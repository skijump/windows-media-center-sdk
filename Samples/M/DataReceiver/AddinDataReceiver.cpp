// AddinDataReceiver.cpp : Implementation of CAddinDataReceiver

#include "stdafx.h"
#include "AddinDataReceiver.h"

#pragma pack (push)
#pragma pack (1)

// Struct used to bundle data
typedef struct _APPLICATION_DATA_TABLE
{
    ITV_PBDA_TAG_ATTRIBUTE tagAttribute;
    GUID gAppGuid;
    GUID gAppGuidTableId;
    int iAppTableVersionNumber;
    int iAppDataLength;
}APPLICATION_DATA_TABLE;

#pragma pack (pop)

// max attribute length
static const UINT g_iMaxAttributeSize = 1024 * 128;

// static PBDATAGTABLE GUID
static GUID g_PbdaTagTable = {0xE1B98D74, 0x9778, 0x4878, 0xB6, 0x64, 0xEB, 0x20, 0x20, 0x36, 0x4D, 0x88};

// typedef for the GetItvDataSource function
typedef HRESULT (*pTVVMDataSource)(IiTvDataSource**);


/*
	STDMETHODIMP CAddinDataReceiver::AdviseConsumer(__in IDataConsumer* pDataConsumer)
	
	An addin calls this to notify the COM object about itself so that it can be notified of incoming
	data from the receiver.

	Input parameter:
		IDataConsumer* pAddin
		A pointer to the Addin which must implement the IDataConsumer interface			
*/

STDMETHODIMP CAddinDataReceiver::AdviseConsumer(__in IDataConsumer* pAddin, __in GUID gAppGuid)
{
	HRESULT hr = E_FAIL;

	if(NULL == pAddin)
		return E_INVALIDARG;

	// store a reference to the pointer to Addin 
	m_pIDataConsumer = pAddin;

	// assign the GUIDS
	m_AppGuid = gAppGuid;
		
	// Setup the data services.
	hr = SetupServices();

	if(FAILED(hr))
	{
		TearDownServices();
		m_pIDataConsumer = NULL;
	}	

	return hr;
}

/*
	STDMETHODIMP CAddinDataReceiver::UnAdviseConsumer()
	
	An addin calls this to notify the COM object that it no longer needs access to the data from 
	the tuner.
*/

STDMETHODIMP CAddinDataReceiver::UnAdviseConsumer()
{
	// The consumer is no longer active.
	m_pIDataConsumer = NULL;

	// Release the Data Attribute	
	m_pItvDataAttribute.Release();

	// Tear down the services.
	TearDownServices();
	
	return S_OK;
}

/*
	STDMETHODIMP CAddinDataReceiver::ReacquireDataSource ()
	
	Reestablishes the connection to the data source. This is called when InvalidateDataSource 
	is called on the Addin.
*/

STDMETHODIMP CAddinDataReceiver::ReacquireDataSource ()
{
	// Tear down the services.
	TearDownServices();

	// Set them back up again.
	return SetupServices();	
}

/*
	STDMETHODIMP CAddinDataReceiver::GetDataSource()

	Loads the McItvVmData.dll returns the handle to the caller 

*/

STDMETHODIMP CAddinDataReceiver::GetDataSource(IiTvDataSource** pDataSource)
{

	HRESULT hr = E_FAIL;

	CAtlString envString;

	// handle to the McItvVmData.dll library
	HMODULE hDllHandle = NULL;	

	// member to hold a pointer to the GetItvDataSource function.
	pTVVMDataSource tvvmDataSource;	

	// Check the parameters
	if((NULL == pDataSource) || (NULL != *pDataSource))
		return E_INVALIDARG;

	// get the complete path to the DLL
	if(!GetCompleteDataDllPath(envString))
	{
		return hr;
	}
	
	// Load the DLL
	hDllHandle = ::LoadLibrary(envString);

	// ensure that we have a valid handle
	if(NULL != hDllHandle)
	{
		// Get the address of GetItvDataSource function
		tvvmDataSource = (pTVVMDataSource)::GetProcAddress(hDllHandle,"GetITVDataSource");

		if(NULL != tvvmDataSource)
		{
			hr = tvvmDataSource(pDataSource);
		}
		else
		{
			hr = HRESULT_FROM_WIN32(GetLastError());
		}
	}
	else
	{
		hr = HRESULT_FROM_WIN32(GetLastError());
	}

	// cleanup	
	if(NULL != hDllHandle)
	{
		::FreeLibrary(hDllHandle);
		hDllHandle = NULL;
	}
	
	return hr;
}

/*
	STDMETHODIMP CAddinDataReceiver::SetupServices()

	Sets up the data source to receive data. 

*/

STDMETHODIMP CAddinDataReceiver::SetupServices()
{
	HRESULT hr = E_FAIL;

	IiTvDataSource* pIiTvDataSource = NULL;

	// Get the IiTvDataAttribute
	hr = m_pItvDataAttribute.CoCreateInstance(__uuidof(iTvDataAttribute), NULL, CLSCTX_INPROC_SERVER);

	if(FAILED(hr))
		return hr;

	// Get the iTv Data source pointer.	
	hr = GetDataSource(&pIiTvDataSource);
	if(FAILED(hr) || (NULL == pIiTvDataSource))
		return hr;

	// Attach to the iTvDataSource pointer.
	m_pDataSource.Attach(pIiTvDataSource);

	IUnknown* pIUnknown = NULL;

	// Since this is not aggregated, IUnknown is implemented by CComObject or CComPolyObject. Calls automatically get forwarded to InternalQueryInterface
	hr = QueryInterface(IID_IUnknown, (void**)&pIUnknown);
	
	// check for errors
	if((FAILED(hr)) || (NULL == pIUnknown))
		return hr;
	
	// Connect to the data source
	return m_pDataSource->Connect(pIUnknown);	
}

/*
	STDMETHODIMP CAddinDataReceiver::TearDownServices()

	Removes the connection to the the data source. 

*/
STDMETHODIMP CAddinDataReceiver::TearDownServices()
{	
	// Disconnect the data source
	if(NULL != m_pDataSource)
	{
		m_pDataSource->Disconnect();
	}

	m_pDataSource = NULL;	

	return S_OK;
}

/*
	STDMETHODIMP CAddinDataReceiver::Stop()

	Disconects the data sourceRemoves the connection to the the data source. 

*/

STDMETHODIMP CAddinDataReceiver::Stop ( )
{
	// Call Stop on the Addin.
	if(NULL != m_pIDataConsumer)
	{
		m_pIDataConsumer->Stop();
	}	

	return S_OK;
}


/*
	STDMETHODIMP CAddinDataReceiver::Receive()
		Forwards data from the tuner to the Addin.

*/

STDMETHODIMP CAddinDataReceiver::Receive (__in unsigned char * piTVData,
							  		      __in unsigned long dwiTVDataLength,
										  __in unsigned char * pAttributes,
										  __in unsigned long dwAttributesLength )
{
	int fixedAppDataTableSize = sizeof(APPLICATION_DATA_TABLE);

	// Check inbound parameters
	if((NULL == piTVData) || (NULL == pAttributes) | ((dwAttributesLength < 0) || (dwAttributesLength > fixedAppDataTableSize + g_iMaxAttributeSize + 1)))
	{
		return E_INVALIDARG;
	}

	// Check if we have a valid customer
	if(NULL == m_pIDataConsumer)
	{
		return S_OK;
	}
	
	HRESULT hr = E_FAIL;	
	LPVOID pbAttribute = NULL;

	_ATLTRY
	{
		// Start the checking phase to determine if the data we got is valid/correct
		hr = m_pItvDataAttribute->Deserialize(pAttributes, dwAttributesLength);
		if(SUCCEEDED(hr))
		{
			// Allocate the memory		
			pbAttribute = CoTaskMemAlloc((int)dwAttributesLength);
			if(NULL == pbAttribute)
			{
				return E_OUTOFMEMORY;		
			}

			// Zero out this memory
			ZeroMemory(pbAttribute,dwAttributesLength);
			
			// Get the value for the attribute
			hr = m_pItvDataAttribute->GetAttribByGUID(__uuidof(ITV_PBDA_TAG_ATTRIBUTE), (BYTE*) pbAttribute ,&dwAttributesLength);
			
			if(SUCCEEDED(hr))
			{
				// cast it to APPLICATION_DATA_TABLE so that we can read off the data
				APPLICATION_DATA_TABLE *appData = static_cast<_APPLICATION_DATA_TABLE*>(pbAttribute);

				if((int)dwAttributesLength >= fixedAppDataTableSize)
				{
					if((appData->tagAttribute.TableUUId == g_PbdaTagTable) && (appData->tagAttribute.TableId >= 0xF0) && (appData->tagAttribute.TableId <= 0xFF))
					{
						int iDataInHostOrder = ntohl(appData->iAppDataLength);

						if ((int)dwAttributesLength >= (fixedAppDataTableSize + iDataInHostOrder))
						{
							if (appData->gAppGuid == m_AppGuid)
							{						
								// Pass the routine to the function that will parse the XML and notify the client.
								hr = ParseXmlStreamAndNotifyConsumer(pbAttribute, iDataInHostOrder, fixedAppDataTableSize);								
							}
						}
					}
				}
			}
		}
	}
	_ATLCATCHALL()
	{		
	}


	if(NULL != pbAttribute)
	{
		CoTaskMemFree(pbAttribute);		
		pbAttribute = NULL;
	}	
	return S_OK;
}

/*
	STDMETHODIMP CAddinDataReceiver::InitializeXMLServices()
		Initializes the Data Structures to parse the XML file with application information.
*/

STDMETHODIMP CAddinDataReceiver::InitializeXMLServices ()
{
	HRESULT hr = E_FAIL;	
	
	// Create an instance of XMLDOMDocument 
	hr = m_pXMLDomDocument.CreateInstance(__uuidof(MSXML2::DOMDocument30),
										  NULL,
										  CLSCTX_INPROC_SERVER);

	if(FAILED(hr))
	{
		return hr;
	}

	// set parameters to false
	m_pXMLDomDocument->put_async(VARIANT_FALSE);
	m_pXMLDomDocument->put_validateOnParse(VARIANT_FALSE);
    m_pXMLDomDocument->put_resolveExternals(VARIANT_FALSE);

	return S_OK;
}

/*
	STDMETHODIMP CAddinDataReceiver::UnInitializeXMLServices()
		Uninitializes the Data Structures after successfully parsing the XML file once.
*/

VOID CAddinDataReceiver::UnInitializeXMLServices()
{
	if(NULL != m_pXMLDomDocument)
	{
		m_pXMLDomDocument.Release();
	}
}

/*
	STDMETHODIMP CAddinDataReceiver::ParseAndNotifyAppAttributes(IXMLDOMElementPtr pIXMLDOMElement)
		Get the attributes of the XML root element and notifies the consumer
*/

STDMETHODIMP CAddinDataReceiver::ParseAndNotifyAppAttributes(IXMLDOMElementPtr pIXMLDOMElement)
{
	// These are the attributes we are interested in
	_variant_t width, height, rows, columns, cellheight, cellwidth;	
	
	// get the attribute value of width	
	width = GetDocumentAttributeAndSetType(pIXMLDOMElement, "width", VT_I4);
	
	// get the attribute value of height	
	height = GetDocumentAttributeAndSetType(pIXMLDOMElement, "height", VT_I4);
	
	// get the attribute value of rows	
	rows = GetDocumentAttributeAndSetType(pIXMLDOMElement, "rows",VT_I4);
	
	// get the attribute value of columns	
	columns = GetDocumentAttributeAndSetType(pIXMLDOMElement, "columns", VT_I4);
	
	// get the attribute value of height	
	cellheight = GetDocumentAttributeAndSetType(pIXMLDOMElement, "cellheight", VT_I4);
	
	// get the attribute value of height	
	cellwidth = GetDocumentAttributeAndSetType(pIXMLDOMElement, "cellwidth", VT_I4);
	
	if(NULL != m_pIDataConsumer)
	{
		m_pIDataConsumer->ReceiveAppData(rows, columns, width, height, cellwidth, cellheight);	
	}	

	return S_OK;
}

/*
	STDMETHODIMP CAddinDataReceiver::ParseAndNotifyInfoTextFormat(IXMLDOMElementPtr pIXMLDOMElement)
		Get the InfoTextFormat attributes and notify the consumer
*/

STDMETHODIMP CAddinDataReceiver::ParseAndNotifyInfoTextFormat(IXMLDOMElementPtr pIXMLDOMElement)
{
	HRESULT hr = E_FAIL;
	IXMLDOMNodeListPtr pInfoTextFormatNodeList = NULL;
	long lElementCount = 0;

	// element(s) to search for parent element
	_bstr_t element = "InfoTextFormat";
	
	// These are the attributes we are interested in
	_variant_t top, left, width, fontSize, fontColor, fontName;

	// get all elements whose name is InfoTextFormat 
	hr = pIXMLDOMElement->getElementsByTagName(element, &pInfoTextFormatNodeList);

	// check error condition
	if((FAILED(hr)) || (NULL == pInfoTextFormatNodeList))
		return hr;

	// Get the count of elements
	hr = pInfoTextFormatNodeList->get_length(&lElementCount);
	
	if(FAILED(hr))
		return hr;

	if(lElementCount > 0)
	{
		do
		{	
			IXMLDOMNodePtr pCurNode = NULL;
			IXMLDOMNamedNodeMapPtr pAttributes = NULL;
			
			// Get the current node
			hr = pInfoTextFormatNodeList->nextNode(&pCurNode);

			// no more nodes.
			if((S_FALSE == hr) && (NULL == pCurNode))
				break;			

			// any other errors bail out.
			if((FAILED(hr)) || (NULL == pCurNode))
				return hr;

			// get the attributes for this element
			hr = pCurNode->get_attributes(&pAttributes);

			// check error
			if((FAILED(hr)) || (NULL == pAttributes))
				return hr;

			// get the fontSize			
			fontSize = GetElementAttributeAndSetType(pAttributes, "fontSize", VT_I4);
			
			// get the fontColor			
			fontColor = GetElementAttributeAndSetType(pAttributes, "fontColor", VT_BSTR);
			
			// get the fontName
			fontName = GetElementAttributeAndSetType(pAttributes, "fontName", VT_BSTR);
			
			// get the left			
			left = GetElementAttributeAndSetType(pAttributes, "left", VT_I4);
			
			// get the top			
			top = GetElementAttributeAndSetType(pAttributes, "top", VT_I4);
			
			// get the width			
			width = GetElementAttributeAndSetType(pAttributes, "width", VT_I4);
			
			// notify the consumer
			if(NULL != m_pIDataConsumer)
			{
				m_pIDataConsumer->ReceiveInfoTextFormat(top, left, width, fontSize, fontColor.bstrVal, fontName.bstrVal);	
			}			
			
			lElementCount--;
		}while(lElementCount > 0);

		// all operations were completed successfully.
		hr = S_OK;
	}
	return hr;
}

/*
	STDMETHODIMP CAddinDataReceiver::ParseAndNotifyChannelBox(IXMLDOMElementPtr pIXMLDOMElement)
		Get the ChannelBox elements attributes and notify the consumer
*/

STDMETHODIMP CAddinDataReceiver::ParseAndNotifyChannelBox(IXMLDOMElementPtr pIXMLDOMElement)
{
	HRESULT hr = E_FAIL;
	IXMLDOMNodeListPtr pChannels = NULL;
	long lElementCount = 0;

	// element(s) to search for parent element
	_bstr_t element = "ChannelBox";	

	// These are the attributes we are interested in
	_variant_t row, column, tuneString, left, top, audiopid, infoChannel, infoTitle, infoTime;

	// get all elements whose name is InfoTextFormat 
	hr = pIXMLDOMElement->getElementsByTagName(element, &pChannels);

	// check the result
	if((FAILED(hr)) || (NULL == pChannels))
		return hr;

	// Get the count of elements
	hr = pChannels->get_length(&lElementCount);

	if(FAILED(hr))
		return hr;

	if(lElementCount > 0)
	{
		do
		{	
			long lProgramInfoCount = 0;
			IXMLDOMNodePtr pCurNode = NULL;
			
			IXMLDOMNamedNodeMapPtr pAttributes = NULL;
			IXMLDOMNodeListPtr pInfoText = NULL;
						
			// Get the current node
			hr = pChannels->nextNode(&pCurNode);

			// no more nodes.
			if((S_FALSE == hr) && (NULL == pCurNode))
				break;			

			// any other errors bail out.
			if(SUCCEEDED(hr))
			{

				// get the attributes for this element
				hr = pCurNode->get_attributes(&pAttributes);

				// check the result.
				if((FAILED(hr)) || (NULL == pAttributes))
					return hr;

				// get the fontSize			
				row = GetElementAttributeAndSetType(pAttributes, "row", VT_I4);

				// get the column
				column = GetElementAttributeAndSetType(pAttributes, "column", VT_I4);

				// get top
				top = GetElementAttributeAndSetType(pAttributes, "top", VT_I4);

				// get left
				left = GetElementAttributeAndSetType(pAttributes, "left", VT_I4);

				// get audiopid
				audiopid = GetElementAttributeAndSetType(pAttributes, "audiopid", VT_I4);

				// get channel
				tuneString = GetElementAttributeAndSetType(pAttributes, "channel", VT_BSTR);

				// get infotextchanne
				infoChannel = GetElementAttributeAndSetType(pAttributes, "InfoTextChannel", VT_BSTR);

				// get description
				infoTitle = GetElementAttributeAndSetType(pAttributes, "InfoTextDescription", VT_BSTR);

				// get time
				infoTime = GetElementAttributeAndSetType(pAttributes, "InfoTextTime", VT_BSTR);

				// notify consumer
				if(NULL != m_pIDataConsumer)
				{
					m_pIDataConsumer->ReceiveCellData(row, column, audiopid, left, top, tuneString.bstrVal, infoChannel.bstrVal, infoTitle.bstrVal, infoTime.bstrVal);
				}
			}
			
		}while(lElementCount > 0);

		// all operations were completed successfully.
		hr = S_OK;
	}
 
	return hr;
}

/*
	STDMETHODIMP CAddinDataReceiver::ParseXmlStreamAndNotifyConsumer (LPVOID pAttributeData, int iDataSize, int ifixedAppDataTableSize)
		Parse the XML data and notify the consumer of the different elements/values.
*/

STDMETHODIMP CAddinDataReceiver::ParseXmlStreamAndNotifyConsumer (LPVOID pAttributeData, int iDataSize, int ifixedAppDataTableSize)
{
	HRESULT hr = E_FAIL;	
	VARIANT_BOOL status;
	IXMLDOMElementPtr pIXMLDOMElement = NULL;
	_bstr_t bstrAddinData;

	// Init XML services.	
	hr = InitializeXMLServices ();

	int iSizeOfEncoding = sizeof(BYTE) * 3;

	// This is the size of the Addin data
	int iByteSize = ifixedAppDataTableSize + iDataSize + 1;	

	// read the XML data for the addin.
	bstrAddinData = ((char*)((BYTE*)pAttributeData + ifixedAppDataTableSize + iSizeOfEncoding));
			
	// Load the XML
	hr = m_pXMLDomDocument->loadXML(bstrAddinData, &status);
	if(SUCCEEDED(hr))
	{
		// Get the document element
		hr = m_pXMLDomDocument->get_documentElement(&pIXMLDOMElement);
		if(SUCCEEDED(hr))
		{
			// Get/Notify the attributes;
			hr = ParseAndNotifyAppAttributes(pIXMLDOMElement);
			if(SUCCEEDED(hr))
			{
				// Get/Notify the infotextformat
				hr = ParseAndNotifyInfoTextFormat(pIXMLDOMElement);
				if(SUCCEEDED(hr))
				{
					// Get/Notify ChannelBox	
					hr = ParseAndNotifyChannelBox(pIXMLDOMElement);					
				}
			}
		}
	}

	// Release XML services
	UnInitializeXMLServices();	

	return hr;
}
						  




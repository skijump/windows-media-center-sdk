// AddinDataReceiver.h : Declaration of the CAddinDataReceiver

#pragma once
#include "resource.h"       // main symbols

#include "DataReceiver_i.h"
#import <McItvVmData.dll> no_namespace, raw_interfaces_only

#import <msxml3.dll>
#include "atlstr.h" 


// Definition for the COM pointer
_COM_SMARTPTR_TYPEDEF(IDataConsumer, __uuidof(IDataConsumer));

// static TVVM Data DLL
static LPCWSTR g_TVVMDataDll = L"\\eHome\\McItvVmData.dll";

#if defined(_WIN32_WCE) && !defined(_CE_DCOM) && !defined(_CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA)
#error "Single-threaded COM objects are not properly supported on Windows CE platform, such as the Windows Mobile platforms that do not include full DCOM support. Define _CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA to force ATL to support creating single-thread COM object's and allow use of it's single-threaded COM object implementations. The threading model in your rgs file was set to 'Free' as that is the only threading model supported in non DCOM Windows CE platforms."
#endif

// CAddinDataReceiver
class ATL_NO_VTABLE CAddinDataReceiver :
	public CComObjectRootEx<CComSingleThreadModel>,
	public CComCoClass<CAddinDataReceiver, &CLSID_AddinDataReceiver>,
	public IAddinDataReceiver,
	public IiTvDataReceiver
{
public:
	CAddinDataReceiver()
	{
		m_pIDataConsumer = NULL;
		m_pDataSource = NULL;
		m_pItvDataAttribute = NULL;		
	}

	DECLARE_REGISTRY_RESOURCEID(IDR_ADDINDATARECEIVER)

	DECLARE_NOT_AGGREGATABLE(CAddinDataReceiver)

	BEGIN_COM_MAP(CAddinDataReceiver)
		COM_INTERFACE_ENTRY(IAddinDataReceiver)
		COM_INTERFACE_ENTRY(IiTvDataReceiver)
	END_COM_MAP()



	DECLARE_PROTECT_FINAL_CONSTRUCT()

	HRESULT FinalConstruct()
	{
		return S_OK;
	}

	void FinalRelease()
	{
	}	

private:

	// Data Members
	IDataConsumerPtr			m_pIDataConsumer;	
	IiTvDataSourcePtr			m_pDataSource;
	CComPtr<IiTvDataAttribute>	m_pItvDataAttribute;
	GUID						m_AppGuid;
	
	// XML Parsing members
	IXMLDOMDocumentPtr			m_pXMLDomDocument;
	
	// Method to setup the underlying data connection needed to receive data.
	STDMETHODIMP SetupServices ();
	STDMETHODIMP TearDownServices ();	
	STDMETHODIMP GetDataSource(IiTvDataSource**);

	BOOL GetCompleteDataDllPath(CAtlString& envStr)
	{
		// ask for the environment variable
		if(envStr.GetEnvironmentVariable(L"windir"))
		{
			envStr += g_TVVMDataDll;			
			return TRUE;
		}		

		return FALSE;
	}


	// Parses the XML stream and creates nodes as required.	
	STDMETHODIMP InitializeXMLServices();
	STDMETHODIMP ParseXmlStreamAndNotifyConsumer(LPVOID, int, int);
	STDMETHODIMP ParseAndNotifyAppAttributes(IXMLDOMElementPtr);
	STDMETHODIMP ParseAndNotifyInfoTextFormat(IXMLDOMElementPtr);
	STDMETHODIMP ParseAndNotifyChannelBox(IXMLDOMElementPtr);
	VOID UnInitializeXMLServices();

	// Helper function that gets the value of an attribute from an attribute list for child Elements.
	inline _variant_t GetElementAttributeAndSetType(IXMLDOMNamedNodeMapPtr pAttributeList, _bstr_t attribute, VARTYPE varChange)
	{
		_variant_t value;
		IXMLDOMNodePtr pValueNode = NULL;			
		
		if(SUCCEEDED(pAttributeList->getNamedItem(attribute, &pValueNode)))		
		{
			if(NULL != pValueNode)
			{
				if(SUCCEEDED(pValueNode->get_nodeValue(&value)))
				{
					value.ChangeType(varChange,NULL);
				}
			}			
		}

		return value;
	}

	// Helper function that gets the value of an attribute from an attribute list for the main document Element.
	inline _variant_t GetDocumentAttributeAndSetType(IXMLDOMElementPtr pIXMLDOMElement, _bstr_t attribute, VARTYPE varChange)
	{
		_variant_t value;

		if(SUCCEEDED(pIXMLDOMElement->getAttribute(attribute, &value)))
		{
			value.ChangeType(varChange,NULL);			
		}		

		return value;
	}	
	
	// IiTvDataReceiver Methods
public:
	STDMETHODIMP get_StreamControlByType(GUID * streamControl)
	{
		if(NULL != streamControl)
		{
			*streamControl = __uuidof(ITVDATA_FILTERING_NONE);
		}
		return S_OK;
	}
	STDMETHODIMP get_CachingLength(unsigned long * cachingLength)
	{
		if(NULL != cachingLength)
		{
			*cachingLength = 0;
		}
		return S_OK;
	}
	STDMETHODIMP Initialize(IiTvDataStreamControl * __MIDL__IiTvDataReceiver0002)
	{
		return S_OK;
	}
	STDMETHODIMP Start()
	{
		return S_OK;
	}	
	STDMETHODIMP Terminate()
	{
		return S_OK;
	}

	STDMETHODIMP Receive(unsigned char * piTVData, unsigned long dwiTVDataLength, unsigned char * pAttributes, unsigned long dwAttributesLength);
	STDMETHODIMP Stop();
		

	// IAddinDataReceiver methods
	STDMETHODIMP AdviseConsumer (__in IDataConsumer*, __in GUID);
	STDMETHODIMP UnAdviseConsumer ();
	STDMETHODIMP ReacquireDataSource ();
};

OBJECT_ENTRY_AUTO(__uuidof(AddinDataReceiver), CAddinDataReceiver)

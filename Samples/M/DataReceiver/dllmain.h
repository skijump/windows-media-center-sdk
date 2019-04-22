// dllmain.h : Declaration of module class.

class CDataReceiverModule : public CAtlDllModuleT< CDataReceiverModule >
{
public :
	DECLARE_LIBID(LIBID_DataReceiverLib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_DATARECEIVER, "{670A46B5-56F2-4CC5-82B2-88D888629D3D}")
};

extern class CDataReceiverModule _AtlModule;

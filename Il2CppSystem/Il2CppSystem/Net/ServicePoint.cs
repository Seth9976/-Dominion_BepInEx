using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net
{
	// Token: 0x02000113 RID: 275
	public class ServicePoint : Object
	{
		// Token: 0x0600115D RID: 4445 RVA: 0x000516B8 File Offset: 0x0004F8B8
		// Note: this type is marked as 'beforefieldinit'.
		static ServicePoint()
		{
			Il2CppClassPointerStore<ServicePoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ServicePoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr);
			ServicePoint.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "uri");
			ServicePoint.NativeFieldInfoPtr_lastDnsResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "lastDnsResolve");
			ServicePoint.NativeFieldInfoPtr_protocolVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "protocolVersion");
			ServicePoint.NativeFieldInfoPtr_host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "host");
			ServicePoint.NativeFieldInfoPtr_usesProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "usesProxy");
			ServicePoint.NativeFieldInfoPtr_sendContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "sendContinue");
			ServicePoint.NativeFieldInfoPtr_useConnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "useConnect");
			ServicePoint.NativeFieldInfoPtr_hostE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "hostE");
			ServicePoint.NativeFieldInfoPtr_useNagle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "useNagle");
			ServicePoint.NativeFieldInfoPtr_endPointCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "endPointCallback");
			ServicePoint.NativeFieldInfoPtr_tcp_keepalive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "tcp_keepalive");
			ServicePoint.NativeFieldInfoPtr_tcp_keepalive_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "tcp_keepalive_time");
			ServicePoint.NativeFieldInfoPtr_tcp_keepalive_interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "tcp_keepalive_interval");
			ServicePoint.NativeFieldInfoPtr__Scheduler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "<Scheduler>k__BackingField");
			ServicePoint.NativeFieldInfoPtr_m_ServerCertificateOrBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "m_ServerCertificateOrBytes");
			ServicePoint.NativeFieldInfoPtr_m_ClientCertificateOrBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, "m_ClientCertificateOrBytes");
			ServicePoint.NativeMethodInfoPtr__ctor_Internal_Void_Uri_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665694);
			ServicePoint.NativeMethodInfoPtr_get_Scheduler_Internal_get_ServicePointScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665695);
			ServicePoint.NativeMethodInfoPtr_get_Address_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665696);
			ServicePoint.NativeMethodInfoPtr_get_ConnectionLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665697);
			ServicePoint.NativeMethodInfoPtr_get_ProtocolVersion_Public_Virtual_New_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665698);
			ServicePoint.NativeMethodInfoPtr_set_Expect100Continue_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665699);
			ServicePoint.NativeMethodInfoPtr_get_UseNagleAlgorithm_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665700);
			ServicePoint.NativeMethodInfoPtr_set_UseNagleAlgorithm_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665701);
			ServicePoint.NativeMethodInfoPtr_get_SendContinue_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665702);
			ServicePoint.NativeMethodInfoPtr_set_SendContinue_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665703);
			ServicePoint.NativeMethodInfoPtr_SetTcpKeepAlive_Public_Void_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665704);
			ServicePoint.NativeMethodInfoPtr_KeepAliveSetup_Internal_Void_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665705);
			ServicePoint.NativeMethodInfoPtr_PutBytes_Private_Static_Void_Il2CppStructArray_1_Byte_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665706);
			ServicePoint.NativeMethodInfoPtr_get_UsesProxy_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665707);
			ServicePoint.NativeMethodInfoPtr_set_UsesProxy_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665708);
			ServicePoint.NativeMethodInfoPtr_get_UseConnect_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665709);
			ServicePoint.NativeMethodInfoPtr_set_UseConnect_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665710);
			ServicePoint.NativeMethodInfoPtr_get_HasTimedOut_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665711);
			ServicePoint.NativeMethodInfoPtr_get_HostEntry_Internal_get_IPHostEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665712);
			ServicePoint.NativeMethodInfoPtr_SetVersion_Internal_Void_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665713);
			ServicePoint.NativeMethodInfoPtr_SendRequest_Internal_Void_WebOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665714);
			ServicePoint.NativeMethodInfoPtr_UpdateServerCertificate_Internal_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665715);
			ServicePoint.NativeMethodInfoPtr_UpdateClientCertificate_Internal_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665716);
			ServicePoint.NativeMethodInfoPtr_CallEndPointDelegate_Internal_Boolean_Socket_IPEndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr, 100665717);
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00051A08 File Offset: 0x0004FC08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52869, RefRangeEnd = 52870, XrefRangeStart = 52832, XrefRangeEnd = 52869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServicePoint(Uri uri, int connectionLimit, int maxIdleTime)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePoint>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref connectionLimit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxIdleTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr__ctor_Internal_Void_Uri_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x00051A70 File Offset: 0x0004FC70
		public unsafe ServicePointScheduler Scheduler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_Scheduler_Internal_get_ServicePointScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x00051AB0 File Offset: 0x0004FCB0
		public unsafe Uri Address
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_Address_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x00051AF0 File Offset: 0x0004FCF0
		public unsafe int ConnectionLimit
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 52870, RefRangeEnd = 52873, XrefRangeStart = 52870, XrefRangeEnd = 52870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_ConnectionLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x00051B2C File Offset: 0x0004FD2C
		public unsafe virtual Version ProtocolVersion
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServicePoint.NativeMethodInfoPtr_get_ProtocolVersion_Public_Virtual_New_get_Version_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (set) Token: 0x06001163 RID: 4451 RVA: 0x00051B78 File Offset: 0x0004FD78
		public unsafe bool Expect100Continue
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_set_Expect100Continue_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x00051BB8 File Offset: 0x0004FDB8
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x00051BF4 File Offset: 0x0004FDF4
		public unsafe bool UseNagleAlgorithm
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_UseNagleAlgorithm_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_set_UseNagleAlgorithm_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x00051C34 File Offset: 0x0004FE34
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x00051C70 File Offset: 0x0004FE70
		public unsafe bool SendContinue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 52875, RefRangeEnd = 52876, XrefRangeStart = 52873, XrefRangeEnd = 52875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_SendContinue_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_set_SendContinue_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00051CB0 File Offset: 0x0004FEB0
		[CallerCount(0)]
		public unsafe void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepAliveTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepAliveInterval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_SetTcpKeepAlive_Public_Void_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00051D0C File Offset: 0x0004FF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52876, XrefRangeEnd = 52886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KeepAliveSetup(Socket socket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_KeepAliveSetup_Internal_Void_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00051D50 File Offset: 0x0004FF50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 52890, RefRangeEnd = 52893, XrefRangeStart = 52886, XrefRangeEnd = 52890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PutBytes(Il2CppStructArray<byte> bytes, uint v, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_PutBytes_Private_Static_Void_Il2CppStructArray_1_Byte_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x00051DA4 File Offset: 0x0004FFA4
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x00051DE0 File Offset: 0x0004FFE0
		public unsafe bool UsesProxy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_UsesProxy_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_set_UsesProxy_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x00051E20 File Offset: 0x00050020
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x00051E5C File Offset: 0x0005005C
		public unsafe bool UseConnect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_UseConnect_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_set_UseConnect_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x00051E9C File Offset: 0x0005009C
		public unsafe bool HasTimedOut
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52893, XrefRangeEnd = 52903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_HasTimedOut_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x00051ED8 File Offset: 0x000500D8
		public unsafe IPHostEntry HostEntry
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 52950, RefRangeEnd = 52953, XrefRangeStart = 52903, XrefRangeEnd = 52950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_get_HostEntry_Internal_get_IPHostEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00051F18 File Offset: 0x00050118
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVersion(Version version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(version);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_SetVersion_Internal_Void_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x00051F5C File Offset: 0x0005015C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52957, RefRangeEnd = 52958, XrefRangeStart = 52953, XrefRangeEnd = 52957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRequest(WebOperation operation, string groupName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(groupName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_SendRequest_Internal_Void_WebOperation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00051FB0 File Offset: 0x000501B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52958, RefRangeEnd = 52959, XrefRangeStart = 52958, XrefRangeEnd = 52958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateServerCertificate(X509Certificate certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_UpdateServerCertificate_Internal_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x00051FF4 File Offset: 0x000501F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 52959, RefRangeEnd = 52961, XrefRangeStart = 52959, XrefRangeEnd = 52959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateClientCertificate(X509Certificate certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_UpdateClientCertificate_Internal_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00052038 File Offset: 0x00050238
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52973, RefRangeEnd = 52974, XrefRangeStart = 52961, XrefRangeEnd = 52973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CallEndPointDelegate(Socket sock, IPEndPoint remote)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sock);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remote);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePoint.NativeMethodInfoPtr_CallEndPointDelegate_Internal_Boolean_Socket_IPEndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0000908C File Offset: 0x0000728C
		public ServicePoint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x00052098 File Offset: 0x00050298
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x00009095 File Offset: 0x00007295
		public unsafe Uri uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x000520C8 File Offset: 0x000502C8
		// (set) Token: 0x0600117A RID: 4474 RVA: 0x000090B4 File Offset: 0x000072B4
		public unsafe DateTime lastDnsResolve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_lastDnsResolve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_lastDnsResolve)) = value;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x000520F0 File Offset: 0x000502F0
		// (set) Token: 0x0600117C RID: 4476 RVA: 0x000090CF File Offset: 0x000072CF
		public unsafe Version protocolVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_protocolVersion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_protocolVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x00052120 File Offset: 0x00050320
		// (set) Token: 0x0600117E RID: 4478 RVA: 0x000090EE File Offset: 0x000072EE
		public unsafe IPHostEntry host
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_host);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPHostEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_host), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x00052150 File Offset: 0x00050350
		// (set) Token: 0x06001180 RID: 4480 RVA: 0x0000910D File Offset: 0x0000730D
		public unsafe bool usesProxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_usesProxy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_usesProxy)) = value;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x00052178 File Offset: 0x00050378
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x00009128 File Offset: 0x00007328
		public unsafe bool sendContinue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_sendContinue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_sendContinue)) = value;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x000521A0 File Offset: 0x000503A0
		// (set) Token: 0x06001184 RID: 4484 RVA: 0x00009143 File Offset: 0x00007343
		public unsafe bool useConnect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_useConnect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_useConnect)) = value;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x000521C8 File Offset: 0x000503C8
		// (set) Token: 0x06001186 RID: 4486 RVA: 0x0000915E File Offset: 0x0000735E
		public unsafe Object hostE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_hostE);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_hostE), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x000521F8 File Offset: 0x000503F8
		// (set) Token: 0x06001188 RID: 4488 RVA: 0x0000917D File Offset: 0x0000737D
		public unsafe bool useNagle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_useNagle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_useNagle)) = value;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x00052220 File Offset: 0x00050420
		// (set) Token: 0x0600118A RID: 4490 RVA: 0x00009198 File Offset: 0x00007398
		public unsafe BindIPEndPoint endPointCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_endPointCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BindIPEndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_endPointCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x00052250 File Offset: 0x00050450
		// (set) Token: 0x0600118C RID: 4492 RVA: 0x000091B7 File Offset: 0x000073B7
		public unsafe bool tcp_keepalive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_tcp_keepalive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_tcp_keepalive)) = value;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x00052278 File Offset: 0x00050478
		// (set) Token: 0x0600118E RID: 4494 RVA: 0x000091D2 File Offset: 0x000073D2
		public unsafe int tcp_keepalive_time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_tcp_keepalive_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_tcp_keepalive_time)) = value;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x000522A0 File Offset: 0x000504A0
		// (set) Token: 0x06001190 RID: 4496 RVA: 0x000091ED File Offset: 0x000073ED
		public unsafe int tcp_keepalive_interval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_tcp_keepalive_interval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_tcp_keepalive_interval)) = value;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x000522C8 File Offset: 0x000504C8
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x00009208 File Offset: 0x00007408
		public unsafe ServicePointScheduler _Scheduler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr__Scheduler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePointScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr__Scheduler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x000522F8 File Offset: 0x000504F8
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x00009227 File Offset: 0x00007427
		public unsafe Object m_ServerCertificateOrBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_m_ServerCertificateOrBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_m_ServerCertificateOrBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x00052328 File Offset: 0x00050528
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x00009246 File Offset: 0x00007446
		public unsafe Object m_ClientCertificateOrBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_m_ClientCertificateOrBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServicePoint.NativeFieldInfoPtr_m_ClientCertificateOrBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeFieldInfoPtr_uri;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeFieldInfoPtr_lastDnsResolve;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeFieldInfoPtr_protocolVersion;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeFieldInfoPtr_host;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeFieldInfoPtr_usesProxy;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeFieldInfoPtr_sendContinue;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeFieldInfoPtr_useConnect;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeFieldInfoPtr_hostE;

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeFieldInfoPtr_useNagle;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeFieldInfoPtr_endPointCallback;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeFieldInfoPtr_tcp_keepalive;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeFieldInfoPtr_tcp_keepalive_time;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeFieldInfoPtr_tcp_keepalive_interval;

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeFieldInfoPtr__Scheduler_k__BackingField;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeFieldInfoPtr_m_ServerCertificateOrBytes;

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeFieldInfoPtr_m_ClientCertificateOrBytes;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Uri_Int32_Int32_0;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeMethodInfoPtr_get_Scheduler_Internal_get_ServicePointScheduler_0;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeMethodInfoPtr_get_Address_Public_get_Uri_0;

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectionLimit_Public_get_Int32_0;

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeMethodInfoPtr_get_ProtocolVersion_Public_Virtual_New_get_Version_0;

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeMethodInfoPtr_set_Expect100Continue_Public_set_Void_Boolean_0;

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeMethodInfoPtr_get_UseNagleAlgorithm_Public_get_Boolean_0;

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeMethodInfoPtr_set_UseNagleAlgorithm_Public_set_Void_Boolean_0;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeMethodInfoPtr_get_SendContinue_Internal_get_Boolean_0;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeMethodInfoPtr_set_SendContinue_Internal_set_Void_Boolean_0;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeMethodInfoPtr_SetTcpKeepAlive_Public_Void_Boolean_Int32_Int32_0;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeMethodInfoPtr_KeepAliveSetup_Internal_Void_Socket_0;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeMethodInfoPtr_PutBytes_Private_Static_Void_Il2CppStructArray_1_Byte_UInt32_Int32_0;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeMethodInfoPtr_get_UsesProxy_Internal_get_Boolean_0;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeMethodInfoPtr_set_UsesProxy_Internal_set_Void_Boolean_0;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr_get_UseConnect_Internal_get_Boolean_0;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeMethodInfoPtr_set_UseConnect_Internal_set_Void_Boolean_0;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeMethodInfoPtr_get_HasTimedOut_Private_get_Boolean_0;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeMethodInfoPtr_get_HostEntry_Internal_get_IPHostEntry_0;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeMethodInfoPtr_SetVersion_Internal_Void_Version_0;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeMethodInfoPtr_SendRequest_Internal_Void_WebOperation_String_0;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeMethodInfoPtr_UpdateServerCertificate_Internal_Void_X509Certificate_0;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeMethodInfoPtr_UpdateClientCertificate_Internal_Void_X509Certificate_0;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeMethodInfoPtr_CallEndPointDelegate_Internal_Boolean_Socket_IPEndPoint_0;
	}
}

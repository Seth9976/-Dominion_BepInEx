using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x0200011A RID: 282
	public class WebConnectionTunnel : Object
	{
		// Token: 0x06001254 RID: 4692 RVA: 0x00054D70 File Offset: 0x00052F70
		// Note: this type is marked as 'beforefieldinit'.
		static WebConnectionTunnel()
		{
			Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebConnectionTunnel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr);
			WebConnectionTunnel.NativeFieldInfoPtr__Request_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<Request>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__ConnectUri_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<ConnectUri>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr_connectRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "connectRequest");
			WebConnectionTunnel.NativeFieldInfoPtr_ntlmAuthState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "ntlmAuthState");
			WebConnectionTunnel.NativeFieldInfoPtr__Success_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<Success>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__CloseConnection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<CloseConnection>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__StatusCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<StatusCode>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__StatusDescription_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<StatusDescription>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__Challenge_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<Challenge>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__Headers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<Headers>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__ProxyVersion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<ProxyVersion>k__BackingField");
			WebConnectionTunnel.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<Data>k__BackingField");
			WebConnectionTunnel.NativeMethodInfoPtr_get_Request_Public_get_HttpWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665835);
			WebConnectionTunnel.NativeMethodInfoPtr_get_ConnectUri_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665836);
			WebConnectionTunnel.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665837);
			WebConnectionTunnel.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665838);
			WebConnectionTunnel.NativeMethodInfoPtr_set_Success_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665839);
			WebConnectionTunnel.NativeMethodInfoPtr_get_CloseConnection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665840);
			WebConnectionTunnel.NativeMethodInfoPtr_set_CloseConnection_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665841);
			WebConnectionTunnel.NativeMethodInfoPtr_get_StatusCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665842);
			WebConnectionTunnel.NativeMethodInfoPtr_set_StatusCode_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665843);
			WebConnectionTunnel.NativeMethodInfoPtr_set_StatusDescription_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665844);
			WebConnectionTunnel.NativeMethodInfoPtr_get_Challenge_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665845);
			WebConnectionTunnel.NativeMethodInfoPtr_set_Challenge_Private_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665846);
			WebConnectionTunnel.NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665847);
			WebConnectionTunnel.NativeMethodInfoPtr_set_Headers_Private_set_Void_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665848);
			WebConnectionTunnel.NativeMethodInfoPtr_get_ProxyVersion_Public_get_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665849);
			WebConnectionTunnel.NativeMethodInfoPtr_set_ProxyVersion_Private_set_Void_Version_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665850);
			WebConnectionTunnel.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665851);
			WebConnectionTunnel.NativeMethodInfoPtr_set_Data_Private_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665852);
			WebConnectionTunnel.NativeMethodInfoPtr_Initialize_Internal_Task_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665853);
			WebConnectionTunnel.NativeMethodInfoPtr_ReadHeaders_Private_Task_1_ValueTuple_3_WebHeaderCollection_Il2CppStructArray_1_Byte_Int32_Stream_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665854);
			WebConnectionTunnel.NativeMethodInfoPtr_FlushContents_Private_Void_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, 100665855);
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x00055034 File Offset: 0x00053234
		public unsafe HttpWebRequest Request
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_Request_Public_get_HttpWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x00055074 File Offset: 0x00053274
		public unsafe Uri ConnectUri
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_ConnectUri_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x000550B4 File Offset: 0x000532B4
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebConnectionTunnel(HttpWebRequest request, Uri connectUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(connectUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x00055114 File Offset: 0x00053314
		// (set) Token: 0x06001259 RID: 4697 RVA: 0x00055150 File Offset: 0x00053350
		public unsafe bool Success
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_Success_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x00055190 File Offset: 0x00053390
		// (set) Token: 0x0600125B RID: 4699 RVA: 0x000551CC File Offset: 0x000533CC
		public unsafe bool CloseConnection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_CloseConnection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_CloseConnection_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x0005520C File Offset: 0x0005340C
		// (set) Token: 0x0600125D RID: 4701 RVA: 0x00055248 File Offset: 0x00053448
		public unsafe int StatusCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_StatusCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_StatusCode_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005ED RID: 1517
		// (set) Token: 0x0600125E RID: 4702 RVA: 0x00055288 File Offset: 0x00053488
		public unsafe string StatusDescription
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_StatusDescription_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x000552CC File Offset: 0x000534CC
		// (set) Token: 0x06001260 RID: 4704 RVA: 0x0005530C File Offset: 0x0005350C
		public unsafe Il2CppStringArray Challenge
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_Challenge_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_Challenge_Private_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x00055350 File Offset: 0x00053550
		// (set) Token: 0x06001262 RID: 4706 RVA: 0x00055390 File Offset: 0x00053590
		public unsafe WebHeaderCollection Headers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_Headers_Private_set_Void_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x000553D4 File Offset: 0x000535D4
		// (set) Token: 0x06001264 RID: 4708 RVA: 0x00055414 File Offset: 0x00053614
		public unsafe Version ProxyVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_ProxyVersion_Public_get_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_ProxyVersion_Private_set_Void_Version_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x00055458 File Offset: 0x00053658
		// (set) Token: 0x06001266 RID: 4710 RVA: 0x00055498 File Offset: 0x00053698
		public unsafe Il2CppStructArray<byte> Data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_set_Data_Private_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x000554DC File Offset: 0x000536DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54281, RefRangeEnd = 54282, XrefRangeStart = 54273, XrefRangeEnd = 54281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task Initialize(Stream stream, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_Initialize_Internal_Task_Stream_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00055544 File Offset: 0x00053744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54294, RefRangeEnd = 54295, XrefRangeStart = 54282, XrefRangeEnd = 54294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>> ReadHeaders(Stream stream, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_ReadHeaders_Private_Task_1_ValueTuple_3_WebHeaderCollection_Il2CppStructArray_1_Byte_Int32_Stream_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>>(intPtr3) : null;
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x000555AC File Offset: 0x000537AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54298, RefRangeEnd = 54299, XrefRangeStart = 54295, XrefRangeEnd = 54298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushContents(Stream stream, int contentLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contentLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel.NativeMethodInfoPtr_FlushContents_Private_Void_Stream_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x00009752 File Offset: 0x00007952
		public WebConnectionTunnel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x000555FC File Offset: 0x000537FC
		// (set) Token: 0x0600126C RID: 4716 RVA: 0x0000975B File Offset: 0x0000795B
		public unsafe HttpWebRequest _Request_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Request_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Request_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x0005562C File Offset: 0x0005382C
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x0000977A File Offset: 0x0000797A
		public unsafe Uri _ConnectUri_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__ConnectUri_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__ConnectUri_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x0005565C File Offset: 0x0005385C
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x00009799 File Offset: 0x00007999
		public unsafe HttpWebRequest connectRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr_connectRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr_connectRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x0005568C File Offset: 0x0005388C
		// (set) Token: 0x06001272 RID: 4722 RVA: 0x000097B8 File Offset: 0x000079B8
		public unsafe WebConnectionTunnel.NtlmAuthState ntlmAuthState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr_ntlmAuthState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr_ntlmAuthState)) = value;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x000556B4 File Offset: 0x000538B4
		// (set) Token: 0x06001274 RID: 4724 RVA: 0x000097D3 File Offset: 0x000079D3
		public unsafe bool _Success_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Success_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Success_k__BackingField)) = value;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001275 RID: 4725 RVA: 0x000556DC File Offset: 0x000538DC
		// (set) Token: 0x06001276 RID: 4726 RVA: 0x000097EE File Offset: 0x000079EE
		public unsafe bool _CloseConnection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__CloseConnection_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__CloseConnection_k__BackingField)) = value;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x00055704 File Offset: 0x00053904
		// (set) Token: 0x06001278 RID: 4728 RVA: 0x00009809 File Offset: 0x00007A09
		public unsafe int _StatusCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__StatusCode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__StatusCode_k__BackingField)) = value;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x0005572C File Offset: 0x0005392C
		// (set) Token: 0x0600127A RID: 4730 RVA: 0x00009824 File Offset: 0x00007A24
		public unsafe string _StatusDescription_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__StatusDescription_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__StatusDescription_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x00055754 File Offset: 0x00053954
		// (set) Token: 0x0600127C RID: 4732 RVA: 0x00009843 File Offset: 0x00007A43
		public unsafe Il2CppStringArray _Challenge_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Challenge_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Challenge_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x00055784 File Offset: 0x00053984
		// (set) Token: 0x0600127E RID: 4734 RVA: 0x00009862 File Offset: 0x00007A62
		public unsafe WebHeaderCollection _Headers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Headers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Headers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x000557B4 File Offset: 0x000539B4
		// (set) Token: 0x06001280 RID: 4736 RVA: 0x00009881 File Offset: 0x00007A81
		public unsafe Version _ProxyVersion_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__ProxyVersion_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__ProxyVersion_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x000557E4 File Offset: 0x000539E4
		// (set) Token: 0x06001282 RID: 4738 RVA: 0x000098A0 File Offset: 0x00007AA0
		public unsafe Il2CppStructArray<byte> _Data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Data_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeFieldInfoPtr__Request_k__BackingField;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeFieldInfoPtr__ConnectUri_k__BackingField;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeFieldInfoPtr_connectRequest;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeFieldInfoPtr_ntlmAuthState;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeFieldInfoPtr__Success_k__BackingField;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeFieldInfoPtr__CloseConnection_k__BackingField;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeFieldInfoPtr__StatusCode_k__BackingField;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeFieldInfoPtr__StatusDescription_k__BackingField;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeFieldInfoPtr__Challenge_k__BackingField;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeFieldInfoPtr__Headers_k__BackingField;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeFieldInfoPtr__ProxyVersion_k__BackingField;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeMethodInfoPtr_get_Request_Public_get_HttpWebRequest_0;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectUri_Public_get_Uri_0;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpWebRequest_Uri_0;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeMethodInfoPtr_get_Success_Public_get_Boolean_0;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeMethodInfoPtr_set_Success_Private_set_Void_Boolean_0;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeMethodInfoPtr_get_CloseConnection_Public_get_Boolean_0;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeMethodInfoPtr_set_CloseConnection_Private_set_Void_Boolean_0;

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusCode_Public_get_Int32_0;

		// Token: 0x04000E2A RID: 3626
		private static readonly IntPtr NativeMethodInfoPtr_set_StatusCode_Private_set_Void_Int32_0;

		// Token: 0x04000E2B RID: 3627
		private static readonly IntPtr NativeMethodInfoPtr_set_StatusDescription_Private_set_Void_String_0;

		// Token: 0x04000E2C RID: 3628
		private static readonly IntPtr NativeMethodInfoPtr_get_Challenge_Public_get_Il2CppStringArray_0;

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeMethodInfoPtr_set_Challenge_Private_set_Void_Il2CppStringArray_0;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeMethodInfoPtr_get_Headers_Public_get_WebHeaderCollection_0;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeMethodInfoPtr_set_Headers_Private_set_Void_WebHeaderCollection_0;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeMethodInfoPtr_get_ProxyVersion_Public_get_Version_0;

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeMethodInfoPtr_set_ProxyVersion_Private_set_Void_Version_0;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Private_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Task_Stream_CancellationToken_0;

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeMethodInfoPtr_ReadHeaders_Private_Task_1_ValueTuple_3_WebHeaderCollection_Il2CppStructArray_1_Byte_Int32_Stream_CancellationToken_0;

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeMethodInfoPtr_FlushContents_Private_Void_Stream_Int32_0;

		// Token: 0x020001D6 RID: 470
		public enum NtlmAuthState
		{
			// Token: 0x0400145C RID: 5212
			None,
			// Token: 0x0400145D RID: 5213
			Challenge,
			// Token: 0x0400145E RID: 5214
			Response
		}

		// Token: 0x020001D7 RID: 471
		[ObfuscatedName("System.Net.WebConnectionTunnel+<Initialize>d__42")]
		public sealed class _Initialize_d__42 : ValueType
		{
			// Token: 0x06001A26 RID: 6694 RVA: 0x0006DB04 File Offset: 0x0006BD04
			// Note: this type is marked as 'beforefieldinit'.
			static _Initialize_d__42()
			{
				Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<Initialize>d__42");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr);
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "<>1__state");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "<>t__builder");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "<>4__this");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "stream");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "cancellationToken");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr__have_auth_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "<have_auth>5__1");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "<>u__1");
				WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, "<>u__2");
				WebConnectionTunnel._Initialize_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, 100665856);
				WebConnectionTunnel._Initialize_d__42.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr, 100665857);
			}

			// Token: 0x06001A27 RID: 6695 RVA: 0x0006DBF8 File Offset: 0x0006BDF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54070, XrefRangeEnd = 54203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel._Initialize_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A28 RID: 6696 RVA: 0x0006DC30 File Offset: 0x0006BE30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel._Initialize_d__42.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A29 RID: 6697 RVA: 0x0000E066 File Offset: 0x0000C266
			public _Initialize_d__42(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001A2A RID: 6698 RVA: 0x0000E06F File Offset: 0x0000C26F
			public _Initialize_d__42()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnectionTunnel._Initialize_d__42>.NativeClassPtr))
			{
			}

			// Token: 0x17000861 RID: 2145
			// (get) Token: 0x06001A2B RID: 6699 RVA: 0x0006DC78 File Offset: 0x0006BE78
			// (set) Token: 0x06001A2C RID: 6700 RVA: 0x0000E081 File Offset: 0x0000C281
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000862 RID: 2146
			// (get) Token: 0x06001A2D RID: 6701 RVA: 0x0006DCA0 File Offset: 0x0006BEA0
			// (set) Token: 0x06001A2E RID: 6702 RVA: 0x0000E09C File Offset: 0x0000C29C
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000863 RID: 2147
			// (get) Token: 0x06001A2F RID: 6703 RVA: 0x0006DCD0 File Offset: 0x0006BED0
			// (set) Token: 0x06001A30 RID: 6704 RVA: 0x0000E0CA File Offset: 0x0000C2CA
			public unsafe WebConnectionTunnel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnectionTunnel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000864 RID: 2148
			// (get) Token: 0x06001A31 RID: 6705 RVA: 0x0006DD00 File Offset: 0x0006BF00
			// (set) Token: 0x06001A32 RID: 6706 RVA: 0x0000E0E9 File Offset: 0x0000C2E9
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000865 RID: 2149
			// (get) Token: 0x06001A33 RID: 6707 RVA: 0x0006DD30 File Offset: 0x0006BF30
			// (set) Token: 0x06001A34 RID: 6708 RVA: 0x0000E108 File Offset: 0x0000C308
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000866 RID: 2150
			// (get) Token: 0x06001A35 RID: 6709 RVA: 0x0006DD60 File Offset: 0x0006BF60
			// (set) Token: 0x06001A36 RID: 6710 RVA: 0x0000E136 File Offset: 0x0000C336
			public unsafe bool _have_auth_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr__have_auth_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr__have_auth_5__1)) = value;
				}
			}

			// Token: 0x17000867 RID: 2151
			// (get) Token: 0x06001A37 RID: 6711 RVA: 0x0006DD88 File Offset: 0x0006BF88
			// (set) Token: 0x06001A38 RID: 6712 RVA: 0x0000E151 File Offset: 0x0000C351
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000868 RID: 2152
			// (get) Token: 0x06001A39 RID: 6713 RVA: 0x0006DDB8 File Offset: 0x0006BFB8
			// (set) Token: 0x06001A3A RID: 6714 RVA: 0x0000E17F File Offset: 0x0000C37F
			public ConfiguredTaskAwaitable<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._Initialize_d__42.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400145F RID: 5215
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001460 RID: 5216
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001461 RID: 5217
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001462 RID: 5218
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x04001463 RID: 5219
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001464 RID: 5220
			private static readonly IntPtr NativeFieldInfoPtr__have_auth_5__1;

			// Token: 0x04001465 RID: 5221
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001466 RID: 5222
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04001467 RID: 5223
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001468 RID: 5224
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001D8 RID: 472
		[ObfuscatedName("System.Net.WebConnectionTunnel+<ReadHeaders>d__43")]
		public sealed class _ReadHeaders_d__43 : ValueType
		{
			// Token: 0x06001A3B RID: 6715 RVA: 0x0006DDE8 File Offset: 0x0006BFE8
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadHeaders_d__43()
			{
				Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebConnectionTunnel>.NativeClassPtr, "<ReadHeaders>d__43");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr);
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<>1__state");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<>t__builder");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "cancellationToken");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "stream");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__buffer_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<buffer>5__1");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__ms_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<ms>5__2");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<>4__this");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__retBuffer_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<retBuffer>5__3");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__status_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<status>5__4");
				WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, "<>u__1");
				WebConnectionTunnel._ReadHeaders_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, 100665858);
				WebConnectionTunnel._ReadHeaders_d__43.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr, 100665859);
			}

			// Token: 0x06001A3C RID: 6716 RVA: 0x0006DF04 File Offset: 0x0006C104
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54203, XrefRangeEnd = 54270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel._ReadHeaders_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A3D RID: 6717 RVA: 0x0006DF3C File Offset: 0x0006C13C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54270, XrefRangeEnd = 54273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnectionTunnel._ReadHeaders_d__43.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A3E RID: 6718 RVA: 0x0000E1AD File Offset: 0x0000C3AD
			public _ReadHeaders_d__43(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001A3F RID: 6719 RVA: 0x0000E1B6 File Offset: 0x0000C3B6
			public _ReadHeaders_d__43()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnectionTunnel._ReadHeaders_d__43>.NativeClassPtr))
			{
			}

			// Token: 0x17000869 RID: 2153
			// (get) Token: 0x06001A40 RID: 6720 RVA: 0x0006DF84 File Offset: 0x0006C184
			// (set) Token: 0x06001A41 RID: 6721 RVA: 0x0000E1C8 File Offset: 0x0000C3C8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700086A RID: 2154
			// (get) Token: 0x06001A42 RID: 6722 RVA: 0x0006DFAC File Offset: 0x0006C1AC
			// (set) Token: 0x06001A43 RID: 6723 RVA: 0x0000E1E3 File Offset: 0x0000C3E3
			public AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, Il2CppStructArray<byte>, int>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700086B RID: 2155
			// (get) Token: 0x06001A44 RID: 6724 RVA: 0x0006DFDC File Offset: 0x0006C1DC
			// (set) Token: 0x06001A45 RID: 6725 RVA: 0x0000E211 File Offset: 0x0000C411
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700086C RID: 2156
			// (get) Token: 0x06001A46 RID: 6726 RVA: 0x0006E00C File Offset: 0x0006C20C
			// (set) Token: 0x06001A47 RID: 6727 RVA: 0x0000E23F File Offset: 0x0000C43F
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700086D RID: 2157
			// (get) Token: 0x06001A48 RID: 6728 RVA: 0x0006E03C File Offset: 0x0006C23C
			// (set) Token: 0x06001A49 RID: 6729 RVA: 0x0000E25E File Offset: 0x0000C45E
			public unsafe Il2CppStructArray<byte> _buffer_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__buffer_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__buffer_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700086E RID: 2158
			// (get) Token: 0x06001A4A RID: 6730 RVA: 0x0006E06C File Offset: 0x0006C26C
			// (set) Token: 0x06001A4B RID: 6731 RVA: 0x0000E27D File Offset: 0x0000C47D
			public unsafe MemoryStream _ms_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__ms_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__ms_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700086F RID: 2159
			// (get) Token: 0x06001A4C RID: 6732 RVA: 0x0006E09C File Offset: 0x0006C29C
			// (set) Token: 0x06001A4D RID: 6733 RVA: 0x0000E29C File Offset: 0x0000C49C
			public unsafe WebConnectionTunnel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnectionTunnel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000870 RID: 2160
			// (get) Token: 0x06001A4E RID: 6734 RVA: 0x0006E0CC File Offset: 0x0006C2CC
			// (set) Token: 0x06001A4F RID: 6735 RVA: 0x0000E2BB File Offset: 0x0000C4BB
			public unsafe Il2CppStructArray<byte> _retBuffer_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__retBuffer_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__retBuffer_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000871 RID: 2161
			// (get) Token: 0x06001A50 RID: 6736 RVA: 0x0006E0FC File Offset: 0x0006C2FC
			// (set) Token: 0x06001A51 RID: 6737 RVA: 0x0000E2DA File Offset: 0x0000C4DA
			public unsafe int _status_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__status_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr__status_5__4)) = value;
				}
			}

			// Token: 0x17000872 RID: 2162
			// (get) Token: 0x06001A52 RID: 6738 RVA: 0x0006E124 File Offset: 0x0006C324
			// (set) Token: 0x06001A53 RID: 6739 RVA: 0x0000E2F5 File Offset: 0x0000C4F5
			public ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnectionTunnel._ReadHeaders_d__43.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001469 RID: 5225
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400146A RID: 5226
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400146B RID: 5227
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400146C RID: 5228
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x0400146D RID: 5229
			private static readonly IntPtr NativeFieldInfoPtr__buffer_5__1;

			// Token: 0x0400146E RID: 5230
			private static readonly IntPtr NativeFieldInfoPtr__ms_5__2;

			// Token: 0x0400146F RID: 5231
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001470 RID: 5232
			private static readonly IntPtr NativeFieldInfoPtr__retBuffer_5__3;

			// Token: 0x04001471 RID: 5233
			private static readonly IntPtr NativeFieldInfoPtr__status_5__4;

			// Token: 0x04001472 RID: 5234
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001473 RID: 5235
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001474 RID: 5236
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}

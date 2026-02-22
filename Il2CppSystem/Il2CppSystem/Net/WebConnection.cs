using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Net.Security;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net
{
	// Token: 0x02000118 RID: 280
	public class WebConnection : Object
	{
		// Token: 0x060011F3 RID: 4595 RVA: 0x0005343C File Offset: 0x0005163C
		// Note: this type is marked as 'beforefieldinit'.
		static WebConnection()
		{
			Il2CppClassPointerStore<WebConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebConnection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnection>.NativeClassPtr);
			WebConnection.NativeFieldInfoPtr_ntlm_credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "ntlm_credentials");
			WebConnection.NativeFieldInfoPtr_ntlm_authenticated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "ntlm_authenticated");
			WebConnection.NativeFieldInfoPtr_unsafe_sharing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "unsafe_sharing");
			WebConnection.NativeFieldInfoPtr_networkStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "networkStream");
			WebConnection.NativeFieldInfoPtr_socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "socket");
			WebConnection.NativeFieldInfoPtr_monoTlsStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "monoTlsStream");
			WebConnection.NativeFieldInfoPtr_tunnel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "tunnel");
			WebConnection.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "disposed");
			WebConnection.NativeFieldInfoPtr__ServicePoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "<ServicePoint>k__BackingField");
			WebConnection.NativeFieldInfoPtr_idleSince = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "idleSince");
			WebConnection.NativeFieldInfoPtr_currentOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "currentOperation");
			WebConnection.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665778);
			WebConnection.NativeMethodInfoPtr__ctor_Public_Void_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665779);
			WebConnection.NativeMethodInfoPtr_CanReuse_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665780);
			WebConnection.NativeMethodInfoPtr_CheckReusable_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665781);
			WebConnection.NativeMethodInfoPtr_Connect_Private_Task_WebOperation_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665782);
			WebConnection.NativeMethodInfoPtr_CreateStream_Private_Task_1_Boolean_WebOperation_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665783);
			WebConnection.NativeMethodInfoPtr_InitConnection_Internal_Task_1_WebRequestStream_WebOperation_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665784);
			WebConnection.NativeMethodInfoPtr_GetException_Internal_Static_WebException_WebExceptionStatus_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665785);
			WebConnection.NativeMethodInfoPtr_ReadLine_Internal_Static_Boolean_Il2CppStructArray_1_Byte_byref_Int32_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665786);
			WebConnection.NativeMethodInfoPtr_CanReuseConnection_Internal_Boolean_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665787);
			WebConnection.NativeMethodInfoPtr_PrepareSharingNtlm_Private_Boolean_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665788);
			WebConnection.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665789);
			WebConnection.NativeMethodInfoPtr_Close_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665790);
			WebConnection.NativeMethodInfoPtr_CloseSocket_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665791);
			WebConnection.NativeMethodInfoPtr_get_Closed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665792);
			WebConnection.NativeMethodInfoPtr_get_IdleSince_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665793);
			WebConnection.NativeMethodInfoPtr_StartOperation_Public_Boolean_WebOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665794);
			WebConnection.NativeMethodInfoPtr_Continue_Public_Boolean_WebOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665795);
			WebConnection.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665796);
			WebConnection.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665797);
			WebConnection.NativeMethodInfoPtr_ResetNtlm_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665798);
			WebConnection.NativeMethodInfoPtr_get_NtlmAuthenticated_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665799);
			WebConnection.NativeMethodInfoPtr_set_NtlmAuthenticated_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665800);
			WebConnection.NativeMethodInfoPtr_get_NtlmCredential_Internal_get_NetworkCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665801);
			WebConnection.NativeMethodInfoPtr_set_NtlmCredential_Internal_set_Void_NetworkCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665802);
			WebConnection.NativeMethodInfoPtr_get_UnsafeAuthenticatedConnectionSharing_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665803);
			WebConnection.NativeMethodInfoPtr_set_UnsafeAuthenticatedConnectionSharing_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, 100665804);
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x00053764 File Offset: 0x00051964
		public unsafe ServicePoint ServicePoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr3) : null;
			}
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x000537A4 File Offset: 0x000519A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53762, XrefRangeEnd = 53763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebConnection(ServicePoint sPoint)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sPoint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr__ctor_Public_Void_ServicePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x000537F0 File Offset: 0x000519F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53763, XrefRangeEnd = 53764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanReuse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_CanReuse_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x0005382C File Offset: 0x00051A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53764, XrefRangeEnd = 53766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckReusable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_CheckReusable_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00053868 File Offset: 0x00051A68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53774, RefRangeEnd = 53775, XrefRangeStart = 53766, XrefRangeEnd = 53774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task Connect(WebOperation operation, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_Connect_Private_Task_WebOperation_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x000538D0 File Offset: 0x00051AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53787, RefRangeEnd = 53788, XrefRangeStart = 53775, XrefRangeEnd = 53787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reused;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_CreateStream_Private_Task_1_Boolean_WebOperation_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x00053948 File Offset: 0x00051B48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53800, RefRangeEnd = 53801, XrefRangeStart = 53788, XrefRangeEnd = 53800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_InitConnection_Internal_Task_1_WebRequestStream_WebOperation_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<WebRequestStream>>(intPtr3) : null;
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x000539B0 File Offset: 0x00051BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53801, XrefRangeEnd = 53822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WebException GetException(WebExceptionStatus status, Exception error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_GetException_Internal_Static_WebException_WebExceptionStatus_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr3) : null;
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00053A04 File Offset: 0x00051C04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 53841, RefRangeEnd = 53844, XrefRangeStart = 53822, XrefRangeEnd = 53841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReadLine(Il2CppStructArray<byte> buffer, ref int start, int max, ref string output)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(output);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_ReadLine_Internal_Static_Boolean_Il2CppStructArray_1_Byte_byref_Int32_Int32_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			output = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00053A84 File Offset: 0x00051C84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53872, RefRangeEnd = 53873, XrefRangeStart = 53844, XrefRangeEnd = 53872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanReuseConnection(WebOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_CanReuseConnection_Internal_Boolean_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x00053AD4 File Offset: 0x00051CD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 53894, RefRangeEnd = 53896, XrefRangeStart = 53873, XrefRangeEnd = 53894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PrepareSharingNtlm(WebOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_PrepareSharingNtlm_Private_Boolean_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x00053B24 File Offset: 0x00051D24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53899, RefRangeEnd = 53900, XrefRangeStart = 53896, XrefRangeEnd = 53899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00053B58 File Offset: 0x00051D58
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 53905, RefRangeEnd = 53909, XrefRangeStart = 53900, XrefRangeEnd = 53905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool reset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_Close_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00053B98 File Offset: 0x00051D98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53917, RefRangeEnd = 53918, XrefRangeStart = 53909, XrefRangeEnd = 53917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseSocket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_CloseSocket_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x00053BCC File Offset: 0x00051DCC
		public unsafe bool Closed
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 53918, RefRangeEnd = 53919, XrefRangeStart = 53918, XrefRangeEnd = 53918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_get_Closed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x00053C08 File Offset: 0x00051E08
		public unsafe DateTime IdleSince
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_get_IdleSince_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00053C44 File Offset: 0x00051E44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53937, RefRangeEnd = 53938, XrefRangeStart = 53919, XrefRangeEnd = 53937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartOperation(WebOperation operation, bool reused)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reused;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_StartOperation_Public_Boolean_WebOperation_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00053CA0 File Offset: 0x00051EA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53947, RefRangeEnd = 53948, XrefRangeStart = 53938, XrefRangeEnd = 53947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Continue(WebOperation next)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_Continue_Public_Boolean_WebOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00053CF0 File Offset: 0x00051EF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53950, RefRangeEnd = 53951, XrefRangeStart = 53948, XrefRangeEnd = 53950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00053D30 File Offset: 0x00051F30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53950, RefRangeEnd = 53951, XrefRangeStart = 53950, XrefRangeEnd = 53951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00053D64 File Offset: 0x00051F64
		[CallerCount(0)]
		public unsafe void ResetNtlm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_ResetNtlm_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x00053D98 File Offset: 0x00051F98
		// (set) Token: 0x0600120A RID: 4618 RVA: 0x00053DD4 File Offset: 0x00051FD4
		public unsafe bool NtlmAuthenticated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_get_NtlmAuthenticated_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_set_NtlmAuthenticated_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x00053E14 File Offset: 0x00052014
		// (set) Token: 0x0600120C RID: 4620 RVA: 0x00053E54 File Offset: 0x00052054
		public unsafe NetworkCredential NtlmCredential
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_get_NtlmCredential_Internal_get_NetworkCredential_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkCredential>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_set_NtlmCredential_Internal_set_Void_NetworkCredential_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x00053E98 File Offset: 0x00052098
		// (set) Token: 0x0600120E RID: 4622 RVA: 0x00053ED4 File Offset: 0x000520D4
		public unsafe bool UnsafeAuthenticatedConnectionSharing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_get_UnsafeAuthenticatedConnectionSharing_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection.NativeMethodInfoPtr_set_UnsafeAuthenticatedConnectionSharing_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x000094D9 File Offset: 0x000076D9
		public WebConnection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x00053F14 File Offset: 0x00052114
		// (set) Token: 0x06001211 RID: 4625 RVA: 0x000094E2 File Offset: 0x000076E2
		public unsafe NetworkCredential ntlm_credentials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_ntlm_credentials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkCredential>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_ntlm_credentials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x00053F44 File Offset: 0x00052144
		// (set) Token: 0x06001213 RID: 4627 RVA: 0x00009501 File Offset: 0x00007701
		public unsafe bool ntlm_authenticated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_ntlm_authenticated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_ntlm_authenticated)) = value;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001214 RID: 4628 RVA: 0x00053F6C File Offset: 0x0005216C
		// (set) Token: 0x06001215 RID: 4629 RVA: 0x0000951C File Offset: 0x0000771C
		public unsafe bool unsafe_sharing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_unsafe_sharing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_unsafe_sharing)) = value;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001216 RID: 4630 RVA: 0x00053F94 File Offset: 0x00052194
		// (set) Token: 0x06001217 RID: 4631 RVA: 0x00009537 File Offset: 0x00007737
		public unsafe Stream networkStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_networkStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_networkStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x00053FC4 File Offset: 0x000521C4
		// (set) Token: 0x06001219 RID: 4633 RVA: 0x00009556 File Offset: 0x00007756
		public unsafe Socket socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_socket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_socket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x00053FF4 File Offset: 0x000521F4
		// (set) Token: 0x0600121B RID: 4635 RVA: 0x00009575 File Offset: 0x00007775
		public unsafe MonoTlsStream monoTlsStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_monoTlsStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoTlsStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_monoTlsStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x00054024 File Offset: 0x00052224
		// (set) Token: 0x0600121D RID: 4637 RVA: 0x00009594 File Offset: 0x00007794
		public unsafe WebConnectionTunnel tunnel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_tunnel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnectionTunnel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_tunnel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x00054054 File Offset: 0x00052254
		// (set) Token: 0x0600121F RID: 4639 RVA: 0x000095B3 File Offset: 0x000077B3
		public unsafe int disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x0005407C File Offset: 0x0005227C
		// (set) Token: 0x06001221 RID: 4641 RVA: 0x000095CE File Offset: 0x000077CE
		public unsafe ServicePoint _ServicePoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr__ServicePoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr__ServicePoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x000540AC File Offset: 0x000522AC
		// (set) Token: 0x06001223 RID: 4643 RVA: 0x000095ED File Offset: 0x000077ED
		public unsafe DateTime idleSince
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_idleSince);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_idleSince)) = value;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x000540D4 File Offset: 0x000522D4
		// (set) Token: 0x06001225 RID: 4645 RVA: 0x00009608 File Offset: 0x00007808
		public unsafe WebOperation currentOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_currentOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection.NativeFieldInfoPtr_currentOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeFieldInfoPtr_ntlm_credentials;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeFieldInfoPtr_ntlm_authenticated;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeFieldInfoPtr_unsafe_sharing;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeFieldInfoPtr_networkStream;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeFieldInfoPtr_socket;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeFieldInfoPtr_monoTlsStream;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeFieldInfoPtr_tunnel;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeFieldInfoPtr__ServicePoint_k__BackingField;

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeFieldInfoPtr_idleSince;

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeFieldInfoPtr_currentOperation;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeMethodInfoPtr_get_ServicePoint_Public_get_ServicePoint_0;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServicePoint_0;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeMethodInfoPtr_CanReuse_Private_Boolean_0;

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeMethodInfoPtr_CheckReusable_Private_Boolean_0;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Private_Task_WebOperation_CancellationToken_0;

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeMethodInfoPtr_CreateStream_Private_Task_1_Boolean_WebOperation_Boolean_CancellationToken_0;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeMethodInfoPtr_InitConnection_Internal_Task_1_WebRequestStream_WebOperation_CancellationToken_0;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeMethodInfoPtr_GetException_Internal_Static_WebException_WebExceptionStatus_Exception_0;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Internal_Static_Boolean_Il2CppStructArray_1_Byte_byref_Int32_Int32_byref_String_0;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeMethodInfoPtr_CanReuseConnection_Internal_Boolean_WebOperation_0;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeMethodInfoPtr_PrepareSharingNtlm_Private_Boolean_WebOperation_0;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x04000DE5 RID: 3557
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_Boolean_0;

		// Token: 0x04000DE6 RID: 3558
		private static readonly IntPtr NativeMethodInfoPtr_CloseSocket_Private_Void_0;

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeMethodInfoPtr_get_Closed_Public_get_Boolean_0;

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeMethodInfoPtr_get_IdleSince_Public_get_DateTime_0;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeMethodInfoPtr_StartOperation_Public_Boolean_WebOperation_Boolean_0;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeMethodInfoPtr_Continue_Public_Boolean_WebOperation_0;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeMethodInfoPtr_ResetNtlm_Private_Void_0;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeMethodInfoPtr_get_NtlmAuthenticated_Internal_get_Boolean_0;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeMethodInfoPtr_set_NtlmAuthenticated_Internal_set_Void_Boolean_0;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeMethodInfoPtr_get_NtlmCredential_Internal_get_NetworkCredential_0;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeMethodInfoPtr_set_NtlmCredential_Internal_set_Void_NetworkCredential_0;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeMethodInfoPtr_get_UnsafeAuthenticatedConnectionSharing_Internal_get_Boolean_0;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeMethodInfoPtr_set_UnsafeAuthenticatedConnectionSharing_Internal_set_Void_Boolean_0;

		// Token: 0x020001D3 RID: 467
		[ObfuscatedName("System.Net.WebConnection+<Connect>d__16")]
		public sealed class _Connect_d__16 : ValueType
		{
			// Token: 0x060019E3 RID: 6627 RVA: 0x0006D1D0 File Offset: 0x0006B3D0
			// Note: this type is marked as 'beforefieldinit'.
			static _Connect_d__16()
			{
				Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "<Connect>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr);
				WebConnection._Connect_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<>1__state");
				WebConnection._Connect_d__16.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<>t__builder");
				WebConnection._Connect_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<>4__this");
				WebConnection._Connect_d__16.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "operation");
				WebConnection._Connect_d__16.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "cancellationToken");
				WebConnection._Connect_d__16.NativeFieldInfoPtr__connectException_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<connectException>5__1");
				WebConnection._Connect_d__16.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<>7__wrap1");
				WebConnection._Connect_d__16.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<>7__wrap2");
				WebConnection._Connect_d__16.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, "<>u__1");
				WebConnection._Connect_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, 100665805);
				WebConnection._Connect_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr, 100665806);
			}

			// Token: 0x060019E4 RID: 6628 RVA: 0x0006D2D8 File Offset: 0x0006B4D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53660, XrefRangeEnd = 53672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection._Connect_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019E5 RID: 6629 RVA: 0x0006D310 File Offset: 0x0006B510
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection._Connect_d__16.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019E6 RID: 6630 RVA: 0x0000DC62 File Offset: 0x0000BE62
			public _Connect_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060019E7 RID: 6631 RVA: 0x0000DC6B File Offset: 0x0000BE6B
			public _Connect_d__16()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnection._Connect_d__16>.NativeClassPtr))
			{
			}

			// Token: 0x17000847 RID: 2119
			// (get) Token: 0x060019E8 RID: 6632 RVA: 0x0006D358 File Offset: 0x0006B558
			// (set) Token: 0x060019E9 RID: 6633 RVA: 0x0000DC7D File Offset: 0x0000BE7D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000848 RID: 2120
			// (get) Token: 0x060019EA RID: 6634 RVA: 0x0006D380 File Offset: 0x0006B580
			// (set) Token: 0x060019EB RID: 6635 RVA: 0x0000DC98 File Offset: 0x0000BE98
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000849 RID: 2121
			// (get) Token: 0x060019EC RID: 6636 RVA: 0x0006D3B0 File Offset: 0x0006B5B0
			// (set) Token: 0x060019ED RID: 6637 RVA: 0x0000DCC6 File Offset: 0x0000BEC6
			public unsafe WebConnection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700084A RID: 2122
			// (get) Token: 0x060019EE RID: 6638 RVA: 0x0006D3E0 File Offset: 0x0006B5E0
			// (set) Token: 0x060019EF RID: 6639 RVA: 0x0000DCE5 File Offset: 0x0000BEE5
			public unsafe WebOperation operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr_operation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr_operation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700084B RID: 2123
			// (get) Token: 0x060019F0 RID: 6640 RVA: 0x0006D410 File Offset: 0x0006B610
			// (set) Token: 0x060019F1 RID: 6641 RVA: 0x0000DD04 File Offset: 0x0000BF04
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700084C RID: 2124
			// (get) Token: 0x060019F2 RID: 6642 RVA: 0x0006D440 File Offset: 0x0006B640
			// (set) Token: 0x060019F3 RID: 6643 RVA: 0x0000DD32 File Offset: 0x0000BF32
			public unsafe Exception _connectException_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr__connectException_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr__connectException_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700084D RID: 2125
			// (get) Token: 0x060019F4 RID: 6644 RVA: 0x0006D470 File Offset: 0x0006B670
			// (set) Token: 0x060019F5 RID: 6645 RVA: 0x0000DD51 File Offset: 0x0000BF51
			public unsafe Il2CppReferenceArray<IPAddress> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700084E RID: 2126
			// (get) Token: 0x060019F6 RID: 6646 RVA: 0x0006D4A0 File Offset: 0x0006B6A0
			// (set) Token: 0x060019F7 RID: 6647 RVA: 0x0000DD70 File Offset: 0x0000BF70
			public unsafe int __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x1700084F RID: 2127
			// (get) Token: 0x060019F8 RID: 6648 RVA: 0x0006D4C8 File Offset: 0x0006B6C8
			// (set) Token: 0x060019F9 RID: 6649 RVA: 0x0000DD8B File Offset: 0x0000BF8B
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._Connect_d__16.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400143B RID: 5179
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400143C RID: 5180
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400143D RID: 5181
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400143E RID: 5182
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x0400143F RID: 5183
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001440 RID: 5184
			private static readonly IntPtr NativeFieldInfoPtr__connectException_5__1;

			// Token: 0x04001441 RID: 5185
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001442 RID: 5186
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001443 RID: 5187
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001444 RID: 5188
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001445 RID: 5189
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001D4 RID: 468
		[ObfuscatedName("System.Net.WebConnection+<CreateStream>d__18")]
		public sealed class _CreateStream_d__18 : ValueType
		{
			// Token: 0x060019FA RID: 6650 RVA: 0x0006D4F8 File Offset: 0x0006B6F8
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateStream_d__18()
			{
				Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "<CreateStream>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr);
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "<>1__state");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "<>t__builder");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "<>4__this");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "operation");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr_reused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "reused");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "cancellationToken");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr__stream_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "<stream>5__1");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "<>u__1");
				WebConnection._CreateStream_d__18.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, "<>u__2");
				WebConnection._CreateStream_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, 100665807);
				WebConnection._CreateStream_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr, 100665808);
			}

			// Token: 0x060019FB RID: 6651 RVA: 0x0006D600 File Offset: 0x0006B800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53672, XrefRangeEnd = 53729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection._CreateStream_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019FC RID: 6652 RVA: 0x0006D638 File Offset: 0x0006B838
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53729, XrefRangeEnd = 53732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection._CreateStream_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019FD RID: 6653 RVA: 0x0000DDB9 File Offset: 0x0000BFB9
			public _CreateStream_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060019FE RID: 6654 RVA: 0x0000DDC2 File Offset: 0x0000BFC2
			public _CreateStream_d__18()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnection._CreateStream_d__18>.NativeClassPtr))
			{
			}

			// Token: 0x17000850 RID: 2128
			// (get) Token: 0x060019FF RID: 6655 RVA: 0x0006D680 File Offset: 0x0006B880
			// (set) Token: 0x06001A00 RID: 6656 RVA: 0x0000DDD4 File Offset: 0x0000BFD4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000851 RID: 2129
			// (get) Token: 0x06001A01 RID: 6657 RVA: 0x0006D6A8 File Offset: 0x0006B8A8
			// (set) Token: 0x06001A02 RID: 6658 RVA: 0x0000DDEF File Offset: 0x0000BFEF
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000852 RID: 2130
			// (get) Token: 0x06001A03 RID: 6659 RVA: 0x0006D6D8 File Offset: 0x0006B8D8
			// (set) Token: 0x06001A04 RID: 6660 RVA: 0x0000DE1D File Offset: 0x0000C01D
			public unsafe WebConnection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000853 RID: 2131
			// (get) Token: 0x06001A05 RID: 6661 RVA: 0x0006D708 File Offset: 0x0006B908
			// (set) Token: 0x06001A06 RID: 6662 RVA: 0x0000DE3C File Offset: 0x0000C03C
			public unsafe WebOperation operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr_operation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr_operation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000854 RID: 2132
			// (get) Token: 0x06001A07 RID: 6663 RVA: 0x0006D738 File Offset: 0x0006B938
			// (set) Token: 0x06001A08 RID: 6664 RVA: 0x0000DE5B File Offset: 0x0000C05B
			public unsafe bool reused
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr_reused);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr_reused)) = value;
				}
			}

			// Token: 0x17000855 RID: 2133
			// (get) Token: 0x06001A09 RID: 6665 RVA: 0x0006D760 File Offset: 0x0006B960
			// (set) Token: 0x06001A0A RID: 6666 RVA: 0x0000DE76 File Offset: 0x0000C076
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000856 RID: 2134
			// (get) Token: 0x06001A0B RID: 6667 RVA: 0x0006D790 File Offset: 0x0006B990
			// (set) Token: 0x06001A0C RID: 6668 RVA: 0x0000DEA4 File Offset: 0x0000C0A4
			public unsafe NetworkStream _stream_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr__stream_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr__stream_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000857 RID: 2135
			// (get) Token: 0x06001A0D RID: 6669 RVA: 0x0006D7C0 File Offset: 0x0006B9C0
			// (set) Token: 0x06001A0E RID: 6670 RVA: 0x0000DEC3 File Offset: 0x0000C0C3
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000858 RID: 2136
			// (get) Token: 0x06001A0F RID: 6671 RVA: 0x0006D7F0 File Offset: 0x0006B9F0
			// (set) Token: 0x06001A10 RID: 6672 RVA: 0x0000DEF1 File Offset: 0x0000C0F1
			public ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._CreateStream_d__18.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001446 RID: 5190
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001447 RID: 5191
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001448 RID: 5192
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001449 RID: 5193
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x0400144A RID: 5194
			private static readonly IntPtr NativeFieldInfoPtr_reused;

			// Token: 0x0400144B RID: 5195
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400144C RID: 5196
			private static readonly IntPtr NativeFieldInfoPtr__stream_5__1;

			// Token: 0x0400144D RID: 5197
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400144E RID: 5198
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400144F RID: 5199
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001450 RID: 5200
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001D5 RID: 469
		[ObfuscatedName("System.Net.WebConnection+<InitConnection>d__19")]
		public sealed class _InitConnection_d__19 : ValueType
		{
			// Token: 0x06001A11 RID: 6673 RVA: 0x0006D820 File Offset: 0x0006BA20
			// Note: this type is marked as 'beforefieldinit'.
			static _InitConnection_d__19()
			{
				Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WebConnection>.NativeClassPtr, "<InitConnection>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr);
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "<>1__state");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "<>t__builder");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "operation");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "cancellationToken");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "<>4__this");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr__reused_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "<reused>5__1");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "<>u__1");
				WebConnection._InitConnection_d__19.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, "<>u__2");
				WebConnection._InitConnection_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, 100665809);
				WebConnection._InitConnection_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr, 100665810);
			}

			// Token: 0x06001A12 RID: 6674 RVA: 0x0006D914 File Offset: 0x0006BB14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53732, XrefRangeEnd = 53759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection._InitConnection_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A13 RID: 6675 RVA: 0x0006D94C File Offset: 0x0006BB4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53759, XrefRangeEnd = 53762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebConnection._InitConnection_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A14 RID: 6676 RVA: 0x0000DF1F File Offset: 0x0000C11F
			public _InitConnection_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001A15 RID: 6677 RVA: 0x0000DF28 File Offset: 0x0000C128
			public _InitConnection_d__19()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebConnection._InitConnection_d__19>.NativeClassPtr))
			{
			}

			// Token: 0x17000859 RID: 2137
			// (get) Token: 0x06001A16 RID: 6678 RVA: 0x0006D994 File Offset: 0x0006BB94
			// (set) Token: 0x06001A17 RID: 6679 RVA: 0x0000DF3A File Offset: 0x0000C13A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700085A RID: 2138
			// (get) Token: 0x06001A18 RID: 6680 RVA: 0x0006D9BC File Offset: 0x0006BBBC
			// (set) Token: 0x06001A19 RID: 6681 RVA: 0x0000DF55 File Offset: 0x0000C155
			public AsyncTaskMethodBuilder<WebRequestStream> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<WebRequestStream>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<WebRequestStream>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<WebRequestStream>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700085B RID: 2139
			// (get) Token: 0x06001A1A RID: 6682 RVA: 0x0006D9EC File Offset: 0x0006BBEC
			// (set) Token: 0x06001A1B RID: 6683 RVA: 0x0000DF83 File Offset: 0x0000C183
			public unsafe WebOperation operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr_operation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr_operation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700085C RID: 2140
			// (get) Token: 0x06001A1C RID: 6684 RVA: 0x0006DA1C File Offset: 0x0006BC1C
			// (set) Token: 0x06001A1D RID: 6685 RVA: 0x0000DFA2 File Offset: 0x0000C1A2
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700085D RID: 2141
			// (get) Token: 0x06001A1E RID: 6686 RVA: 0x0006DA4C File Offset: 0x0006BC4C
			// (set) Token: 0x06001A1F RID: 6687 RVA: 0x0000DFD0 File Offset: 0x0000C1D0
			public unsafe WebConnection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700085E RID: 2142
			// (get) Token: 0x06001A20 RID: 6688 RVA: 0x0006DA7C File Offset: 0x0006BC7C
			// (set) Token: 0x06001A21 RID: 6689 RVA: 0x0000DFEF File Offset: 0x0000C1EF
			public unsafe bool _reused_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr__reused_5__1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr__reused_5__1)) = value;
				}
			}

			// Token: 0x1700085F RID: 2143
			// (get) Token: 0x06001A22 RID: 6690 RVA: 0x0006DAA4 File Offset: 0x0006BCA4
			// (set) Token: 0x06001A23 RID: 6691 RVA: 0x0000E00A File Offset: 0x0000C20A
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000860 RID: 2144
			// (get) Token: 0x06001A24 RID: 6692 RVA: 0x0006DAD4 File Offset: 0x0006BCD4
			// (set) Token: 0x06001A25 RID: 6693 RVA: 0x0000E038 File Offset: 0x0000C238
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WebConnection._InitConnection_d__19.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001451 RID: 5201
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001452 RID: 5202
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001453 RID: 5203
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x04001454 RID: 5204
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001455 RID: 5205
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001456 RID: 5206
			private static readonly IntPtr NativeFieldInfoPtr__reused_5__1;

			// Token: 0x04001457 RID: 5207
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001458 RID: 5208
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04001459 RID: 5209
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400145A RID: 5210
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}

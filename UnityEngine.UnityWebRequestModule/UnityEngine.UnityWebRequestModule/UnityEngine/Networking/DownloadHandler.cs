using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using Unity.Collections;

namespace UnityEngine.Networking
{
	// Token: 0x02000008 RID: 8
	public class DownloadHandler : Object
	{
		// Token: 0x06000101 RID: 257 RVA: 0x00005E94 File Offset: 0x00004094
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadHandler()
		{
			Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "DownloadHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr);
			DownloadHandler.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, "m_Ptr");
			DownloadHandler.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663386);
			DownloadHandler.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663387);
			DownloadHandler.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663388);
			DownloadHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663389);
			DownloadHandler.NativeMethodInfoPtr_get_data_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663390);
			DownloadHandler.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663391);
			DownloadHandler.NativeMethodInfoPtr_GetNativeData_Protected_Virtual_New_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663392);
			DownloadHandler.NativeMethodInfoPtr_GetData_Protected_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663393);
			DownloadHandler.NativeMethodInfoPtr_GetText_Protected_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663394);
			DownloadHandler.NativeMethodInfoPtr_GetTextEncoder_Private_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663395);
			DownloadHandler.NativeMethodInfoPtr_GetContentType_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663396);
			DownloadHandler.NativeMethodInfoPtr_ReceiveContentLengthHeader_Protected_Virtual_New_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663397);
			DownloadHandler.NativeMethodInfoPtr_ReceiveContentLength_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663398);
			DownloadHandler.NativeMethodInfoPtr_GetCheckedDownloader_Protected_Static_T_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663399);
			DownloadHandler.NativeMethodInfoPtr_InternalGetByteArray_Internal_Static_ptr_Byte_DownloadHandler_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663400);
			DownloadHandler.NativeMethodInfoPtr_InternalGetByteArray_Internal_Static_Il2CppStructArray_1_Byte_DownloadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr, 100663401);
			DownloadHandler.IsDoneDelegateField = IL2CPP.ResolveICall<DownloadHandler.IsDoneDelegate>("UnityEngine.Networking.DownloadHandler::IsDone");
			DownloadHandler.GetErrorMsgDelegateField = IL2CPP.ResolveICall<DownloadHandler.GetErrorMsgDelegate>("UnityEngine.Networking.DownloadHandler::GetErrorMsg");
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00006038 File Offset: 0x00004238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124751, XrefRangeEnd = 124753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000606C File Offset: 0x0000426C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000060A8 File Offset: 0x000042A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124753, XrefRangeEnd = 124756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000060E4 File Offset: 0x000042E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124756, XrefRangeEnd = 124760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00006120 File Offset: 0x00004320
		public unsafe Il2CppStructArray<byte> data
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14894, RefRangeEnd = 14910, XrefRangeStart = 14894, XrefRangeEnd = 14910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_get_data_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00006160 File Offset: 0x00004360
		public unsafe string text
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 16379, RefRangeEnd = 16382, XrefRangeStart = 16379, XrefRangeEnd = 16382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00006198 File Offset: 0x00004398
		[CallerCount(0)]
		public unsafe virtual NativeArray<byte> GetNativeData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_GetNativeData_Protected_Virtual_New_NativeArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new NativeArray<byte>(intPtr);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000061DC File Offset: 0x000043DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124760, XrefRangeEnd = 124764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_GetData_Protected_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00006228 File Offset: 0x00004428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124764, XrefRangeEnd = 124773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_GetText_Protected_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000626C File Offset: 0x0000446C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124799, RefRangeEnd = 124800, XrefRangeStart = 124773, XrefRangeEnd = 124799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Encoding GetTextEncoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_GetTextEncoder_Private_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000062AC File Offset: 0x000044AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124800, XrefRangeEnd = 124802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetContentType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_GetContentType_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000062E4 File Offset: 0x000044E4
		[CallerCount(0)]
		public unsafe virtual void ReceiveContentLengthHeader(ulong contentLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_ReceiveContentLengthHeader_Protected_Virtual_New_Void_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00006330 File Offset: 0x00004530
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveContentLength(int contentLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadHandler.NativeMethodInfoPtr_ReceiveContentLength_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000637C File Offset: 0x0000457C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124806, RefRangeEnd = 124807, XrefRangeStart = 124802, XrefRangeEnd = 124806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetCheckedDownloader<T>(UnityWebRequest www) where T : DownloadHandler
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(www);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.MethodInfoStoreGeneric_GetCheckedDownloader_Protected_Static_T_UnityWebRequest_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000063BC File Offset: 0x000045BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124807, XrefRangeEnd = 124809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte* InternalGetByteArray(DownloadHandler dh, out int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_InternalGetByteArray_Internal_Static_ptr_Byte_DownloadHandler_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00006404 File Offset: 0x00004604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> InternalGetByteArray(DownloadHandler dh)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadHandler.NativeMethodInfoPtr_InternalGetByteArray_Internal_Static_Il2CppStructArray_1_Byte_DownloadHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000254D File Offset: 0x0000074D
		public DownloadHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00006448 File Offset: 0x00004648
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00002556 File Offset: 0x00000756
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadHandler.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadHandler.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00006470 File Offset: 0x00004670
		public bool isDone
		{
			get
			{
				return this.IsDone();
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002571 File Offset: 0x00000771
		public bool IsDone()
		{
			return DownloadHandler.IsDoneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00006488 File Offset: 0x00004688
		public string error
		{
			get
			{
				return this.GetErrorMsg();
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000064A0 File Offset: 0x000046A0
		public string GetErrorMsg()
		{
			IntPtr intPtr = DownloadHandler.GetErrorMsgDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000064C4 File Offset: 0x000046C4
		public virtual bool ReceiveData(Il2CppStructArray<byte> data, int dataLength)
		{
			return true;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002583 File Offset: 0x00000783
		public virtual void CompleteContent()
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000064D8 File Offset: 0x000046D8
		public virtual float GetProgress()
		{
			return 0f;
		}

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_get_data_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeData_Protected_Virtual_New_NativeArray_1_Byte_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Protected_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_GetText_Protected_Virtual_New_String_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_GetTextEncoder_Private_Encoding_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_GetContentType_Private_String_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveContentLengthHeader_Protected_Virtual_New_Void_UInt64_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveContentLength_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_GetCheckedDownloader_Protected_Static_T_UnityWebRequest_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetByteArray_Internal_Static_ptr_Byte_DownloadHandler_byref_Int32_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetByteArray_Internal_Static_Il2CppStructArray_1_Byte_DownloadHandler_0;

		// Token: 0x040000A5 RID: 165
		private static readonly DownloadHandler.IsDoneDelegate IsDoneDelegateField;

		// Token: 0x040000A6 RID: 166
		private static readonly DownloadHandler.GetErrorMsgDelegate GetErrorMsgDelegateField;

		// Token: 0x0200002A RID: 42
		private sealed class MethodInfoStoreGeneric_GetCheckedDownloader_Protected_Static_T_UnityWebRequest_0<T>
		{
			// Token: 0x040000EE RID: 238
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DownloadHandler.NativeMethodInfoPtr_GetCheckedDownloader_Protected_Static_T_UnityWebRequest_0, Il2CppClassPointerStore<DownloadHandler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x06000188 RID: 392
		private delegate bool IsDoneDelegate(IntPtr @this);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x0600018A RID: 394
		private delegate IntPtr GetErrorMsgDelegate(IntPtr @this);
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Net
{
	// Token: 0x020000F5 RID: 245
	public sealed class FileWebStream : FileStream
	{
		// Token: 0x06000E7B RID: 3707 RVA: 0x000469A8 File Offset: 0x00044BA8
		// Note: this type is marked as 'beforefieldinit'.
		static FileWebStream()
		{
			Il2CppClassPointerStore<FileWebStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FileWebStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileWebStream>.NativeClassPtr);
			FileWebStream.NativeFieldInfoPtr_m_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileWebStream>.NativeClassPtr, "m_request");
			FileWebStream.NativeMethodInfoPtr__ctor_Public_Void_FileWebRequest_String_FileMode_FileAccess_FileShare_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebStream>.NativeClassPtr, 100665318);
			FileWebStream.NativeMethodInfoPtr__ctor_Public_Void_FileWebRequest_String_FileMode_FileAccess_FileShare_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebStream>.NativeClassPtr, 100665319);
			FileWebStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebStream>.NativeClassPtr, 100665320);
			FileWebStream.NativeMethodInfoPtr_System_Net_ICloseEx_CloseEx_Private_Virtual_Final_New_Void_CloseExState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebStream>.NativeClassPtr, 100665321);
			FileWebStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebStream>.NativeClassPtr, 100665322);
			FileWebStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebStream>.NativeClassPtr, 100665323);
			FileWebStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebStream>.NativeClassPtr, 100665324);
			FileWebStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebStream>.NativeClassPtr, 100665325);
			FileWebStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebStream>.NativeClassPtr, 100665326);
			FileWebStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebStream>.NativeClassPtr, 100665327);
			FileWebStream.NativeMethodInfoPtr_CheckError_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebStream>.NativeClassPtr, 100665328);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00046AC8 File Offset: 0x00044CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49133, XrefRangeEnd = 49137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileWebStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sharing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebStream.NativeMethodInfoPtr__ctor_Public_Void_FileWebRequest_String_FileMode_FileAccess_FileShare_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00046B50 File Offset: 0x00044D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49137, XrefRangeEnd = 49141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileWebStream(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileWebStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sharing;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref async;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebStream.NativeMethodInfoPtr__ctor_Public_Void_FileWebRequest_String_FileMode_FileAccess_FileShare_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00046BF4 File Offset: 0x00044DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49141, XrefRangeEnd = 49145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00046C34 File Offset: 0x00044E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49145, XrefRangeEnd = 49147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Net_ICloseEx_CloseEx(CloseExState closeState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closeState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebStream.NativeMethodInfoPtr_System_Net_ICloseEx_CloseEx_Private_Virtual_Final_New_Void_CloseExState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00046C74 File Offset: 0x00044E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49147, XrefRangeEnd = 49149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00046CE0 File Offset: 0x00044EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49149, XrefRangeEnd = 49151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00046D40 File Offset: 0x00044F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49151, XrefRangeEnd = 49153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginRead(Il2CppStructArray<byte> buffer, int offset, int size, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00046DD4 File Offset: 0x00044FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49153, XrefRangeEnd = 49154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int EndRead(IAsyncResult ar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ar);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00046E24 File Offset: 0x00045024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49154, XrefRangeEnd = 49156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginWrite(Il2CppStructArray<byte> buffer, int offset, int size, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00046EB8 File Offset: 0x000450B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49156, XrefRangeEnd = 49157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndWrite(IAsyncResult ar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ar);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00046EFC File Offset: 0x000450FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 49157, RefRangeEnd = 49161, XrefRangeStart = 49157, XrefRangeEnd = 49157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebStream.NativeMethodInfoPtr_CheckError_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x00007B79 File Offset: 0x00005D79
		public FileWebStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x00046F30 File Offset: 0x00045130
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x00007B82 File Offset: 0x00005D82
		public unsafe FileWebRequest m_request
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebStream.NativeFieldInfoPtr_m_request);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileWebRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileWebStream.NativeFieldInfoPtr_m_request), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeFieldInfoPtr_m_request;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FileWebRequest_String_FileMode_FileAccess_FileShare_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FileWebRequest_String_FileMode_FileAccess_FileShare_Int32_Boolean_0;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeMethodInfoPtr_System_Net_ICloseEx_CloseEx_Private_Virtual_Final_New_Void_CloseExState_0;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_CheckError_Private_Void_0;
	}
}

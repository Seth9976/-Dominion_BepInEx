using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem.Runtime.InteropServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.IO
{
	// Token: 0x02000219 RID: 537
	public class FileStream : Stream
	{
		// Token: 0x060022A7 RID: 8871 RVA: 0x000BDC34 File Offset: 0x000BBE34
		// Note: this type is marked as 'beforefieldinit'.
		static FileStream()
		{
			Il2CppClassPointerStore<FileStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "FileStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileStream>.NativeClassPtr);
			FileStream.NativeFieldInfoPtr_buf_recycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "buf_recycle");
			FileStream.NativeFieldInfoPtr_buf_recycle_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "buf_recycle_lock");
			FileStream.NativeFieldInfoPtr_buf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "buf");
			FileStream.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "name");
			FileStream.NativeFieldInfoPtr_safeHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "safeHandle");
			FileStream.NativeFieldInfoPtr_isExposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "isExposed");
			FileStream.NativeFieldInfoPtr_append_startpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "append_startpos");
			FileStream.NativeFieldInfoPtr_access = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "access");
			FileStream.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "owner");
			FileStream.NativeFieldInfoPtr_async = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "async");
			FileStream.NativeFieldInfoPtr_canseek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "canseek");
			FileStream.NativeFieldInfoPtr_anonymous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "anonymous");
			FileStream.NativeFieldInfoPtr_buf_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "buf_dirty");
			FileStream.NativeFieldInfoPtr_buf_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "buf_size");
			FileStream.NativeFieldInfoPtr_buf_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "buf_length");
			FileStream.NativeFieldInfoPtr_buf_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "buf_offset");
			FileStream.NativeFieldInfoPtr_buf_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "buf_start");
			FileStream.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_FileAccess_Boolean_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669107);
			FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669108);
			FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669109);
			FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669110);
			FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669111);
			FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669112);
			FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_Int32_FileOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669113);
			FileStream.NativeMethodInfoPtr__ctor_Internal_Void_String_FileMode_FileAccess_FileShare_Int32_FileOptions_String_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669114);
			FileStream.NativeMethodInfoPtr__ctor_Internal_Void_String_FileMode_FileAccess_FileShare_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669115);
			FileStream.NativeMethodInfoPtr__ctor_Internal_Void_String_FileMode_FileAccess_FileShare_Int32_Boolean_FileOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669116);
			FileStream.NativeMethodInfoPtr_Init_Private_Void_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669117);
			FileStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669118);
			FileStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669119);
			FileStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669120);
			FileStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669121);
			FileStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669122);
			FileStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669123);
			FileStream.NativeMethodInfoPtr_get_SafeFileHandle_Public_Virtual_New_get_SafeFileHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669124);
			FileStream.NativeMethodInfoPtr_ExposeHandle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669125);
			FileStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669126);
			FileStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669127);
			FileStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669128);
			FileStream.NativeMethodInfoPtr_ReadInternal_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669129);
			FileStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669130);
			FileStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669131);
			FileStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669132);
			FileStream.NativeMethodInfoPtr_WriteInternal_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669133);
			FileStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669134);
			FileStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669135);
			FileStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669136);
			FileStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669137);
			FileStream.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669138);
			FileStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669139);
			FileStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669140);
			FileStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669141);
			FileStream.NativeMethodInfoPtr_ReadSegment_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669142);
			FileStream.NativeMethodInfoPtr_WriteSegment_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669143);
			FileStream.NativeMethodInfoPtr_FlushBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669144);
			FileStream.NativeMethodInfoPtr_FlushBufferIfDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669145);
			FileStream.NativeMethodInfoPtr_RefillBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669146);
			FileStream.NativeMethodInfoPtr_ReadData_Private_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669147);
			FileStream.NativeMethodInfoPtr_InitBuffer_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669148);
			FileStream.NativeMethodInfoPtr_GetSecureFileName_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669149);
			FileStream.NativeMethodInfoPtr_GetSecureFileName_Private_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream>.NativeClassPtr, 100669150);
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x000BE128 File Offset: 0x000BC328
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322820, RefRangeEnd = 322821, XrefRangeStart = 322796, XrefRangeEnd = 322820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAsync;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isConsoleWrapper;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_FileAccess_Boolean_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x000BE1B8 File Offset: 0x000BC3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322821, XrefRangeEnd = 322822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(string path, FileMode mode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x000BE214 File Offset: 0x000BC414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322822, XrefRangeEnd = 322823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(string path, FileMode mode, FileAccess access)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x000BE27C File Offset: 0x000BC47C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 322824, RefRangeEnd = 322827, XrefRangeStart = 322823, XrefRangeEnd = 322824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(string path, FileMode mode, FileAccess access, FileShare share)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x000BE2F4 File Offset: 0x000BC4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322827, XrefRangeEnd = 322828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x000BE378 File Offset: 0x000BC578
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 322829, RefRangeEnd = 322832, XrefRangeStart = 322828, XrefRangeEnd = 322829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useAsync;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x000BE40C File Offset: 0x000BC60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322832, XrefRangeEnd = 322833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_Int32_FileOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x000BE4A0 File Offset: 0x000BC6A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 322834, RefRangeEnd = 322837, XrefRangeStart = 322833, XrefRangeEnd = 322834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options, string msgPath, bool bFromProxy, bool useLongPath = false, bool checkHost = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msgPath);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bFromProxy;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useLongPath;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkHost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Internal_Void_String_FileMode_FileAccess_FileShare_Int32_FileOptions_String_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x000BE570 File Offset: 0x000BC770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322837, XrefRangeEnd = 322838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAsync;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anonymous;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Internal_Void_String_FileMode_FileAccess_FileShare_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x000BE610 File Offset: 0x000BC810
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 322878, RefRangeEnd = 322893, XrefRangeStart = 322838, XrefRangeEnd = 322878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anonymous;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr__ctor_Internal_Void_String_FileMode_FileAccess_FileShare_Int32_Boolean_FileOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x000BE6B0 File Offset: 0x000BC8B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322902, RefRangeEnd = 322903, XrefRangeStart = 322893, XrefRangeEnd = 322902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAsync;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isConsoleWrapper;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_Init_Private_Void_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x000BE738 File Offset: 0x000BC938
		public unsafe override bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x000BE780 File Offset: 0x000BC980
		public unsafe override bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x000BE7C8 File Offset: 0x000BC9C8
		public unsafe override bool CanSeek
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060022B6 RID: 8886 RVA: 0x000BE810 File Offset: 0x000BCA10
		public unsafe override long Length
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322903, XrefRangeEnd = 322909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x060022B7 RID: 8887 RVA: 0x000BE858 File Offset: 0x000BCA58
		// (set) Token: 0x060022B8 RID: 8888 RVA: 0x000BE8A0 File Offset: 0x000BCAA0
		public unsafe override long Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322909, XrefRangeEnd = 322915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322915, XrefRangeEnd = 322923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060022B9 RID: 8889 RVA: 0x000BE8EC File Offset: 0x000BCAEC
		public unsafe virtual SafeFileHandle SafeFileHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322923, XrefRangeEnd = 322925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_get_SafeFileHandle_Public_Virtual_New_get_SafeFileHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeFileHandle>(intPtr3) : null;
			}
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x000BE938 File Offset: 0x000BCB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322925, XrefRangeEnd = 322927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExposeHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_ExposeHandle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x000BE96C File Offset: 0x000BCB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322927, XrefRangeEnd = 322929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ReadByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x000BE9B4 File Offset: 0x000BCBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322929, XrefRangeEnd = 322931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteByte(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x000BEA00 File Offset: 0x000BCC00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322939, RefRangeEnd = 322940, XrefRangeStart = 322931, XrefRangeEnd = 322939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read([In] [Out] Il2CppStructArray<byte> array, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*array = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x000BEA88 File Offset: 0x000BCC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322940, XrefRangeEnd = 322948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadInternal(Il2CppStructArray<byte> dest, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_ReadInternal_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x000BEAF4 File Offset: 0x000BCCF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322956, RefRangeEnd = 322957, XrefRangeStart = 322948, XrefRangeEnd = 322956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginRead(Il2CppStructArray<byte> array, int offset, int numBytes, AsyncCallback userCallback, Object stateObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBytes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x000BEB94 File Offset: 0x000BCD94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322983, RefRangeEnd = 322984, XrefRangeStart = 322957, XrefRangeEnd = 322983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int EndRead(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x000BEBEC File Offset: 0x000BCDEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322986, RefRangeEnd = 322987, XrefRangeStart = 322984, XrefRangeEnd = 322986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<byte> array, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x000BEC58 File Offset: 0x000BCE58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322998, RefRangeEnd = 322999, XrefRangeStart = 322987, XrefRangeEnd = 322998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteInternal(Il2CppStructArray<byte> src, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_WriteInternal_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x000BECB8 File Offset: 0x000BCEB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323021, RefRangeEnd = 323022, XrefRangeStart = 322999, XrefRangeEnd = 323021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAsyncResult BeginWrite(Il2CppStructArray<byte> array, int offset, int numBytes, AsyncCallback userCallback, Object stateObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBytes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x000BED58 File Offset: 0x000BCF58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323048, RefRangeEnd = 323049, XrefRangeStart = 323022, XrefRangeEnd = 323048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EndWrite(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x000BEDA8 File Offset: 0x000BCFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323049, XrefRangeEnd = 323057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long Seek(long offset, SeekOrigin origin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x000BEE0C File Offset: 0x000BD00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323057, XrefRangeEnd = 323066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x000BEE48 File Offset: 0x000BD048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x000BEE84 File Offset: 0x000BD084
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323096, RefRangeEnd = 323098, XrefRangeStart = 323066, XrefRangeEnd = 323096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x000BEED0 File Offset: 0x000BD0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323098, XrefRangeEnd = 323099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task<int> ReadAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x000BEF60 File Offset: 0x000BD160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323099, XrefRangeEnd = 323100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x000BEFF0 File Offset: 0x000BD1F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 323105, RefRangeEnd = 323109, XrefRangeStart = 323100, XrefRangeEnd = 323105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadSegment(Il2CppStructArray<byte> dest, int dest_offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dest_offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_ReadSegment_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x000BF05C File Offset: 0x000BD25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323109, XrefRangeEnd = 323110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int WriteSegment(Il2CppStructArray<byte> src, int src_offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref src_offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_WriteSegment_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x000BF0C8 File Offset: 0x000BD2C8
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 323117, RefRangeEnd = 323133, XrefRangeStart = 323110, XrefRangeEnd = 323117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_FlushBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x000BF0FC File Offset: 0x000BD2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323133, XrefRangeEnd = 323134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushBufferIfDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_FlushBufferIfDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x000BF130 File Offset: 0x000BD330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323136, RefRangeEnd = 323137, XrefRangeStart = 323134, XrefRangeEnd = 323136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefillBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_RefillBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x000BF164 File Offset: 0x000BD364
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 323142, RefRangeEnd = 323147, XrefRangeStart = 323137, XrefRangeEnd = 323142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadData(SafeHandle safeHandle, Il2CppStructArray<byte> buf, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buf);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_ReadData_Private_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x000BF1E0 File Offset: 0x000BD3E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 323168, RefRangeEnd = 323172, XrefRangeStart = 323147, XrefRangeEnd = 323168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitBuffer(int size, bool isZeroSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isZeroSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_InitBuffer_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x000BF22C File Offset: 0x000BD42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323172, XrefRangeEnd = 323178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSecureFileName(string filename)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_GetSecureFileName_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x000BF274 File Offset: 0x000BD474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323178, XrefRangeEnd = 323185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSecureFileName(string filename, bool full)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref full;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.NativeMethodInfoPtr_GetSecureFileName_Private_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x0000BBA1 File Offset: 0x00009DA1
		public FileStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x000BF2CC File Offset: 0x000BD4CC
		// (set) Token: 0x060022D6 RID: 8918 RVA: 0x0000BBAA File Offset: 0x00009DAA
		public unsafe static Il2CppStructArray<byte> buf_recycle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FileStream.NativeFieldInfoPtr_buf_recycle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FileStream.NativeFieldInfoPtr_buf_recycle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x000BF2F4 File Offset: 0x000BD4F4
		// (set) Token: 0x060022D8 RID: 8920 RVA: 0x0000BBBC File Offset: 0x00009DBC
		public unsafe static Object buf_recycle_lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FileStream.NativeFieldInfoPtr_buf_recycle_lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FileStream.NativeFieldInfoPtr_buf_recycle_lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x000BF31C File Offset: 0x000BD51C
		// (set) Token: 0x060022DA RID: 8922 RVA: 0x0000BBCE File Offset: 0x00009DCE
		public unsafe Il2CppStructArray<byte> buf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060022DB RID: 8923 RVA: 0x000BF34C File Offset: 0x000BD54C
		// (set) Token: 0x060022DC RID: 8924 RVA: 0x0000BBED File Offset: 0x00009DED
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x000BF374 File Offset: 0x000BD574
		// (set) Token: 0x060022DE RID: 8926 RVA: 0x0000BC0C File Offset: 0x00009E0C
		public unsafe SafeFileHandle safeHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_safeHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeFileHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_safeHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x000BF3A4 File Offset: 0x000BD5A4
		// (set) Token: 0x060022E0 RID: 8928 RVA: 0x0000BC2B File Offset: 0x00009E2B
		public unsafe bool isExposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_isExposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_isExposed)) = value;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060022E1 RID: 8929 RVA: 0x000BF3CC File Offset: 0x000BD5CC
		// (set) Token: 0x060022E2 RID: 8930 RVA: 0x0000BC46 File Offset: 0x00009E46
		public unsafe long append_startpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_append_startpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_append_startpos)) = value;
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x060022E3 RID: 8931 RVA: 0x000BF3F4 File Offset: 0x000BD5F4
		// (set) Token: 0x060022E4 RID: 8932 RVA: 0x0000BC61 File Offset: 0x00009E61
		public unsafe FileAccess access
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_access);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_access)) = value;
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x000BF41C File Offset: 0x000BD61C
		// (set) Token: 0x060022E6 RID: 8934 RVA: 0x0000BC7C File Offset: 0x00009E7C
		public unsafe bool owner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_owner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_owner)) = value;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060022E7 RID: 8935 RVA: 0x000BF444 File Offset: 0x000BD644
		// (set) Token: 0x060022E8 RID: 8936 RVA: 0x0000BC97 File Offset: 0x00009E97
		public unsafe bool async
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_async);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_async)) = value;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060022E9 RID: 8937 RVA: 0x000BF46C File Offset: 0x000BD66C
		// (set) Token: 0x060022EA RID: 8938 RVA: 0x0000BCB2 File Offset: 0x00009EB2
		public unsafe bool canseek
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_canseek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_canseek)) = value;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060022EB RID: 8939 RVA: 0x000BF494 File Offset: 0x000BD694
		// (set) Token: 0x060022EC RID: 8940 RVA: 0x0000BCCD File Offset: 0x00009ECD
		public unsafe bool anonymous
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_anonymous);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_anonymous)) = value;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x000BF4BC File Offset: 0x000BD6BC
		// (set) Token: 0x060022EE RID: 8942 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		public unsafe bool buf_dirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_dirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_dirty)) = value;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x000BF4E4 File Offset: 0x000BD6E4
		// (set) Token: 0x060022F0 RID: 8944 RVA: 0x0000BD03 File Offset: 0x00009F03
		public unsafe int buf_size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_size)) = value;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060022F1 RID: 8945 RVA: 0x000BF50C File Offset: 0x000BD70C
		// (set) Token: 0x060022F2 RID: 8946 RVA: 0x0000BD1E File Offset: 0x00009F1E
		public unsafe int buf_length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_length)) = value;
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x000BF534 File Offset: 0x000BD734
		// (set) Token: 0x060022F4 RID: 8948 RVA: 0x0000BD39 File Offset: 0x00009F39
		public unsafe int buf_offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_offset)) = value;
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x000BF55C File Offset: 0x000BD75C
		// (set) Token: 0x060022F6 RID: 8950 RVA: 0x0000BD54 File Offset: 0x00009F54
		public unsafe long buf_start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStream.NativeFieldInfoPtr_buf_start)) = value;
			}
		}

		// Token: 0x04001F10 RID: 7952
		private static readonly IntPtr NativeFieldInfoPtr_buf_recycle;

		// Token: 0x04001F11 RID: 7953
		private static readonly IntPtr NativeFieldInfoPtr_buf_recycle_lock;

		// Token: 0x04001F12 RID: 7954
		private static readonly IntPtr NativeFieldInfoPtr_buf;

		// Token: 0x04001F13 RID: 7955
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001F14 RID: 7956
		private static readonly IntPtr NativeFieldInfoPtr_safeHandle;

		// Token: 0x04001F15 RID: 7957
		private static readonly IntPtr NativeFieldInfoPtr_isExposed;

		// Token: 0x04001F16 RID: 7958
		private static readonly IntPtr NativeFieldInfoPtr_append_startpos;

		// Token: 0x04001F17 RID: 7959
		private static readonly IntPtr NativeFieldInfoPtr_access;

		// Token: 0x04001F18 RID: 7960
		private static readonly IntPtr NativeFieldInfoPtr_owner;

		// Token: 0x04001F19 RID: 7961
		private static readonly IntPtr NativeFieldInfoPtr_async;

		// Token: 0x04001F1A RID: 7962
		private static readonly IntPtr NativeFieldInfoPtr_canseek;

		// Token: 0x04001F1B RID: 7963
		private static readonly IntPtr NativeFieldInfoPtr_anonymous;

		// Token: 0x04001F1C RID: 7964
		private static readonly IntPtr NativeFieldInfoPtr_buf_dirty;

		// Token: 0x04001F1D RID: 7965
		private static readonly IntPtr NativeFieldInfoPtr_buf_size;

		// Token: 0x04001F1E RID: 7966
		private static readonly IntPtr NativeFieldInfoPtr_buf_length;

		// Token: 0x04001F1F RID: 7967
		private static readonly IntPtr NativeFieldInfoPtr_buf_offset;

		// Token: 0x04001F20 RID: 7968
		private static readonly IntPtr NativeFieldInfoPtr_buf_start;

		// Token: 0x04001F21 RID: 7969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_FileAccess_Boolean_Int32_Boolean_Boolean_0;

		// Token: 0x04001F22 RID: 7970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_0;

		// Token: 0x04001F23 RID: 7971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_0;

		// Token: 0x04001F24 RID: 7972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_0;

		// Token: 0x04001F25 RID: 7973
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_Int32_0;

		// Token: 0x04001F26 RID: 7974
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_Int32_Boolean_0;

		// Token: 0x04001F27 RID: 7975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_FileMode_FileAccess_FileShare_Int32_FileOptions_0;

		// Token: 0x04001F28 RID: 7976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_FileMode_FileAccess_FileShare_Int32_FileOptions_String_Boolean_Boolean_Boolean_0;

		// Token: 0x04001F29 RID: 7977
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_FileMode_FileAccess_FileShare_Int32_Boolean_Boolean_0;

		// Token: 0x04001F2A RID: 7978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_FileMode_FileAccess_FileShare_Int32_Boolean_FileOptions_0;

		// Token: 0x04001F2B RID: 7979
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_SafeFileHandle_FileAccess_Boolean_Int32_Boolean_Boolean_0;

		// Token: 0x04001F2C RID: 7980
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

		// Token: 0x04001F2D RID: 7981
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

		// Token: 0x04001F2E RID: 7982
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

		// Token: 0x04001F2F RID: 7983
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

		// Token: 0x04001F30 RID: 7984
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

		// Token: 0x04001F31 RID: 7985
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

		// Token: 0x04001F32 RID: 7986
		private static readonly IntPtr NativeMethodInfoPtr_get_SafeFileHandle_Public_Virtual_New_get_SafeFileHandle_0;

		// Token: 0x04001F33 RID: 7987
		private static readonly IntPtr NativeMethodInfoPtr_ExposeHandle_Private_Void_0;

		// Token: 0x04001F34 RID: 7988
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0;

		// Token: 0x04001F35 RID: 7989
		private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0;

		// Token: 0x04001F36 RID: 7990
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001F37 RID: 7991
		private static readonly IntPtr NativeMethodInfoPtr_ReadInternal_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001F38 RID: 7992
		private static readonly IntPtr NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04001F39 RID: 7993
		private static readonly IntPtr NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0;

		// Token: 0x04001F3A RID: 7994
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001F3B RID: 7995
		private static readonly IntPtr NativeMethodInfoPtr_WriteInternal_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001F3C RID: 7996
		private static readonly IntPtr NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04001F3D RID: 7997
		private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0;

		// Token: 0x04001F3E RID: 7998
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

		// Token: 0x04001F3F RID: 7999
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x04001F40 RID: 8000
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001F41 RID: 8001
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04001F42 RID: 8002
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04001F43 RID: 8003
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04001F44 RID: 8004
		private static readonly IntPtr NativeMethodInfoPtr_ReadSegment_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001F45 RID: 8005
		private static readonly IntPtr NativeMethodInfoPtr_WriteSegment_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001F46 RID: 8006
		private static readonly IntPtr NativeMethodInfoPtr_FlushBuffer_Private_Void_0;

		// Token: 0x04001F47 RID: 8007
		private static readonly IntPtr NativeMethodInfoPtr_FlushBufferIfDirty_Private_Void_0;

		// Token: 0x04001F48 RID: 8008
		private static readonly IntPtr NativeMethodInfoPtr_RefillBuffer_Private_Void_0;

		// Token: 0x04001F49 RID: 8009
		private static readonly IntPtr NativeMethodInfoPtr_ReadData_Private_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001F4A RID: 8010
		private static readonly IntPtr NativeMethodInfoPtr_InitBuffer_Private_Void_Int32_Boolean_0;

		// Token: 0x04001F4B RID: 8011
		private static readonly IntPtr NativeMethodInfoPtr_GetSecureFileName_Private_String_String_0;

		// Token: 0x04001F4C RID: 8012
		private static readonly IntPtr NativeMethodInfoPtr_GetSecureFileName_Private_String_String_Boolean_0;

		// Token: 0x020005DA RID: 1498
		public sealed class ReadDelegate : MulticastDelegate
		{
			// Token: 0x060051F7 RID: 20983 RVA: 0x0016E254 File Offset: 0x0016C454
			// Note: this type is marked as 'beforefieldinit'.
			static ReadDelegate()
			{
				Il2CppClassPointerStore<FileStream.ReadDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "ReadDelegate");
				FileStream.ReadDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream.ReadDelegate>.NativeClassPtr, 100669152);
				FileStream.ReadDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream.ReadDelegate>.NativeClassPtr, 100669153);
				FileStream.ReadDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream.ReadDelegate>.NativeClassPtr, 100669154);
				FileStream.ReadDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream.ReadDelegate>.NativeClassPtr, 100669155);
			}

			// Token: 0x060051F8 RID: 20984 RVA: 0x0016E2C8 File Offset: 0x0016C4C8
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream.ReadDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.ReadDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051F9 RID: 20985 RVA: 0x0016E324 File Offset: 0x0016C524
			[CallerCount(0)]
			public unsafe int Invoke(Il2CppStructArray<byte> buffer, int offset, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.ReadDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051FA RID: 20986 RVA: 0x0016E390 File Offset: 0x0016C590
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 322788, RefRangeEnd = 322789, XrefRangeStart = 322782, XrefRangeEnd = 322788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.ReadDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060051FB RID: 20987 RVA: 0x0016E424 File Offset: 0x0016C624
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43352, RefRangeEnd = 43355, XrefRangeStart = 43352, XrefRangeEnd = 43355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.ReadDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051FC RID: 20988 RVA: 0x0001F36B File Offset: 0x0001D56B
			public ReadDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060051FD RID: 20989 RVA: 0x0001F374 File Offset: 0x0001D574
			public static implicit operator FileStream.ReadDelegate(Func<Il2CppStructArray<byte>, int, int, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<FileStream.ReadDelegate>(A_0);
			}

			// Token: 0x060051FE RID: 20990 RVA: 0x0001F37C File Offset: 0x0001D57C
			public static FileStream.ReadDelegate operator +(FileStream.ReadDelegate A_0, FileStream.ReadDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<FileStream.ReadDelegate>();
			}

			// Token: 0x060051FF RID: 20991 RVA: 0x0001F38A File Offset: 0x0001D58A
			public static FileStream.ReadDelegate operator -(FileStream.ReadDelegate A_0, FileStream.ReadDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<FileStream.ReadDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04004255 RID: 16981
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04004256 RID: 16982
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x04004257 RID: 16983
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

			// Token: 0x04004258 RID: 16984
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
		}

		// Token: 0x020005DB RID: 1499
		public sealed class WriteDelegate : MulticastDelegate
		{
			// Token: 0x06005200 RID: 20992 RVA: 0x0016E474 File Offset: 0x0016C674
			// Note: this type is marked as 'beforefieldinit'.
			static WriteDelegate()
			{
				Il2CppClassPointerStore<FileStream.WriteDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileStream>.NativeClassPtr, "WriteDelegate");
				FileStream.WriteDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream.WriteDelegate>.NativeClassPtr, 100669156);
				FileStream.WriteDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream.WriteDelegate>.NativeClassPtr, 100669157);
				FileStream.WriteDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream.WriteDelegate>.NativeClassPtr, 100669158);
				FileStream.WriteDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStream.WriteDelegate>.NativeClassPtr, 100669159);
			}

			// Token: 0x06005201 RID: 20993 RVA: 0x0016E4E8 File Offset: 0x0016C6E8
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WriteDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStream.WriteDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.WriteDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005202 RID: 20994 RVA: 0x0016E544 File Offset: 0x0016C744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Il2CppStructArray<byte> buffer, int offset, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.WriteDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005203 RID: 20995 RVA: 0x0016E5A4 File Offset: 0x0016C7A4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 322795, RefRangeEnd = 322796, XrefRangeStart = 322789, XrefRangeEnd = 322795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.WriteDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06005204 RID: 20996 RVA: 0x0016E638 File Offset: 0x0016C838
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStream.WriteDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005205 RID: 20997 RVA: 0x0001F39B File Offset: 0x0001D59B
			public WriteDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005206 RID: 20998 RVA: 0x0001F3A4 File Offset: 0x0001D5A4
			public static implicit operator FileStream.WriteDelegate(Action<Il2CppStructArray<byte>, int, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<FileStream.WriteDelegate>(A_0);
			}

			// Token: 0x06005207 RID: 20999 RVA: 0x0001F3AC File Offset: 0x0001D5AC
			public static FileStream.WriteDelegate operator +(FileStream.WriteDelegate A_0, FileStream.WriteDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<FileStream.WriteDelegate>();
			}

			// Token: 0x06005208 RID: 21000 RVA: 0x0001F3BA File Offset: 0x0001D5BA
			public static FileStream.WriteDelegate operator -(FileStream.WriteDelegate A_0, FileStream.WriteDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<FileStream.WriteDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04004259 RID: 16985
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400425A RID: 16986
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x0400425B RID: 16987
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

			// Token: 0x0400425C RID: 16988
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}

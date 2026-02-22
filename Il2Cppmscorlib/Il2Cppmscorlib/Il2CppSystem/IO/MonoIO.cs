using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.IO
{
	// Token: 0x0200021C RID: 540
	public static class MonoIO : Object
	{
		// Token: 0x06002311 RID: 8977 RVA: 0x000BF9F8 File Offset: 0x000BDBF8
		// Note: this type is marked as 'beforefieldinit'.
		static MonoIO()
		{
			Il2CppClassPointerStore<MonoIO>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "MonoIO");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoIO>.NativeClassPtr);
			MonoIO.NativeFieldInfoPtr_InvalidHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, "InvalidHandle");
			MonoIO.NativeFieldInfoPtr_dump_handles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, "dump_handles");
			MonoIO.NativeMethodInfoPtr_GetException_Public_Static_Exception_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669166);
			MonoIO.NativeMethodInfoPtr_GetException_Public_Static_Exception_String_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669167);
			MonoIO.NativeMethodInfoPtr_CreateDirectory_Private_Static_Boolean_ptr_Char_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669168);
			MonoIO.NativeMethodInfoPtr_CreateDirectory_Public_Static_Boolean_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669169);
			MonoIO.NativeMethodInfoPtr_RemoveDirectory_Private_Static_Boolean_ptr_Char_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669170);
			MonoIO.NativeMethodInfoPtr_RemoveDirectory_Public_Static_Boolean_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669171);
			MonoIO.NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669172);
			MonoIO.NativeMethodInfoPtr_CopyFile_Private_Static_Boolean_ptr_Char_ptr_Char_Boolean_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669173);
			MonoIO.NativeMethodInfoPtr_CopyFile_Public_Static_Boolean_String_String_Boolean_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669174);
			MonoIO.NativeMethodInfoPtr_DeleteFile_Private_Static_Boolean_ptr_Char_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669175);
			MonoIO.NativeMethodInfoPtr_DeleteFile_Public_Static_Boolean_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669176);
			MonoIO.NativeMethodInfoPtr_GetFileAttributes_Private_Static_FileAttributes_ptr_Char_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669177);
			MonoIO.NativeMethodInfoPtr_GetFileAttributes_Public_Static_FileAttributes_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669178);
			MonoIO.NativeMethodInfoPtr_GetFileType_Private_Static_MonoFileType_IntPtr_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669179);
			MonoIO.NativeMethodInfoPtr_GetFileType_Public_Static_MonoFileType_SafeHandle_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669180);
			MonoIO.NativeMethodInfoPtr_FindFirstFile_Private_Static_IntPtr_ptr_Char_byref_String_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669181);
			MonoIO.NativeMethodInfoPtr_FindFirstFile_Public_Static_IntPtr_String_byref_String_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669182);
			MonoIO.NativeMethodInfoPtr_FindNextFile_Public_Static_Boolean_IntPtr_byref_String_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669183);
			MonoIO.NativeMethodInfoPtr_FindCloseFile_Public_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669184);
			MonoIO.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669185);
			MonoIO.NativeMethodInfoPtr_ExistsFile_Public_Static_Boolean_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669186);
			MonoIO.NativeMethodInfoPtr_ExistsDirectory_Public_Static_Boolean_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669187);
			MonoIO.NativeMethodInfoPtr_ExistsSymlink_Public_Static_Boolean_String_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669188);
			MonoIO.NativeMethodInfoPtr_GetFileStat_Private_Static_Boolean_ptr_Char_byref_MonoIOStat_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669189);
			MonoIO.NativeMethodInfoPtr_GetFileStat_Public_Static_Boolean_String_byref_MonoIOStat_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669190);
			MonoIO.NativeMethodInfoPtr_Open_Private_Static_IntPtr_ptr_Char_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669191);
			MonoIO.NativeMethodInfoPtr_Open_Public_Static_IntPtr_String_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669192);
			MonoIO.NativeMethodInfoPtr_Close_Public_Static_Boolean_IntPtr_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669193);
			MonoIO.NativeMethodInfoPtr_Read_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669194);
			MonoIO.NativeMethodInfoPtr_Read_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669195);
			MonoIO.NativeMethodInfoPtr_Write_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669196);
			MonoIO.NativeMethodInfoPtr_Write_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669197);
			MonoIO.NativeMethodInfoPtr_Seek_Private_Static_Int64_IntPtr_Int64_SeekOrigin_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669198);
			MonoIO.NativeMethodInfoPtr_Seek_Public_Static_Int64_SafeHandle_Int64_SeekOrigin_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669199);
			MonoIO.NativeMethodInfoPtr_GetLength_Private_Static_Int64_IntPtr_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669200);
			MonoIO.NativeMethodInfoPtr_GetLength_Public_Static_Int64_SafeHandle_byref_MonoIOError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669201);
			MonoIO.NativeMethodInfoPtr_get_ConsoleOutput_Public_Static_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669202);
			MonoIO.NativeMethodInfoPtr_get_ConsoleInput_Public_Static_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669203);
			MonoIO.NativeMethodInfoPtr_get_ConsoleError_Public_Static_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669204);
			MonoIO.NativeMethodInfoPtr_get_VolumeSeparatorChar_Public_Static_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669205);
			MonoIO.NativeMethodInfoPtr_get_DirectorySeparatorChar_Public_Static_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669206);
			MonoIO.NativeMethodInfoPtr_get_AltDirectorySeparatorChar_Public_Static_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669207);
			MonoIO.NativeMethodInfoPtr_get_PathSeparator_Public_Static_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669208);
			MonoIO.NativeMethodInfoPtr_DumpHandles_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669209);
			MonoIO.NativeMethodInfoPtr_RemapPath_Public_Static_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoIO>.NativeClassPtr, 100669210);
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x000BFDD4 File Offset: 0x000BDFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323199, XrefRangeEnd = 323209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetException(MonoIOError error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetException_Public_Static_Exception_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x000BFE14 File Offset: 0x000BE014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323209, XrefRangeEnd = 323351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetException(string path, MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetException_Public_Static_Exception_String_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x000BFE68 File Offset: 0x000BE068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323351, XrefRangeEnd = 323352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateDirectory(char* path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = path;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_CreateDirectory_Private_Static_Boolean_ptr_Char_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x000BFEB4 File Offset: 0x000BE0B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323357, RefRangeEnd = 323358, XrefRangeStart = 323352, XrefRangeEnd = 323357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateDirectory(string path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_CreateDirectory_Public_Static_Boolean_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x000BFF04 File Offset: 0x000BE104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323358, XrefRangeEnd = 323359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoveDirectory(char* path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = path;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_RemoveDirectory_Private_Static_Boolean_ptr_Char_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x000BFF50 File Offset: 0x000BE150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323364, RefRangeEnd = 323365, XrefRangeStart = 323359, XrefRangeEnd = 323364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoveDirectory(string path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_RemoveDirectory_Public_Static_Boolean_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x000BFFA0 File Offset: 0x000BE1A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323366, RefRangeEnd = 323368, XrefRangeStart = 323365, XrefRangeEnd = 323366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCurrentDirectory(out MonoIOError error)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x000BFFD8 File Offset: 0x000BE1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323368, XrefRangeEnd = 323369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CopyFile(char* path, char* dest, bool overwrite, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = path;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = dest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overwrite;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_CopyFile_Private_Static_Boolean_ptr_Char_ptr_Char_Boolean_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x000C0040 File Offset: 0x000BE240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323375, RefRangeEnd = 323376, XrefRangeStart = 323369, XrefRangeEnd = 323375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CopyFile(string path, string dest, bool overwrite, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overwrite;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_CopyFile_Public_Static_Boolean_String_String_Boolean_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x000C00B0 File Offset: 0x000BE2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323376, XrefRangeEnd = 323377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeleteFile(char* path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = path;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_DeleteFile_Private_Static_Boolean_ptr_Char_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x000C00FC File Offset: 0x000BE2FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 323382, RefRangeEnd = 323385, XrefRangeStart = 323377, XrefRangeEnd = 323382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeleteFile(string path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_DeleteFile_Public_Static_Boolean_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x000C014C File Offset: 0x000BE34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323385, XrefRangeEnd = 323386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileAttributes GetFileAttributes(char* path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = path;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetFileAttributes_Private_Static_FileAttributes_ptr_Char_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x000C0198 File Offset: 0x000BE398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323391, RefRangeEnd = 323392, XrefRangeStart = 323386, XrefRangeEnd = 323391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileAttributes GetFileAttributes(string path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetFileAttributes_Public_Static_FileAttributes_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x000C01E8 File Offset: 0x000BE3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323392, XrefRangeEnd = 323393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoFileType GetFileType(IntPtr handle, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetFileType_Private_Static_MonoFileType_IntPtr_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x000C0234 File Offset: 0x000BE434
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323400, RefRangeEnd = 323402, XrefRangeStart = 323393, XrefRangeEnd = 323400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetFileType_Public_Static_MonoFileType_SafeHandle_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x000C0284 File Offset: 0x000BE484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323402, XrefRangeEnd = 323403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr FindFirstFile(char* pathWithPattern, out string fileName, out int fileAttr, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pathWithPattern;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &fileAttr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_FindFirstFile_Private_Static_IntPtr_ptr_Char_byref_String_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			fileName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x000C02F8 File Offset: 0x000BE4F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 323408, RefRangeEnd = 323411, XrefRangeStart = 323403, XrefRangeEnd = 323408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr FindFirstFile(string pathWithPattern, out string fileName, out int fileAttr, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pathWithPattern);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &fileAttr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_FindFirstFile_Public_Static_IntPtr_String_byref_String_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			fileName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x000C0370 File Offset: 0x000BE570
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323412, RefRangeEnd = 323414, XrefRangeStart = 323411, XrefRangeEnd = 323412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FindNextFile(IntPtr hnd, out string fileName, out int fileAttr, out int error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hnd;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &fileAttr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_FindNextFile_Public_Static_Boolean_IntPtr_byref_String_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			fileName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x000C03E4 File Offset: 0x000BE5E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323415, RefRangeEnd = 323416, XrefRangeStart = 323414, XrefRangeEnd = 323415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FindCloseFile(IntPtr hnd)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hnd;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_FindCloseFile_Public_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x000C0424 File Offset: 0x000BE624
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323426, RefRangeEnd = 323428, XrefRangeStart = 323416, XrefRangeEnd = 323426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Exists(string path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x000C0474 File Offset: 0x000BE674
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323438, RefRangeEnd = 323439, XrefRangeStart = 323428, XrefRangeEnd = 323438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExistsFile(string path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_ExistsFile_Public_Static_Boolean_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x000C04C4 File Offset: 0x000BE6C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323449, RefRangeEnd = 323450, XrefRangeStart = 323439, XrefRangeEnd = 323449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExistsDirectory(string path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_ExistsDirectory_Public_Static_Boolean_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x000C0514 File Offset: 0x000BE714
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323460, RefRangeEnd = 323462, XrefRangeStart = 323450, XrefRangeEnd = 323460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExistsSymlink(string path, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_ExistsSymlink_Public_Static_Boolean_String_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x000C0564 File Offset: 0x000BE764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323462, XrefRangeEnd = 323463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetFileStat(char* path, out MonoIOStat stat, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = path;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetFileStat_Private_Static_Boolean_ptr_Char_byref_MonoIOStat_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x000C05BC File Offset: 0x000BE7BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 323468, RefRangeEnd = 323471, XrefRangeStart = 323463, XrefRangeEnd = 323468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetFileStat(string path, out MonoIOStat stat, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stat;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetFileStat_Public_Static_Boolean_String_byref_MonoIOStat_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x000C061C File Offset: 0x000BE81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323471, XrefRangeEnd = 323472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = filename;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Open_Private_Static_IntPtr_ptr_Char_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x000C06A0 File Offset: 0x000BE8A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323477, RefRangeEnd = 323478, XrefRangeStart = 323472, XrefRangeEnd = 323477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref share;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Open_Public_Static_IntPtr_String_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x000C0728 File Offset: 0x000BE928
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323479, RefRangeEnd = 323481, XrefRangeStart = 323478, XrefRangeEnd = 323479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Close(IntPtr handle, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Close_Public_Static_Boolean_IntPtr_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x000C0774 File Offset: 0x000BE974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323481, XrefRangeEnd = 323482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Read(IntPtr handle, Il2CppStructArray<byte> dest, int dest_offset, int count, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dest_offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Read_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x000C07F0 File Offset: 0x000BE9F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323489, RefRangeEnd = 323490, XrefRangeStart = 323482, XrefRangeEnd = 323489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Read(SafeHandle safeHandle, Il2CppStructArray<byte> dest, int dest_offset, int count, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dest_offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Read_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x000C0870 File Offset: 0x000BEA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323490, XrefRangeEnd = 323491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Write(IntPtr handle, [In] Il2CppStructArray<byte> src, int src_offset, int count, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref src_offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Write_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x000C08EC File Offset: 0x000BEAEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323498, RefRangeEnd = 323500, XrefRangeStart = 323491, XrefRangeEnd = 323498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Write(SafeHandle safeHandle, Il2CppStructArray<byte> src, int src_offset, int count, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref src_offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Write_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x000C096C File Offset: 0x000BEB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323500, XrefRangeEnd = 323501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Seek_Private_Static_Int64_IntPtr_Int64_SeekOrigin_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x000C09D4 File Offset: 0x000BEBD4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 323508, RefRangeEnd = 323513, XrefRangeStart = 323501, XrefRangeEnd = 323508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_Seek_Public_Static_Int64_SafeHandle_Int64_SeekOrigin_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x000C0A40 File Offset: 0x000BEC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323513, XrefRangeEnd = 323514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetLength(IntPtr handle, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetLength_Private_Static_Int64_IntPtr_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x000C0A8C File Offset: 0x000BEC8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323521, RefRangeEnd = 323522, XrefRangeStart = 323514, XrefRangeEnd = 323521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetLength(SafeHandle safeHandle, out MonoIOError error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_GetLength_Public_Static_Int64_SafeHandle_byref_MonoIOError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x000C0ADC File Offset: 0x000BECDC
		public unsafe static IntPtr ConsoleOutput
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 323523, RefRangeEnd = 323525, XrefRangeStart = 323522, XrefRangeEnd = 323523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_ConsoleOutput_Public_Static_get_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06002337 RID: 9015 RVA: 0x000C0B0C File Offset: 0x000BED0C
		public unsafe static IntPtr ConsoleInput
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 323526, RefRangeEnd = 323528, XrefRangeStart = 323525, XrefRangeEnd = 323526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_ConsoleInput_Public_Static_get_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06002338 RID: 9016 RVA: 0x000C0B3C File Offset: 0x000BED3C
		public unsafe static IntPtr ConsoleError
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 323529, RefRangeEnd = 323530, XrefRangeStart = 323528, XrefRangeEnd = 323529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_ConsoleError_Public_Static_get_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06002339 RID: 9017 RVA: 0x000C0B6C File Offset: 0x000BED6C
		public unsafe static char VolumeSeparatorChar
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323530, XrefRangeEnd = 323531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_VolumeSeparatorChar_Public_Static_get_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x000C0B9C File Offset: 0x000BED9C
		public unsafe static char DirectorySeparatorChar
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323531, XrefRangeEnd = 323532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_DirectorySeparatorChar_Public_Static_get_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x0600233B RID: 9019 RVA: 0x000C0BCC File Offset: 0x000BEDCC
		public unsafe static char AltDirectorySeparatorChar
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323532, XrefRangeEnd = 323533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_AltDirectorySeparatorChar_Public_Static_get_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x0600233C RID: 9020 RVA: 0x000C0BFC File Offset: 0x000BEDFC
		public unsafe static char PathSeparator
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323533, XrefRangeEnd = 323534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_get_PathSeparator_Public_Static_get_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x000C0C2C File Offset: 0x000BEE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DumpHandles()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_DumpHandles_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x000C0C54 File Offset: 0x000BEE54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323535, RefRangeEnd = 323536, XrefRangeStart = 323534, XrefRangeEnd = 323535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemapPath(string path, out string newPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MonoIO.NativeMethodInfoPtr_RemapPath_Public_Static_Boolean_String_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			newPath = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x0000BE7B File Offset: 0x0000A07B
		public MonoIO(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06002340 RID: 9024 RVA: 0x000C0CB0 File Offset: 0x000BEEB0
		// (set) Token: 0x06002341 RID: 9025 RVA: 0x0000BE84 File Offset: 0x0000A084
		public unsafe static IntPtr InvalidHandle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoIO.NativeFieldInfoPtr_InvalidHandle, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoIO.NativeFieldInfoPtr_InvalidHandle, (void*)(&value));
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06002342 RID: 9026 RVA: 0x000C0CCC File Offset: 0x000BEECC
		// (set) Token: 0x06002343 RID: 9027 RVA: 0x0000BE92 File Offset: 0x0000A092
		public unsafe static bool dump_handles
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(MonoIO.NativeFieldInfoPtr_dump_handles, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoIO.NativeFieldInfoPtr_dump_handles, (void*)(&value));
			}
		}

		// Token: 0x04001F62 RID: 8034
		private static readonly IntPtr NativeFieldInfoPtr_InvalidHandle;

		// Token: 0x04001F63 RID: 8035
		private static readonly IntPtr NativeFieldInfoPtr_dump_handles;

		// Token: 0x04001F64 RID: 8036
		private static readonly IntPtr NativeMethodInfoPtr_GetException_Public_Static_Exception_MonoIOError_0;

		// Token: 0x04001F65 RID: 8037
		private static readonly IntPtr NativeMethodInfoPtr_GetException_Public_Static_Exception_String_MonoIOError_0;

		// Token: 0x04001F66 RID: 8038
		private static readonly IntPtr NativeMethodInfoPtr_CreateDirectory_Private_Static_Boolean_ptr_Char_byref_MonoIOError_0;

		// Token: 0x04001F67 RID: 8039
		private static readonly IntPtr NativeMethodInfoPtr_CreateDirectory_Public_Static_Boolean_String_byref_MonoIOError_0;

		// Token: 0x04001F68 RID: 8040
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDirectory_Private_Static_Boolean_ptr_Char_byref_MonoIOError_0;

		// Token: 0x04001F69 RID: 8041
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDirectory_Public_Static_Boolean_String_byref_MonoIOError_0;

		// Token: 0x04001F6A RID: 8042
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_byref_MonoIOError_0;

		// Token: 0x04001F6B RID: 8043
		private static readonly IntPtr NativeMethodInfoPtr_CopyFile_Private_Static_Boolean_ptr_Char_ptr_Char_Boolean_byref_MonoIOError_0;

		// Token: 0x04001F6C RID: 8044
		private static readonly IntPtr NativeMethodInfoPtr_CopyFile_Public_Static_Boolean_String_String_Boolean_byref_MonoIOError_0;

		// Token: 0x04001F6D RID: 8045
		private static readonly IntPtr NativeMethodInfoPtr_DeleteFile_Private_Static_Boolean_ptr_Char_byref_MonoIOError_0;

		// Token: 0x04001F6E RID: 8046
		private static readonly IntPtr NativeMethodInfoPtr_DeleteFile_Public_Static_Boolean_String_byref_MonoIOError_0;

		// Token: 0x04001F6F RID: 8047
		private static readonly IntPtr NativeMethodInfoPtr_GetFileAttributes_Private_Static_FileAttributes_ptr_Char_byref_MonoIOError_0;

		// Token: 0x04001F70 RID: 8048
		private static readonly IntPtr NativeMethodInfoPtr_GetFileAttributes_Public_Static_FileAttributes_String_byref_MonoIOError_0;

		// Token: 0x04001F71 RID: 8049
		private static readonly IntPtr NativeMethodInfoPtr_GetFileType_Private_Static_MonoFileType_IntPtr_byref_MonoIOError_0;

		// Token: 0x04001F72 RID: 8050
		private static readonly IntPtr NativeMethodInfoPtr_GetFileType_Public_Static_MonoFileType_SafeHandle_byref_MonoIOError_0;

		// Token: 0x04001F73 RID: 8051
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstFile_Private_Static_IntPtr_ptr_Char_byref_String_byref_Int32_byref_Int32_0;

		// Token: 0x04001F74 RID: 8052
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstFile_Public_Static_IntPtr_String_byref_String_byref_Int32_byref_Int32_0;

		// Token: 0x04001F75 RID: 8053
		private static readonly IntPtr NativeMethodInfoPtr_FindNextFile_Public_Static_Boolean_IntPtr_byref_String_byref_Int32_byref_Int32_0;

		// Token: 0x04001F76 RID: 8054
		private static readonly IntPtr NativeMethodInfoPtr_FindCloseFile_Public_Static_Boolean_IntPtr_0;

		// Token: 0x04001F77 RID: 8055
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_byref_MonoIOError_0;

		// Token: 0x04001F78 RID: 8056
		private static readonly IntPtr NativeMethodInfoPtr_ExistsFile_Public_Static_Boolean_String_byref_MonoIOError_0;

		// Token: 0x04001F79 RID: 8057
		private static readonly IntPtr NativeMethodInfoPtr_ExistsDirectory_Public_Static_Boolean_String_byref_MonoIOError_0;

		// Token: 0x04001F7A RID: 8058
		private static readonly IntPtr NativeMethodInfoPtr_ExistsSymlink_Public_Static_Boolean_String_byref_MonoIOError_0;

		// Token: 0x04001F7B RID: 8059
		private static readonly IntPtr NativeMethodInfoPtr_GetFileStat_Private_Static_Boolean_ptr_Char_byref_MonoIOStat_byref_MonoIOError_0;

		// Token: 0x04001F7C RID: 8060
		private static readonly IntPtr NativeMethodInfoPtr_GetFileStat_Public_Static_Boolean_String_byref_MonoIOStat_byref_MonoIOError_0;

		// Token: 0x04001F7D RID: 8061
		private static readonly IntPtr NativeMethodInfoPtr_Open_Private_Static_IntPtr_ptr_Char_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0;

		// Token: 0x04001F7E RID: 8062
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Static_IntPtr_String_FileMode_FileAccess_FileShare_FileOptions_byref_MonoIOError_0;

		// Token: 0x04001F7F RID: 8063
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Static_Boolean_IntPtr_byref_MonoIOError_0;

		// Token: 0x04001F80 RID: 8064
		private static readonly IntPtr NativeMethodInfoPtr_Read_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0;

		// Token: 0x04001F81 RID: 8065
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0;

		// Token: 0x04001F82 RID: 8066
		private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Static_Int32_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0;

		// Token: 0x04001F83 RID: 8067
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_Int32_SafeHandle_Il2CppStructArray_1_Byte_Int32_Int32_byref_MonoIOError_0;

		// Token: 0x04001F84 RID: 8068
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Private_Static_Int64_IntPtr_Int64_SeekOrigin_byref_MonoIOError_0;

		// Token: 0x04001F85 RID: 8069
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Static_Int64_SafeHandle_Int64_SeekOrigin_byref_MonoIOError_0;

		// Token: 0x04001F86 RID: 8070
		private static readonly IntPtr NativeMethodInfoPtr_GetLength_Private_Static_Int64_IntPtr_byref_MonoIOError_0;

		// Token: 0x04001F87 RID: 8071
		private static readonly IntPtr NativeMethodInfoPtr_GetLength_Public_Static_Int64_SafeHandle_byref_MonoIOError_0;

		// Token: 0x04001F88 RID: 8072
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsoleOutput_Public_Static_get_IntPtr_0;

		// Token: 0x04001F89 RID: 8073
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsoleInput_Public_Static_get_IntPtr_0;

		// Token: 0x04001F8A RID: 8074
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsoleError_Public_Static_get_IntPtr_0;

		// Token: 0x04001F8B RID: 8075
		private static readonly IntPtr NativeMethodInfoPtr_get_VolumeSeparatorChar_Public_Static_get_Char_0;

		// Token: 0x04001F8C RID: 8076
		private static readonly IntPtr NativeMethodInfoPtr_get_DirectorySeparatorChar_Public_Static_get_Char_0;

		// Token: 0x04001F8D RID: 8077
		private static readonly IntPtr NativeMethodInfoPtr_get_AltDirectorySeparatorChar_Public_Static_get_Char_0;

		// Token: 0x04001F8E RID: 8078
		private static readonly IntPtr NativeMethodInfoPtr_get_PathSeparator_Public_Static_get_Char_0;

		// Token: 0x04001F8F RID: 8079
		private static readonly IntPtr NativeMethodInfoPtr_DumpHandles_Private_Static_Void_0;

		// Token: 0x04001F90 RID: 8080
		private static readonly IntPtr NativeMethodInfoPtr_RemapPath_Public_Static_Boolean_String_byref_String_0;
	}
}

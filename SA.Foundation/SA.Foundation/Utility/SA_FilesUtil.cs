using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Foundation.Utility
{
	// Token: 0x02000013 RID: 19
	public static class SA_FilesUtil : Object
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00005814 File Offset: 0x00003A14
		// Note: this type is marked as 'beforefieldinit'.
		static SA_FilesUtil()
		{
			Il2CppClassPointerStore<SA_FilesUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Utility", "SA_FilesUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_FilesUtil>.NativeClassPtr);
			SA_FilesUtil.NativeMethodInfoPtr_CreateFile_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FilesUtil>.NativeClassPtr, 100663379);
			SA_FilesUtil.NativeMethodInfoPtr_DeleteFile_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FilesUtil>.NativeClassPtr, 100663380);
			SA_FilesUtil.NativeMethodInfoPtr_IsDirectoryExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FilesUtil>.NativeClassPtr, 100663381);
			SA_FilesUtil.NativeMethodInfoPtr_IsFileExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FilesUtil>.NativeClassPtr, 100663382);
			SA_FilesUtil.NativeMethodInfoPtr_Write_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FilesUtil>.NativeClassPtr, 100663383);
			SA_FilesUtil.NativeMethodInfoPtr_WriteAllLines_Public_Static_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FilesUtil>.NativeClassPtr, 100663384);
			SA_FilesUtil.NativeMethodInfoPtr_Read_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FilesUtil>.NativeClassPtr, 100663385);
			SA_FilesUtil.NativeMethodInfoPtr_ReadAllLines_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FilesUtil>.NativeClassPtr, 100663386);
			SA_FilesUtil.NativeMethodInfoPtr_CopyFile_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FilesUtil>.NativeClassPtr, 100663387);
			SA_FilesUtil.NativeMethodInfoPtr_CopyDirectory_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FilesUtil>.NativeClassPtr, 100663388);
			SA_FilesUtil.NativeMethodInfoPtr_CreateDirectory_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FilesUtil>.NativeClassPtr, 100663389);
			SA_FilesUtil.NativeMethodInfoPtr_DeleteDirectory_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FilesUtil>.NativeClassPtr, 100663390);
			SA_FilesUtil.NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FilesUtil>.NativeClassPtr, 100663391);
			SA_FilesUtil.NativeMethodInfoPtr_FixRelativePath_Private_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FilesUtil>.NativeClassPtr, 100663392);
			SA_FilesUtil.NativeMethodInfoPtr_CreatePathFolders_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_FilesUtil>.NativeClassPtr, 100663393);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00005970 File Offset: 0x00003B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98753, XrefRangeEnd = 98764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateFile(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FilesUtil.NativeMethodInfoPtr_CreateFile_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000059A8 File Offset: 0x00003BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98764, XrefRangeEnd = 98768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteFile(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FilesUtil.NativeMethodInfoPtr_DeleteFile_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000059E0 File Offset: 0x00003BE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98605, RefRangeEnd = 98607, XrefRangeStart = 98605, XrefRangeEnd = 98607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDirectoryExists(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FilesUtil.NativeMethodInfoPtr_IsDirectoryExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00005A24 File Offset: 0x00003C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsFileExists(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FilesUtil.NativeMethodInfoPtr_IsFileExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00005A68 File Offset: 0x00003C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98768, XrefRangeEnd = 98782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Write(string path, string contents)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FilesUtil.NativeMethodInfoPtr_Write_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00005AB0 File Offset: 0x00003CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98782, XrefRangeEnd = 98793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteAllLines(string path, Il2CppStringArray contents)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FilesUtil.NativeMethodInfoPtr_WriteAllLines_Public_Static_Void_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00005AF8 File Offset: 0x00003CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98793, XrefRangeEnd = 98797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Read(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FilesUtil.NativeMethodInfoPtr_Read_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00005B34 File Offset: 0x00003D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98797, XrefRangeEnd = 98804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray ReadAllLines(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FilesUtil.NativeMethodInfoPtr_ReadAllLines_Public_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00005B78 File Offset: 0x00003D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98804, XrefRangeEnd = 98825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyFile(string srcPath, string destPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(srcPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FilesUtil.NativeMethodInfoPtr_CopyFile_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00005BC0 File Offset: 0x00003DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98825, XrefRangeEnd = 98855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyDirectory(string srcPath, string destPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(srcPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FilesUtil.NativeMethodInfoPtr_CopyDirectory_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00005C08 File Offset: 0x00003E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98855, XrefRangeEnd = 98866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateDirectory(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FilesUtil.NativeMethodInfoPtr_CreateDirectory_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00005C40 File Offset: 0x00003E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98866, XrefRangeEnd = 98868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteDirectory(string folderPath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(folderPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FilesUtil.NativeMethodInfoPtr_DeleteDirectory_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00005C78 File Offset: 0x00003E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98868, XrefRangeEnd = 98870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetDirectories(string folderPath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(folderPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FilesUtil.NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00005CBC File Offset: 0x00003EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98870, XrefRangeEnd = 98878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FixRelativePath(string path, bool createFolders = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createFolders;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FilesUtil.NativeMethodInfoPtr_FixRelativePath_Private_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00005D08 File Offset: 0x00003F08
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 98897, RefRangeEnd = 98905, XrefRangeStart = 98878, XrefRangeEnd = 98897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreatePathFolders(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_FilesUtil.NativeMethodInfoPtr_CreatePathFolders_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000021A7 File Offset: 0x000003A7
		public SA_FilesUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_CreateFile_Public_Static_Void_String_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_DeleteFile_Public_Static_Void_String_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_IsDirectoryExists_Public_Static_Boolean_String_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_IsFileExists_Public_Static_Boolean_String_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_Void_String_String_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_WriteAllLines_Public_Static_Void_String_Il2CppStringArray_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_String_String_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_ReadAllLines_Public_Static_Il2CppStringArray_String_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_CopyFile_Public_Static_Void_String_String_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_CopyDirectory_Public_Static_Void_String_String_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_CreateDirectory_Public_Static_Void_String_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_DeleteDirectory_Public_Static_Void_String_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_FixRelativePath_Private_Static_String_String_Boolean_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_CreatePathFolders_Private_Static_Void_String_0;
	}
}

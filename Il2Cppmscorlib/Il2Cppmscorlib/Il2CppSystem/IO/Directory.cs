using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x020001F7 RID: 503
	public static class Directory : Object
	{
		// Token: 0x0600205D RID: 8285 RVA: 0x000B3DD8 File Offset: 0x000B1FD8
		// Note: this type is marked as 'beforefieldinit'.
		static Directory()
		{
			Il2CppClassPointerStore<Directory>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "Directory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Directory>.NativeClassPtr);
			Directory.NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668678);
			Directory.NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_String_SearchOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668679);
			Directory.NativeMethodInfoPtr_InternalGetFiles_Private_Static_Il2CppStringArray_String_String_SearchOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668680);
			Directory.NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668681);
			Directory.NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668682);
			Directory.NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_String_SearchOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668683);
			Directory.NativeMethodInfoPtr_InternalGetDirectories_Private_Static_Il2CppStringArray_String_String_SearchOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668684);
			Directory.NativeMethodInfoPtr_InternalGetFileDirectoryNames_Internal_Static_Il2CppStringArray_String_String_String_Boolean_Boolean_SearchOption_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668685);
			Directory.NativeMethodInfoPtr_CreateDirectory_Public_Static_DirectoryInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668686);
			Directory.NativeMethodInfoPtr_CreateDirectoriesInternal_Private_Static_DirectoryInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668687);
			Directory.NativeMethodInfoPtr_Delete_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668688);
			Directory.NativeMethodInfoPtr_RecursiveDelete_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668689);
			Directory.NativeMethodInfoPtr_Delete_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668690);
			Directory.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668691);
			Directory.NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668692);
			Directory.NativeMethodInfoPtr_InsecureGetCurrentDirectory_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668693);
			Directory.NativeMethodInfoPtr_GetDemandDir_Internal_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory>.NativeClassPtr, 100668694);
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x000B3F5C File Offset: 0x000B215C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320233, XrefRangeEnd = 320236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetFiles(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x000B3FA0 File Offset: 0x000B21A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320237, RefRangeEnd = 320238, XrefRangeStart = 320236, XrefRangeEnd = 320237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetFiles(string path, string searchPattern, SearchOption searchOption)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchOption;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_String_SearchOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x000B4004 File Offset: 0x000B2204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320238, XrefRangeEnd = 320239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray InternalGetFiles(string path, string searchPattern, SearchOption searchOption)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchOption;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_InternalGetFiles_Private_Static_Il2CppStringArray_String_String_SearchOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x000B4068 File Offset: 0x000B2268
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320242, RefRangeEnd = 320244, XrefRangeStart = 320239, XrefRangeEnd = 320242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetDirectories(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x000B40AC File Offset: 0x000B22AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320244, XrefRangeEnd = 320245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetDirectories(string path, string searchPattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x000B4104 File Offset: 0x000B2304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320246, RefRangeEnd = 320247, XrefRangeStart = 320245, XrefRangeEnd = 320246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetDirectories(string path, string searchPattern, SearchOption searchOption)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchOption;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_String_SearchOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x000B4168 File Offset: 0x000B2368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320247, XrefRangeEnd = 320248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray InternalGetDirectories(string path, string searchPattern, SearchOption searchOption)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchOption;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_InternalGetDirectories_Private_Static_Il2CppStringArray_String_String_SearchOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x000B41CC File Offset: 0x000B23CC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 320259, RefRangeEnd = 320269, XrefRangeStart = 320248, XrefRangeEnd = 320259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray InternalGetFileDirectoryNames(string path, string userPathOriginal, string searchPattern, bool includeFiles, bool includeDirs, SearchOption searchOption, bool checkHost)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userPathOriginal);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeFiles;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeDirs;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchOption;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkHost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_InternalGetFileDirectoryNames_Internal_Static_Il2CppStringArray_String_String_String_Boolean_Boolean_SearchOption_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x000B426C File Offset: 0x000B246C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 320321, RefRangeEnd = 320334, XrefRangeStart = 320269, XrefRangeEnd = 320321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DirectoryInfo CreateDirectory(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_CreateDirectory_Public_Static_DirectoryInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DirectoryInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x000B42B0 File Offset: 0x000B24B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320349, RefRangeEnd = 320350, XrefRangeStart = 320334, XrefRangeEnd = 320349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DirectoryInfo CreateDirectoriesInternal(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_CreateDirectoriesInternal_Private_Static_DirectoryInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DirectoryInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x000B42F4 File Offset: 0x000B24F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320371, RefRangeEnd = 320373, XrefRangeStart = 320350, XrefRangeEnd = 320371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Delete(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_Delete_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x000B432C File Offset: 0x000B252C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320392, RefRangeEnd = 320394, XrefRangeStart = 320373, XrefRangeEnd = 320392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecursiveDelete(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_RecursiveDelete_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x000B4364 File Offset: 0x000B2564
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320401, RefRangeEnd = 320403, XrefRangeStart = 320394, XrefRangeEnd = 320401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Delete(string path, bool recursive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recursive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_Delete_Public_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x000B43A8 File Offset: 0x000B25A8
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 320412, RefRangeEnd = 320439, XrefRangeStart = 320403, XrefRangeEnd = 320412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Exists(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x000B43EC File Offset: 0x000B25EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320444, RefRangeEnd = 320446, XrefRangeStart = 320439, XrefRangeEnd = 320444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCurrentDirectory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x000B4418 File Offset: 0x000B2618
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 320450, RefRangeEnd = 320453, XrefRangeStart = 320446, XrefRangeEnd = 320450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InsecureGetCurrentDirectory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_InsecureGetCurrentDirectory_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x000B4444 File Offset: 0x000B2644
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320479, RefRangeEnd = 320481, XrefRangeStart = 320453, XrefRangeEnd = 320479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDemandDir(string fullPath, bool thisDirOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref thisDirOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.NativeMethodInfoPtr_GetDemandDir_Internal_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x0000AF74 File Offset: 0x00009174
		public Directory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001D3C RID: 7484
		private static readonly IntPtr NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_0;

		// Token: 0x04001D3D RID: 7485
		private static readonly IntPtr NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_String_SearchOption_0;

		// Token: 0x04001D3E RID: 7486
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetFiles_Private_Static_Il2CppStringArray_String_String_SearchOption_0;

		// Token: 0x04001D3F RID: 7487
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_0;

		// Token: 0x04001D40 RID: 7488
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_String_0;

		// Token: 0x04001D41 RID: 7489
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_String_SearchOption_0;

		// Token: 0x04001D42 RID: 7490
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetDirectories_Private_Static_Il2CppStringArray_String_String_SearchOption_0;

		// Token: 0x04001D43 RID: 7491
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetFileDirectoryNames_Internal_Static_Il2CppStringArray_String_String_String_Boolean_Boolean_SearchOption_Boolean_0;

		// Token: 0x04001D44 RID: 7492
		private static readonly IntPtr NativeMethodInfoPtr_CreateDirectory_Public_Static_DirectoryInfo_String_0;

		// Token: 0x04001D45 RID: 7493
		private static readonly IntPtr NativeMethodInfoPtr_CreateDirectoriesInternal_Private_Static_DirectoryInfo_String_0;

		// Token: 0x04001D46 RID: 7494
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Static_Void_String_0;

		// Token: 0x04001D47 RID: 7495
		private static readonly IntPtr NativeMethodInfoPtr_RecursiveDelete_Private_Static_Void_String_0;

		// Token: 0x04001D48 RID: 7496
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Static_Void_String_Boolean_0;

		// Token: 0x04001D49 RID: 7497
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_String_0;

		// Token: 0x04001D4A RID: 7498
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentDirectory_Public_Static_String_0;

		// Token: 0x04001D4B RID: 7499
		private static readonly IntPtr NativeMethodInfoPtr_InsecureGetCurrentDirectory_Internal_Static_String_0;

		// Token: 0x04001D4C RID: 7500
		private static readonly IntPtr NativeMethodInfoPtr_GetDemandDir_Internal_Static_String_String_Boolean_0;

		// Token: 0x020005CD RID: 1485
		public sealed class SearchData : Object
		{
			// Token: 0x06005138 RID: 20792 RVA: 0x0016B374 File Offset: 0x00169574
			// Note: this type is marked as 'beforefieldinit'.
			static SearchData()
			{
				Il2CppClassPointerStore<Directory.SearchData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Directory>.NativeClassPtr, "SearchData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Directory.SearchData>.NativeClassPtr);
				Directory.SearchData.NativeFieldInfoPtr_fullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Directory.SearchData>.NativeClassPtr, "fullPath");
				Directory.SearchData.NativeFieldInfoPtr_userPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Directory.SearchData>.NativeClassPtr, "userPath");
				Directory.SearchData.NativeFieldInfoPtr_searchOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Directory.SearchData>.NativeClassPtr, "searchOption");
				Directory.SearchData.NativeMethodInfoPtr__ctor_Public_Void_String_String_SearchOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Directory.SearchData>.NativeClassPtr, 100668695);
			}

			// Token: 0x06005139 RID: 20793 RVA: 0x0016B3F0 File Offset: 0x001695F0
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 22030, RefRangeEnd = 22036, XrefRangeStart = 22030, XrefRangeEnd = 22036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SearchData(string fullPath, string userPath, SearchOption searchOption)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Directory.SearchData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userPath);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchOption;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Directory.SearchData.NativeMethodInfoPtr__ctor_Public_Void_String_String_SearchOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600513A RID: 20794 RVA: 0x0001EF93 File Offset: 0x0001D193
			public SearchData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014C0 RID: 5312
			// (get) Token: 0x0600513B RID: 20795 RVA: 0x0016B45C File Offset: 0x0016965C
			// (set) Token: 0x0600513C RID: 20796 RVA: 0x0001EF9C File Offset: 0x0001D19C
			public unsafe string fullPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Directory.SearchData.NativeFieldInfoPtr_fullPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Directory.SearchData.NativeFieldInfoPtr_fullPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170014C1 RID: 5313
			// (get) Token: 0x0600513D RID: 20797 RVA: 0x0016B484 File Offset: 0x00169684
			// (set) Token: 0x0600513E RID: 20798 RVA: 0x0001EFBB File Offset: 0x0001D1BB
			public unsafe string userPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Directory.SearchData.NativeFieldInfoPtr_userPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Directory.SearchData.NativeFieldInfoPtr_userPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170014C2 RID: 5314
			// (get) Token: 0x0600513F RID: 20799 RVA: 0x0016B4AC File Offset: 0x001696AC
			// (set) Token: 0x06005140 RID: 20800 RVA: 0x0001EFDA File Offset: 0x0001D1DA
			public unsafe SearchOption searchOption
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Directory.SearchData.NativeFieldInfoPtr_searchOption);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Directory.SearchData.NativeFieldInfoPtr_searchOption)) = value;
				}
			}

			// Token: 0x040041D3 RID: 16851
			private static readonly IntPtr NativeFieldInfoPtr_fullPath;

			// Token: 0x040041D4 RID: 16852
			private static readonly IntPtr NativeFieldInfoPtr_userPath;

			// Token: 0x040041D5 RID: 16853
			private static readonly IntPtr NativeFieldInfoPtr_searchOption;

			// Token: 0x040041D6 RID: 16854
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_SearchOption_0;
		}
	}
}

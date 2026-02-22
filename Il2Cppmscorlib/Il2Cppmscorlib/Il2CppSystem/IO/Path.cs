using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.IO
{
	// Token: 0x0200021F RID: 543
	public static class Path : Object
	{
		// Token: 0x06002346 RID: 9030 RVA: 0x000C0D7C File Offset: 0x000BEF7C
		// Note: this type is marked as 'beforefieldinit'.
		static Path()
		{
			Il2CppClassPointerStore<Path>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "Path");
			Path.NativeFieldInfoPtr_InvalidPathChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "InvalidPathChars");
			Path.NativeFieldInfoPtr_AltDirectorySeparatorChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "AltDirectorySeparatorChar");
			Path.NativeFieldInfoPtr_DirectorySeparatorChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "DirectorySeparatorChar");
			Path.NativeFieldInfoPtr_PathSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "PathSeparator");
			Path.NativeFieldInfoPtr_DirectorySeparatorStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "DirectorySeparatorStr");
			Path.NativeFieldInfoPtr_VolumeSeparatorChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "VolumeSeparatorChar");
			Path.NativeFieldInfoPtr_PathSeparatorChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "PathSeparatorChars");
			Path.NativeFieldInfoPtr_dirEqualsVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "dirEqualsVolume");
			Path.NativeFieldInfoPtr_trimEndCharsWindows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "trimEndCharsWindows");
			Path.NativeFieldInfoPtr_trimEndCharsUnix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Path>.NativeClassPtr, "trimEndCharsUnix");
			Path.NativeMethodInfoPtr_ChangeExtension_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669212);
			Path.NativeMethodInfoPtr_Combine_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669213);
			Path.NativeMethodInfoPtr_CleanPath_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669214);
			Path.NativeMethodInfoPtr_GetDirectoryName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669215);
			Path.NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669216);
			Path.NativeMethodInfoPtr_GetFileName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669217);
			Path.NativeMethodInfoPtr_GetFileNameWithoutExtension_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669218);
			Path.NativeMethodInfoPtr_GetFullPath_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669219);
			Path.NativeMethodInfoPtr_GetFullPathInternal_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669220);
			Path.NativeMethodInfoPtr_GetFullPathName_Private_Static_Int32_String_Int32_StringBuilder_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669221);
			Path.NativeMethodInfoPtr_GetFullPathName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669222);
			Path.NativeMethodInfoPtr_WindowsDriveAdjustment_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669223);
			Path.NativeMethodInfoPtr_InsecureGetFullPath_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669224);
			Path.NativeMethodInfoPtr_IsDirectorySeparator_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669225);
			Path.NativeMethodInfoPtr_GetPathRoot_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669226);
			Path.NativeMethodInfoPtr_IsPathRooted_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669227);
			Path.NativeMethodInfoPtr_GetInvalidPathChars_Public_Static_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669228);
			Path.NativeMethodInfoPtr_findExtension_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669229);
			Path.NativeMethodInfoPtr_GetServerAndShare_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669231);
			Path.NativeMethodInfoPtr_SameRoot_Private_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669232);
			Path.NativeMethodInfoPtr_CanonicalizePath_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669233);
			Path.NativeMethodInfoPtr_Combine_Public_Static_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669234);
			Path.NativeMethodInfoPtr_Combine_Public_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669235);
			Path.NativeMethodInfoPtr_Validate_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669236);
			Path.NativeMethodInfoPtr_Validate_Internal_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669237);
			Path.NativeMethodInfoPtr_get_DirectorySeparatorCharAsString_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669238);
			Path.NativeMethodInfoPtr_get_TrimEndChars_Internal_Static_get_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669239);
			Path.NativeMethodInfoPtr_CheckSearchPattern_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669240);
			Path.NativeMethodInfoPtr_CheckInvalidPathChars_Internal_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669241);
			Path.NativeMethodInfoPtr_InternalCombine_Internal_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Path>.NativeClassPtr, 100669242);
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x000C10C4 File Offset: 0x000BF2C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323551, RefRangeEnd = 323552, XrefRangeStart = 323536, XrefRangeEnd = 323551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ChangeExtension(string path, string extension)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(extension);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_ChangeExtension_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x000C1114 File Offset: 0x000BF314
		[CallerCount(59)]
		[CachedScanResults(RefRangeStart = 323576, RefRangeEnd = 323635, XrefRangeStart = 323552, XrefRangeEnd = 323576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Combine(string path1, string path2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Combine_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x000C1164 File Offset: 0x000BF364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323635, XrefRangeEnd = 323678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CleanPath(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_CleanPath_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x000C11A0 File Offset: 0x000BF3A0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 323707, RefRangeEnd = 323719, XrefRangeStart = 323678, XrefRangeEnd = 323707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDirectoryName(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetDirectoryName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x000C11DC File Offset: 0x000BF3DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323730, RefRangeEnd = 323732, XrefRangeStart = 323719, XrefRangeEnd = 323730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetExtension(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x000C1218 File Offset: 0x000BF418
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 323742, RefRangeEnd = 323754, XrefRangeStart = 323732, XrefRangeEnd = 323742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFileName(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetFileName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x000C1254 File Offset: 0x000BF454
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323775, RefRangeEnd = 323777, XrefRangeStart = 323754, XrefRangeEnd = 323775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFileNameWithoutExtension(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetFileNameWithoutExtension_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x000C1290 File Offset: 0x000BF490
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 323782, RefRangeEnd = 323790, XrefRangeStart = 323777, XrefRangeEnd = 323782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFullPath(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetFullPath_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x000C12CC File Offset: 0x000BF4CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 323794, RefRangeEnd = 323799, XrefRangeStart = 323790, XrefRangeEnd = 323794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFullPathInternal(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetFullPathInternal_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x000C1308 File Offset: 0x000BF508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323799, XrefRangeEnd = 323804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFullPathName(string path, int numBufferChars, StringBuilder buffer, ref IntPtr lpFilePartOrNull)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBufferChars;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lpFilePartOrNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetFullPathName_Private_Static_Int32_String_Int32_StringBuilder_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x000C1378 File Offset: 0x000BF578
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323827, RefRangeEnd = 323828, XrefRangeStart = 323804, XrefRangeEnd = 323827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFullPathName(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetFullPathName_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x000C13B4 File Offset: 0x000BF5B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323849, RefRangeEnd = 323850, XrefRangeStart = 323828, XrefRangeEnd = 323849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string WindowsDriveAdjustment(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_WindowsDriveAdjustment_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x000C13F0 File Offset: 0x000BF5F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 323942, RefRangeEnd = 323945, XrefRangeStart = 323850, XrefRangeEnd = 323942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InsecureGetFullPath(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_InsecureGetFullPath_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x000C142C File Offset: 0x000BF62C
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 323949, RefRangeEnd = 323974, XrefRangeStart = 323945, XrefRangeEnd = 323949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDirectorySeparator(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_IsDirectorySeparator_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x000C146C File Offset: 0x000BF66C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 324039, RefRangeEnd = 324042, XrefRangeStart = 323974, XrefRangeEnd = 324039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPathRoot(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetPathRoot_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x000C14A8 File Offset: 0x000BF6A8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 324059, RefRangeEnd = 324065, XrefRangeStart = 324042, XrefRangeEnd = 324059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPathRooted(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_IsPathRooted_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x000C14EC File Offset: 0x000BF6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324065, XrefRangeEnd = 324073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> GetInvalidPathChars()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetInvalidPathChars_Public_Static_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x000C1520 File Offset: 0x000BF720
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 324079, RefRangeEnd = 324081, XrefRangeStart = 324073, XrefRangeEnd = 324079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int findExtension(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_findExtension_Private_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x000C1564 File Offset: 0x000BF764
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 324109, RefRangeEnd = 324111, XrefRangeStart = 324081, XrefRangeEnd = 324109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetServerAndShare(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_GetServerAndShare_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x000C15A0 File Offset: 0x000BF7A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 324137, RefRangeEnd = 324139, XrefRangeStart = 324111, XrefRangeEnd = 324137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SameRoot(string root, string path)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_SameRoot_Private_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x000C15F4 File Offset: 0x000BF7F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324239, RefRangeEnd = 324240, XrefRangeStart = 324139, XrefRangeEnd = 324239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CanonicalizePath(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_CanonicalizePath_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x000C1630 File Offset: 0x000BF830
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324291, RefRangeEnd = 324292, XrefRangeStart = 324240, XrefRangeEnd = 324291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Combine([Optional] Il2CppStringArray paths)
		{
			if (paths == null)
			{
				paths = new Il2CppStringArray(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paths);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Combine_Public_Static_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x000C167C File Offset: 0x000BF87C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 324333, RefRangeEnd = 324335, XrefRangeStart = 324292, XrefRangeEnd = 324333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Combine(string path1, string path2, string path3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Combine_Public_Static_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x000C16DC File Offset: 0x000BF8DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 324341, RefRangeEnd = 324345, XrefRangeStart = 324335, XrefRangeEnd = 324341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Validate(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Validate_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x000C1714 File Offset: 0x000BF914
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324353, RefRangeEnd = 324354, XrefRangeStart = 324345, XrefRangeEnd = 324353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Validate(string path, string parameterName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parameterName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_Validate_Internal_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06002360 RID: 9056 RVA: 0x000C175C File Offset: 0x000BF95C
		public unsafe static string DirectorySeparatorCharAsString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324354, XrefRangeEnd = 324358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_get_DirectorySeparatorCharAsString_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06002361 RID: 9057 RVA: 0x000C1788 File Offset: 0x000BF988
		public unsafe static Il2CppStructArray<char> TrimEndChars
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 324363, RefRangeEnd = 324364, XrefRangeStart = 324358, XrefRangeEnd = 324363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_get_TrimEndChars_Internal_Static_get_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x000C17BC File Offset: 0x000BF9BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324378, RefRangeEnd = 324379, XrefRangeStart = 324364, XrefRangeEnd = 324378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckSearchPattern(string searchPattern)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_CheckSearchPattern_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x000C17F4 File Offset: 0x000BF9F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 324384, RefRangeEnd = 324386, XrefRangeStart = 324379, XrefRangeEnd = 324384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckInvalidPathChars(string path, bool checkAdditional = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkAdditional;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_CheckInvalidPathChars_Internal_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x000C1838 File Offset: 0x000BFA38
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 324410, RefRangeEnd = 324418, XrefRangeStart = 324386, XrefRangeEnd = 324410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalCombine(string path1, string path2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Path.NativeMethodInfoPtr_InternalCombine_Internal_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x0000BEB2 File Offset: 0x0000A0B2
		public static string Combine(params string[] paths)
		{
			return Path.Combine(new Il2CppStringArray(paths));
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x0000BEBF File Offset: 0x0000A0BF
		public Path(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x000C1888 File Offset: 0x000BFA88
		// (set) Token: 0x06002368 RID: 9064 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		public unsafe static Il2CppStructArray<char> InvalidPathChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_InvalidPathChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_InvalidPathChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06002369 RID: 9065 RVA: 0x000C18B0 File Offset: 0x000BFAB0
		// (set) Token: 0x0600236A RID: 9066 RVA: 0x0000BEDA File Offset: 0x0000A0DA
		public unsafe static char AltDirectorySeparatorChar
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_AltDirectorySeparatorChar, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_AltDirectorySeparatorChar, (void*)(&value));
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x000C18CC File Offset: 0x000BFACC
		// (set) Token: 0x0600236C RID: 9068 RVA: 0x0000BEE8 File Offset: 0x0000A0E8
		public unsafe static char DirectorySeparatorChar
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_DirectorySeparatorChar, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_DirectorySeparatorChar, (void*)(&value));
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x0600236D RID: 9069 RVA: 0x000C18E8 File Offset: 0x000BFAE8
		// (set) Token: 0x0600236E RID: 9070 RVA: 0x0000BEF6 File Offset: 0x0000A0F6
		public unsafe static char PathSeparator
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_PathSeparator, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_PathSeparator, (void*)(&value));
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x0600236F RID: 9071 RVA: 0x000C1904 File Offset: 0x000BFB04
		// (set) Token: 0x06002370 RID: 9072 RVA: 0x0000BF04 File Offset: 0x0000A104
		public unsafe static string DirectorySeparatorStr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_DirectorySeparatorStr, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_DirectorySeparatorStr, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06002371 RID: 9073 RVA: 0x000C1924 File Offset: 0x000BFB24
		// (set) Token: 0x06002372 RID: 9074 RVA: 0x0000BF16 File Offset: 0x0000A116
		public unsafe static char VolumeSeparatorChar
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_VolumeSeparatorChar, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_VolumeSeparatorChar, (void*)(&value));
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x000C1940 File Offset: 0x000BFB40
		// (set) Token: 0x06002374 RID: 9076 RVA: 0x0000BF24 File Offset: 0x0000A124
		public unsafe static Il2CppStructArray<char> PathSeparatorChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_PathSeparatorChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_PathSeparatorChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x000C1968 File Offset: 0x000BFB68
		// (set) Token: 0x06002376 RID: 9078 RVA: 0x0000BF36 File Offset: 0x0000A136
		public unsafe static bool dirEqualsVolume
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_dirEqualsVolume, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_dirEqualsVolume, (void*)(&value));
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06002377 RID: 9079 RVA: 0x000C1984 File Offset: 0x000BFB84
		// (set) Token: 0x06002378 RID: 9080 RVA: 0x0000BF44 File Offset: 0x0000A144
		public unsafe static Il2CppStructArray<char> trimEndCharsWindows
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_trimEndCharsWindows, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_trimEndCharsWindows, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06002379 RID: 9081 RVA: 0x000C19AC File Offset: 0x000BFBAC
		// (set) Token: 0x0600237A RID: 9082 RVA: 0x0000BF56 File Offset: 0x0000A156
		public unsafe static Il2CppStructArray<char> trimEndCharsUnix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Path.NativeFieldInfoPtr_trimEndCharsUnix, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Path.NativeFieldInfoPtr_trimEndCharsUnix, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FB6 RID: 8118
		private static readonly IntPtr NativeFieldInfoPtr_InvalidPathChars;

		// Token: 0x04001FB7 RID: 8119
		private static readonly IntPtr NativeFieldInfoPtr_AltDirectorySeparatorChar;

		// Token: 0x04001FB8 RID: 8120
		private static readonly IntPtr NativeFieldInfoPtr_DirectorySeparatorChar;

		// Token: 0x04001FB9 RID: 8121
		private static readonly IntPtr NativeFieldInfoPtr_PathSeparator;

		// Token: 0x04001FBA RID: 8122
		private static readonly IntPtr NativeFieldInfoPtr_DirectorySeparatorStr;

		// Token: 0x04001FBB RID: 8123
		private static readonly IntPtr NativeFieldInfoPtr_VolumeSeparatorChar;

		// Token: 0x04001FBC RID: 8124
		private static readonly IntPtr NativeFieldInfoPtr_PathSeparatorChars;

		// Token: 0x04001FBD RID: 8125
		private static readonly IntPtr NativeFieldInfoPtr_dirEqualsVolume;

		// Token: 0x04001FBE RID: 8126
		private static readonly IntPtr NativeFieldInfoPtr_trimEndCharsWindows;

		// Token: 0x04001FBF RID: 8127
		private static readonly IntPtr NativeFieldInfoPtr_trimEndCharsUnix;

		// Token: 0x04001FC0 RID: 8128
		private static readonly IntPtr NativeMethodInfoPtr_ChangeExtension_Public_Static_String_String_String_0;

		// Token: 0x04001FC1 RID: 8129
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_String_String_String_0;

		// Token: 0x04001FC2 RID: 8130
		private static readonly IntPtr NativeMethodInfoPtr_CleanPath_Internal_Static_String_String_0;

		// Token: 0x04001FC3 RID: 8131
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectoryName_Public_Static_String_String_0;

		// Token: 0x04001FC4 RID: 8132
		private static readonly IntPtr NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0;

		// Token: 0x04001FC5 RID: 8133
		private static readonly IntPtr NativeMethodInfoPtr_GetFileName_Public_Static_String_String_0;

		// Token: 0x04001FC6 RID: 8134
		private static readonly IntPtr NativeMethodInfoPtr_GetFileNameWithoutExtension_Public_Static_String_String_0;

		// Token: 0x04001FC7 RID: 8135
		private static readonly IntPtr NativeMethodInfoPtr_GetFullPath_Public_Static_String_String_0;

		// Token: 0x04001FC8 RID: 8136
		private static readonly IntPtr NativeMethodInfoPtr_GetFullPathInternal_Internal_Static_String_String_0;

		// Token: 0x04001FC9 RID: 8137
		private static readonly IntPtr NativeMethodInfoPtr_GetFullPathName_Private_Static_Int32_String_Int32_StringBuilder_byref_IntPtr_0;

		// Token: 0x04001FCA RID: 8138
		private static readonly IntPtr NativeMethodInfoPtr_GetFullPathName_Internal_Static_String_String_0;

		// Token: 0x04001FCB RID: 8139
		private static readonly IntPtr NativeMethodInfoPtr_WindowsDriveAdjustment_Internal_Static_String_String_0;

		// Token: 0x04001FCC RID: 8140
		private static readonly IntPtr NativeMethodInfoPtr_InsecureGetFullPath_Internal_Static_String_String_0;

		// Token: 0x04001FCD RID: 8141
		private static readonly IntPtr NativeMethodInfoPtr_IsDirectorySeparator_Internal_Static_Boolean_Char_0;

		// Token: 0x04001FCE RID: 8142
		private static readonly IntPtr NativeMethodInfoPtr_GetPathRoot_Public_Static_String_String_0;

		// Token: 0x04001FCF RID: 8143
		private static readonly IntPtr NativeMethodInfoPtr_IsPathRooted_Public_Static_Boolean_String_0;

		// Token: 0x04001FD0 RID: 8144
		private static readonly IntPtr NativeMethodInfoPtr_GetInvalidPathChars_Public_Static_Il2CppStructArray_1_Char_0;

		// Token: 0x04001FD1 RID: 8145
		private static readonly IntPtr NativeMethodInfoPtr_findExtension_Private_Static_Int32_String_0;

		// Token: 0x04001FD2 RID: 8146
		private static readonly IntPtr NativeMethodInfoPtr_GetServerAndShare_Private_Static_String_String_0;

		// Token: 0x04001FD3 RID: 8147
		private static readonly IntPtr NativeMethodInfoPtr_SameRoot_Private_Static_Boolean_String_String_0;

		// Token: 0x04001FD4 RID: 8148
		private static readonly IntPtr NativeMethodInfoPtr_CanonicalizePath_Private_Static_String_String_0;

		// Token: 0x04001FD5 RID: 8149
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_String_Il2CppStringArray_0;

		// Token: 0x04001FD6 RID: 8150
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_String_String_String_String_0;

		// Token: 0x04001FD7 RID: 8151
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Static_Void_String_0;

		// Token: 0x04001FD8 RID: 8152
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Internal_Static_Void_String_String_0;

		// Token: 0x04001FD9 RID: 8153
		private static readonly IntPtr NativeMethodInfoPtr_get_DirectorySeparatorCharAsString_Internal_Static_get_String_0;

		// Token: 0x04001FDA RID: 8154
		private static readonly IntPtr NativeMethodInfoPtr_get_TrimEndChars_Internal_Static_get_Il2CppStructArray_1_Char_0;

		// Token: 0x04001FDB RID: 8155
		private static readonly IntPtr NativeMethodInfoPtr_CheckSearchPattern_Internal_Static_Void_String_0;

		// Token: 0x04001FDC RID: 8156
		private static readonly IntPtr NativeMethodInfoPtr_CheckInvalidPathChars_Internal_Static_Void_String_Boolean_0;

		// Token: 0x04001FDD RID: 8157
		private static readonly IntPtr NativeMethodInfoPtr_InternalCombine_Internal_Static_String_String_String_0;
	}
}

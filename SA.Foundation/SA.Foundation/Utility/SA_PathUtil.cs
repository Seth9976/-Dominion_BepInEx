using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SA.Foundation.Utility
{
	// Token: 0x02000016 RID: 22
	public static class SA_PathUtil : Object
	{
		// Token: 0x0600009C RID: 156 RVA: 0x00006408 File Offset: 0x00004608
		// Note: this type is marked as 'beforefieldinit'.
		static SA_PathUtil()
		{
			Il2CppClassPointerStore<SA_PathUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Utility", "SA_PathUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_PathUtil>.NativeClassPtr);
			SA_PathUtil.NativeFieldInfoPtr_FOLDER_SEPARATOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_PathUtil>.NativeClassPtr, "FOLDER_SEPARATOR");
			SA_PathUtil.NativeMethodInfoPtr_FixRelativePath_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PathUtil>.NativeClassPtr, 100663410);
			SA_PathUtil.NativeMethodInfoPtr_ConvertRelativeToAbsolutePath_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PathUtil>.NativeClassPtr, 100663411);
			SA_PathUtil.NativeMethodInfoPtr_IsDirectoryExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PathUtil>.NativeClassPtr, 100663412);
			SA_PathUtil.NativeMethodInfoPtr_IsFileExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PathUtil>.NativeClassPtr, 100663413);
			SA_PathUtil.NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PathUtil>.NativeClassPtr, 100663414);
			SA_PathUtil.NativeMethodInfoPtr_GetFileName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PathUtil>.NativeClassPtr, 100663415);
			SA_PathUtil.NativeMethodInfoPtr_GetFileNameWithoutExtension_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PathUtil>.NativeClassPtr, 100663416);
			SA_PathUtil.NativeMethodInfoPtr_GetDirectoryPath_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PathUtil>.NativeClassPtr, 100663417);
			SA_PathUtil.NativeMethodInfoPtr_GetDirectoriesOutOfPath_Public_Static_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PathUtil>.NativeClassPtr, 100663418);
			SA_PathUtil.NativeMethodInfoPtr_GetPathDirectoryName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_PathUtil>.NativeClassPtr, 100663419);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00006514 File Offset: 0x00004714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99079, XrefRangeEnd = 99086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FixRelativePath(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PathUtil.NativeMethodInfoPtr_FixRelativePath_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00006550 File Offset: 0x00004750
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 99102, RefRangeEnd = 99139, XrefRangeStart = 99086, XrefRangeEnd = 99102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ConvertRelativeToAbsolutePath(string relativePath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(relativePath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PathUtil.NativeMethodInfoPtr_ConvertRelativeToAbsolutePath_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000658C File Offset: 0x0000478C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98605, RefRangeEnd = 98607, XrefRangeStart = 98605, XrefRangeEnd = 98607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDirectoryExists(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PathUtil.NativeMethodInfoPtr_IsDirectoryExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000065D0 File Offset: 0x000047D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsFileExists(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PathUtil.NativeMethodInfoPtr_IsFileExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00006614 File Offset: 0x00004814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetExtension(string filePath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PathUtil.NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00006650 File Offset: 0x00004850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFileName(string filePath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PathUtil.NativeMethodInfoPtr_GetFileName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000668C File Offset: 0x0000488C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99139, XrefRangeEnd = 99144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFileNameWithoutExtension(string filePath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PathUtil.NativeMethodInfoPtr_GetFileNameWithoutExtension_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000066C8 File Offset: 0x000048C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99144, XrefRangeEnd = 99154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDirectoryPath(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PathUtil.NativeMethodInfoPtr_GetDirectoryPath_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00006704 File Offset: 0x00004904
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 99174, RefRangeEnd = 99176, XrefRangeStart = 99154, XrefRangeEnd = 99174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> GetDirectoriesOutOfPath(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PathUtil.NativeMethodInfoPtr_GetDirectoriesOutOfPath_Public_Static_List_1_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00006748 File Offset: 0x00004948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99187, RefRangeEnd = 99188, XrefRangeStart = 99176, XrefRangeEnd = 99187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPathDirectoryName(string folderPath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(folderPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_PathUtil.NativeMethodInfoPtr_GetPathDirectoryName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000021F8 File Offset: 0x000003F8
		public SA_PathUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00006784 File Offset: 0x00004984
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00002201 File Offset: 0x00000401
		public unsafe static string FOLDER_SEPARATOR
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_PathUtil.NativeFieldInfoPtr_FOLDER_SEPARATOR, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_PathUtil.NativeFieldInfoPtr_FOLDER_SEPARATOR, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_FOLDER_SEPARATOR;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_FixRelativePath_Public_Static_String_String_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_ConvertRelativeToAbsolutePath_Public_Static_String_String_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_IsDirectoryExists_Public_Static_Boolean_String_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_IsFileExists_Public_Static_Boolean_String_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_GetFileName_Public_Static_String_String_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_GetFileNameWithoutExtension_Public_Static_String_String_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectoryPath_Public_Static_String_String_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectoriesOutOfPath_Public_Static_List_1_String_String_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_GetPathDirectoryName_Public_Static_String_String_0;
	}
}

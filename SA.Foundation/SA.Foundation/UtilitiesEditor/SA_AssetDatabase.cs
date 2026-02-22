using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace SA.Foundation.UtilitiesEditor
{
	// Token: 0x02000010 RID: 16
	public static class SA_AssetDatabase : global::Il2CppSystem.Object
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00004D00 File Offset: 0x00002F00
		// Note: this type is marked as 'beforefieldinit'.
		static SA_AssetDatabase()
		{
			Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.UtilitiesEditor", "SA_AssetDatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr);
			SA_AssetDatabase.NativeMethodInfoPtr_CreateAsset_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663349);
			SA_AssetDatabase.NativeMethodInfoPtr_CreateFolder_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663350);
			SA_AssetDatabase.NativeMethodInfoPtr_GetAssetPath_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663351);
			SA_AssetDatabase.NativeMethodInfoPtr_GetAbsoluteAssetPath_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663352);
			SA_AssetDatabase.NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663353);
			SA_AssetDatabase.NativeMethodInfoPtr_IsAssetInsideFolder_Public_Static_Boolean_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663354);
			SA_AssetDatabase.NativeMethodInfoPtr_GetFileName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663355);
			SA_AssetDatabase.NativeMethodInfoPtr_GetAssetNameWithoutExtension_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663356);
			SA_AssetDatabase.NativeMethodInfoPtr_CopyAsset_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663357);
			SA_AssetDatabase.NativeMethodInfoPtr_MoveAsset_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663358);
			SA_AssetDatabase.NativeMethodInfoPtr_DeleteAsset_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663359);
			SA_AssetDatabase.NativeMethodInfoPtr_RenameAsset_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663360);
			SA_AssetDatabase.NativeMethodInfoPtr_LoadAssetAtPath_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663361);
			SA_AssetDatabase.NativeMethodInfoPtr_IsDirectoryExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663362);
			SA_AssetDatabase.NativeMethodInfoPtr_IsFileExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663363);
			SA_AssetDatabase.NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663364);
			SA_AssetDatabase.NativeMethodInfoPtr_IsValidFolder_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663365);
			SA_AssetDatabase.NativeMethodInfoPtr_FindAssets_Public_Static_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663366);
			SA_AssetDatabase.NativeMethodInfoPtr_FindAssetsWithExtentions_Public_Static_List_1_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663367);
			SA_AssetDatabase.NativeMethodInfoPtr_Refresh_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663368);
			SA_AssetDatabase.NativeMethodInfoPtr_ImportAsset_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663369);
			SA_AssetDatabase.NativeMethodInfoPtr_GetLocalIdentifierInFile_Public_Static_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663370);
			SA_AssetDatabase.NativeMethodInfoPtr_GetLocalIdentifierInFile_Public_Static_Int32_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663371);
			SA_AssetDatabase.NativeMethodInfoPtr_FixRelativePath_Private_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663372);
			SA_AssetDatabase.NativeMethodInfoPtr_ValidateFoldersPath_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, 100663373);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004F24 File Offset: 0x00003124
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98488, RefRangeEnd = 98490, XrefRangeStart = 98478, XrefRangeEnd = 98488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateAsset(global::UnityEngine.Object asset, string path)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_CreateAsset_Public_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004F6C File Offset: 0x0000316C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98497, RefRangeEnd = 98499, XrefRangeStart = 98490, XrefRangeEnd = 98497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateFolder(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_CreateFolder_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004FA4 File Offset: 0x000031A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 98508, RefRangeEnd = 98512, XrefRangeStart = 98499, XrefRangeEnd = 98508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAssetPath(global::UnityEngine.Object assetObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_GetAssetPath_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004FE0 File Offset: 0x000031E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98512, XrefRangeEnd = 98514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAbsoluteAssetPath(global::UnityEngine.Object assetObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_GetAbsoluteAssetPath_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000501C File Offset: 0x0000321C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98514, XrefRangeEnd = 98519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetExtension(string filePath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00005058 File Offset: 0x00003258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98519, XrefRangeEnd = 98534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAssetInsideFolder(global::UnityEngine.Object assetObject, string folderPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(folderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_IsAssetInsideFolder_Public_Static_Boolean_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000050AC File Offset: 0x000032AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98534, XrefRangeEnd = 98539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFileName(string filePath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_GetFileName_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000050E8 File Offset: 0x000032E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98539, XrefRangeEnd = 98543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAssetNameWithoutExtension(string filePath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_GetAssetNameWithoutExtension_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00005124 File Offset: 0x00003324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98543, XrefRangeEnd = 98561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CopyAsset(string path, string newPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_CopyAsset_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00005178 File Offset: 0x00003378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98561, XrefRangeEnd = 98579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MoveAsset(string oldPath, string newPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_MoveAsset_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000051C8 File Offset: 0x000033C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 98589, RefRangeEnd = 98592, XrefRangeStart = 98579, XrefRangeEnd = 98589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeleteAsset(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_DeleteAsset_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000520C File Offset: 0x0000340C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98592, XrefRangeEnd = 98602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RenameAsset(string pathName, string newName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pathName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_RenameAsset_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000525C File Offset: 0x0000345C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98602, XrefRangeEnd = 98603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T LoadAssetAtPath<T>(string assetPath) where T : global::UnityEngine.Object
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.MethodInfoStoreGeneric_LoadAssetAtPath_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000529C File Offset: 0x0000349C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98605, RefRangeEnd = 98607, XrefRangeStart = 98603, XrefRangeEnd = 98605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDirectoryExists(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_IsDirectoryExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000052E0 File Offset: 0x000034E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98607, XrefRangeEnd = 98609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsFileExists(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_IsFileExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00005324 File Offset: 0x00003524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98609, XrefRangeEnd = 98620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetDirectories(string folderPath)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(folderPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00005368 File Offset: 0x00003568
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 98605, RefRangeEnd = 98607, XrefRangeStart = 98605, XrefRangeEnd = 98607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidFolder(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_IsValidFolder_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000053AC File Offset: 0x000035AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98620, XrefRangeEnd = 98641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> FindAssets(string pathToDirectory)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pathToDirectory);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_FindAssets_Public_Static_List_1_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000053F0 File Offset: 0x000035F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98641, XrefRangeEnd = 98659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<string> FindAssetsWithExtentions(string pathToDirectory, [Optional] Il2CppStringArray extentions)
		{
			if (extentions == null)
			{
				extentions = new Il2CppStringArray(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pathToDirectory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extentions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_FindAssetsWithExtentions_Public_Static_List_1_String_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00005454 File Offset: 0x00003654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98659, XrefRangeEnd = 98660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Refresh()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_Refresh_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000547C File Offset: 0x0000367C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98660, XrefRangeEnd = 98670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ImportAsset(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_ImportAsset_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000054B4 File Offset: 0x000036B4
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLocalIdentifierInFile(GameObject go)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_GetLocalIdentifierInFile_Public_Static_Int32_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000054F8 File Offset: 0x000036F8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLocalIdentifierInFile(Component component)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_GetLocalIdentifierInFile_Public_Static_Int32_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000553C File Offset: 0x0000373C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98678, RefRangeEnd = 98679, XrefRangeStart = 98670, XrefRangeEnd = 98678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FixRelativePath(string path, bool validateFoldersPath = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validateFoldersPath;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_FixRelativePath_Private_Static_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00005588 File Offset: 0x00003788
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 98700, RefRangeEnd = 98711, XrefRangeStart = 98679, XrefRangeEnd = 98700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateFoldersPath(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.NativeMethodInfoPtr_ValidateFoldersPath_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000217E File Offset: 0x0000037E
		public static List<string> FindAssetsWithExtentions(string pathToDirectory, params string[] extentions)
		{
			return SA_AssetDatabase.FindAssetsWithExtentions(pathToDirectory, new Il2CppStringArray(extentions));
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000218C File Offset: 0x0000038C
		public SA_AssetDatabase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_CreateAsset_Public_Static_Void_Object_String_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_CreateFolder_Public_Static_Void_String_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetPath_Public_Static_String_Object_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_GetAbsoluteAssetPath_Public_Static_String_Object_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_IsAssetInsideFolder_Public_Static_Boolean_Object_String_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_GetFileName_Public_Static_String_String_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_GetAssetNameWithoutExtension_Public_Static_String_String_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_CopyAsset_Public_Static_Boolean_String_String_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_MoveAsset_Public_Static_String_String_String_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_DeleteAsset_Public_Static_Boolean_String_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_RenameAsset_Public_Static_String_String_String_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAtPath_Public_Static_T_String_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_IsDirectoryExists_Public_Static_Boolean_String_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_IsFileExists_Public_Static_Boolean_String_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_IsValidFolder_Public_Static_Boolean_String_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_FindAssets_Public_Static_List_1_String_String_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_FindAssetsWithExtentions_Public_Static_List_1_String_String_Il2CppStringArray_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Static_Void_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_ImportAsset_Public_Static_Void_String_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalIdentifierInFile_Public_Static_Int32_GameObject_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalIdentifierInFile_Public_Static_Int32_Component_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_FixRelativePath_Private_Static_String_String_Boolean_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFoldersPath_Public_Static_Void_String_0;

		// Token: 0x02000045 RID: 69
		public class SA_AssetDatabaseProxy : global::Il2CppSystem.Object
		{
			// Token: 0x060003AE RID: 942 RVA: 0x00012808 File Offset: 0x00010A08
			// Note: this type is marked as 'beforefieldinit'.
			static SA_AssetDatabaseProxy()
			{
				Il2CppClassPointerStore<SA_AssetDatabase.SA_AssetDatabaseProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr, "SA_AssetDatabaseProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_AssetDatabase.SA_AssetDatabaseProxy>.NativeClassPtr);
				SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_Create_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase.SA_AssetDatabaseProxy>.NativeClassPtr, 100663866);
				SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_FindAssets_Public_Static_List_1_String_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase.SA_AssetDatabaseProxy>.NativeClassPtr, 100663867);
				SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_CopyAsset_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase.SA_AssetDatabaseProxy>.NativeClassPtr, 100663868);
				SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_RenameAsset_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase.SA_AssetDatabaseProxy>.NativeClassPtr, 100663869);
				SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_Move_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase.SA_AssetDatabaseProxy>.NativeClassPtr, 100663870);
				SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_Delete_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase.SA_AssetDatabaseProxy>.NativeClassPtr, 100663871);
				SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_CreateFolder_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase.SA_AssetDatabaseProxy>.NativeClassPtr, 100663872);
				SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_Refresh_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase.SA_AssetDatabaseProxy>.NativeClassPtr, 100663873);
				SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_ImportAsset_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase.SA_AssetDatabaseProxy>.NativeClassPtr, 100663874);
				SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_GetAssetPath_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase.SA_AssetDatabaseProxy>.NativeClassPtr, 100663875);
				SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_LoadAssetAtPath_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase.SA_AssetDatabaseProxy>.NativeClassPtr, 100663876);
				SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AssetDatabase.SA_AssetDatabaseProxy>.NativeClassPtr, 100663877);
			}

			// Token: 0x060003AF RID: 943 RVA: 0x00012924 File Offset: 0x00010B24
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Create(global::UnityEngine.Object asset, string path)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_Create_Public_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003B0 RID: 944 RVA: 0x0001296C File Offset: 0x00010B6C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 98468, RefRangeEnd = 98470, XrefRangeStart = 98462, XrefRangeEnd = 98468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static List<string> FindAssets(string path, string filter, [Optional] Il2CppStringArray extentions)
			{
				if (extentions == null)
				{
					extentions = new Il2CppStringArray(0L);
				}
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filter);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extentions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_FindAssets_Public_Static_List_1_String_String_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}

			// Token: 0x060003B1 RID: 945 RVA: 0x000129E4 File Offset: 0x00010BE4
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool CopyAsset(string path, string newPath)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_CopyAsset_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060003B2 RID: 946 RVA: 0x00012A38 File Offset: 0x00010C38
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 98472, RefRangeEnd = 98473, XrefRangeStart = 98470, XrefRangeEnd = 98472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string RenameAsset(string pathName, string newName)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(pathName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_RenameAsset_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060003B3 RID: 947 RVA: 0x00012A88 File Offset: 0x00010C88
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 98475, RefRangeEnd = 98476, XrefRangeStart = 98473, XrefRangeEnd = 98475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string Move(string oldPath, string newPath)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(oldPath);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_Move_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060003B4 RID: 948 RVA: 0x00012AD8 File Offset: 0x00010CD8
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool Delete(string path)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_Delete_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060003B5 RID: 949 RVA: 0x00012B1C File Offset: 0x00010D1C
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void CreateFolder(string parentFolder, string newFolderName)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newFolderName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_CreateFolder_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003B6 RID: 950 RVA: 0x00012B64 File Offset: 0x00010D64
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Refresh()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_Refresh_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003B7 RID: 951 RVA: 0x00012B8C File Offset: 0x00010D8C
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void ImportAsset(string path)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_ImportAsset_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003B8 RID: 952 RVA: 0x00012BC4 File Offset: 0x00010DC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98476, XrefRangeEnd = 98478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string GetAssetPath(global::UnityEngine.Object assetObject)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetObject);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_GetAssetPath_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060003B9 RID: 953 RVA: 0x00012C00 File Offset: 0x00010E00
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static T LoadAssetAtPath<T>(string assetPath) where T : global::UnityEngine.Object
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.SA_AssetDatabaseProxy.MethodInfoStoreGeneric_LoadAssetAtPath_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x060003BA RID: 954 RVA: 0x00012C40 File Offset: 0x00010E40
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SA_AssetDatabaseProxy()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_AssetDatabase.SA_AssetDatabaseProxy>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003BB RID: 955 RVA: 0x00002F77 File Offset: 0x00001177
			public static List<string> FindAssets(string path, string filter, params string[] extentions)
			{
				return SA_AssetDatabase.SA_AssetDatabaseProxy.FindAssets(path, filter, new Il2CppStringArray(extentions));
			}

			// Token: 0x060003BC RID: 956 RVA: 0x00002F86 File Offset: 0x00001186
			public SA_AssetDatabaseProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040002DA RID: 730
			private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Void_Object_String_0;

			// Token: 0x040002DB RID: 731
			private static readonly IntPtr NativeMethodInfoPtr_FindAssets_Public_Static_List_1_String_String_String_Il2CppStringArray_0;

			// Token: 0x040002DC RID: 732
			private static readonly IntPtr NativeMethodInfoPtr_CopyAsset_Public_Static_Boolean_String_String_0;

			// Token: 0x040002DD RID: 733
			private static readonly IntPtr NativeMethodInfoPtr_RenameAsset_Public_Static_String_String_String_0;

			// Token: 0x040002DE RID: 734
			private static readonly IntPtr NativeMethodInfoPtr_Move_Public_Static_String_String_String_0;

			// Token: 0x040002DF RID: 735
			private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Static_Boolean_String_0;

			// Token: 0x040002E0 RID: 736
			private static readonly IntPtr NativeMethodInfoPtr_CreateFolder_Public_Static_Void_String_String_0;

			// Token: 0x040002E1 RID: 737
			private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Static_Void_0;

			// Token: 0x040002E2 RID: 738
			private static readonly IntPtr NativeMethodInfoPtr_ImportAsset_Public_Static_Void_String_0;

			// Token: 0x040002E3 RID: 739
			private static readonly IntPtr NativeMethodInfoPtr_GetAssetPath_Public_Static_String_Object_0;

			// Token: 0x040002E4 RID: 740
			private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAtPath_Public_Static_T_String_0;

			// Token: 0x040002E5 RID: 741
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000064 RID: 100
			private sealed class MethodInfoStoreGeneric_LoadAssetAtPath_Public_Static_T_String_0<T>
			{
				// Token: 0x0400037C RID: 892
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SA_AssetDatabase.SA_AssetDatabaseProxy.NativeMethodInfoPtr_LoadAssetAtPath_Public_Static_T_String_0, Il2CppClassPointerStore<SA_AssetDatabase.SA_AssetDatabaseProxy>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x02000046 RID: 70
		private sealed class MethodInfoStoreGeneric_LoadAssetAtPath_Public_Static_T_String_0<T>
		{
			// Token: 0x040002E6 RID: 742
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SA_AssetDatabase.NativeMethodInfoPtr_LoadAssetAtPath_Public_Static_T_String_0, Il2CppClassPointerStore<SA_AssetDatabase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

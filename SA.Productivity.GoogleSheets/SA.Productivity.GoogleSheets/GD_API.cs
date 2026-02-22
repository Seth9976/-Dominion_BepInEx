using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace SA.Productivity.GoogleSheets
{
	// Token: 0x02000002 RID: 2
	public static class GD_API : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002768 File Offset: 0x00000968
		// Note: this type is marked as 'beforefieldinit'.
		static GD_API()
		{
			Il2CppClassPointerStore<GD_API>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Productivity.GoogleSheets.dll", "SA.Productivity.GoogleSheets", "GD_API");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GD_API>.NativeClassPtr);
			GD_API.NativeFieldInfoPtr_NULL_VALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GD_API>.NativeClassPtr, "NULL_VALUE");
			GD_API.NativeMethodInfoPtr_GetValue_Public_Static_T_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663297);
			GD_API.NativeMethodInfoPtr_GetValue_Public_Static_T_String_GD_Cell_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663298);
			GD_API.NativeMethodInfoPtr_GetList_Public_Static_List_1_T_String_GD_CellRange_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663299);
			GD_API.NativeMethodInfoPtr_GetCellsList_Public_Static_List_1_GD_Cell_String_GD_CellRange_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663300);
			GD_API.NativeMethodInfoPtr_GetList_Public_Static_List_1_T_String_GD_CellRange_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663301);
			GD_API.NativeMethodInfoPtr_GetArray_Public_Static_Il2CppArrayBase_1_T_String_GD_CellRange_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663302);
			GD_API.NativeMethodInfoPtr_GetArray_Public_Static_Il2CppArrayBase_1_T_String_GD_CellRange_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663303);
			GD_API.NativeMethodInfoPtr_GetDictionary_Public_Static_Dictionary_2_K_V_String_GD_CellDictionaryRange_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663304);
			GD_API.NativeMethodInfoPtr_GetDictionary_Public_Static_Dictionary_2_K_V_String_GD_CellDictionaryRange_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663305);
			GD_API.NativeMethodInfoPtr_IsValueOfType_Public_Static_Boolean_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663306);
			GD_API.NativeMethodInfoPtr_IsValueOfType_Public_Static_Boolean_String_GD_Cell_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663307);
			GD_API.NativeMethodInfoPtr_FindCellByContent_Public_Static_GD_Cell_String_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663308);
			GD_API.NativeMethodInfoPtr_FindCellByContent_Public_Static_GD_Cell_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663309);
			GD_API.NativeMethodInfoPtr_FindCellByContent_Public_Static_GD_Cell_String_String_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663310);
			GD_API.NativeMethodInfoPtr_FindCellByContent_Public_Static_GD_Cell_String_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663311);
			GD_API.NativeMethodInfoPtr_FindCellByContent_Public_Static_GD_Cell_String_Int32_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663312);
			GD_API.NativeMethodInfoPtr_FindCellByContent_Public_Static_GD_Cell_String_Int32_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663313);
			GD_API.NativeMethodInfoPtr_FindCellsByContent_Public_Static_Il2CppReferenceArray_1_GD_Cell_String_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663314);
			GD_API.NativeMethodInfoPtr_FindCellsByContent_Public_Static_Il2CppReferenceArray_1_GD_Cell_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663315);
			GD_API.NativeMethodInfoPtr_FindCellsByContent_Public_Static_Il2CppReferenceArray_1_GD_Cell_String_String_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663316);
			GD_API.NativeMethodInfoPtr_FindCellsByContent_Public_Static_Il2CppReferenceArray_1_GD_Cell_String_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663317);
			GD_API.NativeMethodInfoPtr_FindCellsByContent_Public_Static_Il2CppReferenceArray_1_GD_Cell_String_Int32_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663318);
			GD_API.NativeMethodInfoPtr_FindCellsByContent_Public_Static_Il2CppReferenceArray_1_GD_Cell_String_Int32_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663319);
			GD_API.NativeMethodInfoPtr_RetrievePublicSheetData_Public_Static_Void_GD_DocTemplate_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663320);
			GD_API.NativeMethodInfoPtr_RetrievePublicSheetData_Public_Static_Void_GD_DocTemplate_GD_WorksheetTemplate_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_API>.NativeClassPtr, 100663321);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000029A0 File Offset: 0x00000BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124890, XrefRangeEnd = 124926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetValue<T>(string docName, int row, int col, int workSheetNumber = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref row;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref workSheetNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.MethodInfoStoreGeneric_GetValue_Public_Static_T_String_Int32_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002A08 File Offset: 0x00000C08
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 124926, RefRangeEnd = 124942, XrefRangeStart = 124926, XrefRangeEnd = 124926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetValue<T>(string docName, GD_Cell cell, int workSheetNumber = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cell);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref workSheetNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.MethodInfoStoreGeneric_GetValue_Public_Static_T_String_GD_Cell_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002A68 File Offset: 0x00000C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124942, XrefRangeEnd = 124951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> GetList<T>(string docName, GD_CellRange range, string workSheetName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(range);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(workSheetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.MethodInfoStoreGeneric_GetList_Public_Static_List_1_T_String_GD_CellRange_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002AD0 File Offset: 0x00000CD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125016, RefRangeEnd = 125018, XrefRangeStart = 124951, XrefRangeEnd = 125016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<GD_Cell> GetCellsList(string docName, GD_CellRange range, int workSheetNumber = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(range);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref workSheetNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.NativeMethodInfoPtr_GetCellsList_Public_Static_List_1_GD_Cell_String_GD_CellRange_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GD_Cell>>(intPtr3) : null;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002B34 File Offset: 0x00000D34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125037, RefRangeEnd = 125038, XrefRangeStart = 125018, XrefRangeEnd = 125037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> GetList<T>(string docName, GD_CellRange range, int workSheetNumber = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(range);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref workSheetNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.MethodInfoStoreGeneric_GetList_Public_Static_List_1_T_String_GD_CellRange_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002B98 File Offset: 0x00000D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125038, XrefRangeEnd = 125039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> GetArray<T>(string docName, GD_CellRange range, int workSheetNumber = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(range);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref workSheetNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.MethodInfoStoreGeneric_GetArray_Public_Static_Il2CppArrayBase_1_T_String_GD_CellRange_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125039, XrefRangeEnd = 125050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> GetArray<T>(string docName, GD_CellRange range, string workSheetName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(range);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(workSheetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.MethodInfoStoreGeneric_GetArray_Public_Static_Il2CppArrayBase_1_T_String_GD_CellRange_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002C54 File Offset: 0x00000E54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125059, RefRangeEnd = 125061, XrefRangeStart = 125050, XrefRangeEnd = 125059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<K, V> GetDictionary<K, V>(string docName, GD_CellDictionaryRange dictionaryRange, string workSheetName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dictionaryRange);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(workSheetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.MethodInfoStoreGeneric_GetDictionary_Public_Static_Dictionary_2_K_V_String_GD_CellDictionaryRange_String_0<K, V>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<K, V>>(intPtr3) : null;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002CBC File Offset: 0x00000EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125061, XrefRangeEnd = 125118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<K, V> GetDictionary<K, V>(string docName, GD_CellDictionaryRange dictionaryRange, int workSheetId = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dictionaryRange);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref workSheetId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.MethodInfoStoreGeneric_GetDictionary_Public_Static_Dictionary_2_K_V_String_GD_CellDictionaryRange_Int32_0<K, V>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<K, V>>(intPtr3) : null;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002D20 File Offset: 0x00000F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125118, XrefRangeEnd = 125149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValueOfType<T>(string docName, int row, int col, int workSheetNumber = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref row;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref workSheetNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.MethodInfoStoreGeneric_IsValueOfType_Public_Static_Boolean_String_Int32_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002D8C File Offset: 0x00000F8C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 124926, RefRangeEnd = 124942, XrefRangeStart = 124926, XrefRangeEnd = 124942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValueOfType<T>(string docName, GD_Cell cell, int workSheetNumber = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cell);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref workSheetNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.MethodInfoStoreGeneric_IsValueOfType_Public_Static_Boolean_String_GD_Cell_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125149, XrefRangeEnd = 125173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GD_Cell FindCellByContent(string docName, Object content, int workSheetNumber = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref workSheetNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.NativeMethodInfoPtr_FindCellByContent_Public_Static_GD_Cell_String_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GD_Cell>(intPtr3) : null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002E54 File Offset: 0x00001054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125173, XrefRangeEnd = 125180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GD_Cell FindCellByContent(string docName, Object content, string workSheetName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(workSheetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.NativeMethodInfoPtr_FindCellByContent_Public_Static_GD_Cell_String_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GD_Cell>(intPtr3) : null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002EBC File Offset: 0x000010BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125180, XrefRangeEnd = 125209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GD_Cell FindCellByContent(string docName, string column, Object content, int workSheetNumber = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(column);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref workSheetNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.NativeMethodInfoPtr_FindCellByContent_Public_Static_GD_Cell_String_String_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GD_Cell>(intPtr3) : null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002F34 File Offset: 0x00001134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125209, XrefRangeEnd = 125216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GD_Cell FindCellByContent(string docName, string column, Object content, string workSheetName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(column);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(workSheetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.NativeMethodInfoPtr_FindCellByContent_Public_Static_GD_Cell_String_String_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GD_Cell>(intPtr3) : null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002FB0 File Offset: 0x000011B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125216, XrefRangeEnd = 125239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GD_Cell FindCellByContent(string docName, int row, Object content, int workSheetNumber = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref row;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref workSheetNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.NativeMethodInfoPtr_FindCellByContent_Public_Static_GD_Cell_String_Int32_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GD_Cell>(intPtr3) : null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003024 File Offset: 0x00001224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125239, XrefRangeEnd = 125246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GD_Cell FindCellByContent(string docName, int row, Object content, string workSheetName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref row;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(workSheetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.NativeMethodInfoPtr_FindCellByContent_Public_Static_GD_Cell_String_Int32_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GD_Cell>(intPtr3) : null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000309C File Offset: 0x0000129C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125246, XrefRangeEnd = 125289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<GD_Cell> FindCellsByContent(string docName, Object content, int workSheetNumber = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref workSheetNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.NativeMethodInfoPtr_FindCellsByContent_Public_Static_Il2CppReferenceArray_1_GD_Cell_String_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GD_Cell>>(intPtr3) : null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003100 File Offset: 0x00001300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125289, XrefRangeEnd = 125305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<GD_Cell> FindCellsByContent(string docName, Object content, string workSheetName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(workSheetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.NativeMethodInfoPtr_FindCellsByContent_Public_Static_Il2CppReferenceArray_1_GD_Cell_String_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GD_Cell>>(intPtr3) : null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003168 File Offset: 0x00001368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125305, XrefRangeEnd = 125350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<GD_Cell> FindCellsByContent(string docName, string column, Object content, int workSheetNumber = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(column);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref workSheetNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.NativeMethodInfoPtr_FindCellsByContent_Public_Static_Il2CppReferenceArray_1_GD_Cell_String_String_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GD_Cell>>(intPtr3) : null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000031E0 File Offset: 0x000013E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125350, XrefRangeEnd = 125366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<GD_Cell> FindCellsByContent(string docName, string column, Object content, string workSheetName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(column);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(workSheetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.NativeMethodInfoPtr_FindCellsByContent_Public_Static_Il2CppReferenceArray_1_GD_Cell_String_String_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GD_Cell>>(intPtr3) : null;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000325C File Offset: 0x0000145C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125366, XrefRangeEnd = 125405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<GD_Cell> FindCellsByContent(string docName, int row, Object content, int workSheetNumber = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref row;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref workSheetNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.NativeMethodInfoPtr_FindCellsByContent_Public_Static_Il2CppReferenceArray_1_GD_Cell_String_Int32_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GD_Cell>>(intPtr3) : null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000032D0 File Offset: 0x000014D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125405, XrefRangeEnd = 125421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<GD_Cell> FindCellsByContent(string docName, int row, Object content, string workSheetName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(docName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref row;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(workSheetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.NativeMethodInfoPtr_FindCellsByContent_Public_Static_Il2CppReferenceArray_1_GD_Cell_String_Int32_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GD_Cell>>(intPtr3) : null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003348 File Offset: 0x00001548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125421, XrefRangeEnd = 125425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RetrievePublicSheetData(GD_DocTemplate doc, bool drawProgressBar = true, Action finish = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drawProgressBar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(finish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.NativeMethodInfoPtr_RetrievePublicSheetData_Public_Static_Void_GD_DocTemplate_Boolean_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000033A0 File Offset: 0x000015A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125425, XrefRangeEnd = 125448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RetrievePublicSheetData(GD_DocTemplate doc, GD_WorksheetTemplate worksheet, bool drawProgressBar = true, Action finish = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worksheet);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drawProgressBar;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(finish);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_API.NativeMethodInfoPtr_RetrievePublicSheetData_Public_Static_Void_GD_DocTemplate_GD_WorksheetTemplate_Boolean_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		public GD_API(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00003408 File Offset: 0x00001608
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static string NULL_VALUE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GD_API.NativeFieldInfoPtr_NULL_VALUE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GD_API.NativeFieldInfoPtr_NULL_VALUE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_NULL_VALUE;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Static_T_String_Int32_Int32_Int32_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Static_T_String_GD_Cell_Int32_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_GetList_Public_Static_List_1_T_String_GD_CellRange_String_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_GetCellsList_Public_Static_List_1_GD_Cell_String_GD_CellRange_Int32_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_GetList_Public_Static_List_1_T_String_GD_CellRange_Int32_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_GetArray_Public_Static_Il2CppArrayBase_1_T_String_GD_CellRange_Int32_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_GetArray_Public_Static_Il2CppArrayBase_1_T_String_GD_CellRange_String_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_GetDictionary_Public_Static_Dictionary_2_K_V_String_GD_CellDictionaryRange_String_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_GetDictionary_Public_Static_Dictionary_2_K_V_String_GD_CellDictionaryRange_Int32_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_IsValueOfType_Public_Static_Boolean_String_Int32_Int32_Int32_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_IsValueOfType_Public_Static_Boolean_String_GD_Cell_Int32_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_FindCellByContent_Public_Static_GD_Cell_String_Object_Int32_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_FindCellByContent_Public_Static_GD_Cell_String_Object_String_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_FindCellByContent_Public_Static_GD_Cell_String_String_Object_Int32_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_FindCellByContent_Public_Static_GD_Cell_String_String_Object_String_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_FindCellByContent_Public_Static_GD_Cell_String_Int32_Object_Int32_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_FindCellByContent_Public_Static_GD_Cell_String_Int32_Object_String_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_FindCellsByContent_Public_Static_Il2CppReferenceArray_1_GD_Cell_String_Object_Int32_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_FindCellsByContent_Public_Static_Il2CppReferenceArray_1_GD_Cell_String_Object_String_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_FindCellsByContent_Public_Static_Il2CppReferenceArray_1_GD_Cell_String_String_Object_Int32_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_FindCellsByContent_Public_Static_Il2CppReferenceArray_1_GD_Cell_String_String_Object_String_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_FindCellsByContent_Public_Static_Il2CppReferenceArray_1_GD_Cell_String_Int32_Object_Int32_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_FindCellsByContent_Public_Static_Il2CppReferenceArray_1_GD_Cell_String_Int32_Object_String_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_RetrievePublicSheetData_Public_Static_Void_GD_DocTemplate_Boolean_Action_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_RetrievePublicSheetData_Public_Static_Void_GD_DocTemplate_GD_WorksheetTemplate_Boolean_Action_0;

		// Token: 0x02000017 RID: 23
		private sealed class MethodInfoStoreGeneric_GetValue_Public_Static_T_String_Int32_Int32_Int32_0<T>
		{
			// Token: 0x040000DB RID: 219
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GD_API.NativeMethodInfoPtr_GetValue_Public_Static_T_String_Int32_Int32_Int32_0, Il2CppClassPointerStore<GD_API>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000018 RID: 24
		private sealed class MethodInfoStoreGeneric_GetValue_Public_Static_T_String_GD_Cell_Int32_0<T>
		{
			// Token: 0x040000DC RID: 220
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GD_API.NativeMethodInfoPtr_GetValue_Public_Static_T_String_GD_Cell_Int32_0, Il2CppClassPointerStore<GD_API>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000019 RID: 25
		private sealed class MethodInfoStoreGeneric_GetList_Public_Static_List_1_T_String_GD_CellRange_String_0<T>
		{
			// Token: 0x040000DD RID: 221
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GD_API.NativeMethodInfoPtr_GetList_Public_Static_List_1_T_String_GD_CellRange_String_0, Il2CppClassPointerStore<GD_API>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001A RID: 26
		private sealed class MethodInfoStoreGeneric_GetList_Public_Static_List_1_T_String_GD_CellRange_Int32_0<T>
		{
			// Token: 0x040000DE RID: 222
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GD_API.NativeMethodInfoPtr_GetList_Public_Static_List_1_T_String_GD_CellRange_Int32_0, Il2CppClassPointerStore<GD_API>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001B RID: 27
		private sealed class MethodInfoStoreGeneric_GetArray_Public_Static_Il2CppArrayBase_1_T_String_GD_CellRange_Int32_0<T>
		{
			// Token: 0x040000DF RID: 223
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GD_API.NativeMethodInfoPtr_GetArray_Public_Static_Il2CppArrayBase_1_T_String_GD_CellRange_Int32_0, Il2CppClassPointerStore<GD_API>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001C RID: 28
		private sealed class MethodInfoStoreGeneric_GetArray_Public_Static_Il2CppArrayBase_1_T_String_GD_CellRange_String_0<T>
		{
			// Token: 0x040000E0 RID: 224
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GD_API.NativeMethodInfoPtr_GetArray_Public_Static_Il2CppArrayBase_1_T_String_GD_CellRange_String_0, Il2CppClassPointerStore<GD_API>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001D RID: 29
		private sealed class MethodInfoStoreGeneric_GetDictionary_Public_Static_Dictionary_2_K_V_String_GD_CellDictionaryRange_String_0<K, V>
		{
			// Token: 0x040000E1 RID: 225
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GD_API.NativeMethodInfoPtr_GetDictionary_Public_Static_Dictionary_2_K_V_String_GD_CellDictionaryRange_String_0, Il2CppClassPointerStore<GD_API>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200001E RID: 30
		private sealed class MethodInfoStoreGeneric_GetDictionary_Public_Static_Dictionary_2_K_V_String_GD_CellDictionaryRange_Int32_0<K, V>
		{
			// Token: 0x040000E2 RID: 226
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GD_API.NativeMethodInfoPtr_GetDictionary_Public_Static_Dictionary_2_K_V_String_GD_CellDictionaryRange_Int32_0, Il2CppClassPointerStore<GD_API>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200001F RID: 31
		private sealed class MethodInfoStoreGeneric_IsValueOfType_Public_Static_Boolean_String_Int32_Int32_Int32_0<T>
		{
			// Token: 0x040000E3 RID: 227
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GD_API.NativeMethodInfoPtr_IsValueOfType_Public_Static_Boolean_String_Int32_Int32_Int32_0, Il2CppClassPointerStore<GD_API>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000020 RID: 32
		private sealed class MethodInfoStoreGeneric_IsValueOfType_Public_Static_Boolean_String_GD_Cell_Int32_0<T>
		{
			// Token: 0x040000E4 RID: 228
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GD_API.NativeMethodInfoPtr_IsValueOfType_Public_Static_Boolean_String_GD_Cell_Int32_0, Il2CppClassPointerStore<GD_API>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C0 RID: 192
	[Serializable]
	public class StyleSheet : ScriptableObject
	{
		// Token: 0x06000AFE RID: 2814 RVA: 0x0002E114 File Offset: 0x0002C314
		// Note: this type is marked as 'beforefieldinit'.
		static StyleSheet()
		{
			Il2CppClassPointerStore<StyleSheet>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StyleSheet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr);
			StyleSheet.NativeFieldInfoPtr_m_Rules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "m_Rules");
			StyleSheet.NativeFieldInfoPtr_m_ComplexSelectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "m_ComplexSelectors");
			StyleSheet.NativeFieldInfoPtr_floats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "floats");
			StyleSheet.NativeFieldInfoPtr_dimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "dimensions");
			StyleSheet.NativeFieldInfoPtr_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "colors");
			StyleSheet.NativeFieldInfoPtr_strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "strings");
			StyleSheet.NativeFieldInfoPtr_assets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "assets");
			StyleSheet.NativeFieldInfoPtr_imports = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "imports");
			StyleSheet.NativeFieldInfoPtr_m_FlattenedImportedStyleSheets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "m_FlattenedImportedStyleSheets");
			StyleSheet.NativeFieldInfoPtr_m_ContentHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "m_ContentHash");
			StyleSheet.NativeFieldInfoPtr_scalableImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "scalableImages");
			StyleSheet.NativeFieldInfoPtr_orderedNameSelectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "orderedNameSelectors");
			StyleSheet.NativeFieldInfoPtr_orderedTypeSelectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "orderedTypeSelectors");
			StyleSheet.NativeFieldInfoPtr_orderedClassSelectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "orderedClassSelectors");
			StyleSheet.NativeFieldInfoPtr_isUnityStyleSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "isUnityStyleSheet");
			StyleSheet.NativeFieldInfoPtr_kCustomPropertyMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "kCustomPropertyMarker");
			StyleSheet.NativeMethodInfoPtr_get_rules_Internal_get_Il2CppReferenceArray_1_StyleRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664223);
			StyleSheet.NativeMethodInfoPtr_set_rules_Internal_set_Void_Il2CppReferenceArray_1_StyleRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664224);
			StyleSheet.NativeMethodInfoPtr_get_complexSelectors_Internal_get_Il2CppReferenceArray_1_StyleComplexSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664225);
			StyleSheet.NativeMethodInfoPtr_set_complexSelectors_Internal_set_Void_Il2CppReferenceArray_1_StyleComplexSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664226);
			StyleSheet.NativeMethodInfoPtr_get_flattenedRecursiveImports_Internal_get_List_1_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664227);
			StyleSheet.NativeMethodInfoPtr_get_contentHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664228);
			StyleSheet.NativeMethodInfoPtr_set_contentHash_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664229);
			StyleSheet.NativeMethodInfoPtr_TryCheckAccess_Private_Static_Boolean_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664230);
			StyleSheet.NativeMethodInfoPtr_CheckAccess_Private_Static_T_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664231);
			StyleSheet.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664232);
			StyleSheet.NativeMethodInfoPtr_FlattenImportedStyleSheetsRecursive_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664233);
			StyleSheet.NativeMethodInfoPtr_FlattenImportedStyleSheetsRecursive_Private_Void_StyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664234);
			StyleSheet.NativeMethodInfoPtr_SetupReferences_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664235);
			StyleSheet.NativeMethodInfoPtr_ReadKeyword_Internal_StyleValueKeyword_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664236);
			StyleSheet.NativeMethodInfoPtr_ReadFloat_Internal_Single_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664237);
			StyleSheet.NativeMethodInfoPtr_TryReadFloat_Internal_Boolean_StyleValueHandle_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664238);
			StyleSheet.NativeMethodInfoPtr_ReadDimension_Internal_Dimension_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664239);
			StyleSheet.NativeMethodInfoPtr_TryReadDimension_Internal_Boolean_StyleValueHandle_byref_Dimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664240);
			StyleSheet.NativeMethodInfoPtr_ReadColor_Internal_Color_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664241);
			StyleSheet.NativeMethodInfoPtr_TryReadColor_Internal_Boolean_StyleValueHandle_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664242);
			StyleSheet.NativeMethodInfoPtr_ReadString_Internal_String_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664243);
			StyleSheet.NativeMethodInfoPtr_TryReadString_Internal_Boolean_StyleValueHandle_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664244);
			StyleSheet.NativeMethodInfoPtr_ReadEnum_Internal_String_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664245);
			StyleSheet.NativeMethodInfoPtr_TryReadEnum_Internal_Boolean_StyleValueHandle_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664246);
			StyleSheet.NativeMethodInfoPtr_ReadVariable_Internal_String_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664247);
			StyleSheet.NativeMethodInfoPtr_TryReadVariable_Internal_Boolean_StyleValueHandle_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664248);
			StyleSheet.NativeMethodInfoPtr_ReadResourcePath_Internal_String_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664249);
			StyleSheet.NativeMethodInfoPtr_TryReadResourcePath_Internal_Boolean_StyleValueHandle_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664250);
			StyleSheet.NativeMethodInfoPtr_ReadAssetReference_Internal_Object_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664251);
			StyleSheet.NativeMethodInfoPtr_ReadMissingAssetReferenceUrl_Internal_String_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664252);
			StyleSheet.NativeMethodInfoPtr_TryReadAssetReference_Internal_Boolean_StyleValueHandle_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664253);
			StyleSheet.NativeMethodInfoPtr_ReadFunction_Internal_StyleValueFunction_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664254);
			StyleSheet.NativeMethodInfoPtr_ReadFunctionName_Internal_String_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664255);
			StyleSheet.NativeMethodInfoPtr_ReadScalableImage_Internal_ScalableImage_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664256);
			StyleSheet.NativeMethodInfoPtr_CustomStartsWith_Private_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664257);
			StyleSheet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, 100664258);
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x0002E554 File Offset: 0x0002C754
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x0002E594 File Offset: 0x0002C794
		public unsafe Il2CppReferenceArray<StyleRule> rules
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 79925, RefRangeEnd = 79936, XrefRangeStart = 79925, XrefRangeEnd = 79936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_get_rules_Internal_get_Il2CppReferenceArray_1_StyleRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleRule>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96956, XrefRangeEnd = 96957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_set_rules_Internal_set_Void_Il2CppReferenceArray_1_StyleRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x0002E5D8 File Offset: 0x0002C7D8
		// (set) Token: 0x06000B02 RID: 2818 RVA: 0x0002E618 File Offset: 0x0002C818
		public unsafe Il2CppReferenceArray<StyleComplexSelector> complexSelectors
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 80223, RefRangeEnd = 80226, XrefRangeStart = 80223, XrefRangeEnd = 80226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_get_complexSelectors_Internal_get_Il2CppReferenceArray_1_StyleComplexSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleComplexSelector>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96957, XrefRangeEnd = 96958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_set_complexSelectors_Internal_set_Void_Il2CppReferenceArray_1_StyleComplexSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x0002E65C File Offset: 0x0002C85C
		public unsafe List<StyleSheet> flattenedRecursiveImports
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_get_flattenedRecursiveImports_Internal_get_List_1_StyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StyleSheet>>(intPtr3) : null;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0002E69C File Offset: 0x0002C89C
		// (set) Token: 0x06000B05 RID: 2821 RVA: 0x0002E6D8 File Offset: 0x0002C8D8
		public unsafe int contentHash
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_get_contentHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(169)]
			[CachedScanResults(RefRangeStart = 90728, RefRangeEnd = 90897, XrefRangeStart = 90728, XrefRangeEnd = 90897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_set_contentHash_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0002E718 File Offset: 0x0002C918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96963, RefRangeEnd = 96964, XrefRangeStart = 96958, XrefRangeEnd = 96963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryCheckAccess<T>(Il2CppArrayBase<T> list, StyleValueType type, StyleValueHandle handle, out T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StyleSheet.MethodInfoStoreGeneric_TryCheckAccess_Private_Static_Boolean_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0002E7C4 File Offset: 0x0002C9C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96970, RefRangeEnd = 96971, XrefRangeStart = 96964, XrefRangeEnd = 96970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T CheckAccess<T>(Il2CppArrayBase<T> list, StyleValueType type, StyleValueHandle handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.MethodInfoStoreGeneric_CheckAccess_Private_Static_T_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0002E820 File Offset: 0x0002CA20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96971, XrefRangeEnd = 96972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0002E854 File Offset: 0x0002CA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96972, XrefRangeEnd = 96979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlattenImportedStyleSheetsRecursive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_FlattenImportedStyleSheetsRecursive_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0002E888 File Offset: 0x0002CA88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96988, RefRangeEnd = 96990, XrefRangeStart = 96979, XrefRangeEnd = 96988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlattenImportedStyleSheetsRecursive(StyleSheet sheet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sheet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_FlattenImportedStyleSheetsRecursive_Private_Void_StyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0002E8CC File Offset: 0x0002CACC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 97053, RefRangeEnd = 97056, XrefRangeStart = 96990, XrefRangeEnd = 97053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupReferences()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_SetupReferences_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0002E900 File Offset: 0x0002CB00
		[CallerCount(0)]
		public unsafe StyleValueKeyword ReadKeyword(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadKeyword_Internal_StyleValueKeyword_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0002E94C File Offset: 0x0002CB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97056, XrefRangeEnd = 97066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ReadFloat(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadFloat_Internal_Single_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0002E998 File Offset: 0x0002CB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97066, XrefRangeEnd = 97078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryReadFloat(StyleValueHandle handle, out float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_TryReadFloat_Internal_Boolean_StyleValueHandle_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0002E9F0 File Offset: 0x0002CBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97078, XrefRangeEnd = 97089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.UIElements.StyleSheets.Dimension ReadDimension(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadDimension_Internal_Dimension_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0002EA3C File Offset: 0x0002CC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97089, XrefRangeEnd = 97101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryReadDimension(StyleValueHandle handle, out UnityEngine.UIElements.StyleSheets.Dimension value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_TryReadDimension_Internal_Boolean_StyleValueHandle_byref_Dimension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0002EA94 File Offset: 0x0002CC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97101, XrefRangeEnd = 97107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color ReadColor(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadColor_Internal_Color_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0002EAE0 File Offset: 0x0002CCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97107, XrefRangeEnd = 97113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryReadColor(StyleValueHandle handle, out Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_TryReadColor_Internal_Boolean_StyleValueHandle_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0002EB38 File Offset: 0x0002CD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97113, XrefRangeEnd = 97119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadString(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadString_Internal_String_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0002EB7C File Offset: 0x0002CD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97119, XrefRangeEnd = 97125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryReadString(StyleValueHandle handle, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_TryReadString_Internal_Boolean_StyleValueHandle_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0002EBE0 File Offset: 0x0002CDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97125, XrefRangeEnd = 97131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadEnum(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadEnum_Internal_String_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0002EC24 File Offset: 0x0002CE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97131, XrefRangeEnd = 97137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryReadEnum(StyleValueHandle handle, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_TryReadEnum_Internal_Boolean_StyleValueHandle_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0002EC88 File Offset: 0x0002CE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97137, XrefRangeEnd = 97143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadVariable(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadVariable_Internal_String_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0002ECCC File Offset: 0x0002CECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97143, XrefRangeEnd = 97149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryReadVariable(StyleValueHandle handle, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_TryReadVariable_Internal_Boolean_StyleValueHandle_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0002ED30 File Offset: 0x0002CF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97149, XrefRangeEnd = 97155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadResourcePath(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadResourcePath_Internal_String_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0002ED74 File Offset: 0x0002CF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97155, XrefRangeEnd = 97161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryReadResourcePath(StyleValueHandle handle, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_TryReadResourcePath_Internal_Boolean_StyleValueHandle_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0002EDD8 File Offset: 0x0002CFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97161, XrefRangeEnd = 97167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadAssetReference(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadAssetReference_Internal_Object_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0002EE24 File Offset: 0x0002D024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97167, XrefRangeEnd = 97173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadMissingAssetReferenceUrl(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadMissingAssetReferenceUrl_Internal_String_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0002EE68 File Offset: 0x0002D068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97173, XrefRangeEnd = 97179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryReadAssetReference(StyleValueHandle handle, out Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_TryReadAssetReference_Internal_Boolean_StyleValueHandle_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0002EED4 File Offset: 0x0002D0D4
		[CallerCount(0)]
		public unsafe StyleValueFunction ReadFunction(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadFunction_Internal_StyleValueFunction_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0002EF20 File Offset: 0x0002D120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97179, XrefRangeEnd = 97188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadFunctionName(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadFunctionName_Internal_String_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0002EF64 File Offset: 0x0002D164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97188, XrefRangeEnd = 97194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.UIElements.StyleSheets.ScalableImage ReadScalableImage(StyleValueHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_ReadScalableImage_Internal_ScalableImage_StyleValueHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new UnityEngine.UIElements.StyleSheets.ScalableImage(intPtr);
			}
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0002EFA8 File Offset: 0x0002D1A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 97198, RefRangeEnd = 97199, XrefRangeStart = 97194, XrefRangeEnd = 97198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CustomStartsWith(string originalString, string pattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(originalString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr_CustomStartsWith_Private_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0002EFFC File Offset: 0x0002D1FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 82720, RefRangeEnd = 82724, XrefRangeStart = 82720, XrefRangeEnd = 82724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StyleSheet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00006F07 File Offset: 0x00005107
		public StyleSheet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x0002F038 File Offset: 0x0002D238
		// (set) Token: 0x06000B25 RID: 2853 RVA: 0x00006F10 File Offset: 0x00005110
		public unsafe Il2CppReferenceArray<StyleRule> m_Rules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_Rules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleRule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_Rules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x0002F068 File Offset: 0x0002D268
		// (set) Token: 0x06000B27 RID: 2855 RVA: 0x00006F2F File Offset: 0x0000512F
		public unsafe Il2CppReferenceArray<StyleComplexSelector> m_ComplexSelectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_ComplexSelectors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleComplexSelector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_ComplexSelectors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x0002F098 File Offset: 0x0002D298
		// (set) Token: 0x06000B29 RID: 2857 RVA: 0x00006F4E File Offset: 0x0000514E
		public unsafe Il2CppStructArray<float> floats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_floats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_floats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x0002F0C8 File Offset: 0x0002D2C8
		// (set) Token: 0x06000B2B RID: 2859 RVA: 0x00006F6D File Offset: 0x0000516D
		public unsafe Il2CppStructArray<UnityEngine.UIElements.StyleSheets.Dimension> dimensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_dimensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<UnityEngine.UIElements.StyleSheets.Dimension>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_dimensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x0002F0F8 File Offset: 0x0002D2F8
		// (set) Token: 0x06000B2D RID: 2861 RVA: 0x00006F8C File Offset: 0x0000518C
		public unsafe Il2CppStructArray<Color> colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x0002F128 File Offset: 0x0002D328
		// (set) Token: 0x06000B2F RID: 2863 RVA: 0x00006FAB File Offset: 0x000051AB
		public unsafe Il2CppStringArray strings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_strings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_strings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x0002F158 File Offset: 0x0002D358
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x00006FCA File Offset: 0x000051CA
		public unsafe Il2CppReferenceArray<Object> assets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_assets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_assets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x0002F188 File Offset: 0x0002D388
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x00006FE9 File Offset: 0x000051E9
		public unsafe Il2CppReferenceArray<StyleSheet.ImportStruct> imports
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_imports);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StyleSheet.ImportStruct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_imports), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x0002F1B8 File Offset: 0x0002D3B8
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x00007008 File Offset: 0x00005208
		public unsafe List<StyleSheet> m_FlattenedImportedStyleSheets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_FlattenedImportedStyleSheets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StyleSheet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_FlattenedImportedStyleSheets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x0002F1E8 File Offset: 0x0002D3E8
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x00007027 File Offset: 0x00005227
		public unsafe int m_ContentHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_ContentHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_m_ContentHash)) = value;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0002F210 File Offset: 0x0002D410
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x00007042 File Offset: 0x00005242
		public unsafe Il2CppReferenceArray<UnityEngine.UIElements.StyleSheets.ScalableImage> scalableImages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_scalableImages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityEngine.UIElements.StyleSheets.ScalableImage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_scalableImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x0002F240 File Offset: 0x0002D440
		// (set) Token: 0x06000B3B RID: 2875 RVA: 0x00007061 File Offset: 0x00005261
		public unsafe Dictionary<string, StyleComplexSelector> orderedNameSelectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_orderedNameSelectors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, StyleComplexSelector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_orderedNameSelectors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x0002F270 File Offset: 0x0002D470
		// (set) Token: 0x06000B3D RID: 2877 RVA: 0x00007080 File Offset: 0x00005280
		public unsafe Dictionary<string, StyleComplexSelector> orderedTypeSelectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_orderedTypeSelectors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, StyleComplexSelector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_orderedTypeSelectors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x0002F2A0 File Offset: 0x0002D4A0
		// (set) Token: 0x06000B3F RID: 2879 RVA: 0x0000709F File Offset: 0x0000529F
		public unsafe Dictionary<string, StyleComplexSelector> orderedClassSelectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_orderedClassSelectors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, StyleComplexSelector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_orderedClassSelectors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x0002F2D0 File Offset: 0x0002D4D0
		// (set) Token: 0x06000B41 RID: 2881 RVA: 0x000070BE File Offset: 0x000052BE
		public unsafe bool isUnityStyleSheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_isUnityStyleSheet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.NativeFieldInfoPtr_isUnityStyleSheet)) = value;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x0002F2F8 File Offset: 0x0002D4F8
		// (set) Token: 0x06000B43 RID: 2883 RVA: 0x000070D9 File Offset: 0x000052D9
		public unsafe static string kCustomPropertyMarker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StyleSheet.NativeFieldInfoPtr_kCustomPropertyMarker, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StyleSheet.NativeFieldInfoPtr_kCustomPropertyMarker, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeFieldInfoPtr_m_Rules;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeFieldInfoPtr_m_ComplexSelectors;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeFieldInfoPtr_floats;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeFieldInfoPtr_dimensions;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeFieldInfoPtr_colors;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeFieldInfoPtr_strings;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeFieldInfoPtr_assets;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeFieldInfoPtr_imports;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeFieldInfoPtr_m_FlattenedImportedStyleSheets;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeFieldInfoPtr_m_ContentHash;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeFieldInfoPtr_scalableImages;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeFieldInfoPtr_orderedNameSelectors;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeFieldInfoPtr_orderedTypeSelectors;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeFieldInfoPtr_orderedClassSelectors;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeFieldInfoPtr_isUnityStyleSheet;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeFieldInfoPtr_kCustomPropertyMarker;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr_get_rules_Internal_get_Il2CppReferenceArray_1_StyleRule_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr_set_rules_Internal_set_Void_Il2CppReferenceArray_1_StyleRule_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_get_complexSelectors_Internal_get_Il2CppReferenceArray_1_StyleComplexSelector_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_set_complexSelectors_Internal_set_Void_Il2CppReferenceArray_1_StyleComplexSelector_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_get_flattenedRecursiveImports_Internal_get_List_1_StyleSheet_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_get_contentHash_Public_get_Int32_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_set_contentHash_Public_set_Void_Int32_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_TryCheckAccess_Private_Static_Boolean_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_byref_T_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_CheckAccess_Private_Static_T_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_FlattenImportedStyleSheetsRecursive_Internal_Void_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_FlattenImportedStyleSheetsRecursive_Private_Void_StyleSheet_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_SetupReferences_Private_Void_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_ReadKeyword_Internal_StyleValueKeyword_StyleValueHandle_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_ReadFloat_Internal_Single_StyleValueHandle_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_TryReadFloat_Internal_Boolean_StyleValueHandle_byref_Single_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_ReadDimension_Internal_Dimension_StyleValueHandle_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_TryReadDimension_Internal_Boolean_StyleValueHandle_byref_Dimension_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_ReadColor_Internal_Color_StyleValueHandle_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_TryReadColor_Internal_Boolean_StyleValueHandle_byref_Color_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_ReadString_Internal_String_StyleValueHandle_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_TryReadString_Internal_Boolean_StyleValueHandle_byref_String_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_ReadEnum_Internal_String_StyleValueHandle_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_TryReadEnum_Internal_Boolean_StyleValueHandle_byref_String_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_ReadVariable_Internal_String_StyleValueHandle_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_TryReadVariable_Internal_Boolean_StyleValueHandle_byref_String_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_ReadResourcePath_Internal_String_StyleValueHandle_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_TryReadResourcePath_Internal_Boolean_StyleValueHandle_byref_String_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_ReadAssetReference_Internal_Object_StyleValueHandle_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_ReadMissingAssetReferenceUrl_Internal_String_StyleValueHandle_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_TryReadAssetReference_Internal_Boolean_StyleValueHandle_byref_Object_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_ReadFunction_Internal_StyleValueFunction_StyleValueHandle_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr_ReadFunctionName_Internal_String_StyleValueHandle_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_ReadScalableImage_Internal_ScalableImage_StyleValueHandle_0;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr_CustomStartsWith_Private_Static_Boolean_String_String_0;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000226 RID: 550
		[Serializable]
		public sealed class ImportStruct : ValueType
		{
			// Token: 0x060013CF RID: 5071 RVA: 0x0003CA80 File Offset: 0x0003AC80
			// Note: this type is marked as 'beforefieldinit'.
			static ImportStruct()
			{
				Il2CppClassPointerStore<StyleSheet.ImportStruct>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StyleSheet>.NativeClassPtr, "ImportStruct");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSheet.ImportStruct>.NativeClassPtr);
				StyleSheet.ImportStruct.NativeFieldInfoPtr_styleSheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet.ImportStruct>.NativeClassPtr, "styleSheet");
				StyleSheet.ImportStruct.NativeFieldInfoPtr_mediaQueries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheet.ImportStruct>.NativeClassPtr, "mediaQueries");
			}

			// Token: 0x060013D0 RID: 5072 RVA: 0x0000CA8F File Offset: 0x0000AC8F
			public ImportStruct(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060013D1 RID: 5073 RVA: 0x0000CA98 File Offset: 0x0000AC98
			public ImportStruct()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StyleSheet.ImportStruct>.NativeClassPtr))
			{
			}

			// Token: 0x17000623 RID: 1571
			// (get) Token: 0x060013D2 RID: 5074 RVA: 0x0003CAD4 File Offset: 0x0003ACD4
			// (set) Token: 0x060013D3 RID: 5075 RVA: 0x0000CAAA File Offset: 0x0000ACAA
			public unsafe StyleSheet styleSheet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.ImportStruct.NativeFieldInfoPtr_styleSheet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.ImportStruct.NativeFieldInfoPtr_styleSheet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000624 RID: 1572
			// (get) Token: 0x060013D4 RID: 5076 RVA: 0x0003CB04 File Offset: 0x0003AD04
			// (set) Token: 0x060013D5 RID: 5077 RVA: 0x0000CAC9 File Offset: 0x0000ACC9
			public unsafe Il2CppStringArray mediaQueries
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.ImportStruct.NativeFieldInfoPtr_mediaQueries);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StyleSheet.ImportStruct.NativeFieldInfoPtr_mediaQueries), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008E9 RID: 2281
			private static readonly IntPtr NativeFieldInfoPtr_styleSheet;

			// Token: 0x040008EA RID: 2282
			private static readonly IntPtr NativeFieldInfoPtr_mediaQueries;
		}

		// Token: 0x02000227 RID: 551
		private sealed class MethodInfoStoreGeneric_TryCheckAccess_Private_Static_Boolean_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_byref_T_0<T>
		{
			// Token: 0x040008EB RID: 2283
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StyleSheet.NativeMethodInfoPtr_TryCheckAccess_Private_Static_Boolean_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_byref_T_0, Il2CppClassPointerStore<StyleSheet>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000228 RID: 552
		private sealed class MethodInfoStoreGeneric_CheckAccess_Private_Static_T_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_0<T>
		{
			// Token: 0x040008EC RID: 2284
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(StyleSheet.NativeMethodInfoPtr_CheckAccess_Private_Static_T_Il2CppArrayBase_1_T_StyleValueType_StyleValueHandle_0, Il2CppClassPointerStore<StyleSheet>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

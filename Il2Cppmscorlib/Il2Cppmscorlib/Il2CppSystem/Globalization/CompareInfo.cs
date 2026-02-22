using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Globalization.Unicode;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200022A RID: 554
	[Serializable]
	public class CompareInfo : Object
	{
		// Token: 0x06002462 RID: 9314 RVA: 0x000C48C0 File Offset: 0x000C2AC0
		// Note: this type is marked as 'beforefieldinit'.
		static CompareInfo()
		{
			Il2CppClassPointerStore<CompareInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CompareInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr);
			CompareInfo.NativeFieldInfoPtr_ValidIndexMaskOffFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "ValidIndexMaskOffFlags");
			CompareInfo.NativeFieldInfoPtr_ValidCompareMaskOffFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "ValidCompareMaskOffFlags");
			CompareInfo.NativeFieldInfoPtr_ValidHashCodeOfStringMaskOffFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "ValidHashCodeOfStringMaskOffFlags");
			CompareInfo.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "m_name");
			CompareInfo.NativeFieldInfoPtr_m_sortName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "m_sortName");
			CompareInfo.NativeFieldInfoPtr_win32LCID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "win32LCID");
			CompareInfo.NativeFieldInfoPtr_culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "culture");
			CompareInfo.NativeFieldInfoPtr_LINGUISTIC_IGNORECASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "LINGUISTIC_IGNORECASE");
			CompareInfo.NativeFieldInfoPtr_NORM_IGNORECASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "NORM_IGNORECASE");
			CompareInfo.NativeFieldInfoPtr_NORM_IGNOREKANATYPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "NORM_IGNOREKANATYPE");
			CompareInfo.NativeFieldInfoPtr_LINGUISTIC_IGNOREDIACRITIC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "LINGUISTIC_IGNOREDIACRITIC");
			CompareInfo.NativeFieldInfoPtr_NORM_IGNORENONSPACE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "NORM_IGNORENONSPACE");
			CompareInfo.NativeFieldInfoPtr_NORM_IGNORESYMBOLS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "NORM_IGNORESYMBOLS");
			CompareInfo.NativeFieldInfoPtr_NORM_IGNOREWIDTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "NORM_IGNOREWIDTH");
			CompareInfo.NativeFieldInfoPtr_SORT_STRINGSORT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "SORT_STRINGSORT");
			CompareInfo.NativeFieldInfoPtr_COMPARE_OPTIONS_ORDINAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "COMPARE_OPTIONS_ORDINAL");
			CompareInfo.NativeFieldInfoPtr_NORM_LINGUISTIC_CASING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "NORM_LINGUISTIC_CASING");
			CompareInfo.NativeFieldInfoPtr_RESERVED_FIND_ASCII_STRING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "RESERVED_FIND_ASCII_STRING");
			CompareInfo.NativeFieldInfoPtr_SORT_VERSION_WHIDBEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "SORT_VERSION_WHIDBEY");
			CompareInfo.NativeFieldInfoPtr_SORT_VERSION_V4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "SORT_VERSION_V4");
			CompareInfo.NativeFieldInfoPtr_m_SortVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "m_SortVersion");
			CompareInfo.NativeFieldInfoPtr_collator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "collator");
			CompareInfo.NativeFieldInfoPtr_collators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "collators");
			CompareInfo.NativeFieldInfoPtr_managedCollation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "managedCollation");
			CompareInfo.NativeFieldInfoPtr_managedCollationChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, "managedCollationChecked");
			CompareInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669320);
			CompareInfo.NativeMethodInfoPtr_GetCompareInfo_Public_Static_CompareInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669321);
			CompareInfo.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669322);
			CompareInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669323);
			CompareInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669324);
			CompareInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669325);
			CompareInfo.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669326);
			CompareInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669327);
			CompareInfo.NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669328);
			CompareInfo.NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669329);
			CompareInfo.NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669330);
			CompareInfo.NativeMethodInfoPtr_CompareOrdinal_Private_Static_Int32_String_Int32_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669331);
			CompareInfo.NativeMethodInfoPtr_IsPrefix_Public_Virtual_New_Boolean_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669332);
			CompareInfo.NativeMethodInfoPtr_IsSuffix_Public_Virtual_New_Boolean_String_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669333);
			CompareInfo.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669334);
			CompareInfo.NativeMethodInfoPtr_LastIndexOf_Public_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669335);
			CompareInfo.NativeMethodInfoPtr_GetSortKey_Public_Virtual_New_SortKey_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669336);
			CompareInfo.NativeMethodInfoPtr_CreateSortKey_Private_SortKey_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669337);
			CompareInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669338);
			CompareInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669339);
			CompareInfo.NativeMethodInfoPtr_GetHashCodeOfString_Internal_Int32_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669340);
			CompareInfo.NativeMethodInfoPtr_GetHashCodeOfString_Internal_Int32_String_CompareOptions_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669341);
			CompareInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669342);
			CompareInfo.NativeMethodInfoPtr_get_UseManagedCollation_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669343);
			CompareInfo.NativeMethodInfoPtr_GetCollator_Private_SimpleCollator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669344);
			CompareInfo.NativeMethodInfoPtr_CreateSortKeyCore_Private_SortKey_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669345);
			CompareInfo.NativeMethodInfoPtr_internal_index_switch_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669346);
			CompareInfo.NativeMethodInfoPtr_internal_compare_switch_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669347);
			CompareInfo.NativeMethodInfoPtr_internal_compare_managed_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669348);
			CompareInfo.NativeMethodInfoPtr_internal_index_managed_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669349);
			CompareInfo.NativeMethodInfoPtr_assign_sortkey_Private_Void_Object_String_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669350);
			CompareInfo.NativeMethodInfoPtr_internal_compare_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669351);
			CompareInfo.NativeMethodInfoPtr_internal_index_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669352);
			CompareInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr, 100669353);
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x000C4D8C File Offset: 0x000C2F8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324926, RefRangeEnd = 324927, XrefRangeStart = 324925, XrefRangeEnd = 324926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompareInfo(CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x000C4DD8 File Offset: 0x000C2FD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324938, RefRangeEnd = 324939, XrefRangeStart = 324927, XrefRangeEnd = 324938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CompareInfo GetCompareInfo(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_GetCompareInfo_Public_Static_CompareInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x000C4E1C File Offset: 0x000C301C
		[CallerCount(0)]
		public unsafe void OnDeserializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x000C4E64 File Offset: 0x000C3064
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 324946, RefRangeEnd = 324948, XrefRangeStart = 324939, XrefRangeEnd = 324946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x000C4E98 File Offset: 0x000C3098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324948, XrefRangeEnd = 324949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x000C4EE0 File Offset: 0x000C30E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324949, XrefRangeEnd = 324953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x000C4F28 File Offset: 0x000C3128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x000C4F6C File Offset: 0x000C316C
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324953, XrefRangeEnd = 324959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x000C4FB0 File Offset: 0x000C31B0
		[CallerCount(0)]
		public unsafe virtual int Compare(string string1, string string2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(string1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(string2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x000C501C File Offset: 0x000C321C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324959, XrefRangeEnd = 324960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(string string1, string string2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(string1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(string2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_String_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x000C5094 File Offset: 0x000C3294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324960, XrefRangeEnd = 324964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(string1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(string2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x000C5148 File Offset: 0x000C3348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324964, XrefRangeEnd = 324965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinal(string string1, int offset1, int length1, string string2, int offset2, int length2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(string1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(string2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_CompareOrdinal_Private_Static_Int32_String_Int32_Int32_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x000C51D4 File Offset: 0x000C33D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324965, XrefRangeEnd = 324973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsPrefix(string source, string prefix, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_IsPrefix_Public_Virtual_New_Boolean_String_String_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x000C524C File Offset: 0x000C344C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324973, XrefRangeEnd = 324981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsSuffix(string source, string suffix, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(suffix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_IsSuffix_Public_Virtual_New_Boolean_String_String_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x000C52C4 File Offset: 0x000C34C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324981, XrefRangeEnd = 324982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x000C5358 File Offset: 0x000C3558
		[CallerCount(0)]
		public unsafe virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_LastIndexOf_Public_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x000C53EC File Offset: 0x000C35EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324982, XrefRangeEnd = 324994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SortKey GetSortKey(string source, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_GetSortKey_Public_Virtual_New_SortKey_String_CompareOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x000C5458 File Offset: 0x000C3658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324994, XrefRangeEnd = 325006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey CreateSortKey(string source, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_CreateSortKey_Private_SortKey_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x000C54B8 File Offset: 0x000C36B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325006, XrefRangeEnd = 325009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x000C5510 File Offset: 0x000C3710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325009, XrefRangeEnd = 325010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x000C5558 File Offset: 0x000C3758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325010, RefRangeEnd = 325011, XrefRangeStart = 325010, XrefRangeEnd = 325010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetHashCodeOfString(string source, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_GetHashCodeOfString_Internal_Int32_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x000C55B4 File Offset: 0x000C37B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325010, RefRangeEnd = 325011, XrefRangeStart = 325010, XrefRangeEnd = 325011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetHashCodeOfString(string source, CompareOptions options, bool forceRandomizedHashing, long additionalEntropy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceRandomizedHashing;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalEntropy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_GetHashCodeOfString_Internal_Int32_String_CompareOptions_Boolean_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x000C562C File Offset: 0x000C382C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325011, XrefRangeEnd = 325014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompareInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x0600247A RID: 9338 RVA: 0x000C5670 File Offset: 0x000C3870
		public unsafe static bool UseManagedCollation
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 325034, RefRangeEnd = 325041, XrefRangeStart = 325014, XrefRangeEnd = 325034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_get_UseManagedCollation_Private_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x000C56A0 File Offset: 0x000C38A0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 325079, RefRangeEnd = 325087, XrefRangeStart = 325041, XrefRangeEnd = 325079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleCollator GetCollator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_GetCollator_Private_SimpleCollator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SimpleCollator>(intPtr3) : null;
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x000C56E0 File Offset: 0x000C38E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325087, XrefRangeEnd = 325093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortKey CreateSortKeyCore(string source, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_CreateSortKeyCore_Private_SortKey_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SortKey>(intPtr3) : null;
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x000C5740 File Offset: 0x000C3940
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325096, RefRangeEnd = 325097, XrefRangeStart = 325093, XrefRangeEnd = 325096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sindex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_index_switch_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x000C57D8 File Offset: 0x000C39D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325102, RefRangeEnd = 325104, XrefRangeStart = 325097, XrefRangeEnd = 325102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_compare_switch_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x000C5880 File Offset: 0x000C3A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325104, XrefRangeEnd = 325107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_compare_managed_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x000C5928 File Offset: 0x000C3B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325107, XrefRangeEnd = 325111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sindex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opt;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_index_managed_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x000C59C0 File Offset: 0x000C3BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325111, XrefRangeEnd = 325112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void assign_sortkey(Object key, string source, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_assign_sortkey_Private_Void_Object_String_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x000C5A24 File Offset: 0x000C3C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325112, XrefRangeEnd = 325113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_compare_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x000C5ACC File Offset: 0x000C3CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325113, XrefRangeEnd = 325114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int internal_index(string source, int sindex, int count, string value, CompareOptions options, bool first)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sindex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr_internal_index_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x000C5B64 File Offset: 0x000C3D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325114, XrefRangeEnd = 325117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompareInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompareInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompareInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x0000C533 File Offset: 0x0000A733
		public CompareInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06002486 RID: 9350 RVA: 0x000C5BA0 File Offset: 0x000C3DA0
		// (set) Token: 0x06002487 RID: 9351 RVA: 0x0000C53C File Offset: 0x0000A73C
		public unsafe static CompareOptions ValidIndexMaskOffFlags
		{
			get
			{
				CompareOptions compareOptions;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_ValidIndexMaskOffFlags, (void*)(&compareOptions));
				return compareOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_ValidIndexMaskOffFlags, (void*)(&value));
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06002488 RID: 9352 RVA: 0x000C5BBC File Offset: 0x000C3DBC
		// (set) Token: 0x06002489 RID: 9353 RVA: 0x0000C54A File Offset: 0x0000A74A
		public unsafe static CompareOptions ValidCompareMaskOffFlags
		{
			get
			{
				CompareOptions compareOptions;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_ValidCompareMaskOffFlags, (void*)(&compareOptions));
				return compareOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_ValidCompareMaskOffFlags, (void*)(&value));
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x0600248A RID: 9354 RVA: 0x000C5BD8 File Offset: 0x000C3DD8
		// (set) Token: 0x0600248B RID: 9355 RVA: 0x0000C558 File Offset: 0x0000A758
		public unsafe static CompareOptions ValidHashCodeOfStringMaskOffFlags
		{
			get
			{
				CompareOptions compareOptions;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_ValidHashCodeOfStringMaskOffFlags, (void*)(&compareOptions));
				return compareOptions;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_ValidHashCodeOfStringMaskOffFlags, (void*)(&value));
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x0600248C RID: 9356 RVA: 0x000C5BF4 File Offset: 0x000C3DF4
		// (set) Token: 0x0600248D RID: 9357 RVA: 0x0000C566 File Offset: 0x0000A766
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x0600248E RID: 9358 RVA: 0x000C5C1C File Offset: 0x000C3E1C
		// (set) Token: 0x0600248F RID: 9359 RVA: 0x0000C585 File Offset: 0x0000A785
		public unsafe string m_sortName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_m_sortName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_m_sortName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06002490 RID: 9360 RVA: 0x000C5C44 File Offset: 0x000C3E44
		// (set) Token: 0x06002491 RID: 9361 RVA: 0x0000C5A4 File Offset: 0x0000A7A4
		public unsafe int win32LCID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_win32LCID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_win32LCID)) = value;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06002492 RID: 9362 RVA: 0x000C5C6C File Offset: 0x000C3E6C
		// (set) Token: 0x06002493 RID: 9363 RVA: 0x0000C5BF File Offset: 0x0000A7BF
		public unsafe int culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_culture);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_culture)) = value;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06002494 RID: 9364 RVA: 0x000C5C94 File Offset: 0x000C3E94
		// (set) Token: 0x06002495 RID: 9365 RVA: 0x0000C5DA File Offset: 0x0000A7DA
		public unsafe static int LINGUISTIC_IGNORECASE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_LINGUISTIC_IGNORECASE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_LINGUISTIC_IGNORECASE, (void*)(&value));
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06002496 RID: 9366 RVA: 0x000C5CB0 File Offset: 0x000C3EB0
		// (set) Token: 0x06002497 RID: 9367 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		public unsafe static int NORM_IGNORECASE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNORECASE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNORECASE, (void*)(&value));
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06002498 RID: 9368 RVA: 0x000C5CCC File Offset: 0x000C3ECC
		// (set) Token: 0x06002499 RID: 9369 RVA: 0x0000C5F6 File Offset: 0x0000A7F6
		public unsafe static int NORM_IGNOREKANATYPE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNOREKANATYPE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNOREKANATYPE, (void*)(&value));
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x0600249A RID: 9370 RVA: 0x000C5CE8 File Offset: 0x000C3EE8
		// (set) Token: 0x0600249B RID: 9371 RVA: 0x0000C604 File Offset: 0x0000A804
		public unsafe static int LINGUISTIC_IGNOREDIACRITIC
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_LINGUISTIC_IGNOREDIACRITIC, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_LINGUISTIC_IGNOREDIACRITIC, (void*)(&value));
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x0600249C RID: 9372 RVA: 0x000C5D04 File Offset: 0x000C3F04
		// (set) Token: 0x0600249D RID: 9373 RVA: 0x0000C612 File Offset: 0x0000A812
		public unsafe static int NORM_IGNORENONSPACE
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNORENONSPACE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNORENONSPACE, (void*)(&value));
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x0600249E RID: 9374 RVA: 0x000C5D20 File Offset: 0x000C3F20
		// (set) Token: 0x0600249F RID: 9375 RVA: 0x0000C620 File Offset: 0x0000A820
		public unsafe static int NORM_IGNORESYMBOLS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNORESYMBOLS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNORESYMBOLS, (void*)(&value));
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060024A0 RID: 9376 RVA: 0x000C5D3C File Offset: 0x000C3F3C
		// (set) Token: 0x060024A1 RID: 9377 RVA: 0x0000C62E File Offset: 0x0000A82E
		public unsafe static int NORM_IGNOREWIDTH
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNOREWIDTH, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_NORM_IGNOREWIDTH, (void*)(&value));
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060024A2 RID: 9378 RVA: 0x000C5D58 File Offset: 0x000C3F58
		// (set) Token: 0x060024A3 RID: 9379 RVA: 0x0000C63C File Offset: 0x0000A83C
		public unsafe static int SORT_STRINGSORT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_SORT_STRINGSORT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_SORT_STRINGSORT, (void*)(&value));
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060024A4 RID: 9380 RVA: 0x000C5D74 File Offset: 0x000C3F74
		// (set) Token: 0x060024A5 RID: 9381 RVA: 0x0000C64A File Offset: 0x0000A84A
		public unsafe static int COMPARE_OPTIONS_ORDINAL
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_COMPARE_OPTIONS_ORDINAL, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_COMPARE_OPTIONS_ORDINAL, (void*)(&value));
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060024A6 RID: 9382 RVA: 0x000C5D90 File Offset: 0x000C3F90
		// (set) Token: 0x060024A7 RID: 9383 RVA: 0x0000C658 File Offset: 0x0000A858
		public unsafe static int NORM_LINGUISTIC_CASING
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_NORM_LINGUISTIC_CASING, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_NORM_LINGUISTIC_CASING, (void*)(&value));
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x060024A8 RID: 9384 RVA: 0x000C5DAC File Offset: 0x000C3FAC
		// (set) Token: 0x060024A9 RID: 9385 RVA: 0x0000C666 File Offset: 0x0000A866
		public unsafe static int RESERVED_FIND_ASCII_STRING
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_RESERVED_FIND_ASCII_STRING, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_RESERVED_FIND_ASCII_STRING, (void*)(&value));
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060024AA RID: 9386 RVA: 0x000C5DC8 File Offset: 0x000C3FC8
		// (set) Token: 0x060024AB RID: 9387 RVA: 0x0000C674 File Offset: 0x0000A874
		public unsafe static int SORT_VERSION_WHIDBEY
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_SORT_VERSION_WHIDBEY, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_SORT_VERSION_WHIDBEY, (void*)(&value));
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x060024AC RID: 9388 RVA: 0x000C5DE4 File Offset: 0x000C3FE4
		// (set) Token: 0x060024AD RID: 9389 RVA: 0x0000C682 File Offset: 0x0000A882
		public unsafe static int SORT_VERSION_V4
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_SORT_VERSION_V4, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_SORT_VERSION_V4, (void*)(&value));
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060024AE RID: 9390 RVA: 0x000C5E00 File Offset: 0x000C4000
		// (set) Token: 0x060024AF RID: 9391 RVA: 0x0000C690 File Offset: 0x0000A890
		public unsafe SortVersion m_SortVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_m_SortVersion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortVersion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_m_SortVersion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060024B0 RID: 9392 RVA: 0x000C5E30 File Offset: 0x000C4030
		// (set) Token: 0x060024B1 RID: 9393 RVA: 0x0000C6AF File Offset: 0x0000A8AF
		public unsafe SimpleCollator collator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_collator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleCollator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompareInfo.NativeFieldInfoPtr_collator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060024B2 RID: 9394 RVA: 0x000C5E60 File Offset: 0x000C4060
		// (set) Token: 0x060024B3 RID: 9395 RVA: 0x0000C6CE File Offset: 0x0000A8CE
		public unsafe static Dictionary<string, SimpleCollator> collators
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_collators, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SimpleCollator>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_collators, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060024B4 RID: 9396 RVA: 0x000C5E88 File Offset: 0x000C4088
		// (set) Token: 0x060024B5 RID: 9397 RVA: 0x0000C6E0 File Offset: 0x0000A8E0
		public unsafe static bool managedCollation
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_managedCollation, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_managedCollation, (void*)(&value));
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x000C5EA4 File Offset: 0x000C40A4
		// (set) Token: 0x060024B7 RID: 9399 RVA: 0x0000C6EE File Offset: 0x0000A8EE
		public unsafe static bool managedCollationChecked
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(CompareInfo.NativeFieldInfoPtr_managedCollationChecked, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompareInfo.NativeFieldInfoPtr_managedCollationChecked, (void*)(&value));
			}
		}

		// Token: 0x04002080 RID: 8320
		private static readonly IntPtr NativeFieldInfoPtr_ValidIndexMaskOffFlags;

		// Token: 0x04002081 RID: 8321
		private static readonly IntPtr NativeFieldInfoPtr_ValidCompareMaskOffFlags;

		// Token: 0x04002082 RID: 8322
		private static readonly IntPtr NativeFieldInfoPtr_ValidHashCodeOfStringMaskOffFlags;

		// Token: 0x04002083 RID: 8323
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x04002084 RID: 8324
		private static readonly IntPtr NativeFieldInfoPtr_m_sortName;

		// Token: 0x04002085 RID: 8325
		private static readonly IntPtr NativeFieldInfoPtr_win32LCID;

		// Token: 0x04002086 RID: 8326
		private static readonly IntPtr NativeFieldInfoPtr_culture;

		// Token: 0x04002087 RID: 8327
		private static readonly IntPtr NativeFieldInfoPtr_LINGUISTIC_IGNORECASE;

		// Token: 0x04002088 RID: 8328
		private static readonly IntPtr NativeFieldInfoPtr_NORM_IGNORECASE;

		// Token: 0x04002089 RID: 8329
		private static readonly IntPtr NativeFieldInfoPtr_NORM_IGNOREKANATYPE;

		// Token: 0x0400208A RID: 8330
		private static readonly IntPtr NativeFieldInfoPtr_LINGUISTIC_IGNOREDIACRITIC;

		// Token: 0x0400208B RID: 8331
		private static readonly IntPtr NativeFieldInfoPtr_NORM_IGNORENONSPACE;

		// Token: 0x0400208C RID: 8332
		private static readonly IntPtr NativeFieldInfoPtr_NORM_IGNORESYMBOLS;

		// Token: 0x0400208D RID: 8333
		private static readonly IntPtr NativeFieldInfoPtr_NORM_IGNOREWIDTH;

		// Token: 0x0400208E RID: 8334
		private static readonly IntPtr NativeFieldInfoPtr_SORT_STRINGSORT;

		// Token: 0x0400208F RID: 8335
		private static readonly IntPtr NativeFieldInfoPtr_COMPARE_OPTIONS_ORDINAL;

		// Token: 0x04002090 RID: 8336
		private static readonly IntPtr NativeFieldInfoPtr_NORM_LINGUISTIC_CASING;

		// Token: 0x04002091 RID: 8337
		private static readonly IntPtr NativeFieldInfoPtr_RESERVED_FIND_ASCII_STRING;

		// Token: 0x04002092 RID: 8338
		private static readonly IntPtr NativeFieldInfoPtr_SORT_VERSION_WHIDBEY;

		// Token: 0x04002093 RID: 8339
		private static readonly IntPtr NativeFieldInfoPtr_SORT_VERSION_V4;

		// Token: 0x04002094 RID: 8340
		private static readonly IntPtr NativeFieldInfoPtr_m_SortVersion;

		// Token: 0x04002095 RID: 8341
		private static readonly IntPtr NativeFieldInfoPtr_collator;

		// Token: 0x04002096 RID: 8342
		private static readonly IntPtr NativeFieldInfoPtr_collators;

		// Token: 0x04002097 RID: 8343
		private static readonly IntPtr NativeFieldInfoPtr_managedCollation;

		// Token: 0x04002098 RID: 8344
		private static readonly IntPtr NativeFieldInfoPtr_managedCollationChecked;

		// Token: 0x04002099 RID: 8345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_0;

		// Token: 0x0400209A RID: 8346
		private static readonly IntPtr NativeMethodInfoPtr_GetCompareInfo_Public_Static_CompareInfo_String_0;

		// Token: 0x0400209B RID: 8347
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0;

		// Token: 0x0400209C RID: 8348
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_0;

		// Token: 0x0400209D RID: 8349
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x0400209E RID: 8350
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0;

		// Token: 0x0400209F RID: 8351
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x040020A0 RID: 8352
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x040020A1 RID: 8353
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_String_0;

		// Token: 0x040020A2 RID: 8354
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_String_CompareOptions_0;

		// Token: 0x040020A3 RID: 8355
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_New_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0;

		// Token: 0x040020A4 RID: 8356
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinal_Private_Static_Int32_String_Int32_Int32_String_Int32_Int32_0;

		// Token: 0x040020A5 RID: 8357
		private static readonly IntPtr NativeMethodInfoPtr_IsPrefix_Public_Virtual_New_Boolean_String_String_CompareOptions_0;

		// Token: 0x040020A6 RID: 8358
		private static readonly IntPtr NativeMethodInfoPtr_IsSuffix_Public_Virtual_New_Boolean_String_String_CompareOptions_0;

		// Token: 0x040020A7 RID: 8359
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x040020A8 RID: 8360
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Virtual_New_Int32_String_String_Int32_Int32_CompareOptions_0;

		// Token: 0x040020A9 RID: 8361
		private static readonly IntPtr NativeMethodInfoPtr_GetSortKey_Public_Virtual_New_SortKey_String_CompareOptions_0;

		// Token: 0x040020AA RID: 8362
		private static readonly IntPtr NativeMethodInfoPtr_CreateSortKey_Private_SortKey_String_CompareOptions_0;

		// Token: 0x040020AB RID: 8363
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040020AC RID: 8364
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040020AD RID: 8365
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeOfString_Internal_Int32_String_CompareOptions_0;

		// Token: 0x040020AE RID: 8366
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeOfString_Internal_Int32_String_CompareOptions_Boolean_Int64_0;

		// Token: 0x040020AF RID: 8367
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040020B0 RID: 8368
		private static readonly IntPtr NativeMethodInfoPtr_get_UseManagedCollation_Private_Static_get_Boolean_0;

		// Token: 0x040020B1 RID: 8369
		private static readonly IntPtr NativeMethodInfoPtr_GetCollator_Private_SimpleCollator_0;

		// Token: 0x040020B2 RID: 8370
		private static readonly IntPtr NativeMethodInfoPtr_CreateSortKeyCore_Private_SortKey_String_CompareOptions_0;

		// Token: 0x040020B3 RID: 8371
		private static readonly IntPtr NativeMethodInfoPtr_internal_index_switch_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0;

		// Token: 0x040020B4 RID: 8372
		private static readonly IntPtr NativeMethodInfoPtr_internal_compare_switch_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0;

		// Token: 0x040020B5 RID: 8373
		private static readonly IntPtr NativeMethodInfoPtr_internal_compare_managed_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0;

		// Token: 0x040020B6 RID: 8374
		private static readonly IntPtr NativeMethodInfoPtr_internal_index_managed_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0;

		// Token: 0x040020B7 RID: 8375
		private static readonly IntPtr NativeMethodInfoPtr_assign_sortkey_Private_Void_Object_String_CompareOptions_0;

		// Token: 0x040020B8 RID: 8376
		private static readonly IntPtr NativeMethodInfoPtr_internal_compare_Private_Int32_String_Int32_Int32_String_Int32_Int32_CompareOptions_0;

		// Token: 0x040020B9 RID: 8377
		private static readonly IntPtr NativeMethodInfoPtr_internal_index_Private_Int32_String_Int32_Int32_String_CompareOptions_Boolean_0;

		// Token: 0x040020BA RID: 8378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}

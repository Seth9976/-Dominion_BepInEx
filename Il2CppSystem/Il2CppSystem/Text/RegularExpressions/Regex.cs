using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000046 RID: 70
	[Serializable]
	public class Regex : Object
	{
		// Token: 0x060003EC RID: 1004 RVA: 0x000202C0 File Offset: 0x0001E4C0
		// Note: this type is marked as 'beforefieldinit'.
		static Regex()
		{
			Il2CppClassPointerStore<Regex>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "Regex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Regex>.NativeClassPtr);
			Regex.NativeFieldInfoPtr_pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "pattern");
			Regex.NativeFieldInfoPtr_factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "factory");
			Regex.NativeFieldInfoPtr_roptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "roptions");
			Regex.NativeFieldInfoPtr_MaximumMatchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "MaximumMatchTimeout");
			Regex.NativeFieldInfoPtr_InfiniteMatchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "InfiniteMatchTimeout");
			Regex.NativeFieldInfoPtr_internalMatchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "internalMatchTimeout");
			Regex.NativeFieldInfoPtr_DefaultMatchTimeout_ConfigKeyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "DefaultMatchTimeout_ConfigKeyName");
			Regex.NativeFieldInfoPtr_FallbackDefaultMatchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "FallbackDefaultMatchTimeout");
			Regex.NativeFieldInfoPtr_DefaultMatchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "DefaultMatchTimeout");
			Regex.NativeFieldInfoPtr_caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "caps");
			Regex.NativeFieldInfoPtr_capnames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "capnames");
			Regex.NativeFieldInfoPtr_capslist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "capslist");
			Regex.NativeFieldInfoPtr_capsize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "capsize");
			Regex.NativeFieldInfoPtr_runnerref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "runnerref");
			Regex.NativeFieldInfoPtr_replref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "replref");
			Regex.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "code");
			Regex.NativeFieldInfoPtr_refsInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "refsInitialized");
			Regex.NativeFieldInfoPtr_livecode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "livecode");
			Regex.NativeFieldInfoPtr_cacheSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "cacheSize");
			Regex.NativeFieldInfoPtr_MaxOptionShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Regex>.NativeClassPtr, "MaxOptionShift");
			Regex.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663907);
			Regex.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663908);
			Regex.NativeMethodInfoPtr__ctor_Public_Void_String_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663909);
			Regex.NativeMethodInfoPtr__ctor_Private_Void_String_RegexOptions_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663910);
			Regex.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663911);
			Regex.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663912);
			Regex.NativeMethodInfoPtr_ValidateMatchTimeout_FamOrAssem_Static_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663913);
			Regex.NativeMethodInfoPtr_InitDefaultMatchTimeout_Private_Static_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663914);
			Regex.NativeMethodInfoPtr_get_Options_Public_get_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663915);
			Regex.NativeMethodInfoPtr_get_MatchTimeout_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663916);
			Regex.NativeMethodInfoPtr_get_RightToLeft_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663917);
			Regex.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663918);
			Regex.NativeMethodInfoPtr_GroupNameFromNumber_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663919);
			Regex.NativeMethodInfoPtr_GroupNumberFromName_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663920);
			Regex.NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663921);
			Regex.NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663922);
			Regex.NativeMethodInfoPtr_IsMatch_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663923);
			Regex.NativeMethodInfoPtr_IsMatch_Public_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663924);
			Regex.NativeMethodInfoPtr_Match_Public_Static_Match_String_String_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663925);
			Regex.NativeMethodInfoPtr_Match_Public_Static_Match_String_String_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663926);
			Regex.NativeMethodInfoPtr_Match_Public_Match_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663927);
			Regex.NativeMethodInfoPtr_Match_Public_Match_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663928);
			Regex.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_MatchEvaluator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663929);
			Regex.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_MatchEvaluator_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663930);
			Regex.NativeMethodInfoPtr_Replace_Public_String_String_MatchEvaluator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663931);
			Regex.NativeMethodInfoPtr_Replace_Public_String_String_MatchEvaluator_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663932);
			Regex.NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663933);
			Regex.NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_RegexOptions_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663934);
			Regex.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663935);
			Regex.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663936);
			Regex.NativeMethodInfoPtr_InitializeReferences_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663937);
			Regex.NativeMethodInfoPtr_Run_Internal_Match_Boolean_Int32_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663938);
			Regex.NativeMethodInfoPtr_LookupCachedAndUpdate_Private_Static_CachedCodeEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663939);
			Regex.NativeMethodInfoPtr_CacheCode_Private_CachedCodeEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663940);
			Regex.NativeMethodInfoPtr_UseOptionR_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663941);
			Regex.NativeMethodInfoPtr_UseOptionInvariant_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Regex>.NativeClassPtr, 100663942);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00020750 File Offset: 0x0001E950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37177, XrefRangeEnd = 37182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Regex()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0002078C File Offset: 0x0001E98C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37187, RefRangeEnd = 37189, XrefRangeStart = 37182, XrefRangeEnd = 37187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Regex(string pattern)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000207D8 File Offset: 0x0001E9D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 37194, RefRangeEnd = 37197, XrefRangeStart = 37189, XrefRangeEnd = 37194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Regex(string pattern, RegexOptions options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr__ctor_Public_Void_String_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00020834 File Offset: 0x0001EA34
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 37229, RefRangeEnd = 37240, XrefRangeStart = 37197, XrefRangeEnd = 37229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Regex(string pattern, RegexOptions options, TimeSpan matchTimeout, bool useCache)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useCache;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr__ctor_Private_Void_String_RegexOptions_TimeSpan_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000208AC File Offset: 0x0001EAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37240, XrefRangeEnd = 37259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Regex(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Regex>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00020910 File Offset: 0x0001EB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37259, XrefRangeEnd = 37271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo si, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(si);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0002096C File Offset: 0x0001EB6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 37289, RefRangeEnd = 37293, XrefRangeStart = 37271, XrefRangeEnd = 37289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateMatchTimeout(TimeSpan matchTimeout)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref matchTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_ValidateMatchTimeout_FamOrAssem_Static_Void_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000209A0 File Offset: 0x0001EBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37293, XrefRangeEnd = 37304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan InitDefaultMatchTimeout()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_InitDefaultMatchTimeout_Private_Static_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x000209D0 File Offset: 0x0001EBD0
		public unsafe RegexOptions Options
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_get_Options_Public_get_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00020A0C File Offset: 0x0001EC0C
		public unsafe TimeSpan MatchTimeout
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_get_MatchTimeout_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00020A48 File Offset: 0x0001EC48
		public unsafe bool RightToLeft
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 37304, RefRangeEnd = 37308, XrefRangeStart = 37304, XrefRangeEnd = 37304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_get_RightToLeft_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00020A84 File Offset: 0x0001EC84
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Regex.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00020AC8 File Offset: 0x0001ECC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37315, RefRangeEnd = 37316, XrefRangeStart = 37308, XrefRangeEnd = 37315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GroupNameFromNumber(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_GroupNameFromNumber_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00020B0C File Offset: 0x0001ED0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37319, RefRangeEnd = 37320, XrefRangeStart = 37316, XrefRangeEnd = 37319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GroupNumberFromName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_GroupNumberFromName_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00020B5C File Offset: 0x0001ED5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37330, RefRangeEnd = 37331, XrefRangeStart = 37320, XrefRangeEnd = 37330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMatch(string input, string pattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00020BB0 File Offset: 0x0001EDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37331, XrefRangeEnd = 37337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00020C20 File Offset: 0x0001EE20
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 37339, RefRangeEnd = 37349, XrefRangeStart = 37337, XrefRangeEnd = 37339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatch(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_IsMatch_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00020C70 File Offset: 0x0001EE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37349, XrefRangeEnd = 37350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatch(string input, int startat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_IsMatch_Public_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00020CCC File Offset: 0x0001EECC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37360, RefRangeEnd = 37362, XrefRangeStart = 37350, XrefRangeEnd = 37360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Match Match(string input, string pattern, RegexOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Match_Public_Static_Match_String_String_RegexOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00020D30 File Offset: 0x0001EF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37362, XrefRangeEnd = 37368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Match Match(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Match_Public_Static_Match_String_String_RegexOptions_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00020DA4 File Offset: 0x0001EFA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37370, RefRangeEnd = 37372, XrefRangeStart = 37368, XrefRangeEnd = 37370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match Match(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Match_Public_Match_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00020DF4 File Offset: 0x0001EFF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37373, RefRangeEnd = 37375, XrefRangeStart = 37372, XrefRangeEnd = 37373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match Match(string input, int startat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Match_Public_Match_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00020E54 File Offset: 0x0001F054
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37385, RefRangeEnd = 37386, XrefRangeStart = 37375, XrefRangeEnd = 37385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Replace(string input, string pattern, MatchEvaluator evaluator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evaluator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_MatchEvaluator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00020EB4 File Offset: 0x0001F0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37386, XrefRangeEnd = 37399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Replace(string input, string pattern, MatchEvaluator evaluator, RegexOptions options, TimeSpan matchTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evaluator);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Replace_Public_Static_String_String_String_MatchEvaluator_RegexOptions_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00020F30 File Offset: 0x0001F130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37399, XrefRangeEnd = 37401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Replace(string input, MatchEvaluator evaluator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evaluator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Replace_Public_String_String_MatchEvaluator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00020F8C File Offset: 0x0001F18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37401, XrefRangeEnd = 37408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Replace(string input, MatchEvaluator evaluator, int count, int startat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evaluator);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Replace_Public_String_String_MatchEvaluator_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00021004 File Offset: 0x0001F204
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 37418, RefRangeEnd = 37423, XrefRangeStart = 37408, XrefRangeEnd = 37418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray Split(string input, string pattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0002105C File Offset: 0x0001F25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37423, XrefRangeEnd = 37436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray Split(string input, string pattern, RegexOptions options, TimeSpan matchTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_RegexOptions_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x000210D0 File Offset: 0x0001F2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37436, XrefRangeEnd = 37438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split(string input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00021120 File Offset: 0x0001F320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37438, XrefRangeEnd = 37445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split(string input, int count, int startat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0002118C File Offset: 0x0001F38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37445, XrefRangeEnd = 37453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeReferences()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_InitializeReferences_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x000211C0 File Offset: 0x0001F3C0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 37472, RefRangeEnd = 37481, XrefRangeStart = 37453, XrefRangeEnd = 37472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref quick;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevlen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(input);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginning;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_Run_Internal_Match_Boolean_Int32_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00021258 File Offset: 0x0001F458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37510, RefRangeEnd = 37511, XrefRangeStart = 37481, XrefRangeEnd = 37510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CachedCodeEntry LookupCachedAndUpdate(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_LookupCachedAndUpdate_Private_Static_CachedCodeEntry_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CachedCodeEntry>(intPtr3) : null;
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0002129C File Offset: 0x0001F49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37511, XrefRangeEnd = 37559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CachedCodeEntry CacheCode(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_CacheCode_Private_CachedCodeEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CachedCodeEntry>(intPtr3) : null;
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000212EC File Offset: 0x0001F4EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 37304, RefRangeEnd = 37308, XrefRangeStart = 37304, XrefRangeEnd = 37308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UseOptionR()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_UseOptionR_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00021328 File Offset: 0x0001F528
		[CallerCount(0)]
		public unsafe bool UseOptionInvariant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Regex.NativeMethodInfoPtr_UseOptionInvariant_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00003614 File Offset: 0x00001814
		public Regex(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00021364 File Offset: 0x0001F564
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x0000361D File Offset: 0x0000181D
		public unsafe string pattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_pattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_pattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x0002138C File Offset: 0x0001F58C
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x0000363C File Offset: 0x0000183C
		public unsafe RegexRunnerFactory factory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_factory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexRunnerFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_factory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x000213BC File Offset: 0x0001F5BC
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x0000365B File Offset: 0x0000185B
		public unsafe RegexOptions roptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_roptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_roptions)) = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x000213E4 File Offset: 0x0001F5E4
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00003676 File Offset: 0x00001876
		public unsafe static TimeSpan MaximumMatchTimeout
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_MaximumMatchTimeout, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_MaximumMatchTimeout, (void*)(&value));
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00021400 File Offset: 0x0001F600
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00003684 File Offset: 0x00001884
		public unsafe static TimeSpan InfiniteMatchTimeout
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_InfiniteMatchTimeout, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_InfiniteMatchTimeout, (void*)(&value));
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x0002141C File Offset: 0x0001F61C
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x00003692 File Offset: 0x00001892
		public unsafe TimeSpan internalMatchTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_internalMatchTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_internalMatchTimeout)) = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00021444 File Offset: 0x0001F644
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x000036AD File Offset: 0x000018AD
		public unsafe static string DefaultMatchTimeout_ConfigKeyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_DefaultMatchTimeout_ConfigKeyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_DefaultMatchTimeout_ConfigKeyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00021464 File Offset: 0x0001F664
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x000036BF File Offset: 0x000018BF
		public unsafe static TimeSpan FallbackDefaultMatchTimeout
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_FallbackDefaultMatchTimeout, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_FallbackDefaultMatchTimeout, (void*)(&value));
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00021480 File Offset: 0x0001F680
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x000036CD File Offset: 0x000018CD
		public unsafe static TimeSpan DefaultMatchTimeout
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_DefaultMatchTimeout, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_DefaultMatchTimeout, (void*)(&value));
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x0002149C File Offset: 0x0001F69C
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x000036DB File Offset: 0x000018DB
		public unsafe Hashtable caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x000214CC File Offset: 0x0001F6CC
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x000036FA File Offset: 0x000018FA
		public unsafe Hashtable capnames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_capnames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_capnames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x000214FC File Offset: 0x0001F6FC
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x00003719 File Offset: 0x00001919
		public unsafe Il2CppStringArray capslist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_capslist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_capslist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0002152C File Offset: 0x0001F72C
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x00003738 File Offset: 0x00001938
		public unsafe int capsize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_capsize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_capsize)) = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00021554 File Offset: 0x0001F754
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00003753 File Offset: 0x00001953
		public unsafe ExclusiveReference runnerref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_runnerref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExclusiveReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_runnerref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00021584 File Offset: 0x0001F784
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x00003772 File Offset: 0x00001972
		public unsafe SharedReference replref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_replref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SharedReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_replref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x000215B4 File Offset: 0x0001F7B4
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x00003791 File Offset: 0x00001991
		public unsafe RegexCode code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_code);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexCode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_code), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x000215E4 File Offset: 0x0001F7E4
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x000037B0 File Offset: 0x000019B0
		public unsafe bool refsInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_refsInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Regex.NativeFieldInfoPtr_refsInitialized)) = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0002160C File Offset: 0x0001F80C
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x000037CB File Offset: 0x000019CB
		public unsafe static LinkedList<CachedCodeEntry> livecode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_livecode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<CachedCodeEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_livecode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00021634 File Offset: 0x0001F834
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x000037DD File Offset: 0x000019DD
		public unsafe static int cacheSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_cacheSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_cacheSize, (void*)(&value));
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00021650 File Offset: 0x0001F850
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x000037EB File Offset: 0x000019EB
		public unsafe static int MaxOptionShift
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Regex.NativeFieldInfoPtr_MaxOptionShift, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Regex.NativeFieldInfoPtr_MaxOptionShift, (void*)(&value));
			}
		}

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeFieldInfoPtr_pattern;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeFieldInfoPtr_factory;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeFieldInfoPtr_roptions;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeFieldInfoPtr_MaximumMatchTimeout;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeFieldInfoPtr_InfiniteMatchTimeout;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeFieldInfoPtr_internalMatchTimeout;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeFieldInfoPtr_DefaultMatchTimeout_ConfigKeyName;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeFieldInfoPtr_FallbackDefaultMatchTimeout;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeFieldInfoPtr_DefaultMatchTimeout;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeFieldInfoPtr_caps;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeFieldInfoPtr_capnames;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeFieldInfoPtr_capslist;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeFieldInfoPtr_capsize;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeFieldInfoPtr_runnerref;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeFieldInfoPtr_replref;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeFieldInfoPtr_code;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeFieldInfoPtr_refsInitialized;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeFieldInfoPtr_livecode;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeFieldInfoPtr_cacheSize;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeFieldInfoPtr_MaxOptionShift;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_RegexOptions_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_RegexOptions_TimeSpan_Boolean_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_ValidateMatchTimeout_FamOrAssem_Static_Void_TimeSpan_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_InitDefaultMatchTimeout_Private_Static_TimeSpan_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_get_Options_Public_get_RegexOptions_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchTimeout_Public_get_TimeSpan_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_get_RightToLeft_Public_get_Boolean_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_GroupNameFromNumber_Public_String_Int32_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_GroupNumberFromName_Public_Int32_String_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Static_Boolean_String_String_RegexOptions_TimeSpan_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Boolean_String_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_IsMatch_Public_Boolean_String_Int32_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_Static_Match_String_String_RegexOptions_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_Static_Match_String_String_RegexOptions_TimeSpan_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_Match_String_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_Match_String_Int32_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_Static_String_String_String_MatchEvaluator_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_Static_String_String_String_MatchEvaluator_RegexOptions_TimeSpan_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_String_String_MatchEvaluator_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_String_String_MatchEvaluator_Int32_Int32_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Static_Il2CppStringArray_String_String_RegexOptions_TimeSpan_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_String_Int32_Int32_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_InitializeReferences_Protected_Void_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Match_Boolean_Int32_String_Int32_Int32_Int32_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_LookupCachedAndUpdate_Private_Static_CachedCodeEntry_String_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_CacheCode_Private_CachedCodeEntry_String_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionR_Protected_Boolean_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionInvariant_Internal_Boolean_0;
	}
}

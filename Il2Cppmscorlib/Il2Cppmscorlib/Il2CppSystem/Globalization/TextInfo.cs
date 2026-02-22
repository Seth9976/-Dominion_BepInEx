using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Text;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000242 RID: 578
	[Serializable]
	public class TextInfo : Object
	{
		// Token: 0x06002736 RID: 10038 RVA: 0x000CF05C File Offset: 0x000CD25C
		// Note: this type is marked as 'beforefieldinit'.
		static TextInfo()
		{
			Il2CppClassPointerStore<TextInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "TextInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextInfo>.NativeClassPtr);
			TextInfo.NativeFieldInfoPtr_m_listSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "m_listSeparator");
			TextInfo.NativeFieldInfoPtr_m_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "m_isReadOnly");
			TextInfo.NativeFieldInfoPtr_m_cultureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "m_cultureName");
			TextInfo.NativeFieldInfoPtr_m_cultureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "m_cultureData");
			TextInfo.NativeFieldInfoPtr_m_textInfoName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "m_textInfoName");
			TextInfo.NativeFieldInfoPtr_m_IsAsciiCasingSameAsInvariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "m_IsAsciiCasingSameAsInvariant");
			TextInfo.NativeFieldInfoPtr_s_Invariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "s_Invariant");
			TextInfo.NativeFieldInfoPtr_customCultureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "customCultureName");
			TextInfo.NativeFieldInfoPtr_m_nDataItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "m_nDataItem");
			TextInfo.NativeFieldInfoPtr_m_useUserOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "m_useUserOverride");
			TextInfo.NativeFieldInfoPtr_m_win32LangID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "m_win32LangID");
			TextInfo.NativeFieldInfoPtr_wordSeparatorMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "wordSeparatorMask");
			TextInfo.NativeMethodInfoPtr_get_Invariant_Internal_Static_get_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669640);
			TextInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669641);
			TextInfo.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669642);
			TextInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669643);
			TextInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669644);
			TextInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669645);
			TextInfo.NativeMethodInfoPtr_GetHashCodeOrdinalIgnoreCase_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669646);
			TextInfo.NativeMethodInfoPtr_GetHashCodeOrdinalIgnoreCase_Internal_Static_Int32_String_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669647);
			TextInfo.NativeMethodInfoPtr_CompareOrdinalIgnoreCase_Internal_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669648);
			TextInfo.NativeMethodInfoPtr_CompareOrdinalIgnoreCaseEx_Internal_Static_Int32_String_Int32_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669649);
			TextInfo.NativeMethodInfoPtr_IndexOfStringOrdinalIgnoreCase_Internal_Static_Int32_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669650);
			TextInfo.NativeMethodInfoPtr_LastIndexOfStringOrdinalIgnoreCase_Internal_Static_Int32_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669651);
			TextInfo.NativeMethodInfoPtr_get_CultureName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669652);
			TextInfo.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669653);
			TextInfo.NativeMethodInfoPtr_SetReadOnlyState_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669654);
			TextInfo.NativeMethodInfoPtr_ToLower_Public_Virtual_New_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669655);
			TextInfo.NativeMethodInfoPtr_ToLower_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669656);
			TextInfo.NativeMethodInfoPtr_ToLowerAsciiInvariant_Private_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669657);
			TextInfo.NativeMethodInfoPtr_ToUpper_Public_Virtual_New_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669658);
			TextInfo.NativeMethodInfoPtr_ToUpper_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669659);
			TextInfo.NativeMethodInfoPtr_ToUpperAsciiInvariant_Private_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669660);
			TextInfo.NativeMethodInfoPtr_IsAscii_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669661);
			TextInfo.NativeMethodInfoPtr_get_IsAsciiCasingSameAsInvariant_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669662);
			TextInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669663);
			TextInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669664);
			TextInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669665);
			TextInfo.NativeMethodInfoPtr_ToTitleCase_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669666);
			TextInfo.NativeMethodInfoPtr_AddNonLetter_Private_Static_Int32_byref_StringBuilder_byref_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669667);
			TextInfo.NativeMethodInfoPtr_AddTitlecaseLetter_Private_Int32_byref_StringBuilder_byref_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669668);
			TextInfo.NativeMethodInfoPtr_IsWordSeparator_Private_Static_Boolean_UnicodeCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669669);
			TextInfo.NativeMethodInfoPtr_IsLetterCategory_Private_Static_Boolean_UnicodeCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669670);
			TextInfo.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669671);
			TextInfo.NativeMethodInfoPtr_GetCaseInsensitiveHashCode_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669672);
			TextInfo.NativeMethodInfoPtr_GetCaseInsensitiveHashCode_Internal_Int32_String_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669673);
			TextInfo.NativeMethodInfoPtr_GetInvariantCaseInsensitiveHashCode_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669674);
			TextInfo.NativeMethodInfoPtr_ToUpperInternal_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669675);
			TextInfo.NativeMethodInfoPtr_ToLowerInternal_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669676);
			TextInfo.NativeMethodInfoPtr_ToUpperInternal_Private_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669677);
			TextInfo.NativeMethodInfoPtr_ToLowerInternal_Private_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669678);
			TextInfo.NativeMethodInfoPtr_InternalCompareStringOrdinalIgnoreCase_Private_Static_Int32_String_Int32_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669679);
			TextInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100669680);
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06002737 RID: 10039 RVA: 0x000CF4B0 File Offset: 0x000CD6B0
		public unsafe static TextInfo Invariant
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 327581, RefRangeEnd = 327582, XrefRangeStart = 327570, XrefRangeEnd = 327581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_get_Invariant_Internal_Static_get_TextInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x000CF4E4 File Offset: 0x000CD6E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 327583, RefRangeEnd = 327585, XrefRangeStart = 327582, XrefRangeEnd = 327583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextInfo(CultureData cultureData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cultureData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x000CF530 File Offset: 0x000CD730
		[CallerCount(0)]
		public unsafe void OnDeserializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x000CF578 File Offset: 0x000CD778
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 327593, RefRangeEnd = 327595, XrefRangeStart = 327585, XrefRangeEnd = 327593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x000CF5AC File Offset: 0x000CD7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327595, XrefRangeEnd = 327596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x000CF5F4 File Offset: 0x000CD7F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327596, XrefRangeEnd = 327600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x000CF63C File Offset: 0x000CD83C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327612, RefRangeEnd = 327613, XrefRangeStart = 327600, XrefRangeEnd = 327612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCodeOrdinalIgnoreCase(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_GetHashCodeOrdinalIgnoreCase_Internal_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x000CF680 File Offset: 0x000CD880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327613, XrefRangeEnd = 327625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCodeOrdinalIgnoreCase(string s, bool forceRandomizedHashing, long additionalEntropy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceRandomizedHashing;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalEntropy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_GetHashCodeOrdinalIgnoreCase_Internal_Static_Int32_String_Boolean_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x000CF6E0 File Offset: 0x000CD8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327625, XrefRangeEnd = 327626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinalIgnoreCase(string str1, string str2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_CompareOrdinalIgnoreCase_Internal_Static_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x000CF734 File Offset: 0x000CD934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327626, XrefRangeEnd = 327627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinalIgnoreCaseEx(string strA, int indexA, string strB, int indexB, int lengthA, int lengthB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexA;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lengthA;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lengthB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_CompareOrdinalIgnoreCaseEx_Internal_Static_Int32_String_Int32_String_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x000CF7C0 File Offset: 0x000CD9C0
		[CallerCount(0)]
		public unsafe static int IndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_IndexOfStringOrdinalIgnoreCase_Internal_Static_Int32_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x000CF830 File Offset: 0x000CDA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327627, XrefRangeEnd = 327628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int LastIndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_LastIndexOfStringOrdinalIgnoreCase_Internal_Static_Int32_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06002743 RID: 10051 RVA: 0x000CF8A0 File Offset: 0x000CDAA0
		public unsafe string CultureName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_get_CultureName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x000CF8D8 File Offset: 0x000CDAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327628, XrefRangeEnd = 327631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInfo.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x000CF924 File Offset: 0x000CDB24
		[CallerCount(0)]
		public unsafe void SetReadOnlyState(bool readOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref readOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_SetReadOnlyState_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x000CF964 File Offset: 0x000CDB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327631, XrefRangeEnd = 327632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual char ToLower(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInfo.NativeMethodInfoPtr_ToLower_Public_Virtual_New_Char_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x000CF9B8 File Offset: 0x000CDBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327632, XrefRangeEnd = 327637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToLower(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInfo.NativeMethodInfoPtr_ToLower_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x000CFA0C File Offset: 0x000CDC0C
		[CallerCount(0)]
		public unsafe static char ToLowerAsciiInvariant(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_ToLowerAsciiInvariant_Private_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x000CFA4C File Offset: 0x000CDC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327637, XrefRangeEnd = 327638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual char ToUpper(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInfo.NativeMethodInfoPtr_ToUpper_Public_Virtual_New_Char_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x000CFAA0 File Offset: 0x000CDCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327638, XrefRangeEnd = 327643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToUpper(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInfo.NativeMethodInfoPtr_ToUpper_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x000CFAF4 File Offset: 0x000CDCF4
		[CallerCount(0)]
		public unsafe static char ToUpperAsciiInvariant(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_ToUpperAsciiInvariant_Private_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x000CFB34 File Offset: 0x000CDD34
		[CallerCount(0)]
		public unsafe static bool IsAscii(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_IsAscii_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x0600274D RID: 10061 RVA: 0x000CFB74 File Offset: 0x000CDD74
		public unsafe bool IsAsciiCasingSameAsInvariant
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 327660, RefRangeEnd = 327662, XrefRangeStart = 327643, XrefRangeEnd = 327660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_get_IsAsciiCasingSameAsInvariant_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x000CFBB0 File Offset: 0x000CDDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327662, XrefRangeEnd = 327665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x000CFC08 File Offset: 0x000CDE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327665, XrefRangeEnd = 327666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x000CFC50 File Offset: 0x000CDE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327666, XrefRangeEnd = 327670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x000CFC94 File Offset: 0x000CDE94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327708, RefRangeEnd = 327709, XrefRangeStart = 327670, XrefRangeEnd = 327708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToTitleCase(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_ToTitleCase_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x000CFCDC File Offset: 0x000CDEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327709, XrefRangeEnd = 327713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AddNonLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(result);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.ManagedStringToIl2Cpp(input);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charLen;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_AddNonLetter_Private_Static_Int32_byref_StringBuilder_byref_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			result = ((intPtr5 == 0) ? null : new StringBuilder(intPtr5));
			input = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x000CFD74 File Offset: 0x000CDF74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327727, RefRangeEnd = 327728, XrefRangeStart = 327713, XrefRangeEnd = 327727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddTitlecaseLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(result);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.ManagedStringToIl2Cpp(input);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charLen;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_AddTitlecaseLetter_Private_Int32_byref_StringBuilder_byref_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			result = ((intPtr5 == 0) ? null : new StringBuilder(intPtr5));
			input = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x000CFE18 File Offset: 0x000CE018
		[CallerCount(0)]
		public unsafe static bool IsWordSeparator(UnicodeCategory category)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref category;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_IsWordSeparator_Private_Static_Boolean_UnicodeCategory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x000CFE58 File Offset: 0x000CE058
		[CallerCount(0)]
		public unsafe static bool IsLetterCategory(UnicodeCategory uc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_IsLetterCategory_Private_Static_Boolean_UnicodeCategory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x000CFE98 File Offset: 0x000CE098
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x000CFEDC File Offset: 0x000CE0DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327729, RefRangeEnd = 327730, XrefRangeStart = 327728, XrefRangeEnd = 327729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCaseInsensitiveHashCode(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_GetCaseInsensitiveHashCode_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x000CFF2C File Offset: 0x000CE12C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 327743, RefRangeEnd = 327746, XrefRangeStart = 327730, XrefRangeEnd = 327743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCaseInsensitiveHashCode(string str, bool forceRandomizedHashing, long additionalEntropy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceRandomizedHashing;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalEntropy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_GetCaseInsensitiveHashCode_Internal_Int32_String_Boolean_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x000CFF98 File Offset: 0x000CE198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327746, XrefRangeEnd = 327755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInvariantCaseInsensitiveHashCode(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_GetInvariantCaseInsensitiveHashCode_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x000CFFE8 File Offset: 0x000CE1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327755, XrefRangeEnd = 327760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToUpperInternal(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_ToUpperInternal_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x000D0030 File Offset: 0x000CE230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327760, XrefRangeEnd = 327765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToLowerInternal(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_ToLowerInternal_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x000D0078 File Offset: 0x000CE278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327765, XrefRangeEnd = 327767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ToUpperInternal(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_ToUpperInternal_Private_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x000D00C4 File Offset: 0x000CE2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327767, XrefRangeEnd = 327769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ToLowerInternal(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_ToLowerInternal_Private_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x000D0110 File Offset: 0x000CE310
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 327775, RefRangeEnd = 327778, XrefRangeStart = 327769, XrefRangeEnd = 327775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InternalCompareStringOrdinalIgnoreCase(string strA, int indexA, string strB, int indexB, int lenA, int lenB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexA;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lenA;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lenB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr_InternalCompareStringOrdinalIgnoreCase_Private_Static_Int32_String_Int32_String_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x000D019C File Offset: 0x000CE39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327778, XrefRangeEnd = 327781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x0000D815 File Offset: 0x0000BA15
		public TextInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06002761 RID: 10081 RVA: 0x000D01D8 File Offset: 0x000CE3D8
		// (set) Token: 0x06002762 RID: 10082 RVA: 0x0000D81E File Offset: 0x0000BA1E
		public unsafe string m_listSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_listSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_listSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06002763 RID: 10083 RVA: 0x000D0200 File Offset: 0x000CE400
		// (set) Token: 0x06002764 RID: 10084 RVA: 0x0000D83D File Offset: 0x0000BA3D
		public unsafe bool m_isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_isReadOnly)) = value;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06002765 RID: 10085 RVA: 0x000D0228 File Offset: 0x000CE428
		// (set) Token: 0x06002766 RID: 10086 RVA: 0x0000D858 File Offset: 0x0000BA58
		public unsafe string m_cultureName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_cultureName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_cultureName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06002767 RID: 10087 RVA: 0x000D0250 File Offset: 0x000CE450
		// (set) Token: 0x06002768 RID: 10088 RVA: 0x0000D877 File Offset: 0x0000BA77
		public unsafe CultureData m_cultureData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_cultureData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_cultureData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06002769 RID: 10089 RVA: 0x000D0280 File Offset: 0x000CE480
		// (set) Token: 0x0600276A RID: 10090 RVA: 0x0000D896 File Offset: 0x0000BA96
		public unsafe string m_textInfoName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_textInfoName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_textInfoName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x0600276B RID: 10091 RVA: 0x000D02A8 File Offset: 0x000CE4A8
		// (set) Token: 0x0600276C RID: 10092 RVA: 0x0000D8B5 File Offset: 0x0000BAB5
		public Nullable<bool> m_IsAsciiCasingSameAsInvariant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_IsAsciiCasingSameAsInvariant);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_IsAsciiCasingSameAsInvariant), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x0600276D RID: 10093 RVA: 0x000D02D8 File Offset: 0x000CE4D8
		// (set) Token: 0x0600276E RID: 10094 RVA: 0x0000D8E3 File Offset: 0x0000BAE3
		public unsafe static TextInfo s_Invariant
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextInfo.NativeFieldInfoPtr_s_Invariant, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextInfo.NativeFieldInfoPtr_s_Invariant, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x0600276F RID: 10095 RVA: 0x000D0300 File Offset: 0x000CE500
		// (set) Token: 0x06002770 RID: 10096 RVA: 0x0000D8F5 File Offset: 0x0000BAF5
		public unsafe string customCultureName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_customCultureName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_customCultureName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06002771 RID: 10097 RVA: 0x000D0328 File Offset: 0x000CE528
		// (set) Token: 0x06002772 RID: 10098 RVA: 0x0000D914 File Offset: 0x0000BB14
		public unsafe int m_nDataItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_nDataItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_nDataItem)) = value;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06002773 RID: 10099 RVA: 0x000D0350 File Offset: 0x000CE550
		// (set) Token: 0x06002774 RID: 10100 RVA: 0x0000D92F File Offset: 0x0000BB2F
		public unsafe bool m_useUserOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_useUserOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_useUserOverride)) = value;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06002775 RID: 10101 RVA: 0x000D0378 File Offset: 0x000CE578
		// (set) Token: 0x06002776 RID: 10102 RVA: 0x0000D94A File Offset: 0x0000BB4A
		public unsafe int m_win32LangID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_win32LangID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInfo.NativeFieldInfoPtr_m_win32LangID)) = value;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06002777 RID: 10103 RVA: 0x000D03A0 File Offset: 0x000CE5A0
		// (set) Token: 0x06002778 RID: 10104 RVA: 0x0000D965 File Offset: 0x0000BB65
		public unsafe static int wordSeparatorMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextInfo.NativeFieldInfoPtr_wordSeparatorMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextInfo.NativeFieldInfoPtr_wordSeparatorMask, (void*)(&value));
			}
		}

		// Token: 0x040022DB RID: 8923
		private static readonly IntPtr NativeFieldInfoPtr_m_listSeparator;

		// Token: 0x040022DC RID: 8924
		private static readonly IntPtr NativeFieldInfoPtr_m_isReadOnly;

		// Token: 0x040022DD RID: 8925
		private static readonly IntPtr NativeFieldInfoPtr_m_cultureName;

		// Token: 0x040022DE RID: 8926
		private static readonly IntPtr NativeFieldInfoPtr_m_cultureData;

		// Token: 0x040022DF RID: 8927
		private static readonly IntPtr NativeFieldInfoPtr_m_textInfoName;

		// Token: 0x040022E0 RID: 8928
		private static readonly IntPtr NativeFieldInfoPtr_m_IsAsciiCasingSameAsInvariant;

		// Token: 0x040022E1 RID: 8929
		private static readonly IntPtr NativeFieldInfoPtr_s_Invariant;

		// Token: 0x040022E2 RID: 8930
		private static readonly IntPtr NativeFieldInfoPtr_customCultureName;

		// Token: 0x040022E3 RID: 8931
		private static readonly IntPtr NativeFieldInfoPtr_m_nDataItem;

		// Token: 0x040022E4 RID: 8932
		private static readonly IntPtr NativeFieldInfoPtr_m_useUserOverride;

		// Token: 0x040022E5 RID: 8933
		private static readonly IntPtr NativeFieldInfoPtr_m_win32LangID;

		// Token: 0x040022E6 RID: 8934
		private static readonly IntPtr NativeFieldInfoPtr_wordSeparatorMask;

		// Token: 0x040022E7 RID: 8935
		private static readonly IntPtr NativeMethodInfoPtr_get_Invariant_Internal_Static_get_TextInfo_0;

		// Token: 0x040022E8 RID: 8936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CultureData_0;

		// Token: 0x040022E9 RID: 8937
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0;

		// Token: 0x040022EA RID: 8938
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_0;

		// Token: 0x040022EB RID: 8939
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x040022EC RID: 8940
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0;

		// Token: 0x040022ED RID: 8941
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeOrdinalIgnoreCase_Internal_Static_Int32_String_0;

		// Token: 0x040022EE RID: 8942
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCodeOrdinalIgnoreCase_Internal_Static_Int32_String_Boolean_Int64_0;

		// Token: 0x040022EF RID: 8943
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinalIgnoreCase_Internal_Static_Int32_String_String_0;

		// Token: 0x040022F0 RID: 8944
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinalIgnoreCaseEx_Internal_Static_Int32_String_Int32_String_Int32_Int32_Int32_0;

		// Token: 0x040022F1 RID: 8945
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfStringOrdinalIgnoreCase_Internal_Static_Int32_String_String_Int32_Int32_0;

		// Token: 0x040022F2 RID: 8946
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfStringOrdinalIgnoreCase_Internal_Static_Int32_String_String_Int32_Int32_0;

		// Token: 0x040022F3 RID: 8947
		private static readonly IntPtr NativeMethodInfoPtr_get_CultureName_Public_get_String_0;

		// Token: 0x040022F4 RID: 8948
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x040022F5 RID: 8949
		private static readonly IntPtr NativeMethodInfoPtr_SetReadOnlyState_Internal_Void_Boolean_0;

		// Token: 0x040022F6 RID: 8950
		private static readonly IntPtr NativeMethodInfoPtr_ToLower_Public_Virtual_New_Char_Char_0;

		// Token: 0x040022F7 RID: 8951
		private static readonly IntPtr NativeMethodInfoPtr_ToLower_Public_Virtual_New_String_String_0;

		// Token: 0x040022F8 RID: 8952
		private static readonly IntPtr NativeMethodInfoPtr_ToLowerAsciiInvariant_Private_Static_Char_Char_0;

		// Token: 0x040022F9 RID: 8953
		private static readonly IntPtr NativeMethodInfoPtr_ToUpper_Public_Virtual_New_Char_Char_0;

		// Token: 0x040022FA RID: 8954
		private static readonly IntPtr NativeMethodInfoPtr_ToUpper_Public_Virtual_New_String_String_0;

		// Token: 0x040022FB RID: 8955
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperAsciiInvariant_Private_Static_Char_Char_0;

		// Token: 0x040022FC RID: 8956
		private static readonly IntPtr NativeMethodInfoPtr_IsAscii_Private_Static_Boolean_Char_0;

		// Token: 0x040022FD RID: 8957
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAsciiCasingSameAsInvariant_Private_get_Boolean_0;

		// Token: 0x040022FE RID: 8958
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040022FF RID: 8959
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002300 RID: 8960
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002301 RID: 8961
		private static readonly IntPtr NativeMethodInfoPtr_ToTitleCase_Public_String_String_0;

		// Token: 0x04002302 RID: 8962
		private static readonly IntPtr NativeMethodInfoPtr_AddNonLetter_Private_Static_Int32_byref_StringBuilder_byref_String_Int32_Int32_0;

		// Token: 0x04002303 RID: 8963
		private static readonly IntPtr NativeMethodInfoPtr_AddTitlecaseLetter_Private_Int32_byref_StringBuilder_byref_String_Int32_Int32_0;

		// Token: 0x04002304 RID: 8964
		private static readonly IntPtr NativeMethodInfoPtr_IsWordSeparator_Private_Static_Boolean_UnicodeCategory_0;

		// Token: 0x04002305 RID: 8965
		private static readonly IntPtr NativeMethodInfoPtr_IsLetterCategory_Private_Static_Boolean_UnicodeCategory_0;

		// Token: 0x04002306 RID: 8966
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04002307 RID: 8967
		private static readonly IntPtr NativeMethodInfoPtr_GetCaseInsensitiveHashCode_Internal_Int32_String_0;

		// Token: 0x04002308 RID: 8968
		private static readonly IntPtr NativeMethodInfoPtr_GetCaseInsensitiveHashCode_Internal_Int32_String_Boolean_Int64_0;

		// Token: 0x04002309 RID: 8969
		private static readonly IntPtr NativeMethodInfoPtr_GetInvariantCaseInsensitiveHashCode_Private_Int32_String_0;

		// Token: 0x0400230A RID: 8970
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperInternal_Private_String_String_0;

		// Token: 0x0400230B RID: 8971
		private static readonly IntPtr NativeMethodInfoPtr_ToLowerInternal_Private_String_String_0;

		// Token: 0x0400230C RID: 8972
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperInternal_Private_Char_Char_0;

		// Token: 0x0400230D RID: 8973
		private static readonly IntPtr NativeMethodInfoPtr_ToLowerInternal_Private_Char_Char_0;

		// Token: 0x0400230E RID: 8974
		private static readonly IntPtr NativeMethodInfoPtr_InternalCompareStringOrdinalIgnoreCase_Private_Static_Int32_String_Int32_String_Int32_Int32_Int32_0;

		// Token: 0x0400230F RID: 8975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}

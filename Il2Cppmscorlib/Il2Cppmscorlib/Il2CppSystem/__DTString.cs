using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem
{
	// Token: 0x020000AB RID: 171
	public sealed class __DTString : ValueType
	{
		// Token: 0x06000C39 RID: 3129 RVA: 0x00059F50 File Offset: 0x00058150
		// Note: this type is marked as 'beforefieldinit'.
		static __DTString()
		{
			Il2CppClassPointerStore<__DTString>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "__DTString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__DTString>.NativeClassPtr);
			__DTString.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "Value");
			__DTString.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "Index");
			__DTString.NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "len");
			__DTString.NativeFieldInfoPtr_m_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "m_current");
			__DTString.NativeFieldInfoPtr_m_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "m_info");
			__DTString.NativeFieldInfoPtr_m_checkDigitToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "m_checkDigitToken");
			__DTString.NativeFieldInfoPtr_WhiteSpaceChecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__DTString>.NativeClassPtr, "WhiteSpaceChecks");
			__DTString.NativeMethodInfoPtr__ctor_Internal_Void_String_DateTimeFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665376);
			__DTString.NativeMethodInfoPtr__ctor_Internal_Void_String_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665377);
			__DTString.NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665378);
			__DTString.NativeMethodInfoPtr_GetNext_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665379);
			__DTString.NativeMethodInfoPtr_AtEnd_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665380);
			__DTString.NativeMethodInfoPtr_Advance_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665381);
			__DTString.NativeMethodInfoPtr_GetRegularToken_Internal_Void_byref_TokenType_byref_Int32_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665382);
			__DTString.NativeMethodInfoPtr_GetSeparatorToken_Internal_TokenType_DateTimeFormatInfo_byref_Int32_byref_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665383);
			__DTString.NativeMethodInfoPtr_MatchSpecifiedWord_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665384);
			__DTString.NativeMethodInfoPtr_MatchSpecifiedWord_Internal_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665385);
			__DTString.NativeMethodInfoPtr_MatchSpecifiedWords_Internal_Boolean_String_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665386);
			__DTString.NativeMethodInfoPtr_Match_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665387);
			__DTString.NativeMethodInfoPtr_Match_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665388);
			__DTString.NativeMethodInfoPtr_MatchLongestWords_Internal_Int32_Il2CppStringArray_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665389);
			__DTString.NativeMethodInfoPtr_GetRepeatCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665390);
			__DTString.NativeMethodInfoPtr_GetNextDigit_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665391);
			__DTString.NativeMethodInfoPtr_GetChar_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665392);
			__DTString.NativeMethodInfoPtr_GetDigit_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665393);
			__DTString.NativeMethodInfoPtr_SkipWhiteSpaces_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665394);
			__DTString.NativeMethodInfoPtr_SkipWhiteSpaceCurrent_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665395);
			__DTString.NativeMethodInfoPtr_TrimTail_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665396);
			__DTString.NativeMethodInfoPtr_RemoveTrailingInQuoteSpaces_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665397);
			__DTString.NativeMethodInfoPtr_RemoveLeadingInQuoteSpaces_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665398);
			__DTString.NativeMethodInfoPtr_GetSubString_Internal_DTSubString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665399);
			__DTString.NativeMethodInfoPtr_ConsumeSubString_Internal_Void_DTSubString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__DTString>.NativeClassPtr, 100665400);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0005A200 File Offset: 0x00058400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285430, XrefRangeEnd = 285435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __DTString(string str, DateTimeFormatInfo dtfi, bool checkDigitToken)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__DTString>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkDigitToken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr__ctor_Internal_Void_String_DateTimeFormatInfo_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0005A270 File Offset: 0x00058470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285437, RefRangeEnd = 285438, XrefRangeStart = 285435, XrefRangeEnd = 285437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __DTString(string str, DateTimeFormatInfo dtfi)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__DTString>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr__ctor_Internal_Void_String_DateTimeFormatInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x0005A2D4 File Offset: 0x000584D4
		public unsafe CompareInfo CompareInfo
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0005A318 File Offset: 0x00058518
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 285438, RefRangeEnd = 285455, XrefRangeStart = 285438, XrefRangeEnd = 285438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetNext_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0005A35C File Offset: 0x0005855C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285455, RefRangeEnd = 285456, XrefRangeStart = 285455, XrefRangeEnd = 285455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AtEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_AtEnd_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0005A3A0 File Offset: 0x000585A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285456, RefRangeEnd = 285459, XrefRangeStart = 285456, XrefRangeEnd = 285456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Advance(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_Advance_Internal_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0005A3F0 File Offset: 0x000585F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285480, RefRangeEnd = 285481, XrefRangeStart = 285459, XrefRangeEnd = 285480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRegularToken(out TokenType tokenType, out int tokenValue, DateTimeFormatInfo dtfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &tokenType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tokenValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetRegularToken_Internal_Void_byref_TokenType_byref_Int32_DateTimeFormatInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0005A454 File Offset: 0x00058654
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 285486, RefRangeEnd = 285491, XrefRangeStart = 285481, XrefRangeEnd = 285486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenType GetSeparatorToken(DateTimeFormatInfo dtfi, out int indexBeforeSeparator, out char charBeforeSeparator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &indexBeforeSeparator;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charBeforeSeparator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetSeparatorToken_Internal_TokenType_DateTimeFormatInfo_byref_Int32_byref_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0005A4C4 File Offset: 0x000586C4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 285491, RefRangeEnd = 285500, XrefRangeStart = 285491, XrefRangeEnd = 285491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchSpecifiedWord(string target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_MatchSpecifiedWord_Internal_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x0005A518 File Offset: 0x00058718
		[CallerCount(0)]
		public unsafe bool MatchSpecifiedWord(string target, int endIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_MatchSpecifiedWord_Internal_Boolean_String_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x0005A578 File Offset: 0x00058778
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 285524, RefRangeEnd = 285530, XrefRangeStart = 285500, XrefRangeEnd = 285524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchSpecifiedWords(string target, bool checkWordBoundary, ref int matchLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkWordBoundary;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &matchLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_MatchSpecifiedWords_Internal_Boolean_String_Boolean_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0005A5E8 File Offset: 0x000587E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285530, RefRangeEnd = 285531, XrefRangeStart = 285530, XrefRangeEnd = 285530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Match(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_Match_Internal_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0005A63C File Offset: 0x0005883C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 285532, RefRangeEnd = 285537, XrefRangeStart = 285531, XrefRangeEnd = 285532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Match(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_Match_Internal_Boolean_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0005A68C File Offset: 0x0005888C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285539, RefRangeEnd = 285542, XrefRangeStart = 285537, XrefRangeEnd = 285539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MatchLongestWords(Il2CppStringArray words, ref int maxMatchStrLen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(words);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maxMatchStrLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_MatchLongestWords_Internal_Int32_Il2CppStringArray_byref_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0005A6EC File Offset: 0x000588EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 285544, RefRangeEnd = 285547, XrefRangeStart = 285542, XrefRangeEnd = 285544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRepeatCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetRepeatCount_Internal_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0005A730 File Offset: 0x00058930
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 285552, RefRangeEnd = 285563, XrefRangeStart = 285547, XrefRangeEnd = 285552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNextDigit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetNextDigit_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0005A774 File Offset: 0x00058974
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 285565, RefRangeEnd = 285574, XrefRangeStart = 285563, XrefRangeEnd = 285565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char GetChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetChar_Internal_Char_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x0005A7B8 File Offset: 0x000589B8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 285575, RefRangeEnd = 285586, XrefRangeStart = 285574, XrefRangeEnd = 285575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDigit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetDigit_Internal_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0005A7FC File Offset: 0x000589FC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 285591, RefRangeEnd = 285599, XrefRangeStart = 285586, XrefRangeEnd = 285591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipWhiteSpaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_SkipWhiteSpaces_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0005A834 File Offset: 0x00058A34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285607, RefRangeEnd = 285608, XrefRangeStart = 285599, XrefRangeEnd = 285607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SkipWhiteSpaceCurrent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_SkipWhiteSpaceCurrent_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0005A878 File Offset: 0x00058A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285608, XrefRangeEnd = 285614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrimTail()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_TrimTail_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0005A8B0 File Offset: 0x00058AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285614, XrefRangeEnd = 285625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrailingInQuoteSpaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_RemoveTrailingInQuoteSpaces_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0005A8E8 File Offset: 0x00058AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285625, XrefRangeEnd = 285632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLeadingInQuoteSpaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_RemoveLeadingInQuoteSpaces_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x0005A920 File Offset: 0x00058B20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 285633, RefRangeEnd = 285637, XrefRangeStart = 285632, XrefRangeEnd = 285633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DTSubString GetSubString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_GetSubString_Internal_DTSubString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new DTSubString(intPtr);
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x0005A95C File Offset: 0x00058B5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 285638, RefRangeEnd = 285642, XrefRangeStart = 285637, XrefRangeEnd = 285638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeSubString(DTSubString sub)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sub));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__DTString.NativeMethodInfoPtr_ConsumeSubString_Internal_Void_DTSubString_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x0000517B File Offset: 0x0000337B
		public __DTString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00005184 File Offset: 0x00003384
		public __DTString()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__DTString>.NativeClassPtr))
		{
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x0005A9A8 File Offset: 0x00058BA8
		// (set) Token: 0x06000C56 RID: 3158 RVA: 0x00005196 File Offset: 0x00003396
		public unsafe string Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_Value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_Value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x0005A9D0 File Offset: 0x00058BD0
		// (set) Token: 0x06000C58 RID: 3160 RVA: 0x000051B5 File Offset: 0x000033B5
		public unsafe int Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_Index)) = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x0005A9F8 File Offset: 0x00058BF8
		// (set) Token: 0x06000C5A RID: 3162 RVA: 0x000051D0 File Offset: 0x000033D0
		public unsafe int len
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_len);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_len)) = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x0005AA20 File Offset: 0x00058C20
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x000051EB File Offset: 0x000033EB
		public unsafe char m_current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_m_current);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_m_current)) = value;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x0005AA48 File Offset: 0x00058C48
		// (set) Token: 0x06000C5E RID: 3166 RVA: 0x00005206 File Offset: 0x00003406
		public unsafe CompareInfo m_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_m_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_m_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x0005AA78 File Offset: 0x00058C78
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x00005225 File Offset: 0x00003425
		public unsafe bool m_checkDigitToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_m_checkDigitToken);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__DTString.NativeFieldInfoPtr_m_checkDigitToken)) = value;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x0005AAA0 File Offset: 0x00058CA0
		// (set) Token: 0x06000C62 RID: 3170 RVA: 0x00005240 File Offset: 0x00003440
		public unsafe static Il2CppStructArray<char> WhiteSpaceChecks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(__DTString.NativeFieldInfoPtr_WhiteSpaceChecks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(__DTString.NativeFieldInfoPtr_WhiteSpaceChecks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeFieldInfoPtr_Index;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeFieldInfoPtr_len;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeFieldInfoPtr_m_current;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeFieldInfoPtr_m_info;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeFieldInfoPtr_m_checkDigitToken;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeFieldInfoPtr_WhiteSpaceChecks;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_DateTimeFormatInfo_Boolean_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_DateTimeFormatInfo_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_get_CompareInfo_Internal_get_CompareInfo_0;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_GetNext_Internal_Boolean_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_AtEnd_Internal_Boolean_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_Advance_Internal_Boolean_Int32_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr_GetRegularToken_Internal_Void_byref_TokenType_byref_Int32_DateTimeFormatInfo_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr_GetSeparatorToken_Internal_TokenType_DateTimeFormatInfo_byref_Int32_byref_Char_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr_MatchSpecifiedWord_Internal_Boolean_String_0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_MatchSpecifiedWord_Internal_Boolean_String_Int32_0;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeMethodInfoPtr_MatchSpecifiedWords_Internal_Boolean_String_Boolean_byref_Int32_0;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeMethodInfoPtr_Match_Internal_Boolean_String_0;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeMethodInfoPtr_Match_Internal_Boolean_Char_0;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr_MatchLongestWords_Internal_Int32_Il2CppStringArray_byref_Int32_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_GetRepeatCount_Internal_Int32_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr_GetNextDigit_Internal_Boolean_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr_GetChar_Internal_Char_0;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr_GetDigit_Internal_Int32_0;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhiteSpaces_Internal_Void_0;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhiteSpaceCurrent_Internal_Boolean_0;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeMethodInfoPtr_TrimTail_Internal_Void_0;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrailingInQuoteSpaces_Internal_Void_0;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLeadingInQuoteSpaces_Internal_Void_0;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr_GetSubString_Internal_DTSubString_0;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeSubString_Internal_Void_DTSubString_0;
	}
}

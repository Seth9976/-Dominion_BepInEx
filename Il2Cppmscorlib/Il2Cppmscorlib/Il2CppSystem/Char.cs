using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem
{
	// Token: 0x02000085 RID: 133
	[Serializable]
	[StructLayout(2)]
	public struct Char
	{
		// Token: 0x06000801 RID: 2049 RVA: 0x00046204 File Offset: 0x00044404
		// Note: this type is marked as 'beforefieldinit'.
		static Char()
		{
			Il2CppClassPointerStore<char>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Char");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<char>.NativeClassPtr);
			Char.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<char>.NativeClassPtr, "m_value");
			Char.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<char>.NativeClassPtr, "MaxValue");
			Char.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<char>.NativeClassPtr, "MinValue");
			Char.NativeFieldInfoPtr_categoryForLatin1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<char>.NativeClassPtr, "categoryForLatin1");
			Char.NativeFieldInfoPtr_UNICODE_PLANE00_END = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<char>.NativeClassPtr, "UNICODE_PLANE00_END");
			Char.NativeFieldInfoPtr_UNICODE_PLANE01_START = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<char>.NativeClassPtr, "UNICODE_PLANE01_START");
			Char.NativeFieldInfoPtr_UNICODE_PLANE16_END = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<char>.NativeClassPtr, "UNICODE_PLANE16_END");
			Char.NativeFieldInfoPtr_HIGH_SURROGATE_START = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<char>.NativeClassPtr, "HIGH_SURROGATE_START");
			Char.NativeFieldInfoPtr_LOW_SURROGATE_END = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<char>.NativeClassPtr, "LOW_SURROGATE_END");
			Char.NativeMethodInfoPtr_IsLatin1_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664567);
			Char.NativeMethodInfoPtr_IsAscii_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664568);
			Char.NativeMethodInfoPtr_GetLatin1UnicodeCategory_Private_Static_UnicodeCategory_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664569);
			Char.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664570);
			Char.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664571);
			Char.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664572);
			Char.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664573);
			Char.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664574);
			Char.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664575);
			Char.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664576);
			Char.NativeMethodInfoPtr_ToString_Public_Static_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664577);
			Char.NativeMethodInfoPtr_Parse_Public_Static_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664578);
			Char.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664579);
			Char.NativeMethodInfoPtr_IsDigit_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664580);
			Char.NativeMethodInfoPtr_CheckLetter_Internal_Static_Boolean_UnicodeCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664581);
			Char.NativeMethodInfoPtr_IsLetter_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664582);
			Char.NativeMethodInfoPtr_IsWhiteSpaceLatin1_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664583);
			Char.NativeMethodInfoPtr_IsWhiteSpace_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664584);
			Char.NativeMethodInfoPtr_IsUpper_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664585);
			Char.NativeMethodInfoPtr_IsLower_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664586);
			Char.NativeMethodInfoPtr_CheckPunctuation_Internal_Static_Boolean_UnicodeCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664587);
			Char.NativeMethodInfoPtr_IsPunctuation_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664588);
			Char.NativeMethodInfoPtr_CheckLetterOrDigit_Internal_Static_Boolean_UnicodeCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664589);
			Char.NativeMethodInfoPtr_IsLetterOrDigit_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664590);
			Char.NativeMethodInfoPtr_ToUpper_Public_Static_Char_Char_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664591);
			Char.NativeMethodInfoPtr_ToUpper_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664592);
			Char.NativeMethodInfoPtr_ToUpperInvariant_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664593);
			Char.NativeMethodInfoPtr_ToLower_Public_Static_Char_Char_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664594);
			Char.NativeMethodInfoPtr_ToLower_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664595);
			Char.NativeMethodInfoPtr_ToLowerInvariant_Public_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664596);
			Char.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664597);
			Char.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664598);
			Char.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664599);
			Char.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664600);
			Char.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664601);
			Char.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664602);
			Char.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664603);
			Char.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664604);
			Char.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664605);
			Char.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664606);
			Char.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664607);
			Char.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664608);
			Char.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664609);
			Char.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664610);
			Char.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664611);
			Char.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664612);
			Char.NativeMethodInfoPtr_IsControl_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664613);
			Char.NativeMethodInfoPtr_CheckNumber_Internal_Static_Boolean_UnicodeCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664614);
			Char.NativeMethodInfoPtr_IsNumber_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664615);
			Char.NativeMethodInfoPtr_IsNumber_Public_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664616);
			Char.NativeMethodInfoPtr_CheckSeparator_Internal_Static_Boolean_UnicodeCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664617);
			Char.NativeMethodInfoPtr_IsSeparatorLatin1_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664618);
			Char.NativeMethodInfoPtr_IsSeparator_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664619);
			Char.NativeMethodInfoPtr_IsSurrogate_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664620);
			Char.NativeMethodInfoPtr_IsSurrogate_Public_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664621);
			Char.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664622);
			Char.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664623);
			Char.NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664624);
			Char.NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664625);
			Char.NativeMethodInfoPtr_IsLowSurrogate_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664626);
			Char.NativeMethodInfoPtr_IsSurrogatePair_Public_Static_Boolean_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664627);
			Char.NativeMethodInfoPtr_ConvertToUtf32_Public_Static_Int32_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<char>.NativeClassPtr, 100664628);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x000467C0 File Offset: 0x000449C0
		[CallerCount(0)]
		public unsafe static bool IsLatin1(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsLatin1_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00046800 File Offset: 0x00044A00
		[CallerCount(0)]
		public unsafe static bool IsAscii(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsAscii_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00046840 File Offset: 0x00044A40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 277319, RefRangeEnd = 277322, XrefRangeStart = 277315, XrefRangeEnd = 277319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory GetLatin1UnicodeCategory(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_GetLatin1UnicodeCategory_Private_Static_UnicodeCategory_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00046880 File Offset: 0x00044A80
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000468B0 File Offset: 0x00044AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277322, XrefRangeEnd = 277325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000468F4 File Offset: 0x00044AF4
		[CallerCount(0)]
		public unsafe bool Equals(char obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Char_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00046934 File Offset: 0x00044B34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277328, RefRangeEnd = 277329, XrefRangeStart = 277325, XrefRangeEnd = 277328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00046978 File Offset: 0x00044B78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277329, RefRangeEnd = 277331, XrefRangeStart = 277329, XrefRangeEnd = 277329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Char_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000469B8 File Offset: 0x00044BB8
		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 277335, RefRangeEnd = 277417, XrefRangeStart = 277331, XrefRangeEnd = 277335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000469E4 File Offset: 0x00044BE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277421, RefRangeEnd = 277422, XrefRangeStart = 277417, XrefRangeEnd = 277421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00046A20 File Offset: 0x00044C20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277423, RefRangeEnd = 277424, XrefRangeStart = 277422, XrefRangeEnd = 277423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ToString_Public_Static_String_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00046A58 File Offset: 0x00044C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277424, XrefRangeEnd = 277438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char Parse(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_Parse_Public_Static_Char_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00046A9C File Offset: 0x00044C9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277439, RefRangeEnd = 277440, XrefRangeStart = 277438, XrefRangeEnd = 277439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, out char result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00046AEC File Offset: 0x00044CEC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 277451, RefRangeEnd = 277457, XrefRangeStart = 277440, XrefRangeEnd = 277451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDigit(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsDigit_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00046B2C File Offset: 0x00044D2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277457, RefRangeEnd = 277458, XrefRangeStart = 277457, XrefRangeEnd = 277457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckLetter(UnicodeCategory uc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_CheckLetter_Internal_Static_Boolean_UnicodeCategory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00046B6C File Offset: 0x00044D6C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 277472, RefRangeEnd = 277484, XrefRangeStart = 277458, XrefRangeEnd = 277472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLetter(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsLetter_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00046BAC File Offset: 0x00044DAC
		[CallerCount(0)]
		public unsafe static bool IsWhiteSpaceLatin1(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsWhiteSpaceLatin1_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00046BEC File Offset: 0x00044DEC
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 277500, RefRangeEnd = 277554, XrefRangeStart = 277484, XrefRangeEnd = 277500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWhiteSpace(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsWhiteSpace_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00046C2C File Offset: 0x00044E2C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 277566, RefRangeEnd = 277572, XrefRangeStart = 277554, XrefRangeEnd = 277566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUpper(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsUpper_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00046C6C File Offset: 0x00044E6C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 277584, RefRangeEnd = 277592, XrefRangeStart = 277572, XrefRangeEnd = 277584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLower(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsLower_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00046CAC File Offset: 0x00044EAC
		[CallerCount(0)]
		public unsafe static bool CheckPunctuation(UnicodeCategory uc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_CheckPunctuation_Internal_Static_Boolean_UnicodeCategory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00046CEC File Offset: 0x00044EEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277606, RefRangeEnd = 277608, XrefRangeStart = 277592, XrefRangeEnd = 277606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPunctuation(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsPunctuation_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00046D2C File Offset: 0x00044F2C
		[CallerCount(0)]
		public unsafe static bool CheckLetterOrDigit(UnicodeCategory uc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_CheckLetterOrDigit_Internal_Static_Boolean_UnicodeCategory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00046D6C File Offset: 0x00044F6C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 277625, RefRangeEnd = 277638, XrefRangeStart = 277608, XrefRangeEnd = 277625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLetterOrDigit(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsLetterOrDigit_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00046DAC File Offset: 0x00044FAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277645, RefRangeEnd = 277646, XrefRangeStart = 277638, XrefRangeEnd = 277645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToUpper(char c, CultureInfo culture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ToUpper_Public_Static_Char_Char_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00046DFC File Offset: 0x00044FFC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 277660, RefRangeEnd = 277667, XrefRangeStart = 277646, XrefRangeEnd = 277660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToUpper(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ToUpper_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00046E3C File Offset: 0x0004503C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 277681, RefRangeEnd = 277687, XrefRangeStart = 277667, XrefRangeEnd = 277681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToUpperInvariant(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ToUpperInvariant_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00046E7C File Offset: 0x0004507C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 277694, RefRangeEnd = 277711, XrefRangeStart = 277687, XrefRangeEnd = 277694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToLower(char c, CultureInfo culture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ToLower_Public_Static_Char_Char_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00046ECC File Offset: 0x000450CC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 277725, RefRangeEnd = 277731, XrefRangeStart = 277711, XrefRangeEnd = 277725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToLower(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ToLower_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00046F0C File Offset: 0x0004510C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277745, RefRangeEnd = 277747, XrefRangeStart = 277731, XrefRangeEnd = 277745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToLowerInvariant(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ToLowerInvariant_Public_Static_Char_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00046F4C File Offset: 0x0004514C
		[CallerCount(0)]
		public unsafe TypeCode GetTypeCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00046F7C File Offset: 0x0004517C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277747, XrefRangeEnd = 277766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_IConvertible_ToBoolean(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00046FC0 File Offset: 0x000451C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210360, RefRangeEnd = 210362, XrefRangeStart = 210360, XrefRangeEnd = 210362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char System_IConvertible_ToChar(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00047004 File Offset: 0x00045204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277766, XrefRangeEnd = 277769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe sbyte System_IConvertible_ToSByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00047048 File Offset: 0x00045248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277769, XrefRangeEnd = 277772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte System_IConvertible_ToByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0004708C File Offset: 0x0004528C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277772, XrefRangeEnd = 277775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short System_IConvertible_ToInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x000470D0 File Offset: 0x000452D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277775, XrefRangeEnd = 277778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort System_IConvertible_ToUInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00047114 File Offset: 0x00045314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277778, XrefRangeEnd = 277781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IConvertible_ToInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00047158 File Offset: 0x00045358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277781, XrefRangeEnd = 277784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint System_IConvertible_ToUInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0004719C File Offset: 0x0004539C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277784, XrefRangeEnd = 277787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long System_IConvertible_ToInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x000471E0 File Offset: 0x000453E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277787, XrefRangeEnd = 277790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong System_IConvertible_ToUInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00047224 File Offset: 0x00045424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277790, XrefRangeEnd = 277809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float System_IConvertible_ToSingle(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00047268 File Offset: 0x00045468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277809, XrefRangeEnd = 277828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double System_IConvertible_ToDouble(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x000472AC File Offset: 0x000454AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277828, XrefRangeEnd = 277847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal System_IConvertible_ToDecimal(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x000472F0 File Offset: 0x000454F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277847, XrefRangeEnd = 277866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime System_IConvertible_ToDateTime(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00047334 File Offset: 0x00045534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277866, XrefRangeEnd = 277873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object System_IConvertible_ToType(Type type, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0004738C File Offset: 0x0004558C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277885, RefRangeEnd = 277887, XrefRangeStart = 277873, XrefRangeEnd = 277885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsControl(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsControl_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000473CC File Offset: 0x000455CC
		[CallerCount(0)]
		public unsafe static bool CheckNumber(UnicodeCategory uc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_CheckNumber_Internal_Static_Boolean_UnicodeCategory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0004740C File Offset: 0x0004560C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277901, RefRangeEnd = 277903, XrefRangeStart = 277887, XrefRangeEnd = 277901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNumber(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsNumber_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0004744C File Offset: 0x0004564C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277918, RefRangeEnd = 277919, XrefRangeStart = 277903, XrefRangeEnd = 277918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNumber(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsNumber_Public_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0004749C File Offset: 0x0004569C
		[CallerCount(0)]
		public unsafe static bool CheckSeparator(UnicodeCategory uc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_CheckSeparator_Internal_Static_Boolean_UnicodeCategory_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000474DC File Offset: 0x000456DC
		[CallerCount(0)]
		public unsafe static bool IsSeparatorLatin1(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsSeparatorLatin1_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0004751C File Offset: 0x0004571C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 277933, RefRangeEnd = 277945, XrefRangeStart = 277919, XrefRangeEnd = 277933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSeparator(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsSeparator_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0004755C File Offset: 0x0004575C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 277945, RefRangeEnd = 277948, XrefRangeStart = 277945, XrefRangeEnd = 277945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSurrogate(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsSurrogate_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0004759C File Offset: 0x0004579C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277952, RefRangeEnd = 277954, XrefRangeStart = 277948, XrefRangeEnd = 277952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSurrogate(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsSurrogate_Public_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x000475EC File Offset: 0x000457EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 277964, RefRangeEnd = 277967, XrefRangeStart = 277954, XrefRangeEnd = 277964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory GetUnicodeCategory(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0004762C File Offset: 0x0004582C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277991, RefRangeEnd = 277993, XrefRangeStart = 277967, XrefRangeEnd = 277991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnicodeCategory GetUnicodeCategory(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0004767C File Offset: 0x0004587C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 277993, RefRangeEnd = 278006, XrefRangeStart = 277993, XrefRangeEnd = 277993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHighSurrogate(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x000476BC File Offset: 0x000458BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278010, RefRangeEnd = 278012, XrefRangeStart = 278006, XrefRangeEnd = 278010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHighSurrogate(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0004770C File Offset: 0x0004590C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 278012, RefRangeEnd = 278026, XrefRangeStart = 278012, XrefRangeEnd = 278012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLowSurrogate(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsLowSurrogate_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0004774C File Offset: 0x0004594C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278026, RefRangeEnd = 278027, XrefRangeStart = 278026, XrefRangeEnd = 278026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSurrogatePair(char highSurrogate, char lowSurrogate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref highSurrogate;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowSurrogate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_IsSurrogatePair_Public_Static_Boolean_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00047798 File Offset: 0x00045998
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278032, RefRangeEnd = 278033, XrefRangeStart = 278027, XrefRangeEnd = 278032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ConvertToUtf32(char highSurrogate, char lowSurrogate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref highSurrogate;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowSurrogate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Char.NativeMethodInfoPtr_ConvertToUtf32_Public_Static_Int32_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0000473A File Offset: 0x0000293A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<char>.NativeClassPtr, ref this));
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x000477E4 File Offset: 0x000459E4
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x0000474C File Offset: 0x0000294C
		public unsafe static char MaxValue
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Char.NativeFieldInfoPtr_MaxValue, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Char.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00047800 File Offset: 0x00045A00
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x0000475A File Offset: 0x0000295A
		public unsafe static char MinValue
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Char.NativeFieldInfoPtr_MinValue, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Char.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x0004781C File Offset: 0x00045A1C
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x00004768 File Offset: 0x00002968
		public unsafe static Il2CppStructArray<byte> categoryForLatin1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Char.NativeFieldInfoPtr_categoryForLatin1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Char.NativeFieldInfoPtr_categoryForLatin1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x00047844 File Offset: 0x00045A44
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x0000477A File Offset: 0x0000297A
		public unsafe static int UNICODE_PLANE00_END
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Char.NativeFieldInfoPtr_UNICODE_PLANE00_END, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Char.NativeFieldInfoPtr_UNICODE_PLANE00_END, (void*)(&value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x00047860 File Offset: 0x00045A60
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x00004788 File Offset: 0x00002988
		public unsafe static int UNICODE_PLANE01_START
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Char.NativeFieldInfoPtr_UNICODE_PLANE01_START, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Char.NativeFieldInfoPtr_UNICODE_PLANE01_START, (void*)(&value));
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x0004787C File Offset: 0x00045A7C
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x00004796 File Offset: 0x00002996
		public unsafe static int UNICODE_PLANE16_END
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Char.NativeFieldInfoPtr_UNICODE_PLANE16_END, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Char.NativeFieldInfoPtr_UNICODE_PLANE16_END, (void*)(&value));
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00047898 File Offset: 0x00045A98
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x000047A4 File Offset: 0x000029A4
		public unsafe static int HIGH_SURROGATE_START
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Char.NativeFieldInfoPtr_HIGH_SURROGATE_START, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Char.NativeFieldInfoPtr_HIGH_SURROGATE_START, (void*)(&value));
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x000478B4 File Offset: 0x00045AB4
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x000047B2 File Offset: 0x000029B2
		public unsafe static int LOW_SURROGATE_END
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Char.NativeFieldInfoPtr_LOW_SURROGATE_END, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Char.NativeFieldInfoPtr_LOW_SURROGATE_END, (void*)(&value));
			}
		}

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeFieldInfoPtr_categoryForLatin1;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeFieldInfoPtr_UNICODE_PLANE00_END;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeFieldInfoPtr_UNICODE_PLANE01_START;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeFieldInfoPtr_UNICODE_PLANE16_END;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeFieldInfoPtr_HIGH_SURROGATE_START;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeFieldInfoPtr_LOW_SURROGATE_END;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_IsLatin1_Private_Static_Boolean_Char_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_IsAscii_Private_Static_Boolean_Char_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_GetLatin1UnicodeCategory_Private_Static_UnicodeCategory_Char_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Char_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Char_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Char_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Char_String_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Char_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_IsDigit_Public_Static_Boolean_Char_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_CheckLetter_Internal_Static_Boolean_UnicodeCategory_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_IsLetter_Public_Static_Boolean_Char_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr_IsWhiteSpaceLatin1_Private_Static_Boolean_Char_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_IsWhiteSpace_Public_Static_Boolean_Char_0;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr_IsUpper_Public_Static_Boolean_Char_0;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr_IsLower_Public_Static_Boolean_Char_0;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr_CheckPunctuation_Internal_Static_Boolean_UnicodeCategory_0;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_IsPunctuation_Public_Static_Boolean_Char_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_CheckLetterOrDigit_Internal_Static_Boolean_UnicodeCategory_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_IsLetterOrDigit_Public_Static_Boolean_Char_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_ToUpper_Public_Static_Char_Char_CultureInfo_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_ToUpper_Public_Static_Char_Char_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperInvariant_Public_Static_Char_Char_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_ToLower_Public_Static_Char_Char_CultureInfo_0;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr_ToLower_Public_Static_Char_Char_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_ToLowerInvariant_Public_Static_Char_Char_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_IsControl_Public_Static_Boolean_Char_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_CheckNumber_Internal_Static_Boolean_UnicodeCategory_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr_IsNumber_Public_Static_Boolean_Char_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr_IsNumber_Public_Static_Boolean_String_Int32_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr_CheckSeparator_Internal_Static_Boolean_UnicodeCategory_0;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr_IsSeparatorLatin1_Private_Static_Boolean_Char_0;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeMethodInfoPtr_IsSeparator_Public_Static_Boolean_Char_0;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr_IsSurrogate_Public_Static_Boolean_Char_0;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr_IsSurrogate_Public_Static_Boolean_String_Int32_0;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_Char_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr_GetUnicodeCategory_Public_Static_UnicodeCategory_String_Int32_0;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_Char_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_IsHighSurrogate_Public_Static_Boolean_String_Int32_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_IsLowSurrogate_Public_Static_Boolean_Char_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_IsSurrogatePair_Public_Static_Boolean_Char_Char_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToUtf32_Public_Static_Int32_Char_Char_0;

		// Token: 0x04000624 RID: 1572
		[FieldOffset(0)]
		public char m_value;
	}
}

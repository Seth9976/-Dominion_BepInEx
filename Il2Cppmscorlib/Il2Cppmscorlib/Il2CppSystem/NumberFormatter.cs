using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x02000128 RID: 296
	public sealed class NumberFormatter : Object
	{
		// Token: 0x060014E4 RID: 5348 RVA: 0x00081334 File Offset: 0x0007F534
		// Note: this type is marked as 'beforefieldinit'.
		static NumberFormatter()
		{
			Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "NumberFormatter");
			NumberFormatter.NativeFieldInfoPtr_MantissaBitsTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "MantissaBitsTable");
			NumberFormatter.NativeFieldInfoPtr_TensExponentTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "TensExponentTable");
			NumberFormatter.NativeFieldInfoPtr_DigitLowerTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "DigitLowerTable");
			NumberFormatter.NativeFieldInfoPtr_DigitUpperTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "DigitUpperTable");
			NumberFormatter.NativeFieldInfoPtr_TenPowersList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "TenPowersList");
			NumberFormatter.NativeFieldInfoPtr_DecHexDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "DecHexDigits");
			NumberFormatter.NativeFieldInfoPtr__nfi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_nfi");
			NumberFormatter.NativeFieldInfoPtr__cbuf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_cbuf");
			NumberFormatter.NativeFieldInfoPtr__NaN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_NaN");
			NumberFormatter.NativeFieldInfoPtr__infinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_infinity");
			NumberFormatter.NativeFieldInfoPtr__isCustomFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_isCustomFormat");
			NumberFormatter.NativeFieldInfoPtr__specifierIsUpper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_specifierIsUpper");
			NumberFormatter.NativeFieldInfoPtr__positive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_positive");
			NumberFormatter.NativeFieldInfoPtr__specifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_specifier");
			NumberFormatter.NativeFieldInfoPtr__precision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_precision");
			NumberFormatter.NativeFieldInfoPtr__defPrecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_defPrecision");
			NumberFormatter.NativeFieldInfoPtr__digitsLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_digitsLen");
			NumberFormatter.NativeFieldInfoPtr__offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_offset");
			NumberFormatter.NativeFieldInfoPtr__decPointPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_decPointPos");
			NumberFormatter.NativeFieldInfoPtr__val1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_val1");
			NumberFormatter.NativeFieldInfoPtr__val2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_val2");
			NumberFormatter.NativeFieldInfoPtr__val3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_val3");
			NumberFormatter.NativeFieldInfoPtr__val4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_val4");
			NumberFormatter.NativeFieldInfoPtr__ind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "_ind");
			NumberFormatter.NativeFieldInfoPtr_threadNumberFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "threadNumberFormatter");
			NumberFormatter.NativeFieldInfoPtr_userFormatProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "userFormatProvider");
			NumberFormatter.NativeMethodInfoPtr_GetFormatterTables_Private_Static_Void_byref_ptr_UInt64_byref_ptr_Int32_byref_ptr_Char_byref_ptr_Char_byref_ptr_Int64_byref_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666856);
			NumberFormatter.NativeMethodInfoPtr_GetTenPowerOf_Private_Static_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666858);
			NumberFormatter.NativeMethodInfoPtr_InitDecHexDigits_Private_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666859);
			NumberFormatter.NativeMethodInfoPtr_InitDecHexDigits_Private_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666860);
			NumberFormatter.NativeMethodInfoPtr_InitDecHexDigits_Private_Void_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666861);
			NumberFormatter.NativeMethodInfoPtr_FastToDecHex_Private_Static_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666862);
			NumberFormatter.NativeMethodInfoPtr_ToDecHex_Private_Static_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666863);
			NumberFormatter.NativeMethodInfoPtr_FastDecHexLen_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666864);
			NumberFormatter.NativeMethodInfoPtr_DecHexLen_Private_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666865);
			NumberFormatter.NativeMethodInfoPtr_DecHexLen_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666866);
			NumberFormatter.NativeMethodInfoPtr_ScaleOrder_Private_Static_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666867);
			NumberFormatter.NativeMethodInfoPtr_InitialFloatingPrecision_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666868);
			NumberFormatter.NativeMethodInfoPtr_ParsePrecision_Private_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666869);
			NumberFormatter.NativeMethodInfoPtr__ctor_Private_Void_Thread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666870);
			NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666871);
			NumberFormatter.NativeMethodInfoPtr_InitHex_Private_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666872);
			NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666873);
			NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666874);
			NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666875);
			NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666876);
			NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666877);
			NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666878);
			NumberFormatter.NativeMethodInfoPtr_ResetCharBuf_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666879);
			NumberFormatter.NativeMethodInfoPtr_Resize_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666880);
			NumberFormatter.NativeMethodInfoPtr_Append_Private_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666881);
			NumberFormatter.NativeMethodInfoPtr_Append_Private_Void_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666882);
			NumberFormatter.NativeMethodInfoPtr_Append_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666883);
			NumberFormatter.NativeMethodInfoPtr_GetNumberFormatInstance_Private_NumberFormatInfo_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666884);
			NumberFormatter.NativeMethodInfoPtr_set_CurrentCulture_Private_set_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666885);
			NumberFormatter.NativeMethodInfoPtr_get_IntegerDigits_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666886);
			NumberFormatter.NativeMethodInfoPtr_get_DecimalDigits_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666887);
			NumberFormatter.NativeMethodInfoPtr_get_IsFloatingSource_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666888);
			NumberFormatter.NativeMethodInfoPtr_get_IsZero_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666889);
			NumberFormatter.NativeMethodInfoPtr_get_IsZeroInteger_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666890);
			NumberFormatter.NativeMethodInfoPtr_RoundPos_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666891);
			NumberFormatter.NativeMethodInfoPtr_RoundDecimal_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666892);
			NumberFormatter.NativeMethodInfoPtr_RoundBits_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666893);
			NumberFormatter.NativeMethodInfoPtr_RemoveTrailingZeros_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666894);
			NumberFormatter.NativeMethodInfoPtr_AddOneToDecHex_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666895);
			NumberFormatter.NativeMethodInfoPtr_AddOneToDecHex_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666896);
			NumberFormatter.NativeMethodInfoPtr_CountTrailingZeros_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666897);
			NumberFormatter.NativeMethodInfoPtr_CountTrailingZeros_Private_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666898);
			NumberFormatter.NativeMethodInfoPtr_GetInstance_Private_Static_NumberFormatter_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666899);
			NumberFormatter.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666900);
			NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666901);
			NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666902);
			NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666903);
			NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666904);
			NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666905);
			NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666906);
			NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666907);
			NumberFormatter.NativeMethodInfoPtr_IntegerToString_Private_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666908);
			NumberFormatter.NativeMethodInfoPtr_NumberToString_Private_String_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666909);
			NumberFormatter.NativeMethodInfoPtr_FormatCurrency_Private_String_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666910);
			NumberFormatter.NativeMethodInfoPtr_FormatDecimal_Private_String_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666911);
			NumberFormatter.NativeMethodInfoPtr_FormatHexadecimal_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666912);
			NumberFormatter.NativeMethodInfoPtr_FormatFixedPoint_Private_String_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666913);
			NumberFormatter.NativeMethodInfoPtr_FormatRoundtrip_Private_String_Double_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666914);
			NumberFormatter.NativeMethodInfoPtr_FormatRoundtrip_Private_String_Single_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666915);
			NumberFormatter.NativeMethodInfoPtr_FormatGeneral_Private_String_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666916);
			NumberFormatter.NativeMethodInfoPtr_FormatNumber_Private_String_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666917);
			NumberFormatter.NativeMethodInfoPtr_FormatPercent_Private_String_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666918);
			NumberFormatter.NativeMethodInfoPtr_FormatExponential_Private_String_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666919);
			NumberFormatter.NativeMethodInfoPtr_FormatExponential_Private_String_Int32_NumberFormatInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666920);
			NumberFormatter.NativeMethodInfoPtr_FormatCustom_Private_String_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666921);
			NumberFormatter.NativeMethodInfoPtr_ZeroTrimEnd_Private_Static_Void_StringBuilder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666922);
			NumberFormatter.NativeMethodInfoPtr_IsZeroOnly_Private_Static_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666923);
			NumberFormatter.NativeMethodInfoPtr_AppendNonNegativeNumber_Private_Static_Void_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666924);
			NumberFormatter.NativeMethodInfoPtr_AppendIntegerString_Private_Void_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666925);
			NumberFormatter.NativeMethodInfoPtr_AppendIntegerString_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666926);
			NumberFormatter.NativeMethodInfoPtr_AppendDecimalString_Private_Void_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666927);
			NumberFormatter.NativeMethodInfoPtr_AppendDecimalString_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666928);
			NumberFormatter.NativeMethodInfoPtr_AppendIntegerStringWithGroupSeparator_Private_Void_Il2CppStructArray_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666929);
			NumberFormatter.NativeMethodInfoPtr_AppendExponent_Private_Void_NumberFormatInfo_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666930);
			NumberFormatter.NativeMethodInfoPtr_AppendOneDigit_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666931);
			NumberFormatter.NativeMethodInfoPtr_AppendDigits_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666932);
			NumberFormatter.NativeMethodInfoPtr_AppendDigits_Private_Void_Int32_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666933);
			NumberFormatter.NativeMethodInfoPtr_Multiply10_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666934);
			NumberFormatter.NativeMethodInfoPtr_Divide10_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666935);
			NumberFormatter.NativeMethodInfoPtr_GetClone_Private_NumberFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, 100666936);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x00081BA4 File Offset: 0x0007FDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306487, XrefRangeEnd = 306488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetFormatterTables(out ulong* MantissaBitsTable, out int* TensExponentTable, out char* DigitLowerTable, out char* DigitUpperTable, out long* TenPowersList, out int* DecHexDigits)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = 0;
			ptr5 = &intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5 = 0;
			ptr6 = &intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6 = 0;
			ptr7 = &intPtr6;
			IntPtr intPtr8;
			IntPtr intPtr7 = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_GetFormatterTables_Private_Static_Void_byref_ptr_UInt64_byref_ptr_Int32_byref_ptr_Char_byref_ptr_Char_byref_ptr_Int64_byref_ptr_Int32_0, 0, (void**)ptr, ref intPtr8);
			Il2CppException.RaiseExceptionIfNecessary(intPtr8);
			IntPtr intPtr9 = intPtr;
			MantissaBitsTable = ((intPtr9 == 0) ? null : new ulong*(intPtr9));
			IntPtr intPtr10 = intPtr2;
			TensExponentTable = ((intPtr10 == 0) ? null : new int*(intPtr10));
			IntPtr intPtr11 = intPtr3;
			DigitLowerTable = ((intPtr11 == 0) ? null : new char*(intPtr11));
			IntPtr intPtr12 = intPtr4;
			DigitUpperTable = ((intPtr12 == 0) ? null : new char*(intPtr12));
			IntPtr intPtr13 = intPtr5;
			TenPowersList = ((intPtr13 == 0) ? null : new long*(intPtr13));
			IntPtr intPtr14 = intPtr6;
			DecHexDigits = ((intPtr14 == 0) ? null : new int*(intPtr14));
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x00081C9C File Offset: 0x0007FE9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 306492, RefRangeEnd = 306494, XrefRangeStart = 306488, XrefRangeEnd = 306492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetTenPowerOf(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_GetTenPowerOf_Private_Static_Int64_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00081CDC File Offset: 0x0007FEDC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 306508, RefRangeEnd = 306514, XrefRangeStart = 306494, XrefRangeEnd = 306508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitDecHexDigits(uint value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_InitDecHexDigits_Private_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00081D1C File Offset: 0x0007FF1C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 306524, RefRangeEnd = 306531, XrefRangeStart = 306514, XrefRangeEnd = 306524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitDecHexDigits(ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_InitDecHexDigits_Private_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00081D5C File Offset: 0x0007FF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306531, XrefRangeEnd = 306544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitDecHexDigits(uint hi, ulong lo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hi;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_InitDecHexDigits_Private_Void_UInt32_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00081DA8 File Offset: 0x0007FFA8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 306548, RefRangeEnd = 306555, XrefRangeStart = 306544, XrefRangeEnd = 306548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint FastToDecHex(int val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FastToDecHex_Private_Static_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00081DE8 File Offset: 0x0007FFE8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 306562, RefRangeEnd = 306569, XrefRangeStart = 306555, XrefRangeEnd = 306562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToDecHex(int val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_ToDecHex_Private_Static_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00081E28 File Offset: 0x00080028
		[CallerCount(0)]
		public unsafe static int FastDecHexLen(int val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FastDecHexLen_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x00081E68 File Offset: 0x00080068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306569, XrefRangeEnd = 306572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DecHexLen(uint val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_DecHexLen_Private_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x00081EA8 File Offset: 0x000800A8
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 306573, RefRangeEnd = 306595, XrefRangeStart = 306572, XrefRangeEnd = 306573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DecHexLen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_DecHexLen_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x00081EE4 File Offset: 0x000800E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 306599, RefRangeEnd = 306602, XrefRangeStart = 306595, XrefRangeEnd = 306599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ScaleOrder(long hi)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hi;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_ScaleOrder_Private_Static_Int32_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x00081F24 File Offset: 0x00080124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306602, XrefRangeEnd = 306603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InitialFloatingPrecision()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_InitialFloatingPrecision_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x00081F60 File Offset: 0x00080160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306603, XrefRangeEnd = 306605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParsePrecision(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_ParsePrecision_Private_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00081FA4 File Offset: 0x000801A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306605, XrefRangeEnd = 306611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFormatter(Thread current)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr__ctor_Private_Void_Thread_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00081FF0 File Offset: 0x000801F0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 306618, RefRangeEnd = 306632, XrefRangeStart = 306611, XrefRangeEnd = 306618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00082034 File Offset: 0x00080234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306632, XrefRangeEnd = 306633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitHex(ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_InitHex_Private_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x00082074 File Offset: 0x00080274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306633, XrefRangeEnd = 306636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string format, int value, int defPrecision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defPrecision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x000820D4 File Offset: 0x000802D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306636, XrefRangeEnd = 306639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string format, uint value, int defPrecision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defPrecision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_UInt32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00082134 File Offset: 0x00080334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306639, XrefRangeEnd = 306642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string format, long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00082184 File Offset: 0x00080384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306642, XrefRangeEnd = 306645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string format, ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x000821D4 File Offset: 0x000803D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 306687, RefRangeEnd = 306689, XrefRangeStart = 306645, XrefRangeEnd = 306687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string format, double value, int defPrecision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defPrecision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00082234 File Offset: 0x00080434
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 306694, RefRangeEnd = 306696, XrefRangeStart = 306689, XrefRangeEnd = 306694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(string format, Decimal value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Init_Private_Void_String_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00082284 File Offset: 0x00080484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306696, XrefRangeEnd = 306699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCharBuf(int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_ResetCharBuf_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x000822C4 File Offset: 0x000804C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306699, XrefRangeEnd = 306702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resize(int len)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref len;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Resize_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00082304 File Offset: 0x00080504
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 306705, RefRangeEnd = 306728, XrefRangeStart = 306702, XrefRangeEnd = 306705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Append_Private_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00082344 File Offset: 0x00080544
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 306731, RefRangeEnd = 306736, XrefRangeStart = 306728, XrefRangeEnd = 306731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(char c, int cnt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cnt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Append_Private_Void_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00082390 File Offset: 0x00080590
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 306740, RefRangeEnd = 306773, XrefRangeStart = 306736, XrefRangeEnd = 306740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Append(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Append_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x000823D4 File Offset: 0x000805D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306773, XrefRangeEnd = 306774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFormatInfo GetNumberFormatInstance(IFormatProvider fp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_GetNumberFormatInstance_Private_NumberFormatInfo_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (set) Token: 0x06001501 RID: 5377 RVA: 0x00082424 File Offset: 0x00080624
		public unsafe CultureInfo CurrentCulture
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_set_CurrentCulture_Private_set_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x00082468 File Offset: 0x00080668
		public unsafe int IntegerDigits
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_get_IntegerDigits_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x000824A4 File Offset: 0x000806A4
		public unsafe int DecimalDigits
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_get_DecimalDigits_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x000824E0 File Offset: 0x000806E0
		public unsafe bool IsFloatingSource
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_get_IsFloatingSource_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x0008251C File Offset: 0x0008071C
		public unsafe bool IsZero
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_get_IsZero_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x00082558 File Offset: 0x00080758
		public unsafe bool IsZeroInteger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_get_IsZeroInteger_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00082594 File Offset: 0x00080794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306774, XrefRangeEnd = 306775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RoundPos(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_RoundPos_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x000825D4 File Offset: 0x000807D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306775, XrefRangeEnd = 306776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RoundDecimal(int decimals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref decimals;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_RoundDecimal_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x00082620 File Offset: 0x00080820
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 306799, RefRangeEnd = 306809, XrefRangeStart = 306776, XrefRangeEnd = 306799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RoundBits(int shift)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shift;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_RoundBits_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x0008266C File Offset: 0x0008086C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306809, XrefRangeEnd = 306810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrailingZeros()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_RemoveTrailingZeros_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x000826A0 File Offset: 0x000808A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306810, XrefRangeEnd = 306814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOneToDecHex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AddOneToDecHex_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x000826D4 File Offset: 0x000808D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 306814, RefRangeEnd = 306817, XrefRangeStart = 306814, XrefRangeEnd = 306814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint AddOneToDecHex(uint val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AddOneToDecHex_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x00082714 File Offset: 0x00080914
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 306818, RefRangeEnd = 306821, XrefRangeStart = 306817, XrefRangeEnd = 306818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CountTrailingZeros()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_CountTrailingZeros_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x00082750 File Offset: 0x00080950
		[CallerCount(0)]
		public unsafe static int CountTrailingZeros(uint val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_CountTrailingZeros_Private_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00082790 File Offset: 0x00080990
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 306830, RefRangeEnd = 306842, XrefRangeStart = 306821, XrefRangeEnd = 306830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NumberFormatter GetInstance(IFormatProvider fp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_GetInstance_Private_Static_NumberFormatter_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatter>(intPtr3) : null;
			}
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x000827D4 File Offset: 0x000809D4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 306851, RefRangeEnd = 306863, XrefRangeStart = 306842, XrefRangeEnd = 306851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x00082808 File Offset: 0x00080A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306863, XrefRangeEnd = 306874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NumberToString(string format, uint value, IFormatProvider fp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_UInt32_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00082864 File Offset: 0x00080A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306874, XrefRangeEnd = 306885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NumberToString(string format, int value, IFormatProvider fp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Int32_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x000828C0 File Offset: 0x00080AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306885, XrefRangeEnd = 306896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NumberToString(string format, ulong value, IFormatProvider fp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_UInt64_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x0008291C File Offset: 0x00080B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306896, XrefRangeEnd = 306907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NumberToString(string format, long value, IFormatProvider fp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Int64_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x00082978 File Offset: 0x00080B78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306925, RefRangeEnd = 306926, XrefRangeStart = 306907, XrefRangeEnd = 306925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NumberToString(string format, float value, IFormatProvider fp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Single_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x000829D4 File Offset: 0x00080BD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306947, RefRangeEnd = 306948, XrefRangeStart = 306926, XrefRangeEnd = 306947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NumberToString(string format, double value, IFormatProvider fp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Double_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x00082A30 File Offset: 0x00080C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306948, XrefRangeEnd = 306956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NumberToString(string format, Decimal value, IFormatProvider fp)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Decimal_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x00082A8C File Offset: 0x00080C8C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 306975, RefRangeEnd = 306983, XrefRangeStart = 306956, XrefRangeEnd = 306975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string IntegerToString(string format, IFormatProvider fp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_IntegerToString_Private_String_String_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x00082AE8 File Offset: 0x00080CE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 306998, RefRangeEnd = 307002, XrefRangeStart = 306983, XrefRangeEnd = 306998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string NumberToString(string format, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_NumberToString_Private_String_String_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x00082B44 File Offset: 0x00080D44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 307050, RefRangeEnd = 307052, XrefRangeStart = 307002, XrefRangeEnd = 307050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatCurrency(int precision, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatCurrency_Private_String_Int32_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x00082B9C File Offset: 0x00080D9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 307059, RefRangeEnd = 307061, XrefRangeStart = 307052, XrefRangeEnd = 307059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatDecimal(int precision, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatDecimal_Private_String_Int32_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00082BF4 File Offset: 0x00080DF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 307076, RefRangeEnd = 307077, XrefRangeStart = 307061, XrefRangeEnd = 307076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatHexadecimal(int precision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatHexadecimal_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00082C38 File Offset: 0x00080E38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 307088, RefRangeEnd = 307090, XrefRangeStart = 307077, XrefRangeEnd = 307088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatFixedPoint(int precision, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatFixedPoint_Private_String_Int32_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00082C90 File Offset: 0x00080E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307090, XrefRangeEnd = 307098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatRoundtrip(double origval, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origval;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatRoundtrip_Private_String_Double_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00082CE8 File Offset: 0x00080EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307098, XrefRangeEnd = 307103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatRoundtrip(float origval, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref origval;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatRoundtrip_Private_String_Single_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x00082D40 File Offset: 0x00080F40
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 307116, RefRangeEnd = 307124, XrefRangeStart = 307103, XrefRangeEnd = 307116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatGeneral(int precision, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatGeneral_Private_String_Int32_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x00082D98 File Offset: 0x00080F98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 307145, RefRangeEnd = 307147, XrefRangeStart = 307124, XrefRangeEnd = 307145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatNumber(int precision, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatNumber_Private_String_Int32_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00082DF0 File Offset: 0x00080FF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 307167, RefRangeEnd = 307169, XrefRangeStart = 307147, XrefRangeEnd = 307167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatPercent(int precision, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatPercent_Private_String_Int32_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00082E48 File Offset: 0x00081048
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 307171, RefRangeEnd = 307173, XrefRangeStart = 307169, XrefRangeEnd = 307171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatExponential(int precision, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatExponential_Private_String_Int32_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x00082EA0 File Offset: 0x000810A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 307205, RefRangeEnd = 307206, XrefRangeStart = 307173, XrefRangeEnd = 307205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatExponential(int precision, NumberFormatInfo nfi, int expDigits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expDigits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatExponential_Private_String_Int32_NumberFormatInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x00082F04 File Offset: 0x00081104
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 307290, RefRangeEnd = 307292, XrefRangeStart = 307206, XrefRangeEnd = 307290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatCustom(string format, NumberFormatInfo nfi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_FormatCustom_Private_String_String_NumberFormatInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x00082F60 File Offset: 0x00081160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307292, XrefRangeEnd = 307298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ZeroTrimEnd(StringBuilder sb, bool canEmpty)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canEmpty;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_ZeroTrimEnd_Private_Static_Void_StringBuilder_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x00082FA4 File Offset: 0x000811A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307298, XrefRangeEnd = 307306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsZeroOnly(StringBuilder sb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_IsZeroOnly_Private_Static_Boolean_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00082FE8 File Offset: 0x000811E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307306, XrefRangeEnd = 307322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendNonNegativeNumber(StringBuilder sb, int v)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendNonNegativeNumber_Private_Static_Void_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0008302C File Offset: 0x0008122C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307322, XrefRangeEnd = 307324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendIntegerString(int minLength, StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendIntegerString_Private_Void_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0008307C File Offset: 0x0008127C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307324, XrefRangeEnd = 307327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendIntegerString(int minLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendIntegerString_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x000830BC File Offset: 0x000812BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307327, XrefRangeEnd = 307328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendDecimalString(int precision, StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendDecimalString_Private_Void_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0008310C File Offset: 0x0008130C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307328, XrefRangeEnd = 307329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendDecimalString(int precision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precision;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendDecimalString_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0008314C File Offset: 0x0008134C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307356, RefRangeEnd = 307359, XrefRangeStart = 307329, XrefRangeEnd = 307356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendIntegerStringWithGroupSeparator(Il2CppStructArray<int> groups, string groupSeparator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(groups);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(groupSeparator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendIntegerStringWithGroupSeparator_Private_Void_Il2CppStructArray_1_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x000831A0 File Offset: 0x000813A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307359, XrefRangeEnd = 307369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendExponent(NumberFormatInfo nfi, int exponent, int minDigits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nfi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exponent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDigits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendExponent_Private_Void_NumberFormatInfo_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00083200 File Offset: 0x00081400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307369, XrefRangeEnd = 307376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendOneDigit(int start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendOneDigit_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00083240 File Offset: 0x00081440
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 307384, RefRangeEnd = 307397, XrefRangeStart = 307376, XrefRangeEnd = 307384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendDigits(int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendDigits_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0008328C File Offset: 0x0008148C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 307412, RefRangeEnd = 307416, XrefRangeStart = 307397, XrefRangeEnd = 307412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendDigits(int start, int end, StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_AppendDigits_Private_Void_Int32_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x000832EC File Offset: 0x000814EC
		[CallerCount(0)]
		public unsafe void Multiply10(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Multiply10_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0008332C File Offset: 0x0008152C
		[CallerCount(0)]
		public unsafe void Divide10(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_Divide10_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0008336C File Offset: 0x0008156C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307416, XrefRangeEnd = 307419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFormatter GetClone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.NativeMethodInfoPtr_GetClone_Private_NumberFormatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatter>(intPtr3) : null;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x000074CB File Offset: 0x000056CB
		public NumberFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x000833AC File Offset: 0x000815AC
		// (set) Token: 0x06001537 RID: 5431 RVA: 0x000074D4 File Offset: 0x000056D4
		public unsafe static ulong* MantissaBitsTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatter.NativeFieldInfoPtr_MantissaBitsTable, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatter.NativeFieldInfoPtr_MantissaBitsTable, (void*)value);
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x000833C8 File Offset: 0x000815C8
		// (set) Token: 0x06001539 RID: 5433 RVA: 0x000074E1 File Offset: 0x000056E1
		public unsafe static int* TensExponentTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatter.NativeFieldInfoPtr_TensExponentTable, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatter.NativeFieldInfoPtr_TensExponentTable, (void*)value);
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x000833E4 File Offset: 0x000815E4
		// (set) Token: 0x0600153B RID: 5435 RVA: 0x000074EE File Offset: 0x000056EE
		public unsafe static char* DigitLowerTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatter.NativeFieldInfoPtr_DigitLowerTable, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatter.NativeFieldInfoPtr_DigitLowerTable, (void*)value);
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x00083400 File Offset: 0x00081600
		// (set) Token: 0x0600153D RID: 5437 RVA: 0x000074FB File Offset: 0x000056FB
		public unsafe static char* DigitUpperTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatter.NativeFieldInfoPtr_DigitUpperTable, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatter.NativeFieldInfoPtr_DigitUpperTable, (void*)value);
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x0008341C File Offset: 0x0008161C
		// (set) Token: 0x0600153F RID: 5439 RVA: 0x00007508 File Offset: 0x00005708
		public unsafe static long* TenPowersList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatter.NativeFieldInfoPtr_TenPowersList, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatter.NativeFieldInfoPtr_TenPowersList, (void*)value);
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x00083438 File Offset: 0x00081638
		// (set) Token: 0x06001541 RID: 5441 RVA: 0x00007515 File Offset: 0x00005715
		public unsafe static int* DecHexDigits
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatter.NativeFieldInfoPtr_DecHexDigits, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatter.NativeFieldInfoPtr_DecHexDigits, (void*)value);
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x00083454 File Offset: 0x00081654
		// (set) Token: 0x06001543 RID: 5443 RVA: 0x00007522 File Offset: 0x00005722
		public unsafe NumberFormatInfo _nfi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__nfi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__nfi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x00083484 File Offset: 0x00081684
		// (set) Token: 0x06001545 RID: 5445 RVA: 0x00007541 File Offset: 0x00005741
		public unsafe Il2CppStructArray<char> _cbuf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__cbuf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__cbuf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x000834B4 File Offset: 0x000816B4
		// (set) Token: 0x06001547 RID: 5447 RVA: 0x00007560 File Offset: 0x00005760
		public unsafe bool _NaN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__NaN);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__NaN)) = value;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x000834DC File Offset: 0x000816DC
		// (set) Token: 0x06001549 RID: 5449 RVA: 0x0000757B File Offset: 0x0000577B
		public unsafe bool _infinity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__infinity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__infinity)) = value;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x00083504 File Offset: 0x00081704
		// (set) Token: 0x0600154B RID: 5451 RVA: 0x00007596 File Offset: 0x00005796
		public unsafe bool _isCustomFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__isCustomFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__isCustomFormat)) = value;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x0008352C File Offset: 0x0008172C
		// (set) Token: 0x0600154D RID: 5453 RVA: 0x000075B1 File Offset: 0x000057B1
		public unsafe bool _specifierIsUpper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__specifierIsUpper);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__specifierIsUpper)) = value;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x00083554 File Offset: 0x00081754
		// (set) Token: 0x0600154F RID: 5455 RVA: 0x000075CC File Offset: 0x000057CC
		public unsafe bool _positive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__positive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__positive)) = value;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001550 RID: 5456 RVA: 0x0008357C File Offset: 0x0008177C
		// (set) Token: 0x06001551 RID: 5457 RVA: 0x000075E7 File Offset: 0x000057E7
		public unsafe char _specifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__specifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__specifier)) = value;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x000835A4 File Offset: 0x000817A4
		// (set) Token: 0x06001553 RID: 5459 RVA: 0x00007602 File Offset: 0x00005802
		public unsafe int _precision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__precision);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__precision)) = value;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x000835CC File Offset: 0x000817CC
		// (set) Token: 0x06001555 RID: 5461 RVA: 0x0000761D File Offset: 0x0000581D
		public unsafe int _defPrecision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__defPrecision);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__defPrecision)) = value;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001556 RID: 5462 RVA: 0x000835F4 File Offset: 0x000817F4
		// (set) Token: 0x06001557 RID: 5463 RVA: 0x00007638 File Offset: 0x00005838
		public unsafe int _digitsLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__digitsLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__digitsLen)) = value;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x0008361C File Offset: 0x0008181C
		// (set) Token: 0x06001559 RID: 5465 RVA: 0x00007653 File Offset: 0x00005853
		public unsafe int _offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__offset)) = value;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x00083644 File Offset: 0x00081844
		// (set) Token: 0x0600155B RID: 5467 RVA: 0x0000766E File Offset: 0x0000586E
		public unsafe int _decPointPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__decPointPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__decPointPos)) = value;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x0600155C RID: 5468 RVA: 0x0008366C File Offset: 0x0008186C
		// (set) Token: 0x0600155D RID: 5469 RVA: 0x00007689 File Offset: 0x00005889
		public unsafe uint _val1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__val1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__val1)) = value;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x00083694 File Offset: 0x00081894
		// (set) Token: 0x0600155F RID: 5471 RVA: 0x000076A4 File Offset: 0x000058A4
		public unsafe uint _val2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__val2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__val2)) = value;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x000836BC File Offset: 0x000818BC
		// (set) Token: 0x06001561 RID: 5473 RVA: 0x000076BF File Offset: 0x000058BF
		public unsafe uint _val3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__val3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__val3)) = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x000836E4 File Offset: 0x000818E4
		// (set) Token: 0x06001563 RID: 5475 RVA: 0x000076DA File Offset: 0x000058DA
		public unsafe uint _val4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__val4);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__val4)) = value;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x0008370C File Offset: 0x0008190C
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x000076F5 File Offset: 0x000058F5
		public unsafe int _ind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__ind);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.NativeFieldInfoPtr__ind)) = value;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x00083734 File Offset: 0x00081934
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x00007710 File Offset: 0x00005910
		public unsafe static NumberFormatter threadNumberFormatter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatter.NativeFieldInfoPtr_threadNumberFormatter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFormatter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatter.NativeFieldInfoPtr_threadNumberFormatter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x0008375C File Offset: 0x0008195C
		// (set) Token: 0x06001569 RID: 5481 RVA: 0x00007722 File Offset: 0x00005922
		public unsafe static NumberFormatter userFormatProvider
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatter.NativeFieldInfoPtr_userFormatProvider, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFormatter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatter.NativeFieldInfoPtr_userFormatProvider, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeFieldInfoPtr_MantissaBitsTable;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeFieldInfoPtr_TensExponentTable;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeFieldInfoPtr_DigitLowerTable;

		// Token: 0x040011C7 RID: 4551
		private static readonly IntPtr NativeFieldInfoPtr_DigitUpperTable;

		// Token: 0x040011C8 RID: 4552
		private static readonly IntPtr NativeFieldInfoPtr_TenPowersList;

		// Token: 0x040011C9 RID: 4553
		private static readonly IntPtr NativeFieldInfoPtr_DecHexDigits;

		// Token: 0x040011CA RID: 4554
		private static readonly IntPtr NativeFieldInfoPtr__nfi;

		// Token: 0x040011CB RID: 4555
		private static readonly IntPtr NativeFieldInfoPtr__cbuf;

		// Token: 0x040011CC RID: 4556
		private static readonly IntPtr NativeFieldInfoPtr__NaN;

		// Token: 0x040011CD RID: 4557
		private static readonly IntPtr NativeFieldInfoPtr__infinity;

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeFieldInfoPtr__isCustomFormat;

		// Token: 0x040011CF RID: 4559
		private static readonly IntPtr NativeFieldInfoPtr__specifierIsUpper;

		// Token: 0x040011D0 RID: 4560
		private static readonly IntPtr NativeFieldInfoPtr__positive;

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeFieldInfoPtr__specifier;

		// Token: 0x040011D2 RID: 4562
		private static readonly IntPtr NativeFieldInfoPtr__precision;

		// Token: 0x040011D3 RID: 4563
		private static readonly IntPtr NativeFieldInfoPtr__defPrecision;

		// Token: 0x040011D4 RID: 4564
		private static readonly IntPtr NativeFieldInfoPtr__digitsLen;

		// Token: 0x040011D5 RID: 4565
		private static readonly IntPtr NativeFieldInfoPtr__offset;

		// Token: 0x040011D6 RID: 4566
		private static readonly IntPtr NativeFieldInfoPtr__decPointPos;

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeFieldInfoPtr__val1;

		// Token: 0x040011D8 RID: 4568
		private static readonly IntPtr NativeFieldInfoPtr__val2;

		// Token: 0x040011D9 RID: 4569
		private static readonly IntPtr NativeFieldInfoPtr__val3;

		// Token: 0x040011DA RID: 4570
		private static readonly IntPtr NativeFieldInfoPtr__val4;

		// Token: 0x040011DB RID: 4571
		private static readonly IntPtr NativeFieldInfoPtr__ind;

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeFieldInfoPtr_threadNumberFormatter;

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeFieldInfoPtr_userFormatProvider;

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatterTables_Private_Static_Void_byref_ptr_UInt64_byref_ptr_Int32_byref_ptr_Char_byref_ptr_Char_byref_ptr_Int64_byref_ptr_Int32_0;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeMethodInfoPtr_GetTenPowerOf_Private_Static_Int64_Int32_0;

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeMethodInfoPtr_InitDecHexDigits_Private_Void_UInt32_0;

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeMethodInfoPtr_InitDecHexDigits_Private_Void_UInt64_0;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeMethodInfoPtr_InitDecHexDigits_Private_Void_UInt32_UInt64_0;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeMethodInfoPtr_FastToDecHex_Private_Static_UInt32_Int32_0;

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeMethodInfoPtr_ToDecHex_Private_Static_UInt32_Int32_0;

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeMethodInfoPtr_FastDecHexLen_Private_Static_Int32_Int32_0;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeMethodInfoPtr_DecHexLen_Private_Static_Int32_UInt32_0;

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeMethodInfoPtr_DecHexLen_Private_Int32_0;

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeMethodInfoPtr_ScaleOrder_Private_Static_Int32_Int64_0;

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeMethodInfoPtr_InitialFloatingPrecision_Private_Int32_0;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeMethodInfoPtr_ParsePrecision_Private_Static_Int32_String_0;

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Thread_0;

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_String_0;

		// Token: 0x040011ED RID: 4589
		private static readonly IntPtr NativeMethodInfoPtr_InitHex_Private_Void_UInt64_0;

		// Token: 0x040011EE RID: 4590
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_String_Int32_Int32_0;

		// Token: 0x040011EF RID: 4591
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_String_UInt32_Int32_0;

		// Token: 0x040011F0 RID: 4592
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_String_Int64_0;

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_String_UInt64_0;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_String_Double_Int32_0;

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_String_Decimal_0;

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeMethodInfoPtr_ResetCharBuf_Private_Void_Int32_0;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeMethodInfoPtr_Resize_Private_Void_Int32_0;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeMethodInfoPtr_Append_Private_Void_Char_0;

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeMethodInfoPtr_Append_Private_Void_Char_Int32_0;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeMethodInfoPtr_Append_Private_Void_String_0;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeMethodInfoPtr_GetNumberFormatInstance_Private_NumberFormatInfo_IFormatProvider_0;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentCulture_Private_set_Void_CultureInfo_0;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeMethodInfoPtr_get_IntegerDigits_Private_get_Int32_0;

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeMethodInfoPtr_get_DecimalDigits_Private_get_Int32_0;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFloatingSource_Private_get_Boolean_0;

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeMethodInfoPtr_get_IsZero_Private_get_Boolean_0;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeMethodInfoPtr_get_IsZeroInteger_Private_get_Boolean_0;

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeMethodInfoPtr_RoundPos_Private_Void_Int32_0;

		// Token: 0x04001201 RID: 4609
		private static readonly IntPtr NativeMethodInfoPtr_RoundDecimal_Private_Boolean_Int32_0;

		// Token: 0x04001202 RID: 4610
		private static readonly IntPtr NativeMethodInfoPtr_RoundBits_Private_Boolean_Int32_0;

		// Token: 0x04001203 RID: 4611
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrailingZeros_Private_Void_0;

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeMethodInfoPtr_AddOneToDecHex_Private_Void_0;

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeMethodInfoPtr_AddOneToDecHex_Private_Static_UInt32_UInt32_0;

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeMethodInfoPtr_CountTrailingZeros_Private_Int32_0;

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeMethodInfoPtr_CountTrailingZeros_Private_Static_Int32_UInt32_0;

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Private_Static_NumberFormatter_IFormatProvider_0;

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeMethodInfoPtr_NumberToString_Public_Static_String_String_UInt32_IFormatProvider_0;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Int32_IFormatProvider_0;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeMethodInfoPtr_NumberToString_Public_Static_String_String_UInt64_IFormatProvider_0;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Int64_IFormatProvider_0;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Single_IFormatProvider_0;

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Double_IFormatProvider_0;

		// Token: 0x04001210 RID: 4624
		private static readonly IntPtr NativeMethodInfoPtr_NumberToString_Public_Static_String_String_Decimal_IFormatProvider_0;

		// Token: 0x04001211 RID: 4625
		private static readonly IntPtr NativeMethodInfoPtr_IntegerToString_Private_String_String_IFormatProvider_0;

		// Token: 0x04001212 RID: 4626
		private static readonly IntPtr NativeMethodInfoPtr_NumberToString_Private_String_String_NumberFormatInfo_0;

		// Token: 0x04001213 RID: 4627
		private static readonly IntPtr NativeMethodInfoPtr_FormatCurrency_Private_String_Int32_NumberFormatInfo_0;

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeMethodInfoPtr_FormatDecimal_Private_String_Int32_NumberFormatInfo_0;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeMethodInfoPtr_FormatHexadecimal_Private_String_Int32_0;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeMethodInfoPtr_FormatFixedPoint_Private_String_Int32_NumberFormatInfo_0;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeMethodInfoPtr_FormatRoundtrip_Private_String_Double_NumberFormatInfo_0;

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeMethodInfoPtr_FormatRoundtrip_Private_String_Single_NumberFormatInfo_0;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeMethodInfoPtr_FormatGeneral_Private_String_Int32_NumberFormatInfo_0;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeMethodInfoPtr_FormatNumber_Private_String_Int32_NumberFormatInfo_0;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeMethodInfoPtr_FormatPercent_Private_String_Int32_NumberFormatInfo_0;

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeMethodInfoPtr_FormatExponential_Private_String_Int32_NumberFormatInfo_0;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeMethodInfoPtr_FormatExponential_Private_String_Int32_NumberFormatInfo_Int32_0;

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeMethodInfoPtr_FormatCustom_Private_String_String_NumberFormatInfo_0;

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeMethodInfoPtr_ZeroTrimEnd_Private_Static_Void_StringBuilder_Boolean_0;

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeMethodInfoPtr_IsZeroOnly_Private_Static_Boolean_StringBuilder_0;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeMethodInfoPtr_AppendNonNegativeNumber_Private_Static_Void_StringBuilder_Int32_0;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeMethodInfoPtr_AppendIntegerString_Private_Void_Int32_StringBuilder_0;

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeMethodInfoPtr_AppendIntegerString_Private_Void_Int32_0;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeMethodInfoPtr_AppendDecimalString_Private_Void_Int32_StringBuilder_0;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeMethodInfoPtr_AppendDecimalString_Private_Void_Int32_0;

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeMethodInfoPtr_AppendIntegerStringWithGroupSeparator_Private_Void_Il2CppStructArray_1_Int32_String_0;

		// Token: 0x04001227 RID: 4647
		private static readonly IntPtr NativeMethodInfoPtr_AppendExponent_Private_Void_NumberFormatInfo_Int32_Int32_0;

		// Token: 0x04001228 RID: 4648
		private static readonly IntPtr NativeMethodInfoPtr_AppendOneDigit_Private_Void_Int32_0;

		// Token: 0x04001229 RID: 4649
		private static readonly IntPtr NativeMethodInfoPtr_AppendDigits_Private_Void_Int32_Int32_0;

		// Token: 0x0400122A RID: 4650
		private static readonly IntPtr NativeMethodInfoPtr_AppendDigits_Private_Void_Int32_Int32_StringBuilder_0;

		// Token: 0x0400122B RID: 4651
		private static readonly IntPtr NativeMethodInfoPtr_Multiply10_Private_Void_Int32_0;

		// Token: 0x0400122C RID: 4652
		private static readonly IntPtr NativeMethodInfoPtr_Divide10_Private_Void_Int32_0;

		// Token: 0x0400122D RID: 4653
		private static readonly IntPtr NativeMethodInfoPtr_GetClone_Private_NumberFormatter_0;

		// Token: 0x020005AC RID: 1452
		public class CustomInfo : Object
		{
			// Token: 0x06004FCC RID: 20428 RVA: 0x001664F8 File Offset: 0x001646F8
			// Note: this type is marked as 'beforefieldinit'.
			static CustomInfo()
			{
				Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NumberFormatter>.NativeClassPtr, "CustomInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr);
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_UseGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "UseGroup");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_DecimalDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "DecimalDigits");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_DecimalPointPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "DecimalPointPos");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_DecimalTailSharpDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "DecimalTailSharpDigits");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_IntegerDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "IntegerDigits");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_IntegerHeadSharpDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "IntegerHeadSharpDigits");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_IntegerHeadPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "IntegerHeadPos");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_UseExponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "UseExponent");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_ExponentDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "ExponentDigits");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_ExponentTailSharpDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "ExponentTailSharpDigits");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_ExponentNegativeSignOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "ExponentNegativeSignOnly");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_DividePlaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "DividePlaces");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_Percents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "Percents");
				NumberFormatter.CustomInfo.NativeFieldInfoPtr_Permilles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, "Permilles");
				NumberFormatter.CustomInfo.NativeMethodInfoPtr_GetActiveSection_Public_Static_Void_String_byref_Boolean_Boolean_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, 100666937);
				NumberFormatter.CustomInfo.NativeMethodInfoPtr_Parse_Public_Static_CustomInfo_String_Int32_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, 100666938);
				NumberFormatter.CustomInfo.NativeMethodInfoPtr_Format_Public_String_String_Int32_Int32_NumberFormatInfo_Boolean_StringBuilder_StringBuilder_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, 100666939);
				NumberFormatter.CustomInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr, 100666940);
			}

			// Token: 0x06004FCD RID: 20429 RVA: 0x0016668C File Offset: 0x0016488C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306399, RefRangeEnd = 306400, XrefRangeStart = 306390, XrefRangeEnd = 306399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void GetActiveSection(string format, ref bool positive, bool zero, ref int offset, ref int length)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &positive;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zero;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.CustomInfo.NativeMethodInfoPtr_GetActiveSection_Public_Static_Void_String_byref_Boolean_Boolean_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FCE RID: 20430 RVA: 0x001666FC File Offset: 0x001648FC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306423, RefRangeEnd = 306424, XrefRangeStart = 306400, XrefRangeEnd = 306423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static NumberFormatter.CustomInfo Parse(string format, int offset, int length, NumberFormatInfo nfi)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.CustomInfo.NativeMethodInfoPtr_Parse_Public_Static_CustomInfo_String_Int32_Int32_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatter.CustomInfo>(intPtr3) : null;
			}

			// Token: 0x06004FCF RID: 20431 RVA: 0x00166770 File Offset: 0x00164970
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306485, RefRangeEnd = 306486, XrefRangeStart = 306424, XrefRangeEnd = 306485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string Format(string format, int offset, int length, NumberFormatInfo nfi, bool positive, StringBuilder sb_int, StringBuilder sb_dec, StringBuilder sb_exp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nfi);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positive;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb_int);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb_dec);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb_exp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.CustomInfo.NativeMethodInfoPtr_Format_Public_String_String_Int32_Int32_NumberFormatInfo_Boolean_StringBuilder_StringBuilder_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06004FD0 RID: 20432 RVA: 0x00166830 File Offset: 0x00164A30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306486, XrefRangeEnd = 306487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CustomInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberFormatter.CustomInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatter.CustomInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FD1 RID: 20433 RVA: 0x0001E4FC File Offset: 0x0001C6FC
			public CustomInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001451 RID: 5201
			// (get) Token: 0x06004FD2 RID: 20434 RVA: 0x0016686C File Offset: 0x00164A6C
			// (set) Token: 0x06004FD3 RID: 20435 RVA: 0x0001E505 File Offset: 0x0001C705
			public unsafe bool UseGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_UseGroup);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_UseGroup)) = value;
				}
			}

			// Token: 0x17001452 RID: 5202
			// (get) Token: 0x06004FD4 RID: 20436 RVA: 0x00166894 File Offset: 0x00164A94
			// (set) Token: 0x06004FD5 RID: 20437 RVA: 0x0001E520 File Offset: 0x0001C720
			public unsafe int DecimalDigits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_DecimalDigits);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_DecimalDigits)) = value;
				}
			}

			// Token: 0x17001453 RID: 5203
			// (get) Token: 0x06004FD6 RID: 20438 RVA: 0x001668BC File Offset: 0x00164ABC
			// (set) Token: 0x06004FD7 RID: 20439 RVA: 0x0001E53B File Offset: 0x0001C73B
			public unsafe int DecimalPointPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_DecimalPointPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_DecimalPointPos)) = value;
				}
			}

			// Token: 0x17001454 RID: 5204
			// (get) Token: 0x06004FD8 RID: 20440 RVA: 0x001668E4 File Offset: 0x00164AE4
			// (set) Token: 0x06004FD9 RID: 20441 RVA: 0x0001E556 File Offset: 0x0001C756
			public unsafe int DecimalTailSharpDigits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_DecimalTailSharpDigits);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_DecimalTailSharpDigits)) = value;
				}
			}

			// Token: 0x17001455 RID: 5205
			// (get) Token: 0x06004FDA RID: 20442 RVA: 0x0016690C File Offset: 0x00164B0C
			// (set) Token: 0x06004FDB RID: 20443 RVA: 0x0001E571 File Offset: 0x0001C771
			public unsafe int IntegerDigits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_IntegerDigits);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_IntegerDigits)) = value;
				}
			}

			// Token: 0x17001456 RID: 5206
			// (get) Token: 0x06004FDC RID: 20444 RVA: 0x00166934 File Offset: 0x00164B34
			// (set) Token: 0x06004FDD RID: 20445 RVA: 0x0001E58C File Offset: 0x0001C78C
			public unsafe int IntegerHeadSharpDigits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_IntegerHeadSharpDigits);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_IntegerHeadSharpDigits)) = value;
				}
			}

			// Token: 0x17001457 RID: 5207
			// (get) Token: 0x06004FDE RID: 20446 RVA: 0x0016695C File Offset: 0x00164B5C
			// (set) Token: 0x06004FDF RID: 20447 RVA: 0x0001E5A7 File Offset: 0x0001C7A7
			public unsafe int IntegerHeadPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_IntegerHeadPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_IntegerHeadPos)) = value;
				}
			}

			// Token: 0x17001458 RID: 5208
			// (get) Token: 0x06004FE0 RID: 20448 RVA: 0x00166984 File Offset: 0x00164B84
			// (set) Token: 0x06004FE1 RID: 20449 RVA: 0x0001E5C2 File Offset: 0x0001C7C2
			public unsafe bool UseExponent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_UseExponent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_UseExponent)) = value;
				}
			}

			// Token: 0x17001459 RID: 5209
			// (get) Token: 0x06004FE2 RID: 20450 RVA: 0x001669AC File Offset: 0x00164BAC
			// (set) Token: 0x06004FE3 RID: 20451 RVA: 0x0001E5DD File Offset: 0x0001C7DD
			public unsafe int ExponentDigits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_ExponentDigits);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_ExponentDigits)) = value;
				}
			}

			// Token: 0x1700145A RID: 5210
			// (get) Token: 0x06004FE4 RID: 20452 RVA: 0x001669D4 File Offset: 0x00164BD4
			// (set) Token: 0x06004FE5 RID: 20453 RVA: 0x0001E5F8 File Offset: 0x0001C7F8
			public unsafe int ExponentTailSharpDigits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_ExponentTailSharpDigits);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_ExponentTailSharpDigits)) = value;
				}
			}

			// Token: 0x1700145B RID: 5211
			// (get) Token: 0x06004FE6 RID: 20454 RVA: 0x001669FC File Offset: 0x00164BFC
			// (set) Token: 0x06004FE7 RID: 20455 RVA: 0x0001E613 File Offset: 0x0001C813
			public unsafe bool ExponentNegativeSignOnly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_ExponentNegativeSignOnly);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_ExponentNegativeSignOnly)) = value;
				}
			}

			// Token: 0x1700145C RID: 5212
			// (get) Token: 0x06004FE8 RID: 20456 RVA: 0x00166A24 File Offset: 0x00164C24
			// (set) Token: 0x06004FE9 RID: 20457 RVA: 0x0001E62E File Offset: 0x0001C82E
			public unsafe int DividePlaces
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_DividePlaces);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_DividePlaces)) = value;
				}
			}

			// Token: 0x1700145D RID: 5213
			// (get) Token: 0x06004FEA RID: 20458 RVA: 0x00166A4C File Offset: 0x00164C4C
			// (set) Token: 0x06004FEB RID: 20459 RVA: 0x0001E649 File Offset: 0x0001C849
			public unsafe int Percents
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_Percents);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_Percents)) = value;
				}
			}

			// Token: 0x1700145E RID: 5214
			// (get) Token: 0x06004FEC RID: 20460 RVA: 0x00166A74 File Offset: 0x00164C74
			// (set) Token: 0x06004FED RID: 20461 RVA: 0x0001E664 File Offset: 0x0001C864
			public unsafe int Permilles
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_Permilles);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatter.CustomInfo.NativeFieldInfoPtr_Permilles)) = value;
				}
			}

			// Token: 0x040040F3 RID: 16627
			private static readonly IntPtr NativeFieldInfoPtr_UseGroup;

			// Token: 0x040040F4 RID: 16628
			private static readonly IntPtr NativeFieldInfoPtr_DecimalDigits;

			// Token: 0x040040F5 RID: 16629
			private static readonly IntPtr NativeFieldInfoPtr_DecimalPointPos;

			// Token: 0x040040F6 RID: 16630
			private static readonly IntPtr NativeFieldInfoPtr_DecimalTailSharpDigits;

			// Token: 0x040040F7 RID: 16631
			private static readonly IntPtr NativeFieldInfoPtr_IntegerDigits;

			// Token: 0x040040F8 RID: 16632
			private static readonly IntPtr NativeFieldInfoPtr_IntegerHeadSharpDigits;

			// Token: 0x040040F9 RID: 16633
			private static readonly IntPtr NativeFieldInfoPtr_IntegerHeadPos;

			// Token: 0x040040FA RID: 16634
			private static readonly IntPtr NativeFieldInfoPtr_UseExponent;

			// Token: 0x040040FB RID: 16635
			private static readonly IntPtr NativeFieldInfoPtr_ExponentDigits;

			// Token: 0x040040FC RID: 16636
			private static readonly IntPtr NativeFieldInfoPtr_ExponentTailSharpDigits;

			// Token: 0x040040FD RID: 16637
			private static readonly IntPtr NativeFieldInfoPtr_ExponentNegativeSignOnly;

			// Token: 0x040040FE RID: 16638
			private static readonly IntPtr NativeFieldInfoPtr_DividePlaces;

			// Token: 0x040040FF RID: 16639
			private static readonly IntPtr NativeFieldInfoPtr_Percents;

			// Token: 0x04004100 RID: 16640
			private static readonly IntPtr NativeFieldInfoPtr_Permilles;

			// Token: 0x04004101 RID: 16641
			private static readonly IntPtr NativeMethodInfoPtr_GetActiveSection_Public_Static_Void_String_byref_Boolean_Boolean_byref_Int32_byref_Int32_0;

			// Token: 0x04004102 RID: 16642
			private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_CustomInfo_String_Int32_Int32_NumberFormatInfo_0;

			// Token: 0x04004103 RID: 16643
			private static readonly IntPtr NativeMethodInfoPtr_Format_Public_String_String_Int32_Int32_NumberFormatInfo_Boolean_StringBuilder_StringBuilder_StringBuilder_0;

			// Token: 0x04004104 RID: 16644
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200023E RID: 574
	[Serializable]
	public sealed class NumberFormatInfo : Object
	{
		// Token: 0x060026A3 RID: 9891 RVA: 0x000CD214 File Offset: 0x000CB414
		// Note: this type is marked as 'beforefieldinit'.
		static NumberFormatInfo()
		{
			Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "NumberFormatInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr);
			NumberFormatInfo.NativeFieldInfoPtr_invariantInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "invariantInfo");
			NumberFormatInfo.NativeFieldInfoPtr_numberGroupSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "numberGroupSizes");
			NumberFormatInfo.NativeFieldInfoPtr_currencyGroupSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencyGroupSizes");
			NumberFormatInfo.NativeFieldInfoPtr_percentGroupSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentGroupSizes");
			NumberFormatInfo.NativeFieldInfoPtr_positiveSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "positiveSign");
			NumberFormatInfo.NativeFieldInfoPtr_negativeSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "negativeSign");
			NumberFormatInfo.NativeFieldInfoPtr_numberDecimalSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "numberDecimalSeparator");
			NumberFormatInfo.NativeFieldInfoPtr_numberGroupSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "numberGroupSeparator");
			NumberFormatInfo.NativeFieldInfoPtr_currencyGroupSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencyGroupSeparator");
			NumberFormatInfo.NativeFieldInfoPtr_currencyDecimalSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencyDecimalSeparator");
			NumberFormatInfo.NativeFieldInfoPtr_currencySymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencySymbol");
			NumberFormatInfo.NativeFieldInfoPtr_ansiCurrencySymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "ansiCurrencySymbol");
			NumberFormatInfo.NativeFieldInfoPtr_nanSymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "nanSymbol");
			NumberFormatInfo.NativeFieldInfoPtr_positiveInfinitySymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "positiveInfinitySymbol");
			NumberFormatInfo.NativeFieldInfoPtr_negativeInfinitySymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "negativeInfinitySymbol");
			NumberFormatInfo.NativeFieldInfoPtr_percentDecimalSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentDecimalSeparator");
			NumberFormatInfo.NativeFieldInfoPtr_percentGroupSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentGroupSeparator");
			NumberFormatInfo.NativeFieldInfoPtr_percentSymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentSymbol");
			NumberFormatInfo.NativeFieldInfoPtr_perMilleSymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "perMilleSymbol");
			NumberFormatInfo.NativeFieldInfoPtr_nativeDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "nativeDigits");
			NumberFormatInfo.NativeFieldInfoPtr_m_dataItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "m_dataItem");
			NumberFormatInfo.NativeFieldInfoPtr_numberDecimalDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "numberDecimalDigits");
			NumberFormatInfo.NativeFieldInfoPtr_currencyDecimalDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencyDecimalDigits");
			NumberFormatInfo.NativeFieldInfoPtr_currencyPositivePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencyPositivePattern");
			NumberFormatInfo.NativeFieldInfoPtr_currencyNegativePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencyNegativePattern");
			NumberFormatInfo.NativeFieldInfoPtr_numberNegativePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "numberNegativePattern");
			NumberFormatInfo.NativeFieldInfoPtr_percentPositivePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentPositivePattern");
			NumberFormatInfo.NativeFieldInfoPtr_percentNegativePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentNegativePattern");
			NumberFormatInfo.NativeFieldInfoPtr_percentDecimalDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentDecimalDigits");
			NumberFormatInfo.NativeFieldInfoPtr_digitSubstitution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "digitSubstitution");
			NumberFormatInfo.NativeFieldInfoPtr_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "isReadOnly");
			NumberFormatInfo.NativeFieldInfoPtr_m_useUserOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "m_useUserOverride");
			NumberFormatInfo.NativeFieldInfoPtr_m_isInvariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "m_isInvariant");
			NumberFormatInfo.NativeFieldInfoPtr_validForParseAsNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "validForParseAsNumber");
			NumberFormatInfo.NativeFieldInfoPtr_validForParseAsCurrency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "validForParseAsCurrency");
			NumberFormatInfo.NativeFieldInfoPtr_InvalidNumberStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "InvalidNumberStyles");
			NumberFormatInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669582);
			NumberFormatInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669583);
			NumberFormatInfo.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669584);
			NumberFormatInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669585);
			NumberFormatInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669586);
			NumberFormatInfo.NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669587);
			NumberFormatInfo.NativeMethodInfoPtr_GetInstance_Public_Static_NumberFormatInfo_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669588);
			NumberFormatInfo.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669589);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyDecimalDigits_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669590);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyDecimalSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669591);
			NumberFormatInfo.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669592);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyGroupSizes_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669593);
			NumberFormatInfo.NativeMethodInfoPtr_get_NumberGroupSizes_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669594);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentGroupSizes_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669595);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyGroupSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669596);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencySymbol_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669597);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669598);
			NumberFormatInfo.NativeMethodInfoPtr_get_NaNSymbol_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669599);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyNegativePattern_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669600);
			NumberFormatInfo.NativeMethodInfoPtr_get_NumberNegativePattern_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669601);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentPositivePattern_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669602);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentNegativePattern_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669603);
			NumberFormatInfo.NativeMethodInfoPtr_get_NegativeInfinitySymbol_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669604);
			NumberFormatInfo.NativeMethodInfoPtr_get_NegativeSign_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669605);
			NumberFormatInfo.NativeMethodInfoPtr_get_NumberDecimalDigits_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669606);
			NumberFormatInfo.NativeMethodInfoPtr_get_NumberDecimalSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669607);
			NumberFormatInfo.NativeMethodInfoPtr_get_NumberGroupSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669608);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyPositivePattern_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669609);
			NumberFormatInfo.NativeMethodInfoPtr_get_PositiveInfinitySymbol_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669610);
			NumberFormatInfo.NativeMethodInfoPtr_get_PositiveSign_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669611);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentDecimalDigits_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669612);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentDecimalSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669613);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentGroupSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669614);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentSymbol_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669615);
			NumberFormatInfo.NativeMethodInfoPtr_get_PerMilleSymbol_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669616);
			NumberFormatInfo.NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669617);
			NumberFormatInfo.NativeMethodInfoPtr_ReadOnly_Public_Static_NumberFormatInfo_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669618);
			NumberFormatInfo.NativeMethodInfoPtr_ValidateParseStyleInteger_Internal_Static_Void_NumberStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669619);
			NumberFormatInfo.NativeMethodInfoPtr_ValidateParseStyleFloatingPoint_Internal_Static_Void_NumberStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100669620);
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x000CD820 File Offset: 0x000CBA20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327222, XrefRangeEnd = 327223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFormatInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x000CD85C File Offset: 0x000CBA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327223, XrefRangeEnd = 327228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x000CD8A4 File Offset: 0x000CBAA4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x000CD8EC File Offset: 0x000CBAEC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x000CD934 File Offset: 0x000CBB34
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 327305, RefRangeEnd = 327310, XrefRangeStart = 327228, XrefRangeEnd = 327305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFormatInfo(CultureData cultureData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cultureData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x060026A9 RID: 9897 RVA: 0x000CD980 File Offset: 0x000CBB80
		public unsafe static NumberFormatInfo InvariantInfo
		{
			[CallerCount(47)]
			[CachedScanResults(RefRangeStart = 327323, RefRangeEnd = 327370, XrefRangeStart = 327310, XrefRangeEnd = 327323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x000CD9B4 File Offset: 0x000CBBB4
		[CallerCount(63)]
		[CachedScanResults(RefRangeStart = 327377, RefRangeEnd = 327440, XrefRangeStart = 327370, XrefRangeEnd = 327377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NumberFormatInfo GetInstance(IFormatProvider formatProvider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_GetInstance_Public_Static_NumberFormatInfo_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x000CD9F8 File Offset: 0x000CBBF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 327443, RefRangeEnd = 327445, XrefRangeStart = 327440, XrefRangeEnd = 327443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x060026AC RID: 9900 RVA: 0x000CDA38 File Offset: 0x000CBC38
		public unsafe int CurrencyDecimalDigits
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyDecimalDigits_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x060026AD RID: 9901 RVA: 0x000CDA74 File Offset: 0x000CBC74
		public unsafe string CurrencyDecimalSeparator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyDecimalSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x060026AE RID: 9902 RVA: 0x000CDAAC File Offset: 0x000CBCAC
		public unsafe bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x060026AF RID: 9903 RVA: 0x000CDAE8 File Offset: 0x000CBCE8
		public unsafe Il2CppStructArray<int> CurrencyGroupSizes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327445, XrefRangeEnd = 327448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyGroupSizes_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x060026B0 RID: 9904 RVA: 0x000CDB28 File Offset: 0x000CBD28
		public unsafe Il2CppStructArray<int> NumberGroupSizes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 327451, RefRangeEnd = 327452, XrefRangeStart = 327448, XrefRangeEnd = 327451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NumberGroupSizes_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x060026B1 RID: 9905 RVA: 0x000CDB68 File Offset: 0x000CBD68
		public unsafe Il2CppStructArray<int> PercentGroupSizes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327452, XrefRangeEnd = 327455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentGroupSizes_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x060026B2 RID: 9906 RVA: 0x000CDBA8 File Offset: 0x000CBDA8
		public unsafe string CurrencyGroupSeparator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyGroupSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x060026B3 RID: 9907 RVA: 0x000CDBE0 File Offset: 0x000CBDE0
		public unsafe string CurrencySymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencySymbol_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x060026B4 RID: 9908 RVA: 0x000CDC18 File Offset: 0x000CBE18
		public unsafe static NumberFormatInfo CurrentInfo
		{
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 327461, RefRangeEnd = 327494, XrefRangeStart = 327455, XrefRangeEnd = 327461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x060026B5 RID: 9909 RVA: 0x000CDC4C File Offset: 0x000CBE4C
		public unsafe string NaNSymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NaNSymbol_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x060026B6 RID: 9910 RVA: 0x000CDC84 File Offset: 0x000CBE84
		public unsafe int CurrencyNegativePattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyNegativePattern_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x060026B7 RID: 9911 RVA: 0x000CDCC0 File Offset: 0x000CBEC0
		public unsafe int NumberNegativePattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NumberNegativePattern_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x060026B8 RID: 9912 RVA: 0x000CDCFC File Offset: 0x000CBEFC
		public unsafe int PercentPositivePattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentPositivePattern_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x060026B9 RID: 9913 RVA: 0x000CDD38 File Offset: 0x000CBF38
		public unsafe int PercentNegativePattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentNegativePattern_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x060026BA RID: 9914 RVA: 0x000CDD74 File Offset: 0x000CBF74
		public unsafe string NegativeInfinitySymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NegativeInfinitySymbol_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x060026BB RID: 9915 RVA: 0x000CDDAC File Offset: 0x000CBFAC
		public unsafe string NegativeSign
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NegativeSign_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x060026BC RID: 9916 RVA: 0x000CDDE4 File Offset: 0x000CBFE4
		public unsafe int NumberDecimalDigits
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NumberDecimalDigits_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x060026BD RID: 9917 RVA: 0x000CDE20 File Offset: 0x000CC020
		public unsafe string NumberDecimalSeparator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NumberDecimalSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x060026BE RID: 9918 RVA: 0x000CDE58 File Offset: 0x000CC058
		public unsafe string NumberGroupSeparator
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NumberGroupSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x060026BF RID: 9919 RVA: 0x000CDE90 File Offset: 0x000CC090
		public unsafe int CurrencyPositivePattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyPositivePattern_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x060026C0 RID: 9920 RVA: 0x000CDECC File Offset: 0x000CC0CC
		public unsafe string PositiveInfinitySymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PositiveInfinitySymbol_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x060026C1 RID: 9921 RVA: 0x000CDF04 File Offset: 0x000CC104
		public unsafe string PositiveSign
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PositiveSign_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x060026C2 RID: 9922 RVA: 0x000CDF3C File Offset: 0x000CC13C
		public unsafe int PercentDecimalDigits
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentDecimalDigits_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x000CDF78 File Offset: 0x000CC178
		public unsafe string PercentDecimalSeparator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentDecimalSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x060026C4 RID: 9924 RVA: 0x000CDFB0 File Offset: 0x000CC1B0
		public unsafe string PercentGroupSeparator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentGroupSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x000CDFE8 File Offset: 0x000CC1E8
		public unsafe string PercentSymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentSymbol_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x060026C6 RID: 9926 RVA: 0x000CE020 File Offset: 0x000CC220
		public unsafe string PerMilleSymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PerMilleSymbol_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x000CE058 File Offset: 0x000CC258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327494, XrefRangeEnd = 327501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetFormat(Type formatType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x000CE0A8 File Offset: 0x000CC2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327501, XrefRangeEnd = 327504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NumberFormatInfo ReadOnly(NumberFormatInfo nfi)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nfi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_ReadOnly_Public_Static_NumberFormatInfo_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x000CE0EC File Offset: 0x000CC2EC
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 327504, RefRangeEnd = 327522, XrefRangeStart = 327504, XrefRangeEnd = 327504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateParseStyleInteger(NumberStyles style)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_ValidateParseStyleInteger_Internal_Static_Void_NumberStyles_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x000CE120 File Offset: 0x000CC320
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 327522, RefRangeEnd = 327528, XrefRangeStart = 327522, XrefRangeEnd = 327522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateParseStyleFloatingPoint(NumberStyles style)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_ValidateParseStyleFloatingPoint_Internal_Static_Void_NumberStyles_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x0000D371 File Offset: 0x0000B571
		public NumberFormatInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x060026CC RID: 9932 RVA: 0x000CE154 File Offset: 0x000CC354
		// (set) Token: 0x060026CD RID: 9933 RVA: 0x0000D37A File Offset: 0x0000B57A
		public unsafe static NumberFormatInfo invariantInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatInfo.NativeFieldInfoPtr_invariantInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatInfo.NativeFieldInfoPtr_invariantInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x060026CE RID: 9934 RVA: 0x000CE17C File Offset: 0x000CC37C
		// (set) Token: 0x060026CF RID: 9935 RVA: 0x0000D38C File Offset: 0x0000B58C
		public unsafe Il2CppStructArray<int> numberGroupSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberGroupSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberGroupSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x060026D0 RID: 9936 RVA: 0x000CE1AC File Offset: 0x000CC3AC
		// (set) Token: 0x060026D1 RID: 9937 RVA: 0x0000D3AB File Offset: 0x0000B5AB
		public unsafe Il2CppStructArray<int> currencyGroupSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyGroupSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyGroupSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x060026D2 RID: 9938 RVA: 0x000CE1DC File Offset: 0x000CC3DC
		// (set) Token: 0x060026D3 RID: 9939 RVA: 0x0000D3CA File Offset: 0x0000B5CA
		public unsafe Il2CppStructArray<int> percentGroupSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentGroupSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentGroupSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x060026D4 RID: 9940 RVA: 0x000CE20C File Offset: 0x000CC40C
		// (set) Token: 0x060026D5 RID: 9941 RVA: 0x0000D3E9 File Offset: 0x0000B5E9
		public unsafe string positiveSign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_positiveSign);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_positiveSign), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x060026D6 RID: 9942 RVA: 0x000CE234 File Offset: 0x000CC434
		// (set) Token: 0x060026D7 RID: 9943 RVA: 0x0000D408 File Offset: 0x0000B608
		public unsafe string negativeSign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_negativeSign);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_negativeSign), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x060026D8 RID: 9944 RVA: 0x000CE25C File Offset: 0x000CC45C
		// (set) Token: 0x060026D9 RID: 9945 RVA: 0x0000D427 File Offset: 0x0000B627
		public unsafe string numberDecimalSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberDecimalSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberDecimalSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x060026DA RID: 9946 RVA: 0x000CE284 File Offset: 0x000CC484
		// (set) Token: 0x060026DB RID: 9947 RVA: 0x0000D446 File Offset: 0x0000B646
		public unsafe string numberGroupSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberGroupSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberGroupSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x060026DC RID: 9948 RVA: 0x000CE2AC File Offset: 0x000CC4AC
		// (set) Token: 0x060026DD RID: 9949 RVA: 0x0000D465 File Offset: 0x0000B665
		public unsafe string currencyGroupSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyGroupSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyGroupSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x060026DE RID: 9950 RVA: 0x000CE2D4 File Offset: 0x000CC4D4
		// (set) Token: 0x060026DF RID: 9951 RVA: 0x0000D484 File Offset: 0x0000B684
		public unsafe string currencyDecimalSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyDecimalSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyDecimalSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x060026E0 RID: 9952 RVA: 0x000CE2FC File Offset: 0x000CC4FC
		// (set) Token: 0x060026E1 RID: 9953 RVA: 0x0000D4A3 File Offset: 0x0000B6A3
		public unsafe string currencySymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencySymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencySymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x060026E2 RID: 9954 RVA: 0x000CE324 File Offset: 0x000CC524
		// (set) Token: 0x060026E3 RID: 9955 RVA: 0x0000D4C2 File Offset: 0x0000B6C2
		public unsafe string ansiCurrencySymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_ansiCurrencySymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_ansiCurrencySymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x060026E4 RID: 9956 RVA: 0x000CE34C File Offset: 0x000CC54C
		// (set) Token: 0x060026E5 RID: 9957 RVA: 0x0000D4E1 File Offset: 0x0000B6E1
		public unsafe string nanSymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_nanSymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_nanSymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x060026E6 RID: 9958 RVA: 0x000CE374 File Offset: 0x000CC574
		// (set) Token: 0x060026E7 RID: 9959 RVA: 0x0000D500 File Offset: 0x0000B700
		public unsafe string positiveInfinitySymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_positiveInfinitySymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_positiveInfinitySymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x060026E8 RID: 9960 RVA: 0x000CE39C File Offset: 0x000CC59C
		// (set) Token: 0x060026E9 RID: 9961 RVA: 0x0000D51F File Offset: 0x0000B71F
		public unsafe string negativeInfinitySymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_negativeInfinitySymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_negativeInfinitySymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x060026EA RID: 9962 RVA: 0x000CE3C4 File Offset: 0x000CC5C4
		// (set) Token: 0x060026EB RID: 9963 RVA: 0x0000D53E File Offset: 0x0000B73E
		public unsafe string percentDecimalSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentDecimalSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentDecimalSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x060026EC RID: 9964 RVA: 0x000CE3EC File Offset: 0x000CC5EC
		// (set) Token: 0x060026ED RID: 9965 RVA: 0x0000D55D File Offset: 0x0000B75D
		public unsafe string percentGroupSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentGroupSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentGroupSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x060026EE RID: 9966 RVA: 0x000CE414 File Offset: 0x000CC614
		// (set) Token: 0x060026EF RID: 9967 RVA: 0x0000D57C File Offset: 0x0000B77C
		public unsafe string percentSymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentSymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentSymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x060026F0 RID: 9968 RVA: 0x000CE43C File Offset: 0x000CC63C
		// (set) Token: 0x060026F1 RID: 9969 RVA: 0x0000D59B File Offset: 0x0000B79B
		public unsafe string perMilleSymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_perMilleSymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_perMilleSymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x060026F2 RID: 9970 RVA: 0x000CE464 File Offset: 0x000CC664
		// (set) Token: 0x060026F3 RID: 9971 RVA: 0x0000D5BA File Offset: 0x0000B7BA
		public unsafe Il2CppStringArray nativeDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_nativeDigits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_nativeDigits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x060026F4 RID: 9972 RVA: 0x000CE494 File Offset: 0x000CC694
		// (set) Token: 0x060026F5 RID: 9973 RVA: 0x0000D5D9 File Offset: 0x0000B7D9
		public unsafe int m_dataItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_m_dataItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_m_dataItem)) = value;
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x060026F6 RID: 9974 RVA: 0x000CE4BC File Offset: 0x000CC6BC
		// (set) Token: 0x060026F7 RID: 9975 RVA: 0x0000D5F4 File Offset: 0x0000B7F4
		public unsafe int numberDecimalDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberDecimalDigits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberDecimalDigits)) = value;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x060026F8 RID: 9976 RVA: 0x000CE4E4 File Offset: 0x000CC6E4
		// (set) Token: 0x060026F9 RID: 9977 RVA: 0x0000D60F File Offset: 0x0000B80F
		public unsafe int currencyDecimalDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyDecimalDigits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyDecimalDigits)) = value;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x060026FA RID: 9978 RVA: 0x000CE50C File Offset: 0x000CC70C
		// (set) Token: 0x060026FB RID: 9979 RVA: 0x0000D62A File Offset: 0x0000B82A
		public unsafe int currencyPositivePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyPositivePattern);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyPositivePattern)) = value;
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x060026FC RID: 9980 RVA: 0x000CE534 File Offset: 0x000CC734
		// (set) Token: 0x060026FD RID: 9981 RVA: 0x0000D645 File Offset: 0x0000B845
		public unsafe int currencyNegativePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyNegativePattern);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyNegativePattern)) = value;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x060026FE RID: 9982 RVA: 0x000CE55C File Offset: 0x000CC75C
		// (set) Token: 0x060026FF RID: 9983 RVA: 0x0000D660 File Offset: 0x0000B860
		public unsafe int numberNegativePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberNegativePattern);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberNegativePattern)) = value;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06002700 RID: 9984 RVA: 0x000CE584 File Offset: 0x000CC784
		// (set) Token: 0x06002701 RID: 9985 RVA: 0x0000D67B File Offset: 0x0000B87B
		public unsafe int percentPositivePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentPositivePattern);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentPositivePattern)) = value;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06002702 RID: 9986 RVA: 0x000CE5AC File Offset: 0x000CC7AC
		// (set) Token: 0x06002703 RID: 9987 RVA: 0x0000D696 File Offset: 0x0000B896
		public unsafe int percentNegativePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentNegativePattern);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentNegativePattern)) = value;
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06002704 RID: 9988 RVA: 0x000CE5D4 File Offset: 0x000CC7D4
		// (set) Token: 0x06002705 RID: 9989 RVA: 0x0000D6B1 File Offset: 0x0000B8B1
		public unsafe int percentDecimalDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentDecimalDigits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentDecimalDigits)) = value;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06002706 RID: 9990 RVA: 0x000CE5FC File Offset: 0x000CC7FC
		// (set) Token: 0x06002707 RID: 9991 RVA: 0x0000D6CC File Offset: 0x0000B8CC
		public unsafe int digitSubstitution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_digitSubstitution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_digitSubstitution)) = value;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06002708 RID: 9992 RVA: 0x000CE624 File Offset: 0x000CC824
		// (set) Token: 0x06002709 RID: 9993 RVA: 0x0000D6E7 File Offset: 0x0000B8E7
		public unsafe bool isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_isReadOnly)) = value;
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x0600270A RID: 9994 RVA: 0x000CE64C File Offset: 0x000CC84C
		// (set) Token: 0x0600270B RID: 9995 RVA: 0x0000D702 File Offset: 0x0000B902
		public unsafe bool m_useUserOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_m_useUserOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_m_useUserOverride)) = value;
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x0600270C RID: 9996 RVA: 0x000CE674 File Offset: 0x000CC874
		// (set) Token: 0x0600270D RID: 9997 RVA: 0x0000D71D File Offset: 0x0000B91D
		public unsafe bool m_isInvariant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_m_isInvariant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_m_isInvariant)) = value;
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x0600270E RID: 9998 RVA: 0x000CE69C File Offset: 0x000CC89C
		// (set) Token: 0x0600270F RID: 9999 RVA: 0x0000D738 File Offset: 0x0000B938
		public unsafe bool validForParseAsNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_validForParseAsNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_validForParseAsNumber)) = value;
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06002710 RID: 10000 RVA: 0x000CE6C4 File Offset: 0x000CC8C4
		// (set) Token: 0x06002711 RID: 10001 RVA: 0x0000D753 File Offset: 0x0000B953
		public unsafe bool validForParseAsCurrency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_validForParseAsCurrency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_validForParseAsCurrency)) = value;
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06002712 RID: 10002 RVA: 0x000CE6EC File Offset: 0x000CC8EC
		// (set) Token: 0x06002713 RID: 10003 RVA: 0x0000D76E File Offset: 0x0000B96E
		public unsafe static NumberStyles InvalidNumberStyles
		{
			get
			{
				NumberStyles numberStyles;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatInfo.NativeFieldInfoPtr_InvalidNumberStyles, (void*)(&numberStyles));
				return numberStyles;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatInfo.NativeFieldInfoPtr_InvalidNumberStyles, (void*)(&value));
			}
		}

		// Token: 0x04002266 RID: 8806
		private static readonly IntPtr NativeFieldInfoPtr_invariantInfo;

		// Token: 0x04002267 RID: 8807
		private static readonly IntPtr NativeFieldInfoPtr_numberGroupSizes;

		// Token: 0x04002268 RID: 8808
		private static readonly IntPtr NativeFieldInfoPtr_currencyGroupSizes;

		// Token: 0x04002269 RID: 8809
		private static readonly IntPtr NativeFieldInfoPtr_percentGroupSizes;

		// Token: 0x0400226A RID: 8810
		private static readonly IntPtr NativeFieldInfoPtr_positiveSign;

		// Token: 0x0400226B RID: 8811
		private static readonly IntPtr NativeFieldInfoPtr_negativeSign;

		// Token: 0x0400226C RID: 8812
		private static readonly IntPtr NativeFieldInfoPtr_numberDecimalSeparator;

		// Token: 0x0400226D RID: 8813
		private static readonly IntPtr NativeFieldInfoPtr_numberGroupSeparator;

		// Token: 0x0400226E RID: 8814
		private static readonly IntPtr NativeFieldInfoPtr_currencyGroupSeparator;

		// Token: 0x0400226F RID: 8815
		private static readonly IntPtr NativeFieldInfoPtr_currencyDecimalSeparator;

		// Token: 0x04002270 RID: 8816
		private static readonly IntPtr NativeFieldInfoPtr_currencySymbol;

		// Token: 0x04002271 RID: 8817
		private static readonly IntPtr NativeFieldInfoPtr_ansiCurrencySymbol;

		// Token: 0x04002272 RID: 8818
		private static readonly IntPtr NativeFieldInfoPtr_nanSymbol;

		// Token: 0x04002273 RID: 8819
		private static readonly IntPtr NativeFieldInfoPtr_positiveInfinitySymbol;

		// Token: 0x04002274 RID: 8820
		private static readonly IntPtr NativeFieldInfoPtr_negativeInfinitySymbol;

		// Token: 0x04002275 RID: 8821
		private static readonly IntPtr NativeFieldInfoPtr_percentDecimalSeparator;

		// Token: 0x04002276 RID: 8822
		private static readonly IntPtr NativeFieldInfoPtr_percentGroupSeparator;

		// Token: 0x04002277 RID: 8823
		private static readonly IntPtr NativeFieldInfoPtr_percentSymbol;

		// Token: 0x04002278 RID: 8824
		private static readonly IntPtr NativeFieldInfoPtr_perMilleSymbol;

		// Token: 0x04002279 RID: 8825
		private static readonly IntPtr NativeFieldInfoPtr_nativeDigits;

		// Token: 0x0400227A RID: 8826
		private static readonly IntPtr NativeFieldInfoPtr_m_dataItem;

		// Token: 0x0400227B RID: 8827
		private static readonly IntPtr NativeFieldInfoPtr_numberDecimalDigits;

		// Token: 0x0400227C RID: 8828
		private static readonly IntPtr NativeFieldInfoPtr_currencyDecimalDigits;

		// Token: 0x0400227D RID: 8829
		private static readonly IntPtr NativeFieldInfoPtr_currencyPositivePattern;

		// Token: 0x0400227E RID: 8830
		private static readonly IntPtr NativeFieldInfoPtr_currencyNegativePattern;

		// Token: 0x0400227F RID: 8831
		private static readonly IntPtr NativeFieldInfoPtr_numberNegativePattern;

		// Token: 0x04002280 RID: 8832
		private static readonly IntPtr NativeFieldInfoPtr_percentPositivePattern;

		// Token: 0x04002281 RID: 8833
		private static readonly IntPtr NativeFieldInfoPtr_percentNegativePattern;

		// Token: 0x04002282 RID: 8834
		private static readonly IntPtr NativeFieldInfoPtr_percentDecimalDigits;

		// Token: 0x04002283 RID: 8835
		private static readonly IntPtr NativeFieldInfoPtr_digitSubstitution;

		// Token: 0x04002284 RID: 8836
		private static readonly IntPtr NativeFieldInfoPtr_isReadOnly;

		// Token: 0x04002285 RID: 8837
		private static readonly IntPtr NativeFieldInfoPtr_m_useUserOverride;

		// Token: 0x04002286 RID: 8838
		private static readonly IntPtr NativeFieldInfoPtr_m_isInvariant;

		// Token: 0x04002287 RID: 8839
		private static readonly IntPtr NativeFieldInfoPtr_validForParseAsNumber;

		// Token: 0x04002288 RID: 8840
		private static readonly IntPtr NativeFieldInfoPtr_validForParseAsCurrency;

		// Token: 0x04002289 RID: 8841
		private static readonly IntPtr NativeFieldInfoPtr_InvalidNumberStyles;

		// Token: 0x0400228A RID: 8842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400228B RID: 8843
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0;

		// Token: 0x0400228C RID: 8844
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0;

		// Token: 0x0400228D RID: 8845
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x0400228E RID: 8846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CultureData_0;

		// Token: 0x0400228F RID: 8847
		private static readonly IntPtr NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_NumberFormatInfo_0;

		// Token: 0x04002290 RID: 8848
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Public_Static_NumberFormatInfo_IFormatProvider_0;

		// Token: 0x04002291 RID: 8849
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04002292 RID: 8850
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyDecimalDigits_Public_get_Int32_0;

		// Token: 0x04002293 RID: 8851
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyDecimalSeparator_Public_get_String_0;

		// Token: 0x04002294 RID: 8852
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0;

		// Token: 0x04002295 RID: 8853
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyGroupSizes_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002296 RID: 8854
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberGroupSizes_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002297 RID: 8855
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentGroupSizes_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002298 RID: 8856
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyGroupSeparator_Public_get_String_0;

		// Token: 0x04002299 RID: 8857
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencySymbol_Public_get_String_0;

		// Token: 0x0400229A RID: 8858
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_NumberFormatInfo_0;

		// Token: 0x0400229B RID: 8859
		private static readonly IntPtr NativeMethodInfoPtr_get_NaNSymbol_Public_get_String_0;

		// Token: 0x0400229C RID: 8860
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyNegativePattern_Public_get_Int32_0;

		// Token: 0x0400229D RID: 8861
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberNegativePattern_Public_get_Int32_0;

		// Token: 0x0400229E RID: 8862
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentPositivePattern_Public_get_Int32_0;

		// Token: 0x0400229F RID: 8863
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentNegativePattern_Public_get_Int32_0;

		// Token: 0x040022A0 RID: 8864
		private static readonly IntPtr NativeMethodInfoPtr_get_NegativeInfinitySymbol_Public_get_String_0;

		// Token: 0x040022A1 RID: 8865
		private static readonly IntPtr NativeMethodInfoPtr_get_NegativeSign_Public_get_String_0;

		// Token: 0x040022A2 RID: 8866
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberDecimalDigits_Public_get_Int32_0;

		// Token: 0x040022A3 RID: 8867
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberDecimalSeparator_Public_get_String_0;

		// Token: 0x040022A4 RID: 8868
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberGroupSeparator_Public_get_String_0;

		// Token: 0x040022A5 RID: 8869
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyPositivePattern_Public_get_Int32_0;

		// Token: 0x040022A6 RID: 8870
		private static readonly IntPtr NativeMethodInfoPtr_get_PositiveInfinitySymbol_Public_get_String_0;

		// Token: 0x040022A7 RID: 8871
		private static readonly IntPtr NativeMethodInfoPtr_get_PositiveSign_Public_get_String_0;

		// Token: 0x040022A8 RID: 8872
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentDecimalDigits_Public_get_Int32_0;

		// Token: 0x040022A9 RID: 8873
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentDecimalSeparator_Public_get_String_0;

		// Token: 0x040022AA RID: 8874
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentGroupSeparator_Public_get_String_0;

		// Token: 0x040022AB RID: 8875
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentSymbol_Public_get_String_0;

		// Token: 0x040022AC RID: 8876
		private static readonly IntPtr NativeMethodInfoPtr_get_PerMilleSymbol_Public_get_String_0;

		// Token: 0x040022AD RID: 8877
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0;

		// Token: 0x040022AE RID: 8878
		private static readonly IntPtr NativeMethodInfoPtr_ReadOnly_Public_Static_NumberFormatInfo_NumberFormatInfo_0;

		// Token: 0x040022AF RID: 8879
		private static readonly IntPtr NativeMethodInfoPtr_ValidateParseStyleInteger_Internal_Static_Void_NumberStyles_0;

		// Token: 0x040022B0 RID: 8880
		private static readonly IntPtr NativeMethodInfoPtr_ValidateParseStyleFloatingPoint_Internal_Static_Void_NumberStyles_0;
	}
}

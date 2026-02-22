using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200008D RID: 141
	public class DatatypeImplementation : XmlSchemaDatatype
	{
		// Token: 0x060009B3 RID: 2483 RVA: 0x00032018 File Offset: 0x00030218
		// Note: this type is marked as 'beforefieldinit'.
		static DatatypeImplementation()
		{
			Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "DatatypeImplementation");
			DatatypeImplementation.NativeFieldInfoPtr_variety = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "variety");
			DatatypeImplementation.NativeFieldInfoPtr_restriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "restriction");
			DatatypeImplementation.NativeFieldInfoPtr_baseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "baseType");
			DatatypeImplementation.NativeFieldInfoPtr_valueConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "valueConverter");
			DatatypeImplementation.NativeFieldInfoPtr_parentSchemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "parentSchemaType");
			DatatypeImplementation.NativeFieldInfoPtr_builtinTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "builtinTypes");
			DatatypeImplementation.NativeFieldInfoPtr_enumToTypeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "enumToTypeCode");
			DatatypeImplementation.NativeFieldInfoPtr_anySimpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "anySimpleType");
			DatatypeImplementation.NativeFieldInfoPtr_anyAtomicType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "anyAtomicType");
			DatatypeImplementation.NativeFieldInfoPtr_untypedAtomicType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "untypedAtomicType");
			DatatypeImplementation.NativeFieldInfoPtr_yearMonthDurationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "yearMonthDurationType");
			DatatypeImplementation.NativeFieldInfoPtr_dayTimeDurationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "dayTimeDurationType");
			DatatypeImplementation.NativeFieldInfoPtr_QnAnySimpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "QnAnySimpleType");
			DatatypeImplementation.NativeFieldInfoPtr_QnAnyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "QnAnyType");
			DatatypeImplementation.NativeFieldInfoPtr_stringFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "stringFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_miscFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "miscFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_numeric2FacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "numeric2FacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_binaryFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "binaryFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_dateTimeFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "dateTimeFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_durationFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "durationFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_listFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "listFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_qnameFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "qnameFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_unionFacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "unionFacetsChecker");
			DatatypeImplementation.NativeFieldInfoPtr_c_anySimpleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_anySimpleType");
			DatatypeImplementation.NativeFieldInfoPtr_c_anyURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_anyURI");
			DatatypeImplementation.NativeFieldInfoPtr_c_base64Binary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_base64Binary");
			DatatypeImplementation.NativeFieldInfoPtr_c_boolean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_boolean");
			DatatypeImplementation.NativeFieldInfoPtr_c_byte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_byte");
			DatatypeImplementation.NativeFieldInfoPtr_c_char = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_char");
			DatatypeImplementation.NativeFieldInfoPtr_c_date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_date");
			DatatypeImplementation.NativeFieldInfoPtr_c_dateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_dateTime");
			DatatypeImplementation.NativeFieldInfoPtr_c_dateTimeNoTz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_dateTimeNoTz");
			DatatypeImplementation.NativeFieldInfoPtr_c_dateTimeTz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_dateTimeTz");
			DatatypeImplementation.NativeFieldInfoPtr_c_day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_day");
			DatatypeImplementation.NativeFieldInfoPtr_c_decimal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_decimal");
			DatatypeImplementation.NativeFieldInfoPtr_c_double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_double");
			DatatypeImplementation.NativeFieldInfoPtr_c_doubleXdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_doubleXdr");
			DatatypeImplementation.NativeFieldInfoPtr_c_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_duration");
			DatatypeImplementation.NativeFieldInfoPtr_c_ENTITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_ENTITY");
			DatatypeImplementation.NativeFieldInfoPtr_c_ENTITIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_ENTITIES");
			DatatypeImplementation.NativeFieldInfoPtr_c_ENUMERATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_ENUMERATION");
			DatatypeImplementation.NativeFieldInfoPtr_c_fixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_fixed");
			DatatypeImplementation.NativeFieldInfoPtr_c_float = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_float");
			DatatypeImplementation.NativeFieldInfoPtr_c_floatXdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_floatXdr");
			DatatypeImplementation.NativeFieldInfoPtr_c_hexBinary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_hexBinary");
			DatatypeImplementation.NativeFieldInfoPtr_c_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_ID");
			DatatypeImplementation.NativeFieldInfoPtr_c_IDREF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_IDREF");
			DatatypeImplementation.NativeFieldInfoPtr_c_IDREFS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_IDREFS");
			DatatypeImplementation.NativeFieldInfoPtr_c_int = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_int");
			DatatypeImplementation.NativeFieldInfoPtr_c_integer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_integer");
			DatatypeImplementation.NativeFieldInfoPtr_c_language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_language");
			DatatypeImplementation.NativeFieldInfoPtr_c_long = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_long");
			DatatypeImplementation.NativeFieldInfoPtr_c_month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_month");
			DatatypeImplementation.NativeFieldInfoPtr_c_monthDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_monthDay");
			DatatypeImplementation.NativeFieldInfoPtr_c_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_Name");
			DatatypeImplementation.NativeFieldInfoPtr_c_NCName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_NCName");
			DatatypeImplementation.NativeFieldInfoPtr_c_negativeInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_negativeInteger");
			DatatypeImplementation.NativeFieldInfoPtr_c_NMTOKEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_NMTOKEN");
			DatatypeImplementation.NativeFieldInfoPtr_c_NMTOKENS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_NMTOKENS");
			DatatypeImplementation.NativeFieldInfoPtr_c_nonNegativeInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_nonNegativeInteger");
			DatatypeImplementation.NativeFieldInfoPtr_c_nonPositiveInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_nonPositiveInteger");
			DatatypeImplementation.NativeFieldInfoPtr_c_normalizedString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_normalizedString");
			DatatypeImplementation.NativeFieldInfoPtr_c_NOTATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_NOTATION");
			DatatypeImplementation.NativeFieldInfoPtr_c_positiveInteger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_positiveInteger");
			DatatypeImplementation.NativeFieldInfoPtr_c_QName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_QName");
			DatatypeImplementation.NativeFieldInfoPtr_c_QNameXdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_QNameXdr");
			DatatypeImplementation.NativeFieldInfoPtr_c_short = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_short");
			DatatypeImplementation.NativeFieldInfoPtr_c_string = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_string");
			DatatypeImplementation.NativeFieldInfoPtr_c_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_time");
			DatatypeImplementation.NativeFieldInfoPtr_c_timeNoTz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_timeNoTz");
			DatatypeImplementation.NativeFieldInfoPtr_c_timeTz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_timeTz");
			DatatypeImplementation.NativeFieldInfoPtr_c_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_token");
			DatatypeImplementation.NativeFieldInfoPtr_c_unsignedByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_unsignedByte");
			DatatypeImplementation.NativeFieldInfoPtr_c_unsignedInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_unsignedInt");
			DatatypeImplementation.NativeFieldInfoPtr_c_unsignedLong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_unsignedLong");
			DatatypeImplementation.NativeFieldInfoPtr_c_unsignedShort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_unsignedShort");
			DatatypeImplementation.NativeFieldInfoPtr_c_uuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_uuid");
			DatatypeImplementation.NativeFieldInfoPtr_c_year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_year");
			DatatypeImplementation.NativeFieldInfoPtr_c_yearMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_yearMonth");
			DatatypeImplementation.NativeFieldInfoPtr_c_normalizedStringV1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_normalizedStringV1Compat");
			DatatypeImplementation.NativeFieldInfoPtr_c_tokenV1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_tokenV1Compat");
			DatatypeImplementation.NativeFieldInfoPtr_c_anyAtomicType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_anyAtomicType");
			DatatypeImplementation.NativeFieldInfoPtr_c_dayTimeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_dayTimeDuration");
			DatatypeImplementation.NativeFieldInfoPtr_c_untypedAtomicType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_untypedAtomicType");
			DatatypeImplementation.NativeFieldInfoPtr_c_yearMonthDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_yearMonthDuration");
			DatatypeImplementation.NativeFieldInfoPtr_c_tokenizedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_tokenizedTypes");
			DatatypeImplementation.NativeFieldInfoPtr_c_tokenizedTypesXsd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_tokenizedTypesXsd");
			DatatypeImplementation.NativeFieldInfoPtr_c_XdrTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_XdrTypes");
			DatatypeImplementation.NativeFieldInfoPtr_c_XsdTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "c_XsdTypes");
			DatatypeImplementation.NativeMethodInfoPtr_get_AnySimpleType_Internal_Static_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664809);
			DatatypeImplementation.NativeMethodInfoPtr_get_UntypedAtomicType_Internal_Static_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664810);
			DatatypeImplementation.NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_DatatypeImplementation_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664811);
			DatatypeImplementation.NativeMethodInfoPtr_FromTypeName_Private_Static_DatatypeImplementation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664812);
			DatatypeImplementation.NativeMethodInfoPtr_StartBuiltinType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664813);
			DatatypeImplementation.NativeMethodInfoPtr_FinishBuiltinType_Internal_Static_Void_XmlSchemaSimpleType_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664814);
			DatatypeImplementation.NativeMethodInfoPtr_CreateBuiltinTypes_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664815);
			DatatypeImplementation.NativeMethodInfoPtr_GetSimpleTypeFromTypeCode_Internal_Static_XmlSchemaSimpleType_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664816);
			DatatypeImplementation.NativeMethodInfoPtr_DeriveByList_Internal_XmlSchemaDatatype_Int32_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664817);
			DatatypeImplementation.NativeMethodInfoPtr_IsEqual_Internal_Virtual_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664818);
			DatatypeImplementation.NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_New_XmlValueConverter_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664819);
			DatatypeImplementation.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664820);
			DatatypeImplementation.NativeMethodInfoPtr_get_ValueConverter_Internal_Virtual_get_XmlValueConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664821);
			DatatypeImplementation.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664822);
			DatatypeImplementation.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664823);
			DatatypeImplementation.NativeMethodInfoPtr_get_Variety_Public_Virtual_get_XmlSchemaDatatypeVariety_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664824);
			DatatypeImplementation.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664825);
			DatatypeImplementation.NativeMethodInfoPtr_get_Restriction_Internal_Virtual_get_RestrictionFacets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664826);
			DatatypeImplementation.NativeMethodInfoPtr_get_ListValueType_Internal_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664827);
			DatatypeImplementation.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664828);
			DatatypeImplementation.NativeMethodInfoPtr_ParseValue_Public_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664829);
			DatatypeImplementation.NativeMethodInfoPtr_GetTypeName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664830);
			DatatypeImplementation.NativeMethodInfoPtr_Compare_Protected_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664831);
			DatatypeImplementation.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, 100664832);
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x00032914 File Offset: 0x00030B14
		public unsafe static XmlSchemaSimpleType AnySimpleType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22073, XrefRangeEnd = 22077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_get_AnySimpleType_Internal_Static_get_XmlSchemaSimpleType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x00032948 File Offset: 0x00030B48
		public unsafe static XmlSchemaSimpleType UntypedAtomicType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22077, XrefRangeEnd = 22081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_get_UntypedAtomicType_Internal_Static_get_XmlSchemaSimpleType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0003297C File Offset: 0x00030B7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22085, RefRangeEnd = 22086, XrefRangeStart = 22081, XrefRangeEnd = 22085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_DatatypeImplementation_XmlTokenizedType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr3) : null;
			}
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x000329BC File Offset: 0x00030BBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 22091, RefRangeEnd = 22093, XrefRangeStart = 22086, XrefRangeEnd = 22091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DatatypeImplementation FromTypeName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_FromTypeName_Private_Static_DatatypeImplementation_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr3) : null;
			}
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00032A00 File Offset: 0x00030C00
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 22104, RefRangeEnd = 22110, XrefRangeStart = 22093, XrefRangeEnd = 22104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dataType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_StartBuiltinType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_XmlSchemaDatatype_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00032A58 File Offset: 0x00030C58
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 22132, RefRangeEnd = 22136, XrefRangeStart = 22110, XrefRangeEnd = 22132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_FinishBuiltinType_Internal_Static_Void_XmlSchemaSimpleType_XmlSchemaSimpleType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00032AA0 File Offset: 0x00030CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22136, XrefRangeEnd = 22301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateBuiltinTypes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_CreateBuiltinTypes_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00032AC8 File Offset: 0x00030CC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22305, RefRangeEnd = 22306, XrefRangeStart = 22301, XrefRangeEnd = 22305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_GetSimpleTypeFromTypeCode_Internal_Static_XmlSchemaSimpleType_XmlTypeCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00032B08 File Offset: 0x00030D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22306, XrefRangeEnd = 22323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minSize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_DeriveByList_Internal_XmlSchemaDatatype_Int32_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00032B68 File Offset: 0x00030D68
		[CallerCount(0)]
		public unsafe override bool IsEqual(Object o1, Object o2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_IsEqual_Internal_Virtual_Boolean_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00032BD4 File Offset: 0x00030DD4
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_New_XmlValueConverter_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x00032C30 File Offset: 0x00030E30
		public unsafe override FacetsChecker FacetsChecker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22323, XrefRangeEnd = 22327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr3) : null;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x00032C7C File Offset: 0x00030E7C
		public unsafe override XmlValueConverter ValueConverter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_ValueConverter_Internal_Virtual_get_XmlValueConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00032CC8 File Offset: 0x00030EC8
		public unsafe override XmlTokenizedType TokenizedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x00032D10 File Offset: 0x00030F10
		public unsafe override Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22327, XrefRangeEnd = 22333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x00032D5C File Offset: 0x00030F5C
		public unsafe override XmlSchemaDatatypeVariety Variety
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_Variety_Public_Virtual_get_XmlSchemaDatatypeVariety_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x00032DA4 File Offset: 0x00030FA4
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00032DEC File Offset: 0x00030FEC
		public unsafe override RestrictionFacets Restriction
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_Restriction_Internal_Virtual_get_RestrictionFacets_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RestrictionFacets>(intPtr3) : null;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x00032E38 File Offset: 0x00031038
		public unsafe virtual Type ListValueType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_ListValueType_Internal_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x00032E84 File Offset: 0x00031084
		public unsafe override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00032ECC File Offset: 0x000310CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22333, XrefRangeEnd = 22334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DatatypeImplementation.NativeMethodInfoPtr_ParseValue_Public_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00032F4C File Offset: 0x0003114C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22334, XrefRangeEnd = 22338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTypeName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_GetTypeName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00032F84 File Offset: 0x00031184
		[CallerCount(0)]
		public unsafe int Compare(Il2CppStructArray<byte> value1, Il2CppStructArray<byte> value2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr_Compare_Protected_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00032FE4 File Offset: 0x000311E4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DatatypeImplementation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0000540B File Offset: 0x0000360B
		public DatatypeImplementation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x00033020 File Offset: 0x00031220
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x00005414 File Offset: 0x00003614
		public unsafe XmlSchemaDatatypeVariety variety
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_variety);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_variety)) = value;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x00033048 File Offset: 0x00031248
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x0000542F File Offset: 0x0000362F
		public unsafe RestrictionFacets restriction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_restriction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RestrictionFacets>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_restriction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x00033078 File Offset: 0x00031278
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x0000544E File Offset: 0x0000364E
		public unsafe DatatypeImplementation baseType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_baseType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_baseType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x000330A8 File Offset: 0x000312A8
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x0000546D File Offset: 0x0000366D
		public unsafe XmlValueConverter valueConverter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_valueConverter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_valueConverter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x000330D8 File Offset: 0x000312D8
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x0000548C File Offset: 0x0000368C
		public unsafe XmlSchemaType parentSchemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_parentSchemaType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.NativeFieldInfoPtr_parentSchemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x00033108 File Offset: 0x00031308
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x000054AB File Offset: 0x000036AB
		public unsafe static Hashtable builtinTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_builtinTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_builtinTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x00033130 File Offset: 0x00031330
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x000054BD File Offset: 0x000036BD
		public unsafe static Il2CppReferenceArray<XmlSchemaSimpleType> enumToTypeCode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_enumToTypeCode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlSchemaSimpleType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_enumToTypeCode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x00033158 File Offset: 0x00031358
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x000054CF File Offset: 0x000036CF
		public unsafe static XmlSchemaSimpleType anySimpleType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_anySimpleType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_anySimpleType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x00033180 File Offset: 0x00031380
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x000054E1 File Offset: 0x000036E1
		public unsafe static XmlSchemaSimpleType anyAtomicType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_anyAtomicType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_anyAtomicType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x000331A8 File Offset: 0x000313A8
		// (set) Token: 0x060009E0 RID: 2528 RVA: 0x000054F3 File Offset: 0x000036F3
		public unsafe static XmlSchemaSimpleType untypedAtomicType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_untypedAtomicType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_untypedAtomicType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x000331D0 File Offset: 0x000313D0
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x00005505 File Offset: 0x00003705
		public unsafe static XmlSchemaSimpleType yearMonthDurationType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_yearMonthDurationType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_yearMonthDurationType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x000331F8 File Offset: 0x000313F8
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x00005517 File Offset: 0x00003717
		public unsafe static XmlSchemaSimpleType dayTimeDurationType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_dayTimeDurationType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_dayTimeDurationType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x00033220 File Offset: 0x00031420
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x00005529 File Offset: 0x00003729
		public unsafe static XmlQualifiedName QnAnySimpleType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_QnAnySimpleType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_QnAnySimpleType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x00033248 File Offset: 0x00031448
		// (set) Token: 0x060009E8 RID: 2536 RVA: 0x0000553B File Offset: 0x0000373B
		public unsafe static XmlQualifiedName QnAnyType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_QnAnyType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_QnAnyType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x00033270 File Offset: 0x00031470
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x0000554D File Offset: 0x0000374D
		public unsafe static FacetsChecker stringFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_stringFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_stringFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00033298 File Offset: 0x00031498
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x0000555F File Offset: 0x0000375F
		public unsafe static FacetsChecker miscFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_miscFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_miscFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x000332C0 File Offset: 0x000314C0
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x00005571 File Offset: 0x00003771
		public unsafe static FacetsChecker numeric2FacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_numeric2FacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_numeric2FacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x000332E8 File Offset: 0x000314E8
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x00005583 File Offset: 0x00003783
		public unsafe static FacetsChecker binaryFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_binaryFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_binaryFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x00033310 File Offset: 0x00031510
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x00005595 File Offset: 0x00003795
		public unsafe static FacetsChecker dateTimeFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_dateTimeFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_dateTimeFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x00033338 File Offset: 0x00031538
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x000055A7 File Offset: 0x000037A7
		public unsafe static FacetsChecker durationFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_durationFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_durationFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x00033360 File Offset: 0x00031560
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x000055B9 File Offset: 0x000037B9
		public unsafe static FacetsChecker listFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_listFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_listFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x00033388 File Offset: 0x00031588
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x000055CB File Offset: 0x000037CB
		public unsafe static FacetsChecker qnameFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_qnameFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_qnameFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x000333B0 File Offset: 0x000315B0
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x000055DD File Offset: 0x000037DD
		public unsafe static FacetsChecker unionFacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_unionFacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_unionFacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x000333D8 File Offset: 0x000315D8
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x000055EF File Offset: 0x000037EF
		public unsafe static DatatypeImplementation c_anySimpleType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_anySimpleType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_anySimpleType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00033400 File Offset: 0x00031600
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x00005601 File Offset: 0x00003801
		public unsafe static DatatypeImplementation c_anyURI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_anyURI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_anyURI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x00033428 File Offset: 0x00031628
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x00005613 File Offset: 0x00003813
		public unsafe static DatatypeImplementation c_base64Binary
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_base64Binary, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_base64Binary, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x00033450 File Offset: 0x00031650
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x00005625 File Offset: 0x00003825
		public unsafe static DatatypeImplementation c_boolean
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_boolean, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_boolean, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x00033478 File Offset: 0x00031678
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x00005637 File Offset: 0x00003837
		public unsafe static DatatypeImplementation c_byte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_byte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_byte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x000334A0 File Offset: 0x000316A0
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x00005649 File Offset: 0x00003849
		public unsafe static DatatypeImplementation c_char
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_char, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_char, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x000334C8 File Offset: 0x000316C8
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x0000565B File Offset: 0x0000385B
		public unsafe static DatatypeImplementation c_date
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_date, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_date, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x000334F0 File Offset: 0x000316F0
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x0000566D File Offset: 0x0000386D
		public unsafe static DatatypeImplementation c_dateTime
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_dateTime, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_dateTime, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x00033518 File Offset: 0x00031718
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x0000567F File Offset: 0x0000387F
		public unsafe static DatatypeImplementation c_dateTimeNoTz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_dateTimeNoTz, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_dateTimeNoTz, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x00033540 File Offset: 0x00031740
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x00005691 File Offset: 0x00003891
		public unsafe static DatatypeImplementation c_dateTimeTz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_dateTimeTz, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_dateTimeTz, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00033568 File Offset: 0x00031768
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x000056A3 File Offset: 0x000038A3
		public unsafe static DatatypeImplementation c_day
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_day, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_day, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x00033590 File Offset: 0x00031790
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x000056B5 File Offset: 0x000038B5
		public unsafe static DatatypeImplementation c_decimal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_decimal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_decimal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x000335B8 File Offset: 0x000317B8
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x000056C7 File Offset: 0x000038C7
		public unsafe static DatatypeImplementation c_double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x000335E0 File Offset: 0x000317E0
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x000056D9 File Offset: 0x000038D9
		public unsafe static DatatypeImplementation c_doubleXdr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_doubleXdr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_doubleXdr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00033608 File Offset: 0x00031808
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x000056EB File Offset: 0x000038EB
		public unsafe static DatatypeImplementation c_duration
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_duration, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_duration, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00033630 File Offset: 0x00031830
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x000056FD File Offset: 0x000038FD
		public unsafe static DatatypeImplementation c_ENTITY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_ENTITY, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_ENTITY, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00033658 File Offset: 0x00031858
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x0000570F File Offset: 0x0000390F
		public unsafe static DatatypeImplementation c_ENTITIES
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_ENTITIES, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_ENTITIES, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x00033680 File Offset: 0x00031880
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x00005721 File Offset: 0x00003921
		public unsafe static DatatypeImplementation c_ENUMERATION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_ENUMERATION, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_ENUMERATION, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x000336A8 File Offset: 0x000318A8
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x00005733 File Offset: 0x00003933
		public unsafe static DatatypeImplementation c_fixed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_fixed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_fixed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x000336D0 File Offset: 0x000318D0
		// (set) Token: 0x06000A22 RID: 2594 RVA: 0x00005745 File Offset: 0x00003945
		public unsafe static DatatypeImplementation c_float
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_float, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_float, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x000336F8 File Offset: 0x000318F8
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x00005757 File Offset: 0x00003957
		public unsafe static DatatypeImplementation c_floatXdr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_floatXdr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_floatXdr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x00033720 File Offset: 0x00031920
		// (set) Token: 0x06000A26 RID: 2598 RVA: 0x00005769 File Offset: 0x00003969
		public unsafe static DatatypeImplementation c_hexBinary
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_hexBinary, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_hexBinary, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x00033748 File Offset: 0x00031948
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x0000577B File Offset: 0x0000397B
		public unsafe static DatatypeImplementation c_ID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_ID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_ID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00033770 File Offset: 0x00031970
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x0000578D File Offset: 0x0000398D
		public unsafe static DatatypeImplementation c_IDREF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_IDREF, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_IDREF, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x00033798 File Offset: 0x00031998
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x0000579F File Offset: 0x0000399F
		public unsafe static DatatypeImplementation c_IDREFS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_IDREFS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_IDREFS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x000337C0 File Offset: 0x000319C0
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x000057B1 File Offset: 0x000039B1
		public unsafe static DatatypeImplementation c_int
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_int, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_int, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x000337E8 File Offset: 0x000319E8
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x000057C3 File Offset: 0x000039C3
		public unsafe static DatatypeImplementation c_integer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_integer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_integer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00033810 File Offset: 0x00031A10
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x000057D5 File Offset: 0x000039D5
		public unsafe static DatatypeImplementation c_language
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_language, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_language, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00033838 File Offset: 0x00031A38
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x000057E7 File Offset: 0x000039E7
		public unsafe static DatatypeImplementation c_long
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_long, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_long, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00033860 File Offset: 0x00031A60
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x000057F9 File Offset: 0x000039F9
		public unsafe static DatatypeImplementation c_month
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_month, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_month, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x00033888 File Offset: 0x00031A88
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x0000580B File Offset: 0x00003A0B
		public unsafe static DatatypeImplementation c_monthDay
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_monthDay, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_monthDay, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x000338B0 File Offset: 0x00031AB0
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x0000581D File Offset: 0x00003A1D
		public unsafe static DatatypeImplementation c_Name
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_Name, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_Name, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x000338D8 File Offset: 0x00031AD8
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x0000582F File Offset: 0x00003A2F
		public unsafe static DatatypeImplementation c_NCName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_NCName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_NCName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00033900 File Offset: 0x00031B00
		// (set) Token: 0x06000A3E RID: 2622 RVA: 0x00005841 File Offset: 0x00003A41
		public unsafe static DatatypeImplementation c_negativeInteger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_negativeInteger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_negativeInteger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x00033928 File Offset: 0x00031B28
		// (set) Token: 0x06000A40 RID: 2624 RVA: 0x00005853 File Offset: 0x00003A53
		public unsafe static DatatypeImplementation c_NMTOKEN
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_NMTOKEN, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_NMTOKEN, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x00033950 File Offset: 0x00031B50
		// (set) Token: 0x06000A42 RID: 2626 RVA: 0x00005865 File Offset: 0x00003A65
		public unsafe static DatatypeImplementation c_NMTOKENS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_NMTOKENS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_NMTOKENS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000A43 RID: 2627 RVA: 0x00033978 File Offset: 0x00031B78
		// (set) Token: 0x06000A44 RID: 2628 RVA: 0x00005877 File Offset: 0x00003A77
		public unsafe static DatatypeImplementation c_nonNegativeInteger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_nonNegativeInteger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_nonNegativeInteger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x000339A0 File Offset: 0x00031BA0
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x00005889 File Offset: 0x00003A89
		public unsafe static DatatypeImplementation c_nonPositiveInteger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_nonPositiveInteger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_nonPositiveInteger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x000339C8 File Offset: 0x00031BC8
		// (set) Token: 0x06000A48 RID: 2632 RVA: 0x0000589B File Offset: 0x00003A9B
		public unsafe static DatatypeImplementation c_normalizedString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_normalizedString, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_normalizedString, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x000339F0 File Offset: 0x00031BF0
		// (set) Token: 0x06000A4A RID: 2634 RVA: 0x000058AD File Offset: 0x00003AAD
		public unsafe static DatatypeImplementation c_NOTATION
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_NOTATION, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_NOTATION, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x00033A18 File Offset: 0x00031C18
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x000058BF File Offset: 0x00003ABF
		public unsafe static DatatypeImplementation c_positiveInteger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_positiveInteger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_positiveInteger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x00033A40 File Offset: 0x00031C40
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x000058D1 File Offset: 0x00003AD1
		public unsafe static DatatypeImplementation c_QName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_QName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_QName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x00033A68 File Offset: 0x00031C68
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x000058E3 File Offset: 0x00003AE3
		public unsafe static DatatypeImplementation c_QNameXdr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_QNameXdr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_QNameXdr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x00033A90 File Offset: 0x00031C90
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x000058F5 File Offset: 0x00003AF5
		public unsafe static DatatypeImplementation c_short
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_short, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_short, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00033AB8 File Offset: 0x00031CB8
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x00005907 File Offset: 0x00003B07
		public unsafe static DatatypeImplementation c_string
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_string, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_string, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00033AE0 File Offset: 0x00031CE0
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00005919 File Offset: 0x00003B19
		public unsafe static DatatypeImplementation c_time
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_time, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_time, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00033B08 File Offset: 0x00031D08
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x0000592B File Offset: 0x00003B2B
		public unsafe static DatatypeImplementation c_timeNoTz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_timeNoTz, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_timeNoTz, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00033B30 File Offset: 0x00031D30
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x0000593D File Offset: 0x00003B3D
		public unsafe static DatatypeImplementation c_timeTz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_timeTz, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_timeTz, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00033B58 File Offset: 0x00031D58
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x0000594F File Offset: 0x00003B4F
		public unsafe static DatatypeImplementation c_token
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_token, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_token, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x00033B80 File Offset: 0x00031D80
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x00005961 File Offset: 0x00003B61
		public unsafe static DatatypeImplementation c_unsignedByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x00033BA8 File Offset: 0x00031DA8
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x00005973 File Offset: 0x00003B73
		public unsafe static DatatypeImplementation c_unsignedInt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedInt, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedInt, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00033BD0 File Offset: 0x00031DD0
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x00005985 File Offset: 0x00003B85
		public unsafe static DatatypeImplementation c_unsignedLong
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedLong, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedLong, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00033BF8 File Offset: 0x00031DF8
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x00005997 File Offset: 0x00003B97
		public unsafe static DatatypeImplementation c_unsignedShort
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedShort, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_unsignedShort, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x00033C20 File Offset: 0x00031E20
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x000059A9 File Offset: 0x00003BA9
		public unsafe static DatatypeImplementation c_uuid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_uuid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_uuid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x00033C48 File Offset: 0x00031E48
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x000059BB File Offset: 0x00003BBB
		public unsafe static DatatypeImplementation c_year
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_year, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_year, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x00033C70 File Offset: 0x00031E70
		// (set) Token: 0x06000A6A RID: 2666 RVA: 0x000059CD File Offset: 0x00003BCD
		public unsafe static DatatypeImplementation c_yearMonth
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_yearMonth, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_yearMonth, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x00033C98 File Offset: 0x00031E98
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x000059DF File Offset: 0x00003BDF
		public unsafe static DatatypeImplementation c_normalizedStringV1Compat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_normalizedStringV1Compat, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_normalizedStringV1Compat, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x00033CC0 File Offset: 0x00031EC0
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x000059F1 File Offset: 0x00003BF1
		public unsafe static DatatypeImplementation c_tokenV1Compat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_tokenV1Compat, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_tokenV1Compat, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00033CE8 File Offset: 0x00031EE8
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x00005A03 File Offset: 0x00003C03
		public unsafe static DatatypeImplementation c_anyAtomicType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_anyAtomicType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_anyAtomicType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x00033D10 File Offset: 0x00031F10
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x00005A15 File Offset: 0x00003C15
		public unsafe static DatatypeImplementation c_dayTimeDuration
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_dayTimeDuration, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_dayTimeDuration, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x00033D38 File Offset: 0x00031F38
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x00005A27 File Offset: 0x00003C27
		public unsafe static DatatypeImplementation c_untypedAtomicType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_untypedAtomicType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_untypedAtomicType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00033D60 File Offset: 0x00031F60
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x00005A39 File Offset: 0x00003C39
		public unsafe static DatatypeImplementation c_yearMonthDuration
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_yearMonthDuration, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_yearMonthDuration, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x00033D88 File Offset: 0x00031F88
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x00005A4B File Offset: 0x00003C4B
		public unsafe static Il2CppReferenceArray<DatatypeImplementation> c_tokenizedTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_tokenizedTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DatatypeImplementation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_tokenizedTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x00033DB0 File Offset: 0x00031FB0
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x00005A5D File Offset: 0x00003C5D
		public unsafe static Il2CppReferenceArray<DatatypeImplementation> c_tokenizedTypesXsd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_tokenizedTypesXsd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DatatypeImplementation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_tokenizedTypesXsd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x00033DD8 File Offset: 0x00031FD8
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x00005A6F File Offset: 0x00003C6F
		public unsafe static Il2CppReferenceArray<DatatypeImplementation.SchemaDatatypeMap> c_XdrTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_XdrTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DatatypeImplementation.SchemaDatatypeMap>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_XdrTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x00033E00 File Offset: 0x00032000
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x00005A81 File Offset: 0x00003C81
		public unsafe static Il2CppReferenceArray<DatatypeImplementation.SchemaDatatypeMap> c_XsdTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DatatypeImplementation.NativeFieldInfoPtr_c_XsdTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DatatypeImplementation.SchemaDatatypeMap>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DatatypeImplementation.NativeFieldInfoPtr_c_XsdTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeFieldInfoPtr_variety;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeFieldInfoPtr_restriction;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeFieldInfoPtr_baseType;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeFieldInfoPtr_valueConverter;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeFieldInfoPtr_parentSchemaType;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeFieldInfoPtr_builtinTypes;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeFieldInfoPtr_enumToTypeCode;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeFieldInfoPtr_anySimpleType;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeFieldInfoPtr_anyAtomicType;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeFieldInfoPtr_untypedAtomicType;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeFieldInfoPtr_yearMonthDurationType;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeFieldInfoPtr_dayTimeDurationType;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeFieldInfoPtr_QnAnySimpleType;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeFieldInfoPtr_QnAnyType;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeFieldInfoPtr_stringFacetsChecker;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeFieldInfoPtr_miscFacetsChecker;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeFieldInfoPtr_numeric2FacetsChecker;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeFieldInfoPtr_binaryFacetsChecker;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeFieldInfoPtr_dateTimeFacetsChecker;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeFieldInfoPtr_durationFacetsChecker;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeFieldInfoPtr_listFacetsChecker;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeFieldInfoPtr_qnameFacetsChecker;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeFieldInfoPtr_unionFacetsChecker;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeFieldInfoPtr_c_anySimpleType;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeFieldInfoPtr_c_anyURI;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeFieldInfoPtr_c_base64Binary;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeFieldInfoPtr_c_boolean;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeFieldInfoPtr_c_byte;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeFieldInfoPtr_c_char;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeFieldInfoPtr_c_date;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeFieldInfoPtr_c_dateTime;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeFieldInfoPtr_c_dateTimeNoTz;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeFieldInfoPtr_c_dateTimeTz;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeFieldInfoPtr_c_day;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeFieldInfoPtr_c_decimal;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeFieldInfoPtr_c_double;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeFieldInfoPtr_c_doubleXdr;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeFieldInfoPtr_c_duration;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeFieldInfoPtr_c_ENTITY;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeFieldInfoPtr_c_ENTITIES;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeFieldInfoPtr_c_ENUMERATION;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeFieldInfoPtr_c_fixed;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeFieldInfoPtr_c_float;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeFieldInfoPtr_c_floatXdr;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeFieldInfoPtr_c_hexBinary;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeFieldInfoPtr_c_ID;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeFieldInfoPtr_c_IDREF;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeFieldInfoPtr_c_IDREFS;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeFieldInfoPtr_c_int;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeFieldInfoPtr_c_integer;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeFieldInfoPtr_c_language;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeFieldInfoPtr_c_long;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeFieldInfoPtr_c_month;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeFieldInfoPtr_c_monthDay;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeFieldInfoPtr_c_Name;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeFieldInfoPtr_c_NCName;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeFieldInfoPtr_c_negativeInteger;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeFieldInfoPtr_c_NMTOKEN;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeFieldInfoPtr_c_NMTOKENS;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeFieldInfoPtr_c_nonNegativeInteger;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeFieldInfoPtr_c_nonPositiveInteger;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeFieldInfoPtr_c_normalizedString;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeFieldInfoPtr_c_NOTATION;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeFieldInfoPtr_c_positiveInteger;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeFieldInfoPtr_c_QName;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeFieldInfoPtr_c_QNameXdr;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeFieldInfoPtr_c_short;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeFieldInfoPtr_c_string;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeFieldInfoPtr_c_time;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeFieldInfoPtr_c_timeNoTz;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeFieldInfoPtr_c_timeTz;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeFieldInfoPtr_c_token;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeFieldInfoPtr_c_unsignedByte;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeFieldInfoPtr_c_unsignedInt;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeFieldInfoPtr_c_unsignedLong;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeFieldInfoPtr_c_unsignedShort;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeFieldInfoPtr_c_uuid;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeFieldInfoPtr_c_year;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeFieldInfoPtr_c_yearMonth;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeFieldInfoPtr_c_normalizedStringV1Compat;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeFieldInfoPtr_c_tokenV1Compat;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeFieldInfoPtr_c_anyAtomicType;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeFieldInfoPtr_c_dayTimeDuration;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeFieldInfoPtr_c_untypedAtomicType;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeFieldInfoPtr_c_yearMonthDuration;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeFieldInfoPtr_c_tokenizedTypes;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeFieldInfoPtr_c_tokenizedTypesXsd;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeFieldInfoPtr_c_XdrTypes;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeFieldInfoPtr_c_XsdTypes;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_get_AnySimpleType_Internal_Static_get_XmlSchemaSimpleType_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_get_UntypedAtomicType_Internal_Static_get_XmlSchemaSimpleType_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_DatatypeImplementation_XmlTokenizedType_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_FromTypeName_Private_Static_DatatypeImplementation_String_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_StartBuiltinType_Internal_Static_XmlSchemaSimpleType_XmlQualifiedName_XmlSchemaDatatype_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_FinishBuiltinType_Internal_Static_Void_XmlSchemaSimpleType_XmlSchemaSimpleType_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_CreateBuiltinTypes_Internal_Static_Void_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_GetSimpleTypeFromTypeCode_Internal_Static_XmlSchemaSimpleType_XmlTypeCode_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_DeriveByList_Internal_XmlSchemaDatatype_Int32_XmlSchemaType_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_IsEqual_Internal_Virtual_Boolean_Object_Object_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_New_XmlValueConverter_XmlSchemaType_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueConverter_Internal_Virtual_get_XmlValueConverter_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_get_Variety_Public_Virtual_get_XmlSchemaDatatypeVariety_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_get_Restriction_Internal_Virtual_get_RestrictionFacets_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_get_ListValueType_Internal_Abstract_Virtual_New_get_Type_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_ParseValue_Public_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_0;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeName_Internal_String_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Protected_Int32_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200012F RID: 303
		public class SchemaDatatypeMap : Object
		{
			// Token: 0x060012B7 RID: 4791 RVA: 0x00055768 File Offset: 0x00053968
			// Note: this type is marked as 'beforefieldinit'.
			static SchemaDatatypeMap()
			{
				Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DatatypeImplementation>.NativeClassPtr, "SchemaDatatypeMap");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr);
				DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, "name");
				DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, "type");
				DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_parentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, "parentIndex");
				DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, 100664833);
				DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, 100664834);
				DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_op_Explicit_Public_Static_DatatypeImplementation_SchemaDatatypeMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, 100664835);
				DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, 100664836);
				DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_get_ParentIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, 100664837);
				DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr, 100664838);
			}

			// Token: 0x060012B8 RID: 4792 RVA: 0x00055848 File Offset: 0x00053A48
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SchemaDatatypeMap(string name, DatatypeImplementation type)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060012B9 RID: 4793 RVA: 0x000558A8 File Offset: 0x00053AA8
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 22030, RefRangeEnd = 22036, XrefRangeStart = 22029, XrefRangeEnd = 22030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SchemaDatatypeMap(string name, DatatypeImplementation type, int parentIndex)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DatatypeImplementation.SchemaDatatypeMap>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parentIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060012BA RID: 4794 RVA: 0x00055914 File Offset: 0x00053B14
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 22036, RefRangeEnd = 22069, XrefRangeStart = 22036, XrefRangeEnd = 22036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static explicit operator DatatypeImplementation(DatatypeImplementation.SchemaDatatypeMap sdm)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sdm);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_op_Explicit_Public_Static_DatatypeImplementation_SchemaDatatypeMap_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr3) : null;
				}
			}

			// Token: 0x1700068D RID: 1677
			// (get) Token: 0x060012BB RID: 4795 RVA: 0x00055958 File Offset: 0x00053B58
			public unsafe string Name
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700068E RID: 1678
			// (get) Token: 0x060012BC RID: 4796 RVA: 0x00055990 File Offset: 0x00053B90
			public unsafe int ParentIndex
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_get_ParentIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060012BD RID: 4797 RVA: 0x000559CC File Offset: 0x00053BCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22069, XrefRangeEnd = 22073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int CompareTo(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatatypeImplementation.SchemaDatatypeMap.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060012BE RID: 4798 RVA: 0x0000865D File Offset: 0x0000685D
			public SchemaDatatypeMap(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700068A RID: 1674
			// (get) Token: 0x060012BF RID: 4799 RVA: 0x00055A1C File Offset: 0x00053C1C
			// (set) Token: 0x060012C0 RID: 4800 RVA: 0x00008666 File Offset: 0x00006866
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700068B RID: 1675
			// (get) Token: 0x060012C1 RID: 4801 RVA: 0x00055A44 File Offset: 0x00053C44
			// (set) Token: 0x060012C2 RID: 4802 RVA: 0x00008685 File Offset: 0x00006885
			public unsafe DatatypeImplementation type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700068C RID: 1676
			// (get) Token: 0x060012C3 RID: 4803 RVA: 0x00055A74 File Offset: 0x00053C74
			// (set) Token: 0x060012C4 RID: 4804 RVA: 0x000086A4 File Offset: 0x000068A4
			public unsafe int parentIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_parentIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatatypeImplementation.SchemaDatatypeMap.NativeFieldInfoPtr_parentIndex)) = value;
				}
			}

			// Token: 0x04000EB1 RID: 3761
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04000EB2 RID: 3762
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04000EB3 RID: 3763
			private static readonly IntPtr NativeFieldInfoPtr_parentIndex;

			// Token: 0x04000EB4 RID: 3764
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_0;

			// Token: 0x04000EB5 RID: 3765
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_DatatypeImplementation_Int32_0;

			// Token: 0x04000EB6 RID: 3766
			private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_DatatypeImplementation_SchemaDatatypeMap_0;

			// Token: 0x04000EB7 RID: 3767
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

			// Token: 0x04000EB8 RID: 3768
			private static readonly IntPtr NativeMethodInfoPtr_get_ParentIndex_Public_get_Int32_0;

			// Token: 0x04000EB9 RID: 3769
			private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;
		}
	}
}

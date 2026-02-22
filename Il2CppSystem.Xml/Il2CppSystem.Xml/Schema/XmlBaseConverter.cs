using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000104 RID: 260
	public class XmlBaseConverter : XmlValueConverter
	{
		// Token: 0x06000F8D RID: 3981 RVA: 0x00048B1C File Offset: 0x00046D1C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlBaseConverter()
		{
			Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlBaseConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr);
			XmlBaseConverter.NativeFieldInfoPtr_schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "schemaType");
			XmlBaseConverter.NativeFieldInfoPtr_typeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "typeCode");
			XmlBaseConverter.NativeFieldInfoPtr_clrTypeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "clrTypeDefault");
			XmlBaseConverter.NativeFieldInfoPtr_ICollectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "ICollectionType");
			XmlBaseConverter.NativeFieldInfoPtr_IEnumerableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "IEnumerableType");
			XmlBaseConverter.NativeFieldInfoPtr_IListType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "IListType");
			XmlBaseConverter.NativeFieldInfoPtr_ObjectArrayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "ObjectArrayType");
			XmlBaseConverter.NativeFieldInfoPtr_StringArrayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "StringArrayType");
			XmlBaseConverter.NativeFieldInfoPtr_XmlAtomicValueArrayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "XmlAtomicValueArrayType");
			XmlBaseConverter.NativeFieldInfoPtr_DecimalType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "DecimalType");
			XmlBaseConverter.NativeFieldInfoPtr_Int32Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "Int32Type");
			XmlBaseConverter.NativeFieldInfoPtr_Int64Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "Int64Type");
			XmlBaseConverter.NativeFieldInfoPtr_StringType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "StringType");
			XmlBaseConverter.NativeFieldInfoPtr_XmlAtomicValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "XmlAtomicValueType");
			XmlBaseConverter.NativeFieldInfoPtr_ObjectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "ObjectType");
			XmlBaseConverter.NativeFieldInfoPtr_ByteType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "ByteType");
			XmlBaseConverter.NativeFieldInfoPtr_Int16Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "Int16Type");
			XmlBaseConverter.NativeFieldInfoPtr_SByteType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "SByteType");
			XmlBaseConverter.NativeFieldInfoPtr_UInt16Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "UInt16Type");
			XmlBaseConverter.NativeFieldInfoPtr_UInt32Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "UInt32Type");
			XmlBaseConverter.NativeFieldInfoPtr_UInt64Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "UInt64Type");
			XmlBaseConverter.NativeFieldInfoPtr_XPathItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "XPathItemType");
			XmlBaseConverter.NativeFieldInfoPtr_DoubleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "DoubleType");
			XmlBaseConverter.NativeFieldInfoPtr_SingleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "SingleType");
			XmlBaseConverter.NativeFieldInfoPtr_DateTimeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "DateTimeType");
			XmlBaseConverter.NativeFieldInfoPtr_DateTimeOffsetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "DateTimeOffsetType");
			XmlBaseConverter.NativeFieldInfoPtr_BooleanType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "BooleanType");
			XmlBaseConverter.NativeFieldInfoPtr_ByteArrayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "ByteArrayType");
			XmlBaseConverter.NativeFieldInfoPtr_XmlQualifiedNameType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "XmlQualifiedNameType");
			XmlBaseConverter.NativeFieldInfoPtr_UriType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "UriType");
			XmlBaseConverter.NativeFieldInfoPtr_TimeSpanType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "TimeSpanType");
			XmlBaseConverter.NativeFieldInfoPtr_XPathNavigatorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, "XPathNavigatorType");
			XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665556);
			XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665557);
			XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665558);
			XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665559);
			XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665560);
			XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665561);
			XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665562);
			XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665563);
			XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665564);
			XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665565);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665566);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665567);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665568);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665569);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665570);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665571);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665572);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665573);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665574);
			XmlBaseConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665575);
			XmlBaseConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665576);
			XmlBaseConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665577);
			XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665578);
			XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665579);
			XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665580);
			XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665581);
			XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665582);
			XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665583);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665584);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665585);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665586);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665587);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665588);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665589);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665590);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665591);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665592);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665593);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665594);
			XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665595);
			XmlBaseConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665596);
			XmlBaseConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665597);
			XmlBaseConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665598);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665599);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665600);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665601);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665602);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665603);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665604);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665605);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665606);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665607);
			XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665608);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665609);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_DateTime_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665610);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Decimal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665611);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Double_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665612);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665613);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int64_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665614);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665615);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665616);
			XmlBaseConverter.NativeMethodInfoPtr_get_SchemaType_Protected_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665617);
			XmlBaseConverter.NativeMethodInfoPtr_get_TypeCode_Protected_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665618);
			XmlBaseConverter.NativeMethodInfoPtr_get_XmlTypeName_Protected_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665619);
			XmlBaseConverter.NativeMethodInfoPtr_get_DefaultClrType_Protected_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665620);
			XmlBaseConverter.NativeMethodInfoPtr_IsDerivedFrom_Protected_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665621);
			XmlBaseConverter.NativeMethodInfoPtr_CreateInvalidClrMappingException_Protected_Exception_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665622);
			XmlBaseConverter.NativeMethodInfoPtr_QNameToString_Protected_Static_String_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665623);
			XmlBaseConverter.NativeMethodInfoPtr_ChangeListType_Protected_Virtual_New_Object_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665624);
			XmlBaseConverter.NativeMethodInfoPtr_StringToBase64Binary_Protected_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665625);
			XmlBaseConverter.NativeMethodInfoPtr_StringToDate_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665626);
			XmlBaseConverter.NativeMethodInfoPtr_StringToDateTime_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665627);
			XmlBaseConverter.NativeMethodInfoPtr_StringToDayTimeDuration_Protected_Static_TimeSpan_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665628);
			XmlBaseConverter.NativeMethodInfoPtr_StringToDuration_Protected_Static_TimeSpan_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665629);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGDay_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665630);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGMonth_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665631);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGMonthDay_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665632);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGYear_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665633);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGYearMonth_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665634);
			XmlBaseConverter.NativeMethodInfoPtr_StringToDateOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665635);
			XmlBaseConverter.NativeMethodInfoPtr_StringToDateTimeOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665636);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGDayOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665637);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGMonthOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665638);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGMonthDayOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665639);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGYearOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665640);
			XmlBaseConverter.NativeMethodInfoPtr_StringToGYearMonthOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665641);
			XmlBaseConverter.NativeMethodInfoPtr_StringToHexBinary_Protected_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665642);
			XmlBaseConverter.NativeMethodInfoPtr_StringToQName_Protected_Static_XmlQualifiedName_String_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665643);
			XmlBaseConverter.NativeMethodInfoPtr_StringToTime_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665644);
			XmlBaseConverter.NativeMethodInfoPtr_StringToTimeOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665645);
			XmlBaseConverter.NativeMethodInfoPtr_StringToYearMonthDuration_Protected_Static_TimeSpan_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665646);
			XmlBaseConverter.NativeMethodInfoPtr_AnyUriToString_Protected_Static_String_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665647);
			XmlBaseConverter.NativeMethodInfoPtr_Base64BinaryToString_Protected_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665648);
			XmlBaseConverter.NativeMethodInfoPtr_DateToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665649);
			XmlBaseConverter.NativeMethodInfoPtr_DateTimeToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665650);
			XmlBaseConverter.NativeMethodInfoPtr_DayTimeDurationToString_Protected_Static_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665651);
			XmlBaseConverter.NativeMethodInfoPtr_DurationToString_Protected_Static_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665652);
			XmlBaseConverter.NativeMethodInfoPtr_GDayToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665653);
			XmlBaseConverter.NativeMethodInfoPtr_GMonthToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665654);
			XmlBaseConverter.NativeMethodInfoPtr_GMonthDayToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665655);
			XmlBaseConverter.NativeMethodInfoPtr_GYearToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665656);
			XmlBaseConverter.NativeMethodInfoPtr_GYearMonthToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665657);
			XmlBaseConverter.NativeMethodInfoPtr_DateOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665658);
			XmlBaseConverter.NativeMethodInfoPtr_DateTimeOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665659);
			XmlBaseConverter.NativeMethodInfoPtr_GDayOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665660);
			XmlBaseConverter.NativeMethodInfoPtr_GMonthOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665661);
			XmlBaseConverter.NativeMethodInfoPtr_GMonthDayOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665662);
			XmlBaseConverter.NativeMethodInfoPtr_GYearOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665663);
			XmlBaseConverter.NativeMethodInfoPtr_GYearMonthOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665664);
			XmlBaseConverter.NativeMethodInfoPtr_QNameToString_Protected_Static_String_XmlQualifiedName_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665665);
			XmlBaseConverter.NativeMethodInfoPtr_TimeToString_Protected_Static_String_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665666);
			XmlBaseConverter.NativeMethodInfoPtr_TimeOffsetToString_Protected_Static_String_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665667);
			XmlBaseConverter.NativeMethodInfoPtr_YearMonthDurationToString_Protected_Static_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665668);
			XmlBaseConverter.NativeMethodInfoPtr_DateTimeOffsetToDateTime_Internal_Static_DateTime_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665669);
			XmlBaseConverter.NativeMethodInfoPtr_DecimalToInt32_Internal_Static_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665670);
			XmlBaseConverter.NativeMethodInfoPtr_DecimalToInt64_Protected_Static_Int64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665671);
			XmlBaseConverter.NativeMethodInfoPtr_DecimalToUInt64_Protected_Static_UInt64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665672);
			XmlBaseConverter.NativeMethodInfoPtr_Int32ToByte_Protected_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665673);
			XmlBaseConverter.NativeMethodInfoPtr_Int32ToInt16_Protected_Static_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665674);
			XmlBaseConverter.NativeMethodInfoPtr_Int32ToSByte_Protected_Static_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665675);
			XmlBaseConverter.NativeMethodInfoPtr_Int32ToUInt16_Protected_Static_UInt16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665676);
			XmlBaseConverter.NativeMethodInfoPtr_Int64ToInt32_Protected_Static_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665677);
			XmlBaseConverter.NativeMethodInfoPtr_Int64ToUInt32_Protected_Static_UInt32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665678);
			XmlBaseConverter.NativeMethodInfoPtr_UntypedAtomicToDateTime_Protected_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665679);
			XmlBaseConverter.NativeMethodInfoPtr_UntypedAtomicToDateTimeOffset_Protected_Static_DateTimeOffset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr, 100665680);
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x00049790 File Offset: 0x00047990
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 25019, RefRangeEnd = 25032, XrefRangeStart = 25014, XrefRangeEnd = 25019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlBaseConverter(XmlSchemaType schemaType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x000497DC File Offset: 0x000479DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25032, XrefRangeEnd = 25037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlBaseConverter(XmlTypeCode typeCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00049824 File Offset: 0x00047A24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25040, RefRangeEnd = 25042, XrefRangeStart = 25037, XrefRangeEnd = 25040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlBaseConverter(XmlBaseConverter converterAtomic)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(converterAtomic);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00049870 File Offset: 0x00047A70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25043, RefRangeEnd = 25044, XrefRangeStart = 25042, XrefRangeEnd = 25043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlBaseConverter(XmlBaseConverter converterAtomic, Type clrTypeDefault)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlBaseConverter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(converterAtomic);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clrTypeDefault);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x000498D0 File Offset: 0x00047AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25044, XrefRangeEnd = 25054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00049924 File Offset: 0x00047B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25054, XrefRangeEnd = 25064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00049978 File Offset: 0x00047B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25064, XrefRangeEnd = 25074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x000499CC File Offset: 0x00047BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25074, XrefRangeEnd = 25084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00049A20 File Offset: 0x00047C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25084, XrefRangeEnd = 25091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00049A78 File Offset: 0x00047C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25091, XrefRangeEnd = 25098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ToBoolean(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00049AD0 File Offset: 0x00047CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25098, XrefRangeEnd = 25108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00049B24 File Offset: 0x00047D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25108, XrefRangeEnd = 25118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(DateTimeOffset value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_DateTimeOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00049B78 File Offset: 0x00047D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25118, XrefRangeEnd = 25128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00049BCC File Offset: 0x00047DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25128, XrefRangeEnd = 25138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00049C20 File Offset: 0x00047E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25138, XrefRangeEnd = 25148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00049C74 File Offset: 0x00047E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25148, XrefRangeEnd = 25155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00049CCC File Offset: 0x00047ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25155, XrefRangeEnd = 25162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime ToDateTime(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00049D24 File Offset: 0x00047F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25162, XrefRangeEnd = 25172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTimeOffset ToDateTimeOffset(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00049D78 File Offset: 0x00047F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25172, XrefRangeEnd = 25179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTimeOffset ToDateTimeOffset(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00049DD0 File Offset: 0x00047FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25179, XrefRangeEnd = 25186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTimeOffset ToDateTimeOffset(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00049E28 File Offset: 0x00048028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25186, XrefRangeEnd = 25193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Decimal ToDecimal(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00049E80 File Offset: 0x00048080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25193, XrefRangeEnd = 25200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Decimal ToDecimal(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00049ED8 File Offset: 0x000480D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25200, XrefRangeEnd = 25210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00049F2C File Offset: 0x0004812C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25210, XrefRangeEnd = 25220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00049F80 File Offset: 0x00048180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25220, XrefRangeEnd = 25230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00049FD4 File Offset: 0x000481D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25230, XrefRangeEnd = 25240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0004A028 File Offset: 0x00048228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25240, XrefRangeEnd = 25247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x0004A080 File Offset: 0x00048280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25247, XrefRangeEnd = 25254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double ToDouble(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x0004A0D8 File Offset: 0x000482D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25254, XrefRangeEnd = 25264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x0004A12C File Offset: 0x0004832C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25264, XrefRangeEnd = 25274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x0004A180 File Offset: 0x00048380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25274, XrefRangeEnd = 25284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x0004A1D4 File Offset: 0x000483D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25284, XrefRangeEnd = 25294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x0004A228 File Offset: 0x00048428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25294, XrefRangeEnd = 25301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x0004A280 File Offset: 0x00048480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25301, XrefRangeEnd = 25308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int ToInt32(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x0004A2D8 File Offset: 0x000484D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25308, XrefRangeEnd = 25318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x0004A32C File Offset: 0x0004852C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25318, XrefRangeEnd = 25328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x0004A380 File Offset: 0x00048580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25328, XrefRangeEnd = 25338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0004A3D4 File Offset: 0x000485D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25338, XrefRangeEnd = 25348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x0004A428 File Offset: 0x00048628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25348, XrefRangeEnd = 25355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0004A480 File Offset: 0x00048680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25355, XrefRangeEnd = 25362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long ToInt64(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x0004A4D8 File Offset: 0x000486D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25362, XrefRangeEnd = 25372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float ToSingle(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x0004A52C File Offset: 0x0004872C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25372, XrefRangeEnd = 25379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float ToSingle(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0004A584 File Offset: 0x00048784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25379, XrefRangeEnd = 25386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float ToSingle(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x0004A5DC File Offset: 0x000487DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25386, XrefRangeEnd = 25395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x0004A62C File Offset: 0x0004882C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25395, XrefRangeEnd = 25404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x0004A67C File Offset: 0x0004887C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25404, XrefRangeEnd = 25413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(DateTimeOffset value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTimeOffset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x0004A6CC File Offset: 0x000488CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25413, XrefRangeEnd = 25422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(Decimal value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Decimal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0004A71C File Offset: 0x0004891C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25422, XrefRangeEnd = 25431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0004A76C File Offset: 0x0004896C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25431, XrefRangeEnd = 25440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x0004A7BC File Offset: 0x000489BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25440, XrefRangeEnd = 25449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x0004A80C File Offset: 0x00048A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25449, XrefRangeEnd = 25458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x0004A85C File Offset: 0x00048A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25458, XrefRangeEnd = 25464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(Object value, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x0004A8C4 File Offset: 0x00048AC4
		[CallerCount(0)]
		public unsafe override string ToString(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x0004A918 File Offset: 0x00048B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25464, XrefRangeEnd = 25467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(bool value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Boolean_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x0004A984 File Offset: 0x00048B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25467, XrefRangeEnd = 25470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(DateTime value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_DateTime_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x0004A9F0 File Offset: 0x00048BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25470, XrefRangeEnd = 25473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(Decimal value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Decimal_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x0004AA5C File Offset: 0x00048C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25473, XrefRangeEnd = 25476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(double value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Double_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x0004AAC8 File Offset: 0x00048CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25476, XrefRangeEnd = 25479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(int value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int32_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0004AB34 File Offset: 0x00048D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25479, XrefRangeEnd = 25482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ChangeType(long value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int64_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x0004ABA0 File Offset: 0x00048DA0
		[CallerCount(0)]
		public unsafe override Object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x0004AC20 File Offset: 0x00048E20
		[CallerCount(0)]
		public unsafe override Object ChangeType(Object value, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x0004AC90 File Offset: 0x00048E90
		public unsafe XmlSchemaType SchemaType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_get_SchemaType_Protected_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x0004ACD0 File Offset: 0x00048ED0
		public unsafe XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_get_TypeCode_Protected_get_XmlTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x0004AD0C File Offset: 0x00048F0C
		public unsafe string XmlTypeName
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25488, RefRangeEnd = 25493, XrefRangeStart = 25482, XrefRangeEnd = 25488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_get_XmlTypeName_Protected_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x0004AD44 File Offset: 0x00048F44
		public unsafe Type DefaultClrType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_get_DefaultClrType_Protected_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x0004AD84 File Offset: 0x00048F84
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 25501, RefRangeEnd = 25508, XrefRangeStart = 25493, XrefRangeEnd = 25501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDerivedFrom(Type derivedType, Type baseType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_IsDerivedFrom_Protected_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x0004ADD8 File Offset: 0x00048FD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25537, RefRangeEnd = 25539, XrefRangeStart = 25508, XrefRangeEnd = 25537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_CreateInvalidClrMappingException_Protected_Exception_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0004AE3C File Offset: 0x0004903C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25539, XrefRangeEnd = 25552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string QNameToString(XmlQualifiedName name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_QNameToString_Protected_Static_String_XmlQualifiedName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x0004AE78 File Offset: 0x00049078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25552, XrefRangeEnd = 25557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object ChangeListType(Object value, Type destinationType, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlBaseConverter.NativeMethodInfoPtr_ChangeListType_Protected_Virtual_New_Object_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x0004AEF8 File Offset: 0x000490F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 25565, RefRangeEnd = 25568, XrefRangeStart = 25557, XrefRangeEnd = 25565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> StringToBase64Binary(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToBase64Binary_Protected_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0004AF3C File Offset: 0x0004913C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25573, RefRangeEnd = 25574, XrefRangeStart = 25568, XrefRangeEnd = 25573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToDate(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToDate_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x0004AF80 File Offset: 0x00049180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25579, RefRangeEnd = 25580, XrefRangeStart = 25574, XrefRangeEnd = 25579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToDateTime(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToDateTime_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0004AFC4 File Offset: 0x000491C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25582, RefRangeEnd = 25583, XrefRangeStart = 25580, XrefRangeEnd = 25582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan StringToDayTimeDuration(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToDayTimeDuration_Protected_Static_TimeSpan_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x0004B008 File Offset: 0x00049208
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 25585, RefRangeEnd = 25588, XrefRangeStart = 25583, XrefRangeEnd = 25585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan StringToDuration(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToDuration_Protected_Static_TimeSpan_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0004B04C File Offset: 0x0004924C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25593, RefRangeEnd = 25594, XrefRangeStart = 25588, XrefRangeEnd = 25593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToGDay(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGDay_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x0004B090 File Offset: 0x00049290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25599, RefRangeEnd = 25600, XrefRangeStart = 25594, XrefRangeEnd = 25599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToGMonth(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGMonth_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x0004B0D4 File Offset: 0x000492D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25605, RefRangeEnd = 25606, XrefRangeStart = 25600, XrefRangeEnd = 25605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToGMonthDay(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGMonthDay_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x0004B118 File Offset: 0x00049318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25611, RefRangeEnd = 25612, XrefRangeStart = 25606, XrefRangeEnd = 25611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToGYear(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGYear_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x0004B15C File Offset: 0x0004935C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25617, RefRangeEnd = 25618, XrefRangeStart = 25612, XrefRangeEnd = 25617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToGYearMonth(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGYearMonth_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x0004B1A0 File Offset: 0x000493A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25618, XrefRangeEnd = 25623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToDateOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToDateOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x0004B1E4 File Offset: 0x000493E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25623, XrefRangeEnd = 25628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToDateTimeOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToDateTimeOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x0004B228 File Offset: 0x00049428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25628, XrefRangeEnd = 25633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToGDayOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGDayOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x0004B26C File Offset: 0x0004946C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25633, XrefRangeEnd = 25638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToGMonthOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGMonthOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x0004B2B0 File Offset: 0x000494B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25638, XrefRangeEnd = 25643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToGMonthDayOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGMonthDayOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x0004B2F4 File Offset: 0x000494F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25643, XrefRangeEnd = 25648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToGYearOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGYearOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x0004B338 File Offset: 0x00049538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25648, XrefRangeEnd = 25653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToGYearMonthOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToGYearMonthOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x0004B37C File Offset: 0x0004957C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25658, RefRangeEnd = 25660, XrefRangeStart = 25653, XrefRangeEnd = 25658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> StringToHexBinary(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToHexBinary_Protected_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x0004B3C0 File Offset: 0x000495C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 25672, RefRangeEnd = 25676, XrefRangeStart = 25660, XrefRangeEnd = 25672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToQName_Protected_Static_XmlQualifiedName_String_IXmlNamespaceResolver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x0004B418 File Offset: 0x00049618
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25681, RefRangeEnd = 25682, XrefRangeStart = 25676, XrefRangeEnd = 25681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime StringToTime(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToTime_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0004B45C File Offset: 0x0004965C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25687, RefRangeEnd = 25688, XrefRangeStart = 25682, XrefRangeEnd = 25687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset StringToTimeOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToTimeOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0004B4A0 File Offset: 0x000496A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25690, RefRangeEnd = 25691, XrefRangeStart = 25688, XrefRangeEnd = 25690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan StringToYearMonthDuration(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_StringToYearMonthDuration_Protected_Static_TimeSpan_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x0004B4E4 File Offset: 0x000496E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25691, XrefRangeEnd = 25693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string AnyUriToString(Uri value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_AnyUriToString_Protected_Static_String_Uri_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0004B520 File Offset: 0x00049720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25693, XrefRangeEnd = 25697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Base64BinaryToString(Il2CppStructArray<byte> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Base64BinaryToString_Protected_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0004B55C File Offset: 0x0004975C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25699, RefRangeEnd = 25700, XrefRangeStart = 25697, XrefRangeEnd = 25699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DateToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DateToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x0004B594 File Offset: 0x00049794
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25702, RefRangeEnd = 25704, XrefRangeStart = 25700, XrefRangeEnd = 25702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DateTimeToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DateTimeToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x0004B5CC File Offset: 0x000497CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25704, XrefRangeEnd = 25706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DayTimeDurationToString(TimeSpan value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DayTimeDurationToString_Protected_Static_String_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x0004B604 File Offset: 0x00049804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25706, XrefRangeEnd = 25708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DurationToString(TimeSpan value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DurationToString_Protected_Static_String_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0004B63C File Offset: 0x0004983C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25710, RefRangeEnd = 25711, XrefRangeStart = 25708, XrefRangeEnd = 25710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GDayToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GDayToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0004B674 File Offset: 0x00049874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25713, RefRangeEnd = 25714, XrefRangeStart = 25711, XrefRangeEnd = 25713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GMonthToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GMonthToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0004B6AC File Offset: 0x000498AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25716, RefRangeEnd = 25717, XrefRangeStart = 25714, XrefRangeEnd = 25716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GMonthDayToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GMonthDayToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0004B6E4 File Offset: 0x000498E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25719, RefRangeEnd = 25720, XrefRangeStart = 25717, XrefRangeEnd = 25719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GYearToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GYearToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0004B71C File Offset: 0x0004991C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25722, RefRangeEnd = 25723, XrefRangeStart = 25720, XrefRangeEnd = 25722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GYearMonthToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GYearMonthToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0004B754 File Offset: 0x00049954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25723, XrefRangeEnd = 25725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DateOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DateOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0004B78C File Offset: 0x0004998C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25727, RefRangeEnd = 25728, XrefRangeStart = 25725, XrefRangeEnd = 25727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DateTimeOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DateTimeOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0004B7C4 File Offset: 0x000499C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25728, XrefRangeEnd = 25730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GDayOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GDayOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0004B7FC File Offset: 0x000499FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25730, XrefRangeEnd = 25732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GMonthOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GMonthOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0004B834 File Offset: 0x00049A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25732, XrefRangeEnd = 25734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GMonthDayOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GMonthDayOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0004B86C File Offset: 0x00049A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25734, XrefRangeEnd = 25736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GYearOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GYearOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0004B8A4 File Offset: 0x00049AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25736, XrefRangeEnd = 25738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GYearMonthOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_GYearMonthOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0004B8DC File Offset: 0x00049ADC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25746, RefRangeEnd = 25747, XrefRangeStart = 25738, XrefRangeEnd = 25746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_QNameToString_Protected_Static_String_XmlQualifiedName_IXmlNamespaceResolver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x0004B92C File Offset: 0x00049B2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25749, RefRangeEnd = 25750, XrefRangeStart = 25747, XrefRangeEnd = 25749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TimeToString(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_TimeToString_Protected_Static_String_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0004B964 File Offset: 0x00049B64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25752, RefRangeEnd = 25753, XrefRangeStart = 25750, XrefRangeEnd = 25752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TimeOffsetToString(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_TimeOffsetToString_Protected_Static_String_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0004B99C File Offset: 0x00049B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25753, XrefRangeEnd = 25755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string YearMonthDurationToString(TimeSpan value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_YearMonthDurationToString_Protected_Static_String_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0004B9D4 File Offset: 0x00049BD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25756, RefRangeEnd = 25757, XrefRangeStart = 25755, XrefRangeEnd = 25756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime DateTimeOffsetToDateTime(DateTimeOffset value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DateTimeOffsetToDateTime_Internal_Static_DateTime_DateTimeOffset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0004BA14 File Offset: 0x00049C14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25769, RefRangeEnd = 25770, XrefRangeStart = 25757, XrefRangeEnd = 25769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DecimalToInt32(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DecimalToInt32_Internal_Static_Int32_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0004BA54 File Offset: 0x00049C54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25782, RefRangeEnd = 25784, XrefRangeStart = 25770, XrefRangeEnd = 25782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long DecimalToInt64(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DecimalToInt64_Protected_Static_Int64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0004BA94 File Offset: 0x00049C94
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 25796, RefRangeEnd = 25800, XrefRangeStart = 25784, XrefRangeEnd = 25796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong DecimalToUInt64(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_DecimalToUInt64_Protected_Static_UInt64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0004BAD4 File Offset: 0x00049CD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25800, RefRangeEnd = 25802, XrefRangeStart = 25800, XrefRangeEnd = 25800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte Int32ToByte(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Int32ToByte_Protected_Static_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0004BB14 File Offset: 0x00049D14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25802, RefRangeEnd = 25804, XrefRangeStart = 25802, XrefRangeEnd = 25802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short Int32ToInt16(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Int32ToInt16_Protected_Static_Int16_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0004BB54 File Offset: 0x00049D54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25804, RefRangeEnd = 25806, XrefRangeStart = 25804, XrefRangeEnd = 25804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte Int32ToSByte(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Int32ToSByte_Protected_Static_SByte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0004BB94 File Offset: 0x00049D94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25806, RefRangeEnd = 25808, XrefRangeStart = 25806, XrefRangeEnd = 25806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort Int32ToUInt16(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Int32ToUInt16_Protected_Static_UInt16_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0004BBD4 File Offset: 0x00049DD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 25808, RefRangeEnd = 25809, XrefRangeStart = 25808, XrefRangeEnd = 25808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Int64ToInt32(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Int64ToInt32_Protected_Static_Int32_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0004BC14 File Offset: 0x00049E14
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 25809, RefRangeEnd = 25813, XrefRangeStart = 25809, XrefRangeEnd = 25809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Int64ToUInt32(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_Int64ToUInt32_Protected_Static_UInt32_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0004BC54 File Offset: 0x00049E54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25818, RefRangeEnd = 25820, XrefRangeStart = 25813, XrefRangeEnd = 25818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime UntypedAtomicToDateTime(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_UntypedAtomicToDateTime_Protected_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0004BC98 File Offset: 0x00049E98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 25825, RefRangeEnd = 25827, XrefRangeStart = 25820, XrefRangeEnd = 25825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTimeOffset UntypedAtomicToDateTimeOffset(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlBaseConverter.NativeMethodInfoPtr_UntypedAtomicToDateTimeOffset_Protected_Static_DateTimeOffset_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00007481 File Offset: 0x00005681
		public XmlBaseConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x0004BCDC File Offset: 0x00049EDC
		// (set) Token: 0x0600100D RID: 4109 RVA: 0x0000748A File Offset: 0x0000568A
		public unsafe XmlSchemaType schemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlBaseConverter.NativeFieldInfoPtr_schemaType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlBaseConverter.NativeFieldInfoPtr_schemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x0004BD0C File Offset: 0x00049F0C
		// (set) Token: 0x0600100F RID: 4111 RVA: 0x000074A9 File Offset: 0x000056A9
		public unsafe XmlTypeCode typeCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlBaseConverter.NativeFieldInfoPtr_typeCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlBaseConverter.NativeFieldInfoPtr_typeCode)) = value;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x0004BD34 File Offset: 0x00049F34
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x000074C4 File Offset: 0x000056C4
		public unsafe Type clrTypeDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlBaseConverter.NativeFieldInfoPtr_clrTypeDefault);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlBaseConverter.NativeFieldInfoPtr_clrTypeDefault), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x0004BD64 File Offset: 0x00049F64
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x000074E3 File Offset: 0x000056E3
		public unsafe static Type ICollectionType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_ICollectionType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_ICollectionType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x0004BD8C File Offset: 0x00049F8C
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x000074F5 File Offset: 0x000056F5
		public unsafe static Type IEnumerableType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_IEnumerableType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_IEnumerableType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x0004BDB4 File Offset: 0x00049FB4
		// (set) Token: 0x06001017 RID: 4119 RVA: 0x00007507 File Offset: 0x00005707
		public unsafe static Type IListType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_IListType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_IListType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x0004BDDC File Offset: 0x00049FDC
		// (set) Token: 0x06001019 RID: 4121 RVA: 0x00007519 File Offset: 0x00005719
		public unsafe static Type ObjectArrayType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_ObjectArrayType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_ObjectArrayType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x0004BE04 File Offset: 0x0004A004
		// (set) Token: 0x0600101B RID: 4123 RVA: 0x0000752B File Offset: 0x0000572B
		public unsafe static Type StringArrayType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_StringArrayType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_StringArrayType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x0004BE2C File Offset: 0x0004A02C
		// (set) Token: 0x0600101D RID: 4125 RVA: 0x0000753D File Offset: 0x0000573D
		public unsafe static Type XmlAtomicValueArrayType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_XmlAtomicValueArrayType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_XmlAtomicValueArrayType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x0004BE54 File Offset: 0x0004A054
		// (set) Token: 0x0600101F RID: 4127 RVA: 0x0000754F File Offset: 0x0000574F
		public unsafe static Type DecimalType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_DecimalType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_DecimalType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x0004BE7C File Offset: 0x0004A07C
		// (set) Token: 0x06001021 RID: 4129 RVA: 0x00007561 File Offset: 0x00005761
		public unsafe static Type Int32Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_Int32Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_Int32Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x0004BEA4 File Offset: 0x0004A0A4
		// (set) Token: 0x06001023 RID: 4131 RVA: 0x00007573 File Offset: 0x00005773
		public unsafe static Type Int64Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_Int64Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_Int64Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x0004BECC File Offset: 0x0004A0CC
		// (set) Token: 0x06001025 RID: 4133 RVA: 0x00007585 File Offset: 0x00005785
		public unsafe static Type StringType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_StringType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_StringType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x0004BEF4 File Offset: 0x0004A0F4
		// (set) Token: 0x06001027 RID: 4135 RVA: 0x00007597 File Offset: 0x00005797
		public unsafe static Type XmlAtomicValueType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_XmlAtomicValueType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_XmlAtomicValueType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x0004BF1C File Offset: 0x0004A11C
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x000075A9 File Offset: 0x000057A9
		public unsafe static Type ObjectType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_ObjectType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_ObjectType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x0004BF44 File Offset: 0x0004A144
		// (set) Token: 0x0600102B RID: 4139 RVA: 0x000075BB File Offset: 0x000057BB
		public unsafe static Type ByteType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_ByteType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_ByteType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x0004BF6C File Offset: 0x0004A16C
		// (set) Token: 0x0600102D RID: 4141 RVA: 0x000075CD File Offset: 0x000057CD
		public unsafe static Type Int16Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_Int16Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_Int16Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x0004BF94 File Offset: 0x0004A194
		// (set) Token: 0x0600102F RID: 4143 RVA: 0x000075DF File Offset: 0x000057DF
		public unsafe static Type SByteType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_SByteType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_SByteType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x0004BFBC File Offset: 0x0004A1BC
		// (set) Token: 0x06001031 RID: 4145 RVA: 0x000075F1 File Offset: 0x000057F1
		public unsafe static Type UInt16Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_UInt16Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_UInt16Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x0004BFE4 File Offset: 0x0004A1E4
		// (set) Token: 0x06001033 RID: 4147 RVA: 0x00007603 File Offset: 0x00005803
		public unsafe static Type UInt32Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_UInt32Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_UInt32Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x0004C00C File Offset: 0x0004A20C
		// (set) Token: 0x06001035 RID: 4149 RVA: 0x00007615 File Offset: 0x00005815
		public unsafe static Type UInt64Type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_UInt64Type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_UInt64Type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x0004C034 File Offset: 0x0004A234
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x00007627 File Offset: 0x00005827
		public unsafe static Type XPathItemType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_XPathItemType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_XPathItemType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x0004C05C File Offset: 0x0004A25C
		// (set) Token: 0x06001039 RID: 4153 RVA: 0x00007639 File Offset: 0x00005839
		public unsafe static Type DoubleType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_DoubleType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_DoubleType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x0004C084 File Offset: 0x0004A284
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x0000764B File Offset: 0x0000584B
		public unsafe static Type SingleType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_SingleType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_SingleType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x0004C0AC File Offset: 0x0004A2AC
		// (set) Token: 0x0600103D RID: 4157 RVA: 0x0000765D File Offset: 0x0000585D
		public unsafe static Type DateTimeType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_DateTimeType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_DateTimeType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x0004C0D4 File Offset: 0x0004A2D4
		// (set) Token: 0x0600103F RID: 4159 RVA: 0x0000766F File Offset: 0x0000586F
		public unsafe static Type DateTimeOffsetType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_DateTimeOffsetType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_DateTimeOffsetType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x0004C0FC File Offset: 0x0004A2FC
		// (set) Token: 0x06001041 RID: 4161 RVA: 0x00007681 File Offset: 0x00005881
		public unsafe static Type BooleanType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_BooleanType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_BooleanType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x0004C124 File Offset: 0x0004A324
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x00007693 File Offset: 0x00005893
		public unsafe static Type ByteArrayType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_ByteArrayType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_ByteArrayType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x0004C14C File Offset: 0x0004A34C
		// (set) Token: 0x06001045 RID: 4165 RVA: 0x000076A5 File Offset: 0x000058A5
		public unsafe static Type XmlQualifiedNameType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_XmlQualifiedNameType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_XmlQualifiedNameType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x0004C174 File Offset: 0x0004A374
		// (set) Token: 0x06001047 RID: 4167 RVA: 0x000076B7 File Offset: 0x000058B7
		public unsafe static Type UriType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_UriType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_UriType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x0004C19C File Offset: 0x0004A39C
		// (set) Token: 0x06001049 RID: 4169 RVA: 0x000076C9 File Offset: 0x000058C9
		public unsafe static Type TimeSpanType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_TimeSpanType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_TimeSpanType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x0004C1C4 File Offset: 0x0004A3C4
		// (set) Token: 0x0600104B RID: 4171 RVA: 0x000076DB File Offset: 0x000058DB
		public unsafe static Type XPathNavigatorType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlBaseConverter.NativeFieldInfoPtr_XPathNavigatorType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlBaseConverter.NativeFieldInfoPtr_XPathNavigatorType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeFieldInfoPtr_schemaType;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeFieldInfoPtr_typeCode;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeFieldInfoPtr_clrTypeDefault;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeFieldInfoPtr_ICollectionType;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeFieldInfoPtr_IEnumerableType;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeFieldInfoPtr_IListType;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeFieldInfoPtr_ObjectArrayType;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeFieldInfoPtr_StringArrayType;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeFieldInfoPtr_XmlAtomicValueArrayType;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeFieldInfoPtr_DecimalType;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeFieldInfoPtr_Int32Type;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeFieldInfoPtr_Int64Type;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeFieldInfoPtr_StringType;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeFieldInfoPtr_XmlAtomicValueType;

		// Token: 0x04000BCD RID: 3021
		private static readonly IntPtr NativeFieldInfoPtr_ObjectType;

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeFieldInfoPtr_ByteType;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeFieldInfoPtr_Int16Type;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeFieldInfoPtr_SByteType;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeFieldInfoPtr_UInt16Type;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeFieldInfoPtr_UInt32Type;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeFieldInfoPtr_UInt64Type;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeFieldInfoPtr_XPathItemType;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeFieldInfoPtr_DoubleType;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeFieldInfoPtr_SingleType;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeFieldInfoPtr_DateTimeType;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeFieldInfoPtr_DateTimeOffsetType;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeFieldInfoPtr_BooleanType;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeFieldInfoPtr_ByteArrayType;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeFieldInfoPtr_XmlQualifiedNameType;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeFieldInfoPtr_UriType;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeFieldInfoPtr_TimeSpanType;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeFieldInfoPtr_XPathNavigatorType;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaType_0;

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlTypeCode_0;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_0;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlBaseConverter_Type_0;

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_DateTime_0;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Double_0;

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Int32_0;

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Int64_0;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_String_0;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Boolean_0;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_DateTimeOffset_0;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Double_0;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int32_0;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Int64_0;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_String_0;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Virtual_DateTime_Object_0;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_DateTime_0;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_String_0;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTimeOffset_Public_Virtual_DateTimeOffset_Object_0;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_String_0;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Virtual_Decimal_Object_0;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Boolean_0;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_DateTime_0;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Int32_0;

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Int64_0;

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_String_0;

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Virtual_Double_Object_0;

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Boolean_0;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_DateTime_0;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Double_0;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Int64_0;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_String_0;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Virtual_Int32_Object_0;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Boolean_0;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_DateTime_0;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Double_0;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Int32_0;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_String_0;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Virtual_Int64_Object_0;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Double_0;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_String_0;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Virtual_Single_Object_0;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTime_0;

		// Token: 0x04000C0C RID: 3084
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_DateTimeOffset_0;

		// Token: 0x04000C0D RID: 3085
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Decimal_0;

		// Token: 0x04000C0E RID: 3086
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Double_0;

		// Token: 0x04000C0F RID: 3087
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Int32_0;

		// Token: 0x04000C10 RID: 3088
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Int64_0;

		// Token: 0x04000C11 RID: 3089
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Single_0;

		// Token: 0x04000C12 RID: 3090
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_IXmlNamespaceResolver_0;

		// Token: 0x04000C13 RID: 3091
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Object_0;

		// Token: 0x04000C14 RID: 3092
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Boolean_Type_0;

		// Token: 0x04000C15 RID: 3093
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_DateTime_Type_0;

		// Token: 0x04000C16 RID: 3094
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Decimal_Type_0;

		// Token: 0x04000C17 RID: 3095
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Double_Type_0;

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int32_Type_0;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Int64_Type_0;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_String_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Virtual_Object_Object_Type_0;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Protected_get_XmlSchemaType_0;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Protected_get_XmlTypeCode_0;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlTypeName_Protected_get_String_0;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultClrType_Protected_get_Type_0;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeMethodInfoPtr_IsDerivedFrom_Protected_Static_Boolean_Type_Type_0;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvalidClrMappingException_Protected_Exception_Type_Type_0;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeMethodInfoPtr_QNameToString_Protected_Static_String_XmlQualifiedName_0;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeMethodInfoPtr_ChangeListType_Protected_Virtual_New_Object_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeMethodInfoPtr_StringToBase64Binary_Protected_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeMethodInfoPtr_StringToDate_Protected_Static_DateTime_String_0;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeMethodInfoPtr_StringToDateTime_Protected_Static_DateTime_String_0;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeMethodInfoPtr_StringToDayTimeDuration_Protected_Static_TimeSpan_String_0;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeMethodInfoPtr_StringToDuration_Protected_Static_TimeSpan_String_0;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeMethodInfoPtr_StringToGDay_Protected_Static_DateTime_String_0;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeMethodInfoPtr_StringToGMonth_Protected_Static_DateTime_String_0;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeMethodInfoPtr_StringToGMonthDay_Protected_Static_DateTime_String_0;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr_StringToGYear_Protected_Static_DateTime_String_0;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeMethodInfoPtr_StringToGYearMonth_Protected_Static_DateTime_String_0;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeMethodInfoPtr_StringToDateOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_StringToDateTimeOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_StringToGDayOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr_StringToGMonthOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeMethodInfoPtr_StringToGMonthDayOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeMethodInfoPtr_StringToGYearOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeMethodInfoPtr_StringToGYearMonthOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeMethodInfoPtr_StringToHexBinary_Protected_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeMethodInfoPtr_StringToQName_Protected_Static_XmlQualifiedName_String_IXmlNamespaceResolver_0;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeMethodInfoPtr_StringToTime_Protected_Static_DateTime_String_0;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr_StringToTimeOffset_Protected_Static_DateTimeOffset_String_0;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeMethodInfoPtr_StringToYearMonthDuration_Protected_Static_TimeSpan_String_0;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr_AnyUriToString_Protected_Static_String_Uri_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr_Base64BinaryToString_Protected_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_DateToString_Protected_Static_String_DateTime_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr_DateTimeToString_Protected_Static_String_DateTime_0;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr_DayTimeDurationToString_Protected_Static_String_TimeSpan_0;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeMethodInfoPtr_DurationToString_Protected_Static_String_TimeSpan_0;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr_GDayToString_Protected_Static_String_DateTime_0;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeMethodInfoPtr_GMonthToString_Protected_Static_String_DateTime_0;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr_GMonthDayToString_Protected_Static_String_DateTime_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr_GYearToString_Protected_Static_String_DateTime_0;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr_GYearMonthToString_Protected_Static_String_DateTime_0;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeMethodInfoPtr_DateOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeMethodInfoPtr_DateTimeOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeMethodInfoPtr_GDayOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeMethodInfoPtr_GMonthOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeMethodInfoPtr_GMonthDayOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeMethodInfoPtr_GYearOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeMethodInfoPtr_GYearMonthOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeMethodInfoPtr_QNameToString_Protected_Static_String_XmlQualifiedName_IXmlNamespaceResolver_0;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeMethodInfoPtr_TimeToString_Protected_Static_String_DateTime_0;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeMethodInfoPtr_TimeOffsetToString_Protected_Static_String_DateTimeOffset_0;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeMethodInfoPtr_YearMonthDurationToString_Protected_Static_String_TimeSpan_0;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeMethodInfoPtr_DateTimeOffsetToDateTime_Internal_Static_DateTime_DateTimeOffset_0;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeMethodInfoPtr_DecimalToInt32_Internal_Static_Int32_Decimal_0;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeMethodInfoPtr_DecimalToInt64_Protected_Static_Int64_Decimal_0;

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeMethodInfoPtr_DecimalToUInt64_Protected_Static_UInt64_Decimal_0;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeMethodInfoPtr_Int32ToByte_Protected_Static_Byte_Int32_0;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeMethodInfoPtr_Int32ToInt16_Protected_Static_Int16_Int32_0;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeMethodInfoPtr_Int32ToSByte_Protected_Static_SByte_Int32_0;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeMethodInfoPtr_Int32ToUInt16_Protected_Static_UInt16_Int32_0;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeMethodInfoPtr_Int64ToInt32_Protected_Static_Int32_Int64_0;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeMethodInfoPtr_Int64ToUInt32_Protected_Static_UInt32_Int64_0;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr_UntypedAtomicToDateTime_Protected_Static_DateTime_String_0;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr_UntypedAtomicToDateTimeOffset_Protected_Static_DateTimeOffset_String_0;
	}
}

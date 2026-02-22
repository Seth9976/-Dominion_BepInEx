using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000092 RID: 146
	public static class Convert : Object
	{
		// Token: 0x06000884 RID: 2180 RVA: 0x00048284 File Offset: 0x00046484
		// Note: this type is marked as 'beforefieldinit'.
		static Convert()
		{
			Il2CppClassPointerStore<Convert>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Convert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Convert>.NativeClassPtr);
			Convert.NativeFieldInfoPtr_ConvertTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Convert>.NativeClassPtr, "ConvertTypes");
			Convert.NativeFieldInfoPtr_EnumType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Convert>.NativeClassPtr, "EnumType");
			Convert.NativeFieldInfoPtr_base64Table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Convert>.NativeClassPtr, "base64Table");
			Convert.NativeFieldInfoPtr_DBNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Convert>.NativeClassPtr, "DBNull");
			Convert.NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664652);
			Convert.NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_TypeCode_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664653);
			Convert.NativeMethodInfoPtr_DefaultToType_Internal_Static_Object_IConvertible_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664654);
			Convert.NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664655);
			Convert.NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664656);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664657);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664658);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664659);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664660);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664661);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664662);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664663);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664664);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664665);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664666);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664667);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664668);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664669);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664670);
			Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664671);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664672);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664673);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664674);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664675);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664676);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664677);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664678);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664679);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664680);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664681);
			Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664682);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664683);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664684);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664685);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664686);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664687);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664688);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664689);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664690);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664691);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664692);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664693);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664694);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664695);
			Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664696);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664697);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664698);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664699);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664700);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664701);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664702);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664703);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664704);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664705);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664706);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664707);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664708);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664709);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664710);
			Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664711);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664712);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664713);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664714);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664715);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664716);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664717);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664718);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664719);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664720);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664721);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664722);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664723);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664724);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664725);
			Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664726);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664727);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664728);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664729);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664730);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664731);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664732);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664733);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664734);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664735);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664736);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664737);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664738);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664739);
			Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664740);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664741);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664742);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664743);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664744);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664745);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664746);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664747);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664748);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664749);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664750);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664751);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664752);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664753);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664754);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664755);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664756);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664757);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664758);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664759);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664760);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664761);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664762);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664763);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664764);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664765);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664766);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664767);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664768);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664769);
			Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664770);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664771);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664772);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664773);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664774);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664775);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664776);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664777);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664778);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664779);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664780);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664781);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664782);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664783);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664784);
			Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664785);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664786);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664787);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664788);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664789);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664790);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664791);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664792);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664793);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664794);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664795);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664796);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664797);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664798);
			Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664799);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664800);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664801);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664802);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664803);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664804);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664805);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664806);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664807);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664808);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664809);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664810);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664811);
			Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664812);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664813);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664814);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664815);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664816);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664817);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664818);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664819);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664820);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664821);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664822);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664823);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664824);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664825);
			Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664826);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664827);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664828);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664829);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664830);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664831);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664832);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664833);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664834);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664835);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664836);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664837);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664838);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664839);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664840);
			Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664841);
			Convert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664842);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664843);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Object_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664844);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664845);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664846);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664847);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664848);
			Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664849);
			Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664850);
			Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664851);
			Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664852);
			Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_Base64FormattingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664853);
			Convert.NativeMethodInfoPtr_ConvertToBase64Array_Private_Static_Int32_ptr_Char_ptr_Byte_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664854);
			Convert.NativeMethodInfoPtr_ToBase64_CalculateAndValidateOutputLength_Private_Static_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664855);
			Convert.NativeMethodInfoPtr_FromBase64String_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664856);
			Convert.NativeMethodInfoPtr_FromBase64CharPtr_Private_Static_Il2CppStructArray_1_Byte_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664857);
			Convert.NativeMethodInfoPtr_FromBase64_Decode_Private_Static_Int32_ptr_Char_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664858);
			Convert.NativeMethodInfoPtr_FromBase64_ComputeResultLength_Private_Static_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Convert>.NativeClassPtr, 100664859);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00049344 File Offset: 0x00047544
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 278116, RefRangeEnd = 278120, XrefRangeStart = 278113, XrefRangeEnd = 278116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeCode GetTypeCode(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00049388 File Offset: 0x00047588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278143, RefRangeEnd = 278144, XrefRangeStart = 278120, XrefRangeEnd = 278143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ChangeType(Object value, TypeCode typeCode, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_TypeCode_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x000493EC File Offset: 0x000475EC
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 278307, RefRangeEnd = 278324, XrefRangeStart = 278144, XrefRangeEnd = 278307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_DefaultToType_Internal_Static_Object_IConvertible_Type_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00049454 File Offset: 0x00047654
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278331, RefRangeEnd = 278333, XrefRangeStart = 278324, XrefRangeEnd = 278331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ChangeType(Object value, Type conversionType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conversionType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x000494AC File Offset: 0x000476AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 278466, RefRangeEnd = 278469, XrefRangeStart = 278333, XrefRangeEnd = 278466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ChangeType(Object value, Type conversionType, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conversionType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00049514 File Offset: 0x00047714
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278470, RefRangeEnd = 278471, XrefRangeStart = 278469, XrefRangeEnd = 278470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00049558 File Offset: 0x00047758
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 278472, RefRangeEnd = 278475, XrefRangeStart = 278471, XrefRangeEnd = 278472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x000495AC File Offset: 0x000477AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 278475, RefRangeEnd = 278480, XrefRangeStart = 278475, XrefRangeEnd = 278475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x000495EC File Offset: 0x000477EC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 278475, RefRangeEnd = 278480, XrefRangeStart = 278475, XrefRangeEnd = 278480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0004962C File Offset: 0x0004782C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278480, RefRangeEnd = 278482, XrefRangeStart = 278480, XrefRangeEnd = 278480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0004966C File Offset: 0x0004786C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278480, RefRangeEnd = 278482, XrefRangeStart = 278480, XrefRangeEnd = 278482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x000496AC File Offset: 0x000478AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278482, RefRangeEnd = 278484, XrefRangeStart = 278482, XrefRangeEnd = 278482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x000496EC File Offset: 0x000478EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278482, RefRangeEnd = 278484, XrefRangeStart = 278482, XrefRangeEnd = 278484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0004972C File Offset: 0x0004792C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278484, RefRangeEnd = 278486, XrefRangeStart = 278484, XrefRangeEnd = 278484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0004976C File Offset: 0x0004796C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278484, RefRangeEnd = 278486, XrefRangeStart = 278484, XrefRangeEnd = 278486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x000497AC File Offset: 0x000479AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 278490, RefRangeEnd = 278494, XrefRangeStart = 278486, XrefRangeEnd = 278490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x000497F0 File Offset: 0x000479F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278498, RefRangeEnd = 278499, XrefRangeStart = 278494, XrefRangeEnd = 278498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00049844 File Offset: 0x00047A44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278499, RefRangeEnd = 278500, XrefRangeStart = 278499, XrefRangeEnd = 278499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00049884 File Offset: 0x00047A84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278500, RefRangeEnd = 278501, XrefRangeStart = 278500, XrefRangeEnd = 278500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x000498C4 File Offset: 0x00047AC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278506, RefRangeEnd = 278507, XrefRangeStart = 278501, XrefRangeEnd = 278506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00049904 File Offset: 0x00047B04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278508, RefRangeEnd = 278510, XrefRangeStart = 278507, XrefRangeEnd = 278508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00049958 File Offset: 0x00047B58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278510, RefRangeEnd = 278511, XrefRangeStart = 278510, XrefRangeEnd = 278510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00049998 File Offset: 0x00047B98
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 278511, RefRangeEnd = 278520, XrefRangeStart = 278511, XrefRangeEnd = 278511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x000499D8 File Offset: 0x00047BD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278520, RefRangeEnd = 278521, XrefRangeStart = 278520, XrefRangeEnd = 278520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00049A18 File Offset: 0x00047C18
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 210774, RefRangeEnd = 210784, XrefRangeStart = 210774, XrefRangeEnd = 210784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00049A58 File Offset: 0x00047C58
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 278521, RefRangeEnd = 278530, XrefRangeStart = 278521, XrefRangeEnd = 278521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00049A98 File Offset: 0x00047C98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278530, RefRangeEnd = 278531, XrefRangeStart = 278530, XrefRangeEnd = 278530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00049AD8 File Offset: 0x00047CD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278531, RefRangeEnd = 278532, XrefRangeStart = 278531, XrefRangeEnd = 278531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00049B18 File Offset: 0x00047D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278532, RefRangeEnd = 278533, XrefRangeStart = 278532, XrefRangeEnd = 278532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00049B58 File Offset: 0x00047D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278533, XrefRangeEnd = 278550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00049B9C File Offset: 0x00047D9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278564, RefRangeEnd = 278565, XrefRangeStart = 278550, XrefRangeEnd = 278564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ToChar(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToChar_Public_Static_Char_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00049BF0 File Offset: 0x00047DF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278566, RefRangeEnd = 278568, XrefRangeStart = 278565, XrefRangeEnd = 278566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00049C44 File Offset: 0x00047E44
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 278475, RefRangeEnd = 278480, XrefRangeStart = 278475, XrefRangeEnd = 278480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00049C84 File Offset: 0x00047E84
		[CallerCount(0)]
		public unsafe static sbyte ToSByte(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00049CC4 File Offset: 0x00047EC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278568, RefRangeEnd = 278569, XrefRangeStart = 278568, XrefRangeEnd = 278568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00049D04 File Offset: 0x00047F04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278569, RefRangeEnd = 278570, XrefRangeStart = 278569, XrefRangeEnd = 278569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00049D44 File Offset: 0x00047F44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278570, RefRangeEnd = 278571, XrefRangeStart = 278570, XrefRangeEnd = 278570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00049D84 File Offset: 0x00047F84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278571, RefRangeEnd = 278572, XrefRangeStart = 278571, XrefRangeEnd = 278571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00049DC4 File Offset: 0x00047FC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278572, RefRangeEnd = 278573, XrefRangeStart = 278572, XrefRangeEnd = 278572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00049E04 File Offset: 0x00048004
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278573, RefRangeEnd = 278574, XrefRangeStart = 278573, XrefRangeEnd = 278573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00049E44 File Offset: 0x00048044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278574, RefRangeEnd = 278575, XrefRangeStart = 278574, XrefRangeEnd = 278574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00049E84 File Offset: 0x00048084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278583, RefRangeEnd = 278584, XrefRangeStart = 278575, XrefRangeEnd = 278583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00049EC4 File Offset: 0x000480C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278588, RefRangeEnd = 278589, XrefRangeStart = 278584, XrefRangeEnd = 278588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00049F04 File Offset: 0x00048104
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278594, RefRangeEnd = 278595, XrefRangeStart = 278589, XrefRangeEnd = 278594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00049F44 File Offset: 0x00048144
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278596, RefRangeEnd = 278597, XrefRangeStart = 278595, XrefRangeEnd = 278596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00049F98 File Offset: 0x00048198
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278598, RefRangeEnd = 278600, XrefRangeStart = 278597, XrefRangeEnd = 278598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00049FEC File Offset: 0x000481EC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 278475, RefRangeEnd = 278480, XrefRangeStart = 278475, XrefRangeEnd = 278480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0004A02C File Offset: 0x0004822C
		[CallerCount(0)]
		public unsafe static byte ToByte(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0004A06C File Offset: 0x0004826C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278600, RefRangeEnd = 278601, XrefRangeStart = 278600, XrefRangeEnd = 278600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0004A0AC File Offset: 0x000482AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278601, RefRangeEnd = 278602, XrefRangeStart = 278601, XrefRangeEnd = 278601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0004A0EC File Offset: 0x000482EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278602, RefRangeEnd = 278603, XrefRangeStart = 278602, XrefRangeEnd = 278602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0004A12C File Offset: 0x0004832C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 278603, RefRangeEnd = 278607, XrefRangeStart = 278603, XrefRangeEnd = 278603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x0004A16C File Offset: 0x0004836C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278607, RefRangeEnd = 278608, XrefRangeStart = 278607, XrefRangeEnd = 278607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x0004A1AC File Offset: 0x000483AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 278608, RefRangeEnd = 278611, XrefRangeStart = 278608, XrefRangeEnd = 278608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0004A1EC File Offset: 0x000483EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278611, RefRangeEnd = 278612, XrefRangeStart = 278611, XrefRangeEnd = 278611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0004A22C File Offset: 0x0004842C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278620, RefRangeEnd = 278621, XrefRangeStart = 278612, XrefRangeEnd = 278620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0004A26C File Offset: 0x0004846C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278625, RefRangeEnd = 278626, XrefRangeStart = 278621, XrefRangeEnd = 278625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x0004A2AC File Offset: 0x000484AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278631, RefRangeEnd = 278632, XrefRangeStart = 278626, XrefRangeEnd = 278631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0004A2EC File Offset: 0x000484EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278637, RefRangeEnd = 278639, XrefRangeStart = 278632, XrefRangeEnd = 278637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0004A330 File Offset: 0x00048530
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 278640, RefRangeEnd = 278643, XrefRangeStart = 278639, XrefRangeEnd = 278640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0004A384 File Offset: 0x00048584
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278644, RefRangeEnd = 278646, XrefRangeStart = 278643, XrefRangeEnd = 278644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0004A3D8 File Offset: 0x000485D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278646, RefRangeEnd = 278648, XrefRangeStart = 278646, XrefRangeEnd = 278646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0004A418 File Offset: 0x00048618
		[CallerCount(0)]
		public unsafe static short ToInt16(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x0004A458 File Offset: 0x00048658
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278648, RefRangeEnd = 278649, XrefRangeStart = 278648, XrefRangeEnd = 278648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0004A498 File Offset: 0x00048698
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 278511, RefRangeEnd = 278520, XrefRangeStart = 278511, XrefRangeEnd = 278520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0004A4D8 File Offset: 0x000486D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278649, RefRangeEnd = 278650, XrefRangeStart = 278649, XrefRangeEnd = 278649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0004A518 File Offset: 0x00048718
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278650, RefRangeEnd = 278651, XrefRangeStart = 278650, XrefRangeEnd = 278650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0004A558 File Offset: 0x00048758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278651, RefRangeEnd = 278652, XrefRangeStart = 278651, XrefRangeEnd = 278651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0004A598 File Offset: 0x00048798
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278652, RefRangeEnd = 278653, XrefRangeStart = 278652, XrefRangeEnd = 278652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0004A5D8 File Offset: 0x000487D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278653, RefRangeEnd = 278654, XrefRangeStart = 278653, XrefRangeEnd = 278653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0004A618 File Offset: 0x00048818
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278662, RefRangeEnd = 278663, XrefRangeStart = 278654, XrefRangeEnd = 278662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0004A658 File Offset: 0x00048858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278667, RefRangeEnd = 278668, XrefRangeStart = 278663, XrefRangeEnd = 278667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0004A698 File Offset: 0x00048898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278673, RefRangeEnd = 278674, XrefRangeStart = 278668, XrefRangeEnd = 278673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0004A6D8 File Offset: 0x000488D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278679, RefRangeEnd = 278681, XrefRangeStart = 278674, XrefRangeEnd = 278679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0004A71C File Offset: 0x0004891C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278682, RefRangeEnd = 278683, XrefRangeStart = 278681, XrefRangeEnd = 278682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0004A770 File Offset: 0x00048970
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278684, RefRangeEnd = 278686, XrefRangeStart = 278683, XrefRangeEnd = 278684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0004A7C4 File Offset: 0x000489C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278646, RefRangeEnd = 278648, XrefRangeStart = 278646, XrefRangeEnd = 278648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0004A804 File Offset: 0x00048A04
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 210774, RefRangeEnd = 210784, XrefRangeStart = 210774, XrefRangeEnd = 210784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0004A844 File Offset: 0x00048A44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278686, RefRangeEnd = 278687, XrefRangeStart = 278686, XrefRangeEnd = 278686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0004A884 File Offset: 0x00048A84
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 278511, RefRangeEnd = 278520, XrefRangeStart = 278511, XrefRangeEnd = 278520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0004A8C4 File Offset: 0x00048AC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278687, RefRangeEnd = 278688, XrefRangeStart = 278687, XrefRangeEnd = 278687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0004A904 File Offset: 0x00048B04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278688, RefRangeEnd = 278689, XrefRangeStart = 278688, XrefRangeEnd = 278688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0004A944 File Offset: 0x00048B44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278689, RefRangeEnd = 278690, XrefRangeStart = 278689, XrefRangeEnd = 278689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0004A984 File Offset: 0x00048B84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278690, RefRangeEnd = 278691, XrefRangeStart = 278690, XrefRangeEnd = 278690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0004A9C4 File Offset: 0x00048BC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278691, RefRangeEnd = 278692, XrefRangeStart = 278691, XrefRangeEnd = 278691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0004AA04 File Offset: 0x00048C04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278700, RefRangeEnd = 278701, XrefRangeStart = 278692, XrefRangeEnd = 278700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0004AA44 File Offset: 0x00048C44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278705, RefRangeEnd = 278706, XrefRangeStart = 278701, XrefRangeEnd = 278705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0004AA84 File Offset: 0x00048C84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278711, RefRangeEnd = 278712, XrefRangeStart = 278706, XrefRangeEnd = 278711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0004AAC4 File Offset: 0x00048CC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278713, RefRangeEnd = 278714, XrefRangeStart = 278712, XrefRangeEnd = 278713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0004AB18 File Offset: 0x00048D18
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 278715, RefRangeEnd = 278723, XrefRangeStart = 278714, XrefRangeEnd = 278715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0004AB5C File Offset: 0x00048D5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 278724, RefRangeEnd = 278727, XrefRangeStart = 278723, XrefRangeEnd = 278724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0004ABB0 File Offset: 0x00048DB0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 278727, RefRangeEnd = 278739, XrefRangeStart = 278727, XrefRangeEnd = 278727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0004ABF0 File Offset: 0x00048DF0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 210774, RefRangeEnd = 210784, XrefRangeStart = 210774, XrefRangeEnd = 210784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0004AC30 File Offset: 0x00048E30
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 278511, RefRangeEnd = 278520, XrefRangeStart = 278511, XrefRangeEnd = 278520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0004AC70 File Offset: 0x00048E70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278739, RefRangeEnd = 278740, XrefRangeStart = 278739, XrefRangeEnd = 278739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0004ACB0 File Offset: 0x00048EB0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 210774, RefRangeEnd = 210784, XrefRangeStart = 210774, XrefRangeEnd = 210784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0004ACF0 File Offset: 0x00048EF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278740, RefRangeEnd = 278741, XrefRangeStart = 278740, XrefRangeEnd = 278740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0004AD30 File Offset: 0x00048F30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278741, RefRangeEnd = 278742, XrefRangeStart = 278741, XrefRangeEnd = 278741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0004AD70 File Offset: 0x00048F70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278742, RefRangeEnd = 278743, XrefRangeStart = 278742, XrefRangeEnd = 278742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0004ADB0 File Offset: 0x00048FB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278747, RefRangeEnd = 278748, XrefRangeStart = 278743, XrefRangeEnd = 278747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0004ADF0 File Offset: 0x00048FF0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 278748, RefRangeEnd = 278758, XrefRangeStart = 278748, XrefRangeEnd = 278748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0004AE30 File Offset: 0x00049030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278762, RefRangeEnd = 278763, XrefRangeStart = 278758, XrefRangeEnd = 278762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0004AE70 File Offset: 0x00049070
		[CallerCount(78)]
		[CachedScanResults(RefRangeStart = 278768, RefRangeEnd = 278846, XrefRangeStart = 278763, XrefRangeEnd = 278768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0004AEB4 File Offset: 0x000490B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278847, RefRangeEnd = 278849, XrefRangeStart = 278846, XrefRangeEnd = 278847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x0004AF08 File Offset: 0x00049108
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278850, RefRangeEnd = 278852, XrefRangeStart = 278849, XrefRangeEnd = 278850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x0004AF4C File Offset: 0x0004914C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278853, RefRangeEnd = 278855, XrefRangeStart = 278852, XrefRangeEnd = 278853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0004AFA0 File Offset: 0x000491A0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 278727, RefRangeEnd = 278739, XrefRangeStart = 278727, XrefRangeEnd = 278739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0004AFE0 File Offset: 0x000491E0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 210774, RefRangeEnd = 210784, XrefRangeStart = 210774, XrefRangeEnd = 210784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0004B020 File Offset: 0x00049220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278855, RefRangeEnd = 278856, XrefRangeStart = 278855, XrefRangeEnd = 278855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0004B060 File Offset: 0x00049260
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 278511, RefRangeEnd = 278520, XrefRangeStart = 278511, XrefRangeEnd = 278520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0004B0A0 File Offset: 0x000492A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278856, RefRangeEnd = 278857, XrefRangeStart = 278856, XrefRangeEnd = 278856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0004B0E0 File Offset: 0x000492E0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 210774, RefRangeEnd = 210784, XrefRangeStart = 210774, XrefRangeEnd = 210784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0004B120 File Offset: 0x00049320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278857, RefRangeEnd = 278858, XrefRangeStart = 278857, XrefRangeEnd = 278857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0004B160 File Offset: 0x00049360
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278858, RefRangeEnd = 278859, XrefRangeStart = 278858, XrefRangeEnd = 278858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0004B1A0 File Offset: 0x000493A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278859, RefRangeEnd = 278860, XrefRangeStart = 278859, XrefRangeEnd = 278859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0004B1E0 File Offset: 0x000493E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278863, RefRangeEnd = 278864, XrefRangeStart = 278860, XrefRangeEnd = 278863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0004B220 File Offset: 0x00049420
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278864, RefRangeEnd = 278865, XrefRangeStart = 278864, XrefRangeEnd = 278864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0004B260 File Offset: 0x00049460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278870, RefRangeEnd = 278871, XrefRangeStart = 278865, XrefRangeEnd = 278870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0004B2A0 File Offset: 0x000494A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278872, RefRangeEnd = 278873, XrefRangeStart = 278871, XrefRangeEnd = 278872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0004B2F4 File Offset: 0x000494F4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 278874, RefRangeEnd = 278880, XrefRangeStart = 278873, XrefRangeEnd = 278874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0004B348 File Offset: 0x00049548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278880, RefRangeEnd = 278881, XrefRangeStart = 278880, XrefRangeEnd = 278880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0004B388 File Offset: 0x00049588
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 210774, RefRangeEnd = 210784, XrefRangeStart = 210774, XrefRangeEnd = 210784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0004B3C8 File Offset: 0x000495C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278881, RefRangeEnd = 278882, XrefRangeStart = 278881, XrefRangeEnd = 278881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0004B408 File Offset: 0x00049608
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 278511, RefRangeEnd = 278520, XrefRangeStart = 278511, XrefRangeEnd = 278520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0004B448 File Offset: 0x00049648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278882, RefRangeEnd = 278883, XrefRangeStart = 278882, XrefRangeEnd = 278882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0004B488 File Offset: 0x00049688
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 210774, RefRangeEnd = 210784, XrefRangeStart = 210774, XrefRangeEnd = 210784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0004B4C8 File Offset: 0x000496C8
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 278883, RefRangeEnd = 278917, XrefRangeStart = 278883, XrefRangeEnd = 278883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0004B508 File Offset: 0x00049708
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0004B548 File Offset: 0x00049748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278917, RefRangeEnd = 278918, XrefRangeStart = 278917, XrefRangeEnd = 278917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0004B588 File Offset: 0x00049788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278926, RefRangeEnd = 278927, XrefRangeStart = 278918, XrefRangeEnd = 278926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0004B5C8 File Offset: 0x000497C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 278932, RefRangeEnd = 278934, XrefRangeStart = 278927, XrefRangeEnd = 278932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0004B608 File Offset: 0x00049808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278939, RefRangeEnd = 278940, XrefRangeStart = 278934, XrefRangeEnd = 278939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0004B648 File Offset: 0x00049848
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 278945, RefRangeEnd = 278982, XrefRangeStart = 278940, XrefRangeEnd = 278945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0004B68C File Offset: 0x0004988C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278983, RefRangeEnd = 278984, XrefRangeStart = 278982, XrefRangeEnd = 278983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0004B6E0 File Offset: 0x000498E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 278985, RefRangeEnd = 278990, XrefRangeStart = 278984, XrefRangeEnd = 278985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x0004B734 File Offset: 0x00049934
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 278727, RefRangeEnd = 278739, XrefRangeStart = 278727, XrefRangeEnd = 278739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0004B774 File Offset: 0x00049974
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 210774, RefRangeEnd = 210784, XrefRangeStart = 210774, XrefRangeEnd = 210784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(char value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0004B7B4 File Offset: 0x000499B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278990, RefRangeEnd = 278991, XrefRangeStart = 278990, XrefRangeEnd = 278990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0004B7F4 File Offset: 0x000499F4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 278511, RefRangeEnd = 278520, XrefRangeStart = 278511, XrefRangeEnd = 278520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0004B834 File Offset: 0x00049A34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278991, RefRangeEnd = 278992, XrefRangeStart = 278991, XrefRangeEnd = 278991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0004B874 File Offset: 0x00049A74
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 210774, RefRangeEnd = 210784, XrefRangeStart = 210774, XrefRangeEnd = 210784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0004B8B4 File Offset: 0x00049AB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278992, RefRangeEnd = 278993, XrefRangeStart = 278992, XrefRangeEnd = 278992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0004B8F4 File Offset: 0x00049AF4
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 210668, RefRangeEnd = 210745, XrefRangeStart = 210668, XrefRangeEnd = 210745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0004B934 File Offset: 0x00049B34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278993, RefRangeEnd = 278994, XrefRangeStart = 278993, XrefRangeEnd = 278993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0004B974 File Offset: 0x00049B74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279002, RefRangeEnd = 279003, XrefRangeStart = 278994, XrefRangeEnd = 279002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0004B9B4 File Offset: 0x00049BB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279008, RefRangeEnd = 279009, XrefRangeStart = 279003, XrefRangeEnd = 279008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0004B9F4 File Offset: 0x00049BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279014, RefRangeEnd = 279015, XrefRangeStart = 279009, XrefRangeEnd = 279014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0004BA34 File Offset: 0x00049C34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279016, RefRangeEnd = 279017, XrefRangeStart = 279015, XrefRangeEnd = 279016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0004BA88 File Offset: 0x00049C88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 279018, RefRangeEnd = 279021, XrefRangeStart = 279017, XrefRangeEnd = 279018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0004BADC File Offset: 0x00049CDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279021, RefRangeEnd = 279022, XrefRangeStart = 279021, XrefRangeEnd = 279021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0004BB1C File Offset: 0x00049D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279022, RefRangeEnd = 279023, XrefRangeStart = 279022, XrefRangeEnd = 279022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0004BB5C File Offset: 0x00049D5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279023, RefRangeEnd = 279024, XrefRangeStart = 279023, XrefRangeEnd = 279023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0004BB9C File Offset: 0x00049D9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279024, RefRangeEnd = 279025, XrefRangeStart = 279024, XrefRangeEnd = 279024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0004BBDC File Offset: 0x00049DDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279025, RefRangeEnd = 279026, XrefRangeStart = 279025, XrefRangeEnd = 279025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0004BC1C File Offset: 0x00049E1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279026, RefRangeEnd = 279027, XrefRangeStart = 279026, XrefRangeEnd = 279026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0004BC5C File Offset: 0x00049E5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279027, RefRangeEnd = 279028, XrefRangeStart = 279027, XrefRangeEnd = 279027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0004BC9C File Offset: 0x00049E9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279028, RefRangeEnd = 279029, XrefRangeStart = 279028, XrefRangeEnd = 279028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0004BCDC File Offset: 0x00049EDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279029, RefRangeEnd = 279030, XrefRangeStart = 279029, XrefRangeEnd = 279029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0004BD1C File Offset: 0x00049F1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279034, RefRangeEnd = 279035, XrefRangeStart = 279030, XrefRangeEnd = 279034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0004BD5C File Offset: 0x00049F5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279036, RefRangeEnd = 279037, XrefRangeStart = 279035, XrefRangeEnd = 279036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0004BDB0 File Offset: 0x00049FB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279037, RefRangeEnd = 279038, XrefRangeStart = 279037, XrefRangeEnd = 279037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0004BDF0 File Offset: 0x00049FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279038, XrefRangeEnd = 279039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0004BE34 File Offset: 0x0004A034
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279040, RefRangeEnd = 279042, XrefRangeStart = 279039, XrefRangeEnd = 279040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0004BE88 File Offset: 0x0004A088
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279042, RefRangeEnd = 279043, XrefRangeStart = 279042, XrefRangeEnd = 279042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0004BEC8 File Offset: 0x0004A0C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279043, RefRangeEnd = 279044, XrefRangeStart = 279043, XrefRangeEnd = 279043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x0004BF08 File Offset: 0x0004A108
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279044, RefRangeEnd = 279045, XrefRangeStart = 279044, XrefRangeEnd = 279044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0004BF48 File Offset: 0x0004A148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279045, RefRangeEnd = 279046, XrefRangeStart = 279045, XrefRangeEnd = 279045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0004BF88 File Offset: 0x0004A188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279046, RefRangeEnd = 279047, XrefRangeStart = 279046, XrefRangeEnd = 279046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0004BFC8 File Offset: 0x0004A1C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279047, RefRangeEnd = 279048, XrefRangeStart = 279047, XrefRangeEnd = 279047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0004C008 File Offset: 0x0004A208
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279048, RefRangeEnd = 279049, XrefRangeStart = 279048, XrefRangeEnd = 279048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0004C048 File Offset: 0x0004A248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279049, RefRangeEnd = 279050, XrefRangeStart = 279049, XrefRangeEnd = 279049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0004C088 File Offset: 0x0004A288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279050, RefRangeEnd = 279051, XrefRangeStart = 279050, XrefRangeEnd = 279050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0004C0C8 File Offset: 0x0004A2C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 279055, RefRangeEnd = 279059, XrefRangeStart = 279051, XrefRangeEnd = 279055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0004C108 File Offset: 0x0004A308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279063, RefRangeEnd = 279064, XrefRangeStart = 279059, XrefRangeEnd = 279063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0004C15C File Offset: 0x0004A35C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279064, RefRangeEnd = 279065, XrefRangeStart = 279064, XrefRangeEnd = 279064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0004C19C File Offset: 0x0004A39C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279070, RefRangeEnd = 279071, XrefRangeStart = 279065, XrefRangeEnd = 279070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0004C1E0 File Offset: 0x0004A3E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279076, RefRangeEnd = 279078, XrefRangeStart = 279071, XrefRangeEnd = 279076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0004C234 File Offset: 0x0004A434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279082, RefRangeEnd = 279083, XrefRangeStart = 279078, XrefRangeEnd = 279082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0004C274 File Offset: 0x0004A474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279087, RefRangeEnd = 279088, XrefRangeStart = 279083, XrefRangeEnd = 279087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0004C2B4 File Offset: 0x0004A4B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279092, RefRangeEnd = 279093, XrefRangeStart = 279088, XrefRangeEnd = 279092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0004C2F4 File Offset: 0x0004A4F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279097, RefRangeEnd = 279098, XrefRangeStart = 279093, XrefRangeEnd = 279097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0004C334 File Offset: 0x0004A534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279102, RefRangeEnd = 279103, XrefRangeStart = 279098, XrefRangeEnd = 279102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0004C374 File Offset: 0x0004A574
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279107, RefRangeEnd = 279108, XrefRangeStart = 279103, XrefRangeEnd = 279107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0004C3B4 File Offset: 0x0004A5B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279112, RefRangeEnd = 279114, XrefRangeStart = 279108, XrefRangeEnd = 279112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0004C3F4 File Offset: 0x0004A5F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279118, RefRangeEnd = 279119, XrefRangeStart = 279114, XrefRangeEnd = 279118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0004C434 File Offset: 0x0004A634
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279123, RefRangeEnd = 279125, XrefRangeStart = 279119, XrefRangeEnd = 279123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0004C474 File Offset: 0x0004A674
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279129, RefRangeEnd = 279131, XrefRangeStart = 279125, XrefRangeEnd = 279129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0004C4B4 File Offset: 0x0004A6B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279139, RefRangeEnd = 279140, XrefRangeStart = 279131, XrefRangeEnd = 279139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0004C508 File Offset: 0x0004A708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108457, RefRangeEnd = 108458, XrefRangeStart = 108457, XrefRangeEnd = 108458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0004C548 File Offset: 0x0004A748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279144, RefRangeEnd = 279145, XrefRangeStart = 279140, XrefRangeEnd = 279144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0004C588 File Offset: 0x0004A788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279150, RefRangeEnd = 279151, XrefRangeStart = 279145, XrefRangeEnd = 279150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ToDateTime(string value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0004C5DC File Offset: 0x0004A7DC
		[CallerCount(69)]
		[CachedScanResults(RefRangeStart = 279162, RefRangeEnd = 279231, XrefRangeStart = 279151, XrefRangeEnd = 279162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0004C618 File Offset: 0x0004A818
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279239, RefRangeEnd = 279240, XrefRangeStart = 279231, XrefRangeEnd = 279239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Object value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Object_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0004C668 File Offset: 0x0004A868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279244, RefRangeEnd = 279245, XrefRangeStart = 279240, XrefRangeEnd = 279244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(char value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Char_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0004C6B4 File Offset: 0x0004A8B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279246, RefRangeEnd = 279247, XrefRangeStart = 279245, XrefRangeEnd = 279246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(int value, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0004C700 File Offset: 0x0004A900
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279252, RefRangeEnd = 279254, XrefRangeStart = 279247, XrefRangeEnd = 279252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0004C738 File Offset: 0x0004A938
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0004C774 File Offset: 0x0004A974
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 279262, RefRangeEnd = 279266, XrefRangeStart = 279254, XrefRangeEnd = 279262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(string value, int fromBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0004C7C4 File Offset: 0x0004A9C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 279267, RefRangeEnd = 279270, XrefRangeStart = 279266, XrefRangeEnd = 279267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(int value, int toBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToString_Public_Static_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0004C80C File Offset: 0x0004AA0C
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 279274, RefRangeEnd = 279336, XrefRangeStart = 279270, XrefRangeEnd = 279274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToBase64String(Il2CppStructArray<byte> inArray)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0004C848 File Offset: 0x0004AA48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279340, RefRangeEnd = 279342, XrefRangeStart = 279336, XrefRangeEnd = 279340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToBase64String(Il2CppStructArray<byte> inArray, int offset, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0004C8A0 File Offset: 0x0004AAA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 279353, RefRangeEnd = 279356, XrefRangeStart = 279342, XrefRangeEnd = 279353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToBase64String(Il2CppStructArray<byte> inArray, int offset, int length, Base64FormattingOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inArray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_Base64FormattingOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0004C908 File Offset: 0x0004AB08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279362, RefRangeEnd = 279363, XrefRangeStart = 279356, XrefRangeEnd = 279362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = outChars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = inData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref insertLineBreaks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ConvertToBase64Array_Private_Static_Int32_ptr_Char_ptr_Byte_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0004C97C File Offset: 0x0004AB7C
		[CallerCount(0)]
		public unsafe static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputLength;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref insertLineBreaks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_ToBase64_CalculateAndValidateOutputLength_Private_Static_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0004C9C8 File Offset: 0x0004ABC8
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 279374, RefRangeEnd = 279417, XrefRangeStart = 279363, XrefRangeEnd = 279374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromBase64String(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_FromBase64String_Public_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0004CA0C File Offset: 0x0004AC0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279429, RefRangeEnd = 279431, XrefRangeStart = 279417, XrefRangeEnd = 279429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromBase64CharPtr(char* inputPtr, int inputLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = inputPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_FromBase64CharPtr_Private_Static_Il2CppStructArray_1_Byte_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0004CA5C File Offset: 0x0004AC5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279437, RefRangeEnd = 279438, XrefRangeStart = 279431, XrefRangeEnd = 279437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FromBase64_Decode(char* startInputPtr, int inputLength, byte* startDestPtr, int destLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = startInputPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = startDestPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_FromBase64_Decode_Private_Static_Int32_ptr_Char_Int32_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0004CAC4 File Offset: 0x0004ACC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279438, XrefRangeEnd = 279440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = inputPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Convert.NativeMethodInfoPtr_FromBase64_ComputeResultLength_Private_Static_Int32_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00004947 File Offset: 0x00002B47
		public Convert(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x0004CB10 File Offset: 0x0004AD10
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x00004950 File Offset: 0x00002B50
		public unsafe static Il2CppReferenceArray<RuntimeType> ConvertTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Convert.NativeFieldInfoPtr_ConvertTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RuntimeType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Convert.NativeFieldInfoPtr_ConvertTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x0004CB38 File Offset: 0x0004AD38
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x00004962 File Offset: 0x00002B62
		public unsafe static RuntimeType EnumType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Convert.NativeFieldInfoPtr_EnumType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Convert.NativeFieldInfoPtr_EnumType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x0004CB60 File Offset: 0x0004AD60
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x00004974 File Offset: 0x00002B74
		public unsafe static Il2CppStructArray<char> base64Table
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Convert.NativeFieldInfoPtr_base64Table, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Convert.NativeFieldInfoPtr_base64Table, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x0004CB88 File Offset: 0x0004AD88
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x00004986 File Offset: 0x00002B86
		public unsafe static Object DBNull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Convert.NativeFieldInfoPtr_DBNull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Convert.NativeFieldInfoPtr_DBNull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeFieldInfoPtr_ConvertTypes;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeFieldInfoPtr_EnumType;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeFieldInfoPtr_base64Table;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeFieldInfoPtr_DBNull;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Object_0;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_TypeCode_IFormatProvider_0;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_DefaultToType_Internal_Static_Object_IConvertible_Type_IFormatProvider_0;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_ChangeType_Public_Static_Object_Object_Type_IFormatProvider_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Object_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Object_IFormatProvider_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_SByte_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Byte_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int16_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt16_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int32_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt32_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Int64_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_UInt64_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_String_IFormatProvider_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Single_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Double_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Public_Static_Boolean_Decimal_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Object_IFormatProvider_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_SByte_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Byte_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Int16_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt16_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Int32_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt32_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_Int64_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_UInt64_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_String_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_ToChar_Public_Static_Char_String_IFormatProvider_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Object_IFormatProvider_0;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Boolean_0;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Char_0;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Byte_0;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int16_0;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt16_0;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int32_0;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt32_0;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Int64_0;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_UInt64_0;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Single_0;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Double_0;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_String_IFormatProvider_0;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Object_IFormatProvider_0;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Boolean_0;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Char_0;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_SByte_0;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int16_0;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt16_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int32_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt32_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Int64_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_UInt64_0;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Single_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Double_0;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_0;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_String_IFormatProvider_0;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Object_IFormatProvider_0;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Boolean_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Char_0;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_SByte_0;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Byte_0;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt16_0;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int32_0;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt32_0;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Int64_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_UInt64_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Single_0;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Double_0;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_0;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_String_IFormatProvider_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Object_IFormatProvider_0;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Boolean_0;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Char_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_SByte_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Byte_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int16_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int32_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt32_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Int64_0;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_UInt64_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Single_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Double_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_String_IFormatProvider_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Object_IFormatProvider_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Boolean_0;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Char_0;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Byte_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int16_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt16_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt32_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Int64_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_UInt64_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Single_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Double_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_IFormatProvider_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Object_IFormatProvider_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Boolean_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Char_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_SByte_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Byte_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int16_0;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt16_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int32_0;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Int64_0;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_UInt64_0;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Single_0;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Double_0;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_String_IFormatProvider_0;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Object_IFormatProvider_0;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Boolean_0;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Char_0;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_SByte_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Byte_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int16_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt16_0;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Int32_0;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt32_0;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_UInt64_0;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Single_0;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Double_0;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_0;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_String_IFormatProvider_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Object_IFormatProvider_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Boolean_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Char_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_SByte_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Byte_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int16_0;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt16_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int32_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_UInt32_0;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Int64_0;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Single_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Double_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_String_IFormatProvider_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Object_IFormatProvider_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_SByte_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Byte_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int16_0;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt16_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int32_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt32_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Int64_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_UInt64_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Double_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_String_IFormatProvider_0;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Boolean_0;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Object_IFormatProvider_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_SByte_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Byte_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int16_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt16_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int32_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt32_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Int64_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_UInt64_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Single_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_String_IFormatProvider_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Boolean_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Object_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Object_IFormatProvider_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_SByte_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Byte_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int16_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt16_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int32_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt32_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Int64_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_UInt64_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Single_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Double_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_String_IFormatProvider_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Decimal_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Static_Decimal_Boolean_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_String_IFormatProvider_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Object_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Object_IFormatProvider_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Char_IFormatProvider_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int32_IFormatProvider_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int64_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_String_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_String_Int32_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Int32_Int32_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr_ToBase64String_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_Base64FormattingOptions_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToBase64Array_Private_Static_Int32_ptr_Char_ptr_Byte_Int32_Int32_Boolean_0;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeMethodInfoPtr_ToBase64_CalculateAndValidateOutputLength_Private_Static_Int32_Int32_Boolean_0;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeMethodInfoPtr_FromBase64String_Public_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeMethodInfoPtr_FromBase64CharPtr_Private_Static_Il2CppStructArray_1_Byte_ptr_Char_Int32_0;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeMethodInfoPtr_FromBase64_Decode_Private_Static_Int32_ptr_Char_Int32_ptr_Byte_Int32_0;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr_FromBase64_ComputeResultLength_Private_Static_Int32_ptr_Char_Int32_0;
	}
}

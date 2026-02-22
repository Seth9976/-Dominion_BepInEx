using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000093 RID: 147
	[Serializable]
	[StructLayout(2)]
	public struct DateTime
	{
		// Token: 0x0600095E RID: 2398 RVA: 0x0004CBB0 File Offset: 0x0004ADB0
		// Note: this type is marked as 'beforefieldinit'.
		static DateTime()
		{
			Il2CppClassPointerStore<DateTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTime>.NativeClassPtr);
			DateTime.NativeFieldInfoPtr_TicksPerMillisecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksPerMillisecond");
			DateTime.NativeFieldInfoPtr_TicksPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksPerSecond");
			DateTime.NativeFieldInfoPtr_TicksPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksPerMinute");
			DateTime.NativeFieldInfoPtr_TicksPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksPerHour");
			DateTime.NativeFieldInfoPtr_TicksPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksPerDay");
			DateTime.NativeFieldInfoPtr_MillisPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MillisPerSecond");
			DateTime.NativeFieldInfoPtr_MillisPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MillisPerMinute");
			DateTime.NativeFieldInfoPtr_MillisPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MillisPerHour");
			DateTime.NativeFieldInfoPtr_MillisPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MillisPerDay");
			DateTime.NativeFieldInfoPtr_DaysPerYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysPerYear");
			DateTime.NativeFieldInfoPtr_DaysPer4Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysPer4Years");
			DateTime.NativeFieldInfoPtr_DaysPer100Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysPer100Years");
			DateTime.NativeFieldInfoPtr_DaysPer400Years = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysPer400Years");
			DateTime.NativeFieldInfoPtr_DaysTo1601 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysTo1601");
			DateTime.NativeFieldInfoPtr_DaysTo1899 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysTo1899");
			DateTime.NativeFieldInfoPtr_DaysTo1970 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysTo1970");
			DateTime.NativeFieldInfoPtr_DaysTo10000 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysTo10000");
			DateTime.NativeFieldInfoPtr_MinTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MinTicks");
			DateTime.NativeFieldInfoPtr_MaxTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MaxTicks");
			DateTime.NativeFieldInfoPtr_MaxMillis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MaxMillis");
			DateTime.NativeFieldInfoPtr_FileTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "FileTimeOffset");
			DateTime.NativeFieldInfoPtr_DoubleDateOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DoubleDateOffset");
			DateTime.NativeFieldInfoPtr_OADateMinAsTicks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "OADateMinAsTicks");
			DateTime.NativeFieldInfoPtr_OADateMinAsDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "OADateMinAsDouble");
			DateTime.NativeFieldInfoPtr_OADateMaxAsDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "OADateMaxAsDouble");
			DateTime.NativeFieldInfoPtr_DatePartYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DatePartYear");
			DateTime.NativeFieldInfoPtr_DatePartDayOfYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DatePartDayOfYear");
			DateTime.NativeFieldInfoPtr_DatePartMonth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DatePartMonth");
			DateTime.NativeFieldInfoPtr_DatePartDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DatePartDay");
			DateTime.NativeFieldInfoPtr_DaysToMonth365 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysToMonth365");
			DateTime.NativeFieldInfoPtr_DaysToMonth366 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DaysToMonth366");
			DateTime.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MinValue");
			DateTime.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "MaxValue");
			DateTime.NativeFieldInfoPtr_TicksMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksMask");
			DateTime.NativeFieldInfoPtr_FlagsMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "FlagsMask");
			DateTime.NativeFieldInfoPtr_LocalMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "LocalMask");
			DateTime.NativeFieldInfoPtr_TicksCeiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksCeiling");
			DateTime.NativeFieldInfoPtr_KindUnspecified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "KindUnspecified");
			DateTime.NativeFieldInfoPtr_KindUtc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "KindUtc");
			DateTime.NativeFieldInfoPtr_KindLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "KindLocal");
			DateTime.NativeFieldInfoPtr_KindLocalAmbiguousDst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "KindLocalAmbiguousDst");
			DateTime.NativeFieldInfoPtr_KindShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "KindShift");
			DateTime.NativeFieldInfoPtr_TicksField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "TicksField");
			DateTime.NativeFieldInfoPtr_DateDataField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "DateDataField");
			DateTime.NativeFieldInfoPtr_dateData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTime>.NativeClassPtr, "dateData");
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664861);
			DateTime.NativeMethodInfoPtr__ctor_Private_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664862);
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int64_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664863);
			DateTime.NativeMethodInfoPtr__ctor_Internal_Void_Int64_DateTimeKind_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664864);
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664865);
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664866);
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664867);
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664868);
			DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664869);
			DateTime.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664870);
			DateTime.NativeMethodInfoPtr_get_InternalTicks_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664871);
			DateTime.NativeMethodInfoPtr_get_InternalKind_Private_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664872);
			DateTime.NativeMethodInfoPtr_Add_Public_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664873);
			DateTime.NativeMethodInfoPtr_Add_Private_DateTime_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664874);
			DateTime.NativeMethodInfoPtr_AddDays_Public_DateTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664875);
			DateTime.NativeMethodInfoPtr_AddMilliseconds_Public_DateTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664876);
			DateTime.NativeMethodInfoPtr_AddMonths_Public_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664877);
			DateTime.NativeMethodInfoPtr_AddSeconds_Public_DateTime_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664878);
			DateTime.NativeMethodInfoPtr_AddTicks_Public_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664879);
			DateTime.NativeMethodInfoPtr_AddYears_Public_DateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664880);
			DateTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664881);
			DateTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664882);
			DateTime.NativeMethodInfoPtr_DateToTicks_Private_Static_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664883);
			DateTime.NativeMethodInfoPtr_TimeToTicks_Private_Static_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664884);
			DateTime.NativeMethodInfoPtr_DaysInMonth_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664885);
			DateTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664886);
			DateTime.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664887);
			DateTime.NativeMethodInfoPtr_FromBinary_Public_Static_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664888);
			DateTime.NativeMethodInfoPtr_FromBinaryRaw_Internal_Static_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664889);
			DateTime.NativeMethodInfoPtr_FromFileTime_Public_Static_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664890);
			DateTime.NativeMethodInfoPtr_FromFileTimeUtc_Public_Static_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664891);
			DateTime.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664892);
			DateTime.NativeMethodInfoPtr_SpecifyKind_Public_Static_DateTime_DateTime_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664893);
			DateTime.NativeMethodInfoPtr_ToBinaryRaw_Internal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664894);
			DateTime.NativeMethodInfoPtr_get_Date_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664895);
			DateTime.NativeMethodInfoPtr_GetDatePart_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664896);
			DateTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664897);
			DateTime.NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664898);
			DateTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664899);
			DateTime.NativeMethodInfoPtr_get_Hour_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664900);
			DateTime.NativeMethodInfoPtr_IsAmbiguousDaylightSavingTime_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664901);
			DateTime.NativeMethodInfoPtr_get_Kind_Public_get_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664902);
			DateTime.NativeMethodInfoPtr_get_Minute_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664903);
			DateTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664904);
			DateTime.NativeMethodInfoPtr_get_Now_Public_Static_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664905);
			DateTime.NativeMethodInfoPtr_get_UtcNow_Public_Static_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664906);
			DateTime.NativeMethodInfoPtr_GetSystemTimeAsFileTime_Internal_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664907);
			DateTime.NativeMethodInfoPtr_get_Second_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664908);
			DateTime.NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664909);
			DateTime.NativeMethodInfoPtr_get_TimeOfDay_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664910);
			DateTime.NativeMethodInfoPtr_get_Year_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664911);
			DateTime.NativeMethodInfoPtr_IsLeapYear_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664912);
			DateTime.NativeMethodInfoPtr_Parse_Public_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664913);
			DateTime.NativeMethodInfoPtr_Parse_Public_Static_DateTime_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664914);
			DateTime.NativeMethodInfoPtr_ParseExact_Public_Static_DateTime_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664915);
			DateTime.NativeMethodInfoPtr_ParseExact_Public_Static_DateTime_String_String_IFormatProvider_DateTimeStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664916);
			DateTime.NativeMethodInfoPtr_Subtract_Public_TimeSpan_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664917);
			DateTime.NativeMethodInfoPtr_ToFileTimeUtc_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664918);
			DateTime.NativeMethodInfoPtr_ToLocalTime_Public_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664919);
			DateTime.NativeMethodInfoPtr_ToLocalTime_Internal_DateTime_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664920);
			DateTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664921);
			DateTime.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664922);
			DateTime.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664923);
			DateTime.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664924);
			DateTime.NativeMethodInfoPtr_ToUniversalTime_Public_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664925);
			DateTime.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_IFormatProvider_DateTimeStyles_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664926);
			DateTime.NativeMethodInfoPtr_TryParseExact_Public_Static_Boolean_String_Il2CppStringArray_IFormatProvider_DateTimeStyles_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664927);
			DateTime.NativeMethodInfoPtr_op_Addition_Public_Static_DateTime_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664928);
			DateTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_DateTime_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664929);
			DateTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664930);
			DateTime.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664931);
			DateTime.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664932);
			DateTime.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664933);
			DateTime.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664934);
			DateTime.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664935);
			DateTime.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664936);
			DateTime.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664937);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664938);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664939);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664940);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664941);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664942);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664943);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664944);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664945);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664946);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664947);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664948);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664949);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664950);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664951);
			DateTime.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664952);
			DateTime.NativeMethodInfoPtr_TryCreate_Internal_Static_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTime>.NativeClassPtr, 100664953);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x0004D6A8 File Offset: 0x0004B8A8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 279440, RefRangeEnd = 279451, XrefRangeStart = 279440, XrefRangeEnd = 279440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(long ticks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0004D6DC File Offset: 0x0004B8DC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(ulong dateData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Private_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0004D710 File Offset: 0x0004B910
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 279451, RefRangeEnd = 279468, XrefRangeStart = 279451, XrefRangeEnd = 279451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(long ticks, DateTimeKind kind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int64_DateTimeKind_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x0004D750 File Offset: 0x0004B950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279468, RefRangeEnd = 279469, XrefRangeStart = 279468, XrefRangeEnd = 279468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(long ticks, DateTimeKind kind, bool isAmbiguousDst)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAmbiguousDst;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Internal_Void_Int64_DateTimeKind_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0004D7A0 File Offset: 0x0004B9A0
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 279473, RefRangeEnd = 279529, XrefRangeStart = 279469, XrefRangeEnd = 279473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(int year, int month, int day)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0004D7F0 File Offset: 0x0004B9F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279534, RefRangeEnd = 279536, XrefRangeStart = 279529, XrefRangeEnd = 279534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(int year, int month, int day, int hour, int minute, int second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hour;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0004D868 File Offset: 0x0004BA68
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 279541, RefRangeEnd = 279546, XrefRangeStart = 279536, XrefRangeEnd = 279541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hour;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_DateTimeKind_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0004D8F0 File Offset: 0x0004BAF0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 279551, RefRangeEnd = 279569, XrefRangeStart = 279546, XrefRangeEnd = 279551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hour;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecond;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0004D978 File Offset: 0x0004BB78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 279574, RefRangeEnd = 279578, XrefRangeStart = 279569, XrefRangeEnd = 279574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hour;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecond;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_DateTimeKind_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0004DA0C File Offset: 0x0004BC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279578, XrefRangeEnd = 279606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x0004DA5C File Offset: 0x0004BC5C
		public unsafe long InternalTicks
		{
			[CallerCount(56)]
			[CachedScanResults(RefRangeStart = 279606, RefRangeEnd = 279662, XrefRangeStart = 279606, XrefRangeEnd = 279606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_InternalTicks_Internal_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x0004DA8C File Offset: 0x0004BC8C
		public unsafe ulong InternalKind
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_InternalKind_Private_get_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0004DABC File Offset: 0x0004BCBC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 279663, RefRangeEnd = 279678, XrefRangeStart = 279662, XrefRangeEnd = 279663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime Add(TimeSpan value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Add_Public_DateTime_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0004DAFC File Offset: 0x0004BCFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 279700, RefRangeEnd = 279703, XrefRangeStart = 279678, XrefRangeEnd = 279700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime Add(double value, int scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Add_Private_DateTime_Double_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0004DB48 File Offset: 0x0004BD48
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 279704, RefRangeEnd = 279711, XrefRangeStart = 279703, XrefRangeEnd = 279704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime AddDays(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_AddDays_Public_DateTime_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0004DB88 File Offset: 0x0004BD88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 279712, RefRangeEnd = 279716, XrefRangeStart = 279711, XrefRangeEnd = 279712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime AddMilliseconds(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_AddMilliseconds_Public_DateTime_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0004DBC8 File Offset: 0x0004BDC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279736, RefRangeEnd = 279738, XrefRangeStart = 279716, XrefRangeEnd = 279736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime AddMonths(int months)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref months;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_AddMonths_Public_DateTime_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0004DC08 File Offset: 0x0004BE08
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 279739, RefRangeEnd = 279746, XrefRangeStart = 279738, XrefRangeEnd = 279739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime AddSeconds(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_AddSeconds_Public_DateTime_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0004DC48 File Offset: 0x0004BE48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 279746, RefRangeEnd = 279751, XrefRangeStart = 279746, XrefRangeEnd = 279746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime AddTicks(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_AddTicks_Public_DateTime_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0004DC88 File Offset: 0x0004BE88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279760, RefRangeEnd = 279762, XrefRangeStart = 279751, XrefRangeEnd = 279760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime AddYears(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_AddYears_Public_DateTime_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0004DCC8 File Offset: 0x0004BEC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279762, XrefRangeEnd = 279765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0004DD0C File Offset: 0x0004BF0C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 279765, RefRangeEnd = 279771, XrefRangeStart = 279765, XrefRangeEnd = 279765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0004DD4C File Offset: 0x0004BF4C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 279781, RefRangeEnd = 279788, XrefRangeStart = 279771, XrefRangeEnd = 279781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long DateToTicks(int year, int month, int day)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_DateToTicks_Private_Static_Int64_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0004DDA8 File Offset: 0x0004BFA8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 279799, RefRangeEnd = 279804, XrefRangeStart = 279788, XrefRangeEnd = 279799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long TimeToTicks(int hour, int minute, int second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hour;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_TimeToTicks_Private_Static_Int64_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0004DE04 File Offset: 0x0004C004
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 279814, RefRangeEnd = 279823, XrefRangeStart = 279804, XrefRangeEnd = 279814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int DaysInMonth(int year, int month)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_DaysInMonth_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0004DE50 File Offset: 0x0004C050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279823, XrefRangeEnd = 279826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0004DE94 File Offset: 0x0004C094
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 279826, RefRangeEnd = 279829, XrefRangeStart = 279826, XrefRangeEnd = 279826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0004DED4 File Offset: 0x0004C0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279829, XrefRangeEnd = 279832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime FromBinary(long dateData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_FromBinary_Public_Static_DateTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0004DF14 File Offset: 0x0004C114
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279832, RefRangeEnd = 279834, XrefRangeStart = 279832, XrefRangeEnd = 279832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime FromBinaryRaw(long dateData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_FromBinaryRaw_Internal_Static_DateTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0004DF54 File Offset: 0x0004C154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279841, RefRangeEnd = 279842, XrefRangeStart = 279834, XrefRangeEnd = 279841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime FromFileTime(long fileTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fileTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_FromFileTime_Public_Static_DateTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0004DF94 File Offset: 0x0004C194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279843, RefRangeEnd = 279844, XrefRangeStart = 279842, XrefRangeEnd = 279843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime FromFileTimeUtc(long fileTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fileTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_FromFileTimeUtc_Public_Static_DateTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0004DFD4 File Offset: 0x0004C1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279844, XrefRangeEnd = 279856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0004E024 File Offset: 0x0004C224
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279857, RefRangeEnd = 279859, XrefRangeStart = 279856, XrefRangeEnd = 279857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime SpecifyKind(DateTime value, DateTimeKind kind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_SpecifyKind_Public_Static_DateTime_DateTime_DateTimeKind_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0004E070 File Offset: 0x0004C270
		[CallerCount(0)]
		public unsafe long ToBinaryRaw()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToBinaryRaw_Internal_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x0004E0A0 File Offset: 0x0004C2A0
		public unsafe DateTime Date
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 279859, RefRangeEnd = 279865, XrefRangeStart = 279859, XrefRangeEnd = 279859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Date_Public_get_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0004E0D0 File Offset: 0x0004C2D0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 279874, RefRangeEnd = 279880, XrefRangeStart = 279865, XrefRangeEnd = 279874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDatePart(int part)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref part;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_GetDatePart_Private_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x0004E110 File Offset: 0x0004C310
		public unsafe int Day
		{
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 279881, RefRangeEnd = 279918, XrefRangeStart = 279880, XrefRangeEnd = 279881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Day_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x0004E140 File Offset: 0x0004C340
		public unsafe DayOfWeek DayOfWeek
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 279918, RefRangeEnd = 279919, XrefRangeStart = 279918, XrefRangeEnd = 279918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0004E170 File Offset: 0x0004C370
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279919, RefRangeEnd = 279920, XrefRangeStart = 279919, XrefRangeEnd = 279919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x0004E1A0 File Offset: 0x0004C3A0
		public unsafe int Hour
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 279920, RefRangeEnd = 279924, XrefRangeStart = 279920, XrefRangeEnd = 279920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Hour_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0004E1D0 File Offset: 0x0004C3D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279924, RefRangeEnd = 279926, XrefRangeStart = 279924, XrefRangeEnd = 279924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAmbiguousDaylightSavingTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_IsAmbiguousDaylightSavingTime_Internal_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x0004E200 File Offset: 0x0004C400
		public unsafe DateTimeKind Kind
		{
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 279926, RefRangeEnd = 279958, XrefRangeStart = 279926, XrefRangeEnd = 279926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Kind_Public_get_DateTimeKind_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x0004E230 File Offset: 0x0004C430
		public unsafe int Minute
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 279958, RefRangeEnd = 279962, XrefRangeStart = 279958, XrefRangeEnd = 279958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Minute_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x0004E260 File Offset: 0x0004C460
		public unsafe int Month
		{
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 279963, RefRangeEnd = 280002, XrefRangeStart = 279962, XrefRangeEnd = 279963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Month_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x0004E290 File Offset: 0x0004C490
		public unsafe static DateTime Now
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 280011, RefRangeEnd = 280053, XrefRangeStart = 280002, XrefRangeEnd = 280011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Now_Public_Static_get_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x0004E2C0 File Offset: 0x0004C4C0
		public unsafe static DateTime UtcNow
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 280057, RefRangeEnd = 280080, XrefRangeStart = 280053, XrefRangeEnd = 280057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_UtcNow_Public_Static_get_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0004E2F0 File Offset: 0x0004C4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280080, XrefRangeEnd = 280081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetSystemTimeAsFileTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_GetSystemTimeAsFileTime_Internal_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x0004E320 File Offset: 0x0004C520
		public unsafe int Second
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 280081, RefRangeEnd = 280087, XrefRangeStart = 280081, XrefRangeEnd = 280081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Second_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x0004E350 File Offset: 0x0004C550
		public unsafe long Ticks
		{
			[CallerCount(56)]
			[CachedScanResults(RefRangeStart = 279606, RefRangeEnd = 279662, XrefRangeStart = 279606, XrefRangeEnd = 279662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0004E380 File Offset: 0x0004C580
		public unsafe TimeSpan TimeOfDay
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 280087, RefRangeEnd = 280106, XrefRangeStart = 280087, XrefRangeEnd = 280087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_TimeOfDay_Public_get_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x0004E3B0 File Offset: 0x0004C5B0
		public unsafe int Year
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 280107, RefRangeEnd = 280143, XrefRangeStart = 280106, XrefRangeEnd = 280107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_get_Year_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0004E3E0 File Offset: 0x0004C5E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 280143, RefRangeEnd = 280147, XrefRangeStart = 280143, XrefRangeEnd = 280143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLeapYear(int year)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_IsLeapYear_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0004E420 File Offset: 0x0004C620
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 280155, RefRangeEnd = 280158, XrefRangeStart = 280147, XrefRangeEnd = 280155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime Parse(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Parse_Public_Static_DateTime_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0004E464 File Offset: 0x0004C664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280166, RefRangeEnd = 280167, XrefRangeStart = 280158, XrefRangeEnd = 280166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime Parse(string s, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Parse_Public_Static_DateTime_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0004E4B8 File Offset: 0x0004C6B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280167, XrefRangeEnd = 280175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ParseExact(string s, string format, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ParseExact_Public_Static_DateTime_String_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0004E520 File Offset: 0x0004C720
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280186, RefRangeEnd = 280188, XrefRangeStart = 280175, XrefRangeEnd = 280186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ParseExact_Public_Static_DateTime_String_String_IFormatProvider_DateTimeStyles_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0004E594 File Offset: 0x0004C794
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 280188, RefRangeEnd = 280196, XrefRangeStart = 280188, XrefRangeEnd = 280188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan Subtract(DateTime value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_Subtract_Public_TimeSpan_DateTime_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0004E5D4 File Offset: 0x0004C7D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280197, RefRangeEnd = 280198, XrefRangeStart = 280196, XrefRangeEnd = 280197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long ToFileTimeUtc()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToFileTimeUtc_Public_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0004E604 File Offset: 0x0004C804
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 280199, RefRangeEnd = 280209, XrefRangeStart = 280198, XrefRangeEnd = 280199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ToLocalTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToLocalTime_Public_DateTime_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0004E634 File Offset: 0x0004C834
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280209, RefRangeEnd = 280210, XrefRangeStart = 280209, XrefRangeEnd = 280209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ToLocalTime(bool throwOnOverflow)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref throwOnOverflow;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToLocalTime_Internal_DateTime_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0004E674 File Offset: 0x0004C874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280210, XrefRangeEnd = 280218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0004E6A0 File Offset: 0x0004C8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280218, XrefRangeEnd = 280226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0004E6DC File Offset: 0x0004C8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280226, XrefRangeEnd = 280234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0004E718 File Offset: 0x0004C918
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280242, RefRangeEnd = 280244, XrefRangeStart = 280234, XrefRangeEnd = 280242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0004E768 File Offset: 0x0004C968
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 280245, RefRangeEnd = 280256, XrefRangeStart = 280244, XrefRangeEnd = 280245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ToUniversalTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_ToUniversalTime_Public_DateTime_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0004E798 File Offset: 0x0004C998
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280276, RefRangeEnd = 280277, XrefRangeStart = 280256, XrefRangeEnd = 280276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styles;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_IFormatProvider_DateTimeStyles_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0004E808 File Offset: 0x0004CA08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280297, RefRangeEnd = 280299, XrefRangeStart = 280277, XrefRangeEnd = 280297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseExact(string s, Il2CppStringArray formats, IFormatProvider provider, DateTimeStyles style, out DateTime result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formats);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_TryParseExact_Public_Static_Boolean_String_Il2CppStringArray_IFormatProvider_DateTimeStyles_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0004E88C File Offset: 0x0004CA8C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 280299, RefRangeEnd = 280312, XrefRangeStart = 280299, XrefRangeEnd = 280299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime operator +(DateTime d, TimeSpan t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_Addition_Public_Static_DateTime_DateTime_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0004E8D8 File Offset: 0x0004CAD8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 280312, RefRangeEnd = 280321, XrefRangeStart = 280312, XrefRangeEnd = 280312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime operator -(DateTime d, TimeSpan t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_DateTime_DateTime_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0004E924 File Offset: 0x0004CB24
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 280321, RefRangeEnd = 280337, XrefRangeStart = 280321, XrefRangeEnd = 280321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan operator -(DateTime d1, DateTime d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0004E970 File Offset: 0x0004CB70
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 280337, RefRangeEnd = 280346, XrefRangeStart = 280337, XrefRangeEnd = 280337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(DateTime d1, DateTime d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0004E9BC File Offset: 0x0004CBBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280346, RefRangeEnd = 280347, XrefRangeStart = 280346, XrefRangeEnd = 280346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(DateTime d1, DateTime d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0004EA08 File Offset: 0x0004CC08
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 280347, RefRangeEnd = 280358, XrefRangeStart = 280347, XrefRangeEnd = 280347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(DateTime t1, DateTime t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0004EA54 File Offset: 0x0004CC54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280358, RefRangeEnd = 280359, XrefRangeStart = 280358, XrefRangeEnd = 280358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <=(DateTime t1, DateTime t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0004EAA0 File Offset: 0x0004CCA0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 280359, RefRangeEnd = 280369, XrefRangeStart = 280359, XrefRangeEnd = 280359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >(DateTime t1, DateTime t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0004EAEC File Offset: 0x0004CCEC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 280369, RefRangeEnd = 280379, XrefRangeStart = 280369, XrefRangeEnd = 280369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >=(DateTime t1, DateTime t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DateTime_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x0004EB38 File Offset: 0x0004CD38
		[CallerCount(0)]
		public unsafe TypeCode GetTypeCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x0004EB68 File Offset: 0x0004CD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280379, XrefRangeEnd = 280398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_IConvertible_ToBoolean(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0004EBAC File Offset: 0x0004CDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280398, XrefRangeEnd = 280417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char System_IConvertible_ToChar(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0004EBF0 File Offset: 0x0004CDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280417, XrefRangeEnd = 280436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe sbyte System_IConvertible_ToSByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0004EC34 File Offset: 0x0004CE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280436, XrefRangeEnd = 280455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte System_IConvertible_ToByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0004EC78 File Offset: 0x0004CE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280455, XrefRangeEnd = 280474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short System_IConvertible_ToInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0004ECBC File Offset: 0x0004CEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280474, XrefRangeEnd = 280493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort System_IConvertible_ToUInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0004ED00 File Offset: 0x0004CF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280493, XrefRangeEnd = 280512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IConvertible_ToInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0004ED44 File Offset: 0x0004CF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280512, XrefRangeEnd = 280531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint System_IConvertible_ToUInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0004ED88 File Offset: 0x0004CF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280531, XrefRangeEnd = 280550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long System_IConvertible_ToInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0004EDCC File Offset: 0x0004CFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280550, XrefRangeEnd = 280569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong System_IConvertible_ToUInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0004EE10 File Offset: 0x0004D010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280569, XrefRangeEnd = 280588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float System_IConvertible_ToSingle(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0004EE54 File Offset: 0x0004D054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280588, XrefRangeEnd = 280607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double System_IConvertible_ToDouble(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0004EE98 File Offset: 0x0004D098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280607, XrefRangeEnd = 280626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal System_IConvertible_ToDecimal(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0004EEDC File Offset: 0x0004D0DC
		[CallerCount(0)]
		public unsafe DateTime System_IConvertible_ToDateTime(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0004EF20 File Offset: 0x0004D120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280626, XrefRangeEnd = 280633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0004EF78 File Offset: 0x0004D178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280633, XrefRangeEnd = 280651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hour;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecond;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTime.NativeMethodInfoPtr_TryCreate_Internal_Static_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00004998 File Offset: 0x00002B98
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DateTime>.NativeClassPtr, ref this));
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x0004F018 File Offset: 0x0004D218
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x000049AA File Offset: 0x00002BAA
		public unsafe static long TicksPerMillisecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksPerMillisecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksPerMillisecond, (void*)(&value));
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x0004F034 File Offset: 0x0004D234
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x000049B8 File Offset: 0x00002BB8
		public unsafe static long TicksPerSecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksPerSecond, (void*)(&value));
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x0004F050 File Offset: 0x0004D250
		// (set) Token: 0x060009C2 RID: 2498 RVA: 0x000049C6 File Offset: 0x00002BC6
		public unsafe static long TicksPerMinute
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksPerMinute, (void*)(&value));
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x0004F06C File Offset: 0x0004D26C
		// (set) Token: 0x060009C4 RID: 2500 RVA: 0x000049D4 File Offset: 0x00002BD4
		public unsafe static long TicksPerHour
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksPerHour, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksPerHour, (void*)(&value));
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x0004F088 File Offset: 0x0004D288
		// (set) Token: 0x060009C6 RID: 2502 RVA: 0x000049E2 File Offset: 0x00002BE2
		public unsafe static long TicksPerDay
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksPerDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksPerDay, (void*)(&value));
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x0004F0A4 File Offset: 0x0004D2A4
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x000049F0 File Offset: 0x00002BF0
		public unsafe static int MillisPerSecond
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MillisPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MillisPerSecond, (void*)(&value));
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x0004F0C0 File Offset: 0x0004D2C0
		// (set) Token: 0x060009CA RID: 2506 RVA: 0x000049FE File Offset: 0x00002BFE
		public unsafe static int MillisPerMinute
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MillisPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MillisPerMinute, (void*)(&value));
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x0004F0DC File Offset: 0x0004D2DC
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x00004A0C File Offset: 0x00002C0C
		public unsafe static int MillisPerHour
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MillisPerHour, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MillisPerHour, (void*)(&value));
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x0004F0F8 File Offset: 0x0004D2F8
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x00004A1A File Offset: 0x00002C1A
		public unsafe static int MillisPerDay
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MillisPerDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MillisPerDay, (void*)(&value));
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x0004F114 File Offset: 0x0004D314
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x00004A28 File Offset: 0x00002C28
		public unsafe static int DaysPerYear
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysPerYear, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysPerYear, (void*)(&value));
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x0004F130 File Offset: 0x0004D330
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x00004A36 File Offset: 0x00002C36
		public unsafe static int DaysPer4Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysPer4Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysPer4Years, (void*)(&value));
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x0004F14C File Offset: 0x0004D34C
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x00004A44 File Offset: 0x00002C44
		public unsafe static int DaysPer100Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysPer100Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysPer100Years, (void*)(&value));
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x0004F168 File Offset: 0x0004D368
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x00004A52 File Offset: 0x00002C52
		public unsafe static int DaysPer400Years
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysPer400Years, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysPer400Years, (void*)(&value));
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x0004F184 File Offset: 0x0004D384
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x00004A60 File Offset: 0x00002C60
		public unsafe static int DaysTo1601
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysTo1601, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysTo1601, (void*)(&value));
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x0004F1A0 File Offset: 0x0004D3A0
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x00004A6E File Offset: 0x00002C6E
		public unsafe static int DaysTo1899
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysTo1899, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysTo1899, (void*)(&value));
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x0004F1BC File Offset: 0x0004D3BC
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x00004A7C File Offset: 0x00002C7C
		public unsafe static int DaysTo1970
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysTo1970, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysTo1970, (void*)(&value));
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x0004F1D8 File Offset: 0x0004D3D8
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x00004A8A File Offset: 0x00002C8A
		public unsafe static int DaysTo10000
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysTo10000, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysTo10000, (void*)(&value));
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x0004F1F4 File Offset: 0x0004D3F4
		// (set) Token: 0x060009E0 RID: 2528 RVA: 0x00004A98 File Offset: 0x00002C98
		public unsafe static long MinTicks
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MinTicks, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MinTicks, (void*)(&value));
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x0004F210 File Offset: 0x0004D410
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x00004AA6 File Offset: 0x00002CA6
		public unsafe static long MaxTicks
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MaxTicks, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MaxTicks, (void*)(&value));
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x0004F22C File Offset: 0x0004D42C
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x00004AB4 File Offset: 0x00002CB4
		public unsafe static long MaxMillis
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MaxMillis, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MaxMillis, (void*)(&value));
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x0004F248 File Offset: 0x0004D448
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x00004AC2 File Offset: 0x00002CC2
		public unsafe static long FileTimeOffset
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_FileTimeOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_FileTimeOffset, (void*)(&value));
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x0004F264 File Offset: 0x0004D464
		// (set) Token: 0x060009E8 RID: 2536 RVA: 0x00004AD0 File Offset: 0x00002CD0
		public unsafe static long DoubleDateOffset
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DoubleDateOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DoubleDateOffset, (void*)(&value));
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x0004F280 File Offset: 0x0004D480
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x00004ADE File Offset: 0x00002CDE
		public unsafe static long OADateMinAsTicks
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_OADateMinAsTicks, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_OADateMinAsTicks, (void*)(&value));
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x0004F29C File Offset: 0x0004D49C
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x00004AEC File Offset: 0x00002CEC
		public unsafe static double OADateMinAsDouble
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_OADateMinAsDouble, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_OADateMinAsDouble, (void*)(&value));
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0004F2B8 File Offset: 0x0004D4B8
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x00004AFA File Offset: 0x00002CFA
		public unsafe static double OADateMaxAsDouble
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_OADateMaxAsDouble, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_OADateMaxAsDouble, (void*)(&value));
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x0004F2D4 File Offset: 0x0004D4D4
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x00004B08 File Offset: 0x00002D08
		public unsafe static int DatePartYear
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DatePartYear, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DatePartYear, (void*)(&value));
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x0004F2F0 File Offset: 0x0004D4F0
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x00004B16 File Offset: 0x00002D16
		public unsafe static int DatePartDayOfYear
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DatePartDayOfYear, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DatePartDayOfYear, (void*)(&value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x0004F30C File Offset: 0x0004D50C
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x00004B24 File Offset: 0x00002D24
		public unsafe static int DatePartMonth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DatePartMonth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DatePartMonth, (void*)(&value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x0004F328 File Offset: 0x0004D528
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x00004B32 File Offset: 0x00002D32
		public unsafe static int DatePartDay
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DatePartDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DatePartDay, (void*)(&value));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x0004F344 File Offset: 0x0004D544
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x00004B40 File Offset: 0x00002D40
		public unsafe static Il2CppStructArray<int> DaysToMonth365
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysToMonth365, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysToMonth365, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x0004F36C File Offset: 0x0004D56C
		// (set) Token: 0x060009FA RID: 2554 RVA: 0x00004B52 File Offset: 0x00002D52
		public unsafe static Il2CppStructArray<int> DaysToMonth366
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DaysToMonth366, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DaysToMonth366, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x0004F394 File Offset: 0x0004D594
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x00004B64 File Offset: 0x00002D64
		public unsafe static DateTime MinValue
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MinValue, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x0004F3B0 File Offset: 0x0004D5B0
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x00004B72 File Offset: 0x00002D72
		public unsafe static DateTime MaxValue
		{
			get
			{
				DateTime dateTime;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_MaxValue, (void*)(&dateTime));
				return dateTime;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x0004F3CC File Offset: 0x0004D5CC
		// (set) Token: 0x06000A00 RID: 2560 RVA: 0x00004B80 File Offset: 0x00002D80
		public unsafe static ulong TicksMask
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksMask, (void*)(&value));
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x0004F3E8 File Offset: 0x0004D5E8
		// (set) Token: 0x06000A02 RID: 2562 RVA: 0x00004B8E File Offset: 0x00002D8E
		public unsafe static ulong FlagsMask
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_FlagsMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_FlagsMask, (void*)(&value));
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0004F404 File Offset: 0x0004D604
		// (set) Token: 0x06000A04 RID: 2564 RVA: 0x00004B9C File Offset: 0x00002D9C
		public unsafe static ulong LocalMask
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_LocalMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_LocalMask, (void*)(&value));
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x0004F420 File Offset: 0x0004D620
		// (set) Token: 0x06000A06 RID: 2566 RVA: 0x00004BAA File Offset: 0x00002DAA
		public unsafe static long TicksCeiling
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksCeiling, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksCeiling, (void*)(&value));
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x0004F43C File Offset: 0x0004D63C
		// (set) Token: 0x06000A08 RID: 2568 RVA: 0x00004BB8 File Offset: 0x00002DB8
		public unsafe static ulong KindUnspecified
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_KindUnspecified, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_KindUnspecified, (void*)(&value));
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0004F458 File Offset: 0x0004D658
		// (set) Token: 0x06000A0A RID: 2570 RVA: 0x00004BC6 File Offset: 0x00002DC6
		public unsafe static ulong KindUtc
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_KindUtc, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_KindUtc, (void*)(&value));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x0004F474 File Offset: 0x0004D674
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x00004BD4 File Offset: 0x00002DD4
		public unsafe static ulong KindLocal
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_KindLocal, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_KindLocal, (void*)(&value));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0004F490 File Offset: 0x0004D690
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x00004BE2 File Offset: 0x00002DE2
		public unsafe static ulong KindLocalAmbiguousDst
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_KindLocalAmbiguousDst, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_KindLocalAmbiguousDst, (void*)(&value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0004F4AC File Offset: 0x0004D6AC
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x00004BF0 File Offset: 0x00002DF0
		public unsafe static int KindShift
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_KindShift, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_KindShift, (void*)(&value));
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0004F4C8 File Offset: 0x0004D6C8
		// (set) Token: 0x06000A12 RID: 2578 RVA: 0x00004BFE File Offset: 0x00002DFE
		public unsafe static string TicksField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_TicksField, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_TicksField, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0004F4E8 File Offset: 0x0004D6E8
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x00004C10 File Offset: 0x00002E10
		public unsafe static string DateDataField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DateTime.NativeFieldInfoPtr_DateDataField, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DateTime.NativeFieldInfoPtr_DateDataField, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerMillisecond;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerSecond;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerMinute;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerHour;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerDay;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerSecond;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerMinute;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerHour;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerDay;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeFieldInfoPtr_DaysPerYear;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer4Years;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer100Years;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeFieldInfoPtr_DaysPer400Years;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeFieldInfoPtr_DaysTo1601;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeFieldInfoPtr_DaysTo1899;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeFieldInfoPtr_DaysTo1970;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeFieldInfoPtr_DaysTo10000;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeFieldInfoPtr_MinTicks;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeFieldInfoPtr_MaxTicks;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeFieldInfoPtr_MaxMillis;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeFieldInfoPtr_FileTimeOffset;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeFieldInfoPtr_DoubleDateOffset;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeFieldInfoPtr_OADateMinAsTicks;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeFieldInfoPtr_OADateMinAsDouble;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeFieldInfoPtr_OADateMaxAsDouble;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeFieldInfoPtr_DatePartYear;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeFieldInfoPtr_DatePartDayOfYear;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeFieldInfoPtr_DatePartMonth;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeFieldInfoPtr_DatePartDay;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeFieldInfoPtr_DaysToMonth365;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeFieldInfoPtr_DaysToMonth366;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeFieldInfoPtr_TicksMask;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeFieldInfoPtr_FlagsMask;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeFieldInfoPtr_LocalMask;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeFieldInfoPtr_TicksCeiling;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeFieldInfoPtr_KindUnspecified;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeFieldInfoPtr_KindUtc;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeFieldInfoPtr_KindLocal;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeFieldInfoPtr_KindLocalAmbiguousDst;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeFieldInfoPtr_KindShift;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeFieldInfoPtr_TicksField;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeFieldInfoPtr_DateDataField;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeFieldInfoPtr_dateData;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_UInt64_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_DateTimeKind_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int64_DateTimeKind_Boolean_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_DateTimeKind_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_DateTimeKind_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalTicks_Internal_get_Int64_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalKind_Private_get_UInt64_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_DateTime_TimeSpan_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_Add_Private_DateTime_Double_Int32_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_AddDays_Public_DateTime_Double_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_AddMilliseconds_Public_DateTime_Double_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_AddMonths_Public_DateTime_Int32_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_AddSeconds_Public_DateTime_Double_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_AddTicks_Public_DateTime_Int64_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr_AddYears_Public_DateTime_Int32_0;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DateTime_0;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_DateToTicks_Private_Static_Int64_Int32_Int32_Int32_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr_TimeToTicks_Private_Static_Int64_Int32_Int32_Int32_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_DaysInMonth_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DateTime_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_FromBinary_Public_Static_DateTime_Int64_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_FromBinaryRaw_Internal_Static_DateTime_Int64_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_FromFileTime_Public_Static_DateTime_Int64_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_FromFileTimeUtc_Public_Static_DateTime_Int64_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_SpecifyKind_Public_Static_DateTime_DateTime_DateTimeKind_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr_ToBinaryRaw_Internal_Int64_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_get_Date_Public_get_DateTime_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr_GetDatePart_Private_Int32_Int32_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_get_Day_Public_get_Int32_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_get_DayOfWeek_Public_get_DayOfWeek_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_get_Hour_Public_get_Int32_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_IsAmbiguousDaylightSavingTime_Internal_Boolean_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_get_Kind_Public_get_DateTimeKind_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_get_Minute_Public_get_Int32_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_get_Month_Public_get_Int32_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_get_Now_Public_Static_get_DateTime_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_get_UtcNow_Public_Static_get_DateTime_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemTimeAsFileTime_Internal_Static_Int64_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_get_Second_Public_get_Int32_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeOfDay_Public_get_TimeSpan_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_get_Year_Public_get_Int32_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_IsLeapYear_Public_Static_Boolean_Int32_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_DateTime_String_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_DateTime_String_IFormatProvider_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_ParseExact_Public_Static_DateTime_String_String_IFormatProvider_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_ParseExact_Public_Static_DateTime_String_String_IFormatProvider_DateTimeStyles_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_TimeSpan_DateTime_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr_ToFileTimeUtc_Public_Int64_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_ToLocalTime_Public_DateTime_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_ToLocalTime_Internal_DateTime_Boolean_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr_ToUniversalTime_Public_DateTime_0;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_IFormatProvider_DateTimeStyles_byref_DateTime_0;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr_TryParseExact_Public_Static_Boolean_String_Il2CppStringArray_IFormatProvider_DateTimeStyles_byref_DateTime_0;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_DateTime_DateTime_TimeSpan_0;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_DateTime_DateTime_TimeSpan_0;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_DateTime_DateTime_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DateTime_DateTime_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DateTime_DateTime_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_DateTime_DateTime_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_DateTime_DateTime_0;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DateTime_DateTime_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DateTime_DateTime_0;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr_TryCreate_Internal_Static_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_Int32_byref_DateTime_0;

		// Token: 0x04000851 RID: 2129
		[FieldOffset(0)]
		public ulong dateData;
	}
}

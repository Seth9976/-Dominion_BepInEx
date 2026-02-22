using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200009F RID: 159
	[Serializable]
	[StructLayout(2)]
	public struct Enum
	{
		// Token: 0x06000B1D RID: 2845 RVA: 0x00054450 File Offset: 0x00052650
		// Note: this type is marked as 'beforefieldinit'.
		static Enum()
		{
			Il2CppClassPointerStore<Enum>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Enum");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enum>.NativeClassPtr);
			Enum.NativeFieldInfoPtr_enumSeperatorCharArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum>.NativeClassPtr, "enumSeperatorCharArray");
			Enum.NativeFieldInfoPtr_enumSeperator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum>.NativeClassPtr, "enumSeperator");
			Enum.NativeMethodInfoPtr_GetCachedValuesAndNames_Private_Static_ValuesAndNames_RuntimeType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665160);
			Enum.NativeMethodInfoPtr_InternalFormattedHexString_Private_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665161);
			Enum.NativeMethodInfoPtr_InternalFormat_Private_Static_String_RuntimeType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665162);
			Enum.NativeMethodInfoPtr_InternalFlagsFormat_Private_Static_String_RuntimeType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665163);
			Enum.NativeMethodInfoPtr_ToUInt64_Internal_Static_UInt64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665164);
			Enum.NativeMethodInfoPtr_InternalCompareTo_Private_Static_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665165);
			Enum.NativeMethodInfoPtr_InternalGetUnderlyingType_Internal_Static_RuntimeType_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665166);
			Enum.NativeMethodInfoPtr_GetEnumValuesAndNames_Private_Static_Boolean_RuntimeType_byref_Il2CppStructArray_1_UInt64_byref_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665167);
			Enum.NativeMethodInfoPtr_InternalBoxEnum_Private_Static_Object_RuntimeType_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665168);
			Enum.NativeMethodInfoPtr_Parse_Public_Static_Object_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665169);
			Enum.NativeMethodInfoPtr_Parse_Public_Static_Object_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665170);
			Enum.NativeMethodInfoPtr_TryParseEnum_Private_Static_Boolean_Type_String_Boolean_byref_EnumResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665171);
			Enum.NativeMethodInfoPtr_GetUnderlyingType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665172);
			Enum.NativeMethodInfoPtr_GetValues_Public_Static_Array_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665173);
			Enum.NativeMethodInfoPtr_InternalGetValues_Internal_Static_Il2CppStructArray_1_UInt64_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665174);
			Enum.NativeMethodInfoPtr_GetName_Public_Static_String_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665175);
			Enum.NativeMethodInfoPtr_InternalGetNames_Internal_Static_Il2CppStringArray_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665176);
			Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665177);
			Enum.NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665178);
			Enum.NativeMethodInfoPtr_get_value_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665179);
			Enum.NativeMethodInfoPtr_GetValue_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665180);
			Enum.NativeMethodInfoPtr_InternalHasFlag_Private_Boolean_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665181);
			Enum.NativeMethodInfoPtr_get_hashcode_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665182);
			Enum.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665183);
			Enum.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665184);
			Enum.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665185);
			Enum.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665186);
			Enum.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665187);
			Enum.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665188);
			Enum.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665189);
			Enum.NativeMethodInfoPtr_HasFlag_Public_Boolean_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665190);
			Enum.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665191);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665192);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665193);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665194);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665195);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665196);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665197);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665198);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665199);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665200);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665201);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665202);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665203);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665204);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665205);
			Enum.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665206);
			Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665207);
			Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665208);
			Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665209);
			Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665210);
			Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665211);
			Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665212);
			Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665213);
			Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665214);
			Enum.NativeMethodInfoPtr_ToObject_Private_Static_Object_Type_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665215);
			Enum.NativeMethodInfoPtr_ToObject_Private_Static_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665216);
			Enum.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum>.NativeClassPtr, 100665217);
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00054930 File Offset: 0x00052B30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 282117, RefRangeEnd = 282120, XrefRangeStart = 282102, XrefRangeEnd = 282117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Enum.ValuesAndNames GetCachedValuesAndNames(RuntimeType enumType, bool getNames)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref getNames;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_GetCachedValuesAndNames_Private_Static_ValuesAndNames_RuntimeType_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Enum.ValuesAndNames>(intPtr3) : null;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00054984 File Offset: 0x00052B84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282145, RefRangeEnd = 282146, XrefRangeStart = 282120, XrefRangeEnd = 282145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalFormattedHexString(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_InternalFormattedHexString_Private_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x000549C0 File Offset: 0x00052BC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282156, RefRangeEnd = 282157, XrefRangeStart = 282146, XrefRangeEnd = 282156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalFormat(RuntimeType eT, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eT);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_InternalFormat_Private_Static_String_RuntimeType_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00054A10 File Offset: 0x00052C10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 282185, RefRangeEnd = 282188, XrefRangeStart = 282157, XrefRangeEnd = 282185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalFlagsFormat(RuntimeType eT, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eT);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_InternalFlagsFormat_Private_Static_String_RuntimeType_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00054A60 File Offset: 0x00052C60
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 282205, RefRangeEnd = 282213, XrefRangeStart = 282188, XrefRangeEnd = 282205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToUInt64_Internal_Static_UInt64_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00054AA4 File Offset: 0x00052CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282213, XrefRangeEnd = 282214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InternalCompareTo(Object o1, Object o2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_InternalCompareTo_Private_Static_Int32_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00054AF8 File Offset: 0x00052CF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282215, RefRangeEnd = 282217, XrefRangeStart = 282214, XrefRangeEnd = 282215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeType InternalGetUnderlyingType(RuntimeType enumType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_InternalGetUnderlyingType_Internal_Static_RuntimeType_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeType>(intPtr3) : null;
			}
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00054B3C File Offset: 0x00052D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282217, XrefRangeEnd = 282218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetEnumValuesAndNames(RuntimeType enumType, out Il2CppStructArray<ulong> values, out Il2CppStringArray names)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_GetEnumValuesAndNames_Private_Static_Boolean_RuntimeType_byref_Il2CppStructArray_1_UInt64_byref_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			values = ((intPtr5 == 0) ? null : new Il2CppStructArray<ulong>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			names = ((intPtr6 == 0) ? null : new Il2CppStringArray(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00054BC4 File Offset: 0x00052DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282218, XrefRangeEnd = 282219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object InternalBoxEnum(RuntimeType enumType, long value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_InternalBoxEnum_Private_Static_Object_RuntimeType_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00054C18 File Offset: 0x00052E18
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 282227, RefRangeEnd = 282240, XrefRangeStart = 282219, XrefRangeEnd = 282227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Parse(Type enumType, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_Parse_Public_Static_Object_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00054C70 File Offset: 0x00052E70
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 282245, RefRangeEnd = 282260, XrefRangeStart = 282240, XrefRangeEnd = 282245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Parse(Type enumType, string value, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_Parse_Public_Static_Object_Type_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00054CD4 File Offset: 0x00052ED4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282325, RefRangeEnd = 282327, XrefRangeStart = 282260, XrefRangeEnd = 282325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseEnum(Type enumType, string value, bool ignoreCase, ref Enum.EnumResult parseResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parseResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_TryParseEnum_Private_Static_Boolean_Type_String_Boolean_byref_EnumResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00054D48 File Offset: 0x00052F48
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 282338, RefRangeEnd = 282349, XrefRangeStart = 282327, XrefRangeEnd = 282338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetUnderlyingType(Type enumType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_GetUnderlyingType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00054D8C File Offset: 0x00052F8C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 282360, RefRangeEnd = 282364, XrefRangeStart = 282349, XrefRangeEnd = 282360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array GetValues(Type enumType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_GetValues_Public_Static_Array_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
			}
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00054DD0 File Offset: 0x00052FD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 282368, RefRangeEnd = 282371, XrefRangeStart = 282364, XrefRangeEnd = 282368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<ulong> InternalGetValues(RuntimeType enumType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_InternalGetValues_Internal_Static_Il2CppStructArray_1_UInt64_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00054E14 File Offset: 0x00053014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282371, XrefRangeEnd = 282382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(Type enumType, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_GetName_Public_Static_String_Type_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00054E64 File Offset: 0x00053064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282386, RefRangeEnd = 282387, XrefRangeStart = 282382, XrefRangeEnd = 282386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray InternalGetNames(RuntimeType enumType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_InternalGetNames_Internal_Static_Il2CppStringArray_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00054EA8 File Offset: 0x000530A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282486, RefRangeEnd = 282487, XrefRangeStart = 282387, XrefRangeEnd = 282486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00054F00 File Offset: 0x00053100
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 282498, RefRangeEnd = 282505, XrefRangeStart = 282487, XrefRangeEnd = 282498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDefined(Type enumType, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_Type_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00054F54 File Offset: 0x00053154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282505, XrefRangeEnd = 282506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object get_value()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_get_value_Private_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00054F88 File Offset: 0x00053188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetValue()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_GetValue_Internal_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00054FBC File Offset: 0x000531BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282506, XrefRangeEnd = 282507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalHasFlag(Enum flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_InternalHasFlag_Private_Boolean_Enum_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00054FFC File Offset: 0x000531FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282507, XrefRangeEnd = 282508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int get_hashcode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_get_hashcode_Private_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0005502C File Offset: 0x0005322C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 282509, RefRangeEnd = 282519, XrefRangeStart = 282508, XrefRangeEnd = 282509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00055070 File Offset: 0x00053270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x000550A0 File Offset: 0x000532A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282519, XrefRangeEnd = 282529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x000550CC File Offset: 0x000532CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282529, XrefRangeEnd = 282530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(string format, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0005511C File Offset: 0x0005331C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282530, XrefRangeEnd = 282535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int CompareTo(Object target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00055160 File Offset: 0x00053360
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282570, RefRangeEnd = 282571, XrefRangeStart = 282535, XrefRangeEnd = 282570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0005519C File Offset: 0x0005339C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282571, RefRangeEnd = 282572, XrefRangeStart = 282571, XrefRangeEnd = 282571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x000551D8 File Offset: 0x000533D8
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 282600, RefRangeEnd = 282630, XrefRangeStart = 282572, XrefRangeEnd = 282600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasFlag(Enum flag)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_HasFlag_Public_Boolean_Enum_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00055218 File Offset: 0x00053418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282630, XrefRangeEnd = 282696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TypeCode GetTypeCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00055248 File Offset: 0x00053448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282696, XrefRangeEnd = 282705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_IConvertible_ToBoolean(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0005528C File Offset: 0x0005348C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282705, XrefRangeEnd = 282714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual char System_IConvertible_ToChar(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x000552D0 File Offset: 0x000534D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282714, XrefRangeEnd = 282723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual sbyte System_IConvertible_ToSByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00055314 File Offset: 0x00053514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282723, XrefRangeEnd = 282732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual byte System_IConvertible_ToByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00055358 File Offset: 0x00053558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282732, XrefRangeEnd = 282741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual short System_IConvertible_ToInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0005539C File Offset: 0x0005359C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282741, XrefRangeEnd = 282750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ushort System_IConvertible_ToUInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x000553E0 File Offset: 0x000535E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282750, XrefRangeEnd = 282759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_IConvertible_ToInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00055424 File Offset: 0x00053624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282759, XrefRangeEnd = 282768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual uint System_IConvertible_ToUInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00055468 File Offset: 0x00053668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282768, XrefRangeEnd = 282777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual long System_IConvertible_ToInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x000554AC File Offset: 0x000536AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282777, XrefRangeEnd = 282786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ulong System_IConvertible_ToUInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x000554F0 File Offset: 0x000536F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282786, XrefRangeEnd = 282795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float System_IConvertible_ToSingle(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00055534 File Offset: 0x00053734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282795, XrefRangeEnd = 282804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double System_IConvertible_ToDouble(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00055578 File Offset: 0x00053778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282804, XrefRangeEnd = 282813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Decimal System_IConvertible_ToDecimal(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x000555BC File Offset: 0x000537BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282813, XrefRangeEnd = 282832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DateTime System_IConvertible_ToDateTime(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00055600 File Offset: 0x00053800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282832, XrefRangeEnd = 282836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_IConvertible_ToType(Type type, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00055658 File Offset: 0x00053858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282872, RefRangeEnd = 282873, XrefRangeStart = 282836, XrefRangeEnd = 282872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, sbyte value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_SByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x000556AC File Offset: 0x000538AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282909, RefRangeEnd = 282910, XrefRangeStart = 282873, XrefRangeEnd = 282909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, short value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00055700 File Offset: 0x00053900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282946, RefRangeEnd = 282947, XrefRangeStart = 282910, XrefRangeEnd = 282946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00055754 File Offset: 0x00053954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282983, RefRangeEnd = 282984, XrefRangeStart = 282947, XrefRangeEnd = 282983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, byte value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x000557A8 File Offset: 0x000539A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283020, RefRangeEnd = 283021, XrefRangeStart = 282984, XrefRangeEnd = 283020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, ushort value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x000557FC File Offset: 0x000539FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283057, RefRangeEnd = 283058, XrefRangeStart = 283021, XrefRangeEnd = 283057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, uint value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00055850 File Offset: 0x00053A50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283094, RefRangeEnd = 283095, XrefRangeStart = 283058, XrefRangeEnd = 283094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, long value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x000558A4 File Offset: 0x00053AA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283131, RefRangeEnd = 283133, XrefRangeStart = 283095, XrefRangeEnd = 283131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, ulong value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x000558F8 File Offset: 0x00053AF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283169, RefRangeEnd = 283170, XrefRangeStart = 283133, XrefRangeEnd = 283169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, char value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Private_Static_Object_Type_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0005594C File Offset: 0x00053B4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283206, RefRangeEnd = 283207, XrefRangeStart = 283170, XrefRangeEnd = 283206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToObject(Type enumType, bool value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr_ToObject_Private_Static_Object_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x000559A0 File Offset: 0x00053BA0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Enum()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.NativeMethodInfoPtr__ctor_Protected_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00004DF8 File Offset: 0x00002FF8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Enum>.NativeClassPtr, ref this));
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x000559C8 File Offset: 0x00053BC8
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x00004E0A File Offset: 0x0000300A
		public unsafe static Il2CppStructArray<char> enumSeperatorCharArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Enum.NativeFieldInfoPtr_enumSeperatorCharArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Enum.NativeFieldInfoPtr_enumSeperatorCharArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x000559F0 File Offset: 0x00053BF0
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x00004E1C File Offset: 0x0000301C
		public unsafe static string enumSeperator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Enum.NativeFieldInfoPtr_enumSeperator, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Enum.NativeFieldInfoPtr_enumSeperator, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeFieldInfoPtr_enumSeperatorCharArray;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeFieldInfoPtr_enumSeperator;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedValuesAndNames_Private_Static_ValuesAndNames_RuntimeType_Boolean_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_InternalFormattedHexString_Private_Static_String_Object_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_InternalFormat_Private_Static_String_RuntimeType_Object_0;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr_InternalFlagsFormat_Private_Static_String_RuntimeType_Object_0;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Internal_Static_UInt64_Object_0;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeMethodInfoPtr_InternalCompareTo_Private_Static_Int32_Object_Object_0;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetUnderlyingType_Internal_Static_RuntimeType_RuntimeType_0;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumValuesAndNames_Private_Static_Boolean_RuntimeType_byref_Il2CppStructArray_1_UInt64_byref_Il2CppStringArray_0;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeMethodInfoPtr_InternalBoxEnum_Private_Static_Object_RuntimeType_Int64_0;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Object_Type_String_0;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Object_Type_String_Boolean_0;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeMethodInfoPtr_TryParseEnum_Private_Static_Boolean_Type_String_Boolean_byref_EnumResult_0;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeMethodInfoPtr_GetUnderlyingType_Public_Static_Type_Type_0;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeMethodInfoPtr_GetValues_Public_Static_Array_Type_0;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetValues_Internal_Static_Il2CppStructArray_1_UInt64_RuntimeType_0;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_Type_Object_0;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetNames_Internal_Static_Il2CppStringArray_RuntimeType_0;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Object_0;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_Type_Object_0;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Private_Object_0;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Internal_Object_0;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeMethodInfoPtr_InternalHasFlag_Private_Boolean_Enum_0;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeMethodInfoPtr_get_hashcode_Private_Int32_0;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeMethodInfoPtr_HasFlag_Public_Boolean_Enum_0;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_SByte_0;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Int16_0;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Int32_0;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Byte_0;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_UInt16_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_UInt32_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_Int64_0;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Public_Static_Object_Type_UInt64_0;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Private_Static_Object_Type_Char_0;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeMethodInfoPtr_ToObject_Private_Static_Object_Type_Boolean_0;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200058F RID: 1423
		public enum ParseFailureKind
		{
			// Token: 0x04003FAB RID: 16299
			None,
			// Token: 0x04003FAC RID: 16300
			Argument,
			// Token: 0x04003FAD RID: 16301
			ArgumentNull,
			// Token: 0x04003FAE RID: 16302
			ArgumentWithParameter,
			// Token: 0x04003FAF RID: 16303
			UnhandledException
		}

		// Token: 0x02000590 RID: 1424
		public sealed class EnumResult : ValueType
		{
			// Token: 0x06004EEC RID: 20204 RVA: 0x0016386C File Offset: 0x00161A6C
			// Note: this type is marked as 'beforefieldinit'.
			static EnumResult()
			{
				Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enum>.NativeClassPtr, "EnumResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr);
				Enum.EnumResult.NativeFieldInfoPtr_parsedEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, "parsedEnum");
				Enum.EnumResult.NativeFieldInfoPtr_canThrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, "canThrow");
				Enum.EnumResult.NativeFieldInfoPtr_m_failure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, "m_failure");
				Enum.EnumResult.NativeFieldInfoPtr_m_failureMessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, "m_failureMessageID");
				Enum.EnumResult.NativeFieldInfoPtr_m_failureParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, "m_failureParameter");
				Enum.EnumResult.NativeFieldInfoPtr_m_failureMessageFormatArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, "m_failureMessageFormatArgument");
				Enum.EnumResult.NativeFieldInfoPtr_m_innerException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, "m_innerException");
				Enum.EnumResult.NativeMethodInfoPtr_Init_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, 100665219);
				Enum.EnumResult.NativeMethodInfoPtr_SetFailure_Internal_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, 100665220);
				Enum.EnumResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, 100665221);
				Enum.EnumResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, 100665222);
				Enum.EnumResult.NativeMethodInfoPtr_GetEnumParseException_Internal_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr, 100665223);
			}

			// Token: 0x06004EED RID: 20205 RVA: 0x00163988 File Offset: 0x00161B88
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 282090, RefRangeEnd = 282092, XrefRangeStart = 282087, XrefRangeEnd = 282090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(bool canMethodThrow)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref canMethodThrow;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.EnumResult.NativeMethodInfoPtr_Init_Internal_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004EEE RID: 20206 RVA: 0x001639CC File Offset: 0x00161BCC
			[CallerCount(0)]
			public unsafe void SetFailure(Exception unhandledException)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(unhandledException);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.EnumResult.NativeMethodInfoPtr_SetFailure_Internal_Void_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004EEF RID: 20207 RVA: 0x00163A14 File Offset: 0x00161C14
			[CallerCount(0)]
			public unsafe void SetFailure(Enum.ParseFailureKind failure, string failureParameter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref failure;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureParameter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.EnumResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EF0 RID: 20208 RVA: 0x00163A6C File Offset: 0x00161C6C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 282092, RefRangeEnd = 282093, XrefRangeStart = 282092, XrefRangeEnd = 282092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFailure(Enum.ParseFailureKind failure, string failureMessageID, Object failureMessageFormatArgument)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref failure;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(failureMessageFormatArgument);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.EnumResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EF1 RID: 20209 RVA: 0x00163AD4 File Offset: 0x00161CD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282093, XrefRangeEnd = 282102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Exception GetEnumParseException()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.EnumResult.NativeMethodInfoPtr_GetEnumParseException_Internal_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}

			// Token: 0x06004EF2 RID: 20210 RVA: 0x0001DD41 File Offset: 0x0001BF41
			public EnumResult(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004EF3 RID: 20211 RVA: 0x0001DD4A File Offset: 0x0001BF4A
			public EnumResult()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enum.EnumResult>.NativeClassPtr))
			{
			}

			// Token: 0x1700140B RID: 5131
			// (get) Token: 0x06004EF4 RID: 20212 RVA: 0x00163B18 File Offset: 0x00161D18
			// (set) Token: 0x06004EF5 RID: 20213 RVA: 0x0001DD5C File Offset: 0x0001BF5C
			public unsafe Object parsedEnum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_parsedEnum);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_parsedEnum), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700140C RID: 5132
			// (get) Token: 0x06004EF6 RID: 20214 RVA: 0x00163B48 File Offset: 0x00161D48
			// (set) Token: 0x06004EF7 RID: 20215 RVA: 0x0001DD7B File Offset: 0x0001BF7B
			public unsafe bool canThrow
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_canThrow);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_canThrow)) = value;
				}
			}

			// Token: 0x1700140D RID: 5133
			// (get) Token: 0x06004EF8 RID: 20216 RVA: 0x00163B70 File Offset: 0x00161D70
			// (set) Token: 0x06004EF9 RID: 20217 RVA: 0x0001DD96 File Offset: 0x0001BF96
			public unsafe Enum.ParseFailureKind m_failure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_failure);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_failure)) = value;
				}
			}

			// Token: 0x1700140E RID: 5134
			// (get) Token: 0x06004EFA RID: 20218 RVA: 0x00163B98 File Offset: 0x00161D98
			// (set) Token: 0x06004EFB RID: 20219 RVA: 0x0001DDB1 File Offset: 0x0001BFB1
			public unsafe string m_failureMessageID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_failureMessageID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_failureMessageID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700140F RID: 5135
			// (get) Token: 0x06004EFC RID: 20220 RVA: 0x00163BC0 File Offset: 0x00161DC0
			// (set) Token: 0x06004EFD RID: 20221 RVA: 0x0001DDD0 File Offset: 0x0001BFD0
			public unsafe string m_failureParameter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_failureParameter);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_failureParameter), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001410 RID: 5136
			// (get) Token: 0x06004EFE RID: 20222 RVA: 0x00163BE8 File Offset: 0x00161DE8
			// (set) Token: 0x06004EFF RID: 20223 RVA: 0x0001DDEF File Offset: 0x0001BFEF
			public unsafe Object m_failureMessageFormatArgument
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_failureMessageFormatArgument);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_failureMessageFormatArgument), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001411 RID: 5137
			// (get) Token: 0x06004F00 RID: 20224 RVA: 0x00163C18 File Offset: 0x00161E18
			// (set) Token: 0x06004F01 RID: 20225 RVA: 0x0001DE0E File Offset: 0x0001C00E
			public unsafe Exception m_innerException
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_innerException);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.EnumResult.NativeFieldInfoPtr_m_innerException), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FB0 RID: 16304
			private static readonly IntPtr NativeFieldInfoPtr_parsedEnum;

			// Token: 0x04003FB1 RID: 16305
			private static readonly IntPtr NativeFieldInfoPtr_canThrow;

			// Token: 0x04003FB2 RID: 16306
			private static readonly IntPtr NativeFieldInfoPtr_m_failure;

			// Token: 0x04003FB3 RID: 16307
			private static readonly IntPtr NativeFieldInfoPtr_m_failureMessageID;

			// Token: 0x04003FB4 RID: 16308
			private static readonly IntPtr NativeFieldInfoPtr_m_failureParameter;

			// Token: 0x04003FB5 RID: 16309
			private static readonly IntPtr NativeFieldInfoPtr_m_failureMessageFormatArgument;

			// Token: 0x04003FB6 RID: 16310
			private static readonly IntPtr NativeFieldInfoPtr_m_innerException;

			// Token: 0x04003FB7 RID: 16311
			private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_Boolean_0;

			// Token: 0x04003FB8 RID: 16312
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_Exception_0;

			// Token: 0x04003FB9 RID: 16313
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0;

			// Token: 0x04003FBA RID: 16314
			private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0;

			// Token: 0x04003FBB RID: 16315
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumParseException_Internal_Exception_0;
		}

		// Token: 0x02000591 RID: 1425
		public class ValuesAndNames : Object
		{
			// Token: 0x06004F02 RID: 20226 RVA: 0x00163C48 File Offset: 0x00161E48
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesAndNames()
			{
				Il2CppClassPointerStore<Enum.ValuesAndNames>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Enum>.NativeClassPtr, "ValuesAndNames");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enum.ValuesAndNames>.NativeClassPtr);
				Enum.ValuesAndNames.NativeFieldInfoPtr_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum.ValuesAndNames>.NativeClassPtr, "Values");
				Enum.ValuesAndNames.NativeFieldInfoPtr_Names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enum.ValuesAndNames>.NativeClassPtr, "Names");
				Enum.ValuesAndNames.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_UInt64_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enum.ValuesAndNames>.NativeClassPtr, 100665224);
			}

			// Token: 0x06004F03 RID: 20227 RVA: 0x00163CB0 File Offset: 0x00161EB0
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesAndNames(Il2CppStructArray<ulong> values, Il2CppStringArray names)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enum.ValuesAndNames>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(names);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Enum.ValuesAndNames.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_UInt64_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F04 RID: 20228 RVA: 0x0001DE2D File Offset: 0x0001C02D
			public ValuesAndNames(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001412 RID: 5138
			// (get) Token: 0x06004F05 RID: 20229 RVA: 0x00163D10 File Offset: 0x00161F10
			// (set) Token: 0x06004F06 RID: 20230 RVA: 0x0001DE36 File Offset: 0x0001C036
			public unsafe Il2CppStructArray<ulong> Values
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.ValuesAndNames.NativeFieldInfoPtr_Values);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.ValuesAndNames.NativeFieldInfoPtr_Values), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001413 RID: 5139
			// (get) Token: 0x06004F07 RID: 20231 RVA: 0x00163D40 File Offset: 0x00161F40
			// (set) Token: 0x06004F08 RID: 20232 RVA: 0x0001DE55 File Offset: 0x0001C055
			public unsafe Il2CppStringArray Names
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.ValuesAndNames.NativeFieldInfoPtr_Names);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Enum.ValuesAndNames.NativeFieldInfoPtr_Names), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FBC RID: 16316
			private static readonly IntPtr NativeFieldInfoPtr_Values;

			// Token: 0x04003FBD RID: 16317
			private static readonly IntPtr NativeFieldInfoPtr_Names;

			// Token: 0x04003FBE RID: 16318
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_UInt64_Il2CppStringArray_0;
		}
	}
}

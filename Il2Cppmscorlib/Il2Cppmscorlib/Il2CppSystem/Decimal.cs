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
	// Token: 0x02000098 RID: 152
	[Serializable]
	[StructLayout(2)]
	public struct Decimal
	{
		// Token: 0x06000A4A RID: 2634 RVA: 0x00050530 File Offset: 0x0004E730
		// Note: this type is marked as 'beforefieldinit'.
		static Decimal()
		{
			Il2CppClassPointerStore<Decimal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Decimal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Decimal>.NativeClassPtr);
			Decimal.NativeFieldInfoPtr_SignMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "SignMask");
			Decimal.NativeFieldInfoPtr_DECIMAL_NEG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "DECIMAL_NEG");
			Decimal.NativeFieldInfoPtr_DECIMAL_ADD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "DECIMAL_ADD");
			Decimal.NativeFieldInfoPtr_ScaleMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "ScaleMask");
			Decimal.NativeFieldInfoPtr_ScaleShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "ScaleShift");
			Decimal.NativeFieldInfoPtr_MaxInt32Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "MaxInt32Scale");
			Decimal.NativeFieldInfoPtr_Powers10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "Powers10");
			Decimal.NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "Zero");
			Decimal.NativeFieldInfoPtr_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "One");
			Decimal.NativeFieldInfoPtr_MinusOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "MinusOne");
			Decimal.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "MaxValue");
			Decimal.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "MinValue");
			Decimal.NativeFieldInfoPtr_NearNegativeZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "NearNegativeZero");
			Decimal.NativeFieldInfoPtr_NearPositiveZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "NearPositiveZero");
			Decimal.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "flags");
			Decimal.NativeFieldInfoPtr_hi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "hi");
			Decimal.NativeFieldInfoPtr_lo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "lo");
			Decimal.NativeFieldInfoPtr_mid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decimal>.NativeClassPtr, "mid");
			Decimal.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665000);
			Decimal.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665001);
			Decimal.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665002);
			Decimal.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665003);
			Decimal.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665004);
			Decimal.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665005);
			Decimal.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665006);
			Decimal.NativeMethodInfoPtr_SetBits_Private_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665007);
			Decimal.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665008);
			Decimal.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665009);
			Decimal.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665010);
			Decimal.NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665011);
			Decimal.NativeMethodInfoPtr_FCallAddSub_Private_Static_Void_byref_Decimal_byref_Decimal_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665012);
			Decimal.NativeMethodInfoPtr_FCallCompare_Private_Static_Int32_byref_Decimal_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665013);
			Decimal.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665014);
			Decimal.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665015);
			Decimal.NativeMethodInfoPtr_FCallDivide_Private_Static_Void_byref_Decimal_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665016);
			Decimal.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665017);
			Decimal.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665018);
			Decimal.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665019);
			Decimal.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665020);
			Decimal.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665021);
			Decimal.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665022);
			Decimal.NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665023);
			Decimal.NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_NumberStyles_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665024);
			Decimal.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_NumberStyles_IFormatProvider_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665025);
			Decimal.NativeMethodInfoPtr_GetBits_Public_Static_Il2CppStructArray_1_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665026);
			Decimal.NativeMethodInfoPtr_ToDecimal_Internal_Static_Decimal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665027);
			Decimal.NativeMethodInfoPtr_FCallMultiply_Private_Static_Void_byref_Decimal_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665028);
			Decimal.NativeMethodInfoPtr_Negate_Public_Static_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665029);
			Decimal.NativeMethodInfoPtr_Round_Public_Static_Decimal_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665030);
			Decimal.NativeMethodInfoPtr_FCallRound_Private_Static_Void_byref_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665031);
			Decimal.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665032);
			Decimal.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665033);
			Decimal.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665034);
			Decimal.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665035);
			Decimal.NativeMethodInfoPtr_FCallToInt32_Internal_Static_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665036);
			Decimal.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665037);
			Decimal.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665038);
			Decimal.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665039);
			Decimal.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665040);
			Decimal.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665041);
			Decimal.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665042);
			Decimal.NativeMethodInfoPtr_Truncate_Public_Static_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665043);
			Decimal.NativeMethodInfoPtr_FCallTruncate_Private_Static_Void_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665044);
			Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665045);
			Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665046);
			Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665047);
			Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665048);
			Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665049);
			Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665050);
			Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665051);
			Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665052);
			Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665053);
			Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665054);
			Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665055);
			Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665056);
			Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665057);
			Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Single_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665058);
			Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Double_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665059);
			Decimal.NativeMethodInfoPtr_op_Addition_Public_Static_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665060);
			Decimal.NativeMethodInfoPtr_op_Subtraction_Public_Static_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665061);
			Decimal.NativeMethodInfoPtr_op_Multiply_Public_Static_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665062);
			Decimal.NativeMethodInfoPtr_op_Division_Public_Static_Decimal_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665063);
			Decimal.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665064);
			Decimal.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665065);
			Decimal.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665066);
			Decimal.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665067);
			Decimal.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665068);
			Decimal.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665069);
			Decimal.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665070);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665071);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665072);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665073);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665074);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665075);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665076);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665077);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665078);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665079);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665080);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665081);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665082);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665083);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665084);
			Decimal.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decimal>.NativeClassPtr, 100665085);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00050D80 File Offset: 0x0004EF80
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 280930, RefRangeEnd = 280935, XrefRangeStart = 280930, XrefRangeEnd = 280930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00050DB4 File Offset: 0x0004EFB4
		[CallerCount(0)]
		public unsafe Decimal(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00050DE8 File Offset: 0x0004EFE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280935, RefRangeEnd = 280937, XrefRangeStart = 280935, XrefRangeEnd = 280935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00050E1C File Offset: 0x0004F01C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280937, RefRangeEnd = 280938, XrefRangeStart = 280937, XrefRangeEnd = 280937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00050E50 File Offset: 0x0004F050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280938, XrefRangeEnd = 280939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00050E84 File Offset: 0x0004F084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280939, XrefRangeEnd = 280940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00050EB8 File Offset: 0x0004F0B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280940, RefRangeEnd = 280942, XrefRangeStart = 280940, XrefRangeEnd = 280940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal(Il2CppStructArray<int> bits)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bits);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00050EF0 File Offset: 0x0004F0F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280942, RefRangeEnd = 280944, XrefRangeStart = 280942, XrefRangeEnd = 280942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBits(Il2CppStructArray<int> bits)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bits);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_SetBits_Private_Void_Il2CppStructArray_1_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00050F28 File Offset: 0x0004F128
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 280944, RefRangeEnd = 280961, XrefRangeStart = 280944, XrefRangeEnd = 280944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal(int lo, int mid, int hi, bool isNegative, byte scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mid;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNegative;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_Byte_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00050F94 File Offset: 0x0004F194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280961, XrefRangeEnd = 280966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializing(StreamingContext ctx)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00050FD0 File Offset: 0x0004F1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280966, XrefRangeEnd = 280971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00051008 File Offset: 0x0004F208
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280971, RefRangeEnd = 280973, XrefRangeStart = 280971, XrefRangeEnd = 280971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal(int lo, int mid, int hi, int flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mid;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hi;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00051064 File Offset: 0x0004F264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280973, XrefRangeEnd = 280974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FCallAddSub(ref Decimal d1, ref Decimal d2, byte bSign)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &d2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSign;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_FCallAddSub_Private_Static_Void_byref_Decimal_byref_Decimal_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x000510B4 File Offset: 0x0004F2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280974, XrefRangeEnd = 280975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FCallCompare(ref Decimal d1, ref Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_FCallCompare_Private_Static_Int32_byref_Decimal_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00051100 File Offset: 0x0004F300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280981, RefRangeEnd = 280982, XrefRangeStart = 280975, XrefRangeEnd = 280981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00051144 File Offset: 0x0004F344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280982, XrefRangeEnd = 280986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Decimal_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00051184 File Offset: 0x0004F384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280986, XrefRangeEnd = 280987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FCallDivide(ref Decimal d1, ref Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_FCallDivide_Private_Static_Void_byref_Decimal_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x000511C4 File Offset: 0x0004F3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280987, XrefRangeEnd = 280993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00051208 File Offset: 0x0004F408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280993, XrefRangeEnd = 280997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Decimal_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00051248 File Offset: 0x0004F448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280997, XrefRangeEnd = 280998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00051278 File Offset: 0x0004F478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281000, RefRangeEnd = 281001, XrefRangeStart = 280998, XrefRangeEnd = 281000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x000512A4 File Offset: 0x0004F4A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281003, RefRangeEnd = 281005, XrefRangeStart = 281001, XrefRangeEnd = 281003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x000512E0 File Offset: 0x0004F4E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281007, RefRangeEnd = 281008, XrefRangeStart = 281005, XrefRangeEnd = 281007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00051330 File Offset: 0x0004F530
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281010, RefRangeEnd = 281012, XrefRangeStart = 281008, XrefRangeEnd = 281010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Parse(string s, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00051384 File Offset: 0x0004F584
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281015, RefRangeEnd = 281018, XrefRangeStart = 281012, XrefRangeEnd = 281015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_NumberStyles_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x000513E8 File Offset: 0x0004F5E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281036, RefRangeEnd = 281038, XrefRangeStart = 281018, XrefRangeEnd = 281036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out Decimal result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_NumberStyles_IFormatProvider_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00051458 File Offset: 0x0004F658
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 281041, RefRangeEnd = 281045, XrefRangeStart = 281038, XrefRangeEnd = 281041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> GetBits(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_GetBits_Public_Static_Il2CppStructArray_1_Int32_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00051498 File Offset: 0x0004F698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281046, RefRangeEnd = 281047, XrefRangeStart = 281045, XrefRangeEnd = 281046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ToDecimal(Il2CppStructArray<byte> buffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToDecimal_Internal_Static_Decimal_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x000514DC File Offset: 0x0004F6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281047, XrefRangeEnd = 281048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FCallMultiply(ref Decimal d1, ref Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_FCallMultiply_Private_Static_Void_byref_Decimal_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0005151C File Offset: 0x0004F71C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281049, RefRangeEnd = 281050, XrefRangeStart = 281048, XrefRangeEnd = 281049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Negate(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Negate_Public_Static_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0005155C File Offset: 0x0004F75C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 281054, RefRangeEnd = 281061, XrefRangeStart = 281050, XrefRangeEnd = 281054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Round(Decimal d, int decimals)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decimals;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Round_Public_Static_Decimal_Decimal_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x000515A8 File Offset: 0x0004F7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281061, XrefRangeEnd = 281062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FCallRound(ref Decimal d, int decimals)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &d;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref decimals;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_FCallRound_Private_Static_Void_byref_Decimal_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x000515E8 File Offset: 0x0004F7E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281066, RefRangeEnd = 281067, XrefRangeStart = 281062, XrefRangeEnd = 281066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte ToByte(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00051628 File Offset: 0x0004F828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281071, RefRangeEnd = 281072, XrefRangeStart = 281067, XrefRangeEnd = 281071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte ToSByte(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00051668 File Offset: 0x0004F868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281076, RefRangeEnd = 281077, XrefRangeStart = 281072, XrefRangeEnd = 281076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short ToInt16(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x000516A8 File Offset: 0x0004F8A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281078, RefRangeEnd = 281079, XrefRangeStart = 281077, XrefRangeEnd = 281078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x000516E8 File Offset: 0x0004F8E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281080, RefRangeEnd = 281081, XrefRangeStart = 281079, XrefRangeEnd = 281080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FCallToInt32(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_FCallToInt32_Internal_Static_Int32_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00051728 File Offset: 0x0004F928
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281085, RefRangeEnd = 281088, XrefRangeStart = 281081, XrefRangeEnd = 281085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToInt32(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00051768 File Offset: 0x0004F968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281092, RefRangeEnd = 281093, XrefRangeStart = 281088, XrefRangeEnd = 281092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToInt64(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x000517A8 File Offset: 0x0004F9A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281097, RefRangeEnd = 281098, XrefRangeStart = 281093, XrefRangeEnd = 281097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ToUInt16(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x000517E8 File Offset: 0x0004F9E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281102, RefRangeEnd = 281105, XrefRangeStart = 281098, XrefRangeEnd = 281102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ToUInt32(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00051828 File Offset: 0x0004FA28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281109, RefRangeEnd = 281110, XrefRangeStart = 281105, XrefRangeEnd = 281109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ToUInt64(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00051868 File Offset: 0x0004FA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281110, XrefRangeEnd = 281111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x000518A8 File Offset: 0x0004FAA8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 281115, RefRangeEnd = 281121, XrefRangeStart = 281111, XrefRangeEnd = 281115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Truncate(Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_Truncate_Public_Static_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x000518E8 File Offset: 0x0004FAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281121, XrefRangeEnd = 281122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FCallTruncate(ref Decimal d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_FCallTruncate_Private_Static_Void_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0005191C File Offset: 0x0004FB1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281122, RefRangeEnd = 281123, XrefRangeStart = 281122, XrefRangeEnd = 281122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Decimal(byte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0005195C File Offset: 0x0004FB5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281123, RefRangeEnd = 281124, XrefRangeStart = 281123, XrefRangeEnd = 281123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Decimal(sbyte value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0005199C File Offset: 0x0004FB9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281124, RefRangeEnd = 281126, XrefRangeStart = 281124, XrefRangeEnd = 281124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Decimal(short value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x000519DC File Offset: 0x0004FBDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281126, RefRangeEnd = 281127, XrefRangeStart = 281126, XrefRangeEnd = 281126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Decimal(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00051A1C File Offset: 0x0004FC1C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 281127, RefRangeEnd = 281132, XrefRangeStart = 281127, XrefRangeEnd = 281127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Decimal(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00051A5C File Offset: 0x0004FC5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281132, RefRangeEnd = 281133, XrefRangeStart = 281132, XrefRangeEnd = 281132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Decimal(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00051A9C File Offset: 0x0004FC9C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 281133, RefRangeEnd = 281137, XrefRangeStart = 281133, XrefRangeEnd = 281133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Decimal(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00051ADC File Offset: 0x0004FCDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281137, RefRangeEnd = 281140, XrefRangeStart = 281137, XrefRangeEnd = 281137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Decimal(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00051B1C File Offset: 0x0004FD1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281141, RefRangeEnd = 281143, XrefRangeStart = 281140, XrefRangeEnd = 281141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Decimal(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00051B5C File Offset: 0x0004FD5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281144, RefRangeEnd = 281145, XrefRangeStart = 281143, XrefRangeEnd = 281144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Decimal(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00051B9C File Offset: 0x0004FD9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281149, RefRangeEnd = 281150, XrefRangeStart = 281145, XrefRangeEnd = 281149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator int(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00051BDC File Offset: 0x0004FDDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281159, RefRangeEnd = 281162, XrefRangeStart = 281150, XrefRangeEnd = 281159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator long(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00051C1C File Offset: 0x0004FE1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281170, RefRangeEnd = 281171, XrefRangeStart = 281162, XrefRangeEnd = 281170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator ulong(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00051C5C File Offset: 0x0004FE5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281175, RefRangeEnd = 281176, XrefRangeStart = 281171, XrefRangeEnd = 281175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Single_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00051C9C File Offset: 0x0004FE9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281180, RefRangeEnd = 281182, XrefRangeStart = 281176, XrefRangeEnd = 281180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator double(Decimal value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Explicit_Public_Static_Double_Decimal_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00051CDC File Offset: 0x0004FEDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281186, RefRangeEnd = 281187, XrefRangeStart = 281182, XrefRangeEnd = 281186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal operator +(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Addition_Public_Static_Decimal_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x00051D28 File Offset: 0x0004FF28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 281191, RefRangeEnd = 281194, XrefRangeStart = 281187, XrefRangeEnd = 281191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal operator -(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Subtraction_Public_Static_Decimal_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00051D74 File Offset: 0x0004FF74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 281198, RefRangeEnd = 281202, XrefRangeStart = 281194, XrefRangeEnd = 281198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal operator *(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Multiply_Public_Static_Decimal_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x00051DC0 File Offset: 0x0004FFC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281206, RefRangeEnd = 281207, XrefRangeStart = 281202, XrefRangeEnd = 281206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal operator /(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Division_Public_Static_Decimal_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00051E0C File Offset: 0x0005000C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 281211, RefRangeEnd = 281218, XrefRangeStart = 281207, XrefRangeEnd = 281211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00051E58 File Offset: 0x00050058
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 281222, RefRangeEnd = 281230, XrefRangeStart = 281218, XrefRangeEnd = 281222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00051EA4 File Offset: 0x000500A4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 281234, RefRangeEnd = 281243, XrefRangeStart = 281230, XrefRangeEnd = 281234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00051EF0 File Offset: 0x000500F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281243, XrefRangeEnd = 281247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <=(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00051F3C File Offset: 0x0005013C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 281251, RefRangeEnd = 281257, XrefRangeStart = 281247, XrefRangeEnd = 281251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00051F88 File Offset: 0x00050188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281257, XrefRangeEnd = 281261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >=(Decimal d1, Decimal d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Decimal_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00051FD4 File Offset: 0x000501D4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 22552, RefRangeEnd = 22562, XrefRangeStart = 22552, XrefRangeEnd = 22562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeCode GetTypeCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00052004 File Offset: 0x00050204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281261, XrefRangeEnd = 281265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_IConvertible_ToBoolean(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00052048 File Offset: 0x00050248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281265, XrefRangeEnd = 281284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char System_IConvertible_ToChar(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0005208C File Offset: 0x0005028C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281284, XrefRangeEnd = 281288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe sbyte System_IConvertible_ToSByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x000520D0 File Offset: 0x000502D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281288, XrefRangeEnd = 281292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte System_IConvertible_ToByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00052114 File Offset: 0x00050314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281292, XrefRangeEnd = 281296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short System_IConvertible_ToInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00052158 File Offset: 0x00050358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281296, XrefRangeEnd = 281300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort System_IConvertible_ToUInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0005219C File Offset: 0x0005039C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281300, XrefRangeEnd = 281304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IConvertible_ToInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x000521E0 File Offset: 0x000503E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281304, XrefRangeEnd = 281308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint System_IConvertible_ToUInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00052224 File Offset: 0x00050424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281308, XrefRangeEnd = 281312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long System_IConvertible_ToInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00052268 File Offset: 0x00050468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281312, XrefRangeEnd = 281316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong System_IConvertible_ToUInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x000522AC File Offset: 0x000504AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281316, XrefRangeEnd = 281320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float System_IConvertible_ToSingle(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x000522F0 File Offset: 0x000504F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281320, XrefRangeEnd = 281324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double System_IConvertible_ToDouble(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00052334 File Offset: 0x00050534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108457, RefRangeEnd = 108458, XrefRangeStart = 108457, XrefRangeEnd = 108458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal System_IConvertible_ToDecimal(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00052378 File Offset: 0x00050578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281324, XrefRangeEnd = 281343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime System_IConvertible_ToDateTime(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x000523BC File Offset: 0x000505BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281343, XrefRangeEnd = 281350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decimal.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00004C6B File Offset: 0x00002E6B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Decimal>.NativeClassPtr, ref this));
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x00052414 File Offset: 0x00050614
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x00004C7D File Offset: 0x00002E7D
		public unsafe static int SignMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_SignMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_SignMask, (void*)(&value));
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x00052430 File Offset: 0x00050630
		// (set) Token: 0x06000AA5 RID: 2725 RVA: 0x00004C8B File Offset: 0x00002E8B
		public unsafe static byte DECIMAL_NEG
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_DECIMAL_NEG, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_DECIMAL_NEG, (void*)(&value));
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x0005244C File Offset: 0x0005064C
		// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x00004C99 File Offset: 0x00002E99
		public unsafe static byte DECIMAL_ADD
		{
			get
			{
				byte b;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_DECIMAL_ADD, (void*)(&b));
				return b;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_DECIMAL_ADD, (void*)(&value));
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x00052468 File Offset: 0x00050668
		// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x00004CA7 File Offset: 0x00002EA7
		public unsafe static int ScaleMask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_ScaleMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_ScaleMask, (void*)(&value));
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x00052484 File Offset: 0x00050684
		// (set) Token: 0x06000AAB RID: 2731 RVA: 0x00004CB5 File Offset: 0x00002EB5
		public unsafe static int ScaleShift
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_ScaleShift, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_ScaleShift, (void*)(&value));
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x000524A0 File Offset: 0x000506A0
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x00004CC3 File Offset: 0x00002EC3
		public unsafe static int MaxInt32Scale
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_MaxInt32Scale, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_MaxInt32Scale, (void*)(&value));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x000524BC File Offset: 0x000506BC
		// (set) Token: 0x06000AAF RID: 2735 RVA: 0x00004CD1 File Offset: 0x00002ED1
		public unsafe static Il2CppStructArray<uint> Powers10
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_Powers10, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_Powers10, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x000524E4 File Offset: 0x000506E4
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x00004CE3 File Offset: 0x00002EE3
		public unsafe static Decimal Zero
		{
			get
			{
				Decimal @decimal;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_Zero, (void*)(&@decimal));
				return @decimal;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_Zero, (void*)(&value));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x00052500 File Offset: 0x00050700
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x00004CF1 File Offset: 0x00002EF1
		public unsafe static Decimal One
		{
			get
			{
				Decimal @decimal;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_One, (void*)(&@decimal));
				return @decimal;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_One, (void*)(&value));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x0005251C File Offset: 0x0005071C
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x00004CFF File Offset: 0x00002EFF
		public unsafe static Decimal MinusOne
		{
			get
			{
				Decimal @decimal;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_MinusOne, (void*)(&@decimal));
				return @decimal;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_MinusOne, (void*)(&value));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x00052538 File Offset: 0x00050738
		// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x00004D0D File Offset: 0x00002F0D
		public unsafe static Decimal MaxValue
		{
			get
			{
				Decimal @decimal;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_MaxValue, (void*)(&@decimal));
				return @decimal;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00052554 File Offset: 0x00050754
		// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x00004D1B File Offset: 0x00002F1B
		public unsafe static Decimal MinValue
		{
			get
			{
				Decimal @decimal;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_MinValue, (void*)(&@decimal));
				return @decimal;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x00052570 File Offset: 0x00050770
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x00004D29 File Offset: 0x00002F29
		public unsafe static Decimal NearNegativeZero
		{
			get
			{
				Decimal @decimal;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_NearNegativeZero, (void*)(&@decimal));
				return @decimal;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_NearNegativeZero, (void*)(&value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0005258C File Offset: 0x0005078C
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x00004D37 File Offset: 0x00002F37
		public unsafe static Decimal NearPositiveZero
		{
			get
			{
				Decimal @decimal;
				IL2CPP.il2cpp_field_static_get_value(Decimal.NativeFieldInfoPtr_NearPositiveZero, (void*)(&@decimal));
				return @decimal;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Decimal.NativeFieldInfoPtr_NearPositiveZero, (void*)(&value));
			}
		}

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeFieldInfoPtr_SignMask;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeFieldInfoPtr_DECIMAL_NEG;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeFieldInfoPtr_DECIMAL_ADD;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeFieldInfoPtr_ScaleMask;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeFieldInfoPtr_ScaleShift;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeFieldInfoPtr_MaxInt32Scale;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeFieldInfoPtr_Powers10;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeFieldInfoPtr_Zero;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeFieldInfoPtr_One;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeFieldInfoPtr_MinusOne;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeFieldInfoPtr_NearNegativeZero;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeFieldInfoPtr_NearPositiveZero;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeFieldInfoPtr_hi;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeFieldInfoPtr_lo;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeFieldInfoPtr_mid;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_SetBits_Private_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_Byte_0;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr_FCallAddSub_Private_Static_Void_byref_Decimal_byref_Decimal_Byte_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_FCallCompare_Private_Static_Int32_byref_Decimal_byref_Decimal_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Decimal_0;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr_FCallDivide_Private_Static_Void_byref_Decimal_byref_Decimal_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Decimal_0;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_IFormatProvider_0;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Decimal_String_NumberStyles_IFormatProvider_0;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_NumberStyles_IFormatProvider_byref_Decimal_0;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeMethodInfoPtr_GetBits_Public_Static_Il2CppStructArray_1_Int32_Decimal_0;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Internal_Static_Decimal_Il2CppStructArray_1_Byte_0;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeMethodInfoPtr_FCallMultiply_Private_Static_Void_byref_Decimal_byref_Decimal_0;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeMethodInfoPtr_Negate_Public_Static_Decimal_Decimal_0;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeMethodInfoPtr_Round_Public_Static_Decimal_Decimal_Int32_0;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeMethodInfoPtr_FCallRound_Private_Static_Void_byref_Decimal_Int32_0;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeMethodInfoPtr_ToByte_Public_Static_Byte_Decimal_0;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeMethodInfoPtr_ToSByte_Public_Static_SByte_Decimal_0;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeMethodInfoPtr_ToInt16_Public_Static_Int16_Decimal_0;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Public_Static_Double_Decimal_0;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeMethodInfoPtr_FCallToInt32_Internal_Static_Int32_Decimal_0;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_Decimal_0;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeMethodInfoPtr_ToInt64_Public_Static_Int64_Decimal_0;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt16_Public_Static_UInt16_Decimal_0;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt32_Public_Static_UInt32_Decimal_0;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeMethodInfoPtr_ToUInt64_Public_Static_UInt64_Decimal_0;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Public_Static_Single_Decimal_0;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeMethodInfoPtr_Truncate_Public_Static_Decimal_Decimal_0;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeMethodInfoPtr_FCallTruncate_Private_Static_Void_byref_Decimal_0;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Byte_0;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_SByte_0;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int16_0;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt16_0;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int32_0;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt32_0;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_Int64_0;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_UInt64_0;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_Single_0;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Decimal_Double_0;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int32_Decimal_0;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Int64_Decimal_0;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_UInt64_Decimal_0;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Single_Decimal_0;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Double_Decimal_0;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Decimal_Decimal_Decimal_0;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Decimal_Decimal_Decimal_0;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Decimal_Decimal_Decimal_0;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Decimal_Decimal_Decimal_0;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Decimal_Decimal_0;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Decimal_Decimal_0;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Decimal_Decimal_0;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_Decimal_Decimal_0;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Decimal_Decimal_0;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_Decimal_Decimal_0;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0;

		// Token: 0x040008F8 RID: 2296
		[FieldOffset(0)]
		public int flags;

		// Token: 0x040008F9 RID: 2297
		[FieldOffset(4)]
		public int hi;

		// Token: 0x040008FA RID: 2298
		[FieldOffset(8)]
		public int lo;

		// Token: 0x040008FB RID: 2299
		[FieldOffset(12)]
		public int mid;
	}
}

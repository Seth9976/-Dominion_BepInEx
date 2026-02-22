using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem
{
	// Token: 0x0200009C RID: 156
	[Serializable]
	[StructLayout(2)]
	public struct Double
	{
		// Token: 0x06000ADE RID: 2782 RVA: 0x00053370 File Offset: 0x00051570
		// Note: this type is marked as 'beforefieldinit'.
		static Double()
		{
			Il2CppClassPointerStore<double>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Double");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<double>.NativeClassPtr);
			Double.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double>.NativeClassPtr, "m_value");
			Double.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double>.NativeClassPtr, "MinValue");
			Double.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double>.NativeClassPtr, "MaxValue");
			Double.NativeFieldInfoPtr_Epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double>.NativeClassPtr, "Epsilon");
			Double.NativeFieldInfoPtr_NegativeInfinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double>.NativeClassPtr, "NegativeInfinity");
			Double.NativeFieldInfoPtr_PositiveInfinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double>.NativeClassPtr, "PositiveInfinity");
			Double.NativeFieldInfoPtr_NaN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double>.NativeClassPtr, "NaN");
			Double.NativeFieldInfoPtr_NegativeZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double>.NativeClassPtr, "NegativeZero");
			Double.NativeMethodInfoPtr_IsInfinity_Public_Static_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665117);
			Double.NativeMethodInfoPtr_IsPositiveInfinity_Public_Static_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665118);
			Double.NativeMethodInfoPtr_IsNegativeInfinity_Public_Static_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665119);
			Double.NativeMethodInfoPtr_IsNaN_Public_Static_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665120);
			Double.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665121);
			Double.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665122);
			Double.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665123);
			Double.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665124);
			Double.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665125);
			Double.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665126);
			Double.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665127);
			Double.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665128);
			Double.NativeMethodInfoPtr_Parse_Public_Static_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665129);
			Double.NativeMethodInfoPtr_Parse_Public_Static_Double_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665130);
			Double.NativeMethodInfoPtr_Parse_Public_Static_Double_String_NumberStyles_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665131);
			Double.NativeMethodInfoPtr_Parse_Private_Static_Double_String_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665132);
			Double.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665133);
			Double.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_NumberStyles_IFormatProvider_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665134);
			Double.NativeMethodInfoPtr_TryParse_Private_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665135);
			Double.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665136);
			Double.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665137);
			Double.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665138);
			Double.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665139);
			Double.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665140);
			Double.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665141);
			Double.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665142);
			Double.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665143);
			Double.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665144);
			Double.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665145);
			Double.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665146);
			Double.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665147);
			Double.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665148);
			Double.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665149);
			Double.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665150);
			Double.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double>.NativeClassPtr, 100665151);
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x000536FC File Offset: 0x000518FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281898, RefRangeEnd = 281899, XrefRangeStart = 281898, XrefRangeEnd = 281898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInfinity(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_IsInfinity_Public_Static_Boolean_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0005373C File Offset: 0x0005193C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281899, RefRangeEnd = 281901, XrefRangeStart = 281899, XrefRangeEnd = 281899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPositiveInfinity(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_IsPositiveInfinity_Public_Static_Boolean_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0005377C File Offset: 0x0005197C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281901, RefRangeEnd = 281902, XrefRangeStart = 281901, XrefRangeEnd = 281901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNegativeInfinity(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_IsNegativeInfinity_Public_Static_Boolean_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x000537BC File Offset: 0x000519BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 281902, RefRangeEnd = 281906, XrefRangeStart = 281902, XrefRangeEnd = 281902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNaN(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_IsNaN_Public_Static_Boolean_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x000537FC File Offset: 0x000519FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281915, RefRangeEnd = 281916, XrefRangeStart = 281906, XrefRangeEnd = 281915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00053840 File Offset: 0x00051A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281916, XrefRangeEnd = 281923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00053880 File Offset: 0x00051A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281923, XrefRangeEnd = 281926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x000538C4 File Offset: 0x00051AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281926, XrefRangeEnd = 281927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(double obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00053904 File Offset: 0x00051B04
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00053934 File Offset: 0x00051B34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281929, RefRangeEnd = 281930, XrefRangeStart = 281927, XrefRangeEnd = 281929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00053960 File Offset: 0x00051B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281930, XrefRangeEnd = 281932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0005399C File Offset: 0x00051B9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281934, RefRangeEnd = 281935, XrefRangeStart = 281932, XrefRangeEnd = 281934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x000539EC File Offset: 0x00051BEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281940, RefRangeEnd = 281941, XrefRangeStart = 281935, XrefRangeEnd = 281940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Parse(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_Parse_Public_Static_Double_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00053A30 File Offset: 0x00051C30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281946, RefRangeEnd = 281948, XrefRangeStart = 281941, XrefRangeEnd = 281946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Parse(string s, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_Parse_Public_Static_Double_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00053A84 File Offset: 0x00051C84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 281954, RefRangeEnd = 281956, XrefRangeStart = 281948, XrefRangeEnd = 281954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Parse(string s, NumberStyles style, IFormatProvider provider)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_Parse_Public_Static_Double_String_NumberStyles_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00053AE8 File Offset: 0x00051CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281956, XrefRangeEnd = 281957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Parse(string s, NumberStyles style, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_Parse_Private_Static_Double_String_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00053B4C File Offset: 0x00051D4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 281966, RefRangeEnd = 281970, XrefRangeStart = 281957, XrefRangeEnd = 281966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, out double result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00053B9C File Offset: 0x00051D9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 281983, RefRangeEnd = 281984, XrefRangeStart = 281970, XrefRangeEnd = 281983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_NumberStyles_IFormatProvider_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00053C0C File Offset: 0x00051E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281984, XrefRangeEnd = 281989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out double result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref style;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_TryParse_Private_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00053C7C File Offset: 0x00051E7C
		[CallerCount(0)]
		public unsafe TypeCode GetTypeCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00053CAC File Offset: 0x00051EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281989, XrefRangeEnd = 281993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_IConvertible_ToBoolean(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00053CF0 File Offset: 0x00051EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281993, XrefRangeEnd = 282012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char System_IConvertible_ToChar(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00053D34 File Offset: 0x00051F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282012, XrefRangeEnd = 282016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe sbyte System_IConvertible_ToSByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00053D78 File Offset: 0x00051F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282016, XrefRangeEnd = 282020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte System_IConvertible_ToByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00053DBC File Offset: 0x00051FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282020, XrefRangeEnd = 282024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short System_IConvertible_ToInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00053E00 File Offset: 0x00052000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282024, XrefRangeEnd = 282028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort System_IConvertible_ToUInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00053E44 File Offset: 0x00052044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282028, XrefRangeEnd = 282032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IConvertible_ToInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x00053E88 File Offset: 0x00052088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282032, XrefRangeEnd = 282036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint System_IConvertible_ToUInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00053ECC File Offset: 0x000520CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282036, XrefRangeEnd = 282040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long System_IConvertible_ToInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00053F10 File Offset: 0x00052110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282040, XrefRangeEnd = 282044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong System_IConvertible_ToUInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00053F54 File Offset: 0x00052154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282044, XrefRangeEnd = 282048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float System_IConvertible_ToSingle(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x00053F98 File Offset: 0x00052198
		[CallerCount(0)]
		public unsafe double System_IConvertible_ToDouble(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00053FDC File Offset: 0x000521DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282048, XrefRangeEnd = 282052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal System_IConvertible_ToDecimal(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x00054020 File Offset: 0x00052220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282052, XrefRangeEnd = 282071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime System_IConvertible_ToDateTime(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00054064 File Offset: 0x00052264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282071, XrefRangeEnd = 282078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Double.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00004D60 File Offset: 0x00002F60
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<double>.NativeClassPtr, ref this));
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x000540BC File Offset: 0x000522BC
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x00004D72 File Offset: 0x00002F72
		public unsafe static double MinValue
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(Double.NativeFieldInfoPtr_MinValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Double.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x000540D8 File Offset: 0x000522D8
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x00004D80 File Offset: 0x00002F80
		public unsafe static double MaxValue
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(Double.NativeFieldInfoPtr_MaxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Double.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x000540F4 File Offset: 0x000522F4
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x00004D8E File Offset: 0x00002F8E
		public unsafe static double Epsilon
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(Double.NativeFieldInfoPtr_Epsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Double.NativeFieldInfoPtr_Epsilon, (void*)(&value));
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00054110 File Offset: 0x00052310
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x00004D9C File Offset: 0x00002F9C
		public unsafe static double NegativeInfinity
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(Double.NativeFieldInfoPtr_NegativeInfinity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Double.NativeFieldInfoPtr_NegativeInfinity, (void*)(&value));
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x0005412C File Offset: 0x0005232C
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x00004DAA File Offset: 0x00002FAA
		public unsafe static double PositiveInfinity
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(Double.NativeFieldInfoPtr_PositiveInfinity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Double.NativeFieldInfoPtr_PositiveInfinity, (void*)(&value));
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00054148 File Offset: 0x00052348
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x00004DB8 File Offset: 0x00002FB8
		public unsafe static double NaN
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(Double.NativeFieldInfoPtr_NaN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Double.NativeFieldInfoPtr_NaN, (void*)(&value));
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x00054164 File Offset: 0x00052364
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x00004DC6 File Offset: 0x00002FC6
		public unsafe static double NegativeZero
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(Double.NativeFieldInfoPtr_NegativeZero, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Double.NativeFieldInfoPtr_NegativeZero, (void*)(&value));
			}
		}

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeFieldInfoPtr_Epsilon;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeFieldInfoPtr_NegativeInfinity;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeFieldInfoPtr_PositiveInfinity;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeFieldInfoPtr_NaN;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeFieldInfoPtr_NegativeZero;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeMethodInfoPtr_IsInfinity_Public_Static_Boolean_Double_0;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeMethodInfoPtr_IsPositiveInfinity_Public_Static_Boolean_Double_0;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeMethodInfoPtr_IsNegativeInfinity_Public_Static_Boolean_Double_0;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeMethodInfoPtr_IsNaN_Public_Static_Boolean_Double_0;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Double_0;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Double_0;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Double_String_0;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Double_String_IFormatProvider_0;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Double_String_NumberStyles_IFormatProvider_0;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Private_Static_Double_String_NumberStyles_NumberFormatInfo_0;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Double_0;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_NumberStyles_IFormatProvider_byref_Double_0;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Private_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Double_0;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0;

		// Token: 0x04000941 RID: 2369
		[FieldOffset(0)]
		public double m_value;
	}
}

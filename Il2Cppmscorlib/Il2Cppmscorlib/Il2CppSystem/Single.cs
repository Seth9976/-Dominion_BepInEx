using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem
{
	// Token: 0x020000E5 RID: 229
	[Serializable]
	[StructLayout(2)]
	public struct Single
	{
		// Token: 0x06000F6E RID: 3950 RVA: 0x00068CB0 File Offset: 0x00066EB0
		// Note: this type is marked as 'beforefieldinit'.
		static Single()
		{
			Il2CppClassPointerStore<float>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Single");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<float>.NativeClassPtr);
			Single.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float>.NativeClassPtr, "m_value");
			Single.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float>.NativeClassPtr, "MinValue");
			Single.NativeFieldInfoPtr_Epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float>.NativeClassPtr, "Epsilon");
			Single.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float>.NativeClassPtr, "MaxValue");
			Single.NativeFieldInfoPtr_PositiveInfinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float>.NativeClassPtr, "PositiveInfinity");
			Single.NativeFieldInfoPtr_NegativeInfinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float>.NativeClassPtr, "NegativeInfinity");
			Single.NativeFieldInfoPtr_NaN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float>.NativeClassPtr, "NaN");
			Single.NativeMethodInfoPtr_IsInfinity_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665916);
			Single.NativeMethodInfoPtr_IsPositiveInfinity_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665917);
			Single.NativeMethodInfoPtr_IsNegativeInfinity_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665918);
			Single.NativeMethodInfoPtr_IsNaN_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665919);
			Single.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665920);
			Single.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665921);
			Single.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665922);
			Single.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665923);
			Single.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665924);
			Single.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665925);
			Single.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665926);
			Single.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665927);
			Single.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665928);
			Single.NativeMethodInfoPtr_Parse_Public_Static_Single_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665929);
			Single.NativeMethodInfoPtr_Parse_Public_Static_Single_String_NumberStyles_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665930);
			Single.NativeMethodInfoPtr_Parse_Private_Static_Single_String_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665931);
			Single.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665932);
			Single.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_NumberStyles_IFormatProvider_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665933);
			Single.NativeMethodInfoPtr_TryParse_Private_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665934);
			Single.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665935);
			Single.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665936);
			Single.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665937);
			Single.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665938);
			Single.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665939);
			Single.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665940);
			Single.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665941);
			Single.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665942);
			Single.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665943);
			Single.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665944);
			Single.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665945);
			Single.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665946);
			Single.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665947);
			Single.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665948);
			Single.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665949);
			Single.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float>.NativeClassPtr, 100665950);
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00069028 File Offset: 0x00067228
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 291971, RefRangeEnd = 291974, XrefRangeStart = 291971, XrefRangeEnd = 291971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInfinity(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_IsInfinity_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00069068 File Offset: 0x00067268
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291974, RefRangeEnd = 291975, XrefRangeStart = 291974, XrefRangeEnd = 291974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPositiveInfinity(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_IsPositiveInfinity_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x000690A8 File Offset: 0x000672A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291975, RefRangeEnd = 291976, XrefRangeStart = 291975, XrefRangeEnd = 291975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNegativeInfinity(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_IsNegativeInfinity_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x000690E8 File Offset: 0x000672E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 291976, RefRangeEnd = 291983, XrefRangeStart = 291976, XrefRangeEnd = 291976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNaN(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_IsNaN_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00069128 File Offset: 0x00067328
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291986, RefRangeEnd = 291987, XrefRangeStart = 291983, XrefRangeEnd = 291986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x0006916C File Offset: 0x0006736C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 291987, RefRangeEnd = 291991, XrefRangeStart = 291987, XrefRangeEnd = 291987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x000691AC File Offset: 0x000673AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291991, XrefRangeEnd = 291994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x000691F0 File Offset: 0x000673F0
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 291994, RefRangeEnd = 292024, XrefRangeStart = 291994, XrefRangeEnd = 291994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(float obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00069230 File Offset: 0x00067430
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 292024, RefRangeEnd = 292078, XrefRangeStart = 292024, XrefRangeEnd = 292024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00069260 File Offset: 0x00067460
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 292080, RefRangeEnd = 292101, XrefRangeStart = 292078, XrefRangeEnd = 292080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x0006928C File Offset: 0x0006748C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292103, RefRangeEnd = 292105, XrefRangeStart = 292101, XrefRangeEnd = 292103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x000692C8 File Offset: 0x000674C8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 292107, RefRangeEnd = 292121, XrefRangeStart = 292105, XrefRangeEnd = 292107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00069304 File Offset: 0x00067504
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 292123, RefRangeEnd = 292162, XrefRangeStart = 292121, XrefRangeEnd = 292123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00069354 File Offset: 0x00067554
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292164, RefRangeEnd = 292166, XrefRangeStart = 292162, XrefRangeEnd = 292164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Parse(string s, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_Parse_Public_Static_Single_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x000693A8 File Offset: 0x000675A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292169, RefRangeEnd = 292171, XrefRangeStart = 292166, XrefRangeEnd = 292169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Parse(string s, NumberStyles style, IFormatProvider provider)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_Parse_Public_Static_Single_String_NumberStyles_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0006940C File Offset: 0x0006760C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292171, XrefRangeEnd = 292172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Parse(string s, NumberStyles style, NumberFormatInfo info)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_Parse_Private_Static_Single_String_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00069470 File Offset: 0x00067670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292174, RefRangeEnd = 292175, XrefRangeStart = 292172, XrefRangeEnd = 292174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, out float result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x000694C0 File Offset: 0x000676C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292178, RefRangeEnd = 292179, XrefRangeStart = 292175, XrefRangeEnd = 292178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_NumberStyles_IFormatProvider_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00069530 File Offset: 0x00067730
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292184, RefRangeEnd = 292186, XrefRangeStart = 292179, XrefRangeEnd = 292184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, NumberStyles style, NumberFormatInfo info, out float result)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_TryParse_Private_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x000695A0 File Offset: 0x000677A0
		[CallerCount(0)]
		public unsafe TypeCode GetTypeCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x000695D0 File Offset: 0x000677D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292186, XrefRangeEnd = 292190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_IConvertible_ToBoolean(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00069614 File Offset: 0x00067814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292190, XrefRangeEnd = 292209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char System_IConvertible_ToChar(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00069658 File Offset: 0x00067858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292209, XrefRangeEnd = 292213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe sbyte System_IConvertible_ToSByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x0006969C File Offset: 0x0006789C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292213, XrefRangeEnd = 292217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte System_IConvertible_ToByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x000696E0 File Offset: 0x000678E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292217, XrefRangeEnd = 292221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short System_IConvertible_ToInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00069724 File Offset: 0x00067924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292221, XrefRangeEnd = 292225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort System_IConvertible_ToUInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00069768 File Offset: 0x00067968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292225, XrefRangeEnd = 292229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IConvertible_ToInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x000697AC File Offset: 0x000679AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292229, XrefRangeEnd = 292233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint System_IConvertible_ToUInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x000697F0 File Offset: 0x000679F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292233, XrefRangeEnd = 292237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long System_IConvertible_ToInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00069834 File Offset: 0x00067A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292237, XrefRangeEnd = 292241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong System_IConvertible_ToUInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00069878 File Offset: 0x00067A78
		[CallerCount(0)]
		public unsafe float System_IConvertible_ToSingle(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x000698BC File Offset: 0x00067ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292241, XrefRangeEnd = 292245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double System_IConvertible_ToDouble(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00069900 File Offset: 0x00067B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292245, XrefRangeEnd = 292249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal System_IConvertible_ToDecimal(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00069944 File Offset: 0x00067B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292249, XrefRangeEnd = 292268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime System_IConvertible_ToDateTime(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00069988 File Offset: 0x00067B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292268, XrefRangeEnd = 292275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Single.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00005E79 File Offset: 0x00004079
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<float>.NativeClassPtr, ref this));
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x000699E0 File Offset: 0x00067BE0
		// (set) Token: 0x06000F94 RID: 3988 RVA: 0x00005E8B File Offset: 0x0000408B
		public unsafe static float MinValue
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Single.NativeFieldInfoPtr_MinValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Single.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x000699FC File Offset: 0x00067BFC
		// (set) Token: 0x06000F96 RID: 3990 RVA: 0x00005E99 File Offset: 0x00004099
		public unsafe static float Epsilon
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Single.NativeFieldInfoPtr_Epsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Single.NativeFieldInfoPtr_Epsilon, (void*)(&value));
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x00069A18 File Offset: 0x00067C18
		// (set) Token: 0x06000F98 RID: 3992 RVA: 0x00005EA7 File Offset: 0x000040A7
		public unsafe static float MaxValue
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Single.NativeFieldInfoPtr_MaxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Single.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x00069A34 File Offset: 0x00067C34
		// (set) Token: 0x06000F9A RID: 3994 RVA: 0x00005EB5 File Offset: 0x000040B5
		public unsafe static float PositiveInfinity
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Single.NativeFieldInfoPtr_PositiveInfinity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Single.NativeFieldInfoPtr_PositiveInfinity, (void*)(&value));
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000F9B RID: 3995 RVA: 0x00069A50 File Offset: 0x00067C50
		// (set) Token: 0x06000F9C RID: 3996 RVA: 0x00005EC3 File Offset: 0x000040C3
		public unsafe static float NegativeInfinity
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Single.NativeFieldInfoPtr_NegativeInfinity, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Single.NativeFieldInfoPtr_NegativeInfinity, (void*)(&value));
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x00069A6C File Offset: 0x00067C6C
		// (set) Token: 0x06000F9E RID: 3998 RVA: 0x00005ED1 File Offset: 0x000040D1
		public unsafe static float NaN
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Single.NativeFieldInfoPtr_NaN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Single.NativeFieldInfoPtr_NaN, (void*)(&value));
			}
		}

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeFieldInfoPtr_Epsilon;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeFieldInfoPtr_PositiveInfinity;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeFieldInfoPtr_NegativeInfinity;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeFieldInfoPtr_NaN;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr_IsInfinity_Public_Static_Boolean_Single_0;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeMethodInfoPtr_IsPositiveInfinity_Public_Static_Boolean_Single_0;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeMethodInfoPtr_IsNegativeInfinity_Public_Static_Boolean_Single_0;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeMethodInfoPtr_IsNaN_Public_Static_Boolean_Single_0;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Single_0;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Single_0;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Single_String_IFormatProvider_0;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Single_String_NumberStyles_IFormatProvider_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Private_Static_Single_String_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Single_0;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_NumberStyles_IFormatProvider_byref_Single_0;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Private_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Single_0;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0;

		// Token: 0x04000D43 RID: 3395
		[FieldOffset(0)]
		public float m_value;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem
{
	// Token: 0x020000C3 RID: 195
	[Serializable]
	[StructLayout(2)]
	public struct Int64
	{
		// Token: 0x06000D60 RID: 3424 RVA: 0x0005ED10 File Offset: 0x0005CF10
		// Note: this type is marked as 'beforefieldinit'.
		static Int64()
		{
			Il2CppClassPointerStore<long>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Int64");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<long>.NativeClassPtr);
			Int64.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<long>.NativeClassPtr, "m_value");
			Int64.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<long>.NativeClassPtr, "MaxValue");
			Int64.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<long>.NativeClassPtr, "MinValue");
			Int64.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665545);
			Int64.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665546);
			Int64.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665547);
			Int64.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665548);
			Int64.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665549);
			Int64.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665550);
			Int64.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665551);
			Int64.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665552);
			Int64.NativeMethodInfoPtr_Parse_Public_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665553);
			Int64.NativeMethodInfoPtr_Parse_Public_Static_Int64_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665554);
			Int64.NativeMethodInfoPtr_Parse_Public_Static_Int64_String_NumberStyles_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665555);
			Int64.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665556);
			Int64.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_NumberStyles_IFormatProvider_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665557);
			Int64.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665558);
			Int64.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665559);
			Int64.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665560);
			Int64.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665561);
			Int64.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665562);
			Int64.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665563);
			Int64.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665564);
			Int64.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665565);
			Int64.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665566);
			Int64.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665567);
			Int64.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665568);
			Int64.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665569);
			Int64.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665570);
			Int64.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665571);
			Int64.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665572);
			Int64.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<long>.NativeClassPtr, 100665573);
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x0005EFC0 File Offset: 0x0005D1C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286799, RefRangeEnd = 286800, XrefRangeStart = 286796, XrefRangeEnd = 286799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0005F004 File Offset: 0x0005D204
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286800, RefRangeEnd = 286801, XrefRangeStart = 286800, XrefRangeEnd = 286800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0005F044 File Offset: 0x0005D244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286801, XrefRangeEnd = 286804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0005F088 File Offset: 0x0005D288
		[CallerCount(0)]
		public unsafe bool Equals(long obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0005F0C8 File Offset: 0x0005D2C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286804, RefRangeEnd = 286805, XrefRangeStart = 286804, XrefRangeEnd = 286804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0005F0F8 File Offset: 0x0005D2F8
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 286807, RefRangeEnd = 286849, XrefRangeStart = 286805, XrefRangeEnd = 286807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0005F124 File Offset: 0x0005D324
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 286851, RefRangeEnd = 286854, XrefRangeStart = 286849, XrefRangeEnd = 286851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0005F160 File Offset: 0x0005D360
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 286856, RefRangeEnd = 286859, XrefRangeStart = 286854, XrefRangeEnd = 286856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0005F1B0 File Offset: 0x0005D3B0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 286861, RefRangeEnd = 286869, XrefRangeStart = 286859, XrefRangeEnd = 286861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Parse(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_Parse_Public_Static_Int64_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x0005F1F4 File Offset: 0x0005D3F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286871, RefRangeEnd = 286872, XrefRangeStart = 286869, XrefRangeEnd = 286871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Parse(string s, IFormatProvider provider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_Parse_Public_Static_Int64_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x0005F248 File Offset: 0x0005D448
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286875, RefRangeEnd = 286877, XrefRangeStart = 286872, XrefRangeEnd = 286875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long Parse(string s, NumberStyles style, IFormatProvider provider)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_Parse_Public_Static_Int64_String_NumberStyles_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x0005F2AC File Offset: 0x0005D4AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 286879, RefRangeEnd = 286883, XrefRangeStart = 286877, XrefRangeEnd = 286879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, out long result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x0005F2FC File Offset: 0x0005D4FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286886, RefRangeEnd = 286888, XrefRangeStart = 286883, XrefRangeEnd = 286886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out long result)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_NumberStyles_IFormatProvider_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0005F36C File Offset: 0x0005D56C
		[CallerCount(0)]
		public unsafe TypeCode GetTypeCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0005F39C File Offset: 0x0005D59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286888, XrefRangeEnd = 286892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_IConvertible_ToBoolean(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x0005F3E0 File Offset: 0x0005D5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286892, XrefRangeEnd = 286896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char System_IConvertible_ToChar(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0005F424 File Offset: 0x0005D624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286896, XrefRangeEnd = 286900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe sbyte System_IConvertible_ToSByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0005F468 File Offset: 0x0005D668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286900, XrefRangeEnd = 286904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte System_IConvertible_ToByte(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x0005F4AC File Offset: 0x0005D6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286904, XrefRangeEnd = 286908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short System_IConvertible_ToInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x0005F4F0 File Offset: 0x0005D6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286908, XrefRangeEnd = 286912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort System_IConvertible_ToUInt16(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0005F534 File Offset: 0x0005D734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286912, XrefRangeEnd = 286916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IConvertible_ToInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0005F578 File Offset: 0x0005D778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286916, XrefRangeEnd = 286920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint System_IConvertible_ToUInt32(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x0005F5BC File Offset: 0x0005D7BC
		[CallerCount(0)]
		public unsafe long System_IConvertible_ToInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x0005F600 File Offset: 0x0005D800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286920, XrefRangeEnd = 286924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong System_IConvertible_ToUInt64(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0005F644 File Offset: 0x0005D844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286924, XrefRangeEnd = 286928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float System_IConvertible_ToSingle(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0005F688 File Offset: 0x0005D888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286928, XrefRangeEnd = 286932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double System_IConvertible_ToDouble(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x0005F6CC File Offset: 0x0005D8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286932, XrefRangeEnd = 286936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal System_IConvertible_ToDecimal(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x0005F710 File Offset: 0x0005D910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286936, XrefRangeEnd = 286955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime System_IConvertible_ToDateTime(IFormatProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0005F754 File Offset: 0x0005D954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286955, XrefRangeEnd = 286962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int64.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x0000583C File Offset: 0x00003A3C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<long>.NativeClassPtr, ref this));
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x0005F7AC File Offset: 0x0005D9AC
		// (set) Token: 0x06000D80 RID: 3456 RVA: 0x0000584E File Offset: 0x00003A4E
		public unsafe static long MaxValue
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Int64.NativeFieldInfoPtr_MaxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Int64.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x0005F7C8 File Offset: 0x0005D9C8
		// (set) Token: 0x06000D82 RID: 3458 RVA: 0x0000585C File Offset: 0x00003A5C
		public unsafe static long MinValue
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Int64.NativeFieldInfoPtr_MinValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Int64.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Int64_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Int64_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Int64_String_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Int64_String_IFormatProvider_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Int64_String_NumberStyles_IFormatProvider_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Int64_0;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_NumberStyles_IFormatProvider_byref_Int64_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0;

		// Token: 0x04000B8C RID: 2956
		[FieldOffset(0)]
		public long m_value;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x020000D3 RID: 211
	public class Number : Object
	{
		// Token: 0x06000DFD RID: 3581 RVA: 0x00061838 File Offset: 0x0005FA38
		// Note: this type is marked as 'beforefieldinit'.
		static Number()
		{
			Il2CppClassPointerStore<Number>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Number");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Number>.NativeClassPtr);
			Number.NativeMethodInfoPtr_NumberBufferToDecimal_Public_Static_Boolean_ptr_Byte_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665649);
			Number.NativeMethodInfoPtr_NumberBufferToDouble_Internal_Static_Boolean_ptr_Byte_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665650);
			Number.NativeMethodInfoPtr_FormatDecimal_Public_Static_String_Decimal_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665651);
			Number.NativeMethodInfoPtr_FormatDouble_Public_Static_String_Double_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665652);
			Number.NativeMethodInfoPtr_FormatInt32_Public_Static_String_Int32_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665653);
			Number.NativeMethodInfoPtr_FormatUInt32_Public_Static_String_UInt32_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665654);
			Number.NativeMethodInfoPtr_FormatInt64_Public_Static_String_Int64_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665655);
			Number.NativeMethodInfoPtr_FormatUInt64_Public_Static_String_UInt64_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665656);
			Number.NativeMethodInfoPtr_FormatSingle_Public_Static_String_Single_String_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665657);
			Number.NativeMethodInfoPtr_HexNumberToInt32_Private_Static_Boolean_byref_NumberBuffer_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665658);
			Number.NativeMethodInfoPtr_HexNumberToInt64_Private_Static_Boolean_byref_NumberBuffer_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665659);
			Number.NativeMethodInfoPtr_HexNumberToUInt32_Private_Static_Boolean_byref_NumberBuffer_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665660);
			Number.NativeMethodInfoPtr_HexNumberToUInt64_Private_Static_Boolean_byref_NumberBuffer_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665661);
			Number.NativeMethodInfoPtr_IsWhite_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665662);
			Number.NativeMethodInfoPtr_NumberToInt32_Private_Static_Boolean_byref_NumberBuffer_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665663);
			Number.NativeMethodInfoPtr_NumberToInt64_Private_Static_Boolean_byref_NumberBuffer_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665664);
			Number.NativeMethodInfoPtr_NumberToUInt32_Private_Static_Boolean_byref_NumberBuffer_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665665);
			Number.NativeMethodInfoPtr_NumberToUInt64_Private_Static_Boolean_byref_NumberBuffer_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665666);
			Number.NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665667);
			Number.NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665668);
			Number.NativeMethodInfoPtr_ParseDecimal_Internal_Static_Decimal_String_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665669);
			Number.NativeMethodInfoPtr_ParseDouble_Internal_Static_Double_String_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665670);
			Number.NativeMethodInfoPtr_ParseInt32_Internal_Static_Int32_String_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665671);
			Number.NativeMethodInfoPtr_ParseInt64_Internal_Static_Int64_String_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665672);
			Number.NativeMethodInfoPtr_ParseNumber_Private_Static_Boolean_byref_ptr_Char_NumberStyles_byref_NumberBuffer_StringBuilder_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665673);
			Number.NativeMethodInfoPtr_ParseSingle_Internal_Static_Single_String_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665674);
			Number.NativeMethodInfoPtr_ParseUInt32_Internal_Static_UInt32_String_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665675);
			Number.NativeMethodInfoPtr_ParseUInt64_Internal_Static_UInt64_String_NumberStyles_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665676);
			Number.NativeMethodInfoPtr_StringToNumber_Private_Static_Void_String_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665677);
			Number.NativeMethodInfoPtr_TrailingZeros_Private_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665678);
			Number.NativeMethodInfoPtr_TryParseDecimal_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665679);
			Number.NativeMethodInfoPtr_TryParseDouble_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665680);
			Number.NativeMethodInfoPtr_TryParseInt32_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665681);
			Number.NativeMethodInfoPtr_TryParseInt64_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665682);
			Number.NativeMethodInfoPtr_TryParseSingle_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665683);
			Number.NativeMethodInfoPtr_TryParseUInt32_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665684);
			Number.NativeMethodInfoPtr_TryParseUInt64_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665685);
			Number.NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_String_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665686);
			Number.NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_String_NumberStyles_byref_NumberBuffer_StringBuilder_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100665687);
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00061B74 File Offset: 0x0005FD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289766, XrefRangeEnd = 289767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NumberBufferToDecimal(byte* number, ref Decimal value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberBufferToDecimal_Public_Static_Boolean_ptr_Byte_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00061BC0 File Offset: 0x0005FDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289767, XrefRangeEnd = 289768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NumberBufferToDouble(byte* number, ref double value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberBufferToDouble_Internal_Static_Boolean_ptr_Byte_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00061C0C File Offset: 0x0005FE0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 289780, RefRangeEnd = 289783, XrefRangeStart = 289768, XrefRangeEnd = 289780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatDecimal(Decimal value, string format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatDecimal_Public_Static_String_Decimal_String_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00061C68 File Offset: 0x0005FE68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 289787, RefRangeEnd = 289790, XrefRangeStart = 289783, XrefRangeEnd = 289787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatDouble(double value, string format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatDouble_Public_Static_String_Double_String_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00061CC4 File Offset: 0x0005FEC4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 289805, RefRangeEnd = 289821, XrefRangeStart = 289790, XrefRangeEnd = 289805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatInt32(int value, string format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatInt32_Public_Static_String_Int32_String_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00061D20 File Offset: 0x0005FF20
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 289836, RefRangeEnd = 289846, XrefRangeStart = 289821, XrefRangeEnd = 289836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatUInt32(uint value, string format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatUInt32_Public_Static_String_UInt32_String_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00061D7C File Offset: 0x0005FF7C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 289861, RefRangeEnd = 289867, XrefRangeStart = 289846, XrefRangeEnd = 289861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatInt64(long value, string format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatInt64_Public_Static_String_Int64_String_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00061DD8 File Offset: 0x0005FFD8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 289882, RefRangeEnd = 289887, XrefRangeStart = 289867, XrefRangeEnd = 289882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatUInt64(ulong value, string format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatUInt64_Public_Static_String_UInt64_String_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00061E34 File Offset: 0x00060034
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 289891, RefRangeEnd = 289895, XrefRangeStart = 289887, XrefRangeEnd = 289891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatSingle(float value, string format, NumberFormatInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_FormatSingle_Public_Static_String_Single_String_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00061E90 File Offset: 0x00060090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289895, XrefRangeEnd = 289897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HexNumberToInt32(ref Number.NumberBuffer number, ref int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_HexNumberToInt32_Private_Static_Boolean_byref_NumberBuffer_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00061EDC File Offset: 0x000600DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289897, XrefRangeEnd = 289898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HexNumberToInt64(ref Number.NumberBuffer number, ref long value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_HexNumberToInt64_Private_Static_Boolean_byref_NumberBuffer_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00061F28 File Offset: 0x00060128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289898, XrefRangeEnd = 289899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HexNumberToUInt32(ref Number.NumberBuffer number, ref uint value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_HexNumberToUInt32_Private_Static_Boolean_byref_NumberBuffer_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00061F74 File Offset: 0x00060174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289899, XrefRangeEnd = 289900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HexNumberToUInt64(ref Number.NumberBuffer number, ref ulong value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_HexNumberToUInt64_Private_Static_Boolean_byref_NumberBuffer_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00061FC0 File Offset: 0x000601C0
		[CallerCount(0)]
		public unsafe static bool IsWhite(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_IsWhite_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00062000 File Offset: 0x00060200
		[CallerCount(0)]
		public unsafe static bool NumberToInt32(ref Number.NumberBuffer number, ref int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberToInt32_Private_Static_Boolean_byref_NumberBuffer_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x0006204C File Offset: 0x0006024C
		[CallerCount(0)]
		public unsafe static bool NumberToInt64(ref Number.NumberBuffer number, ref long value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberToInt64_Private_Static_Boolean_byref_NumberBuffer_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00062098 File Offset: 0x00060298
		[CallerCount(0)]
		public unsafe static bool NumberToUInt32(ref Number.NumberBuffer number, ref uint value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberToUInt32_Private_Static_Boolean_byref_NumberBuffer_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x000620E4 File Offset: 0x000602E4
		[CallerCount(0)]
		public unsafe static bool NumberToUInt64(ref Number.NumberBuffer number, ref ulong value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_NumberToUInt64_Private_Static_Boolean_byref_NumberBuffer_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00062130 File Offset: 0x00060330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289901, RefRangeEnd = 289902, XrefRangeStart = 289900, XrefRangeEnd = 289901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char* MatchChars(char* p, string str)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = p;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00062174 File Offset: 0x00060374
		[CallerCount(0)]
		public unsafe static char* MatchChars(char* p, char* str)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = p;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = str;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x000621B4 File Offset: 0x000603B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289912, RefRangeEnd = 289914, XrefRangeStart = 289902, XrefRangeEnd = 289912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal ParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseDecimal_Internal_Static_Decimal_String_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00062218 File Offset: 0x00060418
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 289927, RefRangeEnd = 289931, XrefRangeStart = 289914, XrefRangeEnd = 289927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseDouble_Internal_Static_Double_String_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x0006227C File Offset: 0x0006047C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 289942, RefRangeEnd = 289950, XrefRangeStart = 289931, XrefRangeEnd = 289942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParseInt32(string s, NumberStyles style, NumberFormatInfo info)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseInt32_Internal_Static_Int32_String_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x000622E0 File Offset: 0x000604E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 289961, RefRangeEnd = 289965, XrefRangeStart = 289950, XrefRangeEnd = 289961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ParseInt64(string value, NumberStyles options, NumberFormatInfo numfmt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseInt64_Internal_Static_Int64_String_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00062344 File Offset: 0x00060544
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 290000, RefRangeEnd = 290012, XrefRangeStart = 289965, XrefRangeEnd = 290000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ParseNumber(ref char* str, NumberStyles options, ref Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(str);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parseDecimal;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseNumber_Private_Static_Boolean_byref_ptr_Char_NumberStyles_byref_NumberBuffer_StringBuilder_NumberFormatInfo_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			str = ((intPtr4 == 0) ? null : new char*(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000623EC File Offset: 0x000605EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290026, RefRangeEnd = 290029, XrefRangeStart = 290012, XrefRangeEnd = 290026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseSingle_Internal_Static_Single_String_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00062450 File Offset: 0x00060650
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 290039, RefRangeEnd = 290043, XrefRangeStart = 290029, XrefRangeEnd = 290039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ParseUInt32(string value, NumberStyles options, NumberFormatInfo numfmt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseUInt32_Internal_Static_UInt32_String_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x000624B4 File Offset: 0x000606B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290053, RefRangeEnd = 290056, XrefRangeStart = 290043, XrefRangeEnd = 290053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ParseUInt64(string value, NumberStyles options, NumberFormatInfo numfmt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_ParseUInt64_Internal_Static_UInt64_String_NumberStyles_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00062518 File Offset: 0x00060718
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 290060, RefRangeEnd = 290065, XrefRangeStart = 290056, XrefRangeEnd = 290060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parseDecimal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_StringToNumber_Private_Static_Void_String_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x0006258C File Offset: 0x0006078C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290065, XrefRangeEnd = 290067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrailingZeros(string s, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TrailingZeros_Private_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x000625DC File Offset: 0x000607DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290081, RefRangeEnd = 290082, XrefRangeStart = 290067, XrefRangeEnd = 290081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt, out Decimal result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseDecimal_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Decimal_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x0006264C File Offset: 0x0006084C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290096, RefRangeEnd = 290099, XrefRangeStart = 290082, XrefRangeEnd = 290096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt, out double result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseDouble_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x000626BC File Offset: 0x000608BC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 290114, RefRangeEnd = 290123, XrefRangeStart = 290099, XrefRangeEnd = 290114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseInt32(string s, NumberStyles style, NumberFormatInfo info, out int result)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseInt32_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x0006272C File Offset: 0x0006092C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 290134, RefRangeEnd = 290138, XrefRangeStart = 290123, XrefRangeEnd = 290134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseInt64(string s, NumberStyles style, NumberFormatInfo info, out long result)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseInt64_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x0006279C File Offset: 0x0006099C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290153, RefRangeEnd = 290154, XrefRangeStart = 290138, XrefRangeEnd = 290153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt, out float result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseSingle_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x0006280C File Offset: 0x00060A0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 290168, RefRangeEnd = 290171, XrefRangeStart = 290154, XrefRangeEnd = 290168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseUInt32(string s, NumberStyles style, NumberFormatInfo info, out uint result)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseUInt32_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x0006287C File Offset: 0x00060A7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290185, RefRangeEnd = 290186, XrefRangeStart = 290171, XrefRangeEnd = 290185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseUInt64(string s, NumberStyles style, NumberFormatInfo info, out ulong result)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryParseUInt64_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x000628EC File Offset: 0x00060AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290186, XrefRangeEnd = 290190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryStringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, NumberFormatInfo numfmt, bool parseDecimal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parseDecimal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_String_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x0006296C File Offset: 0x00060B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290190, XrefRangeEnd = 290195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryStringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &number;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(numfmt);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parseDecimal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_String_NumberStyles_byref_NumberBuffer_StringBuilder_NumberFormatInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x000059F0 File Offset: 0x00003BF0
		public Number(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeMethodInfoPtr_NumberBufferToDecimal_Public_Static_Boolean_ptr_Byte_byref_Decimal_0;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeMethodInfoPtr_NumberBufferToDouble_Internal_Static_Boolean_ptr_Byte_byref_Double_0;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeMethodInfoPtr_FormatDecimal_Public_Static_String_Decimal_String_NumberFormatInfo_0;

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeMethodInfoPtr_FormatDouble_Public_Static_String_Double_String_NumberFormatInfo_0;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeMethodInfoPtr_FormatInt32_Public_Static_String_Int32_String_NumberFormatInfo_0;

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeMethodInfoPtr_FormatUInt32_Public_Static_String_UInt32_String_NumberFormatInfo_0;

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeMethodInfoPtr_FormatInt64_Public_Static_String_Int64_String_NumberFormatInfo_0;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeMethodInfoPtr_FormatUInt64_Public_Static_String_UInt64_String_NumberFormatInfo_0;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeMethodInfoPtr_FormatSingle_Public_Static_String_Single_String_NumberFormatInfo_0;

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeMethodInfoPtr_HexNumberToInt32_Private_Static_Boolean_byref_NumberBuffer_byref_Int32_0;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeMethodInfoPtr_HexNumberToInt64_Private_Static_Boolean_byref_NumberBuffer_byref_Int64_0;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeMethodInfoPtr_HexNumberToUInt32_Private_Static_Boolean_byref_NumberBuffer_byref_UInt32_0;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeMethodInfoPtr_HexNumberToUInt64_Private_Static_Boolean_byref_NumberBuffer_byref_UInt64_0;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeMethodInfoPtr_IsWhite_Private_Static_Boolean_Char_0;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeMethodInfoPtr_NumberToInt32_Private_Static_Boolean_byref_NumberBuffer_byref_Int32_0;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeMethodInfoPtr_NumberToInt64_Private_Static_Boolean_byref_NumberBuffer_byref_Int64_0;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeMethodInfoPtr_NumberToUInt32_Private_Static_Boolean_byref_NumberBuffer_byref_UInt32_0;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeMethodInfoPtr_NumberToUInt64_Private_Static_Boolean_byref_NumberBuffer_byref_UInt64_0;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_String_0;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeMethodInfoPtr_MatchChars_Private_Static_ptr_Char_ptr_Char_ptr_Char_0;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr_ParseDecimal_Internal_Static_Decimal_String_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeMethodInfoPtr_ParseDouble_Internal_Static_Double_String_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr_ParseInt32_Internal_Static_Int32_String_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeMethodInfoPtr_ParseInt64_Internal_Static_Int64_String_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumber_Private_Static_Boolean_byref_ptr_Char_NumberStyles_byref_NumberBuffer_StringBuilder_NumberFormatInfo_Boolean_0;

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeMethodInfoPtr_ParseSingle_Internal_Static_Single_String_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeMethodInfoPtr_ParseUInt32_Internal_Static_UInt32_String_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeMethodInfoPtr_ParseUInt64_Internal_Static_UInt64_String_NumberStyles_NumberFormatInfo_0;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeMethodInfoPtr_StringToNumber_Private_Static_Void_String_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeMethodInfoPtr_TrailingZeros_Private_Static_Boolean_String_Int32_0;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeMethodInfoPtr_TryParseDecimal_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Decimal_0;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeMethodInfoPtr_TryParseDouble_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Double_0;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeMethodInfoPtr_TryParseInt32_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Int32_0;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeMethodInfoPtr_TryParseInt64_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Int64_0;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr_TryParseSingle_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_Single_0;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeMethodInfoPtr_TryParseUInt32_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_UInt32_0;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeMethodInfoPtr_TryParseUInt64_Internal_Static_Boolean_String_NumberStyles_NumberFormatInfo_byref_UInt64_0;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_String_NumberStyles_byref_NumberBuffer_NumberFormatInfo_Boolean_0;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeMethodInfoPtr_TryStringToNumber_Internal_Static_Boolean_String_NumberStyles_byref_NumberBuffer_StringBuilder_NumberFormatInfo_Boolean_0;

		// Token: 0x0200059B RID: 1435
		[StructLayout(2)]
		public struct NumberBuffer
		{
			// Token: 0x06004F24 RID: 20260 RVA: 0x001642B0 File Offset: 0x001624B0
			// Note: this type is marked as 'beforefieldinit'.
			static NumberBuffer()
			{
				Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Number>.NativeClassPtr, "NumberBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr);
				Number.NumberBuffer.NativeFieldInfoPtr_NumberBufferBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, "NumberBufferBytes");
				Number.NumberBuffer.NativeFieldInfoPtr_baseAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, "baseAddress");
				Number.NumberBuffer.NativeFieldInfoPtr_digits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, "digits");
				Number.NumberBuffer.NativeFieldInfoPtr_precision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, "precision");
				Number.NumberBuffer.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, "scale");
				Number.NumberBuffer.NativeFieldInfoPtr_sign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, "sign");
				Number.NumberBuffer.NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, 100665688);
				Number.NumberBuffer.NativeMethodInfoPtr_PackForNative_Public_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, 100665689);
			}

			// Token: 0x06004F25 RID: 20261 RVA: 0x0016437C File Offset: 0x0016257C
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 289746, RefRangeEnd = 289760, XrefRangeStart = 289746, XrefRangeEnd = 289746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NumberBuffer(byte* stackBuffer)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = stackBuffer;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NumberBuffer.NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F26 RID: 20262 RVA: 0x001643B0 File Offset: 0x001625B0
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 289760, RefRangeEnd = 289766, XrefRangeStart = 289760, XrefRangeEnd = 289760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe byte* PackForNative()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Number.NumberBuffer.NativeMethodInfoPtr_PackForNative_Public_ptr_Byte_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}

			// Token: 0x06004F27 RID: 20263 RVA: 0x0001DFA3 File Offset: 0x0001C1A3
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Number.NumberBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x1700141B RID: 5147
			// (get) Token: 0x06004F28 RID: 20264 RVA: 0x001643D8 File Offset: 0x001625D8
			// (set) Token: 0x06004F29 RID: 20265 RVA: 0x0001DFB5 File Offset: 0x0001C1B5
			public unsafe static int NumberBufferBytes
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(Number.NumberBuffer.NativeFieldInfoPtr_NumberBufferBytes, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Number.NumberBuffer.NativeFieldInfoPtr_NumberBufferBytes, (void*)(&value));
				}
			}

			// Token: 0x0400402F RID: 16431
			private static readonly IntPtr NativeFieldInfoPtr_NumberBufferBytes;

			// Token: 0x04004030 RID: 16432
			private static readonly IntPtr NativeFieldInfoPtr_baseAddress;

			// Token: 0x04004031 RID: 16433
			private static readonly IntPtr NativeFieldInfoPtr_digits;

			// Token: 0x04004032 RID: 16434
			private static readonly IntPtr NativeFieldInfoPtr_precision;

			// Token: 0x04004033 RID: 16435
			private static readonly IntPtr NativeFieldInfoPtr_scale;

			// Token: 0x04004034 RID: 16436
			private static readonly IntPtr NativeFieldInfoPtr_sign;

			// Token: 0x04004035 RID: 16437
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Byte_0;

			// Token: 0x04004036 RID: 16438
			private static readonly IntPtr NativeMethodInfoPtr_PackForNative_Public_ptr_Byte_0;

			// Token: 0x04004037 RID: 16439
			[FieldOffset(0)]
			public IntPtr baseAddress;

			// Token: 0x04004038 RID: 16440
			[FieldOffset(8)]
			public IntPtr digits;

			// Token: 0x04004039 RID: 16441
			[FieldOffset(16)]
			public int precision;

			// Token: 0x0400403A RID: 16442
			[FieldOffset(20)]
			public int scale;

			// Token: 0x0400403B RID: 16443
			[FieldOffset(24)]
			[MarshalAs(4)]
			public bool sign;
		}
	}
}

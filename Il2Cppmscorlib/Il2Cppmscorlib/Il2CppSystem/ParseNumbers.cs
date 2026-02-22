using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000107 RID: 263
	public static class ParseNumbers : Object
	{
		// Token: 0x06001393 RID: 5011 RVA: 0x0007C6F0 File Offset: 0x0007A8F0
		// Note: this type is marked as 'beforefieldinit'.
		static ParseNumbers()
		{
			Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ParseNumbers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr);
			ParseNumbers.NativeMethodInfoPtr_StringToInt_Public_Static_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100666692);
			ParseNumbers.NativeMethodInfoPtr_StringToInt_Public_Static_Int32_String_Int32_Int32_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100666693);
			ParseNumbers.NativeMethodInfoPtr_StringToLong_Public_Static_Int64_String_Int32_Int32_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100666694);
			ParseNumbers.NativeMethodInfoPtr_IntToString_Public_Static_String_Int32_Int32_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100666695);
			ParseNumbers.NativeMethodInfoPtr_EndianSwap_Private_Static_Void_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100666696);
			ParseNumbers.NativeMethodInfoPtr_ConvertToBase2_Private_Static_StringBuilder_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100666697);
			ParseNumbers.NativeMethodInfoPtr_ConvertToBase8_Private_Static_StringBuilder_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100666698);
			ParseNumbers.NativeMethodInfoPtr_ConvertToBase16_Private_Static_StringBuilder_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseNumbers>.NativeClassPtr, 100666699);
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x0007C7C0 File Offset: 0x0007A9C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304406, RefRangeEnd = 304407, XrefRangeStart = 304405, XrefRangeEnd = 304406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int StringToInt(string value, int fromBase, int flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromBase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_StringToInt_Public_Static_Int32_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x0007C820 File Offset: 0x0007AA20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 304426, RefRangeEnd = 304428, XrefRangeStart = 304407, XrefRangeEnd = 304426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int StringToInt(string value, int fromBase, int flags, int* parsePos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromBase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = parsePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_StringToInt_Public_Static_Int32_String_Int32_Int32_ptr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x0007C88C File Offset: 0x0007AA8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304449, RefRangeEnd = 304450, XrefRangeStart = 304428, XrefRangeEnd = 304449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long StringToLong(string value, int fromBase, int flags, int* parsePos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromBase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = parsePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_StringToLong_Public_Static_Int64_String_Int32_Int32_ptr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x0007C8F8 File Offset: 0x0007AAF8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 304491, RefRangeEnd = 304497, XrefRangeStart = 304450, XrefRangeEnd = 304491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IntToString(int value, int toBase, int width, char paddingChar, int flags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toBase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingChar;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_IntToString_Public_Static_String_Int32_Int32_Int32_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x0007C968 File Offset: 0x0007AB68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 304501, RefRangeEnd = 304504, XrefRangeStart = 304497, XrefRangeEnd = 304501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndianSwap(ref Il2CppStructArray<byte> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_EndianSwap_Private_Static_Void_byref_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			}
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x0007C9B4 File Offset: 0x0007ABB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304504, XrefRangeEnd = 304516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder ConvertToBase2(Il2CppStructArray<byte> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_ConvertToBase2_Private_Static_StringBuilder_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x0007C9F8 File Offset: 0x0007ABF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304535, RefRangeEnd = 304536, XrefRangeStart = 304516, XrefRangeEnd = 304535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder ConvertToBase8(Il2CppStructArray<byte> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_ConvertToBase8_Private_Static_StringBuilder_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x0007CA3C File Offset: 0x0007AC3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304549, RefRangeEnd = 304550, XrefRangeStart = 304536, XrefRangeEnd = 304549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder ConvertToBase16(Il2CppStructArray<byte> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseNumbers.NativeMethodInfoPtr_ConvertToBase16_Private_Static_StringBuilder_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x00006BB0 File Offset: 0x00004DB0
		public ParseNumbers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr_StringToInt_Public_Static_Int32_String_Int32_Int32_0;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_StringToInt_Public_Static_Int32_String_Int32_Int32_ptr_Int32_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr_StringToLong_Public_Static_Int64_String_Int32_Int32_ptr_Int32_0;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeMethodInfoPtr_IntToString_Public_Static_String_Int32_Int32_Int32_Char_Int32_0;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_EndianSwap_Private_Static_Void_byref_Il2CppStructArray_1_Byte_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToBase2_Private_Static_StringBuilder_Il2CppStructArray_1_Byte_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToBase8_Private_Static_StringBuilder_Il2CppStructArray_1_Byte_0;

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToBase16_Private_Static_StringBuilder_Il2CppStructArray_1_Byte_0;
	}
}

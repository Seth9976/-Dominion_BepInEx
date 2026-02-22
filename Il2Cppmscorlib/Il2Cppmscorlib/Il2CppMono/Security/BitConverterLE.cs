using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security
{
	// Token: 0x02000020 RID: 32
	public sealed class BitConverterLE : Object
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x000298E8 File Offset: 0x00027AE8
		// Note: this type is marked as 'beforefieldinit'.
		static BitConverterLE()
		{
			Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security", "BitConverterLE");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr);
			BitConverterLE.NativeMethodInfoPtr_GetUIntBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663529);
			BitConverterLE.NativeMethodInfoPtr_GetULongBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663530);
			BitConverterLE.NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663531);
			BitConverterLE.NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663532);
			BitConverterLE.NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663533);
			BitConverterLE.NativeMethodInfoPtr_UIntFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663534);
			BitConverterLE.NativeMethodInfoPtr_ULongFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663535);
			BitConverterLE.NativeMethodInfoPtr_ToSingle_Internal_Static_Single_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663536);
			BitConverterLE.NativeMethodInfoPtr_ToDouble_Internal_Static_Double_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663537);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000299CC File Offset: 0x00027BCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 260442, RefRangeEnd = 260445, XrefRangeStart = 260433, XrefRangeEnd = 260442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetUIntBytes(byte* bytes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_GetUIntBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00029A0C File Offset: 0x00027C0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 260454, RefRangeEnd = 260456, XrefRangeStart = 260445, XrefRangeEnd = 260454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetULongBytes(byte* bytes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_GetULongBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00029A4C File Offset: 0x00027C4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260457, RefRangeEnd = 260458, XrefRangeStart = 260456, XrefRangeEnd = 260457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00029A8C File Offset: 0x00027C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260458, XrefRangeEnd = 260459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00029ACC File Offset: 0x00027CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260459, XrefRangeEnd = 260460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetBytes(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00029B0C File Offset: 0x00027D0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 260464, RefRangeEnd = 260466, XrefRangeStart = 260460, XrefRangeEnd = 260464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UIntFromBytes(byte* dst, Il2CppStructArray<byte> src, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dst;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_UIntFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00029B60 File Offset: 0x00027D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260466, XrefRangeEnd = 260470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ULongFromBytes(byte* dst, Il2CppStructArray<byte> src, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dst;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_ULongFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00029BB4 File Offset: 0x00027DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260470, XrefRangeEnd = 260471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ToSingle(Il2CppStructArray<byte> value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_ToSingle_Internal_Static_Single_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00029C04 File Offset: 0x00027E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260471, XrefRangeEnd = 260475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToDouble(Il2CppStructArray<byte> value, int startIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitConverterLE.NativeMethodInfoPtr_ToDouble_Internal_Static_Double_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002BD6 File Offset: 0x00000DD6
		public BitConverterLE(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_GetUIntBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_GetULongBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Single_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Double_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_UIntFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_ULongFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_ToSingle_Internal_Static_Single_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_ToDouble_Internal_Static_Double_Il2CppStructArray_1_Byte_Int32_0;
	}
}

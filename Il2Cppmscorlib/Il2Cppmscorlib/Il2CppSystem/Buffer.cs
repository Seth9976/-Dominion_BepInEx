using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem
{
	// Token: 0x02000082 RID: 130
	public static class Buffer : Object
	{
		// Token: 0x060007C8 RID: 1992 RVA: 0x00044F2C File Offset: 0x0004312C
		// Note: this type is marked as 'beforefieldinit'.
		static Buffer()
		{
			Il2CppClassPointerStore<Buffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Buffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Buffer>.NativeClassPtr);
			Buffer.NativeMethodInfoPtr_InternalBlockCopy_Internal_Static_Boolean_Array_Int32_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100664520);
			Buffer.NativeMethodInfoPtr_IndexOfByte_Internal_Static_Int32_ptr_Byte_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100664521);
			Buffer.NativeMethodInfoPtr__ByteLength_Private_Static_Int32_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100664522);
			Buffer.NativeMethodInfoPtr_ZeroMemory_Internal_Static_Void_ptr_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100664523);
			Buffer.NativeMethodInfoPtr_Memcpy_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_ptr_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100664524);
			Buffer.NativeMethodInfoPtr_Memcpy_Internal_Static_Void_ptr_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100664525);
			Buffer.NativeMethodInfoPtr_ByteLength_Public_Static_Int32_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100664526);
			Buffer.NativeMethodInfoPtr_BlockCopy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100664527);
			Buffer.NativeMethodInfoPtr_memcpy4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100664528);
			Buffer.NativeMethodInfoPtr_memcpy2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100664529);
			Buffer.NativeMethodInfoPtr_memcpy1_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100664530);
			Buffer.NativeMethodInfoPtr_Memcpy_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100664531);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0004504C File Offset: 0x0004324C
		[CallerCount(64)]
		[CachedScanResults(RefRangeStart = 276850, RefRangeEnd = 276914, XrefRangeStart = 276849, XrefRangeEnd = 276850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcOffsetBytes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstOffsetBytes;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_InternalBlockCopy_Internal_Static_Boolean_Array_Int32_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x000450CC File Offset: 0x000432CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276914, XrefRangeEnd = 276915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IndexOfByte(byte* src, byte value, int index, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = src;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_IndexOfByte_Internal_Static_Int32_ptr_Byte_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00045134 File Offset: 0x00043334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276915, XrefRangeEnd = 276916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _ByteLength(Array array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr__ByteLength_Private_Static_Int32_Array_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00045178 File Offset: 0x00043378
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276916, RefRangeEnd = 276918, XrefRangeStart = 276916, XrefRangeEnd = 276916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ZeroMemory(byte* src, long len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = src;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_ZeroMemory_Internal_Static_Void_ptr_Byte_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x000451B8 File Offset: 0x000433B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276920, RefRangeEnd = 276922, XrefRangeStart = 276918, XrefRangeEnd = 276920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Memcpy(Il2CppStructArray<byte> dest, int destIndex, byte* src, int srcIndex, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_Memcpy_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_ptr_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00045228 File Offset: 0x00043428
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 276924, RefRangeEnd = 276928, XrefRangeStart = 276922, XrefRangeEnd = 276924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Memcpy(byte* pDest, int destIndex, Il2CppStructArray<byte> src, int srcIndex, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pDest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_Memcpy_Internal_Static_Void_ptr_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00045298 File Offset: 0x00043498
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 276929, RefRangeEnd = 276933, XrefRangeStart = 276928, XrefRangeEnd = 276929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ByteLength(Array array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_ByteLength_Public_Static_Int32_Array_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x000452DC File Offset: 0x000434DC
		[CallerCount(153)]
		[CachedScanResults(RefRangeStart = 276936, RefRangeEnd = 277089, XrefRangeStart = 276933, XrefRangeEnd = 276936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_BlockCopy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00045350 File Offset: 0x00043550
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 277089, RefRangeEnd = 277095, XrefRangeStart = 277089, XrefRangeEnd = 277089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void memcpy4(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_memcpy4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0004539C File Offset: 0x0004359C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 277095, RefRangeEnd = 277101, XrefRangeStart = 277095, XrefRangeEnd = 277095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void memcpy2(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_memcpy2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x000453E8 File Offset: 0x000435E8
		[CallerCount(0)]
		public unsafe static void memcpy1(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_memcpy1_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00045434 File Offset: 0x00043634
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 277101, RefRangeEnd = 277144, XrefRangeStart = 277101, XrefRangeEnd = 277101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Memcpy(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Buffer.NativeMethodInfoPtr_Memcpy_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x000046FA File Offset: 0x000028FA
		public Buffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_InternalBlockCopy_Internal_Static_Boolean_Array_Int32_Array_Int32_Int32_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfByte_Internal_Static_Int32_ptr_Byte_Byte_Int32_Int32_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr__ByteLength_Private_Static_Int32_Array_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr_ZeroMemory_Internal_Static_Void_ptr_Byte_Int64_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_Memcpy_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_ptr_Byte_Int32_Int32_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_Memcpy_Internal_Static_Void_ptr_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_ByteLength_Public_Static_Int32_Array_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_BlockCopy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_memcpy4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_memcpy2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_memcpy1_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr_Memcpy_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;
	}
}

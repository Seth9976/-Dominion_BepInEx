using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000009 RID: 9
	public class BinHexDecoder : IncrementalReadDecoder
	{
		// Token: 0x06000073 RID: 115 RVA: 0x0000A380 File Offset: 0x00008580
		// Note: this type is marked as 'beforefieldinit'.
		static BinHexDecoder()
		{
			Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "BinHexDecoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr);
			BinHexDecoder.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, "buffer");
			BinHexDecoder.NativeFieldInfoPtr_curIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, "curIndex");
			BinHexDecoder.NativeFieldInfoPtr_endIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, "endIndex");
			BinHexDecoder.NativeFieldInfoPtr_hasHalfByteCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, "hasHalfByteCached");
			BinHexDecoder.NativeFieldInfoPtr_cachedHalfByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, "cachedHalfByte");
			BinHexDecoder.NativeMethodInfoPtr_get_IsFull_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, 100663347);
			BinHexDecoder.NativeMethodInfoPtr_Decode_Internal_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, 100663348);
			BinHexDecoder.NativeMethodInfoPtr_Decode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, 100663349);
			BinHexDecoder.NativeMethodInfoPtr_Decode_Private_Static_Void_ptr_Char_ptr_Char_ptr_Byte_ptr_Byte_byref_Boolean_byref_Byte_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinHexDecoder>.NativeClassPtr, 100663350);
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000A464 File Offset: 0x00008664
		public unsafe override bool IsFull
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinHexDecoder.NativeMethodInfoPtr_get_IsFull_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000A4AC File Offset: 0x000086AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11689, XrefRangeEnd = 11690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Decode(Il2CppStructArray<char> chars, int startPos, int len)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinHexDecoder.NativeMethodInfoPtr_Decode_Internal_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000A520 File Offset: 0x00008720
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11697, RefRangeEnd = 11698, XrefRangeStart = 11690, XrefRangeEnd = 11697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> Decode(Il2CppStructArray<char> chars, bool allowOddChars)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowOddChars;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinHexDecoder.NativeMethodInfoPtr_Decode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000A574 File Offset: 0x00008774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 11703, RefRangeEnd = 11705, XrefRangeStart = 11698, XrefRangeEnd = 11703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pChars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pCharsEndPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pBytes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pBytesEndPos;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hasHalfByteCached;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cachedHalfByte;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsDecoded;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bytesDecoded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinHexDecoder.NativeMethodInfoPtr_Decode_Private_Static_Void_ptr_Char_ptr_Char_ptr_Byte_ptr_Byte_byref_Boolean_byref_Byte_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002371 File Offset: 0x00000571
		public BinHexDecoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000A608 File Offset: 0x00008808
		// (set) Token: 0x0600007A RID: 122 RVA: 0x0000237A File Offset: 0x0000057A
		public unsafe Il2CppStructArray<byte> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000A638 File Offset: 0x00008838
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002399 File Offset: 0x00000599
		public unsafe int curIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_curIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_curIndex)) = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000A660 File Offset: 0x00008860
		// (set) Token: 0x0600007E RID: 126 RVA: 0x000023B4 File Offset: 0x000005B4
		public unsafe int endIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_endIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_endIndex)) = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000A688 File Offset: 0x00008888
		// (set) Token: 0x06000080 RID: 128 RVA: 0x000023CF File Offset: 0x000005CF
		public unsafe bool hasHalfByteCached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_hasHalfByteCached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_hasHalfByteCached)) = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000A6B0 File Offset: 0x000088B0
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000023EA File Offset: 0x000005EA
		public unsafe byte cachedHalfByte
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_cachedHalfByte);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinHexDecoder.NativeFieldInfoPtr_cachedHalfByte)) = value;
			}
		}

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_curIndex;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_endIndex;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_hasHalfByteCached;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_cachedHalfByte;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFull_Internal_Virtual_get_Boolean_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Internal_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Boolean_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Static_Void_ptr_Char_ptr_Char_ptr_Byte_ptr_Byte_byref_Boolean_byref_Byte_byref_Int32_byref_Int32_0;
	}
}

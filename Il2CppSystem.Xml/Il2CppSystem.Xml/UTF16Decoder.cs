using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000055 RID: 85
	public class UTF16Decoder : Decoder
	{
		// Token: 0x06000769 RID: 1897 RVA: 0x00028CD4 File Offset: 0x00026ED4
		// Note: this type is marked as 'beforefieldinit'.
		static UTF16Decoder()
		{
			Il2CppClassPointerStore<UTF16Decoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "UTF16Decoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UTF16Decoder>.NativeClassPtr);
			UTF16Decoder.NativeFieldInfoPtr_bigEndian = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF16Decoder>.NativeClassPtr, "bigEndian");
			UTF16Decoder.NativeFieldInfoPtr_lastByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF16Decoder>.NativeClassPtr, "lastByte");
			UTF16Decoder.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF16Decoder>.NativeClassPtr, 100664525);
			UTF16Decoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF16Decoder>.NativeClassPtr, 100664526);
			UTF16Decoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF16Decoder>.NativeClassPtr, 100664527);
			UTF16Decoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF16Decoder>.NativeClassPtr, 100664528);
			UTF16Decoder.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_byref_Int32_byref_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF16Decoder>.NativeClassPtr, 100664529);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00028D90 File Offset: 0x00026F90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 20495, RefRangeEnd = 20498, XrefRangeStart = 20494, XrefRangeEnd = 20495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UTF16Decoder(bool bigEndian)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF16Decoder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bigEndian;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF16Decoder.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00028DD8 File Offset: 0x00026FD8
		[CallerCount(0)]
		public unsafe override int GetCharCount(Il2CppStructArray<byte> bytes, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF16Decoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00028E4C File Offset: 0x0002704C
		[CallerCount(0)]
		public unsafe override int GetCharCount(Il2CppStructArray<byte> bytes, int index, int count, bool flush)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF16Decoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00028ED0 File Offset: 0x000270D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20498, XrefRangeEnd = 20504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetChars(Il2CppStructArray<byte> bytes, int byteIndex, int byteCount, Il2CppStructArray<char> chars, int charIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chars);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF16Decoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00028F68 File Offset: 0x00027168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20504, XrefRangeEnd = 20507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Convert(Il2CppStructArray<byte> bytes, int byteIndex, int byteCount, Il2CppStructArray<char> chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chars);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bytesUsed;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsUsed;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &completed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF16Decoder.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_byref_Int32_byref_Int32_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0000462B File Offset: 0x0000282B
		public UTF16Decoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00029040 File Offset: 0x00027240
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x00004634 File Offset: 0x00002834
		public unsafe bool bigEndian
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF16Decoder.NativeFieldInfoPtr_bigEndian);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF16Decoder.NativeFieldInfoPtr_bigEndian)) = value;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x00029068 File Offset: 0x00027268
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x0000464F File Offset: 0x0000284F
		public unsafe int lastByte
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF16Decoder.NativeFieldInfoPtr_lastByte);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF16Decoder.NativeFieldInfoPtr_lastByte)) = value;
			}
		}

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeFieldInfoPtr_bigEndian;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeFieldInfoPtr_lastByte;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_byref_Int32_byref_Int32_byref_Boolean_0;
	}
}

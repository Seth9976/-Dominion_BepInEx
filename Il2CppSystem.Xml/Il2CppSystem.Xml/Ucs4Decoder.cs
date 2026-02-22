using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200005C RID: 92
	public class Ucs4Decoder : Decoder
	{
		// Token: 0x060007A2 RID: 1954 RVA: 0x00029F10 File Offset: 0x00028110
		// Note: this type is marked as 'beforefieldinit'.
		static Ucs4Decoder()
		{
			Il2CppClassPointerStore<Ucs4Decoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Ucs4Decoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ucs4Decoder>.NativeClassPtr);
			Ucs4Decoder.NativeFieldInfoPtr_lastBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ucs4Decoder>.NativeClassPtr, "lastBytes");
			Ucs4Decoder.NativeFieldInfoPtr_lastBytesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ucs4Decoder>.NativeClassPtr, "lastBytesCount");
			Ucs4Decoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Decoder>.NativeClassPtr, 100664562);
			Ucs4Decoder.NativeMethodInfoPtr_GetFullChars_Internal_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Decoder>.NativeClassPtr, 100664563);
			Ucs4Decoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Decoder>.NativeClassPtr, 100664564);
			Ucs4Decoder.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_byref_Int32_byref_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Decoder>.NativeClassPtr, 100664565);
			Ucs4Decoder.NativeMethodInfoPtr_Ucs4ToUTF16_Internal_Void_UInt32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Decoder>.NativeClassPtr, 100664566);
			Ucs4Decoder.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Decoder>.NativeClassPtr, 100664567);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00029FE0 File Offset: 0x000281E0
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Decoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0002A054 File Offset: 0x00028254
		[CallerCount(0)]
		public unsafe virtual int GetFullChars(Il2CppStructArray<byte> bytes, int byteIndex, int byteCount, Il2CppStructArray<char> chars, int charIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Decoder.NativeMethodInfoPtr_GetFullChars_Internal_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0002A0EC File Offset: 0x000282EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20609, XrefRangeEnd = 20610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Decoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0002A184 File Offset: 0x00028384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20610, XrefRangeEnd = 20613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Decoder.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_byref_Int32_byref_Int32_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0002A25C File Offset: 0x0002845C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 20613, RefRangeEnd = 20617, XrefRangeStart = 20613, XrefRangeEnd = 20613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Ucs4ToUTF16(uint code, Il2CppStructArray<char> chars, int charIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chars);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ucs4Decoder.NativeMethodInfoPtr_Ucs4ToUTF16_Internal_Void_UInt32_Il2CppStructArray_1_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0002A2BC File Offset: 0x000284BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20617, XrefRangeEnd = 20621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ucs4Decoder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ucs4Decoder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ucs4Decoder.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x000046BF File Offset: 0x000028BF
		public Ucs4Decoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x0002A2F8 File Offset: 0x000284F8
		// (set) Token: 0x060007AB RID: 1963 RVA: 0x000046C8 File Offset: 0x000028C8
		public unsafe Il2CppStructArray<byte> lastBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ucs4Decoder.NativeFieldInfoPtr_lastBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ucs4Decoder.NativeFieldInfoPtr_lastBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x0002A328 File Offset: 0x00028528
		// (set) Token: 0x060007AD RID: 1965 RVA: 0x000046E7 File Offset: 0x000028E7
		public unsafe int lastBytesCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ucs4Decoder.NativeFieldInfoPtr_lastBytesCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ucs4Decoder.NativeFieldInfoPtr_lastBytesCount)) = value;
			}
		}

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeFieldInfoPtr_lastBytes;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeFieldInfoPtr_lastBytesCount;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_GetFullChars_Internal_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_byref_Int32_byref_Int32_byref_Boolean_0;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr_Ucs4ToUTF16_Internal_Void_UInt32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

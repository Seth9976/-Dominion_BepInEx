using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000173 RID: 371
	[Serializable]
	public sealed class UTF32Encoding : Encoding
	{
		// Token: 0x060019A2 RID: 6562 RVA: 0x00095C58 File Offset: 0x00093E58
		// Note: this type is marked as 'beforefieldinit'.
		static UTF32Encoding()
		{
			Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "UTF32Encoding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr);
			UTF32Encoding.NativeFieldInfoPtr_emitUTF32ByteOrderMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, "emitUTF32ByteOrderMark");
			UTF32Encoding.NativeFieldInfoPtr_isThrowException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, "isThrowException");
			UTF32Encoding.NativeFieldInfoPtr_bigEndian = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, "bigEndian");
			UTF32Encoding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667592);
			UTF32Encoding.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667593);
			UTF32Encoding.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667594);
			UTF32Encoding.NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667595);
			UTF32Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667596);
			UTF32Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667597);
			UTF32Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667598);
			UTF32Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667599);
			UTF32Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667600);
			UTF32Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667601);
			UTF32Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667602);
			UTF32Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667603);
			UTF32Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667604);
			UTF32Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667605);
			UTF32Encoding.NativeMethodInfoPtr_GetString_Public_Virtual_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667606);
			UTF32Encoding.NativeMethodInfoPtr_GetByteCount_Internal_Virtual_Int32_ptr_Char_Int32_EncoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667607);
			UTF32Encoding.NativeMethodInfoPtr_GetBytes_Internal_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667608);
			UTF32Encoding.NativeMethodInfoPtr_GetCharCount_Internal_Virtual_Int32_ptr_Byte_Int32_DecoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667609);
			UTF32Encoding.NativeMethodInfoPtr_GetChars_Internal_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667610);
			UTF32Encoding.NativeMethodInfoPtr_GetSurrogate_Private_UInt32_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667611);
			UTF32Encoding.NativeMethodInfoPtr_GetHighSurrogate_Private_Char_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667612);
			UTF32Encoding.NativeMethodInfoPtr_GetLowSurrogate_Private_Char_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667613);
			UTF32Encoding.NativeMethodInfoPtr_GetDecoder_Public_Virtual_Decoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667614);
			UTF32Encoding.NativeMethodInfoPtr_GetEncoder_Public_Virtual_Encoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667615);
			UTF32Encoding.NativeMethodInfoPtr_GetMaxByteCount_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667616);
			UTF32Encoding.NativeMethodInfoPtr_GetMaxCharCount_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667617);
			UTF32Encoding.NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667618);
			UTF32Encoding.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667619);
			UTF32Encoding.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, 100667620);
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x00095F08 File Offset: 0x00094108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314164, XrefRangeEnd = 314165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UTF32Encoding()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x00095F44 File Offset: 0x00094144
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 314166, RefRangeEnd = 314169, XrefRangeStart = 314165, XrefRangeEnd = 314166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UTF32Encoding(bool bigEndian, bool byteOrderMark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bigEndian;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteOrderMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x00095F9C File Offset: 0x0009419C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314169, XrefRangeEnd = 314170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UTF32Encoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bigEndian;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteOrderMark;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnInvalidCharacters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x00096000 File Offset: 0x00094200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314170, XrefRangeEnd = 314181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetDefaultFallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x00096034 File Offset: 0x00094234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314181, XrefRangeEnd = 314183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetByteCount(Il2CppStructArray<char> chars, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x000960A0 File Offset: 0x000942A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314183, XrefRangeEnd = 314184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetByteCount(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x000960F0 File Offset: 0x000942F0
		[CallerCount(0)]
		public unsafe override int GetByteCount(char* chars, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = chars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x00096148 File Offset: 0x00094348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314184, XrefRangeEnd = 314222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetBytes(string s, int charIndex, int charCount, Il2CppStructArray<byte> bytes, int byteIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x000961D4 File Offset: 0x000943D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314222, XrefRangeEnd = 314228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetBytes(Il2CppStructArray<char> chars, int charIndex, int charCount, Il2CppStructArray<byte> bytes, int byteIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x00096260 File Offset: 0x00094460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314228, XrefRangeEnd = 314229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = chars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bytes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x000962D4 File Offset: 0x000944D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314229, XrefRangeEnd = 314231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x00096340 File Offset: 0x00094540
		[CallerCount(0)]
		public unsafe override int GetCharCount(byte* bytes, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00096398 File Offset: 0x00094598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314231, XrefRangeEnd = 314237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00096424 File Offset: 0x00094624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314237, XrefRangeEnd = 314238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = chars;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x00096498 File Offset: 0x00094698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314238, XrefRangeEnd = 314241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetString(Il2CppStructArray<byte> bytes, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetString_Public_Virtual_String_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x000964FC File Offset: 0x000946FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314241, XrefRangeEnd = 314260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetByteCount(char* chars, int count, EncoderNLS encoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = chars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetByteCount_Internal_Virtual_Int32_ptr_Char_Int32_EncoderNLS_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x00096564 File Offset: 0x00094764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314260, XrefRangeEnd = 314285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = chars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bytes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetBytes_Internal_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x000965E8 File Offset: 0x000947E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314285, XrefRangeEnd = 314300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseDecoder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetCharCount_Internal_Virtual_Int32_ptr_Byte_Int32_DecoderNLS_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x00096650 File Offset: 0x00094850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314300, XrefRangeEnd = 314308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = chars;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseDecoder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetChars_Internal_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x000966D4 File Offset: 0x000948D4
		[CallerCount(0)]
		public unsafe uint GetSurrogate(char cHigh, char cLow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cHigh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cLow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetSurrogate_Private_UInt32_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x0009672C File Offset: 0x0009492C
		[CallerCount(0)]
		public unsafe char GetHighSurrogate(uint iChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iChar;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetHighSurrogate_Private_Char_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x00096778 File Offset: 0x00094978
		[CallerCount(0)]
		public unsafe char GetLowSurrogate(uint iChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iChar;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetLowSurrogate_Private_Char_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x000967C4 File Offset: 0x000949C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314308, XrefRangeEnd = 314312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Decoder GetDecoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetDecoder_Public_Virtual_Decoder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Decoder>(intPtr3) : null;
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x00096804 File Offset: 0x00094A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314312, XrefRangeEnd = 314316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Encoder GetEncoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetEncoder_Public_Virtual_Encoder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoder>(intPtr3) : null;
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x00096844 File Offset: 0x00094A44
		[CallerCount(0)]
		public unsafe override int GetMaxByteCount(int charCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetMaxByteCount_Public_Virtual_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x00096890 File Offset: 0x00094A90
		[CallerCount(0)]
		public unsafe override int GetMaxCharCount(int byteCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref byteCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetMaxCharCount_Public_Virtual_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x000968DC File Offset: 0x00094ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314316, XrefRangeEnd = 314321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetPreamble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x0009691C File Offset: 0x00094B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314321, XrefRangeEnd = 314323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x0009696C File Offset: 0x00094B6C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x00008D9D File Offset: 0x00006F9D
		public UTF32Encoding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x060019C1 RID: 6593 RVA: 0x000969A8 File Offset: 0x00094BA8
		// (set) Token: 0x060019C2 RID: 6594 RVA: 0x00008DA6 File Offset: 0x00006FA6
		public unsafe bool emitUTF32ByteOrderMark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF32Encoding.NativeFieldInfoPtr_emitUTF32ByteOrderMark);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF32Encoding.NativeFieldInfoPtr_emitUTF32ByteOrderMark)) = value;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x060019C3 RID: 6595 RVA: 0x000969D0 File Offset: 0x00094BD0
		// (set) Token: 0x060019C4 RID: 6596 RVA: 0x00008DC1 File Offset: 0x00006FC1
		public unsafe bool isThrowException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF32Encoding.NativeFieldInfoPtr_isThrowException);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF32Encoding.NativeFieldInfoPtr_isThrowException)) = value;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060019C5 RID: 6597 RVA: 0x000969F8 File Offset: 0x00094BF8
		// (set) Token: 0x060019C6 RID: 6598 RVA: 0x00008DDC File Offset: 0x00006FDC
		public unsafe bool bigEndian
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF32Encoding.NativeFieldInfoPtr_bigEndian);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF32Encoding.NativeFieldInfoPtr_bigEndian)) = value;
			}
		}

		// Token: 0x0400175F RID: 5983
		private static readonly IntPtr NativeFieldInfoPtr_emitUTF32ByteOrderMark;

		// Token: 0x04001760 RID: 5984
		private static readonly IntPtr NativeFieldInfoPtr_isThrowException;

		// Token: 0x04001761 RID: 5985
		private static readonly IntPtr NativeFieldInfoPtr_bigEndian;

		// Token: 0x04001762 RID: 5986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001763 RID: 5987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;

		// Token: 0x04001764 RID: 5988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x04001765 RID: 5989
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_Void_0;

		// Token: 0x04001766 RID: 5990
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001767 RID: 5991
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_String_0;

		// Token: 0x04001768 RID: 5992
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_0;

		// Token: 0x04001769 RID: 5993
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400176A RID: 5994
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_0;

		// Token: 0x0400176C RID: 5996
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400176D RID: 5997
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_0;

		// Token: 0x0400176E RID: 5998
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x0400176F RID: 5999
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_0;

		// Token: 0x04001770 RID: 6000
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001771 RID: 6001
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Internal_Virtual_Int32_ptr_Char_Int32_EncoderNLS_0;

		// Token: 0x04001772 RID: 6002
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Internal_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0;

		// Token: 0x04001773 RID: 6003
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Internal_Virtual_Int32_ptr_Byte_Int32_DecoderNLS_0;

		// Token: 0x04001774 RID: 6004
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Internal_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0;

		// Token: 0x04001775 RID: 6005
		private static readonly IntPtr NativeMethodInfoPtr_GetSurrogate_Private_UInt32_Char_Char_0;

		// Token: 0x04001776 RID: 6006
		private static readonly IntPtr NativeMethodInfoPtr_GetHighSurrogate_Private_Char_UInt32_0;

		// Token: 0x04001777 RID: 6007
		private static readonly IntPtr NativeMethodInfoPtr_GetLowSurrogate_Private_Char_UInt32_0;

		// Token: 0x04001778 RID: 6008
		private static readonly IntPtr NativeMethodInfoPtr_GetDecoder_Public_Virtual_Decoder_0;

		// Token: 0x04001779 RID: 6009
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoder_Public_Virtual_Encoder_0;

		// Token: 0x0400177A RID: 6010
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxByteCount_Public_Virtual_Int32_Int32_0;

		// Token: 0x0400177B RID: 6011
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxCharCount_Public_Virtual_Int32_Int32_0;

		// Token: 0x0400177C RID: 6012
		private static readonly IntPtr NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400177D RID: 6013
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400177E RID: 6014
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x020005B7 RID: 1463
		[Serializable]
		public class UTF32Decoder : DecoderNLS
		{
			// Token: 0x06005081 RID: 20609 RVA: 0x00168DB4 File Offset: 0x00166FB4
			// Note: this type is marked as 'beforefieldinit'.
			static UTF32Decoder()
			{
				Il2CppClassPointerStore<UTF32Encoding.UTF32Decoder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UTF32Encoding>.NativeClassPtr, "UTF32Decoder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UTF32Encoding.UTF32Decoder>.NativeClassPtr);
				UTF32Encoding.UTF32Decoder.NativeFieldInfoPtr_iChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF32Encoding.UTF32Decoder>.NativeClassPtr, "iChar");
				UTF32Encoding.UTF32Decoder.NativeFieldInfoPtr_readByteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF32Encoding.UTF32Decoder>.NativeClassPtr, "readByteCount");
				UTF32Encoding.UTF32Decoder.NativeMethodInfoPtr__ctor_Public_Void_UTF32Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding.UTF32Decoder>.NativeClassPtr, 100667621);
				UTF32Encoding.UTF32Decoder.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding.UTF32Decoder>.NativeClassPtr, 100667622);
				UTF32Encoding.UTF32Decoder.NativeMethodInfoPtr_get_HasState_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF32Encoding.UTF32Decoder>.NativeClassPtr, 100667623);
			}

			// Token: 0x06005082 RID: 20610 RVA: 0x00168E44 File Offset: 0x00167044
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 314161, RefRangeEnd = 314164, XrefRangeStart = 314160, XrefRangeEnd = 314161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UTF32Decoder(UTF32Encoding encoding)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF32Encoding.UTF32Decoder>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF32Encoding.UTF32Decoder.NativeMethodInfoPtr__ctor_Public_Void_UTF32Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005083 RID: 20611 RVA: 0x00168E90 File Offset: 0x00167090
			[CallerCount(0)]
			public unsafe override void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF32Encoding.UTF32Decoder.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700148F RID: 5263
			// (get) Token: 0x06005084 RID: 20612 RVA: 0x00168ECC File Offset: 0x001670CC
			public unsafe override bool HasState
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF32Encoding.UTF32Decoder.NativeMethodInfoPtr_get_HasState_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005085 RID: 20613 RVA: 0x0001EA8D File Offset: 0x0001CC8D
			public UTF32Decoder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700148D RID: 5261
			// (get) Token: 0x06005086 RID: 20614 RVA: 0x00168F14 File Offset: 0x00167114
			// (set) Token: 0x06005087 RID: 20615 RVA: 0x0001EA96 File Offset: 0x0001CC96
			public unsafe int iChar
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF32Encoding.UTF32Decoder.NativeFieldInfoPtr_iChar);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF32Encoding.UTF32Decoder.NativeFieldInfoPtr_iChar)) = value;
				}
			}

			// Token: 0x1700148E RID: 5262
			// (get) Token: 0x06005088 RID: 20616 RVA: 0x00168F3C File Offset: 0x0016713C
			// (set) Token: 0x06005089 RID: 20617 RVA: 0x0001EAB1 File Offset: 0x0001CCB1
			public unsafe int readByteCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF32Encoding.UTF32Decoder.NativeFieldInfoPtr_readByteCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF32Encoding.UTF32Decoder.NativeFieldInfoPtr_readByteCount)) = value;
				}
			}

			// Token: 0x04004168 RID: 16744
			private static readonly IntPtr NativeFieldInfoPtr_iChar;

			// Token: 0x04004169 RID: 16745
			private static readonly IntPtr NativeFieldInfoPtr_readByteCount;

			// Token: 0x0400416A RID: 16746
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UTF32Encoding_0;

			// Token: 0x0400416B RID: 16747
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

			// Token: 0x0400416C RID: 16748
			private static readonly IntPtr NativeMethodInfoPtr_get_HasState_Internal_Virtual_get_Boolean_0;
		}
	}
}

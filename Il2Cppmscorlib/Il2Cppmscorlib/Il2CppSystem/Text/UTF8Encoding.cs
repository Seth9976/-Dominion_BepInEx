using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text
{
	// Token: 0x02000175 RID: 373
	[Serializable]
	public class UTF8Encoding : Encoding
	{
		// Token: 0x060019EC RID: 6636 RVA: 0x00097818 File Offset: 0x00095A18
		// Note: this type is marked as 'beforefieldinit'.
		static UTF8Encoding()
		{
			Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "UTF8Encoding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr);
			UTF8Encoding.NativeFieldInfoPtr_emitUTF8Identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, "emitUTF8Identifier");
			UTF8Encoding.NativeFieldInfoPtr_isThrowException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, "isThrowException");
			UTF8Encoding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667671);
			UTF8Encoding.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667672);
			UTF8Encoding.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667673);
			UTF8Encoding.NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667674);
			UTF8Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667675);
			UTF8Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667676);
			UTF8Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667677);
			UTF8Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667678);
			UTF8Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667679);
			UTF8Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667680);
			UTF8Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667681);
			UTF8Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667682);
			UTF8Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667683);
			UTF8Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667684);
			UTF8Encoding.NativeMethodInfoPtr_GetString_Public_Virtual_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667685);
			UTF8Encoding.NativeMethodInfoPtr_GetByteCount_Internal_Virtual_Int32_ptr_Char_Int32_EncoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667686);
			UTF8Encoding.NativeMethodInfoPtr_PtrDiff_Private_Static_Int32_ptr_Char_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667687);
			UTF8Encoding.NativeMethodInfoPtr_PtrDiff_Private_Static_Int32_ptr_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667688);
			UTF8Encoding.NativeMethodInfoPtr_InRange_Private_Static_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667689);
			UTF8Encoding.NativeMethodInfoPtr_GetBytes_Internal_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667690);
			UTF8Encoding.NativeMethodInfoPtr_GetCharCount_Internal_Virtual_Int32_ptr_Byte_Int32_DecoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667691);
			UTF8Encoding.NativeMethodInfoPtr_GetChars_Internal_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667692);
			UTF8Encoding.NativeMethodInfoPtr_FallbackInvalidByteSequence_Private_Boolean_byref_ptr_Byte_Int32_DecoderFallbackBuffer_byref_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667693);
			UTF8Encoding.NativeMethodInfoPtr_FallbackInvalidByteSequence_Private_Int32_ptr_Byte_Int32_DecoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667694);
			UTF8Encoding.NativeMethodInfoPtr_GetBytesUnknown_Private_Il2CppStructArray_1_Byte_byref_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667695);
			UTF8Encoding.NativeMethodInfoPtr_GetDecoder_Public_Virtual_Decoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667696);
			UTF8Encoding.NativeMethodInfoPtr_GetEncoder_Public_Virtual_Encoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667697);
			UTF8Encoding.NativeMethodInfoPtr_GetMaxByteCount_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667698);
			UTF8Encoding.NativeMethodInfoPtr_GetMaxCharCount_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667699);
			UTF8Encoding.NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667700);
			UTF8Encoding.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667701);
			UTF8Encoding.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, 100667702);
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x00097AF0 File Offset: 0x00095CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314711, RefRangeEnd = 314712, XrefRangeStart = 314710, XrefRangeEnd = 314711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UTF8Encoding()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8Encoding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x00097B2C File Offset: 0x00095D2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314713, RefRangeEnd = 314714, XrefRangeStart = 314712, XrefRangeEnd = 314713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UTF8Encoding(bool encoderShouldEmitUTF8Identifier)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encoderShouldEmitUTF8Identifier;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8Encoding.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x00097B74 File Offset: 0x00095D74
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 314715, RefRangeEnd = 314722, XrefRangeStart = 314714, XrefRangeEnd = 314715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UTF8Encoding(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref encoderShouldEmitUTF8Identifier;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnInvalidBytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8Encoding.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00097BCC File Offset: 0x00095DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314722, XrefRangeEnd = 314733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetDefaultFallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x00097C08 File Offset: 0x00095E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314733, XrefRangeEnd = 314735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x00097C7C File Offset: 0x00095E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314735, XrefRangeEnd = 314736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetByteCount(string chars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x00097CD4 File Offset: 0x00095ED4
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x00097D38 File Offset: 0x00095F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314736, XrefRangeEnd = 314774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x00097DD0 File Offset: 0x00095FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314774, XrefRangeEnd = 314780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x00097E68 File Offset: 0x00096068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314780, XrefRangeEnd = 314781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x00097EE4 File Offset: 0x000960E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314781, XrefRangeEnd = 314783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x00097F58 File Offset: 0x00096158
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x00097FBC File Offset: 0x000961BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314783, XrefRangeEnd = 314789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x00098054 File Offset: 0x00096254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314789, XrefRangeEnd = 314790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x000980D0 File Offset: 0x000962D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314790, XrefRangeEnd = 314793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetString_Public_Virtual_String_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x00098140 File Offset: 0x00096340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314793, XrefRangeEnd = 314822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = chars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseEncoder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetByteCount_Internal_Virtual_Int32_ptr_Char_Int32_EncoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x000981B4 File Offset: 0x000963B4
		[CallerCount(0)]
		public unsafe static int PtrDiff(char* a, char* b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8Encoding.NativeMethodInfoPtr_PtrDiff_Private_Static_Int32_ptr_Char_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x00098200 File Offset: 0x00096400
		[CallerCount(0)]
		public unsafe static int PtrDiff(byte* a, byte* b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8Encoding.NativeMethodInfoPtr_PtrDiff_Private_Static_Int32_ptr_Byte_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x0009824C File Offset: 0x0009644C
		[CallerCount(0)]
		public unsafe static bool InRange(int ch, int start, int end)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8Encoding.NativeMethodInfoPtr_InRange_Private_Static_Boolean_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x000982A8 File Offset: 0x000964A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314822, XrefRangeEnd = 314835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder)
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
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseEncoder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetBytes_Internal_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x00098338 File Offset: 0x00096538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314835, XrefRangeEnd = 314866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetCharCount_Internal_Virtual_Int32_ptr_Byte_Int32_DecoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x000983AC File Offset: 0x000965AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314866, XrefRangeEnd = 314907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetChars_Internal_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0009843C File Offset: 0x0009663C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314907, XrefRangeEnd = 314908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(pSrc);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fallback);
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(pTarget);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(UTF8Encoding.NativeMethodInfoPtr_FallbackInvalidByteSequence_Private_Boolean_byref_ptr_Byte_Int32_DecoderFallbackBuffer_byref_ptr_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			pSrc = ((intPtr5 == 0) ? null : new byte*(intPtr5));
			IntPtr intPtr6 = intPtr2;
			pTarget = ((intPtr6 == 0) ? null : new char*(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x000984EC File Offset: 0x000966EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314908, XrefRangeEnd = 314910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pSrc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8Encoding.NativeMethodInfoPtr_FallbackInvalidByteSequence_Private_Int32_ptr_Byte_Int32_DecoderFallbackBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x00098554 File Offset: 0x00096754
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 314913, RefRangeEnd = 314918, XrefRangeStart = 314910, XrefRangeEnd = 314913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetBytesUnknown(ref byte* pSrc, int ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(pSrc);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UTF8Encoding.NativeMethodInfoPtr_GetBytesUnknown_Private_Il2CppStructArray_1_Byte_byref_ptr_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pSrc = ((intPtr4 == 0) ? null : new byte*(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr5) : null;
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x000985CC File Offset: 0x000967CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314918, XrefRangeEnd = 314922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Decoder GetDecoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetDecoder_Public_Virtual_Decoder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Decoder>(intPtr3) : null;
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00098618 File Offset: 0x00096818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314922, XrefRangeEnd = 314926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Encoder GetEncoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetEncoder_Public_Virtual_Encoder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoder>(intPtr3) : null;
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00098664 File Offset: 0x00096864
		[CallerCount(0)]
		public unsafe override int GetMaxByteCount(int charCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetMaxByteCount_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x000986B8 File Offset: 0x000968B8
		[CallerCount(0)]
		public unsafe override int GetMaxCharCount(int byteCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref byteCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetMaxCharCount_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0009870C File Offset: 0x0009690C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314926, XrefRangeEnd = 314932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetPreamble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00098758 File Offset: 0x00096958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314932, XrefRangeEnd = 314934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x000987B0 File Offset: 0x000969B0
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00008E78 File Offset: 0x00007078
		public UTF8Encoding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001A0E RID: 6670 RVA: 0x000987F8 File Offset: 0x000969F8
		// (set) Token: 0x06001A0F RID: 6671 RVA: 0x00008E81 File Offset: 0x00007081
		public unsafe bool emitUTF8Identifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8Encoding.NativeFieldInfoPtr_emitUTF8Identifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8Encoding.NativeFieldInfoPtr_emitUTF8Identifier)) = value;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x00098820 File Offset: 0x00096A20
		// (set) Token: 0x06001A11 RID: 6673 RVA: 0x00008E9C File Offset: 0x0000709C
		public unsafe bool isThrowException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8Encoding.NativeFieldInfoPtr_isThrowException);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8Encoding.NativeFieldInfoPtr_isThrowException)) = value;
			}
		}

		// Token: 0x0400179E RID: 6046
		private static readonly IntPtr NativeFieldInfoPtr_emitUTF8Identifier;

		// Token: 0x0400179F RID: 6047
		private static readonly IntPtr NativeFieldInfoPtr_isThrowException;

		// Token: 0x040017A0 RID: 6048
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040017A1 RID: 6049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040017A2 RID: 6050
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;

		// Token: 0x040017A3 RID: 6051
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_Void_0;

		// Token: 0x040017A4 RID: 6052
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040017A5 RID: 6053
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_String_0;

		// Token: 0x040017A6 RID: 6054
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_0;

		// Token: 0x040017A7 RID: 6055
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040017A8 RID: 6056
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040017A9 RID: 6057
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_0;

		// Token: 0x040017AA RID: 6058
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040017AB RID: 6059
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_0;

		// Token: 0x040017AC RID: 6060
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x040017AD RID: 6061
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_0;

		// Token: 0x040017AE RID: 6062
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040017AF RID: 6063
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Internal_Virtual_Int32_ptr_Char_Int32_EncoderNLS_0;

		// Token: 0x040017B0 RID: 6064
		private static readonly IntPtr NativeMethodInfoPtr_PtrDiff_Private_Static_Int32_ptr_Char_ptr_Char_0;

		// Token: 0x040017B1 RID: 6065
		private static readonly IntPtr NativeMethodInfoPtr_PtrDiff_Private_Static_Int32_ptr_Byte_ptr_Byte_0;

		// Token: 0x040017B2 RID: 6066
		private static readonly IntPtr NativeMethodInfoPtr_InRange_Private_Static_Boolean_Int32_Int32_Int32_0;

		// Token: 0x040017B3 RID: 6067
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Internal_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0;

		// Token: 0x040017B4 RID: 6068
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Internal_Virtual_Int32_ptr_Byte_Int32_DecoderNLS_0;

		// Token: 0x040017B5 RID: 6069
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Internal_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0;

		// Token: 0x040017B6 RID: 6070
		private static readonly IntPtr NativeMethodInfoPtr_FallbackInvalidByteSequence_Private_Boolean_byref_ptr_Byte_Int32_DecoderFallbackBuffer_byref_ptr_Char_0;

		// Token: 0x040017B7 RID: 6071
		private static readonly IntPtr NativeMethodInfoPtr_FallbackInvalidByteSequence_Private_Int32_ptr_Byte_Int32_DecoderFallbackBuffer_0;

		// Token: 0x040017B8 RID: 6072
		private static readonly IntPtr NativeMethodInfoPtr_GetBytesUnknown_Private_Il2CppStructArray_1_Byte_byref_ptr_Byte_Int32_0;

		// Token: 0x040017B9 RID: 6073
		private static readonly IntPtr NativeMethodInfoPtr_GetDecoder_Public_Virtual_Decoder_0;

		// Token: 0x040017BA RID: 6074
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoder_Public_Virtual_Encoder_0;

		// Token: 0x040017BB RID: 6075
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxByteCount_Public_Virtual_Int32_Int32_0;

		// Token: 0x040017BC RID: 6076
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxCharCount_Public_Virtual_Int32_Int32_0;

		// Token: 0x040017BD RID: 6077
		private static readonly IntPtr NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x040017BE RID: 6078
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040017BF RID: 6079
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x020005BC RID: 1468
		[Serializable]
		public class UTF8Encoder : EncoderNLS
		{
			// Token: 0x060050B6 RID: 20662 RVA: 0x00169950 File Offset: 0x00167B50
			// Note: this type is marked as 'beforefieldinit'.
			static UTF8Encoder()
			{
				Il2CppClassPointerStore<UTF8Encoding.UTF8Encoder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, "UTF8Encoder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UTF8Encoding.UTF8Encoder>.NativeClassPtr);
				UTF8Encoding.UTF8Encoder.NativeFieldInfoPtr_surrogateChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF8Encoding.UTF8Encoder>.NativeClassPtr, "surrogateChar");
				UTF8Encoding.UTF8Encoder.NativeMethodInfoPtr__ctor_Public_Void_UTF8Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding.UTF8Encoder>.NativeClassPtr, 100667703);
				UTF8Encoding.UTF8Encoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding.UTF8Encoder>.NativeClassPtr, 100667704);
				UTF8Encoding.UTF8Encoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding.UTF8Encoder>.NativeClassPtr, 100667705);
				UTF8Encoding.UTF8Encoder.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding.UTF8Encoder>.NativeClassPtr, 100667706);
			}

			// Token: 0x060050B7 RID: 20663 RVA: 0x001699E0 File Offset: 0x00167BE0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 314379, RefRangeEnd = 314381, XrefRangeStart = 314379, XrefRangeEnd = 314381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UTF8Encoder(UTF8Encoding encoding)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF8Encoding.UTF8Encoder>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8Encoding.UTF8Encoder.NativeMethodInfoPtr__ctor_Public_Void_UTF8Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050B8 RID: 20664 RVA: 0x00169A2C File Offset: 0x00167C2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314596, XrefRangeEnd = 314629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UTF8Encoder(SerializationInfo info, StreamingContext context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF8Encoding.UTF8Encoder>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8Encoding.UTF8Encoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050B9 RID: 20665 RVA: 0x00169A90 File Offset: 0x00167C90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314629, XrefRangeEnd = 314650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8Encoding.UTF8Encoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050BA RID: 20666 RVA: 0x00169AEC File Offset: 0x00167CEC
			[CallerCount(0)]
			public unsafe override void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.UTF8Encoder.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050BB RID: 20667 RVA: 0x0001EBC8 File Offset: 0x0001CDC8
			public UTF8Encoder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700149B RID: 5275
			// (get) Token: 0x060050BC RID: 20668 RVA: 0x00169B28 File Offset: 0x00167D28
			// (set) Token: 0x060050BD RID: 20669 RVA: 0x0001EBD1 File Offset: 0x0001CDD1
			public unsafe int surrogateChar
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8Encoding.UTF8Encoder.NativeFieldInfoPtr_surrogateChar);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8Encoding.UTF8Encoder.NativeFieldInfoPtr_surrogateChar)) = value;
				}
			}

			// Token: 0x04004189 RID: 16777
			private static readonly IntPtr NativeFieldInfoPtr_surrogateChar;

			// Token: 0x0400418A RID: 16778
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UTF8Encoding_0;

			// Token: 0x0400418B RID: 16779
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x0400418C RID: 16780
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x0400418D RID: 16781
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;
		}

		// Token: 0x020005BD RID: 1469
		[Serializable]
		public class UTF8Decoder : DecoderNLS
		{
			// Token: 0x060050BE RID: 20670 RVA: 0x00169B50 File Offset: 0x00167D50
			// Note: this type is marked as 'beforefieldinit'.
			static UTF8Decoder()
			{
				Il2CppClassPointerStore<UTF8Encoding.UTF8Decoder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UTF8Encoding>.NativeClassPtr, "UTF8Decoder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UTF8Encoding.UTF8Decoder>.NativeClassPtr);
				UTF8Encoding.UTF8Decoder.NativeFieldInfoPtr_bits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF8Encoding.UTF8Decoder>.NativeClassPtr, "bits");
				UTF8Encoding.UTF8Decoder.NativeMethodInfoPtr__ctor_Public_Void_UTF8Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding.UTF8Decoder>.NativeClassPtr, 100667707);
				UTF8Encoding.UTF8Decoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding.UTF8Decoder>.NativeClassPtr, 100667708);
				UTF8Encoding.UTF8Decoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding.UTF8Decoder>.NativeClassPtr, 100667709);
				UTF8Encoding.UTF8Decoder.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding.UTF8Decoder>.NativeClassPtr, 100667710);
				UTF8Encoding.UTF8Decoder.NativeMethodInfoPtr_get_HasState_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF8Encoding.UTF8Decoder>.NativeClassPtr, 100667711);
			}

			// Token: 0x060050BF RID: 20671 RVA: 0x00169BF4 File Offset: 0x00167DF4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 314161, RefRangeEnd = 314164, XrefRangeStart = 314161, XrefRangeEnd = 314164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UTF8Decoder(UTF8Encoding encoding)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF8Encoding.UTF8Decoder>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8Encoding.UTF8Decoder.NativeMethodInfoPtr__ctor_Public_Void_UTF8Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050C0 RID: 20672 RVA: 0x00169C40 File Offset: 0x00167E40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314650, XrefRangeEnd = 314683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UTF8Decoder(SerializationInfo info, StreamingContext context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF8Encoding.UTF8Decoder>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8Encoding.UTF8Decoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050C1 RID: 20673 RVA: 0x00169CA4 File Offset: 0x00167EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314683, XrefRangeEnd = 314710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF8Encoding.UTF8Decoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050C2 RID: 20674 RVA: 0x00169D00 File Offset: 0x00167F00
			[CallerCount(0)]
			public unsafe override void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.UTF8Decoder.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700149D RID: 5277
			// (get) Token: 0x060050C3 RID: 20675 RVA: 0x00169D3C File Offset: 0x00167F3C
			public unsafe override bool HasState
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF8Encoding.UTF8Decoder.NativeMethodInfoPtr_get_HasState_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060050C4 RID: 20676 RVA: 0x0001EBEC File Offset: 0x0001CDEC
			public UTF8Decoder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700149C RID: 5276
			// (get) Token: 0x060050C5 RID: 20677 RVA: 0x00169D84 File Offset: 0x00167F84
			// (set) Token: 0x060050C6 RID: 20678 RVA: 0x0001EBF5 File Offset: 0x0001CDF5
			public unsafe int bits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8Encoding.UTF8Decoder.NativeFieldInfoPtr_bits);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF8Encoding.UTF8Decoder.NativeFieldInfoPtr_bits)) = value;
				}
			}

			// Token: 0x0400418E RID: 16782
			private static readonly IntPtr NativeFieldInfoPtr_bits;

			// Token: 0x0400418F RID: 16783
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UTF8Encoding_0;

			// Token: 0x04004190 RID: 16784
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004191 RID: 16785
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004192 RID: 16786
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

			// Token: 0x04004193 RID: 16787
			private static readonly IntPtr NativeMethodInfoPtr_get_HasState_Internal_Virtual_get_Boolean_0;
		}
	}
}

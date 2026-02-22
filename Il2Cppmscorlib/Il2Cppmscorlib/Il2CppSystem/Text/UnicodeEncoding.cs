using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text
{
	// Token: 0x02000172 RID: 370
	[Serializable]
	public class UnicodeEncoding : Encoding
	{
		// Token: 0x0600197D RID: 6525 RVA: 0x00094E40 File Offset: 0x00093040
		// Note: this type is marked as 'beforefieldinit'.
		static UnicodeEncoding()
		{
			Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "UnicodeEncoding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr);
			UnicodeEncoding.NativeFieldInfoPtr_isThrowException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, "isThrowException");
			UnicodeEncoding.NativeFieldInfoPtr_bigEndian = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, "bigEndian");
			UnicodeEncoding.NativeFieldInfoPtr_byteOrderMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, "byteOrderMark");
			UnicodeEncoding.NativeFieldInfoPtr_highLowPatternMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, "highLowPatternMask");
			UnicodeEncoding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667559);
			UnicodeEncoding.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667560);
			UnicodeEncoding.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667561);
			UnicodeEncoding.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667562);
			UnicodeEncoding.NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667563);
			UnicodeEncoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667564);
			UnicodeEncoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667565);
			UnicodeEncoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667566);
			UnicodeEncoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667567);
			UnicodeEncoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667568);
			UnicodeEncoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667569);
			UnicodeEncoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667570);
			UnicodeEncoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667571);
			UnicodeEncoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667572);
			UnicodeEncoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667573);
			UnicodeEncoding.NativeMethodInfoPtr_GetString_Public_Virtual_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667574);
			UnicodeEncoding.NativeMethodInfoPtr_GetByteCount_Internal_Virtual_Int32_ptr_Char_Int32_EncoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667575);
			UnicodeEncoding.NativeMethodInfoPtr_GetBytes_Internal_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667576);
			UnicodeEncoding.NativeMethodInfoPtr_GetCharCount_Internal_Virtual_Int32_ptr_Byte_Int32_DecoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667577);
			UnicodeEncoding.NativeMethodInfoPtr_GetChars_Internal_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667578);
			UnicodeEncoding.NativeMethodInfoPtr_GetEncoder_Public_Virtual_Encoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667579);
			UnicodeEncoding.NativeMethodInfoPtr_GetDecoder_Public_Virtual_Decoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667580);
			UnicodeEncoding.NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667581);
			UnicodeEncoding.NativeMethodInfoPtr_GetMaxByteCount_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667582);
			UnicodeEncoding.NativeMethodInfoPtr_GetMaxCharCount_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667583);
			UnicodeEncoding.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667584);
			UnicodeEncoding.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, 100667585);
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x000950DC File Offset: 0x000932DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313891, XrefRangeEnd = 313892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnicodeEncoding()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnicodeEncoding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00095118 File Offset: 0x00093318
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 313893, RefRangeEnd = 313897, XrefRangeStart = 313892, XrefRangeEnd = 313893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnicodeEncoding(bool bigEndian, bool byteOrderMark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bigEndian;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteOrderMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnicodeEncoding.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00095170 File Offset: 0x00093370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313897, XrefRangeEnd = 313898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnicodeEncoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bigEndian;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteOrderMark;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnInvalidBytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnicodeEncoding.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x000951D4 File Offset: 0x000933D4
		[CallerCount(0)]
		public new unsafe void OnDeserializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnicodeEncoding.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x0009521C File Offset: 0x0009341C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313898, XrefRangeEnd = 313909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetDefaultFallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00095258 File Offset: 0x00093458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313909, XrefRangeEnd = 313911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x000952CC File Offset: 0x000934CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313911, XrefRangeEnd = 313912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetByteCount(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00095324 File Offset: 0x00093524
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00095388 File Offset: 0x00093588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313912, XrefRangeEnd = 313950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x00095420 File Offset: 0x00093620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313950, XrefRangeEnd = 313956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x000954B8 File Offset: 0x000936B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313956, XrefRangeEnd = 313957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x00095534 File Offset: 0x00093734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313957, XrefRangeEnd = 313959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x000955A8 File Offset: 0x000937A8
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x0009560C File Offset: 0x0009380C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313959, XrefRangeEnd = 313965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x000956A4 File Offset: 0x000938A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313965, XrefRangeEnd = 313966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x00095720 File Offset: 0x00093920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313966, XrefRangeEnd = 313969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetString_Public_Virtual_String_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00095790 File Offset: 0x00093990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313969, XrefRangeEnd = 314000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetByteCount_Internal_Virtual_Int32_ptr_Char_Int32_EncoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x00095804 File Offset: 0x00093A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314000, XrefRangeEnd = 314039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetBytes_Internal_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00095894 File Offset: 0x00093A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314039, XrefRangeEnd = 314092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetCharCount_Internal_Virtual_Int32_ptr_Byte_Int32_DecoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x00095908 File Offset: 0x00093B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314092, XrefRangeEnd = 314145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetChars_Internal_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x00095998 File Offset: 0x00093B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314145, XrefRangeEnd = 314149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Encoder GetEncoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetEncoder_Public_Virtual_Encoder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoder>(intPtr3) : null;
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x000959E4 File Offset: 0x00093BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314149, XrefRangeEnd = 314153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppSystem.Text.Decoder GetDecoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetDecoder_Public_Virtual_Decoder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Text.Decoder>(intPtr3) : null;
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x00095A30 File Offset: 0x00093C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314153, XrefRangeEnd = 314158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetPreamble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x00095A7C File Offset: 0x00093C7C
		[CallerCount(0)]
		public unsafe override int GetMaxByteCount(int charCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetMaxByteCount_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x00095AD0 File Offset: 0x00093CD0
		[CallerCount(0)]
		public unsafe override int GetMaxCharCount(int byteCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref byteCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetMaxCharCount_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x00095B24 File Offset: 0x00093D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314158, XrefRangeEnd = 314160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00095B7C File Offset: 0x00093D7C
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x00008D35 File Offset: 0x00006F35
		public UnicodeEncoding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x0600199A RID: 6554 RVA: 0x00095BC4 File Offset: 0x00093DC4
		// (set) Token: 0x0600199B RID: 6555 RVA: 0x00008D3E File Offset: 0x00006F3E
		public unsafe bool isThrowException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeEncoding.NativeFieldInfoPtr_isThrowException);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeEncoding.NativeFieldInfoPtr_isThrowException)) = value;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x0600199C RID: 6556 RVA: 0x00095BEC File Offset: 0x00093DEC
		// (set) Token: 0x0600199D RID: 6557 RVA: 0x00008D59 File Offset: 0x00006F59
		public unsafe bool bigEndian
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeEncoding.NativeFieldInfoPtr_bigEndian);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeEncoding.NativeFieldInfoPtr_bigEndian)) = value;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x0600199E RID: 6558 RVA: 0x00095C14 File Offset: 0x00093E14
		// (set) Token: 0x0600199F RID: 6559 RVA: 0x00008D74 File Offset: 0x00006F74
		public unsafe bool byteOrderMark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeEncoding.NativeFieldInfoPtr_byteOrderMark);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeEncoding.NativeFieldInfoPtr_byteOrderMark)) = value;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x00095C3C File Offset: 0x00093E3C
		// (set) Token: 0x060019A1 RID: 6561 RVA: 0x00008D8F File Offset: 0x00006F8F
		public unsafe static ulong highLowPatternMask
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(UnicodeEncoding.NativeFieldInfoPtr_highLowPatternMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnicodeEncoding.NativeFieldInfoPtr_highLowPatternMask, (void*)(&value));
			}
		}

		// Token: 0x04001740 RID: 5952
		private static readonly IntPtr NativeFieldInfoPtr_isThrowException;

		// Token: 0x04001741 RID: 5953
		private static readonly IntPtr NativeFieldInfoPtr_bigEndian;

		// Token: 0x04001742 RID: 5954
		private static readonly IntPtr NativeFieldInfoPtr_byteOrderMark;

		// Token: 0x04001743 RID: 5955
		private static readonly IntPtr NativeFieldInfoPtr_highLowPatternMask;

		// Token: 0x04001744 RID: 5956
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001745 RID: 5957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;

		// Token: 0x04001746 RID: 5958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x04001747 RID: 5959
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0;

		// Token: 0x04001748 RID: 5960
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_Void_0;

		// Token: 0x04001749 RID: 5961
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0400174A RID: 5962
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_String_0;

		// Token: 0x0400174B RID: 5963
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_0;

		// Token: 0x0400174C RID: 5964
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400174D RID: 5965
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400174E RID: 5966
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_0;

		// Token: 0x0400174F RID: 5967
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001750 RID: 5968
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_0;

		// Token: 0x04001751 RID: 5969
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04001752 RID: 5970
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_0;

		// Token: 0x04001753 RID: 5971
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001754 RID: 5972
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Internal_Virtual_Int32_ptr_Char_Int32_EncoderNLS_0;

		// Token: 0x04001755 RID: 5973
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Internal_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0;

		// Token: 0x04001756 RID: 5974
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Internal_Virtual_Int32_ptr_Byte_Int32_DecoderNLS_0;

		// Token: 0x04001757 RID: 5975
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Internal_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0;

		// Token: 0x04001758 RID: 5976
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoder_Public_Virtual_Encoder_0;

		// Token: 0x04001759 RID: 5977
		private static readonly IntPtr NativeMethodInfoPtr_GetDecoder_Public_Virtual_Decoder_0;

		// Token: 0x0400175A RID: 5978
		private static readonly IntPtr NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400175B RID: 5979
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxByteCount_Public_Virtual_Int32_Int32_0;

		// Token: 0x0400175C RID: 5980
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxCharCount_Public_Virtual_Int32_Int32_0;

		// Token: 0x0400175D RID: 5981
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400175E RID: 5982
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x020005B6 RID: 1462
		[Serializable]
		public class Decoder : DecoderNLS
		{
			// Token: 0x06005076 RID: 20598 RVA: 0x00168B1C File Offset: 0x00166D1C
			// Note: this type is marked as 'beforefieldinit'.
			static Decoder()
			{
				Il2CppClassPointerStore<UnicodeEncoding.Decoder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnicodeEncoding>.NativeClassPtr, "Decoder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnicodeEncoding.Decoder>.NativeClassPtr);
				UnicodeEncoding.Decoder.NativeFieldInfoPtr_lastByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnicodeEncoding.Decoder>.NativeClassPtr, "lastByte");
				UnicodeEncoding.Decoder.NativeFieldInfoPtr_lastChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnicodeEncoding.Decoder>.NativeClassPtr, "lastChar");
				UnicodeEncoding.Decoder.NativeMethodInfoPtr__ctor_Public_Void_UnicodeEncoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding.Decoder>.NativeClassPtr, 100667587);
				UnicodeEncoding.Decoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding.Decoder>.NativeClassPtr, 100667588);
				UnicodeEncoding.Decoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding.Decoder>.NativeClassPtr, 100667589);
				UnicodeEncoding.Decoder.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding.Decoder>.NativeClassPtr, 100667590);
				UnicodeEncoding.Decoder.NativeMethodInfoPtr_get_HasState_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnicodeEncoding.Decoder>.NativeClassPtr, 100667591);
			}

			// Token: 0x06005077 RID: 20599 RVA: 0x00168BD4 File Offset: 0x00166DD4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 313810, RefRangeEnd = 313811, XrefRangeStart = 313809, XrefRangeEnd = 313810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Decoder(UnicodeEncoding encoding)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnicodeEncoding.Decoder>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnicodeEncoding.Decoder.NativeMethodInfoPtr__ctor_Public_Void_UnicodeEncoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005078 RID: 20600 RVA: 0x00168C20 File Offset: 0x00166E20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313811, XrefRangeEnd = 313866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Decoder(SerializationInfo info, StreamingContext context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnicodeEncoding.Decoder>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnicodeEncoding.Decoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005079 RID: 20601 RVA: 0x00168C84 File Offset: 0x00166E84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313866, XrefRangeEnd = 313891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnicodeEncoding.Decoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600507A RID: 20602 RVA: 0x00168CE0 File Offset: 0x00166EE0
			[CallerCount(0)]
			public unsafe override void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.Decoder.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700148C RID: 5260
			// (get) Token: 0x0600507B RID: 20603 RVA: 0x00168D1C File Offset: 0x00166F1C
			public unsafe override bool HasState
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnicodeEncoding.Decoder.NativeMethodInfoPtr_get_HasState_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600507C RID: 20604 RVA: 0x0001EA4E File Offset: 0x0001CC4E
			public Decoder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700148A RID: 5258
			// (get) Token: 0x0600507D RID: 20605 RVA: 0x00168D64 File Offset: 0x00166F64
			// (set) Token: 0x0600507E RID: 20606 RVA: 0x0001EA57 File Offset: 0x0001CC57
			public unsafe int lastByte
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeEncoding.Decoder.NativeFieldInfoPtr_lastByte);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeEncoding.Decoder.NativeFieldInfoPtr_lastByte)) = value;
				}
			}

			// Token: 0x1700148B RID: 5259
			// (get) Token: 0x0600507F RID: 20607 RVA: 0x00168D8C File Offset: 0x00166F8C
			// (set) Token: 0x06005080 RID: 20608 RVA: 0x0001EA72 File Offset: 0x0001CC72
			public unsafe char lastChar
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeEncoding.Decoder.NativeFieldInfoPtr_lastChar);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnicodeEncoding.Decoder.NativeFieldInfoPtr_lastChar)) = value;
				}
			}

			// Token: 0x04004161 RID: 16737
			private static readonly IntPtr NativeFieldInfoPtr_lastByte;

			// Token: 0x04004162 RID: 16738
			private static readonly IntPtr NativeFieldInfoPtr_lastChar;

			// Token: 0x04004163 RID: 16739
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnicodeEncoding_0;

			// Token: 0x04004164 RID: 16740
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004165 RID: 16741
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004166 RID: 16742
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

			// Token: 0x04004167 RID: 16743
			private static readonly IntPtr NativeMethodInfoPtr_get_HasState_Internal_Virtual_get_Boolean_0;
		}
	}
}

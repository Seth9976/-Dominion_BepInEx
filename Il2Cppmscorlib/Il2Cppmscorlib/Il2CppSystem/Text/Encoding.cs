using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text
{
	// Token: 0x0200016C RID: 364
	[Serializable]
	public class Encoding : Object
	{
		// Token: 0x06001895 RID: 6293 RVA: 0x00090300 File Offset: 0x0008E500
		// Note: this type is marked as 'beforefieldinit'.
		static Encoding()
		{
			Il2CppClassPointerStore<Encoding>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "Encoding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Encoding>.NativeClassPtr);
			Encoding.NativeFieldInfoPtr_defaultEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "defaultEncoding");
			Encoding.NativeFieldInfoPtr_unicodeEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "unicodeEncoding");
			Encoding.NativeFieldInfoPtr_bigEndianUnicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "bigEndianUnicode");
			Encoding.NativeFieldInfoPtr_utf7Encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "utf7Encoding");
			Encoding.NativeFieldInfoPtr_utf8Encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "utf8Encoding");
			Encoding.NativeFieldInfoPtr_utf32Encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "utf32Encoding");
			Encoding.NativeFieldInfoPtr_asciiEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "asciiEncoding");
			Encoding.NativeFieldInfoPtr_latin1Encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "latin1Encoding");
			Encoding.NativeFieldInfoPtr_encodings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "encodings");
			Encoding.NativeFieldInfoPtr_m_codePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "m_codePage");
			Encoding.NativeFieldInfoPtr_dataItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "dataItem");
			Encoding.NativeFieldInfoPtr_m_deserializedFromEverett = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "m_deserializedFromEverett");
			Encoding.NativeFieldInfoPtr_m_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "m_isReadOnly");
			Encoding.NativeFieldInfoPtr_encoderFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "encoderFallback");
			Encoding.NativeFieldInfoPtr_decoderFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "decoderFallback");
			Encoding.NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "s_InternalSyncObject");
			Encoding.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667362);
			Encoding.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667363);
			Encoding.NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667364);
			Encoding.NativeMethodInfoPtr_OnDeserializing_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667365);
			Encoding.NativeMethodInfoPtr_OnDeserialized_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667366);
			Encoding.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667367);
			Encoding.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667368);
			Encoding.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667369);
			Encoding.NativeMethodInfoPtr_DeserializeEncoding_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667370);
			Encoding.NativeMethodInfoPtr_SerializeEncoding_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667371);
			Encoding.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667372);
			Encoding.NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667373);
			Encoding.NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667374);
			Encoding.NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667375);
			Encoding.NativeMethodInfoPtr_GetPreamble_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667376);
			Encoding.NativeMethodInfoPtr_GetDataItem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667377);
			Encoding.NativeMethodInfoPtr_get_EncodingName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667378);
			Encoding.NativeMethodInfoPtr_get_HeaderName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667379);
			Encoding.NativeMethodInfoPtr_get_WebName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667380);
			Encoding.NativeMethodInfoPtr_get_EncoderFallback_Public_get_EncoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667381);
			Encoding.NativeMethodInfoPtr_set_EncoderFallback_Public_set_Void_EncoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667382);
			Encoding.NativeMethodInfoPtr_get_DecoderFallback_Public_get_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667383);
			Encoding.NativeMethodInfoPtr_set_DecoderFallback_Public_set_Void_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667384);
			Encoding.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667385);
			Encoding.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667386);
			Encoding.NativeMethodInfoPtr_get_ASCII_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667387);
			Encoding.NativeMethodInfoPtr_get_Latin1_Private_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667388);
			Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667389);
			Encoding.NativeMethodInfoPtr_GetByteCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667390);
			Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667391);
			Encoding.NativeMethodInfoPtr_GetByteCount_Internal_Virtual_New_Int32_ptr_Char_Int32_EncoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667392);
			Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667393);
			Encoding.NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667394);
			Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667395);
			Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667396);
			Encoding.NativeMethodInfoPtr_GetBytes_Internal_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667397);
			Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667398);
			Encoding.NativeMethodInfoPtr_GetCharCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667399);
			Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_New_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667400);
			Encoding.NativeMethodInfoPtr_GetCharCount_Internal_Virtual_New_Int32_ptr_Byte_Int32_DecoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667401);
			Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_New_Il2CppStructArray_1_Char_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667402);
			Encoding.NativeMethodInfoPtr_GetChars_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667403);
			Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667404);
			Encoding.NativeMethodInfoPtr_GetChars_Internal_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667405);
			Encoding.NativeMethodInfoPtr_get_CodePage_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667406);
			Encoding.NativeMethodInfoPtr_GetDecoder_Public_Virtual_New_Decoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667407);
			Encoding.NativeMethodInfoPtr_CreateDefaultEncoding_Private_Static_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667408);
			Encoding.NativeMethodInfoPtr_setReadOnly_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667409);
			Encoding.NativeMethodInfoPtr_get_Default_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667410);
			Encoding.NativeMethodInfoPtr_GetEncoder_Public_Virtual_New_Encoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667411);
			Encoding.NativeMethodInfoPtr_GetMaxByteCount_Public_Abstract_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667412);
			Encoding.NativeMethodInfoPtr_GetMaxCharCount_Public_Abstract_Virtual_New_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667413);
			Encoding.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667414);
			Encoding.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667415);
			Encoding.NativeMethodInfoPtr_get_Unicode_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667416);
			Encoding.NativeMethodInfoPtr_get_BigEndianUnicode_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667417);
			Encoding.NativeMethodInfoPtr_get_UTF7_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667418);
			Encoding.NativeMethodInfoPtr_get_UTF8_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667419);
			Encoding.NativeMethodInfoPtr_get_UTF32_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667420);
			Encoding.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667421);
			Encoding.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667422);
			Encoding.NativeMethodInfoPtr_GetBestFitUnicodeToBytesData_Internal_Virtual_New_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667423);
			Encoding.NativeMethodInfoPtr_GetBestFitBytesToUnicodeData_Internal_Virtual_New_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667424);
			Encoding.NativeMethodInfoPtr_ThrowBytesOverflow_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667425);
			Encoding.NativeMethodInfoPtr_ThrowBytesOverflow_Internal_Void_EncoderNLS_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667426);
			Encoding.NativeMethodInfoPtr_ThrowCharsOverflow_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667427);
			Encoding.NativeMethodInfoPtr_ThrowCharsOverflow_Internal_Void_DecoderNLS_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding>.NativeClassPtr, 100667428);
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x000909AC File Offset: 0x0008EBAC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 310854, RefRangeEnd = 310863, XrefRangeStart = 310853, XrefRangeEnd = 310854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Encoding()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x000909E8 File Offset: 0x0008EBE8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 310870, RefRangeEnd = 310883, XrefRangeStart = 310863, XrefRangeEnd = 310870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Encoding(int codePage)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codePage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x00090A30 File Offset: 0x0008EC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310883, XrefRangeEnd = 310891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetDefaultFallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00090A6C File Offset: 0x0008EC6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310891, RefRangeEnd = 310892, XrefRangeStart = 310891, XrefRangeEnd = 310891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_OnDeserializing_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00090AA0 File Offset: 0x0008ECA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310892, RefRangeEnd = 310893, XrefRangeStart = 310892, XrefRangeEnd = 310892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_OnDeserialized_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00090AD4 File Offset: 0x0008ECD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310891, RefRangeEnd = 310892, XrefRangeStart = 310891, XrefRangeEnd = 310892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00090B1C File Offset: 0x0008ED1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310892, RefRangeEnd = 310893, XrefRangeStart = 310892, XrefRangeEnd = 310893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x00090B64 File Offset: 0x0008ED64
		[CallerCount(0)]
		public unsafe void OnSerializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x00090BAC File Offset: 0x0008EDAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310934, RefRangeEnd = 310935, XrefRangeStart = 310893, XrefRangeEnd = 310934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeserializeEncoding(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_DeserializeEncoding_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00090C08 File Offset: 0x0008EE08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310962, RefRangeEnd = 310963, XrefRangeStart = 310935, XrefRangeEnd = 310962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeEncoding(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_SerializeEncoding_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060018A0 RID: 6304 RVA: 0x00090C64 File Offset: 0x0008EE64
		public unsafe static Object InternalSyncObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310963, XrefRangeEnd = 310972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00090C98 File Offset: 0x0008EE98
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 311035, RefRangeEnd = 311040, XrefRangeStart = 310972, XrefRangeEnd = 311035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncoding(int codepage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00090CD8 File Offset: 0x0008EED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311040, XrefRangeEnd = 311057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codepage;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoderFallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decoderFallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00090D3C File Offset: 0x0008EF3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 311090, RefRangeEnd = 311094, XrefRangeStart = 311057, XrefRangeEnd = 311090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding GetEncoding(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x00090D80 File Offset: 0x0008EF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311094, XrefRangeEnd = 311098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetPreamble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetPreamble_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x00090DCC File Offset: 0x0008EFCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311102, RefRangeEnd = 311104, XrefRangeStart = 311098, XrefRangeEnd = 311102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDataItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_GetDataItem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060018A6 RID: 6310 RVA: 0x00090E00 File Offset: 0x0008F000
		public unsafe virtual string EncodingName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311104, XrefRangeEnd = 311105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_get_EncodingName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x00090E44 File Offset: 0x0008F044
		public unsafe virtual string HeaderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311105, XrefRangeEnd = 311108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_get_HeaderName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x00090E88 File Offset: 0x0008F088
		public unsafe virtual string WebName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311108, XrefRangeEnd = 311111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_get_WebName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x00090ECC File Offset: 0x0008F0CC
		// (set) Token: 0x060018AA RID: 6314 RVA: 0x00090F0C File Offset: 0x0008F10C
		public unsafe EncoderFallback EncoderFallback
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_EncoderFallback_Public_get_EncoderFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311111, RefRangeEnd = 311113, XrefRangeStart = 311111, XrefRangeEnd = 311111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_set_EncoderFallback_Public_set_Void_EncoderFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x00090F50 File Offset: 0x0008F150
		// (set) Token: 0x060018AC RID: 6316 RVA: 0x00090F90 File Offset: 0x0008F190
		public unsafe DecoderFallback DecoderFallback
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_DecoderFallback_Public_get_DecoderFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311113, RefRangeEnd = 311115, XrefRangeStart = 311113, XrefRangeEnd = 311113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_set_DecoderFallback_Public_set_Void_DecoderFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00090FD4 File Offset: 0x0008F1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311115, XrefRangeEnd = 311118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x00091020 File Offset: 0x0008F220
		public unsafe bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060018AF RID: 6319 RVA: 0x0009105C File Offset: 0x0008F25C
		public unsafe static Encoding ASCII
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 311129, RefRangeEnd = 311179, XrefRangeStart = 311118, XrefRangeEnd = 311129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_ASCII_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x00091090 File Offset: 0x0008F290
		public unsafe static Encoding Latin1
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311179, XrefRangeEnd = 311190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_Latin1_Private_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x000910C4 File Offset: 0x0008F2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311190, XrefRangeEnd = 311191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetByteCount(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0009111C File Offset: 0x0008F31C
		[CallerCount(0)]
		public unsafe virtual int GetByteCount(Il2CppStructArray<char> chars, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetByteCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00091190 File Offset: 0x0008F390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311191, XrefRangeEnd = 311194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetByteCount(char* chars, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_ptr_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x000911F4 File Offset: 0x0008F3F4
		[CallerCount(0)]
		public unsafe virtual int GetByteCount(char* chars, int count, EncoderNLS encoder)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetByteCount_Internal_Virtual_New_Int32_ptr_Char_Int32_EncoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00091268 File Offset: 0x0008F468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311194, XrefRangeEnd = 311197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetBytes(Il2CppStructArray<char> chars, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x000912E0 File Offset: 0x0008F4E0
		[CallerCount(0)]
		public unsafe virtual int GetBytes(Il2CppStructArray<char> chars, int charIndex, int charCount, Il2CppStructArray<byte> bytes, int byteIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x00091378 File Offset: 0x0008F578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311197, XrefRangeEnd = 311200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetBytes(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x000913D4 File Offset: 0x0008F5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311200, XrefRangeEnd = 311207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetBytes(string s, int charIndex, int charCount, Il2CppStructArray<byte> bytes, int byteIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x0009146C File Offset: 0x0008F66C
		[CallerCount(0)]
		public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBytes_Internal_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x000914FC File Offset: 0x0008F6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311207, XrefRangeEnd = 311213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x00091578 File Offset: 0x0008F778
		[CallerCount(0)]
		public unsafe virtual int GetCharCount(Il2CppStructArray<byte> bytes, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetCharCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x000915EC File Offset: 0x0008F7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311213, XrefRangeEnd = 311216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetCharCount(byte* bytes, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_New_Int32_ptr_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00091650 File Offset: 0x0008F850
		[CallerCount(0)]
		public unsafe virtual int GetCharCount(byte* bytes, int count, DecoderNLS decoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decoder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetCharCount_Internal_Virtual_New_Int32_ptr_Byte_Int32_DecoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x000916C4 File Offset: 0x0008F8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311216, XrefRangeEnd = 311219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<char> GetChars(Il2CppStructArray<byte> bytes, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_New_Il2CppStructArray_1_Char_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x0009173C File Offset: 0x0008F93C
		[CallerCount(0)]
		public unsafe virtual int GetChars(Il2CppStructArray<byte> bytes, int byteIndex, int byteCount, Il2CppStructArray<char> chars, int charIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetChars_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x000917D4 File Offset: 0x0008F9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311219, XrefRangeEnd = 311225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00091850 File Offset: 0x0008FA50
		[CallerCount(0)]
		public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
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
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decoder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetChars_Internal_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060018C2 RID: 6338 RVA: 0x000918E0 File Offset: 0x0008FAE0
		public unsafe virtual int CodePage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_get_CodePage_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00091928 File Offset: 0x0008FB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311225, XrefRangeEnd = 311229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Decoder GetDecoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetDecoder_Public_Virtual_New_Decoder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Decoder>(intPtr3) : null;
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00091974 File Offset: 0x0008FB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311229, XrefRangeEnd = 311233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Encoding CreateDefaultEncoding()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_CreateDefaultEncoding_Private_Static_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x000919A8 File Offset: 0x0008FBA8
		[CallerCount(0)]
		public unsafe void setReadOnly(bool value = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_setReadOnly_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060018C6 RID: 6342 RVA: 0x000919E8 File Offset: 0x0008FBE8
		public unsafe static Encoding Default
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 311244, RefRangeEnd = 311250, XrefRangeStart = 311233, XrefRangeEnd = 311244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_Default_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x00091A1C File Offset: 0x0008FC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311250, XrefRangeEnd = 311254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Encoder GetEncoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetEncoder_Public_Virtual_New_Encoder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoder>(intPtr3) : null;
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x00091A68 File Offset: 0x0008FC68
		[CallerCount(0)]
		public unsafe virtual int GetMaxByteCount(int charCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetMaxByteCount_Public_Abstract_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x00091ABC File Offset: 0x0008FCBC
		[CallerCount(0)]
		public unsafe virtual int GetMaxCharCount(int byteCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref byteCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetMaxCharCount_Public_Abstract_Virtual_New_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x00091B10 File Offset: 0x0008FD10
		[CallerCount(0)]
		public unsafe virtual string GetString(Il2CppStructArray<byte> bytes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x00091B64 File Offset: 0x0008FD64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311254, XrefRangeEnd = 311255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetString(Il2CppStructArray<byte> bytes, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetString_Public_Virtual_New_String_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x00091BD4 File Offset: 0x0008FDD4
		public unsafe static Encoding Unicode
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 311266, RefRangeEnd = 311287, XrefRangeStart = 311255, XrefRangeEnd = 311266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_Unicode_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x00091C08 File Offset: 0x0008FE08
		public unsafe static Encoding BigEndianUnicode
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 311298, RefRangeEnd = 311302, XrefRangeStart = 311287, XrefRangeEnd = 311298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_BigEndianUnicode_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x00091C3C File Offset: 0x0008FE3C
		public unsafe static Encoding UTF7
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311313, RefRangeEnd = 311315, XrefRangeStart = 311302, XrefRangeEnd = 311313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_UTF7_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x060018CF RID: 6351 RVA: 0x00091C70 File Offset: 0x0008FE70
		public unsafe static Encoding UTF8
		{
			[CallerCount(80)]
			[CachedScanResults(RefRangeStart = 311326, RefRangeEnd = 311406, XrefRangeStart = 311315, XrefRangeEnd = 311326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_UTF8_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x00091CA4 File Offset: 0x0008FEA4
		public unsafe static Encoding UTF32
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311406, XrefRangeEnd = 311417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_get_UTF32_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x00091CD8 File Offset: 0x0008FED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311417, XrefRangeEnd = 311419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00091D30 File Offset: 0x0008FF30
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00091D78 File Offset: 0x0008FF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311419, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<char> GetBestFitUnicodeToBytesData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBestFitUnicodeToBytesData_Internal_Virtual_New_Il2CppStructArray_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x00091DC4 File Offset: 0x0008FFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311423, XrefRangeEnd = 311427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<char> GetBestFitBytesToUnicodeData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.NativeMethodInfoPtr_GetBestFitBytesToUnicodeData_Internal_Virtual_New_Il2CppStructArray_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00091E10 File Offset: 0x00090010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311427, XrefRangeEnd = 311447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowBytesOverflow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_ThrowBytesOverflow_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x00091E44 File Offset: 0x00090044
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 311448, RefRangeEnd = 311461, XrefRangeStart = 311447, XrefRangeEnd = 311448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nothingEncoded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_ThrowBytesOverflow_Internal_Void_EncoderNLS_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x00091E94 File Offset: 0x00090094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311461, XrefRangeEnd = 311481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowCharsOverflow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_ThrowCharsOverflow_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00091EC8 File Offset: 0x000900C8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 311482, RefRangeEnd = 311489, XrefRangeStart = 311481, XrefRangeEnd = 311482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(decoder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nothingDecoded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.NativeMethodInfoPtr_ThrowCharsOverflow_Internal_Void_DecoderNLS_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00008A53 File Offset: 0x00006C53
		public Encoding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x00091F18 File Offset: 0x00090118
		// (set) Token: 0x060018DB RID: 6363 RVA: 0x00008A5C File Offset: 0x00006C5C
		public unsafe static Encoding defaultEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_defaultEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_defaultEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x00091F40 File Offset: 0x00090140
		// (set) Token: 0x060018DD RID: 6365 RVA: 0x00008A6E File Offset: 0x00006C6E
		public unsafe static Encoding unicodeEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_unicodeEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_unicodeEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060018DE RID: 6366 RVA: 0x00091F68 File Offset: 0x00090168
		// (set) Token: 0x060018DF RID: 6367 RVA: 0x00008A80 File Offset: 0x00006C80
		public unsafe static Encoding bigEndianUnicode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_bigEndianUnicode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_bigEndianUnicode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060018E0 RID: 6368 RVA: 0x00091F90 File Offset: 0x00090190
		// (set) Token: 0x060018E1 RID: 6369 RVA: 0x00008A92 File Offset: 0x00006C92
		public unsafe static Encoding utf7Encoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_utf7Encoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_utf7Encoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060018E2 RID: 6370 RVA: 0x00091FB8 File Offset: 0x000901B8
		// (set) Token: 0x060018E3 RID: 6371 RVA: 0x00008AA4 File Offset: 0x00006CA4
		public unsafe static Encoding utf8Encoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_utf8Encoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_utf8Encoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060018E4 RID: 6372 RVA: 0x00091FE0 File Offset: 0x000901E0
		// (set) Token: 0x060018E5 RID: 6373 RVA: 0x00008AB6 File Offset: 0x00006CB6
		public unsafe static Encoding utf32Encoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_utf32Encoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_utf32Encoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060018E6 RID: 6374 RVA: 0x00092008 File Offset: 0x00090208
		// (set) Token: 0x060018E7 RID: 6375 RVA: 0x00008AC8 File Offset: 0x00006CC8
		public unsafe static Encoding asciiEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_asciiEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_asciiEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x00092030 File Offset: 0x00090230
		// (set) Token: 0x060018E9 RID: 6377 RVA: 0x00008ADA File Offset: 0x00006CDA
		public unsafe static Encoding latin1Encoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_latin1Encoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_latin1Encoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x00092058 File Offset: 0x00090258
		// (set) Token: 0x060018EB RID: 6379 RVA: 0x00008AEC File Offset: 0x00006CEC
		public unsafe static Hashtable encodings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_encodings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_encodings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x00092080 File Offset: 0x00090280
		// (set) Token: 0x060018ED RID: 6381 RVA: 0x00008AFE File Offset: 0x00006CFE
		public unsafe int m_codePage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_m_codePage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_m_codePage)) = value;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x000920A8 File Offset: 0x000902A8
		// (set) Token: 0x060018EF RID: 6383 RVA: 0x00008B19 File Offset: 0x00006D19
		public unsafe CodePageDataItem dataItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_dataItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePageDataItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_dataItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x000920D8 File Offset: 0x000902D8
		// (set) Token: 0x060018F1 RID: 6385 RVA: 0x00008B38 File Offset: 0x00006D38
		public unsafe bool m_deserializedFromEverett
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_m_deserializedFromEverett);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_m_deserializedFromEverett)) = value;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x00092100 File Offset: 0x00090300
		// (set) Token: 0x060018F3 RID: 6387 RVA: 0x00008B53 File Offset: 0x00006D53
		public unsafe bool m_isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_m_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_m_isReadOnly)) = value;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x00092128 File Offset: 0x00090328
		// (set) Token: 0x060018F5 RID: 6389 RVA: 0x00008B6E File Offset: 0x00006D6E
		public unsafe EncoderFallback encoderFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_encoderFallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_encoderFallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x00092158 File Offset: 0x00090358
		// (set) Token: 0x060018F7 RID: 6391 RVA: 0x00008B8D File Offset: 0x00006D8D
		public unsafe DecoderFallback decoderFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_decoderFallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.NativeFieldInfoPtr_decoderFallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x00092188 File Offset: 0x00090388
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x00008BAC File Offset: 0x00006DAC
		public unsafe static Object s_InternalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Encoding.NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Encoding.NativeFieldInfoPtr_s_InternalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001684 RID: 5764
		private static readonly IntPtr NativeFieldInfoPtr_defaultEncoding;

		// Token: 0x04001685 RID: 5765
		private static readonly IntPtr NativeFieldInfoPtr_unicodeEncoding;

		// Token: 0x04001686 RID: 5766
		private static readonly IntPtr NativeFieldInfoPtr_bigEndianUnicode;

		// Token: 0x04001687 RID: 5767
		private static readonly IntPtr NativeFieldInfoPtr_utf7Encoding;

		// Token: 0x04001688 RID: 5768
		private static readonly IntPtr NativeFieldInfoPtr_utf8Encoding;

		// Token: 0x04001689 RID: 5769
		private static readonly IntPtr NativeFieldInfoPtr_utf32Encoding;

		// Token: 0x0400168A RID: 5770
		private static readonly IntPtr NativeFieldInfoPtr_asciiEncoding;

		// Token: 0x0400168B RID: 5771
		private static readonly IntPtr NativeFieldInfoPtr_latin1Encoding;

		// Token: 0x0400168C RID: 5772
		private static readonly IntPtr NativeFieldInfoPtr_encodings;

		// Token: 0x0400168D RID: 5773
		private static readonly IntPtr NativeFieldInfoPtr_m_codePage;

		// Token: 0x0400168E RID: 5774
		private static readonly IntPtr NativeFieldInfoPtr_dataItem;

		// Token: 0x0400168F RID: 5775
		private static readonly IntPtr NativeFieldInfoPtr_m_deserializedFromEverett;

		// Token: 0x04001690 RID: 5776
		private static readonly IntPtr NativeFieldInfoPtr_m_isReadOnly;

		// Token: 0x04001691 RID: 5777
		private static readonly IntPtr NativeFieldInfoPtr_encoderFallback;

		// Token: 0x04001692 RID: 5778
		private static readonly IntPtr NativeFieldInfoPtr_decoderFallback;

		// Token: 0x04001693 RID: 5779
		private static readonly IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

		// Token: 0x04001694 RID: 5780
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001695 RID: 5781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Int32_0;

		// Token: 0x04001696 RID: 5782
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_New_Void_0;

		// Token: 0x04001697 RID: 5783
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Internal_Void_0;

		// Token: 0x04001698 RID: 5784
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Internal_Void_0;

		// Token: 0x04001699 RID: 5785
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0;

		// Token: 0x0400169A RID: 5786
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x0400169B RID: 5787
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0;

		// Token: 0x0400169C RID: 5788
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeEncoding_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400169D RID: 5789
		private static readonly IntPtr NativeMethodInfoPtr_SerializeEncoding_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400169E RID: 5790
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSyncObject_Private_Static_get_Object_0;

		// Token: 0x0400169F RID: 5791
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_Int32_0;

		// Token: 0x040016A0 RID: 5792
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0;

		// Token: 0x040016A1 RID: 5793
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoding_Public_Static_Encoding_String_0;

		// Token: 0x040016A2 RID: 5794
		private static readonly IntPtr NativeMethodInfoPtr_GetPreamble_Public_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x040016A3 RID: 5795
		private static readonly IntPtr NativeMethodInfoPtr_GetDataItem_Private_Void_0;

		// Token: 0x040016A4 RID: 5796
		private static readonly IntPtr NativeMethodInfoPtr_get_EncodingName_Public_Virtual_New_get_String_0;

		// Token: 0x040016A5 RID: 5797
		private static readonly IntPtr NativeMethodInfoPtr_get_HeaderName_Public_Virtual_New_get_String_0;

		// Token: 0x040016A6 RID: 5798
		private static readonly IntPtr NativeMethodInfoPtr_get_WebName_Public_Virtual_New_get_String_0;

		// Token: 0x040016A7 RID: 5799
		private static readonly IntPtr NativeMethodInfoPtr_get_EncoderFallback_Public_get_EncoderFallback_0;

		// Token: 0x040016A8 RID: 5800
		private static readonly IntPtr NativeMethodInfoPtr_set_EncoderFallback_Public_set_Void_EncoderFallback_0;

		// Token: 0x040016A9 RID: 5801
		private static readonly IntPtr NativeMethodInfoPtr_get_DecoderFallback_Public_get_DecoderFallback_0;

		// Token: 0x040016AA RID: 5802
		private static readonly IntPtr NativeMethodInfoPtr_set_DecoderFallback_Public_set_Void_DecoderFallback_0;

		// Token: 0x040016AB RID: 5803
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x040016AC RID: 5804
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0;

		// Token: 0x040016AD RID: 5805
		private static readonly IntPtr NativeMethodInfoPtr_get_ASCII_Public_Static_get_Encoding_0;

		// Token: 0x040016AE RID: 5806
		private static readonly IntPtr NativeMethodInfoPtr_get_Latin1_Private_Static_get_Encoding_0;

		// Token: 0x040016AF RID: 5807
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_String_0;

		// Token: 0x040016B0 RID: 5808
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040016B1 RID: 5809
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_ptr_Char_Int32_0;

		// Token: 0x040016B2 RID: 5810
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Internal_Virtual_New_Int32_ptr_Char_Int32_EncoderNLS_0;

		// Token: 0x040016B3 RID: 5811
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040016B4 RID: 5812
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040016B5 RID: 5813
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x040016B6 RID: 5814
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040016B7 RID: 5815
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Internal_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0;

		// Token: 0x040016B8 RID: 5816
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_0;

		// Token: 0x040016B9 RID: 5817
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040016BA RID: 5818
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_New_Int32_ptr_Byte_Int32_0;

		// Token: 0x040016BB RID: 5819
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Internal_Virtual_New_Int32_ptr_Byte_Int32_DecoderNLS_0;

		// Token: 0x040016BC RID: 5820
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_New_Il2CppStructArray_1_Char_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040016BD RID: 5821
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x040016BE RID: 5822
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_0;

		// Token: 0x040016BF RID: 5823
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Internal_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0;

		// Token: 0x040016C0 RID: 5824
		private static readonly IntPtr NativeMethodInfoPtr_get_CodePage_Public_Virtual_New_get_Int32_0;

		// Token: 0x040016C1 RID: 5825
		private static readonly IntPtr NativeMethodInfoPtr_GetDecoder_Public_Virtual_New_Decoder_0;

		// Token: 0x040016C2 RID: 5826
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultEncoding_Private_Static_Encoding_0;

		// Token: 0x040016C3 RID: 5827
		private static readonly IntPtr NativeMethodInfoPtr_setReadOnly_Internal_Void_Boolean_0;

		// Token: 0x040016C4 RID: 5828
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_Encoding_0;

		// Token: 0x040016C5 RID: 5829
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoder_Public_Virtual_New_Encoder_0;

		// Token: 0x040016C6 RID: 5830
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxByteCount_Public_Abstract_Virtual_New_Int32_Int32_0;

		// Token: 0x040016C7 RID: 5831
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxCharCount_Public_Abstract_Virtual_New_Int32_Int32_0;

		// Token: 0x040016C8 RID: 5832
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_New_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x040016C9 RID: 5833
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_New_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040016CA RID: 5834
		private static readonly IntPtr NativeMethodInfoPtr_get_Unicode_Public_Static_get_Encoding_0;

		// Token: 0x040016CB RID: 5835
		private static readonly IntPtr NativeMethodInfoPtr_get_BigEndianUnicode_Public_Static_get_Encoding_0;

		// Token: 0x040016CC RID: 5836
		private static readonly IntPtr NativeMethodInfoPtr_get_UTF7_Public_Static_get_Encoding_0;

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeMethodInfoPtr_get_UTF8_Public_Static_get_Encoding_0;

		// Token: 0x040016CE RID: 5838
		private static readonly IntPtr NativeMethodInfoPtr_get_UTF32_Public_Static_get_Encoding_0;

		// Token: 0x040016CF RID: 5839
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040016D0 RID: 5840
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040016D1 RID: 5841
		private static readonly IntPtr NativeMethodInfoPtr_GetBestFitUnicodeToBytesData_Internal_Virtual_New_Il2CppStructArray_1_Char_0;

		// Token: 0x040016D2 RID: 5842
		private static readonly IntPtr NativeMethodInfoPtr_GetBestFitBytesToUnicodeData_Internal_Virtual_New_Il2CppStructArray_1_Char_0;

		// Token: 0x040016D3 RID: 5843
		private static readonly IntPtr NativeMethodInfoPtr_ThrowBytesOverflow_Internal_Void_0;

		// Token: 0x040016D4 RID: 5844
		private static readonly IntPtr NativeMethodInfoPtr_ThrowBytesOverflow_Internal_Void_EncoderNLS_Boolean_0;

		// Token: 0x040016D5 RID: 5845
		private static readonly IntPtr NativeMethodInfoPtr_ThrowCharsOverflow_Internal_Void_0;

		// Token: 0x040016D6 RID: 5846
		private static readonly IntPtr NativeMethodInfoPtr_ThrowCharsOverflow_Internal_Void_DecoderNLS_Boolean_0;

		// Token: 0x020005B2 RID: 1458
		[Serializable]
		public class DefaultEncoder : Encoder
		{
			// Token: 0x06005016 RID: 20502 RVA: 0x00167340 File Offset: 0x00165540
			// Note: this type is marked as 'beforefieldinit'.
			static DefaultEncoder()
			{
				Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "DefaultEncoder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr);
				Encoding.DefaultEncoder.NativeFieldInfoPtr_m_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, "m_encoding");
				Encoding.DefaultEncoder.NativeFieldInfoPtr_m_hasInitializedEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, "m_hasInitializedEncoding");
				Encoding.DefaultEncoder.NativeFieldInfoPtr_charLeftOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, "charLeftOver");
				Encoding.DefaultEncoder.NativeMethodInfoPtr__ctor_Public_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100667429);
				Encoding.DefaultEncoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100667430);
				Encoding.DefaultEncoder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100667431);
				Encoding.DefaultEncoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100667432);
				Encoding.DefaultEncoder.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100667433);
				Encoding.DefaultEncoder.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100667434);
				Encoding.DefaultEncoder.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100667435);
				Encoding.DefaultEncoder.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr, 100667436);
			}

			// Token: 0x06005017 RID: 20503 RVA: 0x00167448 File Offset: 0x00165648
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 310695, RefRangeEnd = 310697, XrefRangeStart = 310694, XrefRangeEnd = 310695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DefaultEncoder(Encoding encoding)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultEncoder.NativeMethodInfoPtr__ctor_Public_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005018 RID: 20504 RVA: 0x00167494 File Offset: 0x00165694
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310697, XrefRangeEnd = 310730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DefaultEncoder(SerializationInfo info, StreamingContext context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding.DefaultEncoder>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultEncoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005019 RID: 20505 RVA: 0x001674F8 File Offset: 0x001656F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310730, XrefRangeEnd = 310732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object GetRealObject(StreamingContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultEncoder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600501A RID: 20506 RVA: 0x00167550 File Offset: 0x00165750
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310732, XrefRangeEnd = 310741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultEncoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600501B RID: 20507 RVA: 0x001675AC File Offset: 0x001657AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310741, XrefRangeEnd = 310742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetByteCount(Il2CppStructArray<char> chars, int index, int count, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultEncoder.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600501C RID: 20508 RVA: 0x00167630 File Offset: 0x00165830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310742, XrefRangeEnd = 310743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetByteCount(char* chars, int count, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = chars;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultEncoder.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600501D RID: 20509 RVA: 0x001676A0 File Offset: 0x001658A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310743, XrefRangeEnd = 310744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetBytes(Il2CppStructArray<char> chars, int charIndex, int charCount, Il2CppStructArray<byte> bytes, int byteIndex, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultEncoder.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600501E RID: 20510 RVA: 0x00167744 File Offset: 0x00165944
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310744, XrefRangeEnd = 310745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
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
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultEncoder.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600501F RID: 20511 RVA: 0x0001E767 File Offset: 0x0001C967
			public DefaultEncoder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700146B RID: 5227
			// (get) Token: 0x06005020 RID: 20512 RVA: 0x001677D0 File Offset: 0x001659D0
			// (set) Token: 0x06005021 RID: 20513 RVA: 0x0001E770 File Offset: 0x0001C970
			public unsafe Encoding m_encoding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultEncoder.NativeFieldInfoPtr_m_encoding);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultEncoder.NativeFieldInfoPtr_m_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700146C RID: 5228
			// (get) Token: 0x06005022 RID: 20514 RVA: 0x00167800 File Offset: 0x00165A00
			// (set) Token: 0x06005023 RID: 20515 RVA: 0x0001E78F File Offset: 0x0001C98F
			public unsafe bool m_hasInitializedEncoding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultEncoder.NativeFieldInfoPtr_m_hasInitializedEncoding);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultEncoder.NativeFieldInfoPtr_m_hasInitializedEncoding)) = value;
				}
			}

			// Token: 0x1700146D RID: 5229
			// (get) Token: 0x06005024 RID: 20516 RVA: 0x00167828 File Offset: 0x00165A28
			// (set) Token: 0x06005025 RID: 20517 RVA: 0x0001E7AA File Offset: 0x0001C9AA
			public unsafe char charLeftOver
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultEncoder.NativeFieldInfoPtr_charLeftOver);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultEncoder.NativeFieldInfoPtr_charLeftOver)) = value;
				}
			}

			// Token: 0x04004122 RID: 16674
			private static readonly IntPtr NativeFieldInfoPtr_m_encoding;

			// Token: 0x04004123 RID: 16675
			private static readonly IntPtr NativeFieldInfoPtr_m_hasInitializedEncoding;

			// Token: 0x04004124 RID: 16676
			private static readonly IntPtr NativeFieldInfoPtr_charLeftOver;

			// Token: 0x04004125 RID: 16677
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Encoding_0;

			// Token: 0x04004126 RID: 16678
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004127 RID: 16679
			private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0;

			// Token: 0x04004128 RID: 16680
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004129 RID: 16681
			private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_0;

			// Token: 0x0400412A RID: 16682
			private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_Boolean_0;

			// Token: 0x0400412B RID: 16683
			private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_0;

			// Token: 0x0400412C RID: 16684
			private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_Boolean_0;
		}

		// Token: 0x020005B3 RID: 1459
		[Serializable]
		public class DefaultDecoder : Decoder
		{
			// Token: 0x06005026 RID: 20518 RVA: 0x00167850 File Offset: 0x00165A50
			// Note: this type is marked as 'beforefieldinit'.
			static DefaultDecoder()
			{
				Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "DefaultDecoder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr);
				Encoding.DefaultDecoder.NativeFieldInfoPtr_m_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, "m_encoding");
				Encoding.DefaultDecoder.NativeFieldInfoPtr_m_hasInitializedEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, "m_hasInitializedEncoding");
				Encoding.DefaultDecoder.NativeMethodInfoPtr__ctor_Public_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667437);
				Encoding.DefaultDecoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667438);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667439);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667440);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667441);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667442);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667443);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667444);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667445);
				Encoding.DefaultDecoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr, 100667446);
			}

			// Token: 0x06005027 RID: 20519 RVA: 0x0016796C File Offset: 0x00165B6C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 310695, RefRangeEnd = 310697, XrefRangeStart = 310695, XrefRangeEnd = 310697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DefaultDecoder(Encoding encoding)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultDecoder.NativeMethodInfoPtr__ctor_Public_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005028 RID: 20520 RVA: 0x001679B8 File Offset: 0x00165BB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310745, XrefRangeEnd = 310769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DefaultDecoder(SerializationInfo info, StreamingContext context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding.DefaultDecoder>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultDecoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005029 RID: 20521 RVA: 0x00167A1C File Offset: 0x00165C1C
			[CallerCount(0)]
			public unsafe virtual Object GetRealObject(StreamingContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultDecoder.NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600502A RID: 20522 RVA: 0x00167A74 File Offset: 0x00165C74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310769, XrefRangeEnd = 310778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.DefaultDecoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600502B RID: 20523 RVA: 0x00167AD0 File Offset: 0x00165CD0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultDecoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600502C RID: 20524 RVA: 0x00167B44 File Offset: 0x00165D44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310778, XrefRangeEnd = 310779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultDecoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600502D RID: 20525 RVA: 0x00167BC8 File Offset: 0x00165DC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310779, XrefRangeEnd = 310780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetCharCount(byte* bytes, int count, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = bytes;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultDecoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600502E RID: 20526 RVA: 0x00167C38 File Offset: 0x00165E38
			[CallerCount(0)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultDecoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600502F RID: 20527 RVA: 0x00167CD0 File Offset: 0x00165ED0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310780, XrefRangeEnd = 310781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetChars(Il2CppStructArray<byte> bytes, int byteIndex, int byteCount, Il2CppStructArray<char> chars, int charIndex, bool flush)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chars);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultDecoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005030 RID: 20528 RVA: 0x00167D74 File Offset: 0x00165F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310781, XrefRangeEnd = 310782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
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
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoding.DefaultDecoder.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005031 RID: 20529 RVA: 0x0001E7C5 File Offset: 0x0001C9C5
			public DefaultDecoder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700146E RID: 5230
			// (get) Token: 0x06005032 RID: 20530 RVA: 0x00167E00 File Offset: 0x00166000
			// (set) Token: 0x06005033 RID: 20531 RVA: 0x0001E7CE File Offset: 0x0001C9CE
			public unsafe Encoding m_encoding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultDecoder.NativeFieldInfoPtr_m_encoding);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultDecoder.NativeFieldInfoPtr_m_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700146F RID: 5231
			// (get) Token: 0x06005034 RID: 20532 RVA: 0x00167E30 File Offset: 0x00166030
			// (set) Token: 0x06005035 RID: 20533 RVA: 0x0001E7ED File Offset: 0x0001C9ED
			public unsafe bool m_hasInitializedEncoding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultDecoder.NativeFieldInfoPtr_m_hasInitializedEncoding);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.DefaultDecoder.NativeFieldInfoPtr_m_hasInitializedEncoding)) = value;
				}
			}

			// Token: 0x0400412D RID: 16685
			private static readonly IntPtr NativeFieldInfoPtr_m_encoding;

			// Token: 0x0400412E RID: 16686
			private static readonly IntPtr NativeFieldInfoPtr_m_hasInitializedEncoding;

			// Token: 0x0400412F RID: 16687
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Encoding_0;

			// Token: 0x04004130 RID: 16688
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004131 RID: 16689
			private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_Final_New_Object_StreamingContext_0;

			// Token: 0x04004132 RID: 16690
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004133 RID: 16691
			private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x04004134 RID: 16692
			private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0;

			// Token: 0x04004135 RID: 16693
			private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_Boolean_0;

			// Token: 0x04004136 RID: 16694
			private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

			// Token: 0x04004137 RID: 16695
			private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Boolean_0;

			// Token: 0x04004138 RID: 16696
			private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_Boolean_0;
		}

		// Token: 0x020005B4 RID: 1460
		public class EncodingCharBuffer : Object
		{
			// Token: 0x06005036 RID: 20534 RVA: 0x00167E58 File Offset: 0x00166058
			// Note: this type is marked as 'beforefieldinit'.
			static EncodingCharBuffer()
			{
				Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "EncodingCharBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr);
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "chars");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "charStart");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "charEnd");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charCountResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "charCountResult");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_enc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "enc");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "decoder");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_byteStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "byteStart");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_byteEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "byteEnd");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "bytes");
				Encoding.EncodingCharBuffer.NativeFieldInfoPtr_fallbackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, "fallbackBuffer");
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_DecoderNLS_ptr_Char_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667447);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_AddChar_Internal_Boolean_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667448);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_AddChar_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667449);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_AdjustBytes_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667450);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_get_MoreData_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667451);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_GetNextByte_Internal_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667452);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_get_BytesUsed_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667453);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_Fallback_Internal_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667454);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_Fallback_Internal_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667455);
				Encoding.EncodingCharBuffer.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr, 100667456);
			}

			// Token: 0x06005037 RID: 20535 RVA: 0x00168014 File Offset: 0x00166214
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 310787, RefRangeEnd = 310788, XrefRangeStart = 310782, XrefRangeEnd = 310787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EncodingCharBuffer(Encoding enc, DecoderNLS decoder, char* charStart, int charCount, byte* byteStart, int byteCount)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding.EncodingCharBuffer>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(enc);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(decoder);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = charStart;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = byteStart;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_DecoderNLS_ptr_Char_Int32_ptr_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005038 RID: 20536 RVA: 0x001680A8 File Offset: 0x001662A8
			[CallerCount(0)]
			public unsafe bool AddChar(char ch, int numBytes)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ch;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numBytes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_AddChar_Internal_Boolean_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005039 RID: 20537 RVA: 0x00168100 File Offset: 0x00166300
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 310788, RefRangeEnd = 310790, XrefRangeStart = 310788, XrefRangeEnd = 310788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AddChar(char ch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ch;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_AddChar_Internal_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600503A RID: 20538 RVA: 0x0016814C File Offset: 0x0016634C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 310790, RefRangeEnd = 310791, XrefRangeStart = 310790, XrefRangeEnd = 310790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AdjustBytes(int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref count;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_AdjustBytes_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x1700147A RID: 5242
			// (get) Token: 0x0600503B RID: 20539 RVA: 0x0016818C File Offset: 0x0016638C
			public unsafe bool MoreData
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 310791, RefRangeEnd = 310792, XrefRangeStart = 310791, XrefRangeEnd = 310791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_get_MoreData_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600503C RID: 20540 RVA: 0x001681C8 File Offset: 0x001663C8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 310792, RefRangeEnd = 310793, XrefRangeStart = 310792, XrefRangeEnd = 310792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe byte GetNextByte()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_GetNextByte_Internal_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700147B RID: 5243
			// (get) Token: 0x0600503D RID: 20541 RVA: 0x00168204 File Offset: 0x00166404
			public unsafe int BytesUsed
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 310793, RefRangeEnd = 310794, XrefRangeStart = 310793, XrefRangeEnd = 310793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_get_BytesUsed_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600503E RID: 20542 RVA: 0x00168240 File Offset: 0x00166440
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 310798, RefRangeEnd = 310799, XrefRangeStart = 310794, XrefRangeEnd = 310798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Fallback(byte fallbackByte)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref fallbackByte;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_Fallback_Internal_Boolean_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600503F RID: 20543 RVA: 0x0016828C File Offset: 0x0016648C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310799, XrefRangeEnd = 310800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Fallback(Il2CppStructArray<byte> byteBuffer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(byteBuffer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_Fallback_Internal_Boolean_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700147C RID: 5244
			// (get) Token: 0x06005040 RID: 20544 RVA: 0x001682DC File Offset: 0x001664DC
			public unsafe int Count
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingCharBuffer.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005041 RID: 20545 RVA: 0x0001E808 File Offset: 0x0001CA08
			public EncodingCharBuffer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001470 RID: 5232
			// (get) Token: 0x06005042 RID: 20546 RVA: 0x00168318 File Offset: 0x00166518
			// (set) Token: 0x06005043 RID: 20547 RVA: 0x0001E811 File Offset: 0x0001CA11
			public unsafe char* chars
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_chars);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_chars)) = value;
				}
			}

			// Token: 0x17001471 RID: 5233
			// (get) Token: 0x06005044 RID: 20548 RVA: 0x0016833C File Offset: 0x0016653C
			// (set) Token: 0x06005045 RID: 20549 RVA: 0x0001E82C File Offset: 0x0001CA2C
			public unsafe char* charStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charStart)) = value;
				}
			}

			// Token: 0x17001472 RID: 5234
			// (get) Token: 0x06005046 RID: 20550 RVA: 0x00168360 File Offset: 0x00166560
			// (set) Token: 0x06005047 RID: 20551 RVA: 0x0001E847 File Offset: 0x0001CA47
			public unsafe char* charEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charEnd)) = value;
				}
			}

			// Token: 0x17001473 RID: 5235
			// (get) Token: 0x06005048 RID: 20552 RVA: 0x00168384 File Offset: 0x00166584
			// (set) Token: 0x06005049 RID: 20553 RVA: 0x0001E862 File Offset: 0x0001CA62
			public unsafe int charCountResult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charCountResult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_charCountResult)) = value;
				}
			}

			// Token: 0x17001474 RID: 5236
			// (get) Token: 0x0600504A RID: 20554 RVA: 0x001683AC File Offset: 0x001665AC
			// (set) Token: 0x0600504B RID: 20555 RVA: 0x0001E87D File Offset: 0x0001CA7D
			public unsafe Encoding enc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_enc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_enc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001475 RID: 5237
			// (get) Token: 0x0600504C RID: 20556 RVA: 0x001683DC File Offset: 0x001665DC
			// (set) Token: 0x0600504D RID: 20557 RVA: 0x0001E89C File Offset: 0x0001CA9C
			public unsafe DecoderNLS decoder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_decoder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoderNLS>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001476 RID: 5238
			// (get) Token: 0x0600504E RID: 20558 RVA: 0x0016840C File Offset: 0x0016660C
			// (set) Token: 0x0600504F RID: 20559 RVA: 0x0001E8BB File Offset: 0x0001CABB
			public unsafe byte* byteStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_byteStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_byteStart)) = value;
				}
			}

			// Token: 0x17001477 RID: 5239
			// (get) Token: 0x06005050 RID: 20560 RVA: 0x00168430 File Offset: 0x00166630
			// (set) Token: 0x06005051 RID: 20561 RVA: 0x0001E8D6 File Offset: 0x0001CAD6
			public unsafe byte* byteEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_byteEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_byteEnd)) = value;
				}
			}

			// Token: 0x17001478 RID: 5240
			// (get) Token: 0x06005052 RID: 20562 RVA: 0x00168454 File Offset: 0x00166654
			// (set) Token: 0x06005053 RID: 20563 RVA: 0x0001E8F1 File Offset: 0x0001CAF1
			public unsafe byte* bytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_bytes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_bytes)) = value;
				}
			}

			// Token: 0x17001479 RID: 5241
			// (get) Token: 0x06005054 RID: 20564 RVA: 0x00168478 File Offset: 0x00166678
			// (set) Token: 0x06005055 RID: 20565 RVA: 0x0001E90C File Offset: 0x0001CB0C
			public unsafe DecoderFallbackBuffer fallbackBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_fallbackBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoderFallbackBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingCharBuffer.NativeFieldInfoPtr_fallbackBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004139 RID: 16697
			private static readonly IntPtr NativeFieldInfoPtr_chars;

			// Token: 0x0400413A RID: 16698
			private static readonly IntPtr NativeFieldInfoPtr_charStart;

			// Token: 0x0400413B RID: 16699
			private static readonly IntPtr NativeFieldInfoPtr_charEnd;

			// Token: 0x0400413C RID: 16700
			private static readonly IntPtr NativeFieldInfoPtr_charCountResult;

			// Token: 0x0400413D RID: 16701
			private static readonly IntPtr NativeFieldInfoPtr_enc;

			// Token: 0x0400413E RID: 16702
			private static readonly IntPtr NativeFieldInfoPtr_decoder;

			// Token: 0x0400413F RID: 16703
			private static readonly IntPtr NativeFieldInfoPtr_byteStart;

			// Token: 0x04004140 RID: 16704
			private static readonly IntPtr NativeFieldInfoPtr_byteEnd;

			// Token: 0x04004141 RID: 16705
			private static readonly IntPtr NativeFieldInfoPtr_bytes;

			// Token: 0x04004142 RID: 16706
			private static readonly IntPtr NativeFieldInfoPtr_fallbackBuffer;

			// Token: 0x04004143 RID: 16707
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Encoding_DecoderNLS_ptr_Char_Int32_ptr_Byte_Int32_0;

			// Token: 0x04004144 RID: 16708
			private static readonly IntPtr NativeMethodInfoPtr_AddChar_Internal_Boolean_Char_Int32_0;

			// Token: 0x04004145 RID: 16709
			private static readonly IntPtr NativeMethodInfoPtr_AddChar_Internal_Boolean_Char_0;

			// Token: 0x04004146 RID: 16710
			private static readonly IntPtr NativeMethodInfoPtr_AdjustBytes_Internal_Void_Int32_0;

			// Token: 0x04004147 RID: 16711
			private static readonly IntPtr NativeMethodInfoPtr_get_MoreData_Internal_get_Boolean_0;

			// Token: 0x04004148 RID: 16712
			private static readonly IntPtr NativeMethodInfoPtr_GetNextByte_Internal_Byte_0;

			// Token: 0x04004149 RID: 16713
			private static readonly IntPtr NativeMethodInfoPtr_get_BytesUsed_Internal_get_Int32_0;

			// Token: 0x0400414A RID: 16714
			private static readonly IntPtr NativeMethodInfoPtr_Fallback_Internal_Boolean_Byte_0;

			// Token: 0x0400414B RID: 16715
			private static readonly IntPtr NativeMethodInfoPtr_Fallback_Internal_Boolean_Il2CppStructArray_1_Byte_0;

			// Token: 0x0400414C RID: 16716
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Internal_get_Int32_0;
		}

		// Token: 0x020005B5 RID: 1461
		public class EncodingByteBuffer : Object
		{
			// Token: 0x06005056 RID: 20566 RVA: 0x001684A8 File Offset: 0x001666A8
			// Note: this type is marked as 'beforefieldinit'.
			static EncodingByteBuffer()
			{
				Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Encoding>.NativeClassPtr, "EncodingByteBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr);
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "bytes");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "byteStart");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "byteEnd");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "chars");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_charStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "charStart");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_charEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "charEnd");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteCountResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "byteCountResult");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_enc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "enc");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_encoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "encoder");
				Encoding.EncodingByteBuffer.NativeFieldInfoPtr_fallbackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, "fallbackBuffer");
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_EncoderNLS_ptr_Byte_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667457);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667458);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667459);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667460);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667461);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_MovePrevious_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667462);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_get_MoreData_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667463);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_GetNextChar_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667464);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_get_CharsUsed_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667465);
				Encoding.EncodingByteBuffer.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr, 100667466);
			}

			// Token: 0x06005057 RID: 20567 RVA: 0x00168664 File Offset: 0x00166864
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 310831, RefRangeEnd = 310832, XrefRangeStart = 310800, XrefRangeEnd = 310831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EncodingByteBuffer(Encoding inEncoding, EncoderNLS inEncoder, byte* inByteStart, int inByteCount, char* inCharStart, int inCharCount)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoding.EncodingByteBuffer>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(inEncoding);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inEncoder);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = inByteStart;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inByteCount;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = inCharStart;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inCharCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_EncoderNLS_ptr_Byte_Int32_ptr_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005058 RID: 20568 RVA: 0x001686F8 File Offset: 0x001668F8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 310832, RefRangeEnd = 310833, XrefRangeStart = 310832, XrefRangeEnd = 310832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AddByte(byte b, int moreBytesExpected)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref b;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moreBytesExpected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005059 RID: 20569 RVA: 0x00168750 File Offset: 0x00166950
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 310834, RefRangeEnd = 310842, XrefRangeStart = 310833, XrefRangeEnd = 310834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AddByte(byte b1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref b1;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600505A RID: 20570 RVA: 0x0016879C File Offset: 0x0016699C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 310843, RefRangeEnd = 310844, XrefRangeStart = 310842, XrefRangeEnd = 310843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AddByte(byte b1, byte b2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref b1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600505B RID: 20571 RVA: 0x001687F4 File Offset: 0x001669F4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 310844, RefRangeEnd = 310845, XrefRangeStart = 310844, XrefRangeEnd = 310844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool AddByte(byte b1, byte b2, int moreBytesExpected)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref b1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moreBytesExpected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600505C RID: 20572 RVA: 0x0016885C File Offset: 0x00166A5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310845, XrefRangeEnd = 310847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MovePrevious(bool bThrow)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref bThrow;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_MovePrevious_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001487 RID: 5255
			// (get) Token: 0x0600505D RID: 20573 RVA: 0x0016889C File Offset: 0x00166A9C
			public unsafe bool MoreData
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 310847, RefRangeEnd = 310848, XrefRangeStart = 310847, XrefRangeEnd = 310847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_get_MoreData_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600505E RID: 20574 RVA: 0x001688D8 File Offset: 0x00166AD8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 310849, RefRangeEnd = 310852, XrefRangeStart = 310848, XrefRangeEnd = 310849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe char GetNextChar()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_GetNextChar_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001488 RID: 5256
			// (get) Token: 0x0600505F RID: 20575 RVA: 0x00168914 File Offset: 0x00166B14
			public unsafe int CharsUsed
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 310852, RefRangeEnd = 310853, XrefRangeStart = 310852, XrefRangeEnd = 310852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_get_CharsUsed_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001489 RID: 5257
			// (get) Token: 0x06005060 RID: 20576 RVA: 0x00168950 File Offset: 0x00166B50
			public unsafe int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoding.EncodingByteBuffer.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005061 RID: 20577 RVA: 0x0001E92B File Offset: 0x0001CB2B
			public EncodingByteBuffer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700147D RID: 5245
			// (get) Token: 0x06005062 RID: 20578 RVA: 0x0016898C File Offset: 0x00166B8C
			// (set) Token: 0x06005063 RID: 20579 RVA: 0x0001E934 File Offset: 0x0001CB34
			public unsafe byte* bytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_bytes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_bytes)) = value;
				}
			}

			// Token: 0x1700147E RID: 5246
			// (get) Token: 0x06005064 RID: 20580 RVA: 0x001689B0 File Offset: 0x00166BB0
			// (set) Token: 0x06005065 RID: 20581 RVA: 0x0001E94F File Offset: 0x0001CB4F
			public unsafe byte* byteStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteStart)) = value;
				}
			}

			// Token: 0x1700147F RID: 5247
			// (get) Token: 0x06005066 RID: 20582 RVA: 0x001689D4 File Offset: 0x00166BD4
			// (set) Token: 0x06005067 RID: 20583 RVA: 0x0001E96A File Offset: 0x0001CB6A
			public unsafe byte* byteEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteEnd)) = value;
				}
			}

			// Token: 0x17001480 RID: 5248
			// (get) Token: 0x06005068 RID: 20584 RVA: 0x001689F8 File Offset: 0x00166BF8
			// (set) Token: 0x06005069 RID: 20585 RVA: 0x0001E985 File Offset: 0x0001CB85
			public unsafe char* chars
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_chars);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_chars)) = value;
				}
			}

			// Token: 0x17001481 RID: 5249
			// (get) Token: 0x0600506A RID: 20586 RVA: 0x00168A1C File Offset: 0x00166C1C
			// (set) Token: 0x0600506B RID: 20587 RVA: 0x0001E9A0 File Offset: 0x0001CBA0
			public unsafe char* charStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_charStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_charStart)) = value;
				}
			}

			// Token: 0x17001482 RID: 5250
			// (get) Token: 0x0600506C RID: 20588 RVA: 0x00168A40 File Offset: 0x00166C40
			// (set) Token: 0x0600506D RID: 20589 RVA: 0x0001E9BB File Offset: 0x0001CBBB
			public unsafe char* charEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_charEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_charEnd)) = value;
				}
			}

			// Token: 0x17001483 RID: 5251
			// (get) Token: 0x0600506E RID: 20590 RVA: 0x00168A64 File Offset: 0x00166C64
			// (set) Token: 0x0600506F RID: 20591 RVA: 0x0001E9D6 File Offset: 0x0001CBD6
			public unsafe int byteCountResult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteCountResult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_byteCountResult)) = value;
				}
			}

			// Token: 0x17001484 RID: 5252
			// (get) Token: 0x06005070 RID: 20592 RVA: 0x00168A8C File Offset: 0x00166C8C
			// (set) Token: 0x06005071 RID: 20593 RVA: 0x0001E9F1 File Offset: 0x0001CBF1
			public unsafe Encoding enc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_enc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_enc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001485 RID: 5253
			// (get) Token: 0x06005072 RID: 20594 RVA: 0x00168ABC File Offset: 0x00166CBC
			// (set) Token: 0x06005073 RID: 20595 RVA: 0x0001EA10 File Offset: 0x0001CC10
			public unsafe EncoderNLS encoder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_encoder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderNLS>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_encoder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001486 RID: 5254
			// (get) Token: 0x06005074 RID: 20596 RVA: 0x00168AEC File Offset: 0x00166CEC
			// (set) Token: 0x06005075 RID: 20597 RVA: 0x0001EA2F File Offset: 0x0001CC2F
			public unsafe EncoderFallbackBuffer fallbackBuffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_fallbackBuffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderFallbackBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoding.EncodingByteBuffer.NativeFieldInfoPtr_fallbackBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400414D RID: 16717
			private static readonly IntPtr NativeFieldInfoPtr_bytes;

			// Token: 0x0400414E RID: 16718
			private static readonly IntPtr NativeFieldInfoPtr_byteStart;

			// Token: 0x0400414F RID: 16719
			private static readonly IntPtr NativeFieldInfoPtr_byteEnd;

			// Token: 0x04004150 RID: 16720
			private static readonly IntPtr NativeFieldInfoPtr_chars;

			// Token: 0x04004151 RID: 16721
			private static readonly IntPtr NativeFieldInfoPtr_charStart;

			// Token: 0x04004152 RID: 16722
			private static readonly IntPtr NativeFieldInfoPtr_charEnd;

			// Token: 0x04004153 RID: 16723
			private static readonly IntPtr NativeFieldInfoPtr_byteCountResult;

			// Token: 0x04004154 RID: 16724
			private static readonly IntPtr NativeFieldInfoPtr_enc;

			// Token: 0x04004155 RID: 16725
			private static readonly IntPtr NativeFieldInfoPtr_encoder;

			// Token: 0x04004156 RID: 16726
			private static readonly IntPtr NativeFieldInfoPtr_fallbackBuffer;

			// Token: 0x04004157 RID: 16727
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Encoding_EncoderNLS_ptr_Byte_Int32_ptr_Char_Int32_0;

			// Token: 0x04004158 RID: 16728
			private static readonly IntPtr NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Int32_0;

			// Token: 0x04004159 RID: 16729
			private static readonly IntPtr NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_0;

			// Token: 0x0400415A RID: 16730
			private static readonly IntPtr NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Byte_0;

			// Token: 0x0400415B RID: 16731
			private static readonly IntPtr NativeMethodInfoPtr_AddByte_Internal_Boolean_Byte_Byte_Int32_0;

			// Token: 0x0400415C RID: 16732
			private static readonly IntPtr NativeMethodInfoPtr_MovePrevious_Internal_Void_Boolean_0;

			// Token: 0x0400415D RID: 16733
			private static readonly IntPtr NativeMethodInfoPtr_get_MoreData_Internal_get_Boolean_0;

			// Token: 0x0400415E RID: 16734
			private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Internal_Char_0;

			// Token: 0x0400415F RID: 16735
			private static readonly IntPtr NativeMethodInfoPtr_get_CharsUsed_Internal_get_Int32_0;

			// Token: 0x04004160 RID: 16736
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Internal_get_Int32_0;
		}
	}
}

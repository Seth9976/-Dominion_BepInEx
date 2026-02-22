using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text
{
	// Token: 0x02000156 RID: 342
	[Serializable]
	public class Decoder : Object
	{
		// Token: 0x0600174B RID: 5963 RVA: 0x0008ADE4 File Offset: 0x00088FE4
		// Note: this type is marked as 'beforefieldinit'.
		static Decoder()
		{
			Il2CppClassPointerStore<Decoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "Decoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Decoder>.NativeClassPtr);
			Decoder.NativeFieldInfoPtr_m_fallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decoder>.NativeClassPtr, "m_fallback");
			Decoder.NativeFieldInfoPtr_m_fallbackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decoder>.NativeClassPtr, "m_fallbackBuffer");
			Decoder.NativeMethodInfoPtr_SerializeDecoder_Internal_Void_SerializationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100667194);
			Decoder.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100667195);
			Decoder.NativeMethodInfoPtr_get_Fallback_Public_get_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100667196);
			Decoder.NativeMethodInfoPtr_get_FallbackBuffer_Public_get_DecoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100667197);
			Decoder.NativeMethodInfoPtr_get_InternalHasFallbackBuffer_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100667198);
			Decoder.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100667199);
			Decoder.NativeMethodInfoPtr_GetCharCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100667200);
			Decoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100667201);
			Decoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_New_Int32_ptr_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100667202);
			Decoder.NativeMethodInfoPtr_GetChars_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100667203);
			Decoder.NativeMethodInfoPtr_GetChars_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100667204);
			Decoder.NativeMethodInfoPtr_GetChars_Public_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100667205);
			Decoder.NativeMethodInfoPtr_Convert_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_byref_Int32_byref_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100667206);
			Decoder.NativeMethodInfoPtr_Convert_Public_Virtual_New_Void_ptr_Byte_Int32_ptr_Char_Int32_Boolean_byref_Int32_byref_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100667207);
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x0008AF54 File Offset: 0x00089154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309721, XrefRangeEnd = 309725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeDecoder(SerializationInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decoder.NativeMethodInfoPtr_SerializeDecoder_Internal_Void_SerializationInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x0008AF98 File Offset: 0x00089198
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decoder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Decoder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decoder.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x0008AFD4 File Offset: 0x000891D4
		public unsafe DecoderFallback Fallback
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decoder.NativeMethodInfoPtr_get_Fallback_Public_get_DecoderFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr3) : null;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x0008B014 File Offset: 0x00089214
		public unsafe DecoderFallbackBuffer FallbackBuffer
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 309726, RefRangeEnd = 309744, XrefRangeStart = 309725, XrefRangeEnd = 309726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decoder.NativeMethodInfoPtr_get_FallbackBuffer_Public_get_DecoderFallbackBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecoderFallbackBuffer>(intPtr3) : null;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x0008B054 File Offset: 0x00089254
		public unsafe bool InternalHasFallbackBuffer
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 309744, RefRangeEnd = 309751, XrefRangeStart = 309744, XrefRangeEnd = 309744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Decoder.NativeMethodInfoPtr_get_InternalHasFallbackBuffer_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x0008B090 File Offset: 0x00089290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309751, XrefRangeEnd = 309757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Decoder.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x0008B0CC File Offset: 0x000892CC
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Decoder.NativeMethodInfoPtr_GetCharCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x0008B140 File Offset: 0x00089340
		[CallerCount(0)]
		public unsafe virtual int GetCharCount(Il2CppStructArray<byte> bytes, int index, int count, bool flush)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Decoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x0008B1C4 File Offset: 0x000893C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309757, XrefRangeEnd = 309779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetCharCount(byte* bytes, int count, bool flush)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Decoder.NativeMethodInfoPtr_GetCharCount_Public_Virtual_New_Int32_ptr_Byte_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x0008B234 File Offset: 0x00089434
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Decoder.NativeMethodInfoPtr_GetChars_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x0008B2CC File Offset: 0x000894CC
		[CallerCount(0)]
		public unsafe virtual int GetChars(Il2CppStructArray<byte> bytes, int byteIndex, int byteCount, Il2CppStructArray<char> chars, int charIndex, bool flush)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Decoder.NativeMethodInfoPtr_GetChars_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x0008B370 File Offset: 0x00089570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309779, XrefRangeEnd = 309785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Decoder.NativeMethodInfoPtr_GetChars_Public_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x0008B3FC File Offset: 0x000895FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309785, XrefRangeEnd = 309788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Convert(Il2CppStructArray<byte> bytes, int byteIndex, int byteCount, Il2CppStructArray<char> chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Decoder.NativeMethodInfoPtr_Convert_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_byref_Int32_byref_Int32_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x0008B4D4 File Offset: 0x000896D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309788, XrefRangeEnd = 309791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = chars;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bytesUsed;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsUsed;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &completed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Decoder.NativeMethodInfoPtr_Convert_Public_Virtual_New_Void_ptr_Byte_Int32_ptr_Char_Int32_Boolean_byref_Int32_byref_Int32_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00008354 File Offset: 0x00006554
		public Decoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x0600175B RID: 5979 RVA: 0x0008B580 File Offset: 0x00089780
		// (set) Token: 0x0600175C RID: 5980 RVA: 0x0000835D File Offset: 0x0000655D
		public unsafe DecoderFallback m_fallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decoder.NativeFieldInfoPtr_m_fallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoderFallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decoder.NativeFieldInfoPtr_m_fallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x0008B5B0 File Offset: 0x000897B0
		// (set) Token: 0x0600175E RID: 5982 RVA: 0x0000837C File Offset: 0x0000657C
		public unsafe DecoderFallbackBuffer m_fallbackBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decoder.NativeFieldInfoPtr_m_fallbackBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecoderFallbackBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Decoder.NativeFieldInfoPtr_m_fallbackBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015A1 RID: 5537
		private static readonly IntPtr NativeFieldInfoPtr_m_fallback;

		// Token: 0x040015A2 RID: 5538
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackBuffer;

		// Token: 0x040015A3 RID: 5539
		private static readonly IntPtr NativeMethodInfoPtr_SerializeDecoder_Internal_Void_SerializationInfo_0;

		// Token: 0x040015A4 RID: 5540
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040015A5 RID: 5541
		private static readonly IntPtr NativeMethodInfoPtr_get_Fallback_Public_get_DecoderFallback_0;

		// Token: 0x040015A6 RID: 5542
		private static readonly IntPtr NativeMethodInfoPtr_get_FallbackBuffer_Public_get_DecoderFallbackBuffer_0;

		// Token: 0x040015A7 RID: 5543
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalHasFallbackBuffer_Internal_get_Boolean_0;

		// Token: 0x040015A8 RID: 5544
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x040015A9 RID: 5545
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040015AA RID: 5546
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0;

		// Token: 0x040015AB RID: 5547
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_New_Int32_ptr_Byte_Int32_Boolean_0;

		// Token: 0x040015AC RID: 5548
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x040015AD RID: 5549
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Boolean_0;

		// Token: 0x040015AE RID: 5550
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_New_Int32_ptr_Byte_Int32_ptr_Char_Int32_Boolean_0;

		// Token: 0x040015AF RID: 5551
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_byref_Int32_byref_Int32_byref_Boolean_0;

		// Token: 0x040015B0 RID: 5552
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_New_Void_ptr_Byte_Int32_ptr_Char_Int32_Boolean_byref_Int32_byref_Int32_byref_Boolean_0;
	}
}

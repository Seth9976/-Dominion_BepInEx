using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text
{
	// Token: 0x0200015E RID: 350
	[Serializable]
	public class DecoderNLS : Decoder
	{
		// Token: 0x060017B7 RID: 6071 RVA: 0x0008CA20 File Offset: 0x0008AC20
		// Note: this type is marked as 'beforefieldinit'.
		static DecoderNLS()
		{
			Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "DecoderNLS");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr);
			DecoderNLS.NativeFieldInfoPtr_m_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, "m_encoding");
			DecoderNLS.NativeFieldInfoPtr_m_mustFlush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, "m_mustFlush");
			DecoderNLS.NativeFieldInfoPtr_m_throwOnOverflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, "m_throwOnOverflow");
			DecoderNLS.NativeFieldInfoPtr_m_bytesUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, "m_bytesUsed");
			DecoderNLS.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, 100667250);
			DecoderNLS.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, 100667251);
			DecoderNLS.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, 100667252);
			DecoderNLS.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, 100667253);
			DecoderNLS.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, 100667254);
			DecoderNLS.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, 100667255);
			DecoderNLS.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, 100667256);
			DecoderNLS.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, 100667257);
			DecoderNLS.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, 100667258);
			DecoderNLS.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, 100667259);
			DecoderNLS.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, 100667260);
			DecoderNLS.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_byref_Int32_byref_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, 100667261);
			DecoderNLS.NativeMethodInfoPtr_Convert_Public_Virtual_Void_ptr_Byte_Int32_ptr_Char_Int32_Boolean_byref_Int32_byref_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, 100667262);
			DecoderNLS.NativeMethodInfoPtr_get_MustFlush_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, 100667263);
			DecoderNLS.NativeMethodInfoPtr_get_HasState_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, 100667264);
			DecoderNLS.NativeMethodInfoPtr_ClearMustFlush_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr, 100667265);
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x0008CBE0 File Offset: 0x0008ADE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310030, XrefRangeEnd = 310045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderNLS(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderNLS.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x0008CC44 File Offset: 0x0008AE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310045, XrefRangeEnd = 310059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderNLS.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x0008CCA0 File Offset: 0x0008AEA0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 310061, RefRangeEnd = 310066, XrefRangeStart = 310059, XrefRangeEnd = 310061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderNLS(Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderNLS.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x0008CCEC File Offset: 0x0008AEEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 310067, RefRangeEnd = 310070, XrefRangeStart = 310066, XrefRangeEnd = 310067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderNLS()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderNLS>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderNLS.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x0008CD28 File Offset: 0x0008AF28
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderNLS.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x0008CD64 File Offset: 0x0008AF64
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderNLS.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x0008CDD8 File Offset: 0x0008AFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310070, XrefRangeEnd = 310099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderNLS.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x0008CE5C File Offset: 0x0008B05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310099, XrefRangeEnd = 310116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderNLS.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x0008CECC File Offset: 0x0008B0CC
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderNLS.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x0008CF64 File Offset: 0x0008B164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310116, XrefRangeEnd = 310156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderNLS.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x0008D008 File Offset: 0x0008B208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310156, XrefRangeEnd = 310174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderNLS.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x0008D094 File Offset: 0x0008B294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310174, XrefRangeEnd = 310181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderNLS.NativeMethodInfoPtr_Convert_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_byref_Int32_byref_Int32_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x0008D16C File Offset: 0x0008B36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310181, XrefRangeEnd = 310183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderNLS.NativeMethodInfoPtr_Convert_Public_Virtual_Void_ptr_Byte_Int32_ptr_Char_Int32_Boolean_byref_Int32_byref_Int32_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x060017C5 RID: 6085 RVA: 0x0008D218 File Offset: 0x0008B418
		public unsafe bool MustFlush
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderNLS.NativeMethodInfoPtr_get_MustFlush_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x0008D254 File Offset: 0x0008B454
		public unsafe virtual bool HasState
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderNLS.NativeMethodInfoPtr_get_HasState_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x0008D29C File Offset: 0x0008B49C
		[CallerCount(0)]
		public unsafe void ClearMustFlush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderNLS.NativeMethodInfoPtr_ClearMustFlush_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00008576 File Offset: 0x00006776
		public DecoderNLS(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x060017C9 RID: 6089 RVA: 0x0008D2D0 File Offset: 0x0008B4D0
		// (set) Token: 0x060017CA RID: 6090 RVA: 0x0000857F File Offset: 0x0000677F
		public unsafe Encoding m_encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderNLS.NativeFieldInfoPtr_m_encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderNLS.NativeFieldInfoPtr_m_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x0008D300 File Offset: 0x0008B500
		// (set) Token: 0x060017CC RID: 6092 RVA: 0x0000859E File Offset: 0x0000679E
		public unsafe bool m_mustFlush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderNLS.NativeFieldInfoPtr_m_mustFlush);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderNLS.NativeFieldInfoPtr_m_mustFlush)) = value;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x060017CD RID: 6093 RVA: 0x0008D328 File Offset: 0x0008B528
		// (set) Token: 0x060017CE RID: 6094 RVA: 0x000085B9 File Offset: 0x000067B9
		public unsafe bool m_throwOnOverflow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderNLS.NativeFieldInfoPtr_m_throwOnOverflow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderNLS.NativeFieldInfoPtr_m_throwOnOverflow)) = value;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x0008D350 File Offset: 0x0008B550
		// (set) Token: 0x060017D0 RID: 6096 RVA: 0x000085D4 File Offset: 0x000067D4
		public unsafe int m_bytesUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderNLS.NativeFieldInfoPtr_m_bytesUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderNLS.NativeFieldInfoPtr_m_bytesUsed)) = value;
			}
		}

		// Token: 0x040015EB RID: 5611
		private static readonly IntPtr NativeFieldInfoPtr_m_encoding;

		// Token: 0x040015EC RID: 5612
		private static readonly IntPtr NativeFieldInfoPtr_m_mustFlush;

		// Token: 0x040015ED RID: 5613
		private static readonly IntPtr NativeFieldInfoPtr_m_throwOnOverflow;

		// Token: 0x040015EE RID: 5614
		private static readonly IntPtr NativeFieldInfoPtr_m_bytesUsed;

		// Token: 0x040015EF RID: 5615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040015F0 RID: 5616
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040015F1 RID: 5617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Encoding_0;

		// Token: 0x040015F2 RID: 5618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040015F3 RID: 5619
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x040015F4 RID: 5620
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040015F5 RID: 5621
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Boolean_0;

		// Token: 0x040015F6 RID: 5622
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_Boolean_0;

		// Token: 0x040015F7 RID: 5623
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x040015F8 RID: 5624
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Boolean_0;

		// Token: 0x040015F9 RID: 5625
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_Boolean_0;

		// Token: 0x040015FA RID: 5626
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_byref_Int32_byref_Int32_byref_Boolean_0;

		// Token: 0x040015FB RID: 5627
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Void_ptr_Byte_Int32_ptr_Char_Int32_Boolean_byref_Int32_byref_Int32_byref_Boolean_0;

		// Token: 0x040015FC RID: 5628
		private static readonly IntPtr NativeMethodInfoPtr_get_MustFlush_Public_get_Boolean_0;

		// Token: 0x040015FD RID: 5629
		private static readonly IntPtr NativeMethodInfoPtr_get_HasState_Internal_Virtual_New_get_Boolean_0;

		// Token: 0x040015FE RID: 5630
		private static readonly IntPtr NativeMethodInfoPtr_ClearMustFlush_Internal_Void_0;
	}
}

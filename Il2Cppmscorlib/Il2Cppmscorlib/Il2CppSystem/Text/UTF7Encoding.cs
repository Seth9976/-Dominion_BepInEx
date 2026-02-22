using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text
{
	// Token: 0x02000174 RID: 372
	[Serializable]
	public class UTF7Encoding : Encoding
	{
		// Token: 0x060019C7 RID: 6599 RVA: 0x00096A20 File Offset: 0x00094C20
		// Note: this type is marked as 'beforefieldinit'.
		static UTF7Encoding()
		{
			Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "UTF7Encoding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr);
			UTF7Encoding.NativeFieldInfoPtr_base64Bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, "base64Bytes");
			UTF7Encoding.NativeFieldInfoPtr_base64Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, "base64Values");
			UTF7Encoding.NativeFieldInfoPtr_directEncode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, "directEncode");
			UTF7Encoding.NativeFieldInfoPtr_m_allowOptionals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, "m_allowOptionals");
			UTF7Encoding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667624);
			UTF7Encoding.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667625);
			UTF7Encoding.NativeMethodInfoPtr_MakeTables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667626);
			UTF7Encoding.NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667627);
			UTF7Encoding.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667628);
			UTF7Encoding.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667629);
			UTF7Encoding.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667630);
			UTF7Encoding.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667631);
			UTF7Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667632);
			UTF7Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667633);
			UTF7Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667634);
			UTF7Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667635);
			UTF7Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667636);
			UTF7Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667637);
			UTF7Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667638);
			UTF7Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667639);
			UTF7Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667640);
			UTF7Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667641);
			UTF7Encoding.NativeMethodInfoPtr_GetString_Public_Virtual_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667642);
			UTF7Encoding.NativeMethodInfoPtr_GetByteCount_Internal_Virtual_Int32_ptr_Char_Int32_EncoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667643);
			UTF7Encoding.NativeMethodInfoPtr_GetBytes_Internal_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667644);
			UTF7Encoding.NativeMethodInfoPtr_GetCharCount_Internal_Virtual_Int32_ptr_Byte_Int32_DecoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667645);
			UTF7Encoding.NativeMethodInfoPtr_GetChars_Internal_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667646);
			UTF7Encoding.NativeMethodInfoPtr_GetDecoder_Public_Virtual_Decoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667647);
			UTF7Encoding.NativeMethodInfoPtr_GetEncoder_Public_Virtual_Encoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667648);
			UTF7Encoding.NativeMethodInfoPtr_GetMaxByteCount_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667649);
			UTF7Encoding.NativeMethodInfoPtr_GetMaxCharCount_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, 100667650);
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x00096CBC File Offset: 0x00094EBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314433, RefRangeEnd = 314434, XrefRangeStart = 314431, XrefRangeEnd = 314433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UTF7Encoding()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x00096CF8 File Offset: 0x00094EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314434, XrefRangeEnd = 314436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UTF7Encoding(bool allowOptionals)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allowOptionals;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x00096D40 File Offset: 0x00094F40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 314458, RefRangeEnd = 314461, XrefRangeStart = 314436, XrefRangeEnd = 314458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.NativeMethodInfoPtr_MakeTables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x00096D74 File Offset: 0x00094F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314461, XrefRangeEnd = 314471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetDefaultFallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x00096DB0 File Offset: 0x00094FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314471, XrefRangeEnd = 314472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void OnDeserializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x00096DF8 File Offset: 0x00094FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314472, XrefRangeEnd = 314480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void OnDeserialized(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x00096E40 File Offset: 0x00095040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314480, XrefRangeEnd = 314482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x00096E98 File Offset: 0x00095098
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00096EE0 File Offset: 0x000950E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314482, XrefRangeEnd = 314484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00096F54 File Offset: 0x00095154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314484, XrefRangeEnd = 314485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetByteCount(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00096FAC File Offset: 0x000951AC
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00097010 File Offset: 0x00095210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314485, XrefRangeEnd = 314523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x000970A8 File Offset: 0x000952A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314523, XrefRangeEnd = 314529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x00097140 File Offset: 0x00095340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314529, XrefRangeEnd = 314530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x000971BC File Offset: 0x000953BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314530, XrefRangeEnd = 314532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x00097230 File Offset: 0x00095430
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x00097294 File Offset: 0x00095494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314532, XrefRangeEnd = 314538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x0009732C File Offset: 0x0009552C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314538, XrefRangeEnd = 314539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x000973A8 File Offset: 0x000955A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314539, XrefRangeEnd = 314542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetString_Public_Virtual_String_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x00097418 File Offset: 0x00095618
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetByteCount_Internal_Virtual_Int32_ptr_Char_Int32_EncoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x0009748C File Offset: 0x0009568C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314542, XrefRangeEnd = 314570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetBytes_Internal_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x0009751C File Offset: 0x0009571C
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetCharCount_Internal_Virtual_Int32_ptr_Byte_Int32_DecoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x00097590 File Offset: 0x00095790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314570, XrefRangeEnd = 314588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetChars_Internal_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x00097620 File Offset: 0x00095820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314588, XrefRangeEnd = 314592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppSystem.Text.Decoder GetDecoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetDecoder_Public_Virtual_Decoder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Text.Decoder>(intPtr3) : null;
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x0009766C File Offset: 0x0009586C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314592, XrefRangeEnd = 314596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppSystem.Text.Encoder GetEncoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetEncoder_Public_Virtual_Encoder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Text.Encoder>(intPtr3) : null;
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x000976B8 File Offset: 0x000958B8
		[CallerCount(0)]
		public unsafe override int GetMaxByteCount(int charCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetMaxByteCount_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x0009770C File Offset: 0x0009590C
		[CallerCount(0)]
		public unsafe override int GetMaxCharCount(int byteCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref byteCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.NativeMethodInfoPtr_GetMaxCharCount_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00008DF7 File Offset: 0x00006FF7
		public UTF7Encoding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x00097760 File Offset: 0x00095960
		// (set) Token: 0x060019E5 RID: 6629 RVA: 0x00008E00 File Offset: 0x00007000
		public unsafe Il2CppStructArray<byte> base64Bytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.NativeFieldInfoPtr_base64Bytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.NativeFieldInfoPtr_base64Bytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x00097790 File Offset: 0x00095990
		// (set) Token: 0x060019E7 RID: 6631 RVA: 0x00008E1F File Offset: 0x0000701F
		public unsafe Il2CppStructArray<sbyte> base64Values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.NativeFieldInfoPtr_base64Values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.NativeFieldInfoPtr_base64Values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x000977C0 File Offset: 0x000959C0
		// (set) Token: 0x060019E9 RID: 6633 RVA: 0x00008E3E File Offset: 0x0000703E
		public unsafe Il2CppStructArray<bool> directEncode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.NativeFieldInfoPtr_directEncode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.NativeFieldInfoPtr_directEncode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x000977F0 File Offset: 0x000959F0
		// (set) Token: 0x060019EB RID: 6635 RVA: 0x00008E5D File Offset: 0x0000705D
		public unsafe bool m_allowOptionals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.NativeFieldInfoPtr_m_allowOptionals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.NativeFieldInfoPtr_m_allowOptionals)) = value;
			}
		}

		// Token: 0x0400177F RID: 6015
		private static readonly IntPtr NativeFieldInfoPtr_base64Bytes;

		// Token: 0x04001780 RID: 6016
		private static readonly IntPtr NativeFieldInfoPtr_base64Values;

		// Token: 0x04001781 RID: 6017
		private static readonly IntPtr NativeFieldInfoPtr_directEncode;

		// Token: 0x04001782 RID: 6018
		private static readonly IntPtr NativeFieldInfoPtr_m_allowOptionals;

		// Token: 0x04001783 RID: 6019
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001784 RID: 6020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001785 RID: 6021
		private static readonly IntPtr NativeMethodInfoPtr_MakeTables_Private_Void_0;

		// Token: 0x04001786 RID: 6022
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_Void_0;

		// Token: 0x04001787 RID: 6023
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0;

		// Token: 0x04001788 RID: 6024
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x04001789 RID: 6025
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400178A RID: 6026
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400178B RID: 6027
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0400178C RID: 6028
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_String_0;

		// Token: 0x0400178D RID: 6029
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_0;

		// Token: 0x0400178E RID: 6030
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400178F RID: 6031
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001790 RID: 6032
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_0;

		// Token: 0x04001791 RID: 6033
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001792 RID: 6034
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_0;

		// Token: 0x04001793 RID: 6035
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04001794 RID: 6036
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_0;

		// Token: 0x04001795 RID: 6037
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001796 RID: 6038
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Internal_Virtual_Int32_ptr_Char_Int32_EncoderNLS_0;

		// Token: 0x04001797 RID: 6039
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Internal_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0;

		// Token: 0x04001798 RID: 6040
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Internal_Virtual_Int32_ptr_Byte_Int32_DecoderNLS_0;

		// Token: 0x04001799 RID: 6041
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Internal_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0;

		// Token: 0x0400179A RID: 6042
		private static readonly IntPtr NativeMethodInfoPtr_GetDecoder_Public_Virtual_Decoder_0;

		// Token: 0x0400179B RID: 6043
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoder_Public_Virtual_Encoder_0;

		// Token: 0x0400179C RID: 6044
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxByteCount_Public_Virtual_Int32_Int32_0;

		// Token: 0x0400179D RID: 6045
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxCharCount_Public_Virtual_Int32_Int32_0;

		// Token: 0x020005B8 RID: 1464
		[Serializable]
		public class Decoder : DecoderNLS
		{
			// Token: 0x0600508A RID: 20618 RVA: 0x00168F64 File Offset: 0x00167164
			// Note: this type is marked as 'beforefieldinit'.
			static Decoder()
			{
				Il2CppClassPointerStore<UTF7Encoding.Decoder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, "Decoder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UTF7Encoding.Decoder>.NativeClassPtr);
				UTF7Encoding.Decoder.NativeFieldInfoPtr_bits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF7Encoding.Decoder>.NativeClassPtr, "bits");
				UTF7Encoding.Decoder.NativeFieldInfoPtr_bitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF7Encoding.Decoder>.NativeClassPtr, "bitCount");
				UTF7Encoding.Decoder.NativeFieldInfoPtr_firstByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF7Encoding.Decoder>.NativeClassPtr, "firstByte");
				UTF7Encoding.Decoder.NativeMethodInfoPtr__ctor_Public_Void_UTF7Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.Decoder>.NativeClassPtr, 100667651);
				UTF7Encoding.Decoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.Decoder>.NativeClassPtr, 100667652);
				UTF7Encoding.Decoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.Decoder>.NativeClassPtr, 100667653);
				UTF7Encoding.Decoder.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.Decoder>.NativeClassPtr, 100667654);
				UTF7Encoding.Decoder.NativeMethodInfoPtr_get_HasState_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.Decoder>.NativeClassPtr, 100667655);
			}

			// Token: 0x0600508B RID: 20619 RVA: 0x00169030 File Offset: 0x00167230
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 314161, RefRangeEnd = 314164, XrefRangeStart = 314161, XrefRangeEnd = 314164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Decoder(UTF7Encoding encoding)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF7Encoding.Decoder>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.Decoder.NativeMethodInfoPtr__ctor_Public_Void_UTF7Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600508C RID: 20620 RVA: 0x0016907C File Offset: 0x0016727C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314323, XrefRangeEnd = 314360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Decoder(SerializationInfo info, StreamingContext context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF7Encoding.Decoder>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.Decoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600508D RID: 20621 RVA: 0x001690E0 File Offset: 0x001672E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314360, XrefRangeEnd = 314378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.Decoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600508E RID: 20622 RVA: 0x0016913C File Offset: 0x0016733C
			[CallerCount(0)]
			public unsafe override void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.Decoder.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001493 RID: 5267
			// (get) Token: 0x0600508F RID: 20623 RVA: 0x00169178 File Offset: 0x00167378
			public unsafe override bool HasState
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.Decoder.NativeMethodInfoPtr_get_HasState_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005090 RID: 20624 RVA: 0x0001EACC File Offset: 0x0001CCCC
			public Decoder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001490 RID: 5264
			// (get) Token: 0x06005091 RID: 20625 RVA: 0x001691C0 File Offset: 0x001673C0
			// (set) Token: 0x06005092 RID: 20626 RVA: 0x0001EAD5 File Offset: 0x0001CCD5
			public unsafe int bits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.Decoder.NativeFieldInfoPtr_bits);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.Decoder.NativeFieldInfoPtr_bits)) = value;
				}
			}

			// Token: 0x17001491 RID: 5265
			// (get) Token: 0x06005093 RID: 20627 RVA: 0x001691E8 File Offset: 0x001673E8
			// (set) Token: 0x06005094 RID: 20628 RVA: 0x0001EAF0 File Offset: 0x0001CCF0
			public unsafe int bitCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.Decoder.NativeFieldInfoPtr_bitCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.Decoder.NativeFieldInfoPtr_bitCount)) = value;
				}
			}

			// Token: 0x17001492 RID: 5266
			// (get) Token: 0x06005095 RID: 20629 RVA: 0x00169210 File Offset: 0x00167410
			// (set) Token: 0x06005096 RID: 20630 RVA: 0x0001EB0B File Offset: 0x0001CD0B
			public unsafe bool firstByte
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.Decoder.NativeFieldInfoPtr_firstByte);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.Decoder.NativeFieldInfoPtr_firstByte)) = value;
				}
			}

			// Token: 0x0400416D RID: 16749
			private static readonly IntPtr NativeFieldInfoPtr_bits;

			// Token: 0x0400416E RID: 16750
			private static readonly IntPtr NativeFieldInfoPtr_bitCount;

			// Token: 0x0400416F RID: 16751
			private static readonly IntPtr NativeFieldInfoPtr_firstByte;

			// Token: 0x04004170 RID: 16752
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UTF7Encoding_0;

			// Token: 0x04004171 RID: 16753
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004172 RID: 16754
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004173 RID: 16755
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

			// Token: 0x04004174 RID: 16756
			private static readonly IntPtr NativeMethodInfoPtr_get_HasState_Internal_Virtual_get_Boolean_0;
		}

		// Token: 0x020005B9 RID: 1465
		[Serializable]
		public class Encoder : EncoderNLS
		{
			// Token: 0x06005097 RID: 20631 RVA: 0x00169238 File Offset: 0x00167438
			// Note: this type is marked as 'beforefieldinit'.
			static Encoder()
			{
				Il2CppClassPointerStore<UTF7Encoding.Encoder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, "Encoder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UTF7Encoding.Encoder>.NativeClassPtr);
				UTF7Encoding.Encoder.NativeFieldInfoPtr_bits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF7Encoding.Encoder>.NativeClassPtr, "bits");
				UTF7Encoding.Encoder.NativeFieldInfoPtr_bitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF7Encoding.Encoder>.NativeClassPtr, "bitCount");
				UTF7Encoding.Encoder.NativeMethodInfoPtr__ctor_Public_Void_UTF7Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.Encoder>.NativeClassPtr, 100667656);
				UTF7Encoding.Encoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.Encoder>.NativeClassPtr, 100667657);
				UTF7Encoding.Encoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.Encoder>.NativeClassPtr, 100667658);
				UTF7Encoding.Encoder.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.Encoder>.NativeClassPtr, 100667659);
			}

			// Token: 0x06005098 RID: 20632 RVA: 0x001692DC File Offset: 0x001674DC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 314379, RefRangeEnd = 314381, XrefRangeStart = 314378, XrefRangeEnd = 314379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Encoder(UTF7Encoding encoding)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF7Encoding.Encoder>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.Encoder.NativeMethodInfoPtr__ctor_Public_Void_UTF7Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005099 RID: 20633 RVA: 0x00169328 File Offset: 0x00167528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314381, XrefRangeEnd = 314409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Encoder(SerializationInfo info, StreamingContext context)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF7Encoding.Encoder>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.Encoder.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600509A RID: 20634 RVA: 0x0016938C File Offset: 0x0016758C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314409, XrefRangeEnd = 314424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.Encoder.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600509B RID: 20635 RVA: 0x001693E8 File Offset: 0x001675E8
			[CallerCount(0)]
			public unsafe override void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UTF7Encoding.Encoder.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600509C RID: 20636 RVA: 0x0001EB26 File Offset: 0x0001CD26
			public Encoder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001494 RID: 5268
			// (get) Token: 0x0600509D RID: 20637 RVA: 0x00169424 File Offset: 0x00167624
			// (set) Token: 0x0600509E RID: 20638 RVA: 0x0001EB2F File Offset: 0x0001CD2F
			public unsafe int bits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.Encoder.NativeFieldInfoPtr_bits);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.Encoder.NativeFieldInfoPtr_bits)) = value;
				}
			}

			// Token: 0x17001495 RID: 5269
			// (get) Token: 0x0600509F RID: 20639 RVA: 0x0016944C File Offset: 0x0016764C
			// (set) Token: 0x060050A0 RID: 20640 RVA: 0x0001EB4A File Offset: 0x0001CD4A
			public unsafe int bitCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.Encoder.NativeFieldInfoPtr_bitCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.Encoder.NativeFieldInfoPtr_bitCount)) = value;
				}
			}

			// Token: 0x04004175 RID: 16757
			private static readonly IntPtr NativeFieldInfoPtr_bits;

			// Token: 0x04004176 RID: 16758
			private static readonly IntPtr NativeFieldInfoPtr_bitCount;

			// Token: 0x04004177 RID: 16759
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UTF7Encoding_0;

			// Token: 0x04004178 RID: 16760
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x04004179 RID: 16761
			private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

			// Token: 0x0400417A RID: 16762
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;
		}

		// Token: 0x020005BA RID: 1466
		[Serializable]
		public sealed class DecoderUTF7Fallback : DecoderFallback
		{
			// Token: 0x060050A1 RID: 20641 RVA: 0x00169474 File Offset: 0x00167674
			// Note: this type is marked as 'beforefieldinit'.
			static DecoderUTF7Fallback()
			{
				Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7Fallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, "DecoderUTF7Fallback");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7Fallback>.NativeClassPtr);
				UTF7Encoding.DecoderUTF7Fallback.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7Fallback>.NativeClassPtr, 100667660);
				UTF7Encoding.DecoderUTF7Fallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_DecoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7Fallback>.NativeClassPtr, 100667661);
				UTF7Encoding.DecoderUTF7Fallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7Fallback>.NativeClassPtr, 100667662);
				UTF7Encoding.DecoderUTF7Fallback.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7Fallback>.NativeClassPtr, 100667663);
				UTF7Encoding.DecoderUTF7Fallback.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7Fallback>.NativeClassPtr, 100667664);
			}

			// Token: 0x060050A2 RID: 20642 RVA: 0x00169504 File Offset: 0x00167704
			[CallerCount(114)]
			[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DecoderUTF7Fallback()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7Fallback>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.DecoderUTF7Fallback.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050A3 RID: 20643 RVA: 0x00169540 File Offset: 0x00167740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314424, XrefRangeEnd = 314428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override DecoderFallbackBuffer CreateFallbackBuffer()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.DecoderUTF7Fallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_DecoderFallbackBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecoderFallbackBuffer>(intPtr3) : null;
			}

			// Token: 0x17001496 RID: 5270
			// (get) Token: 0x060050A4 RID: 20644 RVA: 0x00169580 File Offset: 0x00167780
			public unsafe override int MaxCharCount
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 15454, RefRangeEnd = 15455, XrefRangeStart = 15454, XrefRangeEnd = 15455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.DecoderUTF7Fallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060050A5 RID: 20645 RVA: 0x001695BC File Offset: 0x001677BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314428, XrefRangeEnd = 314430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.DecoderUTF7Fallback.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060050A6 RID: 20646 RVA: 0x0016960C File Offset: 0x0016780C
			[CallerCount(0)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.DecoderUTF7Fallback.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060050A7 RID: 20647 RVA: 0x0001EB65 File Offset: 0x0001CD65
			public DecoderUTF7Fallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400417B RID: 16763
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400417C RID: 16764
			private static readonly IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_DecoderFallbackBuffer_0;

			// Token: 0x0400417D RID: 16765
			private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0;

			// Token: 0x0400417E RID: 16766
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x0400417F RID: 16767
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
		}

		// Token: 0x020005BB RID: 1467
		public sealed class DecoderUTF7FallbackBuffer : DecoderFallbackBuffer
		{
			// Token: 0x060050A8 RID: 20648 RVA: 0x00169648 File Offset: 0x00167848
			// Note: this type is marked as 'beforefieldinit'.
			static DecoderUTF7FallbackBuffer()
			{
				Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7FallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UTF7Encoding>.NativeClassPtr, "DecoderUTF7FallbackBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7FallbackBuffer>.NativeClassPtr);
				UTF7Encoding.DecoderUTF7FallbackBuffer.NativeFieldInfoPtr_cFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7FallbackBuffer>.NativeClassPtr, "cFallback");
				UTF7Encoding.DecoderUTF7FallbackBuffer.NativeFieldInfoPtr_iCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7FallbackBuffer>.NativeClassPtr, "iCount");
				UTF7Encoding.DecoderUTF7FallbackBuffer.NativeFieldInfoPtr_iSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7FallbackBuffer>.NativeClassPtr, "iSize");
				UTF7Encoding.DecoderUTF7FallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_DecoderUTF7Fallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7FallbackBuffer>.NativeClassPtr, 100667665);
				UTF7Encoding.DecoderUTF7FallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7FallbackBuffer>.NativeClassPtr, 100667666);
				UTF7Encoding.DecoderUTF7FallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7FallbackBuffer>.NativeClassPtr, 100667667);
				UTF7Encoding.DecoderUTF7FallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7FallbackBuffer>.NativeClassPtr, 100667668);
				UTF7Encoding.DecoderUTF7FallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7FallbackBuffer>.NativeClassPtr, 100667669);
				UTF7Encoding.DecoderUTF7FallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7FallbackBuffer>.NativeClassPtr, 100667670);
			}

			// Token: 0x060050A9 RID: 20649 RVA: 0x00169728 File Offset: 0x00167928
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314430, XrefRangeEnd = 314431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DecoderUTF7FallbackBuffer(UTF7Encoding.DecoderUTF7Fallback fallback)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTF7Encoding.DecoderUTF7FallbackBuffer>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(fallback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.DecoderUTF7FallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_DecoderUTF7Fallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060050AA RID: 20650 RVA: 0x00169774 File Offset: 0x00167974
			[CallerCount(0)]
			public unsafe override bool Fallback(Il2CppStructArray<byte> bytesUnknown, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytesUnknown);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.DecoderUTF7FallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060050AB RID: 20651 RVA: 0x001697D0 File Offset: 0x001679D0
			[CallerCount(0)]
			public unsafe override char GetNextChar()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.DecoderUTF7FallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700149A RID: 5274
			// (get) Token: 0x060050AC RID: 20652 RVA: 0x0016980C File Offset: 0x00167A0C
			public unsafe override int Remaining
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.DecoderUTF7FallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060050AD RID: 20653 RVA: 0x00169848 File Offset: 0x00167A48
			[CallerCount(0)]
			public unsafe override void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.DecoderUTF7FallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060050AE RID: 20654 RVA: 0x0016987C File Offset: 0x00167A7C
			[CallerCount(0)]
			public unsafe override int InternalFallback(Il2CppStructArray<byte> bytes, byte* pBytes)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pBytes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTF7Encoding.DecoderUTF7FallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060050AF RID: 20655 RVA: 0x0001EB6E File Offset: 0x0001CD6E
			public DecoderUTF7FallbackBuffer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001497 RID: 5271
			// (get) Token: 0x060050B0 RID: 20656 RVA: 0x001698D8 File Offset: 0x00167AD8
			// (set) Token: 0x060050B1 RID: 20657 RVA: 0x0001EB77 File Offset: 0x0001CD77
			public unsafe char cFallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.DecoderUTF7FallbackBuffer.NativeFieldInfoPtr_cFallback);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.DecoderUTF7FallbackBuffer.NativeFieldInfoPtr_cFallback)) = value;
				}
			}

			// Token: 0x17001498 RID: 5272
			// (get) Token: 0x060050B2 RID: 20658 RVA: 0x00169900 File Offset: 0x00167B00
			// (set) Token: 0x060050B3 RID: 20659 RVA: 0x0001EB92 File Offset: 0x0001CD92
			public unsafe int iCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.DecoderUTF7FallbackBuffer.NativeFieldInfoPtr_iCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.DecoderUTF7FallbackBuffer.NativeFieldInfoPtr_iCount)) = value;
				}
			}

			// Token: 0x17001499 RID: 5273
			// (get) Token: 0x060050B4 RID: 20660 RVA: 0x00169928 File Offset: 0x00167B28
			// (set) Token: 0x060050B5 RID: 20661 RVA: 0x0001EBAD File Offset: 0x0001CDAD
			public unsafe int iSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.DecoderUTF7FallbackBuffer.NativeFieldInfoPtr_iSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTF7Encoding.DecoderUTF7FallbackBuffer.NativeFieldInfoPtr_iSize)) = value;
				}
			}

			// Token: 0x04004180 RID: 16768
			private static readonly IntPtr NativeFieldInfoPtr_cFallback;

			// Token: 0x04004181 RID: 16769
			private static readonly IntPtr NativeFieldInfoPtr_iCount;

			// Token: 0x04004182 RID: 16770
			private static readonly IntPtr NativeFieldInfoPtr_iSize;

			// Token: 0x04004183 RID: 16771
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecoderUTF7Fallback_0;

			// Token: 0x04004184 RID: 16772
			private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0;

			// Token: 0x04004185 RID: 16773
			private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0;

			// Token: 0x04004186 RID: 16774
			private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0;

			// Token: 0x04004187 RID: 16775
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

			// Token: 0x04004188 RID: 16776
			private static readonly IntPtr NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0;
		}
	}
}

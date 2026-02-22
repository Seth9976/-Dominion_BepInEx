using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000155 RID: 341
	[Serializable]
	public class ASCIIEncoding : Encoding
	{
		// Token: 0x06001734 RID: 5940 RVA: 0x0008A318 File Offset: 0x00088518
		// Note: this type is marked as 'beforefieldinit'.
		static ASCIIEncoding()
		{
			Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "ASCIIEncoding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr);
			ASCIIEncoding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667173);
			ASCIIEncoding.NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667174);
			ASCIIEncoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667175);
			ASCIIEncoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667176);
			ASCIIEncoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667177);
			ASCIIEncoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667178);
			ASCIIEncoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667179);
			ASCIIEncoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667180);
			ASCIIEncoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667181);
			ASCIIEncoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667182);
			ASCIIEncoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667183);
			ASCIIEncoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667184);
			ASCIIEncoding.NativeMethodInfoPtr_GetString_Public_Virtual_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667185);
			ASCIIEncoding.NativeMethodInfoPtr_GetByteCount_Internal_Virtual_Int32_ptr_Char_Int32_EncoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667186);
			ASCIIEncoding.NativeMethodInfoPtr_GetBytes_Internal_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667187);
			ASCIIEncoding.NativeMethodInfoPtr_GetCharCount_Internal_Virtual_Int32_ptr_Byte_Int32_DecoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667188);
			ASCIIEncoding.NativeMethodInfoPtr_GetChars_Internal_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667189);
			ASCIIEncoding.NativeMethodInfoPtr_GetMaxByteCount_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667190);
			ASCIIEncoding.NativeMethodInfoPtr_GetMaxCharCount_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667191);
			ASCIIEncoding.NativeMethodInfoPtr_GetDecoder_Public_Virtual_Decoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667192);
			ASCIIEncoding.NativeMethodInfoPtr_GetEncoder_Public_Virtual_Encoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr, 100667193);
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0008A4EC File Offset: 0x000886EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 309577, RefRangeEnd = 309581, XrefRangeStart = 309576, XrefRangeEnd = 309577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASCIIEncoding()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ASCIIEncoding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ASCIIEncoding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0008A528 File Offset: 0x00088728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309581, XrefRangeEnd = 309583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetDefaultFallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x0008A564 File Offset: 0x00088764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309583, XrefRangeEnd = 309585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x0008A5D8 File Offset: 0x000887D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309585, XrefRangeEnd = 309586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetByteCount(string chars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x0008A630 File Offset: 0x00088830
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x0008A694 File Offset: 0x00088894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309586, XrefRangeEnd = 309624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetBytes(string chars, int charIndex, int charCount, Il2CppStructArray<byte> bytes, int byteIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x0008A72C File Offset: 0x0008892C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309624, XrefRangeEnd = 309630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x0008A7C4 File Offset: 0x000889C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309630, XrefRangeEnd = 309631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x0008A840 File Offset: 0x00088A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309631, XrefRangeEnd = 309633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x0008A8B4 File Offset: 0x00088AB4
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x0008A918 File Offset: 0x00088B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309633, XrefRangeEnd = 309639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x0008A9B0 File Offset: 0x00088BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309639, XrefRangeEnd = 309640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x0008AA2C File Offset: 0x00088C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309640, XrefRangeEnd = 309643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetString(Il2CppStructArray<byte> bytes, int byteIndex, int byteCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_GetString_Public_Virtual_String_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x0008AA9C File Offset: 0x00088C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309643, XrefRangeEnd = 309660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetByteCount(char* chars, int charCount, EncoderNLS encoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = chars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_GetByteCount_Internal_Virtual_Int32_ptr_Char_Int32_EncoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x0008AB10 File Offset: 0x00088D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309660, XrefRangeEnd = 309685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_GetBytes_Internal_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x0008ABA0 File Offset: 0x00088DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309685, XrefRangeEnd = 309694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS decoder)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_GetCharCount_Internal_Virtual_Int32_ptr_Byte_Int32_DecoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x0008AC14 File Offset: 0x00088E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309694, XrefRangeEnd = 309713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_GetChars_Internal_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x0008ACA4 File Offset: 0x00088EA4
		[CallerCount(0)]
		public unsafe override int GetMaxByteCount(int charCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_GetMaxByteCount_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x0008ACF8 File Offset: 0x00088EF8
		[CallerCount(0)]
		public unsafe override int GetMaxCharCount(int byteCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref byteCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_GetMaxCharCount_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x0008AD4C File Offset: 0x00088F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309713, XrefRangeEnd = 309717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Decoder GetDecoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_GetDecoder_Public_Virtual_Decoder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Decoder>(intPtr3) : null;
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x0008AD98 File Offset: 0x00088F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309717, XrefRangeEnd = 309721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Encoder GetEncoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ASCIIEncoding.NativeMethodInfoPtr_GetEncoder_Public_Virtual_Encoder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoder>(intPtr3) : null;
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x0000834B File Offset: 0x0000654B
		public ASCIIEncoding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400158C RID: 5516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400158D RID: 5517
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultFallbacks_Internal_Virtual_Void_0;

		// Token: 0x0400158E RID: 5518
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0400158F RID: 5519
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_String_0;

		// Token: 0x04001590 RID: 5520
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_0;

		// Token: 0x04001591 RID: 5521
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_String_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001592 RID: 5522
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001593 RID: 5523
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_0;

		// Token: 0x04001594 RID: 5524
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001595 RID: 5525
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_ptr_Byte_Int32_0;

		// Token: 0x04001596 RID: 5526
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04001597 RID: 5527
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_0;

		// Token: 0x04001598 RID: 5528
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Virtual_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001599 RID: 5529
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Internal_Virtual_Int32_ptr_Char_Int32_EncoderNLS_0;

		// Token: 0x0400159A RID: 5530
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Internal_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_EncoderNLS_0;

		// Token: 0x0400159B RID: 5531
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Internal_Virtual_Int32_ptr_Byte_Int32_DecoderNLS_0;

		// Token: 0x0400159C RID: 5532
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Internal_Virtual_Int32_ptr_Byte_Int32_ptr_Char_Int32_DecoderNLS_0;

		// Token: 0x0400159D RID: 5533
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxByteCount_Public_Virtual_Int32_Int32_0;

		// Token: 0x0400159E RID: 5534
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxCharCount_Public_Virtual_Int32_Int32_0;

		// Token: 0x0400159F RID: 5535
		private static readonly IntPtr NativeMethodInfoPtr_GetDecoder_Public_Virtual_Decoder_0;

		// Token: 0x040015A0 RID: 5536
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoder_Public_Virtual_Encoder_0;
	}
}

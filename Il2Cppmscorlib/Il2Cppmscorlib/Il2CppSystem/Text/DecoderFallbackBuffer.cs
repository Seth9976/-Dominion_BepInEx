using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Text
{
	// Token: 0x0200015D RID: 349
	public class DecoderFallbackBuffer : Object
	{
		// Token: 0x060017A7 RID: 6055 RVA: 0x0008C58C File Offset: 0x0008A78C
		// Note: this type is marked as 'beforefieldinit'.
		static DecoderFallbackBuffer()
		{
			Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "DecoderFallbackBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr);
			DecoderFallbackBuffer.NativeFieldInfoPtr_byteStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, "byteStart");
			DecoderFallbackBuffer.NativeFieldInfoPtr_charEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, "charEnd");
			DecoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100667240);
			DecoderFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Abstract_Virtual_New_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100667241);
			DecoderFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100667242);
			DecoderFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100667243);
			DecoderFallbackBuffer.NativeMethodInfoPtr_InternalReset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100667244);
			DecoderFallbackBuffer.NativeMethodInfoPtr_InternalInitialize_Internal_Void_ptr_Byte_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100667245);
			DecoderFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Boolean_Il2CppStructArray_1_Byte_ptr_Byte_byref_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100667246);
			DecoderFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100667247);
			DecoderFallbackBuffer.NativeMethodInfoPtr_ThrowLastBytesRecursive_Internal_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100667248);
			DecoderFallbackBuffer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100667249);
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x0008C6AC File Offset: 0x0008A8AC
		[CallerCount(0)]
		public unsafe virtual bool Fallback(Il2CppStructArray<byte> bytesUnknown, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x0008C714 File Offset: 0x0008A914
		[CallerCount(0)]
		public unsafe virtual char GetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Abstract_Virtual_New_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x0008C75C File Offset: 0x0008A95C
		public unsafe virtual int Remaining
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x0008C7A4 File Offset: 0x0008A9A4
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x0008C7E0 File Offset: 0x0008A9E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 309953, RefRangeEnd = 309956, XrefRangeStart = 309953, XrefRangeEnd = 309953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallbackBuffer.NativeMethodInfoPtr_InternalReset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x0008C814 File Offset: 0x0008AA14
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 309956, RefRangeEnd = 309973, XrefRangeStart = 309956, XrefRangeEnd = 309956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalInitialize(byte* byteStart, char* charEnd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = byteStart;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = charEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallbackBuffer.NativeMethodInfoPtr_InternalInitialize_Internal_Void_ptr_Byte_ptr_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x0008C860 File Offset: 0x0008AA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309973, XrefRangeEnd = 309982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool InternalFallback(Il2CppStructArray<byte> bytes, byte* pBytes, ref char* chars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pBytes;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Boolean_Il2CppStructArray_1_Byte_ptr_Byte_byref_ptr_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			chars = ((intPtr4 == 0) ? null : new char*(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309982, XrefRangeEnd = 309983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int InternalFallback(Il2CppStructArray<byte> bytes, byte* pBytes)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x0008C958 File Offset: 0x0008AB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309983, XrefRangeEnd = 310030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowLastBytesRecursive(Il2CppStructArray<byte> bytesUnknown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytesUnknown);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallbackBuffer.NativeMethodInfoPtr_ThrowLastBytesRecursive_Internal_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x0008C99C File Offset: 0x0008AB9C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderFallbackBuffer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallbackBuffer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x00008537 File Offset: 0x00006737
		public DecoderFallbackBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x0008C9D8 File Offset: 0x0008ABD8
		// (set) Token: 0x060017B4 RID: 6068 RVA: 0x00008540 File Offset: 0x00006740
		public unsafe byte* byteStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackBuffer.NativeFieldInfoPtr_byteStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackBuffer.NativeFieldInfoPtr_byteStart)) = value;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x0008C9FC File Offset: 0x0008ABFC
		// (set) Token: 0x060017B6 RID: 6070 RVA: 0x0000855B File Offset: 0x0000675B
		public unsafe char* charEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackBuffer.NativeFieldInfoPtr_charEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackBuffer.NativeFieldInfoPtr_charEnd)) = value;
			}
		}

		// Token: 0x040015DF RID: 5599
		private static readonly IntPtr NativeFieldInfoPtr_byteStart;

		// Token: 0x040015E0 RID: 5600
		private static readonly IntPtr NativeFieldInfoPtr_charEnd;

		// Token: 0x040015E1 RID: 5601
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040015E2 RID: 5602
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Abstract_Virtual_New_Char_0;

		// Token: 0x040015E3 RID: 5603
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040015E4 RID: 5604
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x040015E5 RID: 5605
		private static readonly IntPtr NativeMethodInfoPtr_InternalReset_Internal_Void_0;

		// Token: 0x040015E6 RID: 5606
		private static readonly IntPtr NativeMethodInfoPtr_InternalInitialize_Internal_Void_ptr_Byte_ptr_Char_0;

		// Token: 0x040015E7 RID: 5607
		private static readonly IntPtr NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Boolean_Il2CppStructArray_1_Byte_ptr_Byte_byref_ptr_Char_0;

		// Token: 0x040015E8 RID: 5608
		private static readonly IntPtr NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0;

		// Token: 0x040015E9 RID: 5609
		private static readonly IntPtr NativeMethodInfoPtr_ThrowLastBytesRecursive_Internal_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040015EA RID: 5610
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text
{
	// Token: 0x02000161 RID: 353
	[Serializable]
	public class Encoder : Object
	{
		// Token: 0x060017EA RID: 6122 RVA: 0x0008D944 File Offset: 0x0008BB44
		// Note: this type is marked as 'beforefieldinit'.
		static Encoder()
		{
			Il2CppClassPointerStore<Encoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "Encoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Encoder>.NativeClassPtr);
			Encoder.NativeFieldInfoPtr_m_fallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoder>.NativeClassPtr, "m_fallback");
			Encoder.NativeFieldInfoPtr_m_fallbackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Encoder>.NativeClassPtr, "m_fallbackBuffer");
			Encoder.NativeMethodInfoPtr_SerializeEncoder_Internal_Void_SerializationInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100667279);
			Encoder.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100667280);
			Encoder.NativeMethodInfoPtr_get_Fallback_Public_get_EncoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100667281);
			Encoder.NativeMethodInfoPtr_get_FallbackBuffer_Public_get_EncoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100667282);
			Encoder.NativeMethodInfoPtr_get_InternalHasFallbackBuffer_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100667283);
			Encoder.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100667284);
			Encoder.NativeMethodInfoPtr_GetByteCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100667285);
			Encoder.NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_ptr_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100667286);
			Encoder.NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100667287);
			Encoder.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Encoder>.NativeClassPtr, 100667288);
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x0008DA64 File Offset: 0x0008BC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310214, XrefRangeEnd = 310218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SerializeEncoder(SerializationInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoder.NativeMethodInfoPtr_SerializeEncoder_Internal_Void_SerializationInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x0008DAA8 File Offset: 0x0008BCA8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Encoder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Encoder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoder.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060017ED RID: 6125 RVA: 0x0008DAE4 File Offset: 0x0008BCE4
		public unsafe EncoderFallback Fallback
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoder.NativeMethodInfoPtr_get_Fallback_Public_get_EncoderFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr3) : null;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x0008DB24 File Offset: 0x0008BD24
		public unsafe EncoderFallbackBuffer FallbackBuffer
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 310219, RefRangeEnd = 310244, XrefRangeStart = 310218, XrefRangeEnd = 310219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoder.NativeMethodInfoPtr_get_FallbackBuffer_Public_get_EncoderFallbackBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallbackBuffer>(intPtr3) : null;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x0008DB64 File Offset: 0x0008BD64
		public unsafe bool InternalHasFallbackBuffer
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 309744, RefRangeEnd = 309751, XrefRangeStart = 309744, XrefRangeEnd = 309751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Encoder.NativeMethodInfoPtr_get_InternalHasFallbackBuffer_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x0008DBA0 File Offset: 0x0008BDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310244, XrefRangeEnd = 310250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoder.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x0008DBDC File Offset: 0x0008BDDC
		[CallerCount(0)]
		public unsafe virtual int GetByteCount(Il2CppStructArray<char> chars, int index, int count, bool flush)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoder.NativeMethodInfoPtr_GetByteCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x0008DC60 File Offset: 0x0008BE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310250, XrefRangeEnd = 310253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetByteCount(char* chars, int count, bool flush)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoder.NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_ptr_Char_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x0008DCD0 File Offset: 0x0008BED0
		[CallerCount(0)]
		public unsafe virtual int GetBytes(Il2CppStructArray<char> chars, int charIndex, int charCount, Il2CppStructArray<byte> bytes, int byteIndex, bool flush)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoder.NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x0008DD74 File Offset: 0x0008BF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310253, XrefRangeEnd = 310259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Encoder.NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00008675 File Offset: 0x00006875
		public Encoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x0008DE00 File Offset: 0x0008C000
		// (set) Token: 0x060017F7 RID: 6135 RVA: 0x0000867E File Offset: 0x0000687E
		public unsafe EncoderFallback m_fallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoder.NativeFieldInfoPtr_m_fallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderFallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoder.NativeFieldInfoPtr_m_fallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060017F8 RID: 6136 RVA: 0x0008DE30 File Offset: 0x0008C030
		// (set) Token: 0x060017F9 RID: 6137 RVA: 0x0000869D File Offset: 0x0000689D
		public unsafe EncoderFallbackBuffer m_fallbackBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoder.NativeFieldInfoPtr_m_fallbackBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncoderFallbackBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Encoder.NativeFieldInfoPtr_m_fallbackBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001610 RID: 5648
		private static readonly IntPtr NativeFieldInfoPtr_m_fallback;

		// Token: 0x04001611 RID: 5649
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackBuffer;

		// Token: 0x04001612 RID: 5650
		private static readonly IntPtr NativeMethodInfoPtr_SerializeEncoder_Internal_Void_SerializationInfo_0;

		// Token: 0x04001613 RID: 5651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001614 RID: 5652
		private static readonly IntPtr NativeMethodInfoPtr_get_Fallback_Public_get_EncoderFallback_0;

		// Token: 0x04001615 RID: 5653
		private static readonly IntPtr NativeMethodInfoPtr_get_FallbackBuffer_Public_get_EncoderFallbackBuffer_0;

		// Token: 0x04001616 RID: 5654
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalHasFallbackBuffer_Internal_get_Boolean_0;

		// Token: 0x04001617 RID: 5655
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x04001618 RID: 5656
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_0;

		// Token: 0x04001619 RID: 5657
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_New_Int32_ptr_Char_Int32_Boolean_0;

		// Token: 0x0400161A RID: 5658
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_0;

		// Token: 0x0400161B RID: 5659
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_New_Int32_ptr_Char_Int32_ptr_Byte_Int32_Boolean_0;
	}
}

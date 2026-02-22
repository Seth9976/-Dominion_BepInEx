using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Text
{
	// Token: 0x0200015A RID: 346
	public sealed class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer
	{
		// Token: 0x06001787 RID: 6023 RVA: 0x0008BE9C File Offset: 0x0008A09C
		// Note: this type is marked as 'beforefieldinit'.
		static DecoderExceptionFallbackBuffer()
		{
			Il2CppClassPointerStore<DecoderExceptionFallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "DecoderExceptionFallbackBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoderExceptionFallbackBuffer>.NativeClassPtr);
			DecoderExceptionFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderExceptionFallbackBuffer>.NativeClassPtr, 100667226);
			DecoderExceptionFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderExceptionFallbackBuffer>.NativeClassPtr, 100667227);
			DecoderExceptionFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderExceptionFallbackBuffer>.NativeClassPtr, 100667228);
			DecoderExceptionFallbackBuffer.NativeMethodInfoPtr_Throw_Private_Void_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderExceptionFallbackBuffer>.NativeClassPtr, 100667229);
			DecoderExceptionFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderExceptionFallbackBuffer>.NativeClassPtr, 100667230);
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x0008BF30 File Offset: 0x0008A130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309832, XrefRangeEnd = 309833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderExceptionFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x0008BF8C File Offset: 0x0008A18C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override char GetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderExceptionFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x0008BFC8 File Offset: 0x0008A1C8
		public unsafe override int Remaining
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderExceptionFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x0008C004 File Offset: 0x0008A204
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309881, RefRangeEnd = 309882, XrefRangeStart = 309833, XrefRangeEnd = 309881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(Il2CppStructArray<byte> bytesUnknown, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderExceptionFallbackBuffer.NativeMethodInfoPtr_Throw_Private_Void_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x0008C054 File Offset: 0x0008A254
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderExceptionFallbackBuffer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderExceptionFallbackBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderExceptionFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00008491 File Offset: 0x00006691
		public DecoderExceptionFallbackBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040015CB RID: 5579
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040015CC RID: 5580
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0;

		// Token: 0x040015CD RID: 5581
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0;

		// Token: 0x040015CE RID: 5582
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040015CF RID: 5583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000165 RID: 357
	public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x06001821 RID: 6177 RVA: 0x0008E760 File Offset: 0x0008C960
		// Note: this type is marked as 'beforefieldinit'.
		static EncoderExceptionFallbackBuffer()
		{
			Il2CppClassPointerStore<EncoderExceptionFallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncoderExceptionFallbackBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncoderExceptionFallbackBuffer>.NativeClassPtr);
			EncoderExceptionFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderExceptionFallbackBuffer>.NativeClassPtr, 100667308);
			EncoderExceptionFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderExceptionFallbackBuffer>.NativeClassPtr, 100667309);
			EncoderExceptionFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderExceptionFallbackBuffer>.NativeClassPtr, 100667310);
			EncoderExceptionFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderExceptionFallbackBuffer>.NativeClassPtr, 100667311);
			EncoderExceptionFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderExceptionFallbackBuffer>.NativeClassPtr, 100667312);
			EncoderExceptionFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderExceptionFallbackBuffer>.NativeClassPtr, 100667313);
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x0008E808 File Offset: 0x0008CA08
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderExceptionFallbackBuffer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderExceptionFallbackBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderExceptionFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x0008E844 File Offset: 0x0008CA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310303, XrefRangeEnd = 310322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Fallback(char charUnknown, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charUnknown;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderExceptionFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x0008E89C File Offset: 0x0008CA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310322, XrefRangeEnd = 310396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charUnknownHigh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charUnknownLow;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderExceptionFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x0008E904 File Offset: 0x0008CB04
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override char GetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderExceptionFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x0008E940 File Offset: 0x0008CB40
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MovePrevious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderExceptionFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001827 RID: 6183 RVA: 0x0008E97C File Offset: 0x0008CB7C
		public unsafe override int Remaining
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderExceptionFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x00008797 File Offset: 0x00006997
		public EncoderExceptionFallbackBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001636 RID: 5686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001637 RID: 5687
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0;

		// Token: 0x04001638 RID: 5688
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0;

		// Token: 0x04001639 RID: 5689
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0;

		// Token: 0x0400163A RID: 5690
		private static readonly IntPtr NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0;

		// Token: 0x0400163B RID: 5691
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0;
	}
}

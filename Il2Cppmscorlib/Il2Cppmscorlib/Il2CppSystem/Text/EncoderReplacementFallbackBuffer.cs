using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x0200016B RID: 363
	public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x06001886 RID: 6278 RVA: 0x0008FF9C File Offset: 0x0008E19C
		// Note: this type is marked as 'beforefieldinit'.
		static EncoderReplacementFallbackBuffer()
		{
			Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncoderReplacementFallbackBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr);
			EncoderReplacementFallbackBuffer.NativeFieldInfoPtr_strDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, "strDefault");
			EncoderReplacementFallbackBuffer.NativeFieldInfoPtr_fallbackCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, "fallbackCount");
			EncoderReplacementFallbackBuffer.NativeFieldInfoPtr_fallbackIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, "fallbackIndex");
			EncoderReplacementFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_EncoderReplacementFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, 100667355);
			EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, 100667356);
			EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, 100667357);
			EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, 100667358);
			EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, 100667359);
			EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, 100667360);
			EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, 100667361);
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x00090094 File Offset: 0x0008E294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310683, XrefRangeEnd = 310685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderReplacementFallbackBuffer(EncoderReplacementFallback fallback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_EncoderReplacementFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x000900E0 File Offset: 0x0008E2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310685, XrefRangeEnd = 310686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x00090138 File Offset: 0x0008E338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310686, XrefRangeEnd = 310693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x000901A0 File Offset: 0x0008E3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310693, XrefRangeEnd = 310694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override char GetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x000901DC File Offset: 0x0008E3DC
		[CallerCount(0)]
		public unsafe override bool MovePrevious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x00090218 File Offset: 0x0008E418
		public unsafe override int Remaining
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00090254 File Offset: 0x0008E454
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x000089F5 File Offset: 0x00006BF5
		public EncoderReplacementFallbackBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x00090288 File Offset: 0x0008E488
		// (set) Token: 0x06001890 RID: 6288 RVA: 0x000089FE File Offset: 0x00006BFE
		public unsafe string strDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderReplacementFallbackBuffer.NativeFieldInfoPtr_strDefault);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderReplacementFallbackBuffer.NativeFieldInfoPtr_strDefault), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001891 RID: 6289 RVA: 0x000902B0 File Offset: 0x0008E4B0
		// (set) Token: 0x06001892 RID: 6290 RVA: 0x00008A1D File Offset: 0x00006C1D
		public unsafe int fallbackCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderReplacementFallbackBuffer.NativeFieldInfoPtr_fallbackCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderReplacementFallbackBuffer.NativeFieldInfoPtr_fallbackCount)) = value;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x000902D8 File Offset: 0x0008E4D8
		// (set) Token: 0x06001894 RID: 6292 RVA: 0x00008A38 File Offset: 0x00006C38
		public unsafe int fallbackIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderReplacementFallbackBuffer.NativeFieldInfoPtr_fallbackIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderReplacementFallbackBuffer.NativeFieldInfoPtr_fallbackIndex)) = value;
			}
		}

		// Token: 0x0400167A RID: 5754
		private static readonly IntPtr NativeFieldInfoPtr_strDefault;

		// Token: 0x0400167B RID: 5755
		private static readonly IntPtr NativeFieldInfoPtr_fallbackCount;

		// Token: 0x0400167C RID: 5756
		private static readonly IntPtr NativeFieldInfoPtr_fallbackIndex;

		// Token: 0x0400167D RID: 5757
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EncoderReplacementFallback_0;

		// Token: 0x0400167E RID: 5758
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0;

		// Token: 0x0400167F RID: 5759
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0;

		// Token: 0x04001680 RID: 5760
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0;

		// Token: 0x04001681 RID: 5761
		private static readonly IntPtr NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0;

		// Token: 0x04001682 RID: 5762
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0;

		// Token: 0x04001683 RID: 5763
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;
	}
}

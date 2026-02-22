using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x0200015F RID: 351
	[Serializable]
	public sealed class DecoderReplacementFallback : DecoderFallback
	{
		// Token: 0x060017D1 RID: 6097 RVA: 0x0008D378 File Offset: 0x0008B578
		// Note: this type is marked as 'beforefieldinit'.
		static DecoderReplacementFallback()
		{
			Il2CppClassPointerStore<DecoderReplacementFallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "DecoderReplacementFallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoderReplacementFallback>.NativeClassPtr);
			DecoderReplacementFallback.NativeFieldInfoPtr_strDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderReplacementFallback>.NativeClassPtr, "strDefault");
			DecoderReplacementFallback.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallback>.NativeClassPtr, 100667266);
			DecoderReplacementFallback.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallback>.NativeClassPtr, 100667267);
			DecoderReplacementFallback.NativeMethodInfoPtr_get_DefaultString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallback>.NativeClassPtr, 100667268);
			DecoderReplacementFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_DecoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallback>.NativeClassPtr, 100667269);
			DecoderReplacementFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallback>.NativeClassPtr, 100667270);
			DecoderReplacementFallback.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallback>.NativeClassPtr, 100667271);
			DecoderReplacementFallback.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallback>.NativeClassPtr, 100667272);
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x0008D448 File Offset: 0x0008B648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310183, XrefRangeEnd = 310186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderReplacementFallback()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderReplacementFallback>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallback.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x0008D484 File Offset: 0x0008B684
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 310197, RefRangeEnd = 310204, XrefRangeStart = 310186, XrefRangeEnd = 310197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderReplacementFallback(string replacement)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderReplacementFallback>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(replacement);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallback.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x0008D4D0 File Offset: 0x0008B6D0
		public unsafe string DefaultString
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallback.NativeMethodInfoPtr_get_DefaultString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x0008D508 File Offset: 0x0008B708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310204, XrefRangeEnd = 310208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_DecoderFallbackBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecoderFallbackBuffer>(intPtr3) : null;
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x0008D548 File Offset: 0x0008B748
		public unsafe override int MaxCharCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x0008D584 File Offset: 0x0008B784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310208, XrefRangeEnd = 310211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallback.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x0008D5D4 File Offset: 0x0008B7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310211, XrefRangeEnd = 310212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallback.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x000085EF File Offset: 0x000067EF
		public DecoderReplacementFallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x0008D610 File Offset: 0x0008B810
		// (set) Token: 0x060017DB RID: 6107 RVA: 0x000085F8 File Offset: 0x000067F8
		public unsafe string strDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallback.NativeFieldInfoPtr_strDefault);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallback.NativeFieldInfoPtr_strDefault), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040015FF RID: 5631
		private static readonly IntPtr NativeFieldInfoPtr_strDefault;

		// Token: 0x04001600 RID: 5632
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001601 RID: 5633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001602 RID: 5634
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultString_Public_get_String_0;

		// Token: 0x04001603 RID: 5635
		private static readonly IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_DecoderFallbackBuffer_0;

		// Token: 0x04001604 RID: 5636
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0;

		// Token: 0x04001605 RID: 5637
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001606 RID: 5638
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}

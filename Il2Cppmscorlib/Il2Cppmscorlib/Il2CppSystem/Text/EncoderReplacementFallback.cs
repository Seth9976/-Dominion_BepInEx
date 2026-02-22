using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x0200016A RID: 362
	[Serializable]
	public sealed class EncoderReplacementFallback : EncoderFallback
	{
		// Token: 0x0600187B RID: 6267 RVA: 0x0008FCDC File Offset: 0x0008DEDC
		// Note: this type is marked as 'beforefieldinit'.
		static EncoderReplacementFallback()
		{
			Il2CppClassPointerStore<EncoderReplacementFallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncoderReplacementFallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncoderReplacementFallback>.NativeClassPtr);
			EncoderReplacementFallback.NativeFieldInfoPtr_strDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderReplacementFallback>.NativeClassPtr, "strDefault");
			EncoderReplacementFallback.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallback>.NativeClassPtr, 100667348);
			EncoderReplacementFallback.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallback>.NativeClassPtr, 100667349);
			EncoderReplacementFallback.NativeMethodInfoPtr_get_DefaultString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallback>.NativeClassPtr, 100667350);
			EncoderReplacementFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_EncoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallback>.NativeClassPtr, 100667351);
			EncoderReplacementFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallback>.NativeClassPtr, 100667352);
			EncoderReplacementFallback.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallback>.NativeClassPtr, 100667353);
			EncoderReplacementFallback.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallback>.NativeClassPtr, 100667354);
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x0008FDAC File Offset: 0x0008DFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310653, XrefRangeEnd = 310656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderReplacementFallback()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderReplacementFallback>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallback.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x0008FDE8 File Offset: 0x0008DFE8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 310667, RefRangeEnd = 310675, XrefRangeStart = 310656, XrefRangeEnd = 310667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderReplacementFallback(string replacement)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderReplacementFallback>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(replacement);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallback.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x0008FE34 File Offset: 0x0008E034
		public unsafe string DefaultString
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallback.NativeMethodInfoPtr_get_DefaultString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x0008FE6C File Offset: 0x0008E06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310675, XrefRangeEnd = 310680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_EncoderFallbackBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallbackBuffer>(intPtr3) : null;
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x0008FEAC File Offset: 0x0008E0AC
		public unsafe override int MaxCharCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x0008FEE8 File Offset: 0x0008E0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310680, XrefRangeEnd = 310683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallback.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x0008FF38 File Offset: 0x0008E138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallback.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x000089CD File Offset: 0x00006BCD
		public EncoderReplacementFallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x0008FF74 File Offset: 0x0008E174
		// (set) Token: 0x06001885 RID: 6277 RVA: 0x000089D6 File Offset: 0x00006BD6
		public unsafe string strDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderReplacementFallback.NativeFieldInfoPtr_strDefault);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderReplacementFallback.NativeFieldInfoPtr_strDefault), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001672 RID: 5746
		private static readonly IntPtr NativeFieldInfoPtr_strDefault;

		// Token: 0x04001673 RID: 5747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001674 RID: 5748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001675 RID: 5749
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultString_Public_get_String_0;

		// Token: 0x04001676 RID: 5750
		private static readonly IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_EncoderFallbackBuffer_0;

		// Token: 0x04001677 RID: 5751
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0;

		// Token: 0x04001678 RID: 5752
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001679 RID: 5753
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}

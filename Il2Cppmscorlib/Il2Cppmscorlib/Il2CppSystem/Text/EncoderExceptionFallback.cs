using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000164 RID: 356
	[Serializable]
	public sealed class EncoderExceptionFallback : EncoderFallback
	{
		// Token: 0x0600181A RID: 6170 RVA: 0x0008E588 File Offset: 0x0008C788
		// Note: this type is marked as 'beforefieldinit'.
		static EncoderExceptionFallback()
		{
			Il2CppClassPointerStore<EncoderExceptionFallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncoderExceptionFallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncoderExceptionFallback>.NativeClassPtr);
			EncoderExceptionFallback.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderExceptionFallback>.NativeClassPtr, 100667303);
			EncoderExceptionFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_EncoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderExceptionFallback>.NativeClassPtr, 100667304);
			EncoderExceptionFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderExceptionFallback>.NativeClassPtr, 100667305);
			EncoderExceptionFallback.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderExceptionFallback>.NativeClassPtr, 100667306);
			EncoderExceptionFallback.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderExceptionFallback>.NativeClassPtr, 100667307);
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x0008E61C File Offset: 0x0008C81C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderExceptionFallback()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderExceptionFallback>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderExceptionFallback.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x0008E658 File Offset: 0x0008C858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310297, XrefRangeEnd = 310301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderExceptionFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_EncoderFallbackBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallbackBuffer>(intPtr3) : null;
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x0008E698 File Offset: 0x0008C898
		public unsafe override int MaxCharCount
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderExceptionFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x0008E6D4 File Offset: 0x0008C8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310301, XrefRangeEnd = 310303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderExceptionFallback.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x0008E724 File Offset: 0x0008C924
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderExceptionFallback.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x0000878E File Offset: 0x0000698E
		public EncoderExceptionFallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001631 RID: 5681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001632 RID: 5682
		private static readonly IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_EncoderFallbackBuffer_0;

		// Token: 0x04001633 RID: 5683
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0;

		// Token: 0x04001634 RID: 5684
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001635 RID: 5685
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}

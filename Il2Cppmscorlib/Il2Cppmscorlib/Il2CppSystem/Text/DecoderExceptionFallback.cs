using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000159 RID: 345
	[Serializable]
	public sealed class DecoderExceptionFallback : DecoderFallback
	{
		// Token: 0x06001780 RID: 6016 RVA: 0x0008BCC4 File Offset: 0x00089EC4
		// Note: this type is marked as 'beforefieldinit'.
		static DecoderExceptionFallback()
		{
			Il2CppClassPointerStore<DecoderExceptionFallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "DecoderExceptionFallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoderExceptionFallback>.NativeClassPtr);
			DecoderExceptionFallback.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderExceptionFallback>.NativeClassPtr, 100667221);
			DecoderExceptionFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_DecoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderExceptionFallback>.NativeClassPtr, 100667222);
			DecoderExceptionFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderExceptionFallback>.NativeClassPtr, 100667223);
			DecoderExceptionFallback.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderExceptionFallback>.NativeClassPtr, 100667224);
			DecoderExceptionFallback.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderExceptionFallback>.NativeClassPtr, 100667225);
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x0008BD58 File Offset: 0x00089F58
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderExceptionFallback()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderExceptionFallback>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderExceptionFallback.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x0008BD94 File Offset: 0x00089F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309826, XrefRangeEnd = 309830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderExceptionFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_DecoderFallbackBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecoderFallbackBuffer>(intPtr3) : null;
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x0008BDD4 File Offset: 0x00089FD4
		public unsafe override int MaxCharCount
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderExceptionFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x0008BE10 File Offset: 0x0008A010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309830, XrefRangeEnd = 309832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderExceptionFallback.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x0008BE60 File Offset: 0x0008A060
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderExceptionFallback.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00008488 File Offset: 0x00006688
		public DecoderExceptionFallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040015C6 RID: 5574
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040015C7 RID: 5575
		private static readonly IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_DecoderFallbackBuffer_0;

		// Token: 0x040015C8 RID: 5576
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0;

		// Token: 0x040015C9 RID: 5577
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040015CA RID: 5578
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}

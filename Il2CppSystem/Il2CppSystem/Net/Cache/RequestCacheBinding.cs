using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x02000149 RID: 329
	public class RequestCacheBinding : Object
	{
		// Token: 0x06001545 RID: 5445 RVA: 0x000602B8 File Offset: 0x0005E4B8
		// Note: this type is marked as 'beforefieldinit'.
		static RequestCacheBinding()
		{
			Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCacheBinding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr);
			RequestCacheBinding.NativeFieldInfoPtr_m_RequestCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr, "m_RequestCache");
			RequestCacheBinding.NativeFieldInfoPtr_m_CacheValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr, "m_CacheValidator");
			RequestCacheBinding.NativeMethodInfoPtr_get_Cache_Internal_get_RequestCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr, 100666254);
			RequestCacheBinding.NativeMethodInfoPtr_get_Validator_Internal_get_RequestCacheValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheBinding>.NativeClassPtr, 100666255);
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x00060338 File Offset: 0x0005E538
		public unsafe RequestCache Cache
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCacheBinding.NativeMethodInfoPtr_get_Cache_Internal_get_RequestCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RequestCache>(intPtr3) : null;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x00060378 File Offset: 0x0005E578
		public unsafe RequestCacheValidator Validator
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCacheBinding.NativeMethodInfoPtr_get_Validator_Internal_get_RequestCacheValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RequestCacheValidator>(intPtr3) : null;
			}
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x0000ABEB File Offset: 0x00008DEB
		public RequestCacheBinding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x000603B8 File Offset: 0x0005E5B8
		// (set) Token: 0x0600154A RID: 5450 RVA: 0x0000ABF4 File Offset: 0x00008DF4
		public unsafe RequestCache m_RequestCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCacheBinding.NativeFieldInfoPtr_m_RequestCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCacheBinding.NativeFieldInfoPtr_m_RequestCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x000603E8 File Offset: 0x0005E5E8
		// (set) Token: 0x0600154C RID: 5452 RVA: 0x0000AC13 File Offset: 0x00008E13
		public unsafe RequestCacheValidator m_CacheValidator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCacheBinding.NativeFieldInfoPtr_m_CacheValidator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestCacheValidator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCacheBinding.NativeFieldInfoPtr_m_CacheValidator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeFieldInfoPtr_m_RequestCache;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeFieldInfoPtr_m_CacheValidator;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeMethodInfoPtr_get_Cache_Internal_get_RequestCache_0;

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeMethodInfoPtr_get_Validator_Internal_get_RequestCacheValidator_0;
	}
}

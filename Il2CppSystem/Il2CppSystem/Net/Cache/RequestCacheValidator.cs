using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x02000148 RID: 328
	public class RequestCacheValidator : Object
	{
		// Token: 0x06001542 RID: 5442 RVA: 0x0000ABA9 File Offset: 0x00008DA9
		// Note: this type is marked as 'beforefieldinit'.
		static RequestCacheValidator()
		{
			Il2CppClassPointerStore<RequestCacheValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCacheValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCacheValidator>.NativeClassPtr);
			RequestCacheValidator.NativeMethodInfoPtr_CreateValidator_Public_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCacheValidator>.NativeClassPtr, 100666253);
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x00060278 File Offset: 0x0005E478
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 57596, RefRangeEnd = 57598, XrefRangeStart = 57586, XrefRangeEnd = 57596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CreateValidator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCacheValidator.NativeMethodInfoPtr_CreateValidator_Public_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x0000ABE2 File Offset: 0x00008DE2
		public RequestCacheValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001115 RID: 4373
		private static readonly IntPtr NativeMethodInfoPtr_CreateValidator_Public_Object_0;
	}
}

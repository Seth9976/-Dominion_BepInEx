using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x0200014B RID: 331
	public class RequestCachePolicy : Object
	{
		// Token: 0x0600154D RID: 5453 RVA: 0x00060418 File Offset: 0x0005E618
		// Note: this type is marked as 'beforefieldinit'.
		static RequestCachePolicy()
		{
			Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCachePolicy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr);
			RequestCachePolicy.NativeFieldInfoPtr_m_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr, "m_Level");
			RequestCachePolicy.NativeMethodInfoPtr_get_Level_Public_get_RequestCacheLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr, 100666256);
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x00060470 File Offset: 0x0005E670
		public unsafe RequestCacheLevel Level
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequestCachePolicy.NativeMethodInfoPtr_get_Level_Public_get_RequestCacheLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x0000AC32 File Offset: 0x00008E32
		public RequestCachePolicy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001550 RID: 5456 RVA: 0x000604AC File Offset: 0x0005E6AC
		// (set) Token: 0x06001551 RID: 5457 RVA: 0x0000AC3B File Offset: 0x00008E3B
		public unsafe RequestCacheLevel m_Level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCachePolicy.NativeFieldInfoPtr_m_Level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequestCachePolicy.NativeFieldInfoPtr_m_Level)) = value;
			}
		}

		// Token: 0x04001122 RID: 4386
		private static readonly IntPtr NativeFieldInfoPtr_m_Level;

		// Token: 0x04001123 RID: 4387
		private static readonly IntPtr NativeMethodInfoPtr_get_Level_Public_get_RequestCacheLevel_0;
	}
}

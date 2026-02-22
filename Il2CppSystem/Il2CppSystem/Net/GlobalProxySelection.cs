using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000C1 RID: 193
	public class GlobalProxySelection : Object
	{
		// Token: 0x06000B75 RID: 2933 RVA: 0x0003BCF8 File Offset: 0x00039EF8
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalProxySelection()
		{
			Il2CppClassPointerStore<GlobalProxySelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "GlobalProxySelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalProxySelection>.NativeClassPtr);
			GlobalProxySelection.NativeMethodInfoPtr_get_Select_Public_Static_get_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalProxySelection>.NativeClassPtr, 100664934);
			GlobalProxySelection.NativeMethodInfoPtr_GetEmptyWebProxy_Public_Static_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalProxySelection>.NativeClassPtr, 100664935);
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0003BD50 File Offset: 0x00039F50
		public unsafe static IWebProxy Select
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45847, XrefRangeEnd = 45853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalProxySelection.NativeMethodInfoPtr_get_Select_Public_Static_get_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
			}
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0003BD84 File Offset: 0x00039F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45853, XrefRangeEnd = 45857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IWebProxy GetEmptyWebProxy()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalProxySelection.NativeMethodInfoPtr_GetEmptyWebProxy_Public_Static_IWebProxy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IWebProxy>(intPtr3) : null;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x000067BB File Offset: 0x000049BB
		public GlobalProxySelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeMethodInfoPtr_get_Select_Public_Static_get_IWebProxy_0;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeMethodInfoPtr_GetEmptyWebProxy_Public_Static_IWebProxy_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x0200015E RID: 350
	public sealed class WebRequestModulesSection : ConfigurationSection
	{
		// Token: 0x060015B0 RID: 5552 RVA: 0x00061210 File Offset: 0x0005F410
		// Note: this type is marked as 'beforefieldinit'.
		static WebRequestModulesSection()
		{
			Il2CppClassPointerStore<WebRequestModulesSection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "WebRequestModulesSection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestModulesSection>.NativeClassPtr);
			WebRequestModulesSection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestModulesSection>.NativeClassPtr, 100666283);
			WebRequestModulesSection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestModulesSection>.NativeClassPtr, 100666284);
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x00061268 File Offset: 0x0005F468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57678, XrefRangeEnd = 57681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebRequestModulesSection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestModulesSection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestModulesSection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x000612A4 File Offset: 0x0005F4A4
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57681, XrefRangeEnd = 57684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestModulesSection.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x0000AF21 File Offset: 0x00009121
		public WebRequestModulesSection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}

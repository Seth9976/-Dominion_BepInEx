using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x0200015F RID: 351
	[DefaultMember("Item")]
	public sealed class WebRequestModuleElementCollection : ConfigurationElementCollection
	{
		// Token: 0x060015B4 RID: 5556 RVA: 0x0000AF2A File Offset: 0x0000912A
		// Note: this type is marked as 'beforefieldinit'.
		static WebRequestModuleElementCollection()
		{
			Il2CppClassPointerStore<WebRequestModuleElementCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "WebRequestModuleElementCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebRequestModuleElementCollection>.NativeClassPtr);
			WebRequestModuleElementCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebRequestModuleElementCollection>.NativeClassPtr, 100666285);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x000612E4 File Offset: 0x0005F4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57684, XrefRangeEnd = 57687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebRequestModuleElementCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebRequestModuleElementCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebRequestModuleElementCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x0000AF63 File Offset: 0x00009163
		public WebRequestModuleElementCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

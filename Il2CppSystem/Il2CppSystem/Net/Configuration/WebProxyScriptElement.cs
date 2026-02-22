using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x0200015D RID: 349
	public sealed class WebProxyScriptElement : ConfigurationElement
	{
		// Token: 0x060015AC RID: 5548 RVA: 0x0006113C File Offset: 0x0005F33C
		// Note: this type is marked as 'beforefieldinit'.
		static WebProxyScriptElement()
		{
			Il2CppClassPointerStore<WebProxyScriptElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "WebProxyScriptElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebProxyScriptElement>.NativeClassPtr);
			WebProxyScriptElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxyScriptElement>.NativeClassPtr, 100666281);
			WebProxyScriptElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebProxyScriptElement>.NativeClassPtr, 100666282);
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x00061194 File Offset: 0x0005F394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57672, XrefRangeEnd = 57675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WebProxyScriptElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WebProxyScriptElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxyScriptElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x000611D0 File Offset: 0x0005F3D0
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57675, XrefRangeEnd = 57678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebProxyScriptElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x0000AF18 File Offset: 0x00009118
		public WebProxyScriptElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}

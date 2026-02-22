using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000156 RID: 342
	public sealed class HttpWebRequestElement : ConfigurationElement
	{
		// Token: 0x06001591 RID: 5521 RVA: 0x00060C08 File Offset: 0x0005EE08
		// Note: this type is marked as 'beforefieldinit'.
		static HttpWebRequestElement()
		{
			Il2CppClassPointerStore<HttpWebRequestElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "HttpWebRequestElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequestElement>.NativeClassPtr);
			HttpWebRequestElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequestElement>.NativeClassPtr, 100666268);
			HttpWebRequestElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequestElement>.NativeClassPtr, 100666269);
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00060C60 File Offset: 0x0005EE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57633, XrefRangeEnd = 57636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebRequestElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequestElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequestElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x00060C9C File Offset: 0x0005EE9C
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57636, XrefRangeEnd = 57639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequestElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x0000AEA0 File Offset: 0x000090A0
		public HttpWebRequestElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}

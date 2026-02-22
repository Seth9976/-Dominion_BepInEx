using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000155 RID: 341
	public sealed class ProxyElement : ConfigurationElement
	{
		// Token: 0x0600158D RID: 5517 RVA: 0x00060B34 File Offset: 0x0005ED34
		// Note: this type is marked as 'beforefieldinit'.
		static ProxyElement()
		{
			Il2CppClassPointerStore<ProxyElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "ProxyElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProxyElement>.NativeClassPtr);
			ProxyElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyElement>.NativeClassPtr, 100666266);
			ProxyElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyElement>.NativeClassPtr, 100666267);
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x00060B8C File Offset: 0x0005ED8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57627, XrefRangeEnd = 57630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProxyElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProxyElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x0600158F RID: 5519 RVA: 0x00060BC8 File Offset: 0x0005EDC8
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57630, XrefRangeEnd = 57633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x0000AE97 File Offset: 0x00009097
		public ProxyElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}

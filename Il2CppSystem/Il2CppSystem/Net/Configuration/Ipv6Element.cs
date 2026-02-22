using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000157 RID: 343
	public sealed class Ipv6Element : ConfigurationElement
	{
		// Token: 0x06001595 RID: 5525 RVA: 0x00060CDC File Offset: 0x0005EEDC
		// Note: this type is marked as 'beforefieldinit'.
		static Ipv6Element()
		{
			Il2CppClassPointerStore<Ipv6Element>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "Ipv6Element");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ipv6Element>.NativeClassPtr);
			Ipv6Element.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ipv6Element>.NativeClassPtr, 100666270);
			Ipv6Element.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ipv6Element>.NativeClassPtr, 100666271);
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00060D34 File Offset: 0x0005EF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57639, XrefRangeEnd = 57642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ipv6Element()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ipv6Element>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ipv6Element.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x00060D70 File Offset: 0x0005EF70
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57642, XrefRangeEnd = 57645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ipv6Element.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x0000AEA9 File Offset: 0x000090A9
		public Ipv6Element(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}

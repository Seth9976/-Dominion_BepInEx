using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000150 RID: 336
	[DefaultMember("Item")]
	public sealed class BypassElementCollection : ConfigurationElementCollection
	{
		// Token: 0x0600157C RID: 5500 RVA: 0x0000ADD3 File Offset: 0x00008FD3
		// Note: this type is marked as 'beforefieldinit'.
		static BypassElementCollection()
		{
			Il2CppClassPointerStore<BypassElementCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "BypassElementCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BypassElementCollection>.NativeClassPtr);
			BypassElementCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassElementCollection>.NativeClassPtr, 100666259);
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x000608BC File Offset: 0x0005EABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57606, XrefRangeEnd = 57609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BypassElementCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BypassElementCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassElementCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x0000AE0C File Offset: 0x0000900C
		public BypassElementCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001136 RID: 4406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

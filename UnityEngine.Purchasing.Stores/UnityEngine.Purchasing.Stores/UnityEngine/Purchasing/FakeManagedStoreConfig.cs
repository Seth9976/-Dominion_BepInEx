using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200005D RID: 93
	public class FakeManagedStoreConfig : Object
	{
		// Token: 0x06000371 RID: 881 RVA: 0x00003B32 File Offset: 0x00001D32
		// Note: this type is marked as 'beforefieldinit'.
		static FakeManagedStoreConfig()
		{
			Il2CppClassPointerStore<FakeManagedStoreConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "FakeManagedStoreConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FakeManagedStoreConfig>.NativeClassPtr);
			FakeManagedStoreConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeManagedStoreConfig>.NativeClassPtr, 100663727);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00011550 File Offset: 0x0000F750
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FakeManagedStoreConfig()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FakeManagedStoreConfig>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeManagedStoreConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00003B6B File Offset: 0x00001D6B
		public FakeManagedStoreConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

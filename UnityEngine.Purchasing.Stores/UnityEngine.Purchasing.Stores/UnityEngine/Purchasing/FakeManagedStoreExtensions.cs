using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200005E RID: 94
	public class FakeManagedStoreExtensions : Object
	{
		// Token: 0x06000374 RID: 884 RVA: 0x00003B74 File Offset: 0x00001D74
		// Note: this type is marked as 'beforefieldinit'.
		static FakeManagedStoreExtensions()
		{
			Il2CppClassPointerStore<FakeManagedStoreExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "FakeManagedStoreExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FakeManagedStoreExtensions>.NativeClassPtr);
			FakeManagedStoreExtensions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeManagedStoreExtensions>.NativeClassPtr, 100663728);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0001158C File Offset: 0x0000F78C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FakeManagedStoreExtensions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FakeManagedStoreExtensions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeManagedStoreExtensions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00003BAD File Offset: 0x00001DAD
		public FakeManagedStoreExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

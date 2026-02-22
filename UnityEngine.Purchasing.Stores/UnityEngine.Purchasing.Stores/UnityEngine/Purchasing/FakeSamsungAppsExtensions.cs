using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000037 RID: 55
	public class FakeSamsungAppsExtensions : Object
	{
		// Token: 0x060001CC RID: 460 RVA: 0x00002E05 File Offset: 0x00001005
		// Note: this type is marked as 'beforefieldinit'.
		static FakeSamsungAppsExtensions()
		{
			Il2CppClassPointerStore<FakeSamsungAppsExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "FakeSamsungAppsExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FakeSamsungAppsExtensions>.NativeClassPtr);
			FakeSamsungAppsExtensions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeSamsungAppsExtensions>.NativeClassPtr, 100663518);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000BE40 File Offset: 0x0000A040
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FakeSamsungAppsExtensions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FakeSamsungAppsExtensions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeSamsungAppsExtensions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002E3E File Offset: 0x0000103E
		public FakeSamsungAppsExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

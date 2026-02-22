using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001C RID: 28
	public class FakeGooglePlayStoreConfiguration : Object
	{
		// Token: 0x060000F6 RID: 246 RVA: 0x0000271C File Offset: 0x0000091C
		// Note: this type is marked as 'beforefieldinit'.
		static FakeGooglePlayStoreConfiguration()
		{
			Il2CppClassPointerStore<FakeGooglePlayStoreConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "FakeGooglePlayStoreConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FakeGooglePlayStoreConfiguration>.NativeClassPtr);
			FakeGooglePlayStoreConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeGooglePlayStoreConfiguration>.NativeClassPtr, 100663423);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00009100 File Offset: 0x00007300
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FakeGooglePlayStoreConfiguration()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FakeGooglePlayStoreConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeGooglePlayStoreConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002755 File Offset: 0x00000955
		public FakeGooglePlayStoreConfiguration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

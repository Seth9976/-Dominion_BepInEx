using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001D RID: 29
	public class FakeGooglePlayStoreExtensions : Object
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x0000275E File Offset: 0x0000095E
		// Note: this type is marked as 'beforefieldinit'.
		static FakeGooglePlayStoreExtensions()
		{
			Il2CppClassPointerStore<FakeGooglePlayStoreExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "FakeGooglePlayStoreExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FakeGooglePlayStoreExtensions>.NativeClassPtr);
			FakeGooglePlayStoreExtensions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeGooglePlayStoreExtensions>.NativeClassPtr, 100663424);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000913C File Offset: 0x0000733C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FakeGooglePlayStoreExtensions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FakeGooglePlayStoreExtensions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeGooglePlayStoreExtensions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002797 File Offset: 0x00000997
		public FakeGooglePlayStoreExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

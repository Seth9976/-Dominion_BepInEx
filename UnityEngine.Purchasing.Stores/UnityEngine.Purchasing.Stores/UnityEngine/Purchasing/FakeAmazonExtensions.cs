using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000004 RID: 4
	public class FakeAmazonExtensions : Object
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002081 File Offset: 0x00000281
		// Note: this type is marked as 'beforefieldinit'.
		static FakeAmazonExtensions()
		{
			Il2CppClassPointerStore<FakeAmazonExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "FakeAmazonExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FakeAmazonExtensions>.NativeClassPtr);
			FakeAmazonExtensions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeAmazonExtensions>.NativeClassPtr, 100663315);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000061B4 File Offset: 0x000043B4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FakeAmazonExtensions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FakeAmazonExtensions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeAmazonExtensions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020BA File Offset: 0x000002BA
		public FakeAmazonExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

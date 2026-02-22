using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200004A RID: 74
	public class FakeAppleConfiguation : Object
	{
		// Token: 0x06000275 RID: 629 RVA: 0x000032A9 File Offset: 0x000014A9
		// Note: this type is marked as 'beforefieldinit'.
		static FakeAppleConfiguation()
		{
			Il2CppClassPointerStore<FakeAppleConfiguation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "FakeAppleConfiguation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FakeAppleConfiguation>.NativeClassPtr);
			FakeAppleConfiguation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeAppleConfiguation>.NativeClassPtr, 100663619);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000E170 File Offset: 0x0000C370
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FakeAppleConfiguation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FakeAppleConfiguation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeAppleConfiguation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x000032E2 File Offset: 0x000014E2
		public FakeAppleConfiguation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

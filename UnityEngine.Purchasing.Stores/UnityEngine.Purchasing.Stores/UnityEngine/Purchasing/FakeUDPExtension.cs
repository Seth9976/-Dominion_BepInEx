using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200003D RID: 61
	public class FakeUDPExtension : Object
	{
		// Token: 0x060001ED RID: 493 RVA: 0x00002F45 File Offset: 0x00001145
		// Note: this type is marked as 'beforefieldinit'.
		static FakeUDPExtension()
		{
			Il2CppClassPointerStore<FakeUDPExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "FakeUDPExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FakeUDPExtension>.NativeClassPtr);
			FakeUDPExtension.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeUDPExtension>.NativeClassPtr, 100663539);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000C41C File Offset: 0x0000A61C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FakeUDPExtension()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FakeUDPExtension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeUDPExtension.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002F7E File Offset: 0x0000117E
		public FakeUDPExtension(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

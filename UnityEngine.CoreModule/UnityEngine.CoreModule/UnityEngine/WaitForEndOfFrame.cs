using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000C7 RID: 199
	public sealed class WaitForEndOfFrame : YieldInstruction
	{
		// Token: 0x0600117F RID: 4479 RVA: 0x0000A738 File Offset: 0x00008938
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForEndOfFrame()
		{
			Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitForEndOfFrame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr);
			WaitForEndOfFrame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr, 100664529);
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00047258 File Offset: 0x00045458
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForEndOfFrame()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForEndOfFrame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x0000A771 File Offset: 0x00008971
		public WaitForEndOfFrame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

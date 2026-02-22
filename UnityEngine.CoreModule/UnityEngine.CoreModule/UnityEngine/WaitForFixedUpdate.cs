using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000C8 RID: 200
	public sealed class WaitForFixedUpdate : YieldInstruction
	{
		// Token: 0x06001182 RID: 4482 RVA: 0x0000A77A File Offset: 0x0000897A
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForFixedUpdate()
		{
			Il2CppClassPointerStore<WaitForFixedUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitForFixedUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForFixedUpdate>.NativeClassPtr);
			WaitForFixedUpdate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForFixedUpdate>.NativeClassPtr, 100664530);
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x00047294 File Offset: 0x00045494
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForFixedUpdate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForFixedUpdate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForFixedUpdate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0000A7B3 File Offset: 0x000089B3
		public WaitForFixedUpdate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

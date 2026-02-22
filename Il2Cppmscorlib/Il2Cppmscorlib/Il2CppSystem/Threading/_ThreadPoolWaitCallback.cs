using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000283 RID: 643
	public static class _ThreadPoolWaitCallback : Object
	{
		// Token: 0x06002BE7 RID: 11239 RVA: 0x0000F49B File Offset: 0x0000D69B
		// Note: this type is marked as 'beforefieldinit'.
		static _ThreadPoolWaitCallback()
		{
			Il2CppClassPointerStore<_ThreadPoolWaitCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "_ThreadPoolWaitCallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_ThreadPoolWaitCallback>.NativeClassPtr);
			_ThreadPoolWaitCallback.NativeMethodInfoPtr_PerformWaitCallback_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ThreadPoolWaitCallback>.NativeClassPtr, 100670278);
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x000E0810 File Offset: 0x000DEA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333276, XrefRangeEnd = 333280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool PerformWaitCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_ThreadPoolWaitCallback.NativeMethodInfoPtr_PerformWaitCallback_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x0000F4D4 File Offset: 0x0000D6D4
		public _ThreadPoolWaitCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002632 RID: 9778
		private static readonly IntPtr NativeMethodInfoPtr_PerformWaitCallback_Internal_Static_Boolean_0;
	}
}

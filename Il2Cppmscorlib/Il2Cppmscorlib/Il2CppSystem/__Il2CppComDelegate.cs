using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200052E RID: 1326
	public sealed class __Il2CppComDelegate : __Il2CppComObject
	{
		// Token: 0x06004D57 RID: 19799 RVA: 0x0001D3E8 File Offset: 0x0001B5E8
		// Note: this type is marked as 'beforefieldinit'.
		static __Il2CppComDelegate()
		{
			Il2CppClassPointerStore<__Il2CppComDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "__Il2CppComDelegate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__Il2CppComDelegate>.NativeClassPtr);
			__Il2CppComDelegate.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Il2CppComDelegate>.NativeClassPtr, 100674558);
		}

		// Token: 0x06004D58 RID: 19800 RVA: 0x0015D394 File Offset: 0x0015B594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Il2CppComDelegate.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D59 RID: 19801 RVA: 0x0001D421 File Offset: 0x0001B621
		public __Il2CppComDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003E35 RID: 15925
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}

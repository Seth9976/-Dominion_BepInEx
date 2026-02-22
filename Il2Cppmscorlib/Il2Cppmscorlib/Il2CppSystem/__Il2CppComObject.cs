using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200052D RID: 1325
	public class __Il2CppComObject : Object
	{
		// Token: 0x06004D54 RID: 19796 RVA: 0x0001D3A6 File Offset: 0x0001B5A6
		// Note: this type is marked as 'beforefieldinit'.
		static __Il2CppComObject()
		{
			Il2CppClassPointerStore<__Il2CppComObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "__Il2CppComObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__Il2CppComObject>.NativeClassPtr);
			__Il2CppComObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Il2CppComObject>.NativeClassPtr, 100674557);
		}

		// Token: 0x06004D55 RID: 19797 RVA: 0x0015D358 File Offset: 0x0015B558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375113, XrefRangeEnd = 375121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), __Il2CppComObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D56 RID: 19798 RVA: 0x0001D3DF File Offset: 0x0001B5DF
		public __Il2CppComObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003E34 RID: 15924
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}

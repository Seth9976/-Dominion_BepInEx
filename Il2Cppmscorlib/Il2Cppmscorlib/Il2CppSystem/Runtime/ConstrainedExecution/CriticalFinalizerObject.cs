using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.ConstrainedExecution
{
	// Token: 0x0200040F RID: 1039
	public class CriticalFinalizerObject : Object
	{
		// Token: 0x0600416F RID: 16751 RVA: 0x0012E65C File Offset: 0x0012C85C
		// Note: this type is marked as 'beforefieldinit'.
		static CriticalFinalizerObject()
		{
			Il2CppClassPointerStore<CriticalFinalizerObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ConstrainedExecution", "CriticalFinalizerObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CriticalFinalizerObject>.NativeClassPtr);
			CriticalFinalizerObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CriticalFinalizerObject>.NativeClassPtr, 100672822);
			CriticalFinalizerObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CriticalFinalizerObject>.NativeClassPtr, 100672823);
		}

		// Token: 0x06004170 RID: 16752 RVA: 0x0012E6B4 File Offset: 0x0012C8B4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CriticalFinalizerObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CriticalFinalizerObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CriticalFinalizerObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004171 RID: 16753 RVA: 0x0012E6F0 File Offset: 0x0012C8F0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 356076, RefRangeEnd = 356082, XrefRangeStart = 356073, XrefRangeEnd = 356076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CriticalFinalizerObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004172 RID: 16754 RVA: 0x00018E3B File Offset: 0x0001703B
		public CriticalFinalizerObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003568 RID: 13672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04003569 RID: 13673
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}

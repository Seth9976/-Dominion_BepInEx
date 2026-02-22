using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004B5 RID: 1205
	[Serializable]
	public sealed class DebuggerHiddenAttribute : Attribute
	{
		// Token: 0x0600472F RID: 18223 RVA: 0x0001AD81 File Offset: 0x00018F81
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerHiddenAttribute()
		{
			Il2CppClassPointerStore<DebuggerHiddenAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggerHiddenAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerHiddenAttribute>.NativeClassPtr);
			DebuggerHiddenAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerHiddenAttribute>.NativeClassPtr, 100673868);
		}

		// Token: 0x06004730 RID: 18224 RVA: 0x00147810 File Offset: 0x00145A10
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggerHiddenAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerHiddenAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerHiddenAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004731 RID: 18225 RVA: 0x0001ADBA File Offset: 0x00018FBA
		public DebuggerHiddenAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040039BD RID: 14781
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

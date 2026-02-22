using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004B4 RID: 1204
	[Serializable]
	public sealed class DebuggerStepThroughAttribute : Attribute
	{
		// Token: 0x0600472C RID: 18220 RVA: 0x0001AD3F File Offset: 0x00018F3F
		// Note: this type is marked as 'beforefieldinit'.
		static DebuggerStepThroughAttribute()
		{
			Il2CppClassPointerStore<DebuggerStepThroughAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "DebuggerStepThroughAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebuggerStepThroughAttribute>.NativeClassPtr);
			DebuggerStepThroughAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebuggerStepThroughAttribute>.NativeClassPtr, 100673867);
		}

		// Token: 0x0600472D RID: 18221 RVA: 0x001477D4 File Offset: 0x001459D4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebuggerStepThroughAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebuggerStepThroughAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebuggerStepThroughAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600472E RID: 18222 RVA: 0x0001AD78 File Offset: 0x00018F78
		public DebuggerStepThroughAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040039BC RID: 14780
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

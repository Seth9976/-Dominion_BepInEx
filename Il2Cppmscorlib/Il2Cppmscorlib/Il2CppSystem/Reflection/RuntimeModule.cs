using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001D9 RID: 473
	public class RuntimeModule : Module
	{
		// Token: 0x06001E90 RID: 7824 RVA: 0x0000A787 File Offset: 0x00008987
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeModule()
		{
			Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "RuntimeModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr);
			RuntimeModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, 100668359);
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x000AAF88 File Offset: 0x000A9188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318861, RefRangeEnd = 318862, XrefRangeStart = 318857, XrefRangeEnd = 318861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x0000A7C0 File Offset: 0x000089C0
		public RuntimeModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001BD0 RID: 7120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	public class UnityEngineModuleAssembly : Attribute
	{
		// Token: 0x06000011 RID: 17 RVA: 0x0000213A File Offset: 0x0000033A
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEngineModuleAssembly()
		{
			Il2CppClassPointerStore<UnityEngineModuleAssembly>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine", "UnityEngineModuleAssembly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEngineModuleAssembly>.NativeClassPtr);
			UnityEngineModuleAssembly.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngineModuleAssembly>.NativeClassPtr, 100663300);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002954 File Offset: 0x00000B54
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngineModuleAssembly()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEngineModuleAssembly>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEngineModuleAssembly.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002173 File Offset: 0x00000373
		public UnityEngineModuleAssembly(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

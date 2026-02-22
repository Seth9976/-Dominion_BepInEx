using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.VFX
{
	// Token: 0x02000007 RID: 7
	public class VisualEffectObject : Object
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x000026C5 File Offset: 0x000008C5
		// Note: this type is marked as 'beforefieldinit'.
		static VisualEffectObject()
		{
			Il2CppClassPointerStore<VisualEffectObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VisualEffectObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualEffectObject>.NativeClassPtr);
			VisualEffectObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectObject>.NativeClassPtr, 100663318);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000041E8 File Offset: 0x000023E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158182, XrefRangeEnd = 158186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualEffectObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualEffectObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEffectObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000026FE File Offset: 0x000008FE
		public VisualEffectObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

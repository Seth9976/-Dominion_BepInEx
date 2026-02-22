using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x0200001B RID: 27
	public class PreventReadOnlyInstanceModificationAttribute : Attribute
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00002659 File Offset: 0x00000859
		// Note: this type is marked as 'beforefieldinit'.
		static PreventReadOnlyInstanceModificationAttribute()
		{
			Il2CppClassPointerStore<PreventReadOnlyInstanceModificationAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "PreventReadOnlyInstanceModificationAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreventReadOnlyInstanceModificationAttribute>.NativeClassPtr);
			PreventReadOnlyInstanceModificationAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreventReadOnlyInstanceModificationAttribute>.NativeClassPtr, 100663353);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000436C File Offset: 0x0000256C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreventReadOnlyInstanceModificationAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreventReadOnlyInstanceModificationAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreventReadOnlyInstanceModificationAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002692 File Offset: 0x00000892
		public PreventReadOnlyInstanceModificationAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

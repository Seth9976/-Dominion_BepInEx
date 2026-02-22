using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000022 RID: 34
	public sealed class NativeContainerSupportsMinMaxWriteRestrictionAttribute : Attribute
	{
		// Token: 0x060000FC RID: 252 RVA: 0x00002ABF File Offset: 0x00000CBF
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerSupportsMinMaxWriteRestrictionAttribute()
		{
			Il2CppClassPointerStore<NativeContainerSupportsMinMaxWriteRestrictionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerSupportsMinMaxWriteRestrictionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerSupportsMinMaxWriteRestrictionAttribute>.NativeClassPtr);
			NativeContainerSupportsMinMaxWriteRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeContainerSupportsMinMaxWriteRestrictionAttribute>.NativeClassPtr, 100663340);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00019694 File Offset: 0x00017894
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeContainerSupportsMinMaxWriteRestrictionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeContainerSupportsMinMaxWriteRestrictionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeContainerSupportsMinMaxWriteRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002AF8 File Offset: 0x00000CF8
		public NativeContainerSupportsMinMaxWriteRestrictionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

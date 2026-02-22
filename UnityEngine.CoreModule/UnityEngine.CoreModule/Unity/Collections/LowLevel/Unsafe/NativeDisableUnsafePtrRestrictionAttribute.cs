using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000028 RID: 40
	public sealed class NativeDisableUnsafePtrRestrictionAttribute : Attribute
	{
		// Token: 0x0600010C RID: 268 RVA: 0x00002C23 File Offset: 0x00000E23
		// Note: this type is marked as 'beforefieldinit'.
		static NativeDisableUnsafePtrRestrictionAttribute()
		{
			Il2CppClassPointerStore<NativeDisableUnsafePtrRestrictionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeDisableUnsafePtrRestrictionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeDisableUnsafePtrRestrictionAttribute>.NativeClassPtr);
			NativeDisableUnsafePtrRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeDisableUnsafePtrRestrictionAttribute>.NativeClassPtr, 100663344);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00019784 File Offset: 0x00017984
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeDisableUnsafePtrRestrictionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeDisableUnsafePtrRestrictionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeDisableUnsafePtrRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002C5C File Offset: 0x00000E5C
		public NativeDisableUnsafePtrRestrictionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

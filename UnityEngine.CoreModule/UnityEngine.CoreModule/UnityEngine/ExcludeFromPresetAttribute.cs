using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000A9 RID: 169
	public class ExcludeFromPresetAttribute : Attribute
	{
		// Token: 0x06000FFD RID: 4093 RVA: 0x00009FCF File Offset: 0x000081CF
		// Note: this type is marked as 'beforefieldinit'.
		static ExcludeFromPresetAttribute()
		{
			Il2CppClassPointerStore<ExcludeFromPresetAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExcludeFromPresetAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeFromPresetAttribute>.NativeClassPtr);
			ExcludeFromPresetAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeFromPresetAttribute>.NativeClassPtr, 100664331);
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00041CCC File Offset: 0x0003FECC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExcludeFromPresetAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeFromPresetAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExcludeFromPresetAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0000A008 File Offset: 0x00008208
		public ExcludeFromPresetAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

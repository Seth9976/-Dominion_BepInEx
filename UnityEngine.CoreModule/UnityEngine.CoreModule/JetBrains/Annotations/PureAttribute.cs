using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace JetBrains.Annotations
{
	// Token: 0x0200002D RID: 45
	public sealed class PureAttribute : Attribute
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00002E99 File Offset: 0x00001099
		// Note: this type is marked as 'beforefieldinit'.
		static PureAttribute()
		{
			Il2CppClassPointerStore<PureAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", "PureAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PureAttribute>.NativeClassPtr);
			PureAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PureAttribute>.NativeClassPtr, 100663354);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00019E98 File Offset: 0x00018098
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PureAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PureAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PureAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002ED2 File Offset: 0x000010D2
		public PureAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

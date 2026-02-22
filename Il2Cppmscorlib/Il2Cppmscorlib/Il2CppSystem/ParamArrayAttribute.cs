using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000D9 RID: 217
	public sealed class ParamArrayAttribute : Attribute
	{
		// Token: 0x06000E50 RID: 3664 RVA: 0x00005AAD File Offset: 0x00003CAD
		// Note: this type is marked as 'beforefieldinit'.
		static ParamArrayAttribute()
		{
			Il2CppClassPointerStore<ParamArrayAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ParamArrayAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParamArrayAttribute>.NativeClassPtr);
			ParamArrayAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParamArrayAttribute>.NativeClassPtr, 100665715);
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00063514 File Offset: 0x00061714
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParamArrayAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParamArrayAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParamArrayAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00005AE6 File Offset: 0x00003CE6
		public ParamArrayAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

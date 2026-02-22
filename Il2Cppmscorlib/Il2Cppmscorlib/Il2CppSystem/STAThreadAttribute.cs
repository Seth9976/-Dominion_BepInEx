using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000ED RID: 237
	public sealed class STAThreadAttribute : Attribute
	{
		// Token: 0x060010A5 RID: 4261 RVA: 0x000060F0 File Offset: 0x000042F0
		// Note: this type is marked as 'beforefieldinit'.
		static STAThreadAttribute()
		{
			Il2CppClassPointerStore<STAThreadAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "STAThreadAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<STAThreadAttribute>.NativeClassPtr);
			STAThreadAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<STAThreadAttribute>.NativeClassPtr, 100666160);
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x0006F598 File Offset: 0x0006D798
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe STAThreadAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<STAThreadAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(STAThreadAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x00006129 File Offset: 0x00004329
		public STAThreadAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

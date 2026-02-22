using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000252 RID: 594
	public class Punycode : Bootstring
	{
		// Token: 0x0600293C RID: 10556 RVA: 0x0000E53F File Offset: 0x0000C73F
		// Note: this type is marked as 'beforefieldinit'.
		static Punycode()
		{
			Il2CppClassPointerStore<Punycode>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "Punycode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Punycode>.NativeClassPtr);
			Punycode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Punycode>.NativeClassPtr, 100669889);
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x000D6A78 File Offset: 0x000D4C78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329955, RefRangeEnd = 329956, XrefRangeStart = 329954, XrefRangeEnd = 329955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Punycode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Punycode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Punycode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x0000E578 File Offset: 0x0000C778
		public Punycode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002461 RID: 9313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

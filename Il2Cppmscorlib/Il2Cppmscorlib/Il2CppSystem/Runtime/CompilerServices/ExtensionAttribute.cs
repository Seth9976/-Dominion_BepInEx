using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200042E RID: 1070
	public sealed class ExtensionAttribute : Attribute
	{
		// Token: 0x0600423A RID: 16954 RVA: 0x00019435 File Offset: 0x00017635
		// Note: this type is marked as 'beforefieldinit'.
		static ExtensionAttribute()
		{
			Il2CppClassPointerStore<ExtensionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ExtensionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtensionAttribute>.NativeClassPtr);
			ExtensionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionAttribute>.NativeClassPtr, 100672929);
		}

		// Token: 0x0600423B RID: 16955 RVA: 0x001311F0 File Offset: 0x0012F3F0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExtensionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtensionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600423C RID: 16956 RVA: 0x0001946E File Offset: 0x0001766E
		public ExtensionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040035E6 RID: 13798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

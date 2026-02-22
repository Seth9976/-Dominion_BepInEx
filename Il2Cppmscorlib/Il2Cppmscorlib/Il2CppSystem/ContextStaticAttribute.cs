using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000090 RID: 144
	[Serializable]
	public class ContextStaticAttribute : Attribute
	{
		// Token: 0x06000881 RID: 2177 RVA: 0x00004905 File Offset: 0x00002B05
		// Note: this type is marked as 'beforefieldinit'.
		static ContextStaticAttribute()
		{
			Il2CppClassPointerStore<ContextStaticAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ContextStaticAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextStaticAttribute>.NativeClassPtr);
			ContextStaticAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextStaticAttribute>.NativeClassPtr, 100664651);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00048248 File Offset: 0x00046448
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextStaticAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextStaticAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextStaticAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x0000493E File Offset: 0x00002B3E
		public ContextStaticAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

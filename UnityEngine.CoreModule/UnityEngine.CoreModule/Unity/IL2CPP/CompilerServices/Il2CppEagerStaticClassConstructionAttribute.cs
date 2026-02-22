using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IL2CPP.CompilerServices
{
	// Token: 0x0200000D RID: 13
	public class Il2CppEagerStaticClassConstructionAttribute : Attribute
	{
		// Token: 0x06000058 RID: 88 RVA: 0x000023C8 File Offset: 0x000005C8
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppEagerStaticClassConstructionAttribute()
		{
			Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IL2CPP.CompilerServices", "Il2CppEagerStaticClassConstructionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr);
			Il2CppEagerStaticClassConstructionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr, 100663313);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000182E0 File Offset: 0x000164E0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppEagerStaticClassConstructionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppEagerStaticClassConstructionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002401 File Offset: 0x00000601
		public Il2CppEagerStaticClassConstructionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

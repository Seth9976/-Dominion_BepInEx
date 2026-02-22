using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000B2 RID: 178
	public sealed class ExtensionOfNativeClassAttribute : Attribute
	{
		// Token: 0x06001056 RID: 4182 RVA: 0x0000A202 File Offset: 0x00008402
		// Note: this type is marked as 'beforefieldinit'.
		static ExtensionOfNativeClassAttribute()
		{
			Il2CppClassPointerStore<ExtensionOfNativeClassAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExtensionOfNativeClassAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtensionOfNativeClassAttribute>.NativeClassPtr);
			ExtensionOfNativeClassAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtensionOfNativeClassAttribute>.NativeClassPtr, 100664369);
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00042DF0 File Offset: 0x00040FF0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExtensionOfNativeClassAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExtensionOfNativeClassAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExtensionOfNativeClassAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0000A23B File Offset: 0x0000843B
		public ExtensionOfNativeClassAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

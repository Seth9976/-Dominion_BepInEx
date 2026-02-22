using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000449 RID: 1097
	public sealed class OptionalAttribute : Attribute
	{
		// Token: 0x060042BC RID: 17084 RVA: 0x0001995E File Offset: 0x00017B5E
		// Note: this type is marked as 'beforefieldinit'.
		static OptionalAttribute()
		{
			Il2CppClassPointerStore<OptionalAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "OptionalAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionalAttribute>.NativeClassPtr);
			OptionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalAttribute>.NativeClassPtr, 100672972);
		}

		// Token: 0x060042BD RID: 17085 RVA: 0x001328D0 File Offset: 0x00130AD0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionalAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionalAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x00019997 File Offset: 0x00017B97
		public OptionalAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003681 RID: 13953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

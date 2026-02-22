using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000448 RID: 1096
	public sealed class OutAttribute : Attribute
	{
		// Token: 0x060042B9 RID: 17081 RVA: 0x0001991C File Offset: 0x00017B1C
		// Note: this type is marked as 'beforefieldinit'.
		static OutAttribute()
		{
			Il2CppClassPointerStore<OutAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "OutAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutAttribute>.NativeClassPtr);
			OutAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutAttribute>.NativeClassPtr, 100672971);
		}

		// Token: 0x060042BA RID: 17082 RVA: 0x00132894 File Offset: 0x00130A94
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OutAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x00019955 File Offset: 0x00017B55
		public OutAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003680 RID: 13952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

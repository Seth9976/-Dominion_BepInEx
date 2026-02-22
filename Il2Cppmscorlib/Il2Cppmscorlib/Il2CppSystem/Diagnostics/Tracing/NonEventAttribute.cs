using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x0200051A RID: 1306
	public sealed class NonEventAttribute : Attribute
	{
		// Token: 0x06004B96 RID: 19350 RVA: 0x0001C709 File Offset: 0x0001A909
		// Note: this type is marked as 'beforefieldinit'.
		static NonEventAttribute()
		{
			Il2CppClassPointerStore<NonEventAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "NonEventAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonEventAttribute>.NativeClassPtr);
			NonEventAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonEventAttribute>.NativeClassPtr, 100674466);
		}

		// Token: 0x06004B97 RID: 19351 RVA: 0x00159344 File Offset: 0x00157544
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NonEventAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NonEventAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonEventAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B98 RID: 19352 RVA: 0x0001C742 File Offset: 0x0001A942
		public NonEventAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003CFF RID: 15615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000BE RID: 190
	public class SelectionBaseAttribute : Attribute
	{
		// Token: 0x060010FD RID: 4349 RVA: 0x0000A4F0 File Offset: 0x000086F0
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionBaseAttribute()
		{
			Il2CppClassPointerStore<SelectionBaseAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SelectionBaseAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionBaseAttribute>.NativeClassPtr);
			SelectionBaseAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionBaseAttribute>.NativeClassPtr, 100664459);
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x00045500 File Offset: 0x00043700
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionBaseAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionBaseAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionBaseAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x0000A529 File Offset: 0x00008729
		public SelectionBaseAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

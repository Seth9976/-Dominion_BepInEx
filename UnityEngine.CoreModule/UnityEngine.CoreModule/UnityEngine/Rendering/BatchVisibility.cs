using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200013C RID: 316
	[StructLayout(2)]
	public struct BatchVisibility
	{
		// Token: 0x060017CB RID: 6091 RVA: 0x00058F64 File Offset: 0x00057164
		// Note: this type is marked as 'beforefieldinit'.
		static BatchVisibility()
		{
			Il2CppClassPointerStore<BatchVisibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchVisibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchVisibility>.NativeClassPtr);
			BatchVisibility.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchVisibility>.NativeClassPtr, "offset");
			BatchVisibility.NativeFieldInfoPtr_instancesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchVisibility>.NativeClassPtr, "instancesCount");
			BatchVisibility.NativeFieldInfoPtr_visibleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchVisibility>.NativeClassPtr, "visibleCount");
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x0000D4E3 File Offset: 0x0000B6E3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchVisibility>.NativeClassPtr, ref this));
		}

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeFieldInfoPtr_instancesCount;

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeFieldInfoPtr_visibleCount;

		// Token: 0x040011B2 RID: 4530
		[FieldOffset(0)]
		public readonly int offset;

		// Token: 0x040011B3 RID: 4531
		[FieldOffset(4)]
		public readonly int instancesCount;

		// Token: 0x040011B4 RID: 4532
		[FieldOffset(8)]
		public int visibleCount;
	}
}

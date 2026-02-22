using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000CB RID: 203
	[Serializable]
	[StructLayout(2)]
	public struct VectorImageVertex
	{
		// Token: 0x06000B87 RID: 2951 RVA: 0x00030014 File Offset: 0x0002E214
		// Note: this type is marked as 'beforefieldinit'.
		static VectorImageVertex()
		{
			Il2CppClassPointerStore<VectorImageVertex>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VectorImageVertex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VectorImageVertex>.NativeClassPtr);
			VectorImageVertex.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageVertex>.NativeClassPtr, "position");
			VectorImageVertex.NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageVertex>.NativeClassPtr, "tint");
			VectorImageVertex.NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageVertex>.NativeClassPtr, "uv");
			VectorImageVertex.NativeFieldInfoPtr_settingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageVertex>.NativeClassPtr, "settingIndex");
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x000073A0 File Offset: 0x000055A0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VectorImageVertex>.NativeClassPtr, ref this));
		}

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeFieldInfoPtr_tint;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeFieldInfoPtr_uv;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeFieldInfoPtr_settingIndex;

		// Token: 0x0400063E RID: 1598
		[FieldOffset(0)]
		public Vector3 position;

		// Token: 0x0400063F RID: 1599
		[FieldOffset(12)]
		public Color32 tint;

		// Token: 0x04000640 RID: 1600
		[FieldOffset(16)]
		public Vector2 uv;

		// Token: 0x04000641 RID: 1601
		[FieldOffset(24)]
		public uint settingIndex;
	}
}

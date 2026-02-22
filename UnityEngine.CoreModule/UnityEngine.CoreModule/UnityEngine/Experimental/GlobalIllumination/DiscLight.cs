using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x02000160 RID: 352
	[StructLayout(2)]
	public struct DiscLight
	{
		// Token: 0x06001A8F RID: 6799 RVA: 0x0005EC30 File Offset: 0x0005CE30
		// Note: this type is marked as 'beforefieldinit'.
		static DiscLight()
		{
			Il2CppClassPointerStore<DiscLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "DiscLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscLight>.NativeClassPtr);
			DiscLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "instanceID");
			DiscLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "shadow");
			DiscLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "mode");
			DiscLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "position");
			DiscLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "orientation");
			DiscLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "color");
			DiscLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "indirectColor");
			DiscLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "range");
			DiscLight.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "radius");
			DiscLight.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, "falloff");
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x0000EBA8 File Offset: 0x0000CDA8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, ref this));
		}

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeFieldInfoPtr_radius;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x040013D6 RID: 5078
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x040013D7 RID: 5079
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x040013D8 RID: 5080
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x040013D9 RID: 5081
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x040013DA RID: 5082
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x040013DB RID: 5083
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x040013DC RID: 5084
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x040013DD RID: 5085
		[FieldOffset(68)]
		public float range;

		// Token: 0x040013DE RID: 5086
		[FieldOffset(72)]
		public float radius;

		// Token: 0x040013DF RID: 5087
		[FieldOffset(76)]
		public FalloffType falloff;
	}
}

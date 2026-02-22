using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200015F RID: 351
	[StructLayout(2)]
	public struct RectangleLight
	{
		// Token: 0x06001A8D RID: 6797 RVA: 0x0005EB24 File Offset: 0x0005CD24
		// Note: this type is marked as 'beforefieldinit'.
		static RectangleLight()
		{
			Il2CppClassPointerStore<RectangleLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "RectangleLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr);
			RectangleLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "instanceID");
			RectangleLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "shadow");
			RectangleLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "mode");
			RectangleLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "position");
			RectangleLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "orientation");
			RectangleLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "color");
			RectangleLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "indirectColor");
			RectangleLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "range");
			RectangleLight.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "width");
			RectangleLight.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "height");
			RectangleLight.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "falloff");
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x0000EB96 File Offset: 0x0000CD96
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, ref this));
		}

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x040013BE RID: 5054
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x040013C1 RID: 5057
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x040013C2 RID: 5058
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x040013C3 RID: 5059
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x040013C4 RID: 5060
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x040013C5 RID: 5061
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x040013C6 RID: 5062
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x040013C7 RID: 5063
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x040013C8 RID: 5064
		[FieldOffset(68)]
		public float range;

		// Token: 0x040013C9 RID: 5065
		[FieldOffset(72)]
		public float width;

		// Token: 0x040013CA RID: 5066
		[FieldOffset(76)]
		public float height;

		// Token: 0x040013CB RID: 5067
		[FieldOffset(80)]
		public FalloffType falloff;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200015E RID: 350
	[StructLayout(2)]
	public struct SpotLight
	{
		// Token: 0x06001A8B RID: 6795 RVA: 0x0005E9F0 File Offset: 0x0005CBF0
		// Note: this type is marked as 'beforefieldinit'.
		static SpotLight()
		{
			Il2CppClassPointerStore<SpotLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "SpotLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpotLight>.NativeClassPtr);
			SpotLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "instanceID");
			SpotLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "shadow");
			SpotLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "mode");
			SpotLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "position");
			SpotLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "orientation");
			SpotLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "color");
			SpotLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "indirectColor");
			SpotLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "range");
			SpotLight.NativeFieldInfoPtr_sphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "sphereRadius");
			SpotLight.NativeFieldInfoPtr_coneAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "coneAngle");
			SpotLight.NativeFieldInfoPtr_innerConeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "innerConeAngle");
			SpotLight.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "falloff");
			SpotLight.NativeFieldInfoPtr_angularFalloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "angularFalloff");
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x0000EB84 File Offset: 0x0000CD84
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, ref this));
		}

		// Token: 0x0400139C RID: 5020
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x0400139D RID: 5021
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeFieldInfoPtr_sphereRadius;

		// Token: 0x040013A5 RID: 5029
		private static readonly IntPtr NativeFieldInfoPtr_coneAngle;

		// Token: 0x040013A6 RID: 5030
		private static readonly IntPtr NativeFieldInfoPtr_innerConeAngle;

		// Token: 0x040013A7 RID: 5031
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x040013A8 RID: 5032
		private static readonly IntPtr NativeFieldInfoPtr_angularFalloff;

		// Token: 0x040013A9 RID: 5033
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x040013AA RID: 5034
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x040013AB RID: 5035
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x040013AC RID: 5036
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x040013AD RID: 5037
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x040013AE RID: 5038
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x040013AF RID: 5039
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x040013B0 RID: 5040
		[FieldOffset(68)]
		public float range;

		// Token: 0x040013B1 RID: 5041
		[FieldOffset(72)]
		public float sphereRadius;

		// Token: 0x040013B2 RID: 5042
		[FieldOffset(76)]
		public float coneAngle;

		// Token: 0x040013B3 RID: 5043
		[FieldOffset(80)]
		public float innerConeAngle;

		// Token: 0x040013B4 RID: 5044
		[FieldOffset(84)]
		public FalloffType falloff;

		// Token: 0x040013B5 RID: 5045
		[FieldOffset(85)]
		public AngularFalloffType angularFalloff;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200015D RID: 349
	[StructLayout(2)]
	public struct PointLight
	{
		// Token: 0x06001A89 RID: 6793 RVA: 0x0005E8F8 File Offset: 0x0005CAF8
		// Note: this type is marked as 'beforefieldinit'.
		static PointLight()
		{
			Il2CppClassPointerStore<PointLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "PointLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointLight>.NativeClassPtr);
			PointLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "instanceID");
			PointLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "shadow");
			PointLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "mode");
			PointLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "position");
			PointLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "orientation");
			PointLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "color");
			PointLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "indirectColor");
			PointLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "range");
			PointLight.NativeFieldInfoPtr_sphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "sphereRadius");
			PointLight.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, "falloff");
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x0000EB72 File Offset: 0x0000CD72
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PointLight>.NativeClassPtr, ref this));
		}

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeFieldInfoPtr_sphereRadius;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x04001392 RID: 5010
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x04001393 RID: 5011
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x04001394 RID: 5012
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x04001395 RID: 5013
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x04001396 RID: 5014
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x04001397 RID: 5015
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x04001398 RID: 5016
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x04001399 RID: 5017
		[FieldOffset(68)]
		public float range;

		// Token: 0x0400139A RID: 5018
		[FieldOffset(72)]
		public float sphereRadius;

		// Token: 0x0400139B RID: 5019
		[FieldOffset(76)]
		public FalloffType falloff;
	}
}

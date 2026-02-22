using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200015C RID: 348
	[StructLayout(2)]
	public struct DirectionalLight
	{
		// Token: 0x06001A87 RID: 6791 RVA: 0x0005E814 File Offset: 0x0005CA14
		// Note: this type is marked as 'beforefieldinit'.
		static DirectionalLight()
		{
			Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "DirectionalLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr);
			DirectionalLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "instanceID");
			DirectionalLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "shadow");
			DirectionalLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "mode");
			DirectionalLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "position");
			DirectionalLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "orientation");
			DirectionalLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "color");
			DirectionalLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "indirectColor");
			DirectionalLight.NativeFieldInfoPtr_penumbraWidthRadian = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "penumbraWidthRadian");
			DirectionalLight.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "direction");
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0000EB60 File Offset: 0x0000CD60
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, ref this));
		}

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x04001377 RID: 4983
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x0400137A RID: 4986
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x0400137B RID: 4987
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400137C RID: 4988
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x0400137D RID: 4989
		private static readonly IntPtr NativeFieldInfoPtr_penumbraWidthRadian;

		// Token: 0x0400137E RID: 4990
		private static readonly IntPtr NativeFieldInfoPtr_direction;

		// Token: 0x0400137F RID: 4991
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x04001380 RID: 4992
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool shadow;

		// Token: 0x04001381 RID: 4993
		[FieldOffset(5)]
		public LightMode mode;

		// Token: 0x04001382 RID: 4994
		[FieldOffset(8)]
		public Vector3 position;

		// Token: 0x04001383 RID: 4995
		[FieldOffset(20)]
		public Quaternion orientation;

		// Token: 0x04001384 RID: 4996
		[FieldOffset(36)]
		public LinearColor color;

		// Token: 0x04001385 RID: 4997
		[FieldOffset(52)]
		public LinearColor indirectColor;

		// Token: 0x04001386 RID: 4998
		[FieldOffset(68)]
		public float penumbraWidthRadian;

		// Token: 0x04001387 RID: 4999
		[FieldOffset(72)]
		public Vector3 direction;
	}
}

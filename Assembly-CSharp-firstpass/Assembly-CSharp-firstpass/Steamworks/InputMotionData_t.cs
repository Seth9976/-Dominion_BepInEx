using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002AB RID: 683
	[StructLayout(2)]
	public struct InputMotionData_t
	{
		// Token: 0x06002740 RID: 10048 RVA: 0x000ABDA8 File Offset: 0x000A9FA8
		// Note: this type is marked as 'beforefieldinit'.
		static InputMotionData_t()
		{
			Il2CppClassPointerStore<InputMotionData_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "InputMotionData_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputMotionData_t>.NativeClassPtr);
			InputMotionData_t.NativeFieldInfoPtr_rotQuatX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMotionData_t>.NativeClassPtr, "rotQuatX");
			InputMotionData_t.NativeFieldInfoPtr_rotQuatY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMotionData_t>.NativeClassPtr, "rotQuatY");
			InputMotionData_t.NativeFieldInfoPtr_rotQuatZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMotionData_t>.NativeClassPtr, "rotQuatZ");
			InputMotionData_t.NativeFieldInfoPtr_rotQuatW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMotionData_t>.NativeClassPtr, "rotQuatW");
			InputMotionData_t.NativeFieldInfoPtr_posAccelX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMotionData_t>.NativeClassPtr, "posAccelX");
			InputMotionData_t.NativeFieldInfoPtr_posAccelY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMotionData_t>.NativeClassPtr, "posAccelY");
			InputMotionData_t.NativeFieldInfoPtr_posAccelZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMotionData_t>.NativeClassPtr, "posAccelZ");
			InputMotionData_t.NativeFieldInfoPtr_rotVelX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMotionData_t>.NativeClassPtr, "rotVelX");
			InputMotionData_t.NativeFieldInfoPtr_rotVelY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMotionData_t>.NativeClassPtr, "rotVelY");
			InputMotionData_t.NativeFieldInfoPtr_rotVelZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputMotionData_t>.NativeClassPtr, "rotVelZ");
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x0000FABA File Offset: 0x0000DCBA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputMotionData_t>.NativeClassPtr, ref this));
		}

		// Token: 0x0400266C RID: 9836
		private static readonly IntPtr NativeFieldInfoPtr_rotQuatX;

		// Token: 0x0400266D RID: 9837
		private static readonly IntPtr NativeFieldInfoPtr_rotQuatY;

		// Token: 0x0400266E RID: 9838
		private static readonly IntPtr NativeFieldInfoPtr_rotQuatZ;

		// Token: 0x0400266F RID: 9839
		private static readonly IntPtr NativeFieldInfoPtr_rotQuatW;

		// Token: 0x04002670 RID: 9840
		private static readonly IntPtr NativeFieldInfoPtr_posAccelX;

		// Token: 0x04002671 RID: 9841
		private static readonly IntPtr NativeFieldInfoPtr_posAccelY;

		// Token: 0x04002672 RID: 9842
		private static readonly IntPtr NativeFieldInfoPtr_posAccelZ;

		// Token: 0x04002673 RID: 9843
		private static readonly IntPtr NativeFieldInfoPtr_rotVelX;

		// Token: 0x04002674 RID: 9844
		private static readonly IntPtr NativeFieldInfoPtr_rotVelY;

		// Token: 0x04002675 RID: 9845
		private static readonly IntPtr NativeFieldInfoPtr_rotVelZ;

		// Token: 0x04002676 RID: 9846
		[FieldOffset(0)]
		public float rotQuatX;

		// Token: 0x04002677 RID: 9847
		[FieldOffset(4)]
		public float rotQuatY;

		// Token: 0x04002678 RID: 9848
		[FieldOffset(8)]
		public float rotQuatZ;

		// Token: 0x04002679 RID: 9849
		[FieldOffset(12)]
		public float rotQuatW;

		// Token: 0x0400267A RID: 9850
		[FieldOffset(16)]
		public float posAccelX;

		// Token: 0x0400267B RID: 9851
		[FieldOffset(20)]
		public float posAccelY;

		// Token: 0x0400267C RID: 9852
		[FieldOffset(24)]
		public float posAccelZ;

		// Token: 0x0400267D RID: 9853
		[FieldOffset(28)]
		public float rotVelX;

		// Token: 0x0400267E RID: 9854
		[FieldOffset(32)]
		public float rotVelY;

		// Token: 0x0400267F RID: 9855
		[FieldOffset(36)]
		public float rotVelZ;
	}
}

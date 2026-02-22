using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000027 RID: 39
	public sealed class WheelJoint2D : AnchoredJoint2D
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x0000416C File Offset: 0x0000236C
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x0000417E File Offset: 0x0000237E
		public bool useMotor
		{
			get
			{
				return WheelJoint2D.get_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WheelJoint2D.set_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00004191 File Offset: 0x00002391
		public float jointTranslation
		{
			get
			{
				return WheelJoint2D.get_jointTranslationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x000041A3 File Offset: 0x000023A3
		public float jointLinearSpeed
		{
			get
			{
				return WheelJoint2D.get_jointLinearSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x000041B5 File Offset: 0x000023B5
		public float jointSpeed
		{
			get
			{
				return WheelJoint2D.get_jointSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x000041C7 File Offset: 0x000023C7
		public float jointAngle
		{
			get
			{
				return WheelJoint2D.get_jointAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000041D9 File Offset: 0x000023D9
		public float GetMotorTorque(float timeStep)
		{
			return WheelJoint2D.GetMotorTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeStep);
		}

		// Token: 0x0400021F RID: 543
		private static readonly WheelJoint2D.get_useMotorDelegate get_useMotorDelegateField = IL2CPP.ResolveICall<WheelJoint2D.get_useMotorDelegate>("UnityEngine.WheelJoint2D::get_useMotor");

		// Token: 0x04000220 RID: 544
		private static readonly WheelJoint2D.set_useMotorDelegate set_useMotorDelegateField = IL2CPP.ResolveICall<WheelJoint2D.set_useMotorDelegate>("UnityEngine.WheelJoint2D::set_useMotor");

		// Token: 0x04000221 RID: 545
		private static readonly WheelJoint2D.get_jointTranslationDelegate get_jointTranslationDelegateField = IL2CPP.ResolveICall<WheelJoint2D.get_jointTranslationDelegate>("UnityEngine.WheelJoint2D::get_jointTranslation");

		// Token: 0x04000222 RID: 546
		private static readonly WheelJoint2D.get_jointLinearSpeedDelegate get_jointLinearSpeedDelegateField = IL2CPP.ResolveICall<WheelJoint2D.get_jointLinearSpeedDelegate>("UnityEngine.WheelJoint2D::get_jointLinearSpeed");

		// Token: 0x04000223 RID: 547
		private static readonly WheelJoint2D.get_jointSpeedDelegate get_jointSpeedDelegateField = IL2CPP.ResolveICall<WheelJoint2D.get_jointSpeedDelegate>("UnityEngine.WheelJoint2D::get_jointSpeed");

		// Token: 0x04000224 RID: 548
		private static readonly WheelJoint2D.get_jointAngleDelegate get_jointAngleDelegateField = IL2CPP.ResolveICall<WheelJoint2D.get_jointAngleDelegate>("UnityEngine.WheelJoint2D::get_jointAngle");

		// Token: 0x04000225 RID: 549
		private static readonly WheelJoint2D.GetMotorTorqueDelegate GetMotorTorqueDelegateField = IL2CPP.ResolveICall<WheelJoint2D.GetMotorTorqueDelegate>("UnityEngine.WheelJoint2D::GetMotorTorque");

		// Token: 0x020001AC RID: 428
		// (Invoke) Token: 0x06000722 RID: 1826
		private delegate bool get_useMotorDelegate(IntPtr @this);

		// Token: 0x020001AD RID: 429
		// (Invoke) Token: 0x06000724 RID: 1828
		private delegate void set_useMotorDelegate(IntPtr @this, bool value);

		// Token: 0x020001AE RID: 430
		// (Invoke) Token: 0x06000726 RID: 1830
		private delegate float get_jointTranslationDelegate(IntPtr @this);

		// Token: 0x020001AF RID: 431
		// (Invoke) Token: 0x06000728 RID: 1832
		private delegate float get_jointLinearSpeedDelegate(IntPtr @this);

		// Token: 0x020001B0 RID: 432
		// (Invoke) Token: 0x0600072A RID: 1834
		private delegate float get_jointSpeedDelegate(IntPtr @this);

		// Token: 0x020001B1 RID: 433
		// (Invoke) Token: 0x0600072C RID: 1836
		private delegate float get_jointAngleDelegate(IntPtr @this);

		// Token: 0x020001B2 RID: 434
		// (Invoke) Token: 0x0600072E RID: 1838
		private delegate float GetMotorTorqueDelegate(IntPtr @this, float timeStep);
	}
}

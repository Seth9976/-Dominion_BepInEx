using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000022 RID: 34
	public sealed class HingeJoint2D : AnchoredJoint2D
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00003D8C File Offset: 0x00001F8C
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00003D9E File Offset: 0x00001F9E
		public bool useMotor
		{
			get
			{
				return HingeJoint2D.get_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				HingeJoint2D.set_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00003DB1 File Offset: 0x00001FB1
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00003DC3 File Offset: 0x00001FC3
		public bool useLimits
		{
			get
			{
				return HingeJoint2D.get_useLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				HingeJoint2D.set_useLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00003DD6 File Offset: 0x00001FD6
		public JointLimitState2D limitState
		{
			get
			{
				return HingeJoint2D.get_limitStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00003DE8 File Offset: 0x00001FE8
		public float referenceAngle
		{
			get
			{
				return HingeJoint2D.get_referenceAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00003DFA File Offset: 0x00001FFA
		public float jointAngle
		{
			get
			{
				return HingeJoint2D.get_jointAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00003E0C File Offset: 0x0000200C
		public float jointSpeed
		{
			get
			{
				return HingeJoint2D.get_jointSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00003E1E File Offset: 0x0000201E
		public float GetMotorTorque(float timeStep)
		{
			return HingeJoint2D.GetMotorTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeStep);
		}

		// Token: 0x040001EB RID: 491
		private static readonly HingeJoint2D.get_useMotorDelegate get_useMotorDelegateField = IL2CPP.ResolveICall<HingeJoint2D.get_useMotorDelegate>("UnityEngine.HingeJoint2D::get_useMotor");

		// Token: 0x040001EC RID: 492
		private static readonly HingeJoint2D.set_useMotorDelegate set_useMotorDelegateField = IL2CPP.ResolveICall<HingeJoint2D.set_useMotorDelegate>("UnityEngine.HingeJoint2D::set_useMotor");

		// Token: 0x040001ED RID: 493
		private static readonly HingeJoint2D.get_useLimitsDelegate get_useLimitsDelegateField = IL2CPP.ResolveICall<HingeJoint2D.get_useLimitsDelegate>("UnityEngine.HingeJoint2D::get_useLimits");

		// Token: 0x040001EE RID: 494
		private static readonly HingeJoint2D.set_useLimitsDelegate set_useLimitsDelegateField = IL2CPP.ResolveICall<HingeJoint2D.set_useLimitsDelegate>("UnityEngine.HingeJoint2D::set_useLimits");

		// Token: 0x040001EF RID: 495
		private static readonly HingeJoint2D.get_limitStateDelegate get_limitStateDelegateField = IL2CPP.ResolveICall<HingeJoint2D.get_limitStateDelegate>("UnityEngine.HingeJoint2D::get_limitState");

		// Token: 0x040001F0 RID: 496
		private static readonly HingeJoint2D.get_referenceAngleDelegate get_referenceAngleDelegateField = IL2CPP.ResolveICall<HingeJoint2D.get_referenceAngleDelegate>("UnityEngine.HingeJoint2D::get_referenceAngle");

		// Token: 0x040001F1 RID: 497
		private static readonly HingeJoint2D.get_jointAngleDelegate get_jointAngleDelegateField = IL2CPP.ResolveICall<HingeJoint2D.get_jointAngleDelegate>("UnityEngine.HingeJoint2D::get_jointAngle");

		// Token: 0x040001F2 RID: 498
		private static readonly HingeJoint2D.get_jointSpeedDelegate get_jointSpeedDelegateField = IL2CPP.ResolveICall<HingeJoint2D.get_jointSpeedDelegate>("UnityEngine.HingeJoint2D::get_jointSpeed");

		// Token: 0x040001F3 RID: 499
		private static readonly HingeJoint2D.GetMotorTorqueDelegate GetMotorTorqueDelegateField = IL2CPP.ResolveICall<HingeJoint2D.GetMotorTorqueDelegate>("UnityEngine.HingeJoint2D::GetMotorTorque");

		// Token: 0x02000178 RID: 376
		// (Invoke) Token: 0x060006BA RID: 1722
		private delegate bool get_useMotorDelegate(IntPtr @this);

		// Token: 0x02000179 RID: 377
		// (Invoke) Token: 0x060006BC RID: 1724
		private delegate void set_useMotorDelegate(IntPtr @this, bool value);

		// Token: 0x0200017A RID: 378
		// (Invoke) Token: 0x060006BE RID: 1726
		private delegate bool get_useLimitsDelegate(IntPtr @this);

		// Token: 0x0200017B RID: 379
		// (Invoke) Token: 0x060006C0 RID: 1728
		private delegate void set_useLimitsDelegate(IntPtr @this, bool value);

		// Token: 0x0200017C RID: 380
		// (Invoke) Token: 0x060006C2 RID: 1730
		private delegate JointLimitState2D get_limitStateDelegate(IntPtr @this);

		// Token: 0x0200017D RID: 381
		// (Invoke) Token: 0x060006C4 RID: 1732
		private delegate float get_referenceAngleDelegate(IntPtr @this);

		// Token: 0x0200017E RID: 382
		// (Invoke) Token: 0x060006C6 RID: 1734
		private delegate float get_jointAngleDelegate(IntPtr @this);

		// Token: 0x0200017F RID: 383
		// (Invoke) Token: 0x060006C8 RID: 1736
		private delegate float get_jointSpeedDelegate(IntPtr @this);

		// Token: 0x02000180 RID: 384
		// (Invoke) Token: 0x060006CA RID: 1738
		private delegate float GetMotorTorqueDelegate(IntPtr @this, float timeStep);
	}
}

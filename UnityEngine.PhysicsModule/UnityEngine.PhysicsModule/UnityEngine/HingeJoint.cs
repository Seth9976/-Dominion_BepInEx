using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000022 RID: 34
	public class HingeJoint : Joint
	{
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00003DB9 File Offset: 0x00001FB9
		// (set) Token: 0x06000328 RID: 808 RVA: 0x00003DCB File Offset: 0x00001FCB
		public bool useMotor
		{
			get
			{
				return HingeJoint.get_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				HingeJoint.set_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00003DDE File Offset: 0x00001FDE
		// (set) Token: 0x0600032A RID: 810 RVA: 0x00003DF0 File Offset: 0x00001FF0
		public bool useLimits
		{
			get
			{
				return HingeJoint.get_useLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				HingeJoint.set_useLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00003E03 File Offset: 0x00002003
		// (set) Token: 0x0600032C RID: 812 RVA: 0x00003E15 File Offset: 0x00002015
		public bool useSpring
		{
			get
			{
				return HingeJoint.get_useSpringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				HingeJoint.set_useSpringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00003E28 File Offset: 0x00002028
		public float velocity
		{
			get
			{
				return HingeJoint.get_velocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00003E3A File Offset: 0x0000203A
		public float angle
		{
			get
			{
				return HingeJoint.get_angleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x040001F7 RID: 503
		private static readonly HingeJoint.get_useMotorDelegate get_useMotorDelegateField = IL2CPP.ResolveICall<HingeJoint.get_useMotorDelegate>("UnityEngine.HingeJoint::get_useMotor");

		// Token: 0x040001F8 RID: 504
		private static readonly HingeJoint.set_useMotorDelegate set_useMotorDelegateField = IL2CPP.ResolveICall<HingeJoint.set_useMotorDelegate>("UnityEngine.HingeJoint::set_useMotor");

		// Token: 0x040001F9 RID: 505
		private static readonly HingeJoint.get_useLimitsDelegate get_useLimitsDelegateField = IL2CPP.ResolveICall<HingeJoint.get_useLimitsDelegate>("UnityEngine.HingeJoint::get_useLimits");

		// Token: 0x040001FA RID: 506
		private static readonly HingeJoint.set_useLimitsDelegate set_useLimitsDelegateField = IL2CPP.ResolveICall<HingeJoint.set_useLimitsDelegate>("UnityEngine.HingeJoint::set_useLimits");

		// Token: 0x040001FB RID: 507
		private static readonly HingeJoint.get_useSpringDelegate get_useSpringDelegateField = IL2CPP.ResolveICall<HingeJoint.get_useSpringDelegate>("UnityEngine.HingeJoint::get_useSpring");

		// Token: 0x040001FC RID: 508
		private static readonly HingeJoint.set_useSpringDelegate set_useSpringDelegateField = IL2CPP.ResolveICall<HingeJoint.set_useSpringDelegate>("UnityEngine.HingeJoint::set_useSpring");

		// Token: 0x040001FD RID: 509
		private static readonly HingeJoint.get_velocityDelegate get_velocityDelegateField = IL2CPP.ResolveICall<HingeJoint.get_velocityDelegate>("UnityEngine.HingeJoint::get_velocity");

		// Token: 0x040001FE RID: 510
		private static readonly HingeJoint.get_angleDelegate get_angleDelegateField = IL2CPP.ResolveICall<HingeJoint.get_angleDelegate>("UnityEngine.HingeJoint::get_angle");

		// Token: 0x0200016F RID: 367
		// (Invoke) Token: 0x06000603 RID: 1539
		private delegate bool get_useMotorDelegate(IntPtr @this);

		// Token: 0x02000170 RID: 368
		// (Invoke) Token: 0x06000605 RID: 1541
		private delegate void set_useMotorDelegate(IntPtr @this, bool value);

		// Token: 0x02000171 RID: 369
		// (Invoke) Token: 0x06000607 RID: 1543
		private delegate bool get_useLimitsDelegate(IntPtr @this);

		// Token: 0x02000172 RID: 370
		// (Invoke) Token: 0x06000609 RID: 1545
		private delegate void set_useLimitsDelegate(IntPtr @this, bool value);

		// Token: 0x02000173 RID: 371
		// (Invoke) Token: 0x0600060B RID: 1547
		private delegate bool get_useSpringDelegate(IntPtr @this);

		// Token: 0x02000174 RID: 372
		// (Invoke) Token: 0x0600060D RID: 1549
		private delegate void set_useSpringDelegate(IntPtr @this, bool value);

		// Token: 0x02000175 RID: 373
		// (Invoke) Token: 0x0600060F RID: 1551
		private delegate float get_velocityDelegate(IntPtr @this);

		// Token: 0x02000176 RID: 374
		// (Invoke) Token: 0x06000611 RID: 1553
		private delegate float get_angleDelegate(IntPtr @this);
	}
}

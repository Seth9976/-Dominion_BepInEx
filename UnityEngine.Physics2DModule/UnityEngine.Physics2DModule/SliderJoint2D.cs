using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000024 RID: 36
	public sealed class SliderJoint2D : AnchoredJoint2D
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00003F2D File Offset: 0x0000212D
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x00003F3F File Offset: 0x0000213F
		public bool autoConfigureAngle
		{
			get
			{
				return SliderJoint2D.get_autoConfigureAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SliderJoint2D.set_autoConfigureAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00003F52 File Offset: 0x00002152
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x00003F64 File Offset: 0x00002164
		public float angle
		{
			get
			{
				return SliderJoint2D.get_angleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SliderJoint2D.set_angleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00003F77 File Offset: 0x00002177
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x00003F89 File Offset: 0x00002189
		public bool useMotor
		{
			get
			{
				return SliderJoint2D.get_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SliderJoint2D.set_useMotorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00003F9C File Offset: 0x0000219C
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x00003FAE File Offset: 0x000021AE
		public bool useLimits
		{
			get
			{
				return SliderJoint2D.get_useLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SliderJoint2D.set_useLimitsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x00003FC1 File Offset: 0x000021C1
		public JointLimitState2D limitState
		{
			get
			{
				return SliderJoint2D.get_limitStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00003FD3 File Offset: 0x000021D3
		public float referenceAngle
		{
			get
			{
				return SliderJoint2D.get_referenceAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x00003FE5 File Offset: 0x000021E5
		public float jointTranslation
		{
			get
			{
				return SliderJoint2D.get_jointTranslationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00003FF7 File Offset: 0x000021F7
		public float jointSpeed
		{
			get
			{
				return SliderJoint2D.get_jointSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00004009 File Offset: 0x00002209
		public float GetMotorForce(float timeStep)
		{
			return SliderJoint2D.GetMotorForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeStep);
		}

		// Token: 0x04000201 RID: 513
		private static readonly SliderJoint2D.get_autoConfigureAngleDelegate get_autoConfigureAngleDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_autoConfigureAngleDelegate>("UnityEngine.SliderJoint2D::get_autoConfigureAngle");

		// Token: 0x04000202 RID: 514
		private static readonly SliderJoint2D.set_autoConfigureAngleDelegate set_autoConfigureAngleDelegateField = IL2CPP.ResolveICall<SliderJoint2D.set_autoConfigureAngleDelegate>("UnityEngine.SliderJoint2D::set_autoConfigureAngle");

		// Token: 0x04000203 RID: 515
		private static readonly SliderJoint2D.get_angleDelegate get_angleDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_angleDelegate>("UnityEngine.SliderJoint2D::get_angle");

		// Token: 0x04000204 RID: 516
		private static readonly SliderJoint2D.set_angleDelegate set_angleDelegateField = IL2CPP.ResolveICall<SliderJoint2D.set_angleDelegate>("UnityEngine.SliderJoint2D::set_angle");

		// Token: 0x04000205 RID: 517
		private static readonly SliderJoint2D.get_useMotorDelegate get_useMotorDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_useMotorDelegate>("UnityEngine.SliderJoint2D::get_useMotor");

		// Token: 0x04000206 RID: 518
		private static readonly SliderJoint2D.set_useMotorDelegate set_useMotorDelegateField = IL2CPP.ResolveICall<SliderJoint2D.set_useMotorDelegate>("UnityEngine.SliderJoint2D::set_useMotor");

		// Token: 0x04000207 RID: 519
		private static readonly SliderJoint2D.get_useLimitsDelegate get_useLimitsDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_useLimitsDelegate>("UnityEngine.SliderJoint2D::get_useLimits");

		// Token: 0x04000208 RID: 520
		private static readonly SliderJoint2D.set_useLimitsDelegate set_useLimitsDelegateField = IL2CPP.ResolveICall<SliderJoint2D.set_useLimitsDelegate>("UnityEngine.SliderJoint2D::set_useLimits");

		// Token: 0x04000209 RID: 521
		private static readonly SliderJoint2D.get_limitStateDelegate get_limitStateDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_limitStateDelegate>("UnityEngine.SliderJoint2D::get_limitState");

		// Token: 0x0400020A RID: 522
		private static readonly SliderJoint2D.get_referenceAngleDelegate get_referenceAngleDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_referenceAngleDelegate>("UnityEngine.SliderJoint2D::get_referenceAngle");

		// Token: 0x0400020B RID: 523
		private static readonly SliderJoint2D.get_jointTranslationDelegate get_jointTranslationDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_jointTranslationDelegate>("UnityEngine.SliderJoint2D::get_jointTranslation");

		// Token: 0x0400020C RID: 524
		private static readonly SliderJoint2D.get_jointSpeedDelegate get_jointSpeedDelegateField = IL2CPP.ResolveICall<SliderJoint2D.get_jointSpeedDelegate>("UnityEngine.SliderJoint2D::get_jointSpeed");

		// Token: 0x0400020D RID: 525
		private static readonly SliderJoint2D.GetMotorForceDelegate GetMotorForceDelegateField = IL2CPP.ResolveICall<SliderJoint2D.GetMotorForceDelegate>("UnityEngine.SliderJoint2D::GetMotorForce");

		// Token: 0x0200018E RID: 398
		// (Invoke) Token: 0x060006E6 RID: 1766
		private delegate bool get_autoConfigureAngleDelegate(IntPtr @this);

		// Token: 0x0200018F RID: 399
		// (Invoke) Token: 0x060006E8 RID: 1768
		private delegate void set_autoConfigureAngleDelegate(IntPtr @this, bool value);

		// Token: 0x02000190 RID: 400
		// (Invoke) Token: 0x060006EA RID: 1770
		private delegate float get_angleDelegate(IntPtr @this);

		// Token: 0x02000191 RID: 401
		// (Invoke) Token: 0x060006EC RID: 1772
		private delegate void set_angleDelegate(IntPtr @this, float value);

		// Token: 0x02000192 RID: 402
		// (Invoke) Token: 0x060006EE RID: 1774
		private delegate bool get_useMotorDelegate(IntPtr @this);

		// Token: 0x02000193 RID: 403
		// (Invoke) Token: 0x060006F0 RID: 1776
		private delegate void set_useMotorDelegate(IntPtr @this, bool value);

		// Token: 0x02000194 RID: 404
		// (Invoke) Token: 0x060006F2 RID: 1778
		private delegate bool get_useLimitsDelegate(IntPtr @this);

		// Token: 0x02000195 RID: 405
		// (Invoke) Token: 0x060006F4 RID: 1780
		private delegate void set_useLimitsDelegate(IntPtr @this, bool value);

		// Token: 0x02000196 RID: 406
		// (Invoke) Token: 0x060006F6 RID: 1782
		private delegate JointLimitState2D get_limitStateDelegate(IntPtr @this);

		// Token: 0x02000197 RID: 407
		// (Invoke) Token: 0x060006F8 RID: 1784
		private delegate float get_referenceAngleDelegate(IntPtr @this);

		// Token: 0x02000198 RID: 408
		// (Invoke) Token: 0x060006FA RID: 1786
		private delegate float get_jointTranslationDelegate(IntPtr @this);

		// Token: 0x02000199 RID: 409
		// (Invoke) Token: 0x060006FC RID: 1788
		private delegate float get_jointSpeedDelegate(IntPtr @this);

		// Token: 0x0200019A RID: 410
		// (Invoke) Token: 0x060006FE RID: 1790
		private delegate float GetMotorForceDelegate(IntPtr @this, float timeStep);
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000023 RID: 35
	public sealed class RelativeJoint2D : Joint2D
	{
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00003E31 File Offset: 0x00002031
		// (set) Token: 0x0600038F RID: 911 RVA: 0x00003E43 File Offset: 0x00002043
		public float maxForce
		{
			get
			{
				return RelativeJoint2D.get_maxForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RelativeJoint2D.set_maxForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00003E56 File Offset: 0x00002056
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00003E68 File Offset: 0x00002068
		public float maxTorque
		{
			get
			{
				return RelativeJoint2D.get_maxTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RelativeJoint2D.set_maxTorqueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00003E7B File Offset: 0x0000207B
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00003E8D File Offset: 0x0000208D
		public float correctionScale
		{
			get
			{
				return RelativeJoint2D.get_correctionScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RelativeJoint2D.set_correctionScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00003EA0 File Offset: 0x000020A0
		// (set) Token: 0x06000395 RID: 917 RVA: 0x00003EB2 File Offset: 0x000020B2
		public bool autoConfigureOffset
		{
			get
			{
				return RelativeJoint2D.get_autoConfigureOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RelativeJoint2D.set_autoConfigureOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0000BA74 File Offset: 0x00009C74
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00003EC5 File Offset: 0x000020C5
		public Vector2 linearOffset
		{
			get
			{
				Vector2 vector;
				this.get_linearOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_linearOffset_Injected(ref value);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00003ECF File Offset: 0x000020CF
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00003EE1 File Offset: 0x000020E1
		public float angularOffset
		{
			get
			{
				return RelativeJoint2D.get_angularOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RelativeJoint2D.set_angularOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0000BA8C File Offset: 0x00009C8C
		public Vector2 target
		{
			get
			{
				Vector2 vector;
				this.get_target_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00003EF4 File Offset: 0x000020F4
		public void get_linearOffset_Injected(out Vector2 ret)
		{
			RelativeJoint2D.get_linearOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00003F07 File Offset: 0x00002107
		public void set_linearOffset_Injected(ref Vector2 value)
		{
			RelativeJoint2D.set_linearOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00003F1A File Offset: 0x0000211A
		public void get_target_Injected(out Vector2 ret)
		{
			RelativeJoint2D.get_target_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x040001F4 RID: 500
		private static readonly RelativeJoint2D.get_maxForceDelegate get_maxForceDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_maxForceDelegate>("UnityEngine.RelativeJoint2D::get_maxForce");

		// Token: 0x040001F5 RID: 501
		private static readonly RelativeJoint2D.set_maxForceDelegate set_maxForceDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.set_maxForceDelegate>("UnityEngine.RelativeJoint2D::set_maxForce");

		// Token: 0x040001F6 RID: 502
		private static readonly RelativeJoint2D.get_maxTorqueDelegate get_maxTorqueDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_maxTorqueDelegate>("UnityEngine.RelativeJoint2D::get_maxTorque");

		// Token: 0x040001F7 RID: 503
		private static readonly RelativeJoint2D.set_maxTorqueDelegate set_maxTorqueDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.set_maxTorqueDelegate>("UnityEngine.RelativeJoint2D::set_maxTorque");

		// Token: 0x040001F8 RID: 504
		private static readonly RelativeJoint2D.get_correctionScaleDelegate get_correctionScaleDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_correctionScaleDelegate>("UnityEngine.RelativeJoint2D::get_correctionScale");

		// Token: 0x040001F9 RID: 505
		private static readonly RelativeJoint2D.set_correctionScaleDelegate set_correctionScaleDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.set_correctionScaleDelegate>("UnityEngine.RelativeJoint2D::set_correctionScale");

		// Token: 0x040001FA RID: 506
		private static readonly RelativeJoint2D.get_autoConfigureOffsetDelegate get_autoConfigureOffsetDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_autoConfigureOffsetDelegate>("UnityEngine.RelativeJoint2D::get_autoConfigureOffset");

		// Token: 0x040001FB RID: 507
		private static readonly RelativeJoint2D.set_autoConfigureOffsetDelegate set_autoConfigureOffsetDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.set_autoConfigureOffsetDelegate>("UnityEngine.RelativeJoint2D::set_autoConfigureOffset");

		// Token: 0x040001FC RID: 508
		private static readonly RelativeJoint2D.get_angularOffsetDelegate get_angularOffsetDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_angularOffsetDelegate>("UnityEngine.RelativeJoint2D::get_angularOffset");

		// Token: 0x040001FD RID: 509
		private static readonly RelativeJoint2D.set_angularOffsetDelegate set_angularOffsetDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.set_angularOffsetDelegate>("UnityEngine.RelativeJoint2D::set_angularOffset");

		// Token: 0x040001FE RID: 510
		private static readonly RelativeJoint2D.get_linearOffset_InjectedDelegate get_linearOffset_InjectedDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_linearOffset_InjectedDelegate>("UnityEngine.RelativeJoint2D::get_linearOffset_Injected");

		// Token: 0x040001FF RID: 511
		private static readonly RelativeJoint2D.set_linearOffset_InjectedDelegate set_linearOffset_InjectedDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.set_linearOffset_InjectedDelegate>("UnityEngine.RelativeJoint2D::set_linearOffset_Injected");

		// Token: 0x04000200 RID: 512
		private static readonly RelativeJoint2D.get_target_InjectedDelegate get_target_InjectedDelegateField = IL2CPP.ResolveICall<RelativeJoint2D.get_target_InjectedDelegate>("UnityEngine.RelativeJoint2D::get_target_Injected");

		// Token: 0x02000181 RID: 385
		// (Invoke) Token: 0x060006CC RID: 1740
		private delegate float get_maxForceDelegate(IntPtr @this);

		// Token: 0x02000182 RID: 386
		// (Invoke) Token: 0x060006CE RID: 1742
		private delegate void set_maxForceDelegate(IntPtr @this, float value);

		// Token: 0x02000183 RID: 387
		// (Invoke) Token: 0x060006D0 RID: 1744
		private delegate float get_maxTorqueDelegate(IntPtr @this);

		// Token: 0x02000184 RID: 388
		// (Invoke) Token: 0x060006D2 RID: 1746
		private delegate void set_maxTorqueDelegate(IntPtr @this, float value);

		// Token: 0x02000185 RID: 389
		// (Invoke) Token: 0x060006D4 RID: 1748
		private delegate float get_correctionScaleDelegate(IntPtr @this);

		// Token: 0x02000186 RID: 390
		// (Invoke) Token: 0x060006D6 RID: 1750
		private delegate void set_correctionScaleDelegate(IntPtr @this, float value);

		// Token: 0x02000187 RID: 391
		// (Invoke) Token: 0x060006D8 RID: 1752
		private delegate bool get_autoConfigureOffsetDelegate(IntPtr @this);

		// Token: 0x02000188 RID: 392
		// (Invoke) Token: 0x060006DA RID: 1754
		private delegate void set_autoConfigureOffsetDelegate(IntPtr @this, bool value);

		// Token: 0x02000189 RID: 393
		// (Invoke) Token: 0x060006DC RID: 1756
		private delegate float get_angularOffsetDelegate(IntPtr @this);

		// Token: 0x0200018A RID: 394
		// (Invoke) Token: 0x060006DE RID: 1758
		private delegate void set_angularOffsetDelegate(IntPtr @this, float value);

		// Token: 0x0200018B RID: 395
		// (Invoke) Token: 0x060006E0 RID: 1760
		private delegate void get_linearOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200018C RID: 396
		// (Invoke) Token: 0x060006E2 RID: 1762
		private delegate void set_linearOffset_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200018D RID: 397
		// (Invoke) Token: 0x060006E4 RID: 1764
		private delegate void get_target_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}

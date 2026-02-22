using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000025 RID: 37
	public sealed class TargetJoint2D : Joint2D
	{
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0000BC38 File Offset: 0x00009E38
		// (set) Token: 0x060003AE RID: 942 RVA: 0x0000401C File Offset: 0x0000221C
		public Vector2 anchor
		{
			get
			{
				Vector2 vector;
				this.get_anchor_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_anchor_Injected(ref value);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0000BC50 File Offset: 0x00009E50
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00004026 File Offset: 0x00002226
		public Vector2 target
		{
			get
			{
				Vector2 vector;
				this.get_target_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_target_Injected(ref value);
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00004030 File Offset: 0x00002230
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00004042 File Offset: 0x00002242
		public bool autoConfigureTarget
		{
			get
			{
				return TargetJoint2D.get_autoConfigureTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TargetJoint2D.set_autoConfigureTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00004055 File Offset: 0x00002255
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00004067 File Offset: 0x00002267
		public float maxForce
		{
			get
			{
				return TargetJoint2D.get_maxForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TargetJoint2D.set_maxForceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0000407A File Offset: 0x0000227A
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x0000408C File Offset: 0x0000228C
		public float dampingRatio
		{
			get
			{
				return TargetJoint2D.get_dampingRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TargetJoint2D.set_dampingRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x0000409F File Offset: 0x0000229F
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x000040B1 File Offset: 0x000022B1
		public float frequency
		{
			get
			{
				return TargetJoint2D.get_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TargetJoint2D.set_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000040C4 File Offset: 0x000022C4
		public void get_anchor_Injected(out Vector2 ret)
		{
			TargetJoint2D.get_anchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x000040D7 File Offset: 0x000022D7
		public void set_anchor_Injected(ref Vector2 value)
		{
			TargetJoint2D.set_anchor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000040EA File Offset: 0x000022EA
		public void get_target_Injected(out Vector2 ret)
		{
			TargetJoint2D.get_target_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x000040FD File Offset: 0x000022FD
		public void set_target_Injected(ref Vector2 value)
		{
			TargetJoint2D.set_target_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0400020E RID: 526
		private static readonly TargetJoint2D.get_autoConfigureTargetDelegate get_autoConfigureTargetDelegateField = IL2CPP.ResolveICall<TargetJoint2D.get_autoConfigureTargetDelegate>("UnityEngine.TargetJoint2D::get_autoConfigureTarget");

		// Token: 0x0400020F RID: 527
		private static readonly TargetJoint2D.set_autoConfigureTargetDelegate set_autoConfigureTargetDelegateField = IL2CPP.ResolveICall<TargetJoint2D.set_autoConfigureTargetDelegate>("UnityEngine.TargetJoint2D::set_autoConfigureTarget");

		// Token: 0x04000210 RID: 528
		private static readonly TargetJoint2D.get_maxForceDelegate get_maxForceDelegateField = IL2CPP.ResolveICall<TargetJoint2D.get_maxForceDelegate>("UnityEngine.TargetJoint2D::get_maxForce");

		// Token: 0x04000211 RID: 529
		private static readonly TargetJoint2D.set_maxForceDelegate set_maxForceDelegateField = IL2CPP.ResolveICall<TargetJoint2D.set_maxForceDelegate>("UnityEngine.TargetJoint2D::set_maxForce");

		// Token: 0x04000212 RID: 530
		private static readonly TargetJoint2D.get_dampingRatioDelegate get_dampingRatioDelegateField = IL2CPP.ResolveICall<TargetJoint2D.get_dampingRatioDelegate>("UnityEngine.TargetJoint2D::get_dampingRatio");

		// Token: 0x04000213 RID: 531
		private static readonly TargetJoint2D.set_dampingRatioDelegate set_dampingRatioDelegateField = IL2CPP.ResolveICall<TargetJoint2D.set_dampingRatioDelegate>("UnityEngine.TargetJoint2D::set_dampingRatio");

		// Token: 0x04000214 RID: 532
		private static readonly TargetJoint2D.get_frequencyDelegate get_frequencyDelegateField = IL2CPP.ResolveICall<TargetJoint2D.get_frequencyDelegate>("UnityEngine.TargetJoint2D::get_frequency");

		// Token: 0x04000215 RID: 533
		private static readonly TargetJoint2D.set_frequencyDelegate set_frequencyDelegateField = IL2CPP.ResolveICall<TargetJoint2D.set_frequencyDelegate>("UnityEngine.TargetJoint2D::set_frequency");

		// Token: 0x04000216 RID: 534
		private static readonly TargetJoint2D.get_anchor_InjectedDelegate get_anchor_InjectedDelegateField = IL2CPP.ResolveICall<TargetJoint2D.get_anchor_InjectedDelegate>("UnityEngine.TargetJoint2D::get_anchor_Injected");

		// Token: 0x04000217 RID: 535
		private static readonly TargetJoint2D.set_anchor_InjectedDelegate set_anchor_InjectedDelegateField = IL2CPP.ResolveICall<TargetJoint2D.set_anchor_InjectedDelegate>("UnityEngine.TargetJoint2D::set_anchor_Injected");

		// Token: 0x04000218 RID: 536
		private static readonly TargetJoint2D.get_target_InjectedDelegate get_target_InjectedDelegateField = IL2CPP.ResolveICall<TargetJoint2D.get_target_InjectedDelegate>("UnityEngine.TargetJoint2D::get_target_Injected");

		// Token: 0x04000219 RID: 537
		private static readonly TargetJoint2D.set_target_InjectedDelegate set_target_InjectedDelegateField = IL2CPP.ResolveICall<TargetJoint2D.set_target_InjectedDelegate>("UnityEngine.TargetJoint2D::set_target_Injected");

		// Token: 0x0200019B RID: 411
		// (Invoke) Token: 0x06000700 RID: 1792
		private delegate bool get_autoConfigureTargetDelegate(IntPtr @this);

		// Token: 0x0200019C RID: 412
		// (Invoke) Token: 0x06000702 RID: 1794
		private delegate void set_autoConfigureTargetDelegate(IntPtr @this, bool value);

		// Token: 0x0200019D RID: 413
		// (Invoke) Token: 0x06000704 RID: 1796
		private delegate float get_maxForceDelegate(IntPtr @this);

		// Token: 0x0200019E RID: 414
		// (Invoke) Token: 0x06000706 RID: 1798
		private delegate void set_maxForceDelegate(IntPtr @this, float value);

		// Token: 0x0200019F RID: 415
		// (Invoke) Token: 0x06000708 RID: 1800
		private delegate float get_dampingRatioDelegate(IntPtr @this);

		// Token: 0x020001A0 RID: 416
		// (Invoke) Token: 0x0600070A RID: 1802
		private delegate void set_dampingRatioDelegate(IntPtr @this, float value);

		// Token: 0x020001A1 RID: 417
		// (Invoke) Token: 0x0600070C RID: 1804
		private delegate float get_frequencyDelegate(IntPtr @this);

		// Token: 0x020001A2 RID: 418
		// (Invoke) Token: 0x0600070E RID: 1806
		private delegate void set_frequencyDelegate(IntPtr @this, float value);

		// Token: 0x020001A3 RID: 419
		// (Invoke) Token: 0x06000710 RID: 1808
		private delegate void get_anchor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001A4 RID: 420
		// (Invoke) Token: 0x06000712 RID: 1810
		private delegate void set_anchor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020001A5 RID: 421
		// (Invoke) Token: 0x06000714 RID: 1812
		private delegate void get_target_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020001A6 RID: 422
		// (Invoke) Token: 0x06000716 RID: 1814
		private delegate void set_target_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}

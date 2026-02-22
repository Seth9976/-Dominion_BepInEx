using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000026 RID: 38
	public sealed class FixedJoint2D : AnchoredJoint2D
	{
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00004110 File Offset: 0x00002310
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00004122 File Offset: 0x00002322
		public float dampingRatio
		{
			get
			{
				return FixedJoint2D.get_dampingRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				FixedJoint2D.set_dampingRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00004135 File Offset: 0x00002335
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00004147 File Offset: 0x00002347
		public float frequency
		{
			get
			{
				return FixedJoint2D.get_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				FixedJoint2D.set_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x0000415A File Offset: 0x0000235A
		public float referenceAngle
		{
			get
			{
				return FixedJoint2D.get_referenceAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0400021A RID: 538
		private static readonly FixedJoint2D.get_dampingRatioDelegate get_dampingRatioDelegateField = IL2CPP.ResolveICall<FixedJoint2D.get_dampingRatioDelegate>("UnityEngine.FixedJoint2D::get_dampingRatio");

		// Token: 0x0400021B RID: 539
		private static readonly FixedJoint2D.set_dampingRatioDelegate set_dampingRatioDelegateField = IL2CPP.ResolveICall<FixedJoint2D.set_dampingRatioDelegate>("UnityEngine.FixedJoint2D::set_dampingRatio");

		// Token: 0x0400021C RID: 540
		private static readonly FixedJoint2D.get_frequencyDelegate get_frequencyDelegateField = IL2CPP.ResolveICall<FixedJoint2D.get_frequencyDelegate>("UnityEngine.FixedJoint2D::get_frequency");

		// Token: 0x0400021D RID: 541
		private static readonly FixedJoint2D.set_frequencyDelegate set_frequencyDelegateField = IL2CPP.ResolveICall<FixedJoint2D.set_frequencyDelegate>("UnityEngine.FixedJoint2D::set_frequency");

		// Token: 0x0400021E RID: 542
		private static readonly FixedJoint2D.get_referenceAngleDelegate get_referenceAngleDelegateField = IL2CPP.ResolveICall<FixedJoint2D.get_referenceAngleDelegate>("UnityEngine.FixedJoint2D::get_referenceAngle");

		// Token: 0x020001A7 RID: 423
		// (Invoke) Token: 0x06000718 RID: 1816
		private delegate float get_dampingRatioDelegate(IntPtr @this);

		// Token: 0x020001A8 RID: 424
		// (Invoke) Token: 0x0600071A RID: 1818
		private delegate void set_dampingRatioDelegate(IntPtr @this, float value);

		// Token: 0x020001A9 RID: 425
		// (Invoke) Token: 0x0600071C RID: 1820
		private delegate float get_frequencyDelegate(IntPtr @this);

		// Token: 0x020001AA RID: 426
		// (Invoke) Token: 0x0600071E RID: 1822
		private delegate void set_frequencyDelegate(IntPtr @this, float value);

		// Token: 0x020001AB RID: 427
		// (Invoke) Token: 0x06000720 RID: 1824
		private delegate float get_referenceAngleDelegate(IntPtr @this);
	}
}

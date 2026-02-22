using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001F RID: 31
	public sealed class SpringJoint2D : AnchoredJoint2D
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00003C01 File Offset: 0x00001E01
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00003C13 File Offset: 0x00001E13
		public bool autoConfigureDistance
		{
			get
			{
				return SpringJoint2D.get_autoConfigureDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint2D.set_autoConfigureDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000371 RID: 881 RVA: 0x00003C26 File Offset: 0x00001E26
		// (set) Token: 0x06000372 RID: 882 RVA: 0x00003C38 File Offset: 0x00001E38
		public float distance
		{
			get
			{
				return SpringJoint2D.get_distanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint2D.set_distanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00003C4B File Offset: 0x00001E4B
		// (set) Token: 0x06000374 RID: 884 RVA: 0x00003C5D File Offset: 0x00001E5D
		public float dampingRatio
		{
			get
			{
				return SpringJoint2D.get_dampingRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint2D.set_dampingRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00003C70 File Offset: 0x00001E70
		// (set) Token: 0x06000376 RID: 886 RVA: 0x00003C82 File Offset: 0x00001E82
		public float frequency
		{
			get
			{
				return SpringJoint2D.get_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpringJoint2D.set_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040001D9 RID: 473
		private static readonly SpringJoint2D.get_autoConfigureDistanceDelegate get_autoConfigureDistanceDelegateField = IL2CPP.ResolveICall<SpringJoint2D.get_autoConfigureDistanceDelegate>("UnityEngine.SpringJoint2D::get_autoConfigureDistance");

		// Token: 0x040001DA RID: 474
		private static readonly SpringJoint2D.set_autoConfigureDistanceDelegate set_autoConfigureDistanceDelegateField = IL2CPP.ResolveICall<SpringJoint2D.set_autoConfigureDistanceDelegate>("UnityEngine.SpringJoint2D::set_autoConfigureDistance");

		// Token: 0x040001DB RID: 475
		private static readonly SpringJoint2D.get_distanceDelegate get_distanceDelegateField = IL2CPP.ResolveICall<SpringJoint2D.get_distanceDelegate>("UnityEngine.SpringJoint2D::get_distance");

		// Token: 0x040001DC RID: 476
		private static readonly SpringJoint2D.set_distanceDelegate set_distanceDelegateField = IL2CPP.ResolveICall<SpringJoint2D.set_distanceDelegate>("UnityEngine.SpringJoint2D::set_distance");

		// Token: 0x040001DD RID: 477
		private static readonly SpringJoint2D.get_dampingRatioDelegate get_dampingRatioDelegateField = IL2CPP.ResolveICall<SpringJoint2D.get_dampingRatioDelegate>("UnityEngine.SpringJoint2D::get_dampingRatio");

		// Token: 0x040001DE RID: 478
		private static readonly SpringJoint2D.set_dampingRatioDelegate set_dampingRatioDelegateField = IL2CPP.ResolveICall<SpringJoint2D.set_dampingRatioDelegate>("UnityEngine.SpringJoint2D::set_dampingRatio");

		// Token: 0x040001DF RID: 479
		private static readonly SpringJoint2D.get_frequencyDelegate get_frequencyDelegateField = IL2CPP.ResolveICall<SpringJoint2D.get_frequencyDelegate>("UnityEngine.SpringJoint2D::get_frequency");

		// Token: 0x040001E0 RID: 480
		private static readonly SpringJoint2D.set_frequencyDelegate set_frequencyDelegateField = IL2CPP.ResolveICall<SpringJoint2D.set_frequencyDelegate>("UnityEngine.SpringJoint2D::set_frequency");

		// Token: 0x02000166 RID: 358
		// (Invoke) Token: 0x06000696 RID: 1686
		private delegate bool get_autoConfigureDistanceDelegate(IntPtr @this);

		// Token: 0x02000167 RID: 359
		// (Invoke) Token: 0x06000698 RID: 1688
		private delegate void set_autoConfigureDistanceDelegate(IntPtr @this, bool value);

		// Token: 0x02000168 RID: 360
		// (Invoke) Token: 0x0600069A RID: 1690
		private delegate float get_distanceDelegate(IntPtr @this);

		// Token: 0x02000169 RID: 361
		// (Invoke) Token: 0x0600069C RID: 1692
		private delegate void set_distanceDelegate(IntPtr @this, float value);

		// Token: 0x0200016A RID: 362
		// (Invoke) Token: 0x0600069E RID: 1694
		private delegate float get_dampingRatioDelegate(IntPtr @this);

		// Token: 0x0200016B RID: 363
		// (Invoke) Token: 0x060006A0 RID: 1696
		private delegate void set_dampingRatioDelegate(IntPtr @this, float value);

		// Token: 0x0200016C RID: 364
		// (Invoke) Token: 0x060006A2 RID: 1698
		private delegate float get_frequencyDelegate(IntPtr @this);

		// Token: 0x0200016D RID: 365
		// (Invoke) Token: 0x060006A4 RID: 1700
		private delegate void set_frequencyDelegate(IntPtr @this, float value);
	}
}

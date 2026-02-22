using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000020 RID: 32
	public sealed class DistanceJoint2D : AnchoredJoint2D
	{
		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00003C95 File Offset: 0x00001E95
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00003CA7 File Offset: 0x00001EA7
		public bool autoConfigureDistance
		{
			get
			{
				return DistanceJoint2D.get_autoConfigureDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				DistanceJoint2D.set_autoConfigureDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00003CBA File Offset: 0x00001EBA
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00003CCC File Offset: 0x00001ECC
		public float distance
		{
			get
			{
				return DistanceJoint2D.get_distanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				DistanceJoint2D.set_distanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00003CDF File Offset: 0x00001EDF
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00003CF1 File Offset: 0x00001EF1
		public bool maxDistanceOnly
		{
			get
			{
				return DistanceJoint2D.get_maxDistanceOnlyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				DistanceJoint2D.set_maxDistanceOnlyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040001E1 RID: 481
		private static readonly DistanceJoint2D.get_autoConfigureDistanceDelegate get_autoConfigureDistanceDelegateField = IL2CPP.ResolveICall<DistanceJoint2D.get_autoConfigureDistanceDelegate>("UnityEngine.DistanceJoint2D::get_autoConfigureDistance");

		// Token: 0x040001E2 RID: 482
		private static readonly DistanceJoint2D.set_autoConfigureDistanceDelegate set_autoConfigureDistanceDelegateField = IL2CPP.ResolveICall<DistanceJoint2D.set_autoConfigureDistanceDelegate>("UnityEngine.DistanceJoint2D::set_autoConfigureDistance");

		// Token: 0x040001E3 RID: 483
		private static readonly DistanceJoint2D.get_distanceDelegate get_distanceDelegateField = IL2CPP.ResolveICall<DistanceJoint2D.get_distanceDelegate>("UnityEngine.DistanceJoint2D::get_distance");

		// Token: 0x040001E4 RID: 484
		private static readonly DistanceJoint2D.set_distanceDelegate set_distanceDelegateField = IL2CPP.ResolveICall<DistanceJoint2D.set_distanceDelegate>("UnityEngine.DistanceJoint2D::set_distance");

		// Token: 0x040001E5 RID: 485
		private static readonly DistanceJoint2D.get_maxDistanceOnlyDelegate get_maxDistanceOnlyDelegateField = IL2CPP.ResolveICall<DistanceJoint2D.get_maxDistanceOnlyDelegate>("UnityEngine.DistanceJoint2D::get_maxDistanceOnly");

		// Token: 0x040001E6 RID: 486
		private static readonly DistanceJoint2D.set_maxDistanceOnlyDelegate set_maxDistanceOnlyDelegateField = IL2CPP.ResolveICall<DistanceJoint2D.set_maxDistanceOnlyDelegate>("UnityEngine.DistanceJoint2D::set_maxDistanceOnly");

		// Token: 0x0200016E RID: 366
		// (Invoke) Token: 0x060006A6 RID: 1702
		private delegate bool get_autoConfigureDistanceDelegate(IntPtr @this);

		// Token: 0x0200016F RID: 367
		// (Invoke) Token: 0x060006A8 RID: 1704
		private delegate void set_autoConfigureDistanceDelegate(IntPtr @this, bool value);

		// Token: 0x02000170 RID: 368
		// (Invoke) Token: 0x060006AA RID: 1706
		private delegate float get_distanceDelegate(IntPtr @this);

		// Token: 0x02000171 RID: 369
		// (Invoke) Token: 0x060006AC RID: 1708
		private delegate void set_distanceDelegate(IntPtr @this, float value);

		// Token: 0x02000172 RID: 370
		// (Invoke) Token: 0x060006AE RID: 1710
		private delegate bool get_maxDistanceOnlyDelegate(IntPtr @this);

		// Token: 0x02000173 RID: 371
		// (Invoke) Token: 0x060006B0 RID: 1712
		private delegate void set_maxDistanceOnlyDelegate(IntPtr @this, bool value);
	}
}

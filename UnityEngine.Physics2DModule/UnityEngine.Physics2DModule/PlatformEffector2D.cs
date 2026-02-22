using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200002C RID: 44
	public class PlatformEffector2D : Effector2D
	{
		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0000459A File Offset: 0x0000279A
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x000045AC File Offset: 0x000027AC
		public bool useOneWay
		{
			get
			{
				return PlatformEffector2D.get_useOneWayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_useOneWayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x000045BF File Offset: 0x000027BF
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x000045D1 File Offset: 0x000027D1
		public bool useOneWayGrouping
		{
			get
			{
				return PlatformEffector2D.get_useOneWayGroupingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_useOneWayGroupingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x000045E4 File Offset: 0x000027E4
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x000045F6 File Offset: 0x000027F6
		public bool useSideFriction
		{
			get
			{
				return PlatformEffector2D.get_useSideFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_useSideFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x00004609 File Offset: 0x00002809
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x0000461B File Offset: 0x0000281B
		public bool useSideBounce
		{
			get
			{
				return PlatformEffector2D.get_useSideBounceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_useSideBounceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x0000462E File Offset: 0x0000282E
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x00004640 File Offset: 0x00002840
		public float surfaceArc
		{
			get
			{
				return PlatformEffector2D.get_surfaceArcDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_surfaceArcDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x00004653 File Offset: 0x00002853
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x00004665 File Offset: 0x00002865
		public float sideArc
		{
			get
			{
				return PlatformEffector2D.get_sideArcDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_sideArcDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x00004678 File Offset: 0x00002878
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x0000468A File Offset: 0x0000288A
		public float rotationalOffset
		{
			get
			{
				return PlatformEffector2D.get_rotationalOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PlatformEffector2D.set_rotationalOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000259 RID: 601
		private static readonly PlatformEffector2D.get_useOneWayDelegate get_useOneWayDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_useOneWayDelegate>("UnityEngine.PlatformEffector2D::get_useOneWay");

		// Token: 0x0400025A RID: 602
		private static readonly PlatformEffector2D.set_useOneWayDelegate set_useOneWayDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_useOneWayDelegate>("UnityEngine.PlatformEffector2D::set_useOneWay");

		// Token: 0x0400025B RID: 603
		private static readonly PlatformEffector2D.get_useOneWayGroupingDelegate get_useOneWayGroupingDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_useOneWayGroupingDelegate>("UnityEngine.PlatformEffector2D::get_useOneWayGrouping");

		// Token: 0x0400025C RID: 604
		private static readonly PlatformEffector2D.set_useOneWayGroupingDelegate set_useOneWayGroupingDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_useOneWayGroupingDelegate>("UnityEngine.PlatformEffector2D::set_useOneWayGrouping");

		// Token: 0x0400025D RID: 605
		private static readonly PlatformEffector2D.get_useSideFrictionDelegate get_useSideFrictionDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_useSideFrictionDelegate>("UnityEngine.PlatformEffector2D::get_useSideFriction");

		// Token: 0x0400025E RID: 606
		private static readonly PlatformEffector2D.set_useSideFrictionDelegate set_useSideFrictionDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_useSideFrictionDelegate>("UnityEngine.PlatformEffector2D::set_useSideFriction");

		// Token: 0x0400025F RID: 607
		private static readonly PlatformEffector2D.get_useSideBounceDelegate get_useSideBounceDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_useSideBounceDelegate>("UnityEngine.PlatformEffector2D::get_useSideBounce");

		// Token: 0x04000260 RID: 608
		private static readonly PlatformEffector2D.set_useSideBounceDelegate set_useSideBounceDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_useSideBounceDelegate>("UnityEngine.PlatformEffector2D::set_useSideBounce");

		// Token: 0x04000261 RID: 609
		private static readonly PlatformEffector2D.get_surfaceArcDelegate get_surfaceArcDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_surfaceArcDelegate>("UnityEngine.PlatformEffector2D::get_surfaceArc");

		// Token: 0x04000262 RID: 610
		private static readonly PlatformEffector2D.set_surfaceArcDelegate set_surfaceArcDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_surfaceArcDelegate>("UnityEngine.PlatformEffector2D::set_surfaceArc");

		// Token: 0x04000263 RID: 611
		private static readonly PlatformEffector2D.get_sideArcDelegate get_sideArcDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_sideArcDelegate>("UnityEngine.PlatformEffector2D::get_sideArc");

		// Token: 0x04000264 RID: 612
		private static readonly PlatformEffector2D.set_sideArcDelegate set_sideArcDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_sideArcDelegate>("UnityEngine.PlatformEffector2D::set_sideArc");

		// Token: 0x04000265 RID: 613
		private static readonly PlatformEffector2D.get_rotationalOffsetDelegate get_rotationalOffsetDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.get_rotationalOffsetDelegate>("UnityEngine.PlatformEffector2D::get_rotationalOffset");

		// Token: 0x04000266 RID: 614
		private static readonly PlatformEffector2D.set_rotationalOffsetDelegate set_rotationalOffsetDelegateField = IL2CPP.ResolveICall<PlatformEffector2D.set_rotationalOffsetDelegate>("UnityEngine.PlatformEffector2D::set_rotationalOffset");

		// Token: 0x020001E6 RID: 486
		// (Invoke) Token: 0x06000796 RID: 1942
		private delegate bool get_useOneWayDelegate(IntPtr @this);

		// Token: 0x020001E7 RID: 487
		// (Invoke) Token: 0x06000798 RID: 1944
		private delegate void set_useOneWayDelegate(IntPtr @this, bool value);

		// Token: 0x020001E8 RID: 488
		// (Invoke) Token: 0x0600079A RID: 1946
		private delegate bool get_useOneWayGroupingDelegate(IntPtr @this);

		// Token: 0x020001E9 RID: 489
		// (Invoke) Token: 0x0600079C RID: 1948
		private delegate void set_useOneWayGroupingDelegate(IntPtr @this, bool value);

		// Token: 0x020001EA RID: 490
		// (Invoke) Token: 0x0600079E RID: 1950
		private delegate bool get_useSideFrictionDelegate(IntPtr @this);

		// Token: 0x020001EB RID: 491
		// (Invoke) Token: 0x060007A0 RID: 1952
		private delegate void set_useSideFrictionDelegate(IntPtr @this, bool value);

		// Token: 0x020001EC RID: 492
		// (Invoke) Token: 0x060007A2 RID: 1954
		private delegate bool get_useSideBounceDelegate(IntPtr @this);

		// Token: 0x020001ED RID: 493
		// (Invoke) Token: 0x060007A4 RID: 1956
		private delegate void set_useSideBounceDelegate(IntPtr @this, bool value);

		// Token: 0x020001EE RID: 494
		// (Invoke) Token: 0x060007A6 RID: 1958
		private delegate float get_surfaceArcDelegate(IntPtr @this);

		// Token: 0x020001EF RID: 495
		// (Invoke) Token: 0x060007A8 RID: 1960
		private delegate void set_surfaceArcDelegate(IntPtr @this, float value);

		// Token: 0x020001F0 RID: 496
		// (Invoke) Token: 0x060007AA RID: 1962
		private delegate float get_sideArcDelegate(IntPtr @this);

		// Token: 0x020001F1 RID: 497
		// (Invoke) Token: 0x060007AC RID: 1964
		private delegate void set_sideArcDelegate(IntPtr @this, float value);

		// Token: 0x020001F2 RID: 498
		// (Invoke) Token: 0x060007AE RID: 1966
		private delegate float get_rotationalOffsetDelegate(IntPtr @this);

		// Token: 0x020001F3 RID: 499
		// (Invoke) Token: 0x060007B0 RID: 1968
		private delegate void set_rotationalOffsetDelegate(IntPtr @this, float value);
	}
}

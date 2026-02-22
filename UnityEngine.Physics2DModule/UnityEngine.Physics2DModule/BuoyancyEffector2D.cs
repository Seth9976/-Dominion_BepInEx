using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200002A RID: 42
	public class BuoyancyEffector2D : Effector2D
	{
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x0000436F File Offset: 0x0000256F
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x00004381 File Offset: 0x00002581
		public float surfaceLevel
		{
			get
			{
				return BuoyancyEffector2D.get_surfaceLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_surfaceLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00004394 File Offset: 0x00002594
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x000043A6 File Offset: 0x000025A6
		public float density
		{
			get
			{
				return BuoyancyEffector2D.get_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x000043B9 File Offset: 0x000025B9
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x000043CB File Offset: 0x000025CB
		public float linearDrag
		{
			get
			{
				return BuoyancyEffector2D.get_linearDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_linearDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x000043DE File Offset: 0x000025DE
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x000043F0 File Offset: 0x000025F0
		public float angularDrag
		{
			get
			{
				return BuoyancyEffector2D.get_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00004403 File Offset: 0x00002603
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x00004415 File Offset: 0x00002615
		public float flowAngle
		{
			get
			{
				return BuoyancyEffector2D.get_flowAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_flowAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00004428 File Offset: 0x00002628
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x0000443A File Offset: 0x0000263A
		public float flowMagnitude
		{
			get
			{
				return BuoyancyEffector2D.get_flowMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_flowMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0000444D File Offset: 0x0000264D
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x0000445F File Offset: 0x0000265F
		public float flowVariation
		{
			get
			{
				return BuoyancyEffector2D.get_flowVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_flowVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0400023B RID: 571
		private static readonly BuoyancyEffector2D.get_surfaceLevelDelegate get_surfaceLevelDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_surfaceLevelDelegate>("UnityEngine.BuoyancyEffector2D::get_surfaceLevel");

		// Token: 0x0400023C RID: 572
		private static readonly BuoyancyEffector2D.set_surfaceLevelDelegate set_surfaceLevelDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_surfaceLevelDelegate>("UnityEngine.BuoyancyEffector2D::set_surfaceLevel");

		// Token: 0x0400023D RID: 573
		private static readonly BuoyancyEffector2D.get_densityDelegate get_densityDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_densityDelegate>("UnityEngine.BuoyancyEffector2D::get_density");

		// Token: 0x0400023E RID: 574
		private static readonly BuoyancyEffector2D.set_densityDelegate set_densityDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_densityDelegate>("UnityEngine.BuoyancyEffector2D::set_density");

		// Token: 0x0400023F RID: 575
		private static readonly BuoyancyEffector2D.get_linearDragDelegate get_linearDragDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_linearDragDelegate>("UnityEngine.BuoyancyEffector2D::get_linearDrag");

		// Token: 0x04000240 RID: 576
		private static readonly BuoyancyEffector2D.set_linearDragDelegate set_linearDragDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_linearDragDelegate>("UnityEngine.BuoyancyEffector2D::set_linearDrag");

		// Token: 0x04000241 RID: 577
		private static readonly BuoyancyEffector2D.get_angularDragDelegate get_angularDragDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_angularDragDelegate>("UnityEngine.BuoyancyEffector2D::get_angularDrag");

		// Token: 0x04000242 RID: 578
		private static readonly BuoyancyEffector2D.set_angularDragDelegate set_angularDragDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_angularDragDelegate>("UnityEngine.BuoyancyEffector2D::set_angularDrag");

		// Token: 0x04000243 RID: 579
		private static readonly BuoyancyEffector2D.get_flowAngleDelegate get_flowAngleDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_flowAngleDelegate>("UnityEngine.BuoyancyEffector2D::get_flowAngle");

		// Token: 0x04000244 RID: 580
		private static readonly BuoyancyEffector2D.set_flowAngleDelegate set_flowAngleDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_flowAngleDelegate>("UnityEngine.BuoyancyEffector2D::set_flowAngle");

		// Token: 0x04000245 RID: 581
		private static readonly BuoyancyEffector2D.get_flowMagnitudeDelegate get_flowMagnitudeDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_flowMagnitudeDelegate>("UnityEngine.BuoyancyEffector2D::get_flowMagnitude");

		// Token: 0x04000246 RID: 582
		private static readonly BuoyancyEffector2D.set_flowMagnitudeDelegate set_flowMagnitudeDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_flowMagnitudeDelegate>("UnityEngine.BuoyancyEffector2D::set_flowMagnitude");

		// Token: 0x04000247 RID: 583
		private static readonly BuoyancyEffector2D.get_flowVariationDelegate get_flowVariationDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_flowVariationDelegate>("UnityEngine.BuoyancyEffector2D::get_flowVariation");

		// Token: 0x04000248 RID: 584
		private static readonly BuoyancyEffector2D.set_flowVariationDelegate set_flowVariationDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_flowVariationDelegate>("UnityEngine.BuoyancyEffector2D::set_flowVariation");

		// Token: 0x020001C8 RID: 456
		// (Invoke) Token: 0x0600075A RID: 1882
		private delegate float get_surfaceLevelDelegate(IntPtr @this);

		// Token: 0x020001C9 RID: 457
		// (Invoke) Token: 0x0600075C RID: 1884
		private delegate void set_surfaceLevelDelegate(IntPtr @this, float value);

		// Token: 0x020001CA RID: 458
		// (Invoke) Token: 0x0600075E RID: 1886
		private delegate float get_densityDelegate(IntPtr @this);

		// Token: 0x020001CB RID: 459
		// (Invoke) Token: 0x06000760 RID: 1888
		private delegate void set_densityDelegate(IntPtr @this, float value);

		// Token: 0x020001CC RID: 460
		// (Invoke) Token: 0x06000762 RID: 1890
		private delegate float get_linearDragDelegate(IntPtr @this);

		// Token: 0x020001CD RID: 461
		// (Invoke) Token: 0x06000764 RID: 1892
		private delegate void set_linearDragDelegate(IntPtr @this, float value);

		// Token: 0x020001CE RID: 462
		// (Invoke) Token: 0x06000766 RID: 1894
		private delegate float get_angularDragDelegate(IntPtr @this);

		// Token: 0x020001CF RID: 463
		// (Invoke) Token: 0x06000768 RID: 1896
		private delegate void set_angularDragDelegate(IntPtr @this, float value);

		// Token: 0x020001D0 RID: 464
		// (Invoke) Token: 0x0600076A RID: 1898
		private delegate float get_flowAngleDelegate(IntPtr @this);

		// Token: 0x020001D1 RID: 465
		// (Invoke) Token: 0x0600076C RID: 1900
		private delegate void set_flowAngleDelegate(IntPtr @this, float value);

		// Token: 0x020001D2 RID: 466
		// (Invoke) Token: 0x0600076E RID: 1902
		private delegate float get_flowMagnitudeDelegate(IntPtr @this);

		// Token: 0x020001D3 RID: 467
		// (Invoke) Token: 0x06000770 RID: 1904
		private delegate void set_flowMagnitudeDelegate(IntPtr @this, float value);

		// Token: 0x020001D4 RID: 468
		// (Invoke) Token: 0x06000772 RID: 1906
		private delegate float get_flowVariationDelegate(IntPtr @this);

		// Token: 0x020001D5 RID: 469
		// (Invoke) Token: 0x06000774 RID: 1908
		private delegate void set_flowVariationDelegate(IntPtr @this, float value);
	}
}

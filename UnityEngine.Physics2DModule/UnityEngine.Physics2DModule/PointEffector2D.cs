using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200002B RID: 43
	public class PointEffector2D : Effector2D
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00004472 File Offset: 0x00002672
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00004484 File Offset: 0x00002684
		public float forceMagnitude
		{
			get
			{
				return PointEffector2D.get_forceMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_forceMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00004497 File Offset: 0x00002697
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x000044A9 File Offset: 0x000026A9
		public float forceVariation
		{
			get
			{
				return PointEffector2D.get_forceVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_forceVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x000044BC File Offset: 0x000026BC
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x000044CE File Offset: 0x000026CE
		public float distanceScale
		{
			get
			{
				return PointEffector2D.get_distanceScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_distanceScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x000044E1 File Offset: 0x000026E1
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x000044F3 File Offset: 0x000026F3
		public float drag
		{
			get
			{
				return PointEffector2D.get_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00004506 File Offset: 0x00002706
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x00004518 File Offset: 0x00002718
		public float angularDrag
		{
			get
			{
				return PointEffector2D.get_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0000452B File Offset: 0x0000272B
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x0000453D File Offset: 0x0000273D
		public EffectorSelection2D forceSource
		{
			get
			{
				return PointEffector2D.get_forceSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_forceSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00004550 File Offset: 0x00002750
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00004562 File Offset: 0x00002762
		public EffectorSelection2D forceTarget
		{
			get
			{
				return PointEffector2D.get_forceTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_forceTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00004575 File Offset: 0x00002775
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00004587 File Offset: 0x00002787
		public EffectorForceMode2D forceMode
		{
			get
			{
				return PointEffector2D.get_forceModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_forceModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000249 RID: 585
		private static readonly PointEffector2D.get_forceMagnitudeDelegate get_forceMagnitudeDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_forceMagnitudeDelegate>("UnityEngine.PointEffector2D::get_forceMagnitude");

		// Token: 0x0400024A RID: 586
		private static readonly PointEffector2D.set_forceMagnitudeDelegate set_forceMagnitudeDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_forceMagnitudeDelegate>("UnityEngine.PointEffector2D::set_forceMagnitude");

		// Token: 0x0400024B RID: 587
		private static readonly PointEffector2D.get_forceVariationDelegate get_forceVariationDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_forceVariationDelegate>("UnityEngine.PointEffector2D::get_forceVariation");

		// Token: 0x0400024C RID: 588
		private static readonly PointEffector2D.set_forceVariationDelegate set_forceVariationDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_forceVariationDelegate>("UnityEngine.PointEffector2D::set_forceVariation");

		// Token: 0x0400024D RID: 589
		private static readonly PointEffector2D.get_distanceScaleDelegate get_distanceScaleDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_distanceScaleDelegate>("UnityEngine.PointEffector2D::get_distanceScale");

		// Token: 0x0400024E RID: 590
		private static readonly PointEffector2D.set_distanceScaleDelegate set_distanceScaleDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_distanceScaleDelegate>("UnityEngine.PointEffector2D::set_distanceScale");

		// Token: 0x0400024F RID: 591
		private static readonly PointEffector2D.get_dragDelegate get_dragDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_dragDelegate>("UnityEngine.PointEffector2D::get_drag");

		// Token: 0x04000250 RID: 592
		private static readonly PointEffector2D.set_dragDelegate set_dragDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_dragDelegate>("UnityEngine.PointEffector2D::set_drag");

		// Token: 0x04000251 RID: 593
		private static readonly PointEffector2D.get_angularDragDelegate get_angularDragDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_angularDragDelegate>("UnityEngine.PointEffector2D::get_angularDrag");

		// Token: 0x04000252 RID: 594
		private static readonly PointEffector2D.set_angularDragDelegate set_angularDragDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_angularDragDelegate>("UnityEngine.PointEffector2D::set_angularDrag");

		// Token: 0x04000253 RID: 595
		private static readonly PointEffector2D.get_forceSourceDelegate get_forceSourceDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_forceSourceDelegate>("UnityEngine.PointEffector2D::get_forceSource");

		// Token: 0x04000254 RID: 596
		private static readonly PointEffector2D.set_forceSourceDelegate set_forceSourceDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_forceSourceDelegate>("UnityEngine.PointEffector2D::set_forceSource");

		// Token: 0x04000255 RID: 597
		private static readonly PointEffector2D.get_forceTargetDelegate get_forceTargetDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_forceTargetDelegate>("UnityEngine.PointEffector2D::get_forceTarget");

		// Token: 0x04000256 RID: 598
		private static readonly PointEffector2D.set_forceTargetDelegate set_forceTargetDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_forceTargetDelegate>("UnityEngine.PointEffector2D::set_forceTarget");

		// Token: 0x04000257 RID: 599
		private static readonly PointEffector2D.get_forceModeDelegate get_forceModeDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_forceModeDelegate>("UnityEngine.PointEffector2D::get_forceMode");

		// Token: 0x04000258 RID: 600
		private static readonly PointEffector2D.set_forceModeDelegate set_forceModeDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_forceModeDelegate>("UnityEngine.PointEffector2D::set_forceMode");

		// Token: 0x020001D6 RID: 470
		// (Invoke) Token: 0x06000776 RID: 1910
		private delegate float get_forceMagnitudeDelegate(IntPtr @this);

		// Token: 0x020001D7 RID: 471
		// (Invoke) Token: 0x06000778 RID: 1912
		private delegate void set_forceMagnitudeDelegate(IntPtr @this, float value);

		// Token: 0x020001D8 RID: 472
		// (Invoke) Token: 0x0600077A RID: 1914
		private delegate float get_forceVariationDelegate(IntPtr @this);

		// Token: 0x020001D9 RID: 473
		// (Invoke) Token: 0x0600077C RID: 1916
		private delegate void set_forceVariationDelegate(IntPtr @this, float value);

		// Token: 0x020001DA RID: 474
		// (Invoke) Token: 0x0600077E RID: 1918
		private delegate float get_distanceScaleDelegate(IntPtr @this);

		// Token: 0x020001DB RID: 475
		// (Invoke) Token: 0x06000780 RID: 1920
		private delegate void set_distanceScaleDelegate(IntPtr @this, float value);

		// Token: 0x020001DC RID: 476
		// (Invoke) Token: 0x06000782 RID: 1922
		private delegate float get_dragDelegate(IntPtr @this);

		// Token: 0x020001DD RID: 477
		// (Invoke) Token: 0x06000784 RID: 1924
		private delegate void set_dragDelegate(IntPtr @this, float value);

		// Token: 0x020001DE RID: 478
		// (Invoke) Token: 0x06000786 RID: 1926
		private delegate float get_angularDragDelegate(IntPtr @this);

		// Token: 0x020001DF RID: 479
		// (Invoke) Token: 0x06000788 RID: 1928
		private delegate void set_angularDragDelegate(IntPtr @this, float value);

		// Token: 0x020001E0 RID: 480
		// (Invoke) Token: 0x0600078A RID: 1930
		private delegate EffectorSelection2D get_forceSourceDelegate(IntPtr @this);

		// Token: 0x020001E1 RID: 481
		// (Invoke) Token: 0x0600078C RID: 1932
		private delegate void set_forceSourceDelegate(IntPtr @this, EffectorSelection2D value);

		// Token: 0x020001E2 RID: 482
		// (Invoke) Token: 0x0600078E RID: 1934
		private delegate EffectorSelection2D get_forceTargetDelegate(IntPtr @this);

		// Token: 0x020001E3 RID: 483
		// (Invoke) Token: 0x06000790 RID: 1936
		private delegate void set_forceTargetDelegate(IntPtr @this, EffectorSelection2D value);

		// Token: 0x020001E4 RID: 484
		// (Invoke) Token: 0x06000792 RID: 1938
		private delegate EffectorForceMode2D get_forceModeDelegate(IntPtr @this);

		// Token: 0x020001E5 RID: 485
		// (Invoke) Token: 0x06000794 RID: 1940
		private delegate void set_forceModeDelegate(IntPtr @this, EffectorForceMode2D value);
	}
}

using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000029 RID: 41
	public class AreaEffector2D : Effector2D
	{
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x0000426C File Offset: 0x0000246C
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x0000427E File Offset: 0x0000247E
		public float forceAngle
		{
			get
			{
				return AreaEffector2D.get_forceAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_forceAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00004291 File Offset: 0x00002491
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x000042A3 File Offset: 0x000024A3
		public bool useGlobalAngle
		{
			get
			{
				return AreaEffector2D.get_useGlobalAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_useGlobalAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x000042B6 File Offset: 0x000024B6
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x000042C8 File Offset: 0x000024C8
		public float forceMagnitude
		{
			get
			{
				return AreaEffector2D.get_forceMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_forceMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003DA RID: 986 RVA: 0x000042DB File Offset: 0x000024DB
		// (set) Token: 0x060003DB RID: 987 RVA: 0x000042ED File Offset: 0x000024ED
		public float forceVariation
		{
			get
			{
				return AreaEffector2D.get_forceVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_forceVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00004300 File Offset: 0x00002500
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00004312 File Offset: 0x00002512
		public float drag
		{
			get
			{
				return AreaEffector2D.get_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00004325 File Offset: 0x00002525
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00004337 File Offset: 0x00002537
		public float angularDrag
		{
			get
			{
				return AreaEffector2D.get_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0000434A File Offset: 0x0000254A
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x0000435C File Offset: 0x0000255C
		public EffectorSelection2D forceTarget
		{
			get
			{
				return AreaEffector2D.get_forceTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_forceTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0400022D RID: 557
		private static readonly AreaEffector2D.get_forceAngleDelegate get_forceAngleDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_forceAngleDelegate>("UnityEngine.AreaEffector2D::get_forceAngle");

		// Token: 0x0400022E RID: 558
		private static readonly AreaEffector2D.set_forceAngleDelegate set_forceAngleDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_forceAngleDelegate>("UnityEngine.AreaEffector2D::set_forceAngle");

		// Token: 0x0400022F RID: 559
		private static readonly AreaEffector2D.get_useGlobalAngleDelegate get_useGlobalAngleDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_useGlobalAngleDelegate>("UnityEngine.AreaEffector2D::get_useGlobalAngle");

		// Token: 0x04000230 RID: 560
		private static readonly AreaEffector2D.set_useGlobalAngleDelegate set_useGlobalAngleDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_useGlobalAngleDelegate>("UnityEngine.AreaEffector2D::set_useGlobalAngle");

		// Token: 0x04000231 RID: 561
		private static readonly AreaEffector2D.get_forceMagnitudeDelegate get_forceMagnitudeDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_forceMagnitudeDelegate>("UnityEngine.AreaEffector2D::get_forceMagnitude");

		// Token: 0x04000232 RID: 562
		private static readonly AreaEffector2D.set_forceMagnitudeDelegate set_forceMagnitudeDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_forceMagnitudeDelegate>("UnityEngine.AreaEffector2D::set_forceMagnitude");

		// Token: 0x04000233 RID: 563
		private static readonly AreaEffector2D.get_forceVariationDelegate get_forceVariationDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_forceVariationDelegate>("UnityEngine.AreaEffector2D::get_forceVariation");

		// Token: 0x04000234 RID: 564
		private static readonly AreaEffector2D.set_forceVariationDelegate set_forceVariationDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_forceVariationDelegate>("UnityEngine.AreaEffector2D::set_forceVariation");

		// Token: 0x04000235 RID: 565
		private static readonly AreaEffector2D.get_dragDelegate get_dragDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_dragDelegate>("UnityEngine.AreaEffector2D::get_drag");

		// Token: 0x04000236 RID: 566
		private static readonly AreaEffector2D.set_dragDelegate set_dragDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_dragDelegate>("UnityEngine.AreaEffector2D::set_drag");

		// Token: 0x04000237 RID: 567
		private static readonly AreaEffector2D.get_angularDragDelegate get_angularDragDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_angularDragDelegate>("UnityEngine.AreaEffector2D::get_angularDrag");

		// Token: 0x04000238 RID: 568
		private static readonly AreaEffector2D.set_angularDragDelegate set_angularDragDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_angularDragDelegate>("UnityEngine.AreaEffector2D::set_angularDrag");

		// Token: 0x04000239 RID: 569
		private static readonly AreaEffector2D.get_forceTargetDelegate get_forceTargetDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_forceTargetDelegate>("UnityEngine.AreaEffector2D::get_forceTarget");

		// Token: 0x0400023A RID: 570
		private static readonly AreaEffector2D.set_forceTargetDelegate set_forceTargetDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_forceTargetDelegate>("UnityEngine.AreaEffector2D::set_forceTarget");

		// Token: 0x020001BA RID: 442
		// (Invoke) Token: 0x0600073E RID: 1854
		private delegate float get_forceAngleDelegate(IntPtr @this);

		// Token: 0x020001BB RID: 443
		// (Invoke) Token: 0x06000740 RID: 1856
		private delegate void set_forceAngleDelegate(IntPtr @this, float value);

		// Token: 0x020001BC RID: 444
		// (Invoke) Token: 0x06000742 RID: 1858
		private delegate bool get_useGlobalAngleDelegate(IntPtr @this);

		// Token: 0x020001BD RID: 445
		// (Invoke) Token: 0x06000744 RID: 1860
		private delegate void set_useGlobalAngleDelegate(IntPtr @this, bool value);

		// Token: 0x020001BE RID: 446
		// (Invoke) Token: 0x06000746 RID: 1862
		private delegate float get_forceMagnitudeDelegate(IntPtr @this);

		// Token: 0x020001BF RID: 447
		// (Invoke) Token: 0x06000748 RID: 1864
		private delegate void set_forceMagnitudeDelegate(IntPtr @this, float value);

		// Token: 0x020001C0 RID: 448
		// (Invoke) Token: 0x0600074A RID: 1866
		private delegate float get_forceVariationDelegate(IntPtr @this);

		// Token: 0x020001C1 RID: 449
		// (Invoke) Token: 0x0600074C RID: 1868
		private delegate void set_forceVariationDelegate(IntPtr @this, float value);

		// Token: 0x020001C2 RID: 450
		// (Invoke) Token: 0x0600074E RID: 1870
		private delegate float get_dragDelegate(IntPtr @this);

		// Token: 0x020001C3 RID: 451
		// (Invoke) Token: 0x06000750 RID: 1872
		private delegate void set_dragDelegate(IntPtr @this, float value);

		// Token: 0x020001C4 RID: 452
		// (Invoke) Token: 0x06000752 RID: 1874
		private delegate float get_angularDragDelegate(IntPtr @this);

		// Token: 0x020001C5 RID: 453
		// (Invoke) Token: 0x06000754 RID: 1876
		private delegate void set_angularDragDelegate(IntPtr @this, float value);

		// Token: 0x020001C6 RID: 454
		// (Invoke) Token: 0x06000756 RID: 1878
		private delegate EffectorSelection2D get_forceTargetDelegate(IntPtr @this);

		// Token: 0x020001C7 RID: 455
		// (Invoke) Token: 0x06000758 RID: 1880
		private delegate void set_forceTargetDelegate(IntPtr @this, EffectorSelection2D value);
	}
}

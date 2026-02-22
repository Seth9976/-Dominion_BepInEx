using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x0200005B RID: 91
	public sealed class ScaleConstraint : Behaviour
	{
		// Token: 0x06000502 RID: 1282 RVA: 0x0000545E File Offset: 0x0000365E
		public static void Internal_Create(ScaleConstraint self)
		{
			ScaleConstraint.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x00005470 File Offset: 0x00003670
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x00005482 File Offset: 0x00003682
		public float weight
		{
			get
			{
				return ScaleConstraint.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ScaleConstraint.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x0000D22C File Offset: 0x0000B42C
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x00005495 File Offset: 0x00003695
		public Vector3 scaleAtRest
		{
			get
			{
				Vector3 vector;
				this.get_scaleAtRest_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_scaleAtRest_Injected(ref value);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x0000D244 File Offset: 0x0000B444
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x0000549F File Offset: 0x0000369F
		public Vector3 scaleOffset
		{
			get
			{
				Vector3 vector;
				this.get_scaleOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_scaleOffset_Injected(ref value);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x000054A9 File Offset: 0x000036A9
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x000054BB File Offset: 0x000036BB
		public Axis scalingAxis
		{
			get
			{
				return ScaleConstraint.get_scalingAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ScaleConstraint.set_scalingAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x000054CE File Offset: 0x000036CE
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x000054E0 File Offset: 0x000036E0
		public bool constraintActive
		{
			get
			{
				return ScaleConstraint.get_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ScaleConstraint.set_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x000054F3 File Offset: 0x000036F3
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x00005505 File Offset: 0x00003705
		public bool locked
		{
			get
			{
				return ScaleConstraint.get_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ScaleConstraint.set_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x0000D25C File Offset: 0x0000B45C
		public int sourceCount
		{
			get
			{
				return ScaleConstraint.GetSourceCountInternal(this);
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00005518 File Offset: 0x00003718
		public static int GetSourceCountInternal(ScaleConstraint self)
		{
			return ScaleConstraint.GetSourceCountInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0000552A File Offset: 0x0000372A
		public void RemoveSource(int index)
		{
			this.ValidateSourceIndex(index);
			this.RemoveSourceInternal(index);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0000553D File Offset: 0x0000373D
		public void RemoveSourceInternal(int index)
		{
			ScaleConstraint.RemoveSourceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0000D274 File Offset: 0x0000B474
		public void ValidateSourceIndex(int index)
		{
			bool flag = this.sourceCount == 0;
			if (flag)
			{
				throw new InvalidOperationException("The ScaleConstraint component has no sources.");
			}
			bool flag2 = index < 0 || index >= this.sourceCount;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Constraint source index {0} is out of bounds (0-{1}).", index, this.sourceCount));
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00005550 File Offset: 0x00003750
		public void get_scaleAtRest_Injected(out Vector3 ret)
		{
			ScaleConstraint.get_scaleAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00005563 File Offset: 0x00003763
		public void set_scaleAtRest_Injected(ref Vector3 value)
		{
			ScaleConstraint.set_scaleAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00005576 File Offset: 0x00003776
		public void get_scaleOffset_Injected(out Vector3 ret)
		{
			ScaleConstraint.get_scaleOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00005589 File Offset: 0x00003789
		public void set_scaleOffset_Injected(ref Vector3 value)
		{
			ScaleConstraint.set_scaleOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040003AB RID: 939
		private static readonly ScaleConstraint.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<ScaleConstraint.Internal_CreateDelegate>("UnityEngine.Animations.ScaleConstraint::Internal_Create");

		// Token: 0x040003AC RID: 940
		private static readonly ScaleConstraint.get_weightDelegate get_weightDelegateField = IL2CPP.ResolveICall<ScaleConstraint.get_weightDelegate>("UnityEngine.Animations.ScaleConstraint::get_weight");

		// Token: 0x040003AD RID: 941
		private static readonly ScaleConstraint.set_weightDelegate set_weightDelegateField = IL2CPP.ResolveICall<ScaleConstraint.set_weightDelegate>("UnityEngine.Animations.ScaleConstraint::set_weight");

		// Token: 0x040003AE RID: 942
		private static readonly ScaleConstraint.get_scalingAxisDelegate get_scalingAxisDelegateField = IL2CPP.ResolveICall<ScaleConstraint.get_scalingAxisDelegate>("UnityEngine.Animations.ScaleConstraint::get_scalingAxis");

		// Token: 0x040003AF RID: 943
		private static readonly ScaleConstraint.set_scalingAxisDelegate set_scalingAxisDelegateField = IL2CPP.ResolveICall<ScaleConstraint.set_scalingAxisDelegate>("UnityEngine.Animations.ScaleConstraint::set_scalingAxis");

		// Token: 0x040003B0 RID: 944
		private static readonly ScaleConstraint.get_constraintActiveDelegate get_constraintActiveDelegateField = IL2CPP.ResolveICall<ScaleConstraint.get_constraintActiveDelegate>("UnityEngine.Animations.ScaleConstraint::get_constraintActive");

		// Token: 0x040003B1 RID: 945
		private static readonly ScaleConstraint.set_constraintActiveDelegate set_constraintActiveDelegateField = IL2CPP.ResolveICall<ScaleConstraint.set_constraintActiveDelegate>("UnityEngine.Animations.ScaleConstraint::set_constraintActive");

		// Token: 0x040003B2 RID: 946
		private static readonly ScaleConstraint.get_lockedDelegate get_lockedDelegateField = IL2CPP.ResolveICall<ScaleConstraint.get_lockedDelegate>("UnityEngine.Animations.ScaleConstraint::get_locked");

		// Token: 0x040003B3 RID: 947
		private static readonly ScaleConstraint.set_lockedDelegate set_lockedDelegateField = IL2CPP.ResolveICall<ScaleConstraint.set_lockedDelegate>("UnityEngine.Animations.ScaleConstraint::set_locked");

		// Token: 0x040003B4 RID: 948
		private static readonly ScaleConstraint.GetSourceCountInternalDelegate GetSourceCountInternalDelegateField = IL2CPP.ResolveICall<ScaleConstraint.GetSourceCountInternalDelegate>("UnityEngine.Animations.ScaleConstraint::GetSourceCountInternal");

		// Token: 0x040003B5 RID: 949
		private static readonly ScaleConstraint.RemoveSourceInternalDelegate RemoveSourceInternalDelegateField = IL2CPP.ResolveICall<ScaleConstraint.RemoveSourceInternalDelegate>("UnityEngine.Animations.ScaleConstraint::RemoveSourceInternal");

		// Token: 0x040003B6 RID: 950
		private static readonly ScaleConstraint.get_scaleAtRest_InjectedDelegate get_scaleAtRest_InjectedDelegateField = IL2CPP.ResolveICall<ScaleConstraint.get_scaleAtRest_InjectedDelegate>("UnityEngine.Animations.ScaleConstraint::get_scaleAtRest_Injected");

		// Token: 0x040003B7 RID: 951
		private static readonly ScaleConstraint.set_scaleAtRest_InjectedDelegate set_scaleAtRest_InjectedDelegateField = IL2CPP.ResolveICall<ScaleConstraint.set_scaleAtRest_InjectedDelegate>("UnityEngine.Animations.ScaleConstraint::set_scaleAtRest_Injected");

		// Token: 0x040003B8 RID: 952
		private static readonly ScaleConstraint.get_scaleOffset_InjectedDelegate get_scaleOffset_InjectedDelegateField = IL2CPP.ResolveICall<ScaleConstraint.get_scaleOffset_InjectedDelegate>("UnityEngine.Animations.ScaleConstraint::get_scaleOffset_Injected");

		// Token: 0x040003B9 RID: 953
		private static readonly ScaleConstraint.set_scaleOffset_InjectedDelegate set_scaleOffset_InjectedDelegateField = IL2CPP.ResolveICall<ScaleConstraint.set_scaleOffset_InjectedDelegate>("UnityEngine.Animations.ScaleConstraint::set_scaleOffset_Injected");

		// Token: 0x02000252 RID: 594
		// (Invoke) Token: 0x06000946 RID: 2374
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x02000253 RID: 595
		// (Invoke) Token: 0x06000948 RID: 2376
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x02000254 RID: 596
		// (Invoke) Token: 0x0600094A RID: 2378
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x02000255 RID: 597
		// (Invoke) Token: 0x0600094C RID: 2380
		private delegate Axis get_scalingAxisDelegate(IntPtr @this);

		// Token: 0x02000256 RID: 598
		// (Invoke) Token: 0x0600094E RID: 2382
		private delegate void set_scalingAxisDelegate(IntPtr @this, Axis value);

		// Token: 0x02000257 RID: 599
		// (Invoke) Token: 0x06000950 RID: 2384
		private delegate bool get_constraintActiveDelegate(IntPtr @this);

		// Token: 0x02000258 RID: 600
		// (Invoke) Token: 0x06000952 RID: 2386
		private delegate void set_constraintActiveDelegate(IntPtr @this, bool value);

		// Token: 0x02000259 RID: 601
		// (Invoke) Token: 0x06000954 RID: 2388
		private delegate bool get_lockedDelegate(IntPtr @this);

		// Token: 0x0200025A RID: 602
		// (Invoke) Token: 0x06000956 RID: 2390
		private delegate void set_lockedDelegate(IntPtr @this, bool value);

		// Token: 0x0200025B RID: 603
		// (Invoke) Token: 0x06000958 RID: 2392
		private delegate int GetSourceCountInternalDelegate(IntPtr self);

		// Token: 0x0200025C RID: 604
		// (Invoke) Token: 0x0600095A RID: 2394
		private delegate void RemoveSourceInternalDelegate(IntPtr @this, int index);

		// Token: 0x0200025D RID: 605
		// (Invoke) Token: 0x0600095C RID: 2396
		private delegate void get_scaleAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200025E RID: 606
		// (Invoke) Token: 0x0600095E RID: 2398
		private delegate void set_scaleAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200025F RID: 607
		// (Invoke) Token: 0x06000960 RID: 2400
		private delegate void get_scaleOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000260 RID: 608
		// (Invoke) Token: 0x06000962 RID: 2402
		private delegate void set_scaleOffset_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}

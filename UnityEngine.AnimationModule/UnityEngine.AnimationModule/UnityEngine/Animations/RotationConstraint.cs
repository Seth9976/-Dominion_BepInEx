using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x0200005A RID: 90
	public sealed class RotationConstraint : Behaviour
	{
		// Token: 0x060004EB RID: 1259 RVA: 0x00005320 File Offset: 0x00003520
		public static void Internal_Create(RotationConstraint self)
		{
			RotationConstraint.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00005332 File Offset: 0x00003532
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00005344 File Offset: 0x00003544
		public float weight
		{
			get
			{
				return RotationConstraint.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RotationConstraint.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x0000D08C File Offset: 0x0000B28C
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00005357 File Offset: 0x00003557
		public Vector3 rotationAtRest
		{
			get
			{
				Vector3 vector;
				this.get_rotationAtRest_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_rotationAtRest_Injected(ref value);
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0000D0A4 File Offset: 0x0000B2A4
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00005361 File Offset: 0x00003561
		public Vector3 rotationOffset
		{
			get
			{
				Vector3 vector;
				this.get_rotationOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_rotationOffset_Injected(ref value);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x0000536B File Offset: 0x0000356B
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x0000537D File Offset: 0x0000357D
		public Axis rotationAxis
		{
			get
			{
				return RotationConstraint.get_rotationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RotationConstraint.set_rotationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00005390 File Offset: 0x00003590
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x000053A2 File Offset: 0x000035A2
		public bool constraintActive
		{
			get
			{
				return RotationConstraint.get_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RotationConstraint.set_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x000053B5 File Offset: 0x000035B5
		// (set) Token: 0x060004F7 RID: 1271 RVA: 0x000053C7 File Offset: 0x000035C7
		public bool locked
		{
			get
			{
				return RotationConstraint.get_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				RotationConstraint.set_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x0000D0BC File Offset: 0x0000B2BC
		public int sourceCount
		{
			get
			{
				return RotationConstraint.GetSourceCountInternal(this);
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000053DA File Offset: 0x000035DA
		public static int GetSourceCountInternal(RotationConstraint self)
		{
			return RotationConstraint.GetSourceCountInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000053EC File Offset: 0x000035EC
		public void RemoveSource(int index)
		{
			this.ValidateSourceIndex(index);
			this.RemoveSourceInternal(index);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x000053FF File Offset: 0x000035FF
		public void RemoveSourceInternal(int index)
		{
			RotationConstraint.RemoveSourceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0000D0D4 File Offset: 0x0000B2D4
		public void ValidateSourceIndex(int index)
		{
			bool flag = this.sourceCount == 0;
			if (flag)
			{
				throw new InvalidOperationException("The RotationConstraint component has no sources.");
			}
			bool flag2 = index < 0 || index >= this.sourceCount;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Constraint source index {0} is out of bounds (0-{1}).", index, this.sourceCount));
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00005412 File Offset: 0x00003612
		public void get_rotationAtRest_Injected(out Vector3 ret)
		{
			RotationConstraint.get_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00005425 File Offset: 0x00003625
		public void set_rotationAtRest_Injected(ref Vector3 value)
		{
			RotationConstraint.set_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00005438 File Offset: 0x00003638
		public void get_rotationOffset_Injected(out Vector3 ret)
		{
			RotationConstraint.get_rotationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0000544B File Offset: 0x0000364B
		public void set_rotationOffset_Injected(ref Vector3 value)
		{
			RotationConstraint.set_rotationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0400039C RID: 924
		private static readonly RotationConstraint.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<RotationConstraint.Internal_CreateDelegate>("UnityEngine.Animations.RotationConstraint::Internal_Create");

		// Token: 0x0400039D RID: 925
		private static readonly RotationConstraint.get_weightDelegate get_weightDelegateField = IL2CPP.ResolveICall<RotationConstraint.get_weightDelegate>("UnityEngine.Animations.RotationConstraint::get_weight");

		// Token: 0x0400039E RID: 926
		private static readonly RotationConstraint.set_weightDelegate set_weightDelegateField = IL2CPP.ResolveICall<RotationConstraint.set_weightDelegate>("UnityEngine.Animations.RotationConstraint::set_weight");

		// Token: 0x0400039F RID: 927
		private static readonly RotationConstraint.get_rotationAxisDelegate get_rotationAxisDelegateField = IL2CPP.ResolveICall<RotationConstraint.get_rotationAxisDelegate>("UnityEngine.Animations.RotationConstraint::get_rotationAxis");

		// Token: 0x040003A0 RID: 928
		private static readonly RotationConstraint.set_rotationAxisDelegate set_rotationAxisDelegateField = IL2CPP.ResolveICall<RotationConstraint.set_rotationAxisDelegate>("UnityEngine.Animations.RotationConstraint::set_rotationAxis");

		// Token: 0x040003A1 RID: 929
		private static readonly RotationConstraint.get_constraintActiveDelegate get_constraintActiveDelegateField = IL2CPP.ResolveICall<RotationConstraint.get_constraintActiveDelegate>("UnityEngine.Animations.RotationConstraint::get_constraintActive");

		// Token: 0x040003A2 RID: 930
		private static readonly RotationConstraint.set_constraintActiveDelegate set_constraintActiveDelegateField = IL2CPP.ResolveICall<RotationConstraint.set_constraintActiveDelegate>("UnityEngine.Animations.RotationConstraint::set_constraintActive");

		// Token: 0x040003A3 RID: 931
		private static readonly RotationConstraint.get_lockedDelegate get_lockedDelegateField = IL2CPP.ResolveICall<RotationConstraint.get_lockedDelegate>("UnityEngine.Animations.RotationConstraint::get_locked");

		// Token: 0x040003A4 RID: 932
		private static readonly RotationConstraint.set_lockedDelegate set_lockedDelegateField = IL2CPP.ResolveICall<RotationConstraint.set_lockedDelegate>("UnityEngine.Animations.RotationConstraint::set_locked");

		// Token: 0x040003A5 RID: 933
		private static readonly RotationConstraint.GetSourceCountInternalDelegate GetSourceCountInternalDelegateField = IL2CPP.ResolveICall<RotationConstraint.GetSourceCountInternalDelegate>("UnityEngine.Animations.RotationConstraint::GetSourceCountInternal");

		// Token: 0x040003A6 RID: 934
		private static readonly RotationConstraint.RemoveSourceInternalDelegate RemoveSourceInternalDelegateField = IL2CPP.ResolveICall<RotationConstraint.RemoveSourceInternalDelegate>("UnityEngine.Animations.RotationConstraint::RemoveSourceInternal");

		// Token: 0x040003A7 RID: 935
		private static readonly RotationConstraint.get_rotationAtRest_InjectedDelegate get_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<RotationConstraint.get_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.RotationConstraint::get_rotationAtRest_Injected");

		// Token: 0x040003A8 RID: 936
		private static readonly RotationConstraint.set_rotationAtRest_InjectedDelegate set_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<RotationConstraint.set_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.RotationConstraint::set_rotationAtRest_Injected");

		// Token: 0x040003A9 RID: 937
		private static readonly RotationConstraint.get_rotationOffset_InjectedDelegate get_rotationOffset_InjectedDelegateField = IL2CPP.ResolveICall<RotationConstraint.get_rotationOffset_InjectedDelegate>("UnityEngine.Animations.RotationConstraint::get_rotationOffset_Injected");

		// Token: 0x040003AA RID: 938
		private static readonly RotationConstraint.set_rotationOffset_InjectedDelegate set_rotationOffset_InjectedDelegateField = IL2CPP.ResolveICall<RotationConstraint.set_rotationOffset_InjectedDelegate>("UnityEngine.Animations.RotationConstraint::set_rotationOffset_Injected");

		// Token: 0x02000243 RID: 579
		// (Invoke) Token: 0x06000928 RID: 2344
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x02000244 RID: 580
		// (Invoke) Token: 0x0600092A RID: 2346
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x02000245 RID: 581
		// (Invoke) Token: 0x0600092C RID: 2348
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x02000246 RID: 582
		// (Invoke) Token: 0x0600092E RID: 2350
		private delegate Axis get_rotationAxisDelegate(IntPtr @this);

		// Token: 0x02000247 RID: 583
		// (Invoke) Token: 0x06000930 RID: 2352
		private delegate void set_rotationAxisDelegate(IntPtr @this, Axis value);

		// Token: 0x02000248 RID: 584
		// (Invoke) Token: 0x06000932 RID: 2354
		private delegate bool get_constraintActiveDelegate(IntPtr @this);

		// Token: 0x02000249 RID: 585
		// (Invoke) Token: 0x06000934 RID: 2356
		private delegate void set_constraintActiveDelegate(IntPtr @this, bool value);

		// Token: 0x0200024A RID: 586
		// (Invoke) Token: 0x06000936 RID: 2358
		private delegate bool get_lockedDelegate(IntPtr @this);

		// Token: 0x0200024B RID: 587
		// (Invoke) Token: 0x06000938 RID: 2360
		private delegate void set_lockedDelegate(IntPtr @this, bool value);

		// Token: 0x0200024C RID: 588
		// (Invoke) Token: 0x0600093A RID: 2362
		private delegate int GetSourceCountInternalDelegate(IntPtr self);

		// Token: 0x0200024D RID: 589
		// (Invoke) Token: 0x0600093C RID: 2364
		private delegate void RemoveSourceInternalDelegate(IntPtr @this, int index);

		// Token: 0x0200024E RID: 590
		// (Invoke) Token: 0x0600093E RID: 2366
		private delegate void get_rotationAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200024F RID: 591
		// (Invoke) Token: 0x06000940 RID: 2368
		private delegate void set_rotationAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000250 RID: 592
		// (Invoke) Token: 0x06000942 RID: 2370
		private delegate void get_rotationOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000251 RID: 593
		// (Invoke) Token: 0x06000944 RID: 2372
		private delegate void set_rotationOffset_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}

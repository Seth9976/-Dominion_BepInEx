using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x0200005D RID: 93
	public sealed class ParentConstraint : Behaviour
	{
		// Token: 0x06000534 RID: 1332 RVA: 0x00005717 File Offset: 0x00003917
		public static void Internal_Create(ParentConstraint self)
		{
			ParentConstraint.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00005729 File Offset: 0x00003929
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x0000573B File Offset: 0x0000393B
		public float weight
		{
			get
			{
				return ParentConstraint.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParentConstraint.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x0000574E File Offset: 0x0000394E
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00005760 File Offset: 0x00003960
		public bool constraintActive
		{
			get
			{
				return ParentConstraint.get_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParentConstraint.set_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00005773 File Offset: 0x00003973
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x00005785 File Offset: 0x00003985
		public bool locked
		{
			get
			{
				return ParentConstraint.get_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParentConstraint.set_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x0000D668 File Offset: 0x0000B868
		public int sourceCount
		{
			get
			{
				return ParentConstraint.GetSourceCountInternal(this);
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00005798 File Offset: 0x00003998
		public static int GetSourceCountInternal(ParentConstraint self)
		{
			return ParentConstraint.GetSourceCountInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x0000D680 File Offset: 0x0000B880
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x000057AA File Offset: 0x000039AA
		public Vector3 translationAtRest
		{
			get
			{
				Vector3 vector;
				this.get_translationAtRest_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_translationAtRest_Injected(ref value);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x0000D698 File Offset: 0x0000B898
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x000057B4 File Offset: 0x000039B4
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

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x000057BE File Offset: 0x000039BE
		public Il2CppStructArray<Vector3> translationOffsets
		{
			get
			{
				IntPtr intPtr = ParentConstraint.get_translationOffsetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				ParentConstraint.set_translationOffsetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0000D6DC File Offset: 0x0000B8DC
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x000057D6 File Offset: 0x000039D6
		public Il2CppStructArray<Vector3> rotationOffsets
		{
			get
			{
				IntPtr intPtr = ParentConstraint.get_rotationOffsetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				ParentConstraint.set_rotationOffsetsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x000057EE File Offset: 0x000039EE
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00005800 File Offset: 0x00003A00
		public Axis translationAxis
		{
			get
			{
				return ParentConstraint.get_translationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParentConstraint.set_translationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00005813 File Offset: 0x00003A13
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00005825 File Offset: 0x00003A25
		public Axis rotationAxis
		{
			get
			{
				return ParentConstraint.get_rotationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParentConstraint.set_rotationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0000D708 File Offset: 0x0000B908
		public Vector3 GetTranslationOffset(int index)
		{
			this.ValidateSourceIndex(index);
			return this.GetTranslationOffsetInternal(index);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00005838 File Offset: 0x00003A38
		public void SetTranslationOffset(int index, Vector3 value)
		{
			this.ValidateSourceIndex(index);
			this.SetTranslationOffsetInternal(index, value);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0000D72C File Offset: 0x0000B92C
		public Vector3 GetTranslationOffsetInternal(int index)
		{
			Vector3 vector;
			this.GetTranslationOffsetInternal_Injected(index, out vector);
			return vector;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0000584C File Offset: 0x00003A4C
		public void SetTranslationOffsetInternal(int index, Vector3 value)
		{
			this.SetTranslationOffsetInternal_Injected(index, ref value);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0000D744 File Offset: 0x0000B944
		public Vector3 GetRotationOffset(int index)
		{
			this.ValidateSourceIndex(index);
			return this.GetRotationOffsetInternal(index);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00005857 File Offset: 0x00003A57
		public void SetRotationOffset(int index, Vector3 value)
		{
			this.ValidateSourceIndex(index);
			this.SetRotationOffsetInternal(index, value);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0000D768 File Offset: 0x0000B968
		public Vector3 GetRotationOffsetInternal(int index)
		{
			Vector3 vector;
			this.GetRotationOffsetInternal_Injected(index, out vector);
			return vector;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0000586B File Offset: 0x00003A6B
		public void SetRotationOffsetInternal(int index, Vector3 value)
		{
			this.SetRotationOffsetInternal_Injected(index, ref value);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0000D780 File Offset: 0x0000B980
		public void ValidateSourceIndex(int index)
		{
			bool flag = this.sourceCount == 0;
			if (flag)
			{
				throw new InvalidOperationException("The ParentConstraint component has no sources.");
			}
			bool flag2 = index < 0 || index >= this.sourceCount;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Constraint source index {0} is out of bounds (0-{1}).", index, this.sourceCount));
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00005876 File Offset: 0x00003A76
		public void RemoveSource(int index)
		{
			this.ValidateSourceIndex(index);
			this.RemoveSourceInternal(index);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00005889 File Offset: 0x00003A89
		public void RemoveSourceInternal(int index)
		{
			ParentConstraint.RemoveSourceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0000589C File Offset: 0x00003A9C
		public void get_translationAtRest_Injected(out Vector3 ret)
		{
			ParentConstraint.get_translationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x000058AF File Offset: 0x00003AAF
		public void set_translationAtRest_Injected(ref Vector3 value)
		{
			ParentConstraint.set_translationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x000058C2 File Offset: 0x00003AC2
		public void get_rotationAtRest_Injected(out Vector3 ret)
		{
			ParentConstraint.get_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x000058D5 File Offset: 0x00003AD5
		public void set_rotationAtRest_Injected(ref Vector3 value)
		{
			ParentConstraint.set_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x000058E8 File Offset: 0x00003AE8
		public void GetTranslationOffsetInternal_Injected(int index, out Vector3 ret)
		{
			ParentConstraint.GetTranslationOffsetInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out ret);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x000058FC File Offset: 0x00003AFC
		public void SetTranslationOffsetInternal_Injected(int index, ref Vector3 value)
		{
			ParentConstraint.SetTranslationOffsetInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, ref value);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00005910 File Offset: 0x00003B10
		public void GetRotationOffsetInternal_Injected(int index, out Vector3 ret)
		{
			ParentConstraint.GetRotationOffsetInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, out ret);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00005924 File Offset: 0x00003B24
		public void SetRotationOffsetInternal_Injected(int index, ref Vector3 value)
		{
			ParentConstraint.SetRotationOffsetInternal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, ref value);
		}

		// Token: 0x040003CD RID: 973
		private static readonly ParentConstraint.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<ParentConstraint.Internal_CreateDelegate>("UnityEngine.Animations.ParentConstraint::Internal_Create");

		// Token: 0x040003CE RID: 974
		private static readonly ParentConstraint.get_weightDelegate get_weightDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_weightDelegate>("UnityEngine.Animations.ParentConstraint::get_weight");

		// Token: 0x040003CF RID: 975
		private static readonly ParentConstraint.set_weightDelegate set_weightDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_weightDelegate>("UnityEngine.Animations.ParentConstraint::set_weight");

		// Token: 0x040003D0 RID: 976
		private static readonly ParentConstraint.get_constraintActiveDelegate get_constraintActiveDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_constraintActiveDelegate>("UnityEngine.Animations.ParentConstraint::get_constraintActive");

		// Token: 0x040003D1 RID: 977
		private static readonly ParentConstraint.set_constraintActiveDelegate set_constraintActiveDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_constraintActiveDelegate>("UnityEngine.Animations.ParentConstraint::set_constraintActive");

		// Token: 0x040003D2 RID: 978
		private static readonly ParentConstraint.get_lockedDelegate get_lockedDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_lockedDelegate>("UnityEngine.Animations.ParentConstraint::get_locked");

		// Token: 0x040003D3 RID: 979
		private static readonly ParentConstraint.set_lockedDelegate set_lockedDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_lockedDelegate>("UnityEngine.Animations.ParentConstraint::set_locked");

		// Token: 0x040003D4 RID: 980
		private static readonly ParentConstraint.GetSourceCountInternalDelegate GetSourceCountInternalDelegateField = IL2CPP.ResolveICall<ParentConstraint.GetSourceCountInternalDelegate>("UnityEngine.Animations.ParentConstraint::GetSourceCountInternal");

		// Token: 0x040003D5 RID: 981
		private static readonly ParentConstraint.get_translationOffsetsDelegate get_translationOffsetsDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_translationOffsetsDelegate>("UnityEngine.Animations.ParentConstraint::get_translationOffsets");

		// Token: 0x040003D6 RID: 982
		private static readonly ParentConstraint.set_translationOffsetsDelegate set_translationOffsetsDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_translationOffsetsDelegate>("UnityEngine.Animations.ParentConstraint::set_translationOffsets");

		// Token: 0x040003D7 RID: 983
		private static readonly ParentConstraint.get_rotationOffsetsDelegate get_rotationOffsetsDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_rotationOffsetsDelegate>("UnityEngine.Animations.ParentConstraint::get_rotationOffsets");

		// Token: 0x040003D8 RID: 984
		private static readonly ParentConstraint.set_rotationOffsetsDelegate set_rotationOffsetsDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_rotationOffsetsDelegate>("UnityEngine.Animations.ParentConstraint::set_rotationOffsets");

		// Token: 0x040003D9 RID: 985
		private static readonly ParentConstraint.get_translationAxisDelegate get_translationAxisDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_translationAxisDelegate>("UnityEngine.Animations.ParentConstraint::get_translationAxis");

		// Token: 0x040003DA RID: 986
		private static readonly ParentConstraint.set_translationAxisDelegate set_translationAxisDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_translationAxisDelegate>("UnityEngine.Animations.ParentConstraint::set_translationAxis");

		// Token: 0x040003DB RID: 987
		private static readonly ParentConstraint.get_rotationAxisDelegate get_rotationAxisDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_rotationAxisDelegate>("UnityEngine.Animations.ParentConstraint::get_rotationAxis");

		// Token: 0x040003DC RID: 988
		private static readonly ParentConstraint.set_rotationAxisDelegate set_rotationAxisDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_rotationAxisDelegate>("UnityEngine.Animations.ParentConstraint::set_rotationAxis");

		// Token: 0x040003DD RID: 989
		private static readonly ParentConstraint.RemoveSourceInternalDelegate RemoveSourceInternalDelegateField = IL2CPP.ResolveICall<ParentConstraint.RemoveSourceInternalDelegate>("UnityEngine.Animations.ParentConstraint::RemoveSourceInternal");

		// Token: 0x040003DE RID: 990
		private static readonly ParentConstraint.get_translationAtRest_InjectedDelegate get_translationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_translationAtRest_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::get_translationAtRest_Injected");

		// Token: 0x040003DF RID: 991
		private static readonly ParentConstraint.set_translationAtRest_InjectedDelegate set_translationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_translationAtRest_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::set_translationAtRest_Injected");

		// Token: 0x040003E0 RID: 992
		private static readonly ParentConstraint.get_rotationAtRest_InjectedDelegate get_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.get_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::get_rotationAtRest_Injected");

		// Token: 0x040003E1 RID: 993
		private static readonly ParentConstraint.set_rotationAtRest_InjectedDelegate set_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.set_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::set_rotationAtRest_Injected");

		// Token: 0x040003E2 RID: 994
		private static readonly ParentConstraint.GetTranslationOffsetInternal_InjectedDelegate GetTranslationOffsetInternal_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.GetTranslationOffsetInternal_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::GetTranslationOffsetInternal_Injected");

		// Token: 0x040003E3 RID: 995
		private static readonly ParentConstraint.SetTranslationOffsetInternal_InjectedDelegate SetTranslationOffsetInternal_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.SetTranslationOffsetInternal_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::SetTranslationOffsetInternal_Injected");

		// Token: 0x040003E4 RID: 996
		private static readonly ParentConstraint.GetRotationOffsetInternal_InjectedDelegate GetRotationOffsetInternal_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.GetRotationOffsetInternal_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::GetRotationOffsetInternal_Injected");

		// Token: 0x040003E5 RID: 997
		private static readonly ParentConstraint.SetRotationOffsetInternal_InjectedDelegate SetRotationOffsetInternal_InjectedDelegateField = IL2CPP.ResolveICall<ParentConstraint.SetRotationOffsetInternal_InjectedDelegate>("UnityEngine.Animations.ParentConstraint::SetRotationOffsetInternal_Injected");

		// Token: 0x02000274 RID: 628
		// (Invoke) Token: 0x0600098A RID: 2442
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x02000275 RID: 629
		// (Invoke) Token: 0x0600098C RID: 2444
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x02000276 RID: 630
		// (Invoke) Token: 0x0600098E RID: 2446
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x02000277 RID: 631
		// (Invoke) Token: 0x06000990 RID: 2448
		private delegate bool get_constraintActiveDelegate(IntPtr @this);

		// Token: 0x02000278 RID: 632
		// (Invoke) Token: 0x06000992 RID: 2450
		private delegate void set_constraintActiveDelegate(IntPtr @this, bool value);

		// Token: 0x02000279 RID: 633
		// (Invoke) Token: 0x06000994 RID: 2452
		private delegate bool get_lockedDelegate(IntPtr @this);

		// Token: 0x0200027A RID: 634
		// (Invoke) Token: 0x06000996 RID: 2454
		private delegate void set_lockedDelegate(IntPtr @this, bool value);

		// Token: 0x0200027B RID: 635
		// (Invoke) Token: 0x06000998 RID: 2456
		private delegate int GetSourceCountInternalDelegate(IntPtr self);

		// Token: 0x0200027C RID: 636
		// (Invoke) Token: 0x0600099A RID: 2458
		private delegate IntPtr get_translationOffsetsDelegate(IntPtr @this);

		// Token: 0x0200027D RID: 637
		// (Invoke) Token: 0x0600099C RID: 2460
		private delegate void set_translationOffsetsDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200027E RID: 638
		// (Invoke) Token: 0x0600099E RID: 2462
		private delegate IntPtr get_rotationOffsetsDelegate(IntPtr @this);

		// Token: 0x0200027F RID: 639
		// (Invoke) Token: 0x060009A0 RID: 2464
		private delegate void set_rotationOffsetsDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000280 RID: 640
		// (Invoke) Token: 0x060009A2 RID: 2466
		private delegate Axis get_translationAxisDelegate(IntPtr @this);

		// Token: 0x02000281 RID: 641
		// (Invoke) Token: 0x060009A4 RID: 2468
		private delegate void set_translationAxisDelegate(IntPtr @this, Axis value);

		// Token: 0x02000282 RID: 642
		// (Invoke) Token: 0x060009A6 RID: 2470
		private delegate Axis get_rotationAxisDelegate(IntPtr @this);

		// Token: 0x02000283 RID: 643
		// (Invoke) Token: 0x060009A8 RID: 2472
		private delegate void set_rotationAxisDelegate(IntPtr @this, Axis value);

		// Token: 0x02000284 RID: 644
		// (Invoke) Token: 0x060009AA RID: 2474
		private delegate void RemoveSourceInternalDelegate(IntPtr @this, int index);

		// Token: 0x02000285 RID: 645
		// (Invoke) Token: 0x060009AC RID: 2476
		private delegate void get_translationAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000286 RID: 646
		// (Invoke) Token: 0x060009AE RID: 2478
		private delegate void set_translationAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000287 RID: 647
		// (Invoke) Token: 0x060009B0 RID: 2480
		private delegate void get_rotationAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000288 RID: 648
		// (Invoke) Token: 0x060009B2 RID: 2482
		private delegate void set_rotationAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000289 RID: 649
		// (Invoke) Token: 0x060009B4 RID: 2484
		private delegate void GetTranslationOffsetInternal_InjectedDelegate(IntPtr @this, int index, [Out] IntPtr ret);

		// Token: 0x0200028A RID: 650
		// (Invoke) Token: 0x060009B6 RID: 2486
		private delegate void SetTranslationOffsetInternal_InjectedDelegate(IntPtr @this, int index, IntPtr value);

		// Token: 0x0200028B RID: 651
		// (Invoke) Token: 0x060009B8 RID: 2488
		private delegate void GetRotationOffsetInternal_InjectedDelegate(IntPtr @this, int index, [Out] IntPtr ret);

		// Token: 0x0200028C RID: 652
		// (Invoke) Token: 0x060009BA RID: 2490
		private delegate void SetRotationOffsetInternal_InjectedDelegate(IntPtr @this, int index, IntPtr value);
	}
}

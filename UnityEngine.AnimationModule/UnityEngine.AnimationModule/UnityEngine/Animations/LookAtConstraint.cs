using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x0200005C RID: 92
	public sealed class LookAtConstraint : Behaviour
	{
		// Token: 0x06000519 RID: 1305 RVA: 0x0000559C File Offset: 0x0000379C
		public static void Internal_Create(LookAtConstraint self)
		{
			LookAtConstraint.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x000055AE File Offset: 0x000037AE
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x000055C0 File Offset: 0x000037C0
		public float weight
		{
			get
			{
				return LookAtConstraint.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LookAtConstraint.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x000055D3 File Offset: 0x000037D3
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x000055E5 File Offset: 0x000037E5
		public float roll
		{
			get
			{
				return LookAtConstraint.get_rollDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LookAtConstraint.set_rollDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x000055F8 File Offset: 0x000037F8
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x0000560A File Offset: 0x0000380A
		public bool constraintActive
		{
			get
			{
				return LookAtConstraint.get_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LookAtConstraint.set_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x0000561D File Offset: 0x0000381D
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x0000562F File Offset: 0x0000382F
		public bool locked
		{
			get
			{
				return LookAtConstraint.get_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LookAtConstraint.set_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x0000D408 File Offset: 0x0000B608
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00005642 File Offset: 0x00003842
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

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x0000D420 File Offset: 0x0000B620
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x0000564C File Offset: 0x0000384C
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

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x0000D438 File Offset: 0x0000B638
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00005656 File Offset: 0x00003856
		public Transform worldUpObject
		{
			get
			{
				IntPtr intPtr = LookAtConstraint.get_worldUpObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				LookAtConstraint.set_worldUpObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0000566E File Offset: 0x0000386E
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00005680 File Offset: 0x00003880
		public bool useUpObject
		{
			get
			{
				return LookAtConstraint.get_useUpObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				LookAtConstraint.set_useUpObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0000D464 File Offset: 0x0000B664
		public int sourceCount
		{
			get
			{
				return LookAtConstraint.GetSourceCountInternal(this);
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00005693 File Offset: 0x00003893
		public static int GetSourceCountInternal(LookAtConstraint self)
		{
			return LookAtConstraint.GetSourceCountInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x000056A5 File Offset: 0x000038A5
		public void RemoveSource(int index)
		{
			this.ValidateSourceIndex(index);
			this.RemoveSourceInternal(index);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x000056B8 File Offset: 0x000038B8
		public void RemoveSourceInternal(int index)
		{
			LookAtConstraint.RemoveSourceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0000D47C File Offset: 0x0000B67C
		public void ValidateSourceIndex(int index)
		{
			bool flag = this.sourceCount == 0;
			if (flag)
			{
				throw new InvalidOperationException("The LookAtConstraint component has no sources.");
			}
			bool flag2 = index < 0 || index >= this.sourceCount;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Constraint source index {0} is out of bounds (0-{1}).", index, this.sourceCount));
			}
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x000056CB File Offset: 0x000038CB
		public void get_rotationAtRest_Injected(out Vector3 ret)
		{
			LookAtConstraint.get_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x000056DE File Offset: 0x000038DE
		public void set_rotationAtRest_Injected(ref Vector3 value)
		{
			LookAtConstraint.set_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000056F1 File Offset: 0x000038F1
		public void get_rotationOffset_Injected(out Vector3 ret)
		{
			LookAtConstraint.get_rotationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00005704 File Offset: 0x00003904
		public void set_rotationOffset_Injected(ref Vector3 value)
		{
			LookAtConstraint.set_rotationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040003BA RID: 954
		private static readonly LookAtConstraint.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<LookAtConstraint.Internal_CreateDelegate>("UnityEngine.Animations.LookAtConstraint::Internal_Create");

		// Token: 0x040003BB RID: 955
		private static readonly LookAtConstraint.get_weightDelegate get_weightDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_weightDelegate>("UnityEngine.Animations.LookAtConstraint::get_weight");

		// Token: 0x040003BC RID: 956
		private static readonly LookAtConstraint.set_weightDelegate set_weightDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_weightDelegate>("UnityEngine.Animations.LookAtConstraint::set_weight");

		// Token: 0x040003BD RID: 957
		private static readonly LookAtConstraint.get_rollDelegate get_rollDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_rollDelegate>("UnityEngine.Animations.LookAtConstraint::get_roll");

		// Token: 0x040003BE RID: 958
		private static readonly LookAtConstraint.set_rollDelegate set_rollDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_rollDelegate>("UnityEngine.Animations.LookAtConstraint::set_roll");

		// Token: 0x040003BF RID: 959
		private static readonly LookAtConstraint.get_constraintActiveDelegate get_constraintActiveDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_constraintActiveDelegate>("UnityEngine.Animations.LookAtConstraint::get_constraintActive");

		// Token: 0x040003C0 RID: 960
		private static readonly LookAtConstraint.set_constraintActiveDelegate set_constraintActiveDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_constraintActiveDelegate>("UnityEngine.Animations.LookAtConstraint::set_constraintActive");

		// Token: 0x040003C1 RID: 961
		private static readonly LookAtConstraint.get_lockedDelegate get_lockedDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_lockedDelegate>("UnityEngine.Animations.LookAtConstraint::get_locked");

		// Token: 0x040003C2 RID: 962
		private static readonly LookAtConstraint.set_lockedDelegate set_lockedDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_lockedDelegate>("UnityEngine.Animations.LookAtConstraint::set_locked");

		// Token: 0x040003C3 RID: 963
		private static readonly LookAtConstraint.get_worldUpObjectDelegate get_worldUpObjectDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_worldUpObjectDelegate>("UnityEngine.Animations.LookAtConstraint::get_worldUpObject");

		// Token: 0x040003C4 RID: 964
		private static readonly LookAtConstraint.set_worldUpObjectDelegate set_worldUpObjectDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_worldUpObjectDelegate>("UnityEngine.Animations.LookAtConstraint::set_worldUpObject");

		// Token: 0x040003C5 RID: 965
		private static readonly LookAtConstraint.get_useUpObjectDelegate get_useUpObjectDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_useUpObjectDelegate>("UnityEngine.Animations.LookAtConstraint::get_useUpObject");

		// Token: 0x040003C6 RID: 966
		private static readonly LookAtConstraint.set_useUpObjectDelegate set_useUpObjectDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_useUpObjectDelegate>("UnityEngine.Animations.LookAtConstraint::set_useUpObject");

		// Token: 0x040003C7 RID: 967
		private static readonly LookAtConstraint.GetSourceCountInternalDelegate GetSourceCountInternalDelegateField = IL2CPP.ResolveICall<LookAtConstraint.GetSourceCountInternalDelegate>("UnityEngine.Animations.LookAtConstraint::GetSourceCountInternal");

		// Token: 0x040003C8 RID: 968
		private static readonly LookAtConstraint.RemoveSourceInternalDelegate RemoveSourceInternalDelegateField = IL2CPP.ResolveICall<LookAtConstraint.RemoveSourceInternalDelegate>("UnityEngine.Animations.LookAtConstraint::RemoveSourceInternal");

		// Token: 0x040003C9 RID: 969
		private static readonly LookAtConstraint.get_rotationAtRest_InjectedDelegate get_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.LookAtConstraint::get_rotationAtRest_Injected");

		// Token: 0x040003CA RID: 970
		private static readonly LookAtConstraint.set_rotationAtRest_InjectedDelegate set_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.LookAtConstraint::set_rotationAtRest_Injected");

		// Token: 0x040003CB RID: 971
		private static readonly LookAtConstraint.get_rotationOffset_InjectedDelegate get_rotationOffset_InjectedDelegateField = IL2CPP.ResolveICall<LookAtConstraint.get_rotationOffset_InjectedDelegate>("UnityEngine.Animations.LookAtConstraint::get_rotationOffset_Injected");

		// Token: 0x040003CC RID: 972
		private static readonly LookAtConstraint.set_rotationOffset_InjectedDelegate set_rotationOffset_InjectedDelegateField = IL2CPP.ResolveICall<LookAtConstraint.set_rotationOffset_InjectedDelegate>("UnityEngine.Animations.LookAtConstraint::set_rotationOffset_Injected");

		// Token: 0x02000261 RID: 609
		// (Invoke) Token: 0x06000964 RID: 2404
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x02000262 RID: 610
		// (Invoke) Token: 0x06000966 RID: 2406
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x02000263 RID: 611
		// (Invoke) Token: 0x06000968 RID: 2408
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x02000264 RID: 612
		// (Invoke) Token: 0x0600096A RID: 2410
		private delegate float get_rollDelegate(IntPtr @this);

		// Token: 0x02000265 RID: 613
		// (Invoke) Token: 0x0600096C RID: 2412
		private delegate void set_rollDelegate(IntPtr @this, float value);

		// Token: 0x02000266 RID: 614
		// (Invoke) Token: 0x0600096E RID: 2414
		private delegate bool get_constraintActiveDelegate(IntPtr @this);

		// Token: 0x02000267 RID: 615
		// (Invoke) Token: 0x06000970 RID: 2416
		private delegate void set_constraintActiveDelegate(IntPtr @this, bool value);

		// Token: 0x02000268 RID: 616
		// (Invoke) Token: 0x06000972 RID: 2418
		private delegate bool get_lockedDelegate(IntPtr @this);

		// Token: 0x02000269 RID: 617
		// (Invoke) Token: 0x06000974 RID: 2420
		private delegate void set_lockedDelegate(IntPtr @this, bool value);

		// Token: 0x0200026A RID: 618
		// (Invoke) Token: 0x06000976 RID: 2422
		private delegate IntPtr get_worldUpObjectDelegate(IntPtr @this);

		// Token: 0x0200026B RID: 619
		// (Invoke) Token: 0x06000978 RID: 2424
		private delegate void set_worldUpObjectDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200026C RID: 620
		// (Invoke) Token: 0x0600097A RID: 2426
		private delegate bool get_useUpObjectDelegate(IntPtr @this);

		// Token: 0x0200026D RID: 621
		// (Invoke) Token: 0x0600097C RID: 2428
		private delegate void set_useUpObjectDelegate(IntPtr @this, bool value);

		// Token: 0x0200026E RID: 622
		// (Invoke) Token: 0x0600097E RID: 2430
		private delegate int GetSourceCountInternalDelegate(IntPtr self);

		// Token: 0x0200026F RID: 623
		// (Invoke) Token: 0x06000980 RID: 2432
		private delegate void RemoveSourceInternalDelegate(IntPtr @this, int index);

		// Token: 0x02000270 RID: 624
		// (Invoke) Token: 0x06000982 RID: 2434
		private delegate void get_rotationAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000271 RID: 625
		// (Invoke) Token: 0x06000984 RID: 2436
		private delegate void set_rotationAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000272 RID: 626
		// (Invoke) Token: 0x06000986 RID: 2438
		private delegate void get_rotationOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000273 RID: 627
		// (Invoke) Token: 0x06000988 RID: 2440
		private delegate void set_rotationOffset_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}

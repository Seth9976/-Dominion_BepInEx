using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x02000059 RID: 89
	public sealed class PositionConstraint : Behaviour
	{
		// Token: 0x060004D4 RID: 1236 RVA: 0x000051E2 File Offset: 0x000033E2
		public static void Internal_Create(PositionConstraint self)
		{
			PositionConstraint.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x000051F4 File Offset: 0x000033F4
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00005206 File Offset: 0x00003406
		public float weight
		{
			get
			{
				return PositionConstraint.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PositionConstraint.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x0000CEEC File Offset: 0x0000B0EC
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00005219 File Offset: 0x00003419
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

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x0000CF04 File Offset: 0x0000B104
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00005223 File Offset: 0x00003423
		public Vector3 translationOffset
		{
			get
			{
				Vector3 vector;
				this.get_translationOffset_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_translationOffset_Injected(ref value);
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x0000522D File Offset: 0x0000342D
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x0000523F File Offset: 0x0000343F
		public Axis translationAxis
		{
			get
			{
				return PositionConstraint.get_translationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PositionConstraint.set_translationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00005252 File Offset: 0x00003452
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00005264 File Offset: 0x00003464
		public bool constraintActive
		{
			get
			{
				return PositionConstraint.get_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PositionConstraint.set_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00005277 File Offset: 0x00003477
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00005289 File Offset: 0x00003489
		public bool locked
		{
			get
			{
				return PositionConstraint.get_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PositionConstraint.set_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x0000CF1C File Offset: 0x0000B11C
		public int sourceCount
		{
			get
			{
				return PositionConstraint.GetSourceCountInternal(this);
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0000529C File Offset: 0x0000349C
		public static int GetSourceCountInternal(PositionConstraint self)
		{
			return PositionConstraint.GetSourceCountInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x000052AE File Offset: 0x000034AE
		public void RemoveSource(int index)
		{
			this.ValidateSourceIndex(index);
			this.RemoveSourceInternal(index);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000052C1 File Offset: 0x000034C1
		public void RemoveSourceInternal(int index)
		{
			PositionConstraint.RemoveSourceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0000CF34 File Offset: 0x0000B134
		public void ValidateSourceIndex(int index)
		{
			bool flag = this.sourceCount == 0;
			if (flag)
			{
				throw new InvalidOperationException("The PositionConstraint component has no sources.");
			}
			bool flag2 = index < 0 || index >= this.sourceCount;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Constraint source index {0} is out of bounds (0-{1}).", index, this.sourceCount));
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000052D4 File Offset: 0x000034D4
		public void get_translationAtRest_Injected(out Vector3 ret)
		{
			PositionConstraint.get_translationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000052E7 File Offset: 0x000034E7
		public void set_translationAtRest_Injected(ref Vector3 value)
		{
			PositionConstraint.set_translationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x000052FA File Offset: 0x000034FA
		public void get_translationOffset_Injected(out Vector3 ret)
		{
			PositionConstraint.get_translationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0000530D File Offset: 0x0000350D
		public void set_translationOffset_Injected(ref Vector3 value)
		{
			PositionConstraint.set_translationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0400038D RID: 909
		private static readonly PositionConstraint.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<PositionConstraint.Internal_CreateDelegate>("UnityEngine.Animations.PositionConstraint::Internal_Create");

		// Token: 0x0400038E RID: 910
		private static readonly PositionConstraint.get_weightDelegate get_weightDelegateField = IL2CPP.ResolveICall<PositionConstraint.get_weightDelegate>("UnityEngine.Animations.PositionConstraint::get_weight");

		// Token: 0x0400038F RID: 911
		private static readonly PositionConstraint.set_weightDelegate set_weightDelegateField = IL2CPP.ResolveICall<PositionConstraint.set_weightDelegate>("UnityEngine.Animations.PositionConstraint::set_weight");

		// Token: 0x04000390 RID: 912
		private static readonly PositionConstraint.get_translationAxisDelegate get_translationAxisDelegateField = IL2CPP.ResolveICall<PositionConstraint.get_translationAxisDelegate>("UnityEngine.Animations.PositionConstraint::get_translationAxis");

		// Token: 0x04000391 RID: 913
		private static readonly PositionConstraint.set_translationAxisDelegate set_translationAxisDelegateField = IL2CPP.ResolveICall<PositionConstraint.set_translationAxisDelegate>("UnityEngine.Animations.PositionConstraint::set_translationAxis");

		// Token: 0x04000392 RID: 914
		private static readonly PositionConstraint.get_constraintActiveDelegate get_constraintActiveDelegateField = IL2CPP.ResolveICall<PositionConstraint.get_constraintActiveDelegate>("UnityEngine.Animations.PositionConstraint::get_constraintActive");

		// Token: 0x04000393 RID: 915
		private static readonly PositionConstraint.set_constraintActiveDelegate set_constraintActiveDelegateField = IL2CPP.ResolveICall<PositionConstraint.set_constraintActiveDelegate>("UnityEngine.Animations.PositionConstraint::set_constraintActive");

		// Token: 0x04000394 RID: 916
		private static readonly PositionConstraint.get_lockedDelegate get_lockedDelegateField = IL2CPP.ResolveICall<PositionConstraint.get_lockedDelegate>("UnityEngine.Animations.PositionConstraint::get_locked");

		// Token: 0x04000395 RID: 917
		private static readonly PositionConstraint.set_lockedDelegate set_lockedDelegateField = IL2CPP.ResolveICall<PositionConstraint.set_lockedDelegate>("UnityEngine.Animations.PositionConstraint::set_locked");

		// Token: 0x04000396 RID: 918
		private static readonly PositionConstraint.GetSourceCountInternalDelegate GetSourceCountInternalDelegateField = IL2CPP.ResolveICall<PositionConstraint.GetSourceCountInternalDelegate>("UnityEngine.Animations.PositionConstraint::GetSourceCountInternal");

		// Token: 0x04000397 RID: 919
		private static readonly PositionConstraint.RemoveSourceInternalDelegate RemoveSourceInternalDelegateField = IL2CPP.ResolveICall<PositionConstraint.RemoveSourceInternalDelegate>("UnityEngine.Animations.PositionConstraint::RemoveSourceInternal");

		// Token: 0x04000398 RID: 920
		private static readonly PositionConstraint.get_translationAtRest_InjectedDelegate get_translationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<PositionConstraint.get_translationAtRest_InjectedDelegate>("UnityEngine.Animations.PositionConstraint::get_translationAtRest_Injected");

		// Token: 0x04000399 RID: 921
		private static readonly PositionConstraint.set_translationAtRest_InjectedDelegate set_translationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<PositionConstraint.set_translationAtRest_InjectedDelegate>("UnityEngine.Animations.PositionConstraint::set_translationAtRest_Injected");

		// Token: 0x0400039A RID: 922
		private static readonly PositionConstraint.get_translationOffset_InjectedDelegate get_translationOffset_InjectedDelegateField = IL2CPP.ResolveICall<PositionConstraint.get_translationOffset_InjectedDelegate>("UnityEngine.Animations.PositionConstraint::get_translationOffset_Injected");

		// Token: 0x0400039B RID: 923
		private static readonly PositionConstraint.set_translationOffset_InjectedDelegate set_translationOffset_InjectedDelegateField = IL2CPP.ResolveICall<PositionConstraint.set_translationOffset_InjectedDelegate>("UnityEngine.Animations.PositionConstraint::set_translationOffset_Injected");

		// Token: 0x02000234 RID: 564
		// (Invoke) Token: 0x0600090A RID: 2314
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x02000235 RID: 565
		// (Invoke) Token: 0x0600090C RID: 2316
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x02000236 RID: 566
		// (Invoke) Token: 0x0600090E RID: 2318
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x02000237 RID: 567
		// (Invoke) Token: 0x06000910 RID: 2320
		private delegate Axis get_translationAxisDelegate(IntPtr @this);

		// Token: 0x02000238 RID: 568
		// (Invoke) Token: 0x06000912 RID: 2322
		private delegate void set_translationAxisDelegate(IntPtr @this, Axis value);

		// Token: 0x02000239 RID: 569
		// (Invoke) Token: 0x06000914 RID: 2324
		private delegate bool get_constraintActiveDelegate(IntPtr @this);

		// Token: 0x0200023A RID: 570
		// (Invoke) Token: 0x06000916 RID: 2326
		private delegate void set_constraintActiveDelegate(IntPtr @this, bool value);

		// Token: 0x0200023B RID: 571
		// (Invoke) Token: 0x06000918 RID: 2328
		private delegate bool get_lockedDelegate(IntPtr @this);

		// Token: 0x0200023C RID: 572
		// (Invoke) Token: 0x0600091A RID: 2330
		private delegate void set_lockedDelegate(IntPtr @this, bool value);

		// Token: 0x0200023D RID: 573
		// (Invoke) Token: 0x0600091C RID: 2332
		private delegate int GetSourceCountInternalDelegate(IntPtr self);

		// Token: 0x0200023E RID: 574
		// (Invoke) Token: 0x0600091E RID: 2334
		private delegate void RemoveSourceInternalDelegate(IntPtr @this, int index);

		// Token: 0x0200023F RID: 575
		// (Invoke) Token: 0x06000920 RID: 2336
		private delegate void get_translationAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000240 RID: 576
		// (Invoke) Token: 0x06000922 RID: 2338
		private delegate void set_translationAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000241 RID: 577
		// (Invoke) Token: 0x06000924 RID: 2340
		private delegate void get_translationOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000242 RID: 578
		// (Invoke) Token: 0x06000926 RID: 2342
		private delegate void set_translationOffset_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x0200004D RID: 77
	public sealed class AimConstraint : Behaviour
	{
		// Token: 0x06000488 RID: 1160 RVA: 0x00004DAD File Offset: 0x00002FAD
		public static void Internal_Create(AimConstraint self)
		{
			AimConstraint.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00004DBF File Offset: 0x00002FBF
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00004DD1 File Offset: 0x00002FD1
		public float weight
		{
			get
			{
				return AimConstraint.get_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AimConstraint.set_weightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00004DE4 File Offset: 0x00002FE4
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00004DF6 File Offset: 0x00002FF6
		public bool constraintActive
		{
			get
			{
				return AimConstraint.get_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AimConstraint.set_constraintActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00004E09 File Offset: 0x00003009
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x00004E1B File Offset: 0x0000301B
		public bool locked
		{
			get
			{
				return AimConstraint.get_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AimConstraint.set_lockedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x0000CB50 File Offset: 0x0000AD50
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00004E2E File Offset: 0x0000302E
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

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0000CB68 File Offset: 0x0000AD68
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00004E38 File Offset: 0x00003038
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

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00004E42 File Offset: 0x00003042
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00004E54 File Offset: 0x00003054
		public Axis rotationAxis
		{
			get
			{
				return AimConstraint.get_rotationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AimConstraint.set_rotationAxisDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0000CB80 File Offset: 0x0000AD80
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00004E67 File Offset: 0x00003067
		public Vector3 aimVector
		{
			get
			{
				Vector3 vector;
				this.get_aimVector_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_aimVector_Injected(ref value);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x0000CB98 File Offset: 0x0000AD98
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00004E71 File Offset: 0x00003071
		public Vector3 upVector
		{
			get
			{
				Vector3 vector;
				this.get_upVector_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_upVector_Injected(ref value);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0000CBB0 File Offset: 0x0000ADB0
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00004E7B File Offset: 0x0000307B
		public Vector3 worldUpVector
		{
			get
			{
				Vector3 vector;
				this.get_worldUpVector_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_worldUpVector_Injected(ref value);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x0000CBC8 File Offset: 0x0000ADC8
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00004E85 File Offset: 0x00003085
		public Transform worldUpObject
		{
			get
			{
				IntPtr intPtr = AimConstraint.get_worldUpObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				AimConstraint.set_worldUpObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00004E9D File Offset: 0x0000309D
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x00004EAF File Offset: 0x000030AF
		public AimConstraint.WorldUpType worldUpType
		{
			get
			{
				return AimConstraint.get_worldUpTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AimConstraint.set_worldUpTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0000CBF4 File Offset: 0x0000ADF4
		public int sourceCount
		{
			get
			{
				return AimConstraint.GetSourceCountInternal(this);
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00004EC2 File Offset: 0x000030C2
		public static int GetSourceCountInternal(AimConstraint self)
		{
			return AimConstraint.GetSourceCountInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00004ED4 File Offset: 0x000030D4
		public void RemoveSource(int index)
		{
			this.ValidateSourceIndex(index);
			this.RemoveSourceInternal(index);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00004EE7 File Offset: 0x000030E7
		public void RemoveSourceInternal(int index)
		{
			AimConstraint.RemoveSourceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0000CC0C File Offset: 0x0000AE0C
		public void ValidateSourceIndex(int index)
		{
			bool flag = this.sourceCount == 0;
			if (flag)
			{
				throw new InvalidOperationException("The AimConstraint component has no sources.");
			}
			bool flag2 = index < 0 || index >= this.sourceCount;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException("index", String.Format("Constraint source index {0} is out of bounds (0-{1}).", index, this.sourceCount));
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00004EFA File Offset: 0x000030FA
		public void get_rotationAtRest_Injected(out Vector3 ret)
		{
			AimConstraint.get_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00004F0D File Offset: 0x0000310D
		public void set_rotationAtRest_Injected(ref Vector3 value)
		{
			AimConstraint.set_rotationAtRest_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00004F20 File Offset: 0x00003120
		public void get_rotationOffset_Injected(out Vector3 ret)
		{
			AimConstraint.get_rotationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00004F33 File Offset: 0x00003133
		public void set_rotationOffset_Injected(ref Vector3 value)
		{
			AimConstraint.set_rotationOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00004F46 File Offset: 0x00003146
		public void get_aimVector_Injected(out Vector3 ret)
		{
			AimConstraint.get_aimVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00004F59 File Offset: 0x00003159
		public void set_aimVector_Injected(ref Vector3 value)
		{
			AimConstraint.set_aimVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00004F6C File Offset: 0x0000316C
		public void get_upVector_Injected(out Vector3 ret)
		{
			AimConstraint.get_upVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00004F7F File Offset: 0x0000317F
		public void set_upVector_Injected(ref Vector3 value)
		{
			AimConstraint.set_upVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00004F92 File Offset: 0x00003192
		public void get_worldUpVector_Injected(out Vector3 ret)
		{
			AimConstraint.get_worldUpVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00004FA5 File Offset: 0x000031A5
		public void set_worldUpVector_Injected(ref Vector3 value)
		{
			AimConstraint.set_worldUpVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0400034C RID: 844
		private static readonly AimConstraint.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<AimConstraint.Internal_CreateDelegate>("UnityEngine.Animations.AimConstraint::Internal_Create");

		// Token: 0x0400034D RID: 845
		private static readonly AimConstraint.get_weightDelegate get_weightDelegateField = IL2CPP.ResolveICall<AimConstraint.get_weightDelegate>("UnityEngine.Animations.AimConstraint::get_weight");

		// Token: 0x0400034E RID: 846
		private static readonly AimConstraint.set_weightDelegate set_weightDelegateField = IL2CPP.ResolveICall<AimConstraint.set_weightDelegate>("UnityEngine.Animations.AimConstraint::set_weight");

		// Token: 0x0400034F RID: 847
		private static readonly AimConstraint.get_constraintActiveDelegate get_constraintActiveDelegateField = IL2CPP.ResolveICall<AimConstraint.get_constraintActiveDelegate>("UnityEngine.Animations.AimConstraint::get_constraintActive");

		// Token: 0x04000350 RID: 848
		private static readonly AimConstraint.set_constraintActiveDelegate set_constraintActiveDelegateField = IL2CPP.ResolveICall<AimConstraint.set_constraintActiveDelegate>("UnityEngine.Animations.AimConstraint::set_constraintActive");

		// Token: 0x04000351 RID: 849
		private static readonly AimConstraint.get_lockedDelegate get_lockedDelegateField = IL2CPP.ResolveICall<AimConstraint.get_lockedDelegate>("UnityEngine.Animations.AimConstraint::get_locked");

		// Token: 0x04000352 RID: 850
		private static readonly AimConstraint.set_lockedDelegate set_lockedDelegateField = IL2CPP.ResolveICall<AimConstraint.set_lockedDelegate>("UnityEngine.Animations.AimConstraint::set_locked");

		// Token: 0x04000353 RID: 851
		private static readonly AimConstraint.get_rotationAxisDelegate get_rotationAxisDelegateField = IL2CPP.ResolveICall<AimConstraint.get_rotationAxisDelegate>("UnityEngine.Animations.AimConstraint::get_rotationAxis");

		// Token: 0x04000354 RID: 852
		private static readonly AimConstraint.set_rotationAxisDelegate set_rotationAxisDelegateField = IL2CPP.ResolveICall<AimConstraint.set_rotationAxisDelegate>("UnityEngine.Animations.AimConstraint::set_rotationAxis");

		// Token: 0x04000355 RID: 853
		private static readonly AimConstraint.get_worldUpObjectDelegate get_worldUpObjectDelegateField = IL2CPP.ResolveICall<AimConstraint.get_worldUpObjectDelegate>("UnityEngine.Animations.AimConstraint::get_worldUpObject");

		// Token: 0x04000356 RID: 854
		private static readonly AimConstraint.set_worldUpObjectDelegate set_worldUpObjectDelegateField = IL2CPP.ResolveICall<AimConstraint.set_worldUpObjectDelegate>("UnityEngine.Animations.AimConstraint::set_worldUpObject");

		// Token: 0x04000357 RID: 855
		private static readonly AimConstraint.get_worldUpTypeDelegate get_worldUpTypeDelegateField = IL2CPP.ResolveICall<AimConstraint.get_worldUpTypeDelegate>("UnityEngine.Animations.AimConstraint::get_worldUpType");

		// Token: 0x04000358 RID: 856
		private static readonly AimConstraint.set_worldUpTypeDelegate set_worldUpTypeDelegateField = IL2CPP.ResolveICall<AimConstraint.set_worldUpTypeDelegate>("UnityEngine.Animations.AimConstraint::set_worldUpType");

		// Token: 0x04000359 RID: 857
		private static readonly AimConstraint.GetSourceCountInternalDelegate GetSourceCountInternalDelegateField = IL2CPP.ResolveICall<AimConstraint.GetSourceCountInternalDelegate>("UnityEngine.Animations.AimConstraint::GetSourceCountInternal");

		// Token: 0x0400035A RID: 858
		private static readonly AimConstraint.RemoveSourceInternalDelegate RemoveSourceInternalDelegateField = IL2CPP.ResolveICall<AimConstraint.RemoveSourceInternalDelegate>("UnityEngine.Animations.AimConstraint::RemoveSourceInternal");

		// Token: 0x0400035B RID: 859
		private static readonly AimConstraint.get_rotationAtRest_InjectedDelegate get_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.get_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.AimConstraint::get_rotationAtRest_Injected");

		// Token: 0x0400035C RID: 860
		private static readonly AimConstraint.set_rotationAtRest_InjectedDelegate set_rotationAtRest_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.set_rotationAtRest_InjectedDelegate>("UnityEngine.Animations.AimConstraint::set_rotationAtRest_Injected");

		// Token: 0x0400035D RID: 861
		private static readonly AimConstraint.get_rotationOffset_InjectedDelegate get_rotationOffset_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.get_rotationOffset_InjectedDelegate>("UnityEngine.Animations.AimConstraint::get_rotationOffset_Injected");

		// Token: 0x0400035E RID: 862
		private static readonly AimConstraint.set_rotationOffset_InjectedDelegate set_rotationOffset_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.set_rotationOffset_InjectedDelegate>("UnityEngine.Animations.AimConstraint::set_rotationOffset_Injected");

		// Token: 0x0400035F RID: 863
		private static readonly AimConstraint.get_aimVector_InjectedDelegate get_aimVector_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.get_aimVector_InjectedDelegate>("UnityEngine.Animations.AimConstraint::get_aimVector_Injected");

		// Token: 0x04000360 RID: 864
		private static readonly AimConstraint.set_aimVector_InjectedDelegate set_aimVector_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.set_aimVector_InjectedDelegate>("UnityEngine.Animations.AimConstraint::set_aimVector_Injected");

		// Token: 0x04000361 RID: 865
		private static readonly AimConstraint.get_upVector_InjectedDelegate get_upVector_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.get_upVector_InjectedDelegate>("UnityEngine.Animations.AimConstraint::get_upVector_Injected");

		// Token: 0x04000362 RID: 866
		private static readonly AimConstraint.set_upVector_InjectedDelegate set_upVector_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.set_upVector_InjectedDelegate>("UnityEngine.Animations.AimConstraint::set_upVector_Injected");

		// Token: 0x04000363 RID: 867
		private static readonly AimConstraint.get_worldUpVector_InjectedDelegate get_worldUpVector_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.get_worldUpVector_InjectedDelegate>("UnityEngine.Animations.AimConstraint::get_worldUpVector_Injected");

		// Token: 0x04000364 RID: 868
		private static readonly AimConstraint.set_worldUpVector_InjectedDelegate set_worldUpVector_InjectedDelegateField = IL2CPP.ResolveICall<AimConstraint.set_worldUpVector_InjectedDelegate>("UnityEngine.Animations.AimConstraint::set_worldUpVector_Injected");

		// Token: 0x02000207 RID: 519
		public enum WorldUpType
		{
			// Token: 0x040003E9 RID: 1001
			SceneUp,
			// Token: 0x040003EA RID: 1002
			ObjectUp,
			// Token: 0x040003EB RID: 1003
			ObjectRotationUp,
			// Token: 0x040003EC RID: 1004
			Vector,
			// Token: 0x040003ED RID: 1005
			None
		}

		// Token: 0x02000208 RID: 520
		// (Invoke) Token: 0x060008B2 RID: 2226
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x02000209 RID: 521
		// (Invoke) Token: 0x060008B4 RID: 2228
		private delegate float get_weightDelegate(IntPtr @this);

		// Token: 0x0200020A RID: 522
		// (Invoke) Token: 0x060008B6 RID: 2230
		private delegate void set_weightDelegate(IntPtr @this, float value);

		// Token: 0x0200020B RID: 523
		// (Invoke) Token: 0x060008B8 RID: 2232
		private delegate bool get_constraintActiveDelegate(IntPtr @this);

		// Token: 0x0200020C RID: 524
		// (Invoke) Token: 0x060008BA RID: 2234
		private delegate void set_constraintActiveDelegate(IntPtr @this, bool value);

		// Token: 0x0200020D RID: 525
		// (Invoke) Token: 0x060008BC RID: 2236
		private delegate bool get_lockedDelegate(IntPtr @this);

		// Token: 0x0200020E RID: 526
		// (Invoke) Token: 0x060008BE RID: 2238
		private delegate void set_lockedDelegate(IntPtr @this, bool value);

		// Token: 0x0200020F RID: 527
		// (Invoke) Token: 0x060008C0 RID: 2240
		private delegate Axis get_rotationAxisDelegate(IntPtr @this);

		// Token: 0x02000210 RID: 528
		// (Invoke) Token: 0x060008C2 RID: 2242
		private delegate void set_rotationAxisDelegate(IntPtr @this, Axis value);

		// Token: 0x02000211 RID: 529
		// (Invoke) Token: 0x060008C4 RID: 2244
		private delegate IntPtr get_worldUpObjectDelegate(IntPtr @this);

		// Token: 0x02000212 RID: 530
		// (Invoke) Token: 0x060008C6 RID: 2246
		private delegate void set_worldUpObjectDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000213 RID: 531
		// (Invoke) Token: 0x060008C8 RID: 2248
		private delegate AimConstraint.WorldUpType get_worldUpTypeDelegate(IntPtr @this);

		// Token: 0x02000214 RID: 532
		// (Invoke) Token: 0x060008CA RID: 2250
		private delegate void set_worldUpTypeDelegate(IntPtr @this, AimConstraint.WorldUpType value);

		// Token: 0x02000215 RID: 533
		// (Invoke) Token: 0x060008CC RID: 2252
		private delegate int GetSourceCountInternalDelegate(IntPtr self);

		// Token: 0x02000216 RID: 534
		// (Invoke) Token: 0x060008CE RID: 2254
		private delegate void RemoveSourceInternalDelegate(IntPtr @this, int index);

		// Token: 0x02000217 RID: 535
		// (Invoke) Token: 0x060008D0 RID: 2256
		private delegate void get_rotationAtRest_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000218 RID: 536
		// (Invoke) Token: 0x060008D2 RID: 2258
		private delegate void set_rotationAtRest_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000219 RID: 537
		// (Invoke) Token: 0x060008D4 RID: 2260
		private delegate void get_rotationOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200021A RID: 538
		// (Invoke) Token: 0x060008D6 RID: 2262
		private delegate void set_rotationOffset_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200021B RID: 539
		// (Invoke) Token: 0x060008D8 RID: 2264
		private delegate void get_aimVector_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200021C RID: 540
		// (Invoke) Token: 0x060008DA RID: 2266
		private delegate void set_aimVector_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200021D RID: 541
		// (Invoke) Token: 0x060008DC RID: 2268
		private delegate void get_upVector_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200021E RID: 542
		// (Invoke) Token: 0x060008DE RID: 2270
		private delegate void set_upVector_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200021F RID: 543
		// (Invoke) Token: 0x060008E0 RID: 2272
		private delegate void get_worldUpVector_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000220 RID: 544
		// (Invoke) Token: 0x060008E2 RID: 2274
		private delegate void set_worldUpVector_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}

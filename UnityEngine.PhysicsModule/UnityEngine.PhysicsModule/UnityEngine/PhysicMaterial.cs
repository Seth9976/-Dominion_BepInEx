using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001F RID: 31
	public class PhysicMaterial : Object
	{
		// Token: 0x060002DE RID: 734 RVA: 0x00003A3A File Offset: 0x00001C3A
		public static void Internal_CreateDynamicsMaterial(PhysicMaterial mat, string name)
		{
			PhysicMaterial.Internal_CreateDynamicsMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mat), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00003A52 File Offset: 0x00001C52
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x00003A64 File Offset: 0x00001C64
		public float bounciness
		{
			get
			{
				return PhysicMaterial.get_bouncinessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicMaterial.set_bouncinessDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00003A77 File Offset: 0x00001C77
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x00003A89 File Offset: 0x00001C89
		public float dynamicFriction
		{
			get
			{
				return PhysicMaterial.get_dynamicFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicMaterial.set_dynamicFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00003A9C File Offset: 0x00001C9C
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x00003AAE File Offset: 0x00001CAE
		public float staticFriction
		{
			get
			{
				return PhysicMaterial.get_staticFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicMaterial.set_staticFrictionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00003AC1 File Offset: 0x00001CC1
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00003AD3 File Offset: 0x00001CD3
		public PhysicMaterialCombine frictionCombine
		{
			get
			{
				return PhysicMaterial.get_frictionCombineDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicMaterial.set_frictionCombineDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00003AE6 File Offset: 0x00001CE6
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00003AF8 File Offset: 0x00001CF8
		public PhysicMaterialCombine bounceCombine
		{
			get
			{
				return PhysicMaterial.get_bounceCombineDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PhysicMaterial.set_bounceCombineDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00009940 File Offset: 0x00007B40
		// (set) Token: 0x060002EA RID: 746 RVA: 0x00003B0B File Offset: 0x00001D0B
		public float bouncyness
		{
			get
			{
				return this.bounciness;
			}
			set
			{
				this.bounciness = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00009958 File Offset: 0x00007B58
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00003B16 File Offset: 0x00001D16
		public Vector3 frictionDirection2
		{
			get
			{
				return Vector3.zero;
			}
			set
			{
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00009970 File Offset: 0x00007B70
		// (set) Token: 0x060002EE RID: 750 RVA: 0x00003B19 File Offset: 0x00001D19
		public float dynamicFriction2
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00009988 File Offset: 0x00007B88
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x00003B1C File Offset: 0x00001D1C
		public float staticFriction2
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x000099A0 File Offset: 0x00007BA0
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x00003B1F File Offset: 0x00001D1F
		public Vector3 frictionDirection
		{
			get
			{
				return Vector3.zero;
			}
			set
			{
			}
		}

		// Token: 0x040001CB RID: 459
		private static readonly PhysicMaterial.Internal_CreateDynamicsMaterialDelegate Internal_CreateDynamicsMaterialDelegateField = IL2CPP.ResolveICall<PhysicMaterial.Internal_CreateDynamicsMaterialDelegate>("UnityEngine.PhysicMaterial::Internal_CreateDynamicsMaterial");

		// Token: 0x040001CC RID: 460
		private static readonly PhysicMaterial.get_bouncinessDelegate get_bouncinessDelegateField = IL2CPP.ResolveICall<PhysicMaterial.get_bouncinessDelegate>("UnityEngine.PhysicMaterial::get_bounciness");

		// Token: 0x040001CD RID: 461
		private static readonly PhysicMaterial.set_bouncinessDelegate set_bouncinessDelegateField = IL2CPP.ResolveICall<PhysicMaterial.set_bouncinessDelegate>("UnityEngine.PhysicMaterial::set_bounciness");

		// Token: 0x040001CE RID: 462
		private static readonly PhysicMaterial.get_dynamicFrictionDelegate get_dynamicFrictionDelegateField = IL2CPP.ResolveICall<PhysicMaterial.get_dynamicFrictionDelegate>("UnityEngine.PhysicMaterial::get_dynamicFriction");

		// Token: 0x040001CF RID: 463
		private static readonly PhysicMaterial.set_dynamicFrictionDelegate set_dynamicFrictionDelegateField = IL2CPP.ResolveICall<PhysicMaterial.set_dynamicFrictionDelegate>("UnityEngine.PhysicMaterial::set_dynamicFriction");

		// Token: 0x040001D0 RID: 464
		private static readonly PhysicMaterial.get_staticFrictionDelegate get_staticFrictionDelegateField = IL2CPP.ResolveICall<PhysicMaterial.get_staticFrictionDelegate>("UnityEngine.PhysicMaterial::get_staticFriction");

		// Token: 0x040001D1 RID: 465
		private static readonly PhysicMaterial.set_staticFrictionDelegate set_staticFrictionDelegateField = IL2CPP.ResolveICall<PhysicMaterial.set_staticFrictionDelegate>("UnityEngine.PhysicMaterial::set_staticFriction");

		// Token: 0x040001D2 RID: 466
		private static readonly PhysicMaterial.get_frictionCombineDelegate get_frictionCombineDelegateField = IL2CPP.ResolveICall<PhysicMaterial.get_frictionCombineDelegate>("UnityEngine.PhysicMaterial::get_frictionCombine");

		// Token: 0x040001D3 RID: 467
		private static readonly PhysicMaterial.set_frictionCombineDelegate set_frictionCombineDelegateField = IL2CPP.ResolveICall<PhysicMaterial.set_frictionCombineDelegate>("UnityEngine.PhysicMaterial::set_frictionCombine");

		// Token: 0x040001D4 RID: 468
		private static readonly PhysicMaterial.get_bounceCombineDelegate get_bounceCombineDelegateField = IL2CPP.ResolveICall<PhysicMaterial.get_bounceCombineDelegate>("UnityEngine.PhysicMaterial::get_bounceCombine");

		// Token: 0x040001D5 RID: 469
		private static readonly PhysicMaterial.set_bounceCombineDelegate set_bounceCombineDelegateField = IL2CPP.ResolveICall<PhysicMaterial.set_bounceCombineDelegate>("UnityEngine.PhysicMaterial::set_bounceCombine");

		// Token: 0x02000143 RID: 323
		// (Invoke) Token: 0x060005AB RID: 1451
		private delegate void Internal_CreateDynamicsMaterialDelegate(IntPtr mat, IntPtr name);

		// Token: 0x02000144 RID: 324
		// (Invoke) Token: 0x060005AD RID: 1453
		private delegate float get_bouncinessDelegate(IntPtr @this);

		// Token: 0x02000145 RID: 325
		// (Invoke) Token: 0x060005AF RID: 1455
		private delegate void set_bouncinessDelegate(IntPtr @this, float value);

		// Token: 0x02000146 RID: 326
		// (Invoke) Token: 0x060005B1 RID: 1457
		private delegate float get_dynamicFrictionDelegate(IntPtr @this);

		// Token: 0x02000147 RID: 327
		// (Invoke) Token: 0x060005B3 RID: 1459
		private delegate void set_dynamicFrictionDelegate(IntPtr @this, float value);

		// Token: 0x02000148 RID: 328
		// (Invoke) Token: 0x060005B5 RID: 1461
		private delegate float get_staticFrictionDelegate(IntPtr @this);

		// Token: 0x02000149 RID: 329
		// (Invoke) Token: 0x060005B7 RID: 1463
		private delegate void set_staticFrictionDelegate(IntPtr @this, float value);

		// Token: 0x0200014A RID: 330
		// (Invoke) Token: 0x060005B9 RID: 1465
		private delegate PhysicMaterialCombine get_frictionCombineDelegate(IntPtr @this);

		// Token: 0x0200014B RID: 331
		// (Invoke) Token: 0x060005BB RID: 1467
		private delegate void set_frictionCombineDelegate(IntPtr @this, PhysicMaterialCombine value);

		// Token: 0x0200014C RID: 332
		// (Invoke) Token: 0x060005BD RID: 1469
		private delegate PhysicMaterialCombine get_bounceCombineDelegate(IntPtr @this);

		// Token: 0x0200014D RID: 333
		// (Invoke) Token: 0x060005BF RID: 1471
		private delegate void set_bounceCombineDelegate(IntPtr @this, PhysicMaterialCombine value);
	}
}

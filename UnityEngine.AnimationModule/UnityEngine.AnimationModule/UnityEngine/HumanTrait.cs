using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000044 RID: 68
	public class HumanTrait
	{
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00004C57 File Offset: 0x00002E57
		public static int MuscleCount
		{
			get
			{
				return HumanTrait.get_MuscleCountDelegateField();
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00004C63 File Offset: 0x00002E63
		public static int GetBoneIndexFromMono(int humanId)
		{
			return HumanTrait.GetBoneIndexFromMonoDelegateField(humanId);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00004C70 File Offset: 0x00002E70
		public static int GetBoneIndexToMono(int boneIndex)
		{
			return HumanTrait.GetBoneIndexToMonoDelegateField(boneIndex);
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x0000C69C File Offset: 0x0000A89C
		public static Il2CppStringArray MuscleName
		{
			get
			{
				IntPtr intPtr = HumanTrait.get_MuscleNameDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00004C7D File Offset: 0x00002E7D
		public static int BoneCount
		{
			get
			{
				return HumanTrait.get_BoneCountDelegateField();
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x0000C6C4 File Offset: 0x0000A8C4
		public static Il2CppStringArray BoneName
		{
			get
			{
				IntPtr intPtr = HumanTrait.get_BoneNameDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000C6EC File Offset: 0x0000A8EC
		public static int MuscleFromBone(int i, int dofIndex)
		{
			return HumanTrait.Internal_MuscleFromBone(HumanTrait.GetBoneIndexFromMono(i), dofIndex);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00004C89 File Offset: 0x00002E89
		public static int Internal_MuscleFromBone(int i, int dofIndex)
		{
			return HumanTrait.Internal_MuscleFromBoneDelegateField(i, dofIndex);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0000C70C File Offset: 0x0000A90C
		public static int BoneFromMuscle(int i)
		{
			return HumanTrait.GetBoneIndexToMono(HumanTrait.Internal_BoneFromMuscle(i));
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00004C97 File Offset: 0x00002E97
		public static int Internal_BoneFromMuscle(int i)
		{
			return HumanTrait.Internal_BoneFromMuscleDelegateField(i);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000C72C File Offset: 0x0000A92C
		public static bool RequiredBone(int i)
		{
			return HumanTrait.Internal_RequiredBone(HumanTrait.GetBoneIndexFromMono(i));
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00004CA4 File Offset: 0x00002EA4
		public static bool Internal_RequiredBone(int i)
		{
			return HumanTrait.Internal_RequiredBoneDelegateField(i);
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00004CB1 File Offset: 0x00002EB1
		public static int RequiredBoneCount
		{
			get
			{
				return HumanTrait.get_RequiredBoneCountDelegateField();
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00004CBD File Offset: 0x00002EBD
		public static float GetMuscleDefaultMin(int i)
		{
			return HumanTrait.GetMuscleDefaultMinDelegateField(i);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00004CCA File Offset: 0x00002ECA
		public static float GetMuscleDefaultMax(int i)
		{
			return HumanTrait.GetMuscleDefaultMaxDelegateField(i);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0000C74C File Offset: 0x0000A94C
		public static float GetBoneDefaultHierarchyMass(int i)
		{
			return HumanTrait.Internal_GetBoneHierarchyMass(HumanTrait.GetBoneIndexFromMono(i));
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000C76C File Offset: 0x0000A96C
		public static int GetParentBone(int i)
		{
			int num = HumanTrait.Internal_GetParent(HumanTrait.GetBoneIndexFromMono(i));
			return (num != -1) ? HumanTrait.GetBoneIndexToMono(num) : (-1);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00004CD7 File Offset: 0x00002ED7
		public static float Internal_GetBoneHierarchyMass(int i)
		{
			return HumanTrait.Internal_GetBoneHierarchyMassDelegateField(i);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00004CE4 File Offset: 0x00002EE4
		public static int Internal_GetParent(int i)
		{
			return HumanTrait.Internal_GetParentDelegateField(i);
		}

		// Token: 0x04000333 RID: 819
		private static readonly HumanTrait.get_MuscleCountDelegate get_MuscleCountDelegateField = IL2CPP.ResolveICall<HumanTrait.get_MuscleCountDelegate>("UnityEngine.HumanTrait::get_MuscleCount");

		// Token: 0x04000334 RID: 820
		private static readonly HumanTrait.GetBoneIndexFromMonoDelegate GetBoneIndexFromMonoDelegateField = IL2CPP.ResolveICall<HumanTrait.GetBoneIndexFromMonoDelegate>("UnityEngine.HumanTrait::GetBoneIndexFromMono");

		// Token: 0x04000335 RID: 821
		private static readonly HumanTrait.GetBoneIndexToMonoDelegate GetBoneIndexToMonoDelegateField = IL2CPP.ResolveICall<HumanTrait.GetBoneIndexToMonoDelegate>("UnityEngine.HumanTrait::GetBoneIndexToMono");

		// Token: 0x04000336 RID: 822
		private static readonly HumanTrait.get_MuscleNameDelegate get_MuscleNameDelegateField = IL2CPP.ResolveICall<HumanTrait.get_MuscleNameDelegate>("UnityEngine.HumanTrait::get_MuscleName");

		// Token: 0x04000337 RID: 823
		private static readonly HumanTrait.get_BoneCountDelegate get_BoneCountDelegateField = IL2CPP.ResolveICall<HumanTrait.get_BoneCountDelegate>("UnityEngine.HumanTrait::get_BoneCount");

		// Token: 0x04000338 RID: 824
		private static readonly HumanTrait.get_BoneNameDelegate get_BoneNameDelegateField = IL2CPP.ResolveICall<HumanTrait.get_BoneNameDelegate>("UnityEngine.HumanTrait::get_BoneName");

		// Token: 0x04000339 RID: 825
		private static readonly HumanTrait.Internal_MuscleFromBoneDelegate Internal_MuscleFromBoneDelegateField = IL2CPP.ResolveICall<HumanTrait.Internal_MuscleFromBoneDelegate>("UnityEngine.HumanTrait::Internal_MuscleFromBone");

		// Token: 0x0400033A RID: 826
		private static readonly HumanTrait.Internal_BoneFromMuscleDelegate Internal_BoneFromMuscleDelegateField = IL2CPP.ResolveICall<HumanTrait.Internal_BoneFromMuscleDelegate>("UnityEngine.HumanTrait::Internal_BoneFromMuscle");

		// Token: 0x0400033B RID: 827
		private static readonly HumanTrait.Internal_RequiredBoneDelegate Internal_RequiredBoneDelegateField = IL2CPP.ResolveICall<HumanTrait.Internal_RequiredBoneDelegate>("UnityEngine.HumanTrait::Internal_RequiredBone");

		// Token: 0x0400033C RID: 828
		private static readonly HumanTrait.get_RequiredBoneCountDelegate get_RequiredBoneCountDelegateField = IL2CPP.ResolveICall<HumanTrait.get_RequiredBoneCountDelegate>("UnityEngine.HumanTrait::get_RequiredBoneCount");

		// Token: 0x0400033D RID: 829
		private static readonly HumanTrait.GetMuscleDefaultMinDelegate GetMuscleDefaultMinDelegateField = IL2CPP.ResolveICall<HumanTrait.GetMuscleDefaultMinDelegate>("UnityEngine.HumanTrait::GetMuscleDefaultMin");

		// Token: 0x0400033E RID: 830
		private static readonly HumanTrait.GetMuscleDefaultMaxDelegate GetMuscleDefaultMaxDelegateField = IL2CPP.ResolveICall<HumanTrait.GetMuscleDefaultMaxDelegate>("UnityEngine.HumanTrait::GetMuscleDefaultMax");

		// Token: 0x0400033F RID: 831
		private static readonly HumanTrait.Internal_GetBoneHierarchyMassDelegate Internal_GetBoneHierarchyMassDelegateField = IL2CPP.ResolveICall<HumanTrait.Internal_GetBoneHierarchyMassDelegate>("UnityEngine.HumanTrait::Internal_GetBoneHierarchyMass");

		// Token: 0x04000340 RID: 832
		private static readonly HumanTrait.Internal_GetParentDelegate Internal_GetParentDelegateField = IL2CPP.ResolveICall<HumanTrait.Internal_GetParentDelegate>("UnityEngine.HumanTrait::Internal_GetParent");

		// Token: 0x020001F5 RID: 501
		// (Invoke) Token: 0x0600088E RID: 2190
		private delegate int get_MuscleCountDelegate();

		// Token: 0x020001F6 RID: 502
		// (Invoke) Token: 0x06000890 RID: 2192
		private delegate int GetBoneIndexFromMonoDelegate(int humanId);

		// Token: 0x020001F7 RID: 503
		// (Invoke) Token: 0x06000892 RID: 2194
		private delegate int GetBoneIndexToMonoDelegate(int boneIndex);

		// Token: 0x020001F8 RID: 504
		// (Invoke) Token: 0x06000894 RID: 2196
		private delegate IntPtr get_MuscleNameDelegate();

		// Token: 0x020001F9 RID: 505
		// (Invoke) Token: 0x06000896 RID: 2198
		private delegate int get_BoneCountDelegate();

		// Token: 0x020001FA RID: 506
		// (Invoke) Token: 0x06000898 RID: 2200
		private delegate IntPtr get_BoneNameDelegate();

		// Token: 0x020001FB RID: 507
		// (Invoke) Token: 0x0600089A RID: 2202
		private delegate int Internal_MuscleFromBoneDelegate(int i, int dofIndex);

		// Token: 0x020001FC RID: 508
		// (Invoke) Token: 0x0600089C RID: 2204
		private delegate int Internal_BoneFromMuscleDelegate(int i);

		// Token: 0x020001FD RID: 509
		// (Invoke) Token: 0x0600089E RID: 2206
		private delegate bool Internal_RequiredBoneDelegate(int i);

		// Token: 0x020001FE RID: 510
		// (Invoke) Token: 0x060008A0 RID: 2208
		private delegate int get_RequiredBoneCountDelegate();

		// Token: 0x020001FF RID: 511
		// (Invoke) Token: 0x060008A2 RID: 2210
		private delegate float GetMuscleDefaultMinDelegate(int i);

		// Token: 0x02000200 RID: 512
		// (Invoke) Token: 0x060008A4 RID: 2212
		private delegate float GetMuscleDefaultMaxDelegate(int i);

		// Token: 0x02000201 RID: 513
		// (Invoke) Token: 0x060008A6 RID: 2214
		private delegate float Internal_GetBoneHierarchyMassDelegate(int i);

		// Token: 0x02000202 RID: 514
		// (Invoke) Token: 0x060008A8 RID: 2216
		private delegate int Internal_GetParentDelegate(int i);
	}
}

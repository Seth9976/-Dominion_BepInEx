using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200003F RID: 63
	public class Avatar : Object
	{
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00004976 File Offset: 0x00002B76
		public bool isValid
		{
			get
			{
				return Avatar.get_isValidDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00004988 File Offset: 0x00002B88
		public bool isHuman
		{
			get
			{
				return Avatar.get_isHumanDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0000499A File Offset: 0x00002B9A
		public void SetMuscleMinMax(int muscleId, float min, float max)
		{
			Avatar.SetMuscleMinMaxDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), muscleId, min, max);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x000049AF File Offset: 0x00002BAF
		public void SetParameter(int parameterId, float value)
		{
			Avatar.SetParameterDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), parameterId, value);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0000C224 File Offset: 0x0000A424
		public float GetAxisLength(int humanId)
		{
			return this.Internal_GetAxisLength(HumanTrait.GetBoneIndexFromMono(humanId));
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000C244 File Offset: 0x0000A444
		public Quaternion GetPreRotation(int humanId)
		{
			return this.Internal_GetPreRotation(HumanTrait.GetBoneIndexFromMono(humanId));
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0000C264 File Offset: 0x0000A464
		public Quaternion GetPostRotation(int humanId)
		{
			return this.Internal_GetPostRotation(HumanTrait.GetBoneIndexFromMono(humanId));
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000C284 File Offset: 0x0000A484
		public Quaternion GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q)
		{
			return this.Internal_GetZYPostQ(HumanTrait.GetBoneIndexFromMono(humanId), parentQ, q);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000C2A4 File Offset: 0x0000A4A4
		public Quaternion GetZYRoll(int humanId, Vector3 uvw)
		{
			return this.Internal_GetZYRoll(HumanTrait.GetBoneIndexFromMono(humanId), uvw);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0000C2C4 File Offset: 0x0000A4C4
		public Vector3 GetLimitSign(int humanId)
		{
			return this.Internal_GetLimitSign(HumanTrait.GetBoneIndexFromMono(humanId));
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000049C3 File Offset: 0x00002BC3
		public float Internal_GetAxisLength(int humanId)
		{
			return Avatar.Internal_GetAxisLengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanId);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0000C2E4 File Offset: 0x0000A4E4
		public Quaternion Internal_GetPreRotation(int humanId)
		{
			Quaternion quaternion;
			this.Internal_GetPreRotation_Injected(humanId, out quaternion);
			return quaternion;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0000C2FC File Offset: 0x0000A4FC
		public Quaternion Internal_GetPostRotation(int humanId)
		{
			Quaternion quaternion;
			this.Internal_GetPostRotation_Injected(humanId, out quaternion);
			return quaternion;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000C314 File Offset: 0x0000A514
		public Quaternion Internal_GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q)
		{
			Quaternion quaternion;
			this.Internal_GetZYPostQ_Injected(humanId, ref parentQ, ref q, out quaternion);
			return quaternion;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0000C330 File Offset: 0x0000A530
		public Quaternion Internal_GetZYRoll(int humanId, Vector3 uvw)
		{
			Quaternion quaternion;
			this.Internal_GetZYRoll_Injected(humanId, ref uvw, out quaternion);
			return quaternion;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000C34C File Offset: 0x0000A54C
		public Vector3 Internal_GetLimitSign(int humanId)
		{
			Vector3 vector;
			this.Internal_GetLimitSign_Injected(humanId, out vector);
			return vector;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000049D6 File Offset: 0x00002BD6
		public void Internal_GetPreRotation_Injected(int humanId, out Quaternion ret)
		{
			Avatar.Internal_GetPreRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanId, out ret);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000049EA File Offset: 0x00002BEA
		public void Internal_GetPostRotation_Injected(int humanId, out Quaternion ret)
		{
			Avatar.Internal_GetPostRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanId, out ret);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000049FE File Offset: 0x00002BFE
		public void Internal_GetZYPostQ_Injected(int humanId, ref Quaternion parentQ, ref Quaternion q, out Quaternion ret)
		{
			Avatar.Internal_GetZYPostQ_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanId, ref parentQ, ref q, out ret);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00004A15 File Offset: 0x00002C15
		public void Internal_GetZYRoll_Injected(int humanId, ref Vector3 uvw, out Quaternion ret)
		{
			Avatar.Internal_GetZYRoll_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanId, ref uvw, out ret);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00004A2A File Offset: 0x00002C2A
		public void Internal_GetLimitSign_Injected(int humanId, out Vector3 ret)
		{
			Avatar.Internal_GetLimitSign_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanId, out ret);
		}

		// Token: 0x04000304 RID: 772
		private static readonly Avatar.get_isValidDelegate get_isValidDelegateField = IL2CPP.ResolveICall<Avatar.get_isValidDelegate>("UnityEngine.Avatar::get_isValid");

		// Token: 0x04000305 RID: 773
		private static readonly Avatar.get_isHumanDelegate get_isHumanDelegateField = IL2CPP.ResolveICall<Avatar.get_isHumanDelegate>("UnityEngine.Avatar::get_isHuman");

		// Token: 0x04000306 RID: 774
		private static readonly Avatar.SetMuscleMinMaxDelegate SetMuscleMinMaxDelegateField = IL2CPP.ResolveICall<Avatar.SetMuscleMinMaxDelegate>("UnityEngine.Avatar::SetMuscleMinMax");

		// Token: 0x04000307 RID: 775
		private static readonly Avatar.SetParameterDelegate SetParameterDelegateField = IL2CPP.ResolveICall<Avatar.SetParameterDelegate>("UnityEngine.Avatar::SetParameter");

		// Token: 0x04000308 RID: 776
		private static readonly Avatar.Internal_GetAxisLengthDelegate Internal_GetAxisLengthDelegateField = IL2CPP.ResolveICall<Avatar.Internal_GetAxisLengthDelegate>("UnityEngine.Avatar::Internal_GetAxisLength");

		// Token: 0x04000309 RID: 777
		private static readonly Avatar.Internal_GetPreRotation_InjectedDelegate Internal_GetPreRotation_InjectedDelegateField = IL2CPP.ResolveICall<Avatar.Internal_GetPreRotation_InjectedDelegate>("UnityEngine.Avatar::Internal_GetPreRotation_Injected");

		// Token: 0x0400030A RID: 778
		private static readonly Avatar.Internal_GetPostRotation_InjectedDelegate Internal_GetPostRotation_InjectedDelegateField = IL2CPP.ResolveICall<Avatar.Internal_GetPostRotation_InjectedDelegate>("UnityEngine.Avatar::Internal_GetPostRotation_Injected");

		// Token: 0x0400030B RID: 779
		private static readonly Avatar.Internal_GetZYPostQ_InjectedDelegate Internal_GetZYPostQ_InjectedDelegateField = IL2CPP.ResolveICall<Avatar.Internal_GetZYPostQ_InjectedDelegate>("UnityEngine.Avatar::Internal_GetZYPostQ_Injected");

		// Token: 0x0400030C RID: 780
		private static readonly Avatar.Internal_GetZYRoll_InjectedDelegate Internal_GetZYRoll_InjectedDelegateField = IL2CPP.ResolveICall<Avatar.Internal_GetZYRoll_InjectedDelegate>("UnityEngine.Avatar::Internal_GetZYRoll_Injected");

		// Token: 0x0400030D RID: 781
		private static readonly Avatar.Internal_GetLimitSign_InjectedDelegate Internal_GetLimitSign_InjectedDelegateField = IL2CPP.ResolveICall<Avatar.Internal_GetLimitSign_InjectedDelegate>("UnityEngine.Avatar::Internal_GetLimitSign_Injected");

		// Token: 0x020001D5 RID: 469
		// (Invoke) Token: 0x0600084E RID: 2126
		private delegate bool get_isValidDelegate(IntPtr @this);

		// Token: 0x020001D6 RID: 470
		// (Invoke) Token: 0x06000850 RID: 2128
		private delegate bool get_isHumanDelegate(IntPtr @this);

		// Token: 0x020001D7 RID: 471
		// (Invoke) Token: 0x06000852 RID: 2130
		private delegate void SetMuscleMinMaxDelegate(IntPtr @this, int muscleId, float min, float max);

		// Token: 0x020001D8 RID: 472
		// (Invoke) Token: 0x06000854 RID: 2132
		private delegate void SetParameterDelegate(IntPtr @this, int parameterId, float value);

		// Token: 0x020001D9 RID: 473
		// (Invoke) Token: 0x06000856 RID: 2134
		private delegate float Internal_GetAxisLengthDelegate(IntPtr @this, int humanId);

		// Token: 0x020001DA RID: 474
		// (Invoke) Token: 0x06000858 RID: 2136
		private delegate void Internal_GetPreRotation_InjectedDelegate(IntPtr @this, int humanId, [Out] IntPtr ret);

		// Token: 0x020001DB RID: 475
		// (Invoke) Token: 0x0600085A RID: 2138
		private delegate void Internal_GetPostRotation_InjectedDelegate(IntPtr @this, int humanId, [Out] IntPtr ret);

		// Token: 0x020001DC RID: 476
		// (Invoke) Token: 0x0600085C RID: 2140
		private delegate void Internal_GetZYPostQ_InjectedDelegate(IntPtr @this, int humanId, IntPtr parentQ, IntPtr q, [Out] IntPtr ret);

		// Token: 0x020001DD RID: 477
		// (Invoke) Token: 0x0600085E RID: 2142
		private delegate void Internal_GetZYRoll_InjectedDelegate(IntPtr @this, int humanId, IntPtr uvw, [Out] IntPtr ret);

		// Token: 0x020001DE RID: 478
		// (Invoke) Token: 0x06000860 RID: 2144
		private delegate void Internal_GetLimitSign_InjectedDelegate(IntPtr @this, int humanId, [Out] IntPtr ret);
	}
}

using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000042 RID: 66
	public sealed class AvatarMask : Object
	{
		// Token: 0x06000440 RID: 1088 RVA: 0x00004A4F File Offset: 0x00002C4F
		public static void Internal_Create(AvatarMask self)
		{
			AvatarMask.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self));
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0000C45C File Offset: 0x0000A65C
		public int humanoidBodyPartCount
		{
			get
			{
				return 13;
			}
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00004A61 File Offset: 0x00002C61
		public bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index)
		{
			return AvatarMask.GetHumanoidBodyPartActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00004A74 File Offset: 0x00002C74
		public void SetHumanoidBodyPartActive(AvatarMaskBodyPart index, bool value)
		{
			AvatarMask.SetHumanoidBodyPartActiveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, value);
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x00004A88 File Offset: 0x00002C88
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x00004A9A File Offset: 0x00002C9A
		public int transformCount
		{
			get
			{
				return AvatarMask.get_transformCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AvatarMask.set_transformCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00004AAD File Offset: 0x00002CAD
		public void AddTransformPath(Transform transform)
		{
			this.AddTransformPath(transform, true);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00004AB9 File Offset: 0x00002CB9
		public void AddTransformPath(Transform transform, bool recursive)
		{
			AvatarMask.AddTransformPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(transform), recursive);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00004AD2 File Offset: 0x00002CD2
		public void RemoveTransformPath(Transform transform)
		{
			this.RemoveTransformPath(transform, true);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00004ADE File Offset: 0x00002CDE
		public void RemoveTransformPath(Transform transform, bool recursive)
		{
			AvatarMask.RemoveTransformPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(transform), recursive);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000C470 File Offset: 0x0000A670
		public string GetTransformPath(int index)
		{
			IntPtr intPtr = AvatarMask.GetTransformPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00004AF7 File Offset: 0x00002CF7
		public void SetTransformPath(int index, string path)
		{
			AvatarMask.SetTransformPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, IL2CPP.ManagedStringToIl2Cpp(path));
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00004B10 File Offset: 0x00002D10
		public float GetTransformWeight(int index)
		{
			return AvatarMask.GetTransformWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00004B23 File Offset: 0x00002D23
		public void SetTransformWeight(int index, float weight)
		{
			AvatarMask.SetTransformWeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index, weight);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000C498 File Offset: 0x0000A698
		public bool GetTransformActive(int index)
		{
			return this.GetTransformWeight(index) > 0.5f;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00004B37 File Offset: 0x00002D37
		public void SetTransformActive(int index, bool value)
		{
			this.SetTransformWeight(index, value ? 1f : 0f);
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00004B51 File Offset: 0x00002D51
		public bool hasFeetIK
		{
			get
			{
				return AvatarMask.get_hasFeetIKDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000C4B8 File Offset: 0x0000A6B8
		public void Copy(AvatarMask other)
		{
			for (AvatarMaskBodyPart avatarMaskBodyPart = AvatarMaskBodyPart.Root; avatarMaskBodyPart < AvatarMaskBodyPart.LastBodyPart; avatarMaskBodyPart++)
			{
				this.SetHumanoidBodyPartActive(avatarMaskBodyPart, other.GetHumanoidBodyPartActive(avatarMaskBodyPart));
			}
			this.transformCount = other.transformCount;
			for (int i = 0; i < other.transformCount; i++)
			{
				this.SetTransformPath(i, other.GetTransformPath(i));
				this.SetTransformActive(i, other.GetTransformActive(i));
			}
		}

		// Token: 0x0400031E RID: 798
		private static readonly AvatarMask.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<AvatarMask.Internal_CreateDelegate>("UnityEngine.AvatarMask::Internal_Create");

		// Token: 0x0400031F RID: 799
		private static readonly AvatarMask.GetHumanoidBodyPartActiveDelegate GetHumanoidBodyPartActiveDelegateField = IL2CPP.ResolveICall<AvatarMask.GetHumanoidBodyPartActiveDelegate>("UnityEngine.AvatarMask::GetHumanoidBodyPartActive");

		// Token: 0x04000320 RID: 800
		private static readonly AvatarMask.SetHumanoidBodyPartActiveDelegate SetHumanoidBodyPartActiveDelegateField = IL2CPP.ResolveICall<AvatarMask.SetHumanoidBodyPartActiveDelegate>("UnityEngine.AvatarMask::SetHumanoidBodyPartActive");

		// Token: 0x04000321 RID: 801
		private static readonly AvatarMask.get_transformCountDelegate get_transformCountDelegateField = IL2CPP.ResolveICall<AvatarMask.get_transformCountDelegate>("UnityEngine.AvatarMask::get_transformCount");

		// Token: 0x04000322 RID: 802
		private static readonly AvatarMask.set_transformCountDelegate set_transformCountDelegateField = IL2CPP.ResolveICall<AvatarMask.set_transformCountDelegate>("UnityEngine.AvatarMask::set_transformCount");

		// Token: 0x04000323 RID: 803
		private static readonly AvatarMask.AddTransformPathDelegate AddTransformPathDelegateField = IL2CPP.ResolveICall<AvatarMask.AddTransformPathDelegate>("UnityEngine.AvatarMask::AddTransformPath");

		// Token: 0x04000324 RID: 804
		private static readonly AvatarMask.RemoveTransformPathDelegate RemoveTransformPathDelegateField = IL2CPP.ResolveICall<AvatarMask.RemoveTransformPathDelegate>("UnityEngine.AvatarMask::RemoveTransformPath");

		// Token: 0x04000325 RID: 805
		private static readonly AvatarMask.GetTransformPathDelegate GetTransformPathDelegateField = IL2CPP.ResolveICall<AvatarMask.GetTransformPathDelegate>("UnityEngine.AvatarMask::GetTransformPath");

		// Token: 0x04000326 RID: 806
		private static readonly AvatarMask.SetTransformPathDelegate SetTransformPathDelegateField = IL2CPP.ResolveICall<AvatarMask.SetTransformPathDelegate>("UnityEngine.AvatarMask::SetTransformPath");

		// Token: 0x04000327 RID: 807
		private static readonly AvatarMask.GetTransformWeightDelegate GetTransformWeightDelegateField = IL2CPP.ResolveICall<AvatarMask.GetTransformWeightDelegate>("UnityEngine.AvatarMask::GetTransformWeight");

		// Token: 0x04000328 RID: 808
		private static readonly AvatarMask.SetTransformWeightDelegate SetTransformWeightDelegateField = IL2CPP.ResolveICall<AvatarMask.SetTransformWeightDelegate>("UnityEngine.AvatarMask::SetTransformWeight");

		// Token: 0x04000329 RID: 809
		private static readonly AvatarMask.get_hasFeetIKDelegate get_hasFeetIKDelegateField = IL2CPP.ResolveICall<AvatarMask.get_hasFeetIKDelegate>("UnityEngine.AvatarMask::get_hasFeetIK");

		// Token: 0x020001E0 RID: 480
		// (Invoke) Token: 0x06000864 RID: 2148
		private delegate void Internal_CreateDelegate(IntPtr self);

		// Token: 0x020001E1 RID: 481
		// (Invoke) Token: 0x06000866 RID: 2150
		private delegate bool GetHumanoidBodyPartActiveDelegate(IntPtr @this, AvatarMaskBodyPart index);

		// Token: 0x020001E2 RID: 482
		// (Invoke) Token: 0x06000868 RID: 2152
		private delegate void SetHumanoidBodyPartActiveDelegate(IntPtr @this, AvatarMaskBodyPart index, bool value);

		// Token: 0x020001E3 RID: 483
		// (Invoke) Token: 0x0600086A RID: 2154
		private delegate int get_transformCountDelegate(IntPtr @this);

		// Token: 0x020001E4 RID: 484
		// (Invoke) Token: 0x0600086C RID: 2156
		private delegate void set_transformCountDelegate(IntPtr @this, int value);

		// Token: 0x020001E5 RID: 485
		// (Invoke) Token: 0x0600086E RID: 2158
		private delegate void AddTransformPathDelegate(IntPtr @this, IntPtr transform, bool recursive);

		// Token: 0x020001E6 RID: 486
		// (Invoke) Token: 0x06000870 RID: 2160
		private delegate void RemoveTransformPathDelegate(IntPtr @this, IntPtr transform, bool recursive);

		// Token: 0x020001E7 RID: 487
		// (Invoke) Token: 0x06000872 RID: 2162
		private delegate IntPtr GetTransformPathDelegate(IntPtr @this, int index);

		// Token: 0x020001E8 RID: 488
		// (Invoke) Token: 0x06000874 RID: 2164
		private delegate void SetTransformPathDelegate(IntPtr @this, int index, IntPtr path);

		// Token: 0x020001E9 RID: 489
		// (Invoke) Token: 0x06000876 RID: 2166
		private delegate float GetTransformWeightDelegate(IntPtr @this, int index);

		// Token: 0x020001EA RID: 490
		// (Invoke) Token: 0x06000878 RID: 2168
		private delegate void SetTransformWeightDelegate(IntPtr @this, int index, float weight);

		// Token: 0x020001EB RID: 491
		// (Invoke) Token: 0x0600087A RID: 2170
		private delegate bool get_hasFeetIKDelegate(IntPtr @this);
	}
}

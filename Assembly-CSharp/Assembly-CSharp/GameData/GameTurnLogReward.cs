using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData
{
	// Token: 0x0200012E RID: 302
	public sealed class GameTurnLogReward : ValueType
	{
		// Token: 0x06002191 RID: 8593 RVA: 0x0007FAC8 File Offset: 0x0007DCC8
		// Note: this type is marked as 'beforefieldinit'.
		static GameTurnLogReward()
		{
			Il2CppClassPointerStore<GameTurnLogReward>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData", "GameTurnLogReward");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameTurnLogReward>.NativeClassPtr);
			GameTurnLogReward.NativeFieldInfoPtr_cardRewardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogReward>.NativeClassPtr, "cardRewardType");
			GameTurnLogReward.NativeFieldInfoPtr_cardRewardInstanceIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogReward>.NativeClassPtr, "cardRewardInstanceIDs");
			GameTurnLogReward.NativeFieldInfoPtr_resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogReward>.NativeClassPtr, "resources");
			GameTurnLogReward.NativeFieldInfoPtr_bFirstPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogReward>.NativeClassPtr, "bFirstPlayer");
			GameTurnLogReward.NativeFieldInfoPtr_bLiutenant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogReward>.NativeClassPtr, "bLiutenant");
			GameTurnLogReward.NativeFieldInfoPtr_bAmbassador = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogReward>.NativeClassPtr, "bAmbassador");
			GameTurnLogReward.NativeFieldInfoPtr_sourceInstanceIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogReward>.NativeClassPtr, "sourceInstanceIDs");
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x00014DE8 File Offset: 0x00012FE8
		public GameTurnLogReward(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x00014DF1 File Offset: 0x00012FF1
		public GameTurnLogReward()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameTurnLogReward>.NativeClassPtr))
		{
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06002194 RID: 8596 RVA: 0x0007FB84 File Offset: 0x0007DD84
		// (set) Token: 0x06002195 RID: 8597 RVA: 0x00014E03 File Offset: 0x00013003
		public unsafe Il2CppStructArray<int> cardRewardType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogReward.NativeFieldInfoPtr_cardRewardType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogReward.NativeFieldInfoPtr_cardRewardType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002196 RID: 8598 RVA: 0x0007FBB4 File Offset: 0x0007DDB4
		// (set) Token: 0x06002197 RID: 8599 RVA: 0x00014E22 File Offset: 0x00013022
		public unsafe Il2CppStructArray<int> cardRewardInstanceIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogReward.NativeFieldInfoPtr_cardRewardInstanceIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogReward.NativeFieldInfoPtr_cardRewardInstanceIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06002198 RID: 8600 RVA: 0x0007FBE4 File Offset: 0x0007DDE4
		// (set) Token: 0x06002199 RID: 8601 RVA: 0x00014E41 File Offset: 0x00013041
		public unsafe Il2CppStructArray<int> resources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogReward.NativeFieldInfoPtr_resources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogReward.NativeFieldInfoPtr_resources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x0600219A RID: 8602 RVA: 0x0007FC14 File Offset: 0x0007DE14
		// (set) Token: 0x0600219B RID: 8603 RVA: 0x00014E60 File Offset: 0x00013060
		public unsafe int bFirstPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogReward.NativeFieldInfoPtr_bFirstPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogReward.NativeFieldInfoPtr_bFirstPlayer)) = value;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x0600219C RID: 8604 RVA: 0x0007FC3C File Offset: 0x0007DE3C
		// (set) Token: 0x0600219D RID: 8605 RVA: 0x00014E7B File Offset: 0x0001307B
		public unsafe int bLiutenant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogReward.NativeFieldInfoPtr_bLiutenant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogReward.NativeFieldInfoPtr_bLiutenant)) = value;
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x0600219E RID: 8606 RVA: 0x0007FC64 File Offset: 0x0007DE64
		// (set) Token: 0x0600219F RID: 8607 RVA: 0x00014E96 File Offset: 0x00013096
		public unsafe int bAmbassador
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogReward.NativeFieldInfoPtr_bAmbassador);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogReward.NativeFieldInfoPtr_bAmbassador)) = value;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x060021A0 RID: 8608 RVA: 0x0007FC8C File Offset: 0x0007DE8C
		// (set) Token: 0x060021A1 RID: 8609 RVA: 0x00014EB1 File Offset: 0x000130B1
		public unsafe Il2CppStructArray<int> sourceInstanceIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogReward.NativeFieldInfoPtr_sourceInstanceIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogReward.NativeFieldInfoPtr_sourceInstanceIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400168F RID: 5775
		private static readonly IntPtr NativeFieldInfoPtr_cardRewardType;

		// Token: 0x04001690 RID: 5776
		private static readonly IntPtr NativeFieldInfoPtr_cardRewardInstanceIDs;

		// Token: 0x04001691 RID: 5777
		private static readonly IntPtr NativeFieldInfoPtr_resources;

		// Token: 0x04001692 RID: 5778
		private static readonly IntPtr NativeFieldInfoPtr_bFirstPlayer;

		// Token: 0x04001693 RID: 5779
		private static readonly IntPtr NativeFieldInfoPtr_bLiutenant;

		// Token: 0x04001694 RID: 5780
		private static readonly IntPtr NativeFieldInfoPtr_bAmbassador;

		// Token: 0x04001695 RID: 5781
		private static readonly IntPtr NativeFieldInfoPtr_sourceInstanceIDs;
	}
}

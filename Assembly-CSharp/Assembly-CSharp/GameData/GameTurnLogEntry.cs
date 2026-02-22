using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData
{
	// Token: 0x0200012F RID: 303
	public sealed class GameTurnLogEntry : ValueType
	{
		// Token: 0x060021A2 RID: 8610 RVA: 0x0007FCBC File Offset: 0x0007DEBC
		// Note: this type is marked as 'beforefieldinit'.
		static GameTurnLogEntry()
		{
			Il2CppClassPointerStore<GameTurnLogEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData", "GameTurnLogEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameTurnLogEntry>.NativeClassPtr);
			GameTurnLogEntry.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogEntry>.NativeClassPtr, "player");
			GameTurnLogEntry.NativeFieldInfoPtr_round = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogEntry>.NativeClassPtr, "round");
			GameTurnLogEntry.NativeFieldInfoPtr_turn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogEntry>.NativeClassPtr, "turn");
			GameTurnLogEntry.NativeFieldInfoPtr_actionInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogEntry>.NativeClassPtr, "actionInstanceID");
			GameTurnLogEntry.NativeFieldInfoPtr_purchasedInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogEntry>.NativeClassPtr, "purchasedInstanceID");
			GameTurnLogEntry.NativeFieldInfoPtr_playedInstanceIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogEntry>.NativeClassPtr, "playedInstanceIDs");
			GameTurnLogEntry.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogEntry>.NativeClassPtr, "score");
			GameTurnLogEntry.NativeFieldInfoPtr_agents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogEntry>.NativeClassPtr, "agents");
			GameTurnLogEntry.NativeFieldInfoPtr_bIsStartingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogEntry>.NativeClassPtr, "bIsStartingPlayer");
			GameTurnLogEntry.NativeFieldInfoPtr_bHasAmbassador = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogEntry>.NativeClassPtr, "bHasAmbassador");
			GameTurnLogEntry.NativeFieldInfoPtr_startingResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogEntry>.NativeClassPtr, "startingResources");
			GameTurnLogEntry.NativeFieldInfoPtr_rewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogEntry>.NativeClassPtr, "rewards");
			GameTurnLogEntry.NativeFieldInfoPtr_oppRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameTurnLogEntry>.NativeClassPtr, "oppRewards");
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x00014ED0 File Offset: 0x000130D0
		public GameTurnLogEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x00014ED9 File Offset: 0x000130D9
		public GameTurnLogEntry()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameTurnLogEntry>.NativeClassPtr))
		{
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x060021A5 RID: 8613 RVA: 0x0007FDF0 File Offset: 0x0007DFF0
		// (set) Token: 0x060021A6 RID: 8614 RVA: 0x00014EEB File Offset: 0x000130EB
		public unsafe int player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_player);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_player)) = value;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x0007FE18 File Offset: 0x0007E018
		// (set) Token: 0x060021A8 RID: 8616 RVA: 0x00014F06 File Offset: 0x00013106
		public unsafe int round
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_round);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_round)) = value;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x060021A9 RID: 8617 RVA: 0x0007FE40 File Offset: 0x0007E040
		// (set) Token: 0x060021AA RID: 8618 RVA: 0x00014F21 File Offset: 0x00013121
		public unsafe int turn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_turn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_turn)) = value;
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x060021AB RID: 8619 RVA: 0x0007FE68 File Offset: 0x0007E068
		// (set) Token: 0x060021AC RID: 8620 RVA: 0x00014F3C File Offset: 0x0001313C
		public unsafe int actionInstanceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_actionInstanceID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_actionInstanceID)) = value;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x0007FE90 File Offset: 0x0007E090
		// (set) Token: 0x060021AE RID: 8622 RVA: 0x00014F57 File Offset: 0x00013157
		public unsafe int purchasedInstanceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_purchasedInstanceID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_purchasedInstanceID)) = value;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x0007FEB8 File Offset: 0x0007E0B8
		// (set) Token: 0x060021B0 RID: 8624 RVA: 0x00014F72 File Offset: 0x00013172
		public unsafe Il2CppStructArray<int> playedInstanceIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_playedInstanceIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_playedInstanceIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x0007FEE8 File Offset: 0x0007E0E8
		// (set) Token: 0x060021B2 RID: 8626 RVA: 0x00014F91 File Offset: 0x00013191
		public unsafe int score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_score);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_score)) = value;
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x0007FF10 File Offset: 0x0007E110
		// (set) Token: 0x060021B4 RID: 8628 RVA: 0x00014FAC File Offset: 0x000131AC
		public unsafe Il2CppStructArray<int> agents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_agents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_agents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x0007FF40 File Offset: 0x0007E140
		// (set) Token: 0x060021B6 RID: 8630 RVA: 0x00014FCB File Offset: 0x000131CB
		public unsafe int bIsStartingPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_bIsStartingPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_bIsStartingPlayer)) = value;
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x0007FF68 File Offset: 0x0007E168
		// (set) Token: 0x060021B8 RID: 8632 RVA: 0x00014FE6 File Offset: 0x000131E6
		public unsafe int bHasAmbassador
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_bHasAmbassador);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_bHasAmbassador)) = value;
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x0007FF90 File Offset: 0x0007E190
		// (set) Token: 0x060021BA RID: 8634 RVA: 0x00015001 File Offset: 0x00013201
		public unsafe Il2CppStructArray<int> startingResources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_startingResources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_startingResources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x0007FFC0 File Offset: 0x0007E1C0
		// (set) Token: 0x060021BC RID: 8636 RVA: 0x00015020 File Offset: 0x00013220
		public GameTurnLogReward rewards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_rewards);
				return new GameTurnLogReward(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameTurnLogReward>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_rewards), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameTurnLogReward>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x0007FFF0 File Offset: 0x0007E1F0
		// (set) Token: 0x060021BE RID: 8638 RVA: 0x0001504E File Offset: 0x0001324E
		public unsafe Il2CppReferenceArray<GameTurnLogReward> oppRewards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_oppRewards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameTurnLogReward>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameTurnLogEntry.NativeFieldInfoPtr_oppRewards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001696 RID: 5782
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04001697 RID: 5783
		private static readonly IntPtr NativeFieldInfoPtr_round;

		// Token: 0x04001698 RID: 5784
		private static readonly IntPtr NativeFieldInfoPtr_turn;

		// Token: 0x04001699 RID: 5785
		private static readonly IntPtr NativeFieldInfoPtr_actionInstanceID;

		// Token: 0x0400169A RID: 5786
		private static readonly IntPtr NativeFieldInfoPtr_purchasedInstanceID;

		// Token: 0x0400169B RID: 5787
		private static readonly IntPtr NativeFieldInfoPtr_playedInstanceIDs;

		// Token: 0x0400169C RID: 5788
		private static readonly IntPtr NativeFieldInfoPtr_score;

		// Token: 0x0400169D RID: 5789
		private static readonly IntPtr NativeFieldInfoPtr_agents;

		// Token: 0x0400169E RID: 5790
		private static readonly IntPtr NativeFieldInfoPtr_bIsStartingPlayer;

		// Token: 0x0400169F RID: 5791
		private static readonly IntPtr NativeFieldInfoPtr_bHasAmbassador;

		// Token: 0x040016A0 RID: 5792
		private static readonly IntPtr NativeFieldInfoPtr_startingResources;

		// Token: 0x040016A1 RID: 5793
		private static readonly IntPtr NativeFieldInfoPtr_rewards;

		// Token: 0x040016A2 RID: 5794
		private static readonly IntPtr NativeFieldInfoPtr_oppRewards;
	}
}

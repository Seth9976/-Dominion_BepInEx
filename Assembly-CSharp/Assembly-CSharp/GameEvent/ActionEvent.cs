using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000150 RID: 336
	[StructLayout(2)]
	public struct ActionEvent
	{
		// Token: 0x0600221A RID: 8730 RVA: 0x00080EE8 File Offset: 0x0007F0E8
		// Note: this type is marked as 'beforefieldinit'.
		static ActionEvent()
		{
			Il2CppClassPointerStore<ActionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "ActionEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr);
			ActionEvent.NativeFieldInfoPtr_player_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, "player_instance_id");
			ActionEvent.NativeFieldInfoPtr_action_event_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, "action_event_type");
			ActionEvent.NativeFieldInfoPtr_action_card_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, "action_card_instance_id");
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x00015545 File Offset: 0x00013745
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, ref this));
		}

		// Token: 0x040017B2 RID: 6066
		private static readonly IntPtr NativeFieldInfoPtr_player_instance_id;

		// Token: 0x040017B3 RID: 6067
		private static readonly IntPtr NativeFieldInfoPtr_action_event_type;

		// Token: 0x040017B4 RID: 6068
		private static readonly IntPtr NativeFieldInfoPtr_action_card_instance_id;

		// Token: 0x040017B5 RID: 6069
		[FieldOffset(0)]
		public int player_instance_id;

		// Token: 0x040017B6 RID: 6070
		[FieldOffset(4)]
		public int action_event_type;

		// Token: 0x040017B7 RID: 6071
		[FieldOffset(8)]
		public int action_card_instance_id;

		// Token: 0x02000239 RID: 569
		public enum ActionType
		{
			// Token: 0x04001DCE RID: 7630
			PlayedDayEffect,
			// Token: 0x04001DCF RID: 7631
			PlayedNightEffect,
			// Token: 0x04001DD0 RID: 7632
			GainReputation,
			// Token: 0x04001DD1 RID: 7633
			AcquiredChampionHero,
			// Token: 0x04001DD2 RID: 7634
			DefeatedHero,
			// Token: 0x04001DD3 RID: 7635
			AcquiredPortal,
			// Token: 0x04001DD4 RID: 7636
			RallyFromCenterRow,
			// Token: 0x04001DD5 RID: 7637
			EnergizedConstruct,
			// Token: 0x04001DD6 RID: 7638
			MovedEnergyCard,
			// Token: 0x04001DD7 RID: 7639
			PlayLeprechaun,
			// Token: 0x04001DD8 RID: 7640
			AcquireEmpowerCard,
			// Token: 0x04001DD9 RID: 7641
			InfestMonster,
			// Token: 0x04001DDA RID: 7642
			PlayMonsterFromHand,
			// Token: 0x04001DDB RID: 7643
			CellBlockE,
			// Token: 0x04001DDC RID: 7644
			PrimeDirective,
			// Token: 0x04001DDD RID: 7645
			ThicketFamiliar,
			// Token: 0x04001DDE RID: 7646
			YukTribeOutcast,
			// Token: 0x04001DDF RID: 7647
			GainControlOfNeutralTemple,
			// Token: 0x04001DE0 RID: 7648
			GainControlOfOppTemple,
			// Token: 0x04001DE1 RID: 7649
			UseTempleEffect,
			// Token: 0x04001DE2 RID: 7650
			Serenity,
			// Token: 0x04001DE3 RID: 7651
			Echo,
			// Token: 0x04001DE4 RID: 7652
			JubliantMonkCardMatch,
			// Token: 0x04001DE5 RID: 7653
			FistOfTheDragonMonsterDefeat,
			// Token: 0x04001DE6 RID: 7654
			ShuffleSelfBackIntoDeck,
			// Token: 0x04001DE7 RID: 7655
			DiscardEntireDeck,
			// Token: 0x04001DE8 RID: 7656
			AlosyanGuide,
			// Token: 0x04001DE9 RID: 7657
			DeliriumDieRollStart,
			// Token: 0x04001DEA RID: 7658
			DeliriumDieRoll1,
			// Token: 0x04001DEB RID: 7659
			DeliriumDieRoll2,
			// Token: 0x04001DEC RID: 7660
			DeliriumDieRoll3,
			// Token: 0x04001DED RID: 7661
			DeliriumDieRoll4,
			// Token: 0x04001DEE RID: 7662
			DeliriumDieRoll5,
			// Token: 0x04001DEF RID: 7663
			DeliriumDieRoll6,
			// Token: 0x04001DF0 RID: 7664
			Recur,
			// Token: 0x04001DF1 RID: 7665
			InsightAuction
		}
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameData
{
	// Token: 0x02000129 RID: 297
	[StructLayout(2)]
	public struct WorldData
	{
		// Token: 0x0600213E RID: 8510 RVA: 0x0007F03C File Offset: 0x0007D23C
		// Note: this type is marked as 'beforefieldinit'.
		static WorldData()
		{
			Il2CppClassPointerStore<WorldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData", "WorldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldData>.NativeClassPtr);
			WorldData.NativeFieldInfoPtr_is_tutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "is_tutorial");
			WorldData.NativeFieldInfoPtr_round_number = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "round_number");
			WorldData.NativeFieldInfoPtr_current_turn_player_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "current_turn_player_index");
			WorldData.NativeFieldInfoPtr_portal_deck_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "portal_deck_count");
			WorldData.NativeFieldInfoPtr_void_pile_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "void_pile_count");
			WorldData.NativeFieldInfoPtr_event_card_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "event_card_instance_id");
			WorldData.NativeFieldInfoPtr_honor_token_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "honor_token_pool");
			WorldData.NativeFieldInfoPtr_current_turn_rune_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "current_turn_rune_count");
			WorldData.NativeFieldInfoPtr_current_turn_rune_mechana_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "current_turn_rune_mechana_count");
			WorldData.NativeFieldInfoPtr_current_turn_power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "current_turn_power");
			WorldData.NativeFieldInfoPtr_current_turn_energy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "current_turn_energy");
			WorldData.NativeFieldInfoPtr_current_turn_life = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "current_turn_life");
			WorldData.NativeFieldInfoPtr_current_turn_death = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "current_turn_death");
			WorldData.NativeFieldInfoPtr_current_turn_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldData>.NativeClassPtr, "current_turn_flags");
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x0001498E File Offset: 0x00012B8E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldData>.NativeClassPtr, ref this));
		}

		// Token: 0x0400164C RID: 5708
		private static readonly IntPtr NativeFieldInfoPtr_is_tutorial;

		// Token: 0x0400164D RID: 5709
		private static readonly IntPtr NativeFieldInfoPtr_round_number;

		// Token: 0x0400164E RID: 5710
		private static readonly IntPtr NativeFieldInfoPtr_current_turn_player_index;

		// Token: 0x0400164F RID: 5711
		private static readonly IntPtr NativeFieldInfoPtr_portal_deck_count;

		// Token: 0x04001650 RID: 5712
		private static readonly IntPtr NativeFieldInfoPtr_void_pile_count;

		// Token: 0x04001651 RID: 5713
		private static readonly IntPtr NativeFieldInfoPtr_event_card_instance_id;

		// Token: 0x04001652 RID: 5714
		private static readonly IntPtr NativeFieldInfoPtr_honor_token_pool;

		// Token: 0x04001653 RID: 5715
		private static readonly IntPtr NativeFieldInfoPtr_current_turn_rune_count;

		// Token: 0x04001654 RID: 5716
		private static readonly IntPtr NativeFieldInfoPtr_current_turn_rune_mechana_count;

		// Token: 0x04001655 RID: 5717
		private static readonly IntPtr NativeFieldInfoPtr_current_turn_power;

		// Token: 0x04001656 RID: 5718
		private static readonly IntPtr NativeFieldInfoPtr_current_turn_energy;

		// Token: 0x04001657 RID: 5719
		private static readonly IntPtr NativeFieldInfoPtr_current_turn_life;

		// Token: 0x04001658 RID: 5720
		private static readonly IntPtr NativeFieldInfoPtr_current_turn_death;

		// Token: 0x04001659 RID: 5721
		private static readonly IntPtr NativeFieldInfoPtr_current_turn_flags;

		// Token: 0x0400165A RID: 5722
		[FieldOffset(0)]
		public int is_tutorial;

		// Token: 0x0400165B RID: 5723
		[FieldOffset(4)]
		public int round_number;

		// Token: 0x0400165C RID: 5724
		[FieldOffset(8)]
		public int current_turn_player_index;

		// Token: 0x0400165D RID: 5725
		[FieldOffset(12)]
		public int portal_deck_count;

		// Token: 0x0400165E RID: 5726
		[FieldOffset(16)]
		public int void_pile_count;

		// Token: 0x0400165F RID: 5727
		[FieldOffset(20)]
		public int event_card_instance_id;

		// Token: 0x04001660 RID: 5728
		[FieldOffset(24)]
		public int honor_token_pool;

		// Token: 0x04001661 RID: 5729
		[FieldOffset(28)]
		public int current_turn_rune_count;

		// Token: 0x04001662 RID: 5730
		[FieldOffset(32)]
		public int current_turn_rune_mechana_count;

		// Token: 0x04001663 RID: 5731
		[FieldOffset(36)]
		public int current_turn_power;

		// Token: 0x04001664 RID: 5732
		[FieldOffset(40)]
		public int current_turn_energy;

		// Token: 0x04001665 RID: 5733
		[FieldOffset(44)]
		public int current_turn_life;

		// Token: 0x04001666 RID: 5734
		[FieldOffset(48)]
		public int current_turn_death;

		// Token: 0x04001667 RID: 5735
		[FieldOffset(52)]
		public int current_turn_flags;
	}
}

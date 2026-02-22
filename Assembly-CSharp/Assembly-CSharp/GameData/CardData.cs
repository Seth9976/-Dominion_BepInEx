using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameData
{
	// Token: 0x0200012B RID: 299
	public sealed class CardData : ValueType
	{
		// Token: 0x06002142 RID: 8514 RVA: 0x0007F1DC File Offset: 0x0007D3DC
		// Note: this type is marked as 'beforefieldinit'.
		static CardData()
		{
			Il2CppClassPointerStore<CardData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData", "CardData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardData>.NativeClassPtr);
			CardData.NativeFieldInfoPtr_card_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "card_instance_id");
			CardData.NativeFieldInfoPtr_card_set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "card_set");
			CardData.NativeFieldInfoPtr_card_rarity_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "card_rarity_count");
			CardData.NativeFieldInfoPtr_card_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "card_type");
			CardData.NativeFieldInfoPtr_card_faction_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "card_faction_flags");
			CardData.NativeFieldInfoPtr_card_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "card_flags");
			CardData.NativeFieldInfoPtr_card_rune_cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "card_rune_cost");
			CardData.NativeFieldInfoPtr_card_power_cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "card_power_cost");
			CardData.NativeFieldInfoPtr_card_insight_cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "card_insight_cost");
			CardData.NativeFieldInfoPtr_card_honor_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "card_honor_value");
			CardData.NativeFieldInfoPtr_card_name_hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "card_name_hash");
			CardData.NativeFieldInfoPtr_card_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "card_name");
			CardData.NativeFieldInfoPtr_display_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "display_name");
			CardData.NativeFieldInfoPtr_card_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "card_image");
			CardData.NativeFieldInfoPtr_card_type_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "card_type_text");
			CardData.NativeFieldInfoPtr_card_effect_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "card_effect_text");
			CardData.NativeFieldInfoPtr_card_additional_effect1_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "card_additional_effect1_text");
			CardData.NativeFieldInfoPtr_card_additional_effect2_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "card_additional_effect2_text");
			CardData.NativeFieldInfoPtr_card_flavor_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "card_flavor_text");
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x000149B2 File Offset: 0x00012BB2
		public CardData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x000149BB File Offset: 0x00012BBB
		public CardData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardData>.NativeClassPtr))
		{
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x0007F388 File Offset: 0x0007D588
		// (set) Token: 0x06002146 RID: 8518 RVA: 0x000149CD File Offset: 0x00012BCD
		public unsafe short card_instance_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_instance_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_instance_id)) = value;
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06002147 RID: 8519 RVA: 0x0007F3B0 File Offset: 0x0007D5B0
		// (set) Token: 0x06002148 RID: 8520 RVA: 0x000149E8 File Offset: 0x00012BE8
		public unsafe short card_set
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_set);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_set)) = value;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x0007F3D8 File Offset: 0x0007D5D8
		// (set) Token: 0x0600214A RID: 8522 RVA: 0x00014A03 File Offset: 0x00012C03
		public unsafe short card_rarity_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_rarity_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_rarity_count)) = value;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x0007F400 File Offset: 0x0007D600
		// (set) Token: 0x0600214C RID: 8524 RVA: 0x00014A1E File Offset: 0x00012C1E
		public unsafe short card_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_type)) = value;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x0007F428 File Offset: 0x0007D628
		// (set) Token: 0x0600214E RID: 8526 RVA: 0x00014A39 File Offset: 0x00012C39
		public unsafe ushort card_faction_flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_faction_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_faction_flags)) = value;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x0007F450 File Offset: 0x0007D650
		// (set) Token: 0x06002150 RID: 8528 RVA: 0x00014A54 File Offset: 0x00012C54
		public unsafe ushort card_flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_flags)) = value;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x0007F478 File Offset: 0x0007D678
		// (set) Token: 0x06002152 RID: 8530 RVA: 0x00014A6F File Offset: 0x00012C6F
		public unsafe short card_rune_cost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_rune_cost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_rune_cost)) = value;
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06002153 RID: 8531 RVA: 0x0007F4A0 File Offset: 0x0007D6A0
		// (set) Token: 0x06002154 RID: 8532 RVA: 0x00014A8A File Offset: 0x00012C8A
		public unsafe short card_power_cost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_power_cost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_power_cost)) = value;
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06002155 RID: 8533 RVA: 0x0007F4C8 File Offset: 0x0007D6C8
		// (set) Token: 0x06002156 RID: 8534 RVA: 0x00014AA5 File Offset: 0x00012CA5
		public unsafe short card_insight_cost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_insight_cost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_insight_cost)) = value;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06002157 RID: 8535 RVA: 0x0007F4F0 File Offset: 0x0007D6F0
		// (set) Token: 0x06002158 RID: 8536 RVA: 0x00014AC0 File Offset: 0x00012CC0
		public unsafe short card_honor_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_honor_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_honor_value)) = value;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06002159 RID: 8537 RVA: 0x0007F518 File Offset: 0x0007D718
		// (set) Token: 0x0600215A RID: 8538 RVA: 0x00014ADB File Offset: 0x00012CDB
		public unsafe int card_name_hash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_name_hash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_name_hash)) = value;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x0600215B RID: 8539 RVA: 0x0007F540 File Offset: 0x0007D740
		// (set) Token: 0x0600215C RID: 8540 RVA: 0x00014AF6 File Offset: 0x00012CF6
		public unsafe string card_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x0007F568 File Offset: 0x0007D768
		// (set) Token: 0x0600215E RID: 8542 RVA: 0x00014B15 File Offset: 0x00012D15
		public unsafe string display_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_display_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_display_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x0600215F RID: 8543 RVA: 0x0007F590 File Offset: 0x0007D790
		// (set) Token: 0x06002160 RID: 8544 RVA: 0x00014B34 File Offset: 0x00012D34
		public unsafe string card_image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_image);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_image), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06002161 RID: 8545 RVA: 0x0007F5B8 File Offset: 0x0007D7B8
		// (set) Token: 0x06002162 RID: 8546 RVA: 0x00014B53 File Offset: 0x00012D53
		public unsafe string card_type_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_type_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_type_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x0007F5E0 File Offset: 0x0007D7E0
		// (set) Token: 0x06002164 RID: 8548 RVA: 0x00014B72 File Offset: 0x00012D72
		public unsafe string card_effect_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_effect_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_effect_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x0007F608 File Offset: 0x0007D808
		// (set) Token: 0x06002166 RID: 8550 RVA: 0x00014B91 File Offset: 0x00012D91
		public unsafe string card_additional_effect1_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_additional_effect1_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_additional_effect1_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x0007F630 File Offset: 0x0007D830
		// (set) Token: 0x06002168 RID: 8552 RVA: 0x00014BB0 File Offset: 0x00012DB0
		public unsafe string card_additional_effect2_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_additional_effect2_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_additional_effect2_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06002169 RID: 8553 RVA: 0x0007F658 File Offset: 0x0007D858
		// (set) Token: 0x0600216A RID: 8554 RVA: 0x00014BCF File Offset: 0x00012DCF
		public unsafe string card_flavor_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_flavor_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_card_flavor_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400166C RID: 5740
		private static readonly IntPtr NativeFieldInfoPtr_card_instance_id;

		// Token: 0x0400166D RID: 5741
		private static readonly IntPtr NativeFieldInfoPtr_card_set;

		// Token: 0x0400166E RID: 5742
		private static readonly IntPtr NativeFieldInfoPtr_card_rarity_count;

		// Token: 0x0400166F RID: 5743
		private static readonly IntPtr NativeFieldInfoPtr_card_type;

		// Token: 0x04001670 RID: 5744
		private static readonly IntPtr NativeFieldInfoPtr_card_faction_flags;

		// Token: 0x04001671 RID: 5745
		private static readonly IntPtr NativeFieldInfoPtr_card_flags;

		// Token: 0x04001672 RID: 5746
		private static readonly IntPtr NativeFieldInfoPtr_card_rune_cost;

		// Token: 0x04001673 RID: 5747
		private static readonly IntPtr NativeFieldInfoPtr_card_power_cost;

		// Token: 0x04001674 RID: 5748
		private static readonly IntPtr NativeFieldInfoPtr_card_insight_cost;

		// Token: 0x04001675 RID: 5749
		private static readonly IntPtr NativeFieldInfoPtr_card_honor_value;

		// Token: 0x04001676 RID: 5750
		private static readonly IntPtr NativeFieldInfoPtr_card_name_hash;

		// Token: 0x04001677 RID: 5751
		private static readonly IntPtr NativeFieldInfoPtr_card_name;

		// Token: 0x04001678 RID: 5752
		private static readonly IntPtr NativeFieldInfoPtr_display_name;

		// Token: 0x04001679 RID: 5753
		private static readonly IntPtr NativeFieldInfoPtr_card_image;

		// Token: 0x0400167A RID: 5754
		private static readonly IntPtr NativeFieldInfoPtr_card_type_text;

		// Token: 0x0400167B RID: 5755
		private static readonly IntPtr NativeFieldInfoPtr_card_effect_text;

		// Token: 0x0400167C RID: 5756
		private static readonly IntPtr NativeFieldInfoPtr_card_additional_effect1_text;

		// Token: 0x0400167D RID: 5757
		private static readonly IntPtr NativeFieldInfoPtr_card_additional_effect2_text;

		// Token: 0x0400167E RID: 5758
		private static readonly IntPtr NativeFieldInfoPtr_card_flavor_text;
	}
}

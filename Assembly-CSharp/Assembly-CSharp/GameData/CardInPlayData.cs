using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData
{
	// Token: 0x0200012C RID: 300
	public sealed class CardInPlayData : ValueType
	{
		// Token: 0x0600216B RID: 8555 RVA: 0x0007F680 File Offset: 0x0007D880
		// Note: this type is marked as 'beforefieldinit'.
		static CardInPlayData()
		{
			Il2CppClassPointerStore<CardInPlayData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData", "CardInPlayData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardInPlayData>.NativeClassPtr);
			CardInPlayData.NativeFieldInfoPtr_cardinplay_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInPlayData>.NativeClassPtr, "cardinplay_instance_id");
			CardInPlayData.NativeFieldInfoPtr_sourcecard_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInPlayData>.NativeClassPtr, "sourcecard_instance_id");
			CardInPlayData.NativeFieldInfoPtr_undercard_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInPlayData>.NativeClassPtr, "undercard_instance_id");
			CardInPlayData.NativeFieldInfoPtr_ability_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInPlayData>.NativeClassPtr, "ability_count");
			CardInPlayData.NativeFieldInfoPtr_ability_instance_id_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInPlayData>.NativeClassPtr, "ability_instance_id_list");
			CardInPlayData.NativeFieldInfoPtr_needs_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardInPlayData>.NativeClassPtr, "needs_counter");
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x00014BEE File Offset: 0x00012DEE
		public CardInPlayData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x00014BF7 File Offset: 0x00012DF7
		public CardInPlayData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardInPlayData>.NativeClassPtr))
		{
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x0600216E RID: 8558 RVA: 0x0007F728 File Offset: 0x0007D928
		// (set) Token: 0x0600216F RID: 8559 RVA: 0x00014C09 File Offset: 0x00012E09
		public unsafe short cardinplay_instance_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardInPlayData.NativeFieldInfoPtr_cardinplay_instance_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardInPlayData.NativeFieldInfoPtr_cardinplay_instance_id)) = value;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06002170 RID: 8560 RVA: 0x0007F750 File Offset: 0x0007D950
		// (set) Token: 0x06002171 RID: 8561 RVA: 0x00014C24 File Offset: 0x00012E24
		public unsafe short sourcecard_instance_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardInPlayData.NativeFieldInfoPtr_sourcecard_instance_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardInPlayData.NativeFieldInfoPtr_sourcecard_instance_id)) = value;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06002172 RID: 8562 RVA: 0x0007F778 File Offset: 0x0007D978
		// (set) Token: 0x06002173 RID: 8563 RVA: 0x00014C3F File Offset: 0x00012E3F
		public unsafe short undercard_instance_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardInPlayData.NativeFieldInfoPtr_undercard_instance_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardInPlayData.NativeFieldInfoPtr_undercard_instance_id)) = value;
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06002174 RID: 8564 RVA: 0x0007F7A0 File Offset: 0x0007D9A0
		// (set) Token: 0x06002175 RID: 8565 RVA: 0x00014C5A File Offset: 0x00012E5A
		public unsafe short ability_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardInPlayData.NativeFieldInfoPtr_ability_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardInPlayData.NativeFieldInfoPtr_ability_count)) = value;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06002176 RID: 8566 RVA: 0x0007F7C8 File Offset: 0x0007D9C8
		// (set) Token: 0x06002177 RID: 8567 RVA: 0x00014C75 File Offset: 0x00012E75
		public unsafe Il2CppStructArray<short> ability_instance_id_list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardInPlayData.NativeFieldInfoPtr_ability_instance_id_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardInPlayData.NativeFieldInfoPtr_ability_instance_id_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06002178 RID: 8568 RVA: 0x0007F7F8 File Offset: 0x0007D9F8
		// (set) Token: 0x06002179 RID: 8569 RVA: 0x00014C94 File Offset: 0x00012E94
		public unsafe short needs_counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardInPlayData.NativeFieldInfoPtr_needs_counter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardInPlayData.NativeFieldInfoPtr_needs_counter)) = value;
			}
		}

		// Token: 0x0400167F RID: 5759
		private static readonly IntPtr NativeFieldInfoPtr_cardinplay_instance_id;

		// Token: 0x04001680 RID: 5760
		private static readonly IntPtr NativeFieldInfoPtr_sourcecard_instance_id;

		// Token: 0x04001681 RID: 5761
		private static readonly IntPtr NativeFieldInfoPtr_undercard_instance_id;

		// Token: 0x04001682 RID: 5762
		private static readonly IntPtr NativeFieldInfoPtr_ability_count;

		// Token: 0x04001683 RID: 5763
		private static readonly IntPtr NativeFieldInfoPtr_ability_instance_id_list;

		// Token: 0x04001684 RID: 5764
		private static readonly IntPtr NativeFieldInfoPtr_needs_counter;
	}
}

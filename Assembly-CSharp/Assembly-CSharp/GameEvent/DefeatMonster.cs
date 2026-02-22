using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x0200014E RID: 334
	public sealed class DefeatMonster : ValueType
	{
		// Token: 0x0600220D RID: 8717 RVA: 0x00080D5C File Offset: 0x0007EF5C
		// Note: this type is marked as 'beforefieldinit'.
		static DefeatMonster()
		{
			Il2CppClassPointerStore<DefeatMonster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "DefeatMonster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefeatMonster>.NativeClassPtr);
			DefeatMonster.NativeFieldInfoPtr_player_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefeatMonster>.NativeClassPtr, "player_instance_id");
			DefeatMonster.NativeFieldInfoPtr_monster_card_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefeatMonster>.NativeClassPtr, "monster_card_instance_id");
			DefeatMonster.NativeFieldInfoPtr_defeat_from_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefeatMonster>.NativeClassPtr, "defeat_from_location");
			DefeatMonster.NativeFieldInfoPtr_defeat_monster_audio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefeatMonster>.NativeClassPtr, "defeat_monster_audio");
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x000154A8 File Offset: 0x000136A8
		public DefeatMonster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x000154B1 File Offset: 0x000136B1
		public DefeatMonster()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefeatMonster>.NativeClassPtr))
		{
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06002210 RID: 8720 RVA: 0x00080DDC File Offset: 0x0007EFDC
		// (set) Token: 0x06002211 RID: 8721 RVA: 0x000154C3 File Offset: 0x000136C3
		public unsafe int player_instance_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefeatMonster.NativeFieldInfoPtr_player_instance_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefeatMonster.NativeFieldInfoPtr_player_instance_id)) = value;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06002212 RID: 8722 RVA: 0x00080E04 File Offset: 0x0007F004
		// (set) Token: 0x06002213 RID: 8723 RVA: 0x000154DE File Offset: 0x000136DE
		public unsafe int monster_card_instance_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefeatMonster.NativeFieldInfoPtr_monster_card_instance_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefeatMonster.NativeFieldInfoPtr_monster_card_instance_id)) = value;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x00080E2C File Offset: 0x0007F02C
		// (set) Token: 0x06002215 RID: 8725 RVA: 0x000154F9 File Offset: 0x000136F9
		public unsafe int defeat_from_location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefeatMonster.NativeFieldInfoPtr_defeat_from_location);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefeatMonster.NativeFieldInfoPtr_defeat_from_location)) = value;
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x00080E54 File Offset: 0x0007F054
		// (set) Token: 0x06002217 RID: 8727 RVA: 0x00015514 File Offset: 0x00013714
		public unsafe string defeat_monster_audio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefeatMonster.NativeFieldInfoPtr_defeat_monster_audio);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefeatMonster.NativeFieldInfoPtr_defeat_monster_audio), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040017A8 RID: 6056
		private static readonly IntPtr NativeFieldInfoPtr_player_instance_id;

		// Token: 0x040017A9 RID: 6057
		private static readonly IntPtr NativeFieldInfoPtr_monster_card_instance_id;

		// Token: 0x040017AA RID: 6058
		private static readonly IntPtr NativeFieldInfoPtr_defeat_from_location;

		// Token: 0x040017AB RID: 6059
		private static readonly IntPtr NativeFieldInfoPtr_defeat_monster_audio;
	}
}

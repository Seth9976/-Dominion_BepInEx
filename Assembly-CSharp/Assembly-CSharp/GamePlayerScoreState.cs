using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200004F RID: 79
[StructLayout(2)]
public struct GamePlayerScoreState
{
	// Token: 0x06000CC2 RID: 3266 RVA: 0x000400B0 File Offset: 0x0003E2B0
	// Note: this type is marked as 'beforefieldinit'.
	static GamePlayerScoreState()
	{
		Il2CppClassPointerStore<GamePlayerScoreState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GamePlayerScoreState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePlayerScoreState>.NativeClassPtr);
		GamePlayerScoreState.NativeFieldInfoPtr_cultist_kills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerScoreState>.NativeClassPtr, "cultist_kills");
		GamePlayerScoreState.NativeFieldInfoPtr_champ_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerScoreState>.NativeClassPtr, "champ_flags");
		GamePlayerScoreState.NativeFieldInfoPtr_all_day_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerScoreState>.NativeClassPtr, "all_day_cards");
		GamePlayerScoreState.NativeFieldInfoPtr_all_night_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerScoreState>.NativeClassPtr, "all_night_cards");
		GamePlayerScoreState.NativeFieldInfoPtr_award_moken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerScoreState>.NativeClassPtr, "award_moken");
		GamePlayerScoreState.NativeFieldInfoPtr_deck_faction_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerScoreState>.NativeClassPtr, "deck_faction_flags");
		GamePlayerScoreState.NativeFieldInfoPtr_gote_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerScoreState>.NativeClassPtr, "gote_flags");
		GamePlayerScoreState.NativeFieldInfoPtr_all_dreambind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerScoreState>.NativeClassPtr, "all_dreambind");
		GamePlayerScoreState.NativeFieldInfoPtr_deck_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerScoreState>.NativeClassPtr, "deck_count");
	}

	// Token: 0x06000CC3 RID: 3267 RVA: 0x0000992D File Offset: 0x00007B2D
	public Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamePlayerScoreState>.NativeClassPtr, ref this));
	}

	// Token: 0x04000827 RID: 2087
	private static readonly IntPtr NativeFieldInfoPtr_cultist_kills;

	// Token: 0x04000828 RID: 2088
	private static readonly IntPtr NativeFieldInfoPtr_champ_flags;

	// Token: 0x04000829 RID: 2089
	private static readonly IntPtr NativeFieldInfoPtr_all_day_cards;

	// Token: 0x0400082A RID: 2090
	private static readonly IntPtr NativeFieldInfoPtr_all_night_cards;

	// Token: 0x0400082B RID: 2091
	private static readonly IntPtr NativeFieldInfoPtr_award_moken;

	// Token: 0x0400082C RID: 2092
	private static readonly IntPtr NativeFieldInfoPtr_deck_faction_flags;

	// Token: 0x0400082D RID: 2093
	private static readonly IntPtr NativeFieldInfoPtr_gote_flags;

	// Token: 0x0400082E RID: 2094
	private static readonly IntPtr NativeFieldInfoPtr_all_dreambind;

	// Token: 0x0400082F RID: 2095
	private static readonly IntPtr NativeFieldInfoPtr_deck_count;

	// Token: 0x04000830 RID: 2096
	[FieldOffset(0)]
	public uint cultist_kills;

	// Token: 0x04000831 RID: 2097
	[FieldOffset(4)]
	public uint champ_flags;

	// Token: 0x04000832 RID: 2098
	[FieldOffset(8)]
	public int all_day_cards;

	// Token: 0x04000833 RID: 2099
	[FieldOffset(12)]
	public int all_night_cards;

	// Token: 0x04000834 RID: 2100
	[FieldOffset(16)]
	public int award_moken;

	// Token: 0x04000835 RID: 2101
	[FieldOffset(20)]
	public uint deck_faction_flags;

	// Token: 0x04000836 RID: 2102
	[FieldOffset(24)]
	public uint gote_flags;

	// Token: 0x04000837 RID: 2103
	[FieldOffset(28)]
	public uint all_dreambind;

	// Token: 0x04000838 RID: 2104
	[FieldOffset(32)]
	public int deck_count;
}

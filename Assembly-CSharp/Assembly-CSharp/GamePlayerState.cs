using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200004E RID: 78
[StructLayout(2)]
public struct GamePlayerState
{
	// Token: 0x06000CC0 RID: 3264 RVA: 0x0003FF90 File Offset: 0x0003E190
	// Note: this type is marked as 'beforefieldinit'.
	static GamePlayerState()
	{
		Il2CppClassPointerStore<GamePlayerState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GamePlayerState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePlayerState>.NativeClassPtr);
		GamePlayerState.NativeFieldInfoPtr_playerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerState>.NativeClassPtr, "playerIndex");
		GamePlayerState.NativeFieldInfoPtr_playerFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerState>.NativeClassPtr, "playerFlags");
		GamePlayerState.NativeFieldInfoPtr_honorTokenCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerState>.NativeClassPtr, "honorTokenCount");
		GamePlayerState.NativeFieldInfoPtr_handCardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerState>.NativeClassPtr, "handCardCount");
		GamePlayerState.NativeFieldInfoPtr_deckCardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerState>.NativeClassPtr, "deckCardCount");
		GamePlayerState.NativeFieldInfoPtr_discardCardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerState>.NativeClassPtr, "discardCardCount");
		GamePlayerState.NativeFieldInfoPtr_constructCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerState>.NativeClassPtr, "constructCount");
		GamePlayerState.NativeFieldInfoPtr_reputationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerState>.NativeClassPtr, "reputationLevel");
		GamePlayerState.NativeFieldInfoPtr_dreamscapeCardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerState>.NativeClassPtr, "dreamscapeCardCount");
		GamePlayerState.NativeFieldInfoPtr_insightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerState>.NativeClassPtr, "insightCount");
		GamePlayerState.NativeFieldInfoPtr_honor_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerState>.NativeClassPtr, "honor_cards");
		GamePlayerState.NativeFieldInfoPtr_draw_pile_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerState>.NativeClassPtr, "draw_pile_instance_id");
	}

	// Token: 0x06000CC1 RID: 3265 RVA: 0x0000991B File Offset: 0x00007B1B
	public Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamePlayerState>.NativeClassPtr, ref this));
	}

	// Token: 0x0400080F RID: 2063
	private static readonly IntPtr NativeFieldInfoPtr_playerIndex;

	// Token: 0x04000810 RID: 2064
	private static readonly IntPtr NativeFieldInfoPtr_playerFlags;

	// Token: 0x04000811 RID: 2065
	private static readonly IntPtr NativeFieldInfoPtr_honorTokenCount;

	// Token: 0x04000812 RID: 2066
	private static readonly IntPtr NativeFieldInfoPtr_handCardCount;

	// Token: 0x04000813 RID: 2067
	private static readonly IntPtr NativeFieldInfoPtr_deckCardCount;

	// Token: 0x04000814 RID: 2068
	private static readonly IntPtr NativeFieldInfoPtr_discardCardCount;

	// Token: 0x04000815 RID: 2069
	private static readonly IntPtr NativeFieldInfoPtr_constructCount;

	// Token: 0x04000816 RID: 2070
	private static readonly IntPtr NativeFieldInfoPtr_reputationLevel;

	// Token: 0x04000817 RID: 2071
	private static readonly IntPtr NativeFieldInfoPtr_dreamscapeCardCount;

	// Token: 0x04000818 RID: 2072
	private static readonly IntPtr NativeFieldInfoPtr_insightCount;

	// Token: 0x04000819 RID: 2073
	private static readonly IntPtr NativeFieldInfoPtr_honor_cards;

	// Token: 0x0400081A RID: 2074
	private static readonly IntPtr NativeFieldInfoPtr_draw_pile_instance_id;

	// Token: 0x0400081B RID: 2075
	[FieldOffset(0)]
	public uint playerIndex;

	// Token: 0x0400081C RID: 2076
	[FieldOffset(4)]
	public uint playerFlags;

	// Token: 0x0400081D RID: 2077
	[FieldOffset(8)]
	public int honorTokenCount;

	// Token: 0x0400081E RID: 2078
	[FieldOffset(12)]
	public int handCardCount;

	// Token: 0x0400081F RID: 2079
	[FieldOffset(16)]
	public int deckCardCount;

	// Token: 0x04000820 RID: 2080
	[FieldOffset(20)]
	public int discardCardCount;

	// Token: 0x04000821 RID: 2081
	[FieldOffset(24)]
	public int constructCount;

	// Token: 0x04000822 RID: 2082
	[FieldOffset(28)]
	public int reputationLevel;

	// Token: 0x04000823 RID: 2083
	[FieldOffset(32)]
	public int dreamscapeCardCount;

	// Token: 0x04000824 RID: 2084
	[FieldOffset(36)]
	public int insightCount;

	// Token: 0x04000825 RID: 2085
	[FieldOffset(40)]
	public int honor_cards;

	// Token: 0x04000826 RID: 2086
	[FieldOffset(44)]
	public int draw_pile_instance_id;
}

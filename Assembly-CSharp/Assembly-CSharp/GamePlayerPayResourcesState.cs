using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000050 RID: 80
[StructLayout(2)]
public struct GamePlayerPayResourcesState
{
	// Token: 0x06000CC4 RID: 3268 RVA: 0x00040194 File Offset: 0x0003E394
	// Note: this type is marked as 'beforefieldinit'.
	static GamePlayerPayResourcesState()
	{
		Il2CppClassPointerStore<GamePlayerPayResourcesState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GamePlayerPayResourcesState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePlayerPayResourcesState>.NativeClassPtr);
		GamePlayerPayResourcesState.NativeFieldInfoPtr_cardID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerPayResourcesState>.NativeClassPtr, "cardID");
		GamePlayerPayResourcesState.NativeFieldInfoPtr_purchaseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerPayResourcesState>.NativeClassPtr, "purchaseType");
		GamePlayerPayResourcesState.NativeFieldInfoPtr_runeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerPayResourcesState>.NativeClassPtr, "runeFlags");
		GamePlayerPayResourcesState.NativeFieldInfoPtr_powerFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerPayResourcesState>.NativeClassPtr, "powerFlags");
		GamePlayerPayResourcesState.NativeFieldInfoPtr_insightFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerPayResourcesState>.NativeClassPtr, "insightFlags");
		GamePlayerPayResourcesState.NativeFieldInfoPtr_runesNeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerPayResourcesState>.NativeClassPtr, "runesNeeded");
		GamePlayerPayResourcesState.NativeFieldInfoPtr_powerNeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerPayResourcesState>.NativeClassPtr, "powerNeeded");
		GamePlayerPayResourcesState.NativeFieldInfoPtr_insightNeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerPayResourcesState>.NativeClassPtr, "insightNeeded");
		GamePlayerPayResourcesState.NativeFieldInfoPtr_runesMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerPayResourcesState>.NativeClassPtr, "runesMax");
		GamePlayerPayResourcesState.NativeFieldInfoPtr_powerMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerPayResourcesState>.NativeClassPtr, "powerMax");
		GamePlayerPayResourcesState.NativeFieldInfoPtr_insightMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerPayResourcesState>.NativeClassPtr, "insightMax");
	}

	// Token: 0x06000CC5 RID: 3269 RVA: 0x0000993F File Offset: 0x00007B3F
	public Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamePlayerPayResourcesState>.NativeClassPtr, ref this));
	}

	// Token: 0x04000839 RID: 2105
	private static readonly IntPtr NativeFieldInfoPtr_cardID;

	// Token: 0x0400083A RID: 2106
	private static readonly IntPtr NativeFieldInfoPtr_purchaseType;

	// Token: 0x0400083B RID: 2107
	private static readonly IntPtr NativeFieldInfoPtr_runeFlags;

	// Token: 0x0400083C RID: 2108
	private static readonly IntPtr NativeFieldInfoPtr_powerFlags;

	// Token: 0x0400083D RID: 2109
	private static readonly IntPtr NativeFieldInfoPtr_insightFlags;

	// Token: 0x0400083E RID: 2110
	private static readonly IntPtr NativeFieldInfoPtr_runesNeeded;

	// Token: 0x0400083F RID: 2111
	private static readonly IntPtr NativeFieldInfoPtr_powerNeeded;

	// Token: 0x04000840 RID: 2112
	private static readonly IntPtr NativeFieldInfoPtr_insightNeeded;

	// Token: 0x04000841 RID: 2113
	private static readonly IntPtr NativeFieldInfoPtr_runesMax;

	// Token: 0x04000842 RID: 2114
	private static readonly IntPtr NativeFieldInfoPtr_powerMax;

	// Token: 0x04000843 RID: 2115
	private static readonly IntPtr NativeFieldInfoPtr_insightMax;

	// Token: 0x04000844 RID: 2116
	[FieldOffset(0)]
	public int cardID;

	// Token: 0x04000845 RID: 2117
	[FieldOffset(4)]
	public int purchaseType;

	// Token: 0x04000846 RID: 2118
	[FieldOffset(8)]
	public int runeFlags;

	// Token: 0x04000847 RID: 2119
	[FieldOffset(12)]
	public int powerFlags;

	// Token: 0x04000848 RID: 2120
	[FieldOffset(16)]
	public int insightFlags;

	// Token: 0x04000849 RID: 2121
	[FieldOffset(20)]
	public int runesNeeded;

	// Token: 0x0400084A RID: 2122
	[FieldOffset(24)]
	public int powerNeeded;

	// Token: 0x0400084B RID: 2123
	[FieldOffset(28)]
	public int insightNeeded;

	// Token: 0x0400084C RID: 2124
	[FieldOffset(32)]
	public int runesMax;

	// Token: 0x0400084D RID: 2125
	[FieldOffset(36)]
	public int powerMax;

	// Token: 0x0400084E RID: 2126
	[FieldOffset(40)]
	public int insightMax;
}

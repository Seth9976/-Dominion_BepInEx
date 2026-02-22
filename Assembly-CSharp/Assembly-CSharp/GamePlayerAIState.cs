using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000053 RID: 83
[StructLayout(2)]
public struct GamePlayerAIState
{
	// Token: 0x06000CD5 RID: 3285 RVA: 0x00040494 File Offset: 0x0003E694
	// Note: this type is marked as 'beforefieldinit'.
	static GamePlayerAIState()
	{
		Il2CppClassPointerStore<GamePlayerAIState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GamePlayerAIState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePlayerAIState>.NativeClassPtr);
		GamePlayerAIState.NativeFieldInfoPtr_userID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerAIState>.NativeClassPtr, "userID");
		GamePlayerAIState.NativeFieldInfoPtr_isAIPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerAIState>.NativeClassPtr, "isAIPlayer");
		GamePlayerAIState.NativeFieldInfoPtr_isAIThinking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerAIState>.NativeClassPtr, "isAIThinking");
		GamePlayerAIState.NativeFieldInfoPtr_aiThinkingPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerAIState>.NativeClassPtr, "aiThinkingPercentage");
	}

	// Token: 0x06000CD6 RID: 3286 RVA: 0x00009A11 File Offset: 0x00007C11
	public Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamePlayerAIState>.NativeClassPtr, ref this));
	}

	// Token: 0x0400085C RID: 2140
	private static readonly IntPtr NativeFieldInfoPtr_userID;

	// Token: 0x0400085D RID: 2141
	private static readonly IntPtr NativeFieldInfoPtr_isAIPlayer;

	// Token: 0x0400085E RID: 2142
	private static readonly IntPtr NativeFieldInfoPtr_isAIThinking;

	// Token: 0x0400085F RID: 2143
	private static readonly IntPtr NativeFieldInfoPtr_aiThinkingPercentage;

	// Token: 0x04000860 RID: 2144
	[FieldOffset(0)]
	public uint userID;

	// Token: 0x04000861 RID: 2145
	[FieldOffset(4)]
	public ushort isAIPlayer;

	// Token: 0x04000862 RID: 2146
	[FieldOffset(6)]
	public ushort isAIThinking;

	// Token: 0x04000863 RID: 2147
	[FieldOffset(8)]
	public float aiThinkingPercentage;
}

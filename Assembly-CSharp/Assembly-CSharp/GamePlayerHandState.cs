using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000052 RID: 82
[StructLayout(2)]
public struct GamePlayerHandState
{
	// Token: 0x06000CD3 RID: 3283 RVA: 0x00040414 File Offset: 0x0003E614
	// Note: this type is marked as 'beforefieldinit'.
	static GamePlayerHandState()
	{
		Il2CppClassPointerStore<GamePlayerHandState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GamePlayerHandState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePlayerHandState>.NativeClassPtr);
		GamePlayerHandState.NativeFieldInfoPtr_userID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerHandState>.NativeClassPtr, "userID");
		GamePlayerHandState.NativeFieldInfoPtr_handCardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerHandState>.NativeClassPtr, "handCardCount");
		GamePlayerHandState.NativeFieldInfoPtr_chinaCardFaceUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerHandState>.NativeClassPtr, "chinaCardFaceUp");
		GamePlayerHandState.NativeFieldInfoPtr_chinaCardFaceDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerHandState>.NativeClassPtr, "chinaCardFaceDown");
	}

	// Token: 0x06000CD4 RID: 3284 RVA: 0x000099FF File Offset: 0x00007BFF
	public Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamePlayerHandState>.NativeClassPtr, ref this));
	}

	// Token: 0x04000854 RID: 2132
	private static readonly IntPtr NativeFieldInfoPtr_userID;

	// Token: 0x04000855 RID: 2133
	private static readonly IntPtr NativeFieldInfoPtr_handCardCount;

	// Token: 0x04000856 RID: 2134
	private static readonly IntPtr NativeFieldInfoPtr_chinaCardFaceUp;

	// Token: 0x04000857 RID: 2135
	private static readonly IntPtr NativeFieldInfoPtr_chinaCardFaceDown;

	// Token: 0x04000858 RID: 2136
	[FieldOffset(0)]
	public uint userID;

	// Token: 0x04000859 RID: 2137
	[FieldOffset(4)]
	public ushort handCardCount;

	// Token: 0x0400085A RID: 2138
	[FieldOffset(6)]
	public ushort chinaCardFaceUp;

	// Token: 0x0400085B RID: 2139
	[FieldOffset(8)]
	public ushort chinaCardFaceDown;
}

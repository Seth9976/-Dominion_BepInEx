using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200004D RID: 77
[StructLayout(2)]
public struct GamePlayerTimer
{
	// Token: 0x06000CBE RID: 3262 RVA: 0x0003FEFC File Offset: 0x0003E0FC
	// Note: this type is marked as 'beforefieldinit'.
	static GamePlayerTimer()
	{
		Il2CppClassPointerStore<GamePlayerTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GamePlayerTimer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePlayerTimer>.NativeClassPtr);
		GamePlayerTimer.NativeFieldInfoPtr_userID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerTimer>.NativeClassPtr, "userID");
		GamePlayerTimer.NativeFieldInfoPtr_timerHours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerTimer>.NativeClassPtr, "timerHours");
		GamePlayerTimer.NativeFieldInfoPtr_timerMinutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerTimer>.NativeClassPtr, "timerMinutes");
		GamePlayerTimer.NativeFieldInfoPtr_timerSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerTimer>.NativeClassPtr, "timerSeconds");
		GamePlayerTimer.NativeFieldInfoPtr_timerIsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerTimer>.NativeClassPtr, "timerIsActive");
	}

	// Token: 0x06000CBF RID: 3263 RVA: 0x00009909 File Offset: 0x00007B09
	public Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamePlayerTimer>.NativeClassPtr, ref this));
	}

	// Token: 0x04000805 RID: 2053
	private static readonly IntPtr NativeFieldInfoPtr_userID;

	// Token: 0x04000806 RID: 2054
	private static readonly IntPtr NativeFieldInfoPtr_timerHours;

	// Token: 0x04000807 RID: 2055
	private static readonly IntPtr NativeFieldInfoPtr_timerMinutes;

	// Token: 0x04000808 RID: 2056
	private static readonly IntPtr NativeFieldInfoPtr_timerSeconds;

	// Token: 0x04000809 RID: 2057
	private static readonly IntPtr NativeFieldInfoPtr_timerIsActive;

	// Token: 0x0400080A RID: 2058
	[FieldOffset(0)]
	public uint userID;

	// Token: 0x0400080B RID: 2059
	[FieldOffset(4)]
	public ushort timerHours;

	// Token: 0x0400080C RID: 2060
	[FieldOffset(6)]
	public ushort timerMinutes;

	// Token: 0x0400080D RID: 2061
	[FieldOffset(8)]
	public ushort timerSeconds;

	// Token: 0x0400080E RID: 2062
	[FieldOffset(10)]
	public ushort timerIsActive;
}

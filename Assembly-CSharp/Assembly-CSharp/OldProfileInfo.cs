using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200005B RID: 91
[StructLayout(2)]
public struct OldProfileInfo
{
	// Token: 0x06000CE1 RID: 3297 RVA: 0x000407BC File Offset: 0x0003E9BC
	// Note: this type is marked as 'beforefieldinit'.
	static OldProfileInfo()
	{
		Il2CppClassPointerStore<OldProfileInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "OldProfileInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OldProfileInfo>.NativeClassPtr);
		OldProfileInfo.NativeFieldInfoPtr_music = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OldProfileInfo>.NativeClassPtr, "music");
		OldProfileInfo.NativeFieldInfoPtr_soundEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OldProfileInfo>.NativeClassPtr, "soundEffects");
		OldProfileInfo.NativeFieldInfoPtr_cultistScreams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OldProfileInfo>.NativeClassPtr, "cultistScreams");
		OldProfileInfo.NativeFieldInfoPtr_gameSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OldProfileInfo>.NativeClassPtr, "gameSpeed");
		OldProfileInfo.NativeFieldInfoPtr_animationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OldProfileInfo>.NativeClassPtr, "animationSpeed");
		OldProfileInfo.NativeFieldInfoPtr_currentTheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OldProfileInfo>.NativeClassPtr, "currentTheme");
	}

	// Token: 0x06000CE2 RID: 3298 RVA: 0x00009A7D File Offset: 0x00007C7D
	public Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OldProfileInfo>.NativeClassPtr, ref this));
	}

	// Token: 0x040008A8 RID: 2216
	private static readonly IntPtr NativeFieldInfoPtr_music;

	// Token: 0x040008A9 RID: 2217
	private static readonly IntPtr NativeFieldInfoPtr_soundEffects;

	// Token: 0x040008AA RID: 2218
	private static readonly IntPtr NativeFieldInfoPtr_cultistScreams;

	// Token: 0x040008AB RID: 2219
	private static readonly IntPtr NativeFieldInfoPtr_gameSpeed;

	// Token: 0x040008AC RID: 2220
	private static readonly IntPtr NativeFieldInfoPtr_animationSpeed;

	// Token: 0x040008AD RID: 2221
	private static readonly IntPtr NativeFieldInfoPtr_currentTheme;

	// Token: 0x040008AE RID: 2222
	[FieldOffset(0)]
	public int music;

	// Token: 0x040008AF RID: 2223
	[FieldOffset(4)]
	public int soundEffects;

	// Token: 0x040008B0 RID: 2224
	[FieldOffset(8)]
	public int cultistScreams;

	// Token: 0x040008B1 RID: 2225
	[FieldOffset(12)]
	public int gameSpeed;

	// Token: 0x040008B2 RID: 2226
	[FieldOffset(16)]
	public int animationSpeed;

	// Token: 0x040008B3 RID: 2227
	[FieldOffset(20)]
	public int currentTheme;
}

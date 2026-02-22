using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000055 RID: 85
[StructLayout(2)]
public struct GamePlayerParameters
{
	// Token: 0x06000CD9 RID: 3289 RVA: 0x0004060C File Offset: 0x0003E80C
	// Note: this type is marked as 'beforefieldinit'.
	static GamePlayerParameters()
	{
		Il2CppClassPointerStore<GamePlayerParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GamePlayerParameters");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePlayerParameters>.NativeClassPtr);
		GamePlayerParameters.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerParameters>.NativeClassPtr, "avatar");
		GamePlayerParameters.NativeFieldInfoPtr_avatarColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePlayerParameters>.NativeClassPtr, "avatarColorIndex");
	}

	// Token: 0x06000CDA RID: 3290 RVA: 0x00009A35 File Offset: 0x00007C35
	public Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamePlayerParameters>.NativeClassPtr, ref this));
	}

	// Token: 0x04000878 RID: 2168
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x04000879 RID: 2169
	private static readonly IntPtr NativeFieldInfoPtr_avatarColorIndex;

	// Token: 0x0400087A RID: 2170
	[FieldOffset(0)]
	public byte avatar;

	// Token: 0x0400087B RID: 2171
	[FieldOffset(1)]
	public byte avatarColorIndex;
}

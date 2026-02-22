using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000059 RID: 89
[Serializable]
[StructLayout(2)]
public struct PlayerParameters
{
	// Token: 0x06000CDD RID: 3293 RVA: 0x000406D0 File Offset: 0x0003E8D0
	// Note: this type is marked as 'beforefieldinit'.
	static PlayerParameters()
	{
		Il2CppClassPointerStore<PlayerParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PlayerParameters");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerParameters>.NativeClassPtr);
		PlayerParameters.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerParameters>.NativeClassPtr, "avatar");
		PlayerParameters.NativeFieldInfoPtr_avatarColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerParameters>.NativeClassPtr, "avatarColorIndex");
	}

	// Token: 0x06000CDE RID: 3294 RVA: 0x00009A59 File Offset: 0x00007C59
	public Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerParameters>.NativeClassPtr, ref this));
	}

	// Token: 0x0400089A RID: 2202
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x0400089B RID: 2203
	private static readonly IntPtr NativeFieldInfoPtr_avatarColorIndex;

	// Token: 0x0400089C RID: 2204
	[FieldOffset(0)]
	public byte avatar;

	// Token: 0x0400089D RID: 2205
	[FieldOffset(1)]
	public byte avatarColorIndex;
}

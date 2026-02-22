using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000058 RID: 88
[StructLayout(2)]
public struct GameParameters
{
	// Token: 0x06000CDB RID: 3291 RVA: 0x00040664 File Offset: 0x0003E864
	// Note: this type is marked as 'beforefieldinit'.
	static GameParameters()
	{
		Il2CppClassPointerStore<GameParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GameParameters");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameParameters>.NativeClassPtr);
		GameParameters.NativeFieldInfoPtr_setFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameParameters>.NativeClassPtr, "setFlags");
		GameParameters.NativeFieldInfoPtr_promoFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameParameters>.NativeClassPtr, "promoFlags");
		GameParameters.NativeFieldInfoPtr_honorPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameParameters>.NativeClassPtr, "honorPool");
	}

	// Token: 0x06000CDC RID: 3292 RVA: 0x00009A47 File Offset: 0x00007C47
	public Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameParameters>.NativeClassPtr, ref this));
	}

	// Token: 0x04000894 RID: 2196
	private static readonly IntPtr NativeFieldInfoPtr_setFlags;

	// Token: 0x04000895 RID: 2197
	private static readonly IntPtr NativeFieldInfoPtr_promoFlags;

	// Token: 0x04000896 RID: 2198
	private static readonly IntPtr NativeFieldInfoPtr_honorPool;

	// Token: 0x04000897 RID: 2199
	[FieldOffset(0)]
	public ushort setFlags;

	// Token: 0x04000898 RID: 2200
	[FieldOffset(2)]
	public ushort promoFlags;

	// Token: 0x04000899 RID: 2201
	[FieldOffset(4)]
	public ushort honorPool;
}

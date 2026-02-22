using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000067 RID: 103
[StructLayout(2)]
public struct NetworkGameResultPlayerData
{
	// Token: 0x06000DC0 RID: 3520 RVA: 0x00041DDC File Offset: 0x0003FFDC
	// Note: this type is marked as 'beforefieldinit'.
	static NetworkGameResultPlayerData()
	{
		Il2CppClassPointerStore<NetworkGameResultPlayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NetworkGameResultPlayerData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkGameResultPlayerData>.NativeClassPtr);
		NetworkGameResultPlayerData.NativeFieldInfoPtr_userID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkGameResultPlayerData>.NativeClassPtr, "userID");
		NetworkGameResultPlayerData.NativeFieldInfoPtr_finishPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkGameResultPlayerData>.NativeClassPtr, "finishPosition");
		NetworkGameResultPlayerData.NativeFieldInfoPtr_initialRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkGameResultPlayerData>.NativeClassPtr, "initialRating");
		NetworkGameResultPlayerData.NativeFieldInfoPtr_updatedRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkGameResultPlayerData>.NativeClassPtr, "updatedRating");
	}

	// Token: 0x06000DC1 RID: 3521 RVA: 0x0000A142 File Offset: 0x00008342
	public Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkGameResultPlayerData>.NativeClassPtr, ref this));
	}

	// Token: 0x04000964 RID: 2404
	private static readonly IntPtr NativeFieldInfoPtr_userID;

	// Token: 0x04000965 RID: 2405
	private static readonly IntPtr NativeFieldInfoPtr_finishPosition;

	// Token: 0x04000966 RID: 2406
	private static readonly IntPtr NativeFieldInfoPtr_initialRating;

	// Token: 0x04000967 RID: 2407
	private static readonly IntPtr NativeFieldInfoPtr_updatedRating;

	// Token: 0x04000968 RID: 2408
	[FieldOffset(0)]
	public uint userID;

	// Token: 0x04000969 RID: 2409
	[FieldOffset(4)]
	public uint finishPosition;

	// Token: 0x0400096A RID: 2410
	[FieldOffset(8)]
	public uint initialRating;

	// Token: 0x0400096B RID: 2411
	[FieldOffset(12)]
	public uint updatedRating;
}

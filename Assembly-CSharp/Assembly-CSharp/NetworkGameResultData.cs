using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000068 RID: 104
public sealed class NetworkGameResultData : ValueType
{
	// Token: 0x06000DC2 RID: 3522 RVA: 0x0000A154 File Offset: 0x00008354
	// Note: this type is marked as 'beforefieldinit'.
	static NetworkGameResultData()
	{
		Il2CppClassPointerStore<NetworkGameResultData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NetworkGameResultData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkGameResultData>.NativeClassPtr);
		NetworkGameResultData.NativeFieldInfoPtr_result_player_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkGameResultData>.NativeClassPtr, "result_player_data");
	}

	// Token: 0x06000DC3 RID: 3523 RVA: 0x0000A18D File Offset: 0x0000838D
	public NetworkGameResultData(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x06000DC4 RID: 3524 RVA: 0x0000A196 File Offset: 0x00008396
	public NetworkGameResultData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkGameResultData>.NativeClassPtr))
	{
	}

	// Token: 0x170004B6 RID: 1206
	// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x00041E5C File Offset: 0x0004005C
	// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x0000A1A8 File Offset: 0x000083A8
	public unsafe Il2CppStructArray<NetworkGameResultPlayerData> result_player_data
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkGameResultData.NativeFieldInfoPtr_result_player_data);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<NetworkGameResultPlayerData>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkGameResultData.NativeFieldInfoPtr_result_player_data), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400096C RID: 2412
	private static readonly IntPtr NativeFieldInfoPtr_result_player_data;
}

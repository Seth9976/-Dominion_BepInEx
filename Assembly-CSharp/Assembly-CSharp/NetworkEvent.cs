using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000066 RID: 102
[StructLayout(2)]
public struct NetworkEvent
{
	// Token: 0x06000DBE RID: 3518 RVA: 0x00041D84 File Offset: 0x0003FF84
	// Note: this type is marked as 'beforefieldinit'.
	static NetworkEvent()
	{
		Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NetworkEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr);
		NetworkEvent.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr, "type");
		NetworkEvent.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr, "data");
	}

	// Token: 0x06000DBF RID: 3519 RVA: 0x0000A130 File Offset: 0x00008330
	public Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr, ref this));
	}

	// Token: 0x04000960 RID: 2400
	private static readonly IntPtr NativeFieldInfoPtr_type;

	// Token: 0x04000961 RID: 2401
	private static readonly IntPtr NativeFieldInfoPtr_data;

	// Token: 0x04000962 RID: 2402
	[FieldOffset(0)]
	public int type;

	// Token: 0x04000963 RID: 2403
	[FieldOffset(4)]
	public int data;

	// Token: 0x02000186 RID: 390
	public enum EventType
	{
		// Token: 0x040018EB RID: 6379
		Event_LoginInitiated = 1,
		// Token: 0x040018EC RID: 6380
		Event_LoginComplete,
		// Token: 0x040018ED RID: 6381
		Event_LoginError,
		// Token: 0x040018EE RID: 6382
		Event_CreateAccountReply,
		// Token: 0x040018EF RID: 6383
		Event_AvailableGamesRefreshed,
		// Token: 0x040018F0 RID: 6384
		Event_UpdatedGameList,
		// Token: 0x040018F1 RID: 6385
		Event_ConnectionLost,
		// Token: 0x040018F2 RID: 6386
		Event_CreateGameReply,
		// Token: 0x040018F3 RID: 6387
		Event_JoinGameReply,
		// Token: 0x040018F4 RID: 6388
		Event_MatchmakingReply,
		// Token: 0x040018F5 RID: 6389
		Event_FriendRequestReply,
		// Token: 0x040018F6 RID: 6390
		Event_UpdatedMatchmakingList,
		// Token: 0x040018F7 RID: 6391
		Event_UpdatedPlayerProfile,
		// Token: 0x040018F8 RID: 6392
		Event_UpdatedOnlineStatus,
		// Token: 0x040018F9 RID: 6393
		Event_UpdatedFriendsList,
		// Token: 0x040018FA RID: 6394
		Event_DeletedActiveGame,
		// Token: 0x040018FB RID: 6395
		Event_UnlockContent,
		// Token: 0x040018FC RID: 6396
		Event_VerifyAccount,
		// Token: 0x040018FD RID: 6397
		Event_LinkAccount
	}
}

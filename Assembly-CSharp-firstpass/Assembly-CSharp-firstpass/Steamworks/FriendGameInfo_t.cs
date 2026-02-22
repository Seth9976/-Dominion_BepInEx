using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002A8 RID: 680
	[StructLayout(2)]
	public struct FriendGameInfo_t
	{
		// Token: 0x0600273A RID: 10042 RVA: 0x000ABC3C File Offset: 0x000A9E3C
		// Note: this type is marked as 'beforefieldinit'.
		static FriendGameInfo_t()
		{
			Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FriendGameInfo_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr);
			FriendGameInfo_t.NativeFieldInfoPtr_m_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr, "m_gameID");
			FriendGameInfo_t.NativeFieldInfoPtr_m_unGameIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr, "m_unGameIP");
			FriendGameInfo_t.NativeFieldInfoPtr_m_usGamePort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr, "m_usGamePort");
			FriendGameInfo_t.NativeFieldInfoPtr_m_usQueryPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr, "m_usQueryPort");
			FriendGameInfo_t.NativeFieldInfoPtr_m_steamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr, "m_steamIDLobby");
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x0000FA84 File Offset: 0x0000DC84
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendGameInfo_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04002656 RID: 9814
		private static readonly IntPtr NativeFieldInfoPtr_m_gameID;

		// Token: 0x04002657 RID: 9815
		private static readonly IntPtr NativeFieldInfoPtr_m_unGameIP;

		// Token: 0x04002658 RID: 9816
		private static readonly IntPtr NativeFieldInfoPtr_m_usGamePort;

		// Token: 0x04002659 RID: 9817
		private static readonly IntPtr NativeFieldInfoPtr_m_usQueryPort;

		// Token: 0x0400265A RID: 9818
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDLobby;

		// Token: 0x0400265B RID: 9819
		[FieldOffset(0)]
		public CGameID m_gameID;

		// Token: 0x0400265C RID: 9820
		[FieldOffset(8)]
		public uint m_unGameIP;

		// Token: 0x0400265D RID: 9821
		[FieldOffset(12)]
		public ushort m_usGamePort;

		// Token: 0x0400265E RID: 9822
		[FieldOffset(14)]
		public ushort m_usQueryPort;

		// Token: 0x0400265F RID: 9823
		[FieldOffset(16)]
		public CSteamID m_steamIDLobby;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001C9 RID: 457
	[StructLayout(2)]
	public struct RequestPlayersForGameResultCallback_t
	{
		// Token: 0x060022C5 RID: 8901 RVA: 0x000A3A3C File Offset: 0x000A1C3C
		// Note: this type is marked as 'beforefieldinit'.
		static RequestPlayersForGameResultCallback_t()
		{
			Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RequestPlayersForGameResultCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr);
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "k_iCallback");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "m_eResult");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_m_ullSearchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "m_ullSearchID");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_m_SteamIDPlayerFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "m_SteamIDPlayerFound");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_m_SteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "m_SteamIDLobby");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_m_ePlayerAcceptState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "m_ePlayerAcceptState");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_m_nPlayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "m_nPlayerIndex");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_m_nTotalPlayersFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "m_nTotalPlayersFound");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_m_nTotalPlayersAcceptedGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "m_nTotalPlayersAcceptedGame");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_m_nSuggestedTeamIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "m_nSuggestedTeamIndex");
			RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_m_ullUniqueGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, "m_ullUniqueGameID");
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x0000CFF9 File Offset: 0x0000B1F9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RequestPlayersForGameResultCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x000A3B48 File Offset: 0x000A1D48
		// (set) Token: 0x060022C8 RID: 8904 RVA: 0x0000D00B File Offset: 0x0000B20B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RequestPlayersForGameResultCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C99 RID: 7321
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C9A RID: 7322
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001C9B RID: 7323
		private static readonly IntPtr NativeFieldInfoPtr_m_ullSearchID;

		// Token: 0x04001C9C RID: 7324
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamIDPlayerFound;

		// Token: 0x04001C9D RID: 7325
		private static readonly IntPtr NativeFieldInfoPtr_m_SteamIDLobby;

		// Token: 0x04001C9E RID: 7326
		private static readonly IntPtr NativeFieldInfoPtr_m_ePlayerAcceptState;

		// Token: 0x04001C9F RID: 7327
		private static readonly IntPtr NativeFieldInfoPtr_m_nPlayerIndex;

		// Token: 0x04001CA0 RID: 7328
		private static readonly IntPtr NativeFieldInfoPtr_m_nTotalPlayersFound;

		// Token: 0x04001CA1 RID: 7329
		private static readonly IntPtr NativeFieldInfoPtr_m_nTotalPlayersAcceptedGame;

		// Token: 0x04001CA2 RID: 7330
		private static readonly IntPtr NativeFieldInfoPtr_m_nSuggestedTeamIndex;

		// Token: 0x04001CA3 RID: 7331
		private static readonly IntPtr NativeFieldInfoPtr_m_ullUniqueGameID;

		// Token: 0x04001CA4 RID: 7332
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001CA5 RID: 7333
		[FieldOffset(8)]
		public ulong m_ullSearchID;

		// Token: 0x04001CA6 RID: 7334
		[FieldOffset(16)]
		public CSteamID m_SteamIDPlayerFound;

		// Token: 0x04001CA7 RID: 7335
		[FieldOffset(24)]
		public CSteamID m_SteamIDLobby;

		// Token: 0x04001CA8 RID: 7336
		[FieldOffset(32)]
		public PlayerAcceptState_t m_ePlayerAcceptState;

		// Token: 0x04001CA9 RID: 7337
		[FieldOffset(36)]
		public int m_nPlayerIndex;

		// Token: 0x04001CAA RID: 7338
		[FieldOffset(40)]
		public int m_nTotalPlayersFound;

		// Token: 0x04001CAB RID: 7339
		[FieldOffset(44)]
		public int m_nTotalPlayersAcceptedGame;

		// Token: 0x04001CAC RID: 7340
		[FieldOffset(48)]
		public int m_nSuggestedTeamIndex;

		// Token: 0x04001CAD RID: 7341
		[FieldOffset(56)]
		public ulong m_ullUniqueGameID;
	}
}

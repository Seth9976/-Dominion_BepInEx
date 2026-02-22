using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001BC RID: 444
	[StructLayout(2)]
	public struct LobbyInvite_t
	{
		// Token: 0x06002291 RID: 8849 RVA: 0x000A3200 File Offset: 0x000A1400
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyInvite_t()
		{
			Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LobbyInvite_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr);
			LobbyInvite_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr, "k_iCallback");
			LobbyInvite_t.NativeFieldInfoPtr_m_ulSteamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr, "m_ulSteamIDUser");
			LobbyInvite_t.NativeFieldInfoPtr_m_ulSteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr, "m_ulSteamIDLobby");
			LobbyInvite_t.NativeFieldInfoPtr_m_ulGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr, "m_ulGameID");
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x0000CE59 File Offset: 0x0000B059
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyInvite_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06002293 RID: 8851 RVA: 0x000A3280 File Offset: 0x000A1480
		// (set) Token: 0x06002294 RID: 8852 RVA: 0x0000CE6B File Offset: 0x0000B06B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyInvite_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyInvite_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C36 RID: 7222
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C37 RID: 7223
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDUser;

		// Token: 0x04001C38 RID: 7224
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDLobby;

		// Token: 0x04001C39 RID: 7225
		private static readonly IntPtr NativeFieldInfoPtr_m_ulGameID;

		// Token: 0x04001C3A RID: 7226
		[FieldOffset(0)]
		public ulong m_ulSteamIDUser;

		// Token: 0x04001C3B RID: 7227
		[FieldOffset(8)]
		public ulong m_ulSteamIDLobby;

		// Token: 0x04001C3C RID: 7228
		[FieldOffset(16)]
		public ulong m_ulGameID;
	}
}

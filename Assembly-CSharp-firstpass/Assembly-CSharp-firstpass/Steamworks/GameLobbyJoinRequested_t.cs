using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200017B RID: 379
	[StructLayout(2)]
	public struct GameLobbyJoinRequested_t
	{
		// Token: 0x060020FA RID: 8442 RVA: 0x0009FED0 File Offset: 0x0009E0D0
		// Note: this type is marked as 'beforefieldinit'.
		static GameLobbyJoinRequested_t()
		{
			Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GameLobbyJoinRequested_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr);
			GameLobbyJoinRequested_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr, "k_iCallback");
			GameLobbyJoinRequested_t.NativeFieldInfoPtr_m_steamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr, "m_steamIDLobby");
			GameLobbyJoinRequested_t.NativeFieldInfoPtr_m_steamIDFriend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr, "m_steamIDFriend");
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x0000BE46 File Offset: 0x0000A046
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameLobbyJoinRequested_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x0009FF3C File Offset: 0x0009E13C
		// (set) Token: 0x060020FD RID: 8445 RVA: 0x0000BE58 File Offset: 0x0000A058
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameLobbyJoinRequested_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameLobbyJoinRequested_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001AAA RID: 6826
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001AAB RID: 6827
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDLobby;

		// Token: 0x04001AAC RID: 6828
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDFriend;

		// Token: 0x04001AAD RID: 6829
		[FieldOffset(0)]
		public CSteamID m_steamIDLobby;

		// Token: 0x04001AAE RID: 6830
		[FieldOffset(8)]
		public CSteamID m_steamIDFriend;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000181 RID: 385
	[StructLayout(2)]
	public struct GameConnectedChatJoin_t
	{
		// Token: 0x06002119 RID: 8473 RVA: 0x000A0354 File Offset: 0x0009E554
		// Note: this type is marked as 'beforefieldinit'.
		static GameConnectedChatJoin_t()
		{
			Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GameConnectedChatJoin_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr);
			GameConnectedChatJoin_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr, "k_iCallback");
			GameConnectedChatJoin_t.NativeFieldInfoPtr_m_steamIDClanChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr, "m_steamIDClanChat");
			GameConnectedChatJoin_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr, "m_steamIDUser");
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x0000BF49 File Offset: 0x0000A149
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameConnectedChatJoin_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x0600211B RID: 8475 RVA: 0x000A03C0 File Offset: 0x0009E5C0
		// (set) Token: 0x0600211C RID: 8476 RVA: 0x0000BF5B File Offset: 0x0000A15B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameConnectedChatJoin_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameConnectedChatJoin_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001AD0 RID: 6864
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001AD1 RID: 6865
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDClanChat;

		// Token: 0x04001AD2 RID: 6866
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x04001AD3 RID: 6867
		[FieldOffset(0)]
		public CSteamID m_steamIDClanChat;

		// Token: 0x04001AD4 RID: 6868
		[FieldOffset(8)]
		public CSteamID m_steamIDUser;
	}
}

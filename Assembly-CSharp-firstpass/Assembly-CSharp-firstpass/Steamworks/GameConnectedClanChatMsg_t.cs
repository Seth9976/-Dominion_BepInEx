using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000180 RID: 384
	[StructLayout(2)]
	public struct GameConnectedClanChatMsg_t
	{
		// Token: 0x06002115 RID: 8469 RVA: 0x000A02B8 File Offset: 0x0009E4B8
		// Note: this type is marked as 'beforefieldinit'.
		static GameConnectedClanChatMsg_t()
		{
			Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GameConnectedClanChatMsg_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr);
			GameConnectedClanChatMsg_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr, "k_iCallback");
			GameConnectedClanChatMsg_t.NativeFieldInfoPtr_m_steamIDClanChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr, "m_steamIDClanChat");
			GameConnectedClanChatMsg_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr, "m_steamIDUser");
			GameConnectedClanChatMsg_t.NativeFieldInfoPtr_m_iMessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr, "m_iMessageID");
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x0000BF29 File Offset: 0x0000A129
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameConnectedClanChatMsg_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06002117 RID: 8471 RVA: 0x000A0338 File Offset: 0x0009E538
		// (set) Token: 0x06002118 RID: 8472 RVA: 0x0000BF3B File Offset: 0x0000A13B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameConnectedClanChatMsg_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameConnectedClanChatMsg_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001AC9 RID: 6857
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001ACA RID: 6858
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDClanChat;

		// Token: 0x04001ACB RID: 6859
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x04001ACC RID: 6860
		private static readonly IntPtr NativeFieldInfoPtr_m_iMessageID;

		// Token: 0x04001ACD RID: 6861
		[FieldOffset(0)]
		public CSteamID m_steamIDClanChat;

		// Token: 0x04001ACE RID: 6862
		[FieldOffset(8)]
		public CSteamID m_steamIDUser;

		// Token: 0x04001ACF RID: 6863
		[FieldOffset(16)]
		public int m_iMessageID;
	}
}

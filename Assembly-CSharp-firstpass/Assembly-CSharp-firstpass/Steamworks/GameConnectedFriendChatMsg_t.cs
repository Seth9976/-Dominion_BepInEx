using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000185 RID: 389
	[StructLayout(2)]
	public struct GameConnectedFriendChatMsg_t
	{
		// Token: 0x06002129 RID: 8489 RVA: 0x000A0588 File Offset: 0x0009E788
		// Note: this type is marked as 'beforefieldinit'.
		static GameConnectedFriendChatMsg_t()
		{
			Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GameConnectedFriendChatMsg_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr);
			GameConnectedFriendChatMsg_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr, "k_iCallback");
			GameConnectedFriendChatMsg_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr, "m_steamIDUser");
			GameConnectedFriendChatMsg_t.NativeFieldInfoPtr_m_iMessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr, "m_iMessageID");
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x0000BFC9 File Offset: 0x0000A1C9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameConnectedFriendChatMsg_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600212B RID: 8491 RVA: 0x000A05F4 File Offset: 0x0009E7F4
		// (set) Token: 0x0600212C RID: 8492 RVA: 0x0000BFDB File Offset: 0x0000A1DB
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameConnectedFriendChatMsg_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameConnectedFriendChatMsg_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001AE6 RID: 6886
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001AE7 RID: 6887
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x04001AE8 RID: 6888
		private static readonly IntPtr NativeFieldInfoPtr_m_iMessageID;

		// Token: 0x04001AE9 RID: 6889
		[FieldOffset(0)]
		public CSteamID m_steamIDUser;

		// Token: 0x04001AEA RID: 6890
		[FieldOffset(8)]
		public int m_iMessageID;
	}
}

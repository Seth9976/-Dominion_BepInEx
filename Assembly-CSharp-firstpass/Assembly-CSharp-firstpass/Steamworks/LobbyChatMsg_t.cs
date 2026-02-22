using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001C0 RID: 448
	[StructLayout(2)]
	public struct LobbyChatMsg_t
	{
		// Token: 0x060022A1 RID: 8865 RVA: 0x000A3498 File Offset: 0x000A1698
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyChatMsg_t()
		{
			Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LobbyChatMsg_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr);
			LobbyChatMsg_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, "k_iCallback");
			LobbyChatMsg_t.NativeFieldInfoPtr_m_ulSteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, "m_ulSteamIDLobby");
			LobbyChatMsg_t.NativeFieldInfoPtr_m_ulSteamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, "m_ulSteamIDUser");
			LobbyChatMsg_t.NativeFieldInfoPtr_m_eChatEntryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, "m_eChatEntryType");
			LobbyChatMsg_t.NativeFieldInfoPtr_m_iChatID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, "m_iChatID");
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x0000CED9 File Offset: 0x0000B0D9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyChatMsg_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x000A352C File Offset: 0x000A172C
		// (set) Token: 0x060022A4 RID: 8868 RVA: 0x0000CEEB File Offset: 0x0000B0EB
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyChatMsg_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyChatMsg_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C56 RID: 7254
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C57 RID: 7255
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDLobby;

		// Token: 0x04001C58 RID: 7256
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDUser;

		// Token: 0x04001C59 RID: 7257
		private static readonly IntPtr NativeFieldInfoPtr_m_eChatEntryType;

		// Token: 0x04001C5A RID: 7258
		private static readonly IntPtr NativeFieldInfoPtr_m_iChatID;

		// Token: 0x04001C5B RID: 7259
		[FieldOffset(0)]
		public ulong m_ulSteamIDLobby;

		// Token: 0x04001C5C RID: 7260
		[FieldOffset(8)]
		public ulong m_ulSteamIDUser;

		// Token: 0x04001C5D RID: 7261
		[FieldOffset(16)]
		public byte m_eChatEntryType;

		// Token: 0x04001C5E RID: 7262
		[FieldOffset(20)]
		public uint m_iChatID;
	}
}

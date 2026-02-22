using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000184 RID: 388
	[StructLayout(2)]
	public struct JoinClanChatRoomCompletionResult_t
	{
		// Token: 0x06002125 RID: 8485 RVA: 0x000A0500 File Offset: 0x0009E700
		// Note: this type is marked as 'beforefieldinit'.
		static JoinClanChatRoomCompletionResult_t()
		{
			Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "JoinClanChatRoomCompletionResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr);
			JoinClanChatRoomCompletionResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr, "k_iCallback");
			JoinClanChatRoomCompletionResult_t.NativeFieldInfoPtr_m_steamIDClanChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr, "m_steamIDClanChat");
			JoinClanChatRoomCompletionResult_t.NativeFieldInfoPtr_m_eChatRoomEnterResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr, "m_eChatRoomEnterResponse");
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x0000BFA9 File Offset: 0x0000A1A9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JoinClanChatRoomCompletionResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x000A056C File Offset: 0x0009E76C
		// (set) Token: 0x06002128 RID: 8488 RVA: 0x0000BFBB File Offset: 0x0000A1BB
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(JoinClanChatRoomCompletionResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JoinClanChatRoomCompletionResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001AE1 RID: 6881
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001AE2 RID: 6882
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDClanChat;

		// Token: 0x04001AE3 RID: 6883
		private static readonly IntPtr NativeFieldInfoPtr_m_eChatRoomEnterResponse;

		// Token: 0x04001AE4 RID: 6884
		[FieldOffset(0)]
		public CSteamID m_steamIDClanChat;

		// Token: 0x04001AE5 RID: 6885
		[FieldOffset(8)]
		public EChatRoomEnterResponse m_eChatRoomEnterResponse;
	}
}

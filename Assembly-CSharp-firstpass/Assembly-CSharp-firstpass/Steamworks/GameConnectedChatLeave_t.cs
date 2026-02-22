using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000182 RID: 386
	[StructLayout(2)]
	public struct GameConnectedChatLeave_t
	{
		// Token: 0x0600211D RID: 8477 RVA: 0x000A03DC File Offset: 0x0009E5DC
		// Note: this type is marked as 'beforefieldinit'.
		static GameConnectedChatLeave_t()
		{
			Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "GameConnectedChatLeave_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr);
			GameConnectedChatLeave_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, "k_iCallback");
			GameConnectedChatLeave_t.NativeFieldInfoPtr_m_steamIDClanChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, "m_steamIDClanChat");
			GameConnectedChatLeave_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, "m_steamIDUser");
			GameConnectedChatLeave_t.NativeFieldInfoPtr_m_bKicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, "m_bKicked");
			GameConnectedChatLeave_t.NativeFieldInfoPtr_m_bDropped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, "m_bDropped");
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x0000BF69 File Offset: 0x0000A169
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameConnectedChatLeave_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x0600211F RID: 8479 RVA: 0x000A0470 File Offset: 0x0009E670
		// (set) Token: 0x06002120 RID: 8480 RVA: 0x0000BF7B File Offset: 0x0000A17B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GameConnectedChatLeave_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameConnectedChatLeave_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001AD5 RID: 6869
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001AD6 RID: 6870
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDClanChat;

		// Token: 0x04001AD7 RID: 6871
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x04001AD8 RID: 6872
		private static readonly IntPtr NativeFieldInfoPtr_m_bKicked;

		// Token: 0x04001AD9 RID: 6873
		private static readonly IntPtr NativeFieldInfoPtr_m_bDropped;

		// Token: 0x04001ADA RID: 6874
		[FieldOffset(0)]
		public CSteamID m_steamIDClanChat;

		// Token: 0x04001ADB RID: 6875
		[FieldOffset(8)]
		public CSteamID m_steamIDUser;

		// Token: 0x04001ADC RID: 6876
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool m_bKicked;

		// Token: 0x04001ADD RID: 6877
		[FieldOffset(17)]
		[MarshalAs(4)]
		public bool m_bDropped;
	}
}

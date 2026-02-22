using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001BF RID: 447
	[StructLayout(2)]
	public struct LobbyChatUpdate_t
	{
		// Token: 0x0600229D RID: 8861 RVA: 0x000A33E8 File Offset: 0x000A15E8
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyChatUpdate_t()
		{
			Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LobbyChatUpdate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr);
			LobbyChatUpdate_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, "k_iCallback");
			LobbyChatUpdate_t.NativeFieldInfoPtr_m_ulSteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, "m_ulSteamIDLobby");
			LobbyChatUpdate_t.NativeFieldInfoPtr_m_ulSteamIDUserChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, "m_ulSteamIDUserChanged");
			LobbyChatUpdate_t.NativeFieldInfoPtr_m_ulSteamIDMakingChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, "m_ulSteamIDMakingChange");
			LobbyChatUpdate_t.NativeFieldInfoPtr_m_rgfChatMemberStateChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, "m_rgfChatMemberStateChange");
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x0000CEB9 File Offset: 0x0000B0B9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyChatUpdate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x000A347C File Offset: 0x000A167C
		// (set) Token: 0x060022A0 RID: 8864 RVA: 0x0000CECB File Offset: 0x0000B0CB
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyChatUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyChatUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C4D RID: 7245
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C4E RID: 7246
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDLobby;

		// Token: 0x04001C4F RID: 7247
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDUserChanged;

		// Token: 0x04001C50 RID: 7248
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDMakingChange;

		// Token: 0x04001C51 RID: 7249
		private static readonly IntPtr NativeFieldInfoPtr_m_rgfChatMemberStateChange;

		// Token: 0x04001C52 RID: 7250
		[FieldOffset(0)]
		public ulong m_ulSteamIDLobby;

		// Token: 0x04001C53 RID: 7251
		[FieldOffset(8)]
		public ulong m_ulSteamIDUserChanged;

		// Token: 0x04001C54 RID: 7252
		[FieldOffset(16)]
		public ulong m_ulSteamIDMakingChange;

		// Token: 0x04001C55 RID: 7253
		[FieldOffset(24)]
		public uint m_rgfChatMemberStateChange;
	}
}

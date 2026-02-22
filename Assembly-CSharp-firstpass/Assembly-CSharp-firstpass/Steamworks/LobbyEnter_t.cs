using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001BD RID: 445
	[StructLayout(2)]
	public struct LobbyEnter_t
	{
		// Token: 0x06002295 RID: 8853 RVA: 0x000A329C File Offset: 0x000A149C
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyEnter_t()
		{
			Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LobbyEnter_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr);
			LobbyEnter_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, "k_iCallback");
			LobbyEnter_t.NativeFieldInfoPtr_m_ulSteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, "m_ulSteamIDLobby");
			LobbyEnter_t.NativeFieldInfoPtr_m_rgfChatPermissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, "m_rgfChatPermissions");
			LobbyEnter_t.NativeFieldInfoPtr_m_bLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, "m_bLocked");
			LobbyEnter_t.NativeFieldInfoPtr_m_EChatRoomEnterResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, "m_EChatRoomEnterResponse");
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x0000CE79 File Offset: 0x0000B079
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyEnter_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06002297 RID: 8855 RVA: 0x000A3330 File Offset: 0x000A1530
		// (set) Token: 0x06002298 RID: 8856 RVA: 0x0000CE8B File Offset: 0x0000B08B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyEnter_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyEnter_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C3D RID: 7229
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C3E RID: 7230
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDLobby;

		// Token: 0x04001C3F RID: 7231
		private static readonly IntPtr NativeFieldInfoPtr_m_rgfChatPermissions;

		// Token: 0x04001C40 RID: 7232
		private static readonly IntPtr NativeFieldInfoPtr_m_bLocked;

		// Token: 0x04001C41 RID: 7233
		private static readonly IntPtr NativeFieldInfoPtr_m_EChatRoomEnterResponse;

		// Token: 0x04001C42 RID: 7234
		[FieldOffset(0)]
		public ulong m_ulSteamIDLobby;

		// Token: 0x04001C43 RID: 7235
		[FieldOffset(8)]
		public uint m_rgfChatPermissions;

		// Token: 0x04001C44 RID: 7236
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool m_bLocked;

		// Token: 0x04001C45 RID: 7237
		[FieldOffset(16)]
		public uint m_EChatRoomEnterResponse;
	}
}

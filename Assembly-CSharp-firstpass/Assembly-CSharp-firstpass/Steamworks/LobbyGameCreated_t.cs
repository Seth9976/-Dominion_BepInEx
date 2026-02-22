using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001C1 RID: 449
	[StructLayout(2)]
	public struct LobbyGameCreated_t
	{
		// Token: 0x060022A5 RID: 8869 RVA: 0x000A3548 File Offset: 0x000A1748
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyGameCreated_t()
		{
			Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LobbyGameCreated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr);
			LobbyGameCreated_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, "k_iCallback");
			LobbyGameCreated_t.NativeFieldInfoPtr_m_ulSteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, "m_ulSteamIDLobby");
			LobbyGameCreated_t.NativeFieldInfoPtr_m_ulSteamIDGameServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, "m_ulSteamIDGameServer");
			LobbyGameCreated_t.NativeFieldInfoPtr_m_unIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, "m_unIP");
			LobbyGameCreated_t.NativeFieldInfoPtr_m_usPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, "m_usPort");
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x0000CEF9 File Offset: 0x0000B0F9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyGameCreated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x000A35DC File Offset: 0x000A17DC
		// (set) Token: 0x060022A8 RID: 8872 RVA: 0x0000CF0B File Offset: 0x0000B10B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyGameCreated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyGameCreated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C5F RID: 7263
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C60 RID: 7264
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDLobby;

		// Token: 0x04001C61 RID: 7265
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDGameServer;

		// Token: 0x04001C62 RID: 7266
		private static readonly IntPtr NativeFieldInfoPtr_m_unIP;

		// Token: 0x04001C63 RID: 7267
		private static readonly IntPtr NativeFieldInfoPtr_m_usPort;

		// Token: 0x04001C64 RID: 7268
		[FieldOffset(0)]
		public ulong m_ulSteamIDLobby;

		// Token: 0x04001C65 RID: 7269
		[FieldOffset(8)]
		public ulong m_ulSteamIDGameServer;

		// Token: 0x04001C66 RID: 7270
		[FieldOffset(16)]
		public uint m_unIP;

		// Token: 0x04001C67 RID: 7271
		[FieldOffset(20)]
		public ushort m_usPort;
	}
}

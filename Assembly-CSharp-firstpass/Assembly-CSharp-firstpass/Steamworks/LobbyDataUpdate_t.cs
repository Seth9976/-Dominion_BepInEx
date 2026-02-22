using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001BE RID: 446
	[StructLayout(2)]
	public struct LobbyDataUpdate_t
	{
		// Token: 0x06002299 RID: 8857 RVA: 0x000A334C File Offset: 0x000A154C
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyDataUpdate_t()
		{
			Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LobbyDataUpdate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr);
			LobbyDataUpdate_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr, "k_iCallback");
			LobbyDataUpdate_t.NativeFieldInfoPtr_m_ulSteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr, "m_ulSteamIDLobby");
			LobbyDataUpdate_t.NativeFieldInfoPtr_m_ulSteamIDMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr, "m_ulSteamIDMember");
			LobbyDataUpdate_t.NativeFieldInfoPtr_m_bSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr, "m_bSuccess");
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x0000CE99 File Offset: 0x0000B099
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyDataUpdate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600229B RID: 8859 RVA: 0x000A33CC File Offset: 0x000A15CC
		// (set) Token: 0x0600229C RID: 8860 RVA: 0x0000CEAB File Offset: 0x0000B0AB
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyDataUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyDataUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C46 RID: 7238
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C47 RID: 7239
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDLobby;

		// Token: 0x04001C48 RID: 7240
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDMember;

		// Token: 0x04001C49 RID: 7241
		private static readonly IntPtr NativeFieldInfoPtr_m_bSuccess;

		// Token: 0x04001C4A RID: 7242
		[FieldOffset(0)]
		public ulong m_ulSteamIDLobby;

		// Token: 0x04001C4B RID: 7243
		[FieldOffset(8)]
		public ulong m_ulSteamIDMember;

		// Token: 0x04001C4C RID: 7244
		[FieldOffset(16)]
		public byte m_bSuccess;
	}
}

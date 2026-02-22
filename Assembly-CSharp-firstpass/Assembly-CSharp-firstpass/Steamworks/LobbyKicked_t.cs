using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001C3 RID: 451
	[StructLayout(2)]
	public struct LobbyKicked_t
	{
		// Token: 0x060022AD RID: 8877 RVA: 0x000A366C File Offset: 0x000A186C
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyKicked_t()
		{
			Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LobbyKicked_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr);
			LobbyKicked_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr, "k_iCallback");
			LobbyKicked_t.NativeFieldInfoPtr_m_ulSteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr, "m_ulSteamIDLobby");
			LobbyKicked_t.NativeFieldInfoPtr_m_ulSteamIDAdmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr, "m_ulSteamIDAdmin");
			LobbyKicked_t.NativeFieldInfoPtr_m_bKickedDueToDisconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr, "m_bKickedDueToDisconnect");
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x0000CF39 File Offset: 0x0000B139
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyKicked_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x060022AF RID: 8879 RVA: 0x000A36EC File Offset: 0x000A18EC
		// (set) Token: 0x060022B0 RID: 8880 RVA: 0x0000CF4B File Offset: 0x0000B14B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyKicked_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyKicked_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C6B RID: 7275
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C6C RID: 7276
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDLobby;

		// Token: 0x04001C6D RID: 7277
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDAdmin;

		// Token: 0x04001C6E RID: 7278
		private static readonly IntPtr NativeFieldInfoPtr_m_bKickedDueToDisconnect;

		// Token: 0x04001C6F RID: 7279
		[FieldOffset(0)]
		public ulong m_ulSteamIDLobby;

		// Token: 0x04001C70 RID: 7280
		[FieldOffset(8)]
		public ulong m_ulSteamIDAdmin;

		// Token: 0x04001C71 RID: 7281
		[FieldOffset(16)]
		public byte m_bKickedDueToDisconnect;
	}
}

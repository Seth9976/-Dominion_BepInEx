using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001C4 RID: 452
	[StructLayout(2)]
	public struct LobbyCreated_t
	{
		// Token: 0x060022B1 RID: 8881 RVA: 0x000A3708 File Offset: 0x000A1908
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyCreated_t()
		{
			Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LobbyCreated_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr);
			LobbyCreated_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr, "k_iCallback");
			LobbyCreated_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr, "m_eResult");
			LobbyCreated_t.NativeFieldInfoPtr_m_ulSteamIDLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr, "m_ulSteamIDLobby");
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x0000CF59 File Offset: 0x0000B159
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyCreated_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x000A3774 File Offset: 0x000A1974
		// (set) Token: 0x060022B4 RID: 8884 RVA: 0x0000CF6B File Offset: 0x0000B16B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LobbyCreated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LobbyCreated_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001C72 RID: 7282
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001C73 RID: 7283
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001C74 RID: 7284
		private static readonly IntPtr NativeFieldInfoPtr_m_ulSteamIDLobby;

		// Token: 0x04001C75 RID: 7285
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001C76 RID: 7286
		[FieldOffset(8)]
		public ulong m_ulSteamIDLobby;
	}
}

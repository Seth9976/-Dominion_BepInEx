using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001EC RID: 492
	[StructLayout(2)]
	public struct SteamRemotePlaySessionConnected_t
	{
		// Token: 0x0600237D RID: 9085 RVA: 0x000A4D04 File Offset: 0x000A2F04
		// Note: this type is marked as 'beforefieldinit'.
		static SteamRemotePlaySessionConnected_t()
		{
			Il2CppClassPointerStore<SteamRemotePlaySessionConnected_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamRemotePlaySessionConnected_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamRemotePlaySessionConnected_t>.NativeClassPtr);
			SteamRemotePlaySessionConnected_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRemotePlaySessionConnected_t>.NativeClassPtr, "k_iCallback");
			SteamRemotePlaySessionConnected_t.NativeFieldInfoPtr_m_unSessionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRemotePlaySessionConnected_t>.NativeClassPtr, "m_unSessionID");
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x0000D930 File Offset: 0x0000BB30
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamRemotePlaySessionConnected_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x0600237F RID: 9087 RVA: 0x000A4D5C File Offset: 0x000A2F5C
		// (set) Token: 0x06002380 RID: 9088 RVA: 0x0000D942 File Offset: 0x0000BB42
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamRemotePlaySessionConnected_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamRemotePlaySessionConnected_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001D1C RID: 7452
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D1D RID: 7453
		private static readonly IntPtr NativeFieldInfoPtr_m_unSessionID;

		// Token: 0x04001D1E RID: 7454
		[FieldOffset(0)]
		public RemotePlaySessionID_t m_unSessionID;
	}
}

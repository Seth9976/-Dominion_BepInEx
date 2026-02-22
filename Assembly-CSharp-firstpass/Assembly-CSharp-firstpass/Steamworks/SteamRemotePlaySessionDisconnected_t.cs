using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001ED RID: 493
	[StructLayout(2)]
	public struct SteamRemotePlaySessionDisconnected_t
	{
		// Token: 0x06002381 RID: 9089 RVA: 0x000A4D78 File Offset: 0x000A2F78
		// Note: this type is marked as 'beforefieldinit'.
		static SteamRemotePlaySessionDisconnected_t()
		{
			Il2CppClassPointerStore<SteamRemotePlaySessionDisconnected_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamRemotePlaySessionDisconnected_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamRemotePlaySessionDisconnected_t>.NativeClassPtr);
			SteamRemotePlaySessionDisconnected_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRemotePlaySessionDisconnected_t>.NativeClassPtr, "k_iCallback");
			SteamRemotePlaySessionDisconnected_t.NativeFieldInfoPtr_m_unSessionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamRemotePlaySessionDisconnected_t>.NativeClassPtr, "m_unSessionID");
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x0000D950 File Offset: 0x0000BB50
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamRemotePlaySessionDisconnected_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06002383 RID: 9091 RVA: 0x000A4DD0 File Offset: 0x000A2FD0
		// (set) Token: 0x06002384 RID: 9092 RVA: 0x0000D962 File Offset: 0x0000BB62
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamRemotePlaySessionDisconnected_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamRemotePlaySessionDisconnected_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001D1F RID: 7455
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D20 RID: 7456
		private static readonly IntPtr NativeFieldInfoPtr_m_unSessionID;

		// Token: 0x04001D21 RID: 7457
		[FieldOffset(0)]
		public RemotePlaySessionID_t m_unSessionID;
	}
}

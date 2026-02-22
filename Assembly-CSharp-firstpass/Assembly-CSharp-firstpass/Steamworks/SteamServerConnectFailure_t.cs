using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200021E RID: 542
	[StructLayout(2)]
	public struct SteamServerConnectFailure_t
	{
		// Token: 0x060024F7 RID: 9463 RVA: 0x000A7E68 File Offset: 0x000A6068
		// Note: this type is marked as 'beforefieldinit'.
		static SteamServerConnectFailure_t()
		{
			Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamServerConnectFailure_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr);
			SteamServerConnectFailure_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr, "k_iCallback");
			SteamServerConnectFailure_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr, "m_eResult");
			SteamServerConnectFailure_t.NativeFieldInfoPtr_m_bStillRetrying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr, "m_bStillRetrying");
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x0000E877 File Offset: 0x0000CA77
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamServerConnectFailure_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x060024F9 RID: 9465 RVA: 0x000A7ED4 File Offset: 0x000A60D4
		// (set) Token: 0x060024FA RID: 9466 RVA: 0x0000E889 File Offset: 0x0000CA89
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamServerConnectFailure_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamServerConnectFailure_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E62 RID: 7778
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E63 RID: 7779
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001E64 RID: 7780
		private static readonly IntPtr NativeFieldInfoPtr_m_bStillRetrying;

		// Token: 0x04001E65 RID: 7781
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001E66 RID: 7782
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool m_bStillRetrying;
	}
}

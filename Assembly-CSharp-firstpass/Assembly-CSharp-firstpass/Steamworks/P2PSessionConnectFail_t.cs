using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001E4 RID: 484
	[StructLayout(2)]
	public struct P2PSessionConnectFail_t
	{
		// Token: 0x0600233C RID: 9020 RVA: 0x000A4580 File Offset: 0x000A2780
		// Note: this type is marked as 'beforefieldinit'.
		static P2PSessionConnectFail_t()
		{
			Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "P2PSessionConnectFail_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr);
			P2PSessionConnectFail_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr, "k_iCallback");
			P2PSessionConnectFail_t.NativeFieldInfoPtr_m_steamIDRemote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr, "m_steamIDRemote");
			P2PSessionConnectFail_t.NativeFieldInfoPtr_m_eP2PSessionError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr, "m_eP2PSessionError");
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x0000D645 File Offset: 0x0000B845
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<P2PSessionConnectFail_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x0600233E RID: 9022 RVA: 0x000A45EC File Offset: 0x000A27EC
		// (set) Token: 0x0600233F RID: 9023 RVA: 0x0000D657 File Offset: 0x0000B857
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(P2PSessionConnectFail_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(P2PSessionConnectFail_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CF8 RID: 7416
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001CF9 RID: 7417
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDRemote;

		// Token: 0x04001CFA RID: 7418
		private static readonly IntPtr NativeFieldInfoPtr_m_eP2PSessionError;

		// Token: 0x04001CFB RID: 7419
		[FieldOffset(0)]
		public CSteamID m_steamIDRemote;

		// Token: 0x04001CFC RID: 7420
		[FieldOffset(8)]
		public byte m_eP2PSessionError;
	}
}

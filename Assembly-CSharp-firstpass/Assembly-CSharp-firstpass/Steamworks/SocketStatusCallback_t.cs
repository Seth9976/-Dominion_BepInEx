using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001E5 RID: 485
	[StructLayout(2)]
	public struct SocketStatusCallback_t
	{
		// Token: 0x06002340 RID: 9024 RVA: 0x000A4608 File Offset: 0x000A2808
		// Note: this type is marked as 'beforefieldinit'.
		static SocketStatusCallback_t()
		{
			Il2CppClassPointerStore<SocketStatusCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SocketStatusCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketStatusCallback_t>.NativeClassPtr);
			SocketStatusCallback_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketStatusCallback_t>.NativeClassPtr, "k_iCallback");
			SocketStatusCallback_t.NativeFieldInfoPtr_m_hSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketStatusCallback_t>.NativeClassPtr, "m_hSocket");
			SocketStatusCallback_t.NativeFieldInfoPtr_m_hListenSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketStatusCallback_t>.NativeClassPtr, "m_hListenSocket");
			SocketStatusCallback_t.NativeFieldInfoPtr_m_steamIDRemote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketStatusCallback_t>.NativeClassPtr, "m_steamIDRemote");
			SocketStatusCallback_t.NativeFieldInfoPtr_m_eSNetSocketState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketStatusCallback_t>.NativeClassPtr, "m_eSNetSocketState");
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x0000D665 File Offset: 0x0000B865
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SocketStatusCallback_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06002342 RID: 9026 RVA: 0x000A469C File Offset: 0x000A289C
		// (set) Token: 0x06002343 RID: 9027 RVA: 0x0000D677 File Offset: 0x0000B877
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SocketStatusCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SocketStatusCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001CFD RID: 7421
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001CFE RID: 7422
		private static readonly IntPtr NativeFieldInfoPtr_m_hSocket;

		// Token: 0x04001CFF RID: 7423
		private static readonly IntPtr NativeFieldInfoPtr_m_hListenSocket;

		// Token: 0x04001D00 RID: 7424
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDRemote;

		// Token: 0x04001D01 RID: 7425
		private static readonly IntPtr NativeFieldInfoPtr_m_eSNetSocketState;

		// Token: 0x04001D02 RID: 7426
		[FieldOffset(0)]
		public SNetSocket_t m_hSocket;

		// Token: 0x04001D03 RID: 7427
		[FieldOffset(4)]
		public SNetListenSocket_t m_hListenSocket;

		// Token: 0x04001D04 RID: 7428
		[FieldOffset(8)]
		public CSteamID m_steamIDRemote;

		// Token: 0x04001D05 RID: 7429
		[FieldOffset(16)]
		public int m_eSNetSocketState;
	}
}

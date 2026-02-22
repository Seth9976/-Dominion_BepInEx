using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000220 RID: 544
	[StructLayout(2)]
	public struct ClientGameServerDeny_t
	{
		// Token: 0x060024FF RID: 9471 RVA: 0x000A7F64 File Offset: 0x000A6164
		// Note: this type is marked as 'beforefieldinit'.
		static ClientGameServerDeny_t()
		{
			Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "ClientGameServerDeny_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr);
			ClientGameServerDeny_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, "k_iCallback");
			ClientGameServerDeny_t.NativeFieldInfoPtr_m_uAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, "m_uAppID");
			ClientGameServerDeny_t.NativeFieldInfoPtr_m_unGameServerIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, "m_unGameServerIP");
			ClientGameServerDeny_t.NativeFieldInfoPtr_m_usGameServerPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, "m_usGameServerPort");
			ClientGameServerDeny_t.NativeFieldInfoPtr_m_bSecure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, "m_bSecure");
			ClientGameServerDeny_t.NativeFieldInfoPtr_m_uReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, "m_uReason");
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x0000E8B7 File Offset: 0x0000CAB7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientGameServerDeny_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x000A800C File Offset: 0x000A620C
		// (set) Token: 0x06002502 RID: 9474 RVA: 0x0000E8C9 File Offset: 0x0000CAC9
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ClientGameServerDeny_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClientGameServerDeny_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001E6A RID: 7786
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001E6B RID: 7787
		private static readonly IntPtr NativeFieldInfoPtr_m_uAppID;

		// Token: 0x04001E6C RID: 7788
		private static readonly IntPtr NativeFieldInfoPtr_m_unGameServerIP;

		// Token: 0x04001E6D RID: 7789
		private static readonly IntPtr NativeFieldInfoPtr_m_usGameServerPort;

		// Token: 0x04001E6E RID: 7790
		private static readonly IntPtr NativeFieldInfoPtr_m_bSecure;

		// Token: 0x04001E6F RID: 7791
		private static readonly IntPtr NativeFieldInfoPtr_m_uReason;

		// Token: 0x04001E70 RID: 7792
		[FieldOffset(0)]
		public uint m_uAppID;

		// Token: 0x04001E71 RID: 7793
		[FieldOffset(4)]
		public uint m_unGameServerIP;

		// Token: 0x04001E72 RID: 7794
		[FieldOffset(8)]
		public ushort m_usGameServerPort;

		// Token: 0x04001E73 RID: 7795
		[FieldOffset(10)]
		public ushort m_bSecure;

		// Token: 0x04001E74 RID: 7796
		[FieldOffset(12)]
		public uint m_uReason;
	}
}

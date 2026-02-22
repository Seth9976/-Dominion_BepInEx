using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001EE RID: 494
	[StructLayout(2)]
	public struct RemoteStorageAppSyncedClient_t
	{
		// Token: 0x06002385 RID: 9093 RVA: 0x000A4DEC File Offset: 0x000A2FEC
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageAppSyncedClient_t()
		{
			Il2CppClassPointerStore<RemoteStorageAppSyncedClient_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageAppSyncedClient_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageAppSyncedClient_t>.NativeClassPtr);
			RemoteStorageAppSyncedClient_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncedClient_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageAppSyncedClient_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncedClient_t>.NativeClassPtr, "m_nAppID");
			RemoteStorageAppSyncedClient_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncedClient_t>.NativeClassPtr, "m_eResult");
			RemoteStorageAppSyncedClient_t.NativeFieldInfoPtr_m_unNumDownloads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncedClient_t>.NativeClassPtr, "m_unNumDownloads");
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x0000D970 File Offset: 0x0000BB70
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageAppSyncedClient_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x000A4E6C File Offset: 0x000A306C
		// (set) Token: 0x06002388 RID: 9096 RVA: 0x0000D982 File Offset: 0x0000BB82
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageAppSyncedClient_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageAppSyncedClient_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001D22 RID: 7458
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D23 RID: 7459
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04001D24 RID: 7460
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001D25 RID: 7461
		private static readonly IntPtr NativeFieldInfoPtr_m_unNumDownloads;

		// Token: 0x04001D26 RID: 7462
		[FieldOffset(0)]
		public AppId_t m_nAppID;

		// Token: 0x04001D27 RID: 7463
		[FieldOffset(4)]
		public EResult m_eResult;

		// Token: 0x04001D28 RID: 7464
		[FieldOffset(8)]
		public int m_unNumDownloads;
	}
}

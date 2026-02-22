using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001EF RID: 495
	[StructLayout(2)]
	public struct RemoteStorageAppSyncedServer_t
	{
		// Token: 0x06002389 RID: 9097 RVA: 0x000A4E88 File Offset: 0x000A3088
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageAppSyncedServer_t()
		{
			Il2CppClassPointerStore<RemoteStorageAppSyncedServer_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageAppSyncedServer_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageAppSyncedServer_t>.NativeClassPtr);
			RemoteStorageAppSyncedServer_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncedServer_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageAppSyncedServer_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncedServer_t>.NativeClassPtr, "m_nAppID");
			RemoteStorageAppSyncedServer_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncedServer_t>.NativeClassPtr, "m_eResult");
			RemoteStorageAppSyncedServer_t.NativeFieldInfoPtr_m_unNumUploads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncedServer_t>.NativeClassPtr, "m_unNumUploads");
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x0000D990 File Offset: 0x0000BB90
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageAppSyncedServer_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x0600238B RID: 9099 RVA: 0x000A4F08 File Offset: 0x000A3108
		// (set) Token: 0x0600238C RID: 9100 RVA: 0x0000D9A2 File Offset: 0x0000BBA2
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageAppSyncedServer_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageAppSyncedServer_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001D29 RID: 7465
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D2A RID: 7466
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04001D2B RID: 7467
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001D2C RID: 7468
		private static readonly IntPtr NativeFieldInfoPtr_m_unNumUploads;

		// Token: 0x04001D2D RID: 7469
		[FieldOffset(0)]
		public AppId_t m_nAppID;

		// Token: 0x04001D2E RID: 7470
		[FieldOffset(4)]
		public EResult m_eResult;

		// Token: 0x04001D2F RID: 7471
		[FieldOffset(8)]
		public int m_unNumUploads;
	}
}

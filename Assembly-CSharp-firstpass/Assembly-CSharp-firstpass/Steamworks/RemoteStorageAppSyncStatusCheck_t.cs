using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001F1 RID: 497
	[StructLayout(2)]
	public struct RemoteStorageAppSyncStatusCheck_t
	{
		// Token: 0x0600239E RID: 9118 RVA: 0x000A5164 File Offset: 0x000A3364
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteStorageAppSyncStatusCheck_t()
		{
			Il2CppClassPointerStore<RemoteStorageAppSyncStatusCheck_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "RemoteStorageAppSyncStatusCheck_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteStorageAppSyncStatusCheck_t>.NativeClassPtr);
			RemoteStorageAppSyncStatusCheck_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncStatusCheck_t>.NativeClassPtr, "k_iCallback");
			RemoteStorageAppSyncStatusCheck_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncStatusCheck_t>.NativeClassPtr, "m_nAppID");
			RemoteStorageAppSyncStatusCheck_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteStorageAppSyncStatusCheck_t>.NativeClassPtr, "m_eResult");
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x0000DA64 File Offset: 0x0000BC64
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteStorageAppSyncStatusCheck_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x000A51D0 File Offset: 0x000A33D0
		// (set) Token: 0x060023A1 RID: 9121 RVA: 0x0000DA76 File Offset: 0x0000BC76
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemoteStorageAppSyncStatusCheck_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemoteStorageAppSyncStatusCheck_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001D38 RID: 7480
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D39 RID: 7481
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04001D3A RID: 7482
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001D3B RID: 7483
		[FieldOffset(0)]
		public AppId_t m_nAppID;

		// Token: 0x04001D3C RID: 7484
		[FieldOffset(4)]
		public EResult m_eResult;
	}
}

using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001E8 RID: 488
	public sealed class SteamNetConnectionStatusChangedCallback_t : ValueType
	{
		// Token: 0x06002352 RID: 9042 RVA: 0x000A4800 File Offset: 0x000A2A00
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetConnectionStatusChangedCallback_t()
		{
			Il2CppClassPointerStore<SteamNetConnectionStatusChangedCallback_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamNetConnectionStatusChangedCallback_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetConnectionStatusChangedCallback_t>.NativeClassPtr);
			SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionStatusChangedCallback_t>.NativeClassPtr, "k_iCallback");
			SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_m_hConn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionStatusChangedCallback_t>.NativeClassPtr, "m_hConn");
			SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_m_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionStatusChangedCallback_t>.NativeClassPtr, "m_info");
			SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_m_eOldState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetConnectionStatusChangedCallback_t>.NativeClassPtr, "m_eOldState");
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x0000D733 File Offset: 0x0000B933
		public SteamNetConnectionStatusChangedCallback_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x0000D73C File Offset: 0x0000B93C
		public SteamNetConnectionStatusChangedCallback_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetConnectionStatusChangedCallback_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06002355 RID: 9045 RVA: 0x000A4880 File Offset: 0x000A2A80
		// (set) Token: 0x06002356 RID: 9046 RVA: 0x0000D74E File Offset: 0x0000B94E
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06002357 RID: 9047 RVA: 0x000A489C File Offset: 0x000A2A9C
		// (set) Token: 0x06002358 RID: 9048 RVA: 0x0000D75C File Offset: 0x0000B95C
		public unsafe HSteamNetConnection m_hConn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_m_hConn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_m_hConn)) = value;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06002359 RID: 9049 RVA: 0x000A48C4 File Offset: 0x000A2AC4
		// (set) Token: 0x0600235A RID: 9050 RVA: 0x0000D777 File Offset: 0x0000B977
		public SteamNetConnectionInfo_t m_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_m_info);
				return new SteamNetConnectionInfo_t(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_m_info), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x0600235B RID: 9051 RVA: 0x000A48F4 File Offset: 0x000A2AF4
		// (set) Token: 0x0600235C RID: 9052 RVA: 0x0000D7A5 File Offset: 0x0000B9A5
		public unsafe ESteamNetworkingConnectionState m_eOldState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_m_eOldState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetConnectionStatusChangedCallback_t.NativeFieldInfoPtr_m_eOldState)) = value;
			}
		}

		// Token: 0x04001D0A RID: 7434
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D0B RID: 7435
		private static readonly IntPtr NativeFieldInfoPtr_m_hConn;

		// Token: 0x04001D0C RID: 7436
		private static readonly IntPtr NativeFieldInfoPtr_m_info;

		// Token: 0x04001D0D RID: 7437
		private static readonly IntPtr NativeFieldInfoPtr_m_eOldState;
	}
}

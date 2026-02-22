using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001E7 RID: 487
	public sealed class SteamNetworkingMessagesSessionFailed_t : ValueType
	{
		// Token: 0x0600234B RID: 9035 RVA: 0x000A475C File Offset: 0x000A295C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworkingMessagesSessionFailed_t()
		{
			Il2CppClassPointerStore<SteamNetworkingMessagesSessionFailed_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamNetworkingMessagesSessionFailed_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingMessagesSessionFailed_t>.NativeClassPtr);
			SteamNetworkingMessagesSessionFailed_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessagesSessionFailed_t>.NativeClassPtr, "k_iCallback");
			SteamNetworkingMessagesSessionFailed_t.NativeFieldInfoPtr_m_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessagesSessionFailed_t>.NativeClassPtr, "m_info");
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x0000D6DC File Offset: 0x0000B8DC
		public SteamNetworkingMessagesSessionFailed_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x0000D6E5 File Offset: 0x0000B8E5
		public SteamNetworkingMessagesSessionFailed_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetworkingMessagesSessionFailed_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x0600234E RID: 9038 RVA: 0x000A47B4 File Offset: 0x000A29B4
		// (set) Token: 0x0600234F RID: 9039 RVA: 0x0000D6F7 File Offset: 0x0000B8F7
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworkingMessagesSessionFailed_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworkingMessagesSessionFailed_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x000A47D0 File Offset: 0x000A29D0
		// (set) Token: 0x06002351 RID: 9041 RVA: 0x0000D705 File Offset: 0x0000B905
		public SteamNetConnectionInfo_t m_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessagesSessionFailed_t.NativeFieldInfoPtr_m_info);
				return new SteamNetConnectionInfo_t(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessagesSessionFailed_t.NativeFieldInfoPtr_m_info), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamNetConnectionInfo_t>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04001D08 RID: 7432
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D09 RID: 7433
		private static readonly IntPtr NativeFieldInfoPtr_m_info;
	}
}

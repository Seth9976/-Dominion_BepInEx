using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020001E6 RID: 486
	public sealed class SteamNetworkingMessagesSessionRequest_t : ValueType
	{
		// Token: 0x06002344 RID: 9028 RVA: 0x000A46B8 File Offset: 0x000A28B8
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworkingMessagesSessionRequest_t()
		{
			Il2CppClassPointerStore<SteamNetworkingMessagesSessionRequest_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamNetworkingMessagesSessionRequest_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingMessagesSessionRequest_t>.NativeClassPtr);
			SteamNetworkingMessagesSessionRequest_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessagesSessionRequest_t>.NativeClassPtr, "k_iCallback");
			SteamNetworkingMessagesSessionRequest_t.NativeFieldInfoPtr_m_identityRemote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamNetworkingMessagesSessionRequest_t>.NativeClassPtr, "m_identityRemote");
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x0000D685 File Offset: 0x0000B885
		public SteamNetworkingMessagesSessionRequest_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x0000D68E File Offset: 0x0000B88E
		public SteamNetworkingMessagesSessionRequest_t()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamNetworkingMessagesSessionRequest_t>.NativeClassPtr))
		{
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06002347 RID: 9031 RVA: 0x000A4710 File Offset: 0x000A2910
		// (set) Token: 0x06002348 RID: 9032 RVA: 0x0000D6A0 File Offset: 0x0000B8A0
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SteamNetworkingMessagesSessionRequest_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamNetworkingMessagesSessionRequest_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x000A472C File Offset: 0x000A292C
		// (set) Token: 0x0600234A RID: 9034 RVA: 0x0000D6AE File Offset: 0x0000B8AE
		public SteamNetworkingIdentity m_identityRemote
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessagesSessionRequest_t.NativeFieldInfoPtr_m_identityRemote);
				return new SteamNetworkingIdentity(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamNetworkingMessagesSessionRequest_t.NativeFieldInfoPtr_m_identityRemote), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SteamNetworkingIdentity>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04001D06 RID: 7430
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001D07 RID: 7431
		private static readonly IntPtr NativeFieldInfoPtr_m_identityRemote;
	}
}

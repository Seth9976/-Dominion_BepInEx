using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200017E RID: 382
	[StructLayout(2)]
	public struct FriendRichPresenceUpdate_t
	{
		// Token: 0x06002106 RID: 8454 RVA: 0x000A00A4 File Offset: 0x0009E2A4
		// Note: this type is marked as 'beforefieldinit'.
		static FriendRichPresenceUpdate_t()
		{
			Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FriendRichPresenceUpdate_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr);
			FriendRichPresenceUpdate_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr, "k_iCallback");
			FriendRichPresenceUpdate_t.NativeFieldInfoPtr_m_steamIDFriend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr, "m_steamIDFriend");
			FriendRichPresenceUpdate_t.NativeFieldInfoPtr_m_nAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr, "m_nAppID");
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x0000BEA6 File Offset: 0x0000A0A6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendRichPresenceUpdate_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06002108 RID: 8456 RVA: 0x000A0110 File Offset: 0x0009E310
		// (set) Token: 0x06002109 RID: 8457 RVA: 0x0000BEB8 File Offset: 0x0000A0B8
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FriendRichPresenceUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendRichPresenceUpdate_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001ABF RID: 6847
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001AC0 RID: 6848
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDFriend;

		// Token: 0x04001AC1 RID: 6849
		private static readonly IntPtr NativeFieldInfoPtr_m_nAppID;

		// Token: 0x04001AC2 RID: 6850
		[FieldOffset(0)]
		public CSteamID m_steamIDFriend;

		// Token: 0x04001AC3 RID: 6851
		[FieldOffset(8)]
		public AppId_t m_nAppID;
	}
}

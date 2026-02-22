using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000187 RID: 391
	[StructLayout(2)]
	public struct FriendsIsFollowing_t
	{
		// Token: 0x06002131 RID: 8497 RVA: 0x000A06AC File Offset: 0x0009E8AC
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsIsFollowing_t()
		{
			Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FriendsIsFollowing_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr);
			FriendsIsFollowing_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr, "k_iCallback");
			FriendsIsFollowing_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr, "m_eResult");
			FriendsIsFollowing_t.NativeFieldInfoPtr_m_steamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr, "m_steamID");
			FriendsIsFollowing_t.NativeFieldInfoPtr_m_bIsFollowing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr, "m_bIsFollowing");
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x0000C009 File Offset: 0x0000A209
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendsIsFollowing_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x000A072C File Offset: 0x0009E92C
		// (set) Token: 0x06002134 RID: 8500 RVA: 0x0000C01B File Offset: 0x0000A21B
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FriendsIsFollowing_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendsIsFollowing_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001AF4 RID: 6900
		private static readonly IntPtr NativeFieldInfoPtr_m_steamID;

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeFieldInfoPtr_m_bIsFollowing;

		// Token: 0x04001AF6 RID: 6902
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001AF7 RID: 6903
		[FieldOffset(4)]
		public CSteamID m_steamID;

		// Token: 0x04001AF8 RID: 6904
		[FieldOffset(12)]
		[MarshalAs(4)]
		public bool m_bIsFollowing;
	}
}

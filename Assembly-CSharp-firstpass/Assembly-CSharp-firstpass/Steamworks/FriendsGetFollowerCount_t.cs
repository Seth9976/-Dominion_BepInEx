using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000186 RID: 390
	[StructLayout(2)]
	public struct FriendsGetFollowerCount_t
	{
		// Token: 0x0600212D RID: 8493 RVA: 0x000A0610 File Offset: 0x0009E810
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsGetFollowerCount_t()
		{
			Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FriendsGetFollowerCount_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr);
			FriendsGetFollowerCount_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr, "k_iCallback");
			FriendsGetFollowerCount_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr, "m_eResult");
			FriendsGetFollowerCount_t.NativeFieldInfoPtr_m_steamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr, "m_steamID");
			FriendsGetFollowerCount_t.NativeFieldInfoPtr_m_nCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr, "m_nCount");
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x0000BFE9 File Offset: 0x0000A1E9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendsGetFollowerCount_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x000A0690 File Offset: 0x0009E890
		// (set) Token: 0x06002130 RID: 8496 RVA: 0x0000BFFB File Offset: 0x0000A1FB
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(FriendsGetFollowerCount_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FriendsGetFollowerCount_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001AEB RID: 6891
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001AEC RID: 6892
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001AED RID: 6893
		private static readonly IntPtr NativeFieldInfoPtr_m_steamID;

		// Token: 0x04001AEE RID: 6894
		private static readonly IntPtr NativeFieldInfoPtr_m_nCount;

		// Token: 0x04001AEF RID: 6895
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001AF0 RID: 6896
		[FieldOffset(4)]
		public CSteamID m_steamID;

		// Token: 0x04001AF1 RID: 6897
		[FieldOffset(12)]
		public int m_nCount;
	}
}

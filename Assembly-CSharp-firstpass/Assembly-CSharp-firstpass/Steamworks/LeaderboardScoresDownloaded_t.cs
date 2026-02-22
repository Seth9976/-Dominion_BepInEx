using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200022F RID: 559
	[StructLayout(2)]
	public struct LeaderboardScoresDownloaded_t
	{
		// Token: 0x06002552 RID: 9554 RVA: 0x000A8B3C File Offset: 0x000A6D3C
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardScoresDownloaded_t()
		{
			Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LeaderboardScoresDownloaded_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr);
			LeaderboardScoresDownloaded_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr, "k_iCallback");
			LeaderboardScoresDownloaded_t.NativeFieldInfoPtr_m_hSteamLeaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr, "m_hSteamLeaderboard");
			LeaderboardScoresDownloaded_t.NativeFieldInfoPtr_m_hSteamLeaderboardEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr, "m_hSteamLeaderboardEntries");
			LeaderboardScoresDownloaded_t.NativeFieldInfoPtr_m_cEntryCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr, "m_cEntryCount");
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x0000EBB4 File Offset: 0x0000CDB4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardScoresDownloaded_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06002554 RID: 9556 RVA: 0x000A8BBC File Offset: 0x000A6DBC
		// (set) Token: 0x06002555 RID: 9557 RVA: 0x0000EBC6 File Offset: 0x0000CDC6
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LeaderboardScoresDownloaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeaderboardScoresDownloaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001ECC RID: 7884
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001ECD RID: 7885
		private static readonly IntPtr NativeFieldInfoPtr_m_hSteamLeaderboard;

		// Token: 0x04001ECE RID: 7886
		private static readonly IntPtr NativeFieldInfoPtr_m_hSteamLeaderboardEntries;

		// Token: 0x04001ECF RID: 7887
		private static readonly IntPtr NativeFieldInfoPtr_m_cEntryCount;

		// Token: 0x04001ED0 RID: 7888
		[FieldOffset(0)]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		// Token: 0x04001ED1 RID: 7889
		[FieldOffset(8)]
		public SteamLeaderboardEntries_t m_hSteamLeaderboardEntries;

		// Token: 0x04001ED2 RID: 7890
		[FieldOffset(16)]
		public int m_cEntryCount;
	}
}

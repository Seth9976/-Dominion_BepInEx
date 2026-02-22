using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000230 RID: 560
	[StructLayout(2)]
	public struct LeaderboardScoreUploaded_t
	{
		// Token: 0x06002556 RID: 9558 RVA: 0x000A8BD8 File Offset: 0x000A6DD8
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardScoreUploaded_t()
		{
			Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LeaderboardScoreUploaded_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr);
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "k_iCallback");
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_m_bSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "m_bSuccess");
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_m_hSteamLeaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "m_hSteamLeaderboard");
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_m_nScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "m_nScore");
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_m_bScoreChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "m_bScoreChanged");
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_m_nGlobalRankNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "m_nGlobalRankNew");
			LeaderboardScoreUploaded_t.NativeFieldInfoPtr_m_nGlobalRankPrevious = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, "m_nGlobalRankPrevious");
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x0000EBD4 File Offset: 0x0000CDD4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardScoreUploaded_t>.NativeClassPtr, ref this));
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06002558 RID: 9560 RVA: 0x000A8C94 File Offset: 0x000A6E94
		// (set) Token: 0x06002559 RID: 9561 RVA: 0x0000EBE6 File Offset: 0x0000CDE6
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LeaderboardScoreUploaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeaderboardScoreUploaded_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001ED3 RID: 7891
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001ED4 RID: 7892
		private static readonly IntPtr NativeFieldInfoPtr_m_bSuccess;

		// Token: 0x04001ED5 RID: 7893
		private static readonly IntPtr NativeFieldInfoPtr_m_hSteamLeaderboard;

		// Token: 0x04001ED6 RID: 7894
		private static readonly IntPtr NativeFieldInfoPtr_m_nScore;

		// Token: 0x04001ED7 RID: 7895
		private static readonly IntPtr NativeFieldInfoPtr_m_bScoreChanged;

		// Token: 0x04001ED8 RID: 7896
		private static readonly IntPtr NativeFieldInfoPtr_m_nGlobalRankNew;

		// Token: 0x04001ED9 RID: 7897
		private static readonly IntPtr NativeFieldInfoPtr_m_nGlobalRankPrevious;

		// Token: 0x04001EDA RID: 7898
		[FieldOffset(0)]
		public byte m_bSuccess;

		// Token: 0x04001EDB RID: 7899
		[FieldOffset(8)]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		// Token: 0x04001EDC RID: 7900
		[FieldOffset(16)]
		public int m_nScore;

		// Token: 0x04001EDD RID: 7901
		[FieldOffset(20)]
		public byte m_bScoreChanged;

		// Token: 0x04001EDE RID: 7902
		[FieldOffset(24)]
		public int m_nGlobalRankNew;

		// Token: 0x04001EDF RID: 7903
		[FieldOffset(28)]
		public int m_nGlobalRankPrevious;
	}
}

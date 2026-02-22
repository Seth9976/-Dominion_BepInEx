using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200022E RID: 558
	[StructLayout(2)]
	public struct LeaderboardFindResult_t
	{
		// Token: 0x0600254E RID: 9550 RVA: 0x000A8AB4 File Offset: 0x000A6CB4
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardFindResult_t()
		{
			Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LeaderboardFindResult_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr);
			LeaderboardFindResult_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr, "k_iCallback");
			LeaderboardFindResult_t.NativeFieldInfoPtr_m_hSteamLeaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr, "m_hSteamLeaderboard");
			LeaderboardFindResult_t.NativeFieldInfoPtr_m_bLeaderboardFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr, "m_bLeaderboardFound");
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x0000EB94 File Offset: 0x0000CD94
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardFindResult_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06002550 RID: 9552 RVA: 0x000A8B20 File Offset: 0x000A6D20
		// (set) Token: 0x06002551 RID: 9553 RVA: 0x0000EBA6 File Offset: 0x0000CDA6
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LeaderboardFindResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeaderboardFindResult_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001EC7 RID: 7879
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001EC8 RID: 7880
		private static readonly IntPtr NativeFieldInfoPtr_m_hSteamLeaderboard;

		// Token: 0x04001EC9 RID: 7881
		private static readonly IntPtr NativeFieldInfoPtr_m_bLeaderboardFound;

		// Token: 0x04001ECA RID: 7882
		[FieldOffset(0)]
		public SteamLeaderboard_t m_hSteamLeaderboard;

		// Token: 0x04001ECB RID: 7883
		[FieldOffset(8)]
		public byte m_bLeaderboardFound;
	}
}

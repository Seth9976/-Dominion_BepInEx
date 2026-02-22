using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000235 RID: 565
	[StructLayout(2)]
	public struct LeaderboardUGCSet_t
	{
		// Token: 0x06002575 RID: 9589 RVA: 0x000A9038 File Offset: 0x000A7238
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardUGCSet_t()
		{
			Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LeaderboardUGCSet_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr);
			LeaderboardUGCSet_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr, "k_iCallback");
			LeaderboardUGCSet_t.NativeFieldInfoPtr_m_eResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr, "m_eResult");
			LeaderboardUGCSet_t.NativeFieldInfoPtr_m_hSteamLeaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr, "m_hSteamLeaderboard");
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x0000ECED File Offset: 0x0000CEED
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardUGCSet_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x000A90A4 File Offset: 0x000A72A4
		// (set) Token: 0x06002578 RID: 9592 RVA: 0x0000ECFF File Offset: 0x0000CEFF
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LeaderboardUGCSet_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LeaderboardUGCSet_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001EF4 RID: 7924
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;

		// Token: 0x04001EF5 RID: 7925
		private static readonly IntPtr NativeFieldInfoPtr_m_eResult;

		// Token: 0x04001EF6 RID: 7926
		private static readonly IntPtr NativeFieldInfoPtr_m_hSteamLeaderboard;

		// Token: 0x04001EF7 RID: 7927
		[FieldOffset(0)]
		public EResult m_eResult;

		// Token: 0x04001EF8 RID: 7928
		[FieldOffset(8)]
		public SteamLeaderboard_t m_hSteamLeaderboard;
	}
}

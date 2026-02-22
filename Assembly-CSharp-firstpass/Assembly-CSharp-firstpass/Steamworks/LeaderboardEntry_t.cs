using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002B1 RID: 689
	[StructLayout(2)]
	public struct LeaderboardEntry_t
	{
		// Token: 0x0600278B RID: 10123 RVA: 0x000ACA6C File Offset: 0x000AAC6C
		// Note: this type is marked as 'beforefieldinit'.
		static LeaderboardEntry_t()
		{
			Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "LeaderboardEntry_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr);
			LeaderboardEntry_t.NativeFieldInfoPtr_m_steamIDUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr, "m_steamIDUser");
			LeaderboardEntry_t.NativeFieldInfoPtr_m_nGlobalRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr, "m_nGlobalRank");
			LeaderboardEntry_t.NativeFieldInfoPtr_m_nScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr, "m_nScore");
			LeaderboardEntry_t.NativeFieldInfoPtr_m_cDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr, "m_cDetails");
			LeaderboardEntry_t.NativeFieldInfoPtr_m_hUGC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr, "m_hUGC");
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x0000FE01 File Offset: 0x0000E001
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardEntry_t>.NativeClassPtr, ref this));
		}

		// Token: 0x040026C4 RID: 9924
		private static readonly IntPtr NativeFieldInfoPtr_m_steamIDUser;

		// Token: 0x040026C5 RID: 9925
		private static readonly IntPtr NativeFieldInfoPtr_m_nGlobalRank;

		// Token: 0x040026C6 RID: 9926
		private static readonly IntPtr NativeFieldInfoPtr_m_nScore;

		// Token: 0x040026C7 RID: 9927
		private static readonly IntPtr NativeFieldInfoPtr_m_cDetails;

		// Token: 0x040026C8 RID: 9928
		private static readonly IntPtr NativeFieldInfoPtr_m_hUGC;

		// Token: 0x040026C9 RID: 9929
		[FieldOffset(0)]
		public CSteamID m_steamIDUser;

		// Token: 0x040026CA RID: 9930
		[FieldOffset(8)]
		public int m_nGlobalRank;

		// Token: 0x040026CB RID: 9931
		[FieldOffset(12)]
		public int m_nScore;

		// Token: 0x040026CC RID: 9932
		[FieldOffset(16)]
		public int m_cDetails;

		// Token: 0x040026CD RID: 9933
		[FieldOffset(24)]
		public UGCHandle_t m_hUGC;
	}
}

using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.SocialPlatforms;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public static class Social
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x000025C4 File Offset: 0x000007C4
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		public static UnityEngine.SocialPlatforms.ISocialPlatform Active
		{
			get
			{
				return UnityEngine.SocialPlatforms.ActivePlatform.Instance;
			}
			set
			{
				UnityEngine.SocialPlatforms.ActivePlatform.Instance = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x000025DC File Offset: 0x000007DC
		public static UnityEngine.SocialPlatforms.ILocalUser localUser
		{
			get
			{
				return Social.Active.localUser;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000205A File Offset: 0x0000025A
		public static void LoadUsers(Il2CppStringArray userIDs, Action<Il2CppReferenceArray<UnityEngine.SocialPlatforms.IUserProfile>> callback)
		{
			Social.Active.LoadUsers(userIDs, callback);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000206A File Offset: 0x0000026A
		public static void ReportProgress(string achievementID, double progress, Action<bool> callback)
		{
			Social.Active.ReportProgress(achievementID, progress, callback);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000207B File Offset: 0x0000027B
		public static void LoadAchievementDescriptions(Action<Il2CppReferenceArray<UnityEngine.SocialPlatforms.IAchievementDescription>> callback)
		{
			Social.Active.LoadAchievementDescriptions(callback);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000208A File Offset: 0x0000028A
		public static void LoadAchievements(Action<Il2CppReferenceArray<UnityEngine.SocialPlatforms.IAchievement>> callback)
		{
			Social.Active.LoadAchievements(callback);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002099 File Offset: 0x00000299
		public static void ReportScore(long score, string board, Action<bool> callback)
		{
			Social.Active.ReportScore(score, board, callback);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020AA File Offset: 0x000002AA
		public static void LoadScores(string leaderboardID, Action<Il2CppReferenceArray<UnityEngine.SocialPlatforms.IScore>> callback)
		{
			Social.Active.LoadScores(leaderboardID, callback);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000025F8 File Offset: 0x000007F8
		public static UnityEngine.SocialPlatforms.ILeaderboard CreateLeaderboard()
		{
			return Social.Active.CreateLeaderboard();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002614 File Offset: 0x00000814
		public static UnityEngine.SocialPlatforms.IAchievement CreateAchievement()
		{
			return Social.Active.CreateAchievement();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020BA File Offset: 0x000002BA
		public static void ShowAchievementsUI()
		{
			Social.Active.ShowAchievementsUI();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020C8 File Offset: 0x000002C8
		public static void ShowLeaderboardUI()
		{
			Social.Active.ShowLeaderboardUI();
		}
	}
}

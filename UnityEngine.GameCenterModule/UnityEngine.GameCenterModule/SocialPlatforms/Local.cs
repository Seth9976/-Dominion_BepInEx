using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.SocialPlatforms.Impl;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x02000003 RID: 3
	public class Local
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020D6 File Offset: 0x000002D6
		public ILocalUser localUser
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020E3 File Offset: 0x000002E3
		public void UnityEngine.SocialPlatforms.ISocialPlatform.Authenticate(ILocalUser user, Action<bool> callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020F0 File Offset: 0x000002F0
		public void UnityEngine.SocialPlatforms.ISocialPlatform.LoadFriends(ILocalUser user, Action<bool> callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020FD File Offset: 0x000002FD
		public void LoadUsers(Il2CppStringArray userIDs, Action<Il2CppReferenceArray<IUserProfile>> callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000210A File Offset: 0x0000030A
		public void ReportProgress(string id, double progress, Action<bool> callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002117 File Offset: 0x00000317
		public void LoadAchievementDescriptions(Action<Il2CppReferenceArray<IAchievementDescription>> callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002124 File Offset: 0x00000324
		public void LoadAchievements(Action<Il2CppReferenceArray<IAchievement>> callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002131 File Offset: 0x00000331
		public void ReportScore(long score, string board, Action<bool> callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000213E File Offset: 0x0000033E
		public void LoadScores(string leaderboardID, Action<Il2CppReferenceArray<IScore>> callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000214B File Offset: 0x0000034B
		public void UnityEngine.SocialPlatforms.ISocialPlatform.LoadScores(ILeaderboard board, Action<bool> callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002630 File Offset: 0x00000830
		public bool UnityEngine.SocialPlatforms.ISocialPlatform.GetLoading(ILeaderboard board)
		{
			bool flag = !this.VerifyUser();
			return !flag && board.Cast<UnityEngine.SocialPlatforms.Impl.Leaderboard>().loading;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002158 File Offset: 0x00000358
		public void SortScores(UnityEngine.SocialPlatforms.Impl.Leaderboard board)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002165 File Offset: 0x00000365
		public void SetLocalPlayerScore(UnityEngine.SocialPlatforms.Impl.Leaderboard board)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002172 File Offset: 0x00000372
		public void ShowAchievementsUI()
		{
			Debug.Log("ShowAchievementsUI not implemented");
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002180 File Offset: 0x00000380
		public void ShowLeaderboardUI()
		{
			Debug.Log("ShowLeaderboardUI not implemented");
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002660 File Offset: 0x00000860
		public ILeaderboard CreateLeaderboard()
		{
			return new UnityEngine.SocialPlatforms.Impl.Leaderboard();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000267C File Offset: 0x0000087C
		public IAchievement CreateAchievement()
		{
			return new UnityEngine.SocialPlatforms.Impl.Achievement();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002698 File Offset: 0x00000898
		public bool VerifyUser()
		{
			bool flag = !this.localUser.authenticated;
			bool flag2;
			if (flag)
			{
				Debug.LogError("Must authenticate first");
				flag2 = false;
			}
			else
			{
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000218E File Offset: 0x0000038E
		public void PopulateStaticData()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000026D0 File Offset: 0x000008D0
		public Texture2D CreateDummyTexture(int width, int height)
		{
			Texture2D texture2D = new Texture2D(width, height);
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					Color color = (((j & i) > 0) ? Color.white : Color.gray);
					texture2D.SetPixel(j, i, color);
				}
			}
			texture2D.Apply();
			return texture2D;
		}

		// Token: 0x02000015 RID: 21
		public sealed class <>c__DisplayClass10_0
		{
		}

		// Token: 0x02000016 RID: 22
		[Serializable]
		public sealed class <>c
		{
		}
	}
}

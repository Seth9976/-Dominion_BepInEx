using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x02000014 RID: 20
	public class Leaderboard
	{
		// Token: 0x06000060 RID: 96 RVA: 0x000024D6 File Offset: 0x000006D6
		public void SetUserFilter(Il2CppStringArray userIDs)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000024E3 File Offset: 0x000006E3
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000024F0 File Offset: 0x000006F0
		public void LoadScores(Action<bool> callback)
		{
			ActivePlatform.Instance.LoadScores(this, callback);
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002754 File Offset: 0x00000954
		public bool loading
		{
			get
			{
				return ActivePlatform.Instance.GetLoading(this);
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002500 File Offset: 0x00000700
		public void SetLocalUserScore(IScore score)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000250D File Offset: 0x0000070D
		public void SetMaxRange(uint maxRange)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000251A File Offset: 0x0000071A
		public void SetScores(Il2CppReferenceArray<IScore> scores)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002527 File Offset: 0x00000727
		public void SetTitle(string title)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002534 File Offset: 0x00000734
		public Il2CppStringArray GetUserFilter()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002541 File Offset: 0x00000741
		// (set) Token: 0x0600006A RID: 106 RVA: 0x0000254E File Offset: 0x0000074E
		public string id
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0000255B File Offset: 0x0000075B
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002568 File Offset: 0x00000768
		public UserScope userScope
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002575 File Offset: 0x00000775
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00002582 File Offset: 0x00000782
		public TimeScope timeScope
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0000258F File Offset: 0x0000078F
		public IScore localUserScore
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0000259C File Offset: 0x0000079C
		public uint maxRange
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000025A9 File Offset: 0x000007A9
		public Il2CppReferenceArray<IScore> scores
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000025B6 File Offset: 0x000007B6
		public string title
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}

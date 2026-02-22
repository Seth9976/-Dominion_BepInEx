using System;
using Il2CppSystem;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x02000013 RID: 19
	public class Score
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00002412 File Offset: 0x00000612
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000241F File Offset: 0x0000061F
		public void ReportScore(Action<bool> callback)
		{
			ActivePlatform.Instance.ReportScore(this.value, this.leaderboardID, callback);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000243A File Offset: 0x0000063A
		public void SetDate(DateTime date)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002447 File Offset: 0x00000647
		public void SetFormattedValue(string value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002454 File Offset: 0x00000654
		public void SetUserID(string userID)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002461 File Offset: 0x00000661
		public void SetRank(int rank)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000246E File Offset: 0x0000066E
		// (set) Token: 0x06000059 RID: 89 RVA: 0x0000247B File Offset: 0x0000067B
		public string leaderboardID
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

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002488 File Offset: 0x00000688
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002495 File Offset: 0x00000695
		public long value
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

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000024A2 File Offset: 0x000006A2
		public DateTime date
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000024AF File Offset: 0x000006AF
		public string formattedValue
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000024BC File Offset: 0x000006BC
		public string userID
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000024C9 File Offset: 0x000006C9
		public int rank
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}

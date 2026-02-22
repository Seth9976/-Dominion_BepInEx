using System;
using Il2CppSystem;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x02000011 RID: 17
	public class Achievement
	{
		// Token: 0x0600003C RID: 60 RVA: 0x000022E6 File Offset: 0x000004E6
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000022F3 File Offset: 0x000004F3
		public void ReportProgress(Action<bool> callback)
		{
			ActivePlatform.Instance.ReportProgress(this.id, this.percentCompleted, callback);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000230E File Offset: 0x0000050E
		public void SetCompleted(bool value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000231B File Offset: 0x0000051B
		public void SetHidden(bool value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002328 File Offset: 0x00000528
		public void SetLastReportedDate(DateTime date)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002335 File Offset: 0x00000535
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002342 File Offset: 0x00000542
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

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0000234F File Offset: 0x0000054F
		// (set) Token: 0x06000044 RID: 68 RVA: 0x0000235C File Offset: 0x0000055C
		public double percentCompleted
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

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002369 File Offset: 0x00000569
		public bool completed
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002376 File Offset: 0x00000576
		public bool hidden
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002383 File Offset: 0x00000583
		public DateTime lastReportedDate
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}

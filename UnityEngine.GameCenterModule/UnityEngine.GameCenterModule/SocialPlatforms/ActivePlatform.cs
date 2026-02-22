using System;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x02000004 RID: 4
	public static class ActivePlatform
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000219B File Offset: 0x0000039B
		// (set) Token: 0x06000023 RID: 35 RVA: 0x000021A8 File Offset: 0x000003A8
		public static ISocialPlatform Instance
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

		// Token: 0x06000024 RID: 36 RVA: 0x0000273C File Offset: 0x0000093C
		public static ISocialPlatform SelectSocialPlatform()
		{
			return new Local();
		}
	}
}

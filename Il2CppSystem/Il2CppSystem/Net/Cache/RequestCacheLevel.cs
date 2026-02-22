using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Cache
{
	// Token: 0x0200014A RID: 330
	[OriginalName("System.dll", "System.Net.Cache", "RequestCacheLevel")]
	public enum RequestCacheLevel
	{
		// Token: 0x0400111B RID: 4379
		Default,
		// Token: 0x0400111C RID: 4380
		BypassCache,
		// Token: 0x0400111D RID: 4381
		CacheOnly,
		// Token: 0x0400111E RID: 4382
		CacheIfAvailable,
		// Token: 0x0400111F RID: 4383
		Revalidate,
		// Token: 0x04001120 RID: 4384
		Reload,
		// Token: 0x04001121 RID: 4385
		NoCacheNoStore
	}
}

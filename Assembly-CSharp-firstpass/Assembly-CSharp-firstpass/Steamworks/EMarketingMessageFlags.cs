using System;

namespace Steamworks
{
	// Token: 0x0200028E RID: 654
	[Flags]
	public enum EMarketingMessageFlags
	{
		// Token: 0x040024EB RID: 9451
		k_EMarketingMessageFlagsNone = 0,
		// Token: 0x040024EC RID: 9452
		k_EMarketingMessageFlagsHighPriority = 1,
		// Token: 0x040024ED RID: 9453
		k_EMarketingMessageFlagsPlatformWindows = 2,
		// Token: 0x040024EE RID: 9454
		k_EMarketingMessageFlagsPlatformMac = 4,
		// Token: 0x040024EF RID: 9455
		k_EMarketingMessageFlagsPlatformLinux = 8,
		// Token: 0x040024F0 RID: 9456
		k_EMarketingMessageFlagsPlatformRestrictions = 14
	}
}

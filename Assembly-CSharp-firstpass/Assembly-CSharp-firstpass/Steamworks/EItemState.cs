using System;

namespace Steamworks
{
	// Token: 0x02000271 RID: 625
	[Flags]
	public enum EItemState
	{
		// Token: 0x0400238B RID: 9099
		k_EItemStateNone = 0,
		// Token: 0x0400238C RID: 9100
		k_EItemStateSubscribed = 1,
		// Token: 0x0400238D RID: 9101
		k_EItemStateLegacyItem = 2,
		// Token: 0x0400238E RID: 9102
		k_EItemStateInstalled = 4,
		// Token: 0x0400238F RID: 9103
		k_EItemStateNeedsUpdate = 8,
		// Token: 0x04002390 RID: 9104
		k_EItemStateDownloading = 16,
		// Token: 0x04002391 RID: 9105
		k_EItemStateDownloadPending = 32
	}
}

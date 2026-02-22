using System;

namespace UnityEngine.Android
{
	// Token: 0x02000010 RID: 16
	public enum AndroidAssetPackError
	{
		// Token: 0x04000161 RID: 353
		NoError,
		// Token: 0x04000162 RID: 354
		AppUnavailable = -1,
		// Token: 0x04000163 RID: 355
		PackUnavailable = -2,
		// Token: 0x04000164 RID: 356
		InvalidRequest = -3,
		// Token: 0x04000165 RID: 357
		DownloadNotFound = -4,
		// Token: 0x04000166 RID: 358
		ApiNotAvailable = -5,
		// Token: 0x04000167 RID: 359
		NetworkError = -6,
		// Token: 0x04000168 RID: 360
		AccessDenied = -7,
		// Token: 0x04000169 RID: 361
		InsufficientStorage = -10,
		// Token: 0x0400016A RID: 362
		PlayStoreNotFound = -11,
		// Token: 0x0400016B RID: 363
		NetworkUnrestricted = -12,
		// Token: 0x0400016C RID: 364
		AppNotOwned = -13,
		// Token: 0x0400016D RID: 365
		InternalError = -100
	}
}

using System;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	public enum AssetBundleLoadResult
	{
		// Token: 0x0400000B RID: 11
		Success,
		// Token: 0x0400000C RID: 12
		Cancelled,
		// Token: 0x0400000D RID: 13
		NotMatchingCrc,
		// Token: 0x0400000E RID: 14
		FailedCache,
		// Token: 0x0400000F RID: 15
		NotValidAssetBundle,
		// Token: 0x04000010 RID: 16
		NoSerializedData,
		// Token: 0x04000011 RID: 17
		NotCompatible,
		// Token: 0x04000012 RID: 18
		AlreadyLoaded,
		// Token: 0x04000013 RID: 19
		FailedRead,
		// Token: 0x04000014 RID: 20
		FailedDecompression,
		// Token: 0x04000015 RID: 21
		FailedWrite,
		// Token: 0x04000016 RID: 22
		FailedDeleteRecompressionTarget,
		// Token: 0x04000017 RID: 23
		RecompressionTargetIsLoaded,
		// Token: 0x04000018 RID: 24
		RecompressionTargetExistsButNotArchive
	}
}

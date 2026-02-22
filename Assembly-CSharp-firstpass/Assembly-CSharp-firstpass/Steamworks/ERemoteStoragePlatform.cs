using System;

namespace Steamworks
{
	// Token: 0x02000263 RID: 611
	[Flags]
	public enum ERemoteStoragePlatform
	{
		// Token: 0x0400230F RID: 8975
		k_ERemoteStoragePlatformNone = 0,
		// Token: 0x04002310 RID: 8976
		k_ERemoteStoragePlatformWindows = 1,
		// Token: 0x04002311 RID: 8977
		k_ERemoteStoragePlatformOSX = 2,
		// Token: 0x04002312 RID: 8978
		k_ERemoteStoragePlatformPS3 = 4,
		// Token: 0x04002313 RID: 8979
		k_ERemoteStoragePlatformLinux = 8,
		// Token: 0x04002314 RID: 8980
		k_ERemoteStoragePlatformSwitch = 16,
		// Token: 0x04002315 RID: 8981
		k_ERemoteStoragePlatformAndroid = 32,
		// Token: 0x04002316 RID: 8982
		k_ERemoteStoragePlatformIOS = 64,
		// Token: 0x04002317 RID: 8983
		k_ERemoteStoragePlatformAll = -1
	}
}

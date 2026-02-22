using System;

namespace Steamworks
{
	// Token: 0x02000289 RID: 649
	[Flags]
	public enum EAppType
	{
		// Token: 0x040024AF RID: 9391
		k_EAppType_Invalid = 0,
		// Token: 0x040024B0 RID: 9392
		k_EAppType_Game = 1,
		// Token: 0x040024B1 RID: 9393
		k_EAppType_Application = 2,
		// Token: 0x040024B2 RID: 9394
		k_EAppType_Tool = 4,
		// Token: 0x040024B3 RID: 9395
		k_EAppType_Demo = 8,
		// Token: 0x040024B4 RID: 9396
		k_EAppType_Media_DEPRECATED = 16,
		// Token: 0x040024B5 RID: 9397
		k_EAppType_DLC = 32,
		// Token: 0x040024B6 RID: 9398
		k_EAppType_Guide = 64,
		// Token: 0x040024B7 RID: 9399
		k_EAppType_Driver = 128,
		// Token: 0x040024B8 RID: 9400
		k_EAppType_Config = 256,
		// Token: 0x040024B9 RID: 9401
		k_EAppType_Hardware = 512,
		// Token: 0x040024BA RID: 9402
		k_EAppType_Franchise = 1024,
		// Token: 0x040024BB RID: 9403
		k_EAppType_Video = 2048,
		// Token: 0x040024BC RID: 9404
		k_EAppType_Plugin = 4096,
		// Token: 0x040024BD RID: 9405
		k_EAppType_MusicAlbum = 8192,
		// Token: 0x040024BE RID: 9406
		k_EAppType_Series = 16384,
		// Token: 0x040024BF RID: 9407
		k_EAppType_Comic_UNUSED = 32768,
		// Token: 0x040024C0 RID: 9408
		k_EAppType_Beta = 65536,
		// Token: 0x040024C1 RID: 9409
		k_EAppType_Shortcut = 1073741824,
		// Token: 0x040024C2 RID: 9410
		k_EAppType_DepotOnly = -2147483647
	}
}

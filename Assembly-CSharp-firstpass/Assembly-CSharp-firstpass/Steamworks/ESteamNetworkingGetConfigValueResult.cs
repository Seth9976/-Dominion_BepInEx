using System;

namespace Steamworks
{
	// Token: 0x020002A4 RID: 676
	public enum ESteamNetworkingGetConfigValueResult
	{
		// Token: 0x0400263B RID: 9787
		k_ESteamNetworkingGetConfigValue_BadValue = -1,
		// Token: 0x0400263C RID: 9788
		k_ESteamNetworkingGetConfigValue_BadScopeObj = -2,
		// Token: 0x0400263D RID: 9789
		k_ESteamNetworkingGetConfigValue_BufferTooSmall = -3,
		// Token: 0x0400263E RID: 9790
		k_ESteamNetworkingGetConfigValue_OK = 1,
		// Token: 0x0400263F RID: 9791
		k_ESteamNetworkingGetConfigValue_OKInherited,
		// Token: 0x04002640 RID: 9792
		k_ESteamNetworkingGetConfigValueResult__Force32Bit = 2147483647
	}
}

using System;

namespace Steamworks
{
	// Token: 0x0200029D RID: 669
	public enum ESteamNetworkingAvailability
	{
		// Token: 0x040025BA RID: 9658
		k_ESteamNetworkingAvailability_CannotTry = -102,
		// Token: 0x040025BB RID: 9659
		k_ESteamNetworkingAvailability_Failed,
		// Token: 0x040025BC RID: 9660
		k_ESteamNetworkingAvailability_Previously,
		// Token: 0x040025BD RID: 9661
		k_ESteamNetworkingAvailability_Retrying = -10,
		// Token: 0x040025BE RID: 9662
		k_ESteamNetworkingAvailability_NeverTried = 1,
		// Token: 0x040025BF RID: 9663
		k_ESteamNetworkingAvailability_Waiting,
		// Token: 0x040025C0 RID: 9664
		k_ESteamNetworkingAvailability_Attempting,
		// Token: 0x040025C1 RID: 9665
		k_ESteamNetworkingAvailability_Current = 100,
		// Token: 0x040025C2 RID: 9666
		k_ESteamNetworkingAvailability_Unknown = 0,
		// Token: 0x040025C3 RID: 9667
		k_ESteamNetworkingAvailability__Force32bit = 2147483647
	}
}

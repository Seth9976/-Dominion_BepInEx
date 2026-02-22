using System;

namespace Steamworks
{
	// Token: 0x02000279 RID: 633
	public enum ESteamAPICallFailure
	{
		// Token: 0x040023BD RID: 9149
		k_ESteamAPICallFailureNone = -1,
		// Token: 0x040023BE RID: 9150
		k_ESteamAPICallFailureSteamGone,
		// Token: 0x040023BF RID: 9151
		k_ESteamAPICallFailureNetworkFailure,
		// Token: 0x040023C0 RID: 9152
		k_ESteamAPICallFailureInvalidHandle,
		// Token: 0x040023C1 RID: 9153
		k_ESteamAPICallFailureMismatchedCallback
	}
}

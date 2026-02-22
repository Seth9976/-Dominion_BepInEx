using System;

namespace Steamworks
{
	// Token: 0x0200029F RID: 671
	public enum ESteamNetworkingConnectionState
	{
		// Token: 0x040025CD RID: 9677
		k_ESteamNetworkingConnectionState_None,
		// Token: 0x040025CE RID: 9678
		k_ESteamNetworkingConnectionState_Connecting,
		// Token: 0x040025CF RID: 9679
		k_ESteamNetworkingConnectionState_FindingRoute,
		// Token: 0x040025D0 RID: 9680
		k_ESteamNetworkingConnectionState_Connected,
		// Token: 0x040025D1 RID: 9681
		k_ESteamNetworkingConnectionState_ClosedByPeer,
		// Token: 0x040025D2 RID: 9682
		k_ESteamNetworkingConnectionState_ProblemDetectedLocally,
		// Token: 0x040025D3 RID: 9683
		k_ESteamNetworkingConnectionState_FinWait = -1,
		// Token: 0x040025D4 RID: 9684
		k_ESteamNetworkingConnectionState_Linger = -2,
		// Token: 0x040025D5 RID: 9685
		k_ESteamNetworkingConnectionState_Dead = -3,
		// Token: 0x040025D6 RID: 9686
		k_ESteamNetworkingConnectionState__Force32Bit = 2147483647
	}
}

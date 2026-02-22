using System;

namespace Steamworks
{
	// Token: 0x020002A0 RID: 672
	public enum ESteamNetConnectionEnd
	{
		// Token: 0x040025D8 RID: 9688
		k_ESteamNetConnectionEnd_Invalid,
		// Token: 0x040025D9 RID: 9689
		k_ESteamNetConnectionEnd_App_Min = 1000,
		// Token: 0x040025DA RID: 9690
		k_ESteamNetConnectionEnd_App_Generic = 1000,
		// Token: 0x040025DB RID: 9691
		k_ESteamNetConnectionEnd_App_Max = 1999,
		// Token: 0x040025DC RID: 9692
		k_ESteamNetConnectionEnd_AppException_Min,
		// Token: 0x040025DD RID: 9693
		k_ESteamNetConnectionEnd_AppException_Generic = 2000,
		// Token: 0x040025DE RID: 9694
		k_ESteamNetConnectionEnd_AppException_Max = 2999,
		// Token: 0x040025DF RID: 9695
		k_ESteamNetConnectionEnd_Local_Min,
		// Token: 0x040025E0 RID: 9696
		k_ESteamNetConnectionEnd_Local_OfflineMode,
		// Token: 0x040025E1 RID: 9697
		k_ESteamNetConnectionEnd_Local_ManyRelayConnectivity,
		// Token: 0x040025E2 RID: 9698
		k_ESteamNetConnectionEnd_Local_HostedServerPrimaryRelay,
		// Token: 0x040025E3 RID: 9699
		k_ESteamNetConnectionEnd_Local_NetworkConfig,
		// Token: 0x040025E4 RID: 9700
		k_ESteamNetConnectionEnd_Local_Rights,
		// Token: 0x040025E5 RID: 9701
		k_ESteamNetConnectionEnd_Local_P2P_ICE_NoPublicAddresses,
		// Token: 0x040025E6 RID: 9702
		k_ESteamNetConnectionEnd_Local_Max = 3999,
		// Token: 0x040025E7 RID: 9703
		k_ESteamNetConnectionEnd_Remote_Min,
		// Token: 0x040025E8 RID: 9704
		k_ESteamNetConnectionEnd_Remote_Timeout,
		// Token: 0x040025E9 RID: 9705
		k_ESteamNetConnectionEnd_Remote_BadCrypt,
		// Token: 0x040025EA RID: 9706
		k_ESteamNetConnectionEnd_Remote_BadCert,
		// Token: 0x040025EB RID: 9707
		k_ESteamNetConnectionEnd_Remote_NotLoggedIn,
		// Token: 0x040025EC RID: 9708
		k_ESteamNetConnectionEnd_Remote_NotRunningApp,
		// Token: 0x040025ED RID: 9709
		k_ESteamNetConnectionEnd_Remote_BadProtocolVersion,
		// Token: 0x040025EE RID: 9710
		k_ESteamNetConnectionEnd_Remote_P2P_ICE_NoPublicAddresses,
		// Token: 0x040025EF RID: 9711
		k_ESteamNetConnectionEnd_Remote_Max = 4999,
		// Token: 0x040025F0 RID: 9712
		k_ESteamNetConnectionEnd_Misc_Min,
		// Token: 0x040025F1 RID: 9713
		k_ESteamNetConnectionEnd_Misc_Generic,
		// Token: 0x040025F2 RID: 9714
		k_ESteamNetConnectionEnd_Misc_InternalError,
		// Token: 0x040025F3 RID: 9715
		k_ESteamNetConnectionEnd_Misc_Timeout,
		// Token: 0x040025F4 RID: 9716
		k_ESteamNetConnectionEnd_Misc_RelayConnectivity,
		// Token: 0x040025F5 RID: 9717
		k_ESteamNetConnectionEnd_Misc_SteamConnectivity,
		// Token: 0x040025F6 RID: 9718
		k_ESteamNetConnectionEnd_Misc_NoRelaySessionsToClient,
		// Token: 0x040025F7 RID: 9719
		k_ESteamNetConnectionEnd_Misc_P2P_Rendezvous = 5008,
		// Token: 0x040025F8 RID: 9720
		k_ESteamNetConnectionEnd_Misc_P2P_NAT_Firewall,
		// Token: 0x040025F9 RID: 9721
		k_ESteamNetConnectionEnd_Misc_PeerSentNoConnection,
		// Token: 0x040025FA RID: 9722
		k_ESteamNetConnectionEnd_Misc_Max = 5999,
		// Token: 0x040025FB RID: 9723
		k_ESteamNetConnectionEnd__Force32Bit = 2147483647
	}
}

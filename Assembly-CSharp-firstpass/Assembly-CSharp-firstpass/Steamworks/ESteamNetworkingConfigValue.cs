using System;

namespace Steamworks
{
	// Token: 0x020002A3 RID: 675
	public enum ESteamNetworkingConfigValue
	{
		// Token: 0x0400260A RID: 9738
		k_ESteamNetworkingConfig_Invalid,
		// Token: 0x0400260B RID: 9739
		k_ESteamNetworkingConfig_FakePacketLoss_Send = 2,
		// Token: 0x0400260C RID: 9740
		k_ESteamNetworkingConfig_FakePacketLoss_Recv,
		// Token: 0x0400260D RID: 9741
		k_ESteamNetworkingConfig_FakePacketLag_Send,
		// Token: 0x0400260E RID: 9742
		k_ESteamNetworkingConfig_FakePacketLag_Recv,
		// Token: 0x0400260F RID: 9743
		k_ESteamNetworkingConfig_FakePacketReorder_Send,
		// Token: 0x04002610 RID: 9744
		k_ESteamNetworkingConfig_FakePacketReorder_Recv,
		// Token: 0x04002611 RID: 9745
		k_ESteamNetworkingConfig_FakePacketReorder_Time,
		// Token: 0x04002612 RID: 9746
		k_ESteamNetworkingConfig_FakePacketDup_Send = 26,
		// Token: 0x04002613 RID: 9747
		k_ESteamNetworkingConfig_FakePacketDup_Recv,
		// Token: 0x04002614 RID: 9748
		k_ESteamNetworkingConfig_FakePacketDup_TimeMax,
		// Token: 0x04002615 RID: 9749
		k_ESteamNetworkingConfig_TimeoutInitial = 24,
		// Token: 0x04002616 RID: 9750
		k_ESteamNetworkingConfig_TimeoutConnected,
		// Token: 0x04002617 RID: 9751
		k_ESteamNetworkingConfig_SendBufferSize = 9,
		// Token: 0x04002618 RID: 9752
		k_ESteamNetworkingConfig_SendRateMin,
		// Token: 0x04002619 RID: 9753
		k_ESteamNetworkingConfig_SendRateMax,
		// Token: 0x0400261A RID: 9754
		k_ESteamNetworkingConfig_NagleTime,
		// Token: 0x0400261B RID: 9755
		k_ESteamNetworkingConfig_IP_AllowWithoutAuth = 23,
		// Token: 0x0400261C RID: 9756
		k_ESteamNetworkingConfig_MTU_PacketSize = 32,
		// Token: 0x0400261D RID: 9757
		k_ESteamNetworkingConfig_MTU_DataSize,
		// Token: 0x0400261E RID: 9758
		k_ESteamNetworkingConfig_Unencrypted,
		// Token: 0x0400261F RID: 9759
		k_ESteamNetworkingConfig_EnumerateDevVars,
		// Token: 0x04002620 RID: 9760
		k_ESteamNetworkingConfig_SymmetricConnect = 37,
		// Token: 0x04002621 RID: 9761
		k_ESteamNetworkingConfig_LocalVirtualPort,
		// Token: 0x04002622 RID: 9762
		k_ESteamNetworkingConfig_Callback_ConnectionStatusChanged = 201,
		// Token: 0x04002623 RID: 9763
		k_ESteamNetworkingConfig_Callback_AuthStatusChanged,
		// Token: 0x04002624 RID: 9764
		k_ESteamNetworkingConfig_Callback_RelayNetworkStatusChanged,
		// Token: 0x04002625 RID: 9765
		k_ESteamNetworkingConfig_Callback_MessagesSessionRequest,
		// Token: 0x04002626 RID: 9766
		k_ESteamNetworkingConfig_Callback_MessagesSessionFailed,
		// Token: 0x04002627 RID: 9767
		k_ESteamNetworkingConfig_P2P_STUN_ServerList = 103,
		// Token: 0x04002628 RID: 9768
		k_ESteamNetworkingConfig_P2P_Transport_ICE_Enable,
		// Token: 0x04002629 RID: 9769
		k_ESteamNetworkingConfig_P2P_Transport_ICE_Penalty,
		// Token: 0x0400262A RID: 9770
		k_ESteamNetworkingConfig_P2P_Transport_SDR_Penalty,
		// Token: 0x0400262B RID: 9771
		k_ESteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFailInitial = 19,
		// Token: 0x0400262C RID: 9772
		k_ESteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFail,
		// Token: 0x0400262D RID: 9773
		k_ESteamNetworkingConfig_SDRClient_MinPingsBeforePingAccurate,
		// Token: 0x0400262E RID: 9774
		k_ESteamNetworkingConfig_SDRClient_SingleSocket,
		// Token: 0x0400262F RID: 9775
		k_ESteamNetworkingConfig_SDRClient_ForceRelayCluster = 29,
		// Token: 0x04002630 RID: 9776
		k_ESteamNetworkingConfig_SDRClient_DebugTicketAddress,
		// Token: 0x04002631 RID: 9777
		k_ESteamNetworkingConfig_SDRClient_ForceProxyAddr,
		// Token: 0x04002632 RID: 9778
		k_ESteamNetworkingConfig_SDRClient_FakeClusterPing = 36,
		// Token: 0x04002633 RID: 9779
		k_ESteamNetworkingConfig_LogLevel_AckRTT = 13,
		// Token: 0x04002634 RID: 9780
		k_ESteamNetworkingConfig_LogLevel_PacketDecode,
		// Token: 0x04002635 RID: 9781
		k_ESteamNetworkingConfig_LogLevel_Message,
		// Token: 0x04002636 RID: 9782
		k_ESteamNetworkingConfig_LogLevel_PacketGaps,
		// Token: 0x04002637 RID: 9783
		k_ESteamNetworkingConfig_LogLevel_P2PRendezvous,
		// Token: 0x04002638 RID: 9784
		k_ESteamNetworkingConfig_LogLevel_SDRRelayPings,
		// Token: 0x04002639 RID: 9785
		k_ESteamNetworkingConfigValue__Force32Bit = 2147483647
	}
}

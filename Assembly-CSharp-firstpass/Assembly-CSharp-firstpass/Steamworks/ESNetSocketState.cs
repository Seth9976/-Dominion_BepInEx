using System;

namespace Steamworks
{
	// Token: 0x0200025F RID: 607
	public enum ESNetSocketState
	{
		// Token: 0x040022E9 RID: 8937
		k_ESNetSocketStateInvalid,
		// Token: 0x040022EA RID: 8938
		k_ESNetSocketStateConnected,
		// Token: 0x040022EB RID: 8939
		k_ESNetSocketStateInitiated = 10,
		// Token: 0x040022EC RID: 8940
		k_ESNetSocketStateLocalCandidatesFound,
		// Token: 0x040022ED RID: 8941
		k_ESNetSocketStateReceivedRemoteCandidates,
		// Token: 0x040022EE RID: 8942
		k_ESNetSocketStateChallengeHandshake = 15,
		// Token: 0x040022EF RID: 8943
		k_ESNetSocketStateDisconnecting = 21,
		// Token: 0x040022F0 RID: 8944
		k_ESNetSocketStateLocalDisconnect,
		// Token: 0x040022F1 RID: 8945
		k_ESNetSocketStateTimeoutDuringConnect,
		// Token: 0x040022F2 RID: 8946
		k_ESNetSocketStateRemoteEndDisconnected,
		// Token: 0x040022F3 RID: 8947
		k_ESNetSocketStateConnectionBroken
	}
}

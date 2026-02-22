using System;

namespace Steamworks
{
	// Token: 0x02000249 RID: 585
	[Flags]
	public enum EPersonaChange
	{
		// Token: 0x04002119 RID: 8473
		k_EPersonaChangeName = 1,
		// Token: 0x0400211A RID: 8474
		k_EPersonaChangeStatus = 2,
		// Token: 0x0400211B RID: 8475
		k_EPersonaChangeComeOnline = 4,
		// Token: 0x0400211C RID: 8476
		k_EPersonaChangeGoneOffline = 8,
		// Token: 0x0400211D RID: 8477
		k_EPersonaChangeGamePlayed = 16,
		// Token: 0x0400211E RID: 8478
		k_EPersonaChangeGameServer = 32,
		// Token: 0x0400211F RID: 8479
		k_EPersonaChangeAvatar = 64,
		// Token: 0x04002120 RID: 8480
		k_EPersonaChangeJoinedSource = 128,
		// Token: 0x04002121 RID: 8481
		k_EPersonaChangeLeftSource = 256,
		// Token: 0x04002122 RID: 8482
		k_EPersonaChangeRelationshipChanged = 512,
		// Token: 0x04002123 RID: 8483
		k_EPersonaChangeNameFirstSet = 1024,
		// Token: 0x04002124 RID: 8484
		k_EPersonaChangeBroadcast = 2048,
		// Token: 0x04002125 RID: 8485
		k_EPersonaChangeNickname = 4096,
		// Token: 0x04002126 RID: 8486
		k_EPersonaChangeSteamLevel = 8192,
		// Token: 0x04002127 RID: 8487
		k_EPersonaChangeRichPresence = 16384
	}
}

using System;

namespace Steamworks
{
	// Token: 0x02000246 RID: 582
	public enum EUserRestriction
	{
		// Token: 0x04002109 RID: 8457
		k_nUserRestrictionNone,
		// Token: 0x0400210A RID: 8458
		k_nUserRestrictionUnknown,
		// Token: 0x0400210B RID: 8459
		k_nUserRestrictionAnyChat,
		// Token: 0x0400210C RID: 8460
		k_nUserRestrictionVoiceChat = 4,
		// Token: 0x0400210D RID: 8461
		k_nUserRestrictionGroupChat = 8,
		// Token: 0x0400210E RID: 8462
		k_nUserRestrictionRating = 16,
		// Token: 0x0400210F RID: 8463
		k_nUserRestrictionGameInvites = 32,
		// Token: 0x04002110 RID: 8464
		k_nUserRestrictionTrading = 64
	}
}

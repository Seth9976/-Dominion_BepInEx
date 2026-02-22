using System;

namespace Steamworks
{
	// Token: 0x02000284 RID: 644
	public enum EAuthSessionResponse
	{
		// Token: 0x04002475 RID: 9333
		k_EAuthSessionResponseOK,
		// Token: 0x04002476 RID: 9334
		k_EAuthSessionResponseUserNotConnectedToSteam,
		// Token: 0x04002477 RID: 9335
		k_EAuthSessionResponseNoLicenseOrExpired,
		// Token: 0x04002478 RID: 9336
		k_EAuthSessionResponseVACBanned,
		// Token: 0x04002479 RID: 9337
		k_EAuthSessionResponseLoggedInElseWhere,
		// Token: 0x0400247A RID: 9338
		k_EAuthSessionResponseVACCheckTimedOut,
		// Token: 0x0400247B RID: 9339
		k_EAuthSessionResponseAuthTicketCanceled,
		// Token: 0x0400247C RID: 9340
		k_EAuthSessionResponseAuthTicketInvalidAlreadyUsed,
		// Token: 0x0400247D RID: 9341
		k_EAuthSessionResponseAuthTicketInvalid,
		// Token: 0x0400247E RID: 9342
		k_EAuthSessionResponsePublisherIssuedBan
	}
}

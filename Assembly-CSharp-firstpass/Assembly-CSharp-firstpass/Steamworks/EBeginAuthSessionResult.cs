using System;

namespace Steamworks
{
	// Token: 0x02000283 RID: 643
	public enum EBeginAuthSessionResult
	{
		// Token: 0x0400246E RID: 9326
		k_EBeginAuthSessionResultOK,
		// Token: 0x0400246F RID: 9327
		k_EBeginAuthSessionResultInvalidTicket,
		// Token: 0x04002470 RID: 9328
		k_EBeginAuthSessionResultDuplicateRequest,
		// Token: 0x04002471 RID: 9329
		k_EBeginAuthSessionResultInvalidVersion,
		// Token: 0x04002472 RID: 9330
		k_EBeginAuthSessionResultGameMismatch,
		// Token: 0x04002473 RID: 9331
		k_EBeginAuthSessionResultExpiredTicket
	}
}

using System;

namespace Steamworks
{
	// Token: 0x02000293 RID: 659
	[Flags]
	public enum EMarketNotAllowedReasonFlags
	{
		// Token: 0x04002544 RID: 9540
		k_EMarketNotAllowedReason_None = 0,
		// Token: 0x04002545 RID: 9541
		k_EMarketNotAllowedReason_TemporaryFailure = 1,
		// Token: 0x04002546 RID: 9542
		k_EMarketNotAllowedReason_AccountDisabled = 2,
		// Token: 0x04002547 RID: 9543
		k_EMarketNotAllowedReason_AccountLockedDown = 4,
		// Token: 0x04002548 RID: 9544
		k_EMarketNotAllowedReason_AccountLimited = 8,
		// Token: 0x04002549 RID: 9545
		k_EMarketNotAllowedReason_TradeBanned = 16,
		// Token: 0x0400254A RID: 9546
		k_EMarketNotAllowedReason_AccountNotTrusted = 32,
		// Token: 0x0400254B RID: 9547
		k_EMarketNotAllowedReason_SteamGuardNotEnabled = 64,
		// Token: 0x0400254C RID: 9548
		k_EMarketNotAllowedReason_SteamGuardOnlyRecentlyEnabled = 128,
		// Token: 0x0400254D RID: 9549
		k_EMarketNotAllowedReason_RecentPasswordReset = 256,
		// Token: 0x0400254E RID: 9550
		k_EMarketNotAllowedReason_NewPaymentMethod = 512,
		// Token: 0x0400254F RID: 9551
		k_EMarketNotAllowedReason_InvalidCookie = 1024,
		// Token: 0x04002550 RID: 9552
		k_EMarketNotAllowedReason_UsingNewDevice = 2048,
		// Token: 0x04002551 RID: 9553
		k_EMarketNotAllowedReason_RecentSelfRefund = 4096,
		// Token: 0x04002552 RID: 9554
		k_EMarketNotAllowedReason_NewPaymentMethodCannotBeVerified = 8192,
		// Token: 0x04002553 RID: 9555
		k_EMarketNotAllowedReason_NoRecentPurchases = 16384,
		// Token: 0x04002554 RID: 9556
		k_EMarketNotAllowedReason_AcceptedWalletGift = 32768
	}
}

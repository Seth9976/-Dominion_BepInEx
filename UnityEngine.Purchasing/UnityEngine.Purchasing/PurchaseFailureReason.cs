using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000013 RID: 19
	public enum PurchaseFailureReason
	{
		// Token: 0x04000076 RID: 118
		PurchasingUnavailable,
		// Token: 0x04000077 RID: 119
		ExistingPurchasePending,
		// Token: 0x04000078 RID: 120
		ProductUnavailable,
		// Token: 0x04000079 RID: 121
		SignatureInvalid,
		// Token: 0x0400007A RID: 122
		UserCancelled,
		// Token: 0x0400007B RID: 123
		PaymentDeclined,
		// Token: 0x0400007C RID: 124
		DuplicateTransaction,
		// Token: 0x0400007D RID: 125
		Unknown
	}
}

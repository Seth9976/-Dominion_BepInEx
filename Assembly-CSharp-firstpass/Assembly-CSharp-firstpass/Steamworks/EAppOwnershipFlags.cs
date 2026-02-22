using System;

namespace Steamworks
{
	// Token: 0x02000288 RID: 648
	[Flags]
	public enum EAppOwnershipFlags
	{
		// Token: 0x04002497 RID: 9367
		k_EAppOwnershipFlags_None = 0,
		// Token: 0x04002498 RID: 9368
		k_EAppOwnershipFlags_OwnsLicense = 1,
		// Token: 0x04002499 RID: 9369
		k_EAppOwnershipFlags_FreeLicense = 2,
		// Token: 0x0400249A RID: 9370
		k_EAppOwnershipFlags_RegionRestricted = 4,
		// Token: 0x0400249B RID: 9371
		k_EAppOwnershipFlags_LowViolence = 8,
		// Token: 0x0400249C RID: 9372
		k_EAppOwnershipFlags_InvalidPlatform = 16,
		// Token: 0x0400249D RID: 9373
		k_EAppOwnershipFlags_SharedLicense = 32,
		// Token: 0x0400249E RID: 9374
		k_EAppOwnershipFlags_FreeWeekend = 64,
		// Token: 0x0400249F RID: 9375
		k_EAppOwnershipFlags_RetailLicense = 128,
		// Token: 0x040024A0 RID: 9376
		k_EAppOwnershipFlags_LicenseLocked = 256,
		// Token: 0x040024A1 RID: 9377
		k_EAppOwnershipFlags_LicensePending = 512,
		// Token: 0x040024A2 RID: 9378
		k_EAppOwnershipFlags_LicenseExpired = 1024,
		// Token: 0x040024A3 RID: 9379
		k_EAppOwnershipFlags_LicensePermanent = 2048,
		// Token: 0x040024A4 RID: 9380
		k_EAppOwnershipFlags_LicenseRecurring = 4096,
		// Token: 0x040024A5 RID: 9381
		k_EAppOwnershipFlags_LicenseCanceled = 8192,
		// Token: 0x040024A6 RID: 9382
		k_EAppOwnershipFlags_AutoGrant = 16384,
		// Token: 0x040024A7 RID: 9383
		k_EAppOwnershipFlags_PendingGift = 32768,
		// Token: 0x040024A8 RID: 9384
		k_EAppOwnershipFlags_RentalNotActivated = 65536,
		// Token: 0x040024A9 RID: 9385
		k_EAppOwnershipFlags_Rental = 131072,
		// Token: 0x040024AA RID: 9386
		k_EAppOwnershipFlags_SiteLicense = 262144,
		// Token: 0x040024AB RID: 9387
		k_EAppOwnershipFlags_LegacyFreeSub = 524288,
		// Token: 0x040024AC RID: 9388
		k_EAppOwnershipFlags_InvalidOSType = 1048576,
		// Token: 0x040024AD RID: 9389
		k_EAppOwnershipFlags_TimedTrial = 2097152
	}
}

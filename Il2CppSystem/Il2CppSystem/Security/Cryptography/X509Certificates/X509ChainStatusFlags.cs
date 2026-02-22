using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000081 RID: 129
	[OriginalName("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainStatusFlags")]
	[Flags]
	public enum X509ChainStatusFlags
	{
		// Token: 0x040005FF RID: 1535
		NoError = 0,
		// Token: 0x04000600 RID: 1536
		NotTimeValid = 1,
		// Token: 0x04000601 RID: 1537
		NotTimeNested = 2,
		// Token: 0x04000602 RID: 1538
		Revoked = 4,
		// Token: 0x04000603 RID: 1539
		NotSignatureValid = 8,
		// Token: 0x04000604 RID: 1540
		NotValidForUsage = 16,
		// Token: 0x04000605 RID: 1541
		UntrustedRoot = 32,
		// Token: 0x04000606 RID: 1542
		RevocationStatusUnknown = 64,
		// Token: 0x04000607 RID: 1543
		Cyclic = 128,
		// Token: 0x04000608 RID: 1544
		InvalidExtension = 256,
		// Token: 0x04000609 RID: 1545
		InvalidPolicyConstraints = 512,
		// Token: 0x0400060A RID: 1546
		InvalidBasicConstraints = 1024,
		// Token: 0x0400060B RID: 1547
		InvalidNameConstraints = 2048,
		// Token: 0x0400060C RID: 1548
		HasNotSupportedNameConstraint = 4096,
		// Token: 0x0400060D RID: 1549
		HasNotDefinedNameConstraint = 8192,
		// Token: 0x0400060E RID: 1550
		HasNotPermittedNameConstraint = 16384,
		// Token: 0x0400060F RID: 1551
		HasExcludedNameConstraint = 32768,
		// Token: 0x04000610 RID: 1552
		PartialChain = 65536,
		// Token: 0x04000611 RID: 1553
		CtlNotTimeValid = 131072,
		// Token: 0x04000612 RID: 1554
		CtlNotSignatureValid = 262144,
		// Token: 0x04000613 RID: 1555
		CtlNotValidForUsage = 524288,
		// Token: 0x04000614 RID: 1556
		OfflineRevocation = 16777216,
		// Token: 0x04000615 RID: 1557
		NoIssuanceChainPolicy = 33554432,
		// Token: 0x04000616 RID: 1558
		ExplicitDistrust = 67108864,
		// Token: 0x04000617 RID: 1559
		HasNotSupportedCriticalExtension = 134217728,
		// Token: 0x04000618 RID: 1560
		HasWeakSignature = 1048576
	}
}

using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000086 RID: 134
	[OriginalName("System.dll", "System.Security.Cryptography.X509Certificates", "X509VerificationFlags")]
	[Flags]
	public enum X509VerificationFlags
	{
		// Token: 0x04000631 RID: 1585
		NoFlag = 0,
		// Token: 0x04000632 RID: 1586
		IgnoreNotTimeValid = 1,
		// Token: 0x04000633 RID: 1587
		IgnoreCtlNotTimeValid = 2,
		// Token: 0x04000634 RID: 1588
		IgnoreNotTimeNested = 4,
		// Token: 0x04000635 RID: 1589
		IgnoreInvalidBasicConstraints = 8,
		// Token: 0x04000636 RID: 1590
		AllowUnknownCertificateAuthority = 16,
		// Token: 0x04000637 RID: 1591
		IgnoreWrongUsage = 32,
		// Token: 0x04000638 RID: 1592
		IgnoreInvalidName = 64,
		// Token: 0x04000639 RID: 1593
		IgnoreInvalidPolicy = 128,
		// Token: 0x0400063A RID: 1594
		IgnoreEndRevocationUnknown = 256,
		// Token: 0x0400063B RID: 1595
		IgnoreCtlSignerRevocationUnknown = 512,
		// Token: 0x0400063C RID: 1596
		IgnoreCertificateAuthorityRevocationUnknown = 1024,
		// Token: 0x0400063D RID: 1597
		IgnoreRootRevocationUnknown = 2048,
		// Token: 0x0400063E RID: 1598
		AllFlags = 4095
	}
}

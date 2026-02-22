using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000082 RID: 130
	[OriginalName("System.dll", "System.Security.Cryptography.X509Certificates", "X509KeyUsageFlags")]
	[Flags]
	public enum X509KeyUsageFlags
	{
		// Token: 0x0400061A RID: 1562
		None = 0,
		// Token: 0x0400061B RID: 1563
		EncipherOnly = 1,
		// Token: 0x0400061C RID: 1564
		CrlSign = 2,
		// Token: 0x0400061D RID: 1565
		KeyCertSign = 4,
		// Token: 0x0400061E RID: 1566
		KeyAgreement = 8,
		// Token: 0x0400061F RID: 1567
		DataEncipherment = 16,
		// Token: 0x04000620 RID: 1568
		KeyEncipherment = 32,
		// Token: 0x04000621 RID: 1569
		NonRepudiation = 64,
		// Token: 0x04000622 RID: 1570
		DigitalSignature = 128,
		// Token: 0x04000623 RID: 1571
		DecipherOnly = 32768
	}
}

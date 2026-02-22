using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200007E RID: 126
	[OriginalName("System.dll", "System.Security.Cryptography", "AsnDecodeStatus")]
	public enum AsnDecodeStatus
	{
		// Token: 0x040005E5 RID: 1509
		NotDecoded = -1,
		// Token: 0x040005E6 RID: 1510
		Ok,
		// Token: 0x040005E7 RID: 1511
		BadAsn,
		// Token: 0x040005E8 RID: 1512
		BadTag,
		// Token: 0x040005E9 RID: 1513
		BadLength,
		// Token: 0x040005EA RID: 1514
		InformationNotAvailable
	}
}

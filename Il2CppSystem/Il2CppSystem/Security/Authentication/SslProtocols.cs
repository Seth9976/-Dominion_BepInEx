using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Authentication
{
	// Token: 0x02000078 RID: 120
	[OriginalName("System.dll", "System.Security.Authentication", "SslProtocols")]
	[Flags]
	public enum SslProtocols
	{
		// Token: 0x040005B8 RID: 1464
		None = 0,
		// Token: 0x040005B9 RID: 1465
		Ssl2 = 12,
		// Token: 0x040005BA RID: 1466
		Ssl3 = 48,
		// Token: 0x040005BB RID: 1467
		Tls = 192,
		// Token: 0x040005BC RID: 1468
		Tls11 = 768,
		// Token: 0x040005BD RID: 1469
		Tls12 = 3072,
		// Token: 0x040005BE RID: 1470
		Default = 240
	}
}

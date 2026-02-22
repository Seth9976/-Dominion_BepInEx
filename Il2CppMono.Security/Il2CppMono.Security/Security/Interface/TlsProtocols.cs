using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x02000028 RID: 40
	[OriginalName("Mono.Security.dll", "Mono.Security.Interface", "TlsProtocols")]
	[Flags]
	public enum TlsProtocols
	{
		// Token: 0x0400029D RID: 669
		Zero = 0,
		// Token: 0x0400029E RID: 670
		Tls10Client = 128,
		// Token: 0x0400029F RID: 671
		Tls10Server = 64,
		// Token: 0x040002A0 RID: 672
		Tls10 = 192,
		// Token: 0x040002A1 RID: 673
		Tls11Client = 512,
		// Token: 0x040002A2 RID: 674
		Tls11Server = 256,
		// Token: 0x040002A3 RID: 675
		Tls11 = 768,
		// Token: 0x040002A4 RID: 676
		Tls12Client = 2048,
		// Token: 0x040002A5 RID: 677
		Tls12Server = 1024,
		// Token: 0x040002A6 RID: 678
		Tls12 = 3072,
		// Token: 0x040002A7 RID: 679
		ClientMask = 2688,
		// Token: 0x040002A8 RID: 680
		ServerMask = 1344
	}
}

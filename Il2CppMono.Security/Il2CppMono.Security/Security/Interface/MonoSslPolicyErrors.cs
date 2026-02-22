using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x02000022 RID: 34
	[OriginalName("Mono.Security.dll", "Mono.Security.Interface", "MonoSslPolicyErrors")]
	[Flags]
	public enum MonoSslPolicyErrors
	{
		// Token: 0x04000259 RID: 601
		None = 0,
		// Token: 0x0400025A RID: 602
		RemoteCertificateNotAvailable = 1,
		// Token: 0x0400025B RID: 603
		RemoteCertificateNameMismatch = 2,
		// Token: 0x0400025C RID: 604
		RemoteCertificateChainErrors = 4
	}
}

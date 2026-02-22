using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Security
{
	// Token: 0x02000136 RID: 310
	[OriginalName("System.dll", "System.Net.Security", "SslPolicyErrors")]
	[Flags]
	public enum SslPolicyErrors
	{
		// Token: 0x040010B5 RID: 4277
		None = 0,
		// Token: 0x040010B6 RID: 4278
		RemoteCertificateNotAvailable = 1,
		// Token: 0x040010B7 RID: 4279
		RemoteCertificateNameMismatch = 2,
		// Token: 0x040010B8 RID: 4280
		RemoteCertificateChainErrors = 4
	}
}

using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x0200031E RID: 798
	[OriginalName("mscorlib.dll", "System.Security.Cryptography.X509Certificates", "X509KeyStorageFlags")]
	[Flags]
	public enum X509KeyStorageFlags
	{
		// Token: 0x04002BFD RID: 11261
		DefaultKeySet = 0,
		// Token: 0x04002BFE RID: 11262
		UserKeySet = 1,
		// Token: 0x04002BFF RID: 11263
		MachineKeySet = 2,
		// Token: 0x04002C00 RID: 11264
		Exportable = 4,
		// Token: 0x04002C01 RID: 11265
		UserProtected = 8,
		// Token: 0x04002C02 RID: 11266
		PersistKeySet = 16,
		// Token: 0x04002C03 RID: 11267
		EphemeralKeySet = 32
	}
}

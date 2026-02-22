using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Configuration.Assemblies
{
	// Token: 0x02000153 RID: 339
	[OriginalName("mscorlib.dll", "System.Configuration.Assemblies", "AssemblyHashAlgorithm")]
	[Serializable]
	public enum AssemblyHashAlgorithm
	{
		// Token: 0x04001582 RID: 5506
		None,
		// Token: 0x04001583 RID: 5507
		MD5 = 32771,
		// Token: 0x04001584 RID: 5508
		SHA1,
		// Token: 0x04001585 RID: 5509
		SHA256 = 32780,
		// Token: 0x04001586 RID: 5510
		SHA384,
		// Token: 0x04001587 RID: 5511
		SHA512
	}
}

using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Principal
{
	// Token: 0x020002CE RID: 718
	[OriginalName("mscorlib.dll", "System.Security.Principal", "TokenImpersonationLevel")]
	[Serializable]
	public enum TokenImpersonationLevel
	{
		// Token: 0x04002924 RID: 10532
		Anonymous = 1,
		// Token: 0x04002925 RID: 10533
		Delegation = 4,
		// Token: 0x04002926 RID: 10534
		Identification = 2,
		// Token: 0x04002927 RID: 10535
		Impersonation,
		// Token: 0x04002928 RID: 10536
		None = 0
	}
}

using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002DD RID: 733
	[OriginalName("mscorlib.dll", "System.Security.Cryptography", "CspProviderFlags")]
	[Flags]
	[Serializable]
	public enum CspProviderFlags
	{
		// Token: 0x040029AD RID: 10669
		NoFlags = 0,
		// Token: 0x040029AE RID: 10670
		UseMachineKeyStore = 1,
		// Token: 0x040029AF RID: 10671
		UseDefaultKeyContainer = 2,
		// Token: 0x040029B0 RID: 10672
		UseNonExportableKey = 4,
		// Token: 0x040029B1 RID: 10673
		UseExistingKey = 8,
		// Token: 0x040029B2 RID: 10674
		UseArchivableKey = 16,
		// Token: 0x040029B3 RID: 10675
		UseUserProtectedKey = 32,
		// Token: 0x040029B4 RID: 10676
		NoPrompt = 64,
		// Token: 0x040029B5 RID: 10677
		CreateEphemeralKey = 128
	}
}

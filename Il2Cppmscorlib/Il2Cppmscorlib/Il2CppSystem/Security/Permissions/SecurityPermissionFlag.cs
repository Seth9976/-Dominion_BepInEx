using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Security.Permissions
{
	// Token: 0x020002C6 RID: 710
	[OriginalName("mscorlib.dll", "System.Security.Permissions", "SecurityPermissionFlag")]
	[Flags]
	[Serializable]
	public enum SecurityPermissionFlag
	{
		// Token: 0x040028DA RID: 10458
		NoFlags = 0,
		// Token: 0x040028DB RID: 10459
		Assertion = 1,
		// Token: 0x040028DC RID: 10460
		UnmanagedCode = 2,
		// Token: 0x040028DD RID: 10461
		SkipVerification = 4,
		// Token: 0x040028DE RID: 10462
		Execution = 8,
		// Token: 0x040028DF RID: 10463
		ControlThread = 16,
		// Token: 0x040028E0 RID: 10464
		ControlEvidence = 32,
		// Token: 0x040028E1 RID: 10465
		ControlPolicy = 64,
		// Token: 0x040028E2 RID: 10466
		SerializationFormatter = 128,
		// Token: 0x040028E3 RID: 10467
		ControlDomainPolicy = 256,
		// Token: 0x040028E4 RID: 10468
		ControlPrincipal = 512,
		// Token: 0x040028E5 RID: 10469
		ControlAppDomain = 1024,
		// Token: 0x040028E6 RID: 10470
		RemotingConfiguration = 2048,
		// Token: 0x040028E7 RID: 10471
		Infrastructure = 4096,
		// Token: 0x040028E8 RID: 10472
		BindingRedirects = 8192,
		// Token: 0x040028E9 RID: 10473
		AllFlags = 16383
	}
}

using System;

namespace UnityEngine.Networking
{
	// Token: 0x02000005 RID: 5
	public enum NetworkError
	{
		// Token: 0x04000059 RID: 89
		Ok,
		// Token: 0x0400005A RID: 90
		WrongHost,
		// Token: 0x0400005B RID: 91
		WrongConnection,
		// Token: 0x0400005C RID: 92
		WrongChannel,
		// Token: 0x0400005D RID: 93
		NoResources,
		// Token: 0x0400005E RID: 94
		BadMessage,
		// Token: 0x0400005F RID: 95
		Timeout,
		// Token: 0x04000060 RID: 96
		MessageToLong,
		// Token: 0x04000061 RID: 97
		WrongOperation,
		// Token: 0x04000062 RID: 98
		VersionMismatch,
		// Token: 0x04000063 RID: 99
		CRCMismatch,
		// Token: 0x04000064 RID: 100
		DNSFailure,
		// Token: 0x04000065 RID: 101
		UsageError
	}
}

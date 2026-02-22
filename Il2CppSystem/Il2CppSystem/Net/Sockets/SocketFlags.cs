using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000129 RID: 297
	[OriginalName("System.dll", "System.Net.Sockets", "SocketFlags")]
	[Flags]
	public enum SocketFlags
	{
		// Token: 0x0400101A RID: 4122
		None = 0,
		// Token: 0x0400101B RID: 4123
		OutOfBand = 1,
		// Token: 0x0400101C RID: 4124
		Peek = 2,
		// Token: 0x0400101D RID: 4125
		DontRoute = 4,
		// Token: 0x0400101E RID: 4126
		MaxIOVectorLength = 16,
		// Token: 0x0400101F RID: 4127
		Truncated = 256,
		// Token: 0x04001020 RID: 4128
		ControlDataTruncated = 512,
		// Token: 0x04001021 RID: 4129
		Broadcast = 1024,
		// Token: 0x04001022 RID: 4130
		Multicast = 2048,
		// Token: 0x04001023 RID: 4131
		Partial = 32768
	}
}

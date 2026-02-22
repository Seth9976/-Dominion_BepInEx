using System;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x02000011 RID: 17
	public enum ProcessingState
	{
		// Token: 0x04000065 RID: 101
		Unknown,
		// Token: 0x04000066 RID: 102
		InQueue,
		// Token: 0x04000067 RID: 103
		Reading,
		// Token: 0x04000068 RID: 104
		Completed,
		// Token: 0x04000069 RID: 105
		Failed,
		// Token: 0x0400006A RID: 106
		Canceled
	}
}

using System;

namespace UnityEngine.Experimental.AI
{
	// Token: 0x02000013 RID: 19
	public enum PathQueryStatus
	{
		// Token: 0x040000BB RID: 187
		Failure = -2147483648,
		// Token: 0x040000BC RID: 188
		Success = 1073741824,
		// Token: 0x040000BD RID: 189
		InProgress = 536870912,
		// Token: 0x040000BE RID: 190
		StatusDetailMask = 16777215,
		// Token: 0x040000BF RID: 191
		WrongMagic = 1,
		// Token: 0x040000C0 RID: 192
		WrongVersion,
		// Token: 0x040000C1 RID: 193
		OutOfMemory = 4,
		// Token: 0x040000C2 RID: 194
		InvalidParam = 8,
		// Token: 0x040000C3 RID: 195
		BufferTooSmall = 16,
		// Token: 0x040000C4 RID: 196
		OutOfNodes = 32,
		// Token: 0x040000C5 RID: 197
		PartialResult = 64
	}
}

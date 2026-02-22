using System;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	[Flags]
	public enum EventModifiers
	{
		// Token: 0x04000066 RID: 102
		None = 0,
		// Token: 0x04000067 RID: 103
		Shift = 1,
		// Token: 0x04000068 RID: 104
		Control = 2,
		// Token: 0x04000069 RID: 105
		Alt = 4,
		// Token: 0x0400006A RID: 106
		Command = 8,
		// Token: 0x0400006B RID: 107
		Numeric = 16,
		// Token: 0x0400006C RID: 108
		CapsLock = 32,
		// Token: 0x0400006D RID: 109
		FunctionKey = 64
	}
}

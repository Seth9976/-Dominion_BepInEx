using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x02000036 RID: 54
	[OriginalName("System.dll", "System", "UnescapeMode")]
	[Flags]
	public enum UnescapeMode
	{
		// Token: 0x0400027F RID: 639
		CopyOnly = 0,
		// Token: 0x04000280 RID: 640
		Escape = 1,
		// Token: 0x04000281 RID: 641
		Unescape = 2,
		// Token: 0x04000282 RID: 642
		EscapeUnescape = 3,
		// Token: 0x04000283 RID: 643
		V1ToStringFlag = 4,
		// Token: 0x04000284 RID: 644
		UnescapeAll = 8,
		// Token: 0x04000285 RID: 645
		UnescapeAllOrThrow = 24
	}
}

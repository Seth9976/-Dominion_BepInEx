using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200005C RID: 92
	[OriginalName("System.dll", "System.Text.RegularExpressions", "RegexOptions")]
	[Flags]
	public enum RegexOptions
	{
		// Token: 0x040004C0 RID: 1216
		None = 0,
		// Token: 0x040004C1 RID: 1217
		IgnoreCase = 1,
		// Token: 0x040004C2 RID: 1218
		Multiline = 2,
		// Token: 0x040004C3 RID: 1219
		ExplicitCapture = 4,
		// Token: 0x040004C4 RID: 1220
		Compiled = 8,
		// Token: 0x040004C5 RID: 1221
		Singleline = 16,
		// Token: 0x040004C6 RID: 1222
		IgnorePatternWhitespace = 32,
		// Token: 0x040004C7 RID: 1223
		RightToLeft = 64,
		// Token: 0x040004C8 RID: 1224
		ECMAScript = 256,
		// Token: 0x040004C9 RID: 1225
		CultureInvariant = 512
	}
}

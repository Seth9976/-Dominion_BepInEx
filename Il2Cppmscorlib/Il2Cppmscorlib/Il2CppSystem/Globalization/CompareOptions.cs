using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000229 RID: 553
	[OriginalName("mscorlib.dll", "System.Globalization", "CompareOptions")]
	[Flags]
	[Serializable]
	public enum CompareOptions
	{
		// Token: 0x04002077 RID: 8311
		None = 0,
		// Token: 0x04002078 RID: 8312
		IgnoreCase = 1,
		// Token: 0x04002079 RID: 8313
		IgnoreNonSpace = 2,
		// Token: 0x0400207A RID: 8314
		IgnoreSymbols = 4,
		// Token: 0x0400207B RID: 8315
		IgnoreKanaType = 8,
		// Token: 0x0400207C RID: 8316
		IgnoreWidth = 16,
		// Token: 0x0400207D RID: 8317
		OrdinalIgnoreCase = 268435456,
		// Token: 0x0400207E RID: 8318
		StringSort = 536870912,
		// Token: 0x0400207F RID: 8319
		Ordinal = 1073741824
	}
}

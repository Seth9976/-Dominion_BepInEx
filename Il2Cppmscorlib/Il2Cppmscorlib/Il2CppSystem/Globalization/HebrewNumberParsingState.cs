using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200023A RID: 570
	[OriginalName("mscorlib.dll", "System.Globalization", "HebrewNumberParsingState")]
	public enum HebrewNumberParsingState
	{
		// Token: 0x04002221 RID: 8737
		InvalidHebrewNumber,
		// Token: 0x04002222 RID: 8738
		NotHebrewDigit,
		// Token: 0x04002223 RID: 8739
		FoundEndOfHebrewNumber,
		// Token: 0x04002224 RID: 8740
		ContinueParsing
	}
}

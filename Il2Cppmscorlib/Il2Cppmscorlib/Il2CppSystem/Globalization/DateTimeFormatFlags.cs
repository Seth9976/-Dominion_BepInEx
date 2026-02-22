using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200022E RID: 558
	[OriginalName("mscorlib.dll", "System.Globalization", "DateTimeFormatFlags")]
	[Flags]
	public enum DateTimeFormatFlags
	{
		// Token: 0x040020D5 RID: 8405
		None = 0,
		// Token: 0x040020D6 RID: 8406
		UseGenitiveMonth = 1,
		// Token: 0x040020D7 RID: 8407
		UseLeapYearMonth = 2,
		// Token: 0x040020D8 RID: 8408
		UseSpacesInMonthNames = 4,
		// Token: 0x040020D9 RID: 8409
		UseHebrewRule = 8,
		// Token: 0x040020DA RID: 8410
		UseSpacesInDayNames = 16,
		// Token: 0x040020DB RID: 8411
		UseDigitPrefixInTokens = 32,
		// Token: 0x040020DC RID: 8412
		NotInitialized = -1
	}
}

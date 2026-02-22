using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000234 RID: 564
	[OriginalName("mscorlib.dll", "System.Globalization", "DateTimeStyles")]
	[Flags]
	[Serializable]
	public enum DateTimeStyles
	{
		// Token: 0x040021C8 RID: 8648
		None = 0,
		// Token: 0x040021C9 RID: 8649
		AllowLeadingWhite = 1,
		// Token: 0x040021CA RID: 8650
		AllowTrailingWhite = 2,
		// Token: 0x040021CB RID: 8651
		AllowInnerWhite = 4,
		// Token: 0x040021CC RID: 8652
		AllowWhiteSpaces = 7,
		// Token: 0x040021CD RID: 8653
		NoCurrentDateDefault = 8,
		// Token: 0x040021CE RID: 8654
		AdjustToUniversal = 16,
		// Token: 0x040021CF RID: 8655
		AssumeLocal = 32,
		// Token: 0x040021D0 RID: 8656
		AssumeUniversal = 64,
		// Token: 0x040021D1 RID: 8657
		RoundtripKind = 128
	}
}

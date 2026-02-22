using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x020000B1 RID: 177
	[OriginalName("mscorlib.dll", "System", "ParseFlags")]
	[Flags]
	public enum ParseFlags
	{
		// Token: 0x04000A7D RID: 2685
		HaveYear = 1,
		// Token: 0x04000A7E RID: 2686
		HaveMonth = 2,
		// Token: 0x04000A7F RID: 2687
		HaveDay = 4,
		// Token: 0x04000A80 RID: 2688
		HaveHour = 8,
		// Token: 0x04000A81 RID: 2689
		HaveMinute = 16,
		// Token: 0x04000A82 RID: 2690
		HaveSecond = 32,
		// Token: 0x04000A83 RID: 2691
		HaveTime = 64,
		// Token: 0x04000A84 RID: 2692
		HaveDate = 128,
		// Token: 0x04000A85 RID: 2693
		TimeZoneUsed = 256,
		// Token: 0x04000A86 RID: 2694
		TimeZoneUtc = 512,
		// Token: 0x04000A87 RID: 2695
		ParsedMonthName = 1024,
		// Token: 0x04000A88 RID: 2696
		CaptureOffset = 2048,
		// Token: 0x04000A89 RID: 2697
		YearDefault = 4096,
		// Token: 0x04000A8A RID: 2698
		Rfc1123Pattern = 8192,
		// Token: 0x04000A8B RID: 2699
		UtcSortPattern = 16384
	}
}

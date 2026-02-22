using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x020000B4 RID: 180
	[OriginalName("mscorlib.dll", "System", "TokenType")]
	public enum TokenType
	{
		// Token: 0x04000AAB RID: 2731
		NumberToken = 1,
		// Token: 0x04000AAC RID: 2732
		YearNumberToken,
		// Token: 0x04000AAD RID: 2733
		Am,
		// Token: 0x04000AAE RID: 2734
		Pm,
		// Token: 0x04000AAF RID: 2735
		MonthToken,
		// Token: 0x04000AB0 RID: 2736
		EndOfString,
		// Token: 0x04000AB1 RID: 2737
		DayOfWeekToken,
		// Token: 0x04000AB2 RID: 2738
		TimeZoneToken,
		// Token: 0x04000AB3 RID: 2739
		EraToken,
		// Token: 0x04000AB4 RID: 2740
		DateWordToken,
		// Token: 0x04000AB5 RID: 2741
		UnknownToken,
		// Token: 0x04000AB6 RID: 2742
		HebrewNumber,
		// Token: 0x04000AB7 RID: 2743
		JapaneseEraToken,
		// Token: 0x04000AB8 RID: 2744
		TEraToken,
		// Token: 0x04000AB9 RID: 2745
		IgnorableSymbol,
		// Token: 0x04000ABA RID: 2746
		SEP_Unk = 256,
		// Token: 0x04000ABB RID: 2747
		SEP_End = 512,
		// Token: 0x04000ABC RID: 2748
		SEP_Space = 768,
		// Token: 0x04000ABD RID: 2749
		SEP_Am = 1024,
		// Token: 0x04000ABE RID: 2750
		SEP_Pm = 1280,
		// Token: 0x04000ABF RID: 2751
		SEP_Date = 1536,
		// Token: 0x04000AC0 RID: 2752
		SEP_Time = 1792,
		// Token: 0x04000AC1 RID: 2753
		SEP_YearSuff = 2048,
		// Token: 0x04000AC2 RID: 2754
		SEP_MonthSuff = 2304,
		// Token: 0x04000AC3 RID: 2755
		SEP_DaySuff = 2560,
		// Token: 0x04000AC4 RID: 2756
		SEP_HourSuff = 2816,
		// Token: 0x04000AC5 RID: 2757
		SEP_MinuteSuff = 3072,
		// Token: 0x04000AC6 RID: 2758
		SEP_SecondSuff = 3328,
		// Token: 0x04000AC7 RID: 2759
		SEP_LocalTimeMark = 3584,
		// Token: 0x04000AC8 RID: 2760
		SEP_DateOrOffset = 3840,
		// Token: 0x04000AC9 RID: 2761
		RegularTokenMask = 255,
		// Token: 0x04000ACA RID: 2762
		SeparatorTokenMask = 65280
	}
}

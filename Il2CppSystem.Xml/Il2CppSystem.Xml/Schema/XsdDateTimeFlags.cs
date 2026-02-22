using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200010F RID: 271
	[OriginalName("System.Xml.dll", "System.Xml.Schema", "XsdDateTimeFlags")]
	[Flags]
	public enum XsdDateTimeFlags
	{
		// Token: 0x04000CF3 RID: 3315
		DateTime = 1,
		// Token: 0x04000CF4 RID: 3316
		Time = 2,
		// Token: 0x04000CF5 RID: 3317
		Date = 4,
		// Token: 0x04000CF6 RID: 3318
		GYearMonth = 8,
		// Token: 0x04000CF7 RID: 3319
		GYear = 16,
		// Token: 0x04000CF8 RID: 3320
		GMonthDay = 32,
		// Token: 0x04000CF9 RID: 3321
		GDay = 64,
		// Token: 0x04000CFA RID: 3322
		GMonth = 128,
		// Token: 0x04000CFB RID: 3323
		XdrDateTimeNoTz = 256,
		// Token: 0x04000CFC RID: 3324
		XdrDateTime = 512,
		// Token: 0x04000CFD RID: 3325
		XdrTimeNoTz = 1024,
		// Token: 0x04000CFE RID: 3326
		AllXsd = 255
	}
}

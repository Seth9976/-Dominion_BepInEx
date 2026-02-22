using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200008A RID: 138
	[OriginalName("System.Xml.dll", "System.Xml.Schema", "RestrictionFlags")]
	[Flags]
	public enum RestrictionFlags
	{
		// Token: 0x04000769 RID: 1897
		Length = 1,
		// Token: 0x0400076A RID: 1898
		MinLength = 2,
		// Token: 0x0400076B RID: 1899
		MaxLength = 4,
		// Token: 0x0400076C RID: 1900
		Pattern = 8,
		// Token: 0x0400076D RID: 1901
		Enumeration = 16,
		// Token: 0x0400076E RID: 1902
		WhiteSpace = 32,
		// Token: 0x0400076F RID: 1903
		MaxInclusive = 64,
		// Token: 0x04000770 RID: 1904
		MaxExclusive = 128,
		// Token: 0x04000771 RID: 1905
		MinInclusive = 256,
		// Token: 0x04000772 RID: 1906
		MinExclusive = 512,
		// Token: 0x04000773 RID: 1907
		TotalDigits = 1024,
		// Token: 0x04000774 RID: 1908
		FractionDigits = 2048
	}
}

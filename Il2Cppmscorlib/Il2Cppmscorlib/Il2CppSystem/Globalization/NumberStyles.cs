using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200023F RID: 575
	[OriginalName("mscorlib.dll", "System.Globalization", "NumberStyles")]
	[Flags]
	[Serializable]
	public enum NumberStyles
	{
		// Token: 0x040022B2 RID: 8882
		None = 0,
		// Token: 0x040022B3 RID: 8883
		AllowLeadingWhite = 1,
		// Token: 0x040022B4 RID: 8884
		AllowTrailingWhite = 2,
		// Token: 0x040022B5 RID: 8885
		AllowLeadingSign = 4,
		// Token: 0x040022B6 RID: 8886
		AllowTrailingSign = 8,
		// Token: 0x040022B7 RID: 8887
		AllowParentheses = 16,
		// Token: 0x040022B8 RID: 8888
		AllowDecimalPoint = 32,
		// Token: 0x040022B9 RID: 8889
		AllowThousands = 64,
		// Token: 0x040022BA RID: 8890
		AllowExponent = 128,
		// Token: 0x040022BB RID: 8891
		AllowCurrencySymbol = 256,
		// Token: 0x040022BC RID: 8892
		AllowHexSpecifier = 512,
		// Token: 0x040022BD RID: 8893
		Integer = 7,
		// Token: 0x040022BE RID: 8894
		HexNumber = 515,
		// Token: 0x040022BF RID: 8895
		Number = 111,
		// Token: 0x040022C0 RID: 8896
		Float = 167,
		// Token: 0x040022C1 RID: 8897
		Currency = 383,
		// Token: 0x040022C2 RID: 8898
		Any = 511
	}
}

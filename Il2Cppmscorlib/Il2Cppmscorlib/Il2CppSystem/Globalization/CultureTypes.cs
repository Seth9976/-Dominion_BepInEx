using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization
{
	// Token: 0x0200022C RID: 556
	[OriginalName("mscorlib.dll", "System.Globalization", "CultureTypes")]
	[Flags]
	[Serializable]
	public enum CultureTypes
	{
		// Token: 0x040020C8 RID: 8392
		NeutralCultures = 1,
		// Token: 0x040020C9 RID: 8393
		SpecificCultures = 2,
		// Token: 0x040020CA RID: 8394
		InstalledWin32Cultures = 4,
		// Token: 0x040020CB RID: 8395
		AllCultures = 7,
		// Token: 0x040020CC RID: 8396
		UserCustomCulture = 8,
		// Token: 0x040020CD RID: 8397
		ReplacementCultures = 16,
		// Token: 0x040020CE RID: 8398
		WindowsOnlyCultures = 32,
		// Token: 0x040020CF RID: 8399
		FrameworkCultures = 64
	}
}

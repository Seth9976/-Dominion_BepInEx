using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000520 RID: 1312
	[OriginalName("mscorlib.dll", "System.Diagnostics.Tracing", "EventManifestOptions")]
	[Flags]
	public enum EventManifestOptions
	{
		// Token: 0x04003D34 RID: 15668
		None = 0,
		// Token: 0x04003D35 RID: 15669
		Strict = 1,
		// Token: 0x04003D36 RID: 15670
		AllCultures = 2,
		// Token: 0x04003D37 RID: 15671
		OnlyIfNeededForRegistration = 4,
		// Token: 0x04003D38 RID: 15672
		AllowEventSourceOverride = 8
	}
}

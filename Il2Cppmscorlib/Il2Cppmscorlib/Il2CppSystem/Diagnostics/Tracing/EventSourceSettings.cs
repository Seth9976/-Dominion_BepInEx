using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000513 RID: 1299
	[OriginalName("mscorlib.dll", "System.Diagnostics.Tracing", "EventSourceSettings")]
	[Flags]
	public enum EventSourceSettings
	{
		// Token: 0x04003CA8 RID: 15528
		Default = 0,
		// Token: 0x04003CA9 RID: 15529
		ThrowOnEventWriteErrors = 1,
		// Token: 0x04003CAA RID: 15530
		EtwManifestEventFormat = 4,
		// Token: 0x04003CAB RID: 15531
		EtwSelfDescribingEventFormat = 8
	}
}

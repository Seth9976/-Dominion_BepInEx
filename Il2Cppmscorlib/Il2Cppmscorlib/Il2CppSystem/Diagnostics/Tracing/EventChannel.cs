using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000527 RID: 1319
	[OriginalName("mscorlib.dll", "System.Diagnostics.Tracing", "EventChannel")]
	public enum EventChannel : byte
	{
		// Token: 0x04003D85 RID: 15749
		None,
		// Token: 0x04003D86 RID: 15750
		Admin = 16,
		// Token: 0x04003D87 RID: 15751
		Operational,
		// Token: 0x04003D88 RID: 15752
		Analytic,
		// Token: 0x04003D89 RID: 15753
		Debug
	}
}

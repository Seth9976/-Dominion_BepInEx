using System;

namespace Unity.Profiling.LowLevel
{
	// Token: 0x0200000A RID: 10
	[Flags]
	public enum MarkerFlags : ushort
	{
		// Token: 0x04000016 RID: 22
		Default = 0,
		// Token: 0x04000017 RID: 23
		Script = 2,
		// Token: 0x04000018 RID: 24
		ScriptInvoke = 32,
		// Token: 0x04000019 RID: 25
		ScriptDeepProfiler = 64,
		// Token: 0x0400001A RID: 26
		AvailabilityEditor = 4,
		// Token: 0x0400001B RID: 27
		Warning = 16,
		// Token: 0x0400001C RID: 28
		Counter = 128
	}
}

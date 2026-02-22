using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000287 RID: 647
	[OriginalName("mscorlib.dll", "System.Threading", "ThreadState")]
	[Flags]
	[Serializable]
	public enum ThreadState
	{
		// Token: 0x0400264E RID: 9806
		Running = 0,
		// Token: 0x0400264F RID: 9807
		StopRequested = 1,
		// Token: 0x04002650 RID: 9808
		SuspendRequested = 2,
		// Token: 0x04002651 RID: 9809
		Background = 4,
		// Token: 0x04002652 RID: 9810
		Unstarted = 8,
		// Token: 0x04002653 RID: 9811
		Stopped = 16,
		// Token: 0x04002654 RID: 9812
		WaitSleepJoin = 32,
		// Token: 0x04002655 RID: 9813
		Suspended = 64,
		// Token: 0x04002656 RID: 9814
		AbortRequested = 128,
		// Token: 0x04002657 RID: 9815
		Aborted = 256
	}
}

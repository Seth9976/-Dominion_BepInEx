using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x0200029E RID: 670
	[OriginalName("mscorlib.dll", "System.Threading.Tasks", "TaskStatus")]
	public enum TaskStatus
	{
		// Token: 0x04002731 RID: 10033
		Created,
		// Token: 0x04002732 RID: 10034
		WaitingForActivation,
		// Token: 0x04002733 RID: 10035
		WaitingToRun,
		// Token: 0x04002734 RID: 10036
		Running,
		// Token: 0x04002735 RID: 10037
		WaitingForChildrenToComplete,
		// Token: 0x04002736 RID: 10038
		RanToCompletion,
		// Token: 0x04002737 RID: 10039
		Canceled,
		// Token: 0x04002738 RID: 10040
		Faulted
	}
}

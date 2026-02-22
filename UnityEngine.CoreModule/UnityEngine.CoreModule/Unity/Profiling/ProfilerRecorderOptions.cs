using System;

namespace Unity.Profiling
{
	// Token: 0x02000186 RID: 390
	public enum ProfilerRecorderOptions
	{
		// Token: 0x04001588 RID: 5512
		None,
		// Token: 0x04001589 RID: 5513
		StartImmediately,
		// Token: 0x0400158A RID: 5514
		KeepAliveDuringDomainReload,
		// Token: 0x0400158B RID: 5515
		CollectOnlyOnCurrentThread = 4,
		// Token: 0x0400158C RID: 5516
		WrapAroundWhenCapacityReached = 8,
		// Token: 0x0400158D RID: 5517
		SumAllSamplesInFrame = 16,
		// Token: 0x0400158E RID: 5518
		Default = 24
	}
}

using System;

namespace UnityEngine.Profiling.Memory.Experimental
{
	// Token: 0x02000256 RID: 598
	public enum CaptureFlags : uint
	{
		// Token: 0x0400193E RID: 6462
		ManagedObjects = 1U,
		// Token: 0x0400193F RID: 6463
		NativeObjects,
		// Token: 0x04001940 RID: 6464
		NativeAllocations = 4U,
		// Token: 0x04001941 RID: 6465
		NativeAllocationSites = 8U,
		// Token: 0x04001942 RID: 6466
		NativeStackTraces = 16U
	}
}

using System;

namespace Unity.Profiling.LowLevel
{
	// Token: 0x0200018A RID: 394
	public enum ProfilerMarkerDataType : byte
	{
		// Token: 0x04001598 RID: 5528
		Int32 = 2,
		// Token: 0x04001599 RID: 5529
		UInt32,
		// Token: 0x0400159A RID: 5530
		Int64,
		// Token: 0x0400159B RID: 5531
		UInt64,
		// Token: 0x0400159C RID: 5532
		Float,
		// Token: 0x0400159D RID: 5533
		Double,
		// Token: 0x0400159E RID: 5534
		String16 = 9,
		// Token: 0x0400159F RID: 5535
		Blob8 = 11
	}
}

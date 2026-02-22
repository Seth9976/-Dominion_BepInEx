using System;

namespace Unity.Jobs
{
	// Token: 0x0200018E RID: 398
	public static class IJobForExtensions
	{
		// Token: 0x06001BC3 RID: 7107 RVA: 0x0000F377 File Offset: 0x0000D577
		public static JobHandle Schedule<T>(T jobData, int arrayLength, JobHandle dependency) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x0000F384 File Offset: 0x0000D584
		public static JobHandle ScheduleParallel<T>(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependency) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x0000F391 File Offset: 0x0000D591
		public static void Run<T>(T jobData, int arrayLength) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}

using System;
using System.Runtime.InteropServices;

namespace Unity.Jobs
{
	// Token: 0x02000190 RID: 400
	public static class IJobParallelForExtensions
	{
		// Token: 0x06001BC6 RID: 7110 RVA: 0x0000F39E File Offset: 0x0000D59E
		public static JobHandle Schedule<T>(T jobData, int arrayLength, int innerloopBatchCount, [Optional] JobHandle dependsOn) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x0000F3AB File Offset: 0x0000D5AB
		public static void Run<T>(T jobData, int arrayLength) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}

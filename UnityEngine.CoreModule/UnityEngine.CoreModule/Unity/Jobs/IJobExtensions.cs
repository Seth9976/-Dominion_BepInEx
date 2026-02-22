using System;
using System.Runtime.InteropServices;

namespace Unity.Jobs
{
	// Token: 0x0200018C RID: 396
	public static class IJobExtensions
	{
		// Token: 0x06001BC1 RID: 7105 RVA: 0x0000F35D File Offset: 0x0000D55D
		public static JobHandle Schedule<T>(T jobData, [Optional] JobHandle dependsOn) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x0000F36A File Offset: 0x0000D56A
		public static void Run<T>(T jobData) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}

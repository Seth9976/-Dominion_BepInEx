using System;

namespace Unity.Jobs.LowLevel.Unsafe
{
	// Token: 0x02000191 RID: 401
	public static class JobHandleUnsafeUtility
	{
		// Token: 0x06001BC8 RID: 7112 RVA: 0x0006177C File Offset: 0x0005F97C
		public unsafe static JobHandle CombineDependencies(JobHandle* jobs, int count)
		{
			return JobHandle.CombineDependenciesInternalPtr((void*)jobs, count);
		}
	}
}

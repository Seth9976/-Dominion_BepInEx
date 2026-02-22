using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020002A2 RID: 674
	public enum RenderingThreadingMode
	{
		// Token: 0x04001AAD RID: 6829
		Direct,
		// Token: 0x04001AAE RID: 6830
		SingleThreaded,
		// Token: 0x04001AAF RID: 6831
		MultiThreaded,
		// Token: 0x04001AB0 RID: 6832
		LegacyJobified,
		// Token: 0x04001AB1 RID: 6833
		NativeGraphicsJobs,
		// Token: 0x04001AB2 RID: 6834
		NativeGraphicsJobsWithoutRenderThread
	}
}

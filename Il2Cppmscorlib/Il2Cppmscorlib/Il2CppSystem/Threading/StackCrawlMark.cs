using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200027A RID: 634
	[OriginalName("mscorlib.dll", "System.Threading", "StackCrawlMark")]
	[Serializable]
	public enum StackCrawlMark
	{
		// Token: 0x0400260B RID: 9739
		LookForMe,
		// Token: 0x0400260C RID: 9740
		LookForMyCaller,
		// Token: 0x0400260D RID: 9741
		LookForMyCallersCaller,
		// Token: 0x0400260E RID: 9742
		LookForThread
	}
}

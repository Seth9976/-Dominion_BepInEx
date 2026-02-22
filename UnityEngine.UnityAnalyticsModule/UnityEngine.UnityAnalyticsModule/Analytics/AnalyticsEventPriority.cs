using System;

namespace UnityEngine.Analytics
{
	// Token: 0x0200000C RID: 12
	public enum AnalyticsEventPriority
	{
		// Token: 0x0400008F RID: 143
		FlushQueueFlag = 1,
		// Token: 0x04000090 RID: 144
		CacheImmediatelyFlag,
		// Token: 0x04000091 RID: 145
		AllowInStopModeFlag = 4,
		// Token: 0x04000092 RID: 146
		SendImmediateFlag = 8,
		// Token: 0x04000093 RID: 147
		NoCachingFlag = 16,
		// Token: 0x04000094 RID: 148
		NoRetryFlag = 32,
		// Token: 0x04000095 RID: 149
		NormalPriorityEvent = 0,
		// Token: 0x04000096 RID: 150
		NormalPriorityEvent_WithCaching = 2,
		// Token: 0x04000097 RID: 151
		NormalPriorityEvent_NoRetryNoCaching = 48,
		// Token: 0x04000098 RID: 152
		HighPriorityEvent = 1,
		// Token: 0x04000099 RID: 153
		HighPriorityEvent_InStopMode = 5,
		// Token: 0x0400009A RID: 154
		HighestPriorityEvent = 9,
		// Token: 0x0400009B RID: 155
		HighestPriorityEvent_NoRetryNoCaching = 49
	}
}

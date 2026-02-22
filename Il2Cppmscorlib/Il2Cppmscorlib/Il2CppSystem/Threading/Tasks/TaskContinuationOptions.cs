using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002A4 RID: 676
	[OriginalName("mscorlib.dll", "System.Threading.Tasks", "TaskContinuationOptions")]
	[Flags]
	[Serializable]
	public enum TaskContinuationOptions
	{
		// Token: 0x040027EB RID: 10219
		None = 0,
		// Token: 0x040027EC RID: 10220
		PreferFairness = 1,
		// Token: 0x040027ED RID: 10221
		LongRunning = 2,
		// Token: 0x040027EE RID: 10222
		AttachedToParent = 4,
		// Token: 0x040027EF RID: 10223
		DenyChildAttach = 8,
		// Token: 0x040027F0 RID: 10224
		HideScheduler = 16,
		// Token: 0x040027F1 RID: 10225
		LazyCancellation = 32,
		// Token: 0x040027F2 RID: 10226
		RunContinuationsAsynchronously = 64,
		// Token: 0x040027F3 RID: 10227
		NotOnRanToCompletion = 65536,
		// Token: 0x040027F4 RID: 10228
		NotOnFaulted = 131072,
		// Token: 0x040027F5 RID: 10229
		NotOnCanceled = 262144,
		// Token: 0x040027F6 RID: 10230
		OnlyOnRanToCompletion = 393216,
		// Token: 0x040027F7 RID: 10231
		OnlyOnFaulted = 327680,
		// Token: 0x040027F8 RID: 10232
		OnlyOnCanceled = 196608,
		// Token: 0x040027F9 RID: 10233
		ExecuteSynchronously = 524288
	}
}

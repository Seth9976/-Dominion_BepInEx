using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002A3 RID: 675
	[OriginalName("mscorlib.dll", "System.Threading.Tasks", "InternalTaskOptions")]
	[Flags]
	[Serializable]
	public enum InternalTaskOptions
	{
		// Token: 0x040027E1 RID: 10209
		None = 0,
		// Token: 0x040027E2 RID: 10210
		InternalOptionsMask = 65280,
		// Token: 0x040027E3 RID: 10211
		ChildReplica = 256,
		// Token: 0x040027E4 RID: 10212
		ContinuationTask = 512,
		// Token: 0x040027E5 RID: 10213
		PromiseTask = 1024,
		// Token: 0x040027E6 RID: 10214
		SelfReplicating = 2048,
		// Token: 0x040027E7 RID: 10215
		LazyCancellation = 4096,
		// Token: 0x040027E8 RID: 10216
		QueuedByRuntime = 8192,
		// Token: 0x040027E9 RID: 10217
		DoNotDispose = 16384
	}
}

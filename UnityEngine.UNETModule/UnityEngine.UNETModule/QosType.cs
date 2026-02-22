using System;

namespace UnityEngine.Networking
{
	// Token: 0x02000004 RID: 4
	public enum QosType
	{
		// Token: 0x0400004D RID: 77
		Unreliable,
		// Token: 0x0400004E RID: 78
		UnreliableFragmented,
		// Token: 0x0400004F RID: 79
		UnreliableSequenced,
		// Token: 0x04000050 RID: 80
		Reliable,
		// Token: 0x04000051 RID: 81
		ReliableFragmented,
		// Token: 0x04000052 RID: 82
		ReliableSequenced,
		// Token: 0x04000053 RID: 83
		StateUpdate,
		// Token: 0x04000054 RID: 84
		ReliableStateUpdate,
		// Token: 0x04000055 RID: 85
		AllCostDelivery,
		// Token: 0x04000056 RID: 86
		UnreliableFragmentedSequenced,
		// Token: 0x04000057 RID: 87
		ReliableFragmentedSequenced
	}
}

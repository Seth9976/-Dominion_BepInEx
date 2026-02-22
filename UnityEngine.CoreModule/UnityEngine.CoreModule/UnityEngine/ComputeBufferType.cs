using System;

namespace UnityEngine
{
	// Token: 0x020001FA RID: 506
	public enum ComputeBufferType
	{
		// Token: 0x040017B9 RID: 6073
		Default,
		// Token: 0x040017BA RID: 6074
		Raw,
		// Token: 0x040017BB RID: 6075
		Append,
		// Token: 0x040017BC RID: 6076
		Counter = 4,
		// Token: 0x040017BD RID: 6077
		Constant = 8,
		// Token: 0x040017BE RID: 6078
		Structured = 16,
		// Token: 0x040017BF RID: 6079
		DrawIndirect = 256,
		// Token: 0x040017C0 RID: 6080
		IndirectArguments = 256,
		// Token: 0x040017C1 RID: 6081
		GPUMemory = 512
	}
}

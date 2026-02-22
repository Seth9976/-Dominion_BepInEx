using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.ConstrainedExecution
{
	// Token: 0x02000410 RID: 1040
	[OriginalName("mscorlib.dll", "System.Runtime.ConstrainedExecution", "Consistency")]
	[Serializable]
	public enum Consistency
	{
		// Token: 0x0400356B RID: 13675
		MayCorruptProcess,
		// Token: 0x0400356C RID: 13676
		MayCorruptAppDomain,
		// Token: 0x0400356D RID: 13677
		MayCorruptInstance,
		// Token: 0x0400356E RID: 13678
		WillNotCorruptState
	}
}

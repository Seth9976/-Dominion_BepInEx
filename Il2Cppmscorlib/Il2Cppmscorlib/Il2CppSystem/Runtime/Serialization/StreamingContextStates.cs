using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200034D RID: 845
	[OriginalName("mscorlib.dll", "System.Runtime.Serialization", "StreamingContextStates")]
	[Flags]
	[Serializable]
	public enum StreamingContextStates
	{
		// Token: 0x04002DBE RID: 11710
		CrossProcess = 1,
		// Token: 0x04002DBF RID: 11711
		CrossMachine = 2,
		// Token: 0x04002DC0 RID: 11712
		File = 4,
		// Token: 0x04002DC1 RID: 11713
		Persistence = 8,
		// Token: 0x04002DC2 RID: 11714
		Remoting = 16,
		// Token: 0x04002DC3 RID: 11715
		Other = 32,
		// Token: 0x04002DC4 RID: 11716
		Clone = 64,
		// Token: 0x04002DC5 RID: 11717
		CrossAppDomain = 128,
		// Token: 0x04002DC6 RID: 11718
		All = 255
	}
}

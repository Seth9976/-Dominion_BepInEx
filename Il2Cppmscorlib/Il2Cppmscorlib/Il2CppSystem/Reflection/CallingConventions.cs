using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200019E RID: 414
	[OriginalName("mscorlib.dll", "System.Reflection", "CallingConventions")]
	[Flags]
	[Serializable]
	public enum CallingConventions
	{
		// Token: 0x04001906 RID: 6406
		Standard = 1,
		// Token: 0x04001907 RID: 6407
		VarArgs = 2,
		// Token: 0x04001908 RID: 6408
		Any = 3,
		// Token: 0x04001909 RID: 6409
		HasThis = 32,
		// Token: 0x0400190A RID: 6410
		ExplicitThis = 64
	}
}

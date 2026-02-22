using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000199 RID: 409
	[OriginalName("mscorlib.dll", "System.Reflection", "AssemblyNameFlags")]
	[Flags]
	[Serializable]
	public enum AssemblyNameFlags
	{
		// Token: 0x040018DA RID: 6362
		None = 0,
		// Token: 0x040018DB RID: 6363
		PublicKey = 1,
		// Token: 0x040018DC RID: 6364
		EnableJITcompileOptimizer = 16384,
		// Token: 0x040018DD RID: 6365
		EnableJITcompileTracking = 32768,
		// Token: 0x040018DE RID: 6366
		Retargetable = 256
	}
}

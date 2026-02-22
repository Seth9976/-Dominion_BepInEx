using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001A8 RID: 424
	[OriginalName("mscorlib.dll", "System.Reflection", "ResourceLocation")]
	[Flags]
	[Serializable]
	public enum ResourceLocation
	{
		// Token: 0x0400193F RID: 6463
		Embedded = 1,
		// Token: 0x04001940 RID: 6464
		ContainedInAnotherAssembly = 2,
		// Token: 0x04001941 RID: 6465
		ContainedInManifestFile = 4
	}
}

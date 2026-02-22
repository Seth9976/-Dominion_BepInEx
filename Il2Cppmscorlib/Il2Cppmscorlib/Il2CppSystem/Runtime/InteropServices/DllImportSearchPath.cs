using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200044A RID: 1098
	[OriginalName("mscorlib.dll", "System.Runtime.InteropServices", "DllImportSearchPath")]
	[Flags]
	public enum DllImportSearchPath
	{
		// Token: 0x04003683 RID: 13955
		UseDllDirectoryForDependencies = 256,
		// Token: 0x04003684 RID: 13956
		ApplicationDirectory = 512,
		// Token: 0x04003685 RID: 13957
		UserDirectories = 1024,
		// Token: 0x04003686 RID: 13958
		System32 = 2048,
		// Token: 0x04003687 RID: 13959
		SafeDirectories = 4096,
		// Token: 0x04003688 RID: 13960
		AssemblyDirectory = 2,
		// Token: 0x04003689 RID: 13961
		LegacyBehavior = 0
	}
}

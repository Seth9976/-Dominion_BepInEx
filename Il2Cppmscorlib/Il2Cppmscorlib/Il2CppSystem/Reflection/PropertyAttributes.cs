using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001B7 RID: 439
	[OriginalName("mscorlib.dll", "System.Reflection", "PropertyAttributes")]
	[Flags]
	[Serializable]
	public enum PropertyAttributes
	{
		// Token: 0x040019F4 RID: 6644
		None = 0,
		// Token: 0x040019F5 RID: 6645
		SpecialName = 512,
		// Token: 0x040019F6 RID: 6646
		ReservedMask = 62464,
		// Token: 0x040019F7 RID: 6647
		RTSpecialName = 1024,
		// Token: 0x040019F8 RID: 6648
		HasDefault = 4096,
		// Token: 0x040019F9 RID: 6649
		Reserved2 = 8192,
		// Token: 0x040019FA RID: 6650
		Reserved3 = 16384,
		// Token: 0x040019FB RID: 6651
		Reserved4 = 32768
	}
}

using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001DE RID: 478
	[OriginalName("mscorlib.dll", "System.Reflection", "PInfo")]
	[Flags]
	public enum PInfo
	{
		// Token: 0x04001BE9 RID: 7145
		Attributes = 1,
		// Token: 0x04001BEA RID: 7146
		GetMethod = 2,
		// Token: 0x04001BEB RID: 7147
		SetMethod = 4,
		// Token: 0x04001BEC RID: 7148
		ReflectedType = 8,
		// Token: 0x04001BED RID: 7149
		DeclaringType = 16,
		// Token: 0x04001BEE RID: 7150
		Name = 32
	}
}

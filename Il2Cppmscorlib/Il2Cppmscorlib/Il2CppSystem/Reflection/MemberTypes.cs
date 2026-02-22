using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001AD RID: 429
	[OriginalName("mscorlib.dll", "System.Reflection", "MemberTypes")]
	[Flags]
	[Serializable]
	public enum MemberTypes
	{
		// Token: 0x04001976 RID: 6518
		Constructor = 1,
		// Token: 0x04001977 RID: 6519
		Event = 2,
		// Token: 0x04001978 RID: 6520
		Field = 4,
		// Token: 0x04001979 RID: 6521
		Method = 8,
		// Token: 0x0400197A RID: 6522
		Property = 16,
		// Token: 0x0400197B RID: 6523
		TypeInfo = 32,
		// Token: 0x0400197C RID: 6524
		Custom = 64,
		// Token: 0x0400197D RID: 6525
		NestedType = 128,
		// Token: 0x0400197E RID: 6526
		All = 191
	}
}

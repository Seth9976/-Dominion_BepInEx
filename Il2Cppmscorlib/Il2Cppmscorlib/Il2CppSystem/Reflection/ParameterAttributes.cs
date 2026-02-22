using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001B4 RID: 436
	[OriginalName("mscorlib.dll", "System.Reflection", "ParameterAttributes")]
	[Flags]
	[Serializable]
	public enum ParameterAttributes
	{
		// Token: 0x040019E1 RID: 6625
		None = 0,
		// Token: 0x040019E2 RID: 6626
		In = 1,
		// Token: 0x040019E3 RID: 6627
		Out = 2,
		// Token: 0x040019E4 RID: 6628
		Lcid = 4,
		// Token: 0x040019E5 RID: 6629
		Retval = 8,
		// Token: 0x040019E6 RID: 6630
		Optional = 16,
		// Token: 0x040019E7 RID: 6631
		ReservedMask = 61440,
		// Token: 0x040019E8 RID: 6632
		HasDefault = 4096,
		// Token: 0x040019E9 RID: 6633
		HasFieldMarshal = 8192,
		// Token: 0x040019EA RID: 6634
		Reserved3 = 16384,
		// Token: 0x040019EB RID: 6635
		Reserved4 = 32768
	}
}

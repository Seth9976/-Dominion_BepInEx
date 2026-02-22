using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x020004CA RID: 1226
	[OriginalName("mscorlib.dll", "System.Diagnostics.Tracing", "EventFieldFormat")]
	public enum EventFieldFormat
	{
		// Token: 0x04003A3C RID: 14908
		Default,
		// Token: 0x04003A3D RID: 14909
		String = 2,
		// Token: 0x04003A3E RID: 14910
		Boolean,
		// Token: 0x04003A3F RID: 14911
		Hexadecimal,
		// Token: 0x04003A40 RID: 14912
		Xml = 11,
		// Token: 0x04003A41 RID: 14913
		Json,
		// Token: 0x04003A42 RID: 14914
		HResult = 15
	}
}

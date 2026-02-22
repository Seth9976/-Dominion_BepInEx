using System;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x0200000A RID: 10
	[Flags]
	public enum GlyphLoadFlags
	{
		// Token: 0x04000091 RID: 145
		LOAD_DEFAULT = 0,
		// Token: 0x04000092 RID: 146
		LOAD_NO_SCALE = 1,
		// Token: 0x04000093 RID: 147
		LOAD_NO_HINTING = 2,
		// Token: 0x04000094 RID: 148
		LOAD_RENDER = 4,
		// Token: 0x04000095 RID: 149
		LOAD_NO_BITMAP = 8,
		// Token: 0x04000096 RID: 150
		LOAD_FORCE_AUTOHINT = 32,
		// Token: 0x04000097 RID: 151
		LOAD_MONOCHROME = 4096,
		// Token: 0x04000098 RID: 152
		LOAD_NO_AUTOHINT = 32768,
		// Token: 0x04000099 RID: 153
		LOAD_COMPUTE_METRICS = 2097152,
		// Token: 0x0400009A RID: 154
		LOAD_BITMAP_METRICS_ONLY = 4194304
	}
}

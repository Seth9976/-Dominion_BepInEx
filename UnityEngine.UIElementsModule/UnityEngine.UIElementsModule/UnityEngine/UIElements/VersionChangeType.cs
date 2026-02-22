using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000016 RID: 22
	[Flags]
	public enum VersionChangeType
	{
		// Token: 0x040000A2 RID: 162
		Bindings = 1,
		// Token: 0x040000A3 RID: 163
		ViewData = 2,
		// Token: 0x040000A4 RID: 164
		Hierarchy = 4,
		// Token: 0x040000A5 RID: 165
		Layout = 8,
		// Token: 0x040000A6 RID: 166
		StyleSheet = 16,
		// Token: 0x040000A7 RID: 167
		Styles = 32,
		// Token: 0x040000A8 RID: 168
		Overflow = 64,
		// Token: 0x040000A9 RID: 169
		BorderRadius = 128,
		// Token: 0x040000AA RID: 170
		BorderWidth = 256,
		// Token: 0x040000AB RID: 171
		Transform = 512,
		// Token: 0x040000AC RID: 172
		Size = 1024,
		// Token: 0x040000AD RID: 173
		Repaint = 2048,
		// Token: 0x040000AE RID: 174
		Opacity = 4096
	}
}

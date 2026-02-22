using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000526 RID: 1318
	[OriginalName("mscorlib.dll", "System.Diagnostics.Tracing", "EventOpcode")]
	public enum EventOpcode
	{
		// Token: 0x04003D79 RID: 15737
		Info,
		// Token: 0x04003D7A RID: 15738
		Start,
		// Token: 0x04003D7B RID: 15739
		Stop,
		// Token: 0x04003D7C RID: 15740
		DataCollectionStart,
		// Token: 0x04003D7D RID: 15741
		DataCollectionStop,
		// Token: 0x04003D7E RID: 15742
		Extension,
		// Token: 0x04003D7F RID: 15743
		Reply,
		// Token: 0x04003D80 RID: 15744
		Resume,
		// Token: 0x04003D81 RID: 15745
		Suspend,
		// Token: 0x04003D82 RID: 15746
		Send,
		// Token: 0x04003D83 RID: 15747
		Receive = 240
	}
}

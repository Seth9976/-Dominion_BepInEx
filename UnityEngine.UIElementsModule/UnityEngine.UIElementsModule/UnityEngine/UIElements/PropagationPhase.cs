using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200006B RID: 107
	public enum PropagationPhase
	{
		// Token: 0x04000388 RID: 904
		None,
		// Token: 0x04000389 RID: 905
		TrickleDown,
		// Token: 0x0400038A RID: 906
		AtTarget,
		// Token: 0x0400038B RID: 907
		DefaultActionAtTarget = 5,
		// Token: 0x0400038C RID: 908
		BubbleUp = 3,
		// Token: 0x0400038D RID: 909
		DefaultAction
	}
}

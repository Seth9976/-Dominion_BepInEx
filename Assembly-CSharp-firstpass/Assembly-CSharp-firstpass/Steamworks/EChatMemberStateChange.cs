using System;

namespace Steamworks
{
	// Token: 0x02000258 RID: 600
	[Flags]
	public enum EChatMemberStateChange
	{
		// Token: 0x040022C4 RID: 8900
		k_EChatMemberStateChangeEntered = 1,
		// Token: 0x040022C5 RID: 8901
		k_EChatMemberStateChangeLeft = 2,
		// Token: 0x040022C6 RID: 8902
		k_EChatMemberStateChangeDisconnected = 4,
		// Token: 0x040022C7 RID: 8903
		k_EChatMemberStateChangeKicked = 8,
		// Token: 0x040022C8 RID: 8904
		k_EChatMemberStateChangeBanned = 16
	}
}

using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000288 RID: 648
	public enum ShadowMapPass
	{
		// Token: 0x040019E8 RID: 6632
		PointlightPositiveX = 1,
		// Token: 0x040019E9 RID: 6633
		PointlightNegativeX,
		// Token: 0x040019EA RID: 6634
		PointlightPositiveY = 4,
		// Token: 0x040019EB RID: 6635
		PointlightNegativeY = 8,
		// Token: 0x040019EC RID: 6636
		PointlightPositiveZ = 16,
		// Token: 0x040019ED RID: 6637
		PointlightNegativeZ = 32,
		// Token: 0x040019EE RID: 6638
		DirectionalCascade0 = 64,
		// Token: 0x040019EF RID: 6639
		DirectionalCascade1 = 128,
		// Token: 0x040019F0 RID: 6640
		DirectionalCascade2 = 256,
		// Token: 0x040019F1 RID: 6641
		DirectionalCascade3 = 512,
		// Token: 0x040019F2 RID: 6642
		Spotlight = 1024,
		// Token: 0x040019F3 RID: 6643
		Pointlight = 63,
		// Token: 0x040019F4 RID: 6644
		Directional = 960,
		// Token: 0x040019F5 RID: 6645
		All = 2047
	}
}

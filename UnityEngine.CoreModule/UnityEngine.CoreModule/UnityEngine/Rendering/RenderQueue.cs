using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200027B RID: 635
	public enum RenderQueue
	{
		// Token: 0x04001970 RID: 6512
		Background = 1000,
		// Token: 0x04001971 RID: 6513
		Geometry = 2000,
		// Token: 0x04001972 RID: 6514
		AlphaTest = 2450,
		// Token: 0x04001973 RID: 6515
		GeometryLast = 2500,
		// Token: 0x04001974 RID: 6516
		Transparent = 3000,
		// Token: 0x04001975 RID: 6517
		Overlay = 4000
	}
}

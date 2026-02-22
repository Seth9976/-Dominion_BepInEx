using System;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020000D1 RID: 209
	[Flags]
	public enum RenderDataDirtyTypes
	{
		// Token: 0x04000659 RID: 1625
		None = 0,
		// Token: 0x0400065A RID: 1626
		Transform = 1,
		// Token: 0x0400065B RID: 1627
		ClipRectSize = 2,
		// Token: 0x0400065C RID: 1628
		Clipping = 4,
		// Token: 0x0400065D RID: 1629
		ClippingHierarchy = 8,
		// Token: 0x0400065E RID: 1630
		Visuals = 16,
		// Token: 0x0400065F RID: 1631
		VisualsHierarchy = 32,
		// Token: 0x04000660 RID: 1632
		Opacity = 64,
		// Token: 0x04000661 RID: 1633
		OpacityHierarchy = 128
	}
}

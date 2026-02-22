using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020002B1 RID: 689
	public enum SortingCriteria
	{
		// Token: 0x04001B73 RID: 7027
		None,
		// Token: 0x04001B74 RID: 7028
		SortingLayer,
		// Token: 0x04001B75 RID: 7029
		RenderQueue,
		// Token: 0x04001B76 RID: 7030
		BackToFront = 4,
		// Token: 0x04001B77 RID: 7031
		QuantizedFrontToBack = 8,
		// Token: 0x04001B78 RID: 7032
		OptimizeStateChanges = 16,
		// Token: 0x04001B79 RID: 7033
		CanvasOrder = 32,
		// Token: 0x04001B7A RID: 7034
		RendererPriority = 64,
		// Token: 0x04001B7B RID: 7035
		CommonOpaque = 59,
		// Token: 0x04001B7C RID: 7036
		CommonTransparent = 23
	}
}

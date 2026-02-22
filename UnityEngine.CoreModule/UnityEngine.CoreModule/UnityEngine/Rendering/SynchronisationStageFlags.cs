using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020002A4 RID: 676
	public enum SynchronisationStageFlags
	{
		// Token: 0x04001ABB RID: 6843
		VertexProcessing = 1,
		// Token: 0x04001ABC RID: 6844
		PixelProcessing,
		// Token: 0x04001ABD RID: 6845
		ComputeProcessing = 4,
		// Token: 0x04001ABE RID: 6846
		AllGPUOperations = 7
	}
}

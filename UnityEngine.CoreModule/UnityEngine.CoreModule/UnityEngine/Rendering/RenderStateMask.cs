using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020002AE RID: 686
	public enum RenderStateMask
	{
		// Token: 0x04001B6A RID: 7018
		Nothing,
		// Token: 0x04001B6B RID: 7019
		Blend,
		// Token: 0x04001B6C RID: 7020
		Raster,
		// Token: 0x04001B6D RID: 7021
		Depth = 4,
		// Token: 0x04001B6E RID: 7022
		Stencil = 8,
		// Token: 0x04001B6F RID: 7023
		Everything = 15
	}
}

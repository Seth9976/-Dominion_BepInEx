using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020002A0 RID: 672
	public enum RTClearFlags
	{
		// Token: 0x04001A9F RID: 6815
		None,
		// Token: 0x04001AA0 RID: 6816
		Color,
		// Token: 0x04001AA1 RID: 6817
		Depth,
		// Token: 0x04001AA2 RID: 6818
		Stencil = 4,
		// Token: 0x04001AA3 RID: 6819
		All = 7,
		// Token: 0x04001AA4 RID: 6820
		DepthStencil = 6,
		// Token: 0x04001AA5 RID: 6821
		ColorDepth = 3,
		// Token: 0x04001AA6 RID: 6822
		ColorStencil = 5
	}
}

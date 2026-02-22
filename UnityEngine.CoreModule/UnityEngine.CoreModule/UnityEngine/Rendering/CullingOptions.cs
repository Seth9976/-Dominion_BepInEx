using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020002A9 RID: 681
	public enum CullingOptions
	{
		// Token: 0x04001B48 RID: 6984
		None,
		// Token: 0x04001B49 RID: 6985
		ForceEvenIfCameraIsNotActive,
		// Token: 0x04001B4A RID: 6986
		OcclusionCull,
		// Token: 0x04001B4B RID: 6987
		NeedsLighting = 4,
		// Token: 0x04001B4C RID: 6988
		NeedsReflectionProbes = 8,
		// Token: 0x04001B4D RID: 6989
		Stereo = 16,
		// Token: 0x04001B4E RID: 6990
		DisablePerObjectCulling = 32,
		// Token: 0x04001B4F RID: 6991
		ShadowCasters = 64
	}
}

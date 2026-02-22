using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000286 RID: 646
	public static class CameraEventUtils
	{
		// Token: 0x06002019 RID: 8217 RVA: 0x0006727C File Offset: 0x0006547C
		public static bool IsValid(CameraEvent value)
		{
			return value >= CameraEvent.BeforeDepthTexture && value <= CameraEvent.AfterHaloAndLensFlares;
		}

		// Token: 0x040019DE RID: 6622
		public const CameraEvent k_MinimumValue = CameraEvent.BeforeDepthTexture;

		// Token: 0x040019DF RID: 6623
		public const CameraEvent k_MaximumValue = CameraEvent.AfterHaloAndLensFlares;
	}
}

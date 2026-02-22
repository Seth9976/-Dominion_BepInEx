using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200029A RID: 666
	public enum CopyTextureSupport
	{
		// Token: 0x04001A84 RID: 6788
		None,
		// Token: 0x04001A85 RID: 6789
		Basic,
		// Token: 0x04001A86 RID: 6790
		Copy3D,
		// Token: 0x04001A87 RID: 6791
		DifferentTypes = 4,
		// Token: 0x04001A88 RID: 6792
		TextureToRT = 8,
		// Token: 0x04001A89 RID: 6793
		RTToTexture = 16
	}
}

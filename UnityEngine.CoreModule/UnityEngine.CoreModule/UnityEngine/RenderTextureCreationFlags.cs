using System;

namespace UnityEngine
{
	// Token: 0x02000068 RID: 104
	[Flags]
	public enum RenderTextureCreationFlags
	{
		// Token: 0x04000647 RID: 1607
		MipMap = 1,
		// Token: 0x04000648 RID: 1608
		AutoGenerateMips = 2,
		// Token: 0x04000649 RID: 1609
		SRGB = 4,
		// Token: 0x0400064A RID: 1610
		EyeTexture = 8,
		// Token: 0x0400064B RID: 1611
		EnableRandomWrite = 16,
		// Token: 0x0400064C RID: 1612
		CreatedFromScript = 32,
		// Token: 0x0400064D RID: 1613
		AllowVerticalFlip = 128,
		// Token: 0x0400064E RID: 1614
		NoResolvedColorSurface = 256,
		// Token: 0x0400064F RID: 1615
		DynamicallyScalable = 1024,
		// Token: 0x04000650 RID: 1616
		BindMS = 2048
	}
}

using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000147 RID: 327
	[Flags]
	public enum ShaderPropertyFlags
	{
		// Token: 0x04001274 RID: 4724
		None = 0,
		// Token: 0x04001275 RID: 4725
		HideInInspector = 1,
		// Token: 0x04001276 RID: 4726
		PerRendererData = 2,
		// Token: 0x04001277 RID: 4727
		NoScaleOffset = 4,
		// Token: 0x04001278 RID: 4728
		Normal = 8,
		// Token: 0x04001279 RID: 4729
		HDR = 16,
		// Token: 0x0400127A RID: 4730
		Gamma = 32,
		// Token: 0x0400127B RID: 4731
		NonModifiableTextureData = 64,
		// Token: 0x0400127C RID: 4732
		MainTexture = 128,
		// Token: 0x0400127D RID: 4733
		MainColor = 256
	}
}

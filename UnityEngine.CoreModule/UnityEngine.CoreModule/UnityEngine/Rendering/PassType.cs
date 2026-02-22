using System;

namespace UnityEngine.Rendering
{
	// Token: 0x02000289 RID: 649
	public enum PassType
	{
		// Token: 0x040019F7 RID: 6647
		Normal,
		// Token: 0x040019F8 RID: 6648
		Vertex,
		// Token: 0x040019F9 RID: 6649
		VertexLM,
		// Token: 0x040019FA RID: 6650
		VertexLMRGBM,
		// Token: 0x040019FB RID: 6651
		ForwardBase,
		// Token: 0x040019FC RID: 6652
		ForwardAdd,
		// Token: 0x040019FD RID: 6653
		LightPrePassBase,
		// Token: 0x040019FE RID: 6654
		LightPrePassFinal,
		// Token: 0x040019FF RID: 6655
		ShadowCaster,
		// Token: 0x04001A00 RID: 6656
		Deferred = 10,
		// Token: 0x04001A01 RID: 6657
		Meta,
		// Token: 0x04001A02 RID: 6658
		MotionVectors,
		// Token: 0x04001A03 RID: 6659
		ScriptableRenderPipeline,
		// Token: 0x04001A04 RID: 6660
		ScriptableRenderPipelineDefaultUnlit
	}
}

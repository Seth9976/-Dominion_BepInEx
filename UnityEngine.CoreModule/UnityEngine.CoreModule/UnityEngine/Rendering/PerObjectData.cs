using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020002AC RID: 684
	public enum PerObjectData
	{
		// Token: 0x04001B58 RID: 7000
		None,
		// Token: 0x04001B59 RID: 7001
		LightProbe,
		// Token: 0x04001B5A RID: 7002
		ReflectionProbes,
		// Token: 0x04001B5B RID: 7003
		LightProbeProxyVolume = 4,
		// Token: 0x04001B5C RID: 7004
		Lightmaps = 8,
		// Token: 0x04001B5D RID: 7005
		LightData = 16,
		// Token: 0x04001B5E RID: 7006
		MotionVectors = 32,
		// Token: 0x04001B5F RID: 7007
		LightIndices = 64,
		// Token: 0x04001B60 RID: 7008
		ReflectionProbeData = 128,
		// Token: 0x04001B61 RID: 7009
		OcclusionProbe = 256,
		// Token: 0x04001B62 RID: 7010
		OcclusionProbeProxyVolume = 512,
		// Token: 0x04001B63 RID: 7011
		ShadowMask = 1024
	}
}

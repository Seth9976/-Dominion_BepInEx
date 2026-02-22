using System;

namespace UnityEngine
{
	// Token: 0x02000015 RID: 21
	public enum MeshColliderCookingOptions
	{
		// Token: 0x04000142 RID: 322
		None,
		// Token: 0x04000143 RID: 323
		InflateConvexMesh,
		// Token: 0x04000144 RID: 324
		CookForFasterSimulation,
		// Token: 0x04000145 RID: 325
		EnableMeshCleaning = 4,
		// Token: 0x04000146 RID: 326
		WeldColocatedVertices = 8,
		// Token: 0x04000147 RID: 327
		UseFastMidphase = 16
	}
}

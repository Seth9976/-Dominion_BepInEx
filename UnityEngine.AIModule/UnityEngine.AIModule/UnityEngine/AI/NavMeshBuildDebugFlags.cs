using System;

namespace UnityEngine.AI
{
	// Token: 0x0200000F RID: 15
	public enum NavMeshBuildDebugFlags
	{
		// Token: 0x040000A6 RID: 166
		None,
		// Token: 0x040000A7 RID: 167
		InputGeometry,
		// Token: 0x040000A8 RID: 168
		Voxels,
		// Token: 0x040000A9 RID: 169
		Regions = 4,
		// Token: 0x040000AA RID: 170
		RawContours = 8,
		// Token: 0x040000AB RID: 171
		SimplifiedContours = 16,
		// Token: 0x040000AC RID: 172
		PolygonMeshes = 32,
		// Token: 0x040000AD RID: 173
		PolygonMeshesDetail = 64,
		// Token: 0x040000AE RID: 174
		All = 127
	}
}

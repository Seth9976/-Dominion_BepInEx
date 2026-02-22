using System;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public enum TerrainChangedFlags
	{
		// Token: 0x040000B2 RID: 178
		Heightmap = 1,
		// Token: 0x040000B3 RID: 179
		TreeInstances,
		// Token: 0x040000B4 RID: 180
		DelayedHeightmapUpdate = 4,
		// Token: 0x040000B5 RID: 181
		FlushEverythingImmediately = 8,
		// Token: 0x040000B6 RID: 182
		RemoveDirtyDetailsImmediately = 16,
		// Token: 0x040000B7 RID: 183
		HeightmapResolution = 32,
		// Token: 0x040000B8 RID: 184
		Holes = 64,
		// Token: 0x040000B9 RID: 185
		DelayedHolesUpdate = 128,
		// Token: 0x040000BA RID: 186
		WillBeDestroyed = 256
	}
}

using System;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000006 RID: 6
	[Flags]
	public enum TileFlags
	{
		// Token: 0x04000055 RID: 85
		None = 0,
		// Token: 0x04000056 RID: 86
		LockColor = 1,
		// Token: 0x04000057 RID: 87
		LockTransform = 2,
		// Token: 0x04000058 RID: 88
		InstantiateGameObjectRuntimeOnly = 4,
		// Token: 0x04000059 RID: 89
		KeepGameObjectRuntimeOnly = 8,
		// Token: 0x0400005A RID: 90
		LockAll = 3
	}
}

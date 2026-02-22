using System;

namespace UnityEngine.Rendering
{
	// Token: 0x0200012F RID: 303
	[Flags]
	public enum MeshUpdateFlags
	{
		// Token: 0x04001117 RID: 4375
		Default = 0,
		// Token: 0x04001118 RID: 4376
		DontValidateIndices = 1,
		// Token: 0x04001119 RID: 4377
		DontResetBoneBounds = 2,
		// Token: 0x0400111A RID: 4378
		DontNotifyMeshUsers = 4,
		// Token: 0x0400111B RID: 4379
		DontRecalculateBounds = 8
	}
}

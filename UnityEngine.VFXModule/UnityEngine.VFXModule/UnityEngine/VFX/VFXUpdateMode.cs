using System;

namespace UnityEngine.VFX
{
	// Token: 0x02000014 RID: 20
	public enum VFXUpdateMode
	{
		// Token: 0x04000183 RID: 387
		FixedDeltaTime,
		// Token: 0x04000184 RID: 388
		DeltaTime,
		// Token: 0x04000185 RID: 389
		IgnoreTimeScale,
		// Token: 0x04000186 RID: 390
		ExactFixedTimeStep = 4,
		// Token: 0x04000187 RID: 391
		DeltaTimeAndIgnoreTimeScale = 3,
		// Token: 0x04000188 RID: 392
		FixedDeltaAndExactTime,
		// Token: 0x04000189 RID: 393
		FixedDeltaAndExactTimeAndIgnoreTimeScale = 6
	}
}

using System;

namespace UnityEngine.XR
{
	// Token: 0x02000006 RID: 6
	[Flags]
	public enum AvailableTrackingData
	{
		// Token: 0x0400001C RID: 28
		None = 0,
		// Token: 0x0400001D RID: 29
		PositionAvailable = 1,
		// Token: 0x0400001E RID: 30
		RotationAvailable = 2,
		// Token: 0x0400001F RID: 31
		VelocityAvailable = 4,
		// Token: 0x04000020 RID: 32
		AngularVelocityAvailable = 8,
		// Token: 0x04000021 RID: 33
		AccelerationAvailable = 16,
		// Token: 0x04000022 RID: 34
		AngularAccelerationAvailable = 32
	}
}

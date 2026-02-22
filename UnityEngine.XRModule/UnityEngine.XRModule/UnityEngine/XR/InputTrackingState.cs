using System;

namespace UnityEngine.XR
{
	// Token: 0x0200001D RID: 29
	public enum InputTrackingState : uint
	{
		// Token: 0x04000118 RID: 280
		None,
		// Token: 0x04000119 RID: 281
		Position,
		// Token: 0x0400011A RID: 282
		Rotation,
		// Token: 0x0400011B RID: 283
		Velocity = 4U,
		// Token: 0x0400011C RID: 284
		AngularVelocity = 8U,
		// Token: 0x0400011D RID: 285
		Acceleration = 16U,
		// Token: 0x0400011E RID: 286
		AngularAcceleration = 32U,
		// Token: 0x0400011F RID: 287
		All = 63U
	}
}

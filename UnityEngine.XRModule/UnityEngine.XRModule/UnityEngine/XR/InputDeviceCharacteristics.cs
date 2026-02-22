using System;

namespace UnityEngine.XR
{
	// Token: 0x0200001C RID: 28
	public enum InputDeviceCharacteristics : uint
	{
		// Token: 0x0400010B RID: 267
		None,
		// Token: 0x0400010C RID: 268
		HeadMounted,
		// Token: 0x0400010D RID: 269
		Camera,
		// Token: 0x0400010E RID: 270
		HeldInHand = 4U,
		// Token: 0x0400010F RID: 271
		HandTracking = 8U,
		// Token: 0x04000110 RID: 272
		EyeTracking = 16U,
		// Token: 0x04000111 RID: 273
		TrackedDevice = 32U,
		// Token: 0x04000112 RID: 274
		Controller = 64U,
		// Token: 0x04000113 RID: 275
		TrackingReference = 128U,
		// Token: 0x04000114 RID: 276
		Left = 256U,
		// Token: 0x04000115 RID: 277
		Right = 512U,
		// Token: 0x04000116 RID: 278
		Simulated6DOF = 1024U
	}
}

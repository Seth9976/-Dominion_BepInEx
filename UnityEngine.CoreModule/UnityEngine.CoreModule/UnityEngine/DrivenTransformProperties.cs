using System;

namespace UnityEngine
{
	// Token: 0x020000DB RID: 219
	[Flags]
	public enum DrivenTransformProperties
	{
		// Token: 0x04000E21 RID: 3617
		None = 0,
		// Token: 0x04000E22 RID: 3618
		All = -1,
		// Token: 0x04000E23 RID: 3619
		AnchoredPositionX = 2,
		// Token: 0x04000E24 RID: 3620
		AnchoredPositionY = 4,
		// Token: 0x04000E25 RID: 3621
		AnchoredPositionZ = 8,
		// Token: 0x04000E26 RID: 3622
		Rotation = 16,
		// Token: 0x04000E27 RID: 3623
		ScaleX = 32,
		// Token: 0x04000E28 RID: 3624
		ScaleY = 64,
		// Token: 0x04000E29 RID: 3625
		ScaleZ = 128,
		// Token: 0x04000E2A RID: 3626
		AnchorMinX = 256,
		// Token: 0x04000E2B RID: 3627
		AnchorMinY = 512,
		// Token: 0x04000E2C RID: 3628
		AnchorMaxX = 1024,
		// Token: 0x04000E2D RID: 3629
		AnchorMaxY = 2048,
		// Token: 0x04000E2E RID: 3630
		SizeDeltaX = 4096,
		// Token: 0x04000E2F RID: 3631
		SizeDeltaY = 8192,
		// Token: 0x04000E30 RID: 3632
		PivotX = 16384,
		// Token: 0x04000E31 RID: 3633
		PivotY = 32768,
		// Token: 0x04000E32 RID: 3634
		AnchoredPosition = 6,
		// Token: 0x04000E33 RID: 3635
		AnchoredPosition3D = 14,
		// Token: 0x04000E34 RID: 3636
		Scale = 224,
		// Token: 0x04000E35 RID: 3637
		AnchorMin = 768,
		// Token: 0x04000E36 RID: 3638
		AnchorMax = 3072,
		// Token: 0x04000E37 RID: 3639
		Anchors = 3840,
		// Token: 0x04000E38 RID: 3640
		SizeDelta = 12288,
		// Token: 0x04000E39 RID: 3641
		Pivot = 49152
	}
}

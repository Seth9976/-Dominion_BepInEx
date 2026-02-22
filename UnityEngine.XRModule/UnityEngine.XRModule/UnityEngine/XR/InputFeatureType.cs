using System;

namespace UnityEngine.XR
{
	// Token: 0x02000008 RID: 8
	public enum InputFeatureType : uint
	{
		// Token: 0x0400003B RID: 59
		Custom,
		// Token: 0x0400003C RID: 60
		Binary,
		// Token: 0x0400003D RID: 61
		DiscreteStates,
		// Token: 0x0400003E RID: 62
		Axis1D,
		// Token: 0x0400003F RID: 63
		Axis2D,
		// Token: 0x04000040 RID: 64
		Axis3D,
		// Token: 0x04000041 RID: 65
		Rotation,
		// Token: 0x04000042 RID: 66
		Hand,
		// Token: 0x04000043 RID: 67
		Bone,
		// Token: 0x04000044 RID: 68
		Eyes,
		// Token: 0x04000045 RID: 69
		kUnityXRInputFeatureTypeInvalid = 4294967295U
	}
}

using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000021 RID: 33
	public static class TextNative
	{
		// Token: 0x06000152 RID: 338 RVA: 0x00005180 File Offset: 0x00003380
		public static float ComputeTextScaling(Matrix4x4 worldMatrix, float pixelsPerPoint)
		{
			Vector3 vector = new Vector3(worldMatrix.m00, worldMatrix.m10, worldMatrix.m20);
			Vector3 vector2 = new Vector3(worldMatrix.m01, worldMatrix.m11, worldMatrix.m21);
			float num = (vector.magnitude + vector2.magnitude) / 2f;
			return num * pixelsPerPoint;
		}
	}
}

using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000193 RID: 403
	public static class TextUtilities
	{
		// Token: 0x0600112B RID: 4395 RVA: 0x000386FC File Offset: 0x000368FC
		public static float ComputeTextScaling(Matrix4x4 worldMatrix, float pixelsPerPoint)
		{
			Vector3 vector = new Vector3(worldMatrix.m00, worldMatrix.m10, worldMatrix.m20);
			Vector3 vector2 = new Vector3(worldMatrix.m01, worldMatrix.m11, worldMatrix.m21);
			float num = (vector.magnitude + vector2.magnitude) / 2f;
			return num * pixelsPerPoint;
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x0000B037 File Offset: 0x00009237
		public static Vector2 MeasureVisualElementTextSize(VisualElement ve, string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode, ITextHandle textHandle)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}

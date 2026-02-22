using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000186 RID: 390
	public static class MeshGenerationContextUtils
	{
		// Token: 0x060010D1 RID: 4305 RVA: 0x0003796C File Offset: 0x00035B6C
		public static Vector2 ConvertBorderRadiusPercentToPoints(Vector2 borderRectSize, Length length)
		{
			float num = length.value;
			float num2 = length.value;
			bool flag = length.unit == LengthUnit.Percent;
			if (flag)
			{
				num = borderRectSize.x * length.value / 100f;
				num2 = borderRectSize.y * length.value / 100f;
			}
			num = Mathf.Max(num, 0f);
			num2 = Mathf.Max(num2, 0f);
			return new Vector2(num, num2);
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x000379E8 File Offset: 0x00035BE8
		public static void GetVisualElementRadii(VisualElement ve, out Vector2 topLeft, out Vector2 bottomLeft, out Vector2 topRight, out Vector2 bottomRight)
		{
			IResolvedStyle resolvedStyle = ve.resolvedStyle;
			Vector2 vector = new Vector2(resolvedStyle.width, resolvedStyle.height);
			ComputedStyle computedStyle = ve.computedStyle;
			topLeft = MeshGenerationContextUtils.ConvertBorderRadiusPercentToPoints(vector, computedStyle.borderTopLeftRadius);
			bottomLeft = MeshGenerationContextUtils.ConvertBorderRadiusPercentToPoints(vector, computedStyle.borderBottomLeftRadius);
			topRight = MeshGenerationContextUtils.ConvertBorderRadiusPercentToPoints(vector, computedStyle.borderTopRightRadius);
			bottomRight = MeshGenerationContextUtils.ConvertBorderRadiusPercentToPoints(vector, computedStyle.borderBottomRightRadius);
		}
	}
}

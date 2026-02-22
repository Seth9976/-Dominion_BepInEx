using System;
using System.Runtime.InteropServices;

namespace UnityEngine.UIElements
{
	// Token: 0x020000F4 RID: 244
	public class AlignmentUtils
	{
		// Token: 0x06000D4E RID: 3406 RVA: 0x000341F8 File Offset: 0x000323F8
		public static float RoundToPixelGrid(float v, float pixelsPerPoint, [Optional] float offset)
		{
			return Mathf.Floor(v * pixelsPerPoint + 0.5f + offset) / pixelsPerPoint;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x0003421C File Offset: 0x0003241C
		public static float CeilToPixelGrid(float v, float pixelsPerPoint, [Optional] float offset)
		{
			return Mathf.Ceil(v * pixelsPerPoint + offset) / pixelsPerPoint;
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x0003423C File Offset: 0x0003243C
		public static float FloorToPixelGrid(float v, float pixelsPerPoint, [Optional] float offset)
		{
			return Mathf.Floor(v * pixelsPerPoint + offset) / pixelsPerPoint;
		}
	}
}

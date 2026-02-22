using System;

namespace UnityEngine.Yoga
{
	// Token: 0x0200000E RID: 14
	public class MeasureOutput
	{
		// Token: 0x06000149 RID: 329 RVA: 0x00005088 File Offset: 0x00003288
		public static YogaSize Make(float width, float height)
		{
			return new YogaSize
			{
				width = width,
				height = height
			};
		}
	}
}

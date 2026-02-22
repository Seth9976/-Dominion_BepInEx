using System;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020001D9 RID: 473
	public static class StyleSheetColor
	{
		// Token: 0x060012F0 RID: 4848 RVA: 0x0000C4CE File Offset: 0x0000A6CE
		public static bool TryGetColor(string name, out Color color)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0003A33C File Offset: 0x0003853C
		public static Color32 HexToColor32(uint color)
		{
			byte b = (byte)(color & 255U);
			byte b2 = (byte)((color >> 8) & 255U);
			byte b3 = (byte)((color >> 16) & 255U);
			return new Color32(b3, b2, b, byte.MaxValue);
		}
	}
}

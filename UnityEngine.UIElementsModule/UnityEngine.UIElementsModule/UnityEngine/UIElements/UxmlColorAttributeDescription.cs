using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A8 RID: 424
	public class UxmlColorAttributeDescription : TypedUxmlAttributeDescription<Color>
	{
		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x0000B2A2 File Offset: 0x000094A2
		public override string defaultValueAsString
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x00038850 File Offset: 0x00036A50
		public static Color ConvertValueToColor(string v, Color defaultValue)
		{
			Color color;
			bool flag = v == null || !ColorUtility.TryParseHtmlString(v, out color);
			Color color2;
			if (flag)
			{
				color2 = defaultValue;
			}
			else
			{
				color2 = color;
			}
			return color2;
		}

		// Token: 0x02000286 RID: 646
		[Serializable]
		public sealed class <>c
		{
		}
	}
}

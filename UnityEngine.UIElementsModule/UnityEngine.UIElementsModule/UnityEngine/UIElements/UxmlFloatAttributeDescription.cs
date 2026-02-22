using System;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A3 RID: 419
	public class UxmlFloatAttributeDescription : TypedUxmlAttributeDescription<float>
	{
		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x0000B261 File Offset: 0x00009461
		public override string defaultValueAsString
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x0003875C File Offset: 0x0003695C
		public static float ConvertValueToFloat(string v, float defaultValue)
		{
			float num;
			bool flag = v == null || !Single.TryParse(v, NumberStyles.Float, CultureInfo.InvariantCulture, out num);
			float num2;
			if (flag)
			{
				num2 = defaultValue;
			}
			else
			{
				num2 = num;
			}
			return num2;
		}

		// Token: 0x02000281 RID: 641
		[Serializable]
		public sealed class <>c
		{
		}
	}
}

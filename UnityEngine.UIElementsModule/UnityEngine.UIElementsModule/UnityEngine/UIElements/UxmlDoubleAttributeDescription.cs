using System;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A4 RID: 420
	public class UxmlDoubleAttributeDescription : TypedUxmlAttributeDescription<double>
	{
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x0000B26E File Offset: 0x0000946E
		public override string defaultValueAsString
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00038794 File Offset: 0x00036994
		public static double ConvertValueToDouble(string v, double defaultValue)
		{
			double num;
			bool flag = v == null || !Double.TryParse(v, NumberStyles.Float, CultureInfo.InvariantCulture, out num);
			double num2;
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

		// Token: 0x02000282 RID: 642
		[Serializable]
		public sealed class <>c
		{
		}
	}
}

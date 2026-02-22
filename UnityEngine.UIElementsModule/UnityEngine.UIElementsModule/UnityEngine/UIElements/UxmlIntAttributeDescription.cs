using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A5 RID: 421
	public class UxmlIntAttributeDescription : TypedUxmlAttributeDescription<int>
	{
		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x0000B27B File Offset: 0x0000947B
		public override string defaultValueAsString
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x000387CC File Offset: 0x000369CC
		public static int ConvertValueToInt(string v, int defaultValue)
		{
			int num;
			bool flag = v == null || !Int32.TryParse(v, out num);
			int num2;
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

		// Token: 0x02000283 RID: 643
		[Serializable]
		public sealed class <>c
		{
		}
	}
}

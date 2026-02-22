using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A7 RID: 423
	public class UxmlBoolAttributeDescription : TypedUxmlAttributeDescription<bool>
	{
		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x0000B295 File Offset: 0x00009495
		public override string defaultValueAsString
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00038824 File Offset: 0x00036A24
		public static bool ConvertValueToBool(string v, bool defaultValue)
		{
			bool flag2;
			bool flag = v == null || !Boolean.TryParse(v, out flag2);
			bool flag3;
			if (flag)
			{
				flag3 = defaultValue;
			}
			else
			{
				flag3 = flag2;
			}
			return flag3;
		}

		// Token: 0x02000285 RID: 645
		[Serializable]
		public sealed class <>c
		{
		}
	}
}

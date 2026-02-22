using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A6 RID: 422
	public class UxmlLongAttributeDescription : TypedUxmlAttributeDescription<long>
	{
		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x0600115B RID: 4443 RVA: 0x0000B288 File Offset: 0x00009488
		public override string defaultValueAsString
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x000387F8 File Offset: 0x000369F8
		public static long ConvertValueToLong(string v, long defaultValue)
		{
			long num;
			bool flag = v == null || !Int64.TryParse(v, out num);
			long num2;
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

		// Token: 0x02000284 RID: 644
		[Serializable]
		public sealed class <>c
		{
		}
	}
}

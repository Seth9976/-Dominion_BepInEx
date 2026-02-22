using System;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020001DE RID: 478
	public class StyleValidator
	{
		// Token: 0x06001302 RID: 4866 RVA: 0x0003A3AC File Offset: 0x000385AC
		public bool IsUnitMissing(string propertySyntax, string propertyValue)
		{
			float num;
			return Single.TryParse(propertyValue, out num) && (propertySyntax.Contains("<length>") || propertySyntax.Contains("<percentage>"));
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x0003A3E8 File Offset: 0x000385E8
		public bool IsUnsupportedColor(string propertySyntax)
		{
			return propertySyntax.StartsWith("<color>");
		}
	}
}

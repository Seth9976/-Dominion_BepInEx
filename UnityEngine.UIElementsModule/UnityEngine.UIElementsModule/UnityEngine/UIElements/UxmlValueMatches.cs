using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001AE RID: 430
	public class UxmlValueMatches : UxmlTypeRestriction
	{
		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x0000B331 File Offset: 0x00009531
		// (set) Token: 0x0600116D RID: 4461 RVA: 0x0000B33E File Offset: 0x0000953E
		public string regex
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00038894 File Offset: 0x00036A94
		public override bool Equals(UxmlTypeRestriction other)
		{
			UxmlValueMatches uxmlValueMatches = other.TryCast<UxmlValueMatches>();
			bool flag = uxmlValueMatches == null;
			return !flag && this.regex == uxmlValueMatches.regex;
		}
	}
}

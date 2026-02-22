using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001AD RID: 429
	public sealed class LocalizationRequiredAttribute : Attribute
	{
		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001C23 RID: 7203 RVA: 0x0000F72D File Offset: 0x0000D92D
		public bool Required
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}

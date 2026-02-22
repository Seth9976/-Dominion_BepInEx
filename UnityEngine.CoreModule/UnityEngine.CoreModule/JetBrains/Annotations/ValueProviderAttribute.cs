using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001A9 RID: 425
	public sealed class ValueProviderAttribute : Attribute
	{
		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001C1F RID: 7199 RVA: 0x0000F6F9 File Offset: 0x0000D8F9
		public string Name
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}

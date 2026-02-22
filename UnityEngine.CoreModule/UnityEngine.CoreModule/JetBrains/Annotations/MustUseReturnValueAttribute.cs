using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001B6 RID: 438
	public sealed class MustUseReturnValueAttribute : Attribute
	{
		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x0000F788 File Offset: 0x0000D988
		public string Justification
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}

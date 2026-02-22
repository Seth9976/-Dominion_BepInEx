using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001B4 RID: 436
	public sealed class PublicAPIAttribute : Attribute
	{
		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x0000F77B File Offset: 0x0000D97B
		public string Comment
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}

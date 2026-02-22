using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001BB RID: 443
	public sealed class CollectionAccessAttribute : Attribute
	{
		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x0000F7F0 File Offset: 0x0000D9F0
		public CollectionAccessType CollectionAccessType
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}

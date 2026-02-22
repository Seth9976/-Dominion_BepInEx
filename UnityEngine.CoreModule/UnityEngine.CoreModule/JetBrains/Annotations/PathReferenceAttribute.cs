using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001B8 RID: 440
	public sealed class PathReferenceAttribute : Attribute
	{
		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x0000F795 File Offset: 0x0000D995
		public string BasePath
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}

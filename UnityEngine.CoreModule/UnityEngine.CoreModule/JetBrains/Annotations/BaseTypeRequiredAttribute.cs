using System;
using Il2CppSystem;

namespace JetBrains.Annotations
{
	// Token: 0x020001AF RID: 431
	public sealed class BaseTypeRequiredAttribute : Attribute
	{
		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x0000F73A File Offset: 0x0000D93A
		public Type BaseType
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}

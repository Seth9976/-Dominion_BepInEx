using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001B0 RID: 432
	public sealed class UsedImplicitlyAttribute : Attribute
	{
		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x0000F747 File Offset: 0x0000D947
		public ImplicitUseKindFlags UseKindFlags
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x0000F754 File Offset: 0x0000D954
		public ImplicitUseTargetFlags TargetFlags
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}

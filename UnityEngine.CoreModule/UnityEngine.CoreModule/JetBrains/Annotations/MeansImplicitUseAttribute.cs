using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001B1 RID: 433
	public sealed class MeansImplicitUseAttribute : Attribute
	{
		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x0000F761 File Offset: 0x0000D961
		public ImplicitUseKindFlags UseKindFlags
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x0000F76E File Offset: 0x0000D96E
		public ImplicitUseTargetFlags TargetFlags
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}

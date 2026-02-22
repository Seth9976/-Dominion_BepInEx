using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001AC RID: 428
	public sealed class ContractAnnotationAttribute : Attribute
	{
		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x0000F713 File Offset: 0x0000D913
		public string Contract
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x0000F720 File Offset: 0x0000D920
		public bool ForceFullStates
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}

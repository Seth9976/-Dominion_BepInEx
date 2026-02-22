using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001B2 RID: 434
	public enum ImplicitUseKindFlags
	{
		// Token: 0x040015E7 RID: 5607
		Default = 7,
		// Token: 0x040015E8 RID: 5608
		Access = 1,
		// Token: 0x040015E9 RID: 5609
		Assign,
		// Token: 0x040015EA RID: 5610
		InstantiatedWithFixedConstructorSignature = 4,
		// Token: 0x040015EB RID: 5611
		InstantiatedNoFixedConstructorSignature = 8
	}
}

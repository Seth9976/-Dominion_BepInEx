using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001A2 RID: 418
	[OriginalName("mscorlib.dll", "System.Reflection", "GenericParameterAttributes")]
	[Flags]
	public enum GenericParameterAttributes
	{
		// Token: 0x04001928 RID: 6440
		None = 0,
		// Token: 0x04001929 RID: 6441
		VarianceMask = 3,
		// Token: 0x0400192A RID: 6442
		Covariant = 1,
		// Token: 0x0400192B RID: 6443
		Contravariant = 2,
		// Token: 0x0400192C RID: 6444
		SpecialConstraintMask = 28,
		// Token: 0x0400192D RID: 6445
		ReferenceTypeConstraint = 4,
		// Token: 0x0400192E RID: 6446
		NotNullableValueTypeConstraint = 8,
		// Token: 0x0400192F RID: 6447
		DefaultConstructorConstraint = 16
	}
}

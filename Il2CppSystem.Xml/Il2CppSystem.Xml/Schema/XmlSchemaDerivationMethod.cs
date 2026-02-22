using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000EE RID: 238
	[OriginalName("System.Xml.dll", "System.Xml.Schema", "XmlSchemaDerivationMethod")]
	[Flags]
	public enum XmlSchemaDerivationMethod
	{
		// Token: 0x04000AC7 RID: 2759
		Empty = 0,
		// Token: 0x04000AC8 RID: 2760
		Substitution = 1,
		// Token: 0x04000AC9 RID: 2761
		Extension = 2,
		// Token: 0x04000ACA RID: 2762
		Restriction = 4,
		// Token: 0x04000ACB RID: 2763
		List = 8,
		// Token: 0x04000ACC RID: 2764
		Union = 16,
		// Token: 0x04000ACD RID: 2765
		All = 255,
		// Token: 0x04000ACE RID: 2766
		None = 256
	}
}

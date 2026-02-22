using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001BC RID: 444
	[OriginalName("mscorlib.dll", "System.Reflection", "TypeAttributes")]
	[Flags]
	[Serializable]
	public enum TypeAttributes
	{
		// Token: 0x04001A0D RID: 6669
		VisibilityMask = 7,
		// Token: 0x04001A0E RID: 6670
		NotPublic = 0,
		// Token: 0x04001A0F RID: 6671
		Public = 1,
		// Token: 0x04001A10 RID: 6672
		NestedPublic = 2,
		// Token: 0x04001A11 RID: 6673
		NestedPrivate = 3,
		// Token: 0x04001A12 RID: 6674
		NestedFamily = 4,
		// Token: 0x04001A13 RID: 6675
		NestedAssembly = 5,
		// Token: 0x04001A14 RID: 6676
		NestedFamANDAssem = 6,
		// Token: 0x04001A15 RID: 6677
		NestedFamORAssem = 7,
		// Token: 0x04001A16 RID: 6678
		LayoutMask = 24,
		// Token: 0x04001A17 RID: 6679
		AutoLayout = 0,
		// Token: 0x04001A18 RID: 6680
		SequentialLayout = 8,
		// Token: 0x04001A19 RID: 6681
		ExplicitLayout = 16,
		// Token: 0x04001A1A RID: 6682
		ClassSemanticsMask = 32,
		// Token: 0x04001A1B RID: 6683
		Class = 0,
		// Token: 0x04001A1C RID: 6684
		Interface = 32,
		// Token: 0x04001A1D RID: 6685
		Abstract = 128,
		// Token: 0x04001A1E RID: 6686
		Sealed = 256,
		// Token: 0x04001A1F RID: 6687
		SpecialName = 1024,
		// Token: 0x04001A20 RID: 6688
		Import = 4096,
		// Token: 0x04001A21 RID: 6689
		Serializable = 8192,
		// Token: 0x04001A22 RID: 6690
		WindowsRuntime = 16384,
		// Token: 0x04001A23 RID: 6691
		StringFormatMask = 196608,
		// Token: 0x04001A24 RID: 6692
		AnsiClass = 0,
		// Token: 0x04001A25 RID: 6693
		UnicodeClass = 65536,
		// Token: 0x04001A26 RID: 6694
		AutoClass = 131072,
		// Token: 0x04001A27 RID: 6695
		CustomFormatClass = 196608,
		// Token: 0x04001A28 RID: 6696
		CustomFormatMask = 12582912,
		// Token: 0x04001A29 RID: 6697
		BeforeFieldInit = 1048576,
		// Token: 0x04001A2A RID: 6698
		ReservedMask = 264192,
		// Token: 0x04001A2B RID: 6699
		RTSpecialName = 2048,
		// Token: 0x04001A2C RID: 6700
		HasSecurity = 262144
	}
}

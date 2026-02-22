using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x02000042 RID: 66
	[OriginalName("mscorlib.dll", "Microsoft.Win32", "RegistryValueKind")]
	public enum RegistryValueKind
	{
		// Token: 0x0400031E RID: 798
		Unknown,
		// Token: 0x0400031F RID: 799
		String,
		// Token: 0x04000320 RID: 800
		ExpandString,
		// Token: 0x04000321 RID: 801
		Binary,
		// Token: 0x04000322 RID: 802
		DWord,
		// Token: 0x04000323 RID: 803
		MultiString = 7,
		// Token: 0x04000324 RID: 804
		QWord = 11,
		// Token: 0x04000325 RID: 805
		None = -1
	}
}

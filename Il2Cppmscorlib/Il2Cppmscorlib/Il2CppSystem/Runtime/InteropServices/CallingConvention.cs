using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200044F RID: 1103
	[OriginalName("mscorlib.dll", "System.Runtime.InteropServices", "CallingConvention")]
	[Serializable]
	public enum CallingConvention
	{
		// Token: 0x040036A2 RID: 13986
		Winapi = 1,
		// Token: 0x040036A3 RID: 13987
		Cdecl,
		// Token: 0x040036A4 RID: 13988
		StdCall,
		// Token: 0x040036A5 RID: 13989
		ThisCall,
		// Token: 0x040036A6 RID: 13990
		FastCall
	}
}

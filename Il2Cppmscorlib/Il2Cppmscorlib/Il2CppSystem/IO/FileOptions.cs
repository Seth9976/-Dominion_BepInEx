using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.IO
{
	// Token: 0x02000217 RID: 535
	[OriginalName("mscorlib.dll", "System.IO", "FileOptions")]
	[Flags]
	[Serializable]
	public enum FileOptions
	{
		// Token: 0x04001F02 RID: 7938
		None = 0,
		// Token: 0x04001F03 RID: 7939
		Encrypted = 16384,
		// Token: 0x04001F04 RID: 7940
		DeleteOnClose = 67108864,
		// Token: 0x04001F05 RID: 7941
		SequentialScan = 134217728,
		// Token: 0x04001F06 RID: 7942
		RandomAccess = 268435456,
		// Token: 0x04001F07 RID: 7943
		Asynchronous = 1073741824,
		// Token: 0x04001F08 RID: 7944
		WriteThrough = -2147483648
	}
}

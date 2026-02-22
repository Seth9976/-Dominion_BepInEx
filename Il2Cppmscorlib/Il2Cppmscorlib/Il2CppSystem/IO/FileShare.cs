using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.IO
{
	// Token: 0x02000218 RID: 536
	[OriginalName("mscorlib.dll", "System.IO", "FileShare")]
	[Flags]
	[Serializable]
	public enum FileShare
	{
		// Token: 0x04001F0A RID: 7946
		None = 0,
		// Token: 0x04001F0B RID: 7947
		Read = 1,
		// Token: 0x04001F0C RID: 7948
		Write = 2,
		// Token: 0x04001F0D RID: 7949
		ReadWrite = 3,
		// Token: 0x04001F0E RID: 7950
		Delete = 4,
		// Token: 0x04001F0F RID: 7951
		Inheritable = 16
	}
}

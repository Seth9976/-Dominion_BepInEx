using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.IO
{
	// Token: 0x02000215 RID: 533
	[OriginalName("mscorlib.dll", "System.IO", "FileAttributes")]
	[Flags]
	[Serializable]
	public enum FileAttributes
	{
		// Token: 0x04001EEA RID: 7914
		Archive = 32,
		// Token: 0x04001EEB RID: 7915
		Compressed = 2048,
		// Token: 0x04001EEC RID: 7916
		Device = 64,
		// Token: 0x04001EED RID: 7917
		Directory = 16,
		// Token: 0x04001EEE RID: 7918
		Encrypted = 16384,
		// Token: 0x04001EEF RID: 7919
		Hidden = 2,
		// Token: 0x04001EF0 RID: 7920
		Normal = 128,
		// Token: 0x04001EF1 RID: 7921
		NotContentIndexed = 8192,
		// Token: 0x04001EF2 RID: 7922
		Offline = 4096,
		// Token: 0x04001EF3 RID: 7923
		ReadOnly = 1,
		// Token: 0x04001EF4 RID: 7924
		ReparsePoint = 1024,
		// Token: 0x04001EF5 RID: 7925
		SparseFile = 512,
		// Token: 0x04001EF6 RID: 7926
		System = 4,
		// Token: 0x04001EF7 RID: 7927
		Temporary = 256,
		// Token: 0x04001EF8 RID: 7928
		IntegrityStream = 32768,
		// Token: 0x04001EF9 RID: 7929
		NoScrubData = 131072
	}
}

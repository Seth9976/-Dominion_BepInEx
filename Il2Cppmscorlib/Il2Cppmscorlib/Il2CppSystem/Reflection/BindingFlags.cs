using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200019D RID: 413
	[OriginalName("mscorlib.dll", "System.Reflection", "BindingFlags")]
	[Flags]
	[Serializable]
	public enum BindingFlags
	{
		// Token: 0x040018F1 RID: 6385
		Default = 0,
		// Token: 0x040018F2 RID: 6386
		IgnoreCase = 1,
		// Token: 0x040018F3 RID: 6387
		DeclaredOnly = 2,
		// Token: 0x040018F4 RID: 6388
		Instance = 4,
		// Token: 0x040018F5 RID: 6389
		Static = 8,
		// Token: 0x040018F6 RID: 6390
		Public = 16,
		// Token: 0x040018F7 RID: 6391
		NonPublic = 32,
		// Token: 0x040018F8 RID: 6392
		FlattenHierarchy = 64,
		// Token: 0x040018F9 RID: 6393
		InvokeMethod = 256,
		// Token: 0x040018FA RID: 6394
		CreateInstance = 512,
		// Token: 0x040018FB RID: 6395
		GetField = 1024,
		// Token: 0x040018FC RID: 6396
		SetField = 2048,
		// Token: 0x040018FD RID: 6397
		GetProperty = 4096,
		// Token: 0x040018FE RID: 6398
		SetProperty = 8192,
		// Token: 0x040018FF RID: 6399
		PutDispProperty = 16384,
		// Token: 0x04001900 RID: 6400
		PutRefDispProperty = 32768,
		// Token: 0x04001901 RID: 6401
		ExactBinding = 65536,
		// Token: 0x04001902 RID: 6402
		SuppressChangeType = 131072,
		// Token: 0x04001903 RID: 6403
		OptionalParamBinding = 262144,
		// Token: 0x04001904 RID: 6404
		IgnoreReturn = 16777216
	}
}

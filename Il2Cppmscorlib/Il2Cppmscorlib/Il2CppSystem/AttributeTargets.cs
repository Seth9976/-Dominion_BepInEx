using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x0200007D RID: 125
	[OriginalName("mscorlib.dll", "System", "AttributeTargets")]
	[Flags]
	[Serializable]
	public enum AttributeTargets
	{
		// Token: 0x04000552 RID: 1362
		Assembly = 1,
		// Token: 0x04000553 RID: 1363
		Module = 2,
		// Token: 0x04000554 RID: 1364
		Class = 4,
		// Token: 0x04000555 RID: 1365
		Struct = 8,
		// Token: 0x04000556 RID: 1366
		Enum = 16,
		// Token: 0x04000557 RID: 1367
		Constructor = 32,
		// Token: 0x04000558 RID: 1368
		Method = 64,
		// Token: 0x04000559 RID: 1369
		Property = 128,
		// Token: 0x0400055A RID: 1370
		Field = 256,
		// Token: 0x0400055B RID: 1371
		Event = 512,
		// Token: 0x0400055C RID: 1372
		Interface = 1024,
		// Token: 0x0400055D RID: 1373
		Parameter = 2048,
		// Token: 0x0400055E RID: 1374
		Delegate = 4096,
		// Token: 0x0400055F RID: 1375
		ReturnValue = 8192,
		// Token: 0x04000560 RID: 1376
		GenericParameter = 16384,
		// Token: 0x04000561 RID: 1377
		All = 32767
	}
}

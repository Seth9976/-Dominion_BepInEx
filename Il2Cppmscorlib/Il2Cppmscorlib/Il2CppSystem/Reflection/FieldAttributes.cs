using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001A1 RID: 417
	[OriginalName("mscorlib.dll", "System.Reflection", "FieldAttributes")]
	[Flags]
	[Serializable]
	public enum FieldAttributes
	{
		// Token: 0x04001914 RID: 6420
		FieldAccessMask = 7,
		// Token: 0x04001915 RID: 6421
		PrivateScope = 0,
		// Token: 0x04001916 RID: 6422
		Private = 1,
		// Token: 0x04001917 RID: 6423
		FamANDAssem = 2,
		// Token: 0x04001918 RID: 6424
		Assembly = 3,
		// Token: 0x04001919 RID: 6425
		Family = 4,
		// Token: 0x0400191A RID: 6426
		FamORAssem = 5,
		// Token: 0x0400191B RID: 6427
		Public = 6,
		// Token: 0x0400191C RID: 6428
		Static = 16,
		// Token: 0x0400191D RID: 6429
		InitOnly = 32,
		// Token: 0x0400191E RID: 6430
		Literal = 64,
		// Token: 0x0400191F RID: 6431
		NotSerialized = 128,
		// Token: 0x04001920 RID: 6432
		SpecialName = 512,
		// Token: 0x04001921 RID: 6433
		PinvokeImpl = 8192,
		// Token: 0x04001922 RID: 6434
		ReservedMask = 38144,
		// Token: 0x04001923 RID: 6435
		RTSpecialName = 1024,
		// Token: 0x04001924 RID: 6436
		HasFieldMarshal = 4096,
		// Token: 0x04001925 RID: 6437
		HasDefault = 32768,
		// Token: 0x04001926 RID: 6438
		HasFieldRVA = 256
	}
}

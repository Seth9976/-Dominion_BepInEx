using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001A9 RID: 425
	[OriginalName("mscorlib.dll", "System.Reflection", "PInvokeAttributes")]
	[Flags]
	[Serializable]
	public enum PInvokeAttributes
	{
		// Token: 0x04001943 RID: 6467
		NoMangle = 1,
		// Token: 0x04001944 RID: 6468
		CharSetMask = 6,
		// Token: 0x04001945 RID: 6469
		CharSetNotSpec = 0,
		// Token: 0x04001946 RID: 6470
		CharSetAnsi = 2,
		// Token: 0x04001947 RID: 6471
		CharSetUnicode = 4,
		// Token: 0x04001948 RID: 6472
		CharSetAuto = 6,
		// Token: 0x04001949 RID: 6473
		BestFitUseAssem = 0,
		// Token: 0x0400194A RID: 6474
		BestFitEnabled = 16,
		// Token: 0x0400194B RID: 6475
		BestFitDisabled = 32,
		// Token: 0x0400194C RID: 6476
		BestFitMask = 48,
		// Token: 0x0400194D RID: 6477
		ThrowOnUnmappableCharUseAssem = 0,
		// Token: 0x0400194E RID: 6478
		ThrowOnUnmappableCharEnabled = 4096,
		// Token: 0x0400194F RID: 6479
		ThrowOnUnmappableCharDisabled = 8192,
		// Token: 0x04001950 RID: 6480
		ThrowOnUnmappableCharMask = 12288,
		// Token: 0x04001951 RID: 6481
		SupportsLastError = 64,
		// Token: 0x04001952 RID: 6482
		CallConvMask = 1792,
		// Token: 0x04001953 RID: 6483
		CallConvWinapi = 256,
		// Token: 0x04001954 RID: 6484
		CallConvCdecl = 512,
		// Token: 0x04001955 RID: 6485
		CallConvStdcall = 768,
		// Token: 0x04001956 RID: 6486
		CallConvThiscall = 1024,
		// Token: 0x04001957 RID: 6487
		CallConvFastcall = 1280,
		// Token: 0x04001958 RID: 6488
		MaxValue = 65535
	}
}

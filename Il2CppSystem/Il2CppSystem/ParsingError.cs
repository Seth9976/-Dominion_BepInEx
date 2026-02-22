using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x02000035 RID: 53
	[OriginalName("System.dll", "System", "ParsingError")]
	public enum ParsingError
	{
		// Token: 0x04000270 RID: 624
		None,
		// Token: 0x04000271 RID: 625
		BadFormat,
		// Token: 0x04000272 RID: 626
		BadScheme,
		// Token: 0x04000273 RID: 627
		BadAuthority,
		// Token: 0x04000274 RID: 628
		EmptyUriString,
		// Token: 0x04000275 RID: 629
		LastRelativeUriOkErrIndex = 4,
		// Token: 0x04000276 RID: 630
		SchemeLimit,
		// Token: 0x04000277 RID: 631
		SizeLimit,
		// Token: 0x04000278 RID: 632
		MustRootedPath,
		// Token: 0x04000279 RID: 633
		BadHostName,
		// Token: 0x0400027A RID: 634
		NonEmptyHost,
		// Token: 0x0400027B RID: 635
		BadPort,
		// Token: 0x0400027C RID: 636
		BadAuthorityTerminator,
		// Token: 0x0400027D RID: 637
		CannotCreateRelative
	}
}

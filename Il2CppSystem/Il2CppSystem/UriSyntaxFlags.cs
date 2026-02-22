using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x0200003E RID: 62
	[OriginalName("System.dll", "System", "UriSyntaxFlags")]
	[Flags]
	public enum UriSyntaxFlags
	{
		// Token: 0x040002E3 RID: 739
		None = 0,
		// Token: 0x040002E4 RID: 740
		MustHaveAuthority = 1,
		// Token: 0x040002E5 RID: 741
		OptionalAuthority = 2,
		// Token: 0x040002E6 RID: 742
		MayHaveUserInfo = 4,
		// Token: 0x040002E7 RID: 743
		MayHavePort = 8,
		// Token: 0x040002E8 RID: 744
		MayHavePath = 16,
		// Token: 0x040002E9 RID: 745
		MayHaveQuery = 32,
		// Token: 0x040002EA RID: 746
		MayHaveFragment = 64,
		// Token: 0x040002EB RID: 747
		AllowEmptyHost = 128,
		// Token: 0x040002EC RID: 748
		AllowUncHost = 256,
		// Token: 0x040002ED RID: 749
		AllowDnsHost = 512,
		// Token: 0x040002EE RID: 750
		AllowIPv4Host = 1024,
		// Token: 0x040002EF RID: 751
		AllowIPv6Host = 2048,
		// Token: 0x040002F0 RID: 752
		AllowAnInternetHost = 3584,
		// Token: 0x040002F1 RID: 753
		AllowAnyOtherHost = 4096,
		// Token: 0x040002F2 RID: 754
		FileLikeUri = 8192,
		// Token: 0x040002F3 RID: 755
		MailToLikeUri = 16384,
		// Token: 0x040002F4 RID: 756
		V1_UnknownUri = 65536,
		// Token: 0x040002F5 RID: 757
		SimpleUserSyntax = 131072,
		// Token: 0x040002F6 RID: 758
		BuiltInSyntax = 262144,
		// Token: 0x040002F7 RID: 759
		ParserSchemeOnly = 524288,
		// Token: 0x040002F8 RID: 760
		AllowDOSPath = 1048576,
		// Token: 0x040002F9 RID: 761
		PathIsRooted = 2097152,
		// Token: 0x040002FA RID: 762
		ConvertPathSlashes = 4194304,
		// Token: 0x040002FB RID: 763
		CompressPath = 8388608,
		// Token: 0x040002FC RID: 764
		CanonicalizeAsFilePath = 16777216,
		// Token: 0x040002FD RID: 765
		UnEscapeDotsAndSlashes = 33554432,
		// Token: 0x040002FE RID: 766
		AllowIdn = 67108864,
		// Token: 0x040002FF RID: 767
		AllowIriParsing = 268435456
	}
}

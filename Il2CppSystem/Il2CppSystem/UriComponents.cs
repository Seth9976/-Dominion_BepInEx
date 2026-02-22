using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem
{
	// Token: 0x02000032 RID: 50
	[OriginalName("System.dll", "System", "UriComponents")]
	[Flags]
	public enum UriComponents
	{
		// Token: 0x04000256 RID: 598
		Scheme = 1,
		// Token: 0x04000257 RID: 599
		UserInfo = 2,
		// Token: 0x04000258 RID: 600
		Host = 4,
		// Token: 0x04000259 RID: 601
		Port = 8,
		// Token: 0x0400025A RID: 602
		Path = 16,
		// Token: 0x0400025B RID: 603
		Query = 32,
		// Token: 0x0400025C RID: 604
		Fragment = 64,
		// Token: 0x0400025D RID: 605
		StrongPort = 128,
		// Token: 0x0400025E RID: 606
		NormalizedHost = 256,
		// Token: 0x0400025F RID: 607
		KeepDelimiter = 1073741824,
		// Token: 0x04000260 RID: 608
		SerializationInfoString = -2147483648,
		// Token: 0x04000261 RID: 609
		AbsoluteUri = 127,
		// Token: 0x04000262 RID: 610
		HostAndPort = 132,
		// Token: 0x04000263 RID: 611
		StrongAuthority = 134,
		// Token: 0x04000264 RID: 612
		SchemeAndServer = 13,
		// Token: 0x04000265 RID: 613
		HttpRequestUrl = 61,
		// Token: 0x04000266 RID: 614
		PathAndQuery = 48
	}
}

using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net
{
	// Token: 0x020000D7 RID: 215
	[OriginalName("System.dll", "System.Net", "WebExceptionStatus")]
	public enum WebExceptionStatus
	{
		// Token: 0x040009BD RID: 2493
		Success,
		// Token: 0x040009BE RID: 2494
		NameResolutionFailure,
		// Token: 0x040009BF RID: 2495
		ConnectFailure,
		// Token: 0x040009C0 RID: 2496
		ReceiveFailure,
		// Token: 0x040009C1 RID: 2497
		SendFailure,
		// Token: 0x040009C2 RID: 2498
		PipelineFailure,
		// Token: 0x040009C3 RID: 2499
		RequestCanceled,
		// Token: 0x040009C4 RID: 2500
		ProtocolError,
		// Token: 0x040009C5 RID: 2501
		ConnectionClosed,
		// Token: 0x040009C6 RID: 2502
		TrustFailure,
		// Token: 0x040009C7 RID: 2503
		SecureChannelFailure,
		// Token: 0x040009C8 RID: 2504
		ServerProtocolViolation,
		// Token: 0x040009C9 RID: 2505
		KeepAliveFailure,
		// Token: 0x040009CA RID: 2506
		Pending,
		// Token: 0x040009CB RID: 2507
		Timeout,
		// Token: 0x040009CC RID: 2508
		ProxyNameResolutionFailure,
		// Token: 0x040009CD RID: 2509
		UnknownError,
		// Token: 0x040009CE RID: 2510
		MessageLengthLimitExceeded,
		// Token: 0x040009CF RID: 2511
		CacheEntryNotFound,
		// Token: 0x040009D0 RID: 2512
		RequestProhibitedByCachePolicy,
		// Token: 0x040009D1 RID: 2513
		RequestProhibitedByProxy
	}
}

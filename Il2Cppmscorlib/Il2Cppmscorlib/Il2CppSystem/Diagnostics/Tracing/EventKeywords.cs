using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000528 RID: 1320
	[OriginalName("mscorlib.dll", "System.Diagnostics.Tracing", "EventKeywords")]
	[Flags]
	public enum EventKeywords : long
	{
		// Token: 0x04003D8B RID: 15755
		None = 0L,
		// Token: 0x04003D8C RID: 15756
		All = -1L,
		// Token: 0x04003D8D RID: 15757
		MicrosoftTelemetry = 562949953421312L,
		// Token: 0x04003D8E RID: 15758
		WdiContext = 562949953421312L,
		// Token: 0x04003D8F RID: 15759
		WdiDiagnostic = 1125899906842624L,
		// Token: 0x04003D90 RID: 15760
		Sqm = 2251799813685248L,
		// Token: 0x04003D91 RID: 15761
		AuditFailure = 4503599627370496L,
		// Token: 0x04003D92 RID: 15762
		AuditSuccess = 9007199254740992L,
		// Token: 0x04003D93 RID: 15763
		CorrelationHint = 4503599627370496L,
		// Token: 0x04003D94 RID: 15764
		EventLogClassic = 36028797018963968L
	}
}

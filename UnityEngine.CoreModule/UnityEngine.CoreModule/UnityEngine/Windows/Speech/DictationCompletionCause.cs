using System;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x020000F1 RID: 241
	public enum DictationCompletionCause
	{
		// Token: 0x04000F76 RID: 3958
		Complete,
		// Token: 0x04000F77 RID: 3959
		AudioQualityFailure,
		// Token: 0x04000F78 RID: 3960
		Canceled,
		// Token: 0x04000F79 RID: 3961
		TimeoutExceeded,
		// Token: 0x04000F7A RID: 3962
		PauseLimitExceeded,
		// Token: 0x04000F7B RID: 3963
		NetworkFailure,
		// Token: 0x04000F7C RID: 3964
		MicrophoneUnavailable,
		// Token: 0x04000F7D RID: 3965
		UnknownError
	}
}

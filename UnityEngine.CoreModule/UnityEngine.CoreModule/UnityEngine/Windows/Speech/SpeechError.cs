using System;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x020000F0 RID: 240
	public enum SpeechError
	{
		// Token: 0x04000F6B RID: 3947
		NoError,
		// Token: 0x04000F6C RID: 3948
		TopicLanguageNotSupported,
		// Token: 0x04000F6D RID: 3949
		GrammarLanguageMismatch,
		// Token: 0x04000F6E RID: 3950
		GrammarCompilationFailure,
		// Token: 0x04000F6F RID: 3951
		AudioQualityFailure,
		// Token: 0x04000F70 RID: 3952
		PauseLimitExceeded,
		// Token: 0x04000F71 RID: 3953
		TimeoutExceeded,
		// Token: 0x04000F72 RID: 3954
		NetworkFailure,
		// Token: 0x04000F73 RID: 3955
		MicrophoneUnavailable,
		// Token: 0x04000F74 RID: 3956
		UnknownError
	}
}

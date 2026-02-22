using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200036D RID: 877
	[OriginalName("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "InternalParseTypeE")]
	[Serializable]
	public enum InternalParseTypeE
	{
		// Token: 0x04002F05 RID: 12037
		Empty,
		// Token: 0x04002F06 RID: 12038
		SerializedStreamHeader,
		// Token: 0x04002F07 RID: 12039
		Object,
		// Token: 0x04002F08 RID: 12040
		Member,
		// Token: 0x04002F09 RID: 12041
		ObjectEnd,
		// Token: 0x04002F0A RID: 12042
		MemberEnd,
		// Token: 0x04002F0B RID: 12043
		Headers,
		// Token: 0x04002F0C RID: 12044
		HeadersEnd,
		// Token: 0x04002F0D RID: 12045
		SerializedStreamHeaderEnd,
		// Token: 0x04002F0E RID: 12046
		Envelope,
		// Token: 0x04002F0F RID: 12047
		EnvelopeEnd,
		// Token: 0x04002F10 RID: 12048
		Body,
		// Token: 0x04002F11 RID: 12049
		BodyEnd
	}
}

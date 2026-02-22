using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Security.Protocol.Ntlm
{
	// Token: 0x02000012 RID: 18
	[OriginalName("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "NtlmAuthLevel")]
	public enum NtlmAuthLevel
	{
		// Token: 0x040000CB RID: 203
		LM_and_NTLM,
		// Token: 0x040000CC RID: 204
		LM_and_NTLM_and_try_NTLMv2_Session,
		// Token: 0x040000CD RID: 205
		NTLM_only,
		// Token: 0x040000CE RID: 206
		NTLMv2_only
	}
}

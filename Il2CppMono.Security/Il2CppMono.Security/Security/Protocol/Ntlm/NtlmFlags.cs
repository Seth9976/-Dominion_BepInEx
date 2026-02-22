using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppMono.Security.Protocol.Ntlm
{
	// Token: 0x02000013 RID: 19
	[OriginalName("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "NtlmFlags")]
	[Flags]
	public enum NtlmFlags
	{
		// Token: 0x040000D0 RID: 208
		NegotiateUnicode = 1,
		// Token: 0x040000D1 RID: 209
		NegotiateOem = 2,
		// Token: 0x040000D2 RID: 210
		RequestTarget = 4,
		// Token: 0x040000D3 RID: 211
		NegotiateNtlm = 512,
		// Token: 0x040000D4 RID: 212
		NegotiateDomainSupplied = 4096,
		// Token: 0x040000D5 RID: 213
		NegotiateWorkstationSupplied = 8192,
		// Token: 0x040000D6 RID: 214
		NegotiateAlwaysSign = 32768,
		// Token: 0x040000D7 RID: 215
		NegotiateNtlm2Key = 524288,
		// Token: 0x040000D8 RID: 216
		Negotiate128 = 536870912,
		// Token: 0x040000D9 RID: 217
		Negotiate56 = -2147483648
	}
}

using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net
{
	// Token: 0x020000BB RID: 187
	[OriginalName("System.dll", "System.Net", "SecurityProtocolType")]
	[Flags]
	public enum SecurityProtocolType
	{
		// Token: 0x04000894 RID: 2196
		SystemDefault = 0,
		// Token: 0x04000895 RID: 2197
		Ssl3 = 48,
		// Token: 0x04000896 RID: 2198
		Tls = 192,
		// Token: 0x04000897 RID: 2199
		Tls11 = 768,
		// Token: 0x04000898 RID: 2200
		Tls12 = 3072
	}
}

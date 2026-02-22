using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020003B2 RID: 946
	[OriginalName("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "LeaseState")]
	[Serializable]
	public enum LeaseState
	{
		// Token: 0x040032CC RID: 13004
		Null,
		// Token: 0x040032CD RID: 13005
		Initial,
		// Token: 0x040032CE RID: 13006
		Active,
		// Token: 0x040032CF RID: 13007
		Renewing,
		// Token: 0x040032D0 RID: 13008
		Expired
	}
}

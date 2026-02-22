using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x02000297 RID: 663
	[OriginalName("mscorlib.dll", "System.Threading.Tasks", "CausalityRelation")]
	public enum CausalityRelation
	{
		// Token: 0x040026F7 RID: 9975
		AssignDelegate,
		// Token: 0x040026F8 RID: 9976
		Join,
		// Token: 0x040026F9 RID: 9977
		Choice,
		// Token: 0x040026FA RID: 9978
		Cancel,
		// Token: 0x040026FB RID: 9979
		Error
	}
}

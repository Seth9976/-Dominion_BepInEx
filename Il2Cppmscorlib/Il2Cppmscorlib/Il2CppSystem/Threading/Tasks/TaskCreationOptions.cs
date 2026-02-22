using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002A2 RID: 674
	[OriginalName("mscorlib.dll", "System.Threading.Tasks", "TaskCreationOptions")]
	[Flags]
	[Serializable]
	public enum TaskCreationOptions
	{
		// Token: 0x040027D9 RID: 10201
		None = 0,
		// Token: 0x040027DA RID: 10202
		PreferFairness = 1,
		// Token: 0x040027DB RID: 10203
		LongRunning = 2,
		// Token: 0x040027DC RID: 10204
		AttachedToParent = 4,
		// Token: 0x040027DD RID: 10205
		DenyChildAttach = 8,
		// Token: 0x040027DE RID: 10206
		HideScheduler = 16,
		// Token: 0x040027DF RID: 10207
		RunContinuationsAsynchronously = 64
	}
}

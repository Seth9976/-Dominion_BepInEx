using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000458 RID: 1112
	[OriginalName("mscorlib.dll", "System.Runtime.InteropServices", "GCHandleType")]
	[Serializable]
	public enum GCHandleType
	{
		// Token: 0x040036EA RID: 14058
		Weak,
		// Token: 0x040036EB RID: 14059
		WeakTrackResurrection,
		// Token: 0x040036EC RID: 14060
		Normal,
		// Token: 0x040036ED RID: 14061
		Pinned
	}
}

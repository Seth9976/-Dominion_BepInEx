using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001A0 RID: 416
	[OriginalName("mscorlib.dll", "System.Reflection", "EventAttributes")]
	[Flags]
	[Serializable]
	public enum EventAttributes
	{
		// Token: 0x0400190F RID: 6415
		None = 0,
		// Token: 0x04001910 RID: 6416
		SpecialName = 512,
		// Token: 0x04001911 RID: 6417
		ReservedMask = 1024,
		// Token: 0x04001912 RID: 6418
		RTSpecialName = 1024
	}
}

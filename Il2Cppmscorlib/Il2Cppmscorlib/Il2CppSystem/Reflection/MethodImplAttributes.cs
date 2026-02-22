using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001B1 RID: 433
	[OriginalName("mscorlib.dll", "System.Reflection", "MethodImplAttributes")]
	[Serializable]
	public enum MethodImplAttributes
	{
		// Token: 0x040019C2 RID: 6594
		CodeTypeMask = 3,
		// Token: 0x040019C3 RID: 6595
		IL = 0,
		// Token: 0x040019C4 RID: 6596
		Native,
		// Token: 0x040019C5 RID: 6597
		OPTIL,
		// Token: 0x040019C6 RID: 6598
		Runtime,
		// Token: 0x040019C7 RID: 6599
		ManagedMask,
		// Token: 0x040019C8 RID: 6600
		Unmanaged = 4,
		// Token: 0x040019C9 RID: 6601
		Managed = 0,
		// Token: 0x040019CA RID: 6602
		ForwardRef = 16,
		// Token: 0x040019CB RID: 6603
		PreserveSig = 128,
		// Token: 0x040019CC RID: 6604
		InternalCall = 4096,
		// Token: 0x040019CD RID: 6605
		Synchronized = 32,
		// Token: 0x040019CE RID: 6606
		NoInlining = 8,
		// Token: 0x040019CF RID: 6607
		AggressiveInlining = 256,
		// Token: 0x040019D0 RID: 6608
		NoOptimization = 64,
		// Token: 0x040019D1 RID: 6609
		MaxMethodImplVal = 65535
	}
}

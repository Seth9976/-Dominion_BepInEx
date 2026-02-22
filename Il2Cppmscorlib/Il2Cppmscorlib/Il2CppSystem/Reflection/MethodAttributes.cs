using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001AE RID: 430
	[OriginalName("mscorlib.dll", "System.Reflection", "MethodAttributes")]
	[Flags]
	[Serializable]
	public enum MethodAttributes
	{
		// Token: 0x04001980 RID: 6528
		MemberAccessMask = 7,
		// Token: 0x04001981 RID: 6529
		PrivateScope = 0,
		// Token: 0x04001982 RID: 6530
		Private = 1,
		// Token: 0x04001983 RID: 6531
		FamANDAssem = 2,
		// Token: 0x04001984 RID: 6532
		Assembly = 3,
		// Token: 0x04001985 RID: 6533
		Family = 4,
		// Token: 0x04001986 RID: 6534
		FamORAssem = 5,
		// Token: 0x04001987 RID: 6535
		Public = 6,
		// Token: 0x04001988 RID: 6536
		Static = 16,
		// Token: 0x04001989 RID: 6537
		Final = 32,
		// Token: 0x0400198A RID: 6538
		Virtual = 64,
		// Token: 0x0400198B RID: 6539
		HideBySig = 128,
		// Token: 0x0400198C RID: 6540
		CheckAccessOnOverride = 512,
		// Token: 0x0400198D RID: 6541
		VtableLayoutMask = 256,
		// Token: 0x0400198E RID: 6542
		ReuseSlot = 0,
		// Token: 0x0400198F RID: 6543
		NewSlot = 256,
		// Token: 0x04001990 RID: 6544
		Abstract = 1024,
		// Token: 0x04001991 RID: 6545
		SpecialName = 2048,
		// Token: 0x04001992 RID: 6546
		PinvokeImpl = 8192,
		// Token: 0x04001993 RID: 6547
		UnmanagedExport = 8,
		// Token: 0x04001994 RID: 6548
		RTSpecialName = 4096,
		// Token: 0x04001995 RID: 6549
		ReservedMask = 53248,
		// Token: 0x04001996 RID: 6550
		HasSecurity = 16384,
		// Token: 0x04001997 RID: 6551
		RequireSecObject = 32768
	}
}

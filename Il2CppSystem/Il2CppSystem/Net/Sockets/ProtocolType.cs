using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000125 RID: 293
	[OriginalName("System.dll", "System.Net.Sockets", "ProtocolType")]
	public enum ProtocolType
	{
		// Token: 0x04000F31 RID: 3889
		IP,
		// Token: 0x04000F32 RID: 3890
		IPv6HopByHopOptions = 0,
		// Token: 0x04000F33 RID: 3891
		Icmp,
		// Token: 0x04000F34 RID: 3892
		Igmp,
		// Token: 0x04000F35 RID: 3893
		Ggp,
		// Token: 0x04000F36 RID: 3894
		IPv4,
		// Token: 0x04000F37 RID: 3895
		Tcp = 6,
		// Token: 0x04000F38 RID: 3896
		Pup = 12,
		// Token: 0x04000F39 RID: 3897
		Udp = 17,
		// Token: 0x04000F3A RID: 3898
		Idp = 22,
		// Token: 0x04000F3B RID: 3899
		IPv6 = 41,
		// Token: 0x04000F3C RID: 3900
		IPv6RoutingHeader = 43,
		// Token: 0x04000F3D RID: 3901
		IPv6FragmentHeader,
		// Token: 0x04000F3E RID: 3902
		IPSecEncapsulatingSecurityPayload = 50,
		// Token: 0x04000F3F RID: 3903
		IPSecAuthenticationHeader,
		// Token: 0x04000F40 RID: 3904
		IcmpV6 = 58,
		// Token: 0x04000F41 RID: 3905
		IPv6NoNextHeader,
		// Token: 0x04000F42 RID: 3906
		IPv6DestinationOptions,
		// Token: 0x04000F43 RID: 3907
		ND = 77,
		// Token: 0x04000F44 RID: 3908
		Raw = 255,
		// Token: 0x04000F45 RID: 3909
		Unspecified = 0,
		// Token: 0x04000F46 RID: 3910
		Ipx = 1000,
		// Token: 0x04000F47 RID: 3911
		Spx = 1256,
		// Token: 0x04000F48 RID: 3912
		SpxII,
		// Token: 0x04000F49 RID: 3913
		Unknown = -1
	}
}

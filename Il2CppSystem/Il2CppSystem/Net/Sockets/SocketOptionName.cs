using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x0200012B RID: 299
	[OriginalName("System.dll", "System.Net.Sockets", "SocketOptionName")]
	public enum SocketOptionName
	{
		// Token: 0x0400102B RID: 4139
		Debug = 1,
		// Token: 0x0400102C RID: 4140
		AcceptConnection,
		// Token: 0x0400102D RID: 4141
		ReuseAddress = 4,
		// Token: 0x0400102E RID: 4142
		KeepAlive = 8,
		// Token: 0x0400102F RID: 4143
		DontRoute = 16,
		// Token: 0x04001030 RID: 4144
		Broadcast = 32,
		// Token: 0x04001031 RID: 4145
		UseLoopback = 64,
		// Token: 0x04001032 RID: 4146
		Linger = 128,
		// Token: 0x04001033 RID: 4147
		OutOfBandInline = 256,
		// Token: 0x04001034 RID: 4148
		DontLinger = -129,
		// Token: 0x04001035 RID: 4149
		ExclusiveAddressUse = -5,
		// Token: 0x04001036 RID: 4150
		SendBuffer = 4097,
		// Token: 0x04001037 RID: 4151
		ReceiveBuffer,
		// Token: 0x04001038 RID: 4152
		SendLowWater,
		// Token: 0x04001039 RID: 4153
		ReceiveLowWater,
		// Token: 0x0400103A RID: 4154
		SendTimeout,
		// Token: 0x0400103B RID: 4155
		ReceiveTimeout,
		// Token: 0x0400103C RID: 4156
		Error,
		// Token: 0x0400103D RID: 4157
		Type,
		// Token: 0x0400103E RID: 4158
		ReuseUnicastPort = 12295,
		// Token: 0x0400103F RID: 4159
		MaxConnections = 2147483647,
		// Token: 0x04001040 RID: 4160
		IPOptions = 1,
		// Token: 0x04001041 RID: 4161
		HeaderIncluded,
		// Token: 0x04001042 RID: 4162
		TypeOfService,
		// Token: 0x04001043 RID: 4163
		IpTimeToLive,
		// Token: 0x04001044 RID: 4164
		MulticastInterface = 9,
		// Token: 0x04001045 RID: 4165
		MulticastTimeToLive,
		// Token: 0x04001046 RID: 4166
		MulticastLoopback,
		// Token: 0x04001047 RID: 4167
		AddMembership,
		// Token: 0x04001048 RID: 4168
		DropMembership,
		// Token: 0x04001049 RID: 4169
		DontFragment,
		// Token: 0x0400104A RID: 4170
		AddSourceMembership,
		// Token: 0x0400104B RID: 4171
		DropSourceMembership,
		// Token: 0x0400104C RID: 4172
		BlockSource,
		// Token: 0x0400104D RID: 4173
		UnblockSource,
		// Token: 0x0400104E RID: 4174
		PacketInformation,
		// Token: 0x0400104F RID: 4175
		HopLimit = 21,
		// Token: 0x04001050 RID: 4176
		IPProtectionLevel = 23,
		// Token: 0x04001051 RID: 4177
		IPv6Only = 27,
		// Token: 0x04001052 RID: 4178
		NoDelay = 1,
		// Token: 0x04001053 RID: 4179
		BsdUrgent,
		// Token: 0x04001054 RID: 4180
		Expedited = 2,
		// Token: 0x04001055 RID: 4181
		NoChecksum = 1,
		// Token: 0x04001056 RID: 4182
		ChecksumCoverage = 20,
		// Token: 0x04001057 RID: 4183
		UpdateAcceptContext = 28683,
		// Token: 0x04001058 RID: 4184
		UpdateConnectContext = 28688
	}
}

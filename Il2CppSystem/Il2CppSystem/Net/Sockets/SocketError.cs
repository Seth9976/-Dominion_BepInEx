using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000128 RID: 296
	[OriginalName("System.dll", "System.Net.Sockets", "SocketError")]
	public enum SocketError
	{
		// Token: 0x04000FEA RID: 4074
		Success,
		// Token: 0x04000FEB RID: 4075
		SocketError = -1,
		// Token: 0x04000FEC RID: 4076
		Interrupted = 10004,
		// Token: 0x04000FED RID: 4077
		AccessDenied = 10013,
		// Token: 0x04000FEE RID: 4078
		Fault,
		// Token: 0x04000FEF RID: 4079
		InvalidArgument = 10022,
		// Token: 0x04000FF0 RID: 4080
		TooManyOpenSockets = 10024,
		// Token: 0x04000FF1 RID: 4081
		WouldBlock = 10035,
		// Token: 0x04000FF2 RID: 4082
		InProgress,
		// Token: 0x04000FF3 RID: 4083
		AlreadyInProgress,
		// Token: 0x04000FF4 RID: 4084
		NotSocket,
		// Token: 0x04000FF5 RID: 4085
		DestinationAddressRequired,
		// Token: 0x04000FF6 RID: 4086
		MessageSize,
		// Token: 0x04000FF7 RID: 4087
		ProtocolType,
		// Token: 0x04000FF8 RID: 4088
		ProtocolOption,
		// Token: 0x04000FF9 RID: 4089
		ProtocolNotSupported,
		// Token: 0x04000FFA RID: 4090
		SocketNotSupported,
		// Token: 0x04000FFB RID: 4091
		OperationNotSupported,
		// Token: 0x04000FFC RID: 4092
		ProtocolFamilyNotSupported,
		// Token: 0x04000FFD RID: 4093
		AddressFamilyNotSupported,
		// Token: 0x04000FFE RID: 4094
		AddressAlreadyInUse,
		// Token: 0x04000FFF RID: 4095
		AddressNotAvailable,
		// Token: 0x04001000 RID: 4096
		NetworkDown,
		// Token: 0x04001001 RID: 4097
		NetworkUnreachable,
		// Token: 0x04001002 RID: 4098
		NetworkReset,
		// Token: 0x04001003 RID: 4099
		ConnectionAborted,
		// Token: 0x04001004 RID: 4100
		ConnectionReset,
		// Token: 0x04001005 RID: 4101
		NoBufferSpaceAvailable,
		// Token: 0x04001006 RID: 4102
		IsConnected,
		// Token: 0x04001007 RID: 4103
		NotConnected,
		// Token: 0x04001008 RID: 4104
		Shutdown,
		// Token: 0x04001009 RID: 4105
		TimedOut = 10060,
		// Token: 0x0400100A RID: 4106
		ConnectionRefused,
		// Token: 0x0400100B RID: 4107
		HostDown = 10064,
		// Token: 0x0400100C RID: 4108
		HostUnreachable,
		// Token: 0x0400100D RID: 4109
		ProcessLimit = 10067,
		// Token: 0x0400100E RID: 4110
		SystemNotReady = 10091,
		// Token: 0x0400100F RID: 4111
		VersionNotSupported,
		// Token: 0x04001010 RID: 4112
		NotInitialized,
		// Token: 0x04001011 RID: 4113
		Disconnecting = 10101,
		// Token: 0x04001012 RID: 4114
		TypeNotFound = 10109,
		// Token: 0x04001013 RID: 4115
		HostNotFound = 11001,
		// Token: 0x04001014 RID: 4116
		TryAgain,
		// Token: 0x04001015 RID: 4117
		NoRecovery,
		// Token: 0x04001016 RID: 4118
		NoData,
		// Token: 0x04001017 RID: 4119
		IOPending = 997,
		// Token: 0x04001018 RID: 4120
		OperationAborted = 995
	}
}

using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000120 RID: 288
	[OriginalName("System.dll", "System.Net.Sockets", "IOControlCode")]
	public enum IOControlCode : long
	{
		// Token: 0x04000EE4 RID: 3812
		AsyncIO = 2147772029L,
		// Token: 0x04000EE5 RID: 3813
		NonBlockingIO,
		// Token: 0x04000EE6 RID: 3814
		DataToRead = 1074030207L,
		// Token: 0x04000EE7 RID: 3815
		OobDataRead = 1074033415L,
		// Token: 0x04000EE8 RID: 3816
		AssociateHandle = 2281701377L,
		// Token: 0x04000EE9 RID: 3817
		EnableCircularQueuing = 671088642L,
		// Token: 0x04000EEA RID: 3818
		Flush = 671088644L,
		// Token: 0x04000EEB RID: 3819
		GetBroadcastAddress = 1207959557L,
		// Token: 0x04000EEC RID: 3820
		GetExtensionFunctionPointer = 3355443206L,
		// Token: 0x04000EED RID: 3821
		GetQos,
		// Token: 0x04000EEE RID: 3822
		GetGroupQos,
		// Token: 0x04000EEF RID: 3823
		MultipointLoopback = 2281701385L,
		// Token: 0x04000EF0 RID: 3824
		MulticastScope,
		// Token: 0x04000EF1 RID: 3825
		SetQos,
		// Token: 0x04000EF2 RID: 3826
		SetGroupQos,
		// Token: 0x04000EF3 RID: 3827
		TranslateHandle = 3355443213L,
		// Token: 0x04000EF4 RID: 3828
		RoutingInterfaceQuery = 3355443220L,
		// Token: 0x04000EF5 RID: 3829
		RoutingInterfaceChange = 2281701397L,
		// Token: 0x04000EF6 RID: 3830
		AddressListQuery = 1207959574L,
		// Token: 0x04000EF7 RID: 3831
		AddressListChange = 671088663L,
		// Token: 0x04000EF8 RID: 3832
		QueryTargetPnpHandle = 1207959576L,
		// Token: 0x04000EF9 RID: 3833
		NamespaceChange = 2281701401L,
		// Token: 0x04000EFA RID: 3834
		AddressListSort = 3355443225L,
		// Token: 0x04000EFB RID: 3835
		ReceiveAll = 2550136833L,
		// Token: 0x04000EFC RID: 3836
		ReceiveAllMulticast,
		// Token: 0x04000EFD RID: 3837
		ReceiveAllIgmpMulticast,
		// Token: 0x04000EFE RID: 3838
		KeepAliveValues,
		// Token: 0x04000EFF RID: 3839
		AbsorbRouterAlert,
		// Token: 0x04000F00 RID: 3840
		UnicastInterface,
		// Token: 0x04000F01 RID: 3841
		LimitBroadcasts,
		// Token: 0x04000F02 RID: 3842
		BindToInterface,
		// Token: 0x04000F03 RID: 3843
		MulticastInterface,
		// Token: 0x04000F04 RID: 3844
		AddMulticastGroupOnInterface,
		// Token: 0x04000F05 RID: 3845
		DeleteMulticastGroupFromInterface
	}
}

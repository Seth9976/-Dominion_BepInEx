using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Networking
{
	// Token: 0x0200000E RID: 14
	public class ConnectionConfigInternal
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x00002A33 File Offset: 0x00000C33
		public virtual void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00004114 File Offset: 0x00002314
		public ~ConnectionConfigInternal()
		{
			this.Dispose(false);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002A40 File Offset: 0x00000C40
		public void Dispose()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002A4D File Offset: 0x00000C4D
		public static IntPtr InternalCreate()
		{
			return ConnectionConfigInternal.InternalCreateDelegateField();
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002A59 File Offset: 0x00000C59
		public static void InternalDestroy(IntPtr ptr)
		{
			ConnectionConfigInternal.InternalDestroyDelegateField(ptr);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002A66 File Offset: 0x00000C66
		public byte AddChannel(int value)
		{
			return ConnectionConfigInternal.AddChannelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002A79 File Offset: 0x00000C79
		public bool SetPacketSize(ushort value)
		{
			return ConnectionConfigInternal.SetPacketSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
		}

		// Token: 0x17000036 RID: 54
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00002A8C File Offset: 0x00000C8C
		public ushort FragmentSize
		{
			set
			{
				ConnectionConfigInternal.set_FragmentSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000037 RID: 55
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00002A9F File Offset: 0x00000C9F
		public uint ResendTimeout
		{
			set
			{
				ConnectionConfigInternal.set_ResendTimeoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000038 RID: 56
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00002AB2 File Offset: 0x00000CB2
		public uint DisconnectTimeout
		{
			set
			{
				ConnectionConfigInternal.set_DisconnectTimeoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000039 RID: 57
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00002AC5 File Offset: 0x00000CC5
		public uint ConnectTimeout
		{
			set
			{
				ConnectionConfigInternal.set_ConnectTimeoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003A RID: 58
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002AD8 File Offset: 0x00000CD8
		public uint MinUpdateTimeout
		{
			set
			{
				ConnectionConfigInternal.set_MinUpdateTimeoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (set) Token: 0x060000EE RID: 238 RVA: 0x00002AEB File Offset: 0x00000CEB
		public uint PingTimeout
		{
			set
			{
				ConnectionConfigInternal.set_PingTimeoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003C RID: 60
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002AFE File Offset: 0x00000CFE
		public uint ReducedPingTimeout
		{
			set
			{
				ConnectionConfigInternal.set_ReducedPingTimeoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00002B11 File Offset: 0x00000D11
		public uint AllCostTimeout
		{
			set
			{
				ConnectionConfigInternal.set_AllCostTimeoutDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003E RID: 62
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002B24 File Offset: 0x00000D24
		public byte NetworkDropThreshold
		{
			set
			{
				ConnectionConfigInternal.set_NetworkDropThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700003F RID: 63
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002B37 File Offset: 0x00000D37
		public byte OverflowDropThreshold
		{
			set
			{
				ConnectionConfigInternal.set_OverflowDropThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000040 RID: 64
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002B4A File Offset: 0x00000D4A
		public byte MaxConnectionAttempt
		{
			set
			{
				ConnectionConfigInternal.set_MaxConnectionAttemptDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000041 RID: 65
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002B5D File Offset: 0x00000D5D
		public uint AckDelay
		{
			set
			{
				ConnectionConfigInternal.set_AckDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000042 RID: 66
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002B70 File Offset: 0x00000D70
		public uint SendDelay
		{
			set
			{
				ConnectionConfigInternal.set_SendDelayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000043 RID: 67
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00002B83 File Offset: 0x00000D83
		public ushort MaxCombinedReliableMessageSize
		{
			set
			{
				ConnectionConfigInternal.set_MaxCombinedReliableMessageSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000044 RID: 68
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002B96 File Offset: 0x00000D96
		public ushort MaxCombinedReliableMessageCount
		{
			set
			{
				ConnectionConfigInternal.set_MaxCombinedReliableMessageCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000045 RID: 69
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00002BA9 File Offset: 0x00000DA9
		public ushort MaxSentMessageQueueSize
		{
			set
			{
				ConnectionConfigInternal.set_MaxSentMessageQueueSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000046 RID: 70
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002BBC File Offset: 0x00000DBC
		public byte AcksType
		{
			set
			{
				ConnectionConfigInternal.set_AcksTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000047 RID: 71
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00002BCF File Offset: 0x00000DCF
		public bool UsePlatformSpecificProtocols
		{
			set
			{
				ConnectionConfigInternal.set_UsePlatformSpecificProtocolsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000048 RID: 72
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00002BE2 File Offset: 0x00000DE2
		public uint InitialBandwidth
		{
			set
			{
				ConnectionConfigInternal.set_InitialBandwidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000049 RID: 73
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002BF5 File Offset: 0x00000DF5
		public float BandwidthPeakFactor
		{
			set
			{
				ConnectionConfigInternal.set_BandwidthPeakFactorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004A RID: 74
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00002C08 File Offset: 0x00000E08
		public ushort WebSocketReceiveBufferMaxSize
		{
			set
			{
				ConnectionConfigInternal.set_WebSocketReceiveBufferMaxSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700004B RID: 75
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002C1B File Offset: 0x00000E1B
		public uint UdpSocketReceiveBufferMaxSize
		{
			set
			{
				ConnectionConfigInternal.set_UdpSocketReceiveBufferMaxSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002C2E File Offset: 0x00000E2E
		public int SetSSLCertFilePath(string value)
		{
			return ConnectionConfigInternal.SetSSLCertFilePathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002C46 File Offset: 0x00000E46
		public int SetSSLPrivateKeyFilePath(string value)
		{
			return ConnectionConfigInternal.SetSSLPrivateKeyFilePathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002C5E File Offset: 0x00000E5E
		public int SetSSLCAFilePath(string value)
		{
			return ConnectionConfigInternal.SetSSLCAFilePathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002C76 File Offset: 0x00000E76
		public bool MakeChannelsSharedOrder(Il2CppStructArray<byte> values)
		{
			return ConnectionConfigInternal.MakeChannelsSharedOrderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x04000072 RID: 114
		private static readonly ConnectionConfigInternal.InternalCreateDelegate InternalCreateDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.InternalCreateDelegate>("UnityEngine.Networking.ConnectionConfigInternal::InternalCreate");

		// Token: 0x04000073 RID: 115
		private static readonly ConnectionConfigInternal.InternalDestroyDelegate InternalDestroyDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.InternalDestroyDelegate>("UnityEngine.Networking.ConnectionConfigInternal::InternalDestroy");

		// Token: 0x04000074 RID: 116
		private static readonly ConnectionConfigInternal.AddChannelDelegate AddChannelDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.AddChannelDelegate>("UnityEngine.Networking.ConnectionConfigInternal::AddChannel");

		// Token: 0x04000075 RID: 117
		private static readonly ConnectionConfigInternal.SetPacketSizeDelegate SetPacketSizeDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.SetPacketSizeDelegate>("UnityEngine.Networking.ConnectionConfigInternal::SetPacketSize");

		// Token: 0x04000076 RID: 118
		private static readonly ConnectionConfigInternal.set_FragmentSizeDelegate set_FragmentSizeDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_FragmentSizeDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_FragmentSize");

		// Token: 0x04000077 RID: 119
		private static readonly ConnectionConfigInternal.set_ResendTimeoutDelegate set_ResendTimeoutDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_ResendTimeoutDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_ResendTimeout");

		// Token: 0x04000078 RID: 120
		private static readonly ConnectionConfigInternal.set_DisconnectTimeoutDelegate set_DisconnectTimeoutDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_DisconnectTimeoutDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_DisconnectTimeout");

		// Token: 0x04000079 RID: 121
		private static readonly ConnectionConfigInternal.set_ConnectTimeoutDelegate set_ConnectTimeoutDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_ConnectTimeoutDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_ConnectTimeout");

		// Token: 0x0400007A RID: 122
		private static readonly ConnectionConfigInternal.set_MinUpdateTimeoutDelegate set_MinUpdateTimeoutDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_MinUpdateTimeoutDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_MinUpdateTimeout");

		// Token: 0x0400007B RID: 123
		private static readonly ConnectionConfigInternal.set_PingTimeoutDelegate set_PingTimeoutDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_PingTimeoutDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_PingTimeout");

		// Token: 0x0400007C RID: 124
		private static readonly ConnectionConfigInternal.set_ReducedPingTimeoutDelegate set_ReducedPingTimeoutDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_ReducedPingTimeoutDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_ReducedPingTimeout");

		// Token: 0x0400007D RID: 125
		private static readonly ConnectionConfigInternal.set_AllCostTimeoutDelegate set_AllCostTimeoutDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_AllCostTimeoutDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_AllCostTimeout");

		// Token: 0x0400007E RID: 126
		private static readonly ConnectionConfigInternal.set_NetworkDropThresholdDelegate set_NetworkDropThresholdDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_NetworkDropThresholdDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_NetworkDropThreshold");

		// Token: 0x0400007F RID: 127
		private static readonly ConnectionConfigInternal.set_OverflowDropThresholdDelegate set_OverflowDropThresholdDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_OverflowDropThresholdDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_OverflowDropThreshold");

		// Token: 0x04000080 RID: 128
		private static readonly ConnectionConfigInternal.set_MaxConnectionAttemptDelegate set_MaxConnectionAttemptDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_MaxConnectionAttemptDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_MaxConnectionAttempt");

		// Token: 0x04000081 RID: 129
		private static readonly ConnectionConfigInternal.set_AckDelayDelegate set_AckDelayDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_AckDelayDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_AckDelay");

		// Token: 0x04000082 RID: 130
		private static readonly ConnectionConfigInternal.set_SendDelayDelegate set_SendDelayDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_SendDelayDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_SendDelay");

		// Token: 0x04000083 RID: 131
		private static readonly ConnectionConfigInternal.set_MaxCombinedReliableMessageSizeDelegate set_MaxCombinedReliableMessageSizeDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_MaxCombinedReliableMessageSizeDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_MaxCombinedReliableMessageSize");

		// Token: 0x04000084 RID: 132
		private static readonly ConnectionConfigInternal.set_MaxCombinedReliableMessageCountDelegate set_MaxCombinedReliableMessageCountDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_MaxCombinedReliableMessageCountDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_MaxCombinedReliableMessageCount");

		// Token: 0x04000085 RID: 133
		private static readonly ConnectionConfigInternal.set_MaxSentMessageQueueSizeDelegate set_MaxSentMessageQueueSizeDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_MaxSentMessageQueueSizeDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_MaxSentMessageQueueSize");

		// Token: 0x04000086 RID: 134
		private static readonly ConnectionConfigInternal.set_AcksTypeDelegate set_AcksTypeDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_AcksTypeDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_AcksType");

		// Token: 0x04000087 RID: 135
		private static readonly ConnectionConfigInternal.set_UsePlatformSpecificProtocolsDelegate set_UsePlatformSpecificProtocolsDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_UsePlatformSpecificProtocolsDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_UsePlatformSpecificProtocols");

		// Token: 0x04000088 RID: 136
		private static readonly ConnectionConfigInternal.set_InitialBandwidthDelegate set_InitialBandwidthDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_InitialBandwidthDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_InitialBandwidth");

		// Token: 0x04000089 RID: 137
		private static readonly ConnectionConfigInternal.set_BandwidthPeakFactorDelegate set_BandwidthPeakFactorDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_BandwidthPeakFactorDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_BandwidthPeakFactor");

		// Token: 0x0400008A RID: 138
		private static readonly ConnectionConfigInternal.set_WebSocketReceiveBufferMaxSizeDelegate set_WebSocketReceiveBufferMaxSizeDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_WebSocketReceiveBufferMaxSizeDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_WebSocketReceiveBufferMaxSize");

		// Token: 0x0400008B RID: 139
		private static readonly ConnectionConfigInternal.set_UdpSocketReceiveBufferMaxSizeDelegate set_UdpSocketReceiveBufferMaxSizeDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.set_UdpSocketReceiveBufferMaxSizeDelegate>("UnityEngine.Networking.ConnectionConfigInternal::set_UdpSocketReceiveBufferMaxSize");

		// Token: 0x0400008C RID: 140
		private static readonly ConnectionConfigInternal.SetSSLCertFilePathDelegate SetSSLCertFilePathDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.SetSSLCertFilePathDelegate>("UnityEngine.Networking.ConnectionConfigInternal::SetSSLCertFilePath");

		// Token: 0x0400008D RID: 141
		private static readonly ConnectionConfigInternal.SetSSLPrivateKeyFilePathDelegate SetSSLPrivateKeyFilePathDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.SetSSLPrivateKeyFilePathDelegate>("UnityEngine.Networking.ConnectionConfigInternal::SetSSLPrivateKeyFilePath");

		// Token: 0x0400008E RID: 142
		private static readonly ConnectionConfigInternal.SetSSLCAFilePathDelegate SetSSLCAFilePathDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.SetSSLCAFilePathDelegate>("UnityEngine.Networking.ConnectionConfigInternal::SetSSLCAFilePath");

		// Token: 0x0400008F RID: 143
		private static readonly ConnectionConfigInternal.MakeChannelsSharedOrderDelegate MakeChannelsSharedOrderDelegateField = IL2CPP.ResolveICall<ConnectionConfigInternal.MakeChannelsSharedOrderDelegate>("UnityEngine.Networking.ConnectionConfigInternal::MakeChannelsSharedOrder");

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x0600022C RID: 556
		private delegate IntPtr InternalCreateDelegate();

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x0600022E RID: 558
		private delegate void InternalDestroyDelegate(IntPtr ptr);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x06000230 RID: 560
		private delegate byte AddChannelDelegate(IntPtr @this, int value);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x06000232 RID: 562
		private delegate bool SetPacketSizeDelegate(IntPtr @this, ushort value);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x06000234 RID: 564
		private delegate void set_FragmentSizeDelegate(IntPtr @this, ushort value);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x06000236 RID: 566
		private delegate void set_ResendTimeoutDelegate(IntPtr @this, uint value);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x06000238 RID: 568
		private delegate void set_DisconnectTimeoutDelegate(IntPtr @this, uint value);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x0600023A RID: 570
		private delegate void set_ConnectTimeoutDelegate(IntPtr @this, uint value);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x0600023C RID: 572
		private delegate void set_MinUpdateTimeoutDelegate(IntPtr @this, uint value);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x0600023E RID: 574
		private delegate void set_PingTimeoutDelegate(IntPtr @this, uint value);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x06000240 RID: 576
		private delegate void set_ReducedPingTimeoutDelegate(IntPtr @this, uint value);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x06000242 RID: 578
		private delegate void set_AllCostTimeoutDelegate(IntPtr @this, uint value);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x06000244 RID: 580
		private delegate void set_NetworkDropThresholdDelegate(IntPtr @this, byte value);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x06000246 RID: 582
		private delegate void set_OverflowDropThresholdDelegate(IntPtr @this, byte value);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x06000248 RID: 584
		private delegate void set_MaxConnectionAttemptDelegate(IntPtr @this, byte value);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x0600024A RID: 586
		private delegate void set_AckDelayDelegate(IntPtr @this, uint value);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x0600024C RID: 588
		private delegate void set_SendDelayDelegate(IntPtr @this, uint value);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x0600024E RID: 590
		private delegate void set_MaxCombinedReliableMessageSizeDelegate(IntPtr @this, ushort value);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x06000250 RID: 592
		private delegate void set_MaxCombinedReliableMessageCountDelegate(IntPtr @this, ushort value);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x06000252 RID: 594
		private delegate void set_MaxSentMessageQueueSizeDelegate(IntPtr @this, ushort value);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x06000254 RID: 596
		private delegate void set_AcksTypeDelegate(IntPtr @this, byte value);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x06000256 RID: 598
		private delegate void set_UsePlatformSpecificProtocolsDelegate(IntPtr @this, bool value);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x06000258 RID: 600
		private delegate void set_InitialBandwidthDelegate(IntPtr @this, uint value);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x0600025A RID: 602
		private delegate void set_BandwidthPeakFactorDelegate(IntPtr @this, float value);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x0600025C RID: 604
		private delegate void set_WebSocketReceiveBufferMaxSizeDelegate(IntPtr @this, ushort value);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x0600025E RID: 606
		private delegate void set_UdpSocketReceiveBufferMaxSizeDelegate(IntPtr @this, uint value);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x06000260 RID: 608
		private delegate int SetSSLCertFilePathDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x06000262 RID: 610
		private delegate int SetSSLPrivateKeyFilePathDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x06000264 RID: 612
		private delegate int SetSSLCAFilePathDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x06000266 RID: 614
		private delegate bool MakeChannelsSharedOrderDelegate(IntPtr @this, IntPtr values);
	}
}

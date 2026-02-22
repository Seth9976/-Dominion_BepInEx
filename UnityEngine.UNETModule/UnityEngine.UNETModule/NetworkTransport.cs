using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Net;
using UnityEngine.Networking.Types;

namespace UnityEngine.Networking
{
	// Token: 0x02000002 RID: 2
	public sealed class NetworkTransport
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00003884 File Offset: 0x00001A84
		public static bool DoesEndPointUsePlatformProtocols(EndPoint endPoint)
		{
			bool flag = endPoint.GetType().FullName == "UnityEngine.PS4.SceEndPoint";
			if (flag)
			{
				SocketAddress socketAddress = endPoint.Serialize();
				bool flag2 = socketAddress[8] != 0 || socketAddress[9] > 0;
				if (flag2)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		public static int ConnectEndPoint(int hostId, EndPoint endPoint, int exceptionConnectionId, out byte error)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000205D File Offset: 0x0000025D
		public static void Init()
		{
			NetworkTransport.InitializeClass();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		public static void Init(GlobalConfig config)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002073 File Offset: 0x00000273
		public static void InitializeClass()
		{
			NetworkTransport.InitializeClassDelegateField();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000207F File Offset: 0x0000027F
		public static void InitializeClassWithConfig(GlobalConfigInternal config)
		{
			NetworkTransport.InitializeClassWithConfigDelegateField(IL2CPP.Il2CppObjectBaseToPtr(config));
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002091 File Offset: 0x00000291
		public static void Shutdown()
		{
			NetworkTransport.Cleanup();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000038D8 File Offset: 0x00001AD8
		public static string GetAssetId(GameObject go)
		{
			return "";
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000209A File Offset: 0x0000029A
		public static void AddSceneId(int id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020A7 File Offset: 0x000002A7
		public static int GetNextSceneId()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000038F0 File Offset: 0x00001AF0
		public static int AddHostWithSimulator(HostTopology topology, int minTimeout, int maxTimeout, int port, string ip)
		{
			bool flag = topology == null;
			if (flag)
			{
				throw new NullReferenceException("topology is not defined");
			}
			NetworkTransport.CheckTopology(topology);
			return NetworkTransport.AddHostInternal(new HostTopologyInternal(topology), ip, port, minTimeout, maxTimeout);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000392C File Offset: 0x00001B2C
		public static int AddHostWithSimulator(HostTopology topology, int minTimeout, int maxTimeout, int port)
		{
			return NetworkTransport.AddHostWithSimulator(topology, minTimeout, maxTimeout, port, null);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003948 File Offset: 0x00001B48
		public static int AddHostWithSimulator(HostTopology topology, int minTimeout, int maxTimeout)
		{
			return NetworkTransport.AddHostWithSimulator(topology, minTimeout, maxTimeout, 0, null);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003964 File Offset: 0x00001B64
		public static int AddHost(HostTopology topology, int port, string ip)
		{
			return NetworkTransport.AddHostWithSimulator(topology, 0, 0, port, ip);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003980 File Offset: 0x00001B80
		public static int AddHost(HostTopology topology, int port)
		{
			return NetworkTransport.AddHost(topology, port, null);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000399C File Offset: 0x00001B9C
		public static int AddHost(HostTopology topology)
		{
			return NetworkTransport.AddHost(topology, 0, null);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020B4 File Offset: 0x000002B4
		public static int AddHostInternal(HostTopologyInternal topologyInt, string ip, int port, int minTimeout, int maxTimeout)
		{
			return NetworkTransport.AddHostInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(topologyInt), IL2CPP.ManagedStringToIl2Cpp(ip), port, minTimeout, maxTimeout);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000039B8 File Offset: 0x00001BB8
		public static int AddWebsocketHost(HostTopology topology, int port, string ip)
		{
			bool flag = port != 0;
			if (flag)
			{
				bool flag2 = NetworkTransport.IsPortOpen(ip, port);
				if (flag2)
				{
					throw new InvalidOperationException(String.Concat("Cannot open web socket on port ", port.ToString(), " It has been already occupied."));
				}
			}
			bool flag3 = topology == null;
			if (flag3)
			{
				throw new NullReferenceException("topology is not defined");
			}
			NetworkTransport.CheckTopology(topology);
			return NetworkTransport.AddWsHostInternal(new HostTopologyInternal(topology), ip, port);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003A24 File Offset: 0x00001C24
		public static int AddWebsocketHost(HostTopology topology, int port)
		{
			return NetworkTransport.AddWebsocketHost(topology, port, null);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020D0 File Offset: 0x000002D0
		public static int AddWsHostInternal(HostTopologyInternal topologyInt, string ip, int port)
		{
			return NetworkTransport.AddWsHostInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(topologyInt), IL2CPP.ManagedStringToIl2Cpp(ip), port);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020E9 File Offset: 0x000002E9
		public static bool IsPortOpen(string ip, int port)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020F6 File Offset: 0x000002F6
		public static void ConnectAsNetworkHost(int hostId, string address, int port, UnityEngine.Networking.Types.NetworkID network, UnityEngine.Networking.Types.SourceID source, UnityEngine.Networking.Types.NodeID node, out byte error)
		{
			NetworkTransport.ConnectAsNetworkHostInternal(hostId, address, port, (ulong)network, (ulong)source, (ushort)node, out error);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002109 File Offset: 0x00000309
		public static void ConnectAsNetworkHostInternal(int hostId, string address, int port, ulong network, ulong source, ushort node, out byte error)
		{
			NetworkTransport.ConnectAsNetworkHostInternalDelegateField(hostId, IL2CPP.ManagedStringToIl2Cpp(address), port, network, source, node, out error);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002124 File Offset: 0x00000324
		public static void DisconnectNetworkHost(int hostId, out byte error)
		{
			NetworkTransport.DisconnectNetworkHostDelegateField(hostId, out error);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003A40 File Offset: 0x00001C40
		public static NetworkEventType ReceiveRelayEventFromHost(int hostId, out byte error)
		{
			return (NetworkEventType)NetworkTransport.ReceiveRelayEventFromHostInternal(hostId, out error);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002132 File Offset: 0x00000332
		public static int ReceiveRelayEventFromHostInternal(int hostId, out byte error)
		{
			return NetworkTransport.ReceiveRelayEventFromHostInternalDelegateField(hostId, out error);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003A5C File Offset: 0x00001C5C
		public static int ConnectToNetworkPeer(int hostId, string address, int port, int exceptionConnectionId, int relaySlotId, UnityEngine.Networking.Types.NetworkID network, UnityEngine.Networking.Types.SourceID source, UnityEngine.Networking.Types.NodeID node, int bytesPerSec, float bucketSizeFactor, out byte error)
		{
			return NetworkTransport.ConnectToNetworkPeerInternal(hostId, address, port, exceptionConnectionId, relaySlotId, (ulong)network, (ulong)source, (ushort)node, bytesPerSec, bucketSizeFactor, out error);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003A88 File Offset: 0x00001C88
		public static int ConnectToNetworkPeer(int hostId, string address, int port, int exceptionConnectionId, int relaySlotId, UnityEngine.Networking.Types.NetworkID network, UnityEngine.Networking.Types.SourceID source, UnityEngine.Networking.Types.NodeID node, out byte error)
		{
			return NetworkTransport.ConnectToNetworkPeer(hostId, address, port, exceptionConnectionId, relaySlotId, network, source, node, 0, 0f, out error);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003AB4 File Offset: 0x00001CB4
		public static int ConnectToNetworkPeerInternal(int hostId, string address, int port, int exceptionConnectionId, int relaySlotId, ulong network, ulong source, ushort node, int bytesPerSec, float bucketSizeFactor, out byte error)
		{
			return NetworkTransport.ConnectToNetworkPeerInternalDelegateField(hostId, IL2CPP.ManagedStringToIl2Cpp(address), port, exceptionConnectionId, relaySlotId, network, source, node, bytesPerSec, bucketSizeFactor, out error);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003AE4 File Offset: 0x00001CE4
		public static int GetCurrentIncomingMessageAmount()
		{
			return 0;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003AF8 File Offset: 0x00001CF8
		public static int GetCurrentOutgoingMessageAmount()
		{
			return 0;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002140 File Offset: 0x00000340
		public static int GetIncomingMessageQueueSize(int hostId, out byte error)
		{
			return NetworkTransport.GetIncomingMessageQueueSizeDelegateField(hostId, out error);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000214E File Offset: 0x0000034E
		public static int GetOutgoingMessageQueueSize(int hostId, out byte error)
		{
			return NetworkTransport.GetOutgoingMessageQueueSizeDelegateField(hostId, out error);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000215C File Offset: 0x0000035C
		public static int GetCurrentRTT(int hostId, int connectionId, out byte error)
		{
			return NetworkTransport.GetCurrentRTTDelegateField(hostId, connectionId, out error);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003B0C File Offset: 0x00001D0C
		public static int GetCurrentRtt(int hostId, int connectionId, out byte error)
		{
			return NetworkTransport.GetCurrentRTT(hostId, connectionId, out error);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000216B File Offset: 0x0000036B
		public static int GetIncomingPacketLossCount(int hostId, int connectionId, out byte error)
		{
			return NetworkTransport.GetIncomingPacketLossCountDelegateField(hostId, connectionId, out error);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003B28 File Offset: 0x00001D28
		public static int GetNetworkLostPacketNum(int hostId, int connectionId, out byte error)
		{
			return NetworkTransport.GetIncomingPacketLossCount(hostId, connectionId, out error);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000217A File Offset: 0x0000037A
		public static int GetIncomingPacketCount(int hostId, int connectionId, out byte error)
		{
			return NetworkTransport.GetIncomingPacketCountDelegateField(hostId, connectionId, out error);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002189 File Offset: 0x00000389
		public static int GetOutgoingPacketNetworkLossPercent(int hostId, int connectionId, out byte error)
		{
			return NetworkTransport.GetOutgoingPacketNetworkLossPercentDelegateField(hostId, connectionId, out error);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002198 File Offset: 0x00000398
		public static int GetOutgoingPacketOverflowLossPercent(int hostId, int connectionId, out byte error)
		{
			return NetworkTransport.GetOutgoingPacketOverflowLossPercentDelegateField(hostId, connectionId, out error);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000021A7 File Offset: 0x000003A7
		public static int GetMaxAllowedBandwidth(int hostId, int connectionId, out byte error)
		{
			return NetworkTransport.GetMaxAllowedBandwidthDelegateField(hostId, connectionId, out error);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000021B6 File Offset: 0x000003B6
		public static int GetAckBufferCount(int hostId, int connectionId, out byte error)
		{
			return NetworkTransport.GetAckBufferCountDelegateField(hostId, connectionId, out error);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000021C5 File Offset: 0x000003C5
		public static int GetIncomingPacketDropCountForAllHosts()
		{
			return NetworkTransport.GetIncomingPacketDropCountForAllHostsDelegateField();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000021D1 File Offset: 0x000003D1
		public static int GetIncomingPacketCountForAllHosts()
		{
			return NetworkTransport.GetIncomingPacketCountForAllHostsDelegateField();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000021DD File Offset: 0x000003DD
		public static int GetOutgoingPacketCount()
		{
			return NetworkTransport.GetOutgoingPacketCountDelegateField();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000021E9 File Offset: 0x000003E9
		public static int GetOutgoingPacketCountForHost(int hostId, out byte error)
		{
			return NetworkTransport.GetOutgoingPacketCountForHostDelegateField(hostId, out error);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000021F7 File Offset: 0x000003F7
		public static int GetOutgoingPacketCountForConnection(int hostId, int connectionId, out byte error)
		{
			return NetworkTransport.GetOutgoingPacketCountForConnectionDelegateField(hostId, connectionId, out error);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002206 File Offset: 0x00000406
		public static int GetOutgoingMessageCount()
		{
			return NetworkTransport.GetOutgoingMessageCountDelegateField();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002212 File Offset: 0x00000412
		public static int GetOutgoingMessageCountForHost(int hostId, out byte error)
		{
			return NetworkTransport.GetOutgoingMessageCountForHostDelegateField(hostId, out error);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002220 File Offset: 0x00000420
		public static int GetOutgoingMessageCountForConnection(int hostId, int connectionId, out byte error)
		{
			return NetworkTransport.GetOutgoingMessageCountForConnectionDelegateField(hostId, connectionId, out error);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000222F File Offset: 0x0000042F
		public static int GetOutgoingUserBytesCount()
		{
			return NetworkTransport.GetOutgoingUserBytesCountDelegateField();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000223B File Offset: 0x0000043B
		public static int GetOutgoingUserBytesCountForHost(int hostId, out byte error)
		{
			return NetworkTransport.GetOutgoingUserBytesCountForHostDelegateField(hostId, out error);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002249 File Offset: 0x00000449
		public static int GetOutgoingUserBytesCountForConnection(int hostId, int connectionId, out byte error)
		{
			return NetworkTransport.GetOutgoingUserBytesCountForConnectionDelegateField(hostId, connectionId, out error);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002258 File Offset: 0x00000458
		public static int GetOutgoingSystemBytesCount()
		{
			return NetworkTransport.GetOutgoingSystemBytesCountDelegateField();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002264 File Offset: 0x00000464
		public static int GetOutgoingSystemBytesCountForHost(int hostId, out byte error)
		{
			return NetworkTransport.GetOutgoingSystemBytesCountForHostDelegateField(hostId, out error);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002272 File Offset: 0x00000472
		public static int GetOutgoingSystemBytesCountForConnection(int hostId, int connectionId, out byte error)
		{
			return NetworkTransport.GetOutgoingSystemBytesCountForConnectionDelegateField(hostId, connectionId, out error);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002281 File Offset: 0x00000481
		public static int GetOutgoingFullBytesCount()
		{
			return NetworkTransport.GetOutgoingFullBytesCountDelegateField();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000228D File Offset: 0x0000048D
		public static int GetOutgoingFullBytesCountForHost(int hostId, out byte error)
		{
			return NetworkTransport.GetOutgoingFullBytesCountForHostDelegateField(hostId, out error);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000229B File Offset: 0x0000049B
		public static int GetOutgoingFullBytesCountForConnection(int hostId, int connectionId, out byte error)
		{
			return NetworkTransport.GetOutgoingFullBytesCountForConnectionDelegateField(hostId, connectionId, out error);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003B44 File Offset: 0x00001D44
		public static int GetPacketSentRate(int hostId, int connectionId, out byte error)
		{
			error = 0;
			return 0;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003B5C File Offset: 0x00001D5C
		public static int GetPacketReceivedRate(int hostId, int connectionId, out byte error)
		{
			error = 0;
			return 0;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003B74 File Offset: 0x00001D74
		public static int GetRemotePacketReceivedRate(int hostId, int connectionId, out byte error)
		{
			error = 0;
			return 0;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003B8C File Offset: 0x00001D8C
		public static int GetNetIOTimeuS()
		{
			return 0;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003BA0 File Offset: 0x00001DA0
		public static string GetConnectionInfo(int hostId, int connectionId, out int port, out ulong network, out ushort dstNode, out byte error)
		{
			IntPtr intPtr = NetworkTransport.GetConnectionInfoDelegateField(hostId, connectionId, out port, out network, out dstNode, out error);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003BC8 File Offset: 0x00001DC8
		public static void GetConnectionInfo(int hostId, int connectionId, out string address, out int port, out UnityEngine.Networking.Types.NetworkID network, out UnityEngine.Networking.Types.NodeID dstNode, out byte error)
		{
			ulong num;
			ushort num2;
			address = NetworkTransport.GetConnectionInfo(hostId, connectionId, out port, out num, out num2, out error);
			network = (UnityEngine.Networking.Types.NetworkID)num;
			dstNode = (UnityEngine.Networking.Types.NodeID)num2;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000022AA File Offset: 0x000004AA
		public static int GetNetworkTimestamp()
		{
			return NetworkTransport.GetNetworkTimestampDelegateField();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000022B6 File Offset: 0x000004B6
		public static int GetRemoteDelayTimeMS(int hostId, int connectionId, int remoteTime, out byte error)
		{
			return NetworkTransport.GetRemoteDelayTimeMSDelegateField(hostId, connectionId, remoteTime, out error);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003BF0 File Offset: 0x00001DF0
		public static bool StartSendMulticast(int hostId, int channelId, Il2CppStructArray<byte> buffer, int size, out byte error)
		{
			return NetworkTransport.StartSendMulticastInternal(hostId, channelId, buffer, size, out error);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000022C6 File Offset: 0x000004C6
		public static bool StartSendMulticastInternal(int hostId, int channelId, [Out] Il2CppStructArray<byte> buffer, int size, out byte error)
		{
			return NetworkTransport.StartSendMulticastInternalDelegateField(hostId, channelId, IL2CPP.Il2CppObjectBaseToPtr(buffer), size, out error);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000022DD File Offset: 0x000004DD
		public static bool SendMulticast(int hostId, int connectionId, out byte error)
		{
			return NetworkTransport.SendMulticastDelegateField(hostId, connectionId, out error);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000022EC File Offset: 0x000004EC
		public static bool FinishSendMulticast(int hostId, out byte error)
		{
			return NetworkTransport.FinishSendMulticastDelegateField(hostId, out error);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000022FA File Offset: 0x000004FA
		public static int GetMaxPacketSize()
		{
			return NetworkTransport.GetMaxPacketSizeDelegateField();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002306 File Offset: 0x00000506
		public static bool RemoveHost(int hostId)
		{
			return NetworkTransport.RemoveHostDelegateField(hostId);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00003C10 File Offset: 0x00001E10
		public static bool IsStarted
		{
			get
			{
				return NetworkTransport.IsStartedInternal();
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002313 File Offset: 0x00000513
		public static bool IsStartedInternal()
		{
			return NetworkTransport.IsStartedInternalDelegateField();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000231F File Offset: 0x0000051F
		public static int Connect(int hostId, string address, int port, int exeptionConnectionId, out byte error)
		{
			return NetworkTransport.ConnectDelegateField(hostId, IL2CPP.ManagedStringToIl2Cpp(address), port, exeptionConnectionId, out error);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002336 File Offset: 0x00000536
		public static int ConnectWithSimulatorInternal(int hostId, string address, int port, int exeptionConnectionId, out byte error, ConnectionSimulatorConfigInternal conf)
		{
			return NetworkTransport.ConnectWithSimulatorInternalDelegateField(hostId, IL2CPP.ManagedStringToIl2Cpp(address), port, exeptionConnectionId, out error, IL2CPP.Il2CppObjectBaseToPtr(conf));
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003C28 File Offset: 0x00001E28
		public static int ConnectWithSimulator(int hostId, string address, int port, int exeptionConnectionId, out byte error, ConnectionSimulatorConfig conf)
		{
			return NetworkTransport.ConnectWithSimulatorInternal(hostId, address, port, exeptionConnectionId, out error, new ConnectionSimulatorConfigInternal(conf));
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002354 File Offset: 0x00000554
		public static bool Disconnect(int hostId, int connectionId, out byte error)
		{
			return NetworkTransport.DisconnectDelegateField(hostId, connectionId, out error);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002363 File Offset: 0x00000563
		public static int Internal_ConnectEndPoint(int hostId, [Out] Il2CppStructArray<byte> sockAddrStorage, int sockAddrStorageLen, int exceptionConnectionId, out byte error)
		{
			return NetworkTransport.Internal_ConnectEndPointDelegateField(hostId, IL2CPP.Il2CppObjectBaseToPtr(sockAddrStorage), sockAddrStorageLen, exceptionConnectionId, out error);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003C4C File Offset: 0x00001E4C
		public static bool Send(int hostId, int connectionId, int channelId, Il2CppStructArray<byte> buffer, int size, out byte error)
		{
			bool flag = buffer == null;
			if (flag)
			{
				throw new NullReferenceException("send buffer is not initialized");
			}
			return NetworkTransport.SendWrapper(hostId, connectionId, channelId, buffer, size, out error);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000237A File Offset: 0x0000057A
		public static bool SendWrapper(int hostId, int connectionId, int channelId, [Out] Il2CppStructArray<byte> buffer, int size, out byte error)
		{
			return NetworkTransport.SendWrapperDelegateField(hostId, connectionId, channelId, IL2CPP.Il2CppObjectBaseToPtr(buffer), size, out error);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003C80 File Offset: 0x00001E80
		public static bool QueueMessageForSending(int hostId, int connectionId, int channelId, Il2CppStructArray<byte> buffer, int size, out byte error)
		{
			bool flag = buffer == null;
			if (flag)
			{
				throw new NullReferenceException("send buffer is not initialized");
			}
			return NetworkTransport.QueueMessageForSendingWrapper(hostId, connectionId, channelId, buffer, size, out error);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002393 File Offset: 0x00000593
		public static bool QueueMessageForSendingWrapper(int hostId, int connectionId, int channelId, [Out] Il2CppStructArray<byte> buffer, int size, out byte error)
		{
			return NetworkTransport.QueueMessageForSendingWrapperDelegateField(hostId, connectionId, channelId, IL2CPP.Il2CppObjectBaseToPtr(buffer), size, out error);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000023AC File Offset: 0x000005AC
		public static bool SendQueuedMessages(int hostId, int connectionId, out byte error)
		{
			return NetworkTransport.SendQueuedMessagesDelegateField(hostId, connectionId, out error);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003CB4 File Offset: 0x00001EB4
		public static NetworkEventType Receive(out int hostId, out int connectionId, out int channelId, Il2CppStructArray<byte> buffer, int bufferSize, out int receivedSize, out byte error)
		{
			return (NetworkEventType)NetworkTransport.PopData(out hostId, out connectionId, out channelId, buffer, bufferSize, out receivedSize, out error);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000023BB File Offset: 0x000005BB
		public static int PopData(out int hostId, out int connectionId, out int channelId, [Out] Il2CppStructArray<byte> buffer, int bufferSize, out int receivedSize, out byte error)
		{
			return NetworkTransport.PopDataDelegateField(out hostId, out connectionId, out channelId, IL2CPP.Il2CppObjectBaseToPtr(buffer), bufferSize, out receivedSize, out error);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003CD8 File Offset: 0x00001ED8
		public static NetworkEventType ReceiveFromHost(int hostId, out int connectionId, out int channelId, Il2CppStructArray<byte> buffer, int bufferSize, out int receivedSize, out byte error)
		{
			return (NetworkEventType)NetworkTransport.PopDataFromHost(hostId, out connectionId, out channelId, buffer, bufferSize, out receivedSize, out error);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000023D6 File Offset: 0x000005D6
		public static int PopDataFromHost(int hostId, out int connectionId, out int channelId, [Out] Il2CppStructArray<byte> buffer, int bufferSize, out int receivedSize, out byte error)
		{
			return NetworkTransport.PopDataFromHostDelegateField(hostId, out connectionId, out channelId, IL2CPP.Il2CppObjectBaseToPtr(buffer), bufferSize, out receivedSize, out error);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000023F1 File Offset: 0x000005F1
		public static void SetPacketStat(int direction, int packetStatId, int numMsgs, int numBytes)
		{
			NetworkTransport.SetPacketStatDelegateField(direction, packetStatId, numMsgs, numBytes);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002401 File Offset: 0x00000601
		public static void SetNetworkEventAvailableCallback(Action<int> callback)
		{
			NetworkTransport.SetNetworkEventAvailableCallbackDelegateField(IL2CPP.Il2CppObjectBaseToPtr(callback));
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002413 File Offset: 0x00000613
		public static void Cleanup()
		{
			NetworkTransport.CleanupDelegateField();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000241F File Offset: 0x0000061F
		public static bool NotifyWhenConnectionReadyForSend(int hostId, int connectionId, int notificationLevel, out byte error)
		{
			return NetworkTransport.NotifyWhenConnectionReadyForSendDelegateField(hostId, connectionId, notificationLevel, out error);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000242F File Offset: 0x0000062F
		public static int GetHostPort(int hostId)
		{
			return NetworkTransport.GetHostPortDelegateField(hostId);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003CFC File Offset: 0x00001EFC
		public static bool StartBroadcastDiscoveryWithData(int hostId, int broadcastPort, int key, int version, int subversion, [Out] Il2CppStructArray<byte> buffer, int size, int timeout, out byte error)
		{
			return NetworkTransport.StartBroadcastDiscoveryWithDataDelegateField(hostId, broadcastPort, key, version, subversion, IL2CPP.Il2CppObjectBaseToPtr(buffer), size, timeout, out error);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000243C File Offset: 0x0000063C
		public static bool StartBroadcastDiscoveryWithoutData(int hostId, int broadcastPort, int key, int version, int subversion, int timeout, out byte error)
		{
			return NetworkTransport.StartBroadcastDiscoveryWithoutDataDelegateField(hostId, broadcastPort, key, version, subversion, timeout, out error);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003D28 File Offset: 0x00001F28
		public static bool StartBroadcastDiscovery(int hostId, int broadcastPort, int key, int version, int subversion, Il2CppStructArray<byte> buffer, int size, int timeout, out byte error)
		{
			bool flag = buffer != null;
			if (flag)
			{
				bool flag2 = buffer.Length < size;
				if (flag2)
				{
					throw new ArgumentOutOfRangeException(String.Concat("Size: ", size.ToString(), " > buffer.Length ", buffer.Length.ToString()));
				}
				bool flag3 = size == 0;
				if (flag3)
				{
					throw new ArgumentOutOfRangeException("Size is zero while buffer exists, please pass null and 0 as buffer and size parameters");
				}
			}
			bool flag4 = buffer == null;
			bool flag5;
			if (flag4)
			{
				flag5 = NetworkTransport.StartBroadcastDiscoveryWithoutData(hostId, broadcastPort, key, version, subversion, timeout, out error);
			}
			else
			{
				flag5 = NetworkTransport.StartBroadcastDiscoveryWithData(hostId, broadcastPort, key, version, subversion, buffer, size, timeout, out error);
			}
			return flag5;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002452 File Offset: 0x00000652
		public static void StopBroadcastDiscovery()
		{
			NetworkTransport.StopBroadcastDiscoveryDelegateField();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000245E File Offset: 0x0000065E
		public static bool IsBroadcastDiscoveryRunning()
		{
			return NetworkTransport.IsBroadcastDiscoveryRunningDelegateField();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000246A File Offset: 0x0000066A
		public static void SetBroadcastCredentials(int hostId, int key, int version, int subversion, out byte error)
		{
			NetworkTransport.SetBroadcastCredentialsDelegateField(hostId, key, version, subversion, out error);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003DC8 File Offset: 0x00001FC8
		public static string GetBroadcastConnectionInfo(int hostId, out int port, out byte error)
		{
			IntPtr intPtr = NetworkTransport.GetBroadcastConnectionInfoDelegateField(hostId, out port, out error);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000247C File Offset: 0x0000067C
		public static void GetBroadcastConnectionInfo(int hostId, out string address, out int port, out byte error)
		{
			address = NetworkTransport.GetBroadcastConnectionInfo(hostId, out port, out error);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002489 File Offset: 0x00000689
		public static void GetBroadcastConnectionMessage(int hostId, Il2CppStructArray<byte> buffer, int bufferSize, out int receivedSize, out byte error)
		{
			NetworkTransport.GetBroadcastConnectionMessageInternal(hostId, buffer, bufferSize, out receivedSize, out error);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002498 File Offset: 0x00000698
		public static void SetMulticastLock(bool enabled)
		{
			NetworkTransport.SetMulticastLockDelegateField(enabled);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000024A5 File Offset: 0x000006A5
		public static void GetBroadcastConnectionMessageInternal(int hostId, [Out] Il2CppStructArray<byte> buffer, int bufferSize, out int receivedSize, out byte error)
		{
			NetworkTransport.GetBroadcastConnectionMessageInternalDelegateField(hostId, IL2CPP.Il2CppObjectBaseToPtr(buffer), bufferSize, out receivedSize, out error);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003DEC File Offset: 0x00001FEC
		public static void CheckTopology(HostTopology topology)
		{
			int maxPacketSize = NetworkTransport.GetMaxPacketSize();
			bool flag = (int)topology.DefaultConfig.PacketSize > maxPacketSize;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Concat("Default config: packet size should be less than packet size defined in global config: ", maxPacketSize.ToString()));
			}
			for (int i = 0; i < topology.SpecialConnectionConfigs.Count; i++)
			{
				bool flag2 = (int)topology.SpecialConnectionConfigs[i].PacketSize > maxPacketSize;
				if (flag2)
				{
					throw new ArgumentOutOfRangeException(String.Concat("Special config ", i.ToString(), ": packet size should be less than packet size defined in global config: ", maxPacketSize.ToString()));
				}
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000024BC File Offset: 0x000006BC
		public static bool LoadEncryptionLibraryInternal(string libraryName)
		{
			return NetworkTransport.LoadEncryptionLibraryInternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(libraryName));
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003E84 File Offset: 0x00002084
		public static bool LoadEncryptionLibrary(string libraryName)
		{
			return NetworkTransport.LoadEncryptionLibraryInternal(libraryName);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000024CE File Offset: 0x000006CE
		public static void UnloadEncryptionLibraryInternal()
		{
			NetworkTransport.UnloadEncryptionLibraryInternalDelegateField();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000024DA File Offset: 0x000006DA
		public static void UnloadEncryptionLibrary()
		{
			NetworkTransport.UnloadEncryptionLibraryInternal();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000024E3 File Offset: 0x000006E3
		public static bool IsEncryptionActiveInternal()
		{
			return NetworkTransport.IsEncryptionActiveInternalDelegateField();
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003E9C File Offset: 0x0000209C
		public static bool IsEncryptionActive()
		{
			return NetworkTransport.IsEncryptionActiveInternal();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000024EF File Offset: 0x000006EF
		public static short GetEncryptionSafeMaxPacketSizeInternal(short maxPacketSize)
		{
			return NetworkTransport.GetEncryptionSafeMaxPacketSizeInternalDelegateField(maxPacketSize);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00003EB4 File Offset: 0x000020B4
		public static short GetEncryptionSafeMaxPacketSize(short maxPacketSize)
		{
			return NetworkTransport.GetEncryptionSafeMaxPacketSizeInternal(maxPacketSize);
		}

		// Token: 0x04000001 RID: 1
		private static readonly NetworkTransport.InitializeClassDelegate InitializeClassDelegateField = IL2CPP.ResolveICall<NetworkTransport.InitializeClassDelegate>("UnityEngine.Networking.NetworkTransport::InitializeClass");

		// Token: 0x04000002 RID: 2
		private static readonly NetworkTransport.InitializeClassWithConfigDelegate InitializeClassWithConfigDelegateField = IL2CPP.ResolveICall<NetworkTransport.InitializeClassWithConfigDelegate>("UnityEngine.Networking.NetworkTransport::InitializeClassWithConfig");

		// Token: 0x04000003 RID: 3
		private static readonly NetworkTransport.AddHostInternalDelegate AddHostInternalDelegateField = IL2CPP.ResolveICall<NetworkTransport.AddHostInternalDelegate>("UnityEngine.Networking.NetworkTransport::AddHostInternal");

		// Token: 0x04000004 RID: 4
		private static readonly NetworkTransport.AddWsHostInternalDelegate AddWsHostInternalDelegateField = IL2CPP.ResolveICall<NetworkTransport.AddWsHostInternalDelegate>("UnityEngine.Networking.NetworkTransport::AddWsHostInternal");

		// Token: 0x04000005 RID: 5
		private static readonly NetworkTransport.ConnectAsNetworkHostInternalDelegate ConnectAsNetworkHostInternalDelegateField = IL2CPP.ResolveICall<NetworkTransport.ConnectAsNetworkHostInternalDelegate>("UnityEngine.Networking.NetworkTransport::ConnectAsNetworkHostInternal");

		// Token: 0x04000006 RID: 6
		private static readonly NetworkTransport.DisconnectNetworkHostDelegate DisconnectNetworkHostDelegateField = IL2CPP.ResolveICall<NetworkTransport.DisconnectNetworkHostDelegate>("UnityEngine.Networking.NetworkTransport::DisconnectNetworkHost");

		// Token: 0x04000007 RID: 7
		private static readonly NetworkTransport.ReceiveRelayEventFromHostInternalDelegate ReceiveRelayEventFromHostInternalDelegateField = IL2CPP.ResolveICall<NetworkTransport.ReceiveRelayEventFromHostInternalDelegate>("UnityEngine.Networking.NetworkTransport::ReceiveRelayEventFromHostInternal");

		// Token: 0x04000008 RID: 8
		private static readonly NetworkTransport.ConnectToNetworkPeerInternalDelegate ConnectToNetworkPeerInternalDelegateField = IL2CPP.ResolveICall<NetworkTransport.ConnectToNetworkPeerInternalDelegate>("UnityEngine.Networking.NetworkTransport::ConnectToNetworkPeerInternal");

		// Token: 0x04000009 RID: 9
		private static readonly NetworkTransport.GetIncomingMessageQueueSizeDelegate GetIncomingMessageQueueSizeDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetIncomingMessageQueueSizeDelegate>("UnityEngine.Networking.NetworkTransport::GetIncomingMessageQueueSize");

		// Token: 0x0400000A RID: 10
		private static readonly NetworkTransport.GetOutgoingMessageQueueSizeDelegate GetOutgoingMessageQueueSizeDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetOutgoingMessageQueueSizeDelegate>("UnityEngine.Networking.NetworkTransport::GetOutgoingMessageQueueSize");

		// Token: 0x0400000B RID: 11
		private static readonly NetworkTransport.GetCurrentRTTDelegate GetCurrentRTTDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetCurrentRTTDelegate>("UnityEngine.Networking.NetworkTransport::GetCurrentRTT");

		// Token: 0x0400000C RID: 12
		private static readonly NetworkTransport.GetIncomingPacketLossCountDelegate GetIncomingPacketLossCountDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetIncomingPacketLossCountDelegate>("UnityEngine.Networking.NetworkTransport::GetIncomingPacketLossCount");

		// Token: 0x0400000D RID: 13
		private static readonly NetworkTransport.GetIncomingPacketCountDelegate GetIncomingPacketCountDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetIncomingPacketCountDelegate>("UnityEngine.Networking.NetworkTransport::GetIncomingPacketCount");

		// Token: 0x0400000E RID: 14
		private static readonly NetworkTransport.GetOutgoingPacketNetworkLossPercentDelegate GetOutgoingPacketNetworkLossPercentDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetOutgoingPacketNetworkLossPercentDelegate>("UnityEngine.Networking.NetworkTransport::GetOutgoingPacketNetworkLossPercent");

		// Token: 0x0400000F RID: 15
		private static readonly NetworkTransport.GetOutgoingPacketOverflowLossPercentDelegate GetOutgoingPacketOverflowLossPercentDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetOutgoingPacketOverflowLossPercentDelegate>("UnityEngine.Networking.NetworkTransport::GetOutgoingPacketOverflowLossPercent");

		// Token: 0x04000010 RID: 16
		private static readonly NetworkTransport.GetMaxAllowedBandwidthDelegate GetMaxAllowedBandwidthDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetMaxAllowedBandwidthDelegate>("UnityEngine.Networking.NetworkTransport::GetMaxAllowedBandwidth");

		// Token: 0x04000011 RID: 17
		private static readonly NetworkTransport.GetAckBufferCountDelegate GetAckBufferCountDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetAckBufferCountDelegate>("UnityEngine.Networking.NetworkTransport::GetAckBufferCount");

		// Token: 0x04000012 RID: 18
		private static readonly NetworkTransport.GetIncomingPacketDropCountForAllHostsDelegate GetIncomingPacketDropCountForAllHostsDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetIncomingPacketDropCountForAllHostsDelegate>("UnityEngine.Networking.NetworkTransport::GetIncomingPacketDropCountForAllHosts");

		// Token: 0x04000013 RID: 19
		private static readonly NetworkTransport.GetIncomingPacketCountForAllHostsDelegate GetIncomingPacketCountForAllHostsDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetIncomingPacketCountForAllHostsDelegate>("UnityEngine.Networking.NetworkTransport::GetIncomingPacketCountForAllHosts");

		// Token: 0x04000014 RID: 20
		private static readonly NetworkTransport.GetOutgoingPacketCountDelegate GetOutgoingPacketCountDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetOutgoingPacketCountDelegate>("UnityEngine.Networking.NetworkTransport::GetOutgoingPacketCount");

		// Token: 0x04000015 RID: 21
		private static readonly NetworkTransport.GetOutgoingPacketCountForHostDelegate GetOutgoingPacketCountForHostDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetOutgoingPacketCountForHostDelegate>("UnityEngine.Networking.NetworkTransport::GetOutgoingPacketCountForHost");

		// Token: 0x04000016 RID: 22
		private static readonly NetworkTransport.GetOutgoingPacketCountForConnectionDelegate GetOutgoingPacketCountForConnectionDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetOutgoingPacketCountForConnectionDelegate>("UnityEngine.Networking.NetworkTransport::GetOutgoingPacketCountForConnection");

		// Token: 0x04000017 RID: 23
		private static readonly NetworkTransport.GetOutgoingMessageCountDelegate GetOutgoingMessageCountDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetOutgoingMessageCountDelegate>("UnityEngine.Networking.NetworkTransport::GetOutgoingMessageCount");

		// Token: 0x04000018 RID: 24
		private static readonly NetworkTransport.GetOutgoingMessageCountForHostDelegate GetOutgoingMessageCountForHostDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetOutgoingMessageCountForHostDelegate>("UnityEngine.Networking.NetworkTransport::GetOutgoingMessageCountForHost");

		// Token: 0x04000019 RID: 25
		private static readonly NetworkTransport.GetOutgoingMessageCountForConnectionDelegate GetOutgoingMessageCountForConnectionDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetOutgoingMessageCountForConnectionDelegate>("UnityEngine.Networking.NetworkTransport::GetOutgoingMessageCountForConnection");

		// Token: 0x0400001A RID: 26
		private static readonly NetworkTransport.GetOutgoingUserBytesCountDelegate GetOutgoingUserBytesCountDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetOutgoingUserBytesCountDelegate>("UnityEngine.Networking.NetworkTransport::GetOutgoingUserBytesCount");

		// Token: 0x0400001B RID: 27
		private static readonly NetworkTransport.GetOutgoingUserBytesCountForHostDelegate GetOutgoingUserBytesCountForHostDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetOutgoingUserBytesCountForHostDelegate>("UnityEngine.Networking.NetworkTransport::GetOutgoingUserBytesCountForHost");

		// Token: 0x0400001C RID: 28
		private static readonly NetworkTransport.GetOutgoingUserBytesCountForConnectionDelegate GetOutgoingUserBytesCountForConnectionDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetOutgoingUserBytesCountForConnectionDelegate>("UnityEngine.Networking.NetworkTransport::GetOutgoingUserBytesCountForConnection");

		// Token: 0x0400001D RID: 29
		private static readonly NetworkTransport.GetOutgoingSystemBytesCountDelegate GetOutgoingSystemBytesCountDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetOutgoingSystemBytesCountDelegate>("UnityEngine.Networking.NetworkTransport::GetOutgoingSystemBytesCount");

		// Token: 0x0400001E RID: 30
		private static readonly NetworkTransport.GetOutgoingSystemBytesCountForHostDelegate GetOutgoingSystemBytesCountForHostDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetOutgoingSystemBytesCountForHostDelegate>("UnityEngine.Networking.NetworkTransport::GetOutgoingSystemBytesCountForHost");

		// Token: 0x0400001F RID: 31
		private static readonly NetworkTransport.GetOutgoingSystemBytesCountForConnectionDelegate GetOutgoingSystemBytesCountForConnectionDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetOutgoingSystemBytesCountForConnectionDelegate>("UnityEngine.Networking.NetworkTransport::GetOutgoingSystemBytesCountForConnection");

		// Token: 0x04000020 RID: 32
		private static readonly NetworkTransport.GetOutgoingFullBytesCountDelegate GetOutgoingFullBytesCountDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetOutgoingFullBytesCountDelegate>("UnityEngine.Networking.NetworkTransport::GetOutgoingFullBytesCount");

		// Token: 0x04000021 RID: 33
		private static readonly NetworkTransport.GetOutgoingFullBytesCountForHostDelegate GetOutgoingFullBytesCountForHostDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetOutgoingFullBytesCountForHostDelegate>("UnityEngine.Networking.NetworkTransport::GetOutgoingFullBytesCountForHost");

		// Token: 0x04000022 RID: 34
		private static readonly NetworkTransport.GetOutgoingFullBytesCountForConnectionDelegate GetOutgoingFullBytesCountForConnectionDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetOutgoingFullBytesCountForConnectionDelegate>("UnityEngine.Networking.NetworkTransport::GetOutgoingFullBytesCountForConnection");

		// Token: 0x04000023 RID: 35
		private static readonly NetworkTransport.GetConnectionInfoDelegate GetConnectionInfoDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetConnectionInfoDelegate>("UnityEngine.Networking.NetworkTransport::GetConnectionInfo");

		// Token: 0x04000024 RID: 36
		private static readonly NetworkTransport.GetNetworkTimestampDelegate GetNetworkTimestampDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetNetworkTimestampDelegate>("UnityEngine.Networking.NetworkTransport::GetNetworkTimestamp");

		// Token: 0x04000025 RID: 37
		private static readonly NetworkTransport.GetRemoteDelayTimeMSDelegate GetRemoteDelayTimeMSDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetRemoteDelayTimeMSDelegate>("UnityEngine.Networking.NetworkTransport::GetRemoteDelayTimeMS");

		// Token: 0x04000026 RID: 38
		private static readonly NetworkTransport.StartSendMulticastInternalDelegate StartSendMulticastInternalDelegateField = IL2CPP.ResolveICall<NetworkTransport.StartSendMulticastInternalDelegate>("UnityEngine.Networking.NetworkTransport::StartSendMulticastInternal");

		// Token: 0x04000027 RID: 39
		private static readonly NetworkTransport.SendMulticastDelegate SendMulticastDelegateField = IL2CPP.ResolveICall<NetworkTransport.SendMulticastDelegate>("UnityEngine.Networking.NetworkTransport::SendMulticast");

		// Token: 0x04000028 RID: 40
		private static readonly NetworkTransport.FinishSendMulticastDelegate FinishSendMulticastDelegateField = IL2CPP.ResolveICall<NetworkTransport.FinishSendMulticastDelegate>("UnityEngine.Networking.NetworkTransport::FinishSendMulticast");

		// Token: 0x04000029 RID: 41
		private static readonly NetworkTransport.GetMaxPacketSizeDelegate GetMaxPacketSizeDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetMaxPacketSizeDelegate>("UnityEngine.Networking.NetworkTransport::GetMaxPacketSize");

		// Token: 0x0400002A RID: 42
		private static readonly NetworkTransport.RemoveHostDelegate RemoveHostDelegateField = IL2CPP.ResolveICall<NetworkTransport.RemoveHostDelegate>("UnityEngine.Networking.NetworkTransport::RemoveHost");

		// Token: 0x0400002B RID: 43
		private static readonly NetworkTransport.IsStartedInternalDelegate IsStartedInternalDelegateField = IL2CPP.ResolveICall<NetworkTransport.IsStartedInternalDelegate>("UnityEngine.Networking.NetworkTransport::IsStartedInternal");

		// Token: 0x0400002C RID: 44
		private static readonly NetworkTransport.ConnectDelegate ConnectDelegateField = IL2CPP.ResolveICall<NetworkTransport.ConnectDelegate>("UnityEngine.Networking.NetworkTransport::Connect");

		// Token: 0x0400002D RID: 45
		private static readonly NetworkTransport.ConnectWithSimulatorInternalDelegate ConnectWithSimulatorInternalDelegateField = IL2CPP.ResolveICall<NetworkTransport.ConnectWithSimulatorInternalDelegate>("UnityEngine.Networking.NetworkTransport::ConnectWithSimulatorInternal");

		// Token: 0x0400002E RID: 46
		private static readonly NetworkTransport.DisconnectDelegate DisconnectDelegateField = IL2CPP.ResolveICall<NetworkTransport.DisconnectDelegate>("UnityEngine.Networking.NetworkTransport::Disconnect");

		// Token: 0x0400002F RID: 47
		private static readonly NetworkTransport.Internal_ConnectEndPointDelegate Internal_ConnectEndPointDelegateField = IL2CPP.ResolveICall<NetworkTransport.Internal_ConnectEndPointDelegate>("UnityEngine.Networking.NetworkTransport::Internal_ConnectEndPoint");

		// Token: 0x04000030 RID: 48
		private static readonly NetworkTransport.SendWrapperDelegate SendWrapperDelegateField = IL2CPP.ResolveICall<NetworkTransport.SendWrapperDelegate>("UnityEngine.Networking.NetworkTransport::SendWrapper");

		// Token: 0x04000031 RID: 49
		private static readonly NetworkTransport.QueueMessageForSendingWrapperDelegate QueueMessageForSendingWrapperDelegateField = IL2CPP.ResolveICall<NetworkTransport.QueueMessageForSendingWrapperDelegate>("UnityEngine.Networking.NetworkTransport::QueueMessageForSendingWrapper");

		// Token: 0x04000032 RID: 50
		private static readonly NetworkTransport.SendQueuedMessagesDelegate SendQueuedMessagesDelegateField = IL2CPP.ResolveICall<NetworkTransport.SendQueuedMessagesDelegate>("UnityEngine.Networking.NetworkTransport::SendQueuedMessages");

		// Token: 0x04000033 RID: 51
		private static readonly NetworkTransport.PopDataDelegate PopDataDelegateField = IL2CPP.ResolveICall<NetworkTransport.PopDataDelegate>("UnityEngine.Networking.NetworkTransport::PopData");

		// Token: 0x04000034 RID: 52
		private static readonly NetworkTransport.PopDataFromHostDelegate PopDataFromHostDelegateField = IL2CPP.ResolveICall<NetworkTransport.PopDataFromHostDelegate>("UnityEngine.Networking.NetworkTransport::PopDataFromHost");

		// Token: 0x04000035 RID: 53
		private static readonly NetworkTransport.SetPacketStatDelegate SetPacketStatDelegateField = IL2CPP.ResolveICall<NetworkTransport.SetPacketStatDelegate>("UnityEngine.Networking.NetworkTransport::SetPacketStat");

		// Token: 0x04000036 RID: 54
		private static readonly NetworkTransport.SetNetworkEventAvailableCallbackDelegate SetNetworkEventAvailableCallbackDelegateField = IL2CPP.ResolveICall<NetworkTransport.SetNetworkEventAvailableCallbackDelegate>("UnityEngine.Networking.NetworkTransport::SetNetworkEventAvailableCallback");

		// Token: 0x04000037 RID: 55
		private static readonly NetworkTransport.CleanupDelegate CleanupDelegateField = IL2CPP.ResolveICall<NetworkTransport.CleanupDelegate>("UnityEngine.Networking.NetworkTransport::Cleanup");

		// Token: 0x04000038 RID: 56
		private static readonly NetworkTransport.NotifyWhenConnectionReadyForSendDelegate NotifyWhenConnectionReadyForSendDelegateField = IL2CPP.ResolveICall<NetworkTransport.NotifyWhenConnectionReadyForSendDelegate>("UnityEngine.Networking.NetworkTransport::NotifyWhenConnectionReadyForSend");

		// Token: 0x04000039 RID: 57
		private static readonly NetworkTransport.GetHostPortDelegate GetHostPortDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetHostPortDelegate>("UnityEngine.Networking.NetworkTransport::GetHostPort");

		// Token: 0x0400003A RID: 58
		private static readonly NetworkTransport.StartBroadcastDiscoveryWithDataDelegate StartBroadcastDiscoveryWithDataDelegateField = IL2CPP.ResolveICall<NetworkTransport.StartBroadcastDiscoveryWithDataDelegate>("UnityEngine.Networking.NetworkTransport::StartBroadcastDiscoveryWithData");

		// Token: 0x0400003B RID: 59
		private static readonly NetworkTransport.StartBroadcastDiscoveryWithoutDataDelegate StartBroadcastDiscoveryWithoutDataDelegateField = IL2CPP.ResolveICall<NetworkTransport.StartBroadcastDiscoveryWithoutDataDelegate>("UnityEngine.Networking.NetworkTransport::StartBroadcastDiscoveryWithoutData");

		// Token: 0x0400003C RID: 60
		private static readonly NetworkTransport.StopBroadcastDiscoveryDelegate StopBroadcastDiscoveryDelegateField = IL2CPP.ResolveICall<NetworkTransport.StopBroadcastDiscoveryDelegate>("UnityEngine.Networking.NetworkTransport::StopBroadcastDiscovery");

		// Token: 0x0400003D RID: 61
		private static readonly NetworkTransport.IsBroadcastDiscoveryRunningDelegate IsBroadcastDiscoveryRunningDelegateField = IL2CPP.ResolveICall<NetworkTransport.IsBroadcastDiscoveryRunningDelegate>("UnityEngine.Networking.NetworkTransport::IsBroadcastDiscoveryRunning");

		// Token: 0x0400003E RID: 62
		private static readonly NetworkTransport.SetBroadcastCredentialsDelegate SetBroadcastCredentialsDelegateField = IL2CPP.ResolveICall<NetworkTransport.SetBroadcastCredentialsDelegate>("UnityEngine.Networking.NetworkTransport::SetBroadcastCredentials");

		// Token: 0x0400003F RID: 63
		private static readonly NetworkTransport.GetBroadcastConnectionInfoDelegate GetBroadcastConnectionInfoDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetBroadcastConnectionInfoDelegate>("UnityEngine.Networking.NetworkTransport::GetBroadcastConnectionInfo");

		// Token: 0x04000040 RID: 64
		private static readonly NetworkTransport.SetMulticastLockDelegate SetMulticastLockDelegateField = IL2CPP.ResolveICall<NetworkTransport.SetMulticastLockDelegate>("UnityEngine.Networking.NetworkTransport::SetMulticastLock");

		// Token: 0x04000041 RID: 65
		private static readonly NetworkTransport.GetBroadcastConnectionMessageInternalDelegate GetBroadcastConnectionMessageInternalDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetBroadcastConnectionMessageInternalDelegate>("UnityEngine.Networking.NetworkTransport::GetBroadcastConnectionMessageInternal");

		// Token: 0x04000042 RID: 66
		private static readonly NetworkTransport.LoadEncryptionLibraryInternalDelegate LoadEncryptionLibraryInternalDelegateField = IL2CPP.ResolveICall<NetworkTransport.LoadEncryptionLibraryInternalDelegate>("UnityEngine.Networking.NetworkTransport::LoadEncryptionLibraryInternal");

		// Token: 0x04000043 RID: 67
		private static readonly NetworkTransport.UnloadEncryptionLibraryInternalDelegate UnloadEncryptionLibraryInternalDelegateField = IL2CPP.ResolveICall<NetworkTransport.UnloadEncryptionLibraryInternalDelegate>("UnityEngine.Networking.NetworkTransport::UnloadEncryptionLibraryInternal");

		// Token: 0x04000044 RID: 68
		private static readonly NetworkTransport.IsEncryptionActiveInternalDelegate IsEncryptionActiveInternalDelegateField = IL2CPP.ResolveICall<NetworkTransport.IsEncryptionActiveInternalDelegate>("UnityEngine.Networking.NetworkTransport::IsEncryptionActiveInternal");

		// Token: 0x04000045 RID: 69
		private static readonly NetworkTransport.GetEncryptionSafeMaxPacketSizeInternalDelegate GetEncryptionSafeMaxPacketSizeInternalDelegateField = IL2CPP.ResolveICall<NetworkTransport.GetEncryptionSafeMaxPacketSizeInternalDelegate>("UnityEngine.Networking.NetworkTransport::GetEncryptionSafeMaxPacketSizeInternal");

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x060001A2 RID: 418
		private delegate void InitializeClassDelegate();

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x060001A4 RID: 420
		private delegate void InitializeClassWithConfigDelegate(IntPtr config);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x060001A6 RID: 422
		private delegate int AddHostInternalDelegate(IntPtr topologyInt, IntPtr ip, int port, int minTimeout, int maxTimeout);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x060001A8 RID: 424
		private delegate int AddWsHostInternalDelegate(IntPtr topologyInt, IntPtr ip, int port);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x060001AA RID: 426
		private delegate void ConnectAsNetworkHostInternalDelegate(int hostId, IntPtr address, int port, ulong network, ulong source, ushort node, [Out] IntPtr error);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x060001AC RID: 428
		private delegate void DisconnectNetworkHostDelegate(int hostId, [Out] IntPtr error);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x060001AE RID: 430
		private delegate int ReceiveRelayEventFromHostInternalDelegate(int hostId, [Out] IntPtr error);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x060001B0 RID: 432
		private delegate int ConnectToNetworkPeerInternalDelegate(int hostId, IntPtr address, int port, int exceptionConnectionId, int relaySlotId, ulong network, ulong source, ushort node, int bytesPerSec, float bucketSizeFactor, [Out] IntPtr error);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x060001B2 RID: 434
		private delegate int GetIncomingMessageQueueSizeDelegate(int hostId, [Out] IntPtr error);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x060001B4 RID: 436
		private delegate int GetOutgoingMessageQueueSizeDelegate(int hostId, [Out] IntPtr error);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x060001B6 RID: 438
		private delegate int GetCurrentRTTDelegate(int hostId, int connectionId, [Out] IntPtr error);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x060001B8 RID: 440
		private delegate int GetIncomingPacketLossCountDelegate(int hostId, int connectionId, [Out] IntPtr error);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x060001BA RID: 442
		private delegate int GetIncomingPacketCountDelegate(int hostId, int connectionId, [Out] IntPtr error);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x060001BC RID: 444
		private delegate int GetOutgoingPacketNetworkLossPercentDelegate(int hostId, int connectionId, [Out] IntPtr error);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x060001BE RID: 446
		private delegate int GetOutgoingPacketOverflowLossPercentDelegate(int hostId, int connectionId, [Out] IntPtr error);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x060001C0 RID: 448
		private delegate int GetMaxAllowedBandwidthDelegate(int hostId, int connectionId, [Out] IntPtr error);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x060001C2 RID: 450
		private delegate int GetAckBufferCountDelegate(int hostId, int connectionId, [Out] IntPtr error);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x060001C4 RID: 452
		private delegate int GetIncomingPacketDropCountForAllHostsDelegate();

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x060001C6 RID: 454
		private delegate int GetIncomingPacketCountForAllHostsDelegate();

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x060001C8 RID: 456
		private delegate int GetOutgoingPacketCountDelegate();

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x060001CA RID: 458
		private delegate int GetOutgoingPacketCountForHostDelegate(int hostId, [Out] IntPtr error);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x060001CC RID: 460
		private delegate int GetOutgoingPacketCountForConnectionDelegate(int hostId, int connectionId, [Out] IntPtr error);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x060001CE RID: 462
		private delegate int GetOutgoingMessageCountDelegate();

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x060001D0 RID: 464
		private delegate int GetOutgoingMessageCountForHostDelegate(int hostId, [Out] IntPtr error);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x060001D2 RID: 466
		private delegate int GetOutgoingMessageCountForConnectionDelegate(int hostId, int connectionId, [Out] IntPtr error);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x060001D4 RID: 468
		private delegate int GetOutgoingUserBytesCountDelegate();

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x060001D6 RID: 470
		private delegate int GetOutgoingUserBytesCountForHostDelegate(int hostId, [Out] IntPtr error);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x060001D8 RID: 472
		private delegate int GetOutgoingUserBytesCountForConnectionDelegate(int hostId, int connectionId, [Out] IntPtr error);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x060001DA RID: 474
		private delegate int GetOutgoingSystemBytesCountDelegate();

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x060001DC RID: 476
		private delegate int GetOutgoingSystemBytesCountForHostDelegate(int hostId, [Out] IntPtr error);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x060001DE RID: 478
		private delegate int GetOutgoingSystemBytesCountForConnectionDelegate(int hostId, int connectionId, [Out] IntPtr error);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x060001E0 RID: 480
		private delegate int GetOutgoingFullBytesCountDelegate();

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x060001E2 RID: 482
		private delegate int GetOutgoingFullBytesCountForHostDelegate(int hostId, [Out] IntPtr error);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x060001E4 RID: 484
		private delegate int GetOutgoingFullBytesCountForConnectionDelegate(int hostId, int connectionId, [Out] IntPtr error);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x060001E6 RID: 486
		private delegate IntPtr GetConnectionInfoDelegate(int hostId, int connectionId, [Out] IntPtr port, [Out] IntPtr network, [Out] IntPtr dstNode, [Out] IntPtr error);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x060001E8 RID: 488
		private delegate int GetNetworkTimestampDelegate();

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x060001EA RID: 490
		private delegate int GetRemoteDelayTimeMSDelegate(int hostId, int connectionId, int remoteTime, [Out] IntPtr error);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x060001EC RID: 492
		private delegate bool StartSendMulticastInternalDelegate(int hostId, int channelId, [Out] IntPtr buffer, int size, [Out] IntPtr error);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x060001EE RID: 494
		private delegate bool SendMulticastDelegate(int hostId, int connectionId, [Out] IntPtr error);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x060001F0 RID: 496
		private delegate bool FinishSendMulticastDelegate(int hostId, [Out] IntPtr error);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x060001F2 RID: 498
		private delegate int GetMaxPacketSizeDelegate();

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x060001F4 RID: 500
		private delegate bool RemoveHostDelegate(int hostId);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x060001F6 RID: 502
		private delegate bool IsStartedInternalDelegate();

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x060001F8 RID: 504
		private delegate int ConnectDelegate(int hostId, IntPtr address, int port, int exeptionConnectionId, [Out] IntPtr error);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x060001FA RID: 506
		private delegate int ConnectWithSimulatorInternalDelegate(int hostId, IntPtr address, int port, int exeptionConnectionId, [Out] IntPtr error, IntPtr conf);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x060001FC RID: 508
		private delegate bool DisconnectDelegate(int hostId, int connectionId, [Out] IntPtr error);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x060001FE RID: 510
		private delegate int Internal_ConnectEndPointDelegate(int hostId, [Out] IntPtr sockAddrStorage, int sockAddrStorageLen, int exceptionConnectionId, [Out] IntPtr error);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x06000200 RID: 512
		private delegate bool SendWrapperDelegate(int hostId, int connectionId, int channelId, [Out] IntPtr buffer, int size, [Out] IntPtr error);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000202 RID: 514
		private delegate bool QueueMessageForSendingWrapperDelegate(int hostId, int connectionId, int channelId, [Out] IntPtr buffer, int size, [Out] IntPtr error);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000204 RID: 516
		private delegate bool SendQueuedMessagesDelegate(int hostId, int connectionId, [Out] IntPtr error);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x06000206 RID: 518
		private delegate int PopDataDelegate([Out] IntPtr hostId, [Out] IntPtr connectionId, [Out] IntPtr channelId, [Out] IntPtr buffer, int bufferSize, [Out] IntPtr receivedSize, [Out] IntPtr error);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x06000208 RID: 520
		private delegate int PopDataFromHostDelegate(int hostId, [Out] IntPtr connectionId, [Out] IntPtr channelId, [Out] IntPtr buffer, int bufferSize, [Out] IntPtr receivedSize, [Out] IntPtr error);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x0600020A RID: 522
		private delegate void SetPacketStatDelegate(int direction, int packetStatId, int numMsgs, int numBytes);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x0600020C RID: 524
		private delegate void SetNetworkEventAvailableCallbackDelegate(IntPtr callback);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x0600020E RID: 526
		private delegate void CleanupDelegate();

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x06000210 RID: 528
		private delegate bool NotifyWhenConnectionReadyForSendDelegate(int hostId, int connectionId, int notificationLevel, [Out] IntPtr error);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x06000212 RID: 530
		private delegate int GetHostPortDelegate(int hostId);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x06000214 RID: 532
		private delegate bool StartBroadcastDiscoveryWithDataDelegate(int hostId, int broadcastPort, int key, int version, int subversion, [Out] IntPtr buffer, int size, int timeout, [Out] IntPtr error);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x06000216 RID: 534
		private delegate bool StartBroadcastDiscoveryWithoutDataDelegate(int hostId, int broadcastPort, int key, int version, int subversion, int timeout, [Out] IntPtr error);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x06000218 RID: 536
		private delegate void StopBroadcastDiscoveryDelegate();

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x0600021A RID: 538
		private delegate bool IsBroadcastDiscoveryRunningDelegate();

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x0600021C RID: 540
		private delegate void SetBroadcastCredentialsDelegate(int hostId, int key, int version, int subversion, [Out] IntPtr error);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x0600021E RID: 542
		private delegate IntPtr GetBroadcastConnectionInfoDelegate(int hostId, [Out] IntPtr port, [Out] IntPtr error);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x06000220 RID: 544
		private delegate void SetMulticastLockDelegate(bool enabled);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x06000222 RID: 546
		private delegate void GetBroadcastConnectionMessageInternalDelegate(int hostId, [Out] IntPtr buffer, int bufferSize, [Out] IntPtr receivedSize, [Out] IntPtr error);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x06000224 RID: 548
		private delegate bool LoadEncryptionLibraryInternalDelegate(IntPtr libraryName);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x06000226 RID: 550
		private delegate void UnloadEncryptionLibraryInternalDelegate();

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x06000228 RID: 552
		private delegate bool IsEncryptionActiveInternalDelegate();

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x0600022A RID: 554
		private delegate short GetEncryptionSafeMaxPacketSizeInternalDelegate(short maxPacketSize);
	}
}

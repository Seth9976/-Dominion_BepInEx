using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000164 RID: 356
	public static class SteamNetworkingSockets : Object
	{
		// Token: 0x06001BA4 RID: 7076 RVA: 0x0007E46C File Offset: 0x0007C66C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamNetworkingSockets()
		{
			Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamNetworkingSockets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr);
			SteamNetworkingSockets.NativeMethodInfoPtr_CreateListenSocketIP_Public_Static_HSteamListenSocket_byref_SteamNetworkingIPAddr_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667064);
			SteamNetworkingSockets.NativeMethodInfoPtr_ConnectByIPAddress_Public_Static_HSteamNetConnection_byref_SteamNetworkingIPAddr_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667065);
			SteamNetworkingSockets.NativeMethodInfoPtr_CreateListenSocketP2P_Public_Static_HSteamListenSocket_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667066);
			SteamNetworkingSockets.NativeMethodInfoPtr_ConnectP2P_Public_Static_HSteamNetConnection_byref_SteamNetworkingIdentity_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667067);
			SteamNetworkingSockets.NativeMethodInfoPtr_AcceptConnection_Public_Static_EResult_HSteamNetConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667068);
			SteamNetworkingSockets.NativeMethodInfoPtr_CloseConnection_Public_Static_Boolean_HSteamNetConnection_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667069);
			SteamNetworkingSockets.NativeMethodInfoPtr_CloseListenSocket_Public_Static_Boolean_HSteamListenSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667070);
			SteamNetworkingSockets.NativeMethodInfoPtr_SetConnectionUserData_Public_Static_Boolean_HSteamNetConnection_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667071);
			SteamNetworkingSockets.NativeMethodInfoPtr_GetConnectionUserData_Public_Static_Int64_HSteamNetConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667072);
			SteamNetworkingSockets.NativeMethodInfoPtr_SetConnectionName_Public_Static_Void_HSteamNetConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667073);
			SteamNetworkingSockets.NativeMethodInfoPtr_GetConnectionName_Public_Static_Boolean_HSteamNetConnection_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667074);
			SteamNetworkingSockets.NativeMethodInfoPtr_SendMessageToConnection_Public_Static_EResult_HSteamNetConnection_IntPtr_UInt32_Int32_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667075);
			SteamNetworkingSockets.NativeMethodInfoPtr_SendMessages_Public_Static_Void_Int32_Il2CppReferenceArray_1_SteamNetworkingMessage_t_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667076);
			SteamNetworkingSockets.NativeMethodInfoPtr_FlushMessagesOnConnection_Public_Static_EResult_HSteamNetConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667077);
			SteamNetworkingSockets.NativeMethodInfoPtr_ReceiveMessagesOnConnection_Public_Static_Int32_HSteamNetConnection_Il2CppStructArray_1_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667078);
			SteamNetworkingSockets.NativeMethodInfoPtr_GetConnectionInfo_Public_Static_Boolean_HSteamNetConnection_byref_SteamNetConnectionInfo_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667079);
			SteamNetworkingSockets.NativeMethodInfoPtr_GetQuickConnectionStatus_Public_Static_Boolean_HSteamNetConnection_byref_SteamNetworkingQuickConnectionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667080);
			SteamNetworkingSockets.NativeMethodInfoPtr_GetDetailedConnectionStatus_Public_Static_Int32_HSteamNetConnection_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667081);
			SteamNetworkingSockets.NativeMethodInfoPtr_GetListenSocketAddress_Public_Static_Boolean_HSteamListenSocket_byref_SteamNetworkingIPAddr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667082);
			SteamNetworkingSockets.NativeMethodInfoPtr_CreateSocketPair_Public_Static_Boolean_byref_HSteamNetConnection_byref_HSteamNetConnection_Boolean_byref_SteamNetworkingIdentity_byref_SteamNetworkingIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667083);
			SteamNetworkingSockets.NativeMethodInfoPtr_GetIdentity_Public_Static_Boolean_byref_SteamNetworkingIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667084);
			SteamNetworkingSockets.NativeMethodInfoPtr_InitAuthentication_Public_Static_ESteamNetworkingAvailability_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667085);
			SteamNetworkingSockets.NativeMethodInfoPtr_GetAuthenticationStatus_Public_Static_ESteamNetworkingAvailability_byref_SteamNetAuthenticationStatus_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667086);
			SteamNetworkingSockets.NativeMethodInfoPtr_CreatePollGroup_Public_Static_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667087);
			SteamNetworkingSockets.NativeMethodInfoPtr_DestroyPollGroup_Public_Static_Boolean_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667088);
			SteamNetworkingSockets.NativeMethodInfoPtr_SetConnectionPollGroup_Public_Static_Boolean_HSteamNetConnection_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667089);
			SteamNetworkingSockets.NativeMethodInfoPtr_ReceiveMessagesOnPollGroup_Public_Static_Int32_HSteamNetPollGroup_Il2CppStructArray_1_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667090);
			SteamNetworkingSockets.NativeMethodInfoPtr_ReceivedRelayAuthTicket_Public_Static_Boolean_IntPtr_Int32_byref_SteamDatagramRelayAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667091);
			SteamNetworkingSockets.NativeMethodInfoPtr_FindRelayAuthTicketForServer_Public_Static_Int32_byref_SteamNetworkingIdentity_Int32_byref_SteamDatagramRelayAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667092);
			SteamNetworkingSockets.NativeMethodInfoPtr_ConnectToHostedDedicatedServer_Public_Static_HSteamNetConnection_byref_SteamNetworkingIdentity_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667093);
			SteamNetworkingSockets.NativeMethodInfoPtr_GetHostedDedicatedServerPort_Public_Static_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667094);
			SteamNetworkingSockets.NativeMethodInfoPtr_GetHostedDedicatedServerPOPID_Public_Static_SteamNetworkingPOPID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667095);
			SteamNetworkingSockets.NativeMethodInfoPtr_GetHostedDedicatedServerAddress_Public_Static_EResult_byref_SteamDatagramHostedAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667096);
			SteamNetworkingSockets.NativeMethodInfoPtr_CreateHostedDedicatedServerListenSocket_Public_Static_HSteamListenSocket_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667097);
			SteamNetworkingSockets.NativeMethodInfoPtr_GetGameCoordinatorServerLogin_Public_Static_EResult_byref_SteamDatagramGameCoordinatorServerLogin_byref_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667098);
			SteamNetworkingSockets.NativeMethodInfoPtr_ConnectP2PCustomSignaling_Public_Static_HSteamNetConnection_byref_ISteamNetworkingConnectionCustomSignaling_byref_SteamNetworkingIdentity_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667099);
			SteamNetworkingSockets.NativeMethodInfoPtr_ReceivedP2PCustomSignal_Public_Static_Boolean_IntPtr_Int32_byref_ISteamNetworkingCustomSignalingRecvContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667100);
			SteamNetworkingSockets.NativeMethodInfoPtr_GetCertificateRequest_Public_Static_Boolean_byref_Int32_IntPtr_byref_SteamNetworkingErrMsg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667101);
			SteamNetworkingSockets.NativeMethodInfoPtr_SetCertificate_Public_Static_Boolean_IntPtr_Int32_byref_SteamNetworkingErrMsg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667102);
			SteamNetworkingSockets.NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamNetworkingSockets>.NativeClassPtr, 100667103);
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x0007E7BC File Offset: 0x0007C9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200703, XrefRangeEnd = 200711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamListenSocket CreateListenSocketIP(ref SteamNetworkingIPAddr localAddress, int nOptions, Il2CppStructArray<SteamNetworkingConfigValue_t> pOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(localAddress);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_CreateListenSocketIP_Public_Static_HSteamListenSocket_byref_SteamNetworkingIPAddr_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0007E820 File Offset: 0x0007CA20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200711, XrefRangeEnd = 200719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamNetConnection ConnectByIPAddress(ref SteamNetworkingIPAddr address, int nOptions, Il2CppStructArray<SteamNetworkingConfigValue_t> pOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(address);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_ConnectByIPAddress_Public_Static_HSteamNetConnection_byref_SteamNetworkingIPAddr_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0007E884 File Offset: 0x0007CA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200719, XrefRangeEnd = 200727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamListenSocket CreateListenSocketP2P(int nLocalVirtualPort, int nOptions, Il2CppStructArray<SteamNetworkingConfigValue_t> pOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nLocalVirtualPort;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_CreateListenSocketP2P_Public_Static_HSteamListenSocket_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x0007E8E4 File Offset: 0x0007CAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200727, XrefRangeEnd = 200735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamNetConnection ConnectP2P(ref SteamNetworkingIdentity identityRemote, int nRemoteVirtualPort, int nOptions, Il2CppStructArray<SteamNetworkingConfigValue_t> pOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(identityRemote);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRemoteVirtualPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_ConnectP2P_Public_Static_HSteamNetConnection_byref_SteamNetworkingIdentity_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0007E954 File Offset: 0x0007CB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200735, XrefRangeEnd = 200739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EResult AcceptConnection(HSteamNetConnection hConn)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_AcceptConnection_Public_Static_EResult_HSteamNetConnection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x0007E994 File Offset: 0x0007CB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200739, XrefRangeEnd = 200751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CloseConnection(HSteamNetConnection hPeer, int nReason, string pszDebug, bool bEnableLinger)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hPeer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nReason;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszDebug);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnableLinger;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_CloseConnection_Public_Static_Boolean_HSteamNetConnection_Int32_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x0007EA00 File Offset: 0x0007CC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200751, XrefRangeEnd = 200755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CloseListenSocket(HSteamListenSocket hSocket)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSocket;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_CloseListenSocket_Public_Static_Boolean_HSteamListenSocket_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0007EA40 File Offset: 0x0007CC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200755, XrefRangeEnd = 200759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetConnectionUserData(HSteamNetConnection hPeer, long nUserData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hPeer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nUserData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_SetConnectionUserData_Public_Static_Boolean_HSteamNetConnection_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0007EA8C File Offset: 0x0007CC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200759, XrefRangeEnd = 200763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetConnectionUserData(HSteamNetConnection hPeer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hPeer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_GetConnectionUserData_Public_Static_Int64_HSteamNetConnection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x0007EACC File Offset: 0x0007CCCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200763, XrefRangeEnd = 200775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetConnectionName(HSteamNetConnection hPeer, string pszName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hPeer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pszName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_SetConnectionName_Public_Static_Void_HSteamNetConnection_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x0007EB10 File Offset: 0x0007CD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200775, XrefRangeEnd = 200787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetConnectionName(HSteamNetConnection hPeer, out string pszName, int nMaxLen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hPeer;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxLen;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_GetConnectionName_Public_Static_Boolean_HSteamNetConnection_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pszName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x0007EB78 File Offset: 0x0007CD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200787, XrefRangeEnd = 200791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EResult SendMessageToConnection(HSteamNetConnection hConn, IntPtr pData, uint cbData, int nSendFlags, out long pOutMessageNumber)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbData;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nSendFlags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pOutMessageNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_SendMessageToConnection_Public_Static_EResult_HSteamNetConnection_IntPtr_UInt32_Int32_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0007EBF0 File Offset: 0x0007CDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200791, XrefRangeEnd = 200795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendMessages(int nMessages, Il2CppReferenceArray<SteamNetworkingMessage_t> pMessages, Il2CppStructArray<long> pOutMessageNumberOrResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nMessages;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pMessages);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pOutMessageNumberOrResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_SendMessages_Public_Static_Void_Int32_Il2CppReferenceArray_1_SteamNetworkingMessage_t_Il2CppStructArray_1_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x0007EC48 File Offset: 0x0007CE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200795, XrefRangeEnd = 200799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EResult FlushMessagesOnConnection(HSteamNetConnection hConn)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_FlushMessagesOnConnection_Public_Static_EResult_HSteamNetConnection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0007EC88 File Offset: 0x0007CE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200799, XrefRangeEnd = 200803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReceiveMessagesOnConnection(HSteamNetConnection hConn, Il2CppStructArray<IntPtr> ppOutMessages, int nMaxMessages)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ppOutMessages);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxMessages;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_ReceiveMessagesOnConnection_Public_Static_Int32_HSteamNetConnection_Il2CppStructArray_1_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0007ECE8 File Offset: 0x0007CEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200803, XrefRangeEnd = 200807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetConnectionInfo(HSteamNetConnection hConn, out SteamNetConnectionInfo_t pInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_GetConnectionInfo_Public_Static_Boolean_HSteamNetConnection_byref_SteamNetConnectionInfo_t_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pInfo = ((intPtr4 == 0) ? null : new SteamNetConnectionInfo_t(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x0007ED48 File Offset: 0x0007CF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200807, XrefRangeEnd = 200811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetQuickConnectionStatus(HSteamNetConnection hConn, out SteamNetworkingQuickConnectionStatus pStats)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_GetQuickConnectionStatus_Public_Static_Boolean_HSteamNetConnection_byref_SteamNetworkingQuickConnectionStatus_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pStats = ((intPtr4 == 0) ? null : new SteamNetworkingQuickConnectionStatus(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x0007EDA8 File Offset: 0x0007CFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200811, XrefRangeEnd = 200823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetDetailedConnectionStatus(HSteamNetConnection hConn, out string pszBuf, int cbBuf)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbBuf;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_GetDetailedConnectionStatus_Public_Static_Int32_HSteamNetConnection_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pszBuf = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x0007EE10 File Offset: 0x0007D010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200823, XrefRangeEnd = 200827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetListenSocketAddress(HSteamListenSocket hSocket, out SteamNetworkingIPAddr address)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSocket;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_GetListenSocketAddress_Public_Static_Boolean_HSteamListenSocket_byref_SteamNetworkingIPAddr_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			address = ((intPtr4 == 0) ? null : new SteamNetworkingIPAddr(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x0007EE70 File Offset: 0x0007D070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200827, XrefRangeEnd = 200831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CreateSocketPair(out HSteamNetConnection pOutConnection1, out HSteamNetConnection pOutConnection2, bool bUseNetworkLoopback, ref SteamNetworkingIdentity pIdentity1, ref SteamNetworkingIdentity pIdentity2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pOutConnection1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pOutConnection2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bUseNetworkLoopback;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pIdentity1);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pIdentity2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_CreateSocketPair_Public_Static_Boolean_byref_HSteamNetConnection_byref_HSteamNetConnection_Boolean_byref_SteamNetworkingIdentity_byref_SteamNetworkingIdentity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x0007EEF0 File Offset: 0x0007D0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200831, XrefRangeEnd = 200835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetIdentity(out SteamNetworkingIdentity pIdentity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_GetIdentity_Public_Static_Boolean_byref_SteamNetworkingIdentity_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pIdentity = ((intPtr4 == 0) ? null : new SteamNetworkingIdentity(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x0007EF44 File Offset: 0x0007D144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200835, XrefRangeEnd = 200839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESteamNetworkingAvailability InitAuthentication()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_InitAuthentication_Public_Static_ESteamNetworkingAvailability_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x0007EF74 File Offset: 0x0007D174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200839, XrefRangeEnd = 200843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESteamNetworkingAvailability GetAuthenticationStatus(out SteamNetAuthenticationStatus_t pDetails)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_GetAuthenticationStatus_Public_Static_ESteamNetworkingAvailability_byref_SteamNetAuthenticationStatus_t_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pDetails = ((intPtr4 == 0) ? null : new SteamNetAuthenticationStatus_t(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x0007EFC8 File Offset: 0x0007D1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200843, XrefRangeEnd = 200851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamNetPollGroup CreatePollGroup()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_CreatePollGroup_Public_Static_HSteamNetPollGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x0007EFF8 File Offset: 0x0007D1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200851, XrefRangeEnd = 200855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DestroyPollGroup(HSteamNetPollGroup hPollGroup)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hPollGroup;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_DestroyPollGroup_Public_Static_Boolean_HSteamNetPollGroup_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x0007F038 File Offset: 0x0007D238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200855, XrefRangeEnd = 200859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetConnectionPollGroup(HSteamNetConnection hConn, HSteamNetPollGroup hPollGroup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hPollGroup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_SetConnectionPollGroup_Public_Static_Boolean_HSteamNetConnection_HSteamNetPollGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x0007F084 File Offset: 0x0007D284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200859, XrefRangeEnd = 200863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReceiveMessagesOnPollGroup(HSteamNetPollGroup hPollGroup, Il2CppStructArray<IntPtr> ppOutMessages, int nMaxMessages)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hPollGroup;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ppOutMessages);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxMessages;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_ReceiveMessagesOnPollGroup_Public_Static_Int32_HSteamNetPollGroup_Il2CppStructArray_1_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x0007F0E4 File Offset: 0x0007D2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200863, XrefRangeEnd = 200867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReceivedRelayAuthTicket(IntPtr pvTicket, int cbTicket, out SteamDatagramRelayAuthTicket pOutParsedTicket)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pvTicket;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbTicket;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_ReceivedRelayAuthTicket_Public_Static_Boolean_IntPtr_Int32_byref_SteamDatagramRelayAuthTicket_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pOutParsedTicket = ((intPtr4 == 0) ? null : new SteamDatagramRelayAuthTicket(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x0007F154 File Offset: 0x0007D354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200867, XrefRangeEnd = 200871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindRelayAuthTicketForServer(ref SteamNetworkingIdentity identityGameServer, int nRemoteVirtualPort, out SteamDatagramRelayAuthTicket pOutParsedTicket)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(identityGameServer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRemoteVirtualPort;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_FindRelayAuthTicketForServer_Public_Static_Int32_byref_SteamNetworkingIdentity_Int32_byref_SteamDatagramRelayAuthTicket_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pOutParsedTicket = ((intPtr4 == 0) ? null : new SteamDatagramRelayAuthTicket(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x0007F1C8 File Offset: 0x0007D3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200871, XrefRangeEnd = 200879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamNetConnection ConnectToHostedDedicatedServer(ref SteamNetworkingIdentity identityTarget, int nRemoteVirtualPort, int nOptions, Il2CppStructArray<SteamNetworkingConfigValue_t> pOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(identityTarget);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRemoteVirtualPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_ConnectToHostedDedicatedServer_Public_Static_HSteamNetConnection_byref_SteamNetworkingIdentity_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x0007F238 File Offset: 0x0007D438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200879, XrefRangeEnd = 200883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort GetHostedDedicatedServerPort()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_GetHostedDedicatedServerPort_Public_Static_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x0007F268 File Offset: 0x0007D468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200883, XrefRangeEnd = 200887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamNetworkingPOPID GetHostedDedicatedServerPOPID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_GetHostedDedicatedServerPOPID_Public_Static_SteamNetworkingPOPID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x0007F298 File Offset: 0x0007D498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200887, XrefRangeEnd = 200891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EResult GetHostedDedicatedServerAddress(out SteamDatagramHostedAddress pRouting)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_GetHostedDedicatedServerAddress_Public_Static_EResult_byref_SteamDatagramHostedAddress_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pRouting = ((intPtr4 == 0) ? null : new SteamDatagramHostedAddress(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x0007F2EC File Offset: 0x0007D4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200891, XrefRangeEnd = 200899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamListenSocket CreateHostedDedicatedServerListenSocket(int nLocalVirtualPort, int nOptions, Il2CppStructArray<SteamNetworkingConfigValue_t> pOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nLocalVirtualPort;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_CreateHostedDedicatedServerListenSocket_Public_Static_HSteamListenSocket_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x0007F34C File Offset: 0x0007D54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200899, XrefRangeEnd = 200903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EResult GetGameCoordinatorServerLogin(out SteamDatagramGameCoordinatorServerLogin pLoginInfo, out int pcbSignedBlob, IntPtr pBlob)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcbSignedBlob;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pBlob;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_GetGameCoordinatorServerLogin_Public_Static_EResult_byref_SteamDatagramGameCoordinatorServerLogin_byref_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pLoginInfo = ((intPtr4 == 0) ? null : new SteamDatagramGameCoordinatorServerLogin(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x0007F3BC File Offset: 0x0007D5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200903, XrefRangeEnd = 200911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamNetConnection ConnectP2PCustomSignaling(out ISteamNetworkingConnectionCustomSignaling pSignaling, ref SteamNetworkingIdentity pPeerIdentity, int nRemoteVirtualPort, int nOptions, Il2CppStructArray<SteamNetworkingConfigValue_t> pOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pSignaling;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(pPeerIdentity);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRemoteVirtualPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_ConnectP2PCustomSignaling_Public_Static_HSteamNetConnection_byref_ISteamNetworkingConnectionCustomSignaling_byref_SteamNetworkingIdentity_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x0007F43C File Offset: 0x0007D63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200911, XrefRangeEnd = 200915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReceivedP2PCustomSignal(IntPtr pMsg, int cbMsg, out ISteamNetworkingCustomSignalingRecvContext pContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pMsg;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbMsg;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_ReceivedP2PCustomSignal_Public_Static_Boolean_IntPtr_Int32_byref_ISteamNetworkingCustomSignalingRecvContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x0007F498 File Offset: 0x0007D698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200915, XrefRangeEnd = 200919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetCertificateRequest(out int pcbBlob, IntPtr pBlob, out SteamNetworkingErrMsg errMsg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pcbBlob;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pBlob;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_GetCertificateRequest_Public_Static_Boolean_byref_Int32_IntPtr_byref_SteamNetworkingErrMsg_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			errMsg = ((intPtr4 == 0) ? null : new SteamNetworkingErrMsg(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0007F508 File Offset: 0x0007D708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200919, XrefRangeEnd = 200923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetCertificate(IntPtr pCertificate, int cbCertificate, out SteamNetworkingErrMsg errMsg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pCertificate;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbCertificate;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_SetCertificate_Public_Static_Boolean_IntPtr_Int32_byref_SteamNetworkingErrMsg_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			errMsg = ((intPtr4 == 0) ? null : new SteamNetworkingErrMsg(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0007F578 File Offset: 0x0007D778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200923, XrefRangeEnd = 200927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunCallbacks()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamNetworkingSockets.NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x0000BAE4 File Offset: 0x00009CE4
		public SteamNetworkingSockets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001584 RID: 5508
		private static readonly IntPtr NativeMethodInfoPtr_CreateListenSocketIP_Public_Static_HSteamListenSocket_byref_SteamNetworkingIPAddr_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0;

		// Token: 0x04001585 RID: 5509
		private static readonly IntPtr NativeMethodInfoPtr_ConnectByIPAddress_Public_Static_HSteamNetConnection_byref_SteamNetworkingIPAddr_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0;

		// Token: 0x04001586 RID: 5510
		private static readonly IntPtr NativeMethodInfoPtr_CreateListenSocketP2P_Public_Static_HSteamListenSocket_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0;

		// Token: 0x04001587 RID: 5511
		private static readonly IntPtr NativeMethodInfoPtr_ConnectP2P_Public_Static_HSteamNetConnection_byref_SteamNetworkingIdentity_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0;

		// Token: 0x04001588 RID: 5512
		private static readonly IntPtr NativeMethodInfoPtr_AcceptConnection_Public_Static_EResult_HSteamNetConnection_0;

		// Token: 0x04001589 RID: 5513
		private static readonly IntPtr NativeMethodInfoPtr_CloseConnection_Public_Static_Boolean_HSteamNetConnection_Int32_String_Boolean_0;

		// Token: 0x0400158A RID: 5514
		private static readonly IntPtr NativeMethodInfoPtr_CloseListenSocket_Public_Static_Boolean_HSteamListenSocket_0;

		// Token: 0x0400158B RID: 5515
		private static readonly IntPtr NativeMethodInfoPtr_SetConnectionUserData_Public_Static_Boolean_HSteamNetConnection_Int64_0;

		// Token: 0x0400158C RID: 5516
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionUserData_Public_Static_Int64_HSteamNetConnection_0;

		// Token: 0x0400158D RID: 5517
		private static readonly IntPtr NativeMethodInfoPtr_SetConnectionName_Public_Static_Void_HSteamNetConnection_String_0;

		// Token: 0x0400158E RID: 5518
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionName_Public_Static_Boolean_HSteamNetConnection_byref_String_Int32_0;

		// Token: 0x0400158F RID: 5519
		private static readonly IntPtr NativeMethodInfoPtr_SendMessageToConnection_Public_Static_EResult_HSteamNetConnection_IntPtr_UInt32_Int32_byref_Int64_0;

		// Token: 0x04001590 RID: 5520
		private static readonly IntPtr NativeMethodInfoPtr_SendMessages_Public_Static_Void_Int32_Il2CppReferenceArray_1_SteamNetworkingMessage_t_Il2CppStructArray_1_Int64_0;

		// Token: 0x04001591 RID: 5521
		private static readonly IntPtr NativeMethodInfoPtr_FlushMessagesOnConnection_Public_Static_EResult_HSteamNetConnection_0;

		// Token: 0x04001592 RID: 5522
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessagesOnConnection_Public_Static_Int32_HSteamNetConnection_Il2CppStructArray_1_IntPtr_Int32_0;

		// Token: 0x04001593 RID: 5523
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionInfo_Public_Static_Boolean_HSteamNetConnection_byref_SteamNetConnectionInfo_t_0;

		// Token: 0x04001594 RID: 5524
		private static readonly IntPtr NativeMethodInfoPtr_GetQuickConnectionStatus_Public_Static_Boolean_HSteamNetConnection_byref_SteamNetworkingQuickConnectionStatus_0;

		// Token: 0x04001595 RID: 5525
		private static readonly IntPtr NativeMethodInfoPtr_GetDetailedConnectionStatus_Public_Static_Int32_HSteamNetConnection_byref_String_Int32_0;

		// Token: 0x04001596 RID: 5526
		private static readonly IntPtr NativeMethodInfoPtr_GetListenSocketAddress_Public_Static_Boolean_HSteamListenSocket_byref_SteamNetworkingIPAddr_0;

		// Token: 0x04001597 RID: 5527
		private static readonly IntPtr NativeMethodInfoPtr_CreateSocketPair_Public_Static_Boolean_byref_HSteamNetConnection_byref_HSteamNetConnection_Boolean_byref_SteamNetworkingIdentity_byref_SteamNetworkingIdentity_0;

		// Token: 0x04001598 RID: 5528
		private static readonly IntPtr NativeMethodInfoPtr_GetIdentity_Public_Static_Boolean_byref_SteamNetworkingIdentity_0;

		// Token: 0x04001599 RID: 5529
		private static readonly IntPtr NativeMethodInfoPtr_InitAuthentication_Public_Static_ESteamNetworkingAvailability_0;

		// Token: 0x0400159A RID: 5530
		private static readonly IntPtr NativeMethodInfoPtr_GetAuthenticationStatus_Public_Static_ESteamNetworkingAvailability_byref_SteamNetAuthenticationStatus_t_0;

		// Token: 0x0400159B RID: 5531
		private static readonly IntPtr NativeMethodInfoPtr_CreatePollGroup_Public_Static_HSteamNetPollGroup_0;

		// Token: 0x0400159C RID: 5532
		private static readonly IntPtr NativeMethodInfoPtr_DestroyPollGroup_Public_Static_Boolean_HSteamNetPollGroup_0;

		// Token: 0x0400159D RID: 5533
		private static readonly IntPtr NativeMethodInfoPtr_SetConnectionPollGroup_Public_Static_Boolean_HSteamNetConnection_HSteamNetPollGroup_0;

		// Token: 0x0400159E RID: 5534
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessagesOnPollGroup_Public_Static_Int32_HSteamNetPollGroup_Il2CppStructArray_1_IntPtr_Int32_0;

		// Token: 0x0400159F RID: 5535
		private static readonly IntPtr NativeMethodInfoPtr_ReceivedRelayAuthTicket_Public_Static_Boolean_IntPtr_Int32_byref_SteamDatagramRelayAuthTicket_0;

		// Token: 0x040015A0 RID: 5536
		private static readonly IntPtr NativeMethodInfoPtr_FindRelayAuthTicketForServer_Public_Static_Int32_byref_SteamNetworkingIdentity_Int32_byref_SteamDatagramRelayAuthTicket_0;

		// Token: 0x040015A1 RID: 5537
		private static readonly IntPtr NativeMethodInfoPtr_ConnectToHostedDedicatedServer_Public_Static_HSteamNetConnection_byref_SteamNetworkingIdentity_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0;

		// Token: 0x040015A2 RID: 5538
		private static readonly IntPtr NativeMethodInfoPtr_GetHostedDedicatedServerPort_Public_Static_UInt16_0;

		// Token: 0x040015A3 RID: 5539
		private static readonly IntPtr NativeMethodInfoPtr_GetHostedDedicatedServerPOPID_Public_Static_SteamNetworkingPOPID_0;

		// Token: 0x040015A4 RID: 5540
		private static readonly IntPtr NativeMethodInfoPtr_GetHostedDedicatedServerAddress_Public_Static_EResult_byref_SteamDatagramHostedAddress_0;

		// Token: 0x040015A5 RID: 5541
		private static readonly IntPtr NativeMethodInfoPtr_CreateHostedDedicatedServerListenSocket_Public_Static_HSteamListenSocket_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0;

		// Token: 0x040015A6 RID: 5542
		private static readonly IntPtr NativeMethodInfoPtr_GetGameCoordinatorServerLogin_Public_Static_EResult_byref_SteamDatagramGameCoordinatorServerLogin_byref_Int32_IntPtr_0;

		// Token: 0x040015A7 RID: 5543
		private static readonly IntPtr NativeMethodInfoPtr_ConnectP2PCustomSignaling_Public_Static_HSteamNetConnection_byref_ISteamNetworkingConnectionCustomSignaling_byref_SteamNetworkingIdentity_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0;

		// Token: 0x040015A8 RID: 5544
		private static readonly IntPtr NativeMethodInfoPtr_ReceivedP2PCustomSignal_Public_Static_Boolean_IntPtr_Int32_byref_ISteamNetworkingCustomSignalingRecvContext_0;

		// Token: 0x040015A9 RID: 5545
		private static readonly IntPtr NativeMethodInfoPtr_GetCertificateRequest_Public_Static_Boolean_byref_Int32_IntPtr_byref_SteamNetworkingErrMsg_0;

		// Token: 0x040015AA RID: 5546
		private static readonly IntPtr NativeMethodInfoPtr_SetCertificate_Public_Static_Boolean_IntPtr_Int32_byref_SteamNetworkingErrMsg_0;

		// Token: 0x040015AB RID: 5547
		private static readonly IntPtr NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000153 RID: 339
	public static class SteamGameServerNetworkingSockets : Object
	{
		// Token: 0x060019AD RID: 6573 RVA: 0x00072C2C File Offset: 0x00070E2C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamGameServerNetworkingSockets()
		{
			Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamGameServerNetworkingSockets");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_CreateListenSocketIP_Public_Static_HSteamListenSocket_byref_SteamNetworkingIPAddr_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666595);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_ConnectByIPAddress_Public_Static_HSteamNetConnection_byref_SteamNetworkingIPAddr_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666596);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_CreateListenSocketP2P_Public_Static_HSteamListenSocket_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666597);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_ConnectP2P_Public_Static_HSteamNetConnection_byref_SteamNetworkingIdentity_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666598);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_AcceptConnection_Public_Static_EResult_HSteamNetConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666599);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_CloseConnection_Public_Static_Boolean_HSteamNetConnection_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666600);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_CloseListenSocket_Public_Static_Boolean_HSteamListenSocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666601);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_SetConnectionUserData_Public_Static_Boolean_HSteamNetConnection_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666602);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetConnectionUserData_Public_Static_Int64_HSteamNetConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666603);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_SetConnectionName_Public_Static_Void_HSteamNetConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666604);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetConnectionName_Public_Static_Boolean_HSteamNetConnection_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666605);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_SendMessageToConnection_Public_Static_EResult_HSteamNetConnection_IntPtr_UInt32_Int32_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666606);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_SendMessages_Public_Static_Void_Int32_Il2CppReferenceArray_1_SteamNetworkingMessage_t_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666607);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_FlushMessagesOnConnection_Public_Static_EResult_HSteamNetConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666608);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_ReceiveMessagesOnConnection_Public_Static_Int32_HSteamNetConnection_Il2CppStructArray_1_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666609);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetConnectionInfo_Public_Static_Boolean_HSteamNetConnection_byref_SteamNetConnectionInfo_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666610);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetQuickConnectionStatus_Public_Static_Boolean_HSteamNetConnection_byref_SteamNetworkingQuickConnectionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666611);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetDetailedConnectionStatus_Public_Static_Int32_HSteamNetConnection_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666612);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetListenSocketAddress_Public_Static_Boolean_HSteamListenSocket_byref_SteamNetworkingIPAddr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666613);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_CreateSocketPair_Public_Static_Boolean_byref_HSteamNetConnection_byref_HSteamNetConnection_Boolean_byref_SteamNetworkingIdentity_byref_SteamNetworkingIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666614);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetIdentity_Public_Static_Boolean_byref_SteamNetworkingIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666615);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_InitAuthentication_Public_Static_ESteamNetworkingAvailability_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666616);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetAuthenticationStatus_Public_Static_ESteamNetworkingAvailability_byref_SteamNetAuthenticationStatus_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666617);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_CreatePollGroup_Public_Static_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666618);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_DestroyPollGroup_Public_Static_Boolean_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666619);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_SetConnectionPollGroup_Public_Static_Boolean_HSteamNetConnection_HSteamNetPollGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666620);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_ReceiveMessagesOnPollGroup_Public_Static_Int32_HSteamNetPollGroup_Il2CppStructArray_1_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666621);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_ReceivedRelayAuthTicket_Public_Static_Boolean_IntPtr_Int32_byref_SteamDatagramRelayAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666622);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_FindRelayAuthTicketForServer_Public_Static_Int32_byref_SteamNetworkingIdentity_Int32_byref_SteamDatagramRelayAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666623);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_ConnectToHostedDedicatedServer_Public_Static_HSteamNetConnection_byref_SteamNetworkingIdentity_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666624);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetHostedDedicatedServerPort_Public_Static_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666625);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetHostedDedicatedServerPOPID_Public_Static_SteamNetworkingPOPID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666626);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetHostedDedicatedServerAddress_Public_Static_EResult_byref_SteamDatagramHostedAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666627);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_CreateHostedDedicatedServerListenSocket_Public_Static_HSteamListenSocket_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666628);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetGameCoordinatorServerLogin_Public_Static_EResult_byref_SteamDatagramGameCoordinatorServerLogin_byref_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666629);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_ConnectP2PCustomSignaling_Public_Static_HSteamNetConnection_byref_ISteamNetworkingConnectionCustomSignaling_byref_SteamNetworkingIdentity_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666630);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_ReceivedP2PCustomSignal_Public_Static_Boolean_IntPtr_Int32_byref_ISteamNetworkingCustomSignalingRecvContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666631);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetCertificateRequest_Public_Static_Boolean_byref_Int32_IntPtr_byref_SteamNetworkingErrMsg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666632);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_SetCertificate_Public_Static_Boolean_IntPtr_Int32_byref_SteamNetworkingErrMsg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666633);
			SteamGameServerNetworkingSockets.NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerNetworkingSockets>.NativeClassPtr, 100666634);
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x00072F7C File Offset: 0x0007117C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197540, XrefRangeEnd = 197548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_CreateListenSocketIP_Public_Static_HSteamListenSocket_byref_SteamNetworkingIPAddr_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00072FE0 File Offset: 0x000711E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197548, XrefRangeEnd = 197556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_ConnectByIPAddress_Public_Static_HSteamNetConnection_byref_SteamNetworkingIPAddr_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00073044 File Offset: 0x00071244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197556, XrefRangeEnd = 197564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_CreateListenSocketP2P_Public_Static_HSteamListenSocket_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x000730A4 File Offset: 0x000712A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197564, XrefRangeEnd = 197572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_ConnectP2P_Public_Static_HSteamNetConnection_byref_SteamNetworkingIdentity_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00073114 File Offset: 0x00071314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197572, XrefRangeEnd = 197576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EResult AcceptConnection(HSteamNetConnection hConn)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_AcceptConnection_Public_Static_EResult_HSteamNetConnection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x00073154 File Offset: 0x00071354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197576, XrefRangeEnd = 197588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_CloseConnection_Public_Static_Boolean_HSteamNetConnection_Int32_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x000731C0 File Offset: 0x000713C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197588, XrefRangeEnd = 197592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CloseListenSocket(HSteamListenSocket hSocket)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSocket;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_CloseListenSocket_Public_Static_Boolean_HSteamListenSocket_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x00073200 File Offset: 0x00071400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197592, XrefRangeEnd = 197596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_SetConnectionUserData_Public_Static_Boolean_HSteamNetConnection_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x0007324C File Offset: 0x0007144C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197596, XrefRangeEnd = 197600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetConnectionUserData(HSteamNetConnection hPeer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hPeer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetConnectionUserData_Public_Static_Int64_HSteamNetConnection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x0007328C File Offset: 0x0007148C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197600, XrefRangeEnd = 197612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_SetConnectionName_Public_Static_Void_HSteamNetConnection_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x000732D0 File Offset: 0x000714D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197612, XrefRangeEnd = 197624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetConnectionName_Public_Static_Boolean_HSteamNetConnection_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pszName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x00073338 File Offset: 0x00071538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197624, XrefRangeEnd = 197628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_SendMessageToConnection_Public_Static_EResult_HSteamNetConnection_IntPtr_UInt32_Int32_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x000733B0 File Offset: 0x000715B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197628, XrefRangeEnd = 197632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_SendMessages_Public_Static_Void_Int32_Il2CppReferenceArray_1_SteamNetworkingMessage_t_Il2CppStructArray_1_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x00073408 File Offset: 0x00071608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197632, XrefRangeEnd = 197636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EResult FlushMessagesOnConnection(HSteamNetConnection hConn)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hConn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_FlushMessagesOnConnection_Public_Static_EResult_HSteamNetConnection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x00073448 File Offset: 0x00071648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197636, XrefRangeEnd = 197640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_ReceiveMessagesOnConnection_Public_Static_Int32_HSteamNetConnection_Il2CppStructArray_1_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x000734A8 File Offset: 0x000716A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197640, XrefRangeEnd = 197644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetConnectionInfo_Public_Static_Boolean_HSteamNetConnection_byref_SteamNetConnectionInfo_t_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pInfo = ((intPtr4 == 0) ? null : new SteamNetConnectionInfo_t(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x00073508 File Offset: 0x00071708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197644, XrefRangeEnd = 197648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetQuickConnectionStatus_Public_Static_Boolean_HSteamNetConnection_byref_SteamNetworkingQuickConnectionStatus_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pStats = ((intPtr4 == 0) ? null : new SteamNetworkingQuickConnectionStatus(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x00073568 File Offset: 0x00071768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197648, XrefRangeEnd = 197660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetDetailedConnectionStatus_Public_Static_Int32_HSteamNetConnection_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pszBuf = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x000735D0 File Offset: 0x000717D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197660, XrefRangeEnd = 197664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetListenSocketAddress_Public_Static_Boolean_HSteamListenSocket_byref_SteamNetworkingIPAddr_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			address = ((intPtr4 == 0) ? null : new SteamNetworkingIPAddr(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00073630 File Offset: 0x00071830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197664, XrefRangeEnd = 197668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_CreateSocketPair_Public_Static_Boolean_byref_HSteamNetConnection_byref_HSteamNetConnection_Boolean_byref_SteamNetworkingIdentity_byref_SteamNetworkingIdentity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x000736B0 File Offset: 0x000718B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197668, XrefRangeEnd = 197672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetIdentity(out SteamNetworkingIdentity pIdentity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetIdentity_Public_Static_Boolean_byref_SteamNetworkingIdentity_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pIdentity = ((intPtr4 == 0) ? null : new SteamNetworkingIdentity(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00073704 File Offset: 0x00071904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197672, XrefRangeEnd = 197676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESteamNetworkingAvailability InitAuthentication()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_InitAuthentication_Public_Static_ESteamNetworkingAvailability_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x00073734 File Offset: 0x00071934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197676, XrefRangeEnd = 197680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESteamNetworkingAvailability GetAuthenticationStatus(out SteamNetAuthenticationStatus_t pDetails)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetAuthenticationStatus_Public_Static_ESteamNetworkingAvailability_byref_SteamNetAuthenticationStatus_t_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pDetails = ((intPtr4 == 0) ? null : new SteamNetAuthenticationStatus_t(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x00073788 File Offset: 0x00071988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197680, XrefRangeEnd = 197688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamNetPollGroup CreatePollGroup()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_CreatePollGroup_Public_Static_HSteamNetPollGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x000737B8 File Offset: 0x000719B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197688, XrefRangeEnd = 197692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DestroyPollGroup(HSteamNetPollGroup hPollGroup)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hPollGroup;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_DestroyPollGroup_Public_Static_Boolean_HSteamNetPollGroup_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x000737F8 File Offset: 0x000719F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197692, XrefRangeEnd = 197696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_SetConnectionPollGroup_Public_Static_Boolean_HSteamNetConnection_HSteamNetPollGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x00073844 File Offset: 0x00071A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197696, XrefRangeEnd = 197700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_ReceiveMessagesOnPollGroup_Public_Static_Int32_HSteamNetPollGroup_Il2CppStructArray_1_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x000738A4 File Offset: 0x00071AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197700, XrefRangeEnd = 197704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_ReceivedRelayAuthTicket_Public_Static_Boolean_IntPtr_Int32_byref_SteamDatagramRelayAuthTicket_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pOutParsedTicket = ((intPtr4 == 0) ? null : new SteamDatagramRelayAuthTicket(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x00073914 File Offset: 0x00071B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197704, XrefRangeEnd = 197708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_FindRelayAuthTicketForServer_Public_Static_Int32_byref_SteamNetworkingIdentity_Int32_byref_SteamDatagramRelayAuthTicket_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pOutParsedTicket = ((intPtr4 == 0) ? null : new SteamDatagramRelayAuthTicket(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x00073988 File Offset: 0x00071B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197708, XrefRangeEnd = 197716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_ConnectToHostedDedicatedServer_Public_Static_HSteamNetConnection_byref_SteamNetworkingIdentity_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x000739F8 File Offset: 0x00071BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197716, XrefRangeEnd = 197720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort GetHostedDedicatedServerPort()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetHostedDedicatedServerPort_Public_Static_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x00073A28 File Offset: 0x00071C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197720, XrefRangeEnd = 197725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamNetworkingPOPID GetHostedDedicatedServerPOPID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetHostedDedicatedServerPOPID_Public_Static_SteamNetworkingPOPID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x00073A58 File Offset: 0x00071C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197725, XrefRangeEnd = 197729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EResult GetHostedDedicatedServerAddress(out SteamDatagramHostedAddress pRouting)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetHostedDedicatedServerAddress_Public_Static_EResult_byref_SteamDatagramHostedAddress_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pRouting = ((intPtr4 == 0) ? null : new SteamDatagramHostedAddress(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x00073AAC File Offset: 0x00071CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197729, XrefRangeEnd = 197737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_CreateHostedDedicatedServerListenSocket_Public_Static_HSteamListenSocket_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00073B0C File Offset: 0x00071D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197737, XrefRangeEnd = 197741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetGameCoordinatorServerLogin_Public_Static_EResult_byref_SteamDatagramGameCoordinatorServerLogin_byref_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pLoginInfo = ((intPtr4 == 0) ? null : new SteamDatagramGameCoordinatorServerLogin(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00073B7C File Offset: 0x00071D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197741, XrefRangeEnd = 197749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_ConnectP2PCustomSignaling_Public_Static_HSteamNetConnection_byref_ISteamNetworkingConnectionCustomSignaling_byref_SteamNetworkingIdentity_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00073BFC File Offset: 0x00071DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197749, XrefRangeEnd = 197753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_ReceivedP2PCustomSignal_Public_Static_Boolean_IntPtr_Int32_byref_ISteamNetworkingCustomSignalingRecvContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00073C58 File Offset: 0x00071E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197753, XrefRangeEnd = 197757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_GetCertificateRequest_Public_Static_Boolean_byref_Int32_IntPtr_byref_SteamNetworkingErrMsg_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			errMsg = ((intPtr4 == 0) ? null : new SteamNetworkingErrMsg(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00073CC8 File Offset: 0x00071EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197757, XrefRangeEnd = 197761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_SetCertificate_Public_Static_Boolean_IntPtr_Int32_byref_SteamNetworkingErrMsg_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			errMsg = ((intPtr4 == 0) ? null : new SteamNetworkingErrMsg(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x00073D38 File Offset: 0x00071F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197761, XrefRangeEnd = 197765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunCallbacks()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerNetworkingSockets.NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x0000BA4B File Offset: 0x00009C4B
		public SteamGameServerNetworkingSockets(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040013AF RID: 5039
		private static readonly IntPtr NativeMethodInfoPtr_CreateListenSocketIP_Public_Static_HSteamListenSocket_byref_SteamNetworkingIPAddr_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0;

		// Token: 0x040013B0 RID: 5040
		private static readonly IntPtr NativeMethodInfoPtr_ConnectByIPAddress_Public_Static_HSteamNetConnection_byref_SteamNetworkingIPAddr_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0;

		// Token: 0x040013B1 RID: 5041
		private static readonly IntPtr NativeMethodInfoPtr_CreateListenSocketP2P_Public_Static_HSteamListenSocket_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0;

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeMethodInfoPtr_ConnectP2P_Public_Static_HSteamNetConnection_byref_SteamNetworkingIdentity_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0;

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeMethodInfoPtr_AcceptConnection_Public_Static_EResult_HSteamNetConnection_0;

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeMethodInfoPtr_CloseConnection_Public_Static_Boolean_HSteamNetConnection_Int32_String_Boolean_0;

		// Token: 0x040013B5 RID: 5045
		private static readonly IntPtr NativeMethodInfoPtr_CloseListenSocket_Public_Static_Boolean_HSteamListenSocket_0;

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeMethodInfoPtr_SetConnectionUserData_Public_Static_Boolean_HSteamNetConnection_Int64_0;

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionUserData_Public_Static_Int64_HSteamNetConnection_0;

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeMethodInfoPtr_SetConnectionName_Public_Static_Void_HSteamNetConnection_String_0;

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionName_Public_Static_Boolean_HSteamNetConnection_byref_String_Int32_0;

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeMethodInfoPtr_SendMessageToConnection_Public_Static_EResult_HSteamNetConnection_IntPtr_UInt32_Int32_byref_Int64_0;

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeMethodInfoPtr_SendMessages_Public_Static_Void_Int32_Il2CppReferenceArray_1_SteamNetworkingMessage_t_Il2CppStructArray_1_Int64_0;

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeMethodInfoPtr_FlushMessagesOnConnection_Public_Static_EResult_HSteamNetConnection_0;

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessagesOnConnection_Public_Static_Int32_HSteamNetConnection_Il2CppStructArray_1_IntPtr_Int32_0;

		// Token: 0x040013BE RID: 5054
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectionInfo_Public_Static_Boolean_HSteamNetConnection_byref_SteamNetConnectionInfo_t_0;

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeMethodInfoPtr_GetQuickConnectionStatus_Public_Static_Boolean_HSteamNetConnection_byref_SteamNetworkingQuickConnectionStatus_0;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeMethodInfoPtr_GetDetailedConnectionStatus_Public_Static_Int32_HSteamNetConnection_byref_String_Int32_0;

		// Token: 0x040013C1 RID: 5057
		private static readonly IntPtr NativeMethodInfoPtr_GetListenSocketAddress_Public_Static_Boolean_HSteamListenSocket_byref_SteamNetworkingIPAddr_0;

		// Token: 0x040013C2 RID: 5058
		private static readonly IntPtr NativeMethodInfoPtr_CreateSocketPair_Public_Static_Boolean_byref_HSteamNetConnection_byref_HSteamNetConnection_Boolean_byref_SteamNetworkingIdentity_byref_SteamNetworkingIdentity_0;

		// Token: 0x040013C3 RID: 5059
		private static readonly IntPtr NativeMethodInfoPtr_GetIdentity_Public_Static_Boolean_byref_SteamNetworkingIdentity_0;

		// Token: 0x040013C4 RID: 5060
		private static readonly IntPtr NativeMethodInfoPtr_InitAuthentication_Public_Static_ESteamNetworkingAvailability_0;

		// Token: 0x040013C5 RID: 5061
		private static readonly IntPtr NativeMethodInfoPtr_GetAuthenticationStatus_Public_Static_ESteamNetworkingAvailability_byref_SteamNetAuthenticationStatus_t_0;

		// Token: 0x040013C6 RID: 5062
		private static readonly IntPtr NativeMethodInfoPtr_CreatePollGroup_Public_Static_HSteamNetPollGroup_0;

		// Token: 0x040013C7 RID: 5063
		private static readonly IntPtr NativeMethodInfoPtr_DestroyPollGroup_Public_Static_Boolean_HSteamNetPollGroup_0;

		// Token: 0x040013C8 RID: 5064
		private static readonly IntPtr NativeMethodInfoPtr_SetConnectionPollGroup_Public_Static_Boolean_HSteamNetConnection_HSteamNetPollGroup_0;

		// Token: 0x040013C9 RID: 5065
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveMessagesOnPollGroup_Public_Static_Int32_HSteamNetPollGroup_Il2CppStructArray_1_IntPtr_Int32_0;

		// Token: 0x040013CA RID: 5066
		private static readonly IntPtr NativeMethodInfoPtr_ReceivedRelayAuthTicket_Public_Static_Boolean_IntPtr_Int32_byref_SteamDatagramRelayAuthTicket_0;

		// Token: 0x040013CB RID: 5067
		private static readonly IntPtr NativeMethodInfoPtr_FindRelayAuthTicketForServer_Public_Static_Int32_byref_SteamNetworkingIdentity_Int32_byref_SteamDatagramRelayAuthTicket_0;

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeMethodInfoPtr_ConnectToHostedDedicatedServer_Public_Static_HSteamNetConnection_byref_SteamNetworkingIdentity_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeMethodInfoPtr_GetHostedDedicatedServerPort_Public_Static_UInt16_0;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeMethodInfoPtr_GetHostedDedicatedServerPOPID_Public_Static_SteamNetworkingPOPID_0;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeMethodInfoPtr_GetHostedDedicatedServerAddress_Public_Static_EResult_byref_SteamDatagramHostedAddress_0;

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeMethodInfoPtr_CreateHostedDedicatedServerListenSocket_Public_Static_HSteamListenSocket_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeMethodInfoPtr_GetGameCoordinatorServerLogin_Public_Static_EResult_byref_SteamDatagramGameCoordinatorServerLogin_byref_Int32_IntPtr_0;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeMethodInfoPtr_ConnectP2PCustomSignaling_Public_Static_HSteamNetConnection_byref_ISteamNetworkingConnectionCustomSignaling_byref_SteamNetworkingIdentity_Int32_Int32_Il2CppStructArray_1_SteamNetworkingConfigValue_t_0;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeMethodInfoPtr_ReceivedP2PCustomSignal_Public_Static_Boolean_IntPtr_Int32_byref_ISteamNetworkingCustomSignalingRecvContext_0;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeMethodInfoPtr_GetCertificateRequest_Public_Static_Boolean_byref_Int32_IntPtr_byref_SteamNetworkingErrMsg_0;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeMethodInfoPtr_SetCertificate_Public_Static_Boolean_IntPtr_Int32_byref_SteamNetworkingErrMsg_0;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeMethodInfoPtr_RunCallbacks_Public_Static_Void_0;
	}
}

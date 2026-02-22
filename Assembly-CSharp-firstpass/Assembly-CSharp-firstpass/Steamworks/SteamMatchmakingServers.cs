using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200015D RID: 349
	public static class SteamMatchmakingServers : Object
	{
		// Token: 0x06001B26 RID: 6950 RVA: 0x0007B9DC File Offset: 0x00079BDC
		// Note: this type is marked as 'beforefieldinit'.
		static SteamMatchmakingServers()
		{
			Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamMatchmakingServers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr);
			SteamMatchmakingServers.NativeMethodInfoPtr_RequestInternetServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100666952);
			SteamMatchmakingServers.NativeMethodInfoPtr_RequestLANServerList_Public_Static_HServerListRequest_AppId_t_ISteamMatchmakingServerListResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100666953);
			SteamMatchmakingServers.NativeMethodInfoPtr_RequestFriendsServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100666954);
			SteamMatchmakingServers.NativeMethodInfoPtr_RequestFavoritesServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100666955);
			SteamMatchmakingServers.NativeMethodInfoPtr_RequestHistoryServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100666956);
			SteamMatchmakingServers.NativeMethodInfoPtr_RequestSpectatorServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100666957);
			SteamMatchmakingServers.NativeMethodInfoPtr_ReleaseRequest_Public_Static_Void_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100666958);
			SteamMatchmakingServers.NativeMethodInfoPtr_GetServerDetails_Public_Static_gameserveritem_t_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100666959);
			SteamMatchmakingServers.NativeMethodInfoPtr_CancelQuery_Public_Static_Void_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100666960);
			SteamMatchmakingServers.NativeMethodInfoPtr_RefreshQuery_Public_Static_Void_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100666961);
			SteamMatchmakingServers.NativeMethodInfoPtr_IsRefreshing_Public_Static_Boolean_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100666962);
			SteamMatchmakingServers.NativeMethodInfoPtr_GetServerCount_Public_Static_Int32_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100666963);
			SteamMatchmakingServers.NativeMethodInfoPtr_RefreshServer_Public_Static_Void_HServerListRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100666964);
			SteamMatchmakingServers.NativeMethodInfoPtr_PingServer_Public_Static_HServerQuery_UInt32_UInt16_ISteamMatchmakingPingResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100666965);
			SteamMatchmakingServers.NativeMethodInfoPtr_PlayerDetails_Public_Static_HServerQuery_UInt32_UInt16_ISteamMatchmakingPlayersResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100666966);
			SteamMatchmakingServers.NativeMethodInfoPtr_ServerRules_Public_Static_HServerQuery_UInt32_UInt16_ISteamMatchmakingRulesResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100666967);
			SteamMatchmakingServers.NativeMethodInfoPtr_CancelServerQuery_Public_Static_Void_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100666968);
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x0007BB60 File Offset: 0x00079D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200037, XrefRangeEnd = 200051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerListRequest RequestInternetServerList(AppId_t iApp, Il2CppReferenceArray<MatchMakingKeyValuePair_t> ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iApp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ppchFilters);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRequestServersResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_RequestInternetServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x0007BBD0 File Offset: 0x00079DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200051, XrefRangeEnd = 200060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerListRequest RequestLANServerList(AppId_t iApp, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iApp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRequestServersResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_RequestLANServerList_Public_Static_HServerListRequest_AppId_t_ISteamMatchmakingServerListResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0007BC20 File Offset: 0x00079E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200060, XrefRangeEnd = 200074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerListRequest RequestFriendsServerList(AppId_t iApp, Il2CppReferenceArray<MatchMakingKeyValuePair_t> ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iApp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ppchFilters);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRequestServersResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_RequestFriendsServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x0007BC90 File Offset: 0x00079E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200074, XrefRangeEnd = 200088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerListRequest RequestFavoritesServerList(AppId_t iApp, Il2CppReferenceArray<MatchMakingKeyValuePair_t> ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iApp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ppchFilters);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRequestServersResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_RequestFavoritesServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x0007BD00 File Offset: 0x00079F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200088, XrefRangeEnd = 200102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerListRequest RequestHistoryServerList(AppId_t iApp, Il2CppReferenceArray<MatchMakingKeyValuePair_t> ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iApp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ppchFilters);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRequestServersResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_RequestHistoryServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x0007BD70 File Offset: 0x00079F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200102, XrefRangeEnd = 200116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerListRequest RequestSpectatorServerList(AppId_t iApp, Il2CppReferenceArray<MatchMakingKeyValuePair_t> ppchFilters, uint nFilters, ISteamMatchmakingServerListResponse pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iApp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ppchFilters);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nFilters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRequestServersResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_RequestSpectatorServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x0007BDE0 File Offset: 0x00079FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200116, XrefRangeEnd = 200120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseRequest(HServerListRequest hServerListRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hServerListRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_ReleaseRequest_Public_Static_Void_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x0007BE14 File Offset: 0x0007A014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200120, XrefRangeEnd = 200136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static gameserveritem_t GetServerDetails(HServerListRequest hRequest, int iServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_GetServerDetails_Public_Static_gameserveritem_t_HServerListRequest_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<gameserveritem_t>(intPtr3) : null;
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x0007BE64 File Offset: 0x0007A064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200136, XrefRangeEnd = 200140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CancelQuery(HServerListRequest hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_CancelQuery_Public_Static_Void_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x0007BE98 File Offset: 0x0007A098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200140, XrefRangeEnd = 200144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RefreshQuery(HServerListRequest hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_RefreshQuery_Public_Static_Void_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x0007BECC File Offset: 0x0007A0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200144, XrefRangeEnd = 200148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRefreshing(HServerListRequest hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_IsRefreshing_Public_Static_Boolean_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x0007BF0C File Offset: 0x0007A10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200148, XrefRangeEnd = 200152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetServerCount(HServerListRequest hRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_GetServerCount_Public_Static_Int32_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x0007BF4C File Offset: 0x0007A14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200152, XrefRangeEnd = 200156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RefreshServer(HServerListRequest hRequest, int iServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hRequest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_RefreshServer_Public_Static_Void_HServerListRequest_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x0007BF8C File Offset: 0x0007A18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200156, XrefRangeEnd = 200165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerQuery PingServer(uint unIP, ushort usPort, ISteamMatchmakingPingResponse pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRequestServersResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_PingServer_Public_Static_HServerQuery_UInt32_UInt16_ISteamMatchmakingPingResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x0007BFEC File Offset: 0x0007A1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200165, XrefRangeEnd = 200174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerQuery PlayerDetails(uint unIP, ushort usPort, ISteamMatchmakingPlayersResponse pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRequestServersResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_PlayerDetails_Public_Static_HServerQuery_UInt32_UInt16_ISteamMatchmakingPlayersResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x0007C04C File Offset: 0x0007A24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200174, XrefRangeEnd = 200183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HServerQuery ServerRules(uint unIP, ushort usPort, ISteamMatchmakingRulesResponse pRequestServersResponse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pRequestServersResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_ServerRules_Public_Static_HServerQuery_UInt32_UInt16_ISteamMatchmakingRulesResponse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x0007C0AC File Offset: 0x0007A2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200183, XrefRangeEnd = 200187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CancelServerQuery(HServerQuery hServerQuery)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hServerQuery;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_CancelServerQuery_Public_Static_Void_HServerQuery_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x0000BAA5 File Offset: 0x00009CA5
		public SteamMatchmakingServers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001514 RID: 5396
		private static readonly IntPtr NativeMethodInfoPtr_RequestInternetServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0;

		// Token: 0x04001515 RID: 5397
		private static readonly IntPtr NativeMethodInfoPtr_RequestLANServerList_Public_Static_HServerListRequest_AppId_t_ISteamMatchmakingServerListResponse_0;

		// Token: 0x04001516 RID: 5398
		private static readonly IntPtr NativeMethodInfoPtr_RequestFriendsServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0;

		// Token: 0x04001517 RID: 5399
		private static readonly IntPtr NativeMethodInfoPtr_RequestFavoritesServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0;

		// Token: 0x04001518 RID: 5400
		private static readonly IntPtr NativeMethodInfoPtr_RequestHistoryServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0;

		// Token: 0x04001519 RID: 5401
		private static readonly IntPtr NativeMethodInfoPtr_RequestSpectatorServerList_Public_Static_HServerListRequest_AppId_t_Il2CppReferenceArray_1_MatchMakingKeyValuePair_t_UInt32_ISteamMatchmakingServerListResponse_0;

		// Token: 0x0400151A RID: 5402
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseRequest_Public_Static_Void_HServerListRequest_0;

		// Token: 0x0400151B RID: 5403
		private static readonly IntPtr NativeMethodInfoPtr_GetServerDetails_Public_Static_gameserveritem_t_HServerListRequest_Int32_0;

		// Token: 0x0400151C RID: 5404
		private static readonly IntPtr NativeMethodInfoPtr_CancelQuery_Public_Static_Void_HServerListRequest_0;

		// Token: 0x0400151D RID: 5405
		private static readonly IntPtr NativeMethodInfoPtr_RefreshQuery_Public_Static_Void_HServerListRequest_0;

		// Token: 0x0400151E RID: 5406
		private static readonly IntPtr NativeMethodInfoPtr_IsRefreshing_Public_Static_Boolean_HServerListRequest_0;

		// Token: 0x0400151F RID: 5407
		private static readonly IntPtr NativeMethodInfoPtr_GetServerCount_Public_Static_Int32_HServerListRequest_0;

		// Token: 0x04001520 RID: 5408
		private static readonly IntPtr NativeMethodInfoPtr_RefreshServer_Public_Static_Void_HServerListRequest_Int32_0;

		// Token: 0x04001521 RID: 5409
		private static readonly IntPtr NativeMethodInfoPtr_PingServer_Public_Static_HServerQuery_UInt32_UInt16_ISteamMatchmakingPingResponse_0;

		// Token: 0x04001522 RID: 5410
		private static readonly IntPtr NativeMethodInfoPtr_PlayerDetails_Public_Static_HServerQuery_UInt32_UInt16_ISteamMatchmakingPlayersResponse_0;

		// Token: 0x04001523 RID: 5411
		private static readonly IntPtr NativeMethodInfoPtr_ServerRules_Public_Static_HServerQuery_UInt32_UInt16_ISteamMatchmakingRulesResponse_0;

		// Token: 0x04001524 RID: 5412
		private static readonly IntPtr NativeMethodInfoPtr_CancelServerQuery_Public_Static_Void_HServerQuery_0;
	}
}

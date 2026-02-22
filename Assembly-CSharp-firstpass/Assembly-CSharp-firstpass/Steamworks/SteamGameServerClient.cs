using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200014F RID: 335
	public static class SteamGameServerClient : Object
	{
		// Token: 0x0600192C RID: 6444 RVA: 0x0006F8B8 File Offset: 0x0006DAB8
		// Note: this type is marked as 'beforefieldinit'.
		static SteamGameServerClient()
		{
			Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamGameServerClient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr);
			SteamGameServerClient.NativeMethodInfoPtr_CreateSteamPipe_Public_Static_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666474);
			SteamGameServerClient.NativeMethodInfoPtr_BReleaseSteamPipe_Public_Static_Boolean_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666475);
			SteamGameServerClient.NativeMethodInfoPtr_ConnectToGlobalUser_Public_Static_HSteamUser_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666476);
			SteamGameServerClient.NativeMethodInfoPtr_CreateLocalUser_Public_Static_HSteamUser_byref_HSteamPipe_EAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666477);
			SteamGameServerClient.NativeMethodInfoPtr_ReleaseUser_Public_Static_Void_HSteamPipe_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666478);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamUser_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666479);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamGameServer_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666480);
			SteamGameServerClient.NativeMethodInfoPtr_SetLocalIPBinding_Public_Static_Void_byref_SteamIPAddress_t_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666481);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamFriends_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666482);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamUtils_Public_Static_IntPtr_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666483);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamMatchmaking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666484);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamMatchmakingServers_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666485);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamGenericInterface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666486);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamUserStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666487);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamGameServerStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666488);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamApps_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666489);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamNetworking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666490);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamRemoteStorage_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666491);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamScreenshots_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666492);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamGameSearch_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666493);
			SteamGameServerClient.NativeMethodInfoPtr_GetIPCCallCount_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666494);
			SteamGameServerClient.NativeMethodInfoPtr_SetWarningMessageHook_Public_Static_Void_SteamAPIWarningMessageHook_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666495);
			SteamGameServerClient.NativeMethodInfoPtr_BShutdownIfAllPipesClosed_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666496);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamHTTP_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666497);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamController_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666498);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamUGC_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666499);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamAppList_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666500);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamMusic_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666501);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamMusicRemote_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666502);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamHTMLSurface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666503);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamInventory_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666504);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamVideo_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666505);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamParentalSettings_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666506);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamInput_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666507);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamParties_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666508);
			SteamGameServerClient.NativeMethodInfoPtr_GetISteamRemotePlay_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerClient>.NativeClassPtr, 100666509);
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x0006FBB8 File Offset: 0x0006DDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196621, XrefRangeEnd = 196626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamPipe CreateSteamPipe()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_CreateSteamPipe_Public_Static_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x0006FBE8 File Offset: 0x0006DDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196626, XrefRangeEnd = 196630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BReleaseSteamPipe(HSteamPipe hSteamPipe)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamPipe;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_BReleaseSteamPipe_Public_Static_Boolean_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x0006FC28 File Offset: 0x0006DE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196630, XrefRangeEnd = 196635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamPipe;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_ConnectToGlobalUser_Public_Static_HSteamUser_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x0006FC68 File Offset: 0x0006DE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196635, XrefRangeEnd = 196640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &phSteamPipe;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAccountType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_CreateLocalUser_Public_Static_HSteamUser_byref_HSteamPipe_EAccountType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x0006FCB4 File Offset: 0x0006DEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196640, XrefRangeEnd = 196644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamPipe;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_ReleaseUser_Public_Static_Void_HSteamPipe_HSteamUser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x0006FCF4 File Offset: 0x0006DEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196644, XrefRangeEnd = 196656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamUser_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x0006FD54 File Offset: 0x0006DF54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196668, RefRangeEnd = 196669, XrefRangeStart = 196656, XrefRangeEnd = 196668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamGameServer_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x0006FDB4 File Offset: 0x0006DFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196669, XrefRangeEnd = 196673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLocalIPBinding(ref SteamIPAddress_t unIP, ushort usPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &unIP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_SetLocalIPBinding_Public_Static_Void_byref_SteamIPAddress_t_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x0006FDF4 File Offset: 0x0006DFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196673, XrefRangeEnd = 196685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamFriends_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x0006FE54 File Offset: 0x0006E054
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196697, RefRangeEnd = 196698, XrefRangeStart = 196685, XrefRangeEnd = 196697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamPipe;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamUtils_Public_Static_IntPtr_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x0006FEA4 File Offset: 0x0006E0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196698, XrefRangeEnd = 196710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamMatchmaking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x0006FF04 File Offset: 0x0006E104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196710, XrefRangeEnd = 196722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamMatchmakingServers_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x0006FF64 File Offset: 0x0006E164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196722, XrefRangeEnd = 196734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamGenericInterface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x0006FFC4 File Offset: 0x0006E1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196734, XrefRangeEnd = 196746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamUserStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00070024 File Offset: 0x0006E224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196758, RefRangeEnd = 196759, XrefRangeStart = 196746, XrefRangeEnd = 196758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamGameServerStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00070084 File Offset: 0x0006E284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196771, RefRangeEnd = 196772, XrefRangeStart = 196759, XrefRangeEnd = 196771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamApps_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x000700E4 File Offset: 0x0006E2E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196784, RefRangeEnd = 196785, XrefRangeStart = 196772, XrefRangeEnd = 196784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamNetworking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00070144 File Offset: 0x0006E344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196785, XrefRangeEnd = 196797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamRemoteStorage_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x000701A4 File Offset: 0x0006E3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196797, XrefRangeEnd = 196809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamScreenshots_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x00070204 File Offset: 0x0006E404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196809, XrefRangeEnd = 196821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamGameSearch(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamGameSearch_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00070264 File Offset: 0x0006E464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196821, XrefRangeEnd = 196825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetIPCCallCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetIPCCallCount_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x00070294 File Offset: 0x0006E494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196825, XrefRangeEnd = 196829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pFunction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_SetWarningMessageHook_Public_Static_Void_SteamAPIWarningMessageHook_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x000702CC File Offset: 0x0006E4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196829, XrefRangeEnd = 196833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BShutdownIfAllPipesClosed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_BShutdownIfAllPipesClosed_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x000702FC File Offset: 0x0006E4FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196845, RefRangeEnd = 196846, XrefRangeStart = 196833, XrefRangeEnd = 196845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamHTTP_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0007035C File Offset: 0x0006E55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196846, XrefRangeEnd = 196858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamController_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x000703BC File Offset: 0x0006E5BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196870, RefRangeEnd = 196871, XrefRangeStart = 196858, XrefRangeEnd = 196870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamUGC_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x0007041C File Offset: 0x0006E61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196871, XrefRangeEnd = 196883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamAppList(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamAppList_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x0007047C File Offset: 0x0006E67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196883, XrefRangeEnd = 196895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamMusic_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x000704DC File Offset: 0x0006E6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196895, XrefRangeEnd = 196907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamMusicRemote_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0007053C File Offset: 0x0006E73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196907, XrefRangeEnd = 196919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamHTMLSurface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x0007059C File Offset: 0x0006E79C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196931, RefRangeEnd = 196932, XrefRangeStart = 196919, XrefRangeEnd = 196931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamInventory_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x000705FC File Offset: 0x0006E7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196932, XrefRangeEnd = 196944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamVideo_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x0007065C File Offset: 0x0006E85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196944, XrefRangeEnd = 196956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamuser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamParentalSettings_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x000706BC File Offset: 0x0006E8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196956, XrefRangeEnd = 196968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamInput(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamInput_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x0007071C File Offset: 0x0006E91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196968, XrefRangeEnd = 196980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamParties(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamParties_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x0007077C File Offset: 0x0006E97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196980, XrefRangeEnd = 196992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetISteamRemotePlay(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamPipe;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerClient.NativeMethodInfoPtr_GetISteamRemotePlay_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x0000BA27 File Offset: 0x00009C27
		public SteamGameServerClient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeMethodInfoPtr_CreateSteamPipe_Public_Static_HSteamPipe_0;

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeMethodInfoPtr_BReleaseSteamPipe_Public_Static_Boolean_HSteamPipe_0;

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeMethodInfoPtr_ConnectToGlobalUser_Public_Static_HSteamUser_HSteamPipe_0;

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeMethodInfoPtr_CreateLocalUser_Public_Static_HSteamUser_byref_HSteamPipe_EAccountType_0;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseUser_Public_Static_Void_HSteamPipe_HSteamUser_0;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamUser_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamGameServer_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalIPBinding_Public_Static_Void_byref_SteamIPAddress_t_UInt16_0;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamFriends_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamUtils_Public_Static_IntPtr_HSteamPipe_String_0;

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamMatchmaking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamMatchmakingServers_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamGenericInterface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamUserStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamGameServerStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamApps_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamNetworking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamRemoteStorage_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamScreenshots_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamGameSearch_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeMethodInfoPtr_GetIPCCallCount_Public_Static_UInt32_0;

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeMethodInfoPtr_SetWarningMessageHook_Public_Static_Void_SteamAPIWarningMessageHook_t_0;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeMethodInfoPtr_BShutdownIfAllPipesClosed_Public_Static_Boolean_0;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamHTTP_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamController_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamUGC_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamAppList_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamMusic_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamMusicRemote_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001353 RID: 4947
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamHTMLSurface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001354 RID: 4948
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamInventory_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001355 RID: 4949
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamVideo_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001356 RID: 4950
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamParentalSettings_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001357 RID: 4951
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamInput_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001358 RID: 4952
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamParties_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001359 RID: 4953
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamRemotePlay_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200014A RID: 330
	public static class SteamClient : Object
	{
		// Token: 0x06001849 RID: 6217 RVA: 0x0006AC74 File Offset: 0x00068E74
		// Note: this type is marked as 'beforefieldinit'.
		static SteamClient()
		{
			Il2CppClassPointerStore<SteamClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamClient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamClient>.NativeClassPtr);
			SteamClient.NativeMethodInfoPtr_CreateSteamPipe_Public_Static_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666257);
			SteamClient.NativeMethodInfoPtr_BReleaseSteamPipe_Public_Static_Boolean_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666258);
			SteamClient.NativeMethodInfoPtr_ConnectToGlobalUser_Public_Static_HSteamUser_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666259);
			SteamClient.NativeMethodInfoPtr_CreateLocalUser_Public_Static_HSteamUser_byref_HSteamPipe_EAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666260);
			SteamClient.NativeMethodInfoPtr_ReleaseUser_Public_Static_Void_HSteamPipe_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666261);
			SteamClient.NativeMethodInfoPtr_GetISteamUser_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666262);
			SteamClient.NativeMethodInfoPtr_GetISteamGameServer_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666263);
			SteamClient.NativeMethodInfoPtr_SetLocalIPBinding_Public_Static_Void_byref_SteamIPAddress_t_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666264);
			SteamClient.NativeMethodInfoPtr_GetISteamFriends_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666265);
			SteamClient.NativeMethodInfoPtr_GetISteamUtils_Public_Static_IntPtr_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666266);
			SteamClient.NativeMethodInfoPtr_GetISteamMatchmaking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666267);
			SteamClient.NativeMethodInfoPtr_GetISteamMatchmakingServers_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666268);
			SteamClient.NativeMethodInfoPtr_GetISteamGenericInterface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666269);
			SteamClient.NativeMethodInfoPtr_GetISteamUserStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666270);
			SteamClient.NativeMethodInfoPtr_GetISteamGameServerStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666271);
			SteamClient.NativeMethodInfoPtr_GetISteamApps_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666272);
			SteamClient.NativeMethodInfoPtr_GetISteamNetworking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666273);
			SteamClient.NativeMethodInfoPtr_GetISteamRemoteStorage_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666274);
			SteamClient.NativeMethodInfoPtr_GetISteamScreenshots_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666275);
			SteamClient.NativeMethodInfoPtr_GetISteamGameSearch_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666276);
			SteamClient.NativeMethodInfoPtr_GetIPCCallCount_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666277);
			SteamClient.NativeMethodInfoPtr_SetWarningMessageHook_Public_Static_Void_SteamAPIWarningMessageHook_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666278);
			SteamClient.NativeMethodInfoPtr_BShutdownIfAllPipesClosed_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666279);
			SteamClient.NativeMethodInfoPtr_GetISteamHTTP_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666280);
			SteamClient.NativeMethodInfoPtr_GetISteamController_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666281);
			SteamClient.NativeMethodInfoPtr_GetISteamUGC_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666282);
			SteamClient.NativeMethodInfoPtr_GetISteamAppList_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666283);
			SteamClient.NativeMethodInfoPtr_GetISteamMusic_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666284);
			SteamClient.NativeMethodInfoPtr_GetISteamMusicRemote_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666285);
			SteamClient.NativeMethodInfoPtr_GetISteamHTMLSurface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666286);
			SteamClient.NativeMethodInfoPtr_GetISteamInventory_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666287);
			SteamClient.NativeMethodInfoPtr_GetISteamVideo_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666288);
			SteamClient.NativeMethodInfoPtr_GetISteamParentalSettings_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666289);
			SteamClient.NativeMethodInfoPtr_GetISteamInput_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666290);
			SteamClient.NativeMethodInfoPtr_GetISteamParties_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666291);
			SteamClient.NativeMethodInfoPtr_GetISteamRemotePlay_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamClient>.NativeClassPtr, 100666292);
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x0006AF74 File Offset: 0x00069174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195110, XrefRangeEnd = 195115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamPipe CreateSteamPipe()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_CreateSteamPipe_Public_Static_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x0006AFA4 File Offset: 0x000691A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195115, XrefRangeEnd = 195119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BReleaseSteamPipe(HSteamPipe hSteamPipe)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamPipe;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_BReleaseSteamPipe_Public_Static_Boolean_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x0006AFE4 File Offset: 0x000691E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195119, XrefRangeEnd = 195124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamPipe;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_ConnectToGlobalUser_Public_Static_HSteamUser_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x0006B024 File Offset: 0x00069224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195124, XrefRangeEnd = 195129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_CreateLocalUser_Public_Static_HSteamUser_byref_HSteamPipe_EAccountType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x0006B070 File Offset: 0x00069270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195129, XrefRangeEnd = 195133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_ReleaseUser_Public_Static_Void_HSteamPipe_HSteamUser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x0006B0B0 File Offset: 0x000692B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195145, RefRangeEnd = 195146, XrefRangeStart = 195133, XrefRangeEnd = 195145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamUser_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x0006B110 File Offset: 0x00069310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195146, XrefRangeEnd = 195158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamGameServer_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x0006B170 File Offset: 0x00069370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195158, XrefRangeEnd = 195162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_SetLocalIPBinding_Public_Static_Void_byref_SteamIPAddress_t_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x0006B1B0 File Offset: 0x000693B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195174, RefRangeEnd = 195175, XrefRangeStart = 195162, XrefRangeEnd = 195174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamFriends_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0006B210 File Offset: 0x00069410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195187, RefRangeEnd = 195188, XrefRangeStart = 195175, XrefRangeEnd = 195187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamUtils_Public_Static_IntPtr_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x0006B260 File Offset: 0x00069460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195200, RefRangeEnd = 195201, XrefRangeStart = 195188, XrefRangeEnd = 195200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamMatchmaking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x0006B2C0 File Offset: 0x000694C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195213, RefRangeEnd = 195214, XrefRangeStart = 195201, XrefRangeEnd = 195213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamMatchmakingServers_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x0006B320 File Offset: 0x00069520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195214, XrefRangeEnd = 195226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamGenericInterface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x0006B380 File Offset: 0x00069580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195238, RefRangeEnd = 195239, XrefRangeStart = 195226, XrefRangeEnd = 195238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamUserStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x0006B3E0 File Offset: 0x000695E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195239, XrefRangeEnd = 195251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamGameServerStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x0006B440 File Offset: 0x00069640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195263, RefRangeEnd = 195264, XrefRangeStart = 195251, XrefRangeEnd = 195263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamApps_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x0006B4A0 File Offset: 0x000696A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195276, RefRangeEnd = 195277, XrefRangeStart = 195264, XrefRangeEnd = 195276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamNetworking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x0006B500 File Offset: 0x00069700
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195289, RefRangeEnd = 195290, XrefRangeStart = 195277, XrefRangeEnd = 195289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamRemoteStorage_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x0006B560 File Offset: 0x00069760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195302, RefRangeEnd = 195303, XrefRangeStart = 195290, XrefRangeEnd = 195302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamScreenshots_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x0006B5C0 File Offset: 0x000697C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195315, RefRangeEnd = 195316, XrefRangeStart = 195303, XrefRangeEnd = 195315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamGameSearch_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x0006B620 File Offset: 0x00069820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195316, XrefRangeEnd = 195320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetIPCCallCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetIPCCallCount_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0006B650 File Offset: 0x00069850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195324, RefRangeEnd = 195325, XrefRangeStart = 195320, XrefRangeEnd = 195324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pFunction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_SetWarningMessageHook_Public_Static_Void_SteamAPIWarningMessageHook_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x0006B688 File Offset: 0x00069888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195325, XrefRangeEnd = 195329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BShutdownIfAllPipesClosed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_BShutdownIfAllPipesClosed_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x0006B6B8 File Offset: 0x000698B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195341, RefRangeEnd = 195342, XrefRangeStart = 195329, XrefRangeEnd = 195341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamHTTP_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x0006B718 File Offset: 0x00069918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195354, RefRangeEnd = 195355, XrefRangeStart = 195342, XrefRangeEnd = 195354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamController_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x0006B778 File Offset: 0x00069978
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195367, RefRangeEnd = 195368, XrefRangeStart = 195355, XrefRangeEnd = 195367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamUGC_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x0006B7D8 File Offset: 0x000699D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195380, RefRangeEnd = 195381, XrefRangeStart = 195368, XrefRangeEnd = 195380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamAppList_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x0006B838 File Offset: 0x00069A38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195393, RefRangeEnd = 195394, XrefRangeStart = 195381, XrefRangeEnd = 195393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamMusic_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x0006B898 File Offset: 0x00069A98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195406, RefRangeEnd = 195407, XrefRangeStart = 195394, XrefRangeEnd = 195406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamMusicRemote_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x0006B8F8 File Offset: 0x00069AF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195419, RefRangeEnd = 195420, XrefRangeStart = 195407, XrefRangeEnd = 195419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamHTMLSurface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0006B958 File Offset: 0x00069B58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195432, RefRangeEnd = 195433, XrefRangeStart = 195420, XrefRangeEnd = 195432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamInventory_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x0006B9B8 File Offset: 0x00069BB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195445, RefRangeEnd = 195446, XrefRangeStart = 195433, XrefRangeEnd = 195445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamVideo_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0006BA18 File Offset: 0x00069C18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195458, RefRangeEnd = 195459, XrefRangeStart = 195446, XrefRangeEnd = 195458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamParentalSettings_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x0006BA78 File Offset: 0x00069C78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195471, RefRangeEnd = 195472, XrefRangeStart = 195459, XrefRangeEnd = 195471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamInput_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x0006BAD8 File Offset: 0x00069CD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195484, RefRangeEnd = 195485, XrefRangeStart = 195472, XrefRangeEnd = 195484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamParties_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x0006BB38 File Offset: 0x00069D38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195497, RefRangeEnd = 195498, XrefRangeStart = 195485, XrefRangeEnd = 195497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamClient.NativeMethodInfoPtr_GetISteamRemotePlay_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x0000B9FA File Offset: 0x00009BFA
		public SteamClient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeMethodInfoPtr_CreateSteamPipe_Public_Static_HSteamPipe_0;

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeMethodInfoPtr_BReleaseSteamPipe_Public_Static_Boolean_HSteamPipe_0;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeMethodInfoPtr_ConnectToGlobalUser_Public_Static_HSteamUser_HSteamPipe_0;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeMethodInfoPtr_CreateLocalUser_Public_Static_HSteamUser_byref_HSteamPipe_EAccountType_0;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseUser_Public_Static_Void_HSteamPipe_HSteamUser_0;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamUser_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamGameServer_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalIPBinding_Public_Static_Void_byref_SteamIPAddress_t_UInt16_0;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamFriends_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamUtils_Public_Static_IntPtr_HSteamPipe_String_0;

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamMatchmaking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamMatchmakingServers_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamGenericInterface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamUserStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamGameServerStats_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamApps_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400126D RID: 4717
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamNetworking_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400126E RID: 4718
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamRemoteStorage_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamScreenshots_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamGameSearch_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeMethodInfoPtr_GetIPCCallCount_Public_Static_UInt32_0;

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeMethodInfoPtr_SetWarningMessageHook_Public_Static_Void_SteamAPIWarningMessageHook_t_0;

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeMethodInfoPtr_BShutdownIfAllPipesClosed_Public_Static_Boolean_0;

		// Token: 0x04001274 RID: 4724
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamHTTP_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001275 RID: 4725
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamController_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamUGC_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001277 RID: 4727
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamAppList_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamMusic_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamMusicRemote_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamHTMLSurface_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamInventory_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamVideo_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamParentalSettings_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamInput_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamParties_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeMethodInfoPtr_GetISteamRemotePlay_Public_Static_IntPtr_HSteamUser_HSteamPipe_String_0;
	}
}

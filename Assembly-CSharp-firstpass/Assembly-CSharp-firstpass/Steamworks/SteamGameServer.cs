using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200014D RID: 333
	public static class SteamGameServer : Object
	{
		// Token: 0x060018E0 RID: 6368 RVA: 0x0006E174 File Offset: 0x0006C374
		// Note: this type is marked as 'beforefieldinit'.
		static SteamGameServer()
		{
			Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamGameServer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr);
			SteamGameServer.NativeMethodInfoPtr_SetProduct_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666402);
			SteamGameServer.NativeMethodInfoPtr_SetGameDescription_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666403);
			SteamGameServer.NativeMethodInfoPtr_SetModDir_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666404);
			SteamGameServer.NativeMethodInfoPtr_SetDedicatedServer_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666405);
			SteamGameServer.NativeMethodInfoPtr_LogOn_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666406);
			SteamGameServer.NativeMethodInfoPtr_LogOnAnonymous_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666407);
			SteamGameServer.NativeMethodInfoPtr_LogOff_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666408);
			SteamGameServer.NativeMethodInfoPtr_BLoggedOn_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666409);
			SteamGameServer.NativeMethodInfoPtr_BSecure_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666410);
			SteamGameServer.NativeMethodInfoPtr_GetSteamID_Public_Static_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666411);
			SteamGameServer.NativeMethodInfoPtr_WasRestartRequested_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666412);
			SteamGameServer.NativeMethodInfoPtr_SetMaxPlayerCount_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666413);
			SteamGameServer.NativeMethodInfoPtr_SetBotPlayerCount_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666414);
			SteamGameServer.NativeMethodInfoPtr_SetServerName_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666415);
			SteamGameServer.NativeMethodInfoPtr_SetMapName_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666416);
			SteamGameServer.NativeMethodInfoPtr_SetPasswordProtected_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666417);
			SteamGameServer.NativeMethodInfoPtr_SetSpectatorPort_Public_Static_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666418);
			SteamGameServer.NativeMethodInfoPtr_SetSpectatorServerName_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666419);
			SteamGameServer.NativeMethodInfoPtr_ClearAllKeyValues_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666420);
			SteamGameServer.NativeMethodInfoPtr_SetKeyValue_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666421);
			SteamGameServer.NativeMethodInfoPtr_SetGameTags_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666422);
			SteamGameServer.NativeMethodInfoPtr_SetGameData_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666423);
			SteamGameServer.NativeMethodInfoPtr_SetRegion_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666424);
			SteamGameServer.NativeMethodInfoPtr_SendUserConnectAndAuthenticate_Public_Static_Boolean_UInt32_Il2CppStructArray_1_Byte_UInt32_byref_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666425);
			SteamGameServer.NativeMethodInfoPtr_CreateUnauthenticatedUserConnection_Public_Static_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666426);
			SteamGameServer.NativeMethodInfoPtr_SendUserDisconnect_Public_Static_Void_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666427);
			SteamGameServer.NativeMethodInfoPtr_BUpdateUserData_Public_Static_Boolean_CSteamID_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666428);
			SteamGameServer.NativeMethodInfoPtr_GetAuthSessionTicket_Public_Static_HAuthTicket_Il2CppStructArray_1_Byte_Int32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666429);
			SteamGameServer.NativeMethodInfoPtr_BeginAuthSession_Public_Static_EBeginAuthSessionResult_Il2CppStructArray_1_Byte_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666430);
			SteamGameServer.NativeMethodInfoPtr_EndAuthSession_Public_Static_Void_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666431);
			SteamGameServer.NativeMethodInfoPtr_CancelAuthTicket_Public_Static_Void_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666432);
			SteamGameServer.NativeMethodInfoPtr_UserHasLicenseForApp_Public_Static_EUserHasLicenseForAppResult_CSteamID_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666433);
			SteamGameServer.NativeMethodInfoPtr_RequestUserGroupStatus_Public_Static_Boolean_CSteamID_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666434);
			SteamGameServer.NativeMethodInfoPtr_GetGameplayStats_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666435);
			SteamGameServer.NativeMethodInfoPtr_GetServerReputation_Public_Static_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666436);
			SteamGameServer.NativeMethodInfoPtr_GetPublicIP_Public_Static_SteamIPAddress_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666437);
			SteamGameServer.NativeMethodInfoPtr_HandleIncomingPacket_Public_Static_Boolean_Il2CppStructArray_1_Byte_Int32_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666438);
			SteamGameServer.NativeMethodInfoPtr_GetNextOutgoingPacket_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_byref_UInt32_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666439);
			SteamGameServer.NativeMethodInfoPtr_EnableHeartbeats_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666440);
			SteamGameServer.NativeMethodInfoPtr_SetHeartbeatInterval_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666441);
			SteamGameServer.NativeMethodInfoPtr_ForceHeartbeat_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666442);
			SteamGameServer.NativeMethodInfoPtr_AssociateWithClan_Public_Static_SteamAPICall_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666443);
			SteamGameServer.NativeMethodInfoPtr_ComputeNewPlayerCompatibility_Public_Static_SteamAPICall_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100666444);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x0006E500 File Offset: 0x0006C700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196149, XrefRangeEnd = 196161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetProduct(string pszProduct)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszProduct);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_SetProduct_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x0006E538 File Offset: 0x0006C738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196161, XrefRangeEnd = 196173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGameDescription(string pszGameDescription)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszGameDescription);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_SetGameDescription_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0006E570 File Offset: 0x0006C770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196173, XrefRangeEnd = 196185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetModDir(string pszModDir)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszModDir);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_SetModDir_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x0006E5A8 File Offset: 0x0006C7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196185, XrefRangeEnd = 196189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDedicatedServer(bool bDedicated)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bDedicated;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_SetDedicatedServer_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x0006E5DC File Offset: 0x0006C7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196189, XrefRangeEnd = 196201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogOn(string pszToken)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszToken);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_LogOn_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x0006E614 File Offset: 0x0006C814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196201, XrefRangeEnd = 196205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogOnAnonymous()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_LogOnAnonymous_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x0006E63C File Offset: 0x0006C83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196205, XrefRangeEnd = 196209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogOff()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_LogOff_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0006E664 File Offset: 0x0006C864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196209, XrefRangeEnd = 196213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BLoggedOn()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_BLoggedOn_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x0006E694 File Offset: 0x0006C894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196213, XrefRangeEnd = 196217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BSecure()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_BSecure_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x0006E6C4 File Offset: 0x0006C8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196217, XrefRangeEnd = 196225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CSteamID GetSteamID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_GetSteamID_Public_Static_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x0006E6F4 File Offset: 0x0006C8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196225, XrefRangeEnd = 196229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool WasRestartRequested()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_WasRestartRequested_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x0006E724 File Offset: 0x0006C924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196229, XrefRangeEnd = 196233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMaxPlayerCount(int cPlayersMax)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cPlayersMax;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_SetMaxPlayerCount_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x0006E758 File Offset: 0x0006C958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196233, XrefRangeEnd = 196237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetBotPlayerCount(int cBotplayers)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cBotplayers;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_SetBotPlayerCount_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x0006E78C File Offset: 0x0006C98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196237, XrefRangeEnd = 196249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetServerName(string pszServerName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszServerName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_SetServerName_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x0006E7C4 File Offset: 0x0006C9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196249, XrefRangeEnd = 196261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMapName(string pszMapName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszMapName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_SetMapName_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x0006E7FC File Offset: 0x0006C9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196261, XrefRangeEnd = 196265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPasswordProtected(bool bPasswordProtected)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bPasswordProtected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_SetPasswordProtected_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x0006E830 File Offset: 0x0006CA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196265, XrefRangeEnd = 196269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSpectatorPort(ushort unSpectatorPort)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unSpectatorPort;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_SetSpectatorPort_Public_Static_Void_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0006E864 File Offset: 0x0006CA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196269, XrefRangeEnd = 196281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSpectatorServerName(string pszSpectatorServerName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszSpectatorServerName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_SetSpectatorServerName_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x0006E89C File Offset: 0x0006CA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196281, XrefRangeEnd = 196285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearAllKeyValues()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_ClearAllKeyValues_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x0006E8C4 File Offset: 0x0006CAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196285, XrefRangeEnd = 196304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetKeyValue(string pKey, string pValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_SetKeyValue_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x0006E90C File Offset: 0x0006CB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196304, XrefRangeEnd = 196316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGameTags(string pchGameTags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchGameTags);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_SetGameTags_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x0006E944 File Offset: 0x0006CB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196316, XrefRangeEnd = 196328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGameData(string pchGameData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchGameData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_SetGameData_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x0006E97C File Offset: 0x0006CB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196328, XrefRangeEnd = 196340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRegion(string pszRegion)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszRegion);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_SetRegion_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x0006E9B4 File Offset: 0x0006CBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196340, XrefRangeEnd = 196344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SendUserConnectAndAuthenticate(uint unIPClient, Il2CppStructArray<byte> pvAuthBlob, uint cubAuthBlobSize, out CSteamID pSteamIDUser)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIPClient;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pvAuthBlob);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubAuthBlobSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pSteamIDUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_SendUserConnectAndAuthenticate_Public_Static_Boolean_UInt32_Il2CppStructArray_1_Byte_UInt32_byref_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x0006EA20 File Offset: 0x0006CC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196344, XrefRangeEnd = 196352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CSteamID CreateUnauthenticatedUserConnection()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_CreateUnauthenticatedUserConnection_Public_Static_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x0006EA50 File Offset: 0x0006CC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196352, XrefRangeEnd = 196356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendUserDisconnect(CSteamID steamIDUser)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_SendUserDisconnect_Public_Static_Void_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x0006EA84 File Offset: 0x0006CC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196356, XrefRangeEnd = 196368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, uint uScore)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchPlayerName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uScore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_BUpdateUserData_Public_Static_Boolean_CSteamID_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x0006EAE4 File Offset: 0x0006CCE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196368, XrefRangeEnd = 196376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HAuthTicket GetAuthSessionTicket(Il2CppStructArray<byte> pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pTicket);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbMaxTicket;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcbTicket;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_GetAuthSessionTicket_Public_Static_HAuthTicket_Il2CppStructArray_1_Byte_Int32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x0006EB44 File Offset: 0x0006CD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196376, XrefRangeEnd = 196380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EBeginAuthSessionResult BeginAuthSession(Il2CppStructArray<byte> pAuthTicket, int cbAuthTicket, CSteamID steamID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pAuthTicket);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbAuthTicket;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_BeginAuthSession_Public_Static_EBeginAuthSessionResult_Il2CppStructArray_1_Byte_Int32_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x0006EBA4 File Offset: 0x0006CDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196380, XrefRangeEnd = 196384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndAuthSession(CSteamID steamID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_EndAuthSession_Public_Static_Void_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x0006EBD8 File Offset: 0x0006CDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196384, XrefRangeEnd = 196388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hAuthTicket;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_CancelAuthTicket_Public_Static_Void_HAuthTicket_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x0006EC0C File Offset: 0x0006CE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196388, XrefRangeEnd = 196392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_UserHasLicenseForApp_Public_Static_EUserHasLicenseForAppResult_CSteamID_AppId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x0006EC58 File Offset: 0x0006CE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196392, XrefRangeEnd = 196396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDGroup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_RequestUserGroupStatus_Public_Static_Boolean_CSteamID_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x0006ECA4 File Offset: 0x0006CEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196396, XrefRangeEnd = 196400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetGameplayStats()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_GetGameplayStats_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x0006ECCC File Offset: 0x0006CECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196400, XrefRangeEnd = 196407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t GetServerReputation()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_GetServerReputation_Public_Static_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x0006ECFC File Offset: 0x0006CEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196407, XrefRangeEnd = 196411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamIPAddress_t GetPublicIP()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_GetPublicIP_Public_Static_SteamIPAddress_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x0006ED2C File Offset: 0x0006CF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196411, XrefRangeEnd = 196415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HandleIncomingPacket(Il2CppStructArray<byte> pData, int cbData, uint srcIP, ushort srcPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcIP;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_HandleIncomingPacket_Public_Static_Boolean_Il2CppStructArray_1_Byte_Int32_UInt32_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x0006ED98 File Offset: 0x0006CF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196415, XrefRangeEnd = 196419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNextOutgoingPacket(Il2CppStructArray<byte> pOut, int cbMaxOut, out uint pNetAdr, out ushort pPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pOut);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbMaxOut;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pNetAdr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_GetNextOutgoingPacket_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_byref_UInt32_byref_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x0006EE04 File Offset: 0x0006D004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196419, XrefRangeEnd = 196423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnableHeartbeats(bool bActive)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bActive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_EnableHeartbeats_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x0006EE38 File Offset: 0x0006D038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196423, XrefRangeEnd = 196427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetHeartbeatInterval(int iHeartbeatInterval)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iHeartbeatInterval;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_SetHeartbeatInterval_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x0006EE6C File Offset: 0x0006D06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196427, XrefRangeEnd = 196431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForceHeartbeat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_ForceHeartbeat_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x0006EE94 File Offset: 0x0006D094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196431, XrefRangeEnd = 196438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t AssociateWithClan(CSteamID steamIDClan)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_AssociateWithClan_Public_Static_SteamAPICall_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x0006EED4 File Offset: 0x0006D0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196438, XrefRangeEnd = 196445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t ComputeNewPlayerCompatibility(CSteamID steamIDNewPlayer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDNewPlayer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_ComputeNewPlayerCompatibility_Public_Static_SteamAPICall_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x0000BA15 File Offset: 0x00009C15
		public SteamGameServer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeMethodInfoPtr_SetProduct_Public_Static_Void_String_0;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeMethodInfoPtr_SetGameDescription_Public_Static_Void_String_0;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeMethodInfoPtr_SetModDir_Public_Static_Void_String_0;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeMethodInfoPtr_SetDedicatedServer_Public_Static_Void_Boolean_0;

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeMethodInfoPtr_LogOn_Public_Static_Void_String_0;

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeMethodInfoPtr_LogOnAnonymous_Public_Static_Void_0;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeMethodInfoPtr_LogOff_Public_Static_Void_0;

		// Token: 0x040012F5 RID: 4853
		private static readonly IntPtr NativeMethodInfoPtr_BLoggedOn_Public_Static_Boolean_0;

		// Token: 0x040012F6 RID: 4854
		private static readonly IntPtr NativeMethodInfoPtr_BSecure_Public_Static_Boolean_0;

		// Token: 0x040012F7 RID: 4855
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamID_Public_Static_CSteamID_0;

		// Token: 0x040012F8 RID: 4856
		private static readonly IntPtr NativeMethodInfoPtr_WasRestartRequested_Public_Static_Boolean_0;

		// Token: 0x040012F9 RID: 4857
		private static readonly IntPtr NativeMethodInfoPtr_SetMaxPlayerCount_Public_Static_Void_Int32_0;

		// Token: 0x040012FA RID: 4858
		private static readonly IntPtr NativeMethodInfoPtr_SetBotPlayerCount_Public_Static_Void_Int32_0;

		// Token: 0x040012FB RID: 4859
		private static readonly IntPtr NativeMethodInfoPtr_SetServerName_Public_Static_Void_String_0;

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeMethodInfoPtr_SetMapName_Public_Static_Void_String_0;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeMethodInfoPtr_SetPasswordProtected_Public_Static_Void_Boolean_0;

		// Token: 0x040012FE RID: 4862
		private static readonly IntPtr NativeMethodInfoPtr_SetSpectatorPort_Public_Static_Void_UInt16_0;

		// Token: 0x040012FF RID: 4863
		private static readonly IntPtr NativeMethodInfoPtr_SetSpectatorServerName_Public_Static_Void_String_0;

		// Token: 0x04001300 RID: 4864
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllKeyValues_Public_Static_Void_0;

		// Token: 0x04001301 RID: 4865
		private static readonly IntPtr NativeMethodInfoPtr_SetKeyValue_Public_Static_Void_String_String_0;

		// Token: 0x04001302 RID: 4866
		private static readonly IntPtr NativeMethodInfoPtr_SetGameTags_Public_Static_Void_String_0;

		// Token: 0x04001303 RID: 4867
		private static readonly IntPtr NativeMethodInfoPtr_SetGameData_Public_Static_Void_String_0;

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeMethodInfoPtr_SetRegion_Public_Static_Void_String_0;

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeMethodInfoPtr_SendUserConnectAndAuthenticate_Public_Static_Boolean_UInt32_Il2CppStructArray_1_Byte_UInt32_byref_CSteamID_0;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeMethodInfoPtr_CreateUnauthenticatedUserConnection_Public_Static_CSteamID_0;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeMethodInfoPtr_SendUserDisconnect_Public_Static_Void_CSteamID_0;

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeMethodInfoPtr_BUpdateUserData_Public_Static_Boolean_CSteamID_String_UInt32_0;

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeMethodInfoPtr_GetAuthSessionTicket_Public_Static_HAuthTicket_Il2CppStructArray_1_Byte_Int32_byref_UInt32_0;

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeMethodInfoPtr_BeginAuthSession_Public_Static_EBeginAuthSessionResult_Il2CppStructArray_1_Byte_Int32_CSteamID_0;

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeMethodInfoPtr_EndAuthSession_Public_Static_Void_CSteamID_0;

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeMethodInfoPtr_CancelAuthTicket_Public_Static_Void_HAuthTicket_0;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeMethodInfoPtr_UserHasLicenseForApp_Public_Static_EUserHasLicenseForAppResult_CSteamID_AppId_t_0;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeMethodInfoPtr_RequestUserGroupStatus_Public_Static_Boolean_CSteamID_CSteamID_0;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeMethodInfoPtr_GetGameplayStats_Public_Static_Void_0;

		// Token: 0x04001310 RID: 4880
		private static readonly IntPtr NativeMethodInfoPtr_GetServerReputation_Public_Static_SteamAPICall_t_0;

		// Token: 0x04001311 RID: 4881
		private static readonly IntPtr NativeMethodInfoPtr_GetPublicIP_Public_Static_SteamIPAddress_t_0;

		// Token: 0x04001312 RID: 4882
		private static readonly IntPtr NativeMethodInfoPtr_HandleIncomingPacket_Public_Static_Boolean_Il2CppStructArray_1_Byte_Int32_UInt32_UInt16_0;

		// Token: 0x04001313 RID: 4883
		private static readonly IntPtr NativeMethodInfoPtr_GetNextOutgoingPacket_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_byref_UInt32_byref_UInt16_0;

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeMethodInfoPtr_EnableHeartbeats_Public_Static_Void_Boolean_0;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeMethodInfoPtr_SetHeartbeatInterval_Public_Static_Void_Int32_0;

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeMethodInfoPtr_ForceHeartbeat_Public_Static_Void_0;

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeMethodInfoPtr_AssociateWithClan_Public_Static_SteamAPICall_t_CSteamID_0;

		// Token: 0x04001318 RID: 4888
		private static readonly IntPtr NativeMethodInfoPtr_ComputeNewPlayerCompatibility_Public_Static_SteamAPICall_t_CSteamID_0;
	}
}

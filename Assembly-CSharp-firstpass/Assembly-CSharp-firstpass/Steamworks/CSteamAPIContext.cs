using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002CB RID: 715
	public static class CSteamAPIContext : Object
	{
		// Token: 0x060028DC RID: 10460 RVA: 0x000B0C54 File Offset: 0x000AEE54
		// Note: this type is marked as 'beforefieldinit'.
		static CSteamAPIContext()
		{
			Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CSteamAPIContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr);
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamClient");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamUser");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamFriends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamFriends");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUtils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamUtils");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMatchmaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamMatchmaking");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUserStats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamUserStats");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamApps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamApps");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMatchmakingServers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamMatchmakingServers");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamNetworking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamNetworking");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamRemoteStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamRemoteStorage");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamScreenshots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamScreenshots");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamGameSearch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamGameSearch");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamHTTP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamHTTP");
			CSteamAPIContext.NativeFieldInfoPtr_m_pController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pController");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUGC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamUGC");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamAppList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamAppList");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamMusic");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMusicRemote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamMusicRemote");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamHTMLSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamHTMLSurface");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamInventory");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamVideo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamVideo");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamParentalSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamParentalSettings");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamInput");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamParties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamParties");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamRemotePlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamRemotePlay");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamNetworkingUtils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamNetworkingUtils");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamNetworkingSockets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamNetworkingSockets");
			CSteamAPIContext.NativeFieldInfoPtr_m_pSteamNetworkingMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, "m_pSteamNetworkingMessages");
			CSteamAPIContext.NativeMethodInfoPtr_Clear_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668510);
			CSteamAPIContext.NativeMethodInfoPtr_Init_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668511);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamClient_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668512);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamUser_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668513);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamFriends_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668514);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamUtils_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668515);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamMatchmaking_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668516);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamUserStats_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668517);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamApps_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668518);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamMatchmakingServers_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668519);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamNetworking_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668520);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamRemoteStorage_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668521);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamScreenshots_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668522);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamGameSearch_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668523);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamHTTP_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668524);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamController_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668525);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamUGC_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668526);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamAppList_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668527);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamMusic_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668528);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamMusicRemote_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668529);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamHTMLSurface_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668530);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamInventory_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668531);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamVideo_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668532);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamParentalSettings_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668533);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamInput_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668534);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamParties_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668535);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamRemotePlay_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668536);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamNetworkingUtils_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668537);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamNetworkingSockets_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668538);
			CSteamAPIContext.NativeMethodInfoPtr_GetSteamNetworkingMessages_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSteamAPIContext>.NativeClassPtr, 100668539);
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x000B110C File Offset: 0x000AF30C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209908, RefRangeEnd = 209909, XrefRangeStart = 209877, XrefRangeEnd = 209908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_Clear_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x000B1134 File Offset: 0x000AF334
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210113, RefRangeEnd = 210115, XrefRangeStart = 209909, XrefRangeEnd = 210113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_Init_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x000B1164 File Offset: 0x000AF364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210115, XrefRangeEnd = 210117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamClient()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamClient_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x000B1194 File Offset: 0x000AF394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210117, XrefRangeEnd = 210119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamUser()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamUser_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x000B11C4 File Offset: 0x000AF3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210119, XrefRangeEnd = 210121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamFriends()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamFriends_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x000B11F4 File Offset: 0x000AF3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210121, XrefRangeEnd = 210123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamUtils()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamUtils_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x000B1224 File Offset: 0x000AF424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210123, XrefRangeEnd = 210125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamMatchmaking()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamMatchmaking_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x000B1254 File Offset: 0x000AF454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210125, XrefRangeEnd = 210127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamUserStats()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamUserStats_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x000B1284 File Offset: 0x000AF484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210127, XrefRangeEnd = 210129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamApps()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamApps_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x000B12B4 File Offset: 0x000AF4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210129, XrefRangeEnd = 210131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamMatchmakingServers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamMatchmakingServers_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x000B12E4 File Offset: 0x000AF4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210131, XrefRangeEnd = 210133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamNetworking()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamNetworking_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x000B1314 File Offset: 0x000AF514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210133, XrefRangeEnd = 210135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamRemoteStorage()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamRemoteStorage_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x000B1344 File Offset: 0x000AF544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210135, XrefRangeEnd = 210137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamScreenshots()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamScreenshots_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x000B1374 File Offset: 0x000AF574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210137, XrefRangeEnd = 210139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamGameSearch()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamGameSearch_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x000B13A4 File Offset: 0x000AF5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210139, XrefRangeEnd = 210141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamHTTP()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamHTTP_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x000B13D4 File Offset: 0x000AF5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210141, XrefRangeEnd = 210143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamController()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamController_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x000B1404 File Offset: 0x000AF604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210143, XrefRangeEnd = 210145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamUGC()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamUGC_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x000B1434 File Offset: 0x000AF634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210145, XrefRangeEnd = 210147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamAppList()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamAppList_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x000B1464 File Offset: 0x000AF664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210147, XrefRangeEnd = 210149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamMusic()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamMusic_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x000B1494 File Offset: 0x000AF694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210149, XrefRangeEnd = 210151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamMusicRemote()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamMusicRemote_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x000B14C4 File Offset: 0x000AF6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210151, XrefRangeEnd = 210153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamHTMLSurface()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamHTMLSurface_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x000B14F4 File Offset: 0x000AF6F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210153, XrefRangeEnd = 210155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamInventory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamInventory_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x000B1524 File Offset: 0x000AF724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210155, XrefRangeEnd = 210157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamVideo()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamVideo_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x000B1554 File Offset: 0x000AF754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210157, XrefRangeEnd = 210159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamParentalSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamParentalSettings_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x000B1584 File Offset: 0x000AF784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210159, XrefRangeEnd = 210161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamInput()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamInput_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x000B15B4 File Offset: 0x000AF7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210161, XrefRangeEnd = 210163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamParties()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamParties_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x000B15E4 File Offset: 0x000AF7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210163, XrefRangeEnd = 210165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamRemotePlay()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamRemotePlay_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x000B1614 File Offset: 0x000AF814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210165, XrefRangeEnd = 210167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamNetworkingUtils()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamNetworkingUtils_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x000B1644 File Offset: 0x000AF844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210167, XrefRangeEnd = 210169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamNetworkingSockets()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamNetworkingSockets_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x000B1674 File Offset: 0x000AF874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210169, XrefRangeEnd = 210171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetSteamNetworkingMessages()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSteamAPIContext.NativeMethodInfoPtr_GetSteamNetworkingMessages_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x00010830 File Offset: 0x0000EA30
		public CSteamAPIContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x060028FC RID: 10492 RVA: 0x000B16A4 File Offset: 0x000AF8A4
		// (set) Token: 0x060028FD RID: 10493 RVA: 0x00010839 File Offset: 0x0000EA39
		public unsafe static IntPtr m_pSteamClient
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamClient, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamClient, (void*)(&value));
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x060028FE RID: 10494 RVA: 0x000B16C0 File Offset: 0x000AF8C0
		// (set) Token: 0x060028FF RID: 10495 RVA: 0x00010847 File Offset: 0x0000EA47
		public unsafe static IntPtr m_pSteamUser
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUser, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUser, (void*)(&value));
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06002900 RID: 10496 RVA: 0x000B16DC File Offset: 0x000AF8DC
		// (set) Token: 0x06002901 RID: 10497 RVA: 0x00010855 File Offset: 0x0000EA55
		public unsafe static IntPtr m_pSteamFriends
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamFriends, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamFriends, (void*)(&value));
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06002902 RID: 10498 RVA: 0x000B16F8 File Offset: 0x000AF8F8
		// (set) Token: 0x06002903 RID: 10499 RVA: 0x00010863 File Offset: 0x0000EA63
		public unsafe static IntPtr m_pSteamUtils
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUtils, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUtils, (void*)(&value));
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06002904 RID: 10500 RVA: 0x000B1714 File Offset: 0x000AF914
		// (set) Token: 0x06002905 RID: 10501 RVA: 0x00010871 File Offset: 0x0000EA71
		public unsafe static IntPtr m_pSteamMatchmaking
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMatchmaking, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMatchmaking, (void*)(&value));
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06002906 RID: 10502 RVA: 0x000B1730 File Offset: 0x000AF930
		// (set) Token: 0x06002907 RID: 10503 RVA: 0x0001087F File Offset: 0x0000EA7F
		public unsafe static IntPtr m_pSteamUserStats
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUserStats, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUserStats, (void*)(&value));
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06002908 RID: 10504 RVA: 0x000B174C File Offset: 0x000AF94C
		// (set) Token: 0x06002909 RID: 10505 RVA: 0x0001088D File Offset: 0x0000EA8D
		public unsafe static IntPtr m_pSteamApps
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamApps, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamApps, (void*)(&value));
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x0600290A RID: 10506 RVA: 0x000B1768 File Offset: 0x000AF968
		// (set) Token: 0x0600290B RID: 10507 RVA: 0x0001089B File Offset: 0x0000EA9B
		public unsafe static IntPtr m_pSteamMatchmakingServers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMatchmakingServers, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMatchmakingServers, (void*)(&value));
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x0600290C RID: 10508 RVA: 0x000B1784 File Offset: 0x000AF984
		// (set) Token: 0x0600290D RID: 10509 RVA: 0x000108A9 File Offset: 0x0000EAA9
		public unsafe static IntPtr m_pSteamNetworking
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamNetworking, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamNetworking, (void*)(&value));
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x0600290E RID: 10510 RVA: 0x000B17A0 File Offset: 0x000AF9A0
		// (set) Token: 0x0600290F RID: 10511 RVA: 0x000108B7 File Offset: 0x0000EAB7
		public unsafe static IntPtr m_pSteamRemoteStorage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamRemoteStorage, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamRemoteStorage, (void*)(&value));
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06002910 RID: 10512 RVA: 0x000B17BC File Offset: 0x000AF9BC
		// (set) Token: 0x06002911 RID: 10513 RVA: 0x000108C5 File Offset: 0x0000EAC5
		public unsafe static IntPtr m_pSteamScreenshots
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamScreenshots, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamScreenshots, (void*)(&value));
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06002912 RID: 10514 RVA: 0x000B17D8 File Offset: 0x000AF9D8
		// (set) Token: 0x06002913 RID: 10515 RVA: 0x000108D3 File Offset: 0x0000EAD3
		public unsafe static IntPtr m_pSteamGameSearch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamGameSearch, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamGameSearch, (void*)(&value));
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06002914 RID: 10516 RVA: 0x000B17F4 File Offset: 0x000AF9F4
		// (set) Token: 0x06002915 RID: 10517 RVA: 0x000108E1 File Offset: 0x0000EAE1
		public unsafe static IntPtr m_pSteamHTTP
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamHTTP, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamHTTP, (void*)(&value));
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06002916 RID: 10518 RVA: 0x000B1810 File Offset: 0x000AFA10
		// (set) Token: 0x06002917 RID: 10519 RVA: 0x000108EF File Offset: 0x0000EAEF
		public unsafe static IntPtr m_pController
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pController, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pController, (void*)(&value));
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06002918 RID: 10520 RVA: 0x000B182C File Offset: 0x000AFA2C
		// (set) Token: 0x06002919 RID: 10521 RVA: 0x000108FD File Offset: 0x0000EAFD
		public unsafe static IntPtr m_pSteamUGC
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUGC, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamUGC, (void*)(&value));
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x0600291A RID: 10522 RVA: 0x000B1848 File Offset: 0x000AFA48
		// (set) Token: 0x0600291B RID: 10523 RVA: 0x0001090B File Offset: 0x0000EB0B
		public unsafe static IntPtr m_pSteamAppList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamAppList, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamAppList, (void*)(&value));
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x0600291C RID: 10524 RVA: 0x000B1864 File Offset: 0x000AFA64
		// (set) Token: 0x0600291D RID: 10525 RVA: 0x00010919 File Offset: 0x0000EB19
		public unsafe static IntPtr m_pSteamMusic
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMusic, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMusic, (void*)(&value));
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x0600291E RID: 10526 RVA: 0x000B1880 File Offset: 0x000AFA80
		// (set) Token: 0x0600291F RID: 10527 RVA: 0x00010927 File Offset: 0x0000EB27
		public unsafe static IntPtr m_pSteamMusicRemote
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMusicRemote, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamMusicRemote, (void*)(&value));
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06002920 RID: 10528 RVA: 0x000B189C File Offset: 0x000AFA9C
		// (set) Token: 0x06002921 RID: 10529 RVA: 0x00010935 File Offset: 0x0000EB35
		public unsafe static IntPtr m_pSteamHTMLSurface
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamHTMLSurface, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamHTMLSurface, (void*)(&value));
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06002922 RID: 10530 RVA: 0x000B18B8 File Offset: 0x000AFAB8
		// (set) Token: 0x06002923 RID: 10531 RVA: 0x00010943 File Offset: 0x0000EB43
		public unsafe static IntPtr m_pSteamInventory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamInventory, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamInventory, (void*)(&value));
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06002924 RID: 10532 RVA: 0x000B18D4 File Offset: 0x000AFAD4
		// (set) Token: 0x06002925 RID: 10533 RVA: 0x00010951 File Offset: 0x0000EB51
		public unsafe static IntPtr m_pSteamVideo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamVideo, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamVideo, (void*)(&value));
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06002926 RID: 10534 RVA: 0x000B18F0 File Offset: 0x000AFAF0
		// (set) Token: 0x06002927 RID: 10535 RVA: 0x0001095F File Offset: 0x0000EB5F
		public unsafe static IntPtr m_pSteamParentalSettings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamParentalSettings, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamParentalSettings, (void*)(&value));
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06002928 RID: 10536 RVA: 0x000B190C File Offset: 0x000AFB0C
		// (set) Token: 0x06002929 RID: 10537 RVA: 0x0001096D File Offset: 0x0000EB6D
		public unsafe static IntPtr m_pSteamInput
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamInput, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamInput, (void*)(&value));
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x0600292A RID: 10538 RVA: 0x000B1928 File Offset: 0x000AFB28
		// (set) Token: 0x0600292B RID: 10539 RVA: 0x0001097B File Offset: 0x0000EB7B
		public unsafe static IntPtr m_pSteamParties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamParties, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamParties, (void*)(&value));
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x0600292C RID: 10540 RVA: 0x000B1944 File Offset: 0x000AFB44
		// (set) Token: 0x0600292D RID: 10541 RVA: 0x00010989 File Offset: 0x0000EB89
		public unsafe static IntPtr m_pSteamRemotePlay
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamRemotePlay, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamRemotePlay, (void*)(&value));
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x0600292E RID: 10542 RVA: 0x000B1960 File Offset: 0x000AFB60
		// (set) Token: 0x0600292F RID: 10543 RVA: 0x00010997 File Offset: 0x0000EB97
		public unsafe static IntPtr m_pSteamNetworkingUtils
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamNetworkingUtils, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamNetworkingUtils, (void*)(&value));
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06002930 RID: 10544 RVA: 0x000B197C File Offset: 0x000AFB7C
		// (set) Token: 0x06002931 RID: 10545 RVA: 0x000109A5 File Offset: 0x0000EBA5
		public unsafe static IntPtr m_pSteamNetworkingSockets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamNetworkingSockets, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamNetworkingSockets, (void*)(&value));
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06002932 RID: 10546 RVA: 0x000B1998 File Offset: 0x000AFB98
		// (set) Token: 0x06002933 RID: 10547 RVA: 0x000109B3 File Offset: 0x0000EBB3
		public unsafe static IntPtr m_pSteamNetworkingMessages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamNetworkingMessages, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CSteamAPIContext.NativeFieldInfoPtr_m_pSteamNetworkingMessages, (void*)(&value));
			}
		}

		// Token: 0x0400279E RID: 10142
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamClient;

		// Token: 0x0400279F RID: 10143
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamUser;

		// Token: 0x040027A0 RID: 10144
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamFriends;

		// Token: 0x040027A1 RID: 10145
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamUtils;

		// Token: 0x040027A2 RID: 10146
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamMatchmaking;

		// Token: 0x040027A3 RID: 10147
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamUserStats;

		// Token: 0x040027A4 RID: 10148
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamApps;

		// Token: 0x040027A5 RID: 10149
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamMatchmakingServers;

		// Token: 0x040027A6 RID: 10150
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamNetworking;

		// Token: 0x040027A7 RID: 10151
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamRemoteStorage;

		// Token: 0x040027A8 RID: 10152
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamScreenshots;

		// Token: 0x040027A9 RID: 10153
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamGameSearch;

		// Token: 0x040027AA RID: 10154
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamHTTP;

		// Token: 0x040027AB RID: 10155
		private static readonly IntPtr NativeFieldInfoPtr_m_pController;

		// Token: 0x040027AC RID: 10156
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamUGC;

		// Token: 0x040027AD RID: 10157
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamAppList;

		// Token: 0x040027AE RID: 10158
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamMusic;

		// Token: 0x040027AF RID: 10159
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamMusicRemote;

		// Token: 0x040027B0 RID: 10160
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamHTMLSurface;

		// Token: 0x040027B1 RID: 10161
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamInventory;

		// Token: 0x040027B2 RID: 10162
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamVideo;

		// Token: 0x040027B3 RID: 10163
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamParentalSettings;

		// Token: 0x040027B4 RID: 10164
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamInput;

		// Token: 0x040027B5 RID: 10165
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamParties;

		// Token: 0x040027B6 RID: 10166
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamRemotePlay;

		// Token: 0x040027B7 RID: 10167
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamNetworkingUtils;

		// Token: 0x040027B8 RID: 10168
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamNetworkingSockets;

		// Token: 0x040027B9 RID: 10169
		private static readonly IntPtr NativeFieldInfoPtr_m_pSteamNetworkingMessages;

		// Token: 0x040027BA RID: 10170
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Static_Void_0;

		// Token: 0x040027BB RID: 10171
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Static_Boolean_0;

		// Token: 0x040027BC RID: 10172
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamClient_Internal_Static_IntPtr_0;

		// Token: 0x040027BD RID: 10173
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamUser_Internal_Static_IntPtr_0;

		// Token: 0x040027BE RID: 10174
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamFriends_Internal_Static_IntPtr_0;

		// Token: 0x040027BF RID: 10175
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamUtils_Internal_Static_IntPtr_0;

		// Token: 0x040027C0 RID: 10176
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamMatchmaking_Internal_Static_IntPtr_0;

		// Token: 0x040027C1 RID: 10177
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamUserStats_Internal_Static_IntPtr_0;

		// Token: 0x040027C2 RID: 10178
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamApps_Internal_Static_IntPtr_0;

		// Token: 0x040027C3 RID: 10179
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamMatchmakingServers_Internal_Static_IntPtr_0;

		// Token: 0x040027C4 RID: 10180
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamNetworking_Internal_Static_IntPtr_0;

		// Token: 0x040027C5 RID: 10181
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamRemoteStorage_Internal_Static_IntPtr_0;

		// Token: 0x040027C6 RID: 10182
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamScreenshots_Internal_Static_IntPtr_0;

		// Token: 0x040027C7 RID: 10183
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamGameSearch_Internal_Static_IntPtr_0;

		// Token: 0x040027C8 RID: 10184
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamHTTP_Internal_Static_IntPtr_0;

		// Token: 0x040027C9 RID: 10185
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamController_Internal_Static_IntPtr_0;

		// Token: 0x040027CA RID: 10186
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamUGC_Internal_Static_IntPtr_0;

		// Token: 0x040027CB RID: 10187
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamAppList_Internal_Static_IntPtr_0;

		// Token: 0x040027CC RID: 10188
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamMusic_Internal_Static_IntPtr_0;

		// Token: 0x040027CD RID: 10189
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamMusicRemote_Internal_Static_IntPtr_0;

		// Token: 0x040027CE RID: 10190
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamHTMLSurface_Internal_Static_IntPtr_0;

		// Token: 0x040027CF RID: 10191
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamInventory_Internal_Static_IntPtr_0;

		// Token: 0x040027D0 RID: 10192
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamVideo_Internal_Static_IntPtr_0;

		// Token: 0x040027D1 RID: 10193
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamParentalSettings_Internal_Static_IntPtr_0;

		// Token: 0x040027D2 RID: 10194
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamInput_Internal_Static_IntPtr_0;

		// Token: 0x040027D3 RID: 10195
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamParties_Internal_Static_IntPtr_0;

		// Token: 0x040027D4 RID: 10196
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamRemotePlay_Internal_Static_IntPtr_0;

		// Token: 0x040027D5 RID: 10197
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamNetworkingUtils_Internal_Static_IntPtr_0;

		// Token: 0x040027D6 RID: 10198
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamNetworkingSockets_Internal_Static_IntPtr_0;

		// Token: 0x040027D7 RID: 10199
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamNetworkingMessages_Internal_Static_IntPtr_0;
	}
}

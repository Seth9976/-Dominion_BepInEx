using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200014E RID: 334
	public static class SteamGameServerApps : Object
	{
		// Token: 0x0600190D RID: 6413 RVA: 0x0006EF14 File Offset: 0x0006D114
		// Note: this type is marked as 'beforefieldinit'.
		static SteamGameServerApps()
		{
			Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamGameServerApps");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr);
			SteamGameServerApps.NativeMethodInfoPtr_BIsSubscribed_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666445);
			SteamGameServerApps.NativeMethodInfoPtr_BIsLowViolence_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666446);
			SteamGameServerApps.NativeMethodInfoPtr_BIsCybercafe_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666447);
			SteamGameServerApps.NativeMethodInfoPtr_BIsVACBanned_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666448);
			SteamGameServerApps.NativeMethodInfoPtr_GetCurrentGameLanguage_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666449);
			SteamGameServerApps.NativeMethodInfoPtr_GetAvailableGameLanguages_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666450);
			SteamGameServerApps.NativeMethodInfoPtr_BIsSubscribedApp_Public_Static_Boolean_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666451);
			SteamGameServerApps.NativeMethodInfoPtr_BIsDlcInstalled_Public_Static_Boolean_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666452);
			SteamGameServerApps.NativeMethodInfoPtr_GetEarliestPurchaseUnixTime_Public_Static_UInt32_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666453);
			SteamGameServerApps.NativeMethodInfoPtr_BIsSubscribedFromFreeWeekend_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666454);
			SteamGameServerApps.NativeMethodInfoPtr_GetDLCCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666455);
			SteamGameServerApps.NativeMethodInfoPtr_BGetDLCDataByIndex_Public_Static_Boolean_Int32_byref_AppId_t_byref_Boolean_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666456);
			SteamGameServerApps.NativeMethodInfoPtr_InstallDLC_Public_Static_Void_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666457);
			SteamGameServerApps.NativeMethodInfoPtr_UninstallDLC_Public_Static_Void_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666458);
			SteamGameServerApps.NativeMethodInfoPtr_RequestAppProofOfPurchaseKey_Public_Static_Void_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666459);
			SteamGameServerApps.NativeMethodInfoPtr_GetCurrentBetaName_Public_Static_Boolean_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666460);
			SteamGameServerApps.NativeMethodInfoPtr_MarkContentCorrupt_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666461);
			SteamGameServerApps.NativeMethodInfoPtr_GetInstalledDepots_Public_Static_UInt32_AppId_t_Il2CppStructArray_1_DepotId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666462);
			SteamGameServerApps.NativeMethodInfoPtr_GetAppInstallDir_Public_Static_UInt32_AppId_t_byref_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666463);
			SteamGameServerApps.NativeMethodInfoPtr_BIsAppInstalled_Public_Static_Boolean_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666464);
			SteamGameServerApps.NativeMethodInfoPtr_GetAppOwner_Public_Static_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666465);
			SteamGameServerApps.NativeMethodInfoPtr_GetLaunchQueryParam_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666466);
			SteamGameServerApps.NativeMethodInfoPtr_GetDlcDownloadProgress_Public_Static_Boolean_AppId_t_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666467);
			SteamGameServerApps.NativeMethodInfoPtr_GetAppBuildId_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666468);
			SteamGameServerApps.NativeMethodInfoPtr_RequestAllProofOfPurchaseKeys_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666469);
			SteamGameServerApps.NativeMethodInfoPtr_GetFileDetails_Public_Static_SteamAPICall_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666470);
			SteamGameServerApps.NativeMethodInfoPtr_GetLaunchCommandLine_Public_Static_Int32_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666471);
			SteamGameServerApps.NativeMethodInfoPtr_BIsSubscribedFromFamilySharing_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666472);
			SteamGameServerApps.NativeMethodInfoPtr_BIsTimedTrial_Public_Static_Boolean_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerApps>.NativeClassPtr, 100666473);
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x0006F188 File Offset: 0x0006D388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196445, XrefRangeEnd = 196449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsSubscribed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_BIsSubscribed_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x0006F1B8 File Offset: 0x0006D3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196449, XrefRangeEnd = 196453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsLowViolence()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_BIsLowViolence_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x0006F1E8 File Offset: 0x0006D3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196453, XrefRangeEnd = 196457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsCybercafe()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_BIsCybercafe_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x0006F218 File Offset: 0x0006D418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196457, XrefRangeEnd = 196461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsVACBanned()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_BIsVACBanned_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x0006F248 File Offset: 0x0006D448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196461, XrefRangeEnd = 196466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCurrentGameLanguage()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_GetCurrentGameLanguage_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x0006F274 File Offset: 0x0006D474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196466, XrefRangeEnd = 196471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAvailableGameLanguages()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_GetAvailableGameLanguages_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x0006F2A0 File Offset: 0x0006D4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196471, XrefRangeEnd = 196475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsSubscribedApp(AppId_t appID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_BIsSubscribedApp_Public_Static_Boolean_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x0006F2E0 File Offset: 0x0006D4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196475, XrefRangeEnd = 196479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsDlcInstalled(AppId_t appID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_BIsDlcInstalled_Public_Static_Boolean_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x0006F320 File Offset: 0x0006D520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196479, XrefRangeEnd = 196483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetEarliestPurchaseUnixTime(AppId_t nAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_GetEarliestPurchaseUnixTime_Public_Static_UInt32_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x0006F360 File Offset: 0x0006D560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196483, XrefRangeEnd = 196487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsSubscribedFromFreeWeekend()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_BIsSubscribedFromFreeWeekend_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0006F390 File Offset: 0x0006D590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196487, XrefRangeEnd = 196491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetDLCCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_GetDLCCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x0006F3C0 File Offset: 0x0006D5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196491, XrefRangeEnd = 196503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BGetDLCDataByIndex(int iDLC, out AppId_t pAppID, out bool pbAvailable, out string pchName, int cchNameBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iDLC;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pAppID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAvailable;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchNameBufferSize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_BGetDLCDataByIndex_Public_Static_Boolean_Int32_byref_AppId_t_byref_Boolean_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x0006F444 File Offset: 0x0006D644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196503, XrefRangeEnd = 196507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallDLC(AppId_t nAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_InstallDLC_Public_Static_Void_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x0006F478 File Offset: 0x0006D678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196507, XrefRangeEnd = 196511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UninstallDLC(AppId_t nAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_UninstallDLC_Public_Static_Void_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x0006F4AC File Offset: 0x0006D6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196511, XrefRangeEnd = 196515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequestAppProofOfPurchaseKey(AppId_t nAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_RequestAppProofOfPurchaseKey_Public_Static_Void_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x0006F4E0 File Offset: 0x0006D6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196515, XrefRangeEnd = 196528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetCurrentBetaName(out string pchName, int cchNameBufferSize)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchNameBufferSize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_GetCurrentBetaName_Public_Static_Boolean_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x0006F538 File Offset: 0x0006D738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196528, XrefRangeEnd = 196532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MarkContentCorrupt(bool bMissingFilesOnly)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bMissingFilesOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_MarkContentCorrupt_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x0006F578 File Offset: 0x0006D778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196532, XrefRangeEnd = 196536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetInstalledDepots(AppId_t appID, Il2CppStructArray<DepotId_t> pvecDepots, uint cMaxDepots)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pvecDepots);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMaxDepots;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_GetInstalledDepots_Public_Static_UInt32_AppId_t_Il2CppStructArray_1_DepotId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x0006F5D8 File Offset: 0x0006D7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196536, XrefRangeEnd = 196548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetAppInstallDir(AppId_t appID, out string pchFolder, uint cchFolderBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appID;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchFolderBufferSize;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_GetAppInstallDir_Public_Static_UInt32_AppId_t_byref_String_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchFolder = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x0006F640 File Offset: 0x0006D840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196548, XrefRangeEnd = 196552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsAppInstalled(AppId_t appID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_BIsAppInstalled_Public_Static_Boolean_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x0006F680 File Offset: 0x0006D880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196552, XrefRangeEnd = 196560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CSteamID GetAppOwner()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_GetAppOwner_Public_Static_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x0006F6B0 File Offset: 0x0006D8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196560, XrefRangeEnd = 196573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLaunchQueryParam(string pchKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_GetLaunchQueryParam_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x0006F6EC File Offset: 0x0006D8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196573, XrefRangeEnd = 196577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDlcDownloadProgress(AppId_t nAppID, out ulong punBytesDownloaded, out ulong punBytesTotal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punBytesDownloaded;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punBytesTotal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_GetDlcDownloadProgress_Public_Static_Boolean_AppId_t_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x0006F748 File Offset: 0x0006D948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196577, XrefRangeEnd = 196581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAppBuildId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_GetAppBuildId_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x0006F778 File Offset: 0x0006D978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196581, XrefRangeEnd = 196585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequestAllProofOfPurchaseKeys()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_RequestAllProofOfPurchaseKeys_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x0006F7A0 File Offset: 0x0006D9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196585, XrefRangeEnd = 196600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t GetFileDetails(string pszFileName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszFileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_GetFileDetails_Public_Static_SteamAPICall_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x0006F7E4 File Offset: 0x0006D9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196600, XrefRangeEnd = 196613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLaunchCommandLine(out string pszCommandLine, int cubCommandLine)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubCommandLine;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_GetLaunchCommandLine_Public_Static_Int32_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pszCommandLine = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x0006F83C File Offset: 0x0006DA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196613, XrefRangeEnd = 196617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsSubscribedFromFamilySharing()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_BIsSubscribedFromFamilySharing_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x0006F86C File Offset: 0x0006DA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196617, XrefRangeEnd = 196621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsTimedTrial(out uint punSecondsAllowed, out uint punSecondsPlayed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &punSecondsAllowed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punSecondsPlayed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerApps.NativeMethodInfoPtr_BIsTimedTrial_Public_Static_Boolean_byref_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x0000BA1E File Offset: 0x00009C1E
		public SteamGameServerApps(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeMethodInfoPtr_BIsSubscribed_Public_Static_Boolean_0;

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeMethodInfoPtr_BIsLowViolence_Public_Static_Boolean_0;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeMethodInfoPtr_BIsCybercafe_Public_Static_Boolean_0;

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeMethodInfoPtr_BIsVACBanned_Public_Static_Boolean_0;

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentGameLanguage_Public_Static_String_0;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeMethodInfoPtr_GetAvailableGameLanguages_Public_Static_String_0;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeMethodInfoPtr_BIsSubscribedApp_Public_Static_Boolean_AppId_t_0;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeMethodInfoPtr_BIsDlcInstalled_Public_Static_Boolean_AppId_t_0;

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeMethodInfoPtr_GetEarliestPurchaseUnixTime_Public_Static_UInt32_AppId_t_0;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeMethodInfoPtr_BIsSubscribedFromFreeWeekend_Public_Static_Boolean_0;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeMethodInfoPtr_GetDLCCount_Public_Static_Int32_0;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeMethodInfoPtr_BGetDLCDataByIndex_Public_Static_Boolean_Int32_byref_AppId_t_byref_Boolean_byref_String_Int32_0;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeMethodInfoPtr_InstallDLC_Public_Static_Void_AppId_t_0;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeMethodInfoPtr_UninstallDLC_Public_Static_Void_AppId_t_0;

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeMethodInfoPtr_RequestAppProofOfPurchaseKey_Public_Static_Void_AppId_t_0;

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentBetaName_Public_Static_Boolean_byref_String_Int32_0;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeMethodInfoPtr_MarkContentCorrupt_Public_Static_Boolean_Boolean_0;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeMethodInfoPtr_GetInstalledDepots_Public_Static_UInt32_AppId_t_Il2CppStructArray_1_DepotId_t_UInt32_0;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeMethodInfoPtr_GetAppInstallDir_Public_Static_UInt32_AppId_t_byref_String_UInt32_0;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeMethodInfoPtr_BIsAppInstalled_Public_Static_Boolean_AppId_t_0;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeMethodInfoPtr_GetAppOwner_Public_Static_CSteamID_0;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeMethodInfoPtr_GetLaunchQueryParam_Public_Static_String_String_0;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeMethodInfoPtr_GetDlcDownloadProgress_Public_Static_Boolean_AppId_t_byref_UInt64_byref_UInt64_0;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeMethodInfoPtr_GetAppBuildId_Public_Static_Int32_0;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeMethodInfoPtr_RequestAllProofOfPurchaseKeys_Public_Static_Void_0;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeMethodInfoPtr_GetFileDetails_Public_Static_SteamAPICall_t_String_0;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeMethodInfoPtr_GetLaunchCommandLine_Public_Static_Int32_byref_String_Int32_0;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr_BIsSubscribedFromFamilySharing_Public_Static_Boolean_0;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr_BIsTimedTrial_Public_Static_Boolean_byref_UInt32_byref_UInt32_0;
	}
}

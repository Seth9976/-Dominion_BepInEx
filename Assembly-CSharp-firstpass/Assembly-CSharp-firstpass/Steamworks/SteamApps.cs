using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000149 RID: 329
	public static class SteamApps : Object
	{
		// Token: 0x0600182A RID: 6186 RVA: 0x0006A2D0 File Offset: 0x000684D0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamApps()
		{
			Il2CppClassPointerStore<SteamApps>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamApps");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamApps>.NativeClassPtr);
			SteamApps.NativeMethodInfoPtr_BIsSubscribed_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666228);
			SteamApps.NativeMethodInfoPtr_BIsLowViolence_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666229);
			SteamApps.NativeMethodInfoPtr_BIsCybercafe_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666230);
			SteamApps.NativeMethodInfoPtr_BIsVACBanned_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666231);
			SteamApps.NativeMethodInfoPtr_GetCurrentGameLanguage_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666232);
			SteamApps.NativeMethodInfoPtr_GetAvailableGameLanguages_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666233);
			SteamApps.NativeMethodInfoPtr_BIsSubscribedApp_Public_Static_Boolean_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666234);
			SteamApps.NativeMethodInfoPtr_BIsDlcInstalled_Public_Static_Boolean_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666235);
			SteamApps.NativeMethodInfoPtr_GetEarliestPurchaseUnixTime_Public_Static_UInt32_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666236);
			SteamApps.NativeMethodInfoPtr_BIsSubscribedFromFreeWeekend_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666237);
			SteamApps.NativeMethodInfoPtr_GetDLCCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666238);
			SteamApps.NativeMethodInfoPtr_BGetDLCDataByIndex_Public_Static_Boolean_Int32_byref_AppId_t_byref_Boolean_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666239);
			SteamApps.NativeMethodInfoPtr_InstallDLC_Public_Static_Void_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666240);
			SteamApps.NativeMethodInfoPtr_UninstallDLC_Public_Static_Void_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666241);
			SteamApps.NativeMethodInfoPtr_RequestAppProofOfPurchaseKey_Public_Static_Void_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666242);
			SteamApps.NativeMethodInfoPtr_GetCurrentBetaName_Public_Static_Boolean_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666243);
			SteamApps.NativeMethodInfoPtr_MarkContentCorrupt_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666244);
			SteamApps.NativeMethodInfoPtr_GetInstalledDepots_Public_Static_UInt32_AppId_t_Il2CppStructArray_1_DepotId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666245);
			SteamApps.NativeMethodInfoPtr_GetAppInstallDir_Public_Static_UInt32_AppId_t_byref_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666246);
			SteamApps.NativeMethodInfoPtr_BIsAppInstalled_Public_Static_Boolean_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666247);
			SteamApps.NativeMethodInfoPtr_GetAppOwner_Public_Static_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666248);
			SteamApps.NativeMethodInfoPtr_GetLaunchQueryParam_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666249);
			SteamApps.NativeMethodInfoPtr_GetDlcDownloadProgress_Public_Static_Boolean_AppId_t_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666250);
			SteamApps.NativeMethodInfoPtr_GetAppBuildId_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666251);
			SteamApps.NativeMethodInfoPtr_RequestAllProofOfPurchaseKeys_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666252);
			SteamApps.NativeMethodInfoPtr_GetFileDetails_Public_Static_SteamAPICall_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666253);
			SteamApps.NativeMethodInfoPtr_GetLaunchCommandLine_Public_Static_Int32_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666254);
			SteamApps.NativeMethodInfoPtr_BIsSubscribedFromFamilySharing_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666255);
			SteamApps.NativeMethodInfoPtr_BIsTimedTrial_Public_Static_Boolean_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamApps>.NativeClassPtr, 100666256);
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x0006A544 File Offset: 0x00068744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194933, XrefRangeEnd = 194937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsSubscribed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_BIsSubscribed_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x0006A574 File Offset: 0x00068774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194937, XrefRangeEnd = 194941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsLowViolence()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_BIsLowViolence_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x0006A5A4 File Offset: 0x000687A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194941, XrefRangeEnd = 194945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsCybercafe()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_BIsCybercafe_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x0006A5D4 File Offset: 0x000687D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194945, XrefRangeEnd = 194949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsVACBanned()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_BIsVACBanned_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x0006A604 File Offset: 0x00068804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194949, XrefRangeEnd = 194954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCurrentGameLanguage()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_GetCurrentGameLanguage_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x0006A630 File Offset: 0x00068830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194954, XrefRangeEnd = 194959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAvailableGameLanguages()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_GetAvailableGameLanguages_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x0006A65C File Offset: 0x0006885C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194959, XrefRangeEnd = 194963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsSubscribedApp(AppId_t appID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_BIsSubscribedApp_Public_Static_Boolean_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x0006A69C File Offset: 0x0006889C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194967, RefRangeEnd = 194968, XrefRangeStart = 194963, XrefRangeEnd = 194967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsDlcInstalled(AppId_t appID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_BIsDlcInstalled_Public_Static_Boolean_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x0006A6DC File Offset: 0x000688DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194968, XrefRangeEnd = 194972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetEarliestPurchaseUnixTime(AppId_t nAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_GetEarliestPurchaseUnixTime_Public_Static_UInt32_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x0006A71C File Offset: 0x0006891C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194972, XrefRangeEnd = 194976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsSubscribedFromFreeWeekend()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_BIsSubscribedFromFreeWeekend_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x0006A74C File Offset: 0x0006894C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194976, XrefRangeEnd = 194980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetDLCCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_GetDLCCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x0006A77C File Offset: 0x0006897C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194980, XrefRangeEnd = 194992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_BGetDLCDataByIndex_Public_Static_Boolean_Int32_byref_AppId_t_byref_Boolean_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x0006A800 File Offset: 0x00068A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194992, XrefRangeEnd = 194996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallDLC(AppId_t nAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_InstallDLC_Public_Static_Void_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x0006A834 File Offset: 0x00068A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194996, XrefRangeEnd = 195000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UninstallDLC(AppId_t nAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_UninstallDLC_Public_Static_Void_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x0006A868 File Offset: 0x00068A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195000, XrefRangeEnd = 195004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequestAppProofOfPurchaseKey(AppId_t nAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_RequestAppProofOfPurchaseKey_Public_Static_Void_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x0006A89C File Offset: 0x00068A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195004, XrefRangeEnd = 195017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_GetCurrentBetaName_Public_Static_Boolean_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x0006A8F4 File Offset: 0x00068AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195017, XrefRangeEnd = 195021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool MarkContentCorrupt(bool bMissingFilesOnly)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bMissingFilesOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_MarkContentCorrupt_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x0006A934 File Offset: 0x00068B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195021, XrefRangeEnd = 195025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_GetInstalledDepots_Public_Static_UInt32_AppId_t_Il2CppStructArray_1_DepotId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x0006A994 File Offset: 0x00068B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195025, XrefRangeEnd = 195037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_GetAppInstallDir_Public_Static_UInt32_AppId_t_byref_String_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchFolder = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x0006A9FC File Offset: 0x00068BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195037, XrefRangeEnd = 195041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsAppInstalled(AppId_t appID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref appID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_BIsAppInstalled_Public_Static_Boolean_AppId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x0006AA3C File Offset: 0x00068C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195041, XrefRangeEnd = 195049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CSteamID GetAppOwner()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_GetAppOwner_Public_Static_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x0006AA6C File Offset: 0x00068C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195049, XrefRangeEnd = 195062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLaunchQueryParam(string pchKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_GetLaunchQueryParam_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x0006AAA8 File Offset: 0x00068CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195062, XrefRangeEnd = 195066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_GetDlcDownloadProgress_Public_Static_Boolean_AppId_t_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0006AB04 File Offset: 0x00068D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195066, XrefRangeEnd = 195070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAppBuildId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_GetAppBuildId_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x0006AB34 File Offset: 0x00068D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195070, XrefRangeEnd = 195074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequestAllProofOfPurchaseKeys()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_RequestAllProofOfPurchaseKeys_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x0006AB5C File Offset: 0x00068D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195074, XrefRangeEnd = 195089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t GetFileDetails(string pszFileName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pszFileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_GetFileDetails_Public_Static_SteamAPICall_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x0006ABA0 File Offset: 0x00068DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195089, XrefRangeEnd = 195102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_GetLaunchCommandLine_Public_Static_Int32_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pszCommandLine = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x0006ABF8 File Offset: 0x00068DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195102, XrefRangeEnd = 195106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsSubscribedFromFamilySharing()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_BIsSubscribedFromFamilySharing_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x0006AC28 File Offset: 0x00068E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195106, XrefRangeEnd = 195110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamApps.NativeMethodInfoPtr_BIsTimedTrial_Public_Static_Boolean_byref_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x0000B9F1 File Offset: 0x00009BF1
		public SteamApps(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeMethodInfoPtr_BIsSubscribed_Public_Static_Boolean_0;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeMethodInfoPtr_BIsLowViolence_Public_Static_Boolean_0;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeMethodInfoPtr_BIsCybercafe_Public_Static_Boolean_0;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeMethodInfoPtr_BIsVACBanned_Public_Static_Boolean_0;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentGameLanguage_Public_Static_String_0;

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeMethodInfoPtr_GetAvailableGameLanguages_Public_Static_String_0;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeMethodInfoPtr_BIsSubscribedApp_Public_Static_Boolean_AppId_t_0;

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeMethodInfoPtr_BIsDlcInstalled_Public_Static_Boolean_AppId_t_0;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr_GetEarliestPurchaseUnixTime_Public_Static_UInt32_AppId_t_0;

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeMethodInfoPtr_BIsSubscribedFromFreeWeekend_Public_Static_Boolean_0;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeMethodInfoPtr_GetDLCCount_Public_Static_Int32_0;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeMethodInfoPtr_BGetDLCDataByIndex_Public_Static_Boolean_Int32_byref_AppId_t_byref_Boolean_byref_String_Int32_0;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeMethodInfoPtr_InstallDLC_Public_Static_Void_AppId_t_0;

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeMethodInfoPtr_UninstallDLC_Public_Static_Void_AppId_t_0;

		// Token: 0x0400124E RID: 4686
		private static readonly IntPtr NativeMethodInfoPtr_RequestAppProofOfPurchaseKey_Public_Static_Void_AppId_t_0;

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentBetaName_Public_Static_Boolean_byref_String_Int32_0;

		// Token: 0x04001250 RID: 4688
		private static readonly IntPtr NativeMethodInfoPtr_MarkContentCorrupt_Public_Static_Boolean_Boolean_0;

		// Token: 0x04001251 RID: 4689
		private static readonly IntPtr NativeMethodInfoPtr_GetInstalledDepots_Public_Static_UInt32_AppId_t_Il2CppStructArray_1_DepotId_t_UInt32_0;

		// Token: 0x04001252 RID: 4690
		private static readonly IntPtr NativeMethodInfoPtr_GetAppInstallDir_Public_Static_UInt32_AppId_t_byref_String_UInt32_0;

		// Token: 0x04001253 RID: 4691
		private static readonly IntPtr NativeMethodInfoPtr_BIsAppInstalled_Public_Static_Boolean_AppId_t_0;

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeMethodInfoPtr_GetAppOwner_Public_Static_CSteamID_0;

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeMethodInfoPtr_GetLaunchQueryParam_Public_Static_String_String_0;

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeMethodInfoPtr_GetDlcDownloadProgress_Public_Static_Boolean_AppId_t_byref_UInt64_byref_UInt64_0;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeMethodInfoPtr_GetAppBuildId_Public_Static_Int32_0;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeMethodInfoPtr_RequestAllProofOfPurchaseKeys_Public_Static_Void_0;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeMethodInfoPtr_GetFileDetails_Public_Static_SteamAPICall_t_String_0;

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeMethodInfoPtr_GetLaunchCommandLine_Public_Static_Int32_byref_String_Int32_0;

		// Token: 0x0400125B RID: 4699
		private static readonly IntPtr NativeMethodInfoPtr_BIsSubscribedFromFamilySharing_Public_Static_Boolean_0;

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeMethodInfoPtr_BIsTimedTrial_Public_Static_Boolean_byref_UInt32_byref_UInt32_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200016C RID: 364
	public static class SteamUserStats : Object
	{
		// Token: 0x06001CAE RID: 7342 RVA: 0x0008488C File Offset: 0x00082A8C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamUserStats()
		{
			Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamUserStats");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr);
			SteamUserStats.NativeMethodInfoPtr_RequestCurrentStats_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667314);
			SteamUserStats.NativeMethodInfoPtr_GetStat_Public_Static_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667315);
			SteamUserStats.NativeMethodInfoPtr_GetStat_Public_Static_Boolean_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667316);
			SteamUserStats.NativeMethodInfoPtr_SetStat_Public_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667317);
			SteamUserStats.NativeMethodInfoPtr_SetStat_Public_Static_Boolean_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667318);
			SteamUserStats.NativeMethodInfoPtr_UpdateAvgRateStat_Public_Static_Boolean_String_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667319);
			SteamUserStats.NativeMethodInfoPtr_GetAchievement_Public_Static_Boolean_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667320);
			SteamUserStats.NativeMethodInfoPtr_SetAchievement_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667321);
			SteamUserStats.NativeMethodInfoPtr_ClearAchievement_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667322);
			SteamUserStats.NativeMethodInfoPtr_GetAchievementAndUnlockTime_Public_Static_Boolean_String_byref_Boolean_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667323);
			SteamUserStats.NativeMethodInfoPtr_StoreStats_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667324);
			SteamUserStats.NativeMethodInfoPtr_GetAchievementIcon_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667325);
			SteamUserStats.NativeMethodInfoPtr_GetAchievementDisplayAttribute_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667326);
			SteamUserStats.NativeMethodInfoPtr_IndicateAchievementProgress_Public_Static_Boolean_String_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667327);
			SteamUserStats.NativeMethodInfoPtr_GetNumAchievements_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667328);
			SteamUserStats.NativeMethodInfoPtr_GetAchievementName_Public_Static_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667329);
			SteamUserStats.NativeMethodInfoPtr_RequestUserStats_Public_Static_SteamAPICall_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667330);
			SteamUserStats.NativeMethodInfoPtr_GetUserStat_Public_Static_Boolean_CSteamID_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667331);
			SteamUserStats.NativeMethodInfoPtr_GetUserStat_Public_Static_Boolean_CSteamID_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667332);
			SteamUserStats.NativeMethodInfoPtr_GetUserAchievement_Public_Static_Boolean_CSteamID_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667333);
			SteamUserStats.NativeMethodInfoPtr_GetUserAchievementAndUnlockTime_Public_Static_Boolean_CSteamID_String_byref_Boolean_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667334);
			SteamUserStats.NativeMethodInfoPtr_ResetAllStats_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667335);
			SteamUserStats.NativeMethodInfoPtr_FindOrCreateLeaderboard_Public_Static_SteamAPICall_t_String_ELeaderboardSortMethod_ELeaderboardDisplayType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667336);
			SteamUserStats.NativeMethodInfoPtr_FindLeaderboard_Public_Static_SteamAPICall_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667337);
			SteamUserStats.NativeMethodInfoPtr_GetLeaderboardName_Public_Static_String_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667338);
			SteamUserStats.NativeMethodInfoPtr_GetLeaderboardEntryCount_Public_Static_Int32_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667339);
			SteamUserStats.NativeMethodInfoPtr_GetLeaderboardSortMethod_Public_Static_ELeaderboardSortMethod_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667340);
			SteamUserStats.NativeMethodInfoPtr_GetLeaderboardDisplayType_Public_Static_ELeaderboardDisplayType_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667341);
			SteamUserStats.NativeMethodInfoPtr_DownloadLeaderboardEntries_Public_Static_SteamAPICall_t_SteamLeaderboard_t_ELeaderboardDataRequest_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667342);
			SteamUserStats.NativeMethodInfoPtr_DownloadLeaderboardEntriesForUsers_Public_Static_SteamAPICall_t_SteamLeaderboard_t_Il2CppStructArray_1_CSteamID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667343);
			SteamUserStats.NativeMethodInfoPtr_GetDownloadedLeaderboardEntry_Public_Static_Boolean_SteamLeaderboardEntries_t_Int32_byref_LeaderboardEntry_t_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667344);
			SteamUserStats.NativeMethodInfoPtr_UploadLeaderboardScore_Public_Static_SteamAPICall_t_SteamLeaderboard_t_ELeaderboardUploadScoreMethod_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667345);
			SteamUserStats.NativeMethodInfoPtr_AttachLeaderboardUGC_Public_Static_SteamAPICall_t_SteamLeaderboard_t_UGCHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667346);
			SteamUserStats.NativeMethodInfoPtr_GetNumberOfCurrentPlayers_Public_Static_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667347);
			SteamUserStats.NativeMethodInfoPtr_RequestGlobalAchievementPercentages_Public_Static_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667348);
			SteamUserStats.NativeMethodInfoPtr_GetMostAchievedAchievementInfo_Public_Static_Int32_byref_String_UInt32_byref_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667349);
			SteamUserStats.NativeMethodInfoPtr_GetNextMostAchievedAchievementInfo_Public_Static_Int32_Int32_byref_String_UInt32_byref_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667350);
			SteamUserStats.NativeMethodInfoPtr_GetAchievementAchievedPercent_Public_Static_Boolean_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667351);
			SteamUserStats.NativeMethodInfoPtr_RequestGlobalStats_Public_Static_SteamAPICall_t_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667352);
			SteamUserStats.NativeMethodInfoPtr_GetGlobalStat_Public_Static_Boolean_String_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667353);
			SteamUserStats.NativeMethodInfoPtr_GetGlobalStat_Public_Static_Boolean_String_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667354);
			SteamUserStats.NativeMethodInfoPtr_GetGlobalStatHistory_Public_Static_Int32_String_Il2CppStructArray_1_Int64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667355);
			SteamUserStats.NativeMethodInfoPtr_GetGlobalStatHistory_Public_Static_Int32_String_Il2CppStructArray_1_Double_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667356);
			SteamUserStats.NativeMethodInfoPtr_GetAchievementProgressLimits_Public_Static_Boolean_String_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667357);
			SteamUserStats.NativeMethodInfoPtr_GetAchievementProgressLimits_Public_Static_Boolean_String_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100667358);
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x00084C40 File Offset: 0x00082E40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202633, RefRangeEnd = 202634, XrefRangeStart = 202629, XrefRangeEnd = 202633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequestCurrentStats()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_RequestCurrentStats_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x00084C70 File Offset: 0x00082E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202634, XrefRangeEnd = 202646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetStat(string pchName, out int pData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetStat_Public_Static_Boolean_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x00084CC0 File Offset: 0x00082EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202646, XrefRangeEnd = 202658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetStat(string pchName, out float pData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetStat_Public_Static_Boolean_String_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x00084D10 File Offset: 0x00082F10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202670, RefRangeEnd = 202671, XrefRangeStart = 202658, XrefRangeEnd = 202670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetStat(string pchName, int nData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_SetStat_Public_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x00084D60 File Offset: 0x00082F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202671, XrefRangeEnd = 202683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetStat(string pchName, float fData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_SetStat_Public_Static_Boolean_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x00084DB0 File Offset: 0x00082FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202683, XrefRangeEnd = 202695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flCountThisSession;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dSessionLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_UpdateAvgRateStat_Public_Static_Boolean_String_Single_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x00084E10 File Offset: 0x00083010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202695, XrefRangeEnd = 202707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetAchievement(string pchName, out bool pbAchieved)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetAchievement_Public_Static_Boolean_String_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x00084E60 File Offset: 0x00083060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202719, RefRangeEnd = 202720, XrefRangeStart = 202707, XrefRangeEnd = 202719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetAchievement(string pchName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_SetAchievement_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00084EA4 File Offset: 0x000830A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202720, XrefRangeEnd = 202732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ClearAchievement(string pchName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_ClearAchievement_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x00084EE8 File Offset: 0x000830E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202732, XrefRangeEnd = 202744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetAchievementAndUnlockTime(string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punUnlockTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetAchievementAndUnlockTime_Public_Static_Boolean_String_byref_Boolean_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x00084F48 File Offset: 0x00083148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202748, RefRangeEnd = 202749, XrefRangeStart = 202744, XrefRangeEnd = 202748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StoreStats()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_StoreStats_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00084F78 File Offset: 0x00083178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202749, XrefRangeEnd = 202761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetAchievementIcon(string pchName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetAchievementIcon_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x00084FBC File Offset: 0x000831BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202761, XrefRangeEnd = 202781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAchievementDisplayAttribute(string pchName, string pchKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetAchievementDisplayAttribute_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x0008500C File Offset: 0x0008320C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202781, XrefRangeEnd = 202793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nCurProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_IndicateAchievementProgress_Public_Static_Boolean_String_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x0008506C File Offset: 0x0008326C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202793, XrefRangeEnd = 202797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetNumAchievements()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetNumAchievements_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x0008509C File Offset: 0x0008329C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202797, XrefRangeEnd = 202802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAchievementName(uint iAchievement)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iAchievement;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetAchievementName_Public_Static_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x000850D4 File Offset: 0x000832D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202802, XrefRangeEnd = 202810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RequestUserStats(CSteamID steamIDUser)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_RequestUserStats_Public_Static_SteamAPICall_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x00085114 File Offset: 0x00083314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202810, XrefRangeEnd = 202822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetUserStat(CSteamID steamIDUser, string pchName, out int pData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetUserStat_Public_Static_Boolean_CSteamID_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x00085174 File Offset: 0x00083374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202822, XrefRangeEnd = 202834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetUserStat(CSteamID steamIDUser, string pchName, out float pData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetUserStat_Public_Static_Boolean_CSteamID_String_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x000851D4 File Offset: 0x000833D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202834, XrefRangeEnd = 202846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetUserAchievement(CSteamID steamIDUser, string pchName, out bool pbAchieved)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetUserAchievement_Public_Static_Boolean_CSteamID_String_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x00085234 File Offset: 0x00083434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202846, XrefRangeEnd = 202858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetUserAchievementAndUnlockTime(CSteamID steamIDUser, string pchName, out bool pbAchieved, out uint punUnlockTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punUnlockTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetUserAchievementAndUnlockTime_Public_Static_Boolean_CSteamID_String_byref_Boolean_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x000852A0 File Offset: 0x000834A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202858, XrefRangeEnd = 202862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ResetAllStats(bool bAchievementsToo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bAchievementsToo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_ResetAllStats_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x000852E0 File Offset: 0x000834E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202862, XrefRangeEnd = 202878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t FindOrCreateLeaderboard(string pchLeaderboardName, ELeaderboardSortMethod eLeaderboardSortMethod, ELeaderboardDisplayType eLeaderboardDisplayType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchLeaderboardName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLeaderboardSortMethod;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLeaderboardDisplayType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_FindOrCreateLeaderboard_Public_Static_SteamAPICall_t_String_ELeaderboardSortMethod_ELeaderboardDisplayType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x00085340 File Offset: 0x00083540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202878, XrefRangeEnd = 202894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t FindLeaderboard(string pchLeaderboardName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchLeaderboardName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_FindLeaderboard_Public_Static_SteamAPICall_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x00085384 File Offset: 0x00083584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202894, XrefRangeEnd = 202899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamLeaderboard;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetLeaderboardName_Public_Static_String_SteamLeaderboard_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x000853BC File Offset: 0x000835BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202899, XrefRangeEnd = 202903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamLeaderboard;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetLeaderboardEntryCount_Public_Static_Int32_SteamLeaderboard_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x000853FC File Offset: 0x000835FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202903, XrefRangeEnd = 202907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ELeaderboardSortMethod GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamLeaderboard;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetLeaderboardSortMethod_Public_Static_ELeaderboardSortMethod_SteamLeaderboard_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x0008543C File Offset: 0x0008363C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202907, XrefRangeEnd = 202911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ELeaderboardDisplayType GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamLeaderboard;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetLeaderboardDisplayType_Public_Static_ELeaderboardDisplayType_SteamLeaderboard_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x0008547C File Offset: 0x0008367C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202911, XrefRangeEnd = 202919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamLeaderboard;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLeaderboardDataRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRangeStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRangeEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_DownloadLeaderboardEntries_Public_Static_SteamAPICall_t_SteamLeaderboard_t_ELeaderboardDataRequest_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x000854E4 File Offset: 0x000836E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202919, XrefRangeEnd = 202927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, Il2CppStructArray<CSteamID> prgUsers, int cUsers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamLeaderboard;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prgUsers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cUsers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_DownloadLeaderboardEntriesForUsers_Public_Static_SteamAPICall_t_SteamLeaderboard_t_Il2CppStructArray_1_CSteamID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x00085544 File Offset: 0x00083744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202927, XrefRangeEnd = 202931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, out LeaderboardEntry_t pLeaderboardEntry, Il2CppStructArray<int> pDetails, int cDetailsMax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamLeaderboardEntries;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pLeaderboardEntry;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pDetails);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cDetailsMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetDownloadedLeaderboardEntry_Public_Static_Boolean_SteamLeaderboardEntries_t_Int32_byref_LeaderboardEntry_t_Il2CppStructArray_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x000855C0 File Offset: 0x000837C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202931, XrefRangeEnd = 202939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, ELeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, Il2CppStructArray<int> pScoreDetails, int cScoreDetailsCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamLeaderboard;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLeaderboardUploadScoreMethod;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nScore;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pScoreDetails);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cScoreDetailsCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_UploadLeaderboardScore_Public_Static_SteamAPICall_t_SteamLeaderboard_t_ELeaderboardUploadScoreMethod_Int32_Il2CppStructArray_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x0008563C File Offset: 0x0008383C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202939, XrefRangeEnd = 202947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamLeaderboard;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hUGC;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_AttachLeaderboardUGC_Public_Static_SteamAPICall_t_SteamLeaderboard_t_UGCHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00085688 File Offset: 0x00083888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202947, XrefRangeEnd = 202955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t GetNumberOfCurrentPlayers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetNumberOfCurrentPlayers_Public_Static_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x000856B8 File Offset: 0x000838B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202955, XrefRangeEnd = 202963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RequestGlobalAchievementPercentages()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_RequestGlobalAchievementPercentages_Public_Static_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x000856E8 File Offset: 0x000838E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202963, XrefRangeEnd = 202975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMostAchievedAchievementInfo(out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unNameBufLen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pflPercent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetMostAchievedAchievementInfo_Public_Static_Int32_byref_String_UInt32_byref_Single_byref_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x0008575C File Offset: 0x0008395C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202975, XrefRangeEnd = 202987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, uint unNameBufLen, out float pflPercent, out bool pbAchieved)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iIteratorPrevious;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unNameBufLen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pflPercent;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetNextMostAchievedAchievementInfo_Public_Static_Int32_Int32_byref_String_UInt32_byref_Single_byref_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x000857E0 File Offset: 0x000839E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202987, XrefRangeEnd = 202999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetAchievementAchievedPercent(string pchName, out float pflPercent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pflPercent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetAchievementAchievedPercent_Public_Static_Boolean_String_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x00085830 File Offset: 0x00083A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202999, XrefRangeEnd = 203007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RequestGlobalStats(int nHistoryDays)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nHistoryDays;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_RequestGlobalStats_Public_Static_SteamAPICall_t_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x00085870 File Offset: 0x00083A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203007, XrefRangeEnd = 203019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetGlobalStat(string pchStatName, out long pData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchStatName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetGlobalStat_Public_Static_Boolean_String_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x000858C0 File Offset: 0x00083AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203019, XrefRangeEnd = 203031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetGlobalStat(string pchStatName, out double pData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchStatName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetGlobalStat_Public_Static_Boolean_String_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x00085910 File Offset: 0x00083B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203031, XrefRangeEnd = 203043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGlobalStatHistory(string pchStatName, Il2CppStructArray<long> pData, uint cubData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchStatName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetGlobalStatHistory_Public_Static_Int32_String_Il2CppStructArray_1_Int64_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x00085974 File Offset: 0x00083B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203043, XrefRangeEnd = 203055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGlobalStatHistory(string pchStatName, Il2CppStructArray<double> pData, uint cubData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchStatName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetGlobalStatHistory_Public_Static_Int32_String_Il2CppStructArray_1_Double_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x000859D8 File Offset: 0x00083BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203055, XrefRangeEnd = 203067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetAchievementProgressLimits(string pchName, out int pnMinProgress, out int pnMaxProgress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnMinProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnMaxProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetAchievementProgressLimits_Public_Static_Boolean_String_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x00085A38 File Offset: 0x00083C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203067, XrefRangeEnd = 203079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetAchievementProgressLimits(string pchName, out float pfMinProgress, out float pfMaxProgress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pfMinProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pfMaxProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetAchievementProgressLimits_Public_Static_Boolean_String_byref_Single_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x0000BB2C File Offset: 0x00009D2C
		public SteamUserStats(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400167E RID: 5758
		private static readonly IntPtr NativeMethodInfoPtr_RequestCurrentStats_Public_Static_Boolean_0;

		// Token: 0x0400167F RID: 5759
		private static readonly IntPtr NativeMethodInfoPtr_GetStat_Public_Static_Boolean_String_byref_Int32_0;

		// Token: 0x04001680 RID: 5760
		private static readonly IntPtr NativeMethodInfoPtr_GetStat_Public_Static_Boolean_String_byref_Single_0;

		// Token: 0x04001681 RID: 5761
		private static readonly IntPtr NativeMethodInfoPtr_SetStat_Public_Static_Boolean_String_Int32_0;

		// Token: 0x04001682 RID: 5762
		private static readonly IntPtr NativeMethodInfoPtr_SetStat_Public_Static_Boolean_String_Single_0;

		// Token: 0x04001683 RID: 5763
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAvgRateStat_Public_Static_Boolean_String_Single_Double_0;

		// Token: 0x04001684 RID: 5764
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievement_Public_Static_Boolean_String_byref_Boolean_0;

		// Token: 0x04001685 RID: 5765
		private static readonly IntPtr NativeMethodInfoPtr_SetAchievement_Public_Static_Boolean_String_0;

		// Token: 0x04001686 RID: 5766
		private static readonly IntPtr NativeMethodInfoPtr_ClearAchievement_Public_Static_Boolean_String_0;

		// Token: 0x04001687 RID: 5767
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievementAndUnlockTime_Public_Static_Boolean_String_byref_Boolean_byref_UInt32_0;

		// Token: 0x04001688 RID: 5768
		private static readonly IntPtr NativeMethodInfoPtr_StoreStats_Public_Static_Boolean_0;

		// Token: 0x04001689 RID: 5769
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievementIcon_Public_Static_Int32_String_0;

		// Token: 0x0400168A RID: 5770
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievementDisplayAttribute_Public_Static_String_String_String_0;

		// Token: 0x0400168B RID: 5771
		private static readonly IntPtr NativeMethodInfoPtr_IndicateAchievementProgress_Public_Static_Boolean_String_UInt32_UInt32_0;

		// Token: 0x0400168C RID: 5772
		private static readonly IntPtr NativeMethodInfoPtr_GetNumAchievements_Public_Static_UInt32_0;

		// Token: 0x0400168D RID: 5773
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievementName_Public_Static_String_UInt32_0;

		// Token: 0x0400168E RID: 5774
		private static readonly IntPtr NativeMethodInfoPtr_RequestUserStats_Public_Static_SteamAPICall_t_CSteamID_0;

		// Token: 0x0400168F RID: 5775
		private static readonly IntPtr NativeMethodInfoPtr_GetUserStat_Public_Static_Boolean_CSteamID_String_byref_Int32_0;

		// Token: 0x04001690 RID: 5776
		private static readonly IntPtr NativeMethodInfoPtr_GetUserStat_Public_Static_Boolean_CSteamID_String_byref_Single_0;

		// Token: 0x04001691 RID: 5777
		private static readonly IntPtr NativeMethodInfoPtr_GetUserAchievement_Public_Static_Boolean_CSteamID_String_byref_Boolean_0;

		// Token: 0x04001692 RID: 5778
		private static readonly IntPtr NativeMethodInfoPtr_GetUserAchievementAndUnlockTime_Public_Static_Boolean_CSteamID_String_byref_Boolean_byref_UInt32_0;

		// Token: 0x04001693 RID: 5779
		private static readonly IntPtr NativeMethodInfoPtr_ResetAllStats_Public_Static_Boolean_Boolean_0;

		// Token: 0x04001694 RID: 5780
		private static readonly IntPtr NativeMethodInfoPtr_FindOrCreateLeaderboard_Public_Static_SteamAPICall_t_String_ELeaderboardSortMethod_ELeaderboardDisplayType_0;

		// Token: 0x04001695 RID: 5781
		private static readonly IntPtr NativeMethodInfoPtr_FindLeaderboard_Public_Static_SteamAPICall_t_String_0;

		// Token: 0x04001696 RID: 5782
		private static readonly IntPtr NativeMethodInfoPtr_GetLeaderboardName_Public_Static_String_SteamLeaderboard_t_0;

		// Token: 0x04001697 RID: 5783
		private static readonly IntPtr NativeMethodInfoPtr_GetLeaderboardEntryCount_Public_Static_Int32_SteamLeaderboard_t_0;

		// Token: 0x04001698 RID: 5784
		private static readonly IntPtr NativeMethodInfoPtr_GetLeaderboardSortMethod_Public_Static_ELeaderboardSortMethod_SteamLeaderboard_t_0;

		// Token: 0x04001699 RID: 5785
		private static readonly IntPtr NativeMethodInfoPtr_GetLeaderboardDisplayType_Public_Static_ELeaderboardDisplayType_SteamLeaderboard_t_0;

		// Token: 0x0400169A RID: 5786
		private static readonly IntPtr NativeMethodInfoPtr_DownloadLeaderboardEntries_Public_Static_SteamAPICall_t_SteamLeaderboard_t_ELeaderboardDataRequest_Int32_Int32_0;

		// Token: 0x0400169B RID: 5787
		private static readonly IntPtr NativeMethodInfoPtr_DownloadLeaderboardEntriesForUsers_Public_Static_SteamAPICall_t_SteamLeaderboard_t_Il2CppStructArray_1_CSteamID_Int32_0;

		// Token: 0x0400169C RID: 5788
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadedLeaderboardEntry_Public_Static_Boolean_SteamLeaderboardEntries_t_Int32_byref_LeaderboardEntry_t_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x0400169D RID: 5789
		private static readonly IntPtr NativeMethodInfoPtr_UploadLeaderboardScore_Public_Static_SteamAPICall_t_SteamLeaderboard_t_ELeaderboardUploadScoreMethod_Int32_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x0400169E RID: 5790
		private static readonly IntPtr NativeMethodInfoPtr_AttachLeaderboardUGC_Public_Static_SteamAPICall_t_SteamLeaderboard_t_UGCHandle_t_0;

		// Token: 0x0400169F RID: 5791
		private static readonly IntPtr NativeMethodInfoPtr_GetNumberOfCurrentPlayers_Public_Static_SteamAPICall_t_0;

		// Token: 0x040016A0 RID: 5792
		private static readonly IntPtr NativeMethodInfoPtr_RequestGlobalAchievementPercentages_Public_Static_SteamAPICall_t_0;

		// Token: 0x040016A1 RID: 5793
		private static readonly IntPtr NativeMethodInfoPtr_GetMostAchievedAchievementInfo_Public_Static_Int32_byref_String_UInt32_byref_Single_byref_Boolean_0;

		// Token: 0x040016A2 RID: 5794
		private static readonly IntPtr NativeMethodInfoPtr_GetNextMostAchievedAchievementInfo_Public_Static_Int32_Int32_byref_String_UInt32_byref_Single_byref_Boolean_0;

		// Token: 0x040016A3 RID: 5795
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievementAchievedPercent_Public_Static_Boolean_String_byref_Single_0;

		// Token: 0x040016A4 RID: 5796
		private static readonly IntPtr NativeMethodInfoPtr_RequestGlobalStats_Public_Static_SteamAPICall_t_Int32_0;

		// Token: 0x040016A5 RID: 5797
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalStat_Public_Static_Boolean_String_byref_Int64_0;

		// Token: 0x040016A6 RID: 5798
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalStat_Public_Static_Boolean_String_byref_Double_0;

		// Token: 0x040016A7 RID: 5799
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalStatHistory_Public_Static_Int32_String_Il2CppStructArray_1_Int64_UInt32_0;

		// Token: 0x040016A8 RID: 5800
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalStatHistory_Public_Static_Int32_String_Il2CppStructArray_1_Double_UInt32_0;

		// Token: 0x040016A9 RID: 5801
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievementProgressLimits_Public_Static_Boolean_String_byref_Int32_byref_Int32_0;

		// Token: 0x040016AA RID: 5802
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievementProgressLimits_Public_Static_Boolean_String_byref_Single_byref_Single_0;
	}
}

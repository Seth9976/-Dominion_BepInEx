using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200012A RID: 298
public class GooglePlayServicesTab : FeatureTab
{
	// Token: 0x060014D4 RID: 5332 RVA: 0x0005EF54 File Offset: 0x0005D154
	// Note: this type is marked as 'beforefieldinit'.
	static GooglePlayServicesTab()
	{
		Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GooglePlayServicesTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr);
		GooglePlayServicesTab.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "score");
		GooglePlayServicesTab.NativeFieldInfoPtr_LEADERBOARD_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "LEADERBOARD_NAME");
		GooglePlayServicesTab.NativeFieldInfoPtr_PIE_GIFT_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "PIE_GIFT_ID");
		GooglePlayServicesTab.NativeFieldInfoPtr_LEADERBOARD_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "LEADERBOARD_ID");
		GooglePlayServicesTab.NativeFieldInfoPtr_INCREMENTAL_ACHIEVEMENT_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "INCREMENTAL_ACHIEVEMENT_ID");
		GooglePlayServicesTab.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "avatar");
		GooglePlayServicesTab.NativeFieldInfoPtr_defaulttexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "defaulttexture");
		GooglePlayServicesTab.NativeFieldInfoPtr_logo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "logo");
		GooglePlayServicesTab.NativeFieldInfoPtr_pieIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "pieIcon");
		GooglePlayServicesTab.NativeFieldInfoPtr_connectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "connectButton");
		GooglePlayServicesTab.NativeFieldInfoPtr_connectButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "connectButtonLabel");
		GooglePlayServicesTab.NativeFieldInfoPtr_scoreSubmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "scoreSubmit");
		GooglePlayServicesTab.NativeFieldInfoPtr_scoreSubmitLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "scoreSubmitLabel");
		GooglePlayServicesTab.NativeFieldInfoPtr_playerLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "playerLabel");
		GooglePlayServicesTab.NativeFieldInfoPtr_ConnectionDependedntButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "ConnectionDependedntButtons");
		GooglePlayServicesTab.NativeFieldInfoPtr_a_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "a_id");
		GooglePlayServicesTab.NativeFieldInfoPtr_a_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "a_name");
		GooglePlayServicesTab.NativeFieldInfoPtr_a_descr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "a_descr");
		GooglePlayServicesTab.NativeFieldInfoPtr_a_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "a_type");
		GooglePlayServicesTab.NativeFieldInfoPtr_a_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "a_state");
		GooglePlayServicesTab.NativeFieldInfoPtr_a_steps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "a_steps");
		GooglePlayServicesTab.NativeFieldInfoPtr_a_total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "a_total");
		GooglePlayServicesTab.NativeFieldInfoPtr_b_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "b_id");
		GooglePlayServicesTab.NativeFieldInfoPtr_b_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "b_name");
		GooglePlayServicesTab.NativeFieldInfoPtr_b_all_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, "b_all_time");
		GooglePlayServicesTab.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665821);
		GooglePlayServicesTab.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665822);
		GooglePlayServicesTab.NativeMethodInfoPtr_ConncetButtonPress_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665823);
		GooglePlayServicesTab.NativeMethodInfoPtr_GetAccs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665824);
		GooglePlayServicesTab.NativeMethodInfoPtr_RetrieveToken_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665825);
		GooglePlayServicesTab.NativeMethodInfoPtr_showLeaderBoardsUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665826);
		GooglePlayServicesTab.NativeMethodInfoPtr_loadLeaderBoards_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665827);
		GooglePlayServicesTab.NativeMethodInfoPtr_showLeaderBoard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665828);
		GooglePlayServicesTab.NativeMethodInfoPtr_submitScore_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665829);
		GooglePlayServicesTab.NativeMethodInfoPtr_ResetBoard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665830);
		GooglePlayServicesTab.NativeMethodInfoPtr_showAchievementsUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665831);
		GooglePlayServicesTab.NativeMethodInfoPtr_loadAchievements_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665832);
		GooglePlayServicesTab.NativeMethodInfoPtr_reportAchievement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665833);
		GooglePlayServicesTab.NativeMethodInfoPtr_incrementAchievement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665834);
		GooglePlayServicesTab.NativeMethodInfoPtr_revealAchievement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665835);
		GooglePlayServicesTab.NativeMethodInfoPtr_ResetAchievement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665836);
		GooglePlayServicesTab.NativeMethodInfoPtr_ResetAllAchievements_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665837);
		GooglePlayServicesTab.NativeMethodInfoPtr_SendGiftRequest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665838);
		GooglePlayServicesTab.NativeMethodInfoPtr_OpenInbox_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665839);
		GooglePlayServicesTab.NativeMethodInfoPtr_clearDefaultAccount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665840);
		GooglePlayServicesTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665841);
		GooglePlayServicesTab.NativeMethodInfoPtr_RequestAdvertisingId_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665842);
		GooglePlayServicesTab.NativeMethodInfoPtr_ActionAdvertisingIdLoaded_Private_Void_GP_AdvertisingIdLoadResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665843);
		GooglePlayServicesTab.NativeMethodInfoPtr_OnAchievmnetsLoadedInfoListner_Private_Void_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665844);
		GooglePlayServicesTab.NativeMethodInfoPtr_OnAchievementsLoaded_Private_Void_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665845);
		GooglePlayServicesTab.NativeMethodInfoPtr_OnAchievementUpdated_Private_Void_GP_AchievementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665846);
		GooglePlayServicesTab.NativeMethodInfoPtr_OnLeaderBoardsLoaded_Private_Void_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665847);
		GooglePlayServicesTab.NativeMethodInfoPtr_UpdateBoardInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665848);
		GooglePlayServicesTab.NativeMethodInfoPtr_OnScoreSubmited_Private_Void_GP_LeaderboardResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665849);
		GooglePlayServicesTab.NativeMethodInfoPtr_OnScoreUpdated_Private_Void_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665850);
		GooglePlayServicesTab.NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665851);
		GooglePlayServicesTab.NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665852);
		GooglePlayServicesTab.NativeMethodInfoPtr_ActionConnectionResultReceived_Private_Void_GooglePlayConnectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665853);
		GooglePlayServicesTab.NativeMethodInfoPtr_OnGiftResult_Private_Void_GooglePlayGiftRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665854);
		GooglePlayServicesTab.NativeMethodInfoPtr_OnPendingGiftsDetected_Private_Void_List_1_GPGameRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665855);
		GooglePlayServicesTab.NativeMethodInfoPtr_OnPromtGiftDialogClose_Private_Void_AndroidDialogResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665856);
		GooglePlayServicesTab.NativeMethodInfoPtr_OnGameRequestAccepted_Private_Void_List_1_GPGameRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665857);
		GooglePlayServicesTab.NativeMethodInfoPtr_ActionAvailableDeviceAccountsLoaded_Private_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665858);
		GooglePlayServicesTab.NativeMethodInfoPtr_SighDialogComplete_Private_Void_AndroidDialogResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665859);
		GooglePlayServicesTab.NativeMethodInfoPtr_ActionOAuthTokenLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665860);
		GooglePlayServicesTab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr, 100665861);
	}

	// Token: 0x060014D5 RID: 5333 RVA: 0x0005F4AC File Offset: 0x0005D6AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188820, XrefRangeEnd = 188947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014D6 RID: 5334 RVA: 0x0005F4E0 File Offset: 0x0005D6E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188947, XrefRangeEnd = 189064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014D7 RID: 5335 RVA: 0x0005F514 File Offset: 0x0005D714
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189064, XrefRangeEnd = 189098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConncetButtonPress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_ConncetButtonPress_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014D8 RID: 5336 RVA: 0x0005F548 File Offset: 0x0005D748
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189098, XrefRangeEnd = 189106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetAccs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_GetAccs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014D9 RID: 5337 RVA: 0x0005F57C File Offset: 0x0005D77C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189106, XrefRangeEnd = 189114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RetrieveToken()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_RetrieveToken_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014DA RID: 5338 RVA: 0x0005F5B0 File Offset: 0x0005D7B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189114, XrefRangeEnd = 189125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void showLeaderBoardsUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_showLeaderBoardsUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014DB RID: 5339 RVA: 0x0005F5E4 File Offset: 0x0005D7E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189125, XrefRangeEnd = 189162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void loadLeaderBoards()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_loadLeaderBoards_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014DC RID: 5340 RVA: 0x0005F618 File Offset: 0x0005D818
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189162, XrefRangeEnd = 189175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void showLeaderBoard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_showLeaderBoard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014DD RID: 5341 RVA: 0x0005F64C File Offset: 0x0005D84C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189175, XrefRangeEnd = 189194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void submitScore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_submitScore_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014DE RID: 5342 RVA: 0x0005F680 File Offset: 0x0005D880
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189194, XrefRangeEnd = 189205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetBoard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_ResetBoard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014DF RID: 5343 RVA: 0x0005F6B4 File Offset: 0x0005D8B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189205, XrefRangeEnd = 189216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void showAchievementsUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_showAchievementsUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014E0 RID: 5344 RVA: 0x0005F6E8 File Offset: 0x0005D8E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189216, XrefRangeEnd = 189239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void loadAchievements()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_loadAchievements_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014E1 RID: 5345 RVA: 0x0005F71C File Offset: 0x0005D91C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189239, XrefRangeEnd = 189252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void reportAchievement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_reportAchievement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014E2 RID: 5346 RVA: 0x0005F750 File Offset: 0x0005D950
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189252, XrefRangeEnd = 189265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void incrementAchievement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_incrementAchievement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014E3 RID: 5347 RVA: 0x0005F784 File Offset: 0x0005D984
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189265, XrefRangeEnd = 189278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void revealAchievement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_revealAchievement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014E4 RID: 5348 RVA: 0x0005F7B8 File Offset: 0x0005D9B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189278, XrefRangeEnd = 189293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetAchievement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_ResetAchievement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014E5 RID: 5349 RVA: 0x0005F7EC File Offset: 0x0005D9EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189293, XrefRangeEnd = 189306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetAllAchievements()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_ResetAllAchievements_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014E6 RID: 5350 RVA: 0x0005F820 File Offset: 0x0005DA20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189306, XrefRangeEnd = 189317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendGiftRequest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_SendGiftRequest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014E7 RID: 5351 RVA: 0x0005F854 File Offset: 0x0005DA54
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189317, XrefRangeEnd = 189325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OpenInbox()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_OpenInbox_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014E8 RID: 5352 RVA: 0x0005F888 File Offset: 0x0005DA88
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189325, XrefRangeEnd = 189333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clearDefaultAccount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_clearDefaultAccount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014E9 RID: 5353 RVA: 0x0005F8BC File Offset: 0x0005DABC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189333, XrefRangeEnd = 189403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014EA RID: 5354 RVA: 0x0005F8F0 File Offset: 0x0005DAF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189403, XrefRangeEnd = 189427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RequestAdvertisingId()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_RequestAdvertisingId_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014EB RID: 5355 RVA: 0x0005F924 File Offset: 0x0005DB24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189427, XrefRangeEnd = 189456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActionAdvertisingIdLoaded(GP_AdvertisingIdLoadResult res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_ActionAdvertisingIdLoaded_Private_Void_GP_AdvertisingIdLoadResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014EC RID: 5356 RVA: 0x0005F968 File Offset: 0x0005DB68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189456, XrefRangeEnd = 189496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAchievmnetsLoadedInfoListner(GooglePlayResult res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_OnAchievmnetsLoadedInfoListner_Private_Void_GooglePlayResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014ED RID: 5357 RVA: 0x0005F9AC File Offset: 0x0005DBAC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189496, XrefRangeEnd = 189526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAchievementsLoaded(GooglePlayResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_OnAchievementsLoaded_Private_Void_GooglePlayResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014EE RID: 5358 RVA: 0x0005F9F0 File Offset: 0x0005DBF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189526, XrefRangeEnd = 189540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAchievementUpdated(GP_AchievementResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_OnAchievementUpdated_Private_Void_GP_AchievementResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014EF RID: 5359 RVA: 0x0005FA34 File Offset: 0x0005DC34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189540, XrefRangeEnd = 189589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLeaderBoardsLoaded(GooglePlayResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_OnLeaderBoardsLoaded_Private_Void_GooglePlayResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014F0 RID: 5360 RVA: 0x0005FA78 File Offset: 0x0005DC78
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 189604, RefRangeEnd = 189608, XrefRangeStart = 189589, XrefRangeEnd = 189604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateBoardInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_UpdateBoardInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014F1 RID: 5361 RVA: 0x0005FAAC File Offset: 0x0005DCAC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189608, XrefRangeEnd = 189616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnScoreSubmited(GP_LeaderboardResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_OnScoreSubmited_Private_Void_GP_LeaderboardResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014F2 RID: 5362 RVA: 0x0005FAF0 File Offset: 0x0005DCF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189616, XrefRangeEnd = 189617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnScoreUpdated(GooglePlayResult res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_OnScoreUpdated_Private_Void_GooglePlayResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014F3 RID: 5363 RVA: 0x0005FB34 File Offset: 0x0005DD34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189617, XrefRangeEnd = 189622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerDisconnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014F4 RID: 5364 RVA: 0x0005FB68 File Offset: 0x0005DD68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189622, XrefRangeEnd = 189639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerConnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014F5 RID: 5365 RVA: 0x0005FB9C File Offset: 0x0005DD9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189639, XrefRangeEnd = 189664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActionConnectionResultReceived(GooglePlayConnectionResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_ActionConnectionResultReceived_Private_Void_GooglePlayConnectionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014F6 RID: 5366 RVA: 0x0005FBE0 File Offset: 0x0005DDE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189664, XrefRangeEnd = 189681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGiftResult(GooglePlayGiftRequestResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_OnGiftResult_Private_Void_GooglePlayGiftRequestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014F7 RID: 5367 RVA: 0x0005FC24 File Offset: 0x0005DE24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189681, XrefRangeEnd = 189696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPendingGiftsDetected(List<GPGameRequest> gifts)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gifts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_OnPendingGiftsDetected_Private_Void_List_1_GPGameRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014F8 RID: 5368 RVA: 0x0005FC68 File Offset: 0x0005DE68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189696, XrefRangeEnd = 189703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPromtGiftDialogClose(AndroidDialogResult res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref res;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_OnPromtGiftDialogClose_Private_Void_AndroidDialogResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014F9 RID: 5369 RVA: 0x0005FCA8 File Offset: 0x0005DEA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189703, XrefRangeEnd = 189723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGameRequestAccepted(List<GPGameRequest> gifts)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gifts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_OnGameRequestAccepted_Private_Void_List_1_GPGameRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014FA RID: 5370 RVA: 0x0005FCEC File Offset: 0x0005DEEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189723, XrefRangeEnd = 189764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActionAvailableDeviceAccountsLoaded(List<string> accounts)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(accounts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_ActionAvailableDeviceAccountsLoaded_Private_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014FB RID: 5371 RVA: 0x0005FD30 File Offset: 0x0005DF30
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189764, XrefRangeEnd = 189779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SighDialogComplete(AndroidDialogResult res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref res;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_SighDialogComplete_Private_Void_AndroidDialogResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014FC RID: 5372 RVA: 0x0005FD70 File Offset: 0x0005DF70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189779, XrefRangeEnd = 189789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActionOAuthTokenLoaded(string token)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr_ActionOAuthTokenLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014FD RID: 5373 RVA: 0x0005FDB4 File Offset: 0x0005DFB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189789, XrefRangeEnd = 189790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePlayServicesTab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayServicesTab>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayServicesTab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014FE RID: 5374 RVA: 0x0000A2A2 File Offset: 0x000084A2
	public GooglePlayServicesTab(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005F7 RID: 1527
	// (get) Token: 0x060014FF RID: 5375 RVA: 0x0005FDF0 File Offset: 0x0005DFF0
	// (set) Token: 0x06001500 RID: 5376 RVA: 0x0000A2AB File Offset: 0x000084AB
	public unsafe int score
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_score);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_score)) = value;
		}
	}

	// Token: 0x170005F8 RID: 1528
	// (get) Token: 0x06001501 RID: 5377 RVA: 0x0005FE18 File Offset: 0x0005E018
	// (set) Token: 0x06001502 RID: 5378 RVA: 0x0000A2C6 File Offset: 0x000084C6
	public unsafe static string LEADERBOARD_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayServicesTab.NativeFieldInfoPtr_LEADERBOARD_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayServicesTab.NativeFieldInfoPtr_LEADERBOARD_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170005F9 RID: 1529
	// (get) Token: 0x06001503 RID: 5379 RVA: 0x0005FE38 File Offset: 0x0005E038
	// (set) Token: 0x06001504 RID: 5380 RVA: 0x0000A2D8 File Offset: 0x000084D8
	public unsafe static string PIE_GIFT_ID
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayServicesTab.NativeFieldInfoPtr_PIE_GIFT_ID, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayServicesTab.NativeFieldInfoPtr_PIE_GIFT_ID, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170005FA RID: 1530
	// (get) Token: 0x06001505 RID: 5381 RVA: 0x0005FE58 File Offset: 0x0005E058
	// (set) Token: 0x06001506 RID: 5382 RVA: 0x0000A2EA File Offset: 0x000084EA
	public unsafe static string LEADERBOARD_ID
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayServicesTab.NativeFieldInfoPtr_LEADERBOARD_ID, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayServicesTab.NativeFieldInfoPtr_LEADERBOARD_ID, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170005FB RID: 1531
	// (get) Token: 0x06001507 RID: 5383 RVA: 0x0005FE78 File Offset: 0x0005E078
	// (set) Token: 0x06001508 RID: 5384 RVA: 0x0000A2FC File Offset: 0x000084FC
	public unsafe static string INCREMENTAL_ACHIEVEMENT_ID
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayServicesTab.NativeFieldInfoPtr_INCREMENTAL_ACHIEVEMENT_ID, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayServicesTab.NativeFieldInfoPtr_INCREMENTAL_ACHIEVEMENT_ID, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170005FC RID: 1532
	// (get) Token: 0x06001509 RID: 5385 RVA: 0x0005FE98 File Offset: 0x0005E098
	// (set) Token: 0x0600150A RID: 5386 RVA: 0x0000A30E File Offset: 0x0000850E
	public unsafe Image avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005FD RID: 1533
	// (get) Token: 0x0600150B RID: 5387 RVA: 0x0005FEC8 File Offset: 0x0005E0C8
	// (set) Token: 0x0600150C RID: 5388 RVA: 0x0000A32D File Offset: 0x0000852D
	public unsafe Sprite defaulttexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_defaulttexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_defaulttexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005FE RID: 1534
	// (get) Token: 0x0600150D RID: 5389 RVA: 0x0005FEF8 File Offset: 0x0005E0F8
	// (set) Token: 0x0600150E RID: 5390 RVA: 0x0000A34C File Offset: 0x0000854C
	public unsafe Sprite logo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_logo);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_logo), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005FF RID: 1535
	// (get) Token: 0x0600150F RID: 5391 RVA: 0x0005FF28 File Offset: 0x0005E128
	// (set) Token: 0x06001510 RID: 5392 RVA: 0x0000A36B File Offset: 0x0000856B
	public unsafe Texture2D pieIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_pieIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_pieIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000600 RID: 1536
	// (get) Token: 0x06001511 RID: 5393 RVA: 0x0005FF58 File Offset: 0x0005E158
	// (set) Token: 0x06001512 RID: 5394 RVA: 0x0000A38A File Offset: 0x0000858A
	public unsafe Button connectButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_connectButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_connectButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000601 RID: 1537
	// (get) Token: 0x06001513 RID: 5395 RVA: 0x0005FF88 File Offset: 0x0005E188
	// (set) Token: 0x06001514 RID: 5396 RVA: 0x0000A3A9 File Offset: 0x000085A9
	public unsafe Text connectButtonLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_connectButtonLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_connectButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000602 RID: 1538
	// (get) Token: 0x06001515 RID: 5397 RVA: 0x0005FFB8 File Offset: 0x0005E1B8
	// (set) Token: 0x06001516 RID: 5398 RVA: 0x0000A3C8 File Offset: 0x000085C8
	public unsafe Button scoreSubmit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_scoreSubmit);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_scoreSubmit), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000603 RID: 1539
	// (get) Token: 0x06001517 RID: 5399 RVA: 0x0005FFE8 File Offset: 0x0005E1E8
	// (set) Token: 0x06001518 RID: 5400 RVA: 0x0000A3E7 File Offset: 0x000085E7
	public unsafe Text scoreSubmitLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_scoreSubmitLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_scoreSubmitLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000604 RID: 1540
	// (get) Token: 0x06001519 RID: 5401 RVA: 0x00060018 File Offset: 0x0005E218
	// (set) Token: 0x0600151A RID: 5402 RVA: 0x0000A406 File Offset: 0x00008606
	public unsafe Text playerLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_playerLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_playerLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000605 RID: 1541
	// (get) Token: 0x0600151B RID: 5403 RVA: 0x00060048 File Offset: 0x0005E248
	// (set) Token: 0x0600151C RID: 5404 RVA: 0x0000A425 File Offset: 0x00008625
	public unsafe Il2CppReferenceArray<Button> ConnectionDependedntButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_ConnectionDependedntButtons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_ConnectionDependedntButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000606 RID: 1542
	// (get) Token: 0x0600151D RID: 5405 RVA: 0x00060078 File Offset: 0x0005E278
	// (set) Token: 0x0600151E RID: 5406 RVA: 0x0000A444 File Offset: 0x00008644
	public unsafe Text a_id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_a_id);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_a_id), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000607 RID: 1543
	// (get) Token: 0x0600151F RID: 5407 RVA: 0x000600A8 File Offset: 0x0005E2A8
	// (set) Token: 0x06001520 RID: 5408 RVA: 0x0000A463 File Offset: 0x00008663
	public unsafe Text a_name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_a_name);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_a_name), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000608 RID: 1544
	// (get) Token: 0x06001521 RID: 5409 RVA: 0x000600D8 File Offset: 0x0005E2D8
	// (set) Token: 0x06001522 RID: 5410 RVA: 0x0000A482 File Offset: 0x00008682
	public unsafe Text a_descr
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_a_descr);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_a_descr), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000609 RID: 1545
	// (get) Token: 0x06001523 RID: 5411 RVA: 0x00060108 File Offset: 0x0005E308
	// (set) Token: 0x06001524 RID: 5412 RVA: 0x0000A4A1 File Offset: 0x000086A1
	public unsafe Text a_type
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_a_type);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_a_type), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700060A RID: 1546
	// (get) Token: 0x06001525 RID: 5413 RVA: 0x00060138 File Offset: 0x0005E338
	// (set) Token: 0x06001526 RID: 5414 RVA: 0x0000A4C0 File Offset: 0x000086C0
	public unsafe Text a_state
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_a_state);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_a_state), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700060B RID: 1547
	// (get) Token: 0x06001527 RID: 5415 RVA: 0x00060168 File Offset: 0x0005E368
	// (set) Token: 0x06001528 RID: 5416 RVA: 0x0000A4DF File Offset: 0x000086DF
	public unsafe Text a_steps
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_a_steps);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_a_steps), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700060C RID: 1548
	// (get) Token: 0x06001529 RID: 5417 RVA: 0x00060198 File Offset: 0x0005E398
	// (set) Token: 0x0600152A RID: 5418 RVA: 0x0000A4FE File Offset: 0x000086FE
	public unsafe Text a_total
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_a_total);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_a_total), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700060D RID: 1549
	// (get) Token: 0x0600152B RID: 5419 RVA: 0x000601C8 File Offset: 0x0005E3C8
	// (set) Token: 0x0600152C RID: 5420 RVA: 0x0000A51D File Offset: 0x0000871D
	public unsafe Text b_id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_b_id);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_b_id), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700060E RID: 1550
	// (get) Token: 0x0600152D RID: 5421 RVA: 0x000601F8 File Offset: 0x0005E3F8
	// (set) Token: 0x0600152E RID: 5422 RVA: 0x0000A53C File Offset: 0x0000873C
	public unsafe Text b_name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_b_name);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_b_name), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700060F RID: 1551
	// (get) Token: 0x0600152F RID: 5423 RVA: 0x00060228 File Offset: 0x0005E428
	// (set) Token: 0x06001530 RID: 5424 RVA: 0x0000A55B File Offset: 0x0000875B
	public unsafe Text b_all_time
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_b_all_time);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayServicesTab.NativeFieldInfoPtr_b_all_time), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000FD7 RID: 4055
	private static readonly IntPtr NativeFieldInfoPtr_score;

	// Token: 0x04000FD8 RID: 4056
	private static readonly IntPtr NativeFieldInfoPtr_LEADERBOARD_NAME;

	// Token: 0x04000FD9 RID: 4057
	private static readonly IntPtr NativeFieldInfoPtr_PIE_GIFT_ID;

	// Token: 0x04000FDA RID: 4058
	private static readonly IntPtr NativeFieldInfoPtr_LEADERBOARD_ID;

	// Token: 0x04000FDB RID: 4059
	private static readonly IntPtr NativeFieldInfoPtr_INCREMENTAL_ACHIEVEMENT_ID;

	// Token: 0x04000FDC RID: 4060
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x04000FDD RID: 4061
	private static readonly IntPtr NativeFieldInfoPtr_defaulttexture;

	// Token: 0x04000FDE RID: 4062
	private static readonly IntPtr NativeFieldInfoPtr_logo;

	// Token: 0x04000FDF RID: 4063
	private static readonly IntPtr NativeFieldInfoPtr_pieIcon;

	// Token: 0x04000FE0 RID: 4064
	private static readonly IntPtr NativeFieldInfoPtr_connectButton;

	// Token: 0x04000FE1 RID: 4065
	private static readonly IntPtr NativeFieldInfoPtr_connectButtonLabel;

	// Token: 0x04000FE2 RID: 4066
	private static readonly IntPtr NativeFieldInfoPtr_scoreSubmit;

	// Token: 0x04000FE3 RID: 4067
	private static readonly IntPtr NativeFieldInfoPtr_scoreSubmitLabel;

	// Token: 0x04000FE4 RID: 4068
	private static readonly IntPtr NativeFieldInfoPtr_playerLabel;

	// Token: 0x04000FE5 RID: 4069
	private static readonly IntPtr NativeFieldInfoPtr_ConnectionDependedntButtons;

	// Token: 0x04000FE6 RID: 4070
	private static readonly IntPtr NativeFieldInfoPtr_a_id;

	// Token: 0x04000FE7 RID: 4071
	private static readonly IntPtr NativeFieldInfoPtr_a_name;

	// Token: 0x04000FE8 RID: 4072
	private static readonly IntPtr NativeFieldInfoPtr_a_descr;

	// Token: 0x04000FE9 RID: 4073
	private static readonly IntPtr NativeFieldInfoPtr_a_type;

	// Token: 0x04000FEA RID: 4074
	private static readonly IntPtr NativeFieldInfoPtr_a_state;

	// Token: 0x04000FEB RID: 4075
	private static readonly IntPtr NativeFieldInfoPtr_a_steps;

	// Token: 0x04000FEC RID: 4076
	private static readonly IntPtr NativeFieldInfoPtr_a_total;

	// Token: 0x04000FED RID: 4077
	private static readonly IntPtr NativeFieldInfoPtr_b_id;

	// Token: 0x04000FEE RID: 4078
	private static readonly IntPtr NativeFieldInfoPtr_b_name;

	// Token: 0x04000FEF RID: 4079
	private static readonly IntPtr NativeFieldInfoPtr_b_all_time;

	// Token: 0x04000FF0 RID: 4080
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000FF1 RID: 4081
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000FF2 RID: 4082
	private static readonly IntPtr NativeMethodInfoPtr_ConncetButtonPress_Public_Void_0;

	// Token: 0x04000FF3 RID: 4083
	private static readonly IntPtr NativeMethodInfoPtr_GetAccs_Public_Void_0;

	// Token: 0x04000FF4 RID: 4084
	private static readonly IntPtr NativeMethodInfoPtr_RetrieveToken_Public_Void_0;

	// Token: 0x04000FF5 RID: 4085
	private static readonly IntPtr NativeMethodInfoPtr_showLeaderBoardsUI_Public_Void_0;

	// Token: 0x04000FF6 RID: 4086
	private static readonly IntPtr NativeMethodInfoPtr_loadLeaderBoards_Public_Void_0;

	// Token: 0x04000FF7 RID: 4087
	private static readonly IntPtr NativeMethodInfoPtr_showLeaderBoard_Public_Void_0;

	// Token: 0x04000FF8 RID: 4088
	private static readonly IntPtr NativeMethodInfoPtr_submitScore_Public_Void_0;

	// Token: 0x04000FF9 RID: 4089
	private static readonly IntPtr NativeMethodInfoPtr_ResetBoard_Public_Void_0;

	// Token: 0x04000FFA RID: 4090
	private static readonly IntPtr NativeMethodInfoPtr_showAchievementsUI_Public_Void_0;

	// Token: 0x04000FFB RID: 4091
	private static readonly IntPtr NativeMethodInfoPtr_loadAchievements_Public_Void_0;

	// Token: 0x04000FFC RID: 4092
	private static readonly IntPtr NativeMethodInfoPtr_reportAchievement_Public_Void_0;

	// Token: 0x04000FFD RID: 4093
	private static readonly IntPtr NativeMethodInfoPtr_incrementAchievement_Public_Void_0;

	// Token: 0x04000FFE RID: 4094
	private static readonly IntPtr NativeMethodInfoPtr_revealAchievement_Public_Void_0;

	// Token: 0x04000FFF RID: 4095
	private static readonly IntPtr NativeMethodInfoPtr_ResetAchievement_Public_Void_0;

	// Token: 0x04001000 RID: 4096
	private static readonly IntPtr NativeMethodInfoPtr_ResetAllAchievements_Public_Void_0;

	// Token: 0x04001001 RID: 4097
	private static readonly IntPtr NativeMethodInfoPtr_SendGiftRequest_Public_Void_0;

	// Token: 0x04001002 RID: 4098
	private static readonly IntPtr NativeMethodInfoPtr_OpenInbox_Public_Void_0;

	// Token: 0x04001003 RID: 4099
	private static readonly IntPtr NativeMethodInfoPtr_clearDefaultAccount_Public_Void_0;

	// Token: 0x04001004 RID: 4100
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x04001005 RID: 4101
	private static readonly IntPtr NativeMethodInfoPtr_RequestAdvertisingId_Public_Void_0;

	// Token: 0x04001006 RID: 4102
	private static readonly IntPtr NativeMethodInfoPtr_ActionAdvertisingIdLoaded_Private_Void_GP_AdvertisingIdLoadResult_0;

	// Token: 0x04001007 RID: 4103
	private static readonly IntPtr NativeMethodInfoPtr_OnAchievmnetsLoadedInfoListner_Private_Void_GooglePlayResult_0;

	// Token: 0x04001008 RID: 4104
	private static readonly IntPtr NativeMethodInfoPtr_OnAchievementsLoaded_Private_Void_GooglePlayResult_0;

	// Token: 0x04001009 RID: 4105
	private static readonly IntPtr NativeMethodInfoPtr_OnAchievementUpdated_Private_Void_GP_AchievementResult_0;

	// Token: 0x0400100A RID: 4106
	private static readonly IntPtr NativeMethodInfoPtr_OnLeaderBoardsLoaded_Private_Void_GooglePlayResult_0;

	// Token: 0x0400100B RID: 4107
	private static readonly IntPtr NativeMethodInfoPtr_UpdateBoardInfo_Private_Void_0;

	// Token: 0x0400100C RID: 4108
	private static readonly IntPtr NativeMethodInfoPtr_OnScoreSubmited_Private_Void_GP_LeaderboardResult_0;

	// Token: 0x0400100D RID: 4109
	private static readonly IntPtr NativeMethodInfoPtr_OnScoreUpdated_Private_Void_GooglePlayResult_0;

	// Token: 0x0400100E RID: 4110
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0;

	// Token: 0x0400100F RID: 4111
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0;

	// Token: 0x04001010 RID: 4112
	private static readonly IntPtr NativeMethodInfoPtr_ActionConnectionResultReceived_Private_Void_GooglePlayConnectionResult_0;

	// Token: 0x04001011 RID: 4113
	private static readonly IntPtr NativeMethodInfoPtr_OnGiftResult_Private_Void_GooglePlayGiftRequestResult_0;

	// Token: 0x04001012 RID: 4114
	private static readonly IntPtr NativeMethodInfoPtr_OnPendingGiftsDetected_Private_Void_List_1_GPGameRequest_0;

	// Token: 0x04001013 RID: 4115
	private static readonly IntPtr NativeMethodInfoPtr_OnPromtGiftDialogClose_Private_Void_AndroidDialogResult_0;

	// Token: 0x04001014 RID: 4116
	private static readonly IntPtr NativeMethodInfoPtr_OnGameRequestAccepted_Private_Void_List_1_GPGameRequest_0;

	// Token: 0x04001015 RID: 4117
	private static readonly IntPtr NativeMethodInfoPtr_ActionAvailableDeviceAccountsLoaded_Private_Void_List_1_String_0;

	// Token: 0x04001016 RID: 4118
	private static readonly IntPtr NativeMethodInfoPtr_SighDialogComplete_Private_Void_AndroidDialogResult_0;

	// Token: 0x04001017 RID: 4119
	private static readonly IntPtr NativeMethodInfoPtr_ActionOAuthTokenLoaded_Private_Void_String_0;

	// Token: 0x04001018 RID: 4120
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

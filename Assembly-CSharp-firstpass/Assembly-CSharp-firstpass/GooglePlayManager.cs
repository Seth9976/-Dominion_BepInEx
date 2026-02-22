using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using SA.Common.Pattern;
using UnityEngine;

// Token: 0x02000034 RID: 52
public class GooglePlayManager : Singleton<GooglePlayManager>
{
	// Token: 0x060004E8 RID: 1256 RVA: 0x000275EC File Offset: 0x000257EC
	// Note: this type is marked as 'beforefieldinit'.
	static GooglePlayManager()
	{
		Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GooglePlayManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr);
		GooglePlayManager.NativeFieldInfoPtr_ActionScoreSubmited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "ActionScoreSubmited");
		GooglePlayManager.NativeFieldInfoPtr_ActionScoresListLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "ActionScoresListLoaded");
		GooglePlayManager.NativeFieldInfoPtr_ActionLeaderboardsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "ActionLeaderboardsLoaded");
		GooglePlayManager.NativeFieldInfoPtr_ActionAchievementUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "ActionAchievementUpdated");
		GooglePlayManager.NativeFieldInfoPtr_ActionFriendsListLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "ActionFriendsListLoaded");
		GooglePlayManager.NativeFieldInfoPtr_ActionAchievementsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "ActionAchievementsLoaded");
		GooglePlayManager.NativeFieldInfoPtr_ActionSendGiftResultReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "ActionSendGiftResultReceived");
		GooglePlayManager.NativeFieldInfoPtr_ActionRequestsInboxDialogDismissed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "ActionRequestsInboxDialogDismissed");
		GooglePlayManager.NativeFieldInfoPtr_ActionPendingGameRequestsDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "ActionPendingGameRequestsDetected");
		GooglePlayManager.NativeFieldInfoPtr_ActionGameRequestsAccepted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "ActionGameRequestsAccepted");
		GooglePlayManager.NativeFieldInfoPtr_ActionAvailableDeviceAccountsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "ActionAvailableDeviceAccountsLoaded");
		GooglePlayManager.NativeFieldInfoPtr_ActionOAuthTokenLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "ActionOAuthTokenLoaded");
		GooglePlayManager.NativeFieldInfoPtr_ActionServerAuthCodeLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "ActionServerAuthCodeLoaded");
		GooglePlayManager.NativeFieldInfoPtr__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "_player");
		GooglePlayManager.NativeFieldInfoPtr__players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "_players");
		GooglePlayManager.NativeFieldInfoPtr__friendsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "_friendsList");
		GooglePlayManager.NativeFieldInfoPtr__deviceGoogleAccountList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "_deviceGoogleAccountList");
		GooglePlayManager.NativeFieldInfoPtr__gameRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "_gameRequests");
		GooglePlayManager.NativeFieldInfoPtr__loadedAuthToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "_loadedAuthToken");
		GooglePlayManager.NativeFieldInfoPtr__currentAccount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "_currentAccount");
		GooglePlayManager.NativeFieldInfoPtr__IsLeaderboardsDataLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "_IsLeaderboardsDataLoaded");
		GooglePlayManager.NativeMethodInfoPtr_add_ActionScoreSubmited_Public_Static_add_Void_Action_1_GP_LeaderboardResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663877);
		GooglePlayManager.NativeMethodInfoPtr_remove_ActionScoreSubmited_Public_Static_rem_Void_Action_1_GP_LeaderboardResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663878);
		GooglePlayManager.NativeMethodInfoPtr_add_ActionScoresListLoaded_Public_Static_add_Void_Action_1_GP_LeaderboardResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663879);
		GooglePlayManager.NativeMethodInfoPtr_remove_ActionScoresListLoaded_Public_Static_rem_Void_Action_1_GP_LeaderboardResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663880);
		GooglePlayManager.NativeMethodInfoPtr_add_ActionLeaderboardsLoaded_Public_Static_add_Void_Action_1_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663881);
		GooglePlayManager.NativeMethodInfoPtr_remove_ActionLeaderboardsLoaded_Public_Static_rem_Void_Action_1_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663882);
		GooglePlayManager.NativeMethodInfoPtr_add_ActionAchievementUpdated_Public_Static_add_Void_Action_1_GP_AchievementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663883);
		GooglePlayManager.NativeMethodInfoPtr_remove_ActionAchievementUpdated_Public_Static_rem_Void_Action_1_GP_AchievementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663884);
		GooglePlayManager.NativeMethodInfoPtr_add_ActionFriendsListLoaded_Public_Static_add_Void_Action_1_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663885);
		GooglePlayManager.NativeMethodInfoPtr_remove_ActionFriendsListLoaded_Public_Static_rem_Void_Action_1_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663886);
		GooglePlayManager.NativeMethodInfoPtr_add_ActionAchievementsLoaded_Public_Static_add_Void_Action_1_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663887);
		GooglePlayManager.NativeMethodInfoPtr_remove_ActionAchievementsLoaded_Public_Static_rem_Void_Action_1_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663888);
		GooglePlayManager.NativeMethodInfoPtr_add_ActionSendGiftResultReceived_Public_Static_add_Void_Action_1_GooglePlayGiftRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663889);
		GooglePlayManager.NativeMethodInfoPtr_remove_ActionSendGiftResultReceived_Public_Static_rem_Void_Action_1_GooglePlayGiftRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663890);
		GooglePlayManager.NativeMethodInfoPtr_add_ActionRequestsInboxDialogDismissed_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663891);
		GooglePlayManager.NativeMethodInfoPtr_remove_ActionRequestsInboxDialogDismissed_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663892);
		GooglePlayManager.NativeMethodInfoPtr_add_ActionPendingGameRequestsDetected_Public_Static_add_Void_Action_1_List_1_GPGameRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663893);
		GooglePlayManager.NativeMethodInfoPtr_remove_ActionPendingGameRequestsDetected_Public_Static_rem_Void_Action_1_List_1_GPGameRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663894);
		GooglePlayManager.NativeMethodInfoPtr_add_ActionGameRequestsAccepted_Public_Static_add_Void_Action_1_List_1_GPGameRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663895);
		GooglePlayManager.NativeMethodInfoPtr_remove_ActionGameRequestsAccepted_Public_Static_rem_Void_Action_1_List_1_GPGameRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663896);
		GooglePlayManager.NativeMethodInfoPtr_add_ActionAvailableDeviceAccountsLoaded_Public_Static_add_Void_Action_1_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663897);
		GooglePlayManager.NativeMethodInfoPtr_remove_ActionAvailableDeviceAccountsLoaded_Public_Static_rem_Void_Action_1_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663898);
		GooglePlayManager.NativeMethodInfoPtr_add_ActionOAuthTokenLoaded_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663899);
		GooglePlayManager.NativeMethodInfoPtr_remove_ActionOAuthTokenLoaded_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663900);
		GooglePlayManager.NativeMethodInfoPtr_add_ActionServerAuthCodeLoaded_Public_Static_add_Void_Action_2_GooglePlayResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663901);
		GooglePlayManager.NativeMethodInfoPtr_remove_ActionServerAuthCodeLoaded_Public_Static_rem_Void_Action_2_GooglePlayResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663902);
		GooglePlayManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663903);
		GooglePlayManager.NativeMethodInfoPtr_Create_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663904);
		GooglePlayManager.NativeMethodInfoPtr_GetPlayServicesStatus_Public_GP_PlayServicesStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663905);
		GooglePlayManager.NativeMethodInfoPtr_RetrieveDeviceGoogleAccounts_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663906);
		GooglePlayManager.NativeMethodInfoPtr_LoadToken_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663907);
		GooglePlayManager.NativeMethodInfoPtr_LoadToken_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663908);
		GooglePlayManager.NativeMethodInfoPtr_GetGamesServerAuthCode_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663909);
		GooglePlayManager.NativeMethodInfoPtr_InvalidateToken_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663910);
		GooglePlayManager.NativeMethodInfoPtr_ShowAchievementsUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663911);
		GooglePlayManager.NativeMethodInfoPtr_ShowLeaderBoardsUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663912);
		GooglePlayManager.NativeMethodInfoPtr_ShowLeaderBoard_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663913);
		GooglePlayManager.NativeMethodInfoPtr_ShowLeaderBoardById_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663914);
		GooglePlayManager.NativeMethodInfoPtr_SubmitScore_Public_Void_String_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663915);
		GooglePlayManager.NativeMethodInfoPtr_SubmitScoreById_Public_Void_String_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663916);
		GooglePlayManager.NativeMethodInfoPtr_LoadLeaderBoards_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663917);
		GooglePlayManager.NativeMethodInfoPtr_UpdatePlayerScoreLocal_Public_Void_GPLeaderBoard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663918);
		GooglePlayManager.NativeMethodInfoPtr_LoadPlayerCenteredScores_Public_Void_String_GPBoardTimeSpan_GPCollectionType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663919);
		GooglePlayManager.NativeMethodInfoPtr_LoadTopScores_Public_Void_String_GPBoardTimeSpan_GPCollectionType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663920);
		GooglePlayManager.NativeMethodInfoPtr_UnlockAchievement_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663921);
		GooglePlayManager.NativeMethodInfoPtr_UnlockAchievementById_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663922);
		GooglePlayManager.NativeMethodInfoPtr_RevealAchievement_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663923);
		GooglePlayManager.NativeMethodInfoPtr_RevealAchievementById_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663924);
		GooglePlayManager.NativeMethodInfoPtr_IncrementAchievement_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663925);
		GooglePlayManager.NativeMethodInfoPtr_IncrementAchievementById_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663926);
		GooglePlayManager.NativeMethodInfoPtr_SetStepsImmediate_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663927);
		GooglePlayManager.NativeMethodInfoPtr_LoadAchievements_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663928);
		GooglePlayManager.NativeMethodInfoPtr_ResetAchievement_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663929);
		GooglePlayManager.NativeMethodInfoPtr_ResetAllAchievements_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663930);
		GooglePlayManager.NativeMethodInfoPtr_ResetLeaderBoard_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663931);
		GooglePlayManager.NativeMethodInfoPtr_LoadFriends_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663932);
		GooglePlayManager.NativeMethodInfoPtr_SendGiftRequest_Public_Void_GPGameRequestType_Int32_Texture2D_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663933);
		GooglePlayManager.NativeMethodInfoPtr_get_currentAccount_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663934);
		GooglePlayManager.NativeMethodInfoPtr_ShowRequestsAccepDialog_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663935);
		GooglePlayManager.NativeMethodInfoPtr_AcceptRequests_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663936);
		GooglePlayManager.NativeMethodInfoPtr_DismissRequest_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663937);
		GooglePlayManager.NativeMethodInfoPtr_DispatchLeaderboardUpdateEvent_Public_Void_GP_LeaderboardResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663938);
		GooglePlayManager.NativeMethodInfoPtr_GetLeaderBoard_Public_GPLeaderBoard_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663939);
		GooglePlayManager.NativeMethodInfoPtr_GetAchievement_Public_GPAchievement_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663940);
		GooglePlayManager.NativeMethodInfoPtr_GetPlayerById_Public_GooglePlayerTemplate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663941);
		GooglePlayManager.NativeMethodInfoPtr_GetGameRequestById_Public_GPGameRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663942);
		GooglePlayManager.NativeMethodInfoPtr_get_player_Public_get_GooglePlayerTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663943);
		GooglePlayManager.NativeMethodInfoPtr_get_players_Public_get_Dictionary_2_String_GooglePlayerTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663944);
		GooglePlayManager.NativeMethodInfoPtr_get_LeaderBoards_Public_get_List_1_GPLeaderBoard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663945);
		GooglePlayManager.NativeMethodInfoPtr_get_Achievements_Public_get_List_1_GPAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663946);
		GooglePlayManager.NativeMethodInfoPtr_get_friendsList_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663947);
		GooglePlayManager.NativeMethodInfoPtr_get_gameRequests_Public_get_List_1_GPGameRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663948);
		GooglePlayManager.NativeMethodInfoPtr_get_deviceGoogleAccountList_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663949);
		GooglePlayManager.NativeMethodInfoPtr_get_loadedAuthToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663950);
		GooglePlayManager.NativeMethodInfoPtr_get_IsLeaderboardsDataLoaded_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663951);
		GooglePlayManager.NativeMethodInfoPtr_OnGiftSendResult_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663952);
		GooglePlayManager.NativeMethodInfoPtr_OnRequestsInboxDialogDismissed_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663953);
		GooglePlayManager.NativeMethodInfoPtr_OnAchievementsLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663954);
		GooglePlayManager.NativeMethodInfoPtr_OnAchievementUpdated_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663955);
		GooglePlayManager.NativeMethodInfoPtr_OnScoreDataRecevied_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663956);
		GooglePlayManager.NativeMethodInfoPtr_OnLeaderboardDataLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663957);
		GooglePlayManager.NativeMethodInfoPtr_OnPlayerScoreUpdated_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663958);
		GooglePlayManager.NativeMethodInfoPtr_OnScoreSubmitted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663959);
		GooglePlayManager.NativeMethodInfoPtr_OnPlayerDataLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663960);
		GooglePlayManager.NativeMethodInfoPtr_OnPlayersLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663961);
		GooglePlayManager.NativeMethodInfoPtr_OnGameRequestsLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663962);
		GooglePlayManager.NativeMethodInfoPtr_OnGameRequestsAccepted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663963);
		GooglePlayManager.NativeMethodInfoPtr_OnAccountsLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663964);
		GooglePlayManager.NativeMethodInfoPtr_OnTokenLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663965);
		GooglePlayManager.NativeMethodInfoPtr_OnGamesServerAuthCodeLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663966);
		GooglePlayManager.NativeMethodInfoPtr_ParseParticipanData_Public_Static_GP_Participant_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663967);
		GooglePlayManager.NativeMethodInfoPtr_ParseParticipantsData_Public_Static_List_1_GP_Participant_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663968);
		GooglePlayManager.NativeMethodInfoPtr_AddPlayer_Private_Void_GooglePlayerTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663969);
		GooglePlayManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, 100663970);
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x00027F18 File Offset: 0x00026118
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 164551, RefRangeEnd = 164553, XrefRangeStart = 164540, XrefRangeEnd = 164551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionScoreSubmited(Action<GP_LeaderboardResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_add_ActionScoreSubmited_Public_Static_add_Void_Action_1_GP_LeaderboardResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x00027F50 File Offset: 0x00026150
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 164564, RefRangeEnd = 164566, XrefRangeStart = 164553, XrefRangeEnd = 164564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionScoreSubmited(Action<GP_LeaderboardResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_remove_ActionScoreSubmited_Public_Static_rem_Void_Action_1_GP_LeaderboardResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x00027F88 File Offset: 0x00026188
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 164577, RefRangeEnd = 164579, XrefRangeStart = 164566, XrefRangeEnd = 164577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionScoresListLoaded(Action<GP_LeaderboardResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_add_ActionScoresListLoaded_Public_Static_add_Void_Action_1_GP_LeaderboardResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x00027FC0 File Offset: 0x000261C0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 164590, RefRangeEnd = 164592, XrefRangeStart = 164579, XrefRangeEnd = 164590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionScoresListLoaded(Action<GP_LeaderboardResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_remove_ActionScoresListLoaded_Public_Static_rem_Void_Action_1_GP_LeaderboardResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004ED RID: 1261 RVA: 0x00027FF8 File Offset: 0x000261F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164592, XrefRangeEnd = 164603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionLeaderboardsLoaded(Action<GooglePlayResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_add_ActionLeaderboardsLoaded_Public_Static_add_Void_Action_1_GooglePlayResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x00028030 File Offset: 0x00026230
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164614, RefRangeEnd = 164615, XrefRangeStart = 164603, XrefRangeEnd = 164614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionLeaderboardsLoaded(Action<GooglePlayResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_remove_ActionLeaderboardsLoaded_Public_Static_rem_Void_Action_1_GooglePlayResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x00028068 File Offset: 0x00026268
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164626, RefRangeEnd = 164627, XrefRangeStart = 164615, XrefRangeEnd = 164626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionAchievementUpdated(Action<GP_AchievementResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_add_ActionAchievementUpdated_Public_Static_add_Void_Action_1_GP_AchievementResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x000280A0 File Offset: 0x000262A0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164638, RefRangeEnd = 164639, XrefRangeStart = 164627, XrefRangeEnd = 164638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionAchievementUpdated(Action<GP_AchievementResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_remove_ActionAchievementUpdated_Public_Static_rem_Void_Action_1_GP_AchievementResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x000280D8 File Offset: 0x000262D8
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 164650, RefRangeEnd = 164654, XrefRangeStart = 164639, XrefRangeEnd = 164650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionFriendsListLoaded(Action<GooglePlayResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_add_ActionFriendsListLoaded_Public_Static_add_Void_Action_1_GooglePlayResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x00028110 File Offset: 0x00026310
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 164665, RefRangeEnd = 164667, XrefRangeStart = 164654, XrefRangeEnd = 164665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionFriendsListLoaded(Action<GooglePlayResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_remove_ActionFriendsListLoaded_Public_Static_rem_Void_Action_1_GooglePlayResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x00028148 File Offset: 0x00026348
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 164678, RefRangeEnd = 164681, XrefRangeStart = 164667, XrefRangeEnd = 164678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionAchievementsLoaded(Action<GooglePlayResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_add_ActionAchievementsLoaded_Public_Static_add_Void_Action_1_GooglePlayResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x00028180 File Offset: 0x00026380
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 164692, RefRangeEnd = 164695, XrefRangeStart = 164681, XrefRangeEnd = 164692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionAchievementsLoaded(Action<GooglePlayResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_remove_ActionAchievementsLoaded_Public_Static_rem_Void_Action_1_GooglePlayResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004F5 RID: 1269 RVA: 0x000281B8 File Offset: 0x000263B8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164706, RefRangeEnd = 164707, XrefRangeStart = 164695, XrefRangeEnd = 164706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionSendGiftResultReceived(Action<GooglePlayGiftRequestResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_add_ActionSendGiftResultReceived_Public_Static_add_Void_Action_1_GooglePlayGiftRequestResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x000281F0 File Offset: 0x000263F0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164718, RefRangeEnd = 164719, XrefRangeStart = 164707, XrefRangeEnd = 164718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionSendGiftResultReceived(Action<GooglePlayGiftRequestResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_remove_ActionSendGiftResultReceived_Public_Static_rem_Void_Action_1_GooglePlayGiftRequestResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004F7 RID: 1271 RVA: 0x00028228 File Offset: 0x00026428
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164719, XrefRangeEnd = 164730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionRequestsInboxDialogDismissed(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_add_ActionRequestsInboxDialogDismissed_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x00028260 File Offset: 0x00026460
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164730, XrefRangeEnd = 164741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionRequestsInboxDialogDismissed(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_remove_ActionRequestsInboxDialogDismissed_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x00028298 File Offset: 0x00026498
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164752, RefRangeEnd = 164753, XrefRangeStart = 164741, XrefRangeEnd = 164752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionPendingGameRequestsDetected(Action<List<GPGameRequest>> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_add_ActionPendingGameRequestsDetected_Public_Static_add_Void_Action_1_List_1_GPGameRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004FA RID: 1274 RVA: 0x000282D0 File Offset: 0x000264D0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164764, RefRangeEnd = 164765, XrefRangeStart = 164753, XrefRangeEnd = 164764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionPendingGameRequestsDetected(Action<List<GPGameRequest>> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_remove_ActionPendingGameRequestsDetected_Public_Static_rem_Void_Action_1_List_1_GPGameRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004FB RID: 1275 RVA: 0x00028308 File Offset: 0x00026508
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164776, RefRangeEnd = 164777, XrefRangeStart = 164765, XrefRangeEnd = 164776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionGameRequestsAccepted(Action<List<GPGameRequest>> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_add_ActionGameRequestsAccepted_Public_Static_add_Void_Action_1_List_1_GPGameRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004FC RID: 1276 RVA: 0x00028340 File Offset: 0x00026540
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164788, RefRangeEnd = 164789, XrefRangeStart = 164777, XrefRangeEnd = 164788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionGameRequestsAccepted(Action<List<GPGameRequest>> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_remove_ActionGameRequestsAccepted_Public_Static_rem_Void_Action_1_List_1_GPGameRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x00028378 File Offset: 0x00026578
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164800, RefRangeEnd = 164801, XrefRangeStart = 164789, XrefRangeEnd = 164800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionAvailableDeviceAccountsLoaded(Action<List<string>> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_add_ActionAvailableDeviceAccountsLoaded_Public_Static_add_Void_Action_1_List_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x000283B0 File Offset: 0x000265B0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164812, RefRangeEnd = 164813, XrefRangeStart = 164801, XrefRangeEnd = 164812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionAvailableDeviceAccountsLoaded(Action<List<string>> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_remove_ActionAvailableDeviceAccountsLoaded_Public_Static_rem_Void_Action_1_List_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x000283E8 File Offset: 0x000265E8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164824, RefRangeEnd = 164825, XrefRangeStart = 164813, XrefRangeEnd = 164824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionOAuthTokenLoaded(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_add_ActionOAuthTokenLoaded_Public_Static_add_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x00028420 File Offset: 0x00026620
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164836, RefRangeEnd = 164837, XrefRangeStart = 164825, XrefRangeEnd = 164836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionOAuthTokenLoaded(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_remove_ActionOAuthTokenLoaded_Public_Static_rem_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x00028458 File Offset: 0x00026658
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164837, XrefRangeEnd = 164848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionServerAuthCodeLoaded(Action<GooglePlayResult, string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_add_ActionServerAuthCodeLoaded_Public_Static_add_Void_Action_2_GooglePlayResult_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x00028490 File Offset: 0x00026690
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164848, XrefRangeEnd = 164859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionServerAuthCodeLoaded(Action<GooglePlayResult, string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_remove_ActionServerAuthCodeLoaded_Public_Static_rem_Void_Action_2_GooglePlayResult_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000503 RID: 1283 RVA: 0x000284C8 File Offset: 0x000266C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164859, XrefRangeEnd = 164864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000504 RID: 1284 RVA: 0x000284FC File Offset: 0x000266FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164864, XrefRangeEnd = 164878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Create()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_Create_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000505 RID: 1285 RVA: 0x00028530 File Offset: 0x00026730
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164878, XrefRangeEnd = 164879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_PlayServicesStatus GetPlayServicesStatus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_GetPlayServicesStatus_Public_GP_PlayServicesStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000506 RID: 1286 RVA: 0x0002856C File Offset: 0x0002676C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164880, RefRangeEnd = 164881, XrefRangeStart = 164879, XrefRangeEnd = 164880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RetrieveDeviceGoogleAccounts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_RetrieveDeviceGoogleAccounts_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000507 RID: 1287 RVA: 0x000285A0 File Offset: 0x000267A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164881, XrefRangeEnd = 164882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadToken(string accountName, string scopes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(accountName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(scopes);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_LoadToken_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000508 RID: 1288 RVA: 0x000285F4 File Offset: 0x000267F4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164885, RefRangeEnd = 164886, XrefRangeStart = 164882, XrefRangeEnd = 164885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadToken()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_LoadToken_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000509 RID: 1289 RVA: 0x00028628 File Offset: 0x00026828
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164886, XrefRangeEnd = 164887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetGamesServerAuthCode(string webClientAppId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(webClientAppId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_GetGamesServerAuthCode_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600050A RID: 1290 RVA: 0x0002866C File Offset: 0x0002686C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164887, XrefRangeEnd = 164888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InvalidateToken(string token)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_InvalidateToken_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600050B RID: 1291 RVA: 0x000286B0 File Offset: 0x000268B0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164897, RefRangeEnd = 164898, XrefRangeStart = 164888, XrefRangeEnd = 164897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowAchievementsUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_ShowAchievementsUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600050C RID: 1292 RVA: 0x000286E4 File Offset: 0x000268E4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164907, RefRangeEnd = 164908, XrefRangeStart = 164898, XrefRangeEnd = 164907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowLeaderBoardsUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_ShowLeaderBoardsUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600050D RID: 1293 RVA: 0x00028718 File Offset: 0x00026918
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164908, XrefRangeEnd = 164917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowLeaderBoard(string leaderboardName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(leaderboardName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_ShowLeaderBoard_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600050E RID: 1294 RVA: 0x0002875C File Offset: 0x0002695C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 164926, RefRangeEnd = 164928, XrefRangeStart = 164917, XrefRangeEnd = 164926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowLeaderBoardById(string leaderboardId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(leaderboardId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_ShowLeaderBoardById_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x000287A0 File Offset: 0x000269A0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164949, RefRangeEnd = 164950, XrefRangeStart = 164928, XrefRangeEnd = 164949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitScore(string leaderboardName, long score, string tag = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(leaderboardName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tag);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_SubmitScore_Public_Void_String_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000510 RID: 1296 RVA: 0x00028804 File Offset: 0x00026A04
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 164971, RefRangeEnd = 164972, XrefRangeStart = 164950, XrefRangeEnd = 164971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitScoreById(string leaderboardId, long score, string tag = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(leaderboardId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tag);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_SubmitScoreById_Public_Void_String_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000511 RID: 1297 RVA: 0x00028868 File Offset: 0x00026A68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164972, XrefRangeEnd = 164981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadLeaderBoards()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_LoadLeaderBoards_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x0002889C File Offset: 0x00026A9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164981, XrefRangeEnd = 165010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePlayerScoreLocal(GPLeaderBoard leaderboard)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(leaderboard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_UpdatePlayerScoreLocal_Public_Void_GPLeaderBoard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x000288E0 File Offset: 0x00026AE0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 165019, RefRangeEnd = 165021, XrefRangeStart = 165010, XrefRangeEnd = 165019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadPlayerCenteredScores(string leaderboardId, GPBoardTimeSpan span, GPCollectionType collection, int maxResults)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(leaderboardId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref span;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref collection;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxResults;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_LoadPlayerCenteredScores_Public_Void_String_GPBoardTimeSpan_GPCollectionType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x0002894C File Offset: 0x00026B4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165021, XrefRangeEnd = 165030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadTopScores(string leaderboardId, GPBoardTimeSpan span, GPCollectionType collection, int maxResults)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(leaderboardId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref span;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref collection;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxResults;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_LoadTopScores_Public_Void_String_GPBoardTimeSpan_GPCollectionType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x000289B8 File Offset: 0x00026BB8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 165049, RefRangeEnd = 165051, XrefRangeStart = 165030, XrefRangeEnd = 165049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlockAchievement(string achievementName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_UnlockAchievement_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x000289FC File Offset: 0x00026BFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165051, XrefRangeEnd = 165070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlockAchievementById(string achievementId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_UnlockAchievementById_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x00028A40 File Offset: 0x00026C40
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 165089, RefRangeEnd = 165090, XrefRangeStart = 165070, XrefRangeEnd = 165089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RevealAchievement(string achievementName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_RevealAchievement_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x00028A84 File Offset: 0x00026C84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165090, XrefRangeEnd = 165109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RevealAchievementById(string achievementId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_RevealAchievementById_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x00028AC8 File Offset: 0x00026CC8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 165133, RefRangeEnd = 165134, XrefRangeStart = 165109, XrefRangeEnd = 165133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IncrementAchievement(string achievementName, int numsteps)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numsteps;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_IncrementAchievement_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x00028B18 File Offset: 0x00026D18
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 165158, RefRangeEnd = 165159, XrefRangeStart = 165134, XrefRangeEnd = 165158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IncrementAchievementById(string achievementId, int numsteps)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numsteps;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_IncrementAchievementById_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x00028B68 File Offset: 0x00026D68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165159, XrefRangeEnd = 165169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStepsImmediate(string achievementId, int numsteps)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numsteps;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_SetStepsImmediate_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x00028BB8 File Offset: 0x00026DB8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 165178, RefRangeEnd = 165180, XrefRangeStart = 165169, XrefRangeEnd = 165178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAchievements()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_LoadAchievements_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x00028BEC File Offset: 0x00026DEC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 165189, RefRangeEnd = 165190, XrefRangeStart = 165180, XrefRangeEnd = 165189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetAchievement(string achievementId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_ResetAchievement_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x00028C30 File Offset: 0x00026E30
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 165199, RefRangeEnd = 165200, XrefRangeStart = 165190, XrefRangeEnd = 165199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetAllAchievements()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_ResetAllAchievements_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x00028C64 File Offset: 0x00026E64
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 165234, RefRangeEnd = 165235, XrefRangeStart = 165200, XrefRangeEnd = 165234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetLeaderBoard(string leaderboardId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(leaderboardId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_ResetLeaderBoard_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x00028CA8 File Offset: 0x00026EA8
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 165244, RefRangeEnd = 165248, XrefRangeStart = 165235, XrefRangeEnd = 165244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadFriends()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_LoadFriends_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x00028CDC File Offset: 0x00026EDC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 165262, RefRangeEnd = 165263, XrefRangeStart = 165248, XrefRangeEnd = 165262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendGiftRequest(GPGameRequestType type, int requestLifetimeDays, Texture2D icon, string description, string playload = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref type;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requestLifetimeDays;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(icon);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(playload);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_SendGiftRequest_Public_Void_GPGameRequestType_Int32_Texture2D_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170001AD RID: 429
	// (get) Token: 0x06000522 RID: 1314 RVA: 0x00028D60 File Offset: 0x00026F60
	public unsafe string currentAccount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_get_currentAccount_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x00028D98 File Offset: 0x00026F98
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 165272, RefRangeEnd = 165274, XrefRangeStart = 165263, XrefRangeEnd = 165272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowRequestsAccepDialog()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_ShowRequestsAccepDialog_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x00028DCC File Offset: 0x00026FCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165274, XrefRangeEnd = 165286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AcceptRequests([Optional] Il2CppStringArray ids)
	{
		if (ids == null)
		{
			ids = new Il2CppStringArray(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_AcceptRequests_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x00028E1C File Offset: 0x0002701C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165286, XrefRangeEnd = 165298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DismissRequest([Optional] Il2CppStringArray ids)
	{
		if (ids == null)
		{
			ids = new Il2CppStringArray(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_DismissRequest_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x00028E6C File Offset: 0x0002706C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165298, XrefRangeEnd = 165306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchLeaderboardUpdateEvent(GP_LeaderboardResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_DispatchLeaderboardUpdateEvent_Public_Void_GP_LeaderboardResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x00028EB0 File Offset: 0x000270B0
	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 165354, RefRangeEnd = 165367, XrefRangeStart = 165306, XrefRangeEnd = 165354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPLeaderBoard GetLeaderBoard(string leaderboardId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(leaderboardId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_GetLeaderBoard_Public_GPLeaderBoard_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GPLeaderBoard>(intPtr3) : null;
		}
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x00028F00 File Offset: 0x00027100
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 165388, RefRangeEnd = 165389, XrefRangeStart = 165367, XrefRangeEnd = 165388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPAchievement GetAchievement(string achievementId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(achievementId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_GetAchievement_Public_GPAchievement_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GPAchievement>(intPtr3) : null;
		}
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x00028F50 File Offset: 0x00027150
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 165393, RefRangeEnd = 165400, XrefRangeStart = 165389, XrefRangeEnd = 165393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePlayerTemplate GetPlayerById(string playerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_GetPlayerById_Public_GooglePlayerTemplate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GooglePlayerTemplate>(intPtr3) : null;
		}
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x00028FA0 File Offset: 0x000271A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165400, XrefRangeEnd = 165417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPGameRequest GetGameRequestById(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_GetGameRequestById_Public_GPGameRequest_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GPGameRequest>(intPtr3) : null;
		}
	}

	// Token: 0x170001AE RID: 430
	// (get) Token: 0x0600052B RID: 1323 RVA: 0x00028FF0 File Offset: 0x000271F0
	public unsafe GooglePlayerTemplate player
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_get_player_Public_get_GooglePlayerTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GooglePlayerTemplate>(intPtr3) : null;
		}
	}

	// Token: 0x170001AF RID: 431
	// (get) Token: 0x0600052C RID: 1324 RVA: 0x00029030 File Offset: 0x00027230
	public unsafe Dictionary<string, GooglePlayerTemplate> players
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_get_players_Public_get_Dictionary_2_String_GooglePlayerTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GooglePlayerTemplate>>(intPtr3) : null;
		}
	}

	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x0600052D RID: 1325 RVA: 0x00029070 File Offset: 0x00027270
	public unsafe List<GPLeaderBoard> LeaderBoards
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 165421, RefRangeEnd = 165424, XrefRangeStart = 165417, XrefRangeEnd = 165421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_get_LeaderBoards_Public_get_List_1_GPLeaderBoard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GPLeaderBoard>>(intPtr3) : null;
		}
	}

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x0600052E RID: 1326 RVA: 0x000290B0 File Offset: 0x000272B0
	public unsafe List<GPAchievement> Achievements
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 165428, RefRangeEnd = 165432, XrefRangeStart = 165424, XrefRangeEnd = 165428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_get_Achievements_Public_get_List_1_GPAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GPAchievement>>(intPtr3) : null;
		}
	}

	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x0600052F RID: 1327 RVA: 0x000290F0 File Offset: 0x000272F0
	public unsafe List<string> friendsList
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_get_friendsList_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}
	}

	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x06000530 RID: 1328 RVA: 0x00029130 File Offset: 0x00027330
	public unsafe List<GPGameRequest> gameRequests
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_get_gameRequests_Public_get_List_1_GPGameRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GPGameRequest>>(intPtr3) : null;
		}
	}

	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x06000531 RID: 1329 RVA: 0x00029170 File Offset: 0x00027370
	public unsafe List<string> deviceGoogleAccountList
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_get_deviceGoogleAccountList_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}
	}

	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x06000532 RID: 1330 RVA: 0x000291B0 File Offset: 0x000273B0
	public unsafe string loadedAuthToken
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_get_loadedAuthToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x06000533 RID: 1331 RVA: 0x000291E8 File Offset: 0x000273E8
	public unsafe static bool IsLeaderboardsDataLoaded
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165432, XrefRangeEnd = 165436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_get_IsLeaderboardsDataLoaded_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x00029218 File Offset: 0x00027418
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165436, XrefRangeEnd = 165469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGiftSendResult(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_OnGiftSendResult_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x0002925C File Offset: 0x0002745C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165469, XrefRangeEnd = 165475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRequestsInboxDialogDismissed(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_OnRequestsInboxDialogDismissed_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x000292A0 File Offset: 0x000274A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165475, XrefRangeEnd = 165532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAchievementsLoaded(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_OnAchievementsLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x000292E4 File Offset: 0x000274E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165532, XrefRangeEnd = 165559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAchievementUpdated(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_OnAchievementUpdated_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x00029328 File Offset: 0x00027528
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165559, XrefRangeEnd = 165651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnScoreDataRecevied(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_OnScoreDataRecevied_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x0002936C File Offset: 0x0002756C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165651, XrefRangeEnd = 165707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLeaderboardDataLoaded(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_OnLeaderboardDataLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x000293B0 File Offset: 0x000275B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165707, XrefRangeEnd = 165763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerScoreUpdated(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_OnPlayerScoreUpdated_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x000293F4 File Offset: 0x000275F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165763, XrefRangeEnd = 165805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnScoreSubmitted(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_OnScoreSubmitted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x00029438 File Offset: 0x00027638
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165805, XrefRangeEnd = 165832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerDataLoaded(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_OnPlayerDataLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x0002947C File Offset: 0x0002767C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165832, XrefRangeEnd = 165877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayersLoaded(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_OnPlayersLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x000294C0 File Offset: 0x000276C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165877, XrefRangeEnd = 165914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGameRequestsLoaded(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_OnGameRequestsLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x00029504 File Offset: 0x00027704
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165914, XrefRangeEnd = 165968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGameRequestsAccepted(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_OnGameRequestsAccepted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x00029548 File Offset: 0x00027748
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165968, XrefRangeEnd = 165997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAccountsLoaded(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_OnAccountsLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x0002958C File Offset: 0x0002778C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165997, XrefRangeEnd = 166005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTokenLoaded(string token)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_OnTokenLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x000295D0 File Offset: 0x000277D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166005, XrefRangeEnd = 166033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGamesServerAuthCodeLoaded(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_OnGamesServerAuthCodeLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x00029614 File Offset: 0x00027814
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 166051, RefRangeEnd = 166053, XrefRangeStart = 166033, XrefRangeEnd = 166051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GP_Participant ParseParticipanData(Il2CppStringArray data, int index)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_ParseParticipanData_Public_Static_GP_Participant_Il2CppStringArray_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GP_Participant>(intPtr3) : null;
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x00029668 File Offset: 0x00027868
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 166070, RefRangeEnd = 166071, XrefRangeStart = 166053, XrefRangeEnd = 166070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<GP_Participant> ParseParticipantsData(Il2CppStringArray data, int index)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_ParseParticipantsData_Public_Static_List_1_GP_Participant_Il2CppStringArray_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GP_Participant>>(intPtr3) : null;
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x000296BC File Offset: 0x000278BC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 166077, RefRangeEnd = 166079, XrefRangeStart = 166071, XrefRangeEnd = 166077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddPlayer(GooglePlayerTemplate p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr_AddPlayer_Private_Void_GooglePlayerTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x00029700 File Offset: 0x00027900
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166079, XrefRangeEnd = 166110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePlayManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x0000406C File Offset: 0x0000226C
	public void AcceptRequests(params string[] ids)
	{
		this.AcceptRequests(new Il2CppStringArray(ids));
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x0000407A File Offset: 0x0000227A
	public void DismissRequest(params string[] ids)
	{
		this.DismissRequest(new Il2CppStringArray(ids));
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x00004088 File Offset: 0x00002288
	public GooglePlayManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x0600054A RID: 1354 RVA: 0x0002973C File Offset: 0x0002793C
	// (set) Token: 0x0600054B RID: 1355 RVA: 0x00004091 File Offset: 0x00002291
	public unsafe static Action<GP_LeaderboardResult> ActionScoreSubmited
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayManager.NativeFieldInfoPtr_ActionScoreSubmited, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_LeaderboardResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayManager.NativeFieldInfoPtr_ActionScoreSubmited, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000199 RID: 409
	// (get) Token: 0x0600054C RID: 1356 RVA: 0x00029764 File Offset: 0x00027964
	// (set) Token: 0x0600054D RID: 1357 RVA: 0x000040A3 File Offset: 0x000022A3
	public unsafe static Action<GP_LeaderboardResult> ActionScoresListLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayManager.NativeFieldInfoPtr_ActionScoresListLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_LeaderboardResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayManager.NativeFieldInfoPtr_ActionScoresListLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x0600054E RID: 1358 RVA: 0x0002978C File Offset: 0x0002798C
	// (set) Token: 0x0600054F RID: 1359 RVA: 0x000040B5 File Offset: 0x000022B5
	public unsafe static Action<GooglePlayResult> ActionLeaderboardsLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayManager.NativeFieldInfoPtr_ActionLeaderboardsLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GooglePlayResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayManager.NativeFieldInfoPtr_ActionLeaderboardsLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x06000550 RID: 1360 RVA: 0x000297B4 File Offset: 0x000279B4
	// (set) Token: 0x06000551 RID: 1361 RVA: 0x000040C7 File Offset: 0x000022C7
	public unsafe static Action<GP_AchievementResult> ActionAchievementUpdated
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayManager.NativeFieldInfoPtr_ActionAchievementUpdated, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_AchievementResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayManager.NativeFieldInfoPtr_ActionAchievementUpdated, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700019C RID: 412
	// (get) Token: 0x06000552 RID: 1362 RVA: 0x000297DC File Offset: 0x000279DC
	// (set) Token: 0x06000553 RID: 1363 RVA: 0x000040D9 File Offset: 0x000022D9
	public unsafe static Action<GooglePlayResult> ActionFriendsListLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayManager.NativeFieldInfoPtr_ActionFriendsListLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GooglePlayResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayManager.NativeFieldInfoPtr_ActionFriendsListLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700019D RID: 413
	// (get) Token: 0x06000554 RID: 1364 RVA: 0x00029804 File Offset: 0x00027A04
	// (set) Token: 0x06000555 RID: 1365 RVA: 0x000040EB File Offset: 0x000022EB
	public unsafe static Action<GooglePlayResult> ActionAchievementsLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayManager.NativeFieldInfoPtr_ActionAchievementsLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GooglePlayResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayManager.NativeFieldInfoPtr_ActionAchievementsLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700019E RID: 414
	// (get) Token: 0x06000556 RID: 1366 RVA: 0x0002982C File Offset: 0x00027A2C
	// (set) Token: 0x06000557 RID: 1367 RVA: 0x000040FD File Offset: 0x000022FD
	public unsafe static Action<GooglePlayGiftRequestResult> ActionSendGiftResultReceived
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayManager.NativeFieldInfoPtr_ActionSendGiftResultReceived, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GooglePlayGiftRequestResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayManager.NativeFieldInfoPtr_ActionSendGiftResultReceived, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x06000558 RID: 1368 RVA: 0x00029854 File Offset: 0x00027A54
	// (set) Token: 0x06000559 RID: 1369 RVA: 0x0000410F File Offset: 0x0000230F
	public unsafe static Action ActionRequestsInboxDialogDismissed
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayManager.NativeFieldInfoPtr_ActionRequestsInboxDialogDismissed, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayManager.NativeFieldInfoPtr_ActionRequestsInboxDialogDismissed, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x0600055A RID: 1370 RVA: 0x0002987C File Offset: 0x00027A7C
	// (set) Token: 0x0600055B RID: 1371 RVA: 0x00004121 File Offset: 0x00002321
	public unsafe static Action<List<GPGameRequest>> ActionPendingGameRequestsDetected
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayManager.NativeFieldInfoPtr_ActionPendingGameRequestsDetected, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<List<GPGameRequest>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayManager.NativeFieldInfoPtr_ActionPendingGameRequestsDetected, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A1 RID: 417
	// (get) Token: 0x0600055C RID: 1372 RVA: 0x000298A4 File Offset: 0x00027AA4
	// (set) Token: 0x0600055D RID: 1373 RVA: 0x00004133 File Offset: 0x00002333
	public unsafe static Action<List<GPGameRequest>> ActionGameRequestsAccepted
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayManager.NativeFieldInfoPtr_ActionGameRequestsAccepted, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<List<GPGameRequest>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayManager.NativeFieldInfoPtr_ActionGameRequestsAccepted, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x0600055E RID: 1374 RVA: 0x000298CC File Offset: 0x00027ACC
	// (set) Token: 0x0600055F RID: 1375 RVA: 0x00004145 File Offset: 0x00002345
	public unsafe static Action<List<string>> ActionAvailableDeviceAccountsLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayManager.NativeFieldInfoPtr_ActionAvailableDeviceAccountsLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<List<string>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayManager.NativeFieldInfoPtr_ActionAvailableDeviceAccountsLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x06000560 RID: 1376 RVA: 0x000298F4 File Offset: 0x00027AF4
	// (set) Token: 0x06000561 RID: 1377 RVA: 0x00004157 File Offset: 0x00002357
	public unsafe static Action<string> ActionOAuthTokenLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayManager.NativeFieldInfoPtr_ActionOAuthTokenLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayManager.NativeFieldInfoPtr_ActionOAuthTokenLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x06000562 RID: 1378 RVA: 0x0002991C File Offset: 0x00027B1C
	// (set) Token: 0x06000563 RID: 1379 RVA: 0x00004169 File Offset: 0x00002369
	public unsafe static Action<GooglePlayResult, string> ActionServerAuthCodeLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayManager.NativeFieldInfoPtr_ActionServerAuthCodeLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GooglePlayResult, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayManager.NativeFieldInfoPtr_ActionServerAuthCodeLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x06000564 RID: 1380 RVA: 0x00029944 File Offset: 0x00027B44
	// (set) Token: 0x06000565 RID: 1381 RVA: 0x0000417B File Offset: 0x0000237B
	public unsafe GooglePlayerTemplate _player
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayManager.NativeFieldInfoPtr__player);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GooglePlayerTemplate>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayManager.NativeFieldInfoPtr__player), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x06000566 RID: 1382 RVA: 0x00029974 File Offset: 0x00027B74
	// (set) Token: 0x06000567 RID: 1383 RVA: 0x0000419A File Offset: 0x0000239A
	public unsafe Dictionary<string, GooglePlayerTemplate> _players
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayManager.NativeFieldInfoPtr__players);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GooglePlayerTemplate>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayManager.NativeFieldInfoPtr__players), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x06000568 RID: 1384 RVA: 0x000299A4 File Offset: 0x00027BA4
	// (set) Token: 0x06000569 RID: 1385 RVA: 0x000041B9 File Offset: 0x000023B9
	public unsafe List<string> _friendsList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayManager.NativeFieldInfoPtr__friendsList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayManager.NativeFieldInfoPtr__friendsList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x0600056A RID: 1386 RVA: 0x000299D4 File Offset: 0x00027BD4
	// (set) Token: 0x0600056B RID: 1387 RVA: 0x000041D8 File Offset: 0x000023D8
	public unsafe List<string> _deviceGoogleAccountList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayManager.NativeFieldInfoPtr__deviceGoogleAccountList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayManager.NativeFieldInfoPtr__deviceGoogleAccountList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x0600056C RID: 1388 RVA: 0x00029A04 File Offset: 0x00027C04
	// (set) Token: 0x0600056D RID: 1389 RVA: 0x000041F7 File Offset: 0x000023F7
	public unsafe List<GPGameRequest> _gameRequests
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayManager.NativeFieldInfoPtr__gameRequests);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GPGameRequest>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayManager.NativeFieldInfoPtr__gameRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001AA RID: 426
	// (get) Token: 0x0600056E RID: 1390 RVA: 0x00029A34 File Offset: 0x00027C34
	// (set) Token: 0x0600056F RID: 1391 RVA: 0x00004216 File Offset: 0x00002416
	public unsafe string _loadedAuthToken
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayManager.NativeFieldInfoPtr__loadedAuthToken);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayManager.NativeFieldInfoPtr__loadedAuthToken), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170001AB RID: 427
	// (get) Token: 0x06000570 RID: 1392 RVA: 0x00029A5C File Offset: 0x00027C5C
	// (set) Token: 0x06000571 RID: 1393 RVA: 0x00004235 File Offset: 0x00002435
	public unsafe string _currentAccount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayManager.NativeFieldInfoPtr__currentAccount);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayManager.NativeFieldInfoPtr__currentAccount), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170001AC RID: 428
	// (get) Token: 0x06000572 RID: 1394 RVA: 0x00029A84 File Offset: 0x00027C84
	// (set) Token: 0x06000573 RID: 1395 RVA: 0x00004254 File Offset: 0x00002454
	public unsafe static bool _IsLeaderboardsDataLoaded
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayManager.NativeFieldInfoPtr__IsLeaderboardsDataLoaded, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayManager.NativeFieldInfoPtr__IsLeaderboardsDataLoaded, (void*)(&value));
		}
	}

	// Token: 0x040003AB RID: 939
	private static readonly IntPtr NativeFieldInfoPtr_ActionScoreSubmited;

	// Token: 0x040003AC RID: 940
	private static readonly IntPtr NativeFieldInfoPtr_ActionScoresListLoaded;

	// Token: 0x040003AD RID: 941
	private static readonly IntPtr NativeFieldInfoPtr_ActionLeaderboardsLoaded;

	// Token: 0x040003AE RID: 942
	private static readonly IntPtr NativeFieldInfoPtr_ActionAchievementUpdated;

	// Token: 0x040003AF RID: 943
	private static readonly IntPtr NativeFieldInfoPtr_ActionFriendsListLoaded;

	// Token: 0x040003B0 RID: 944
	private static readonly IntPtr NativeFieldInfoPtr_ActionAchievementsLoaded;

	// Token: 0x040003B1 RID: 945
	private static readonly IntPtr NativeFieldInfoPtr_ActionSendGiftResultReceived;

	// Token: 0x040003B2 RID: 946
	private static readonly IntPtr NativeFieldInfoPtr_ActionRequestsInboxDialogDismissed;

	// Token: 0x040003B3 RID: 947
	private static readonly IntPtr NativeFieldInfoPtr_ActionPendingGameRequestsDetected;

	// Token: 0x040003B4 RID: 948
	private static readonly IntPtr NativeFieldInfoPtr_ActionGameRequestsAccepted;

	// Token: 0x040003B5 RID: 949
	private static readonly IntPtr NativeFieldInfoPtr_ActionAvailableDeviceAccountsLoaded;

	// Token: 0x040003B6 RID: 950
	private static readonly IntPtr NativeFieldInfoPtr_ActionOAuthTokenLoaded;

	// Token: 0x040003B7 RID: 951
	private static readonly IntPtr NativeFieldInfoPtr_ActionServerAuthCodeLoaded;

	// Token: 0x040003B8 RID: 952
	private static readonly IntPtr NativeFieldInfoPtr__player;

	// Token: 0x040003B9 RID: 953
	private static readonly IntPtr NativeFieldInfoPtr__players;

	// Token: 0x040003BA RID: 954
	private static readonly IntPtr NativeFieldInfoPtr__friendsList;

	// Token: 0x040003BB RID: 955
	private static readonly IntPtr NativeFieldInfoPtr__deviceGoogleAccountList;

	// Token: 0x040003BC RID: 956
	private static readonly IntPtr NativeFieldInfoPtr__gameRequests;

	// Token: 0x040003BD RID: 957
	private static readonly IntPtr NativeFieldInfoPtr__loadedAuthToken;

	// Token: 0x040003BE RID: 958
	private static readonly IntPtr NativeFieldInfoPtr__currentAccount;

	// Token: 0x040003BF RID: 959
	private static readonly IntPtr NativeFieldInfoPtr__IsLeaderboardsDataLoaded;

	// Token: 0x040003C0 RID: 960
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionScoreSubmited_Public_Static_add_Void_Action_1_GP_LeaderboardResult_0;

	// Token: 0x040003C1 RID: 961
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionScoreSubmited_Public_Static_rem_Void_Action_1_GP_LeaderboardResult_0;

	// Token: 0x040003C2 RID: 962
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionScoresListLoaded_Public_Static_add_Void_Action_1_GP_LeaderboardResult_0;

	// Token: 0x040003C3 RID: 963
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionScoresListLoaded_Public_Static_rem_Void_Action_1_GP_LeaderboardResult_0;

	// Token: 0x040003C4 RID: 964
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionLeaderboardsLoaded_Public_Static_add_Void_Action_1_GooglePlayResult_0;

	// Token: 0x040003C5 RID: 965
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionLeaderboardsLoaded_Public_Static_rem_Void_Action_1_GooglePlayResult_0;

	// Token: 0x040003C6 RID: 966
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionAchievementUpdated_Public_Static_add_Void_Action_1_GP_AchievementResult_0;

	// Token: 0x040003C7 RID: 967
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionAchievementUpdated_Public_Static_rem_Void_Action_1_GP_AchievementResult_0;

	// Token: 0x040003C8 RID: 968
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionFriendsListLoaded_Public_Static_add_Void_Action_1_GooglePlayResult_0;

	// Token: 0x040003C9 RID: 969
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionFriendsListLoaded_Public_Static_rem_Void_Action_1_GooglePlayResult_0;

	// Token: 0x040003CA RID: 970
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionAchievementsLoaded_Public_Static_add_Void_Action_1_GooglePlayResult_0;

	// Token: 0x040003CB RID: 971
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionAchievementsLoaded_Public_Static_rem_Void_Action_1_GooglePlayResult_0;

	// Token: 0x040003CC RID: 972
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionSendGiftResultReceived_Public_Static_add_Void_Action_1_GooglePlayGiftRequestResult_0;

	// Token: 0x040003CD RID: 973
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionSendGiftResultReceived_Public_Static_rem_Void_Action_1_GooglePlayGiftRequestResult_0;

	// Token: 0x040003CE RID: 974
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionRequestsInboxDialogDismissed_Public_Static_add_Void_Action_0;

	// Token: 0x040003CF RID: 975
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionRequestsInboxDialogDismissed_Public_Static_rem_Void_Action_0;

	// Token: 0x040003D0 RID: 976
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionPendingGameRequestsDetected_Public_Static_add_Void_Action_1_List_1_GPGameRequest_0;

	// Token: 0x040003D1 RID: 977
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionPendingGameRequestsDetected_Public_Static_rem_Void_Action_1_List_1_GPGameRequest_0;

	// Token: 0x040003D2 RID: 978
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionGameRequestsAccepted_Public_Static_add_Void_Action_1_List_1_GPGameRequest_0;

	// Token: 0x040003D3 RID: 979
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionGameRequestsAccepted_Public_Static_rem_Void_Action_1_List_1_GPGameRequest_0;

	// Token: 0x040003D4 RID: 980
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionAvailableDeviceAccountsLoaded_Public_Static_add_Void_Action_1_List_1_String_0;

	// Token: 0x040003D5 RID: 981
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionAvailableDeviceAccountsLoaded_Public_Static_rem_Void_Action_1_List_1_String_0;

	// Token: 0x040003D6 RID: 982
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionOAuthTokenLoaded_Public_Static_add_Void_Action_1_String_0;

	// Token: 0x040003D7 RID: 983
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionOAuthTokenLoaded_Public_Static_rem_Void_Action_1_String_0;

	// Token: 0x040003D8 RID: 984
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionServerAuthCodeLoaded_Public_Static_add_Void_Action_2_GooglePlayResult_String_0;

	// Token: 0x040003D9 RID: 985
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionServerAuthCodeLoaded_Public_Static_rem_Void_Action_2_GooglePlayResult_String_0;

	// Token: 0x040003DA RID: 986
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040003DB RID: 987
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Void_0;

	// Token: 0x040003DC RID: 988
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayServicesStatus_Public_GP_PlayServicesStatus_0;

	// Token: 0x040003DD RID: 989
	private static readonly IntPtr NativeMethodInfoPtr_RetrieveDeviceGoogleAccounts_Public_Void_0;

	// Token: 0x040003DE RID: 990
	private static readonly IntPtr NativeMethodInfoPtr_LoadToken_Public_Void_String_String_0;

	// Token: 0x040003DF RID: 991
	private static readonly IntPtr NativeMethodInfoPtr_LoadToken_Public_Void_0;

	// Token: 0x040003E0 RID: 992
	private static readonly IntPtr NativeMethodInfoPtr_GetGamesServerAuthCode_Public_Void_String_0;

	// Token: 0x040003E1 RID: 993
	private static readonly IntPtr NativeMethodInfoPtr_InvalidateToken_Public_Void_String_0;

	// Token: 0x040003E2 RID: 994
	private static readonly IntPtr NativeMethodInfoPtr_ShowAchievementsUI_Public_Void_0;

	// Token: 0x040003E3 RID: 995
	private static readonly IntPtr NativeMethodInfoPtr_ShowLeaderBoardsUI_Public_Void_0;

	// Token: 0x040003E4 RID: 996
	private static readonly IntPtr NativeMethodInfoPtr_ShowLeaderBoard_Public_Void_String_0;

	// Token: 0x040003E5 RID: 997
	private static readonly IntPtr NativeMethodInfoPtr_ShowLeaderBoardById_Public_Void_String_0;

	// Token: 0x040003E6 RID: 998
	private static readonly IntPtr NativeMethodInfoPtr_SubmitScore_Public_Void_String_Int64_String_0;

	// Token: 0x040003E7 RID: 999
	private static readonly IntPtr NativeMethodInfoPtr_SubmitScoreById_Public_Void_String_Int64_String_0;

	// Token: 0x040003E8 RID: 1000
	private static readonly IntPtr NativeMethodInfoPtr_LoadLeaderBoards_Public_Void_0;

	// Token: 0x040003E9 RID: 1001
	private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayerScoreLocal_Public_Void_GPLeaderBoard_0;

	// Token: 0x040003EA RID: 1002
	private static readonly IntPtr NativeMethodInfoPtr_LoadPlayerCenteredScores_Public_Void_String_GPBoardTimeSpan_GPCollectionType_Int32_0;

	// Token: 0x040003EB RID: 1003
	private static readonly IntPtr NativeMethodInfoPtr_LoadTopScores_Public_Void_String_GPBoardTimeSpan_GPCollectionType_Int32_0;

	// Token: 0x040003EC RID: 1004
	private static readonly IntPtr NativeMethodInfoPtr_UnlockAchievement_Public_Void_String_0;

	// Token: 0x040003ED RID: 1005
	private static readonly IntPtr NativeMethodInfoPtr_UnlockAchievementById_Public_Void_String_0;

	// Token: 0x040003EE RID: 1006
	private static readonly IntPtr NativeMethodInfoPtr_RevealAchievement_Public_Void_String_0;

	// Token: 0x040003EF RID: 1007
	private static readonly IntPtr NativeMethodInfoPtr_RevealAchievementById_Public_Void_String_0;

	// Token: 0x040003F0 RID: 1008
	private static readonly IntPtr NativeMethodInfoPtr_IncrementAchievement_Public_Void_String_Int32_0;

	// Token: 0x040003F1 RID: 1009
	private static readonly IntPtr NativeMethodInfoPtr_IncrementAchievementById_Public_Void_String_Int32_0;

	// Token: 0x040003F2 RID: 1010
	private static readonly IntPtr NativeMethodInfoPtr_SetStepsImmediate_Public_Void_String_Int32_0;

	// Token: 0x040003F3 RID: 1011
	private static readonly IntPtr NativeMethodInfoPtr_LoadAchievements_Public_Void_0;

	// Token: 0x040003F4 RID: 1012
	private static readonly IntPtr NativeMethodInfoPtr_ResetAchievement_Public_Void_String_0;

	// Token: 0x040003F5 RID: 1013
	private static readonly IntPtr NativeMethodInfoPtr_ResetAllAchievements_Public_Void_0;

	// Token: 0x040003F6 RID: 1014
	private static readonly IntPtr NativeMethodInfoPtr_ResetLeaderBoard_Public_Void_String_0;

	// Token: 0x040003F7 RID: 1015
	private static readonly IntPtr NativeMethodInfoPtr_LoadFriends_Public_Void_0;

	// Token: 0x040003F8 RID: 1016
	private static readonly IntPtr NativeMethodInfoPtr_SendGiftRequest_Public_Void_GPGameRequestType_Int32_Texture2D_String_String_0;

	// Token: 0x040003F9 RID: 1017
	private static readonly IntPtr NativeMethodInfoPtr_get_currentAccount_Public_get_String_0;

	// Token: 0x040003FA RID: 1018
	private static readonly IntPtr NativeMethodInfoPtr_ShowRequestsAccepDialog_Public_Void_0;

	// Token: 0x040003FB RID: 1019
	private static readonly IntPtr NativeMethodInfoPtr_AcceptRequests_Public_Void_Il2CppStringArray_0;

	// Token: 0x040003FC RID: 1020
	private static readonly IntPtr NativeMethodInfoPtr_DismissRequest_Public_Void_Il2CppStringArray_0;

	// Token: 0x040003FD RID: 1021
	private static readonly IntPtr NativeMethodInfoPtr_DispatchLeaderboardUpdateEvent_Public_Void_GP_LeaderboardResult_0;

	// Token: 0x040003FE RID: 1022
	private static readonly IntPtr NativeMethodInfoPtr_GetLeaderBoard_Public_GPLeaderBoard_String_0;

	// Token: 0x040003FF RID: 1023
	private static readonly IntPtr NativeMethodInfoPtr_GetAchievement_Public_GPAchievement_String_0;

	// Token: 0x04000400 RID: 1024
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayerById_Public_GooglePlayerTemplate_String_0;

	// Token: 0x04000401 RID: 1025
	private static readonly IntPtr NativeMethodInfoPtr_GetGameRequestById_Public_GPGameRequest_String_0;

	// Token: 0x04000402 RID: 1026
	private static readonly IntPtr NativeMethodInfoPtr_get_player_Public_get_GooglePlayerTemplate_0;

	// Token: 0x04000403 RID: 1027
	private static readonly IntPtr NativeMethodInfoPtr_get_players_Public_get_Dictionary_2_String_GooglePlayerTemplate_0;

	// Token: 0x04000404 RID: 1028
	private static readonly IntPtr NativeMethodInfoPtr_get_LeaderBoards_Public_get_List_1_GPLeaderBoard_0;

	// Token: 0x04000405 RID: 1029
	private static readonly IntPtr NativeMethodInfoPtr_get_Achievements_Public_get_List_1_GPAchievement_0;

	// Token: 0x04000406 RID: 1030
	private static readonly IntPtr NativeMethodInfoPtr_get_friendsList_Public_get_List_1_String_0;

	// Token: 0x04000407 RID: 1031
	private static readonly IntPtr NativeMethodInfoPtr_get_gameRequests_Public_get_List_1_GPGameRequest_0;

	// Token: 0x04000408 RID: 1032
	private static readonly IntPtr NativeMethodInfoPtr_get_deviceGoogleAccountList_Public_get_List_1_String_0;

	// Token: 0x04000409 RID: 1033
	private static readonly IntPtr NativeMethodInfoPtr_get_loadedAuthToken_Public_get_String_0;

	// Token: 0x0400040A RID: 1034
	private static readonly IntPtr NativeMethodInfoPtr_get_IsLeaderboardsDataLoaded_Public_Static_get_Boolean_0;

	// Token: 0x0400040B RID: 1035
	private static readonly IntPtr NativeMethodInfoPtr_OnGiftSendResult_Private_Void_String_0;

	// Token: 0x0400040C RID: 1036
	private static readonly IntPtr NativeMethodInfoPtr_OnRequestsInboxDialogDismissed_Private_Void_String_0;

	// Token: 0x0400040D RID: 1037
	private static readonly IntPtr NativeMethodInfoPtr_OnAchievementsLoaded_Private_Void_String_0;

	// Token: 0x0400040E RID: 1038
	private static readonly IntPtr NativeMethodInfoPtr_OnAchievementUpdated_Private_Void_String_0;

	// Token: 0x0400040F RID: 1039
	private static readonly IntPtr NativeMethodInfoPtr_OnScoreDataRecevied_Private_Void_String_0;

	// Token: 0x04000410 RID: 1040
	private static readonly IntPtr NativeMethodInfoPtr_OnLeaderboardDataLoaded_Private_Void_String_0;

	// Token: 0x04000411 RID: 1041
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerScoreUpdated_Private_Void_String_0;

	// Token: 0x04000412 RID: 1042
	private static readonly IntPtr NativeMethodInfoPtr_OnScoreSubmitted_Private_Void_String_0;

	// Token: 0x04000413 RID: 1043
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerDataLoaded_Private_Void_String_0;

	// Token: 0x04000414 RID: 1044
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayersLoaded_Private_Void_String_0;

	// Token: 0x04000415 RID: 1045
	private static readonly IntPtr NativeMethodInfoPtr_OnGameRequestsLoaded_Private_Void_String_0;

	// Token: 0x04000416 RID: 1046
	private static readonly IntPtr NativeMethodInfoPtr_OnGameRequestsAccepted_Private_Void_String_0;

	// Token: 0x04000417 RID: 1047
	private static readonly IntPtr NativeMethodInfoPtr_OnAccountsLoaded_Private_Void_String_0;

	// Token: 0x04000418 RID: 1048
	private static readonly IntPtr NativeMethodInfoPtr_OnTokenLoaded_Private_Void_String_0;

	// Token: 0x04000419 RID: 1049
	private static readonly IntPtr NativeMethodInfoPtr_OnGamesServerAuthCodeLoaded_Private_Void_String_0;

	// Token: 0x0400041A RID: 1050
	private static readonly IntPtr NativeMethodInfoPtr_ParseParticipanData_Public_Static_GP_Participant_Il2CppStringArray_Int32_0;

	// Token: 0x0400041B RID: 1051
	private static readonly IntPtr NativeMethodInfoPtr_ParseParticipantsData_Public_Static_List_1_GP_Participant_Il2CppStringArray_Int32_0;

	// Token: 0x0400041C RID: 1052
	private static readonly IntPtr NativeMethodInfoPtr_AddPlayer_Private_Void_GooglePlayerTemplate_0;

	// Token: 0x0400041D RID: 1053
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000371 RID: 881
	[ObfuscatedName("GooglePlayManager+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x060034B6 RID: 13494 RVA: 0x000D9BB4 File Offset: 0x000D7DB4
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<GooglePlayManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GooglePlayManager>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayManager.__c>.NativeClassPtr);
			GooglePlayManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayManager.__c>.NativeClassPtr, "<>9");
			GooglePlayManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager.__c>.NativeClassPtr, 100670003);
			GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_0_Internal_Void_GP_LeaderboardResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager.__c>.NativeClassPtr, 100670004);
			GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_1_Internal_Void_GP_LeaderboardResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager.__c>.NativeClassPtr, 100670005);
			GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_2_Internal_Void_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager.__c>.NativeClassPtr, 100670006);
			GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_3_Internal_Void_GP_AchievementResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager.__c>.NativeClassPtr, 100670007);
			GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_4_Internal_Void_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager.__c>.NativeClassPtr, 100670008);
			GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_5_Internal_Void_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager.__c>.NativeClassPtr, 100670009);
			GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_6_Internal_Void_GooglePlayGiftRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager.__c>.NativeClassPtr, 100670010);
			GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager.__c>.NativeClassPtr, 100670011);
			GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_8_Internal_Void_List_1_GPGameRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager.__c>.NativeClassPtr, 100670012);
			GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_9_Internal_Void_List_1_GPGameRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager.__c>.NativeClassPtr, 100670013);
			GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_10_Internal_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager.__c>.NativeClassPtr, 100670014);
			GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_11_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager.__c>.NativeClassPtr, 100670015);
			GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_12_Internal_Void_GooglePlayResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayManager.__c>.NativeClassPtr, 100670016);
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x000D9D0C File Offset: 0x000D7F0C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayManager.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x000D9D48 File Offset: 0x000D7F48
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__125_0(GP_LeaderboardResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_0_Internal_Void_GP_LeaderboardResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x000D9D8C File Offset: 0x000D7F8C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__125_1(GP_LeaderboardResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_1_Internal_Void_GP_LeaderboardResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x000D9DD0 File Offset: 0x000D7FD0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__125_2(GooglePlayResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_2_Internal_Void_GooglePlayResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x000D9E14 File Offset: 0x000D8014
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__125_3(GP_AchievementResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_3_Internal_Void_GP_AchievementResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x000D9E58 File Offset: 0x000D8058
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__125_4(GooglePlayResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_4_Internal_Void_GooglePlayResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x000D9E9C File Offset: 0x000D809C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__125_5(GooglePlayResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_5_Internal_Void_GooglePlayResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x000D9EE0 File Offset: 0x000D80E0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__125_6(GooglePlayGiftRequestResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_6_Internal_Void_GooglePlayGiftRequestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x000D9F24 File Offset: 0x000D8124
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__125_7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x000D9F58 File Offset: 0x000D8158
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__125_8(List<GPGameRequest> <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_8_Internal_Void_List_1_GPGameRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x000D9F9C File Offset: 0x000D819C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__125_9(List<GPGameRequest> <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_9_Internal_Void_List_1_GPGameRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034C2 RID: 13506 RVA: 0x000D9FE0 File Offset: 0x000D81E0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__125_10(List<string> <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_10_Internal_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x000DA024 File Offset: 0x000D8224
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__125_11(string <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_11_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x000DA068 File Offset: 0x000D8268
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__125_12(GooglePlayResult <p0>, string <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(<p1>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayManager.__c.NativeMethodInfoPtr___cctor_b__125_12_Internal_Void_GooglePlayResult_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x000148DD File Offset: 0x00012ADD
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x060034C6 RID: 13510 RVA: 0x000DA0BC File Offset: 0x000D82BC
		// (set) Token: 0x060034C7 RID: 13511 RVA: 0x000148E6 File Offset: 0x00012AE6
		public unsafe static GooglePlayManager.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GooglePlayManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GooglePlayManager.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlayManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030B4 RID: 12468
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040030B5 RID: 12469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040030B6 RID: 12470
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__125_0_Internal_Void_GP_LeaderboardResult_0;

		// Token: 0x040030B7 RID: 12471
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__125_1_Internal_Void_GP_LeaderboardResult_0;

		// Token: 0x040030B8 RID: 12472
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__125_2_Internal_Void_GooglePlayResult_0;

		// Token: 0x040030B9 RID: 12473
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__125_3_Internal_Void_GP_AchievementResult_0;

		// Token: 0x040030BA RID: 12474
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__125_4_Internal_Void_GooglePlayResult_0;

		// Token: 0x040030BB RID: 12475
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__125_5_Internal_Void_GooglePlayResult_0;

		// Token: 0x040030BC RID: 12476
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__125_6_Internal_Void_GooglePlayGiftRequestResult_0;

		// Token: 0x040030BD RID: 12477
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__125_7_Internal_Void_0;

		// Token: 0x040030BE RID: 12478
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__125_8_Internal_Void_List_1_GPGameRequest_0;

		// Token: 0x040030BF RID: 12479
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__125_9_Internal_Void_List_1_GPGameRequest_0;

		// Token: 0x040030C0 RID: 12480
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__125_10_Internal_Void_List_1_String_0;

		// Token: 0x040030C1 RID: 12481
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__125_11_Internal_Void_String_0;

		// Token: 0x040030C2 RID: 12482
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__125_12_Internal_Void_GooglePlayResult_String_0;
	}
}

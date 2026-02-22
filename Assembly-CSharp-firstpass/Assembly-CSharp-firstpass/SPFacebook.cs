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

// Token: 0x0200008B RID: 139
public class SPFacebook : Singleton<SPFacebook>
{
	// Token: 0x06000994 RID: 2452 RVA: 0x00037E78 File Offset: 0x00036078
	// Note: this type is marked as 'beforefieldinit'.
	static SPFacebook()
	{
		Il2CppClassPointerStore<SPFacebook>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SPFacebook");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr);
		SPFacebook.NativeFieldInfoPtr__userInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "_userInfo");
		SPFacebook.NativeFieldInfoPtr__friends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "_friends");
		SPFacebook.NativeFieldInfoPtr__invitableFriends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "_invitableFriends");
		SPFacebook.NativeFieldInfoPtr__IsInited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "_IsInited");
		SPFacebook.NativeFieldInfoPtr__userScores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "_userScores");
		SPFacebook.NativeFieldInfoPtr__appScores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "_appScores");
		SPFacebook.NativeFieldInfoPtr_lastSubmitedScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "lastSubmitedScore");
		SPFacebook.NativeFieldInfoPtr__likes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "_likes");
		SPFacebook.NativeFieldInfoPtr__AppRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "_AppRequests");
		SPFacebook.NativeFieldInfoPtr_OnPostStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "OnPostStarted");
		SPFacebook.NativeFieldInfoPtr_OnLoginStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "OnLoginStarted");
		SPFacebook.NativeFieldInfoPtr_OnLogOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "OnLogOut");
		SPFacebook.NativeFieldInfoPtr_OnFriendsRequestStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "OnFriendsRequestStarted");
		SPFacebook.NativeFieldInfoPtr_OnAppInviteSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "OnAppInviteSent");
		SPFacebook.NativeFieldInfoPtr_OnInitCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "OnInitCompleteAction");
		SPFacebook.NativeFieldInfoPtr_OnPostingCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "OnPostingCompleteAction");
		SPFacebook.NativeFieldInfoPtr_OnFocusChangedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "OnFocusChangedAction");
		SPFacebook.NativeFieldInfoPtr_OnAuthCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "OnAuthCompleteAction");
		SPFacebook.NativeFieldInfoPtr_OnUserDataRequestCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "OnUserDataRequestCompleteAction");
		SPFacebook.NativeFieldInfoPtr_OnFriendsDataRequestCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "OnFriendsDataRequestCompleteAction");
		SPFacebook.NativeFieldInfoPtr_OnInvitableFriendsDataRequestCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "OnInvitableFriendsDataRequestCompleteAction");
		SPFacebook.NativeFieldInfoPtr_OnAppRequestCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "OnAppRequestCompleteAction");
		SPFacebook.NativeFieldInfoPtr_OnAppRequestsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "OnAppRequestsLoaded");
		SPFacebook.NativeFieldInfoPtr_OnAppScoresRequestCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "OnAppScoresRequestCompleteAction");
		SPFacebook.NativeFieldInfoPtr_OnPlayerScoresRequestCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "OnPlayerScoresRequestCompleteAction");
		SPFacebook.NativeFieldInfoPtr_OnSubmitScoreRequestCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "OnSubmitScoreRequestCompleteAction");
		SPFacebook.NativeFieldInfoPtr_OnDeleteScoresRequestCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "OnDeleteScoresRequestCompleteAction");
		SPFacebook.NativeFieldInfoPtr_OnLikesListLoadedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "OnLikesListLoadedAction");
		SPFacebook.NativeFieldInfoPtr__FB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "_FB");
		SPFacebook.NativeMethodInfoPtr_add_OnPostStarted_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664436);
		SPFacebook.NativeMethodInfoPtr_remove_OnPostStarted_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664437);
		SPFacebook.NativeMethodInfoPtr_add_OnLoginStarted_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664438);
		SPFacebook.NativeMethodInfoPtr_remove_OnLoginStarted_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664439);
		SPFacebook.NativeMethodInfoPtr_add_OnLogOut_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664440);
		SPFacebook.NativeMethodInfoPtr_remove_OnLogOut_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664441);
		SPFacebook.NativeMethodInfoPtr_add_OnFriendsRequestStarted_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664442);
		SPFacebook.NativeMethodInfoPtr_remove_OnFriendsRequestStarted_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664443);
		SPFacebook.NativeMethodInfoPtr_add_OnAppInviteSent_Public_Static_add_Void_Action_1_FB_AppInviteResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664444);
		SPFacebook.NativeMethodInfoPtr_remove_OnAppInviteSent_Public_Static_rem_Void_Action_1_FB_AppInviteResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664445);
		SPFacebook.NativeMethodInfoPtr_add_OnInitCompleteAction_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664446);
		SPFacebook.NativeMethodInfoPtr_remove_OnInitCompleteAction_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664447);
		SPFacebook.NativeMethodInfoPtr_add_OnPostingCompleteAction_Public_Static_add_Void_Action_1_FB_PostResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664448);
		SPFacebook.NativeMethodInfoPtr_remove_OnPostingCompleteAction_Public_Static_rem_Void_Action_1_FB_PostResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664449);
		SPFacebook.NativeMethodInfoPtr_add_OnFocusChangedAction_Public_Static_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664450);
		SPFacebook.NativeMethodInfoPtr_remove_OnFocusChangedAction_Public_Static_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664451);
		SPFacebook.NativeMethodInfoPtr_add_OnAuthCompleteAction_Public_Static_add_Void_Action_1_FB_LoginResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664452);
		SPFacebook.NativeMethodInfoPtr_remove_OnAuthCompleteAction_Public_Static_rem_Void_Action_1_FB_LoginResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664453);
		SPFacebook.NativeMethodInfoPtr_add_OnUserDataRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664454);
		SPFacebook.NativeMethodInfoPtr_remove_OnUserDataRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664455);
		SPFacebook.NativeMethodInfoPtr_add_OnFriendsDataRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664456);
		SPFacebook.NativeMethodInfoPtr_remove_OnFriendsDataRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664457);
		SPFacebook.NativeMethodInfoPtr_add_OnInvitableFriendsDataRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664458);
		SPFacebook.NativeMethodInfoPtr_remove_OnInvitableFriendsDataRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664459);
		SPFacebook.NativeMethodInfoPtr_add_OnAppRequestCompleteAction_Public_Static_add_Void_Action_1_FB_AppRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664460);
		SPFacebook.NativeMethodInfoPtr_remove_OnAppRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_AppRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664461);
		SPFacebook.NativeMethodInfoPtr_add_OnAppRequestsLoaded_Public_Static_add_Void_Action_1_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664462);
		SPFacebook.NativeMethodInfoPtr_remove_OnAppRequestsLoaded_Public_Static_rem_Void_Action_1_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664463);
		SPFacebook.NativeMethodInfoPtr_add_OnAppScoresRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664464);
		SPFacebook.NativeMethodInfoPtr_remove_OnAppScoresRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664465);
		SPFacebook.NativeMethodInfoPtr_add_OnPlayerScoresRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664466);
		SPFacebook.NativeMethodInfoPtr_remove_OnPlayerScoresRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664467);
		SPFacebook.NativeMethodInfoPtr_add_OnSubmitScoreRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664468);
		SPFacebook.NativeMethodInfoPtr_remove_OnSubmitScoreRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664469);
		SPFacebook.NativeMethodInfoPtr_add_OnDeleteScoresRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664470);
		SPFacebook.NativeMethodInfoPtr_remove_OnDeleteScoresRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664471);
		SPFacebook.NativeMethodInfoPtr_add_OnLikesListLoadedAction_Public_Static_add_Void_Action_1_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664472);
		SPFacebook.NativeMethodInfoPtr_remove_OnLikesListLoadedAction_Public_Static_rem_Void_Action_1_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664473);
		SPFacebook.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664474);
		SPFacebook.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664475);
		SPFacebook.NativeMethodInfoPtr_Login_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664476);
		SPFacebook.NativeMethodInfoPtr_Login_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664477);
		SPFacebook.NativeMethodInfoPtr_SendAppInvite_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664478);
		SPFacebook.NativeMethodInfoPtr_Logout_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664479);
		SPFacebook.NativeMethodInfoPtr_LoadUserData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664480);
		SPFacebook.NativeMethodInfoPtr_LoadInvitableFrientdsInfo_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664481);
		SPFacebook.NativeMethodInfoPtr_GetInvitableFriendById_Public_FB_UserInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664482);
		SPFacebook.NativeMethodInfoPtr_LoadFrientdsInfo_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664483);
		SPFacebook.NativeMethodInfoPtr_GetFriendById_Public_FB_UserInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664484);
		SPFacebook.NativeMethodInfoPtr_PostImage_Public_Void_String_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664485);
		SPFacebook.NativeMethodInfoPtr_PostText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664486);
		SPFacebook.NativeMethodInfoPtr_FeedShare_Public_Void_String_String_String_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664487);
		SPFacebook.NativeMethodInfoPtr_SendTrunRequest_Public_Void_String_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664488);
		SPFacebook.NativeMethodInfoPtr_SendGift_Public_Void_String_String_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664489);
		SPFacebook.NativeMethodInfoPtr_AskGift_Public_Void_String_String_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664490);
		SPFacebook.NativeMethodInfoPtr_SendInvite_Public_Void_String_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664491);
		SPFacebook.NativeMethodInfoPtr_OnAppRequestFailed_AndroidCB_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664492);
		SPFacebook.NativeMethodInfoPtr_OnAppRequestCompleted_AndroidCB_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664493);
		SPFacebook.NativeMethodInfoPtr_AppRequest_Public_Void_String_FB_RequestActionType_String_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664494);
		SPFacebook.NativeMethodInfoPtr_AppRequest_Public_Void_String_FB_RequestActionType_String_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664495);
		SPFacebook.NativeMethodInfoPtr_AppRequest_Public_Void_String_Il2CppStringArray_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664496);
		SPFacebook.NativeMethodInfoPtr_LoadPendingRequests_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664497);
		SPFacebook.NativeMethodInfoPtr_OnRequestsLoadComplete_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664498);
		SPFacebook.NativeMethodInfoPtr_LoadPlayerScores_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664499);
		SPFacebook.NativeMethodInfoPtr_LoadAppScores_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664500);
		SPFacebook.NativeMethodInfoPtr_SubmitScore_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664501);
		SPFacebook.NativeMethodInfoPtr_DeletePlayerScores_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664502);
		SPFacebook.NativeMethodInfoPtr_LoadCurrentUserLikes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664503);
		SPFacebook.NativeMethodInfoPtr_LoadLikes_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664504);
		SPFacebook.NativeMethodInfoPtr_LoadLikes_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664505);
		SPFacebook.NativeMethodInfoPtr_GetCurrentPlayerScoreByAppId_Public_FB_Score_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664506);
		SPFacebook.NativeMethodInfoPtr_GetCurrentPlayerIntScoreByAppId_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664507);
		SPFacebook.NativeMethodInfoPtr_GetScoreByUserId_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664508);
		SPFacebook.NativeMethodInfoPtr_GetScoreObjectByUserId_Public_FB_Score_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664509);
		SPFacebook.NativeMethodInfoPtr_GerUserLikesList_Public_List_1_FB_LikeInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664510);
		SPFacebook.NativeMethodInfoPtr_IsUserLikesPage_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664511);
		SPFacebook.NativeMethodInfoPtr_get_IsInited_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664512);
		SPFacebook.NativeMethodInfoPtr_get_IsLoggedIn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664513);
		SPFacebook.NativeMethodInfoPtr_get_UserId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664514);
		SPFacebook.NativeMethodInfoPtr_get_AccessToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664515);
		SPFacebook.NativeMethodInfoPtr_get_AppId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664516);
		SPFacebook.NativeMethodInfoPtr_get_userInfo_Public_get_FB_UserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664517);
		SPFacebook.NativeMethodInfoPtr_get_friends_Public_get_Dictionary_2_String_FB_UserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664518);
		SPFacebook.NativeMethodInfoPtr_get_InvitableFriends_Public_get_Dictionary_2_String_FB_UserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664519);
		SPFacebook.NativeMethodInfoPtr_get_friendsIds_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664520);
		SPFacebook.NativeMethodInfoPtr_get_InvitableFriendsIds_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664521);
		SPFacebook.NativeMethodInfoPtr_get_friendsList_Public_get_List_1_FB_UserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664522);
		SPFacebook.NativeMethodInfoPtr_get_InvitableFriendsList_Public_get_List_1_FB_UserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664523);
		SPFacebook.NativeMethodInfoPtr_get_userScores_Public_get_Dictionary_2_String_FB_Score_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664524);
		SPFacebook.NativeMethodInfoPtr_get_appScores_Public_get_Dictionary_2_String_FB_Score_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664525);
		SPFacebook.NativeMethodInfoPtr_get_applicationScoreList_Public_get_List_1_FB_Score_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664526);
		SPFacebook.NativeMethodInfoPtr_get_AppRequests_Public_get_List_1_FB_AppRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664527);
		SPFacebook.NativeMethodInfoPtr_get_FB_Public_get_SP_FB_API_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664528);
		SPFacebook.NativeMethodInfoPtr_OnUserLikesResult_Private_Void_FB_Result_FB_LikesRetrieveTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664529);
		SPFacebook.NativeMethodInfoPtr_OnScoreDeleted_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664530);
		SPFacebook.NativeMethodInfoPtr_OnScoreSubmited_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664531);
		SPFacebook.NativeMethodInfoPtr_OnAppScoresComplete_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664532);
		SPFacebook.NativeMethodInfoPtr_AddToAppScores_Private_Void_FB_Score_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664533);
		SPFacebook.NativeMethodInfoPtr_AddToUserScores_Private_Void_FB_Score_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664534);
		SPFacebook.NativeMethodInfoPtr_OnLoaPlayrScoresComplete_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664535);
		SPFacebook.NativeMethodInfoPtr_ParseInvitableFriendsData_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664536);
		SPFacebook.NativeMethodInfoPtr_ParseFriendsFromJson_Private_Void_String_Dictionary_2_String_FB_UserInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664537);
		SPFacebook.NativeMethodInfoPtr_ParseFriendsData_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664538);
		SPFacebook.NativeMethodInfoPtr_OnInitComplete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664539);
		SPFacebook.NativeMethodInfoPtr_OnHideUnity_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664540);
		SPFacebook.NativeMethodInfoPtr_LoginCallback_Public_Void_FB_LoginResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664541);
		SPFacebook.NativeMethodInfoPtr_PostCallback_Internal_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664542);
		SPFacebook.NativeMethodInfoPtr_PostCallback_Public_Void_FB_PostResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664543);
		SPFacebook.NativeMethodInfoPtr_AppRequestCallback_Public_Void_FB_AppRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664544);
		SPFacebook.NativeMethodInfoPtr_AppInviteResultCallback_Public_Void_FB_AppInviteResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664545);
		SPFacebook.NativeMethodInfoPtr_UserDataCallBack_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664546);
		SPFacebook.NativeMethodInfoPtr_InvitableFriendsDataCallBack_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664547);
		SPFacebook.NativeMethodInfoPtr_FriendsDataCallBack_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664548);
		SPFacebook.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, 100664549);
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x000389D4 File Offset: 0x00036BD4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171228, RefRangeEnd = 171229, XrefRangeStart = 171217, XrefRangeEnd = 171228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnPostStarted(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_add_OnPostStarted_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x00038A0C File Offset: 0x00036C0C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171229, XrefRangeEnd = 171240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnPostStarted(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_remove_OnPostStarted_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x00038A44 File Offset: 0x00036C44
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171251, RefRangeEnd = 171252, XrefRangeStart = 171240, XrefRangeEnd = 171251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnLoginStarted(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_add_OnLoginStarted_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x00038A7C File Offset: 0x00036C7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171252, XrefRangeEnd = 171263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnLoginStarted(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_remove_OnLoginStarted_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000999 RID: 2457 RVA: 0x00038AB4 File Offset: 0x00036CB4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171274, RefRangeEnd = 171275, XrefRangeStart = 171263, XrefRangeEnd = 171274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnLogOut(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_add_OnLogOut_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x00038AEC File Offset: 0x00036CEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171275, XrefRangeEnd = 171286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnLogOut(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_remove_OnLogOut_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x00038B24 File Offset: 0x00036D24
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171297, RefRangeEnd = 171298, XrefRangeStart = 171286, XrefRangeEnd = 171297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnFriendsRequestStarted(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_add_OnFriendsRequestStarted_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600099C RID: 2460 RVA: 0x00038B5C File Offset: 0x00036D5C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171298, XrefRangeEnd = 171309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnFriendsRequestStarted(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_remove_OnFriendsRequestStarted_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x00038B94 File Offset: 0x00036D94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171309, XrefRangeEnd = 171320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnAppInviteSent(Action<FB_AppInviteResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_add_OnAppInviteSent_Public_Static_add_Void_Action_1_FB_AppInviteResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600099E RID: 2462 RVA: 0x00038BCC File Offset: 0x00036DCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171320, XrefRangeEnd = 171331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnAppInviteSent(Action<FB_AppInviteResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_remove_OnAppInviteSent_Public_Static_rem_Void_Action_1_FB_AppInviteResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x00038C04 File Offset: 0x00036E04
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 171342, RefRangeEnd = 171345, XrefRangeStart = 171331, XrefRangeEnd = 171342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnInitCompleteAction(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_add_OnInitCompleteAction_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x00038C3C File Offset: 0x00036E3C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171356, RefRangeEnd = 171357, XrefRangeStart = 171345, XrefRangeEnd = 171356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnInitCompleteAction(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_remove_OnInitCompleteAction_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x00038C74 File Offset: 0x00036E74
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 171368, RefRangeEnd = 171370, XrefRangeStart = 171357, XrefRangeEnd = 171368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnPostingCompleteAction(Action<FB_PostResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_add_OnPostingCompleteAction_Public_Static_add_Void_Action_1_FB_PostResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x00038CAC File Offset: 0x00036EAC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171370, XrefRangeEnd = 171381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnPostingCompleteAction(Action<FB_PostResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_remove_OnPostingCompleteAction_Public_Static_rem_Void_Action_1_FB_PostResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x00038CE4 File Offset: 0x00036EE4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 171392, RefRangeEnd = 171394, XrefRangeStart = 171381, XrefRangeEnd = 171392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnFocusChangedAction(Action<bool> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_add_OnFocusChangedAction_Public_Static_add_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x00038D1C File Offset: 0x00036F1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171394, XrefRangeEnd = 171405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnFocusChangedAction(Action<bool> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_remove_OnFocusChangedAction_Public_Static_rem_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x00038D54 File Offset: 0x00036F54
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 171416, RefRangeEnd = 171420, XrefRangeStart = 171405, XrefRangeEnd = 171416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnAuthCompleteAction(Action<FB_LoginResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_add_OnAuthCompleteAction_Public_Static_add_Void_Action_1_FB_LoginResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x00038D8C File Offset: 0x00036F8C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171431, RefRangeEnd = 171432, XrefRangeStart = 171420, XrefRangeEnd = 171431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnAuthCompleteAction(Action<FB_LoginResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_remove_OnAuthCompleteAction_Public_Static_rem_Void_Action_1_FB_LoginResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x00038DC4 File Offset: 0x00036FC4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 171443, RefRangeEnd = 171446, XrefRangeStart = 171432, XrefRangeEnd = 171443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnUserDataRequestCompleteAction(Action<FB_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_add_OnUserDataRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x00038DFC File Offset: 0x00036FFC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 171457, RefRangeEnd = 171459, XrefRangeStart = 171446, XrefRangeEnd = 171457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnUserDataRequestCompleteAction(Action<FB_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_remove_OnUserDataRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x00038E34 File Offset: 0x00037034
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 171470, RefRangeEnd = 171472, XrefRangeStart = 171459, XrefRangeEnd = 171470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnFriendsDataRequestCompleteAction(Action<FB_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_add_OnFriendsDataRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x00038E6C File Offset: 0x0003706C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171483, RefRangeEnd = 171484, XrefRangeStart = 171472, XrefRangeEnd = 171483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnFriendsDataRequestCompleteAction(Action<FB_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_remove_OnFriendsDataRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x00038EA4 File Offset: 0x000370A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171484, XrefRangeEnd = 171495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnInvitableFriendsDataRequestCompleteAction(Action<FB_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_add_OnInvitableFriendsDataRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x00038EDC File Offset: 0x000370DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171495, XrefRangeEnd = 171506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnInvitableFriendsDataRequestCompleteAction(Action<FB_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_remove_OnInvitableFriendsDataRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x00038F14 File Offset: 0x00037114
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 171517, RefRangeEnd = 171521, XrefRangeStart = 171506, XrefRangeEnd = 171517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnAppRequestCompleteAction(Action<FB_AppRequestResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_add_OnAppRequestCompleteAction_Public_Static_add_Void_Action_1_FB_AppRequestResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x00038F4C File Offset: 0x0003714C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171532, RefRangeEnd = 171533, XrefRangeStart = 171521, XrefRangeEnd = 171532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnAppRequestCompleteAction(Action<FB_AppRequestResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_remove_OnAppRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_AppRequestResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x00038F84 File Offset: 0x00037184
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171544, RefRangeEnd = 171545, XrefRangeStart = 171533, XrefRangeEnd = 171544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnAppRequestsLoaded(Action<FB_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_add_OnAppRequestsLoaded_Public_Static_add_Void_Action_1_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x00038FBC File Offset: 0x000371BC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171556, RefRangeEnd = 171557, XrefRangeStart = 171545, XrefRangeEnd = 171556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnAppRequestsLoaded(Action<FB_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_remove_OnAppRequestsLoaded_Public_Static_rem_Void_Action_1_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x00038FF4 File Offset: 0x000371F4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171568, RefRangeEnd = 171569, XrefRangeStart = 171557, XrefRangeEnd = 171568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnAppScoresRequestCompleteAction(Action<FB_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_add_OnAppScoresRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x0003902C File Offset: 0x0003722C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171569, XrefRangeEnd = 171580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnAppScoresRequestCompleteAction(Action<FB_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_remove_OnAppScoresRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x00039064 File Offset: 0x00037264
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171591, RefRangeEnd = 171592, XrefRangeStart = 171580, XrefRangeEnd = 171591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnPlayerScoresRequestCompleteAction(Action<FB_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_add_OnPlayerScoresRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x0003909C File Offset: 0x0003729C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171592, XrefRangeEnd = 171603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnPlayerScoresRequestCompleteAction(Action<FB_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_remove_OnPlayerScoresRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x000390D4 File Offset: 0x000372D4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171614, RefRangeEnd = 171615, XrefRangeStart = 171603, XrefRangeEnd = 171614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnSubmitScoreRequestCompleteAction(Action<FB_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_add_OnSubmitScoreRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x0003910C File Offset: 0x0003730C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171615, XrefRangeEnd = 171626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnSubmitScoreRequestCompleteAction(Action<FB_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_remove_OnSubmitScoreRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x00039144 File Offset: 0x00037344
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171637, RefRangeEnd = 171638, XrefRangeStart = 171626, XrefRangeEnd = 171637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnDeleteScoresRequestCompleteAction(Action<FB_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_add_OnDeleteScoresRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x0003917C File Offset: 0x0003737C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171638, XrefRangeEnd = 171649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnDeleteScoresRequestCompleteAction(Action<FB_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_remove_OnDeleteScoresRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x000391B4 File Offset: 0x000373B4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171660, RefRangeEnd = 171661, XrefRangeStart = 171649, XrefRangeEnd = 171660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnLikesListLoadedAction(Action<FB_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_add_OnLikesListLoadedAction_Public_Static_add_Void_Action_1_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x000391EC File Offset: 0x000373EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171661, XrefRangeEnd = 171672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnLikesListLoadedAction(Action<FB_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_remove_OnLikesListLoadedAction_Public_Static_rem_Void_Action_1_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x00039224 File Offset: 0x00037424
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171672, XrefRangeEnd = 171677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x00039258 File Offset: 0x00037458
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 171686, RefRangeEnd = 171689, XrefRangeStart = 171677, XrefRangeEnd = 171686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x0003928C File Offset: 0x0003748C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 171711, RefRangeEnd = 171713, XrefRangeStart = 171689, XrefRangeEnd = 171711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Login()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_Login_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x000392C0 File Offset: 0x000374C0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171728, RefRangeEnd = 171729, XrefRangeStart = 171713, XrefRangeEnd = 171728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Login([Optional] Il2CppStringArray scopes)
	{
		if (scopes == null)
		{
			scopes = new Il2CppStringArray(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(scopes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_Login_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00039310 File Offset: 0x00037510
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171729, XrefRangeEnd = 171739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendAppInvite(string appLinkUrl, string previewImageUrl)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(appLinkUrl);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(previewImageUrl);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_SendAppInvite_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x00039364 File Offset: 0x00037564
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 171753, RefRangeEnd = 171757, XrefRangeStart = 171739, XrefRangeEnd = 171753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Logout()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_Logout_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x00039398 File Offset: 0x00037598
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 171791, RefRangeEnd = 171794, XrefRangeStart = 171757, XrefRangeEnd = 171791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadUserData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_LoadUserData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x000393CC File Offset: 0x000375CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171794, XrefRangeEnd = 171821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadInvitableFrientdsInfo(int limit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref limit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_LoadInvitableFrientdsInfo_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x0003940C File Offset: 0x0003760C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171821, XrefRangeEnd = 171827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_UserInfo GetInvitableFriendById(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_GetInvitableFriendById_Public_FB_UserInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FB_UserInfo>(intPtr3) : null;
		}
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x0003945C File Offset: 0x0003765C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171858, RefRangeEnd = 171859, XrefRangeStart = 171827, XrefRangeEnd = 171858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadFrientdsInfo(int limit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref limit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_LoadFrientdsInfo_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x0003949C File Offset: 0x0003769C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171859, XrefRangeEnd = 171865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_UserInfo GetFriendById(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_GetFriendById_Public_FB_UserInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FB_UserInfo>(intPtr3) : null;
		}
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x000394EC File Offset: 0x000376EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171865, XrefRangeEnd = 171902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostImage(string caption, Texture2D image)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(caption);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_PostImage_Public_Void_String_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x00039540 File Offset: 0x00037740
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171902, XrefRangeEnd = 171930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostText(string message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_PostText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x00039584 File Offset: 0x00037784
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 171933, RefRangeEnd = 171935, XrefRangeStart = 171930, XrefRangeEnd = 171933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FeedShare(string toId = "", string link = "", string linkName = "", string linkCaption = "", string linkDescription = "", string picture = "", string actionName = "", string actionLink = "", string reference = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(toId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(link);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(linkName);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(linkCaption);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(linkDescription);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(picture);
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(actionName);
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(actionLink);
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(reference);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_FeedShare_Public_Void_String_String_String_String_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009C9 RID: 2505 RVA: 0x00039660 File Offset: 0x00037860
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 171941, RefRangeEnd = 171943, XrefRangeStart = 171935, XrefRangeEnd = 171941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendTrunRequest(string title, string message, string data = "", Il2CppStringArray to = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_SendTrunRequest_Public_Void_String_String_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x000396DC File Offset: 0x000378DC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 171944, RefRangeEnd = 171946, XrefRangeStart = 171943, XrefRangeEnd = 171944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendGift(string title, string message, string objectId, string data = "", Il2CppStringArray to = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectId);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_SendGift_Public_Void_String_String_String_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009CB RID: 2507 RVA: 0x00039768 File Offset: 0x00037968
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171947, RefRangeEnd = 171948, XrefRangeStart = 171946, XrefRangeEnd = 171947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AskGift(string title, string message, string objectId, string data = "", Il2CppStringArray to = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectId);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_AskGift_Public_Void_String_String_String_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x000397F4 File Offset: 0x000379F4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 171949, RefRangeEnd = 171951, XrefRangeStart = 171948, XrefRangeEnd = 171949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendInvite(string title, string message, string data = "", Il2CppStringArray to = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_SendInvite_Public_Void_String_String_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x00039870 File Offset: 0x00037A70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171951, XrefRangeEnd = 171965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAppRequestFailed_AndroidCB(string error)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_OnAppRequestFailed_AndroidCB_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x000398B4 File Offset: 0x00037AB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171965, XrefRangeEnd = 172008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAppRequestCompleted_AndroidCB(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_OnAppRequestCompleted_AndroidCB_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x000398F8 File Offset: 0x00037AF8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 172020, RefRangeEnd = 172022, XrefRangeStart = 172008, XrefRangeEnd = 172020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AppRequest(string message, FB_RequestActionType actionType, string objectId, Il2CppStringArray to, string data = "", string title = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionType;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectId);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_AppRequest_Public_Void_String_FB_RequestActionType_String_Il2CppStringArray_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x00039994 File Offset: 0x00037B94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172022, XrefRangeEnd = 172034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AppRequest(string message, FB_RequestActionType actionType, string objectId, List<global::Il2CppSystem.Object> filters = null, Il2CppStringArray excludeIds = null, Nullable<int> maxRecipients = null, string data = "", string title = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionType;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectId);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filters);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(excludeIds);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(maxRecipients));
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_AppRequest_Public_Void_String_FB_RequestActionType_String_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x00039A5C File Offset: 0x00037C5C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 172046, RefRangeEnd = 172049, XrefRangeStart = 172034, XrefRangeEnd = 172046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AppRequest(string message, Il2CppStringArray to = null, List<global::Il2CppSystem.Object> filters = null, Il2CppStringArray excludeIds = null, Nullable<int> maxRecipients = null, string data = "", string title = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filters);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(excludeIds);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(maxRecipients));
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_AppRequest_Public_Void_String_Il2CppStringArray_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x00039B14 File Offset: 0x00037D14
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172069, RefRangeEnd = 172070, XrefRangeStart = 172049, XrefRangeEnd = 172069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadPendingRequests()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_LoadPendingRequests_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x00039B48 File Offset: 0x00037D48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172070, XrefRangeEnd = 172287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRequestsLoadComplete(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_OnRequestsLoadComplete_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009D4 RID: 2516 RVA: 0x00039B8C File Offset: 0x00037D8C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172307, RefRangeEnd = 172308, XrefRangeStart = 172287, XrefRangeEnd = 172307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadPlayerScores()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_LoadPlayerScores_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x00039BC0 File Offset: 0x00037DC0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172328, RefRangeEnd = 172329, XrefRangeStart = 172308, XrefRangeEnd = 172328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAppScores()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_LoadAppScores_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x00039BF4 File Offset: 0x00037DF4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172350, RefRangeEnd = 172351, XrefRangeStart = 172329, XrefRangeEnd = 172350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitScore(int score)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref score;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_SubmitScore_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x00039C34 File Offset: 0x00037E34
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172371, RefRangeEnd = 172372, XrefRangeStart = 172351, XrefRangeEnd = 172371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeletePlayerScores()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_DeletePlayerScores_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x00039C68 File Offset: 0x00037E68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172372, XrefRangeEnd = 172392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadCurrentUserLikes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_LoadCurrentUserLikes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x00039C9C File Offset: 0x00037E9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172392, XrefRangeEnd = 172404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadLikes(string userId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_LoadLikes_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x00039CE0 File Offset: 0x00037EE0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172416, RefRangeEnd = 172417, XrefRangeStart = 172404, XrefRangeEnd = 172416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadLikes(string userId, string pageId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pageId);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_LoadLikes_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x00039D34 File Offset: 0x00037F34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172417, XrefRangeEnd = 172429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_Score GetCurrentPlayerScoreByAppId(string appId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(appId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_GetCurrentPlayerScoreByAppId_Public_FB_Score_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FB_Score>(intPtr3) : null;
		}
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x00039D84 File Offset: 0x00037F84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172429, XrefRangeEnd = 172441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetCurrentPlayerIntScoreByAppId(string appId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(appId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_GetCurrentPlayerIntScoreByAppId_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x00039DD4 File Offset: 0x00037FD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172441, XrefRangeEnd = 172445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetScoreByUserId(string userId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_GetScoreByUserId_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x00039E24 File Offset: 0x00038024
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172445, XrefRangeEnd = 172449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_Score GetScoreObjectByUserId(string userId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_GetScoreObjectByUserId_Public_FB_Score_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FB_Score>(intPtr3) : null;
		}
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x00039E74 File Offset: 0x00038074
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172449, XrefRangeEnd = 172479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<FB_LikeInfo> GerUserLikesList(string userId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_GerUserLikesList_Public_List_1_FB_LikeInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FB_LikeInfo>>(intPtr3) : null;
		}
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x00039EC4 File Offset: 0x000380C4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 172488, RefRangeEnd = 172490, XrefRangeStart = 172479, XrefRangeEnd = 172488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsUserLikesPage(string userId, string pageId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pageId);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_IsUserLikesPage_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x1700032B RID: 811
	// (get) Token: 0x060009E1 RID: 2529 RVA: 0x00039F24 File Offset: 0x00038124
	public unsafe bool IsInited
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_get_IsInited_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700032C RID: 812
	// (get) Token: 0x060009E2 RID: 2530 RVA: 0x00039F60 File Offset: 0x00038160
	public unsafe bool IsLoggedIn
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 172500, RefRangeEnd = 172513, XrefRangeStart = 172490, XrefRangeEnd = 172500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_get_IsLoggedIn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700032D RID: 813
	// (get) Token: 0x060009E3 RID: 2531 RVA: 0x00039F9C File Offset: 0x0003819C
	public unsafe string UserId
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 172522, RefRangeEnd = 172536, XrefRangeStart = 172513, XrefRangeEnd = 172522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_get_UserId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700032E RID: 814
	// (get) Token: 0x060009E4 RID: 2532 RVA: 0x00039FD4 File Offset: 0x000381D4
	public unsafe string AccessToken
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172536, XrefRangeEnd = 172545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_get_AccessToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700032F RID: 815
	// (get) Token: 0x060009E5 RID: 2533 RVA: 0x0003A00C File Offset: 0x0003820C
	public unsafe string AppId
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 172554, RefRangeEnd = 172564, XrefRangeStart = 172545, XrefRangeEnd = 172554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_get_AppId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000330 RID: 816
	// (get) Token: 0x060009E6 RID: 2534 RVA: 0x0003A044 File Offset: 0x00038244
	public unsafe FB_UserInfo userInfo
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_get_userInfo_Public_get_FB_UserInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FB_UserInfo>(intPtr3) : null;
		}
	}

	// Token: 0x17000331 RID: 817
	// (get) Token: 0x060009E7 RID: 2535 RVA: 0x0003A084 File Offset: 0x00038284
	public unsafe Dictionary<string, FB_UserInfo> friends
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_get_friends_Public_get_Dictionary_2_String_FB_UserInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, FB_UserInfo>>(intPtr3) : null;
		}
	}

	// Token: 0x17000332 RID: 818
	// (get) Token: 0x060009E8 RID: 2536 RVA: 0x0003A0C4 File Offset: 0x000382C4
	public unsafe Dictionary<string, FB_UserInfo> InvitableFriends
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_get_InvitableFriends_Public_get_Dictionary_2_String_FB_UserInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, FB_UserInfo>>(intPtr3) : null;
		}
	}

	// Token: 0x17000333 RID: 819
	// (get) Token: 0x060009E9 RID: 2537 RVA: 0x0003A104 File Offset: 0x00038304
	public unsafe List<string> friendsIds
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172564, XrefRangeEnd = 172589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_get_friendsIds_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}
	}

	// Token: 0x17000334 RID: 820
	// (get) Token: 0x060009EA RID: 2538 RVA: 0x0003A144 File Offset: 0x00038344
	public unsafe List<string> InvitableFriendsIds
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172589, XrefRangeEnd = 172614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_get_InvitableFriendsIds_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}
	}

	// Token: 0x17000335 RID: 821
	// (get) Token: 0x060009EB RID: 2539 RVA: 0x0003A184 File Offset: 0x00038384
	public unsafe List<FB_UserInfo> friendsList
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172614, XrefRangeEnd = 172639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_get_friendsList_Public_get_List_1_FB_UserInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FB_UserInfo>>(intPtr3) : null;
		}
	}

	// Token: 0x17000336 RID: 822
	// (get) Token: 0x060009EC RID: 2540 RVA: 0x0003A1C4 File Offset: 0x000383C4
	public unsafe List<FB_UserInfo> InvitableFriendsList
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172639, XrefRangeEnd = 172664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_get_InvitableFriendsList_Public_get_List_1_FB_UserInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FB_UserInfo>>(intPtr3) : null;
		}
	}

	// Token: 0x17000337 RID: 823
	// (get) Token: 0x060009ED RID: 2541 RVA: 0x0003A204 File Offset: 0x00038404
	public unsafe Dictionary<string, FB_Score> userScores
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_get_userScores_Public_get_Dictionary_2_String_FB_Score_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, FB_Score>>(intPtr3) : null;
		}
	}

	// Token: 0x17000338 RID: 824
	// (get) Token: 0x060009EE RID: 2542 RVA: 0x0003A244 File Offset: 0x00038444
	public unsafe Dictionary<string, FB_Score> appScores
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_get_appScores_Public_get_Dictionary_2_String_FB_Score_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, FB_Score>>(intPtr3) : null;
		}
	}

	// Token: 0x17000339 RID: 825
	// (get) Token: 0x060009EF RID: 2543 RVA: 0x0003A284 File Offset: 0x00038484
	public unsafe List<FB_Score> applicationScoreList
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172664, XrefRangeEnd = 172688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_get_applicationScoreList_Public_get_List_1_FB_Score_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FB_Score>>(intPtr3) : null;
		}
	}

	// Token: 0x1700033A RID: 826
	// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0003A2C4 File Offset: 0x000384C4
	public unsafe List<FB_AppRequest> AppRequests
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_get_AppRequests_Public_get_List_1_FB_AppRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FB_AppRequest>>(intPtr3) : null;
		}
	}

	// Token: 0x1700033B RID: 827
	// (get) Token: 0x060009F1 RID: 2545 RVA: 0x0003A304 File Offset: 0x00038504
	public unsafe SP_FB_API FB
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 172693, RefRangeEnd = 172704, XrefRangeStart = 172688, XrefRangeEnd = 172693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_get_FB_Public_get_SP_FB_API_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SP_FB_API>(intPtr3) : null;
		}
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x0003A344 File Offset: 0x00038544
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172704, XrefRangeEnd = 172793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUserLikesResult(FB_Result result, FB_LikesRetrieveTask task)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(task);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_OnUserLikesResult_Private_Void_FB_Result_FB_LikesRetrieveTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x0003A398 File Offset: 0x00038598
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172793, XrefRangeEnd = 172833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnScoreDeleted(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_OnScoreDeleted_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x0003A3DC File Offset: 0x000385DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172833, XrefRangeEnd = 172873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnScoreSubmited(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_OnScoreSubmited_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x0003A420 File Offset: 0x00038620
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 172873, XrefRangeEnd = 172979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAppScoresComplete(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_OnAppScoresComplete_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x0003A464 File Offset: 0x00038664
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 172996, RefRangeEnd = 172997, XrefRangeStart = 172979, XrefRangeEnd = 172996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToAppScores(FB_Score score)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(score);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_AddToAppScores_Private_Void_FB_Score_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x0003A4A8 File Offset: 0x000386A8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 173014, RefRangeEnd = 173015, XrefRangeStart = 172997, XrefRangeEnd = 173014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddToUserScores(FB_Score score)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(score);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_AddToUserScores_Private_Void_FB_Score_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x0003A4EC File Offset: 0x000386EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173015, XrefRangeEnd = 173083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLoaPlayrScoresComplete(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_OnLoaPlayrScoresComplete_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x0003A530 File Offset: 0x00038730
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173083, XrefRangeEnd = 173084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ParseInvitableFriendsData(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_ParseInvitableFriendsData_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x0003A574 File Offset: 0x00038774
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 173143, RefRangeEnd = 173147, XrefRangeStart = 173084, XrefRangeEnd = 173143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ParseFriendsFromJson(string data, Dictionary<string, FB_UserInfo> friends, bool invitable = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(friends);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invitable;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_ParseFriendsFromJson_Private_Void_String_Dictionary_2_String_FB_UserInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x0003A5D8 File Offset: 0x000387D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173147, XrefRangeEnd = 173148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ParseFriendsData(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_ParseFriendsData_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x0003A61C File Offset: 0x0003881C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173148, XrefRangeEnd = 173162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInitComplete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_OnInitComplete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x0003A650 File Offset: 0x00038850
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173162, XrefRangeEnd = 173170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnHideUnity(bool isGameShown)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isGameShown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_OnHideUnity_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x0003A690 File Offset: 0x00038890
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173170, XrefRangeEnd = 173178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoginCallback(FB_LoginResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_LoginCallback_Public_Void_FB_LoginResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x0003A6D4 File Offset: 0x000388D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173178, XrefRangeEnd = 173190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostCallback_Internal(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_PostCallback_Internal_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x0003A718 File Offset: 0x00038918
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 173198, RefRangeEnd = 173199, XrefRangeStart = 173190, XrefRangeEnd = 173198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostCallback(FB_PostResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_PostCallback_Public_Void_FB_PostResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x0003A75C File Offset: 0x0003895C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173199, XrefRangeEnd = 173207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AppRequestCallback(FB_AppRequestResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_AppRequestCallback_Public_Void_FB_AppRequestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x0003A7A0 File Offset: 0x000389A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173207, XrefRangeEnd = 173215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AppInviteResultCallback(FB_AppInviteResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_AppInviteResultCallback_Public_Void_FB_AppInviteResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x0003A7E4 File Offset: 0x000389E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173215, XrefRangeEnd = 173403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UserDataCallBack(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_UserDataCallBack_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x0003A828 File Offset: 0x00038A28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173403, XrefRangeEnd = 173418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InvitableFriendsDataCallBack(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_InvitableFriendsDataCallBack_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x0003A86C File Offset: 0x00038A6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173418, XrefRangeEnd = 173433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FriendsDataCallBack(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr_FriendsDataCallBack_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x0003A8B0 File Offset: 0x00038AB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173433, XrefRangeEnd = 173471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SPFacebook()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x00005DAF File Offset: 0x00003FAF
	public void Login(params string[] scopes)
	{
		this.Login(new Il2CppStringArray(scopes));
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x00005DBD File Offset: 0x00003FBD
	public SPFacebook(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700030E RID: 782
	// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0003A8EC File Offset: 0x00038AEC
	// (set) Token: 0x06000A0A RID: 2570 RVA: 0x00005DC6 File Offset: 0x00003FC6
	public unsafe FB_UserInfo _userInfo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr__userInfo);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<FB_UserInfo>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr__userInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700030F RID: 783
	// (get) Token: 0x06000A0B RID: 2571 RVA: 0x0003A91C File Offset: 0x00038B1C
	// (set) Token: 0x06000A0C RID: 2572 RVA: 0x00005DE5 File Offset: 0x00003FE5
	public unsafe Dictionary<string, FB_UserInfo> _friends
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr__friends);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, FB_UserInfo>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr__friends), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000310 RID: 784
	// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0003A94C File Offset: 0x00038B4C
	// (set) Token: 0x06000A0E RID: 2574 RVA: 0x00005E04 File Offset: 0x00004004
	public unsafe Dictionary<string, FB_UserInfo> _invitableFriends
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr__invitableFriends);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, FB_UserInfo>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr__invitableFriends), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000311 RID: 785
	// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0003A97C File Offset: 0x00038B7C
	// (set) Token: 0x06000A10 RID: 2576 RVA: 0x00005E23 File Offset: 0x00004023
	public unsafe bool _IsInited
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr__IsInited);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr__IsInited)) = value;
		}
	}

	// Token: 0x17000312 RID: 786
	// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0003A9A4 File Offset: 0x00038BA4
	// (set) Token: 0x06000A12 RID: 2578 RVA: 0x00005E3E File Offset: 0x0000403E
	public unsafe Dictionary<string, FB_Score> _userScores
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr__userScores);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, FB_Score>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr__userScores), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000313 RID: 787
	// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0003A9D4 File Offset: 0x00038BD4
	// (set) Token: 0x06000A14 RID: 2580 RVA: 0x00005E5D File Offset: 0x0000405D
	public unsafe Dictionary<string, FB_Score> _appScores
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr__appScores);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, FB_Score>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr__appScores), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000314 RID: 788
	// (get) Token: 0x06000A15 RID: 2581 RVA: 0x0003AA04 File Offset: 0x00038C04
	// (set) Token: 0x06000A16 RID: 2582 RVA: 0x00005E7C File Offset: 0x0000407C
	public unsafe int lastSubmitedScore
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr_lastSubmitedScore);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr_lastSubmitedScore)) = value;
		}
	}

	// Token: 0x17000315 RID: 789
	// (get) Token: 0x06000A17 RID: 2583 RVA: 0x0003AA2C File Offset: 0x00038C2C
	// (set) Token: 0x06000A18 RID: 2584 RVA: 0x00005E97 File Offset: 0x00004097
	public unsafe Dictionary<string, Dictionary<string, FB_LikeInfo>> _likes
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr__likes);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Dictionary<string, FB_LikeInfo>>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr__likes), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000316 RID: 790
	// (get) Token: 0x06000A19 RID: 2585 RVA: 0x0003AA5C File Offset: 0x00038C5C
	// (set) Token: 0x06000A1A RID: 2586 RVA: 0x00005EB6 File Offset: 0x000040B6
	public unsafe List<FB_AppRequest> _AppRequests
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr__AppRequests);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FB_AppRequest>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr__AppRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000317 RID: 791
	// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0003AA8C File Offset: 0x00038C8C
	// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00005ED5 File Offset: 0x000040D5
	public unsafe static Action OnPostStarted
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SPFacebook.NativeFieldInfoPtr_OnPostStarted, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SPFacebook.NativeFieldInfoPtr_OnPostStarted, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000318 RID: 792
	// (get) Token: 0x06000A1D RID: 2589 RVA: 0x0003AAB4 File Offset: 0x00038CB4
	// (set) Token: 0x06000A1E RID: 2590 RVA: 0x00005EE7 File Offset: 0x000040E7
	public unsafe static Action OnLoginStarted
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SPFacebook.NativeFieldInfoPtr_OnLoginStarted, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SPFacebook.NativeFieldInfoPtr_OnLoginStarted, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000319 RID: 793
	// (get) Token: 0x06000A1F RID: 2591 RVA: 0x0003AADC File Offset: 0x00038CDC
	// (set) Token: 0x06000A20 RID: 2592 RVA: 0x00005EF9 File Offset: 0x000040F9
	public unsafe static Action OnLogOut
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SPFacebook.NativeFieldInfoPtr_OnLogOut, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SPFacebook.NativeFieldInfoPtr_OnLogOut, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700031A RID: 794
	// (get) Token: 0x06000A21 RID: 2593 RVA: 0x0003AB04 File Offset: 0x00038D04
	// (set) Token: 0x06000A22 RID: 2594 RVA: 0x00005F0B File Offset: 0x0000410B
	public unsafe static Action OnFriendsRequestStarted
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SPFacebook.NativeFieldInfoPtr_OnFriendsRequestStarted, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SPFacebook.NativeFieldInfoPtr_OnFriendsRequestStarted, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700031B RID: 795
	// (get) Token: 0x06000A23 RID: 2595 RVA: 0x0003AB2C File Offset: 0x00038D2C
	// (set) Token: 0x06000A24 RID: 2596 RVA: 0x00005F1D File Offset: 0x0000411D
	public unsafe static Action<FB_AppInviteResult> OnAppInviteSent
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SPFacebook.NativeFieldInfoPtr_OnAppInviteSent, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_AppInviteResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SPFacebook.NativeFieldInfoPtr_OnAppInviteSent, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700031C RID: 796
	// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0003AB54 File Offset: 0x00038D54
	// (set) Token: 0x06000A26 RID: 2598 RVA: 0x00005F2F File Offset: 0x0000412F
	public unsafe static Action OnInitCompleteAction
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SPFacebook.NativeFieldInfoPtr_OnInitCompleteAction, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SPFacebook.NativeFieldInfoPtr_OnInitCompleteAction, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700031D RID: 797
	// (get) Token: 0x06000A27 RID: 2599 RVA: 0x0003AB7C File Offset: 0x00038D7C
	// (set) Token: 0x06000A28 RID: 2600 RVA: 0x00005F41 File Offset: 0x00004141
	public unsafe static Action<FB_PostResult> OnPostingCompleteAction
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SPFacebook.NativeFieldInfoPtr_OnPostingCompleteAction, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_PostResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SPFacebook.NativeFieldInfoPtr_OnPostingCompleteAction, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700031E RID: 798
	// (get) Token: 0x06000A29 RID: 2601 RVA: 0x0003ABA4 File Offset: 0x00038DA4
	// (set) Token: 0x06000A2A RID: 2602 RVA: 0x00005F53 File Offset: 0x00004153
	public unsafe static Action<bool> OnFocusChangedAction
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SPFacebook.NativeFieldInfoPtr_OnFocusChangedAction, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SPFacebook.NativeFieldInfoPtr_OnFocusChangedAction, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700031F RID: 799
	// (get) Token: 0x06000A2B RID: 2603 RVA: 0x0003ABCC File Offset: 0x00038DCC
	// (set) Token: 0x06000A2C RID: 2604 RVA: 0x00005F65 File Offset: 0x00004165
	public unsafe static Action<FB_LoginResult> OnAuthCompleteAction
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SPFacebook.NativeFieldInfoPtr_OnAuthCompleteAction, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_LoginResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SPFacebook.NativeFieldInfoPtr_OnAuthCompleteAction, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000320 RID: 800
	// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0003ABF4 File Offset: 0x00038DF4
	// (set) Token: 0x06000A2E RID: 2606 RVA: 0x00005F77 File Offset: 0x00004177
	public unsafe static Action<FB_Result> OnUserDataRequestCompleteAction
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SPFacebook.NativeFieldInfoPtr_OnUserDataRequestCompleteAction, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_Result>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SPFacebook.NativeFieldInfoPtr_OnUserDataRequestCompleteAction, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000321 RID: 801
	// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0003AC1C File Offset: 0x00038E1C
	// (set) Token: 0x06000A30 RID: 2608 RVA: 0x00005F89 File Offset: 0x00004189
	public unsafe static Action<FB_Result> OnFriendsDataRequestCompleteAction
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SPFacebook.NativeFieldInfoPtr_OnFriendsDataRequestCompleteAction, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_Result>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SPFacebook.NativeFieldInfoPtr_OnFriendsDataRequestCompleteAction, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000322 RID: 802
	// (get) Token: 0x06000A31 RID: 2609 RVA: 0x0003AC44 File Offset: 0x00038E44
	// (set) Token: 0x06000A32 RID: 2610 RVA: 0x00005F9B File Offset: 0x0000419B
	public unsafe static Action<FB_Result> OnInvitableFriendsDataRequestCompleteAction
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SPFacebook.NativeFieldInfoPtr_OnInvitableFriendsDataRequestCompleteAction, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_Result>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SPFacebook.NativeFieldInfoPtr_OnInvitableFriendsDataRequestCompleteAction, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000323 RID: 803
	// (get) Token: 0x06000A33 RID: 2611 RVA: 0x0003AC6C File Offset: 0x00038E6C
	// (set) Token: 0x06000A34 RID: 2612 RVA: 0x00005FAD File Offset: 0x000041AD
	public unsafe static Action<FB_AppRequestResult> OnAppRequestCompleteAction
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SPFacebook.NativeFieldInfoPtr_OnAppRequestCompleteAction, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_AppRequestResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SPFacebook.NativeFieldInfoPtr_OnAppRequestCompleteAction, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000324 RID: 804
	// (get) Token: 0x06000A35 RID: 2613 RVA: 0x0003AC94 File Offset: 0x00038E94
	// (set) Token: 0x06000A36 RID: 2614 RVA: 0x00005FBF File Offset: 0x000041BF
	public unsafe static Action<FB_Result> OnAppRequestsLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SPFacebook.NativeFieldInfoPtr_OnAppRequestsLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_Result>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SPFacebook.NativeFieldInfoPtr_OnAppRequestsLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000325 RID: 805
	// (get) Token: 0x06000A37 RID: 2615 RVA: 0x0003ACBC File Offset: 0x00038EBC
	// (set) Token: 0x06000A38 RID: 2616 RVA: 0x00005FD1 File Offset: 0x000041D1
	public unsafe static Action<FB_Result> OnAppScoresRequestCompleteAction
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SPFacebook.NativeFieldInfoPtr_OnAppScoresRequestCompleteAction, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_Result>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SPFacebook.NativeFieldInfoPtr_OnAppScoresRequestCompleteAction, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000326 RID: 806
	// (get) Token: 0x06000A39 RID: 2617 RVA: 0x0003ACE4 File Offset: 0x00038EE4
	// (set) Token: 0x06000A3A RID: 2618 RVA: 0x00005FE3 File Offset: 0x000041E3
	public unsafe static Action<FB_Result> OnPlayerScoresRequestCompleteAction
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SPFacebook.NativeFieldInfoPtr_OnPlayerScoresRequestCompleteAction, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_Result>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SPFacebook.NativeFieldInfoPtr_OnPlayerScoresRequestCompleteAction, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000327 RID: 807
	// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0003AD0C File Offset: 0x00038F0C
	// (set) Token: 0x06000A3C RID: 2620 RVA: 0x00005FF5 File Offset: 0x000041F5
	public unsafe static Action<FB_Result> OnSubmitScoreRequestCompleteAction
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SPFacebook.NativeFieldInfoPtr_OnSubmitScoreRequestCompleteAction, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_Result>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SPFacebook.NativeFieldInfoPtr_OnSubmitScoreRequestCompleteAction, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000328 RID: 808
	// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0003AD34 File Offset: 0x00038F34
	// (set) Token: 0x06000A3E RID: 2622 RVA: 0x00006007 File Offset: 0x00004207
	public unsafe static Action<FB_Result> OnDeleteScoresRequestCompleteAction
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SPFacebook.NativeFieldInfoPtr_OnDeleteScoresRequestCompleteAction, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_Result>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SPFacebook.NativeFieldInfoPtr_OnDeleteScoresRequestCompleteAction, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000329 RID: 809
	// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0003AD5C File Offset: 0x00038F5C
	// (set) Token: 0x06000A40 RID: 2624 RVA: 0x00006019 File Offset: 0x00004219
	public unsafe static Action<FB_Result> OnLikesListLoadedAction
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SPFacebook.NativeFieldInfoPtr_OnLikesListLoadedAction, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_Result>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SPFacebook.NativeFieldInfoPtr_OnLikesListLoadedAction, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700032A RID: 810
	// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0003AD84 File Offset: 0x00038F84
	// (set) Token: 0x06000A42 RID: 2626 RVA: 0x0000602B File Offset: 0x0000422B
	public unsafe SP_FB_API _FB
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr__FB);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SP_FB_API>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SPFacebook.NativeFieldInfoPtr__FB), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040007B3 RID: 1971
	private static readonly IntPtr NativeFieldInfoPtr__userInfo;

	// Token: 0x040007B4 RID: 1972
	private static readonly IntPtr NativeFieldInfoPtr__friends;

	// Token: 0x040007B5 RID: 1973
	private static readonly IntPtr NativeFieldInfoPtr__invitableFriends;

	// Token: 0x040007B6 RID: 1974
	private static readonly IntPtr NativeFieldInfoPtr__IsInited;

	// Token: 0x040007B7 RID: 1975
	private static readonly IntPtr NativeFieldInfoPtr__userScores;

	// Token: 0x040007B8 RID: 1976
	private static readonly IntPtr NativeFieldInfoPtr__appScores;

	// Token: 0x040007B9 RID: 1977
	private static readonly IntPtr NativeFieldInfoPtr_lastSubmitedScore;

	// Token: 0x040007BA RID: 1978
	private static readonly IntPtr NativeFieldInfoPtr__likes;

	// Token: 0x040007BB RID: 1979
	private static readonly IntPtr NativeFieldInfoPtr__AppRequests;

	// Token: 0x040007BC RID: 1980
	private static readonly IntPtr NativeFieldInfoPtr_OnPostStarted;

	// Token: 0x040007BD RID: 1981
	private static readonly IntPtr NativeFieldInfoPtr_OnLoginStarted;

	// Token: 0x040007BE RID: 1982
	private static readonly IntPtr NativeFieldInfoPtr_OnLogOut;

	// Token: 0x040007BF RID: 1983
	private static readonly IntPtr NativeFieldInfoPtr_OnFriendsRequestStarted;

	// Token: 0x040007C0 RID: 1984
	private static readonly IntPtr NativeFieldInfoPtr_OnAppInviteSent;

	// Token: 0x040007C1 RID: 1985
	private static readonly IntPtr NativeFieldInfoPtr_OnInitCompleteAction;

	// Token: 0x040007C2 RID: 1986
	private static readonly IntPtr NativeFieldInfoPtr_OnPostingCompleteAction;

	// Token: 0x040007C3 RID: 1987
	private static readonly IntPtr NativeFieldInfoPtr_OnFocusChangedAction;

	// Token: 0x040007C4 RID: 1988
	private static readonly IntPtr NativeFieldInfoPtr_OnAuthCompleteAction;

	// Token: 0x040007C5 RID: 1989
	private static readonly IntPtr NativeFieldInfoPtr_OnUserDataRequestCompleteAction;

	// Token: 0x040007C6 RID: 1990
	private static readonly IntPtr NativeFieldInfoPtr_OnFriendsDataRequestCompleteAction;

	// Token: 0x040007C7 RID: 1991
	private static readonly IntPtr NativeFieldInfoPtr_OnInvitableFriendsDataRequestCompleteAction;

	// Token: 0x040007C8 RID: 1992
	private static readonly IntPtr NativeFieldInfoPtr_OnAppRequestCompleteAction;

	// Token: 0x040007C9 RID: 1993
	private static readonly IntPtr NativeFieldInfoPtr_OnAppRequestsLoaded;

	// Token: 0x040007CA RID: 1994
	private static readonly IntPtr NativeFieldInfoPtr_OnAppScoresRequestCompleteAction;

	// Token: 0x040007CB RID: 1995
	private static readonly IntPtr NativeFieldInfoPtr_OnPlayerScoresRequestCompleteAction;

	// Token: 0x040007CC RID: 1996
	private static readonly IntPtr NativeFieldInfoPtr_OnSubmitScoreRequestCompleteAction;

	// Token: 0x040007CD RID: 1997
	private static readonly IntPtr NativeFieldInfoPtr_OnDeleteScoresRequestCompleteAction;

	// Token: 0x040007CE RID: 1998
	private static readonly IntPtr NativeFieldInfoPtr_OnLikesListLoadedAction;

	// Token: 0x040007CF RID: 1999
	private static readonly IntPtr NativeFieldInfoPtr__FB;

	// Token: 0x040007D0 RID: 2000
	private static readonly IntPtr NativeMethodInfoPtr_add_OnPostStarted_Public_Static_add_Void_Action_0;

	// Token: 0x040007D1 RID: 2001
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnPostStarted_Public_Static_rem_Void_Action_0;

	// Token: 0x040007D2 RID: 2002
	private static readonly IntPtr NativeMethodInfoPtr_add_OnLoginStarted_Public_Static_add_Void_Action_0;

	// Token: 0x040007D3 RID: 2003
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnLoginStarted_Public_Static_rem_Void_Action_0;

	// Token: 0x040007D4 RID: 2004
	private static readonly IntPtr NativeMethodInfoPtr_add_OnLogOut_Public_Static_add_Void_Action_0;

	// Token: 0x040007D5 RID: 2005
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnLogOut_Public_Static_rem_Void_Action_0;

	// Token: 0x040007D6 RID: 2006
	private static readonly IntPtr NativeMethodInfoPtr_add_OnFriendsRequestStarted_Public_Static_add_Void_Action_0;

	// Token: 0x040007D7 RID: 2007
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnFriendsRequestStarted_Public_Static_rem_Void_Action_0;

	// Token: 0x040007D8 RID: 2008
	private static readonly IntPtr NativeMethodInfoPtr_add_OnAppInviteSent_Public_Static_add_Void_Action_1_FB_AppInviteResult_0;

	// Token: 0x040007D9 RID: 2009
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnAppInviteSent_Public_Static_rem_Void_Action_1_FB_AppInviteResult_0;

	// Token: 0x040007DA RID: 2010
	private static readonly IntPtr NativeMethodInfoPtr_add_OnInitCompleteAction_Public_Static_add_Void_Action_0;

	// Token: 0x040007DB RID: 2011
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnInitCompleteAction_Public_Static_rem_Void_Action_0;

	// Token: 0x040007DC RID: 2012
	private static readonly IntPtr NativeMethodInfoPtr_add_OnPostingCompleteAction_Public_Static_add_Void_Action_1_FB_PostResult_0;

	// Token: 0x040007DD RID: 2013
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnPostingCompleteAction_Public_Static_rem_Void_Action_1_FB_PostResult_0;

	// Token: 0x040007DE RID: 2014
	private static readonly IntPtr NativeMethodInfoPtr_add_OnFocusChangedAction_Public_Static_add_Void_Action_1_Boolean_0;

	// Token: 0x040007DF RID: 2015
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnFocusChangedAction_Public_Static_rem_Void_Action_1_Boolean_0;

	// Token: 0x040007E0 RID: 2016
	private static readonly IntPtr NativeMethodInfoPtr_add_OnAuthCompleteAction_Public_Static_add_Void_Action_1_FB_LoginResult_0;

	// Token: 0x040007E1 RID: 2017
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnAuthCompleteAction_Public_Static_rem_Void_Action_1_FB_LoginResult_0;

	// Token: 0x040007E2 RID: 2018
	private static readonly IntPtr NativeMethodInfoPtr_add_OnUserDataRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0;

	// Token: 0x040007E3 RID: 2019
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnUserDataRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0;

	// Token: 0x040007E4 RID: 2020
	private static readonly IntPtr NativeMethodInfoPtr_add_OnFriendsDataRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0;

	// Token: 0x040007E5 RID: 2021
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnFriendsDataRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0;

	// Token: 0x040007E6 RID: 2022
	private static readonly IntPtr NativeMethodInfoPtr_add_OnInvitableFriendsDataRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0;

	// Token: 0x040007E7 RID: 2023
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnInvitableFriendsDataRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0;

	// Token: 0x040007E8 RID: 2024
	private static readonly IntPtr NativeMethodInfoPtr_add_OnAppRequestCompleteAction_Public_Static_add_Void_Action_1_FB_AppRequestResult_0;

	// Token: 0x040007E9 RID: 2025
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnAppRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_AppRequestResult_0;

	// Token: 0x040007EA RID: 2026
	private static readonly IntPtr NativeMethodInfoPtr_add_OnAppRequestsLoaded_Public_Static_add_Void_Action_1_FB_Result_0;

	// Token: 0x040007EB RID: 2027
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnAppRequestsLoaded_Public_Static_rem_Void_Action_1_FB_Result_0;

	// Token: 0x040007EC RID: 2028
	private static readonly IntPtr NativeMethodInfoPtr_add_OnAppScoresRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0;

	// Token: 0x040007ED RID: 2029
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnAppScoresRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0;

	// Token: 0x040007EE RID: 2030
	private static readonly IntPtr NativeMethodInfoPtr_add_OnPlayerScoresRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0;

	// Token: 0x040007EF RID: 2031
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnPlayerScoresRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0;

	// Token: 0x040007F0 RID: 2032
	private static readonly IntPtr NativeMethodInfoPtr_add_OnSubmitScoreRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0;

	// Token: 0x040007F1 RID: 2033
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnSubmitScoreRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0;

	// Token: 0x040007F2 RID: 2034
	private static readonly IntPtr NativeMethodInfoPtr_add_OnDeleteScoresRequestCompleteAction_Public_Static_add_Void_Action_1_FB_Result_0;

	// Token: 0x040007F3 RID: 2035
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnDeleteScoresRequestCompleteAction_Public_Static_rem_Void_Action_1_FB_Result_0;

	// Token: 0x040007F4 RID: 2036
	private static readonly IntPtr NativeMethodInfoPtr_add_OnLikesListLoadedAction_Public_Static_add_Void_Action_1_FB_Result_0;

	// Token: 0x040007F5 RID: 2037
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnLikesListLoadedAction_Public_Static_rem_Void_Action_1_FB_Result_0;

	// Token: 0x040007F6 RID: 2038
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040007F7 RID: 2039
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	// Token: 0x040007F8 RID: 2040
	private static readonly IntPtr NativeMethodInfoPtr_Login_Public_Void_0;

	// Token: 0x040007F9 RID: 2041
	private static readonly IntPtr NativeMethodInfoPtr_Login_Public_Void_Il2CppStringArray_0;

	// Token: 0x040007FA RID: 2042
	private static readonly IntPtr NativeMethodInfoPtr_SendAppInvite_Public_Void_String_String_0;

	// Token: 0x040007FB RID: 2043
	private static readonly IntPtr NativeMethodInfoPtr_Logout_Public_Void_0;

	// Token: 0x040007FC RID: 2044
	private static readonly IntPtr NativeMethodInfoPtr_LoadUserData_Public_Void_0;

	// Token: 0x040007FD RID: 2045
	private static readonly IntPtr NativeMethodInfoPtr_LoadInvitableFrientdsInfo_Public_Void_Int32_0;

	// Token: 0x040007FE RID: 2046
	private static readonly IntPtr NativeMethodInfoPtr_GetInvitableFriendById_Public_FB_UserInfo_String_0;

	// Token: 0x040007FF RID: 2047
	private static readonly IntPtr NativeMethodInfoPtr_LoadFrientdsInfo_Public_Void_Int32_0;

	// Token: 0x04000800 RID: 2048
	private static readonly IntPtr NativeMethodInfoPtr_GetFriendById_Public_FB_UserInfo_String_0;

	// Token: 0x04000801 RID: 2049
	private static readonly IntPtr NativeMethodInfoPtr_PostImage_Public_Void_String_Texture2D_0;

	// Token: 0x04000802 RID: 2050
	private static readonly IntPtr NativeMethodInfoPtr_PostText_Public_Void_String_0;

	// Token: 0x04000803 RID: 2051
	private static readonly IntPtr NativeMethodInfoPtr_FeedShare_Public_Void_String_String_String_String_String_String_String_String_String_0;

	// Token: 0x04000804 RID: 2052
	private static readonly IntPtr NativeMethodInfoPtr_SendTrunRequest_Public_Void_String_String_String_Il2CppStringArray_0;

	// Token: 0x04000805 RID: 2053
	private static readonly IntPtr NativeMethodInfoPtr_SendGift_Public_Void_String_String_String_String_Il2CppStringArray_0;

	// Token: 0x04000806 RID: 2054
	private static readonly IntPtr NativeMethodInfoPtr_AskGift_Public_Void_String_String_String_String_Il2CppStringArray_0;

	// Token: 0x04000807 RID: 2055
	private static readonly IntPtr NativeMethodInfoPtr_SendInvite_Public_Void_String_String_String_Il2CppStringArray_0;

	// Token: 0x04000808 RID: 2056
	private static readonly IntPtr NativeMethodInfoPtr_OnAppRequestFailed_AndroidCB_Private_Void_String_0;

	// Token: 0x04000809 RID: 2057
	private static readonly IntPtr NativeMethodInfoPtr_OnAppRequestCompleted_AndroidCB_Private_Void_String_0;

	// Token: 0x0400080A RID: 2058
	private static readonly IntPtr NativeMethodInfoPtr_AppRequest_Public_Void_String_FB_RequestActionType_String_Il2CppStringArray_String_String_0;

	// Token: 0x0400080B RID: 2059
	private static readonly IntPtr NativeMethodInfoPtr_AppRequest_Public_Void_String_FB_RequestActionType_String_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0;

	// Token: 0x0400080C RID: 2060
	private static readonly IntPtr NativeMethodInfoPtr_AppRequest_Public_Void_String_Il2CppStringArray_List_1_Object_Il2CppStringArray_Nullable_1_Int32_String_String_0;

	// Token: 0x0400080D RID: 2061
	private static readonly IntPtr NativeMethodInfoPtr_LoadPendingRequests_Public_Void_0;

	// Token: 0x0400080E RID: 2062
	private static readonly IntPtr NativeMethodInfoPtr_OnRequestsLoadComplete_Private_Void_FB_Result_0;

	// Token: 0x0400080F RID: 2063
	private static readonly IntPtr NativeMethodInfoPtr_LoadPlayerScores_Public_Void_0;

	// Token: 0x04000810 RID: 2064
	private static readonly IntPtr NativeMethodInfoPtr_LoadAppScores_Public_Void_0;

	// Token: 0x04000811 RID: 2065
	private static readonly IntPtr NativeMethodInfoPtr_SubmitScore_Public_Void_Int32_0;

	// Token: 0x04000812 RID: 2066
	private static readonly IntPtr NativeMethodInfoPtr_DeletePlayerScores_Public_Void_0;

	// Token: 0x04000813 RID: 2067
	private static readonly IntPtr NativeMethodInfoPtr_LoadCurrentUserLikes_Public_Void_0;

	// Token: 0x04000814 RID: 2068
	private static readonly IntPtr NativeMethodInfoPtr_LoadLikes_Public_Void_String_0;

	// Token: 0x04000815 RID: 2069
	private static readonly IntPtr NativeMethodInfoPtr_LoadLikes_Public_Void_String_String_0;

	// Token: 0x04000816 RID: 2070
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentPlayerScoreByAppId_Public_FB_Score_String_0;

	// Token: 0x04000817 RID: 2071
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentPlayerIntScoreByAppId_Public_Int32_String_0;

	// Token: 0x04000818 RID: 2072
	private static readonly IntPtr NativeMethodInfoPtr_GetScoreByUserId_Public_Int32_String_0;

	// Token: 0x04000819 RID: 2073
	private static readonly IntPtr NativeMethodInfoPtr_GetScoreObjectByUserId_Public_FB_Score_String_0;

	// Token: 0x0400081A RID: 2074
	private static readonly IntPtr NativeMethodInfoPtr_GerUserLikesList_Public_List_1_FB_LikeInfo_String_0;

	// Token: 0x0400081B RID: 2075
	private static readonly IntPtr NativeMethodInfoPtr_IsUserLikesPage_Public_Boolean_String_String_0;

	// Token: 0x0400081C RID: 2076
	private static readonly IntPtr NativeMethodInfoPtr_get_IsInited_Public_get_Boolean_0;

	// Token: 0x0400081D RID: 2077
	private static readonly IntPtr NativeMethodInfoPtr_get_IsLoggedIn_Public_get_Boolean_0;

	// Token: 0x0400081E RID: 2078
	private static readonly IntPtr NativeMethodInfoPtr_get_UserId_Public_get_String_0;

	// Token: 0x0400081F RID: 2079
	private static readonly IntPtr NativeMethodInfoPtr_get_AccessToken_Public_get_String_0;

	// Token: 0x04000820 RID: 2080
	private static readonly IntPtr NativeMethodInfoPtr_get_AppId_Public_get_String_0;

	// Token: 0x04000821 RID: 2081
	private static readonly IntPtr NativeMethodInfoPtr_get_userInfo_Public_get_FB_UserInfo_0;

	// Token: 0x04000822 RID: 2082
	private static readonly IntPtr NativeMethodInfoPtr_get_friends_Public_get_Dictionary_2_String_FB_UserInfo_0;

	// Token: 0x04000823 RID: 2083
	private static readonly IntPtr NativeMethodInfoPtr_get_InvitableFriends_Public_get_Dictionary_2_String_FB_UserInfo_0;

	// Token: 0x04000824 RID: 2084
	private static readonly IntPtr NativeMethodInfoPtr_get_friendsIds_Public_get_List_1_String_0;

	// Token: 0x04000825 RID: 2085
	private static readonly IntPtr NativeMethodInfoPtr_get_InvitableFriendsIds_Public_get_List_1_String_0;

	// Token: 0x04000826 RID: 2086
	private static readonly IntPtr NativeMethodInfoPtr_get_friendsList_Public_get_List_1_FB_UserInfo_0;

	// Token: 0x04000827 RID: 2087
	private static readonly IntPtr NativeMethodInfoPtr_get_InvitableFriendsList_Public_get_List_1_FB_UserInfo_0;

	// Token: 0x04000828 RID: 2088
	private static readonly IntPtr NativeMethodInfoPtr_get_userScores_Public_get_Dictionary_2_String_FB_Score_0;

	// Token: 0x04000829 RID: 2089
	private static readonly IntPtr NativeMethodInfoPtr_get_appScores_Public_get_Dictionary_2_String_FB_Score_0;

	// Token: 0x0400082A RID: 2090
	private static readonly IntPtr NativeMethodInfoPtr_get_applicationScoreList_Public_get_List_1_FB_Score_0;

	// Token: 0x0400082B RID: 2091
	private static readonly IntPtr NativeMethodInfoPtr_get_AppRequests_Public_get_List_1_FB_AppRequest_0;

	// Token: 0x0400082C RID: 2092
	private static readonly IntPtr NativeMethodInfoPtr_get_FB_Public_get_SP_FB_API_0;

	// Token: 0x0400082D RID: 2093
	private static readonly IntPtr NativeMethodInfoPtr_OnUserLikesResult_Private_Void_FB_Result_FB_LikesRetrieveTask_0;

	// Token: 0x0400082E RID: 2094
	private static readonly IntPtr NativeMethodInfoPtr_OnScoreDeleted_Private_Void_FB_Result_0;

	// Token: 0x0400082F RID: 2095
	private static readonly IntPtr NativeMethodInfoPtr_OnScoreSubmited_Private_Void_FB_Result_0;

	// Token: 0x04000830 RID: 2096
	private static readonly IntPtr NativeMethodInfoPtr_OnAppScoresComplete_Private_Void_FB_Result_0;

	// Token: 0x04000831 RID: 2097
	private static readonly IntPtr NativeMethodInfoPtr_AddToAppScores_Private_Void_FB_Score_0;

	// Token: 0x04000832 RID: 2098
	private static readonly IntPtr NativeMethodInfoPtr_AddToUserScores_Private_Void_FB_Score_0;

	// Token: 0x04000833 RID: 2099
	private static readonly IntPtr NativeMethodInfoPtr_OnLoaPlayrScoresComplete_Private_Void_FB_Result_0;

	// Token: 0x04000834 RID: 2100
	private static readonly IntPtr NativeMethodInfoPtr_ParseInvitableFriendsData_Public_Void_String_0;

	// Token: 0x04000835 RID: 2101
	private static readonly IntPtr NativeMethodInfoPtr_ParseFriendsFromJson_Private_Void_String_Dictionary_2_String_FB_UserInfo_Boolean_0;

	// Token: 0x04000836 RID: 2102
	private static readonly IntPtr NativeMethodInfoPtr_ParseFriendsData_Public_Void_String_0;

	// Token: 0x04000837 RID: 2103
	private static readonly IntPtr NativeMethodInfoPtr_OnInitComplete_Public_Void_0;

	// Token: 0x04000838 RID: 2104
	private static readonly IntPtr NativeMethodInfoPtr_OnHideUnity_Public_Void_Boolean_0;

	// Token: 0x04000839 RID: 2105
	private static readonly IntPtr NativeMethodInfoPtr_LoginCallback_Public_Void_FB_LoginResult_0;

	// Token: 0x0400083A RID: 2106
	private static readonly IntPtr NativeMethodInfoPtr_PostCallback_Internal_Private_Void_FB_Result_0;

	// Token: 0x0400083B RID: 2107
	private static readonly IntPtr NativeMethodInfoPtr_PostCallback_Public_Void_FB_PostResult_0;

	// Token: 0x0400083C RID: 2108
	private static readonly IntPtr NativeMethodInfoPtr_AppRequestCallback_Public_Void_FB_AppRequestResult_0;

	// Token: 0x0400083D RID: 2109
	private static readonly IntPtr NativeMethodInfoPtr_AppInviteResultCallback_Public_Void_FB_AppInviteResult_0;

	// Token: 0x0400083E RID: 2110
	private static readonly IntPtr NativeMethodInfoPtr_UserDataCallBack_Private_Void_FB_Result_0;

	// Token: 0x0400083F RID: 2111
	private static readonly IntPtr NativeMethodInfoPtr_InvitableFriendsDataCallBack_Private_Void_FB_Result_0;

	// Token: 0x04000840 RID: 2112
	private static readonly IntPtr NativeMethodInfoPtr_FriendsDataCallBack_Private_Void_FB_Result_0;

	// Token: 0x04000841 RID: 2113
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200037B RID: 891
	public sealed class FB_Delegate : MulticastDelegate
	{
		// Token: 0x0600353D RID: 13629 RVA: 0x000DBB98 File Offset: 0x000D9D98
		// Note: this type is marked as 'beforefieldinit'.
		static FB_Delegate()
		{
			Il2CppClassPointerStore<SPFacebook.FB_Delegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "FB_Delegate");
			SPFacebook.FB_Delegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.FB_Delegate>.NativeClassPtr, 100670089);
			SPFacebook.FB_Delegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.FB_Delegate>.NativeClassPtr, 100670090);
			SPFacebook.FB_Delegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_FB_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.FB_Delegate>.NativeClassPtr, 100670091);
			SPFacebook.FB_Delegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.FB_Delegate>.NativeClassPtr, 100670092);
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x000DBC0C File Offset: 0x000D9E0C
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FB_Delegate(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SPFacebook.FB_Delegate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.FB_Delegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x000DBC68 File Offset: 0x000D9E68
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 59640, RefRangeEnd = 59663, XrefRangeStart = 59640, XrefRangeEnd = 59663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(FB_Result result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.FB_Delegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x000DBCAC File Offset: 0x000D9EAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163501, RefRangeEnd = 163503, XrefRangeStart = 163501, XrefRangeEnd = 163503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(FB_Result result, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.FB_Delegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_FB_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x000DBD20 File Offset: 0x000D9F20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.FB_Delegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003542 RID: 13634 RVA: 0x00014A8D File Offset: 0x00012C8D
		public FB_Delegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x00014A96 File Offset: 0x00012C96
		public static implicit operator SPFacebook.FB_Delegate(Action<FB_Result> A_0)
		{
			return DelegateSupport.ConvertDelegate<SPFacebook.FB_Delegate>(A_0);
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x00014A9E File Offset: 0x00012C9E
		public static SPFacebook.FB_Delegate operator +(SPFacebook.FB_Delegate A_0, SPFacebook.FB_Delegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<SPFacebook.FB_Delegate>();
		}

		// Token: 0x06003545 RID: 13637 RVA: 0x00014AAC File Offset: 0x00012CAC
		public static SPFacebook.FB_Delegate operator -(SPFacebook.FB_Delegate A_0, SPFacebook.FB_Delegate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<SPFacebook.FB_Delegate>();
			}
			return delegate2;
		}

		// Token: 0x04003114 RID: 12564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04003115 RID: 12565
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_FB_Result_0;

		// Token: 0x04003116 RID: 12566
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_FB_Result_AsyncCallback_Object_0;

		// Token: 0x04003117 RID: 12567
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x0200037C RID: 892
	[ObfuscatedName("SPFacebook+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x06003546 RID: 13638 RVA: 0x000DBD64 File Offset: 0x000D9F64
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SPFacebook>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr);
			SPFacebook.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, "<>9");
			SPFacebook.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670094);
			SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670095);
			SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670096);
			SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670097);
			SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670098);
			SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_4_Internal_Void_FB_AppInviteResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670099);
			SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670100);
			SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_6_Internal_Void_FB_PostResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670101);
			SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_7_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670102);
			SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_8_Internal_Void_FB_LoginResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670103);
			SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_9_Internal_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670104);
			SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_10_Internal_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670105);
			SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_11_Internal_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670106);
			SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_12_Internal_Void_FB_AppRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670107);
			SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_13_Internal_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670108);
			SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_14_Internal_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670109);
			SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_15_Internal_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670110);
			SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_16_Internal_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670111);
			SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_17_Internal_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670112);
			SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_18_Internal_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr, 100670113);
		}

		// Token: 0x06003547 RID: 13639 RVA: 0x000DBF34 File Offset: 0x000DA134
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SPFacebook.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x000DBF70 File Offset: 0x000DA170
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__161_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x000DBFA4 File Offset: 0x000DA1A4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__161_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x000DBFD8 File Offset: 0x000DA1D8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__161_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x000DC00C File Offset: 0x000DA20C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__161_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x000DC040 File Offset: 0x000DA240
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__161_4(FB_AppInviteResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_4_Internal_Void_FB_AppInviteResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x000DC084 File Offset: 0x000DA284
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__161_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x000DC0B8 File Offset: 0x000DA2B8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__161_6(FB_PostResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_6_Internal_Void_FB_PostResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x000DC0FC File Offset: 0x000DA2FC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__161_7(bool <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_7_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x000DC13C File Offset: 0x000DA33C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__161_8(FB_LoginResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_8_Internal_Void_FB_LoginResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x000DC180 File Offset: 0x000DA380
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__161_9(FB_Result <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_9_Internal_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x000DC1C4 File Offset: 0x000DA3C4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__161_10(FB_Result <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_10_Internal_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x000DC208 File Offset: 0x000DA408
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__161_11(FB_Result <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_11_Internal_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x000DC24C File Offset: 0x000DA44C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__161_12(FB_AppRequestResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_12_Internal_Void_FB_AppRequestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x000DC290 File Offset: 0x000DA490
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__161_13(FB_Result <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_13_Internal_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x000DC2D4 File Offset: 0x000DA4D4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__161_14(FB_Result <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_14_Internal_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x000DC318 File Offset: 0x000DA518
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__161_15(FB_Result <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_15_Internal_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x000DC35C File Offset: 0x000DA55C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__161_16(FB_Result <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_16_Internal_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003559 RID: 13657 RVA: 0x000DC3A0 File Offset: 0x000DA5A0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__161_17(FB_Result <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_17_Internal_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x000DC3E4 File Offset: 0x000DA5E4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__161_18(FB_Result <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SPFacebook.__c.NativeMethodInfoPtr___cctor_b__161_18_Internal_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x00014ABD File Offset: 0x00012CBD
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x0600355C RID: 13660 RVA: 0x000DC428 File Offset: 0x000DA628
		// (set) Token: 0x0600355D RID: 13661 RVA: 0x00014AC6 File Offset: 0x00012CC6
		public unsafe static SPFacebook.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SPFacebook.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SPFacebook.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SPFacebook.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003118 RID: 12568
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003119 RID: 12569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400311A RID: 12570
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__161_0_Internal_Void_0;

		// Token: 0x0400311B RID: 12571
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__161_1_Internal_Void_0;

		// Token: 0x0400311C RID: 12572
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__161_2_Internal_Void_0;

		// Token: 0x0400311D RID: 12573
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__161_3_Internal_Void_0;

		// Token: 0x0400311E RID: 12574
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__161_4_Internal_Void_FB_AppInviteResult_0;

		// Token: 0x0400311F RID: 12575
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__161_5_Internal_Void_0;

		// Token: 0x04003120 RID: 12576
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__161_6_Internal_Void_FB_PostResult_0;

		// Token: 0x04003121 RID: 12577
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__161_7_Internal_Void_Boolean_0;

		// Token: 0x04003122 RID: 12578
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__161_8_Internal_Void_FB_LoginResult_0;

		// Token: 0x04003123 RID: 12579
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__161_9_Internal_Void_FB_Result_0;

		// Token: 0x04003124 RID: 12580
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__161_10_Internal_Void_FB_Result_0;

		// Token: 0x04003125 RID: 12581
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__161_11_Internal_Void_FB_Result_0;

		// Token: 0x04003126 RID: 12582
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__161_12_Internal_Void_FB_AppRequestResult_0;

		// Token: 0x04003127 RID: 12583
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__161_13_Internal_Void_FB_Result_0;

		// Token: 0x04003128 RID: 12584
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__161_14_Internal_Void_FB_Result_0;

		// Token: 0x04003129 RID: 12585
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__161_15_Internal_Void_FB_Result_0;

		// Token: 0x0400312A RID: 12586
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__161_16_Internal_Void_FB_Result_0;

		// Token: 0x0400312B RID: 12587
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__161_17_Internal_Void_FB_Result_0;

		// Token: 0x0400312C RID: 12588
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__161_18_Internal_Void_FB_Result_0;
	}
}

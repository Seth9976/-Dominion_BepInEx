using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000047 RID: 71
public class AscensionLib : Object
{
	// Token: 0x06000BB9 RID: 3001 RVA: 0x0003C4E8 File Offset: 0x0003A6E8
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionLib()
	{
		Il2CppClassPointerStore<AscensionLib>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionLib");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr);
		AscensionLib.NativeFieldInfoPtr_DLL_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, "DLL_NAME");
		AscensionLib.NativeMethodInfoPtr_SetGameOptionsListener_Public_Static_Void_GameOptionsListenerDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664109);
		AscensionLib.NativeMethodInfoPtr_SelectGameOption_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664110);
		AscensionLib.NativeMethodInfoPtr_SelectGameOptionWithData_Public_Static_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664111);
		AscensionLib.NativeMethodInfoPtr_ResendGameOptionsList_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664112);
		AscensionLib.NativeMethodInfoPtr_GetGameParameters_Public_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664113);
		AscensionLib.NativeMethodInfoPtr_GetGamePlayerInfo_Public_Static_Int32_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664114);
		AscensionLib.NativeMethodInfoPtr_GetGamePlayerTimer_Public_Static_Int32_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664115);
		AscensionLib.NativeMethodInfoPtr_GetGamePlayerState_Public_Static_Int32_Int32_ptr_GamePlayerState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664116);
		AscensionLib.NativeMethodInfoPtr_GetGamePlayerLogCount_Public_Static_Int32_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664117);
		AscensionLib.NativeMethodInfoPtr_GetGamePlayerLog_Public_Static_Int32_Int32_UInt32_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664118);
		AscensionLib.NativeMethodInfoPtr_GetGamePlayerScoreState_Public_Static_Int32_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664119);
		AscensionLib.NativeMethodInfoPtr_GetGamePlayerPayResourcesState_Public_Static_Int32_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664120);
		AscensionLib.NativeMethodInfoPtr_GetGameAuctionInsightState_Public_Static_Int32_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664121);
		AscensionLib.NativeMethodInfoPtr_GetGamePlayerAIState_Public_Static_Int32_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664122);
		AscensionLib.NativeMethodInfoPtr_GetGameCardState_Public_Static_Int32_Int32_Il2CppStructArray_1_QueryCardState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664123);
		AscensionLib.NativeMethodInfoPtr_GetKingdomStackList_Public_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664124);
		AscensionLib.NativeMethodInfoPtr_GetNextCenterRowMagnifyScroll_Public_Static_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664125);
		AscensionLib.NativeMethodInfoPtr_GetWinnerID_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664126);
		AscensionLib.NativeMethodInfoPtr_GetNonTrophyHintCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664127);
		AscensionLib.NativeMethodInfoPtr_GetCanUseTempleOfImmortalityForThisCard_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664128);
		AscensionLib.NativeMethodInfoPtr_GetHasBetterUsableHint_Public_Static_Int32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664129);
		AscensionLib.NativeMethodInfoPtr_GetHasSelectableDreamscapeCard_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664130);
		AscensionLib.NativeMethodInfoPtr_GetHasSelectableUniqueZoneCard_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664131);
		AscensionLib.NativeMethodInfoPtr_GetCardTransformName_Public_Static_Int32_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664132);
		AscensionLib.NativeMethodInfoPtr_GetCenterRowCardType_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664133);
		AscensionLib.NativeMethodInfoPtr_GetPlayedCardPositionIndex_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664134);
		AscensionLib.NativeMethodInfoPtr_GetPlayedCardEntryList_Public_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664135);
		AscensionLib.NativeMethodInfoPtr_GetResolveCardPositionIndex_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664136);
		AscensionLib.NativeMethodInfoPtr_GetResolveCardEntryList_Public_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664137);
		AscensionLib.NativeMethodInfoPtr_GetInstanceID_Public_Static_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664138);
		AscensionLib.NativeMethodInfoPtr_GetInstanceList_Public_Static_Int32_Int32_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664139);
		AscensionLib.NativeMethodInfoPtr_GetInstanceData_Public_Static_Int32_Int32_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664140);
		AscensionLib.NativeMethodInfoPtr_GetCardDataByName_Public_Static_Int32_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664141);
		AscensionLib.NativeMethodInfoPtr_Initialize_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664142);
		AscensionLib.NativeMethodInfoPtr_Shutdown_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664143);
		AscensionLib.NativeMethodInfoPtr_StartGame_Public_Static_Void_IntPtr_Int32_Il2CppReferenceArray_1_AppPlayerData_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664144);
		AscensionLib.NativeMethodInfoPtr_StartTutorial_Public_Static_Void_IntPtr_Int32_Il2CppReferenceArray_1_AppPlayerData_Int32_UInt32_Int32_Il2CppStructArray_1_TutorialAIStep_Int32_Il2CppStructArray_1_TutorialAIStep_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664145);
		AscensionLib.NativeMethodInfoPtr_SetTutorialSyncAIOptions_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664146);
		AscensionLib.NativeMethodInfoPtr_ResumeGame_Public_Static_Void_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664147);
		AscensionLib.NativeMethodInfoPtr_ExitCurrentGame_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664148);
		AscensionLib.NativeMethodInfoPtr_UpdateGame_Public_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664149);
		AscensionLib.NativeMethodInfoPtr_ForceUpdateStateMachineInput_Public_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664150);
		AscensionLib.NativeMethodInfoPtr_HasTemporaryMoveBuffer_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664151);
		AscensionLib.NativeMethodInfoPtr_CommitTemporaryMoveBuffer_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664152);
		AscensionLib.NativeMethodInfoPtr_GetCurrentGameID_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664153);
		AscensionLib.NativeMethodInfoPtr_GetGamePlayerCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664154);
		AscensionLib.NativeMethodInfoPtr_GetGamePlayerAICount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664155);
		AscensionLib.NativeMethodInfoPtr_GetGameRoundNumber_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664156);
		AscensionLib.NativeMethodInfoPtr_GetGameCompleted_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664157);
		AscensionLib.NativeMethodInfoPtr_GetLocalPlayerIndex_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664158);
		AscensionLib.NativeMethodInfoPtr_GetLocalPlayerInstanceID_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664159);
		AscensionLib.NativeMethodInfoPtr_GetLocalOpponentPlayerIndex_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664160);
		AscensionLib.NativeMethodInfoPtr_GetLocalOpponentInstanceID_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664161);
		AscensionLib.NativeMethodInfoPtr_GetPlayerIndexByTurnOrder_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664162);
		AscensionLib.NativeMethodInfoPtr_GetCardInPlayExtraData_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664163);
		AscensionLib.NativeMethodInfoPtr_GetIsOnlineGame_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664164);
		AscensionLib.NativeMethodInfoPtr_GetIsTutorialGame_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664165);
		AscensionLib.NativeMethodInfoPtr_GetIsHotseatGame_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664166);
		AscensionLib.NativeMethodInfoPtr_GetNewLocalPlayerID_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664167);
		AscensionLib.NativeMethodInfoPtr_GetCurrentGameMoveCount_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664168);
		AscensionLib.NativeMethodInfoPtr_GetCurrentGameNextMoveIndex_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664169);
		AscensionLib.NativeMethodInfoPtr_GetCurrentGameNetworkConfirmCount_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664170);
		AscensionLib.NativeMethodInfoPtr_SetGameSpeed_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664171);
		AscensionLib.NativeMethodInfoPtr_AttemptToLoadOldSaveData_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664172);
		AscensionLib.NativeMethodInfoPtr_AttemptToLoadOldProfileData_Public_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664173);
		AscensionLib.NativeMethodInfoPtr_SetSaveDataFunc_Public_Static_Void_SaveWorldDataDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664174);
		AscensionLib.NativeMethodInfoPtr_NetworkCreate_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664175);
		AscensionLib.NativeMethodInfoPtr_NetworkLogin_Public_Static_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664176);
		AscensionLib.NativeMethodInfoPtr_NetworkCreateAccount_Public_Static_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664177);
		AscensionLib.NativeMethodInfoPtr_NetworkSetLoginPassword_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664178);
		AscensionLib.NativeMethodInfoPtr_NetworkSetCreateAccount_Public_Static_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664179);
		AscensionLib.NativeMethodInfoPtr_NetworkConnect_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664180);
		AscensionLib.NativeMethodInfoPtr_NetworkUpdate_Public_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664181);
		AscensionLib.NativeMethodInfoPtr_NetworkDisconnect_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664182);
		AscensionLib.NativeMethodInfoPtr_NetworkDestroy_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664183);
		AscensionLib.NativeMethodInfoPtr_NetworkResumeGame_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664184);
		AscensionLib.NativeMethodInfoPtr_NetworkGameFinished_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664185);
		AscensionLib.NativeMethodInfoPtr_NetworkGetActiveGames_Public_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664186);
		AscensionLib.NativeMethodInfoPtr_NetworkGetActiveGameWithID_Public_Static_Int32_IntPtr_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664187);
		AscensionLib.NativeMethodInfoPtr_NetworkGetCompletedGames_Public_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664188);
		AscensionLib.NativeMethodInfoPtr_NetworkGetGamePlayerTimers_Public_Static_Int32_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664189);
		AscensionLib.NativeMethodInfoPtr_NetworkRefreshAvailableGames_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664190);
		AscensionLib.NativeMethodInfoPtr_NetworkGetAvailableGames_Public_Static_Int32_IntPtr_Int32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664191);
		AscensionLib.NativeMethodInfoPtr_NetworkJoinGame_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664192);
		AscensionLib.NativeMethodInfoPtr_NetworkCreateGame_Public_Static_Int32_UInt32_IntPtr_UInt32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664193);
		AscensionLib.NativeMethodInfoPtr_NetworkSetNotifyDeviceId_Public_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664194);
		AscensionLib.NativeMethodInfoPtr_NetworkSendLocalAvatarIndex_Public_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664195);
		AscensionLib.NativeMethodInfoPtr_NetworkGetFriendsList_Public_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664196);
		AscensionLib.NativeMethodInfoPtr_NetworkAddFriendFromUserId_Public_Static_Int32_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664197);
		AscensionLib.NativeMethodInfoPtr_NetworkAddFriendFromUsername_Public_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664198);
		AscensionLib.NativeMethodInfoPtr_NetworkRemoveFriendWithUserId_Public_Static_Int32_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664199);
		AscensionLib.NativeMethodInfoPtr_NetworkAddFriendFromEmail_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664200);
		AscensionLib.NativeMethodInfoPtr_NetworkGetUserOnlineStatus_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664201);
		AscensionLib.NativeMethodInfoPtr_NetworkRequestUsersOnlineStatus_Public_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664202);
		AscensionLib.NativeMethodInfoPtr_NetworkGetLocalID_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664203);
		AscensionLib.NativeMethodInfoPtr_NetworkGetLocalAvatar_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664204);
		AscensionLib.NativeMethodInfoPtr_NetworkGetLocalRating_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664205);
		AscensionLib.NativeMethodInfoPtr_NetworkGetLocalName_Public_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664206);
		AscensionLib.NativeMethodInfoPtr_NetworkRemotePlayerProfile_Public_Static_Void_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664207);
		AscensionLib.NativeMethodInfoPtr_NetworkLocalPlayerProfile_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664208);
		AscensionLib.NativeMethodInfoPtr_NetworkRequestPlayerProfile_Public_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664209);
		AscensionLib.NativeMethodInfoPtr_NetworkGetGameFriends_Public_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664210);
		AscensionLib.NativeMethodInfoPtr_NetworkGetNumGameFriends_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664211);
		AscensionLib.NativeMethodInfoPtr_NetworkForfeitGame_Public_Static_Int32_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664212);
		AscensionLib.NativeMethodInfoPtr_NetworkSetMonitorGame_Public_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664213);
		AscensionLib.NativeMethodInfoPtr_NetworkClearMonitorGame_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664214);
		AscensionLib.NativeMethodInfoPtr_NetworkRequestGameMonitor_Public_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664215);
		AscensionLib.NativeMethodInfoPtr_NetworkDeleteGame_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664216);
		AscensionLib.NativeMethodInfoPtr_NetworkWithdrawFromGame_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664217);
		AscensionLib.NativeMethodInfoPtr_NetworkLaunchGame_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664218);
		AscensionLib.NativeMethodInfoPtr_NetworkAcceptGameInvite_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664219);
		AscensionLib.NativeMethodInfoPtr_NetworkGetChatChannelMessageCount_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664220);
		AscensionLib.NativeMethodInfoPtr_NetworkGetChatChannelMessageList_Public_Static_UInt32_UInt32_UInt32_UInt32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664221);
		AscensionLib.NativeMethodInfoPtr_NetworkSubmitChatMessage_Public_Static_Void_UInt32_UInt32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664222);
		AscensionLib.NativeMethodInfoPtr_NetworkSubmitChatPosition_Public_Static_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664223);
		AscensionLib.NativeMethodInfoPtr_NetworkGetChatPosition_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664224);
		AscensionLib.NativeMethodInfoPtr_NetworkGetLastChatMessageIndex_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664225);
		AscensionLib.NativeMethodInfoPtr_NetworkGetGameWaitingCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664226);
		AscensionLib.NativeMethodInfoPtr_NetworkGetNextActiveGameID_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664227);
		AscensionLib.NativeMethodInfoPtr_NetworkGetRematchGameData_Public_Static_Int32_UInt32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664228);
		AscensionLib.NativeMethodInfoPtr_NetworkRematchGame_Public_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664229);
		AscensionLib.NativeMethodInfoPtr_NetworkIsConnectedToServer_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664230);
		AscensionLib.NativeMethodInfoPtr_NetworkIsCreatingAccount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664231);
		AscensionLib.NativeMethodInfoPtr_NetworkGetNotificationSetting_Public_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664232);
		AscensionLib.NativeMethodInfoPtr_NetworkSetNotificationSetting_Public_Static_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664233);
		AscensionLib.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, 100664234);
	}

	// Token: 0x06000BBA RID: 3002 RVA: 0x0003CF04 File Offset: 0x0003B104
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237631, RefRangeEnd = 237633, XrefRangeStart = 237629, XrefRangeEnd = 237631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGameOptionsListener(AscensionLib.GameOptionsListenerDelegate pGameOptionsListenerFunc)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pGameOptionsListenerFunc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_SetGameOptionsListener_Public_Static_Void_GameOptionsListenerDelegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BBB RID: 3003 RVA: 0x0003CF3C File Offset: 0x0003B13C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237635, RefRangeEnd = 237636, XrefRangeStart = 237633, XrefRangeEnd = 237635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SelectGameOption(int optionIndex)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref optionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_SelectGameOption_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BBC RID: 3004 RVA: 0x0003CF70 File Offset: 0x0003B170
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237638, RefRangeEnd = 237639, XrefRangeStart = 237636, XrefRangeEnd = 237638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SelectGameOptionWithData(int optionIndex, uint selectionData)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref optionIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionData;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_SelectGameOptionWithData_Public_Static_Void_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BBD RID: 3005 RVA: 0x0003CFB0 File Offset: 0x0003B1B0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237641, RefRangeEnd = 237642, XrefRangeStart = 237639, XrefRangeEnd = 237641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResendGameOptionsList()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_ResendGameOptionsList_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BBE RID: 3006 RVA: 0x0003CFD8 File Offset: 0x0003B1D8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237644, RefRangeEnd = 237646, XrefRangeStart = 237642, XrefRangeEnd = 237644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr GetGameParameters()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetGameParameters_Public_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x0003D008 File Offset: 0x0003B208
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 237648, RefRangeEnd = 237658, XrefRangeStart = 237646, XrefRangeEnd = 237648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetGamePlayerInfo(int playerID, IntPtr pData, int maxDataSize)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pData;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDataSize;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetGamePlayerInfo_Public_Static_Int32_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BC0 RID: 3008 RVA: 0x0003D064 File Offset: 0x0003B264
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237660, RefRangeEnd = 237661, XrefRangeStart = 237658, XrefRangeEnd = 237660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetGamePlayerTimer(int playerID, IntPtr pData, int maxDataSize)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pData;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDataSize;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetGamePlayerTimer_Public_Static_Int32_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BC1 RID: 3009 RVA: 0x0003D0C0 File Offset: 0x0003B2C0
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 237663, RefRangeEnd = 237669, XrefRangeStart = 237661, XrefRangeEnd = 237663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetGamePlayerState(int playerIndex, GamePlayerState* pData, int maxDataSize)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pData;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDataSize;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetGamePlayerState_Public_Static_Int32_Int32_ptr_GamePlayerState_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BC2 RID: 3010 RVA: 0x0003D118 File Offset: 0x0003B318
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 237671, RefRangeEnd = 237674, XrefRangeStart = 237669, XrefRangeEnd = 237671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetGamePlayerLogCount(int playerIndex, uint roundNumber)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref roundNumber;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetGamePlayerLogCount_Public_Static_Int32_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BC3 RID: 3011 RVA: 0x0003D164 File Offset: 0x0003B364
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237676, RefRangeEnd = 237678, XrefRangeStart = 237674, XrefRangeEnd = 237676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetGamePlayerLog(int playerIndex, uint roundNumber, IntPtr cardIDs, IntPtr cardStates, int maxCards)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref roundNumber;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardIDs;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardStates;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCards;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetGamePlayerLog_Public_Static_Int32_Int32_UInt32_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BC4 RID: 3012 RVA: 0x0003D1DC File Offset: 0x0003B3DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237678, XrefRangeEnd = 237680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetGamePlayerScoreState(int playerIndex, IntPtr pData, int maxDataSize)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pData;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDataSize;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetGamePlayerScoreState_Public_Static_Int32_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BC5 RID: 3013 RVA: 0x0003D238 File Offset: 0x0003B438
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237682, RefRangeEnd = 237683, XrefRangeStart = 237680, XrefRangeEnd = 237682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetGamePlayerPayResourcesState(int playerIndex, IntPtr pData, int maxDataSize)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pData;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDataSize;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetGamePlayerPayResourcesState_Public_Static_Int32_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BC6 RID: 3014 RVA: 0x0003D294 File Offset: 0x0003B494
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237685, RefRangeEnd = 237686, XrefRangeStart = 237683, XrefRangeEnd = 237685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetGameAuctionInsightState(int playerIndex, IntPtr pData, int maxDataSize)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pData;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDataSize;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetGameAuctionInsightState_Public_Static_Int32_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BC7 RID: 3015 RVA: 0x0003D2F0 File Offset: 0x0003B4F0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237688, RefRangeEnd = 237689, XrefRangeStart = 237686, XrefRangeEnd = 237688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetGamePlayerAIState(int playerID, IntPtr pData, int maxDataSize)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pData;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDataSize;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetGamePlayerAIState_Public_Static_Int32_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BC8 RID: 3016 RVA: 0x0003D34C File Offset: 0x0003B54C
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 237691, RefRangeEnd = 237697, XrefRangeStart = 237689, XrefRangeEnd = 237691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetGameCardState(int queryCardCount, Il2CppStructArray<QueryCardState> pQueryCardBuffer, int bufferLen)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref queryCardCount;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pQueryCardBuffer);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferLen;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetGameCardState_Public_Static_Int32_Int32_Il2CppStructArray_1_QueryCardState_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BC9 RID: 3017 RVA: 0x0003D3AC File Offset: 0x0003B5AC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237699, RefRangeEnd = 237700, XrefRangeStart = 237697, XrefRangeEnd = 237699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetKingdomStackList(IntPtr pData, int maxDataSize)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pData;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDataSize;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetKingdomStackList_Public_Static_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BCA RID: 3018 RVA: 0x0003D3F8 File Offset: 0x0003B5F8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237702, RefRangeEnd = 237704, XrefRangeStart = 237700, XrefRangeEnd = 237702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetNextCenterRowMagnifyScroll(int currentInstanceID, bool bScrollDirectionRight)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref currentInstanceID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bScrollDirectionRight;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetNextCenterRowMagnifyScroll_Public_Static_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BCB RID: 3019 RVA: 0x0003D444 File Offset: 0x0003B644
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237706, RefRangeEnd = 237707, XrefRangeStart = 237704, XrefRangeEnd = 237706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetWinnerID()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetWinnerID_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BCC RID: 3020 RVA: 0x0003D474 File Offset: 0x0003B674
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 237709, RefRangeEnd = 237712, XrefRangeStart = 237707, XrefRangeEnd = 237709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetNonTrophyHintCount()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetNonTrophyHintCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BCD RID: 3021 RVA: 0x0003D4A4 File Offset: 0x0003B6A4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237714, RefRangeEnd = 237716, XrefRangeStart = 237712, XrefRangeEnd = 237714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetCanUseTempleOfImmortalityForThisCard(uint hint, uint instanceID)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref hint;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instanceID;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetCanUseTempleOfImmortalityForThisCard_Public_Static_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BCE RID: 3022 RVA: 0x0003D4F0 File Offset: 0x0003B6F0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237718, RefRangeEnd = 237719, XrefRangeStart = 237716, XrefRangeEnd = 237718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetHasBetterUsableHint(uint hint, uint instanceID)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref hint;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instanceID;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetHasBetterUsableHint_Public_Static_Int32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BCF RID: 3023 RVA: 0x0003D53C File Offset: 0x0003B73C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237721, RefRangeEnd = 237722, XrefRangeStart = 237719, XrefRangeEnd = 237721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetHasSelectableDreamscapeCard()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetHasSelectableDreamscapeCard_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BD0 RID: 3024 RVA: 0x0003D56C File Offset: 0x0003B76C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237724, RefRangeEnd = 237725, XrefRangeStart = 237722, XrefRangeEnd = 237724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetHasSelectableUniqueZoneCard()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetHasSelectableUniqueZoneCard_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BD1 RID: 3025 RVA: 0x0003D59C File Offset: 0x0003B79C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237725, XrefRangeEnd = 237727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCardTransformName(int cardInstanceID, IntPtr pData, int maxDataSize)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref cardInstanceID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pData;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDataSize;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetCardTransformName_Public_Static_Int32_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BD2 RID: 3026 RVA: 0x0003D5F8 File Offset: 0x0003B7F8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237729, RefRangeEnd = 237730, XrefRangeStart = 237727, XrefRangeEnd = 237729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCenterRowCardType(int centerRowIndex, int cardInstanceID)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref centerRowIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardInstanceID;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetCenterRowCardType_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BD3 RID: 3027 RVA: 0x0003D644 File Offset: 0x0003B844
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237732, RefRangeEnd = 237733, XrefRangeStart = 237730, XrefRangeEnd = 237732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPlayedCardPositionIndex(int playedCardInstanceID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playedCardInstanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetPlayedCardPositionIndex_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000BD4 RID: 3028 RVA: 0x0003D684 File Offset: 0x0003B884
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237735, RefRangeEnd = 237736, XrefRangeStart = 237733, XrefRangeEnd = 237735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPlayedCardEntryList(IntPtr pInstanceIDs, int maxInstanceCount)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pInstanceIDs;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxInstanceCount;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetPlayedCardEntryList_Public_Static_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BD5 RID: 3029 RVA: 0x0003D6D0 File Offset: 0x0003B8D0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237738, RefRangeEnd = 237739, XrefRangeStart = 237736, XrefRangeEnd = 237738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetResolveCardPositionIndex(int resolveCardInstanceID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref resolveCardInstanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetResolveCardPositionIndex_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000BD6 RID: 3030 RVA: 0x0003D710 File Offset: 0x0003B910
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237741, RefRangeEnd = 237742, XrefRangeStart = 237739, XrefRangeEnd = 237741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetResolveCardEntryList(IntPtr pInstanceIDs, int maxInstanceCount)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pInstanceIDs;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxInstanceCount;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetResolveCardEntryList_Public_Static_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BD7 RID: 3031 RVA: 0x0003D75C File Offset: 0x0003B95C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237742, XrefRangeEnd = 237745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetInstanceID(int instanceType, string instanceName)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instanceType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(instanceName);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetInstanceID_Public_Static_Int32_Int32_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BD8 RID: 3032 RVA: 0x0003D7AC File Offset: 0x0003B9AC
	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 237747, RefRangeEnd = 237763, XrefRangeStart = 237745, XrefRangeEnd = 237747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetInstanceList(int instanceType, int playerIndex, IntPtr pInstanceIDs, int maxInstanceCount)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instanceType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerIndex;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pInstanceIDs;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxInstanceCount;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetInstanceList_Public_Static_Int32_Int32_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BD9 RID: 3033 RVA: 0x0003D814 File Offset: 0x0003BA14
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 237765, RefRangeEnd = 237770, XrefRangeStart = 237763, XrefRangeEnd = 237765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetInstanceData(int instanceType, int instanceID, IntPtr pData, int maxDataSize)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instanceType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instanceID;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pData;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDataSize;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetInstanceData_Public_Static_Int32_Int32_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BDA RID: 3034 RVA: 0x0003D87C File Offset: 0x0003BA7C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237773, RefRangeEnd = 237775, XrefRangeStart = 237770, XrefRangeEnd = 237773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCardDataByName(string pCardName, IntPtr pData, int maxDataSize)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(pCardName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pData;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDataSize;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetCardDataByName_Public_Static_Int32_String_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BDB RID: 3035 RVA: 0x0003D8DC File Offset: 0x0003BADC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237778, RefRangeEnd = 237779, XrefRangeStart = 237775, XrefRangeEnd = 237778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize(string data_path, int processorCount)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data_path);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref processorCount;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_Initialize_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BDC RID: 3036 RVA: 0x0003D920 File Offset: 0x0003BB20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237779, XrefRangeEnd = 237781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Shutdown()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_Shutdown_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BDD RID: 3037 RVA: 0x0003D948 File Offset: 0x0003BB48
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237787, RefRangeEnd = 237788, XrefRangeStart = 237781, XrefRangeEnd = 237787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartGame(IntPtr pGameParameters, int numPlayers, Il2CppReferenceArray<AppPlayerData> pAppPlayerData, uint randomSeed, bool bSoakTest)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pGameParameters;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPlayers;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pAppPlayerData);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomSeed;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSoakTest;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_StartGame_Public_Static_Void_IntPtr_Int32_Il2CppReferenceArray_1_AppPlayerData_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BDE RID: 3038 RVA: 0x0003D9B8 File Offset: 0x0003BBB8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237794, RefRangeEnd = 237795, XrefRangeStart = 237788, XrefRangeEnd = 237794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartTutorial(IntPtr pGameParameters, int numPlayers, Il2CppReferenceArray<AppPlayerData> pAppPlayerData, int tutorialIndex, uint randomSeed, int tutorialSetupStepCount, Il2CppStructArray<TutorialAIStep> tutorialSetupSteps, int tutorialAIStepCount, Il2CppStructArray<TutorialAIStep> tutorialAISteps, int randomDieResultCount, Il2CppStructArray<byte> randomDieResults)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pGameParameters;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPlayers;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pAppPlayerData);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tutorialIndex;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomSeed;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tutorialSetupStepCount;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tutorialSetupSteps);
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tutorialAIStepCount;
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tutorialAISteps);
		ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomDieResultCount;
		ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(randomDieResults);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_StartTutorial_Public_Static_Void_IntPtr_Int32_Il2CppReferenceArray_1_AppPlayerData_Int32_UInt32_Int32_Il2CppStructArray_1_TutorialAIStep_Int32_Il2CppStructArray_1_TutorialAIStep_Int32_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BDF RID: 3039 RVA: 0x0003DA8C File Offset: 0x0003BC8C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237797, RefRangeEnd = 237798, XrefRangeStart = 237795, XrefRangeEnd = 237797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetTutorialSyncAIOptions()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_SetTutorialSyncAIOptions_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BE0 RID: 3040 RVA: 0x0003DAB4 File Offset: 0x0003BCB4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237800, RefRangeEnd = 237801, XrefRangeStart = 237798, XrefRangeEnd = 237800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResumeGame(IntPtr pGameWorldData, int size, int WorldDataVersion)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pGameWorldData;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref WorldDataVersion;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_ResumeGame_Public_Static_Void_IntPtr_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BE1 RID: 3041 RVA: 0x0003DB04 File Offset: 0x0003BD04
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 237803, RefRangeEnd = 237807, XrefRangeStart = 237801, XrefRangeEnd = 237803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ExitCurrentGame()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_ExitCurrentGame_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BE2 RID: 3042 RVA: 0x0003DB2C File Offset: 0x0003BD2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237807, XrefRangeEnd = 237809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int UpdateGame(IntPtr pGameEvents, int maxEvents)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pGameEvents;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxEvents;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_UpdateGame_Public_Static_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BE3 RID: 3043 RVA: 0x0003DB78 File Offset: 0x0003BD78
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 237811, RefRangeEnd = 237814, XrefRangeStart = 237809, XrefRangeEnd = 237811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ForceUpdateStateMachineInput(IntPtr pGameEvents, int maxEvents)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pGameEvents;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxEvents;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_ForceUpdateStateMachineInput_Public_Static_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BE4 RID: 3044 RVA: 0x0003DBC4 File Offset: 0x0003BDC4
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 237816, RefRangeEnd = 237820, XrefRangeStart = 237814, XrefRangeEnd = 237816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int HasTemporaryMoveBuffer()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_HasTemporaryMoveBuffer_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BE5 RID: 3045 RVA: 0x0003DBF4 File Offset: 0x0003BDF4
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 237822, RefRangeEnd = 237828, XrefRangeStart = 237820, XrefRangeEnd = 237822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CommitTemporaryMoveBuffer()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_CommitTemporaryMoveBuffer_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BE6 RID: 3046 RVA: 0x0003DC1C File Offset: 0x0003BE1C
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 237830, RefRangeEnd = 237835, XrefRangeStart = 237828, XrefRangeEnd = 237830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetCurrentGameID()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetCurrentGameID_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BE7 RID: 3047 RVA: 0x0003DC4C File Offset: 0x0003BE4C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237837, RefRangeEnd = 237838, XrefRangeStart = 237835, XrefRangeEnd = 237837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetGamePlayerCount()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetGamePlayerCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BE8 RID: 3048 RVA: 0x0003DC7C File Offset: 0x0003BE7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237838, XrefRangeEnd = 237840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetGamePlayerAICount()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetGamePlayerAICount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BE9 RID: 3049 RVA: 0x0003DCAC File Offset: 0x0003BEAC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237840, XrefRangeEnd = 237842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetGameRoundNumber()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetGameRoundNumber_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BEA RID: 3050 RVA: 0x0003DCDC File Offset: 0x0003BEDC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237844, RefRangeEnd = 237845, XrefRangeStart = 237842, XrefRangeEnd = 237844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetGameCompleted()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetGameCompleted_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BEB RID: 3051 RVA: 0x0003DD0C File Offset: 0x0003BF0C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 237847, RefRangeEnd = 237851, XrefRangeStart = 237845, XrefRangeEnd = 237847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetLocalPlayerIndex()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetLocalPlayerIndex_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BEC RID: 3052 RVA: 0x0003DD3C File Offset: 0x0003BF3C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237853, RefRangeEnd = 237855, XrefRangeStart = 237851, XrefRangeEnd = 237853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetLocalPlayerInstanceID()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetLocalPlayerInstanceID_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BED RID: 3053 RVA: 0x0003DD6C File Offset: 0x0003BF6C
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 237857, RefRangeEnd = 237862, XrefRangeStart = 237855, XrefRangeEnd = 237857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetLocalOpponentPlayerIndex(int opponent_index)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref opponent_index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetLocalOpponentPlayerIndex_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000BEE RID: 3054 RVA: 0x0003DDAC File Offset: 0x0003BFAC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 237864, RefRangeEnd = 237867, XrefRangeStart = 237862, XrefRangeEnd = 237864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetLocalOpponentInstanceID(int opponent_index)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref opponent_index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetLocalOpponentInstanceID_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000BEF RID: 3055 RVA: 0x0003DDEC File Offset: 0x0003BFEC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237869, RefRangeEnd = 237871, XrefRangeStart = 237867, XrefRangeEnd = 237869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPlayerIndexByTurnOrder(int player_index)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref player_index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetPlayerIndexByTurnOrder_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000BF0 RID: 3056 RVA: 0x0003DE2C File Offset: 0x0003C02C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237873, RefRangeEnd = 237874, XrefRangeStart = 237871, XrefRangeEnd = 237873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCardInPlayExtraData(int cardInPlayInstanceID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref cardInPlayInstanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetCardInPlayExtraData_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000BF1 RID: 3057 RVA: 0x0003DE6C File Offset: 0x0003C06C
	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 237876, RefRangeEnd = 237890, XrefRangeStart = 237874, XrefRangeEnd = 237876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetIsOnlineGame()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetIsOnlineGame_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BF2 RID: 3058 RVA: 0x0003DE9C File Offset: 0x0003C09C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 237892, RefRangeEnd = 237895, XrefRangeStart = 237890, XrefRangeEnd = 237892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetIsTutorialGame()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetIsTutorialGame_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BF3 RID: 3059 RVA: 0x0003DECC File Offset: 0x0003C0CC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 237897, RefRangeEnd = 237900, XrefRangeStart = 237895, XrefRangeEnd = 237897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetIsHotseatGame()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetIsHotseatGame_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BF4 RID: 3060 RVA: 0x0003DEFC File Offset: 0x0003C0FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237900, XrefRangeEnd = 237902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetNewLocalPlayerID()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetNewLocalPlayerID_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BF5 RID: 3061 RVA: 0x0003DF2C File Offset: 0x0003C12C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237902, XrefRangeEnd = 237904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetCurrentGameMoveCount()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetCurrentGameMoveCount_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BF6 RID: 3062 RVA: 0x0003DF5C File Offset: 0x0003C15C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237906, RefRangeEnd = 237908, XrefRangeStart = 237904, XrefRangeEnd = 237906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetCurrentGameNextMoveIndex()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetCurrentGameNextMoveIndex_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BF7 RID: 3063 RVA: 0x0003DF8C File Offset: 0x0003C18C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237910, RefRangeEnd = 237912, XrefRangeStart = 237908, XrefRangeEnd = 237910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint GetCurrentGameNetworkConfirmCount()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_GetCurrentGameNetworkConfirmCount_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BF8 RID: 3064 RVA: 0x0003DFBC File Offset: 0x0003C1BC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237914, RefRangeEnd = 237916, XrefRangeStart = 237912, XrefRangeEnd = 237914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGameSpeed(int speed)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref speed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_SetGameSpeed_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BF9 RID: 3065 RVA: 0x0003DFF0 File Offset: 0x0003C1F0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237918, RefRangeEnd = 237919, XrefRangeStart = 237916, XrefRangeEnd = 237918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AttemptToLoadOldSaveData(int slot)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_AttemptToLoadOldSaveData_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000BFA RID: 3066 RVA: 0x0003E030 File Offset: 0x0003C230
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237921, RefRangeEnd = 237922, XrefRangeStart = 237919, XrefRangeEnd = 237921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AttemptToLoadOldProfileData(IntPtr pBuffer, int bufLen)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pBuffer;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufLen;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_AttemptToLoadOldProfileData_Public_Static_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000BFB RID: 3067 RVA: 0x0003E07C File Offset: 0x0003C27C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237924, RefRangeEnd = 237926, XrefRangeStart = 237922, XrefRangeEnd = 237924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSaveDataFunc(AscensionLib.SaveWorldDataDelegate pOutputMessageFunc)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pOutputMessageFunc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_SetSaveDataFunc_Public_Static_Void_SaveWorldDataDelegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BFC RID: 3068 RVA: 0x0003E0B4 File Offset: 0x0003C2B4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237928, RefRangeEnd = 237930, XrefRangeStart = 237926, XrefRangeEnd = 237928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkCreate()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkCreate_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x0003E0DC File Offset: 0x0003C2DC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237937, RefRangeEnd = 237938, XrefRangeStart = 237930, XrefRangeEnd = 237937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkLogin(string pLoginEmail, string pLoginPassword, string platformAccount)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(pLoginEmail);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pLoginPassword);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(platformAccount);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkLogin_Public_Static_Void_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BFE RID: 3070 RVA: 0x0003E138 File Offset: 0x0003C338
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237947, RefRangeEnd = 237948, XrefRangeStart = 237938, XrefRangeEnd = 237947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkCreateAccount(string pLoginEmail, string pLoginPassword, string pLoginUsername, string platformAccount)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(pLoginEmail);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pLoginPassword);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pLoginUsername);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(platformAccount);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkCreateAccount_Public_Static_Void_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BFF RID: 3071 RVA: 0x0003E1A4 File Offset: 0x0003C3A4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237953, RefRangeEnd = 237955, XrefRangeStart = 237948, XrefRangeEnd = 237953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkSetLoginPassword(string pLoginUsername, string pLoginPassword)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(pLoginUsername);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pLoginPassword);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkSetLoginPassword_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C00 RID: 3072 RVA: 0x0003E1EC File Offset: 0x0003C3EC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237962, RefRangeEnd = 237963, XrefRangeStart = 237955, XrefRangeEnd = 237962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkSetCreateAccount(string pLoginEmail, string pLoginPassword, string pLoginUsername)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(pLoginEmail);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pLoginPassword);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pLoginUsername);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkSetCreateAccount_Public_Static_Void_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C01 RID: 3073 RVA: 0x0003E248 File Offset: 0x0003C448
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237966, RefRangeEnd = 237967, XrefRangeStart = 237963, XrefRangeEnd = 237966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkConnect(string platformAccount)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(platformAccount);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkConnect_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C02 RID: 3074 RVA: 0x0003E280 File Offset: 0x0003C480
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237969, RefRangeEnd = 237970, XrefRangeStart = 237967, XrefRangeEnd = 237969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkUpdate(IntPtr pNetworkEvents, int maxEvents)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pNetworkEvents;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxEvents;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkUpdate_Public_Static_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C03 RID: 3075 RVA: 0x0003E2CC File Offset: 0x0003C4CC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237972, RefRangeEnd = 237974, XrefRangeStart = 237970, XrefRangeEnd = 237972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkDisconnect()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkDisconnect_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C04 RID: 3076 RVA: 0x0003E2F4 File Offset: 0x0003C4F4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237976, RefRangeEnd = 237977, XrefRangeStart = 237974, XrefRangeEnd = 237976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkDestroy()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkDestroy_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C05 RID: 3077 RVA: 0x0003E31C File Offset: 0x0003C51C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 237979, RefRangeEnd = 237982, XrefRangeStart = 237977, XrefRangeEnd = 237979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkResumeGame(int gameIndex)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gameIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkResumeGame_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C06 RID: 3078 RVA: 0x0003E350 File Offset: 0x0003C550
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237982, XrefRangeEnd = 237984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkGameFinished()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGameFinished_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C07 RID: 3079 RVA: 0x0003E378 File Offset: 0x0003C578
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237986, RefRangeEnd = 237987, XrefRangeStart = 237984, XrefRangeEnd = 237986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkGetActiveGames(IntPtr pGames, int maxGames)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pGames;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxGames;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetActiveGames_Public_Static_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C08 RID: 3080 RVA: 0x0003E3C4 File Offset: 0x0003C5C4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237989, RefRangeEnd = 237990, XrefRangeStart = 237987, XrefRangeEnd = 237989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkGetActiveGameWithID(IntPtr pGames, int maxGames, uint gameID)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pGames;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxGames;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gameID;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetActiveGameWithID_Public_Static_Int32_IntPtr_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C09 RID: 3081 RVA: 0x0003E420 File Offset: 0x0003C620
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237992, RefRangeEnd = 237993, XrefRangeStart = 237990, XrefRangeEnd = 237992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkGetCompletedGames(IntPtr pGames, int maxGames)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pGames;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxGames;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetCompletedGames_Public_Static_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C0A RID: 3082 RVA: 0x0003E46C File Offset: 0x0003C66C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237995, RefRangeEnd = 237996, XrefRangeStart = 237993, XrefRangeEnd = 237995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkGetGamePlayerTimers(uint gameID, IntPtr pTimers)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gameID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pTimers;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetGamePlayerTimers_Public_Static_Int32_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C0B RID: 3083 RVA: 0x0003E4B8 File Offset: 0x0003C6B8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237998, RefRangeEnd = 237999, XrefRangeStart = 237996, XrefRangeEnd = 237998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkRefreshAvailableGames()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkRefreshAvailableGames_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x0003E4E0 File Offset: 0x0003C6E0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238001, RefRangeEnd = 238002, XrefRangeStart = 237999, XrefRangeEnd = 238001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkGetAvailableGames(IntPtr pGames, int maxGames, uint filterPlayers, uint filterTime)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pGames;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxGames;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterPlayers;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filterTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetAvailableGames_Public_Static_Int32_IntPtr_Int32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C0D RID: 3085 RVA: 0x0003E548 File Offset: 0x0003C748
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238002, XrefRangeEnd = 238004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkJoinGame(int gameIndex)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gameIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkJoinGame_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C0E RID: 3086 RVA: 0x0003E57C File Offset: 0x0003C77C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238006, RefRangeEnd = 238007, XrefRangeStart = 238004, XrefRangeEnd = 238006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkCreateGame(uint maxPlayerCount, IntPtr invitationIds, uint startPlayerTime, IntPtr pGameParameters, int paramSize)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref maxPlayerCount;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invitationIds;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPlayerTime;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pGameParameters;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paramSize;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkCreateGame_Public_Static_Int32_UInt32_IntPtr_UInt32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C0F RID: 3087 RVA: 0x0003E5F4 File Offset: 0x0003C7F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238007, XrefRangeEnd = 238009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkSetNotifyDeviceId(IntPtr pId, int idLen)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pId;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idLen;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkSetNotifyDeviceId_Public_Static_Void_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C10 RID: 3088 RVA: 0x0003E634 File Offset: 0x0003C834
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238011, RefRangeEnd = 238012, XrefRangeStart = 238009, XrefRangeEnd = 238011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkSendLocalAvatarIndex(uint avatarIndex)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref avatarIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkSendLocalAvatarIndex_Public_Static_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C11 RID: 3089 RVA: 0x0003E668 File Offset: 0x0003C868
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238014, RefRangeEnd = 238015, XrefRangeStart = 238012, XrefRangeEnd = 238014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkGetFriendsList(IntPtr pFriendsBuffer, int maxFriends)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pFriendsBuffer;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxFriends;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetFriendsList_Public_Static_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C12 RID: 3090 RVA: 0x0003E6B4 File Offset: 0x0003C8B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238015, XrefRangeEnd = 238018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkAddFriendFromUserId(uint friendID, string accessToken)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref friendID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(accessToken);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkAddFriendFromUserId_Public_Static_Int32_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C13 RID: 3091 RVA: 0x0003E704 File Offset: 0x0003C904
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238023, RefRangeEnd = 238024, XrefRangeStart = 238018, XrefRangeEnd = 238023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkAddFriendFromUsername(string userName, string accessToken)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(userName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(accessToken);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkAddFriendFromUsername_Public_Static_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C14 RID: 3092 RVA: 0x0003E758 File Offset: 0x0003C958
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238027, RefRangeEnd = 238028, XrefRangeStart = 238024, XrefRangeEnd = 238027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkRemoveFriendWithUserId(uint exFriendID, string accessToken)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref exFriendID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(accessToken);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkRemoveFriendWithUserId_Public_Static_Int32_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C15 RID: 3093 RVA: 0x0003E7A8 File Offset: 0x0003C9A8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238033, RefRangeEnd = 238034, XrefRangeStart = 238028, XrefRangeEnd = 238033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkAddFriendFromEmail(string pEmail, string accessToken)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(pEmail);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(accessToken);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkAddFriendFromEmail_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C16 RID: 3094 RVA: 0x0003E7F0 File Offset: 0x0003C9F0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 238036, RefRangeEnd = 238039, XrefRangeStart = 238034, XrefRangeEnd = 238036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkGetUserOnlineStatus(uint userId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref userId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetUserOnlineStatus_Public_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000C17 RID: 3095 RVA: 0x0003E830 File Offset: 0x0003CA30
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238041, RefRangeEnd = 238042, XrefRangeStart = 238039, XrefRangeEnd = 238041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkRequestUsersOnlineStatus(IntPtr pUsers, int numUsers)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pUsers;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numUsers;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkRequestUsersOnlineStatus_Public_Static_Void_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C18 RID: 3096 RVA: 0x0003E870 File Offset: 0x0003CA70
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 238044, RefRangeEnd = 238048, XrefRangeStart = 238042, XrefRangeEnd = 238044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint NetworkGetLocalID()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetLocalID_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C19 RID: 3097 RVA: 0x0003E8A0 File Offset: 0x0003CAA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238048, XrefRangeEnd = 238050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint NetworkGetLocalAvatar()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetLocalAvatar_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C1A RID: 3098 RVA: 0x0003E8D0 File Offset: 0x0003CAD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238050, XrefRangeEnd = 238052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint NetworkGetLocalRating()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetLocalRating_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C1B RID: 3099 RVA: 0x0003E900 File Offset: 0x0003CB00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238052, XrefRangeEnd = 238054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr NetworkGetLocalName()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetLocalName_Public_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C1C RID: 3100 RVA: 0x0003E930 File Offset: 0x0003CB30
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238056, RefRangeEnd = 238057, XrefRangeStart = 238054, XrefRangeEnd = 238056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkRemotePlayerProfile(int userID, IntPtr c)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref userID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkRemotePlayerProfile_Public_Static_Void_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C1D RID: 3101 RVA: 0x0003E970 File Offset: 0x0003CB70
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238059, RefRangeEnd = 238060, XrefRangeStart = 238057, XrefRangeEnd = 238059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkLocalPlayerProfile(IntPtr c)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkLocalPlayerProfile_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C1E RID: 3102 RVA: 0x0003E9A4 File Offset: 0x0003CBA4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238062, RefRangeEnd = 238063, XrefRangeStart = 238060, XrefRangeEnd = 238062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkRequestPlayerProfile(uint userID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref userID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkRequestPlayerProfile_Public_Static_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C1F RID: 3103 RVA: 0x0003E9D8 File Offset: 0x0003CBD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238063, XrefRangeEnd = 238065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkGetGameFriends(IntPtr pFriendsBuffer, int maxFriends)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pFriendsBuffer;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxFriends;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetGameFriends_Public_Static_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C20 RID: 3104 RVA: 0x0003EA24 File Offset: 0x0003CC24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238065, XrefRangeEnd = 238067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkGetNumGameFriends()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetNumGameFriends_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C21 RID: 3105 RVA: 0x0003EA54 File Offset: 0x0003CC54
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238069, RefRangeEnd = 238070, XrefRangeStart = 238067, XrefRangeEnd = 238069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkForfeitGame(uint gameID, bool bLastPlayer)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gameID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bLastPlayer;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkForfeitGame_Public_Static_Int32_UInt32_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C22 RID: 3106 RVA: 0x0003EAA0 File Offset: 0x0003CCA0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238072, RefRangeEnd = 238073, XrefRangeStart = 238070, XrefRangeEnd = 238072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkSetMonitorGame(uint gameID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkSetMonitorGame_Public_Static_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C23 RID: 3107 RVA: 0x0003EAD4 File Offset: 0x0003CCD4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238075, RefRangeEnd = 238076, XrefRangeStart = 238073, XrefRangeEnd = 238075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkClearMonitorGame()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkClearMonitorGame_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x0003EAFC File Offset: 0x0003CCFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238076, XrefRangeEnd = 238078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkRequestGameMonitor(uint gameID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkRequestGameMonitor_Public_Static_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C25 RID: 3109 RVA: 0x0003EB30 File Offset: 0x0003CD30
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238080, RefRangeEnd = 238081, XrefRangeStart = 238078, XrefRangeEnd = 238080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkDeleteGame(uint gameID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkDeleteGame_Public_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000C26 RID: 3110 RVA: 0x0003EB70 File Offset: 0x0003CD70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238081, XrefRangeEnd = 238083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkWithdrawFromGame(uint gameID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkWithdrawFromGame_Public_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000C27 RID: 3111 RVA: 0x0003EBB0 File Offset: 0x0003CDB0
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 238085, RefRangeEnd = 238089, XrefRangeStart = 238083, XrefRangeEnd = 238085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkLaunchGame(uint gameID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkLaunchGame_Public_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000C28 RID: 3112 RVA: 0x0003EBF0 File Offset: 0x0003CDF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238089, XrefRangeEnd = 238091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkAcceptGameInvite(uint gameID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkAcceptGameInvite_Public_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000C29 RID: 3113 RVA: 0x0003EC30 File Offset: 0x0003CE30
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238093, RefRangeEnd = 238094, XrefRangeStart = 238091, XrefRangeEnd = 238093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint NetworkGetChatChannelMessageCount(uint channelID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref channelID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetChatChannelMessageCount_Public_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x0003EC70 File Offset: 0x0003CE70
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238096, RefRangeEnd = 238097, XrefRangeStart = 238094, XrefRangeEnd = 238096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint NetworkGetChatChannelMessageList(uint channelID, uint firstMessageIndex, uint maxMessageCount, IntPtr pData, int maxDataSize)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref channelID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstMessageIndex;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxMessageCount;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pData;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDataSize;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetChatChannelMessageList_Public_Static_UInt32_UInt32_UInt32_UInt32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x0003ECE8 File Offset: 0x0003CEE8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238099, RefRangeEnd = 238100, XrefRangeStart = 238097, XrefRangeEnd = 238099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkSubmitChatMessage(uint channelID, uint chatLength, Il2CppStructArray<byte> chatMessage)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref channelID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chatLength;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chatMessage);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkSubmitChatMessage_Public_Static_Void_UInt32_UInt32_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x0003ED3C File Offset: 0x0003CF3C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238102, RefRangeEnd = 238103, XrefRangeStart = 238100, XrefRangeEnd = 238102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkSubmitChatPosition(uint channelID, uint chatPositionIndex)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref channelID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chatPositionIndex;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkSubmitChatPosition_Public_Static_Void_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C2D RID: 3117 RVA: 0x0003ED7C File Offset: 0x0003CF7C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 238105, RefRangeEnd = 238107, XrefRangeStart = 238103, XrefRangeEnd = 238105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint NetworkGetChatPosition(uint channelID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref channelID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetChatPosition_Public_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000C2E RID: 3118 RVA: 0x0003EDBC File Offset: 0x0003CFBC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238109, RefRangeEnd = 238110, XrefRangeStart = 238107, XrefRangeEnd = 238109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint NetworkGetLastChatMessageIndex(uint channelID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref channelID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetLastChatMessageIndex_Public_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000C2F RID: 3119 RVA: 0x0003EDFC File Offset: 0x0003CFFC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 238112, RefRangeEnd = 238114, XrefRangeStart = 238110, XrefRangeEnd = 238112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkGetGameWaitingCount()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetGameWaitingCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C30 RID: 3120 RVA: 0x0003EE2C File Offset: 0x0003D02C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238116, RefRangeEnd = 238117, XrefRangeStart = 238114, XrefRangeEnd = 238116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint NetworkGetNextActiveGameID(uint allowedCardSetFlags, uint allowedPromoPackFlags)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref allowedCardSetFlags;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowedPromoPackFlags;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetNextActiveGameID_Public_Static_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C31 RID: 3121 RVA: 0x0003EE78 File Offset: 0x0003D078
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238119, RefRangeEnd = 238120, XrefRangeStart = 238117, XrefRangeEnd = 238119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkGetRematchGameData(uint gameID, IntPtr pBuffer, int bufLen)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gameID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pBuffer;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufLen;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetRematchGameData_Public_Static_Int32_UInt32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C32 RID: 3122 RVA: 0x0003EED4 File Offset: 0x0003D0D4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238122, RefRangeEnd = 238123, XrefRangeStart = 238120, XrefRangeEnd = 238122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NetworkRematchGame(uint gameID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkRematchGame_Public_Static_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C33 RID: 3123 RVA: 0x0003EF08 File Offset: 0x0003D108
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238123, XrefRangeEnd = 238125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkIsConnectedToServer()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkIsConnectedToServer_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C34 RID: 3124 RVA: 0x0003EF38 File Offset: 0x0003D138
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238127, RefRangeEnd = 238128, XrefRangeStart = 238125, XrefRangeEnd = 238127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkIsCreatingAccount()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkIsCreatingAccount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C35 RID: 3125 RVA: 0x0003EF68 File Offset: 0x0003D168
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 238130, RefRangeEnd = 238133, XrefRangeStart = 238128, XrefRangeEnd = 238130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkGetNotificationSetting(IntPtr pGameParameters, int index)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pGameParameters;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkGetNotificationSetting_Public_Static_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C36 RID: 3126 RVA: 0x0003EFB4 File Offset: 0x0003D1B4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238135, RefRangeEnd = 238136, XrefRangeStart = 238133, XrefRangeEnd = 238135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NetworkSetNotificationSetting(int index, bool bEnabled)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bEnabled;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr_NetworkSetNotificationSetting_Public_Static_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000C37 RID: 3127 RVA: 0x0003F000 File Offset: 0x0003D200
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionLib()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C38 RID: 3128 RVA: 0x0000920A File Offset: 0x0000740A
	public AscensionLib(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700040D RID: 1037
	// (get) Token: 0x06000C39 RID: 3129 RVA: 0x0003F03C File Offset: 0x0003D23C
	// (set) Token: 0x06000C3A RID: 3130 RVA: 0x00009213 File Offset: 0x00007413
	public unsafe static string DLL_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AscensionLib.NativeFieldInfoPtr_DLL_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionLib.NativeFieldInfoPtr_DLL_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x0400074C RID: 1868
	private static readonly IntPtr NativeFieldInfoPtr_DLL_NAME;

	// Token: 0x0400074D RID: 1869
	private static readonly IntPtr NativeMethodInfoPtr_SetGameOptionsListener_Public_Static_Void_GameOptionsListenerDelegate_0;

	// Token: 0x0400074E RID: 1870
	private static readonly IntPtr NativeMethodInfoPtr_SelectGameOption_Public_Static_Void_Int32_0;

	// Token: 0x0400074F RID: 1871
	private static readonly IntPtr NativeMethodInfoPtr_SelectGameOptionWithData_Public_Static_Void_Int32_UInt32_0;

	// Token: 0x04000750 RID: 1872
	private static readonly IntPtr NativeMethodInfoPtr_ResendGameOptionsList_Public_Static_Void_0;

	// Token: 0x04000751 RID: 1873
	private static readonly IntPtr NativeMethodInfoPtr_GetGameParameters_Public_Static_IntPtr_0;

	// Token: 0x04000752 RID: 1874
	private static readonly IntPtr NativeMethodInfoPtr_GetGamePlayerInfo_Public_Static_Int32_Int32_IntPtr_Int32_0;

	// Token: 0x04000753 RID: 1875
	private static readonly IntPtr NativeMethodInfoPtr_GetGamePlayerTimer_Public_Static_Int32_Int32_IntPtr_Int32_0;

	// Token: 0x04000754 RID: 1876
	private static readonly IntPtr NativeMethodInfoPtr_GetGamePlayerState_Public_Static_Int32_Int32_ptr_GamePlayerState_Int32_0;

	// Token: 0x04000755 RID: 1877
	private static readonly IntPtr NativeMethodInfoPtr_GetGamePlayerLogCount_Public_Static_Int32_Int32_UInt32_0;

	// Token: 0x04000756 RID: 1878
	private static readonly IntPtr NativeMethodInfoPtr_GetGamePlayerLog_Public_Static_Int32_Int32_UInt32_IntPtr_IntPtr_Int32_0;

	// Token: 0x04000757 RID: 1879
	private static readonly IntPtr NativeMethodInfoPtr_GetGamePlayerScoreState_Public_Static_Int32_Int32_IntPtr_Int32_0;

	// Token: 0x04000758 RID: 1880
	private static readonly IntPtr NativeMethodInfoPtr_GetGamePlayerPayResourcesState_Public_Static_Int32_Int32_IntPtr_Int32_0;

	// Token: 0x04000759 RID: 1881
	private static readonly IntPtr NativeMethodInfoPtr_GetGameAuctionInsightState_Public_Static_Int32_Int32_IntPtr_Int32_0;

	// Token: 0x0400075A RID: 1882
	private static readonly IntPtr NativeMethodInfoPtr_GetGamePlayerAIState_Public_Static_Int32_Int32_IntPtr_Int32_0;

	// Token: 0x0400075B RID: 1883
	private static readonly IntPtr NativeMethodInfoPtr_GetGameCardState_Public_Static_Int32_Int32_Il2CppStructArray_1_QueryCardState_Int32_0;

	// Token: 0x0400075C RID: 1884
	private static readonly IntPtr NativeMethodInfoPtr_GetKingdomStackList_Public_Static_Int32_IntPtr_Int32_0;

	// Token: 0x0400075D RID: 1885
	private static readonly IntPtr NativeMethodInfoPtr_GetNextCenterRowMagnifyScroll_Public_Static_Int32_Int32_Boolean_0;

	// Token: 0x0400075E RID: 1886
	private static readonly IntPtr NativeMethodInfoPtr_GetWinnerID_Public_Static_Int32_0;

	// Token: 0x0400075F RID: 1887
	private static readonly IntPtr NativeMethodInfoPtr_GetNonTrophyHintCount_Public_Static_Int32_0;

	// Token: 0x04000760 RID: 1888
	private static readonly IntPtr NativeMethodInfoPtr_GetCanUseTempleOfImmortalityForThisCard_Public_Static_UInt32_UInt32_UInt32_0;

	// Token: 0x04000761 RID: 1889
	private static readonly IntPtr NativeMethodInfoPtr_GetHasBetterUsableHint_Public_Static_Int32_UInt32_UInt32_0;

	// Token: 0x04000762 RID: 1890
	private static readonly IntPtr NativeMethodInfoPtr_GetHasSelectableDreamscapeCard_Public_Static_Int32_0;

	// Token: 0x04000763 RID: 1891
	private static readonly IntPtr NativeMethodInfoPtr_GetHasSelectableUniqueZoneCard_Public_Static_Int32_0;

	// Token: 0x04000764 RID: 1892
	private static readonly IntPtr NativeMethodInfoPtr_GetCardTransformName_Public_Static_Int32_Int32_IntPtr_Int32_0;

	// Token: 0x04000765 RID: 1893
	private static readonly IntPtr NativeMethodInfoPtr_GetCenterRowCardType_Public_Static_Int32_Int32_Int32_0;

	// Token: 0x04000766 RID: 1894
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayedCardPositionIndex_Public_Static_Int32_Int32_0;

	// Token: 0x04000767 RID: 1895
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayedCardEntryList_Public_Static_Int32_IntPtr_Int32_0;

	// Token: 0x04000768 RID: 1896
	private static readonly IntPtr NativeMethodInfoPtr_GetResolveCardPositionIndex_Public_Static_Int32_Int32_0;

	// Token: 0x04000769 RID: 1897
	private static readonly IntPtr NativeMethodInfoPtr_GetResolveCardEntryList_Public_Static_Int32_IntPtr_Int32_0;

	// Token: 0x0400076A RID: 1898
	private static readonly IntPtr NativeMethodInfoPtr_GetInstanceID_Public_Static_Int32_Int32_String_0;

	// Token: 0x0400076B RID: 1899
	private static readonly IntPtr NativeMethodInfoPtr_GetInstanceList_Public_Static_Int32_Int32_Int32_IntPtr_Int32_0;

	// Token: 0x0400076C RID: 1900
	private static readonly IntPtr NativeMethodInfoPtr_GetInstanceData_Public_Static_Int32_Int32_Int32_IntPtr_Int32_0;

	// Token: 0x0400076D RID: 1901
	private static readonly IntPtr NativeMethodInfoPtr_GetCardDataByName_Public_Static_Int32_String_IntPtr_Int32_0;

	// Token: 0x0400076E RID: 1902
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_String_Int32_0;

	// Token: 0x0400076F RID: 1903
	private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Public_Static_Void_0;

	// Token: 0x04000770 RID: 1904
	private static readonly IntPtr NativeMethodInfoPtr_StartGame_Public_Static_Void_IntPtr_Int32_Il2CppReferenceArray_1_AppPlayerData_UInt32_Boolean_0;

	// Token: 0x04000771 RID: 1905
	private static readonly IntPtr NativeMethodInfoPtr_StartTutorial_Public_Static_Void_IntPtr_Int32_Il2CppReferenceArray_1_AppPlayerData_Int32_UInt32_Int32_Il2CppStructArray_1_TutorialAIStep_Int32_Il2CppStructArray_1_TutorialAIStep_Int32_Il2CppStructArray_1_Byte_0;

	// Token: 0x04000772 RID: 1906
	private static readonly IntPtr NativeMethodInfoPtr_SetTutorialSyncAIOptions_Public_Static_Void_0;

	// Token: 0x04000773 RID: 1907
	private static readonly IntPtr NativeMethodInfoPtr_ResumeGame_Public_Static_Void_IntPtr_Int32_Int32_0;

	// Token: 0x04000774 RID: 1908
	private static readonly IntPtr NativeMethodInfoPtr_ExitCurrentGame_Public_Static_Void_0;

	// Token: 0x04000775 RID: 1909
	private static readonly IntPtr NativeMethodInfoPtr_UpdateGame_Public_Static_Int32_IntPtr_Int32_0;

	// Token: 0x04000776 RID: 1910
	private static readonly IntPtr NativeMethodInfoPtr_ForceUpdateStateMachineInput_Public_Static_Int32_IntPtr_Int32_0;

	// Token: 0x04000777 RID: 1911
	private static readonly IntPtr NativeMethodInfoPtr_HasTemporaryMoveBuffer_Public_Static_Int32_0;

	// Token: 0x04000778 RID: 1912
	private static readonly IntPtr NativeMethodInfoPtr_CommitTemporaryMoveBuffer_Public_Static_Void_0;

	// Token: 0x04000779 RID: 1913
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentGameID_Public_Static_UInt32_0;

	// Token: 0x0400077A RID: 1914
	private static readonly IntPtr NativeMethodInfoPtr_GetGamePlayerCount_Public_Static_Int32_0;

	// Token: 0x0400077B RID: 1915
	private static readonly IntPtr NativeMethodInfoPtr_GetGamePlayerAICount_Public_Static_Int32_0;

	// Token: 0x0400077C RID: 1916
	private static readonly IntPtr NativeMethodInfoPtr_GetGameRoundNumber_Public_Static_Int32_0;

	// Token: 0x0400077D RID: 1917
	private static readonly IntPtr NativeMethodInfoPtr_GetGameCompleted_Public_Static_Int32_0;

	// Token: 0x0400077E RID: 1918
	private static readonly IntPtr NativeMethodInfoPtr_GetLocalPlayerIndex_Public_Static_Int32_0;

	// Token: 0x0400077F RID: 1919
	private static readonly IntPtr NativeMethodInfoPtr_GetLocalPlayerInstanceID_Public_Static_Int32_0;

	// Token: 0x04000780 RID: 1920
	private static readonly IntPtr NativeMethodInfoPtr_GetLocalOpponentPlayerIndex_Public_Static_Int32_Int32_0;

	// Token: 0x04000781 RID: 1921
	private static readonly IntPtr NativeMethodInfoPtr_GetLocalOpponentInstanceID_Public_Static_Int32_Int32_0;

	// Token: 0x04000782 RID: 1922
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayerIndexByTurnOrder_Public_Static_Int32_Int32_0;

	// Token: 0x04000783 RID: 1923
	private static readonly IntPtr NativeMethodInfoPtr_GetCardInPlayExtraData_Public_Static_Int32_Int32_0;

	// Token: 0x04000784 RID: 1924
	private static readonly IntPtr NativeMethodInfoPtr_GetIsOnlineGame_Public_Static_Int32_0;

	// Token: 0x04000785 RID: 1925
	private static readonly IntPtr NativeMethodInfoPtr_GetIsTutorialGame_Public_Static_Int32_0;

	// Token: 0x04000786 RID: 1926
	private static readonly IntPtr NativeMethodInfoPtr_GetIsHotseatGame_Public_Static_Int32_0;

	// Token: 0x04000787 RID: 1927
	private static readonly IntPtr NativeMethodInfoPtr_GetNewLocalPlayerID_Public_Static_Int32_0;

	// Token: 0x04000788 RID: 1928
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentGameMoveCount_Public_Static_UInt32_0;

	// Token: 0x04000789 RID: 1929
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentGameNextMoveIndex_Public_Static_UInt32_0;

	// Token: 0x0400078A RID: 1930
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentGameNetworkConfirmCount_Public_Static_UInt32_0;

	// Token: 0x0400078B RID: 1931
	private static readonly IntPtr NativeMethodInfoPtr_SetGameSpeed_Public_Static_Void_Int32_0;

	// Token: 0x0400078C RID: 1932
	private static readonly IntPtr NativeMethodInfoPtr_AttemptToLoadOldSaveData_Public_Static_Int32_Int32_0;

	// Token: 0x0400078D RID: 1933
	private static readonly IntPtr NativeMethodInfoPtr_AttemptToLoadOldProfileData_Public_Static_Int32_IntPtr_Int32_0;

	// Token: 0x0400078E RID: 1934
	private static readonly IntPtr NativeMethodInfoPtr_SetSaveDataFunc_Public_Static_Void_SaveWorldDataDelegate_0;

	// Token: 0x0400078F RID: 1935
	private static readonly IntPtr NativeMethodInfoPtr_NetworkCreate_Public_Static_Void_0;

	// Token: 0x04000790 RID: 1936
	private static readonly IntPtr NativeMethodInfoPtr_NetworkLogin_Public_Static_Void_String_String_String_0;

	// Token: 0x04000791 RID: 1937
	private static readonly IntPtr NativeMethodInfoPtr_NetworkCreateAccount_Public_Static_Void_String_String_String_String_0;

	// Token: 0x04000792 RID: 1938
	private static readonly IntPtr NativeMethodInfoPtr_NetworkSetLoginPassword_Public_Static_Void_String_String_0;

	// Token: 0x04000793 RID: 1939
	private static readonly IntPtr NativeMethodInfoPtr_NetworkSetCreateAccount_Public_Static_Void_String_String_String_0;

	// Token: 0x04000794 RID: 1940
	private static readonly IntPtr NativeMethodInfoPtr_NetworkConnect_Public_Static_Void_String_0;

	// Token: 0x04000795 RID: 1941
	private static readonly IntPtr NativeMethodInfoPtr_NetworkUpdate_Public_Static_Int32_IntPtr_Int32_0;

	// Token: 0x04000796 RID: 1942
	private static readonly IntPtr NativeMethodInfoPtr_NetworkDisconnect_Public_Static_Void_0;

	// Token: 0x04000797 RID: 1943
	private static readonly IntPtr NativeMethodInfoPtr_NetworkDestroy_Public_Static_Void_0;

	// Token: 0x04000798 RID: 1944
	private static readonly IntPtr NativeMethodInfoPtr_NetworkResumeGame_Public_Static_Void_Int32_0;

	// Token: 0x04000799 RID: 1945
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGameFinished_Public_Static_Void_0;

	// Token: 0x0400079A RID: 1946
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetActiveGames_Public_Static_Int32_IntPtr_Int32_0;

	// Token: 0x0400079B RID: 1947
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetActiveGameWithID_Public_Static_Int32_IntPtr_Int32_UInt32_0;

	// Token: 0x0400079C RID: 1948
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetCompletedGames_Public_Static_Int32_IntPtr_Int32_0;

	// Token: 0x0400079D RID: 1949
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetGamePlayerTimers_Public_Static_Int32_UInt32_IntPtr_0;

	// Token: 0x0400079E RID: 1950
	private static readonly IntPtr NativeMethodInfoPtr_NetworkRefreshAvailableGames_Public_Static_Void_0;

	// Token: 0x0400079F RID: 1951
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetAvailableGames_Public_Static_Int32_IntPtr_Int32_UInt32_UInt32_0;

	// Token: 0x040007A0 RID: 1952
	private static readonly IntPtr NativeMethodInfoPtr_NetworkJoinGame_Public_Static_Void_Int32_0;

	// Token: 0x040007A1 RID: 1953
	private static readonly IntPtr NativeMethodInfoPtr_NetworkCreateGame_Public_Static_Int32_UInt32_IntPtr_UInt32_IntPtr_Int32_0;

	// Token: 0x040007A2 RID: 1954
	private static readonly IntPtr NativeMethodInfoPtr_NetworkSetNotifyDeviceId_Public_Static_Void_IntPtr_Int32_0;

	// Token: 0x040007A3 RID: 1955
	private static readonly IntPtr NativeMethodInfoPtr_NetworkSendLocalAvatarIndex_Public_Static_Void_UInt32_0;

	// Token: 0x040007A4 RID: 1956
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetFriendsList_Public_Static_Int32_IntPtr_Int32_0;

	// Token: 0x040007A5 RID: 1957
	private static readonly IntPtr NativeMethodInfoPtr_NetworkAddFriendFromUserId_Public_Static_Int32_UInt32_String_0;

	// Token: 0x040007A6 RID: 1958
	private static readonly IntPtr NativeMethodInfoPtr_NetworkAddFriendFromUsername_Public_Static_Int32_String_String_0;

	// Token: 0x040007A7 RID: 1959
	private static readonly IntPtr NativeMethodInfoPtr_NetworkRemoveFriendWithUserId_Public_Static_Int32_UInt32_String_0;

	// Token: 0x040007A8 RID: 1960
	private static readonly IntPtr NativeMethodInfoPtr_NetworkAddFriendFromEmail_Public_Static_Void_String_String_0;

	// Token: 0x040007A9 RID: 1961
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetUserOnlineStatus_Public_Static_Int32_UInt32_0;

	// Token: 0x040007AA RID: 1962
	private static readonly IntPtr NativeMethodInfoPtr_NetworkRequestUsersOnlineStatus_Public_Static_Void_IntPtr_Int32_0;

	// Token: 0x040007AB RID: 1963
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetLocalID_Public_Static_UInt32_0;

	// Token: 0x040007AC RID: 1964
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetLocalAvatar_Public_Static_UInt32_0;

	// Token: 0x040007AD RID: 1965
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetLocalRating_Public_Static_UInt32_0;

	// Token: 0x040007AE RID: 1966
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetLocalName_Public_Static_IntPtr_0;

	// Token: 0x040007AF RID: 1967
	private static readonly IntPtr NativeMethodInfoPtr_NetworkRemotePlayerProfile_Public_Static_Void_Int32_IntPtr_0;

	// Token: 0x040007B0 RID: 1968
	private static readonly IntPtr NativeMethodInfoPtr_NetworkLocalPlayerProfile_Public_Static_Void_IntPtr_0;

	// Token: 0x040007B1 RID: 1969
	private static readonly IntPtr NativeMethodInfoPtr_NetworkRequestPlayerProfile_Public_Static_Void_UInt32_0;

	// Token: 0x040007B2 RID: 1970
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetGameFriends_Public_Static_Int32_IntPtr_Int32_0;

	// Token: 0x040007B3 RID: 1971
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetNumGameFriends_Public_Static_Int32_0;

	// Token: 0x040007B4 RID: 1972
	private static readonly IntPtr NativeMethodInfoPtr_NetworkForfeitGame_Public_Static_Int32_UInt32_Boolean_0;

	// Token: 0x040007B5 RID: 1973
	private static readonly IntPtr NativeMethodInfoPtr_NetworkSetMonitorGame_Public_Static_Void_UInt32_0;

	// Token: 0x040007B6 RID: 1974
	private static readonly IntPtr NativeMethodInfoPtr_NetworkClearMonitorGame_Public_Static_Void_0;

	// Token: 0x040007B7 RID: 1975
	private static readonly IntPtr NativeMethodInfoPtr_NetworkRequestGameMonitor_Public_Static_Void_UInt32_0;

	// Token: 0x040007B8 RID: 1976
	private static readonly IntPtr NativeMethodInfoPtr_NetworkDeleteGame_Public_Static_Int32_UInt32_0;

	// Token: 0x040007B9 RID: 1977
	private static readonly IntPtr NativeMethodInfoPtr_NetworkWithdrawFromGame_Public_Static_Int32_UInt32_0;

	// Token: 0x040007BA RID: 1978
	private static readonly IntPtr NativeMethodInfoPtr_NetworkLaunchGame_Public_Static_Int32_UInt32_0;

	// Token: 0x040007BB RID: 1979
	private static readonly IntPtr NativeMethodInfoPtr_NetworkAcceptGameInvite_Public_Static_Int32_UInt32_0;

	// Token: 0x040007BC RID: 1980
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetChatChannelMessageCount_Public_Static_UInt32_UInt32_0;

	// Token: 0x040007BD RID: 1981
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetChatChannelMessageList_Public_Static_UInt32_UInt32_UInt32_UInt32_IntPtr_Int32_0;

	// Token: 0x040007BE RID: 1982
	private static readonly IntPtr NativeMethodInfoPtr_NetworkSubmitChatMessage_Public_Static_Void_UInt32_UInt32_Il2CppStructArray_1_Byte_0;

	// Token: 0x040007BF RID: 1983
	private static readonly IntPtr NativeMethodInfoPtr_NetworkSubmitChatPosition_Public_Static_Void_UInt32_UInt32_0;

	// Token: 0x040007C0 RID: 1984
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetChatPosition_Public_Static_UInt32_UInt32_0;

	// Token: 0x040007C1 RID: 1985
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetLastChatMessageIndex_Public_Static_UInt32_UInt32_0;

	// Token: 0x040007C2 RID: 1986
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetGameWaitingCount_Public_Static_Int32_0;

	// Token: 0x040007C3 RID: 1987
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetNextActiveGameID_Public_Static_UInt32_UInt32_UInt32_0;

	// Token: 0x040007C4 RID: 1988
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetRematchGameData_Public_Static_Int32_UInt32_IntPtr_Int32_0;

	// Token: 0x040007C5 RID: 1989
	private static readonly IntPtr NativeMethodInfoPtr_NetworkRematchGame_Public_Static_Void_UInt32_0;

	// Token: 0x040007C6 RID: 1990
	private static readonly IntPtr NativeMethodInfoPtr_NetworkIsConnectedToServer_Public_Static_Int32_0;

	// Token: 0x040007C7 RID: 1991
	private static readonly IntPtr NativeMethodInfoPtr_NetworkIsCreatingAccount_Public_Static_Int32_0;

	// Token: 0x040007C8 RID: 1992
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetNotificationSetting_Public_Static_Int32_IntPtr_Int32_0;

	// Token: 0x040007C9 RID: 1993
	private static readonly IntPtr NativeMethodInfoPtr_NetworkSetNotificationSetting_Public_Static_Int32_Int32_Boolean_0;

	// Token: 0x040007CA RID: 1994
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000182 RID: 386
	public sealed class GameOptionsListenerDelegate : MulticastDelegate
	{
		// Token: 0x060023ED RID: 9197 RVA: 0x00085FDC File Offset: 0x000841DC
		// Note: this type is marked as 'beforefieldinit'.
		static GameOptionsListenerDelegate()
		{
			Il2CppClassPointerStore<AscensionLib.GameOptionsListenerDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, "GameOptionsListenerDelegate");
			AscensionLib.GameOptionsListenerDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib.GameOptionsListenerDelegate>.NativeClassPtr, 100666148);
			AscensionLib.GameOptionsListenerDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib.GameOptionsListenerDelegate>.NativeClassPtr, 100666149);
			AscensionLib.GameOptionsListenerDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_IntPtr_Int32_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib.GameOptionsListenerDelegate>.NativeClassPtr, 100666150);
			AscensionLib.GameOptionsListenerDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib.GameOptionsListenerDelegate>.NativeClassPtr, 100666151);
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x00086050 File Offset: 0x00084250
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameOptionsListenerDelegate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionLib.GameOptionsListenerDelegate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.GameOptionsListenerDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x000860AC File Offset: 0x000842AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237601, XrefRangeEnd = 237605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(int playerID, IntPtr pOptionPrompt, int numOptions, IntPtr pOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pOptionPrompt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numOptions;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.GameOptionsListenerDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_IntPtr_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x00086114 File Offset: 0x00084314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237605, XrefRangeEnd = 237616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(int playerID, IntPtr pOptionPrompt, int numOptions, IntPtr pOptions, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pOptionPrompt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numOptions;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.GameOptionsListenerDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_IntPtr_Int32_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x000861B0 File Offset: 0x000843B0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.GameOptionsListenerDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x000166AC File Offset: 0x000148AC
		public GameOptionsListenerDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x000166B5 File Offset: 0x000148B5
		public static implicit operator AscensionLib.GameOptionsListenerDelegate(Action<int, IntPtr, int, IntPtr> A_0)
		{
			return DelegateSupport.ConvertDelegate<AscensionLib.GameOptionsListenerDelegate>(A_0);
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x000166BD File Offset: 0x000148BD
		public static AscensionLib.GameOptionsListenerDelegate operator +(AscensionLib.GameOptionsListenerDelegate A_0, AscensionLib.GameOptionsListenerDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AscensionLib.GameOptionsListenerDelegate>();
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x000166CB File Offset: 0x000148CB
		public static AscensionLib.GameOptionsListenerDelegate operator -(AscensionLib.GameOptionsListenerDelegate A_0, AscensionLib.GameOptionsListenerDelegate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AscensionLib.GameOptionsListenerDelegate>();
			}
			return delegate2;
		}

		// Token: 0x040018D9 RID: 6361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040018DA RID: 6362
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_IntPtr_Int32_IntPtr_0;

		// Token: 0x040018DB RID: 6363
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_IntPtr_Int32_IntPtr_AsyncCallback_Object_0;

		// Token: 0x040018DC RID: 6364
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x02000183 RID: 387
	public sealed class SaveWorldDataDelegate : MulticastDelegate
	{
		// Token: 0x060023F6 RID: 9206 RVA: 0x000861F4 File Offset: 0x000843F4
		// Note: this type is marked as 'beforefieldinit'.
		static SaveWorldDataDelegate()
		{
			Il2CppClassPointerStore<AscensionLib.SaveWorldDataDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionLib>.NativeClassPtr, "SaveWorldDataDelegate");
			AscensionLib.SaveWorldDataDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib.SaveWorldDataDelegate>.NativeClassPtr, 100666152);
			AscensionLib.SaveWorldDataDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib.SaveWorldDataDelegate>.NativeClassPtr, 100666153);
			AscensionLib.SaveWorldDataDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib.SaveWorldDataDelegate>.NativeClassPtr, 100666154);
			AscensionLib.SaveWorldDataDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLib.SaveWorldDataDelegate>.NativeClassPtr, 100666155);
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x00086268 File Offset: 0x00084468
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveWorldDataDelegate(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionLib.SaveWorldDataDelegate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.SaveWorldDataDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x000862C4 File Offset: 0x000844C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237616, XrefRangeEnd = 237620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(IntPtr pSaveData, int size, IntPtr pShortSave)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pSaveData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pShortSave;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.SaveWorldDataDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x00086320 File Offset: 0x00084520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237620, XrefRangeEnd = 237629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(IntPtr pSaveData, int size, IntPtr pShortSave, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pSaveData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pShortSave;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.SaveWorldDataDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x000863B0 File Offset: 0x000845B0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLib.SaveWorldDataDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x000166DC File Offset: 0x000148DC
		public SaveWorldDataDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x000166E5 File Offset: 0x000148E5
		public static implicit operator AscensionLib.SaveWorldDataDelegate(Action<IntPtr, int, IntPtr> A_0)
		{
			return DelegateSupport.ConvertDelegate<AscensionLib.SaveWorldDataDelegate>(A_0);
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x000166ED File Offset: 0x000148ED
		public static AscensionLib.SaveWorldDataDelegate operator +(AscensionLib.SaveWorldDataDelegate A_0, AscensionLib.SaveWorldDataDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AscensionLib.SaveWorldDataDelegate>();
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x000166FB File Offset: 0x000148FB
		public static AscensionLib.SaveWorldDataDelegate operator -(AscensionLib.SaveWorldDataDelegate A_0, AscensionLib.SaveWorldDataDelegate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AscensionLib.SaveWorldDataDelegate>();
			}
			return delegate2;
		}

		// Token: 0x040018DD RID: 6365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040018DE RID: 6366
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int32_IntPtr_0;

		// Token: 0x040018DF RID: 6367
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_IntPtr_AsyncCallback_Object_0;

		// Token: 0x040018E0 RID: 6368
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}

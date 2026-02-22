using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000B6 RID: 182
public class UIP_GameSlot : MonoBehaviour
{
	// Token: 0x0600158E RID: 5518 RVA: 0x0005B5B0 File Offset: 0x000597B0
	// Note: this type is marked as 'beforefieldinit'.
	static UIP_GameSlot()
	{
		Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIP_GameSlot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr);
		UIP_GameSlot.NativeFieldInfoPtr_m_baseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_baseButton");
		UIP_GameSlot.NativeFieldInfoPtr_m_playerInfoGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_playerInfoGameObjects");
		UIP_GameSlot.NativeFieldInfoPtr_m_OnlineStatusIndicatorPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_OnlineStatusIndicatorPrefab");
		UIP_GameSlot.NativeFieldInfoPtr_m_honorRemainingObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_honorRemainingObj");
		UIP_GameSlot.NativeFieldInfoPtr_m_honorRemainingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_honorRemainingText");
		UIP_GameSlot.NativeFieldInfoPtr_m_timerObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_timerObj");
		UIP_GameSlot.NativeFieldInfoPtr_m_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_timer");
		UIP_GameSlot.NativeFieldInfoPtr_m_roundText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_roundText");
		UIP_GameSlot.NativeFieldInfoPtr_m_forfeitTextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_forfeitTextColor");
		UIP_GameSlot.NativeFieldInfoPtr_m_localPlayerActiveTurnColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_localPlayerActiveTurnColor");
		UIP_GameSlot.NativeFieldInfoPtr_m_nonLocalPlayerActiveTurnColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_nonLocalPlayerActiveTurnColor");
		UIP_GameSlot.NativeFieldInfoPtr_m_waitingOnInviteColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_waitingOnInviteColor");
		UIP_GameSlot.NativeFieldInfoPtr_m_setIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_setIcons");
		UIP_GameSlot.NativeFieldInfoPtr_m_promoIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_promoIcons");
		UIP_GameSlot.NativeFieldInfoPtr_m_OnlineStatusImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_OnlineStatusImages");
		UIP_GameSlot.NativeFieldInfoPtr_m_newChatIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_newChatIcon");
		UIP_GameSlot.NativeFieldInfoPtr_m_deleteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_deleteButton");
		UIP_GameSlot.NativeFieldInfoPtr_m_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_RectTransform");
		UIP_GameSlot.NativeFieldInfoPtr_m_colorizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_colorizer");
		UIP_GameSlot.NativeFieldInfoPtr_m_colorizerDeleteColorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_colorizerDeleteColorIndex");
		UIP_GameSlot.NativeFieldInfoPtr_m_network = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_network");
		UIP_GameSlot.NativeFieldInfoPtr_m_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_callback");
		UIP_GameSlot.NativeFieldInfoPtr_m_matchmakingTimerCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_matchmakingTimerCoroutine");
		UIP_GameSlot.NativeFieldInfoPtr_m_save_struct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_save_struct");
		UIP_GameSlot.NativeFieldInfoPtr_m_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_type");
		UIP_GameSlot.NativeFieldInfoPtr_m_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_state");
		UIP_GameSlot.NativeFieldInfoPtr_m_savePathShort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_savePathShort");
		UIP_GameSlot.NativeFieldInfoPtr_m_savePathFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_savePathFull");
		UIP_GameSlot.NativeFieldInfoPtr_m_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_GameID");
		UIP_GameSlot.NativeFieldInfoPtr_m_gameSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_gameSlotIndex");
		UIP_GameSlot.NativeFieldInfoPtr_m_colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_colors");
		UIP_GameSlot.NativeFieldInfoPtr_m_saveDataSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_saveDataSize");
		UIP_GameSlot.NativeFieldInfoPtr_m_worldDataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_worldDataVersion");
		UIP_GameSlot.NativeFieldInfoPtr_m_numPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_numPlayers");
		UIP_GameSlot.NativeFieldInfoPtr_bLocalPlayerForfeited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "bLocalPlayerForfeited");
		UIP_GameSlot.NativeFieldInfoPtr_m_playerIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_playerIDs");
		UIP_GameSlot.NativeFieldInfoPtr_m_localPlayerGameObjectsIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_localPlayerGameObjectsIndex");
		UIP_GameSlot.NativeFieldInfoPtr_m_matchmakingOpponentGameObjectIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_matchmakingOpponentGameObjectIndex");
		UIP_GameSlot.NativeFieldInfoPtr_m_matchmakingRatingDifference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_matchmakingRatingDifference");
		UIP_GameSlot.NativeFieldInfoPtr_m_matchmakingExpireTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_matchmakingExpireTime");
		UIP_GameSlot.NativeFieldInfoPtr_m_matchmakingExpireTimeRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_matchmakingExpireTimeRemaining");
		UIP_GameSlot.NativeFieldInfoPtr_m_localPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_localPlayerID");
		UIP_GameSlot.NativeFieldInfoPtr_m_defaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_defaultColor");
		UIP_GameSlot.NativeFieldInfoPtr_m_bDeleteMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_bDeleteMode");
		UIP_GameSlot.NativeFieldInfoPtr_m_bOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_bOwner");
		UIP_GameSlot.NativeFieldInfoPtr_m_bReadyToStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_bReadyToStart");
		UIP_GameSlot.NativeFieldInfoPtr_m_bInvited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_bInvited");
		UIP_GameSlot.NativeFieldInfoPtr_m_bDisplayPlayerTimers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_bDisplayPlayerTimers");
		UIP_GameSlot.NativeFieldInfoPtr_m_bNeedsOnlineStatusUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_bNeedsOnlineStatusUpdate");
		UIP_GameSlot.NativeFieldInfoPtr_m_bNetworkInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "m_bNetworkInitialized");
		UIP_GameSlot.NativeMethodInfoPtr_GetNumPlayers_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665029);
		UIP_GameSlot.NativeMethodInfoPtr_NeedsOnlineStatusUpdate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665030);
		UIP_GameSlot.NativeMethodInfoPtr_SetAllRequestsProcessed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665031);
		UIP_GameSlot.NativeMethodInfoPtr_GetOnlineStatusUpdateUserId_Public_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665032);
		UIP_GameSlot.NativeMethodInfoPtr_GetLocalPlayerForfeited_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665033);
		UIP_GameSlot.NativeMethodInfoPtr_GetShortSavePath_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665034);
		UIP_GameSlot.NativeMethodInfoPtr_SetShortSavePath_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665035);
		UIP_GameSlot.NativeMethodInfoPtr_GetFullSavePath_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665036);
		UIP_GameSlot.NativeMethodInfoPtr_SetFullSavePath_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665037);
		UIP_GameSlot.NativeMethodInfoPtr_GetSlotIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665038);
		UIP_GameSlot.NativeMethodInfoPtr_SetSlotIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665039);
		UIP_GameSlot.NativeMethodInfoPtr_GetDataSize_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665040);
		UIP_GameSlot.NativeMethodInfoPtr_GetDataVersion_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665041);
		UIP_GameSlot.NativeMethodInfoPtr_GetNetworkGameID_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665042);
		UIP_GameSlot.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665043);
		UIP_GameSlot.NativeMethodInfoPtr_IsVisible_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665044);
		UIP_GameSlot.NativeMethodInfoPtr_InitializeNetwork_Public_Void_Network_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665045);
		UIP_GameSlot.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665046);
		UIP_GameSlot.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665047);
		UIP_GameSlot.NativeMethodInfoPtr_NetworkEventCallback_Private_Void_EventType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665048);
		UIP_GameSlot.NativeMethodInfoPtr_SetClickListener_Public_Void_ClickCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665049);
		UIP_GameSlot.NativeMethodInfoPtr_OnPressSlot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665050);
		UIP_GameSlot.NativeMethodInfoPtr_OnPressDelete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665051);
		UIP_GameSlot.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665052);
		UIP_GameSlot.NativeMethodInfoPtr_GetGameSlotData_Public_ShortSaveStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665053);
		UIP_GameSlot.NativeMethodInfoPtr_HideDeleteButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665054);
		UIP_GameSlot.NativeMethodInfoPtr_SetData_Public_Void_ShortSaveStruct_ESlotType_InAppPurchaseWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665055);
		UIP_GameSlot.NativeMethodInfoPtr_TurnOnDeleteMode_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665056);
		UIP_GameSlot.NativeMethodInfoPtr_TurnOnSelectedMode_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665057);
		UIP_GameSlot.NativeMethodInfoPtr_UpdateTurnText_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665058);
		UIP_GameSlot.NativeMethodInfoPtr_UpdateStatusText_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665059);
		UIP_GameSlot.NativeMethodInfoPtr_GetIsHostOnline_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665060);
		UIP_GameSlot.NativeMethodInfoPtr_OnlineStatusIndicatorsSetActive_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665061);
		UIP_GameSlot.NativeMethodInfoPtr_UpdatePlayerOnlineStatus_Private_Void_Int32_PlayerOnlineStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665062);
		UIP_GameSlot.NativeMethodInfoPtr_UpdatePlayerTimers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665063);
		UIP_GameSlot.NativeMethodInfoPtr_UpdateMatchmakingTimer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665064);
		UIP_GameSlot.NativeMethodInfoPtr_ProcessMatchmakingExpireTimer_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665065);
		UIP_GameSlot.NativeMethodInfoPtr_GetTimeStringFromSeconds_Private_String_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665066);
		UIP_GameSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, 100665067);
	}

	// Token: 0x0600158F RID: 5519 RVA: 0x0005BCD4 File Offset: 0x00059ED4
	[CallerCount(0)]
	public unsafe int GetNumPlayers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_GetNumPlayers_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001590 RID: 5520 RVA: 0x0005BD10 File Offset: 0x00059F10
	[CallerCount(0)]
	public unsafe bool NeedsOnlineStatusUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_NeedsOnlineStatusUpdate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001591 RID: 5521 RVA: 0x0005BD4C File Offset: 0x00059F4C
	[CallerCount(0)]
	public unsafe void SetAllRequestsProcessed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_SetAllRequestsProcessed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001592 RID: 5522 RVA: 0x0005BD80 File Offset: 0x00059F80
	[CallerCount(0)]
	public unsafe Il2CppStructArray<int> GetOnlineStatusUpdateUserId()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_GetOnlineStatusUpdateUserId_Public_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
	}

	// Token: 0x06001593 RID: 5523 RVA: 0x0005BDC0 File Offset: 0x00059FC0
	[CallerCount(0)]
	public unsafe bool GetLocalPlayerForfeited()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_GetLocalPlayerForfeited_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001594 RID: 5524 RVA: 0x0005BDFC File Offset: 0x00059FFC
	[CallerCount(0)]
	public unsafe string GetShortSavePath()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_GetShortSavePath_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06001595 RID: 5525 RVA: 0x0005BE34 File Offset: 0x0005A034
	[CallerCount(0)]
	public unsafe void SetShortSavePath(string s)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_SetShortSavePath_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001596 RID: 5526 RVA: 0x0005BE78 File Offset: 0x0005A078
	[CallerCount(0)]
	public unsafe string GetFullSavePath()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_GetFullSavePath_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06001597 RID: 5527 RVA: 0x0005BEB0 File Offset: 0x0005A0B0
	[CallerCount(0)]
	public unsafe void SetFullSavePath(string s)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_SetFullSavePath_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001598 RID: 5528 RVA: 0x0005BEF4 File Offset: 0x0005A0F4
	[CallerCount(0)]
	public unsafe int GetSlotIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_GetSlotIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001599 RID: 5529 RVA: 0x0005BF30 File Offset: 0x0005A130
	[CallerCount(0)]
	public unsafe void SetSlotIndex(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_SetSlotIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600159A RID: 5530 RVA: 0x0005BF70 File Offset: 0x0005A170
	[CallerCount(0)]
	public unsafe int GetDataSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_GetDataSize_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600159B RID: 5531 RVA: 0x0005BFAC File Offset: 0x0005A1AC
	[CallerCount(0)]
	public unsafe int GetDataVersion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_GetDataVersion_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600159C RID: 5532 RVA: 0x0005BFE8 File Offset: 0x0005A1E8
	[CallerCount(0)]
	public unsafe uint GetNetworkGameID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_GetNetworkGameID_Public_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600159D RID: 5533 RVA: 0x0005C024 File Offset: 0x0005A224
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600159E RID: 5534 RVA: 0x0005C058 File Offset: 0x0005A258
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247107, RefRangeEnd = 247108, XrefRangeStart = 247099, XrefRangeEnd = 247107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsVisible()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_IsVisible_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600159F RID: 5535 RVA: 0x0005C094 File Offset: 0x0005A294
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247121, RefRangeEnd = 247122, XrefRangeStart = 247108, XrefRangeEnd = 247121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeNetwork(Network network)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(network);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_InitializeNetwork_Public_Void_Network_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015A0 RID: 5536 RVA: 0x0005C0D8 File Offset: 0x0005A2D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247122, XrefRangeEnd = 247142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015A1 RID: 5537 RVA: 0x0005C10C File Offset: 0x0005A30C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247142, XrefRangeEnd = 247150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015A2 RID: 5538 RVA: 0x0005C140 File Offset: 0x0005A340
	[CallerCount(0)]
	public unsafe void NetworkEventCallback(NetworkEvent.EventType eventType, int eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventData;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_NetworkEventCallback_Private_Void_EventType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015A3 RID: 5539 RVA: 0x0005C18C File Offset: 0x0005A38C
	[CallerCount(0)]
	public unsafe void SetClickListener(UIP_GameSlot.ClickCallback cb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_SetClickListener_Public_Void_ClickCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015A4 RID: 5540 RVA: 0x0005C1D0 File Offset: 0x0005A3D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247150, XrefRangeEnd = 247155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPressSlot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_OnPressSlot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015A5 RID: 5541 RVA: 0x0005C204 File Offset: 0x0005A404
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247155, XrefRangeEnd = 247159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPressDelete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_OnPressDelete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015A6 RID: 5542 RVA: 0x0005C238 File Offset: 0x0005A438
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247159, XrefRangeEnd = 247161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015A7 RID: 5543 RVA: 0x0005C26C File Offset: 0x0005A46C
	[CallerCount(0)]
	public unsafe ShortSaveStruct GetGameSlotData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_GetGameSlotData_Public_ShortSaveStruct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return new ShortSaveStruct(intPtr);
	}

	// Token: 0x060015A8 RID: 5544 RVA: 0x0005C2A4 File Offset: 0x0005A4A4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247165, RefRangeEnd = 247166, XrefRangeStart = 247161, XrefRangeEnd = 247165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideDeleteButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_HideDeleteButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015A9 RID: 5545 RVA: 0x0005C2D8 File Offset: 0x0005A4D8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 247387, RefRangeEnd = 247389, XrefRangeStart = 247166, XrefRangeEnd = 247387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData(ShortSaveStruct save_struct, UIP_GameSlot.ESlotType slotType, InAppPurchaseWrapper iapManager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(save_struct));
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slotType;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(iapManager);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_SetData_Public_Void_ShortSaveStruct_ESlotType_InAppPurchaseWrapper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015AA RID: 5546 RVA: 0x0005C340 File Offset: 0x0005A540
	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 247396, RefRangeEnd = 247410, XrefRangeStart = 247389, XrefRangeEnd = 247396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TurnOnDeleteMode(bool bDeleteModeOn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bDeleteModeOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_TurnOnDeleteMode_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015AB RID: 5547 RVA: 0x0005C380 File Offset: 0x0005A580
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TurnOnSelectedMode(bool bSelectModeOn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bSelectModeOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_TurnOnSelectedMode_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015AC RID: 5548 RVA: 0x0005C3C0 File Offset: 0x0005A5C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247410, XrefRangeEnd = 247422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTurnText(int turnNumber)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref turnNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_UpdateTurnText_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015AD RID: 5549 RVA: 0x0005C400 File Offset: 0x0005A600
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247446, RefRangeEnd = 247447, XrefRangeStart = 247422, XrefRangeEnd = 247446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateStatusText(int roundNumber)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref roundNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_UpdateStatusText_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015AE RID: 5550 RVA: 0x0005C440 File Offset: 0x0005A640
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247451, RefRangeEnd = 247452, XrefRangeStart = 247447, XrefRangeEnd = 247451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetIsHostOnline()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_GetIsHostOnline_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060015AF RID: 5551 RVA: 0x0005C47C File Offset: 0x0005A67C
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 247457, RefRangeEnd = 247462, XrefRangeStart = 247452, XrefRangeEnd = 247457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnlineStatusIndicatorsSetActive(int playerGameObjectIndex, bool bActive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerGameObjectIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bActive;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_OnlineStatusIndicatorsSetActive_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015B0 RID: 5552 RVA: 0x0005C4C8 File Offset: 0x0005A6C8
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 247467, RefRangeEnd = 247472, XrefRangeStart = 247462, XrefRangeEnd = 247467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePlayerOnlineStatus(int playerGameObjectIndex, PlayerOnlineStatus status)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerGameObjectIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_UpdatePlayerOnlineStatus_Private_Void_Int32_PlayerOnlineStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015B1 RID: 5553 RVA: 0x0005C514 File Offset: 0x0005A714
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247524, RefRangeEnd = 247525, XrefRangeStart = 247472, XrefRangeEnd = 247524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePlayerTimers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_UpdatePlayerTimers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015B2 RID: 5554 RVA: 0x0005C548 File Offset: 0x0005A748
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247540, RefRangeEnd = 247541, XrefRangeStart = 247525, XrefRangeEnd = 247540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateMatchmakingTimer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_UpdateMatchmakingTimer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015B3 RID: 5555 RVA: 0x0005C57C File Offset: 0x0005A77C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247541, XrefRangeEnd = 247545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ProcessMatchmakingExpireTimer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_ProcessMatchmakingExpireTimer_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060015B4 RID: 5556 RVA: 0x0005C5BC File Offset: 0x0005A7BC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 247573, RefRangeEnd = 247575, XrefRangeStart = 247545, XrefRangeEnd = 247573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetTimeStringFromSeconds(uint timeInSeconds, bool bShortHand)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref timeInSeconds;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bShortHand;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr_GetTimeStringFromSeconds_Private_String_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x060015B5 RID: 5557 RVA: 0x0005C610 File Offset: 0x0005A810
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247575, XrefRangeEnd = 247579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIP_GameSlot()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015B6 RID: 5558 RVA: 0x0000DEFC File Offset: 0x0000C0FC
	public UIP_GameSlot(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170006D3 RID: 1747
	// (get) Token: 0x060015B7 RID: 5559 RVA: 0x0005C64C File Offset: 0x0005A84C
	// (set) Token: 0x060015B8 RID: 5560 RVA: 0x0000DF05 File Offset: 0x0000C105
	public unsafe Button m_baseButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_baseButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_baseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006D4 RID: 1748
	// (get) Token: 0x060015B9 RID: 5561 RVA: 0x0005C67C File Offset: 0x0005A87C
	// (set) Token: 0x060015BA RID: 5562 RVA: 0x0000DF24 File Offset: 0x0000C124
	public unsafe Il2CppReferenceArray<UIP_GameSlot.PlayerInfoGameObjects> m_playerInfoGameObjects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_playerInfoGameObjects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIP_GameSlot.PlayerInfoGameObjects>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_playerInfoGameObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006D5 RID: 1749
	// (get) Token: 0x060015BB RID: 5563 RVA: 0x0005C6AC File Offset: 0x0005A8AC
	// (set) Token: 0x060015BC RID: 5564 RVA: 0x0000DF43 File Offset: 0x0000C143
	public unsafe GameObject m_OnlineStatusIndicatorPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_OnlineStatusIndicatorPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_OnlineStatusIndicatorPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006D6 RID: 1750
	// (get) Token: 0x060015BD RID: 5565 RVA: 0x0005C6DC File Offset: 0x0005A8DC
	// (set) Token: 0x060015BE RID: 5566 RVA: 0x0000DF62 File Offset: 0x0000C162
	public unsafe GameObject m_honorRemainingObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_honorRemainingObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_honorRemainingObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006D7 RID: 1751
	// (get) Token: 0x060015BF RID: 5567 RVA: 0x0005C70C File Offset: 0x0005A90C
	// (set) Token: 0x060015C0 RID: 5568 RVA: 0x0000DF81 File Offset: 0x0000C181
	public unsafe TextMeshProUGUI m_honorRemainingText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_honorRemainingText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_honorRemainingText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006D8 RID: 1752
	// (get) Token: 0x060015C1 RID: 5569 RVA: 0x0005C73C File Offset: 0x0005A93C
	// (set) Token: 0x060015C2 RID: 5570 RVA: 0x0000DFA0 File Offset: 0x0000C1A0
	public unsafe GameObject m_timerObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_timerObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_timerObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006D9 RID: 1753
	// (get) Token: 0x060015C3 RID: 5571 RVA: 0x0005C76C File Offset: 0x0005A96C
	// (set) Token: 0x060015C4 RID: 5572 RVA: 0x0000DFBF File Offset: 0x0000C1BF
	public unsafe TextMeshProUGUI m_timer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_timer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_timer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006DA RID: 1754
	// (get) Token: 0x060015C5 RID: 5573 RVA: 0x0005C79C File Offset: 0x0005A99C
	// (set) Token: 0x060015C6 RID: 5574 RVA: 0x0000DFDE File Offset: 0x0000C1DE
	public unsafe TextMeshProUGUI m_roundText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_roundText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_roundText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006DB RID: 1755
	// (get) Token: 0x060015C7 RID: 5575 RVA: 0x0005C7CC File Offset: 0x0005A9CC
	// (set) Token: 0x060015C8 RID: 5576 RVA: 0x0000DFFD File Offset: 0x0000C1FD
	public unsafe Color m_forfeitTextColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_forfeitTextColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_forfeitTextColor)) = value;
		}
	}

	// Token: 0x170006DC RID: 1756
	// (get) Token: 0x060015C9 RID: 5577 RVA: 0x0005C7F4 File Offset: 0x0005A9F4
	// (set) Token: 0x060015CA RID: 5578 RVA: 0x0000E018 File Offset: 0x0000C218
	public unsafe Color m_localPlayerActiveTurnColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_localPlayerActiveTurnColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_localPlayerActiveTurnColor)) = value;
		}
	}

	// Token: 0x170006DD RID: 1757
	// (get) Token: 0x060015CB RID: 5579 RVA: 0x0005C81C File Offset: 0x0005AA1C
	// (set) Token: 0x060015CC RID: 5580 RVA: 0x0000E033 File Offset: 0x0000C233
	public unsafe Color m_nonLocalPlayerActiveTurnColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_nonLocalPlayerActiveTurnColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_nonLocalPlayerActiveTurnColor)) = value;
		}
	}

	// Token: 0x170006DE RID: 1758
	// (get) Token: 0x060015CD RID: 5581 RVA: 0x0005C844 File Offset: 0x0005AA44
	// (set) Token: 0x060015CE RID: 5582 RVA: 0x0000E04E File Offset: 0x0000C24E
	public unsafe Color m_waitingOnInviteColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_waitingOnInviteColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_waitingOnInviteColor)) = value;
		}
	}

	// Token: 0x170006DF RID: 1759
	// (get) Token: 0x060015CF RID: 5583 RVA: 0x0005C86C File Offset: 0x0005AA6C
	// (set) Token: 0x060015D0 RID: 5584 RVA: 0x0000E069 File Offset: 0x0000C269
	public unsafe Il2CppReferenceArray<UIP_GameSlot.SetIcon> m_setIcons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_setIcons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIP_GameSlot.SetIcon>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_setIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006E0 RID: 1760
	// (get) Token: 0x060015D1 RID: 5585 RVA: 0x0005C89C File Offset: 0x0005AA9C
	// (set) Token: 0x060015D2 RID: 5586 RVA: 0x0000E088 File Offset: 0x0000C288
	public unsafe Il2CppReferenceArray<UIP_GameSlot.SetIcon> m_promoIcons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_promoIcons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIP_GameSlot.SetIcon>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_promoIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006E1 RID: 1761
	// (get) Token: 0x060015D3 RID: 5587 RVA: 0x0005C8CC File Offset: 0x0005AACC
	// (set) Token: 0x060015D4 RID: 5588 RVA: 0x0000E0A7 File Offset: 0x0000C2A7
	public unsafe Il2CppReferenceArray<Sprite> m_OnlineStatusImages
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_OnlineStatusImages);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_OnlineStatusImages), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006E2 RID: 1762
	// (get) Token: 0x060015D5 RID: 5589 RVA: 0x0005C8FC File Offset: 0x0005AAFC
	// (set) Token: 0x060015D6 RID: 5590 RVA: 0x0000E0C6 File Offset: 0x0000C2C6
	public unsafe GameObject m_newChatIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_newChatIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_newChatIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006E3 RID: 1763
	// (get) Token: 0x060015D7 RID: 5591 RVA: 0x0005C92C File Offset: 0x0005AB2C
	// (set) Token: 0x060015D8 RID: 5592 RVA: 0x0000E0E5 File Offset: 0x0000C2E5
	public unsafe Button m_deleteButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_deleteButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_deleteButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006E4 RID: 1764
	// (get) Token: 0x060015D9 RID: 5593 RVA: 0x0005C95C File Offset: 0x0005AB5C
	// (set) Token: 0x060015DA RID: 5594 RVA: 0x0000E104 File Offset: 0x0000C304
	public unsafe RectTransform m_RectTransform
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_RectTransform);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006E5 RID: 1765
	// (get) Token: 0x060015DB RID: 5595 RVA: 0x0005C98C File Offset: 0x0005AB8C
	// (set) Token: 0x060015DC RID: 5596 RVA: 0x0000E123 File Offset: 0x0000C323
	public unsafe ColorByFaction m_colorizer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_colorizer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorByFaction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_colorizer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006E6 RID: 1766
	// (get) Token: 0x060015DD RID: 5597 RVA: 0x0005C9BC File Offset: 0x0005ABBC
	// (set) Token: 0x060015DE RID: 5598 RVA: 0x0000E142 File Offset: 0x0000C342
	public unsafe uint m_colorizerDeleteColorIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_colorizerDeleteColorIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_colorizerDeleteColorIndex)) = value;
		}
	}

	// Token: 0x170006E7 RID: 1767
	// (get) Token: 0x060015DF RID: 5599 RVA: 0x0005C9E4 File Offset: 0x0005ABE4
	// (set) Token: 0x060015E0 RID: 5600 RVA: 0x0000E15D File Offset: 0x0000C35D
	public unsafe Network m_network
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_network);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Network>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_network), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006E8 RID: 1768
	// (get) Token: 0x060015E1 RID: 5601 RVA: 0x0005CA14 File Offset: 0x0005AC14
	// (set) Token: 0x060015E2 RID: 5602 RVA: 0x0000E17C File Offset: 0x0000C37C
	public unsafe UIP_GameSlot.ClickCallback m_callback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_callback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIP_GameSlot.ClickCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006E9 RID: 1769
	// (get) Token: 0x060015E3 RID: 5603 RVA: 0x0005CA44 File Offset: 0x0005AC44
	// (set) Token: 0x060015E4 RID: 5604 RVA: 0x0000E19B File Offset: 0x0000C39B
	public unsafe Coroutine m_matchmakingTimerCoroutine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_matchmakingTimerCoroutine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_matchmakingTimerCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006EA RID: 1770
	// (get) Token: 0x060015E5 RID: 5605 RVA: 0x0005CA74 File Offset: 0x0005AC74
	// (set) Token: 0x060015E6 RID: 5606 RVA: 0x0000E1BA File Offset: 0x0000C3BA
	public ShortSaveStruct m_save_struct
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_save_struct);
			return new ShortSaveStruct(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_save_struct), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x170006EB RID: 1771
	// (get) Token: 0x060015E7 RID: 5607 RVA: 0x0005CAA4 File Offset: 0x0005ACA4
	// (set) Token: 0x060015E8 RID: 5608 RVA: 0x0000E1E8 File Offset: 0x0000C3E8
	public unsafe UIP_GameSlot.ESlotType m_type
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_type);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_type)) = value;
		}
	}

	// Token: 0x170006EC RID: 1772
	// (get) Token: 0x060015E9 RID: 5609 RVA: 0x0005CACC File Offset: 0x0005ACCC
	// (set) Token: 0x060015EA RID: 5610 RVA: 0x0000E203 File Offset: 0x0000C403
	public unsafe UIP_GameSlot.ENetworkGameState m_state
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_state);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_state)) = value;
		}
	}

	// Token: 0x170006ED RID: 1773
	// (get) Token: 0x060015EB RID: 5611 RVA: 0x0005CAF4 File Offset: 0x0005ACF4
	// (set) Token: 0x060015EC RID: 5612 RVA: 0x0000E21E File Offset: 0x0000C41E
	public unsafe string m_savePathShort
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_savePathShort);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_savePathShort), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170006EE RID: 1774
	// (get) Token: 0x060015ED RID: 5613 RVA: 0x0005CB1C File Offset: 0x0005AD1C
	// (set) Token: 0x060015EE RID: 5614 RVA: 0x0000E23D File Offset: 0x0000C43D
	public unsafe string m_savePathFull
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_savePathFull);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_savePathFull), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170006EF RID: 1775
	// (get) Token: 0x060015EF RID: 5615 RVA: 0x0005CB44 File Offset: 0x0005AD44
	// (set) Token: 0x060015F0 RID: 5616 RVA: 0x0000E25C File Offset: 0x0000C45C
	public unsafe uint m_GameID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_GameID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_GameID)) = value;
		}
	}

	// Token: 0x170006F0 RID: 1776
	// (get) Token: 0x060015F1 RID: 5617 RVA: 0x0005CB6C File Offset: 0x0005AD6C
	// (set) Token: 0x060015F2 RID: 5618 RVA: 0x0000E277 File Offset: 0x0000C477
	public unsafe int m_gameSlotIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_gameSlotIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_gameSlotIndex)) = value;
		}
	}

	// Token: 0x170006F1 RID: 1777
	// (get) Token: 0x060015F3 RID: 5619 RVA: 0x0005CB94 File Offset: 0x0005AD94
	// (set) Token: 0x060015F4 RID: 5620 RVA: 0x0000E292 File Offset: 0x0000C492
	public unsafe uint m_colors
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_colors);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_colors)) = value;
		}
	}

	// Token: 0x170006F2 RID: 1778
	// (get) Token: 0x060015F5 RID: 5621 RVA: 0x0005CBBC File Offset: 0x0005ADBC
	// (set) Token: 0x060015F6 RID: 5622 RVA: 0x0000E2AD File Offset: 0x0000C4AD
	public unsafe int m_saveDataSize
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_saveDataSize);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_saveDataSize)) = value;
		}
	}

	// Token: 0x170006F3 RID: 1779
	// (get) Token: 0x060015F7 RID: 5623 RVA: 0x0005CBE4 File Offset: 0x0005ADE4
	// (set) Token: 0x060015F8 RID: 5624 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
	public unsafe int m_worldDataVersion
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_worldDataVersion);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_worldDataVersion)) = value;
		}
	}

	// Token: 0x170006F4 RID: 1780
	// (get) Token: 0x060015F9 RID: 5625 RVA: 0x0005CC0C File Offset: 0x0005AE0C
	// (set) Token: 0x060015FA RID: 5626 RVA: 0x0000E2E3 File Offset: 0x0000C4E3
	public unsafe int m_numPlayers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_numPlayers);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_numPlayers)) = value;
		}
	}

	// Token: 0x170006F5 RID: 1781
	// (get) Token: 0x060015FB RID: 5627 RVA: 0x0005CC34 File Offset: 0x0005AE34
	// (set) Token: 0x060015FC RID: 5628 RVA: 0x0000E2FE File Offset: 0x0000C4FE
	public unsafe bool bLocalPlayerForfeited
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_bLocalPlayerForfeited);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_bLocalPlayerForfeited)) = value;
		}
	}

	// Token: 0x170006F6 RID: 1782
	// (get) Token: 0x060015FD RID: 5629 RVA: 0x0005CC5C File Offset: 0x0005AE5C
	// (set) Token: 0x060015FE RID: 5630 RVA: 0x0000E319 File Offset: 0x0000C519
	public unsafe Il2CppStructArray<int> m_playerIDs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_playerIDs);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_playerIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006F7 RID: 1783
	// (get) Token: 0x060015FF RID: 5631 RVA: 0x0005CC8C File Offset: 0x0005AE8C
	// (set) Token: 0x06001600 RID: 5632 RVA: 0x0000E338 File Offset: 0x0000C538
	public unsafe int m_localPlayerGameObjectsIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_localPlayerGameObjectsIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_localPlayerGameObjectsIndex)) = value;
		}
	}

	// Token: 0x170006F8 RID: 1784
	// (get) Token: 0x06001601 RID: 5633 RVA: 0x0005CCB4 File Offset: 0x0005AEB4
	// (set) Token: 0x06001602 RID: 5634 RVA: 0x0000E353 File Offset: 0x0000C553
	public unsafe int m_matchmakingOpponentGameObjectIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_matchmakingOpponentGameObjectIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_matchmakingOpponentGameObjectIndex)) = value;
		}
	}

	// Token: 0x170006F9 RID: 1785
	// (get) Token: 0x06001603 RID: 5635 RVA: 0x0005CCDC File Offset: 0x0005AEDC
	// (set) Token: 0x06001604 RID: 5636 RVA: 0x0000E36E File Offset: 0x0000C56E
	public unsafe int m_matchmakingRatingDifference
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_matchmakingRatingDifference);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_matchmakingRatingDifference)) = value;
		}
	}

	// Token: 0x170006FA RID: 1786
	// (get) Token: 0x06001605 RID: 5637 RVA: 0x0005CD04 File Offset: 0x0005AF04
	// (set) Token: 0x06001606 RID: 5638 RVA: 0x0000E389 File Offset: 0x0000C589
	public unsafe uint m_matchmakingExpireTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_matchmakingExpireTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_matchmakingExpireTime)) = value;
		}
	}

	// Token: 0x170006FB RID: 1787
	// (get) Token: 0x06001607 RID: 5639 RVA: 0x0005CD2C File Offset: 0x0005AF2C
	// (set) Token: 0x06001608 RID: 5640 RVA: 0x0000E3A4 File Offset: 0x0000C5A4
	public unsafe uint m_matchmakingExpireTimeRemaining
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_matchmakingExpireTimeRemaining);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_matchmakingExpireTimeRemaining)) = value;
		}
	}

	// Token: 0x170006FC RID: 1788
	// (get) Token: 0x06001609 RID: 5641 RVA: 0x0005CD54 File Offset: 0x0005AF54
	// (set) Token: 0x0600160A RID: 5642 RVA: 0x0000E3BF File Offset: 0x0000C5BF
	public unsafe uint m_localPlayerID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_localPlayerID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_localPlayerID)) = value;
		}
	}

	// Token: 0x170006FD RID: 1789
	// (get) Token: 0x0600160B RID: 5643 RVA: 0x0005CD7C File Offset: 0x0005AF7C
	// (set) Token: 0x0600160C RID: 5644 RVA: 0x0000E3DA File Offset: 0x0000C5DA
	public unsafe uint m_defaultColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_defaultColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_defaultColor)) = value;
		}
	}

	// Token: 0x170006FE RID: 1790
	// (get) Token: 0x0600160D RID: 5645 RVA: 0x0005CDA4 File Offset: 0x0005AFA4
	// (set) Token: 0x0600160E RID: 5646 RVA: 0x0000E3F5 File Offset: 0x0000C5F5
	public unsafe bool m_bDeleteMode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_bDeleteMode);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_bDeleteMode)) = value;
		}
	}

	// Token: 0x170006FF RID: 1791
	// (get) Token: 0x0600160F RID: 5647 RVA: 0x0005CDCC File Offset: 0x0005AFCC
	// (set) Token: 0x06001610 RID: 5648 RVA: 0x0000E410 File Offset: 0x0000C610
	public unsafe bool m_bOwner
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_bOwner);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_bOwner)) = value;
		}
	}

	// Token: 0x17000700 RID: 1792
	// (get) Token: 0x06001611 RID: 5649 RVA: 0x0005CDF4 File Offset: 0x0005AFF4
	// (set) Token: 0x06001612 RID: 5650 RVA: 0x0000E42B File Offset: 0x0000C62B
	public unsafe bool m_bReadyToStart
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_bReadyToStart);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_bReadyToStart)) = value;
		}
	}

	// Token: 0x17000701 RID: 1793
	// (get) Token: 0x06001613 RID: 5651 RVA: 0x0005CE1C File Offset: 0x0005B01C
	// (set) Token: 0x06001614 RID: 5652 RVA: 0x0000E446 File Offset: 0x0000C646
	public unsafe bool m_bInvited
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_bInvited);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_bInvited)) = value;
		}
	}

	// Token: 0x17000702 RID: 1794
	// (get) Token: 0x06001615 RID: 5653 RVA: 0x0005CE44 File Offset: 0x0005B044
	// (set) Token: 0x06001616 RID: 5654 RVA: 0x0000E461 File Offset: 0x0000C661
	public unsafe bool m_bDisplayPlayerTimers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_bDisplayPlayerTimers);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_bDisplayPlayerTimers)) = value;
		}
	}

	// Token: 0x17000703 RID: 1795
	// (get) Token: 0x06001617 RID: 5655 RVA: 0x0005CE6C File Offset: 0x0005B06C
	// (set) Token: 0x06001618 RID: 5656 RVA: 0x0000E47C File Offset: 0x0000C67C
	public unsafe bool m_bNeedsOnlineStatusUpdate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_bNeedsOnlineStatusUpdate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_bNeedsOnlineStatusUpdate)) = value;
		}
	}

	// Token: 0x17000704 RID: 1796
	// (get) Token: 0x06001619 RID: 5657 RVA: 0x0005CE94 File Offset: 0x0005B094
	// (set) Token: 0x0600161A RID: 5658 RVA: 0x0000E497 File Offset: 0x0000C697
	public unsafe bool m_bNetworkInitialized
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_bNetworkInitialized);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.NativeFieldInfoPtr_m_bNetworkInitialized)) = value;
		}
	}

	// Token: 0x04000EEF RID: 3823
	private static readonly IntPtr NativeFieldInfoPtr_m_baseButton;

	// Token: 0x04000EF0 RID: 3824
	private static readonly IntPtr NativeFieldInfoPtr_m_playerInfoGameObjects;

	// Token: 0x04000EF1 RID: 3825
	private static readonly IntPtr NativeFieldInfoPtr_m_OnlineStatusIndicatorPrefab;

	// Token: 0x04000EF2 RID: 3826
	private static readonly IntPtr NativeFieldInfoPtr_m_honorRemainingObj;

	// Token: 0x04000EF3 RID: 3827
	private static readonly IntPtr NativeFieldInfoPtr_m_honorRemainingText;

	// Token: 0x04000EF4 RID: 3828
	private static readonly IntPtr NativeFieldInfoPtr_m_timerObj;

	// Token: 0x04000EF5 RID: 3829
	private static readonly IntPtr NativeFieldInfoPtr_m_timer;

	// Token: 0x04000EF6 RID: 3830
	private static readonly IntPtr NativeFieldInfoPtr_m_roundText;

	// Token: 0x04000EF7 RID: 3831
	private static readonly IntPtr NativeFieldInfoPtr_m_forfeitTextColor;

	// Token: 0x04000EF8 RID: 3832
	private static readonly IntPtr NativeFieldInfoPtr_m_localPlayerActiveTurnColor;

	// Token: 0x04000EF9 RID: 3833
	private static readonly IntPtr NativeFieldInfoPtr_m_nonLocalPlayerActiveTurnColor;

	// Token: 0x04000EFA RID: 3834
	private static readonly IntPtr NativeFieldInfoPtr_m_waitingOnInviteColor;

	// Token: 0x04000EFB RID: 3835
	private static readonly IntPtr NativeFieldInfoPtr_m_setIcons;

	// Token: 0x04000EFC RID: 3836
	private static readonly IntPtr NativeFieldInfoPtr_m_promoIcons;

	// Token: 0x04000EFD RID: 3837
	private static readonly IntPtr NativeFieldInfoPtr_m_OnlineStatusImages;

	// Token: 0x04000EFE RID: 3838
	private static readonly IntPtr NativeFieldInfoPtr_m_newChatIcon;

	// Token: 0x04000EFF RID: 3839
	private static readonly IntPtr NativeFieldInfoPtr_m_deleteButton;

	// Token: 0x04000F00 RID: 3840
	private static readonly IntPtr NativeFieldInfoPtr_m_RectTransform;

	// Token: 0x04000F01 RID: 3841
	private static readonly IntPtr NativeFieldInfoPtr_m_colorizer;

	// Token: 0x04000F02 RID: 3842
	private static readonly IntPtr NativeFieldInfoPtr_m_colorizerDeleteColorIndex;

	// Token: 0x04000F03 RID: 3843
	private static readonly IntPtr NativeFieldInfoPtr_m_network;

	// Token: 0x04000F04 RID: 3844
	private static readonly IntPtr NativeFieldInfoPtr_m_callback;

	// Token: 0x04000F05 RID: 3845
	private static readonly IntPtr NativeFieldInfoPtr_m_matchmakingTimerCoroutine;

	// Token: 0x04000F06 RID: 3846
	private static readonly IntPtr NativeFieldInfoPtr_m_save_struct;

	// Token: 0x04000F07 RID: 3847
	private static readonly IntPtr NativeFieldInfoPtr_m_type;

	// Token: 0x04000F08 RID: 3848
	private static readonly IntPtr NativeFieldInfoPtr_m_state;

	// Token: 0x04000F09 RID: 3849
	private static readonly IntPtr NativeFieldInfoPtr_m_savePathShort;

	// Token: 0x04000F0A RID: 3850
	private static readonly IntPtr NativeFieldInfoPtr_m_savePathFull;

	// Token: 0x04000F0B RID: 3851
	private static readonly IntPtr NativeFieldInfoPtr_m_GameID;

	// Token: 0x04000F0C RID: 3852
	private static readonly IntPtr NativeFieldInfoPtr_m_gameSlotIndex;

	// Token: 0x04000F0D RID: 3853
	private static readonly IntPtr NativeFieldInfoPtr_m_colors;

	// Token: 0x04000F0E RID: 3854
	private static readonly IntPtr NativeFieldInfoPtr_m_saveDataSize;

	// Token: 0x04000F0F RID: 3855
	private static readonly IntPtr NativeFieldInfoPtr_m_worldDataVersion;

	// Token: 0x04000F10 RID: 3856
	private static readonly IntPtr NativeFieldInfoPtr_m_numPlayers;

	// Token: 0x04000F11 RID: 3857
	private static readonly IntPtr NativeFieldInfoPtr_bLocalPlayerForfeited;

	// Token: 0x04000F12 RID: 3858
	private static readonly IntPtr NativeFieldInfoPtr_m_playerIDs;

	// Token: 0x04000F13 RID: 3859
	private static readonly IntPtr NativeFieldInfoPtr_m_localPlayerGameObjectsIndex;

	// Token: 0x04000F14 RID: 3860
	private static readonly IntPtr NativeFieldInfoPtr_m_matchmakingOpponentGameObjectIndex;

	// Token: 0x04000F15 RID: 3861
	private static readonly IntPtr NativeFieldInfoPtr_m_matchmakingRatingDifference;

	// Token: 0x04000F16 RID: 3862
	private static readonly IntPtr NativeFieldInfoPtr_m_matchmakingExpireTime;

	// Token: 0x04000F17 RID: 3863
	private static readonly IntPtr NativeFieldInfoPtr_m_matchmakingExpireTimeRemaining;

	// Token: 0x04000F18 RID: 3864
	private static readonly IntPtr NativeFieldInfoPtr_m_localPlayerID;

	// Token: 0x04000F19 RID: 3865
	private static readonly IntPtr NativeFieldInfoPtr_m_defaultColor;

	// Token: 0x04000F1A RID: 3866
	private static readonly IntPtr NativeFieldInfoPtr_m_bDeleteMode;

	// Token: 0x04000F1B RID: 3867
	private static readonly IntPtr NativeFieldInfoPtr_m_bOwner;

	// Token: 0x04000F1C RID: 3868
	private static readonly IntPtr NativeFieldInfoPtr_m_bReadyToStart;

	// Token: 0x04000F1D RID: 3869
	private static readonly IntPtr NativeFieldInfoPtr_m_bInvited;

	// Token: 0x04000F1E RID: 3870
	private static readonly IntPtr NativeFieldInfoPtr_m_bDisplayPlayerTimers;

	// Token: 0x04000F1F RID: 3871
	private static readonly IntPtr NativeFieldInfoPtr_m_bNeedsOnlineStatusUpdate;

	// Token: 0x04000F20 RID: 3872
	private static readonly IntPtr NativeFieldInfoPtr_m_bNetworkInitialized;

	// Token: 0x04000F21 RID: 3873
	private static readonly IntPtr NativeMethodInfoPtr_GetNumPlayers_Public_Int32_0;

	// Token: 0x04000F22 RID: 3874
	private static readonly IntPtr NativeMethodInfoPtr_NeedsOnlineStatusUpdate_Public_Boolean_0;

	// Token: 0x04000F23 RID: 3875
	private static readonly IntPtr NativeMethodInfoPtr_SetAllRequestsProcessed_Public_Void_0;

	// Token: 0x04000F24 RID: 3876
	private static readonly IntPtr NativeMethodInfoPtr_GetOnlineStatusUpdateUserId_Public_Il2CppStructArray_1_Int32_0;

	// Token: 0x04000F25 RID: 3877
	private static readonly IntPtr NativeMethodInfoPtr_GetLocalPlayerForfeited_Public_Boolean_0;

	// Token: 0x04000F26 RID: 3878
	private static readonly IntPtr NativeMethodInfoPtr_GetShortSavePath_Public_String_0;

	// Token: 0x04000F27 RID: 3879
	private static readonly IntPtr NativeMethodInfoPtr_SetShortSavePath_Public_Void_String_0;

	// Token: 0x04000F28 RID: 3880
	private static readonly IntPtr NativeMethodInfoPtr_GetFullSavePath_Public_String_0;

	// Token: 0x04000F29 RID: 3881
	private static readonly IntPtr NativeMethodInfoPtr_SetFullSavePath_Public_Void_String_0;

	// Token: 0x04000F2A RID: 3882
	private static readonly IntPtr NativeMethodInfoPtr_GetSlotIndex_Public_Int32_0;

	// Token: 0x04000F2B RID: 3883
	private static readonly IntPtr NativeMethodInfoPtr_SetSlotIndex_Public_Void_Int32_0;

	// Token: 0x04000F2C RID: 3884
	private static readonly IntPtr NativeMethodInfoPtr_GetDataSize_Public_Int32_0;

	// Token: 0x04000F2D RID: 3885
	private static readonly IntPtr NativeMethodInfoPtr_GetDataVersion_Public_Int32_0;

	// Token: 0x04000F2E RID: 3886
	private static readonly IntPtr NativeMethodInfoPtr_GetNetworkGameID_Public_UInt32_0;

	// Token: 0x04000F2F RID: 3887
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000F30 RID: 3888
	private static readonly IntPtr NativeMethodInfoPtr_IsVisible_Public_Boolean_0;

	// Token: 0x04000F31 RID: 3889
	private static readonly IntPtr NativeMethodInfoPtr_InitializeNetwork_Public_Void_Network_0;

	// Token: 0x04000F32 RID: 3890
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000F33 RID: 3891
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000F34 RID: 3892
	private static readonly IntPtr NativeMethodInfoPtr_NetworkEventCallback_Private_Void_EventType_Int32_0;

	// Token: 0x04000F35 RID: 3893
	private static readonly IntPtr NativeMethodInfoPtr_SetClickListener_Public_Void_ClickCallback_0;

	// Token: 0x04000F36 RID: 3894
	private static readonly IntPtr NativeMethodInfoPtr_OnPressSlot_Public_Void_0;

	// Token: 0x04000F37 RID: 3895
	private static readonly IntPtr NativeMethodInfoPtr_OnPressDelete_Public_Void_0;

	// Token: 0x04000F38 RID: 3896
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000F39 RID: 3897
	private static readonly IntPtr NativeMethodInfoPtr_GetGameSlotData_Public_ShortSaveStruct_0;

	// Token: 0x04000F3A RID: 3898
	private static readonly IntPtr NativeMethodInfoPtr_HideDeleteButton_Public_Void_0;

	// Token: 0x04000F3B RID: 3899
	private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_ShortSaveStruct_ESlotType_InAppPurchaseWrapper_0;

	// Token: 0x04000F3C RID: 3900
	private static readonly IntPtr NativeMethodInfoPtr_TurnOnDeleteMode_Public_Void_Boolean_0;

	// Token: 0x04000F3D RID: 3901
	private static readonly IntPtr NativeMethodInfoPtr_TurnOnSelectedMode_Public_Void_Boolean_0;

	// Token: 0x04000F3E RID: 3902
	private static readonly IntPtr NativeMethodInfoPtr_UpdateTurnText_Private_Void_Int32_0;

	// Token: 0x04000F3F RID: 3903
	private static readonly IntPtr NativeMethodInfoPtr_UpdateStatusText_Private_Void_Int32_0;

	// Token: 0x04000F40 RID: 3904
	private static readonly IntPtr NativeMethodInfoPtr_GetIsHostOnline_Public_Boolean_0;

	// Token: 0x04000F41 RID: 3905
	private static readonly IntPtr NativeMethodInfoPtr_OnlineStatusIndicatorsSetActive_Private_Void_Int32_Boolean_0;

	// Token: 0x04000F42 RID: 3906
	private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayerOnlineStatus_Private_Void_Int32_PlayerOnlineStatus_0;

	// Token: 0x04000F43 RID: 3907
	private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayerTimers_Private_Void_0;

	// Token: 0x04000F44 RID: 3908
	private static readonly IntPtr NativeMethodInfoPtr_UpdateMatchmakingTimer_Private_Void_0;

	// Token: 0x04000F45 RID: 3909
	private static readonly IntPtr NativeMethodInfoPtr_ProcessMatchmakingExpireTimer_Private_IEnumerator_0;

	// Token: 0x04000F46 RID: 3910
	private static readonly IntPtr NativeMethodInfoPtr_GetTimeStringFromSeconds_Private_String_UInt32_Boolean_0;

	// Token: 0x04000F47 RID: 3911
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001C9 RID: 457
	public enum ClickEventType
	{
		// Token: 0x04001A81 RID: 6785
		Evt_Click_Unknown,
		// Token: 0x04001A82 RID: 6786
		Evt_Click_LoadOfflineGame,
		// Token: 0x04001A83 RID: 6787
		Evt_Click_DeleteOfflineGame,
		// Token: 0x04001A84 RID: 6788
		Evt_Click_NetworkLaunchGame,
		// Token: 0x04001A85 RID: 6789
		Evt_Click_NetworkAcceptInvite,
		// Token: 0x04001A86 RID: 6790
		Evt_Click_NetworkResumeGame,
		// Token: 0x04001A87 RID: 6791
		Evt_Click_NetworkJoinGame,
		// Token: 0x04001A88 RID: 6792
		Evt_Click_NetworkDeleteGame,
		// Token: 0x04001A89 RID: 6793
		Evt_Click_NetworkForfeitGame,
		// Token: 0x04001A8A RID: 6794
		Evt_Click_NetworkForfeitGameLastPlayer,
		// Token: 0x04001A8B RID: 6795
		Evt_Click_NetworkWithdrawFromGame,
		// Token: 0x04001A8C RID: 6796
		Evt_Click_NetworkDeleteMatchmakingGame
	}

	// Token: 0x020001CA RID: 458
	public enum ESlotType
	{
		// Token: 0x04001A8E RID: 6798
		Active_Offline,
		// Token: 0x04001A8F RID: 6799
		Active_Online,
		// Token: 0x04001A90 RID: 6800
		Available,
		// Token: 0x04001A91 RID: 6801
		Matchmaking
	}

	// Token: 0x020001CB RID: 459
	public enum ENetworkGameState
	{
		// Token: 0x04001A93 RID: 6803
		E_GAMESTATE_OFFLINE,
		// Token: 0x04001A94 RID: 6804
		E_GAMESTATE_STAGING,
		// Token: 0x04001A95 RID: 6805
		E_GAMESTATE_PLAYING,
		// Token: 0x04001A96 RID: 6806
		E_GAMESTATE_COMPLETED,
		// Token: 0x04001A97 RID: 6807
		E_GAMESTATE_ARCHIVED
	}

	// Token: 0x020001CC RID: 460
	public enum ENetworkUserState
	{
		// Token: 0x04001A99 RID: 6809
		E_USERSTATE_OFFLINE,
		// Token: 0x04001A9A RID: 6810
		E_USERSTATE_READY,
		// Token: 0x04001A9B RID: 6811
		E_USERSTATE_INVITED,
		// Token: 0x04001A9C RID: 6812
		E_USERSTATE_PLAYING,
		// Token: 0x04001A9D RID: 6813
		E_USERSTATE_FORFEIT,
		// Token: 0x04001A9E RID: 6814
		E_USERSTATE_FINISHED
	}

	// Token: 0x020001CD RID: 461
	public enum PlayerSide
	{
		// Token: 0x04001AA0 RID: 6816
		E_PLAYERSIDE_UNKNOWN,
		// Token: 0x04001AA1 RID: 6817
		E_PLAYERSIDE_USSR,
		// Token: 0x04001AA2 RID: 6818
		E_PLAYERSIDE_US
	}

	// Token: 0x020001CE RID: 462
	public sealed class ClickCallback : MulticastDelegate
	{
		// Token: 0x06002681 RID: 9857 RVA: 0x0008D584 File Offset: 0x0008B784
		// Note: this type is marked as 'beforefieldinit'.
		static ClickCallback()
		{
			Il2CppClassPointerStore<UIP_GameSlot.ClickCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "ClickCallback");
			UIP_GameSlot.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot.ClickCallback>.NativeClassPtr, 100666350);
			UIP_GameSlot.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_GameSlot_ClickEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot.ClickCallback>.NativeClassPtr, 100666351);
			UIP_GameSlot.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_GameSlot_ClickEventType_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot.ClickCallback>.NativeClassPtr, 100666352);
			UIP_GameSlot.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot.ClickCallback>.NativeClassPtr, 100666353);
		}

		// Token: 0x06002682 RID: 9858 RVA: 0x0008D5F8 File Offset: 0x0008B7F8
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIP_GameSlot.ClickCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x0008D654 File Offset: 0x0008B854
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 79669, RefRangeEnd = 79680, XrefRangeStart = 79669, XrefRangeEnd = 79680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(UIP_GameSlot slot, UIP_GameSlot.ClickEventType evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_GameSlot_ClickEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x0008D6A4 File Offset: 0x0008B8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247083, XrefRangeEnd = 247087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(UIP_GameSlot slot, UIP_GameSlot.ClickEventType evt, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_GameSlot_ClickEventType_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x0008D728 File Offset: 0x0008B928
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x00017C74 File Offset: 0x00015E74
		public ClickCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x00017C7D File Offset: 0x00015E7D
		public static implicit operator UIP_GameSlot.ClickCallback(Action<UIP_GameSlot, UIP_GameSlot.ClickEventType> A_0)
		{
			return DelegateSupport.ConvertDelegate<UIP_GameSlot.ClickCallback>(A_0);
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x00017C85 File Offset: 0x00015E85
		public static UIP_GameSlot.ClickCallback operator +(UIP_GameSlot.ClickCallback A_0, UIP_GameSlot.ClickCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UIP_GameSlot.ClickCallback>();
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x00017C93 File Offset: 0x00015E93
		public static UIP_GameSlot.ClickCallback operator -(UIP_GameSlot.ClickCallback A_0, UIP_GameSlot.ClickCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UIP_GameSlot.ClickCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001AA3 RID: 6819
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001AA4 RID: 6820
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_GameSlot_ClickEventType_0;

		// Token: 0x04001AA5 RID: 6821
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_GameSlot_ClickEventType_AsyncCallback_Object_0;

		// Token: 0x04001AA6 RID: 6822
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020001CF RID: 463
	[Serializable]
	public sealed class PlayerInfoGameObjects : ValueType
	{
		// Token: 0x0600268A RID: 9866 RVA: 0x0008D76C File Offset: 0x0008B96C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerInfoGameObjects()
		{
			Il2CppClassPointerStore<UIP_GameSlot.PlayerInfoGameObjects>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "PlayerInfoGameObjects");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIP_GameSlot.PlayerInfoGameObjects>.NativeClassPtr);
			UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerRootObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot.PlayerInfoGameObjects>.NativeClassPtr, "m_playerRootObj");
			UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot.PlayerInfoGameObjects>.NativeClassPtr, "m_playerText");
			UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerRating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot.PlayerInfoGameObjects>.NativeClassPtr, "m_playerRating");
			UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerRatingObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot.PlayerInfoGameObjects>.NativeClassPtr, "m_playerRatingObj");
			UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerTimerObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot.PlayerInfoGameObjects>.NativeClassPtr, "m_playerTimerObj");
			UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_activePlayerObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot.PlayerInfoGameObjects>.NativeClassPtr, "m_activePlayerObject");
			UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerStatusIndicatorRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot.PlayerInfoGameObjects>.NativeClassPtr, "m_playerStatusIndicatorRoot");
			UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerStatusIndicatorImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot.PlayerInfoGameObjects>.NativeClassPtr, "m_playerStatusIndicatorImage");
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x00017CA4 File Offset: 0x00015EA4
		public PlayerInfoGameObjects(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x00017CAD File Offset: 0x00015EAD
		public PlayerInfoGameObjects()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIP_GameSlot.PlayerInfoGameObjects>.NativeClassPtr))
		{
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x0600268D RID: 9869 RVA: 0x0008D838 File Offset: 0x0008BA38
		// (set) Token: 0x0600268E RID: 9870 RVA: 0x00017CBF File Offset: 0x00015EBF
		public unsafe GameObject m_playerRootObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerRootObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerRootObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x0600268F RID: 9871 RVA: 0x0008D868 File Offset: 0x0008BA68
		// (set) Token: 0x06002690 RID: 9872 RVA: 0x00017CDE File Offset: 0x00015EDE
		public unsafe TextMeshProUGUI m_playerText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06002691 RID: 9873 RVA: 0x0008D898 File Offset: 0x0008BA98
		// (set) Token: 0x06002692 RID: 9874 RVA: 0x00017CFD File Offset: 0x00015EFD
		public unsafe TextMeshProUGUI m_playerRating
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerRating);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerRating), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06002693 RID: 9875 RVA: 0x0008D8C8 File Offset: 0x0008BAC8
		// (set) Token: 0x06002694 RID: 9876 RVA: 0x00017D1C File Offset: 0x00015F1C
		public unsafe GameObject m_playerRatingObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerRatingObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerRatingObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06002695 RID: 9877 RVA: 0x0008D8F8 File Offset: 0x0008BAF8
		// (set) Token: 0x06002696 RID: 9878 RVA: 0x00017D3B File Offset: 0x00015F3B
		public unsafe GameObject m_playerTimerObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerTimerObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerTimerObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06002697 RID: 9879 RVA: 0x0008D928 File Offset: 0x0008BB28
		// (set) Token: 0x06002698 RID: 9880 RVA: 0x00017D5A File Offset: 0x00015F5A
		public unsafe GameObject m_activePlayerObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_activePlayerObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_activePlayerObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06002699 RID: 9881 RVA: 0x0008D958 File Offset: 0x0008BB58
		// (set) Token: 0x0600269A RID: 9882 RVA: 0x00017D79 File Offset: 0x00015F79
		public unsafe GameObject m_playerStatusIndicatorRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerStatusIndicatorRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerStatusIndicatorRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x0600269B RID: 9883 RVA: 0x0008D988 File Offset: 0x0008BB88
		// (set) Token: 0x0600269C RID: 9884 RVA: 0x00017D98 File Offset: 0x00015F98
		public unsafe Image m_playerStatusIndicatorImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerStatusIndicatorImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.PlayerInfoGameObjects.NativeFieldInfoPtr_m_playerStatusIndicatorImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AA7 RID: 6823
		private static readonly IntPtr NativeFieldInfoPtr_m_playerRootObj;

		// Token: 0x04001AA8 RID: 6824
		private static readonly IntPtr NativeFieldInfoPtr_m_playerText;

		// Token: 0x04001AA9 RID: 6825
		private static readonly IntPtr NativeFieldInfoPtr_m_playerRating;

		// Token: 0x04001AAA RID: 6826
		private static readonly IntPtr NativeFieldInfoPtr_m_playerRatingObj;

		// Token: 0x04001AAB RID: 6827
		private static readonly IntPtr NativeFieldInfoPtr_m_playerTimerObj;

		// Token: 0x04001AAC RID: 6828
		private static readonly IntPtr NativeFieldInfoPtr_m_activePlayerObject;

		// Token: 0x04001AAD RID: 6829
		private static readonly IntPtr NativeFieldInfoPtr_m_playerStatusIndicatorRoot;

		// Token: 0x04001AAE RID: 6830
		private static readonly IntPtr NativeFieldInfoPtr_m_playerStatusIndicatorImage;
	}

	// Token: 0x020001D0 RID: 464
	[Serializable]
	public sealed class SetIcon : ValueType
	{
		// Token: 0x0600269D RID: 9885 RVA: 0x0008D9B8 File Offset: 0x0008BBB8
		// Note: this type is marked as 'beforefieldinit'.
		static SetIcon()
		{
			Il2CppClassPointerStore<UIP_GameSlot.SetIcon>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "SetIcon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIP_GameSlot.SetIcon>.NativeClassPtr);
			UIP_GameSlot.SetIcon.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot.SetIcon>.NativeClassPtr, "root");
			UIP_GameSlot.SetIcon.NativeFieldInfoPtr_lockIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot.SetIcon>.NativeClassPtr, "lockIcon");
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x00017DB7 File Offset: 0x00015FB7
		public SetIcon(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x00017DC0 File Offset: 0x00015FC0
		public SetIcon()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIP_GameSlot.SetIcon>.NativeClassPtr))
		{
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x060026A0 RID: 9888 RVA: 0x0008DA0C File Offset: 0x0008BC0C
		// (set) Token: 0x060026A1 RID: 9889 RVA: 0x00017DD2 File Offset: 0x00015FD2
		public unsafe GameObject root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.SetIcon.NativeFieldInfoPtr_root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.SetIcon.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x060026A2 RID: 9890 RVA: 0x0008DA3C File Offset: 0x0008BC3C
		// (set) Token: 0x060026A3 RID: 9891 RVA: 0x00017DF1 File Offset: 0x00015FF1
		public unsafe GameObject lockIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.SetIcon.NativeFieldInfoPtr_lockIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot.SetIcon.NativeFieldInfoPtr_lockIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AAF RID: 6831
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x04001AB0 RID: 6832
		private static readonly IntPtr NativeFieldInfoPtr_lockIcon;
	}

	// Token: 0x020001D1 RID: 465
	[ObfuscatedName("UIP_GameSlot+<ProcessMatchmakingExpireTimer>d__94")]
	public sealed class _ProcessMatchmakingExpireTimer_d__94 : global::Il2CppSystem.Object
	{
		// Token: 0x060026A4 RID: 9892 RVA: 0x0008DA6C File Offset: 0x0008BC6C
		// Note: this type is marked as 'beforefieldinit'.
		static _ProcessMatchmakingExpireTimer_d__94()
		{
			Il2CppClassPointerStore<UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIP_GameSlot>.NativeClassPtr, "<ProcessMatchmakingExpireTimer>d__94");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94>.NativeClassPtr);
			UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94>.NativeClassPtr, "<>1__state");
			UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94>.NativeClassPtr, "<>2__current");
			UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94>.NativeClassPtr, "<>4__this");
			UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeFieldInfoPtr__accumulatedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94>.NativeClassPtr, "<accumulatedTime>5__2");
			UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeFieldInfoPtr__previousTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94>.NativeClassPtr, "<previousTime>5__3");
			UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94>.NativeClassPtr, 100666354);
			UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94>.NativeClassPtr, 100666355);
			UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94>.NativeClassPtr, 100666356);
			UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94>.NativeClassPtr, 100666357);
			UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94>.NativeClassPtr, 100666358);
			UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94>.NativeClassPtr, 100666359);
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x0008DB74 File Offset: 0x0008BD74
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ProcessMatchmakingExpireTimer_d__94(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x0008DBBC File Offset: 0x0008BDBC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x0008DBF0 File Offset: 0x0008BDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247087, XrefRangeEnd = 247094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x060026A8 RID: 9896 RVA: 0x0008DC2C File Offset: 0x0008BE2C
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x0008DC6C File Offset: 0x0008BE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247094, XrefRangeEnd = 247099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x060026AA RID: 9898 RVA: 0x0008DCA0 File Offset: 0x0008BEA0
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x00017E10 File Offset: 0x00016010
		public _ProcessMatchmakingExpireTimer_d__94(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x060026AC RID: 9900 RVA: 0x0008DCE0 File Offset: 0x0008BEE0
		// (set) Token: 0x060026AD RID: 9901 RVA: 0x00017E19 File Offset: 0x00016019
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x060026AE RID: 9902 RVA: 0x0008DD08 File Offset: 0x0008BF08
		// (set) Token: 0x060026AF RID: 9903 RVA: 0x00017E34 File Offset: 0x00016034
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x060026B0 RID: 9904 RVA: 0x0008DD38 File Offset: 0x0008BF38
		// (set) Token: 0x060026B1 RID: 9905 RVA: 0x00017E53 File Offset: 0x00016053
		public unsafe UIP_GameSlot __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIP_GameSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x060026B2 RID: 9906 RVA: 0x0008DD68 File Offset: 0x0008BF68
		// (set) Token: 0x060026B3 RID: 9907 RVA: 0x00017E72 File Offset: 0x00016072
		public unsafe float _accumulatedTime_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeFieldInfoPtr__accumulatedTime_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeFieldInfoPtr__accumulatedTime_5__2)) = value;
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x060026B4 RID: 9908 RVA: 0x0008DD90 File Offset: 0x0008BF90
		// (set) Token: 0x060026B5 RID: 9909 RVA: 0x00017E8D File Offset: 0x0001608D
		public unsafe float _previousTime_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeFieldInfoPtr__previousTime_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_GameSlot._ProcessMatchmakingExpireTimer_d__94.NativeFieldInfoPtr__previousTime_5__3)) = value;
			}
		}

		// Token: 0x04001AB1 RID: 6833
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001AB2 RID: 6834
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001AB3 RID: 6835
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001AB4 RID: 6836
		private static readonly IntPtr NativeFieldInfoPtr__accumulatedTime_5__2;

		// Token: 0x04001AB5 RID: 6837
		private static readonly IntPtr NativeFieldInfoPtr__previousTime_5__3;

		// Token: 0x04001AB6 RID: 6838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001AB7 RID: 6839
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001AB8 RID: 6840
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001AB9 RID: 6841
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001ABA RID: 6842
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001ABB RID: 6843
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

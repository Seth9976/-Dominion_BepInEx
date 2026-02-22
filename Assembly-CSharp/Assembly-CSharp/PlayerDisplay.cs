using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200003A RID: 58
public class PlayerDisplay : MonoBehaviour
{
	// Token: 0x060009F0 RID: 2544 RVA: 0x00037610 File Offset: 0x00035810
	// Note: this type is marked as 'beforefieldinit'.
	static PlayerDisplay()
	{
		Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PlayerDisplay");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr);
		PlayerDisplay.NativeFieldInfoPtr_m_AnimationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_AnimationManager");
		PlayerDisplay.NativeFieldInfoPtr_m_CardManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_CardManager");
		PlayerDisplay.NativeFieldInfoPtr_m_DragManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_DragManager");
		PlayerDisplay.NativeFieldInfoPtr_m_PlayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_PlayerIndex");
		PlayerDisplay.NativeFieldInfoPtr_m_PlayerInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_PlayerInstanceID");
		PlayerDisplay.NativeFieldInfoPtr_m_PlayerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_PlayerName");
		PlayerDisplay.NativeFieldInfoPtr_m_TextPlayerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_TextPlayerName");
		PlayerDisplay.NativeFieldInfoPtr_m_playerAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_playerAvatar");
		PlayerDisplay.NativeFieldInfoPtr_m_playerAvatarAI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_playerAvatarAI");
		PlayerDisplay.NativeFieldInfoPtr_m_thinkingAI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_thinkingAI");
		PlayerDisplay.NativeFieldInfoPtr_m_TextHonorPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_TextHonorPoints");
		PlayerDisplay.NativeFieldInfoPtr_m_TextConstructCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_TextConstructCount");
		PlayerDisplay.NativeFieldInfoPtr_m_TextHandCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_TextHandCount");
		PlayerDisplay.NativeFieldInfoPtr_m_TextDrawPileCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_TextDrawPileCount");
		PlayerDisplay.NativeFieldInfoPtr_m_TextDiscardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_TextDiscardCount");
		PlayerDisplay.NativeFieldInfoPtr_m_DreamscapeCountDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_DreamscapeCountDisplay");
		PlayerDisplay.NativeFieldInfoPtr_m_TextDreamscapeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_TextDreamscapeCount");
		PlayerDisplay.NativeFieldInfoPtr_m_InsightDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_InsightDisplay");
		PlayerDisplay.NativeFieldInfoPtr_m_TextInsightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_TextInsightCount");
		PlayerDisplay.NativeFieldInfoPtr_m_ReputationDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_ReputationDisplay");
		PlayerDisplay.NativeFieldInfoPtr_m_ReputationDisplayGeneric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_ReputationDisplayGeneric");
		PlayerDisplay.NativeFieldInfoPtr_m_TextReputationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_TextReputationLevel");
		PlayerDisplay.NativeFieldInfoPtr_m_ReputationDisplayEnlightened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_ReputationDisplayEnlightened");
		PlayerDisplay.NativeFieldInfoPtr_m_TextReputationLevelEnlightened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_TextReputationLevelEnlightened");
		PlayerDisplay.NativeFieldInfoPtr_m_ReputationDisplayLifebound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_ReputationDisplayLifebound");
		PlayerDisplay.NativeFieldInfoPtr_m_TextReputationLevelLifebound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_TextReputationLevelLifebound");
		PlayerDisplay.NativeFieldInfoPtr_m_ReputationDisplayMechana = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_ReputationDisplayMechana");
		PlayerDisplay.NativeFieldInfoPtr_m_TextReputationLevelMechana = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_TextReputationLevelMechana");
		PlayerDisplay.NativeFieldInfoPtr_m_ReputationDisplayVoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_ReputationDisplayVoid");
		PlayerDisplay.NativeFieldInfoPtr_m_TextReputationLevelVoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_TextReputationLevelVoid");
		PlayerDisplay.NativeFieldInfoPtr_m_TurnPlayerGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_TurnPlayerGlow");
		PlayerDisplay.NativeFieldInfoPtr_m_LastPlayerGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_LastPlayerGlow");
		PlayerDisplay.NativeFieldInfoPtr_m_LocatorHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_LocatorHand");
		PlayerDisplay.NativeFieldInfoPtr_m_LocatorDrawPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_LocatorDrawPile");
		PlayerDisplay.NativeFieldInfoPtr_m_LocatorDiscardPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_LocatorDiscardPile");
		PlayerDisplay.NativeFieldInfoPtr_m_LocatorDiscardTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_LocatorDiscardTray");
		PlayerDisplay.NativeFieldInfoPtr_m_LocatorConstructIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_LocatorConstructIcon");
		PlayerDisplay.NativeFieldInfoPtr_m_LocatorConstructTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_LocatorConstructTray");
		PlayerDisplay.NativeFieldInfoPtr_m_LocatorDreamscapePile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_LocatorDreamscapePile");
		PlayerDisplay.NativeFieldInfoPtr_m_LocatorDreamscapeTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_LocatorDreamscapeTray");
		PlayerDisplay.NativeFieldInfoPtr_m_LocatorOwnedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_LocatorOwnedList");
		PlayerDisplay.NativeFieldInfoPtr_m_LocatorAnnounceConstruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_LocatorAnnounceConstruct");
		PlayerDisplay.NativeFieldInfoPtr_m_LocatorAnnounceDiscard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_LocatorAnnounceDiscard");
		PlayerDisplay.NativeFieldInfoPtr_m_DragDrawPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_DragDrawPile");
		PlayerDisplay.NativeFieldInfoPtr_m_ResourceLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_ResourceLocations");
		PlayerDisplay.NativeFieldInfoPtr_m_NodeOnlineTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_NodeOnlineTimer");
		PlayerDisplay.NativeFieldInfoPtr_m_TextOnlineTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_TextOnlineTimer");
		PlayerDisplay.NativeFieldInfoPtr_m_OnlineStatusObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_OnlineStatusObj");
		PlayerDisplay.NativeFieldInfoPtr_m_OnlineStatusImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_OnlineStatusImage");
		PlayerDisplay.NativeFieldInfoPtr_m_OnlineStatusImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_OnlineStatusImages");
		PlayerDisplay.NativeFieldInfoPtr_m_ConstructTrayButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_ConstructTrayButton");
		PlayerDisplay.NativeFieldInfoPtr_m_OppConstructButtonGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_OppConstructButtonGlow");
		PlayerDisplay.NativeFieldInfoPtr_m_OppDiscardButtonGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_OppDiscardButtonGlow");
		PlayerDisplay.NativeFieldInfoPtr_m_OppLogButtonGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_OppLogButtonGlow");
		PlayerDisplay.NativeFieldInfoPtr_m_OppConstructTrayObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_OppConstructTrayObj");
		PlayerDisplay.NativeFieldInfoPtr_m_OppDiscardTrayObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_OppDiscardTrayObj");
		PlayerDisplay.NativeFieldInfoPtr_m_OppLogTrayObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_OppLogTrayObj");
		PlayerDisplay.NativeFieldInfoPtr_k_maxDataSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "k_maxDataSize");
		PlayerDisplay.NativeFieldInfoPtr_k_maxCardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "k_maxCardCount");
		PlayerDisplay.NativeFieldInfoPtr_k_maxQueryCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "k_maxQueryCount");
		PlayerDisplay.NativeFieldInfoPtr_m_PlayerDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_PlayerDataBuffer");
		PlayerDisplay.NativeFieldInfoPtr_m_PlayerDataHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_PlayerDataHandle");
		PlayerDisplay.NativeFieldInfoPtr_m_CurrentScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_CurrentScore");
		PlayerDisplay.NativeFieldInfoPtr_m_DreamscapeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_DreamscapeCount");
		PlayerDisplay.NativeFieldInfoPtr_m_bShowDreamscape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_bShowDreamscape");
		PlayerDisplay.NativeFieldInfoPtr_m_bShowInsight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_bShowInsight");
		PlayerDisplay.NativeFieldInfoPtr_m_DisplayedHonorPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_DisplayedHonorPoints");
		PlayerDisplay.NativeFieldInfoPtr_m_DisplayedConstructCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_DisplayedConstructCount");
		PlayerDisplay.NativeFieldInfoPtr_m_DisplayedHandCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_DisplayedHandCount");
		PlayerDisplay.NativeFieldInfoPtr_m_DisplayedDrawPileCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_DisplayedDrawPileCount");
		PlayerDisplay.NativeFieldInfoPtr_m_DisplayedDiscardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_DisplayedDiscardCount");
		PlayerDisplay.NativeFieldInfoPtr_m_DisplayedDreamscapeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_DisplayedDreamscapeCount");
		PlayerDisplay.NativeFieldInfoPtr_m_DisplayedInsightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_DisplayedInsightCount");
		PlayerDisplay.NativeFieldInfoPtr_m_DisplayedReputationLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_DisplayedReputationLevel");
		PlayerDisplay.NativeFieldInfoPtr_m_OwnedCardList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_OwnedCardList");
		PlayerDisplay.NativeFieldInfoPtr_m_QueryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "m_QueryBuffer");
		PlayerDisplay.NativeMethodInfoPtr_RegisterEventHandlers_Public_Void_GameEventBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100663992);
		PlayerDisplay.NativeMethodInfoPtr_GetPlayerIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100663993);
		PlayerDisplay.NativeMethodInfoPtr_GetPlayerInstanceID_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100663994);
		PlayerDisplay.NativeMethodInfoPtr_GetPlayerCurrentScore_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100663995);
		PlayerDisplay.NativeMethodInfoPtr_GetPlayerDreamscapeCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100663996);
		PlayerDisplay.NativeMethodInfoPtr_InvokeConstructTray_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100663997);
		PlayerDisplay.NativeMethodInfoPtr_SetPlayerIndex_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100663998);
		PlayerDisplay.NativeMethodInfoPtr_GetPlayerName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100663999);
		PlayerDisplay.NativeMethodInfoPtr_SetPlayerName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664000);
		PlayerDisplay.NativeMethodInfoPtr_GetAvatarIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664001);
		PlayerDisplay.NativeMethodInfoPtr_SetAvatar_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664002);
		PlayerDisplay.NativeMethodInfoPtr_GetHonorString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664003);
		PlayerDisplay.NativeMethodInfoPtr_HidePlayerHand_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664004);
		PlayerDisplay.NativeMethodInfoPtr_FindCardInPlayerHandByName_Public_AscensionCard_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664005);
		PlayerDisplay.NativeMethodInfoPtr_GetResourceLocation_Public_GameObject_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664006);
		PlayerDisplay.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664007);
		PlayerDisplay.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664008);
		PlayerDisplay.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664009);
		PlayerDisplay.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664010);
		PlayerDisplay.NativeMethodInfoPtr_UpdateDreamscapeDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664011);
		PlayerDisplay.NativeMethodInfoPtr_UpdatePlayerDisplay_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664012);
		PlayerDisplay.NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664013);
		PlayerDisplay.NativeMethodInfoPtr_UpdateOppTrayButtonGlows_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664014);
		PlayerDisplay.NativeMethodInfoPtr_GetIfHasSelectableCardInPlay_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664015);
		PlayerDisplay.NativeMethodInfoPtr_PutCardInPlay_Public_Void_AscensionCardInPlay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664016);
		PlayerDisplay.NativeMethodInfoPtr_ResetDiscardTray_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664017);
		PlayerDisplay.NativeMethodInfoPtr_CreateOwnedCard_Private_AscensionCard_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664018);
		PlayerDisplay.NativeMethodInfoPtr_HandleAddOwnedCard_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664019);
		PlayerDisplay.NativeMethodInfoPtr_HandleRemoveOwnedCard_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664020);
		PlayerDisplay.NativeMethodInfoPtr_RebuildPlayerOwnedList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664021);
		PlayerDisplay.NativeMethodInfoPtr_RebuildPlayerHandList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664022);
		PlayerDisplay.NativeMethodInfoPtr_RebuildPlayerDiscardList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664023);
		PlayerDisplay.NativeMethodInfoPtr_RebuildPlayerDreamscapeList_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664024);
		PlayerDisplay.NativeMethodInfoPtr_RebuildInterface_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664025);
		PlayerDisplay.NativeMethodInfoPtr_RebuildAnimationManager_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664026);
		PlayerDisplay.NativeMethodInfoPtr_SetPlayerOnlineTimer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664027);
		PlayerDisplay.NativeMethodInfoPtr_UpdateOnlineStatus_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664028);
		PlayerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, 100664029);
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x00037F28 File Offset: 0x00036128
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236218, RefRangeEnd = 236219, XrefRangeStart = 236198, XrefRangeEnd = 236218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterEventHandlers(GameEventBuffer game_event_buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(game_event_buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_RegisterEventHandlers_Public_Void_GameEventBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x00037F6C File Offset: 0x0003616C
	[CallerCount(0)]
	public unsafe int GetPlayerIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_GetPlayerIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x00037FA8 File Offset: 0x000361A8
	[CallerCount(0)]
	public unsafe int GetPlayerInstanceID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_GetPlayerInstanceID_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x00037FE4 File Offset: 0x000361E4
	[CallerCount(0)]
	public unsafe int GetPlayerCurrentScore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_GetPlayerCurrentScore_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x00038020 File Offset: 0x00036220
	[CallerCount(0)]
	public unsafe int GetPlayerDreamscapeCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_GetPlayerDreamscapeCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x0003805C File Offset: 0x0003625C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236224, RefRangeEnd = 236225, XrefRangeStart = 236219, XrefRangeEnd = 236224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InvokeConstructTray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_InvokeConstructTray_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x00038090 File Offset: 0x00036290
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 236240, RefRangeEnd = 236243, XrefRangeStart = 236225, XrefRangeEnd = 236240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPlayerIndex(int player_index, int player_instance_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref player_index;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref player_instance_id;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_SetPlayerIndex_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x000380DC File Offset: 0x000362DC
	[CallerCount(0)]
	public unsafe string GetPlayerName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_GetPlayerName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x00038114 File Offset: 0x00036314
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236247, RefRangeEnd = 236248, XrefRangeStart = 236243, XrefRangeEnd = 236247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPlayerName(string player_name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(player_name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_SetPlayerName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x00038158 File Offset: 0x00036358
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 236252, RefRangeEnd = 236255, XrefRangeStart = 236248, XrefRangeEnd = 236252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetAvatarIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_GetAvatarIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x00038194 File Offset: 0x00036394
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236264, RefRangeEnd = 236265, XrefRangeStart = 236255, XrefRangeEnd = 236264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAvatar(int avatarIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref avatarIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_SetAvatar_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x000381D4 File Offset: 0x000363D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236265, XrefRangeEnd = 236271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetHonorString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_GetHonorString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x0003820C File Offset: 0x0003640C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 236276, RefRangeEnd = 236278, XrefRangeStart = 236271, XrefRangeEnd = 236276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HidePlayerHand(bool bHidden)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bHidden;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_HidePlayerHand_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x0003824C File Offset: 0x0003644C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236300, RefRangeEnd = 236301, XrefRangeStart = 236278, XrefRangeEnd = 236300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionCard FindCardInPlayerHandByName(string card_name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_FindCardInPlayerHandByName_Public_AscensionCard_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AscensionCard>(intPtr3) : null;
		}
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x0003829C File Offset: 0x0003649C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 236301, RefRangeEnd = 236303, XrefRangeStart = 236301, XrefRangeEnd = 236301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetResourceLocation(uint resource_type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref resource_type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_GetResourceLocation_Public_GameObject_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x000382E8 File Offset: 0x000364E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236303, XrefRangeEnd = 236320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x0003831C File Offset: 0x0003651C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236320, XrefRangeEnd = 236326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x00038350 File Offset: 0x00036550
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236326, XrefRangeEnd = 236327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x00038384 File Offset: 0x00036584
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236327, XrefRangeEnd = 236333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x000383B8 File Offset: 0x000365B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236333, XrefRangeEnd = 236370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDreamscapeDisplay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_UpdateDreamscapeDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x000383EC File Offset: 0x000365EC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 236569, RefRangeEnd = 236571, XrefRangeStart = 236370, XrefRangeEnd = 236569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePlayerDisplay(bool bCheckCards)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bCheckCards;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_UpdatePlayerDisplay_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x0003842C File Offset: 0x0003662C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236576, RefRangeEnd = 236577, XrefRangeStart = 236571, XrefRangeEnd = 236576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSelectionState(bool bHighlight, bool bExcludeIfAnimating = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bHighlight;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bExcludeIfAnimating;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x00038478 File Offset: 0x00036678
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236601, RefRangeEnd = 236602, XrefRangeStart = 236577, XrefRangeEnd = 236601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateOppTrayButtonGlows(bool bforceOff)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bforceOff;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_UpdateOppTrayButtonGlows_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A08 RID: 2568 RVA: 0x000384B8 File Offset: 0x000366B8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236616, RefRangeEnd = 236617, XrefRangeStart = 236602, XrefRangeEnd = 236616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetIfHasSelectableCardInPlay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_GetIfHasSelectableCardInPlay_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x000384F4 File Offset: 0x000366F4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236625, RefRangeEnd = 236626, XrefRangeStart = 236617, XrefRangeEnd = 236625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PutCardInPlay(AscensionCardInPlay cardinplay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardinplay);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_PutCardInPlay_Public_Void_AscensionCardInPlay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x00038538 File Offset: 0x00036738
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236647, RefRangeEnd = 236648, XrefRangeStart = 236626, XrefRangeEnd = 236647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetDiscardTray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_ResetDiscardTray_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x0003856C File Offset: 0x0003676C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 236676, RefRangeEnd = 236678, XrefRangeStart = 236648, XrefRangeEnd = 236676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionCard CreateOwnedCard(int owned_card_instance_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref owned_card_instance_id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_CreateOwnedCard_Private_AscensionCard_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AscensionCard>(intPtr3) : null;
		}
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x000385B8 File Offset: 0x000367B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236678, XrefRangeEnd = 236712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleAddOwnedCard(IntPtr event_buffer, GameEventFeedback event_feedback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref event_buffer;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(event_feedback);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_HandleAddOwnedCard_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x00038608 File Offset: 0x00036808
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236712, XrefRangeEnd = 236769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleRemoveOwnedCard(IntPtr event_buffer, GameEventFeedback event_feedback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref event_buffer;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(event_feedback);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_HandleRemoveOwnedCard_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x00038658 File Offset: 0x00036858
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236802, RefRangeEnd = 236803, XrefRangeStart = 236769, XrefRangeEnd = 236802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildPlayerOwnedList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_RebuildPlayerOwnedList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x0003868C File Offset: 0x0003688C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236843, RefRangeEnd = 236844, XrefRangeStart = 236803, XrefRangeEnd = 236843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildPlayerHandList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_RebuildPlayerHandList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A10 RID: 2576 RVA: 0x000386C0 File Offset: 0x000368C0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236884, RefRangeEnd = 236885, XrefRangeStart = 236844, XrefRangeEnd = 236884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildPlayerDiscardList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_RebuildPlayerDiscardList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x000386F4 File Offset: 0x000368F4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236942, RefRangeEnd = 236943, XrefRangeStart = 236885, XrefRangeEnd = 236942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildPlayerDreamscapeList(bool bGetUniqueCards)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bGetUniqueCards;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_RebuildPlayerDreamscapeList_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x00038734 File Offset: 0x00036934
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 236981, RefRangeEnd = 236983, XrefRangeStart = 236943, XrefRangeEnd = 236981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildInterface(bool bGetUniqueCards)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bGetUniqueCards;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_RebuildInterface_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x00038774 File Offset: 0x00036974
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 237018, RefRangeEnd = 237020, XrefRangeStart = 236983, XrefRangeEnd = 237018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildAnimationManager(bool bLocalPlayer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bLocalPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_RebuildAnimationManager_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x000387B4 File Offset: 0x000369B4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 237061, RefRangeEnd = 237062, XrefRangeStart = 237020, XrefRangeEnd = 237061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPlayerOnlineTimer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_SetPlayerOnlineTimer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x000387E8 File Offset: 0x000369E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237062, XrefRangeEnd = 237066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator UpdateOnlineStatus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr_UpdateOnlineStatus_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000A16 RID: 2582 RVA: 0x00038828 File Offset: 0x00036A28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237066, XrefRangeEnd = 237070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerDisplay()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A17 RID: 2583 RVA: 0x000080C4 File Offset: 0x000062C4
	public PlayerDisplay(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700036E RID: 878
	// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00038864 File Offset: 0x00036A64
	// (set) Token: 0x06000A19 RID: 2585 RVA: 0x000080CD File Offset: 0x000062CD
	public unsafe AscensionAnimationManager m_AnimationManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_AnimationManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_AnimationManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700036F RID: 879
	// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00038894 File Offset: 0x00036A94
	// (set) Token: 0x06000A1B RID: 2587 RVA: 0x000080EC File Offset: 0x000062EC
	public unsafe AscensionCardManager m_CardManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_CardManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCardManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_CardManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000370 RID: 880
	// (get) Token: 0x06000A1C RID: 2588 RVA: 0x000388C4 File Offset: 0x00036AC4
	// (set) Token: 0x06000A1D RID: 2589 RVA: 0x0000810B File Offset: 0x0000630B
	public unsafe DragManager m_DragManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DragManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DragManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DragManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000371 RID: 881
	// (get) Token: 0x06000A1E RID: 2590 RVA: 0x000388F4 File Offset: 0x00036AF4
	// (set) Token: 0x06000A1F RID: 2591 RVA: 0x0000812A File Offset: 0x0000632A
	public unsafe int m_PlayerIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_PlayerIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_PlayerIndex)) = value;
		}
	}

	// Token: 0x17000372 RID: 882
	// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0003891C File Offset: 0x00036B1C
	// (set) Token: 0x06000A21 RID: 2593 RVA: 0x00008145 File Offset: 0x00006345
	public unsafe int m_PlayerInstanceID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_PlayerInstanceID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_PlayerInstanceID)) = value;
		}
	}

	// Token: 0x17000373 RID: 883
	// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00038944 File Offset: 0x00036B44
	// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00008160 File Offset: 0x00006360
	public unsafe string m_PlayerName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_PlayerName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_PlayerName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000374 RID: 884
	// (get) Token: 0x06000A24 RID: 2596 RVA: 0x0003896C File Offset: 0x00036B6C
	// (set) Token: 0x06000A25 RID: 2597 RVA: 0x0000817F File Offset: 0x0000637F
	public unsafe TextMeshProUGUI m_TextPlayerName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextPlayerName);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextPlayerName), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000375 RID: 885
	// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0003899C File Offset: 0x00036B9C
	// (set) Token: 0x06000A27 RID: 2599 RVA: 0x0000819E File Offset: 0x0000639E
	public unsafe Avatar_UI m_playerAvatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_playerAvatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_playerAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000376 RID: 886
	// (get) Token: 0x06000A28 RID: 2600 RVA: 0x000389CC File Offset: 0x00036BCC
	// (set) Token: 0x06000A29 RID: 2601 RVA: 0x000081BD File Offset: 0x000063BD
	public unsafe Avatar_UI m_playerAvatarAI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_playerAvatarAI);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_playerAvatarAI), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000377 RID: 887
	// (get) Token: 0x06000A2A RID: 2602 RVA: 0x000389FC File Offset: 0x00036BFC
	// (set) Token: 0x06000A2B RID: 2603 RVA: 0x000081DC File Offset: 0x000063DC
	public unsafe Image m_thinkingAI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_thinkingAI);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_thinkingAI), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000378 RID: 888
	// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00038A2C File Offset: 0x00036C2C
	// (set) Token: 0x06000A2D RID: 2605 RVA: 0x000081FB File Offset: 0x000063FB
	public unsafe TextMeshProUGUI m_TextHonorPoints
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextHonorPoints);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextHonorPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000379 RID: 889
	// (get) Token: 0x06000A2E RID: 2606 RVA: 0x00038A5C File Offset: 0x00036C5C
	// (set) Token: 0x06000A2F RID: 2607 RVA: 0x0000821A File Offset: 0x0000641A
	public unsafe TextMeshProUGUI m_TextConstructCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextConstructCount);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextConstructCount), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700037A RID: 890
	// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00038A8C File Offset: 0x00036C8C
	// (set) Token: 0x06000A31 RID: 2609 RVA: 0x00008239 File Offset: 0x00006439
	public unsafe TextMeshProUGUI m_TextHandCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextHandCount);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextHandCount), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700037B RID: 891
	// (get) Token: 0x06000A32 RID: 2610 RVA: 0x00038ABC File Offset: 0x00036CBC
	// (set) Token: 0x06000A33 RID: 2611 RVA: 0x00008258 File Offset: 0x00006458
	public unsafe TextMeshProUGUI m_TextDrawPileCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextDrawPileCount);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextDrawPileCount), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700037C RID: 892
	// (get) Token: 0x06000A34 RID: 2612 RVA: 0x00038AEC File Offset: 0x00036CEC
	// (set) Token: 0x06000A35 RID: 2613 RVA: 0x00008277 File Offset: 0x00006477
	public unsafe TextMeshProUGUI m_TextDiscardCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextDiscardCount);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextDiscardCount), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700037D RID: 893
	// (get) Token: 0x06000A36 RID: 2614 RVA: 0x00038B1C File Offset: 0x00036D1C
	// (set) Token: 0x06000A37 RID: 2615 RVA: 0x00008296 File Offset: 0x00006496
	public unsafe GameObject m_DreamscapeCountDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DreamscapeCountDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DreamscapeCountDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700037E RID: 894
	// (get) Token: 0x06000A38 RID: 2616 RVA: 0x00038B4C File Offset: 0x00036D4C
	// (set) Token: 0x06000A39 RID: 2617 RVA: 0x000082B5 File Offset: 0x000064B5
	public unsafe TextMeshProUGUI m_TextDreamscapeCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextDreamscapeCount);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextDreamscapeCount), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700037F RID: 895
	// (get) Token: 0x06000A3A RID: 2618 RVA: 0x00038B7C File Offset: 0x00036D7C
	// (set) Token: 0x06000A3B RID: 2619 RVA: 0x000082D4 File Offset: 0x000064D4
	public unsafe GameObject m_InsightDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_InsightDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_InsightDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000380 RID: 896
	// (get) Token: 0x06000A3C RID: 2620 RVA: 0x00038BAC File Offset: 0x00036DAC
	// (set) Token: 0x06000A3D RID: 2621 RVA: 0x000082F3 File Offset: 0x000064F3
	public unsafe TextMeshProUGUI m_TextInsightCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextInsightCount);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextInsightCount), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000381 RID: 897
	// (get) Token: 0x06000A3E RID: 2622 RVA: 0x00038BDC File Offset: 0x00036DDC
	// (set) Token: 0x06000A3F RID: 2623 RVA: 0x00008312 File Offset: 0x00006512
	public unsafe GameObject m_ReputationDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_ReputationDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_ReputationDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000382 RID: 898
	// (get) Token: 0x06000A40 RID: 2624 RVA: 0x00038C0C File Offset: 0x00036E0C
	// (set) Token: 0x06000A41 RID: 2625 RVA: 0x00008331 File Offset: 0x00006531
	public unsafe GameObject m_ReputationDisplayGeneric
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_ReputationDisplayGeneric);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_ReputationDisplayGeneric), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000383 RID: 899
	// (get) Token: 0x06000A42 RID: 2626 RVA: 0x00038C3C File Offset: 0x00036E3C
	// (set) Token: 0x06000A43 RID: 2627 RVA: 0x00008350 File Offset: 0x00006550
	public unsafe TextMeshProUGUI m_TextReputationLevel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextReputationLevel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextReputationLevel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000384 RID: 900
	// (get) Token: 0x06000A44 RID: 2628 RVA: 0x00038C6C File Offset: 0x00036E6C
	// (set) Token: 0x06000A45 RID: 2629 RVA: 0x0000836F File Offset: 0x0000656F
	public unsafe GameObject m_ReputationDisplayEnlightened
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_ReputationDisplayEnlightened);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_ReputationDisplayEnlightened), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000385 RID: 901
	// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00038C9C File Offset: 0x00036E9C
	// (set) Token: 0x06000A47 RID: 2631 RVA: 0x0000838E File Offset: 0x0000658E
	public unsafe TextMeshProUGUI m_TextReputationLevelEnlightened
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextReputationLevelEnlightened);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextReputationLevelEnlightened), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000386 RID: 902
	// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00038CCC File Offset: 0x00036ECC
	// (set) Token: 0x06000A49 RID: 2633 RVA: 0x000083AD File Offset: 0x000065AD
	public unsafe GameObject m_ReputationDisplayLifebound
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_ReputationDisplayLifebound);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_ReputationDisplayLifebound), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000387 RID: 903
	// (get) Token: 0x06000A4A RID: 2634 RVA: 0x00038CFC File Offset: 0x00036EFC
	// (set) Token: 0x06000A4B RID: 2635 RVA: 0x000083CC File Offset: 0x000065CC
	public unsafe TextMeshProUGUI m_TextReputationLevelLifebound
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextReputationLevelLifebound);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextReputationLevelLifebound), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000388 RID: 904
	// (get) Token: 0x06000A4C RID: 2636 RVA: 0x00038D2C File Offset: 0x00036F2C
	// (set) Token: 0x06000A4D RID: 2637 RVA: 0x000083EB File Offset: 0x000065EB
	public unsafe GameObject m_ReputationDisplayMechana
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_ReputationDisplayMechana);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_ReputationDisplayMechana), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000389 RID: 905
	// (get) Token: 0x06000A4E RID: 2638 RVA: 0x00038D5C File Offset: 0x00036F5C
	// (set) Token: 0x06000A4F RID: 2639 RVA: 0x0000840A File Offset: 0x0000660A
	public unsafe TextMeshProUGUI m_TextReputationLevelMechana
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextReputationLevelMechana);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextReputationLevelMechana), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700038A RID: 906
	// (get) Token: 0x06000A50 RID: 2640 RVA: 0x00038D8C File Offset: 0x00036F8C
	// (set) Token: 0x06000A51 RID: 2641 RVA: 0x00008429 File Offset: 0x00006629
	public unsafe GameObject m_ReputationDisplayVoid
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_ReputationDisplayVoid);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_ReputationDisplayVoid), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700038B RID: 907
	// (get) Token: 0x06000A52 RID: 2642 RVA: 0x00038DBC File Offset: 0x00036FBC
	// (set) Token: 0x06000A53 RID: 2643 RVA: 0x00008448 File Offset: 0x00006648
	public unsafe TextMeshProUGUI m_TextReputationLevelVoid
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextReputationLevelVoid);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextReputationLevelVoid), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700038C RID: 908
	// (get) Token: 0x06000A54 RID: 2644 RVA: 0x00038DEC File Offset: 0x00036FEC
	// (set) Token: 0x06000A55 RID: 2645 RVA: 0x00008467 File Offset: 0x00006667
	public unsafe GameObject m_TurnPlayerGlow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TurnPlayerGlow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TurnPlayerGlow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700038D RID: 909
	// (get) Token: 0x06000A56 RID: 2646 RVA: 0x00038E1C File Offset: 0x0003701C
	// (set) Token: 0x06000A57 RID: 2647 RVA: 0x00008486 File Offset: 0x00006686
	public unsafe GameObject m_LastPlayerGlow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LastPlayerGlow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LastPlayerGlow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700038E RID: 910
	// (get) Token: 0x06000A58 RID: 2648 RVA: 0x00038E4C File Offset: 0x0003704C
	// (set) Token: 0x06000A59 RID: 2649 RVA: 0x000084A5 File Offset: 0x000066A5
	public unsafe AscensionAnimationLocator m_LocatorHand
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorHand);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorHand), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700038F RID: 911
	// (get) Token: 0x06000A5A RID: 2650 RVA: 0x00038E7C File Offset: 0x0003707C
	// (set) Token: 0x06000A5B RID: 2651 RVA: 0x000084C4 File Offset: 0x000066C4
	public unsafe AscensionAnimationLocator m_LocatorDrawPile
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorDrawPile);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorDrawPile), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000390 RID: 912
	// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00038EAC File Offset: 0x000370AC
	// (set) Token: 0x06000A5D RID: 2653 RVA: 0x000084E3 File Offset: 0x000066E3
	public unsafe AscensionAnimationLocator m_LocatorDiscardPile
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorDiscardPile);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorDiscardPile), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000391 RID: 913
	// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00038EDC File Offset: 0x000370DC
	// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00008502 File Offset: 0x00006702
	public unsafe AscensionAnimationLocator m_LocatorDiscardTray
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorDiscardTray);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorDiscardTray), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000392 RID: 914
	// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00038F0C File Offset: 0x0003710C
	// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00008521 File Offset: 0x00006721
	public unsafe AscensionAnimationLocator m_LocatorConstructIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorConstructIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorConstructIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000393 RID: 915
	// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00038F3C File Offset: 0x0003713C
	// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00008540 File Offset: 0x00006740
	public unsafe AscensionAnimationLocator m_LocatorConstructTray
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorConstructTray);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorConstructTray), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000394 RID: 916
	// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00038F6C File Offset: 0x0003716C
	// (set) Token: 0x06000A65 RID: 2661 RVA: 0x0000855F File Offset: 0x0000675F
	public unsafe AscensionAnimationLocator m_LocatorDreamscapePile
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorDreamscapePile);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorDreamscapePile), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000395 RID: 917
	// (get) Token: 0x06000A66 RID: 2662 RVA: 0x00038F9C File Offset: 0x0003719C
	// (set) Token: 0x06000A67 RID: 2663 RVA: 0x0000857E File Offset: 0x0000677E
	public unsafe AscensionAnimationLocator m_LocatorDreamscapeTray
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorDreamscapeTray);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorDreamscapeTray), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000396 RID: 918
	// (get) Token: 0x06000A68 RID: 2664 RVA: 0x00038FCC File Offset: 0x000371CC
	// (set) Token: 0x06000A69 RID: 2665 RVA: 0x0000859D File Offset: 0x0000679D
	public unsafe AscensionAnimationLocatorSorted m_LocatorOwnedList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorOwnedList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocatorSorted>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorOwnedList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000397 RID: 919
	// (get) Token: 0x06000A6A RID: 2666 RVA: 0x00038FFC File Offset: 0x000371FC
	// (set) Token: 0x06000A6B RID: 2667 RVA: 0x000085BC File Offset: 0x000067BC
	public unsafe AscensionAnimationLocator m_LocatorAnnounceConstruct
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorAnnounceConstruct);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorAnnounceConstruct), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000398 RID: 920
	// (get) Token: 0x06000A6C RID: 2668 RVA: 0x0003902C File Offset: 0x0003722C
	// (set) Token: 0x06000A6D RID: 2669 RVA: 0x000085DB File Offset: 0x000067DB
	public unsafe AscensionAnimationLocator m_LocatorAnnounceDiscard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorAnnounceDiscard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_LocatorAnnounceDiscard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000399 RID: 921
	// (get) Token: 0x06000A6E RID: 2670 RVA: 0x0003905C File Offset: 0x0003725C
	// (set) Token: 0x06000A6F RID: 2671 RVA: 0x000085FA File Offset: 0x000067FA
	public unsafe AscensionDrawPile m_DragDrawPile
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DragDrawPile);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionDrawPile>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DragDrawPile), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700039A RID: 922
	// (get) Token: 0x06000A70 RID: 2672 RVA: 0x0003908C File Offset: 0x0003728C
	// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00008619 File Offset: 0x00006819
	public unsafe Il2CppReferenceArray<GameObject> m_ResourceLocations
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_ResourceLocations);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_ResourceLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700039B RID: 923
	// (get) Token: 0x06000A72 RID: 2674 RVA: 0x000390BC File Offset: 0x000372BC
	// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00008638 File Offset: 0x00006838
	public unsafe GameObject m_NodeOnlineTimer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_NodeOnlineTimer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_NodeOnlineTimer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700039C RID: 924
	// (get) Token: 0x06000A74 RID: 2676 RVA: 0x000390EC File Offset: 0x000372EC
	// (set) Token: 0x06000A75 RID: 2677 RVA: 0x00008657 File Offset: 0x00006857
	public unsafe TextMeshProUGUI m_TextOnlineTimer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextOnlineTimer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_TextOnlineTimer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700039D RID: 925
	// (get) Token: 0x06000A76 RID: 2678 RVA: 0x0003911C File Offset: 0x0003731C
	// (set) Token: 0x06000A77 RID: 2679 RVA: 0x00008676 File Offset: 0x00006876
	public unsafe GameObject m_OnlineStatusObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OnlineStatusObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OnlineStatusObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700039E RID: 926
	// (get) Token: 0x06000A78 RID: 2680 RVA: 0x0003914C File Offset: 0x0003734C
	// (set) Token: 0x06000A79 RID: 2681 RVA: 0x00008695 File Offset: 0x00006895
	public unsafe Image m_OnlineStatusImage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OnlineStatusImage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OnlineStatusImage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700039F RID: 927
	// (get) Token: 0x06000A7A RID: 2682 RVA: 0x0003917C File Offset: 0x0003737C
	// (set) Token: 0x06000A7B RID: 2683 RVA: 0x000086B4 File Offset: 0x000068B4
	public unsafe Il2CppReferenceArray<Sprite> m_OnlineStatusImages
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OnlineStatusImages);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OnlineStatusImages), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003A0 RID: 928
	// (get) Token: 0x06000A7C RID: 2684 RVA: 0x000391AC File Offset: 0x000373AC
	// (set) Token: 0x06000A7D RID: 2685 RVA: 0x000086D3 File Offset: 0x000068D3
	public unsafe Button m_ConstructTrayButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_ConstructTrayButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_ConstructTrayButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003A1 RID: 929
	// (get) Token: 0x06000A7E RID: 2686 RVA: 0x000391DC File Offset: 0x000373DC
	// (set) Token: 0x06000A7F RID: 2687 RVA: 0x000086F2 File Offset: 0x000068F2
	public unsafe GameObject m_OppConstructButtonGlow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OppConstructButtonGlow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OppConstructButtonGlow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003A2 RID: 930
	// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0003920C File Offset: 0x0003740C
	// (set) Token: 0x06000A81 RID: 2689 RVA: 0x00008711 File Offset: 0x00006911
	public unsafe GameObject m_OppDiscardButtonGlow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OppDiscardButtonGlow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OppDiscardButtonGlow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003A3 RID: 931
	// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0003923C File Offset: 0x0003743C
	// (set) Token: 0x06000A83 RID: 2691 RVA: 0x00008730 File Offset: 0x00006930
	public unsafe GameObject m_OppLogButtonGlow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OppLogButtonGlow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OppLogButtonGlow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003A4 RID: 932
	// (get) Token: 0x06000A84 RID: 2692 RVA: 0x0003926C File Offset: 0x0003746C
	// (set) Token: 0x06000A85 RID: 2693 RVA: 0x0000874F File Offset: 0x0000694F
	public unsafe GameObject m_OppConstructTrayObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OppConstructTrayObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OppConstructTrayObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003A5 RID: 933
	// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0003929C File Offset: 0x0003749C
	// (set) Token: 0x06000A87 RID: 2695 RVA: 0x0000876E File Offset: 0x0000696E
	public unsafe GameObject m_OppDiscardTrayObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OppDiscardTrayObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OppDiscardTrayObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003A6 RID: 934
	// (get) Token: 0x06000A88 RID: 2696 RVA: 0x000392CC File Offset: 0x000374CC
	// (set) Token: 0x06000A89 RID: 2697 RVA: 0x0000878D File Offset: 0x0000698D
	public unsafe GameObject m_OppLogTrayObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OppLogTrayObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OppLogTrayObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003A7 RID: 935
	// (get) Token: 0x06000A8A RID: 2698 RVA: 0x000392FC File Offset: 0x000374FC
	// (set) Token: 0x06000A8B RID: 2699 RVA: 0x000087AC File Offset: 0x000069AC
	public unsafe static int k_maxDataSize
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(PlayerDisplay.NativeFieldInfoPtr_k_maxDataSize, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(PlayerDisplay.NativeFieldInfoPtr_k_maxDataSize, (void*)(&value));
		}
	}

	// Token: 0x170003A8 RID: 936
	// (get) Token: 0x06000A8C RID: 2700 RVA: 0x00039318 File Offset: 0x00037518
	// (set) Token: 0x06000A8D RID: 2701 RVA: 0x000087BA File Offset: 0x000069BA
	public unsafe static int k_maxCardCount
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(PlayerDisplay.NativeFieldInfoPtr_k_maxCardCount, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(PlayerDisplay.NativeFieldInfoPtr_k_maxCardCount, (void*)(&value));
		}
	}

	// Token: 0x170003A9 RID: 937
	// (get) Token: 0x06000A8E RID: 2702 RVA: 0x00039334 File Offset: 0x00037534
	// (set) Token: 0x06000A8F RID: 2703 RVA: 0x000087C8 File Offset: 0x000069C8
	public unsafe static int k_maxQueryCount
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(PlayerDisplay.NativeFieldInfoPtr_k_maxQueryCount, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(PlayerDisplay.NativeFieldInfoPtr_k_maxQueryCount, (void*)(&value));
		}
	}

	// Token: 0x170003AA RID: 938
	// (get) Token: 0x06000A90 RID: 2704 RVA: 0x00039350 File Offset: 0x00037550
	// (set) Token: 0x06000A91 RID: 2705 RVA: 0x000087D6 File Offset: 0x000069D6
	public unsafe Il2CppStructArray<byte> m_PlayerDataBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_PlayerDataBuffer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_PlayerDataBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003AB RID: 939
	// (get) Token: 0x06000A92 RID: 2706 RVA: 0x00039380 File Offset: 0x00037580
	// (set) Token: 0x06000A93 RID: 2707 RVA: 0x000087F5 File Offset: 0x000069F5
	public unsafe GCHandle m_PlayerDataHandle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_PlayerDataHandle);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_PlayerDataHandle)) = value;
		}
	}

	// Token: 0x170003AC RID: 940
	// (get) Token: 0x06000A94 RID: 2708 RVA: 0x000393A8 File Offset: 0x000375A8
	// (set) Token: 0x06000A95 RID: 2709 RVA: 0x00008810 File Offset: 0x00006A10
	public unsafe int m_CurrentScore
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_CurrentScore);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_CurrentScore)) = value;
		}
	}

	// Token: 0x170003AD RID: 941
	// (get) Token: 0x06000A96 RID: 2710 RVA: 0x000393D0 File Offset: 0x000375D0
	// (set) Token: 0x06000A97 RID: 2711 RVA: 0x0000882B File Offset: 0x00006A2B
	public unsafe int m_DreamscapeCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DreamscapeCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DreamscapeCount)) = value;
		}
	}

	// Token: 0x170003AE RID: 942
	// (get) Token: 0x06000A98 RID: 2712 RVA: 0x000393F8 File Offset: 0x000375F8
	// (set) Token: 0x06000A99 RID: 2713 RVA: 0x00008846 File Offset: 0x00006A46
	public unsafe bool m_bShowDreamscape
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_bShowDreamscape);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_bShowDreamscape)) = value;
		}
	}

	// Token: 0x170003AF RID: 943
	// (get) Token: 0x06000A9A RID: 2714 RVA: 0x00039420 File Offset: 0x00037620
	// (set) Token: 0x06000A9B RID: 2715 RVA: 0x00008861 File Offset: 0x00006A61
	public unsafe bool m_bShowInsight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_bShowInsight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_bShowInsight)) = value;
		}
	}

	// Token: 0x170003B0 RID: 944
	// (get) Token: 0x06000A9C RID: 2716 RVA: 0x00039448 File Offset: 0x00037648
	// (set) Token: 0x06000A9D RID: 2717 RVA: 0x0000887C File Offset: 0x00006A7C
	public unsafe int m_DisplayedHonorPoints
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DisplayedHonorPoints);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DisplayedHonorPoints)) = value;
		}
	}

	// Token: 0x170003B1 RID: 945
	// (get) Token: 0x06000A9E RID: 2718 RVA: 0x00039470 File Offset: 0x00037670
	// (set) Token: 0x06000A9F RID: 2719 RVA: 0x00008897 File Offset: 0x00006A97
	public unsafe int m_DisplayedConstructCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DisplayedConstructCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DisplayedConstructCount)) = value;
		}
	}

	// Token: 0x170003B2 RID: 946
	// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x00039498 File Offset: 0x00037698
	// (set) Token: 0x06000AA1 RID: 2721 RVA: 0x000088B2 File Offset: 0x00006AB2
	public unsafe int m_DisplayedHandCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DisplayedHandCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DisplayedHandCount)) = value;
		}
	}

	// Token: 0x170003B3 RID: 947
	// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x000394C0 File Offset: 0x000376C0
	// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x000088CD File Offset: 0x00006ACD
	public unsafe int m_DisplayedDrawPileCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DisplayedDrawPileCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DisplayedDrawPileCount)) = value;
		}
	}

	// Token: 0x170003B4 RID: 948
	// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x000394E8 File Offset: 0x000376E8
	// (set) Token: 0x06000AA5 RID: 2725 RVA: 0x000088E8 File Offset: 0x00006AE8
	public unsafe int m_DisplayedDiscardCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DisplayedDiscardCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DisplayedDiscardCount)) = value;
		}
	}

	// Token: 0x170003B5 RID: 949
	// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x00039510 File Offset: 0x00037710
	// (set) Token: 0x06000AA7 RID: 2727 RVA: 0x00008903 File Offset: 0x00006B03
	public unsafe int m_DisplayedDreamscapeCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DisplayedDreamscapeCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DisplayedDreamscapeCount)) = value;
		}
	}

	// Token: 0x170003B6 RID: 950
	// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x00039538 File Offset: 0x00037738
	// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x0000891E File Offset: 0x00006B1E
	public unsafe int m_DisplayedInsightCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DisplayedInsightCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DisplayedInsightCount)) = value;
		}
	}

	// Token: 0x170003B7 RID: 951
	// (get) Token: 0x06000AAA RID: 2730 RVA: 0x00039560 File Offset: 0x00037760
	// (set) Token: 0x06000AAB RID: 2731 RVA: 0x00008939 File Offset: 0x00006B39
	public unsafe int m_DisplayedReputationLevel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DisplayedReputationLevel);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_DisplayedReputationLevel)) = value;
		}
	}

	// Token: 0x170003B8 RID: 952
	// (get) Token: 0x06000AAC RID: 2732 RVA: 0x00039588 File Offset: 0x00037788
	// (set) Token: 0x06000AAD RID: 2733 RVA: 0x00008954 File Offset: 0x00006B54
	public unsafe List<AscensionCard> m_OwnedCardList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OwnedCardList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AscensionCard>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_OwnedCardList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003B9 RID: 953
	// (get) Token: 0x06000AAE RID: 2734 RVA: 0x000395B8 File Offset: 0x000377B8
	// (set) Token: 0x06000AAF RID: 2735 RVA: 0x00008973 File Offset: 0x00006B73
	public unsafe Il2CppStructArray<QueryCardState> m_QueryBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_QueryBuffer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<QueryCardState>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay.NativeFieldInfoPtr_m_QueryBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000630 RID: 1584
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimationManager;

	// Token: 0x04000631 RID: 1585
	private static readonly IntPtr NativeFieldInfoPtr_m_CardManager;

	// Token: 0x04000632 RID: 1586
	private static readonly IntPtr NativeFieldInfoPtr_m_DragManager;

	// Token: 0x04000633 RID: 1587
	private static readonly IntPtr NativeFieldInfoPtr_m_PlayerIndex;

	// Token: 0x04000634 RID: 1588
	private static readonly IntPtr NativeFieldInfoPtr_m_PlayerInstanceID;

	// Token: 0x04000635 RID: 1589
	private static readonly IntPtr NativeFieldInfoPtr_m_PlayerName;

	// Token: 0x04000636 RID: 1590
	private static readonly IntPtr NativeFieldInfoPtr_m_TextPlayerName;

	// Token: 0x04000637 RID: 1591
	private static readonly IntPtr NativeFieldInfoPtr_m_playerAvatar;

	// Token: 0x04000638 RID: 1592
	private static readonly IntPtr NativeFieldInfoPtr_m_playerAvatarAI;

	// Token: 0x04000639 RID: 1593
	private static readonly IntPtr NativeFieldInfoPtr_m_thinkingAI;

	// Token: 0x0400063A RID: 1594
	private static readonly IntPtr NativeFieldInfoPtr_m_TextHonorPoints;

	// Token: 0x0400063B RID: 1595
	private static readonly IntPtr NativeFieldInfoPtr_m_TextConstructCount;

	// Token: 0x0400063C RID: 1596
	private static readonly IntPtr NativeFieldInfoPtr_m_TextHandCount;

	// Token: 0x0400063D RID: 1597
	private static readonly IntPtr NativeFieldInfoPtr_m_TextDrawPileCount;

	// Token: 0x0400063E RID: 1598
	private static readonly IntPtr NativeFieldInfoPtr_m_TextDiscardCount;

	// Token: 0x0400063F RID: 1599
	private static readonly IntPtr NativeFieldInfoPtr_m_DreamscapeCountDisplay;

	// Token: 0x04000640 RID: 1600
	private static readonly IntPtr NativeFieldInfoPtr_m_TextDreamscapeCount;

	// Token: 0x04000641 RID: 1601
	private static readonly IntPtr NativeFieldInfoPtr_m_InsightDisplay;

	// Token: 0x04000642 RID: 1602
	private static readonly IntPtr NativeFieldInfoPtr_m_TextInsightCount;

	// Token: 0x04000643 RID: 1603
	private static readonly IntPtr NativeFieldInfoPtr_m_ReputationDisplay;

	// Token: 0x04000644 RID: 1604
	private static readonly IntPtr NativeFieldInfoPtr_m_ReputationDisplayGeneric;

	// Token: 0x04000645 RID: 1605
	private static readonly IntPtr NativeFieldInfoPtr_m_TextReputationLevel;

	// Token: 0x04000646 RID: 1606
	private static readonly IntPtr NativeFieldInfoPtr_m_ReputationDisplayEnlightened;

	// Token: 0x04000647 RID: 1607
	private static readonly IntPtr NativeFieldInfoPtr_m_TextReputationLevelEnlightened;

	// Token: 0x04000648 RID: 1608
	private static readonly IntPtr NativeFieldInfoPtr_m_ReputationDisplayLifebound;

	// Token: 0x04000649 RID: 1609
	private static readonly IntPtr NativeFieldInfoPtr_m_TextReputationLevelLifebound;

	// Token: 0x0400064A RID: 1610
	private static readonly IntPtr NativeFieldInfoPtr_m_ReputationDisplayMechana;

	// Token: 0x0400064B RID: 1611
	private static readonly IntPtr NativeFieldInfoPtr_m_TextReputationLevelMechana;

	// Token: 0x0400064C RID: 1612
	private static readonly IntPtr NativeFieldInfoPtr_m_ReputationDisplayVoid;

	// Token: 0x0400064D RID: 1613
	private static readonly IntPtr NativeFieldInfoPtr_m_TextReputationLevelVoid;

	// Token: 0x0400064E RID: 1614
	private static readonly IntPtr NativeFieldInfoPtr_m_TurnPlayerGlow;

	// Token: 0x0400064F RID: 1615
	private static readonly IntPtr NativeFieldInfoPtr_m_LastPlayerGlow;

	// Token: 0x04000650 RID: 1616
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorHand;

	// Token: 0x04000651 RID: 1617
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorDrawPile;

	// Token: 0x04000652 RID: 1618
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorDiscardPile;

	// Token: 0x04000653 RID: 1619
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorDiscardTray;

	// Token: 0x04000654 RID: 1620
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorConstructIcon;

	// Token: 0x04000655 RID: 1621
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorConstructTray;

	// Token: 0x04000656 RID: 1622
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorDreamscapePile;

	// Token: 0x04000657 RID: 1623
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorDreamscapeTray;

	// Token: 0x04000658 RID: 1624
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorOwnedList;

	// Token: 0x04000659 RID: 1625
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorAnnounceConstruct;

	// Token: 0x0400065A RID: 1626
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorAnnounceDiscard;

	// Token: 0x0400065B RID: 1627
	private static readonly IntPtr NativeFieldInfoPtr_m_DragDrawPile;

	// Token: 0x0400065C RID: 1628
	private static readonly IntPtr NativeFieldInfoPtr_m_ResourceLocations;

	// Token: 0x0400065D RID: 1629
	private static readonly IntPtr NativeFieldInfoPtr_m_NodeOnlineTimer;

	// Token: 0x0400065E RID: 1630
	private static readonly IntPtr NativeFieldInfoPtr_m_TextOnlineTimer;

	// Token: 0x0400065F RID: 1631
	private static readonly IntPtr NativeFieldInfoPtr_m_OnlineStatusObj;

	// Token: 0x04000660 RID: 1632
	private static readonly IntPtr NativeFieldInfoPtr_m_OnlineStatusImage;

	// Token: 0x04000661 RID: 1633
	private static readonly IntPtr NativeFieldInfoPtr_m_OnlineStatusImages;

	// Token: 0x04000662 RID: 1634
	private static readonly IntPtr NativeFieldInfoPtr_m_ConstructTrayButton;

	// Token: 0x04000663 RID: 1635
	private static readonly IntPtr NativeFieldInfoPtr_m_OppConstructButtonGlow;

	// Token: 0x04000664 RID: 1636
	private static readonly IntPtr NativeFieldInfoPtr_m_OppDiscardButtonGlow;

	// Token: 0x04000665 RID: 1637
	private static readonly IntPtr NativeFieldInfoPtr_m_OppLogButtonGlow;

	// Token: 0x04000666 RID: 1638
	private static readonly IntPtr NativeFieldInfoPtr_m_OppConstructTrayObj;

	// Token: 0x04000667 RID: 1639
	private static readonly IntPtr NativeFieldInfoPtr_m_OppDiscardTrayObj;

	// Token: 0x04000668 RID: 1640
	private static readonly IntPtr NativeFieldInfoPtr_m_OppLogTrayObj;

	// Token: 0x04000669 RID: 1641
	private static readonly IntPtr NativeFieldInfoPtr_k_maxDataSize;

	// Token: 0x0400066A RID: 1642
	private static readonly IntPtr NativeFieldInfoPtr_k_maxCardCount;

	// Token: 0x0400066B RID: 1643
	private static readonly IntPtr NativeFieldInfoPtr_k_maxQueryCount;

	// Token: 0x0400066C RID: 1644
	private static readonly IntPtr NativeFieldInfoPtr_m_PlayerDataBuffer;

	// Token: 0x0400066D RID: 1645
	private static readonly IntPtr NativeFieldInfoPtr_m_PlayerDataHandle;

	// Token: 0x0400066E RID: 1646
	private static readonly IntPtr NativeFieldInfoPtr_m_CurrentScore;

	// Token: 0x0400066F RID: 1647
	private static readonly IntPtr NativeFieldInfoPtr_m_DreamscapeCount;

	// Token: 0x04000670 RID: 1648
	private static readonly IntPtr NativeFieldInfoPtr_m_bShowDreamscape;

	// Token: 0x04000671 RID: 1649
	private static readonly IntPtr NativeFieldInfoPtr_m_bShowInsight;

	// Token: 0x04000672 RID: 1650
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedHonorPoints;

	// Token: 0x04000673 RID: 1651
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedConstructCount;

	// Token: 0x04000674 RID: 1652
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedHandCount;

	// Token: 0x04000675 RID: 1653
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedDrawPileCount;

	// Token: 0x04000676 RID: 1654
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedDiscardCount;

	// Token: 0x04000677 RID: 1655
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedDreamscapeCount;

	// Token: 0x04000678 RID: 1656
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedInsightCount;

	// Token: 0x04000679 RID: 1657
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedReputationLevel;

	// Token: 0x0400067A RID: 1658
	private static readonly IntPtr NativeFieldInfoPtr_m_OwnedCardList;

	// Token: 0x0400067B RID: 1659
	private static readonly IntPtr NativeFieldInfoPtr_m_QueryBuffer;

	// Token: 0x0400067C RID: 1660
	private static readonly IntPtr NativeMethodInfoPtr_RegisterEventHandlers_Public_Void_GameEventBuffer_0;

	// Token: 0x0400067D RID: 1661
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayerIndex_Public_Int32_0;

	// Token: 0x0400067E RID: 1662
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayerInstanceID_Public_Int32_0;

	// Token: 0x0400067F RID: 1663
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayerCurrentScore_Public_Int32_0;

	// Token: 0x04000680 RID: 1664
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayerDreamscapeCount_Public_Int32_0;

	// Token: 0x04000681 RID: 1665
	private static readonly IntPtr NativeMethodInfoPtr_InvokeConstructTray_Public_Void_0;

	// Token: 0x04000682 RID: 1666
	private static readonly IntPtr NativeMethodInfoPtr_SetPlayerIndex_Public_Void_Int32_Int32_0;

	// Token: 0x04000683 RID: 1667
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayerName_Public_String_0;

	// Token: 0x04000684 RID: 1668
	private static readonly IntPtr NativeMethodInfoPtr_SetPlayerName_Public_Void_String_0;

	// Token: 0x04000685 RID: 1669
	private static readonly IntPtr NativeMethodInfoPtr_GetAvatarIndex_Public_Int32_0;

	// Token: 0x04000686 RID: 1670
	private static readonly IntPtr NativeMethodInfoPtr_SetAvatar_Public_Void_Int32_0;

	// Token: 0x04000687 RID: 1671
	private static readonly IntPtr NativeMethodInfoPtr_GetHonorString_Public_String_0;

	// Token: 0x04000688 RID: 1672
	private static readonly IntPtr NativeMethodInfoPtr_HidePlayerHand_Public_Void_Boolean_0;

	// Token: 0x04000689 RID: 1673
	private static readonly IntPtr NativeMethodInfoPtr_FindCardInPlayerHandByName_Public_AscensionCard_String_0;

	// Token: 0x0400068A RID: 1674
	private static readonly IntPtr NativeMethodInfoPtr_GetResourceLocation_Public_GameObject_UInt32_0;

	// Token: 0x0400068B RID: 1675
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x0400068C RID: 1676
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x0400068D RID: 1677
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x0400068E RID: 1678
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x0400068F RID: 1679
	private static readonly IntPtr NativeMethodInfoPtr_UpdateDreamscapeDisplay_Public_Void_0;

	// Token: 0x04000690 RID: 1680
	private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayerDisplay_Public_Void_Boolean_0;

	// Token: 0x04000691 RID: 1681
	private static readonly IntPtr NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_Boolean_0;

	// Token: 0x04000692 RID: 1682
	private static readonly IntPtr NativeMethodInfoPtr_UpdateOppTrayButtonGlows_Public_Void_Boolean_0;

	// Token: 0x04000693 RID: 1683
	private static readonly IntPtr NativeMethodInfoPtr_GetIfHasSelectableCardInPlay_Public_Boolean_0;

	// Token: 0x04000694 RID: 1684
	private static readonly IntPtr NativeMethodInfoPtr_PutCardInPlay_Public_Void_AscensionCardInPlay_0;

	// Token: 0x04000695 RID: 1685
	private static readonly IntPtr NativeMethodInfoPtr_ResetDiscardTray_Public_Void_0;

	// Token: 0x04000696 RID: 1686
	private static readonly IntPtr NativeMethodInfoPtr_CreateOwnedCard_Private_AscensionCard_Int32_0;

	// Token: 0x04000697 RID: 1687
	private static readonly IntPtr NativeMethodInfoPtr_HandleAddOwnedCard_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x04000698 RID: 1688
	private static readonly IntPtr NativeMethodInfoPtr_HandleRemoveOwnedCard_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x04000699 RID: 1689
	private static readonly IntPtr NativeMethodInfoPtr_RebuildPlayerOwnedList_Public_Void_0;

	// Token: 0x0400069A RID: 1690
	private static readonly IntPtr NativeMethodInfoPtr_RebuildPlayerHandList_Public_Void_0;

	// Token: 0x0400069B RID: 1691
	private static readonly IntPtr NativeMethodInfoPtr_RebuildPlayerDiscardList_Public_Void_0;

	// Token: 0x0400069C RID: 1692
	private static readonly IntPtr NativeMethodInfoPtr_RebuildPlayerDreamscapeList_Public_Void_Boolean_0;

	// Token: 0x0400069D RID: 1693
	private static readonly IntPtr NativeMethodInfoPtr_RebuildInterface_Public_Void_Boolean_0;

	// Token: 0x0400069E RID: 1694
	private static readonly IntPtr NativeMethodInfoPtr_RebuildAnimationManager_Public_Void_Boolean_0;

	// Token: 0x0400069F RID: 1695
	private static readonly IntPtr NativeMethodInfoPtr_SetPlayerOnlineTimer_Public_Void_0;

	// Token: 0x040006A0 RID: 1696
	private static readonly IntPtr NativeMethodInfoPtr_UpdateOnlineStatus_Private_IEnumerator_0;

	// Token: 0x040006A1 RID: 1697
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200017D RID: 381
	[ObfuscatedName("PlayerDisplay+<UpdateOnlineStatus>d__112")]
	public sealed class _UpdateOnlineStatus_d__112 : global::Il2CppSystem.Object
	{
		// Token: 0x060023A6 RID: 9126 RVA: 0x00085380 File Offset: 0x00083580
		// Note: this type is marked as 'beforefieldinit'.
		static _UpdateOnlineStatus_d__112()
		{
			Il2CppClassPointerStore<PlayerDisplay._UpdateOnlineStatus_d__112>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerDisplay>.NativeClassPtr, "<UpdateOnlineStatus>d__112");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerDisplay._UpdateOnlineStatus_d__112>.NativeClassPtr);
			PlayerDisplay._UpdateOnlineStatus_d__112.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay._UpdateOnlineStatus_d__112>.NativeClassPtr, "<>1__state");
			PlayerDisplay._UpdateOnlineStatus_d__112.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay._UpdateOnlineStatus_d__112>.NativeClassPtr, "<>2__current");
			PlayerDisplay._UpdateOnlineStatus_d__112.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDisplay._UpdateOnlineStatus_d__112>.NativeClassPtr, "<>4__this");
			PlayerDisplay._UpdateOnlineStatus_d__112.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay._UpdateOnlineStatus_d__112>.NativeClassPtr, 100666128);
			PlayerDisplay._UpdateOnlineStatus_d__112.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay._UpdateOnlineStatus_d__112>.NativeClassPtr, 100666129);
			PlayerDisplay._UpdateOnlineStatus_d__112.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay._UpdateOnlineStatus_d__112>.NativeClassPtr, 100666130);
			PlayerDisplay._UpdateOnlineStatus_d__112.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay._UpdateOnlineStatus_d__112>.NativeClassPtr, 100666131);
			PlayerDisplay._UpdateOnlineStatus_d__112.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay._UpdateOnlineStatus_d__112>.NativeClassPtr, 100666132);
			PlayerDisplay._UpdateOnlineStatus_d__112.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDisplay._UpdateOnlineStatus_d__112>.NativeClassPtr, 100666133);
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x00085460 File Offset: 0x00083660
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _UpdateOnlineStatus_d__112(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerDisplay._UpdateOnlineStatus_d__112>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay._UpdateOnlineStatus_d__112.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x000854A8 File Offset: 0x000836A8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay._UpdateOnlineStatus_d__112.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x000854DC File Offset: 0x000836DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236187, XrefRangeEnd = 236193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay._UpdateOnlineStatus_d__112.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x060023AA RID: 9130 RVA: 0x00085518 File Offset: 0x00083718
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay._UpdateOnlineStatus_d__112.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x00085558 File Offset: 0x00083758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236193, XrefRangeEnd = 236198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay._UpdateOnlineStatus_d__112.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x060023AC RID: 9132 RVA: 0x0008558C File Offset: 0x0008378C
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDisplay._UpdateOnlineStatus_d__112.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x00016420 File Offset: 0x00014620
		public _UpdateOnlineStatus_d__112(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x000855CC File Offset: 0x000837CC
		// (set) Token: 0x060023AF RID: 9135 RVA: 0x00016429 File Offset: 0x00014629
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay._UpdateOnlineStatus_d__112.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay._UpdateOnlineStatus_d__112.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x000855F4 File Offset: 0x000837F4
		// (set) Token: 0x060023B1 RID: 9137 RVA: 0x00016444 File Offset: 0x00014644
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay._UpdateOnlineStatus_d__112.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay._UpdateOnlineStatus_d__112.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x060023B2 RID: 9138 RVA: 0x00085624 File Offset: 0x00083824
		// (set) Token: 0x060023B3 RID: 9139 RVA: 0x00016463 File Offset: 0x00014663
		public unsafe PlayerDisplay __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay._UpdateOnlineStatus_d__112.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDisplay._UpdateOnlineStatus_d__112.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018B4 RID: 6324
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040018B5 RID: 6325
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040018B6 RID: 6326
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040018B7 RID: 6327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040018B8 RID: 6328
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040018B9 RID: 6329
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040018BA RID: 6330
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040018BB RID: 6331
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040018BC RID: 6332
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000022 RID: 34
public class AscensionGame : MonoBehaviour
{
	// Token: 0x060005C9 RID: 1481 RVA: 0x0002B470 File Offset: 0x00029670
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionGame()
	{
		Il2CppClassPointerStore<AscensionGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionGame");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr);
		AscensionGame.NativeFieldInfoPtr_k_maxDataSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "k_maxDataSize");
		AscensionGame.NativeFieldInfoPtr_k_maxCardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "k_maxCardCount");
		AscensionGame.NativeFieldInfoPtr_k_maxQueryCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "k_maxQueryCount");
		AscensionGame.NativeFieldInfoPtr_s_loadingIntoCompletedGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "s_loadingIntoCompletedGame");
		AscensionGame.NativeFieldInfoPtr_m_CardManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_CardManager");
		AscensionGame.NativeFieldInfoPtr_m_DragManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DragManager");
		AscensionGame.NativeFieldInfoPtr_m_AnimationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_AnimationManager");
		AscensionGame.NativeFieldInfoPtr_m_MagnifyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_MagnifyManager");
		AscensionGame.NativeFieldInfoPtr_m_AudioHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_AudioHandler");
		AscensionGame.NativeFieldInfoPtr_m_CenterRowSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_CenterRowSlots");
		AscensionGame.NativeFieldInfoPtr_m_CenterRowSeventhSlotScalar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_CenterRowSeventhSlotScalar");
		AscensionGame.NativeFieldInfoPtr_m_PortalDeckLocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_PortalDeckLocator");
		AscensionGame.NativeFieldInfoPtr_m_LocatorPortalDeckAnnounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocatorPortalDeckAnnounce");
		AscensionGame.NativeFieldInfoPtr_m_VoidPileLocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_VoidPileLocator");
		AscensionGame.NativeFieldInfoPtr_m_UnderVoidPileLocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_UnderVoidPileLocator");
		AscensionGame.NativeFieldInfoPtr_m_VoidPileLocatorEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_VoidPileLocatorEvent");
		AscensionGame.NativeFieldInfoPtr_m_UnderVoidPileLocatorEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_UnderVoidPileLocatorEvent");
		AscensionGame.NativeFieldInfoPtr_m_LocatorVoidPileTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocatorVoidPileTray");
		AscensionGame.NativeFieldInfoPtr_m_LocatorActionAreaPlayedCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocatorActionAreaPlayedCards");
		AscensionGame.NativeFieldInfoPtr_m_LocatorResolveEffectStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocatorResolveEffectStack");
		AscensionGame.NativeFieldInfoPtr_m_LocatorRevealedCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocatorRevealedCards");
		AscensionGame.NativeFieldInfoPtr_m_LocatorRevealAnnounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocatorRevealAnnounce");
		AscensionGame.NativeFieldInfoPtr_m_LocatorEventCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocatorEventCard");
		AscensionGame.NativeFieldInfoPtr_m_LocatorAvailableTemples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocatorAvailableTemples");
		AscensionGame.NativeFieldInfoPtr_m_LocatorAvailableTemplesAnnounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocatorAvailableTemplesAnnounce");
		AscensionGame.NativeFieldInfoPtr_m_LocatorDeliriumDieStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocatorDeliriumDieStart");
		AscensionGame.NativeFieldInfoPtr_m_LocatorDeliriumDieResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocatorDeliriumDieResolve");
		AscensionGame.NativeFieldInfoPtr_m_LocatorUniqueCardZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocatorUniqueCardZone");
		AscensionGame.NativeFieldInfoPtr_m_LocatorChampionIncoming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocatorChampionIncoming");
		AscensionGame.NativeFieldInfoPtr_m_LocatorChampionOutgoing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocatorChampionOutgoing");
		AscensionGame.NativeFieldInfoPtr_m_TransformEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_TransformEffect");
		AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDreamscapeArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocalPlayerDreamscapeArea");
		AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDreamscapeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocalPlayerDreamscapeButton");
		AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDreamscapeCenterSpacer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocalPlayerDreamscapeCenterSpacer");
		AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDreamscapeGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocalPlayerDreamscapeGlow");
		AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDreamscapeGlowFreeCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocalPlayerDreamscapeGlowFreeCard");
		AscensionGame.NativeFieldInfoPtr_m_LocalPlayerLeprechaunArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocalPlayerLeprechaunArea");
		AscensionGame.NativeFieldInfoPtr_m_PsytheaRedeemedArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_PsytheaRedeemedArea");
		AscensionGame.NativeFieldInfoPtr_m_PsytheaRedeemedGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_PsytheaRedeemedGlow");
		AscensionGame.NativeFieldInfoPtr_m_PsytheaRedeemedGlowFreeCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_PsytheaRedeemedGlowFreeCard");
		AscensionGame.NativeFieldInfoPtr_m_gameLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_gameLog");
		AscensionGame.NativeFieldInfoPtr_m_GameOptionButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_GameOptionButtons");
		AscensionGame.NativeFieldInfoPtr_m_GameOptionPlayerButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_GameOptionPlayerButtons");
		AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocalPlayerDisplay");
		AscensionGame.NativeFieldInfoPtr_m_OpponentTrays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_OpponentTrays");
		AscensionGame.NativeFieldInfoPtr_m_ActiveOpponentTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_ActiveOpponentTray");
		AscensionGame.NativeFieldInfoPtr_m_ActionAreaEndTurnButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_ActionAreaEndTurnButton");
		AscensionGame.NativeFieldInfoPtr_m_ActionAreaPlayAllButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_ActionAreaPlayAllButton");
		AscensionGame.NativeFieldInfoPtr_m_ActionAreaNoneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_ActionAreaNoneButton");
		AscensionGame.NativeFieldInfoPtr_m_ActionAreaLeftCapHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_ActionAreaLeftCapHighlight");
		AscensionGame.NativeFieldInfoPtr_m_ActionAreaRightCapHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_ActionAreaRightCapHighlight");
		AscensionGame.NativeFieldInfoPtr_m_RoundNumberDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_RoundNumberDisplay");
		AscensionGame.NativeFieldInfoPtr_m_RoundNumberText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_RoundNumberText");
		AscensionGame.NativeFieldInfoPtr_m_HonorPoolText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_HonorPoolText");
		AscensionGame.NativeFieldInfoPtr_m_HonorPoolGlowObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_HonorPoolGlowObj");
		AscensionGame.NativeFieldInfoPtr_m_HonorPoolGlowImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_HonorPoolGlowImage");
		AscensionGame.NativeFieldInfoPtr_m_HonorPoolGlowParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_HonorPoolGlowParticles");
		AscensionGame.NativeFieldInfoPtr_m_HonorPoolGlowColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_HonorPoolGlowColors");
		AscensionGame.NativeFieldInfoPtr_m_RuneCountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_RuneCountText");
		AscensionGame.NativeFieldInfoPtr_m_PowerCountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_PowerCountText");
		AscensionGame.NativeFieldInfoPtr_m_RuneMechanaCountDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_RuneMechanaCountDisplay");
		AscensionGame.NativeFieldInfoPtr_m_RuneMechanaCountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_RuneMechanaCountText");
		AscensionGame.NativeFieldInfoPtr_m_RuneGlowGeneric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_RuneGlowGeneric");
		AscensionGame.NativeFieldInfoPtr_m_RuneGlowLifebound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_RuneGlowLifebound");
		AscensionGame.NativeFieldInfoPtr_m_PowerGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_PowerGlow");
		AscensionGame.NativeFieldInfoPtr_m_EnergyCountDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_EnergyCountDisplay");
		AscensionGame.NativeFieldInfoPtr_m_EnergyCountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_EnergyCountText");
		AscensionGame.NativeFieldInfoPtr_m_TempleResourceDisplayList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_TempleResourceDisplayList");
		AscensionGame.NativeFieldInfoPtr_m_TempleLifeCountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_TempleLifeCountText");
		AscensionGame.NativeFieldInfoPtr_m_TempleDeathCountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_TempleDeathCountText");
		AscensionGame.NativeFieldInfoPtr_m_PortalDeckCountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_PortalDeckCountText");
		AscensionGame.NativeFieldInfoPtr_m_VoidPileCountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_VoidPileCountText");
		AscensionGame.NativeFieldInfoPtr_m_DayNightRootList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DayNightRootList");
		AscensionGame.NativeFieldInfoPtr_m_DayNightDayList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DayNightDayList");
		AscensionGame.NativeFieldInfoPtr_m_DayNightDayOnlyList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DayNightDayOnlyList");
		AscensionGame.NativeFieldInfoPtr_m_DayNightNightList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DayNightNightList");
		AscensionGame.NativeFieldInfoPtr_m_DayNightNightOnlyList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DayNightNightOnlyList");
		AscensionGame.NativeFieldInfoPtr_m_DayNightBothList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DayNightBothList");
		AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDeckList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocalPlayerDeckList");
		AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDeckTrayToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocalPlayerDeckTrayToggle");
		AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDiscardTrayToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocalPlayerDiscardTrayToggle");
		AscensionGame.NativeFieldInfoPtr_m_LocalPlayerConstructTrayToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocalPlayerConstructTrayToggle");
		AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDreamscapeTrayToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocalPlayerDreamscapeTrayToggle");
		AscensionGame.NativeFieldInfoPtr_m_LocalPlayerLeprechaunTrayToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocalPlayerLeprechaunTrayToggle");
		AscensionGame.NativeFieldInfoPtr_m_VoidTrayToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_VoidTrayToggle");
		AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDrawPileList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocalPlayerDrawPileList");
		AscensionGame.NativeFieldInfoPtr_m_LocatorDrawPileList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocatorDrawPileList");
		AscensionGame.NativeFieldInfoPtr_m_LocalPlayerLifeboundList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocalPlayerLifeboundList");
		AscensionGame.NativeFieldInfoPtr_m_LocatorLifeboundList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocatorLifeboundList");
		AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDefeatedMonsterList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocalPlayerDefeatedMonsterList");
		AscensionGame.NativeFieldInfoPtr_m_LocatorDefeatedMonsterList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocatorDefeatedMonsterList");
		AscensionGame.NativeFieldInfoPtr_m_KingdomStackTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_KingdomStackTray");
		AscensionGame.NativeFieldInfoPtr_m_LeprechaunStackTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LeprechaunStackTray");
		AscensionGame.NativeFieldInfoPtr_m_KingdomStackPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_KingdomStackPrefab");
		AscensionGame.NativeFieldInfoPtr_m_OptionPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_OptionPrompt");
		AscensionGame.NativeFieldInfoPtr_m_OptionPromptAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_OptionPromptAnimator");
		AscensionGame.NativeFieldInfoPtr_m_OptionPromptText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_OptionPromptText");
		AscensionGame.NativeFieldInfoPtr_m_Button_NoAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Button_NoAction");
		AscensionGame.NativeFieldInfoPtr_m_Button_EndTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Button_EndTurn");
		AscensionGame.NativeFieldInfoPtr_m_Button_Commit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Button_Commit");
		AscensionGame.NativeFieldInfoPtr_m_Button_Undo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Button_Undo");
		AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Glow_EndTurn");
		AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn_PS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Glow_EndTurn_PS");
		AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Glow_EndTurn_Button");
		AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn_Red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Glow_EndTurn_Red");
		AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn_Green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Glow_EndTurn_Green");
		AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn_RedBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Glow_EndTurn_RedBlock");
		AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn_GreenBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Glow_EndTurn_GreenBlock");
		AscensionGame.NativeFieldInfoPtr_m_Button_DeliriumDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Button_DeliriumDie");
		AscensionGame.NativeFieldInfoPtr_m_Glow_DeliriumDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Glow_DeliriumDie");
		AscensionGame.NativeFieldInfoPtr_m_Popup_Chat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Popup_Chat");
		AscensionGame.NativeFieldInfoPtr_m_Popup_Chat_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Popup_Chat_Button");
		AscensionGame.NativeFieldInfoPtr_m_Popup_Chat_Tray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Popup_Chat_Tray");
		AscensionGame.NativeFieldInfoPtr_m_Popup_Forfeit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Popup_Forfeit");
		AscensionGame.NativeFieldInfoPtr_m_Popup_Forfeit_KeepPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Popup_Forfeit_KeepPlaying");
		AscensionGame.NativeFieldInfoPtr_m_Popup_Forfeit_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Popup_Forfeit_Text");
		AscensionGame.NativeFieldInfoPtr_m_Popup_Forfeit_Cancel_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Popup_Forfeit_Cancel_Button");
		AscensionGame.NativeFieldInfoPtr_m_Popup_Forfeit_Continue_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Popup_Forfeit_Continue_Button");
		AscensionGame.NativeFieldInfoPtr_m_Popup_Forfeit_Confirm_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Popup_Forfeit_Confirm_Button");
		AscensionGame.NativeFieldInfoPtr_m_Popup_EndTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Popup_EndTurn");
		AscensionGame.NativeFieldInfoPtr_m_Popup_ConfirmMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Popup_ConfirmMove");
		AscensionGame.NativeFieldInfoPtr_m_Popup_ConfirmMoveText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Popup_ConfirmMoveText");
		AscensionGame.NativeFieldInfoPtr_m_Popup_ConfirmMove_ConfirmButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Popup_ConfirmMove_ConfirmButtonText");
		AscensionGame.NativeFieldInfoPtr_m_Popup_ConfirmMove_CancelButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Popup_ConfirmMove_CancelButtonText");
		AscensionGame.NativeFieldInfoPtr_m_Popup_ConfirmMoveImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Popup_ConfirmMoveImage");
		AscensionGame.NativeFieldInfoPtr_m_PauseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_PauseButton");
		AscensionGame.NativeFieldInfoPtr_m_CloseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_CloseButton");
		AscensionGame.NativeFieldInfoPtr_m_Popup_EndGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Popup_EndGame");
		AscensionGame.NativeFieldInfoPtr_m_HotseatScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_HotseatScreen");
		AscensionGame.NativeFieldInfoPtr_m_TutorialRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_TutorialRoot");
		AscensionGame.NativeFieldInfoPtr_m_TutorialPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_TutorialPanel");
		AscensionGame.NativeFieldInfoPtr_m_TutorialPanelText_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_TutorialPanelText_Label");
		AscensionGame.NativeFieldInfoPtr_m_TutorialPanelPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_TutorialPanelPrompt");
		AscensionGame.NativeFieldInfoPtr_m_TutorialPanelText_ButtonConfirm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_TutorialPanelText_ButtonConfirm");
		AscensionGame.NativeFieldInfoPtr_m_TutorialPanelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_TutorialPanelButton");
		AscensionGame.NativeFieldInfoPtr_m_TutorialPanelContinueButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_TutorialPanelContinueButton");
		AscensionGame.NativeFieldInfoPtr_m_TutorialPanelExitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_TutorialPanelExitButton");
		AscensionGame.NativeFieldInfoPtr_m_TutorialInterfaceCallouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_TutorialInterfaceCallouts");
		AscensionGame.NativeFieldInfoPtr_m_TutorialInterfaceCalloutPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_TutorialInterfaceCalloutPrefabs");
		AscensionGame.NativeFieldInfoPtr_m_OnlineGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_OnlineGameID");
		AscensionGame.NativeFieldInfoPtr_m_LocalPlayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocalPlayerIndex");
		AscensionGame.NativeFieldInfoPtr_m_LocalPlayerInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LocalPlayerInstanceID");
		AscensionGame.NativeFieldInfoPtr_m_RoundNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_RoundNumber");
		AscensionGame.NativeFieldInfoPtr_m_KingdomStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_KingdomStacks");
		AscensionGame.NativeFieldInfoPtr_m_CardInPlayList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_CardInPlayList");
		AscensionGame.NativeFieldInfoPtr_m_bShowEnergyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_bShowEnergyCount");
		AscensionGame.NativeFieldInfoPtr_m_bShowDayNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_bShowDayNight");
		AscensionGame.NativeFieldInfoPtr_m_bShowDreamscapeArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_bShowDreamscapeArea");
		AscensionGame.NativeFieldInfoPtr_m_bShowTemples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_bShowTemples");
		AscensionGame.NativeFieldInfoPtr_m_bShowDeckTrayDrawPileList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_bShowDeckTrayDrawPileList");
		AscensionGame.NativeFieldInfoPtr_m_bShowDeckTrayLifeboundList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_bShowDeckTrayLifeboundList");
		AscensionGame.NativeFieldInfoPtr_m_LifeboundCardList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LifeboundCardList");
		AscensionGame.NativeFieldInfoPtr_m_bShowDeckTrayDefeatedMonsterList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_bShowDeckTrayDefeatedMonsterList");
		AscensionGame.NativeFieldInfoPtr_m_DefeatedMonsterCardList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DefeatedMonsterCardList");
		AscensionGame.NativeFieldInfoPtr_m_EndDragCloseTragToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_EndDragCloseTragToggle");
		AscensionGame.NativeFieldInfoPtr_m_QueryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_QueryBuffer");
		AscensionGame.NativeFieldInfoPtr_m_dataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_dataBuffer");
		AscensionGame.NativeFieldInfoPtr_m_hDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_hDataBuffer");
		AscensionGame.NativeFieldInfoPtr_m_bufPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_bufPtr");
		AscensionGame.NativeFieldInfoPtr_m_endTurnParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_endTurnParticles");
		AscensionGame.NativeFieldInfoPtr_m_cardList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_cardList");
		AscensionGame.NativeFieldInfoPtr_m_hCardInstanceBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_hCardInstanceBuffer");
		AscensionGame.NativeFieldInfoPtr_m_cardBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_cardBuffer");
		AscensionGame.NativeFieldInfoPtr_m_GameEventBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_GameEventBuffer");
		AscensionGame.NativeFieldInfoPtr_m_lastSavedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_lastSavedState");
		AscensionGame.NativeFieldInfoPtr_m_PopupManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_PopupManager");
		AscensionGame.NativeFieldInfoPtr_m_ResourceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_ResourceManager");
		AscensionGame.NativeFieldInfoPtr_m_ConfirmMoveResource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_ConfirmMoveResource");
		AscensionGame.NativeFieldInfoPtr_m_ConfirmMovePopupLastShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_ConfirmMovePopupLastShown");
		AscensionGame.NativeFieldInfoPtr_m_bPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_bPaused");
		AscensionGame.NativeFieldInfoPtr_m_bInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_bInitialized");
		AscensionGame.NativeFieldInfoPtr_m_bWaitingAfterTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_bWaitingAfterTurn");
		AscensionGame.NativeFieldInfoPtr_m_bEndGameWaitingForCommit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_bEndGameWaitingForCommit");
		AscensionGame.NativeFieldInfoPtr_m_bForfeitLastPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_bForfeitLastPlayer");
		AscensionGame.NativeFieldInfoPtr_m_bForfeitDenied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_bForfeitDenied");
		AscensionGame.NativeFieldInfoPtr_m_LoadingScreenHoldUpdateCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_LoadingScreenHoldUpdateCount");
		AscensionGame.NativeFieldInfoPtr_m_PauseSimulationTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_PauseSimulationTimer");
		AscensionGame.NativeFieldInfoPtr_m_bLoadedIntoCompletedGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_bLoadedIntoCompletedGame");
		AscensionGame.NativeFieldInfoPtr_m_DisplayedRoundNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DisplayedRoundNumber");
		AscensionGame.NativeFieldInfoPtr_m_DisplayedHonorPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DisplayedHonorPool");
		AscensionGame.NativeFieldInfoPtr_m_DisplayedRuneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DisplayedRuneCount");
		AscensionGame.NativeFieldInfoPtr_m_DisplayedPowerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DisplayedPowerCount");
		AscensionGame.NativeFieldInfoPtr_m_DisplayedRuneMechanaCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DisplayedRuneMechanaCount");
		AscensionGame.NativeFieldInfoPtr_m_DisplayedHasRuneMechana = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DisplayedHasRuneMechana");
		AscensionGame.NativeFieldInfoPtr_m_DisplayedEnergyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DisplayedEnergyCount");
		AscensionGame.NativeFieldInfoPtr_m_DisplayedHasEnergy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DisplayedHasEnergy");
		AscensionGame.NativeFieldInfoPtr_m_DisplayedPortalDeckCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DisplayedPortalDeckCount");
		AscensionGame.NativeFieldInfoPtr_m_DisplayedVoidPileCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DisplayedVoidPileCount");
		AscensionGame.NativeFieldInfoPtr_m_DisplayedShowDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DisplayedShowDay");
		AscensionGame.NativeFieldInfoPtr_m_DisplayedShowNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DisplayedShowNight");
		AscensionGame.NativeFieldInfoPtr_m_DisplayedWorldStateFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DisplayedWorldStateFlags");
		AscensionGame.NativeFieldInfoPtr_m_DisplayedTempleLifeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DisplayedTempleLifeCount");
		AscensionGame.NativeFieldInfoPtr_m_DisplayedHasTempleLife = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DisplayedHasTempleLife");
		AscensionGame.NativeFieldInfoPtr_m_DisplayedTempleDeathCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DisplayedTempleDeathCount");
		AscensionGame.NativeFieldInfoPtr_m_DisplayedHasTempleDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_DisplayedHasTempleDeath");
		AscensionGame.NativeFieldInfoPtr_m_PopupConfirm_SelectionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_PopupConfirm_SelectionID");
		AscensionGame.NativeFieldInfoPtr_m_PopupConfirm_SelectionHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_PopupConfirm_SelectionHint");
		AscensionGame.NativeFieldInfoPtr_m_PopupConfirm_Negative_SelectionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_PopupConfirm_Negative_SelectionID");
		AscensionGame.NativeFieldInfoPtr_m_PopupConfirm_Negative_SelectionHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_PopupConfirm_Negative_SelectionHint");
		AscensionGame.NativeFieldInfoPtr_m_Tutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_Tutorial");
		AscensionGame.NativeFieldInfoPtr_m_bAdvanceTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_bAdvanceTutorial");
		AscensionGame.NativeFieldInfoPtr_m_TutorialElementsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_TutorialElementsActive");
		AscensionGame.NativeFieldInfoPtr_m_TutorialElementsMagnify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_TutorialElementsMagnify");
		AscensionGame.NativeFieldInfoPtr_m_TutorialElementsCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_TutorialElementsCreated");
		AscensionGame.NativeFieldInfoPtr_m_TutorialStepTimeStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, "m_TutorialStepTimeStart");
		AscensionGame.NativeMethodInfoPtr_GetTutorial_Public_Tutorial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663690);
		AscensionGame.NativeMethodInfoPtr_GetTutorialStepStartTime_Public_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663691);
		AscensionGame.NativeMethodInfoPtr_GetAnimationManager_Public_AnimationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663692);
		AscensionGame.NativeMethodInfoPtr_GetDragManager_Public_DragManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663693);
		AscensionGame.NativeMethodInfoPtr_GetCardManager_Public_AscensionCardManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663694);
		AscensionGame.NativeMethodInfoPtr_GetLastSavedState_Public_Static_ShortSaveStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663695);
		AscensionGame.NativeMethodInfoPtr_GetLocalPlayerIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663696);
		AscensionGame.NativeMethodInfoPtr_GetLocalPlayerInstanceID_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663697);
		AscensionGame.NativeMethodInfoPtr_GetPlayerDisplayByLocalPlayerOrder_Public_PlayerDisplay_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663698);
		AscensionGame.NativeMethodInfoPtr_GetPlayerDisplayByInstanceID_Public_PlayerDisplay_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663699);
		AscensionGame.NativeMethodInfoPtr_GetIsEndGamePopupActive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663700);
		AscensionGame.NativeMethodInfoPtr_OnSaveData_Public_Static_Void_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663701);
		AscensionGame.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663702);
		AscensionGame.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663703);
		AscensionGame.NativeMethodInfoPtr_ConstructTrayKeybind_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663704);
		AscensionGame.NativeMethodInfoPtr_DrawTrayKeybind_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663705);
		AscensionGame.NativeMethodInfoPtr_DiscardTrayKeybind_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663706);
		AscensionGame.NativeMethodInfoPtr_VoidTrayKeybind_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663707);
		AscensionGame.NativeMethodInfoPtr_PauseButtonKeybind_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663708);
		AscensionGame.NativeMethodInfoPtr_UnmagnifyOrCloseTraysKeybind_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663709);
		AscensionGame.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663710);
		AscensionGame.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663711);
		AscensionGame.NativeMethodInfoPtr_StartTutorial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663712);
		AscensionGame.NativeMethodInfoPtr_PauseSimulationForTutorial_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663713);
		AscensionGame.NativeMethodInfoPtr_ClearActiveTutorialElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663714);
		AscensionGame.NativeMethodInfoPtr_ShowTutorialPanel_Private_Void_TutorialStep_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663715);
		AscensionGame.NativeMethodInfoPtr_OnMagnifyCard_Private_Void_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663716);
		AscensionGame.NativeMethodInfoPtr_OnUnmagnifyCard_Private_Void_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663717);
		AscensionGame.NativeMethodInfoPtr_HandleTutorialEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663718);
		AscensionGame.NativeMethodInfoPtr_SetupTutorialStep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663719);
		AscensionGame.NativeMethodInfoPtr_HandleTutorialGameOptionSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663720);
		AscensionGame.NativeMethodInfoPtr_AdvanceTutorial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663721);
		AscensionGame.NativeMethodInfoPtr_UpdateTutorial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663722);
		AscensionGame.NativeMethodInfoPtr_OnActionConfirmButtonTutorialPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663723);
		AscensionGame.NativeMethodInfoPtr_HandleLeaveGameAnalytics_Public_Static_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663724);
		AscensionGame.NativeMethodInfoPtr_OnBeginAnimationCallback_Public_Void_AnimateObject_UInt32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663725);
		AscensionGame.NativeMethodInfoPtr_OnEndAnimationCallback_Public_Void_AnimateObject_UInt32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663726);
		AscensionGame.NativeMethodInfoPtr_OnBeginDragCallback_Public_Void_DragObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663727);
		AscensionGame.NativeMethodInfoPtr_OnEndDragCallback_Public_Void_DragObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663728);
		AscensionGame.NativeMethodInfoPtr_OnApplicationPause_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663729);
		AscensionGame.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663730);
		AscensionGame.NativeMethodInfoPtr_UpdateWorldData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663731);
		AscensionGame.NativeMethodInfoPtr_UpdateUniqueCardDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663732);
		AscensionGame.NativeMethodInfoPtr_UpdateCenterRowDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663733);
		AscensionGame.NativeMethodInfoPtr_UpdateCenterRowScale_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663734);
		AscensionGame.NativeMethodInfoPtr_UpdateKingdomStacks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663735);
		AscensionGame.NativeMethodInfoPtr_GetAllOpponentsHaveForfeited_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663736);
		AscensionGame.NativeMethodInfoPtr_GetCardInPlay_Public_AscensionCardInPlay_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663737);
		AscensionGame.NativeMethodInfoPtr_GetCardInPlayByAbilityInstanceID_Public_AscensionCardInPlay_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663738);
		AscensionGame.NativeMethodInfoPtr_PutCardInPlay_Private_Void_AscensionCardInPlay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663739);
		AscensionGame.NativeMethodInfoPtr_PutCardInPlay_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663740);
		AscensionGame.NativeMethodInfoPtr_RemoveCardFromPlay_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663741);
		AscensionGame.NativeMethodInfoPtr_RemoveAllCardsFromPlay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663742);
		AscensionGame.NativeMethodInfoPtr_HandleEventPause_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663743);
		AscensionGame.NativeMethodInfoPtr_HandleEventKingdomStackStatus_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663744);
		AscensionGame.NativeMethodInfoPtr_HandleEventCenterRowStatus_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663745);
		AscensionGame.NativeMethodInfoPtr_HandleEventCardInPlayStatus_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663746);
		AscensionGame.NativeMethodInfoPtr_HandleEventResetPlayerDiscardPile_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663747);
		AscensionGame.NativeMethodInfoPtr_HandleEventCloseDreamscapeTray_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663748);
		AscensionGame.NativeMethodInfoPtr_HandleEventEndOfRainbowTray_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663749);
		AscensionGame.NativeMethodInfoPtr_HandleEventDeliriumResult_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663750);
		AscensionGame.NativeMethodInfoPtr_HandleEventDrawHandAtEndOfTurn_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663751);
		AscensionGame.NativeMethodInfoPtr_HandleEventTransformCard_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663752);
		AscensionGame.NativeMethodInfoPtr_HandleEventUpdatePlayedCardList_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663753);
		AscensionGame.NativeMethodInfoPtr_HandleEventRemovePlayedCard_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663754);
		AscensionGame.NativeMethodInfoPtr_HandleEventUpdateResolveEffectList_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663755);
		AscensionGame.NativeMethodInfoPtr_HandleEventTutorialAISelectedOption_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663756);
		AscensionGame.NativeMethodInfoPtr_HandleEventCommitPlayerDecision_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663757);
		AscensionGame.NativeMethodInfoPtr_HandleEventAchievementData_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663758);
		AscensionGame.NativeMethodInfoPtr_HandleEventGameOver_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663759);
		AscensionGame.NativeMethodInfoPtr_HandleEventLoadProgress_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663760);
		AscensionGame.NativeMethodInfoPtr_UpdateGameOptionsSelectionState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663761);
		AscensionGame.NativeMethodInfoPtr_ShowConfirmMovePopup_Public_Void_UInt32_UInt16_Int32_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663762);
		AscensionGame.NativeMethodInfoPtr_ReleaseConfirmMoveResource_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663763);
		AscensionGame.NativeMethodInfoPtr_OnConfirmPopupConfirmButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663764);
		AscensionGame.NativeMethodInfoPtr_OnConfirmPopupCancelButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663765);
		AscensionGame.NativeMethodInfoPtr_OnEndTurnKeybind_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663766);
		AscensionGame.NativeMethodInfoPtr_OnEndTurnButton_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663767);
		AscensionGame.NativeMethodInfoPtr_OnPlayAllKeybind_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663768);
		AscensionGame.NativeMethodInfoPtr_OnPlayAllButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663769);
		AscensionGame.NativeMethodInfoPtr_OnNoneButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663770);
		AscensionGame.NativeMethodInfoPtr_OnButtonPressedNoAction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663771);
		AscensionGame.NativeMethodInfoPtr_OnButtonPressedEndTurn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663772);
		AscensionGame.NativeMethodInfoPtr_OnButtonPressedCommit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663773);
		AscensionGame.NativeMethodInfoPtr_OnButtonPressedPayForDeliriumDie_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663774);
		AscensionGame.NativeMethodInfoPtr_OnMagnifiedCardActionButtonPressed_Public_Void_AscensionCard_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663775);
		AscensionGame.NativeMethodInfoPtr_OnForfeitCancelButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663776);
		AscensionGame.NativeMethodInfoPtr_OnForfeitPopupButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663777);
		AscensionGame.NativeMethodInfoPtr_OnCurrentPopupChanged_Public_Void_EPopups_EPopups_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663778);
		AscensionGame.NativeMethodInfoPtr_OnHotseatScreenPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663779);
		AscensionGame.NativeMethodInfoPtr_PauseButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663780);
		AscensionGame.NativeMethodInfoPtr_ResumeButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663781);
		AscensionGame.NativeMethodInfoPtr_SummaryScreenStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663782);
		AscensionGame.NativeMethodInfoPtr_SummaryScreenEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663783);
		AscensionGame.NativeMethodInfoPtr_SwitchToPlayer_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663784);
		AscensionGame.NativeMethodInfoPtr_BuildLocalPlayerDrawPileList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663785);
		AscensionGame.NativeMethodInfoPtr_FindCardInLifeboundList_Public_AscensionCard_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663786);
		AscensionGame.NativeMethodInfoPtr_BuildLifeboundList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663787);
		AscensionGame.NativeMethodInfoPtr_BuildDefeatedMonsterList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663788);
		AscensionGame.NativeMethodInfoPtr_RebuildCenterRow_Public_Void_AscensionCardManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663789);
		AscensionGame.NativeMethodInfoPtr_ResetVoidCardTray_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663790);
		AscensionGame.NativeMethodInfoPtr_RebuildVoidCardList_Public_Void_AscensionCardManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663791);
		AscensionGame.NativeMethodInfoPtr_RebuildActionAreaPlayedCards_Public_Void_AscensionCardManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663792);
		AscensionGame.NativeMethodInfoPtr_RebuildResolveEffectStack_Public_Void_AscensionCardManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663793);
		AscensionGame.NativeMethodInfoPtr_RebuildEventCardInPlay_Public_Void_AscensionCardManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663794);
		AscensionGame.NativeMethodInfoPtr_RebuildAvailableTemples_Public_Void_AscensionCardManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663795);
		AscensionGame.NativeMethodInfoPtr_RebuildUniqueCardZone_Public_Void_AscensionCardManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663796);
		AscensionGame.NativeMethodInfoPtr_RebuildGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663797);
		AscensionGame.NativeMethodInfoPtr_CreateKingdomStack_Public_GameObject_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663798);
		AscensionGame.NativeMethodInfoPtr_RebuildKingdomStacks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663799);
		AscensionGame.NativeMethodInfoPtr_RebuildCardInPlayList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663800);
		AscensionGame.NativeMethodInfoPtr_RebuildInterface_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663801);
		AscensionGame.NativeMethodInfoPtr_RebuildAnimationManager_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663802);
		AscensionGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr, 100663803);
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x0002CD8C File Offset: 0x0002AF8C
	[CallerCount(0)]
	public unsafe Tutorial GetTutorial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_GetTutorial_Public_Tutorial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tutorial>(intPtr3) : null;
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x0002CDCC File Offset: 0x0002AFCC
	[CallerCount(0)]
	public unsafe DateTime GetTutorialStepStartTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_GetTutorialStepStartTime_Public_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005CC RID: 1484 RVA: 0x0002CE08 File Offset: 0x0002B008
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationManager GetAnimationManager()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_GetAnimationManager_Public_AnimationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationManager>(intPtr3) : null;
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x0002CE48 File Offset: 0x0002B048
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DragManager GetDragManager()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_GetDragManager_Public_DragManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<DragManager>(intPtr3) : null;
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x0002CE88 File Offset: 0x0002B088
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionCardManager GetCardManager()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_GetCardManager_Public_AscensionCardManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AscensionCardManager>(intPtr3) : null;
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x0002CEC8 File Offset: 0x0002B0C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229733, XrefRangeEnd = 229737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ShortSaveStruct GetLastSavedState()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_GetLastSavedState_Public_Static_ShortSaveStruct_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return new ShortSaveStruct(intPtr);
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x0002CEF4 File Offset: 0x0002B0F4
	[CallerCount(0)]
	public unsafe int GetLocalPlayerIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_GetLocalPlayerIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x0002CF30 File Offset: 0x0002B130
	[CallerCount(0)]
	public unsafe int GetLocalPlayerInstanceID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_GetLocalPlayerInstanceID_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x0002CF6C File Offset: 0x0002B16C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 229741, RefRangeEnd = 229744, XrefRangeStart = 229737, XrefRangeEnd = 229741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerDisplay GetPlayerDisplayByLocalPlayerOrder(int order_index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref order_index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_GetPlayerDisplayByLocalPlayerOrder_Public_PlayerDisplay_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerDisplay>(intPtr3) : null;
		}
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x0002CFB8 File Offset: 0x0002B1B8
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 229751, RefRangeEnd = 229756, XrefRangeStart = 229744, XrefRangeEnd = 229751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerDisplay GetPlayerDisplayByInstanceID(int playerInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerInstanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_GetPlayerDisplayByInstanceID_Public_PlayerDisplay_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerDisplay>(intPtr3) : null;
		}
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x0002D004 File Offset: 0x0002B204
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229760, RefRangeEnd = 229761, XrefRangeStart = 229756, XrefRangeEnd = 229760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetIsEndGamePopupActive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_GetIsEndGamePopupActive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x0002D040 File Offset: 0x0002B240
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229761, XrefRangeEnd = 229815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnSaveData(IntPtr pSaveData, int size, IntPtr pShortSaveStruct)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pSaveData;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pShortSaveStruct;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnSaveData_Public_Static_Void_IntPtr_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x0002D090 File Offset: 0x0002B290
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229815, XrefRangeEnd = 230111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x0002D0C4 File Offset: 0x0002B2C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230111, XrefRangeEnd = 230191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x0002D0F8 File Offset: 0x0002B2F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230191, XrefRangeEnd = 230199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConstructTrayKeybind()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_ConstructTrayKeybind_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x0002D12C File Offset: 0x0002B32C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230199, XrefRangeEnd = 230207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawTrayKeybind()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_DrawTrayKeybind_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x0002D160 File Offset: 0x0002B360
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230207, XrefRangeEnd = 230215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DiscardTrayKeybind()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_DiscardTrayKeybind_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x0002D194 File Offset: 0x0002B394
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230215, XrefRangeEnd = 230223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void VoidTrayKeybind()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_VoidTrayKeybind_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x0002D1C8 File Offset: 0x0002B3C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230223, XrefRangeEnd = 230232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PauseButtonKeybind()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_PauseButtonKeybind_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x0002D1FC File Offset: 0x0002B3FC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 230263, RefRangeEnd = 230265, XrefRangeStart = 230232, XrefRangeEnd = 230263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnmagnifyOrCloseTraysKeybind()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_UnmagnifyOrCloseTraysKeybind_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x0002D230 File Offset: 0x0002B430
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230265, XrefRangeEnd = 230507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x0002D264 File Offset: 0x0002B464
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 230565, RefRangeEnd = 230566, XrefRangeStart = 230507, XrefRangeEnd = 230565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x0002D298 File Offset: 0x0002B498
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230566, XrefRangeEnd = 230595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartTutorial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_StartTutorial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x0002D2CC File Offset: 0x0002B4CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230595, XrefRangeEnd = 230596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool PauseSimulationForTutorial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_PauseSimulationForTutorial_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x0002D308 File Offset: 0x0002B508
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 230639, RefRangeEnd = 230641, XrefRangeStart = 230596, XrefRangeEnd = 230639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearActiveTutorialElements()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_ClearActiveTutorialElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x0002D33C File Offset: 0x0002B53C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 230701, RefRangeEnd = 230702, XrefRangeStart = 230641, XrefRangeEnd = 230701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowTutorialPanel(TutorialStep current_step, bool bActivateConfirmButton)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(current_step);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bActivateConfirmButton;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_ShowTutorialPanel_Private_Void_TutorialStep_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x0002D38C File Offset: 0x0002B58C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230702, XrefRangeEnd = 230706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMagnifyCard(CardObject magnifyCard)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(magnifyCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnMagnifyCard_Private_Void_CardObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x0002D3D0 File Offset: 0x0002B5D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230706, XrefRangeEnd = 230741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUnmagnifyCard(CardObject magnifyCard)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(magnifyCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnUnmagnifyCard_Private_Void_CardObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x0002D414 File Offset: 0x0002B614
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230741, XrefRangeEnd = 230748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleTutorialEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleTutorialEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x0002D448 File Offset: 0x0002B648
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 230868, RefRangeEnd = 230871, XrefRangeStart = 230748, XrefRangeEnd = 230868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupTutorialStep()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_SetupTutorialStep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x0002D47C File Offset: 0x0002B67C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 230874, RefRangeEnd = 230876, XrefRangeStart = 230871, XrefRangeEnd = 230874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleTutorialGameOptionSelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleTutorialGameOptionSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x0002D4B0 File Offset: 0x0002B6B0
	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 230885, RefRangeEnd = 230896, XrefRangeStart = 230876, XrefRangeEnd = 230885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AdvanceTutorial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_AdvanceTutorial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x0002D4E4 File Offset: 0x0002B6E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230896, XrefRangeEnd = 230901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTutorial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_UpdateTutorial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x0002D518 File Offset: 0x0002B718
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230901, XrefRangeEnd = 230914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnActionConfirmButtonTutorialPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnActionConfirmButtonTutorialPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x0002D54C File Offset: 0x0002B74C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HandleLeaveGameAnalytics(string reason, int winner, int score)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref winner;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref score;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleLeaveGameAnalytics_Public_Static_Void_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x0002D5A0 File Offset: 0x0002B7A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230914, XrefRangeEnd = 230916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBeginAnimationCallback(AnimateObject animateObject, uint animationFlags, int sourceLocatorIndex, int sourceLocatorInstanceID, int destinationLocatorIndex, int destinationLocatorInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animateObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref animationFlags;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceLocatorIndex;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceLocatorInstanceID;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationLocatorIndex;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationLocatorInstanceID;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnBeginAnimationCallback_Public_Void_AnimateObject_UInt32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x0002D628 File Offset: 0x0002B828
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230916, XrefRangeEnd = 230918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEndAnimationCallback(AnimateObject animateObject, uint animationFlags, int sourceLocatorIndex, int sourceLocatorInstanceID, int destinationLocatorIndex, int destinationLocatorInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animateObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref animationFlags;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceLocatorIndex;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceLocatorInstanceID;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationLocatorIndex;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationLocatorInstanceID;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnEndAnimationCallback_Public_Void_AnimateObject_UInt32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x0002D6B0 File Offset: 0x0002B8B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230918, XrefRangeEnd = 230949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBeginDragCallback(DragObject dragObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnBeginDragCallback_Public_Void_DragObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x0002D6F4 File Offset: 0x0002B8F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230949, XrefRangeEnd = 230958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEndDragCallback(DragObject dragObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnEndDragCallback_Public_Void_DragObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x0002D738 File Offset: 0x0002B938
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnApplicationPause(bool bPaused)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bPaused;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnApplicationPause_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x0002D778 File Offset: 0x0002B978
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230958, XrefRangeEnd = 231205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x0002D7AC File Offset: 0x0002B9AC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 231373, RefRangeEnd = 231374, XrefRangeStart = 231205, XrefRangeEnd = 231373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateWorldData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_UpdateWorldData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x0002D7E0 File Offset: 0x0002B9E0
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateUniqueCardDisplay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_UpdateUniqueCardDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x0002D814 File Offset: 0x0002BA14
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 231385, RefRangeEnd = 231386, XrefRangeStart = 231374, XrefRangeEnd = 231385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCenterRowDisplay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_UpdateCenterRowDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x0002D848 File Offset: 0x0002BA48
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 231401, RefRangeEnd = 231404, XrefRangeStart = 231386, XrefRangeEnd = 231401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCenterRowScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_UpdateCenterRowScale_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005F7 RID: 1527 RVA: 0x0002D87C File Offset: 0x0002BA7C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 231419, RefRangeEnd = 231420, XrefRangeStart = 231404, XrefRangeEnd = 231419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateKingdomStacks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_UpdateKingdomStacks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005F8 RID: 1528 RVA: 0x0002D8B0 File Offset: 0x0002BAB0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 231443, RefRangeEnd = 231446, XrefRangeStart = 231420, XrefRangeEnd = 231443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetAllOpponentsHaveForfeited()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_GetAllOpponentsHaveForfeited_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x0002D8EC File Offset: 0x0002BAEC
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 231462, RefRangeEnd = 231470, XrefRangeStart = 231446, XrefRangeEnd = 231462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionCardInPlay GetCardInPlay(int cardinplay_instance_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref cardinplay_instance_id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_GetCardInPlay_Public_AscensionCardInPlay_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AscensionCardInPlay>(intPtr3) : null;
		}
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x0002D938 File Offset: 0x0002BB38
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 231489, RefRangeEnd = 231492, XrefRangeStart = 231470, XrefRangeEnd = 231489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionCardInPlay GetCardInPlayByAbilityInstanceID(int ability_instance_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref ability_instance_id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_GetCardInPlayByAbilityInstanceID_Public_AscensionCardInPlay_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AscensionCardInPlay>(intPtr3) : null;
		}
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x0002D984 File Offset: 0x0002BB84
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 231501, RefRangeEnd = 231505, XrefRangeStart = 231492, XrefRangeEnd = 231501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PutCardInPlay(AscensionCardInPlay cardinplay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardinplay);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_PutCardInPlay_Private_Void_AscensionCardInPlay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x0002D9C8 File Offset: 0x0002BBC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231505, XrefRangeEnd = 231518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PutCardInPlay(int cardinplay_instance_id, int sourcecard_instance_id, int owner_instance_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref cardinplay_instance_id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourcecard_instance_id;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref owner_instance_id;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_PutCardInPlay_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x0002DA24 File Offset: 0x0002BC24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231518, XrefRangeEnd = 231563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RemoveCardFromPlay(int cardinplay_instance_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref cardinplay_instance_id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_RemoveCardFromPlay_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x0002DA70 File Offset: 0x0002BC70
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 231606, RefRangeEnd = 231607, XrefRangeStart = 231563, XrefRangeEnd = 231606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveAllCardsFromPlay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_RemoveAllCardsFromPlay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x0002DAA4 File Offset: 0x0002BCA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231607, XrefRangeEnd = 231632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventPause(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleEventPause_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x0002DAF4 File Offset: 0x0002BCF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231632, XrefRangeEnd = 231671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventKingdomStackStatus(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleEventKingdomStackStatus_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x0002DB44 File Offset: 0x0002BD44
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231671, XrefRangeEnd = 231691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventCenterRowStatus(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleEventCenterRowStatus_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x0002DB94 File Offset: 0x0002BD94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231691, XrefRangeEnd = 231717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventCardInPlayStatus(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleEventCardInPlayStatus_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x0002DBE4 File Offset: 0x0002BDE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231717, XrefRangeEnd = 231739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventResetPlayerDiscardPile(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleEventResetPlayerDiscardPile_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x0002DC34 File Offset: 0x0002BE34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231739, XrefRangeEnd = 231755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventCloseDreamscapeTray(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleEventCloseDreamscapeTray_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x0002DC84 File Offset: 0x0002BE84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231755, XrefRangeEnd = 231773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventEndOfRainbowTray(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleEventEndOfRainbowTray_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x0002DCD4 File Offset: 0x0002BED4
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventDeliriumResult(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleEventDeliriumResult_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x0002DD24 File Offset: 0x0002BF24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231773, XrefRangeEnd = 231791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventDrawHandAtEndOfTurn(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleEventDrawHandAtEndOfTurn_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x0002DD74 File Offset: 0x0002BF74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231791, XrefRangeEnd = 231825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventTransformCard(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleEventTransformCard_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x0002DDC4 File Offset: 0x0002BFC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231825, XrefRangeEnd = 231847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventUpdatePlayedCardList(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleEventUpdatePlayedCardList_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x0002DE14 File Offset: 0x0002C014
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231847, XrefRangeEnd = 231878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventRemovePlayedCard(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleEventRemovePlayedCard_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x0002DE64 File Offset: 0x0002C064
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231878, XrefRangeEnd = 231900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventUpdateResolveEffectList(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleEventUpdateResolveEffectList_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x0002DEB4 File Offset: 0x0002C0B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231900, XrefRangeEnd = 231938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventTutorialAISelectedOption(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleEventTutorialAISelectedOption_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x0002DF04 File Offset: 0x0002C104
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231938, XrefRangeEnd = 231955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventCommitPlayerDecision(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleEventCommitPlayerDecision_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x0002DF54 File Offset: 0x0002C154
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231955, XrefRangeEnd = 231975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventAchievementData(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleEventAchievementData_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x0002DFA4 File Offset: 0x0002C1A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231975, XrefRangeEnd = 231986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventGameOver(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleEventGameOver_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x0002DFF4 File Offset: 0x0002C1F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231986, XrefRangeEnd = 232053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventLoadProgress(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_HandleEventLoadProgress_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x0002E044 File Offset: 0x0002C244
	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 232606, RefRangeEnd = 232617, XrefRangeStart = 232053, XrefRangeEnd = 232606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateGameOptionsSelectionState(bool bHighlight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bHighlight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_UpdateGameOptionsSelectionState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x0002E084 File Offset: 0x0002C284
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 232692, RefRangeEnd = 232694, XrefRangeStart = 232617, XrefRangeEnd = 232692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowConfirmMovePopup(uint selectionID, ushort selectionHint, int sourceInstanceID, uint cancelSelectionID = 0U, ushort cancelSelectionHint = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref selectionID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionHint;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceInstanceID;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cancelSelectionID;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cancelSelectionHint;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_ShowConfirmMovePopup_Public_Void_UInt32_UInt16_Int32_UInt32_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x0002E0FC File Offset: 0x0002C2FC
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 232700, RefRangeEnd = 232704, XrefRangeStart = 232694, XrefRangeEnd = 232700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleaseConfirmMoveResource()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_ReleaseConfirmMoveResource_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000614 RID: 1556 RVA: 0x0002E130 File Offset: 0x0002C330
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232704, XrefRangeEnd = 232711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConfirmPopupConfirmButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnConfirmPopupConfirmButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000615 RID: 1557 RVA: 0x0002E164 File Offset: 0x0002C364
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232711, XrefRangeEnd = 232720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConfirmPopupCancelButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnConfirmPopupCancelButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000616 RID: 1558 RVA: 0x0002E198 File Offset: 0x0002C398
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232720, XrefRangeEnd = 232725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEndTurnKeybind()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnEndTurnKeybind_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000617 RID: 1559 RVA: 0x0002E1CC File Offset: 0x0002C3CC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 232748, RefRangeEnd = 232749, XrefRangeStart = 232725, XrefRangeEnd = 232748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEndTurnButton(bool bConfirm = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bConfirm;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnEndTurnButton_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000618 RID: 1560 RVA: 0x0002E20C File Offset: 0x0002C40C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232749, XrefRangeEnd = 232755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayAllKeybind()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnPlayAllKeybind_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000619 RID: 1561 RVA: 0x0002E240 File Offset: 0x0002C440
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232755, XrefRangeEnd = 232757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayAllButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnPlayAllButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600061A RID: 1562 RVA: 0x0002E274 File Offset: 0x0002C474
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232757, XrefRangeEnd = 232795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnNoneButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnNoneButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x0002E2A8 File Offset: 0x0002C4A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232795, XrefRangeEnd = 232826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnButtonPressedNoAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnButtonPressedNoAction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600061C RID: 1564 RVA: 0x0002E2DC File Offset: 0x0002C4DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232826, XrefRangeEnd = 232864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnButtonPressedEndTurn(bool bConfirm = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bConfirm;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnButtonPressedEndTurn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600061D RID: 1565 RVA: 0x0002E31C File Offset: 0x0002C51C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232864, XrefRangeEnd = 232895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnButtonPressedCommit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnButtonPressedCommit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600061E RID: 1566 RVA: 0x0002E350 File Offset: 0x0002C550
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232895, XrefRangeEnd = 232900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnButtonPressedPayForDeliriumDie(bool bConfirm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bConfirm;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnButtonPressedPayForDeliriumDie_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x0002E390 File Offset: 0x0002C590
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 232905, RefRangeEnd = 232907, XrefRangeStart = 232900, XrefRangeEnd = 232905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMagnifiedCardActionButtonPressed(AscensionCard ascension_card, ushort selected_hint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ascension_card);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selected_hint;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnMagnifiedCardActionButtonPressed_Public_Void_AscensionCard_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000620 RID: 1568 RVA: 0x0002E3E0 File Offset: 0x0002C5E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232907, XrefRangeEnd = 232912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnForfeitCancelButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnForfeitCancelButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x0002E414 File Offset: 0x0002C614
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232912, XrefRangeEnd = 232931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnForfeitPopupButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnForfeitPopupButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x0002E448 File Offset: 0x0002C648
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCurrentPopupChanged(EPopups newPopup, EPopups oldPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref newPopup;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldPopup;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnCurrentPopupChanged_Public_Void_EPopups_EPopups_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x0002E494 File Offset: 0x0002C694
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232931, XrefRangeEnd = 232938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnHotseatScreenPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_OnHotseatScreenPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x0002E4C8 File Offset: 0x0002C6C8
	[CallerCount(0)]
	public unsafe void PauseButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_PauseButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000625 RID: 1573 RVA: 0x0002E4FC File Offset: 0x0002C6FC
	[CallerCount(0)]
	public unsafe void ResumeButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_ResumeButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x0002E530 File Offset: 0x0002C730
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SummaryScreenStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_SummaryScreenStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x0002E564 File Offset: 0x0002C764
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SummaryScreenEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_SummaryScreenEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x0002E598 File Offset: 0x0002C798
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 232984, RefRangeEnd = 232986, XrefRangeStart = 232938, XrefRangeEnd = 232984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SwitchToPlayer(int playerID, bool bInitialize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bInitialize;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_SwitchToPlayer_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000629 RID: 1577 RVA: 0x0002E5E4 File Offset: 0x0002C7E4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233040, RefRangeEnd = 233041, XrefRangeStart = 232986, XrefRangeEnd = 233040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildLocalPlayerDrawPileList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_BuildLocalPlayerDrawPileList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x0002E618 File Offset: 0x0002C818
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233057, RefRangeEnd = 233058, XrefRangeStart = 233041, XrefRangeEnd = 233057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionCard FindCardInLifeboundList(int lifeboundInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref lifeboundInstanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_FindCardInLifeboundList_Public_AscensionCard_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AscensionCard>(intPtr3) : null;
		}
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x0002E664 File Offset: 0x0002C864
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233100, RefRangeEnd = 233101, XrefRangeStart = 233058, XrefRangeEnd = 233100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildLifeboundList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_BuildLifeboundList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x0002E698 File Offset: 0x0002C898
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233143, RefRangeEnd = 233144, XrefRangeStart = 233101, XrefRangeEnd = 233143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildDefeatedMonsterList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_BuildDefeatedMonsterList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x0002E6CC File Offset: 0x0002C8CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233144, XrefRangeEnd = 233153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildCenterRow(AscensionCardManager card_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_RebuildCenterRow_Public_Void_AscensionCardManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x0002E710 File Offset: 0x0002C910
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233174, RefRangeEnd = 233175, XrefRangeStart = 233153, XrefRangeEnd = 233174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetVoidCardTray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_ResetVoidCardTray_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x0002E744 File Offset: 0x0002C944
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233196, RefRangeEnd = 233197, XrefRangeStart = 233175, XrefRangeEnd = 233196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildVoidCardList(AscensionCardManager card_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_RebuildVoidCardList_Public_Void_AscensionCardManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x0002E788 File Offset: 0x0002C988
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233238, RefRangeEnd = 233239, XrefRangeStart = 233197, XrefRangeEnd = 233238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildActionAreaPlayedCards(AscensionCardManager card_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_RebuildActionAreaPlayedCards_Public_Void_AscensionCardManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x0002E7CC File Offset: 0x0002C9CC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233278, RefRangeEnd = 233279, XrefRangeStart = 233239, XrefRangeEnd = 233278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildResolveEffectStack(AscensionCardManager card_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_RebuildResolveEffectStack_Public_Void_AscensionCardManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x0002E810 File Offset: 0x0002CA10
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233314, RefRangeEnd = 233315, XrefRangeStart = 233279, XrefRangeEnd = 233314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildEventCardInPlay(AscensionCardManager card_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_RebuildEventCardInPlay_Public_Void_AscensionCardManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x0002E854 File Offset: 0x0002CA54
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233349, RefRangeEnd = 233350, XrefRangeStart = 233315, XrefRangeEnd = 233349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildAvailableTemples(AscensionCardManager card_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_RebuildAvailableTemples_Public_Void_AscensionCardManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x0002E898 File Offset: 0x0002CA98
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildUniqueCardZone(AscensionCardManager card_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_RebuildUniqueCardZone_Public_Void_AscensionCardManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x0002E8DC File Offset: 0x0002CADC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 233398, RefRangeEnd = 233401, XrefRangeStart = 233350, XrefRangeEnd = 233398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildGame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_RebuildGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x0002E910 File Offset: 0x0002CB10
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233458, RefRangeEnd = 233459, XrefRangeStart = 233401, XrefRangeEnd = 233458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject CreateKingdomStack(int kingdomstack_instance_id, int remaining_card_count, int sample_card_instance_id, bool is_end_of_rainbow)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref kingdomstack_instance_id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remaining_card_count;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sample_card_instance_id;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref is_end_of_rainbow;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_CreateKingdomStack_Public_GameObject_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x0002E988 File Offset: 0x0002CB88
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233519, RefRangeEnd = 233520, XrefRangeStart = 233459, XrefRangeEnd = 233519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildKingdomStacks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_RebuildKingdomStacks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x0002E9BC File Offset: 0x0002CBBC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233539, RefRangeEnd = 233540, XrefRangeStart = 233520, XrefRangeEnd = 233539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildCardInPlayList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_RebuildCardInPlayList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x0002E9F0 File Offset: 0x0002CBF0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233575, RefRangeEnd = 233576, XrefRangeStart = 233540, XrefRangeEnd = 233575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildInterface()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_RebuildInterface_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x0002EA24 File Offset: 0x0002CC24
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233691, RefRangeEnd = 233692, XrefRangeStart = 233576, XrefRangeEnd = 233691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildAnimationManager()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr_RebuildAnimationManager_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x0002EA58 File Offset: 0x0002CC58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233692, XrefRangeEnd = 233722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionGame()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionGame>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x0000574B File Offset: 0x0000394B
	public AscensionGame(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000209 RID: 521
	// (get) Token: 0x0600063D RID: 1597 RVA: 0x0002EA94 File Offset: 0x0002CC94
	// (set) Token: 0x0600063E RID: 1598 RVA: 0x00005754 File Offset: 0x00003954
	public unsafe static int k_maxDataSize
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionGame.NativeFieldInfoPtr_k_maxDataSize, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionGame.NativeFieldInfoPtr_k_maxDataSize, (void*)(&value));
		}
	}

	// Token: 0x1700020A RID: 522
	// (get) Token: 0x0600063F RID: 1599 RVA: 0x0002EAB0 File Offset: 0x0002CCB0
	// (set) Token: 0x06000640 RID: 1600 RVA: 0x00005762 File Offset: 0x00003962
	public unsafe static int k_maxCardCount
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionGame.NativeFieldInfoPtr_k_maxCardCount, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionGame.NativeFieldInfoPtr_k_maxCardCount, (void*)(&value));
		}
	}

	// Token: 0x1700020B RID: 523
	// (get) Token: 0x06000641 RID: 1601 RVA: 0x0002EACC File Offset: 0x0002CCCC
	// (set) Token: 0x06000642 RID: 1602 RVA: 0x00005770 File Offset: 0x00003970
	public unsafe static int k_maxQueryCount
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionGame.NativeFieldInfoPtr_k_maxQueryCount, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionGame.NativeFieldInfoPtr_k_maxQueryCount, (void*)(&value));
		}
	}

	// Token: 0x1700020C RID: 524
	// (get) Token: 0x06000643 RID: 1603 RVA: 0x0002EAE8 File Offset: 0x0002CCE8
	// (set) Token: 0x06000644 RID: 1604 RVA: 0x0000577E File Offset: 0x0000397E
	public unsafe static bool s_loadingIntoCompletedGame
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(AscensionGame.NativeFieldInfoPtr_s_loadingIntoCompletedGame, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionGame.NativeFieldInfoPtr_s_loadingIntoCompletedGame, (void*)(&value));
		}
	}

	// Token: 0x1700020D RID: 525
	// (get) Token: 0x06000645 RID: 1605 RVA: 0x0002EB04 File Offset: 0x0002CD04
	// (set) Token: 0x06000646 RID: 1606 RVA: 0x0000578C File Offset: 0x0000398C
	public unsafe AscensionCardManager m_CardManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_CardManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCardManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_CardManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700020E RID: 526
	// (get) Token: 0x06000647 RID: 1607 RVA: 0x0002EB34 File Offset: 0x0002CD34
	// (set) Token: 0x06000648 RID: 1608 RVA: 0x000057AB File Offset: 0x000039AB
	public unsafe DragManager m_DragManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DragManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DragManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DragManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700020F RID: 527
	// (get) Token: 0x06000649 RID: 1609 RVA: 0x0002EB64 File Offset: 0x0002CD64
	// (set) Token: 0x0600064A RID: 1610 RVA: 0x000057CA File Offset: 0x000039CA
	public unsafe AscensionAnimationManager m_AnimationManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_AnimationManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_AnimationManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000210 RID: 528
	// (get) Token: 0x0600064B RID: 1611 RVA: 0x0002EB94 File Offset: 0x0002CD94
	// (set) Token: 0x0600064C RID: 1612 RVA: 0x000057E9 File Offset: 0x000039E9
	public unsafe AscensionMagnifyManager m_MagnifyManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_MagnifyManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionMagnifyManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_MagnifyManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000211 RID: 529
	// (get) Token: 0x0600064D RID: 1613 RVA: 0x0002EBC4 File Offset: 0x0002CDC4
	// (set) Token: 0x0600064E RID: 1614 RVA: 0x00005808 File Offset: 0x00003A08
	public unsafe AscensionAudioHandlerIngame m_AudioHandler
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_AudioHandler);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAudioHandlerIngame>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_AudioHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000212 RID: 530
	// (get) Token: 0x0600064F RID: 1615 RVA: 0x0002EBF4 File Offset: 0x0002CDF4
	// (set) Token: 0x06000650 RID: 1616 RVA: 0x00005827 File Offset: 0x00003A27
	public unsafe Il2CppReferenceArray<AscensionCenterRow> m_CenterRowSlots
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_CenterRowSlots);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AscensionCenterRow>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_CenterRowSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000213 RID: 531
	// (get) Token: 0x06000651 RID: 1617 RVA: 0x0002EC24 File Offset: 0x0002CE24
	// (set) Token: 0x06000652 RID: 1618 RVA: 0x00005846 File Offset: 0x00003A46
	public unsafe Vector3 m_CenterRowSeventhSlotScalar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_CenterRowSeventhSlotScalar);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_CenterRowSeventhSlotScalar)) = value;
		}
	}

	// Token: 0x17000214 RID: 532
	// (get) Token: 0x06000653 RID: 1619 RVA: 0x0002EC4C File Offset: 0x0002CE4C
	// (set) Token: 0x06000654 RID: 1620 RVA: 0x00005861 File Offset: 0x00003A61
	public unsafe AscensionAnimationLocator m_PortalDeckLocator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PortalDeckLocator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PortalDeckLocator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000215 RID: 533
	// (get) Token: 0x06000655 RID: 1621 RVA: 0x0002EC7C File Offset: 0x0002CE7C
	// (set) Token: 0x06000656 RID: 1622 RVA: 0x00005880 File Offset: 0x00003A80
	public unsafe AscensionAnimationLocator m_LocatorPortalDeckAnnounce
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorPortalDeckAnnounce);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorPortalDeckAnnounce), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000216 RID: 534
	// (get) Token: 0x06000657 RID: 1623 RVA: 0x0002ECAC File Offset: 0x0002CEAC
	// (set) Token: 0x06000658 RID: 1624 RVA: 0x0000589F File Offset: 0x00003A9F
	public unsafe AscensionAnimationLocator m_VoidPileLocator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_VoidPileLocator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_VoidPileLocator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000217 RID: 535
	// (get) Token: 0x06000659 RID: 1625 RVA: 0x0002ECDC File Offset: 0x0002CEDC
	// (set) Token: 0x0600065A RID: 1626 RVA: 0x000058BE File Offset: 0x00003ABE
	public unsafe AscensionAnimationLocator m_UnderVoidPileLocator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_UnderVoidPileLocator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_UnderVoidPileLocator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000218 RID: 536
	// (get) Token: 0x0600065B RID: 1627 RVA: 0x0002ED0C File Offset: 0x0002CF0C
	// (set) Token: 0x0600065C RID: 1628 RVA: 0x000058DD File Offset: 0x00003ADD
	public unsafe AscensionAnimationLocator m_VoidPileLocatorEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_VoidPileLocatorEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_VoidPileLocatorEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000219 RID: 537
	// (get) Token: 0x0600065D RID: 1629 RVA: 0x0002ED3C File Offset: 0x0002CF3C
	// (set) Token: 0x0600065E RID: 1630 RVA: 0x000058FC File Offset: 0x00003AFC
	public unsafe AscensionAnimationLocator m_UnderVoidPileLocatorEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_UnderVoidPileLocatorEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_UnderVoidPileLocatorEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700021A RID: 538
	// (get) Token: 0x0600065F RID: 1631 RVA: 0x0002ED6C File Offset: 0x0002CF6C
	// (set) Token: 0x06000660 RID: 1632 RVA: 0x0000591B File Offset: 0x00003B1B
	public unsafe AscensionAnimationLocator m_LocatorVoidPileTray
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorVoidPileTray);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorVoidPileTray), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700021B RID: 539
	// (get) Token: 0x06000661 RID: 1633 RVA: 0x0002ED9C File Offset: 0x0002CF9C
	// (set) Token: 0x06000662 RID: 1634 RVA: 0x0000593A File Offset: 0x00003B3A
	public unsafe AscensionAnimationLocator m_LocatorActionAreaPlayedCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorActionAreaPlayedCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorActionAreaPlayedCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700021C RID: 540
	// (get) Token: 0x06000663 RID: 1635 RVA: 0x0002EDCC File Offset: 0x0002CFCC
	// (set) Token: 0x06000664 RID: 1636 RVA: 0x00005959 File Offset: 0x00003B59
	public unsafe AscensionAnimationLocator m_LocatorResolveEffectStack
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorResolveEffectStack);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorResolveEffectStack), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700021D RID: 541
	// (get) Token: 0x06000665 RID: 1637 RVA: 0x0002EDFC File Offset: 0x0002CFFC
	// (set) Token: 0x06000666 RID: 1638 RVA: 0x00005978 File Offset: 0x00003B78
	public unsafe AscensionAnimationLocator m_LocatorRevealedCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorRevealedCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorRevealedCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700021E RID: 542
	// (get) Token: 0x06000667 RID: 1639 RVA: 0x0002EE2C File Offset: 0x0002D02C
	// (set) Token: 0x06000668 RID: 1640 RVA: 0x00005997 File Offset: 0x00003B97
	public unsafe AscensionAnimationLocator m_LocatorRevealAnnounce
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorRevealAnnounce);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorRevealAnnounce), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700021F RID: 543
	// (get) Token: 0x06000669 RID: 1641 RVA: 0x0002EE5C File Offset: 0x0002D05C
	// (set) Token: 0x0600066A RID: 1642 RVA: 0x000059B6 File Offset: 0x00003BB6
	public unsafe AscensionAnimationLocator m_LocatorEventCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorEventCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorEventCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000220 RID: 544
	// (get) Token: 0x0600066B RID: 1643 RVA: 0x0002EE8C File Offset: 0x0002D08C
	// (set) Token: 0x0600066C RID: 1644 RVA: 0x000059D5 File Offset: 0x00003BD5
	public unsafe AscensionAnimationLocator m_LocatorAvailableTemples
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorAvailableTemples);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorAvailableTemples), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000221 RID: 545
	// (get) Token: 0x0600066D RID: 1645 RVA: 0x0002EEBC File Offset: 0x0002D0BC
	// (set) Token: 0x0600066E RID: 1646 RVA: 0x000059F4 File Offset: 0x00003BF4
	public unsafe AscensionAnimationLocator m_LocatorAvailableTemplesAnnounce
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorAvailableTemplesAnnounce);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorAvailableTemplesAnnounce), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000222 RID: 546
	// (get) Token: 0x0600066F RID: 1647 RVA: 0x0002EEEC File Offset: 0x0002D0EC
	// (set) Token: 0x06000670 RID: 1648 RVA: 0x00005A13 File Offset: 0x00003C13
	public unsafe AscensionAnimationLocator m_LocatorDeliriumDieStart
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorDeliriumDieStart);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorDeliriumDieStart), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000223 RID: 547
	// (get) Token: 0x06000671 RID: 1649 RVA: 0x0002EF1C File Offset: 0x0002D11C
	// (set) Token: 0x06000672 RID: 1650 RVA: 0x00005A32 File Offset: 0x00003C32
	public unsafe AscensionAnimationLocator m_LocatorDeliriumDieResolve
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorDeliriumDieResolve);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorDeliriumDieResolve), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000224 RID: 548
	// (get) Token: 0x06000673 RID: 1651 RVA: 0x0002EF4C File Offset: 0x0002D14C
	// (set) Token: 0x06000674 RID: 1652 RVA: 0x00005A51 File Offset: 0x00003C51
	public unsafe AscensionAnimationLocator m_LocatorUniqueCardZone
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorUniqueCardZone);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorUniqueCardZone), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000225 RID: 549
	// (get) Token: 0x06000675 RID: 1653 RVA: 0x0002EF7C File Offset: 0x0002D17C
	// (set) Token: 0x06000676 RID: 1654 RVA: 0x00005A70 File Offset: 0x00003C70
	public unsafe AscensionAnimationLocator m_LocatorChampionIncoming
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorChampionIncoming);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorChampionIncoming), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000226 RID: 550
	// (get) Token: 0x06000677 RID: 1655 RVA: 0x0002EFAC File Offset: 0x0002D1AC
	// (set) Token: 0x06000678 RID: 1656 RVA: 0x00005A8F File Offset: 0x00003C8F
	public unsafe AscensionAnimationLocator m_LocatorChampionOutgoing
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorChampionOutgoing);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorChampionOutgoing), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000227 RID: 551
	// (get) Token: 0x06000679 RID: 1657 RVA: 0x0002EFDC File Offset: 0x0002D1DC
	// (set) Token: 0x0600067A RID: 1658 RVA: 0x00005AAE File Offset: 0x00003CAE
	public unsafe AscensionTransformEffect m_TransformEffect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TransformEffect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionTransformEffect>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TransformEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000228 RID: 552
	// (get) Token: 0x0600067B RID: 1659 RVA: 0x0002F00C File Offset: 0x0002D20C
	// (set) Token: 0x0600067C RID: 1660 RVA: 0x00005ACD File Offset: 0x00003CCD
	public unsafe GameObject m_LocalPlayerDreamscapeArea
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDreamscapeArea);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDreamscapeArea), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000229 RID: 553
	// (get) Token: 0x0600067D RID: 1661 RVA: 0x0002F03C File Offset: 0x0002D23C
	// (set) Token: 0x0600067E RID: 1662 RVA: 0x00005AEC File Offset: 0x00003CEC
	public unsafe GameObject m_LocalPlayerDreamscapeButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDreamscapeButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDreamscapeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700022A RID: 554
	// (get) Token: 0x0600067F RID: 1663 RVA: 0x0002F06C File Offset: 0x0002D26C
	// (set) Token: 0x06000680 RID: 1664 RVA: 0x00005B0B File Offset: 0x00003D0B
	public unsafe GameObject m_LocalPlayerDreamscapeCenterSpacer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDreamscapeCenterSpacer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDreamscapeCenterSpacer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700022B RID: 555
	// (get) Token: 0x06000681 RID: 1665 RVA: 0x0002F09C File Offset: 0x0002D29C
	// (set) Token: 0x06000682 RID: 1666 RVA: 0x00005B2A File Offset: 0x00003D2A
	public unsafe GameObject m_LocalPlayerDreamscapeGlow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDreamscapeGlow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDreamscapeGlow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700022C RID: 556
	// (get) Token: 0x06000683 RID: 1667 RVA: 0x0002F0CC File Offset: 0x0002D2CC
	// (set) Token: 0x06000684 RID: 1668 RVA: 0x00005B49 File Offset: 0x00003D49
	public unsafe GameObject m_LocalPlayerDreamscapeGlowFreeCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDreamscapeGlowFreeCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDreamscapeGlowFreeCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700022D RID: 557
	// (get) Token: 0x06000685 RID: 1669 RVA: 0x0002F0FC File Offset: 0x0002D2FC
	// (set) Token: 0x06000686 RID: 1670 RVA: 0x00005B68 File Offset: 0x00003D68
	public unsafe GameObject m_LocalPlayerLeprechaunArea
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerLeprechaunArea);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerLeprechaunArea), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700022E RID: 558
	// (get) Token: 0x06000687 RID: 1671 RVA: 0x0002F12C File Offset: 0x0002D32C
	// (set) Token: 0x06000688 RID: 1672 RVA: 0x00005B87 File Offset: 0x00003D87
	public unsafe GameObject m_PsytheaRedeemedArea
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PsytheaRedeemedArea);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PsytheaRedeemedArea), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700022F RID: 559
	// (get) Token: 0x06000689 RID: 1673 RVA: 0x0002F15C File Offset: 0x0002D35C
	// (set) Token: 0x0600068A RID: 1674 RVA: 0x00005BA6 File Offset: 0x00003DA6
	public unsafe GameObject m_PsytheaRedeemedGlow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PsytheaRedeemedGlow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PsytheaRedeemedGlow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000230 RID: 560
	// (get) Token: 0x0600068B RID: 1675 RVA: 0x0002F18C File Offset: 0x0002D38C
	// (set) Token: 0x0600068C RID: 1676 RVA: 0x00005BC5 File Offset: 0x00003DC5
	public unsafe GameObject m_PsytheaRedeemedGlowFreeCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PsytheaRedeemedGlowFreeCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PsytheaRedeemedGlowFreeCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000231 RID: 561
	// (get) Token: 0x0600068D RID: 1677 RVA: 0x0002F1BC File Offset: 0x0002D3BC
	// (set) Token: 0x0600068E RID: 1678 RVA: 0x00005BE4 File Offset: 0x00003DE4
	public unsafe AscensionLog m_gameLog
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_gameLog);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionLog>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_gameLog), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000232 RID: 562
	// (get) Token: 0x0600068F RID: 1679 RVA: 0x0002F1EC File Offset: 0x0002D3EC
	// (set) Token: 0x06000690 RID: 1680 RVA: 0x00005C03 File Offset: 0x00003E03
	public unsafe Il2CppReferenceArray<GameOptionButton> m_GameOptionButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_GameOptionButtons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameOptionButton>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_GameOptionButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000233 RID: 563
	// (get) Token: 0x06000691 RID: 1681 RVA: 0x0002F21C File Offset: 0x0002D41C
	// (set) Token: 0x06000692 RID: 1682 RVA: 0x00005C22 File Offset: 0x00003E22
	public unsafe Il2CppReferenceArray<GameOptionPlayerButton> m_GameOptionPlayerButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_GameOptionPlayerButtons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameOptionPlayerButton>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_GameOptionPlayerButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000234 RID: 564
	// (get) Token: 0x06000693 RID: 1683 RVA: 0x0002F24C File Offset: 0x0002D44C
	// (set) Token: 0x06000694 RID: 1684 RVA: 0x00005C41 File Offset: 0x00003E41
	public unsafe PlayerDisplay m_LocalPlayerDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerDisplay>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000235 RID: 565
	// (get) Token: 0x06000695 RID: 1685 RVA: 0x0002F27C File Offset: 0x0002D47C
	// (set) Token: 0x06000696 RID: 1686 RVA: 0x00005C60 File Offset: 0x00003E60
	public unsafe Il2CppReferenceArray<OpponentTray> m_OpponentTrays
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_OpponentTrays);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OpponentTray>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_OpponentTrays), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000236 RID: 566
	// (get) Token: 0x06000697 RID: 1687 RVA: 0x0002F2AC File Offset: 0x0002D4AC
	// (set) Token: 0x06000698 RID: 1688 RVA: 0x00005C7F File Offset: 0x00003E7F
	public unsafe OpponentTray m_ActiveOpponentTray
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_ActiveOpponentTray);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<OpponentTray>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_ActiveOpponentTray), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000237 RID: 567
	// (get) Token: 0x06000699 RID: 1689 RVA: 0x0002F2DC File Offset: 0x0002D4DC
	// (set) Token: 0x0600069A RID: 1690 RVA: 0x00005C9E File Offset: 0x00003E9E
	public unsafe GameObject m_ActionAreaEndTurnButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_ActionAreaEndTurnButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_ActionAreaEndTurnButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000238 RID: 568
	// (get) Token: 0x0600069B RID: 1691 RVA: 0x0002F30C File Offset: 0x0002D50C
	// (set) Token: 0x0600069C RID: 1692 RVA: 0x00005CBD File Offset: 0x00003EBD
	public unsafe GameObject m_ActionAreaPlayAllButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_ActionAreaPlayAllButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_ActionAreaPlayAllButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000239 RID: 569
	// (get) Token: 0x0600069D RID: 1693 RVA: 0x0002F33C File Offset: 0x0002D53C
	// (set) Token: 0x0600069E RID: 1694 RVA: 0x00005CDC File Offset: 0x00003EDC
	public unsafe GameObject m_ActionAreaNoneButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_ActionAreaNoneButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_ActionAreaNoneButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700023A RID: 570
	// (get) Token: 0x0600069F RID: 1695 RVA: 0x0002F36C File Offset: 0x0002D56C
	// (set) Token: 0x060006A0 RID: 1696 RVA: 0x00005CFB File Offset: 0x00003EFB
	public unsafe Image m_ActionAreaLeftCapHighlight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_ActionAreaLeftCapHighlight);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_ActionAreaLeftCapHighlight), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700023B RID: 571
	// (get) Token: 0x060006A1 RID: 1697 RVA: 0x0002F39C File Offset: 0x0002D59C
	// (set) Token: 0x060006A2 RID: 1698 RVA: 0x00005D1A File Offset: 0x00003F1A
	public unsafe Image m_ActionAreaRightCapHighlight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_ActionAreaRightCapHighlight);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_ActionAreaRightCapHighlight), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700023C RID: 572
	// (get) Token: 0x060006A3 RID: 1699 RVA: 0x0002F3CC File Offset: 0x0002D5CC
	// (set) Token: 0x060006A4 RID: 1700 RVA: 0x00005D39 File Offset: 0x00003F39
	public unsafe GameObject m_RoundNumberDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_RoundNumberDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_RoundNumberDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700023D RID: 573
	// (get) Token: 0x060006A5 RID: 1701 RVA: 0x0002F3FC File Offset: 0x0002D5FC
	// (set) Token: 0x060006A6 RID: 1702 RVA: 0x00005D58 File Offset: 0x00003F58
	public unsafe TextMeshProUGUI m_RoundNumberText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_RoundNumberText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_RoundNumberText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700023E RID: 574
	// (get) Token: 0x060006A7 RID: 1703 RVA: 0x0002F42C File Offset: 0x0002D62C
	// (set) Token: 0x060006A8 RID: 1704 RVA: 0x00005D77 File Offset: 0x00003F77
	public unsafe TextMeshProUGUI m_HonorPoolText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_HonorPoolText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_HonorPoolText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700023F RID: 575
	// (get) Token: 0x060006A9 RID: 1705 RVA: 0x0002F45C File Offset: 0x0002D65C
	// (set) Token: 0x060006AA RID: 1706 RVA: 0x00005D96 File Offset: 0x00003F96
	public unsafe GameObject m_HonorPoolGlowObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_HonorPoolGlowObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_HonorPoolGlowObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000240 RID: 576
	// (get) Token: 0x060006AB RID: 1707 RVA: 0x0002F48C File Offset: 0x0002D68C
	// (set) Token: 0x060006AC RID: 1708 RVA: 0x00005DB5 File Offset: 0x00003FB5
	public unsafe Image m_HonorPoolGlowImage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_HonorPoolGlowImage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_HonorPoolGlowImage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000241 RID: 577
	// (get) Token: 0x060006AD RID: 1709 RVA: 0x0002F4BC File Offset: 0x0002D6BC
	// (set) Token: 0x060006AE RID: 1710 RVA: 0x00005DD4 File Offset: 0x00003FD4
	public unsafe ParticleSystem m_HonorPoolGlowParticles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_HonorPoolGlowParticles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_HonorPoolGlowParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000242 RID: 578
	// (get) Token: 0x060006AF RID: 1711 RVA: 0x0002F4EC File Offset: 0x0002D6EC
	// (set) Token: 0x060006B0 RID: 1712 RVA: 0x00005DF3 File Offset: 0x00003FF3
	public unsafe Il2CppStructArray<Color> m_HonorPoolGlowColors
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_HonorPoolGlowColors);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_HonorPoolGlowColors), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000243 RID: 579
	// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0002F51C File Offset: 0x0002D71C
	// (set) Token: 0x060006B2 RID: 1714 RVA: 0x00005E12 File Offset: 0x00004012
	public unsafe TextMeshProUGUI m_RuneCountText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_RuneCountText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_RuneCountText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000244 RID: 580
	// (get) Token: 0x060006B3 RID: 1715 RVA: 0x0002F54C File Offset: 0x0002D74C
	// (set) Token: 0x060006B4 RID: 1716 RVA: 0x00005E31 File Offset: 0x00004031
	public unsafe TextMeshProUGUI m_PowerCountText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PowerCountText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PowerCountText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000245 RID: 581
	// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0002F57C File Offset: 0x0002D77C
	// (set) Token: 0x060006B6 RID: 1718 RVA: 0x00005E50 File Offset: 0x00004050
	public unsafe GameObject m_RuneMechanaCountDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_RuneMechanaCountDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_RuneMechanaCountDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000246 RID: 582
	// (get) Token: 0x060006B7 RID: 1719 RVA: 0x0002F5AC File Offset: 0x0002D7AC
	// (set) Token: 0x060006B8 RID: 1720 RVA: 0x00005E6F File Offset: 0x0000406F
	public unsafe TextMeshProUGUI m_RuneMechanaCountText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_RuneMechanaCountText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_RuneMechanaCountText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000247 RID: 583
	// (get) Token: 0x060006B9 RID: 1721 RVA: 0x0002F5DC File Offset: 0x0002D7DC
	// (set) Token: 0x060006BA RID: 1722 RVA: 0x00005E8E File Offset: 0x0000408E
	public unsafe GameObject m_RuneGlowGeneric
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_RuneGlowGeneric);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_RuneGlowGeneric), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000248 RID: 584
	// (get) Token: 0x060006BB RID: 1723 RVA: 0x0002F60C File Offset: 0x0002D80C
	// (set) Token: 0x060006BC RID: 1724 RVA: 0x00005EAD File Offset: 0x000040AD
	public unsafe GameObject m_RuneGlowLifebound
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_RuneGlowLifebound);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_RuneGlowLifebound), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000249 RID: 585
	// (get) Token: 0x060006BD RID: 1725 RVA: 0x0002F63C File Offset: 0x0002D83C
	// (set) Token: 0x060006BE RID: 1726 RVA: 0x00005ECC File Offset: 0x000040CC
	public unsafe GameObject m_PowerGlow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PowerGlow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PowerGlow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700024A RID: 586
	// (get) Token: 0x060006BF RID: 1727 RVA: 0x0002F66C File Offset: 0x0002D86C
	// (set) Token: 0x060006C0 RID: 1728 RVA: 0x00005EEB File Offset: 0x000040EB
	public unsafe GameObject m_EnergyCountDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_EnergyCountDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_EnergyCountDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700024B RID: 587
	// (get) Token: 0x060006C1 RID: 1729 RVA: 0x0002F69C File Offset: 0x0002D89C
	// (set) Token: 0x060006C2 RID: 1730 RVA: 0x00005F0A File Offset: 0x0000410A
	public unsafe TextMeshProUGUI m_EnergyCountText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_EnergyCountText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_EnergyCountText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700024C RID: 588
	// (get) Token: 0x060006C3 RID: 1731 RVA: 0x0002F6CC File Offset: 0x0002D8CC
	// (set) Token: 0x060006C4 RID: 1732 RVA: 0x00005F29 File Offset: 0x00004129
	public unsafe Il2CppReferenceArray<GameObject> m_TempleResourceDisplayList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TempleResourceDisplayList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TempleResourceDisplayList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700024D RID: 589
	// (get) Token: 0x060006C5 RID: 1733 RVA: 0x0002F6FC File Offset: 0x0002D8FC
	// (set) Token: 0x060006C6 RID: 1734 RVA: 0x00005F48 File Offset: 0x00004148
	public unsafe TextMeshProUGUI m_TempleLifeCountText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TempleLifeCountText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TempleLifeCountText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700024E RID: 590
	// (get) Token: 0x060006C7 RID: 1735 RVA: 0x0002F72C File Offset: 0x0002D92C
	// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00005F67 File Offset: 0x00004167
	public unsafe TextMeshProUGUI m_TempleDeathCountText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TempleDeathCountText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TempleDeathCountText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700024F RID: 591
	// (get) Token: 0x060006C9 RID: 1737 RVA: 0x0002F75C File Offset: 0x0002D95C
	// (set) Token: 0x060006CA RID: 1738 RVA: 0x00005F86 File Offset: 0x00004186
	public unsafe TextMeshProUGUI m_PortalDeckCountText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PortalDeckCountText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PortalDeckCountText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000250 RID: 592
	// (get) Token: 0x060006CB RID: 1739 RVA: 0x0002F78C File Offset: 0x0002D98C
	// (set) Token: 0x060006CC RID: 1740 RVA: 0x00005FA5 File Offset: 0x000041A5
	public unsafe TextMeshProUGUI m_VoidPileCountText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_VoidPileCountText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_VoidPileCountText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000251 RID: 593
	// (get) Token: 0x060006CD RID: 1741 RVA: 0x0002F7BC File Offset: 0x0002D9BC
	// (set) Token: 0x060006CE RID: 1742 RVA: 0x00005FC4 File Offset: 0x000041C4
	public unsafe Il2CppReferenceArray<GameObject> m_DayNightRootList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DayNightRootList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DayNightRootList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000252 RID: 594
	// (get) Token: 0x060006CF RID: 1743 RVA: 0x0002F7EC File Offset: 0x0002D9EC
	// (set) Token: 0x060006D0 RID: 1744 RVA: 0x00005FE3 File Offset: 0x000041E3
	public unsafe Il2CppReferenceArray<GameObject> m_DayNightDayList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DayNightDayList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DayNightDayList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000253 RID: 595
	// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0002F81C File Offset: 0x0002DA1C
	// (set) Token: 0x060006D2 RID: 1746 RVA: 0x00006002 File Offset: 0x00004202
	public unsafe Il2CppReferenceArray<GameObject> m_DayNightDayOnlyList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DayNightDayOnlyList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DayNightDayOnlyList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000254 RID: 596
	// (get) Token: 0x060006D3 RID: 1747 RVA: 0x0002F84C File Offset: 0x0002DA4C
	// (set) Token: 0x060006D4 RID: 1748 RVA: 0x00006021 File Offset: 0x00004221
	public unsafe Il2CppReferenceArray<GameObject> m_DayNightNightList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DayNightNightList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DayNightNightList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000255 RID: 597
	// (get) Token: 0x060006D5 RID: 1749 RVA: 0x0002F87C File Offset: 0x0002DA7C
	// (set) Token: 0x060006D6 RID: 1750 RVA: 0x00006040 File Offset: 0x00004240
	public unsafe Il2CppReferenceArray<GameObject> m_DayNightNightOnlyList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DayNightNightOnlyList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DayNightNightOnlyList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000256 RID: 598
	// (get) Token: 0x060006D7 RID: 1751 RVA: 0x0002F8AC File Offset: 0x0002DAAC
	// (set) Token: 0x060006D8 RID: 1752 RVA: 0x0000605F File Offset: 0x0000425F
	public unsafe Il2CppReferenceArray<GameObject> m_DayNightBothList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DayNightBothList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DayNightBothList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000257 RID: 599
	// (get) Token: 0x060006D9 RID: 1753 RVA: 0x0002F8DC File Offset: 0x0002DADC
	// (set) Token: 0x060006DA RID: 1754 RVA: 0x0000607E File Offset: 0x0000427E
	public unsafe GameObject m_LocalPlayerDeckList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDeckList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDeckList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000258 RID: 600
	// (get) Token: 0x060006DB RID: 1755 RVA: 0x0002F90C File Offset: 0x0002DB0C
	// (set) Token: 0x060006DC RID: 1756 RVA: 0x0000609D File Offset: 0x0000429D
	public unsafe TrayToggle m_LocalPlayerDeckTrayToggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDeckTrayToggle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrayToggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDeckTrayToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000259 RID: 601
	// (get) Token: 0x060006DD RID: 1757 RVA: 0x0002F93C File Offset: 0x0002DB3C
	// (set) Token: 0x060006DE RID: 1758 RVA: 0x000060BC File Offset: 0x000042BC
	public unsafe TrayToggle m_LocalPlayerDiscardTrayToggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDiscardTrayToggle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrayToggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDiscardTrayToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700025A RID: 602
	// (get) Token: 0x060006DF RID: 1759 RVA: 0x0002F96C File Offset: 0x0002DB6C
	// (set) Token: 0x060006E0 RID: 1760 RVA: 0x000060DB File Offset: 0x000042DB
	public unsafe TrayToggle m_LocalPlayerConstructTrayToggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerConstructTrayToggle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrayToggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerConstructTrayToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700025B RID: 603
	// (get) Token: 0x060006E1 RID: 1761 RVA: 0x0002F99C File Offset: 0x0002DB9C
	// (set) Token: 0x060006E2 RID: 1762 RVA: 0x000060FA File Offset: 0x000042FA
	public unsafe TrayToggle m_LocalPlayerDreamscapeTrayToggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDreamscapeTrayToggle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrayToggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDreamscapeTrayToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700025C RID: 604
	// (get) Token: 0x060006E3 RID: 1763 RVA: 0x0002F9CC File Offset: 0x0002DBCC
	// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00006119 File Offset: 0x00004319
	public unsafe TrayToggle m_LocalPlayerLeprechaunTrayToggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerLeprechaunTrayToggle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrayToggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerLeprechaunTrayToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700025D RID: 605
	// (get) Token: 0x060006E5 RID: 1765 RVA: 0x0002F9FC File Offset: 0x0002DBFC
	// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00006138 File Offset: 0x00004338
	public unsafe TrayToggle m_VoidTrayToggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_VoidTrayToggle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrayToggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_VoidTrayToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700025E RID: 606
	// (get) Token: 0x060006E7 RID: 1767 RVA: 0x0002FA2C File Offset: 0x0002DC2C
	// (set) Token: 0x060006E8 RID: 1768 RVA: 0x00006157 File Offset: 0x00004357
	public unsafe GameObject m_LocalPlayerDrawPileList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDrawPileList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDrawPileList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700025F RID: 607
	// (get) Token: 0x060006E9 RID: 1769 RVA: 0x0002FA5C File Offset: 0x0002DC5C
	// (set) Token: 0x060006EA RID: 1770 RVA: 0x00006176 File Offset: 0x00004376
	public unsafe AscensionAnimationLocatorSorted m_LocatorDrawPileList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorDrawPileList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocatorSorted>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorDrawPileList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000260 RID: 608
	// (get) Token: 0x060006EB RID: 1771 RVA: 0x0002FA8C File Offset: 0x0002DC8C
	// (set) Token: 0x060006EC RID: 1772 RVA: 0x00006195 File Offset: 0x00004395
	public unsafe GameObject m_LocalPlayerLifeboundList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerLifeboundList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerLifeboundList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000261 RID: 609
	// (get) Token: 0x060006ED RID: 1773 RVA: 0x0002FABC File Offset: 0x0002DCBC
	// (set) Token: 0x060006EE RID: 1774 RVA: 0x000061B4 File Offset: 0x000043B4
	public unsafe AscensionAnimationLocatorSorted m_LocatorLifeboundList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorLifeboundList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocatorSorted>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorLifeboundList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000262 RID: 610
	// (get) Token: 0x060006EF RID: 1775 RVA: 0x0002FAEC File Offset: 0x0002DCEC
	// (set) Token: 0x060006F0 RID: 1776 RVA: 0x000061D3 File Offset: 0x000043D3
	public unsafe GameObject m_LocalPlayerDefeatedMonsterList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDefeatedMonsterList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerDefeatedMonsterList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000263 RID: 611
	// (get) Token: 0x060006F1 RID: 1777 RVA: 0x0002FB1C File Offset: 0x0002DD1C
	// (set) Token: 0x060006F2 RID: 1778 RVA: 0x000061F2 File Offset: 0x000043F2
	public unsafe AscensionAnimationLocatorSorted m_LocatorDefeatedMonsterList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorDefeatedMonsterList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocatorSorted>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocatorDefeatedMonsterList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000264 RID: 612
	// (get) Token: 0x060006F3 RID: 1779 RVA: 0x0002FB4C File Offset: 0x0002DD4C
	// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00006211 File Offset: 0x00004411
	public unsafe GameObject m_KingdomStackTray
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_KingdomStackTray);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_KingdomStackTray), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000265 RID: 613
	// (get) Token: 0x060006F5 RID: 1781 RVA: 0x0002FB7C File Offset: 0x0002DD7C
	// (set) Token: 0x060006F6 RID: 1782 RVA: 0x00006230 File Offset: 0x00004430
	public unsafe GameObject m_LeprechaunStackTray
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LeprechaunStackTray);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LeprechaunStackTray), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000266 RID: 614
	// (get) Token: 0x060006F7 RID: 1783 RVA: 0x0002FBAC File Offset: 0x0002DDAC
	// (set) Token: 0x060006F8 RID: 1784 RVA: 0x0000624F File Offset: 0x0000444F
	public unsafe GameObject m_KingdomStackPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_KingdomStackPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_KingdomStackPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000267 RID: 615
	// (get) Token: 0x060006F9 RID: 1785 RVA: 0x0002FBDC File Offset: 0x0002DDDC
	// (set) Token: 0x060006FA RID: 1786 RVA: 0x0000626E File Offset: 0x0000446E
	public unsafe GameObject m_OptionPrompt
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_OptionPrompt);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_OptionPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000268 RID: 616
	// (get) Token: 0x060006FB RID: 1787 RVA: 0x0002FC0C File Offset: 0x0002DE0C
	// (set) Token: 0x060006FC RID: 1788 RVA: 0x0000628D File Offset: 0x0000448D
	public unsafe Animator m_OptionPromptAnimator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_OptionPromptAnimator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_OptionPromptAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000269 RID: 617
	// (get) Token: 0x060006FD RID: 1789 RVA: 0x0002FC3C File Offset: 0x0002DE3C
	// (set) Token: 0x060006FE RID: 1790 RVA: 0x000062AC File Offset: 0x000044AC
	public unsafe TextMeshProUGUI m_OptionPromptText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_OptionPromptText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_OptionPromptText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700026A RID: 618
	// (get) Token: 0x060006FF RID: 1791 RVA: 0x0002FC6C File Offset: 0x0002DE6C
	// (set) Token: 0x06000700 RID: 1792 RVA: 0x000062CB File Offset: 0x000044CB
	public unsafe GameObject m_Button_NoAction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Button_NoAction);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Button_NoAction), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700026B RID: 619
	// (get) Token: 0x06000701 RID: 1793 RVA: 0x0002FC9C File Offset: 0x0002DE9C
	// (set) Token: 0x06000702 RID: 1794 RVA: 0x000062EA File Offset: 0x000044EA
	public unsafe GameObject m_Button_EndTurn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Button_EndTurn);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Button_EndTurn), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700026C RID: 620
	// (get) Token: 0x06000703 RID: 1795 RVA: 0x0002FCCC File Offset: 0x0002DECC
	// (set) Token: 0x06000704 RID: 1796 RVA: 0x00006309 File Offset: 0x00004509
	public unsafe GameObject m_Button_Commit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Button_Commit);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Button_Commit), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700026D RID: 621
	// (get) Token: 0x06000705 RID: 1797 RVA: 0x0002FCFC File Offset: 0x0002DEFC
	// (set) Token: 0x06000706 RID: 1798 RVA: 0x00006328 File Offset: 0x00004528
	public unsafe GameObject m_Button_Undo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Button_Undo);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Button_Undo), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700026E RID: 622
	// (get) Token: 0x06000707 RID: 1799 RVA: 0x0002FD2C File Offset: 0x0002DF2C
	// (set) Token: 0x06000708 RID: 1800 RVA: 0x00006347 File Offset: 0x00004547
	public unsafe Image m_Glow_EndTurn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700026F RID: 623
	// (get) Token: 0x06000709 RID: 1801 RVA: 0x0002FD5C File Offset: 0x0002DF5C
	// (set) Token: 0x0600070A RID: 1802 RVA: 0x00006366 File Offset: 0x00004566
	public unsafe ParticleSystem m_Glow_EndTurn_PS
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn_PS);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn_PS), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000270 RID: 624
	// (get) Token: 0x0600070B RID: 1803 RVA: 0x0002FD8C File Offset: 0x0002DF8C
	// (set) Token: 0x0600070C RID: 1804 RVA: 0x00006385 File Offset: 0x00004585
	public unsafe Button m_Glow_EndTurn_Button
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn_Button);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000271 RID: 625
	// (get) Token: 0x0600070D RID: 1805 RVA: 0x0002FDBC File Offset: 0x0002DFBC
	// (set) Token: 0x0600070E RID: 1806 RVA: 0x000063A4 File Offset: 0x000045A4
	public unsafe Color m_Glow_EndTurn_Red
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn_Red);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn_Red)) = value;
		}
	}

	// Token: 0x17000272 RID: 626
	// (get) Token: 0x0600070F RID: 1807 RVA: 0x0002FDE4 File Offset: 0x0002DFE4
	// (set) Token: 0x06000710 RID: 1808 RVA: 0x000063BF File Offset: 0x000045BF
	public unsafe Color m_Glow_EndTurn_Green
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn_Green);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn_Green)) = value;
		}
	}

	// Token: 0x17000273 RID: 627
	// (get) Token: 0x06000711 RID: 1809 RVA: 0x0002FE0C File Offset: 0x0002E00C
	// (set) Token: 0x06000712 RID: 1810 RVA: 0x000063DA File Offset: 0x000045DA
	public unsafe ColorBlock m_Glow_EndTurn_RedBlock
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn_RedBlock);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn_RedBlock)) = value;
		}
	}

	// Token: 0x17000274 RID: 628
	// (get) Token: 0x06000713 RID: 1811 RVA: 0x0002FE34 File Offset: 0x0002E034
	// (set) Token: 0x06000714 RID: 1812 RVA: 0x000063F5 File Offset: 0x000045F5
	public unsafe ColorBlock m_Glow_EndTurn_GreenBlock
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn_GreenBlock);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Glow_EndTurn_GreenBlock)) = value;
		}
	}

	// Token: 0x17000275 RID: 629
	// (get) Token: 0x06000715 RID: 1813 RVA: 0x0002FE5C File Offset: 0x0002E05C
	// (set) Token: 0x06000716 RID: 1814 RVA: 0x00006410 File Offset: 0x00004610
	public unsafe GameObject m_Button_DeliriumDie
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Button_DeliriumDie);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Button_DeliriumDie), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000276 RID: 630
	// (get) Token: 0x06000717 RID: 1815 RVA: 0x0002FE8C File Offset: 0x0002E08C
	// (set) Token: 0x06000718 RID: 1816 RVA: 0x0000642F File Offset: 0x0000462F
	public unsafe GameObject m_Glow_DeliriumDie
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Glow_DeliriumDie);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Glow_DeliriumDie), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000277 RID: 631
	// (get) Token: 0x06000719 RID: 1817 RVA: 0x0002FEBC File Offset: 0x0002E0BC
	// (set) Token: 0x0600071A RID: 1818 RVA: 0x0000644E File Offset: 0x0000464E
	public unsafe GameObject m_Popup_Chat
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_Chat);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_Chat), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000278 RID: 632
	// (get) Token: 0x0600071B RID: 1819 RVA: 0x0002FEEC File Offset: 0x0002E0EC
	// (set) Token: 0x0600071C RID: 1820 RVA: 0x0000646D File Offset: 0x0000466D
	public unsafe GameObject m_Popup_Chat_Button
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_Chat_Button);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_Chat_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000279 RID: 633
	// (get) Token: 0x0600071D RID: 1821 RVA: 0x0002FF1C File Offset: 0x0002E11C
	// (set) Token: 0x0600071E RID: 1822 RVA: 0x0000648C File Offset: 0x0000468C
	public unsafe TrayToggle m_Popup_Chat_Tray
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_Chat_Tray);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrayToggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_Chat_Tray), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700027A RID: 634
	// (get) Token: 0x0600071F RID: 1823 RVA: 0x0002FF4C File Offset: 0x0002E14C
	// (set) Token: 0x06000720 RID: 1824 RVA: 0x000064AB File Offset: 0x000046AB
	public unsafe GameObject m_Popup_Forfeit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_Forfeit);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_Forfeit), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700027B RID: 635
	// (get) Token: 0x06000721 RID: 1825 RVA: 0x0002FF7C File Offset: 0x0002E17C
	// (set) Token: 0x06000722 RID: 1826 RVA: 0x000064CA File Offset: 0x000046CA
	public unsafe GameObject m_Popup_Forfeit_KeepPlaying
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_Forfeit_KeepPlaying);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_Forfeit_KeepPlaying), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700027C RID: 636
	// (get) Token: 0x06000723 RID: 1827 RVA: 0x0002FFAC File Offset: 0x0002E1AC
	// (set) Token: 0x06000724 RID: 1828 RVA: 0x000064E9 File Offset: 0x000046E9
	public unsafe TextMeshProUGUI m_Popup_Forfeit_Text
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_Forfeit_Text);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_Forfeit_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700027D RID: 637
	// (get) Token: 0x06000725 RID: 1829 RVA: 0x0002FFDC File Offset: 0x0002E1DC
	// (set) Token: 0x06000726 RID: 1830 RVA: 0x00006508 File Offset: 0x00004708
	public unsafe GameObject m_Popup_Forfeit_Cancel_Button
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_Forfeit_Cancel_Button);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_Forfeit_Cancel_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700027E RID: 638
	// (get) Token: 0x06000727 RID: 1831 RVA: 0x0003000C File Offset: 0x0002E20C
	// (set) Token: 0x06000728 RID: 1832 RVA: 0x00006527 File Offset: 0x00004727
	public unsafe GameObject m_Popup_Forfeit_Continue_Button
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_Forfeit_Continue_Button);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_Forfeit_Continue_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700027F RID: 639
	// (get) Token: 0x06000729 RID: 1833 RVA: 0x0003003C File Offset: 0x0002E23C
	// (set) Token: 0x0600072A RID: 1834 RVA: 0x00006546 File Offset: 0x00004746
	public unsafe GameObject m_Popup_Forfeit_Confirm_Button
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_Forfeit_Confirm_Button);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_Forfeit_Confirm_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000280 RID: 640
	// (get) Token: 0x0600072B RID: 1835 RVA: 0x0003006C File Offset: 0x0002E26C
	// (set) Token: 0x0600072C RID: 1836 RVA: 0x00006565 File Offset: 0x00004765
	public unsafe GameObject m_Popup_EndTurn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_EndTurn);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_EndTurn), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000281 RID: 641
	// (get) Token: 0x0600072D RID: 1837 RVA: 0x0003009C File Offset: 0x0002E29C
	// (set) Token: 0x0600072E RID: 1838 RVA: 0x00006584 File Offset: 0x00004784
	public unsafe GameObject m_Popup_ConfirmMove
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_ConfirmMove);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_ConfirmMove), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000282 RID: 642
	// (get) Token: 0x0600072F RID: 1839 RVA: 0x000300CC File Offset: 0x0002E2CC
	// (set) Token: 0x06000730 RID: 1840 RVA: 0x000065A3 File Offset: 0x000047A3
	public unsafe TextMeshProUGUI m_Popup_ConfirmMoveText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_ConfirmMoveText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_ConfirmMoveText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000283 RID: 643
	// (get) Token: 0x06000731 RID: 1841 RVA: 0x000300FC File Offset: 0x0002E2FC
	// (set) Token: 0x06000732 RID: 1842 RVA: 0x000065C2 File Offset: 0x000047C2
	public unsafe TextMeshProUGUI m_Popup_ConfirmMove_ConfirmButtonText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_ConfirmMove_ConfirmButtonText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_ConfirmMove_ConfirmButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000284 RID: 644
	// (get) Token: 0x06000733 RID: 1843 RVA: 0x0003012C File Offset: 0x0002E32C
	// (set) Token: 0x06000734 RID: 1844 RVA: 0x000065E1 File Offset: 0x000047E1
	public unsafe TextMeshProUGUI m_Popup_ConfirmMove_CancelButtonText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_ConfirmMove_CancelButtonText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_ConfirmMove_CancelButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000285 RID: 645
	// (get) Token: 0x06000735 RID: 1845 RVA: 0x0003015C File Offset: 0x0002E35C
	// (set) Token: 0x06000736 RID: 1846 RVA: 0x00006600 File Offset: 0x00004800
	public unsafe Image m_Popup_ConfirmMoveImage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_ConfirmMoveImage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_ConfirmMoveImage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000286 RID: 646
	// (get) Token: 0x06000737 RID: 1847 RVA: 0x0003018C File Offset: 0x0002E38C
	// (set) Token: 0x06000738 RID: 1848 RVA: 0x0000661F File Offset: 0x0000481F
	public unsafe Button m_PauseButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PauseButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PauseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000287 RID: 647
	// (get) Token: 0x06000739 RID: 1849 RVA: 0x000301BC File Offset: 0x0002E3BC
	// (set) Token: 0x0600073A RID: 1850 RVA: 0x0000663E File Offset: 0x0000483E
	public unsafe Button m_CloseButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_CloseButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_CloseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000288 RID: 648
	// (get) Token: 0x0600073B RID: 1851 RVA: 0x000301EC File Offset: 0x0002E3EC
	// (set) Token: 0x0600073C RID: 1852 RVA: 0x0000665D File Offset: 0x0000485D
	public unsafe Popup_EndGame m_Popup_EndGame
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_EndGame);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Popup_EndGame>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Popup_EndGame), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000289 RID: 649
	// (get) Token: 0x0600073D RID: 1853 RVA: 0x0003021C File Offset: 0x0002E41C
	// (set) Token: 0x0600073E RID: 1854 RVA: 0x0000667C File Offset: 0x0000487C
	public unsafe HotseatOverlay m_HotseatScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_HotseatScreen);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<HotseatOverlay>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_HotseatScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700028A RID: 650
	// (get) Token: 0x0600073F RID: 1855 RVA: 0x0003024C File Offset: 0x0002E44C
	// (set) Token: 0x06000740 RID: 1856 RVA: 0x0000669B File Offset: 0x0000489B
	public unsafe GameObject m_TutorialRoot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialRoot);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700028B RID: 651
	// (get) Token: 0x06000741 RID: 1857 RVA: 0x0003027C File Offset: 0x0002E47C
	// (set) Token: 0x06000742 RID: 1858 RVA: 0x000066BA File Offset: 0x000048BA
	public unsafe GameObject m_TutorialPanel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialPanel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700028C RID: 652
	// (get) Token: 0x06000743 RID: 1859 RVA: 0x000302AC File Offset: 0x0002E4AC
	// (set) Token: 0x06000744 RID: 1860 RVA: 0x000066D9 File Offset: 0x000048D9
	public unsafe TextMeshProUGUI m_TutorialPanelText_Label
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialPanelText_Label);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialPanelText_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700028D RID: 653
	// (get) Token: 0x06000745 RID: 1861 RVA: 0x000302DC File Offset: 0x0002E4DC
	// (set) Token: 0x06000746 RID: 1862 RVA: 0x000066F8 File Offset: 0x000048F8
	public unsafe TextMeshProUGUI m_TutorialPanelPrompt
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialPanelPrompt);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialPanelPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700028E RID: 654
	// (get) Token: 0x06000747 RID: 1863 RVA: 0x0003030C File Offset: 0x0002E50C
	// (set) Token: 0x06000748 RID: 1864 RVA: 0x00006717 File Offset: 0x00004917
	public unsafe GameObject m_TutorialPanelText_ButtonConfirm
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialPanelText_ButtonConfirm);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialPanelText_ButtonConfirm), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700028F RID: 655
	// (get) Token: 0x06000749 RID: 1865 RVA: 0x0003033C File Offset: 0x0002E53C
	// (set) Token: 0x0600074A RID: 1866 RVA: 0x00006736 File Offset: 0x00004936
	public unsafe Button m_TutorialPanelButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialPanelButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialPanelButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000290 RID: 656
	// (get) Token: 0x0600074B RID: 1867 RVA: 0x0003036C File Offset: 0x0002E56C
	// (set) Token: 0x0600074C RID: 1868 RVA: 0x00006755 File Offset: 0x00004955
	public unsafe GameObject m_TutorialPanelContinueButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialPanelContinueButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialPanelContinueButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000291 RID: 657
	// (get) Token: 0x0600074D RID: 1869 RVA: 0x0003039C File Offset: 0x0002E59C
	// (set) Token: 0x0600074E RID: 1870 RVA: 0x00006774 File Offset: 0x00004974
	public unsafe GameObject m_TutorialPanelExitButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialPanelExitButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialPanelExitButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000292 RID: 658
	// (get) Token: 0x0600074F RID: 1871 RVA: 0x000303CC File Offset: 0x0002E5CC
	// (set) Token: 0x06000750 RID: 1872 RVA: 0x00006793 File Offset: 0x00004993
	public unsafe Il2CppReferenceArray<GameObject> m_TutorialInterfaceCallouts
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialInterfaceCallouts);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialInterfaceCallouts), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000293 RID: 659
	// (get) Token: 0x06000751 RID: 1873 RVA: 0x000303FC File Offset: 0x0002E5FC
	// (set) Token: 0x06000752 RID: 1874 RVA: 0x000067B2 File Offset: 0x000049B2
	public unsafe Il2CppReferenceArray<GameObject> m_TutorialInterfaceCalloutPrefabs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialInterfaceCalloutPrefabs);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialInterfaceCalloutPrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000294 RID: 660
	// (get) Token: 0x06000753 RID: 1875 RVA: 0x0003042C File Offset: 0x0002E62C
	// (set) Token: 0x06000754 RID: 1876 RVA: 0x000067D1 File Offset: 0x000049D1
	public unsafe uint m_OnlineGameID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_OnlineGameID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_OnlineGameID)) = value;
		}
	}

	// Token: 0x17000295 RID: 661
	// (get) Token: 0x06000755 RID: 1877 RVA: 0x00030454 File Offset: 0x0002E654
	// (set) Token: 0x06000756 RID: 1878 RVA: 0x000067EC File Offset: 0x000049EC
	public unsafe int m_LocalPlayerIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerIndex)) = value;
		}
	}

	// Token: 0x17000296 RID: 662
	// (get) Token: 0x06000757 RID: 1879 RVA: 0x0003047C File Offset: 0x0002E67C
	// (set) Token: 0x06000758 RID: 1880 RVA: 0x00006807 File Offset: 0x00004A07
	public unsafe int m_LocalPlayerInstanceID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerInstanceID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LocalPlayerInstanceID)) = value;
		}
	}

	// Token: 0x17000297 RID: 663
	// (get) Token: 0x06000759 RID: 1881 RVA: 0x000304A4 File Offset: 0x0002E6A4
	// (set) Token: 0x0600075A RID: 1882 RVA: 0x00006822 File Offset: 0x00004A22
	public unsafe int m_RoundNumber
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_RoundNumber);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_RoundNumber)) = value;
		}
	}

	// Token: 0x17000298 RID: 664
	// (get) Token: 0x0600075B RID: 1883 RVA: 0x000304CC File Offset: 0x0002E6CC
	// (set) Token: 0x0600075C RID: 1884 RVA: 0x0000683D File Offset: 0x00004A3D
	public unsafe List<KingdomStack> m_KingdomStacks
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_KingdomStacks);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KingdomStack>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_KingdomStacks), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000299 RID: 665
	// (get) Token: 0x0600075D RID: 1885 RVA: 0x000304FC File Offset: 0x0002E6FC
	// (set) Token: 0x0600075E RID: 1886 RVA: 0x0000685C File Offset: 0x00004A5C
	public unsafe List<AscensionCardInPlay> m_CardInPlayList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_CardInPlayList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AscensionCardInPlay>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_CardInPlayList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700029A RID: 666
	// (get) Token: 0x0600075F RID: 1887 RVA: 0x0003052C File Offset: 0x0002E72C
	// (set) Token: 0x06000760 RID: 1888 RVA: 0x0000687B File Offset: 0x00004A7B
	public unsafe bool m_bShowEnergyCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bShowEnergyCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bShowEnergyCount)) = value;
		}
	}

	// Token: 0x1700029B RID: 667
	// (get) Token: 0x06000761 RID: 1889 RVA: 0x00030554 File Offset: 0x0002E754
	// (set) Token: 0x06000762 RID: 1890 RVA: 0x00006896 File Offset: 0x00004A96
	public unsafe bool m_bShowDayNight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bShowDayNight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bShowDayNight)) = value;
		}
	}

	// Token: 0x1700029C RID: 668
	// (get) Token: 0x06000763 RID: 1891 RVA: 0x0003057C File Offset: 0x0002E77C
	// (set) Token: 0x06000764 RID: 1892 RVA: 0x000068B1 File Offset: 0x00004AB1
	public unsafe bool m_bShowDreamscapeArea
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bShowDreamscapeArea);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bShowDreamscapeArea)) = value;
		}
	}

	// Token: 0x1700029D RID: 669
	// (get) Token: 0x06000765 RID: 1893 RVA: 0x000305A4 File Offset: 0x0002E7A4
	// (set) Token: 0x06000766 RID: 1894 RVA: 0x000068CC File Offset: 0x00004ACC
	public unsafe bool m_bShowTemples
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bShowTemples);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bShowTemples)) = value;
		}
	}

	// Token: 0x1700029E RID: 670
	// (get) Token: 0x06000767 RID: 1895 RVA: 0x000305CC File Offset: 0x0002E7CC
	// (set) Token: 0x06000768 RID: 1896 RVA: 0x000068E7 File Offset: 0x00004AE7
	public unsafe bool m_bShowDeckTrayDrawPileList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bShowDeckTrayDrawPileList);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bShowDeckTrayDrawPileList)) = value;
		}
	}

	// Token: 0x1700029F RID: 671
	// (get) Token: 0x06000769 RID: 1897 RVA: 0x000305F4 File Offset: 0x0002E7F4
	// (set) Token: 0x0600076A RID: 1898 RVA: 0x00006902 File Offset: 0x00004B02
	public unsafe bool m_bShowDeckTrayLifeboundList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bShowDeckTrayLifeboundList);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bShowDeckTrayLifeboundList)) = value;
		}
	}

	// Token: 0x170002A0 RID: 672
	// (get) Token: 0x0600076B RID: 1899 RVA: 0x0003061C File Offset: 0x0002E81C
	// (set) Token: 0x0600076C RID: 1900 RVA: 0x0000691D File Offset: 0x00004B1D
	public unsafe List<AscensionCard> m_LifeboundCardList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LifeboundCardList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AscensionCard>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_LifeboundCardList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002A1 RID: 673
	// (get) Token: 0x0600076D RID: 1901 RVA: 0x0003064C File Offset: 0x0002E84C
	// (set) Token: 0x0600076E RID: 1902 RVA: 0x0000693C File Offset: 0x00004B3C
	public unsafe bool m_bShowDeckTrayDefeatedMonsterList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bShowDeckTrayDefeatedMonsterList);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bShowDeckTrayDefeatedMonsterList)) = value;
		}
	}

	// Token: 0x170002A2 RID: 674
	// (get) Token: 0x0600076F RID: 1903 RVA: 0x00030674 File Offset: 0x0002E874
	// (set) Token: 0x06000770 RID: 1904 RVA: 0x00006957 File Offset: 0x00004B57
	public unsafe List<AscensionCard> m_DefeatedMonsterCardList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DefeatedMonsterCardList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AscensionCard>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DefeatedMonsterCardList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002A3 RID: 675
	// (get) Token: 0x06000771 RID: 1905 RVA: 0x000306A4 File Offset: 0x0002E8A4
	// (set) Token: 0x06000772 RID: 1906 RVA: 0x00006976 File Offset: 0x00004B76
	public unsafe TrayToggle m_EndDragCloseTragToggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_EndDragCloseTragToggle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrayToggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_EndDragCloseTragToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002A4 RID: 676
	// (get) Token: 0x06000773 RID: 1907 RVA: 0x000306D4 File Offset: 0x0002E8D4
	// (set) Token: 0x06000774 RID: 1908 RVA: 0x00006995 File Offset: 0x00004B95
	public unsafe Il2CppStructArray<QueryCardState> m_QueryBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_QueryBuffer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<QueryCardState>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_QueryBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002A5 RID: 677
	// (get) Token: 0x06000775 RID: 1909 RVA: 0x00030704 File Offset: 0x0002E904
	// (set) Token: 0x06000776 RID: 1910 RVA: 0x000069B4 File Offset: 0x00004BB4
	public unsafe Il2CppStructArray<byte> m_dataBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_dataBuffer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_dataBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002A6 RID: 678
	// (get) Token: 0x06000777 RID: 1911 RVA: 0x00030734 File Offset: 0x0002E934
	// (set) Token: 0x06000778 RID: 1912 RVA: 0x000069D3 File Offset: 0x00004BD3
	public unsafe GCHandle m_hDataBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_hDataBuffer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_hDataBuffer)) = value;
		}
	}

	// Token: 0x170002A7 RID: 679
	// (get) Token: 0x06000779 RID: 1913 RVA: 0x0003075C File Offset: 0x0002E95C
	// (set) Token: 0x0600077A RID: 1914 RVA: 0x000069EE File Offset: 0x00004BEE
	public unsafe IntPtr m_bufPtr
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bufPtr);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bufPtr)) = value;
		}
	}

	// Token: 0x170002A8 RID: 680
	// (get) Token: 0x0600077B RID: 1915 RVA: 0x00030784 File Offset: 0x0002E984
	// (set) Token: 0x0600077C RID: 1916 RVA: 0x00006A09 File Offset: 0x00004C09
	public unsafe Il2CppStructArray<ParticleSystem.Particle> m_endTurnParticles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_endTurnParticles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ParticleSystem.Particle>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_endTurnParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002A9 RID: 681
	// (get) Token: 0x0600077D RID: 1917 RVA: 0x000307B4 File Offset: 0x0002E9B4
	// (set) Token: 0x0600077E RID: 1918 RVA: 0x00006A28 File Offset: 0x00004C28
	public unsafe Il2CppStructArray<int> m_cardList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_cardList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_cardList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002AA RID: 682
	// (get) Token: 0x0600077F RID: 1919 RVA: 0x000307E4 File Offset: 0x0002E9E4
	// (set) Token: 0x06000780 RID: 1920 RVA: 0x00006A47 File Offset: 0x00004C47
	public unsafe GCHandle m_hCardInstanceBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_hCardInstanceBuffer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_hCardInstanceBuffer)) = value;
		}
	}

	// Token: 0x170002AB RID: 683
	// (get) Token: 0x06000781 RID: 1921 RVA: 0x0003080C File Offset: 0x0002EA0C
	// (set) Token: 0x06000782 RID: 1922 RVA: 0x00006A62 File Offset: 0x00004C62
	public unsafe IntPtr m_cardBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_cardBuffer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_cardBuffer)) = value;
		}
	}

	// Token: 0x170002AC RID: 684
	// (get) Token: 0x06000783 RID: 1923 RVA: 0x00030834 File Offset: 0x0002EA34
	// (set) Token: 0x06000784 RID: 1924 RVA: 0x00006A7D File Offset: 0x00004C7D
	public unsafe GameEventBuffer m_GameEventBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_GameEventBuffer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameEventBuffer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_GameEventBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002AD RID: 685
	// (get) Token: 0x06000785 RID: 1925 RVA: 0x00030864 File Offset: 0x0002EA64
	// (set) Token: 0x06000786 RID: 1926 RVA: 0x00006A9C File Offset: 0x00004C9C
	public unsafe static ShortSaveStruct m_lastSavedState
	{
		get
		{
			IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, (UIntPtr)0)];
			IL2CPP.il2cpp_field_static_get_value(AscensionGame.NativeFieldInfoPtr_m_lastSavedState, intPtr);
			return new ShortSaveStruct(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionGame.NativeFieldInfoPtr_m_lastSavedState, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
		}
	}

	// Token: 0x170002AE RID: 686
	// (get) Token: 0x06000787 RID: 1927 RVA: 0x000308A0 File Offset: 0x0002EAA0
	// (set) Token: 0x06000788 RID: 1928 RVA: 0x00006AB3 File Offset: 0x00004CB3
	public unsafe PopupManager m_PopupManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PopupManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PopupManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PopupManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002AF RID: 687
	// (get) Token: 0x06000789 RID: 1929 RVA: 0x000308D0 File Offset: 0x0002EAD0
	// (set) Token: 0x0600078A RID: 1930 RVA: 0x00006AD2 File Offset: 0x00004CD2
	public unsafe ResourceManager m_ResourceManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_ResourceManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_ResourceManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002B0 RID: 688
	// (get) Token: 0x0600078B RID: 1931 RVA: 0x00030900 File Offset: 0x0002EB00
	// (set) Token: 0x0600078C RID: 1932 RVA: 0x00006AF1 File Offset: 0x00004CF1
	public unsafe ResourceEntry m_ConfirmMoveResource
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_ConfirmMoveResource);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceEntry>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_ConfirmMoveResource), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002B1 RID: 689
	// (get) Token: 0x0600078D RID: 1933 RVA: 0x00030930 File Offset: 0x0002EB30
	// (set) Token: 0x0600078E RID: 1934 RVA: 0x00006B10 File Offset: 0x00004D10
	public unsafe int m_ConfirmMovePopupLastShown
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_ConfirmMovePopupLastShown);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_ConfirmMovePopupLastShown)) = value;
		}
	}

	// Token: 0x170002B2 RID: 690
	// (get) Token: 0x0600078F RID: 1935 RVA: 0x00030958 File Offset: 0x0002EB58
	// (set) Token: 0x06000790 RID: 1936 RVA: 0x00006B2B File Offset: 0x00004D2B
	public unsafe bool m_bPaused
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bPaused);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bPaused)) = value;
		}
	}

	// Token: 0x170002B3 RID: 691
	// (get) Token: 0x06000791 RID: 1937 RVA: 0x00030980 File Offset: 0x0002EB80
	// (set) Token: 0x06000792 RID: 1938 RVA: 0x00006B46 File Offset: 0x00004D46
	public unsafe bool m_bInitialized
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bInitialized);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bInitialized)) = value;
		}
	}

	// Token: 0x170002B4 RID: 692
	// (get) Token: 0x06000793 RID: 1939 RVA: 0x000309A8 File Offset: 0x0002EBA8
	// (set) Token: 0x06000794 RID: 1940 RVA: 0x00006B61 File Offset: 0x00004D61
	public unsafe bool m_bWaitingAfterTurn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bWaitingAfterTurn);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bWaitingAfterTurn)) = value;
		}
	}

	// Token: 0x170002B5 RID: 693
	// (get) Token: 0x06000795 RID: 1941 RVA: 0x000309D0 File Offset: 0x0002EBD0
	// (set) Token: 0x06000796 RID: 1942 RVA: 0x00006B7C File Offset: 0x00004D7C
	public unsafe bool m_bEndGameWaitingForCommit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bEndGameWaitingForCommit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bEndGameWaitingForCommit)) = value;
		}
	}

	// Token: 0x170002B6 RID: 694
	// (get) Token: 0x06000797 RID: 1943 RVA: 0x000309F8 File Offset: 0x0002EBF8
	// (set) Token: 0x06000798 RID: 1944 RVA: 0x00006B97 File Offset: 0x00004D97
	public unsafe bool m_bForfeitLastPlayer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bForfeitLastPlayer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bForfeitLastPlayer)) = value;
		}
	}

	// Token: 0x170002B7 RID: 695
	// (get) Token: 0x06000799 RID: 1945 RVA: 0x00030A20 File Offset: 0x0002EC20
	// (set) Token: 0x0600079A RID: 1946 RVA: 0x00006BB2 File Offset: 0x00004DB2
	public unsafe bool m_bForfeitDenied
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bForfeitDenied);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bForfeitDenied)) = value;
		}
	}

	// Token: 0x170002B8 RID: 696
	// (get) Token: 0x0600079B RID: 1947 RVA: 0x00030A48 File Offset: 0x0002EC48
	// (set) Token: 0x0600079C RID: 1948 RVA: 0x00006BCD File Offset: 0x00004DCD
	public unsafe static uint m_LoadingScreenHoldUpdateCount
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionGame.NativeFieldInfoPtr_m_LoadingScreenHoldUpdateCount, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionGame.NativeFieldInfoPtr_m_LoadingScreenHoldUpdateCount, (void*)(&value));
		}
	}

	// Token: 0x170002B9 RID: 697
	// (get) Token: 0x0600079D RID: 1949 RVA: 0x00030A64 File Offset: 0x0002EC64
	// (set) Token: 0x0600079E RID: 1950 RVA: 0x00006BDB File Offset: 0x00004DDB
	public unsafe float m_PauseSimulationTimer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PauseSimulationTimer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PauseSimulationTimer)) = value;
		}
	}

	// Token: 0x170002BA RID: 698
	// (get) Token: 0x0600079F RID: 1951 RVA: 0x00030A8C File Offset: 0x0002EC8C
	// (set) Token: 0x060007A0 RID: 1952 RVA: 0x00006BF6 File Offset: 0x00004DF6
	public unsafe bool m_bLoadedIntoCompletedGame
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bLoadedIntoCompletedGame);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bLoadedIntoCompletedGame)) = value;
		}
	}

	// Token: 0x170002BB RID: 699
	// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00030AB4 File Offset: 0x0002ECB4
	// (set) Token: 0x060007A2 RID: 1954 RVA: 0x00006C11 File Offset: 0x00004E11
	public unsafe int m_DisplayedRoundNumber
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedRoundNumber);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedRoundNumber)) = value;
		}
	}

	// Token: 0x170002BC RID: 700
	// (get) Token: 0x060007A3 RID: 1955 RVA: 0x00030ADC File Offset: 0x0002ECDC
	// (set) Token: 0x060007A4 RID: 1956 RVA: 0x00006C2C File Offset: 0x00004E2C
	public unsafe int m_DisplayedHonorPool
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedHonorPool);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedHonorPool)) = value;
		}
	}

	// Token: 0x170002BD RID: 701
	// (get) Token: 0x060007A5 RID: 1957 RVA: 0x00030B04 File Offset: 0x0002ED04
	// (set) Token: 0x060007A6 RID: 1958 RVA: 0x00006C47 File Offset: 0x00004E47
	public unsafe int m_DisplayedRuneCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedRuneCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedRuneCount)) = value;
		}
	}

	// Token: 0x170002BE RID: 702
	// (get) Token: 0x060007A7 RID: 1959 RVA: 0x00030B2C File Offset: 0x0002ED2C
	// (set) Token: 0x060007A8 RID: 1960 RVA: 0x00006C62 File Offset: 0x00004E62
	public unsafe int m_DisplayedPowerCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedPowerCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedPowerCount)) = value;
		}
	}

	// Token: 0x170002BF RID: 703
	// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00030B54 File Offset: 0x0002ED54
	// (set) Token: 0x060007AA RID: 1962 RVA: 0x00006C7D File Offset: 0x00004E7D
	public unsafe int m_DisplayedRuneMechanaCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedRuneMechanaCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedRuneMechanaCount)) = value;
		}
	}

	// Token: 0x170002C0 RID: 704
	// (get) Token: 0x060007AB RID: 1963 RVA: 0x00030B7C File Offset: 0x0002ED7C
	// (set) Token: 0x060007AC RID: 1964 RVA: 0x00006C98 File Offset: 0x00004E98
	public unsafe bool m_DisplayedHasRuneMechana
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedHasRuneMechana);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedHasRuneMechana)) = value;
		}
	}

	// Token: 0x170002C1 RID: 705
	// (get) Token: 0x060007AD RID: 1965 RVA: 0x00030BA4 File Offset: 0x0002EDA4
	// (set) Token: 0x060007AE RID: 1966 RVA: 0x00006CB3 File Offset: 0x00004EB3
	public unsafe int m_DisplayedEnergyCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedEnergyCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedEnergyCount)) = value;
		}
	}

	// Token: 0x170002C2 RID: 706
	// (get) Token: 0x060007AF RID: 1967 RVA: 0x00030BCC File Offset: 0x0002EDCC
	// (set) Token: 0x060007B0 RID: 1968 RVA: 0x00006CCE File Offset: 0x00004ECE
	public unsafe bool m_DisplayedHasEnergy
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedHasEnergy);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedHasEnergy)) = value;
		}
	}

	// Token: 0x170002C3 RID: 707
	// (get) Token: 0x060007B1 RID: 1969 RVA: 0x00030BF4 File Offset: 0x0002EDF4
	// (set) Token: 0x060007B2 RID: 1970 RVA: 0x00006CE9 File Offset: 0x00004EE9
	public unsafe int m_DisplayedPortalDeckCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedPortalDeckCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedPortalDeckCount)) = value;
		}
	}

	// Token: 0x170002C4 RID: 708
	// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00030C1C File Offset: 0x0002EE1C
	// (set) Token: 0x060007B4 RID: 1972 RVA: 0x00006D04 File Offset: 0x00004F04
	public unsafe int m_DisplayedVoidPileCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedVoidPileCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedVoidPileCount)) = value;
		}
	}

	// Token: 0x170002C5 RID: 709
	// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00030C44 File Offset: 0x0002EE44
	// (set) Token: 0x060007B6 RID: 1974 RVA: 0x00006D1F File Offset: 0x00004F1F
	public unsafe bool m_DisplayedShowDay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedShowDay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedShowDay)) = value;
		}
	}

	// Token: 0x170002C6 RID: 710
	// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00030C6C File Offset: 0x0002EE6C
	// (set) Token: 0x060007B8 RID: 1976 RVA: 0x00006D3A File Offset: 0x00004F3A
	public unsafe bool m_DisplayedShowNight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedShowNight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedShowNight)) = value;
		}
	}

	// Token: 0x170002C7 RID: 711
	// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00030C94 File Offset: 0x0002EE94
	// (set) Token: 0x060007BA RID: 1978 RVA: 0x00006D55 File Offset: 0x00004F55
	public unsafe int m_DisplayedWorldStateFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedWorldStateFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedWorldStateFlags)) = value;
		}
	}

	// Token: 0x170002C8 RID: 712
	// (get) Token: 0x060007BB RID: 1979 RVA: 0x00030CBC File Offset: 0x0002EEBC
	// (set) Token: 0x060007BC RID: 1980 RVA: 0x00006D70 File Offset: 0x00004F70
	public unsafe int m_DisplayedTempleLifeCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedTempleLifeCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedTempleLifeCount)) = value;
		}
	}

	// Token: 0x170002C9 RID: 713
	// (get) Token: 0x060007BD RID: 1981 RVA: 0x00030CE4 File Offset: 0x0002EEE4
	// (set) Token: 0x060007BE RID: 1982 RVA: 0x00006D8B File Offset: 0x00004F8B
	public unsafe bool m_DisplayedHasTempleLife
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedHasTempleLife);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedHasTempleLife)) = value;
		}
	}

	// Token: 0x170002CA RID: 714
	// (get) Token: 0x060007BF RID: 1983 RVA: 0x00030D0C File Offset: 0x0002EF0C
	// (set) Token: 0x060007C0 RID: 1984 RVA: 0x00006DA6 File Offset: 0x00004FA6
	public unsafe int m_DisplayedTempleDeathCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedTempleDeathCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedTempleDeathCount)) = value;
		}
	}

	// Token: 0x170002CB RID: 715
	// (get) Token: 0x060007C1 RID: 1985 RVA: 0x00030D34 File Offset: 0x0002EF34
	// (set) Token: 0x060007C2 RID: 1986 RVA: 0x00006DC1 File Offset: 0x00004FC1
	public unsafe bool m_DisplayedHasTempleDeath
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedHasTempleDeath);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_DisplayedHasTempleDeath)) = value;
		}
	}

	// Token: 0x170002CC RID: 716
	// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00030D5C File Offset: 0x0002EF5C
	// (set) Token: 0x060007C4 RID: 1988 RVA: 0x00006DDC File Offset: 0x00004FDC
	public unsafe uint m_PopupConfirm_SelectionID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PopupConfirm_SelectionID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PopupConfirm_SelectionID)) = value;
		}
	}

	// Token: 0x170002CD RID: 717
	// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00030D84 File Offset: 0x0002EF84
	// (set) Token: 0x060007C6 RID: 1990 RVA: 0x00006DF7 File Offset: 0x00004FF7
	public unsafe ushort m_PopupConfirm_SelectionHint
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PopupConfirm_SelectionHint);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PopupConfirm_SelectionHint)) = value;
		}
	}

	// Token: 0x170002CE RID: 718
	// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00030DAC File Offset: 0x0002EFAC
	// (set) Token: 0x060007C8 RID: 1992 RVA: 0x00006E12 File Offset: 0x00005012
	public unsafe uint m_PopupConfirm_Negative_SelectionID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PopupConfirm_Negative_SelectionID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PopupConfirm_Negative_SelectionID)) = value;
		}
	}

	// Token: 0x170002CF RID: 719
	// (get) Token: 0x060007C9 RID: 1993 RVA: 0x00030DD4 File Offset: 0x0002EFD4
	// (set) Token: 0x060007CA RID: 1994 RVA: 0x00006E2D File Offset: 0x0000502D
	public unsafe ushort m_PopupConfirm_Negative_SelectionHint
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PopupConfirm_Negative_SelectionHint);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_PopupConfirm_Negative_SelectionHint)) = value;
		}
	}

	// Token: 0x170002D0 RID: 720
	// (get) Token: 0x060007CB RID: 1995 RVA: 0x00030DFC File Offset: 0x0002EFFC
	// (set) Token: 0x060007CC RID: 1996 RVA: 0x00006E48 File Offset: 0x00005048
	public unsafe Tutorial m_Tutorial
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Tutorial);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tutorial>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_Tutorial), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002D1 RID: 721
	// (get) Token: 0x060007CD RID: 1997 RVA: 0x00030E2C File Offset: 0x0002F02C
	// (set) Token: 0x060007CE RID: 1998 RVA: 0x00006E67 File Offset: 0x00005067
	public unsafe bool m_bAdvanceTutorial
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bAdvanceTutorial);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_bAdvanceTutorial)) = value;
		}
	}

	// Token: 0x170002D2 RID: 722
	// (get) Token: 0x060007CF RID: 1999 RVA: 0x00030E54 File Offset: 0x0002F054
	// (set) Token: 0x060007D0 RID: 2000 RVA: 0x00006E82 File Offset: 0x00005082
	public unsafe List<GameObject> m_TutorialElementsActive
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialElementsActive);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialElementsActive), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002D3 RID: 723
	// (get) Token: 0x060007D1 RID: 2001 RVA: 0x00030E84 File Offset: 0x0002F084
	// (set) Token: 0x060007D2 RID: 2002 RVA: 0x00006EA1 File Offset: 0x000050A1
	public unsafe List<GameObject> m_TutorialElementsMagnify
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialElementsMagnify);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialElementsMagnify), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002D4 RID: 724
	// (get) Token: 0x060007D3 RID: 2003 RVA: 0x00030EB4 File Offset: 0x0002F0B4
	// (set) Token: 0x060007D4 RID: 2004 RVA: 0x00006EC0 File Offset: 0x000050C0
	public unsafe List<GameObject> m_TutorialElementsCreated
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialElementsCreated);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialElementsCreated), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002D5 RID: 725
	// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00030EE4 File Offset: 0x0002F0E4
	// (set) Token: 0x060007D6 RID: 2006 RVA: 0x00006EDF File Offset: 0x000050DF
	public unsafe DateTime m_TutorialStepTimeStart
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialStepTimeStart);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionGame.NativeFieldInfoPtr_m_TutorialStepTimeStart)) = value;
		}
	}

	// Token: 0x0400039F RID: 927
	private static readonly IntPtr NativeFieldInfoPtr_k_maxDataSize;

	// Token: 0x040003A0 RID: 928
	private static readonly IntPtr NativeFieldInfoPtr_k_maxCardCount;

	// Token: 0x040003A1 RID: 929
	private static readonly IntPtr NativeFieldInfoPtr_k_maxQueryCount;

	// Token: 0x040003A2 RID: 930
	private static readonly IntPtr NativeFieldInfoPtr_s_loadingIntoCompletedGame;

	// Token: 0x040003A3 RID: 931
	private static readonly IntPtr NativeFieldInfoPtr_m_CardManager;

	// Token: 0x040003A4 RID: 932
	private static readonly IntPtr NativeFieldInfoPtr_m_DragManager;

	// Token: 0x040003A5 RID: 933
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimationManager;

	// Token: 0x040003A6 RID: 934
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifyManager;

	// Token: 0x040003A7 RID: 935
	private static readonly IntPtr NativeFieldInfoPtr_m_AudioHandler;

	// Token: 0x040003A8 RID: 936
	private static readonly IntPtr NativeFieldInfoPtr_m_CenterRowSlots;

	// Token: 0x040003A9 RID: 937
	private static readonly IntPtr NativeFieldInfoPtr_m_CenterRowSeventhSlotScalar;

	// Token: 0x040003AA RID: 938
	private static readonly IntPtr NativeFieldInfoPtr_m_PortalDeckLocator;

	// Token: 0x040003AB RID: 939
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorPortalDeckAnnounce;

	// Token: 0x040003AC RID: 940
	private static readonly IntPtr NativeFieldInfoPtr_m_VoidPileLocator;

	// Token: 0x040003AD RID: 941
	private static readonly IntPtr NativeFieldInfoPtr_m_UnderVoidPileLocator;

	// Token: 0x040003AE RID: 942
	private static readonly IntPtr NativeFieldInfoPtr_m_VoidPileLocatorEvent;

	// Token: 0x040003AF RID: 943
	private static readonly IntPtr NativeFieldInfoPtr_m_UnderVoidPileLocatorEvent;

	// Token: 0x040003B0 RID: 944
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorVoidPileTray;

	// Token: 0x040003B1 RID: 945
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorActionAreaPlayedCards;

	// Token: 0x040003B2 RID: 946
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorResolveEffectStack;

	// Token: 0x040003B3 RID: 947
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorRevealedCards;

	// Token: 0x040003B4 RID: 948
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorRevealAnnounce;

	// Token: 0x040003B5 RID: 949
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorEventCard;

	// Token: 0x040003B6 RID: 950
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorAvailableTemples;

	// Token: 0x040003B7 RID: 951
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorAvailableTemplesAnnounce;

	// Token: 0x040003B8 RID: 952
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorDeliriumDieStart;

	// Token: 0x040003B9 RID: 953
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorDeliriumDieResolve;

	// Token: 0x040003BA RID: 954
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorUniqueCardZone;

	// Token: 0x040003BB RID: 955
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorChampionIncoming;

	// Token: 0x040003BC RID: 956
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorChampionOutgoing;

	// Token: 0x040003BD RID: 957
	private static readonly IntPtr NativeFieldInfoPtr_m_TransformEffect;

	// Token: 0x040003BE RID: 958
	private static readonly IntPtr NativeFieldInfoPtr_m_LocalPlayerDreamscapeArea;

	// Token: 0x040003BF RID: 959
	private static readonly IntPtr NativeFieldInfoPtr_m_LocalPlayerDreamscapeButton;

	// Token: 0x040003C0 RID: 960
	private static readonly IntPtr NativeFieldInfoPtr_m_LocalPlayerDreamscapeCenterSpacer;

	// Token: 0x040003C1 RID: 961
	private static readonly IntPtr NativeFieldInfoPtr_m_LocalPlayerDreamscapeGlow;

	// Token: 0x040003C2 RID: 962
	private static readonly IntPtr NativeFieldInfoPtr_m_LocalPlayerDreamscapeGlowFreeCard;

	// Token: 0x040003C3 RID: 963
	private static readonly IntPtr NativeFieldInfoPtr_m_LocalPlayerLeprechaunArea;

	// Token: 0x040003C4 RID: 964
	private static readonly IntPtr NativeFieldInfoPtr_m_PsytheaRedeemedArea;

	// Token: 0x040003C5 RID: 965
	private static readonly IntPtr NativeFieldInfoPtr_m_PsytheaRedeemedGlow;

	// Token: 0x040003C6 RID: 966
	private static readonly IntPtr NativeFieldInfoPtr_m_PsytheaRedeemedGlowFreeCard;

	// Token: 0x040003C7 RID: 967
	private static readonly IntPtr NativeFieldInfoPtr_m_gameLog;

	// Token: 0x040003C8 RID: 968
	private static readonly IntPtr NativeFieldInfoPtr_m_GameOptionButtons;

	// Token: 0x040003C9 RID: 969
	private static readonly IntPtr NativeFieldInfoPtr_m_GameOptionPlayerButtons;

	// Token: 0x040003CA RID: 970
	private static readonly IntPtr NativeFieldInfoPtr_m_LocalPlayerDisplay;

	// Token: 0x040003CB RID: 971
	private static readonly IntPtr NativeFieldInfoPtr_m_OpponentTrays;

	// Token: 0x040003CC RID: 972
	private static readonly IntPtr NativeFieldInfoPtr_m_ActiveOpponentTray;

	// Token: 0x040003CD RID: 973
	private static readonly IntPtr NativeFieldInfoPtr_m_ActionAreaEndTurnButton;

	// Token: 0x040003CE RID: 974
	private static readonly IntPtr NativeFieldInfoPtr_m_ActionAreaPlayAllButton;

	// Token: 0x040003CF RID: 975
	private static readonly IntPtr NativeFieldInfoPtr_m_ActionAreaNoneButton;

	// Token: 0x040003D0 RID: 976
	private static readonly IntPtr NativeFieldInfoPtr_m_ActionAreaLeftCapHighlight;

	// Token: 0x040003D1 RID: 977
	private static readonly IntPtr NativeFieldInfoPtr_m_ActionAreaRightCapHighlight;

	// Token: 0x040003D2 RID: 978
	private static readonly IntPtr NativeFieldInfoPtr_m_RoundNumberDisplay;

	// Token: 0x040003D3 RID: 979
	private static readonly IntPtr NativeFieldInfoPtr_m_RoundNumberText;

	// Token: 0x040003D4 RID: 980
	private static readonly IntPtr NativeFieldInfoPtr_m_HonorPoolText;

	// Token: 0x040003D5 RID: 981
	private static readonly IntPtr NativeFieldInfoPtr_m_HonorPoolGlowObj;

	// Token: 0x040003D6 RID: 982
	private static readonly IntPtr NativeFieldInfoPtr_m_HonorPoolGlowImage;

	// Token: 0x040003D7 RID: 983
	private static readonly IntPtr NativeFieldInfoPtr_m_HonorPoolGlowParticles;

	// Token: 0x040003D8 RID: 984
	private static readonly IntPtr NativeFieldInfoPtr_m_HonorPoolGlowColors;

	// Token: 0x040003D9 RID: 985
	private static readonly IntPtr NativeFieldInfoPtr_m_RuneCountText;

	// Token: 0x040003DA RID: 986
	private static readonly IntPtr NativeFieldInfoPtr_m_PowerCountText;

	// Token: 0x040003DB RID: 987
	private static readonly IntPtr NativeFieldInfoPtr_m_RuneMechanaCountDisplay;

	// Token: 0x040003DC RID: 988
	private static readonly IntPtr NativeFieldInfoPtr_m_RuneMechanaCountText;

	// Token: 0x040003DD RID: 989
	private static readonly IntPtr NativeFieldInfoPtr_m_RuneGlowGeneric;

	// Token: 0x040003DE RID: 990
	private static readonly IntPtr NativeFieldInfoPtr_m_RuneGlowLifebound;

	// Token: 0x040003DF RID: 991
	private static readonly IntPtr NativeFieldInfoPtr_m_PowerGlow;

	// Token: 0x040003E0 RID: 992
	private static readonly IntPtr NativeFieldInfoPtr_m_EnergyCountDisplay;

	// Token: 0x040003E1 RID: 993
	private static readonly IntPtr NativeFieldInfoPtr_m_EnergyCountText;

	// Token: 0x040003E2 RID: 994
	private static readonly IntPtr NativeFieldInfoPtr_m_TempleResourceDisplayList;

	// Token: 0x040003E3 RID: 995
	private static readonly IntPtr NativeFieldInfoPtr_m_TempleLifeCountText;

	// Token: 0x040003E4 RID: 996
	private static readonly IntPtr NativeFieldInfoPtr_m_TempleDeathCountText;

	// Token: 0x040003E5 RID: 997
	private static readonly IntPtr NativeFieldInfoPtr_m_PortalDeckCountText;

	// Token: 0x040003E6 RID: 998
	private static readonly IntPtr NativeFieldInfoPtr_m_VoidPileCountText;

	// Token: 0x040003E7 RID: 999
	private static readonly IntPtr NativeFieldInfoPtr_m_DayNightRootList;

	// Token: 0x040003E8 RID: 1000
	private static readonly IntPtr NativeFieldInfoPtr_m_DayNightDayList;

	// Token: 0x040003E9 RID: 1001
	private static readonly IntPtr NativeFieldInfoPtr_m_DayNightDayOnlyList;

	// Token: 0x040003EA RID: 1002
	private static readonly IntPtr NativeFieldInfoPtr_m_DayNightNightList;

	// Token: 0x040003EB RID: 1003
	private static readonly IntPtr NativeFieldInfoPtr_m_DayNightNightOnlyList;

	// Token: 0x040003EC RID: 1004
	private static readonly IntPtr NativeFieldInfoPtr_m_DayNightBothList;

	// Token: 0x040003ED RID: 1005
	private static readonly IntPtr NativeFieldInfoPtr_m_LocalPlayerDeckList;

	// Token: 0x040003EE RID: 1006
	private static readonly IntPtr NativeFieldInfoPtr_m_LocalPlayerDeckTrayToggle;

	// Token: 0x040003EF RID: 1007
	private static readonly IntPtr NativeFieldInfoPtr_m_LocalPlayerDiscardTrayToggle;

	// Token: 0x040003F0 RID: 1008
	private static readonly IntPtr NativeFieldInfoPtr_m_LocalPlayerConstructTrayToggle;

	// Token: 0x040003F1 RID: 1009
	private static readonly IntPtr NativeFieldInfoPtr_m_LocalPlayerDreamscapeTrayToggle;

	// Token: 0x040003F2 RID: 1010
	private static readonly IntPtr NativeFieldInfoPtr_m_LocalPlayerLeprechaunTrayToggle;

	// Token: 0x040003F3 RID: 1011
	private static readonly IntPtr NativeFieldInfoPtr_m_VoidTrayToggle;

	// Token: 0x040003F4 RID: 1012
	private static readonly IntPtr NativeFieldInfoPtr_m_LocalPlayerDrawPileList;

	// Token: 0x040003F5 RID: 1013
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorDrawPileList;

	// Token: 0x040003F6 RID: 1014
	private static readonly IntPtr NativeFieldInfoPtr_m_LocalPlayerLifeboundList;

	// Token: 0x040003F7 RID: 1015
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorLifeboundList;

	// Token: 0x040003F8 RID: 1016
	private static readonly IntPtr NativeFieldInfoPtr_m_LocalPlayerDefeatedMonsterList;

	// Token: 0x040003F9 RID: 1017
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorDefeatedMonsterList;

	// Token: 0x040003FA RID: 1018
	private static readonly IntPtr NativeFieldInfoPtr_m_KingdomStackTray;

	// Token: 0x040003FB RID: 1019
	private static readonly IntPtr NativeFieldInfoPtr_m_LeprechaunStackTray;

	// Token: 0x040003FC RID: 1020
	private static readonly IntPtr NativeFieldInfoPtr_m_KingdomStackPrefab;

	// Token: 0x040003FD RID: 1021
	private static readonly IntPtr NativeFieldInfoPtr_m_OptionPrompt;

	// Token: 0x040003FE RID: 1022
	private static readonly IntPtr NativeFieldInfoPtr_m_OptionPromptAnimator;

	// Token: 0x040003FF RID: 1023
	private static readonly IntPtr NativeFieldInfoPtr_m_OptionPromptText;

	// Token: 0x04000400 RID: 1024
	private static readonly IntPtr NativeFieldInfoPtr_m_Button_NoAction;

	// Token: 0x04000401 RID: 1025
	private static readonly IntPtr NativeFieldInfoPtr_m_Button_EndTurn;

	// Token: 0x04000402 RID: 1026
	private static readonly IntPtr NativeFieldInfoPtr_m_Button_Commit;

	// Token: 0x04000403 RID: 1027
	private static readonly IntPtr NativeFieldInfoPtr_m_Button_Undo;

	// Token: 0x04000404 RID: 1028
	private static readonly IntPtr NativeFieldInfoPtr_m_Glow_EndTurn;

	// Token: 0x04000405 RID: 1029
	private static readonly IntPtr NativeFieldInfoPtr_m_Glow_EndTurn_PS;

	// Token: 0x04000406 RID: 1030
	private static readonly IntPtr NativeFieldInfoPtr_m_Glow_EndTurn_Button;

	// Token: 0x04000407 RID: 1031
	private static readonly IntPtr NativeFieldInfoPtr_m_Glow_EndTurn_Red;

	// Token: 0x04000408 RID: 1032
	private static readonly IntPtr NativeFieldInfoPtr_m_Glow_EndTurn_Green;

	// Token: 0x04000409 RID: 1033
	private static readonly IntPtr NativeFieldInfoPtr_m_Glow_EndTurn_RedBlock;

	// Token: 0x0400040A RID: 1034
	private static readonly IntPtr NativeFieldInfoPtr_m_Glow_EndTurn_GreenBlock;

	// Token: 0x0400040B RID: 1035
	private static readonly IntPtr NativeFieldInfoPtr_m_Button_DeliriumDie;

	// Token: 0x0400040C RID: 1036
	private static readonly IntPtr NativeFieldInfoPtr_m_Glow_DeliriumDie;

	// Token: 0x0400040D RID: 1037
	private static readonly IntPtr NativeFieldInfoPtr_m_Popup_Chat;

	// Token: 0x0400040E RID: 1038
	private static readonly IntPtr NativeFieldInfoPtr_m_Popup_Chat_Button;

	// Token: 0x0400040F RID: 1039
	private static readonly IntPtr NativeFieldInfoPtr_m_Popup_Chat_Tray;

	// Token: 0x04000410 RID: 1040
	private static readonly IntPtr NativeFieldInfoPtr_m_Popup_Forfeit;

	// Token: 0x04000411 RID: 1041
	private static readonly IntPtr NativeFieldInfoPtr_m_Popup_Forfeit_KeepPlaying;

	// Token: 0x04000412 RID: 1042
	private static readonly IntPtr NativeFieldInfoPtr_m_Popup_Forfeit_Text;

	// Token: 0x04000413 RID: 1043
	private static readonly IntPtr NativeFieldInfoPtr_m_Popup_Forfeit_Cancel_Button;

	// Token: 0x04000414 RID: 1044
	private static readonly IntPtr NativeFieldInfoPtr_m_Popup_Forfeit_Continue_Button;

	// Token: 0x04000415 RID: 1045
	private static readonly IntPtr NativeFieldInfoPtr_m_Popup_Forfeit_Confirm_Button;

	// Token: 0x04000416 RID: 1046
	private static readonly IntPtr NativeFieldInfoPtr_m_Popup_EndTurn;

	// Token: 0x04000417 RID: 1047
	private static readonly IntPtr NativeFieldInfoPtr_m_Popup_ConfirmMove;

	// Token: 0x04000418 RID: 1048
	private static readonly IntPtr NativeFieldInfoPtr_m_Popup_ConfirmMoveText;

	// Token: 0x04000419 RID: 1049
	private static readonly IntPtr NativeFieldInfoPtr_m_Popup_ConfirmMove_ConfirmButtonText;

	// Token: 0x0400041A RID: 1050
	private static readonly IntPtr NativeFieldInfoPtr_m_Popup_ConfirmMove_CancelButtonText;

	// Token: 0x0400041B RID: 1051
	private static readonly IntPtr NativeFieldInfoPtr_m_Popup_ConfirmMoveImage;

	// Token: 0x0400041C RID: 1052
	private static readonly IntPtr NativeFieldInfoPtr_m_PauseButton;

	// Token: 0x0400041D RID: 1053
	private static readonly IntPtr NativeFieldInfoPtr_m_CloseButton;

	// Token: 0x0400041E RID: 1054
	private static readonly IntPtr NativeFieldInfoPtr_m_Popup_EndGame;

	// Token: 0x0400041F RID: 1055
	private static readonly IntPtr NativeFieldInfoPtr_m_HotseatScreen;

	// Token: 0x04000420 RID: 1056
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialRoot;

	// Token: 0x04000421 RID: 1057
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialPanel;

	// Token: 0x04000422 RID: 1058
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialPanelText_Label;

	// Token: 0x04000423 RID: 1059
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialPanelPrompt;

	// Token: 0x04000424 RID: 1060
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialPanelText_ButtonConfirm;

	// Token: 0x04000425 RID: 1061
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialPanelButton;

	// Token: 0x04000426 RID: 1062
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialPanelContinueButton;

	// Token: 0x04000427 RID: 1063
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialPanelExitButton;

	// Token: 0x04000428 RID: 1064
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialInterfaceCallouts;

	// Token: 0x04000429 RID: 1065
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialInterfaceCalloutPrefabs;

	// Token: 0x0400042A RID: 1066
	private static readonly IntPtr NativeFieldInfoPtr_m_OnlineGameID;

	// Token: 0x0400042B RID: 1067
	private static readonly IntPtr NativeFieldInfoPtr_m_LocalPlayerIndex;

	// Token: 0x0400042C RID: 1068
	private static readonly IntPtr NativeFieldInfoPtr_m_LocalPlayerInstanceID;

	// Token: 0x0400042D RID: 1069
	private static readonly IntPtr NativeFieldInfoPtr_m_RoundNumber;

	// Token: 0x0400042E RID: 1070
	private static readonly IntPtr NativeFieldInfoPtr_m_KingdomStacks;

	// Token: 0x0400042F RID: 1071
	private static readonly IntPtr NativeFieldInfoPtr_m_CardInPlayList;

	// Token: 0x04000430 RID: 1072
	private static readonly IntPtr NativeFieldInfoPtr_m_bShowEnergyCount;

	// Token: 0x04000431 RID: 1073
	private static readonly IntPtr NativeFieldInfoPtr_m_bShowDayNight;

	// Token: 0x04000432 RID: 1074
	private static readonly IntPtr NativeFieldInfoPtr_m_bShowDreamscapeArea;

	// Token: 0x04000433 RID: 1075
	private static readonly IntPtr NativeFieldInfoPtr_m_bShowTemples;

	// Token: 0x04000434 RID: 1076
	private static readonly IntPtr NativeFieldInfoPtr_m_bShowDeckTrayDrawPileList;

	// Token: 0x04000435 RID: 1077
	private static readonly IntPtr NativeFieldInfoPtr_m_bShowDeckTrayLifeboundList;

	// Token: 0x04000436 RID: 1078
	private static readonly IntPtr NativeFieldInfoPtr_m_LifeboundCardList;

	// Token: 0x04000437 RID: 1079
	private static readonly IntPtr NativeFieldInfoPtr_m_bShowDeckTrayDefeatedMonsterList;

	// Token: 0x04000438 RID: 1080
	private static readonly IntPtr NativeFieldInfoPtr_m_DefeatedMonsterCardList;

	// Token: 0x04000439 RID: 1081
	private static readonly IntPtr NativeFieldInfoPtr_m_EndDragCloseTragToggle;

	// Token: 0x0400043A RID: 1082
	private static readonly IntPtr NativeFieldInfoPtr_m_QueryBuffer;

	// Token: 0x0400043B RID: 1083
	private static readonly IntPtr NativeFieldInfoPtr_m_dataBuffer;

	// Token: 0x0400043C RID: 1084
	private static readonly IntPtr NativeFieldInfoPtr_m_hDataBuffer;

	// Token: 0x0400043D RID: 1085
	private static readonly IntPtr NativeFieldInfoPtr_m_bufPtr;

	// Token: 0x0400043E RID: 1086
	private static readonly IntPtr NativeFieldInfoPtr_m_endTurnParticles;

	// Token: 0x0400043F RID: 1087
	private static readonly IntPtr NativeFieldInfoPtr_m_cardList;

	// Token: 0x04000440 RID: 1088
	private static readonly IntPtr NativeFieldInfoPtr_m_hCardInstanceBuffer;

	// Token: 0x04000441 RID: 1089
	private static readonly IntPtr NativeFieldInfoPtr_m_cardBuffer;

	// Token: 0x04000442 RID: 1090
	private static readonly IntPtr NativeFieldInfoPtr_m_GameEventBuffer;

	// Token: 0x04000443 RID: 1091
	private static readonly IntPtr NativeFieldInfoPtr_m_lastSavedState;

	// Token: 0x04000444 RID: 1092
	private static readonly IntPtr NativeFieldInfoPtr_m_PopupManager;

	// Token: 0x04000445 RID: 1093
	private static readonly IntPtr NativeFieldInfoPtr_m_ResourceManager;

	// Token: 0x04000446 RID: 1094
	private static readonly IntPtr NativeFieldInfoPtr_m_ConfirmMoveResource;

	// Token: 0x04000447 RID: 1095
	private static readonly IntPtr NativeFieldInfoPtr_m_ConfirmMovePopupLastShown;

	// Token: 0x04000448 RID: 1096
	private static readonly IntPtr NativeFieldInfoPtr_m_bPaused;

	// Token: 0x04000449 RID: 1097
	private static readonly IntPtr NativeFieldInfoPtr_m_bInitialized;

	// Token: 0x0400044A RID: 1098
	private static readonly IntPtr NativeFieldInfoPtr_m_bWaitingAfterTurn;

	// Token: 0x0400044B RID: 1099
	private static readonly IntPtr NativeFieldInfoPtr_m_bEndGameWaitingForCommit;

	// Token: 0x0400044C RID: 1100
	private static readonly IntPtr NativeFieldInfoPtr_m_bForfeitLastPlayer;

	// Token: 0x0400044D RID: 1101
	private static readonly IntPtr NativeFieldInfoPtr_m_bForfeitDenied;

	// Token: 0x0400044E RID: 1102
	private static readonly IntPtr NativeFieldInfoPtr_m_LoadingScreenHoldUpdateCount;

	// Token: 0x0400044F RID: 1103
	private static readonly IntPtr NativeFieldInfoPtr_m_PauseSimulationTimer;

	// Token: 0x04000450 RID: 1104
	private static readonly IntPtr NativeFieldInfoPtr_m_bLoadedIntoCompletedGame;

	// Token: 0x04000451 RID: 1105
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedRoundNumber;

	// Token: 0x04000452 RID: 1106
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedHonorPool;

	// Token: 0x04000453 RID: 1107
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedRuneCount;

	// Token: 0x04000454 RID: 1108
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedPowerCount;

	// Token: 0x04000455 RID: 1109
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedRuneMechanaCount;

	// Token: 0x04000456 RID: 1110
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedHasRuneMechana;

	// Token: 0x04000457 RID: 1111
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedEnergyCount;

	// Token: 0x04000458 RID: 1112
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedHasEnergy;

	// Token: 0x04000459 RID: 1113
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedPortalDeckCount;

	// Token: 0x0400045A RID: 1114
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedVoidPileCount;

	// Token: 0x0400045B RID: 1115
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedShowDay;

	// Token: 0x0400045C RID: 1116
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedShowNight;

	// Token: 0x0400045D RID: 1117
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedWorldStateFlags;

	// Token: 0x0400045E RID: 1118
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedTempleLifeCount;

	// Token: 0x0400045F RID: 1119
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedHasTempleLife;

	// Token: 0x04000460 RID: 1120
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedTempleDeathCount;

	// Token: 0x04000461 RID: 1121
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedHasTempleDeath;

	// Token: 0x04000462 RID: 1122
	private static readonly IntPtr NativeFieldInfoPtr_m_PopupConfirm_SelectionID;

	// Token: 0x04000463 RID: 1123
	private static readonly IntPtr NativeFieldInfoPtr_m_PopupConfirm_SelectionHint;

	// Token: 0x04000464 RID: 1124
	private static readonly IntPtr NativeFieldInfoPtr_m_PopupConfirm_Negative_SelectionID;

	// Token: 0x04000465 RID: 1125
	private static readonly IntPtr NativeFieldInfoPtr_m_PopupConfirm_Negative_SelectionHint;

	// Token: 0x04000466 RID: 1126
	private static readonly IntPtr NativeFieldInfoPtr_m_Tutorial;

	// Token: 0x04000467 RID: 1127
	private static readonly IntPtr NativeFieldInfoPtr_m_bAdvanceTutorial;

	// Token: 0x04000468 RID: 1128
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialElementsActive;

	// Token: 0x04000469 RID: 1129
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialElementsMagnify;

	// Token: 0x0400046A RID: 1130
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialElementsCreated;

	// Token: 0x0400046B RID: 1131
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialStepTimeStart;

	// Token: 0x0400046C RID: 1132
	private static readonly IntPtr NativeMethodInfoPtr_GetTutorial_Public_Tutorial_0;

	// Token: 0x0400046D RID: 1133
	private static readonly IntPtr NativeMethodInfoPtr_GetTutorialStepStartTime_Public_DateTime_0;

	// Token: 0x0400046E RID: 1134
	private static readonly IntPtr NativeMethodInfoPtr_GetAnimationManager_Public_AnimationManager_0;

	// Token: 0x0400046F RID: 1135
	private static readonly IntPtr NativeMethodInfoPtr_GetDragManager_Public_DragManager_0;

	// Token: 0x04000470 RID: 1136
	private static readonly IntPtr NativeMethodInfoPtr_GetCardManager_Public_AscensionCardManager_0;

	// Token: 0x04000471 RID: 1137
	private static readonly IntPtr NativeMethodInfoPtr_GetLastSavedState_Public_Static_ShortSaveStruct_0;

	// Token: 0x04000472 RID: 1138
	private static readonly IntPtr NativeMethodInfoPtr_GetLocalPlayerIndex_Public_Int32_0;

	// Token: 0x04000473 RID: 1139
	private static readonly IntPtr NativeMethodInfoPtr_GetLocalPlayerInstanceID_Public_Int32_0;

	// Token: 0x04000474 RID: 1140
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayerDisplayByLocalPlayerOrder_Public_PlayerDisplay_Int32_0;

	// Token: 0x04000475 RID: 1141
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayerDisplayByInstanceID_Public_PlayerDisplay_Int32_0;

	// Token: 0x04000476 RID: 1142
	private static readonly IntPtr NativeMethodInfoPtr_GetIsEndGamePopupActive_Public_Boolean_0;

	// Token: 0x04000477 RID: 1143
	private static readonly IntPtr NativeMethodInfoPtr_OnSaveData_Public_Static_Void_IntPtr_Int32_IntPtr_0;

	// Token: 0x04000478 RID: 1144
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000479 RID: 1145
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x0400047A RID: 1146
	private static readonly IntPtr NativeMethodInfoPtr_ConstructTrayKeybind_Private_Void_0;

	// Token: 0x0400047B RID: 1147
	private static readonly IntPtr NativeMethodInfoPtr_DrawTrayKeybind_Private_Void_0;

	// Token: 0x0400047C RID: 1148
	private static readonly IntPtr NativeMethodInfoPtr_DiscardTrayKeybind_Private_Void_0;

	// Token: 0x0400047D RID: 1149
	private static readonly IntPtr NativeMethodInfoPtr_VoidTrayKeybind_Private_Void_0;

	// Token: 0x0400047E RID: 1150
	private static readonly IntPtr NativeMethodInfoPtr_PauseButtonKeybind_Private_Void_0;

	// Token: 0x0400047F RID: 1151
	private static readonly IntPtr NativeMethodInfoPtr_UnmagnifyOrCloseTraysKeybind_Private_Void_0;

	// Token: 0x04000480 RID: 1152
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000481 RID: 1153
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	// Token: 0x04000482 RID: 1154
	private static readonly IntPtr NativeMethodInfoPtr_StartTutorial_Private_Void_0;

	// Token: 0x04000483 RID: 1155
	private static readonly IntPtr NativeMethodInfoPtr_PauseSimulationForTutorial_Private_Boolean_0;

	// Token: 0x04000484 RID: 1156
	private static readonly IntPtr NativeMethodInfoPtr_ClearActiveTutorialElements_Private_Void_0;

	// Token: 0x04000485 RID: 1157
	private static readonly IntPtr NativeMethodInfoPtr_ShowTutorialPanel_Private_Void_TutorialStep_Boolean_0;

	// Token: 0x04000486 RID: 1158
	private static readonly IntPtr NativeMethodInfoPtr_OnMagnifyCard_Private_Void_CardObject_0;

	// Token: 0x04000487 RID: 1159
	private static readonly IntPtr NativeMethodInfoPtr_OnUnmagnifyCard_Private_Void_CardObject_0;

	// Token: 0x04000488 RID: 1160
	private static readonly IntPtr NativeMethodInfoPtr_HandleTutorialEnd_Private_Void_0;

	// Token: 0x04000489 RID: 1161
	private static readonly IntPtr NativeMethodInfoPtr_SetupTutorialStep_Private_Void_0;

	// Token: 0x0400048A RID: 1162
	private static readonly IntPtr NativeMethodInfoPtr_HandleTutorialGameOptionSelection_Public_Void_0;

	// Token: 0x0400048B RID: 1163
	private static readonly IntPtr NativeMethodInfoPtr_AdvanceTutorial_Public_Void_0;

	// Token: 0x0400048C RID: 1164
	private static readonly IntPtr NativeMethodInfoPtr_UpdateTutorial_Private_Void_0;

	// Token: 0x0400048D RID: 1165
	private static readonly IntPtr NativeMethodInfoPtr_OnActionConfirmButtonTutorialPressed_Public_Void_0;

	// Token: 0x0400048E RID: 1166
	private static readonly IntPtr NativeMethodInfoPtr_HandleLeaveGameAnalytics_Public_Static_Void_String_Int32_Int32_0;

	// Token: 0x0400048F RID: 1167
	private static readonly IntPtr NativeMethodInfoPtr_OnBeginAnimationCallback_Public_Void_AnimateObject_UInt32_Int32_Int32_Int32_Int32_0;

	// Token: 0x04000490 RID: 1168
	private static readonly IntPtr NativeMethodInfoPtr_OnEndAnimationCallback_Public_Void_AnimateObject_UInt32_Int32_Int32_Int32_Int32_0;

	// Token: 0x04000491 RID: 1169
	private static readonly IntPtr NativeMethodInfoPtr_OnBeginDragCallback_Public_Void_DragObject_0;

	// Token: 0x04000492 RID: 1170
	private static readonly IntPtr NativeMethodInfoPtr_OnEndDragCallback_Public_Void_DragObject_0;

	// Token: 0x04000493 RID: 1171
	private static readonly IntPtr NativeMethodInfoPtr_OnApplicationPause_Public_Void_Boolean_0;

	// Token: 0x04000494 RID: 1172
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000495 RID: 1173
	private static readonly IntPtr NativeMethodInfoPtr_UpdateWorldData_Public_Void_0;

	// Token: 0x04000496 RID: 1174
	private static readonly IntPtr NativeMethodInfoPtr_UpdateUniqueCardDisplay_Public_Void_0;

	// Token: 0x04000497 RID: 1175
	private static readonly IntPtr NativeMethodInfoPtr_UpdateCenterRowDisplay_Public_Void_0;

	// Token: 0x04000498 RID: 1176
	private static readonly IntPtr NativeMethodInfoPtr_UpdateCenterRowScale_Public_Void_0;

	// Token: 0x04000499 RID: 1177
	private static readonly IntPtr NativeMethodInfoPtr_UpdateKingdomStacks_Public_Void_0;

	// Token: 0x0400049A RID: 1178
	private static readonly IntPtr NativeMethodInfoPtr_GetAllOpponentsHaveForfeited_Public_Boolean_0;

	// Token: 0x0400049B RID: 1179
	private static readonly IntPtr NativeMethodInfoPtr_GetCardInPlay_Public_AscensionCardInPlay_Int32_0;

	// Token: 0x0400049C RID: 1180
	private static readonly IntPtr NativeMethodInfoPtr_GetCardInPlayByAbilityInstanceID_Public_AscensionCardInPlay_Int32_0;

	// Token: 0x0400049D RID: 1181
	private static readonly IntPtr NativeMethodInfoPtr_PutCardInPlay_Private_Void_AscensionCardInPlay_0;

	// Token: 0x0400049E RID: 1182
	private static readonly IntPtr NativeMethodInfoPtr_PutCardInPlay_Public_Void_Int32_Int32_Int32_0;

	// Token: 0x0400049F RID: 1183
	private static readonly IntPtr NativeMethodInfoPtr_RemoveCardFromPlay_Public_Boolean_Int32_0;

	// Token: 0x040004A0 RID: 1184
	private static readonly IntPtr NativeMethodInfoPtr_RemoveAllCardsFromPlay_Public_Void_0;

	// Token: 0x040004A1 RID: 1185
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventPause_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040004A2 RID: 1186
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventKingdomStackStatus_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040004A3 RID: 1187
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventCenterRowStatus_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040004A4 RID: 1188
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventCardInPlayStatus_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040004A5 RID: 1189
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventResetPlayerDiscardPile_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040004A6 RID: 1190
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventCloseDreamscapeTray_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040004A7 RID: 1191
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventEndOfRainbowTray_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040004A8 RID: 1192
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventDeliriumResult_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040004A9 RID: 1193
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventDrawHandAtEndOfTurn_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040004AA RID: 1194
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventTransformCard_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040004AB RID: 1195
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventUpdatePlayedCardList_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040004AC RID: 1196
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventRemovePlayedCard_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040004AD RID: 1197
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventUpdateResolveEffectList_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040004AE RID: 1198
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventTutorialAISelectedOption_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040004AF RID: 1199
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventCommitPlayerDecision_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040004B0 RID: 1200
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventAchievementData_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040004B1 RID: 1201
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventGameOver_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040004B2 RID: 1202
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventLoadProgress_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040004B3 RID: 1203
	private static readonly IntPtr NativeMethodInfoPtr_UpdateGameOptionsSelectionState_Public_Void_Boolean_0;

	// Token: 0x040004B4 RID: 1204
	private static readonly IntPtr NativeMethodInfoPtr_ShowConfirmMovePopup_Public_Void_UInt32_UInt16_Int32_UInt32_UInt16_0;

	// Token: 0x040004B5 RID: 1205
	private static readonly IntPtr NativeMethodInfoPtr_ReleaseConfirmMoveResource_Private_Void_0;

	// Token: 0x040004B6 RID: 1206
	private static readonly IntPtr NativeMethodInfoPtr_OnConfirmPopupConfirmButton_Public_Void_0;

	// Token: 0x040004B7 RID: 1207
	private static readonly IntPtr NativeMethodInfoPtr_OnConfirmPopupCancelButton_Public_Void_0;

	// Token: 0x040004B8 RID: 1208
	private static readonly IntPtr NativeMethodInfoPtr_OnEndTurnKeybind_Private_Void_0;

	// Token: 0x040004B9 RID: 1209
	private static readonly IntPtr NativeMethodInfoPtr_OnEndTurnButton_Public_Void_Boolean_0;

	// Token: 0x040004BA RID: 1210
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayAllKeybind_Public_Void_0;

	// Token: 0x040004BB RID: 1211
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayAllButton_Public_Void_0;

	// Token: 0x040004BC RID: 1212
	private static readonly IntPtr NativeMethodInfoPtr_OnNoneButton_Public_Void_0;

	// Token: 0x040004BD RID: 1213
	private static readonly IntPtr NativeMethodInfoPtr_OnButtonPressedNoAction_Public_Void_0;

	// Token: 0x040004BE RID: 1214
	private static readonly IntPtr NativeMethodInfoPtr_OnButtonPressedEndTurn_Public_Void_Boolean_0;

	// Token: 0x040004BF RID: 1215
	private static readonly IntPtr NativeMethodInfoPtr_OnButtonPressedCommit_Public_Void_0;

	// Token: 0x040004C0 RID: 1216
	private static readonly IntPtr NativeMethodInfoPtr_OnButtonPressedPayForDeliriumDie_Public_Void_Boolean_0;

	// Token: 0x040004C1 RID: 1217
	private static readonly IntPtr NativeMethodInfoPtr_OnMagnifiedCardActionButtonPressed_Public_Void_AscensionCard_UInt16_0;

	// Token: 0x040004C2 RID: 1218
	private static readonly IntPtr NativeMethodInfoPtr_OnForfeitCancelButtonPressed_Public_Void_0;

	// Token: 0x040004C3 RID: 1219
	private static readonly IntPtr NativeMethodInfoPtr_OnForfeitPopupButtonPressed_Public_Void_0;

	// Token: 0x040004C4 RID: 1220
	private static readonly IntPtr NativeMethodInfoPtr_OnCurrentPopupChanged_Public_Void_EPopups_EPopups_0;

	// Token: 0x040004C5 RID: 1221
	private static readonly IntPtr NativeMethodInfoPtr_OnHotseatScreenPressed_Public_Void_0;

	// Token: 0x040004C6 RID: 1222
	private static readonly IntPtr NativeMethodInfoPtr_PauseButtonPressed_Public_Void_0;

	// Token: 0x040004C7 RID: 1223
	private static readonly IntPtr NativeMethodInfoPtr_ResumeButtonPressed_Public_Void_0;

	// Token: 0x040004C8 RID: 1224
	private static readonly IntPtr NativeMethodInfoPtr_SummaryScreenStart_Public_Void_0;

	// Token: 0x040004C9 RID: 1225
	private static readonly IntPtr NativeMethodInfoPtr_SummaryScreenEnd_Public_Void_0;

	// Token: 0x040004CA RID: 1226
	private static readonly IntPtr NativeMethodInfoPtr_SwitchToPlayer_Private_Void_Int32_Boolean_0;

	// Token: 0x040004CB RID: 1227
	private static readonly IntPtr NativeMethodInfoPtr_BuildLocalPlayerDrawPileList_Public_Void_0;

	// Token: 0x040004CC RID: 1228
	private static readonly IntPtr NativeMethodInfoPtr_FindCardInLifeboundList_Public_AscensionCard_Int32_0;

	// Token: 0x040004CD RID: 1229
	private static readonly IntPtr NativeMethodInfoPtr_BuildLifeboundList_Public_Void_0;

	// Token: 0x040004CE RID: 1230
	private static readonly IntPtr NativeMethodInfoPtr_BuildDefeatedMonsterList_Public_Void_0;

	// Token: 0x040004CF RID: 1231
	private static readonly IntPtr NativeMethodInfoPtr_RebuildCenterRow_Public_Void_AscensionCardManager_0;

	// Token: 0x040004D0 RID: 1232
	private static readonly IntPtr NativeMethodInfoPtr_ResetVoidCardTray_Public_Void_0;

	// Token: 0x040004D1 RID: 1233
	private static readonly IntPtr NativeMethodInfoPtr_RebuildVoidCardList_Public_Void_AscensionCardManager_0;

	// Token: 0x040004D2 RID: 1234
	private static readonly IntPtr NativeMethodInfoPtr_RebuildActionAreaPlayedCards_Public_Void_AscensionCardManager_0;

	// Token: 0x040004D3 RID: 1235
	private static readonly IntPtr NativeMethodInfoPtr_RebuildResolveEffectStack_Public_Void_AscensionCardManager_0;

	// Token: 0x040004D4 RID: 1236
	private static readonly IntPtr NativeMethodInfoPtr_RebuildEventCardInPlay_Public_Void_AscensionCardManager_0;

	// Token: 0x040004D5 RID: 1237
	private static readonly IntPtr NativeMethodInfoPtr_RebuildAvailableTemples_Public_Void_AscensionCardManager_0;

	// Token: 0x040004D6 RID: 1238
	private static readonly IntPtr NativeMethodInfoPtr_RebuildUniqueCardZone_Public_Void_AscensionCardManager_0;

	// Token: 0x040004D7 RID: 1239
	private static readonly IntPtr NativeMethodInfoPtr_RebuildGame_Private_Void_0;

	// Token: 0x040004D8 RID: 1240
	private static readonly IntPtr NativeMethodInfoPtr_CreateKingdomStack_Public_GameObject_Int32_Int32_Int32_Boolean_0;

	// Token: 0x040004D9 RID: 1241
	private static readonly IntPtr NativeMethodInfoPtr_RebuildKingdomStacks_Private_Void_0;

	// Token: 0x040004DA RID: 1242
	private static readonly IntPtr NativeMethodInfoPtr_RebuildCardInPlayList_Private_Void_0;

	// Token: 0x040004DB RID: 1243
	private static readonly IntPtr NativeMethodInfoPtr_RebuildInterface_Private_Void_0;

	// Token: 0x040004DC RID: 1244
	private static readonly IntPtr NativeMethodInfoPtr_RebuildAnimationManager_Private_Void_0;

	// Token: 0x040004DD RID: 1245
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

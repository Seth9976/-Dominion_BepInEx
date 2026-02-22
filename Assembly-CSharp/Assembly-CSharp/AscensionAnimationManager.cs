using System;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000014 RID: 20
public class AscensionAnimationManager : AnimationManager
{
	// Token: 0x060001B7 RID: 439 RVA: 0x0001FE4C File Offset: 0x0001E04C
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionAnimationManager()
	{
		Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionAnimationManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr);
		AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animationTypeCard");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeRune = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animationTypeRune");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeRuneMechana = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animationTypeRuneMechana");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animationTypePower");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeHonor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animationTypeHonor");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeEnergy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animationTypeEnergy");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeInsight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animationTypeInsight");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeTempleLife = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animationTypeTempleLife");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeTempleDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animationTypeTempleDeath");
		AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_cardEffectPlay");
		AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_cardEffectDraw");
		AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectAcquire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_cardEffectAcquire");
		AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectDefeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_cardEffectDefeat");
		AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectDiscard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_cardEffectDiscard");
		AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectBanish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_cardEffectBanish");
		AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectCopy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_cardEffectCopy");
		AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectSteal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_cardEffectSteal");
		AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectFate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_cardEffectFate");
		AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectReveal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_cardEffectReveal");
		AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_cardEffectTransform");
		AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_cardEffectAsync");
		AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectPhantasm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_cardEffectPhantasm");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayerHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationPlayerHand");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayerDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationPlayerDeck");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayerDiscard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationPlayerDiscard");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayerConstructs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationPlayerConstructs");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayerInPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationPlayerInPlay");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationKingdomStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationKingdomStack");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationCenterRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationCenterRow");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPortalDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationPortalDeck");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationVoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationVoid");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayedCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationPlayedCards");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationResolveEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationResolveEffects");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationRevealCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationRevealCards");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationEventCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationEventCard");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationSoulGemsStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationSoulGemsStart");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationUnassignedChampionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationUnassignedChampionList");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationUnassignedChampionIncoming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationUnassignedChampionIncoming");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationUnassignedChampionOutgoing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationUnassignedChampionOutgoing");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayerDreamscape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationPlayerDreamscape");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationEndOfRainbow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationEndOfRainbow");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationUnderPlayerConstructs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationUnderPlayerConstructs");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAvailableTemples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationAvailableTemples");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationDeliriumDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationDeliriumDie");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationDeliriumDieStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationDeliriumDieStart");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationDeliriumDieResolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationDeliriumDieResolve");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationUniqueCardZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationUniqueCardZone");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnounceCenterRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationAnnounceCenterRow");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnounceKingdomStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationAnnounceKingdomStack");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnouncePortalDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationAnnouncePortalDeck");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnouncePlayerConstruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationAnnouncePlayerConstruct");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnouncePlayerDiscard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationAnnouncePlayerDiscard");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnounceReveal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationAnnounceReveal");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnounceAvailableTemple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animLocationAnnounceAvailableTemple");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animHintNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animHintNone");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceCenterRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animHintAnnounceCenterRow");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceDiscard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animHintAnnounceDiscard");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceDiscardInvoluntary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animHintAnnounceDiscardInvoluntary");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceDefeatCultist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animHintAnnounceDefeatCultist");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceReveal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animHintAnnounceReveal");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animHintCopyLifeboundCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animHintCopyLifeboundCard");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceDreamscape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animHintAnnounceDreamscape");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animHintCopyCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animHintCopyCard");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animHintRevealPortal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animHintRevealPortal");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animHintIncludePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animHintIncludePlayer");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnouncePlayConstruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animHintAnnouncePlayConstruct");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceUseConstruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animHintAnnounceUseConstruct");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceAvailableTemple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animHintAnnounceAvailableTemple");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceStealTemple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animHintAnnounceStealTemple");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animHintAnnounceMask");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animHintFlagsAnimateIntoVoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animHintFlagsAnimateIntoVoid");
		AscensionAnimationManager.NativeFieldInfoPtr_k_animHintFlagsHideCardOnAnimEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_animHintFlagsHideCardOnAnimEnd");
		AscensionAnimationManager.NativeFieldInfoPtr_k_AnimationFlagEffectFate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_AnimationFlagEffectFate");
		AscensionAnimationManager.NativeFieldInfoPtr_m_CardEffectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_CardEffectColor");
		AscensionAnimationManager.NativeFieldInfoPtr_k_AnimationMovementRateXY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_AnimationMovementRateXY");
		AscensionAnimationManager.NativeFieldInfoPtr_k_AnimationMovementRateZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_AnimationMovementRateZ");
		AscensionAnimationManager.NativeFieldInfoPtr_k_AnimationRotationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_AnimationRotationRate");
		AscensionAnimationManager.NativeFieldInfoPtr_k_AnimationScaleRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_AnimationScaleRate");
		AscensionAnimationManager.NativeFieldInfoPtr_k_AnimationInternalRotationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "k_AnimationInternalRotationRate");
		AscensionAnimationManager.NativeFieldInfoPtr_m_CardManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_CardManager");
		AscensionAnimationManager.NativeFieldInfoPtr_m_AscensionGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_AscensionGame");
		AscensionAnimationManager.NativeFieldInfoPtr_m_AudioManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_AudioManager");
		AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateRuneTokenPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_AnimateRuneTokenPrefab");
		AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateRuneMechanaTokenPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_AnimateRuneMechanaTokenPrefab");
		AscensionAnimationManager.NativeFieldInfoPtr_m_AnimatePowerTokenPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_AnimatePowerTokenPrefab");
		AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateHonorTokenPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_AnimateHonorTokenPrefab");
		AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateEnergyTokenPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_AnimateEnergyTokenPrefab");
		AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateInsightTokenPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_AnimateInsightTokenPrefab");
		AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateTempleLifeTokenPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_AnimateTempleLifeTokenPrefab");
		AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateTempleDeathTokenPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_AnimateTempleDeathTokenPrefab");
		AscensionAnimationManager.NativeFieldInfoPtr_m_DeliriumDiePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_DeliriumDiePrefab");
		AscensionAnimationManager.NativeFieldInfoPtr_m_DisableDeliriumDieButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_DisableDeliriumDieButton");
		AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateTokenDestinations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_AnimateTokenDestinations");
		AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateResourceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_AnimateResourceList");
		AscensionAnimationManager.NativeFieldInfoPtr_m_NetworkConfirmAnimationList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_NetworkConfirmAnimationList");
		AscensionAnimationManager.NativeFieldInfoPtr_m_bWaitForAnimationConfirmation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_bWaitForAnimationConfirmation");
		AscensionAnimationManager.NativeFieldInfoPtr_m_PendingCardDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_PendingCardDraw");
		AscensionAnimationManager.NativeFieldInfoPtr_m_DeliriumDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "m_DeliriumDie");
		AscensionAnimationManager.NativeMethodInfoPtr_RegisterEventHandlers_Public_Void_GameEventBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663443);
		AscensionAnimationManager.NativeMethodInfoPtr_RebuildAnimationManager_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663444);
		AscensionAnimationManager.NativeMethodInfoPtr_SetAnimationRatesCard_Public_Void_AnimateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663445);
		AscensionAnimationManager.NativeMethodInfoPtr_SetAnimationRatesResource_Public_Void_AnimateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663446);
		AscensionAnimationManager.NativeMethodInfoPtr_SetAnimationRatesDeliriumDie_Public_Void_AnimateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663447);
		AscensionAnimationManager.NativeMethodInfoPtr_SetAnimationRatesReturnDragObject_Public_Virtual_Void_AnimateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663448);
		AscensionAnimationManager.NativeMethodInfoPtr_AdjustAnimationPauseTime_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663449);
		AscensionAnimationManager.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663450);
		AscensionAnimationManager.NativeMethodInfoPtr_AddNetworkConfirmAnimation_Private_Void_AnimateObject_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663451);
		AscensionAnimationManager.NativeMethodInfoPtr_AddWaitForAnimationConfirmation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663452);
		AscensionAnimationManager.NativeMethodInfoPtr_PauseForAnimationManager_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663453);
		AscensionAnimationManager.NativeMethodInfoPtr_SetPendingCardDraw_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663454);
		AscensionAnimationManager.NativeMethodInfoPtr_HandleEventAnimationCard_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663455);
		AscensionAnimationManager.NativeMethodInfoPtr_HandleEventAnimationResource_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663456);
		AscensionAnimationManager.NativeMethodInfoPtr_StartAnimationResource_Public_Boolean_UInt32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663457);
		AscensionAnimationManager.NativeMethodInfoPtr_GetDeliriumDieFromInstanceID_Private_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663458);
		AscensionAnimationManager.NativeMethodInfoPtr_HandleEventAnimationDeliriumDie_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663459);
		AscensionAnimationManager.NativeMethodInfoPtr_HandleEventDeliriumResult_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663460);
		AscensionAnimationManager.NativeMethodInfoPtr_PlaceCardInLimboOnAnimEndCallback_Private_Void_AnimateObject_AnimationLocator_AnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663461);
		AscensionAnimationManager.NativeMethodInfoPtr_EndResourceAnimationCallback_Private_Void_AnimateObject_AnimationLocator_AnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663462);
		AscensionAnimationManager.NativeMethodInfoPtr_DestroyAllAnimatingResources_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663463);
		AscensionAnimationManager.NativeMethodInfoPtr_SubtractAnimatingResources_Public_Void_byref_WorldData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663464);
		AscensionAnimationManager.NativeMethodInfoPtr_SubtractAnimatingResources_Public_Void_byref_GamePlayerState_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663465);
		AscensionAnimationManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, 100663466);
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x00020804 File Offset: 0x0001EA04
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 225228, RefRangeEnd = 225229, XrefRangeStart = 225198, XrefRangeEnd = 225228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterEventHandlers(GameEventBuffer game_event_buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(game_event_buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_RegisterEventHandlers_Public_Void_GameEventBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x00020848 File Offset: 0x0001EA48
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 225246, RefRangeEnd = 225247, XrefRangeStart = 225229, XrefRangeEnd = 225246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildAnimationManager()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_RebuildAnimationManager_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001BA RID: 442 RVA: 0x0002087C File Offset: 0x0001EA7C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 225252, RefRangeEnd = 225253, XrefRangeStart = 225247, XrefRangeEnd = 225252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAnimationRatesCard(AnimateObject animate_object)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_SetAnimationRatesCard_Public_Void_AnimateObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001BB RID: 443 RVA: 0x000208C0 File Offset: 0x0001EAC0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 225257, RefRangeEnd = 225258, XrefRangeStart = 225253, XrefRangeEnd = 225257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAnimationRatesResource(AnimateObject animate_object)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_SetAnimationRatesResource_Public_Void_AnimateObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001BC RID: 444 RVA: 0x00020904 File Offset: 0x0001EB04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225258, XrefRangeEnd = 225262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAnimationRatesDeliriumDie(AnimateObject animate_object)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_SetAnimationRatesDeliriumDie_Public_Void_AnimateObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001BD RID: 445 RVA: 0x00020948 File Offset: 0x0001EB48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225262, XrefRangeEnd = 225267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetAnimationRatesReturnDragObject(AnimateObject animate_object)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionAnimationManager.NativeMethodInfoPtr_SetAnimationRatesReturnDragObject_Public_Virtual_Void_AnimateObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001BE RID: 446 RVA: 0x00020998 File Offset: 0x0001EB98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225267, XrefRangeEnd = 225271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float AdjustAnimationPauseTime(float min_time, float max_time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref min_time;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max_time;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_AdjustAnimationPauseTime_Public_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060001BF RID: 447 RVA: 0x000209F0 File Offset: 0x0001EBF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225271, XrefRangeEnd = 225293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionAnimationManager.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x00020A2C File Offset: 0x0001EC2C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 225324, RefRangeEnd = 225326, XrefRangeStart = 225293, XrefRangeEnd = 225324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddNetworkConfirmAnimation(AnimateObject animateObject, uint moveIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animateObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveIndex;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_AddNetworkConfirmAnimation_Private_Void_AnimateObject_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x00020A7C File Offset: 0x0001EC7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225326, XrefRangeEnd = 225327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddWaitForAnimationConfirmation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_AddWaitForAnimationConfirmation_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00020AB8 File Offset: 0x0001ECB8
	[CallerCount(0)]
	public unsafe override bool PauseForAnimationManager()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionAnimationManager.NativeMethodInfoPtr_PauseForAnimationManager_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00020B00 File Offset: 0x0001ED00
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 225334, RefRangeEnd = 225335, XrefRangeStart = 225327, XrefRangeEnd = 225334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPendingCardDraw(GameObject card_object)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card_object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_SetPendingCardDraw_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x00020B44 File Offset: 0x0001ED44
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225335, XrefRangeEnd = 225617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventAnimationCard(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_HandleEventAnimationCard_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x00020B94 File Offset: 0x0001ED94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225617, XrefRangeEnd = 225631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventAnimationResource(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_HandleEventAnimationResource_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00020BE4 File Offset: 0x0001EDE4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 225841, RefRangeEnd = 225842, XrefRangeStart = 225631, XrefRangeEnd = 225841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool StartAnimationResource(uint resource_type, int resource_count, int anim_source_location, int anim_source_instance_id, int anim_destination_location, int anim_destination_instance_id, int animation_card_instance_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref resource_type;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resource_count;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anim_source_location;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anim_source_instance_id;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anim_destination_location;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anim_destination_instance_id;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref animation_card_instance_id;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_StartAnimationResource_Public_Boolean_UInt32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x00020C84 File Offset: 0x0001EE84
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 225883, RefRangeEnd = 225884, XrefRangeStart = 225842, XrefRangeEnd = 225883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetDeliriumDieFromInstanceID(int instanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_GetDeliriumDieFromInstanceID_Private_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x00020CD0 File Offset: 0x0001EED0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225884, XrefRangeEnd = 225923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEventAnimationDeliriumDie(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_HandleEventAnimationDeliriumDie_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x00020D20 File Offset: 0x0001EF20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225923, XrefRangeEnd = 225945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_HandleEventDeliriumResult_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001CA RID: 458 RVA: 0x00020D70 File Offset: 0x0001EF70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225945, XrefRangeEnd = 225965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaceCardInLimboOnAnimEndCallback(AnimateObject animateObject, AnimationLocator sourceLocator, AnimationLocator destinationLocator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animateObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceLocator);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationLocator);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_PlaceCardInLimboOnAnimEndCallback_Private_Void_AnimateObject_AnimationLocator_AnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00020DD8 File Offset: 0x0001EFD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225965, XrefRangeEnd = 225975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndResourceAnimationCallback(AnimateObject animateObject, AnimationLocator sourceLocator, AnimationLocator destinationLocator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animateObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceLocator);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationLocator);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_EndResourceAnimationCallback_Private_Void_AnimateObject_AnimationLocator_AnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00020E40 File Offset: 0x0001F040
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225975, XrefRangeEnd = 225996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyAllAnimatingResources()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_DestroyAllAnimatingResources_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001CD RID: 461 RVA: 0x00020E74 File Offset: 0x0001F074
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 226015, RefRangeEnd = 226016, XrefRangeStart = 225996, XrefRangeEnd = 226015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubtractAnimatingResources(ref WorldData world_data, int destination_locator_index, int destination_locator_instance_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = &world_data;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination_locator_index;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination_locator_instance_id;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_SubtractAnimatingResources_Public_Void_byref_WorldData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001CE RID: 462 RVA: 0x00020ED0 File Offset: 0x0001F0D0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 226032, RefRangeEnd = 226033, XrefRangeStart = 226016, XrefRangeEnd = 226032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubtractAnimatingResources(ref GamePlayerState player_state, int destination_locator_index, int destination_locator_instance_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = &player_state;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination_locator_index;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination_locator_instance_id;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr_SubtractAnimatingResources_Public_Void_byref_GamePlayerState_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001CF RID: 463 RVA: 0x00020F2C File Offset: 0x0001F12C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226033, XrefRangeEnd = 226062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionAnimationManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x00002EE0 File Offset: 0x000010E0
	public AscensionAnimationManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x060001D1 RID: 465 RVA: 0x00020F68 File Offset: 0x0001F168
	// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002EE9 File Offset: 0x000010E9
	public unsafe static uint k_animationTypeCard
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeCard, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeCard, (void*)(&value));
		}
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x060001D3 RID: 467 RVA: 0x00020F84 File Offset: 0x0001F184
	// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002EF7 File Offset: 0x000010F7
	public unsafe static uint k_animationTypeRune
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeRune, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeRune, (void*)(&value));
		}
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x060001D5 RID: 469 RVA: 0x00020FA0 File Offset: 0x0001F1A0
	// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002F05 File Offset: 0x00001105
	public unsafe static uint k_animationTypeRuneMechana
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeRuneMechana, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeRuneMechana, (void*)(&value));
		}
	}

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x060001D7 RID: 471 RVA: 0x00020FBC File Offset: 0x0001F1BC
	// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002F13 File Offset: 0x00001113
	public unsafe static uint k_animationTypePower
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypePower, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypePower, (void*)(&value));
		}
	}

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x060001D9 RID: 473 RVA: 0x00020FD8 File Offset: 0x0001F1D8
	// (set) Token: 0x060001DA RID: 474 RVA: 0x00002F21 File Offset: 0x00001121
	public unsafe static uint k_animationTypeHonor
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeHonor, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeHonor, (void*)(&value));
		}
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x060001DB RID: 475 RVA: 0x00020FF4 File Offset: 0x0001F1F4
	// (set) Token: 0x060001DC RID: 476 RVA: 0x00002F2F File Offset: 0x0000112F
	public unsafe static uint k_animationTypeEnergy
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeEnergy, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeEnergy, (void*)(&value));
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x060001DD RID: 477 RVA: 0x00021010 File Offset: 0x0001F210
	// (set) Token: 0x060001DE RID: 478 RVA: 0x00002F3D File Offset: 0x0000113D
	public unsafe static uint k_animationTypeInsight
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeInsight, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeInsight, (void*)(&value));
		}
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x060001DF RID: 479 RVA: 0x0002102C File Offset: 0x0001F22C
	// (set) Token: 0x060001E0 RID: 480 RVA: 0x00002F4B File Offset: 0x0000114B
	public unsafe static uint k_animationTypeTempleLife
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeTempleLife, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeTempleLife, (void*)(&value));
		}
	}

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x060001E1 RID: 481 RVA: 0x00021048 File Offset: 0x0001F248
	// (set) Token: 0x060001E2 RID: 482 RVA: 0x00002F59 File Offset: 0x00001159
	public unsafe static uint k_animationTypeTempleDeath
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeTempleDeath, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animationTypeTempleDeath, (void*)(&value));
		}
	}

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x060001E3 RID: 483 RVA: 0x00021064 File Offset: 0x0001F264
	// (set) Token: 0x060001E4 RID: 484 RVA: 0x00002F67 File Offset: 0x00001167
	public unsafe static uint k_cardEffectPlay
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectPlay, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectPlay, (void*)(&value));
		}
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x060001E5 RID: 485 RVA: 0x00021080 File Offset: 0x0001F280
	// (set) Token: 0x060001E6 RID: 486 RVA: 0x00002F75 File Offset: 0x00001175
	public unsafe static uint k_cardEffectDraw
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectDraw, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectDraw, (void*)(&value));
		}
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x060001E7 RID: 487 RVA: 0x0002109C File Offset: 0x0001F29C
	// (set) Token: 0x060001E8 RID: 488 RVA: 0x00002F83 File Offset: 0x00001183
	public unsafe static uint k_cardEffectAcquire
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectAcquire, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectAcquire, (void*)(&value));
		}
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x060001E9 RID: 489 RVA: 0x000210B8 File Offset: 0x0001F2B8
	// (set) Token: 0x060001EA RID: 490 RVA: 0x00002F91 File Offset: 0x00001191
	public unsafe static uint k_cardEffectDefeat
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectDefeat, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectDefeat, (void*)(&value));
		}
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x060001EB RID: 491 RVA: 0x000210D4 File Offset: 0x0001F2D4
	// (set) Token: 0x060001EC RID: 492 RVA: 0x00002F9F File Offset: 0x0000119F
	public unsafe static uint k_cardEffectDiscard
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectDiscard, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectDiscard, (void*)(&value));
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x060001ED RID: 493 RVA: 0x000210F0 File Offset: 0x0001F2F0
	// (set) Token: 0x060001EE RID: 494 RVA: 0x00002FAD File Offset: 0x000011AD
	public unsafe static uint k_cardEffectBanish
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectBanish, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectBanish, (void*)(&value));
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x060001EF RID: 495 RVA: 0x0002110C File Offset: 0x0001F30C
	// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002FBB File Offset: 0x000011BB
	public unsafe static uint k_cardEffectCopy
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectCopy, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectCopy, (void*)(&value));
		}
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x060001F1 RID: 497 RVA: 0x00021128 File Offset: 0x0001F328
	// (set) Token: 0x060001F2 RID: 498 RVA: 0x00002FC9 File Offset: 0x000011C9
	public unsafe static uint k_cardEffectSteal
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectSteal, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectSteal, (void*)(&value));
		}
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x060001F3 RID: 499 RVA: 0x00021144 File Offset: 0x0001F344
	// (set) Token: 0x060001F4 RID: 500 RVA: 0x00002FD7 File Offset: 0x000011D7
	public unsafe static uint k_cardEffectFate
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectFate, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectFate, (void*)(&value));
		}
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x060001F5 RID: 501 RVA: 0x00021160 File Offset: 0x0001F360
	// (set) Token: 0x060001F6 RID: 502 RVA: 0x00002FE5 File Offset: 0x000011E5
	public unsafe static uint k_cardEffectReveal
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectReveal, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectReveal, (void*)(&value));
		}
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x060001F7 RID: 503 RVA: 0x0002117C File Offset: 0x0001F37C
	// (set) Token: 0x060001F8 RID: 504 RVA: 0x00002FF3 File Offset: 0x000011F3
	public unsafe static uint k_cardEffectTransform
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectTransform, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectTransform, (void*)(&value));
		}
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x060001F9 RID: 505 RVA: 0x00021198 File Offset: 0x0001F398
	// (set) Token: 0x060001FA RID: 506 RVA: 0x00003001 File Offset: 0x00001201
	public unsafe static uint k_cardEffectAsync
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectAsync, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectAsync, (void*)(&value));
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x060001FB RID: 507 RVA: 0x000211B4 File Offset: 0x0001F3B4
	// (set) Token: 0x060001FC RID: 508 RVA: 0x0000300F File Offset: 0x0000120F
	public unsafe static uint k_cardEffectPhantasm
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectPhantasm, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_cardEffectPhantasm, (void*)(&value));
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x060001FD RID: 509 RVA: 0x000211D0 File Offset: 0x0001F3D0
	// (set) Token: 0x060001FE RID: 510 RVA: 0x0000301D File Offset: 0x0000121D
	public unsafe static int k_animLocationPlayerHand
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayerHand, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayerHand, (void*)(&value));
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x060001FF RID: 511 RVA: 0x000211EC File Offset: 0x0001F3EC
	// (set) Token: 0x06000200 RID: 512 RVA: 0x0000302B File Offset: 0x0000122B
	public unsafe static int k_animLocationPlayerDeck
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayerDeck, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayerDeck, (void*)(&value));
		}
	}

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x06000201 RID: 513 RVA: 0x00021208 File Offset: 0x0001F408
	// (set) Token: 0x06000202 RID: 514 RVA: 0x00003039 File Offset: 0x00001239
	public unsafe static int k_animLocationPlayerDiscard
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayerDiscard, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayerDiscard, (void*)(&value));
		}
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06000203 RID: 515 RVA: 0x00021224 File Offset: 0x0001F424
	// (set) Token: 0x06000204 RID: 516 RVA: 0x00003047 File Offset: 0x00001247
	public unsafe static int k_animLocationPlayerConstructs
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayerConstructs, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayerConstructs, (void*)(&value));
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x06000205 RID: 517 RVA: 0x00021240 File Offset: 0x0001F440
	// (set) Token: 0x06000206 RID: 518 RVA: 0x00003055 File Offset: 0x00001255
	public unsafe static int k_animLocationPlayerInPlay
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayerInPlay, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayerInPlay, (void*)(&value));
		}
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x06000207 RID: 519 RVA: 0x0002125C File Offset: 0x0001F45C
	// (set) Token: 0x06000208 RID: 520 RVA: 0x00003063 File Offset: 0x00001263
	public unsafe static int k_animLocationKingdomStack
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationKingdomStack, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationKingdomStack, (void*)(&value));
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06000209 RID: 521 RVA: 0x00021278 File Offset: 0x0001F478
	// (set) Token: 0x0600020A RID: 522 RVA: 0x00003071 File Offset: 0x00001271
	public unsafe static int k_animLocationCenterRow
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationCenterRow, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationCenterRow, (void*)(&value));
		}
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x0600020B RID: 523 RVA: 0x00021294 File Offset: 0x0001F494
	// (set) Token: 0x0600020C RID: 524 RVA: 0x0000307F File Offset: 0x0000127F
	public unsafe static int k_animLocationPortalDeck
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPortalDeck, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPortalDeck, (void*)(&value));
		}
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x0600020D RID: 525 RVA: 0x000212B0 File Offset: 0x0001F4B0
	// (set) Token: 0x0600020E RID: 526 RVA: 0x0000308D File Offset: 0x0000128D
	public unsafe static int k_animLocationVoid
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationVoid, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationVoid, (void*)(&value));
		}
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x0600020F RID: 527 RVA: 0x000212CC File Offset: 0x0001F4CC
	// (set) Token: 0x06000210 RID: 528 RVA: 0x0000309B File Offset: 0x0000129B
	public unsafe static int k_animLocationPlayedCards
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayedCards, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayedCards, (void*)(&value));
		}
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x06000211 RID: 529 RVA: 0x000212E8 File Offset: 0x0001F4E8
	// (set) Token: 0x06000212 RID: 530 RVA: 0x000030A9 File Offset: 0x000012A9
	public unsafe static int k_animLocationResolveEffects
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationResolveEffects, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationResolveEffects, (void*)(&value));
		}
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x06000213 RID: 531 RVA: 0x00021304 File Offset: 0x0001F504
	// (set) Token: 0x06000214 RID: 532 RVA: 0x000030B7 File Offset: 0x000012B7
	public unsafe static int k_animLocationRevealCards
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationRevealCards, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationRevealCards, (void*)(&value));
		}
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x06000215 RID: 533 RVA: 0x00021320 File Offset: 0x0001F520
	// (set) Token: 0x06000216 RID: 534 RVA: 0x000030C5 File Offset: 0x000012C5
	public unsafe static int k_animLocationEventCard
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationEventCard, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationEventCard, (void*)(&value));
		}
	}

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x06000217 RID: 535 RVA: 0x0002133C File Offset: 0x0001F53C
	// (set) Token: 0x06000218 RID: 536 RVA: 0x000030D3 File Offset: 0x000012D3
	public unsafe static int k_animLocationSoulGemsStart
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationSoulGemsStart, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationSoulGemsStart, (void*)(&value));
		}
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x06000219 RID: 537 RVA: 0x00021358 File Offset: 0x0001F558
	// (set) Token: 0x0600021A RID: 538 RVA: 0x000030E1 File Offset: 0x000012E1
	public unsafe static int k_animLocationUnassignedChampionList
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationUnassignedChampionList, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationUnassignedChampionList, (void*)(&value));
		}
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x0600021B RID: 539 RVA: 0x00021374 File Offset: 0x0001F574
	// (set) Token: 0x0600021C RID: 540 RVA: 0x000030EF File Offset: 0x000012EF
	public unsafe static int k_animLocationUnassignedChampionIncoming
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationUnassignedChampionIncoming, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationUnassignedChampionIncoming, (void*)(&value));
		}
	}

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x0600021D RID: 541 RVA: 0x00021390 File Offset: 0x0001F590
	// (set) Token: 0x0600021E RID: 542 RVA: 0x000030FD File Offset: 0x000012FD
	public unsafe static int k_animLocationUnassignedChampionOutgoing
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationUnassignedChampionOutgoing, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationUnassignedChampionOutgoing, (void*)(&value));
		}
	}

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x0600021F RID: 543 RVA: 0x000213AC File Offset: 0x0001F5AC
	// (set) Token: 0x06000220 RID: 544 RVA: 0x0000310B File Offset: 0x0000130B
	public unsafe static int k_animLocationPlayerDreamscape
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayerDreamscape, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationPlayerDreamscape, (void*)(&value));
		}
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000221 RID: 545 RVA: 0x000213C8 File Offset: 0x0001F5C8
	// (set) Token: 0x06000222 RID: 546 RVA: 0x00003119 File Offset: 0x00001319
	public unsafe static int k_animLocationEndOfRainbow
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationEndOfRainbow, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationEndOfRainbow, (void*)(&value));
		}
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x06000223 RID: 547 RVA: 0x000213E4 File Offset: 0x0001F5E4
	// (set) Token: 0x06000224 RID: 548 RVA: 0x00003127 File Offset: 0x00001327
	public unsafe static int k_animLocationUnderPlayerConstructs
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationUnderPlayerConstructs, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationUnderPlayerConstructs, (void*)(&value));
		}
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x06000225 RID: 549 RVA: 0x00021400 File Offset: 0x0001F600
	// (set) Token: 0x06000226 RID: 550 RVA: 0x00003135 File Offset: 0x00001335
	public unsafe static int k_animLocationAvailableTemples
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAvailableTemples, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAvailableTemples, (void*)(&value));
		}
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x06000227 RID: 551 RVA: 0x0002141C File Offset: 0x0001F61C
	// (set) Token: 0x06000228 RID: 552 RVA: 0x00003143 File Offset: 0x00001343
	public unsafe static int k_animLocationDeliriumDie
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationDeliriumDie, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationDeliriumDie, (void*)(&value));
		}
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x06000229 RID: 553 RVA: 0x00021438 File Offset: 0x0001F638
	// (set) Token: 0x0600022A RID: 554 RVA: 0x00003151 File Offset: 0x00001351
	public unsafe static int k_animLocationDeliriumDieStart
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationDeliriumDieStart, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationDeliriumDieStart, (void*)(&value));
		}
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x0600022B RID: 555 RVA: 0x00021454 File Offset: 0x0001F654
	// (set) Token: 0x0600022C RID: 556 RVA: 0x0000315F File Offset: 0x0000135F
	public unsafe static int k_animLocationDeliriumDieResolve
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationDeliriumDieResolve, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationDeliriumDieResolve, (void*)(&value));
		}
	}

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x0600022D RID: 557 RVA: 0x00021470 File Offset: 0x0001F670
	// (set) Token: 0x0600022E RID: 558 RVA: 0x0000316D File Offset: 0x0000136D
	public unsafe static int k_animLocationUniqueCardZone
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationUniqueCardZone, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationUniqueCardZone, (void*)(&value));
		}
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x0600022F RID: 559 RVA: 0x0002148C File Offset: 0x0001F68C
	// (set) Token: 0x06000230 RID: 560 RVA: 0x0000317B File Offset: 0x0000137B
	public unsafe static int k_animLocationAnnounceCenterRow
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnounceCenterRow, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnounceCenterRow, (void*)(&value));
		}
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x06000231 RID: 561 RVA: 0x000214A8 File Offset: 0x0001F6A8
	// (set) Token: 0x06000232 RID: 562 RVA: 0x00003189 File Offset: 0x00001389
	public unsafe static int k_animLocationAnnounceKingdomStack
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnounceKingdomStack, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnounceKingdomStack, (void*)(&value));
		}
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x06000233 RID: 563 RVA: 0x000214C4 File Offset: 0x0001F6C4
	// (set) Token: 0x06000234 RID: 564 RVA: 0x00003197 File Offset: 0x00001397
	public unsafe static int k_animLocationAnnouncePortalDeck
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnouncePortalDeck, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnouncePortalDeck, (void*)(&value));
		}
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x06000235 RID: 565 RVA: 0x000214E0 File Offset: 0x0001F6E0
	// (set) Token: 0x06000236 RID: 566 RVA: 0x000031A5 File Offset: 0x000013A5
	public unsafe static int k_animLocationAnnouncePlayerConstruct
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnouncePlayerConstruct, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnouncePlayerConstruct, (void*)(&value));
		}
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x06000237 RID: 567 RVA: 0x000214FC File Offset: 0x0001F6FC
	// (set) Token: 0x06000238 RID: 568 RVA: 0x000031B3 File Offset: 0x000013B3
	public unsafe static int k_animLocationAnnouncePlayerDiscard
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnouncePlayerDiscard, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnouncePlayerDiscard, (void*)(&value));
		}
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x06000239 RID: 569 RVA: 0x00021518 File Offset: 0x0001F718
	// (set) Token: 0x0600023A RID: 570 RVA: 0x000031C1 File Offset: 0x000013C1
	public unsafe static int k_animLocationAnnounceReveal
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnounceReveal, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnounceReveal, (void*)(&value));
		}
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x0600023B RID: 571 RVA: 0x00021534 File Offset: 0x0001F734
	// (set) Token: 0x0600023C RID: 572 RVA: 0x000031CF File Offset: 0x000013CF
	public unsafe static int k_animLocationAnnounceAvailableTemple
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnounceAvailableTemple, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animLocationAnnounceAvailableTemple, (void*)(&value));
		}
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x0600023D RID: 573 RVA: 0x00021550 File Offset: 0x0001F750
	// (set) Token: 0x0600023E RID: 574 RVA: 0x000031DD File Offset: 0x000013DD
	public unsafe static uint k_animHintNone
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintNone, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintNone, (void*)(&value));
		}
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x0600023F RID: 575 RVA: 0x0002156C File Offset: 0x0001F76C
	// (set) Token: 0x06000240 RID: 576 RVA: 0x000031EB File Offset: 0x000013EB
	public unsafe static uint k_animHintAnnounceCenterRow
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceCenterRow, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceCenterRow, (void*)(&value));
		}
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x06000241 RID: 577 RVA: 0x00021588 File Offset: 0x0001F788
	// (set) Token: 0x06000242 RID: 578 RVA: 0x000031F9 File Offset: 0x000013F9
	public unsafe static uint k_animHintAnnounceDiscard
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceDiscard, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceDiscard, (void*)(&value));
		}
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x06000243 RID: 579 RVA: 0x000215A4 File Offset: 0x0001F7A4
	// (set) Token: 0x06000244 RID: 580 RVA: 0x00003207 File Offset: 0x00001407
	public unsafe static uint k_animHintAnnounceDiscardInvoluntary
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceDiscardInvoluntary, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceDiscardInvoluntary, (void*)(&value));
		}
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x06000245 RID: 581 RVA: 0x000215C0 File Offset: 0x0001F7C0
	// (set) Token: 0x06000246 RID: 582 RVA: 0x00003215 File Offset: 0x00001415
	public unsafe static uint k_animHintAnnounceDefeatCultist
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceDefeatCultist, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceDefeatCultist, (void*)(&value));
		}
	}

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x06000247 RID: 583 RVA: 0x000215DC File Offset: 0x0001F7DC
	// (set) Token: 0x06000248 RID: 584 RVA: 0x00003223 File Offset: 0x00001423
	public unsafe static uint k_animHintAnnounceReveal
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceReveal, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceReveal, (void*)(&value));
		}
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x06000249 RID: 585 RVA: 0x000215F8 File Offset: 0x0001F7F8
	// (set) Token: 0x0600024A RID: 586 RVA: 0x00003231 File Offset: 0x00001431
	public unsafe static uint k_animHintCopyLifeboundCard
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintCopyLifeboundCard, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintCopyLifeboundCard, (void*)(&value));
		}
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x0600024B RID: 587 RVA: 0x00021614 File Offset: 0x0001F814
	// (set) Token: 0x0600024C RID: 588 RVA: 0x0000323F File Offset: 0x0000143F
	public unsafe static uint k_animHintAnnounceDreamscape
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceDreamscape, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceDreamscape, (void*)(&value));
		}
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x0600024D RID: 589 RVA: 0x00021630 File Offset: 0x0001F830
	// (set) Token: 0x0600024E RID: 590 RVA: 0x0000324D File Offset: 0x0000144D
	public unsafe static uint k_animHintCopyCard
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintCopyCard, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintCopyCard, (void*)(&value));
		}
	}

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x0600024F RID: 591 RVA: 0x0002164C File Offset: 0x0001F84C
	// (set) Token: 0x06000250 RID: 592 RVA: 0x0000325B File Offset: 0x0000145B
	public unsafe static uint k_animHintRevealPortal
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintRevealPortal, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintRevealPortal, (void*)(&value));
		}
	}

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x06000251 RID: 593 RVA: 0x00021668 File Offset: 0x0001F868
	// (set) Token: 0x06000252 RID: 594 RVA: 0x00003269 File Offset: 0x00001469
	public unsafe static uint k_animHintIncludePlayer
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintIncludePlayer, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintIncludePlayer, (void*)(&value));
		}
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x06000253 RID: 595 RVA: 0x00021684 File Offset: 0x0001F884
	// (set) Token: 0x06000254 RID: 596 RVA: 0x00003277 File Offset: 0x00001477
	public unsafe static uint k_animHintAnnouncePlayConstruct
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnouncePlayConstruct, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnouncePlayConstruct, (void*)(&value));
		}
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x06000255 RID: 597 RVA: 0x000216A0 File Offset: 0x0001F8A0
	// (set) Token: 0x06000256 RID: 598 RVA: 0x00003285 File Offset: 0x00001485
	public unsafe static uint k_animHintAnnounceUseConstruct
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceUseConstruct, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceUseConstruct, (void*)(&value));
		}
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x06000257 RID: 599 RVA: 0x000216BC File Offset: 0x0001F8BC
	// (set) Token: 0x06000258 RID: 600 RVA: 0x00003293 File Offset: 0x00001493
	public unsafe static uint k_animHintAnnounceAvailableTemple
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceAvailableTemple, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceAvailableTemple, (void*)(&value));
		}
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x06000259 RID: 601 RVA: 0x000216D8 File Offset: 0x0001F8D8
	// (set) Token: 0x0600025A RID: 602 RVA: 0x000032A1 File Offset: 0x000014A1
	public unsafe static uint k_animHintAnnounceStealTemple
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceStealTemple, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceStealTemple, (void*)(&value));
		}
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x0600025B RID: 603 RVA: 0x000216F4 File Offset: 0x0001F8F4
	// (set) Token: 0x0600025C RID: 604 RVA: 0x000032AF File Offset: 0x000014AF
	public unsafe static uint k_animHintAnnounceMask
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceMask, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintAnnounceMask, (void*)(&value));
		}
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x0600025D RID: 605 RVA: 0x00021710 File Offset: 0x0001F910
	// (set) Token: 0x0600025E RID: 606 RVA: 0x000032BD File Offset: 0x000014BD
	public unsafe static uint k_animHintFlagsAnimateIntoVoid
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintFlagsAnimateIntoVoid, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintFlagsAnimateIntoVoid, (void*)(&value));
		}
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x0600025F RID: 607 RVA: 0x0002172C File Offset: 0x0001F92C
	// (set) Token: 0x06000260 RID: 608 RVA: 0x000032CB File Offset: 0x000014CB
	public unsafe static uint k_animHintFlagsHideCardOnAnimEnd
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintFlagsHideCardOnAnimEnd, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_animHintFlagsHideCardOnAnimEnd, (void*)(&value));
		}
	}

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x06000261 RID: 609 RVA: 0x00021748 File Offset: 0x0001F948
	// (set) Token: 0x06000262 RID: 610 RVA: 0x000032D9 File Offset: 0x000014D9
	public unsafe static uint k_AnimationFlagEffectFate
	{
		get
		{
			uint num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_AnimationFlagEffectFate, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_AnimationFlagEffectFate, (void*)(&value));
		}
	}

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x06000263 RID: 611 RVA: 0x00021764 File Offset: 0x0001F964
	// (set) Token: 0x06000264 RID: 612 RVA: 0x000032E7 File Offset: 0x000014E7
	public unsafe static Il2CppStructArray<Color32> m_CardEffectColor
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_m_CardEffectColor, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color32>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_m_CardEffectColor, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x06000265 RID: 613 RVA: 0x0002178C File Offset: 0x0001F98C
	// (set) Token: 0x06000266 RID: 614 RVA: 0x000032F9 File Offset: 0x000014F9
	public unsafe static float k_AnimationMovementRateXY
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_AnimationMovementRateXY, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_AnimationMovementRateXY, (void*)(&value));
		}
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x06000267 RID: 615 RVA: 0x000217A8 File Offset: 0x0001F9A8
	// (set) Token: 0x06000268 RID: 616 RVA: 0x00003307 File Offset: 0x00001507
	public unsafe static float k_AnimationMovementRateZ
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_AnimationMovementRateZ, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_AnimationMovementRateZ, (void*)(&value));
		}
	}

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x06000269 RID: 617 RVA: 0x000217C4 File Offset: 0x0001F9C4
	// (set) Token: 0x0600026A RID: 618 RVA: 0x00003315 File Offset: 0x00001515
	public unsafe static float k_AnimationRotationRate
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_AnimationRotationRate, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_AnimationRotationRate, (void*)(&value));
		}
	}

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x0600026B RID: 619 RVA: 0x000217E0 File Offset: 0x0001F9E0
	// (set) Token: 0x0600026C RID: 620 RVA: 0x00003323 File Offset: 0x00001523
	public unsafe static float k_AnimationScaleRate
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_AnimationScaleRate, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_AnimationScaleRate, (void*)(&value));
		}
	}

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x0600026D RID: 621 RVA: 0x000217FC File Offset: 0x0001F9FC
	// (set) Token: 0x0600026E RID: 622 RVA: 0x00003331 File Offset: 0x00001531
	public unsafe static float k_AnimationInternalRotationRate
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationManager.NativeFieldInfoPtr_k_AnimationInternalRotationRate, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationManager.NativeFieldInfoPtr_k_AnimationInternalRotationRate, (void*)(&value));
		}
	}

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x0600026F RID: 623 RVA: 0x00021818 File Offset: 0x0001FA18
	// (set) Token: 0x06000270 RID: 624 RVA: 0x0000333F File Offset: 0x0000153F
	public unsafe AscensionCardManager m_CardManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_CardManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCardManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_CardManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x06000271 RID: 625 RVA: 0x00021848 File Offset: 0x0001FA48
	// (set) Token: 0x06000272 RID: 626 RVA: 0x0000335E File Offset: 0x0000155E
	public unsafe AscensionGame m_AscensionGame
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AscensionGame);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionGame>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AscensionGame), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x06000273 RID: 627 RVA: 0x00021878 File Offset: 0x0001FA78
	// (set) Token: 0x06000274 RID: 628 RVA: 0x0000337D File Offset: 0x0000157D
	public unsafe AscensionAudioHandlerIngame m_AudioManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AudioManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAudioHandlerIngame>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AudioManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x06000275 RID: 629 RVA: 0x000218A8 File Offset: 0x0001FAA8
	// (set) Token: 0x06000276 RID: 630 RVA: 0x0000339C File Offset: 0x0000159C
	public unsafe GameObject m_AnimateRuneTokenPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateRuneTokenPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateRuneTokenPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x06000277 RID: 631 RVA: 0x000218D8 File Offset: 0x0001FAD8
	// (set) Token: 0x06000278 RID: 632 RVA: 0x000033BB File Offset: 0x000015BB
	public unsafe GameObject m_AnimateRuneMechanaTokenPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateRuneMechanaTokenPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateRuneMechanaTokenPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x06000279 RID: 633 RVA: 0x00021908 File Offset: 0x0001FB08
	// (set) Token: 0x0600027A RID: 634 RVA: 0x000033DA File Offset: 0x000015DA
	public unsafe GameObject m_AnimatePowerTokenPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimatePowerTokenPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimatePowerTokenPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x0600027B RID: 635 RVA: 0x00021938 File Offset: 0x0001FB38
	// (set) Token: 0x0600027C RID: 636 RVA: 0x000033F9 File Offset: 0x000015F9
	public unsafe GameObject m_AnimateHonorTokenPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateHonorTokenPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateHonorTokenPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x0600027D RID: 637 RVA: 0x00021968 File Offset: 0x0001FB68
	// (set) Token: 0x0600027E RID: 638 RVA: 0x00003418 File Offset: 0x00001618
	public unsafe GameObject m_AnimateEnergyTokenPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateEnergyTokenPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateEnergyTokenPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000DD RID: 221
	// (get) Token: 0x0600027F RID: 639 RVA: 0x00021998 File Offset: 0x0001FB98
	// (set) Token: 0x06000280 RID: 640 RVA: 0x00003437 File Offset: 0x00001637
	public unsafe GameObject m_AnimateInsightTokenPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateInsightTokenPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateInsightTokenPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x06000281 RID: 641 RVA: 0x000219C8 File Offset: 0x0001FBC8
	// (set) Token: 0x06000282 RID: 642 RVA: 0x00003456 File Offset: 0x00001656
	public unsafe GameObject m_AnimateTempleLifeTokenPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateTempleLifeTokenPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateTempleLifeTokenPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000DF RID: 223
	// (get) Token: 0x06000283 RID: 643 RVA: 0x000219F8 File Offset: 0x0001FBF8
	// (set) Token: 0x06000284 RID: 644 RVA: 0x00003475 File Offset: 0x00001675
	public unsafe GameObject m_AnimateTempleDeathTokenPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateTempleDeathTokenPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateTempleDeathTokenPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x06000285 RID: 645 RVA: 0x00021A28 File Offset: 0x0001FC28
	// (set) Token: 0x06000286 RID: 646 RVA: 0x00003494 File Offset: 0x00001694
	public unsafe GameObject m_DeliriumDiePrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_DeliriumDiePrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_DeliriumDiePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x06000287 RID: 647 RVA: 0x00021A58 File Offset: 0x0001FC58
	// (set) Token: 0x06000288 RID: 648 RVA: 0x000034B3 File Offset: 0x000016B3
	public unsafe GameObject m_DisableDeliriumDieButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_DisableDeliriumDieButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_DisableDeliriumDieButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x06000289 RID: 649 RVA: 0x00021A88 File Offset: 0x0001FC88
	// (set) Token: 0x0600028A RID: 650 RVA: 0x000034D2 File Offset: 0x000016D2
	public unsafe Il2CppReferenceArray<GameObject> m_AnimateTokenDestinations
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateTokenDestinations);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateTokenDestinations), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x0600028B RID: 651 RVA: 0x00021AB8 File Offset: 0x0001FCB8
	// (set) Token: 0x0600028C RID: 652 RVA: 0x000034F1 File Offset: 0x000016F1
	public unsafe List<AscensionResource> m_AnimateResourceList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateResourceList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AscensionResource>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_AnimateResourceList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x0600028D RID: 653 RVA: 0x00021AE8 File Offset: 0x0001FCE8
	// (set) Token: 0x0600028E RID: 654 RVA: 0x00003510 File Offset: 0x00001710
	public unsafe List<AscensionAnimationManager.NetworkConfirmAnimationEntry> m_NetworkConfirmAnimationList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_NetworkConfirmAnimationList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AscensionAnimationManager.NetworkConfirmAnimationEntry>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_NetworkConfirmAnimationList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x0600028F RID: 655 RVA: 0x00021B18 File Offset: 0x0001FD18
	// (set) Token: 0x06000290 RID: 656 RVA: 0x0000352F File Offset: 0x0000172F
	public unsafe bool m_bWaitForAnimationConfirmation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_bWaitForAnimationConfirmation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_bWaitForAnimationConfirmation)) = value;
		}
	}

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x06000291 RID: 657 RVA: 0x00021B40 File Offset: 0x0001FD40
	// (set) Token: 0x06000292 RID: 658 RVA: 0x0000354A File Offset: 0x0000174A
	public unsafe GameObject m_PendingCardDraw
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_PendingCardDraw);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_PendingCardDraw), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x06000293 RID: 659 RVA: 0x00021B70 File Offset: 0x0001FD70
	// (set) Token: 0x06000294 RID: 660 RVA: 0x00003569 File Offset: 0x00001769
	public unsafe GameObject m_DeliriumDie
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_DeliriumDie);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NativeFieldInfoPtr_m_DeliriumDie), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000118 RID: 280
	private static readonly IntPtr NativeFieldInfoPtr_k_animationTypeCard;

	// Token: 0x04000119 RID: 281
	private static readonly IntPtr NativeFieldInfoPtr_k_animationTypeRune;

	// Token: 0x0400011A RID: 282
	private static readonly IntPtr NativeFieldInfoPtr_k_animationTypeRuneMechana;

	// Token: 0x0400011B RID: 283
	private static readonly IntPtr NativeFieldInfoPtr_k_animationTypePower;

	// Token: 0x0400011C RID: 284
	private static readonly IntPtr NativeFieldInfoPtr_k_animationTypeHonor;

	// Token: 0x0400011D RID: 285
	private static readonly IntPtr NativeFieldInfoPtr_k_animationTypeEnergy;

	// Token: 0x0400011E RID: 286
	private static readonly IntPtr NativeFieldInfoPtr_k_animationTypeInsight;

	// Token: 0x0400011F RID: 287
	private static readonly IntPtr NativeFieldInfoPtr_k_animationTypeTempleLife;

	// Token: 0x04000120 RID: 288
	private static readonly IntPtr NativeFieldInfoPtr_k_animationTypeTempleDeath;

	// Token: 0x04000121 RID: 289
	private static readonly IntPtr NativeFieldInfoPtr_k_cardEffectPlay;

	// Token: 0x04000122 RID: 290
	private static readonly IntPtr NativeFieldInfoPtr_k_cardEffectDraw;

	// Token: 0x04000123 RID: 291
	private static readonly IntPtr NativeFieldInfoPtr_k_cardEffectAcquire;

	// Token: 0x04000124 RID: 292
	private static readonly IntPtr NativeFieldInfoPtr_k_cardEffectDefeat;

	// Token: 0x04000125 RID: 293
	private static readonly IntPtr NativeFieldInfoPtr_k_cardEffectDiscard;

	// Token: 0x04000126 RID: 294
	private static readonly IntPtr NativeFieldInfoPtr_k_cardEffectBanish;

	// Token: 0x04000127 RID: 295
	private static readonly IntPtr NativeFieldInfoPtr_k_cardEffectCopy;

	// Token: 0x04000128 RID: 296
	private static readonly IntPtr NativeFieldInfoPtr_k_cardEffectSteal;

	// Token: 0x04000129 RID: 297
	private static readonly IntPtr NativeFieldInfoPtr_k_cardEffectFate;

	// Token: 0x0400012A RID: 298
	private static readonly IntPtr NativeFieldInfoPtr_k_cardEffectReveal;

	// Token: 0x0400012B RID: 299
	private static readonly IntPtr NativeFieldInfoPtr_k_cardEffectTransform;

	// Token: 0x0400012C RID: 300
	private static readonly IntPtr NativeFieldInfoPtr_k_cardEffectAsync;

	// Token: 0x0400012D RID: 301
	private static readonly IntPtr NativeFieldInfoPtr_k_cardEffectPhantasm;

	// Token: 0x0400012E RID: 302
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationPlayerHand;

	// Token: 0x0400012F RID: 303
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationPlayerDeck;

	// Token: 0x04000130 RID: 304
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationPlayerDiscard;

	// Token: 0x04000131 RID: 305
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationPlayerConstructs;

	// Token: 0x04000132 RID: 306
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationPlayerInPlay;

	// Token: 0x04000133 RID: 307
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationKingdomStack;

	// Token: 0x04000134 RID: 308
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationCenterRow;

	// Token: 0x04000135 RID: 309
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationPortalDeck;

	// Token: 0x04000136 RID: 310
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationVoid;

	// Token: 0x04000137 RID: 311
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationPlayedCards;

	// Token: 0x04000138 RID: 312
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationResolveEffects;

	// Token: 0x04000139 RID: 313
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationRevealCards;

	// Token: 0x0400013A RID: 314
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationEventCard;

	// Token: 0x0400013B RID: 315
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationSoulGemsStart;

	// Token: 0x0400013C RID: 316
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationUnassignedChampionList;

	// Token: 0x0400013D RID: 317
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationUnassignedChampionIncoming;

	// Token: 0x0400013E RID: 318
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationUnassignedChampionOutgoing;

	// Token: 0x0400013F RID: 319
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationPlayerDreamscape;

	// Token: 0x04000140 RID: 320
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationEndOfRainbow;

	// Token: 0x04000141 RID: 321
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationUnderPlayerConstructs;

	// Token: 0x04000142 RID: 322
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationAvailableTemples;

	// Token: 0x04000143 RID: 323
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationDeliriumDie;

	// Token: 0x04000144 RID: 324
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationDeliriumDieStart;

	// Token: 0x04000145 RID: 325
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationDeliriumDieResolve;

	// Token: 0x04000146 RID: 326
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationUniqueCardZone;

	// Token: 0x04000147 RID: 327
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationAnnounceCenterRow;

	// Token: 0x04000148 RID: 328
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationAnnounceKingdomStack;

	// Token: 0x04000149 RID: 329
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationAnnouncePortalDeck;

	// Token: 0x0400014A RID: 330
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationAnnouncePlayerConstruct;

	// Token: 0x0400014B RID: 331
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationAnnouncePlayerDiscard;

	// Token: 0x0400014C RID: 332
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationAnnounceReveal;

	// Token: 0x0400014D RID: 333
	private static readonly IntPtr NativeFieldInfoPtr_k_animLocationAnnounceAvailableTemple;

	// Token: 0x0400014E RID: 334
	private static readonly IntPtr NativeFieldInfoPtr_k_animHintNone;

	// Token: 0x0400014F RID: 335
	private static readonly IntPtr NativeFieldInfoPtr_k_animHintAnnounceCenterRow;

	// Token: 0x04000150 RID: 336
	private static readonly IntPtr NativeFieldInfoPtr_k_animHintAnnounceDiscard;

	// Token: 0x04000151 RID: 337
	private static readonly IntPtr NativeFieldInfoPtr_k_animHintAnnounceDiscardInvoluntary;

	// Token: 0x04000152 RID: 338
	private static readonly IntPtr NativeFieldInfoPtr_k_animHintAnnounceDefeatCultist;

	// Token: 0x04000153 RID: 339
	private static readonly IntPtr NativeFieldInfoPtr_k_animHintAnnounceReveal;

	// Token: 0x04000154 RID: 340
	private static readonly IntPtr NativeFieldInfoPtr_k_animHintCopyLifeboundCard;

	// Token: 0x04000155 RID: 341
	private static readonly IntPtr NativeFieldInfoPtr_k_animHintAnnounceDreamscape;

	// Token: 0x04000156 RID: 342
	private static readonly IntPtr NativeFieldInfoPtr_k_animHintCopyCard;

	// Token: 0x04000157 RID: 343
	private static readonly IntPtr NativeFieldInfoPtr_k_animHintRevealPortal;

	// Token: 0x04000158 RID: 344
	private static readonly IntPtr NativeFieldInfoPtr_k_animHintIncludePlayer;

	// Token: 0x04000159 RID: 345
	private static readonly IntPtr NativeFieldInfoPtr_k_animHintAnnouncePlayConstruct;

	// Token: 0x0400015A RID: 346
	private static readonly IntPtr NativeFieldInfoPtr_k_animHintAnnounceUseConstruct;

	// Token: 0x0400015B RID: 347
	private static readonly IntPtr NativeFieldInfoPtr_k_animHintAnnounceAvailableTemple;

	// Token: 0x0400015C RID: 348
	private static readonly IntPtr NativeFieldInfoPtr_k_animHintAnnounceStealTemple;

	// Token: 0x0400015D RID: 349
	private static readonly IntPtr NativeFieldInfoPtr_k_animHintAnnounceMask;

	// Token: 0x0400015E RID: 350
	private static readonly IntPtr NativeFieldInfoPtr_k_animHintFlagsAnimateIntoVoid;

	// Token: 0x0400015F RID: 351
	private static readonly IntPtr NativeFieldInfoPtr_k_animHintFlagsHideCardOnAnimEnd;

	// Token: 0x04000160 RID: 352
	private static readonly IntPtr NativeFieldInfoPtr_k_AnimationFlagEffectFate;

	// Token: 0x04000161 RID: 353
	private static readonly IntPtr NativeFieldInfoPtr_m_CardEffectColor;

	// Token: 0x04000162 RID: 354
	private static readonly IntPtr NativeFieldInfoPtr_k_AnimationMovementRateXY;

	// Token: 0x04000163 RID: 355
	private static readonly IntPtr NativeFieldInfoPtr_k_AnimationMovementRateZ;

	// Token: 0x04000164 RID: 356
	private static readonly IntPtr NativeFieldInfoPtr_k_AnimationRotationRate;

	// Token: 0x04000165 RID: 357
	private static readonly IntPtr NativeFieldInfoPtr_k_AnimationScaleRate;

	// Token: 0x04000166 RID: 358
	private static readonly IntPtr NativeFieldInfoPtr_k_AnimationInternalRotationRate;

	// Token: 0x04000167 RID: 359
	private static readonly IntPtr NativeFieldInfoPtr_m_CardManager;

	// Token: 0x04000168 RID: 360
	private static readonly IntPtr NativeFieldInfoPtr_m_AscensionGame;

	// Token: 0x04000169 RID: 361
	private static readonly IntPtr NativeFieldInfoPtr_m_AudioManager;

	// Token: 0x0400016A RID: 362
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimateRuneTokenPrefab;

	// Token: 0x0400016B RID: 363
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimateRuneMechanaTokenPrefab;

	// Token: 0x0400016C RID: 364
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimatePowerTokenPrefab;

	// Token: 0x0400016D RID: 365
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimateHonorTokenPrefab;

	// Token: 0x0400016E RID: 366
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimateEnergyTokenPrefab;

	// Token: 0x0400016F RID: 367
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimateInsightTokenPrefab;

	// Token: 0x04000170 RID: 368
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimateTempleLifeTokenPrefab;

	// Token: 0x04000171 RID: 369
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimateTempleDeathTokenPrefab;

	// Token: 0x04000172 RID: 370
	private static readonly IntPtr NativeFieldInfoPtr_m_DeliriumDiePrefab;

	// Token: 0x04000173 RID: 371
	private static readonly IntPtr NativeFieldInfoPtr_m_DisableDeliriumDieButton;

	// Token: 0x04000174 RID: 372
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimateTokenDestinations;

	// Token: 0x04000175 RID: 373
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimateResourceList;

	// Token: 0x04000176 RID: 374
	private static readonly IntPtr NativeFieldInfoPtr_m_NetworkConfirmAnimationList;

	// Token: 0x04000177 RID: 375
	private static readonly IntPtr NativeFieldInfoPtr_m_bWaitForAnimationConfirmation;

	// Token: 0x04000178 RID: 376
	private static readonly IntPtr NativeFieldInfoPtr_m_PendingCardDraw;

	// Token: 0x04000179 RID: 377
	private static readonly IntPtr NativeFieldInfoPtr_m_DeliriumDie;

	// Token: 0x0400017A RID: 378
	private static readonly IntPtr NativeMethodInfoPtr_RegisterEventHandlers_Public_Void_GameEventBuffer_0;

	// Token: 0x0400017B RID: 379
	private static readonly IntPtr NativeMethodInfoPtr_RebuildAnimationManager_Public_Void_0;

	// Token: 0x0400017C RID: 380
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimationRatesCard_Public_Void_AnimateObject_0;

	// Token: 0x0400017D RID: 381
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimationRatesResource_Public_Void_AnimateObject_0;

	// Token: 0x0400017E RID: 382
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimationRatesDeliriumDie_Public_Void_AnimateObject_0;

	// Token: 0x0400017F RID: 383
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimationRatesReturnDragObject_Public_Virtual_Void_AnimateObject_0;

	// Token: 0x04000180 RID: 384
	private static readonly IntPtr NativeMethodInfoPtr_AdjustAnimationPauseTime_Public_Single_Single_Single_0;

	// Token: 0x04000181 RID: 385
	private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

	// Token: 0x04000182 RID: 386
	private static readonly IntPtr NativeMethodInfoPtr_AddNetworkConfirmAnimation_Private_Void_AnimateObject_UInt32_0;

	// Token: 0x04000183 RID: 387
	private static readonly IntPtr NativeMethodInfoPtr_AddWaitForAnimationConfirmation_Public_Boolean_0;

	// Token: 0x04000184 RID: 388
	private static readonly IntPtr NativeMethodInfoPtr_PauseForAnimationManager_Public_Virtual_Boolean_0;

	// Token: 0x04000185 RID: 389
	private static readonly IntPtr NativeMethodInfoPtr_SetPendingCardDraw_Public_Void_GameObject_0;

	// Token: 0x04000186 RID: 390
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventAnimationCard_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x04000187 RID: 391
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventAnimationResource_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x04000188 RID: 392
	private static readonly IntPtr NativeMethodInfoPtr_StartAnimationResource_Public_Boolean_UInt32_Int32_Int32_Int32_Int32_Int32_Int32_0;

	// Token: 0x04000189 RID: 393
	private static readonly IntPtr NativeMethodInfoPtr_GetDeliriumDieFromInstanceID_Private_GameObject_Int32_0;

	// Token: 0x0400018A RID: 394
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventAnimationDeliriumDie_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x0400018B RID: 395
	private static readonly IntPtr NativeMethodInfoPtr_HandleEventDeliriumResult_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x0400018C RID: 396
	private static readonly IntPtr NativeMethodInfoPtr_PlaceCardInLimboOnAnimEndCallback_Private_Void_AnimateObject_AnimationLocator_AnimationLocator_0;

	// Token: 0x0400018D RID: 397
	private static readonly IntPtr NativeMethodInfoPtr_EndResourceAnimationCallback_Private_Void_AnimateObject_AnimationLocator_AnimationLocator_0;

	// Token: 0x0400018E RID: 398
	private static readonly IntPtr NativeMethodInfoPtr_DestroyAllAnimatingResources_Public_Void_0;

	// Token: 0x0400018F RID: 399
	private static readonly IntPtr NativeMethodInfoPtr_SubtractAnimatingResources_Public_Void_byref_WorldData_Int32_Int32_0;

	// Token: 0x04000190 RID: 400
	private static readonly IntPtr NativeMethodInfoPtr_SubtractAnimatingResources_Public_Void_byref_GamePlayerState_Int32_Int32_0;

	// Token: 0x04000191 RID: 401
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000169 RID: 361
	public class NetworkConfirmAnimationEntry : global::Il2CppSystem.Object
	{
		// Token: 0x060022B0 RID: 8880 RVA: 0x0008230C File Offset: 0x0008050C
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkConfirmAnimationEntry()
		{
			Il2CppClassPointerStore<AscensionAnimationManager.NetworkConfirmAnimationEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionAnimationManager>.NativeClassPtr, "NetworkConfirmAnimationEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionAnimationManager.NetworkConfirmAnimationEntry>.NativeClassPtr);
			AscensionAnimationManager.NetworkConfirmAnimationEntry.NativeFieldInfoPtr_m_AnimateObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager.NetworkConfirmAnimationEntry>.NativeClassPtr, "m_AnimateObject");
			AscensionAnimationManager.NetworkConfirmAnimationEntry.NativeFieldInfoPtr_m_MoveIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationManager.NetworkConfirmAnimationEntry>.NativeClassPtr, "m_MoveIndex");
			AscensionAnimationManager.NetworkConfirmAnimationEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationManager.NetworkConfirmAnimationEntry>.NativeClassPtr, 100666029);
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x00082374 File Offset: 0x00080574
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkConfirmAnimationEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionAnimationManager.NetworkConfirmAnimationEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationManager.NetworkConfirmAnimationEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x00015D51 File Offset: 0x00013F51
		public NetworkConfirmAnimationEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x000823B0 File Offset: 0x000805B0
		// (set) Token: 0x060022B4 RID: 8884 RVA: 0x00015D5A File Offset: 0x00013F5A
		public unsafe AnimateObject m_AnimateObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NetworkConfirmAnimationEntry.NativeFieldInfoPtr_m_AnimateObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimateObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NetworkConfirmAnimationEntry.NativeFieldInfoPtr_m_AnimateObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x000823E0 File Offset: 0x000805E0
		// (set) Token: 0x060022B6 RID: 8886 RVA: 0x00015D79 File Offset: 0x00013F79
		public unsafe uint m_MoveIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NetworkConfirmAnimationEntry.NativeFieldInfoPtr_m_MoveIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationManager.NetworkConfirmAnimationEntry.NativeFieldInfoPtr_m_MoveIndex)) = value;
			}
		}

		// Token: 0x04001819 RID: 6169
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimateObject;

		// Token: 0x0400181A RID: 6170
		private static readonly IntPtr NativeFieldInfoPtr_m_MoveIndex;

		// Token: 0x0400181B RID: 6171
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

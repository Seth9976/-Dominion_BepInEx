using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000015 RID: 21
public class AscensionAudioHandlerIngame : MonoBehaviour
{
	// Token: 0x06000295 RID: 661 RVA: 0x00021BA0 File Offset: 0x0001FDA0
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionAudioHandlerIngame()
	{
		Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionAudioHandlerIngame");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr);
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_AnimationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_AnimationManager");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_CardManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_CardManager");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_DragManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_DragManager");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_AudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_AudioSource");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_DragAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_DragAudioSource");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionConfirm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipActionConfirm");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipActionBack");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipActionSelect");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionEndTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipActionEndTurn");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionTakeCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipActionTakeCard");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionActivateCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipActionActivateCard");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionBanishCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipActionBanishCard");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceRune = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimResourceRune");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceRuneMechana = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimResourceRuneMechana");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourcePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimResourcePower");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceHonor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimResourceHonor");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceEnergy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimResourceEnergy");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceInsight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimResourceInsight");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceTempleLife = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimResourceTempleLife");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceTempleDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimResourceTempleDeath");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipStartAnimCardDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipStartAnimCardDeck");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipStartAnimCardSlide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipStartAnimCardSlide");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipStartAnimCardFate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipStartAnimCardFate");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipStartCardDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipStartCardDrag");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipUpdateCardDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipUpdateCardDrag");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCenterRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimCenterRow");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimPlayedArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimPlayedArea");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardConstruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimCardConstruct");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardConstructDreamersGlass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimCardConstructDreamersGlass");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimConstructInPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimConstructInPlay");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardAcquire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimCardAcquire");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardAcquireHero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimCardAcquireHero");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardAcquireConstruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimCardAcquireConstruct");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardFateRatKing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimCardFateRatKing");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardFateNemesis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimCardFateNemesis");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimEventEnlightened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimEventEnlightened");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimEventLifebound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimEventLifebound");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimEventMechana = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimEventMechana");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimEventVoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimEventVoid");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimEventMonster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEndAnimEventMonster");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventShuffleDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventShuffleDeck");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventAcquireEnergyShard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventAcquireEnergyShard");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventAcquireDarkEnergyShard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventAcquireDarkEnergyShard");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_AudioDefeatMonster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_AudioDefeatMonster");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipDefeatCultist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipDefeatCultist");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipDefeatCultistScream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipDefeatCultistScream");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipDefeatFanatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipDefeatFanatic");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventTransformedCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventTransformedCard");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventTransformedAdayu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventTransformedAdayu");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventTransformedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventTransformedEvent");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventPlayedDayEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventPlayedDayEffect");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventPlayedNightEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventPlayedNightEffect");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventGainReputation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventGainReputation");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventAcquiredChampion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventAcquiredChampion");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventDefeatedHero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventDefeatedHero");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventAcquiredPortal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventAcquiredPortal");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventRallyAcquire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventRallyAcquire");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventRallyDefeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventRallyDefeat");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventEnergizedConstruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventEnergizedConstruct");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventMovedEnergyCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventMovedEnergyCard");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventPlayLeprechaun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventPlayLeprechaun");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventAcquireEmpower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventAcquireEmpower");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventInfestMonster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventInfestMonster");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventPlayMonsterFromHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventPlayMonsterFromHand");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventCellBlockE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventCellBlockE");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventPrimeDirective = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventPrimeDirective");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventThicketFamiliar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventThicketFamiliar");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventYukTribeOutcast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventYukTribeOutcast");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventGainControlOfNeutralTemple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventGainControlOfNeutralTemple");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventGainControlOfOppTemple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventGainControlOfOppTemple");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventUseTempleEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventUseTempleEffect");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventSerenity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventSerenity");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventEcho = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventEcho");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventJubliantMonkCardMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventJubliantMonkCardMatch");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventFistOfTheDragonMonsterDefeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventFistOfTheDragonMonsterDefeat");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventShuffleSelfBackIntoDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventShuffleSelfBackIntoDeck");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventDiscardEntireDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventDiscardEntireDeck");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventAlosyanGuide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventAlosyanGuide");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventDeliriumStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventDeliriumStart");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventDeliriumResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventDeliriumResult");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventRecur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventRecur");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventInsightAuction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipEventInsightAuction");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipTrayOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipTrayOpen");
		AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipTrayClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, "m_ClipTrayClose");
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663468);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663469);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663470);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_RegisterEventHandlers_Public_Void_GameEventBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663471);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_RegisterMagnifyManager_Public_Void_AscensionMagnifyManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663472);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_PlayDeliriumDieAudio_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663473);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_PlayAudioActionSelect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663474);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_PlayAudioTrayOpen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663475);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_PlayAudioTrayClose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663476);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_PlayRandomSoundFromList_Private_Void_Il2CppReferenceArray_1_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663477);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_PlaySoundFromList_Private_Void_Il2CppReferenceArray_1_AudioClip_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663478);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleBeginAnimation_Private_Void_AnimateObject_UInt32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663479);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleEndAnimation_Private_Void_AnimateObject_UInt32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663480);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleBeginDrag_Public_Void_DragObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663481);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleUpdateDrag_Public_Void_DragObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663482);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleBeginMagnifyCard_Private_Void_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663483);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleEndMagnifyCard_Private_Void_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663484);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandlePlayerSelectedOption_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663485);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleResetPlayerDiscardPile_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663486);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleDefeatMonster_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663487);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleAcquireCard_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663488);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleActionEvent_Private_Void_IntPtr_GameEventFeedback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663489);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr_PlayTransformCardSound_Public_Void_AscensionCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663490);
		AscensionAudioHandlerIngame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr, 100663491);
	}

	// Token: 0x06000296 RID: 662 RVA: 0x00022440 File Offset: 0x00020640
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000297 RID: 663 RVA: 0x00022474 File Offset: 0x00020674
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226062, XrefRangeEnd = 226095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000298 RID: 664 RVA: 0x000224A8 File Offset: 0x000206A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226095, XrefRangeEnd = 226128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000299 RID: 665 RVA: 0x000224DC File Offset: 0x000206DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226128, XrefRangeEnd = 226165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterEventHandlers(GameEventBuffer game_event_buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(game_event_buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_RegisterEventHandlers_Public_Void_GameEventBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600029A RID: 666 RVA: 0x00022520 File Offset: 0x00020720
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226165, XrefRangeEnd = 226182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterMagnifyManager(AscensionMagnifyManager magnify_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(magnify_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_RegisterMagnifyManager_Public_Void_AscensionMagnifyManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600029B RID: 667 RVA: 0x00022564 File Offset: 0x00020764
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 226184, RefRangeEnd = 226187, XrefRangeStart = 226182, XrefRangeEnd = 226184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayDeliriumDieAudio(int result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_PlayDeliriumDieAudio_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600029C RID: 668 RVA: 0x000225A4 File Offset: 0x000207A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226187, XrefRangeEnd = 226188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayAudioActionSelect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_PlayAudioActionSelect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600029D RID: 669 RVA: 0x000225D8 File Offset: 0x000207D8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 226189, RefRangeEnd = 226191, XrefRangeStart = 226188, XrefRangeEnd = 226189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayAudioTrayOpen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_PlayAudioTrayOpen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600029E RID: 670 RVA: 0x0002260C File Offset: 0x0002080C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 226189, RefRangeEnd = 226191, XrefRangeStart = 226189, XrefRangeEnd = 226191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayAudioTrayClose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_PlayAudioTrayClose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600029F RID: 671 RVA: 0x00022640 File Offset: 0x00020840
	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 226197, RefRangeEnd = 226215, XrefRangeStart = 226191, XrefRangeEnd = 226197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayRandomSoundFromList(Il2CppReferenceArray<AudioClip> audioClipList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioClipList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_PlayRandomSoundFromList_Private_Void_Il2CppReferenceArray_1_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x00022684 File Offset: 0x00020884
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 226220, RefRangeEnd = 226221, XrefRangeStart = 226215, XrefRangeEnd = 226220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaySoundFromList(Il2CppReferenceArray<AudioClip> audioClipList, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioClipList);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_PlaySoundFromList_Private_Void_Il2CppReferenceArray_1_AudioClip_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x000226D4 File Offset: 0x000208D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226221, XrefRangeEnd = 226230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleBeginAnimation(AnimateObject animateObject, uint animationFlags, int sourceLocatorIndex, int sourceLocatorInstanceID, int destinationLocatorIndex, int destinationLocatorInstanceID)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleBeginAnimation_Private_Void_AnimateObject_UInt32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x0002275C File Offset: 0x0002095C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226230, XrefRangeEnd = 226247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEndAnimation(AnimateObject animateObject, uint animationFlags, int sourceLocatorIndex, int sourceLocatorInstanceID, int destinationLocatorIndex, int destinationLocatorInstanceID)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleEndAnimation_Private_Void_AnimateObject_UInt32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x000227E4 File Offset: 0x000209E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226247, XrefRangeEnd = 226260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleBeginDrag(DragObject dragObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleBeginDrag_Public_Void_DragObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x00022828 File Offset: 0x00020A28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226260, XrefRangeEnd = 226274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleUpdateDrag(DragObject dragObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleUpdateDrag_Public_Void_DragObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x0002286C File Offset: 0x00020A6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226274, XrefRangeEnd = 226285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleBeginMagnifyCard(CardObject magnifyCard)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(magnifyCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleBeginMagnifyCard_Private_Void_CardObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x000228B0 File Offset: 0x00020AB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226285, XrefRangeEnd = 226286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleEndMagnifyCard(CardObject magnifyCard)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(magnifyCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleEndMagnifyCard_Private_Void_CardObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x000228F4 File Offset: 0x00020AF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226286, XrefRangeEnd = 226301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandlePlayerSelectedOption(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandlePlayerSelectedOption_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x00022944 File Offset: 0x00020B44
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226301, XrefRangeEnd = 226313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleResetPlayerDiscardPile(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleResetPlayerDiscardPile_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x00022994 File Offset: 0x00020B94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226313, XrefRangeEnd = 226343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleDefeatMonster(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleDefeatMonster_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002AA RID: 682 RVA: 0x000229E4 File Offset: 0x00020BE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226343, XrefRangeEnd = 226382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleAcquireCard(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleAcquireCard_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002AB RID: 683 RVA: 0x00022A34 File Offset: 0x00020C34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226382, XrefRangeEnd = 226398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleActionEvent(IntPtr event_buffer, GameEventFeedback event_feedback)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_HandleActionEvent_Private_Void_IntPtr_GameEventFeedback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002AC RID: 684 RVA: 0x00022A84 File Offset: 0x00020C84
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 226421, RefRangeEnd = 226422, XrefRangeStart = 226398, XrefRangeEnd = 226421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayTransformCardSound(AscensionCard transformedCard)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transformedCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr_PlayTransformCardSound_Public_Void_AscensionCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060002AD RID: 685 RVA: 0x00022AC8 File Offset: 0x00020CC8
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionAudioHandlerIngame()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionAudioHandlerIngame>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAudioHandlerIngame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002AE RID: 686 RVA: 0x00003588 File Offset: 0x00001788
	public AscensionAudioHandlerIngame(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x060002AF RID: 687 RVA: 0x00022B04 File Offset: 0x00020D04
	// (set) Token: 0x060002B0 RID: 688 RVA: 0x00003591 File Offset: 0x00001791
	public unsafe AscensionAnimationManager m_AnimationManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_AnimationManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_AnimationManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x060002B1 RID: 689 RVA: 0x00022B34 File Offset: 0x00020D34
	// (set) Token: 0x060002B2 RID: 690 RVA: 0x000035B0 File Offset: 0x000017B0
	public unsafe AscensionCardManager m_CardManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_CardManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCardManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_CardManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x060002B3 RID: 691 RVA: 0x00022B64 File Offset: 0x00020D64
	// (set) Token: 0x060002B4 RID: 692 RVA: 0x000035CF File Offset: 0x000017CF
	public unsafe DragManager m_DragManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_DragManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DragManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_DragManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000EB RID: 235
	// (get) Token: 0x060002B5 RID: 693 RVA: 0x00022B94 File Offset: 0x00020D94
	// (set) Token: 0x060002B6 RID: 694 RVA: 0x000035EE File Offset: 0x000017EE
	public unsafe AudioSource m_AudioSource
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_AudioSource);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_AudioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x060002B7 RID: 695 RVA: 0x00022BC4 File Offset: 0x00020DC4
	// (set) Token: 0x060002B8 RID: 696 RVA: 0x0000360D File Offset: 0x0000180D
	public unsafe AudioSource m_DragAudioSource
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_DragAudioSource);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_DragAudioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x060002B9 RID: 697 RVA: 0x00022BF4 File Offset: 0x00020DF4
	// (set) Token: 0x060002BA RID: 698 RVA: 0x0000362C File Offset: 0x0000182C
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipActionConfirm
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionConfirm);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionConfirm), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x060002BB RID: 699 RVA: 0x00022C24 File Offset: 0x00020E24
	// (set) Token: 0x060002BC RID: 700 RVA: 0x0000364B File Offset: 0x0000184B
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipActionBack
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionBack);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionBack), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x060002BD RID: 701 RVA: 0x00022C54 File Offset: 0x00020E54
	// (set) Token: 0x060002BE RID: 702 RVA: 0x0000366A File Offset: 0x0000186A
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipActionSelect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionSelect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionSelect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x060002BF RID: 703 RVA: 0x00022C84 File Offset: 0x00020E84
	// (set) Token: 0x060002C0 RID: 704 RVA: 0x00003689 File Offset: 0x00001889
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipActionEndTurn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionEndTurn);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionEndTurn), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x060002C1 RID: 705 RVA: 0x00022CB4 File Offset: 0x00020EB4
	// (set) Token: 0x060002C2 RID: 706 RVA: 0x000036A8 File Offset: 0x000018A8
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipActionTakeCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionTakeCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionTakeCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x060002C3 RID: 707 RVA: 0x00022CE4 File Offset: 0x00020EE4
	// (set) Token: 0x060002C4 RID: 708 RVA: 0x000036C7 File Offset: 0x000018C7
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipActionActivateCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionActivateCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionActivateCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x060002C5 RID: 709 RVA: 0x00022D14 File Offset: 0x00020F14
	// (set) Token: 0x060002C6 RID: 710 RVA: 0x000036E6 File Offset: 0x000018E6
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipActionBanishCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionBanishCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipActionBanishCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x060002C7 RID: 711 RVA: 0x00022D44 File Offset: 0x00020F44
	// (set) Token: 0x060002C8 RID: 712 RVA: 0x00003705 File Offset: 0x00001905
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimResourceRune
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceRune);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceRune), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x060002C9 RID: 713 RVA: 0x00022D74 File Offset: 0x00020F74
	// (set) Token: 0x060002CA RID: 714 RVA: 0x00003724 File Offset: 0x00001924
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimResourceRuneMechana
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceRuneMechana);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceRuneMechana), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x060002CB RID: 715 RVA: 0x00022DA4 File Offset: 0x00020FA4
	// (set) Token: 0x060002CC RID: 716 RVA: 0x00003743 File Offset: 0x00001943
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimResourcePower
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourcePower);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourcePower), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x060002CD RID: 717 RVA: 0x00022DD4 File Offset: 0x00020FD4
	// (set) Token: 0x060002CE RID: 718 RVA: 0x00003762 File Offset: 0x00001962
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimResourceHonor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceHonor);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceHonor), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x060002CF RID: 719 RVA: 0x00022E04 File Offset: 0x00021004
	// (set) Token: 0x060002D0 RID: 720 RVA: 0x00003781 File Offset: 0x00001981
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimResourceEnergy
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceEnergy);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceEnergy), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x060002D1 RID: 721 RVA: 0x00022E34 File Offset: 0x00021034
	// (set) Token: 0x060002D2 RID: 722 RVA: 0x000037A0 File Offset: 0x000019A0
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimResourceInsight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceInsight);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceInsight), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x060002D3 RID: 723 RVA: 0x00022E64 File Offset: 0x00021064
	// (set) Token: 0x060002D4 RID: 724 RVA: 0x000037BF File Offset: 0x000019BF
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimResourceTempleLife
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceTempleLife);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceTempleLife), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x060002D5 RID: 725 RVA: 0x00022E94 File Offset: 0x00021094
	// (set) Token: 0x060002D6 RID: 726 RVA: 0x000037DE File Offset: 0x000019DE
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimResourceTempleDeath
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceTempleDeath);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimResourceTempleDeath), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x060002D7 RID: 727 RVA: 0x00022EC4 File Offset: 0x000210C4
	// (set) Token: 0x060002D8 RID: 728 RVA: 0x000037FD File Offset: 0x000019FD
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipStartAnimCardDeck
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipStartAnimCardDeck);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipStartAnimCardDeck), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000FD RID: 253
	// (get) Token: 0x060002D9 RID: 729 RVA: 0x00022EF4 File Offset: 0x000210F4
	// (set) Token: 0x060002DA RID: 730 RVA: 0x0000381C File Offset: 0x00001A1C
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipStartAnimCardSlide
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipStartAnimCardSlide);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipStartAnimCardSlide), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x060002DB RID: 731 RVA: 0x00022F24 File Offset: 0x00021124
	// (set) Token: 0x060002DC RID: 732 RVA: 0x0000383B File Offset: 0x00001A3B
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipStartAnimCardFate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipStartAnimCardFate);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipStartAnimCardFate), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x060002DD RID: 733 RVA: 0x00022F54 File Offset: 0x00021154
	// (set) Token: 0x060002DE RID: 734 RVA: 0x0000385A File Offset: 0x00001A5A
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipStartCardDrag
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipStartCardDrag);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipStartCardDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x060002DF RID: 735 RVA: 0x00022F84 File Offset: 0x00021184
	// (set) Token: 0x060002E0 RID: 736 RVA: 0x00003879 File Offset: 0x00001A79
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipUpdateCardDrag
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipUpdateCardDrag);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipUpdateCardDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x060002E1 RID: 737 RVA: 0x00022FB4 File Offset: 0x000211B4
	// (set) Token: 0x060002E2 RID: 738 RVA: 0x00003898 File Offset: 0x00001A98
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimCenterRow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCenterRow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCenterRow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x060002E3 RID: 739 RVA: 0x00022FE4 File Offset: 0x000211E4
	// (set) Token: 0x060002E4 RID: 740 RVA: 0x000038B7 File Offset: 0x00001AB7
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimPlayedArea
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimPlayedArea);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimPlayedArea), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x060002E5 RID: 741 RVA: 0x00023014 File Offset: 0x00021214
	// (set) Token: 0x060002E6 RID: 742 RVA: 0x000038D6 File Offset: 0x00001AD6
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimCardConstruct
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardConstruct);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardConstruct), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x060002E7 RID: 743 RVA: 0x00023044 File Offset: 0x00021244
	// (set) Token: 0x060002E8 RID: 744 RVA: 0x000038F5 File Offset: 0x00001AF5
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimCardConstructDreamersGlass
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardConstructDreamersGlass);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardConstructDreamersGlass), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x060002E9 RID: 745 RVA: 0x00023074 File Offset: 0x00021274
	// (set) Token: 0x060002EA RID: 746 RVA: 0x00003914 File Offset: 0x00001B14
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimConstructInPlay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimConstructInPlay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimConstructInPlay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000106 RID: 262
	// (get) Token: 0x060002EB RID: 747 RVA: 0x000230A4 File Offset: 0x000212A4
	// (set) Token: 0x060002EC RID: 748 RVA: 0x00003933 File Offset: 0x00001B33
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimCardAcquire
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardAcquire);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardAcquire), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000107 RID: 263
	// (get) Token: 0x060002ED RID: 749 RVA: 0x000230D4 File Offset: 0x000212D4
	// (set) Token: 0x060002EE RID: 750 RVA: 0x00003952 File Offset: 0x00001B52
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimCardAcquireHero
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardAcquireHero);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardAcquireHero), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000108 RID: 264
	// (get) Token: 0x060002EF RID: 751 RVA: 0x00023104 File Offset: 0x00021304
	// (set) Token: 0x060002F0 RID: 752 RVA: 0x00003971 File Offset: 0x00001B71
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimCardAcquireConstruct
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardAcquireConstruct);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardAcquireConstruct), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000109 RID: 265
	// (get) Token: 0x060002F1 RID: 753 RVA: 0x00023134 File Offset: 0x00021334
	// (set) Token: 0x060002F2 RID: 754 RVA: 0x00003990 File Offset: 0x00001B90
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimCardFateRatKing
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardFateRatKing);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardFateRatKing), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700010A RID: 266
	// (get) Token: 0x060002F3 RID: 755 RVA: 0x00023164 File Offset: 0x00021364
	// (set) Token: 0x060002F4 RID: 756 RVA: 0x000039AF File Offset: 0x00001BAF
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimCardFateNemesis
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardFateNemesis);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimCardFateNemesis), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x060002F5 RID: 757 RVA: 0x00023194 File Offset: 0x00021394
	// (set) Token: 0x060002F6 RID: 758 RVA: 0x000039CE File Offset: 0x00001BCE
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimEventEnlightened
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimEventEnlightened);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimEventEnlightened), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x060002F7 RID: 759 RVA: 0x000231C4 File Offset: 0x000213C4
	// (set) Token: 0x060002F8 RID: 760 RVA: 0x000039ED File Offset: 0x00001BED
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimEventLifebound
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimEventLifebound);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimEventLifebound), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x060002F9 RID: 761 RVA: 0x000231F4 File Offset: 0x000213F4
	// (set) Token: 0x060002FA RID: 762 RVA: 0x00003A0C File Offset: 0x00001C0C
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimEventMechana
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimEventMechana);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimEventMechana), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x060002FB RID: 763 RVA: 0x00023224 File Offset: 0x00021424
	// (set) Token: 0x060002FC RID: 764 RVA: 0x00003A2B File Offset: 0x00001C2B
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimEventVoid
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimEventVoid);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimEventVoid), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x060002FD RID: 765 RVA: 0x00023254 File Offset: 0x00021454
	// (set) Token: 0x060002FE RID: 766 RVA: 0x00003A4A File Offset: 0x00001C4A
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEndAnimEventMonster
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimEventMonster);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEndAnimEventMonster), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000110 RID: 272
	// (get) Token: 0x060002FF RID: 767 RVA: 0x00023284 File Offset: 0x00021484
	// (set) Token: 0x06000300 RID: 768 RVA: 0x00003A69 File Offset: 0x00001C69
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventShuffleDeck
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventShuffleDeck);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventShuffleDeck), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x06000301 RID: 769 RVA: 0x000232B4 File Offset: 0x000214B4
	// (set) Token: 0x06000302 RID: 770 RVA: 0x00003A88 File Offset: 0x00001C88
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventAcquireEnergyShard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventAcquireEnergyShard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventAcquireEnergyShard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000112 RID: 274
	// (get) Token: 0x06000303 RID: 771 RVA: 0x000232E4 File Offset: 0x000214E4
	// (set) Token: 0x06000304 RID: 772 RVA: 0x00003AA7 File Offset: 0x00001CA7
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventAcquireDarkEnergyShard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventAcquireDarkEnergyShard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventAcquireDarkEnergyShard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000113 RID: 275
	// (get) Token: 0x06000305 RID: 773 RVA: 0x00023314 File Offset: 0x00021514
	// (set) Token: 0x06000306 RID: 774 RVA: 0x00003AC6 File Offset: 0x00001CC6
	public unsafe Il2CppReferenceArray<AudioClip> m_AudioDefeatMonster
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_AudioDefeatMonster);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_AudioDefeatMonster), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000114 RID: 276
	// (get) Token: 0x06000307 RID: 775 RVA: 0x00023344 File Offset: 0x00021544
	// (set) Token: 0x06000308 RID: 776 RVA: 0x00003AE5 File Offset: 0x00001CE5
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipDefeatCultist
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipDefeatCultist);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipDefeatCultist), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000115 RID: 277
	// (get) Token: 0x06000309 RID: 777 RVA: 0x00023374 File Offset: 0x00021574
	// (set) Token: 0x0600030A RID: 778 RVA: 0x00003B04 File Offset: 0x00001D04
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipDefeatCultistScream
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipDefeatCultistScream);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipDefeatCultistScream), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000116 RID: 278
	// (get) Token: 0x0600030B RID: 779 RVA: 0x000233A4 File Offset: 0x000215A4
	// (set) Token: 0x0600030C RID: 780 RVA: 0x00003B23 File Offset: 0x00001D23
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipDefeatFanatic
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipDefeatFanatic);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipDefeatFanatic), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x0600030D RID: 781 RVA: 0x000233D4 File Offset: 0x000215D4
	// (set) Token: 0x0600030E RID: 782 RVA: 0x00003B42 File Offset: 0x00001D42
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventTransformedCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventTransformedCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventTransformedCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000118 RID: 280
	// (get) Token: 0x0600030F RID: 783 RVA: 0x00023404 File Offset: 0x00021604
	// (set) Token: 0x06000310 RID: 784 RVA: 0x00003B61 File Offset: 0x00001D61
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventTransformedAdayu
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventTransformedAdayu);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventTransformedAdayu), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x06000311 RID: 785 RVA: 0x00023434 File Offset: 0x00021634
	// (set) Token: 0x06000312 RID: 786 RVA: 0x00003B80 File Offset: 0x00001D80
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventTransformedEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventTransformedEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventTransformedEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x06000313 RID: 787 RVA: 0x00023464 File Offset: 0x00021664
	// (set) Token: 0x06000314 RID: 788 RVA: 0x00003B9F File Offset: 0x00001D9F
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventPlayedDayEffect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventPlayedDayEffect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventPlayedDayEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x06000315 RID: 789 RVA: 0x00023494 File Offset: 0x00021694
	// (set) Token: 0x06000316 RID: 790 RVA: 0x00003BBE File Offset: 0x00001DBE
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventPlayedNightEffect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventPlayedNightEffect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventPlayedNightEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x06000317 RID: 791 RVA: 0x000234C4 File Offset: 0x000216C4
	// (set) Token: 0x06000318 RID: 792 RVA: 0x00003BDD File Offset: 0x00001DDD
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventGainReputation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventGainReputation);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventGainReputation), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x06000319 RID: 793 RVA: 0x000234F4 File Offset: 0x000216F4
	// (set) Token: 0x0600031A RID: 794 RVA: 0x00003BFC File Offset: 0x00001DFC
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventAcquiredChampion
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventAcquiredChampion);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventAcquiredChampion), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x0600031B RID: 795 RVA: 0x00023524 File Offset: 0x00021724
	// (set) Token: 0x0600031C RID: 796 RVA: 0x00003C1B File Offset: 0x00001E1B
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventDefeatedHero
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventDefeatedHero);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventDefeatedHero), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x0600031D RID: 797 RVA: 0x00023554 File Offset: 0x00021754
	// (set) Token: 0x0600031E RID: 798 RVA: 0x00003C3A File Offset: 0x00001E3A
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventAcquiredPortal
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventAcquiredPortal);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventAcquiredPortal), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x0600031F RID: 799 RVA: 0x00023584 File Offset: 0x00021784
	// (set) Token: 0x06000320 RID: 800 RVA: 0x00003C59 File Offset: 0x00001E59
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventRallyAcquire
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventRallyAcquire);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventRallyAcquire), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000121 RID: 289
	// (get) Token: 0x06000321 RID: 801 RVA: 0x000235B4 File Offset: 0x000217B4
	// (set) Token: 0x06000322 RID: 802 RVA: 0x00003C78 File Offset: 0x00001E78
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventRallyDefeat
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventRallyDefeat);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventRallyDefeat), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x06000323 RID: 803 RVA: 0x000235E4 File Offset: 0x000217E4
	// (set) Token: 0x06000324 RID: 804 RVA: 0x00003C97 File Offset: 0x00001E97
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventEnergizedConstruct
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventEnergizedConstruct);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventEnergizedConstruct), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000123 RID: 291
	// (get) Token: 0x06000325 RID: 805 RVA: 0x00023614 File Offset: 0x00021814
	// (set) Token: 0x06000326 RID: 806 RVA: 0x00003CB6 File Offset: 0x00001EB6
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventMovedEnergyCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventMovedEnergyCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventMovedEnergyCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x06000327 RID: 807 RVA: 0x00023644 File Offset: 0x00021844
	// (set) Token: 0x06000328 RID: 808 RVA: 0x00003CD5 File Offset: 0x00001ED5
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventPlayLeprechaun
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventPlayLeprechaun);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventPlayLeprechaun), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x06000329 RID: 809 RVA: 0x00023674 File Offset: 0x00021874
	// (set) Token: 0x0600032A RID: 810 RVA: 0x00003CF4 File Offset: 0x00001EF4
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventAcquireEmpower
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventAcquireEmpower);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventAcquireEmpower), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x0600032B RID: 811 RVA: 0x000236A4 File Offset: 0x000218A4
	// (set) Token: 0x0600032C RID: 812 RVA: 0x00003D13 File Offset: 0x00001F13
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventInfestMonster
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventInfestMonster);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventInfestMonster), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000127 RID: 295
	// (get) Token: 0x0600032D RID: 813 RVA: 0x000236D4 File Offset: 0x000218D4
	// (set) Token: 0x0600032E RID: 814 RVA: 0x00003D32 File Offset: 0x00001F32
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventPlayMonsterFromHand
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventPlayMonsterFromHand);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventPlayMonsterFromHand), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x0600032F RID: 815 RVA: 0x00023704 File Offset: 0x00021904
	// (set) Token: 0x06000330 RID: 816 RVA: 0x00003D51 File Offset: 0x00001F51
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventCellBlockE
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventCellBlockE);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventCellBlockE), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x06000331 RID: 817 RVA: 0x00023734 File Offset: 0x00021934
	// (set) Token: 0x06000332 RID: 818 RVA: 0x00003D70 File Offset: 0x00001F70
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventPrimeDirective
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventPrimeDirective);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventPrimeDirective), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x06000333 RID: 819 RVA: 0x00023764 File Offset: 0x00021964
	// (set) Token: 0x06000334 RID: 820 RVA: 0x00003D8F File Offset: 0x00001F8F
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventThicketFamiliar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventThicketFamiliar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventThicketFamiliar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700012B RID: 299
	// (get) Token: 0x06000335 RID: 821 RVA: 0x00023794 File Offset: 0x00021994
	// (set) Token: 0x06000336 RID: 822 RVA: 0x00003DAE File Offset: 0x00001FAE
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventYukTribeOutcast
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventYukTribeOutcast);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventYukTribeOutcast), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700012C RID: 300
	// (get) Token: 0x06000337 RID: 823 RVA: 0x000237C4 File Offset: 0x000219C4
	// (set) Token: 0x06000338 RID: 824 RVA: 0x00003DCD File Offset: 0x00001FCD
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventGainControlOfNeutralTemple
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventGainControlOfNeutralTemple);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventGainControlOfNeutralTemple), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700012D RID: 301
	// (get) Token: 0x06000339 RID: 825 RVA: 0x000237F4 File Offset: 0x000219F4
	// (set) Token: 0x0600033A RID: 826 RVA: 0x00003DEC File Offset: 0x00001FEC
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventGainControlOfOppTemple
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventGainControlOfOppTemple);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventGainControlOfOppTemple), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x0600033B RID: 827 RVA: 0x00023824 File Offset: 0x00021A24
	// (set) Token: 0x0600033C RID: 828 RVA: 0x00003E0B File Offset: 0x0000200B
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventUseTempleEffect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventUseTempleEffect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventUseTempleEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700012F RID: 303
	// (get) Token: 0x0600033D RID: 829 RVA: 0x00023854 File Offset: 0x00021A54
	// (set) Token: 0x0600033E RID: 830 RVA: 0x00003E2A File Offset: 0x0000202A
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventSerenity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventSerenity);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventSerenity), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000130 RID: 304
	// (get) Token: 0x0600033F RID: 831 RVA: 0x00023884 File Offset: 0x00021A84
	// (set) Token: 0x06000340 RID: 832 RVA: 0x00003E49 File Offset: 0x00002049
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventEcho
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventEcho);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventEcho), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000131 RID: 305
	// (get) Token: 0x06000341 RID: 833 RVA: 0x000238B4 File Offset: 0x00021AB4
	// (set) Token: 0x06000342 RID: 834 RVA: 0x00003E68 File Offset: 0x00002068
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventJubliantMonkCardMatch
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventJubliantMonkCardMatch);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventJubliantMonkCardMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000132 RID: 306
	// (get) Token: 0x06000343 RID: 835 RVA: 0x000238E4 File Offset: 0x00021AE4
	// (set) Token: 0x06000344 RID: 836 RVA: 0x00003E87 File Offset: 0x00002087
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventFistOfTheDragonMonsterDefeat
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventFistOfTheDragonMonsterDefeat);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventFistOfTheDragonMonsterDefeat), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000133 RID: 307
	// (get) Token: 0x06000345 RID: 837 RVA: 0x00023914 File Offset: 0x00021B14
	// (set) Token: 0x06000346 RID: 838 RVA: 0x00003EA6 File Offset: 0x000020A6
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventShuffleSelfBackIntoDeck
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventShuffleSelfBackIntoDeck);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventShuffleSelfBackIntoDeck), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000134 RID: 308
	// (get) Token: 0x06000347 RID: 839 RVA: 0x00023944 File Offset: 0x00021B44
	// (set) Token: 0x06000348 RID: 840 RVA: 0x00003EC5 File Offset: 0x000020C5
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventDiscardEntireDeck
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventDiscardEntireDeck);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventDiscardEntireDeck), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000135 RID: 309
	// (get) Token: 0x06000349 RID: 841 RVA: 0x00023974 File Offset: 0x00021B74
	// (set) Token: 0x0600034A RID: 842 RVA: 0x00003EE4 File Offset: 0x000020E4
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventAlosyanGuide
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventAlosyanGuide);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventAlosyanGuide), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000136 RID: 310
	// (get) Token: 0x0600034B RID: 843 RVA: 0x000239A4 File Offset: 0x00021BA4
	// (set) Token: 0x0600034C RID: 844 RVA: 0x00003F03 File Offset: 0x00002103
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventDeliriumStart
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventDeliriumStart);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventDeliriumStart), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000137 RID: 311
	// (get) Token: 0x0600034D RID: 845 RVA: 0x000239D4 File Offset: 0x00021BD4
	// (set) Token: 0x0600034E RID: 846 RVA: 0x00003F22 File Offset: 0x00002122
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventDeliriumResult
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventDeliriumResult);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventDeliriumResult), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000138 RID: 312
	// (get) Token: 0x0600034F RID: 847 RVA: 0x00023A04 File Offset: 0x00021C04
	// (set) Token: 0x06000350 RID: 848 RVA: 0x00003F41 File Offset: 0x00002141
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventRecur
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventRecur);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventRecur), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000139 RID: 313
	// (get) Token: 0x06000351 RID: 849 RVA: 0x00023A34 File Offset: 0x00021C34
	// (set) Token: 0x06000352 RID: 850 RVA: 0x00003F60 File Offset: 0x00002160
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipEventInsightAuction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventInsightAuction);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipEventInsightAuction), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700013A RID: 314
	// (get) Token: 0x06000353 RID: 851 RVA: 0x00023A64 File Offset: 0x00021C64
	// (set) Token: 0x06000354 RID: 852 RVA: 0x00003F7F File Offset: 0x0000217F
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipTrayOpen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipTrayOpen);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipTrayOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700013B RID: 315
	// (get) Token: 0x06000355 RID: 853 RVA: 0x00023A94 File Offset: 0x00021C94
	// (set) Token: 0x06000356 RID: 854 RVA: 0x00003F9E File Offset: 0x0000219E
	public unsafe Il2CppReferenceArray<AudioClip> m_ClipTrayClose
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipTrayClose);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAudioHandlerIngame.NativeFieldInfoPtr_m_ClipTrayClose), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000192 RID: 402
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimationManager;

	// Token: 0x04000193 RID: 403
	private static readonly IntPtr NativeFieldInfoPtr_m_CardManager;

	// Token: 0x04000194 RID: 404
	private static readonly IntPtr NativeFieldInfoPtr_m_DragManager;

	// Token: 0x04000195 RID: 405
	private static readonly IntPtr NativeFieldInfoPtr_m_AudioSource;

	// Token: 0x04000196 RID: 406
	private static readonly IntPtr NativeFieldInfoPtr_m_DragAudioSource;

	// Token: 0x04000197 RID: 407
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipActionConfirm;

	// Token: 0x04000198 RID: 408
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipActionBack;

	// Token: 0x04000199 RID: 409
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipActionSelect;

	// Token: 0x0400019A RID: 410
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipActionEndTurn;

	// Token: 0x0400019B RID: 411
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipActionTakeCard;

	// Token: 0x0400019C RID: 412
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipActionActivateCard;

	// Token: 0x0400019D RID: 413
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipActionBanishCard;

	// Token: 0x0400019E RID: 414
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimResourceRune;

	// Token: 0x0400019F RID: 415
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimResourceRuneMechana;

	// Token: 0x040001A0 RID: 416
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimResourcePower;

	// Token: 0x040001A1 RID: 417
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimResourceHonor;

	// Token: 0x040001A2 RID: 418
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimResourceEnergy;

	// Token: 0x040001A3 RID: 419
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimResourceInsight;

	// Token: 0x040001A4 RID: 420
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimResourceTempleLife;

	// Token: 0x040001A5 RID: 421
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimResourceTempleDeath;

	// Token: 0x040001A6 RID: 422
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipStartAnimCardDeck;

	// Token: 0x040001A7 RID: 423
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipStartAnimCardSlide;

	// Token: 0x040001A8 RID: 424
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipStartAnimCardFate;

	// Token: 0x040001A9 RID: 425
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipStartCardDrag;

	// Token: 0x040001AA RID: 426
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipUpdateCardDrag;

	// Token: 0x040001AB RID: 427
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimCenterRow;

	// Token: 0x040001AC RID: 428
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimPlayedArea;

	// Token: 0x040001AD RID: 429
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimCardConstruct;

	// Token: 0x040001AE RID: 430
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimCardConstructDreamersGlass;

	// Token: 0x040001AF RID: 431
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimConstructInPlay;

	// Token: 0x040001B0 RID: 432
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimCardAcquire;

	// Token: 0x040001B1 RID: 433
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimCardAcquireHero;

	// Token: 0x040001B2 RID: 434
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimCardAcquireConstruct;

	// Token: 0x040001B3 RID: 435
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimCardFateRatKing;

	// Token: 0x040001B4 RID: 436
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimCardFateNemesis;

	// Token: 0x040001B5 RID: 437
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimEventEnlightened;

	// Token: 0x040001B6 RID: 438
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimEventLifebound;

	// Token: 0x040001B7 RID: 439
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimEventMechana;

	// Token: 0x040001B8 RID: 440
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimEventVoid;

	// Token: 0x040001B9 RID: 441
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEndAnimEventMonster;

	// Token: 0x040001BA RID: 442
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventShuffleDeck;

	// Token: 0x040001BB RID: 443
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventAcquireEnergyShard;

	// Token: 0x040001BC RID: 444
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventAcquireDarkEnergyShard;

	// Token: 0x040001BD RID: 445
	private static readonly IntPtr NativeFieldInfoPtr_m_AudioDefeatMonster;

	// Token: 0x040001BE RID: 446
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipDefeatCultist;

	// Token: 0x040001BF RID: 447
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipDefeatCultistScream;

	// Token: 0x040001C0 RID: 448
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipDefeatFanatic;

	// Token: 0x040001C1 RID: 449
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventTransformedCard;

	// Token: 0x040001C2 RID: 450
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventTransformedAdayu;

	// Token: 0x040001C3 RID: 451
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventTransformedEvent;

	// Token: 0x040001C4 RID: 452
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventPlayedDayEffect;

	// Token: 0x040001C5 RID: 453
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventPlayedNightEffect;

	// Token: 0x040001C6 RID: 454
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventGainReputation;

	// Token: 0x040001C7 RID: 455
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventAcquiredChampion;

	// Token: 0x040001C8 RID: 456
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventDefeatedHero;

	// Token: 0x040001C9 RID: 457
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventAcquiredPortal;

	// Token: 0x040001CA RID: 458
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventRallyAcquire;

	// Token: 0x040001CB RID: 459
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventRallyDefeat;

	// Token: 0x040001CC RID: 460
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventEnergizedConstruct;

	// Token: 0x040001CD RID: 461
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventMovedEnergyCard;

	// Token: 0x040001CE RID: 462
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventPlayLeprechaun;

	// Token: 0x040001CF RID: 463
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventAcquireEmpower;

	// Token: 0x040001D0 RID: 464
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventInfestMonster;

	// Token: 0x040001D1 RID: 465
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventPlayMonsterFromHand;

	// Token: 0x040001D2 RID: 466
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventCellBlockE;

	// Token: 0x040001D3 RID: 467
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventPrimeDirective;

	// Token: 0x040001D4 RID: 468
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventThicketFamiliar;

	// Token: 0x040001D5 RID: 469
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventYukTribeOutcast;

	// Token: 0x040001D6 RID: 470
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventGainControlOfNeutralTemple;

	// Token: 0x040001D7 RID: 471
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventGainControlOfOppTemple;

	// Token: 0x040001D8 RID: 472
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventUseTempleEffect;

	// Token: 0x040001D9 RID: 473
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventSerenity;

	// Token: 0x040001DA RID: 474
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventEcho;

	// Token: 0x040001DB RID: 475
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventJubliantMonkCardMatch;

	// Token: 0x040001DC RID: 476
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventFistOfTheDragonMonsterDefeat;

	// Token: 0x040001DD RID: 477
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventShuffleSelfBackIntoDeck;

	// Token: 0x040001DE RID: 478
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventDiscardEntireDeck;

	// Token: 0x040001DF RID: 479
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventAlosyanGuide;

	// Token: 0x040001E0 RID: 480
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventDeliriumStart;

	// Token: 0x040001E1 RID: 481
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventDeliriumResult;

	// Token: 0x040001E2 RID: 482
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventRecur;

	// Token: 0x040001E3 RID: 483
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipEventInsightAuction;

	// Token: 0x040001E4 RID: 484
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipTrayOpen;

	// Token: 0x040001E5 RID: 485
	private static readonly IntPtr NativeFieldInfoPtr_m_ClipTrayClose;

	// Token: 0x040001E6 RID: 486
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040001E7 RID: 487
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040001E8 RID: 488
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x040001E9 RID: 489
	private static readonly IntPtr NativeMethodInfoPtr_RegisterEventHandlers_Public_Void_GameEventBuffer_0;

	// Token: 0x040001EA RID: 490
	private static readonly IntPtr NativeMethodInfoPtr_RegisterMagnifyManager_Public_Void_AscensionMagnifyManager_0;

	// Token: 0x040001EB RID: 491
	private static readonly IntPtr NativeMethodInfoPtr_PlayDeliriumDieAudio_Public_Void_Int32_0;

	// Token: 0x040001EC RID: 492
	private static readonly IntPtr NativeMethodInfoPtr_PlayAudioActionSelect_Public_Void_0;

	// Token: 0x040001ED RID: 493
	private static readonly IntPtr NativeMethodInfoPtr_PlayAudioTrayOpen_Public_Void_0;

	// Token: 0x040001EE RID: 494
	private static readonly IntPtr NativeMethodInfoPtr_PlayAudioTrayClose_Public_Void_0;

	// Token: 0x040001EF RID: 495
	private static readonly IntPtr NativeMethodInfoPtr_PlayRandomSoundFromList_Private_Void_Il2CppReferenceArray_1_AudioClip_0;

	// Token: 0x040001F0 RID: 496
	private static readonly IntPtr NativeMethodInfoPtr_PlaySoundFromList_Private_Void_Il2CppReferenceArray_1_AudioClip_Int32_0;

	// Token: 0x040001F1 RID: 497
	private static readonly IntPtr NativeMethodInfoPtr_HandleBeginAnimation_Private_Void_AnimateObject_UInt32_Int32_Int32_Int32_Int32_0;

	// Token: 0x040001F2 RID: 498
	private static readonly IntPtr NativeMethodInfoPtr_HandleEndAnimation_Private_Void_AnimateObject_UInt32_Int32_Int32_Int32_Int32_0;

	// Token: 0x040001F3 RID: 499
	private static readonly IntPtr NativeMethodInfoPtr_HandleBeginDrag_Public_Void_DragObject_0;

	// Token: 0x040001F4 RID: 500
	private static readonly IntPtr NativeMethodInfoPtr_HandleUpdateDrag_Public_Void_DragObject_0;

	// Token: 0x040001F5 RID: 501
	private static readonly IntPtr NativeMethodInfoPtr_HandleBeginMagnifyCard_Private_Void_CardObject_0;

	// Token: 0x040001F6 RID: 502
	private static readonly IntPtr NativeMethodInfoPtr_HandleEndMagnifyCard_Private_Void_CardObject_0;

	// Token: 0x040001F7 RID: 503
	private static readonly IntPtr NativeMethodInfoPtr_HandlePlayerSelectedOption_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040001F8 RID: 504
	private static readonly IntPtr NativeMethodInfoPtr_HandleResetPlayerDiscardPile_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040001F9 RID: 505
	private static readonly IntPtr NativeMethodInfoPtr_HandleDefeatMonster_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040001FA RID: 506
	private static readonly IntPtr NativeMethodInfoPtr_HandleAcquireCard_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040001FB RID: 507
	private static readonly IntPtr NativeMethodInfoPtr_HandleActionEvent_Private_Void_IntPtr_GameEventFeedback_0;

	// Token: 0x040001FC RID: 508
	private static readonly IntPtr NativeMethodInfoPtr_PlayTransformCardSound_Public_Void_AscensionCard_0;

	// Token: 0x040001FD RID: 509
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

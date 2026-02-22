using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000018 RID: 24
public class AscensionCard : CardObject
{
	// Token: 0x06000357 RID: 855 RVA: 0x00023AC4 File Offset: 0x00021CC4
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionCard()
	{
		Il2CppClassPointerStore<AscensionCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionCard");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr);
		AscensionCard.NativeFieldInfoPtr_m_CardFrontFullCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardFrontFullCard");
		AscensionCard.NativeFieldInfoPtr_m_CardFrontHalfCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardFrontHalfCard");
		AscensionCard.NativeFieldInfoPtr_m_CardFrontChampionHorizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardFrontChampionHorizontal");
		AscensionCard.NativeFieldInfoPtr_m_CardBackFullCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardBackFullCard");
		AscensionCard.NativeFieldInfoPtr_m_CardBackHalfCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardBackHalfCard");
		AscensionCard.NativeFieldInfoPtr_m_CardGlowFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardGlowFull");
		AscensionCard.NativeFieldInfoPtr_m_CardGlowHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardGlowHalf");
		AscensionCard.NativeFieldInfoPtr_m_CardBackRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardBackRotation");
		AscensionCard.NativeFieldInfoPtr_m_CardFrontParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardFrontParent");
		AscensionCard.NativeFieldInfoPtr_m_LayoutCardFullFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_LayoutCardFullFront");
		AscensionCard.NativeFieldInfoPtr_m_LayoutCardHalfFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_LayoutCardHalfFront");
		AscensionCard.NativeFieldInfoPtr_m_LayoutCardChampionHorizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_LayoutCardChampionHorizontal");
		AscensionCard.NativeFieldInfoPtr_m_ResourceCardImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_ResourceCardImage");
		AscensionCard.NativeFieldInfoPtr_m_bDontShowCardFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_bDontShowCardFront");
		AscensionCard.NativeFieldInfoPtr_m_bDesireShowCardBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_bDesireShowCardBack");
		AscensionCard.NativeFieldInfoPtr_m_bDesireShowCardBackImmediate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_bDesireShowCardBackImmediate");
		AscensionCard.NativeFieldInfoPtr_m_ActiveDisplayState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_ActiveDisplayState");
		AscensionCard.NativeFieldInfoPtr_m_bShowingCardBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_bShowingCardBack");
		AscensionCard.NativeFieldInfoPtr_m_CardBackTargetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardBackTargetRotation");
		AscensionCard.NativeFieldInfoPtr_m_bGlowActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_bGlowActive");
		AscensionCard.NativeFieldInfoPtr_m_bOverrideGlowColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_bOverrideGlowColor");
		AscensionCard.NativeFieldInfoPtr_m_GlowColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_GlowColor");
		AscensionCard.NativeFieldInfoPtr_m_ActiveCardFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_ActiveCardFront");
		AscensionCard.NativeFieldInfoPtr_m_ActiveCardBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_ActiveCardBack");
		AscensionCard.NativeFieldInfoPtr_m_ActiveGlowDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_ActiveGlowDisplay");
		AscensionCard.NativeFieldInfoPtr_m_DisplayCardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_DisplayCardCount");
		AscensionCard.NativeFieldInfoPtr_m_CurrentCardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CurrentCardCount");
		AscensionCard.NativeFieldInfoPtr_m_bMatchWidthOnActiveDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_bMatchWidthOnActiveDisplay");
		AscensionCard.NativeFieldInfoPtr_m_bMatchHeightOnActiveDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_bMatchHeightOnActiveDisplay");
		AscensionCard.NativeFieldInfoPtr_m_OverridePointerClickCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_OverridePointerClickCallback");
		AscensionCard.NativeFieldInfoPtr_m_DragType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_DragType");
		AscensionCard.NativeFieldInfoPtr_m_bCurrentlyDragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_bCurrentlyDragging");
		AscensionCard.NativeFieldInfoPtr_m_CardName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardName");
		AscensionCard.NativeFieldInfoPtr_m_CardHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardHash");
		AscensionCard.NativeFieldInfoPtr_m_CardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardType");
		AscensionCard.NativeFieldInfoPtr_m_CardFactionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardFactionFlags");
		AscensionCard.NativeFieldInfoPtr_m_CardHonorValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardHonorValue");
		AscensionCard.NativeFieldInfoPtr_m_CardRuneCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardRuneCost");
		AscensionCard.NativeFieldInfoPtr_m_CardDisplayRuneCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardDisplayRuneCost");
		AscensionCard.NativeFieldInfoPtr_m_CardPowerCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardPowerCost");
		AscensionCard.NativeFieldInfoPtr_m_CardDisplayPowerCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardDisplayPowerCost");
		AscensionCard.NativeFieldInfoPtr_m_CardInsightCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardInsightCost");
		AscensionCard.NativeFieldInfoPtr_m_CardDisplayInsightCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_CardDisplayInsightCost");
		AscensionCard.NativeFieldInfoPtr_m_DisplayedFactionEmblems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_DisplayedFactionEmblems");
		AscensionCard.NativeFieldInfoPtr_m_DisplayedEnergizeBoxGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_DisplayedEnergizeBoxGlow");
		AscensionCard.NativeFieldInfoPtr_m_DisplayedDayEffectGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_DisplayedDayEffectGlow");
		AscensionCard.NativeFieldInfoPtr_m_DisplayedNightEffectGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_DisplayedNightEffectGlow");
		AscensionCard.NativeFieldInfoPtr_m_bDoNotPutInVoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_bDoNotPutInVoid");
		AscensionCard.NativeFieldInfoPtr_m_bPreserveDisplayState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_bPreserveDisplayState");
		AscensionCard.NativeFieldInfoPtr_m_bLivesInUniqueCardZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "m_bLivesInUniqueCardZone");
		AscensionCard.NativeMethodInfoPtr_IsShowingCardBack_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663492);
		AscensionCard.NativeMethodInfoPtr_SetPreserveDisplayState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663493);
		AscensionCard.NativeMethodInfoPtr_GetCardName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663494);
		AscensionCard.NativeMethodInfoPtr_SetCardName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663495);
		AscensionCard.NativeMethodInfoPtr_GetCardHash_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663496);
		AscensionCard.NativeMethodInfoPtr_SetCardHash_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663497);
		AscensionCard.NativeMethodInfoPtr_GetCardType_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663498);
		AscensionCard.NativeMethodInfoPtr_GetCardFactionFlags_Public_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663499);
		AscensionCard.NativeMethodInfoPtr_SetCardType_Public_Void_Int32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663500);
		AscensionCard.NativeMethodInfoPtr_GetCardHonorValue_Public_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663501);
		AscensionCard.NativeMethodInfoPtr_DoNotPutInVoid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663502);
		AscensionCard.NativeMethodInfoPtr_SetDoNotPutInVoid_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663503);
		AscensionCard.NativeMethodInfoPtr_LivesInUniqueCardZone_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663504);
		AscensionCard.NativeMethodInfoPtr_SetLivesInUniqueCardZone_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663505);
		AscensionCard.NativeMethodInfoPtr_AddOverridePointerClickCallback_Public_Void_OnPointerClickCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663506);
		AscensionCard.NativeMethodInfoPtr_RemoveOverridePointerClickCallback_Public_Void_OnPointerClickCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663507);
		AscensionCard.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663508);
		AscensionCard.NativeMethodInfoPtr_CreateFromPrefab_Public_Static_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663509);
		AscensionCard.NativeMethodInfoPtr_MergeCardFrontFullFromPrefab_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663510);
		AscensionCard.NativeMethodInfoPtr_MergeCardFrontHalfFromPrefab_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663511);
		AscensionCard.NativeMethodInfoPtr_MergeCardFrontChampionHorizontalFromPrefab_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663512);
		AscensionCard.NativeMethodInfoPtr_MergeCardBackFromPrefab_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663513);
		AscensionCard.NativeMethodInfoPtr_MergeCardBackHalfFromPrefab_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663514);
		AscensionCard.NativeMethodInfoPtr_MergeGoldBorderFromPrefab_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663515);
		AscensionCard.NativeMethodInfoPtr_MergeGoldBorderHalfFromPrefab_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663516);
		AscensionCard.NativeMethodInfoPtr_MergeCardGlowFullFromPrefab_Public_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663517);
		AscensionCard.NativeMethodInfoPtr_MergeCardGlowHalfFromPrefab_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663518);
		AscensionCard.NativeMethodInfoPtr_HasLoadCompleted_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663519);
		AscensionCard.NativeMethodInfoPtr_AddOnLoadCompletedCallback_Public_Void_ResourceLoadCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663520);
		AscensionCard.NativeMethodInfoPtr_SetDontShowCardFront_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663521);
		AscensionCard.NativeMethodInfoPtr_SetCardImage_Public_Void_ResourceEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663522);
		AscensionCard.NativeMethodInfoPtr_HandleCardImageLoadCompleted_Private_Void_ResourceEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663523);
		AscensionCard.NativeMethodInfoPtr_RemoveCardImage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663524);
		AscensionCard.NativeMethodInfoPtr_SetCardFrameTop_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663525);
		AscensionCard.NativeMethodInfoPtr_SetCardFrameBottom_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663526);
		AscensionCard.NativeMethodInfoPtr_SetCardTitle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663527);
		AscensionCard.NativeMethodInfoPtr_SetCardTypeText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663528);
		AscensionCard.NativeMethodInfoPtr_SetCardRuneCost_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663529);
		AscensionCard.NativeMethodInfoPtr_SetCardDisplayRuneCost_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663530);
		AscensionCard.NativeMethodInfoPtr_ResetCardDisplayRuneCost_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663531);
		AscensionCard.NativeMethodInfoPtr_SetCardPowerCost_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663532);
		AscensionCard.NativeMethodInfoPtr_SetCardDisplayPowerCost_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663533);
		AscensionCard.NativeMethodInfoPtr_ResetCardDisplayPowerCost_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663534);
		AscensionCard.NativeMethodInfoPtr_SetCardDisplayFactionEmblems_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663535);
		AscensionCard.NativeMethodInfoPtr_ResetCardDisplayFactionEmblems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663536);
		AscensionCard.NativeMethodInfoPtr_SetCardDisplayEnergizeBoxGlow_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663537);
		AscensionCard.NativeMethodInfoPtr_SetCardDisplayDayEffectGlow_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663538);
		AscensionCard.NativeMethodInfoPtr_SetCardDisplayNightEffectGlow_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663539);
		AscensionCard.NativeMethodInfoPtr_SetCardInsightCost_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663540);
		AscensionCard.NativeMethodInfoPtr_SetCardDisplayInsightCost_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663541);
		AscensionCard.NativeMethodInfoPtr_ResetCardDisplayInsightCost_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663542);
		AscensionCard.NativeMethodInfoPtr_SetCardHonorValue_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663543);
		AscensionCard.NativeMethodInfoPtr_SetCardTextEffect_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663544);
		AscensionCard.NativeMethodInfoPtr_SetCardTextFateEffect_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663545);
		AscensionCard.NativeMethodInfoPtr_SetCardTextEnergizeEffect_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663546);
		AscensionCard.NativeMethodInfoPtr_SetCardTextTrophyEffect_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663547);
		AscensionCard.NativeMethodInfoPtr_SetCardTextDayEffect_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663548);
		AscensionCard.NativeMethodInfoPtr_SetCardTextNightEffect_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663549);
		AscensionCard.NativeMethodInfoPtr_SetCardTextSetPlusRarityIndicator_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663550);
		AscensionCard.NativeMethodInfoPtr_SetCardTextFlavor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663551);
		AscensionCard.NativeMethodInfoPtr_SetCardCount_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663552);
		AscensionCard.NativeMethodInfoPtr_SetupCallbacks_Public_Virtual_Void_CardManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663553);
		AscensionCard.NativeMethodInfoPtr_SetActiveGlow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663554);
		AscensionCard.NativeMethodInfoPtr_SetGlowOverride_Public_Void_Boolean_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663555);
		AscensionCard.NativeMethodInfoPtr_SetPlayedGlow_Public_Void_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663556);
		AscensionCard.NativeMethodInfoPtr_SetSelectable_Public_Virtual_Void_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663557);
		AscensionCard.NativeMethodInfoPtr_BeginAnimationCallback_Private_Void_AnimateObject_AnimationLocator_AnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663558);
		AscensionCard.NativeMethodInfoPtr_EndAnimationCallback_Private_Void_AnimateObject_AnimationLocator_AnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663559);
		AscensionCard.NativeMethodInfoPtr_IsCurrentlyDragging_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663560);
		AscensionCard.NativeMethodInfoPtr_SetDragType_Public_Void_ECardDragType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663561);
		AscensionCard.NativeMethodInfoPtr_BeginDragCallback_Private_Void_DragObject_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663562);
		AscensionCard.NativeMethodInfoPtr_EndDragCallback_Private_Void_DragObject_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663563);
		AscensionCard.NativeMethodInfoPtr_DragHintCallback_Private_Void_DragObject_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663564);
		AscensionCard.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663565);
		AscensionCard.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663566);
		AscensionCard.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663567);
		AscensionCard.NativeMethodInfoPtr_SetTargetScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663568);
		AscensionCard.NativeMethodInfoPtr_UpdateCard_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663569);
		AscensionCard.NativeMethodInfoPtr_GetCardDisplay_Private_GameObject_ECardDisplayState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663570);
		AscensionCard.NativeMethodInfoPtr_SetActiveDisplay_Private_Void_GameObject_GameObject_GameObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663571);
		AscensionCard.NativeMethodInfoPtr_ShowFullCard_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663572);
		AscensionCard.NativeMethodInfoPtr_ShowHalfCard_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663573);
		AscensionCard.NativeMethodInfoPtr_SetCardDisplayState_Private_Void_ECardDisplayState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663574);
		AscensionCard.NativeMethodInfoPtr_DisplayCardBack_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663575);
		AscensionCard.NativeMethodInfoPtr_CanMagnify_Public_Virtual_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663576);
		AscensionCard.NativeMethodInfoPtr_CustomSortAscensionCards_Public_Static_Int32_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663577);
		AscensionCard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, 100663578);
	}

	// Token: 0x06000358 RID: 856 RVA: 0x000245A8 File Offset: 0x000227A8
	[CallerCount(0)]
	public unsafe bool IsShowingCardBack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_IsShowingCardBack_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000359 RID: 857 RVA: 0x000245E4 File Offset: 0x000227E4
	[CallerCount(0)]
	public unsafe void SetPreserveDisplayState(bool bPreserveState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bPreserveState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetPreserveDisplayState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600035A RID: 858 RVA: 0x00024624 File Offset: 0x00022824
	[CallerCount(0)]
	public unsafe string GetCardName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_GetCardName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x0600035B RID: 859 RVA: 0x0002465C File Offset: 0x0002285C
	[CallerCount(0)]
	public unsafe void SetCardName(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600035C RID: 860 RVA: 0x000246A0 File Offset: 0x000228A0
	[CallerCount(0)]
	public unsafe int GetCardHash()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_GetCardHash_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600035D RID: 861 RVA: 0x000246DC File Offset: 0x000228DC
	[CallerCount(0)]
	public unsafe void SetCardHash(int hash)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref hash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardHash_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600035E RID: 862 RVA: 0x0002471C File Offset: 0x0002291C
	[CallerCount(0)]
	public unsafe int GetCardType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_GetCardType_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600035F RID: 863 RVA: 0x00024758 File Offset: 0x00022958
	[CallerCount(0)]
	public unsafe ushort GetCardFactionFlags()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_GetCardFactionFlags_Public_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000360 RID: 864 RVA: 0x00024794 File Offset: 0x00022994
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226449, XrefRangeEnd = 226457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardType(int cardType, ushort cardFactionFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref cardType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardFactionFlags;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardType_Public_Void_Int32_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000361 RID: 865 RVA: 0x000247E0 File Offset: 0x000229E0
	[CallerCount(0)]
	public unsafe short GetCardHonorValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_GetCardHonorValue_Public_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000362 RID: 866 RVA: 0x0002481C File Offset: 0x00022A1C
	[CallerCount(0)]
	public unsafe bool DoNotPutInVoid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_DoNotPutInVoid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000363 RID: 867 RVA: 0x00024858 File Offset: 0x00022A58
	[CallerCount(0)]
	public unsafe void SetDoNotPutInVoid(bool bDoNotPutInVoid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bDoNotPutInVoid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetDoNotPutInVoid_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000364 RID: 868 RVA: 0x00024898 File Offset: 0x00022A98
	[CallerCount(0)]
	public unsafe bool LivesInUniqueCardZone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_LivesInUniqueCardZone_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000365 RID: 869 RVA: 0x000248D4 File Offset: 0x00022AD4
	[CallerCount(0)]
	public unsafe void SetLivesInUniqueCardZone(bool bLivesInUniqueCardZone)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bLivesInUniqueCardZone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetLivesInUniqueCardZone_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000366 RID: 870 RVA: 0x00024914 File Offset: 0x00022B14
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 226460, RefRangeEnd = 226461, XrefRangeStart = 226457, XrefRangeEnd = 226460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOverridePointerClickCallback(AscensionCard.OnPointerClickCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_AddOverridePointerClickCallback_Public_Void_OnPointerClickCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000367 RID: 871 RVA: 0x00024958 File Offset: 0x00022B58
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 226464, RefRangeEnd = 226466, XrefRangeStart = 226461, XrefRangeEnd = 226464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOverridePointerClickCallback(AscensionCard.OnPointerClickCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_RemoveOverridePointerClickCallback_Public_Void_OnPointerClickCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000368 RID: 872 RVA: 0x0002499C File Offset: 0x00022B9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226466, XrefRangeEnd = 226467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000369 RID: 873 RVA: 0x000249D0 File Offset: 0x00022BD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226467, XrefRangeEnd = 226487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject CreateFromPrefab(GameObject cardPrefab)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardPrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_CreateFromPrefab_Public_Static_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}
	}

	// Token: 0x0600036A RID: 874 RVA: 0x00024A14 File Offset: 0x00022C14
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 226515, RefRangeEnd = 226516, XrefRangeStart = 226487, XrefRangeEnd = 226515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MergeCardFrontFullFromPrefab(GameObject cardFrontFullPrefab)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardFrontFullPrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_MergeCardFrontFullFromPrefab_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600036B RID: 875 RVA: 0x00024A58 File Offset: 0x00022C58
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 226544, RefRangeEnd = 226545, XrefRangeStart = 226516, XrefRangeEnd = 226544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MergeCardFrontHalfFromPrefab(GameObject cardFrontHalfPrefab)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardFrontHalfPrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_MergeCardFrontHalfFromPrefab_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600036C RID: 876 RVA: 0x00024A9C File Offset: 0x00022C9C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 226575, RefRangeEnd = 226576, XrefRangeStart = 226545, XrefRangeEnd = 226575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MergeCardFrontChampionHorizontalFromPrefab(GameObject cardFrontChampionHorizontalPrefab)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardFrontChampionHorizontalPrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_MergeCardFrontChampionHorizontalFromPrefab_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600036D RID: 877 RVA: 0x00024AE0 File Offset: 0x00022CE0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 226598, RefRangeEnd = 226599, XrefRangeStart = 226576, XrefRangeEnd = 226598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MergeCardBackFromPrefab(GameObject cardBackPrefab)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardBackPrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_MergeCardBackFromPrefab_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600036E RID: 878 RVA: 0x00024B24 File Offset: 0x00022D24
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 226621, RefRangeEnd = 226622, XrefRangeStart = 226599, XrefRangeEnd = 226621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MergeCardBackHalfFromPrefab(GameObject cardBackHalfPrefab)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardBackHalfPrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_MergeCardBackHalfFromPrefab_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600036F RID: 879 RVA: 0x00024B68 File Offset: 0x00022D68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226622, XrefRangeEnd = 226637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MergeGoldBorderFromPrefab(GameObject cardBorderPrefab)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardBorderPrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_MergeGoldBorderFromPrefab_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000370 RID: 880 RVA: 0x00024BAC File Offset: 0x00022DAC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226637, XrefRangeEnd = 226652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MergeGoldBorderHalfFromPrefab(GameObject cardBorderPrefab)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardBorderPrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_MergeGoldBorderHalfFromPrefab_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000371 RID: 881 RVA: 0x00024BF0 File Offset: 0x00022DF0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 226683, RefRangeEnd = 226684, XrefRangeStart = 226652, XrefRangeEnd = 226683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MergeCardGlowFullFromPrefab(GameObject glowPrefab, bool useHorizontalOrientation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(glowPrefab);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useHorizontalOrientation;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_MergeCardGlowFullFromPrefab_Public_Void_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000372 RID: 882 RVA: 0x00024C40 File Offset: 0x00022E40
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 226712, RefRangeEnd = 226713, XrefRangeStart = 226684, XrefRangeEnd = 226712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MergeCardGlowHalfFromPrefab(GameObject glowPrefab)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(glowPrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_MergeCardGlowHalfFromPrefab_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000373 RID: 883 RVA: 0x00024C84 File Offset: 0x00022E84
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 226713, RefRangeEnd = 226715, XrefRangeStart = 226713, XrefRangeEnd = 226713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasLoadCompleted()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_HasLoadCompleted_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000374 RID: 884 RVA: 0x00024CC0 File Offset: 0x00022EC0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 226716, RefRangeEnd = 226717, XrefRangeStart = 226715, XrefRangeEnd = 226716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnLoadCompletedCallback(ResourceEntry.ResourceLoadCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_AddOnLoadCompletedCallback_Public_Void_ResourceLoadCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000375 RID: 885 RVA: 0x00024D04 File Offset: 0x00022F04
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 226726, RefRangeEnd = 226728, XrefRangeStart = 226717, XrefRangeEnd = 226726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDontShowCardFront(bool bDontShowCardFront)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bDontShowCardFront;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetDontShowCardFront_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000376 RID: 886 RVA: 0x00024D44 File Offset: 0x00022F44
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226728, XrefRangeEnd = 226738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardImage(ResourceEntry resourceCardImage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceCardImage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardImage_Public_Void_ResourceEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000377 RID: 887 RVA: 0x00024D88 File Offset: 0x00022F88
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 226761, RefRangeEnd = 226763, XrefRangeStart = 226738, XrefRangeEnd = 226761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleCardImageLoadCompleted(ResourceEntry resourceEntry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceEntry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_HandleCardImageLoadCompleted_Private_Void_ResourceEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000378 RID: 888 RVA: 0x00024DCC File Offset: 0x00022FCC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 226775, RefRangeEnd = 226778, XrefRangeStart = 226763, XrefRangeEnd = 226775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveCardImage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_RemoveCardImage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000379 RID: 889 RVA: 0x00024E00 File Offset: 0x00023000
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226778, XrefRangeEnd = 226787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardFrameTop(Sprite sprite_frame_top)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite_frame_top);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardFrameTop_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600037A RID: 890 RVA: 0x00024E44 File Offset: 0x00023044
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226787, XrefRangeEnd = 226796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardFrameBottom(Sprite sprite_frame_bottom)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite_frame_bottom);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardFrameBottom_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600037B RID: 891 RVA: 0x00024E88 File Offset: 0x00023088
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226796, XrefRangeEnd = 226805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTitle(string card_title)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_title);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardTitle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600037C RID: 892 RVA: 0x00024ECC File Offset: 0x000230CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226805, XrefRangeEnd = 226814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTypeText(string card_type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardTypeText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600037D RID: 893 RVA: 0x00024F10 File Offset: 0x00023110
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226814, XrefRangeEnd = 226825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardRuneCost(short card_rune_cost)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref card_rune_cost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardRuneCost_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600037E RID: 894 RVA: 0x00024F50 File Offset: 0x00023150
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 226836, RefRangeEnd = 226842, XrefRangeStart = 226825, XrefRangeEnd = 226836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardDisplayRuneCost(short card_rune_cost)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref card_rune_cost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardDisplayRuneCost_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600037F RID: 895 RVA: 0x00024F90 File Offset: 0x00023190
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226842, XrefRangeEnd = 226843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetCardDisplayRuneCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_ResetCardDisplayRuneCost_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000380 RID: 896 RVA: 0x00024FC4 File Offset: 0x000231C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226843, XrefRangeEnd = 226854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardPowerCost(short card_power_cost)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref card_power_cost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardPowerCost_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000381 RID: 897 RVA: 0x00025004 File Offset: 0x00023204
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 226865, RefRangeEnd = 226871, XrefRangeStart = 226854, XrefRangeEnd = 226865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardDisplayPowerCost(short card_power_cost)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref card_power_cost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardDisplayPowerCost_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000382 RID: 898 RVA: 0x00025044 File Offset: 0x00023244
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226871, XrefRangeEnd = 226872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetCardDisplayPowerCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_ResetCardDisplayPowerCost_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000383 RID: 899 RVA: 0x00025078 File Offset: 0x00023278
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 226881, RefRangeEnd = 226888, XrefRangeStart = 226872, XrefRangeEnd = 226881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardDisplayFactionEmblems(uint faction_flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref faction_flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardDisplayFactionEmblems_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000384 RID: 900 RVA: 0x000250B8 File Offset: 0x000232B8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 226897, RefRangeEnd = 226899, XrefRangeStart = 226888, XrefRangeEnd = 226897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetCardDisplayFactionEmblems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_ResetCardDisplayFactionEmblems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000385 RID: 901 RVA: 0x000250EC File Offset: 0x000232EC
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 226908, RefRangeEnd = 226915, XrefRangeStart = 226899, XrefRangeEnd = 226908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardDisplayEnergizeBoxGlow(bool bVisible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardDisplayEnergizeBoxGlow_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000386 RID: 902 RVA: 0x0002512C File Offset: 0x0002332C
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 226924, RefRangeEnd = 226931, XrefRangeStart = 226915, XrefRangeEnd = 226924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardDisplayDayEffectGlow(bool bVisible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardDisplayDayEffectGlow_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000387 RID: 903 RVA: 0x0002516C File Offset: 0x0002336C
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 226940, RefRangeEnd = 226947, XrefRangeStart = 226931, XrefRangeEnd = 226940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardDisplayNightEffectGlow(bool bVisible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardDisplayNightEffectGlow_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000388 RID: 904 RVA: 0x000251AC File Offset: 0x000233AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226947, XrefRangeEnd = 226956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardInsightCost(short card_insight_cost)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref card_insight_cost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardInsightCost_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000389 RID: 905 RVA: 0x000251EC File Offset: 0x000233EC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 226967, RefRangeEnd = 226968, XrefRangeStart = 226956, XrefRangeEnd = 226967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardDisplayInsightCost(short card_insight_cost)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref card_insight_cost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardDisplayInsightCost_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600038A RID: 906 RVA: 0x0002522C File Offset: 0x0002342C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 226979, RefRangeEnd = 226981, XrefRangeStart = 226968, XrefRangeEnd = 226979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetCardDisplayInsightCost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_ResetCardDisplayInsightCost_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600038B RID: 907 RVA: 0x00025260 File Offset: 0x00023460
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226981, XrefRangeEnd = 226990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardHonorValue(short card_honor_value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref card_honor_value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardHonorValue_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600038C RID: 908 RVA: 0x000252A0 File Offset: 0x000234A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226990, XrefRangeEnd = 226999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTextEffect(string card_effect_text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_effect_text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardTextEffect_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600038D RID: 909 RVA: 0x000252E4 File Offset: 0x000234E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226999, XrefRangeEnd = 227008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTextFateEffect(string card_fate_effect_text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_fate_effect_text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardTextFateEffect_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600038E RID: 910 RVA: 0x00025328 File Offset: 0x00023528
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227008, XrefRangeEnd = 227017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTextEnergizeEffect(string card_energize_effect_text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_energize_effect_text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardTextEnergizeEffect_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600038F RID: 911 RVA: 0x0002536C File Offset: 0x0002356C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227017, XrefRangeEnd = 227026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTextTrophyEffect(string card_trophy_effect_text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_trophy_effect_text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardTextTrophyEffect_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000390 RID: 912 RVA: 0x000253B0 File Offset: 0x000235B0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 227035, RefRangeEnd = 227037, XrefRangeStart = 227026, XrefRangeEnd = 227035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTextDayEffect(string card_day_effect_text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_day_effect_text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardTextDayEffect_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000391 RID: 913 RVA: 0x000253F4 File Offset: 0x000235F4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 227046, RefRangeEnd = 227047, XrefRangeStart = 227037, XrefRangeEnd = 227046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTextNightEffect(string card_night_effect_text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_night_effect_text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardTextNightEffect_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000392 RID: 914 RVA: 0x00025438 File Offset: 0x00023638
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227047, XrefRangeEnd = 227056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTextSetPlusRarityIndicator(string card_set_plus_rarity_text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_set_plus_rarity_text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardTextSetPlusRarityIndicator_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000393 RID: 915 RVA: 0x0002547C File Offset: 0x0002367C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227056, XrefRangeEnd = 227065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTextFlavor(string card_flavor_text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_flavor_text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardTextFlavor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000394 RID: 916 RVA: 0x000254C0 File Offset: 0x000236C0
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 227096, RefRangeEnd = 227101, XrefRangeStart = 227065, XrefRangeEnd = 227096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardCount(int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardCount_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000395 RID: 917 RVA: 0x00025500 File Offset: 0x00023700
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227101, XrefRangeEnd = 227150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetupCallbacks(CardManager card_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionCard.NativeMethodInfoPtr_SetupCallbacks_Public_Virtual_Void_CardManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00025550 File Offset: 0x00023750
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 227162, RefRangeEnd = 227167, XrefRangeStart = 227150, XrefRangeEnd = 227162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetActiveGlow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetActiveGlow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000397 RID: 919 RVA: 0x00025584 File Offset: 0x00023784
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 227168, RefRangeEnd = 227171, XrefRangeStart = 227167, XrefRangeEnd = 227168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGlowOverride(bool bActive, Color glowColor, bool bOverrideColor = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bActive;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glowColor;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bOverrideColor;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetGlowOverride_Public_Void_Boolean_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000398 RID: 920 RVA: 0x000255E0 File Offset: 0x000237E0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 227181, RefRangeEnd = 227183, XrefRangeStart = 227171, XrefRangeEnd = 227181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPlayedGlow(bool bActive, Color glowColor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bActive;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glowColor;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetPlayedGlow_Public_Void_Boolean_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000399 RID: 921 RVA: 0x0002562C File Offset: 0x0002382C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227183, XrefRangeEnd = 227201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetSelectable(bool bSelectable, Color highlightColor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bSelectable;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highlightColor;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionCard.NativeMethodInfoPtr_SetSelectable_Public_Virtual_Void_Boolean_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600039A RID: 922 RVA: 0x00025684 File Offset: 0x00023884
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227201, XrefRangeEnd = 227282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginAnimationCallback(AnimateObject animateObject, AnimationLocator sourceLocator, AnimationLocator destinationLocator)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_BeginAnimationCallback_Private_Void_AnimateObject_AnimationLocator_AnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600039B RID: 923 RVA: 0x000256EC File Offset: 0x000238EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227282, XrefRangeEnd = 227318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndAnimationCallback(AnimateObject animateObject, AnimationLocator sourceLocator, AnimationLocator destinationLocator)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_EndAnimationCallback_Private_Void_AnimateObject_AnimationLocator_AnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600039C RID: 924 RVA: 0x00025754 File Offset: 0x00023954
	[CallerCount(0)]
	public unsafe bool IsCurrentlyDragging()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_IsCurrentlyDragging_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600039D RID: 925 RVA: 0x00025790 File Offset: 0x00023990
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227318, XrefRangeEnd = 227325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDragType(ECardDragType dragType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref dragType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetDragType_Public_Void_ECardDragType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600039E RID: 926 RVA: 0x000257D0 File Offset: 0x000239D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227325, XrefRangeEnd = 227344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginDragCallback(DragObject dragObject, PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_BeginDragCallback_Private_Void_DragObject_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600039F RID: 927 RVA: 0x00025824 File Offset: 0x00023A24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227344, XrefRangeEnd = 227363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndDragCallback(DragObject dragObject, PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_EndDragCallback_Private_Void_DragObject_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00025878 File Offset: 0x00023A78
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227363, XrefRangeEnd = 227387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DragHintCallback(DragObject dragObject, PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_DragHintCallback_Private_Void_DragObject_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x000258CC File Offset: 0x00023ACC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227387, XrefRangeEnd = 227400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnPointerClick(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00025910 File Offset: 0x00023B10
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnPointerDown(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x00025954 File Offset: 0x00023B54
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnPointerUp(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00025998 File Offset: 0x00023B98
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 227408, RefRangeEnd = 227412, XrefRangeStart = 227400, XrefRangeEnd = 227408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTargetScale(float target_scale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref target_scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetTargetScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x000259D8 File Offset: 0x00023BD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227412, XrefRangeEnd = 227427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool UpdateCard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionCard.NativeMethodInfoPtr_UpdateCard_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x00025A20 File Offset: 0x00023C20
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 227431, RefRangeEnd = 227433, XrefRangeStart = 227427, XrefRangeEnd = 227431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetCardDisplay(ECardDisplayState displayState, bool bCardBackEnabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref displayState;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCardBackEnabled;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_GetCardDisplay_Private_GameObject_ECardDisplayState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x00025A7C File Offset: 0x00023C7C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 227525, RefRangeEnd = 227527, XrefRangeStart = 227433, XrefRangeEnd = 227525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetActiveDisplay(GameObject cardFront, GameObject cardBack, GameObject cardGlow, float setCurrentScale = -1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardFront);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cardBack);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cardGlow);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setCurrentScale;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetActiveDisplay_Private_Void_GameObject_GameObject_GameObject_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x00025AF0 File Offset: 0x00023CF0
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 227532, RefRangeEnd = 227541, XrefRangeStart = 227527, XrefRangeEnd = 227532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowFullCard(float setCurrentScale = -1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref setCurrentScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_ShowFullCard_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x00025B30 File Offset: 0x00023D30
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 227546, RefRangeEnd = 227548, XrefRangeStart = 227541, XrefRangeEnd = 227546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowHalfCard(float setCurrentScale = -1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref setCurrentScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_ShowHalfCard_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003AA RID: 938 RVA: 0x00025B70 File Offset: 0x00023D70
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 227559, RefRangeEnd = 227560, XrefRangeStart = 227548, XrefRangeEnd = 227559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardDisplayState(ECardDisplayState displayState, float setCurrentScale = -1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref displayState;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setCurrentScale;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_SetCardDisplayState_Private_Void_ECardDisplayState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003AB RID: 939 RVA: 0x00025BBC File Offset: 0x00023DBC
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 227579, RefRangeEnd = 227589, XrefRangeStart = 227560, XrefRangeEnd = 227579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplayCardBack(bool bCardBackEnabled, bool bImmediate = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bCardBackEnabled;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bImmediate;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_DisplayCardBack_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00025C08 File Offset: 0x00023E08
	[CallerCount(0)]
	public unsafe override bool CanMagnify(bool bAllowShowingCardBack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bAllowShowingCardBack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionCard.NativeMethodInfoPtr_CanMagnify_Public_Virtual_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060003AD RID: 941 RVA: 0x00025C5C File Offset: 0x00023E5C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227589, XrefRangeEnd = 227623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CustomSortAscensionCards(Transform a, Transform b)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr_CustomSortAscensionCards_Public_Static_Int32_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060003AE RID: 942 RVA: 0x00025CB0 File Offset: 0x00023EB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227623, XrefRangeEnd = 227625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionCard()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003AF RID: 943 RVA: 0x00003FBD File Offset: 0x000021BD
	public AscensionCard(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x060003B0 RID: 944 RVA: 0x00025CEC File Offset: 0x00023EEC
	// (set) Token: 0x060003B1 RID: 945 RVA: 0x00003FC6 File Offset: 0x000021C6
	public unsafe GameObject m_CardFrontFullCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardFrontFullCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardFrontFullCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700013D RID: 317
	// (get) Token: 0x060003B2 RID: 946 RVA: 0x00025D1C File Offset: 0x00023F1C
	// (set) Token: 0x060003B3 RID: 947 RVA: 0x00003FE5 File Offset: 0x000021E5
	public unsafe GameObject m_CardFrontHalfCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardFrontHalfCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardFrontHalfCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x060003B4 RID: 948 RVA: 0x00025D4C File Offset: 0x00023F4C
	// (set) Token: 0x060003B5 RID: 949 RVA: 0x00004004 File Offset: 0x00002204
	public unsafe GameObject m_CardFrontChampionHorizontal
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardFrontChampionHorizontal);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardFrontChampionHorizontal), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700013F RID: 319
	// (get) Token: 0x060003B6 RID: 950 RVA: 0x00025D7C File Offset: 0x00023F7C
	// (set) Token: 0x060003B7 RID: 951 RVA: 0x00004023 File Offset: 0x00002223
	public unsafe GameObject m_CardBackFullCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardBackFullCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardBackFullCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x060003B8 RID: 952 RVA: 0x00025DAC File Offset: 0x00023FAC
	// (set) Token: 0x060003B9 RID: 953 RVA: 0x00004042 File Offset: 0x00002242
	public unsafe GameObject m_CardBackHalfCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardBackHalfCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardBackHalfCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x060003BA RID: 954 RVA: 0x00025DDC File Offset: 0x00023FDC
	// (set) Token: 0x060003BB RID: 955 RVA: 0x00004061 File Offset: 0x00002261
	public unsafe GameObject m_CardGlowFull
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardGlowFull);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardGlowFull), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x060003BC RID: 956 RVA: 0x00025E0C File Offset: 0x0002400C
	// (set) Token: 0x060003BD RID: 957 RVA: 0x00004080 File Offset: 0x00002280
	public unsafe GameObject m_CardGlowHalf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardGlowHalf);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardGlowHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000143 RID: 323
	// (get) Token: 0x060003BE RID: 958 RVA: 0x00025E3C File Offset: 0x0002403C
	// (set) Token: 0x060003BF RID: 959 RVA: 0x0000409F File Offset: 0x0000229F
	public unsafe GameObject m_CardBackRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardBackRotation);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardBackRotation), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000144 RID: 324
	// (get) Token: 0x060003C0 RID: 960 RVA: 0x00025E6C File Offset: 0x0002406C
	// (set) Token: 0x060003C1 RID: 961 RVA: 0x000040BE File Offset: 0x000022BE
	public unsafe GameObject m_CardFrontParent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardFrontParent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardFrontParent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000145 RID: 325
	// (get) Token: 0x060003C2 RID: 962 RVA: 0x00025E9C File Offset: 0x0002409C
	// (set) Token: 0x060003C3 RID: 963 RVA: 0x000040DD File Offset: 0x000022DD
	public unsafe AscensionCardLayout m_LayoutCardFullFront
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_LayoutCardFullFront);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCardLayout>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_LayoutCardFullFront), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000146 RID: 326
	// (get) Token: 0x060003C4 RID: 964 RVA: 0x00025ECC File Offset: 0x000240CC
	// (set) Token: 0x060003C5 RID: 965 RVA: 0x000040FC File Offset: 0x000022FC
	public unsafe AscensionCardLayout m_LayoutCardHalfFront
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_LayoutCardHalfFront);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCardLayout>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_LayoutCardHalfFront), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000147 RID: 327
	// (get) Token: 0x060003C6 RID: 966 RVA: 0x00025EFC File Offset: 0x000240FC
	// (set) Token: 0x060003C7 RID: 967 RVA: 0x0000411B File Offset: 0x0000231B
	public unsafe AscensionCardLayout m_LayoutCardChampionHorizontal
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_LayoutCardChampionHorizontal);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCardLayout>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_LayoutCardChampionHorizontal), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000148 RID: 328
	// (get) Token: 0x060003C8 RID: 968 RVA: 0x00025F2C File Offset: 0x0002412C
	// (set) Token: 0x060003C9 RID: 969 RVA: 0x0000413A File Offset: 0x0000233A
	public unsafe ResourceEntry m_ResourceCardImage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_ResourceCardImage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceEntry>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_ResourceCardImage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x060003CA RID: 970 RVA: 0x00025F5C File Offset: 0x0002415C
	// (set) Token: 0x060003CB RID: 971 RVA: 0x00004159 File Offset: 0x00002359
	public unsafe bool m_bDontShowCardFront
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bDontShowCardFront);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bDontShowCardFront)) = value;
		}
	}

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x060003CC RID: 972 RVA: 0x00025F84 File Offset: 0x00024184
	// (set) Token: 0x060003CD RID: 973 RVA: 0x00004174 File Offset: 0x00002374
	public unsafe bool m_bDesireShowCardBack
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bDesireShowCardBack);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bDesireShowCardBack)) = value;
		}
	}

	// Token: 0x1700014B RID: 331
	// (get) Token: 0x060003CE RID: 974 RVA: 0x00025FAC File Offset: 0x000241AC
	// (set) Token: 0x060003CF RID: 975 RVA: 0x0000418F File Offset: 0x0000238F
	public unsafe bool m_bDesireShowCardBackImmediate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bDesireShowCardBackImmediate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bDesireShowCardBackImmediate)) = value;
		}
	}

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x060003D0 RID: 976 RVA: 0x00025FD4 File Offset: 0x000241D4
	// (set) Token: 0x060003D1 RID: 977 RVA: 0x000041AA File Offset: 0x000023AA
	public unsafe ECardDisplayState m_ActiveDisplayState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_ActiveDisplayState);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_ActiveDisplayState)) = value;
		}
	}

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x060003D2 RID: 978 RVA: 0x00025FFC File Offset: 0x000241FC
	// (set) Token: 0x060003D3 RID: 979 RVA: 0x000041C5 File Offset: 0x000023C5
	public unsafe bool m_bShowingCardBack
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bShowingCardBack);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bShowingCardBack)) = value;
		}
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x060003D4 RID: 980 RVA: 0x00026024 File Offset: 0x00024224
	// (set) Token: 0x060003D5 RID: 981 RVA: 0x000041E0 File Offset: 0x000023E0
	public unsafe Vector3 m_CardBackTargetRotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardBackTargetRotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardBackTargetRotation)) = value;
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x060003D6 RID: 982 RVA: 0x0002604C File Offset: 0x0002424C
	// (set) Token: 0x060003D7 RID: 983 RVA: 0x000041FB File Offset: 0x000023FB
	public unsafe bool m_bGlowActive
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bGlowActive);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bGlowActive)) = value;
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x060003D8 RID: 984 RVA: 0x00026074 File Offset: 0x00024274
	// (set) Token: 0x060003D9 RID: 985 RVA: 0x00004216 File Offset: 0x00002416
	public unsafe bool m_bOverrideGlowColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bOverrideGlowColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bOverrideGlowColor)) = value;
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x060003DA RID: 986 RVA: 0x0002609C File Offset: 0x0002429C
	// (set) Token: 0x060003DB RID: 987 RVA: 0x00004231 File Offset: 0x00002431
	public unsafe Color m_GlowColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_GlowColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_GlowColor)) = value;
		}
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x060003DC RID: 988 RVA: 0x000260C4 File Offset: 0x000242C4
	// (set) Token: 0x060003DD RID: 989 RVA: 0x0000424C File Offset: 0x0000244C
	public unsafe GameObject m_ActiveCardFront
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_ActiveCardFront);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_ActiveCardFront), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x060003DE RID: 990 RVA: 0x000260F4 File Offset: 0x000242F4
	// (set) Token: 0x060003DF RID: 991 RVA: 0x0000426B File Offset: 0x0000246B
	public unsafe GameObject m_ActiveCardBack
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_ActiveCardBack);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_ActiveCardBack), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x060003E0 RID: 992 RVA: 0x00026124 File Offset: 0x00024324
	// (set) Token: 0x060003E1 RID: 993 RVA: 0x0000428A File Offset: 0x0000248A
	public unsafe GameObject m_ActiveGlowDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_ActiveGlowDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_ActiveGlowDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000155 RID: 341
	// (get) Token: 0x060003E2 RID: 994 RVA: 0x00026154 File Offset: 0x00024354
	// (set) Token: 0x060003E3 RID: 995 RVA: 0x000042A9 File Offset: 0x000024A9
	public unsafe AscensionCardCount m_DisplayCardCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_DisplayCardCount);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCardCount>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_DisplayCardCount), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000156 RID: 342
	// (get) Token: 0x060003E4 RID: 996 RVA: 0x00026184 File Offset: 0x00024384
	// (set) Token: 0x060003E5 RID: 997 RVA: 0x000042C8 File Offset: 0x000024C8
	public unsafe int m_CurrentCardCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CurrentCardCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CurrentCardCount)) = value;
		}
	}

	// Token: 0x17000157 RID: 343
	// (get) Token: 0x060003E6 RID: 998 RVA: 0x000261AC File Offset: 0x000243AC
	// (set) Token: 0x060003E7 RID: 999 RVA: 0x000042E3 File Offset: 0x000024E3
	public unsafe bool m_bMatchWidthOnActiveDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bMatchWidthOnActiveDisplay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bMatchWidthOnActiveDisplay)) = value;
		}
	}

	// Token: 0x17000158 RID: 344
	// (get) Token: 0x060003E8 RID: 1000 RVA: 0x000261D4 File Offset: 0x000243D4
	// (set) Token: 0x060003E9 RID: 1001 RVA: 0x000042FE File Offset: 0x000024FE
	public unsafe bool m_bMatchHeightOnActiveDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bMatchHeightOnActiveDisplay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bMatchHeightOnActiveDisplay)) = value;
		}
	}

	// Token: 0x17000159 RID: 345
	// (get) Token: 0x060003EA RID: 1002 RVA: 0x000261FC File Offset: 0x000243FC
	// (set) Token: 0x060003EB RID: 1003 RVA: 0x00004319 File Offset: 0x00002519
	public unsafe AscensionCard.OnPointerClickCallback m_OverridePointerClickCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_OverridePointerClickCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCard.OnPointerClickCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_OverridePointerClickCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700015A RID: 346
	// (get) Token: 0x060003EC RID: 1004 RVA: 0x0002622C File Offset: 0x0002442C
	// (set) Token: 0x060003ED RID: 1005 RVA: 0x00004338 File Offset: 0x00002538
	public unsafe ECardDragType m_DragType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_DragType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_DragType)) = value;
		}
	}

	// Token: 0x1700015B RID: 347
	// (get) Token: 0x060003EE RID: 1006 RVA: 0x00026254 File Offset: 0x00024454
	// (set) Token: 0x060003EF RID: 1007 RVA: 0x00004353 File Offset: 0x00002553
	public unsafe bool m_bCurrentlyDragging
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bCurrentlyDragging);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bCurrentlyDragging)) = value;
		}
	}

	// Token: 0x1700015C RID: 348
	// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0002627C File Offset: 0x0002447C
	// (set) Token: 0x060003F1 RID: 1009 RVA: 0x0000436E File Offset: 0x0000256E
	public unsafe string m_CardName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700015D RID: 349
	// (get) Token: 0x060003F2 RID: 1010 RVA: 0x000262A4 File Offset: 0x000244A4
	// (set) Token: 0x060003F3 RID: 1011 RVA: 0x0000438D File Offset: 0x0000258D
	public unsafe int m_CardHash
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardHash);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardHash)) = value;
		}
	}

	// Token: 0x1700015E RID: 350
	// (get) Token: 0x060003F4 RID: 1012 RVA: 0x000262CC File Offset: 0x000244CC
	// (set) Token: 0x060003F5 RID: 1013 RVA: 0x000043A8 File Offset: 0x000025A8
	public unsafe int m_CardType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardType)) = value;
		}
	}

	// Token: 0x1700015F RID: 351
	// (get) Token: 0x060003F6 RID: 1014 RVA: 0x000262F4 File Offset: 0x000244F4
	// (set) Token: 0x060003F7 RID: 1015 RVA: 0x000043C3 File Offset: 0x000025C3
	public unsafe ushort m_CardFactionFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardFactionFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardFactionFlags)) = value;
		}
	}

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0002631C File Offset: 0x0002451C
	// (set) Token: 0x060003F9 RID: 1017 RVA: 0x000043DE File Offset: 0x000025DE
	public unsafe short m_CardHonorValue
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardHonorValue);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardHonorValue)) = value;
		}
	}

	// Token: 0x17000161 RID: 353
	// (get) Token: 0x060003FA RID: 1018 RVA: 0x00026344 File Offset: 0x00024544
	// (set) Token: 0x060003FB RID: 1019 RVA: 0x000043F9 File Offset: 0x000025F9
	public unsafe short m_CardRuneCost
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardRuneCost);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardRuneCost)) = value;
		}
	}

	// Token: 0x17000162 RID: 354
	// (get) Token: 0x060003FC RID: 1020 RVA: 0x0002636C File Offset: 0x0002456C
	// (set) Token: 0x060003FD RID: 1021 RVA: 0x00004414 File Offset: 0x00002614
	public unsafe short m_CardDisplayRuneCost
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardDisplayRuneCost);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardDisplayRuneCost)) = value;
		}
	}

	// Token: 0x17000163 RID: 355
	// (get) Token: 0x060003FE RID: 1022 RVA: 0x00026394 File Offset: 0x00024594
	// (set) Token: 0x060003FF RID: 1023 RVA: 0x0000442F File Offset: 0x0000262F
	public unsafe short m_CardPowerCost
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardPowerCost);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardPowerCost)) = value;
		}
	}

	// Token: 0x17000164 RID: 356
	// (get) Token: 0x06000400 RID: 1024 RVA: 0x000263BC File Offset: 0x000245BC
	// (set) Token: 0x06000401 RID: 1025 RVA: 0x0000444A File Offset: 0x0000264A
	public unsafe short m_CardDisplayPowerCost
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardDisplayPowerCost);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardDisplayPowerCost)) = value;
		}
	}

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x06000402 RID: 1026 RVA: 0x000263E4 File Offset: 0x000245E4
	// (set) Token: 0x06000403 RID: 1027 RVA: 0x00004465 File Offset: 0x00002665
	public unsafe short m_CardInsightCost
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardInsightCost);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardInsightCost)) = value;
		}
	}

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x06000404 RID: 1028 RVA: 0x0002640C File Offset: 0x0002460C
	// (set) Token: 0x06000405 RID: 1029 RVA: 0x00004480 File Offset: 0x00002680
	public unsafe short m_CardDisplayInsightCost
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardDisplayInsightCost);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_CardDisplayInsightCost)) = value;
		}
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x06000406 RID: 1030 RVA: 0x00026434 File Offset: 0x00024634
	// (set) Token: 0x06000407 RID: 1031 RVA: 0x0000449B File Offset: 0x0000269B
	public unsafe uint m_DisplayedFactionEmblems
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_DisplayedFactionEmblems);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_DisplayedFactionEmblems)) = value;
		}
	}

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x06000408 RID: 1032 RVA: 0x0002645C File Offset: 0x0002465C
	// (set) Token: 0x06000409 RID: 1033 RVA: 0x000044B6 File Offset: 0x000026B6
	public unsafe bool m_DisplayedEnergizeBoxGlow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_DisplayedEnergizeBoxGlow);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_DisplayedEnergizeBoxGlow)) = value;
		}
	}

	// Token: 0x17000169 RID: 361
	// (get) Token: 0x0600040A RID: 1034 RVA: 0x00026484 File Offset: 0x00024684
	// (set) Token: 0x0600040B RID: 1035 RVA: 0x000044D1 File Offset: 0x000026D1
	public unsafe bool m_DisplayedDayEffectGlow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_DisplayedDayEffectGlow);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_DisplayedDayEffectGlow)) = value;
		}
	}

	// Token: 0x1700016A RID: 362
	// (get) Token: 0x0600040C RID: 1036 RVA: 0x000264AC File Offset: 0x000246AC
	// (set) Token: 0x0600040D RID: 1037 RVA: 0x000044EC File Offset: 0x000026EC
	public unsafe bool m_DisplayedNightEffectGlow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_DisplayedNightEffectGlow);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_DisplayedNightEffectGlow)) = value;
		}
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x0600040E RID: 1038 RVA: 0x000264D4 File Offset: 0x000246D4
	// (set) Token: 0x0600040F RID: 1039 RVA: 0x00004507 File Offset: 0x00002707
	public unsafe bool m_bDoNotPutInVoid
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bDoNotPutInVoid);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bDoNotPutInVoid)) = value;
		}
	}

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x06000410 RID: 1040 RVA: 0x000264FC File Offset: 0x000246FC
	// (set) Token: 0x06000411 RID: 1041 RVA: 0x00004522 File Offset: 0x00002722
	public unsafe bool m_bPreserveDisplayState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bPreserveDisplayState);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bPreserveDisplayState)) = value;
		}
	}

	// Token: 0x1700016D RID: 365
	// (get) Token: 0x06000412 RID: 1042 RVA: 0x00026524 File Offset: 0x00024724
	// (set) Token: 0x06000413 RID: 1043 RVA: 0x0000453D File Offset: 0x0000273D
	public unsafe bool m_bLivesInUniqueCardZone
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bLivesInUniqueCardZone);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCard.NativeFieldInfoPtr_m_bLivesInUniqueCardZone)) = value;
		}
	}

	// Token: 0x04000206 RID: 518
	private static readonly IntPtr NativeFieldInfoPtr_m_CardFrontFullCard;

	// Token: 0x04000207 RID: 519
	private static readonly IntPtr NativeFieldInfoPtr_m_CardFrontHalfCard;

	// Token: 0x04000208 RID: 520
	private static readonly IntPtr NativeFieldInfoPtr_m_CardFrontChampionHorizontal;

	// Token: 0x04000209 RID: 521
	private static readonly IntPtr NativeFieldInfoPtr_m_CardBackFullCard;

	// Token: 0x0400020A RID: 522
	private static readonly IntPtr NativeFieldInfoPtr_m_CardBackHalfCard;

	// Token: 0x0400020B RID: 523
	private static readonly IntPtr NativeFieldInfoPtr_m_CardGlowFull;

	// Token: 0x0400020C RID: 524
	private static readonly IntPtr NativeFieldInfoPtr_m_CardGlowHalf;

	// Token: 0x0400020D RID: 525
	private static readonly IntPtr NativeFieldInfoPtr_m_CardBackRotation;

	// Token: 0x0400020E RID: 526
	private static readonly IntPtr NativeFieldInfoPtr_m_CardFrontParent;

	// Token: 0x0400020F RID: 527
	private static readonly IntPtr NativeFieldInfoPtr_m_LayoutCardFullFront;

	// Token: 0x04000210 RID: 528
	private static readonly IntPtr NativeFieldInfoPtr_m_LayoutCardHalfFront;

	// Token: 0x04000211 RID: 529
	private static readonly IntPtr NativeFieldInfoPtr_m_LayoutCardChampionHorizontal;

	// Token: 0x04000212 RID: 530
	private static readonly IntPtr NativeFieldInfoPtr_m_ResourceCardImage;

	// Token: 0x04000213 RID: 531
	private static readonly IntPtr NativeFieldInfoPtr_m_bDontShowCardFront;

	// Token: 0x04000214 RID: 532
	private static readonly IntPtr NativeFieldInfoPtr_m_bDesireShowCardBack;

	// Token: 0x04000215 RID: 533
	private static readonly IntPtr NativeFieldInfoPtr_m_bDesireShowCardBackImmediate;

	// Token: 0x04000216 RID: 534
	private static readonly IntPtr NativeFieldInfoPtr_m_ActiveDisplayState;

	// Token: 0x04000217 RID: 535
	private static readonly IntPtr NativeFieldInfoPtr_m_bShowingCardBack;

	// Token: 0x04000218 RID: 536
	private static readonly IntPtr NativeFieldInfoPtr_m_CardBackTargetRotation;

	// Token: 0x04000219 RID: 537
	private static readonly IntPtr NativeFieldInfoPtr_m_bGlowActive;

	// Token: 0x0400021A RID: 538
	private static readonly IntPtr NativeFieldInfoPtr_m_bOverrideGlowColor;

	// Token: 0x0400021B RID: 539
	private static readonly IntPtr NativeFieldInfoPtr_m_GlowColor;

	// Token: 0x0400021C RID: 540
	private static readonly IntPtr NativeFieldInfoPtr_m_ActiveCardFront;

	// Token: 0x0400021D RID: 541
	private static readonly IntPtr NativeFieldInfoPtr_m_ActiveCardBack;

	// Token: 0x0400021E RID: 542
	private static readonly IntPtr NativeFieldInfoPtr_m_ActiveGlowDisplay;

	// Token: 0x0400021F RID: 543
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayCardCount;

	// Token: 0x04000220 RID: 544
	private static readonly IntPtr NativeFieldInfoPtr_m_CurrentCardCount;

	// Token: 0x04000221 RID: 545
	private static readonly IntPtr NativeFieldInfoPtr_m_bMatchWidthOnActiveDisplay;

	// Token: 0x04000222 RID: 546
	private static readonly IntPtr NativeFieldInfoPtr_m_bMatchHeightOnActiveDisplay;

	// Token: 0x04000223 RID: 547
	private static readonly IntPtr NativeFieldInfoPtr_m_OverridePointerClickCallback;

	// Token: 0x04000224 RID: 548
	private static readonly IntPtr NativeFieldInfoPtr_m_DragType;

	// Token: 0x04000225 RID: 549
	private static readonly IntPtr NativeFieldInfoPtr_m_bCurrentlyDragging;

	// Token: 0x04000226 RID: 550
	private static readonly IntPtr NativeFieldInfoPtr_m_CardName;

	// Token: 0x04000227 RID: 551
	private static readonly IntPtr NativeFieldInfoPtr_m_CardHash;

	// Token: 0x04000228 RID: 552
	private static readonly IntPtr NativeFieldInfoPtr_m_CardType;

	// Token: 0x04000229 RID: 553
	private static readonly IntPtr NativeFieldInfoPtr_m_CardFactionFlags;

	// Token: 0x0400022A RID: 554
	private static readonly IntPtr NativeFieldInfoPtr_m_CardHonorValue;

	// Token: 0x0400022B RID: 555
	private static readonly IntPtr NativeFieldInfoPtr_m_CardRuneCost;

	// Token: 0x0400022C RID: 556
	private static readonly IntPtr NativeFieldInfoPtr_m_CardDisplayRuneCost;

	// Token: 0x0400022D RID: 557
	private static readonly IntPtr NativeFieldInfoPtr_m_CardPowerCost;

	// Token: 0x0400022E RID: 558
	private static readonly IntPtr NativeFieldInfoPtr_m_CardDisplayPowerCost;

	// Token: 0x0400022F RID: 559
	private static readonly IntPtr NativeFieldInfoPtr_m_CardInsightCost;

	// Token: 0x04000230 RID: 560
	private static readonly IntPtr NativeFieldInfoPtr_m_CardDisplayInsightCost;

	// Token: 0x04000231 RID: 561
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedFactionEmblems;

	// Token: 0x04000232 RID: 562
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedEnergizeBoxGlow;

	// Token: 0x04000233 RID: 563
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedDayEffectGlow;

	// Token: 0x04000234 RID: 564
	private static readonly IntPtr NativeFieldInfoPtr_m_DisplayedNightEffectGlow;

	// Token: 0x04000235 RID: 565
	private static readonly IntPtr NativeFieldInfoPtr_m_bDoNotPutInVoid;

	// Token: 0x04000236 RID: 566
	private static readonly IntPtr NativeFieldInfoPtr_m_bPreserveDisplayState;

	// Token: 0x04000237 RID: 567
	private static readonly IntPtr NativeFieldInfoPtr_m_bLivesInUniqueCardZone;

	// Token: 0x04000238 RID: 568
	private static readonly IntPtr NativeMethodInfoPtr_IsShowingCardBack_Public_Boolean_0;

	// Token: 0x04000239 RID: 569
	private static readonly IntPtr NativeMethodInfoPtr_SetPreserveDisplayState_Public_Void_Boolean_0;

	// Token: 0x0400023A RID: 570
	private static readonly IntPtr NativeMethodInfoPtr_GetCardName_Public_String_0;

	// Token: 0x0400023B RID: 571
	private static readonly IntPtr NativeMethodInfoPtr_SetCardName_Public_Void_String_0;

	// Token: 0x0400023C RID: 572
	private static readonly IntPtr NativeMethodInfoPtr_GetCardHash_Public_Int32_0;

	// Token: 0x0400023D RID: 573
	private static readonly IntPtr NativeMethodInfoPtr_SetCardHash_Public_Void_Int32_0;

	// Token: 0x0400023E RID: 574
	private static readonly IntPtr NativeMethodInfoPtr_GetCardType_Public_Int32_0;

	// Token: 0x0400023F RID: 575
	private static readonly IntPtr NativeMethodInfoPtr_GetCardFactionFlags_Public_UInt16_0;

	// Token: 0x04000240 RID: 576
	private static readonly IntPtr NativeMethodInfoPtr_SetCardType_Public_Void_Int32_UInt16_0;

	// Token: 0x04000241 RID: 577
	private static readonly IntPtr NativeMethodInfoPtr_GetCardHonorValue_Public_Int16_0;

	// Token: 0x04000242 RID: 578
	private static readonly IntPtr NativeMethodInfoPtr_DoNotPutInVoid_Public_Boolean_0;

	// Token: 0x04000243 RID: 579
	private static readonly IntPtr NativeMethodInfoPtr_SetDoNotPutInVoid_Public_Void_Boolean_0;

	// Token: 0x04000244 RID: 580
	private static readonly IntPtr NativeMethodInfoPtr_LivesInUniqueCardZone_Public_Boolean_0;

	// Token: 0x04000245 RID: 581
	private static readonly IntPtr NativeMethodInfoPtr_SetLivesInUniqueCardZone_Public_Void_Boolean_0;

	// Token: 0x04000246 RID: 582
	private static readonly IntPtr NativeMethodInfoPtr_AddOverridePointerClickCallback_Public_Void_OnPointerClickCallback_0;

	// Token: 0x04000247 RID: 583
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOverridePointerClickCallback_Public_Void_OnPointerClickCallback_0;

	// Token: 0x04000248 RID: 584
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000249 RID: 585
	private static readonly IntPtr NativeMethodInfoPtr_CreateFromPrefab_Public_Static_GameObject_GameObject_0;

	// Token: 0x0400024A RID: 586
	private static readonly IntPtr NativeMethodInfoPtr_MergeCardFrontFullFromPrefab_Public_Void_GameObject_0;

	// Token: 0x0400024B RID: 587
	private static readonly IntPtr NativeMethodInfoPtr_MergeCardFrontHalfFromPrefab_Public_Void_GameObject_0;

	// Token: 0x0400024C RID: 588
	private static readonly IntPtr NativeMethodInfoPtr_MergeCardFrontChampionHorizontalFromPrefab_Public_Void_GameObject_0;

	// Token: 0x0400024D RID: 589
	private static readonly IntPtr NativeMethodInfoPtr_MergeCardBackFromPrefab_Public_Void_GameObject_0;

	// Token: 0x0400024E RID: 590
	private static readonly IntPtr NativeMethodInfoPtr_MergeCardBackHalfFromPrefab_Public_Void_GameObject_0;

	// Token: 0x0400024F RID: 591
	private static readonly IntPtr NativeMethodInfoPtr_MergeGoldBorderFromPrefab_Public_Void_GameObject_0;

	// Token: 0x04000250 RID: 592
	private static readonly IntPtr NativeMethodInfoPtr_MergeGoldBorderHalfFromPrefab_Public_Void_GameObject_0;

	// Token: 0x04000251 RID: 593
	private static readonly IntPtr NativeMethodInfoPtr_MergeCardGlowFullFromPrefab_Public_Void_GameObject_Boolean_0;

	// Token: 0x04000252 RID: 594
	private static readonly IntPtr NativeMethodInfoPtr_MergeCardGlowHalfFromPrefab_Public_Void_GameObject_0;

	// Token: 0x04000253 RID: 595
	private static readonly IntPtr NativeMethodInfoPtr_HasLoadCompleted_Public_Boolean_0;

	// Token: 0x04000254 RID: 596
	private static readonly IntPtr NativeMethodInfoPtr_AddOnLoadCompletedCallback_Public_Void_ResourceLoadCallback_0;

	// Token: 0x04000255 RID: 597
	private static readonly IntPtr NativeMethodInfoPtr_SetDontShowCardFront_Public_Void_Boolean_0;

	// Token: 0x04000256 RID: 598
	private static readonly IntPtr NativeMethodInfoPtr_SetCardImage_Public_Void_ResourceEntry_0;

	// Token: 0x04000257 RID: 599
	private static readonly IntPtr NativeMethodInfoPtr_HandleCardImageLoadCompleted_Private_Void_ResourceEntry_0;

	// Token: 0x04000258 RID: 600
	private static readonly IntPtr NativeMethodInfoPtr_RemoveCardImage_Private_Void_0;

	// Token: 0x04000259 RID: 601
	private static readonly IntPtr NativeMethodInfoPtr_SetCardFrameTop_Public_Void_Sprite_0;

	// Token: 0x0400025A RID: 602
	private static readonly IntPtr NativeMethodInfoPtr_SetCardFrameBottom_Public_Void_Sprite_0;

	// Token: 0x0400025B RID: 603
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTitle_Public_Void_String_0;

	// Token: 0x0400025C RID: 604
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTypeText_Public_Void_String_0;

	// Token: 0x0400025D RID: 605
	private static readonly IntPtr NativeMethodInfoPtr_SetCardRuneCost_Public_Void_Int16_0;

	// Token: 0x0400025E RID: 606
	private static readonly IntPtr NativeMethodInfoPtr_SetCardDisplayRuneCost_Public_Void_Int16_0;

	// Token: 0x0400025F RID: 607
	private static readonly IntPtr NativeMethodInfoPtr_ResetCardDisplayRuneCost_Public_Void_0;

	// Token: 0x04000260 RID: 608
	private static readonly IntPtr NativeMethodInfoPtr_SetCardPowerCost_Public_Void_Int16_0;

	// Token: 0x04000261 RID: 609
	private static readonly IntPtr NativeMethodInfoPtr_SetCardDisplayPowerCost_Public_Void_Int16_0;

	// Token: 0x04000262 RID: 610
	private static readonly IntPtr NativeMethodInfoPtr_ResetCardDisplayPowerCost_Public_Void_0;

	// Token: 0x04000263 RID: 611
	private static readonly IntPtr NativeMethodInfoPtr_SetCardDisplayFactionEmblems_Public_Void_UInt32_0;

	// Token: 0x04000264 RID: 612
	private static readonly IntPtr NativeMethodInfoPtr_ResetCardDisplayFactionEmblems_Public_Void_0;

	// Token: 0x04000265 RID: 613
	private static readonly IntPtr NativeMethodInfoPtr_SetCardDisplayEnergizeBoxGlow_Public_Void_Boolean_0;

	// Token: 0x04000266 RID: 614
	private static readonly IntPtr NativeMethodInfoPtr_SetCardDisplayDayEffectGlow_Public_Void_Boolean_0;

	// Token: 0x04000267 RID: 615
	private static readonly IntPtr NativeMethodInfoPtr_SetCardDisplayNightEffectGlow_Public_Void_Boolean_0;

	// Token: 0x04000268 RID: 616
	private static readonly IntPtr NativeMethodInfoPtr_SetCardInsightCost_Public_Void_Int16_0;

	// Token: 0x04000269 RID: 617
	private static readonly IntPtr NativeMethodInfoPtr_SetCardDisplayInsightCost_Public_Void_Int16_0;

	// Token: 0x0400026A RID: 618
	private static readonly IntPtr NativeMethodInfoPtr_ResetCardDisplayInsightCost_Public_Void_0;

	// Token: 0x0400026B RID: 619
	private static readonly IntPtr NativeMethodInfoPtr_SetCardHonorValue_Public_Void_Int16_0;

	// Token: 0x0400026C RID: 620
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTextEffect_Public_Void_String_0;

	// Token: 0x0400026D RID: 621
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTextFateEffect_Public_Void_String_0;

	// Token: 0x0400026E RID: 622
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTextEnergizeEffect_Public_Void_String_0;

	// Token: 0x0400026F RID: 623
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTextTrophyEffect_Public_Void_String_0;

	// Token: 0x04000270 RID: 624
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTextDayEffect_Public_Void_String_0;

	// Token: 0x04000271 RID: 625
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTextNightEffect_Public_Void_String_0;

	// Token: 0x04000272 RID: 626
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTextSetPlusRarityIndicator_Public_Void_String_0;

	// Token: 0x04000273 RID: 627
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTextFlavor_Public_Void_String_0;

	// Token: 0x04000274 RID: 628
	private static readonly IntPtr NativeMethodInfoPtr_SetCardCount_Public_Void_Int32_0;

	// Token: 0x04000275 RID: 629
	private static readonly IntPtr NativeMethodInfoPtr_SetupCallbacks_Public_Virtual_Void_CardManager_0;

	// Token: 0x04000276 RID: 630
	private static readonly IntPtr NativeMethodInfoPtr_SetActiveGlow_Private_Void_0;

	// Token: 0x04000277 RID: 631
	private static readonly IntPtr NativeMethodInfoPtr_SetGlowOverride_Public_Void_Boolean_Color_Boolean_0;

	// Token: 0x04000278 RID: 632
	private static readonly IntPtr NativeMethodInfoPtr_SetPlayedGlow_Public_Void_Boolean_Color_0;

	// Token: 0x04000279 RID: 633
	private static readonly IntPtr NativeMethodInfoPtr_SetSelectable_Public_Virtual_Void_Boolean_Color_0;

	// Token: 0x0400027A RID: 634
	private static readonly IntPtr NativeMethodInfoPtr_BeginAnimationCallback_Private_Void_AnimateObject_AnimationLocator_AnimationLocator_0;

	// Token: 0x0400027B RID: 635
	private static readonly IntPtr NativeMethodInfoPtr_EndAnimationCallback_Private_Void_AnimateObject_AnimationLocator_AnimationLocator_0;

	// Token: 0x0400027C RID: 636
	private static readonly IntPtr NativeMethodInfoPtr_IsCurrentlyDragging_Public_Boolean_0;

	// Token: 0x0400027D RID: 637
	private static readonly IntPtr NativeMethodInfoPtr_SetDragType_Public_Void_ECardDragType_0;

	// Token: 0x0400027E RID: 638
	private static readonly IntPtr NativeMethodInfoPtr_BeginDragCallback_Private_Void_DragObject_PointerEventData_0;

	// Token: 0x0400027F RID: 639
	private static readonly IntPtr NativeMethodInfoPtr_EndDragCallback_Private_Void_DragObject_PointerEventData_0;

	// Token: 0x04000280 RID: 640
	private static readonly IntPtr NativeMethodInfoPtr_DragHintCallback_Private_Void_DragObject_PointerEventData_0;

	// Token: 0x04000281 RID: 641
	private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000282 RID: 642
	private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000283 RID: 643
	private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000284 RID: 644
	private static readonly IntPtr NativeMethodInfoPtr_SetTargetScale_Public_Void_Single_0;

	// Token: 0x04000285 RID: 645
	private static readonly IntPtr NativeMethodInfoPtr_UpdateCard_Public_Virtual_Boolean_0;

	// Token: 0x04000286 RID: 646
	private static readonly IntPtr NativeMethodInfoPtr_GetCardDisplay_Private_GameObject_ECardDisplayState_Boolean_0;

	// Token: 0x04000287 RID: 647
	private static readonly IntPtr NativeMethodInfoPtr_SetActiveDisplay_Private_Void_GameObject_GameObject_GameObject_Single_0;

	// Token: 0x04000288 RID: 648
	private static readonly IntPtr NativeMethodInfoPtr_ShowFullCard_Public_Void_Single_0;

	// Token: 0x04000289 RID: 649
	private static readonly IntPtr NativeMethodInfoPtr_ShowHalfCard_Public_Void_Single_0;

	// Token: 0x0400028A RID: 650
	private static readonly IntPtr NativeMethodInfoPtr_SetCardDisplayState_Private_Void_ECardDisplayState_Single_0;

	// Token: 0x0400028B RID: 651
	private static readonly IntPtr NativeMethodInfoPtr_DisplayCardBack_Public_Void_Boolean_Boolean_0;

	// Token: 0x0400028C RID: 652
	private static readonly IntPtr NativeMethodInfoPtr_CanMagnify_Public_Virtual_Boolean_Boolean_0;

	// Token: 0x0400028D RID: 653
	private static readonly IntPtr NativeMethodInfoPtr_CustomSortAscensionCards_Public_Static_Int32_Transform_Transform_0;

	// Token: 0x0400028E RID: 654
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200016A RID: 362
	public sealed class OnPointerClickCallback : MulticastDelegate
	{
		// Token: 0x060022B7 RID: 8887 RVA: 0x00082408 File Offset: 0x00080608
		// Note: this type is marked as 'beforefieldinit'.
		static OnPointerClickCallback()
		{
			Il2CppClassPointerStore<AscensionCard.OnPointerClickCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionCard>.NativeClassPtr, "OnPointerClickCallback");
			AscensionCard.OnPointerClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard.OnPointerClickCallback>.NativeClassPtr, 100666030);
			AscensionCard.OnPointerClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AscensionCard_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard.OnPointerClickCallback>.NativeClassPtr, 100666031);
			AscensionCard.OnPointerClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AscensionCard_PointerEventData_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard.OnPointerClickCallback>.NativeClassPtr, 100666032);
			AscensionCard.OnPointerClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCard.OnPointerClickCallback>.NativeClassPtr, 100666033);
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x0008247C File Offset: 0x0008067C
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnPointerClickCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionCard.OnPointerClickCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.OnPointerClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x000824D8 File Offset: 0x000806D8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 226438, RefRangeEnd = 226449, XrefRangeStart = 226422, XrefRangeEnd = 226438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(AscensionCard clickCard, PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clickCard);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.OnPointerClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AscensionCard_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x0008252C File Offset: 0x0008072C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AscensionCard clickCard, PointerEventData eventData, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clickCard);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.OnPointerClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AscensionCard_PointerEventData_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x000825B4 File Offset: 0x000807B4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCard.OnPointerClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x00015D94 File Offset: 0x00013F94
		public OnPointerClickCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x00015D9D File Offset: 0x00013F9D
		public static implicit operator AscensionCard.OnPointerClickCallback(Action<AscensionCard, PointerEventData> A_0)
		{
			return DelegateSupport.ConvertDelegate<AscensionCard.OnPointerClickCallback>(A_0);
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x00015DA5 File Offset: 0x00013FA5
		public static AscensionCard.OnPointerClickCallback operator +(AscensionCard.OnPointerClickCallback A_0, AscensionCard.OnPointerClickCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AscensionCard.OnPointerClickCallback>();
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x00015DB3 File Offset: 0x00013FB3
		public static AscensionCard.OnPointerClickCallback operator -(AscensionCard.OnPointerClickCallback A_0, AscensionCard.OnPointerClickCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AscensionCard.OnPointerClickCallback>();
			}
			return delegate2;
		}

		// Token: 0x0400181C RID: 6172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400181D RID: 6173
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AscensionCard_PointerEventData_0;

		// Token: 0x0400181E RID: 6174
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AscensionCard_PointerEventData_AsyncCallback_Object_0;

		// Token: 0x0400181F RID: 6175
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}

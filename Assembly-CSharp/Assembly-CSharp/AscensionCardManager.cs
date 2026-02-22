using System;
using GameData;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x0200001C RID: 28
public class AscensionCardManager : CardManager
{
	// Token: 0x0600049B RID: 1179 RVA: 0x000280F0 File Offset: 0x000262F0
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionCardManager()
	{
		Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionCardManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr);
		AscensionCardManager.NativeFieldInfoPtr_k_cardFlagFate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "k_cardFlagFate");
		AscensionCardManager.NativeFieldInfoPtr_k_cardFlagTrophyMonster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "k_cardFlagTrophyMonster");
		AscensionCardManager.NativeFieldInfoPtr_k_cardFlagEnergy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "k_cardFlagEnergy");
		AscensionCardManager.NativeFieldInfoPtr_k_cardFlagMultiFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "k_cardFlagMultiFaction");
		AscensionCardManager.NativeFieldInfoPtr_k_cardFlagTransformPre = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "k_cardFlagTransformPre");
		AscensionCardManager.NativeFieldInfoPtr_k_cardFlagTransformPost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "k_cardFlagTransformPost");
		AscensionCardManager.NativeFieldInfoPtr_k_cardFlagDream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "k_cardFlagDream");
		AscensionCardManager.NativeFieldInfoPtr_k_cardFlagDreamborn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "k_cardFlagDreamborn");
		AscensionCardManager.NativeFieldInfoPtr_k_cardFlagDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "k_cardFlagDay");
		AscensionCardManager.NativeFieldInfoPtr_k_cardFlagNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "k_cardFlagNight");
		AscensionCardManager.NativeFieldInfoPtr_k_cardFlagDualCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "k_cardFlagDualCost");
		AscensionCardManager.NativeFieldInfoPtr_k_cardFlagChampionHero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "k_cardFlagChampionHero");
		AscensionCardManager.NativeFieldInfoPtr_k_cardFlagDreambind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "k_cardFlagDreambind");
		AscensionCardManager.NativeFieldInfoPtr_k_cardFlagHasGoldBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "k_cardFlagHasGoldBorder");
		AscensionCardManager.NativeFieldInfoPtr_k_cardFlagDoNotPutInVoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "k_cardFlagDoNotPutInVoid");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabCardBase");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabCardBack");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardBackHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabCardBackHalf");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardBackSoulGem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabCardBackSoulGem");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardBackSoulGemHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabCardBackSoulGemHalf");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabCardGlow");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardGlowHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabCardGlowHalf");
		AscensionCardManager.NativeFieldInfoPtr_m_CardSetNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_CardSetNames");
		AscensionCardManager.NativeFieldInfoPtr_m_CardSetTextSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_CardSetTextSprites");
		AscensionCardManager.NativeFieldInfoPtr_m_CardRarityTextSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_CardRarityTextSprite");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabBasicCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabBasicCards");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabSpecificCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabSpecificCards");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericCards");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericFateCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericFateCards");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericEnergyCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericEnergyCards");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericMultiFactionCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericMultiFactionCards");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericTransformPreCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericTransformPreCards");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericTransformPostCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericTransformPostCards");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDreamCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericDreamCards");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDreambornCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericDreambornCards");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDreambindCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericDreambindCards");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericAllFactionCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericAllFactionCards");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDayCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericDayCards");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDayDualCostCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericDayDualCostCards");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericNightCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericNightCards");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericNightDualCostCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericNightDualCostCards");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabEventCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabEventCards");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabTrophyMonster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabTrophyMonster");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabChampionHero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabChampionHero");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabChampionsHorizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabChampionsHorizontal");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGoldBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGoldBorder");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericCardsHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericCardsHalf");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericMultiFactionCardsHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericMultiFactionCardsHalf");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericTransformPreCardsHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericTransformPreCardsHalf");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericTransformPostCardsHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericTransformPostCardsHalf");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDreamCardsHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericDreamCardsHalf");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDreambornCardsHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericDreambornCardsHalf");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDreambindCardsHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericDreambindCardsHalf");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericAllFactionCardsHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericAllFactionCardsHalf");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDayCardsHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericDayCardsHalf");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDayDualCostCardsHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericDayDualCostCardsHalf");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericNightCardsHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericNightCardsHalf");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericNightDualCostCardsHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGenericNightDualCostCardsHalf");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabTrophyMonsterHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabTrophyMonsterHalf");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabChampionHeroHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabChampionHeroHalf");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabGoldBorderHalf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabGoldBorderHalf");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabCardCounter");
		AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardOverlays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_PrefabCardOverlays");
		AscensionCardManager.NativeFieldInfoPtr_m_SpritesCardFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_SpritesCardFrame");
		AscensionCardManager.NativeFieldInfoPtr_m_SpritesCardFrameMultiFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_SpritesCardFrameMultiFaction");
		AscensionCardManager.NativeFieldInfoPtr_m_SpritesCardFrameChampion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_SpritesCardFrameChampion");
		AscensionCardManager.NativeFieldInfoPtr_m_SpritesCardFrameDream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_SpritesCardFrameDream");
		AscensionCardManager.NativeFieldInfoPtr_m_SpritesCardArt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_SpritesCardArt");
		AscensionCardManager.NativeFieldInfoPtr_m_CardInPlayPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_CardInPlayPrefab");
		AscensionCardManager.NativeFieldInfoPtr_m_CardInPlayEventPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_CardInPlayEventPrefab");
		AscensionCardManager.NativeFieldInfoPtr_m_CardLimbo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_CardLimbo");
		AscensionCardManager.NativeFieldInfoPtr_m_DragCardScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_DragCardScale");
		AscensionCardManager.NativeFieldInfoPtr_m_DragCardTargetScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_DragCardTargetScale");
		AscensionCardManager.NativeFieldInfoPtr_m_ResourceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, "m_ResourceManager");
		AscensionCardManager.NativeMethodInfoPtr_GetCardLimbo_Public_AscensionAnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663628);
		AscensionCardManager.NativeMethodInfoPtr_GetDragCardScale_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663629);
		AscensionCardManager.NativeMethodInfoPtr_GetDragCardTargetScale_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663630);
		AscensionCardManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663631);
		AscensionCardManager.NativeMethodInfoPtr_FindCardPrefabByName_Private_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663632);
		AscensionCardManager.NativeMethodInfoPtr_FindEventPrefabByName_Private_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663633);
		AscensionCardManager.NativeMethodInfoPtr_FindChampionPrefabByName_Private_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663634);
		AscensionCardManager.NativeMethodInfoPtr_FindSpriteCardFrameByName_Private_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663635);
		AscensionCardManager.NativeMethodInfoPtr_FindSpriteCardFrameMultiFactionByName_Private_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663636);
		AscensionCardManager.NativeMethodInfoPtr_FindSpriteCardFrameChampionByName_Private_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663637);
		AscensionCardManager.NativeMethodInfoPtr_FindSpriteCardFrameDreamByName_Private_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663638);
		AscensionCardManager.NativeMethodInfoPtr_FindSpriteCardArtByName_Private_ResourceEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663639);
		AscensionCardManager.NativeMethodInfoPtr_GetCardImagePath_Public_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663640);
		AscensionCardManager.NativeMethodInfoPtr_GetPrefabCardCounter_Public_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663641);
		AscensionCardManager.NativeMethodInfoPtr_CreateCardFromInstanceID_Public_Virtual_GameObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663642);
		AscensionCardManager.NativeMethodInfoPtr_CreateCardFromName_Public_GameObject_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663643);
		AscensionCardManager.NativeMethodInfoPtr_CreateCard_Private_GameObject_CardData_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663644);
		AscensionCardManager.NativeMethodInfoPtr_CreateCardInPlay_Public_AscensionCardInPlay_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663645);
		AscensionCardManager.NativeMethodInfoPtr_PlaceCardInCardLimbo_Public_Boolean_AscensionCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663646);
		AscensionCardManager.NativeMethodInfoPtr_PlaceAllCardsInLimbo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663647);
		AscensionCardManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr, 100663648);
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x0002888C File Offset: 0x00026A8C
	[CallerCount(0)]
	public unsafe AscensionAnimationLocator GetCardLimbo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr_GetCardLimbo_Public_AscensionAnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr3) : null;
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x000288CC File Offset: 0x00026ACC
	[CallerCount(0)]
	public unsafe float GetDragCardScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr_GetDragCardScale_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x00028908 File Offset: 0x00026B08
	[CallerCount(0)]
	public unsafe float GetDragCardTargetScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr_GetDragCardTargetScale_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x00028944 File Offset: 0x00026B44
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228111, XrefRangeEnd = 228121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x00028978 File Offset: 0x00026B78
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 228129, RefRangeEnd = 228131, XrefRangeStart = 228121, XrefRangeEnd = 228129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject FindCardPrefabByName(string prefabName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(prefabName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr_FindCardPrefabByName_Private_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x000289C8 File Offset: 0x00026BC8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 228135, RefRangeEnd = 228137, XrefRangeStart = 228131, XrefRangeEnd = 228135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject FindEventPrefabByName(string prefabName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(prefabName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr_FindEventPrefabByName_Private_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}
	}

	// Token: 0x060004A2 RID: 1186 RVA: 0x00028A18 File Offset: 0x00026C18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228137, XrefRangeEnd = 228145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject FindChampionPrefabByName(string prefabName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(prefabName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr_FindChampionPrefabByName_Private_GameObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}
	}

	// Token: 0x060004A3 RID: 1187 RVA: 0x00028A68 File Offset: 0x00026C68
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 228149, RefRangeEnd = 228151, XrefRangeStart = 228145, XrefRangeEnd = 228149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite FindSpriteCardFrameByName(string cardFrameName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardFrameName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr_FindSpriteCardFrameByName_Private_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x00028AB8 File Offset: 0x00026CB8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 228155, RefRangeEnd = 228157, XrefRangeStart = 228151, XrefRangeEnd = 228155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite FindSpriteCardFrameMultiFactionByName(string cardFrameName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardFrameName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr_FindSpriteCardFrameMultiFactionByName_Private_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x00028B08 File Offset: 0x00026D08
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 228161, RefRangeEnd = 228163, XrefRangeStart = 228157, XrefRangeEnd = 228161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite FindSpriteCardFrameChampionByName(string cardFrameName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardFrameName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr_FindSpriteCardFrameChampionByName_Private_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00028B58 File Offset: 0x00026D58
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 228167, RefRangeEnd = 228171, XrefRangeStart = 228163, XrefRangeEnd = 228167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite FindSpriteCardFrameDreamByName(string cardFrameName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardFrameName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr_FindSpriteCardFrameDreamByName_Private_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x00028BA8 File Offset: 0x00026DA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228171, XrefRangeEnd = 228178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResourceEntry FindSpriteCardArtByName(string cardArtPathname)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardArtPathname);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr_FindSpriteCardArtByName_Private_ResourceEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceEntry>(intPtr3) : null;
		}
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x00028BF8 File Offset: 0x00026DF8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 228186, RefRangeEnd = 228188, XrefRangeStart = 228178, XrefRangeEnd = 228186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetCardImagePath(int cardSet, string cardImageName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref cardSet;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cardImageName);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr_GetCardImagePath_Public_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x00028C50 File Offset: 0x00026E50
	[CallerCount(0)]
	public unsafe GameObject GetPrefabCardCounter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr_GetPrefabCardCounter_Public_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x00028C90 File Offset: 0x00026E90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228188, XrefRangeEnd = 228209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override GameObject CreateCardFromInstanceID(int createInstanceID, bool bAddToMasterList = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref createInstanceID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAddToMasterList;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionCardManager.NativeMethodInfoPtr_CreateCardFromInstanceID_Public_Virtual_GameObject_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x00028CF8 File Offset: 0x00026EF8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 228230, RefRangeEnd = 228231, XrefRangeStart = 228209, XrefRangeEnd = 228230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject CreateCardFromName(string cardName, bool bAddToMasterList = true, bool bIgnoreCardBack = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAddToMasterList;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIgnoreCardBack;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr_CreateCardFromName_Public_GameObject_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x060004AC RID: 1196 RVA: 0x00028D64 File Offset: 0x00026F64
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 228695, RefRangeEnd = 228698, XrefRangeStart = 228231, XrefRangeEnd = 228695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject CreateCard(CardData card_info, int createInstanceID, bool bAddToMasterList = true, bool bIgnoreCardBack = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(card_info));
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref createInstanceID;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAddToMasterList;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIgnoreCardBack;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr_CreateCard_Private_GameObject_CardData_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x060004AD RID: 1197 RVA: 0x00028DE4 File Offset: 0x00026FE4
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 228795, RefRangeEnd = 228799, XrefRangeStart = 228698, XrefRangeEnd = 228795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionCardInPlay CreateCardInPlay(int cardinplay_instance_id, bool useEventPrefab = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref cardinplay_instance_id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useEventPrefab;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr_CreateCardInPlay_Public_AscensionCardInPlay_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AscensionCardInPlay>(intPtr3) : null;
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x00028E40 File Offset: 0x00027040
	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 228812, RefRangeEnd = 228835, XrefRangeStart = 228799, XrefRangeEnd = 228812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool PlaceCardInCardLimbo(AscensionCard card)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr_PlaceCardInCardLimbo_Public_Boolean_AscensionCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x00028E90 File Offset: 0x00027090
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 228867, RefRangeEnd = 228868, XrefRangeStart = 228835, XrefRangeEnd = 228867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaceAllCardsInLimbo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr_PlaceAllCardsInLimbo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x00028EC4 File Offset: 0x000270C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228868, XrefRangeEnd = 228869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionCardManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionCardManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x00004A43 File Offset: 0x00002C43
	public AscensionCardManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000196 RID: 406
	// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00028F00 File Offset: 0x00027100
	// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00004A4C File Offset: 0x00002C4C
	public unsafe static ushort k_cardFlagFate
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagFate, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagFate, (void*)(&value));
		}
	}

	// Token: 0x17000197 RID: 407
	// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00028F1C File Offset: 0x0002711C
	// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00004A5A File Offset: 0x00002C5A
	public unsafe static ushort k_cardFlagTrophyMonster
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagTrophyMonster, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagTrophyMonster, (void*)(&value));
		}
	}

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00028F38 File Offset: 0x00027138
	// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00004A68 File Offset: 0x00002C68
	public unsafe static ushort k_cardFlagEnergy
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagEnergy, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagEnergy, (void*)(&value));
		}
	}

	// Token: 0x17000199 RID: 409
	// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00028F54 File Offset: 0x00027154
	// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00004A76 File Offset: 0x00002C76
	public unsafe static ushort k_cardFlagMultiFaction
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagMultiFaction, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagMultiFaction, (void*)(&value));
		}
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x060004BA RID: 1210 RVA: 0x00028F70 File Offset: 0x00027170
	// (set) Token: 0x060004BB RID: 1211 RVA: 0x00004A84 File Offset: 0x00002C84
	public unsafe static ushort k_cardFlagTransformPre
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagTransformPre, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagTransformPre, (void*)(&value));
		}
	}

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x060004BC RID: 1212 RVA: 0x00028F8C File Offset: 0x0002718C
	// (set) Token: 0x060004BD RID: 1213 RVA: 0x00004A92 File Offset: 0x00002C92
	public unsafe static ushort k_cardFlagTransformPost
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagTransformPost, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagTransformPost, (void*)(&value));
		}
	}

	// Token: 0x1700019C RID: 412
	// (get) Token: 0x060004BE RID: 1214 RVA: 0x00028FA8 File Offset: 0x000271A8
	// (set) Token: 0x060004BF RID: 1215 RVA: 0x00004AA0 File Offset: 0x00002CA0
	public unsafe static ushort k_cardFlagDream
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagDream, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagDream, (void*)(&value));
		}
	}

	// Token: 0x1700019D RID: 413
	// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00028FC4 File Offset: 0x000271C4
	// (set) Token: 0x060004C1 RID: 1217 RVA: 0x00004AAE File Offset: 0x00002CAE
	public unsafe static ushort k_cardFlagDreamborn
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagDreamborn, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagDreamborn, (void*)(&value));
		}
	}

	// Token: 0x1700019E RID: 414
	// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00028FE0 File Offset: 0x000271E0
	// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00004ABC File Offset: 0x00002CBC
	public unsafe static ushort k_cardFlagDay
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagDay, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagDay, (void*)(&value));
		}
	}

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00028FFC File Offset: 0x000271FC
	// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00004ACA File Offset: 0x00002CCA
	public unsafe static ushort k_cardFlagNight
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagNight, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagNight, (void*)(&value));
		}
	}

	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00029018 File Offset: 0x00027218
	// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00004AD8 File Offset: 0x00002CD8
	public unsafe static ushort k_cardFlagDualCost
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagDualCost, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagDualCost, (void*)(&value));
		}
	}

	// Token: 0x170001A1 RID: 417
	// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00029034 File Offset: 0x00027234
	// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00004AE6 File Offset: 0x00002CE6
	public unsafe static ushort k_cardFlagChampionHero
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagChampionHero, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagChampionHero, (void*)(&value));
		}
	}

	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x060004CA RID: 1226 RVA: 0x00029050 File Offset: 0x00027250
	// (set) Token: 0x060004CB RID: 1227 RVA: 0x00004AF4 File Offset: 0x00002CF4
	public unsafe static ushort k_cardFlagDreambind
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagDreambind, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagDreambind, (void*)(&value));
		}
	}

	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x060004CC RID: 1228 RVA: 0x0002906C File Offset: 0x0002726C
	// (set) Token: 0x060004CD RID: 1229 RVA: 0x00004B02 File Offset: 0x00002D02
	public unsafe static ushort k_cardFlagHasGoldBorder
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagHasGoldBorder, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagHasGoldBorder, (void*)(&value));
		}
	}

	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x060004CE RID: 1230 RVA: 0x00029088 File Offset: 0x00027288
	// (set) Token: 0x060004CF RID: 1231 RVA: 0x00004B10 File Offset: 0x00002D10
	public unsafe static ushort k_cardFlagDoNotPutInVoid
	{
		get
		{
			ushort num;
			IL2CPP.il2cpp_field_static_get_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagDoNotPutInVoid, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionCardManager.NativeFieldInfoPtr_k_cardFlagDoNotPutInVoid, (void*)(&value));
		}
	}

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x060004D0 RID: 1232 RVA: 0x000290A4 File Offset: 0x000272A4
	// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00004B1E File Offset: 0x00002D1E
	public unsafe GameObject m_PrefabCardBase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardBase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardBase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x060004D2 RID: 1234 RVA: 0x000290D4 File Offset: 0x000272D4
	// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00004B3D File Offset: 0x00002D3D
	public unsafe GameObject m_PrefabCardBack
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardBack);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardBack), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00029104 File Offset: 0x00027304
	// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00004B5C File Offset: 0x00002D5C
	public unsafe GameObject m_PrefabCardBackHalf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardBackHalf);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardBackHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00029134 File Offset: 0x00027334
	// (set) Token: 0x060004D7 RID: 1239 RVA: 0x00004B7B File Offset: 0x00002D7B
	public unsafe GameObject m_PrefabCardBackSoulGem
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardBackSoulGem);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardBackSoulGem), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00029164 File Offset: 0x00027364
	// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00004B9A File Offset: 0x00002D9A
	public unsafe GameObject m_PrefabCardBackSoulGemHalf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardBackSoulGemHalf);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardBackSoulGemHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001AA RID: 426
	// (get) Token: 0x060004DA RID: 1242 RVA: 0x00029194 File Offset: 0x00027394
	// (set) Token: 0x060004DB RID: 1243 RVA: 0x00004BB9 File Offset: 0x00002DB9
	public unsafe GameObject m_PrefabCardGlow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardGlow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardGlow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001AB RID: 427
	// (get) Token: 0x060004DC RID: 1244 RVA: 0x000291C4 File Offset: 0x000273C4
	// (set) Token: 0x060004DD RID: 1245 RVA: 0x00004BD8 File Offset: 0x00002DD8
	public unsafe GameObject m_PrefabCardGlowHalf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardGlowHalf);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardGlowHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001AC RID: 428
	// (get) Token: 0x060004DE RID: 1246 RVA: 0x000291F4 File Offset: 0x000273F4
	// (set) Token: 0x060004DF RID: 1247 RVA: 0x00004BF7 File Offset: 0x00002DF7
	public unsafe Il2CppStringArray m_CardSetNames
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_CardSetNames);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_CardSetNames), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001AD RID: 429
	// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00029224 File Offset: 0x00027424
	// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00004C16 File Offset: 0x00002E16
	public unsafe Il2CppStringArray m_CardSetTextSprites
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_CardSetTextSprites);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_CardSetTextSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001AE RID: 430
	// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00029254 File Offset: 0x00027454
	// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00004C35 File Offset: 0x00002E35
	public unsafe string m_CardRarityTextSprite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_CardRarityTextSprite);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_CardRarityTextSprite), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170001AF RID: 431
	// (get) Token: 0x060004E4 RID: 1252 RVA: 0x0002927C File Offset: 0x0002747C
	// (set) Token: 0x060004E5 RID: 1253 RVA: 0x00004C54 File Offset: 0x00002E54
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabBasicCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabBasicCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabBasicCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x060004E6 RID: 1254 RVA: 0x000292AC File Offset: 0x000274AC
	// (set) Token: 0x060004E7 RID: 1255 RVA: 0x00004C73 File Offset: 0x00002E73
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabSpecificCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabSpecificCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabSpecificCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x060004E8 RID: 1256 RVA: 0x000292DC File Offset: 0x000274DC
	// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00004C92 File Offset: 0x00002E92
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x060004EA RID: 1258 RVA: 0x0002930C File Offset: 0x0002750C
	// (set) Token: 0x060004EB RID: 1259 RVA: 0x00004CB1 File Offset: 0x00002EB1
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericFateCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericFateCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericFateCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x060004EC RID: 1260 RVA: 0x0002933C File Offset: 0x0002753C
	// (set) Token: 0x060004ED RID: 1261 RVA: 0x00004CD0 File Offset: 0x00002ED0
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericEnergyCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericEnergyCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericEnergyCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x060004EE RID: 1262 RVA: 0x0002936C File Offset: 0x0002756C
	// (set) Token: 0x060004EF RID: 1263 RVA: 0x00004CEF File Offset: 0x00002EEF
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericMultiFactionCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericMultiFactionCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericMultiFactionCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0002939C File Offset: 0x0002759C
	// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00004D0E File Offset: 0x00002F0E
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericTransformPreCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericTransformPreCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericTransformPreCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x060004F2 RID: 1266 RVA: 0x000293CC File Offset: 0x000275CC
	// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00004D2D File Offset: 0x00002F2D
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericTransformPostCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericTransformPostCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericTransformPostCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x060004F4 RID: 1268 RVA: 0x000293FC File Offset: 0x000275FC
	// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00004D4C File Offset: 0x00002F4C
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericDreamCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDreamCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDreamCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001B8 RID: 440
	// (get) Token: 0x060004F6 RID: 1270 RVA: 0x0002942C File Offset: 0x0002762C
	// (set) Token: 0x060004F7 RID: 1271 RVA: 0x00004D6B File Offset: 0x00002F6B
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericDreambornCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDreambornCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDreambornCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001B9 RID: 441
	// (get) Token: 0x060004F8 RID: 1272 RVA: 0x0002945C File Offset: 0x0002765C
	// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00004D8A File Offset: 0x00002F8A
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericDreambindCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDreambindCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDreambindCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001BA RID: 442
	// (get) Token: 0x060004FA RID: 1274 RVA: 0x0002948C File Offset: 0x0002768C
	// (set) Token: 0x060004FB RID: 1275 RVA: 0x00004DA9 File Offset: 0x00002FA9
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericAllFactionCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericAllFactionCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericAllFactionCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001BB RID: 443
	// (get) Token: 0x060004FC RID: 1276 RVA: 0x000294BC File Offset: 0x000276BC
	// (set) Token: 0x060004FD RID: 1277 RVA: 0x00004DC8 File Offset: 0x00002FC8
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericDayCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDayCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDayCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001BC RID: 444
	// (get) Token: 0x060004FE RID: 1278 RVA: 0x000294EC File Offset: 0x000276EC
	// (set) Token: 0x060004FF RID: 1279 RVA: 0x00004DE7 File Offset: 0x00002FE7
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericDayDualCostCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDayDualCostCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDayDualCostCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001BD RID: 445
	// (get) Token: 0x06000500 RID: 1280 RVA: 0x0002951C File Offset: 0x0002771C
	// (set) Token: 0x06000501 RID: 1281 RVA: 0x00004E06 File Offset: 0x00003006
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericNightCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericNightCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericNightCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001BE RID: 446
	// (get) Token: 0x06000502 RID: 1282 RVA: 0x0002954C File Offset: 0x0002774C
	// (set) Token: 0x06000503 RID: 1283 RVA: 0x00004E25 File Offset: 0x00003025
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericNightDualCostCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericNightDualCostCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericNightDualCostCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001BF RID: 447
	// (get) Token: 0x06000504 RID: 1284 RVA: 0x0002957C File Offset: 0x0002777C
	// (set) Token: 0x06000505 RID: 1285 RVA: 0x00004E44 File Offset: 0x00003044
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabEventCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabEventCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabEventCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001C0 RID: 448
	// (get) Token: 0x06000506 RID: 1286 RVA: 0x000295AC File Offset: 0x000277AC
	// (set) Token: 0x06000507 RID: 1287 RVA: 0x00004E63 File Offset: 0x00003063
	public unsafe GameObject m_PrefabTrophyMonster
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabTrophyMonster);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabTrophyMonster), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x06000508 RID: 1288 RVA: 0x000295DC File Offset: 0x000277DC
	// (set) Token: 0x06000509 RID: 1289 RVA: 0x00004E82 File Offset: 0x00003082
	public unsafe GameObject m_PrefabChampionHero
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabChampionHero);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabChampionHero), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001C2 RID: 450
	// (get) Token: 0x0600050A RID: 1290 RVA: 0x0002960C File Offset: 0x0002780C
	// (set) Token: 0x0600050B RID: 1291 RVA: 0x00004EA1 File Offset: 0x000030A1
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabChampionsHorizontal
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabChampionsHorizontal);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabChampionsHorizontal), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001C3 RID: 451
	// (get) Token: 0x0600050C RID: 1292 RVA: 0x0002963C File Offset: 0x0002783C
	// (set) Token: 0x0600050D RID: 1293 RVA: 0x00004EC0 File Offset: 0x000030C0
	public unsafe GameObject m_PrefabGoldBorder
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGoldBorder);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGoldBorder), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001C4 RID: 452
	// (get) Token: 0x0600050E RID: 1294 RVA: 0x0002966C File Offset: 0x0002786C
	// (set) Token: 0x0600050F RID: 1295 RVA: 0x00004EDF File Offset: 0x000030DF
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericCardsHalf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericCardsHalf);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericCardsHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001C5 RID: 453
	// (get) Token: 0x06000510 RID: 1296 RVA: 0x0002969C File Offset: 0x0002789C
	// (set) Token: 0x06000511 RID: 1297 RVA: 0x00004EFE File Offset: 0x000030FE
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericMultiFactionCardsHalf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericMultiFactionCardsHalf);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericMultiFactionCardsHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001C6 RID: 454
	// (get) Token: 0x06000512 RID: 1298 RVA: 0x000296CC File Offset: 0x000278CC
	// (set) Token: 0x06000513 RID: 1299 RVA: 0x00004F1D File Offset: 0x0000311D
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericTransformPreCardsHalf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericTransformPreCardsHalf);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericTransformPreCardsHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001C7 RID: 455
	// (get) Token: 0x06000514 RID: 1300 RVA: 0x000296FC File Offset: 0x000278FC
	// (set) Token: 0x06000515 RID: 1301 RVA: 0x00004F3C File Offset: 0x0000313C
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericTransformPostCardsHalf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericTransformPostCardsHalf);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericTransformPostCardsHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001C8 RID: 456
	// (get) Token: 0x06000516 RID: 1302 RVA: 0x0002972C File Offset: 0x0002792C
	// (set) Token: 0x06000517 RID: 1303 RVA: 0x00004F5B File Offset: 0x0000315B
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericDreamCardsHalf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDreamCardsHalf);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDreamCardsHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001C9 RID: 457
	// (get) Token: 0x06000518 RID: 1304 RVA: 0x0002975C File Offset: 0x0002795C
	// (set) Token: 0x06000519 RID: 1305 RVA: 0x00004F7A File Offset: 0x0000317A
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericDreambornCardsHalf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDreambornCardsHalf);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDreambornCardsHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001CA RID: 458
	// (get) Token: 0x0600051A RID: 1306 RVA: 0x0002978C File Offset: 0x0002798C
	// (set) Token: 0x0600051B RID: 1307 RVA: 0x00004F99 File Offset: 0x00003199
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericDreambindCardsHalf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDreambindCardsHalf);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDreambindCardsHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001CB RID: 459
	// (get) Token: 0x0600051C RID: 1308 RVA: 0x000297BC File Offset: 0x000279BC
	// (set) Token: 0x0600051D RID: 1309 RVA: 0x00004FB8 File Offset: 0x000031B8
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericAllFactionCardsHalf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericAllFactionCardsHalf);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericAllFactionCardsHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001CC RID: 460
	// (get) Token: 0x0600051E RID: 1310 RVA: 0x000297EC File Offset: 0x000279EC
	// (set) Token: 0x0600051F RID: 1311 RVA: 0x00004FD7 File Offset: 0x000031D7
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericDayCardsHalf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDayCardsHalf);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDayCardsHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001CD RID: 461
	// (get) Token: 0x06000520 RID: 1312 RVA: 0x0002981C File Offset: 0x00027A1C
	// (set) Token: 0x06000521 RID: 1313 RVA: 0x00004FF6 File Offset: 0x000031F6
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericDayDualCostCardsHalf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDayDualCostCardsHalf);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericDayDualCostCardsHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001CE RID: 462
	// (get) Token: 0x06000522 RID: 1314 RVA: 0x0002984C File Offset: 0x00027A4C
	// (set) Token: 0x06000523 RID: 1315 RVA: 0x00005015 File Offset: 0x00003215
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericNightCardsHalf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericNightCardsHalf);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericNightCardsHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001CF RID: 463
	// (get) Token: 0x06000524 RID: 1316 RVA: 0x0002987C File Offset: 0x00027A7C
	// (set) Token: 0x06000525 RID: 1317 RVA: 0x00005034 File Offset: 0x00003234
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabGenericNightDualCostCardsHalf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericNightDualCostCardsHalf);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGenericNightDualCostCardsHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001D0 RID: 464
	// (get) Token: 0x06000526 RID: 1318 RVA: 0x000298AC File Offset: 0x00027AAC
	// (set) Token: 0x06000527 RID: 1319 RVA: 0x00005053 File Offset: 0x00003253
	public unsafe GameObject m_PrefabTrophyMonsterHalf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabTrophyMonsterHalf);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabTrophyMonsterHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001D1 RID: 465
	// (get) Token: 0x06000528 RID: 1320 RVA: 0x000298DC File Offset: 0x00027ADC
	// (set) Token: 0x06000529 RID: 1321 RVA: 0x00005072 File Offset: 0x00003272
	public unsafe GameObject m_PrefabChampionHeroHalf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabChampionHeroHalf);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabChampionHeroHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001D2 RID: 466
	// (get) Token: 0x0600052A RID: 1322 RVA: 0x0002990C File Offset: 0x00027B0C
	// (set) Token: 0x0600052B RID: 1323 RVA: 0x00005091 File Offset: 0x00003291
	public unsafe GameObject m_PrefabGoldBorderHalf
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGoldBorderHalf);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabGoldBorderHalf), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001D3 RID: 467
	// (get) Token: 0x0600052C RID: 1324 RVA: 0x0002993C File Offset: 0x00027B3C
	// (set) Token: 0x0600052D RID: 1325 RVA: 0x000050B0 File Offset: 0x000032B0
	public unsafe GameObject m_PrefabCardCounter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardCounter);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardCounter), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001D4 RID: 468
	// (get) Token: 0x0600052E RID: 1326 RVA: 0x0002996C File Offset: 0x00027B6C
	// (set) Token: 0x0600052F RID: 1327 RVA: 0x000050CF File Offset: 0x000032CF
	public unsafe Il2CppReferenceArray<GameObject> m_PrefabCardOverlays
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardOverlays);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_PrefabCardOverlays), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001D5 RID: 469
	// (get) Token: 0x06000530 RID: 1328 RVA: 0x0002999C File Offset: 0x00027B9C
	// (set) Token: 0x06000531 RID: 1329 RVA: 0x000050EE File Offset: 0x000032EE
	public unsafe Il2CppReferenceArray<Sprite> m_SpritesCardFrame
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_SpritesCardFrame);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_SpritesCardFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001D6 RID: 470
	// (get) Token: 0x06000532 RID: 1330 RVA: 0x000299CC File Offset: 0x00027BCC
	// (set) Token: 0x06000533 RID: 1331 RVA: 0x0000510D File Offset: 0x0000330D
	public unsafe Il2CppReferenceArray<Sprite> m_SpritesCardFrameMultiFaction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_SpritesCardFrameMultiFaction);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_SpritesCardFrameMultiFaction), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001D7 RID: 471
	// (get) Token: 0x06000534 RID: 1332 RVA: 0x000299FC File Offset: 0x00027BFC
	// (set) Token: 0x06000535 RID: 1333 RVA: 0x0000512C File Offset: 0x0000332C
	public unsafe Il2CppReferenceArray<Sprite> m_SpritesCardFrameChampion
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_SpritesCardFrameChampion);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_SpritesCardFrameChampion), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001D8 RID: 472
	// (get) Token: 0x06000536 RID: 1334 RVA: 0x00029A2C File Offset: 0x00027C2C
	// (set) Token: 0x06000537 RID: 1335 RVA: 0x0000514B File Offset: 0x0000334B
	public unsafe Il2CppReferenceArray<Sprite> m_SpritesCardFrameDream
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_SpritesCardFrameDream);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_SpritesCardFrameDream), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001D9 RID: 473
	// (get) Token: 0x06000538 RID: 1336 RVA: 0x00029A5C File Offset: 0x00027C5C
	// (set) Token: 0x06000539 RID: 1337 RVA: 0x0000516A File Offset: 0x0000336A
	public unsafe Il2CppReferenceArray<Sprite> m_SpritesCardArt
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_SpritesCardArt);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_SpritesCardArt), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001DA RID: 474
	// (get) Token: 0x0600053A RID: 1338 RVA: 0x00029A8C File Offset: 0x00027C8C
	// (set) Token: 0x0600053B RID: 1339 RVA: 0x00005189 File Offset: 0x00003389
	public unsafe GameObject m_CardInPlayPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_CardInPlayPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_CardInPlayPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001DB RID: 475
	// (get) Token: 0x0600053C RID: 1340 RVA: 0x00029ABC File Offset: 0x00027CBC
	// (set) Token: 0x0600053D RID: 1341 RVA: 0x000051A8 File Offset: 0x000033A8
	public unsafe GameObject m_CardInPlayEventPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_CardInPlayEventPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_CardInPlayEventPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001DC RID: 476
	// (get) Token: 0x0600053E RID: 1342 RVA: 0x00029AEC File Offset: 0x00027CEC
	// (set) Token: 0x0600053F RID: 1343 RVA: 0x000051C7 File Offset: 0x000033C7
	public unsafe AscensionAnimationLocator m_CardLimbo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_CardLimbo);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_CardLimbo), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001DD RID: 477
	// (get) Token: 0x06000540 RID: 1344 RVA: 0x00029B1C File Offset: 0x00027D1C
	// (set) Token: 0x06000541 RID: 1345 RVA: 0x000051E6 File Offset: 0x000033E6
	public unsafe float m_DragCardScale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_DragCardScale);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_DragCardScale)) = value;
		}
	}

	// Token: 0x170001DE RID: 478
	// (get) Token: 0x06000542 RID: 1346 RVA: 0x00029B44 File Offset: 0x00027D44
	// (set) Token: 0x06000543 RID: 1347 RVA: 0x00005201 File Offset: 0x00003401
	public unsafe float m_DragCardTargetScale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_DragCardTargetScale);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_DragCardTargetScale)) = value;
		}
	}

	// Token: 0x170001DF RID: 479
	// (get) Token: 0x06000544 RID: 1348 RVA: 0x00029B6C File Offset: 0x00027D6C
	// (set) Token: 0x06000545 RID: 1349 RVA: 0x0000521C File Offset: 0x0000341C
	public unsafe ResourceManager m_ResourceManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_ResourceManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardManager.NativeFieldInfoPtr_m_ResourceManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040002E8 RID: 744
	private static readonly IntPtr NativeFieldInfoPtr_k_cardFlagFate;

	// Token: 0x040002E9 RID: 745
	private static readonly IntPtr NativeFieldInfoPtr_k_cardFlagTrophyMonster;

	// Token: 0x040002EA RID: 746
	private static readonly IntPtr NativeFieldInfoPtr_k_cardFlagEnergy;

	// Token: 0x040002EB RID: 747
	private static readonly IntPtr NativeFieldInfoPtr_k_cardFlagMultiFaction;

	// Token: 0x040002EC RID: 748
	private static readonly IntPtr NativeFieldInfoPtr_k_cardFlagTransformPre;

	// Token: 0x040002ED RID: 749
	private static readonly IntPtr NativeFieldInfoPtr_k_cardFlagTransformPost;

	// Token: 0x040002EE RID: 750
	private static readonly IntPtr NativeFieldInfoPtr_k_cardFlagDream;

	// Token: 0x040002EF RID: 751
	private static readonly IntPtr NativeFieldInfoPtr_k_cardFlagDreamborn;

	// Token: 0x040002F0 RID: 752
	private static readonly IntPtr NativeFieldInfoPtr_k_cardFlagDay;

	// Token: 0x040002F1 RID: 753
	private static readonly IntPtr NativeFieldInfoPtr_k_cardFlagNight;

	// Token: 0x040002F2 RID: 754
	private static readonly IntPtr NativeFieldInfoPtr_k_cardFlagDualCost;

	// Token: 0x040002F3 RID: 755
	private static readonly IntPtr NativeFieldInfoPtr_k_cardFlagChampionHero;

	// Token: 0x040002F4 RID: 756
	private static readonly IntPtr NativeFieldInfoPtr_k_cardFlagDreambind;

	// Token: 0x040002F5 RID: 757
	private static readonly IntPtr NativeFieldInfoPtr_k_cardFlagHasGoldBorder;

	// Token: 0x040002F6 RID: 758
	private static readonly IntPtr NativeFieldInfoPtr_k_cardFlagDoNotPutInVoid;

	// Token: 0x040002F7 RID: 759
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabCardBase;

	// Token: 0x040002F8 RID: 760
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabCardBack;

	// Token: 0x040002F9 RID: 761
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabCardBackHalf;

	// Token: 0x040002FA RID: 762
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabCardBackSoulGem;

	// Token: 0x040002FB RID: 763
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabCardBackSoulGemHalf;

	// Token: 0x040002FC RID: 764
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabCardGlow;

	// Token: 0x040002FD RID: 765
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabCardGlowHalf;

	// Token: 0x040002FE RID: 766
	private static readonly IntPtr NativeFieldInfoPtr_m_CardSetNames;

	// Token: 0x040002FF RID: 767
	private static readonly IntPtr NativeFieldInfoPtr_m_CardSetTextSprites;

	// Token: 0x04000300 RID: 768
	private static readonly IntPtr NativeFieldInfoPtr_m_CardRarityTextSprite;

	// Token: 0x04000301 RID: 769
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabBasicCards;

	// Token: 0x04000302 RID: 770
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabSpecificCards;

	// Token: 0x04000303 RID: 771
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericCards;

	// Token: 0x04000304 RID: 772
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericFateCards;

	// Token: 0x04000305 RID: 773
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericEnergyCards;

	// Token: 0x04000306 RID: 774
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericMultiFactionCards;

	// Token: 0x04000307 RID: 775
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericTransformPreCards;

	// Token: 0x04000308 RID: 776
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericTransformPostCards;

	// Token: 0x04000309 RID: 777
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericDreamCards;

	// Token: 0x0400030A RID: 778
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericDreambornCards;

	// Token: 0x0400030B RID: 779
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericDreambindCards;

	// Token: 0x0400030C RID: 780
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericAllFactionCards;

	// Token: 0x0400030D RID: 781
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericDayCards;

	// Token: 0x0400030E RID: 782
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericDayDualCostCards;

	// Token: 0x0400030F RID: 783
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericNightCards;

	// Token: 0x04000310 RID: 784
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericNightDualCostCards;

	// Token: 0x04000311 RID: 785
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabEventCards;

	// Token: 0x04000312 RID: 786
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabTrophyMonster;

	// Token: 0x04000313 RID: 787
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabChampionHero;

	// Token: 0x04000314 RID: 788
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabChampionsHorizontal;

	// Token: 0x04000315 RID: 789
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGoldBorder;

	// Token: 0x04000316 RID: 790
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericCardsHalf;

	// Token: 0x04000317 RID: 791
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericMultiFactionCardsHalf;

	// Token: 0x04000318 RID: 792
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericTransformPreCardsHalf;

	// Token: 0x04000319 RID: 793
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericTransformPostCardsHalf;

	// Token: 0x0400031A RID: 794
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericDreamCardsHalf;

	// Token: 0x0400031B RID: 795
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericDreambornCardsHalf;

	// Token: 0x0400031C RID: 796
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericDreambindCardsHalf;

	// Token: 0x0400031D RID: 797
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericAllFactionCardsHalf;

	// Token: 0x0400031E RID: 798
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericDayCardsHalf;

	// Token: 0x0400031F RID: 799
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericDayDualCostCardsHalf;

	// Token: 0x04000320 RID: 800
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericNightCardsHalf;

	// Token: 0x04000321 RID: 801
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGenericNightDualCostCardsHalf;

	// Token: 0x04000322 RID: 802
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabTrophyMonsterHalf;

	// Token: 0x04000323 RID: 803
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabChampionHeroHalf;

	// Token: 0x04000324 RID: 804
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabGoldBorderHalf;

	// Token: 0x04000325 RID: 805
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabCardCounter;

	// Token: 0x04000326 RID: 806
	private static readonly IntPtr NativeFieldInfoPtr_m_PrefabCardOverlays;

	// Token: 0x04000327 RID: 807
	private static readonly IntPtr NativeFieldInfoPtr_m_SpritesCardFrame;

	// Token: 0x04000328 RID: 808
	private static readonly IntPtr NativeFieldInfoPtr_m_SpritesCardFrameMultiFaction;

	// Token: 0x04000329 RID: 809
	private static readonly IntPtr NativeFieldInfoPtr_m_SpritesCardFrameChampion;

	// Token: 0x0400032A RID: 810
	private static readonly IntPtr NativeFieldInfoPtr_m_SpritesCardFrameDream;

	// Token: 0x0400032B RID: 811
	private static readonly IntPtr NativeFieldInfoPtr_m_SpritesCardArt;

	// Token: 0x0400032C RID: 812
	private static readonly IntPtr NativeFieldInfoPtr_m_CardInPlayPrefab;

	// Token: 0x0400032D RID: 813
	private static readonly IntPtr NativeFieldInfoPtr_m_CardInPlayEventPrefab;

	// Token: 0x0400032E RID: 814
	private static readonly IntPtr NativeFieldInfoPtr_m_CardLimbo;

	// Token: 0x0400032F RID: 815
	private static readonly IntPtr NativeFieldInfoPtr_m_DragCardScale;

	// Token: 0x04000330 RID: 816
	private static readonly IntPtr NativeFieldInfoPtr_m_DragCardTargetScale;

	// Token: 0x04000331 RID: 817
	private static readonly IntPtr NativeFieldInfoPtr_m_ResourceManager;

	// Token: 0x04000332 RID: 818
	private static readonly IntPtr NativeMethodInfoPtr_GetCardLimbo_Public_AscensionAnimationLocator_0;

	// Token: 0x04000333 RID: 819
	private static readonly IntPtr NativeMethodInfoPtr_GetDragCardScale_Public_Single_0;

	// Token: 0x04000334 RID: 820
	private static readonly IntPtr NativeMethodInfoPtr_GetDragCardTargetScale_Public_Single_0;

	// Token: 0x04000335 RID: 821
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000336 RID: 822
	private static readonly IntPtr NativeMethodInfoPtr_FindCardPrefabByName_Private_GameObject_String_0;

	// Token: 0x04000337 RID: 823
	private static readonly IntPtr NativeMethodInfoPtr_FindEventPrefabByName_Private_GameObject_String_0;

	// Token: 0x04000338 RID: 824
	private static readonly IntPtr NativeMethodInfoPtr_FindChampionPrefabByName_Private_GameObject_String_0;

	// Token: 0x04000339 RID: 825
	private static readonly IntPtr NativeMethodInfoPtr_FindSpriteCardFrameByName_Private_Sprite_String_0;

	// Token: 0x0400033A RID: 826
	private static readonly IntPtr NativeMethodInfoPtr_FindSpriteCardFrameMultiFactionByName_Private_Sprite_String_0;

	// Token: 0x0400033B RID: 827
	private static readonly IntPtr NativeMethodInfoPtr_FindSpriteCardFrameChampionByName_Private_Sprite_String_0;

	// Token: 0x0400033C RID: 828
	private static readonly IntPtr NativeMethodInfoPtr_FindSpriteCardFrameDreamByName_Private_Sprite_String_0;

	// Token: 0x0400033D RID: 829
	private static readonly IntPtr NativeMethodInfoPtr_FindSpriteCardArtByName_Private_ResourceEntry_String_0;

	// Token: 0x0400033E RID: 830
	private static readonly IntPtr NativeMethodInfoPtr_GetCardImagePath_Public_String_Int32_String_0;

	// Token: 0x0400033F RID: 831
	private static readonly IntPtr NativeMethodInfoPtr_GetPrefabCardCounter_Public_GameObject_0;

	// Token: 0x04000340 RID: 832
	private static readonly IntPtr NativeMethodInfoPtr_CreateCardFromInstanceID_Public_Virtual_GameObject_Int32_Boolean_0;

	// Token: 0x04000341 RID: 833
	private static readonly IntPtr NativeMethodInfoPtr_CreateCardFromName_Public_GameObject_String_Boolean_Boolean_0;

	// Token: 0x04000342 RID: 834
	private static readonly IntPtr NativeMethodInfoPtr_CreateCard_Private_GameObject_CardData_Int32_Boolean_Boolean_0;

	// Token: 0x04000343 RID: 835
	private static readonly IntPtr NativeMethodInfoPtr_CreateCardInPlay_Public_AscensionCardInPlay_Int32_Boolean_0;

	// Token: 0x04000344 RID: 836
	private static readonly IntPtr NativeMethodInfoPtr_PlaceCardInCardLimbo_Public_Boolean_AscensionCard_0;

	// Token: 0x04000345 RID: 837
	private static readonly IntPtr NativeMethodInfoPtr_PlaceAllCardsInLimbo_Public_Void_0;

	// Token: 0x04000346 RID: 838
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

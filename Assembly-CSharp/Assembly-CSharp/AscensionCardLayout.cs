using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200001B RID: 27
public class AscensionCardLayout : MonoBehaviour
{
	// Token: 0x0600043E RID: 1086 RVA: 0x00026EF4 File Offset: 0x000250F4
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionCardLayout()
	{
		Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionCardLayout");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr);
		AscensionCardLayout.NativeFieldInfoPtr_m_CardArt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardArt");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardFrameTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardFrameTop");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardFrameBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardFrameBottom");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardTextName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardTextName");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardTextNameFirstLetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardTextNameFirstLetter");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardTextType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardTextType");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardTextRuneCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardTextRuneCost");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardRuneCostGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardRuneCostGlow");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardTextPowerCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardTextPowerCost");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardPowerCostGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardPowerCostGlow");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardTextInsightCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardTextInsightCost");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardInsightCostGlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardInsightCostGlow");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardTextHonorValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardTextHonorValue");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardTextEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardTextEffect");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardTextFateEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardTextFateEffect");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardTextEnergizeEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardTextEnergizeEffect");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardTextTrophyEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardTextTrophyEffect");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardTextDayDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardTextDayDisplay");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardTextDayEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardTextDayEffect");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardGlowDayDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardGlowDayDisplay");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardTextNightDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardTextNightDisplay");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardTextNightEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardTextNightEffect");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardGlowNightDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardGlowNightDisplay");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardTextSetPlusRarityIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardTextSetPlusRarityIndicator");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardTextFlavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardTextFlavor");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardFactionEmblem_Enlightened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardFactionEmblem_Enlightened");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardFactionEmblem_Lifebound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardFactionEmblem_Lifebound");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardFactionEmblem_Mechana = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardFactionEmblem_Mechana");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardFactionEmblem_Void = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardFactionEmblem_Void");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardGlow_EnergizeBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardGlow_EnergizeBox");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardGlow_PlayedCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardGlow_PlayedCard");
		AscensionCardLayout.NativeFieldInfoPtr_m_CardGlow_PlayedCardImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, "m_CardGlow_PlayedCardImage");
		AscensionCardLayout.NativeMethodInfoPtr_MergeGoldBorder_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663601);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardImage_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663602);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardFrameTop_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663603);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardFrameBottom_Public_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663604);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardTitle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663605);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardTypeText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663606);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardRuneCost_Public_Void_Int16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663607);
		AscensionCardLayout.NativeMethodInfoPtr_SetRuneCostGlowVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663608);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardPowerCost_Public_Void_Int16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663609);
		AscensionCardLayout.NativeMethodInfoPtr_SetPowerCostGlowVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663610);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardInsightCost_Public_Void_Int16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663611);
		AscensionCardLayout.NativeMethodInfoPtr_SetInsightCostGlowVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663612);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardFactionEmblems_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663613);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardEnergizeGlowVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663614);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardDayGlowVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663615);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardNightGlowVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663616);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardHonorValue_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663617);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardTextEffect_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663618);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardTextFateEffect_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663619);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardTextEnergizeEffect_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663620);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardTextTrophyEffect_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663621);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardTextDayEffect_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663622);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardTextNightEffect_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663623);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardTextSetPlusRarityIndicator_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663624);
		AscensionCardLayout.NativeMethodInfoPtr_SetCardTextFlavor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663625);
		AscensionCardLayout.NativeMethodInfoPtr_SetPlayedCardEffect_Public_Boolean_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663626);
		AscensionCardLayout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr, 100663627);
	}

	// Token: 0x0600043F RID: 1087 RVA: 0x000273C0 File Offset: 0x000255C0
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 227830, RefRangeEnd = 227834, XrefRangeStart = 227821, XrefRangeEnd = 227830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MergeGoldBorder(GameObject goldBorderObj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(goldBorderObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_MergeGoldBorder_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x00027404 File Offset: 0x00025604
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 227839, RefRangeEnd = 227844, XrefRangeStart = 227834, XrefRangeEnd = 227839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardImage(Sprite cardImage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardImage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardImage_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x00027448 File Offset: 0x00025648
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 227849, RefRangeEnd = 227853, XrefRangeStart = 227844, XrefRangeEnd = 227849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardFrameTop(Sprite sprite_frame_top)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite_frame_top);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardFrameTop_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x0002748C File Offset: 0x0002568C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 227858, RefRangeEnd = 227862, XrefRangeStart = 227853, XrefRangeEnd = 227858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardFrameBottom(Sprite sprite_frame_bottom)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite_frame_bottom);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardFrameBottom_Public_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x000274D0 File Offset: 0x000256D0
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 227873, RefRangeEnd = 227877, XrefRangeStart = 227862, XrefRangeEnd = 227873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTitle(string card_title)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_title);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardTitle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x00027514 File Offset: 0x00025714
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 227882, RefRangeEnd = 227886, XrefRangeStart = 227877, XrefRangeEnd = 227882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTypeText(string card_type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardTypeText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x00027558 File Offset: 0x00025758
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 227892, RefRangeEnd = 227898, XrefRangeStart = 227886, XrefRangeEnd = 227892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardRuneCost(short card_rune_cost, bool bAllowZero = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref card_rune_cost;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAllowZero;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardRuneCost_Public_Void_Int16_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x000275A4 File Offset: 0x000257A4
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 227903, RefRangeEnd = 227909, XrefRangeStart = 227898, XrefRangeEnd = 227903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRuneCostGlowVisible(bool bvisible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bvisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetRuneCostGlowVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x000275E4 File Offset: 0x000257E4
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 227915, RefRangeEnd = 227921, XrefRangeStart = 227909, XrefRangeEnd = 227915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardPowerCost(short card_power_cost, bool bAllowZero = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref card_power_cost;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAllowZero;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardPowerCost_Public_Void_Int16_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x00027630 File Offset: 0x00025830
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 227926, RefRangeEnd = 227932, XrefRangeStart = 227921, XrefRangeEnd = 227926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPowerCostGlowVisible(bool bvisible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bvisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetPowerCostGlowVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000449 RID: 1097 RVA: 0x00027670 File Offset: 0x00025870
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 227938, RefRangeEnd = 227946, XrefRangeStart = 227932, XrefRangeEnd = 227938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardInsightCost(short card_insight_cost, bool bAllowZero = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref card_insight_cost;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAllowZero;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardInsightCost_Public_Void_Int16_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x000276BC File Offset: 0x000258BC
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 227951, RefRangeEnd = 227955, XrefRangeStart = 227946, XrefRangeEnd = 227951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInsightCostGlowVisible(bool bvisible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bvisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetInsightCostGlowVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x000276FC File Offset: 0x000258FC
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 227972, RefRangeEnd = 227976, XrefRangeStart = 227955, XrefRangeEnd = 227972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardFactionEmblems(uint faction_flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref faction_flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardFactionEmblems_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x0002773C File Offset: 0x0002593C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 227981, RefRangeEnd = 227983, XrefRangeStart = 227976, XrefRangeEnd = 227981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardEnergizeGlowVisible(bool bVisible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardEnergizeGlowVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600044D RID: 1101 RVA: 0x0002777C File Offset: 0x0002597C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 227988, RefRangeEnd = 227990, XrefRangeStart = 227983, XrefRangeEnd = 227988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardDayGlowVisible(bool bvisible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bvisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardDayGlowVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x000277BC File Offset: 0x000259BC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 227995, RefRangeEnd = 227997, XrefRangeStart = 227990, XrefRangeEnd = 227995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardNightGlowVisible(bool bvisible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bvisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardNightGlowVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x000277FC File Offset: 0x000259FC
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 228013, RefRangeEnd = 228017, XrefRangeStart = 227997, XrefRangeEnd = 228013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardHonorValue(short card_honor_value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref card_honor_value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardHonorValue_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x0002783C File Offset: 0x00025A3C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 228022, RefRangeEnd = 228026, XrefRangeStart = 228017, XrefRangeEnd = 228022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTextEffect(string card_effect_text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_effect_text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardTextEffect_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x00027880 File Offset: 0x00025A80
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 228031, RefRangeEnd = 228035, XrefRangeStart = 228026, XrefRangeEnd = 228031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTextFateEffect(string card_fate_effect_text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_fate_effect_text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardTextFateEffect_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x000278C4 File Offset: 0x00025AC4
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 228040, RefRangeEnd = 228044, XrefRangeStart = 228035, XrefRangeEnd = 228040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTextEnergizeEffect(string card_energize_effect_text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_energize_effect_text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardTextEnergizeEffect_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x00027908 File Offset: 0x00025B08
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 228049, RefRangeEnd = 228053, XrefRangeStart = 228044, XrefRangeEnd = 228049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTextTrophyEffect(string card_trophy_effect_text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_trophy_effect_text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardTextTrophyEffect_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x0002794C File Offset: 0x00025B4C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 228064, RefRangeEnd = 228066, XrefRangeStart = 228053, XrefRangeEnd = 228064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTextDayEffect(string card_day_effect_text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_day_effect_text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardTextDayEffect_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000455 RID: 1109 RVA: 0x00027990 File Offset: 0x00025B90
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 228077, RefRangeEnd = 228079, XrefRangeStart = 228066, XrefRangeEnd = 228077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTextNightEffect(string card_night_effect_text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_night_effect_text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardTextNightEffect_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x000279D4 File Offset: 0x00025BD4
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 228084, RefRangeEnd = 228088, XrefRangeStart = 228079, XrefRangeEnd = 228084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTextSetPlusRarityIndicator(string card_set_plus_rarity_text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_set_plus_rarity_text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardTextSetPlusRarityIndicator_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x00027A18 File Offset: 0x00025C18
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 228096, RefRangeEnd = 228100, XrefRangeStart = 228088, XrefRangeEnd = 228096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTextFlavor(string card_flavor_text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_flavor_text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetCardTextFlavor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x00027A5C File Offset: 0x00025C5C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 228109, RefRangeEnd = 228111, XrefRangeStart = 228100, XrefRangeEnd = 228109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetPlayedCardEffect(bool bActive, Color glowColor)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr_SetPlayedCardEffect_Public_Boolean_Boolean_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x00027AB4 File Offset: 0x00025CB4
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionCardLayout()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionCardLayout>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardLayout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600045A RID: 1114 RVA: 0x0000465A File Offset: 0x0000285A
	public AscensionCardLayout(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000176 RID: 374
	// (get) Token: 0x0600045B RID: 1115 RVA: 0x00027AF0 File Offset: 0x00025CF0
	// (set) Token: 0x0600045C RID: 1116 RVA: 0x00004663 File Offset: 0x00002863
	public unsafe Image m_CardArt
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardArt);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardArt), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000177 RID: 375
	// (get) Token: 0x0600045D RID: 1117 RVA: 0x00027B20 File Offset: 0x00025D20
	// (set) Token: 0x0600045E RID: 1118 RVA: 0x00004682 File Offset: 0x00002882
	public unsafe Image m_CardFrameTop
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardFrameTop);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardFrameTop), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000178 RID: 376
	// (get) Token: 0x0600045F RID: 1119 RVA: 0x00027B50 File Offset: 0x00025D50
	// (set) Token: 0x06000460 RID: 1120 RVA: 0x000046A1 File Offset: 0x000028A1
	public unsafe Image m_CardFrameBottom
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardFrameBottom);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardFrameBottom), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000179 RID: 377
	// (get) Token: 0x06000461 RID: 1121 RVA: 0x00027B80 File Offset: 0x00025D80
	// (set) Token: 0x06000462 RID: 1122 RVA: 0x000046C0 File Offset: 0x000028C0
	public unsafe TextMeshProUGUI m_CardTextName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextName);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextName), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700017A RID: 378
	// (get) Token: 0x06000463 RID: 1123 RVA: 0x00027BB0 File Offset: 0x00025DB0
	// (set) Token: 0x06000464 RID: 1124 RVA: 0x000046DF File Offset: 0x000028DF
	public unsafe TextMeshProUGUI m_CardTextNameFirstLetter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextNameFirstLetter);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextNameFirstLetter), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700017B RID: 379
	// (get) Token: 0x06000465 RID: 1125 RVA: 0x00027BE0 File Offset: 0x00025DE0
	// (set) Token: 0x06000466 RID: 1126 RVA: 0x000046FE File Offset: 0x000028FE
	public unsafe TextMeshProUGUI m_CardTextType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextType);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextType), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700017C RID: 380
	// (get) Token: 0x06000467 RID: 1127 RVA: 0x00027C10 File Offset: 0x00025E10
	// (set) Token: 0x06000468 RID: 1128 RVA: 0x0000471D File Offset: 0x0000291D
	public unsafe TextMeshProUGUI m_CardTextRuneCost
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextRuneCost);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextRuneCost), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700017D RID: 381
	// (get) Token: 0x06000469 RID: 1129 RVA: 0x00027C40 File Offset: 0x00025E40
	// (set) Token: 0x0600046A RID: 1130 RVA: 0x0000473C File Offset: 0x0000293C
	public unsafe GameObject m_CardRuneCostGlow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardRuneCostGlow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardRuneCostGlow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700017E RID: 382
	// (get) Token: 0x0600046B RID: 1131 RVA: 0x00027C70 File Offset: 0x00025E70
	// (set) Token: 0x0600046C RID: 1132 RVA: 0x0000475B File Offset: 0x0000295B
	public unsafe TextMeshProUGUI m_CardTextPowerCost
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextPowerCost);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextPowerCost), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x0600046D RID: 1133 RVA: 0x00027CA0 File Offset: 0x00025EA0
	// (set) Token: 0x0600046E RID: 1134 RVA: 0x0000477A File Offset: 0x0000297A
	public unsafe GameObject m_CardPowerCostGlow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardPowerCostGlow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardPowerCostGlow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000180 RID: 384
	// (get) Token: 0x0600046F RID: 1135 RVA: 0x00027CD0 File Offset: 0x00025ED0
	// (set) Token: 0x06000470 RID: 1136 RVA: 0x00004799 File Offset: 0x00002999
	public unsafe TextMeshProUGUI m_CardTextInsightCost
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextInsightCost);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextInsightCost), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000181 RID: 385
	// (get) Token: 0x06000471 RID: 1137 RVA: 0x00027D00 File Offset: 0x00025F00
	// (set) Token: 0x06000472 RID: 1138 RVA: 0x000047B8 File Offset: 0x000029B8
	public unsafe GameObject m_CardInsightCostGlow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardInsightCostGlow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardInsightCostGlow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000182 RID: 386
	// (get) Token: 0x06000473 RID: 1139 RVA: 0x00027D30 File Offset: 0x00025F30
	// (set) Token: 0x06000474 RID: 1140 RVA: 0x000047D7 File Offset: 0x000029D7
	public unsafe TextMeshProUGUI m_CardTextHonorValue
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextHonorValue);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextHonorValue), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000183 RID: 387
	// (get) Token: 0x06000475 RID: 1141 RVA: 0x00027D60 File Offset: 0x00025F60
	// (set) Token: 0x06000476 RID: 1142 RVA: 0x000047F6 File Offset: 0x000029F6
	public unsafe TextMeshProUGUI m_CardTextEffect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextEffect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x06000477 RID: 1143 RVA: 0x00027D90 File Offset: 0x00025F90
	// (set) Token: 0x06000478 RID: 1144 RVA: 0x00004815 File Offset: 0x00002A15
	public unsafe TextMeshProUGUI m_CardTextFateEffect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextFateEffect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextFateEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000185 RID: 389
	// (get) Token: 0x06000479 RID: 1145 RVA: 0x00027DC0 File Offset: 0x00025FC0
	// (set) Token: 0x0600047A RID: 1146 RVA: 0x00004834 File Offset: 0x00002A34
	public unsafe TextMeshProUGUI m_CardTextEnergizeEffect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextEnergizeEffect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextEnergizeEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000186 RID: 390
	// (get) Token: 0x0600047B RID: 1147 RVA: 0x00027DF0 File Offset: 0x00025FF0
	// (set) Token: 0x0600047C RID: 1148 RVA: 0x00004853 File Offset: 0x00002A53
	public unsafe TextMeshProUGUI m_CardTextTrophyEffect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextTrophyEffect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextTrophyEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000187 RID: 391
	// (get) Token: 0x0600047D RID: 1149 RVA: 0x00027E20 File Offset: 0x00026020
	// (set) Token: 0x0600047E RID: 1150 RVA: 0x00004872 File Offset: 0x00002A72
	public unsafe GameObject m_CardTextDayDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextDayDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextDayDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000188 RID: 392
	// (get) Token: 0x0600047F RID: 1151 RVA: 0x00027E50 File Offset: 0x00026050
	// (set) Token: 0x06000480 RID: 1152 RVA: 0x00004891 File Offset: 0x00002A91
	public unsafe TextMeshProUGUI m_CardTextDayEffect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextDayEffect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextDayEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x06000481 RID: 1153 RVA: 0x00027E80 File Offset: 0x00026080
	// (set) Token: 0x06000482 RID: 1154 RVA: 0x000048B0 File Offset: 0x00002AB0
	public unsafe GameObject m_CardGlowDayDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardGlowDayDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardGlowDayDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700018A RID: 394
	// (get) Token: 0x06000483 RID: 1155 RVA: 0x00027EB0 File Offset: 0x000260B0
	// (set) Token: 0x06000484 RID: 1156 RVA: 0x000048CF File Offset: 0x00002ACF
	public unsafe GameObject m_CardTextNightDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextNightDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextNightDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700018B RID: 395
	// (get) Token: 0x06000485 RID: 1157 RVA: 0x00027EE0 File Offset: 0x000260E0
	// (set) Token: 0x06000486 RID: 1158 RVA: 0x000048EE File Offset: 0x00002AEE
	public unsafe TextMeshProUGUI m_CardTextNightEffect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextNightEffect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextNightEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700018C RID: 396
	// (get) Token: 0x06000487 RID: 1159 RVA: 0x00027F10 File Offset: 0x00026110
	// (set) Token: 0x06000488 RID: 1160 RVA: 0x0000490D File Offset: 0x00002B0D
	public unsafe GameObject m_CardGlowNightDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardGlowNightDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardGlowNightDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x06000489 RID: 1161 RVA: 0x00027F40 File Offset: 0x00026140
	// (set) Token: 0x0600048A RID: 1162 RVA: 0x0000492C File Offset: 0x00002B2C
	public unsafe TextMeshProUGUI m_CardTextSetPlusRarityIndicator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextSetPlusRarityIndicator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextSetPlusRarityIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x0600048B RID: 1163 RVA: 0x00027F70 File Offset: 0x00026170
	// (set) Token: 0x0600048C RID: 1164 RVA: 0x0000494B File Offset: 0x00002B4B
	public unsafe TextMeshProUGUI m_CardTextFlavor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextFlavor);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardTextFlavor), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700018F RID: 399
	// (get) Token: 0x0600048D RID: 1165 RVA: 0x00027FA0 File Offset: 0x000261A0
	// (set) Token: 0x0600048E RID: 1166 RVA: 0x0000496A File Offset: 0x00002B6A
	public unsafe GameObject m_CardFactionEmblem_Enlightened
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardFactionEmblem_Enlightened);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardFactionEmblem_Enlightened), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000190 RID: 400
	// (get) Token: 0x0600048F RID: 1167 RVA: 0x00027FD0 File Offset: 0x000261D0
	// (set) Token: 0x06000490 RID: 1168 RVA: 0x00004989 File Offset: 0x00002B89
	public unsafe GameObject m_CardFactionEmblem_Lifebound
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardFactionEmblem_Lifebound);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardFactionEmblem_Lifebound), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x06000491 RID: 1169 RVA: 0x00028000 File Offset: 0x00026200
	// (set) Token: 0x06000492 RID: 1170 RVA: 0x000049A8 File Offset: 0x00002BA8
	public unsafe GameObject m_CardFactionEmblem_Mechana
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardFactionEmblem_Mechana);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardFactionEmblem_Mechana), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x06000493 RID: 1171 RVA: 0x00028030 File Offset: 0x00026230
	// (set) Token: 0x06000494 RID: 1172 RVA: 0x000049C7 File Offset: 0x00002BC7
	public unsafe GameObject m_CardFactionEmblem_Void
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardFactionEmblem_Void);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardFactionEmblem_Void), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x06000495 RID: 1173 RVA: 0x00028060 File Offset: 0x00026260
	// (set) Token: 0x06000496 RID: 1174 RVA: 0x000049E6 File Offset: 0x00002BE6
	public unsafe GameObject m_CardGlow_EnergizeBox
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardGlow_EnergizeBox);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardGlow_EnergizeBox), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x06000497 RID: 1175 RVA: 0x00028090 File Offset: 0x00026290
	// (set) Token: 0x06000498 RID: 1176 RVA: 0x00004A05 File Offset: 0x00002C05
	public unsafe GameObject m_CardGlow_PlayedCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardGlow_PlayedCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardGlow_PlayedCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x06000499 RID: 1177 RVA: 0x000280C0 File Offset: 0x000262C0
	// (set) Token: 0x0600049A RID: 1178 RVA: 0x00004A24 File Offset: 0x00002C24
	public unsafe Image m_CardGlow_PlayedCardImage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardGlow_PlayedCardImage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardLayout.NativeFieldInfoPtr_m_CardGlow_PlayedCardImage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040002AD RID: 685
	private static readonly IntPtr NativeFieldInfoPtr_m_CardArt;

	// Token: 0x040002AE RID: 686
	private static readonly IntPtr NativeFieldInfoPtr_m_CardFrameTop;

	// Token: 0x040002AF RID: 687
	private static readonly IntPtr NativeFieldInfoPtr_m_CardFrameBottom;

	// Token: 0x040002B0 RID: 688
	private static readonly IntPtr NativeFieldInfoPtr_m_CardTextName;

	// Token: 0x040002B1 RID: 689
	private static readonly IntPtr NativeFieldInfoPtr_m_CardTextNameFirstLetter;

	// Token: 0x040002B2 RID: 690
	private static readonly IntPtr NativeFieldInfoPtr_m_CardTextType;

	// Token: 0x040002B3 RID: 691
	private static readonly IntPtr NativeFieldInfoPtr_m_CardTextRuneCost;

	// Token: 0x040002B4 RID: 692
	private static readonly IntPtr NativeFieldInfoPtr_m_CardRuneCostGlow;

	// Token: 0x040002B5 RID: 693
	private static readonly IntPtr NativeFieldInfoPtr_m_CardTextPowerCost;

	// Token: 0x040002B6 RID: 694
	private static readonly IntPtr NativeFieldInfoPtr_m_CardPowerCostGlow;

	// Token: 0x040002B7 RID: 695
	private static readonly IntPtr NativeFieldInfoPtr_m_CardTextInsightCost;

	// Token: 0x040002B8 RID: 696
	private static readonly IntPtr NativeFieldInfoPtr_m_CardInsightCostGlow;

	// Token: 0x040002B9 RID: 697
	private static readonly IntPtr NativeFieldInfoPtr_m_CardTextHonorValue;

	// Token: 0x040002BA RID: 698
	private static readonly IntPtr NativeFieldInfoPtr_m_CardTextEffect;

	// Token: 0x040002BB RID: 699
	private static readonly IntPtr NativeFieldInfoPtr_m_CardTextFateEffect;

	// Token: 0x040002BC RID: 700
	private static readonly IntPtr NativeFieldInfoPtr_m_CardTextEnergizeEffect;

	// Token: 0x040002BD RID: 701
	private static readonly IntPtr NativeFieldInfoPtr_m_CardTextTrophyEffect;

	// Token: 0x040002BE RID: 702
	private static readonly IntPtr NativeFieldInfoPtr_m_CardTextDayDisplay;

	// Token: 0x040002BF RID: 703
	private static readonly IntPtr NativeFieldInfoPtr_m_CardTextDayEffect;

	// Token: 0x040002C0 RID: 704
	private static readonly IntPtr NativeFieldInfoPtr_m_CardGlowDayDisplay;

	// Token: 0x040002C1 RID: 705
	private static readonly IntPtr NativeFieldInfoPtr_m_CardTextNightDisplay;

	// Token: 0x040002C2 RID: 706
	private static readonly IntPtr NativeFieldInfoPtr_m_CardTextNightEffect;

	// Token: 0x040002C3 RID: 707
	private static readonly IntPtr NativeFieldInfoPtr_m_CardGlowNightDisplay;

	// Token: 0x040002C4 RID: 708
	private static readonly IntPtr NativeFieldInfoPtr_m_CardTextSetPlusRarityIndicator;

	// Token: 0x040002C5 RID: 709
	private static readonly IntPtr NativeFieldInfoPtr_m_CardTextFlavor;

	// Token: 0x040002C6 RID: 710
	private static readonly IntPtr NativeFieldInfoPtr_m_CardFactionEmblem_Enlightened;

	// Token: 0x040002C7 RID: 711
	private static readonly IntPtr NativeFieldInfoPtr_m_CardFactionEmblem_Lifebound;

	// Token: 0x040002C8 RID: 712
	private static readonly IntPtr NativeFieldInfoPtr_m_CardFactionEmblem_Mechana;

	// Token: 0x040002C9 RID: 713
	private static readonly IntPtr NativeFieldInfoPtr_m_CardFactionEmblem_Void;

	// Token: 0x040002CA RID: 714
	private static readonly IntPtr NativeFieldInfoPtr_m_CardGlow_EnergizeBox;

	// Token: 0x040002CB RID: 715
	private static readonly IntPtr NativeFieldInfoPtr_m_CardGlow_PlayedCard;

	// Token: 0x040002CC RID: 716
	private static readonly IntPtr NativeFieldInfoPtr_m_CardGlow_PlayedCardImage;

	// Token: 0x040002CD RID: 717
	private static readonly IntPtr NativeMethodInfoPtr_MergeGoldBorder_Public_Void_GameObject_0;

	// Token: 0x040002CE RID: 718
	private static readonly IntPtr NativeMethodInfoPtr_SetCardImage_Public_Void_Sprite_0;

	// Token: 0x040002CF RID: 719
	private static readonly IntPtr NativeMethodInfoPtr_SetCardFrameTop_Public_Void_Sprite_0;

	// Token: 0x040002D0 RID: 720
	private static readonly IntPtr NativeMethodInfoPtr_SetCardFrameBottom_Public_Void_Sprite_0;

	// Token: 0x040002D1 RID: 721
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTitle_Public_Void_String_0;

	// Token: 0x040002D2 RID: 722
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTypeText_Public_Void_String_0;

	// Token: 0x040002D3 RID: 723
	private static readonly IntPtr NativeMethodInfoPtr_SetCardRuneCost_Public_Void_Int16_Boolean_0;

	// Token: 0x040002D4 RID: 724
	private static readonly IntPtr NativeMethodInfoPtr_SetRuneCostGlowVisible_Public_Void_Boolean_0;

	// Token: 0x040002D5 RID: 725
	private static readonly IntPtr NativeMethodInfoPtr_SetCardPowerCost_Public_Void_Int16_Boolean_0;

	// Token: 0x040002D6 RID: 726
	private static readonly IntPtr NativeMethodInfoPtr_SetPowerCostGlowVisible_Public_Void_Boolean_0;

	// Token: 0x040002D7 RID: 727
	private static readonly IntPtr NativeMethodInfoPtr_SetCardInsightCost_Public_Void_Int16_Boolean_0;

	// Token: 0x040002D8 RID: 728
	private static readonly IntPtr NativeMethodInfoPtr_SetInsightCostGlowVisible_Public_Void_Boolean_0;

	// Token: 0x040002D9 RID: 729
	private static readonly IntPtr NativeMethodInfoPtr_SetCardFactionEmblems_Public_Void_UInt32_0;

	// Token: 0x040002DA RID: 730
	private static readonly IntPtr NativeMethodInfoPtr_SetCardEnergizeGlowVisible_Public_Void_Boolean_0;

	// Token: 0x040002DB RID: 731
	private static readonly IntPtr NativeMethodInfoPtr_SetCardDayGlowVisible_Public_Void_Boolean_0;

	// Token: 0x040002DC RID: 732
	private static readonly IntPtr NativeMethodInfoPtr_SetCardNightGlowVisible_Public_Void_Boolean_0;

	// Token: 0x040002DD RID: 733
	private static readonly IntPtr NativeMethodInfoPtr_SetCardHonorValue_Public_Void_Int16_0;

	// Token: 0x040002DE RID: 734
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTextEffect_Public_Void_String_0;

	// Token: 0x040002DF RID: 735
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTextFateEffect_Public_Void_String_0;

	// Token: 0x040002E0 RID: 736
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTextEnergizeEffect_Public_Void_String_0;

	// Token: 0x040002E1 RID: 737
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTextTrophyEffect_Public_Void_String_0;

	// Token: 0x040002E2 RID: 738
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTextDayEffect_Public_Void_String_0;

	// Token: 0x040002E3 RID: 739
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTextNightEffect_Public_Void_String_0;

	// Token: 0x040002E4 RID: 740
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTextSetPlusRarityIndicator_Public_Void_String_0;

	// Token: 0x040002E5 RID: 741
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTextFlavor_Public_Void_String_0;

	// Token: 0x040002E6 RID: 742
	private static readonly IntPtr NativeMethodInfoPtr_SetPlayedCardEffect_Public_Boolean_Boolean_Color_0;

	// Token: 0x040002E7 RID: 743
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000011 RID: 17
public class AscensionAnimationLocatorPlayedCards : AscensionAnimationLocator
{
	// Token: 0x0600015D RID: 349 RVA: 0x0001EC74 File Offset: 0x0001CE74
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionAnimationLocatorPlayedCards()
	{
		Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionAnimationLocatorPlayedCards");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr);
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectCopy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "k_playedCardEffectCopy");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectBanish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "k_playedCardEffectBanish");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "k_playedCardEffectTransform");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectEnergized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "k_playedCardEffectEnergized");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectKeepInHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "k_playedCardEffectKeepInHand");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectVision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "k_playedCardEffectVision");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "k_playedCardEffectActive");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectDiscarded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "k_playedCardEffectDiscarded");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "k_playedCardEffectDay");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "k_playedCardEffectNight");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectPhantasm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "k_playedCardEffectPhantasm");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_CardManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "m_CardManager");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "m_scrollRect");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_layoutController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "m_layoutController");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_playedCardRightJustifyThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "m_playedCardRightJustifyThreshold");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_PlayedCardEntryList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "m_PlayedCardEntryList");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_PlayedCardPlaceholderList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "m_PlayedCardPlaceholderList");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_PlayedCardEntryListCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "m_PlayedCardEntryListCapacity");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_PlayedCardEntryListCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "m_PlayedCardEntryListCount");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_QueryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "m_QueryBuffer");
		AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_DefaultPlayedCardEntryListCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "m_DefaultPlayedCardEntryListCapacity");
		AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, 100663411);
		AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_CreatePlayedCardPlaceholder_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, 100663412);
		AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_HasPlayedCardPlaceholder_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, 100663413);
		AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_ResetPlayedCardEntryList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, 100663414);
		AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_RebuildPlayedCardEntryList_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, 100663415);
		AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_AddPlayedCardEntry_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, 100663416);
		AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_UpdatePlayedCardEntry_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, 100663417);
		AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_RemovePlayedCardEntry_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, 100663418);
		AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_UpdateHorizontalController_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, 100663419);
		AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_UpdatePlayedCardFromFlags_Private_Void_AscensionCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, 100663420);
		AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, 100663421);
		AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_UpdateAllPlayedCardsFromFlags_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, 100663422);
		AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_CalculateInsertSiblingIndex_Private_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, 100663423);
		AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_SetPlaceholderParent_Protected_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, 100663424);
		AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_PlaceAnimateObject_Public_Virtual_Void_AnimateObject_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, 100663425);
		AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, 100663426);
	}

	// Token: 0x0600015E RID: 350 RVA: 0x0001EF88 File Offset: 0x0001D188
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224874, XrefRangeEnd = 224882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600015F RID: 351 RVA: 0x0001EFBC File Offset: 0x0001D1BC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 224901, RefRangeEnd = 224904, XrefRangeStart = 224882, XrefRangeEnd = 224901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreatePlayedCardPlaceholder(int index, int instanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instanceID;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_CreatePlayedCardPlaceholder_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000160 RID: 352 RVA: 0x0001F008 File Offset: 0x0001D208
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224905, RefRangeEnd = 224906, XrefRangeStart = 224904, XrefRangeEnd = 224905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasPlayedCardPlaceholder(int instanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_HasPlayedCardPlaceholder_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000161 RID: 353 RVA: 0x0001F054 File Offset: 0x0001D254
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 224919, RefRangeEnd = 224921, XrefRangeStart = 224906, XrefRangeEnd = 224919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetPlayedCardEntryList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_ResetPlayedCardEntryList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000162 RID: 354 RVA: 0x0001F088 File Offset: 0x0001D288
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224947, RefRangeEnd = 224948, XrefRangeStart = 224921, XrefRangeEnd = 224947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildPlayedCardEntryList(int played_card_count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref played_card_count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_RebuildPlayedCardEntryList_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000163 RID: 355 RVA: 0x0001F0C8 File Offset: 0x0001D2C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224948, XrefRangeEnd = 224961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddPlayedCardEntry(int addInstanceID, int addFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref addInstanceID;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addFlags;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_AddPlayedCardEntry_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000164 RID: 356 RVA: 0x0001F114 File Offset: 0x0001D314
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224961, XrefRangeEnd = 224984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePlayedCardEntry(int updateIndex, int updateInstanceID, int updateFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref updateIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateInstanceID;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateFlags;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_UpdatePlayedCardEntry_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000165 RID: 357 RVA: 0x0001F170 File Offset: 0x0001D370
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224994, RefRangeEnd = 224995, XrefRangeStart = 224984, XrefRangeEnd = 224994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemovePlayedCardEntry(int removeIndex, int removeInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref removeIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref removeInstanceID;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_RemovePlayedCardEntry_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000166 RID: 358 RVA: 0x0001F1BC File Offset: 0x0001D3BC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 225000, RefRangeEnd = 225002, XrefRangeStart = 224995, XrefRangeEnd = 225000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateHorizontalController()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_UpdateHorizontalController_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000167 RID: 359 RVA: 0x0001F1F0 File Offset: 0x0001D3F0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 225009, RefRangeEnd = 225012, XrefRangeStart = 225002, XrefRangeEnd = 225009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePlayedCardFromFlags(AscensionCard ascension_card)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ascension_card);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_UpdatePlayedCardFromFlags_Private_Void_AscensionCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000168 RID: 360 RVA: 0x0001F234 File Offset: 0x0001D434
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 225028, RefRangeEnd = 225029, XrefRangeStart = 225012, XrefRangeEnd = 225028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000169 RID: 361 RVA: 0x0001F268 File Offset: 0x0001D468
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 225028, RefRangeEnd = 225029, XrefRangeStart = 225028, XrefRangeEnd = 225029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAllPlayedCardsFromFlags()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_UpdateAllPlayedCardsFromFlags_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600016A RID: 362 RVA: 0x0001F29C File Offset: 0x0001D49C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 225047, RefRangeEnd = 225048, XrefRangeStart = 225029, XrefRangeEnd = 225047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CalculateInsertSiblingIndex(GameObject insert)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(insert);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_CalculateInsertSiblingIndex_Private_Int32_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600016B RID: 363 RVA: 0x0001F2EC File Offset: 0x0001D4EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225048, XrefRangeEnd = 225062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetPlaceholderParent(GameObject placeholder)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(placeholder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_SetPlaceholderParent_Protected_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600016C RID: 364 RVA: 0x0001F33C File Offset: 0x0001D53C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225062, XrefRangeEnd = 225067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void PlaceAnimateObject(AnimateObject animate_object, bool bSetPosition = false, bool bSetRotation = false, bool bIgnoreOverride = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animate_object);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSetPosition;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSetRotation;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIgnoreOverride;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr_PlaceAnimateObject_Public_Virtual_Void_AnimateObject_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600016D RID: 365 RVA: 0x0001F3B4 File Offset: 0x0001D5B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225067, XrefRangeEnd = 225071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionAnimationLocatorPlayedCards()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionAnimationLocatorPlayedCards.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00002C90 File Offset: 0x00000E90
	public AscensionAnimationLocatorPlayedCards(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x0600016F RID: 367 RVA: 0x0001F3F0 File Offset: 0x0001D5F0
	// (set) Token: 0x06000170 RID: 368 RVA: 0x00002C99 File Offset: 0x00000E99
	public unsafe static int k_playedCardEffectCopy
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectCopy, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectCopy, (void*)(&value));
		}
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x06000171 RID: 369 RVA: 0x0001F40C File Offset: 0x0001D60C
	// (set) Token: 0x06000172 RID: 370 RVA: 0x00002CA7 File Offset: 0x00000EA7
	public unsafe static int k_playedCardEffectBanish
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectBanish, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectBanish, (void*)(&value));
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x06000173 RID: 371 RVA: 0x0001F428 File Offset: 0x0001D628
	// (set) Token: 0x06000174 RID: 372 RVA: 0x00002CB5 File Offset: 0x00000EB5
	public unsafe static int k_playedCardEffectTransform
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectTransform, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectTransform, (void*)(&value));
		}
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x06000175 RID: 373 RVA: 0x0001F444 File Offset: 0x0001D644
	// (set) Token: 0x06000176 RID: 374 RVA: 0x00002CC3 File Offset: 0x00000EC3
	public unsafe static int k_playedCardEffectEnergized
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectEnergized, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectEnergized, (void*)(&value));
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x06000177 RID: 375 RVA: 0x0001F460 File Offset: 0x0001D660
	// (set) Token: 0x06000178 RID: 376 RVA: 0x00002CD1 File Offset: 0x00000ED1
	public unsafe static int k_playedCardEffectKeepInHand
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectKeepInHand, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectKeepInHand, (void*)(&value));
		}
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x06000179 RID: 377 RVA: 0x0001F47C File Offset: 0x0001D67C
	// (set) Token: 0x0600017A RID: 378 RVA: 0x00002CDF File Offset: 0x00000EDF
	public unsafe static int k_playedCardEffectVision
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectVision, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectVision, (void*)(&value));
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x0600017B RID: 379 RVA: 0x0001F498 File Offset: 0x0001D698
	// (set) Token: 0x0600017C RID: 380 RVA: 0x00002CED File Offset: 0x00000EED
	public unsafe static int k_playedCardEffectActive
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectActive, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectActive, (void*)(&value));
		}
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x0600017D RID: 381 RVA: 0x0001F4B4 File Offset: 0x0001D6B4
	// (set) Token: 0x0600017E RID: 382 RVA: 0x00002CFB File Offset: 0x00000EFB
	public unsafe static int k_playedCardEffectDiscarded
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectDiscarded, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectDiscarded, (void*)(&value));
		}
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x0600017F RID: 383 RVA: 0x0001F4D0 File Offset: 0x0001D6D0
	// (set) Token: 0x06000180 RID: 384 RVA: 0x00002D09 File Offset: 0x00000F09
	public unsafe static int k_playedCardEffectDay
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectDay, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectDay, (void*)(&value));
		}
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x06000181 RID: 385 RVA: 0x0001F4EC File Offset: 0x0001D6EC
	// (set) Token: 0x06000182 RID: 386 RVA: 0x00002D17 File Offset: 0x00000F17
	public unsafe static int k_playedCardEffectNight
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectNight, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectNight, (void*)(&value));
		}
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x06000183 RID: 387 RVA: 0x0001F508 File Offset: 0x0001D708
	// (set) Token: 0x06000184 RID: 388 RVA: 0x00002D25 File Offset: 0x00000F25
	public unsafe static int k_playedCardEffectPhantasm
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectPhantasm, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_k_playedCardEffectPhantasm, (void*)(&value));
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x06000185 RID: 389 RVA: 0x0001F524 File Offset: 0x0001D724
	// (set) Token: 0x06000186 RID: 390 RVA: 0x00002D33 File Offset: 0x00000F33
	public unsafe AscensionCardManager m_CardManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_CardManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCardManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_CardManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x06000187 RID: 391 RVA: 0x0001F554 File Offset: 0x0001D754
	// (set) Token: 0x06000188 RID: 392 RVA: 0x00002D52 File Offset: 0x00000F52
	public unsafe ScrollRect m_scrollRect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_scrollRect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x06000189 RID: 393 RVA: 0x0001F584 File Offset: 0x0001D784
	// (set) Token: 0x0600018A RID: 394 RVA: 0x00002D71 File Offset: 0x00000F71
	public unsafe HorizontalLayoutGroup m_layoutController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_layoutController);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<HorizontalLayoutGroup>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_layoutController), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x0600018B RID: 395 RVA: 0x0001F5B4 File Offset: 0x0001D7B4
	// (set) Token: 0x0600018C RID: 396 RVA: 0x00002D90 File Offset: 0x00000F90
	public unsafe int m_playedCardRightJustifyThreshold
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_playedCardRightJustifyThreshold);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_playedCardRightJustifyThreshold)) = value;
		}
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x0600018D RID: 397 RVA: 0x0001F5DC File Offset: 0x0001D7DC
	// (set) Token: 0x0600018E RID: 398 RVA: 0x00002DAB File Offset: 0x00000FAB
	public unsafe Il2CppStructArray<AscensionAnimationLocatorPlayedCards.PlayedCardEntry> m_PlayedCardEntryList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_PlayedCardEntryList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<AscensionAnimationLocatorPlayedCards.PlayedCardEntry>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_PlayedCardEntryList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x0600018F RID: 399 RVA: 0x0001F60C File Offset: 0x0001D80C
	// (set) Token: 0x06000190 RID: 400 RVA: 0x00002DCA File Offset: 0x00000FCA
	public unsafe Il2CppReferenceArray<AscensionCard> m_PlayedCardPlaceholderList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_PlayedCardPlaceholderList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AscensionCard>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_PlayedCardPlaceholderList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x06000191 RID: 401 RVA: 0x0001F63C File Offset: 0x0001D83C
	// (set) Token: 0x06000192 RID: 402 RVA: 0x00002DE9 File Offset: 0x00000FE9
	public unsafe int m_PlayedCardEntryListCapacity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_PlayedCardEntryListCapacity);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_PlayedCardEntryListCapacity)) = value;
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x06000193 RID: 403 RVA: 0x0001F664 File Offset: 0x0001D864
	// (set) Token: 0x06000194 RID: 404 RVA: 0x00002E04 File Offset: 0x00001004
	public unsafe int m_PlayedCardEntryListCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_PlayedCardEntryListCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_PlayedCardEntryListCount)) = value;
		}
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x06000195 RID: 405 RVA: 0x0001F68C File Offset: 0x0001D88C
	// (set) Token: 0x06000196 RID: 406 RVA: 0x00002E1F File Offset: 0x0000101F
	public unsafe Il2CppStructArray<QueryCardState> m_QueryBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_QueryBuffer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<QueryCardState>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_QueryBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x06000197 RID: 407 RVA: 0x0001F6BC File Offset: 0x0001D8BC
	// (set) Token: 0x06000198 RID: 408 RVA: 0x00002E3E File Offset: 0x0000103E
	public unsafe static int m_DefaultPlayedCardEntryListCapacity
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_DefaultPlayedCardEntryListCapacity, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AscensionAnimationLocatorPlayedCards.NativeFieldInfoPtr_m_DefaultPlayedCardEntryListCapacity, (void*)(&value));
		}
	}

	// Token: 0x040000DE RID: 222
	private static readonly IntPtr NativeFieldInfoPtr_k_playedCardEffectCopy;

	// Token: 0x040000DF RID: 223
	private static readonly IntPtr NativeFieldInfoPtr_k_playedCardEffectBanish;

	// Token: 0x040000E0 RID: 224
	private static readonly IntPtr NativeFieldInfoPtr_k_playedCardEffectTransform;

	// Token: 0x040000E1 RID: 225
	private static readonly IntPtr NativeFieldInfoPtr_k_playedCardEffectEnergized;

	// Token: 0x040000E2 RID: 226
	private static readonly IntPtr NativeFieldInfoPtr_k_playedCardEffectKeepInHand;

	// Token: 0x040000E3 RID: 227
	private static readonly IntPtr NativeFieldInfoPtr_k_playedCardEffectVision;

	// Token: 0x040000E4 RID: 228
	private static readonly IntPtr NativeFieldInfoPtr_k_playedCardEffectActive;

	// Token: 0x040000E5 RID: 229
	private static readonly IntPtr NativeFieldInfoPtr_k_playedCardEffectDiscarded;

	// Token: 0x040000E6 RID: 230
	private static readonly IntPtr NativeFieldInfoPtr_k_playedCardEffectDay;

	// Token: 0x040000E7 RID: 231
	private static readonly IntPtr NativeFieldInfoPtr_k_playedCardEffectNight;

	// Token: 0x040000E8 RID: 232
	private static readonly IntPtr NativeFieldInfoPtr_k_playedCardEffectPhantasm;

	// Token: 0x040000E9 RID: 233
	private static readonly IntPtr NativeFieldInfoPtr_m_CardManager;

	// Token: 0x040000EA RID: 234
	private static readonly IntPtr NativeFieldInfoPtr_m_scrollRect;

	// Token: 0x040000EB RID: 235
	private static readonly IntPtr NativeFieldInfoPtr_m_layoutController;

	// Token: 0x040000EC RID: 236
	private static readonly IntPtr NativeFieldInfoPtr_m_playedCardRightJustifyThreshold;

	// Token: 0x040000ED RID: 237
	private static readonly IntPtr NativeFieldInfoPtr_m_PlayedCardEntryList;

	// Token: 0x040000EE RID: 238
	private static readonly IntPtr NativeFieldInfoPtr_m_PlayedCardPlaceholderList;

	// Token: 0x040000EF RID: 239
	private static readonly IntPtr NativeFieldInfoPtr_m_PlayedCardEntryListCapacity;

	// Token: 0x040000F0 RID: 240
	private static readonly IntPtr NativeFieldInfoPtr_m_PlayedCardEntryListCount;

	// Token: 0x040000F1 RID: 241
	private static readonly IntPtr NativeFieldInfoPtr_m_QueryBuffer;

	// Token: 0x040000F2 RID: 242
	private static readonly IntPtr NativeFieldInfoPtr_m_DefaultPlayedCardEntryListCapacity;

	// Token: 0x040000F3 RID: 243
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040000F4 RID: 244
	private static readonly IntPtr NativeMethodInfoPtr_CreatePlayedCardPlaceholder_Private_Void_Int32_Int32_0;

	// Token: 0x040000F5 RID: 245
	private static readonly IntPtr NativeMethodInfoPtr_HasPlayedCardPlaceholder_Public_Boolean_Int32_0;

	// Token: 0x040000F6 RID: 246
	private static readonly IntPtr NativeMethodInfoPtr_ResetPlayedCardEntryList_Public_Void_0;

	// Token: 0x040000F7 RID: 247
	private static readonly IntPtr NativeMethodInfoPtr_RebuildPlayedCardEntryList_Public_Void_Int32_0;

	// Token: 0x040000F8 RID: 248
	private static readonly IntPtr NativeMethodInfoPtr_AddPlayedCardEntry_Public_Void_Int32_Int32_0;

	// Token: 0x040000F9 RID: 249
	private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayedCardEntry_Public_Void_Int32_Int32_Int32_0;

	// Token: 0x040000FA RID: 250
	private static readonly IntPtr NativeMethodInfoPtr_RemovePlayedCardEntry_Public_Void_Int32_Int32_0;

	// Token: 0x040000FB RID: 251
	private static readonly IntPtr NativeMethodInfoPtr_UpdateHorizontalController_Private_Void_0;

	// Token: 0x040000FC RID: 252
	private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayedCardFromFlags_Private_Void_AscensionCard_0;

	// Token: 0x040000FD RID: 253
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x040000FE RID: 254
	private static readonly IntPtr NativeMethodInfoPtr_UpdateAllPlayedCardsFromFlags_Public_Void_0;

	// Token: 0x040000FF RID: 255
	private static readonly IntPtr NativeMethodInfoPtr_CalculateInsertSiblingIndex_Private_Int32_GameObject_0;

	// Token: 0x04000100 RID: 256
	private static readonly IntPtr NativeMethodInfoPtr_SetPlaceholderParent_Protected_Virtual_Void_GameObject_0;

	// Token: 0x04000101 RID: 257
	private static readonly IntPtr NativeMethodInfoPtr_PlaceAnimateObject_Public_Virtual_Void_AnimateObject_Boolean_Boolean_Boolean_0;

	// Token: 0x04000102 RID: 258
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000166 RID: 358
	[StructLayout(2)]
	public struct PlayedCardEntry
	{
		// Token: 0x060022A3 RID: 8867 RVA: 0x0008205C File Offset: 0x0008025C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayedCardEntry()
		{
			Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards.PlayedCardEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards>.NativeClassPtr, "PlayedCardEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards.PlayedCardEntry>.NativeClassPtr);
			AscensionAnimationLocatorPlayedCards.PlayedCardEntry.NativeFieldInfoPtr_playedCardInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards.PlayedCardEntry>.NativeClassPtr, "playedCardInstanceID");
			AscensionAnimationLocatorPlayedCards.PlayedCardEntry.NativeFieldInfoPtr_playedCardFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards.PlayedCardEntry>.NativeClassPtr, "playedCardFlags");
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x00015CFD File Offset: 0x00013EFD
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AscensionAnimationLocatorPlayedCards.PlayedCardEntry>.NativeClassPtr, ref this));
		}

		// Token: 0x0400180D RID: 6157
		private static readonly IntPtr NativeFieldInfoPtr_playedCardInstanceID;

		// Token: 0x0400180E RID: 6158
		private static readonly IntPtr NativeFieldInfoPtr_playedCardFlags;

		// Token: 0x0400180F RID: 6159
		[FieldOffset(0)]
		public int playedCardInstanceID;

		// Token: 0x04001810 RID: 6160
		[FieldOffset(4)]
		public int playedCardFlags;
	}
}

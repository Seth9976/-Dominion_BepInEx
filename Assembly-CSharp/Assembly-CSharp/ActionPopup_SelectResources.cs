using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

// Token: 0x02000009 RID: 9
public class ActionPopup_SelectResources : PopupBase
{
	// Token: 0x060000AF RID: 175 RVA: 0x0001CE18 File Offset: 0x0001B018
	// Note: this type is marked as 'beforefieldinit'.
	static ActionPopup_SelectResources()
	{
		Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ActionPopup_SelectResources");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr);
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayTextList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_TopDisplayTextList");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_ConfirmButtonTextList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_ConfirmButtonTextList");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_topDisplayText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_topDisplayText");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayRuneObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_TopDisplayRuneObj");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayRuneText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_TopDisplayRuneText");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayPowerObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_TopDisplayPowerObj");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayPowerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_TopDisplayPowerText");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayInsightObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_TopDisplayInsightObj");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayInsightText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_TopDisplayInsightText");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_MainDisplayRuneObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_MainDisplayRuneObj");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_MainDisplayRuneText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_MainDisplayRuneText");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_MainDisplayPowerObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_MainDisplayPowerObj");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_MainDisplayPowerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_MainDisplayPowerText");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_MainDisplayInsightObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_MainDisplayInsightObj");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_MainDisplayInsightText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_MainDisplayInsightText");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_confirmButton");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_confirmButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_confirmButtonText");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_AscensionCardManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_AscensionCardManager");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_ResolvingCardLocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_ResolvingCardLocator");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_AnimationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_AnimationManager");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_DeliriumDieDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_DeliriumDieDisplay");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_ResolvingCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_ResolvingCard");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_bExitTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_bExitTimer");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_CountdownTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_CountdownTimer");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_bIsHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_bIsHidden");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_currentRunes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_currentRunes");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_currentPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_currentPower");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_currentInsight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_currentInsight");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_runeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_runeFlags");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_powerFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_powerFlags");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_insightFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_insightFlags");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_runesNeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_runesNeeded");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_powerNeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_powerNeeded");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_insightNeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_insightNeeded");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_runesMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_runesMax");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_powerMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_powerMax");
		ActionPopup_SelectResources.NativeFieldInfoPtr_m_insightMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, "m_insightMax");
		ActionPopup_SelectResources.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, 100663362);
		ActionPopup_SelectResources.NativeMethodInfoPtr_BlockGameUpdate_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, 100663363);
		ActionPopup_SelectResources.NativeMethodInfoPtr_ActivatePopup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, 100663364);
		ActionPopup_SelectResources.NativeMethodInfoPtr_DismissPopup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, 100663365);
		ActionPopup_SelectResources.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, 100663366);
		ActionPopup_SelectResources.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, 100663367);
		ActionPopup_SelectResources.NativeMethodInfoPtr_HidePopup_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, 100663368);
		ActionPopup_SelectResources.NativeMethodInfoPtr_SetHideValue_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, 100663369);
		ActionPopup_SelectResources.NativeMethodInfoPtr_GetIsHidden_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, 100663370);
		ActionPopup_SelectResources.NativeMethodInfoPtr_UpdateDisplay_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, 100663371);
		ActionPopup_SelectResources.NativeMethodInfoPtr_UpdateCountsAndButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, 100663372);
		ActionPopup_SelectResources.NativeMethodInfoPtr_TestCurrentSelection_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, 100663373);
		ActionPopup_SelectResources.NativeMethodInfoPtr_OnRunesHit_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, 100663374);
		ActionPopup_SelectResources.NativeMethodInfoPtr_OnPowerHit_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, 100663375);
		ActionPopup_SelectResources.NativeMethodInfoPtr_OnInsightHit_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, 100663376);
		ActionPopup_SelectResources.NativeMethodInfoPtr_OnActionButtonConfirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, 100663377);
		ActionPopup_SelectResources.NativeMethodInfoPtr_SetResolvingCard_Private_Void_AscensionAnimationLocator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, 100663378);
		ActionPopup_SelectResources.NativeMethodInfoPtr_UpdateResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, 100663379);
		ActionPopup_SelectResources.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr, 100663380);
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x0001D2A8 File Offset: 0x0001B4A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224531, XrefRangeEnd = 224533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_SelectResources.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x0001D2DC File Offset: 0x0001B4DC
	[CallerCount(0)]
	public unsafe override bool BlockGameUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionPopup_SelectResources.NativeMethodInfoPtr_BlockGameUpdate_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x0001D324 File Offset: 0x0001B524
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224533, XrefRangeEnd = 224536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ActivatePopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionPopup_SelectResources.NativeMethodInfoPtr_ActivatePopup_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x0001D360 File Offset: 0x0001B560
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224536, XrefRangeEnd = 224539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void DismissPopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionPopup_SelectResources.NativeMethodInfoPtr_DismissPopup_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x0001D39C File Offset: 0x0001B59C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224539, XrefRangeEnd = 224542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetActive(bool bActive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_SelectResources.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x0001D3DC File Offset: 0x0001B5DC
	[CallerCount(0)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_SelectResources.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x0001D410 File Offset: 0x0001B610
	[CallerCount(0)]
	public unsafe void HidePopup(bool bIsHidden)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bIsHidden;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_SelectResources.NativeMethodInfoPtr_HidePopup_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x0001D450 File Offset: 0x0001B650
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224542, XrefRangeEnd = 224543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHideValue(bool bIsHidden)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bIsHidden;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_SelectResources.NativeMethodInfoPtr_SetHideValue_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x0001D490 File Offset: 0x0001B690
	[CallerCount(0)]
	public unsafe override bool GetIsHidden()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionPopup_SelectResources.NativeMethodInfoPtr_GetIsHidden_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x0001D4D8 File Offset: 0x0001B6D8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224618, RefRangeEnd = 224619, XrefRangeStart = 224543, XrefRangeEnd = 224618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDisplay(int playerIndex, bool bAnimateResolvingCard = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAnimateResolvingCard;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_SelectResources.NativeMethodInfoPtr_UpdateDisplay_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000BA RID: 186 RVA: 0x0001D524 File Offset: 0x0001B724
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 224625, RefRangeEnd = 224629, XrefRangeStart = 224619, XrefRangeEnd = 224625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCountsAndButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_SelectResources.NativeMethodInfoPtr_UpdateCountsAndButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000BB RID: 187 RVA: 0x0001D558 File Offset: 0x0001B758
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 224659, RefRangeEnd = 224663, XrefRangeStart = 224629, XrefRangeEnd = 224659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int TestCurrentSelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_SelectResources.NativeMethodInfoPtr_TestCurrentSelection_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060000BC RID: 188 RVA: 0x0001D594 File Offset: 0x0001B794
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224663, XrefRangeEnd = 224666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRunesHit(int change)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_SelectResources.NativeMethodInfoPtr_OnRunesHit_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000BD RID: 189 RVA: 0x0001D5D4 File Offset: 0x0001B7D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224666, XrefRangeEnd = 224669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPowerHit(int change)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_SelectResources.NativeMethodInfoPtr_OnPowerHit_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000BE RID: 190 RVA: 0x0001D614 File Offset: 0x0001B814
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224669, XrefRangeEnd = 224672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInsightHit(int change)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_SelectResources.NativeMethodInfoPtr_OnInsightHit_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000BF RID: 191 RVA: 0x0001D654 File Offset: 0x0001B854
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224672, XrefRangeEnd = 224676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnActionButtonConfirm()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_SelectResources.NativeMethodInfoPtr_OnActionButtonConfirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x0001D688 File Offset: 0x0001B888
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224676, XrefRangeEnd = 224684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetResolvingCard(AscensionAnimationLocator resolvePosition, bool bAnimateResolvingCard)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolvePosition);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAnimateResolvingCard;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_SelectResources.NativeMethodInfoPtr_SetResolvingCard_Private_Void_AscensionAnimationLocator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x0001D6D8 File Offset: 0x0001B8D8
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateResources()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_SelectResources.NativeMethodInfoPtr_UpdateResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x0001D70C File Offset: 0x0001B90C
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114494, XrefRangeEnd = 114502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActionPopup_SelectResources()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionPopup_SelectResources>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_SelectResources.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x000025EB File Offset: 0x000007EB
	public ActionPopup_SelectResources(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060000C4 RID: 196 RVA: 0x0001D748 File Offset: 0x0001B948
	// (set) Token: 0x060000C5 RID: 197 RVA: 0x000025F4 File Offset: 0x000007F4
	public unsafe static Il2CppStringArray m_TopDisplayTextList
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayTextList, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayTextList, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060000C6 RID: 198 RVA: 0x0001D770 File Offset: 0x0001B970
	// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002606 File Offset: 0x00000806
	public unsafe static Il2CppStringArray m_ConfirmButtonTextList
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(ActionPopup_SelectResources.NativeFieldInfoPtr_m_ConfirmButtonTextList, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ActionPopup_SelectResources.NativeFieldInfoPtr_m_ConfirmButtonTextList, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x060000C8 RID: 200 RVA: 0x0001D798 File Offset: 0x0001B998
	// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002618 File Offset: 0x00000818
	public unsafe TextMeshProUGUI m_topDisplayText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_topDisplayText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_topDisplayText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x060000CA RID: 202 RVA: 0x0001D7C8 File Offset: 0x0001B9C8
	// (set) Token: 0x060000CB RID: 203 RVA: 0x00002637 File Offset: 0x00000837
	public unsafe GameObject m_TopDisplayRuneObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayRuneObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayRuneObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x060000CC RID: 204 RVA: 0x0001D7F8 File Offset: 0x0001B9F8
	// (set) Token: 0x060000CD RID: 205 RVA: 0x00002656 File Offset: 0x00000856
	public unsafe TextMeshProUGUI m_TopDisplayRuneText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayRuneText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayRuneText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x060000CE RID: 206 RVA: 0x0001D828 File Offset: 0x0001BA28
	// (set) Token: 0x060000CF RID: 207 RVA: 0x00002675 File Offset: 0x00000875
	public unsafe GameObject m_TopDisplayPowerObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayPowerObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayPowerObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x060000D0 RID: 208 RVA: 0x0001D858 File Offset: 0x0001BA58
	// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002694 File Offset: 0x00000894
	public unsafe TextMeshProUGUI m_TopDisplayPowerText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayPowerText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayPowerText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x060000D2 RID: 210 RVA: 0x0001D888 File Offset: 0x0001BA88
	// (set) Token: 0x060000D3 RID: 211 RVA: 0x000026B3 File Offset: 0x000008B3
	public unsafe GameObject m_TopDisplayInsightObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayInsightObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayInsightObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x060000D4 RID: 212 RVA: 0x0001D8B8 File Offset: 0x0001BAB8
	// (set) Token: 0x060000D5 RID: 213 RVA: 0x000026D2 File Offset: 0x000008D2
	public unsafe TextMeshProUGUI m_TopDisplayInsightText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayInsightText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_TopDisplayInsightText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x060000D6 RID: 214 RVA: 0x0001D8E8 File Offset: 0x0001BAE8
	// (set) Token: 0x060000D7 RID: 215 RVA: 0x000026F1 File Offset: 0x000008F1
	public unsafe GameObject m_MainDisplayRuneObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_MainDisplayRuneObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_MainDisplayRuneObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x060000D8 RID: 216 RVA: 0x0001D918 File Offset: 0x0001BB18
	// (set) Token: 0x060000D9 RID: 217 RVA: 0x00002710 File Offset: 0x00000910
	public unsafe TextMeshProUGUI m_MainDisplayRuneText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_MainDisplayRuneText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_MainDisplayRuneText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x060000DA RID: 218 RVA: 0x0001D948 File Offset: 0x0001BB48
	// (set) Token: 0x060000DB RID: 219 RVA: 0x0000272F File Offset: 0x0000092F
	public unsafe GameObject m_MainDisplayPowerObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_MainDisplayPowerObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_MainDisplayPowerObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x060000DC RID: 220 RVA: 0x0001D978 File Offset: 0x0001BB78
	// (set) Token: 0x060000DD RID: 221 RVA: 0x0000274E File Offset: 0x0000094E
	public unsafe TextMeshProUGUI m_MainDisplayPowerText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_MainDisplayPowerText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_MainDisplayPowerText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x060000DE RID: 222 RVA: 0x0001D9A8 File Offset: 0x0001BBA8
	// (set) Token: 0x060000DF RID: 223 RVA: 0x0000276D File Offset: 0x0000096D
	public unsafe GameObject m_MainDisplayInsightObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_MainDisplayInsightObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_MainDisplayInsightObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x060000E0 RID: 224 RVA: 0x0001D9D8 File Offset: 0x0001BBD8
	// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000278C File Offset: 0x0000098C
	public unsafe TextMeshProUGUI m_MainDisplayInsightText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_MainDisplayInsightText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_MainDisplayInsightText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x060000E2 RID: 226 RVA: 0x0001DA08 File Offset: 0x0001BC08
	// (set) Token: 0x060000E3 RID: 227 RVA: 0x000027AB File Offset: 0x000009AB
	public unsafe GameObject m_confirmButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_confirmButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x060000E4 RID: 228 RVA: 0x0001DA38 File Offset: 0x0001BC38
	// (set) Token: 0x060000E5 RID: 229 RVA: 0x000027CA File Offset: 0x000009CA
	public unsafe TextMeshProUGUI m_confirmButtonText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_confirmButtonText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_confirmButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x060000E6 RID: 230 RVA: 0x0001DA68 File Offset: 0x0001BC68
	// (set) Token: 0x060000E7 RID: 231 RVA: 0x000027E9 File Offset: 0x000009E9
	public unsafe AscensionCardManager m_AscensionCardManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_AscensionCardManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCardManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_AscensionCardManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x060000E8 RID: 232 RVA: 0x0001DA98 File Offset: 0x0001BC98
	// (set) Token: 0x060000E9 RID: 233 RVA: 0x00002808 File Offset: 0x00000A08
	public unsafe AscensionAnimationLocator m_ResolvingCardLocator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_ResolvingCardLocator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_ResolvingCardLocator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x060000EA RID: 234 RVA: 0x0001DAC8 File Offset: 0x0001BCC8
	// (set) Token: 0x060000EB RID: 235 RVA: 0x00002827 File Offset: 0x00000A27
	public unsafe AscensionAnimationManager m_AnimationManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_AnimationManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_AnimationManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x060000EC RID: 236 RVA: 0x0001DAF8 File Offset: 0x0001BCF8
	// (set) Token: 0x060000ED RID: 237 RVA: 0x00002846 File Offset: 0x00000A46
	public unsafe GameObject m_DeliriumDieDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_DeliriumDieDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_DeliriumDieDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x060000EE RID: 238 RVA: 0x0001DB28 File Offset: 0x0001BD28
	// (set) Token: 0x060000EF RID: 239 RVA: 0x00002865 File Offset: 0x00000A65
	public unsafe AnimateObject m_ResolvingCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_ResolvingCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimateObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_ResolvingCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x060000F0 RID: 240 RVA: 0x0001DB58 File Offset: 0x0001BD58
	// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002884 File Offset: 0x00000A84
	public unsafe bool m_bExitTimer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_bExitTimer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_bExitTimer)) = value;
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x060000F2 RID: 242 RVA: 0x0001DB80 File Offset: 0x0001BD80
	// (set) Token: 0x060000F3 RID: 243 RVA: 0x0000289F File Offset: 0x00000A9F
	public unsafe float m_CountdownTimer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_CountdownTimer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_CountdownTimer)) = value;
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x060000F4 RID: 244 RVA: 0x0001DBA8 File Offset: 0x0001BDA8
	// (set) Token: 0x060000F5 RID: 245 RVA: 0x000028BA File Offset: 0x00000ABA
	public unsafe bool m_bIsHidden
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_bIsHidden);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_bIsHidden)) = value;
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x060000F6 RID: 246 RVA: 0x0001DBD0 File Offset: 0x0001BDD0
	// (set) Token: 0x060000F7 RID: 247 RVA: 0x000028D5 File Offset: 0x00000AD5
	public unsafe int m_currentRunes
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_currentRunes);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_currentRunes)) = value;
		}
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x060000F8 RID: 248 RVA: 0x0001DBF8 File Offset: 0x0001BDF8
	// (set) Token: 0x060000F9 RID: 249 RVA: 0x000028F0 File Offset: 0x00000AF0
	public unsafe int m_currentPower
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_currentPower);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_currentPower)) = value;
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x060000FA RID: 250 RVA: 0x0001DC20 File Offset: 0x0001BE20
	// (set) Token: 0x060000FB RID: 251 RVA: 0x0000290B File Offset: 0x00000B0B
	public unsafe int m_currentInsight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_currentInsight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_currentInsight)) = value;
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x060000FC RID: 252 RVA: 0x0001DC48 File Offset: 0x0001BE48
	// (set) Token: 0x060000FD RID: 253 RVA: 0x00002926 File Offset: 0x00000B26
	public unsafe int m_runeFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_runeFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_runeFlags)) = value;
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x060000FE RID: 254 RVA: 0x0001DC70 File Offset: 0x0001BE70
	// (set) Token: 0x060000FF RID: 255 RVA: 0x00002941 File Offset: 0x00000B41
	public unsafe int m_powerFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_powerFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_powerFlags)) = value;
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x06000100 RID: 256 RVA: 0x0001DC98 File Offset: 0x0001BE98
	// (set) Token: 0x06000101 RID: 257 RVA: 0x0000295C File Offset: 0x00000B5C
	public unsafe int m_insightFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_insightFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_insightFlags)) = value;
		}
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06000102 RID: 258 RVA: 0x0001DCC0 File Offset: 0x0001BEC0
	// (set) Token: 0x06000103 RID: 259 RVA: 0x00002977 File Offset: 0x00000B77
	public unsafe int m_runesNeeded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_runesNeeded);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_runesNeeded)) = value;
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x06000104 RID: 260 RVA: 0x0001DCE8 File Offset: 0x0001BEE8
	// (set) Token: 0x06000105 RID: 261 RVA: 0x00002992 File Offset: 0x00000B92
	public unsafe int m_powerNeeded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_powerNeeded);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_powerNeeded)) = value;
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x06000106 RID: 262 RVA: 0x0001DD10 File Offset: 0x0001BF10
	// (set) Token: 0x06000107 RID: 263 RVA: 0x000029AD File Offset: 0x00000BAD
	public unsafe int m_insightNeeded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_insightNeeded);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_insightNeeded)) = value;
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x06000108 RID: 264 RVA: 0x0001DD38 File Offset: 0x0001BF38
	// (set) Token: 0x06000109 RID: 265 RVA: 0x000029C8 File Offset: 0x00000BC8
	public unsafe int m_runesMax
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_runesMax);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_runesMax)) = value;
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x0600010A RID: 266 RVA: 0x0001DD60 File Offset: 0x0001BF60
	// (set) Token: 0x0600010B RID: 267 RVA: 0x000029E3 File Offset: 0x00000BE3
	public unsafe int m_powerMax
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_powerMax);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_powerMax)) = value;
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x0600010C RID: 268 RVA: 0x0001DD88 File Offset: 0x0001BF88
	// (set) Token: 0x0600010D RID: 269 RVA: 0x000029FE File Offset: 0x00000BFE
	public unsafe int m_insightMax
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_insightMax);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_SelectResources.NativeFieldInfoPtr_m_insightMax)) = value;
		}
	}

	// Token: 0x04000071 RID: 113
	private static readonly IntPtr NativeFieldInfoPtr_m_TopDisplayTextList;

	// Token: 0x04000072 RID: 114
	private static readonly IntPtr NativeFieldInfoPtr_m_ConfirmButtonTextList;

	// Token: 0x04000073 RID: 115
	private static readonly IntPtr NativeFieldInfoPtr_m_topDisplayText;

	// Token: 0x04000074 RID: 116
	private static readonly IntPtr NativeFieldInfoPtr_m_TopDisplayRuneObj;

	// Token: 0x04000075 RID: 117
	private static readonly IntPtr NativeFieldInfoPtr_m_TopDisplayRuneText;

	// Token: 0x04000076 RID: 118
	private static readonly IntPtr NativeFieldInfoPtr_m_TopDisplayPowerObj;

	// Token: 0x04000077 RID: 119
	private static readonly IntPtr NativeFieldInfoPtr_m_TopDisplayPowerText;

	// Token: 0x04000078 RID: 120
	private static readonly IntPtr NativeFieldInfoPtr_m_TopDisplayInsightObj;

	// Token: 0x04000079 RID: 121
	private static readonly IntPtr NativeFieldInfoPtr_m_TopDisplayInsightText;

	// Token: 0x0400007A RID: 122
	private static readonly IntPtr NativeFieldInfoPtr_m_MainDisplayRuneObj;

	// Token: 0x0400007B RID: 123
	private static readonly IntPtr NativeFieldInfoPtr_m_MainDisplayRuneText;

	// Token: 0x0400007C RID: 124
	private static readonly IntPtr NativeFieldInfoPtr_m_MainDisplayPowerObj;

	// Token: 0x0400007D RID: 125
	private static readonly IntPtr NativeFieldInfoPtr_m_MainDisplayPowerText;

	// Token: 0x0400007E RID: 126
	private static readonly IntPtr NativeFieldInfoPtr_m_MainDisplayInsightObj;

	// Token: 0x0400007F RID: 127
	private static readonly IntPtr NativeFieldInfoPtr_m_MainDisplayInsightText;

	// Token: 0x04000080 RID: 128
	private static readonly IntPtr NativeFieldInfoPtr_m_confirmButton;

	// Token: 0x04000081 RID: 129
	private static readonly IntPtr NativeFieldInfoPtr_m_confirmButtonText;

	// Token: 0x04000082 RID: 130
	private static readonly IntPtr NativeFieldInfoPtr_m_AscensionCardManager;

	// Token: 0x04000083 RID: 131
	private static readonly IntPtr NativeFieldInfoPtr_m_ResolvingCardLocator;

	// Token: 0x04000084 RID: 132
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimationManager;

	// Token: 0x04000085 RID: 133
	private static readonly IntPtr NativeFieldInfoPtr_m_DeliriumDieDisplay;

	// Token: 0x04000086 RID: 134
	private static readonly IntPtr NativeFieldInfoPtr_m_ResolvingCard;

	// Token: 0x04000087 RID: 135
	private static readonly IntPtr NativeFieldInfoPtr_m_bExitTimer;

	// Token: 0x04000088 RID: 136
	private static readonly IntPtr NativeFieldInfoPtr_m_CountdownTimer;

	// Token: 0x04000089 RID: 137
	private static readonly IntPtr NativeFieldInfoPtr_m_bIsHidden;

	// Token: 0x0400008A RID: 138
	private static readonly IntPtr NativeFieldInfoPtr_m_currentRunes;

	// Token: 0x0400008B RID: 139
	private static readonly IntPtr NativeFieldInfoPtr_m_currentPower;

	// Token: 0x0400008C RID: 140
	private static readonly IntPtr NativeFieldInfoPtr_m_currentInsight;

	// Token: 0x0400008D RID: 141
	private static readonly IntPtr NativeFieldInfoPtr_m_runeFlags;

	// Token: 0x0400008E RID: 142
	private static readonly IntPtr NativeFieldInfoPtr_m_powerFlags;

	// Token: 0x0400008F RID: 143
	private static readonly IntPtr NativeFieldInfoPtr_m_insightFlags;

	// Token: 0x04000090 RID: 144
	private static readonly IntPtr NativeFieldInfoPtr_m_runesNeeded;

	// Token: 0x04000091 RID: 145
	private static readonly IntPtr NativeFieldInfoPtr_m_powerNeeded;

	// Token: 0x04000092 RID: 146
	private static readonly IntPtr NativeFieldInfoPtr_m_insightNeeded;

	// Token: 0x04000093 RID: 147
	private static readonly IntPtr NativeFieldInfoPtr_m_runesMax;

	// Token: 0x04000094 RID: 148
	private static readonly IntPtr NativeFieldInfoPtr_m_powerMax;

	// Token: 0x04000095 RID: 149
	private static readonly IntPtr NativeFieldInfoPtr_m_insightMax;

	// Token: 0x04000096 RID: 150
	private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

	// Token: 0x04000097 RID: 151
	private static readonly IntPtr NativeMethodInfoPtr_BlockGameUpdate_Public_Virtual_Boolean_0;

	// Token: 0x04000098 RID: 152
	private static readonly IntPtr NativeMethodInfoPtr_ActivatePopup_Public_Virtual_Void_0;

	// Token: 0x04000099 RID: 153
	private static readonly IntPtr NativeMethodInfoPtr_DismissPopup_Public_Virtual_Void_0;

	// Token: 0x0400009A RID: 154
	private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

	// Token: 0x0400009B RID: 155
	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	// Token: 0x0400009C RID: 156
	private static readonly IntPtr NativeMethodInfoPtr_HidePopup_Private_Void_Boolean_0;

	// Token: 0x0400009D RID: 157
	private static readonly IntPtr NativeMethodInfoPtr_SetHideValue_Public_Void_Boolean_0;

	// Token: 0x0400009E RID: 158
	private static readonly IntPtr NativeMethodInfoPtr_GetIsHidden_Public_Virtual_Boolean_0;

	// Token: 0x0400009F RID: 159
	private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplay_Public_Void_Int32_Boolean_0;

	// Token: 0x040000A0 RID: 160
	private static readonly IntPtr NativeMethodInfoPtr_UpdateCountsAndButton_Public_Void_0;

	// Token: 0x040000A1 RID: 161
	private static readonly IntPtr NativeMethodInfoPtr_TestCurrentSelection_Private_Int32_0;

	// Token: 0x040000A2 RID: 162
	private static readonly IntPtr NativeMethodInfoPtr_OnRunesHit_Public_Void_Int32_0;

	// Token: 0x040000A3 RID: 163
	private static readonly IntPtr NativeMethodInfoPtr_OnPowerHit_Public_Void_Int32_0;

	// Token: 0x040000A4 RID: 164
	private static readonly IntPtr NativeMethodInfoPtr_OnInsightHit_Public_Void_Int32_0;

	// Token: 0x040000A5 RID: 165
	private static readonly IntPtr NativeMethodInfoPtr_OnActionButtonConfirm_Public_Void_0;

	// Token: 0x040000A6 RID: 166
	private static readonly IntPtr NativeMethodInfoPtr_SetResolvingCard_Private_Void_AscensionAnimationLocator_Boolean_0;

	// Token: 0x040000A7 RID: 167
	private static readonly IntPtr NativeMethodInfoPtr_UpdateResources_Private_Void_0;

	// Token: 0x040000A8 RID: 168
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

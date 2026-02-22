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

// Token: 0x020000C9 RID: 201
public class UI_CardGallery : UI_FrontEndAndInGameScene
{
	// Token: 0x06001801 RID: 6145 RVA: 0x0006277C File Offset: 0x0006097C
	// Note: this type is marked as 'beforefieldinit'.
	static UI_CardGallery()
	{
		Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_CardGallery");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr);
		UI_CardGallery.NativeFieldInfoPtr_m_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_nodes");
		UI_CardGallery.NativeFieldInfoPtr_m_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_cards");
		UI_CardGallery.NativeFieldInfoPtr_m_cardManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_cardManager");
		UI_CardGallery.NativeFieldInfoPtr_m_limbo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_limbo");
		UI_CardGallery.NativeFieldInfoPtr_m_scaleForVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_scaleForVertical");
		UI_CardGallery.NativeFieldInfoPtr_m_scaleForHorizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_scaleForHorizontal");
		UI_CardGallery.NativeFieldInfoPtr_m_setToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_setToggles");
		UI_CardGallery.NativeFieldInfoPtr_m_typeToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_typeToggles");
		UI_CardGallery.NativeFieldInfoPtr_m_cardCountCommon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_cardCountCommon");
		UI_CardGallery.NativeFieldInfoPtr_m_cardCountEnlightneed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_cardCountEnlightneed");
		UI_CardGallery.NativeFieldInfoPtr_m_cardCountLifebound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_cardCountLifebound");
		UI_CardGallery.NativeFieldInfoPtr_m_cardCountMechana = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_cardCountMechana");
		UI_CardGallery.NativeFieldInfoPtr_m_cardCountVoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_cardCountVoid");
		UI_CardGallery.NativeFieldInfoPtr_m_cardCountMonster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_cardCountMonster");
		UI_CardGallery.NativeFieldInfoPtr_m_transformButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_transformButton");
		UI_CardGallery.NativeFieldInfoPtr_m_setName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_setName");
		UI_CardGallery.NativeFieldInfoPtr_m_debugHalfHeightObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_debugHalfHeightObject");
		UI_CardGallery.NativeFieldInfoPtr_m_debugHalfHeightToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_debugHalfHeightToggle");
		UI_CardGallery.NativeFieldInfoPtr_m_loadingScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_loadingScreen");
		UI_CardGallery.NativeFieldInfoPtr_m_cardMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_cardMaterial");
		UI_CardGallery.NativeFieldInfoPtr_m_MinSwipeDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_MinSwipeDistance");
		UI_CardGallery.NativeFieldInfoPtr_m_cardManagerPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_cardManagerPath");
		UI_CardGallery.NativeFieldInfoPtr_m_bIgnoreToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_bIgnoreToggles");
		UI_CardGallery.NativeFieldInfoPtr_m_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_currentIndex");
		UI_CardGallery.NativeFieldInfoPtr_m_currentNodeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_currentNodeIndex");
		UI_CardGallery.NativeFieldInfoPtr_m_currentSetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_currentSetIndex");
		UI_CardGallery.NativeFieldInfoPtr_m_oldSetFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_oldSetFlags");
		UI_CardGallery.NativeFieldInfoPtr_m_oldTypeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_oldTypeFlags");
		UI_CardGallery.NativeFieldInfoPtr_m_bOldHHToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_bOldHHToggle");
		UI_CardGallery.NativeFieldInfoPtr_m_startingSetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_startingSetIndex");
		UI_CardGallery.NativeFieldInfoPtr_m_startTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_startTouch");
		UI_CardGallery.NativeFieldInfoPtr_m_bIsTouching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_bIsTouching");
		UI_CardGallery.NativeFieldInfoPtr_m_bIgnoreMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_bIgnoreMove");
		UI_CardGallery.NativeFieldInfoPtr_m_cardManagerFromResouces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "m_cardManagerFromResouces");
		UI_CardGallery.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, 100665212);
		UI_CardGallery.NativeMethodInfoPtr_OnMenuEnter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, 100665213);
		UI_CardGallery.NativeMethodInfoPtr_OnMenuExit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, 100665214);
		UI_CardGallery.NativeMethodInfoPtr_SetStartingSet_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, 100665215);
		UI_CardGallery.NativeMethodInfoPtr_CardTypeUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, 100665216);
		UI_CardGallery.NativeMethodInfoPtr_CardTypeDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, 100665217);
		UI_CardGallery.NativeMethodInfoPtr_MoveLeft_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, 100665218);
		UI_CardGallery.NativeMethodInfoPtr_MoveRight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, 100665219);
		UI_CardGallery.NativeMethodInfoPtr_MoveLockout_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, 100665220);
		UI_CardGallery.NativeMethodInfoPtr_SetCurrentSetText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, 100665221);
		UI_CardGallery.NativeMethodInfoPtr_FlipCard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, 100665222);
		UI_CardGallery.NativeMethodInfoPtr_SetInfoBox_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, 100665223);
		UI_CardGallery.NativeMethodInfoPtr_ResetNodes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, 100665224);
		UI_CardGallery.NativeMethodInfoPtr_IAP_SetStartingCardSet_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, 100665225);
		UI_CardGallery.NativeMethodInfoPtr_RebuildCardLists_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, 100665226);
		UI_CardGallery.NativeMethodInfoPtr_RebuildCardListsAsync_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, 100665227);
		UI_CardGallery.NativeMethodInfoPtr_GetIndex_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, 100665228);
		UI_CardGallery.NativeMethodInfoPtr_ClearCardLists_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, 100665229);
		UI_CardGallery.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, 100665230);
	}

	// Token: 0x06001802 RID: 6146 RVA: 0x00062BD0 File Offset: 0x00060DD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248876, XrefRangeEnd = 248931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001803 RID: 6147 RVA: 0x00062C04 File Offset: 0x00060E04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248931, XrefRangeEnd = 249018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMenuEnter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery.NativeMethodInfoPtr_OnMenuEnter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001804 RID: 6148 RVA: 0x00062C38 File Offset: 0x00060E38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249018, XrefRangeEnd = 249132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMenuExit(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery.NativeMethodInfoPtr_OnMenuExit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001805 RID: 6149 RVA: 0x00062C78 File Offset: 0x00060E78
	[CallerCount(0)]
	public unsafe void SetStartingSet(int setIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref setIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery.NativeMethodInfoPtr_SetStartingSet_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001806 RID: 6150 RVA: 0x00062CB8 File Offset: 0x00060EB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249132, XrefRangeEnd = 249139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CardTypeUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery.NativeMethodInfoPtr_CardTypeUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001807 RID: 6151 RVA: 0x00062CEC File Offset: 0x00060EEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249139, XrefRangeEnd = 249146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CardTypeDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery.NativeMethodInfoPtr_CardTypeDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001808 RID: 6152 RVA: 0x00062D20 File Offset: 0x00060F20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249146, XrefRangeEnd = 249171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveLeft()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery.NativeMethodInfoPtr_MoveLeft_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001809 RID: 6153 RVA: 0x00062D54 File Offset: 0x00060F54
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249171, XrefRangeEnd = 249195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveRight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery.NativeMethodInfoPtr_MoveRight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600180A RID: 6154 RVA: 0x00062D88 File Offset: 0x00060F88
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249195, XrefRangeEnd = 249199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator MoveLockout()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery.NativeMethodInfoPtr_MoveLockout_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600180B RID: 6155 RVA: 0x00062DC8 File Offset: 0x00060FC8
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 249213, RefRangeEnd = 249216, XrefRangeStart = 249199, XrefRangeEnd = 249213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCurrentSetText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery.NativeMethodInfoPtr_SetCurrentSetText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600180C RID: 6156 RVA: 0x00062DFC File Offset: 0x00060FFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249216, XrefRangeEnd = 249233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FlipCard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery.NativeMethodInfoPtr_FlipCard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600180D RID: 6157 RVA: 0x00062E30 File Offset: 0x00061030
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInfoBox()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery.NativeMethodInfoPtr_SetInfoBox_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600180E RID: 6158 RVA: 0x00062E64 File Offset: 0x00061064
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 249241, RefRangeEnd = 249243, XrefRangeStart = 249233, XrefRangeEnd = 249241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetNodes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery.NativeMethodInfoPtr_ResetNodes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600180F RID: 6159 RVA: 0x00062E98 File Offset: 0x00061098
	[CallerCount(0)]
	public unsafe void IAP_SetStartingCardSet(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery.NativeMethodInfoPtr_IAP_SetStartingCardSet_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001810 RID: 6160 RVA: 0x00062ED8 File Offset: 0x000610D8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 249248, RefRangeEnd = 249250, XrefRangeStart = 249243, XrefRangeEnd = 249248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildCardLists()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery.NativeMethodInfoPtr_RebuildCardLists_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001811 RID: 6161 RVA: 0x00062F0C File Offset: 0x0006110C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249250, XrefRangeEnd = 249254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator RebuildCardListsAsync()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery.NativeMethodInfoPtr_RebuildCardListsAsync_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06001812 RID: 6162 RVA: 0x00062F4C File Offset: 0x0006114C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 249258, RefRangeEnd = 249260, XrefRangeStart = 249254, XrefRangeEnd = 249258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetIndex(int startingIndex, int steps)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref startingIndex;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steps;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery.NativeMethodInfoPtr_GetIndex_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001813 RID: 6163 RVA: 0x00062FA4 File Offset: 0x000611A4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 249331, RefRangeEnd = 249333, XrefRangeStart = 249260, XrefRangeEnd = 249331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearCardLists()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery.NativeMethodInfoPtr_ClearCardLists_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001814 RID: 6164 RVA: 0x00062FD8 File Offset: 0x000611D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249333, XrefRangeEnd = 249335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_CardGallery()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001815 RID: 6165 RVA: 0x0000F726 File Offset: 0x0000D926
	public UI_CardGallery(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170007A2 RID: 1954
	// (get) Token: 0x06001816 RID: 6166 RVA: 0x00063014 File Offset: 0x00061214
	// (set) Token: 0x06001817 RID: 6167 RVA: 0x0000F72F File Offset: 0x0000D92F
	public unsafe Il2CppReferenceArray<UIP_CardGalleryNode> m_nodes
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_nodes);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIP_CardGalleryNode>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007A3 RID: 1955
	// (get) Token: 0x06001818 RID: 6168 RVA: 0x00063044 File Offset: 0x00061244
	// (set) Token: 0x06001819 RID: 6169 RVA: 0x0000F74E File Offset: 0x0000D94E
	public unsafe Il2CppReferenceArray<UI_CardGallery.CardGalleryCardSet> m_cards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UI_CardGallery.CardGalleryCardSet>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007A4 RID: 1956
	// (get) Token: 0x0600181A RID: 6170 RVA: 0x00063074 File Offset: 0x00061274
	// (set) Token: 0x0600181B RID: 6171 RVA: 0x0000F76D File Offset: 0x0000D96D
	public unsafe AscensionCardManager m_cardManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCardManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007A5 RID: 1957
	// (get) Token: 0x0600181C RID: 6172 RVA: 0x000630A4 File Offset: 0x000612A4
	// (set) Token: 0x0600181D RID: 6173 RVA: 0x0000F78C File Offset: 0x0000D98C
	public unsafe GameObject m_limbo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_limbo);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_limbo), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007A6 RID: 1958
	// (get) Token: 0x0600181E RID: 6174 RVA: 0x000630D4 File Offset: 0x000612D4
	// (set) Token: 0x0600181F RID: 6175 RVA: 0x0000F7AB File Offset: 0x0000D9AB
	public unsafe float m_scaleForVertical
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_scaleForVertical);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_scaleForVertical)) = value;
		}
	}

	// Token: 0x170007A7 RID: 1959
	// (get) Token: 0x06001820 RID: 6176 RVA: 0x000630FC File Offset: 0x000612FC
	// (set) Token: 0x06001821 RID: 6177 RVA: 0x0000F7C6 File Offset: 0x0000D9C6
	public unsafe float m_scaleForHorizontal
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_scaleForHorizontal);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_scaleForHorizontal)) = value;
		}
	}

	// Token: 0x170007A8 RID: 1960
	// (get) Token: 0x06001822 RID: 6178 RVA: 0x00063124 File Offset: 0x00061324
	// (set) Token: 0x06001823 RID: 6179 RVA: 0x0000F7E1 File Offset: 0x0000D9E1
	public unsafe Il2CppReferenceArray<Toggle> m_setToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_setToggles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Toggle>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_setToggles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007A9 RID: 1961
	// (get) Token: 0x06001824 RID: 6180 RVA: 0x00063154 File Offset: 0x00061354
	// (set) Token: 0x06001825 RID: 6181 RVA: 0x0000F800 File Offset: 0x0000DA00
	public unsafe Il2CppReferenceArray<Toggle> m_typeToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_typeToggles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Toggle>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_typeToggles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007AA RID: 1962
	// (get) Token: 0x06001826 RID: 6182 RVA: 0x00063184 File Offset: 0x00061384
	// (set) Token: 0x06001827 RID: 6183 RVA: 0x0000F81F File Offset: 0x0000DA1F
	public unsafe TextMeshProUGUI m_cardCountCommon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardCountCommon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardCountCommon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007AB RID: 1963
	// (get) Token: 0x06001828 RID: 6184 RVA: 0x000631B4 File Offset: 0x000613B4
	// (set) Token: 0x06001829 RID: 6185 RVA: 0x0000F83E File Offset: 0x0000DA3E
	public unsafe TextMeshProUGUI m_cardCountEnlightneed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardCountEnlightneed);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardCountEnlightneed), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007AC RID: 1964
	// (get) Token: 0x0600182A RID: 6186 RVA: 0x000631E4 File Offset: 0x000613E4
	// (set) Token: 0x0600182B RID: 6187 RVA: 0x0000F85D File Offset: 0x0000DA5D
	public unsafe TextMeshProUGUI m_cardCountLifebound
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardCountLifebound);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardCountLifebound), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007AD RID: 1965
	// (get) Token: 0x0600182C RID: 6188 RVA: 0x00063214 File Offset: 0x00061414
	// (set) Token: 0x0600182D RID: 6189 RVA: 0x0000F87C File Offset: 0x0000DA7C
	public unsafe TextMeshProUGUI m_cardCountMechana
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardCountMechana);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardCountMechana), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007AE RID: 1966
	// (get) Token: 0x0600182E RID: 6190 RVA: 0x00063244 File Offset: 0x00061444
	// (set) Token: 0x0600182F RID: 6191 RVA: 0x0000F89B File Offset: 0x0000DA9B
	public unsafe TextMeshProUGUI m_cardCountVoid
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardCountVoid);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardCountVoid), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007AF RID: 1967
	// (get) Token: 0x06001830 RID: 6192 RVA: 0x00063274 File Offset: 0x00061474
	// (set) Token: 0x06001831 RID: 6193 RVA: 0x0000F8BA File Offset: 0x0000DABA
	public unsafe TextMeshProUGUI m_cardCountMonster
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardCountMonster);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardCountMonster), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007B0 RID: 1968
	// (get) Token: 0x06001832 RID: 6194 RVA: 0x000632A4 File Offset: 0x000614A4
	// (set) Token: 0x06001833 RID: 6195 RVA: 0x0000F8D9 File Offset: 0x0000DAD9
	public unsafe GameObject m_transformButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_transformButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_transformButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007B1 RID: 1969
	// (get) Token: 0x06001834 RID: 6196 RVA: 0x000632D4 File Offset: 0x000614D4
	// (set) Token: 0x06001835 RID: 6197 RVA: 0x0000F8F8 File Offset: 0x0000DAF8
	public unsafe TextMeshProUGUI m_setName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_setName);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_setName), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007B2 RID: 1970
	// (get) Token: 0x06001836 RID: 6198 RVA: 0x00063304 File Offset: 0x00061504
	// (set) Token: 0x06001837 RID: 6199 RVA: 0x0000F917 File Offset: 0x0000DB17
	public unsafe GameObject m_debugHalfHeightObject
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_debugHalfHeightObject);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_debugHalfHeightObject), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007B3 RID: 1971
	// (get) Token: 0x06001838 RID: 6200 RVA: 0x00063334 File Offset: 0x00061534
	// (set) Token: 0x06001839 RID: 6201 RVA: 0x0000F936 File Offset: 0x0000DB36
	public unsafe Toggle m_debugHalfHeightToggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_debugHalfHeightToggle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_debugHalfHeightToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007B4 RID: 1972
	// (get) Token: 0x0600183A RID: 6202 RVA: 0x00063364 File Offset: 0x00061564
	// (set) Token: 0x0600183B RID: 6203 RVA: 0x0000F955 File Offset: 0x0000DB55
	public unsafe GameObject m_loadingScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_loadingScreen);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_loadingScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007B5 RID: 1973
	// (get) Token: 0x0600183C RID: 6204 RVA: 0x00063394 File Offset: 0x00061594
	// (set) Token: 0x0600183D RID: 6205 RVA: 0x0000F974 File Offset: 0x0000DB74
	public unsafe Material m_cardMaterial
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardMaterial);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007B6 RID: 1974
	// (get) Token: 0x0600183E RID: 6206 RVA: 0x000633C4 File Offset: 0x000615C4
	// (set) Token: 0x0600183F RID: 6207 RVA: 0x0000F993 File Offset: 0x0000DB93
	public unsafe float m_MinSwipeDistance
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_MinSwipeDistance);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_MinSwipeDistance)) = value;
		}
	}

	// Token: 0x170007B7 RID: 1975
	// (get) Token: 0x06001840 RID: 6208 RVA: 0x000633EC File Offset: 0x000615EC
	// (set) Token: 0x06001841 RID: 6209 RVA: 0x0000F9AE File Offset: 0x0000DBAE
	public unsafe string m_cardManagerPath
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardManagerPath);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardManagerPath), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170007B8 RID: 1976
	// (get) Token: 0x06001842 RID: 6210 RVA: 0x00063414 File Offset: 0x00061614
	// (set) Token: 0x06001843 RID: 6211 RVA: 0x0000F9CD File Offset: 0x0000DBCD
	public unsafe bool m_bIgnoreToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_bIgnoreToggles);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_bIgnoreToggles)) = value;
		}
	}

	// Token: 0x170007B9 RID: 1977
	// (get) Token: 0x06001844 RID: 6212 RVA: 0x0006343C File Offset: 0x0006163C
	// (set) Token: 0x06001845 RID: 6213 RVA: 0x0000F9E8 File Offset: 0x0000DBE8
	public unsafe int m_currentIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_currentIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_currentIndex)) = value;
		}
	}

	// Token: 0x170007BA RID: 1978
	// (get) Token: 0x06001846 RID: 6214 RVA: 0x00063464 File Offset: 0x00061664
	// (set) Token: 0x06001847 RID: 6215 RVA: 0x0000FA03 File Offset: 0x0000DC03
	public unsafe int m_currentNodeIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_currentNodeIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_currentNodeIndex)) = value;
		}
	}

	// Token: 0x170007BB RID: 1979
	// (get) Token: 0x06001848 RID: 6216 RVA: 0x0006348C File Offset: 0x0006168C
	// (set) Token: 0x06001849 RID: 6217 RVA: 0x0000FA1E File Offset: 0x0000DC1E
	public unsafe int m_currentSetIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_currentSetIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_currentSetIndex)) = value;
		}
	}

	// Token: 0x170007BC RID: 1980
	// (get) Token: 0x0600184A RID: 6218 RVA: 0x000634B4 File Offset: 0x000616B4
	// (set) Token: 0x0600184B RID: 6219 RVA: 0x0000FA39 File Offset: 0x0000DC39
	public unsafe int m_oldSetFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_oldSetFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_oldSetFlags)) = value;
		}
	}

	// Token: 0x170007BD RID: 1981
	// (get) Token: 0x0600184C RID: 6220 RVA: 0x000634DC File Offset: 0x000616DC
	// (set) Token: 0x0600184D RID: 6221 RVA: 0x0000FA54 File Offset: 0x0000DC54
	public unsafe int m_oldTypeFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_oldTypeFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_oldTypeFlags)) = value;
		}
	}

	// Token: 0x170007BE RID: 1982
	// (get) Token: 0x0600184E RID: 6222 RVA: 0x00063504 File Offset: 0x00061704
	// (set) Token: 0x0600184F RID: 6223 RVA: 0x0000FA6F File Offset: 0x0000DC6F
	public unsafe bool m_bOldHHToggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_bOldHHToggle);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_bOldHHToggle)) = value;
		}
	}

	// Token: 0x170007BF RID: 1983
	// (get) Token: 0x06001850 RID: 6224 RVA: 0x0006352C File Offset: 0x0006172C
	// (set) Token: 0x06001851 RID: 6225 RVA: 0x0000FA8A File Offset: 0x0000DC8A
	public unsafe int m_startingSetIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_startingSetIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_startingSetIndex)) = value;
		}
	}

	// Token: 0x170007C0 RID: 1984
	// (get) Token: 0x06001852 RID: 6226 RVA: 0x00063554 File Offset: 0x00061754
	// (set) Token: 0x06001853 RID: 6227 RVA: 0x0000FAA5 File Offset: 0x0000DCA5
	public unsafe Vector2 m_startTouch
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_startTouch);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_startTouch)) = value;
		}
	}

	// Token: 0x170007C1 RID: 1985
	// (get) Token: 0x06001854 RID: 6228 RVA: 0x0006357C File Offset: 0x0006177C
	// (set) Token: 0x06001855 RID: 6229 RVA: 0x0000FAC0 File Offset: 0x0000DCC0
	public unsafe bool m_bIsTouching
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_bIsTouching);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_bIsTouching)) = value;
		}
	}

	// Token: 0x170007C2 RID: 1986
	// (get) Token: 0x06001856 RID: 6230 RVA: 0x000635A4 File Offset: 0x000617A4
	// (set) Token: 0x06001857 RID: 6231 RVA: 0x0000FADB File Offset: 0x0000DCDB
	public unsafe bool m_bIgnoreMove
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_bIgnoreMove);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_bIgnoreMove)) = value;
		}
	}

	// Token: 0x170007C3 RID: 1987
	// (get) Token: 0x06001858 RID: 6232 RVA: 0x000635CC File Offset: 0x000617CC
	// (set) Token: 0x06001859 RID: 6233 RVA: 0x0000FAF6 File Offset: 0x0000DCF6
	public unsafe GameObject m_cardManagerFromResouces
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardManagerFromResouces);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.NativeFieldInfoPtr_m_cardManagerFromResouces), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04001070 RID: 4208
	private static readonly IntPtr NativeFieldInfoPtr_m_nodes;

	// Token: 0x04001071 RID: 4209
	private static readonly IntPtr NativeFieldInfoPtr_m_cards;

	// Token: 0x04001072 RID: 4210
	private static readonly IntPtr NativeFieldInfoPtr_m_cardManager;

	// Token: 0x04001073 RID: 4211
	private static readonly IntPtr NativeFieldInfoPtr_m_limbo;

	// Token: 0x04001074 RID: 4212
	private static readonly IntPtr NativeFieldInfoPtr_m_scaleForVertical;

	// Token: 0x04001075 RID: 4213
	private static readonly IntPtr NativeFieldInfoPtr_m_scaleForHorizontal;

	// Token: 0x04001076 RID: 4214
	private static readonly IntPtr NativeFieldInfoPtr_m_setToggles;

	// Token: 0x04001077 RID: 4215
	private static readonly IntPtr NativeFieldInfoPtr_m_typeToggles;

	// Token: 0x04001078 RID: 4216
	private static readonly IntPtr NativeFieldInfoPtr_m_cardCountCommon;

	// Token: 0x04001079 RID: 4217
	private static readonly IntPtr NativeFieldInfoPtr_m_cardCountEnlightneed;

	// Token: 0x0400107A RID: 4218
	private static readonly IntPtr NativeFieldInfoPtr_m_cardCountLifebound;

	// Token: 0x0400107B RID: 4219
	private static readonly IntPtr NativeFieldInfoPtr_m_cardCountMechana;

	// Token: 0x0400107C RID: 4220
	private static readonly IntPtr NativeFieldInfoPtr_m_cardCountVoid;

	// Token: 0x0400107D RID: 4221
	private static readonly IntPtr NativeFieldInfoPtr_m_cardCountMonster;

	// Token: 0x0400107E RID: 4222
	private static readonly IntPtr NativeFieldInfoPtr_m_transformButton;

	// Token: 0x0400107F RID: 4223
	private static readonly IntPtr NativeFieldInfoPtr_m_setName;

	// Token: 0x04001080 RID: 4224
	private static readonly IntPtr NativeFieldInfoPtr_m_debugHalfHeightObject;

	// Token: 0x04001081 RID: 4225
	private static readonly IntPtr NativeFieldInfoPtr_m_debugHalfHeightToggle;

	// Token: 0x04001082 RID: 4226
	private static readonly IntPtr NativeFieldInfoPtr_m_loadingScreen;

	// Token: 0x04001083 RID: 4227
	private static readonly IntPtr NativeFieldInfoPtr_m_cardMaterial;

	// Token: 0x04001084 RID: 4228
	private static readonly IntPtr NativeFieldInfoPtr_m_MinSwipeDistance;

	// Token: 0x04001085 RID: 4229
	private static readonly IntPtr NativeFieldInfoPtr_m_cardManagerPath;

	// Token: 0x04001086 RID: 4230
	private static readonly IntPtr NativeFieldInfoPtr_m_bIgnoreToggles;

	// Token: 0x04001087 RID: 4231
	private static readonly IntPtr NativeFieldInfoPtr_m_currentIndex;

	// Token: 0x04001088 RID: 4232
	private static readonly IntPtr NativeFieldInfoPtr_m_currentNodeIndex;

	// Token: 0x04001089 RID: 4233
	private static readonly IntPtr NativeFieldInfoPtr_m_currentSetIndex;

	// Token: 0x0400108A RID: 4234
	private static readonly IntPtr NativeFieldInfoPtr_m_oldSetFlags;

	// Token: 0x0400108B RID: 4235
	private static readonly IntPtr NativeFieldInfoPtr_m_oldTypeFlags;

	// Token: 0x0400108C RID: 4236
	private static readonly IntPtr NativeFieldInfoPtr_m_bOldHHToggle;

	// Token: 0x0400108D RID: 4237
	private static readonly IntPtr NativeFieldInfoPtr_m_startingSetIndex;

	// Token: 0x0400108E RID: 4238
	private static readonly IntPtr NativeFieldInfoPtr_m_startTouch;

	// Token: 0x0400108F RID: 4239
	private static readonly IntPtr NativeFieldInfoPtr_m_bIsTouching;

	// Token: 0x04001090 RID: 4240
	private static readonly IntPtr NativeFieldInfoPtr_m_bIgnoreMove;

	// Token: 0x04001091 RID: 4241
	private static readonly IntPtr NativeFieldInfoPtr_m_cardManagerFromResouces;

	// Token: 0x04001092 RID: 4242
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04001093 RID: 4243
	private static readonly IntPtr NativeMethodInfoPtr_OnMenuEnter_Public_Void_0;

	// Token: 0x04001094 RID: 4244
	private static readonly IntPtr NativeMethodInfoPtr_OnMenuExit_Public_Void_Boolean_0;

	// Token: 0x04001095 RID: 4245
	private static readonly IntPtr NativeMethodInfoPtr_SetStartingSet_Public_Void_Int32_0;

	// Token: 0x04001096 RID: 4246
	private static readonly IntPtr NativeMethodInfoPtr_CardTypeUp_Public_Void_0;

	// Token: 0x04001097 RID: 4247
	private static readonly IntPtr NativeMethodInfoPtr_CardTypeDown_Public_Void_0;

	// Token: 0x04001098 RID: 4248
	private static readonly IntPtr NativeMethodInfoPtr_MoveLeft_Public_Void_0;

	// Token: 0x04001099 RID: 4249
	private static readonly IntPtr NativeMethodInfoPtr_MoveRight_Public_Void_0;

	// Token: 0x0400109A RID: 4250
	private static readonly IntPtr NativeMethodInfoPtr_MoveLockout_Private_IEnumerator_0;

	// Token: 0x0400109B RID: 4251
	private static readonly IntPtr NativeMethodInfoPtr_SetCurrentSetText_Private_Void_0;

	// Token: 0x0400109C RID: 4252
	private static readonly IntPtr NativeMethodInfoPtr_FlipCard_Public_Void_0;

	// Token: 0x0400109D RID: 4253
	private static readonly IntPtr NativeMethodInfoPtr_SetInfoBox_Private_Void_0;

	// Token: 0x0400109E RID: 4254
	private static readonly IntPtr NativeMethodInfoPtr_ResetNodes_Private_Void_0;

	// Token: 0x0400109F RID: 4255
	private static readonly IntPtr NativeMethodInfoPtr_IAP_SetStartingCardSet_Public_Void_Int32_0;

	// Token: 0x040010A0 RID: 4256
	private static readonly IntPtr NativeMethodInfoPtr_RebuildCardLists_Public_Void_0;

	// Token: 0x040010A1 RID: 4257
	private static readonly IntPtr NativeMethodInfoPtr_RebuildCardListsAsync_Private_IEnumerator_0;

	// Token: 0x040010A2 RID: 4258
	private static readonly IntPtr NativeMethodInfoPtr_GetIndex_Private_Int32_Int32_Int32_0;

	// Token: 0x040010A3 RID: 4259
	private static readonly IntPtr NativeMethodInfoPtr_ClearCardLists_Private_Void_0;

	// Token: 0x040010A4 RID: 4260
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001E7 RID: 487
	public enum CardGalleryType
	{
		// Token: 0x04001B17 RID: 6935
		Common = 1,
		// Token: 0x04001B18 RID: 6936
		Enlightened,
		// Token: 0x04001B19 RID: 6937
		Lifebound = 4,
		// Token: 0x04001B1A RID: 6938
		Mechana = 8,
		// Token: 0x04001B1B RID: 6939
		Void = 16,
		// Token: 0x04001B1C RID: 6940
		Monster = 32
	}

	// Token: 0x020001E8 RID: 488
	public enum CardGallerySet
	{
		// Token: 0x04001B1E RID: 6942
		COTG,
		// Token: 0x04001B1F RID: 6943
		COTG_10th,
		// Token: 0x04001B20 RID: 6944
		ROTF,
		// Token: 0x04001B21 RID: 6945
		SOS,
		// Token: 0x04001B22 RID: 6946
		IH,
		// Token: 0x04001B23 RID: 6947
		ROV,
		// Token: 0x04001B24 RID: 6948
		DU,
		// Token: 0x04001B25 RID: 6949
		RU,
		// Token: 0x04001B26 RID: 6950
		DOC,
		// Token: 0x04001B27 RID: 6951
		DS,
		// Token: 0x04001B28 RID: 6952
		WOS,
		// Token: 0x04001B29 RID: 6953
		GOTE,
		// Token: 0x04001B2A RID: 6954
		Promo1,
		// Token: 0x04001B2B RID: 6955
		Promo2,
		// Token: 0x04001B2C RID: 6956
		Promo3,
		// Token: 0x04001B2D RID: 6957
		Promo4,
		// Token: 0x04001B2E RID: 6958
		Promo5,
		// Token: 0x04001B2F RID: 6959
		Promo6,
		// Token: 0x04001B30 RID: 6960
		VOTA,
		// Token: 0x04001B31 RID: 6961
		Delirium,
		// Token: 0x04001B32 RID: 6962
		Deliverance
	}

	// Token: 0x020001E9 RID: 489
	[Serializable]
	public sealed class CardGalleryCard : ValueType
	{
		// Token: 0x06002757 RID: 10071 RVA: 0x0008F8E8 File Offset: 0x0008DAE8
		// Note: this type is marked as 'beforefieldinit'.
		static CardGalleryCard()
		{
			Il2CppClassPointerStore<UI_CardGallery.CardGalleryCard>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "CardGalleryCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCard>.NativeClassPtr);
			UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCard>.NativeClassPtr, "card");
			UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_flipCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCard>.NativeClassPtr, "flipCard");
			UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_cardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCard>.NativeClassPtr, "cardType");
			UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_isHorizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCard>.NativeClassPtr, "isHorizontal");
			UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_cardFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCard>.NativeClassPtr, "cardFileName");
			UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_hasTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCard>.NativeClassPtr, "hasTransform");
			UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_transformCardFilename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCard>.NativeClassPtr, "transformCardFilename");
			UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_overrideCardSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCard>.NativeClassPtr, "overrideCardSet");
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x0001844A File Offset: 0x0001664A
		public CardGalleryCard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x00018453 File Offset: 0x00016653
		public CardGalleryCard()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCard>.NativeClassPtr))
		{
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x0600275A RID: 10074 RVA: 0x0008F9B4 File Offset: 0x0008DBB4
		// (set) Token: 0x0600275B RID: 10075 RVA: 0x00018465 File Offset: 0x00016665
		public unsafe GameObject card
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_card);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x0600275C RID: 10076 RVA: 0x0008F9E4 File Offset: 0x0008DBE4
		// (set) Token: 0x0600275D RID: 10077 RVA: 0x00018484 File Offset: 0x00016684
		public unsafe GameObject flipCard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_flipCard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_flipCard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x0008FA14 File Offset: 0x0008DC14
		// (set) Token: 0x0600275F RID: 10079 RVA: 0x000184A3 File Offset: 0x000166A3
		public unsafe UI_CardGallery.CardGalleryType cardType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_cardType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_cardType)) = value;
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x0008FA3C File Offset: 0x0008DC3C
		// (set) Token: 0x06002761 RID: 10081 RVA: 0x000184BE File Offset: 0x000166BE
		public unsafe bool isHorizontal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_isHorizontal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_isHorizontal)) = value;
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06002762 RID: 10082 RVA: 0x0008FA64 File Offset: 0x0008DC64
		// (set) Token: 0x06002763 RID: 10083 RVA: 0x000184D9 File Offset: 0x000166D9
		public unsafe string cardFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_cardFileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_cardFileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x0008FA8C File Offset: 0x0008DC8C
		// (set) Token: 0x06002765 RID: 10085 RVA: 0x000184F8 File Offset: 0x000166F8
		public unsafe bool hasTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_hasTransform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_hasTransform)) = value;
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06002766 RID: 10086 RVA: 0x0008FAB4 File Offset: 0x0008DCB4
		// (set) Token: 0x06002767 RID: 10087 RVA: 0x00018513 File Offset: 0x00016713
		public unsafe string transformCardFilename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_transformCardFilename);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_transformCardFilename), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06002768 RID: 10088 RVA: 0x0008FADC File Offset: 0x0008DCDC
		// (set) Token: 0x06002769 RID: 10089 RVA: 0x00018532 File Offset: 0x00016732
		public unsafe string overrideCardSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_overrideCardSet);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCard.NativeFieldInfoPtr_overrideCardSet), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001B33 RID: 6963
		private static readonly IntPtr NativeFieldInfoPtr_card;

		// Token: 0x04001B34 RID: 6964
		private static readonly IntPtr NativeFieldInfoPtr_flipCard;

		// Token: 0x04001B35 RID: 6965
		private static readonly IntPtr NativeFieldInfoPtr_cardType;

		// Token: 0x04001B36 RID: 6966
		private static readonly IntPtr NativeFieldInfoPtr_isHorizontal;

		// Token: 0x04001B37 RID: 6967
		private static readonly IntPtr NativeFieldInfoPtr_cardFileName;

		// Token: 0x04001B38 RID: 6968
		private static readonly IntPtr NativeFieldInfoPtr_hasTransform;

		// Token: 0x04001B39 RID: 6969
		private static readonly IntPtr NativeFieldInfoPtr_transformCardFilename;

		// Token: 0x04001B3A RID: 6970
		private static readonly IntPtr NativeFieldInfoPtr_overrideCardSet;
	}

	// Token: 0x020001EA RID: 490
	[Serializable]
	public sealed class CardGalleryCardSet : ValueType
	{
		// Token: 0x0600276A RID: 10090 RVA: 0x0008FB04 File Offset: 0x0008DD04
		// Note: this type is marked as 'beforefieldinit'.
		static CardGalleryCardSet()
		{
			Il2CppClassPointerStore<UI_CardGallery.CardGalleryCardSet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "CardGalleryCardSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCardSet>.NativeClassPtr);
			UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_cardSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCardSet>.NativeClassPtr, "cardSet");
			UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_setName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCardSet>.NativeClassPtr, "setName");
			UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCardSet>.NativeClassPtr, "cards");
			UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_commonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCardSet>.NativeClassPtr, "commonCount");
			UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_enlightenedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCardSet>.NativeClassPtr, "enlightenedCount");
			UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_lifeboundCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCardSet>.NativeClassPtr, "lifeboundCount");
			UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_mechanaCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCardSet>.NativeClassPtr, "mechanaCount");
			UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_voidCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCardSet>.NativeClassPtr, "voidCount");
			UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_monsterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCardSet>.NativeClassPtr, "monsterCount");
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x00018551 File Offset: 0x00016751
		public CardGalleryCardSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x0001855A File Offset: 0x0001675A
		public CardGalleryCardSet()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_CardGallery.CardGalleryCardSet>.NativeClassPtr))
		{
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x0600276D RID: 10093 RVA: 0x0008FBE4 File Offset: 0x0008DDE4
		// (set) Token: 0x0600276E RID: 10094 RVA: 0x0001856C File Offset: 0x0001676C
		public unsafe UI_CardGallery.CardGallerySet cardSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_cardSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_cardSet)) = value;
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x0600276F RID: 10095 RVA: 0x0008FC0C File Offset: 0x0008DE0C
		// (set) Token: 0x06002770 RID: 10096 RVA: 0x00018587 File Offset: 0x00016787
		public unsafe string setName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_setName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_setName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06002771 RID: 10097 RVA: 0x0008FC34 File Offset: 0x0008DE34
		// (set) Token: 0x06002772 RID: 10098 RVA: 0x000185A6 File Offset: 0x000167A6
		public unsafe Il2CppReferenceArray<UI_CardGallery.CardGalleryCard> cards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_cards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UI_CardGallery.CardGalleryCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_cards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06002773 RID: 10099 RVA: 0x0008FC64 File Offset: 0x0008DE64
		// (set) Token: 0x06002774 RID: 10100 RVA: 0x000185C5 File Offset: 0x000167C5
		public unsafe int commonCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_commonCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_commonCount)) = value;
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06002775 RID: 10101 RVA: 0x0008FC8C File Offset: 0x0008DE8C
		// (set) Token: 0x06002776 RID: 10102 RVA: 0x000185E0 File Offset: 0x000167E0
		public unsafe int enlightenedCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_enlightenedCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_enlightenedCount)) = value;
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06002777 RID: 10103 RVA: 0x0008FCB4 File Offset: 0x0008DEB4
		// (set) Token: 0x06002778 RID: 10104 RVA: 0x000185FB File Offset: 0x000167FB
		public unsafe int lifeboundCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_lifeboundCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_lifeboundCount)) = value;
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x0008FCDC File Offset: 0x0008DEDC
		// (set) Token: 0x0600277A RID: 10106 RVA: 0x00018616 File Offset: 0x00016816
		public unsafe int mechanaCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_mechanaCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_mechanaCount)) = value;
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x0600277B RID: 10107 RVA: 0x0008FD04 File Offset: 0x0008DF04
		// (set) Token: 0x0600277C RID: 10108 RVA: 0x00018631 File Offset: 0x00016831
		public unsafe int voidCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_voidCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_voidCount)) = value;
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x0600277D RID: 10109 RVA: 0x0008FD2C File Offset: 0x0008DF2C
		// (set) Token: 0x0600277E RID: 10110 RVA: 0x0001864C File Offset: 0x0001684C
		public unsafe int monsterCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_monsterCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery.CardGalleryCardSet.NativeFieldInfoPtr_monsterCount)) = value;
			}
		}

		// Token: 0x04001B3B RID: 6971
		private static readonly IntPtr NativeFieldInfoPtr_cardSet;

		// Token: 0x04001B3C RID: 6972
		private static readonly IntPtr NativeFieldInfoPtr_setName;

		// Token: 0x04001B3D RID: 6973
		private static readonly IntPtr NativeFieldInfoPtr_cards;

		// Token: 0x04001B3E RID: 6974
		private static readonly IntPtr NativeFieldInfoPtr_commonCount;

		// Token: 0x04001B3F RID: 6975
		private static readonly IntPtr NativeFieldInfoPtr_enlightenedCount;

		// Token: 0x04001B40 RID: 6976
		private static readonly IntPtr NativeFieldInfoPtr_lifeboundCount;

		// Token: 0x04001B41 RID: 6977
		private static readonly IntPtr NativeFieldInfoPtr_mechanaCount;

		// Token: 0x04001B42 RID: 6978
		private static readonly IntPtr NativeFieldInfoPtr_voidCount;

		// Token: 0x04001B43 RID: 6979
		private static readonly IntPtr NativeFieldInfoPtr_monsterCount;
	}

	// Token: 0x020001EB RID: 491
	[ObfuscatedName("UI_CardGallery+<MoveLockout>d__46")]
	public sealed class _MoveLockout_d__46 : global::Il2CppSystem.Object
	{
		// Token: 0x0600277F RID: 10111 RVA: 0x0008FD54 File Offset: 0x0008DF54
		// Note: this type is marked as 'beforefieldinit'.
		static _MoveLockout_d__46()
		{
			Il2CppClassPointerStore<UI_CardGallery._MoveLockout_d__46>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "<MoveLockout>d__46");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_CardGallery._MoveLockout_d__46>.NativeClassPtr);
			UI_CardGallery._MoveLockout_d__46.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery._MoveLockout_d__46>.NativeClassPtr, "<>1__state");
			UI_CardGallery._MoveLockout_d__46.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery._MoveLockout_d__46>.NativeClassPtr, "<>2__current");
			UI_CardGallery._MoveLockout_d__46.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery._MoveLockout_d__46>.NativeClassPtr, "<>4__this");
			UI_CardGallery._MoveLockout_d__46.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery._MoveLockout_d__46>.NativeClassPtr, "<i>5__2");
			UI_CardGallery._MoveLockout_d__46.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery._MoveLockout_d__46>.NativeClassPtr, 100666410);
			UI_CardGallery._MoveLockout_d__46.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery._MoveLockout_d__46>.NativeClassPtr, 100666411);
			UI_CardGallery._MoveLockout_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery._MoveLockout_d__46>.NativeClassPtr, 100666412);
			UI_CardGallery._MoveLockout_d__46.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery._MoveLockout_d__46>.NativeClassPtr, 100666413);
			UI_CardGallery._MoveLockout_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery._MoveLockout_d__46>.NativeClassPtr, 100666414);
			UI_CardGallery._MoveLockout_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery._MoveLockout_d__46>.NativeClassPtr, 100666415);
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x0008FE48 File Offset: 0x0008E048
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _MoveLockout_d__46(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_CardGallery._MoveLockout_d__46>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery._MoveLockout_d__46.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x0008FE90 File Offset: 0x0008E090
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery._MoveLockout_d__46.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x0008FEC4 File Offset: 0x0008E0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248807, XrefRangeEnd = 248812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery._MoveLockout_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06002783 RID: 10115 RVA: 0x0008FF00 File Offset: 0x0008E100
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery._MoveLockout_d__46.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x0008FF40 File Offset: 0x0008E140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248812, XrefRangeEnd = 248817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery._MoveLockout_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06002785 RID: 10117 RVA: 0x0008FF74 File Offset: 0x0008E174
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery._MoveLockout_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x00018667 File Offset: 0x00016867
		public _MoveLockout_d__46(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06002787 RID: 10119 RVA: 0x0008FFB4 File Offset: 0x0008E1B4
		// (set) Token: 0x06002788 RID: 10120 RVA: 0x00018670 File Offset: 0x00016870
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._MoveLockout_d__46.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._MoveLockout_d__46.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06002789 RID: 10121 RVA: 0x0008FFDC File Offset: 0x0008E1DC
		// (set) Token: 0x0600278A RID: 10122 RVA: 0x0001868B File Offset: 0x0001688B
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._MoveLockout_d__46.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._MoveLockout_d__46.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x0600278B RID: 10123 RVA: 0x0009000C File Offset: 0x0008E20C
		// (set) Token: 0x0600278C RID: 10124 RVA: 0x000186AA File Offset: 0x000168AA
		public unsafe UI_CardGallery __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._MoveLockout_d__46.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_CardGallery>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._MoveLockout_d__46.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x0009003C File Offset: 0x0008E23C
		// (set) Token: 0x0600278E RID: 10126 RVA: 0x000186C9 File Offset: 0x000168C9
		public unsafe int _i_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._MoveLockout_d__46.NativeFieldInfoPtr__i_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._MoveLockout_d__46.NativeFieldInfoPtr__i_5__2)) = value;
			}
		}

		// Token: 0x04001B44 RID: 6980
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001B45 RID: 6981
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001B46 RID: 6982
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001B47 RID: 6983
		private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

		// Token: 0x04001B48 RID: 6984
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001B49 RID: 6985
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B4A RID: 6986
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001B4B RID: 6987
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001B4C RID: 6988
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B4D RID: 6989
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020001EC RID: 492
	[ObfuscatedName("UI_CardGallery+<RebuildCardListsAsync>d__53")]
	public sealed class _RebuildCardListsAsync_d__53 : global::Il2CppSystem.Object
	{
		// Token: 0x0600278F RID: 10127 RVA: 0x00090064 File Offset: 0x0008E264
		// Note: this type is marked as 'beforefieldinit'.
		static _RebuildCardListsAsync_d__53()
		{
			Il2CppClassPointerStore<UI_CardGallery._RebuildCardListsAsync_d__53>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_CardGallery>.NativeClassPtr, "<RebuildCardListsAsync>d__53");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_CardGallery._RebuildCardListsAsync_d__53>.NativeClassPtr);
			UI_CardGallery._RebuildCardListsAsync_d__53.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery._RebuildCardListsAsync_d__53>.NativeClassPtr, "<>1__state");
			UI_CardGallery._RebuildCardListsAsync_d__53.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery._RebuildCardListsAsync_d__53>.NativeClassPtr, "<>2__current");
			UI_CardGallery._RebuildCardListsAsync_d__53.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery._RebuildCardListsAsync_d__53>.NativeClassPtr, "<>4__this");
			UI_CardGallery._RebuildCardListsAsync_d__53.NativeFieldInfoPtr__setFlags_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery._RebuildCardListsAsync_d__53>.NativeClassPtr, "<setFlags>5__2");
			UI_CardGallery._RebuildCardListsAsync_d__53.NativeFieldInfoPtr__typeFlags_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery._RebuildCardListsAsync_d__53>.NativeClassPtr, "<typeFlags>5__3");
			UI_CardGallery._RebuildCardListsAsync_d__53.NativeFieldInfoPtr__request_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CardGallery._RebuildCardListsAsync_d__53>.NativeClassPtr, "<request>5__4");
			UI_CardGallery._RebuildCardListsAsync_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery._RebuildCardListsAsync_d__53>.NativeClassPtr, 100666416);
			UI_CardGallery._RebuildCardListsAsync_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery._RebuildCardListsAsync_d__53>.NativeClassPtr, 100666417);
			UI_CardGallery._RebuildCardListsAsync_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery._RebuildCardListsAsync_d__53>.NativeClassPtr, 100666418);
			UI_CardGallery._RebuildCardListsAsync_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery._RebuildCardListsAsync_d__53>.NativeClassPtr, 100666419);
			UI_CardGallery._RebuildCardListsAsync_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery._RebuildCardListsAsync_d__53>.NativeClassPtr, 100666420);
			UI_CardGallery._RebuildCardListsAsync_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CardGallery._RebuildCardListsAsync_d__53>.NativeClassPtr, 100666421);
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x00090180 File Offset: 0x0008E380
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _RebuildCardListsAsync_d__53(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_CardGallery._RebuildCardListsAsync_d__53>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery._RebuildCardListsAsync_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x000901C8 File Offset: 0x0008E3C8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery._RebuildCardListsAsync_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x000901FC File Offset: 0x0008E3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248817, XrefRangeEnd = 248871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery._RebuildCardListsAsync_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06002793 RID: 10131 RVA: 0x00090238 File Offset: 0x0008E438
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery._RebuildCardListsAsync_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x00090278 File Offset: 0x0008E478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248871, XrefRangeEnd = 248876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery._RebuildCardListsAsync_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x000902AC File Offset: 0x0008E4AC
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CardGallery._RebuildCardListsAsync_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x000186E4 File Offset: 0x000168E4
		public _RebuildCardListsAsync_d__53(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06002797 RID: 10135 RVA: 0x000902EC File Offset: 0x0008E4EC
		// (set) Token: 0x06002798 RID: 10136 RVA: 0x000186ED File Offset: 0x000168ED
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._RebuildCardListsAsync_d__53.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._RebuildCardListsAsync_d__53.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06002799 RID: 10137 RVA: 0x00090314 File Offset: 0x0008E514
		// (set) Token: 0x0600279A RID: 10138 RVA: 0x00018708 File Offset: 0x00016908
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._RebuildCardListsAsync_d__53.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._RebuildCardListsAsync_d__53.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x0600279B RID: 10139 RVA: 0x00090344 File Offset: 0x0008E544
		// (set) Token: 0x0600279C RID: 10140 RVA: 0x00018727 File Offset: 0x00016927
		public unsafe UI_CardGallery __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._RebuildCardListsAsync_d__53.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_CardGallery>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._RebuildCardListsAsync_d__53.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x0600279D RID: 10141 RVA: 0x00090374 File Offset: 0x0008E574
		// (set) Token: 0x0600279E RID: 10142 RVA: 0x00018746 File Offset: 0x00016946
		public unsafe int _setFlags_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._RebuildCardListsAsync_d__53.NativeFieldInfoPtr__setFlags_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._RebuildCardListsAsync_d__53.NativeFieldInfoPtr__setFlags_5__2)) = value;
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x0600279F RID: 10143 RVA: 0x0009039C File Offset: 0x0008E59C
		// (set) Token: 0x060027A0 RID: 10144 RVA: 0x00018761 File Offset: 0x00016961
		public unsafe int _typeFlags_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._RebuildCardListsAsync_d__53.NativeFieldInfoPtr__typeFlags_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._RebuildCardListsAsync_d__53.NativeFieldInfoPtr__typeFlags_5__3)) = value;
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x060027A1 RID: 10145 RVA: 0x000903C4 File Offset: 0x0008E5C4
		// (set) Token: 0x060027A2 RID: 10146 RVA: 0x0001877C File Offset: 0x0001697C
		public unsafe ResourceRequest _request_5__4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._RebuildCardListsAsync_d__53.NativeFieldInfoPtr__request_5__4);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CardGallery._RebuildCardListsAsync_d__53.NativeFieldInfoPtr__request_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B4E RID: 6990
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001B4F RID: 6991
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001B50 RID: 6992
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001B51 RID: 6993
		private static readonly IntPtr NativeFieldInfoPtr__setFlags_5__2;

		// Token: 0x04001B52 RID: 6994
		private static readonly IntPtr NativeFieldInfoPtr__typeFlags_5__3;

		// Token: 0x04001B53 RID: 6995
		private static readonly IntPtr NativeFieldInfoPtr__request_5__4;

		// Token: 0x04001B54 RID: 6996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001B55 RID: 6997
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B56 RID: 6998
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001B57 RID: 6999
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001B58 RID: 7000
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B59 RID: 7001
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

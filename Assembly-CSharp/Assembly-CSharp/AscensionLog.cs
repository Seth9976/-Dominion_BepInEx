using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000023 RID: 35
public class AscensionLog : MonoBehaviour
{
	// Token: 0x060007D7 RID: 2007 RVA: 0x00030F0C File Offset: 0x0002F10C
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionLog()
	{
		Il2CppClassPointerStore<AscensionLog>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionLog");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr);
		AscensionLog.NativeFieldInfoPtr_m_roundText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, "m_roundText");
		AscensionLog.NativeFieldInfoPtr_m_cardManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, "m_cardManager");
		AscensionLog.NativeFieldInfoPtr_m_activeTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, "m_activeTray");
		AscensionLog.NativeFieldInfoPtr_m_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, "m_scrollRect");
		AscensionLog.NativeFieldInfoPtr_m_contentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, "m_contentContainer");
		AscensionLog.NativeFieldInfoPtr_m_arrowLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, "m_arrowLeft");
		AscensionLog.NativeFieldInfoPtr_m_arrowRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, "m_arrowRight");
		AscensionLog.NativeFieldInfoPtr_m_opponentDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, "m_opponentDisplays");
		AscensionLog.NativeFieldInfoPtr_m_cardList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, "m_cardList");
		AscensionLog.NativeFieldInfoPtr_m_roundNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, "m_roundNumber");
		AscensionLog.NativeFieldInfoPtr_m_maxRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, "m_maxRound");
		AscensionLog.NativeFieldInfoPtr_m_oppDisplayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, "m_oppDisplayed");
		AscensionLog.NativeFieldInfoPtr_m_bUpdateListPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, "m_bUpdateListPos");
		AscensionLog.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, 100663805);
		AscensionLog.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, 100663806);
		AscensionLog.NativeMethodInfoPtr_RegisterOpponentDisplay_Public_Void_PlayerDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, 100663807);
		AscensionLog.NativeMethodInfoPtr_ClearRegisteredDisplays_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, 100663808);
		AscensionLog.NativeMethodInfoPtr_SetGameCurrentRound_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, 100663809);
		AscensionLog.NativeMethodInfoPtr_MoveLeft_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, 100663810);
		AscensionLog.NativeMethodInfoPtr_MoveRight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, 100663811);
		AscensionLog.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, 100663812);
		AscensionLog.NativeMethodInfoPtr_ClearCardList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, 100663813);
		AscensionLog.NativeMethodInfoPtr_RebuildList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, 100663814);
		AscensionLog.NativeMethodInfoPtr_RebuildListAddative_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, 100663815);
		AscensionLog.NativeMethodInfoPtr_CheckVisibility_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, 100663816);
		AscensionLog.NativeMethodInfoPtr_ResetScrollPosition_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, 100663817);
		AscensionLog.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, 100663818);
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x00031158 File Offset: 0x0002F358
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233731, XrefRangeEnd = 233733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x0003118C File Offset: 0x0002F38C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233733, XrefRangeEnd = 233734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060007DA RID: 2010 RVA: 0x000311C0 File Offset: 0x0002F3C0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233740, RefRangeEnd = 233741, XrefRangeStart = 233734, XrefRangeEnd = 233740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RegisterOpponentDisplay(PlayerDisplay oppDisplay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oppDisplay);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog.NativeMethodInfoPtr_RegisterOpponentDisplay_Public_Void_PlayerDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x00031204 File Offset: 0x0002F404
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 233745, RefRangeEnd = 233746, XrefRangeStart = 233741, XrefRangeEnd = 233745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearRegisteredDisplays()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog.NativeMethodInfoPtr_ClearRegisteredDisplays_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x00031238 File Offset: 0x0002F438
	[CallerCount(0)]
	public unsafe void SetGameCurrentRound(int round)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref round;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog.NativeMethodInfoPtr_SetGameCurrentRound_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060007DD RID: 2013 RVA: 0x00031278 File Offset: 0x0002F478
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233746, XrefRangeEnd = 233747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveLeft()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog.NativeMethodInfoPtr_MoveLeft_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x000312AC File Offset: 0x0002F4AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233747, XrefRangeEnd = 233748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveRight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog.NativeMethodInfoPtr_MoveRight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060007DF RID: 2015 RVA: 0x000312E0 File Offset: 0x0002F4E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x00031314 File Offset: 0x0002F514
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 233761, RefRangeEnd = 233765, XrefRangeStart = 233748, XrefRangeEnd = 233761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearCardList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog.NativeMethodInfoPtr_ClearCardList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060007E1 RID: 2017 RVA: 0x00031348 File Offset: 0x0002F548
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233821, RefRangeEnd = 233823, XrefRangeStart = 233765, XrefRangeEnd = 233821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog.NativeMethodInfoPtr_RebuildList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060007E2 RID: 2018 RVA: 0x0003137C File Offset: 0x0002F57C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233823, XrefRangeEnd = 233871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildListAddative()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog.NativeMethodInfoPtr_RebuildListAddative_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060007E3 RID: 2019 RVA: 0x000313B0 File Offset: 0x0002F5B0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 233883, RefRangeEnd = 233885, XrefRangeStart = 233871, XrefRangeEnd = 233883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckVisibility()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog.NativeMethodInfoPtr_CheckVisibility_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x000313E4 File Offset: 0x0002F5E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233885, XrefRangeEnd = 233889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ResetScrollPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog.NativeMethodInfoPtr_ResetScrollPosition_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x00031424 File Offset: 0x0002F624
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233889, XrefRangeEnd = 233902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionLog()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060007E6 RID: 2022 RVA: 0x00006EFA File Offset: 0x000050FA
	public AscensionLog(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002D6 RID: 726
	// (get) Token: 0x060007E7 RID: 2023 RVA: 0x00031460 File Offset: 0x0002F660
	// (set) Token: 0x060007E8 RID: 2024 RVA: 0x00006F03 File Offset: 0x00005103
	public unsafe TextMeshProUGUI m_roundText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_roundText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_roundText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002D7 RID: 727
	// (get) Token: 0x060007E9 RID: 2025 RVA: 0x00031490 File Offset: 0x0002F690
	// (set) Token: 0x060007EA RID: 2026 RVA: 0x00006F22 File Offset: 0x00005122
	public unsafe AscensionCardManager m_cardManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_cardManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCardManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_cardManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002D8 RID: 728
	// (get) Token: 0x060007EB RID: 2027 RVA: 0x000314C0 File Offset: 0x0002F6C0
	// (set) Token: 0x060007EC RID: 2028 RVA: 0x00006F41 File Offset: 0x00005141
	public unsafe TrayToggleMultipleOwners m_activeTray
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_activeTray);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrayToggleMultipleOwners>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_activeTray), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002D9 RID: 729
	// (get) Token: 0x060007ED RID: 2029 RVA: 0x000314F0 File Offset: 0x0002F6F0
	// (set) Token: 0x060007EE RID: 2030 RVA: 0x00006F60 File Offset: 0x00005160
	public unsafe ScrollRect m_scrollRect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_scrollRect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002DA RID: 730
	// (get) Token: 0x060007EF RID: 2031 RVA: 0x00031520 File Offset: 0x0002F720
	// (set) Token: 0x060007F0 RID: 2032 RVA: 0x00006F7F File Offset: 0x0000517F
	public unsafe AscensionAnimationLocator m_contentContainer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_contentContainer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_contentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002DB RID: 731
	// (get) Token: 0x060007F1 RID: 2033 RVA: 0x00031550 File Offset: 0x0002F750
	// (set) Token: 0x060007F2 RID: 2034 RVA: 0x00006F9E File Offset: 0x0000519E
	public unsafe GameObject m_arrowLeft
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_arrowLeft);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_arrowLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002DC RID: 732
	// (get) Token: 0x060007F3 RID: 2035 RVA: 0x00031580 File Offset: 0x0002F780
	// (set) Token: 0x060007F4 RID: 2036 RVA: 0x00006FBD File Offset: 0x000051BD
	public unsafe GameObject m_arrowRight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_arrowRight);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_arrowRight), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002DD RID: 733
	// (get) Token: 0x060007F5 RID: 2037 RVA: 0x000315B0 File Offset: 0x0002F7B0
	// (set) Token: 0x060007F6 RID: 2038 RVA: 0x00006FDC File Offset: 0x000051DC
	public unsafe List<PlayerDisplay> m_opponentDisplays
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_opponentDisplays);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerDisplay>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_opponentDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002DE RID: 734
	// (get) Token: 0x060007F7 RID: 2039 RVA: 0x000315E0 File Offset: 0x0002F7E0
	// (set) Token: 0x060007F8 RID: 2040 RVA: 0x00006FFB File Offset: 0x000051FB
	public unsafe List<AscensionCard> m_cardList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_cardList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AscensionCard>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_cardList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002DF RID: 735
	// (get) Token: 0x060007F9 RID: 2041 RVA: 0x00031610 File Offset: 0x0002F810
	// (set) Token: 0x060007FA RID: 2042 RVA: 0x0000701A File Offset: 0x0000521A
	public unsafe int m_roundNumber
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_roundNumber);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_roundNumber)) = value;
		}
	}

	// Token: 0x170002E0 RID: 736
	// (get) Token: 0x060007FB RID: 2043 RVA: 0x00031638 File Offset: 0x0002F838
	// (set) Token: 0x060007FC RID: 2044 RVA: 0x00007035 File Offset: 0x00005235
	public unsafe int m_maxRound
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_maxRound);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_maxRound)) = value;
		}
	}

	// Token: 0x170002E1 RID: 737
	// (get) Token: 0x060007FD RID: 2045 RVA: 0x00031660 File Offset: 0x0002F860
	// (set) Token: 0x060007FE RID: 2046 RVA: 0x00007050 File Offset: 0x00005250
	public unsafe int m_oppDisplayed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_oppDisplayed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_oppDisplayed)) = value;
		}
	}

	// Token: 0x170002E2 RID: 738
	// (get) Token: 0x060007FF RID: 2047 RVA: 0x00031688 File Offset: 0x0002F888
	// (set) Token: 0x06000800 RID: 2048 RVA: 0x0000706B File Offset: 0x0000526B
	public unsafe bool m_bUpdateListPos
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_bUpdateListPos);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog.NativeFieldInfoPtr_m_bUpdateListPos)) = value;
		}
	}

	// Token: 0x040004DE RID: 1246
	private static readonly IntPtr NativeFieldInfoPtr_m_roundText;

	// Token: 0x040004DF RID: 1247
	private static readonly IntPtr NativeFieldInfoPtr_m_cardManager;

	// Token: 0x040004E0 RID: 1248
	private static readonly IntPtr NativeFieldInfoPtr_m_activeTray;

	// Token: 0x040004E1 RID: 1249
	private static readonly IntPtr NativeFieldInfoPtr_m_scrollRect;

	// Token: 0x040004E2 RID: 1250
	private static readonly IntPtr NativeFieldInfoPtr_m_contentContainer;

	// Token: 0x040004E3 RID: 1251
	private static readonly IntPtr NativeFieldInfoPtr_m_arrowLeft;

	// Token: 0x040004E4 RID: 1252
	private static readonly IntPtr NativeFieldInfoPtr_m_arrowRight;

	// Token: 0x040004E5 RID: 1253
	private static readonly IntPtr NativeFieldInfoPtr_m_opponentDisplays;

	// Token: 0x040004E6 RID: 1254
	private static readonly IntPtr NativeFieldInfoPtr_m_cardList;

	// Token: 0x040004E7 RID: 1255
	private static readonly IntPtr NativeFieldInfoPtr_m_roundNumber;

	// Token: 0x040004E8 RID: 1256
	private static readonly IntPtr NativeFieldInfoPtr_m_maxRound;

	// Token: 0x040004E9 RID: 1257
	private static readonly IntPtr NativeFieldInfoPtr_m_oppDisplayed;

	// Token: 0x040004EA RID: 1258
	private static readonly IntPtr NativeFieldInfoPtr_m_bUpdateListPos;

	// Token: 0x040004EB RID: 1259
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x040004EC RID: 1260
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x040004ED RID: 1261
	private static readonly IntPtr NativeMethodInfoPtr_RegisterOpponentDisplay_Public_Void_PlayerDisplay_0;

	// Token: 0x040004EE RID: 1262
	private static readonly IntPtr NativeMethodInfoPtr_ClearRegisteredDisplays_Public_Void_0;

	// Token: 0x040004EF RID: 1263
	private static readonly IntPtr NativeMethodInfoPtr_SetGameCurrentRound_Public_Void_Int32_0;

	// Token: 0x040004F0 RID: 1264
	private static readonly IntPtr NativeMethodInfoPtr_MoveLeft_Public_Void_0;

	// Token: 0x040004F1 RID: 1265
	private static readonly IntPtr NativeMethodInfoPtr_MoveRight_Public_Void_0;

	// Token: 0x040004F2 RID: 1266
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x040004F3 RID: 1267
	private static readonly IntPtr NativeMethodInfoPtr_ClearCardList_Private_Void_0;

	// Token: 0x040004F4 RID: 1268
	private static readonly IntPtr NativeMethodInfoPtr_RebuildList_Private_Void_0;

	// Token: 0x040004F5 RID: 1269
	private static readonly IntPtr NativeMethodInfoPtr_RebuildListAddative_Private_Void_0;

	// Token: 0x040004F6 RID: 1270
	private static readonly IntPtr NativeMethodInfoPtr_CheckVisibility_Private_Void_0;

	// Token: 0x040004F7 RID: 1271
	private static readonly IntPtr NativeMethodInfoPtr_ResetScrollPosition_Private_IEnumerator_0;

	// Token: 0x040004F8 RID: 1272
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200016D RID: 365
	[ObfuscatedName("AscensionLog+<ResetScrollPosition>d__25")]
	public sealed class _ResetScrollPosition_d__25 : global::Il2CppSystem.Object
	{
		// Token: 0x060022E8 RID: 8936 RVA: 0x00082D08 File Offset: 0x00080F08
		// Note: this type is marked as 'beforefieldinit'.
		static _ResetScrollPosition_d__25()
		{
			Il2CppClassPointerStore<AscensionLog._ResetScrollPosition_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionLog>.NativeClassPtr, "<ResetScrollPosition>d__25");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionLog._ResetScrollPosition_d__25>.NativeClassPtr);
			AscensionLog._ResetScrollPosition_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionLog._ResetScrollPosition_d__25>.NativeClassPtr, "<>1__state");
			AscensionLog._ResetScrollPosition_d__25.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionLog._ResetScrollPosition_d__25>.NativeClassPtr, "<>2__current");
			AscensionLog._ResetScrollPosition_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionLog._ResetScrollPosition_d__25>.NativeClassPtr, "<>4__this");
			AscensionLog._ResetScrollPosition_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog._ResetScrollPosition_d__25>.NativeClassPtr, 100666046);
			AscensionLog._ResetScrollPosition_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog._ResetScrollPosition_d__25>.NativeClassPtr, 100666047);
			AscensionLog._ResetScrollPosition_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog._ResetScrollPosition_d__25>.NativeClassPtr, 100666048);
			AscensionLog._ResetScrollPosition_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog._ResetScrollPosition_d__25>.NativeClassPtr, 100666049);
			AscensionLog._ResetScrollPosition_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog._ResetScrollPosition_d__25>.NativeClassPtr, 100666050);
			AscensionLog._ResetScrollPosition_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionLog._ResetScrollPosition_d__25>.NativeClassPtr, 100666051);
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x00082DE8 File Offset: 0x00080FE8
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ResetScrollPosition_d__25(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionLog._ResetScrollPosition_d__25>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog._ResetScrollPosition_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x00082E30 File Offset: 0x00081030
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog._ResetScrollPosition_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x00082E64 File Offset: 0x00081064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233722, XrefRangeEnd = 233726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog._ResetScrollPosition_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x060022EC RID: 8940 RVA: 0x00082EA0 File Offset: 0x000810A0
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog._ResetScrollPosition_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x00082EE0 File Offset: 0x000810E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233726, XrefRangeEnd = 233731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog._ResetScrollPosition_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x00082F14 File Offset: 0x00081114
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionLog._ResetScrollPosition_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x00015F2A File Offset: 0x0001412A
		public _ResetScrollPosition_d__25(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x060022F0 RID: 8944 RVA: 0x00082F54 File Offset: 0x00081154
		// (set) Token: 0x060022F1 RID: 8945 RVA: 0x00015F33 File Offset: 0x00014133
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog._ResetScrollPosition_d__25.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog._ResetScrollPosition_d__25.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x060022F2 RID: 8946 RVA: 0x00082F7C File Offset: 0x0008117C
		// (set) Token: 0x060022F3 RID: 8947 RVA: 0x00015F4E File Offset: 0x0001414E
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog._ResetScrollPosition_d__25.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog._ResetScrollPosition_d__25.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x00082FAC File Offset: 0x000811AC
		// (set) Token: 0x060022F5 RID: 8949 RVA: 0x00015F6D File Offset: 0x0001416D
		public unsafe AscensionLog __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog._ResetScrollPosition_d__25.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionLog>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionLog._ResetScrollPosition_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001838 RID: 6200
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001839 RID: 6201
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400183A RID: 6202
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400183B RID: 6203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400183C RID: 6204
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400183D RID: 6205
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400183E RID: 6206
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400183F RID: 6207
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001840 RID: 6208
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

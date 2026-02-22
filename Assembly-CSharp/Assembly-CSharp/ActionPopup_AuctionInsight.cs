using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;

// Token: 0x02000007 RID: 7
public class ActionPopup_AuctionInsight : PopupBase
{
	// Token: 0x06000042 RID: 66 RVA: 0x0001BAAC File Offset: 0x00019CAC
	// Note: this type is marked as 'beforefieldinit'.
	static ActionPopup_AuctionInsight()
	{
		Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ActionPopup_AuctionInsight");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr);
		ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_topDisplayText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, "m_topDisplayText");
		ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_MainDisplayInsightObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, "m_MainDisplayInsightObj");
		ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_MainDisplayInsightText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, "m_MainDisplayInsightText");
		ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, "m_confirmButton");
		ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_confirmButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, "m_confirmButtonText");
		ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_BidderDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, "m_BidderDisplays");
		ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_HighBidPromptText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, "m_HighBidPromptText");
		ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_HighBidInsightIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, "m_HighBidInsightIcon");
		ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_HighBidInsightText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, "m_HighBidInsightText");
		ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_CardManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, "m_CardManager");
		ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_AnimationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, "m_AnimationManager");
		ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_AuctionCardLocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, "m_AuctionCardLocator");
		ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_AuctionCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, "m_AuctionCard");
		ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_bIsHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, "m_bIsHidden");
		ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_currentInsight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, "m_currentInsight");
		ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_insightMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, "m_insightMin");
		ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_insightMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, "m_insightMax");
		ActionPopup_AuctionInsight.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, 100663331);
		ActionPopup_AuctionInsight.NativeMethodInfoPtr_BlockGameUpdate_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, 100663332);
		ActionPopup_AuctionInsight.NativeMethodInfoPtr_ActivatePopup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, 100663333);
		ActionPopup_AuctionInsight.NativeMethodInfoPtr_DismissPopup_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, 100663334);
		ActionPopup_AuctionInsight.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, 100663335);
		ActionPopup_AuctionInsight.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, 100663336);
		ActionPopup_AuctionInsight.NativeMethodInfoPtr_HidePopup_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, 100663337);
		ActionPopup_AuctionInsight.NativeMethodInfoPtr_SetHideValue_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, 100663338);
		ActionPopup_AuctionInsight.NativeMethodInfoPtr_GetIsHidden_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, 100663339);
		ActionPopup_AuctionInsight.NativeMethodInfoPtr_UpdateDisplay_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, 100663340);
		ActionPopup_AuctionInsight.NativeMethodInfoPtr_UpdateCountsAndButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, 100663341);
		ActionPopup_AuctionInsight.NativeMethodInfoPtr_OnInsightHit_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, 100663342);
		ActionPopup_AuctionInsight.NativeMethodInfoPtr_OnActionButtonBid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, 100663343);
		ActionPopup_AuctionInsight.NativeMethodInfoPtr_OnActionButtonPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, 100663344);
		ActionPopup_AuctionInsight.NativeMethodInfoPtr_SetAuctionCard_Private_Void_AscensionAnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, 100663345);
		ActionPopup_AuctionInsight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, 100663346);
	}

	// Token: 0x06000043 RID: 67 RVA: 0x0001BD70 File Offset: 0x00019F70
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_AuctionInsight.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000044 RID: 68 RVA: 0x0001BDA4 File Offset: 0x00019FA4
	[CallerCount(48)]
	[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool BlockGameUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionPopup_AuctionInsight.NativeMethodInfoPtr_BlockGameUpdate_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000045 RID: 69 RVA: 0x0001BDEC File Offset: 0x00019FEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224175, XrefRangeEnd = 224178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ActivatePopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionPopup_AuctionInsight.NativeMethodInfoPtr_ActivatePopup_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000046 RID: 70 RVA: 0x0001BE28 File Offset: 0x0001A028
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224178, XrefRangeEnd = 224181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void DismissPopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionPopup_AuctionInsight.NativeMethodInfoPtr_DismissPopup_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x0001BE64 File Offset: 0x0001A064
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224181, XrefRangeEnd = 224184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetActive(bool bActive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_AuctionInsight.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000048 RID: 72 RVA: 0x0001BEA4 File Offset: 0x0001A0A4
	[CallerCount(0)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_AuctionInsight.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000049 RID: 73 RVA: 0x0001BED8 File Offset: 0x0001A0D8
	[CallerCount(0)]
	public unsafe void HidePopup(bool bIsHidden)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bIsHidden;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_AuctionInsight.NativeMethodInfoPtr_HidePopup_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600004A RID: 74 RVA: 0x0001BF18 File Offset: 0x0001A118
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224184, XrefRangeEnd = 224185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHideValue(bool bIsHidden)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bIsHidden;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_AuctionInsight.NativeMethodInfoPtr_SetHideValue_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600004B RID: 75 RVA: 0x0001BF58 File Offset: 0x0001A158
	[CallerCount(0)]
	public unsafe override bool GetIsHidden()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionPopup_AuctionInsight.NativeMethodInfoPtr_GetIsHidden_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600004C RID: 76 RVA: 0x0001BFA0 File Offset: 0x0001A1A0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 224335, RefRangeEnd = 224336, XrefRangeStart = 224185, XrefRangeEnd = 224335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDisplay(int playerIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_AuctionInsight.NativeMethodInfoPtr_UpdateDisplay_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600004D RID: 77 RVA: 0x0001BFE0 File Offset: 0x0001A1E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224336, XrefRangeEnd = 224339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCountsAndButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_AuctionInsight.NativeMethodInfoPtr_UpdateCountsAndButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600004E RID: 78 RVA: 0x0001C014 File Offset: 0x0001A214
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224339, XrefRangeEnd = 224343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInsightHit(int change)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_AuctionInsight.NativeMethodInfoPtr_OnInsightHit_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600004F RID: 79 RVA: 0x0001C054 File Offset: 0x0001A254
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224343, XrefRangeEnd = 224347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnActionButtonBid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_AuctionInsight.NativeMethodInfoPtr_OnActionButtonBid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000050 RID: 80 RVA: 0x0001C088 File Offset: 0x0001A288
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224347, XrefRangeEnd = 224351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnActionButtonPass()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_AuctionInsight.NativeMethodInfoPtr_OnActionButtonPass_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000051 RID: 81 RVA: 0x0001C0BC File Offset: 0x0001A2BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224351, XrefRangeEnd = 224360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAuctionCard(AscensionAnimationLocator resolvePosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolvePosition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_AuctionInsight.NativeMethodInfoPtr_SetAuctionCard_Private_Void_AscensionAnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000052 RID: 82 RVA: 0x0001C100 File Offset: 0x0001A300
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114494, XrefRangeEnd = 114502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActionPopup_AuctionInsight()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionPopup_AuctionInsight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000053 RID: 83 RVA: 0x0000219A File Offset: 0x0000039A
	public ActionPopup_AuctionInsight(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000054 RID: 84 RVA: 0x0001C13C File Offset: 0x0001A33C
	// (set) Token: 0x06000055 RID: 85 RVA: 0x000021A3 File Offset: 0x000003A3
	public unsafe TextMeshProUGUI m_topDisplayText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_topDisplayText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_topDisplayText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000056 RID: 86 RVA: 0x0001C16C File Offset: 0x0001A36C
	// (set) Token: 0x06000057 RID: 87 RVA: 0x000021C2 File Offset: 0x000003C2
	public unsafe GameObject m_MainDisplayInsightObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_MainDisplayInsightObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_MainDisplayInsightObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000058 RID: 88 RVA: 0x0001C19C File Offset: 0x0001A39C
	// (set) Token: 0x06000059 RID: 89 RVA: 0x000021E1 File Offset: 0x000003E1
	public unsafe TextMeshProUGUI m_MainDisplayInsightText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_MainDisplayInsightText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_MainDisplayInsightText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x0600005A RID: 90 RVA: 0x0001C1CC File Offset: 0x0001A3CC
	// (set) Token: 0x0600005B RID: 91 RVA: 0x00002200 File Offset: 0x00000400
	public unsafe GameObject m_confirmButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_confirmButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x0600005C RID: 92 RVA: 0x0001C1FC File Offset: 0x0001A3FC
	// (set) Token: 0x0600005D RID: 93 RVA: 0x0000221F File Offset: 0x0000041F
	public unsafe TextMeshProUGUI m_confirmButtonText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_confirmButtonText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_confirmButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x0600005E RID: 94 RVA: 0x0001C22C File Offset: 0x0001A42C
	// (set) Token: 0x0600005F RID: 95 RVA: 0x0000223E File Offset: 0x0000043E
	public unsafe Il2CppReferenceArray<ActionPopup_AuctionInsight.BidderDisplay> m_BidderDisplays
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_BidderDisplays);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ActionPopup_AuctionInsight.BidderDisplay>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_BidderDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000060 RID: 96 RVA: 0x0001C25C File Offset: 0x0001A45C
	// (set) Token: 0x06000061 RID: 97 RVA: 0x0000225D File Offset: 0x0000045D
	public unsafe TextMeshProUGUI m_HighBidPromptText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_HighBidPromptText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_HighBidPromptText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000062 RID: 98 RVA: 0x0001C28C File Offset: 0x0001A48C
	// (set) Token: 0x06000063 RID: 99 RVA: 0x0000227C File Offset: 0x0000047C
	public unsafe GameObject m_HighBidInsightIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_HighBidInsightIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_HighBidInsightIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000064 RID: 100 RVA: 0x0001C2BC File Offset: 0x0001A4BC
	// (set) Token: 0x06000065 RID: 101 RVA: 0x0000229B File Offset: 0x0000049B
	public unsafe TextMeshProUGUI m_HighBidInsightText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_HighBidInsightText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_HighBidInsightText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000066 RID: 102 RVA: 0x0001C2EC File Offset: 0x0001A4EC
	// (set) Token: 0x06000067 RID: 103 RVA: 0x000022BA File Offset: 0x000004BA
	public unsafe AscensionCardManager m_CardManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_CardManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCardManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_CardManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000068 RID: 104 RVA: 0x0001C31C File Offset: 0x0001A51C
	// (set) Token: 0x06000069 RID: 105 RVA: 0x000022D9 File Offset: 0x000004D9
	public unsafe AscensionAnimationManager m_AnimationManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_AnimationManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_AnimationManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x0600006A RID: 106 RVA: 0x0001C34C File Offset: 0x0001A54C
	// (set) Token: 0x0600006B RID: 107 RVA: 0x000022F8 File Offset: 0x000004F8
	public unsafe AscensionAnimationLocator m_AuctionCardLocator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_AuctionCardLocator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_AuctionCardLocator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x0600006C RID: 108 RVA: 0x0001C37C File Offset: 0x0001A57C
	// (set) Token: 0x0600006D RID: 109 RVA: 0x00002317 File Offset: 0x00000517
	public unsafe AnimateObject m_AuctionCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_AuctionCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimateObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_AuctionCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x0600006E RID: 110 RVA: 0x0001C3AC File Offset: 0x0001A5AC
	// (set) Token: 0x0600006F RID: 111 RVA: 0x00002336 File Offset: 0x00000536
	public unsafe bool m_bIsHidden
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_bIsHidden);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_bIsHidden)) = value;
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000070 RID: 112 RVA: 0x0001C3D4 File Offset: 0x0001A5D4
	// (set) Token: 0x06000071 RID: 113 RVA: 0x00002351 File Offset: 0x00000551
	public unsafe int m_currentInsight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_currentInsight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_currentInsight)) = value;
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000072 RID: 114 RVA: 0x0001C3FC File Offset: 0x0001A5FC
	// (set) Token: 0x06000073 RID: 115 RVA: 0x0000236C File Offset: 0x0000056C
	public unsafe int m_insightMin
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_insightMin);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_insightMin)) = value;
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x06000074 RID: 116 RVA: 0x0001C424 File Offset: 0x0001A624
	// (set) Token: 0x06000075 RID: 117 RVA: 0x00002387 File Offset: 0x00000587
	public unsafe int m_insightMax
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_insightMax);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.NativeFieldInfoPtr_m_insightMax)) = value;
		}
	}

	// Token: 0x0400002D RID: 45
	private static readonly IntPtr NativeFieldInfoPtr_m_topDisplayText;

	// Token: 0x0400002E RID: 46
	private static readonly IntPtr NativeFieldInfoPtr_m_MainDisplayInsightObj;

	// Token: 0x0400002F RID: 47
	private static readonly IntPtr NativeFieldInfoPtr_m_MainDisplayInsightText;

	// Token: 0x04000030 RID: 48
	private static readonly IntPtr NativeFieldInfoPtr_m_confirmButton;

	// Token: 0x04000031 RID: 49
	private static readonly IntPtr NativeFieldInfoPtr_m_confirmButtonText;

	// Token: 0x04000032 RID: 50
	private static readonly IntPtr NativeFieldInfoPtr_m_BidderDisplays;

	// Token: 0x04000033 RID: 51
	private static readonly IntPtr NativeFieldInfoPtr_m_HighBidPromptText;

	// Token: 0x04000034 RID: 52
	private static readonly IntPtr NativeFieldInfoPtr_m_HighBidInsightIcon;

	// Token: 0x04000035 RID: 53
	private static readonly IntPtr NativeFieldInfoPtr_m_HighBidInsightText;

	// Token: 0x04000036 RID: 54
	private static readonly IntPtr NativeFieldInfoPtr_m_CardManager;

	// Token: 0x04000037 RID: 55
	private static readonly IntPtr NativeFieldInfoPtr_m_AnimationManager;

	// Token: 0x04000038 RID: 56
	private static readonly IntPtr NativeFieldInfoPtr_m_AuctionCardLocator;

	// Token: 0x04000039 RID: 57
	private static readonly IntPtr NativeFieldInfoPtr_m_AuctionCard;

	// Token: 0x0400003A RID: 58
	private static readonly IntPtr NativeFieldInfoPtr_m_bIsHidden;

	// Token: 0x0400003B RID: 59
	private static readonly IntPtr NativeFieldInfoPtr_m_currentInsight;

	// Token: 0x0400003C RID: 60
	private static readonly IntPtr NativeFieldInfoPtr_m_insightMin;

	// Token: 0x0400003D RID: 61
	private static readonly IntPtr NativeFieldInfoPtr_m_insightMax;

	// Token: 0x0400003E RID: 62
	private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

	// Token: 0x0400003F RID: 63
	private static readonly IntPtr NativeMethodInfoPtr_BlockGameUpdate_Public_Virtual_Boolean_0;

	// Token: 0x04000040 RID: 64
	private static readonly IntPtr NativeMethodInfoPtr_ActivatePopup_Public_Virtual_Void_0;

	// Token: 0x04000041 RID: 65
	private static readonly IntPtr NativeMethodInfoPtr_DismissPopup_Public_Virtual_Void_0;

	// Token: 0x04000042 RID: 66
	private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

	// Token: 0x04000043 RID: 67
	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	// Token: 0x04000044 RID: 68
	private static readonly IntPtr NativeMethodInfoPtr_HidePopup_Private_Void_Boolean_0;

	// Token: 0x04000045 RID: 69
	private static readonly IntPtr NativeMethodInfoPtr_SetHideValue_Public_Void_Boolean_0;

	// Token: 0x04000046 RID: 70
	private static readonly IntPtr NativeMethodInfoPtr_GetIsHidden_Public_Virtual_Boolean_0;

	// Token: 0x04000047 RID: 71
	private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplay_Public_Void_Int32_0;

	// Token: 0x04000048 RID: 72
	private static readonly IntPtr NativeMethodInfoPtr_UpdateCountsAndButton_Public_Void_0;

	// Token: 0x04000049 RID: 73
	private static readonly IntPtr NativeMethodInfoPtr_OnInsightHit_Public_Void_Int32_0;

	// Token: 0x0400004A RID: 74
	private static readonly IntPtr NativeMethodInfoPtr_OnActionButtonBid_Public_Void_0;

	// Token: 0x0400004B RID: 75
	private static readonly IntPtr NativeMethodInfoPtr_OnActionButtonPass_Public_Void_0;

	// Token: 0x0400004C RID: 76
	private static readonly IntPtr NativeMethodInfoPtr_SetAuctionCard_Private_Void_AscensionAnimationLocator_0;

	// Token: 0x0400004D RID: 77
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000161 RID: 353
	[Serializable]
	public sealed class BidderDisplay : ValueType
	{
		// Token: 0x06002249 RID: 8777 RVA: 0x000811A0 File Offset: 0x0007F3A0
		// Note: this type is marked as 'beforefieldinit'.
		static BidderDisplay()
		{
			Il2CppClassPointerStore<ActionPopup_AuctionInsight.BidderDisplay>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionPopup_AuctionInsight>.NativeClassPtr, "BidderDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionPopup_AuctionInsight.BidderDisplay>.NativeClassPtr);
			ActionPopup_AuctionInsight.BidderDisplay.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight.BidderDisplay>.NativeClassPtr, "root");
			ActionPopup_AuctionInsight.BidderDisplay.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight.BidderDisplay>.NativeClassPtr, "avatar");
			ActionPopup_AuctionInsight.BidderDisplay.NativeFieldInfoPtr_textPlayerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight.BidderDisplay>.NativeClassPtr, "textPlayerName");
			ActionPopup_AuctionInsight.BidderDisplay.NativeFieldInfoPtr_playerAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight.BidderDisplay>.NativeClassPtr, "playerAvatar");
			ActionPopup_AuctionInsight.BidderDisplay.NativeFieldInfoPtr_playerInsightDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight.BidderDisplay>.NativeClassPtr, "playerInsightDisplay");
			ActionPopup_AuctionInsight.BidderDisplay.NativeFieldInfoPtr_playerInsightValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionPopup_AuctionInsight.BidderDisplay>.NativeClassPtr, "playerInsightValue");
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x0001598E File Offset: 0x00013B8E
		public BidderDisplay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x00015997 File Offset: 0x00013B97
		public BidderDisplay()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionPopup_AuctionInsight.BidderDisplay>.NativeClassPtr))
		{
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x00081244 File Offset: 0x0007F444
		// (set) Token: 0x0600224D RID: 8781 RVA: 0x000159A9 File Offset: 0x00013BA9
		public unsafe GameObject root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.BidderDisplay.NativeFieldInfoPtr_root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.BidderDisplay.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x00081274 File Offset: 0x0007F474
		// (set) Token: 0x0600224F RID: 8783 RVA: 0x000159C8 File Offset: 0x00013BC8
		public unsafe Avatar_UI avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.BidderDisplay.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.BidderDisplay.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x000812A4 File Offset: 0x0007F4A4
		// (set) Token: 0x06002251 RID: 8785 RVA: 0x000159E7 File Offset: 0x00013BE7
		public unsafe TextMeshProUGUI textPlayerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.BidderDisplay.NativeFieldInfoPtr_textPlayerName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.BidderDisplay.NativeFieldInfoPtr_textPlayerName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x000812D4 File Offset: 0x0007F4D4
		// (set) Token: 0x06002253 RID: 8787 RVA: 0x00015A06 File Offset: 0x00013C06
		public unsafe Avatar_UI playerAvatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.BidderDisplay.NativeFieldInfoPtr_playerAvatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.BidderDisplay.NativeFieldInfoPtr_playerAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x00081304 File Offset: 0x0007F504
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x00015A25 File Offset: 0x00013C25
		public unsafe GameObject playerInsightDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.BidderDisplay.NativeFieldInfoPtr_playerInsightDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.BidderDisplay.NativeFieldInfoPtr_playerInsightDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x00081334 File Offset: 0x0007F534
		// (set) Token: 0x06002257 RID: 8791 RVA: 0x00015A44 File Offset: 0x00013C44
		public unsafe TextMeshProUGUI playerInsightValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.BidderDisplay.NativeFieldInfoPtr_playerInsightValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionPopup_AuctionInsight.BidderDisplay.NativeFieldInfoPtr_playerInsightValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017DC RID: 6108
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x040017DD RID: 6109
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x040017DE RID: 6110
		private static readonly IntPtr NativeFieldInfoPtr_textPlayerName;

		// Token: 0x040017DF RID: 6111
		private static readonly IntPtr NativeFieldInfoPtr_playerAvatar;

		// Token: 0x040017E0 RID: 6112
		private static readonly IntPtr NativeFieldInfoPtr_playerInsightDisplay;

		// Token: 0x040017E1 RID: 6113
		private static readonly IntPtr NativeFieldInfoPtr_playerInsightValue;
	}
}

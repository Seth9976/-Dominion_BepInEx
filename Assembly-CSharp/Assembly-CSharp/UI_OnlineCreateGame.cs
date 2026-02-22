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

// Token: 0x020000D7 RID: 215
public class UI_OnlineCreateGame : UI_NetworkBase
{
	// Token: 0x060019EF RID: 6639 RVA: 0x00067E68 File Offset: 0x00066068
	// Note: this type is marked as 'beforefieldinit'.
	static UI_OnlineCreateGame()
	{
		Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_OnlineCreateGame");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr);
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_playerSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_playerSlots");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_setToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_setToggles");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_promoToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_promoToggles");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_setLocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_setLocks");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_promoLocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_promoLocks");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_profileList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_profileList");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_profileListPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_profileListPopup");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_timerValueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_timerValueText");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_minDialogDisplayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_minDialogDisplayTime");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_defaultDraggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_defaultDraggable");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_gameTimeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_gameTimeIndex");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_delayCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_delayCoroutine");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_createGameReplyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_createGameReplyData");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_bMinDialogDisplayTimeReached");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_bProcessCreateGameReply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_bProcessCreateGameReply");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_bHandlePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_bHandlePopup");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_bCreateSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_bCreateSuccess");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_bIgnoreToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_bIgnoreToggles");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_setFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_setFlags");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_promoFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_promoFlags");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_inviteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_inviteIndex");
		UI_OnlineCreateGame.NativeFieldInfoPtr_m_InAppPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "m_InAppPurchase");
		UI_OnlineCreateGame.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665346);
		UI_OnlineCreateGame.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665347);
		UI_OnlineCreateGame.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_Profile_ClickEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665348);
		UI_OnlineCreateGame.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665349);
		UI_OnlineCreateGame.NativeMethodInfoPtr_PopulateSlot_Private_Void_FriendInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665350);
		UI_OnlineCreateGame.NativeMethodInfoPtr_ClearInviteSlot_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665351);
		UI_OnlineCreateGame.NativeMethodInfoPtr_OnCreateGameButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665352);
		UI_OnlineCreateGame.NativeMethodInfoPtr_HandleCreateCanceled_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665353);
		UI_OnlineCreateGame.NativeMethodInfoPtr_HandleBackFromPopup_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665354);
		UI_OnlineCreateGame.NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665355);
		UI_OnlineCreateGame.NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665356);
		UI_OnlineCreateGame.NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665357);
		UI_OnlineCreateGame.NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665358);
		UI_OnlineCreateGame.NativeMethodInfoPtr_ProcessCreateGameReply_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665359);
		UI_OnlineCreateGame.NativeMethodInfoPtr_DelayCloseAfterSuccess_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665360);
		UI_OnlineCreateGame.NativeMethodInfoPtr_OnTimerButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665361);
		UI_OnlineCreateGame.NativeMethodInfoPtr_UpdateTimerLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665362);
		UI_OnlineCreateGame.NativeMethodInfoPtr_OnPlayerPressed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665363);
		UI_OnlineCreateGame.NativeMethodInfoPtr_OnGameTypeChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665364);
		UI_OnlineCreateGame.NativeMethodInfoPtr_UpdatePlayerStates_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665365);
		UI_OnlineCreateGame.NativeMethodInfoPtr_ShowInvitePopup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665366);
		UI_OnlineCreateGame.NativeMethodInfoPtr_HideInvitePopup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665367);
		UI_OnlineCreateGame.NativeMethodInfoPtr_ShowInvitePopup_OneSlot_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665368);
		UI_OnlineCreateGame.NativeMethodInfoPtr_HandleInvites_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665369);
		UI_OnlineCreateGame.NativeMethodInfoPtr_CreateGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665370);
		UI_OnlineCreateGame.NativeMethodInfoPtr_RetreiveSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665371);
		UI_OnlineCreateGame.NativeMethodInfoPtr_StoreSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665372);
		UI_OnlineCreateGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, 100665373);
	}

	// Token: 0x060019F0 RID: 6640 RVA: 0x00068280 File Offset: 0x00066480
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251148, XrefRangeEnd = 251170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060019F1 RID: 6641 RVA: 0x000682B4 File Offset: 0x000664B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251170, XrefRangeEnd = 251252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnterMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060019F2 RID: 6642 RVA: 0x000682E8 File Offset: 0x000664E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251252, XrefRangeEnd = 251256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleClickOnSlot(UIP_Profile slot, UIP_Profile.ClickEventType evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_Profile_ClickEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060019F3 RID: 6643 RVA: 0x00068338 File Offset: 0x00066538
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251256, XrefRangeEnd = 251259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExitMenu(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060019F4 RID: 6644 RVA: 0x00068378 File Offset: 0x00066578
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 251265, RefRangeEnd = 251273, XrefRangeStart = 251259, XrefRangeEnd = 251265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PopulateSlot(FriendInfo friend, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(friend));
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_PopulateSlot_Private_Void_FriendInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060019F5 RID: 6645 RVA: 0x000683D0 File Offset: 0x000665D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251273, XrefRangeEnd = 251274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearInviteSlot(int slotIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref slotIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_ClearInviteSlot_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060019F6 RID: 6646 RVA: 0x00068410 File Offset: 0x00066610
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251274, XrefRangeEnd = 251307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCreateGameButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_OnCreateGameButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060019F7 RID: 6647 RVA: 0x00068444 File Offset: 0x00066644
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251307, XrefRangeEnd = 251308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleCreateCanceled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_HandleCreateCanceled_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060019F8 RID: 6648 RVA: 0x00068478 File Offset: 0x00066678
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251308, XrefRangeEnd = 251312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator HandleBackFromPopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_HandleBackFromPopup_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060019F9 RID: 6649 RVA: 0x000684B8 File Offset: 0x000666B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251312, XrefRangeEnd = 251316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ProcessDelayTime(float totalDelayTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref totalDelayTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x060019FA RID: 6650 RVA: 0x00068504 File Offset: 0x00066704
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NetworkStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_OnlineCreateGame.NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060019FB RID: 6651 RVA: 0x00068540 File Offset: 0x00066740
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NetworkOnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_OnlineCreateGame.NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060019FC RID: 6652 RVA: 0x0006857C File Offset: 0x0006677C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251316, XrefRangeEnd = 251317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NetworkEventCallback(NetworkEvent.EventType eventType, int eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventData;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_OnlineCreateGame.NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060019FD RID: 6653 RVA: 0x000685D4 File Offset: 0x000667D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251317, XrefRangeEnd = 251353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessCreateGameReply(int eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_ProcessCreateGameReply_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060019FE RID: 6654 RVA: 0x00068614 File Offset: 0x00066814
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251353, XrefRangeEnd = 251357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator DelayCloseAfterSuccess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_DelayCloseAfterSuccess_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060019FF RID: 6655 RVA: 0x00068654 File Offset: 0x00066854
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251357, XrefRangeEnd = 251363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTimerButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_OnTimerButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A00 RID: 6656 RVA: 0x00068688 File Offset: 0x00066888
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 251370, RefRangeEnd = 251373, XrefRangeStart = 251363, XrefRangeEnd = 251370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTimerLabel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_UpdateTimerLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A01 RID: 6657 RVA: 0x000686BC File Offset: 0x000668BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251373, XrefRangeEnd = 251414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerPressed(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_OnPlayerPressed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001A02 RID: 6658 RVA: 0x000686FC File Offset: 0x000668FC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 251422, RefRangeEnd = 251424, XrefRangeStart = 251414, XrefRangeEnd = 251422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGameTypeChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_OnGameTypeChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A03 RID: 6659 RVA: 0x00068730 File Offset: 0x00066930
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 251426, RefRangeEnd = 251429, XrefRangeStart = 251424, XrefRangeEnd = 251426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePlayerStates()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_UpdatePlayerStates_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A04 RID: 6660 RVA: 0x00068764 File Offset: 0x00066964
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251429, XrefRangeEnd = 251437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowInvitePopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_ShowInvitePopup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A05 RID: 6661 RVA: 0x00068798 File Offset: 0x00066998
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251437, XrefRangeEnd = 251439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideInvitePopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_HideInvitePopup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A06 RID: 6662 RVA: 0x000687CC File Offset: 0x000669CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251439, XrefRangeEnd = 251451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowInvitePopup_OneSlot(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_ShowInvitePopup_OneSlot_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001A07 RID: 6663 RVA: 0x0006880C File Offset: 0x00066A0C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251451, XrefRangeEnd = 251477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleInvites()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_HandleInvites_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A08 RID: 6664 RVA: 0x00068840 File Offset: 0x00066A40
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 251493, RefRangeEnd = 251494, XrefRangeStart = 251477, XrefRangeEnd = 251493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateGame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_CreateGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A09 RID: 6665 RVA: 0x00068874 File Offset: 0x00066A74
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 251627, RefRangeEnd = 251628, XrefRangeStart = 251494, XrefRangeEnd = 251627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RetreiveSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_RetreiveSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A0A RID: 6666 RVA: 0x000688A8 File Offset: 0x00066AA8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 251708, RefRangeEnd = 251709, XrefRangeStart = 251628, XrefRangeEnd = 251708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StoreSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr_StoreSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A0B RID: 6667 RVA: 0x000688DC File Offset: 0x00066ADC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251709, XrefRangeEnd = 251713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_OnlineCreateGame()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A0C RID: 6668 RVA: 0x00010AC8 File Offset: 0x0000ECC8
	public UI_OnlineCreateGame(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000848 RID: 2120
	// (get) Token: 0x06001A0D RID: 6669 RVA: 0x00068918 File Offset: 0x00066B18
	// (set) Token: 0x06001A0E RID: 6670 RVA: 0x00010AD1 File Offset: 0x0000ECD1
	public unsafe Il2CppReferenceArray<UI_OnlineCreateGame.PlayerSlot> m_playerSlots
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_playerSlots);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UI_OnlineCreateGame.PlayerSlot>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_playerSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000849 RID: 2121
	// (get) Token: 0x06001A0F RID: 6671 RVA: 0x00068948 File Offset: 0x00066B48
	// (set) Token: 0x06001A10 RID: 6672 RVA: 0x00010AF0 File Offset: 0x0000ECF0
	public unsafe Il2CppReferenceArray<Toggle> m_setToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_setToggles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Toggle>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_setToggles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700084A RID: 2122
	// (get) Token: 0x06001A11 RID: 6673 RVA: 0x00068978 File Offset: 0x00066B78
	// (set) Token: 0x06001A12 RID: 6674 RVA: 0x00010B0F File Offset: 0x0000ED0F
	public unsafe Il2CppReferenceArray<Toggle> m_promoToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_promoToggles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Toggle>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_promoToggles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700084B RID: 2123
	// (get) Token: 0x06001A13 RID: 6675 RVA: 0x000689A8 File Offset: 0x00066BA8
	// (set) Token: 0x06001A14 RID: 6676 RVA: 0x00010B2E File Offset: 0x0000ED2E
	public unsafe Il2CppReferenceArray<GameObject> m_setLocks
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_setLocks);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_setLocks), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700084C RID: 2124
	// (get) Token: 0x06001A15 RID: 6677 RVA: 0x000689D8 File Offset: 0x00066BD8
	// (set) Token: 0x06001A16 RID: 6678 RVA: 0x00010B4D File Offset: 0x0000ED4D
	public unsafe Il2CppReferenceArray<GameObject> m_promoLocks
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_promoLocks);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_promoLocks), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700084D RID: 2125
	// (get) Token: 0x06001A17 RID: 6679 RVA: 0x00068A08 File Offset: 0x00066C08
	// (set) Token: 0x06001A18 RID: 6680 RVA: 0x00010B6C File Offset: 0x0000ED6C
	public unsafe UIC_FriendsList m_profileList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_profileList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_FriendsList>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_profileList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700084E RID: 2126
	// (get) Token: 0x06001A19 RID: 6681 RVA: 0x00068A38 File Offset: 0x00066C38
	// (set) Token: 0x06001A1A RID: 6682 RVA: 0x00010B8B File Offset: 0x0000ED8B
	public unsafe GameObject m_profileListPopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_profileListPopup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_profileListPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700084F RID: 2127
	// (get) Token: 0x06001A1B RID: 6683 RVA: 0x00068A68 File Offset: 0x00066C68
	// (set) Token: 0x06001A1C RID: 6684 RVA: 0x00010BAA File Offset: 0x0000EDAA
	public unsafe TextMeshProUGUI m_timerValueText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_timerValueText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_timerValueText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000850 RID: 2128
	// (get) Token: 0x06001A1D RID: 6685 RVA: 0x00068A98 File Offset: 0x00066C98
	// (set) Token: 0x06001A1E RID: 6686 RVA: 0x00010BC9 File Offset: 0x0000EDC9
	public unsafe float m_minDialogDisplayTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_minDialogDisplayTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_minDialogDisplayTime)) = value;
		}
	}

	// Token: 0x17000851 RID: 2129
	// (get) Token: 0x06001A1F RID: 6687 RVA: 0x00068AC0 File Offset: 0x00066CC0
	// (set) Token: 0x06001A20 RID: 6688 RVA: 0x00010BE4 File Offset: 0x0000EDE4
	public FriendInfo m_defaultDraggable
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_defaultDraggable);
			return new FriendInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendInfo>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_defaultDraggable), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<FriendInfo>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17000852 RID: 2130
	// (get) Token: 0x06001A21 RID: 6689 RVA: 0x00068AF0 File Offset: 0x00066CF0
	// (set) Token: 0x06001A22 RID: 6690 RVA: 0x00010C12 File Offset: 0x0000EE12
	public unsafe uint m_gameTimeIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_gameTimeIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_gameTimeIndex)) = value;
		}
	}

	// Token: 0x17000853 RID: 2131
	// (get) Token: 0x06001A23 RID: 6691 RVA: 0x00068B18 File Offset: 0x00066D18
	// (set) Token: 0x06001A24 RID: 6692 RVA: 0x00010C2D File Offset: 0x0000EE2D
	public unsafe Coroutine m_delayCoroutine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_delayCoroutine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_delayCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000854 RID: 2132
	// (get) Token: 0x06001A25 RID: 6693 RVA: 0x00068B48 File Offset: 0x00066D48
	// (set) Token: 0x06001A26 RID: 6694 RVA: 0x00010C4C File Offset: 0x0000EE4C
	public unsafe int m_createGameReplyData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_createGameReplyData);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_createGameReplyData)) = value;
		}
	}

	// Token: 0x17000855 RID: 2133
	// (get) Token: 0x06001A27 RID: 6695 RVA: 0x00068B70 File Offset: 0x00066D70
	// (set) Token: 0x06001A28 RID: 6696 RVA: 0x00010C67 File Offset: 0x0000EE67
	public unsafe bool m_bMinDialogDisplayTimeReached
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached)) = value;
		}
	}

	// Token: 0x17000856 RID: 2134
	// (get) Token: 0x06001A29 RID: 6697 RVA: 0x00068B98 File Offset: 0x00066D98
	// (set) Token: 0x06001A2A RID: 6698 RVA: 0x00010C82 File Offset: 0x0000EE82
	public unsafe bool m_bProcessCreateGameReply
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_bProcessCreateGameReply);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_bProcessCreateGameReply)) = value;
		}
	}

	// Token: 0x17000857 RID: 2135
	// (get) Token: 0x06001A2B RID: 6699 RVA: 0x00068BC0 File Offset: 0x00066DC0
	// (set) Token: 0x06001A2C RID: 6700 RVA: 0x00010C9D File Offset: 0x0000EE9D
	public unsafe bool m_bHandlePopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_bHandlePopup);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_bHandlePopup)) = value;
		}
	}

	// Token: 0x17000858 RID: 2136
	// (get) Token: 0x06001A2D RID: 6701 RVA: 0x00068BE8 File Offset: 0x00066DE8
	// (set) Token: 0x06001A2E RID: 6702 RVA: 0x00010CB8 File Offset: 0x0000EEB8
	public unsafe bool m_bCreateSuccess
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_bCreateSuccess);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_bCreateSuccess)) = value;
		}
	}

	// Token: 0x17000859 RID: 2137
	// (get) Token: 0x06001A2F RID: 6703 RVA: 0x00068C10 File Offset: 0x00066E10
	// (set) Token: 0x06001A30 RID: 6704 RVA: 0x00010CD3 File Offset: 0x0000EED3
	public unsafe bool m_bIgnoreToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_bIgnoreToggles);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_bIgnoreToggles)) = value;
		}
	}

	// Token: 0x1700085A RID: 2138
	// (get) Token: 0x06001A31 RID: 6705 RVA: 0x00068C38 File Offset: 0x00066E38
	// (set) Token: 0x06001A32 RID: 6706 RVA: 0x00010CEE File Offset: 0x0000EEEE
	public unsafe uint m_setFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_setFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_setFlags)) = value;
		}
	}

	// Token: 0x1700085B RID: 2139
	// (get) Token: 0x06001A33 RID: 6707 RVA: 0x00068C60 File Offset: 0x00066E60
	// (set) Token: 0x06001A34 RID: 6708 RVA: 0x00010D09 File Offset: 0x0000EF09
	public unsafe uint m_promoFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_promoFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_promoFlags)) = value;
		}
	}

	// Token: 0x1700085C RID: 2140
	// (get) Token: 0x06001A35 RID: 6709 RVA: 0x00068C88 File Offset: 0x00066E88
	// (set) Token: 0x06001A36 RID: 6710 RVA: 0x00010D24 File Offset: 0x0000EF24
	public unsafe int m_inviteIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_inviteIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_inviteIndex)) = value;
		}
	}

	// Token: 0x1700085D RID: 2141
	// (get) Token: 0x06001A37 RID: 6711 RVA: 0x00068CB0 File Offset: 0x00066EB0
	// (set) Token: 0x06001A38 RID: 6712 RVA: 0x00010D3F File Offset: 0x0000EF3F
	public unsafe InAppPurchaseWrapper m_InAppPurchase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_InAppPurchase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<InAppPurchaseWrapper>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.NativeFieldInfoPtr_m_InAppPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400119C RID: 4508
	private static readonly IntPtr NativeFieldInfoPtr_m_playerSlots;

	// Token: 0x0400119D RID: 4509
	private static readonly IntPtr NativeFieldInfoPtr_m_setToggles;

	// Token: 0x0400119E RID: 4510
	private static readonly IntPtr NativeFieldInfoPtr_m_promoToggles;

	// Token: 0x0400119F RID: 4511
	private static readonly IntPtr NativeFieldInfoPtr_m_setLocks;

	// Token: 0x040011A0 RID: 4512
	private static readonly IntPtr NativeFieldInfoPtr_m_promoLocks;

	// Token: 0x040011A1 RID: 4513
	private static readonly IntPtr NativeFieldInfoPtr_m_profileList;

	// Token: 0x040011A2 RID: 4514
	private static readonly IntPtr NativeFieldInfoPtr_m_profileListPopup;

	// Token: 0x040011A3 RID: 4515
	private static readonly IntPtr NativeFieldInfoPtr_m_timerValueText;

	// Token: 0x040011A4 RID: 4516
	private static readonly IntPtr NativeFieldInfoPtr_m_minDialogDisplayTime;

	// Token: 0x040011A5 RID: 4517
	private static readonly IntPtr NativeFieldInfoPtr_m_defaultDraggable;

	// Token: 0x040011A6 RID: 4518
	private static readonly IntPtr NativeFieldInfoPtr_m_gameTimeIndex;

	// Token: 0x040011A7 RID: 4519
	private static readonly IntPtr NativeFieldInfoPtr_m_delayCoroutine;

	// Token: 0x040011A8 RID: 4520
	private static readonly IntPtr NativeFieldInfoPtr_m_createGameReplyData;

	// Token: 0x040011A9 RID: 4521
	private static readonly IntPtr NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached;

	// Token: 0x040011AA RID: 4522
	private static readonly IntPtr NativeFieldInfoPtr_m_bProcessCreateGameReply;

	// Token: 0x040011AB RID: 4523
	private static readonly IntPtr NativeFieldInfoPtr_m_bHandlePopup;

	// Token: 0x040011AC RID: 4524
	private static readonly IntPtr NativeFieldInfoPtr_m_bCreateSuccess;

	// Token: 0x040011AD RID: 4525
	private static readonly IntPtr NativeFieldInfoPtr_m_bIgnoreToggles;

	// Token: 0x040011AE RID: 4526
	private static readonly IntPtr NativeFieldInfoPtr_m_setFlags;

	// Token: 0x040011AF RID: 4527
	private static readonly IntPtr NativeFieldInfoPtr_m_promoFlags;

	// Token: 0x040011B0 RID: 4528
	private static readonly IntPtr NativeFieldInfoPtr_m_inviteIndex;

	// Token: 0x040011B1 RID: 4529
	private static readonly IntPtr NativeFieldInfoPtr_m_InAppPurchase;

	// Token: 0x040011B2 RID: 4530
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040011B3 RID: 4531
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterMenu_Public_Void_0;

	// Token: 0x040011B4 RID: 4532
	private static readonly IntPtr NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_Profile_ClickEventType_0;

	// Token: 0x040011B5 RID: 4533
	private static readonly IntPtr NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0;

	// Token: 0x040011B6 RID: 4534
	private static readonly IntPtr NativeMethodInfoPtr_PopulateSlot_Private_Void_FriendInfo_Int32_0;

	// Token: 0x040011B7 RID: 4535
	private static readonly IntPtr NativeMethodInfoPtr_ClearInviteSlot_Public_Void_Int32_0;

	// Token: 0x040011B8 RID: 4536
	private static readonly IntPtr NativeMethodInfoPtr_OnCreateGameButtonPressed_Public_Void_0;

	// Token: 0x040011B9 RID: 4537
	private static readonly IntPtr NativeMethodInfoPtr_HandleCreateCanceled_Public_Void_0;

	// Token: 0x040011BA RID: 4538
	private static readonly IntPtr NativeMethodInfoPtr_HandleBackFromPopup_Private_IEnumerator_0;

	// Token: 0x040011BB RID: 4539
	private static readonly IntPtr NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0;

	// Token: 0x040011BC RID: 4540
	private static readonly IntPtr NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0;

	// Token: 0x040011BD RID: 4541
	private static readonly IntPtr NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0;

	// Token: 0x040011BE RID: 4542
	private static readonly IntPtr NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0;

	// Token: 0x040011BF RID: 4543
	private static readonly IntPtr NativeMethodInfoPtr_ProcessCreateGameReply_Private_Void_Int32_0;

	// Token: 0x040011C0 RID: 4544
	private static readonly IntPtr NativeMethodInfoPtr_DelayCloseAfterSuccess_Private_IEnumerator_0;

	// Token: 0x040011C1 RID: 4545
	private static readonly IntPtr NativeMethodInfoPtr_OnTimerButtonPressed_Public_Void_0;

	// Token: 0x040011C2 RID: 4546
	private static readonly IntPtr NativeMethodInfoPtr_UpdateTimerLabel_Private_Void_0;

	// Token: 0x040011C3 RID: 4547
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerPressed_Public_Void_Int32_0;

	// Token: 0x040011C4 RID: 4548
	private static readonly IntPtr NativeMethodInfoPtr_OnGameTypeChanged_Public_Void_0;

	// Token: 0x040011C5 RID: 4549
	private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayerStates_Public_Void_0;

	// Token: 0x040011C6 RID: 4550
	private static readonly IntPtr NativeMethodInfoPtr_ShowInvitePopup_Public_Void_0;

	// Token: 0x040011C7 RID: 4551
	private static readonly IntPtr NativeMethodInfoPtr_HideInvitePopup_Public_Void_0;

	// Token: 0x040011C8 RID: 4552
	private static readonly IntPtr NativeMethodInfoPtr_ShowInvitePopup_OneSlot_Public_Void_Int32_0;

	// Token: 0x040011C9 RID: 4553
	private static readonly IntPtr NativeMethodInfoPtr_HandleInvites_Public_Void_0;

	// Token: 0x040011CA RID: 4554
	private static readonly IntPtr NativeMethodInfoPtr_CreateGame_Public_Void_0;

	// Token: 0x040011CB RID: 4555
	private static readonly IntPtr NativeMethodInfoPtr_RetreiveSettings_Private_Void_0;

	// Token: 0x040011CC RID: 4556
	private static readonly IntPtr NativeMethodInfoPtr_StoreSettings_Private_Void_0;

	// Token: 0x040011CD RID: 4557
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001F9 RID: 505
	[Serializable]
	public sealed class PlayerSlot : ValueType
	{
		// Token: 0x06002851 RID: 10321 RVA: 0x0009212C File Offset: 0x0009032C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSlot()
		{
			Il2CppClassPointerStore<UI_OnlineCreateGame.PlayerSlot>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "PlayerSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_OnlineCreateGame.PlayerSlot>.NativeClassPtr);
			UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame.PlayerSlot>.NativeClassPtr, "root");
			UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame.PlayerSlot>.NativeClassPtr, "avatar");
			UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_avatarObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame.PlayerSlot>.NativeClassPtr, "avatarObj");
			UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame.PlayerSlot>.NativeClassPtr, "name");
			UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_nameObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame.PlayerSlot>.NativeClassPtr, "nameObj");
			UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_playerTypeObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame.PlayerSlot>.NativeClassPtr, "playerTypeObj");
			UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_m_ClearInviteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame.PlayerSlot>.NativeClassPtr, "m_ClearInviteButton");
			UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_playerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame.PlayerSlot>.NativeClassPtr, "playerID");
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x00018E09 File Offset: 0x00017009
		public PlayerSlot(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x00018E12 File Offset: 0x00017012
		public PlayerSlot()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_OnlineCreateGame.PlayerSlot>.NativeClassPtr))
		{
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06002854 RID: 10324 RVA: 0x000921F8 File Offset: 0x000903F8
		// (set) Token: 0x06002855 RID: 10325 RVA: 0x00018E24 File Offset: 0x00017024
		public unsafe GameObject root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06002856 RID: 10326 RVA: 0x00092228 File Offset: 0x00090428
		// (set) Token: 0x06002857 RID: 10327 RVA: 0x00018E43 File Offset: 0x00017043
		public unsafe Avatar_UI avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06002858 RID: 10328 RVA: 0x00092258 File Offset: 0x00090458
		// (set) Token: 0x06002859 RID: 10329 RVA: 0x00018E62 File Offset: 0x00017062
		public unsafe GameObject avatarObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_avatarObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_avatarObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x0600285A RID: 10330 RVA: 0x00092288 File Offset: 0x00090488
		// (set) Token: 0x0600285B RID: 10331 RVA: 0x00018E81 File Offset: 0x00017081
		public unsafe TextMeshProUGUI name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x0600285C RID: 10332 RVA: 0x000922B8 File Offset: 0x000904B8
		// (set) Token: 0x0600285D RID: 10333 RVA: 0x00018EA0 File Offset: 0x000170A0
		public unsafe GameObject nameObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_nameObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_nameObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x0600285E RID: 10334 RVA: 0x000922E8 File Offset: 0x000904E8
		// (set) Token: 0x0600285F RID: 10335 RVA: 0x00018EBF File Offset: 0x000170BF
		public unsafe Il2CppReferenceArray<GameObject> playerTypeObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_playerTypeObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_playerTypeObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06002860 RID: 10336 RVA: 0x00092318 File Offset: 0x00090518
		// (set) Token: 0x06002861 RID: 10337 RVA: 0x00018EDE File Offset: 0x000170DE
		public unsafe GameObject m_ClearInviteButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_m_ClearInviteButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_m_ClearInviteButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x06002862 RID: 10338 RVA: 0x00092348 File Offset: 0x00090548
		// (set) Token: 0x06002863 RID: 10339 RVA: 0x00018EFD File Offset: 0x000170FD
		public unsafe uint playerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_playerID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame.PlayerSlot.NativeFieldInfoPtr_playerID)) = value;
			}
		}

		// Token: 0x04001BBE RID: 7102
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x04001BBF RID: 7103
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04001BC0 RID: 7104
		private static readonly IntPtr NativeFieldInfoPtr_avatarObj;

		// Token: 0x04001BC1 RID: 7105
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001BC2 RID: 7106
		private static readonly IntPtr NativeFieldInfoPtr_nameObj;

		// Token: 0x04001BC3 RID: 7107
		private static readonly IntPtr NativeFieldInfoPtr_playerTypeObj;

		// Token: 0x04001BC4 RID: 7108
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearInviteButton;

		// Token: 0x04001BC5 RID: 7109
		private static readonly IntPtr NativeFieldInfoPtr_playerID;
	}

	// Token: 0x020001FA RID: 506
	[ObfuscatedName("UI_OnlineCreateGame+<HandleBackFromPopup>d__31")]
	public sealed class _HandleBackFromPopup_d__31 : global::Il2CppSystem.Object
	{
		// Token: 0x06002864 RID: 10340 RVA: 0x00092370 File Offset: 0x00090570
		// Note: this type is marked as 'beforefieldinit'.
		static _HandleBackFromPopup_d__31()
		{
			Il2CppClassPointerStore<UI_OnlineCreateGame._HandleBackFromPopup_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "<HandleBackFromPopup>d__31");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_OnlineCreateGame._HandleBackFromPopup_d__31>.NativeClassPtr);
			UI_OnlineCreateGame._HandleBackFromPopup_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame._HandleBackFromPopup_d__31>.NativeClassPtr, "<>1__state");
			UI_OnlineCreateGame._HandleBackFromPopup_d__31.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame._HandleBackFromPopup_d__31>.NativeClassPtr, "<>2__current");
			UI_OnlineCreateGame._HandleBackFromPopup_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame._HandleBackFromPopup_d__31>.NativeClassPtr, 100666468);
			UI_OnlineCreateGame._HandleBackFromPopup_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame._HandleBackFromPopup_d__31>.NativeClassPtr, 100666469);
			UI_OnlineCreateGame._HandleBackFromPopup_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame._HandleBackFromPopup_d__31>.NativeClassPtr, 100666470);
			UI_OnlineCreateGame._HandleBackFromPopup_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame._HandleBackFromPopup_d__31>.NativeClassPtr, 100666471);
			UI_OnlineCreateGame._HandleBackFromPopup_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame._HandleBackFromPopup_d__31>.NativeClassPtr, 100666472);
			UI_OnlineCreateGame._HandleBackFromPopup_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame._HandleBackFromPopup_d__31>.NativeClassPtr, 100666473);
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x0009243C File Offset: 0x0009063C
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _HandleBackFromPopup_d__31(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_OnlineCreateGame._HandleBackFromPopup_d__31>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame._HandleBackFromPopup_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x00092484 File Offset: 0x00090684
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame._HandleBackFromPopup_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x000924B8 File Offset: 0x000906B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251110, XrefRangeEnd = 251118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame._HandleBackFromPopup_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06002868 RID: 10344 RVA: 0x000924F4 File Offset: 0x000906F4
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame._HandleBackFromPopup_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x00092534 File Offset: 0x00090734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251118, XrefRangeEnd = 251123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame._HandleBackFromPopup_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x0600286A RID: 10346 RVA: 0x00092568 File Offset: 0x00090768
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame._HandleBackFromPopup_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x00018F18 File Offset: 0x00017118
		public _HandleBackFromPopup_d__31(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x0600286C RID: 10348 RVA: 0x000925A8 File Offset: 0x000907A8
		// (set) Token: 0x0600286D RID: 10349 RVA: 0x00018F21 File Offset: 0x00017121
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._HandleBackFromPopup_d__31.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._HandleBackFromPopup_d__31.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x0600286E RID: 10350 RVA: 0x000925D0 File Offset: 0x000907D0
		// (set) Token: 0x0600286F RID: 10351 RVA: 0x00018F3C File Offset: 0x0001713C
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._HandleBackFromPopup_d__31.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._HandleBackFromPopup_d__31.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BC6 RID: 7110
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001BC7 RID: 7111
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001BC8 RID: 7112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001BC9 RID: 7113
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001BCA RID: 7114
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001BCB RID: 7115
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001BCC RID: 7116
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001BCD RID: 7117
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020001FB RID: 507
	[ObfuscatedName("UI_OnlineCreateGame+<ProcessDelayTime>d__32")]
	public sealed class _ProcessDelayTime_d__32 : global::Il2CppSystem.Object
	{
		// Token: 0x06002870 RID: 10352 RVA: 0x00092600 File Offset: 0x00090800
		// Note: this type is marked as 'beforefieldinit'.
		static _ProcessDelayTime_d__32()
		{
			Il2CppClassPointerStore<UI_OnlineCreateGame._ProcessDelayTime_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "<ProcessDelayTime>d__32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_OnlineCreateGame._ProcessDelayTime_d__32>.NativeClassPtr);
			UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame._ProcessDelayTime_d__32>.NativeClassPtr, "<>1__state");
			UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame._ProcessDelayTime_d__32>.NativeClassPtr, "<>2__current");
			UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame._ProcessDelayTime_d__32>.NativeClassPtr, "<>4__this");
			UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeFieldInfoPtr_totalDelayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame._ProcessDelayTime_d__32>.NativeClassPtr, "totalDelayTime");
			UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeFieldInfoPtr__accumulatedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame._ProcessDelayTime_d__32>.NativeClassPtr, "<accumulatedTime>5__2");
			UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeFieldInfoPtr__previousTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame._ProcessDelayTime_d__32>.NativeClassPtr, "<previousTime>5__3");
			UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame._ProcessDelayTime_d__32>.NativeClassPtr, 100666474);
			UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame._ProcessDelayTime_d__32>.NativeClassPtr, 100666475);
			UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame._ProcessDelayTime_d__32>.NativeClassPtr, 100666476);
			UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame._ProcessDelayTime_d__32>.NativeClassPtr, 100666477);
			UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame._ProcessDelayTime_d__32>.NativeClassPtr, 100666478);
			UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame._ProcessDelayTime_d__32>.NativeClassPtr, 100666479);
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x0009271C File Offset: 0x0009091C
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ProcessDelayTime_d__32(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_OnlineCreateGame._ProcessDelayTime_d__32>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x00092764 File Offset: 0x00090964
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x00092798 File Offset: 0x00090998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251123, XrefRangeEnd = 251131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06002874 RID: 10356 RVA: 0x000927D4 File Offset: 0x000909D4
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x00092814 File Offset: 0x00090A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251131, XrefRangeEnd = 251136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06002876 RID: 10358 RVA: 0x00092848 File Offset: 0x00090A48
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x00018F5B File Offset: 0x0001715B
		public _ProcessDelayTime_d__32(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06002878 RID: 10360 RVA: 0x00092888 File Offset: 0x00090A88
		// (set) Token: 0x06002879 RID: 10361 RVA: 0x00018F64 File Offset: 0x00017164
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x0600287A RID: 10362 RVA: 0x000928B0 File Offset: 0x00090AB0
		// (set) Token: 0x0600287B RID: 10363 RVA: 0x00018F7F File Offset: 0x0001717F
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x0600287C RID: 10364 RVA: 0x000928E0 File Offset: 0x00090AE0
		// (set) Token: 0x0600287D RID: 10365 RVA: 0x00018F9E File Offset: 0x0001719E
		public unsafe UI_OnlineCreateGame __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_OnlineCreateGame>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x0600287E RID: 10366 RVA: 0x00092910 File Offset: 0x00090B10
		// (set) Token: 0x0600287F RID: 10367 RVA: 0x00018FBD File Offset: 0x000171BD
		public unsafe float totalDelayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeFieldInfoPtr_totalDelayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeFieldInfoPtr_totalDelayTime)) = value;
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06002880 RID: 10368 RVA: 0x00092938 File Offset: 0x00090B38
		// (set) Token: 0x06002881 RID: 10369 RVA: 0x00018FD8 File Offset: 0x000171D8
		public unsafe float _accumulatedTime_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeFieldInfoPtr__accumulatedTime_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeFieldInfoPtr__accumulatedTime_5__2)) = value;
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06002882 RID: 10370 RVA: 0x00092960 File Offset: 0x00090B60
		// (set) Token: 0x06002883 RID: 10371 RVA: 0x00018FF3 File Offset: 0x000171F3
		public unsafe float _previousTime_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeFieldInfoPtr__previousTime_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._ProcessDelayTime_d__32.NativeFieldInfoPtr__previousTime_5__3)) = value;
			}
		}

		// Token: 0x04001BCE RID: 7118
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001BCF RID: 7119
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001BD0 RID: 7120
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001BD1 RID: 7121
		private static readonly IntPtr NativeFieldInfoPtr_totalDelayTime;

		// Token: 0x04001BD2 RID: 7122
		private static readonly IntPtr NativeFieldInfoPtr__accumulatedTime_5__2;

		// Token: 0x04001BD3 RID: 7123
		private static readonly IntPtr NativeFieldInfoPtr__previousTime_5__3;

		// Token: 0x04001BD4 RID: 7124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001BD5 RID: 7125
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001BD6 RID: 7126
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001BD7 RID: 7127
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001BD8 RID: 7128
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001BD9 RID: 7129
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020001FC RID: 508
	[ObfuscatedName("UI_OnlineCreateGame+<DelayCloseAfterSuccess>d__37")]
	public sealed class _DelayCloseAfterSuccess_d__37 : global::Il2CppSystem.Object
	{
		// Token: 0x06002884 RID: 10372 RVA: 0x00092988 File Offset: 0x00090B88
		// Note: this type is marked as 'beforefieldinit'.
		static _DelayCloseAfterSuccess_d__37()
		{
			Il2CppClassPointerStore<UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_OnlineCreateGame>.NativeClassPtr, "<DelayCloseAfterSuccess>d__37");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37>.NativeClassPtr);
			UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37>.NativeClassPtr, "<>1__state");
			UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37>.NativeClassPtr, "<>2__current");
			UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37>.NativeClassPtr, 100666480);
			UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37>.NativeClassPtr, 100666481);
			UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37>.NativeClassPtr, 100666482);
			UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37>.NativeClassPtr, 100666483);
			UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37>.NativeClassPtr, 100666484);
			UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37>.NativeClassPtr, 100666485);
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x00092A54 File Offset: 0x00090C54
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _DelayCloseAfterSuccess_d__37(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x00092A9C File Offset: 0x00090C9C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x00092AD0 File Offset: 0x00090CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251136, XrefRangeEnd = 251143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06002888 RID: 10376 RVA: 0x00092B0C File Offset: 0x00090D0C
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x00092B4C File Offset: 0x00090D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251143, XrefRangeEnd = 251148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x0600288A RID: 10378 RVA: 0x00092B80 File Offset: 0x00090D80
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x0001900E File Offset: 0x0001720E
		public _DelayCloseAfterSuccess_d__37(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x0600288C RID: 10380 RVA: 0x00092BC0 File Offset: 0x00090DC0
		// (set) Token: 0x0600288D RID: 10381 RVA: 0x00019017 File Offset: 0x00017217
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x0600288E RID: 10382 RVA: 0x00092BE8 File Offset: 0x00090DE8
		// (set) Token: 0x0600288F RID: 10383 RVA: 0x00019032 File Offset: 0x00017232
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineCreateGame._DelayCloseAfterSuccess_d__37.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BDA RID: 7130
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001BDB RID: 7131
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001BDC RID: 7132
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001BDD RID: 7133
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001BDE RID: 7134
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001BDF RID: 7135
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001BE0 RID: 7136
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001BE1 RID: 7137
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

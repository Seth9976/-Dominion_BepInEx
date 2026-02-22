using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000D9 RID: 217
public class UI_OnlineJoinViewGame : UI_NetworkBase
{
	// Token: 0x06001A6A RID: 6762 RVA: 0x00069634 File Offset: 0x00067834
	// Note: this type is marked as 'beforefieldinit'.
	static UI_OnlineJoinViewGame()
	{
		Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_OnlineJoinViewGame");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr);
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_playerSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_playerSlots");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_setToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_setToggles");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_promoToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_promoToggles");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_setLocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_setLocks");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_promoLocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_promoLocks");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_OnlineStatusImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_OnlineStatusImages");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_timerValueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_timerValueText");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_startGameObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_startGameObj");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_startGameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_startGameText");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_minDialogDisplayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_minDialogDisplayTime");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_delayCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_delayCoroutine");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_createGameReplyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_createGameReplyData");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_bMinDialogDisplayTimeReached");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bProcessCreateGameReply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_bProcessCreateGameReply");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_gameData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_gameData");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bHandlePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_bHandlePopup");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bCreateSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_bCreateSuccess");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bIsGameReadyToStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_bIsGameReadyToStart");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bIsPlayerOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_bIsPlayerOwner");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bIsPlayerInvited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_bIsPlayerInvited");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bIsPlayerInGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_bIsPlayerInGame");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_factionSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_factionSelected");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_requestOnlineStatusArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_requestOnlineStatusArray");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_hUserDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_hUserDataBuffer");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_savedAnalyticsString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_savedAnalyticsString");
		UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_InAppPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "m_InAppPurchase");
		UI_OnlineJoinViewGame.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, 100665391);
		UI_OnlineJoinViewGame.NativeMethodInfoPtr_SetGameData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, 100665392);
		UI_OnlineJoinViewGame.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, 100665393);
		UI_OnlineJoinViewGame.NativeMethodInfoPtr_HandleBackFromPopup_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, 100665394);
		UI_OnlineJoinViewGame.NativeMethodInfoPtr_PopulateSlot_Private_Void_FriendInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, 100665395);
		UI_OnlineJoinViewGame.NativeMethodInfoPtr_OnPlayerPressed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, 100665396);
		UI_OnlineJoinViewGame.NativeMethodInfoPtr_SetGameData_Public_Void_ShortSaveStruct_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, 100665397);
		UI_OnlineJoinViewGame.NativeMethodInfoPtr_OnConfirmPopup_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, 100665398);
		UI_OnlineJoinViewGame.NativeMethodInfoPtr_OnJoinGameButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, 100665399);
		UI_OnlineJoinViewGame.NativeMethodInfoPtr_HandleCreateCanceled_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, 100665400);
		UI_OnlineJoinViewGame.NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, 100665401);
		UI_OnlineJoinViewGame.NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, 100665402);
		UI_OnlineJoinViewGame.NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, 100665403);
		UI_OnlineJoinViewGame.NativeMethodInfoPtr_UpdateTimerLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, 100665404);
		UI_OnlineJoinViewGame.NativeMethodInfoPtr_DelayCloseAfterSuccess_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, 100665405);
		UI_OnlineJoinViewGame.NativeMethodInfoPtr_ProcessJoinGameReply_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, 100665406);
		UI_OnlineJoinViewGame.NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, 100665407);
		UI_OnlineJoinViewGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, 100665408);
	}

	// Token: 0x06001A6B RID: 6763 RVA: 0x000699D4 File Offset: 0x00067BD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252023, XrefRangeEnd = 252029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnterMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A6C RID: 6764 RVA: 0x00069A08 File Offset: 0x00067C08
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 252199, RefRangeEnd = 252201, XrefRangeStart = 252029, XrefRangeEnd = 252199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGameData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame.NativeMethodInfoPtr_SetGameData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A6D RID: 6765 RVA: 0x00069A3C File Offset: 0x00067C3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252201, XrefRangeEnd = 252203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExitMenu(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001A6E RID: 6766 RVA: 0x00069A7C File Offset: 0x00067C7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252203, XrefRangeEnd = 252207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator HandleBackFromPopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame.NativeMethodInfoPtr_HandleBackFromPopup_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06001A6F RID: 6767 RVA: 0x00069ABC File Offset: 0x00067CBC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 252208, RefRangeEnd = 252209, XrefRangeStart = 252207, XrefRangeEnd = 252208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame.NativeMethodInfoPtr_PopulateSlot_Private_Void_FriendInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A70 RID: 6768 RVA: 0x00069B14 File Offset: 0x00067D14
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerPressed(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame.NativeMethodInfoPtr_OnPlayerPressed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001A71 RID: 6769 RVA: 0x00069B54 File Offset: 0x00067D54
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 252221, RefRangeEnd = 252225, XrefRangeStart = 252209, XrefRangeEnd = 252221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGameData(ShortSaveStruct data, bool bIsPlayerInvited, bool bIsGameReadyToStart)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIsPlayerInvited;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIsGameReadyToStart;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame.NativeMethodInfoPtr_SetGameData_Public_Void_ShortSaveStruct_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A72 RID: 6770 RVA: 0x00069BB8 File Offset: 0x00067DB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252225, XrefRangeEnd = 252226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConfirmPopup(bool bConfirm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bConfirm;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame.NativeMethodInfoPtr_OnConfirmPopup_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001A73 RID: 6771 RVA: 0x00069BF8 File Offset: 0x00067DF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252226, XrefRangeEnd = 252246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnJoinGameButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame.NativeMethodInfoPtr_OnJoinGameButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A74 RID: 6772 RVA: 0x00069C2C File Offset: 0x00067E2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252246, XrefRangeEnd = 252247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleCreateCanceled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame.NativeMethodInfoPtr_HandleCreateCanceled_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A75 RID: 6773 RVA: 0x00069C60 File Offset: 0x00067E60
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NetworkStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_OnlineJoinViewGame.NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A76 RID: 6774 RVA: 0x00069C9C File Offset: 0x00067E9C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NetworkOnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_OnlineJoinViewGame.NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A77 RID: 6775 RVA: 0x00069CD8 File Offset: 0x00067ED8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252247, XrefRangeEnd = 252273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_OnlineJoinViewGame.NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A78 RID: 6776 RVA: 0x00069D30 File Offset: 0x00067F30
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252273, XrefRangeEnd = 252278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTimerLabel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame.NativeMethodInfoPtr_UpdateTimerLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A79 RID: 6777 RVA: 0x00069D64 File Offset: 0x00067F64
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252278, XrefRangeEnd = 252282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator DelayCloseAfterSuccess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame.NativeMethodInfoPtr_DelayCloseAfterSuccess_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06001A7A RID: 6778 RVA: 0x00069DA4 File Offset: 0x00067FA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252282, XrefRangeEnd = 252318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessJoinGameReply(int eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame.NativeMethodInfoPtr_ProcessJoinGameReply_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001A7B RID: 6779 RVA: 0x00069DE4 File Offset: 0x00067FE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252318, XrefRangeEnd = 252322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ProcessDelayTime(float totalDelayTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref totalDelayTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame.NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x06001A7C RID: 6780 RVA: 0x00069E30 File Offset: 0x00068030
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252322, XrefRangeEnd = 252326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_OnlineJoinViewGame()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A7D RID: 6781 RVA: 0x00010F24 File Offset: 0x0000F124
	public UI_OnlineJoinViewGame(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700086D RID: 2157
	// (get) Token: 0x06001A7E RID: 6782 RVA: 0x00069E6C File Offset: 0x0006806C
	// (set) Token: 0x06001A7F RID: 6783 RVA: 0x00010F2D File Offset: 0x0000F12D
	public unsafe Il2CppReferenceArray<UI_OnlineJoinViewGame.PlayerSlot> m_playerSlots
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_playerSlots);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UI_OnlineJoinViewGame.PlayerSlot>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_playerSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700086E RID: 2158
	// (get) Token: 0x06001A80 RID: 6784 RVA: 0x00069E9C File Offset: 0x0006809C
	// (set) Token: 0x06001A81 RID: 6785 RVA: 0x00010F4C File Offset: 0x0000F14C
	public unsafe Il2CppReferenceArray<Toggle> m_setToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_setToggles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Toggle>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_setToggles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700086F RID: 2159
	// (get) Token: 0x06001A82 RID: 6786 RVA: 0x00069ECC File Offset: 0x000680CC
	// (set) Token: 0x06001A83 RID: 6787 RVA: 0x00010F6B File Offset: 0x0000F16B
	public unsafe Il2CppReferenceArray<Toggle> m_promoToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_promoToggles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Toggle>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_promoToggles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000870 RID: 2160
	// (get) Token: 0x06001A84 RID: 6788 RVA: 0x00069EFC File Offset: 0x000680FC
	// (set) Token: 0x06001A85 RID: 6789 RVA: 0x00010F8A File Offset: 0x0000F18A
	public unsafe Il2CppReferenceArray<GameObject> m_setLocks
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_setLocks);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_setLocks), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000871 RID: 2161
	// (get) Token: 0x06001A86 RID: 6790 RVA: 0x00069F2C File Offset: 0x0006812C
	// (set) Token: 0x06001A87 RID: 6791 RVA: 0x00010FA9 File Offset: 0x0000F1A9
	public unsafe Il2CppReferenceArray<GameObject> m_promoLocks
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_promoLocks);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_promoLocks), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000872 RID: 2162
	// (get) Token: 0x06001A88 RID: 6792 RVA: 0x00069F5C File Offset: 0x0006815C
	// (set) Token: 0x06001A89 RID: 6793 RVA: 0x00010FC8 File Offset: 0x0000F1C8
	public unsafe Il2CppReferenceArray<Sprite> m_OnlineStatusImages
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_OnlineStatusImages);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_OnlineStatusImages), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000873 RID: 2163
	// (get) Token: 0x06001A8A RID: 6794 RVA: 0x00069F8C File Offset: 0x0006818C
	// (set) Token: 0x06001A8B RID: 6795 RVA: 0x00010FE7 File Offset: 0x0000F1E7
	public unsafe TextMeshProUGUI m_timerValueText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_timerValueText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_timerValueText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000874 RID: 2164
	// (get) Token: 0x06001A8C RID: 6796 RVA: 0x00069FBC File Offset: 0x000681BC
	// (set) Token: 0x06001A8D RID: 6797 RVA: 0x00011006 File Offset: 0x0000F206
	public unsafe GameObject m_startGameObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_startGameObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_startGameObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000875 RID: 2165
	// (get) Token: 0x06001A8E RID: 6798 RVA: 0x00069FEC File Offset: 0x000681EC
	// (set) Token: 0x06001A8F RID: 6799 RVA: 0x00011025 File Offset: 0x0000F225
	public unsafe TextMeshProUGUI m_startGameText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_startGameText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_startGameText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000876 RID: 2166
	// (get) Token: 0x06001A90 RID: 6800 RVA: 0x0006A01C File Offset: 0x0006821C
	// (set) Token: 0x06001A91 RID: 6801 RVA: 0x00011044 File Offset: 0x0000F244
	public unsafe float m_minDialogDisplayTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_minDialogDisplayTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_minDialogDisplayTime)) = value;
		}
	}

	// Token: 0x17000877 RID: 2167
	// (get) Token: 0x06001A92 RID: 6802 RVA: 0x0006A044 File Offset: 0x00068244
	// (set) Token: 0x06001A93 RID: 6803 RVA: 0x0001105F File Offset: 0x0000F25F
	public unsafe Coroutine m_delayCoroutine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_delayCoroutine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_delayCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000878 RID: 2168
	// (get) Token: 0x06001A94 RID: 6804 RVA: 0x0006A074 File Offset: 0x00068274
	// (set) Token: 0x06001A95 RID: 6805 RVA: 0x0001107E File Offset: 0x0000F27E
	public unsafe int m_createGameReplyData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_createGameReplyData);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_createGameReplyData)) = value;
		}
	}

	// Token: 0x17000879 RID: 2169
	// (get) Token: 0x06001A96 RID: 6806 RVA: 0x0006A09C File Offset: 0x0006829C
	// (set) Token: 0x06001A97 RID: 6807 RVA: 0x00011099 File Offset: 0x0000F299
	public unsafe bool m_bMinDialogDisplayTimeReached
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached)) = value;
		}
	}

	// Token: 0x1700087A RID: 2170
	// (get) Token: 0x06001A98 RID: 6808 RVA: 0x0006A0C4 File Offset: 0x000682C4
	// (set) Token: 0x06001A99 RID: 6809 RVA: 0x000110B4 File Offset: 0x0000F2B4
	public unsafe bool m_bProcessCreateGameReply
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bProcessCreateGameReply);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bProcessCreateGameReply)) = value;
		}
	}

	// Token: 0x1700087B RID: 2171
	// (get) Token: 0x06001A9A RID: 6810 RVA: 0x0006A0EC File Offset: 0x000682EC
	// (set) Token: 0x06001A9B RID: 6811 RVA: 0x000110CF File Offset: 0x0000F2CF
	public ShortSaveStruct m_gameData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_gameData);
			return new ShortSaveStruct(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_gameData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ShortSaveStruct>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x1700087C RID: 2172
	// (get) Token: 0x06001A9C RID: 6812 RVA: 0x0006A11C File Offset: 0x0006831C
	// (set) Token: 0x06001A9D RID: 6813 RVA: 0x000110FD File Offset: 0x0000F2FD
	public unsafe bool m_bHandlePopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bHandlePopup);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bHandlePopup)) = value;
		}
	}

	// Token: 0x1700087D RID: 2173
	// (get) Token: 0x06001A9E RID: 6814 RVA: 0x0006A144 File Offset: 0x00068344
	// (set) Token: 0x06001A9F RID: 6815 RVA: 0x00011118 File Offset: 0x0000F318
	public unsafe bool m_bCreateSuccess
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bCreateSuccess);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bCreateSuccess)) = value;
		}
	}

	// Token: 0x1700087E RID: 2174
	// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x0006A16C File Offset: 0x0006836C
	// (set) Token: 0x06001AA1 RID: 6817 RVA: 0x00011133 File Offset: 0x0000F333
	public unsafe bool m_bIsGameReadyToStart
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bIsGameReadyToStart);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bIsGameReadyToStart)) = value;
		}
	}

	// Token: 0x1700087F RID: 2175
	// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x0006A194 File Offset: 0x00068394
	// (set) Token: 0x06001AA3 RID: 6819 RVA: 0x0001114E File Offset: 0x0000F34E
	public unsafe bool m_bIsPlayerOwner
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bIsPlayerOwner);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bIsPlayerOwner)) = value;
		}
	}

	// Token: 0x17000880 RID: 2176
	// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x0006A1BC File Offset: 0x000683BC
	// (set) Token: 0x06001AA5 RID: 6821 RVA: 0x00011169 File Offset: 0x0000F369
	public unsafe bool m_bIsPlayerInvited
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bIsPlayerInvited);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bIsPlayerInvited)) = value;
		}
	}

	// Token: 0x17000881 RID: 2177
	// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x0006A1E4 File Offset: 0x000683E4
	// (set) Token: 0x06001AA7 RID: 6823 RVA: 0x00011184 File Offset: 0x0000F384
	public unsafe bool m_bIsPlayerInGame
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bIsPlayerInGame);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_bIsPlayerInGame)) = value;
		}
	}

	// Token: 0x17000882 RID: 2178
	// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x0006A20C File Offset: 0x0006840C
	// (set) Token: 0x06001AA9 RID: 6825 RVA: 0x0001119F File Offset: 0x0000F39F
	public unsafe uint m_factionSelected
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_factionSelected);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_factionSelected)) = value;
		}
	}

	// Token: 0x17000883 RID: 2179
	// (get) Token: 0x06001AAA RID: 6826 RVA: 0x0006A234 File Offset: 0x00068434
	// (set) Token: 0x06001AAB RID: 6827 RVA: 0x000111BA File Offset: 0x0000F3BA
	public unsafe Il2CppStructArray<uint> m_requestOnlineStatusArray
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_requestOnlineStatusArray);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_requestOnlineStatusArray), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000884 RID: 2180
	// (get) Token: 0x06001AAC RID: 6828 RVA: 0x0006A264 File Offset: 0x00068464
	// (set) Token: 0x06001AAD RID: 6829 RVA: 0x000111D9 File Offset: 0x0000F3D9
	public unsafe GCHandle m_hUserDataBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_hUserDataBuffer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_hUserDataBuffer)) = value;
		}
	}

	// Token: 0x17000885 RID: 2181
	// (get) Token: 0x06001AAE RID: 6830 RVA: 0x0006A28C File Offset: 0x0006848C
	// (set) Token: 0x06001AAF RID: 6831 RVA: 0x000111F4 File Offset: 0x0000F3F4
	public unsafe string m_savedAnalyticsString
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_savedAnalyticsString);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_savedAnalyticsString), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000886 RID: 2182
	// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x0006A2B4 File Offset: 0x000684B4
	// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x00011213 File Offset: 0x0000F413
	public unsafe InAppPurchaseWrapper m_InAppPurchase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_InAppPurchase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<InAppPurchaseWrapper>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.NativeFieldInfoPtr_m_InAppPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040011EE RID: 4590
	private static readonly IntPtr NativeFieldInfoPtr_m_playerSlots;

	// Token: 0x040011EF RID: 4591
	private static readonly IntPtr NativeFieldInfoPtr_m_setToggles;

	// Token: 0x040011F0 RID: 4592
	private static readonly IntPtr NativeFieldInfoPtr_m_promoToggles;

	// Token: 0x040011F1 RID: 4593
	private static readonly IntPtr NativeFieldInfoPtr_m_setLocks;

	// Token: 0x040011F2 RID: 4594
	private static readonly IntPtr NativeFieldInfoPtr_m_promoLocks;

	// Token: 0x040011F3 RID: 4595
	private static readonly IntPtr NativeFieldInfoPtr_m_OnlineStatusImages;

	// Token: 0x040011F4 RID: 4596
	private static readonly IntPtr NativeFieldInfoPtr_m_timerValueText;

	// Token: 0x040011F5 RID: 4597
	private static readonly IntPtr NativeFieldInfoPtr_m_startGameObj;

	// Token: 0x040011F6 RID: 4598
	private static readonly IntPtr NativeFieldInfoPtr_m_startGameText;

	// Token: 0x040011F7 RID: 4599
	private static readonly IntPtr NativeFieldInfoPtr_m_minDialogDisplayTime;

	// Token: 0x040011F8 RID: 4600
	private static readonly IntPtr NativeFieldInfoPtr_m_delayCoroutine;

	// Token: 0x040011F9 RID: 4601
	private static readonly IntPtr NativeFieldInfoPtr_m_createGameReplyData;

	// Token: 0x040011FA RID: 4602
	private static readonly IntPtr NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached;

	// Token: 0x040011FB RID: 4603
	private static readonly IntPtr NativeFieldInfoPtr_m_bProcessCreateGameReply;

	// Token: 0x040011FC RID: 4604
	private static readonly IntPtr NativeFieldInfoPtr_m_gameData;

	// Token: 0x040011FD RID: 4605
	private static readonly IntPtr NativeFieldInfoPtr_m_bHandlePopup;

	// Token: 0x040011FE RID: 4606
	private static readonly IntPtr NativeFieldInfoPtr_m_bCreateSuccess;

	// Token: 0x040011FF RID: 4607
	private static readonly IntPtr NativeFieldInfoPtr_m_bIsGameReadyToStart;

	// Token: 0x04001200 RID: 4608
	private static readonly IntPtr NativeFieldInfoPtr_m_bIsPlayerOwner;

	// Token: 0x04001201 RID: 4609
	private static readonly IntPtr NativeFieldInfoPtr_m_bIsPlayerInvited;

	// Token: 0x04001202 RID: 4610
	private static readonly IntPtr NativeFieldInfoPtr_m_bIsPlayerInGame;

	// Token: 0x04001203 RID: 4611
	private static readonly IntPtr NativeFieldInfoPtr_m_factionSelected;

	// Token: 0x04001204 RID: 4612
	private static readonly IntPtr NativeFieldInfoPtr_m_requestOnlineStatusArray;

	// Token: 0x04001205 RID: 4613
	private static readonly IntPtr NativeFieldInfoPtr_m_hUserDataBuffer;

	// Token: 0x04001206 RID: 4614
	private static readonly IntPtr NativeFieldInfoPtr_m_savedAnalyticsString;

	// Token: 0x04001207 RID: 4615
	private static readonly IntPtr NativeFieldInfoPtr_m_InAppPurchase;

	// Token: 0x04001208 RID: 4616
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterMenu_Public_Void_0;

	// Token: 0x04001209 RID: 4617
	private static readonly IntPtr NativeMethodInfoPtr_SetGameData_Private_Void_0;

	// Token: 0x0400120A RID: 4618
	private static readonly IntPtr NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0;

	// Token: 0x0400120B RID: 4619
	private static readonly IntPtr NativeMethodInfoPtr_HandleBackFromPopup_Private_IEnumerator_0;

	// Token: 0x0400120C RID: 4620
	private static readonly IntPtr NativeMethodInfoPtr_PopulateSlot_Private_Void_FriendInfo_Int32_0;

	// Token: 0x0400120D RID: 4621
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerPressed_Public_Void_Int32_0;

	// Token: 0x0400120E RID: 4622
	private static readonly IntPtr NativeMethodInfoPtr_SetGameData_Public_Void_ShortSaveStruct_Boolean_Boolean_0;

	// Token: 0x0400120F RID: 4623
	private static readonly IntPtr NativeMethodInfoPtr_OnConfirmPopup_Public_Void_Boolean_0;

	// Token: 0x04001210 RID: 4624
	private static readonly IntPtr NativeMethodInfoPtr_OnJoinGameButtonPressed_Public_Void_0;

	// Token: 0x04001211 RID: 4625
	private static readonly IntPtr NativeMethodInfoPtr_HandleCreateCanceled_Public_Void_0;

	// Token: 0x04001212 RID: 4626
	private static readonly IntPtr NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0;

	// Token: 0x04001213 RID: 4627
	private static readonly IntPtr NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0;

	// Token: 0x04001214 RID: 4628
	private static readonly IntPtr NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0;

	// Token: 0x04001215 RID: 4629
	private static readonly IntPtr NativeMethodInfoPtr_UpdateTimerLabel_Private_Void_0;

	// Token: 0x04001216 RID: 4630
	private static readonly IntPtr NativeMethodInfoPtr_DelayCloseAfterSuccess_Private_IEnumerator_0;

	// Token: 0x04001217 RID: 4631
	private static readonly IntPtr NativeMethodInfoPtr_ProcessJoinGameReply_Private_Void_Int32_0;

	// Token: 0x04001218 RID: 4632
	private static readonly IntPtr NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0;

	// Token: 0x04001219 RID: 4633
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001FE RID: 510
	[Serializable]
	public sealed class PlayerSlot : ValueType
	{
		// Token: 0x06002899 RID: 10393 RVA: 0x00092CF8 File Offset: 0x00090EF8
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSlot()
		{
			Il2CppClassPointerStore<UI_OnlineJoinViewGame.PlayerSlot>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "PlayerSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_OnlineJoinViewGame.PlayerSlot>.NativeClassPtr);
			UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame.PlayerSlot>.NativeClassPtr, "root");
			UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame.PlayerSlot>.NativeClassPtr, "avatar");
			UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame.PlayerSlot>.NativeClassPtr, "name");
			UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_invitedObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame.PlayerSlot>.NativeClassPtr, "invitedObj");
			UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_onlineStatusObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame.PlayerSlot>.NativeClassPtr, "onlineStatusObj");
			UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_onlineStatusImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame.PlayerSlot>.NativeClassPtr, "onlineStatusImage");
			UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_playerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame.PlayerSlot>.NativeClassPtr, "playerID");
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x000190C1 File Offset: 0x000172C1
		public PlayerSlot(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x000190CA File Offset: 0x000172CA
		public PlayerSlot()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_OnlineJoinViewGame.PlayerSlot>.NativeClassPtr))
		{
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x0600289C RID: 10396 RVA: 0x00092DB0 File Offset: 0x00090FB0
		// (set) Token: 0x0600289D RID: 10397 RVA: 0x000190DC File Offset: 0x000172DC
		public unsafe GameObject root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x00092DE0 File Offset: 0x00090FE0
		// (set) Token: 0x0600289F RID: 10399 RVA: 0x000190FB File Offset: 0x000172FB
		public unsafe Avatar_UI avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x00092E10 File Offset: 0x00091010
		// (set) Token: 0x060028A1 RID: 10401 RVA: 0x0001911A File Offset: 0x0001731A
		public unsafe TextMeshProUGUI name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x00092E40 File Offset: 0x00091040
		// (set) Token: 0x060028A3 RID: 10403 RVA: 0x00019139 File Offset: 0x00017339
		public unsafe GameObject invitedObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_invitedObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_invitedObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x00092E70 File Offset: 0x00091070
		// (set) Token: 0x060028A5 RID: 10405 RVA: 0x00019158 File Offset: 0x00017358
		public unsafe GameObject onlineStatusObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_onlineStatusObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_onlineStatusObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x060028A6 RID: 10406 RVA: 0x00092EA0 File Offset: 0x000910A0
		// (set) Token: 0x060028A7 RID: 10407 RVA: 0x00019177 File Offset: 0x00017377
		public unsafe Image onlineStatusImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_onlineStatusImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_onlineStatusImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x00092ED0 File Offset: 0x000910D0
		// (set) Token: 0x060028A9 RID: 10409 RVA: 0x00019196 File Offset: 0x00017396
		public unsafe uint playerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_playerID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame.PlayerSlot.NativeFieldInfoPtr_playerID)) = value;
			}
		}

		// Token: 0x04001BE5 RID: 7141
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x04001BE6 RID: 7142
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04001BE7 RID: 7143
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001BE8 RID: 7144
		private static readonly IntPtr NativeFieldInfoPtr_invitedObj;

		// Token: 0x04001BE9 RID: 7145
		private static readonly IntPtr NativeFieldInfoPtr_onlineStatusObj;

		// Token: 0x04001BEA RID: 7146
		private static readonly IntPtr NativeFieldInfoPtr_onlineStatusImage;

		// Token: 0x04001BEB RID: 7147
		private static readonly IntPtr NativeFieldInfoPtr_playerID;
	}

	// Token: 0x020001FF RID: 511
	[ObfuscatedName("UI_OnlineJoinViewGame+<HandleBackFromPopup>d__30")]
	public sealed class _HandleBackFromPopup_d__30 : global::Il2CppSystem.Object
	{
		// Token: 0x060028AA RID: 10410 RVA: 0x00092EF8 File Offset: 0x000910F8
		// Note: this type is marked as 'beforefieldinit'.
		static _HandleBackFromPopup_d__30()
		{
			Il2CppClassPointerStore<UI_OnlineJoinViewGame._HandleBackFromPopup_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "<HandleBackFromPopup>d__30");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_OnlineJoinViewGame._HandleBackFromPopup_d__30>.NativeClassPtr);
			UI_OnlineJoinViewGame._HandleBackFromPopup_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame._HandleBackFromPopup_d__30>.NativeClassPtr, "<>1__state");
			UI_OnlineJoinViewGame._HandleBackFromPopup_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame._HandleBackFromPopup_d__30>.NativeClassPtr, "<>2__current");
			UI_OnlineJoinViewGame._HandleBackFromPopup_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame._HandleBackFromPopup_d__30>.NativeClassPtr, 100666486);
			UI_OnlineJoinViewGame._HandleBackFromPopup_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame._HandleBackFromPopup_d__30>.NativeClassPtr, 100666487);
			UI_OnlineJoinViewGame._HandleBackFromPopup_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame._HandleBackFromPopup_d__30>.NativeClassPtr, 100666488);
			UI_OnlineJoinViewGame._HandleBackFromPopup_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame._HandleBackFromPopup_d__30>.NativeClassPtr, 100666489);
			UI_OnlineJoinViewGame._HandleBackFromPopup_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame._HandleBackFromPopup_d__30>.NativeClassPtr, 100666490);
			UI_OnlineJoinViewGame._HandleBackFromPopup_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame._HandleBackFromPopup_d__30>.NativeClassPtr, 100666491);
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x00092FC4 File Offset: 0x000911C4
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _HandleBackFromPopup_d__30(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_OnlineJoinViewGame._HandleBackFromPopup_d__30>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame._HandleBackFromPopup_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x0009300C File Offset: 0x0009120C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame._HandleBackFromPopup_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x00093040 File Offset: 0x00091240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251984, XrefRangeEnd = 251994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame._HandleBackFromPopup_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x060028AE RID: 10414 RVA: 0x0009307C File Offset: 0x0009127C
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame._HandleBackFromPopup_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x000930BC File Offset: 0x000912BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251994, XrefRangeEnd = 251999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame._HandleBackFromPopup_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x060028B0 RID: 10416 RVA: 0x000930F0 File Offset: 0x000912F0
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame._HandleBackFromPopup_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x000191B1 File Offset: 0x000173B1
		public _HandleBackFromPopup_d__30(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x060028B2 RID: 10418 RVA: 0x00093130 File Offset: 0x00091330
		// (set) Token: 0x060028B3 RID: 10419 RVA: 0x000191BA File Offset: 0x000173BA
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._HandleBackFromPopup_d__30.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._HandleBackFromPopup_d__30.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x060028B4 RID: 10420 RVA: 0x00093158 File Offset: 0x00091358
		// (set) Token: 0x060028B5 RID: 10421 RVA: 0x000191D5 File Offset: 0x000173D5
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._HandleBackFromPopup_d__30.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._HandleBackFromPopup_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BEC RID: 7148
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001BED RID: 7149
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001BEE RID: 7150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001BEF RID: 7151
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001BF0 RID: 7152
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001BF1 RID: 7153
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001BF2 RID: 7154
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001BF3 RID: 7155
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000200 RID: 512
	[ObfuscatedName("UI_OnlineJoinViewGame+<DelayCloseAfterSuccess>d__41")]
	public sealed class _DelayCloseAfterSuccess_d__41 : global::Il2CppSystem.Object
	{
		// Token: 0x060028B6 RID: 10422 RVA: 0x00093188 File Offset: 0x00091388
		// Note: this type is marked as 'beforefieldinit'.
		static _DelayCloseAfterSuccess_d__41()
		{
			Il2CppClassPointerStore<UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "<DelayCloseAfterSuccess>d__41");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41>.NativeClassPtr);
			UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41>.NativeClassPtr, "<>1__state");
			UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41>.NativeClassPtr, "<>2__current");
			UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41>.NativeClassPtr, "<>4__this");
			UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41>.NativeClassPtr, 100666492);
			UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41>.NativeClassPtr, 100666493);
			UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41>.NativeClassPtr, 100666494);
			UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41>.NativeClassPtr, 100666495);
			UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41>.NativeClassPtr, 100666496);
			UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41>.NativeClassPtr, 100666497);
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x00093268 File Offset: 0x00091468
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _DelayCloseAfterSuccess_d__41(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x000932B0 File Offset: 0x000914B0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x000932E4 File Offset: 0x000914E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251999, XrefRangeEnd = 252005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x060028BA RID: 10426 RVA: 0x00093320 File Offset: 0x00091520
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x00093360 File Offset: 0x00091560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252005, XrefRangeEnd = 252010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x060028BC RID: 10428 RVA: 0x00093394 File Offset: 0x00091594
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x000191F4 File Offset: 0x000173F4
		public _DelayCloseAfterSuccess_d__41(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x060028BE RID: 10430 RVA: 0x000933D4 File Offset: 0x000915D4
		// (set) Token: 0x060028BF RID: 10431 RVA: 0x000191FD File Offset: 0x000173FD
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x060028C0 RID: 10432 RVA: 0x000933FC File Offset: 0x000915FC
		// (set) Token: 0x060028C1 RID: 10433 RVA: 0x00019218 File Offset: 0x00017418
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x060028C2 RID: 10434 RVA: 0x0009342C File Offset: 0x0009162C
		// (set) Token: 0x060028C3 RID: 10435 RVA: 0x00019237 File Offset: 0x00017437
		public unsafe UI_OnlineJoinViewGame __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_OnlineJoinViewGame>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._DelayCloseAfterSuccess_d__41.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BF4 RID: 7156
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001BF5 RID: 7157
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001BF6 RID: 7158
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001BF7 RID: 7159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001BF8 RID: 7160
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001BF9 RID: 7161
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001BFA RID: 7162
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001BFB RID: 7163
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001BFC RID: 7164
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000201 RID: 513
	[ObfuscatedName("UI_OnlineJoinViewGame+<ProcessDelayTime>d__43")]
	public sealed class _ProcessDelayTime_d__43 : global::Il2CppSystem.Object
	{
		// Token: 0x060028C4 RID: 10436 RVA: 0x0009345C File Offset: 0x0009165C
		// Note: this type is marked as 'beforefieldinit'.
		static _ProcessDelayTime_d__43()
		{
			Il2CppClassPointerStore<UI_OnlineJoinViewGame._ProcessDelayTime_d__43>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_OnlineJoinViewGame>.NativeClassPtr, "<ProcessDelayTime>d__43");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_OnlineJoinViewGame._ProcessDelayTime_d__43>.NativeClassPtr);
			UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame._ProcessDelayTime_d__43>.NativeClassPtr, "<>1__state");
			UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame._ProcessDelayTime_d__43>.NativeClassPtr, "<>2__current");
			UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame._ProcessDelayTime_d__43>.NativeClassPtr, "<>4__this");
			UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeFieldInfoPtr_totalDelayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame._ProcessDelayTime_d__43>.NativeClassPtr, "totalDelayTime");
			UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeFieldInfoPtr__accumulatedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame._ProcessDelayTime_d__43>.NativeClassPtr, "<accumulatedTime>5__2");
			UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeFieldInfoPtr__previousTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineJoinViewGame._ProcessDelayTime_d__43>.NativeClassPtr, "<previousTime>5__3");
			UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame._ProcessDelayTime_d__43>.NativeClassPtr, 100666498);
			UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame._ProcessDelayTime_d__43>.NativeClassPtr, 100666499);
			UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame._ProcessDelayTime_d__43>.NativeClassPtr, 100666500);
			UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame._ProcessDelayTime_d__43>.NativeClassPtr, 100666501);
			UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame._ProcessDelayTime_d__43>.NativeClassPtr, 100666502);
			UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineJoinViewGame._ProcessDelayTime_d__43>.NativeClassPtr, 100666503);
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x00093578 File Offset: 0x00091778
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ProcessDelayTime_d__43(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_OnlineJoinViewGame._ProcessDelayTime_d__43>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x000935C0 File Offset: 0x000917C0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x000935F4 File Offset: 0x000917F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252010, XrefRangeEnd = 252018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x060028C8 RID: 10440 RVA: 0x00093630 File Offset: 0x00091830
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x00093670 File Offset: 0x00091870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252018, XrefRangeEnd = 252023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x060028CA RID: 10442 RVA: 0x000936A4 File Offset: 0x000918A4
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x00019256 File Offset: 0x00017456
		public _ProcessDelayTime_d__43(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x060028CC RID: 10444 RVA: 0x000936E4 File Offset: 0x000918E4
		// (set) Token: 0x060028CD RID: 10445 RVA: 0x0001925F File Offset: 0x0001745F
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x060028CE RID: 10446 RVA: 0x0009370C File Offset: 0x0009190C
		// (set) Token: 0x060028CF RID: 10447 RVA: 0x0001927A File Offset: 0x0001747A
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x060028D0 RID: 10448 RVA: 0x0009373C File Offset: 0x0009193C
		// (set) Token: 0x060028D1 RID: 10449 RVA: 0x00019299 File Offset: 0x00017499
		public unsafe UI_OnlineJoinViewGame __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_OnlineJoinViewGame>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x060028D2 RID: 10450 RVA: 0x0009376C File Offset: 0x0009196C
		// (set) Token: 0x060028D3 RID: 10451 RVA: 0x000192B8 File Offset: 0x000174B8
		public unsafe float totalDelayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeFieldInfoPtr_totalDelayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeFieldInfoPtr_totalDelayTime)) = value;
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x060028D4 RID: 10452 RVA: 0x00093794 File Offset: 0x00091994
		// (set) Token: 0x060028D5 RID: 10453 RVA: 0x000192D3 File Offset: 0x000174D3
		public unsafe float _accumulatedTime_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeFieldInfoPtr__accumulatedTime_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeFieldInfoPtr__accumulatedTime_5__2)) = value;
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x060028D6 RID: 10454 RVA: 0x000937BC File Offset: 0x000919BC
		// (set) Token: 0x060028D7 RID: 10455 RVA: 0x000192EE File Offset: 0x000174EE
		public unsafe float _previousTime_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeFieldInfoPtr__previousTime_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineJoinViewGame._ProcessDelayTime_d__43.NativeFieldInfoPtr__previousTime_5__3)) = value;
			}
		}

		// Token: 0x04001BFD RID: 7165
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001BFE RID: 7166
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001BFF RID: 7167
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001C00 RID: 7168
		private static readonly IntPtr NativeFieldInfoPtr_totalDelayTime;

		// Token: 0x04001C01 RID: 7169
		private static readonly IntPtr NativeFieldInfoPtr__accumulatedTime_5__2;

		// Token: 0x04001C02 RID: 7170
		private static readonly IntPtr NativeFieldInfoPtr__previousTime_5__3;

		// Token: 0x04001C03 RID: 7171
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001C04 RID: 7172
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001C05 RID: 7173
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001C06 RID: 7174
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001C07 RID: 7175
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001C08 RID: 7176
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000DB RID: 219
public class UI_ProfileList : UI_NetworkBase
{
	// Token: 0x06001AE5 RID: 6885 RVA: 0x0006AC44 File Offset: 0x00068E44
	// Note: this type is marked as 'beforefieldinit'.
	static UI_ProfileList()
	{
		Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_ProfileList");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr);
		UI_ProfileList.NativeFieldInfoPtr_m_confirmPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_confirmPopup");
		UI_ProfileList.NativeFieldInfoPtr_m_confirmPopupNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_confirmPopupNameText");
		UI_ProfileList.NativeFieldInfoPtr_m_confirmPopupAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_confirmPopupAvatar");
		UI_ProfileList.NativeFieldInfoPtr_m_localPlayerNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_localPlayerNameText");
		UI_ProfileList.NativeFieldInfoPtr_m_localPlayerAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_localPlayerAvatar");
		UI_ProfileList.NativeFieldInfoPtr_m_messagePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_messagePopup");
		UI_ProfileList.NativeFieldInfoPtr_m_messagePopupCancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_messagePopupCancelButton");
		UI_ProfileList.NativeFieldInfoPtr_m_messagePopupTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_messagePopupTitle");
		UI_ProfileList.NativeFieldInfoPtr_m_messagePopupText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_messagePopupText");
		UI_ProfileList.NativeFieldInfoPtr_m_minDialogDisplayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_minDialogDisplayTime");
		UI_ProfileList.NativeFieldInfoPtr_m_friendsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_friendsList");
		UI_ProfileList.NativeFieldInfoPtr_m_friendInfoDisplayRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_friendInfoDisplayRoot");
		UI_ProfileList.NativeFieldInfoPtr_m_profileListBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_profileListBase");
		UI_ProfileList.NativeFieldInfoPtr_m_avatarListBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_avatarListBase");
		UI_ProfileList.NativeFieldInfoPtr_m_profileAvatarToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_profileAvatarToggle");
		UI_ProfileList.NativeFieldInfoPtr_m_nameRenamePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_nameRenamePopup");
		UI_ProfileList.NativeFieldInfoPtr_m_nameRenameField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_nameRenameField");
		UI_ProfileList.NativeFieldInfoPtr_m_nameRenameInputFieldObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_nameRenameInputFieldObj");
		UI_ProfileList.NativeFieldInfoPtr_m_nameRenameDupErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_nameRenameDupErrorMessage");
		UI_ProfileList.NativeFieldInfoPtr_m_nameRenameConfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_nameRenameConfirmButton");
		UI_ProfileList.NativeFieldInfoPtr_m_inProgressNumLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_inProgressNumLabel");
		UI_ProfileList.NativeFieldInfoPtr_m_gamesCompletedNumLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_gamesCompletedNumLabel");
		UI_ProfileList.NativeFieldInfoPtr_m_forfeitsNumLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_forfeitsNumLabel");
		UI_ProfileList.NativeFieldInfoPtr_m_2pRecordNumLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_2pRecordNumLabel");
		UI_ProfileList.NativeFieldInfoPtr_m_3pRecordNumLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_3pRecordNumLabel");
		UI_ProfileList.NativeFieldInfoPtr_m_4pRecordNumLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_4pRecordNumLabel");
		UI_ProfileList.NativeFieldInfoPtr_m_ratingNumLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_ratingNumLabel");
		UI_ProfileList.NativeFieldInfoPtr_m_addFriendUserName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_addFriendUserName");
		UI_ProfileList.NativeFieldInfoPtr_m_OfflineOnlyObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_OfflineOnlyObjects");
		UI_ProfileList.NativeFieldInfoPtr_m_OnlineOnlyObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_OnlineOnlyObjects");
		UI_ProfileList.NativeFieldInfoPtr_m_delayCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_delayCoroutine");
		UI_ProfileList.NativeFieldInfoPtr_m_currentFriendDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_currentFriendDisplayName");
		UI_ProfileList.NativeFieldInfoPtr_m_currentFriendDisplayedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_currentFriendDisplayedID");
		UI_ProfileList.NativeFieldInfoPtr_m_requestedFriendId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_requestedFriendId");
		UI_ProfileList.NativeFieldInfoPtr_m_processFriendRequestReplyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_processFriendRequestReplyData");
		UI_ProfileList.NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_bMinDialogDisplayTimeReached");
		UI_ProfileList.NativeFieldInfoPtr_m_bProcessFriendRequestReply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_bProcessFriendRequestReply");
		UI_ProfileList.NativeFieldInfoPtr_m_bNamePopupIsNewProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_bNamePopupIsNewProfile");
		UI_ProfileList.NativeFieldInfoPtr_m_offlineProfileManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_offlineProfileManager");
		UI_ProfileList.NativeFieldInfoPtr_m_selectedProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "m_selectedProfile");
		UI_ProfileList.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665424);
		UI_ProfileList.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665425);
		UI_ProfileList.NativeMethodInfoPtr_SetOfflineStats_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665426);
		UI_ProfileList.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665427);
		UI_ProfileList.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665428);
		UI_ProfileList.NativeMethodInfoPtr_OnProfileAvatarToggle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665429);
		UI_ProfileList.NativeMethodInfoPtr_OnAvatarButtonPressed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665430);
		UI_ProfileList.NativeMethodInfoPtr_SaveOfflineProfile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665431);
		UI_ProfileList.NativeMethodInfoPtr_AskToRemoveFriend_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665432);
		UI_ProfileList.NativeMethodInfoPtr_OnAddProfilePressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665433);
		UI_ProfileList.NativeMethodInfoPtr_OnRenameProfilePressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665434);
		UI_ProfileList.NativeMethodInfoPtr_OnNameRenameConfirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665435);
		UI_ProfileList.NativeMethodInfoPtr_RemoveFriend_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665436);
		UI_ProfileList.NativeMethodInfoPtr_OnProfilePopupClose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665437);
		UI_ProfileList.NativeMethodInfoPtr_OnProfileButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665438);
		UI_ProfileList.NativeMethodInfoPtr_OnFriendListButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665439);
		UI_ProfileList.NativeMethodInfoPtr_Notified_Public_Virtual_Final_New_Void_PopupNotificationType_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665440);
		UI_ProfileList.NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665441);
		UI_ProfileList.NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665442);
		UI_ProfileList.NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665443);
		UI_ProfileList.NativeMethodInfoPtr_OnNameRenamePressed_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665444);
		UI_ProfileList.NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665445);
		UI_ProfileList.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_Profile_ClickEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665446);
		UI_ProfileList.NativeMethodInfoPtr_RequestFriendProfile_Private_Void_FriendInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665447);
		UI_ProfileList.NativeMethodInfoPtr_DisplayTopUserInfo_Private_Void_String_UInt16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665448);
		UI_ProfileList.NativeMethodInfoPtr_HandleClickOnLocalPlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665449);
		UI_ProfileList.NativeMethodInfoPtr_HandleUpdatedLocalPlayerProfile_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665450);
		UI_ProfileList.NativeMethodInfoPtr_DisplayLocalPlayerProfile_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665451);
		UI_ProfileList.NativeMethodInfoPtr_DisplayFriendProfileInfo_Private_Void_NetworkPlayerProfileInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665452);
		UI_ProfileList.NativeMethodInfoPtr_ProcessFriendRequestReply_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665453);
		UI_ProfileList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, 100665454);
	}

	// Token: 0x06001AE6 RID: 6886 RVA: 0x0006B200 File Offset: 0x00069400
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252613, XrefRangeEnd = 252618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AE7 RID: 6887 RVA: 0x0006B234 File Offset: 0x00069434
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252618, XrefRangeEnd = 252661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnterMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AE8 RID: 6888 RVA: 0x0006B268 File Offset: 0x00069468
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 252688, RefRangeEnd = 252692, XrefRangeStart = 252661, XrefRangeEnd = 252688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOfflineStats(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_SetOfflineStats_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001AE9 RID: 6889 RVA: 0x0006B2A8 File Offset: 0x000694A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252692, XrefRangeEnd = 252701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExitMenu(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001AEA RID: 6890 RVA: 0x0006B2E8 File Offset: 0x000694E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252701, XrefRangeEnd = 252706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AEB RID: 6891 RVA: 0x0006B31C File Offset: 0x0006951C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252706, XrefRangeEnd = 252709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnProfileAvatarToggle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_OnProfileAvatarToggle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AEC RID: 6892 RVA: 0x0006B350 File Offset: 0x00069550
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252709, XrefRangeEnd = 252716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAvatarButtonPressed(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_OnAvatarButtonPressed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001AED RID: 6893 RVA: 0x0006B390 File Offset: 0x00069590
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252716, XrefRangeEnd = 252729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveOfflineProfile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_SaveOfflineProfile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AEE RID: 6894 RVA: 0x0006B3C4 File Offset: 0x000695C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252729, XrefRangeEnd = 252736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AskToRemoveFriend()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_AskToRemoveFriend_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AEF RID: 6895 RVA: 0x0006B3F8 File Offset: 0x000695F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252736, XrefRangeEnd = 252737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAddProfilePressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_OnAddProfilePressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AF0 RID: 6896 RVA: 0x0006B42C File Offset: 0x0006962C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252737, XrefRangeEnd = 252738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRenameProfilePressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_OnRenameProfilePressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AF1 RID: 6897 RVA: 0x0006B460 File Offset: 0x00069660
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252738, XrefRangeEnd = 252755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnNameRenameConfirm()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_OnNameRenameConfirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AF2 RID: 6898 RVA: 0x0006B494 File Offset: 0x00069694
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252755, XrefRangeEnd = 252763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveFriend()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_RemoveFriend_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AF3 RID: 6899 RVA: 0x0006B4C8 File Offset: 0x000696C8
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnProfilePopupClose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_OnProfilePopupClose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AF4 RID: 6900 RVA: 0x0006B4FC File Offset: 0x000696FC
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnProfileButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_OnProfileButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AF5 RID: 6901 RVA: 0x0006B530 File Offset: 0x00069730
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnFriendListButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_OnFriendListButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AF6 RID: 6902 RVA: 0x0006B564 File Offset: 0x00069764
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252763, XrefRangeEnd = 252779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Notified(PopupNotificationType type, string childPopupName, global::Il2CppSystem.Object data = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref type;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(childPopupName);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_Notified_Public_Virtual_Final_New_Void_PopupNotificationType_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AF7 RID: 6903 RVA: 0x0006B5C8 File Offset: 0x000697C8
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NetworkStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_ProfileList.NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AF8 RID: 6904 RVA: 0x0006B604 File Offset: 0x00069804
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NetworkOnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_ProfileList.NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AF9 RID: 6905 RVA: 0x0006B640 File Offset: 0x00069840
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252779, XrefRangeEnd = 252780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_ProfileList.NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AFA RID: 6906 RVA: 0x0006B698 File Offset: 0x00069898
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 252788, RefRangeEnd = 252790, XrefRangeStart = 252780, XrefRangeEnd = 252788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnNameRenamePressed(bool bIsNewProfile)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bIsNewProfile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_OnNameRenamePressed_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001AFB RID: 6907 RVA: 0x0006B6D8 File Offset: 0x000698D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252790, XrefRangeEnd = 252794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ProcessDelayTime(float totalDelayTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref totalDelayTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x06001AFC RID: 6908 RVA: 0x0006B724 File Offset: 0x00069924
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252794, XrefRangeEnd = 252805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_Profile_ClickEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AFD RID: 6909 RVA: 0x0006B774 File Offset: 0x00069974
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252805, XrefRangeEnd = 252808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RequestFriendProfile(FriendInfo friendInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(friendInfo));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_RequestFriendProfile_Private_Void_FriendInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001AFE RID: 6910 RVA: 0x0006B7BC File Offset: 0x000699BC
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplayTopUserInfo(string name, ushort rating, string altString)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rating;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(altString);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_DisplayTopUserInfo_Private_Void_String_UInt16_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AFF RID: 6911 RVA: 0x0006B820 File Offset: 0x00069A20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252808, XrefRangeEnd = 252809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleClickOnLocalPlayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_HandleClickOnLocalPlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B00 RID: 6912 RVA: 0x0006B854 File Offset: 0x00069A54
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252809, XrefRangeEnd = 252810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleUpdatedLocalPlayerProfile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_HandleUpdatedLocalPlayerProfile_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B01 RID: 6913 RVA: 0x0006B888 File Offset: 0x00069A88
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 252818, RefRangeEnd = 252821, XrefRangeStart = 252810, XrefRangeEnd = 252818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplayLocalPlayerProfile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_DisplayLocalPlayerProfile_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B02 RID: 6914 RVA: 0x0006B8BC File Offset: 0x00069ABC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252821, XrefRangeEnd = 252822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplayFriendProfileInfo(NetworkPlayerProfileInfo profileInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profileInfo));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_DisplayFriendProfileInfo_Private_Void_NetworkPlayerProfileInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001B03 RID: 6915 RVA: 0x0006B904 File Offset: 0x00069B04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252822, XrefRangeEnd = 252840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessFriendRequestReply(int eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr_ProcessFriendRequestReply_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001B04 RID: 6916 RVA: 0x0006B944 File Offset: 0x00069B44
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252840, XrefRangeEnd = 252844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_ProfileList()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B05 RID: 6917 RVA: 0x0001143A File Offset: 0x0000F63A
	public UI_ProfileList(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000898 RID: 2200
	// (get) Token: 0x06001B06 RID: 6918 RVA: 0x0006B980 File Offset: 0x00069B80
	// (set) Token: 0x06001B07 RID: 6919 RVA: 0x00011443 File Offset: 0x0000F643
	public unsafe GameObject m_confirmPopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_confirmPopup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_confirmPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000899 RID: 2201
	// (get) Token: 0x06001B08 RID: 6920 RVA: 0x0006B9B0 File Offset: 0x00069BB0
	// (set) Token: 0x06001B09 RID: 6921 RVA: 0x00011462 File Offset: 0x0000F662
	public unsafe Text m_confirmPopupNameText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_confirmPopupNameText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_confirmPopupNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700089A RID: 2202
	// (get) Token: 0x06001B0A RID: 6922 RVA: 0x0006B9E0 File Offset: 0x00069BE0
	// (set) Token: 0x06001B0B RID: 6923 RVA: 0x00011481 File Offset: 0x0000F681
	public unsafe Avatar_UI m_confirmPopupAvatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_confirmPopupAvatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_confirmPopupAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700089B RID: 2203
	// (get) Token: 0x06001B0C RID: 6924 RVA: 0x0006BA10 File Offset: 0x00069C10
	// (set) Token: 0x06001B0D RID: 6925 RVA: 0x000114A0 File Offset: 0x0000F6A0
	public unsafe Text m_localPlayerNameText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_localPlayerNameText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_localPlayerNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700089C RID: 2204
	// (get) Token: 0x06001B0E RID: 6926 RVA: 0x0006BA40 File Offset: 0x00069C40
	// (set) Token: 0x06001B0F RID: 6927 RVA: 0x000114BF File Offset: 0x0000F6BF
	public unsafe Avatar_UI m_localPlayerAvatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_localPlayerAvatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_localPlayerAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700089D RID: 2205
	// (get) Token: 0x06001B10 RID: 6928 RVA: 0x0006BA70 File Offset: 0x00069C70
	// (set) Token: 0x06001B11 RID: 6929 RVA: 0x000114DE File Offset: 0x0000F6DE
	public unsafe GameObject m_messagePopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_messagePopup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_messagePopup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700089E RID: 2206
	// (get) Token: 0x06001B12 RID: 6930 RVA: 0x0006BAA0 File Offset: 0x00069CA0
	// (set) Token: 0x06001B13 RID: 6931 RVA: 0x000114FD File Offset: 0x0000F6FD
	public unsafe GameObject m_messagePopupCancelButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_messagePopupCancelButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_messagePopupCancelButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700089F RID: 2207
	// (get) Token: 0x06001B14 RID: 6932 RVA: 0x0006BAD0 File Offset: 0x00069CD0
	// (set) Token: 0x06001B15 RID: 6933 RVA: 0x0001151C File Offset: 0x0000F71C
	public unsafe Text m_messagePopupTitle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_messagePopupTitle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_messagePopupTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008A0 RID: 2208
	// (get) Token: 0x06001B16 RID: 6934 RVA: 0x0006BB00 File Offset: 0x00069D00
	// (set) Token: 0x06001B17 RID: 6935 RVA: 0x0001153B File Offset: 0x0000F73B
	public unsafe Text m_messagePopupText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_messagePopupText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_messagePopupText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008A1 RID: 2209
	// (get) Token: 0x06001B18 RID: 6936 RVA: 0x0006BB30 File Offset: 0x00069D30
	// (set) Token: 0x06001B19 RID: 6937 RVA: 0x0001155A File Offset: 0x0000F75A
	public unsafe float m_minDialogDisplayTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_minDialogDisplayTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_minDialogDisplayTime)) = value;
		}
	}

	// Token: 0x170008A2 RID: 2210
	// (get) Token: 0x06001B1A RID: 6938 RVA: 0x0006BB58 File Offset: 0x00069D58
	// (set) Token: 0x06001B1B RID: 6939 RVA: 0x00011575 File Offset: 0x0000F775
	public unsafe UIC_FriendsList m_friendsList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_friendsList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_FriendsList>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_friendsList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008A3 RID: 2211
	// (get) Token: 0x06001B1C RID: 6940 RVA: 0x0006BB88 File Offset: 0x00069D88
	// (set) Token: 0x06001B1D RID: 6941 RVA: 0x00011594 File Offset: 0x0000F794
	public unsafe GameObject m_friendInfoDisplayRoot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_friendInfoDisplayRoot);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_friendInfoDisplayRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008A4 RID: 2212
	// (get) Token: 0x06001B1E RID: 6942 RVA: 0x0006BBB8 File Offset: 0x00069DB8
	// (set) Token: 0x06001B1F RID: 6943 RVA: 0x000115B3 File Offset: 0x0000F7B3
	public unsafe GameObject m_profileListBase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_profileListBase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_profileListBase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008A5 RID: 2213
	// (get) Token: 0x06001B20 RID: 6944 RVA: 0x0006BBE8 File Offset: 0x00069DE8
	// (set) Token: 0x06001B21 RID: 6945 RVA: 0x000115D2 File Offset: 0x0000F7D2
	public unsafe GameObject m_avatarListBase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_avatarListBase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_avatarListBase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008A6 RID: 2214
	// (get) Token: 0x06001B22 RID: 6946 RVA: 0x0006BC18 File Offset: 0x00069E18
	// (set) Token: 0x06001B23 RID: 6947 RVA: 0x000115F1 File Offset: 0x0000F7F1
	public unsafe Toggle m_profileAvatarToggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_profileAvatarToggle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_profileAvatarToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008A7 RID: 2215
	// (get) Token: 0x06001B24 RID: 6948 RVA: 0x0006BC48 File Offset: 0x00069E48
	// (set) Token: 0x06001B25 RID: 6949 RVA: 0x00011610 File Offset: 0x0000F810
	public unsafe GameObject m_nameRenamePopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_nameRenamePopup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_nameRenamePopup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008A8 RID: 2216
	// (get) Token: 0x06001B26 RID: 6950 RVA: 0x0006BC78 File Offset: 0x00069E78
	// (set) Token: 0x06001B27 RID: 6951 RVA: 0x0001162F File Offset: 0x0000F82F
	public unsafe InputField m_nameRenameField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_nameRenameField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_nameRenameField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008A9 RID: 2217
	// (get) Token: 0x06001B28 RID: 6952 RVA: 0x0006BCA8 File Offset: 0x00069EA8
	// (set) Token: 0x06001B29 RID: 6953 RVA: 0x0001164E File Offset: 0x0000F84E
	public unsafe GameObject m_nameRenameInputFieldObj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_nameRenameInputFieldObj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_nameRenameInputFieldObj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008AA RID: 2218
	// (get) Token: 0x06001B2A RID: 6954 RVA: 0x0006BCD8 File Offset: 0x00069ED8
	// (set) Token: 0x06001B2B RID: 6955 RVA: 0x0001166D File Offset: 0x0000F86D
	public unsafe GameObject m_nameRenameDupErrorMessage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_nameRenameDupErrorMessage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_nameRenameDupErrorMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008AB RID: 2219
	// (get) Token: 0x06001B2C RID: 6956 RVA: 0x0006BD08 File Offset: 0x00069F08
	// (set) Token: 0x06001B2D RID: 6957 RVA: 0x0001168C File Offset: 0x0000F88C
	public unsafe GameObject m_nameRenameConfirmButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_nameRenameConfirmButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_nameRenameConfirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008AC RID: 2220
	// (get) Token: 0x06001B2E RID: 6958 RVA: 0x0006BD38 File Offset: 0x00069F38
	// (set) Token: 0x06001B2F RID: 6959 RVA: 0x000116AB File Offset: 0x0000F8AB
	public unsafe Text m_inProgressNumLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_inProgressNumLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_inProgressNumLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008AD RID: 2221
	// (get) Token: 0x06001B30 RID: 6960 RVA: 0x0006BD68 File Offset: 0x00069F68
	// (set) Token: 0x06001B31 RID: 6961 RVA: 0x000116CA File Offset: 0x0000F8CA
	public unsafe Text m_gamesCompletedNumLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_gamesCompletedNumLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_gamesCompletedNumLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008AE RID: 2222
	// (get) Token: 0x06001B32 RID: 6962 RVA: 0x0006BD98 File Offset: 0x00069F98
	// (set) Token: 0x06001B33 RID: 6963 RVA: 0x000116E9 File Offset: 0x0000F8E9
	public unsafe Text m_forfeitsNumLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_forfeitsNumLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_forfeitsNumLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008AF RID: 2223
	// (get) Token: 0x06001B34 RID: 6964 RVA: 0x0006BDC8 File Offset: 0x00069FC8
	// (set) Token: 0x06001B35 RID: 6965 RVA: 0x00011708 File Offset: 0x0000F908
	public unsafe Text m_2pRecordNumLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_2pRecordNumLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_2pRecordNumLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008B0 RID: 2224
	// (get) Token: 0x06001B36 RID: 6966 RVA: 0x0006BDF8 File Offset: 0x00069FF8
	// (set) Token: 0x06001B37 RID: 6967 RVA: 0x00011727 File Offset: 0x0000F927
	public unsafe Text m_3pRecordNumLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_3pRecordNumLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_3pRecordNumLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008B1 RID: 2225
	// (get) Token: 0x06001B38 RID: 6968 RVA: 0x0006BE28 File Offset: 0x0006A028
	// (set) Token: 0x06001B39 RID: 6969 RVA: 0x00011746 File Offset: 0x0000F946
	public unsafe Text m_4pRecordNumLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_4pRecordNumLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_4pRecordNumLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008B2 RID: 2226
	// (get) Token: 0x06001B3A RID: 6970 RVA: 0x0006BE58 File Offset: 0x0006A058
	// (set) Token: 0x06001B3B RID: 6971 RVA: 0x00011765 File Offset: 0x0000F965
	public unsafe Text m_ratingNumLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_ratingNumLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_ratingNumLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008B3 RID: 2227
	// (get) Token: 0x06001B3C RID: 6972 RVA: 0x0006BE88 File Offset: 0x0006A088
	// (set) Token: 0x06001B3D RID: 6973 RVA: 0x00011784 File Offset: 0x0000F984
	public unsafe Text m_addFriendUserName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_addFriendUserName);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_addFriendUserName), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008B4 RID: 2228
	// (get) Token: 0x06001B3E RID: 6974 RVA: 0x0006BEB8 File Offset: 0x0006A0B8
	// (set) Token: 0x06001B3F RID: 6975 RVA: 0x000117A3 File Offset: 0x0000F9A3
	public unsafe Il2CppReferenceArray<GameObject> m_OfflineOnlyObjects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_OfflineOnlyObjects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_OfflineOnlyObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008B5 RID: 2229
	// (get) Token: 0x06001B40 RID: 6976 RVA: 0x0006BEE8 File Offset: 0x0006A0E8
	// (set) Token: 0x06001B41 RID: 6977 RVA: 0x000117C2 File Offset: 0x0000F9C2
	public unsafe Il2CppReferenceArray<GameObject> m_OnlineOnlyObjects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_OnlineOnlyObjects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_OnlineOnlyObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008B6 RID: 2230
	// (get) Token: 0x06001B42 RID: 6978 RVA: 0x0006BF18 File Offset: 0x0006A118
	// (set) Token: 0x06001B43 RID: 6979 RVA: 0x000117E1 File Offset: 0x0000F9E1
	public unsafe Coroutine m_delayCoroutine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_delayCoroutine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_delayCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008B7 RID: 2231
	// (get) Token: 0x06001B44 RID: 6980 RVA: 0x0006BF48 File Offset: 0x0006A148
	// (set) Token: 0x06001B45 RID: 6981 RVA: 0x00011800 File Offset: 0x0000FA00
	public unsafe string m_currentFriendDisplayName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_currentFriendDisplayName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_currentFriendDisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170008B8 RID: 2232
	// (get) Token: 0x06001B46 RID: 6982 RVA: 0x0006BF70 File Offset: 0x0006A170
	// (set) Token: 0x06001B47 RID: 6983 RVA: 0x0001181F File Offset: 0x0000FA1F
	public unsafe uint m_currentFriendDisplayedID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_currentFriendDisplayedID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_currentFriendDisplayedID)) = value;
		}
	}

	// Token: 0x170008B9 RID: 2233
	// (get) Token: 0x06001B48 RID: 6984 RVA: 0x0006BF98 File Offset: 0x0006A198
	// (set) Token: 0x06001B49 RID: 6985 RVA: 0x0001183A File Offset: 0x0000FA3A
	public unsafe uint m_requestedFriendId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_requestedFriendId);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_requestedFriendId)) = value;
		}
	}

	// Token: 0x170008BA RID: 2234
	// (get) Token: 0x06001B4A RID: 6986 RVA: 0x0006BFC0 File Offset: 0x0006A1C0
	// (set) Token: 0x06001B4B RID: 6987 RVA: 0x00011855 File Offset: 0x0000FA55
	public unsafe int m_processFriendRequestReplyData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_processFriendRequestReplyData);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_processFriendRequestReplyData)) = value;
		}
	}

	// Token: 0x170008BB RID: 2235
	// (get) Token: 0x06001B4C RID: 6988 RVA: 0x0006BFE8 File Offset: 0x0006A1E8
	// (set) Token: 0x06001B4D RID: 6989 RVA: 0x00011870 File Offset: 0x0000FA70
	public unsafe bool m_bMinDialogDisplayTimeReached
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached)) = value;
		}
	}

	// Token: 0x170008BC RID: 2236
	// (get) Token: 0x06001B4E RID: 6990 RVA: 0x0006C010 File Offset: 0x0006A210
	// (set) Token: 0x06001B4F RID: 6991 RVA: 0x0001188B File Offset: 0x0000FA8B
	public unsafe bool m_bProcessFriendRequestReply
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_bProcessFriendRequestReply);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_bProcessFriendRequestReply)) = value;
		}
	}

	// Token: 0x170008BD RID: 2237
	// (get) Token: 0x06001B50 RID: 6992 RVA: 0x0006C038 File Offset: 0x0006A238
	// (set) Token: 0x06001B51 RID: 6993 RVA: 0x000118A6 File Offset: 0x0000FAA6
	public unsafe bool m_bNamePopupIsNewProfile
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_bNamePopupIsNewProfile);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_bNamePopupIsNewProfile)) = value;
		}
	}

	// Token: 0x170008BE RID: 2238
	// (get) Token: 0x06001B52 RID: 6994 RVA: 0x0006C060 File Offset: 0x0006A260
	// (set) Token: 0x06001B53 RID: 6995 RVA: 0x000118C1 File Offset: 0x0000FAC1
	public unsafe ProfileManager m_offlineProfileManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_offlineProfileManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfileManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_offlineProfileManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008BF RID: 2239
	// (get) Token: 0x06001B54 RID: 6996 RVA: 0x0006C090 File Offset: 0x0006A290
	// (set) Token: 0x06001B55 RID: 6997 RVA: 0x000118E0 File Offset: 0x0000FAE0
	public unsafe int m_selectedProfile
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_selectedProfile);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList.NativeFieldInfoPtr_m_selectedProfile)) = value;
		}
	}

	// Token: 0x0400123A RID: 4666
	private static readonly IntPtr NativeFieldInfoPtr_m_confirmPopup;

	// Token: 0x0400123B RID: 4667
	private static readonly IntPtr NativeFieldInfoPtr_m_confirmPopupNameText;

	// Token: 0x0400123C RID: 4668
	private static readonly IntPtr NativeFieldInfoPtr_m_confirmPopupAvatar;

	// Token: 0x0400123D RID: 4669
	private static readonly IntPtr NativeFieldInfoPtr_m_localPlayerNameText;

	// Token: 0x0400123E RID: 4670
	private static readonly IntPtr NativeFieldInfoPtr_m_localPlayerAvatar;

	// Token: 0x0400123F RID: 4671
	private static readonly IntPtr NativeFieldInfoPtr_m_messagePopup;

	// Token: 0x04001240 RID: 4672
	private static readonly IntPtr NativeFieldInfoPtr_m_messagePopupCancelButton;

	// Token: 0x04001241 RID: 4673
	private static readonly IntPtr NativeFieldInfoPtr_m_messagePopupTitle;

	// Token: 0x04001242 RID: 4674
	private static readonly IntPtr NativeFieldInfoPtr_m_messagePopupText;

	// Token: 0x04001243 RID: 4675
	private static readonly IntPtr NativeFieldInfoPtr_m_minDialogDisplayTime;

	// Token: 0x04001244 RID: 4676
	private static readonly IntPtr NativeFieldInfoPtr_m_friendsList;

	// Token: 0x04001245 RID: 4677
	private static readonly IntPtr NativeFieldInfoPtr_m_friendInfoDisplayRoot;

	// Token: 0x04001246 RID: 4678
	private static readonly IntPtr NativeFieldInfoPtr_m_profileListBase;

	// Token: 0x04001247 RID: 4679
	private static readonly IntPtr NativeFieldInfoPtr_m_avatarListBase;

	// Token: 0x04001248 RID: 4680
	private static readonly IntPtr NativeFieldInfoPtr_m_profileAvatarToggle;

	// Token: 0x04001249 RID: 4681
	private static readonly IntPtr NativeFieldInfoPtr_m_nameRenamePopup;

	// Token: 0x0400124A RID: 4682
	private static readonly IntPtr NativeFieldInfoPtr_m_nameRenameField;

	// Token: 0x0400124B RID: 4683
	private static readonly IntPtr NativeFieldInfoPtr_m_nameRenameInputFieldObj;

	// Token: 0x0400124C RID: 4684
	private static readonly IntPtr NativeFieldInfoPtr_m_nameRenameDupErrorMessage;

	// Token: 0x0400124D RID: 4685
	private static readonly IntPtr NativeFieldInfoPtr_m_nameRenameConfirmButton;

	// Token: 0x0400124E RID: 4686
	private static readonly IntPtr NativeFieldInfoPtr_m_inProgressNumLabel;

	// Token: 0x0400124F RID: 4687
	private static readonly IntPtr NativeFieldInfoPtr_m_gamesCompletedNumLabel;

	// Token: 0x04001250 RID: 4688
	private static readonly IntPtr NativeFieldInfoPtr_m_forfeitsNumLabel;

	// Token: 0x04001251 RID: 4689
	private static readonly IntPtr NativeFieldInfoPtr_m_2pRecordNumLabel;

	// Token: 0x04001252 RID: 4690
	private static readonly IntPtr NativeFieldInfoPtr_m_3pRecordNumLabel;

	// Token: 0x04001253 RID: 4691
	private static readonly IntPtr NativeFieldInfoPtr_m_4pRecordNumLabel;

	// Token: 0x04001254 RID: 4692
	private static readonly IntPtr NativeFieldInfoPtr_m_ratingNumLabel;

	// Token: 0x04001255 RID: 4693
	private static readonly IntPtr NativeFieldInfoPtr_m_addFriendUserName;

	// Token: 0x04001256 RID: 4694
	private static readonly IntPtr NativeFieldInfoPtr_m_OfflineOnlyObjects;

	// Token: 0x04001257 RID: 4695
	private static readonly IntPtr NativeFieldInfoPtr_m_OnlineOnlyObjects;

	// Token: 0x04001258 RID: 4696
	private static readonly IntPtr NativeFieldInfoPtr_m_delayCoroutine;

	// Token: 0x04001259 RID: 4697
	private static readonly IntPtr NativeFieldInfoPtr_m_currentFriendDisplayName;

	// Token: 0x0400125A RID: 4698
	private static readonly IntPtr NativeFieldInfoPtr_m_currentFriendDisplayedID;

	// Token: 0x0400125B RID: 4699
	private static readonly IntPtr NativeFieldInfoPtr_m_requestedFriendId;

	// Token: 0x0400125C RID: 4700
	private static readonly IntPtr NativeFieldInfoPtr_m_processFriendRequestReplyData;

	// Token: 0x0400125D RID: 4701
	private static readonly IntPtr NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached;

	// Token: 0x0400125E RID: 4702
	private static readonly IntPtr NativeFieldInfoPtr_m_bProcessFriendRequestReply;

	// Token: 0x0400125F RID: 4703
	private static readonly IntPtr NativeFieldInfoPtr_m_bNamePopupIsNewProfile;

	// Token: 0x04001260 RID: 4704
	private static readonly IntPtr NativeFieldInfoPtr_m_offlineProfileManager;

	// Token: 0x04001261 RID: 4705
	private static readonly IntPtr NativeFieldInfoPtr_m_selectedProfile;

	// Token: 0x04001262 RID: 4706
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04001263 RID: 4707
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterMenu_Public_Void_0;

	// Token: 0x04001264 RID: 4708
	private static readonly IntPtr NativeMethodInfoPtr_SetOfflineStats_Public_Void_Int32_0;

	// Token: 0x04001265 RID: 4709
	private static readonly IntPtr NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0;

	// Token: 0x04001266 RID: 4710
	private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

	// Token: 0x04001267 RID: 4711
	private static readonly IntPtr NativeMethodInfoPtr_OnProfileAvatarToggle_Public_Void_0;

	// Token: 0x04001268 RID: 4712
	private static readonly IntPtr NativeMethodInfoPtr_OnAvatarButtonPressed_Public_Void_Int32_0;

	// Token: 0x04001269 RID: 4713
	private static readonly IntPtr NativeMethodInfoPtr_SaveOfflineProfile_Public_Void_0;

	// Token: 0x0400126A RID: 4714
	private static readonly IntPtr NativeMethodInfoPtr_AskToRemoveFriend_Public_Void_0;

	// Token: 0x0400126B RID: 4715
	private static readonly IntPtr NativeMethodInfoPtr_OnAddProfilePressed_Public_Void_0;

	// Token: 0x0400126C RID: 4716
	private static readonly IntPtr NativeMethodInfoPtr_OnRenameProfilePressed_Public_Void_0;

	// Token: 0x0400126D RID: 4717
	private static readonly IntPtr NativeMethodInfoPtr_OnNameRenameConfirm_Public_Void_0;

	// Token: 0x0400126E RID: 4718
	private static readonly IntPtr NativeMethodInfoPtr_RemoveFriend_Public_Void_0;

	// Token: 0x0400126F RID: 4719
	private static readonly IntPtr NativeMethodInfoPtr_OnProfilePopupClose_Public_Void_0;

	// Token: 0x04001270 RID: 4720
	private static readonly IntPtr NativeMethodInfoPtr_OnProfileButtonPressed_Public_Void_0;

	// Token: 0x04001271 RID: 4721
	private static readonly IntPtr NativeMethodInfoPtr_OnFriendListButtonPressed_Public_Void_0;

	// Token: 0x04001272 RID: 4722
	private static readonly IntPtr NativeMethodInfoPtr_Notified_Public_Virtual_Final_New_Void_PopupNotificationType_String_Object_0;

	// Token: 0x04001273 RID: 4723
	private static readonly IntPtr NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0;

	// Token: 0x04001274 RID: 4724
	private static readonly IntPtr NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0;

	// Token: 0x04001275 RID: 4725
	private static readonly IntPtr NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0;

	// Token: 0x04001276 RID: 4726
	private static readonly IntPtr NativeMethodInfoPtr_OnNameRenamePressed_Private_Void_Boolean_0;

	// Token: 0x04001277 RID: 4727
	private static readonly IntPtr NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0;

	// Token: 0x04001278 RID: 4728
	private static readonly IntPtr NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_Profile_ClickEventType_0;

	// Token: 0x04001279 RID: 4729
	private static readonly IntPtr NativeMethodInfoPtr_RequestFriendProfile_Private_Void_FriendInfo_0;

	// Token: 0x0400127A RID: 4730
	private static readonly IntPtr NativeMethodInfoPtr_DisplayTopUserInfo_Private_Void_String_UInt16_String_0;

	// Token: 0x0400127B RID: 4731
	private static readonly IntPtr NativeMethodInfoPtr_HandleClickOnLocalPlayer_Public_Void_0;

	// Token: 0x0400127C RID: 4732
	private static readonly IntPtr NativeMethodInfoPtr_HandleUpdatedLocalPlayerProfile_Private_Void_0;

	// Token: 0x0400127D RID: 4733
	private static readonly IntPtr NativeMethodInfoPtr_DisplayLocalPlayerProfile_Private_Void_0;

	// Token: 0x0400127E RID: 4734
	private static readonly IntPtr NativeMethodInfoPtr_DisplayFriendProfileInfo_Private_Void_NetworkPlayerProfileInfo_0;

	// Token: 0x0400127F RID: 4735
	private static readonly IntPtr NativeMethodInfoPtr_ProcessFriendRequestReply_Private_Void_Int32_0;

	// Token: 0x04001280 RID: 4736
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000203 RID: 515
	[ObfuscatedName("UI_ProfileList+<ProcessDelayTime>d__61")]
	public sealed class _ProcessDelayTime_d__61 : global::Il2CppSystem.Object
	{
		// Token: 0x060028E6 RID: 10470 RVA: 0x00093AB0 File Offset: 0x00091CB0
		// Note: this type is marked as 'beforefieldinit'.
		static _ProcessDelayTime_d__61()
		{
			Il2CppClassPointerStore<UI_ProfileList._ProcessDelayTime_d__61>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_ProfileList>.NativeClassPtr, "<ProcessDelayTime>d__61");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_ProfileList._ProcessDelayTime_d__61>.NativeClassPtr);
			UI_ProfileList._ProcessDelayTime_d__61.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList._ProcessDelayTime_d__61>.NativeClassPtr, "<>1__state");
			UI_ProfileList._ProcessDelayTime_d__61.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList._ProcessDelayTime_d__61>.NativeClassPtr, "<>2__current");
			UI_ProfileList._ProcessDelayTime_d__61.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList._ProcessDelayTime_d__61>.NativeClassPtr, "<>4__this");
			UI_ProfileList._ProcessDelayTime_d__61.NativeFieldInfoPtr_totalDelayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList._ProcessDelayTime_d__61>.NativeClassPtr, "totalDelayTime");
			UI_ProfileList._ProcessDelayTime_d__61.NativeFieldInfoPtr__accumulatedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList._ProcessDelayTime_d__61>.NativeClassPtr, "<accumulatedTime>5__2");
			UI_ProfileList._ProcessDelayTime_d__61.NativeFieldInfoPtr__previousTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_ProfileList._ProcessDelayTime_d__61>.NativeClassPtr, "<previousTime>5__3");
			UI_ProfileList._ProcessDelayTime_d__61.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList._ProcessDelayTime_d__61>.NativeClassPtr, 100666510);
			UI_ProfileList._ProcessDelayTime_d__61.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList._ProcessDelayTime_d__61>.NativeClassPtr, 100666511);
			UI_ProfileList._ProcessDelayTime_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList._ProcessDelayTime_d__61>.NativeClassPtr, 100666512);
			UI_ProfileList._ProcessDelayTime_d__61.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList._ProcessDelayTime_d__61>.NativeClassPtr, 100666513);
			UI_ProfileList._ProcessDelayTime_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList._ProcessDelayTime_d__61>.NativeClassPtr, 100666514);
			UI_ProfileList._ProcessDelayTime_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_ProfileList._ProcessDelayTime_d__61>.NativeClassPtr, 100666515);
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x00093BCC File Offset: 0x00091DCC
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ProcessDelayTime_d__61(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_ProfileList._ProcessDelayTime_d__61>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList._ProcessDelayTime_d__61.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x00093C14 File Offset: 0x00091E14
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList._ProcessDelayTime_d__61.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x00093C48 File Offset: 0x00091E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252600, XrefRangeEnd = 252608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList._ProcessDelayTime_d__61.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x060028EA RID: 10474 RVA: 0x00093C84 File Offset: 0x00091E84
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList._ProcessDelayTime_d__61.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x00093CC4 File Offset: 0x00091EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252608, XrefRangeEnd = 252613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList._ProcessDelayTime_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x060028EC RID: 10476 RVA: 0x00093CF8 File Offset: 0x00091EF8
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_ProfileList._ProcessDelayTime_d__61.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x00019367 File Offset: 0x00017567
		public _ProcessDelayTime_d__61(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x060028EE RID: 10478 RVA: 0x00093D38 File Offset: 0x00091F38
		// (set) Token: 0x060028EF RID: 10479 RVA: 0x00019370 File Offset: 0x00017570
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList._ProcessDelayTime_d__61.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList._ProcessDelayTime_d__61.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x060028F0 RID: 10480 RVA: 0x00093D60 File Offset: 0x00091F60
		// (set) Token: 0x060028F1 RID: 10481 RVA: 0x0001938B File Offset: 0x0001758B
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList._ProcessDelayTime_d__61.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList._ProcessDelayTime_d__61.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x060028F2 RID: 10482 RVA: 0x00093D90 File Offset: 0x00091F90
		// (set) Token: 0x060028F3 RID: 10483 RVA: 0x000193AA File Offset: 0x000175AA
		public unsafe UI_ProfileList __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList._ProcessDelayTime_d__61.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_ProfileList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList._ProcessDelayTime_d__61.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x060028F4 RID: 10484 RVA: 0x00093DC0 File Offset: 0x00091FC0
		// (set) Token: 0x060028F5 RID: 10485 RVA: 0x000193C9 File Offset: 0x000175C9
		public unsafe float totalDelayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList._ProcessDelayTime_d__61.NativeFieldInfoPtr_totalDelayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList._ProcessDelayTime_d__61.NativeFieldInfoPtr_totalDelayTime)) = value;
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x060028F6 RID: 10486 RVA: 0x00093DE8 File Offset: 0x00091FE8
		// (set) Token: 0x060028F7 RID: 10487 RVA: 0x000193E4 File Offset: 0x000175E4
		public unsafe float _accumulatedTime_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList._ProcessDelayTime_d__61.NativeFieldInfoPtr__accumulatedTime_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList._ProcessDelayTime_d__61.NativeFieldInfoPtr__accumulatedTime_5__2)) = value;
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x060028F8 RID: 10488 RVA: 0x00093E10 File Offset: 0x00092010
		// (set) Token: 0x060028F9 RID: 10489 RVA: 0x000193FF File Offset: 0x000175FF
		public unsafe float _previousTime_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList._ProcessDelayTime_d__61.NativeFieldInfoPtr__previousTime_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_ProfileList._ProcessDelayTime_d__61.NativeFieldInfoPtr__previousTime_5__3)) = value;
			}
		}

		// Token: 0x04001C12 RID: 7186
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001C13 RID: 7187
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001C14 RID: 7188
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001C15 RID: 7189
		private static readonly IntPtr NativeFieldInfoPtr_totalDelayTime;

		// Token: 0x04001C16 RID: 7190
		private static readonly IntPtr NativeFieldInfoPtr__accumulatedTime_5__2;

		// Token: 0x04001C17 RID: 7191
		private static readonly IntPtr NativeFieldInfoPtr__previousTime_5__3;

		// Token: 0x04001C18 RID: 7192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001C19 RID: 7193
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001C1A RID: 7194
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001C1B RID: 7195
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001C1C RID: 7196
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001C1D RID: 7197
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

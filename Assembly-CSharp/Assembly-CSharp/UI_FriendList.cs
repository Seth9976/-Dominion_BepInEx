using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000CE RID: 206
public class UI_FriendList : UI_NetworkBase
{
	// Token: 0x060018B1 RID: 6321 RVA: 0x00064554 File Offset: 0x00062754
	// Note: this type is marked as 'beforefieldinit'.
	static UI_FriendList()
	{
		Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_FriendList");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr);
		UI_FriendList.NativeFieldInfoPtr_m_confirmPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_confirmPopup");
		UI_FriendList.NativeFieldInfoPtr_m_confirmPopupNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_confirmPopupNameText");
		UI_FriendList.NativeFieldInfoPtr_m_confirmPopupAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_confirmPopupAvatar");
		UI_FriendList.NativeFieldInfoPtr_m_localPlayerNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_localPlayerNameText");
		UI_FriendList.NativeFieldInfoPtr_m_localPlayerAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_localPlayerAvatar");
		UI_FriendList.NativeFieldInfoPtr_m_localPlayerSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_localPlayerSelected");
		UI_FriendList.NativeFieldInfoPtr_m_removeFriendButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_removeFriendButton");
		UI_FriendList.NativeFieldInfoPtr_m_leftStatsDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_leftStatsDisplay");
		UI_FriendList.NativeFieldInfoPtr_m_leftNoStatsDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_leftNoStatsDisplay");
		UI_FriendList.NativeFieldInfoPtr_m_leftNoStatsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_leftNoStatsText");
		UI_FriendList.NativeFieldInfoPtr_m_minDialogDisplayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_minDialogDisplayTime");
		UI_FriendList.NativeFieldInfoPtr_m_friendsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_friendsList");
		UI_FriendList.NativeFieldInfoPtr_m_nameRenamePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_nameRenamePopup");
		UI_FriendList.NativeFieldInfoPtr_m_nameRenameField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_nameRenameField");
		UI_FriendList.NativeFieldInfoPtr_m_emailField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_emailField");
		UI_FriendList.NativeFieldInfoPtr_m_nameRenameConfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_nameRenameConfirmButton");
		UI_FriendList.NativeFieldInfoPtr_m_activePlayerAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_activePlayerAvatar");
		UI_FriendList.NativeFieldInfoPtr_m_activePlayerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_activePlayerName");
		UI_FriendList.NativeFieldInfoPtr_m_activeProfileAvatarButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_activeProfileAvatarButton");
		UI_FriendList.NativeFieldInfoPtr_m_inProgressNumLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_inProgressNumLabel");
		UI_FriendList.NativeFieldInfoPtr_m_gamesCompletedNumLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_gamesCompletedNumLabel");
		UI_FriendList.NativeFieldInfoPtr_m_forfeitsNumLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_forfeitsNumLabel");
		UI_FriendList.NativeFieldInfoPtr_m_2pRecordNumLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_2pRecordNumLabel");
		UI_FriendList.NativeFieldInfoPtr_m_3pRecordNumLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_3pRecordNumLabel");
		UI_FriendList.NativeFieldInfoPtr_m_4pRecordNumLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_4pRecordNumLabel");
		UI_FriendList.NativeFieldInfoPtr_m_ratingNumLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_ratingNumLabel");
		UI_FriendList.NativeFieldInfoPtr_m_delayCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_delayCoroutine");
		UI_FriendList.NativeFieldInfoPtr_m_currentFriendDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_currentFriendDisplayName");
		UI_FriendList.NativeFieldInfoPtr_m_currentFriendDisplayedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_currentFriendDisplayedID");
		UI_FriendList.NativeFieldInfoPtr_m_requestedFriendId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_requestedFriendId");
		UI_FriendList.NativeFieldInfoPtr_m_processFriendRequestReplyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_processFriendRequestReplyData");
		UI_FriendList.NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_bMinDialogDisplayTimeReached");
		UI_FriendList.NativeFieldInfoPtr_m_bProcessFriendRequestReply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_bProcessFriendRequestReply");
		UI_FriendList.NativeFieldInfoPtr_m_bIgnoreToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_bIgnoreToggles");
		UI_FriendList.NativeFieldInfoPtr_m_bIgnoreNextEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "m_bIgnoreNextEnter");
		UI_FriendList.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665254);
		UI_FriendList.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665255);
		UI_FriendList.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665256);
		UI_FriendList.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665257);
		UI_FriendList.NativeMethodInfoPtr_OnAvatarConfirm_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665258);
		UI_FriendList.NativeMethodInfoPtr_OnAvatarButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665259);
		UI_FriendList.NativeMethodInfoPtr_AskToRemoveFriend_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665260);
		UI_FriendList.NativeMethodInfoPtr_OnAddFriendPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665261);
		UI_FriendList.NativeMethodInfoPtr_RemoveFriend_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665262);
		UI_FriendList.NativeMethodInfoPtr_Notified_Public_Virtual_Final_New_Void_PopupNotificationType_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665263);
		UI_FriendList.NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665264);
		UI_FriendList.NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665265);
		UI_FriendList.NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665266);
		UI_FriendList.NativeMethodInfoPtr_OnNameRenamePressed_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665267);
		UI_FriendList.NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665268);
		UI_FriendList.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_Profile_ClickEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665269);
		UI_FriendList.NativeMethodInfoPtr_RequestFriendProfile_Private_Void_FriendInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665270);
		UI_FriendList.NativeMethodInfoPtr_DisplayTopUserInfo_Private_Void_String_UInt16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665271);
		UI_FriendList.NativeMethodInfoPtr_HandleClickOnLocalPlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665272);
		UI_FriendList.NativeMethodInfoPtr_HandleUpdatedLocalPlayerProfile_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665273);
		UI_FriendList.NativeMethodInfoPtr_DisplayLocalPlayerProfile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665274);
		UI_FriendList.NativeMethodInfoPtr_DisplayFriendProfileInfo_Private_Void_NetworkPlayerProfileInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665275);
		UI_FriendList.NativeMethodInfoPtr_ProcessFriendRequestReply_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665276);
		UI_FriendList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, 100665277);
	}

	// Token: 0x060018B2 RID: 6322 RVA: 0x00064A20 File Offset: 0x00062C20
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060018B3 RID: 6323 RVA: 0x00064A54 File Offset: 0x00062C54
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249655, XrefRangeEnd = 249678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnterMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060018B4 RID: 6324 RVA: 0x00064A88 File Offset: 0x00062C88
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249678, XrefRangeEnd = 249680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExitMenu(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060018B5 RID: 6325 RVA: 0x00064AC8 File Offset: 0x00062CC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249680, XrefRangeEnd = 249698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060018B6 RID: 6326 RVA: 0x00064AFC File Offset: 0x00062CFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249698, XrefRangeEnd = 249706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAvatarConfirm(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_OnAvatarConfirm_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060018B7 RID: 6327 RVA: 0x00064B3C File Offset: 0x00062D3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249706, XrefRangeEnd = 249736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAvatarButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_OnAvatarButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060018B8 RID: 6328 RVA: 0x00064B70 File Offset: 0x00062D70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249736, XrefRangeEnd = 249744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AskToRemoveFriend()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_AskToRemoveFriend_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060018B9 RID: 6329 RVA: 0x00064BA4 File Offset: 0x00062DA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249744, XrefRangeEnd = 249754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAddFriendPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_OnAddFriendPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060018BA RID: 6330 RVA: 0x00064BD8 File Offset: 0x00062DD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249754, XrefRangeEnd = 249789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveFriend()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_RemoveFriend_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060018BB RID: 6331 RVA: 0x00064C0C File Offset: 0x00062E0C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249789, XrefRangeEnd = 249812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_Notified_Public_Virtual_Final_New_Void_PopupNotificationType_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060018BC RID: 6332 RVA: 0x00064C70 File Offset: 0x00062E70
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NetworkStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_FriendList.NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060018BD RID: 6333 RVA: 0x00064CAC File Offset: 0x00062EAC
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NetworkOnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_FriendList.NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060018BE RID: 6334 RVA: 0x00064CE8 File Offset: 0x00062EE8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249812, XrefRangeEnd = 249813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_FriendList.NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060018BF RID: 6335 RVA: 0x00064D40 File Offset: 0x00062F40
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnNameRenamePressed(bool bIsNewProfile)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bIsNewProfile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_OnNameRenamePressed_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060018C0 RID: 6336 RVA: 0x00064D80 File Offset: 0x00062F80
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 249817, RefRangeEnd = 249818, XrefRangeStart = 249813, XrefRangeEnd = 249817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ProcessDelayTime(float totalDelayTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref totalDelayTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x060018C1 RID: 6337 RVA: 0x00064DCC File Offset: 0x00062FCC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 249836, RefRangeEnd = 249837, XrefRangeStart = 249818, XrefRangeEnd = 249836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_Profile_ClickEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060018C2 RID: 6338 RVA: 0x00064E1C File Offset: 0x0006301C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249837, XrefRangeEnd = 249840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RequestFriendProfile(FriendInfo friendInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(friendInfo));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_RequestFriendProfile_Private_Void_FriendInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060018C3 RID: 6339 RVA: 0x00064E64 File Offset: 0x00063064
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_DisplayTopUserInfo_Private_Void_String_UInt16_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060018C4 RID: 6340 RVA: 0x00064EC8 File Offset: 0x000630C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249840, XrefRangeEnd = 249841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleClickOnLocalPlayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_HandleClickOnLocalPlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060018C5 RID: 6341 RVA: 0x00064EFC File Offset: 0x000630FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249841, XrefRangeEnd = 249842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleUpdatedLocalPlayerProfile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_HandleUpdatedLocalPlayerProfile_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060018C6 RID: 6342 RVA: 0x00064F30 File Offset: 0x00063130
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 249896, RefRangeEnd = 249900, XrefRangeStart = 249842, XrefRangeEnd = 249896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplayLocalPlayerProfile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_DisplayLocalPlayerProfile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060018C7 RID: 6343 RVA: 0x00064F64 File Offset: 0x00063164
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249900, XrefRangeEnd = 249934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplayFriendProfileInfo(NetworkPlayerProfileInfo profileInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profileInfo));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_DisplayFriendProfileInfo_Private_Void_NetworkPlayerProfileInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060018C8 RID: 6344 RVA: 0x00064FAC File Offset: 0x000631AC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 250000, RefRangeEnd = 250001, XrefRangeStart = 249934, XrefRangeEnd = 250000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessFriendRequestReply(int eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr_ProcessFriendRequestReply_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060018C9 RID: 6345 RVA: 0x00064FEC File Offset: 0x000631EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250001, XrefRangeEnd = 250005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_FriendList()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060018CA RID: 6346 RVA: 0x0000FE69 File Offset: 0x0000E069
	public UI_FriendList(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170007E0 RID: 2016
	// (get) Token: 0x060018CB RID: 6347 RVA: 0x00065028 File Offset: 0x00063228
	// (set) Token: 0x060018CC RID: 6348 RVA: 0x0000FE72 File Offset: 0x0000E072
	public unsafe GameObject m_confirmPopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_confirmPopup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_confirmPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007E1 RID: 2017
	// (get) Token: 0x060018CD RID: 6349 RVA: 0x00065058 File Offset: 0x00063258
	// (set) Token: 0x060018CE RID: 6350 RVA: 0x0000FE91 File Offset: 0x0000E091
	public unsafe TextMeshProUGUI m_confirmPopupNameText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_confirmPopupNameText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_confirmPopupNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007E2 RID: 2018
	// (get) Token: 0x060018CF RID: 6351 RVA: 0x00065088 File Offset: 0x00063288
	// (set) Token: 0x060018D0 RID: 6352 RVA: 0x0000FEB0 File Offset: 0x0000E0B0
	public unsafe Avatar_UI m_confirmPopupAvatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_confirmPopupAvatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_confirmPopupAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007E3 RID: 2019
	// (get) Token: 0x060018D1 RID: 6353 RVA: 0x000650B8 File Offset: 0x000632B8
	// (set) Token: 0x060018D2 RID: 6354 RVA: 0x0000FECF File Offset: 0x0000E0CF
	public unsafe TextMeshProUGUI m_localPlayerNameText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_localPlayerNameText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_localPlayerNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007E4 RID: 2020
	// (get) Token: 0x060018D3 RID: 6355 RVA: 0x000650E8 File Offset: 0x000632E8
	// (set) Token: 0x060018D4 RID: 6356 RVA: 0x0000FEEE File Offset: 0x0000E0EE
	public unsafe Avatar_UI m_localPlayerAvatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_localPlayerAvatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_localPlayerAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007E5 RID: 2021
	// (get) Token: 0x060018D5 RID: 6357 RVA: 0x00065118 File Offset: 0x00063318
	// (set) Token: 0x060018D6 RID: 6358 RVA: 0x0000FF0D File Offset: 0x0000E10D
	public unsafe GameObject m_localPlayerSelected
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_localPlayerSelected);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_localPlayerSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007E6 RID: 2022
	// (get) Token: 0x060018D7 RID: 6359 RVA: 0x00065148 File Offset: 0x00063348
	// (set) Token: 0x060018D8 RID: 6360 RVA: 0x0000FF2C File Offset: 0x0000E12C
	public unsafe GameObject m_removeFriendButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_removeFriendButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_removeFriendButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007E7 RID: 2023
	// (get) Token: 0x060018D9 RID: 6361 RVA: 0x00065178 File Offset: 0x00063378
	// (set) Token: 0x060018DA RID: 6362 RVA: 0x0000FF4B File Offset: 0x0000E14B
	public unsafe GameObject m_leftStatsDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_leftStatsDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_leftStatsDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007E8 RID: 2024
	// (get) Token: 0x060018DB RID: 6363 RVA: 0x000651A8 File Offset: 0x000633A8
	// (set) Token: 0x060018DC RID: 6364 RVA: 0x0000FF6A File Offset: 0x0000E16A
	public unsafe GameObject m_leftNoStatsDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_leftNoStatsDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_leftNoStatsDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007E9 RID: 2025
	// (get) Token: 0x060018DD RID: 6365 RVA: 0x000651D8 File Offset: 0x000633D8
	// (set) Token: 0x060018DE RID: 6366 RVA: 0x0000FF89 File Offset: 0x0000E189
	public unsafe TextMeshProUGUI m_leftNoStatsText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_leftNoStatsText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_leftNoStatsText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007EA RID: 2026
	// (get) Token: 0x060018DF RID: 6367 RVA: 0x00065208 File Offset: 0x00063408
	// (set) Token: 0x060018E0 RID: 6368 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
	public unsafe float m_minDialogDisplayTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_minDialogDisplayTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_minDialogDisplayTime)) = value;
		}
	}

	// Token: 0x170007EB RID: 2027
	// (get) Token: 0x060018E1 RID: 6369 RVA: 0x00065230 File Offset: 0x00063430
	// (set) Token: 0x060018E2 RID: 6370 RVA: 0x0000FFC3 File Offset: 0x0000E1C3
	public unsafe UIC_FriendsList m_friendsList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_friendsList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_FriendsList>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_friendsList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007EC RID: 2028
	// (get) Token: 0x060018E3 RID: 6371 RVA: 0x00065260 File Offset: 0x00063460
	// (set) Token: 0x060018E4 RID: 6372 RVA: 0x0000FFE2 File Offset: 0x0000E1E2
	public unsafe GameObject m_nameRenamePopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_nameRenamePopup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_nameRenamePopup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007ED RID: 2029
	// (get) Token: 0x060018E5 RID: 6373 RVA: 0x00065290 File Offset: 0x00063490
	// (set) Token: 0x060018E6 RID: 6374 RVA: 0x00010001 File Offset: 0x0000E201
	public unsafe TMP_InputField m_nameRenameField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_nameRenameField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_nameRenameField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007EE RID: 2030
	// (get) Token: 0x060018E7 RID: 6375 RVA: 0x000652C0 File Offset: 0x000634C0
	// (set) Token: 0x060018E8 RID: 6376 RVA: 0x00010020 File Offset: 0x0000E220
	public unsafe TMP_InputField m_emailField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_emailField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_emailField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007EF RID: 2031
	// (get) Token: 0x060018E9 RID: 6377 RVA: 0x000652F0 File Offset: 0x000634F0
	// (set) Token: 0x060018EA RID: 6378 RVA: 0x0001003F File Offset: 0x0000E23F
	public unsafe GameObject m_nameRenameConfirmButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_nameRenameConfirmButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_nameRenameConfirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007F0 RID: 2032
	// (get) Token: 0x060018EB RID: 6379 RVA: 0x00065320 File Offset: 0x00063520
	// (set) Token: 0x060018EC RID: 6380 RVA: 0x0001005E File Offset: 0x0000E25E
	public unsafe Avatar_UI m_activePlayerAvatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_activePlayerAvatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_activePlayerAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007F1 RID: 2033
	// (get) Token: 0x060018ED RID: 6381 RVA: 0x00065350 File Offset: 0x00063550
	// (set) Token: 0x060018EE RID: 6382 RVA: 0x0001007D File Offset: 0x0000E27D
	public unsafe TextMeshProUGUI m_activePlayerName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_activePlayerName);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_activePlayerName), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007F2 RID: 2034
	// (get) Token: 0x060018EF RID: 6383 RVA: 0x00065380 File Offset: 0x00063580
	// (set) Token: 0x060018F0 RID: 6384 RVA: 0x0001009C File Offset: 0x0000E29C
	public unsafe Button m_activeProfileAvatarButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_activeProfileAvatarButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_activeProfileAvatarButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007F3 RID: 2035
	// (get) Token: 0x060018F1 RID: 6385 RVA: 0x000653B0 File Offset: 0x000635B0
	// (set) Token: 0x060018F2 RID: 6386 RVA: 0x000100BB File Offset: 0x0000E2BB
	public unsafe TextMeshProUGUI m_inProgressNumLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_inProgressNumLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_inProgressNumLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007F4 RID: 2036
	// (get) Token: 0x060018F3 RID: 6387 RVA: 0x000653E0 File Offset: 0x000635E0
	// (set) Token: 0x060018F4 RID: 6388 RVA: 0x000100DA File Offset: 0x0000E2DA
	public unsafe TextMeshProUGUI m_gamesCompletedNumLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_gamesCompletedNumLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_gamesCompletedNumLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007F5 RID: 2037
	// (get) Token: 0x060018F5 RID: 6389 RVA: 0x00065410 File Offset: 0x00063610
	// (set) Token: 0x060018F6 RID: 6390 RVA: 0x000100F9 File Offset: 0x0000E2F9
	public unsafe TextMeshProUGUI m_forfeitsNumLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_forfeitsNumLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_forfeitsNumLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007F6 RID: 2038
	// (get) Token: 0x060018F7 RID: 6391 RVA: 0x00065440 File Offset: 0x00063640
	// (set) Token: 0x060018F8 RID: 6392 RVA: 0x00010118 File Offset: 0x0000E318
	public unsafe TextMeshProUGUI m_2pRecordNumLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_2pRecordNumLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_2pRecordNumLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007F7 RID: 2039
	// (get) Token: 0x060018F9 RID: 6393 RVA: 0x00065470 File Offset: 0x00063670
	// (set) Token: 0x060018FA RID: 6394 RVA: 0x00010137 File Offset: 0x0000E337
	public unsafe TextMeshProUGUI m_3pRecordNumLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_3pRecordNumLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_3pRecordNumLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007F8 RID: 2040
	// (get) Token: 0x060018FB RID: 6395 RVA: 0x000654A0 File Offset: 0x000636A0
	// (set) Token: 0x060018FC RID: 6396 RVA: 0x00010156 File Offset: 0x0000E356
	public unsafe TextMeshProUGUI m_4pRecordNumLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_4pRecordNumLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_4pRecordNumLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007F9 RID: 2041
	// (get) Token: 0x060018FD RID: 6397 RVA: 0x000654D0 File Offset: 0x000636D0
	// (set) Token: 0x060018FE RID: 6398 RVA: 0x00010175 File Offset: 0x0000E375
	public unsafe TextMeshProUGUI m_ratingNumLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_ratingNumLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_ratingNumLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007FA RID: 2042
	// (get) Token: 0x060018FF RID: 6399 RVA: 0x00065500 File Offset: 0x00063700
	// (set) Token: 0x06001900 RID: 6400 RVA: 0x00010194 File Offset: 0x0000E394
	public unsafe Coroutine m_delayCoroutine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_delayCoroutine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_delayCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007FB RID: 2043
	// (get) Token: 0x06001901 RID: 6401 RVA: 0x00065530 File Offset: 0x00063730
	// (set) Token: 0x06001902 RID: 6402 RVA: 0x000101B3 File Offset: 0x0000E3B3
	public unsafe string m_currentFriendDisplayName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_currentFriendDisplayName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_currentFriendDisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170007FC RID: 2044
	// (get) Token: 0x06001903 RID: 6403 RVA: 0x00065558 File Offset: 0x00063758
	// (set) Token: 0x06001904 RID: 6404 RVA: 0x000101D2 File Offset: 0x0000E3D2
	public unsafe uint m_currentFriendDisplayedID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_currentFriendDisplayedID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_currentFriendDisplayedID)) = value;
		}
	}

	// Token: 0x170007FD RID: 2045
	// (get) Token: 0x06001905 RID: 6405 RVA: 0x00065580 File Offset: 0x00063780
	// (set) Token: 0x06001906 RID: 6406 RVA: 0x000101ED File Offset: 0x0000E3ED
	public unsafe uint m_requestedFriendId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_requestedFriendId);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_requestedFriendId)) = value;
		}
	}

	// Token: 0x170007FE RID: 2046
	// (get) Token: 0x06001907 RID: 6407 RVA: 0x000655A8 File Offset: 0x000637A8
	// (set) Token: 0x06001908 RID: 6408 RVA: 0x00010208 File Offset: 0x0000E408
	public unsafe int m_processFriendRequestReplyData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_processFriendRequestReplyData);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_processFriendRequestReplyData)) = value;
		}
	}

	// Token: 0x170007FF RID: 2047
	// (get) Token: 0x06001909 RID: 6409 RVA: 0x000655D0 File Offset: 0x000637D0
	// (set) Token: 0x0600190A RID: 6410 RVA: 0x00010223 File Offset: 0x0000E423
	public unsafe bool m_bMinDialogDisplayTimeReached
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached)) = value;
		}
	}

	// Token: 0x17000800 RID: 2048
	// (get) Token: 0x0600190B RID: 6411 RVA: 0x000655F8 File Offset: 0x000637F8
	// (set) Token: 0x0600190C RID: 6412 RVA: 0x0001023E File Offset: 0x0000E43E
	public unsafe bool m_bProcessFriendRequestReply
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_bProcessFriendRequestReply);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_bProcessFriendRequestReply)) = value;
		}
	}

	// Token: 0x17000801 RID: 2049
	// (get) Token: 0x0600190D RID: 6413 RVA: 0x00065620 File Offset: 0x00063820
	// (set) Token: 0x0600190E RID: 6414 RVA: 0x00010259 File Offset: 0x0000E459
	public unsafe bool m_bIgnoreToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_bIgnoreToggles);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_bIgnoreToggles)) = value;
		}
	}

	// Token: 0x17000802 RID: 2050
	// (get) Token: 0x0600190F RID: 6415 RVA: 0x00065648 File Offset: 0x00063848
	// (set) Token: 0x06001910 RID: 6416 RVA: 0x00010274 File Offset: 0x0000E474
	public unsafe bool m_bIgnoreNextEnter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_bIgnoreNextEnter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList.NativeFieldInfoPtr_m_bIgnoreNextEnter)) = value;
		}
	}

	// Token: 0x040010D8 RID: 4312
	private static readonly IntPtr NativeFieldInfoPtr_m_confirmPopup;

	// Token: 0x040010D9 RID: 4313
	private static readonly IntPtr NativeFieldInfoPtr_m_confirmPopupNameText;

	// Token: 0x040010DA RID: 4314
	private static readonly IntPtr NativeFieldInfoPtr_m_confirmPopupAvatar;

	// Token: 0x040010DB RID: 4315
	private static readonly IntPtr NativeFieldInfoPtr_m_localPlayerNameText;

	// Token: 0x040010DC RID: 4316
	private static readonly IntPtr NativeFieldInfoPtr_m_localPlayerAvatar;

	// Token: 0x040010DD RID: 4317
	private static readonly IntPtr NativeFieldInfoPtr_m_localPlayerSelected;

	// Token: 0x040010DE RID: 4318
	private static readonly IntPtr NativeFieldInfoPtr_m_removeFriendButton;

	// Token: 0x040010DF RID: 4319
	private static readonly IntPtr NativeFieldInfoPtr_m_leftStatsDisplay;

	// Token: 0x040010E0 RID: 4320
	private static readonly IntPtr NativeFieldInfoPtr_m_leftNoStatsDisplay;

	// Token: 0x040010E1 RID: 4321
	private static readonly IntPtr NativeFieldInfoPtr_m_leftNoStatsText;

	// Token: 0x040010E2 RID: 4322
	private static readonly IntPtr NativeFieldInfoPtr_m_minDialogDisplayTime;

	// Token: 0x040010E3 RID: 4323
	private static readonly IntPtr NativeFieldInfoPtr_m_friendsList;

	// Token: 0x040010E4 RID: 4324
	private static readonly IntPtr NativeFieldInfoPtr_m_nameRenamePopup;

	// Token: 0x040010E5 RID: 4325
	private static readonly IntPtr NativeFieldInfoPtr_m_nameRenameField;

	// Token: 0x040010E6 RID: 4326
	private static readonly IntPtr NativeFieldInfoPtr_m_emailField;

	// Token: 0x040010E7 RID: 4327
	private static readonly IntPtr NativeFieldInfoPtr_m_nameRenameConfirmButton;

	// Token: 0x040010E8 RID: 4328
	private static readonly IntPtr NativeFieldInfoPtr_m_activePlayerAvatar;

	// Token: 0x040010E9 RID: 4329
	private static readonly IntPtr NativeFieldInfoPtr_m_activePlayerName;

	// Token: 0x040010EA RID: 4330
	private static readonly IntPtr NativeFieldInfoPtr_m_activeProfileAvatarButton;

	// Token: 0x040010EB RID: 4331
	private static readonly IntPtr NativeFieldInfoPtr_m_inProgressNumLabel;

	// Token: 0x040010EC RID: 4332
	private static readonly IntPtr NativeFieldInfoPtr_m_gamesCompletedNumLabel;

	// Token: 0x040010ED RID: 4333
	private static readonly IntPtr NativeFieldInfoPtr_m_forfeitsNumLabel;

	// Token: 0x040010EE RID: 4334
	private static readonly IntPtr NativeFieldInfoPtr_m_2pRecordNumLabel;

	// Token: 0x040010EF RID: 4335
	private static readonly IntPtr NativeFieldInfoPtr_m_3pRecordNumLabel;

	// Token: 0x040010F0 RID: 4336
	private static readonly IntPtr NativeFieldInfoPtr_m_4pRecordNumLabel;

	// Token: 0x040010F1 RID: 4337
	private static readonly IntPtr NativeFieldInfoPtr_m_ratingNumLabel;

	// Token: 0x040010F2 RID: 4338
	private static readonly IntPtr NativeFieldInfoPtr_m_delayCoroutine;

	// Token: 0x040010F3 RID: 4339
	private static readonly IntPtr NativeFieldInfoPtr_m_currentFriendDisplayName;

	// Token: 0x040010F4 RID: 4340
	private static readonly IntPtr NativeFieldInfoPtr_m_currentFriendDisplayedID;

	// Token: 0x040010F5 RID: 4341
	private static readonly IntPtr NativeFieldInfoPtr_m_requestedFriendId;

	// Token: 0x040010F6 RID: 4342
	private static readonly IntPtr NativeFieldInfoPtr_m_processFriendRequestReplyData;

	// Token: 0x040010F7 RID: 4343
	private static readonly IntPtr NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached;

	// Token: 0x040010F8 RID: 4344
	private static readonly IntPtr NativeFieldInfoPtr_m_bProcessFriendRequestReply;

	// Token: 0x040010F9 RID: 4345
	private static readonly IntPtr NativeFieldInfoPtr_m_bIgnoreToggles;

	// Token: 0x040010FA RID: 4346
	private static readonly IntPtr NativeFieldInfoPtr_m_bIgnoreNextEnter;

	// Token: 0x040010FB RID: 4347
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040010FC RID: 4348
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterMenu_Public_Void_0;

	// Token: 0x040010FD RID: 4349
	private static readonly IntPtr NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0;

	// Token: 0x040010FE RID: 4350
	private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

	// Token: 0x040010FF RID: 4351
	private static readonly IntPtr NativeMethodInfoPtr_OnAvatarConfirm_Public_Void_Int32_0;

	// Token: 0x04001100 RID: 4352
	private static readonly IntPtr NativeMethodInfoPtr_OnAvatarButtonPressed_Public_Void_0;

	// Token: 0x04001101 RID: 4353
	private static readonly IntPtr NativeMethodInfoPtr_AskToRemoveFriend_Public_Void_0;

	// Token: 0x04001102 RID: 4354
	private static readonly IntPtr NativeMethodInfoPtr_OnAddFriendPressed_Public_Void_0;

	// Token: 0x04001103 RID: 4355
	private static readonly IntPtr NativeMethodInfoPtr_RemoveFriend_Public_Void_0;

	// Token: 0x04001104 RID: 4356
	private static readonly IntPtr NativeMethodInfoPtr_Notified_Public_Virtual_Final_New_Void_PopupNotificationType_String_Object_0;

	// Token: 0x04001105 RID: 4357
	private static readonly IntPtr NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0;

	// Token: 0x04001106 RID: 4358
	private static readonly IntPtr NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0;

	// Token: 0x04001107 RID: 4359
	private static readonly IntPtr NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0;

	// Token: 0x04001108 RID: 4360
	private static readonly IntPtr NativeMethodInfoPtr_OnNameRenamePressed_Private_Void_Boolean_0;

	// Token: 0x04001109 RID: 4361
	private static readonly IntPtr NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0;

	// Token: 0x0400110A RID: 4362
	private static readonly IntPtr NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_Profile_ClickEventType_0;

	// Token: 0x0400110B RID: 4363
	private static readonly IntPtr NativeMethodInfoPtr_RequestFriendProfile_Private_Void_FriendInfo_0;

	// Token: 0x0400110C RID: 4364
	private static readonly IntPtr NativeMethodInfoPtr_DisplayTopUserInfo_Private_Void_String_UInt16_String_0;

	// Token: 0x0400110D RID: 4365
	private static readonly IntPtr NativeMethodInfoPtr_HandleClickOnLocalPlayer_Public_Void_0;

	// Token: 0x0400110E RID: 4366
	private static readonly IntPtr NativeMethodInfoPtr_HandleUpdatedLocalPlayerProfile_Private_Void_0;

	// Token: 0x0400110F RID: 4367
	private static readonly IntPtr NativeMethodInfoPtr_DisplayLocalPlayerProfile_Public_Void_0;

	// Token: 0x04001110 RID: 4368
	private static readonly IntPtr NativeMethodInfoPtr_DisplayFriendProfileInfo_Private_Void_NetworkPlayerProfileInfo_0;

	// Token: 0x04001111 RID: 4369
	private static readonly IntPtr NativeMethodInfoPtr_ProcessFriendRequestReply_Private_Void_Int32_0;

	// Token: 0x04001112 RID: 4370
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001F2 RID: 498
	[ObfuscatedName("UI_FriendList+<ProcessDelayTime>d__49")]
	public sealed class _ProcessDelayTime_d__49 : global::Il2CppSystem.Object
	{
		// Token: 0x060027E2 RID: 10210 RVA: 0x00090F9C File Offset: 0x0008F19C
		// Note: this type is marked as 'beforefieldinit'.
		static _ProcessDelayTime_d__49()
		{
			Il2CppClassPointerStore<UI_FriendList._ProcessDelayTime_d__49>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_FriendList>.NativeClassPtr, "<ProcessDelayTime>d__49");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_FriendList._ProcessDelayTime_d__49>.NativeClassPtr);
			UI_FriendList._ProcessDelayTime_d__49.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList._ProcessDelayTime_d__49>.NativeClassPtr, "<>1__state");
			UI_FriendList._ProcessDelayTime_d__49.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList._ProcessDelayTime_d__49>.NativeClassPtr, "<>2__current");
			UI_FriendList._ProcessDelayTime_d__49.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList._ProcessDelayTime_d__49>.NativeClassPtr, "<>4__this");
			UI_FriendList._ProcessDelayTime_d__49.NativeFieldInfoPtr_totalDelayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList._ProcessDelayTime_d__49>.NativeClassPtr, "totalDelayTime");
			UI_FriendList._ProcessDelayTime_d__49.NativeFieldInfoPtr__accumulatedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList._ProcessDelayTime_d__49>.NativeClassPtr, "<accumulatedTime>5__2");
			UI_FriendList._ProcessDelayTime_d__49.NativeFieldInfoPtr__previousTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_FriendList._ProcessDelayTime_d__49>.NativeClassPtr, "<previousTime>5__3");
			UI_FriendList._ProcessDelayTime_d__49.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList._ProcessDelayTime_d__49>.NativeClassPtr, 100666444);
			UI_FriendList._ProcessDelayTime_d__49.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList._ProcessDelayTime_d__49>.NativeClassPtr, 100666445);
			UI_FriendList._ProcessDelayTime_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList._ProcessDelayTime_d__49>.NativeClassPtr, 100666446);
			UI_FriendList._ProcessDelayTime_d__49.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList._ProcessDelayTime_d__49>.NativeClassPtr, 100666447);
			UI_FriendList._ProcessDelayTime_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList._ProcessDelayTime_d__49>.NativeClassPtr, 100666448);
			UI_FriendList._ProcessDelayTime_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_FriendList._ProcessDelayTime_d__49>.NativeClassPtr, 100666449);
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x000910B8 File Offset: 0x0008F2B8
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ProcessDelayTime_d__49(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_FriendList._ProcessDelayTime_d__49>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList._ProcessDelayTime_d__49.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x00091100 File Offset: 0x0008F300
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList._ProcessDelayTime_d__49.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x00091134 File Offset: 0x0008F334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249642, XrefRangeEnd = 249650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList._ProcessDelayTime_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x060027E6 RID: 10214 RVA: 0x00091170 File Offset: 0x0008F370
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList._ProcessDelayTime_d__49.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x000911B0 File Offset: 0x0008F3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249650, XrefRangeEnd = 249655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList._ProcessDelayTime_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x060027E8 RID: 10216 RVA: 0x000911E4 File Offset: 0x0008F3E4
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_FriendList._ProcessDelayTime_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x00018993 File Offset: 0x00016B93
		public _ProcessDelayTime_d__49(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x060027EA RID: 10218 RVA: 0x00091224 File Offset: 0x0008F424
		// (set) Token: 0x060027EB RID: 10219 RVA: 0x0001899C File Offset: 0x00016B9C
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList._ProcessDelayTime_d__49.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList._ProcessDelayTime_d__49.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x060027EC RID: 10220 RVA: 0x0009124C File Offset: 0x0008F44C
		// (set) Token: 0x060027ED RID: 10221 RVA: 0x000189B7 File Offset: 0x00016BB7
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList._ProcessDelayTime_d__49.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList._ProcessDelayTime_d__49.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x060027EE RID: 10222 RVA: 0x0009127C File Offset: 0x0008F47C
		// (set) Token: 0x060027EF RID: 10223 RVA: 0x000189D6 File Offset: 0x00016BD6
		public unsafe UI_FriendList __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList._ProcessDelayTime_d__49.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_FriendList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList._ProcessDelayTime_d__49.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x060027F0 RID: 10224 RVA: 0x000912AC File Offset: 0x0008F4AC
		// (set) Token: 0x060027F1 RID: 10225 RVA: 0x000189F5 File Offset: 0x00016BF5
		public unsafe float totalDelayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList._ProcessDelayTime_d__49.NativeFieldInfoPtr_totalDelayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList._ProcessDelayTime_d__49.NativeFieldInfoPtr_totalDelayTime)) = value;
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x060027F2 RID: 10226 RVA: 0x000912D4 File Offset: 0x0008F4D4
		// (set) Token: 0x060027F3 RID: 10227 RVA: 0x00018A10 File Offset: 0x00016C10
		public unsafe float _accumulatedTime_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList._ProcessDelayTime_d__49.NativeFieldInfoPtr__accumulatedTime_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList._ProcessDelayTime_d__49.NativeFieldInfoPtr__accumulatedTime_5__2)) = value;
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x060027F4 RID: 10228 RVA: 0x000912FC File Offset: 0x0008F4FC
		// (set) Token: 0x060027F5 RID: 10229 RVA: 0x00018A2B File Offset: 0x00016C2B
		public unsafe float _previousTime_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList._ProcessDelayTime_d__49.NativeFieldInfoPtr__previousTime_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_FriendList._ProcessDelayTime_d__49.NativeFieldInfoPtr__previousTime_5__3)) = value;
			}
		}

		// Token: 0x04001B83 RID: 7043
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001B84 RID: 7044
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001B85 RID: 7045
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001B86 RID: 7046
		private static readonly IntPtr NativeFieldInfoPtr_totalDelayTime;

		// Token: 0x04001B87 RID: 7047
		private static readonly IntPtr NativeFieldInfoPtr__accumulatedTime_5__2;

		// Token: 0x04001B88 RID: 7048
		private static readonly IntPtr NativeFieldInfoPtr__previousTime_5__3;

		// Token: 0x04001B89 RID: 7049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001B8A RID: 7050
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B8B RID: 7051
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001B8C RID: 7052
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001B8D RID: 7053
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001B8E RID: 7054
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000BB RID: 187
public class UIP_ProfilePopup : UI_NetworkBase
{
	// Token: 0x06001689 RID: 5769 RVA: 0x0005E350 File Offset: 0x0005C550
	// Note: this type is marked as 'beforefieldinit'.
	static UIP_ProfilePopup()
	{
		Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIP_ProfilePopup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr);
		UIP_ProfilePopup.NativeFieldInfoPtr_m_messagePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_messagePopup");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_messagePopupCancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_messagePopupCancelButton");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_messagePopupText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_messagePopupText");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_minDialogDisplayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_minDialogDisplayTime");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_addRemoveFriendButtonBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_addRemoveFriendButtonBase");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_addRemoveFriendButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_addRemoveFriendButtonText");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_displayNameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_displayNameLabel");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_ratingNumLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_ratingNumLabel");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_gamesCompletedNumLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_gamesCompletedNumLabel");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_forfeitsNumLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_forfeitsNumLabel");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_inProgressNumLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_inProgressNumLabel");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_2PlayerRecordLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_2PlayerRecordLabel");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_3PlayerRecordLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_3PlayerRecordLabel");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_4PlayerRecordLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_4PlayerRecordLabel");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_5PlayerRecordLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_5PlayerRecordLabel");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_6PlayerRecordLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_6PlayerRecordLabel");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_avatar");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_addRemoveFriendPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_addRemoveFriendPopup");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_addRemoveFriendText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_addRemoveFriendText");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_addRemoveFriendName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_addRemoveFriendName");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_addRemoveFriendAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_addRemoveFriendAvatar");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_bDisplayingFriend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_bDisplayingFriend");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_bDisplayingLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_bDisplayingLocal");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_requestedFriendId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_requestedFriendId");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_processFriendRequestReplyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_processFriendRequestReplyData");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_bMinDialogDisplayTimeReached");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_bProcessFriendRequestReply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_bProcessFriendRequestReply");
		UIP_ProfilePopup.NativeFieldInfoPtr_m_delayCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "m_delayCoroutine");
		UIP_ProfilePopup.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, 100665102);
		UIP_ProfilePopup.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, 100665103);
		UIP_ProfilePopup.NativeMethodInfoPtr_DisplayPlayerProfile_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, 100665104);
		UIP_ProfilePopup.NativeMethodInfoPtr_OnExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, 100665105);
		UIP_ProfilePopup.NativeMethodInfoPtr_GetIsFriend_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, 100665106);
		UIP_ProfilePopup.NativeMethodInfoPtr_FriendButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, 100665107);
		UIP_ProfilePopup.NativeMethodInfoPtr_FriendButtonClickedConfirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, 100665108);
		UIP_ProfilePopup.NativeMethodInfoPtr_ProcessFriendRequestReply_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, 100665109);
		UIP_ProfilePopup.NativeMethodInfoPtr_DisplayProfileInfo_Private_Void_NetworkPlayerProfileInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, 100665110);
		UIP_ProfilePopup.NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, 100665111);
		UIP_ProfilePopup.NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, 100665112);
		UIP_ProfilePopup.NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, 100665113);
		UIP_ProfilePopup.NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, 100665114);
		UIP_ProfilePopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, 100665115);
	}

	// Token: 0x0600168A RID: 5770 RVA: 0x0005E6C8 File Offset: 0x0005C8C8
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ProfilePopup.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600168B RID: 5771 RVA: 0x0005E6FC File Offset: 0x0005C8FC
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ProfilePopup.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600168C RID: 5772 RVA: 0x0005E730 File Offset: 0x0005C930
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 247804, RefRangeEnd = 247807, XrefRangeStart = 247786, XrefRangeEnd = 247804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplayPlayerProfile(uint userID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref userID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ProfilePopup.NativeMethodInfoPtr_DisplayPlayerProfile_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600168D RID: 5773 RVA: 0x0005E770 File Offset: 0x0005C970
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247807, XrefRangeEnd = 247808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ProfilePopup.NativeMethodInfoPtr_OnExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600168E RID: 5774 RVA: 0x0005E7A4 File Offset: 0x0005C9A4
	[CallerCount(0)]
	public unsafe bool GetIsFriend()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ProfilePopup.NativeMethodInfoPtr_GetIsFriend_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600168F RID: 5775 RVA: 0x0005E7E0 File Offset: 0x0005C9E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247808, XrefRangeEnd = 247819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FriendButtonClicked()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ProfilePopup.NativeMethodInfoPtr_FriendButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001690 RID: 5776 RVA: 0x0005E814 File Offset: 0x0005CA14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247819, XrefRangeEnd = 247824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FriendButtonClickedConfirm()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ProfilePopup.NativeMethodInfoPtr_FriendButtonClickedConfirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001691 RID: 5777 RVA: 0x0005E848 File Offset: 0x0005CA48
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 247846, RefRangeEnd = 247849, XrefRangeStart = 247824, XrefRangeEnd = 247846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessFriendRequestReply(int eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ProfilePopup.NativeMethodInfoPtr_ProcessFriendRequestReply_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001692 RID: 5778 RVA: 0x0005E888 File Offset: 0x0005CA88
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 247886, RefRangeEnd = 247887, XrefRangeStart = 247849, XrefRangeEnd = 247886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplayProfileInfo(NetworkPlayerProfileInfo profileInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(profileInfo));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ProfilePopup.NativeMethodInfoPtr_DisplayProfileInfo_Private_Void_NetworkPlayerProfileInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001693 RID: 5779 RVA: 0x0005E8D0 File Offset: 0x0005CAD0
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NetworkStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIP_ProfilePopup.NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001694 RID: 5780 RVA: 0x0005E90C File Offset: 0x0005CB0C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NetworkOnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIP_ProfilePopup.NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001695 RID: 5781 RVA: 0x0005E948 File Offset: 0x0005CB48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247887, XrefRangeEnd = 247893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIP_ProfilePopup.NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001696 RID: 5782 RVA: 0x0005E9A0 File Offset: 0x0005CBA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247893, XrefRangeEnd = 247897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ProcessDelayTime(float totalDelayTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref totalDelayTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ProfilePopup.NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x06001697 RID: 5783 RVA: 0x0005E9EC File Offset: 0x0005CBEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247897, XrefRangeEnd = 247901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIP_ProfilePopup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ProfilePopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001698 RID: 5784 RVA: 0x0000E8F7 File Offset: 0x0000CAF7
	public UIP_ProfilePopup(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000727 RID: 1831
	// (get) Token: 0x06001699 RID: 5785 RVA: 0x0005EA28 File Offset: 0x0005CC28
	// (set) Token: 0x0600169A RID: 5786 RVA: 0x0000E900 File Offset: 0x0000CB00
	public unsafe GameObject m_messagePopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_messagePopup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_messagePopup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000728 RID: 1832
	// (get) Token: 0x0600169B RID: 5787 RVA: 0x0005EA58 File Offset: 0x0005CC58
	// (set) Token: 0x0600169C RID: 5788 RVA: 0x0000E91F File Offset: 0x0000CB1F
	public unsafe GameObject m_messagePopupCancelButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_messagePopupCancelButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_messagePopupCancelButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000729 RID: 1833
	// (get) Token: 0x0600169D RID: 5789 RVA: 0x0005EA88 File Offset: 0x0005CC88
	// (set) Token: 0x0600169E RID: 5790 RVA: 0x0000E93E File Offset: 0x0000CB3E
	public unsafe Text m_messagePopupText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_messagePopupText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_messagePopupText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700072A RID: 1834
	// (get) Token: 0x0600169F RID: 5791 RVA: 0x0005EAB8 File Offset: 0x0005CCB8
	// (set) Token: 0x060016A0 RID: 5792 RVA: 0x0000E95D File Offset: 0x0000CB5D
	public unsafe float m_minDialogDisplayTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_minDialogDisplayTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_minDialogDisplayTime)) = value;
		}
	}

	// Token: 0x1700072B RID: 1835
	// (get) Token: 0x060016A1 RID: 5793 RVA: 0x0005EAE0 File Offset: 0x0005CCE0
	// (set) Token: 0x060016A2 RID: 5794 RVA: 0x0000E978 File Offset: 0x0000CB78
	public unsafe GameObject m_addRemoveFriendButtonBase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_addRemoveFriendButtonBase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_addRemoveFriendButtonBase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700072C RID: 1836
	// (get) Token: 0x060016A3 RID: 5795 RVA: 0x0005EB10 File Offset: 0x0005CD10
	// (set) Token: 0x060016A4 RID: 5796 RVA: 0x0000E997 File Offset: 0x0000CB97
	public unsafe Text m_addRemoveFriendButtonText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_addRemoveFriendButtonText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_addRemoveFriendButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700072D RID: 1837
	// (get) Token: 0x060016A5 RID: 5797 RVA: 0x0005EB40 File Offset: 0x0005CD40
	// (set) Token: 0x060016A6 RID: 5798 RVA: 0x0000E9B6 File Offset: 0x0000CBB6
	public unsafe Text m_displayNameLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_displayNameLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_displayNameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700072E RID: 1838
	// (get) Token: 0x060016A7 RID: 5799 RVA: 0x0005EB70 File Offset: 0x0005CD70
	// (set) Token: 0x060016A8 RID: 5800 RVA: 0x0000E9D5 File Offset: 0x0000CBD5
	public unsafe Text m_ratingNumLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_ratingNumLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_ratingNumLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700072F RID: 1839
	// (get) Token: 0x060016A9 RID: 5801 RVA: 0x0005EBA0 File Offset: 0x0005CDA0
	// (set) Token: 0x060016AA RID: 5802 RVA: 0x0000E9F4 File Offset: 0x0000CBF4
	public unsafe Text m_gamesCompletedNumLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_gamesCompletedNumLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_gamesCompletedNumLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000730 RID: 1840
	// (get) Token: 0x060016AB RID: 5803 RVA: 0x0005EBD0 File Offset: 0x0005CDD0
	// (set) Token: 0x060016AC RID: 5804 RVA: 0x0000EA13 File Offset: 0x0000CC13
	public unsafe Text m_forfeitsNumLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_forfeitsNumLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_forfeitsNumLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000731 RID: 1841
	// (get) Token: 0x060016AD RID: 5805 RVA: 0x0005EC00 File Offset: 0x0005CE00
	// (set) Token: 0x060016AE RID: 5806 RVA: 0x0000EA32 File Offset: 0x0000CC32
	public unsafe Text m_inProgressNumLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_inProgressNumLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_inProgressNumLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000732 RID: 1842
	// (get) Token: 0x060016AF RID: 5807 RVA: 0x0005EC30 File Offset: 0x0005CE30
	// (set) Token: 0x060016B0 RID: 5808 RVA: 0x0000EA51 File Offset: 0x0000CC51
	public unsafe Text m_2PlayerRecordLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_2PlayerRecordLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_2PlayerRecordLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000733 RID: 1843
	// (get) Token: 0x060016B1 RID: 5809 RVA: 0x0005EC60 File Offset: 0x0005CE60
	// (set) Token: 0x060016B2 RID: 5810 RVA: 0x0000EA70 File Offset: 0x0000CC70
	public unsafe Text m_3PlayerRecordLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_3PlayerRecordLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_3PlayerRecordLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000734 RID: 1844
	// (get) Token: 0x060016B3 RID: 5811 RVA: 0x0005EC90 File Offset: 0x0005CE90
	// (set) Token: 0x060016B4 RID: 5812 RVA: 0x0000EA8F File Offset: 0x0000CC8F
	public unsafe Text m_4PlayerRecordLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_4PlayerRecordLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_4PlayerRecordLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000735 RID: 1845
	// (get) Token: 0x060016B5 RID: 5813 RVA: 0x0005ECC0 File Offset: 0x0005CEC0
	// (set) Token: 0x060016B6 RID: 5814 RVA: 0x0000EAAE File Offset: 0x0000CCAE
	public unsafe Text m_5PlayerRecordLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_5PlayerRecordLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_5PlayerRecordLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000736 RID: 1846
	// (get) Token: 0x060016B7 RID: 5815 RVA: 0x0005ECF0 File Offset: 0x0005CEF0
	// (set) Token: 0x060016B8 RID: 5816 RVA: 0x0000EACD File Offset: 0x0000CCCD
	public unsafe Text m_6PlayerRecordLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_6PlayerRecordLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_6PlayerRecordLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000737 RID: 1847
	// (get) Token: 0x060016B9 RID: 5817 RVA: 0x0005ED20 File Offset: 0x0005CF20
	// (set) Token: 0x060016BA RID: 5818 RVA: 0x0000EAEC File Offset: 0x0000CCEC
	public unsafe Avatar_UI m_avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000738 RID: 1848
	// (get) Token: 0x060016BB RID: 5819 RVA: 0x0005ED50 File Offset: 0x0005CF50
	// (set) Token: 0x060016BC RID: 5820 RVA: 0x0000EB0B File Offset: 0x0000CD0B
	public unsafe GameObject m_addRemoveFriendPopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_addRemoveFriendPopup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_addRemoveFriendPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000739 RID: 1849
	// (get) Token: 0x060016BD RID: 5821 RVA: 0x0005ED80 File Offset: 0x0005CF80
	// (set) Token: 0x060016BE RID: 5822 RVA: 0x0000EB2A File Offset: 0x0000CD2A
	public unsafe Text m_addRemoveFriendText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_addRemoveFriendText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_addRemoveFriendText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700073A RID: 1850
	// (get) Token: 0x060016BF RID: 5823 RVA: 0x0005EDB0 File Offset: 0x0005CFB0
	// (set) Token: 0x060016C0 RID: 5824 RVA: 0x0000EB49 File Offset: 0x0000CD49
	public unsafe Text m_addRemoveFriendName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_addRemoveFriendName);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_addRemoveFriendName), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700073B RID: 1851
	// (get) Token: 0x060016C1 RID: 5825 RVA: 0x0005EDE0 File Offset: 0x0005CFE0
	// (set) Token: 0x060016C2 RID: 5826 RVA: 0x0000EB68 File Offset: 0x0000CD68
	public unsafe Avatar_UI m_addRemoveFriendAvatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_addRemoveFriendAvatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_addRemoveFriendAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700073C RID: 1852
	// (get) Token: 0x060016C3 RID: 5827 RVA: 0x0005EE10 File Offset: 0x0005D010
	// (set) Token: 0x060016C4 RID: 5828 RVA: 0x0000EB87 File Offset: 0x0000CD87
	public unsafe bool m_bDisplayingFriend
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_bDisplayingFriend);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_bDisplayingFriend)) = value;
		}
	}

	// Token: 0x1700073D RID: 1853
	// (get) Token: 0x060016C5 RID: 5829 RVA: 0x0005EE38 File Offset: 0x0005D038
	// (set) Token: 0x060016C6 RID: 5830 RVA: 0x0000EBA2 File Offset: 0x0000CDA2
	public unsafe bool m_bDisplayingLocal
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_bDisplayingLocal);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_bDisplayingLocal)) = value;
		}
	}

	// Token: 0x1700073E RID: 1854
	// (get) Token: 0x060016C7 RID: 5831 RVA: 0x0005EE60 File Offset: 0x0005D060
	// (set) Token: 0x060016C8 RID: 5832 RVA: 0x0000EBBD File Offset: 0x0000CDBD
	public unsafe uint m_requestedFriendId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_requestedFriendId);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_requestedFriendId)) = value;
		}
	}

	// Token: 0x1700073F RID: 1855
	// (get) Token: 0x060016C9 RID: 5833 RVA: 0x0005EE88 File Offset: 0x0005D088
	// (set) Token: 0x060016CA RID: 5834 RVA: 0x0000EBD8 File Offset: 0x0000CDD8
	public unsafe int m_processFriendRequestReplyData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_processFriendRequestReplyData);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_processFriendRequestReplyData)) = value;
		}
	}

	// Token: 0x17000740 RID: 1856
	// (get) Token: 0x060016CB RID: 5835 RVA: 0x0005EEB0 File Offset: 0x0005D0B0
	// (set) Token: 0x060016CC RID: 5836 RVA: 0x0000EBF3 File Offset: 0x0000CDF3
	public unsafe bool m_bMinDialogDisplayTimeReached
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached)) = value;
		}
	}

	// Token: 0x17000741 RID: 1857
	// (get) Token: 0x060016CD RID: 5837 RVA: 0x0005EED8 File Offset: 0x0005D0D8
	// (set) Token: 0x060016CE RID: 5838 RVA: 0x0000EC0E File Offset: 0x0000CE0E
	public unsafe bool m_bProcessFriendRequestReply
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_bProcessFriendRequestReply);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_bProcessFriendRequestReply)) = value;
		}
	}

	// Token: 0x17000742 RID: 1858
	// (get) Token: 0x060016CF RID: 5839 RVA: 0x0005EF00 File Offset: 0x0005D100
	// (set) Token: 0x060016D0 RID: 5840 RVA: 0x0000EC29 File Offset: 0x0000CE29
	public unsafe Coroutine m_delayCoroutine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_delayCoroutine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup.NativeFieldInfoPtr_m_delayCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000F8C RID: 3980
	private static readonly IntPtr NativeFieldInfoPtr_m_messagePopup;

	// Token: 0x04000F8D RID: 3981
	private static readonly IntPtr NativeFieldInfoPtr_m_messagePopupCancelButton;

	// Token: 0x04000F8E RID: 3982
	private static readonly IntPtr NativeFieldInfoPtr_m_messagePopupText;

	// Token: 0x04000F8F RID: 3983
	private static readonly IntPtr NativeFieldInfoPtr_m_minDialogDisplayTime;

	// Token: 0x04000F90 RID: 3984
	private static readonly IntPtr NativeFieldInfoPtr_m_addRemoveFriendButtonBase;

	// Token: 0x04000F91 RID: 3985
	private static readonly IntPtr NativeFieldInfoPtr_m_addRemoveFriendButtonText;

	// Token: 0x04000F92 RID: 3986
	private static readonly IntPtr NativeFieldInfoPtr_m_displayNameLabel;

	// Token: 0x04000F93 RID: 3987
	private static readonly IntPtr NativeFieldInfoPtr_m_ratingNumLabel;

	// Token: 0x04000F94 RID: 3988
	private static readonly IntPtr NativeFieldInfoPtr_m_gamesCompletedNumLabel;

	// Token: 0x04000F95 RID: 3989
	private static readonly IntPtr NativeFieldInfoPtr_m_forfeitsNumLabel;

	// Token: 0x04000F96 RID: 3990
	private static readonly IntPtr NativeFieldInfoPtr_m_inProgressNumLabel;

	// Token: 0x04000F97 RID: 3991
	private static readonly IntPtr NativeFieldInfoPtr_m_2PlayerRecordLabel;

	// Token: 0x04000F98 RID: 3992
	private static readonly IntPtr NativeFieldInfoPtr_m_3PlayerRecordLabel;

	// Token: 0x04000F99 RID: 3993
	private static readonly IntPtr NativeFieldInfoPtr_m_4PlayerRecordLabel;

	// Token: 0x04000F9A RID: 3994
	private static readonly IntPtr NativeFieldInfoPtr_m_5PlayerRecordLabel;

	// Token: 0x04000F9B RID: 3995
	private static readonly IntPtr NativeFieldInfoPtr_m_6PlayerRecordLabel;

	// Token: 0x04000F9C RID: 3996
	private static readonly IntPtr NativeFieldInfoPtr_m_avatar;

	// Token: 0x04000F9D RID: 3997
	private static readonly IntPtr NativeFieldInfoPtr_m_addRemoveFriendPopup;

	// Token: 0x04000F9E RID: 3998
	private static readonly IntPtr NativeFieldInfoPtr_m_addRemoveFriendText;

	// Token: 0x04000F9F RID: 3999
	private static readonly IntPtr NativeFieldInfoPtr_m_addRemoveFriendName;

	// Token: 0x04000FA0 RID: 4000
	private static readonly IntPtr NativeFieldInfoPtr_m_addRemoveFriendAvatar;

	// Token: 0x04000FA1 RID: 4001
	private static readonly IntPtr NativeFieldInfoPtr_m_bDisplayingFriend;

	// Token: 0x04000FA2 RID: 4002
	private static readonly IntPtr NativeFieldInfoPtr_m_bDisplayingLocal;

	// Token: 0x04000FA3 RID: 4003
	private static readonly IntPtr NativeFieldInfoPtr_m_requestedFriendId;

	// Token: 0x04000FA4 RID: 4004
	private static readonly IntPtr NativeFieldInfoPtr_m_processFriendRequestReplyData;

	// Token: 0x04000FA5 RID: 4005
	private static readonly IntPtr NativeFieldInfoPtr_m_bMinDialogDisplayTimeReached;

	// Token: 0x04000FA6 RID: 4006
	private static readonly IntPtr NativeFieldInfoPtr_m_bProcessFriendRequestReply;

	// Token: 0x04000FA7 RID: 4007
	private static readonly IntPtr NativeFieldInfoPtr_m_delayCoroutine;

	// Token: 0x04000FA8 RID: 4008
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000FA9 RID: 4009
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000FAA RID: 4010
	private static readonly IntPtr NativeMethodInfoPtr_DisplayPlayerProfile_Public_Void_UInt32_0;

	// Token: 0x04000FAB RID: 4011
	private static readonly IntPtr NativeMethodInfoPtr_OnExit_Public_Void_0;

	// Token: 0x04000FAC RID: 4012
	private static readonly IntPtr NativeMethodInfoPtr_GetIsFriend_Public_Boolean_0;

	// Token: 0x04000FAD RID: 4013
	private static readonly IntPtr NativeMethodInfoPtr_FriendButtonClicked_Public_Void_0;

	// Token: 0x04000FAE RID: 4014
	private static readonly IntPtr NativeMethodInfoPtr_FriendButtonClickedConfirm_Public_Void_0;

	// Token: 0x04000FAF RID: 4015
	private static readonly IntPtr NativeMethodInfoPtr_ProcessFriendRequestReply_Private_Void_Int32_0;

	// Token: 0x04000FB0 RID: 4016
	private static readonly IntPtr NativeMethodInfoPtr_DisplayProfileInfo_Private_Void_NetworkPlayerProfileInfo_0;

	// Token: 0x04000FB1 RID: 4017
	private static readonly IntPtr NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0;

	// Token: 0x04000FB2 RID: 4018
	private static readonly IntPtr NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0;

	// Token: 0x04000FB3 RID: 4019
	private static readonly IntPtr NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0;

	// Token: 0x04000FB4 RID: 4020
	private static readonly IntPtr NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0;

	// Token: 0x04000FB5 RID: 4021
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001D5 RID: 469
	[ObfuscatedName("UIP_ProfilePopup+<ProcessDelayTime>d__40")]
	public sealed class _ProcessDelayTime_d__40 : global::Il2CppSystem.Object
	{
		// Token: 0x060026C8 RID: 9928 RVA: 0x0008E188 File Offset: 0x0008C388
		// Note: this type is marked as 'beforefieldinit'.
		static _ProcessDelayTime_d__40()
		{
			Il2CppClassPointerStore<UIP_ProfilePopup._ProcessDelayTime_d__40>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIP_ProfilePopup>.NativeClassPtr, "<ProcessDelayTime>d__40");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIP_ProfilePopup._ProcessDelayTime_d__40>.NativeClassPtr);
			UIP_ProfilePopup._ProcessDelayTime_d__40.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup._ProcessDelayTime_d__40>.NativeClassPtr, "<>1__state");
			UIP_ProfilePopup._ProcessDelayTime_d__40.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup._ProcessDelayTime_d__40>.NativeClassPtr, "<>2__current");
			UIP_ProfilePopup._ProcessDelayTime_d__40.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup._ProcessDelayTime_d__40>.NativeClassPtr, "<>4__this");
			UIP_ProfilePopup._ProcessDelayTime_d__40.NativeFieldInfoPtr_totalDelayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup._ProcessDelayTime_d__40>.NativeClassPtr, "totalDelayTime");
			UIP_ProfilePopup._ProcessDelayTime_d__40.NativeFieldInfoPtr__accumulatedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup._ProcessDelayTime_d__40>.NativeClassPtr, "<accumulatedTime>5__2");
			UIP_ProfilePopup._ProcessDelayTime_d__40.NativeFieldInfoPtr__previousTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIP_ProfilePopup._ProcessDelayTime_d__40>.NativeClassPtr, "<previousTime>5__3");
			UIP_ProfilePopup._ProcessDelayTime_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup._ProcessDelayTime_d__40>.NativeClassPtr, 100666368);
			UIP_ProfilePopup._ProcessDelayTime_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup._ProcessDelayTime_d__40>.NativeClassPtr, 100666369);
			UIP_ProfilePopup._ProcessDelayTime_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup._ProcessDelayTime_d__40>.NativeClassPtr, 100666370);
			UIP_ProfilePopup._ProcessDelayTime_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup._ProcessDelayTime_d__40>.NativeClassPtr, 100666371);
			UIP_ProfilePopup._ProcessDelayTime_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup._ProcessDelayTime_d__40>.NativeClassPtr, 100666372);
			UIP_ProfilePopup._ProcessDelayTime_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIP_ProfilePopup._ProcessDelayTime_d__40>.NativeClassPtr, 100666373);
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x0008E2A4 File Offset: 0x0008C4A4
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ProcessDelayTime_d__40(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIP_ProfilePopup._ProcessDelayTime_d__40>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ProfilePopup._ProcessDelayTime_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x0008E2EC File Offset: 0x0008C4EC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ProfilePopup._ProcessDelayTime_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x0008E320 File Offset: 0x0008C520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247773, XrefRangeEnd = 247781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ProfilePopup._ProcessDelayTime_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x060026CC RID: 9932 RVA: 0x0008E35C File Offset: 0x0008C55C
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ProfilePopup._ProcessDelayTime_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x0008E39C File Offset: 0x0008C59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247781, XrefRangeEnd = 247786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ProfilePopup._ProcessDelayTime_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x060026CE RID: 9934 RVA: 0x0008E3D0 File Offset: 0x0008C5D0
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIP_ProfilePopup._ProcessDelayTime_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x00017F08 File Offset: 0x00016108
		public _ProcessDelayTime_d__40(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x060026D0 RID: 9936 RVA: 0x0008E410 File Offset: 0x0008C610
		// (set) Token: 0x060026D1 RID: 9937 RVA: 0x00017F11 File Offset: 0x00016111
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup._ProcessDelayTime_d__40.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup._ProcessDelayTime_d__40.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x060026D2 RID: 9938 RVA: 0x0008E438 File Offset: 0x0008C638
		// (set) Token: 0x060026D3 RID: 9939 RVA: 0x00017F2C File Offset: 0x0001612C
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup._ProcessDelayTime_d__40.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup._ProcessDelayTime_d__40.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x060026D4 RID: 9940 RVA: 0x0008E468 File Offset: 0x0008C668
		// (set) Token: 0x060026D5 RID: 9941 RVA: 0x00017F4B File Offset: 0x0001614B
		public unsafe UIP_ProfilePopup __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup._ProcessDelayTime_d__40.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIP_ProfilePopup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup._ProcessDelayTime_d__40.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x060026D6 RID: 9942 RVA: 0x0008E498 File Offset: 0x0008C698
		// (set) Token: 0x060026D7 RID: 9943 RVA: 0x00017F6A File Offset: 0x0001616A
		public unsafe float totalDelayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup._ProcessDelayTime_d__40.NativeFieldInfoPtr_totalDelayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup._ProcessDelayTime_d__40.NativeFieldInfoPtr_totalDelayTime)) = value;
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x060026D8 RID: 9944 RVA: 0x0008E4C0 File Offset: 0x0008C6C0
		// (set) Token: 0x060026D9 RID: 9945 RVA: 0x00017F85 File Offset: 0x00016185
		public unsafe float _accumulatedTime_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup._ProcessDelayTime_d__40.NativeFieldInfoPtr__accumulatedTime_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup._ProcessDelayTime_d__40.NativeFieldInfoPtr__accumulatedTime_5__2)) = value;
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x060026DA RID: 9946 RVA: 0x0008E4E8 File Offset: 0x0008C6E8
		// (set) Token: 0x060026DB RID: 9947 RVA: 0x00017FA0 File Offset: 0x000161A0
		public unsafe float _previousTime_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup._ProcessDelayTime_d__40.NativeFieldInfoPtr__previousTime_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIP_ProfilePopup._ProcessDelayTime_d__40.NativeFieldInfoPtr__previousTime_5__3)) = value;
			}
		}

		// Token: 0x04001AC6 RID: 6854
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001AC7 RID: 6855
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001AC8 RID: 6856
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001AC9 RID: 6857
		private static readonly IntPtr NativeFieldInfoPtr_totalDelayTime;

		// Token: 0x04001ACA RID: 6858
		private static readonly IntPtr NativeFieldInfoPtr__accumulatedTime_5__2;

		// Token: 0x04001ACB RID: 6859
		private static readonly IntPtr NativeFieldInfoPtr__previousTime_5__3;

		// Token: 0x04001ACC RID: 6860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001ACD RID: 6861
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001ACE RID: 6862
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001ACF RID: 6863
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001AD0 RID: 6864
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001AD1 RID: 6865
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

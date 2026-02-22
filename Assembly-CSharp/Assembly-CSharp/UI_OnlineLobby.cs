using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000DA RID: 218
public class UI_OnlineLobby : UI_NetworkBase
{
	// Token: 0x06001AB2 RID: 6834 RVA: 0x0006A2E4 File Offset: 0x000684E4
	// Note: this type is marked as 'beforefieldinit'.
	static UI_OnlineLobby()
	{
		Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_OnlineLobby");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr);
		UI_OnlineLobby.NativeFieldInfoPtr_m_onlineGameList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, "m_onlineGameList");
		UI_OnlineLobby.NativeFieldInfoPtr_m_userNameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, "m_userNameLabel");
		UI_OnlineLobby.NativeFieldInfoPtr_m_userRatingLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, "m_userRatingLabel");
		UI_OnlineLobby.NativeFieldInfoPtr_m_userAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, "m_userAvatar");
		UI_OnlineLobby.NativeFieldInfoPtr_m_Toggle_ActiveGameList_Deprecated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, "m_Toggle_ActiveGameList_Deprecated");
		UI_OnlineLobby.NativeFieldInfoPtr_m_Toggle_CompletedGameList_Deprecated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, "m_Toggle_CompletedGameList_Deprecated");
		UI_OnlineLobby.NativeFieldInfoPtr_m_Button_ActiveGameList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, "m_Button_ActiveGameList");
		UI_OnlineLobby.NativeFieldInfoPtr_m_Button_CompletedGameList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, "m_Button_CompletedGameList");
		UI_OnlineLobby.NativeFieldInfoPtr_m_ActiveListText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, "m_ActiveListText");
		UI_OnlineLobby.NativeFieldInfoPtr_m_selectSlotAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, "m_selectSlotAudio");
		UI_OnlineLobby.NativeFieldInfoPtr_m_toggleAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, "m_toggleAudio");
		UI_OnlineLobby.NativeFieldInfoPtr_m_joinGameScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, "m_joinGameScreen");
		UI_OnlineLobby.NativeFieldInfoPtr_m_bIgnoreToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, "m_bIgnoreToggles");
		UI_OnlineLobby.NativeFieldInfoPtr_m_bEnterFromPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, "m_bEnterFromPopup");
		UI_OnlineLobby.NativeFieldInfoPtr_m_bLoadingIntoCompletedGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, "m_bLoadingIntoCompletedGame");
		UI_OnlineLobby.NativeFieldInfoPtr_m_lastGameSlotClickEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, "m_lastGameSlotClickEvent");
		UI_OnlineLobby.NativeFieldInfoPtr_m_lastGameSlotSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, "m_lastGameSlotSelected");
		UI_OnlineLobby.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, 100665409);
		UI_OnlineLobby.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, 100665410);
		UI_OnlineLobby.NativeMethodInfoPtr_OnConfirmButtonPressed_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, 100665411);
		UI_OnlineLobby.NativeMethodInfoPtr_OnToggleButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, 100665412);
		UI_OnlineLobby.NativeMethodInfoPtr_IgnoreNetworkEvents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, 100665413);
		UI_OnlineLobby.NativeMethodInfoPtr_EnableActiveGameList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, 100665414);
		UI_OnlineLobby.NativeMethodInfoPtr_EnableCompletedGameList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, 100665415);
		UI_OnlineLobby.NativeMethodInfoPtr_CheckForNewChat_Private_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, 100665416);
		UI_OnlineLobby.NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, 100665417);
		UI_OnlineLobby.NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, 100665418);
		UI_OnlineLobby.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_GameSlot_ClickEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, 100665419);
		UI_OnlineLobby.NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, 100665420);
		UI_OnlineLobby.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, 100665421);
		UI_OnlineLobby.NativeMethodInfoPtr_DisplayLocalPlayerProfile_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, 100665422);
		UI_OnlineLobby.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, 100665423);
	}

	// Token: 0x06001AB3 RID: 6835 RVA: 0x0006A594 File Offset: 0x00068794
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252336, XrefRangeEnd = 252368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnterMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineLobby.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AB4 RID: 6836 RVA: 0x0006A5C8 File Offset: 0x000687C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252368, XrefRangeEnd = 252370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExitMenu(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineLobby.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001AB5 RID: 6837 RVA: 0x0006A608 File Offset: 0x00068808
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252370, XrefRangeEnd = 252374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConfirmButtonPressed(bool bConfirm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bConfirm;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineLobby.NativeMethodInfoPtr_OnConfirmButtonPressed_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001AB6 RID: 6838 RVA: 0x0006A648 File Offset: 0x00068848
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252374, XrefRangeEnd = 252382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnToggleButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineLobby.NativeMethodInfoPtr_OnToggleButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AB7 RID: 6839 RVA: 0x0006A67C File Offset: 0x0006887C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IgnoreNetworkEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineLobby.NativeMethodInfoPtr_IgnoreNetworkEvents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AB8 RID: 6840 RVA: 0x0006A6B0 File Offset: 0x000688B0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 252399, RefRangeEnd = 252401, XrefRangeStart = 252382, XrefRangeEnd = 252399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableActiveGameList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineLobby.NativeMethodInfoPtr_EnableActiveGameList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AB9 RID: 6841 RVA: 0x0006A6E4 File Offset: 0x000688E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252401, XrefRangeEnd = 252418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableCompletedGameList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineLobby.NativeMethodInfoPtr_EnableCompletedGameList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001ABA RID: 6842 RVA: 0x0006A718 File Offset: 0x00068918
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252418, XrefRangeEnd = 252422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator CheckForNewChat(bool bIsCompleteList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bIsCompleteList;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineLobby.NativeMethodInfoPtr_CheckForNewChat_Private_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x06001ABB RID: 6843 RVA: 0x0006A764 File Offset: 0x00068964
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NetworkStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_OnlineLobby.NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001ABC RID: 6844 RVA: 0x0006A7A0 File Offset: 0x000689A0
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NetworkOnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_OnlineLobby.NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001ABD RID: 6845 RVA: 0x0006A7DC File Offset: 0x000689DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252422, XrefRangeEnd = 252566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleClickOnSlot(UIP_GameSlot slot, UIP_GameSlot.ClickEventType evt)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineLobby.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_GameSlot_ClickEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001ABE RID: 6846 RVA: 0x0006A82C File Offset: 0x00068A2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252566, XrefRangeEnd = 252572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_OnlineLobby.NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001ABF RID: 6847 RVA: 0x0006A884 File Offset: 0x00068A84
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineLobby.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AC0 RID: 6848 RVA: 0x0006A8B8 File Offset: 0x00068AB8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 252587, RefRangeEnd = 252589, XrefRangeStart = 252572, XrefRangeEnd = 252587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisplayLocalPlayerProfile(bool bVisible)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineLobby.NativeMethodInfoPtr_DisplayLocalPlayerProfile_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001AC1 RID: 6849 RVA: 0x0006A8F8 File Offset: 0x00068AF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252589, XrefRangeEnd = 252600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_OnlineLobby()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineLobby.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001AC2 RID: 6850 RVA: 0x00011232 File Offset: 0x0000F432
	public UI_OnlineLobby(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000887 RID: 2183
	// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x0006A934 File Offset: 0x00068B34
	// (set) Token: 0x06001AC4 RID: 6852 RVA: 0x0001123B File Offset: 0x0000F43B
	public unsafe UIC_OnlineGameList m_onlineGameList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_onlineGameList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_OnlineGameList>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_onlineGameList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000888 RID: 2184
	// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x0006A964 File Offset: 0x00068B64
	// (set) Token: 0x06001AC6 RID: 6854 RVA: 0x0001125A File Offset: 0x0000F45A
	public unsafe TextMeshProUGUI m_userNameLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_userNameLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_userNameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000889 RID: 2185
	// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x0006A994 File Offset: 0x00068B94
	// (set) Token: 0x06001AC8 RID: 6856 RVA: 0x00011279 File Offset: 0x0000F479
	public unsafe TextMeshProUGUI m_userRatingLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_userRatingLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_userRatingLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700088A RID: 2186
	// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x0006A9C4 File Offset: 0x00068BC4
	// (set) Token: 0x06001ACA RID: 6858 RVA: 0x00011298 File Offset: 0x0000F498
	public unsafe Avatar_UI m_userAvatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_userAvatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_userAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700088B RID: 2187
	// (get) Token: 0x06001ACB RID: 6859 RVA: 0x0006A9F4 File Offset: 0x00068BF4
	// (set) Token: 0x06001ACC RID: 6860 RVA: 0x000112B7 File Offset: 0x0000F4B7
	public unsafe Toggle m_Toggle_ActiveGameList_Deprecated
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_Toggle_ActiveGameList_Deprecated);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_Toggle_ActiveGameList_Deprecated), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700088C RID: 2188
	// (get) Token: 0x06001ACD RID: 6861 RVA: 0x0006AA24 File Offset: 0x00068C24
	// (set) Token: 0x06001ACE RID: 6862 RVA: 0x000112D6 File Offset: 0x0000F4D6
	public unsafe Toggle m_Toggle_CompletedGameList_Deprecated
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_Toggle_CompletedGameList_Deprecated);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_Toggle_CompletedGameList_Deprecated), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700088D RID: 2189
	// (get) Token: 0x06001ACF RID: 6863 RVA: 0x0006AA54 File Offset: 0x00068C54
	// (set) Token: 0x06001AD0 RID: 6864 RVA: 0x000112F5 File Offset: 0x0000F4F5
	public unsafe Button m_Button_ActiveGameList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_Button_ActiveGameList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_Button_ActiveGameList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700088E RID: 2190
	// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x0006AA84 File Offset: 0x00068C84
	// (set) Token: 0x06001AD2 RID: 6866 RVA: 0x00011314 File Offset: 0x0000F514
	public unsafe Button m_Button_CompletedGameList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_Button_CompletedGameList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_Button_CompletedGameList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700088F RID: 2191
	// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x0006AAB4 File Offset: 0x00068CB4
	// (set) Token: 0x06001AD4 RID: 6868 RVA: 0x00011333 File Offset: 0x0000F533
	public unsafe TextMeshProUGUI m_ActiveListText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_ActiveListText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_ActiveListText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000890 RID: 2192
	// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x0006AAE4 File Offset: 0x00068CE4
	// (set) Token: 0x06001AD6 RID: 6870 RVA: 0x00011352 File Offset: 0x0000F552
	public unsafe AudioSource m_selectSlotAudio
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_selectSlotAudio);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_selectSlotAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000891 RID: 2193
	// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x0006AB14 File Offset: 0x00068D14
	// (set) Token: 0x06001AD8 RID: 6872 RVA: 0x00011371 File Offset: 0x0000F571
	public unsafe AudioSource m_toggleAudio
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_toggleAudio);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_toggleAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000892 RID: 2194
	// (get) Token: 0x06001AD9 RID: 6873 RVA: 0x0006AB44 File Offset: 0x00068D44
	// (set) Token: 0x06001ADA RID: 6874 RVA: 0x00011390 File Offset: 0x0000F590
	public unsafe UI_OnlineJoinViewGame m_joinGameScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_joinGameScreen);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_OnlineJoinViewGame>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_joinGameScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000893 RID: 2195
	// (get) Token: 0x06001ADB RID: 6875 RVA: 0x0006AB74 File Offset: 0x00068D74
	// (set) Token: 0x06001ADC RID: 6876 RVA: 0x000113AF File Offset: 0x0000F5AF
	public unsafe bool m_bIgnoreToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_bIgnoreToggles);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_bIgnoreToggles)) = value;
		}
	}

	// Token: 0x17000894 RID: 2196
	// (get) Token: 0x06001ADD RID: 6877 RVA: 0x0006AB9C File Offset: 0x00068D9C
	// (set) Token: 0x06001ADE RID: 6878 RVA: 0x000113CA File Offset: 0x0000F5CA
	public unsafe bool m_bEnterFromPopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_bEnterFromPopup);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_bEnterFromPopup)) = value;
		}
	}

	// Token: 0x17000895 RID: 2197
	// (get) Token: 0x06001ADF RID: 6879 RVA: 0x0006ABC4 File Offset: 0x00068DC4
	// (set) Token: 0x06001AE0 RID: 6880 RVA: 0x000113E5 File Offset: 0x0000F5E5
	public unsafe bool m_bLoadingIntoCompletedGame
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_bLoadingIntoCompletedGame);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_bLoadingIntoCompletedGame)) = value;
		}
	}

	// Token: 0x17000896 RID: 2198
	// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x0006ABEC File Offset: 0x00068DEC
	// (set) Token: 0x06001AE2 RID: 6882 RVA: 0x00011400 File Offset: 0x0000F600
	public unsafe UIP_GameSlot.ClickEventType m_lastGameSlotClickEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_lastGameSlotClickEvent);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_lastGameSlotClickEvent)) = value;
		}
	}

	// Token: 0x17000897 RID: 2199
	// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x0006AC14 File Offset: 0x00068E14
	// (set) Token: 0x06001AE4 RID: 6884 RVA: 0x0001141B File Offset: 0x0000F61B
	public unsafe UIP_GameSlot m_lastGameSlotSelected
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_lastGameSlotSelected);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIP_GameSlot>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby.NativeFieldInfoPtr_m_lastGameSlotSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400121A RID: 4634
	private static readonly IntPtr NativeFieldInfoPtr_m_onlineGameList;

	// Token: 0x0400121B RID: 4635
	private static readonly IntPtr NativeFieldInfoPtr_m_userNameLabel;

	// Token: 0x0400121C RID: 4636
	private static readonly IntPtr NativeFieldInfoPtr_m_userRatingLabel;

	// Token: 0x0400121D RID: 4637
	private static readonly IntPtr NativeFieldInfoPtr_m_userAvatar;

	// Token: 0x0400121E RID: 4638
	private static readonly IntPtr NativeFieldInfoPtr_m_Toggle_ActiveGameList_Deprecated;

	// Token: 0x0400121F RID: 4639
	private static readonly IntPtr NativeFieldInfoPtr_m_Toggle_CompletedGameList_Deprecated;

	// Token: 0x04001220 RID: 4640
	private static readonly IntPtr NativeFieldInfoPtr_m_Button_ActiveGameList;

	// Token: 0x04001221 RID: 4641
	private static readonly IntPtr NativeFieldInfoPtr_m_Button_CompletedGameList;

	// Token: 0x04001222 RID: 4642
	private static readonly IntPtr NativeFieldInfoPtr_m_ActiveListText;

	// Token: 0x04001223 RID: 4643
	private static readonly IntPtr NativeFieldInfoPtr_m_selectSlotAudio;

	// Token: 0x04001224 RID: 4644
	private static readonly IntPtr NativeFieldInfoPtr_m_toggleAudio;

	// Token: 0x04001225 RID: 4645
	private static readonly IntPtr NativeFieldInfoPtr_m_joinGameScreen;

	// Token: 0x04001226 RID: 4646
	private static readonly IntPtr NativeFieldInfoPtr_m_bIgnoreToggles;

	// Token: 0x04001227 RID: 4647
	private static readonly IntPtr NativeFieldInfoPtr_m_bEnterFromPopup;

	// Token: 0x04001228 RID: 4648
	private static readonly IntPtr NativeFieldInfoPtr_m_bLoadingIntoCompletedGame;

	// Token: 0x04001229 RID: 4649
	private static readonly IntPtr NativeFieldInfoPtr_m_lastGameSlotClickEvent;

	// Token: 0x0400122A RID: 4650
	private static readonly IntPtr NativeFieldInfoPtr_m_lastGameSlotSelected;

	// Token: 0x0400122B RID: 4651
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterMenu_Public_Void_0;

	// Token: 0x0400122C RID: 4652
	private static readonly IntPtr NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0;

	// Token: 0x0400122D RID: 4653
	private static readonly IntPtr NativeMethodInfoPtr_OnConfirmButtonPressed_Public_Void_Boolean_0;

	// Token: 0x0400122E RID: 4654
	private static readonly IntPtr NativeMethodInfoPtr_OnToggleButtonPressed_Public_Void_0;

	// Token: 0x0400122F RID: 4655
	private static readonly IntPtr NativeMethodInfoPtr_IgnoreNetworkEvents_Public_Void_0;

	// Token: 0x04001230 RID: 4656
	private static readonly IntPtr NativeMethodInfoPtr_EnableActiveGameList_Public_Void_0;

	// Token: 0x04001231 RID: 4657
	private static readonly IntPtr NativeMethodInfoPtr_EnableCompletedGameList_Public_Void_0;

	// Token: 0x04001232 RID: 4658
	private static readonly IntPtr NativeMethodInfoPtr_CheckForNewChat_Private_IEnumerator_Boolean_0;

	// Token: 0x04001233 RID: 4659
	private static readonly IntPtr NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0;

	// Token: 0x04001234 RID: 4660
	private static readonly IntPtr NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0;

	// Token: 0x04001235 RID: 4661
	private static readonly IntPtr NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_GameSlot_ClickEventType_0;

	// Token: 0x04001236 RID: 4662
	private static readonly IntPtr NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0;

	// Token: 0x04001237 RID: 4663
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04001238 RID: 4664
	private static readonly IntPtr NativeMethodInfoPtr_DisplayLocalPlayerProfile_Private_Void_Boolean_0;

	// Token: 0x04001239 RID: 4665
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000202 RID: 514
	[ObfuscatedName("UI_OnlineLobby+<CheckForNewChat>d__24")]
	public sealed class _CheckForNewChat_d__24 : global::Il2CppSystem.Object
	{
		// Token: 0x060028D8 RID: 10456 RVA: 0x000937E4 File Offset: 0x000919E4
		// Note: this type is marked as 'beforefieldinit'.
		static _CheckForNewChat_d__24()
		{
			Il2CppClassPointerStore<UI_OnlineLobby._CheckForNewChat_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_OnlineLobby>.NativeClassPtr, "<CheckForNewChat>d__24");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_OnlineLobby._CheckForNewChat_d__24>.NativeClassPtr);
			UI_OnlineLobby._CheckForNewChat_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby._CheckForNewChat_d__24>.NativeClassPtr, "<>1__state");
			UI_OnlineLobby._CheckForNewChat_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby._CheckForNewChat_d__24>.NativeClassPtr, "<>2__current");
			UI_OnlineLobby._CheckForNewChat_d__24.NativeFieldInfoPtr_bIsCompleteList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineLobby._CheckForNewChat_d__24>.NativeClassPtr, "bIsCompleteList");
			UI_OnlineLobby._CheckForNewChat_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby._CheckForNewChat_d__24>.NativeClassPtr, 100666504);
			UI_OnlineLobby._CheckForNewChat_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby._CheckForNewChat_d__24>.NativeClassPtr, 100666505);
			UI_OnlineLobby._CheckForNewChat_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby._CheckForNewChat_d__24>.NativeClassPtr, 100666506);
			UI_OnlineLobby._CheckForNewChat_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby._CheckForNewChat_d__24>.NativeClassPtr, 100666507);
			UI_OnlineLobby._CheckForNewChat_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby._CheckForNewChat_d__24>.NativeClassPtr, 100666508);
			UI_OnlineLobby._CheckForNewChat_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineLobby._CheckForNewChat_d__24>.NativeClassPtr, 100666509);
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x000938C4 File Offset: 0x00091AC4
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _CheckForNewChat_d__24(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_OnlineLobby._CheckForNewChat_d__24>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineLobby._CheckForNewChat_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x0009390C File Offset: 0x00091B0C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineLobby._CheckForNewChat_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x00093940 File Offset: 0x00091B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252326, XrefRangeEnd = 252331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineLobby._CheckForNewChat_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x060028DC RID: 10460 RVA: 0x0009397C File Offset: 0x00091B7C
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineLobby._CheckForNewChat_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x000939BC File Offset: 0x00091BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252331, XrefRangeEnd = 252336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineLobby._CheckForNewChat_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x060028DE RID: 10462 RVA: 0x000939F0 File Offset: 0x00091BF0
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineLobby._CheckForNewChat_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x00019309 File Offset: 0x00017509
		public _CheckForNewChat_d__24(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x060028E0 RID: 10464 RVA: 0x00093A30 File Offset: 0x00091C30
		// (set) Token: 0x060028E1 RID: 10465 RVA: 0x00019312 File Offset: 0x00017512
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby._CheckForNewChat_d__24.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby._CheckForNewChat_d__24.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x060028E2 RID: 10466 RVA: 0x00093A58 File Offset: 0x00091C58
		// (set) Token: 0x060028E3 RID: 10467 RVA: 0x0001932D File Offset: 0x0001752D
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby._CheckForNewChat_d__24.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby._CheckForNewChat_d__24.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x060028E4 RID: 10468 RVA: 0x00093A88 File Offset: 0x00091C88
		// (set) Token: 0x060028E5 RID: 10469 RVA: 0x0001934C File Offset: 0x0001754C
		public unsafe bool bIsCompleteList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby._CheckForNewChat_d__24.NativeFieldInfoPtr_bIsCompleteList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineLobby._CheckForNewChat_d__24.NativeFieldInfoPtr_bIsCompleteList)) = value;
			}
		}

		// Token: 0x04001C09 RID: 7177
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001C0A RID: 7178
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001C0B RID: 7179
		private static readonly IntPtr NativeFieldInfoPtr_bIsCompleteList;

		// Token: 0x04001C0C RID: 7180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001C0D RID: 7181
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001C0E RID: 7182
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001C0F RID: 7183
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001C10 RID: 7184
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001C11 RID: 7185
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

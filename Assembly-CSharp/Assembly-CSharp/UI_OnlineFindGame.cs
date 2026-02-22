using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000D8 RID: 216
public class UI_OnlineFindGame : UI_NetworkBase
{
	// Token: 0x06001A39 RID: 6713 RVA: 0x00068CE0 File Offset: 0x00066EE0
	// Note: this type is marked as 'beforefieldinit'.
	static UI_OnlineFindGame()
	{
		Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_OnlineFindGame");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr);
		UI_OnlineFindGame.NativeFieldInfoPtr_m_onlineGameList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, "m_onlineGameList");
		UI_OnlineFindGame.NativeFieldInfoPtr_m_timerValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, "m_timerValues");
		UI_OnlineFindGame.NativeFieldInfoPtr_m_playerCountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, "m_playerCountText");
		UI_OnlineFindGame.NativeFieldInfoPtr_m_timerCountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, "m_timerCountText");
		UI_OnlineFindGame.NativeFieldInfoPtr_m_ToggleFilterPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, "m_ToggleFilterPlayers");
		UI_OnlineFindGame.NativeFieldInfoPtr_m_ToggleFilterTimers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, "m_ToggleFilterTimers");
		UI_OnlineFindGame.NativeFieldInfoPtr_m_selectSlotAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, "m_selectSlotAudio");
		UI_OnlineFindGame.NativeFieldInfoPtr_m_toggleAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, "m_toggleAudio");
		UI_OnlineFindGame.NativeFieldInfoPtr_m_joinGameScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, "m_joinGameScreen");
		UI_OnlineFindGame.NativeFieldInfoPtr_m_bIgnoreToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, "m_bIgnoreToggles");
		UI_OnlineFindGame.NativeFieldInfoPtr_m_bEnterFromPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, "m_bEnterFromPopup");
		UI_OnlineFindGame.NativeFieldInfoPtr_m_lastGameSlotClickEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, "m_lastGameSlotClickEvent");
		UI_OnlineFindGame.NativeFieldInfoPtr_m_lastGameSlotSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, "m_lastGameSlotSelected");
		UI_OnlineFindGame.NativeFieldInfoPtr_m_playerFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, "m_playerFilter");
		UI_OnlineFindGame.NativeFieldInfoPtr_m_timerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, "m_timerIndex");
		UI_OnlineFindGame.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, 100665374);
		UI_OnlineFindGame.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, 100665375);
		UI_OnlineFindGame.NativeMethodInfoPtr_RetrieveSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, 100665376);
		UI_OnlineFindGame.NativeMethodInfoPtr_StoreSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, 100665377);
		UI_OnlineFindGame.NativeMethodInfoPtr_OnConfirmButtonPressed_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, 100665378);
		UI_OnlineFindGame.NativeMethodInfoPtr_UpdateButtonText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, 100665379);
		UI_OnlineFindGame.NativeMethodInfoPtr_HandlePlayerToggle_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, 100665380);
		UI_OnlineFindGame.NativeMethodInfoPtr_HandleTimerToggle_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, 100665381);
		UI_OnlineFindGame.NativeMethodInfoPtr_UpdateToggles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, 100665382);
		UI_OnlineFindGame.NativeMethodInfoPtr_OnRefreshPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, 100665383);
		UI_OnlineFindGame.NativeMethodInfoPtr_IgnoreNetworkEvents_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, 100665384);
		UI_OnlineFindGame.NativeMethodInfoPtr_EnableFindGameList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, 100665385);
		UI_OnlineFindGame.NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, 100665386);
		UI_OnlineFindGame.NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, 100665387);
		UI_OnlineFindGame.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_GameSlot_ClickEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, 100665388);
		UI_OnlineFindGame.NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, 100665389);
		UI_OnlineFindGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, 100665390);
	}

	// Token: 0x06001A3A RID: 6714 RVA: 0x00068F90 File Offset: 0x00067190
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251713, XrefRangeEnd = 251725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnterMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineFindGame.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A3B RID: 6715 RVA: 0x00068FC4 File Offset: 0x000671C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251725, XrefRangeEnd = 251728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExitMenu(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineFindGame.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001A3C RID: 6716 RVA: 0x00069004 File Offset: 0x00067204
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 251765, RefRangeEnd = 251766, XrefRangeStart = 251728, XrefRangeEnd = 251765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RetrieveSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineFindGame.NativeMethodInfoPtr_RetrieveSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A3D RID: 6717 RVA: 0x00069038 File Offset: 0x00067238
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 251797, RefRangeEnd = 251798, XrefRangeStart = 251766, XrefRangeEnd = 251797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StoreSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineFindGame.NativeMethodInfoPtr_StoreSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A3E RID: 6718 RVA: 0x0006906C File Offset: 0x0006726C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConfirmButtonPressed(bool bConfirm)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bConfirm;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineFindGame.NativeMethodInfoPtr_OnConfirmButtonPressed_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001A3F RID: 6719 RVA: 0x000690AC File Offset: 0x000672AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251798, XrefRangeEnd = 251809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateButtonText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineFindGame.NativeMethodInfoPtr_UpdateButtonText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A40 RID: 6720 RVA: 0x000690E0 File Offset: 0x000672E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251809, XrefRangeEnd = 251814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandlePlayerToggle(int lastPressedIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref lastPressedIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineFindGame.NativeMethodInfoPtr_HandlePlayerToggle_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001A41 RID: 6721 RVA: 0x00069120 File Offset: 0x00067320
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251814, XrefRangeEnd = 251819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleTimerToggle(int lastPressedIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref lastPressedIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineFindGame.NativeMethodInfoPtr_HandleTimerToggle_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001A42 RID: 6722 RVA: 0x00069160 File Offset: 0x00067360
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 251827, RefRangeEnd = 251834, XrefRangeStart = 251819, XrefRangeEnd = 251827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateToggles()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineFindGame.NativeMethodInfoPtr_UpdateToggles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A43 RID: 6723 RVA: 0x00069194 File Offset: 0x00067394
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251834, XrefRangeEnd = 251836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRefreshPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineFindGame.NativeMethodInfoPtr_OnRefreshPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A44 RID: 6724 RVA: 0x000691C8 File Offset: 0x000673C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251836, XrefRangeEnd = 251838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void IgnoreNetworkEvents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineFindGame.NativeMethodInfoPtr_IgnoreNetworkEvents_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A45 RID: 6725 RVA: 0x000691FC File Offset: 0x000673FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableFindGameList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineFindGame.NativeMethodInfoPtr_EnableFindGameList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A46 RID: 6726 RVA: 0x00069230 File Offset: 0x00067430
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NetworkStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_OnlineFindGame.NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A47 RID: 6727 RVA: 0x0006926C File Offset: 0x0006746C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NetworkOnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_OnlineFindGame.NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A48 RID: 6728 RVA: 0x000692A8 File Offset: 0x000674A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251838, XrefRangeEnd = 251979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineFindGame.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_GameSlot_ClickEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A49 RID: 6729 RVA: 0x000692F8 File Offset: 0x000674F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251979, XrefRangeEnd = 251980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_OnlineFindGame.NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A4A RID: 6730 RVA: 0x00069350 File Offset: 0x00067550
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251980, XrefRangeEnd = 251984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_OnlineFindGame()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OnlineFindGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001A4B RID: 6731 RVA: 0x00010D5E File Offset: 0x0000EF5E
	public UI_OnlineFindGame(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700085E RID: 2142
	// (get) Token: 0x06001A4C RID: 6732 RVA: 0x0006938C File Offset: 0x0006758C
	// (set) Token: 0x06001A4D RID: 6733 RVA: 0x00010D67 File Offset: 0x0000EF67
	public unsafe UIC_OnlineGameList m_onlineGameList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_onlineGameList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_OnlineGameList>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_onlineGameList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700085F RID: 2143
	// (get) Token: 0x06001A4E RID: 6734 RVA: 0x000693BC File Offset: 0x000675BC
	// (set) Token: 0x06001A4F RID: 6735 RVA: 0x00010D86 File Offset: 0x0000EF86
	public unsafe Il2CppReferenceArray<UI_OnlineFindGame.TimerValue> m_timerValues
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_timerValues);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UI_OnlineFindGame.TimerValue>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_timerValues), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000860 RID: 2144
	// (get) Token: 0x06001A50 RID: 6736 RVA: 0x000693EC File Offset: 0x000675EC
	// (set) Token: 0x06001A51 RID: 6737 RVA: 0x00010DA5 File Offset: 0x0000EFA5
	public unsafe TextMeshProUGUI m_playerCountText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_playerCountText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_playerCountText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000861 RID: 2145
	// (get) Token: 0x06001A52 RID: 6738 RVA: 0x0006941C File Offset: 0x0006761C
	// (set) Token: 0x06001A53 RID: 6739 RVA: 0x00010DC4 File Offset: 0x0000EFC4
	public unsafe TextMeshProUGUI m_timerCountText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_timerCountText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_timerCountText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000862 RID: 2146
	// (get) Token: 0x06001A54 RID: 6740 RVA: 0x0006944C File Offset: 0x0006764C
	// (set) Token: 0x06001A55 RID: 6741 RVA: 0x00010DE3 File Offset: 0x0000EFE3
	public unsafe Il2CppReferenceArray<Toggle> m_ToggleFilterPlayers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_ToggleFilterPlayers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Toggle>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_ToggleFilterPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000863 RID: 2147
	// (get) Token: 0x06001A56 RID: 6742 RVA: 0x0006947C File Offset: 0x0006767C
	// (set) Token: 0x06001A57 RID: 6743 RVA: 0x00010E02 File Offset: 0x0000F002
	public unsafe Il2CppReferenceArray<Toggle> m_ToggleFilterTimers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_ToggleFilterTimers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Toggle>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_ToggleFilterTimers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000864 RID: 2148
	// (get) Token: 0x06001A58 RID: 6744 RVA: 0x000694AC File Offset: 0x000676AC
	// (set) Token: 0x06001A59 RID: 6745 RVA: 0x00010E21 File Offset: 0x0000F021
	public unsafe AudioSource m_selectSlotAudio
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_selectSlotAudio);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_selectSlotAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000865 RID: 2149
	// (get) Token: 0x06001A5A RID: 6746 RVA: 0x000694DC File Offset: 0x000676DC
	// (set) Token: 0x06001A5B RID: 6747 RVA: 0x00010E40 File Offset: 0x0000F040
	public unsafe AudioSource m_toggleAudio
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_toggleAudio);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_toggleAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000866 RID: 2150
	// (get) Token: 0x06001A5C RID: 6748 RVA: 0x0006950C File Offset: 0x0006770C
	// (set) Token: 0x06001A5D RID: 6749 RVA: 0x00010E5F File Offset: 0x0000F05F
	public unsafe UI_OnlineJoinViewGame m_joinGameScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_joinGameScreen);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_OnlineJoinViewGame>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_joinGameScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000867 RID: 2151
	// (get) Token: 0x06001A5E RID: 6750 RVA: 0x0006953C File Offset: 0x0006773C
	// (set) Token: 0x06001A5F RID: 6751 RVA: 0x00010E7E File Offset: 0x0000F07E
	public unsafe bool m_bIgnoreToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_bIgnoreToggles);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_bIgnoreToggles)) = value;
		}
	}

	// Token: 0x17000868 RID: 2152
	// (get) Token: 0x06001A60 RID: 6752 RVA: 0x00069564 File Offset: 0x00067764
	// (set) Token: 0x06001A61 RID: 6753 RVA: 0x00010E99 File Offset: 0x0000F099
	public unsafe bool m_bEnterFromPopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_bEnterFromPopup);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_bEnterFromPopup)) = value;
		}
	}

	// Token: 0x17000869 RID: 2153
	// (get) Token: 0x06001A62 RID: 6754 RVA: 0x0006958C File Offset: 0x0006778C
	// (set) Token: 0x06001A63 RID: 6755 RVA: 0x00010EB4 File Offset: 0x0000F0B4
	public unsafe UIP_GameSlot.ClickEventType m_lastGameSlotClickEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_lastGameSlotClickEvent);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_lastGameSlotClickEvent)) = value;
		}
	}

	// Token: 0x1700086A RID: 2154
	// (get) Token: 0x06001A64 RID: 6756 RVA: 0x000695B4 File Offset: 0x000677B4
	// (set) Token: 0x06001A65 RID: 6757 RVA: 0x00010ECF File Offset: 0x0000F0CF
	public unsafe UIP_GameSlot m_lastGameSlotSelected
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_lastGameSlotSelected);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIP_GameSlot>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_lastGameSlotSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700086B RID: 2155
	// (get) Token: 0x06001A66 RID: 6758 RVA: 0x000695E4 File Offset: 0x000677E4
	// (set) Token: 0x06001A67 RID: 6759 RVA: 0x00010EEE File Offset: 0x0000F0EE
	public unsafe uint m_playerFilter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_playerFilter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_playerFilter)) = value;
		}
	}

	// Token: 0x1700086C RID: 2156
	// (get) Token: 0x06001A68 RID: 6760 RVA: 0x0006960C File Offset: 0x0006780C
	// (set) Token: 0x06001A69 RID: 6761 RVA: 0x00010F09 File Offset: 0x0000F109
	public unsafe uint m_timerIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_timerIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.NativeFieldInfoPtr_m_timerIndex)) = value;
		}
	}

	// Token: 0x040011CE RID: 4558
	private static readonly IntPtr NativeFieldInfoPtr_m_onlineGameList;

	// Token: 0x040011CF RID: 4559
	private static readonly IntPtr NativeFieldInfoPtr_m_timerValues;

	// Token: 0x040011D0 RID: 4560
	private static readonly IntPtr NativeFieldInfoPtr_m_playerCountText;

	// Token: 0x040011D1 RID: 4561
	private static readonly IntPtr NativeFieldInfoPtr_m_timerCountText;

	// Token: 0x040011D2 RID: 4562
	private static readonly IntPtr NativeFieldInfoPtr_m_ToggleFilterPlayers;

	// Token: 0x040011D3 RID: 4563
	private static readonly IntPtr NativeFieldInfoPtr_m_ToggleFilterTimers;

	// Token: 0x040011D4 RID: 4564
	private static readonly IntPtr NativeFieldInfoPtr_m_selectSlotAudio;

	// Token: 0x040011D5 RID: 4565
	private static readonly IntPtr NativeFieldInfoPtr_m_toggleAudio;

	// Token: 0x040011D6 RID: 4566
	private static readonly IntPtr NativeFieldInfoPtr_m_joinGameScreen;

	// Token: 0x040011D7 RID: 4567
	private static readonly IntPtr NativeFieldInfoPtr_m_bIgnoreToggles;

	// Token: 0x040011D8 RID: 4568
	private static readonly IntPtr NativeFieldInfoPtr_m_bEnterFromPopup;

	// Token: 0x040011D9 RID: 4569
	private static readonly IntPtr NativeFieldInfoPtr_m_lastGameSlotClickEvent;

	// Token: 0x040011DA RID: 4570
	private static readonly IntPtr NativeFieldInfoPtr_m_lastGameSlotSelected;

	// Token: 0x040011DB RID: 4571
	private static readonly IntPtr NativeFieldInfoPtr_m_playerFilter;

	// Token: 0x040011DC RID: 4572
	private static readonly IntPtr NativeFieldInfoPtr_m_timerIndex;

	// Token: 0x040011DD RID: 4573
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterMenu_Public_Void_0;

	// Token: 0x040011DE RID: 4574
	private static readonly IntPtr NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0;

	// Token: 0x040011DF RID: 4575
	private static readonly IntPtr NativeMethodInfoPtr_RetrieveSettings_Private_Void_0;

	// Token: 0x040011E0 RID: 4576
	private static readonly IntPtr NativeMethodInfoPtr_StoreSettings_Private_Void_0;

	// Token: 0x040011E1 RID: 4577
	private static readonly IntPtr NativeMethodInfoPtr_OnConfirmButtonPressed_Public_Void_Boolean_0;

	// Token: 0x040011E2 RID: 4578
	private static readonly IntPtr NativeMethodInfoPtr_UpdateButtonText_Public_Void_0;

	// Token: 0x040011E3 RID: 4579
	private static readonly IntPtr NativeMethodInfoPtr_HandlePlayerToggle_Public_Void_Int32_0;

	// Token: 0x040011E4 RID: 4580
	private static readonly IntPtr NativeMethodInfoPtr_HandleTimerToggle_Public_Void_Int32_0;

	// Token: 0x040011E5 RID: 4581
	private static readonly IntPtr NativeMethodInfoPtr_UpdateToggles_Public_Void_0;

	// Token: 0x040011E6 RID: 4582
	private static readonly IntPtr NativeMethodInfoPtr_OnRefreshPressed_Public_Void_0;

	// Token: 0x040011E7 RID: 4583
	private static readonly IntPtr NativeMethodInfoPtr_IgnoreNetworkEvents_Public_Void_0;

	// Token: 0x040011E8 RID: 4584
	private static readonly IntPtr NativeMethodInfoPtr_EnableFindGameList_Public_Void_0;

	// Token: 0x040011E9 RID: 4585
	private static readonly IntPtr NativeMethodInfoPtr_NetworkStart_Protected_Virtual_Void_0;

	// Token: 0x040011EA RID: 4586
	private static readonly IntPtr NativeMethodInfoPtr_NetworkOnDestroy_Protected_Virtual_Void_0;

	// Token: 0x040011EB RID: 4587
	private static readonly IntPtr NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_GameSlot_ClickEventType_0;

	// Token: 0x040011EC RID: 4588
	private static readonly IntPtr NativeMethodInfoPtr_NetworkEventCallback_Protected_Virtual_Void_EventType_Int32_0;

	// Token: 0x040011ED RID: 4589
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001FD RID: 509
	[Serializable]
	public sealed class TimerValue : ValueType
	{
		// Token: 0x06002890 RID: 10384 RVA: 0x00092C18 File Offset: 0x00090E18
		// Note: this type is marked as 'beforefieldinit'.
		static TimerValue()
		{
			Il2CppClassPointerStore<UI_OnlineFindGame.TimerValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_OnlineFindGame>.NativeClassPtr, "TimerValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_OnlineFindGame.TimerValue>.NativeClassPtr);
			UI_OnlineFindGame.TimerValue.NativeFieldInfoPtr_minTimeInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineFindGame.TimerValue>.NativeClassPtr, "minTimeInSeconds");
			UI_OnlineFindGame.TimerValue.NativeFieldInfoPtr_maxTimeInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineFindGame.TimerValue>.NativeClassPtr, "maxTimeInSeconds");
			UI_OnlineFindGame.TimerValue.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OnlineFindGame.TimerValue>.NativeClassPtr, "text");
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x00019051 File Offset: 0x00017251
		public TimerValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x0001905A File Offset: 0x0001725A
		public TimerValue()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_OnlineFindGame.TimerValue>.NativeClassPtr))
		{
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06002893 RID: 10387 RVA: 0x00092C80 File Offset: 0x00090E80
		// (set) Token: 0x06002894 RID: 10388 RVA: 0x0001906C File Offset: 0x0001726C
		public unsafe uint minTimeInSeconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.TimerValue.NativeFieldInfoPtr_minTimeInSeconds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.TimerValue.NativeFieldInfoPtr_minTimeInSeconds)) = value;
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06002895 RID: 10389 RVA: 0x00092CA8 File Offset: 0x00090EA8
		// (set) Token: 0x06002896 RID: 10390 RVA: 0x00019087 File Offset: 0x00017287
		public unsafe uint maxTimeInSeconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.TimerValue.NativeFieldInfoPtr_maxTimeInSeconds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.TimerValue.NativeFieldInfoPtr_maxTimeInSeconds)) = value;
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06002897 RID: 10391 RVA: 0x00092CD0 File Offset: 0x00090ED0
		// (set) Token: 0x06002898 RID: 10392 RVA: 0x000190A2 File Offset: 0x000172A2
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.TimerValue.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OnlineFindGame.TimerValue.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001BE2 RID: 7138
		private static readonly IntPtr NativeFieldInfoPtr_minTimeInSeconds;

		// Token: 0x04001BE3 RID: 7139
		private static readonly IntPtr NativeFieldInfoPtr_maxTimeInSeconds;

		// Token: 0x04001BE4 RID: 7140
		private static readonly IntPtr NativeFieldInfoPtr_text;
	}
}

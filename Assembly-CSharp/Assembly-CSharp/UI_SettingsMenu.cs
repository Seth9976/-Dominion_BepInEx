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

// Token: 0x020000DD RID: 221
public class UI_SettingsMenu : MonoBehaviour
{
	// Token: 0x06001B6E RID: 7022 RVA: 0x0006C4C0 File Offset: 0x0006A6C0
	// Note: this type is marked as 'beforefieldinit'.
	static UI_SettingsMenu()
	{
		Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_SettingsMenu");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr);
		UI_SettingsMenu.NativeFieldInfoPtr_m_screenResolutionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_screenResolutionList");
		UI_SettingsMenu.NativeFieldInfoPtr_m_resolutionListPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_resolutionListPopup");
		UI_SettingsMenu.NativeFieldInfoPtr_m_resolutionConfirmPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_resolutionConfirmPopup");
		UI_SettingsMenu.NativeFieldInfoPtr_m_resolutionConfirmPopupText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_resolutionConfirmPopupText");
		UI_SettingsMenu.NativeFieldInfoPtr_m_resoultionTitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_resoultionTitleText");
		UI_SettingsMenu.NativeFieldInfoPtr_m_resolutionCountdownPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_resolutionCountdownPopup");
		UI_SettingsMenu.NativeFieldInfoPtr_m_resolutionCountdownPopupText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_resolutionCountdownPopupText");
		UI_SettingsMenu.NativeFieldInfoPtr_m_resolutionCountdownPopupTextCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_resolutionCountdownPopupTextCount");
		UI_SettingsMenu.NativeFieldInfoPtr_m_themeToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_themeToggles");
		UI_SettingsMenu.NativeFieldInfoPtr_m_themeLocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_themeLocks");
		UI_SettingsMenu.NativeFieldInfoPtr_m_themeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_themeText");
		UI_SettingsMenu.NativeFieldInfoPtr_m_themeTextGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_themeTextGroup");
		UI_SettingsMenu.NativeFieldInfoPtr_m_themeText2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_themeText2");
		UI_SettingsMenu.NativeFieldInfoPtr_m_themeTextGroup2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_themeTextGroup2");
		UI_SettingsMenu.NativeFieldInfoPtr_m_windowedScreenToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_windowedScreenToggle");
		UI_SettingsMenu.NativeFieldInfoPtr_m_versionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_versionText");
		UI_SettingsMenu.NativeFieldInfoPtr_m_cultistScreamToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_cultistScreamToggle");
		UI_SettingsMenu.NativeFieldInfoPtr_m_animSpeedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_animSpeedText");
		UI_SettingsMenu.NativeFieldInfoPtr_m_animSpeedBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_animSpeedBG");
		UI_SettingsMenu.NativeFieldInfoPtr_m_animSpeedSlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_animSpeedSlow");
		UI_SettingsMenu.NativeFieldInfoPtr_m_animSpeedMed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_animSpeedMed");
		UI_SettingsMenu.NativeFieldInfoPtr_m_animSpeedFast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_animSpeedFast");
		UI_SettingsMenu.NativeFieldInfoPtr_m_gameSpeedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_gameSpeedText");
		UI_SettingsMenu.NativeFieldInfoPtr_m_gameSpeedBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_gameSpeedBG");
		UI_SettingsMenu.NativeFieldInfoPtr_m_gameSpeedSlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_gameSpeedSlow");
		UI_SettingsMenu.NativeFieldInfoPtr_m_gameSpeedMed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_gameSpeedMed");
		UI_SettingsMenu.NativeFieldInfoPtr_m_gameSpeedFast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_gameSpeedFast");
		UI_SettingsMenu.NativeFieldInfoPtr_m_audioSettingsHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_audioSettingsHandler");
		UI_SettingsMenu.NativeFieldInfoPtr_m_musicVolumeSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_musicVolumeSlider");
		UI_SettingsMenu.NativeFieldInfoPtr_m_effectsVolumeSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_effectsVolumeSlider");
		UI_SettingsMenu.NativeFieldInfoPtr_m_screenResolutionSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_screenResolutionSelect");
		UI_SettingsMenu.NativeFieldInfoPtr_m_colorizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_colorizer");
		UI_SettingsMenu.NativeFieldInfoPtr_m_themeInputBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_themeInputBlocker");
		UI_SettingsMenu.NativeFieldInfoPtr_m_ButtonsToDisableOnMobile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_ButtonsToDisableOnMobile");
		UI_SettingsMenu.NativeFieldInfoPtr_m_cardScaleManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_cardScaleManager");
		UI_SettingsMenu.NativeFieldInfoPtr_m_countdownCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_countdownCoroutine");
		UI_SettingsMenu.NativeFieldInfoPtr_m_pendingResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_pendingResolution");
		UI_SettingsMenu.NativeFieldInfoPtr_m_themeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_themeManager");
		UI_SettingsMenu.NativeFieldInfoPtr_m_currentScreenWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_currentScreenWidth");
		UI_SettingsMenu.NativeFieldInfoPtr_m_currentScreenHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_currentScreenHeight");
		UI_SettingsMenu.NativeFieldInfoPtr_m_bIgnoreToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_bIgnoreToggles");
		UI_SettingsMenu.NativeFieldInfoPtr_m_animSpeedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_animSpeedValue");
		UI_SettingsMenu.NativeFieldInfoPtr_m_gameSpeedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_gameSpeedValue");
		UI_SettingsMenu.NativeFieldInfoPtr_m_bHandleThemeTextSwap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_bHandleThemeTextSwap");
		UI_SettingsMenu.NativeFieldInfoPtr_m_bSwapFrom2To1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_bSwapFrom2To1");
		UI_SettingsMenu.NativeFieldInfoPtr_m_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "m_currentTime");
		UI_SettingsMenu.NativeMethodInfoPtr_OnEnterMenu_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665461);
		UI_SettingsMenu.NativeMethodInfoPtr_OnExitMenu_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665462);
		UI_SettingsMenu.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665463);
		UI_SettingsMenu.NativeMethodInfoPtr_UpdateThemeName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665464);
		UI_SettingsMenu.NativeMethodInfoPtr_OnThemeTogglePressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665465);
		UI_SettingsMenu.NativeMethodInfoPtr_GetThemeShortName_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665466);
		UI_SettingsMenu.NativeMethodInfoPtr_DisableThemeBlocker_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665467);
		UI_SettingsMenu.NativeMethodInfoPtr_OnVolumeSettingsChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665468);
		UI_SettingsMenu.NativeMethodInfoPtr_OnAnimSpeedButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665469);
		UI_SettingsMenu.NativeMethodInfoPtr_OnAnimSpeedChanged_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665470);
		UI_SettingsMenu.NativeMethodInfoPtr_OnGameSpeedButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665471);
		UI_SettingsMenu.NativeMethodInfoPtr_OnGameSpeedChanged_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665472);
		UI_SettingsMenu.NativeMethodInfoPtr_OnResolutionPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665473);
		UI_SettingsMenu.NativeMethodInfoPtr_Notified_Public_Virtual_Final_New_Void_PopupNotificationType_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665474);
		UI_SettingsMenu.NativeMethodInfoPtr_HandleWindowModeChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665475);
		UI_SettingsMenu.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665476);
		UI_SettingsMenu.NativeMethodInfoPtr_CheckThemeManager_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665477);
		UI_SettingsMenu.NativeMethodInfoPtr_HandleResolutionSelection_Protected_Void_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665478);
		UI_SettingsMenu.NativeMethodInfoPtr_ResolutionCountdownTimerHandler_Protected_IEnumerator_Single_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665479);
		UI_SettingsMenu.NativeMethodInfoPtr_OnAchievementsButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665480);
		UI_SettingsMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, 100665481);
	}

	// Token: 0x06001B6F RID: 7023 RVA: 0x0006CA2C File Offset: 0x0006AC2C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 253034, RefRangeEnd = 253035, XrefRangeStart = 252957, XrefRangeEnd = 253034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnEnterMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_SettingsMenu.NativeMethodInfoPtr_OnEnterMenu_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B70 RID: 7024 RVA: 0x0006CA68 File Offset: 0x0006AC68
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 253056, RefRangeEnd = 253057, XrefRangeStart = 253035, XrefRangeEnd = 253056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnExitMenu(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UI_SettingsMenu.NativeMethodInfoPtr_OnExitMenu_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001B71 RID: 7025 RVA: 0x0006CAB4 File Offset: 0x0006ACB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253057, XrefRangeEnd = 253077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B72 RID: 7026 RVA: 0x0006CAE8 File Offset: 0x0006ACE8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 253124, RefRangeEnd = 253126, XrefRangeStart = 253077, XrefRangeEnd = 253124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateThemeName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu.NativeMethodInfoPtr_UpdateThemeName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B73 RID: 7027 RVA: 0x0006CB1C File Offset: 0x0006AD1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253126, XrefRangeEnd = 253159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnThemeTogglePressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu.NativeMethodInfoPtr_OnThemeTogglePressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B74 RID: 7028 RVA: 0x0006CB50 File Offset: 0x0006AD50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253159, XrefRangeEnd = 253176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetThemeShortName(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu.NativeMethodInfoPtr_GetThemeShortName_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06001B75 RID: 7029 RVA: 0x0006CB94 File Offset: 0x0006AD94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253176, XrefRangeEnd = 253180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator DisableThemeBlocker()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu.NativeMethodInfoPtr_DisableThemeBlocker_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06001B76 RID: 7030 RVA: 0x0006CBD4 File Offset: 0x0006ADD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253180, XrefRangeEnd = 253185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnVolumeSettingsChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu.NativeMethodInfoPtr_OnVolumeSettingsChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B77 RID: 7031 RVA: 0x0006CC08 File Offset: 0x0006AE08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253185, XrefRangeEnd = 253186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAnimSpeedButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu.NativeMethodInfoPtr_OnAnimSpeedButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B78 RID: 7032 RVA: 0x0006CC3C File Offset: 0x0006AE3C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 253190, RefRangeEnd = 253192, XrefRangeStart = 253186, XrefRangeEnd = 253190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAnimSpeedChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu.NativeMethodInfoPtr_OnAnimSpeedChanged_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B79 RID: 7033 RVA: 0x0006CC70 File Offset: 0x0006AE70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253192, XrefRangeEnd = 253193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGameSpeedButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu.NativeMethodInfoPtr_OnGameSpeedButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B7A RID: 7034 RVA: 0x0006CCA4 File Offset: 0x0006AEA4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 253198, RefRangeEnd = 253200, XrefRangeStart = 253193, XrefRangeEnd = 253198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGameSpeedChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu.NativeMethodInfoPtr_OnGameSpeedChanged_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B7B RID: 7035 RVA: 0x0006CCD8 File Offset: 0x0006AED8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253200, XrefRangeEnd = 253202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnResolutionPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu.NativeMethodInfoPtr_OnResolutionPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B7C RID: 7036 RVA: 0x0006CD0C File Offset: 0x0006AF0C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253202, XrefRangeEnd = 253222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu.NativeMethodInfoPtr_Notified_Public_Virtual_Final_New_Void_PopupNotificationType_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B7D RID: 7037 RVA: 0x0006CD70 File Offset: 0x0006AF70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253222, XrefRangeEnd = 253227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleWindowModeChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu.NativeMethodInfoPtr_HandleWindowModeChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B7E RID: 7038 RVA: 0x0006CDA4 File Offset: 0x0006AFA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253227, XrefRangeEnd = 253233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B7F RID: 7039 RVA: 0x0006CDD8 File Offset: 0x0006AFD8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 253246, RefRangeEnd = 253248, XrefRangeStart = 253233, XrefRangeEnd = 253246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckThemeManager()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu.NativeMethodInfoPtr_CheckThemeManager_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B80 RID: 7040 RVA: 0x0006CE0C File Offset: 0x0006B00C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253248, XrefRangeEnd = 253255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleResolutionSelection(Resolution selectedResolution)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref selectedResolution;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu.NativeMethodInfoPtr_HandleResolutionSelection_Protected_Void_Resolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001B81 RID: 7041 RVA: 0x0006CE4C File Offset: 0x0006B04C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253255, XrefRangeEnd = 253259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ResolutionCountdownTimerHandler(float totalTime, TextMeshProUGUI textObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref totalTime;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(textObject);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu.NativeMethodInfoPtr_ResolutionCountdownTimerHandler_Protected_IEnumerator_Single_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06001B82 RID: 7042 RVA: 0x0006CEAC File Offset: 0x0006B0AC
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAchievementsButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu.NativeMethodInfoPtr_OnAchievementsButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B83 RID: 7043 RVA: 0x0006CEE0 File Offset: 0x0006B0E0
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_SettingsMenu()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001B84 RID: 7044 RVA: 0x000119F0 File Offset: 0x0000FBF0
	public UI_SettingsMenu(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170008C8 RID: 2248
	// (get) Token: 0x06001B85 RID: 7045 RVA: 0x0006CF1C File Offset: 0x0006B11C
	// (set) Token: 0x06001B86 RID: 7046 RVA: 0x000119F9 File Offset: 0x0000FBF9
	public unsafe UIC_ScreenResolutionList m_screenResolutionList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_screenResolutionList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_ScreenResolutionList>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_screenResolutionList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008C9 RID: 2249
	// (get) Token: 0x06001B87 RID: 7047 RVA: 0x0006CF4C File Offset: 0x0006B14C
	// (set) Token: 0x06001B88 RID: 7048 RVA: 0x00011A18 File Offset: 0x0000FC18
	public unsafe RegisterPopup m_resolutionListPopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_resolutionListPopup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegisterPopup>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_resolutionListPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008CA RID: 2250
	// (get) Token: 0x06001B89 RID: 7049 RVA: 0x0006CF7C File Offset: 0x0006B17C
	// (set) Token: 0x06001B8A RID: 7050 RVA: 0x00011A37 File Offset: 0x0000FC37
	public unsafe RegisterPopup m_resolutionConfirmPopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_resolutionConfirmPopup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegisterPopup>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_resolutionConfirmPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008CB RID: 2251
	// (get) Token: 0x06001B8B RID: 7051 RVA: 0x0006CFAC File Offset: 0x0006B1AC
	// (set) Token: 0x06001B8C RID: 7052 RVA: 0x00011A56 File Offset: 0x0000FC56
	public unsafe TextMeshProUGUI m_resolutionConfirmPopupText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_resolutionConfirmPopupText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_resolutionConfirmPopupText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008CC RID: 2252
	// (get) Token: 0x06001B8D RID: 7053 RVA: 0x0006CFDC File Offset: 0x0006B1DC
	// (set) Token: 0x06001B8E RID: 7054 RVA: 0x00011A75 File Offset: 0x0000FC75
	public unsafe TextMeshProUGUI m_resoultionTitleText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_resoultionTitleText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_resoultionTitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008CD RID: 2253
	// (get) Token: 0x06001B8F RID: 7055 RVA: 0x0006D00C File Offset: 0x0006B20C
	// (set) Token: 0x06001B90 RID: 7056 RVA: 0x00011A94 File Offset: 0x0000FC94
	public unsafe RegisterPopup m_resolutionCountdownPopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_resolutionCountdownPopup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegisterPopup>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_resolutionCountdownPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008CE RID: 2254
	// (get) Token: 0x06001B91 RID: 7057 RVA: 0x0006D03C File Offset: 0x0006B23C
	// (set) Token: 0x06001B92 RID: 7058 RVA: 0x00011AB3 File Offset: 0x0000FCB3
	public unsafe TextMeshProUGUI m_resolutionCountdownPopupText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_resolutionCountdownPopupText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_resolutionCountdownPopupText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008CF RID: 2255
	// (get) Token: 0x06001B93 RID: 7059 RVA: 0x0006D06C File Offset: 0x0006B26C
	// (set) Token: 0x06001B94 RID: 7060 RVA: 0x00011AD2 File Offset: 0x0000FCD2
	public unsafe TextMeshProUGUI m_resolutionCountdownPopupTextCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_resolutionCountdownPopupTextCount);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_resolutionCountdownPopupTextCount), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008D0 RID: 2256
	// (get) Token: 0x06001B95 RID: 7061 RVA: 0x0006D09C File Offset: 0x0006B29C
	// (set) Token: 0x06001B96 RID: 7062 RVA: 0x00011AF1 File Offset: 0x0000FCF1
	public unsafe Il2CppReferenceArray<Toggle> m_themeToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_themeToggles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Toggle>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_themeToggles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008D1 RID: 2257
	// (get) Token: 0x06001B97 RID: 7063 RVA: 0x0006D0CC File Offset: 0x0006B2CC
	// (set) Token: 0x06001B98 RID: 7064 RVA: 0x00011B10 File Offset: 0x0000FD10
	public unsafe Il2CppReferenceArray<GameObject> m_themeLocks
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_themeLocks);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_themeLocks), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008D2 RID: 2258
	// (get) Token: 0x06001B99 RID: 7065 RVA: 0x0006D0FC File Offset: 0x0006B2FC
	// (set) Token: 0x06001B9A RID: 7066 RVA: 0x00011B2F File Offset: 0x0000FD2F
	public unsafe TextMeshProUGUI m_themeText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_themeText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_themeText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008D3 RID: 2259
	// (get) Token: 0x06001B9B RID: 7067 RVA: 0x0006D12C File Offset: 0x0006B32C
	// (set) Token: 0x06001B9C RID: 7068 RVA: 0x00011B4E File Offset: 0x0000FD4E
	public unsafe CanvasGroup m_themeTextGroup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_themeTextGroup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_themeTextGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008D4 RID: 2260
	// (get) Token: 0x06001B9D RID: 7069 RVA: 0x0006D15C File Offset: 0x0006B35C
	// (set) Token: 0x06001B9E RID: 7070 RVA: 0x00011B6D File Offset: 0x0000FD6D
	public unsafe TextMeshProUGUI m_themeText2
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_themeText2);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_themeText2), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008D5 RID: 2261
	// (get) Token: 0x06001B9F RID: 7071 RVA: 0x0006D18C File Offset: 0x0006B38C
	// (set) Token: 0x06001BA0 RID: 7072 RVA: 0x00011B8C File Offset: 0x0000FD8C
	public unsafe CanvasGroup m_themeTextGroup2
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_themeTextGroup2);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_themeTextGroup2), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008D6 RID: 2262
	// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x0006D1BC File Offset: 0x0006B3BC
	// (set) Token: 0x06001BA2 RID: 7074 RVA: 0x00011BAB File Offset: 0x0000FDAB
	public unsafe Toggle m_windowedScreenToggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_windowedScreenToggle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_windowedScreenToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008D7 RID: 2263
	// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x0006D1EC File Offset: 0x0006B3EC
	// (set) Token: 0x06001BA4 RID: 7076 RVA: 0x00011BCA File Offset: 0x0000FDCA
	public unsafe TextMeshProUGUI m_versionText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_versionText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_versionText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008D8 RID: 2264
	// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x0006D21C File Offset: 0x0006B41C
	// (set) Token: 0x06001BA6 RID: 7078 RVA: 0x00011BE9 File Offset: 0x0000FDE9
	public unsafe Toggle m_cultistScreamToggle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_cultistScreamToggle);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_cultistScreamToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008D9 RID: 2265
	// (get) Token: 0x06001BA7 RID: 7079 RVA: 0x0006D24C File Offset: 0x0006B44C
	// (set) Token: 0x06001BA8 RID: 7080 RVA: 0x00011C08 File Offset: 0x0000FE08
	public unsafe TextMeshProUGUI m_animSpeedText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_animSpeedText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_animSpeedText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008DA RID: 2266
	// (get) Token: 0x06001BA9 RID: 7081 RVA: 0x0006D27C File Offset: 0x0006B47C
	// (set) Token: 0x06001BAA RID: 7082 RVA: 0x00011C27 File Offset: 0x0000FE27
	public unsafe Image m_animSpeedBG
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_animSpeedBG);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_animSpeedBG), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008DB RID: 2267
	// (get) Token: 0x06001BAB RID: 7083 RVA: 0x0006D2AC File Offset: 0x0006B4AC
	// (set) Token: 0x06001BAC RID: 7084 RVA: 0x00011C46 File Offset: 0x0000FE46
	public unsafe Color m_animSpeedSlow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_animSpeedSlow);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_animSpeedSlow)) = value;
		}
	}

	// Token: 0x170008DC RID: 2268
	// (get) Token: 0x06001BAD RID: 7085 RVA: 0x0006D2D4 File Offset: 0x0006B4D4
	// (set) Token: 0x06001BAE RID: 7086 RVA: 0x00011C61 File Offset: 0x0000FE61
	public unsafe Color m_animSpeedMed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_animSpeedMed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_animSpeedMed)) = value;
		}
	}

	// Token: 0x170008DD RID: 2269
	// (get) Token: 0x06001BAF RID: 7087 RVA: 0x0006D2FC File Offset: 0x0006B4FC
	// (set) Token: 0x06001BB0 RID: 7088 RVA: 0x00011C7C File Offset: 0x0000FE7C
	public unsafe Color m_animSpeedFast
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_animSpeedFast);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_animSpeedFast)) = value;
		}
	}

	// Token: 0x170008DE RID: 2270
	// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x0006D324 File Offset: 0x0006B524
	// (set) Token: 0x06001BB2 RID: 7090 RVA: 0x00011C97 File Offset: 0x0000FE97
	public unsafe TextMeshProUGUI m_gameSpeedText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_gameSpeedText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_gameSpeedText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008DF RID: 2271
	// (get) Token: 0x06001BB3 RID: 7091 RVA: 0x0006D354 File Offset: 0x0006B554
	// (set) Token: 0x06001BB4 RID: 7092 RVA: 0x00011CB6 File Offset: 0x0000FEB6
	public unsafe Image m_gameSpeedBG
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_gameSpeedBG);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_gameSpeedBG), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008E0 RID: 2272
	// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x0006D384 File Offset: 0x0006B584
	// (set) Token: 0x06001BB6 RID: 7094 RVA: 0x00011CD5 File Offset: 0x0000FED5
	public unsafe Color m_gameSpeedSlow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_gameSpeedSlow);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_gameSpeedSlow)) = value;
		}
	}

	// Token: 0x170008E1 RID: 2273
	// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x0006D3AC File Offset: 0x0006B5AC
	// (set) Token: 0x06001BB8 RID: 7096 RVA: 0x00011CF0 File Offset: 0x0000FEF0
	public unsafe Color m_gameSpeedMed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_gameSpeedMed);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_gameSpeedMed)) = value;
		}
	}

	// Token: 0x170008E2 RID: 2274
	// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x0006D3D4 File Offset: 0x0006B5D4
	// (set) Token: 0x06001BBA RID: 7098 RVA: 0x00011D0B File Offset: 0x0000FF0B
	public unsafe Color m_gameSpeedFast
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_gameSpeedFast);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_gameSpeedFast)) = value;
		}
	}

	// Token: 0x170008E3 RID: 2275
	// (get) Token: 0x06001BBB RID: 7099 RVA: 0x0006D3FC File Offset: 0x0006B5FC
	// (set) Token: 0x06001BBC RID: 7100 RVA: 0x00011D26 File Offset: 0x0000FF26
	public unsafe AudioSettingsHandler m_audioSettingsHandler
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_audioSettingsHandler);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSettingsHandler>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_audioSettingsHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008E4 RID: 2276
	// (get) Token: 0x06001BBD RID: 7101 RVA: 0x0006D42C File Offset: 0x0006B62C
	// (set) Token: 0x06001BBE RID: 7102 RVA: 0x00011D45 File Offset: 0x0000FF45
	public unsafe Slider m_musicVolumeSlider
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_musicVolumeSlider);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_musicVolumeSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008E5 RID: 2277
	// (get) Token: 0x06001BBF RID: 7103 RVA: 0x0006D45C File Offset: 0x0006B65C
	// (set) Token: 0x06001BC0 RID: 7104 RVA: 0x00011D64 File Offset: 0x0000FF64
	public unsafe Slider m_effectsVolumeSlider
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_effectsVolumeSlider);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_effectsVolumeSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008E6 RID: 2278
	// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x0006D48C File Offset: 0x0006B68C
	// (set) Token: 0x06001BC2 RID: 7106 RVA: 0x00011D83 File Offset: 0x0000FF83
	public unsafe AudioSource m_screenResolutionSelect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_screenResolutionSelect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_screenResolutionSelect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008E7 RID: 2279
	// (get) Token: 0x06001BC3 RID: 7107 RVA: 0x0006D4BC File Offset: 0x0006B6BC
	// (set) Token: 0x06001BC4 RID: 7108 RVA: 0x00011DA2 File Offset: 0x0000FFA2
	public unsafe ColorByFaction m_colorizer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_colorizer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorByFaction>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_colorizer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008E8 RID: 2280
	// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x0006D4EC File Offset: 0x0006B6EC
	// (set) Token: 0x06001BC6 RID: 7110 RVA: 0x00011DC1 File Offset: 0x0000FFC1
	public unsafe GameObject m_themeInputBlocker
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_themeInputBlocker);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_themeInputBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008E9 RID: 2281
	// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x0006D51C File Offset: 0x0006B71C
	// (set) Token: 0x06001BC8 RID: 7112 RVA: 0x00011DE0 File Offset: 0x0000FFE0
	public unsafe Il2CppReferenceArray<GameObject> m_ButtonsToDisableOnMobile
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_ButtonsToDisableOnMobile);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_ButtonsToDisableOnMobile), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008EA RID: 2282
	// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x0006D54C File Offset: 0x0006B74C
	// (set) Token: 0x06001BCA RID: 7114 RVA: 0x00011DFF File Offset: 0x0000FFFF
	public unsafe AdjustCardScaleManager m_cardScaleManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_cardScaleManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdjustCardScaleManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_cardScaleManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008EB RID: 2283
	// (get) Token: 0x06001BCB RID: 7115 RVA: 0x0006D57C File Offset: 0x0006B77C
	// (set) Token: 0x06001BCC RID: 7116 RVA: 0x00011E1E File Offset: 0x0001001E
	public unsafe Coroutine m_countdownCoroutine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_countdownCoroutine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_countdownCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008EC RID: 2284
	// (get) Token: 0x06001BCD RID: 7117 RVA: 0x0006D5AC File Offset: 0x0006B7AC
	// (set) Token: 0x06001BCE RID: 7118 RVA: 0x00011E3D File Offset: 0x0001003D
	public unsafe Resolution m_pendingResolution
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_pendingResolution);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_pendingResolution)) = value;
		}
	}

	// Token: 0x170008ED RID: 2285
	// (get) Token: 0x06001BCF RID: 7119 RVA: 0x0006D5D4 File Offset: 0x0006B7D4
	// (set) Token: 0x06001BD0 RID: 7120 RVA: 0x00011E58 File Offset: 0x00010058
	public unsafe ThemeManager m_themeManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_themeManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_themeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170008EE RID: 2286
	// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x0006D604 File Offset: 0x0006B804
	// (set) Token: 0x06001BD2 RID: 7122 RVA: 0x00011E77 File Offset: 0x00010077
	public unsafe int m_currentScreenWidth
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_currentScreenWidth);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_currentScreenWidth)) = value;
		}
	}

	// Token: 0x170008EF RID: 2287
	// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x0006D62C File Offset: 0x0006B82C
	// (set) Token: 0x06001BD4 RID: 7124 RVA: 0x00011E92 File Offset: 0x00010092
	public unsafe int m_currentScreenHeight
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_currentScreenHeight);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_currentScreenHeight)) = value;
		}
	}

	// Token: 0x170008F0 RID: 2288
	// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x0006D654 File Offset: 0x0006B854
	// (set) Token: 0x06001BD6 RID: 7126 RVA: 0x00011EAD File Offset: 0x000100AD
	public unsafe bool m_bIgnoreToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_bIgnoreToggles);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_bIgnoreToggles)) = value;
		}
	}

	// Token: 0x170008F1 RID: 2289
	// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x0006D67C File Offset: 0x0006B87C
	// (set) Token: 0x06001BD8 RID: 7128 RVA: 0x00011EC8 File Offset: 0x000100C8
	public unsafe float m_animSpeedValue
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_animSpeedValue);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_animSpeedValue)) = value;
		}
	}

	// Token: 0x170008F2 RID: 2290
	// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x0006D6A4 File Offset: 0x0006B8A4
	// (set) Token: 0x06001BDA RID: 7130 RVA: 0x00011EE3 File Offset: 0x000100E3
	public unsafe int m_gameSpeedValue
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_gameSpeedValue);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_gameSpeedValue)) = value;
		}
	}

	// Token: 0x170008F3 RID: 2291
	// (get) Token: 0x06001BDB RID: 7131 RVA: 0x0006D6CC File Offset: 0x0006B8CC
	// (set) Token: 0x06001BDC RID: 7132 RVA: 0x00011EFE File Offset: 0x000100FE
	public unsafe bool m_bHandleThemeTextSwap
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_bHandleThemeTextSwap);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_bHandleThemeTextSwap)) = value;
		}
	}

	// Token: 0x170008F4 RID: 2292
	// (get) Token: 0x06001BDD RID: 7133 RVA: 0x0006D6F4 File Offset: 0x0006B8F4
	// (set) Token: 0x06001BDE RID: 7134 RVA: 0x00011F19 File Offset: 0x00010119
	public unsafe bool m_bSwapFrom2To1
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_bSwapFrom2To1);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_bSwapFrom2To1)) = value;
		}
	}

	// Token: 0x170008F5 RID: 2293
	// (get) Token: 0x06001BDF RID: 7135 RVA: 0x0006D71C File Offset: 0x0006B91C
	// (set) Token: 0x06001BE0 RID: 7136 RVA: 0x00011F34 File Offset: 0x00010134
	public unsafe float m_currentTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_currentTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu.NativeFieldInfoPtr_m_currentTime)) = value;
		}
	}

	// Token: 0x0400128F RID: 4751
	private static readonly IntPtr NativeFieldInfoPtr_m_screenResolutionList;

	// Token: 0x04001290 RID: 4752
	private static readonly IntPtr NativeFieldInfoPtr_m_resolutionListPopup;

	// Token: 0x04001291 RID: 4753
	private static readonly IntPtr NativeFieldInfoPtr_m_resolutionConfirmPopup;

	// Token: 0x04001292 RID: 4754
	private static readonly IntPtr NativeFieldInfoPtr_m_resolutionConfirmPopupText;

	// Token: 0x04001293 RID: 4755
	private static readonly IntPtr NativeFieldInfoPtr_m_resoultionTitleText;

	// Token: 0x04001294 RID: 4756
	private static readonly IntPtr NativeFieldInfoPtr_m_resolutionCountdownPopup;

	// Token: 0x04001295 RID: 4757
	private static readonly IntPtr NativeFieldInfoPtr_m_resolutionCountdownPopupText;

	// Token: 0x04001296 RID: 4758
	private static readonly IntPtr NativeFieldInfoPtr_m_resolutionCountdownPopupTextCount;

	// Token: 0x04001297 RID: 4759
	private static readonly IntPtr NativeFieldInfoPtr_m_themeToggles;

	// Token: 0x04001298 RID: 4760
	private static readonly IntPtr NativeFieldInfoPtr_m_themeLocks;

	// Token: 0x04001299 RID: 4761
	private static readonly IntPtr NativeFieldInfoPtr_m_themeText;

	// Token: 0x0400129A RID: 4762
	private static readonly IntPtr NativeFieldInfoPtr_m_themeTextGroup;

	// Token: 0x0400129B RID: 4763
	private static readonly IntPtr NativeFieldInfoPtr_m_themeText2;

	// Token: 0x0400129C RID: 4764
	private static readonly IntPtr NativeFieldInfoPtr_m_themeTextGroup2;

	// Token: 0x0400129D RID: 4765
	private static readonly IntPtr NativeFieldInfoPtr_m_windowedScreenToggle;

	// Token: 0x0400129E RID: 4766
	private static readonly IntPtr NativeFieldInfoPtr_m_versionText;

	// Token: 0x0400129F RID: 4767
	private static readonly IntPtr NativeFieldInfoPtr_m_cultistScreamToggle;

	// Token: 0x040012A0 RID: 4768
	private static readonly IntPtr NativeFieldInfoPtr_m_animSpeedText;

	// Token: 0x040012A1 RID: 4769
	private static readonly IntPtr NativeFieldInfoPtr_m_animSpeedBG;

	// Token: 0x040012A2 RID: 4770
	private static readonly IntPtr NativeFieldInfoPtr_m_animSpeedSlow;

	// Token: 0x040012A3 RID: 4771
	private static readonly IntPtr NativeFieldInfoPtr_m_animSpeedMed;

	// Token: 0x040012A4 RID: 4772
	private static readonly IntPtr NativeFieldInfoPtr_m_animSpeedFast;

	// Token: 0x040012A5 RID: 4773
	private static readonly IntPtr NativeFieldInfoPtr_m_gameSpeedText;

	// Token: 0x040012A6 RID: 4774
	private static readonly IntPtr NativeFieldInfoPtr_m_gameSpeedBG;

	// Token: 0x040012A7 RID: 4775
	private static readonly IntPtr NativeFieldInfoPtr_m_gameSpeedSlow;

	// Token: 0x040012A8 RID: 4776
	private static readonly IntPtr NativeFieldInfoPtr_m_gameSpeedMed;

	// Token: 0x040012A9 RID: 4777
	private static readonly IntPtr NativeFieldInfoPtr_m_gameSpeedFast;

	// Token: 0x040012AA RID: 4778
	private static readonly IntPtr NativeFieldInfoPtr_m_audioSettingsHandler;

	// Token: 0x040012AB RID: 4779
	private static readonly IntPtr NativeFieldInfoPtr_m_musicVolumeSlider;

	// Token: 0x040012AC RID: 4780
	private static readonly IntPtr NativeFieldInfoPtr_m_effectsVolumeSlider;

	// Token: 0x040012AD RID: 4781
	private static readonly IntPtr NativeFieldInfoPtr_m_screenResolutionSelect;

	// Token: 0x040012AE RID: 4782
	private static readonly IntPtr NativeFieldInfoPtr_m_colorizer;

	// Token: 0x040012AF RID: 4783
	private static readonly IntPtr NativeFieldInfoPtr_m_themeInputBlocker;

	// Token: 0x040012B0 RID: 4784
	private static readonly IntPtr NativeFieldInfoPtr_m_ButtonsToDisableOnMobile;

	// Token: 0x040012B1 RID: 4785
	private static readonly IntPtr NativeFieldInfoPtr_m_cardScaleManager;

	// Token: 0x040012B2 RID: 4786
	private static readonly IntPtr NativeFieldInfoPtr_m_countdownCoroutine;

	// Token: 0x040012B3 RID: 4787
	private static readonly IntPtr NativeFieldInfoPtr_m_pendingResolution;

	// Token: 0x040012B4 RID: 4788
	private static readonly IntPtr NativeFieldInfoPtr_m_themeManager;

	// Token: 0x040012B5 RID: 4789
	private static readonly IntPtr NativeFieldInfoPtr_m_currentScreenWidth;

	// Token: 0x040012B6 RID: 4790
	private static readonly IntPtr NativeFieldInfoPtr_m_currentScreenHeight;

	// Token: 0x040012B7 RID: 4791
	private static readonly IntPtr NativeFieldInfoPtr_m_bIgnoreToggles;

	// Token: 0x040012B8 RID: 4792
	private static readonly IntPtr NativeFieldInfoPtr_m_animSpeedValue;

	// Token: 0x040012B9 RID: 4793
	private static readonly IntPtr NativeFieldInfoPtr_m_gameSpeedValue;

	// Token: 0x040012BA RID: 4794
	private static readonly IntPtr NativeFieldInfoPtr_m_bHandleThemeTextSwap;

	// Token: 0x040012BB RID: 4795
	private static readonly IntPtr NativeFieldInfoPtr_m_bSwapFrom2To1;

	// Token: 0x040012BC RID: 4796
	private static readonly IntPtr NativeFieldInfoPtr_m_currentTime;

	// Token: 0x040012BD RID: 4797
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterMenu_Public_Virtual_New_Void_0;

	// Token: 0x040012BE RID: 4798
	private static readonly IntPtr NativeMethodInfoPtr_OnExitMenu_Public_Virtual_New_Void_Boolean_0;

	// Token: 0x040012BF RID: 4799
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x040012C0 RID: 4800
	private static readonly IntPtr NativeMethodInfoPtr_UpdateThemeName_Private_Void_0;

	// Token: 0x040012C1 RID: 4801
	private static readonly IntPtr NativeMethodInfoPtr_OnThemeTogglePressed_Public_Void_0;

	// Token: 0x040012C2 RID: 4802
	private static readonly IntPtr NativeMethodInfoPtr_GetThemeShortName_Private_String_Int32_0;

	// Token: 0x040012C3 RID: 4803
	private static readonly IntPtr NativeMethodInfoPtr_DisableThemeBlocker_Private_IEnumerator_0;

	// Token: 0x040012C4 RID: 4804
	private static readonly IntPtr NativeMethodInfoPtr_OnVolumeSettingsChanged_Public_Void_0;

	// Token: 0x040012C5 RID: 4805
	private static readonly IntPtr NativeMethodInfoPtr_OnAnimSpeedButtonPressed_Public_Void_0;

	// Token: 0x040012C6 RID: 4806
	private static readonly IntPtr NativeMethodInfoPtr_OnAnimSpeedChanged_Protected_Void_0;

	// Token: 0x040012C7 RID: 4807
	private static readonly IntPtr NativeMethodInfoPtr_OnGameSpeedButtonPressed_Public_Void_0;

	// Token: 0x040012C8 RID: 4808
	private static readonly IntPtr NativeMethodInfoPtr_OnGameSpeedChanged_Protected_Void_0;

	// Token: 0x040012C9 RID: 4809
	private static readonly IntPtr NativeMethodInfoPtr_OnResolutionPressed_Public_Void_0;

	// Token: 0x040012CA RID: 4810
	private static readonly IntPtr NativeMethodInfoPtr_Notified_Public_Virtual_Final_New_Void_PopupNotificationType_String_Object_0;

	// Token: 0x040012CB RID: 4811
	private static readonly IntPtr NativeMethodInfoPtr_HandleWindowModeChange_Public_Void_0;

	// Token: 0x040012CC RID: 4812
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040012CD RID: 4813
	private static readonly IntPtr NativeMethodInfoPtr_CheckThemeManager_Protected_Void_0;

	// Token: 0x040012CE RID: 4814
	private static readonly IntPtr NativeMethodInfoPtr_HandleResolutionSelection_Protected_Void_Resolution_0;

	// Token: 0x040012CF RID: 4815
	private static readonly IntPtr NativeMethodInfoPtr_ResolutionCountdownTimerHandler_Protected_IEnumerator_Single_TextMeshProUGUI_0;

	// Token: 0x040012D0 RID: 4816
	private static readonly IntPtr NativeMethodInfoPtr_OnAchievementsButtonPressed_Public_Void_0;

	// Token: 0x040012D1 RID: 4817
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000205 RID: 517
	[ObfuscatedName("UI_SettingsMenu+<DisableThemeBlocker>d__52")]
	public sealed class _DisableThemeBlocker_d__52 : global::Il2CppSystem.Object
	{
		// Token: 0x0600290C RID: 10508 RVA: 0x0009418C File Offset: 0x0009238C
		// Note: this type is marked as 'beforefieldinit'.
		static _DisableThemeBlocker_d__52()
		{
			Il2CppClassPointerStore<UI_SettingsMenu._DisableThemeBlocker_d__52>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "<DisableThemeBlocker>d__52");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_SettingsMenu._DisableThemeBlocker_d__52>.NativeClassPtr);
			UI_SettingsMenu._DisableThemeBlocker_d__52.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu._DisableThemeBlocker_d__52>.NativeClassPtr, "<>1__state");
			UI_SettingsMenu._DisableThemeBlocker_d__52.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu._DisableThemeBlocker_d__52>.NativeClassPtr, "<>2__current");
			UI_SettingsMenu._DisableThemeBlocker_d__52.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu._DisableThemeBlocker_d__52>.NativeClassPtr, "<>4__this");
			UI_SettingsMenu._DisableThemeBlocker_d__52.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu._DisableThemeBlocker_d__52>.NativeClassPtr, 100666522);
			UI_SettingsMenu._DisableThemeBlocker_d__52.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu._DisableThemeBlocker_d__52>.NativeClassPtr, 100666523);
			UI_SettingsMenu._DisableThemeBlocker_d__52.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu._DisableThemeBlocker_d__52>.NativeClassPtr, 100666524);
			UI_SettingsMenu._DisableThemeBlocker_d__52.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu._DisableThemeBlocker_d__52>.NativeClassPtr, 100666525);
			UI_SettingsMenu._DisableThemeBlocker_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu._DisableThemeBlocker_d__52>.NativeClassPtr, 100666526);
			UI_SettingsMenu._DisableThemeBlocker_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu._DisableThemeBlocker_d__52>.NativeClassPtr, 100666527);
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x0009426C File Offset: 0x0009246C
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _DisableThemeBlocker_d__52(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_SettingsMenu._DisableThemeBlocker_d__52>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu._DisableThemeBlocker_d__52.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x000942B4 File Offset: 0x000924B4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu._DisableThemeBlocker_d__52.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x000942E8 File Offset: 0x000924E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252936, XrefRangeEnd = 252940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu._DisableThemeBlocker_d__52.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06002910 RID: 10512 RVA: 0x00094324 File Offset: 0x00092524
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu._DisableThemeBlocker_d__52.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x00094364 File Offset: 0x00092564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252940, XrefRangeEnd = 252945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu._DisableThemeBlocker_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06002912 RID: 10514 RVA: 0x00094398 File Offset: 0x00092598
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu._DisableThemeBlocker_d__52.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x000194B6 File Offset: 0x000176B6
		public _DisableThemeBlocker_d__52(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06002914 RID: 10516 RVA: 0x000943D8 File Offset: 0x000925D8
		// (set) Token: 0x06002915 RID: 10517 RVA: 0x000194BF File Offset: 0x000176BF
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._DisableThemeBlocker_d__52.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._DisableThemeBlocker_d__52.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06002916 RID: 10518 RVA: 0x00094400 File Offset: 0x00092600
		// (set) Token: 0x06002917 RID: 10519 RVA: 0x000194DA File Offset: 0x000176DA
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._DisableThemeBlocker_d__52.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._DisableThemeBlocker_d__52.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06002918 RID: 10520 RVA: 0x00094430 File Offset: 0x00092630
		// (set) Token: 0x06002919 RID: 10521 RVA: 0x000194F9 File Offset: 0x000176F9
		public unsafe UI_SettingsMenu __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._DisableThemeBlocker_d__52.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_SettingsMenu>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._DisableThemeBlocker_d__52.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C29 RID: 7209
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001C2A RID: 7210
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001C2B RID: 7211
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001C2C RID: 7212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001C2D RID: 7213
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001C2E RID: 7214
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001C2F RID: 7215
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001C30 RID: 7216
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001C31 RID: 7217
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000206 RID: 518
	[ObfuscatedName("UI_SettingsMenu+<ResolutionCountdownTimerHandler>d__64")]
	public sealed class _ResolutionCountdownTimerHandler_d__64 : global::Il2CppSystem.Object
	{
		// Token: 0x0600291A RID: 10522 RVA: 0x00094460 File Offset: 0x00092660
		// Note: this type is marked as 'beforefieldinit'.
		static _ResolutionCountdownTimerHandler_d__64()
		{
			Il2CppClassPointerStore<UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_SettingsMenu>.NativeClassPtr, "<ResolutionCountdownTimerHandler>d__64");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64>.NativeClassPtr);
			UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64>.NativeClassPtr, "<>1__state");
			UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64>.NativeClassPtr, "<>2__current");
			UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr_totalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64>.NativeClassPtr, "totalTime");
			UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr_textObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64>.NativeClassPtr, "textObject");
			UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64>.NativeClassPtr, "<>4__this");
			UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr__previousTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64>.NativeClassPtr, "<previousTime>5__2");
			UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr__timeCounter_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64>.NativeClassPtr, "<timeCounter>5__3");
			UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr__bCounting_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64>.NativeClassPtr, "<bCounting>5__4");
			UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64>.NativeClassPtr, 100666528);
			UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64>.NativeClassPtr, 100666529);
			UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64>.NativeClassPtr, 100666530);
			UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64>.NativeClassPtr, 100666531);
			UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64>.NativeClassPtr, 100666532);
			UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64>.NativeClassPtr, 100666533);
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x000945A4 File Offset: 0x000927A4
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ResolutionCountdownTimerHandler_d__64(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x000945EC File Offset: 0x000927EC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x00094620 File Offset: 0x00092820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252945, XrefRangeEnd = 252952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x0600291E RID: 10526 RVA: 0x0009465C File Offset: 0x0009285C
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x0009469C File Offset: 0x0009289C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252952, XrefRangeEnd = 252957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06002920 RID: 10528 RVA: 0x000946D0 File Offset: 0x000928D0
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x00019518 File Offset: 0x00017718
		public _ResolutionCountdownTimerHandler_d__64(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06002922 RID: 10530 RVA: 0x00094710 File Offset: 0x00092910
		// (set) Token: 0x06002923 RID: 10531 RVA: 0x00019521 File Offset: 0x00017721
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06002924 RID: 10532 RVA: 0x00094738 File Offset: 0x00092938
		// (set) Token: 0x06002925 RID: 10533 RVA: 0x0001953C File Offset: 0x0001773C
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06002926 RID: 10534 RVA: 0x00094768 File Offset: 0x00092968
		// (set) Token: 0x06002927 RID: 10535 RVA: 0x0001955B File Offset: 0x0001775B
		public unsafe float totalTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr_totalTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr_totalTime)) = value;
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06002928 RID: 10536 RVA: 0x00094790 File Offset: 0x00092990
		// (set) Token: 0x06002929 RID: 10537 RVA: 0x00019576 File Offset: 0x00017776
		public unsafe TextMeshProUGUI textObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr_textObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr_textObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x0600292A RID: 10538 RVA: 0x000947C0 File Offset: 0x000929C0
		// (set) Token: 0x0600292B RID: 10539 RVA: 0x00019595 File Offset: 0x00017795
		public unsafe UI_SettingsMenu __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_SettingsMenu>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x0600292C RID: 10540 RVA: 0x000947F0 File Offset: 0x000929F0
		// (set) Token: 0x0600292D RID: 10541 RVA: 0x000195B4 File Offset: 0x000177B4
		public unsafe float _previousTime_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr__previousTime_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr__previousTime_5__2)) = value;
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x0600292E RID: 10542 RVA: 0x00094818 File Offset: 0x00092A18
		// (set) Token: 0x0600292F RID: 10543 RVA: 0x000195CF File Offset: 0x000177CF
		public unsafe float _timeCounter_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr__timeCounter_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr__timeCounter_5__3)) = value;
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06002930 RID: 10544 RVA: 0x00094840 File Offset: 0x00092A40
		// (set) Token: 0x06002931 RID: 10545 RVA: 0x000195EA File Offset: 0x000177EA
		public unsafe bool _bCounting_5__4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr__bCounting_5__4);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_SettingsMenu._ResolutionCountdownTimerHandler_d__64.NativeFieldInfoPtr__bCounting_5__4)) = value;
			}
		}

		// Token: 0x04001C32 RID: 7218
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001C33 RID: 7219
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001C34 RID: 7220
		private static readonly IntPtr NativeFieldInfoPtr_totalTime;

		// Token: 0x04001C35 RID: 7221
		private static readonly IntPtr NativeFieldInfoPtr_textObject;

		// Token: 0x04001C36 RID: 7222
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001C37 RID: 7223
		private static readonly IntPtr NativeFieldInfoPtr__previousTime_5__2;

		// Token: 0x04001C38 RID: 7224
		private static readonly IntPtr NativeFieldInfoPtr__timeCounter_5__3;

		// Token: 0x04001C39 RID: 7225
		private static readonly IntPtr NativeFieldInfoPtr__bCounting_5__4;

		// Token: 0x04001C3A RID: 7226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001C3B RID: 7227
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001C3C RID: 7228
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001C3D RID: 7229
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001C3E RID: 7230
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001C3F RID: 7231
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

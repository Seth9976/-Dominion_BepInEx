using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;

// Token: 0x02000025 RID: 37
public class AscensionPause : UI_SettingsMenu
{
	// Token: 0x0600084A RID: 2122 RVA: 0x0003228C File Offset: 0x0003048C
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionPause()
	{
		Il2CppClassPointerStore<AscensionPause>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionPause");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr);
		AscensionPause.NativeFieldInfoPtr_m_confirmForfeitPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "m_confirmForfeitPopup");
		AscensionPause.NativeFieldInfoPtr_m_cardGalleryAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "m_cardGalleryAnimator");
		AscensionPause.NativeFieldInfoPtr_m_cardGalleryScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "m_cardGalleryScreen");
		AscensionPause.NativeFieldInfoPtr_m_rulebookAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "m_rulebookAnimator");
		AscensionPause.NativeFieldInfoPtr_m_rulebookScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "m_rulebookScreen");
		AscensionPause.NativeFieldInfoPtr_m_keybindAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "m_keybindAnimator");
		AscensionPause.NativeFieldInfoPtr_m_keybindScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "m_keybindScreen");
		AscensionPause.NativeFieldInfoPtr_m_pauseScreenAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "m_pauseScreenAnimator");
		AscensionPause.NativeFieldInfoPtr_m_waitTimeToDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "m_waitTimeToDisable");
		AscensionPause.NativeFieldInfoPtr_m_subscreenColorizers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "m_subscreenColorizers");
		AscensionPause.NativeFieldInfoPtr_m_AscensionGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "m_AscensionGame");
		AscensionPause.NativeFieldInfoPtr_m_forfeitButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "m_forfeitButtonText");
		AscensionPause.NativeFieldInfoPtr_m_forfeitPopupText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "m_forfeitPopupText");
		AscensionPause.NativeFieldInfoPtr_m_OpenParameterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "m_OpenParameterId");
		AscensionPause.NativeFieldInfoPtr_m_currentScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "m_currentScreen");
		AscensionPause.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663834);
		AscensionPause.NativeMethodInfoPtr_OnEnterMenu_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663835);
		AscensionPause.NativeMethodInfoPtr_OnExitMenu_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663836);
		AscensionPause.NativeMethodInfoPtr_SetForfeitText_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663837);
		AscensionPause.NativeMethodInfoPtr_OnExitGamePressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663838);
		AscensionPause.NativeMethodInfoPtr_OnForfeitButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663839);
		AscensionPause.NativeMethodInfoPtr_OnForfeitConfirmPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663840);
		AscensionPause.NativeMethodInfoPtr_OnPauseButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663841);
		AscensionPause.NativeMethodInfoPtr_OnCardGalleryButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663842);
		AscensionPause.NativeMethodInfoPtr_OnRulebookButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663843);
		AscensionPause.NativeMethodInfoPtr_OnKeybindButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663844);
		AscensionPause.NativeMethodInfoPtr_TurnOnCardGallery_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663845);
		AscensionPause.NativeMethodInfoPtr_TurnOffCardGallery_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663846);
		AscensionPause.NativeMethodInfoPtr_TurnOnRulebook_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663847);
		AscensionPause.NativeMethodInfoPtr_TurnOffRulebook_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663848);
		AscensionPause.NativeMethodInfoPtr_TurnOnKeybindScreen_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663849);
		AscensionPause.NativeMethodInfoPtr_TurnOffKeybindScreen_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663850);
		AscensionPause.NativeMethodInfoPtr_TurnOnPause_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663851);
		AscensionPause.NativeMethodInfoPtr_TurnOffPause_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663852);
		AscensionPause.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, 100663853);
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x00032578 File Offset: 0x00030778
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234755, XrefRangeEnd = 234779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600084C RID: 2124 RVA: 0x000325AC File Offset: 0x000307AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234779, XrefRangeEnd = 234804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnEnterMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionPause.NativeMethodInfoPtr_OnEnterMenu_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x000325E8 File Offset: 0x000307E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234804, XrefRangeEnd = 234805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnExitMenu(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionPause.NativeMethodInfoPtr_OnExitMenu_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x00032634 File Offset: 0x00030834
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 234820, RefRangeEnd = 234821, XrefRangeStart = 234805, XrefRangeEnd = 234820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetForfeitText(bool bAllOppsForfeited)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bAllOppsForfeited;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause.NativeMethodInfoPtr_SetForfeitText_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x00032674 File Offset: 0x00030874
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234821, XrefRangeEnd = 234866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExitGamePressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause.NativeMethodInfoPtr_OnExitGamePressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x000326A8 File Offset: 0x000308A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234866, XrefRangeEnd = 234868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnForfeitButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause.NativeMethodInfoPtr_OnForfeitButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x000326DC File Offset: 0x000308DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234868, XrefRangeEnd = 234934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnForfeitConfirmPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause.NativeMethodInfoPtr_OnForfeitConfirmPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x00032710 File Offset: 0x00030910
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234934, XrefRangeEnd = 234954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPauseButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause.NativeMethodInfoPtr_OnPauseButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x00032744 File Offset: 0x00030944
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234954, XrefRangeEnd = 234974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCardGalleryButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause.NativeMethodInfoPtr_OnCardGalleryButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x00032778 File Offset: 0x00030978
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234974, XrefRangeEnd = 234994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRulebookButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause.NativeMethodInfoPtr_OnRulebookButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x000327AC File Offset: 0x000309AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234994, XrefRangeEnd = 235014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnKeybindButtonPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause.NativeMethodInfoPtr_OnKeybindButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x000327E0 File Offset: 0x000309E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235014, XrefRangeEnd = 235018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator TurnOnCardGallery()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause.NativeMethodInfoPtr_TurnOnCardGallery_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x00032820 File Offset: 0x00030A20
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 235022, RefRangeEnd = 235025, XrefRangeStart = 235018, XrefRangeEnd = 235022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator TurnOffCardGallery()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause.NativeMethodInfoPtr_TurnOffCardGallery_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x00032860 File Offset: 0x00030A60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235025, XrefRangeEnd = 235029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator TurnOnRulebook()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause.NativeMethodInfoPtr_TurnOnRulebook_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x000328A0 File Offset: 0x00030AA0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 235033, RefRangeEnd = 235036, XrefRangeStart = 235029, XrefRangeEnd = 235033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator TurnOffRulebook()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause.NativeMethodInfoPtr_TurnOffRulebook_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x000328E0 File Offset: 0x00030AE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235036, XrefRangeEnd = 235040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator TurnOnKeybindScreen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause.NativeMethodInfoPtr_TurnOnKeybindScreen_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x00032920 File Offset: 0x00030B20
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 235044, RefRangeEnd = 235047, XrefRangeStart = 235040, XrefRangeEnd = 235044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator TurnOffKeybindScreen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause.NativeMethodInfoPtr_TurnOffKeybindScreen_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x00032960 File Offset: 0x00030B60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235047, XrefRangeEnd = 235051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator TurnOnPause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause.NativeMethodInfoPtr_TurnOnPause_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x000329A0 File Offset: 0x00030BA0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 235055, RefRangeEnd = 235058, XrefRangeStart = 235051, XrefRangeEnd = 235055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator TurnOffPause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause.NativeMethodInfoPtr_TurnOffPause_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x000329E0 File Offset: 0x00030BE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235058, XrefRangeEnd = 235059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionPause()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x0000737A File Offset: 0x0000557A
	public AscensionPause(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002FF RID: 767
	// (get) Token: 0x06000860 RID: 2144 RVA: 0x00032A1C File Offset: 0x00030C1C
	// (set) Token: 0x06000861 RID: 2145 RVA: 0x00007383 File Offset: 0x00005583
	public unsafe GameObject m_confirmForfeitPopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_confirmForfeitPopup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_confirmForfeitPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000300 RID: 768
	// (get) Token: 0x06000862 RID: 2146 RVA: 0x00032A4C File Offset: 0x00030C4C
	// (set) Token: 0x06000863 RID: 2147 RVA: 0x000073A2 File Offset: 0x000055A2
	public unsafe Animator m_cardGalleryAnimator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_cardGalleryAnimator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_cardGalleryAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000301 RID: 769
	// (get) Token: 0x06000864 RID: 2148 RVA: 0x00032A7C File Offset: 0x00030C7C
	// (set) Token: 0x06000865 RID: 2149 RVA: 0x000073C1 File Offset: 0x000055C1
	public unsafe UI_CardGallery m_cardGalleryScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_cardGalleryScreen);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_CardGallery>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_cardGalleryScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000302 RID: 770
	// (get) Token: 0x06000866 RID: 2150 RVA: 0x00032AAC File Offset: 0x00030CAC
	// (set) Token: 0x06000867 RID: 2151 RVA: 0x000073E0 File Offset: 0x000055E0
	public unsafe Animator m_rulebookAnimator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_rulebookAnimator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_rulebookAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000303 RID: 771
	// (get) Token: 0x06000868 RID: 2152 RVA: 0x00032ADC File Offset: 0x00030CDC
	// (set) Token: 0x06000869 RID: 2153 RVA: 0x000073FF File Offset: 0x000055FF
	public unsafe UI_Rulebook m_rulebookScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_rulebookScreen);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_Rulebook>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_rulebookScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000304 RID: 772
	// (get) Token: 0x0600086A RID: 2154 RVA: 0x00032B0C File Offset: 0x00030D0C
	// (set) Token: 0x0600086B RID: 2155 RVA: 0x0000741E File Offset: 0x0000561E
	public unsafe Animator m_keybindAnimator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_keybindAnimator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_keybindAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000305 RID: 773
	// (get) Token: 0x0600086C RID: 2156 RVA: 0x00032B3C File Offset: 0x00030D3C
	// (set) Token: 0x0600086D RID: 2157 RVA: 0x0000743D File Offset: 0x0000563D
	public unsafe UI_Keybindings m_keybindScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_keybindScreen);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_Keybindings>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_keybindScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000306 RID: 774
	// (get) Token: 0x0600086E RID: 2158 RVA: 0x00032B6C File Offset: 0x00030D6C
	// (set) Token: 0x0600086F RID: 2159 RVA: 0x0000745C File Offset: 0x0000565C
	public unsafe Animator m_pauseScreenAnimator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_pauseScreenAnimator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_pauseScreenAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000307 RID: 775
	// (get) Token: 0x06000870 RID: 2160 RVA: 0x00032B9C File Offset: 0x00030D9C
	// (set) Token: 0x06000871 RID: 2161 RVA: 0x0000747B File Offset: 0x0000567B
	public unsafe float m_waitTimeToDisable
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_waitTimeToDisable);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_waitTimeToDisable)) = value;
		}
	}

	// Token: 0x17000308 RID: 776
	// (get) Token: 0x06000872 RID: 2162 RVA: 0x00032BC4 File Offset: 0x00030DC4
	// (set) Token: 0x06000873 RID: 2163 RVA: 0x00007496 File Offset: 0x00005696
	public unsafe Il2CppReferenceArray<ColorByFaction> m_subscreenColorizers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_subscreenColorizers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ColorByFaction>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_subscreenColorizers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000309 RID: 777
	// (get) Token: 0x06000874 RID: 2164 RVA: 0x00032BF4 File Offset: 0x00030DF4
	// (set) Token: 0x06000875 RID: 2165 RVA: 0x000074B5 File Offset: 0x000056B5
	public unsafe AscensionGame m_AscensionGame
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_AscensionGame);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionGame>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_AscensionGame), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700030A RID: 778
	// (get) Token: 0x06000876 RID: 2166 RVA: 0x00032C24 File Offset: 0x00030E24
	// (set) Token: 0x06000877 RID: 2167 RVA: 0x000074D4 File Offset: 0x000056D4
	public unsafe TextMeshProUGUI m_forfeitButtonText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_forfeitButtonText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_forfeitButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700030B RID: 779
	// (get) Token: 0x06000878 RID: 2168 RVA: 0x00032C54 File Offset: 0x00030E54
	// (set) Token: 0x06000879 RID: 2169 RVA: 0x000074F3 File Offset: 0x000056F3
	public unsafe TextMeshProUGUI m_forfeitPopupText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_forfeitPopupText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_forfeitPopupText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700030C RID: 780
	// (get) Token: 0x0600087A RID: 2170 RVA: 0x00032C84 File Offset: 0x00030E84
	// (set) Token: 0x0600087B RID: 2171 RVA: 0x00007512 File Offset: 0x00005712
	public unsafe int m_OpenParameterId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_OpenParameterId);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_OpenParameterId)) = value;
		}
	}

	// Token: 0x1700030D RID: 781
	// (get) Token: 0x0600087C RID: 2172 RVA: 0x00032CAC File Offset: 0x00030EAC
	// (set) Token: 0x0600087D RID: 2173 RVA: 0x0000752D File Offset: 0x0000572D
	public unsafe int m_currentScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_currentScreen);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause.NativeFieldInfoPtr_m_currentScreen)) = value;
		}
	}

	// Token: 0x04000524 RID: 1316
	private static readonly IntPtr NativeFieldInfoPtr_m_confirmForfeitPopup;

	// Token: 0x04000525 RID: 1317
	private static readonly IntPtr NativeFieldInfoPtr_m_cardGalleryAnimator;

	// Token: 0x04000526 RID: 1318
	private static readonly IntPtr NativeFieldInfoPtr_m_cardGalleryScreen;

	// Token: 0x04000527 RID: 1319
	private static readonly IntPtr NativeFieldInfoPtr_m_rulebookAnimator;

	// Token: 0x04000528 RID: 1320
	private static readonly IntPtr NativeFieldInfoPtr_m_rulebookScreen;

	// Token: 0x04000529 RID: 1321
	private static readonly IntPtr NativeFieldInfoPtr_m_keybindAnimator;

	// Token: 0x0400052A RID: 1322
	private static readonly IntPtr NativeFieldInfoPtr_m_keybindScreen;

	// Token: 0x0400052B RID: 1323
	private static readonly IntPtr NativeFieldInfoPtr_m_pauseScreenAnimator;

	// Token: 0x0400052C RID: 1324
	private static readonly IntPtr NativeFieldInfoPtr_m_waitTimeToDisable;

	// Token: 0x0400052D RID: 1325
	private static readonly IntPtr NativeFieldInfoPtr_m_subscreenColorizers;

	// Token: 0x0400052E RID: 1326
	private static readonly IntPtr NativeFieldInfoPtr_m_AscensionGame;

	// Token: 0x0400052F RID: 1327
	private static readonly IntPtr NativeFieldInfoPtr_m_forfeitButtonText;

	// Token: 0x04000530 RID: 1328
	private static readonly IntPtr NativeFieldInfoPtr_m_forfeitPopupText;

	// Token: 0x04000531 RID: 1329
	private static readonly IntPtr NativeFieldInfoPtr_m_OpenParameterId;

	// Token: 0x04000532 RID: 1330
	private static readonly IntPtr NativeFieldInfoPtr_m_currentScreen;

	// Token: 0x04000533 RID: 1331
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000534 RID: 1332
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterMenu_Public_Virtual_Void_0;

	// Token: 0x04000535 RID: 1333
	private static readonly IntPtr NativeMethodInfoPtr_OnExitMenu_Public_Virtual_Void_Boolean_0;

	// Token: 0x04000536 RID: 1334
	private static readonly IntPtr NativeMethodInfoPtr_SetForfeitText_Private_Void_Boolean_0;

	// Token: 0x04000537 RID: 1335
	private static readonly IntPtr NativeMethodInfoPtr_OnExitGamePressed_Public_Void_0;

	// Token: 0x04000538 RID: 1336
	private static readonly IntPtr NativeMethodInfoPtr_OnForfeitButtonPressed_Public_Void_0;

	// Token: 0x04000539 RID: 1337
	private static readonly IntPtr NativeMethodInfoPtr_OnForfeitConfirmPressed_Public_Void_0;

	// Token: 0x0400053A RID: 1338
	private static readonly IntPtr NativeMethodInfoPtr_OnPauseButtonPressed_Public_Void_0;

	// Token: 0x0400053B RID: 1339
	private static readonly IntPtr NativeMethodInfoPtr_OnCardGalleryButtonPressed_Public_Void_0;

	// Token: 0x0400053C RID: 1340
	private static readonly IntPtr NativeMethodInfoPtr_OnRulebookButtonPressed_Public_Void_0;

	// Token: 0x0400053D RID: 1341
	private static readonly IntPtr NativeMethodInfoPtr_OnKeybindButtonPressed_Public_Void_0;

	// Token: 0x0400053E RID: 1342
	private static readonly IntPtr NativeMethodInfoPtr_TurnOnCardGallery_Private_IEnumerator_0;

	// Token: 0x0400053F RID: 1343
	private static readonly IntPtr NativeMethodInfoPtr_TurnOffCardGallery_Private_IEnumerator_0;

	// Token: 0x04000540 RID: 1344
	private static readonly IntPtr NativeMethodInfoPtr_TurnOnRulebook_Private_IEnumerator_0;

	// Token: 0x04000541 RID: 1345
	private static readonly IntPtr NativeMethodInfoPtr_TurnOffRulebook_Private_IEnumerator_0;

	// Token: 0x04000542 RID: 1346
	private static readonly IntPtr NativeMethodInfoPtr_TurnOnKeybindScreen_Private_IEnumerator_0;

	// Token: 0x04000543 RID: 1347
	private static readonly IntPtr NativeMethodInfoPtr_TurnOffKeybindScreen_Private_IEnumerator_0;

	// Token: 0x04000544 RID: 1348
	private static readonly IntPtr NativeMethodInfoPtr_TurnOnPause_Private_IEnumerator_0;

	// Token: 0x04000545 RID: 1349
	private static readonly IntPtr NativeMethodInfoPtr_TurnOffPause_Private_IEnumerator_0;

	// Token: 0x04000546 RID: 1350
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200016E RID: 366
	[ObfuscatedName("AscensionPause+<TurnOnCardGallery>d__26")]
	public sealed class _TurnOnCardGallery_d__26 : global::Il2CppSystem.Object
	{
		// Token: 0x060022F6 RID: 8950 RVA: 0x00082FDC File Offset: 0x000811DC
		// Note: this type is marked as 'beforefieldinit'.
		static _TurnOnCardGallery_d__26()
		{
			Il2CppClassPointerStore<AscensionPause._TurnOnCardGallery_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "<TurnOnCardGallery>d__26");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionPause._TurnOnCardGallery_d__26>.NativeClassPtr);
			AscensionPause._TurnOnCardGallery_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOnCardGallery_d__26>.NativeClassPtr, "<>1__state");
			AscensionPause._TurnOnCardGallery_d__26.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOnCardGallery_d__26>.NativeClassPtr, "<>2__current");
			AscensionPause._TurnOnCardGallery_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOnCardGallery_d__26>.NativeClassPtr, "<>4__this");
			AscensionPause._TurnOnCardGallery_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnCardGallery_d__26>.NativeClassPtr, 100666052);
			AscensionPause._TurnOnCardGallery_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnCardGallery_d__26>.NativeClassPtr, 100666053);
			AscensionPause._TurnOnCardGallery_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnCardGallery_d__26>.NativeClassPtr, 100666054);
			AscensionPause._TurnOnCardGallery_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnCardGallery_d__26>.NativeClassPtr, 100666055);
			AscensionPause._TurnOnCardGallery_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnCardGallery_d__26>.NativeClassPtr, 100666056);
			AscensionPause._TurnOnCardGallery_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnCardGallery_d__26>.NativeClassPtr, 100666057);
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x000830BC File Offset: 0x000812BC
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _TurnOnCardGallery_d__26(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionPause._TurnOnCardGallery_d__26>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnCardGallery_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x00083104 File Offset: 0x00081304
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnCardGallery_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x00083138 File Offset: 0x00081338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234681, XrefRangeEnd = 234685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnCardGallery_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x060022FA RID: 8954 RVA: 0x00083174 File Offset: 0x00081374
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnCardGallery_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x000831B4 File Offset: 0x000813B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234685, XrefRangeEnd = 234690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnCardGallery_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x060022FC RID: 8956 RVA: 0x000831E8 File Offset: 0x000813E8
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnCardGallery_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x00015F8C File Offset: 0x0001418C
		public _TurnOnCardGallery_d__26(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x060022FE RID: 8958 RVA: 0x00083228 File Offset: 0x00081428
		// (set) Token: 0x060022FF RID: 8959 RVA: 0x00015F95 File Offset: 0x00014195
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnCardGallery_d__26.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnCardGallery_d__26.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06002300 RID: 8960 RVA: 0x00083250 File Offset: 0x00081450
		// (set) Token: 0x06002301 RID: 8961 RVA: 0x00015FB0 File Offset: 0x000141B0
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnCardGallery_d__26.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnCardGallery_d__26.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06002302 RID: 8962 RVA: 0x00083280 File Offset: 0x00081480
		// (set) Token: 0x06002303 RID: 8963 RVA: 0x00015FCF File Offset: 0x000141CF
		public unsafe AscensionPause __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnCardGallery_d__26.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionPause>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnCardGallery_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001841 RID: 6209
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001842 RID: 6210
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001843 RID: 6211
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001844 RID: 6212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001845 RID: 6213
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001846 RID: 6214
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001847 RID: 6215
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001848 RID: 6216
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001849 RID: 6217
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200016F RID: 367
	[ObfuscatedName("AscensionPause+<TurnOffCardGallery>d__27")]
	public sealed class _TurnOffCardGallery_d__27 : global::Il2CppSystem.Object
	{
		// Token: 0x06002304 RID: 8964 RVA: 0x000832B0 File Offset: 0x000814B0
		// Note: this type is marked as 'beforefieldinit'.
		static _TurnOffCardGallery_d__27()
		{
			Il2CppClassPointerStore<AscensionPause._TurnOffCardGallery_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "<TurnOffCardGallery>d__27");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionPause._TurnOffCardGallery_d__27>.NativeClassPtr);
			AscensionPause._TurnOffCardGallery_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOffCardGallery_d__27>.NativeClassPtr, "<>1__state");
			AscensionPause._TurnOffCardGallery_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOffCardGallery_d__27>.NativeClassPtr, "<>2__current");
			AscensionPause._TurnOffCardGallery_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOffCardGallery_d__27>.NativeClassPtr, "<>4__this");
			AscensionPause._TurnOffCardGallery_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffCardGallery_d__27>.NativeClassPtr, 100666058);
			AscensionPause._TurnOffCardGallery_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffCardGallery_d__27>.NativeClassPtr, 100666059);
			AscensionPause._TurnOffCardGallery_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffCardGallery_d__27>.NativeClassPtr, 100666060);
			AscensionPause._TurnOffCardGallery_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffCardGallery_d__27>.NativeClassPtr, 100666061);
			AscensionPause._TurnOffCardGallery_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffCardGallery_d__27>.NativeClassPtr, 100666062);
			AscensionPause._TurnOffCardGallery_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffCardGallery_d__27>.NativeClassPtr, 100666063);
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x00083390 File Offset: 0x00081590
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _TurnOffCardGallery_d__27(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionPause._TurnOffCardGallery_d__27>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffCardGallery_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x000833D8 File Offset: 0x000815D8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffCardGallery_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x0008340C File Offset: 0x0008160C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234690, XrefRangeEnd = 234694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffCardGallery_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06002308 RID: 8968 RVA: 0x00083448 File Offset: 0x00081648
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffCardGallery_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002309 RID: 8969 RVA: 0x00083488 File Offset: 0x00081688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234694, XrefRangeEnd = 234699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffCardGallery_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x0600230A RID: 8970 RVA: 0x000834BC File Offset: 0x000816BC
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffCardGallery_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x00015FEE File Offset: 0x000141EE
		public _TurnOffCardGallery_d__27(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x0600230C RID: 8972 RVA: 0x000834FC File Offset: 0x000816FC
		// (set) Token: 0x0600230D RID: 8973 RVA: 0x00015FF7 File Offset: 0x000141F7
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffCardGallery_d__27.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffCardGallery_d__27.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x0600230E RID: 8974 RVA: 0x00083524 File Offset: 0x00081724
		// (set) Token: 0x0600230F RID: 8975 RVA: 0x00016012 File Offset: 0x00014212
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffCardGallery_d__27.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffCardGallery_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06002310 RID: 8976 RVA: 0x00083554 File Offset: 0x00081754
		// (set) Token: 0x06002311 RID: 8977 RVA: 0x00016031 File Offset: 0x00014231
		public unsafe AscensionPause __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffCardGallery_d__27.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionPause>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffCardGallery_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400184A RID: 6218
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400184B RID: 6219
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400184C RID: 6220
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400184D RID: 6221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400184E RID: 6222
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400184F RID: 6223
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001850 RID: 6224
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001851 RID: 6225
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001852 RID: 6226
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000170 RID: 368
	[ObfuscatedName("AscensionPause+<TurnOnRulebook>d__28")]
	public sealed class _TurnOnRulebook_d__28 : global::Il2CppSystem.Object
	{
		// Token: 0x06002312 RID: 8978 RVA: 0x00083584 File Offset: 0x00081784
		// Note: this type is marked as 'beforefieldinit'.
		static _TurnOnRulebook_d__28()
		{
			Il2CppClassPointerStore<AscensionPause._TurnOnRulebook_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "<TurnOnRulebook>d__28");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionPause._TurnOnRulebook_d__28>.NativeClassPtr);
			AscensionPause._TurnOnRulebook_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOnRulebook_d__28>.NativeClassPtr, "<>1__state");
			AscensionPause._TurnOnRulebook_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOnRulebook_d__28>.NativeClassPtr, "<>2__current");
			AscensionPause._TurnOnRulebook_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOnRulebook_d__28>.NativeClassPtr, "<>4__this");
			AscensionPause._TurnOnRulebook_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnRulebook_d__28>.NativeClassPtr, 100666064);
			AscensionPause._TurnOnRulebook_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnRulebook_d__28>.NativeClassPtr, 100666065);
			AscensionPause._TurnOnRulebook_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnRulebook_d__28>.NativeClassPtr, 100666066);
			AscensionPause._TurnOnRulebook_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnRulebook_d__28>.NativeClassPtr, 100666067);
			AscensionPause._TurnOnRulebook_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnRulebook_d__28>.NativeClassPtr, 100666068);
			AscensionPause._TurnOnRulebook_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnRulebook_d__28>.NativeClassPtr, 100666069);
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x00083664 File Offset: 0x00081864
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _TurnOnRulebook_d__28(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionPause._TurnOnRulebook_d__28>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnRulebook_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002314 RID: 8980 RVA: 0x000836AC File Offset: 0x000818AC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnRulebook_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x000836E0 File Offset: 0x000818E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234699, XrefRangeEnd = 234703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnRulebook_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06002316 RID: 8982 RVA: 0x0008371C File Offset: 0x0008191C
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnRulebook_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x0008375C File Offset: 0x0008195C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234703, XrefRangeEnd = 234708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnRulebook_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06002318 RID: 8984 RVA: 0x00083790 File Offset: 0x00081990
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnRulebook_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x00016050 File Offset: 0x00014250
		public _TurnOnRulebook_d__28(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x0600231A RID: 8986 RVA: 0x000837D0 File Offset: 0x000819D0
		// (set) Token: 0x0600231B RID: 8987 RVA: 0x00016059 File Offset: 0x00014259
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnRulebook_d__28.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnRulebook_d__28.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x000837F8 File Offset: 0x000819F8
		// (set) Token: 0x0600231D RID: 8989 RVA: 0x00016074 File Offset: 0x00014274
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnRulebook_d__28.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnRulebook_d__28.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x00083828 File Offset: 0x00081A28
		// (set) Token: 0x0600231F RID: 8991 RVA: 0x00016093 File Offset: 0x00014293
		public unsafe AscensionPause __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnRulebook_d__28.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionPause>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnRulebook_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001853 RID: 6227
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001857 RID: 6231
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001858 RID: 6232
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001859 RID: 6233
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400185A RID: 6234
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400185B RID: 6235
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000171 RID: 369
	[ObfuscatedName("AscensionPause+<TurnOffRulebook>d__29")]
	public sealed class _TurnOffRulebook_d__29 : global::Il2CppSystem.Object
	{
		// Token: 0x06002320 RID: 8992 RVA: 0x00083858 File Offset: 0x00081A58
		// Note: this type is marked as 'beforefieldinit'.
		static _TurnOffRulebook_d__29()
		{
			Il2CppClassPointerStore<AscensionPause._TurnOffRulebook_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "<TurnOffRulebook>d__29");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionPause._TurnOffRulebook_d__29>.NativeClassPtr);
			AscensionPause._TurnOffRulebook_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOffRulebook_d__29>.NativeClassPtr, "<>1__state");
			AscensionPause._TurnOffRulebook_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOffRulebook_d__29>.NativeClassPtr, "<>2__current");
			AscensionPause._TurnOffRulebook_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOffRulebook_d__29>.NativeClassPtr, "<>4__this");
			AscensionPause._TurnOffRulebook_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffRulebook_d__29>.NativeClassPtr, 100666070);
			AscensionPause._TurnOffRulebook_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffRulebook_d__29>.NativeClassPtr, 100666071);
			AscensionPause._TurnOffRulebook_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffRulebook_d__29>.NativeClassPtr, 100666072);
			AscensionPause._TurnOffRulebook_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffRulebook_d__29>.NativeClassPtr, 100666073);
			AscensionPause._TurnOffRulebook_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffRulebook_d__29>.NativeClassPtr, 100666074);
			AscensionPause._TurnOffRulebook_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffRulebook_d__29>.NativeClassPtr, 100666075);
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x00083938 File Offset: 0x00081B38
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _TurnOffRulebook_d__29(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionPause._TurnOffRulebook_d__29>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffRulebook_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x00083980 File Offset: 0x00081B80
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffRulebook_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x000839B4 File Offset: 0x00081BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234708, XrefRangeEnd = 234712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffRulebook_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002324 RID: 8996 RVA: 0x000839F0 File Offset: 0x00081BF0
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffRulebook_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x00083A30 File Offset: 0x00081C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234712, XrefRangeEnd = 234717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffRulebook_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002326 RID: 8998 RVA: 0x00083A64 File Offset: 0x00081C64
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffRulebook_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x000160B2 File Offset: 0x000142B2
		public _TurnOffRulebook_d__29(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06002328 RID: 9000 RVA: 0x00083AA4 File Offset: 0x00081CA4
		// (set) Token: 0x06002329 RID: 9001 RVA: 0x000160BB File Offset: 0x000142BB
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffRulebook_d__29.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffRulebook_d__29.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x00083ACC File Offset: 0x00081CCC
		// (set) Token: 0x0600232B RID: 9003 RVA: 0x000160D6 File Offset: 0x000142D6
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffRulebook_d__29.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffRulebook_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x00083AFC File Offset: 0x00081CFC
		// (set) Token: 0x0600232D RID: 9005 RVA: 0x000160F5 File Offset: 0x000142F5
		public unsafe AscensionPause __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffRulebook_d__29.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionPause>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffRulebook_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400185C RID: 6236
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400185D RID: 6237
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400185E RID: 6238
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400185F RID: 6239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001860 RID: 6240
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001861 RID: 6241
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001862 RID: 6242
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001863 RID: 6243
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001864 RID: 6244
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000172 RID: 370
	[ObfuscatedName("AscensionPause+<TurnOnKeybindScreen>d__30")]
	public sealed class _TurnOnKeybindScreen_d__30 : global::Il2CppSystem.Object
	{
		// Token: 0x0600232E RID: 9006 RVA: 0x00083B2C File Offset: 0x00081D2C
		// Note: this type is marked as 'beforefieldinit'.
		static _TurnOnKeybindScreen_d__30()
		{
			Il2CppClassPointerStore<AscensionPause._TurnOnKeybindScreen_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "<TurnOnKeybindScreen>d__30");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionPause._TurnOnKeybindScreen_d__30>.NativeClassPtr);
			AscensionPause._TurnOnKeybindScreen_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOnKeybindScreen_d__30>.NativeClassPtr, "<>1__state");
			AscensionPause._TurnOnKeybindScreen_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOnKeybindScreen_d__30>.NativeClassPtr, "<>2__current");
			AscensionPause._TurnOnKeybindScreen_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOnKeybindScreen_d__30>.NativeClassPtr, "<>4__this");
			AscensionPause._TurnOnKeybindScreen_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnKeybindScreen_d__30>.NativeClassPtr, 100666076);
			AscensionPause._TurnOnKeybindScreen_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnKeybindScreen_d__30>.NativeClassPtr, 100666077);
			AscensionPause._TurnOnKeybindScreen_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnKeybindScreen_d__30>.NativeClassPtr, 100666078);
			AscensionPause._TurnOnKeybindScreen_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnKeybindScreen_d__30>.NativeClassPtr, 100666079);
			AscensionPause._TurnOnKeybindScreen_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnKeybindScreen_d__30>.NativeClassPtr, 100666080);
			AscensionPause._TurnOnKeybindScreen_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnKeybindScreen_d__30>.NativeClassPtr, 100666081);
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x00083C0C File Offset: 0x00081E0C
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _TurnOnKeybindScreen_d__30(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionPause._TurnOnKeybindScreen_d__30>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnKeybindScreen_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x00083C54 File Offset: 0x00081E54
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnKeybindScreen_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x00083C88 File Offset: 0x00081E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234717, XrefRangeEnd = 234721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnKeybindScreen_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x00083CC4 File Offset: 0x00081EC4
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnKeybindScreen_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x00083D04 File Offset: 0x00081F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234721, XrefRangeEnd = 234726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnKeybindScreen_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x00083D38 File Offset: 0x00081F38
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnKeybindScreen_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x00016114 File Offset: 0x00014314
		public _TurnOnKeybindScreen_d__30(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x00083D78 File Offset: 0x00081F78
		// (set) Token: 0x06002337 RID: 9015 RVA: 0x0001611D File Offset: 0x0001431D
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnKeybindScreen_d__30.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnKeybindScreen_d__30.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06002338 RID: 9016 RVA: 0x00083DA0 File Offset: 0x00081FA0
		// (set) Token: 0x06002339 RID: 9017 RVA: 0x00016138 File Offset: 0x00014338
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnKeybindScreen_d__30.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnKeybindScreen_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x00083DD0 File Offset: 0x00081FD0
		// (set) Token: 0x0600233B RID: 9019 RVA: 0x00016157 File Offset: 0x00014357
		public unsafe AscensionPause __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnKeybindScreen_d__30.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionPause>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnKeybindScreen_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001865 RID: 6245
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001866 RID: 6246
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001867 RID: 6247
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001868 RID: 6248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001869 RID: 6249
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400186A RID: 6250
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400186B RID: 6251
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400186C RID: 6252
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400186D RID: 6253
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000173 RID: 371
	[ObfuscatedName("AscensionPause+<TurnOffKeybindScreen>d__31")]
	public sealed class _TurnOffKeybindScreen_d__31 : global::Il2CppSystem.Object
	{
		// Token: 0x0600233C RID: 9020 RVA: 0x00083E00 File Offset: 0x00082000
		// Note: this type is marked as 'beforefieldinit'.
		static _TurnOffKeybindScreen_d__31()
		{
			Il2CppClassPointerStore<AscensionPause._TurnOffKeybindScreen_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "<TurnOffKeybindScreen>d__31");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionPause._TurnOffKeybindScreen_d__31>.NativeClassPtr);
			AscensionPause._TurnOffKeybindScreen_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOffKeybindScreen_d__31>.NativeClassPtr, "<>1__state");
			AscensionPause._TurnOffKeybindScreen_d__31.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOffKeybindScreen_d__31>.NativeClassPtr, "<>2__current");
			AscensionPause._TurnOffKeybindScreen_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOffKeybindScreen_d__31>.NativeClassPtr, "<>4__this");
			AscensionPause._TurnOffKeybindScreen_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffKeybindScreen_d__31>.NativeClassPtr, 100666082);
			AscensionPause._TurnOffKeybindScreen_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffKeybindScreen_d__31>.NativeClassPtr, 100666083);
			AscensionPause._TurnOffKeybindScreen_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffKeybindScreen_d__31>.NativeClassPtr, 100666084);
			AscensionPause._TurnOffKeybindScreen_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffKeybindScreen_d__31>.NativeClassPtr, 100666085);
			AscensionPause._TurnOffKeybindScreen_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffKeybindScreen_d__31>.NativeClassPtr, 100666086);
			AscensionPause._TurnOffKeybindScreen_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffKeybindScreen_d__31>.NativeClassPtr, 100666087);
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x00083EE0 File Offset: 0x000820E0
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _TurnOffKeybindScreen_d__31(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionPause._TurnOffKeybindScreen_d__31>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffKeybindScreen_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x00083F28 File Offset: 0x00082128
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffKeybindScreen_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x00083F5C File Offset: 0x0008215C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234726, XrefRangeEnd = 234730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffKeybindScreen_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06002340 RID: 9024 RVA: 0x00083F98 File Offset: 0x00082198
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffKeybindScreen_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x00083FD8 File Offset: 0x000821D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234730, XrefRangeEnd = 234735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffKeybindScreen_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06002342 RID: 9026 RVA: 0x0008400C File Offset: 0x0008220C
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffKeybindScreen_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x00016176 File Offset: 0x00014376
		public _TurnOffKeybindScreen_d__31(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002344 RID: 9028 RVA: 0x0008404C File Offset: 0x0008224C
		// (set) Token: 0x06002345 RID: 9029 RVA: 0x0001617F File Offset: 0x0001437F
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffKeybindScreen_d__31.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffKeybindScreen_d__31.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06002346 RID: 9030 RVA: 0x00084074 File Offset: 0x00082274
		// (set) Token: 0x06002347 RID: 9031 RVA: 0x0001619A File Offset: 0x0001439A
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffKeybindScreen_d__31.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffKeybindScreen_d__31.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06002348 RID: 9032 RVA: 0x000840A4 File Offset: 0x000822A4
		// (set) Token: 0x06002349 RID: 9033 RVA: 0x000161B9 File Offset: 0x000143B9
		public unsafe AscensionPause __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffKeybindScreen_d__31.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionPause>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffKeybindScreen_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400186E RID: 6254
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400186F RID: 6255
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001870 RID: 6256
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001871 RID: 6257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001872 RID: 6258
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001873 RID: 6259
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001874 RID: 6260
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001875 RID: 6261
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001876 RID: 6262
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000174 RID: 372
	[ObfuscatedName("AscensionPause+<TurnOnPause>d__32")]
	public sealed class _TurnOnPause_d__32 : global::Il2CppSystem.Object
	{
		// Token: 0x0600234A RID: 9034 RVA: 0x000840D4 File Offset: 0x000822D4
		// Note: this type is marked as 'beforefieldinit'.
		static _TurnOnPause_d__32()
		{
			Il2CppClassPointerStore<AscensionPause._TurnOnPause_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "<TurnOnPause>d__32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionPause._TurnOnPause_d__32>.NativeClassPtr);
			AscensionPause._TurnOnPause_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOnPause_d__32>.NativeClassPtr, "<>1__state");
			AscensionPause._TurnOnPause_d__32.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOnPause_d__32>.NativeClassPtr, "<>2__current");
			AscensionPause._TurnOnPause_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOnPause_d__32>.NativeClassPtr, "<>4__this");
			AscensionPause._TurnOnPause_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnPause_d__32>.NativeClassPtr, 100666088);
			AscensionPause._TurnOnPause_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnPause_d__32>.NativeClassPtr, 100666089);
			AscensionPause._TurnOnPause_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnPause_d__32>.NativeClassPtr, 100666090);
			AscensionPause._TurnOnPause_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnPause_d__32>.NativeClassPtr, 100666091);
			AscensionPause._TurnOnPause_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnPause_d__32>.NativeClassPtr, 100666092);
			AscensionPause._TurnOnPause_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOnPause_d__32>.NativeClassPtr, 100666093);
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x000841B4 File Offset: 0x000823B4
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _TurnOnPause_d__32(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionPause._TurnOnPause_d__32>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnPause_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x000841FC File Offset: 0x000823FC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnPause_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x00084230 File Offset: 0x00082430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234735, XrefRangeEnd = 234740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnPause_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x0600234E RID: 9038 RVA: 0x0008426C File Offset: 0x0008246C
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnPause_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x000842AC File Offset: 0x000824AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234740, XrefRangeEnd = 234745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnPause_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x000842E0 File Offset: 0x000824E0
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOnPause_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x000161D8 File Offset: 0x000143D8
		public _TurnOnPause_d__32(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x00084320 File Offset: 0x00082520
		// (set) Token: 0x06002353 RID: 9043 RVA: 0x000161E1 File Offset: 0x000143E1
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnPause_d__32.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnPause_d__32.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x00084348 File Offset: 0x00082548
		// (set) Token: 0x06002355 RID: 9045 RVA: 0x000161FC File Offset: 0x000143FC
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnPause_d__32.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnPause_d__32.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06002356 RID: 9046 RVA: 0x00084378 File Offset: 0x00082578
		// (set) Token: 0x06002357 RID: 9047 RVA: 0x0001621B File Offset: 0x0001441B
		public unsafe AscensionPause __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnPause_d__32.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionPause>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOnPause_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001877 RID: 6263
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001878 RID: 6264
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001879 RID: 6265
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400187A RID: 6266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400187B RID: 6267
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400187C RID: 6268
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400187D RID: 6269
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400187E RID: 6270
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400187F RID: 6271
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000175 RID: 373
	[ObfuscatedName("AscensionPause+<TurnOffPause>d__33")]
	public sealed class _TurnOffPause_d__33 : global::Il2CppSystem.Object
	{
		// Token: 0x06002358 RID: 9048 RVA: 0x000843A8 File Offset: 0x000825A8
		// Note: this type is marked as 'beforefieldinit'.
		static _TurnOffPause_d__33()
		{
			Il2CppClassPointerStore<AscensionPause._TurnOffPause_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AscensionPause>.NativeClassPtr, "<TurnOffPause>d__33");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionPause._TurnOffPause_d__33>.NativeClassPtr);
			AscensionPause._TurnOffPause_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOffPause_d__33>.NativeClassPtr, "<>1__state");
			AscensionPause._TurnOffPause_d__33.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOffPause_d__33>.NativeClassPtr, "<>2__current");
			AscensionPause._TurnOffPause_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionPause._TurnOffPause_d__33>.NativeClassPtr, "<>4__this");
			AscensionPause._TurnOffPause_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffPause_d__33>.NativeClassPtr, 100666094);
			AscensionPause._TurnOffPause_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffPause_d__33>.NativeClassPtr, 100666095);
			AscensionPause._TurnOffPause_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffPause_d__33>.NativeClassPtr, 100666096);
			AscensionPause._TurnOffPause_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffPause_d__33>.NativeClassPtr, 100666097);
			AscensionPause._TurnOffPause_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffPause_d__33>.NativeClassPtr, 100666098);
			AscensionPause._TurnOffPause_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionPause._TurnOffPause_d__33>.NativeClassPtr, 100666099);
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x00084488 File Offset: 0x00082688
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _TurnOffPause_d__33(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionPause._TurnOffPause_d__33>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffPause_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x000844D0 File Offset: 0x000826D0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffPause_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x00084504 File Offset: 0x00082704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234745, XrefRangeEnd = 234750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffPause_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x0600235C RID: 9052 RVA: 0x00084540 File Offset: 0x00082740
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffPause_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x00084580 File Offset: 0x00082780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234750, XrefRangeEnd = 234755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffPause_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x0600235E RID: 9054 RVA: 0x000845B4 File Offset: 0x000827B4
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionPause._TurnOffPause_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x0001623A File Offset: 0x0001443A
		public _TurnOffPause_d__33(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06002360 RID: 9056 RVA: 0x000845F4 File Offset: 0x000827F4
		// (set) Token: 0x06002361 RID: 9057 RVA: 0x00016243 File Offset: 0x00014443
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffPause_d__33.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffPause_d__33.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06002362 RID: 9058 RVA: 0x0008461C File Offset: 0x0008281C
		// (set) Token: 0x06002363 RID: 9059 RVA: 0x0001625E File Offset: 0x0001445E
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffPause_d__33.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffPause_d__33.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06002364 RID: 9060 RVA: 0x0008464C File Offset: 0x0008284C
		// (set) Token: 0x06002365 RID: 9061 RVA: 0x0001627D File Offset: 0x0001447D
		public unsafe AscensionPause __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffPause_d__33.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionPause>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionPause._TurnOffPause_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001880 RID: 6272
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001881 RID: 6273
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001882 RID: 6274
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001883 RID: 6275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001884 RID: 6276
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001885 RID: 6277
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001886 RID: 6278
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001887 RID: 6279
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001888 RID: 6280
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

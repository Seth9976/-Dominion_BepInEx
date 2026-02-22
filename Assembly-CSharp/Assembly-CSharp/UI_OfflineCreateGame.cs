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

// Token: 0x020000D4 RID: 212
public class UI_OfflineCreateGame : MonoBehaviour
{
	// Token: 0x06001991 RID: 6545 RVA: 0x00066D0C File Offset: 0x00064F0C
	// Note: this type is marked as 'beforefieldinit'.
	static UI_OfflineCreateGame()
	{
		Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_OfflineCreateGame");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr);
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_playerSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_playerSlots");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_setToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_setToggles");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_promoToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_promoToggles");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_setLocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_setLocks");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_promoLocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_promoLocks");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_leftButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_leftButton");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_rightButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_rightButton");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_leftButtonDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_leftButtonDisabled");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_rightButtonDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_rightButtonDisabled");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_honorPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_honorPool");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_soakTestNumPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_soakTestNumPlayers");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_soakTestHonorPoolAdjust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_soakTestHonorPoolAdjust");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_soakTestSetFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_soakTestSetFlags");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_soakTestPromoFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_soakTestPromoFlags");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_bIgnoreNextEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_bIgnoreNextEnter");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_InAppPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_InAppPurchase");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_avatarSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_avatarSlotIndex");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_setFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_setFlags");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_promoFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_promoFlags");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_honorPoolAdjust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_honorPoolAdjust");
		UI_OfflineCreateGame.NativeFieldInfoPtr_m_bIgnoreToggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "m_bIgnoreToggles");
		UI_OfflineCreateGame.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, 100665316);
		UI_OfflineCreateGame.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, 100665317);
		UI_OfflineCreateGame.NativeMethodInfoPtr_HandleClickOnSlot_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, 100665318);
		UI_OfflineCreateGame.NativeMethodInfoPtr_HandleClickOnSlotAI_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, 100665319);
		UI_OfflineCreateGame.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, 100665320);
		UI_OfflineCreateGame.NativeMethodInfoPtr_OnAvatarCallback_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, 100665321);
		UI_OfflineCreateGame.NativeMethodInfoPtr_OnAvatarSelectPressed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, 100665322);
		UI_OfflineCreateGame.NativeMethodInfoPtr_OnGameTypeChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, 100665323);
		UI_OfflineCreateGame.NativeMethodInfoPtr_UpdatePlayerStates_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, 100665324);
		UI_OfflineCreateGame.NativeMethodInfoPtr_AdjustHonor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, 100665325);
		UI_OfflineCreateGame.NativeMethodInfoPtr_CreateGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, 100665326);
		UI_OfflineCreateGame.NativeMethodInfoPtr_RetreiveSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, 100665327);
		UI_OfflineCreateGame.NativeMethodInfoPtr_StoreSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, 100665328);
		UI_OfflineCreateGame.NativeMethodInfoPtr_HandleSoakTest_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, 100665329);
		UI_OfflineCreateGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, 100665330);
	}

	// Token: 0x06001992 RID: 6546 RVA: 0x0006700C File Offset: 0x0006520C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250481, XrefRangeEnd = 250494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001993 RID: 6547 RVA: 0x00067040 File Offset: 0x00065240
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250494, XrefRangeEnd = 250544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnterMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001994 RID: 6548 RVA: 0x00067074 File Offset: 0x00065274
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250544, XrefRangeEnd = 250553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleClickOnSlot(int slotIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref slotIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame.NativeMethodInfoPtr_HandleClickOnSlot_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001995 RID: 6549 RVA: 0x000670B4 File Offset: 0x000652B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250553, XrefRangeEnd = 250558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleClickOnSlotAI(int slotIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref slotIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame.NativeMethodInfoPtr_HandleClickOnSlotAI_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001996 RID: 6550 RVA: 0x000670F4 File Offset: 0x000652F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250558, XrefRangeEnd = 250559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExitMenu(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001997 RID: 6551 RVA: 0x00067134 File Offset: 0x00065334
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250559, XrefRangeEnd = 250563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAvatarCallback(int avatarIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref avatarIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame.NativeMethodInfoPtr_OnAvatarCallback_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001998 RID: 6552 RVA: 0x00067174 File Offset: 0x00065374
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250563, XrefRangeEnd = 250593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAvatarSelectPressed(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame.NativeMethodInfoPtr_OnAvatarSelectPressed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001999 RID: 6553 RVA: 0x000671B4 File Offset: 0x000653B4
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 250617, RefRangeEnd = 250624, XrefRangeStart = 250593, XrefRangeEnd = 250617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGameTypeChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame.NativeMethodInfoPtr_OnGameTypeChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600199A RID: 6554 RVA: 0x000671E8 File Offset: 0x000653E8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 250638, RefRangeEnd = 250639, XrefRangeStart = 250624, XrefRangeEnd = 250638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePlayerStates()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame.NativeMethodInfoPtr_UpdatePlayerStates_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600199B RID: 6555 RVA: 0x0006721C File Offset: 0x0006541C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250639, XrefRangeEnd = 250640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AdjustHonor(bool bAdjustUp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bAdjustUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame.NativeMethodInfoPtr_AdjustHonor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600199C RID: 6556 RVA: 0x0006725C File Offset: 0x0006545C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 250706, RefRangeEnd = 250707, XrefRangeStart = 250640, XrefRangeEnd = 250706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateGame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame.NativeMethodInfoPtr_CreateGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600199D RID: 6557 RVA: 0x00067290 File Offset: 0x00065490
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 250844, RefRangeEnd = 250845, XrefRangeStart = 250707, XrefRangeEnd = 250844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RetreiveSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame.NativeMethodInfoPtr_RetreiveSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600199E RID: 6558 RVA: 0x000672C4 File Offset: 0x000654C4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 250930, RefRangeEnd = 250932, XrefRangeStart = 250845, XrefRangeEnd = 250930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StoreSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame.NativeMethodInfoPtr_StoreSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600199F RID: 6559 RVA: 0x000672F8 File Offset: 0x000654F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250932, XrefRangeEnd = 250936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator HandleSoakTest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame.NativeMethodInfoPtr_HandleSoakTest_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060019A0 RID: 6560 RVA: 0x00067338 File Offset: 0x00065538
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250936, XrefRangeEnd = 250937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_OfflineCreateGame()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060019A1 RID: 6561 RVA: 0x0001075A File Offset: 0x0000E95A
	public UI_OfflineCreateGame(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700082B RID: 2091
	// (get) Token: 0x060019A2 RID: 6562 RVA: 0x00067374 File Offset: 0x00065574
	// (set) Token: 0x060019A3 RID: 6563 RVA: 0x00010763 File Offset: 0x0000E963
	public unsafe Il2CppReferenceArray<UI_OfflineCreateGame.PlayerSlot> m_playerSlots
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_playerSlots);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UI_OfflineCreateGame.PlayerSlot>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_playerSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700082C RID: 2092
	// (get) Token: 0x060019A4 RID: 6564 RVA: 0x000673A4 File Offset: 0x000655A4
	// (set) Token: 0x060019A5 RID: 6565 RVA: 0x00010782 File Offset: 0x0000E982
	public unsafe Il2CppReferenceArray<Toggle> m_setToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_setToggles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Toggle>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_setToggles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700082D RID: 2093
	// (get) Token: 0x060019A6 RID: 6566 RVA: 0x000673D4 File Offset: 0x000655D4
	// (set) Token: 0x060019A7 RID: 6567 RVA: 0x000107A1 File Offset: 0x0000E9A1
	public unsafe Il2CppReferenceArray<Toggle> m_promoToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_promoToggles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Toggle>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_promoToggles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700082E RID: 2094
	// (get) Token: 0x060019A8 RID: 6568 RVA: 0x00067404 File Offset: 0x00065604
	// (set) Token: 0x060019A9 RID: 6569 RVA: 0x000107C0 File Offset: 0x0000E9C0
	public unsafe Il2CppReferenceArray<GameObject> m_setLocks
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_setLocks);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_setLocks), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700082F RID: 2095
	// (get) Token: 0x060019AA RID: 6570 RVA: 0x00067434 File Offset: 0x00065634
	// (set) Token: 0x060019AB RID: 6571 RVA: 0x000107DF File Offset: 0x0000E9DF
	public unsafe Il2CppReferenceArray<GameObject> m_promoLocks
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_promoLocks);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_promoLocks), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000830 RID: 2096
	// (get) Token: 0x060019AC RID: 6572 RVA: 0x00067464 File Offset: 0x00065664
	// (set) Token: 0x060019AD RID: 6573 RVA: 0x000107FE File Offset: 0x0000E9FE
	public unsafe Button m_leftButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_leftButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_leftButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000831 RID: 2097
	// (get) Token: 0x060019AE RID: 6574 RVA: 0x00067494 File Offset: 0x00065694
	// (set) Token: 0x060019AF RID: 6575 RVA: 0x0001081D File Offset: 0x0000EA1D
	public unsafe Button m_rightButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_rightButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_rightButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000832 RID: 2098
	// (get) Token: 0x060019B0 RID: 6576 RVA: 0x000674C4 File Offset: 0x000656C4
	// (set) Token: 0x060019B1 RID: 6577 RVA: 0x0001083C File Offset: 0x0000EA3C
	public unsafe GameObject m_leftButtonDisabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_leftButtonDisabled);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_leftButtonDisabled), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000833 RID: 2099
	// (get) Token: 0x060019B2 RID: 6578 RVA: 0x000674F4 File Offset: 0x000656F4
	// (set) Token: 0x060019B3 RID: 6579 RVA: 0x0001085B File Offset: 0x0000EA5B
	public unsafe GameObject m_rightButtonDisabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_rightButtonDisabled);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_rightButtonDisabled), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000834 RID: 2100
	// (get) Token: 0x060019B4 RID: 6580 RVA: 0x00067524 File Offset: 0x00065724
	// (set) Token: 0x060019B5 RID: 6581 RVA: 0x0001087A File Offset: 0x0000EA7A
	public unsafe TextMeshProUGUI m_honorPool
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_honorPool);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_honorPool), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000835 RID: 2101
	// (get) Token: 0x060019B6 RID: 6582 RVA: 0x00067554 File Offset: 0x00065754
	// (set) Token: 0x060019B7 RID: 6583 RVA: 0x00010899 File Offset: 0x0000EA99
	public unsafe int m_soakTestNumPlayers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_soakTestNumPlayers);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_soakTestNumPlayers)) = value;
		}
	}

	// Token: 0x17000836 RID: 2102
	// (get) Token: 0x060019B8 RID: 6584 RVA: 0x0006757C File Offset: 0x0006577C
	// (set) Token: 0x060019B9 RID: 6585 RVA: 0x000108B4 File Offset: 0x0000EAB4
	public unsafe int m_soakTestHonorPoolAdjust
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_soakTestHonorPoolAdjust);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_soakTestHonorPoolAdjust)) = value;
		}
	}

	// Token: 0x17000837 RID: 2103
	// (get) Token: 0x060019BA RID: 6586 RVA: 0x000675A4 File Offset: 0x000657A4
	// (set) Token: 0x060019BB RID: 6587 RVA: 0x000108CF File Offset: 0x0000EACF
	public unsafe uint m_soakTestSetFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_soakTestSetFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_soakTestSetFlags)) = value;
		}
	}

	// Token: 0x17000838 RID: 2104
	// (get) Token: 0x060019BC RID: 6588 RVA: 0x000675CC File Offset: 0x000657CC
	// (set) Token: 0x060019BD RID: 6589 RVA: 0x000108EA File Offset: 0x0000EAEA
	public unsafe uint m_soakTestPromoFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_soakTestPromoFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_soakTestPromoFlags)) = value;
		}
	}

	// Token: 0x17000839 RID: 2105
	// (get) Token: 0x060019BE RID: 6590 RVA: 0x000675F4 File Offset: 0x000657F4
	// (set) Token: 0x060019BF RID: 6591 RVA: 0x00010905 File Offset: 0x0000EB05
	public unsafe bool m_bIgnoreNextEnter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_bIgnoreNextEnter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_bIgnoreNextEnter)) = value;
		}
	}

	// Token: 0x1700083A RID: 2106
	// (get) Token: 0x060019C0 RID: 6592 RVA: 0x0006761C File Offset: 0x0006581C
	// (set) Token: 0x060019C1 RID: 6593 RVA: 0x00010920 File Offset: 0x0000EB20
	public unsafe InAppPurchaseWrapper m_InAppPurchase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_InAppPurchase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<InAppPurchaseWrapper>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_InAppPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700083B RID: 2107
	// (get) Token: 0x060019C2 RID: 6594 RVA: 0x0006764C File Offset: 0x0006584C
	// (set) Token: 0x060019C3 RID: 6595 RVA: 0x0001093F File Offset: 0x0000EB3F
	public unsafe uint m_avatarSlotIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_avatarSlotIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_avatarSlotIndex)) = value;
		}
	}

	// Token: 0x1700083C RID: 2108
	// (get) Token: 0x060019C4 RID: 6596 RVA: 0x00067674 File Offset: 0x00065874
	// (set) Token: 0x060019C5 RID: 6597 RVA: 0x0001095A File Offset: 0x0000EB5A
	public unsafe uint m_setFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_setFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_setFlags)) = value;
		}
	}

	// Token: 0x1700083D RID: 2109
	// (get) Token: 0x060019C6 RID: 6598 RVA: 0x0006769C File Offset: 0x0006589C
	// (set) Token: 0x060019C7 RID: 6599 RVA: 0x00010975 File Offset: 0x0000EB75
	public unsafe uint m_promoFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_promoFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_promoFlags)) = value;
		}
	}

	// Token: 0x1700083E RID: 2110
	// (get) Token: 0x060019C8 RID: 6600 RVA: 0x000676C4 File Offset: 0x000658C4
	// (set) Token: 0x060019C9 RID: 6601 RVA: 0x00010990 File Offset: 0x0000EB90
	public unsafe int m_honorPoolAdjust
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_honorPoolAdjust);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_honorPoolAdjust)) = value;
		}
	}

	// Token: 0x1700083F RID: 2111
	// (get) Token: 0x060019CA RID: 6602 RVA: 0x000676EC File Offset: 0x000658EC
	// (set) Token: 0x060019CB RID: 6603 RVA: 0x000109AB File Offset: 0x0000EBAB
	public unsafe bool m_bIgnoreToggles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_bIgnoreToggles);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.NativeFieldInfoPtr_m_bIgnoreToggles)) = value;
		}
	}

	// Token: 0x04001161 RID: 4449
	private static readonly IntPtr NativeFieldInfoPtr_m_playerSlots;

	// Token: 0x04001162 RID: 4450
	private static readonly IntPtr NativeFieldInfoPtr_m_setToggles;

	// Token: 0x04001163 RID: 4451
	private static readonly IntPtr NativeFieldInfoPtr_m_promoToggles;

	// Token: 0x04001164 RID: 4452
	private static readonly IntPtr NativeFieldInfoPtr_m_setLocks;

	// Token: 0x04001165 RID: 4453
	private static readonly IntPtr NativeFieldInfoPtr_m_promoLocks;

	// Token: 0x04001166 RID: 4454
	private static readonly IntPtr NativeFieldInfoPtr_m_leftButton;

	// Token: 0x04001167 RID: 4455
	private static readonly IntPtr NativeFieldInfoPtr_m_rightButton;

	// Token: 0x04001168 RID: 4456
	private static readonly IntPtr NativeFieldInfoPtr_m_leftButtonDisabled;

	// Token: 0x04001169 RID: 4457
	private static readonly IntPtr NativeFieldInfoPtr_m_rightButtonDisabled;

	// Token: 0x0400116A RID: 4458
	private static readonly IntPtr NativeFieldInfoPtr_m_honorPool;

	// Token: 0x0400116B RID: 4459
	private static readonly IntPtr NativeFieldInfoPtr_m_soakTestNumPlayers;

	// Token: 0x0400116C RID: 4460
	private static readonly IntPtr NativeFieldInfoPtr_m_soakTestHonorPoolAdjust;

	// Token: 0x0400116D RID: 4461
	private static readonly IntPtr NativeFieldInfoPtr_m_soakTestSetFlags;

	// Token: 0x0400116E RID: 4462
	private static readonly IntPtr NativeFieldInfoPtr_m_soakTestPromoFlags;

	// Token: 0x0400116F RID: 4463
	private static readonly IntPtr NativeFieldInfoPtr_m_bIgnoreNextEnter;

	// Token: 0x04001170 RID: 4464
	private static readonly IntPtr NativeFieldInfoPtr_m_InAppPurchase;

	// Token: 0x04001171 RID: 4465
	private static readonly IntPtr NativeFieldInfoPtr_m_avatarSlotIndex;

	// Token: 0x04001172 RID: 4466
	private static readonly IntPtr NativeFieldInfoPtr_m_setFlags;

	// Token: 0x04001173 RID: 4467
	private static readonly IntPtr NativeFieldInfoPtr_m_promoFlags;

	// Token: 0x04001174 RID: 4468
	private static readonly IntPtr NativeFieldInfoPtr_m_honorPoolAdjust;

	// Token: 0x04001175 RID: 4469
	private static readonly IntPtr NativeFieldInfoPtr_m_bIgnoreToggles;

	// Token: 0x04001176 RID: 4470
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04001177 RID: 4471
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterMenu_Public_Void_0;

	// Token: 0x04001178 RID: 4472
	private static readonly IntPtr NativeMethodInfoPtr_HandleClickOnSlot_Public_Void_Int32_0;

	// Token: 0x04001179 RID: 4473
	private static readonly IntPtr NativeMethodInfoPtr_HandleClickOnSlotAI_Public_Void_Int32_0;

	// Token: 0x0400117A RID: 4474
	private static readonly IntPtr NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0;

	// Token: 0x0400117B RID: 4475
	private static readonly IntPtr NativeMethodInfoPtr_OnAvatarCallback_Public_Void_Int32_0;

	// Token: 0x0400117C RID: 4476
	private static readonly IntPtr NativeMethodInfoPtr_OnAvatarSelectPressed_Public_Void_Int32_0;

	// Token: 0x0400117D RID: 4477
	private static readonly IntPtr NativeMethodInfoPtr_OnGameTypeChanged_Public_Void_0;

	// Token: 0x0400117E RID: 4478
	private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayerStates_Public_Void_0;

	// Token: 0x0400117F RID: 4479
	private static readonly IntPtr NativeMethodInfoPtr_AdjustHonor_Public_Void_Boolean_0;

	// Token: 0x04001180 RID: 4480
	private static readonly IntPtr NativeMethodInfoPtr_CreateGame_Public_Void_0;

	// Token: 0x04001181 RID: 4481
	private static readonly IntPtr NativeMethodInfoPtr_RetreiveSettings_Private_Void_0;

	// Token: 0x04001182 RID: 4482
	private static readonly IntPtr NativeMethodInfoPtr_StoreSettings_Private_Void_0;

	// Token: 0x04001183 RID: 4483
	private static readonly IntPtr NativeMethodInfoPtr_HandleSoakTest_Private_IEnumerator_0;

	// Token: 0x04001184 RID: 4484
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001F6 RID: 502
	[Serializable]
	public sealed class PlayerSlot : ValueType
	{
		// Token: 0x06002822 RID: 10274 RVA: 0x00091940 File Offset: 0x0008FB40
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSlot()
		{
			Il2CppClassPointerStore<UI_OfflineCreateGame.PlayerSlot>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "PlayerSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_OfflineCreateGame.PlayerSlot>.NativeClassPtr);
			UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame.PlayerSlot>.NativeClassPtr, "root");
			UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame.PlayerSlot>.NativeClassPtr, "avatar");
			UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_avatarObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame.PlayerSlot>.NativeClassPtr, "avatarObj");
			UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame.PlayerSlot>.NativeClassPtr, "name");
			UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_nameObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame.PlayerSlot>.NativeClassPtr, "nameObj");
			UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_playerTypeObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame.PlayerSlot>.NativeClassPtr, "playerTypeObj");
			UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_aiRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame.PlayerSlot>.NativeClassPtr, "aiRoot");
			UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_aiDifficultyObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame.PlayerSlot>.NativeClassPtr, "aiDifficultyObj");
			UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_playerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame.PlayerSlot>.NativeClassPtr, "playerType");
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x00018C36 File Offset: 0x00016E36
		public PlayerSlot(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x00018C3F File Offset: 0x00016E3F
		public PlayerSlot()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_OfflineCreateGame.PlayerSlot>.NativeClassPtr))
		{
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06002825 RID: 10277 RVA: 0x00091A20 File Offset: 0x0008FC20
		// (set) Token: 0x06002826 RID: 10278 RVA: 0x00018C51 File Offset: 0x00016E51
		public unsafe GameObject root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06002827 RID: 10279 RVA: 0x00091A50 File Offset: 0x0008FC50
		// (set) Token: 0x06002828 RID: 10280 RVA: 0x00018C70 File Offset: 0x00016E70
		public unsafe Avatar_UI avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar_UI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06002829 RID: 10281 RVA: 0x00091A80 File Offset: 0x0008FC80
		// (set) Token: 0x0600282A RID: 10282 RVA: 0x00018C8F File Offset: 0x00016E8F
		public unsafe GameObject avatarObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_avatarObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_avatarObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x0600282B RID: 10283 RVA: 0x00091AB0 File Offset: 0x0008FCB0
		// (set) Token: 0x0600282C RID: 10284 RVA: 0x00018CAE File Offset: 0x00016EAE
		public unsafe TMP_InputField name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x0600282D RID: 10285 RVA: 0x00091AE0 File Offset: 0x0008FCE0
		// (set) Token: 0x0600282E RID: 10286 RVA: 0x00018CCD File Offset: 0x00016ECD
		public unsafe GameObject nameObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_nameObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_nameObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x0600282F RID: 10287 RVA: 0x00091B10 File Offset: 0x0008FD10
		// (set) Token: 0x06002830 RID: 10288 RVA: 0x00018CEC File Offset: 0x00016EEC
		public unsafe Il2CppReferenceArray<GameObject> playerTypeObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_playerTypeObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_playerTypeObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06002831 RID: 10289 RVA: 0x00091B40 File Offset: 0x0008FD40
		// (set) Token: 0x06002832 RID: 10290 RVA: 0x00018D0B File Offset: 0x00016F0B
		public unsafe GameObject aiRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_aiRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_aiRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x00091B70 File Offset: 0x0008FD70
		// (set) Token: 0x06002834 RID: 10292 RVA: 0x00018D2A File Offset: 0x00016F2A
		public unsafe Il2CppReferenceArray<GameObject> aiDifficultyObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_aiDifficultyObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_aiDifficultyObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x00091BA0 File Offset: 0x0008FDA0
		// (set) Token: 0x06002836 RID: 10294 RVA: 0x00018D49 File Offset: 0x00016F49
		public unsafe int playerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_playerType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame.PlayerSlot.NativeFieldInfoPtr_playerType)) = value;
			}
		}

		// Token: 0x04001BA4 RID: 7076
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x04001BA5 RID: 7077
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04001BA6 RID: 7078
		private static readonly IntPtr NativeFieldInfoPtr_avatarObj;

		// Token: 0x04001BA7 RID: 7079
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001BA8 RID: 7080
		private static readonly IntPtr NativeFieldInfoPtr_nameObj;

		// Token: 0x04001BA9 RID: 7081
		private static readonly IntPtr NativeFieldInfoPtr_playerTypeObj;

		// Token: 0x04001BAA RID: 7082
		private static readonly IntPtr NativeFieldInfoPtr_aiRoot;

		// Token: 0x04001BAB RID: 7083
		private static readonly IntPtr NativeFieldInfoPtr_aiDifficultyObj;

		// Token: 0x04001BAC RID: 7084
		private static readonly IntPtr NativeFieldInfoPtr_playerType;
	}

	// Token: 0x020001F7 RID: 503
	[ObfuscatedName("UI_OfflineCreateGame+<HandleSoakTest>d__35")]
	public sealed class _HandleSoakTest_d__35 : global::Il2CppSystem.Object
	{
		// Token: 0x06002837 RID: 10295 RVA: 0x00091BC8 File Offset: 0x0008FDC8
		// Note: this type is marked as 'beforefieldinit'.
		static _HandleSoakTest_d__35()
		{
			Il2CppClassPointerStore<UI_OfflineCreateGame._HandleSoakTest_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_OfflineCreateGame>.NativeClassPtr, "<HandleSoakTest>d__35");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_OfflineCreateGame._HandleSoakTest_d__35>.NativeClassPtr);
			UI_OfflineCreateGame._HandleSoakTest_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame._HandleSoakTest_d__35>.NativeClassPtr, "<>1__state");
			UI_OfflineCreateGame._HandleSoakTest_d__35.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame._HandleSoakTest_d__35>.NativeClassPtr, "<>2__current");
			UI_OfflineCreateGame._HandleSoakTest_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_OfflineCreateGame._HandleSoakTest_d__35>.NativeClassPtr, "<>4__this");
			UI_OfflineCreateGame._HandleSoakTest_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame._HandleSoakTest_d__35>.NativeClassPtr, 100666456);
			UI_OfflineCreateGame._HandleSoakTest_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame._HandleSoakTest_d__35>.NativeClassPtr, 100666457);
			UI_OfflineCreateGame._HandleSoakTest_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame._HandleSoakTest_d__35>.NativeClassPtr, 100666458);
			UI_OfflineCreateGame._HandleSoakTest_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame._HandleSoakTest_d__35>.NativeClassPtr, 100666459);
			UI_OfflineCreateGame._HandleSoakTest_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame._HandleSoakTest_d__35>.NativeClassPtr, 100666460);
			UI_OfflineCreateGame._HandleSoakTest_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_OfflineCreateGame._HandleSoakTest_d__35>.NativeClassPtr, 100666461);
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x00091CA8 File Offset: 0x0008FEA8
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _HandleSoakTest_d__35(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_OfflineCreateGame._HandleSoakTest_d__35>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame._HandleSoakTest_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x00091CF0 File Offset: 0x0008FEF0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame._HandleSoakTest_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x00091D24 File Offset: 0x0008FF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250455, XrefRangeEnd = 250476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame._HandleSoakTest_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x0600283B RID: 10299 RVA: 0x00091D60 File Offset: 0x0008FF60
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame._HandleSoakTest_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x00091DA0 File Offset: 0x0008FFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250476, XrefRangeEnd = 250481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame._HandleSoakTest_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x0600283D RID: 10301 RVA: 0x00091DD4 File Offset: 0x0008FFD4
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_OfflineCreateGame._HandleSoakTest_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x00018D64 File Offset: 0x00016F64
		public _HandleSoakTest_d__35(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x0600283F RID: 10303 RVA: 0x00091E14 File Offset: 0x00090014
		// (set) Token: 0x06002840 RID: 10304 RVA: 0x00018D6D File Offset: 0x00016F6D
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame._HandleSoakTest_d__35.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame._HandleSoakTest_d__35.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06002841 RID: 10305 RVA: 0x00091E3C File Offset: 0x0009003C
		// (set) Token: 0x06002842 RID: 10306 RVA: 0x00018D88 File Offset: 0x00016F88
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame._HandleSoakTest_d__35.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame._HandleSoakTest_d__35.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06002843 RID: 10307 RVA: 0x00091E6C File Offset: 0x0009006C
		// (set) Token: 0x06002844 RID: 10308 RVA: 0x00018DA7 File Offset: 0x00016FA7
		public unsafe UI_OfflineCreateGame __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame._HandleSoakTest_d__35.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UI_OfflineCreateGame>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_OfflineCreateGame._HandleSoakTest_d__35.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BAD RID: 7085
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001BAE RID: 7086
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001BAF RID: 7087
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001BB0 RID: 7088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001BB1 RID: 7089
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001BB2 RID: 7090
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001BB3 RID: 7091
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001BB4 RID: 7092
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001BB5 RID: 7093
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

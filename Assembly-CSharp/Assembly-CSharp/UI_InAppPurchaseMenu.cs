using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000CF RID: 207
public class UI_InAppPurchaseMenu : MonoBehaviour
{
	// Token: 0x06001911 RID: 6417 RVA: 0x00065670 File Offset: 0x00063870
	// Note: this type is marked as 'beforefieldinit'.
	static UI_InAppPurchaseMenu()
	{
		Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_InAppPurchaseMenu");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr);
		UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "m_buttons");
		UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_bundles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "m_bundles");
		UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_restorePurchaseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "m_restorePurchaseButton");
		UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_mobileBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "m_mobileBase");
		UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_steamBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "m_steamBase");
		UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_bundleDetailsPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "m_bundleDetailsPopup");
		UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_bundleDetailsButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "m_bundleDetailsButton");
		UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_bundleDetailsCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "m_bundleDetailsCost");
		UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_toggleController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "m_toggleController");
		UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_PartiallyOwnedPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "m_PartiallyOwnedPopup");
		UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_deviceID_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "m_deviceID_obj");
		UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_deviceId_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "m_deviceId_text");
		UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_IAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "m_IAP");
		UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_currentBundleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "m_currentBundleIndex");
		UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "m_startTime");
		UI_InAppPurchaseMenu.NativeFieldInfoPtr_sessionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "sessionID");
		UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_bDidPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "m_bDidPurchase");
		UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_partialOwnedPopupIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "m_partialOwnedPopupIndex");
		UI_InAppPurchaseMenu.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, 100665278);
		UI_InAppPurchaseMenu.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, 100665279);
		UI_InAppPurchaseMenu.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, 100665280);
		UI_InAppPurchaseMenu.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, 100665281);
		UI_InAppPurchaseMenu.NativeMethodInfoPtr_OnBundleDetailsPressed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, 100665282);
		UI_InAppPurchaseMenu.NativeMethodInfoPtr_OnDetailsPressed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, 100665283);
		UI_InAppPurchaseMenu.NativeMethodInfoPtr_OnPurchaseButtonPressed_Public_Void_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, 100665284);
		UI_InAppPurchaseMenu.NativeMethodInfoPtr_ClearPartialOwnershipPopup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, 100665285);
		UI_InAppPurchaseMenu.NativeMethodInfoPtr_OnPartialOwnershipPurchaseConfirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, 100665286);
		UI_InAppPurchaseMenu.NativeMethodInfoPtr_OnRestorePurchasesPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, 100665287);
		UI_InAppPurchaseMenu.NativeMethodInfoPtr_PopulateInfoPanel_Private_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, 100665288);
		UI_InAppPurchaseMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, 100665289);
	}

	// Token: 0x06001912 RID: 6418 RVA: 0x000658F8 File Offset: 0x00063AF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250005, XrefRangeEnd = 250033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_InAppPurchaseMenu.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001913 RID: 6419 RVA: 0x0006592C File Offset: 0x00063B2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250033, XrefRangeEnd = 250040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_InAppPurchaseMenu.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001914 RID: 6420 RVA: 0x00065960 File Offset: 0x00063B60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250040, XrefRangeEnd = 250050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnterMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_InAppPurchaseMenu.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001915 RID: 6421 RVA: 0x00065994 File Offset: 0x00063B94
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExitMenu(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_InAppPurchaseMenu.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001916 RID: 6422 RVA: 0x000659D4 File Offset: 0x00063BD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250050, XrefRangeEnd = 250070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBundleDetailsPressed(int bundleIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bundleIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_InAppPurchaseMenu.NativeMethodInfoPtr_OnBundleDetailsPressed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001917 RID: 6423 RVA: 0x00065A14 File Offset: 0x00063C14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250070, XrefRangeEnd = 250091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDetailsPressed(int setIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref setIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_InAppPurchaseMenu.NativeMethodInfoPtr_OnDetailsPressed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001918 RID: 6424 RVA: 0x00065A54 File Offset: 0x00063C54
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250091, XrefRangeEnd = 250105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPurchaseButtonPressed(Button pressed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pressed);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_InAppPurchaseMenu.NativeMethodInfoPtr_OnPurchaseButtonPressed_Public_Void_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001919 RID: 6425 RVA: 0x00065A98 File Offset: 0x00063C98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250105, XrefRangeEnd = 250110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearPartialOwnershipPopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_InAppPurchaseMenu.NativeMethodInfoPtr_ClearPartialOwnershipPopup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600191A RID: 6426 RVA: 0x00065ACC File Offset: 0x00063CCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250110, XrefRangeEnd = 250120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPartialOwnershipPurchaseConfirm()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_InAppPurchaseMenu.NativeMethodInfoPtr_OnPartialOwnershipPurchaseConfirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600191B RID: 6427 RVA: 0x00065B00 File Offset: 0x00063D00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250120, XrefRangeEnd = 250125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRestorePurchasesPressed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_InAppPurchaseMenu.NativeMethodInfoPtr_OnRestorePurchasesPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600191C RID: 6428 RVA: 0x00065B34 File Offset: 0x00063D34
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 250145, RefRangeEnd = 250148, XrefRangeStart = 250125, XrefRangeEnd = 250145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PopulateInfoPanel(uint index, bool bFillBundlePopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bFillBundlePopup;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_InAppPurchaseMenu.NativeMethodInfoPtr_PopulateInfoPanel_Private_Void_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600191D RID: 6429 RVA: 0x00065B80 File Offset: 0x00063D80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250148, XrefRangeEnd = 250151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_InAppPurchaseMenu()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_InAppPurchaseMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600191E RID: 6430 RVA: 0x0001028F File Offset: 0x0000E48F
	public UI_InAppPurchaseMenu(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000803 RID: 2051
	// (get) Token: 0x0600191F RID: 6431 RVA: 0x00065BBC File Offset: 0x00063DBC
	// (set) Token: 0x06001920 RID: 6432 RVA: 0x00010298 File Offset: 0x0000E498
	public unsafe Il2CppReferenceArray<UI_InAppPurchaseMenu.InAppButton> m_buttons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_buttons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UI_InAppPurchaseMenu.InAppButton>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000804 RID: 2052
	// (get) Token: 0x06001921 RID: 6433 RVA: 0x00065BEC File Offset: 0x00063DEC
	// (set) Token: 0x06001922 RID: 6434 RVA: 0x000102B7 File Offset: 0x0000E4B7
	public unsafe Il2CppReferenceArray<UI_InAppPurchaseMenu.InAppBundleDetail> m_bundles
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_bundles);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UI_InAppPurchaseMenu.InAppBundleDetail>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_bundles), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000805 RID: 2053
	// (get) Token: 0x06001923 RID: 6435 RVA: 0x00065C1C File Offset: 0x00063E1C
	// (set) Token: 0x06001924 RID: 6436 RVA: 0x000102D6 File Offset: 0x0000E4D6
	public unsafe GameObject m_restorePurchaseButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_restorePurchaseButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_restorePurchaseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000806 RID: 2054
	// (get) Token: 0x06001925 RID: 6437 RVA: 0x00065C4C File Offset: 0x00063E4C
	// (set) Token: 0x06001926 RID: 6438 RVA: 0x000102F5 File Offset: 0x0000E4F5
	public unsafe GameObject m_mobileBase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_mobileBase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_mobileBase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000807 RID: 2055
	// (get) Token: 0x06001927 RID: 6439 RVA: 0x00065C7C File Offset: 0x00063E7C
	// (set) Token: 0x06001928 RID: 6440 RVA: 0x00010314 File Offset: 0x0000E514
	public unsafe GameObject m_steamBase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_steamBase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_steamBase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000808 RID: 2056
	// (get) Token: 0x06001929 RID: 6441 RVA: 0x00065CAC File Offset: 0x00063EAC
	// (set) Token: 0x0600192A RID: 6442 RVA: 0x00010333 File Offset: 0x0000E533
	public unsafe GameObject m_bundleDetailsPopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_bundleDetailsPopup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_bundleDetailsPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000809 RID: 2057
	// (get) Token: 0x0600192B RID: 6443 RVA: 0x00065CDC File Offset: 0x00063EDC
	// (set) Token: 0x0600192C RID: 6444 RVA: 0x00010352 File Offset: 0x0000E552
	public unsafe Button m_bundleDetailsButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_bundleDetailsButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_bundleDetailsButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700080A RID: 2058
	// (get) Token: 0x0600192D RID: 6445 RVA: 0x00065D0C File Offset: 0x00063F0C
	// (set) Token: 0x0600192E RID: 6446 RVA: 0x00010371 File Offset: 0x0000E571
	public unsafe TextMeshProUGUI m_bundleDetailsCost
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_bundleDetailsCost);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_bundleDetailsCost), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700080B RID: 2059
	// (get) Token: 0x0600192F RID: 6447 RVA: 0x00065D3C File Offset: 0x00063F3C
	// (set) Token: 0x06001930 RID: 6448 RVA: 0x00010390 File Offset: 0x0000E590
	public unsafe ToggleListAnimationCortroller m_toggleController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_toggleController);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleListAnimationCortroller>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_toggleController), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700080C RID: 2060
	// (get) Token: 0x06001931 RID: 6449 RVA: 0x00065D6C File Offset: 0x00063F6C
	// (set) Token: 0x06001932 RID: 6450 RVA: 0x000103AF File Offset: 0x0000E5AF
	public unsafe GameObject m_PartiallyOwnedPopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_PartiallyOwnedPopup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_PartiallyOwnedPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700080D RID: 2061
	// (get) Token: 0x06001933 RID: 6451 RVA: 0x00065D9C File Offset: 0x00063F9C
	// (set) Token: 0x06001934 RID: 6452 RVA: 0x000103CE File Offset: 0x0000E5CE
	public unsafe GameObject m_deviceID_obj
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_deviceID_obj);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_deviceID_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700080E RID: 2062
	// (get) Token: 0x06001935 RID: 6453 RVA: 0x00065DCC File Offset: 0x00063FCC
	// (set) Token: 0x06001936 RID: 6454 RVA: 0x000103ED File Offset: 0x0000E5ED
	public unsafe TextMeshProUGUI m_deviceId_text
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_deviceId_text);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_deviceId_text), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700080F RID: 2063
	// (get) Token: 0x06001937 RID: 6455 RVA: 0x00065DFC File Offset: 0x00063FFC
	// (set) Token: 0x06001938 RID: 6456 RVA: 0x0001040C File Offset: 0x0000E60C
	public unsafe InAppPurchaseWrapper m_IAP
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_IAP);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<InAppPurchaseWrapper>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_IAP), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000810 RID: 2064
	// (get) Token: 0x06001939 RID: 6457 RVA: 0x00065E2C File Offset: 0x0006402C
	// (set) Token: 0x0600193A RID: 6458 RVA: 0x0001042B File Offset: 0x0000E62B
	public unsafe int m_currentBundleIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_currentBundleIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_currentBundleIndex)) = value;
		}
	}

	// Token: 0x17000811 RID: 2065
	// (get) Token: 0x0600193B RID: 6459 RVA: 0x00065E54 File Offset: 0x00064054
	// (set) Token: 0x0600193C RID: 6460 RVA: 0x00010446 File Offset: 0x0000E646
	public unsafe float m_startTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_startTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_startTime)) = value;
		}
	}

	// Token: 0x17000812 RID: 2066
	// (get) Token: 0x0600193D RID: 6461 RVA: 0x00065E7C File Offset: 0x0006407C
	// (set) Token: 0x0600193E RID: 6462 RVA: 0x00010461 File Offset: 0x0000E661
	public unsafe string sessionID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_sessionID);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_sessionID), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000813 RID: 2067
	// (get) Token: 0x0600193F RID: 6463 RVA: 0x00065EA4 File Offset: 0x000640A4
	// (set) Token: 0x06001940 RID: 6464 RVA: 0x00010480 File Offset: 0x0000E680
	public unsafe bool m_bDidPurchase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_bDidPurchase);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_bDidPurchase)) = value;
		}
	}

	// Token: 0x17000814 RID: 2068
	// (get) Token: 0x06001941 RID: 6465 RVA: 0x00065ECC File Offset: 0x000640CC
	// (set) Token: 0x06001942 RID: 6466 RVA: 0x0001049B File Offset: 0x0000E69B
	public unsafe int m_partialOwnedPopupIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_partialOwnedPopupIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.NativeFieldInfoPtr_m_partialOwnedPopupIndex)) = value;
		}
	}

	// Token: 0x04001113 RID: 4371
	private static readonly IntPtr NativeFieldInfoPtr_m_buttons;

	// Token: 0x04001114 RID: 4372
	private static readonly IntPtr NativeFieldInfoPtr_m_bundles;

	// Token: 0x04001115 RID: 4373
	private static readonly IntPtr NativeFieldInfoPtr_m_restorePurchaseButton;

	// Token: 0x04001116 RID: 4374
	private static readonly IntPtr NativeFieldInfoPtr_m_mobileBase;

	// Token: 0x04001117 RID: 4375
	private static readonly IntPtr NativeFieldInfoPtr_m_steamBase;

	// Token: 0x04001118 RID: 4376
	private static readonly IntPtr NativeFieldInfoPtr_m_bundleDetailsPopup;

	// Token: 0x04001119 RID: 4377
	private static readonly IntPtr NativeFieldInfoPtr_m_bundleDetailsButton;

	// Token: 0x0400111A RID: 4378
	private static readonly IntPtr NativeFieldInfoPtr_m_bundleDetailsCost;

	// Token: 0x0400111B RID: 4379
	private static readonly IntPtr NativeFieldInfoPtr_m_toggleController;

	// Token: 0x0400111C RID: 4380
	private static readonly IntPtr NativeFieldInfoPtr_m_PartiallyOwnedPopup;

	// Token: 0x0400111D RID: 4381
	private static readonly IntPtr NativeFieldInfoPtr_m_deviceID_obj;

	// Token: 0x0400111E RID: 4382
	private static readonly IntPtr NativeFieldInfoPtr_m_deviceId_text;

	// Token: 0x0400111F RID: 4383
	private static readonly IntPtr NativeFieldInfoPtr_m_IAP;

	// Token: 0x04001120 RID: 4384
	private static readonly IntPtr NativeFieldInfoPtr_m_currentBundleIndex;

	// Token: 0x04001121 RID: 4385
	private static readonly IntPtr NativeFieldInfoPtr_m_startTime;

	// Token: 0x04001122 RID: 4386
	private static readonly IntPtr NativeFieldInfoPtr_sessionID;

	// Token: 0x04001123 RID: 4387
	private static readonly IntPtr NativeFieldInfoPtr_m_bDidPurchase;

	// Token: 0x04001124 RID: 4388
	private static readonly IntPtr NativeFieldInfoPtr_m_partialOwnedPopupIndex;

	// Token: 0x04001125 RID: 4389
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04001126 RID: 4390
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04001127 RID: 4391
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterMenu_Public_Void_0;

	// Token: 0x04001128 RID: 4392
	private static readonly IntPtr NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0;

	// Token: 0x04001129 RID: 4393
	private static readonly IntPtr NativeMethodInfoPtr_OnBundleDetailsPressed_Public_Void_Int32_0;

	// Token: 0x0400112A RID: 4394
	private static readonly IntPtr NativeMethodInfoPtr_OnDetailsPressed_Public_Void_Int32_0;

	// Token: 0x0400112B RID: 4395
	private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseButtonPressed_Public_Void_Button_0;

	// Token: 0x0400112C RID: 4396
	private static readonly IntPtr NativeMethodInfoPtr_ClearPartialOwnershipPopup_Public_Void_0;

	// Token: 0x0400112D RID: 4397
	private static readonly IntPtr NativeMethodInfoPtr_OnPartialOwnershipPurchaseConfirm_Public_Void_0;

	// Token: 0x0400112E RID: 4398
	private static readonly IntPtr NativeMethodInfoPtr_OnRestorePurchasesPressed_Public_Void_0;

	// Token: 0x0400112F RID: 4399
	private static readonly IntPtr NativeMethodInfoPtr_PopulateInfoPanel_Private_Void_UInt32_Boolean_0;

	// Token: 0x04001130 RID: 4400
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001F3 RID: 499
	[Serializable]
	public sealed class InAppButton : ValueType
	{
		// Token: 0x060027F6 RID: 10230 RVA: 0x00091324 File Offset: 0x0008F524
		// Note: this type is marked as 'beforefieldinit'.
		static InAppButton()
		{
			Il2CppClassPointerStore<UI_InAppPurchaseMenu.InAppButton>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "InAppButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_InAppPurchaseMenu.InAppButton>.NativeClassPtr);
			UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu.InAppButton>.NativeClassPtr, "root");
			UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu.InAppButton>.NativeClassPtr, "button");
			UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_cost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu.InAppButton>.NativeClassPtr, "cost");
			UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu.InAppButton>.NativeClassPtr, "desc");
			UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_IAP_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu.InAppButton>.NativeClassPtr, "IAP_ID");
			UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_unlockedOnPcAndMac = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu.InAppButton>.NativeClassPtr, "unlockedOnPcAndMac");
			UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_existsInBundlePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu.InAppButton>.NativeClassPtr, "existsInBundlePopup");
			UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_isBundle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu.InAppButton>.NativeClassPtr, "isBundle");
			UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_bOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu.InAppButton>.NativeClassPtr, "bOwned");
			UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_bBundlePartiallyOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu.InAppButton>.NativeClassPtr, "bBundlePartiallyOwned");
			UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_bBundleFullyOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu.InAppButton>.NativeClassPtr, "bBundleFullyOwned");
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x00018A46 File Offset: 0x00016C46
		public InAppButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x00018A4F File Offset: 0x00016C4F
		public InAppButton()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_InAppPurchaseMenu.InAppButton>.NativeClassPtr))
		{
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x060027F9 RID: 10233 RVA: 0x0009142C File Offset: 0x0008F62C
		// (set) Token: 0x060027FA RID: 10234 RVA: 0x00018A61 File Offset: 0x00016C61
		public unsafe GameObject root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x060027FB RID: 10235 RVA: 0x0009145C File Offset: 0x0008F65C
		// (set) Token: 0x060027FC RID: 10236 RVA: 0x00018A80 File Offset: 0x00016C80
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x060027FD RID: 10237 RVA: 0x0009148C File Offset: 0x0008F68C
		// (set) Token: 0x060027FE RID: 10238 RVA: 0x00018A9F File Offset: 0x00016C9F
		public unsafe TextMeshProUGUI cost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_cost);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_cost), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x060027FF RID: 10239 RVA: 0x000914BC File Offset: 0x0008F6BC
		// (set) Token: 0x06002800 RID: 10240 RVA: 0x00018ABE File Offset: 0x00016CBE
		public unsafe TextMeshProUGUI desc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_desc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_desc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06002801 RID: 10241 RVA: 0x000914EC File Offset: 0x0008F6EC
		// (set) Token: 0x06002802 RID: 10242 RVA: 0x00018ADD File Offset: 0x00016CDD
		public unsafe string IAP_ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_IAP_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_IAP_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06002803 RID: 10243 RVA: 0x00091514 File Offset: 0x0008F714
		// (set) Token: 0x06002804 RID: 10244 RVA: 0x00018AFC File Offset: 0x00016CFC
		public unsafe bool unlockedOnPcAndMac
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_unlockedOnPcAndMac);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_unlockedOnPcAndMac)) = value;
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06002805 RID: 10245 RVA: 0x0009153C File Offset: 0x0008F73C
		// (set) Token: 0x06002806 RID: 10246 RVA: 0x00018B17 File Offset: 0x00016D17
		public unsafe bool existsInBundlePopup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_existsInBundlePopup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_existsInBundlePopup)) = value;
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06002807 RID: 10247 RVA: 0x00091564 File Offset: 0x0008F764
		// (set) Token: 0x06002808 RID: 10248 RVA: 0x00018B32 File Offset: 0x00016D32
		public unsafe bool isBundle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_isBundle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_isBundle)) = value;
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06002809 RID: 10249 RVA: 0x0009158C File Offset: 0x0008F78C
		// (set) Token: 0x0600280A RID: 10250 RVA: 0x00018B4D File Offset: 0x00016D4D
		public unsafe bool bOwned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_bOwned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_bOwned)) = value;
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x000915B4 File Offset: 0x0008F7B4
		// (set) Token: 0x0600280C RID: 10252 RVA: 0x00018B68 File Offset: 0x00016D68
		public unsafe bool bBundlePartiallyOwned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_bBundlePartiallyOwned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_bBundlePartiallyOwned)) = value;
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x0600280D RID: 10253 RVA: 0x000915DC File Offset: 0x0008F7DC
		// (set) Token: 0x0600280E RID: 10254 RVA: 0x00018B83 File Offset: 0x00016D83
		public unsafe bool bBundleFullyOwned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_bBundleFullyOwned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppButton.NativeFieldInfoPtr_bBundleFullyOwned)) = value;
			}
		}

		// Token: 0x04001B8F RID: 7055
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x04001B90 RID: 7056
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04001B91 RID: 7057
		private static readonly IntPtr NativeFieldInfoPtr_cost;

		// Token: 0x04001B92 RID: 7058
		private static readonly IntPtr NativeFieldInfoPtr_desc;

		// Token: 0x04001B93 RID: 7059
		private static readonly IntPtr NativeFieldInfoPtr_IAP_ID;

		// Token: 0x04001B94 RID: 7060
		private static readonly IntPtr NativeFieldInfoPtr_unlockedOnPcAndMac;

		// Token: 0x04001B95 RID: 7061
		private static readonly IntPtr NativeFieldInfoPtr_existsInBundlePopup;

		// Token: 0x04001B96 RID: 7062
		private static readonly IntPtr NativeFieldInfoPtr_isBundle;

		// Token: 0x04001B97 RID: 7063
		private static readonly IntPtr NativeFieldInfoPtr_bOwned;

		// Token: 0x04001B98 RID: 7064
		private static readonly IntPtr NativeFieldInfoPtr_bBundlePartiallyOwned;

		// Token: 0x04001B99 RID: 7065
		private static readonly IntPtr NativeFieldInfoPtr_bBundleFullyOwned;
	}

	// Token: 0x020001F4 RID: 500
	[Serializable]
	public sealed class InAppBundleDetail : ValueType
	{
		// Token: 0x0600280F RID: 10255 RVA: 0x00091604 File Offset: 0x0008F804
		// Note: this type is marked as 'beforefieldinit'.
		static InAppBundleDetail()
		{
			Il2CppClassPointerStore<UI_InAppPurchaseMenu.InAppBundleDetail>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UI_InAppPurchaseMenu>.NativeClassPtr, "InAppBundleDetail");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_InAppPurchaseMenu.InAppBundleDetail>.NativeClassPtr);
			UI_InAppPurchaseMenu.InAppBundleDetail.NativeFieldInfoPtr_buttonIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu.InAppBundleDetail>.NativeClassPtr, "buttonIndex");
			UI_InAppPurchaseMenu.InAppBundleDetail.NativeFieldInfoPtr_containsIndexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_InAppPurchaseMenu.InAppBundleDetail>.NativeClassPtr, "containsIndexes");
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x00018B9E File Offset: 0x00016D9E
		public InAppBundleDetail(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x00018BA7 File Offset: 0x00016DA7
		public InAppBundleDetail()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_InAppPurchaseMenu.InAppBundleDetail>.NativeClassPtr))
		{
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06002812 RID: 10258 RVA: 0x00091658 File Offset: 0x0008F858
		// (set) Token: 0x06002813 RID: 10259 RVA: 0x00018BB9 File Offset: 0x00016DB9
		public unsafe int buttonIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppBundleDetail.NativeFieldInfoPtr_buttonIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppBundleDetail.NativeFieldInfoPtr_buttonIndex)) = value;
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x06002814 RID: 10260 RVA: 0x00091680 File Offset: 0x0008F880
		// (set) Token: 0x06002815 RID: 10261 RVA: 0x00018BD4 File Offset: 0x00016DD4
		public unsafe Il2CppStructArray<int> containsIndexes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppBundleDetail.NativeFieldInfoPtr_containsIndexes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_InAppPurchaseMenu.InAppBundleDetail.NativeFieldInfoPtr_containsIndexes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B9A RID: 7066
		private static readonly IntPtr NativeFieldInfoPtr_buttonIndex;

		// Token: 0x04001B9B RID: 7067
		private static readonly IntPtr NativeFieldInfoPtr_containsIndexes;
	}
}

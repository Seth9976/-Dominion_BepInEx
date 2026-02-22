using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020000D1 RID: 209
public class UI_Login : MonoBehaviour
{
	// Token: 0x06001951 RID: 6481 RVA: 0x00066184 File Offset: 0x00064384
	// Note: this type is marked as 'beforefieldinit'.
	static UI_Login()
	{
		Il2CppClassPointerStore<UI_Login>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_Login");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_Login>.NativeClassPtr);
		UI_Login.NativeFieldInfoPtr_m_emailPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, "m_emailPrompt");
		UI_Login.NativeFieldInfoPtr_m_usernamePrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, "m_usernamePrompt");
		UI_Login.NativeFieldInfoPtr_m_passwordPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, "m_passwordPrompt");
		UI_Login.NativeFieldInfoPtr_m_rememberPasswordCheckBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, "m_rememberPasswordCheckBox");
		UI_Login.NativeFieldInfoPtr_m_connectionPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, "m_connectionPopup");
		UI_Login.NativeFieldInfoPtr_m_connectionPopupBackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, "m_connectionPopupBackButton");
		UI_Login.NativeFieldInfoPtr_m_connectionPopupMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, "m_connectionPopupMessage");
		UI_Login.NativeFieldInfoPtr_m_PopupAccountInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, "m_PopupAccountInfo");
		UI_Login.NativeFieldInfoPtr_m_ignoreAccountInfoCheckBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, "m_ignoreAccountInfoCheckBox");
		UI_Login.NativeFieldInfoPtr_m_ButtonDone_HaveNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, "m_ButtonDone_HaveNone");
		UI_Login.NativeFieldInfoPtr_m_ButtonCancel_HaveNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, "m_ButtonCancel_HaveNone");
		UI_Login.NativeFieldInfoPtr_m_ConnectWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, "m_ConnectWaitTime");
		UI_Login.NativeFieldInfoPtr_k_MinConnectWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, "k_MinConnectWaitTime");
		UI_Login.NativeFieldInfoPtr_k_MaxConnectWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, "k_MaxConnectWaitTime");
		UI_Login.NativeFieldInfoPtr_m_system = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, "m_system");
		UI_Login.NativeFieldInfoPtr_m_bHandlePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, "m_bHandlePopup");
		UI_Login.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, 100665294);
		UI_Login.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, 100665295);
		UI_Login.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, 100665296);
		UI_Login.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, 100665297);
		UI_Login.NativeMethodInfoPtr_OnClickLoginButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, 100665298);
		UI_Login.NativeMethodInfoPtr_OnClickForgotPasswordButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, 100665299);
		UI_Login.NativeMethodInfoPtr_RetreiveSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, 100665300);
		UI_Login.NativeMethodInfoPtr_StoreSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, 100665301);
		UI_Login.NativeMethodInfoPtr_Submit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, 100665302);
		UI_Login.NativeMethodInfoPtr_ValidatedAccountInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, 100665303);
		UI_Login.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_Login>.NativeClassPtr, 100665304);
	}

	// Token: 0x06001952 RID: 6482 RVA: 0x000663D0 File Offset: 0x000645D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250222, XrefRangeEnd = 250245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Login.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001953 RID: 6483 RVA: 0x00066404 File Offset: 0x00064604
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250245, XrefRangeEnd = 250268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Login.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001954 RID: 6484 RVA: 0x00066438 File Offset: 0x00064638
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250268, XrefRangeEnd = 250309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnterMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Login.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001955 RID: 6485 RVA: 0x0006646C File Offset: 0x0006466C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250309, XrefRangeEnd = 250336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExitMenu(bool bUnderPopup)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUnderPopup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Login.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001956 RID: 6486 RVA: 0x000664AC File Offset: 0x000646AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250336, XrefRangeEnd = 250337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClickLoginButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Login.NativeMethodInfoPtr_OnClickLoginButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001957 RID: 6487 RVA: 0x000664E0 File Offset: 0x000646E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250337, XrefRangeEnd = 250347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClickForgotPasswordButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Login.NativeMethodInfoPtr_OnClickForgotPasswordButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001958 RID: 6488 RVA: 0x00066514 File Offset: 0x00064714
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250347, XrefRangeEnd = 250365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RetreiveSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Login.NativeMethodInfoPtr_RetreiveSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001959 RID: 6489 RVA: 0x00066548 File Offset: 0x00064748
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250365, XrefRangeEnd = 250378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StoreSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Login.NativeMethodInfoPtr_StoreSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600195A RID: 6490 RVA: 0x0006657C File Offset: 0x0006477C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 250389, RefRangeEnd = 250391, XrefRangeStart = 250378, XrefRangeEnd = 250389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Submit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Login.NativeMethodInfoPtr_Submit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600195B RID: 6491 RVA: 0x000665B0 File Offset: 0x000647B0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 250400, RefRangeEnd = 250401, XrefRangeStart = 250391, XrefRangeEnd = 250400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ValidatedAccountInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Login.NativeMethodInfoPtr_ValidatedAccountInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600195C RID: 6492 RVA: 0x000665EC File Offset: 0x000647EC
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_Login()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_Login>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_Login.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600195D RID: 6493 RVA: 0x0001053B File Offset: 0x0000E73B
	public UI_Login(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000819 RID: 2073
	// (get) Token: 0x0600195E RID: 6494 RVA: 0x00066628 File Offset: 0x00064828
	// (set) Token: 0x0600195F RID: 6495 RVA: 0x00010544 File Offset: 0x0000E744
	public unsafe TMP_InputField m_emailPrompt
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_emailPrompt);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_emailPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700081A RID: 2074
	// (get) Token: 0x06001960 RID: 6496 RVA: 0x00066658 File Offset: 0x00064858
	// (set) Token: 0x06001961 RID: 6497 RVA: 0x00010563 File Offset: 0x0000E763
	public unsafe TMP_InputField m_usernamePrompt
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_usernamePrompt);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_usernamePrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700081B RID: 2075
	// (get) Token: 0x06001962 RID: 6498 RVA: 0x00066688 File Offset: 0x00064888
	// (set) Token: 0x06001963 RID: 6499 RVA: 0x00010582 File Offset: 0x0000E782
	public unsafe TMP_InputField m_passwordPrompt
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_passwordPrompt);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_passwordPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700081C RID: 2076
	// (get) Token: 0x06001964 RID: 6500 RVA: 0x000666B8 File Offset: 0x000648B8
	// (set) Token: 0x06001965 RID: 6501 RVA: 0x000105A1 File Offset: 0x0000E7A1
	public unsafe Toggle m_rememberPasswordCheckBox
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_rememberPasswordCheckBox);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_rememberPasswordCheckBox), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700081D RID: 2077
	// (get) Token: 0x06001966 RID: 6502 RVA: 0x000666E8 File Offset: 0x000648E8
	// (set) Token: 0x06001967 RID: 6503 RVA: 0x000105C0 File Offset: 0x0000E7C0
	public unsafe GameObject m_connectionPopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_connectionPopup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_connectionPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700081E RID: 2078
	// (get) Token: 0x06001968 RID: 6504 RVA: 0x00066718 File Offset: 0x00064918
	// (set) Token: 0x06001969 RID: 6505 RVA: 0x000105DF File Offset: 0x0000E7DF
	public unsafe GameObject m_connectionPopupBackButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_connectionPopupBackButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_connectionPopupBackButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700081F RID: 2079
	// (get) Token: 0x0600196A RID: 6506 RVA: 0x00066748 File Offset: 0x00064948
	// (set) Token: 0x0600196B RID: 6507 RVA: 0x000105FE File Offset: 0x0000E7FE
	public unsafe TextMeshProUGUI m_connectionPopupMessage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_connectionPopupMessage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_connectionPopupMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000820 RID: 2080
	// (get) Token: 0x0600196C RID: 6508 RVA: 0x00066778 File Offset: 0x00064978
	// (set) Token: 0x0600196D RID: 6509 RVA: 0x0001061D File Offset: 0x0000E81D
	public unsafe GameObject m_PopupAccountInfo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_PopupAccountInfo);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_PopupAccountInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000821 RID: 2081
	// (get) Token: 0x0600196E RID: 6510 RVA: 0x000667A8 File Offset: 0x000649A8
	// (set) Token: 0x0600196F RID: 6511 RVA: 0x0001063C File Offset: 0x0000E83C
	public unsafe Toggle m_ignoreAccountInfoCheckBox
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_ignoreAccountInfoCheckBox);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_ignoreAccountInfoCheckBox), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000822 RID: 2082
	// (get) Token: 0x06001970 RID: 6512 RVA: 0x000667D8 File Offset: 0x000649D8
	// (set) Token: 0x06001971 RID: 6513 RVA: 0x0001065B File Offset: 0x0000E85B
	public unsafe GameObject m_ButtonDone_HaveNone
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_ButtonDone_HaveNone);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_ButtonDone_HaveNone), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000823 RID: 2083
	// (get) Token: 0x06001972 RID: 6514 RVA: 0x00066808 File Offset: 0x00064A08
	// (set) Token: 0x06001973 RID: 6515 RVA: 0x0001067A File Offset: 0x0000E87A
	public unsafe GameObject m_ButtonCancel_HaveNone
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_ButtonCancel_HaveNone);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_ButtonCancel_HaveNone), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000824 RID: 2084
	// (get) Token: 0x06001974 RID: 6516 RVA: 0x00066838 File Offset: 0x00064A38
	// (set) Token: 0x06001975 RID: 6517 RVA: 0x00010699 File Offset: 0x0000E899
	public unsafe float m_ConnectWaitTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_ConnectWaitTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_ConnectWaitTime)) = value;
		}
	}

	// Token: 0x17000825 RID: 2085
	// (get) Token: 0x06001976 RID: 6518 RVA: 0x00066860 File Offset: 0x00064A60
	// (set) Token: 0x06001977 RID: 6519 RVA: 0x000106B4 File Offset: 0x0000E8B4
	public unsafe static float k_MinConnectWaitTime
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(UI_Login.NativeFieldInfoPtr_k_MinConnectWaitTime, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(UI_Login.NativeFieldInfoPtr_k_MinConnectWaitTime, (void*)(&value));
		}
	}

	// Token: 0x17000826 RID: 2086
	// (get) Token: 0x06001978 RID: 6520 RVA: 0x0006687C File Offset: 0x00064A7C
	// (set) Token: 0x06001979 RID: 6521 RVA: 0x000106C2 File Offset: 0x0000E8C2
	public unsafe static float k_MaxConnectWaitTime
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(UI_Login.NativeFieldInfoPtr_k_MaxConnectWaitTime, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(UI_Login.NativeFieldInfoPtr_k_MaxConnectWaitTime, (void*)(&value));
		}
	}

	// Token: 0x17000827 RID: 2087
	// (get) Token: 0x0600197A RID: 6522 RVA: 0x00066898 File Offset: 0x00064A98
	// (set) Token: 0x0600197B RID: 6523 RVA: 0x000106D0 File Offset: 0x0000E8D0
	public unsafe EventSystem m_system
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_system);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_system), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000828 RID: 2088
	// (get) Token: 0x0600197C RID: 6524 RVA: 0x000668C8 File Offset: 0x00064AC8
	// (set) Token: 0x0600197D RID: 6525 RVA: 0x000106EF File Offset: 0x0000E8EF
	public unsafe bool m_bHandlePopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_bHandlePopup);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_Login.NativeFieldInfoPtr_m_bHandlePopup)) = value;
		}
	}

	// Token: 0x04001139 RID: 4409
	private static readonly IntPtr NativeFieldInfoPtr_m_emailPrompt;

	// Token: 0x0400113A RID: 4410
	private static readonly IntPtr NativeFieldInfoPtr_m_usernamePrompt;

	// Token: 0x0400113B RID: 4411
	private static readonly IntPtr NativeFieldInfoPtr_m_passwordPrompt;

	// Token: 0x0400113C RID: 4412
	private static readonly IntPtr NativeFieldInfoPtr_m_rememberPasswordCheckBox;

	// Token: 0x0400113D RID: 4413
	private static readonly IntPtr NativeFieldInfoPtr_m_connectionPopup;

	// Token: 0x0400113E RID: 4414
	private static readonly IntPtr NativeFieldInfoPtr_m_connectionPopupBackButton;

	// Token: 0x0400113F RID: 4415
	private static readonly IntPtr NativeFieldInfoPtr_m_connectionPopupMessage;

	// Token: 0x04001140 RID: 4416
	private static readonly IntPtr NativeFieldInfoPtr_m_PopupAccountInfo;

	// Token: 0x04001141 RID: 4417
	private static readonly IntPtr NativeFieldInfoPtr_m_ignoreAccountInfoCheckBox;

	// Token: 0x04001142 RID: 4418
	private static readonly IntPtr NativeFieldInfoPtr_m_ButtonDone_HaveNone;

	// Token: 0x04001143 RID: 4419
	private static readonly IntPtr NativeFieldInfoPtr_m_ButtonCancel_HaveNone;

	// Token: 0x04001144 RID: 4420
	private static readonly IntPtr NativeFieldInfoPtr_m_ConnectWaitTime;

	// Token: 0x04001145 RID: 4421
	private static readonly IntPtr NativeFieldInfoPtr_k_MinConnectWaitTime;

	// Token: 0x04001146 RID: 4422
	private static readonly IntPtr NativeFieldInfoPtr_k_MaxConnectWaitTime;

	// Token: 0x04001147 RID: 4423
	private static readonly IntPtr NativeFieldInfoPtr_m_system;

	// Token: 0x04001148 RID: 4424
	private static readonly IntPtr NativeFieldInfoPtr_m_bHandlePopup;

	// Token: 0x04001149 RID: 4425
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x0400114A RID: 4426
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x0400114B RID: 4427
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterMenu_Public_Void_0;

	// Token: 0x0400114C RID: 4428
	private static readonly IntPtr NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0;

	// Token: 0x0400114D RID: 4429
	private static readonly IntPtr NativeMethodInfoPtr_OnClickLoginButton_Public_Void_0;

	// Token: 0x0400114E RID: 4430
	private static readonly IntPtr NativeMethodInfoPtr_OnClickForgotPasswordButton_Public_Void_0;

	// Token: 0x0400114F RID: 4431
	private static readonly IntPtr NativeMethodInfoPtr_RetreiveSettings_Private_Void_0;

	// Token: 0x04001150 RID: 4432
	private static readonly IntPtr NativeMethodInfoPtr_StoreSettings_Private_Void_0;

	// Token: 0x04001151 RID: 4433
	private static readonly IntPtr NativeMethodInfoPtr_Submit_Private_Void_0;

	// Token: 0x04001152 RID: 4434
	private static readonly IntPtr NativeMethodInfoPtr_ValidatedAccountInput_Private_Boolean_0;

	// Token: 0x04001153 RID: 4435
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

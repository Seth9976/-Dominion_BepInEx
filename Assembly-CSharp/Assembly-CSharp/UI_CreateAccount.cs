using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020000CC RID: 204
public class UI_CreateAccount : MonoBehaviour
{
	// Token: 0x06001892 RID: 6290 RVA: 0x00063FF0 File Offset: 0x000621F0
	// Note: this type is marked as 'beforefieldinit'.
	static UI_CreateAccount()
	{
		Il2CppClassPointerStore<UI_CreateAccount>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UI_CreateAccount");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UI_CreateAccount>.NativeClassPtr);
		UI_CreateAccount.NativeFieldInfoPtr_m_emailLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CreateAccount>.NativeClassPtr, "m_emailLabel");
		UI_CreateAccount.NativeFieldInfoPtr_m_nameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CreateAccount>.NativeClassPtr, "m_nameLabel");
		UI_CreateAccount.NativeFieldInfoPtr_m_pwdLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CreateAccount>.NativeClassPtr, "m_pwdLabel");
		UI_CreateAccount.NativeFieldInfoPtr_m_confirmPwdLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CreateAccount>.NativeClassPtr, "m_confirmPwdLabel");
		UI_CreateAccount.NativeFieldInfoPtr_m_tosAgree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CreateAccount>.NativeClassPtr, "m_tosAgree");
		UI_CreateAccount.NativeFieldInfoPtr_m_bHandlePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CreateAccount>.NativeClassPtr, "m_bHandlePopup");
		UI_CreateAccount.NativeFieldInfoPtr_m_system = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UI_CreateAccount>.NativeClassPtr, "m_system");
		UI_CreateAccount.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CreateAccount>.NativeClassPtr, 100665245);
		UI_CreateAccount.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CreateAccount>.NativeClassPtr, 100665246);
		UI_CreateAccount.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CreateAccount>.NativeClassPtr, 100665247);
		UI_CreateAccount.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CreateAccount>.NativeClassPtr, 100665248);
		UI_CreateAccount.NativeMethodInfoPtr_OnCreateAccount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CreateAccount>.NativeClassPtr, 100665249);
		UI_CreateAccount.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UI_CreateAccount>.NativeClassPtr, 100665250);
	}

	// Token: 0x06001893 RID: 6291 RVA: 0x00064124 File Offset: 0x00062324
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249551, XrefRangeEnd = 249555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CreateAccount.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001894 RID: 6292 RVA: 0x00064158 File Offset: 0x00062358
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249555, XrefRangeEnd = 249578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CreateAccount.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001895 RID: 6293 RVA: 0x0006418C File Offset: 0x0006238C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249578, XrefRangeEnd = 249601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnterMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CreateAccount.NativeMethodInfoPtr_OnEnterMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001896 RID: 6294 RVA: 0x000641C0 File Offset: 0x000623C0
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CreateAccount.NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001897 RID: 6295 RVA: 0x00064200 File Offset: 0x00062400
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249601, XrefRangeEnd = 249641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCreateAccount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CreateAccount.NativeMethodInfoPtr_OnCreateAccount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001898 RID: 6296 RVA: 0x00064234 File Offset: 0x00062434
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UI_CreateAccount()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UI_CreateAccount>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UI_CreateAccount.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001899 RID: 6297 RVA: 0x0000FD48 File Offset: 0x0000DF48
	public UI_CreateAccount(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170007D7 RID: 2007
	// (get) Token: 0x0600189A RID: 6298 RVA: 0x00064270 File Offset: 0x00062470
	// (set) Token: 0x0600189B RID: 6299 RVA: 0x0000FD51 File Offset: 0x0000DF51
	public unsafe TMP_InputField m_emailLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CreateAccount.NativeFieldInfoPtr_m_emailLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CreateAccount.NativeFieldInfoPtr_m_emailLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007D8 RID: 2008
	// (get) Token: 0x0600189C RID: 6300 RVA: 0x000642A0 File Offset: 0x000624A0
	// (set) Token: 0x0600189D RID: 6301 RVA: 0x0000FD70 File Offset: 0x0000DF70
	public unsafe TMP_InputField m_nameLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CreateAccount.NativeFieldInfoPtr_m_nameLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CreateAccount.NativeFieldInfoPtr_m_nameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007D9 RID: 2009
	// (get) Token: 0x0600189E RID: 6302 RVA: 0x000642D0 File Offset: 0x000624D0
	// (set) Token: 0x0600189F RID: 6303 RVA: 0x0000FD8F File Offset: 0x0000DF8F
	public unsafe TMP_InputField m_pwdLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CreateAccount.NativeFieldInfoPtr_m_pwdLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CreateAccount.NativeFieldInfoPtr_m_pwdLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007DA RID: 2010
	// (get) Token: 0x060018A0 RID: 6304 RVA: 0x00064300 File Offset: 0x00062500
	// (set) Token: 0x060018A1 RID: 6305 RVA: 0x0000FDAE File Offset: 0x0000DFAE
	public unsafe TMP_InputField m_confirmPwdLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CreateAccount.NativeFieldInfoPtr_m_confirmPwdLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CreateAccount.NativeFieldInfoPtr_m_confirmPwdLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007DB RID: 2011
	// (get) Token: 0x060018A2 RID: 6306 RVA: 0x00064330 File Offset: 0x00062530
	// (set) Token: 0x060018A3 RID: 6307 RVA: 0x0000FDCD File Offset: 0x0000DFCD
	public unsafe Toggle m_tosAgree
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CreateAccount.NativeFieldInfoPtr_m_tosAgree);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CreateAccount.NativeFieldInfoPtr_m_tosAgree), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170007DC RID: 2012
	// (get) Token: 0x060018A4 RID: 6308 RVA: 0x00064360 File Offset: 0x00062560
	// (set) Token: 0x060018A5 RID: 6309 RVA: 0x0000FDEC File Offset: 0x0000DFEC
	public unsafe bool m_bHandlePopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CreateAccount.NativeFieldInfoPtr_m_bHandlePopup);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CreateAccount.NativeFieldInfoPtr_m_bHandlePopup)) = value;
		}
	}

	// Token: 0x170007DD RID: 2013
	// (get) Token: 0x060018A6 RID: 6310 RVA: 0x00064388 File Offset: 0x00062588
	// (set) Token: 0x060018A7 RID: 6311 RVA: 0x0000FE07 File Offset: 0x0000E007
	public unsafe EventSystem m_system
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CreateAccount.NativeFieldInfoPtr_m_system);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UI_CreateAccount.NativeFieldInfoPtr_m_system), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040010C6 RID: 4294
	private static readonly IntPtr NativeFieldInfoPtr_m_emailLabel;

	// Token: 0x040010C7 RID: 4295
	private static readonly IntPtr NativeFieldInfoPtr_m_nameLabel;

	// Token: 0x040010C8 RID: 4296
	private static readonly IntPtr NativeFieldInfoPtr_m_pwdLabel;

	// Token: 0x040010C9 RID: 4297
	private static readonly IntPtr NativeFieldInfoPtr_m_confirmPwdLabel;

	// Token: 0x040010CA RID: 4298
	private static readonly IntPtr NativeFieldInfoPtr_m_tosAgree;

	// Token: 0x040010CB RID: 4299
	private static readonly IntPtr NativeFieldInfoPtr_m_bHandlePopup;

	// Token: 0x040010CC RID: 4300
	private static readonly IntPtr NativeFieldInfoPtr_m_system;

	// Token: 0x040010CD RID: 4301
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040010CE RID: 4302
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x040010CF RID: 4303
	private static readonly IntPtr NativeMethodInfoPtr_OnEnterMenu_Public_Void_0;

	// Token: 0x040010D0 RID: 4304
	private static readonly IntPtr NativeMethodInfoPtr_OnExitMenu_Public_Void_Boolean_0;

	// Token: 0x040010D1 RID: 4305
	private static readonly IntPtr NativeMethodInfoPtr_OnCreateAccount_Public_Void_0;

	// Token: 0x040010D2 RID: 4306
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

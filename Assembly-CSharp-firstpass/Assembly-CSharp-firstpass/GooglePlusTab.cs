using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

// Token: 0x0200011F RID: 287
public class GooglePlusTab : FeatureTab
{
	// Token: 0x060013C8 RID: 5064 RVA: 0x0005B504 File Offset: 0x00059704
	// Note: this type is marked as 'beforefieldinit'.
	static GooglePlusTab()
	{
		Il2CppClassPointerStore<GooglePlusTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GooglePlusTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlusTab>.NativeClassPtr);
		GooglePlusTab.NativeFieldInfoPtr_Abuttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlusTab>.NativeClassPtr, "Abuttons");
		GooglePlusTab.NativeFieldInfoPtr_PlusButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlusTab>.NativeClassPtr, "PlusButton");
		GooglePlusTab.NativeFieldInfoPtr_PlusUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlusTab>.NativeClassPtr, "PlusUrl");
		GooglePlusTab.NativeMethodInfoPtr_CreatePlusButtons_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlusTab>.NativeClassPtr, 100665681);
		GooglePlusTab.NativeMethodInfoPtr_HideButtons_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlusTab>.NativeClassPtr, 100665682);
		GooglePlusTab.NativeMethodInfoPtr_ShoweButtons_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlusTab>.NativeClassPtr, 100665683);
		GooglePlusTab.NativeMethodInfoPtr_CreateRandomPostButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlusTab>.NativeClassPtr, 100665684);
		GooglePlusTab.NativeMethodInfoPtr_ChangePosPostButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlusTab>.NativeClassPtr, 100665685);
		GooglePlusTab.NativeMethodInfoPtr_ButtonClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlusTab>.NativeClassPtr, 100665686);
		GooglePlusTab.NativeMethodInfoPtr_SendInvitation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlusTab>.NativeClassPtr, 100665687);
		GooglePlusTab.NativeMethodInfoPtr_HandleActionAppInvitesSent_Private_Void_GP_SendAppInvitesResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlusTab>.NativeClassPtr, 100665688);
		GooglePlusTab.NativeMethodInfoPtr_GetInvitation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlusTab>.NativeClassPtr, 100665689);
		GooglePlusTab.NativeMethodInfoPtr_HandleActionAppInviteRetrieved_Private_Void_GP_RetrieveAppInviteResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlusTab>.NativeClassPtr, 100665690);
		GooglePlusTab.NativeMethodInfoPtr_AddNewFriends_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlusTab>.NativeClassPtr, 100665691);
		GooglePlusTab.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlusTab>.NativeClassPtr, 100665692);
		GooglePlusTab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlusTab>.NativeClassPtr, 100665693);
	}

	// Token: 0x060013C9 RID: 5065 RVA: 0x0005B674 File Offset: 0x00059874
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185600, XrefRangeEnd = 185649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreatePlusButtons()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlusTab.NativeMethodInfoPtr_CreatePlusButtons_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013CA RID: 5066 RVA: 0x0005B6A8 File Offset: 0x000598A8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 185664, RefRangeEnd = 185665, XrefRangeStart = 185649, XrefRangeEnd = 185664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideButtons()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlusTab.NativeMethodInfoPtr_HideButtons_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013CB RID: 5067 RVA: 0x0005B6DC File Offset: 0x000598DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185665, XrefRangeEnd = 185680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShoweButtons()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlusTab.NativeMethodInfoPtr_ShoweButtons_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013CC RID: 5068 RVA: 0x0005B710 File Offset: 0x00059910
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185680, XrefRangeEnd = 185697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateRandomPostButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlusTab.NativeMethodInfoPtr_CreateRandomPostButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013CD RID: 5069 RVA: 0x0005B744 File Offset: 0x00059944
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185697, XrefRangeEnd = 185702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangePosPostButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlusTab.NativeMethodInfoPtr_ChangePosPostButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013CE RID: 5070 RVA: 0x0005B778 File Offset: 0x00059978
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185702, XrefRangeEnd = 185707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ButtonClicked()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlusTab.NativeMethodInfoPtr_ButtonClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013CF RID: 5071 RVA: 0x0005B7AC File Offset: 0x000599AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185707, XrefRangeEnd = 185742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendInvitation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlusTab.NativeMethodInfoPtr_SendInvitation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013D0 RID: 5072 RVA: 0x0005B7E0 File Offset: 0x000599E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185742, XrefRangeEnd = 185782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleActionAppInvitesSent(GP_SendAppInvitesResult res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlusTab.NativeMethodInfoPtr_HandleActionAppInvitesSent_Private_Void_GP_SendAppInvitesResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013D1 RID: 5073 RVA: 0x0005B824 File Offset: 0x00059A24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185782, XrefRangeEnd = 185802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetInvitation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlusTab.NativeMethodInfoPtr_GetInvitation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013D2 RID: 5074 RVA: 0x0005B858 File Offset: 0x00059A58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185802, XrefRangeEnd = 185824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleActionAppInviteRetrieved(GP_RetrieveAppInviteResult res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlusTab.NativeMethodInfoPtr_HandleActionAppInviteRetrieved_Private_Void_GP_RetrieveAppInviteResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013D3 RID: 5075 RVA: 0x0005B89C File Offset: 0x00059A9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185824, XrefRangeEnd = 185834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddNewFriends()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlusTab.NativeMethodInfoPtr_AddNewFriends_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013D4 RID: 5076 RVA: 0x0005B8D0 File Offset: 0x00059AD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185834, XrefRangeEnd = 185836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlusTab.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013D5 RID: 5077 RVA: 0x0005B904 File Offset: 0x00059B04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185836, XrefRangeEnd = 185845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePlusTab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlusTab>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlusTab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013D6 RID: 5078 RVA: 0x00009BED File Offset: 0x00007DED
	public GooglePlusTab(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005C2 RID: 1474
	// (get) Token: 0x060013D7 RID: 5079 RVA: 0x0005B940 File Offset: 0x00059B40
	// (set) Token: 0x060013D8 RID: 5080 RVA: 0x00009BF6 File Offset: 0x00007DF6
	public unsafe List<AN_PlusButton> Abuttons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlusTab.NativeFieldInfoPtr_Abuttons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AN_PlusButton>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlusTab.NativeFieldInfoPtr_Abuttons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005C3 RID: 1475
	// (get) Token: 0x060013D9 RID: 5081 RVA: 0x0005B970 File Offset: 0x00059B70
	// (set) Token: 0x060013DA RID: 5082 RVA: 0x00009C15 File Offset: 0x00007E15
	public unsafe AN_PlusButton PlusButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlusTab.NativeFieldInfoPtr_PlusButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AN_PlusButton>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlusTab.NativeFieldInfoPtr_PlusButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005C4 RID: 1476
	// (get) Token: 0x060013DB RID: 5083 RVA: 0x0005B9A0 File Offset: 0x00059BA0
	// (set) Token: 0x060013DC RID: 5084 RVA: 0x00009C34 File Offset: 0x00007E34
	public unsafe string PlusUrl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlusTab.NativeFieldInfoPtr_PlusUrl);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlusTab.NativeFieldInfoPtr_PlusUrl), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000F16 RID: 3862
	private static readonly IntPtr NativeFieldInfoPtr_Abuttons;

	// Token: 0x04000F17 RID: 3863
	private static readonly IntPtr NativeFieldInfoPtr_PlusButton;

	// Token: 0x04000F18 RID: 3864
	private static readonly IntPtr NativeFieldInfoPtr_PlusUrl;

	// Token: 0x04000F19 RID: 3865
	private static readonly IntPtr NativeMethodInfoPtr_CreatePlusButtons_Public_Void_0;

	// Token: 0x04000F1A RID: 3866
	private static readonly IntPtr NativeMethodInfoPtr_HideButtons_Public_Void_0;

	// Token: 0x04000F1B RID: 3867
	private static readonly IntPtr NativeMethodInfoPtr_ShoweButtons_Public_Void_0;

	// Token: 0x04000F1C RID: 3868
	private static readonly IntPtr NativeMethodInfoPtr_CreateRandomPostButton_Public_Void_0;

	// Token: 0x04000F1D RID: 3869
	private static readonly IntPtr NativeMethodInfoPtr_ChangePosPostButton_Public_Void_0;

	// Token: 0x04000F1E RID: 3870
	private static readonly IntPtr NativeMethodInfoPtr_ButtonClicked_Private_Void_0;

	// Token: 0x04000F1F RID: 3871
	private static readonly IntPtr NativeMethodInfoPtr_SendInvitation_Private_Void_0;

	// Token: 0x04000F20 RID: 3872
	private static readonly IntPtr NativeMethodInfoPtr_HandleActionAppInvitesSent_Private_Void_GP_SendAppInvitesResult_0;

	// Token: 0x04000F21 RID: 3873
	private static readonly IntPtr NativeMethodInfoPtr_GetInvitation_Private_Void_0;

	// Token: 0x04000F22 RID: 3874
	private static readonly IntPtr NativeMethodInfoPtr_HandleActionAppInviteRetrieved_Private_Void_GP_RetrieveAppInviteResult_0;

	// Token: 0x04000F23 RID: 3875
	private static readonly IntPtr NativeMethodInfoPtr_AddNewFriends_Private_Void_0;

	// Token: 0x04000F24 RID: 3876
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000F25 RID: 3877
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

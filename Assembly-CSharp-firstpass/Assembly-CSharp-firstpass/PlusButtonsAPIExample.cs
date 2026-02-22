using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000125 RID: 293
public class PlusButtonsAPIExample : MonoBehaviour
{
	// Token: 0x06001433 RID: 5171 RVA: 0x0005CFA0 File Offset: 0x0005B1A0
	// Note: this type is marked as 'beforefieldinit'.
	static PlusButtonsAPIExample()
	{
		Il2CppClassPointerStore<PlusButtonsAPIExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "PlusButtonsAPIExample");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlusButtonsAPIExample>.NativeClassPtr);
		PlusButtonsAPIExample.NativeFieldInfoPtr_Abuttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlusButtonsAPIExample>.NativeClassPtr, "Abuttons");
		PlusButtonsAPIExample.NativeFieldInfoPtr_PlusButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlusButtonsAPIExample>.NativeClassPtr, "PlusButton");
		PlusButtonsAPIExample.NativeFieldInfoPtr_PlusUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlusButtonsAPIExample>.NativeClassPtr, "PlusUrl");
		PlusButtonsAPIExample.NativeMethodInfoPtr_CreatePlusButtons_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlusButtonsAPIExample>.NativeClassPtr, 100665758);
		PlusButtonsAPIExample.NativeMethodInfoPtr_HideButtons_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlusButtonsAPIExample>.NativeClassPtr, 100665759);
		PlusButtonsAPIExample.NativeMethodInfoPtr_ShoweButtons_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlusButtonsAPIExample>.NativeClassPtr, 100665760);
		PlusButtonsAPIExample.NativeMethodInfoPtr_CreateRandomPostButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlusButtonsAPIExample>.NativeClassPtr, 100665761);
		PlusButtonsAPIExample.NativeMethodInfoPtr_ChangePosPostButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlusButtonsAPIExample>.NativeClassPtr, 100665762);
		PlusButtonsAPIExample.NativeMethodInfoPtr_ButtonClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlusButtonsAPIExample>.NativeClassPtr, 100665763);
		PlusButtonsAPIExample.NativeMethodInfoPtr_SendInvitation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlusButtonsAPIExample>.NativeClassPtr, 100665764);
		PlusButtonsAPIExample.NativeMethodInfoPtr_HandleActionAppInvitesSent_Private_Void_GP_SendAppInvitesResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlusButtonsAPIExample>.NativeClassPtr, 100665765);
		PlusButtonsAPIExample.NativeMethodInfoPtr_GetInvitation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlusButtonsAPIExample>.NativeClassPtr, 100665766);
		PlusButtonsAPIExample.NativeMethodInfoPtr_HandleActionAppInviteRetrieved_Private_Void_GP_RetrieveAppInviteResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlusButtonsAPIExample>.NativeClassPtr, 100665767);
		PlusButtonsAPIExample.NativeMethodInfoPtr_AddNewFriends_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlusButtonsAPIExample>.NativeClassPtr, 100665768);
		PlusButtonsAPIExample.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlusButtonsAPIExample>.NativeClassPtr, 100665769);
		PlusButtonsAPIExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlusButtonsAPIExample>.NativeClassPtr, 100665770);
	}

	// Token: 0x06001434 RID: 5172 RVA: 0x0005D110 File Offset: 0x0005B310
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186986, XrefRangeEnd = 187035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreatePlusButtons()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlusButtonsAPIExample.NativeMethodInfoPtr_CreatePlusButtons_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001435 RID: 5173 RVA: 0x0005D144 File Offset: 0x0005B344
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 187050, RefRangeEnd = 187051, XrefRangeStart = 187035, XrefRangeEnd = 187050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideButtons()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlusButtonsAPIExample.NativeMethodInfoPtr_HideButtons_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001436 RID: 5174 RVA: 0x0005D178 File Offset: 0x0005B378
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187051, XrefRangeEnd = 187066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShoweButtons()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlusButtonsAPIExample.NativeMethodInfoPtr_ShoweButtons_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001437 RID: 5175 RVA: 0x0005D1AC File Offset: 0x0005B3AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187066, XrefRangeEnd = 187083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateRandomPostButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlusButtonsAPIExample.NativeMethodInfoPtr_CreateRandomPostButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001438 RID: 5176 RVA: 0x0005D1E0 File Offset: 0x0005B3E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangePosPostButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlusButtonsAPIExample.NativeMethodInfoPtr_ChangePosPostButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001439 RID: 5177 RVA: 0x0005D214 File Offset: 0x0005B414
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187083, XrefRangeEnd = 187088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ButtonClicked()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlusButtonsAPIExample.NativeMethodInfoPtr_ButtonClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600143A RID: 5178 RVA: 0x0005D248 File Offset: 0x0005B448
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187088, XrefRangeEnd = 187123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendInvitation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlusButtonsAPIExample.NativeMethodInfoPtr_SendInvitation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600143B RID: 5179 RVA: 0x0005D27C File Offset: 0x0005B47C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187123, XrefRangeEnd = 187164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleActionAppInvitesSent(GP_SendAppInvitesResult res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlusButtonsAPIExample.NativeMethodInfoPtr_HandleActionAppInvitesSent_Private_Void_GP_SendAppInvitesResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600143C RID: 5180 RVA: 0x0005D2C0 File Offset: 0x0005B4C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187164, XrefRangeEnd = 187184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetInvitation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlusButtonsAPIExample.NativeMethodInfoPtr_GetInvitation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600143D RID: 5181 RVA: 0x0005D2F4 File Offset: 0x0005B4F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187184, XrefRangeEnd = 187207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleActionAppInviteRetrieved(GP_RetrieveAppInviteResult res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlusButtonsAPIExample.NativeMethodInfoPtr_HandleActionAppInviteRetrieved_Private_Void_GP_RetrieveAppInviteResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600143E RID: 5182 RVA: 0x0005D338 File Offset: 0x0005B538
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187207, XrefRangeEnd = 187217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddNewFriends()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlusButtonsAPIExample.NativeMethodInfoPtr_AddNewFriends_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600143F RID: 5183 RVA: 0x0005D36C File Offset: 0x0005B56C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187217, XrefRangeEnd = 187219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlusButtonsAPIExample.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001440 RID: 5184 RVA: 0x0005D3A0 File Offset: 0x0005B5A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187219, XrefRangeEnd = 187228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlusButtonsAPIExample()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlusButtonsAPIExample>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlusButtonsAPIExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001441 RID: 5185 RVA: 0x00009D36 File Offset: 0x00007F36
	public PlusButtonsAPIExample(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005CB RID: 1483
	// (get) Token: 0x06001442 RID: 5186 RVA: 0x0005D3DC File Offset: 0x0005B5DC
	// (set) Token: 0x06001443 RID: 5187 RVA: 0x00009D3F File Offset: 0x00007F3F
	public unsafe List<AN_PlusButton> Abuttons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlusButtonsAPIExample.NativeFieldInfoPtr_Abuttons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AN_PlusButton>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlusButtonsAPIExample.NativeFieldInfoPtr_Abuttons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005CC RID: 1484
	// (get) Token: 0x06001444 RID: 5188 RVA: 0x0005D40C File Offset: 0x0005B60C
	// (set) Token: 0x06001445 RID: 5189 RVA: 0x00009D5E File Offset: 0x00007F5E
	public unsafe AN_PlusButton PlusButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlusButtonsAPIExample.NativeFieldInfoPtr_PlusButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AN_PlusButton>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlusButtonsAPIExample.NativeFieldInfoPtr_PlusButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005CD RID: 1485
	// (get) Token: 0x06001446 RID: 5190 RVA: 0x0005D43C File Offset: 0x0005B63C
	// (set) Token: 0x06001447 RID: 5191 RVA: 0x00009D7D File Offset: 0x00007F7D
	public unsafe string PlusUrl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlusButtonsAPIExample.NativeFieldInfoPtr_PlusUrl);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlusButtonsAPIExample.NativeFieldInfoPtr_PlusUrl), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000F6C RID: 3948
	private static readonly IntPtr NativeFieldInfoPtr_Abuttons;

	// Token: 0x04000F6D RID: 3949
	private static readonly IntPtr NativeFieldInfoPtr_PlusButton;

	// Token: 0x04000F6E RID: 3950
	private static readonly IntPtr NativeFieldInfoPtr_PlusUrl;

	// Token: 0x04000F6F RID: 3951
	private static readonly IntPtr NativeMethodInfoPtr_CreatePlusButtons_Public_Void_0;

	// Token: 0x04000F70 RID: 3952
	private static readonly IntPtr NativeMethodInfoPtr_HideButtons_Public_Void_0;

	// Token: 0x04000F71 RID: 3953
	private static readonly IntPtr NativeMethodInfoPtr_ShoweButtons_Public_Void_0;

	// Token: 0x04000F72 RID: 3954
	private static readonly IntPtr NativeMethodInfoPtr_CreateRandomPostButton_Public_Void_0;

	// Token: 0x04000F73 RID: 3955
	private static readonly IntPtr NativeMethodInfoPtr_ChangePosPostButton_Public_Void_0;

	// Token: 0x04000F74 RID: 3956
	private static readonly IntPtr NativeMethodInfoPtr_ButtonClicked_Private_Void_0;

	// Token: 0x04000F75 RID: 3957
	private static readonly IntPtr NativeMethodInfoPtr_SendInvitation_Private_Void_0;

	// Token: 0x04000F76 RID: 3958
	private static readonly IntPtr NativeMethodInfoPtr_HandleActionAppInvitesSent_Private_Void_GP_SendAppInvitesResult_0;

	// Token: 0x04000F77 RID: 3959
	private static readonly IntPtr NativeMethodInfoPtr_GetInvitation_Private_Void_0;

	// Token: 0x04000F78 RID: 3960
	private static readonly IntPtr NativeMethodInfoPtr_HandleActionAppInviteRetrieved_Private_Void_GP_RetrieveAppInviteResult_0;

	// Token: 0x04000F79 RID: 3961
	private static readonly IntPtr NativeMethodInfoPtr_AddNewFriends_Private_Void_0;

	// Token: 0x04000F7A RID: 3962
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000F7B RID: 3963
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

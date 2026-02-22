using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000132 RID: 306
public class FacebookAndroidTurnBasedAndGiftsExample : MonoBehaviour
{
	// Token: 0x06001639 RID: 5689 RVA: 0x00063678 File Offset: 0x00061878
	// Note: this type is marked as 'beforefieldinit'.
	static FacebookAndroidTurnBasedAndGiftsExample()
	{
		Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FacebookAndroidTurnBasedAndGiftsExample");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr);
		FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_IsUserInfoLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, "IsUserInfoLoaded");
		FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_IsAuntificated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, "IsAuntificated");
		FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_ConnectionDependedntButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, "ConnectionDependedntButtons");
		FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_connectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, "connectButton");
		FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, "avatar");
		FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, "Location");
		FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_Language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, "Language");
		FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_Mail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, "Mail");
		FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, "Name");
		FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_BombItemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, "BombItemId");
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665968);
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665969);
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_RetriveAppRequests_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665970);
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_OnAppRequestsLoaded_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665971);
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_SendTrunhRequest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665972);
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_SendTrunhRequestToSpecifiedFriend_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665973);
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_AskItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665974);
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_SendItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665975);
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_SendInv_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665976);
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_SendInvToSpecifayedFirend_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665977);
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_SendToSpecifiedFriend_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665978);
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_OnAppRequestCompleteAction_Private_Void_FB_AppRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665979);
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_Connect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665980);
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_LoadUserData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665981);
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_OnFocusChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665982);
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_OnUserDataLoaded_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665983);
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_OnInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665984);
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_OnAuth_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665985);
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_LogOut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665986);
		FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr, 100665987);
	}

	// Token: 0x0600163A RID: 5690 RVA: 0x00063900 File Offset: 0x00061B00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191834, XrefRangeEnd = 191873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600163B RID: 5691 RVA: 0x00063934 File Offset: 0x00061B34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191873, XrefRangeEnd = 191899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600163C RID: 5692 RVA: 0x00063968 File Offset: 0x00061B68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191899, XrefRangeEnd = 191919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RetriveAppRequests()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_RetriveAppRequests_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600163D RID: 5693 RVA: 0x0006399C File Offset: 0x00061B9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191919, XrefRangeEnd = 191970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAppRequestsLoaded(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_OnAppRequestsLoaded_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600163E RID: 5694 RVA: 0x000639E0 File Offset: 0x00061BE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191970, XrefRangeEnd = 191983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendTrunhRequest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_SendTrunhRequest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600163F RID: 5695 RVA: 0x00063A14 File Offset: 0x00061C14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191983, XrefRangeEnd = 192031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendTrunhRequestToSpecifiedFriend()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_SendTrunhRequestToSpecifiedFriend_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001640 RID: 5696 RVA: 0x00063A48 File Offset: 0x00061C48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192031, XrefRangeEnd = 192044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AskItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_AskItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001641 RID: 5697 RVA: 0x00063A7C File Offset: 0x00061C7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192044, XrefRangeEnd = 192057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_SendItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001642 RID: 5698 RVA: 0x00063AB0 File Offset: 0x00061CB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192057, XrefRangeEnd = 192083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendInv()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_SendInv_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001643 RID: 5699 RVA: 0x00063AE4 File Offset: 0x00061CE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192083, XrefRangeEnd = 192119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendInvToSpecifayedFirend()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_SendInvToSpecifayedFirend_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001644 RID: 5700 RVA: 0x00063B18 File Offset: 0x00061D18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192119, XrefRangeEnd = 192155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendToSpecifiedFriend()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_SendToSpecifiedFriend_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001645 RID: 5701 RVA: 0x00063B4C File Offset: 0x00061D4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192155, XrefRangeEnd = 192204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAppRequestCompleteAction(FB_AppRequestResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_OnAppRequestCompleteAction_Private_Void_FB_AppRequestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001646 RID: 5702 RVA: 0x00063B90 File Offset: 0x00061D90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192204, XrefRangeEnd = 192245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Connect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_Connect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001647 RID: 5703 RVA: 0x00063BC4 File Offset: 0x00061DC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192245, XrefRangeEnd = 192268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadUserData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_LoadUserData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001648 RID: 5704 RVA: 0x00063BF8 File Offset: 0x00061DF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192268, XrefRangeEnd = 192270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnFocusChanged(bool focus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref focus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_OnFocusChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001649 RID: 5705 RVA: 0x00063C38 File Offset: 0x00061E38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192270, XrefRangeEnd = 192305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUserDataLoaded(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_OnUserDataLoaded_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600164A RID: 5706 RVA: 0x00063C7C File Offset: 0x00061E7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192305, XrefRangeEnd = 192319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_OnInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600164B RID: 5707 RVA: 0x00063CB0 File Offset: 0x00061EB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192319, XrefRangeEnd = 192362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAuth(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_OnAuth_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600164C RID: 5708 RVA: 0x00063CF4 File Offset: 0x00061EF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192362, XrefRangeEnd = 192375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LogOut()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr_LogOut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600164D RID: 5709 RVA: 0x00063D28 File Offset: 0x00061F28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192375, XrefRangeEnd = 192395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FacebookAndroidTurnBasedAndGiftsExample()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacebookAndroidTurnBasedAndGiftsExample>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookAndroidTurnBasedAndGiftsExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600164E RID: 5710 RVA: 0x0000AE3E File Offset: 0x0000903E
	public FacebookAndroidTurnBasedAndGiftsExample(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000658 RID: 1624
	// (get) Token: 0x0600164F RID: 5711 RVA: 0x00063D64 File Offset: 0x00061F64
	// (set) Token: 0x06001650 RID: 5712 RVA: 0x0000AE47 File Offset: 0x00009047
	public unsafe static bool IsUserInfoLoaded
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_IsUserInfoLoaded, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_IsUserInfoLoaded, (void*)(&value));
		}
	}

	// Token: 0x17000659 RID: 1625
	// (get) Token: 0x06001651 RID: 5713 RVA: 0x00063D80 File Offset: 0x00061F80
	// (set) Token: 0x06001652 RID: 5714 RVA: 0x0000AE55 File Offset: 0x00009055
	public unsafe static bool IsAuntificated
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_IsAuntificated, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_IsAuntificated, (void*)(&value));
		}
	}

	// Token: 0x1700065A RID: 1626
	// (get) Token: 0x06001653 RID: 5715 RVA: 0x00063D9C File Offset: 0x00061F9C
	// (set) Token: 0x06001654 RID: 5716 RVA: 0x0000AE63 File Offset: 0x00009063
	public unsafe Il2CppReferenceArray<DefaultPreviewButton> ConnectionDependedntButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_ConnectionDependedntButtons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DefaultPreviewButton>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_ConnectionDependedntButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700065B RID: 1627
	// (get) Token: 0x06001655 RID: 5717 RVA: 0x00063DCC File Offset: 0x00061FCC
	// (set) Token: 0x06001656 RID: 5718 RVA: 0x0000AE82 File Offset: 0x00009082
	public unsafe DefaultPreviewButton connectButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_connectButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultPreviewButton>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_connectButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700065C RID: 1628
	// (get) Token: 0x06001657 RID: 5719 RVA: 0x00063DFC File Offset: 0x00061FFC
	// (set) Token: 0x06001658 RID: 5720 RVA: 0x0000AEA1 File Offset: 0x000090A1
	public unsafe SA_Texture avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Texture>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700065D RID: 1629
	// (get) Token: 0x06001659 RID: 5721 RVA: 0x00063E2C File Offset: 0x0006202C
	// (set) Token: 0x0600165A RID: 5722 RVA: 0x0000AEC0 File Offset: 0x000090C0
	public unsafe SA_Label Location
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_Location);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_Location), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700065E RID: 1630
	// (get) Token: 0x0600165B RID: 5723 RVA: 0x00063E5C File Offset: 0x0006205C
	// (set) Token: 0x0600165C RID: 5724 RVA: 0x0000AEDF File Offset: 0x000090DF
	public unsafe SA_Label Language
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_Language);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_Language), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700065F RID: 1631
	// (get) Token: 0x0600165D RID: 5725 RVA: 0x00063E8C File Offset: 0x0006208C
	// (set) Token: 0x0600165E RID: 5726 RVA: 0x0000AEFE File Offset: 0x000090FE
	public unsafe SA_Label Mail
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_Mail);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_Mail), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000660 RID: 1632
	// (get) Token: 0x0600165F RID: 5727 RVA: 0x00063EBC File Offset: 0x000620BC
	// (set) Token: 0x06001660 RID: 5728 RVA: 0x0000AF1D File Offset: 0x0000911D
	public unsafe SA_Label Name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_Name);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000661 RID: 1633
	// (get) Token: 0x06001661 RID: 5729 RVA: 0x00063EEC File Offset: 0x000620EC
	// (set) Token: 0x06001662 RID: 5730 RVA: 0x0000AF3C File Offset: 0x0000913C
	public unsafe string BombItemId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_BombItemId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookAndroidTurnBasedAndGiftsExample.NativeFieldInfoPtr_BombItemId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040010CB RID: 4299
	private static readonly IntPtr NativeFieldInfoPtr_IsUserInfoLoaded;

	// Token: 0x040010CC RID: 4300
	private static readonly IntPtr NativeFieldInfoPtr_IsAuntificated;

	// Token: 0x040010CD RID: 4301
	private static readonly IntPtr NativeFieldInfoPtr_ConnectionDependedntButtons;

	// Token: 0x040010CE RID: 4302
	private static readonly IntPtr NativeFieldInfoPtr_connectButton;

	// Token: 0x040010CF RID: 4303
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x040010D0 RID: 4304
	private static readonly IntPtr NativeFieldInfoPtr_Location;

	// Token: 0x040010D1 RID: 4305
	private static readonly IntPtr NativeFieldInfoPtr_Language;

	// Token: 0x040010D2 RID: 4306
	private static readonly IntPtr NativeFieldInfoPtr_Mail;

	// Token: 0x040010D3 RID: 4307
	private static readonly IntPtr NativeFieldInfoPtr_Name;

	// Token: 0x040010D4 RID: 4308
	private static readonly IntPtr NativeFieldInfoPtr_BombItemId;

	// Token: 0x040010D5 RID: 4309
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040010D6 RID: 4310
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x040010D7 RID: 4311
	private static readonly IntPtr NativeMethodInfoPtr_RetriveAppRequests_Public_Void_0;

	// Token: 0x040010D8 RID: 4312
	private static readonly IntPtr NativeMethodInfoPtr_OnAppRequestsLoaded_Private_Void_FB_Result_0;

	// Token: 0x040010D9 RID: 4313
	private static readonly IntPtr NativeMethodInfoPtr_SendTrunhRequest_Public_Void_0;

	// Token: 0x040010DA RID: 4314
	private static readonly IntPtr NativeMethodInfoPtr_SendTrunhRequestToSpecifiedFriend_Public_Void_0;

	// Token: 0x040010DB RID: 4315
	private static readonly IntPtr NativeMethodInfoPtr_AskItem_Public_Void_0;

	// Token: 0x040010DC RID: 4316
	private static readonly IntPtr NativeMethodInfoPtr_SendItem_Public_Void_0;

	// Token: 0x040010DD RID: 4317
	private static readonly IntPtr NativeMethodInfoPtr_SendInv_Public_Void_0;

	// Token: 0x040010DE RID: 4318
	private static readonly IntPtr NativeMethodInfoPtr_SendInvToSpecifayedFirend_Public_Void_0;

	// Token: 0x040010DF RID: 4319
	private static readonly IntPtr NativeMethodInfoPtr_SendToSpecifiedFriend_Public_Void_0;

	// Token: 0x040010E0 RID: 4320
	private static readonly IntPtr NativeMethodInfoPtr_OnAppRequestCompleteAction_Private_Void_FB_AppRequestResult_0;

	// Token: 0x040010E1 RID: 4321
	private static readonly IntPtr NativeMethodInfoPtr_Connect_Private_Void_0;

	// Token: 0x040010E2 RID: 4322
	private static readonly IntPtr NativeMethodInfoPtr_LoadUserData_Private_Void_0;

	// Token: 0x040010E3 RID: 4323
	private static readonly IntPtr NativeMethodInfoPtr_OnFocusChanged_Private_Void_Boolean_0;

	// Token: 0x040010E4 RID: 4324
	private static readonly IntPtr NativeMethodInfoPtr_OnUserDataLoaded_Private_Void_FB_Result_0;

	// Token: 0x040010E5 RID: 4325
	private static readonly IntPtr NativeMethodInfoPtr_OnInit_Private_Void_0;

	// Token: 0x040010E6 RID: 4326
	private static readonly IntPtr NativeMethodInfoPtr_OnAuth_Private_Void_FB_Result_0;

	// Token: 0x040010E7 RID: 4327
	private static readonly IntPtr NativeMethodInfoPtr_LogOut_Private_Void_0;

	// Token: 0x040010E8 RID: 4328
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

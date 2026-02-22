using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000136 RID: 310
public class TwitterApiTab : FeatureTab
{
	// Token: 0x060016DB RID: 5851 RVA: 0x00065918 File Offset: 0x00063B18
	// Note: this type is marked as 'beforefieldinit'.
	static TwitterApiTab()
	{
		Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TwitterApiTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr);
		TwitterApiTab.NativeFieldInfoPtr_IsUserInfoLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, "IsUserInfoLoaded");
		TwitterApiTab.NativeFieldInfoPtr_IsAuthenticated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, "IsAuthenticated");
		TwitterApiTab.NativeFieldInfoPtr_ImageToShare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, "ImageToShare");
		TwitterApiTab.NativeFieldInfoPtr_ConnectButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, "ConnectButtonText");
		TwitterApiTab.NativeFieldInfoPtr_ConnectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, "ConnectButton");
		TwitterApiTab.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, "Avatar");
		TwitterApiTab.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, "Location");
		TwitterApiTab.NativeFieldInfoPtr_Language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, "Language");
		TwitterApiTab.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, "Status");
		TwitterApiTab.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, "Name");
		TwitterApiTab.NativeFieldInfoPtr_AuthDependedButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, "AuthDependedButtons");
		TwitterApiTab.NativeFieldInfoPtr_AvatarSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, "AvatarSprite");
		TwitterApiTab.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666054);
		TwitterApiTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666055);
		TwitterApiTab.NativeMethodInfoPtr_Connect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666056);
		TwitterApiTab.NativeMethodInfoPtr_PostWithAuthCheck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666057);
		TwitterApiTab.NativeMethodInfoPtr_PostNativeScreenshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666058);
		TwitterApiTab.NativeMethodInfoPtr_PostMSG_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666059);
		TwitterApiTab.NativeMethodInfoPtr_PostImage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666060);
		TwitterApiTab.NativeMethodInfoPtr_PostTWScreenshot_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666061);
		TwitterApiTab.NativeMethodInfoPtr_LoadUserData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666062);
		TwitterApiTab.NativeMethodInfoPtr_Test_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666063);
		TwitterApiTab.NativeMethodInfoPtr_OnResult_Private_Void_TW_APIRequstResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666064);
		TwitterApiTab.NativeMethodInfoPtr_PostMessage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666065);
		TwitterApiTab.NativeMethodInfoPtr_PostScreehShot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666066);
		TwitterApiTab.NativeMethodInfoPtr_OnUserDataRequestCompleteAction_Private_Void_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666067);
		TwitterApiTab.NativeMethodInfoPtr_OnPostingCompleteAction_Private_Void_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666068);
		TwitterApiTab.NativeMethodInfoPtr_OnAuthCompleteAction_Private_Void_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666069);
		TwitterApiTab.NativeMethodInfoPtr_OnTwitterInitedAction_Private_Void_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666070);
		TwitterApiTab.NativeMethodInfoPtr_OnAuth_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666071);
		TwitterApiTab.NativeMethodInfoPtr_RetrieveTimeLine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666072);
		TwitterApiTab.NativeMethodInfoPtr_UserLookUpRequest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666073);
		TwitterApiTab.NativeMethodInfoPtr_FriedsidsRequest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666074);
		TwitterApiTab.NativeMethodInfoPtr_FollowersidsRequest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666075);
		TwitterApiTab.NativeMethodInfoPtr_TweetSearch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666076);
		TwitterApiTab.NativeMethodInfoPtr_OnIdsLoaded_Private_Void_TW_APIRequstResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666077);
		TwitterApiTab.NativeMethodInfoPtr_OnLookUpRequestComplete_Private_Void_TW_APIRequstResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666078);
		TwitterApiTab.NativeMethodInfoPtr_OnSearchRequestComplete_Private_Void_TW_APIRequstResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666079);
		TwitterApiTab.NativeMethodInfoPtr_OnTimeLineRequestComplete_Private_Void_TW_APIRequstResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666080);
		TwitterApiTab.NativeMethodInfoPtr_PostScreenshot_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666081);
		TwitterApiTab.NativeMethodInfoPtr_LogOut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666082);
		TwitterApiTab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, 100666083);
	}

	// Token: 0x060016DC RID: 5852 RVA: 0x00065C90 File Offset: 0x00063E90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193312, XrefRangeEnd = 193358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016DD RID: 5853 RVA: 0x00065CC4 File Offset: 0x00063EC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193358, XrefRangeEnd = 193374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016DE RID: 5854 RVA: 0x00065CF8 File Offset: 0x00063EF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193374, XrefRangeEnd = 193398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Connect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_Connect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016DF RID: 5855 RVA: 0x00065D2C File Offset: 0x00063F2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193398, XrefRangeEnd = 193408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostWithAuthCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_PostWithAuthCheck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016E0 RID: 5856 RVA: 0x00065D60 File Offset: 0x00063F60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193408, XrefRangeEnd = 193413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostNativeScreenshot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_PostNativeScreenshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016E1 RID: 5857 RVA: 0x00065D94 File Offset: 0x00063F94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193413, XrefRangeEnd = 193423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostMSG()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_PostMSG_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016E2 RID: 5858 RVA: 0x00065DC8 File Offset: 0x00063FC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193423, XrefRangeEnd = 193433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostImage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_PostImage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016E3 RID: 5859 RVA: 0x00065DFC File Offset: 0x00063FFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193433, XrefRangeEnd = 193437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator PostTWScreenshot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_PostTWScreenshot_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060016E4 RID: 5860 RVA: 0x00065E3C File Offset: 0x0006403C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193437, XrefRangeEnd = 193445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadUserData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_LoadUserData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016E5 RID: 5861 RVA: 0x00065E70 File Offset: 0x00064070
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193445, XrefRangeEnd = 193459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Test()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_Test_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016E6 RID: 5862 RVA: 0x00065EA4 File Offset: 0x000640A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193459, XrefRangeEnd = 193471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnResult(TW_APIRequstResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_OnResult_Private_Void_TW_APIRequstResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016E7 RID: 5863 RVA: 0x00065EE8 File Offset: 0x000640E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193471, XrefRangeEnd = 193481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_PostMessage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016E8 RID: 5864 RVA: 0x00065F1C File Offset: 0x0006411C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193481, XrefRangeEnd = 193486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostScreehShot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_PostScreehShot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016E9 RID: 5865 RVA: 0x00065F50 File Offset: 0x00064150
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193486, XrefRangeEnd = 193538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUserDataRequestCompleteAction(TWResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_OnUserDataRequestCompleteAction_Private_Void_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016EA RID: 5866 RVA: 0x00065F94 File Offset: 0x00064194
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193538, XrefRangeEnd = 193549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPostingCompleteAction(TWResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_OnPostingCompleteAction_Private_Void_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016EB RID: 5867 RVA: 0x00065FD8 File Offset: 0x000641D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193549, XrefRangeEnd = 193553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAuthCompleteAction(TWResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_OnAuthCompleteAction_Private_Void_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016EC RID: 5868 RVA: 0x0006601C File Offset: 0x0006421C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193553, XrefRangeEnd = 193563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTwitterInitedAction(TWResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_OnTwitterInitedAction_Private_Void_TWResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016ED RID: 5869 RVA: 0x00066060 File Offset: 0x00064260
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193563, XrefRangeEnd = 193567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAuth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_OnAuth_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016EE RID: 5870 RVA: 0x00066094 File Offset: 0x00064294
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193567, XrefRangeEnd = 193589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RetrieveTimeLine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_RetrieveTimeLine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016EF RID: 5871 RVA: 0x000660C8 File Offset: 0x000642C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193589, XrefRangeEnd = 193614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UserLookUpRequest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_UserLookUpRequest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016F0 RID: 5872 RVA: 0x000660FC File Offset: 0x000642FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193614, XrefRangeEnd = 193631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FriedsidsRequest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_FriedsidsRequest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016F1 RID: 5873 RVA: 0x00066130 File Offset: 0x00064330
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193631, XrefRangeEnd = 193648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FollowersidsRequest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_FollowersidsRequest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016F2 RID: 5874 RVA: 0x00066164 File Offset: 0x00064364
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193648, XrefRangeEnd = 193670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TweetSearch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_TweetSearch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016F3 RID: 5875 RVA: 0x00066198 File Offset: 0x00064398
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193670, XrefRangeEnd = 193681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnIdsLoaded(TW_APIRequstResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_OnIdsLoaded_Private_Void_TW_APIRequstResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016F4 RID: 5876 RVA: 0x000661DC File Offset: 0x000643DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193681, XrefRangeEnd = 193707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLookUpRequestComplete(TW_APIRequstResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_OnLookUpRequestComplete_Private_Void_TW_APIRequstResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016F5 RID: 5877 RVA: 0x00066220 File Offset: 0x00064420
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193707, XrefRangeEnd = 193726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSearchRequestComplete(TW_APIRequstResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_OnSearchRequestComplete_Private_Void_TW_APIRequstResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016F6 RID: 5878 RVA: 0x00066264 File Offset: 0x00064464
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193726, XrefRangeEnd = 193745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTimeLineRequestComplete(TW_APIRequstResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_OnTimeLineRequestComplete_Private_Void_TW_APIRequstResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060016F7 RID: 5879 RVA: 0x000662A8 File Offset: 0x000644A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193745, XrefRangeEnd = 193749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator PostScreenshot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_PostScreenshot_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060016F8 RID: 5880 RVA: 0x000662E8 File Offset: 0x000644E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193749, XrefRangeEnd = 193762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LogOut()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr_LogOut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016F9 RID: 5881 RVA: 0x0006631C File Offset: 0x0006451C
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114494, XrefRangeEnd = 114502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TwitterApiTab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060016FA RID: 5882 RVA: 0x0000B246 File Offset: 0x00009446
	public TwitterApiTab(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700067B RID: 1659
	// (get) Token: 0x060016FB RID: 5883 RVA: 0x00066358 File Offset: 0x00064558
	// (set) Token: 0x060016FC RID: 5884 RVA: 0x0000B24F File Offset: 0x0000944F
	public unsafe static bool IsUserInfoLoaded
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(TwitterApiTab.NativeFieldInfoPtr_IsUserInfoLoaded, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TwitterApiTab.NativeFieldInfoPtr_IsUserInfoLoaded, (void*)(&value));
		}
	}

	// Token: 0x1700067C RID: 1660
	// (get) Token: 0x060016FD RID: 5885 RVA: 0x00066374 File Offset: 0x00064574
	// (set) Token: 0x060016FE RID: 5886 RVA: 0x0000B25D File Offset: 0x0000945D
	public unsafe static bool IsAuthenticated
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(TwitterApiTab.NativeFieldInfoPtr_IsAuthenticated, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TwitterApiTab.NativeFieldInfoPtr_IsAuthenticated, (void*)(&value));
		}
	}

	// Token: 0x1700067D RID: 1661
	// (get) Token: 0x060016FF RID: 5887 RVA: 0x00066390 File Offset: 0x00064590
	// (set) Token: 0x06001700 RID: 5888 RVA: 0x0000B26B File Offset: 0x0000946B
	public unsafe Texture2D ImageToShare
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_ImageToShare);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_ImageToShare), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700067E RID: 1662
	// (get) Token: 0x06001701 RID: 5889 RVA: 0x000663C0 File Offset: 0x000645C0
	// (set) Token: 0x06001702 RID: 5890 RVA: 0x0000B28A File Offset: 0x0000948A
	public unsafe Text ConnectButtonText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_ConnectButtonText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_ConnectButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700067F RID: 1663
	// (get) Token: 0x06001703 RID: 5891 RVA: 0x000663F0 File Offset: 0x000645F0
	// (set) Token: 0x06001704 RID: 5892 RVA: 0x0000B2A9 File Offset: 0x000094A9
	public unsafe Button ConnectButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_ConnectButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_ConnectButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000680 RID: 1664
	// (get) Token: 0x06001705 RID: 5893 RVA: 0x00066420 File Offset: 0x00064620
	// (set) Token: 0x06001706 RID: 5894 RVA: 0x0000B2C8 File Offset: 0x000094C8
	public unsafe Image Avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_Avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000681 RID: 1665
	// (get) Token: 0x06001707 RID: 5895 RVA: 0x00066450 File Offset: 0x00064650
	// (set) Token: 0x06001708 RID: 5896 RVA: 0x0000B2E7 File Offset: 0x000094E7
	public unsafe Text Location
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_Location);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_Location), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000682 RID: 1666
	// (get) Token: 0x06001709 RID: 5897 RVA: 0x00066480 File Offset: 0x00064680
	// (set) Token: 0x0600170A RID: 5898 RVA: 0x0000B306 File Offset: 0x00009506
	public unsafe Text Language
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_Language);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_Language), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000683 RID: 1667
	// (get) Token: 0x0600170B RID: 5899 RVA: 0x000664B0 File Offset: 0x000646B0
	// (set) Token: 0x0600170C RID: 5900 RVA: 0x0000B325 File Offset: 0x00009525
	public unsafe Text Status
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_Status);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_Status), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000684 RID: 1668
	// (get) Token: 0x0600170D RID: 5901 RVA: 0x000664E0 File Offset: 0x000646E0
	// (set) Token: 0x0600170E RID: 5902 RVA: 0x0000B344 File Offset: 0x00009544
	public unsafe Text Name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_Name);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000685 RID: 1669
	// (get) Token: 0x0600170F RID: 5903 RVA: 0x00066510 File Offset: 0x00064710
	// (set) Token: 0x06001710 RID: 5904 RVA: 0x0000B363 File Offset: 0x00009563
	public unsafe Il2CppReferenceArray<Button> AuthDependedButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_AuthDependedButtons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_AuthDependedButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000686 RID: 1670
	// (get) Token: 0x06001711 RID: 5905 RVA: 0x00066540 File Offset: 0x00064740
	// (set) Token: 0x06001712 RID: 5906 RVA: 0x0000B382 File Offset: 0x00009582
	public unsafe Sprite AvatarSprite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_AvatarSprite);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab.NativeFieldInfoPtr_AvatarSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04001142 RID: 4418
	private static readonly IntPtr NativeFieldInfoPtr_IsUserInfoLoaded;

	// Token: 0x04001143 RID: 4419
	private static readonly IntPtr NativeFieldInfoPtr_IsAuthenticated;

	// Token: 0x04001144 RID: 4420
	private static readonly IntPtr NativeFieldInfoPtr_ImageToShare;

	// Token: 0x04001145 RID: 4421
	private static readonly IntPtr NativeFieldInfoPtr_ConnectButtonText;

	// Token: 0x04001146 RID: 4422
	private static readonly IntPtr NativeFieldInfoPtr_ConnectButton;

	// Token: 0x04001147 RID: 4423
	private static readonly IntPtr NativeFieldInfoPtr_Avatar;

	// Token: 0x04001148 RID: 4424
	private static readonly IntPtr NativeFieldInfoPtr_Location;

	// Token: 0x04001149 RID: 4425
	private static readonly IntPtr NativeFieldInfoPtr_Language;

	// Token: 0x0400114A RID: 4426
	private static readonly IntPtr NativeFieldInfoPtr_Status;

	// Token: 0x0400114B RID: 4427
	private static readonly IntPtr NativeFieldInfoPtr_Name;

	// Token: 0x0400114C RID: 4428
	private static readonly IntPtr NativeFieldInfoPtr_AuthDependedButtons;

	// Token: 0x0400114D RID: 4429
	private static readonly IntPtr NativeFieldInfoPtr_AvatarSprite;

	// Token: 0x0400114E RID: 4430
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x0400114F RID: 4431
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x04001150 RID: 4432
	private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Void_0;

	// Token: 0x04001151 RID: 4433
	private static readonly IntPtr NativeMethodInfoPtr_PostWithAuthCheck_Public_Void_0;

	// Token: 0x04001152 RID: 4434
	private static readonly IntPtr NativeMethodInfoPtr_PostNativeScreenshot_Public_Void_0;

	// Token: 0x04001153 RID: 4435
	private static readonly IntPtr NativeMethodInfoPtr_PostMSG_Public_Void_0;

	// Token: 0x04001154 RID: 4436
	private static readonly IntPtr NativeMethodInfoPtr_PostImage_Public_Void_0;

	// Token: 0x04001155 RID: 4437
	private static readonly IntPtr NativeMethodInfoPtr_PostTWScreenshot_Private_IEnumerator_0;

	// Token: 0x04001156 RID: 4438
	private static readonly IntPtr NativeMethodInfoPtr_LoadUserData_Public_Void_0;

	// Token: 0x04001157 RID: 4439
	private static readonly IntPtr NativeMethodInfoPtr_Test_Private_Void_0;

	// Token: 0x04001158 RID: 4440
	private static readonly IntPtr NativeMethodInfoPtr_OnResult_Private_Void_TW_APIRequstResult_0;

	// Token: 0x04001159 RID: 4441
	private static readonly IntPtr NativeMethodInfoPtr_PostMessage_Public_Void_0;

	// Token: 0x0400115A RID: 4442
	private static readonly IntPtr NativeMethodInfoPtr_PostScreehShot_Public_Void_0;

	// Token: 0x0400115B RID: 4443
	private static readonly IntPtr NativeMethodInfoPtr_OnUserDataRequestCompleteAction_Private_Void_TWResult_0;

	// Token: 0x0400115C RID: 4444
	private static readonly IntPtr NativeMethodInfoPtr_OnPostingCompleteAction_Private_Void_TWResult_0;

	// Token: 0x0400115D RID: 4445
	private static readonly IntPtr NativeMethodInfoPtr_OnAuthCompleteAction_Private_Void_TWResult_0;

	// Token: 0x0400115E RID: 4446
	private static readonly IntPtr NativeMethodInfoPtr_OnTwitterInitedAction_Private_Void_TWResult_0;

	// Token: 0x0400115F RID: 4447
	private static readonly IntPtr NativeMethodInfoPtr_OnAuth_Private_Void_0;

	// Token: 0x04001160 RID: 4448
	private static readonly IntPtr NativeMethodInfoPtr_RetrieveTimeLine_Public_Void_0;

	// Token: 0x04001161 RID: 4449
	private static readonly IntPtr NativeMethodInfoPtr_UserLookUpRequest_Public_Void_0;

	// Token: 0x04001162 RID: 4450
	private static readonly IntPtr NativeMethodInfoPtr_FriedsidsRequest_Public_Void_0;

	// Token: 0x04001163 RID: 4451
	private static readonly IntPtr NativeMethodInfoPtr_FollowersidsRequest_Public_Void_0;

	// Token: 0x04001164 RID: 4452
	private static readonly IntPtr NativeMethodInfoPtr_TweetSearch_Public_Void_0;

	// Token: 0x04001165 RID: 4453
	private static readonly IntPtr NativeMethodInfoPtr_OnIdsLoaded_Private_Void_TW_APIRequstResult_0;

	// Token: 0x04001166 RID: 4454
	private static readonly IntPtr NativeMethodInfoPtr_OnLookUpRequestComplete_Private_Void_TW_APIRequstResult_0;

	// Token: 0x04001167 RID: 4455
	private static readonly IntPtr NativeMethodInfoPtr_OnSearchRequestComplete_Private_Void_TW_APIRequstResult_0;

	// Token: 0x04001168 RID: 4456
	private static readonly IntPtr NativeMethodInfoPtr_OnTimeLineRequestComplete_Private_Void_TW_APIRequstResult_0;

	// Token: 0x04001169 RID: 4457
	private static readonly IntPtr NativeMethodInfoPtr_PostScreenshot_Private_IEnumerator_0;

	// Token: 0x0400116A RID: 4458
	private static readonly IntPtr NativeMethodInfoPtr_LogOut_Private_Void_0;

	// Token: 0x0400116B RID: 4459
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020003A3 RID: 931
	[ObfuscatedName("TwitterApiTab+<PostTWScreenshot>d__19")]
	public sealed class _PostTWScreenshot_d__19 : global::Il2CppSystem.Object
	{
		// Token: 0x060036FE RID: 14078 RVA: 0x000E113C File Offset: 0x000DF33C
		// Note: this type is marked as 'beforefieldinit'.
		static _PostTWScreenshot_d__19()
		{
			Il2CppClassPointerStore<TwitterApiTab._PostTWScreenshot_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, "<PostTWScreenshot>d__19");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwitterApiTab._PostTWScreenshot_d__19>.NativeClassPtr);
			TwitterApiTab._PostTWScreenshot_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApiTab._PostTWScreenshot_d__19>.NativeClassPtr, "<>1__state");
			TwitterApiTab._PostTWScreenshot_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApiTab._PostTWScreenshot_d__19>.NativeClassPtr, "<>2__current");
			TwitterApiTab._PostTWScreenshot_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab._PostTWScreenshot_d__19>.NativeClassPtr, 100670285);
			TwitterApiTab._PostTWScreenshot_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab._PostTWScreenshot_d__19>.NativeClassPtr, 100670286);
			TwitterApiTab._PostTWScreenshot_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab._PostTWScreenshot_d__19>.NativeClassPtr, 100670287);
			TwitterApiTab._PostTWScreenshot_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab._PostTWScreenshot_d__19>.NativeClassPtr, 100670288);
			TwitterApiTab._PostTWScreenshot_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab._PostTWScreenshot_d__19>.NativeClassPtr, 100670289);
			TwitterApiTab._PostTWScreenshot_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab._PostTWScreenshot_d__19>.NativeClassPtr, 100670290);
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x000E1208 File Offset: 0x000DF408
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _PostTWScreenshot_d__19(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwitterApiTab._PostTWScreenshot_d__19>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab._PostTWScreenshot_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x000E1250 File Offset: 0x000DF450
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab._PostTWScreenshot_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x000E1284 File Offset: 0x000DF484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193283, XrefRangeEnd = 193293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab._PostTWScreenshot_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06003702 RID: 14082 RVA: 0x000E12C0 File Offset: 0x000DF4C0
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab._PostTWScreenshot_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003703 RID: 14083 RVA: 0x000E1300 File Offset: 0x000DF500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193293, XrefRangeEnd = 193298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab._PostTWScreenshot_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06003704 RID: 14084 RVA: 0x000E1334 File Offset: 0x000DF534
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab._PostTWScreenshot_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x000154FB File Offset: 0x000136FB
		public _PostTWScreenshot_d__19(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06003706 RID: 14086 RVA: 0x000E1374 File Offset: 0x000DF574
		// (set) Token: 0x06003707 RID: 14087 RVA: 0x00015504 File Offset: 0x00013704
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab._PostTWScreenshot_d__19.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab._PostTWScreenshot_d__19.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06003708 RID: 14088 RVA: 0x000E139C File Offset: 0x000DF59C
		// (set) Token: 0x06003709 RID: 14089 RVA: 0x0001551F File Offset: 0x0001371F
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab._PostTWScreenshot_d__19.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab._PostTWScreenshot_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003220 RID: 12832
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04003221 RID: 12833
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04003222 RID: 12834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04003223 RID: 12835
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003224 RID: 12836
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04003225 RID: 12837
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04003226 RID: 12838
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003227 RID: 12839
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020003A4 RID: 932
	[ObfuscatedName("TwitterApiTab+<PostScreenshot>d__39")]
	public sealed class _PostScreenshot_d__39 : global::Il2CppSystem.Object
	{
		// Token: 0x0600370A RID: 14090 RVA: 0x000E13CC File Offset: 0x000DF5CC
		// Note: this type is marked as 'beforefieldinit'.
		static _PostScreenshot_d__39()
		{
			Il2CppClassPointerStore<TwitterApiTab._PostScreenshot_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TwitterApiTab>.NativeClassPtr, "<PostScreenshot>d__39");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwitterApiTab._PostScreenshot_d__39>.NativeClassPtr);
			TwitterApiTab._PostScreenshot_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApiTab._PostScreenshot_d__39>.NativeClassPtr, "<>1__state");
			TwitterApiTab._PostScreenshot_d__39.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterApiTab._PostScreenshot_d__39>.NativeClassPtr, "<>2__current");
			TwitterApiTab._PostScreenshot_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab._PostScreenshot_d__39>.NativeClassPtr, 100670291);
			TwitterApiTab._PostScreenshot_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab._PostScreenshot_d__39>.NativeClassPtr, 100670292);
			TwitterApiTab._PostScreenshot_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab._PostScreenshot_d__39>.NativeClassPtr, 100670293);
			TwitterApiTab._PostScreenshot_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab._PostScreenshot_d__39>.NativeClassPtr, 100670294);
			TwitterApiTab._PostScreenshot_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab._PostScreenshot_d__39>.NativeClassPtr, 100670295);
			TwitterApiTab._PostScreenshot_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterApiTab._PostScreenshot_d__39>.NativeClassPtr, 100670296);
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x000E1498 File Offset: 0x000DF698
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _PostScreenshot_d__39(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwitterApiTab._PostScreenshot_d__39>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab._PostScreenshot_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x000E14E0 File Offset: 0x000DF6E0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab._PostScreenshot_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x000E1514 File Offset: 0x000DF714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193298, XrefRangeEnd = 193307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab._PostScreenshot_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x0600370E RID: 14094 RVA: 0x000E1550 File Offset: 0x000DF750
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab._PostScreenshot_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x000E1590 File Offset: 0x000DF790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193307, XrefRangeEnd = 193312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab._PostScreenshot_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06003710 RID: 14096 RVA: 0x000E15C4 File Offset: 0x000DF7C4
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterApiTab._PostScreenshot_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x0001553E File Offset: 0x0001373E
		public _PostScreenshot_d__39(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06003712 RID: 14098 RVA: 0x000E1604 File Offset: 0x000DF804
		// (set) Token: 0x06003713 RID: 14099 RVA: 0x00015547 File Offset: 0x00013747
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab._PostScreenshot_d__39.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab._PostScreenshot_d__39.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06003714 RID: 14100 RVA: 0x000E162C File Offset: 0x000DF82C
		// (set) Token: 0x06003715 RID: 14101 RVA: 0x00015562 File Offset: 0x00013762
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab._PostScreenshot_d__39.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterApiTab._PostScreenshot_d__39.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003228 RID: 12840
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04003229 RID: 12841
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400322A RID: 12842
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400322B RID: 12843
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400322C RID: 12844
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400322D RID: 12845
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400322E RID: 12846
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400322F RID: 12847
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

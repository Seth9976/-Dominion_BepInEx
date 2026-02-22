using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000133 RID: 307
public class FacebookApiTab : FeatureTab
{
	// Token: 0x06001663 RID: 5731 RVA: 0x00063F14 File Offset: 0x00062114
	// Note: this type is marked as 'beforefieldinit'.
	static FacebookApiTab()
	{
		Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FacebookApiTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr);
		FacebookApiTab.NativeFieldInfoPtr_IsUserInfoLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "IsUserInfoLoaded");
		FacebookApiTab.NativeFieldInfoPtr_IsFrindsInfoLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "IsFrindsInfoLoaded");
		FacebookApiTab.NativeFieldInfoPtr_IsAuntificated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "IsAuntificated");
		FacebookApiTab.NativeFieldInfoPtr_ConnectionDependedntButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "ConnectionDependedntButtons");
		FacebookApiTab.NativeFieldInfoPtr_ConnectButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "ConnectButtonText");
		FacebookApiTab.NativeFieldInfoPtr_ConnectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "ConnectButton");
		FacebookApiTab.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "Avatar");
		FacebookApiTab.NativeFieldInfoPtr_AvatarSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "AvatarSprite");
		FacebookApiTab.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "Location");
		FacebookApiTab.NativeFieldInfoPtr_Language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "Language");
		FacebookApiTab.NativeFieldInfoPtr_Mail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "Mail");
		FacebookApiTab.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "Name");
		FacebookApiTab.NativeFieldInfoPtr_f1Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "f1Name");
		FacebookApiTab.NativeFieldInfoPtr_f2Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "f2Name");
		FacebookApiTab.NativeFieldInfoPtr_f1ProfileLogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "f1ProfileLogo");
		FacebookApiTab.NativeFieldInfoPtr_f2ProfileLogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "f2ProfileLogo");
		FacebookApiTab.NativeFieldInfoPtr_f1Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "f1Avatar");
		FacebookApiTab.NativeFieldInfoPtr_f2Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "f2Avatar");
		FacebookApiTab.NativeFieldInfoPtr_ImageToShare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "ImageToShare");
		FacebookApiTab.NativeFieldInfoPtr_friends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "friends");
		FacebookApiTab.NativeFieldInfoPtr_startScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "startScore");
		FacebookApiTab.NativeFieldInfoPtr_UNION_ASSETS_PAGE_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "UNION_ASSETS_PAGE_ID");
		FacebookApiTab.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100665989);
		FacebookApiTab.NativeMethodInfoPtr_HandleOnRevokePermission_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100665990);
		FacebookApiTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100665991);
		FacebookApiTab.NativeMethodInfoPtr_PostWithAuthCheck_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100665992);
		FacebookApiTab.NativeMethodInfoPtr_PostNativeScreenshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100665993);
		FacebookApiTab.NativeMethodInfoPtr_PostImage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100665994);
		FacebookApiTab.NativeMethodInfoPtr_PostFBScreenshot_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100665995);
		FacebookApiTab.NativeMethodInfoPtr_Connect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100665996);
		FacebookApiTab.NativeMethodInfoPtr_LoadUserData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100665997);
		FacebookApiTab.NativeMethodInfoPtr_PostMessage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100665998);
		FacebookApiTab.NativeMethodInfoPtr_PostScreehShot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100665999);
		FacebookApiTab.NativeMethodInfoPtr_LoadFriends_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666000);
		FacebookApiTab.NativeMethodInfoPtr_AppRequest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666001);
		FacebookApiTab.NativeMethodInfoPtr_LoadScore_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666002);
		FacebookApiTab.NativeMethodInfoPtr_LoadAppScores_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666003);
		FacebookApiTab.NativeMethodInfoPtr_SubmitScore_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666004);
		FacebookApiTab.NativeMethodInfoPtr_DeletePlayerScores_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666005);
		FacebookApiTab.NativeMethodInfoPtr_LikePage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666006);
		FacebookApiTab.NativeMethodInfoPtr_CheckLike_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666007);
		FacebookApiTab.NativeMethodInfoPtr_ActivateApp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666008);
		FacebookApiTab.NativeMethodInfoPtr_AchievedLevel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666009);
		FacebookApiTab.NativeMethodInfoPtr_AddedPaymentInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666010);
		FacebookApiTab.NativeMethodInfoPtr_AddedToCart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666011);
		FacebookApiTab.NativeMethodInfoPtr_AddedToWishlist_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666012);
		FacebookApiTab.NativeMethodInfoPtr_CompletedRegistration_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666013);
		FacebookApiTab.NativeMethodInfoPtr_InitiatedCheckout_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666014);
		FacebookApiTab.NativeMethodInfoPtr_Purchased_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666015);
		FacebookApiTab.NativeMethodInfoPtr_Rated_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666016);
		FacebookApiTab.NativeMethodInfoPtr_Searched_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666017);
		FacebookApiTab.NativeMethodInfoPtr_SpentCredits_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666018);
		FacebookApiTab.NativeMethodInfoPtr_UnlockedAchievement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666019);
		FacebookApiTab.NativeMethodInfoPtr_ViewedContent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666020);
		FacebookApiTab.NativeMethodInfoPtr_OnLikesLoaded_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666021);
		FacebookApiTab.NativeMethodInfoPtr_OnFocusChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666022);
		FacebookApiTab.NativeMethodInfoPtr_OnUserDataLoaded_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666023);
		FacebookApiTab.NativeMethodInfoPtr_OnFriendsDataLoaded_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666024);
		FacebookApiTab.NativeMethodInfoPtr_OnInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666025);
		FacebookApiTab.NativeMethodInfoPtr_OnAuth_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666026);
		FacebookApiTab.NativeMethodInfoPtr_OnPost_Private_Void_FB_PostResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666027);
		FacebookApiTab.NativeMethodInfoPtr_OnPlayerScoreRequestComplete_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666028);
		FacebookApiTab.NativeMethodInfoPtr_OnAppScoreRequestComplete_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666029);
		FacebookApiTab.NativeMethodInfoPtr_OnSubmitScoreRequestComplete_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666030);
		FacebookApiTab.NativeMethodInfoPtr_OnDeleteScoreRequestComplete_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666031);
		FacebookApiTab.NativeMethodInfoPtr_PostScreenshot_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666032);
		FacebookApiTab.NativeMethodInfoPtr_LogOut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666033);
		FacebookApiTab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, 100666034);
	}

	// Token: 0x06001664 RID: 5732 RVA: 0x00064494 File Offset: 0x00062694
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192424, XrefRangeEnd = 192502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001665 RID: 5733 RVA: 0x000644C8 File Offset: 0x000626C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192502, XrefRangeEnd = 192512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleOnRevokePermission(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_HandleOnRevokePermission_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001666 RID: 5734 RVA: 0x0006450C File Offset: 0x0006270C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192512, XrefRangeEnd = 192533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001667 RID: 5735 RVA: 0x00064540 File Offset: 0x00062740
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192533, XrefRangeEnd = 192552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostWithAuthCheck()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_PostWithAuthCheck_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001668 RID: 5736 RVA: 0x00064574 File Offset: 0x00062774
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192552, XrefRangeEnd = 192557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostNativeScreenshot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_PostNativeScreenshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001669 RID: 5737 RVA: 0x000645A8 File Offset: 0x000627A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192557, XrefRangeEnd = 192567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostImage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_PostImage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600166A RID: 5738 RVA: 0x000645DC File Offset: 0x000627DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192567, XrefRangeEnd = 192571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator PostFBScreenshot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_PostFBScreenshot_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600166B RID: 5739 RVA: 0x0006461C File Offset: 0x0006281C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192571, XrefRangeEnd = 192601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Connect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_Connect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600166C RID: 5740 RVA: 0x00064650 File Offset: 0x00062850
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192601, XrefRangeEnd = 192624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadUserData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_LoadUserData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600166D RID: 5741 RVA: 0x00064684 File Offset: 0x00062884
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192624, XrefRangeEnd = 192647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_PostMessage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600166E RID: 5742 RVA: 0x000646B8 File Offset: 0x000628B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192647, XrefRangeEnd = 192655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostScreehShot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_PostScreehShot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600166F RID: 5743 RVA: 0x000646EC File Offset: 0x000628EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192655, XrefRangeEnd = 192678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadFriends()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_LoadFriends_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001670 RID: 5744 RVA: 0x00064720 File Offset: 0x00062920
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192678, XrefRangeEnd = 192689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AppRequest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_AppRequest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001671 RID: 5745 RVA: 0x00064754 File Offset: 0x00062954
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192689, XrefRangeEnd = 192697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadScore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_LoadScore_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001672 RID: 5746 RVA: 0x00064788 File Offset: 0x00062988
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192697, XrefRangeEnd = 192705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAppScores()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_LoadAppScores_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001673 RID: 5747 RVA: 0x000647BC File Offset: 0x000629BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192705, XrefRangeEnd = 192713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitScore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_SubmitScore_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001674 RID: 5748 RVA: 0x000647F0 File Offset: 0x000629F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192713, XrefRangeEnd = 192721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeletePlayerScores()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_DeletePlayerScores_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001675 RID: 5749 RVA: 0x00064824 File Offset: 0x00062A24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192721, XrefRangeEnd = 192724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LikePage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_LikePage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001676 RID: 5750 RVA: 0x00064858 File Offset: 0x00062A58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192724, XrefRangeEnd = 192764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckLike()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_CheckLike_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001677 RID: 5751 RVA: 0x0006488C File Offset: 0x00062A8C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivateApp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_ActivateApp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001678 RID: 5752 RVA: 0x000648C0 File Offset: 0x00062AC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AchievedLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_AchievedLevel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001679 RID: 5753 RVA: 0x000648F4 File Offset: 0x00062AF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddedPaymentInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_AddedPaymentInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600167A RID: 5754 RVA: 0x00064928 File Offset: 0x00062B28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192764, XrefRangeEnd = 192771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddedToCart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_AddedToCart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600167B RID: 5755 RVA: 0x0006495C File Offset: 0x00062B5C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192771, XrefRangeEnd = 192778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddedToWishlist()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_AddedToWishlist_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600167C RID: 5756 RVA: 0x00064990 File Offset: 0x00062B90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192778, XrefRangeEnd = 192781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CompletedRegistration()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_CompletedRegistration_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600167D RID: 5757 RVA: 0x000649C4 File Offset: 0x00062BC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192781, XrefRangeEnd = 192788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitiatedCheckout()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_InitiatedCheckout_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600167E RID: 5758 RVA: 0x000649F8 File Offset: 0x00062BF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192788, XrefRangeEnd = 192795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Purchased()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_Purchased_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600167F RID: 5759 RVA: 0x00064A2C File Offset: 0x00062C2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192795, XrefRangeEnd = 192800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Rated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_Rated_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001680 RID: 5760 RVA: 0x00064A60 File Offset: 0x00062C60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192800, XrefRangeEnd = 192805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Searched()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_Searched_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001681 RID: 5761 RVA: 0x00064A94 File Offset: 0x00062C94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192805, XrefRangeEnd = 192810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpentCredits()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_SpentCredits_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001682 RID: 5762 RVA: 0x00064AC8 File Offset: 0x00062CC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192810, XrefRangeEnd = 192813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlockedAchievement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_UnlockedAchievement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001683 RID: 5763 RVA: 0x00064AFC File Offset: 0x00062CFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192813, XrefRangeEnd = 192820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ViewedContent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_ViewedContent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001684 RID: 5764 RVA: 0x00064B30 File Offset: 0x00062D30
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192820, XrefRangeEnd = 192844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLikesLoaded(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_OnLikesLoaded_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001685 RID: 5765 RVA: 0x00064B74 File Offset: 0x00062D74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192844, XrefRangeEnd = 192853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnFocusChanged(bool focus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref focus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_OnFocusChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001686 RID: 5766 RVA: 0x00064BB4 File Offset: 0x00062DB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192853, XrefRangeEnd = 192888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUserDataLoaded(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_OnUserDataLoaded_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001687 RID: 5767 RVA: 0x00064BF8 File Offset: 0x00062DF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192888, XrefRangeEnd = 192913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnFriendsDataLoaded(FB_Result res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_OnFriendsDataLoaded_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001688 RID: 5768 RVA: 0x00064C3C File Offset: 0x00062E3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192913, XrefRangeEnd = 192927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_OnInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001689 RID: 5769 RVA: 0x00064C70 File Offset: 0x00062E70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192927, XrefRangeEnd = 192948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAuth(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_OnAuth_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600168A RID: 5770 RVA: 0x00064CB4 File Offset: 0x00062EB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192948, XrefRangeEnd = 192970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPost(FB_PostResult res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_OnPost_Private_Void_FB_PostResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600168B RID: 5771 RVA: 0x00064CF8 File Offset: 0x00062EF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192970, XrefRangeEnd = 192977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerScoreRequestComplete(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_OnPlayerScoreRequestComplete_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600168C RID: 5772 RVA: 0x00064D3C File Offset: 0x00062F3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192977, XrefRangeEnd = 192984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAppScoreRequestComplete(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_OnAppScoreRequestComplete_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600168D RID: 5773 RVA: 0x00064D80 File Offset: 0x00062F80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192984, XrefRangeEnd = 192989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSubmitScoreRequestComplete(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_OnSubmitScoreRequestComplete_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600168E RID: 5774 RVA: 0x00064DC4 File Offset: 0x00062FC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192989, XrefRangeEnd = 192994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDeleteScoreRequestComplete(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_OnDeleteScoreRequestComplete_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600168F RID: 5775 RVA: 0x00064E08 File Offset: 0x00063008
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192994, XrefRangeEnd = 192998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator PostScreenshot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_PostScreenshot_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06001690 RID: 5776 RVA: 0x00064E48 File Offset: 0x00063048
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192998, XrefRangeEnd = 193011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LogOut()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr_LogOut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001691 RID: 5777 RVA: 0x00064E7C File Offset: 0x0006307C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193011, XrefRangeEnd = 193014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FacebookApiTab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001692 RID: 5778 RVA: 0x0000AF5B File Offset: 0x0000915B
	public FacebookApiTab(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000662 RID: 1634
	// (get) Token: 0x06001693 RID: 5779 RVA: 0x00064EB8 File Offset: 0x000630B8
	// (set) Token: 0x06001694 RID: 5780 RVA: 0x0000AF64 File Offset: 0x00009164
	public unsafe static bool IsUserInfoLoaded
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(FacebookApiTab.NativeFieldInfoPtr_IsUserInfoLoaded, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookApiTab.NativeFieldInfoPtr_IsUserInfoLoaded, (void*)(&value));
		}
	}

	// Token: 0x17000663 RID: 1635
	// (get) Token: 0x06001695 RID: 5781 RVA: 0x00064ED4 File Offset: 0x000630D4
	// (set) Token: 0x06001696 RID: 5782 RVA: 0x0000AF72 File Offset: 0x00009172
	public unsafe static bool IsFrindsInfoLoaded
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(FacebookApiTab.NativeFieldInfoPtr_IsFrindsInfoLoaded, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookApiTab.NativeFieldInfoPtr_IsFrindsInfoLoaded, (void*)(&value));
		}
	}

	// Token: 0x17000664 RID: 1636
	// (get) Token: 0x06001697 RID: 5783 RVA: 0x00064EF0 File Offset: 0x000630F0
	// (set) Token: 0x06001698 RID: 5784 RVA: 0x0000AF80 File Offset: 0x00009180
	public unsafe static bool IsAuntificated
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(FacebookApiTab.NativeFieldInfoPtr_IsAuntificated, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookApiTab.NativeFieldInfoPtr_IsAuntificated, (void*)(&value));
		}
	}

	// Token: 0x17000665 RID: 1637
	// (get) Token: 0x06001699 RID: 5785 RVA: 0x00064F0C File Offset: 0x0006310C
	// (set) Token: 0x0600169A RID: 5786 RVA: 0x0000AF8E File Offset: 0x0000918E
	public unsafe Il2CppReferenceArray<Button> ConnectionDependedntButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_ConnectionDependedntButtons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_ConnectionDependedntButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000666 RID: 1638
	// (get) Token: 0x0600169B RID: 5787 RVA: 0x00064F3C File Offset: 0x0006313C
	// (set) Token: 0x0600169C RID: 5788 RVA: 0x0000AFAD File Offset: 0x000091AD
	public unsafe Text ConnectButtonText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_ConnectButtonText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_ConnectButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000667 RID: 1639
	// (get) Token: 0x0600169D RID: 5789 RVA: 0x00064F6C File Offset: 0x0006316C
	// (set) Token: 0x0600169E RID: 5790 RVA: 0x0000AFCC File Offset: 0x000091CC
	public unsafe Button ConnectButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_ConnectButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_ConnectButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000668 RID: 1640
	// (get) Token: 0x0600169F RID: 5791 RVA: 0x00064F9C File Offset: 0x0006319C
	// (set) Token: 0x060016A0 RID: 5792 RVA: 0x0000AFEB File Offset: 0x000091EB
	public unsafe Image Avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_Avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000669 RID: 1641
	// (get) Token: 0x060016A1 RID: 5793 RVA: 0x00064FCC File Offset: 0x000631CC
	// (set) Token: 0x060016A2 RID: 5794 RVA: 0x0000B00A File Offset: 0x0000920A
	public unsafe Sprite AvatarSprite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_AvatarSprite);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_AvatarSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700066A RID: 1642
	// (get) Token: 0x060016A3 RID: 5795 RVA: 0x00064FFC File Offset: 0x000631FC
	// (set) Token: 0x060016A4 RID: 5796 RVA: 0x0000B029 File Offset: 0x00009229
	public unsafe Text Location
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_Location);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_Location), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700066B RID: 1643
	// (get) Token: 0x060016A5 RID: 5797 RVA: 0x0006502C File Offset: 0x0006322C
	// (set) Token: 0x060016A6 RID: 5798 RVA: 0x0000B048 File Offset: 0x00009248
	public unsafe Text Language
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_Language);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_Language), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700066C RID: 1644
	// (get) Token: 0x060016A7 RID: 5799 RVA: 0x0006505C File Offset: 0x0006325C
	// (set) Token: 0x060016A8 RID: 5800 RVA: 0x0000B067 File Offset: 0x00009267
	public unsafe Text Mail
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_Mail);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_Mail), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700066D RID: 1645
	// (get) Token: 0x060016A9 RID: 5801 RVA: 0x0006508C File Offset: 0x0006328C
	// (set) Token: 0x060016AA RID: 5802 RVA: 0x0000B086 File Offset: 0x00009286
	public unsafe Text Name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_Name);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_Name), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700066E RID: 1646
	// (get) Token: 0x060016AB RID: 5803 RVA: 0x000650BC File Offset: 0x000632BC
	// (set) Token: 0x060016AC RID: 5804 RVA: 0x0000B0A5 File Offset: 0x000092A5
	public unsafe Text f1Name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_f1Name);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_f1Name), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700066F RID: 1647
	// (get) Token: 0x060016AD RID: 5805 RVA: 0x000650EC File Offset: 0x000632EC
	// (set) Token: 0x060016AE RID: 5806 RVA: 0x0000B0C4 File Offset: 0x000092C4
	public unsafe Text f2Name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_f2Name);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_f2Name), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000670 RID: 1648
	// (get) Token: 0x060016AF RID: 5807 RVA: 0x0006511C File Offset: 0x0006331C
	// (set) Token: 0x060016B0 RID: 5808 RVA: 0x0000B0E3 File Offset: 0x000092E3
	public unsafe Image f1ProfileLogo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_f1ProfileLogo);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_f1ProfileLogo), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000671 RID: 1649
	// (get) Token: 0x060016B1 RID: 5809 RVA: 0x0006514C File Offset: 0x0006334C
	// (set) Token: 0x060016B2 RID: 5810 RVA: 0x0000B102 File Offset: 0x00009302
	public unsafe Image f2ProfileLogo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_f2ProfileLogo);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_f2ProfileLogo), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000672 RID: 1650
	// (get) Token: 0x060016B3 RID: 5811 RVA: 0x0006517C File Offset: 0x0006337C
	// (set) Token: 0x060016B4 RID: 5812 RVA: 0x0000B121 File Offset: 0x00009321
	public unsafe Sprite f1Avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_f1Avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_f1Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000673 RID: 1651
	// (get) Token: 0x060016B5 RID: 5813 RVA: 0x000651AC File Offset: 0x000633AC
	// (set) Token: 0x060016B6 RID: 5814 RVA: 0x0000B140 File Offset: 0x00009340
	public unsafe Sprite f2Avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_f2Avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_f2Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000674 RID: 1652
	// (get) Token: 0x060016B7 RID: 5815 RVA: 0x000651DC File Offset: 0x000633DC
	// (set) Token: 0x060016B8 RID: 5816 RVA: 0x0000B15F File Offset: 0x0000935F
	public unsafe Texture2D ImageToShare
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_ImageToShare);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_ImageToShare), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000675 RID: 1653
	// (get) Token: 0x060016B9 RID: 5817 RVA: 0x0006520C File Offset: 0x0006340C
	// (set) Token: 0x060016BA RID: 5818 RVA: 0x0000B17E File Offset: 0x0000937E
	public unsafe GameObject friends
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_friends);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_friends), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000676 RID: 1654
	// (get) Token: 0x060016BB RID: 5819 RVA: 0x0006523C File Offset: 0x0006343C
	// (set) Token: 0x060016BC RID: 5820 RVA: 0x0000B19D File Offset: 0x0000939D
	public unsafe int startScore
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_startScore);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_startScore)) = value;
		}
	}

	// Token: 0x17000677 RID: 1655
	// (get) Token: 0x060016BD RID: 5821 RVA: 0x00065264 File Offset: 0x00063464
	// (set) Token: 0x060016BE RID: 5822 RVA: 0x0000B1B8 File Offset: 0x000093B8
	public unsafe string UNION_ASSETS_PAGE_ID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_UNION_ASSETS_PAGE_ID);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab.NativeFieldInfoPtr_UNION_ASSETS_PAGE_ID), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040010E9 RID: 4329
	private static readonly IntPtr NativeFieldInfoPtr_IsUserInfoLoaded;

	// Token: 0x040010EA RID: 4330
	private static readonly IntPtr NativeFieldInfoPtr_IsFrindsInfoLoaded;

	// Token: 0x040010EB RID: 4331
	private static readonly IntPtr NativeFieldInfoPtr_IsAuntificated;

	// Token: 0x040010EC RID: 4332
	private static readonly IntPtr NativeFieldInfoPtr_ConnectionDependedntButtons;

	// Token: 0x040010ED RID: 4333
	private static readonly IntPtr NativeFieldInfoPtr_ConnectButtonText;

	// Token: 0x040010EE RID: 4334
	private static readonly IntPtr NativeFieldInfoPtr_ConnectButton;

	// Token: 0x040010EF RID: 4335
	private static readonly IntPtr NativeFieldInfoPtr_Avatar;

	// Token: 0x040010F0 RID: 4336
	private static readonly IntPtr NativeFieldInfoPtr_AvatarSprite;

	// Token: 0x040010F1 RID: 4337
	private static readonly IntPtr NativeFieldInfoPtr_Location;

	// Token: 0x040010F2 RID: 4338
	private static readonly IntPtr NativeFieldInfoPtr_Language;

	// Token: 0x040010F3 RID: 4339
	private static readonly IntPtr NativeFieldInfoPtr_Mail;

	// Token: 0x040010F4 RID: 4340
	private static readonly IntPtr NativeFieldInfoPtr_Name;

	// Token: 0x040010F5 RID: 4341
	private static readonly IntPtr NativeFieldInfoPtr_f1Name;

	// Token: 0x040010F6 RID: 4342
	private static readonly IntPtr NativeFieldInfoPtr_f2Name;

	// Token: 0x040010F7 RID: 4343
	private static readonly IntPtr NativeFieldInfoPtr_f1ProfileLogo;

	// Token: 0x040010F8 RID: 4344
	private static readonly IntPtr NativeFieldInfoPtr_f2ProfileLogo;

	// Token: 0x040010F9 RID: 4345
	private static readonly IntPtr NativeFieldInfoPtr_f1Avatar;

	// Token: 0x040010FA RID: 4346
	private static readonly IntPtr NativeFieldInfoPtr_f2Avatar;

	// Token: 0x040010FB RID: 4347
	private static readonly IntPtr NativeFieldInfoPtr_ImageToShare;

	// Token: 0x040010FC RID: 4348
	private static readonly IntPtr NativeFieldInfoPtr_friends;

	// Token: 0x040010FD RID: 4349
	private static readonly IntPtr NativeFieldInfoPtr_startScore;

	// Token: 0x040010FE RID: 4350
	private static readonly IntPtr NativeFieldInfoPtr_UNION_ASSETS_PAGE_ID;

	// Token: 0x040010FF RID: 4351
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04001100 RID: 4352
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnRevokePermission_Private_Void_FB_Result_0;

	// Token: 0x04001101 RID: 4353
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x04001102 RID: 4354
	private static readonly IntPtr NativeMethodInfoPtr_PostWithAuthCheck_Public_Void_0;

	// Token: 0x04001103 RID: 4355
	private static readonly IntPtr NativeMethodInfoPtr_PostNativeScreenshot_Public_Void_0;

	// Token: 0x04001104 RID: 4356
	private static readonly IntPtr NativeMethodInfoPtr_PostImage_Public_Void_0;

	// Token: 0x04001105 RID: 4357
	private static readonly IntPtr NativeMethodInfoPtr_PostFBScreenshot_Private_IEnumerator_0;

	// Token: 0x04001106 RID: 4358
	private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Void_0;

	// Token: 0x04001107 RID: 4359
	private static readonly IntPtr NativeMethodInfoPtr_LoadUserData_Public_Void_0;

	// Token: 0x04001108 RID: 4360
	private static readonly IntPtr NativeMethodInfoPtr_PostMessage_Public_Void_0;

	// Token: 0x04001109 RID: 4361
	private static readonly IntPtr NativeMethodInfoPtr_PostScreehShot_Public_Void_0;

	// Token: 0x0400110A RID: 4362
	private static readonly IntPtr NativeMethodInfoPtr_LoadFriends_Public_Void_0;

	// Token: 0x0400110B RID: 4363
	private static readonly IntPtr NativeMethodInfoPtr_AppRequest_Public_Void_0;

	// Token: 0x0400110C RID: 4364
	private static readonly IntPtr NativeMethodInfoPtr_LoadScore_Public_Void_0;

	// Token: 0x0400110D RID: 4365
	private static readonly IntPtr NativeMethodInfoPtr_LoadAppScores_Public_Void_0;

	// Token: 0x0400110E RID: 4366
	private static readonly IntPtr NativeMethodInfoPtr_SubmitScore_Public_Void_0;

	// Token: 0x0400110F RID: 4367
	private static readonly IntPtr NativeMethodInfoPtr_DeletePlayerScores_Public_Void_0;

	// Token: 0x04001110 RID: 4368
	private static readonly IntPtr NativeMethodInfoPtr_LikePage_Public_Void_0;

	// Token: 0x04001111 RID: 4369
	private static readonly IntPtr NativeMethodInfoPtr_CheckLike_Public_Void_0;

	// Token: 0x04001112 RID: 4370
	private static readonly IntPtr NativeMethodInfoPtr_ActivateApp_Public_Void_0;

	// Token: 0x04001113 RID: 4371
	private static readonly IntPtr NativeMethodInfoPtr_AchievedLevel_Public_Void_0;

	// Token: 0x04001114 RID: 4372
	private static readonly IntPtr NativeMethodInfoPtr_AddedPaymentInfo_Public_Void_0;

	// Token: 0x04001115 RID: 4373
	private static readonly IntPtr NativeMethodInfoPtr_AddedToCart_Public_Void_0;

	// Token: 0x04001116 RID: 4374
	private static readonly IntPtr NativeMethodInfoPtr_AddedToWishlist_Public_Void_0;

	// Token: 0x04001117 RID: 4375
	private static readonly IntPtr NativeMethodInfoPtr_CompletedRegistration_Public_Void_0;

	// Token: 0x04001118 RID: 4376
	private static readonly IntPtr NativeMethodInfoPtr_InitiatedCheckout_Public_Void_0;

	// Token: 0x04001119 RID: 4377
	private static readonly IntPtr NativeMethodInfoPtr_Purchased_Public_Void_0;

	// Token: 0x0400111A RID: 4378
	private static readonly IntPtr NativeMethodInfoPtr_Rated_Public_Void_0;

	// Token: 0x0400111B RID: 4379
	private static readonly IntPtr NativeMethodInfoPtr_Searched_Public_Void_0;

	// Token: 0x0400111C RID: 4380
	private static readonly IntPtr NativeMethodInfoPtr_SpentCredits_Public_Void_0;

	// Token: 0x0400111D RID: 4381
	private static readonly IntPtr NativeMethodInfoPtr_UnlockedAchievement_Public_Void_0;

	// Token: 0x0400111E RID: 4382
	private static readonly IntPtr NativeMethodInfoPtr_ViewedContent_Public_Void_0;

	// Token: 0x0400111F RID: 4383
	private static readonly IntPtr NativeMethodInfoPtr_OnLikesLoaded_Private_Void_FB_Result_0;

	// Token: 0x04001120 RID: 4384
	private static readonly IntPtr NativeMethodInfoPtr_OnFocusChanged_Private_Void_Boolean_0;

	// Token: 0x04001121 RID: 4385
	private static readonly IntPtr NativeMethodInfoPtr_OnUserDataLoaded_Private_Void_FB_Result_0;

	// Token: 0x04001122 RID: 4386
	private static readonly IntPtr NativeMethodInfoPtr_OnFriendsDataLoaded_Private_Void_FB_Result_0;

	// Token: 0x04001123 RID: 4387
	private static readonly IntPtr NativeMethodInfoPtr_OnInit_Private_Void_0;

	// Token: 0x04001124 RID: 4388
	private static readonly IntPtr NativeMethodInfoPtr_OnAuth_Private_Void_FB_Result_0;

	// Token: 0x04001125 RID: 4389
	private static readonly IntPtr NativeMethodInfoPtr_OnPost_Private_Void_FB_PostResult_0;

	// Token: 0x04001126 RID: 4390
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerScoreRequestComplete_Private_Void_FB_Result_0;

	// Token: 0x04001127 RID: 4391
	private static readonly IntPtr NativeMethodInfoPtr_OnAppScoreRequestComplete_Private_Void_FB_Result_0;

	// Token: 0x04001128 RID: 4392
	private static readonly IntPtr NativeMethodInfoPtr_OnSubmitScoreRequestComplete_Private_Void_FB_Result_0;

	// Token: 0x04001129 RID: 4393
	private static readonly IntPtr NativeMethodInfoPtr_OnDeleteScoreRequestComplete_Private_Void_FB_Result_0;

	// Token: 0x0400112A RID: 4394
	private static readonly IntPtr NativeMethodInfoPtr_PostScreenshot_Private_IEnumerator_0;

	// Token: 0x0400112B RID: 4395
	private static readonly IntPtr NativeMethodInfoPtr_LogOut_Private_Void_0;

	// Token: 0x0400112C RID: 4396
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200039D RID: 925
	[ObfuscatedName("FacebookApiTab+<PostFBScreenshot>d__27")]
	public sealed class _PostFBScreenshot_d__27 : global::Il2CppSystem.Object
	{
		// Token: 0x060036BA RID: 14010 RVA: 0x000E0320 File Offset: 0x000DE520
		// Note: this type is marked as 'beforefieldinit'.
		static _PostFBScreenshot_d__27()
		{
			Il2CppClassPointerStore<FacebookApiTab._PostFBScreenshot_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "<PostFBScreenshot>d__27");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FacebookApiTab._PostFBScreenshot_d__27>.NativeClassPtr);
			FacebookApiTab._PostFBScreenshot_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab._PostFBScreenshot_d__27>.NativeClassPtr, "<>1__state");
			FacebookApiTab._PostFBScreenshot_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab._PostFBScreenshot_d__27>.NativeClassPtr, "<>2__current");
			FacebookApiTab._PostFBScreenshot_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab._PostFBScreenshot_d__27>.NativeClassPtr, 100670252);
			FacebookApiTab._PostFBScreenshot_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab._PostFBScreenshot_d__27>.NativeClassPtr, 100670253);
			FacebookApiTab._PostFBScreenshot_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab._PostFBScreenshot_d__27>.NativeClassPtr, 100670254);
			FacebookApiTab._PostFBScreenshot_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab._PostFBScreenshot_d__27>.NativeClassPtr, 100670255);
			FacebookApiTab._PostFBScreenshot_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab._PostFBScreenshot_d__27>.NativeClassPtr, 100670256);
			FacebookApiTab._PostFBScreenshot_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab._PostFBScreenshot_d__27>.NativeClassPtr, 100670257);
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x000E03EC File Offset: 0x000DE5EC
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _PostFBScreenshot_d__27(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacebookApiTab._PostFBScreenshot_d__27>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab._PostFBScreenshot_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x000E0434 File Offset: 0x000DE634
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab._PostFBScreenshot_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x000E0468 File Offset: 0x000DE668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192395, XrefRangeEnd = 192405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab._PostFBScreenshot_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x060036BE RID: 14014 RVA: 0x000E04A4 File Offset: 0x000DE6A4
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab._PostFBScreenshot_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x000E04E4 File Offset: 0x000DE6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192405, XrefRangeEnd = 192410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab._PostFBScreenshot_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x060036C0 RID: 14016 RVA: 0x000E0518 File Offset: 0x000DE718
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab._PostFBScreenshot_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x0001537F File Offset: 0x0001357F
		public _PostFBScreenshot_d__27(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x060036C2 RID: 14018 RVA: 0x000E0558 File Offset: 0x000DE758
		// (set) Token: 0x060036C3 RID: 14019 RVA: 0x00015388 File Offset: 0x00013588
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab._PostFBScreenshot_d__27.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab._PostFBScreenshot_d__27.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x060036C4 RID: 14020 RVA: 0x000E0580 File Offset: 0x000DE780
		// (set) Token: 0x060036C5 RID: 14021 RVA: 0x000153A3 File Offset: 0x000135A3
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab._PostFBScreenshot_d__27.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab._PostFBScreenshot_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031F4 RID: 12788
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040031F5 RID: 12789
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040031F6 RID: 12790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040031F7 RID: 12791
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040031F8 RID: 12792
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040031F9 RID: 12793
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040031FA RID: 12794
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040031FB RID: 12795
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200039E RID: 926
	[ObfuscatedName("FacebookApiTab+<PostScreenshot>d__65")]
	public sealed class _PostScreenshot_d__65 : global::Il2CppSystem.Object
	{
		// Token: 0x060036C6 RID: 14022 RVA: 0x000E05B0 File Offset: 0x000DE7B0
		// Note: this type is marked as 'beforefieldinit'.
		static _PostScreenshot_d__65()
		{
			Il2CppClassPointerStore<FacebookApiTab._PostScreenshot_d__65>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FacebookApiTab>.NativeClassPtr, "<PostScreenshot>d__65");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FacebookApiTab._PostScreenshot_d__65>.NativeClassPtr);
			FacebookApiTab._PostScreenshot_d__65.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab._PostScreenshot_d__65>.NativeClassPtr, "<>1__state");
			FacebookApiTab._PostScreenshot_d__65.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookApiTab._PostScreenshot_d__65>.NativeClassPtr, "<>2__current");
			FacebookApiTab._PostScreenshot_d__65.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab._PostScreenshot_d__65>.NativeClassPtr, 100670258);
			FacebookApiTab._PostScreenshot_d__65.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab._PostScreenshot_d__65>.NativeClassPtr, 100670259);
			FacebookApiTab._PostScreenshot_d__65.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab._PostScreenshot_d__65>.NativeClassPtr, 100670260);
			FacebookApiTab._PostScreenshot_d__65.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab._PostScreenshot_d__65>.NativeClassPtr, 100670261);
			FacebookApiTab._PostScreenshot_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab._PostScreenshot_d__65>.NativeClassPtr, 100670262);
			FacebookApiTab._PostScreenshot_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookApiTab._PostScreenshot_d__65>.NativeClassPtr, 100670263);
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x000E067C File Offset: 0x000DE87C
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _PostScreenshot_d__65(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacebookApiTab._PostScreenshot_d__65>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab._PostScreenshot_d__65.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x000E06C4 File Offset: 0x000DE8C4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab._PostScreenshot_d__65.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x000E06F8 File Offset: 0x000DE8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192410, XrefRangeEnd = 192419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab._PostScreenshot_d__65.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x060036CA RID: 14026 RVA: 0x000E0734 File Offset: 0x000DE934
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab._PostScreenshot_d__65.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x000E0774 File Offset: 0x000DE974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192419, XrefRangeEnd = 192424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab._PostScreenshot_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x060036CC RID: 14028 RVA: 0x000E07A8 File Offset: 0x000DE9A8
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookApiTab._PostScreenshot_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x000153C2 File Offset: 0x000135C2
		public _PostScreenshot_d__65(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x060036CE RID: 14030 RVA: 0x000E07E8 File Offset: 0x000DE9E8
		// (set) Token: 0x060036CF RID: 14031 RVA: 0x000153CB File Offset: 0x000135CB
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab._PostScreenshot_d__65.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab._PostScreenshot_d__65.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x060036D0 RID: 14032 RVA: 0x000E0810 File Offset: 0x000DEA10
		// (set) Token: 0x060036D1 RID: 14033 RVA: 0x000153E6 File Offset: 0x000135E6
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab._PostScreenshot_d__65.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacebookApiTab._PostScreenshot_d__65.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031FC RID: 12796
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040031FD RID: 12797
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040031FE RID: 12798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040031FF RID: 12799
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003200 RID: 12800
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04003201 RID: 12801
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04003202 RID: 12802
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04003203 RID: 12803
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

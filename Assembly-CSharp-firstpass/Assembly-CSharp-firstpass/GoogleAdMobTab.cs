using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200010C RID: 268
public class GoogleAdMobTab : FeatureTab
{
	// Token: 0x0600123B RID: 4667 RVA: 0x00056614 File Offset: 0x00054814
	// Note: this type is marked as 'beforefieldinit'.
	static GoogleAdMobTab()
	{
		Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GoogleAdMobTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr);
		GoogleAdMobTab.NativeFieldInfoPtr_MY_BANNERS_AD_UNIT_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "MY_BANNERS_AD_UNIT_ID");
		GoogleAdMobTab.NativeFieldInfoPtr_MY_INTERSTISIALS_AD_UNIT_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "MY_INTERSTISIALS_AD_UNIT_ID");
		GoogleAdMobTab.NativeFieldInfoPtr_MY_REWARDED_VIDEO_AD_UNIT_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "MY_REWARDED_VIDEO_AD_UNIT_ID");
		GoogleAdMobTab.NativeFieldInfoPtr_Banner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "Banner");
		GoogleAdMobTab.NativeFieldInfoPtr_SmartBanner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "SmartBanner");
		GoogleAdMobTab.NativeFieldInfoPtr_IsInterstisialsAdReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "IsInterstisialsAdReady");
		GoogleAdMobTab.NativeFieldInfoPtr_ShowInterstitialButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "ShowInterstitialButton");
		GoogleAdMobTab.NativeFieldInfoPtr_CustomPosTgl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "CustomPosTgl");
		GoogleAdMobTab.NativeFieldInfoPtr_UpperLeftTgl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "UpperLeftTgl");
		GoogleAdMobTab.NativeFieldInfoPtr_UpperCenterTgl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "UpperCenterTgl");
		GoogleAdMobTab.NativeFieldInfoPtr_BottomLeftTgl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "BottomLeftTgl");
		GoogleAdMobTab.NativeFieldInfoPtr_BottomCenterTgl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "BottomCenterTgl");
		GoogleAdMobTab.NativeFieldInfoPtr_BottomRightTgl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "BottomRightTgl");
		GoogleAdMobTab.NativeFieldInfoPtr_BannerHideBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "BannerHideBtn");
		GoogleAdMobTab.NativeFieldInfoPtr_BannerCreateBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "BannerCreateBtn");
		GoogleAdMobTab.NativeFieldInfoPtr_BannerRefreshBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "BannerRefreshBtn");
		GoogleAdMobTab.NativeFieldInfoPtr_BannerChangePosToMiddleBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "BannerChangePosToMiddleBtn");
		GoogleAdMobTab.NativeFieldInfoPtr_BannerChangePosRandomBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "BannerChangePosRandomBtn");
		GoogleAdMobTab.NativeFieldInfoPtr_BannerDestroyBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "BannerDestroyBtn");
		GoogleAdMobTab.NativeFieldInfoPtr_SmartBotPosTgl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "SmartBotPosTgl");
		GoogleAdMobTab.NativeFieldInfoPtr_SmartTopPosTgl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "SmartTopPosTgl");
		GoogleAdMobTab.NativeFieldInfoPtr_SmartHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "SmartHide");
		GoogleAdMobTab.NativeFieldInfoPtr_SmartCreate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "SmartCreate");
		GoogleAdMobTab.NativeFieldInfoPtr_SmartRefresh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "SmartRefresh");
		GoogleAdMobTab.NativeFieldInfoPtr_SmartDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "SmartDestroy");
		GoogleAdMobTab.NativeFieldInfoPtr_BannerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "BannerPosition");
		GoogleAdMobTab.NativeFieldInfoPtr_SmartBannerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, "SmartBannerPosition");
		GoogleAdMobTab.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665504);
		GoogleAdMobTab.NativeMethodInfoPtr_HandleOnRewardedVideoAdClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665505);
		GoogleAdMobTab.NativeMethodInfoPtr_HandleOnRewardedVideoLoaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665506);
		GoogleAdMobTab.NativeMethodInfoPtr_StartInterstitialAd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665507);
		GoogleAdMobTab.NativeMethodInfoPtr_LoadInterstitialAd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665508);
		GoogleAdMobTab.NativeMethodInfoPtr_ShowInterstitialAd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665509);
		GoogleAdMobTab.NativeMethodInfoPtr_LoadRewardedVideoAd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665510);
		GoogleAdMobTab.NativeMethodInfoPtr_ShowRewardedVideoAd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665511);
		GoogleAdMobTab.NativeMethodInfoPtr_BannerHide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665512);
		GoogleAdMobTab.NativeMethodInfoPtr_BannerShow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665513);
		GoogleAdMobTab.NativeMethodInfoPtr_BannerRefresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665514);
		GoogleAdMobTab.NativeMethodInfoPtr_BannerDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665515);
		GoogleAdMobTab.NativeMethodInfoPtr_SmartBannerHide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665516);
		GoogleAdMobTab.NativeMethodInfoPtr_SmartBannerShow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665517);
		GoogleAdMobTab.NativeMethodInfoPtr_SmartBannerRefresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665518);
		GoogleAdMobTab.NativeMethodInfoPtr_SmartBannerDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665519);
		GoogleAdMobTab.NativeMethodInfoPtr_ChnagePostToMiddle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665520);
		GoogleAdMobTab.NativeMethodInfoPtr_ChangePostRandom_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665521);
		GoogleAdMobTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665522);
		GoogleAdMobTab.NativeMethodInfoPtr_OnInterstisialsLoaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665523);
		GoogleAdMobTab.NativeMethodInfoPtr_OnInterstisialsOpen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665524);
		GoogleAdMobTab.NativeMethodInfoPtr_OnInAppRequest_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665525);
		GoogleAdMobTab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665526);
		GoogleAdMobTab.NativeMethodInfoPtr__Start_b__27_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665527);
		GoogleAdMobTab.NativeMethodInfoPtr__Start_b__27_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665528);
		GoogleAdMobTab.NativeMethodInfoPtr__Start_b__27_2_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665529);
		GoogleAdMobTab.NativeMethodInfoPtr__Start_b__27_3_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665530);
		GoogleAdMobTab.NativeMethodInfoPtr__Start_b__27_4_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665531);
		GoogleAdMobTab.NativeMethodInfoPtr__Start_b__27_5_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665532);
		GoogleAdMobTab.NativeMethodInfoPtr__Start_b__27_6_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665533);
		GoogleAdMobTab.NativeMethodInfoPtr__Start_b__27_7_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr, 100665534);
	}

	// Token: 0x0600123C RID: 4668 RVA: 0x00056ACC File Offset: 0x00054CCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182629, XrefRangeEnd = 182781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600123D RID: 4669 RVA: 0x00056B00 File Offset: 0x00054D00
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleOnRewardedVideoAdClosed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_HandleOnRewardedVideoAdClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600123E RID: 4670 RVA: 0x00056B34 File Offset: 0x00054D34
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleOnRewardedVideoLoaded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_HandleOnRewardedVideoLoaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600123F RID: 4671 RVA: 0x00056B68 File Offset: 0x00054D68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182781, XrefRangeEnd = 182789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartInterstitialAd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_StartInterstitialAd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001240 RID: 4672 RVA: 0x00056B9C File Offset: 0x00054D9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182789, XrefRangeEnd = 182797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadInterstitialAd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_LoadInterstitialAd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001241 RID: 4673 RVA: 0x00056BD0 File Offset: 0x00054DD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182797, XrefRangeEnd = 182805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowInterstitialAd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_ShowInterstitialAd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001242 RID: 4674 RVA: 0x00056C04 File Offset: 0x00054E04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182805, XrefRangeEnd = 182813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadRewardedVideoAd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_LoadRewardedVideoAd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001243 RID: 4675 RVA: 0x00056C38 File Offset: 0x00054E38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182813, XrefRangeEnd = 182821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowRewardedVideoAd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_ShowRewardedVideoAd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001244 RID: 4676 RVA: 0x00056C6C File Offset: 0x00054E6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182821, XrefRangeEnd = 182825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BannerHide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_BannerHide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001245 RID: 4677 RVA: 0x00056CA0 File Offset: 0x00054EA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182825, XrefRangeEnd = 182836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BannerShow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_BannerShow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001246 RID: 4678 RVA: 0x00056CD4 File Offset: 0x00054ED4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182836, XrefRangeEnd = 182840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BannerRefresh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_BannerRefresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001247 RID: 4679 RVA: 0x00056D08 File Offset: 0x00054F08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182840, XrefRangeEnd = 182850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BannerDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_BannerDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001248 RID: 4680 RVA: 0x00056D3C File Offset: 0x00054F3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182850, XrefRangeEnd = 182854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SmartBannerHide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_SmartBannerHide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001249 RID: 4681 RVA: 0x00056D70 File Offset: 0x00054F70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182854, XrefRangeEnd = 182861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SmartBannerShow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_SmartBannerShow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600124A RID: 4682 RVA: 0x00056DA4 File Offset: 0x00054FA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182861, XrefRangeEnd = 182865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SmartBannerRefresh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_SmartBannerRefresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600124B RID: 4683 RVA: 0x00056DD8 File Offset: 0x00054FD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182865, XrefRangeEnd = 182875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SmartBannerDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_SmartBannerDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600124C RID: 4684 RVA: 0x00056E0C File Offset: 0x0005500C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182875, XrefRangeEnd = 182879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChnagePostToMiddle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_ChnagePostToMiddle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600124D RID: 4685 RVA: 0x00056E40 File Offset: 0x00055040
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182879, XrefRangeEnd = 182888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangePostRandom()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_ChangePostRandom_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600124E RID: 4686 RVA: 0x00056E74 File Offset: 0x00055074
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182888, XrefRangeEnd = 182929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600124F RID: 4687 RVA: 0x00056EA8 File Offset: 0x000550A8
	[CallerCount(0)]
	public unsafe void OnInterstisialsLoaded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_OnInterstisialsLoaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001250 RID: 4688 RVA: 0x00056EDC File Offset: 0x000550DC
	[CallerCount(0)]
	public unsafe void OnInterstisialsOpen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_OnInterstisialsOpen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001251 RID: 4689 RVA: 0x00056F10 File Offset: 0x00055110
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182929, XrefRangeEnd = 182945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInAppRequest(string productId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr_OnInAppRequest_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001252 RID: 4690 RVA: 0x00056F54 File Offset: 0x00055154
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182945, XrefRangeEnd = 182946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GoogleAdMobTab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleAdMobTab>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001253 RID: 4691 RVA: 0x00056F90 File Offset: 0x00055190
	[CallerCount(0)]
	public unsafe void _Start_b__27_0(bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr__Start_b__27_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001254 RID: 4692 RVA: 0x00056FD0 File Offset: 0x000551D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182946, XrefRangeEnd = 182949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__27_1(bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr__Start_b__27_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001255 RID: 4693 RVA: 0x00057010 File Offset: 0x00055210
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182949, XrefRangeEnd = 182952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__27_2(bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr__Start_b__27_2_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001256 RID: 4694 RVA: 0x00057050 File Offset: 0x00055250
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182952, XrefRangeEnd = 182955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__27_3(bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr__Start_b__27_3_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001257 RID: 4695 RVA: 0x00057090 File Offset: 0x00055290
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182955, XrefRangeEnd = 182958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__27_4(bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr__Start_b__27_4_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001258 RID: 4696 RVA: 0x000570D0 File Offset: 0x000552D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182958, XrefRangeEnd = 182961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__27_5(bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr__Start_b__27_5_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001259 RID: 4697 RVA: 0x00057110 File Offset: 0x00055310
	[CallerCount(0)]
	public unsafe void _Start_b__27_6(bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr__Start_b__27_6_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600125A RID: 4698 RVA: 0x00057150 File Offset: 0x00055350
	[CallerCount(0)]
	public unsafe void _Start_b__27_7(bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleAdMobTab.NativeMethodInfoPtr__Start_b__27_7_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600125B RID: 4699 RVA: 0x000090C7 File Offset: 0x000072C7
	public GoogleAdMobTab(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000562 RID: 1378
	// (get) Token: 0x0600125C RID: 4700 RVA: 0x00057190 File Offset: 0x00055390
	// (set) Token: 0x0600125D RID: 4701 RVA: 0x000090D0 File Offset: 0x000072D0
	public unsafe static string MY_BANNERS_AD_UNIT_ID
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleAdMobTab.NativeFieldInfoPtr_MY_BANNERS_AD_UNIT_ID, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleAdMobTab.NativeFieldInfoPtr_MY_BANNERS_AD_UNIT_ID, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000563 RID: 1379
	// (get) Token: 0x0600125E RID: 4702 RVA: 0x000571B0 File Offset: 0x000553B0
	// (set) Token: 0x0600125F RID: 4703 RVA: 0x000090E2 File Offset: 0x000072E2
	public unsafe static string MY_INTERSTISIALS_AD_UNIT_ID
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleAdMobTab.NativeFieldInfoPtr_MY_INTERSTISIALS_AD_UNIT_ID, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleAdMobTab.NativeFieldInfoPtr_MY_INTERSTISIALS_AD_UNIT_ID, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000564 RID: 1380
	// (get) Token: 0x06001260 RID: 4704 RVA: 0x000571D0 File Offset: 0x000553D0
	// (set) Token: 0x06001261 RID: 4705 RVA: 0x000090F4 File Offset: 0x000072F4
	public unsafe static string MY_REWARDED_VIDEO_AD_UNIT_ID
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleAdMobTab.NativeFieldInfoPtr_MY_REWARDED_VIDEO_AD_UNIT_ID, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleAdMobTab.NativeFieldInfoPtr_MY_REWARDED_VIDEO_AD_UNIT_ID, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000565 RID: 1381
	// (get) Token: 0x06001262 RID: 4706 RVA: 0x000571F0 File Offset: 0x000553F0
	// (set) Token: 0x06001263 RID: 4707 RVA: 0x00009106 File Offset: 0x00007306
	public unsafe GoogleMobileAdBanner Banner
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_Banner);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleMobileAdBanner>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_Banner), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000566 RID: 1382
	// (get) Token: 0x06001264 RID: 4708 RVA: 0x00057220 File Offset: 0x00055420
	// (set) Token: 0x06001265 RID: 4709 RVA: 0x00009125 File Offset: 0x00007325
	public unsafe GoogleMobileAdBanner SmartBanner
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_SmartBanner);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleMobileAdBanner>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_SmartBanner), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000567 RID: 1383
	// (get) Token: 0x06001266 RID: 4710 RVA: 0x00057250 File Offset: 0x00055450
	// (set) Token: 0x06001267 RID: 4711 RVA: 0x00009144 File Offset: 0x00007344
	public unsafe bool IsInterstisialsAdReady
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_IsInterstisialsAdReady);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_IsInterstisialsAdReady)) = value;
		}
	}

	// Token: 0x17000568 RID: 1384
	// (get) Token: 0x06001268 RID: 4712 RVA: 0x00057278 File Offset: 0x00055478
	// (set) Token: 0x06001269 RID: 4713 RVA: 0x0000915F File Offset: 0x0000735F
	public unsafe Button ShowInterstitialButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_ShowInterstitialButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_ShowInterstitialButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000569 RID: 1385
	// (get) Token: 0x0600126A RID: 4714 RVA: 0x000572A8 File Offset: 0x000554A8
	// (set) Token: 0x0600126B RID: 4715 RVA: 0x0000917E File Offset: 0x0000737E
	public unsafe Toggle CustomPosTgl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_CustomPosTgl);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_CustomPosTgl), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700056A RID: 1386
	// (get) Token: 0x0600126C RID: 4716 RVA: 0x000572D8 File Offset: 0x000554D8
	// (set) Token: 0x0600126D RID: 4717 RVA: 0x0000919D File Offset: 0x0000739D
	public unsafe Toggle UpperLeftTgl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_UpperLeftTgl);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_UpperLeftTgl), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700056B RID: 1387
	// (get) Token: 0x0600126E RID: 4718 RVA: 0x00057308 File Offset: 0x00055508
	// (set) Token: 0x0600126F RID: 4719 RVA: 0x000091BC File Offset: 0x000073BC
	public unsafe Toggle UpperCenterTgl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_UpperCenterTgl);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_UpperCenterTgl), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700056C RID: 1388
	// (get) Token: 0x06001270 RID: 4720 RVA: 0x00057338 File Offset: 0x00055538
	// (set) Token: 0x06001271 RID: 4721 RVA: 0x000091DB File Offset: 0x000073DB
	public unsafe Toggle BottomLeftTgl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BottomLeftTgl);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BottomLeftTgl), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700056D RID: 1389
	// (get) Token: 0x06001272 RID: 4722 RVA: 0x00057368 File Offset: 0x00055568
	// (set) Token: 0x06001273 RID: 4723 RVA: 0x000091FA File Offset: 0x000073FA
	public unsafe Toggle BottomCenterTgl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BottomCenterTgl);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BottomCenterTgl), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700056E RID: 1390
	// (get) Token: 0x06001274 RID: 4724 RVA: 0x00057398 File Offset: 0x00055598
	// (set) Token: 0x06001275 RID: 4725 RVA: 0x00009219 File Offset: 0x00007419
	public unsafe Toggle BottomRightTgl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BottomRightTgl);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BottomRightTgl), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700056F RID: 1391
	// (get) Token: 0x06001276 RID: 4726 RVA: 0x000573C8 File Offset: 0x000555C8
	// (set) Token: 0x06001277 RID: 4727 RVA: 0x00009238 File Offset: 0x00007438
	public unsafe Button BannerHideBtn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BannerHideBtn);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BannerHideBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000570 RID: 1392
	// (get) Token: 0x06001278 RID: 4728 RVA: 0x000573F8 File Offset: 0x000555F8
	// (set) Token: 0x06001279 RID: 4729 RVA: 0x00009257 File Offset: 0x00007457
	public unsafe Button BannerCreateBtn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BannerCreateBtn);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BannerCreateBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000571 RID: 1393
	// (get) Token: 0x0600127A RID: 4730 RVA: 0x00057428 File Offset: 0x00055628
	// (set) Token: 0x0600127B RID: 4731 RVA: 0x00009276 File Offset: 0x00007476
	public unsafe Button BannerRefreshBtn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BannerRefreshBtn);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BannerRefreshBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000572 RID: 1394
	// (get) Token: 0x0600127C RID: 4732 RVA: 0x00057458 File Offset: 0x00055658
	// (set) Token: 0x0600127D RID: 4733 RVA: 0x00009295 File Offset: 0x00007495
	public unsafe Button BannerChangePosToMiddleBtn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BannerChangePosToMiddleBtn);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BannerChangePosToMiddleBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000573 RID: 1395
	// (get) Token: 0x0600127E RID: 4734 RVA: 0x00057488 File Offset: 0x00055688
	// (set) Token: 0x0600127F RID: 4735 RVA: 0x000092B4 File Offset: 0x000074B4
	public unsafe Button BannerChangePosRandomBtn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BannerChangePosRandomBtn);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BannerChangePosRandomBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000574 RID: 1396
	// (get) Token: 0x06001280 RID: 4736 RVA: 0x000574B8 File Offset: 0x000556B8
	// (set) Token: 0x06001281 RID: 4737 RVA: 0x000092D3 File Offset: 0x000074D3
	public unsafe Button BannerDestroyBtn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BannerDestroyBtn);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BannerDestroyBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000575 RID: 1397
	// (get) Token: 0x06001282 RID: 4738 RVA: 0x000574E8 File Offset: 0x000556E8
	// (set) Token: 0x06001283 RID: 4739 RVA: 0x000092F2 File Offset: 0x000074F2
	public unsafe Toggle SmartBotPosTgl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_SmartBotPosTgl);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_SmartBotPosTgl), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000576 RID: 1398
	// (get) Token: 0x06001284 RID: 4740 RVA: 0x00057518 File Offset: 0x00055718
	// (set) Token: 0x06001285 RID: 4741 RVA: 0x00009311 File Offset: 0x00007511
	public unsafe Toggle SmartTopPosTgl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_SmartTopPosTgl);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_SmartTopPosTgl), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000577 RID: 1399
	// (get) Token: 0x06001286 RID: 4742 RVA: 0x00057548 File Offset: 0x00055748
	// (set) Token: 0x06001287 RID: 4743 RVA: 0x00009330 File Offset: 0x00007530
	public unsafe Button SmartHide
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_SmartHide);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_SmartHide), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000578 RID: 1400
	// (get) Token: 0x06001288 RID: 4744 RVA: 0x00057578 File Offset: 0x00055778
	// (set) Token: 0x06001289 RID: 4745 RVA: 0x0000934F File Offset: 0x0000754F
	public unsafe Button SmartCreate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_SmartCreate);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_SmartCreate), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000579 RID: 1401
	// (get) Token: 0x0600128A RID: 4746 RVA: 0x000575A8 File Offset: 0x000557A8
	// (set) Token: 0x0600128B RID: 4747 RVA: 0x0000936E File Offset: 0x0000756E
	public unsafe Button SmartRefresh
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_SmartRefresh);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_SmartRefresh), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700057A RID: 1402
	// (get) Token: 0x0600128C RID: 4748 RVA: 0x000575D8 File Offset: 0x000557D8
	// (set) Token: 0x0600128D RID: 4749 RVA: 0x0000938D File Offset: 0x0000758D
	public unsafe Button SmartDestroy
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_SmartDestroy);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_SmartDestroy), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700057B RID: 1403
	// (get) Token: 0x0600128E RID: 4750 RVA: 0x00057608 File Offset: 0x00055808
	// (set) Token: 0x0600128F RID: 4751 RVA: 0x000093AC File Offset: 0x000075AC
	public Nullable<TextAnchor> BannerPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BannerPosition);
			return new Nullable<TextAnchor>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<TextAnchor>>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_BannerPosition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<TextAnchor>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x1700057C RID: 1404
	// (get) Token: 0x06001290 RID: 4752 RVA: 0x00057638 File Offset: 0x00055838
	// (set) Token: 0x06001291 RID: 4753 RVA: 0x000093DA File Offset: 0x000075DA
	public unsafe TextAnchor SmartBannerPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_SmartBannerPosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleAdMobTab.NativeFieldInfoPtr_SmartBannerPosition)) = value;
		}
	}

	// Token: 0x04000E0B RID: 3595
	private static readonly IntPtr NativeFieldInfoPtr_MY_BANNERS_AD_UNIT_ID;

	// Token: 0x04000E0C RID: 3596
	private static readonly IntPtr NativeFieldInfoPtr_MY_INTERSTISIALS_AD_UNIT_ID;

	// Token: 0x04000E0D RID: 3597
	private static readonly IntPtr NativeFieldInfoPtr_MY_REWARDED_VIDEO_AD_UNIT_ID;

	// Token: 0x04000E0E RID: 3598
	private static readonly IntPtr NativeFieldInfoPtr_Banner;

	// Token: 0x04000E0F RID: 3599
	private static readonly IntPtr NativeFieldInfoPtr_SmartBanner;

	// Token: 0x04000E10 RID: 3600
	private static readonly IntPtr NativeFieldInfoPtr_IsInterstisialsAdReady;

	// Token: 0x04000E11 RID: 3601
	private static readonly IntPtr NativeFieldInfoPtr_ShowInterstitialButton;

	// Token: 0x04000E12 RID: 3602
	private static readonly IntPtr NativeFieldInfoPtr_CustomPosTgl;

	// Token: 0x04000E13 RID: 3603
	private static readonly IntPtr NativeFieldInfoPtr_UpperLeftTgl;

	// Token: 0x04000E14 RID: 3604
	private static readonly IntPtr NativeFieldInfoPtr_UpperCenterTgl;

	// Token: 0x04000E15 RID: 3605
	private static readonly IntPtr NativeFieldInfoPtr_BottomLeftTgl;

	// Token: 0x04000E16 RID: 3606
	private static readonly IntPtr NativeFieldInfoPtr_BottomCenterTgl;

	// Token: 0x04000E17 RID: 3607
	private static readonly IntPtr NativeFieldInfoPtr_BottomRightTgl;

	// Token: 0x04000E18 RID: 3608
	private static readonly IntPtr NativeFieldInfoPtr_BannerHideBtn;

	// Token: 0x04000E19 RID: 3609
	private static readonly IntPtr NativeFieldInfoPtr_BannerCreateBtn;

	// Token: 0x04000E1A RID: 3610
	private static readonly IntPtr NativeFieldInfoPtr_BannerRefreshBtn;

	// Token: 0x04000E1B RID: 3611
	private static readonly IntPtr NativeFieldInfoPtr_BannerChangePosToMiddleBtn;

	// Token: 0x04000E1C RID: 3612
	private static readonly IntPtr NativeFieldInfoPtr_BannerChangePosRandomBtn;

	// Token: 0x04000E1D RID: 3613
	private static readonly IntPtr NativeFieldInfoPtr_BannerDestroyBtn;

	// Token: 0x04000E1E RID: 3614
	private static readonly IntPtr NativeFieldInfoPtr_SmartBotPosTgl;

	// Token: 0x04000E1F RID: 3615
	private static readonly IntPtr NativeFieldInfoPtr_SmartTopPosTgl;

	// Token: 0x04000E20 RID: 3616
	private static readonly IntPtr NativeFieldInfoPtr_SmartHide;

	// Token: 0x04000E21 RID: 3617
	private static readonly IntPtr NativeFieldInfoPtr_SmartCreate;

	// Token: 0x04000E22 RID: 3618
	private static readonly IntPtr NativeFieldInfoPtr_SmartRefresh;

	// Token: 0x04000E23 RID: 3619
	private static readonly IntPtr NativeFieldInfoPtr_SmartDestroy;

	// Token: 0x04000E24 RID: 3620
	private static readonly IntPtr NativeFieldInfoPtr_BannerPosition;

	// Token: 0x04000E25 RID: 3621
	private static readonly IntPtr NativeFieldInfoPtr_SmartBannerPosition;

	// Token: 0x04000E26 RID: 3622
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000E27 RID: 3623
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnRewardedVideoAdClosed_Private_Void_0;

	// Token: 0x04000E28 RID: 3624
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnRewardedVideoLoaded_Private_Void_0;

	// Token: 0x04000E29 RID: 3625
	private static readonly IntPtr NativeMethodInfoPtr_StartInterstitialAd_Public_Void_0;

	// Token: 0x04000E2A RID: 3626
	private static readonly IntPtr NativeMethodInfoPtr_LoadInterstitialAd_Public_Void_0;

	// Token: 0x04000E2B RID: 3627
	private static readonly IntPtr NativeMethodInfoPtr_ShowInterstitialAd_Public_Void_0;

	// Token: 0x04000E2C RID: 3628
	private static readonly IntPtr NativeMethodInfoPtr_LoadRewardedVideoAd_Public_Void_0;

	// Token: 0x04000E2D RID: 3629
	private static readonly IntPtr NativeMethodInfoPtr_ShowRewardedVideoAd_Public_Void_0;

	// Token: 0x04000E2E RID: 3630
	private static readonly IntPtr NativeMethodInfoPtr_BannerHide_Public_Void_0;

	// Token: 0x04000E2F RID: 3631
	private static readonly IntPtr NativeMethodInfoPtr_BannerShow_Public_Void_0;

	// Token: 0x04000E30 RID: 3632
	private static readonly IntPtr NativeMethodInfoPtr_BannerRefresh_Public_Void_0;

	// Token: 0x04000E31 RID: 3633
	private static readonly IntPtr NativeMethodInfoPtr_BannerDestroy_Public_Void_0;

	// Token: 0x04000E32 RID: 3634
	private static readonly IntPtr NativeMethodInfoPtr_SmartBannerHide_Public_Void_0;

	// Token: 0x04000E33 RID: 3635
	private static readonly IntPtr NativeMethodInfoPtr_SmartBannerShow_Public_Void_0;

	// Token: 0x04000E34 RID: 3636
	private static readonly IntPtr NativeMethodInfoPtr_SmartBannerRefresh_Public_Void_0;

	// Token: 0x04000E35 RID: 3637
	private static readonly IntPtr NativeMethodInfoPtr_SmartBannerDestroy_Public_Void_0;

	// Token: 0x04000E36 RID: 3638
	private static readonly IntPtr NativeMethodInfoPtr_ChnagePostToMiddle_Public_Void_0;

	// Token: 0x04000E37 RID: 3639
	private static readonly IntPtr NativeMethodInfoPtr_ChangePostRandom_Public_Void_0;

	// Token: 0x04000E38 RID: 3640
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x04000E39 RID: 3641
	private static readonly IntPtr NativeMethodInfoPtr_OnInterstisialsLoaded_Private_Void_0;

	// Token: 0x04000E3A RID: 3642
	private static readonly IntPtr NativeMethodInfoPtr_OnInterstisialsOpen_Private_Void_0;

	// Token: 0x04000E3B RID: 3643
	private static readonly IntPtr NativeMethodInfoPtr_OnInAppRequest_Private_Void_String_0;

	// Token: 0x04000E3C RID: 3644
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000E3D RID: 3645
	private static readonly IntPtr NativeMethodInfoPtr__Start_b__27_0_Private_Void_Boolean_0;

	// Token: 0x04000E3E RID: 3646
	private static readonly IntPtr NativeMethodInfoPtr__Start_b__27_1_Private_Void_Boolean_0;

	// Token: 0x04000E3F RID: 3647
	private static readonly IntPtr NativeMethodInfoPtr__Start_b__27_2_Private_Void_Boolean_0;

	// Token: 0x04000E40 RID: 3648
	private static readonly IntPtr NativeMethodInfoPtr__Start_b__27_3_Private_Void_Boolean_0;

	// Token: 0x04000E41 RID: 3649
	private static readonly IntPtr NativeMethodInfoPtr__Start_b__27_4_Private_Void_Boolean_0;

	// Token: 0x04000E42 RID: 3650
	private static readonly IntPtr NativeMethodInfoPtr__Start_b__27_5_Private_Void_Boolean_0;

	// Token: 0x04000E43 RID: 3651
	private static readonly IntPtr NativeMethodInfoPtr__Start_b__27_6_Private_Void_Boolean_0;

	// Token: 0x04000E44 RID: 3652
	private static readonly IntPtr NativeMethodInfoPtr__Start_b__27_7_Private_Void_Boolean_0;
}

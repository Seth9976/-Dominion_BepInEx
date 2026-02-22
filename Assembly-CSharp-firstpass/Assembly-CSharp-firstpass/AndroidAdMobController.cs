using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using SA.Common.Pattern;
using UnityEngine;

// Token: 0x02000009 RID: 9
public class AndroidAdMobController : Singleton<AndroidAdMobController>
{
	// Token: 0x0600004B RID: 75 RVA: 0x00017CD8 File Offset: 0x00015ED8
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidAdMobController()
	{
		Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidAdMobController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr);
		AndroidAdMobController.NativeFieldInfoPtr__IsInited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "_IsInited");
		AndroidAdMobController.NativeFieldInfoPtr__banners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "_banners");
		AndroidAdMobController.NativeFieldInfoPtr__IsEditorTestingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "_IsEditorTestingEnabled");
		AndroidAdMobController.NativeFieldInfoPtr__EditorFillRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "_EditorFillRate");
		AndroidAdMobController.NativeFieldInfoPtr__BannersUunitId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "_BannersUunitId");
		AndroidAdMobController.NativeFieldInfoPtr__InterstisialUnitId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "_InterstisialUnitId");
		AndroidAdMobController.NativeFieldInfoPtr__RewardedVideoAdUnitId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "_RewardedVideoAdUnitId");
		AndroidAdMobController.NativeFieldInfoPtr_OnRewarded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "OnRewarded");
		AndroidAdMobController.NativeFieldInfoPtr_OnRewardedVideoAdClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "OnRewardedVideoAdClosed");
		AndroidAdMobController.NativeFieldInfoPtr_OnRewardedVideoAdFailedToLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "OnRewardedVideoAdFailedToLoad");
		AndroidAdMobController.NativeFieldInfoPtr_OnRewardedVideoAdLeftApplication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "OnRewardedVideoAdLeftApplication");
		AndroidAdMobController.NativeFieldInfoPtr_OnRewardedVideoLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "OnRewardedVideoLoaded");
		AndroidAdMobController.NativeFieldInfoPtr_OnRewardedVideoAdOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "OnRewardedVideoAdOpened");
		AndroidAdMobController.NativeFieldInfoPtr_OnRewardedVideoStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "OnRewardedVideoStarted");
		AndroidAdMobController.NativeFieldInfoPtr_OnInterstitialLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "OnInterstitialLoaded");
		AndroidAdMobController.NativeFieldInfoPtr_OnInterstitialFailedLoading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "OnInterstitialFailedLoading");
		AndroidAdMobController.NativeFieldInfoPtr_OnInterstitialOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "OnInterstitialOpened");
		AndroidAdMobController.NativeFieldInfoPtr_OnInterstitialClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "OnInterstitialClosed");
		AndroidAdMobController.NativeFieldInfoPtr_OnInterstitialLeftApplication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "OnInterstitialLeftApplication");
		AndroidAdMobController.NativeFieldInfoPtr_OnAdInAppRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "OnAdInAppRequest");
		AndroidAdMobController.NativeFieldInfoPtr_DEVICES_SEPARATOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "DEVICES_SEPARATOR");
		AndroidAdMobController.NativeFieldInfoPtr__InterstitialShowOnLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "_InterstitialShowOnLoad");
		AndroidAdMobController.NativeFieldInfoPtr__RewardedVideoShowOnLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "_RewardedVideoShowOnLoad");
		AndroidAdMobController.NativeMethodInfoPtr_add_OnRewarded_Public_Virtual_Final_New_add_Void_Action_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663351);
		AndroidAdMobController.NativeMethodInfoPtr_remove_OnRewarded_Public_Virtual_Final_New_rem_Void_Action_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663352);
		AndroidAdMobController.NativeMethodInfoPtr_add_OnRewardedVideoAdClosed_Public_Virtual_Final_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663353);
		AndroidAdMobController.NativeMethodInfoPtr_remove_OnRewardedVideoAdClosed_Public_Virtual_Final_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663354);
		AndroidAdMobController.NativeMethodInfoPtr_add_OnRewardedVideoAdFailedToLoad_Public_Virtual_Final_New_add_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663355);
		AndroidAdMobController.NativeMethodInfoPtr_remove_OnRewardedVideoAdFailedToLoad_Public_Virtual_Final_New_rem_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663356);
		AndroidAdMobController.NativeMethodInfoPtr_add_OnRewardedVideoAdLeftApplication_Public_Virtual_Final_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663357);
		AndroidAdMobController.NativeMethodInfoPtr_remove_OnRewardedVideoAdLeftApplication_Public_Virtual_Final_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663358);
		AndroidAdMobController.NativeMethodInfoPtr_add_OnRewardedVideoLoaded_Public_Virtual_Final_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663359);
		AndroidAdMobController.NativeMethodInfoPtr_remove_OnRewardedVideoLoaded_Public_Virtual_Final_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663360);
		AndroidAdMobController.NativeMethodInfoPtr_add_OnRewardedVideoAdOpened_Public_Virtual_Final_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663361);
		AndroidAdMobController.NativeMethodInfoPtr_remove_OnRewardedVideoAdOpened_Public_Virtual_Final_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663362);
		AndroidAdMobController.NativeMethodInfoPtr_add_OnRewardedVideoStarted_Public_Virtual_Final_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663363);
		AndroidAdMobController.NativeMethodInfoPtr_remove_OnRewardedVideoStarted_Public_Virtual_Final_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663364);
		AndroidAdMobController.NativeMethodInfoPtr_add_OnInterstitialLoaded_Public_Virtual_Final_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663365);
		AndroidAdMobController.NativeMethodInfoPtr_remove_OnInterstitialLoaded_Public_Virtual_Final_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663366);
		AndroidAdMobController.NativeMethodInfoPtr_add_OnInterstitialFailedLoading_Public_Virtual_Final_New_add_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663367);
		AndroidAdMobController.NativeMethodInfoPtr_remove_OnInterstitialFailedLoading_Public_Virtual_Final_New_rem_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663368);
		AndroidAdMobController.NativeMethodInfoPtr_add_OnInterstitialOpened_Public_Virtual_Final_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663369);
		AndroidAdMobController.NativeMethodInfoPtr_remove_OnInterstitialOpened_Public_Virtual_Final_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663370);
		AndroidAdMobController.NativeMethodInfoPtr_add_OnInterstitialClosed_Public_Virtual_Final_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663371);
		AndroidAdMobController.NativeMethodInfoPtr_remove_OnInterstitialClosed_Public_Virtual_Final_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663372);
		AndroidAdMobController.NativeMethodInfoPtr_add_OnInterstitialLeftApplication_Public_Virtual_Final_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663373);
		AndroidAdMobController.NativeMethodInfoPtr_remove_OnInterstitialLeftApplication_Public_Virtual_Final_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663374);
		AndroidAdMobController.NativeMethodInfoPtr_add_OnAdInAppRequest_Public_Virtual_Final_New_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663375);
		AndroidAdMobController.NativeMethodInfoPtr_remove_OnAdInAppRequest_Public_Virtual_Final_New_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663376);
		AndroidAdMobController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663377);
		AndroidAdMobController.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663378);
		AndroidAdMobController.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663379);
		AndroidAdMobController.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663380);
		AndroidAdMobController.NativeMethodInfoPtr_InitEditorTesting_Public_Virtual_Final_New_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663381);
		AndroidAdMobController.NativeMethodInfoPtr_SetBannersUnitID_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663382);
		AndroidAdMobController.NativeMethodInfoPtr_SetInterstisialsUnitID_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663383);
		AndroidAdMobController.NativeMethodInfoPtr_SetRewardedVideoAdUnitID_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663384);
		AndroidAdMobController.NativeMethodInfoPtr_AddKeyword_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663385);
		AndroidAdMobController.NativeMethodInfoPtr_SetBirthday_Public_Virtual_Final_New_Void_Int32_AndroidMonth_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663386);
		AndroidAdMobController.NativeMethodInfoPtr_TagForChildDirectedTreatment_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663387);
		AndroidAdMobController.NativeMethodInfoPtr_AddTestDevice_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663388);
		AndroidAdMobController.NativeMethodInfoPtr_AddTestDevices_Public_Virtual_Final_New_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663389);
		AndroidAdMobController.NativeMethodInfoPtr_SetGender_Public_Virtual_Final_New_Void_GoogleGender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663390);
		AndroidAdMobController.NativeMethodInfoPtr_CreateAdBanner_Public_Virtual_Final_New_GoogleMobileAdBanner_TextAnchor_GADBannerSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663391);
		AndroidAdMobController.NativeMethodInfoPtr_CreateAdBanner_Public_Virtual_Final_New_GoogleMobileAdBanner_Int32_Int32_GADBannerSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663392);
		AndroidAdMobController.NativeMethodInfoPtr_DestroyBanner_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663393);
		AndroidAdMobController.NativeMethodInfoPtr_StartInterstitialAd_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663394);
		AndroidAdMobController.NativeMethodInfoPtr_LoadInterstitialAd_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663395);
		AndroidAdMobController.NativeMethodInfoPtr_HandleOnInterstitialLoadComplete_Editor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663396);
		AndroidAdMobController.NativeMethodInfoPtr_ShowInterstitialAd_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663397);
		AndroidAdMobController.NativeMethodInfoPtr_HandleOnInterstitialFinished_Editor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663398);
		AndroidAdMobController.NativeMethodInfoPtr_HandleOnInterstitialLeftApplication_Editor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663399);
		AndroidAdMobController.NativeMethodInfoPtr_StartRewardedVideo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663400);
		AndroidAdMobController.NativeMethodInfoPtr_LoadRewardedVideo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663401);
		AndroidAdMobController.NativeMethodInfoPtr_HandleOnVideoLoadComplete_Editor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663402);
		AndroidAdMobController.NativeMethodInfoPtr_ShowRewardedVideo_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663403);
		AndroidAdMobController.NativeMethodInfoPtr_HandleOnVideoFinished_Editor_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663404);
		AndroidAdMobController.NativeMethodInfoPtr_HandleOnVideoLeftApplication_Editor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663405);
		AndroidAdMobController.NativeMethodInfoPtr_RecordInAppResolution_Public_Virtual_Final_New_Void_GADInAppResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663406);
		AndroidAdMobController.NativeMethodInfoPtr_GetBanner_Public_Virtual_Final_New_GoogleMobileAdBanner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663407);
		AndroidAdMobController.NativeMethodInfoPtr_get_banners_Public_Virtual_Final_New_get_List_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663408);
		AndroidAdMobController.NativeMethodInfoPtr_get_IsInited_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663409);
		AndroidAdMobController.NativeMethodInfoPtr_get_BannersUunitId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663410);
		AndroidAdMobController.NativeMethodInfoPtr_get_InterstisialUnitId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663411);
		AndroidAdMobController.NativeMethodInfoPtr_get_RewardedVideoAdUnitId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663412);
		AndroidAdMobController.NativeMethodInfoPtr_get_IsEditorTestingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663413);
		AndroidAdMobController.NativeMethodInfoPtr_OnBannerAdLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663414);
		AndroidAdMobController.NativeMethodInfoPtr_OnBannerAdFailedToLoad_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663415);
		AndroidAdMobController.NativeMethodInfoPtr_OnBannerAdOpened_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663416);
		AndroidAdMobController.NativeMethodInfoPtr_OnBannerAdClosed_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663417);
		AndroidAdMobController.NativeMethodInfoPtr_OnBannerAdLeftApplication_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663418);
		AndroidAdMobController.NativeMethodInfoPtr_OnInterstitialAdLoaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663419);
		AndroidAdMobController.NativeMethodInfoPtr_OnInterstitialAdFailedToLoad_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663420);
		AndroidAdMobController.NativeMethodInfoPtr_OnInterstitialAdOpened_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663421);
		AndroidAdMobController.NativeMethodInfoPtr_OnInterstitialAdClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663422);
		AndroidAdMobController.NativeMethodInfoPtr_OnInterstitialAdLeftApplication_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663423);
		AndroidAdMobController.NativeMethodInfoPtr_RewardedCallback_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663424);
		AndroidAdMobController.NativeMethodInfoPtr_RewardedVideoAdClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663425);
		AndroidAdMobController.NativeMethodInfoPtr_RewardedVideoAdFailedToLoad_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663426);
		AndroidAdMobController.NativeMethodInfoPtr_RewardedVideoAdLeftApplication_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663427);
		AndroidAdMobController.NativeMethodInfoPtr_RewardedVideoLoaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663428);
		AndroidAdMobController.NativeMethodInfoPtr_RewardedVideoAdOpened_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663429);
		AndroidAdMobController.NativeMethodInfoPtr_RewardedVideoStarted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663430);
		AndroidAdMobController.NativeMethodInfoPtr_OnInAppPurchaseRequested_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663431);
		AndroidAdMobController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, 100663432);
	}

	// Token: 0x0600004C RID: 76 RVA: 0x0001853C File Offset: 0x0001673C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159782, XrefRangeEnd = 159786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_OnRewarded(Action<string, int> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_add_OnRewarded_Public_Virtual_Final_New_add_Void_Action_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00018580 File Offset: 0x00016780
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159786, XrefRangeEnd = 159790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_OnRewarded(Action<string, int> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_remove_OnRewarded_Public_Virtual_Final_New_rem_Void_Action_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600004E RID: 78 RVA: 0x000185C4 File Offset: 0x000167C4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 159794, RefRangeEnd = 159795, XrefRangeStart = 159790, XrefRangeEnd = 159794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_OnRewardedVideoAdClosed(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_add_OnRewardedVideoAdClosed_Public_Virtual_Final_New_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00018608 File Offset: 0x00016808
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159795, XrefRangeEnd = 159799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_OnRewardedVideoAdClosed(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_remove_OnRewardedVideoAdClosed_Public_Virtual_Final_New_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000050 RID: 80 RVA: 0x0001864C File Offset: 0x0001684C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159799, XrefRangeEnd = 159803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_OnRewardedVideoAdFailedToLoad(Action<int> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_add_OnRewardedVideoAdFailedToLoad_Public_Virtual_Final_New_add_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00018690 File Offset: 0x00016890
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159803, XrefRangeEnd = 159807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_OnRewardedVideoAdFailedToLoad(Action<int> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_remove_OnRewardedVideoAdFailedToLoad_Public_Virtual_Final_New_rem_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000052 RID: 82 RVA: 0x000186D4 File Offset: 0x000168D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159807, XrefRangeEnd = 159811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_OnRewardedVideoAdLeftApplication(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_add_OnRewardedVideoAdLeftApplication_Public_Virtual_Final_New_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00018718 File Offset: 0x00016918
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159811, XrefRangeEnd = 159815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_OnRewardedVideoAdLeftApplication(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_remove_OnRewardedVideoAdLeftApplication_Public_Virtual_Final_New_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000054 RID: 84 RVA: 0x0001875C File Offset: 0x0001695C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 159819, RefRangeEnd = 159820, XrefRangeStart = 159815, XrefRangeEnd = 159819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_OnRewardedVideoLoaded(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_add_OnRewardedVideoLoaded_Public_Virtual_Final_New_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000055 RID: 85 RVA: 0x000187A0 File Offset: 0x000169A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159820, XrefRangeEnd = 159824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_OnRewardedVideoLoaded(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_remove_OnRewardedVideoLoaded_Public_Virtual_Final_New_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000056 RID: 86 RVA: 0x000187E4 File Offset: 0x000169E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159824, XrefRangeEnd = 159828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_OnRewardedVideoAdOpened(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_add_OnRewardedVideoAdOpened_Public_Virtual_Final_New_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00018828 File Offset: 0x00016A28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159828, XrefRangeEnd = 159832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_OnRewardedVideoAdOpened(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_remove_OnRewardedVideoAdOpened_Public_Virtual_Final_New_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000058 RID: 88 RVA: 0x0001886C File Offset: 0x00016A6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159832, XrefRangeEnd = 159836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_OnRewardedVideoStarted(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_add_OnRewardedVideoStarted_Public_Virtual_Final_New_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000059 RID: 89 RVA: 0x000188B0 File Offset: 0x00016AB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159836, XrefRangeEnd = 159840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_OnRewardedVideoStarted(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_remove_OnRewardedVideoStarted_Public_Virtual_Final_New_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600005A RID: 90 RVA: 0x000188F4 File Offset: 0x00016AF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159840, XrefRangeEnd = 159844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_OnInterstitialLoaded(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_add_OnInterstitialLoaded_Public_Virtual_Final_New_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00018938 File Offset: 0x00016B38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159844, XrefRangeEnd = 159848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_OnInterstitialLoaded(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_remove_OnInterstitialLoaded_Public_Virtual_Final_New_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600005C RID: 92 RVA: 0x0001897C File Offset: 0x00016B7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159848, XrefRangeEnd = 159852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_OnInterstitialFailedLoading(Action<int> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_add_OnInterstitialFailedLoading_Public_Virtual_Final_New_add_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600005D RID: 93 RVA: 0x000189C0 File Offset: 0x00016BC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159852, XrefRangeEnd = 159856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_OnInterstitialFailedLoading(Action<int> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_remove_OnInterstitialFailedLoading_Public_Virtual_Final_New_rem_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00018A04 File Offset: 0x00016C04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159856, XrefRangeEnd = 159860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_OnInterstitialOpened(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_add_OnInterstitialOpened_Public_Virtual_Final_New_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00018A48 File Offset: 0x00016C48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159860, XrefRangeEnd = 159864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_OnInterstitialOpened(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_remove_OnInterstitialOpened_Public_Virtual_Final_New_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00018A8C File Offset: 0x00016C8C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159864, XrefRangeEnd = 159868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_OnInterstitialClosed(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_add_OnInterstitialClosed_Public_Virtual_Final_New_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00018AD0 File Offset: 0x00016CD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159868, XrefRangeEnd = 159872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_OnInterstitialClosed(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_remove_OnInterstitialClosed_Public_Virtual_Final_New_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00018B14 File Offset: 0x00016D14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159872, XrefRangeEnd = 159876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_OnInterstitialLeftApplication(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_add_OnInterstitialLeftApplication_Public_Virtual_Final_New_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00018B58 File Offset: 0x00016D58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159876, XrefRangeEnd = 159880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_OnInterstitialLeftApplication(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_remove_OnInterstitialLeftApplication_Public_Virtual_Final_New_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00018B9C File Offset: 0x00016D9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159880, XrefRangeEnd = 159884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void add_OnAdInAppRequest(Action<string> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_add_OnAdInAppRequest_Public_Virtual_Final_New_add_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00018BE0 File Offset: 0x00016DE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159884, XrefRangeEnd = 159888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void remove_OnAdInAppRequest(Action<string> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_remove_OnAdInAppRequest_Public_Virtual_Final_New_rem_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00018C24 File Offset: 0x00016E24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159888, XrefRangeEnd = 159893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00018C58 File Offset: 0x00016E58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159893, XrefRangeEnd = 159930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnApplicationPause(bool pauseStatus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pauseStatus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00018C98 File Offset: 0x00016E98
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 159950, RefRangeEnd = 159953, XrefRangeStart = 159930, XrefRangeEnd = 159950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Init(string ad_unit_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ad_unit_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00018CDC File Offset: 0x00016EDC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159953, XrefRangeEnd = 159961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Init(string banners_unit_id, string interstisial_unit_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(banners_unit_id);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(interstisial_unit_id);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00018D30 File Offset: 0x00016F30
	[CallerCount(0)]
	public unsafe virtual void InitEditorTesting(bool isTestingEnabled, int editorFillRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isTestingEnabled;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref editorFillRate;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_InitEditorTesting_Public_Virtual_Final_New_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00018D7C File Offset: 0x00016F7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159961, XrefRangeEnd = 159967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetBannersUnitID(string ad_unit_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ad_unit_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_SetBannersUnitID_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00018DC0 File Offset: 0x00016FC0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 159973, RefRangeEnd = 159974, XrefRangeStart = 159967, XrefRangeEnd = 159973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetInterstisialsUnitID(string ad_unit_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ad_unit_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_SetInterstisialsUnitID_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00018E04 File Offset: 0x00017004
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 159980, RefRangeEnd = 159981, XrefRangeStart = 159974, XrefRangeEnd = 159980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetRewardedVideoAdUnitID(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_SetRewardedVideoAdUnitID_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00018E48 File Offset: 0x00017048
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159981, XrefRangeEnd = 159989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddKeyword(string keyword)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_AddKeyword_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00018E8C File Offset: 0x0001708C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159989, XrefRangeEnd = 160007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetBirthday(int year, AndroidMonth month, int day)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref year;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_SetBirthday_Public_Virtual_Final_New_Void_Int32_AndroidMonth_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00018EE8 File Offset: 0x000170E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160007, XrefRangeEnd = 160023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void TagForChildDirectedTreatment(bool tagForChildDirectedTreatment)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref tagForChildDirectedTreatment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_TagForChildDirectedTreatment_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00018F28 File Offset: 0x00017128
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160023, XrefRangeEnd = 160031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddTestDevice(string deviceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deviceId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_AddTestDevice_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00018F6C File Offset: 0x0001716C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160031, XrefRangeEnd = 160042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void AddTestDevices([Optional] Il2CppStringArray ids)
	{
		if (ids == null)
		{
			ids = new Il2CppStringArray(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_AddTestDevices_Public_Virtual_Final_New_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00018FBC File Offset: 0x000171BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160042, XrefRangeEnd = 160051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetGender(GoogleGender gender)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gender;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_SetGender_Public_Virtual_Final_New_Void_GoogleGender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00018FFC File Offset: 0x000171FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160051, XrefRangeEnd = 160064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual GoogleMobileAdBanner CreateAdBanner(TextAnchor anchor, GADBannerSize size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref anchor;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_CreateAdBanner_Public_Virtual_Final_New_GoogleMobileAdBanner_TextAnchor_GADBannerSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleMobileAdBanner>(intPtr3) : null;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00019058 File Offset: 0x00017258
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160064, XrefRangeEnd = 160077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual GoogleMobileAdBanner CreateAdBanner(int x, int y, GADBannerSize size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref x;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_CreateAdBanner_Public_Virtual_Final_New_GoogleMobileAdBanner_Int32_Int32_GADBannerSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleMobileAdBanner>(intPtr3) : null;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x000190C0 File Offset: 0x000172C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160077, XrefRangeEnd = 160084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void DestroyBanner(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_DestroyBanner_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00019100 File Offset: 0x00017300
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160084, XrefRangeEnd = 160111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void StartInterstitialAd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_StartInterstitialAd_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00019134 File Offset: 0x00017334
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160111, XrefRangeEnd = 160138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void LoadInterstitialAd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_LoadInterstitialAd_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00019168 File Offset: 0x00017368
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160138, XrefRangeEnd = 160153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleOnInterstitialLoadComplete_Editor(bool success)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref success;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_HandleOnInterstitialLoadComplete_Editor_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600007A RID: 122 RVA: 0x000191A8 File Offset: 0x000173A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160153, XrefRangeEnd = 160188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ShowInterstitialAd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_ShowInterstitialAd_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600007B RID: 123 RVA: 0x000191DC File Offset: 0x000173DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160188, XrefRangeEnd = 160209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleOnInterstitialFinished_Editor(bool isRewarded)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isRewarded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_HandleOnInterstitialFinished_Editor_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600007C RID: 124 RVA: 0x0001921C File Offset: 0x0001741C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160209, XrefRangeEnd = 160211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleOnInterstitialLeftApplication_Editor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_HandleOnInterstitialLeftApplication_Editor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00019250 File Offset: 0x00017450
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160211, XrefRangeEnd = 160244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void StartRewardedVideo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_StartRewardedVideo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00019284 File Offset: 0x00017484
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 160271, RefRangeEnd = 160272, XrefRangeStart = 160244, XrefRangeEnd = 160271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void LoadRewardedVideo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_LoadRewardedVideo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600007F RID: 127 RVA: 0x000192B8 File Offset: 0x000174B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160272, XrefRangeEnd = 160287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleOnVideoLoadComplete_Editor(bool success)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref success;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_HandleOnVideoLoadComplete_Editor_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000080 RID: 128 RVA: 0x000192F8 File Offset: 0x000174F8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 160322, RefRangeEnd = 160323, XrefRangeStart = 160287, XrefRangeEnd = 160322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ShowRewardedVideo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_ShowRewardedVideo_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000081 RID: 129 RVA: 0x0001932C File Offset: 0x0001752C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160323, XrefRangeEnd = 160344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleOnVideoFinished_Editor(bool isRewarded)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isRewarded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_HandleOnVideoFinished_Editor_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000082 RID: 130 RVA: 0x0001936C File Offset: 0x0001756C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160344, XrefRangeEnd = 160346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleOnVideoLeftApplication_Editor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_HandleOnVideoLeftApplication_Editor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000083 RID: 131 RVA: 0x000193A0 File Offset: 0x000175A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160346, XrefRangeEnd = 160353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RecordInAppResolution(GADInAppResolution resolution)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref resolution;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_RecordInAppResolution_Public_Virtual_Final_New_Void_GADInAppResolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000084 RID: 132 RVA: 0x000193E0 File Offset: 0x000175E0
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 160367, RefRangeEnd = 160372, XrefRangeStart = 160353, XrefRangeEnd = 160367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual GoogleMobileAdBanner GetBanner(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_GetBanner_Public_Virtual_Final_New_GoogleMobileAdBanner_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleMobileAdBanner>(intPtr3) : null;
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000085 RID: 133 RVA: 0x0001942C File Offset: 0x0001762C
	public unsafe virtual List<GoogleMobileAdBanner> banners
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160372, XrefRangeEnd = 160396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_get_banners_Public_Virtual_Final_New_get_List_1_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GoogleMobileAdBanner>>(intPtr3) : null;
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06000086 RID: 134 RVA: 0x0001946C File Offset: 0x0001766C
	public unsafe virtual bool IsInited
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_get_IsInited_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000087 RID: 135 RVA: 0x000194A8 File Offset: 0x000176A8
	public unsafe virtual string BannersUunitId
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_get_BannersUunitId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x06000088 RID: 136 RVA: 0x000194E0 File Offset: 0x000176E0
	public unsafe virtual string InterstisialUnitId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_get_InterstisialUnitId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000089 RID: 137 RVA: 0x00019518 File Offset: 0x00017718
	public unsafe virtual string RewardedVideoAdUnitId
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_get_RewardedVideoAdUnitId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x0600008A RID: 138 RVA: 0x00019550 File Offset: 0x00017750
	public unsafe bool IsEditorTestingEnabled
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160396, XrefRangeEnd = 160397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_get_IsEditorTestingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600008B RID: 139 RVA: 0x0001958C File Offset: 0x0001778C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160397, XrefRangeEnd = 160423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBannerAdLoaded(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_OnBannerAdLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600008C RID: 140 RVA: 0x000195D0 File Offset: 0x000177D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160423, XrefRangeEnd = 160433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBannerAdFailedToLoad(string bannerID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(bannerID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_OnBannerAdFailedToLoad_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00019614 File Offset: 0x00017814
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160433, XrefRangeEnd = 160443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBannerAdOpened(string bannerID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(bannerID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_OnBannerAdOpened_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00019658 File Offset: 0x00017858
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160443, XrefRangeEnd = 160453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBannerAdClosed(string bannerID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(bannerID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_OnBannerAdClosed_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600008F RID: 143 RVA: 0x0001969C File Offset: 0x0001789C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160453, XrefRangeEnd = 160463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBannerAdLeftApplication(string bannerID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(bannerID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_OnBannerAdLeftApplication_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000090 RID: 144 RVA: 0x000196E0 File Offset: 0x000178E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160463, XrefRangeEnd = 160465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInterstitialAdLoaded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_OnInterstitialAdLoaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00019714 File Offset: 0x00017914
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160465, XrefRangeEnd = 160470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInterstitialAdFailedToLoad(string errorCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(errorCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_OnInterstitialAdFailedToLoad_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00019758 File Offset: 0x00017958
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160470, XrefRangeEnd = 160472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInterstitialAdOpened()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_OnInterstitialAdOpened_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000093 RID: 147 RVA: 0x0001978C File Offset: 0x0001798C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160472, XrefRangeEnd = 160474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInterstitialAdClosed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_OnInterstitialAdClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000094 RID: 148 RVA: 0x000197C0 File Offset: 0x000179C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInterstitialAdLeftApplication()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_OnInterstitialAdLeftApplication_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000095 RID: 149 RVA: 0x000197F4 File Offset: 0x000179F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160474, XrefRangeEnd = 160495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RewardedCallback(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_RewardedCallback_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00019838 File Offset: 0x00017A38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160495, XrefRangeEnd = 160497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RewardedVideoAdClosed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_RewardedVideoAdClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000097 RID: 151 RVA: 0x0001986C File Offset: 0x00017A6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160497, XrefRangeEnd = 160502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RewardedVideoAdFailedToLoad(string errorCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(errorCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_RewardedVideoAdFailedToLoad_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000098 RID: 152 RVA: 0x000198B0 File Offset: 0x00017AB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RewardedVideoAdLeftApplication()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_RewardedVideoAdLeftApplication_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000099 RID: 153 RVA: 0x000198E4 File Offset: 0x00017AE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160502, XrefRangeEnd = 160504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RewardedVideoLoaded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_RewardedVideoLoaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00019918 File Offset: 0x00017B18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160504, XrefRangeEnd = 160506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RewardedVideoAdOpened()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_RewardedVideoAdOpened_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600009B RID: 155 RVA: 0x0001994C File Offset: 0x00017B4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160506, XrefRangeEnd = 160508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RewardedVideoStarted()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_RewardedVideoStarted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00019980 File Offset: 0x00017B80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160508, XrefRangeEnd = 160512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInAppPurchaseRequested(string productId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr_OnInAppPurchaseRequested_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600009D RID: 157 RVA: 0x000199C4 File Offset: 0x00017BC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160512, XrefRangeEnd = 160673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidAdMobController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600009E RID: 158 RVA: 0x000020FC File Offset: 0x000002FC
	public virtual void AddTestDevices(params string[] ids)
	{
		this.AddTestDevices(new Il2CppStringArray(ids));
	}

	// Token: 0x0600009F RID: 159 RVA: 0x0000210A File Offset: 0x0000030A
	public AndroidAdMobController(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x060000A0 RID: 160 RVA: 0x00019A00 File Offset: 0x00017C00
	// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002113 File Offset: 0x00000313
	public unsafe bool _IsInited
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr__IsInited);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr__IsInited)) = value;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x060000A2 RID: 162 RVA: 0x00019A28 File Offset: 0x00017C28
	// (set) Token: 0x060000A3 RID: 163 RVA: 0x0000212E File Offset: 0x0000032E
	public unsafe Dictionary<int, AndroidADBanner> _banners
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr__banners);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, AndroidADBanner>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr__banners), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x060000A4 RID: 164 RVA: 0x00019A58 File Offset: 0x00017C58
	// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000214D File Offset: 0x0000034D
	public unsafe bool _IsEditorTestingEnabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr__IsEditorTestingEnabled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr__IsEditorTestingEnabled)) = value;
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x060000A6 RID: 166 RVA: 0x00019A80 File Offset: 0x00017C80
	// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002168 File Offset: 0x00000368
	public unsafe int _EditorFillRate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr__EditorFillRate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr__EditorFillRate)) = value;
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x060000A8 RID: 168 RVA: 0x00019AA8 File Offset: 0x00017CA8
	// (set) Token: 0x060000A9 RID: 169 RVA: 0x00002183 File Offset: 0x00000383
	public unsafe string _BannersUunitId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr__BannersUunitId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr__BannersUunitId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x060000AA RID: 170 RVA: 0x00019AD0 File Offset: 0x00017CD0
	// (set) Token: 0x060000AB RID: 171 RVA: 0x000021A2 File Offset: 0x000003A2
	public unsafe string _InterstisialUnitId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr__InterstisialUnitId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr__InterstisialUnitId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x060000AC RID: 172 RVA: 0x00019AF8 File Offset: 0x00017CF8
	// (set) Token: 0x060000AD RID: 173 RVA: 0x000021C1 File Offset: 0x000003C1
	public unsafe string _RewardedVideoAdUnitId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr__RewardedVideoAdUnitId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr__RewardedVideoAdUnitId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x060000AE RID: 174 RVA: 0x00019B20 File Offset: 0x00017D20
	// (set) Token: 0x060000AF RID: 175 RVA: 0x000021E0 File Offset: 0x000003E0
	public unsafe Action<string, int> OnRewarded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnRewarded);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, int>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnRewarded), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x060000B0 RID: 176 RVA: 0x00019B50 File Offset: 0x00017D50
	// (set) Token: 0x060000B1 RID: 177 RVA: 0x000021FF File Offset: 0x000003FF
	public unsafe Action OnRewardedVideoAdClosed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnRewardedVideoAdClosed);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnRewardedVideoAdClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x060000B2 RID: 178 RVA: 0x00019B80 File Offset: 0x00017D80
	// (set) Token: 0x060000B3 RID: 179 RVA: 0x0000221E File Offset: 0x0000041E
	public unsafe Action<int> OnRewardedVideoAdFailedToLoad
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnRewardedVideoAdFailedToLoad);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnRewardedVideoAdFailedToLoad), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x060000B4 RID: 180 RVA: 0x00019BB0 File Offset: 0x00017DB0
	// (set) Token: 0x060000B5 RID: 181 RVA: 0x0000223D File Offset: 0x0000043D
	public unsafe Action OnRewardedVideoAdLeftApplication
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnRewardedVideoAdLeftApplication);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnRewardedVideoAdLeftApplication), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x060000B6 RID: 182 RVA: 0x00019BE0 File Offset: 0x00017DE0
	// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000225C File Offset: 0x0000045C
	public unsafe Action OnRewardedVideoLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnRewardedVideoLoaded);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnRewardedVideoLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x060000B8 RID: 184 RVA: 0x00019C10 File Offset: 0x00017E10
	// (set) Token: 0x060000B9 RID: 185 RVA: 0x0000227B File Offset: 0x0000047B
	public unsafe Action OnRewardedVideoAdOpened
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnRewardedVideoAdOpened);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnRewardedVideoAdOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x060000BA RID: 186 RVA: 0x00019C40 File Offset: 0x00017E40
	// (set) Token: 0x060000BB RID: 187 RVA: 0x0000229A File Offset: 0x0000049A
	public unsafe Action OnRewardedVideoStarted
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnRewardedVideoStarted);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnRewardedVideoStarted), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x060000BC RID: 188 RVA: 0x00019C70 File Offset: 0x00017E70
	// (set) Token: 0x060000BD RID: 189 RVA: 0x000022B9 File Offset: 0x000004B9
	public unsafe Action OnInterstitialLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnInterstitialLoaded);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnInterstitialLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x060000BE RID: 190 RVA: 0x00019CA0 File Offset: 0x00017EA0
	// (set) Token: 0x060000BF RID: 191 RVA: 0x000022D8 File Offset: 0x000004D8
	public unsafe Action<int> OnInterstitialFailedLoading
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnInterstitialFailedLoading);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnInterstitialFailedLoading), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x060000C0 RID: 192 RVA: 0x00019CD0 File Offset: 0x00017ED0
	// (set) Token: 0x060000C1 RID: 193 RVA: 0x000022F7 File Offset: 0x000004F7
	public unsafe Action OnInterstitialOpened
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnInterstitialOpened);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnInterstitialOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x060000C2 RID: 194 RVA: 0x00019D00 File Offset: 0x00017F00
	// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002316 File Offset: 0x00000516
	public unsafe Action OnInterstitialClosed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnInterstitialClosed);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnInterstitialClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x060000C4 RID: 196 RVA: 0x00019D30 File Offset: 0x00017F30
	// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002335 File Offset: 0x00000535
	public unsafe Action OnInterstitialLeftApplication
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnInterstitialLeftApplication);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnInterstitialLeftApplication), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x060000C6 RID: 198 RVA: 0x00019D60 File Offset: 0x00017F60
	// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002354 File Offset: 0x00000554
	public unsafe Action<string> OnAdInAppRequest
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnAdInAppRequest);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr_OnAdInAppRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x060000C8 RID: 200 RVA: 0x00019D90 File Offset: 0x00017F90
	// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002373 File Offset: 0x00000573
	public unsafe static string DEVICES_SEPARATOR
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidAdMobController.NativeFieldInfoPtr_DEVICES_SEPARATOR, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidAdMobController.NativeFieldInfoPtr_DEVICES_SEPARATOR, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x060000CA RID: 202 RVA: 0x00019DB0 File Offset: 0x00017FB0
	// (set) Token: 0x060000CB RID: 203 RVA: 0x00002385 File Offset: 0x00000585
	public unsafe bool _InterstitialShowOnLoad
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr__InterstitialShowOnLoad);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr__InterstitialShowOnLoad)) = value;
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x060000CC RID: 204 RVA: 0x00019DD8 File Offset: 0x00017FD8
	// (set) Token: 0x060000CD RID: 205 RVA: 0x000023A0 File Offset: 0x000005A0
	public unsafe bool _RewardedVideoShowOnLoad
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr__RewardedVideoShowOnLoad);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobController.NativeFieldInfoPtr__RewardedVideoShowOnLoad)) = value;
		}
	}

	// Token: 0x0400004A RID: 74
	private static readonly IntPtr NativeFieldInfoPtr__IsInited;

	// Token: 0x0400004B RID: 75
	private static readonly IntPtr NativeFieldInfoPtr__banners;

	// Token: 0x0400004C RID: 76
	private static readonly IntPtr NativeFieldInfoPtr__IsEditorTestingEnabled;

	// Token: 0x0400004D RID: 77
	private static readonly IntPtr NativeFieldInfoPtr__EditorFillRate;

	// Token: 0x0400004E RID: 78
	private static readonly IntPtr NativeFieldInfoPtr__BannersUunitId;

	// Token: 0x0400004F RID: 79
	private static readonly IntPtr NativeFieldInfoPtr__InterstisialUnitId;

	// Token: 0x04000050 RID: 80
	private static readonly IntPtr NativeFieldInfoPtr__RewardedVideoAdUnitId;

	// Token: 0x04000051 RID: 81
	private static readonly IntPtr NativeFieldInfoPtr_OnRewarded;

	// Token: 0x04000052 RID: 82
	private static readonly IntPtr NativeFieldInfoPtr_OnRewardedVideoAdClosed;

	// Token: 0x04000053 RID: 83
	private static readonly IntPtr NativeFieldInfoPtr_OnRewardedVideoAdFailedToLoad;

	// Token: 0x04000054 RID: 84
	private static readonly IntPtr NativeFieldInfoPtr_OnRewardedVideoAdLeftApplication;

	// Token: 0x04000055 RID: 85
	private static readonly IntPtr NativeFieldInfoPtr_OnRewardedVideoLoaded;

	// Token: 0x04000056 RID: 86
	private static readonly IntPtr NativeFieldInfoPtr_OnRewardedVideoAdOpened;

	// Token: 0x04000057 RID: 87
	private static readonly IntPtr NativeFieldInfoPtr_OnRewardedVideoStarted;

	// Token: 0x04000058 RID: 88
	private static readonly IntPtr NativeFieldInfoPtr_OnInterstitialLoaded;

	// Token: 0x04000059 RID: 89
	private static readonly IntPtr NativeFieldInfoPtr_OnInterstitialFailedLoading;

	// Token: 0x0400005A RID: 90
	private static readonly IntPtr NativeFieldInfoPtr_OnInterstitialOpened;

	// Token: 0x0400005B RID: 91
	private static readonly IntPtr NativeFieldInfoPtr_OnInterstitialClosed;

	// Token: 0x0400005C RID: 92
	private static readonly IntPtr NativeFieldInfoPtr_OnInterstitialLeftApplication;

	// Token: 0x0400005D RID: 93
	private static readonly IntPtr NativeFieldInfoPtr_OnAdInAppRequest;

	// Token: 0x0400005E RID: 94
	private static readonly IntPtr NativeFieldInfoPtr_DEVICES_SEPARATOR;

	// Token: 0x0400005F RID: 95
	private static readonly IntPtr NativeFieldInfoPtr__InterstitialShowOnLoad;

	// Token: 0x04000060 RID: 96
	private static readonly IntPtr NativeFieldInfoPtr__RewardedVideoShowOnLoad;

	// Token: 0x04000061 RID: 97
	private static readonly IntPtr NativeMethodInfoPtr_add_OnRewarded_Public_Virtual_Final_New_add_Void_Action_2_String_Int32_0;

	// Token: 0x04000062 RID: 98
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnRewarded_Public_Virtual_Final_New_rem_Void_Action_2_String_Int32_0;

	// Token: 0x04000063 RID: 99
	private static readonly IntPtr NativeMethodInfoPtr_add_OnRewardedVideoAdClosed_Public_Virtual_Final_New_add_Void_Action_0;

	// Token: 0x04000064 RID: 100
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnRewardedVideoAdClosed_Public_Virtual_Final_New_rem_Void_Action_0;

	// Token: 0x04000065 RID: 101
	private static readonly IntPtr NativeMethodInfoPtr_add_OnRewardedVideoAdFailedToLoad_Public_Virtual_Final_New_add_Void_Action_1_Int32_0;

	// Token: 0x04000066 RID: 102
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnRewardedVideoAdFailedToLoad_Public_Virtual_Final_New_rem_Void_Action_1_Int32_0;

	// Token: 0x04000067 RID: 103
	private static readonly IntPtr NativeMethodInfoPtr_add_OnRewardedVideoAdLeftApplication_Public_Virtual_Final_New_add_Void_Action_0;

	// Token: 0x04000068 RID: 104
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnRewardedVideoAdLeftApplication_Public_Virtual_Final_New_rem_Void_Action_0;

	// Token: 0x04000069 RID: 105
	private static readonly IntPtr NativeMethodInfoPtr_add_OnRewardedVideoLoaded_Public_Virtual_Final_New_add_Void_Action_0;

	// Token: 0x0400006A RID: 106
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnRewardedVideoLoaded_Public_Virtual_Final_New_rem_Void_Action_0;

	// Token: 0x0400006B RID: 107
	private static readonly IntPtr NativeMethodInfoPtr_add_OnRewardedVideoAdOpened_Public_Virtual_Final_New_add_Void_Action_0;

	// Token: 0x0400006C RID: 108
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnRewardedVideoAdOpened_Public_Virtual_Final_New_rem_Void_Action_0;

	// Token: 0x0400006D RID: 109
	private static readonly IntPtr NativeMethodInfoPtr_add_OnRewardedVideoStarted_Public_Virtual_Final_New_add_Void_Action_0;

	// Token: 0x0400006E RID: 110
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnRewardedVideoStarted_Public_Virtual_Final_New_rem_Void_Action_0;

	// Token: 0x0400006F RID: 111
	private static readonly IntPtr NativeMethodInfoPtr_add_OnInterstitialLoaded_Public_Virtual_Final_New_add_Void_Action_0;

	// Token: 0x04000070 RID: 112
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnInterstitialLoaded_Public_Virtual_Final_New_rem_Void_Action_0;

	// Token: 0x04000071 RID: 113
	private static readonly IntPtr NativeMethodInfoPtr_add_OnInterstitialFailedLoading_Public_Virtual_Final_New_add_Void_Action_1_Int32_0;

	// Token: 0x04000072 RID: 114
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnInterstitialFailedLoading_Public_Virtual_Final_New_rem_Void_Action_1_Int32_0;

	// Token: 0x04000073 RID: 115
	private static readonly IntPtr NativeMethodInfoPtr_add_OnInterstitialOpened_Public_Virtual_Final_New_add_Void_Action_0;

	// Token: 0x04000074 RID: 116
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnInterstitialOpened_Public_Virtual_Final_New_rem_Void_Action_0;

	// Token: 0x04000075 RID: 117
	private static readonly IntPtr NativeMethodInfoPtr_add_OnInterstitialClosed_Public_Virtual_Final_New_add_Void_Action_0;

	// Token: 0x04000076 RID: 118
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnInterstitialClosed_Public_Virtual_Final_New_rem_Void_Action_0;

	// Token: 0x04000077 RID: 119
	private static readonly IntPtr NativeMethodInfoPtr_add_OnInterstitialLeftApplication_Public_Virtual_Final_New_add_Void_Action_0;

	// Token: 0x04000078 RID: 120
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnInterstitialLeftApplication_Public_Virtual_Final_New_rem_Void_Action_0;

	// Token: 0x04000079 RID: 121
	private static readonly IntPtr NativeMethodInfoPtr_add_OnAdInAppRequest_Public_Virtual_Final_New_add_Void_Action_1_String_0;

	// Token: 0x0400007A RID: 122
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnAdInAppRequest_Public_Virtual_Final_New_rem_Void_Action_1_String_0;

	// Token: 0x0400007B RID: 123
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x0400007C RID: 124
	private static readonly IntPtr NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0;

	// Token: 0x0400007D RID: 125
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_String_0;

	// Token: 0x0400007E RID: 126
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_String_String_0;

	// Token: 0x0400007F RID: 127
	private static readonly IntPtr NativeMethodInfoPtr_InitEditorTesting_Public_Virtual_Final_New_Void_Boolean_Int32_0;

	// Token: 0x04000080 RID: 128
	private static readonly IntPtr NativeMethodInfoPtr_SetBannersUnitID_Public_Virtual_Final_New_Void_String_0;

	// Token: 0x04000081 RID: 129
	private static readonly IntPtr NativeMethodInfoPtr_SetInterstisialsUnitID_Public_Virtual_Final_New_Void_String_0;

	// Token: 0x04000082 RID: 130
	private static readonly IntPtr NativeMethodInfoPtr_SetRewardedVideoAdUnitID_Public_Virtual_Final_New_Void_String_0;

	// Token: 0x04000083 RID: 131
	private static readonly IntPtr NativeMethodInfoPtr_AddKeyword_Public_Virtual_Final_New_Void_String_0;

	// Token: 0x04000084 RID: 132
	private static readonly IntPtr NativeMethodInfoPtr_SetBirthday_Public_Virtual_Final_New_Void_Int32_AndroidMonth_Int32_0;

	// Token: 0x04000085 RID: 133
	private static readonly IntPtr NativeMethodInfoPtr_TagForChildDirectedTreatment_Public_Virtual_Final_New_Void_Boolean_0;

	// Token: 0x04000086 RID: 134
	private static readonly IntPtr NativeMethodInfoPtr_AddTestDevice_Public_Virtual_Final_New_Void_String_0;

	// Token: 0x04000087 RID: 135
	private static readonly IntPtr NativeMethodInfoPtr_AddTestDevices_Public_Virtual_Final_New_Void_Il2CppStringArray_0;

	// Token: 0x04000088 RID: 136
	private static readonly IntPtr NativeMethodInfoPtr_SetGender_Public_Virtual_Final_New_Void_GoogleGender_0;

	// Token: 0x04000089 RID: 137
	private static readonly IntPtr NativeMethodInfoPtr_CreateAdBanner_Public_Virtual_Final_New_GoogleMobileAdBanner_TextAnchor_GADBannerSize_0;

	// Token: 0x0400008A RID: 138
	private static readonly IntPtr NativeMethodInfoPtr_CreateAdBanner_Public_Virtual_Final_New_GoogleMobileAdBanner_Int32_Int32_GADBannerSize_0;

	// Token: 0x0400008B RID: 139
	private static readonly IntPtr NativeMethodInfoPtr_DestroyBanner_Public_Virtual_Final_New_Void_Int32_0;

	// Token: 0x0400008C RID: 140
	private static readonly IntPtr NativeMethodInfoPtr_StartInterstitialAd_Public_Virtual_Final_New_Void_0;

	// Token: 0x0400008D RID: 141
	private static readonly IntPtr NativeMethodInfoPtr_LoadInterstitialAd_Public_Virtual_Final_New_Void_0;

	// Token: 0x0400008E RID: 142
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnInterstitialLoadComplete_Editor_Private_Void_Boolean_0;

	// Token: 0x0400008F RID: 143
	private static readonly IntPtr NativeMethodInfoPtr_ShowInterstitialAd_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000090 RID: 144
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnInterstitialFinished_Editor_Private_Void_Boolean_0;

	// Token: 0x04000091 RID: 145
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnInterstitialLeftApplication_Editor_Private_Void_0;

	// Token: 0x04000092 RID: 146
	private static readonly IntPtr NativeMethodInfoPtr_StartRewardedVideo_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000093 RID: 147
	private static readonly IntPtr NativeMethodInfoPtr_LoadRewardedVideo_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000094 RID: 148
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnVideoLoadComplete_Editor_Private_Void_Boolean_0;

	// Token: 0x04000095 RID: 149
	private static readonly IntPtr NativeMethodInfoPtr_ShowRewardedVideo_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000096 RID: 150
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnVideoFinished_Editor_Private_Void_Boolean_0;

	// Token: 0x04000097 RID: 151
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnVideoLeftApplication_Editor_Private_Void_0;

	// Token: 0x04000098 RID: 152
	private static readonly IntPtr NativeMethodInfoPtr_RecordInAppResolution_Public_Virtual_Final_New_Void_GADInAppResolution_0;

	// Token: 0x04000099 RID: 153
	private static readonly IntPtr NativeMethodInfoPtr_GetBanner_Public_Virtual_Final_New_GoogleMobileAdBanner_Int32_0;

	// Token: 0x0400009A RID: 154
	private static readonly IntPtr NativeMethodInfoPtr_get_banners_Public_Virtual_Final_New_get_List_1_GoogleMobileAdBanner_0;

	// Token: 0x0400009B RID: 155
	private static readonly IntPtr NativeMethodInfoPtr_get_IsInited_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x0400009C RID: 156
	private static readonly IntPtr NativeMethodInfoPtr_get_BannersUunitId_Public_Virtual_Final_New_get_String_0;

	// Token: 0x0400009D RID: 157
	private static readonly IntPtr NativeMethodInfoPtr_get_InterstisialUnitId_Public_Virtual_Final_New_get_String_0;

	// Token: 0x0400009E RID: 158
	private static readonly IntPtr NativeMethodInfoPtr_get_RewardedVideoAdUnitId_Public_Virtual_Final_New_get_String_0;

	// Token: 0x0400009F RID: 159
	private static readonly IntPtr NativeMethodInfoPtr_get_IsEditorTestingEnabled_Public_get_Boolean_0;

	// Token: 0x040000A0 RID: 160
	private static readonly IntPtr NativeMethodInfoPtr_OnBannerAdLoaded_Private_Void_String_0;

	// Token: 0x040000A1 RID: 161
	private static readonly IntPtr NativeMethodInfoPtr_OnBannerAdFailedToLoad_Private_Void_String_0;

	// Token: 0x040000A2 RID: 162
	private static readonly IntPtr NativeMethodInfoPtr_OnBannerAdOpened_Private_Void_String_0;

	// Token: 0x040000A3 RID: 163
	private static readonly IntPtr NativeMethodInfoPtr_OnBannerAdClosed_Private_Void_String_0;

	// Token: 0x040000A4 RID: 164
	private static readonly IntPtr NativeMethodInfoPtr_OnBannerAdLeftApplication_Private_Void_String_0;

	// Token: 0x040000A5 RID: 165
	private static readonly IntPtr NativeMethodInfoPtr_OnInterstitialAdLoaded_Private_Void_0;

	// Token: 0x040000A6 RID: 166
	private static readonly IntPtr NativeMethodInfoPtr_OnInterstitialAdFailedToLoad_Private_Void_String_0;

	// Token: 0x040000A7 RID: 167
	private static readonly IntPtr NativeMethodInfoPtr_OnInterstitialAdOpened_Private_Void_0;

	// Token: 0x040000A8 RID: 168
	private static readonly IntPtr NativeMethodInfoPtr_OnInterstitialAdClosed_Private_Void_0;

	// Token: 0x040000A9 RID: 169
	private static readonly IntPtr NativeMethodInfoPtr_OnInterstitialAdLeftApplication_Private_Void_0;

	// Token: 0x040000AA RID: 170
	private static readonly IntPtr NativeMethodInfoPtr_RewardedCallback_Private_Void_String_0;

	// Token: 0x040000AB RID: 171
	private static readonly IntPtr NativeMethodInfoPtr_RewardedVideoAdClosed_Private_Void_0;

	// Token: 0x040000AC RID: 172
	private static readonly IntPtr NativeMethodInfoPtr_RewardedVideoAdFailedToLoad_Private_Void_String_0;

	// Token: 0x040000AD RID: 173
	private static readonly IntPtr NativeMethodInfoPtr_RewardedVideoAdLeftApplication_Private_Void_0;

	// Token: 0x040000AE RID: 174
	private static readonly IntPtr NativeMethodInfoPtr_RewardedVideoLoaded_Private_Void_0;

	// Token: 0x040000AF RID: 175
	private static readonly IntPtr NativeMethodInfoPtr_RewardedVideoAdOpened_Private_Void_0;

	// Token: 0x040000B0 RID: 176
	private static readonly IntPtr NativeMethodInfoPtr_RewardedVideoStarted_Private_Void_0;

	// Token: 0x040000B1 RID: 177
	private static readonly IntPtr NativeMethodInfoPtr_OnInAppPurchaseRequested_Private_Void_String_0;

	// Token: 0x040000B2 RID: 178
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000363 RID: 867
	[ObfuscatedName("AndroidAdMobController+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x060033EC RID: 13292 RVA: 0x000D7590 File Offset: 0x000D5790
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidAdMobController>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr);
			AndroidAdMobController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, "<>9");
			AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, "<>9__110_0");
			AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, "<>9__110_1");
			AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, "<>9__110_2");
			AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, "<>9__110_3");
			AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, "<>9__110_4");
			AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, "<>9__110_5");
			AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, "<>9__110_6");
			AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, "<>9__110_7");
			AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, "<>9__110_8");
			AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, "<>9__110_9");
			AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, "<>9__110_10");
			AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, "<>9__110_11");
			AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, "<>9__110_12");
			AndroidAdMobController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, 100669917);
			AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_0_Internal_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, 100669918);
			AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, 100669919);
			AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_2_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, 100669920);
			AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, 100669921);
			AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, 100669922);
			AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, 100669923);
			AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, 100669924);
			AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, 100669925);
			AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_8_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, 100669926);
			AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_9_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, 100669927);
			AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_10_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, 100669928);
			AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_11_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, 100669929);
			AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_12_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr, 100669930);
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x000D77EC File Offset: 0x000D59EC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidAdMobController.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x000D7828 File Offset: 0x000D5A28
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__110_0(string <p0>, int <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref <p1>;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_0_Internal_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033EF RID: 13295 RVA: 0x000D7878 File Offset: 0x000D5A78
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__110_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x000D78AC File Offset: 0x000D5AAC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__110_2(int <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_2_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x000D78EC File Offset: 0x000D5AEC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__110_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x000D7920 File Offset: 0x000D5B20
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__110_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x000D7954 File Offset: 0x000D5B54
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__110_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x000D7988 File Offset: 0x000D5B88
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__110_6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x000D79BC File Offset: 0x000D5BBC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__110_7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x000D79F0 File Offset: 0x000D5BF0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__110_8(int <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_8_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x000D7A30 File Offset: 0x000D5C30
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__110_9()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_9_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x000D7A64 File Offset: 0x000D5C64
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__110_10()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_10_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x000D7A98 File Offset: 0x000D5C98
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__110_11()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_11_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x000D7ACC File Offset: 0x000D5CCC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__110_12(string <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobController.__c.NativeMethodInfoPtr___ctor_b__110_12_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x000144C6 File Offset: 0x000126C6
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x060033FC RID: 13308 RVA: 0x000D7B10 File Offset: 0x000D5D10
		// (set) Token: 0x060033FD RID: 13309 RVA: 0x000144CF File Offset: 0x000126CF
		public unsafe static AndroidAdMobController.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidAdMobController.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x060033FE RID: 13310 RVA: 0x000D7B38 File Offset: 0x000D5D38
		// (set) Token: 0x060033FF RID: 13311 RVA: 0x000144E1 File Offset: 0x000126E1
		public unsafe static Action<string, int> __9__110_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06003400 RID: 13312 RVA: 0x000D7B60 File Offset: 0x000D5D60
		// (set) Token: 0x06003401 RID: 13313 RVA: 0x000144F3 File Offset: 0x000126F3
		public unsafe static Action __9__110_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06003402 RID: 13314 RVA: 0x000D7B88 File Offset: 0x000D5D88
		// (set) Token: 0x06003403 RID: 13315 RVA: 0x00014505 File Offset: 0x00012705
		public unsafe static Action<int> __9__110_2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06003404 RID: 13316 RVA: 0x000D7BB0 File Offset: 0x000D5DB0
		// (set) Token: 0x06003405 RID: 13317 RVA: 0x00014517 File Offset: 0x00012717
		public unsafe static Action __9__110_3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06003406 RID: 13318 RVA: 0x000D7BD8 File Offset: 0x000D5DD8
		// (set) Token: 0x06003407 RID: 13319 RVA: 0x00014529 File Offset: 0x00012729
		public unsafe static Action __9__110_4
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_4, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_4, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06003408 RID: 13320 RVA: 0x000D7C00 File Offset: 0x000D5E00
		// (set) Token: 0x06003409 RID: 13321 RVA: 0x0001453B File Offset: 0x0001273B
		public unsafe static Action __9__110_5
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_5, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_5, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x0600340A RID: 13322 RVA: 0x000D7C28 File Offset: 0x000D5E28
		// (set) Token: 0x0600340B RID: 13323 RVA: 0x0001454D File Offset: 0x0001274D
		public unsafe static Action __9__110_6
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_6, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_6, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x0600340C RID: 13324 RVA: 0x000D7C50 File Offset: 0x000D5E50
		// (set) Token: 0x0600340D RID: 13325 RVA: 0x0001455F File Offset: 0x0001275F
		public unsafe static Action __9__110_7
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_7, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_7, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x0600340E RID: 13326 RVA: 0x000D7C78 File Offset: 0x000D5E78
		// (set) Token: 0x0600340F RID: 13327 RVA: 0x00014571 File Offset: 0x00012771
		public unsafe static Action<int> __9__110_8
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_8, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_8, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06003410 RID: 13328 RVA: 0x000D7CA0 File Offset: 0x000D5EA0
		// (set) Token: 0x06003411 RID: 13329 RVA: 0x00014583 File Offset: 0x00012783
		public unsafe static Action __9__110_9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06003412 RID: 13330 RVA: 0x000D7CC8 File Offset: 0x000D5EC8
		// (set) Token: 0x06003413 RID: 13331 RVA: 0x00014595 File Offset: 0x00012795
		public unsafe static Action __9__110_10
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_10, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_10, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x06003414 RID: 13332 RVA: 0x000D7CF0 File Offset: 0x000D5EF0
		// (set) Token: 0x06003415 RID: 13333 RVA: 0x000145A7 File Offset: 0x000127A7
		public unsafe static Action __9__110_11
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_11, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_11, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x06003416 RID: 13334 RVA: 0x000D7D18 File Offset: 0x000D5F18
		// (set) Token: 0x06003417 RID: 13335 RVA: 0x000145B9 File Offset: 0x000127B9
		public unsafe static Action<string> __9__110_12
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_12, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidAdMobController.__c.NativeFieldInfoPtr___9__110_12, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400303A RID: 12346
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x0400303B RID: 12347
		private static readonly IntPtr NativeFieldInfoPtr___9__110_0;

		// Token: 0x0400303C RID: 12348
		private static readonly IntPtr NativeFieldInfoPtr___9__110_1;

		// Token: 0x0400303D RID: 12349
		private static readonly IntPtr NativeFieldInfoPtr___9__110_2;

		// Token: 0x0400303E RID: 12350
		private static readonly IntPtr NativeFieldInfoPtr___9__110_3;

		// Token: 0x0400303F RID: 12351
		private static readonly IntPtr NativeFieldInfoPtr___9__110_4;

		// Token: 0x04003040 RID: 12352
		private static readonly IntPtr NativeFieldInfoPtr___9__110_5;

		// Token: 0x04003041 RID: 12353
		private static readonly IntPtr NativeFieldInfoPtr___9__110_6;

		// Token: 0x04003042 RID: 12354
		private static readonly IntPtr NativeFieldInfoPtr___9__110_7;

		// Token: 0x04003043 RID: 12355
		private static readonly IntPtr NativeFieldInfoPtr___9__110_8;

		// Token: 0x04003044 RID: 12356
		private static readonly IntPtr NativeFieldInfoPtr___9__110_9;

		// Token: 0x04003045 RID: 12357
		private static readonly IntPtr NativeFieldInfoPtr___9__110_10;

		// Token: 0x04003046 RID: 12358
		private static readonly IntPtr NativeFieldInfoPtr___9__110_11;

		// Token: 0x04003047 RID: 12359
		private static readonly IntPtr NativeFieldInfoPtr___9__110_12;

		// Token: 0x04003048 RID: 12360
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003049 RID: 12361
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__110_0_Internal_Void_String_Int32_0;

		// Token: 0x0400304A RID: 12362
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__110_1_Internal_Void_0;

		// Token: 0x0400304B RID: 12363
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__110_2_Internal_Void_Int32_0;

		// Token: 0x0400304C RID: 12364
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__110_3_Internal_Void_0;

		// Token: 0x0400304D RID: 12365
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__110_4_Internal_Void_0;

		// Token: 0x0400304E RID: 12366
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__110_5_Internal_Void_0;

		// Token: 0x0400304F RID: 12367
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__110_6_Internal_Void_0;

		// Token: 0x04003050 RID: 12368
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__110_7_Internal_Void_0;

		// Token: 0x04003051 RID: 12369
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__110_8_Internal_Void_Int32_0;

		// Token: 0x04003052 RID: 12370
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__110_9_Internal_Void_0;

		// Token: 0x04003053 RID: 12371
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__110_10_Internal_Void_0;

		// Token: 0x04003054 RID: 12372
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__110_11_Internal_Void_0;

		// Token: 0x04003055 RID: 12373
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__110_12_Internal_Void_String_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SA.AndroidNative.DynamicLinks;
using UnityEngine;

// Token: 0x02000020 RID: 32
public class AndroidNativeSettings : ScriptableObject
{
	// Token: 0x060002C4 RID: 708 RVA: 0x000215E8 File Offset: 0x0001F7E8
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidNativeSettings()
	{
		Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidNativeSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr);
		AndroidNativeSettings.NativeFieldInfoPtr_VERSION_NUMBER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "VERSION_NUMBER");
		AndroidNativeSettings.NativeFieldInfoPtr_GOOGLE_PLAY_SDK_VERSION_NUMBER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "GOOGLE_PLAY_SDK_VERSION_NUMBER");
		AndroidNativeSettings.NativeFieldInfoPtr_GOOGLE_PLAY_SDK_LEAGCY_VERSION_NUMBER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "GOOGLE_PLAY_SDK_LEAGCY_VERSION_NUMBER");
		AndroidNativeSettings.NativeFieldInfoPtr_EnablePlusAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "EnablePlusAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_EnableGamesAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "EnableGamesAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_EnableAppInviteAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "EnableAppInviteAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_EnableDriveAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "EnableDriveAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_LoadProfileIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "LoadProfileIcons");
		AndroidNativeSettings.NativeFieldInfoPtr_LoadProfileImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "LoadProfileImages");
		AndroidNativeSettings.NativeFieldInfoPtr_LoadQuestsImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "LoadQuestsImages");
		AndroidNativeSettings.NativeFieldInfoPtr_LoadQuestsIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "LoadQuestsIcons");
		AndroidNativeSettings.NativeFieldInfoPtr_LoadEventsIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "LoadEventsIcons");
		AndroidNativeSettings.NativeFieldInfoPtr_ShowConnectingPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ShowConnectingPopup");
		AndroidNativeSettings.NativeFieldInfoPtr_AutoLoadLocalPlayerScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "AutoLoadLocalPlayerScore");
		AndroidNativeSettings.NativeFieldInfoPtr_GoogleFitEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "GoogleFitEnabled");
		AndroidNativeSettings.NativeFieldInfoPtr_EnableATCSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "EnableATCSupport");
		AndroidNativeSettings.NativeFieldInfoPtr_OneSignalEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "OneSignalEnabled");
		AndroidNativeSettings.NativeFieldInfoPtr_OneSignalAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "OneSignalAppID");
		AndroidNativeSettings.NativeFieldInfoPtr_OneSignalDownloadLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "OneSignalDownloadLink");
		AndroidNativeSettings.NativeFieldInfoPtr_OneSignalDocLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "OneSignalDocLink");
		AndroidNativeSettings.NativeFieldInfoPtr_UseParsePushNotifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "UseParsePushNotifications");
		AndroidNativeSettings.NativeFieldInfoPtr_ParseAppId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ParseAppId");
		AndroidNativeSettings.NativeFieldInfoPtr_DotNetKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "DotNetKey");
		AndroidNativeSettings.NativeFieldInfoPtr_ParseDocLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ParseDocLink");
		AndroidNativeSettings.NativeFieldInfoPtr_ParseDownloadLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ParseDownloadLink");
		AndroidNativeSettings.NativeFieldInfoPtr_DialogTheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "DialogTheme");
		AndroidNativeSettings.NativeFieldInfoPtr_EnableSoomla = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "EnableSoomla");
		AndroidNativeSettings.NativeFieldInfoPtr_SoomlaDownloadLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "SoomlaDownloadLink");
		AndroidNativeSettings.NativeFieldInfoPtr_SoomlaDocsLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "SoomlaDocsLink");
		AndroidNativeSettings.NativeFieldInfoPtr_SoomlaGameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "SoomlaGameKey");
		AndroidNativeSettings.NativeFieldInfoPtr_SoomlaEnvKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "SoomlaEnvKey");
		AndroidNativeSettings.NativeFieldInfoPtr_Ad_EditorFillRateIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "Ad_EditorFillRateIndex");
		AndroidNativeSettings.NativeFieldInfoPtr_Ad_EditorFillRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "Ad_EditorFillRate");
		AndroidNativeSettings.NativeFieldInfoPtr_Is_Ad_EditorTestingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "Is_Ad_EditorTestingEnabled");
		AndroidNativeSettings.NativeFieldInfoPtr_InApps_EditorFillRateIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "InApps_EditorFillRateIndex");
		AndroidNativeSettings.NativeFieldInfoPtr_InApps_EditorFillRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "InApps_EditorFillRate");
		AndroidNativeSettings.NativeFieldInfoPtr_Is_InApps_EditorTestingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "Is_InApps_EditorTestingEnabled");
		AndroidNativeSettings.NativeFieldInfoPtr_Is_Leaderboards_Editor_Notifications_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "Is_Leaderboards_Editor_Notifications_Enabled");
		AndroidNativeSettings.NativeFieldInfoPtr_Is_Achievements_Editor_Notifications_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "Is_Achievements_Editor_Notifications_Enabled");
		AndroidNativeSettings.NativeFieldInfoPtr_GCM_SenderId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "GCM_SenderId");
		AndroidNativeSettings.NativeFieldInfoPtr_PushService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "PushService");
		AndroidNativeSettings.NativeFieldInfoPtr_SaveCameraImageToGallery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "SaveCameraImageToGallery");
		AndroidNativeSettings.NativeFieldInfoPtr_UseProductNameAsFolderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "UseProductNameAsFolderName");
		AndroidNativeSettings.NativeFieldInfoPtr_GalleryFolderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "GalleryFolderName");
		AndroidNativeSettings.NativeFieldInfoPtr_MaxImageLoadSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "MaxImageLoadSize");
		AndroidNativeSettings.NativeFieldInfoPtr_CameraCaptureMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "CameraCaptureMode");
		AndroidNativeSettings.NativeFieldInfoPtr_ImageFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ImageFormat");
		AndroidNativeSettings.NativeFieldInfoPtr_ShowAppPermissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ShowAppPermissions");
		AndroidNativeSettings.NativeFieldInfoPtr_EnableBillingAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "EnableBillingAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_EnablePSAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "EnablePSAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_EnableSocialAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "EnableSocialAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_EnableCameraAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "EnableCameraAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_ExpandNativeAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ExpandNativeAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_ExpandPSAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ExpandPSAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_ExpandBillingAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ExpandBillingAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_ExpandSocialAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ExpandSocialAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_ExpandCameraAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ExpandCameraAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_ThirdPartyParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ThirdPartyParams");
		AndroidNativeSettings.NativeFieldInfoPtr_ShowPSSettingsResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ShowPSSettingsResources");
		AndroidNativeSettings.NativeFieldInfoPtr_ShowActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ShowActions");
		AndroidNativeSettings.NativeFieldInfoPtr_GCMSettingsActinve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "GCMSettingsActinve");
		AndroidNativeSettings.NativeFieldInfoPtr_LocalNotificationsAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "LocalNotificationsAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_ImmersiveModeAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ImmersiveModeAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_ApplicationInformationAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ApplicationInformationAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_ExternalAppsAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ExternalAppsAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_PoupsandPreloadersAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "PoupsandPreloadersAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_CheckAppLicenseAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "CheckAppLicenseAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_NetworkStateAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "NetworkStateAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_FirebaseAnalytics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "FirebaseAnalytics");
		AndroidNativeSettings.NativeFieldInfoPtr_FirebaseDynamicLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "FirebaseDynamicLinks");
		AndroidNativeSettings.NativeFieldInfoPtr_FirebaseAppId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "FirebaseAppId");
		AndroidNativeSettings.NativeFieldInfoPtr_FirebaseApiKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "FirebaseApiKey");
		AndroidNativeSettings.NativeFieldInfoPtr_DynamicLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "DynamicLinks");
		AndroidNativeSettings.NativeFieldInfoPtr_InAppPurchasesAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "InAppPurchasesAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_GooglePlayServicesAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "GooglePlayServicesAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_PlayServicesAdvancedSignInAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "PlayServicesAdvancedSignInAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_GoogleButtonAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "GoogleButtonAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_AnalyticsAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "AnalyticsAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_GoogleCloudSaveAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "GoogleCloudSaveAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_PushNotificationsAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "PushNotificationsAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_GoogleMobileAdAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "GoogleMobileAdAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_GoogleOAuthAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "GoogleOAuthAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_GalleryAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "GalleryAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_CameraAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "CameraAPI");
		AndroidNativeSettings.NativeFieldInfoPtr_KeepManifestClean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "KeepManifestClean");
		AndroidNativeSettings.NativeFieldInfoPtr_GooglePlayServiceAppID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "GooglePlayServiceAppID");
		AndroidNativeSettings.NativeFieldInfoPtr_ToolbarSelectedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ToolbarSelectedIndex");
		AndroidNativeSettings.NativeFieldInfoPtr_base64EncodedPublicKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "base64EncodedPublicKey");
		AndroidNativeSettings.NativeFieldInfoPtr_ShowStoreProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ShowStoreProducts");
		AndroidNativeSettings.NativeFieldInfoPtr_InAppProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "InAppProducts");
		AndroidNativeSettings.NativeFieldInfoPtr_ShowLeaderboards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ShowLeaderboards");
		AndroidNativeSettings.NativeFieldInfoPtr_Leaderboards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "Leaderboards");
		AndroidNativeSettings.NativeFieldInfoPtr_ShowAchievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ShowAchievements");
		AndroidNativeSettings.NativeFieldInfoPtr_Achievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "Achievements");
		AndroidNativeSettings.NativeFieldInfoPtr_ShowWhenAppIsForeground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ShowWhenAppIsForeground");
		AndroidNativeSettings.NativeFieldInfoPtr_EnableVibrationLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "EnableVibrationLocal");
		AndroidNativeSettings.NativeFieldInfoPtr_LocalNotificationSmallIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "LocalNotificationSmallIcon");
		AndroidNativeSettings.NativeFieldInfoPtr_LocalNotificationLargeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "LocalNotificationLargeIcon");
		AndroidNativeSettings.NativeFieldInfoPtr_LocalNotificationSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "LocalNotificationSound");
		AndroidNativeSettings.NativeFieldInfoPtr_LocalNotificationWakeLockTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "LocalNotificationWakeLockTimer");
		AndroidNativeSettings.NativeFieldInfoPtr_ReplaceOldNotificationWithNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ReplaceOldNotificationWithNew");
		AndroidNativeSettings.NativeFieldInfoPtr_ShowPushWhenAppIsForeground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ShowPushWhenAppIsForeground");
		AndroidNativeSettings.NativeFieldInfoPtr_EnableVibrationPush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "EnableVibrationPush");
		AndroidNativeSettings.NativeFieldInfoPtr_PushNotificationColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "PushNotificationColor");
		AndroidNativeSettings.NativeFieldInfoPtr_PushNotificationSmallIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "PushNotificationSmallIcon");
		AndroidNativeSettings.NativeFieldInfoPtr_PushNotificationLargeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "PushNotificationLargeIcon");
		AndroidNativeSettings.NativeFieldInfoPtr_PushNotificationSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "PushNotificationSound");
		AndroidNativeSettings.NativeFieldInfoPtr_ANSettingsAssetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ANSettingsAssetName");
		AndroidNativeSettings.NativeFieldInfoPtr_ANSettingsAssetExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "ANSettingsAssetExtension");
		AndroidNativeSettings.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, "instance");
		AndroidNativeSettings.NativeMethodInfoPtr_get_Instance_Public_Static_get_AndroidNativeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, 100663708);
		AndroidNativeSettings.NativeMethodInfoPtr_get_IsBase64KeyWasReplaced_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, 100663709);
		AndroidNativeSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr, 100663710);
	}

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x060002C5 RID: 709 RVA: 0x00021EEC File Offset: 0x000200EC
	public unsafe static AndroidNativeSettings Instance
	{
		[CallerCount(102)]
		[CachedScanResults(RefRangeStart = 162496, RefRangeEnd = 162598, XrefRangeStart = 162467, XrefRangeEnd = 162496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeSettings.NativeMethodInfoPtr_get_Instance_Public_Static_get_AndroidNativeSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidNativeSettings>(intPtr3) : null;
		}
	}

	// Token: 0x1700013F RID: 319
	// (get) Token: 0x060002C6 RID: 710 RVA: 0x00021F20 File Offset: 0x00020120
	public unsafe bool IsBase64KeyWasReplaced
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 162604, RefRangeEnd = 162608, XrefRangeStart = 162598, XrefRangeEnd = 162604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeSettings.NativeMethodInfoPtr_get_IsBase64KeyWasReplaced_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x00021F5C File Offset: 0x0002015C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162608, XrefRangeEnd = 162665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidNativeSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidNativeSettings>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x00002DB4 File Offset: 0x00000FB4
	public AndroidNativeSettings(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x060002C9 RID: 713 RVA: 0x00021F98 File Offset: 0x00020198
	// (set) Token: 0x060002CA RID: 714 RVA: 0x00002DBD File Offset: 0x00000FBD
	public unsafe static string VERSION_NUMBER
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNativeSettings.NativeFieldInfoPtr_VERSION_NUMBER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNativeSettings.NativeFieldInfoPtr_VERSION_NUMBER, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x060002CB RID: 715 RVA: 0x00021FB8 File Offset: 0x000201B8
	// (set) Token: 0x060002CC RID: 716 RVA: 0x00002DCF File Offset: 0x00000FCF
	public unsafe static string GOOGLE_PLAY_SDK_VERSION_NUMBER
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNativeSettings.NativeFieldInfoPtr_GOOGLE_PLAY_SDK_VERSION_NUMBER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNativeSettings.NativeFieldInfoPtr_GOOGLE_PLAY_SDK_VERSION_NUMBER, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x060002CD RID: 717 RVA: 0x00021FD8 File Offset: 0x000201D8
	// (set) Token: 0x060002CE RID: 718 RVA: 0x00002DE1 File Offset: 0x00000FE1
	public unsafe static string GOOGLE_PLAY_SDK_LEAGCY_VERSION_NUMBER
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNativeSettings.NativeFieldInfoPtr_GOOGLE_PLAY_SDK_LEAGCY_VERSION_NUMBER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNativeSettings.NativeFieldInfoPtr_GOOGLE_PLAY_SDK_LEAGCY_VERSION_NUMBER, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x060002CF RID: 719 RVA: 0x00021FF8 File Offset: 0x000201F8
	// (set) Token: 0x060002D0 RID: 720 RVA: 0x00002DF3 File Offset: 0x00000FF3
	public unsafe bool EnablePlusAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnablePlusAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnablePlusAPI)) = value;
		}
	}

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x060002D1 RID: 721 RVA: 0x00022020 File Offset: 0x00020220
	// (set) Token: 0x060002D2 RID: 722 RVA: 0x00002E0E File Offset: 0x0000100E
	public unsafe bool EnableGamesAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableGamesAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableGamesAPI)) = value;
		}
	}

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x060002D3 RID: 723 RVA: 0x00022048 File Offset: 0x00020248
	// (set) Token: 0x060002D4 RID: 724 RVA: 0x00002E29 File Offset: 0x00001029
	public unsafe bool EnableAppInviteAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableAppInviteAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableAppInviteAPI)) = value;
		}
	}

	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x060002D5 RID: 725 RVA: 0x00022070 File Offset: 0x00020270
	// (set) Token: 0x060002D6 RID: 726 RVA: 0x00002E44 File Offset: 0x00001044
	public unsafe bool EnableDriveAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableDriveAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableDriveAPI)) = value;
		}
	}

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x060002D7 RID: 727 RVA: 0x00022098 File Offset: 0x00020298
	// (set) Token: 0x060002D8 RID: 728 RVA: 0x00002E5F File Offset: 0x0000105F
	public unsafe bool LoadProfileIcons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LoadProfileIcons);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LoadProfileIcons)) = value;
		}
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x060002D9 RID: 729 RVA: 0x000220C0 File Offset: 0x000202C0
	// (set) Token: 0x060002DA RID: 730 RVA: 0x00002E7A File Offset: 0x0000107A
	public unsafe bool LoadProfileImages
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LoadProfileImages);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LoadProfileImages)) = value;
		}
	}

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x060002DB RID: 731 RVA: 0x000220E8 File Offset: 0x000202E8
	// (set) Token: 0x060002DC RID: 732 RVA: 0x00002E95 File Offset: 0x00001095
	public unsafe bool LoadQuestsImages
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LoadQuestsImages);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LoadQuestsImages)) = value;
		}
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x060002DD RID: 733 RVA: 0x00022110 File Offset: 0x00020310
	// (set) Token: 0x060002DE RID: 734 RVA: 0x00002EB0 File Offset: 0x000010B0
	public unsafe bool LoadQuestsIcons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LoadQuestsIcons);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LoadQuestsIcons)) = value;
		}
	}

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x060002DF RID: 735 RVA: 0x00022138 File Offset: 0x00020338
	// (set) Token: 0x060002E0 RID: 736 RVA: 0x00002ECB File Offset: 0x000010CB
	public unsafe bool LoadEventsIcons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LoadEventsIcons);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LoadEventsIcons)) = value;
		}
	}

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x060002E1 RID: 737 RVA: 0x00022160 File Offset: 0x00020360
	// (set) Token: 0x060002E2 RID: 738 RVA: 0x00002EE6 File Offset: 0x000010E6
	public unsafe bool ShowConnectingPopup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ShowConnectingPopup);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ShowConnectingPopup)) = value;
		}
	}

	// Token: 0x170000DD RID: 221
	// (get) Token: 0x060002E3 RID: 739 RVA: 0x00022188 File Offset: 0x00020388
	// (set) Token: 0x060002E4 RID: 740 RVA: 0x00002F01 File Offset: 0x00001101
	public unsafe bool AutoLoadLocalPlayerScore
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_AutoLoadLocalPlayerScore);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_AutoLoadLocalPlayerScore)) = value;
		}
	}

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x060002E5 RID: 741 RVA: 0x000221B0 File Offset: 0x000203B0
	// (set) Token: 0x060002E6 RID: 742 RVA: 0x00002F1C File Offset: 0x0000111C
	public unsafe bool GoogleFitEnabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GoogleFitEnabled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GoogleFitEnabled)) = value;
		}
	}

	// Token: 0x170000DF RID: 223
	// (get) Token: 0x060002E7 RID: 743 RVA: 0x000221D8 File Offset: 0x000203D8
	// (set) Token: 0x060002E8 RID: 744 RVA: 0x00002F37 File Offset: 0x00001137
	public unsafe bool EnableATCSupport
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableATCSupport);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableATCSupport)) = value;
		}
	}

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x060002E9 RID: 745 RVA: 0x00022200 File Offset: 0x00020400
	// (set) Token: 0x060002EA RID: 746 RVA: 0x00002F52 File Offset: 0x00001152
	public unsafe bool OneSignalEnabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_OneSignalEnabled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_OneSignalEnabled)) = value;
		}
	}

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x060002EB RID: 747 RVA: 0x00022228 File Offset: 0x00020428
	// (set) Token: 0x060002EC RID: 748 RVA: 0x00002F6D File Offset: 0x0000116D
	public unsafe string OneSignalAppID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_OneSignalAppID);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_OneSignalAppID), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x060002ED RID: 749 RVA: 0x00022250 File Offset: 0x00020450
	// (set) Token: 0x060002EE RID: 750 RVA: 0x00002F8C File Offset: 0x0000118C
	public unsafe string OneSignalDownloadLink
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_OneSignalDownloadLink);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_OneSignalDownloadLink), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x060002EF RID: 751 RVA: 0x00022278 File Offset: 0x00020478
	// (set) Token: 0x060002F0 RID: 752 RVA: 0x00002FAB File Offset: 0x000011AB
	public unsafe string OneSignalDocLink
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_OneSignalDocLink);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_OneSignalDocLink), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x060002F1 RID: 753 RVA: 0x000222A0 File Offset: 0x000204A0
	// (set) Token: 0x060002F2 RID: 754 RVA: 0x00002FCA File Offset: 0x000011CA
	public unsafe bool UseParsePushNotifications
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_UseParsePushNotifications);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_UseParsePushNotifications)) = value;
		}
	}

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x060002F3 RID: 755 RVA: 0x000222C8 File Offset: 0x000204C8
	// (set) Token: 0x060002F4 RID: 756 RVA: 0x00002FE5 File Offset: 0x000011E5
	public unsafe string ParseAppId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ParseAppId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ParseAppId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x060002F5 RID: 757 RVA: 0x000222F0 File Offset: 0x000204F0
	// (set) Token: 0x060002F6 RID: 758 RVA: 0x00003004 File Offset: 0x00001204
	public unsafe string DotNetKey
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_DotNetKey);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_DotNetKey), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000E7 RID: 231
	// (get) Token: 0x060002F7 RID: 759 RVA: 0x00022318 File Offset: 0x00020518
	// (set) Token: 0x060002F8 RID: 760 RVA: 0x00003023 File Offset: 0x00001223
	public unsafe string ParseDocLink
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ParseDocLink);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ParseDocLink), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x060002F9 RID: 761 RVA: 0x00022340 File Offset: 0x00020540
	// (set) Token: 0x060002FA RID: 762 RVA: 0x00003042 File Offset: 0x00001242
	public unsafe string ParseDownloadLink
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ParseDownloadLink);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ParseDownloadLink), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x060002FB RID: 763 RVA: 0x00022368 File Offset: 0x00020568
	// (set) Token: 0x060002FC RID: 764 RVA: 0x00003061 File Offset: 0x00001261
	public unsafe AndroidDialogTheme DialogTheme
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_DialogTheme);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_DialogTheme)) = value;
		}
	}

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x060002FD RID: 765 RVA: 0x00022390 File Offset: 0x00020590
	// (set) Token: 0x060002FE RID: 766 RVA: 0x0000307C File Offset: 0x0000127C
	public unsafe bool EnableSoomla
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableSoomla);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableSoomla)) = value;
		}
	}

	// Token: 0x170000EB RID: 235
	// (get) Token: 0x060002FF RID: 767 RVA: 0x000223B8 File Offset: 0x000205B8
	// (set) Token: 0x06000300 RID: 768 RVA: 0x00003097 File Offset: 0x00001297
	public unsafe string SoomlaDownloadLink
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_SoomlaDownloadLink);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_SoomlaDownloadLink), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x06000301 RID: 769 RVA: 0x000223E0 File Offset: 0x000205E0
	// (set) Token: 0x06000302 RID: 770 RVA: 0x000030B6 File Offset: 0x000012B6
	public unsafe string SoomlaDocsLink
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_SoomlaDocsLink);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_SoomlaDocsLink), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x06000303 RID: 771 RVA: 0x00022408 File Offset: 0x00020608
	// (set) Token: 0x06000304 RID: 772 RVA: 0x000030D5 File Offset: 0x000012D5
	public unsafe string SoomlaGameKey
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_SoomlaGameKey);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_SoomlaGameKey), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x06000305 RID: 773 RVA: 0x00022430 File Offset: 0x00020630
	// (set) Token: 0x06000306 RID: 774 RVA: 0x000030F4 File Offset: 0x000012F4
	public unsafe string SoomlaEnvKey
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_SoomlaEnvKey);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_SoomlaEnvKey), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x06000307 RID: 775 RVA: 0x00022458 File Offset: 0x00020658
	// (set) Token: 0x06000308 RID: 776 RVA: 0x00003113 File Offset: 0x00001313
	public unsafe int Ad_EditorFillRateIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_Ad_EditorFillRateIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_Ad_EditorFillRateIndex)) = value;
		}
	}

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x06000309 RID: 777 RVA: 0x00022480 File Offset: 0x00020680
	// (set) Token: 0x0600030A RID: 778 RVA: 0x0000312E File Offset: 0x0000132E
	public unsafe int Ad_EditorFillRate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_Ad_EditorFillRate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_Ad_EditorFillRate)) = value;
		}
	}

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x0600030B RID: 779 RVA: 0x000224A8 File Offset: 0x000206A8
	// (set) Token: 0x0600030C RID: 780 RVA: 0x00003149 File Offset: 0x00001349
	public unsafe bool Is_Ad_EditorTestingEnabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_Is_Ad_EditorTestingEnabled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_Is_Ad_EditorTestingEnabled)) = value;
		}
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x0600030D RID: 781 RVA: 0x000224D0 File Offset: 0x000206D0
	// (set) Token: 0x0600030E RID: 782 RVA: 0x00003164 File Offset: 0x00001364
	public unsafe int InApps_EditorFillRateIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_InApps_EditorFillRateIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_InApps_EditorFillRateIndex)) = value;
		}
	}

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x0600030F RID: 783 RVA: 0x000224F8 File Offset: 0x000206F8
	// (set) Token: 0x06000310 RID: 784 RVA: 0x0000317F File Offset: 0x0000137F
	public unsafe int InApps_EditorFillRate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_InApps_EditorFillRate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_InApps_EditorFillRate)) = value;
		}
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x06000311 RID: 785 RVA: 0x00022520 File Offset: 0x00020720
	// (set) Token: 0x06000312 RID: 786 RVA: 0x0000319A File Offset: 0x0000139A
	public unsafe bool Is_InApps_EditorTestingEnabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_Is_InApps_EditorTestingEnabled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_Is_InApps_EditorTestingEnabled)) = value;
		}
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x06000313 RID: 787 RVA: 0x00022548 File Offset: 0x00020748
	// (set) Token: 0x06000314 RID: 788 RVA: 0x000031B5 File Offset: 0x000013B5
	public unsafe bool Is_Leaderboards_Editor_Notifications_Enabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_Is_Leaderboards_Editor_Notifications_Enabled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_Is_Leaderboards_Editor_Notifications_Enabled)) = value;
		}
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x06000315 RID: 789 RVA: 0x00022570 File Offset: 0x00020770
	// (set) Token: 0x06000316 RID: 790 RVA: 0x000031D0 File Offset: 0x000013D0
	public unsafe bool Is_Achievements_Editor_Notifications_Enabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_Is_Achievements_Editor_Notifications_Enabled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_Is_Achievements_Editor_Notifications_Enabled)) = value;
		}
	}

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x06000317 RID: 791 RVA: 0x00022598 File Offset: 0x00020798
	// (set) Token: 0x06000318 RID: 792 RVA: 0x000031EB File Offset: 0x000013EB
	public unsafe string GCM_SenderId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GCM_SenderId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GCM_SenderId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x06000319 RID: 793 RVA: 0x000225C0 File Offset: 0x000207C0
	// (set) Token: 0x0600031A RID: 794 RVA: 0x0000320A File Offset: 0x0000140A
	public unsafe AN_PushNotificationService PushService
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_PushService);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_PushService)) = value;
		}
	}

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x0600031B RID: 795 RVA: 0x000225E8 File Offset: 0x000207E8
	// (set) Token: 0x0600031C RID: 796 RVA: 0x00003225 File Offset: 0x00001425
	public unsafe bool SaveCameraImageToGallery
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_SaveCameraImageToGallery);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_SaveCameraImageToGallery)) = value;
		}
	}

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x0600031D RID: 797 RVA: 0x00022610 File Offset: 0x00020810
	// (set) Token: 0x0600031E RID: 798 RVA: 0x00003240 File Offset: 0x00001440
	public unsafe bool UseProductNameAsFolderName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_UseProductNameAsFolderName);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_UseProductNameAsFolderName)) = value;
		}
	}

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x0600031F RID: 799 RVA: 0x00022638 File Offset: 0x00020838
	// (set) Token: 0x06000320 RID: 800 RVA: 0x0000325B File Offset: 0x0000145B
	public unsafe string GalleryFolderName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GalleryFolderName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GalleryFolderName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06000321 RID: 801 RVA: 0x00022660 File Offset: 0x00020860
	// (set) Token: 0x06000322 RID: 802 RVA: 0x0000327A File Offset: 0x0000147A
	public unsafe int MaxImageLoadSize
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_MaxImageLoadSize);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_MaxImageLoadSize)) = value;
		}
	}

	// Token: 0x170000FD RID: 253
	// (get) Token: 0x06000323 RID: 803 RVA: 0x00022688 File Offset: 0x00020888
	// (set) Token: 0x06000324 RID: 804 RVA: 0x00003295 File Offset: 0x00001495
	public unsafe AN_CameraCaptureType CameraCaptureMode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_CameraCaptureMode);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_CameraCaptureMode)) = value;
		}
	}

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x06000325 RID: 805 RVA: 0x000226B0 File Offset: 0x000208B0
	// (set) Token: 0x06000326 RID: 806 RVA: 0x000032B0 File Offset: 0x000014B0
	public unsafe AndroidCameraImageFormat ImageFormat
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ImageFormat);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ImageFormat)) = value;
		}
	}

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x06000327 RID: 807 RVA: 0x000226D8 File Offset: 0x000208D8
	// (set) Token: 0x06000328 RID: 808 RVA: 0x000032CB File Offset: 0x000014CB
	public unsafe bool ShowAppPermissions
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ShowAppPermissions);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ShowAppPermissions)) = value;
		}
	}

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x06000329 RID: 809 RVA: 0x00022700 File Offset: 0x00020900
	// (set) Token: 0x0600032A RID: 810 RVA: 0x000032E6 File Offset: 0x000014E6
	public unsafe bool EnableBillingAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableBillingAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableBillingAPI)) = value;
		}
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x0600032B RID: 811 RVA: 0x00022728 File Offset: 0x00020928
	// (set) Token: 0x0600032C RID: 812 RVA: 0x00003301 File Offset: 0x00001501
	public unsafe bool EnablePSAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnablePSAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnablePSAPI)) = value;
		}
	}

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x0600032D RID: 813 RVA: 0x00022750 File Offset: 0x00020950
	// (set) Token: 0x0600032E RID: 814 RVA: 0x0000331C File Offset: 0x0000151C
	public unsafe bool EnableSocialAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableSocialAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableSocialAPI)) = value;
		}
	}

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x0600032F RID: 815 RVA: 0x00022778 File Offset: 0x00020978
	// (set) Token: 0x06000330 RID: 816 RVA: 0x00003337 File Offset: 0x00001537
	public unsafe bool EnableCameraAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableCameraAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableCameraAPI)) = value;
		}
	}

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x06000331 RID: 817 RVA: 0x000227A0 File Offset: 0x000209A0
	// (set) Token: 0x06000332 RID: 818 RVA: 0x00003352 File Offset: 0x00001552
	public unsafe bool ExpandNativeAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ExpandNativeAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ExpandNativeAPI)) = value;
		}
	}

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x06000333 RID: 819 RVA: 0x000227C8 File Offset: 0x000209C8
	// (set) Token: 0x06000334 RID: 820 RVA: 0x0000336D File Offset: 0x0000156D
	public unsafe bool ExpandPSAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ExpandPSAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ExpandPSAPI)) = value;
		}
	}

	// Token: 0x17000106 RID: 262
	// (get) Token: 0x06000335 RID: 821 RVA: 0x000227F0 File Offset: 0x000209F0
	// (set) Token: 0x06000336 RID: 822 RVA: 0x00003388 File Offset: 0x00001588
	public unsafe bool ExpandBillingAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ExpandBillingAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ExpandBillingAPI)) = value;
		}
	}

	// Token: 0x17000107 RID: 263
	// (get) Token: 0x06000337 RID: 823 RVA: 0x00022818 File Offset: 0x00020A18
	// (set) Token: 0x06000338 RID: 824 RVA: 0x000033A3 File Offset: 0x000015A3
	public unsafe bool ExpandSocialAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ExpandSocialAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ExpandSocialAPI)) = value;
		}
	}

	// Token: 0x17000108 RID: 264
	// (get) Token: 0x06000339 RID: 825 RVA: 0x00022840 File Offset: 0x00020A40
	// (set) Token: 0x0600033A RID: 826 RVA: 0x000033BE File Offset: 0x000015BE
	public unsafe bool ExpandCameraAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ExpandCameraAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ExpandCameraAPI)) = value;
		}
	}

	// Token: 0x17000109 RID: 265
	// (get) Token: 0x0600033B RID: 827 RVA: 0x00022868 File Offset: 0x00020A68
	// (set) Token: 0x0600033C RID: 828 RVA: 0x000033D9 File Offset: 0x000015D9
	public unsafe bool ThirdPartyParams
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ThirdPartyParams);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ThirdPartyParams)) = value;
		}
	}

	// Token: 0x1700010A RID: 266
	// (get) Token: 0x0600033D RID: 829 RVA: 0x00022890 File Offset: 0x00020A90
	// (set) Token: 0x0600033E RID: 830 RVA: 0x000033F4 File Offset: 0x000015F4
	public unsafe bool ShowPSSettingsResources
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ShowPSSettingsResources);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ShowPSSettingsResources)) = value;
		}
	}

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x0600033F RID: 831 RVA: 0x000228B8 File Offset: 0x00020AB8
	// (set) Token: 0x06000340 RID: 832 RVA: 0x0000340F File Offset: 0x0000160F
	public unsafe bool ShowActions
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ShowActions);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ShowActions)) = value;
		}
	}

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x06000341 RID: 833 RVA: 0x000228E0 File Offset: 0x00020AE0
	// (set) Token: 0x06000342 RID: 834 RVA: 0x0000342A File Offset: 0x0000162A
	public unsafe bool GCMSettingsActinve
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GCMSettingsActinve);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GCMSettingsActinve)) = value;
		}
	}

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x06000343 RID: 835 RVA: 0x00022908 File Offset: 0x00020B08
	// (set) Token: 0x06000344 RID: 836 RVA: 0x00003445 File Offset: 0x00001645
	public unsafe bool LocalNotificationsAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LocalNotificationsAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LocalNotificationsAPI)) = value;
		}
	}

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x06000345 RID: 837 RVA: 0x00022930 File Offset: 0x00020B30
	// (set) Token: 0x06000346 RID: 838 RVA: 0x00003460 File Offset: 0x00001660
	public unsafe bool ImmersiveModeAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ImmersiveModeAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ImmersiveModeAPI)) = value;
		}
	}

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x06000347 RID: 839 RVA: 0x00022958 File Offset: 0x00020B58
	// (set) Token: 0x06000348 RID: 840 RVA: 0x0000347B File Offset: 0x0000167B
	public unsafe bool ApplicationInformationAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ApplicationInformationAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ApplicationInformationAPI)) = value;
		}
	}

	// Token: 0x17000110 RID: 272
	// (get) Token: 0x06000349 RID: 841 RVA: 0x00022980 File Offset: 0x00020B80
	// (set) Token: 0x0600034A RID: 842 RVA: 0x00003496 File Offset: 0x00001696
	public unsafe bool ExternalAppsAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ExternalAppsAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ExternalAppsAPI)) = value;
		}
	}

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x0600034B RID: 843 RVA: 0x000229A8 File Offset: 0x00020BA8
	// (set) Token: 0x0600034C RID: 844 RVA: 0x000034B1 File Offset: 0x000016B1
	public unsafe bool PoupsandPreloadersAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_PoupsandPreloadersAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_PoupsandPreloadersAPI)) = value;
		}
	}

	// Token: 0x17000112 RID: 274
	// (get) Token: 0x0600034D RID: 845 RVA: 0x000229D0 File Offset: 0x00020BD0
	// (set) Token: 0x0600034E RID: 846 RVA: 0x000034CC File Offset: 0x000016CC
	public unsafe bool CheckAppLicenseAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_CheckAppLicenseAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_CheckAppLicenseAPI)) = value;
		}
	}

	// Token: 0x17000113 RID: 275
	// (get) Token: 0x0600034F RID: 847 RVA: 0x000229F8 File Offset: 0x00020BF8
	// (set) Token: 0x06000350 RID: 848 RVA: 0x000034E7 File Offset: 0x000016E7
	public unsafe bool NetworkStateAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_NetworkStateAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_NetworkStateAPI)) = value;
		}
	}

	// Token: 0x17000114 RID: 276
	// (get) Token: 0x06000351 RID: 849 RVA: 0x00022A20 File Offset: 0x00020C20
	// (set) Token: 0x06000352 RID: 850 RVA: 0x00003502 File Offset: 0x00001702
	public unsafe bool FirebaseAnalytics
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_FirebaseAnalytics);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_FirebaseAnalytics)) = value;
		}
	}

	// Token: 0x17000115 RID: 277
	// (get) Token: 0x06000353 RID: 851 RVA: 0x00022A48 File Offset: 0x00020C48
	// (set) Token: 0x06000354 RID: 852 RVA: 0x0000351D File Offset: 0x0000171D
	public unsafe bool FirebaseDynamicLinks
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_FirebaseDynamicLinks);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_FirebaseDynamicLinks)) = value;
		}
	}

	// Token: 0x17000116 RID: 278
	// (get) Token: 0x06000355 RID: 853 RVA: 0x00022A70 File Offset: 0x00020C70
	// (set) Token: 0x06000356 RID: 854 RVA: 0x00003538 File Offset: 0x00001738
	public unsafe string FirebaseAppId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_FirebaseAppId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_FirebaseAppId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x06000357 RID: 855 RVA: 0x00022A98 File Offset: 0x00020C98
	// (set) Token: 0x06000358 RID: 856 RVA: 0x00003557 File Offset: 0x00001757
	public unsafe string FirebaseApiKey
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_FirebaseApiKey);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_FirebaseApiKey), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000118 RID: 280
	// (get) Token: 0x06000359 RID: 857 RVA: 0x00022AC0 File Offset: 0x00020CC0
	// (set) Token: 0x0600035A RID: 858 RVA: 0x00003576 File Offset: 0x00001776
	public unsafe List<LinkEditorTemplate> DynamicLinks
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_DynamicLinks);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LinkEditorTemplate>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_DynamicLinks), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x0600035B RID: 859 RVA: 0x00022AF0 File Offset: 0x00020CF0
	// (set) Token: 0x0600035C RID: 860 RVA: 0x00003595 File Offset: 0x00001795
	public unsafe bool InAppPurchasesAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_InAppPurchasesAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_InAppPurchasesAPI)) = value;
		}
	}

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x0600035D RID: 861 RVA: 0x00022B18 File Offset: 0x00020D18
	// (set) Token: 0x0600035E RID: 862 RVA: 0x000035B0 File Offset: 0x000017B0
	public unsafe bool GooglePlayServicesAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GooglePlayServicesAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GooglePlayServicesAPI)) = value;
		}
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x0600035F RID: 863 RVA: 0x00022B40 File Offset: 0x00020D40
	// (set) Token: 0x06000360 RID: 864 RVA: 0x000035CB File Offset: 0x000017CB
	public unsafe bool PlayServicesAdvancedSignInAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_PlayServicesAdvancedSignInAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_PlayServicesAdvancedSignInAPI)) = value;
		}
	}

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x06000361 RID: 865 RVA: 0x00022B68 File Offset: 0x00020D68
	// (set) Token: 0x06000362 RID: 866 RVA: 0x000035E6 File Offset: 0x000017E6
	public unsafe bool GoogleButtonAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GoogleButtonAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GoogleButtonAPI)) = value;
		}
	}

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x06000363 RID: 867 RVA: 0x00022B90 File Offset: 0x00020D90
	// (set) Token: 0x06000364 RID: 868 RVA: 0x00003601 File Offset: 0x00001801
	public unsafe bool AnalyticsAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_AnalyticsAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_AnalyticsAPI)) = value;
		}
	}

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x06000365 RID: 869 RVA: 0x00022BB8 File Offset: 0x00020DB8
	// (set) Token: 0x06000366 RID: 870 RVA: 0x0000361C File Offset: 0x0000181C
	public unsafe bool GoogleCloudSaveAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GoogleCloudSaveAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GoogleCloudSaveAPI)) = value;
		}
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x06000367 RID: 871 RVA: 0x00022BE0 File Offset: 0x00020DE0
	// (set) Token: 0x06000368 RID: 872 RVA: 0x00003637 File Offset: 0x00001837
	public unsafe bool PushNotificationsAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_PushNotificationsAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_PushNotificationsAPI)) = value;
		}
	}

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x06000369 RID: 873 RVA: 0x00022C08 File Offset: 0x00020E08
	// (set) Token: 0x0600036A RID: 874 RVA: 0x00003652 File Offset: 0x00001852
	public unsafe bool GoogleMobileAdAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GoogleMobileAdAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GoogleMobileAdAPI)) = value;
		}
	}

	// Token: 0x17000121 RID: 289
	// (get) Token: 0x0600036B RID: 875 RVA: 0x00022C30 File Offset: 0x00020E30
	// (set) Token: 0x0600036C RID: 876 RVA: 0x0000366D File Offset: 0x0000186D
	public unsafe bool GoogleOAuthAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GoogleOAuthAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GoogleOAuthAPI)) = value;
		}
	}

	// Token: 0x17000122 RID: 290
	// (get) Token: 0x0600036D RID: 877 RVA: 0x00022C58 File Offset: 0x00020E58
	// (set) Token: 0x0600036E RID: 878 RVA: 0x00003688 File Offset: 0x00001888
	public unsafe bool GalleryAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GalleryAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GalleryAPI)) = value;
		}
	}

	// Token: 0x17000123 RID: 291
	// (get) Token: 0x0600036F RID: 879 RVA: 0x00022C80 File Offset: 0x00020E80
	// (set) Token: 0x06000370 RID: 880 RVA: 0x000036A3 File Offset: 0x000018A3
	public unsafe bool CameraAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_CameraAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_CameraAPI)) = value;
		}
	}

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x06000371 RID: 881 RVA: 0x00022CA8 File Offset: 0x00020EA8
	// (set) Token: 0x06000372 RID: 882 RVA: 0x000036BE File Offset: 0x000018BE
	public unsafe bool KeepManifestClean
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_KeepManifestClean);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_KeepManifestClean)) = value;
		}
	}

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x06000373 RID: 883 RVA: 0x00022CD0 File Offset: 0x00020ED0
	// (set) Token: 0x06000374 RID: 884 RVA: 0x000036D9 File Offset: 0x000018D9
	public unsafe string GooglePlayServiceAppID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GooglePlayServiceAppID);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_GooglePlayServiceAppID), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x06000375 RID: 885 RVA: 0x00022CF8 File Offset: 0x00020EF8
	// (set) Token: 0x06000376 RID: 886 RVA: 0x000036F8 File Offset: 0x000018F8
	public unsafe int ToolbarSelectedIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ToolbarSelectedIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ToolbarSelectedIndex)) = value;
		}
	}

	// Token: 0x17000127 RID: 295
	// (get) Token: 0x06000377 RID: 887 RVA: 0x00022D20 File Offset: 0x00020F20
	// (set) Token: 0x06000378 RID: 888 RVA: 0x00003713 File Offset: 0x00001913
	public unsafe string base64EncodedPublicKey
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_base64EncodedPublicKey);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_base64EncodedPublicKey), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x06000379 RID: 889 RVA: 0x00022D48 File Offset: 0x00020F48
	// (set) Token: 0x0600037A RID: 890 RVA: 0x00003732 File Offset: 0x00001932
	public unsafe bool ShowStoreProducts
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ShowStoreProducts);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ShowStoreProducts)) = value;
		}
	}

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x0600037B RID: 891 RVA: 0x00022D70 File Offset: 0x00020F70
	// (set) Token: 0x0600037C RID: 892 RVA: 0x0000374D File Offset: 0x0000194D
	public unsafe List<GoogleProductTemplate> InAppProducts
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_InAppProducts);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GoogleProductTemplate>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_InAppProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x0600037D RID: 893 RVA: 0x00022DA0 File Offset: 0x00020FA0
	// (set) Token: 0x0600037E RID: 894 RVA: 0x0000376C File Offset: 0x0000196C
	public unsafe bool ShowLeaderboards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ShowLeaderboards);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ShowLeaderboards)) = value;
		}
	}

	// Token: 0x1700012B RID: 299
	// (get) Token: 0x0600037F RID: 895 RVA: 0x00022DC8 File Offset: 0x00020FC8
	// (set) Token: 0x06000380 RID: 896 RVA: 0x00003787 File Offset: 0x00001987
	public unsafe List<GPLeaderBoard> Leaderboards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_Leaderboards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GPLeaderBoard>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_Leaderboards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700012C RID: 300
	// (get) Token: 0x06000381 RID: 897 RVA: 0x00022DF8 File Offset: 0x00020FF8
	// (set) Token: 0x06000382 RID: 898 RVA: 0x000037A6 File Offset: 0x000019A6
	public unsafe bool ShowAchievements
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ShowAchievements);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ShowAchievements)) = value;
		}
	}

	// Token: 0x1700012D RID: 301
	// (get) Token: 0x06000383 RID: 899 RVA: 0x00022E20 File Offset: 0x00021020
	// (set) Token: 0x06000384 RID: 900 RVA: 0x000037C1 File Offset: 0x000019C1
	public unsafe List<GPAchievement> Achievements
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_Achievements);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GPAchievement>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_Achievements), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x06000385 RID: 901 RVA: 0x00022E50 File Offset: 0x00021050
	// (set) Token: 0x06000386 RID: 902 RVA: 0x000037E0 File Offset: 0x000019E0
	public unsafe bool ShowWhenAppIsForeground
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ShowWhenAppIsForeground);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ShowWhenAppIsForeground)) = value;
		}
	}

	// Token: 0x1700012F RID: 303
	// (get) Token: 0x06000387 RID: 903 RVA: 0x00022E78 File Offset: 0x00021078
	// (set) Token: 0x06000388 RID: 904 RVA: 0x000037FB File Offset: 0x000019FB
	public unsafe bool EnableVibrationLocal
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableVibrationLocal);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableVibrationLocal)) = value;
		}
	}

	// Token: 0x17000130 RID: 304
	// (get) Token: 0x06000389 RID: 905 RVA: 0x00022EA0 File Offset: 0x000210A0
	// (set) Token: 0x0600038A RID: 906 RVA: 0x00003816 File Offset: 0x00001A16
	public unsafe Texture2D LocalNotificationSmallIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LocalNotificationSmallIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LocalNotificationSmallIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000131 RID: 305
	// (get) Token: 0x0600038B RID: 907 RVA: 0x00022ED0 File Offset: 0x000210D0
	// (set) Token: 0x0600038C RID: 908 RVA: 0x00003835 File Offset: 0x00001A35
	public unsafe Texture2D LocalNotificationLargeIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LocalNotificationLargeIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LocalNotificationLargeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000132 RID: 306
	// (get) Token: 0x0600038D RID: 909 RVA: 0x00022F00 File Offset: 0x00021100
	// (set) Token: 0x0600038E RID: 910 RVA: 0x00003854 File Offset: 0x00001A54
	public unsafe AudioClip LocalNotificationSound
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LocalNotificationSound);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LocalNotificationSound), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000133 RID: 307
	// (get) Token: 0x0600038F RID: 911 RVA: 0x00022F30 File Offset: 0x00021130
	// (set) Token: 0x06000390 RID: 912 RVA: 0x00003873 File Offset: 0x00001A73
	public unsafe int LocalNotificationWakeLockTimer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LocalNotificationWakeLockTimer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_LocalNotificationWakeLockTimer)) = value;
		}
	}

	// Token: 0x17000134 RID: 308
	// (get) Token: 0x06000391 RID: 913 RVA: 0x00022F58 File Offset: 0x00021158
	// (set) Token: 0x06000392 RID: 914 RVA: 0x0000388E File Offset: 0x00001A8E
	public unsafe bool ReplaceOldNotificationWithNew
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ReplaceOldNotificationWithNew);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ReplaceOldNotificationWithNew)) = value;
		}
	}

	// Token: 0x17000135 RID: 309
	// (get) Token: 0x06000393 RID: 915 RVA: 0x00022F80 File Offset: 0x00021180
	// (set) Token: 0x06000394 RID: 916 RVA: 0x000038A9 File Offset: 0x00001AA9
	public unsafe bool ShowPushWhenAppIsForeground
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ShowPushWhenAppIsForeground);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_ShowPushWhenAppIsForeground)) = value;
		}
	}

	// Token: 0x17000136 RID: 310
	// (get) Token: 0x06000395 RID: 917 RVA: 0x00022FA8 File Offset: 0x000211A8
	// (set) Token: 0x06000396 RID: 918 RVA: 0x000038C4 File Offset: 0x00001AC4
	public unsafe bool EnableVibrationPush
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableVibrationPush);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_EnableVibrationPush)) = value;
		}
	}

	// Token: 0x17000137 RID: 311
	// (get) Token: 0x06000397 RID: 919 RVA: 0x00022FD0 File Offset: 0x000211D0
	// (set) Token: 0x06000398 RID: 920 RVA: 0x000038DF File Offset: 0x00001ADF
	public unsafe Color PushNotificationColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_PushNotificationColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_PushNotificationColor)) = value;
		}
	}

	// Token: 0x17000138 RID: 312
	// (get) Token: 0x06000399 RID: 921 RVA: 0x00022FF8 File Offset: 0x000211F8
	// (set) Token: 0x0600039A RID: 922 RVA: 0x000038FA File Offset: 0x00001AFA
	public unsafe Texture2D PushNotificationSmallIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_PushNotificationSmallIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_PushNotificationSmallIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000139 RID: 313
	// (get) Token: 0x0600039B RID: 923 RVA: 0x00023028 File Offset: 0x00021228
	// (set) Token: 0x0600039C RID: 924 RVA: 0x00003919 File Offset: 0x00001B19
	public unsafe Texture2D PushNotificationLargeIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_PushNotificationLargeIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_PushNotificationLargeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700013A RID: 314
	// (get) Token: 0x0600039D RID: 925 RVA: 0x00023058 File Offset: 0x00021258
	// (set) Token: 0x0600039E RID: 926 RVA: 0x00003938 File Offset: 0x00001B38
	public unsafe AudioClip PushNotificationSound
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_PushNotificationSound);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeSettings.NativeFieldInfoPtr_PushNotificationSound), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700013B RID: 315
	// (get) Token: 0x0600039F RID: 927 RVA: 0x00023088 File Offset: 0x00021288
	// (set) Token: 0x060003A0 RID: 928 RVA: 0x00003957 File Offset: 0x00001B57
	public unsafe static string ANSettingsAssetName
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNativeSettings.NativeFieldInfoPtr_ANSettingsAssetName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNativeSettings.NativeFieldInfoPtr_ANSettingsAssetName, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x060003A1 RID: 929 RVA: 0x000230A8 File Offset: 0x000212A8
	// (set) Token: 0x060003A2 RID: 930 RVA: 0x00003969 File Offset: 0x00001B69
	public unsafe static string ANSettingsAssetExtension
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNativeSettings.NativeFieldInfoPtr_ANSettingsAssetExtension, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNativeSettings.NativeFieldInfoPtr_ANSettingsAssetExtension, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700013D RID: 317
	// (get) Token: 0x060003A3 RID: 931 RVA: 0x000230C8 File Offset: 0x000212C8
	// (set) Token: 0x060003A4 RID: 932 RVA: 0x0000397B File Offset: 0x00001B7B
	public unsafe static AndroidNativeSettings instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNativeSettings.NativeFieldInfoPtr_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidNativeSettings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNativeSettings.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000251 RID: 593
	private static readonly IntPtr NativeFieldInfoPtr_VERSION_NUMBER;

	// Token: 0x04000252 RID: 594
	private static readonly IntPtr NativeFieldInfoPtr_GOOGLE_PLAY_SDK_VERSION_NUMBER;

	// Token: 0x04000253 RID: 595
	private static readonly IntPtr NativeFieldInfoPtr_GOOGLE_PLAY_SDK_LEAGCY_VERSION_NUMBER;

	// Token: 0x04000254 RID: 596
	private static readonly IntPtr NativeFieldInfoPtr_EnablePlusAPI;

	// Token: 0x04000255 RID: 597
	private static readonly IntPtr NativeFieldInfoPtr_EnableGamesAPI;

	// Token: 0x04000256 RID: 598
	private static readonly IntPtr NativeFieldInfoPtr_EnableAppInviteAPI;

	// Token: 0x04000257 RID: 599
	private static readonly IntPtr NativeFieldInfoPtr_EnableDriveAPI;

	// Token: 0x04000258 RID: 600
	private static readonly IntPtr NativeFieldInfoPtr_LoadProfileIcons;

	// Token: 0x04000259 RID: 601
	private static readonly IntPtr NativeFieldInfoPtr_LoadProfileImages;

	// Token: 0x0400025A RID: 602
	private static readonly IntPtr NativeFieldInfoPtr_LoadQuestsImages;

	// Token: 0x0400025B RID: 603
	private static readonly IntPtr NativeFieldInfoPtr_LoadQuestsIcons;

	// Token: 0x0400025C RID: 604
	private static readonly IntPtr NativeFieldInfoPtr_LoadEventsIcons;

	// Token: 0x0400025D RID: 605
	private static readonly IntPtr NativeFieldInfoPtr_ShowConnectingPopup;

	// Token: 0x0400025E RID: 606
	private static readonly IntPtr NativeFieldInfoPtr_AutoLoadLocalPlayerScore;

	// Token: 0x0400025F RID: 607
	private static readonly IntPtr NativeFieldInfoPtr_GoogleFitEnabled;

	// Token: 0x04000260 RID: 608
	private static readonly IntPtr NativeFieldInfoPtr_EnableATCSupport;

	// Token: 0x04000261 RID: 609
	private static readonly IntPtr NativeFieldInfoPtr_OneSignalEnabled;

	// Token: 0x04000262 RID: 610
	private static readonly IntPtr NativeFieldInfoPtr_OneSignalAppID;

	// Token: 0x04000263 RID: 611
	private static readonly IntPtr NativeFieldInfoPtr_OneSignalDownloadLink;

	// Token: 0x04000264 RID: 612
	private static readonly IntPtr NativeFieldInfoPtr_OneSignalDocLink;

	// Token: 0x04000265 RID: 613
	private static readonly IntPtr NativeFieldInfoPtr_UseParsePushNotifications;

	// Token: 0x04000266 RID: 614
	private static readonly IntPtr NativeFieldInfoPtr_ParseAppId;

	// Token: 0x04000267 RID: 615
	private static readonly IntPtr NativeFieldInfoPtr_DotNetKey;

	// Token: 0x04000268 RID: 616
	private static readonly IntPtr NativeFieldInfoPtr_ParseDocLink;

	// Token: 0x04000269 RID: 617
	private static readonly IntPtr NativeFieldInfoPtr_ParseDownloadLink;

	// Token: 0x0400026A RID: 618
	private static readonly IntPtr NativeFieldInfoPtr_DialogTheme;

	// Token: 0x0400026B RID: 619
	private static readonly IntPtr NativeFieldInfoPtr_EnableSoomla;

	// Token: 0x0400026C RID: 620
	private static readonly IntPtr NativeFieldInfoPtr_SoomlaDownloadLink;

	// Token: 0x0400026D RID: 621
	private static readonly IntPtr NativeFieldInfoPtr_SoomlaDocsLink;

	// Token: 0x0400026E RID: 622
	private static readonly IntPtr NativeFieldInfoPtr_SoomlaGameKey;

	// Token: 0x0400026F RID: 623
	private static readonly IntPtr NativeFieldInfoPtr_SoomlaEnvKey;

	// Token: 0x04000270 RID: 624
	private static readonly IntPtr NativeFieldInfoPtr_Ad_EditorFillRateIndex;

	// Token: 0x04000271 RID: 625
	private static readonly IntPtr NativeFieldInfoPtr_Ad_EditorFillRate;

	// Token: 0x04000272 RID: 626
	private static readonly IntPtr NativeFieldInfoPtr_Is_Ad_EditorTestingEnabled;

	// Token: 0x04000273 RID: 627
	private static readonly IntPtr NativeFieldInfoPtr_InApps_EditorFillRateIndex;

	// Token: 0x04000274 RID: 628
	private static readonly IntPtr NativeFieldInfoPtr_InApps_EditorFillRate;

	// Token: 0x04000275 RID: 629
	private static readonly IntPtr NativeFieldInfoPtr_Is_InApps_EditorTestingEnabled;

	// Token: 0x04000276 RID: 630
	private static readonly IntPtr NativeFieldInfoPtr_Is_Leaderboards_Editor_Notifications_Enabled;

	// Token: 0x04000277 RID: 631
	private static readonly IntPtr NativeFieldInfoPtr_Is_Achievements_Editor_Notifications_Enabled;

	// Token: 0x04000278 RID: 632
	private static readonly IntPtr NativeFieldInfoPtr_GCM_SenderId;

	// Token: 0x04000279 RID: 633
	private static readonly IntPtr NativeFieldInfoPtr_PushService;

	// Token: 0x0400027A RID: 634
	private static readonly IntPtr NativeFieldInfoPtr_SaveCameraImageToGallery;

	// Token: 0x0400027B RID: 635
	private static readonly IntPtr NativeFieldInfoPtr_UseProductNameAsFolderName;

	// Token: 0x0400027C RID: 636
	private static readonly IntPtr NativeFieldInfoPtr_GalleryFolderName;

	// Token: 0x0400027D RID: 637
	private static readonly IntPtr NativeFieldInfoPtr_MaxImageLoadSize;

	// Token: 0x0400027E RID: 638
	private static readonly IntPtr NativeFieldInfoPtr_CameraCaptureMode;

	// Token: 0x0400027F RID: 639
	private static readonly IntPtr NativeFieldInfoPtr_ImageFormat;

	// Token: 0x04000280 RID: 640
	private static readonly IntPtr NativeFieldInfoPtr_ShowAppPermissions;

	// Token: 0x04000281 RID: 641
	private static readonly IntPtr NativeFieldInfoPtr_EnableBillingAPI;

	// Token: 0x04000282 RID: 642
	private static readonly IntPtr NativeFieldInfoPtr_EnablePSAPI;

	// Token: 0x04000283 RID: 643
	private static readonly IntPtr NativeFieldInfoPtr_EnableSocialAPI;

	// Token: 0x04000284 RID: 644
	private static readonly IntPtr NativeFieldInfoPtr_EnableCameraAPI;

	// Token: 0x04000285 RID: 645
	private static readonly IntPtr NativeFieldInfoPtr_ExpandNativeAPI;

	// Token: 0x04000286 RID: 646
	private static readonly IntPtr NativeFieldInfoPtr_ExpandPSAPI;

	// Token: 0x04000287 RID: 647
	private static readonly IntPtr NativeFieldInfoPtr_ExpandBillingAPI;

	// Token: 0x04000288 RID: 648
	private static readonly IntPtr NativeFieldInfoPtr_ExpandSocialAPI;

	// Token: 0x04000289 RID: 649
	private static readonly IntPtr NativeFieldInfoPtr_ExpandCameraAPI;

	// Token: 0x0400028A RID: 650
	private static readonly IntPtr NativeFieldInfoPtr_ThirdPartyParams;

	// Token: 0x0400028B RID: 651
	private static readonly IntPtr NativeFieldInfoPtr_ShowPSSettingsResources;

	// Token: 0x0400028C RID: 652
	private static readonly IntPtr NativeFieldInfoPtr_ShowActions;

	// Token: 0x0400028D RID: 653
	private static readonly IntPtr NativeFieldInfoPtr_GCMSettingsActinve;

	// Token: 0x0400028E RID: 654
	private static readonly IntPtr NativeFieldInfoPtr_LocalNotificationsAPI;

	// Token: 0x0400028F RID: 655
	private static readonly IntPtr NativeFieldInfoPtr_ImmersiveModeAPI;

	// Token: 0x04000290 RID: 656
	private static readonly IntPtr NativeFieldInfoPtr_ApplicationInformationAPI;

	// Token: 0x04000291 RID: 657
	private static readonly IntPtr NativeFieldInfoPtr_ExternalAppsAPI;

	// Token: 0x04000292 RID: 658
	private static readonly IntPtr NativeFieldInfoPtr_PoupsandPreloadersAPI;

	// Token: 0x04000293 RID: 659
	private static readonly IntPtr NativeFieldInfoPtr_CheckAppLicenseAPI;

	// Token: 0x04000294 RID: 660
	private static readonly IntPtr NativeFieldInfoPtr_NetworkStateAPI;

	// Token: 0x04000295 RID: 661
	private static readonly IntPtr NativeFieldInfoPtr_FirebaseAnalytics;

	// Token: 0x04000296 RID: 662
	private static readonly IntPtr NativeFieldInfoPtr_FirebaseDynamicLinks;

	// Token: 0x04000297 RID: 663
	private static readonly IntPtr NativeFieldInfoPtr_FirebaseAppId;

	// Token: 0x04000298 RID: 664
	private static readonly IntPtr NativeFieldInfoPtr_FirebaseApiKey;

	// Token: 0x04000299 RID: 665
	private static readonly IntPtr NativeFieldInfoPtr_DynamicLinks;

	// Token: 0x0400029A RID: 666
	private static readonly IntPtr NativeFieldInfoPtr_InAppPurchasesAPI;

	// Token: 0x0400029B RID: 667
	private static readonly IntPtr NativeFieldInfoPtr_GooglePlayServicesAPI;

	// Token: 0x0400029C RID: 668
	private static readonly IntPtr NativeFieldInfoPtr_PlayServicesAdvancedSignInAPI;

	// Token: 0x0400029D RID: 669
	private static readonly IntPtr NativeFieldInfoPtr_GoogleButtonAPI;

	// Token: 0x0400029E RID: 670
	private static readonly IntPtr NativeFieldInfoPtr_AnalyticsAPI;

	// Token: 0x0400029F RID: 671
	private static readonly IntPtr NativeFieldInfoPtr_GoogleCloudSaveAPI;

	// Token: 0x040002A0 RID: 672
	private static readonly IntPtr NativeFieldInfoPtr_PushNotificationsAPI;

	// Token: 0x040002A1 RID: 673
	private static readonly IntPtr NativeFieldInfoPtr_GoogleMobileAdAPI;

	// Token: 0x040002A2 RID: 674
	private static readonly IntPtr NativeFieldInfoPtr_GoogleOAuthAPI;

	// Token: 0x040002A3 RID: 675
	private static readonly IntPtr NativeFieldInfoPtr_GalleryAPI;

	// Token: 0x040002A4 RID: 676
	private static readonly IntPtr NativeFieldInfoPtr_CameraAPI;

	// Token: 0x040002A5 RID: 677
	private static readonly IntPtr NativeFieldInfoPtr_KeepManifestClean;

	// Token: 0x040002A6 RID: 678
	private static readonly IntPtr NativeFieldInfoPtr_GooglePlayServiceAppID;

	// Token: 0x040002A7 RID: 679
	private static readonly IntPtr NativeFieldInfoPtr_ToolbarSelectedIndex;

	// Token: 0x040002A8 RID: 680
	private static readonly IntPtr NativeFieldInfoPtr_base64EncodedPublicKey;

	// Token: 0x040002A9 RID: 681
	private static readonly IntPtr NativeFieldInfoPtr_ShowStoreProducts;

	// Token: 0x040002AA RID: 682
	private static readonly IntPtr NativeFieldInfoPtr_InAppProducts;

	// Token: 0x040002AB RID: 683
	private static readonly IntPtr NativeFieldInfoPtr_ShowLeaderboards;

	// Token: 0x040002AC RID: 684
	private static readonly IntPtr NativeFieldInfoPtr_Leaderboards;

	// Token: 0x040002AD RID: 685
	private static readonly IntPtr NativeFieldInfoPtr_ShowAchievements;

	// Token: 0x040002AE RID: 686
	private static readonly IntPtr NativeFieldInfoPtr_Achievements;

	// Token: 0x040002AF RID: 687
	private static readonly IntPtr NativeFieldInfoPtr_ShowWhenAppIsForeground;

	// Token: 0x040002B0 RID: 688
	private static readonly IntPtr NativeFieldInfoPtr_EnableVibrationLocal;

	// Token: 0x040002B1 RID: 689
	private static readonly IntPtr NativeFieldInfoPtr_LocalNotificationSmallIcon;

	// Token: 0x040002B2 RID: 690
	private static readonly IntPtr NativeFieldInfoPtr_LocalNotificationLargeIcon;

	// Token: 0x040002B3 RID: 691
	private static readonly IntPtr NativeFieldInfoPtr_LocalNotificationSound;

	// Token: 0x040002B4 RID: 692
	private static readonly IntPtr NativeFieldInfoPtr_LocalNotificationWakeLockTimer;

	// Token: 0x040002B5 RID: 693
	private static readonly IntPtr NativeFieldInfoPtr_ReplaceOldNotificationWithNew;

	// Token: 0x040002B6 RID: 694
	private static readonly IntPtr NativeFieldInfoPtr_ShowPushWhenAppIsForeground;

	// Token: 0x040002B7 RID: 695
	private static readonly IntPtr NativeFieldInfoPtr_EnableVibrationPush;

	// Token: 0x040002B8 RID: 696
	private static readonly IntPtr NativeFieldInfoPtr_PushNotificationColor;

	// Token: 0x040002B9 RID: 697
	private static readonly IntPtr NativeFieldInfoPtr_PushNotificationSmallIcon;

	// Token: 0x040002BA RID: 698
	private static readonly IntPtr NativeFieldInfoPtr_PushNotificationLargeIcon;

	// Token: 0x040002BB RID: 699
	private static readonly IntPtr NativeFieldInfoPtr_PushNotificationSound;

	// Token: 0x040002BC RID: 700
	private static readonly IntPtr NativeFieldInfoPtr_ANSettingsAssetName;

	// Token: 0x040002BD RID: 701
	private static readonly IntPtr NativeFieldInfoPtr_ANSettingsAssetExtension;

	// Token: 0x040002BE RID: 702
	private static readonly IntPtr NativeFieldInfoPtr_instance;

	// Token: 0x040002BF RID: 703
	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_AndroidNativeSettings_0;

	// Token: 0x040002C0 RID: 704
	private static readonly IntPtr NativeMethodInfoPtr_get_IsBase64KeyWasReplaced_Public_get_Boolean_0;

	// Token: 0x040002C1 RID: 705
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

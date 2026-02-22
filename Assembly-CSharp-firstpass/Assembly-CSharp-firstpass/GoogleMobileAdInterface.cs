using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000012 RID: 18
public class GoogleMobileAdInterface : Il2CppObjectBase
{
	// Token: 0x06000107 RID: 263 RVA: 0x0001AAA8 File Offset: 0x00018CA8
	// Note: this type is marked as 'beforefieldinit'.
	static GoogleMobileAdInterface()
	{
		Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GoogleMobileAdInterface");
		GoogleMobileAdInterface.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663461);
		GoogleMobileAdInterface.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663462);
		GoogleMobileAdInterface.NativeMethodInfoPtr_InitEditorTesting_Public_Abstract_Virtual_New_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663463);
		GoogleMobileAdInterface.NativeMethodInfoPtr_SetBannersUnitID_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663464);
		GoogleMobileAdInterface.NativeMethodInfoPtr_SetInterstisialsUnitID_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663465);
		GoogleMobileAdInterface.NativeMethodInfoPtr_SetRewardedVideoAdUnitID_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663466);
		GoogleMobileAdInterface.NativeMethodInfoPtr_AddKeyword_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663467);
		GoogleMobileAdInterface.NativeMethodInfoPtr_AddTestDevice_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663468);
		GoogleMobileAdInterface.NativeMethodInfoPtr_AddTestDevices_Public_Abstract_Virtual_New_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663469);
		GoogleMobileAdInterface.NativeMethodInfoPtr_SetGender_Public_Abstract_Virtual_New_Void_GoogleGender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663470);
		GoogleMobileAdInterface.NativeMethodInfoPtr_SetBirthday_Public_Abstract_Virtual_New_Void_Int32_AndroidMonth_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663471);
		GoogleMobileAdInterface.NativeMethodInfoPtr_TagForChildDirectedTreatment_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663472);
		GoogleMobileAdInterface.NativeMethodInfoPtr_CreateAdBanner_Public_Abstract_Virtual_New_GoogleMobileAdBanner_TextAnchor_GADBannerSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663473);
		GoogleMobileAdInterface.NativeMethodInfoPtr_CreateAdBanner_Public_Abstract_Virtual_New_GoogleMobileAdBanner_Int32_Int32_GADBannerSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663474);
		GoogleMobileAdInterface.NativeMethodInfoPtr_DestroyBanner_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663475);
		GoogleMobileAdInterface.NativeMethodInfoPtr_StartRewardedVideo_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663476);
		GoogleMobileAdInterface.NativeMethodInfoPtr_LoadRewardedVideo_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663477);
		GoogleMobileAdInterface.NativeMethodInfoPtr_ShowRewardedVideo_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663478);
		GoogleMobileAdInterface.NativeMethodInfoPtr_StartInterstitialAd_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663479);
		GoogleMobileAdInterface.NativeMethodInfoPtr_LoadInterstitialAd_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663480);
		GoogleMobileAdInterface.NativeMethodInfoPtr_ShowInterstitialAd_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663481);
		GoogleMobileAdInterface.NativeMethodInfoPtr_RecordInAppResolution_Public_Abstract_Virtual_New_Void_GADInAppResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663482);
		GoogleMobileAdInterface.NativeMethodInfoPtr_GetBanner_Public_Abstract_Virtual_New_GoogleMobileAdBanner_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663483);
		GoogleMobileAdInterface.NativeMethodInfoPtr_get_banners_Public_Abstract_Virtual_New_get_List_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663484);
		GoogleMobileAdInterface.NativeMethodInfoPtr_get_IsInited_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663485);
		GoogleMobileAdInterface.NativeMethodInfoPtr_get_BannersUunitId_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663486);
		GoogleMobileAdInterface.NativeMethodInfoPtr_get_InterstisialUnitId_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663487);
		GoogleMobileAdInterface.NativeMethodInfoPtr_get_RewardedVideoAdUnitId_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663488);
		GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnInterstitialLoaded_Public_Abstract_Virtual_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663489);
		GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnInterstitialLoaded_Public_Abstract_Virtual_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663490);
		GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnInterstitialFailedLoading_Public_Abstract_Virtual_New_add_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663491);
		GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnInterstitialFailedLoading_Public_Abstract_Virtual_New_rem_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663492);
		GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnInterstitialOpened_Public_Abstract_Virtual_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663493);
		GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnInterstitialOpened_Public_Abstract_Virtual_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663494);
		GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnInterstitialClosed_Public_Abstract_Virtual_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663495);
		GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnInterstitialClosed_Public_Abstract_Virtual_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663496);
		GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnInterstitialLeftApplication_Public_Abstract_Virtual_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663497);
		GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnInterstitialLeftApplication_Public_Abstract_Virtual_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663498);
		GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnAdInAppRequest_Public_Abstract_Virtual_New_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663499);
		GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnAdInAppRequest_Public_Abstract_Virtual_New_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663500);
		GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnRewarded_Public_Abstract_Virtual_New_add_Void_Action_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663501);
		GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnRewarded_Public_Abstract_Virtual_New_rem_Void_Action_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663502);
		GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnRewardedVideoAdClosed_Public_Abstract_Virtual_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663503);
		GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnRewardedVideoAdClosed_Public_Abstract_Virtual_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663504);
		GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnRewardedVideoAdFailedToLoad_Public_Abstract_Virtual_New_add_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663505);
		GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnRewardedVideoAdFailedToLoad_Public_Abstract_Virtual_New_rem_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663506);
		GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnRewardedVideoAdLeftApplication_Public_Abstract_Virtual_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663507);
		GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnRewardedVideoAdLeftApplication_Public_Abstract_Virtual_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663508);
		GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnRewardedVideoLoaded_Public_Abstract_Virtual_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663509);
		GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnRewardedVideoLoaded_Public_Abstract_Virtual_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663510);
		GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnRewardedVideoAdOpened_Public_Abstract_Virtual_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663511);
		GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnRewardedVideoAdOpened_Public_Abstract_Virtual_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663512);
		GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnRewardedVideoStarted_Public_Abstract_Virtual_New_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663513);
		GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnRewardedVideoStarted_Public_Abstract_Virtual_New_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdInterface>.NativeClassPtr, 100663514);
	}

	// Token: 0x06000108 RID: 264 RVA: 0x0001AF08 File Offset: 0x00019108
	[CallerCount(0)]
	public unsafe virtual void Init(string ad_unit_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ad_unit_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000109 RID: 265 RVA: 0x0001AF58 File Offset: 0x00019158
	[CallerCount(0)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600010A RID: 266 RVA: 0x0001AFB8 File Offset: 0x000191B8
	[CallerCount(0)]
	public unsafe virtual void InitEditorTesting(bool isEditorTestingEnabled, int fillRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isEditorTestingEnabled;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fillRate;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_InitEditorTesting_Public_Abstract_Virtual_New_Void_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600010B RID: 267 RVA: 0x0001B010 File Offset: 0x00019210
	[CallerCount(0)]
	public unsafe virtual void SetBannersUnitID(string ad_unit_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ad_unit_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_SetBannersUnitID_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600010C RID: 268 RVA: 0x0001B060 File Offset: 0x00019260
	[CallerCount(0)]
	public unsafe virtual void SetInterstisialsUnitID(string ad_unit_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ad_unit_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_SetInterstisialsUnitID_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600010D RID: 269 RVA: 0x0001B0B0 File Offset: 0x000192B0
	[CallerCount(0)]
	public unsafe virtual void SetRewardedVideoAdUnitID(string ad_unit_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ad_unit_id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_SetRewardedVideoAdUnitID_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600010E RID: 270 RVA: 0x0001B100 File Offset: 0x00019300
	[CallerCount(0)]
	public unsafe virtual void AddKeyword(string keyword)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_AddKeyword_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600010F RID: 271 RVA: 0x0001B150 File Offset: 0x00019350
	[CallerCount(0)]
	public unsafe virtual void AddTestDevice(string deviceId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deviceId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_AddTestDevice_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000110 RID: 272 RVA: 0x0001B1A0 File Offset: 0x000193A0
	[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_AddTestDevices_Public_Abstract_Virtual_New_Void_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000111 RID: 273 RVA: 0x0001B1FC File Offset: 0x000193FC
	[CallerCount(0)]
	public unsafe virtual void SetGender(GoogleGender gender)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gender;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_SetGender_Public_Abstract_Virtual_New_Void_GoogleGender_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000112 RID: 274 RVA: 0x0001B248 File Offset: 0x00019448
	[CallerCount(0)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_SetBirthday_Public_Abstract_Virtual_New_Void_Int32_AndroidMonth_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000113 RID: 275 RVA: 0x0001B2B0 File Offset: 0x000194B0
	[CallerCount(0)]
	public unsafe virtual void TagForChildDirectedTreatment(bool tagForChildDirectedTreatment)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref tagForChildDirectedTreatment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_TagForChildDirectedTreatment_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000114 RID: 276 RVA: 0x0001B2FC File Offset: 0x000194FC
	[CallerCount(0)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_CreateAdBanner_Public_Abstract_Virtual_New_GoogleMobileAdBanner_TextAnchor_GADBannerSize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleMobileAdBanner>(intPtr3) : null;
	}

	// Token: 0x06000115 RID: 277 RVA: 0x0001B364 File Offset: 0x00019564
	[CallerCount(0)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_CreateAdBanner_Public_Abstract_Virtual_New_GoogleMobileAdBanner_Int32_Int32_GADBannerSize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleMobileAdBanner>(intPtr3) : null;
	}

	// Token: 0x06000116 RID: 278 RVA: 0x0001B3D8 File Offset: 0x000195D8
	[CallerCount(0)]
	public unsafe virtual void DestroyBanner(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_DestroyBanner_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000117 RID: 279 RVA: 0x0001B424 File Offset: 0x00019624
	[CallerCount(0)]
	public unsafe virtual void StartRewardedVideo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_StartRewardedVideo_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000118 RID: 280 RVA: 0x0001B460 File Offset: 0x00019660
	[CallerCount(0)]
	public unsafe virtual void LoadRewardedVideo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_LoadRewardedVideo_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000119 RID: 281 RVA: 0x0001B49C File Offset: 0x0001969C
	[CallerCount(0)]
	public unsafe virtual void ShowRewardedVideo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_ShowRewardedVideo_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600011A RID: 282 RVA: 0x0001B4D8 File Offset: 0x000196D8
	[CallerCount(0)]
	public unsafe virtual void StartInterstitialAd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_StartInterstitialAd_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600011B RID: 283 RVA: 0x0001B514 File Offset: 0x00019714
	[CallerCount(0)]
	public unsafe virtual void LoadInterstitialAd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_LoadInterstitialAd_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600011C RID: 284 RVA: 0x0001B550 File Offset: 0x00019750
	[CallerCount(0)]
	public unsafe virtual void ShowInterstitialAd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_ShowInterstitialAd_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600011D RID: 285 RVA: 0x0001B58C File Offset: 0x0001978C
	[CallerCount(0)]
	public unsafe virtual void RecordInAppResolution(GADInAppResolution resolution)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref resolution;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_RecordInAppResolution_Public_Abstract_Virtual_New_Void_GADInAppResolution_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600011E RID: 286 RVA: 0x0001B5D8 File Offset: 0x000197D8
	[CallerCount(0)]
	public unsafe virtual GoogleMobileAdBanner GetBanner(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_GetBanner_Public_Abstract_Virtual_New_GoogleMobileAdBanner_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleMobileAdBanner>(intPtr3) : null;
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x0600011F RID: 287 RVA: 0x0001B630 File Offset: 0x00019830
	public unsafe virtual List<GoogleMobileAdBanner> banners
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_get_banners_Public_Abstract_Virtual_New_get_List_1_GoogleMobileAdBanner_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GoogleMobileAdBanner>>(intPtr3) : null;
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x06000120 RID: 288 RVA: 0x0001B67C File Offset: 0x0001987C
	public unsafe virtual bool IsInited
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_get_IsInited_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x06000121 RID: 289 RVA: 0x0001B6C4 File Offset: 0x000198C4
	public unsafe virtual string BannersUunitId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_get_BannersUunitId_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x06000122 RID: 290 RVA: 0x0001B708 File Offset: 0x00019908
	public unsafe virtual string InterstisialUnitId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_get_InterstisialUnitId_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x06000123 RID: 291 RVA: 0x0001B74C File Offset: 0x0001994C
	public unsafe virtual string RewardedVideoAdUnitId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_get_RewardedVideoAdUnitId_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000124 RID: 292 RVA: 0x0001B790 File Offset: 0x00019990
	[CallerCount(0)]
	public unsafe virtual void add_OnInterstitialLoaded(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnInterstitialLoaded_Public_Abstract_Virtual_New_add_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000125 RID: 293 RVA: 0x0001B7E0 File Offset: 0x000199E0
	[CallerCount(0)]
	public unsafe virtual void remove_OnInterstitialLoaded(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnInterstitialLoaded_Public_Abstract_Virtual_New_rem_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000126 RID: 294 RVA: 0x0001B830 File Offset: 0x00019A30
	[CallerCount(0)]
	public unsafe virtual void add_OnInterstitialFailedLoading(Action<int> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnInterstitialFailedLoading_Public_Abstract_Virtual_New_add_Void_Action_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000127 RID: 295 RVA: 0x0001B880 File Offset: 0x00019A80
	[CallerCount(0)]
	public unsafe virtual void remove_OnInterstitialFailedLoading(Action<int> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnInterstitialFailedLoading_Public_Abstract_Virtual_New_rem_Void_Action_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000128 RID: 296 RVA: 0x0001B8D0 File Offset: 0x00019AD0
	[CallerCount(0)]
	public unsafe virtual void add_OnInterstitialOpened(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnInterstitialOpened_Public_Abstract_Virtual_New_add_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000129 RID: 297 RVA: 0x0001B920 File Offset: 0x00019B20
	[CallerCount(0)]
	public unsafe virtual void remove_OnInterstitialOpened(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnInterstitialOpened_Public_Abstract_Virtual_New_rem_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600012A RID: 298 RVA: 0x0001B970 File Offset: 0x00019B70
	[CallerCount(0)]
	public unsafe virtual void add_OnInterstitialClosed(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnInterstitialClosed_Public_Abstract_Virtual_New_add_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600012B RID: 299 RVA: 0x0001B9C0 File Offset: 0x00019BC0
	[CallerCount(0)]
	public unsafe virtual void remove_OnInterstitialClosed(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnInterstitialClosed_Public_Abstract_Virtual_New_rem_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600012C RID: 300 RVA: 0x0001BA10 File Offset: 0x00019C10
	[CallerCount(0)]
	public unsafe virtual void add_OnInterstitialLeftApplication(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnInterstitialLeftApplication_Public_Abstract_Virtual_New_add_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600012D RID: 301 RVA: 0x0001BA60 File Offset: 0x00019C60
	[CallerCount(0)]
	public unsafe virtual void remove_OnInterstitialLeftApplication(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnInterstitialLeftApplication_Public_Abstract_Virtual_New_rem_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600012E RID: 302 RVA: 0x0001BAB0 File Offset: 0x00019CB0
	[CallerCount(0)]
	public unsafe virtual void add_OnAdInAppRequest(Action<string> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnAdInAppRequest_Public_Abstract_Virtual_New_add_Void_Action_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600012F RID: 303 RVA: 0x0001BB00 File Offset: 0x00019D00
	[CallerCount(0)]
	public unsafe virtual void remove_OnAdInAppRequest(Action<string> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnAdInAppRequest_Public_Abstract_Virtual_New_rem_Void_Action_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000130 RID: 304 RVA: 0x0001BB50 File Offset: 0x00019D50
	[CallerCount(0)]
	public unsafe virtual void add_OnRewarded(Action<string, int> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnRewarded_Public_Abstract_Virtual_New_add_Void_Action_2_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000131 RID: 305 RVA: 0x0001BBA0 File Offset: 0x00019DA0
	[CallerCount(0)]
	public unsafe virtual void remove_OnRewarded(Action<string, int> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnRewarded_Public_Abstract_Virtual_New_rem_Void_Action_2_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000132 RID: 306 RVA: 0x0001BBF0 File Offset: 0x00019DF0
	[CallerCount(0)]
	public unsafe virtual void add_OnRewardedVideoAdClosed(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnRewardedVideoAdClosed_Public_Abstract_Virtual_New_add_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000133 RID: 307 RVA: 0x0001BC40 File Offset: 0x00019E40
	[CallerCount(0)]
	public unsafe virtual void remove_OnRewardedVideoAdClosed(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnRewardedVideoAdClosed_Public_Abstract_Virtual_New_rem_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000134 RID: 308 RVA: 0x0001BC90 File Offset: 0x00019E90
	[CallerCount(0)]
	public unsafe virtual void add_OnRewardedVideoAdFailedToLoad(Action<int> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnRewardedVideoAdFailedToLoad_Public_Abstract_Virtual_New_add_Void_Action_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000135 RID: 309 RVA: 0x0001BCE0 File Offset: 0x00019EE0
	[CallerCount(0)]
	public unsafe virtual void remove_OnRewardedVideoAdFailedToLoad(Action<int> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnRewardedVideoAdFailedToLoad_Public_Abstract_Virtual_New_rem_Void_Action_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000136 RID: 310 RVA: 0x0001BD30 File Offset: 0x00019F30
	[CallerCount(0)]
	public unsafe virtual void add_OnRewardedVideoAdLeftApplication(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnRewardedVideoAdLeftApplication_Public_Abstract_Virtual_New_add_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000137 RID: 311 RVA: 0x0001BD80 File Offset: 0x00019F80
	[CallerCount(0)]
	public unsafe virtual void remove_OnRewardedVideoAdLeftApplication(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnRewardedVideoAdLeftApplication_Public_Abstract_Virtual_New_rem_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000138 RID: 312 RVA: 0x0001BDD0 File Offset: 0x00019FD0
	[CallerCount(0)]
	public unsafe virtual void add_OnRewardedVideoLoaded(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnRewardedVideoLoaded_Public_Abstract_Virtual_New_add_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000139 RID: 313 RVA: 0x0001BE20 File Offset: 0x0001A020
	[CallerCount(0)]
	public unsafe virtual void remove_OnRewardedVideoLoaded(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnRewardedVideoLoaded_Public_Abstract_Virtual_New_rem_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600013A RID: 314 RVA: 0x0001BE70 File Offset: 0x0001A070
	[CallerCount(0)]
	public unsafe virtual void add_OnRewardedVideoAdOpened(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnRewardedVideoAdOpened_Public_Abstract_Virtual_New_add_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600013B RID: 315 RVA: 0x0001BEC0 File Offset: 0x0001A0C0
	[CallerCount(0)]
	public unsafe virtual void remove_OnRewardedVideoAdOpened(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnRewardedVideoAdOpened_Public_Abstract_Virtual_New_rem_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600013C RID: 316 RVA: 0x0001BF10 File Offset: 0x0001A110
	[CallerCount(0)]
	public unsafe virtual void add_OnRewardedVideoStarted(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_add_OnRewardedVideoStarted_Public_Abstract_Virtual_New_add_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600013D RID: 317 RVA: 0x0001BF60 File Offset: 0x0001A160
	[CallerCount(0)]
	public unsafe virtual void remove_OnRewardedVideoStarted(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GoogleMobileAdInterface.NativeMethodInfoPtr_remove_OnRewardedVideoStarted_Public_Abstract_Virtual_New_rem_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600013E RID: 318 RVA: 0x000024AA File Offset: 0x000006AA
	public virtual void AddTestDevices(params string[] ids)
	{
		this.AddTestDevices(new Il2CppStringArray(ids));
	}

	// Token: 0x0600013F RID: 319 RVA: 0x000024B8 File Offset: 0x000006B8
	public GoogleMobileAdInterface(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040000FC RID: 252
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_String_0;

	// Token: 0x040000FD RID: 253
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_String_String_0;

	// Token: 0x040000FE RID: 254
	private static readonly IntPtr NativeMethodInfoPtr_InitEditorTesting_Public_Abstract_Virtual_New_Void_Boolean_Int32_0;

	// Token: 0x040000FF RID: 255
	private static readonly IntPtr NativeMethodInfoPtr_SetBannersUnitID_Public_Abstract_Virtual_New_Void_String_0;

	// Token: 0x04000100 RID: 256
	private static readonly IntPtr NativeMethodInfoPtr_SetInterstisialsUnitID_Public_Abstract_Virtual_New_Void_String_0;

	// Token: 0x04000101 RID: 257
	private static readonly IntPtr NativeMethodInfoPtr_SetRewardedVideoAdUnitID_Public_Abstract_Virtual_New_Void_String_0;

	// Token: 0x04000102 RID: 258
	private static readonly IntPtr NativeMethodInfoPtr_AddKeyword_Public_Abstract_Virtual_New_Void_String_0;

	// Token: 0x04000103 RID: 259
	private static readonly IntPtr NativeMethodInfoPtr_AddTestDevice_Public_Abstract_Virtual_New_Void_String_0;

	// Token: 0x04000104 RID: 260
	private static readonly IntPtr NativeMethodInfoPtr_AddTestDevices_Public_Abstract_Virtual_New_Void_Il2CppStringArray_0;

	// Token: 0x04000105 RID: 261
	private static readonly IntPtr NativeMethodInfoPtr_SetGender_Public_Abstract_Virtual_New_Void_GoogleGender_0;

	// Token: 0x04000106 RID: 262
	private static readonly IntPtr NativeMethodInfoPtr_SetBirthday_Public_Abstract_Virtual_New_Void_Int32_AndroidMonth_Int32_0;

	// Token: 0x04000107 RID: 263
	private static readonly IntPtr NativeMethodInfoPtr_TagForChildDirectedTreatment_Public_Abstract_Virtual_New_Void_Boolean_0;

	// Token: 0x04000108 RID: 264
	private static readonly IntPtr NativeMethodInfoPtr_CreateAdBanner_Public_Abstract_Virtual_New_GoogleMobileAdBanner_TextAnchor_GADBannerSize_0;

	// Token: 0x04000109 RID: 265
	private static readonly IntPtr NativeMethodInfoPtr_CreateAdBanner_Public_Abstract_Virtual_New_GoogleMobileAdBanner_Int32_Int32_GADBannerSize_0;

	// Token: 0x0400010A RID: 266
	private static readonly IntPtr NativeMethodInfoPtr_DestroyBanner_Public_Abstract_Virtual_New_Void_Int32_0;

	// Token: 0x0400010B RID: 267
	private static readonly IntPtr NativeMethodInfoPtr_StartRewardedVideo_Public_Abstract_Virtual_New_Void_0;

	// Token: 0x0400010C RID: 268
	private static readonly IntPtr NativeMethodInfoPtr_LoadRewardedVideo_Public_Abstract_Virtual_New_Void_0;

	// Token: 0x0400010D RID: 269
	private static readonly IntPtr NativeMethodInfoPtr_ShowRewardedVideo_Public_Abstract_Virtual_New_Void_0;

	// Token: 0x0400010E RID: 270
	private static readonly IntPtr NativeMethodInfoPtr_StartInterstitialAd_Public_Abstract_Virtual_New_Void_0;

	// Token: 0x0400010F RID: 271
	private static readonly IntPtr NativeMethodInfoPtr_LoadInterstitialAd_Public_Abstract_Virtual_New_Void_0;

	// Token: 0x04000110 RID: 272
	private static readonly IntPtr NativeMethodInfoPtr_ShowInterstitialAd_Public_Abstract_Virtual_New_Void_0;

	// Token: 0x04000111 RID: 273
	private static readonly IntPtr NativeMethodInfoPtr_RecordInAppResolution_Public_Abstract_Virtual_New_Void_GADInAppResolution_0;

	// Token: 0x04000112 RID: 274
	private static readonly IntPtr NativeMethodInfoPtr_GetBanner_Public_Abstract_Virtual_New_GoogleMobileAdBanner_Int32_0;

	// Token: 0x04000113 RID: 275
	private static readonly IntPtr NativeMethodInfoPtr_get_banners_Public_Abstract_Virtual_New_get_List_1_GoogleMobileAdBanner_0;

	// Token: 0x04000114 RID: 276
	private static readonly IntPtr NativeMethodInfoPtr_get_IsInited_Public_Abstract_Virtual_New_get_Boolean_0;

	// Token: 0x04000115 RID: 277
	private static readonly IntPtr NativeMethodInfoPtr_get_BannersUunitId_Public_Abstract_Virtual_New_get_String_0;

	// Token: 0x04000116 RID: 278
	private static readonly IntPtr NativeMethodInfoPtr_get_InterstisialUnitId_Public_Abstract_Virtual_New_get_String_0;

	// Token: 0x04000117 RID: 279
	private static readonly IntPtr NativeMethodInfoPtr_get_RewardedVideoAdUnitId_Public_Abstract_Virtual_New_get_String_0;

	// Token: 0x04000118 RID: 280
	private static readonly IntPtr NativeMethodInfoPtr_add_OnInterstitialLoaded_Public_Abstract_Virtual_New_add_Void_Action_0;

	// Token: 0x04000119 RID: 281
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnInterstitialLoaded_Public_Abstract_Virtual_New_rem_Void_Action_0;

	// Token: 0x0400011A RID: 282
	private static readonly IntPtr NativeMethodInfoPtr_add_OnInterstitialFailedLoading_Public_Abstract_Virtual_New_add_Void_Action_1_Int32_0;

	// Token: 0x0400011B RID: 283
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnInterstitialFailedLoading_Public_Abstract_Virtual_New_rem_Void_Action_1_Int32_0;

	// Token: 0x0400011C RID: 284
	private static readonly IntPtr NativeMethodInfoPtr_add_OnInterstitialOpened_Public_Abstract_Virtual_New_add_Void_Action_0;

	// Token: 0x0400011D RID: 285
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnInterstitialOpened_Public_Abstract_Virtual_New_rem_Void_Action_0;

	// Token: 0x0400011E RID: 286
	private static readonly IntPtr NativeMethodInfoPtr_add_OnInterstitialClosed_Public_Abstract_Virtual_New_add_Void_Action_0;

	// Token: 0x0400011F RID: 287
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnInterstitialClosed_Public_Abstract_Virtual_New_rem_Void_Action_0;

	// Token: 0x04000120 RID: 288
	private static readonly IntPtr NativeMethodInfoPtr_add_OnInterstitialLeftApplication_Public_Abstract_Virtual_New_add_Void_Action_0;

	// Token: 0x04000121 RID: 289
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnInterstitialLeftApplication_Public_Abstract_Virtual_New_rem_Void_Action_0;

	// Token: 0x04000122 RID: 290
	private static readonly IntPtr NativeMethodInfoPtr_add_OnAdInAppRequest_Public_Abstract_Virtual_New_add_Void_Action_1_String_0;

	// Token: 0x04000123 RID: 291
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnAdInAppRequest_Public_Abstract_Virtual_New_rem_Void_Action_1_String_0;

	// Token: 0x04000124 RID: 292
	private static readonly IntPtr NativeMethodInfoPtr_add_OnRewarded_Public_Abstract_Virtual_New_add_Void_Action_2_String_Int32_0;

	// Token: 0x04000125 RID: 293
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnRewarded_Public_Abstract_Virtual_New_rem_Void_Action_2_String_Int32_0;

	// Token: 0x04000126 RID: 294
	private static readonly IntPtr NativeMethodInfoPtr_add_OnRewardedVideoAdClosed_Public_Abstract_Virtual_New_add_Void_Action_0;

	// Token: 0x04000127 RID: 295
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnRewardedVideoAdClosed_Public_Abstract_Virtual_New_rem_Void_Action_0;

	// Token: 0x04000128 RID: 296
	private static readonly IntPtr NativeMethodInfoPtr_add_OnRewardedVideoAdFailedToLoad_Public_Abstract_Virtual_New_add_Void_Action_1_Int32_0;

	// Token: 0x04000129 RID: 297
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnRewardedVideoAdFailedToLoad_Public_Abstract_Virtual_New_rem_Void_Action_1_Int32_0;

	// Token: 0x0400012A RID: 298
	private static readonly IntPtr NativeMethodInfoPtr_add_OnRewardedVideoAdLeftApplication_Public_Abstract_Virtual_New_add_Void_Action_0;

	// Token: 0x0400012B RID: 299
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnRewardedVideoAdLeftApplication_Public_Abstract_Virtual_New_rem_Void_Action_0;

	// Token: 0x0400012C RID: 300
	private static readonly IntPtr NativeMethodInfoPtr_add_OnRewardedVideoLoaded_Public_Abstract_Virtual_New_add_Void_Action_0;

	// Token: 0x0400012D RID: 301
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnRewardedVideoLoaded_Public_Abstract_Virtual_New_rem_Void_Action_0;

	// Token: 0x0400012E RID: 302
	private static readonly IntPtr NativeMethodInfoPtr_add_OnRewardedVideoAdOpened_Public_Abstract_Virtual_New_add_Void_Action_0;

	// Token: 0x0400012F RID: 303
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnRewardedVideoAdOpened_Public_Abstract_Virtual_New_rem_Void_Action_0;

	// Token: 0x04000130 RID: 304
	private static readonly IntPtr NativeMethodInfoPtr_add_OnRewardedVideoStarted_Public_Abstract_Virtual_New_add_Void_Action_0;

	// Token: 0x04000131 RID: 305
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnRewardedVideoStarted_Public_Abstract_Virtual_New_rem_Void_Action_0;
}

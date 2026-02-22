using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using SA.Common.Pattern;
using UnityEngine;

// Token: 0x020000DA RID: 218
public class AndroidNativeUtility : Singleton<AndroidNativeUtility>
{
	// Token: 0x06000F68 RID: 3944 RVA: 0x0004D28C File Offset: 0x0004B48C
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidNativeUtility()
	{
		Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidNativeUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr);
		AndroidNativeUtility.NativeFieldInfoPtr_OnPackageCheckResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, "OnPackageCheckResult");
		AndroidNativeUtility.NativeFieldInfoPtr_OnAndroidIdLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, "OnAndroidIdLoaded");
		AndroidNativeUtility.NativeFieldInfoPtr_InternalStoragePathLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, "InternalStoragePathLoaded");
		AndroidNativeUtility.NativeFieldInfoPtr_ExternalStoragePathLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, "ExternalStoragePathLoaded");
		AndroidNativeUtility.NativeFieldInfoPtr_LocaleInfoLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, "LocaleInfoLoaded");
		AndroidNativeUtility.NativeFieldInfoPtr_ActionDevicePackagesListLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, "ActionDevicePackagesListLoaded");
		AndroidNativeUtility.NativeFieldInfoPtr_ActionNetworkInfoLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, "ActionNetworkInfoLoaded");
		AndroidNativeUtility.NativeFieldInfoPtr_OnOAuthRefreshTokenLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, "OnOAuthRefreshTokenLoaded");
		AndroidNativeUtility.NativeFieldInfoPtr_OnOAuthAccessTokenLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, "OnOAuthAccessTokenLoaded");
		AndroidNativeUtility.NativeFieldInfoPtr_OnDeviceCodeLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, "OnDeviceCodeLoaded");
		AndroidNativeUtility.NativeFieldInfoPtr__redirectUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, "_redirectUrl");
		AndroidNativeUtility.NativeFieldInfoPtr__clientId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, "_clientId");
		AndroidNativeUtility.NativeFieldInfoPtr__clientSecret = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, "_clientSecret");
		AndroidNativeUtility.NativeMethodInfoPtr_add_OnPackageCheckResult_Public_Static_add_Void_Action_1_AN_PackageCheckResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665195);
		AndroidNativeUtility.NativeMethodInfoPtr_remove_OnPackageCheckResult_Public_Static_rem_Void_Action_1_AN_PackageCheckResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665196);
		AndroidNativeUtility.NativeMethodInfoPtr_add_OnAndroidIdLoaded_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665197);
		AndroidNativeUtility.NativeMethodInfoPtr_remove_OnAndroidIdLoaded_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665198);
		AndroidNativeUtility.NativeMethodInfoPtr_add_InternalStoragePathLoaded_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665199);
		AndroidNativeUtility.NativeMethodInfoPtr_remove_InternalStoragePathLoaded_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665200);
		AndroidNativeUtility.NativeMethodInfoPtr_add_ExternalStoragePathLoaded_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665201);
		AndroidNativeUtility.NativeMethodInfoPtr_remove_ExternalStoragePathLoaded_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665202);
		AndroidNativeUtility.NativeMethodInfoPtr_add_LocaleInfoLoaded_Public_Static_add_Void_Action_1_AN_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665203);
		AndroidNativeUtility.NativeMethodInfoPtr_remove_LocaleInfoLoaded_Public_Static_rem_Void_Action_1_AN_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665204);
		AndroidNativeUtility.NativeMethodInfoPtr_add_ActionDevicePackagesListLoaded_Public_Static_add_Void_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665205);
		AndroidNativeUtility.NativeMethodInfoPtr_remove_ActionDevicePackagesListLoaded_Public_Static_rem_Void_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665206);
		AndroidNativeUtility.NativeMethodInfoPtr_add_ActionNetworkInfoLoaded_Public_Static_add_Void_Action_1_AN_NetworkInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665207);
		AndroidNativeUtility.NativeMethodInfoPtr_remove_ActionNetworkInfoLoaded_Public_Static_rem_Void_Action_1_AN_NetworkInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665208);
		AndroidNativeUtility.NativeMethodInfoPtr_add_OnOAuthRefreshTokenLoaded_Public_Static_add_Void_Action_1_AN_RefreshTokenResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665209);
		AndroidNativeUtility.NativeMethodInfoPtr_remove_OnOAuthRefreshTokenLoaded_Public_Static_rem_Void_Action_1_AN_RefreshTokenResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665210);
		AndroidNativeUtility.NativeMethodInfoPtr_add_OnOAuthAccessTokenLoaded_Public_Static_add_Void_Action_1_AN_AccessTokenResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665211);
		AndroidNativeUtility.NativeMethodInfoPtr_remove_OnOAuthAccessTokenLoaded_Public_Static_rem_Void_Action_1_AN_AccessTokenResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665212);
		AndroidNativeUtility.NativeMethodInfoPtr_add_OnDeviceCodeLoaded_Public_Static_add_Void_Action_1_AN_DeviceCodeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665213);
		AndroidNativeUtility.NativeMethodInfoPtr_remove_OnDeviceCodeLoaded_Public_Static_rem_Void_Action_1_AN_DeviceCodeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665214);
		AndroidNativeUtility.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665215);
		AndroidNativeUtility.NativeMethodInfoPtr_GenerateRefreshToken_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665216);
		AndroidNativeUtility.NativeMethodInfoPtr_RefreshOAuthToken_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665217);
		AndroidNativeUtility.NativeMethodInfoPtr_ObtainUserDeviceCode_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665218);
		AndroidNativeUtility.NativeMethodInfoPtr_CheckIsPackageInstalled_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665219);
		AndroidNativeUtility.NativeMethodInfoPtr_StartApplication_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665220);
		AndroidNativeUtility.NativeMethodInfoPtr_StartApplication_Public_Void_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665221);
		AndroidNativeUtility.NativeMethodInfoPtr_LoadAndroidId_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665222);
		AndroidNativeUtility.NativeMethodInfoPtr_GetInternalStoragePath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665223);
		AndroidNativeUtility.NativeMethodInfoPtr_GetExternalStoragePath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665224);
		AndroidNativeUtility.NativeMethodInfoPtr_GetExternalStoragePublicDirectory_Public_String_AN_ExternalStorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665225);
		AndroidNativeUtility.NativeMethodInfoPtr_LoadLocaleInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665226);
		AndroidNativeUtility.NativeMethodInfoPtr_LoadPackagesList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665227);
		AndroidNativeUtility.NativeMethodInfoPtr_LoadNetworkInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665228);
		AndroidNativeUtility.NativeMethodInfoPtr_OpenSettingsPage_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665229);
		AndroidNativeUtility.NativeMethodInfoPtr_ShowPreloader_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665230);
		AndroidNativeUtility.NativeMethodInfoPtr_ShowPreloader_Public_Static_Void_String_String_AndroidDialogTheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665231);
		AndroidNativeUtility.NativeMethodInfoPtr_HidePreloader_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665232);
		AndroidNativeUtility.NativeMethodInfoPtr_OpenAppRatingPage_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665233);
		AndroidNativeUtility.NativeMethodInfoPtr_RedirectToGooglePlayRatingPage_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665234);
		AndroidNativeUtility.NativeMethodInfoPtr_HideCurrentPopup_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665235);
		AndroidNativeUtility.NativeMethodInfoPtr_get_SDKLevel_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665236);
		AndroidNativeUtility.NativeMethodInfoPtr_InvitePlusFriends_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665237);
		AndroidNativeUtility.NativeMethodInfoPtr_RefreshTokenCodeReceived_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665238);
		AndroidNativeUtility.NativeMethodInfoPtr_GenerateRefreshTokenRequest_Private_IEnumerator_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665239);
		AndroidNativeUtility.NativeMethodInfoPtr_RefreshOAuthTokenRequest_Private_IEnumerator_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665240);
		AndroidNativeUtility.NativeMethodInfoPtr_ObtainUserDeviceCodeRequest_Private_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665241);
		AndroidNativeUtility.NativeMethodInfoPtr_OnAndroidIdLoadedEvent_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665242);
		AndroidNativeUtility.NativeMethodInfoPtr_OnPacakgeFound_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665243);
		AndroidNativeUtility.NativeMethodInfoPtr_OnPacakgeNotFound_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665244);
		AndroidNativeUtility.NativeMethodInfoPtr_OnExternalStoragePathLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665245);
		AndroidNativeUtility.NativeMethodInfoPtr_OnInternalStoragePathLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665246);
		AndroidNativeUtility.NativeMethodInfoPtr_OnLocaleInfoLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665247);
		AndroidNativeUtility.NativeMethodInfoPtr_OnPackagesListLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665248);
		AndroidNativeUtility.NativeMethodInfoPtr_OnNetworkInfoLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665249);
		AndroidNativeUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, 100665250);
	}

	// Token: 0x06000F69 RID: 3945 RVA: 0x0004D820 File Offset: 0x0004BA20
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 179917, RefRangeEnd = 179919, XrefRangeStart = 179906, XrefRangeEnd = 179917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnPackageCheckResult(Action<AN_PackageCheckResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_add_OnPackageCheckResult_Public_Static_add_Void_Action_1_AN_PackageCheckResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F6A RID: 3946 RVA: 0x0004D858 File Offset: 0x0004BA58
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 179930, RefRangeEnd = 179932, XrefRangeStart = 179919, XrefRangeEnd = 179930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnPackageCheckResult(Action<AN_PackageCheckResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_remove_OnPackageCheckResult_Public_Static_rem_Void_Action_1_AN_PackageCheckResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x0004D890 File Offset: 0x0004BA90
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 179943, RefRangeEnd = 179945, XrefRangeStart = 179932, XrefRangeEnd = 179943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnAndroidIdLoaded(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_add_OnAndroidIdLoaded_Public_Static_add_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F6C RID: 3948 RVA: 0x0004D8C8 File Offset: 0x0004BAC8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 179956, RefRangeEnd = 179958, XrefRangeStart = 179945, XrefRangeEnd = 179956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnAndroidIdLoaded(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_remove_OnAndroidIdLoaded_Public_Static_rem_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F6D RID: 3949 RVA: 0x0004D900 File Offset: 0x0004BB00
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 179969, RefRangeEnd = 179971, XrefRangeStart = 179958, XrefRangeEnd = 179969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_InternalStoragePathLoaded(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_add_InternalStoragePathLoaded_Public_Static_add_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F6E RID: 3950 RVA: 0x0004D938 File Offset: 0x0004BB38
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 179982, RefRangeEnd = 179984, XrefRangeStart = 179971, XrefRangeEnd = 179982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_InternalStoragePathLoaded(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_remove_InternalStoragePathLoaded_Public_Static_rem_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x0004D970 File Offset: 0x0004BB70
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 179995, RefRangeEnd = 179997, XrefRangeStart = 179984, XrefRangeEnd = 179995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ExternalStoragePathLoaded(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_add_ExternalStoragePathLoaded_Public_Static_add_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x0004D9A8 File Offset: 0x0004BBA8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 180008, RefRangeEnd = 180010, XrefRangeStart = 179997, XrefRangeEnd = 180008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ExternalStoragePathLoaded(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_remove_ExternalStoragePathLoaded_Public_Static_rem_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F71 RID: 3953 RVA: 0x0004D9E0 File Offset: 0x0004BBE0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 180021, RefRangeEnd = 180023, XrefRangeStart = 180010, XrefRangeEnd = 180021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_LocaleInfoLoaded(Action<AN_Locale> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_add_LocaleInfoLoaded_Public_Static_add_Void_Action_1_AN_Locale_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x0004DA18 File Offset: 0x0004BC18
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 180034, RefRangeEnd = 180036, XrefRangeStart = 180023, XrefRangeEnd = 180034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_LocaleInfoLoaded(Action<AN_Locale> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_remove_LocaleInfoLoaded_Public_Static_rem_Void_Action_1_AN_Locale_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F73 RID: 3955 RVA: 0x0004DA50 File Offset: 0x0004BC50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180036, XrefRangeEnd = 180047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionDevicePackagesListLoaded(Action<Il2CppStringArray> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_add_ActionDevicePackagesListLoaded_Public_Static_add_Void_Action_1_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F74 RID: 3956 RVA: 0x0004DA88 File Offset: 0x0004BC88
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180047, XrefRangeEnd = 180058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionDevicePackagesListLoaded(Action<Il2CppStringArray> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_remove_ActionDevicePackagesListLoaded_Public_Static_rem_Void_Action_1_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F75 RID: 3957 RVA: 0x0004DAC0 File Offset: 0x0004BCC0
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 180069, RefRangeEnd = 180073, XrefRangeStart = 180058, XrefRangeEnd = 180069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionNetworkInfoLoaded(Action<AN_NetworkInfo> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_add_ActionNetworkInfoLoaded_Public_Static_add_Void_Action_1_AN_NetworkInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F76 RID: 3958 RVA: 0x0004DAF8 File Offset: 0x0004BCF8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 180084, RefRangeEnd = 180086, XrefRangeStart = 180073, XrefRangeEnd = 180084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionNetworkInfoLoaded(Action<AN_NetworkInfo> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_remove_ActionNetworkInfoLoaded_Public_Static_rem_Void_Action_1_AN_NetworkInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F77 RID: 3959 RVA: 0x0004DB30 File Offset: 0x0004BD30
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180086, XrefRangeEnd = 180097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnOAuthRefreshTokenLoaded(Action<AN_RefreshTokenResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_add_OnOAuthRefreshTokenLoaded_Public_Static_add_Void_Action_1_AN_RefreshTokenResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F78 RID: 3960 RVA: 0x0004DB68 File Offset: 0x0004BD68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180097, XrefRangeEnd = 180108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnOAuthRefreshTokenLoaded(Action<AN_RefreshTokenResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_remove_OnOAuthRefreshTokenLoaded_Public_Static_rem_Void_Action_1_AN_RefreshTokenResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F79 RID: 3961 RVA: 0x0004DBA0 File Offset: 0x0004BDA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180108, XrefRangeEnd = 180119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnOAuthAccessTokenLoaded(Action<AN_AccessTokenResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_add_OnOAuthAccessTokenLoaded_Public_Static_add_Void_Action_1_AN_AccessTokenResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F7A RID: 3962 RVA: 0x0004DBD8 File Offset: 0x0004BDD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180119, XrefRangeEnd = 180130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnOAuthAccessTokenLoaded(Action<AN_AccessTokenResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_remove_OnOAuthAccessTokenLoaded_Public_Static_rem_Void_Action_1_AN_AccessTokenResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F7B RID: 3963 RVA: 0x0004DC10 File Offset: 0x0004BE10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180130, XrefRangeEnd = 180141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnDeviceCodeLoaded(Action<AN_DeviceCodeResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_add_OnDeviceCodeLoaded_Public_Static_add_Void_Action_1_AN_DeviceCodeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F7C RID: 3964 RVA: 0x0004DC48 File Offset: 0x0004BE48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180141, XrefRangeEnd = 180152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnDeviceCodeLoaded(Action<AN_DeviceCodeResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_remove_OnDeviceCodeLoaded_Public_Static_rem_Void_Action_1_AN_DeviceCodeResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F7D RID: 3965 RVA: 0x0004DC80 File Offset: 0x0004BE80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180152, XrefRangeEnd = 180157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F7E RID: 3966 RVA: 0x0004DCB4 File Offset: 0x0004BEB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180157, XrefRangeEnd = 180176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateRefreshToken(string redirectUrl, string clientId, string clientSecret)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(redirectUrl);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(clientId);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(clientSecret);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_GenerateRefreshToken_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x0004DD1C File Offset: 0x0004BF1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180176, XrefRangeEnd = 180182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshOAuthToken(string refreshToken, string clientId, string clientSecret)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(refreshToken);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(clientId);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(clientSecret);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_RefreshOAuthToken_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F80 RID: 3968 RVA: 0x0004DD84 File Offset: 0x0004BF84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180182, XrefRangeEnd = 180188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ObtainUserDeviceCode(string clientId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(clientId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_ObtainUserDeviceCode_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F81 RID: 3969 RVA: 0x0004DDC8 File Offset: 0x0004BFC8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 180202, RefRangeEnd = 180204, XrefRangeStart = 180188, XrefRangeEnd = 180202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckIsPackageInstalled(string packageName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(packageName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_CheckIsPackageInstalled_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x0004DE0C File Offset: 0x0004C00C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180204, XrefRangeEnd = 180218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartApplication(string bundle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(bundle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_StartApplication_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F83 RID: 3971 RVA: 0x0004DE50 File Offset: 0x0004C050
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180218, XrefRangeEnd = 180266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartApplication(string packageName, Dictionary<string, string> extras)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(packageName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extras);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_StartApplication_Public_Void_String_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F84 RID: 3972 RVA: 0x0004DEA4 File Offset: 0x0004C0A4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 176930, RefRangeEnd = 176932, XrefRangeStart = 176930, XrefRangeEnd = 176932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAndroidId()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_LoadAndroidId_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F85 RID: 3973 RVA: 0x0004DED8 File Offset: 0x0004C0D8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177026, RefRangeEnd = 177028, XrefRangeStart = 177026, XrefRangeEnd = 177028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetInternalStoragePath()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_GetInternalStoragePath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F86 RID: 3974 RVA: 0x0004DF0C File Offset: 0x0004C10C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177036, RefRangeEnd = 177038, XrefRangeStart = 177036, XrefRangeEnd = 177038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetExternalStoragePath()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_GetExternalStoragePath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F87 RID: 3975 RVA: 0x0004DF40 File Offset: 0x0004C140
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180266, XrefRangeEnd = 180272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetExternalStoragePublicDirectory(AN_ExternalStorageType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_GetExternalStoragePublicDirectory_Public_String_AN_ExternalStorageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000F88 RID: 3976 RVA: 0x0004DF84 File Offset: 0x0004C184
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177048, RefRangeEnd = 177050, XrefRangeStart = 177048, XrefRangeEnd = 177050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadLocaleInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_LoadLocaleInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F89 RID: 3977 RVA: 0x0004DFB8 File Offset: 0x0004C1B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadPackagesList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_LoadPackagesList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x0004DFEC File Offset: 0x0004C1EC
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 176958, RefRangeEnd = 176962, XrefRangeStart = 176958, XrefRangeEnd = 176962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadNetworkInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_LoadNetworkInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x0004E020 File Offset: 0x0004C220
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 176976, RefRangeEnd = 176978, XrefRangeStart = 176976, XrefRangeEnd = 176978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OpenSettingsPage(string action)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_OpenSettingsPage_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x0004E058 File Offset: 0x0004C258
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 180278, RefRangeEnd = 180279, XrefRangeStart = 180272, XrefRangeEnd = 180278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowPreloader(string title, string message)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_ShowPreloader_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F8D RID: 3981 RVA: 0x0004E0A0 File Offset: 0x0004C2A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180279, XrefRangeEnd = 180285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowPreloader(string title, string message, AndroidDialogTheme theme)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref theme;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_ShowPreloader_Public_Static_Void_String_String_AndroidDialogTheme_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F8E RID: 3982 RVA: 0x0004E0F8 File Offset: 0x0004C2F8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 180286, RefRangeEnd = 180287, XrefRangeStart = 180285, XrefRangeEnd = 180286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HidePreloader()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_HidePreloader_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F8F RID: 3983 RVA: 0x0004E120 File Offset: 0x0004C320
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 180288, RefRangeEnd = 180289, XrefRangeStart = 180287, XrefRangeEnd = 180288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OpenAppRatingPage(string url)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_OpenAppRatingPage_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x0004E158 File Offset: 0x0004C358
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180289, XrefRangeEnd = 180293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RedirectToGooglePlayRatingPage(string url)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_RedirectToGooglePlayRatingPage_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x0004E190 File Offset: 0x0004C390
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180293, XrefRangeEnd = 180294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HideCurrentPopup()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_HideCurrentPopup_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x1700049A RID: 1178
	// (get) Token: 0x06000F92 RID: 3986 RVA: 0x0004E1B8 File Offset: 0x0004C3B8
	public unsafe static int SDKLevel
	{
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_get_SDKLevel_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x0004E1E8 File Offset: 0x0004C3E8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 176948, RefRangeEnd = 176950, XrefRangeStart = 176948, XrefRangeEnd = 176950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvitePlusFriends()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_InvitePlusFriends_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x0004E210 File Offset: 0x0004C410
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180294, XrefRangeEnd = 180320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshTokenCodeReceived(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_RefreshTokenCodeReceived_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x0004E254 File Offset: 0x0004C454
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180320, XrefRangeEnd = 180324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator GenerateRefreshTokenRequest(string code, string clientId, string clientSecret, string redirectUrl)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(clientId);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(clientSecret);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(redirectUrl);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_GenerateRefreshTokenRequest_Private_IEnumerator_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x0004E2DC File Offset: 0x0004C4DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180324, XrefRangeEnd = 180328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator RefreshOAuthTokenRequest(string clientId, string clientSecret, string refreshToken)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(clientId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(clientSecret);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(refreshToken);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_RefreshOAuthTokenRequest_Private_IEnumerator_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x0004E350 File Offset: 0x0004C550
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180328, XrefRangeEnd = 180332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ObtainUserDeviceCodeRequest(string clientId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(clientId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_ObtainUserDeviceCodeRequest_Private_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x0004E3A0 File Offset: 0x0004C5A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180332, XrefRangeEnd = 180340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAndroidIdLoadedEvent(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_OnAndroidIdLoadedEvent_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F99 RID: 3993 RVA: 0x0004E3E4 File Offset: 0x0004C5E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180340, XrefRangeEnd = 180352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPacakgeFound(string packageName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(packageName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_OnPacakgeFound_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x0004E428 File Offset: 0x0004C628
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180352, XrefRangeEnd = 180372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPacakgeNotFound(string packageName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(packageName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_OnPacakgeNotFound_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x0004E46C File Offset: 0x0004C66C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180372, XrefRangeEnd = 180380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExternalStoragePathLoaded(string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_OnExternalStoragePathLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x0004E4B0 File Offset: 0x0004C6B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180380, XrefRangeEnd = 180388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInternalStoragePathLoaded(string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_OnInternalStoragePathLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x0004E4F4 File Offset: 0x0004C6F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180388, XrefRangeEnd = 180417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLocaleInfoLoaded(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_OnLocaleInfoLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x0004E538 File Offset: 0x0004C738
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180417, XrefRangeEnd = 180434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPackagesListLoaded(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_OnPackagesListLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x0004E57C File Offset: 0x0004C77C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180434, XrefRangeEnd = 180474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnNetworkInfoLoaded(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr_OnNetworkInfoLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x0004E5C0 File Offset: 0x0004C7C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180474, XrefRangeEnd = 180484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidNativeUtility()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x00007D99 File Offset: 0x00005F99
	public AndroidNativeUtility(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700048D RID: 1165
	// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x0004E5FC File Offset: 0x0004C7FC
	// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x00007DA2 File Offset: 0x00005FA2
	public unsafe static Action<AN_PackageCheckResult> OnPackageCheckResult
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNativeUtility.NativeFieldInfoPtr_OnPackageCheckResult, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AN_PackageCheckResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNativeUtility.NativeFieldInfoPtr_OnPackageCheckResult, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700048E RID: 1166
	// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x0004E624 File Offset: 0x0004C824
	// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x00007DB4 File Offset: 0x00005FB4
	public unsafe static Action<string> OnAndroidIdLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNativeUtility.NativeFieldInfoPtr_OnAndroidIdLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNativeUtility.NativeFieldInfoPtr_OnAndroidIdLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700048F RID: 1167
	// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x0004E64C File Offset: 0x0004C84C
	// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x00007DC6 File Offset: 0x00005FC6
	public unsafe static Action<string> InternalStoragePathLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNativeUtility.NativeFieldInfoPtr_InternalStoragePathLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNativeUtility.NativeFieldInfoPtr_InternalStoragePathLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000490 RID: 1168
	// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x0004E674 File Offset: 0x0004C874
	// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x00007DD8 File Offset: 0x00005FD8
	public unsafe static Action<string> ExternalStoragePathLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNativeUtility.NativeFieldInfoPtr_ExternalStoragePathLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNativeUtility.NativeFieldInfoPtr_ExternalStoragePathLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000491 RID: 1169
	// (get) Token: 0x06000FAA RID: 4010 RVA: 0x0004E69C File Offset: 0x0004C89C
	// (set) Token: 0x06000FAB RID: 4011 RVA: 0x00007DEA File Offset: 0x00005FEA
	public unsafe static Action<AN_Locale> LocaleInfoLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNativeUtility.NativeFieldInfoPtr_LocaleInfoLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AN_Locale>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNativeUtility.NativeFieldInfoPtr_LocaleInfoLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000492 RID: 1170
	// (get) Token: 0x06000FAC RID: 4012 RVA: 0x0004E6C4 File Offset: 0x0004C8C4
	// (set) Token: 0x06000FAD RID: 4013 RVA: 0x00007DFC File Offset: 0x00005FFC
	public unsafe static Action<Il2CppStringArray> ActionDevicePackagesListLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNativeUtility.NativeFieldInfoPtr_ActionDevicePackagesListLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNativeUtility.NativeFieldInfoPtr_ActionDevicePackagesListLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000493 RID: 1171
	// (get) Token: 0x06000FAE RID: 4014 RVA: 0x0004E6EC File Offset: 0x0004C8EC
	// (set) Token: 0x06000FAF RID: 4015 RVA: 0x00007E0E File Offset: 0x0000600E
	public unsafe static Action<AN_NetworkInfo> ActionNetworkInfoLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNativeUtility.NativeFieldInfoPtr_ActionNetworkInfoLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AN_NetworkInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNativeUtility.NativeFieldInfoPtr_ActionNetworkInfoLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000494 RID: 1172
	// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x0004E714 File Offset: 0x0004C914
	// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x00007E20 File Offset: 0x00006020
	public unsafe static Action<AN_RefreshTokenResult> OnOAuthRefreshTokenLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNativeUtility.NativeFieldInfoPtr_OnOAuthRefreshTokenLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AN_RefreshTokenResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNativeUtility.NativeFieldInfoPtr_OnOAuthRefreshTokenLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000495 RID: 1173
	// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x0004E73C File Offset: 0x0004C93C
	// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x00007E32 File Offset: 0x00006032
	public unsafe static Action<AN_AccessTokenResult> OnOAuthAccessTokenLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNativeUtility.NativeFieldInfoPtr_OnOAuthAccessTokenLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AN_AccessTokenResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNativeUtility.NativeFieldInfoPtr_OnOAuthAccessTokenLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000496 RID: 1174
	// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x0004E764 File Offset: 0x0004C964
	// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x00007E44 File Offset: 0x00006044
	public unsafe static Action<AN_DeviceCodeResult> OnDeviceCodeLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNativeUtility.NativeFieldInfoPtr_OnDeviceCodeLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AN_DeviceCodeResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNativeUtility.NativeFieldInfoPtr_OnDeviceCodeLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000497 RID: 1175
	// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x0004E78C File Offset: 0x0004C98C
	// (set) Token: 0x06000FB7 RID: 4023 RVA: 0x00007E56 File Offset: 0x00006056
	public unsafe string _redirectUrl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility.NativeFieldInfoPtr__redirectUrl);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility.NativeFieldInfoPtr__redirectUrl), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000498 RID: 1176
	// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x0004E7B4 File Offset: 0x0004C9B4
	// (set) Token: 0x06000FB9 RID: 4025 RVA: 0x00007E75 File Offset: 0x00006075
	public unsafe string _clientId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility.NativeFieldInfoPtr__clientId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility.NativeFieldInfoPtr__clientId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000499 RID: 1177
	// (get) Token: 0x06000FBA RID: 4026 RVA: 0x0004E7DC File Offset: 0x0004C9DC
	// (set) Token: 0x06000FBB RID: 4027 RVA: 0x00007E94 File Offset: 0x00006094
	public unsafe string _clientSecret
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility.NativeFieldInfoPtr__clientSecret);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility.NativeFieldInfoPtr__clientSecret), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000C33 RID: 3123
	private static readonly IntPtr NativeFieldInfoPtr_OnPackageCheckResult;

	// Token: 0x04000C34 RID: 3124
	private static readonly IntPtr NativeFieldInfoPtr_OnAndroidIdLoaded;

	// Token: 0x04000C35 RID: 3125
	private static readonly IntPtr NativeFieldInfoPtr_InternalStoragePathLoaded;

	// Token: 0x04000C36 RID: 3126
	private static readonly IntPtr NativeFieldInfoPtr_ExternalStoragePathLoaded;

	// Token: 0x04000C37 RID: 3127
	private static readonly IntPtr NativeFieldInfoPtr_LocaleInfoLoaded;

	// Token: 0x04000C38 RID: 3128
	private static readonly IntPtr NativeFieldInfoPtr_ActionDevicePackagesListLoaded;

	// Token: 0x04000C39 RID: 3129
	private static readonly IntPtr NativeFieldInfoPtr_ActionNetworkInfoLoaded;

	// Token: 0x04000C3A RID: 3130
	private static readonly IntPtr NativeFieldInfoPtr_OnOAuthRefreshTokenLoaded;

	// Token: 0x04000C3B RID: 3131
	private static readonly IntPtr NativeFieldInfoPtr_OnOAuthAccessTokenLoaded;

	// Token: 0x04000C3C RID: 3132
	private static readonly IntPtr NativeFieldInfoPtr_OnDeviceCodeLoaded;

	// Token: 0x04000C3D RID: 3133
	private static readonly IntPtr NativeFieldInfoPtr__redirectUrl;

	// Token: 0x04000C3E RID: 3134
	private static readonly IntPtr NativeFieldInfoPtr__clientId;

	// Token: 0x04000C3F RID: 3135
	private static readonly IntPtr NativeFieldInfoPtr__clientSecret;

	// Token: 0x04000C40 RID: 3136
	private static readonly IntPtr NativeMethodInfoPtr_add_OnPackageCheckResult_Public_Static_add_Void_Action_1_AN_PackageCheckResult_0;

	// Token: 0x04000C41 RID: 3137
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnPackageCheckResult_Public_Static_rem_Void_Action_1_AN_PackageCheckResult_0;

	// Token: 0x04000C42 RID: 3138
	private static readonly IntPtr NativeMethodInfoPtr_add_OnAndroidIdLoaded_Public_Static_add_Void_Action_1_String_0;

	// Token: 0x04000C43 RID: 3139
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnAndroidIdLoaded_Public_Static_rem_Void_Action_1_String_0;

	// Token: 0x04000C44 RID: 3140
	private static readonly IntPtr NativeMethodInfoPtr_add_InternalStoragePathLoaded_Public_Static_add_Void_Action_1_String_0;

	// Token: 0x04000C45 RID: 3141
	private static readonly IntPtr NativeMethodInfoPtr_remove_InternalStoragePathLoaded_Public_Static_rem_Void_Action_1_String_0;

	// Token: 0x04000C46 RID: 3142
	private static readonly IntPtr NativeMethodInfoPtr_add_ExternalStoragePathLoaded_Public_Static_add_Void_Action_1_String_0;

	// Token: 0x04000C47 RID: 3143
	private static readonly IntPtr NativeMethodInfoPtr_remove_ExternalStoragePathLoaded_Public_Static_rem_Void_Action_1_String_0;

	// Token: 0x04000C48 RID: 3144
	private static readonly IntPtr NativeMethodInfoPtr_add_LocaleInfoLoaded_Public_Static_add_Void_Action_1_AN_Locale_0;

	// Token: 0x04000C49 RID: 3145
	private static readonly IntPtr NativeMethodInfoPtr_remove_LocaleInfoLoaded_Public_Static_rem_Void_Action_1_AN_Locale_0;

	// Token: 0x04000C4A RID: 3146
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionDevicePackagesListLoaded_Public_Static_add_Void_Action_1_Il2CppStringArray_0;

	// Token: 0x04000C4B RID: 3147
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionDevicePackagesListLoaded_Public_Static_rem_Void_Action_1_Il2CppStringArray_0;

	// Token: 0x04000C4C RID: 3148
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionNetworkInfoLoaded_Public_Static_add_Void_Action_1_AN_NetworkInfo_0;

	// Token: 0x04000C4D RID: 3149
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionNetworkInfoLoaded_Public_Static_rem_Void_Action_1_AN_NetworkInfo_0;

	// Token: 0x04000C4E RID: 3150
	private static readonly IntPtr NativeMethodInfoPtr_add_OnOAuthRefreshTokenLoaded_Public_Static_add_Void_Action_1_AN_RefreshTokenResult_0;

	// Token: 0x04000C4F RID: 3151
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnOAuthRefreshTokenLoaded_Public_Static_rem_Void_Action_1_AN_RefreshTokenResult_0;

	// Token: 0x04000C50 RID: 3152
	private static readonly IntPtr NativeMethodInfoPtr_add_OnOAuthAccessTokenLoaded_Public_Static_add_Void_Action_1_AN_AccessTokenResult_0;

	// Token: 0x04000C51 RID: 3153
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnOAuthAccessTokenLoaded_Public_Static_rem_Void_Action_1_AN_AccessTokenResult_0;

	// Token: 0x04000C52 RID: 3154
	private static readonly IntPtr NativeMethodInfoPtr_add_OnDeviceCodeLoaded_Public_Static_add_Void_Action_1_AN_DeviceCodeResult_0;

	// Token: 0x04000C53 RID: 3155
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnDeviceCodeLoaded_Public_Static_rem_Void_Action_1_AN_DeviceCodeResult_0;

	// Token: 0x04000C54 RID: 3156
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000C55 RID: 3157
	private static readonly IntPtr NativeMethodInfoPtr_GenerateRefreshToken_Public_Void_String_String_String_0;

	// Token: 0x04000C56 RID: 3158
	private static readonly IntPtr NativeMethodInfoPtr_RefreshOAuthToken_Public_Void_String_String_String_0;

	// Token: 0x04000C57 RID: 3159
	private static readonly IntPtr NativeMethodInfoPtr_ObtainUserDeviceCode_Public_Void_String_0;

	// Token: 0x04000C58 RID: 3160
	private static readonly IntPtr NativeMethodInfoPtr_CheckIsPackageInstalled_Public_Void_String_0;

	// Token: 0x04000C59 RID: 3161
	private static readonly IntPtr NativeMethodInfoPtr_StartApplication_Public_Void_String_0;

	// Token: 0x04000C5A RID: 3162
	private static readonly IntPtr NativeMethodInfoPtr_StartApplication_Public_Void_String_Dictionary_2_String_String_0;

	// Token: 0x04000C5B RID: 3163
	private static readonly IntPtr NativeMethodInfoPtr_LoadAndroidId_Public_Void_0;

	// Token: 0x04000C5C RID: 3164
	private static readonly IntPtr NativeMethodInfoPtr_GetInternalStoragePath_Public_Void_0;

	// Token: 0x04000C5D RID: 3165
	private static readonly IntPtr NativeMethodInfoPtr_GetExternalStoragePath_Public_Void_0;

	// Token: 0x04000C5E RID: 3166
	private static readonly IntPtr NativeMethodInfoPtr_GetExternalStoragePublicDirectory_Public_String_AN_ExternalStorageType_0;

	// Token: 0x04000C5F RID: 3167
	private static readonly IntPtr NativeMethodInfoPtr_LoadLocaleInfo_Public_Void_0;

	// Token: 0x04000C60 RID: 3168
	private static readonly IntPtr NativeMethodInfoPtr_LoadPackagesList_Public_Void_0;

	// Token: 0x04000C61 RID: 3169
	private static readonly IntPtr NativeMethodInfoPtr_LoadNetworkInfo_Public_Void_0;

	// Token: 0x04000C62 RID: 3170
	private static readonly IntPtr NativeMethodInfoPtr_OpenSettingsPage_Public_Static_Void_String_0;

	// Token: 0x04000C63 RID: 3171
	private static readonly IntPtr NativeMethodInfoPtr_ShowPreloader_Public_Static_Void_String_String_0;

	// Token: 0x04000C64 RID: 3172
	private static readonly IntPtr NativeMethodInfoPtr_ShowPreloader_Public_Static_Void_String_String_AndroidDialogTheme_0;

	// Token: 0x04000C65 RID: 3173
	private static readonly IntPtr NativeMethodInfoPtr_HidePreloader_Public_Static_Void_0;

	// Token: 0x04000C66 RID: 3174
	private static readonly IntPtr NativeMethodInfoPtr_OpenAppRatingPage_Public_Static_Void_String_0;

	// Token: 0x04000C67 RID: 3175
	private static readonly IntPtr NativeMethodInfoPtr_RedirectToGooglePlayRatingPage_Public_Static_Void_String_0;

	// Token: 0x04000C68 RID: 3176
	private static readonly IntPtr NativeMethodInfoPtr_HideCurrentPopup_Public_Static_Void_0;

	// Token: 0x04000C69 RID: 3177
	private static readonly IntPtr NativeMethodInfoPtr_get_SDKLevel_Public_Static_get_Int32_0;

	// Token: 0x04000C6A RID: 3178
	private static readonly IntPtr NativeMethodInfoPtr_InvitePlusFriends_Public_Static_Void_0;

	// Token: 0x04000C6B RID: 3179
	private static readonly IntPtr NativeMethodInfoPtr_RefreshTokenCodeReceived_Private_Void_String_0;

	// Token: 0x04000C6C RID: 3180
	private static readonly IntPtr NativeMethodInfoPtr_GenerateRefreshTokenRequest_Private_IEnumerator_String_String_String_String_0;

	// Token: 0x04000C6D RID: 3181
	private static readonly IntPtr NativeMethodInfoPtr_RefreshOAuthTokenRequest_Private_IEnumerator_String_String_String_0;

	// Token: 0x04000C6E RID: 3182
	private static readonly IntPtr NativeMethodInfoPtr_ObtainUserDeviceCodeRequest_Private_IEnumerator_String_0;

	// Token: 0x04000C6F RID: 3183
	private static readonly IntPtr NativeMethodInfoPtr_OnAndroidIdLoadedEvent_Private_Void_String_0;

	// Token: 0x04000C70 RID: 3184
	private static readonly IntPtr NativeMethodInfoPtr_OnPacakgeFound_Private_Void_String_0;

	// Token: 0x04000C71 RID: 3185
	private static readonly IntPtr NativeMethodInfoPtr_OnPacakgeNotFound_Private_Void_String_0;

	// Token: 0x04000C72 RID: 3186
	private static readonly IntPtr NativeMethodInfoPtr_OnExternalStoragePathLoaded_Private_Void_String_0;

	// Token: 0x04000C73 RID: 3187
	private static readonly IntPtr NativeMethodInfoPtr_OnInternalStoragePathLoaded_Private_Void_String_0;

	// Token: 0x04000C74 RID: 3188
	private static readonly IntPtr NativeMethodInfoPtr_OnLocaleInfoLoaded_Private_Void_String_0;

	// Token: 0x04000C75 RID: 3189
	private static readonly IntPtr NativeMethodInfoPtr_OnPackagesListLoaded_Private_Void_String_0;

	// Token: 0x04000C76 RID: 3190
	private static readonly IntPtr NativeMethodInfoPtr_OnNetworkInfoLoaded_Private_Void_String_0;

	// Token: 0x04000C77 RID: 3191
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200038F RID: 911
	[ObfuscatedName("AndroidNativeUtility+<GenerateRefreshTokenRequest>d__58")]
	public sealed class _GenerateRefreshTokenRequest_d__58 : global::Il2CppSystem.Object
	{
		// Token: 0x06003625 RID: 13861 RVA: 0x000DE75C File Offset: 0x000DC95C
		// Note: this type is marked as 'beforefieldinit'.
		static _GenerateRefreshTokenRequest_d__58()
		{
			Il2CppClassPointerStore<AndroidNativeUtility._GenerateRefreshTokenRequest_d__58>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, "<GenerateRefreshTokenRequest>d__58");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidNativeUtility._GenerateRefreshTokenRequest_d__58>.NativeClassPtr);
			AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility._GenerateRefreshTokenRequest_d__58>.NativeClassPtr, "<>1__state");
			AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility._GenerateRefreshTokenRequest_d__58>.NativeClassPtr, "<>2__current");
			AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility._GenerateRefreshTokenRequest_d__58>.NativeClassPtr, "code");
			AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr_clientId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility._GenerateRefreshTokenRequest_d__58>.NativeClassPtr, "clientId");
			AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr_clientSecret = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility._GenerateRefreshTokenRequest_d__58>.NativeClassPtr, "clientSecret");
			AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr_redirectUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility._GenerateRefreshTokenRequest_d__58>.NativeClassPtr, "redirectUrl");
			AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr__response_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility._GenerateRefreshTokenRequest_d__58>.NativeClassPtr, "<response>5__2");
			AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility._GenerateRefreshTokenRequest_d__58>.NativeClassPtr, 100670190);
			AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility._GenerateRefreshTokenRequest_d__58>.NativeClassPtr, 100670191);
			AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility._GenerateRefreshTokenRequest_d__58>.NativeClassPtr, 100670192);
			AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility._GenerateRefreshTokenRequest_d__58>.NativeClassPtr, 100670193);
			AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility._GenerateRefreshTokenRequest_d__58>.NativeClassPtr, 100670194);
			AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility._GenerateRefreshTokenRequest_d__58>.NativeClassPtr, 100670195);
		}

		// Token: 0x06003626 RID: 13862 RVA: 0x000DE88C File Offset: 0x000DCA8C
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _GenerateRefreshTokenRequest_d__58(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidNativeUtility._GenerateRefreshTokenRequest_d__58>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x000DE8D4 File Offset: 0x000DCAD4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003628 RID: 13864 RVA: 0x000DE908 File Offset: 0x000DCB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179622, XrefRangeEnd = 179714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06003629 RID: 13865 RVA: 0x000DE944 File Offset: 0x000DCB44
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x000DE984 File Offset: 0x000DCB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179714, XrefRangeEnd = 179719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x0600362B RID: 13867 RVA: 0x000DE9B8 File Offset: 0x000DCBB8
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x00014FA0 File Offset: 0x000131A0
		public _GenerateRefreshTokenRequest_d__58(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x0600362D RID: 13869 RVA: 0x000DE9F8 File Offset: 0x000DCBF8
		// (set) Token: 0x0600362E RID: 13870 RVA: 0x00014FA9 File Offset: 0x000131A9
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x0600362F RID: 13871 RVA: 0x000DEA20 File Offset: 0x000DCC20
		// (set) Token: 0x06003630 RID: 13872 RVA: 0x00014FC4 File Offset: 0x000131C4
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06003631 RID: 13873 RVA: 0x000DEA50 File Offset: 0x000DCC50
		// (set) Token: 0x06003632 RID: 13874 RVA: 0x00014FE3 File Offset: 0x000131E3
		public unsafe string code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr_code);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06003633 RID: 13875 RVA: 0x000DEA78 File Offset: 0x000DCC78
		// (set) Token: 0x06003634 RID: 13876 RVA: 0x00015002 File Offset: 0x00013202
		public unsafe string clientId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr_clientId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr_clientId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06003635 RID: 13877 RVA: 0x000DEAA0 File Offset: 0x000DCCA0
		// (set) Token: 0x06003636 RID: 13878 RVA: 0x00015021 File Offset: 0x00013221
		public unsafe string clientSecret
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr_clientSecret);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr_clientSecret), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06003637 RID: 13879 RVA: 0x000DEAC8 File Offset: 0x000DCCC8
		// (set) Token: 0x06003638 RID: 13880 RVA: 0x00015040 File Offset: 0x00013240
		public unsafe string redirectUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr_redirectUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr_redirectUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06003639 RID: 13881 RVA: 0x000DEAF0 File Offset: 0x000DCCF0
		// (set) Token: 0x0600363A RID: 13882 RVA: 0x0001505F File Offset: 0x0001325F
		public unsafe WWW _response_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr__response_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WWW>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._GenerateRefreshTokenRequest_d__58.NativeFieldInfoPtr__response_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400319D RID: 12701
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400319E RID: 12702
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400319F RID: 12703
		private static readonly IntPtr NativeFieldInfoPtr_code;

		// Token: 0x040031A0 RID: 12704
		private static readonly IntPtr NativeFieldInfoPtr_clientId;

		// Token: 0x040031A1 RID: 12705
		private static readonly IntPtr NativeFieldInfoPtr_clientSecret;

		// Token: 0x040031A2 RID: 12706
		private static readonly IntPtr NativeFieldInfoPtr_redirectUrl;

		// Token: 0x040031A3 RID: 12707
		private static readonly IntPtr NativeFieldInfoPtr__response_5__2;

		// Token: 0x040031A4 RID: 12708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040031A5 RID: 12709
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040031A6 RID: 12710
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040031A7 RID: 12711
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040031A8 RID: 12712
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040031A9 RID: 12713
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000390 RID: 912
	[ObfuscatedName("AndroidNativeUtility+<RefreshOAuthTokenRequest>d__59")]
	public sealed class _RefreshOAuthTokenRequest_d__59 : global::Il2CppSystem.Object
	{
		// Token: 0x0600363B RID: 13883 RVA: 0x000DEB20 File Offset: 0x000DCD20
		// Note: this type is marked as 'beforefieldinit'.
		static _RefreshOAuthTokenRequest_d__59()
		{
			Il2CppClassPointerStore<AndroidNativeUtility._RefreshOAuthTokenRequest_d__59>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, "<RefreshOAuthTokenRequest>d__59");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidNativeUtility._RefreshOAuthTokenRequest_d__59>.NativeClassPtr);
			AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility._RefreshOAuthTokenRequest_d__59>.NativeClassPtr, "<>1__state");
			AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility._RefreshOAuthTokenRequest_d__59>.NativeClassPtr, "<>2__current");
			AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeFieldInfoPtr_clientId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility._RefreshOAuthTokenRequest_d__59>.NativeClassPtr, "clientId");
			AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeFieldInfoPtr_clientSecret = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility._RefreshOAuthTokenRequest_d__59>.NativeClassPtr, "clientSecret");
			AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeFieldInfoPtr_refreshToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility._RefreshOAuthTokenRequest_d__59>.NativeClassPtr, "refreshToken");
			AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeFieldInfoPtr__response_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility._RefreshOAuthTokenRequest_d__59>.NativeClassPtr, "<response>5__2");
			AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility._RefreshOAuthTokenRequest_d__59>.NativeClassPtr, 100670196);
			AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility._RefreshOAuthTokenRequest_d__59>.NativeClassPtr, 100670197);
			AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility._RefreshOAuthTokenRequest_d__59>.NativeClassPtr, 100670198);
			AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility._RefreshOAuthTokenRequest_d__59>.NativeClassPtr, 100670199);
			AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility._RefreshOAuthTokenRequest_d__59>.NativeClassPtr, 100670200);
			AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility._RefreshOAuthTokenRequest_d__59>.NativeClassPtr, 100670201);
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x000DEC3C File Offset: 0x000DCE3C
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _RefreshOAuthTokenRequest_d__59(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidNativeUtility._RefreshOAuthTokenRequest_d__59>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x000DEC84 File Offset: 0x000DCE84
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x000DECB8 File Offset: 0x000DCEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179719, XrefRangeEnd = 179798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x0600363F RID: 13887 RVA: 0x000DECF4 File Offset: 0x000DCEF4
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x000DED34 File Offset: 0x000DCF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179798, XrefRangeEnd = 179803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06003641 RID: 13889 RVA: 0x000DED68 File Offset: 0x000DCF68
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x0001507E File Offset: 0x0001327E
		public _RefreshOAuthTokenRequest_d__59(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06003643 RID: 13891 RVA: 0x000DEDA8 File Offset: 0x000DCFA8
		// (set) Token: 0x06003644 RID: 13892 RVA: 0x00015087 File Offset: 0x00013287
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06003645 RID: 13893 RVA: 0x000DEDD0 File Offset: 0x000DCFD0
		// (set) Token: 0x06003646 RID: 13894 RVA: 0x000150A2 File Offset: 0x000132A2
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06003647 RID: 13895 RVA: 0x000DEE00 File Offset: 0x000DD000
		// (set) Token: 0x06003648 RID: 13896 RVA: 0x000150C1 File Offset: 0x000132C1
		public unsafe string clientId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeFieldInfoPtr_clientId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeFieldInfoPtr_clientId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06003649 RID: 13897 RVA: 0x000DEE28 File Offset: 0x000DD028
		// (set) Token: 0x0600364A RID: 13898 RVA: 0x000150E0 File Offset: 0x000132E0
		public unsafe string clientSecret
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeFieldInfoPtr_clientSecret);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeFieldInfoPtr_clientSecret), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x0600364B RID: 13899 RVA: 0x000DEE50 File Offset: 0x000DD050
		// (set) Token: 0x0600364C RID: 13900 RVA: 0x000150FF File Offset: 0x000132FF
		public unsafe string refreshToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeFieldInfoPtr_refreshToken);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeFieldInfoPtr_refreshToken), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x0600364D RID: 13901 RVA: 0x000DEE78 File Offset: 0x000DD078
		// (set) Token: 0x0600364E RID: 13902 RVA: 0x0001511E File Offset: 0x0001331E
		public unsafe WWW _response_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeFieldInfoPtr__response_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WWW>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._RefreshOAuthTokenRequest_d__59.NativeFieldInfoPtr__response_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031AA RID: 12714
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040031AB RID: 12715
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040031AC RID: 12716
		private static readonly IntPtr NativeFieldInfoPtr_clientId;

		// Token: 0x040031AD RID: 12717
		private static readonly IntPtr NativeFieldInfoPtr_clientSecret;

		// Token: 0x040031AE RID: 12718
		private static readonly IntPtr NativeFieldInfoPtr_refreshToken;

		// Token: 0x040031AF RID: 12719
		private static readonly IntPtr NativeFieldInfoPtr__response_5__2;

		// Token: 0x040031B0 RID: 12720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040031B1 RID: 12721
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040031B2 RID: 12722
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040031B3 RID: 12723
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040031B4 RID: 12724
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040031B5 RID: 12725
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000391 RID: 913
	[ObfuscatedName("AndroidNativeUtility+<ObtainUserDeviceCodeRequest>d__60")]
	public sealed class _ObtainUserDeviceCodeRequest_d__60 : global::Il2CppSystem.Object
	{
		// Token: 0x0600364F RID: 13903 RVA: 0x000DEEA8 File Offset: 0x000DD0A8
		// Note: this type is marked as 'beforefieldinit'.
		static _ObtainUserDeviceCodeRequest_d__60()
		{
			Il2CppClassPointerStore<AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, "<ObtainUserDeviceCodeRequest>d__60");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60>.NativeClassPtr);
			AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60>.NativeClassPtr, "<>1__state");
			AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60>.NativeClassPtr, "<>2__current");
			AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeFieldInfoPtr_clientId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60>.NativeClassPtr, "clientId");
			AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeFieldInfoPtr__response_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60>.NativeClassPtr, "<response>5__2");
			AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60>.NativeClassPtr, 100670202);
			AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60>.NativeClassPtr, 100670203);
			AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60>.NativeClassPtr, 100670204);
			AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60>.NativeClassPtr, 100670205);
			AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60>.NativeClassPtr, 100670206);
			AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60>.NativeClassPtr, 100670207);
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x000DEF9C File Offset: 0x000DD19C
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ObtainUserDeviceCodeRequest_d__60(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x000DEFE4 File Offset: 0x000DD1E4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x000DF018 File Offset: 0x000DD218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179803, XrefRangeEnd = 179901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x06003653 RID: 13907 RVA: 0x000DF054 File Offset: 0x000DD254
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x000DF094 File Offset: 0x000DD294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179901, XrefRangeEnd = 179906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06003655 RID: 13909 RVA: 0x000DF0C8 File Offset: 0x000DD2C8
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x0001513D File Offset: 0x0001333D
		public _ObtainUserDeviceCodeRequest_d__60(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06003657 RID: 13911 RVA: 0x000DF108 File Offset: 0x000DD308
		// (set) Token: 0x06003658 RID: 13912 RVA: 0x00015146 File Offset: 0x00013346
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06003659 RID: 13913 RVA: 0x000DF130 File Offset: 0x000DD330
		// (set) Token: 0x0600365A RID: 13914 RVA: 0x00015161 File Offset: 0x00013361
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x0600365B RID: 13915 RVA: 0x000DF160 File Offset: 0x000DD360
		// (set) Token: 0x0600365C RID: 13916 RVA: 0x00015180 File Offset: 0x00013380
		public unsafe string clientId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeFieldInfoPtr_clientId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeFieldInfoPtr_clientId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x0600365D RID: 13917 RVA: 0x000DF188 File Offset: 0x000DD388
		// (set) Token: 0x0600365E RID: 13918 RVA: 0x0001519F File Offset: 0x0001339F
		public unsafe WWW _response_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeFieldInfoPtr__response_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WWW>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidNativeUtility._ObtainUserDeviceCodeRequest_d__60.NativeFieldInfoPtr__response_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031B6 RID: 12726
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040031B7 RID: 12727
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040031B8 RID: 12728
		private static readonly IntPtr NativeFieldInfoPtr_clientId;

		// Token: 0x040031B9 RID: 12729
		private static readonly IntPtr NativeFieldInfoPtr__response_5__2;

		// Token: 0x040031BA RID: 12730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040031BB RID: 12731
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040031BC RID: 12732
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040031BD RID: 12733
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040031BE RID: 12734
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040031BF RID: 12735
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000392 RID: 914
	[ObfuscatedName("AndroidNativeUtility+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x0600365F RID: 13919 RVA: 0x000DF1B8 File Offset: 0x000DD3B8
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AndroidNativeUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidNativeUtility>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidNativeUtility.__c>.NativeClassPtr);
			AndroidNativeUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNativeUtility.__c>.NativeClassPtr, "<>9");
			AndroidNativeUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility.__c>.NativeClassPtr, 100670209);
			AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_0_Internal_Void_AN_PackageCheckResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility.__c>.NativeClassPtr, 100670210);
			AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_1_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility.__c>.NativeClassPtr, 100670211);
			AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_2_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility.__c>.NativeClassPtr, 100670212);
			AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_3_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility.__c>.NativeClassPtr, 100670213);
			AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_4_Internal_Void_AN_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility.__c>.NativeClassPtr, 100670214);
			AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_5_Internal_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility.__c>.NativeClassPtr, 100670215);
			AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_6_Internal_Void_AN_NetworkInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility.__c>.NativeClassPtr, 100670216);
			AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_7_Internal_Void_AN_RefreshTokenResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility.__c>.NativeClassPtr, 100670217);
			AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_8_Internal_Void_AN_AccessTokenResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility.__c>.NativeClassPtr, 100670218);
			AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_9_Internal_Void_AN_DeviceCodeResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeUtility.__c>.NativeClassPtr, 100670219);
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x000DF2D4 File Offset: 0x000DD4D4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidNativeUtility.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x000DF310 File Offset: 0x000DD510
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__70_0(AN_PackageCheckResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_0_Internal_Void_AN_PackageCheckResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003662 RID: 13922 RVA: 0x000DF354 File Offset: 0x000DD554
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__70_1(string <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_1_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x000DF398 File Offset: 0x000DD598
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__70_2(string <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_2_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x000DF3DC File Offset: 0x000DD5DC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__70_3(string <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_3_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x000DF420 File Offset: 0x000DD620
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__70_4(AN_Locale <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_4_Internal_Void_AN_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x000DF464 File Offset: 0x000DD664
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__70_5(Il2CppStringArray <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_5_Internal_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x000DF4A8 File Offset: 0x000DD6A8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__70_6(AN_NetworkInfo <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_6_Internal_Void_AN_NetworkInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x000DF4EC File Offset: 0x000DD6EC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__70_7(AN_RefreshTokenResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_7_Internal_Void_AN_RefreshTokenResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x000DF530 File Offset: 0x000DD730
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__70_8(AN_AccessTokenResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_8_Internal_Void_AN_AccessTokenResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x000DF574 File Offset: 0x000DD774
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__70_9(AN_DeviceCodeResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeUtility.__c.NativeMethodInfoPtr___cctor_b__70_9_Internal_Void_AN_DeviceCodeResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x000151BE File Offset: 0x000133BE
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x0600366C RID: 13932 RVA: 0x000DF5B8 File Offset: 0x000DD7B8
		// (set) Token: 0x0600366D RID: 13933 RVA: 0x000151C7 File Offset: 0x000133C7
		public unsafe static AndroidNativeUtility.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidNativeUtility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidNativeUtility.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidNativeUtility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031C0 RID: 12736
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040031C1 RID: 12737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040031C2 RID: 12738
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__70_0_Internal_Void_AN_PackageCheckResult_0;

		// Token: 0x040031C3 RID: 12739
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__70_1_Internal_Void_String_0;

		// Token: 0x040031C4 RID: 12740
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__70_2_Internal_Void_String_0;

		// Token: 0x040031C5 RID: 12741
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__70_3_Internal_Void_String_0;

		// Token: 0x040031C6 RID: 12742
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__70_4_Internal_Void_AN_Locale_0;

		// Token: 0x040031C7 RID: 12743
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__70_5_Internal_Void_Il2CppStringArray_0;

		// Token: 0x040031C8 RID: 12744
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__70_6_Internal_Void_AN_NetworkInfo_0;

		// Token: 0x040031C9 RID: 12745
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__70_7_Internal_Void_AN_RefreshTokenResult_0;

		// Token: 0x040031CA RID: 12746
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__70_8_Internal_Void_AN_AccessTokenResult_0;

		// Token: 0x040031CB RID: 12747
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__70_9_Internal_Void_AN_DeviceCodeResult_0;
	}
}

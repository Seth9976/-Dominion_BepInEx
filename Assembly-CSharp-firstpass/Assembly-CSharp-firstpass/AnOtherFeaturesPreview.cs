using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x0200011E RID: 286
public class AnOtherFeaturesPreview : MonoBehaviour
{
	// Token: 0x060013A4 RID: 5028 RVA: 0x0005AB34 File Offset: 0x00058D34
	// Note: this type is marked as 'beforefieldinit'.
	static AnOtherFeaturesPreview()
	{
		Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AnOtherFeaturesPreview");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr);
		AnOtherFeaturesPreview.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, "image");
		AnOtherFeaturesPreview.NativeFieldInfoPtr_helloWorldTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, "helloWorldTexture");
		AnOtherFeaturesPreview.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665651);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_SaveToGalalry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665652);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_SaveScreenshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665653);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_GetImageFromGallery_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665654);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_GetImageFromCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665655);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_CheckForTV_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665656);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_LoadNetworkInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665657);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_HandleActionNetworkInfoLoaded_Private_Void_AN_NetworkInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665658);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_CheckAppInstalation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665659);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_RunApp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665660);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_CheckAppLicense_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665661);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_LicenseRequestResult_Private_Void_AN_LicenseRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665662);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_EnableImmersiveMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665663);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_GetAndroidId_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665664);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_OnAndroidIdLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665665);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_LoadAppInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665666);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_LoadAdressBook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665667);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_OnDeviceTypeChecked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665668);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_OnPackageCheckResult_Private_Void_AN_PackageCheckResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665669);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_OnContactsLoaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665670);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_OnImagePicked_Private_Void_AndroidImagePickResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665671);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_OnImageSaved_Private_Void_GallerySaveResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665672);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_OnPackageInfoLoaded_Private_Void_PackageAppInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665673);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_LoadInternal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665674);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_LoadExternal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665675);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_LoadLocaleInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665676);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_LocaleInfoLoaded_Private_Void_AN_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665677);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_ExternalStoragePathLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665678);
		AnOtherFeaturesPreview.NativeMethodInfoPtr_InternalStoragePathLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665679);
		AnOtherFeaturesPreview.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr, 100665680);
	}

	// Token: 0x060013A5 RID: 5029 RVA: 0x0005ADE4 File Offset: 0x00058FE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184856, XrefRangeEnd = 184876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013A6 RID: 5030 RVA: 0x0005AE18 File Offset: 0x00059018
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184876, XrefRangeEnd = 184902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveToGalalry()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_SaveToGalalry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013A7 RID: 5031 RVA: 0x0005AE4C File Offset: 0x0005904C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184902, XrefRangeEnd = 184940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveScreenshot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_SaveScreenshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013A8 RID: 5032 RVA: 0x0005AE80 File Offset: 0x00059080
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184940, XrefRangeEnd = 184959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetImageFromGallery()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_GetImageFromGallery_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013A9 RID: 5033 RVA: 0x0005AEB4 File Offset: 0x000590B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184959, XrefRangeEnd = 184982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetImageFromCamera()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_GetImageFromCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013AA RID: 5034 RVA: 0x0005AEE8 File Offset: 0x000590E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184982, XrefRangeEnd = 185000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckForTV()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_CheckForTV_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013AB RID: 5035 RVA: 0x0005AF1C File Offset: 0x0005911C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadNetworkInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_LoadNetworkInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013AC RID: 5036 RVA: 0x0005AF50 File Offset: 0x00059150
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185000, XrefRangeEnd = 185050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleActionNetworkInfoLoaded(AN_NetworkInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_HandleActionNetworkInfoLoaded_Private_Void_AN_NetworkInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013AD RID: 5037 RVA: 0x0005AF94 File Offset: 0x00059194
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185050, XrefRangeEnd = 185072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckAppInstalation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_CheckAppInstalation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013AE RID: 5038 RVA: 0x0005AFC8 File Offset: 0x000591C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185072, XrefRangeEnd = 185078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RunApp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_RunApp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013AF RID: 5039 RVA: 0x0005AFFC File Offset: 0x000591FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185078, XrefRangeEnd = 185109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckAppLicense()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_CheckAppLicense_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013B0 RID: 5040 RVA: 0x0005B030 File Offset: 0x00059230
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185109, XrefRangeEnd = 185129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LicenseRequestResult(AN_LicenseRequestResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_LicenseRequestResult_Private_Void_AN_LicenseRequestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013B1 RID: 5041 RVA: 0x0005B074 File Offset: 0x00059274
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185129, XrefRangeEnd = 185137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableImmersiveMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_EnableImmersiveMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013B2 RID: 5042 RVA: 0x0005B0A8 File Offset: 0x000592A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185137, XrefRangeEnd = 185157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetAndroidId()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_GetAndroidId_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013B3 RID: 5043 RVA: 0x0005B0DC File Offset: 0x000592DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185157, XrefRangeEnd = 185172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAndroidIdLoaded(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_OnAndroidIdLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013B4 RID: 5044 RVA: 0x0005B120 File Offset: 0x00059320
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185172, XrefRangeEnd = 185204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAppInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_LoadAppInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013B5 RID: 5045 RVA: 0x0005B154 File Offset: 0x00059354
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185204, XrefRangeEnd = 185222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAdressBook()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_LoadAdressBook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013B6 RID: 5046 RVA: 0x0005B188 File Offset: 0x00059388
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185222, XrefRangeEnd = 185244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDeviceTypeChecked()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_OnDeviceTypeChecked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013B7 RID: 5047 RVA: 0x0005B1BC File Offset: 0x000593BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185244, XrefRangeEnd = 185270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPackageCheckResult(AN_PackageCheckResult res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_OnPackageCheckResult_Private_Void_AN_PackageCheckResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013B8 RID: 5048 RVA: 0x0005B200 File Offset: 0x00059400
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185270, XrefRangeEnd = 185298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnContactsLoaded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_OnContactsLoaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013B9 RID: 5049 RVA: 0x0005B234 File Offset: 0x00059434
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185298, XrefRangeEnd = 185342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnImagePicked(AndroidImagePickResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_OnImagePicked_Private_Void_AndroidImagePickResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013BA RID: 5050 RVA: 0x0005B278 File Offset: 0x00059478
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185342, XrefRangeEnd = 185383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnImageSaved(GallerySaveResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_OnImageSaved_Private_Void_GallerySaveResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013BB RID: 5051 RVA: 0x0005B2BC File Offset: 0x000594BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185383, XrefRangeEnd = 185441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPackageInfoLoaded(PackageAppInfo PacakgeInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PacakgeInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_OnPackageInfoLoaded_Private_Void_PackageAppInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013BC RID: 5052 RVA: 0x0005B300 File Offset: 0x00059500
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185441, XrefRangeEnd = 185461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadInternal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_LoadInternal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013BD RID: 5053 RVA: 0x0005B334 File Offset: 0x00059534
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185461, XrefRangeEnd = 185481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadExternal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_LoadExternal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013BE RID: 5054 RVA: 0x0005B368 File Offset: 0x00059568
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185481, XrefRangeEnd = 185501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadLocaleInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_LoadLocaleInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013BF RID: 5055 RVA: 0x0005B39C File Offset: 0x0005959C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185501, XrefRangeEnd = 185566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LocaleInfoLoaded(AN_Locale locale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_LocaleInfoLoaded_Private_Void_AN_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013C0 RID: 5056 RVA: 0x0005B3E0 File Offset: 0x000595E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185566, XrefRangeEnd = 185583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExternalStoragePathLoaded(string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_ExternalStoragePathLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013C1 RID: 5057 RVA: 0x0005B424 File Offset: 0x00059624
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185583, XrefRangeEnd = 185600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalStoragePathLoaded(string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr_InternalStoragePathLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013C2 RID: 5058 RVA: 0x0005B468 File Offset: 0x00059668
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnOtherFeaturesPreview()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnOtherFeaturesPreview>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnOtherFeaturesPreview.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013C3 RID: 5059 RVA: 0x00009BA6 File Offset: 0x00007DA6
	public AnOtherFeaturesPreview(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005C0 RID: 1472
	// (get) Token: 0x060013C4 RID: 5060 RVA: 0x0005B4A4 File Offset: 0x000596A4
	// (set) Token: 0x060013C5 RID: 5061 RVA: 0x00009BAF File Offset: 0x00007DAF
	public unsafe GameObject image
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnOtherFeaturesPreview.NativeFieldInfoPtr_image);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnOtherFeaturesPreview.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005C1 RID: 1473
	// (get) Token: 0x060013C6 RID: 5062 RVA: 0x0005B4D4 File Offset: 0x000596D4
	// (set) Token: 0x060013C7 RID: 5063 RVA: 0x00009BCE File Offset: 0x00007DCE
	public unsafe Texture2D helloWorldTexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnOtherFeaturesPreview.NativeFieldInfoPtr_helloWorldTexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnOtherFeaturesPreview.NativeFieldInfoPtr_helloWorldTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000EF6 RID: 3830
	private static readonly IntPtr NativeFieldInfoPtr_image;

	// Token: 0x04000EF7 RID: 3831
	private static readonly IntPtr NativeFieldInfoPtr_helloWorldTexture;

	// Token: 0x04000EF8 RID: 3832
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000EF9 RID: 3833
	private static readonly IntPtr NativeMethodInfoPtr_SaveToGalalry_Public_Void_0;

	// Token: 0x04000EFA RID: 3834
	private static readonly IntPtr NativeMethodInfoPtr_SaveScreenshot_Public_Void_0;

	// Token: 0x04000EFB RID: 3835
	private static readonly IntPtr NativeMethodInfoPtr_GetImageFromGallery_Public_Void_0;

	// Token: 0x04000EFC RID: 3836
	private static readonly IntPtr NativeMethodInfoPtr_GetImageFromCamera_Public_Void_0;

	// Token: 0x04000EFD RID: 3837
	private static readonly IntPtr NativeMethodInfoPtr_CheckForTV_Public_Void_0;

	// Token: 0x04000EFE RID: 3838
	private static readonly IntPtr NativeMethodInfoPtr_LoadNetworkInfo_Public_Void_0;

	// Token: 0x04000EFF RID: 3839
	private static readonly IntPtr NativeMethodInfoPtr_HandleActionNetworkInfoLoaded_Private_Void_AN_NetworkInfo_0;

	// Token: 0x04000F00 RID: 3840
	private static readonly IntPtr NativeMethodInfoPtr_CheckAppInstalation_Public_Void_0;

	// Token: 0x04000F01 RID: 3841
	private static readonly IntPtr NativeMethodInfoPtr_RunApp_Public_Void_0;

	// Token: 0x04000F02 RID: 3842
	private static readonly IntPtr NativeMethodInfoPtr_CheckAppLicense_Public_Void_0;

	// Token: 0x04000F03 RID: 3843
	private static readonly IntPtr NativeMethodInfoPtr_LicenseRequestResult_Private_Void_AN_LicenseRequestResult_0;

	// Token: 0x04000F04 RID: 3844
	private static readonly IntPtr NativeMethodInfoPtr_EnableImmersiveMode_Private_Void_0;

	// Token: 0x04000F05 RID: 3845
	private static readonly IntPtr NativeMethodInfoPtr_GetAndroidId_Public_Void_0;

	// Token: 0x04000F06 RID: 3846
	private static readonly IntPtr NativeMethodInfoPtr_OnAndroidIdLoaded_Private_Void_String_0;

	// Token: 0x04000F07 RID: 3847
	private static readonly IntPtr NativeMethodInfoPtr_LoadAppInfo_Private_Void_0;

	// Token: 0x04000F08 RID: 3848
	private static readonly IntPtr NativeMethodInfoPtr_LoadAdressBook_Private_Void_0;

	// Token: 0x04000F09 RID: 3849
	private static readonly IntPtr NativeMethodInfoPtr_OnDeviceTypeChecked_Private_Void_0;

	// Token: 0x04000F0A RID: 3850
	private static readonly IntPtr NativeMethodInfoPtr_OnPackageCheckResult_Private_Void_AN_PackageCheckResult_0;

	// Token: 0x04000F0B RID: 3851
	private static readonly IntPtr NativeMethodInfoPtr_OnContactsLoaded_Private_Void_0;

	// Token: 0x04000F0C RID: 3852
	private static readonly IntPtr NativeMethodInfoPtr_OnImagePicked_Private_Void_AndroidImagePickResult_0;

	// Token: 0x04000F0D RID: 3853
	private static readonly IntPtr NativeMethodInfoPtr_OnImageSaved_Private_Void_GallerySaveResult_0;

	// Token: 0x04000F0E RID: 3854
	private static readonly IntPtr NativeMethodInfoPtr_OnPackageInfoLoaded_Private_Void_PackageAppInfo_0;

	// Token: 0x04000F0F RID: 3855
	private static readonly IntPtr NativeMethodInfoPtr_LoadInternal_Public_Void_0;

	// Token: 0x04000F10 RID: 3856
	private static readonly IntPtr NativeMethodInfoPtr_LoadExternal_Public_Void_0;

	// Token: 0x04000F11 RID: 3857
	private static readonly IntPtr NativeMethodInfoPtr_LoadLocaleInfo_Public_Void_0;

	// Token: 0x04000F12 RID: 3858
	private static readonly IntPtr NativeMethodInfoPtr_LocaleInfoLoaded_Private_Void_AN_Locale_0;

	// Token: 0x04000F13 RID: 3859
	private static readonly IntPtr NativeMethodInfoPtr_ExternalStoragePathLoaded_Private_Void_String_0;

	// Token: 0x04000F14 RID: 3860
	private static readonly IntPtr NativeMethodInfoPtr_InternalStoragePathLoaded_Private_Void_String_0;

	// Token: 0x04000F15 RID: 3861
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000121 RID: 289
public class NativeApiTab : FeatureTab
{
	// Token: 0x060013E4 RID: 5092 RVA: 0x0005BB68 File Offset: 0x00059D68
	// Note: this type is marked as 'beforefieldinit'.
	static NativeApiTab()
	{
		Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "NativeApiTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr);
		NativeApiTab.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, "image");
		NativeApiTab.NativeFieldInfoPtr_helloWorldTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, "helloWorldTexture");
		NativeApiTab.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665699);
		NativeApiTab.NativeMethodInfoPtr_SaveToGalalry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665700);
		NativeApiTab.NativeMethodInfoPtr_SaveScreenshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665701);
		NativeApiTab.NativeMethodInfoPtr_GetImageFromGallery_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665702);
		NativeApiTab.NativeMethodInfoPtr_GetImageFromCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665703);
		NativeApiTab.NativeMethodInfoPtr_CheckForTV_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665704);
		NativeApiTab.NativeMethodInfoPtr_LoadNetworkInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665705);
		NativeApiTab.NativeMethodInfoPtr_HandleActionNetworkInfoLoaded_Private_Void_AN_NetworkInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665706);
		NativeApiTab.NativeMethodInfoPtr_CheckAppInstalation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665707);
		NativeApiTab.NativeMethodInfoPtr_RunApp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665708);
		NativeApiTab.NativeMethodInfoPtr_CheckAppLicense_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665709);
		NativeApiTab.NativeMethodInfoPtr_LicenseRequestResult_Private_Void_AN_LicenseRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665710);
		NativeApiTab.NativeMethodInfoPtr_EnableImmersiveMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665711);
		NativeApiTab.NativeMethodInfoPtr_GetAndroidId_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665712);
		NativeApiTab.NativeMethodInfoPtr_OnAndroidIdLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665713);
		NativeApiTab.NativeMethodInfoPtr_LoadAppInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665714);
		NativeApiTab.NativeMethodInfoPtr_LoadAdressBook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665715);
		NativeApiTab.NativeMethodInfoPtr_OnDeviceTypeChecked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665716);
		NativeApiTab.NativeMethodInfoPtr_OnPackageCheckResult_Private_Void_AN_PackageCheckResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665717);
		NativeApiTab.NativeMethodInfoPtr_OnContactsLoaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665718);
		NativeApiTab.NativeMethodInfoPtr_OnImagePicked_Private_Void_AndroidImagePickResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665719);
		NativeApiTab.NativeMethodInfoPtr_OnImageSaved_Private_Void_GallerySaveResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665720);
		NativeApiTab.NativeMethodInfoPtr_OnPackageInfoLoaded_Private_Void_PackageAppInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665721);
		NativeApiTab.NativeMethodInfoPtr_LoadInternal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665722);
		NativeApiTab.NativeMethodInfoPtr_LoadExternal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665723);
		NativeApiTab.NativeMethodInfoPtr_LoadLocaleInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665724);
		NativeApiTab.NativeMethodInfoPtr_LocaleInfoLoaded_Private_Void_AN_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665725);
		NativeApiTab.NativeMethodInfoPtr_ExternalStoragePathLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665726);
		NativeApiTab.NativeMethodInfoPtr_InternalStoragePathLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665727);
		NativeApiTab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr, 100665728);
	}

	// Token: 0x060013E5 RID: 5093 RVA: 0x0005BE18 File Offset: 0x0005A018
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185866, XrefRangeEnd = 185886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013E6 RID: 5094 RVA: 0x0005BE4C File Offset: 0x0005A04C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185886, XrefRangeEnd = 185912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveToGalalry()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_SaveToGalalry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013E7 RID: 5095 RVA: 0x0005BE80 File Offset: 0x0005A080
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185912, XrefRangeEnd = 185938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveScreenshot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_SaveScreenshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013E8 RID: 5096 RVA: 0x0005BEB4 File Offset: 0x0005A0B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185938, XrefRangeEnd = 185957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetImageFromGallery()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_GetImageFromGallery_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013E9 RID: 5097 RVA: 0x0005BEE8 File Offset: 0x0005A0E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185957, XrefRangeEnd = 185976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetImageFromCamera()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_GetImageFromCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013EA RID: 5098 RVA: 0x0005BF1C File Offset: 0x0005A11C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185976, XrefRangeEnd = 185994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckForTV()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_CheckForTV_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x0005BF50 File Offset: 0x0005A150
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadNetworkInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_LoadNetworkInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013EC RID: 5100 RVA: 0x0005BF84 File Offset: 0x0005A184
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185994, XrefRangeEnd = 186044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleActionNetworkInfoLoaded(AN_NetworkInfo info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_HandleActionNetworkInfoLoaded_Private_Void_AN_NetworkInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013ED RID: 5101 RVA: 0x0005BFC8 File Offset: 0x0005A1C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186044, XrefRangeEnd = 186066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckAppInstalation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_CheckAppInstalation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013EE RID: 5102 RVA: 0x0005BFFC File Offset: 0x0005A1FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186066, XrefRangeEnd = 186072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RunApp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_RunApp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013EF RID: 5103 RVA: 0x0005C030 File Offset: 0x0005A230
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186072, XrefRangeEnd = 186103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckAppLicense()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_CheckAppLicense_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013F0 RID: 5104 RVA: 0x0005C064 File Offset: 0x0005A264
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186103, XrefRangeEnd = 186123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LicenseRequestResult(AN_LicenseRequestResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_LicenseRequestResult_Private_Void_AN_LicenseRequestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013F1 RID: 5105 RVA: 0x0005C0A8 File Offset: 0x0005A2A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186123, XrefRangeEnd = 186131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableImmersiveMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_EnableImmersiveMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013F2 RID: 5106 RVA: 0x0005C0DC File Offset: 0x0005A2DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186131, XrefRangeEnd = 186151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetAndroidId()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_GetAndroidId_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013F3 RID: 5107 RVA: 0x0005C110 File Offset: 0x0005A310
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186151, XrefRangeEnd = 186166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAndroidIdLoaded(string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_OnAndroidIdLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013F4 RID: 5108 RVA: 0x0005C154 File Offset: 0x0005A354
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186166, XrefRangeEnd = 186186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAppInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_LoadAppInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013F5 RID: 5109 RVA: 0x0005C188 File Offset: 0x0005A388
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186186, XrefRangeEnd = 186204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadAdressBook()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_LoadAdressBook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013F6 RID: 5110 RVA: 0x0005C1BC File Offset: 0x0005A3BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186204, XrefRangeEnd = 186224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDeviceTypeChecked()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_OnDeviceTypeChecked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013F7 RID: 5111 RVA: 0x0005C1F0 File Offset: 0x0005A3F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186224, XrefRangeEnd = 186247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPackageCheckResult(AN_PackageCheckResult res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_OnPackageCheckResult_Private_Void_AN_PackageCheckResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013F8 RID: 5112 RVA: 0x0005C234 File Offset: 0x0005A434
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186247, XrefRangeEnd = 186273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnContactsLoaded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_OnContactsLoaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013F9 RID: 5113 RVA: 0x0005C268 File Offset: 0x0005A468
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186273, XrefRangeEnd = 186311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnImagePicked(AndroidImagePickResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_OnImagePicked_Private_Void_AndroidImagePickResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013FA RID: 5114 RVA: 0x0005C2AC File Offset: 0x0005A4AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186311, XrefRangeEnd = 186343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnImageSaved(GallerySaveResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_OnImageSaved_Private_Void_GallerySaveResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013FB RID: 5115 RVA: 0x0005C2F0 File Offset: 0x0005A4F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186343, XrefRangeEnd = 186389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPackageInfoLoaded(PackageAppInfo PacakgeInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PacakgeInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_OnPackageInfoLoaded_Private_Void_PackageAppInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013FC RID: 5116 RVA: 0x0005C334 File Offset: 0x0005A534
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186389, XrefRangeEnd = 186409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadInternal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_LoadInternal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013FD RID: 5117 RVA: 0x0005C368 File Offset: 0x0005A568
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186409, XrefRangeEnd = 186429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadExternal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_LoadExternal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013FE RID: 5118 RVA: 0x0005C39C File Offset: 0x0005A59C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186429, XrefRangeEnd = 186449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadLocaleInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_LoadLocaleInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013FF RID: 5119 RVA: 0x0005C3D0 File Offset: 0x0005A5D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186449, XrefRangeEnd = 186512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LocaleInfoLoaded(AN_Locale locale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(locale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_LocaleInfoLoaded_Private_Void_AN_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001400 RID: 5120 RVA: 0x0005C414 File Offset: 0x0005A614
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186512, XrefRangeEnd = 186527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExternalStoragePathLoaded(string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_ExternalStoragePathLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001401 RID: 5121 RVA: 0x0005C458 File Offset: 0x0005A658
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186527, XrefRangeEnd = 186542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalStoragePathLoaded(string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr_InternalStoragePathLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001402 RID: 5122 RVA: 0x0005C49C File Offset: 0x0005A69C
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114494, XrefRangeEnd = 114502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeApiTab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeApiTab>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeApiTab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001403 RID: 5123 RVA: 0x00009C5C File Offset: 0x00007E5C
	public NativeApiTab(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005C5 RID: 1477
	// (get) Token: 0x06001404 RID: 5124 RVA: 0x0005C4D8 File Offset: 0x0005A6D8
	// (set) Token: 0x06001405 RID: 5125 RVA: 0x00009C65 File Offset: 0x00007E65
	public unsafe Image image
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeApiTab.NativeFieldInfoPtr_image);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeApiTab.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005C6 RID: 1478
	// (get) Token: 0x06001406 RID: 5126 RVA: 0x0005C508 File Offset: 0x0005A708
	// (set) Token: 0x06001407 RID: 5127 RVA: 0x00009C84 File Offset: 0x00007E84
	public unsafe Texture2D helloWorldTexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeApiTab.NativeFieldInfoPtr_helloWorldTexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeApiTab.NativeFieldInfoPtr_helloWorldTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000F2B RID: 3883
	private static readonly IntPtr NativeFieldInfoPtr_image;

	// Token: 0x04000F2C RID: 3884
	private static readonly IntPtr NativeFieldInfoPtr_helloWorldTexture;

	// Token: 0x04000F2D RID: 3885
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000F2E RID: 3886
	private static readonly IntPtr NativeMethodInfoPtr_SaveToGalalry_Public_Void_0;

	// Token: 0x04000F2F RID: 3887
	private static readonly IntPtr NativeMethodInfoPtr_SaveScreenshot_Public_Void_0;

	// Token: 0x04000F30 RID: 3888
	private static readonly IntPtr NativeMethodInfoPtr_GetImageFromGallery_Public_Void_0;

	// Token: 0x04000F31 RID: 3889
	private static readonly IntPtr NativeMethodInfoPtr_GetImageFromCamera_Public_Void_0;

	// Token: 0x04000F32 RID: 3890
	private static readonly IntPtr NativeMethodInfoPtr_CheckForTV_Public_Void_0;

	// Token: 0x04000F33 RID: 3891
	private static readonly IntPtr NativeMethodInfoPtr_LoadNetworkInfo_Public_Void_0;

	// Token: 0x04000F34 RID: 3892
	private static readonly IntPtr NativeMethodInfoPtr_HandleActionNetworkInfoLoaded_Private_Void_AN_NetworkInfo_0;

	// Token: 0x04000F35 RID: 3893
	private static readonly IntPtr NativeMethodInfoPtr_CheckAppInstalation_Public_Void_0;

	// Token: 0x04000F36 RID: 3894
	private static readonly IntPtr NativeMethodInfoPtr_RunApp_Public_Void_0;

	// Token: 0x04000F37 RID: 3895
	private static readonly IntPtr NativeMethodInfoPtr_CheckAppLicense_Public_Void_0;

	// Token: 0x04000F38 RID: 3896
	private static readonly IntPtr NativeMethodInfoPtr_LicenseRequestResult_Private_Void_AN_LicenseRequestResult_0;

	// Token: 0x04000F39 RID: 3897
	private static readonly IntPtr NativeMethodInfoPtr_EnableImmersiveMode_Public_Void_0;

	// Token: 0x04000F3A RID: 3898
	private static readonly IntPtr NativeMethodInfoPtr_GetAndroidId_Public_Void_0;

	// Token: 0x04000F3B RID: 3899
	private static readonly IntPtr NativeMethodInfoPtr_OnAndroidIdLoaded_Private_Void_String_0;

	// Token: 0x04000F3C RID: 3900
	private static readonly IntPtr NativeMethodInfoPtr_LoadAppInfo_Public_Void_0;

	// Token: 0x04000F3D RID: 3901
	private static readonly IntPtr NativeMethodInfoPtr_LoadAdressBook_Private_Void_0;

	// Token: 0x04000F3E RID: 3902
	private static readonly IntPtr NativeMethodInfoPtr_OnDeviceTypeChecked_Private_Void_0;

	// Token: 0x04000F3F RID: 3903
	private static readonly IntPtr NativeMethodInfoPtr_OnPackageCheckResult_Private_Void_AN_PackageCheckResult_0;

	// Token: 0x04000F40 RID: 3904
	private static readonly IntPtr NativeMethodInfoPtr_OnContactsLoaded_Private_Void_0;

	// Token: 0x04000F41 RID: 3905
	private static readonly IntPtr NativeMethodInfoPtr_OnImagePicked_Private_Void_AndroidImagePickResult_0;

	// Token: 0x04000F42 RID: 3906
	private static readonly IntPtr NativeMethodInfoPtr_OnImageSaved_Private_Void_GallerySaveResult_0;

	// Token: 0x04000F43 RID: 3907
	private static readonly IntPtr NativeMethodInfoPtr_OnPackageInfoLoaded_Private_Void_PackageAppInfo_0;

	// Token: 0x04000F44 RID: 3908
	private static readonly IntPtr NativeMethodInfoPtr_LoadInternal_Public_Void_0;

	// Token: 0x04000F45 RID: 3909
	private static readonly IntPtr NativeMethodInfoPtr_LoadExternal_Public_Void_0;

	// Token: 0x04000F46 RID: 3910
	private static readonly IntPtr NativeMethodInfoPtr_LoadLocaleInfo_Public_Void_0;

	// Token: 0x04000F47 RID: 3911
	private static readonly IntPtr NativeMethodInfoPtr_LocaleInfoLoaded_Private_Void_AN_Locale_0;

	// Token: 0x04000F48 RID: 3912
	private static readonly IntPtr NativeMethodInfoPtr_ExternalStoragePathLoaded_Private_Void_String_0;

	// Token: 0x04000F49 RID: 3913
	private static readonly IntPtr NativeMethodInfoPtr_InternalStoragePathLoaded_Private_Void_String_0;

	// Token: 0x04000F4A RID: 3914
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

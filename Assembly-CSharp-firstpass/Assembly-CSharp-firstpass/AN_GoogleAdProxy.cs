using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x020000C0 RID: 192
public class AN_GoogleAdProxy : Object
{
	// Token: 0x06000DFB RID: 3579 RVA: 0x000488A0 File Offset: 0x00046AA0
	// Note: this type is marked as 'beforefieldinit'.
	static AN_GoogleAdProxy()
	{
		Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_GoogleAdProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr);
		AN_GoogleAdProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, "CLASS_NAME");
		AN_GoogleAdProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665039);
		AN_GoogleAdProxy.NativeMethodInfoPtr_InitMobileAd_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665040);
		AN_GoogleAdProxy.NativeMethodInfoPtr_ChangeBannersUnitID_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665041);
		AN_GoogleAdProxy.NativeMethodInfoPtr_ChangeInterstisialsUnitID_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665042);
		AN_GoogleAdProxy.NativeMethodInfoPtr_ChangeRewardedVideoUnitID_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665043);
		AN_GoogleAdProxy.NativeMethodInfoPtr_CreateBannerAd_Public_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665044);
		AN_GoogleAdProxy.NativeMethodInfoPtr_CreateBannerAdPos_Public_Static_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665045);
		AN_GoogleAdProxy.NativeMethodInfoPtr_SetBannerPosition_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665046);
		AN_GoogleAdProxy.NativeMethodInfoPtr_SetBannerPosition_Public_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665047);
		AN_GoogleAdProxy.NativeMethodInfoPtr_HideAd_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665048);
		AN_GoogleAdProxy.NativeMethodInfoPtr_ShowAd_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665049);
		AN_GoogleAdProxy.NativeMethodInfoPtr_RefreshAd_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665050);
		AN_GoogleAdProxy.NativeMethodInfoPtr_PauseAd_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665051);
		AN_GoogleAdProxy.NativeMethodInfoPtr_ResumeAd_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665052);
		AN_GoogleAdProxy.NativeMethodInfoPtr_DestroyBanner_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665053);
		AN_GoogleAdProxy.NativeMethodInfoPtr_StartInterstitialAd_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665054);
		AN_GoogleAdProxy.NativeMethodInfoPtr_LoadInterstitialAd_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665055);
		AN_GoogleAdProxy.NativeMethodInfoPtr_ShowInterstitialAd_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665056);
		AN_GoogleAdProxy.NativeMethodInfoPtr_LoadRewardedVideo_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665057);
		AN_GoogleAdProxy.NativeMethodInfoPtr_ShowRewardedVideo_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665058);
		AN_GoogleAdProxy.NativeMethodInfoPtr_RecordInAppResolution_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665059);
		AN_GoogleAdProxy.NativeMethodInfoPtr_AddKeyword_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665060);
		AN_GoogleAdProxy.NativeMethodInfoPtr_SetBirthday_Public_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665061);
		AN_GoogleAdProxy.NativeMethodInfoPtr_TagForChildDirectedTreatment_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665062);
		AN_GoogleAdProxy.NativeMethodInfoPtr_AddTestDevice_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665063);
		AN_GoogleAdProxy.NativeMethodInfoPtr_AddTestDevices_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665064);
		AN_GoogleAdProxy.NativeMethodInfoPtr_SetGender_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665065);
		AN_GoogleAdProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr, 100665066);
	}

	// Token: 0x06000DFC RID: 3580 RVA: 0x00048B14 File Offset: 0x00046D14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178070, XrefRangeEnd = 178071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallActivityFunction(string methodName, [Optional] Il2CppReferenceArray<Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Object>(0L);
		}
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DFD RID: 3581 RVA: 0x00048B6C File Offset: 0x00046D6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178071, XrefRangeEnd = 178077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitMobileAd(string id)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_InitMobileAd_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DFE RID: 3582 RVA: 0x00048BA4 File Offset: 0x00046DA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178077, XrefRangeEnd = 178083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeBannersUnitID(string id)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_ChangeBannersUnitID_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DFF RID: 3583 RVA: 0x00048BDC File Offset: 0x00046DDC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178083, XrefRangeEnd = 178089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeInterstisialsUnitID(string id)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_ChangeInterstisialsUnitID_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E00 RID: 3584 RVA: 0x00048C14 File Offset: 0x00046E14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178089, XrefRangeEnd = 178095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeRewardedVideoUnitID(string id)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_ChangeRewardedVideoUnitID_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E01 RID: 3585 RVA: 0x00048C4C File Offset: 0x00046E4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178095, XrefRangeEnd = 178106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateBannerAd(int gravity, int size, int id)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gravity;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_CreateBannerAd_Public_Static_Void_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E02 RID: 3586 RVA: 0x00048C9C File Offset: 0x00046E9C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178119, RefRangeEnd = 178120, XrefRangeStart = 178106, XrefRangeEnd = 178119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateBannerAdPos(int x, int y, int size, int id)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref x;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_CreateBannerAdPos_Public_Static_Void_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E03 RID: 3587 RVA: 0x00048CF8 File Offset: 0x00046EF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178120, XrefRangeEnd = 178129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetBannerPosition(int gravity, int bannerId)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gravity;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bannerId;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_SetBannerPosition_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E04 RID: 3588 RVA: 0x00048D38 File Offset: 0x00046F38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178129, XrefRangeEnd = 178140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetBannerPosition(int x, int y, int bannerId)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref x;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bannerId;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_SetBannerPosition_Public_Static_Void_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E05 RID: 3589 RVA: 0x00048D88 File Offset: 0x00046F88
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178140, XrefRangeEnd = 178147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HideAd(int id)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_HideAd_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E06 RID: 3590 RVA: 0x00048DBC File Offset: 0x00046FBC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178147, XrefRangeEnd = 178154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowAd(int id)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_ShowAd_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E07 RID: 3591 RVA: 0x00048DF0 File Offset: 0x00046FF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178154, XrefRangeEnd = 178161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RefreshAd(int id)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_RefreshAd_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E08 RID: 3592 RVA: 0x00048E24 File Offset: 0x00047024
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178161, XrefRangeEnd = 178168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PauseAd(int id)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_PauseAd_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E09 RID: 3593 RVA: 0x00048E58 File Offset: 0x00047058
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178168, XrefRangeEnd = 178175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResumeAd(int id)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_ResumeAd_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E0A RID: 3594 RVA: 0x00048E8C File Offset: 0x0004708C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178182, RefRangeEnd = 178183, XrefRangeStart = 178175, XrefRangeEnd = 178182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyBanner(int id)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_DestroyBanner_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E0B RID: 3595 RVA: 0x00048EC0 File Offset: 0x000470C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178183, XrefRangeEnd = 178188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartInterstitialAd()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_StartInterstitialAd_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E0C RID: 3596 RVA: 0x00048EE8 File Offset: 0x000470E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178188, XrefRangeEnd = 178193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadInterstitialAd()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_LoadInterstitialAd_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E0D RID: 3597 RVA: 0x00048F10 File Offset: 0x00047110
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178193, XrefRangeEnd = 178198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowInterstitialAd()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_ShowInterstitialAd_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E0E RID: 3598 RVA: 0x00048F38 File Offset: 0x00047138
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178198, XrefRangeEnd = 178203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadRewardedVideo()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_LoadRewardedVideo_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E0F RID: 3599 RVA: 0x00048F60 File Offset: 0x00047160
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178203, XrefRangeEnd = 178208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowRewardedVideo()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_ShowRewardedVideo_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E10 RID: 3600 RVA: 0x00048F88 File Offset: 0x00047188
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178208, XrefRangeEnd = 178215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RecordInAppResolution(int res)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref res;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_RecordInAppResolution_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E11 RID: 3601 RVA: 0x00048FBC File Offset: 0x000471BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178215, XrefRangeEnd = 178221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddKeyword(string keyword)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_AddKeyword_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E12 RID: 3602 RVA: 0x00048FF4 File Offset: 0x000471F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178221, XrefRangeEnd = 178232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetBirthday(int year, int month, int day)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref year;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_SetBirthday_Public_Static_Void_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E13 RID: 3603 RVA: 0x00049044 File Offset: 0x00047244
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178232, XrefRangeEnd = 178246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TagForChildDirectedTreatment(bool tagForChildDirectedTreatment)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref tagForChildDirectedTreatment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_TagForChildDirectedTreatment_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E14 RID: 3604 RVA: 0x00049078 File Offset: 0x00047278
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178246, XrefRangeEnd = 178252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddTestDevice(string deviceId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deviceId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_AddTestDevice_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E15 RID: 3605 RVA: 0x000490B0 File Offset: 0x000472B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178252, XrefRangeEnd = 178258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddTestDevices(string cvsDeviceIds)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cvsDeviceIds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_AddTestDevices_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E16 RID: 3606 RVA: 0x000490E8 File Offset: 0x000472E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178258, XrefRangeEnd = 178265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGender(int gender)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gender;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr_SetGender_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E17 RID: 3607 RVA: 0x0004911C File Offset: 0x0004731C
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_GoogleAdProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_GoogleAdProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GoogleAdProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E18 RID: 3608 RVA: 0x0000762E File Offset: 0x0000582E
	public static void CallActivityFunction(string methodName, params Object[] args)
	{
		AN_GoogleAdProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000E19 RID: 3609 RVA: 0x0000763C File Offset: 0x0000583C
	public AN_GoogleAdProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000436 RID: 1078
	// (get) Token: 0x06000E1A RID: 3610 RVA: 0x00049158 File Offset: 0x00047358
	// (set) Token: 0x06000E1B RID: 3611 RVA: 0x00007645 File Offset: 0x00005845
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_GoogleAdProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_GoogleAdProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000AE3 RID: 2787
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000AE4 RID: 2788
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000AE5 RID: 2789
	private static readonly IntPtr NativeMethodInfoPtr_InitMobileAd_Public_Static_Void_String_0;

	// Token: 0x04000AE6 RID: 2790
	private static readonly IntPtr NativeMethodInfoPtr_ChangeBannersUnitID_Public_Static_Void_String_0;

	// Token: 0x04000AE7 RID: 2791
	private static readonly IntPtr NativeMethodInfoPtr_ChangeInterstisialsUnitID_Public_Static_Void_String_0;

	// Token: 0x04000AE8 RID: 2792
	private static readonly IntPtr NativeMethodInfoPtr_ChangeRewardedVideoUnitID_Public_Static_Void_String_0;

	// Token: 0x04000AE9 RID: 2793
	private static readonly IntPtr NativeMethodInfoPtr_CreateBannerAd_Public_Static_Void_Int32_Int32_Int32_0;

	// Token: 0x04000AEA RID: 2794
	private static readonly IntPtr NativeMethodInfoPtr_CreateBannerAdPos_Public_Static_Void_Int32_Int32_Int32_Int32_0;

	// Token: 0x04000AEB RID: 2795
	private static readonly IntPtr NativeMethodInfoPtr_SetBannerPosition_Public_Static_Void_Int32_Int32_0;

	// Token: 0x04000AEC RID: 2796
	private static readonly IntPtr NativeMethodInfoPtr_SetBannerPosition_Public_Static_Void_Int32_Int32_Int32_0;

	// Token: 0x04000AED RID: 2797
	private static readonly IntPtr NativeMethodInfoPtr_HideAd_Public_Static_Void_Int32_0;

	// Token: 0x04000AEE RID: 2798
	private static readonly IntPtr NativeMethodInfoPtr_ShowAd_Public_Static_Void_Int32_0;

	// Token: 0x04000AEF RID: 2799
	private static readonly IntPtr NativeMethodInfoPtr_RefreshAd_Public_Static_Void_Int32_0;

	// Token: 0x04000AF0 RID: 2800
	private static readonly IntPtr NativeMethodInfoPtr_PauseAd_Public_Static_Void_Int32_0;

	// Token: 0x04000AF1 RID: 2801
	private static readonly IntPtr NativeMethodInfoPtr_ResumeAd_Public_Static_Void_Int32_0;

	// Token: 0x04000AF2 RID: 2802
	private static readonly IntPtr NativeMethodInfoPtr_DestroyBanner_Public_Static_Void_Int32_0;

	// Token: 0x04000AF3 RID: 2803
	private static readonly IntPtr NativeMethodInfoPtr_StartInterstitialAd_Public_Static_Void_0;

	// Token: 0x04000AF4 RID: 2804
	private static readonly IntPtr NativeMethodInfoPtr_LoadInterstitialAd_Public_Static_Void_0;

	// Token: 0x04000AF5 RID: 2805
	private static readonly IntPtr NativeMethodInfoPtr_ShowInterstitialAd_Public_Static_Void_0;

	// Token: 0x04000AF6 RID: 2806
	private static readonly IntPtr NativeMethodInfoPtr_LoadRewardedVideo_Public_Static_Void_0;

	// Token: 0x04000AF7 RID: 2807
	private static readonly IntPtr NativeMethodInfoPtr_ShowRewardedVideo_Public_Static_Void_0;

	// Token: 0x04000AF8 RID: 2808
	private static readonly IntPtr NativeMethodInfoPtr_RecordInAppResolution_Public_Static_Void_Int32_0;

	// Token: 0x04000AF9 RID: 2809
	private static readonly IntPtr NativeMethodInfoPtr_AddKeyword_Public_Static_Void_String_0;

	// Token: 0x04000AFA RID: 2810
	private static readonly IntPtr NativeMethodInfoPtr_SetBirthday_Public_Static_Void_Int32_Int32_Int32_0;

	// Token: 0x04000AFB RID: 2811
	private static readonly IntPtr NativeMethodInfoPtr_TagForChildDirectedTreatment_Public_Static_Void_Boolean_0;

	// Token: 0x04000AFC RID: 2812
	private static readonly IntPtr NativeMethodInfoPtr_AddTestDevice_Public_Static_Void_String_0;

	// Token: 0x04000AFD RID: 2813
	private static readonly IntPtr NativeMethodInfoPtr_AddTestDevices_Public_Static_Void_String_0;

	// Token: 0x04000AFE RID: 2814
	private static readonly IntPtr NativeMethodInfoPtr_SetGender_Public_Static_Void_Int32_0;

	// Token: 0x04000AFF RID: 2815
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

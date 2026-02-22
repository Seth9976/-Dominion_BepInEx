using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x020000B6 RID: 182
public class AndroidNative : Object
{
	// Token: 0x06000D17 RID: 3351 RVA: 0x00044EA8 File Offset: 0x000430A8
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidNative()
	{
		Il2CppClassPointerStore<AndroidNative>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidNative");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr);
		AndroidNative.NativeFieldInfoPtr_DATA_SPLITTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, "DATA_SPLITTER");
		AndroidNative.NativeFieldInfoPtr_DATA_EOF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, "DATA_EOF");
		AndroidNative.NativeFieldInfoPtr_DATA_SPLITTER2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, "DATA_SPLITTER2");
		AndroidNative.NativeFieldInfoPtr_DATA_SPLITTER3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, "DATA_SPLITTER3");
		AndroidNative.NativeFieldInfoPtr_UTILITY_CLASSS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, "UTILITY_CLASSS");
		AndroidNative.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, "CLASS_NAME");
		AndroidNative.NativeMethodInfoPtr_StringToArray_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664873);
		AndroidNative.NativeMethodInfoPtr_ArrayToString_Public_Static_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664874);
		AndroidNative.NativeMethodInfoPtr_TwitterInit_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664875);
		AndroidNative.NativeMethodInfoPtr_AuthificateUser_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664876);
		AndroidNative.NativeMethodInfoPtr_LoadUserData_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664877);
		AndroidNative.NativeMethodInfoPtr_TwitterPost_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664878);
		AndroidNative.NativeMethodInfoPtr_TwitterPostWithImage_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664879);
		AndroidNative.NativeMethodInfoPtr_LogoutFromTwitter_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664880);
		AndroidNative.NativeMethodInfoPtr_InitCameraAPI_Public_Static_Void_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664881);
		AndroidNative.NativeMethodInfoPtr_SaveToGalalry_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664882);
		AndroidNative.NativeMethodInfoPtr_GetVideoAndStartShareIntent_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664883);
		AndroidNative.NativeMethodInfoPtr_GetVideoFromGallery_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664884);
		AndroidNative.NativeMethodInfoPtr_GetImageFromGallery_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664885);
		AndroidNative.NativeMethodInfoPtr_GetImagesFromGallery_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664886);
		AndroidNative.NativeMethodInfoPtr_GetImageFromCamera_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664887);
		AndroidNative.NativeMethodInfoPtr_isPackageInstalled_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664888);
		AndroidNative.NativeMethodInfoPtr_runPackage_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664889);
		AndroidNative.NativeMethodInfoPtr_LoadAndroidId_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664890);
		AndroidNative.NativeMethodInfoPtr_LoadPackagesList_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664891);
		AndroidNative.NativeMethodInfoPtr_InvitePlusFriends_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664892);
		AndroidNative.NativeMethodInfoPtr_LoadNetworkInfo_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664893);
		AndroidNative.NativeMethodInfoPtr_OpenSettingsPage_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664894);
		AndroidNative.NativeMethodInfoPtr_LaunchApplication_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664895);
		AndroidNative.NativeMethodInfoPtr_LoadContacts_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664896);
		AndroidNative.NativeMethodInfoPtr_LoadPackageInfo_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664897);
		AndroidNative.NativeMethodInfoPtr_GetInternalStoragePath_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664898);
		AndroidNative.NativeMethodInfoPtr_GetExternalStoragePath_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664899);
		AndroidNative.NativeMethodInfoPtr_GetExternalStoragePublicDirectory_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664900);
		AndroidNative.NativeMethodInfoPtr_LoadLocaleInfo_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664901);
		AndroidNative.NativeMethodInfoPtr_StartLockTask_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664902);
		AndroidNative.NativeMethodInfoPtr_StopLockTask_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664903);
		AndroidNative.NativeMethodInfoPtr_OpenAppInStore_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664904);
		AndroidNative.NativeMethodInfoPtr_GenerateRefreshToken_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664905);
		AndroidNative.NativeMethodInfoPtr_SaveToCacheStorage_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664906);
		AndroidNative.NativeMethodInfoPtr_GetFromCacheStorage_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664907);
		AndroidNative.NativeMethodInfoPtr_RemoveData_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664908);
		AndroidNative.NativeMethodInfoPtr_CopyToClipboard_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664909);
		AndroidNative.NativeMethodInfoPtr_CallUtility_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664910);
		AndroidNative.NativeMethodInfoPtr_CallAndroidNativeBridge_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664911);
		AndroidNative.NativeMethodInfoPtr_CallStatic_Private_Static_Void_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664912);
		AndroidNative.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr, 100664913);
	}

	// Token: 0x06000D18 RID: 3352 RVA: 0x00045284 File Offset: 0x00043484
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 176694, RefRangeEnd = 176697, XrefRangeStart = 176684, XrefRangeEnd = 176694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray StringToArray(string val)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_StringToArray_Public_Static_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}
	}

	// Token: 0x06000D19 RID: 3353 RVA: 0x000452C8 File Offset: 0x000434C8
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 176717, RefRangeEnd = 176721, XrefRangeStart = 176697, XrefRangeEnd = 176717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ArrayToString(Il2CppStringArray array)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_ArrayToString_Public_Static_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x00045304 File Offset: 0x00043504
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176721, XrefRangeEnd = 176740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TwitterInit(string consumer_key, string consumer_secret)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(consumer_key);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(consumer_secret);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_TwitterInit_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D1B RID: 3355 RVA: 0x0004534C File Offset: 0x0004354C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176740, XrefRangeEnd = 176748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AuthificateUser()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_AuthificateUser_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D1C RID: 3356 RVA: 0x00045374 File Offset: 0x00043574
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176748, XrefRangeEnd = 176756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadUserData()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_LoadUserData_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D1D RID: 3357 RVA: 0x0004539C File Offset: 0x0004359C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176756, XrefRangeEnd = 176770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TwitterPost(string status)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(status);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_TwitterPost_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D1E RID: 3358 RVA: 0x000453D4 File Offset: 0x000435D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176770, XrefRangeEnd = 176789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TwitterPostWithImage(string status, string data)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(status);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_TwitterPostWithImage_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D1F RID: 3359 RVA: 0x0004541C File Offset: 0x0004361C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176789, XrefRangeEnd = 176797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogoutFromTwitter()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_LogoutFromTwitter_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D20 RID: 3360 RVA: 0x00045444 File Offset: 0x00043644
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 176814, RefRangeEnd = 176815, XrefRangeStart = 176797, XrefRangeEnd = 176814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitCameraAPI(string folderName, int maxSize, int mode, int format)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(folderName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSize;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_InitCameraAPI_Public_Static_Void_String_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D21 RID: 3361 RVA: 0x000454A4 File Offset: 0x000436A4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 176834, RefRangeEnd = 176835, XrefRangeStart = 176815, XrefRangeEnd = 176834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveToGalalry(string ImageData, string name)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ImageData);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_SaveToGalalry_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D22 RID: 3362 RVA: 0x000454EC File Offset: 0x000436EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176835, XrefRangeEnd = 176854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetVideoAndStartShareIntent(string message, string caption)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(caption);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_GetVideoAndStartShareIntent_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D23 RID: 3363 RVA: 0x00045534 File Offset: 0x00043734
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 176862, RefRangeEnd = 176863, XrefRangeStart = 176854, XrefRangeEnd = 176862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetVideoFromGallery()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_GetVideoFromGallery_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D24 RID: 3364 RVA: 0x0004555C File Offset: 0x0004375C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 176871, RefRangeEnd = 176873, XrefRangeStart = 176863, XrefRangeEnd = 176871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetImageFromGallery()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_GetImageFromGallery_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D25 RID: 3365 RVA: 0x00045584 File Offset: 0x00043784
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 176881, RefRangeEnd = 176882, XrefRangeStart = 176873, XrefRangeEnd = 176881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetImagesFromGallery()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_GetImagesFromGallery_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D26 RID: 3366 RVA: 0x000455AC File Offset: 0x000437AC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 176892, RefRangeEnd = 176894, XrefRangeStart = 176882, XrefRangeEnd = 176892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetImageFromCamera(bool bSaveToGallery = false)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bSaveToGallery;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_GetImageFromCamera_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D27 RID: 3367 RVA: 0x000455E0 File Offset: 0x000437E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176894, XrefRangeEnd = 176908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void isPackageInstalled(string packagename)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(packagename);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_isPackageInstalled_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D28 RID: 3368 RVA: 0x00045618 File Offset: 0x00043818
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176908, XrefRangeEnd = 176922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void runPackage(string packagename)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(packagename);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_runPackage_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D29 RID: 3369 RVA: 0x00045650 File Offset: 0x00043850
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 176930, RefRangeEnd = 176932, XrefRangeStart = 176922, XrefRangeEnd = 176930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadAndroidId()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_LoadAndroidId_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D2A RID: 3370 RVA: 0x00045678 File Offset: 0x00043878
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176932, XrefRangeEnd = 176940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadPackagesList()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_LoadPackagesList_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D2B RID: 3371 RVA: 0x000456A0 File Offset: 0x000438A0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 176948, RefRangeEnd = 176950, XrefRangeStart = 176940, XrefRangeEnd = 176948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvitePlusFriends()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_InvitePlusFriends_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D2C RID: 3372 RVA: 0x000456C8 File Offset: 0x000438C8
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 176958, RefRangeEnd = 176962, XrefRangeStart = 176950, XrefRangeEnd = 176958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadNetworkInfo()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_LoadNetworkInfo_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D2D RID: 3373 RVA: 0x000456F0 File Offset: 0x000438F0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 176976, RefRangeEnd = 176978, XrefRangeStart = 176962, XrefRangeEnd = 176976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OpenSettingsPage(string action)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_OpenSettingsPage_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D2E RID: 3374 RVA: 0x00045728 File Offset: 0x00043928
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176978, XrefRangeEnd = 176997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LaunchApplication(string bundle, string data)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(bundle);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_LaunchApplication_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D2F RID: 3375 RVA: 0x00045770 File Offset: 0x00043970
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 177005, RefRangeEnd = 177008, XrefRangeStart = 176997, XrefRangeEnd = 177005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadContacts()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_LoadContacts_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D30 RID: 3376 RVA: 0x00045798 File Offset: 0x00043998
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177016, RefRangeEnd = 177018, XrefRangeStart = 177008, XrefRangeEnd = 177016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadPackageInfo()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_LoadPackageInfo_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D31 RID: 3377 RVA: 0x000457C0 File Offset: 0x000439C0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177026, RefRangeEnd = 177028, XrefRangeStart = 177018, XrefRangeEnd = 177026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetInternalStoragePath()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_GetInternalStoragePath_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D32 RID: 3378 RVA: 0x000457E8 File Offset: 0x000439E8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177036, RefRangeEnd = 177038, XrefRangeStart = 177028, XrefRangeEnd = 177036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetExternalStoragePath()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_GetExternalStoragePath_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D33 RID: 3379 RVA: 0x00045810 File Offset: 0x00043A10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177038, XrefRangeEnd = 177040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetExternalStoragePublicDirectory(string type)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_GetExternalStoragePublicDirectory_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000D34 RID: 3380 RVA: 0x0004584C File Offset: 0x00043A4C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177048, RefRangeEnd = 177050, XrefRangeStart = 177040, XrefRangeEnd = 177048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadLocaleInfo()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_LoadLocaleInfo_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D35 RID: 3381 RVA: 0x00045874 File Offset: 0x00043A74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177050, XrefRangeEnd = 177058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartLockTask()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_StartLockTask_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D36 RID: 3382 RVA: 0x0004589C File Offset: 0x00043A9C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177058, XrefRangeEnd = 177066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StopLockTask()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_StopLockTask_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D37 RID: 3383 RVA: 0x000458C4 File Offset: 0x00043AC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177066, XrefRangeEnd = 177080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OpenAppInStore(string appPackageName)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(appPackageName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_OpenAppInStore_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D38 RID: 3384 RVA: 0x000458FC File Offset: 0x00043AFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177080, XrefRangeEnd = 177099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GenerateRefreshToken(string redirectUrl, string clientId)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(redirectUrl);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(clientId);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_GenerateRefreshToken_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D39 RID: 3385 RVA: 0x00045944 File Offset: 0x00043B44
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177099, XrefRangeEnd = 177118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveToCacheStorage(string key, string value)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_SaveToCacheStorage_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D3A RID: 3386 RVA: 0x0004598C File Offset: 0x00043B8C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177118, XrefRangeEnd = 177120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetFromCacheStorage(string key)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_GetFromCacheStorage_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000D3B RID: 3387 RVA: 0x000459C8 File Offset: 0x00043BC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177120, XrefRangeEnd = 177134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveData(string key)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_RemoveData_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D3C RID: 3388 RVA: 0x00045A00 File Offset: 0x00043C00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177134, XrefRangeEnd = 177148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyToClipboard(string text)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_CopyToClipboard_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D3D RID: 3389 RVA: 0x00045A38 File Offset: 0x00043C38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177148, XrefRangeEnd = 177151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallUtility(string methodName, [Optional] Il2CppReferenceArray<Object> args)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_CallUtility_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D3E RID: 3390 RVA: 0x00045A90 File Offset: 0x00043C90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177151, XrefRangeEnd = 177154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallAndroidNativeBridge(string methodName, [Optional] Il2CppReferenceArray<Object> args)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_CallAndroidNativeBridge_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D3F RID: 3391 RVA: 0x00045AE8 File Offset: 0x00043CE8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177154, XrefRangeEnd = 177155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallStatic(string className, string methodName, [Optional] Il2CppReferenceArray<Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Object>(0L);
		}
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr_CallStatic_Private_Static_Void_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D40 RID: 3392 RVA: 0x00045B50 File Offset: 0x00043D50
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidNative()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidNative>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNative.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D41 RID: 3393 RVA: 0x0000741D File Offset: 0x0000561D
	public static void CallUtility(string methodName, params Object[] args)
	{
		AndroidNative.CallUtility(methodName, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000D42 RID: 3394 RVA: 0x0000742B File Offset: 0x0000562B
	public static void CallAndroidNativeBridge(string methodName, params Object[] args)
	{
		AndroidNative.CallAndroidNativeBridge(methodName, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000D43 RID: 3395 RVA: 0x00007439 File Offset: 0x00005639
	public static void CallStatic(string className, string methodName, params Object[] args)
	{
		AndroidNative.CallStatic(className, methodName, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000D44 RID: 3396 RVA: 0x00007448 File Offset: 0x00005648
	public AndroidNative(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000427 RID: 1063
	// (get) Token: 0x06000D45 RID: 3397 RVA: 0x00045B8C File Offset: 0x00043D8C
	// (set) Token: 0x06000D46 RID: 3398 RVA: 0x00007451 File Offset: 0x00005651
	public unsafe static string DATA_SPLITTER
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNative.NativeFieldInfoPtr_DATA_SPLITTER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNative.NativeFieldInfoPtr_DATA_SPLITTER, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000428 RID: 1064
	// (get) Token: 0x06000D47 RID: 3399 RVA: 0x00045BAC File Offset: 0x00043DAC
	// (set) Token: 0x06000D48 RID: 3400 RVA: 0x00007463 File Offset: 0x00005663
	public unsafe static string DATA_EOF
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNative.NativeFieldInfoPtr_DATA_EOF, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNative.NativeFieldInfoPtr_DATA_EOF, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000429 RID: 1065
	// (get) Token: 0x06000D49 RID: 3401 RVA: 0x00045BCC File Offset: 0x00043DCC
	// (set) Token: 0x06000D4A RID: 3402 RVA: 0x00007475 File Offset: 0x00005675
	public unsafe static string DATA_SPLITTER2
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNative.NativeFieldInfoPtr_DATA_SPLITTER2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNative.NativeFieldInfoPtr_DATA_SPLITTER2, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700042A RID: 1066
	// (get) Token: 0x06000D4B RID: 3403 RVA: 0x00045BEC File Offset: 0x00043DEC
	// (set) Token: 0x06000D4C RID: 3404 RVA: 0x00007487 File Offset: 0x00005687
	public unsafe static string DATA_SPLITTER3
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNative.NativeFieldInfoPtr_DATA_SPLITTER3, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNative.NativeFieldInfoPtr_DATA_SPLITTER3, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700042B RID: 1067
	// (get) Token: 0x06000D4D RID: 3405 RVA: 0x00045C0C File Offset: 0x00043E0C
	// (set) Token: 0x06000D4E RID: 3406 RVA: 0x00007499 File Offset: 0x00005699
	public unsafe static string UTILITY_CLASSS
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNative.NativeFieldInfoPtr_UTILITY_CLASSS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNative.NativeFieldInfoPtr_UTILITY_CLASSS, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700042C RID: 1068
	// (get) Token: 0x06000D4F RID: 3407 RVA: 0x00045C2C File Offset: 0x00043E2C
	// (set) Token: 0x06000D50 RID: 3408 RVA: 0x000074AB File Offset: 0x000056AB
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidNative.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidNative.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000A2E RID: 2606
	private static readonly IntPtr NativeFieldInfoPtr_DATA_SPLITTER;

	// Token: 0x04000A2F RID: 2607
	private static readonly IntPtr NativeFieldInfoPtr_DATA_EOF;

	// Token: 0x04000A30 RID: 2608
	private static readonly IntPtr NativeFieldInfoPtr_DATA_SPLITTER2;

	// Token: 0x04000A31 RID: 2609
	private static readonly IntPtr NativeFieldInfoPtr_DATA_SPLITTER3;

	// Token: 0x04000A32 RID: 2610
	private static readonly IntPtr NativeFieldInfoPtr_UTILITY_CLASSS;

	// Token: 0x04000A33 RID: 2611
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000A34 RID: 2612
	private static readonly IntPtr NativeMethodInfoPtr_StringToArray_Public_Static_Il2CppStringArray_String_0;

	// Token: 0x04000A35 RID: 2613
	private static readonly IntPtr NativeMethodInfoPtr_ArrayToString_Public_Static_String_Il2CppStringArray_0;

	// Token: 0x04000A36 RID: 2614
	private static readonly IntPtr NativeMethodInfoPtr_TwitterInit_Public_Static_Void_String_String_0;

	// Token: 0x04000A37 RID: 2615
	private static readonly IntPtr NativeMethodInfoPtr_AuthificateUser_Public_Static_Void_0;

	// Token: 0x04000A38 RID: 2616
	private static readonly IntPtr NativeMethodInfoPtr_LoadUserData_Public_Static_Void_0;

	// Token: 0x04000A39 RID: 2617
	private static readonly IntPtr NativeMethodInfoPtr_TwitterPost_Public_Static_Void_String_0;

	// Token: 0x04000A3A RID: 2618
	private static readonly IntPtr NativeMethodInfoPtr_TwitterPostWithImage_Public_Static_Void_String_String_0;

	// Token: 0x04000A3B RID: 2619
	private static readonly IntPtr NativeMethodInfoPtr_LogoutFromTwitter_Public_Static_Void_0;

	// Token: 0x04000A3C RID: 2620
	private static readonly IntPtr NativeMethodInfoPtr_InitCameraAPI_Public_Static_Void_String_Int32_Int32_Int32_0;

	// Token: 0x04000A3D RID: 2621
	private static readonly IntPtr NativeMethodInfoPtr_SaveToGalalry_Public_Static_Void_String_String_0;

	// Token: 0x04000A3E RID: 2622
	private static readonly IntPtr NativeMethodInfoPtr_GetVideoAndStartShareIntent_Public_Static_Void_String_String_0;

	// Token: 0x04000A3F RID: 2623
	private static readonly IntPtr NativeMethodInfoPtr_GetVideoFromGallery_Public_Static_Void_0;

	// Token: 0x04000A40 RID: 2624
	private static readonly IntPtr NativeMethodInfoPtr_GetImageFromGallery_Public_Static_Void_0;

	// Token: 0x04000A41 RID: 2625
	private static readonly IntPtr NativeMethodInfoPtr_GetImagesFromGallery_Public_Static_Void_0;

	// Token: 0x04000A42 RID: 2626
	private static readonly IntPtr NativeMethodInfoPtr_GetImageFromCamera_Public_Static_Void_Boolean_0;

	// Token: 0x04000A43 RID: 2627
	private static readonly IntPtr NativeMethodInfoPtr_isPackageInstalled_Public_Static_Void_String_0;

	// Token: 0x04000A44 RID: 2628
	private static readonly IntPtr NativeMethodInfoPtr_runPackage_Public_Static_Void_String_0;

	// Token: 0x04000A45 RID: 2629
	private static readonly IntPtr NativeMethodInfoPtr_LoadAndroidId_Public_Static_Void_0;

	// Token: 0x04000A46 RID: 2630
	private static readonly IntPtr NativeMethodInfoPtr_LoadPackagesList_Public_Static_Void_0;

	// Token: 0x04000A47 RID: 2631
	private static readonly IntPtr NativeMethodInfoPtr_InvitePlusFriends_Public_Static_Void_0;

	// Token: 0x04000A48 RID: 2632
	private static readonly IntPtr NativeMethodInfoPtr_LoadNetworkInfo_Public_Static_Void_0;

	// Token: 0x04000A49 RID: 2633
	private static readonly IntPtr NativeMethodInfoPtr_OpenSettingsPage_Public_Static_Void_String_0;

	// Token: 0x04000A4A RID: 2634
	private static readonly IntPtr NativeMethodInfoPtr_LaunchApplication_Public_Static_Void_String_String_0;

	// Token: 0x04000A4B RID: 2635
	private static readonly IntPtr NativeMethodInfoPtr_LoadContacts_Public_Static_Void_0;

	// Token: 0x04000A4C RID: 2636
	private static readonly IntPtr NativeMethodInfoPtr_LoadPackageInfo_Public_Static_Void_0;

	// Token: 0x04000A4D RID: 2637
	private static readonly IntPtr NativeMethodInfoPtr_GetInternalStoragePath_Public_Static_Void_0;

	// Token: 0x04000A4E RID: 2638
	private static readonly IntPtr NativeMethodInfoPtr_GetExternalStoragePath_Public_Static_Void_0;

	// Token: 0x04000A4F RID: 2639
	private static readonly IntPtr NativeMethodInfoPtr_GetExternalStoragePublicDirectory_Public_Static_String_String_0;

	// Token: 0x04000A50 RID: 2640
	private static readonly IntPtr NativeMethodInfoPtr_LoadLocaleInfo_Public_Static_Void_0;

	// Token: 0x04000A51 RID: 2641
	private static readonly IntPtr NativeMethodInfoPtr_StartLockTask_Public_Static_Void_0;

	// Token: 0x04000A52 RID: 2642
	private static readonly IntPtr NativeMethodInfoPtr_StopLockTask_Public_Static_Void_0;

	// Token: 0x04000A53 RID: 2643
	private static readonly IntPtr NativeMethodInfoPtr_OpenAppInStore_Public_Static_Void_String_0;

	// Token: 0x04000A54 RID: 2644
	private static readonly IntPtr NativeMethodInfoPtr_GenerateRefreshToken_Public_Static_Void_String_String_0;

	// Token: 0x04000A55 RID: 2645
	private static readonly IntPtr NativeMethodInfoPtr_SaveToCacheStorage_Public_Static_Void_String_String_0;

	// Token: 0x04000A56 RID: 2646
	private static readonly IntPtr NativeMethodInfoPtr_GetFromCacheStorage_Public_Static_String_String_0;

	// Token: 0x04000A57 RID: 2647
	private static readonly IntPtr NativeMethodInfoPtr_RemoveData_Public_Static_Void_String_0;

	// Token: 0x04000A58 RID: 2648
	private static readonly IntPtr NativeMethodInfoPtr_CopyToClipboard_Public_Static_Void_String_0;

	// Token: 0x04000A59 RID: 2649
	private static readonly IntPtr NativeMethodInfoPtr_CallUtility_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000A5A RID: 2650
	private static readonly IntPtr NativeMethodInfoPtr_CallAndroidNativeBridge_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000A5B RID: 2651
	private static readonly IntPtr NativeMethodInfoPtr_CallStatic_Private_Static_Void_String_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000A5C RID: 2652
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

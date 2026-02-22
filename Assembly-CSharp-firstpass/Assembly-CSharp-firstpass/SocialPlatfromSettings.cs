using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000021 RID: 33
public class SocialPlatfromSettings : ScriptableObject
{
	// Token: 0x060003A5 RID: 933 RVA: 0x000230F0 File Offset: 0x000212F0
	// Note: this type is marked as 'beforefieldinit'.
	static SocialPlatfromSettings()
	{
		Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SocialPlatfromSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr);
		SocialPlatfromSettings.NativeFieldInfoPtr_VERSION_NUMBER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "VERSION_NUMBER");
		SocialPlatfromSettings.NativeFieldInfoPtr_FB_SDK_VERSION_NUMBER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "FB_SDK_VERSION_NUMBER");
		SocialPlatfromSettings.NativeFieldInfoPtr_ShowImageSharingSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "ShowImageSharingSettings");
		SocialPlatfromSettings.NativeFieldInfoPtr_SaveImageToGallery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "SaveImageToGallery");
		SocialPlatfromSettings.NativeFieldInfoPtr_showPermitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "showPermitions");
		SocialPlatfromSettings.NativeFieldInfoPtr_ShowActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "ShowActions");
		SocialPlatfromSettings.NativeFieldInfoPtr_ShowAPIS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "ShowAPIS");
		SocialPlatfromSettings.NativeFieldInfoPtr_fb_scopes_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "fb_scopes_list");
		SocialPlatfromSettings.NativeFieldInfoPtr_TWITTER_CONSUMER_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "TWITTER_CONSUMER_KEY");
		SocialPlatfromSettings.NativeFieldInfoPtr_TWITTER_CONSUMER_SECRET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "TWITTER_CONSUMER_SECRET");
		SocialPlatfromSettings.NativeFieldInfoPtr_TWITTER_ACCESS_TOKEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "TWITTER_ACCESS_TOKEN");
		SocialPlatfromSettings.NativeFieldInfoPtr_TWITTER_ACCESS_TOKEN_SECRET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "TWITTER_ACCESS_TOKEN_SECRET");
		SocialPlatfromSettings.NativeFieldInfoPtr_ShowEditorOauthTestingBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "ShowEditorOauthTestingBlock");
		SocialPlatfromSettings.NativeFieldInfoPtr_ISNSettingsAssetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "ISNSettingsAssetName");
		SocialPlatfromSettings.NativeFieldInfoPtr_ISNSettingsAssetExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "ISNSettingsAssetExtension");
		SocialPlatfromSettings.NativeFieldInfoPtr_TwitterAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "TwitterAPI");
		SocialPlatfromSettings.NativeFieldInfoPtr_NativeSharingAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "NativeSharingAPI");
		SocialPlatfromSettings.NativeFieldInfoPtr_InstagramAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "InstagramAPI");
		SocialPlatfromSettings.NativeFieldInfoPtr_EnableImageSharing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "EnableImageSharing");
		SocialPlatfromSettings.NativeFieldInfoPtr_KeepManifestClean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "KeepManifestClean");
		SocialPlatfromSettings.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, "instance");
		SocialPlatfromSettings.NativeMethodInfoPtr_get_Instance_Public_Static_get_SocialPlatfromSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, 100663712);
		SocialPlatfromSettings.NativeMethodInfoPtr_AddDefaultScopes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, 100663713);
		SocialPlatfromSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr, 100663714);
	}

	// Token: 0x17000155 RID: 341
	// (get) Token: 0x060003A6 RID: 934 RVA: 0x00023300 File Offset: 0x00021500
	public unsafe static SocialPlatfromSettings Instance
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 162694, RefRangeEnd = 162701, XrefRangeStart = 162665, XrefRangeEnd = 162694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialPlatfromSettings.NativeMethodInfoPtr_get_Instance_Public_Static_get_SocialPlatfromSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SocialPlatfromSettings>(intPtr3) : null;
		}
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x00023334 File Offset: 0x00021534
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162701, XrefRangeEnd = 162746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddDefaultScopes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialPlatfromSettings.NativeMethodInfoPtr_AddDefaultScopes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x00023368 File Offset: 0x00021568
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162746, XrefRangeEnd = 162760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SocialPlatfromSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocialPlatfromSettings>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocialPlatfromSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x0000398D File Offset: 0x00001B8D
	public SocialPlatfromSettings(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x060003AA RID: 938 RVA: 0x000233A4 File Offset: 0x000215A4
	// (set) Token: 0x060003AB RID: 939 RVA: 0x00003996 File Offset: 0x00001B96
	public unsafe static string VERSION_NUMBER
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SocialPlatfromSettings.NativeFieldInfoPtr_VERSION_NUMBER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SocialPlatfromSettings.NativeFieldInfoPtr_VERSION_NUMBER, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x060003AC RID: 940 RVA: 0x000233C4 File Offset: 0x000215C4
	// (set) Token: 0x060003AD RID: 941 RVA: 0x000039A8 File Offset: 0x00001BA8
	public unsafe static string FB_SDK_VERSION_NUMBER
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SocialPlatfromSettings.NativeFieldInfoPtr_FB_SDK_VERSION_NUMBER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SocialPlatfromSettings.NativeFieldInfoPtr_FB_SDK_VERSION_NUMBER, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x060003AE RID: 942 RVA: 0x000233E4 File Offset: 0x000215E4
	// (set) Token: 0x060003AF RID: 943 RVA: 0x000039BA File Offset: 0x00001BBA
	public unsafe bool ShowImageSharingSettings
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_ShowImageSharingSettings);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_ShowImageSharingSettings)) = value;
		}
	}

	// Token: 0x17000143 RID: 323
	// (get) Token: 0x060003B0 RID: 944 RVA: 0x0002340C File Offset: 0x0002160C
	// (set) Token: 0x060003B1 RID: 945 RVA: 0x000039D5 File Offset: 0x00001BD5
	public unsafe bool SaveImageToGallery
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_SaveImageToGallery);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_SaveImageToGallery)) = value;
		}
	}

	// Token: 0x17000144 RID: 324
	// (get) Token: 0x060003B2 RID: 946 RVA: 0x00023434 File Offset: 0x00021634
	// (set) Token: 0x060003B3 RID: 947 RVA: 0x000039F0 File Offset: 0x00001BF0
	public unsafe bool showPermitions
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_showPermitions);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_showPermitions)) = value;
		}
	}

	// Token: 0x17000145 RID: 325
	// (get) Token: 0x060003B4 RID: 948 RVA: 0x0002345C File Offset: 0x0002165C
	// (set) Token: 0x060003B5 RID: 949 RVA: 0x00003A0B File Offset: 0x00001C0B
	public unsafe bool ShowActions
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_ShowActions);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_ShowActions)) = value;
		}
	}

	// Token: 0x17000146 RID: 326
	// (get) Token: 0x060003B6 RID: 950 RVA: 0x00023484 File Offset: 0x00021684
	// (set) Token: 0x060003B7 RID: 951 RVA: 0x00003A26 File Offset: 0x00001C26
	public unsafe bool ShowAPIS
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_ShowAPIS);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_ShowAPIS)) = value;
		}
	}

	// Token: 0x17000147 RID: 327
	// (get) Token: 0x060003B8 RID: 952 RVA: 0x000234AC File Offset: 0x000216AC
	// (set) Token: 0x060003B9 RID: 953 RVA: 0x00003A41 File Offset: 0x00001C41
	public unsafe List<string> fb_scopes_list
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_fb_scopes_list);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_fb_scopes_list), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000148 RID: 328
	// (get) Token: 0x060003BA RID: 954 RVA: 0x000234DC File Offset: 0x000216DC
	// (set) Token: 0x060003BB RID: 955 RVA: 0x00003A60 File Offset: 0x00001C60
	public unsafe string TWITTER_CONSUMER_KEY
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_TWITTER_CONSUMER_KEY);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_TWITTER_CONSUMER_KEY), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x060003BC RID: 956 RVA: 0x00023504 File Offset: 0x00021704
	// (set) Token: 0x060003BD RID: 957 RVA: 0x00003A7F File Offset: 0x00001C7F
	public unsafe string TWITTER_CONSUMER_SECRET
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_TWITTER_CONSUMER_SECRET);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_TWITTER_CONSUMER_SECRET), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x060003BE RID: 958 RVA: 0x0002352C File Offset: 0x0002172C
	// (set) Token: 0x060003BF RID: 959 RVA: 0x00003A9E File Offset: 0x00001C9E
	public unsafe string TWITTER_ACCESS_TOKEN
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_TWITTER_ACCESS_TOKEN);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_TWITTER_ACCESS_TOKEN), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700014B RID: 331
	// (get) Token: 0x060003C0 RID: 960 RVA: 0x00023554 File Offset: 0x00021754
	// (set) Token: 0x060003C1 RID: 961 RVA: 0x00003ABD File Offset: 0x00001CBD
	public unsafe string TWITTER_ACCESS_TOKEN_SECRET
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_TWITTER_ACCESS_TOKEN_SECRET);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_TWITTER_ACCESS_TOKEN_SECRET), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x060003C2 RID: 962 RVA: 0x0002357C File Offset: 0x0002177C
	// (set) Token: 0x060003C3 RID: 963 RVA: 0x00003ADC File Offset: 0x00001CDC
	public unsafe bool ShowEditorOauthTestingBlock
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_ShowEditorOauthTestingBlock);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_ShowEditorOauthTestingBlock)) = value;
		}
	}

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x060003C4 RID: 964 RVA: 0x000235A4 File Offset: 0x000217A4
	// (set) Token: 0x060003C5 RID: 965 RVA: 0x00003AF7 File Offset: 0x00001CF7
	public unsafe static string ISNSettingsAssetName
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SocialPlatfromSettings.NativeFieldInfoPtr_ISNSettingsAssetName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SocialPlatfromSettings.NativeFieldInfoPtr_ISNSettingsAssetName, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x060003C6 RID: 966 RVA: 0x000235C4 File Offset: 0x000217C4
	// (set) Token: 0x060003C7 RID: 967 RVA: 0x00003B09 File Offset: 0x00001D09
	public unsafe static string ISNSettingsAssetExtension
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SocialPlatfromSettings.NativeFieldInfoPtr_ISNSettingsAssetExtension, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SocialPlatfromSettings.NativeFieldInfoPtr_ISNSettingsAssetExtension, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x060003C8 RID: 968 RVA: 0x000235E4 File Offset: 0x000217E4
	// (set) Token: 0x060003C9 RID: 969 RVA: 0x00003B1B File Offset: 0x00001D1B
	public unsafe bool TwitterAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_TwitterAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_TwitterAPI)) = value;
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x060003CA RID: 970 RVA: 0x0002360C File Offset: 0x0002180C
	// (set) Token: 0x060003CB RID: 971 RVA: 0x00003B36 File Offset: 0x00001D36
	public unsafe bool NativeSharingAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_NativeSharingAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_NativeSharingAPI)) = value;
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x060003CC RID: 972 RVA: 0x00023634 File Offset: 0x00021834
	// (set) Token: 0x060003CD RID: 973 RVA: 0x00003B51 File Offset: 0x00001D51
	public unsafe bool InstagramAPI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_InstagramAPI);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_InstagramAPI)) = value;
		}
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x060003CE RID: 974 RVA: 0x0002365C File Offset: 0x0002185C
	// (set) Token: 0x060003CF RID: 975 RVA: 0x00003B6C File Offset: 0x00001D6C
	public unsafe bool EnableImageSharing
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_EnableImageSharing);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_EnableImageSharing)) = value;
		}
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x060003D0 RID: 976 RVA: 0x00023684 File Offset: 0x00021884
	// (set) Token: 0x060003D1 RID: 977 RVA: 0x00003B87 File Offset: 0x00001D87
	public unsafe bool KeepManifestClean
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_KeepManifestClean);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocialPlatfromSettings.NativeFieldInfoPtr_KeepManifestClean)) = value;
		}
	}

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x060003D2 RID: 978 RVA: 0x000236AC File Offset: 0x000218AC
	// (set) Token: 0x060003D3 RID: 979 RVA: 0x00003BA2 File Offset: 0x00001DA2
	public unsafe static SocialPlatfromSettings instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SocialPlatfromSettings.NativeFieldInfoPtr_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SocialPlatfromSettings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SocialPlatfromSettings.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040002C2 RID: 706
	private static readonly IntPtr NativeFieldInfoPtr_VERSION_NUMBER;

	// Token: 0x040002C3 RID: 707
	private static readonly IntPtr NativeFieldInfoPtr_FB_SDK_VERSION_NUMBER;

	// Token: 0x040002C4 RID: 708
	private static readonly IntPtr NativeFieldInfoPtr_ShowImageSharingSettings;

	// Token: 0x040002C5 RID: 709
	private static readonly IntPtr NativeFieldInfoPtr_SaveImageToGallery;

	// Token: 0x040002C6 RID: 710
	private static readonly IntPtr NativeFieldInfoPtr_showPermitions;

	// Token: 0x040002C7 RID: 711
	private static readonly IntPtr NativeFieldInfoPtr_ShowActions;

	// Token: 0x040002C8 RID: 712
	private static readonly IntPtr NativeFieldInfoPtr_ShowAPIS;

	// Token: 0x040002C9 RID: 713
	private static readonly IntPtr NativeFieldInfoPtr_fb_scopes_list;

	// Token: 0x040002CA RID: 714
	private static readonly IntPtr NativeFieldInfoPtr_TWITTER_CONSUMER_KEY;

	// Token: 0x040002CB RID: 715
	private static readonly IntPtr NativeFieldInfoPtr_TWITTER_CONSUMER_SECRET;

	// Token: 0x040002CC RID: 716
	private static readonly IntPtr NativeFieldInfoPtr_TWITTER_ACCESS_TOKEN;

	// Token: 0x040002CD RID: 717
	private static readonly IntPtr NativeFieldInfoPtr_TWITTER_ACCESS_TOKEN_SECRET;

	// Token: 0x040002CE RID: 718
	private static readonly IntPtr NativeFieldInfoPtr_ShowEditorOauthTestingBlock;

	// Token: 0x040002CF RID: 719
	private static readonly IntPtr NativeFieldInfoPtr_ISNSettingsAssetName;

	// Token: 0x040002D0 RID: 720
	private static readonly IntPtr NativeFieldInfoPtr_ISNSettingsAssetExtension;

	// Token: 0x040002D1 RID: 721
	private static readonly IntPtr NativeFieldInfoPtr_TwitterAPI;

	// Token: 0x040002D2 RID: 722
	private static readonly IntPtr NativeFieldInfoPtr_NativeSharingAPI;

	// Token: 0x040002D3 RID: 723
	private static readonly IntPtr NativeFieldInfoPtr_InstagramAPI;

	// Token: 0x040002D4 RID: 724
	private static readonly IntPtr NativeFieldInfoPtr_EnableImageSharing;

	// Token: 0x040002D5 RID: 725
	private static readonly IntPtr NativeFieldInfoPtr_KeepManifestClean;

	// Token: 0x040002D6 RID: 726
	private static readonly IntPtr NativeFieldInfoPtr_instance;

	// Token: 0x040002D7 RID: 727
	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_SocialPlatfromSettings_0;

	// Token: 0x040002D8 RID: 728
	private static readonly IntPtr NativeMethodInfoPtr_AddDefaultScopes_Public_Void_0;

	// Token: 0x040002D9 RID: 729
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

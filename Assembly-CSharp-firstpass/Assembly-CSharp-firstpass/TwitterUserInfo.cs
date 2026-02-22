using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

// Token: 0x020000A9 RID: 169
public class TwitterUserInfo : global::Il2CppSystem.Object
{
	// Token: 0x06000C3D RID: 3133 RVA: 0x00041CA8 File Offset: 0x0003FEA8
	// Note: this type is marked as 'beforefieldinit'.
	static TwitterUserInfo()
	{
		Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TwitterUserInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr);
		TwitterUserInfo.NativeFieldInfoPtr_ActionProfileImageLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "ActionProfileImageLoaded");
		TwitterUserInfo.NativeFieldInfoPtr_ActionProfileBackgroundImageLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "ActionProfileBackgroundImageLoaded");
		TwitterUserInfo.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "_id");
		TwitterUserInfo.NativeFieldInfoPtr__description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "_description");
		TwitterUserInfo.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "_name");
		TwitterUserInfo.NativeFieldInfoPtr__screen_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "_screen_name");
		TwitterUserInfo.NativeFieldInfoPtr__location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "_location");
		TwitterUserInfo.NativeFieldInfoPtr__lang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "_lang");
		TwitterUserInfo.NativeFieldInfoPtr__rawJSON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "_rawJSON");
		TwitterUserInfo.NativeFieldInfoPtr__profile_image_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "_profile_image_url");
		TwitterUserInfo.NativeFieldInfoPtr__profile_image_url_https = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "_profile_image_url_https");
		TwitterUserInfo.NativeFieldInfoPtr__profile_background_image_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "_profile_background_image_url");
		TwitterUserInfo.NativeFieldInfoPtr__profile_background_image_url_https = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "_profile_background_image_url_https");
		TwitterUserInfo.NativeFieldInfoPtr__profile_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "_profile_image");
		TwitterUserInfo.NativeFieldInfoPtr__profile_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "_profile_background");
		TwitterUserInfo.NativeFieldInfoPtr__profile_background_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "_profile_background_color");
		TwitterUserInfo.NativeFieldInfoPtr__profile_text_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "_profile_text_color");
		TwitterUserInfo.NativeFieldInfoPtr__friends_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "_friends_count");
		TwitterUserInfo.NativeFieldInfoPtr__statuses_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "_statuses_count");
		TwitterUserInfo.NativeFieldInfoPtr__status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "_status");
		TwitterUserInfo.NativeMethodInfoPtr_add_ActionProfileImageLoaded_Public_add_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664767);
		TwitterUserInfo.NativeMethodInfoPtr_remove_ActionProfileImageLoaded_Public_rem_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664768);
		TwitterUserInfo.NativeMethodInfoPtr_add_ActionProfileBackgroundImageLoaded_Public_add_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664769);
		TwitterUserInfo.NativeMethodInfoPtr_remove_ActionProfileBackgroundImageLoaded_Public_rem_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664770);
		TwitterUserInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664771);
		TwitterUserInfo.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664772);
		TwitterUserInfo.NativeMethodInfoPtr_LoadProfileImage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664773);
		TwitterUserInfo.NativeMethodInfoPtr_LoadBackgroundImage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664774);
		TwitterUserInfo.NativeMethodInfoPtr_get_rawJSON_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664775);
		TwitterUserInfo.NativeMethodInfoPtr_get_id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664776);
		TwitterUserInfo.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664777);
		TwitterUserInfo.NativeMethodInfoPtr_get_description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664778);
		TwitterUserInfo.NativeMethodInfoPtr_get_screen_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664779);
		TwitterUserInfo.NativeMethodInfoPtr_get_location_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664780);
		TwitterUserInfo.NativeMethodInfoPtr_get_lang_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664781);
		TwitterUserInfo.NativeMethodInfoPtr_get_profile_image_url_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664782);
		TwitterUserInfo.NativeMethodInfoPtr_get_profile_image_url_https_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664783);
		TwitterUserInfo.NativeMethodInfoPtr_get_profile_background_image_url_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664784);
		TwitterUserInfo.NativeMethodInfoPtr_get_profile_background_image_url_https_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664785);
		TwitterUserInfo.NativeMethodInfoPtr_get_friends_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664786);
		TwitterUserInfo.NativeMethodInfoPtr_get_statuses_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664787);
		TwitterUserInfo.NativeMethodInfoPtr_get_status_Public_get_TwitterStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664788);
		TwitterUserInfo.NativeMethodInfoPtr_get_profile_image_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664789);
		TwitterUserInfo.NativeMethodInfoPtr_get_profile_background_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664790);
		TwitterUserInfo.NativeMethodInfoPtr_get_profile_background_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664791);
		TwitterUserInfo.NativeMethodInfoPtr_get_profile_text_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664792);
		TwitterUserInfo.NativeMethodInfoPtr_OnProfileImageLoaded_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664793);
		TwitterUserInfo.NativeMethodInfoPtr_OnProfileBackgroundLoaded_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664794);
		TwitterUserInfo.NativeMethodInfoPtr_HexToColor_Private_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, 100664795);
	}

	// Token: 0x06000C3E RID: 3134 RVA: 0x000420AC File Offset: 0x000402AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175140, XrefRangeEnd = 175144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_ActionProfileImageLoaded(Action<Texture2D> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_add_ActionProfileImageLoaded_Public_add_Void_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C3F RID: 3135 RVA: 0x000420F0 File Offset: 0x000402F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175144, XrefRangeEnd = 175148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_ActionProfileImageLoaded(Action<Texture2D> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_remove_ActionProfileImageLoaded_Public_rem_Void_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C40 RID: 3136 RVA: 0x00042134 File Offset: 0x00040334
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175148, XrefRangeEnd = 175152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_ActionProfileBackgroundImageLoaded(Action<Texture2D> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_add_ActionProfileBackgroundImageLoaded_Public_add_Void_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C41 RID: 3137 RVA: 0x00042178 File Offset: 0x00040378
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175152, XrefRangeEnd = 175156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_ActionProfileBackgroundImageLoaded(Action<Texture2D> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_remove_ActionProfileBackgroundImageLoaded_Public_rem_Void_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C42 RID: 3138 RVA: 0x000421BC File Offset: 0x000403BC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 175304, RefRangeEnd = 175305, XrefRangeStart = 175156, XrefRangeEnd = 175304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TwitterUserInfo(string data)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C43 RID: 3139 RVA: 0x00042208 File Offset: 0x00040408
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 175425, RefRangeEnd = 175428, XrefRangeStart = 175305, XrefRangeEnd = 175425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TwitterUserInfo(IDictionary JSON)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(JSON);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C44 RID: 3140 RVA: 0x00042254 File Offset: 0x00040454
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175428, XrefRangeEnd = 175445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadProfileImage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_LoadProfileImage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C45 RID: 3141 RVA: 0x00042288 File Offset: 0x00040488
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175445, XrefRangeEnd = 175462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadBackgroundImage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_LoadBackgroundImage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170003FA RID: 1018
	// (get) Token: 0x06000C46 RID: 3142 RVA: 0x000422BC File Offset: 0x000404BC
	public unsafe string rawJSON
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_get_rawJSON_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170003FB RID: 1019
	// (get) Token: 0x06000C47 RID: 3143 RVA: 0x000422F4 File Offset: 0x000404F4
	public unsafe string id
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_get_id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170003FC RID: 1020
	// (get) Token: 0x06000C48 RID: 3144 RVA: 0x0004232C File Offset: 0x0004052C
	public unsafe string name
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170003FD RID: 1021
	// (get) Token: 0x06000C49 RID: 3145 RVA: 0x00042364 File Offset: 0x00040564
	public unsafe string description
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_get_description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170003FE RID: 1022
	// (get) Token: 0x06000C4A RID: 3146 RVA: 0x0004239C File Offset: 0x0004059C
	public unsafe string screen_name
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_get_screen_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170003FF RID: 1023
	// (get) Token: 0x06000C4B RID: 3147 RVA: 0x000423D4 File Offset: 0x000405D4
	public unsafe string location
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_get_location_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000400 RID: 1024
	// (get) Token: 0x06000C4C RID: 3148 RVA: 0x0004240C File Offset: 0x0004060C
	public unsafe string lang
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_get_lang_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000401 RID: 1025
	// (get) Token: 0x06000C4D RID: 3149 RVA: 0x00042444 File Offset: 0x00040644
	public unsafe string profile_image_url
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_get_profile_image_url_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000402 RID: 1026
	// (get) Token: 0x06000C4E RID: 3150 RVA: 0x0004247C File Offset: 0x0004067C
	public unsafe string profile_image_url_https
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_get_profile_image_url_https_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000403 RID: 1027
	// (get) Token: 0x06000C4F RID: 3151 RVA: 0x000424B4 File Offset: 0x000406B4
	public unsafe string profile_background_image_url
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_get_profile_background_image_url_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000404 RID: 1028
	// (get) Token: 0x06000C50 RID: 3152 RVA: 0x000424EC File Offset: 0x000406EC
	public unsafe string profile_background_image_url_https
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_get_profile_background_image_url_https_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000405 RID: 1029
	// (get) Token: 0x06000C51 RID: 3153 RVA: 0x00042524 File Offset: 0x00040724
	public unsafe int friends_count
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_get_friends_count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000406 RID: 1030
	// (get) Token: 0x06000C52 RID: 3154 RVA: 0x00042560 File Offset: 0x00040760
	public unsafe int statuses_count
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_get_statuses_count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000407 RID: 1031
	// (get) Token: 0x06000C53 RID: 3155 RVA: 0x0004259C File Offset: 0x0004079C
	public unsafe TwitterStatus status
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_get_status_Public_get_TwitterStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TwitterStatus>(intPtr3) : null;
		}
	}

	// Token: 0x17000408 RID: 1032
	// (get) Token: 0x06000C54 RID: 3156 RVA: 0x000425DC File Offset: 0x000407DC
	public unsafe Texture2D profile_image
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_get_profile_image_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}
	}

	// Token: 0x17000409 RID: 1033
	// (get) Token: 0x06000C55 RID: 3157 RVA: 0x0004261C File Offset: 0x0004081C
	public unsafe Texture2D profile_background
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_get_profile_background_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}
	}

	// Token: 0x1700040A RID: 1034
	// (get) Token: 0x06000C56 RID: 3158 RVA: 0x0004265C File Offset: 0x0004085C
	public unsafe Color profile_background_color
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_get_profile_background_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700040B RID: 1035
	// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00042698 File Offset: 0x00040898
	public unsafe Color profile_text_color
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_get_profile_text_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000C58 RID: 3160 RVA: 0x000426D4 File Offset: 0x000408D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175462, XrefRangeEnd = 175465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnProfileImageLoaded(Texture2D img)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(img);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_OnProfileImageLoaded_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C59 RID: 3161 RVA: 0x00042718 File Offset: 0x00040918
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175465, XrefRangeEnd = 175468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnProfileBackgroundLoaded(Texture2D img)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(img);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_OnProfileBackgroundLoaded_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C5A RID: 3162 RVA: 0x0004275C File Offset: 0x0004095C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175468, XrefRangeEnd = 175476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color HexToColor(string hex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(hex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.NativeMethodInfoPtr_HexToColor_Private_Color_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000C5B RID: 3163 RVA: 0x00006E97 File Offset: 0x00005097
	public TwitterUserInfo(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170003E6 RID: 998
	// (get) Token: 0x06000C5C RID: 3164 RVA: 0x000427AC File Offset: 0x000409AC
	// (set) Token: 0x06000C5D RID: 3165 RVA: 0x00006EA0 File Offset: 0x000050A0
	public unsafe Action<Texture2D> ActionProfileImageLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr_ActionProfileImageLoaded);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr_ActionProfileImageLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003E7 RID: 999
	// (get) Token: 0x06000C5E RID: 3166 RVA: 0x000427DC File Offset: 0x000409DC
	// (set) Token: 0x06000C5F RID: 3167 RVA: 0x00006EBF File Offset: 0x000050BF
	public unsafe Action<Texture2D> ActionProfileBackgroundImageLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr_ActionProfileBackgroundImageLoaded);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr_ActionProfileBackgroundImageLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003E8 RID: 1000
	// (get) Token: 0x06000C60 RID: 3168 RVA: 0x0004280C File Offset: 0x00040A0C
	// (set) Token: 0x06000C61 RID: 3169 RVA: 0x00006EDE File Offset: 0x000050DE
	public unsafe string _id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003E9 RID: 1001
	// (get) Token: 0x06000C62 RID: 3170 RVA: 0x00042834 File Offset: 0x00040A34
	// (set) Token: 0x06000C63 RID: 3171 RVA: 0x00006EFD File Offset: 0x000050FD
	public unsafe string _description
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__description);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__description), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003EA RID: 1002
	// (get) Token: 0x06000C64 RID: 3172 RVA: 0x0004285C File Offset: 0x00040A5C
	// (set) Token: 0x06000C65 RID: 3173 RVA: 0x00006F1C File Offset: 0x0000511C
	public unsafe string _name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003EB RID: 1003
	// (get) Token: 0x06000C66 RID: 3174 RVA: 0x00042884 File Offset: 0x00040A84
	// (set) Token: 0x06000C67 RID: 3175 RVA: 0x00006F3B File Offset: 0x0000513B
	public unsafe string _screen_name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__screen_name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__screen_name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003EC RID: 1004
	// (get) Token: 0x06000C68 RID: 3176 RVA: 0x000428AC File Offset: 0x00040AAC
	// (set) Token: 0x06000C69 RID: 3177 RVA: 0x00006F5A File Offset: 0x0000515A
	public unsafe string _location
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__location);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__location), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003ED RID: 1005
	// (get) Token: 0x06000C6A RID: 3178 RVA: 0x000428D4 File Offset: 0x00040AD4
	// (set) Token: 0x06000C6B RID: 3179 RVA: 0x00006F79 File Offset: 0x00005179
	public unsafe string _lang
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__lang);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__lang), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003EE RID: 1006
	// (get) Token: 0x06000C6C RID: 3180 RVA: 0x000428FC File Offset: 0x00040AFC
	// (set) Token: 0x06000C6D RID: 3181 RVA: 0x00006F98 File Offset: 0x00005198
	public unsafe string _rawJSON
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__rawJSON);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__rawJSON), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003EF RID: 1007
	// (get) Token: 0x06000C6E RID: 3182 RVA: 0x00042924 File Offset: 0x00040B24
	// (set) Token: 0x06000C6F RID: 3183 RVA: 0x00006FB7 File Offset: 0x000051B7
	public unsafe string _profile_image_url
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__profile_image_url);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__profile_image_url), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003F0 RID: 1008
	// (get) Token: 0x06000C70 RID: 3184 RVA: 0x0004294C File Offset: 0x00040B4C
	// (set) Token: 0x06000C71 RID: 3185 RVA: 0x00006FD6 File Offset: 0x000051D6
	public unsafe string _profile_image_url_https
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__profile_image_url_https);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__profile_image_url_https), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003F1 RID: 1009
	// (get) Token: 0x06000C72 RID: 3186 RVA: 0x00042974 File Offset: 0x00040B74
	// (set) Token: 0x06000C73 RID: 3187 RVA: 0x00006FF5 File Offset: 0x000051F5
	public unsafe string _profile_background_image_url
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__profile_background_image_url);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__profile_background_image_url), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003F2 RID: 1010
	// (get) Token: 0x06000C74 RID: 3188 RVA: 0x0004299C File Offset: 0x00040B9C
	// (set) Token: 0x06000C75 RID: 3189 RVA: 0x00007014 File Offset: 0x00005214
	public unsafe string _profile_background_image_url_https
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__profile_background_image_url_https);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__profile_background_image_url_https), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003F3 RID: 1011
	// (get) Token: 0x06000C76 RID: 3190 RVA: 0x000429C4 File Offset: 0x00040BC4
	// (set) Token: 0x06000C77 RID: 3191 RVA: 0x00007033 File Offset: 0x00005233
	public unsafe Texture2D _profile_image
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__profile_image);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__profile_image), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003F4 RID: 1012
	// (get) Token: 0x06000C78 RID: 3192 RVA: 0x000429F4 File Offset: 0x00040BF4
	// (set) Token: 0x06000C79 RID: 3193 RVA: 0x00007052 File Offset: 0x00005252
	public unsafe Texture2D _profile_background
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__profile_background);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__profile_background), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003F5 RID: 1013
	// (get) Token: 0x06000C7A RID: 3194 RVA: 0x00042A24 File Offset: 0x00040C24
	// (set) Token: 0x06000C7B RID: 3195 RVA: 0x00007071 File Offset: 0x00005271
	public unsafe Color _profile_background_color
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__profile_background_color);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__profile_background_color)) = value;
		}
	}

	// Token: 0x170003F6 RID: 1014
	// (get) Token: 0x06000C7C RID: 3196 RVA: 0x00042A4C File Offset: 0x00040C4C
	// (set) Token: 0x06000C7D RID: 3197 RVA: 0x0000708C File Offset: 0x0000528C
	public unsafe Color _profile_text_color
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__profile_text_color);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__profile_text_color)) = value;
		}
	}

	// Token: 0x170003F7 RID: 1015
	// (get) Token: 0x06000C7E RID: 3198 RVA: 0x00042A74 File Offset: 0x00040C74
	// (set) Token: 0x06000C7F RID: 3199 RVA: 0x000070A7 File Offset: 0x000052A7
	public unsafe int _friends_count
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__friends_count);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__friends_count)) = value;
		}
	}

	// Token: 0x170003F8 RID: 1016
	// (get) Token: 0x06000C80 RID: 3200 RVA: 0x00042A9C File Offset: 0x00040C9C
	// (set) Token: 0x06000C81 RID: 3201 RVA: 0x000070C2 File Offset: 0x000052C2
	public unsafe int _statuses_count
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__statuses_count);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__statuses_count)) = value;
		}
	}

	// Token: 0x170003F9 RID: 1017
	// (get) Token: 0x06000C82 RID: 3202 RVA: 0x00042AC4 File Offset: 0x00040CC4
	// (set) Token: 0x06000C83 RID: 3203 RVA: 0x000070DD File Offset: 0x000052DD
	public unsafe TwitterStatus _status
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__status);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TwitterStatus>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterUserInfo.NativeFieldInfoPtr__status), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000999 RID: 2457
	private static readonly IntPtr NativeFieldInfoPtr_ActionProfileImageLoaded;

	// Token: 0x0400099A RID: 2458
	private static readonly IntPtr NativeFieldInfoPtr_ActionProfileBackgroundImageLoaded;

	// Token: 0x0400099B RID: 2459
	private static readonly IntPtr NativeFieldInfoPtr__id;

	// Token: 0x0400099C RID: 2460
	private static readonly IntPtr NativeFieldInfoPtr__description;

	// Token: 0x0400099D RID: 2461
	private static readonly IntPtr NativeFieldInfoPtr__name;

	// Token: 0x0400099E RID: 2462
	private static readonly IntPtr NativeFieldInfoPtr__screen_name;

	// Token: 0x0400099F RID: 2463
	private static readonly IntPtr NativeFieldInfoPtr__location;

	// Token: 0x040009A0 RID: 2464
	private static readonly IntPtr NativeFieldInfoPtr__lang;

	// Token: 0x040009A1 RID: 2465
	private static readonly IntPtr NativeFieldInfoPtr__rawJSON;

	// Token: 0x040009A2 RID: 2466
	private static readonly IntPtr NativeFieldInfoPtr__profile_image_url;

	// Token: 0x040009A3 RID: 2467
	private static readonly IntPtr NativeFieldInfoPtr__profile_image_url_https;

	// Token: 0x040009A4 RID: 2468
	private static readonly IntPtr NativeFieldInfoPtr__profile_background_image_url;

	// Token: 0x040009A5 RID: 2469
	private static readonly IntPtr NativeFieldInfoPtr__profile_background_image_url_https;

	// Token: 0x040009A6 RID: 2470
	private static readonly IntPtr NativeFieldInfoPtr__profile_image;

	// Token: 0x040009A7 RID: 2471
	private static readonly IntPtr NativeFieldInfoPtr__profile_background;

	// Token: 0x040009A8 RID: 2472
	private static readonly IntPtr NativeFieldInfoPtr__profile_background_color;

	// Token: 0x040009A9 RID: 2473
	private static readonly IntPtr NativeFieldInfoPtr__profile_text_color;

	// Token: 0x040009AA RID: 2474
	private static readonly IntPtr NativeFieldInfoPtr__friends_count;

	// Token: 0x040009AB RID: 2475
	private static readonly IntPtr NativeFieldInfoPtr__statuses_count;

	// Token: 0x040009AC RID: 2476
	private static readonly IntPtr NativeFieldInfoPtr__status;

	// Token: 0x040009AD RID: 2477
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionProfileImageLoaded_Public_add_Void_Action_1_Texture2D_0;

	// Token: 0x040009AE RID: 2478
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionProfileImageLoaded_Public_rem_Void_Action_1_Texture2D_0;

	// Token: 0x040009AF RID: 2479
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionProfileBackgroundImageLoaded_Public_add_Void_Action_1_Texture2D_0;

	// Token: 0x040009B0 RID: 2480
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionProfileBackgroundImageLoaded_Public_rem_Void_Action_1_Texture2D_0;

	// Token: 0x040009B1 RID: 2481
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x040009B2 RID: 2482
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_0;

	// Token: 0x040009B3 RID: 2483
	private static readonly IntPtr NativeMethodInfoPtr_LoadProfileImage_Public_Void_0;

	// Token: 0x040009B4 RID: 2484
	private static readonly IntPtr NativeMethodInfoPtr_LoadBackgroundImage_Public_Void_0;

	// Token: 0x040009B5 RID: 2485
	private static readonly IntPtr NativeMethodInfoPtr_get_rawJSON_Public_get_String_0;

	// Token: 0x040009B6 RID: 2486
	private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_String_0;

	// Token: 0x040009B7 RID: 2487
	private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

	// Token: 0x040009B8 RID: 2488
	private static readonly IntPtr NativeMethodInfoPtr_get_description_Public_get_String_0;

	// Token: 0x040009B9 RID: 2489
	private static readonly IntPtr NativeMethodInfoPtr_get_screen_name_Public_get_String_0;

	// Token: 0x040009BA RID: 2490
	private static readonly IntPtr NativeMethodInfoPtr_get_location_Public_get_String_0;

	// Token: 0x040009BB RID: 2491
	private static readonly IntPtr NativeMethodInfoPtr_get_lang_Public_get_String_0;

	// Token: 0x040009BC RID: 2492
	private static readonly IntPtr NativeMethodInfoPtr_get_profile_image_url_Public_get_String_0;

	// Token: 0x040009BD RID: 2493
	private static readonly IntPtr NativeMethodInfoPtr_get_profile_image_url_https_Public_get_String_0;

	// Token: 0x040009BE RID: 2494
	private static readonly IntPtr NativeMethodInfoPtr_get_profile_background_image_url_Public_get_String_0;

	// Token: 0x040009BF RID: 2495
	private static readonly IntPtr NativeMethodInfoPtr_get_profile_background_image_url_https_Public_get_String_0;

	// Token: 0x040009C0 RID: 2496
	private static readonly IntPtr NativeMethodInfoPtr_get_friends_count_Public_get_Int32_0;

	// Token: 0x040009C1 RID: 2497
	private static readonly IntPtr NativeMethodInfoPtr_get_statuses_count_Public_get_Int32_0;

	// Token: 0x040009C2 RID: 2498
	private static readonly IntPtr NativeMethodInfoPtr_get_status_Public_get_TwitterStatus_0;

	// Token: 0x040009C3 RID: 2499
	private static readonly IntPtr NativeMethodInfoPtr_get_profile_image_Public_get_Texture2D_0;

	// Token: 0x040009C4 RID: 2500
	private static readonly IntPtr NativeMethodInfoPtr_get_profile_background_Public_get_Texture2D_0;

	// Token: 0x040009C5 RID: 2501
	private static readonly IntPtr NativeMethodInfoPtr_get_profile_background_color_Public_get_Color_0;

	// Token: 0x040009C6 RID: 2502
	private static readonly IntPtr NativeMethodInfoPtr_get_profile_text_color_Public_get_Color_0;

	// Token: 0x040009C7 RID: 2503
	private static readonly IntPtr NativeMethodInfoPtr_OnProfileImageLoaded_Private_Void_Texture2D_0;

	// Token: 0x040009C8 RID: 2504
	private static readonly IntPtr NativeMethodInfoPtr_OnProfileBackgroundLoaded_Private_Void_Texture2D_0;

	// Token: 0x040009C9 RID: 2505
	private static readonly IntPtr NativeMethodInfoPtr_HexToColor_Private_Color_String_0;

	// Token: 0x02000385 RID: 901
	[ObfuscatedName("TwitterUserInfo+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x060035B9 RID: 13753 RVA: 0x000DD418 File Offset: 0x000DB618
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<TwitterUserInfo.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TwitterUserInfo>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwitterUserInfo.__c>.NativeClassPtr);
			TwitterUserInfo.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo.__c>.NativeClassPtr, "<>9");
			TwitterUserInfo.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo.__c>.NativeClassPtr, "<>9__24_0");
			TwitterUserInfo.__c.NativeFieldInfoPtr___9__24_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo.__c>.NativeClassPtr, "<>9__24_1");
			TwitterUserInfo.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo.__c>.NativeClassPtr, "<>9__25_0");
			TwitterUserInfo.__c.NativeFieldInfoPtr___9__25_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterUserInfo.__c>.NativeClassPtr, "<>9__25_1");
			TwitterUserInfo.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo.__c>.NativeClassPtr, 100670149);
			TwitterUserInfo.__c.NativeMethodInfoPtr___ctor_b__24_0_Internal_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo.__c>.NativeClassPtr, 100670150);
			TwitterUserInfo.__c.NativeMethodInfoPtr___ctor_b__24_1_Internal_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo.__c>.NativeClassPtr, 100670151);
			TwitterUserInfo.__c.NativeMethodInfoPtr___ctor_b__25_0_Internal_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo.__c>.NativeClassPtr, 100670152);
			TwitterUserInfo.__c.NativeMethodInfoPtr___ctor_b__25_1_Internal_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterUserInfo.__c>.NativeClassPtr, 100670153);
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x000DD50C File Offset: 0x000DB70C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwitterUserInfo.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x000DD548 File Offset: 0x000DB748
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__24_0(Texture2D <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.__c.NativeMethodInfoPtr___ctor_b__24_0_Internal_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x000DD58C File Offset: 0x000DB78C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__24_1(Texture2D <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.__c.NativeMethodInfoPtr___ctor_b__24_1_Internal_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x000DD5D0 File Offset: 0x000DB7D0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__25_0(Texture2D <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.__c.NativeMethodInfoPtr___ctor_b__25_0_Internal_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x000DD614 File Offset: 0x000DB814
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__25_1(Texture2D <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterUserInfo.__c.NativeMethodInfoPtr___ctor_b__25_1_Internal_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x00014D00 File Offset: 0x00012F00
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x060035C0 RID: 13760 RVA: 0x000DD658 File Offset: 0x000DB858
		// (set) Token: 0x060035C1 RID: 13761 RVA: 0x00014D09 File Offset: 0x00012F09
		public unsafe static TwitterUserInfo.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwitterUserInfo.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TwitterUserInfo.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwitterUserInfo.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x060035C2 RID: 13762 RVA: 0x000DD680 File Offset: 0x000DB880
		// (set) Token: 0x060035C3 RID: 13763 RVA: 0x00014D1B File Offset: 0x00012F1B
		public unsafe static Action<Texture2D> __9__24_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwitterUserInfo.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwitterUserInfo.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x060035C4 RID: 13764 RVA: 0x000DD6A8 File Offset: 0x000DB8A8
		// (set) Token: 0x060035C5 RID: 13765 RVA: 0x00014D2D File Offset: 0x00012F2D
		public unsafe static Action<Texture2D> __9__24_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwitterUserInfo.__c.NativeFieldInfoPtr___9__24_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwitterUserInfo.__c.NativeFieldInfoPtr___9__24_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x060035C6 RID: 13766 RVA: 0x000DD6D0 File Offset: 0x000DB8D0
		// (set) Token: 0x060035C7 RID: 13767 RVA: 0x00014D3F File Offset: 0x00012F3F
		public unsafe static Action<Texture2D> __9__25_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwitterUserInfo.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwitterUserInfo.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x060035C8 RID: 13768 RVA: 0x000DD6F8 File Offset: 0x000DB8F8
		// (set) Token: 0x060035C9 RID: 13769 RVA: 0x00014D51 File Offset: 0x00012F51
		public unsafe static Action<Texture2D> __9__25_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TwitterUserInfo.__c.NativeFieldInfoPtr___9__25_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TwitterUserInfo.__c.NativeFieldInfoPtr___9__25_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003160 RID: 12640
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003161 RID: 12641
		private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

		// Token: 0x04003162 RID: 12642
		private static readonly IntPtr NativeFieldInfoPtr___9__24_1;

		// Token: 0x04003163 RID: 12643
		private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

		// Token: 0x04003164 RID: 12644
		private static readonly IntPtr NativeFieldInfoPtr___9__25_1;

		// Token: 0x04003165 RID: 12645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003166 RID: 12646
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__24_0_Internal_Void_Texture2D_0;

		// Token: 0x04003167 RID: 12647
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__24_1_Internal_Void_Texture2D_0;

		// Token: 0x04003168 RID: 12648
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__25_0_Internal_Void_Texture2D_0;

		// Token: 0x04003169 RID: 12649
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__25_1_Internal_Void_Texture2D_0;
	}
}

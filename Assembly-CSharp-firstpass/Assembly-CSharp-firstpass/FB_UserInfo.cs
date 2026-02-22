using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000098 RID: 152
public class FB_UserInfo : global::Il2CppSystem.Object
{
	// Token: 0x06000AF5 RID: 2805 RVA: 0x0003D8A8 File Offset: 0x0003BAA8
	// Note: this type is marked as 'beforefieldinit'.
	static FB_UserInfo()
	{
		Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FB_UserInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr);
		FB_UserInfo.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, "_id");
		FB_UserInfo.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, "_name");
		FB_UserInfo.NativeFieldInfoPtr__first_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, "_first_name");
		FB_UserInfo.NativeFieldInfoPtr__last_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, "_last_name");
		FB_UserInfo.NativeFieldInfoPtr__username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, "_username");
		FB_UserInfo.NativeFieldInfoPtr__profile_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, "_profile_url");
		FB_UserInfo.NativeFieldInfoPtr__email = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, "_email");
		FB_UserInfo.NativeFieldInfoPtr__location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, "_location");
		FB_UserInfo.NativeFieldInfoPtr__locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, "_locale");
		FB_UserInfo.NativeFieldInfoPtr__rawJSON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, "_rawJSON");
		FB_UserInfo.NativeFieldInfoPtr__Birthday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, "_Birthday");
		FB_UserInfo.NativeFieldInfoPtr__gender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, "_gender");
		FB_UserInfo.NativeFieldInfoPtr__ageRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, "_ageRange");
		FB_UserInfo.NativeFieldInfoPtr__picUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, "_picUrl");
		FB_UserInfo.NativeFieldInfoPtr_profileImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, "profileImages");
		FB_UserInfo.NativeFieldInfoPtr_OnProfileImageLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, "OnProfileImageLoaded");
		FB_UserInfo.NativeMethodInfoPtr_add_OnProfileImageLoaded_Public_add_Void_Action_1_FB_UserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664629);
		FB_UserInfo.NativeMethodInfoPtr_remove_OnProfileImageLoaded_Public_rem_Void_Action_1_FB_UserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664630);
		FB_UserInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664631);
		FB_UserInfo.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664632);
		FB_UserInfo.NativeMethodInfoPtr_InitializeData_Public_Void_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664633);
		FB_UserInfo.NativeMethodInfoPtr_GetProfileUrl_Public_String_FB_ProfileImageSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664634);
		FB_UserInfo.NativeMethodInfoPtr_GetProfileImage_Public_Texture2D_FB_ProfileImageSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664635);
		FB_UserInfo.NativeMethodInfoPtr_LoadProfileImage_Public_Void_FB_ProfileImageSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664636);
		FB_UserInfo.NativeMethodInfoPtr_get_RawJSON_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664637);
		FB_UserInfo.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664638);
		FB_UserInfo.NativeMethodInfoPtr_get_Birthday_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664639);
		FB_UserInfo.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664640);
		FB_UserInfo.NativeMethodInfoPtr_get_FirstName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664641);
		FB_UserInfo.NativeMethodInfoPtr_get_LastName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664642);
		FB_UserInfo.NativeMethodInfoPtr_get_UserName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664643);
		FB_UserInfo.NativeMethodInfoPtr_get_ProfileUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664644);
		FB_UserInfo.NativeMethodInfoPtr_get_Email_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664645);
		FB_UserInfo.NativeMethodInfoPtr_get_Locale_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664646);
		FB_UserInfo.NativeMethodInfoPtr_get_Location_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664647);
		FB_UserInfo.NativeMethodInfoPtr_get_Gender_Public_get_FB_Gender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664648);
		FB_UserInfo.NativeMethodInfoPtr_get_AgeRange_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664649);
		FB_UserInfo.NativeMethodInfoPtr_get_PictureUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664650);
		FB_UserInfo.NativeMethodInfoPtr_OnSquareImageLoaded_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664651);
		FB_UserInfo.NativeMethodInfoPtr_OnLargeImageLoaded_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664652);
		FB_UserInfo.NativeMethodInfoPtr_OnNormalImageLoaded_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664653);
		FB_UserInfo.NativeMethodInfoPtr_OnSmallImageLoaded_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, 100664654);
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x0003DC20 File Offset: 0x0003BE20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173803, XrefRangeEnd = 173807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnProfileImageLoaded(Action<FB_UserInfo> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_add_OnProfileImageLoaded_Public_add_Void_Action_1_FB_UserInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x0003DC64 File Offset: 0x0003BE64
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173807, XrefRangeEnd = 173811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnProfileImageLoaded(Action<FB_UserInfo> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_remove_OnProfileImageLoaded_Public_rem_Void_Action_1_FB_UserInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x0003DCA8 File Offset: 0x0003BEA8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 173851, RefRangeEnd = 173852, XrefRangeStart = 173811, XrefRangeEnd = 173851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_UserInfo(string data)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x0003DCF4 File Offset: 0x0003BEF4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 173888, RefRangeEnd = 173889, XrefRangeStart = 173852, XrefRangeEnd = 173888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_UserInfo(IDictionary JSON)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(JSON);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000AFA RID: 2810 RVA: 0x0003DD40 File Offset: 0x0003BF40
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 174074, RefRangeEnd = 174076, XrefRangeStart = 173889, XrefRangeEnd = 174074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeData(IDictionary JSON)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(JSON);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_InitializeData_Public_Void_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000AFB RID: 2811 RVA: 0x0003DD84 File Offset: 0x0003BF84
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 174086, RefRangeEnd = 174091, XrefRangeStart = 174076, XrefRangeEnd = 174086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetProfileUrl(FB_ProfileImageSize size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_GetProfileUrl_Public_String_FB_ProfileImageSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000AFC RID: 2812 RVA: 0x0003DDC8 File Offset: 0x0003BFC8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 174095, RefRangeEnd = 174096, XrefRangeStart = 174091, XrefRangeEnd = 174095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture2D GetProfileImage(FB_ProfileImageSize size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_GetProfileImage_Public_Texture2D_FB_ProfileImageSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x0003DE14 File Offset: 0x0003C014
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 174150, RefRangeEnd = 174152, XrefRangeStart = 174096, XrefRangeEnd = 174150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadProfileImage(FB_ProfileImageSize size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_LoadProfileImage_Public_Void_FB_ProfileImageSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x17000383 RID: 899
	// (get) Token: 0x06000AFE RID: 2814 RVA: 0x0003DE54 File Offset: 0x0003C054
	public unsafe string RawJSON
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_get_RawJSON_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000384 RID: 900
	// (get) Token: 0x06000AFF RID: 2815 RVA: 0x0003DE8C File Offset: 0x0003C08C
	public unsafe string Id
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000385 RID: 901
	// (get) Token: 0x06000B00 RID: 2816 RVA: 0x0003DEC4 File Offset: 0x0003C0C4
	public unsafe DateTime Birthday
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_get_Birthday_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000386 RID: 902
	// (get) Token: 0x06000B01 RID: 2817 RVA: 0x0003DF00 File Offset: 0x0003C100
	public unsafe string Name
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000387 RID: 903
	// (get) Token: 0x06000B02 RID: 2818 RVA: 0x0003DF38 File Offset: 0x0003C138
	public unsafe string FirstName
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_get_FirstName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000388 RID: 904
	// (get) Token: 0x06000B03 RID: 2819 RVA: 0x0003DF70 File Offset: 0x0003C170
	public unsafe string LastName
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_get_LastName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000389 RID: 905
	// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0003DFA8 File Offset: 0x0003C1A8
	public unsafe string UserName
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_get_UserName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700038A RID: 906
	// (get) Token: 0x06000B05 RID: 2821 RVA: 0x0003DFE0 File Offset: 0x0003C1E0
	public unsafe string ProfileUrl
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_get_ProfileUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700038B RID: 907
	// (get) Token: 0x06000B06 RID: 2822 RVA: 0x0003E018 File Offset: 0x0003C218
	public unsafe string Email
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_get_Email_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700038C RID: 908
	// (get) Token: 0x06000B07 RID: 2823 RVA: 0x0003E050 File Offset: 0x0003C250
	public unsafe string Locale
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_get_Locale_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700038D RID: 909
	// (get) Token: 0x06000B08 RID: 2824 RVA: 0x0003E088 File Offset: 0x0003C288
	public unsafe string Location
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_get_Location_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700038E RID: 910
	// (get) Token: 0x06000B09 RID: 2825 RVA: 0x0003E0C0 File Offset: 0x0003C2C0
	public unsafe FB_Gender Gender
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12786, RefRangeEnd = 12787, XrefRangeStart = 12786, XrefRangeEnd = 12787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_get_Gender_Public_get_FB_Gender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700038F RID: 911
	// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0003E0FC File Offset: 0x0003C2FC
	public unsafe string AgeRange
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_get_AgeRange_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000390 RID: 912
	// (get) Token: 0x06000B0B RID: 2827 RVA: 0x0003E134 File Offset: 0x0003C334
	public unsafe string PictureUrl
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_get_PictureUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000B0C RID: 2828 RVA: 0x0003E16C File Offset: 0x0003C36C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174152, XrefRangeEnd = 174165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSquareImageLoaded(Texture2D image)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_OnSquareImageLoaded_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B0D RID: 2829 RVA: 0x0003E1B0 File Offset: 0x0003C3B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174165, XrefRangeEnd = 174178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLargeImageLoaded(Texture2D image)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_OnLargeImageLoaded_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B0E RID: 2830 RVA: 0x0003E1F4 File Offset: 0x0003C3F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174178, XrefRangeEnd = 174191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnNormalImageLoaded(Texture2D image)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_OnNormalImageLoaded_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B0F RID: 2831 RVA: 0x0003E238 File Offset: 0x0003C438
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174191, XrefRangeEnd = 174204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSmallImageLoaded(Texture2D image)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(image);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.NativeMethodInfoPtr_OnSmallImageLoaded_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B10 RID: 2832 RVA: 0x0000653A File Offset: 0x0000473A
	public FB_UserInfo(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000373 RID: 883
	// (get) Token: 0x06000B11 RID: 2833 RVA: 0x0003E27C File Offset: 0x0003C47C
	// (set) Token: 0x06000B12 RID: 2834 RVA: 0x00006543 File Offset: 0x00004743
	public unsafe string _id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000374 RID: 884
	// (get) Token: 0x06000B13 RID: 2835 RVA: 0x0003E2A4 File Offset: 0x0003C4A4
	// (set) Token: 0x06000B14 RID: 2836 RVA: 0x00006562 File Offset: 0x00004762
	public unsafe string _name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000375 RID: 885
	// (get) Token: 0x06000B15 RID: 2837 RVA: 0x0003E2CC File Offset: 0x0003C4CC
	// (set) Token: 0x06000B16 RID: 2838 RVA: 0x00006581 File Offset: 0x00004781
	public unsafe string _first_name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__first_name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__first_name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000376 RID: 886
	// (get) Token: 0x06000B17 RID: 2839 RVA: 0x0003E2F4 File Offset: 0x0003C4F4
	// (set) Token: 0x06000B18 RID: 2840 RVA: 0x000065A0 File Offset: 0x000047A0
	public unsafe string _last_name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__last_name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__last_name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000377 RID: 887
	// (get) Token: 0x06000B19 RID: 2841 RVA: 0x0003E31C File Offset: 0x0003C51C
	// (set) Token: 0x06000B1A RID: 2842 RVA: 0x000065BF File Offset: 0x000047BF
	public unsafe string _username
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__username);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__username), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000378 RID: 888
	// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0003E344 File Offset: 0x0003C544
	// (set) Token: 0x06000B1C RID: 2844 RVA: 0x000065DE File Offset: 0x000047DE
	public unsafe string _profile_url
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__profile_url);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__profile_url), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000379 RID: 889
	// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0003E36C File Offset: 0x0003C56C
	// (set) Token: 0x06000B1E RID: 2846 RVA: 0x000065FD File Offset: 0x000047FD
	public unsafe string _email
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__email);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__email), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700037A RID: 890
	// (get) Token: 0x06000B1F RID: 2847 RVA: 0x0003E394 File Offset: 0x0003C594
	// (set) Token: 0x06000B20 RID: 2848 RVA: 0x0000661C File Offset: 0x0000481C
	public unsafe string _location
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__location);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__location), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700037B RID: 891
	// (get) Token: 0x06000B21 RID: 2849 RVA: 0x0003E3BC File Offset: 0x0003C5BC
	// (set) Token: 0x06000B22 RID: 2850 RVA: 0x0000663B File Offset: 0x0000483B
	public unsafe string _locale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__locale);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__locale), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700037C RID: 892
	// (get) Token: 0x06000B23 RID: 2851 RVA: 0x0003E3E4 File Offset: 0x0003C5E4
	// (set) Token: 0x06000B24 RID: 2852 RVA: 0x0000665A File Offset: 0x0000485A
	public unsafe string _rawJSON
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__rawJSON);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__rawJSON), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700037D RID: 893
	// (get) Token: 0x06000B25 RID: 2853 RVA: 0x0003E40C File Offset: 0x0003C60C
	// (set) Token: 0x06000B26 RID: 2854 RVA: 0x00006679 File Offset: 0x00004879
	public unsafe DateTime _Birthday
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__Birthday);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__Birthday)) = value;
		}
	}

	// Token: 0x1700037E RID: 894
	// (get) Token: 0x06000B27 RID: 2855 RVA: 0x0003E434 File Offset: 0x0003C634
	// (set) Token: 0x06000B28 RID: 2856 RVA: 0x00006694 File Offset: 0x00004894
	public unsafe FB_Gender _gender
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__gender);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__gender)) = value;
		}
	}

	// Token: 0x1700037F RID: 895
	// (get) Token: 0x06000B29 RID: 2857 RVA: 0x0003E45C File Offset: 0x0003C65C
	// (set) Token: 0x06000B2A RID: 2858 RVA: 0x000066AF File Offset: 0x000048AF
	public unsafe string _ageRange
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__ageRange);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__ageRange), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000380 RID: 896
	// (get) Token: 0x06000B2B RID: 2859 RVA: 0x0003E484 File Offset: 0x0003C684
	// (set) Token: 0x06000B2C RID: 2860 RVA: 0x000066CE File Offset: 0x000048CE
	public unsafe string _picUrl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__picUrl);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr__picUrl), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000381 RID: 897
	// (get) Token: 0x06000B2D RID: 2861 RVA: 0x0003E4AC File Offset: 0x0003C6AC
	// (set) Token: 0x06000B2E RID: 2862 RVA: 0x000066ED File Offset: 0x000048ED
	public unsafe Dictionary<FB_ProfileImageSize, Texture2D> profileImages
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr_profileImages);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<FB_ProfileImageSize, Texture2D>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr_profileImages), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000382 RID: 898
	// (get) Token: 0x06000B2F RID: 2863 RVA: 0x0003E4DC File Offset: 0x0003C6DC
	// (set) Token: 0x06000B30 RID: 2864 RVA: 0x0000670C File Offset: 0x0000490C
	public unsafe Action<FB_UserInfo> OnProfileImageLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr_OnProfileImageLoaded);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_UserInfo>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_UserInfo.NativeFieldInfoPtr_OnProfileImageLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040008BB RID: 2235
	private static readonly IntPtr NativeFieldInfoPtr__id;

	// Token: 0x040008BC RID: 2236
	private static readonly IntPtr NativeFieldInfoPtr__name;

	// Token: 0x040008BD RID: 2237
	private static readonly IntPtr NativeFieldInfoPtr__first_name;

	// Token: 0x040008BE RID: 2238
	private static readonly IntPtr NativeFieldInfoPtr__last_name;

	// Token: 0x040008BF RID: 2239
	private static readonly IntPtr NativeFieldInfoPtr__username;

	// Token: 0x040008C0 RID: 2240
	private static readonly IntPtr NativeFieldInfoPtr__profile_url;

	// Token: 0x040008C1 RID: 2241
	private static readonly IntPtr NativeFieldInfoPtr__email;

	// Token: 0x040008C2 RID: 2242
	private static readonly IntPtr NativeFieldInfoPtr__location;

	// Token: 0x040008C3 RID: 2243
	private static readonly IntPtr NativeFieldInfoPtr__locale;

	// Token: 0x040008C4 RID: 2244
	private static readonly IntPtr NativeFieldInfoPtr__rawJSON;

	// Token: 0x040008C5 RID: 2245
	private static readonly IntPtr NativeFieldInfoPtr__Birthday;

	// Token: 0x040008C6 RID: 2246
	private static readonly IntPtr NativeFieldInfoPtr__gender;

	// Token: 0x040008C7 RID: 2247
	private static readonly IntPtr NativeFieldInfoPtr__ageRange;

	// Token: 0x040008C8 RID: 2248
	private static readonly IntPtr NativeFieldInfoPtr__picUrl;

	// Token: 0x040008C9 RID: 2249
	private static readonly IntPtr NativeFieldInfoPtr_profileImages;

	// Token: 0x040008CA RID: 2250
	private static readonly IntPtr NativeFieldInfoPtr_OnProfileImageLoaded;

	// Token: 0x040008CB RID: 2251
	private static readonly IntPtr NativeMethodInfoPtr_add_OnProfileImageLoaded_Public_add_Void_Action_1_FB_UserInfo_0;

	// Token: 0x040008CC RID: 2252
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnProfileImageLoaded_Public_rem_Void_Action_1_FB_UserInfo_0;

	// Token: 0x040008CD RID: 2253
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x040008CE RID: 2254
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_0;

	// Token: 0x040008CF RID: 2255
	private static readonly IntPtr NativeMethodInfoPtr_InitializeData_Public_Void_IDictionary_0;

	// Token: 0x040008D0 RID: 2256
	private static readonly IntPtr NativeMethodInfoPtr_GetProfileUrl_Public_String_FB_ProfileImageSize_0;

	// Token: 0x040008D1 RID: 2257
	private static readonly IntPtr NativeMethodInfoPtr_GetProfileImage_Public_Texture2D_FB_ProfileImageSize_0;

	// Token: 0x040008D2 RID: 2258
	private static readonly IntPtr NativeMethodInfoPtr_LoadProfileImage_Public_Void_FB_ProfileImageSize_0;

	// Token: 0x040008D3 RID: 2259
	private static readonly IntPtr NativeMethodInfoPtr_get_RawJSON_Public_get_String_0;

	// Token: 0x040008D4 RID: 2260
	private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

	// Token: 0x040008D5 RID: 2261
	private static readonly IntPtr NativeMethodInfoPtr_get_Birthday_Public_get_DateTime_0;

	// Token: 0x040008D6 RID: 2262
	private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

	// Token: 0x040008D7 RID: 2263
	private static readonly IntPtr NativeMethodInfoPtr_get_FirstName_Public_get_String_0;

	// Token: 0x040008D8 RID: 2264
	private static readonly IntPtr NativeMethodInfoPtr_get_LastName_Public_get_String_0;

	// Token: 0x040008D9 RID: 2265
	private static readonly IntPtr NativeMethodInfoPtr_get_UserName_Public_get_String_0;

	// Token: 0x040008DA RID: 2266
	private static readonly IntPtr NativeMethodInfoPtr_get_ProfileUrl_Public_get_String_0;

	// Token: 0x040008DB RID: 2267
	private static readonly IntPtr NativeMethodInfoPtr_get_Email_Public_get_String_0;

	// Token: 0x040008DC RID: 2268
	private static readonly IntPtr NativeMethodInfoPtr_get_Locale_Public_get_String_0;

	// Token: 0x040008DD RID: 2269
	private static readonly IntPtr NativeMethodInfoPtr_get_Location_Public_get_String_0;

	// Token: 0x040008DE RID: 2270
	private static readonly IntPtr NativeMethodInfoPtr_get_Gender_Public_get_FB_Gender_0;

	// Token: 0x040008DF RID: 2271
	private static readonly IntPtr NativeMethodInfoPtr_get_AgeRange_Public_get_String_0;

	// Token: 0x040008E0 RID: 2272
	private static readonly IntPtr NativeMethodInfoPtr_get_PictureUrl_Public_get_String_0;

	// Token: 0x040008E1 RID: 2273
	private static readonly IntPtr NativeMethodInfoPtr_OnSquareImageLoaded_Private_Void_Texture2D_0;

	// Token: 0x040008E2 RID: 2274
	private static readonly IntPtr NativeMethodInfoPtr_OnLargeImageLoaded_Private_Void_Texture2D_0;

	// Token: 0x040008E3 RID: 2275
	private static readonly IntPtr NativeMethodInfoPtr_OnNormalImageLoaded_Private_Void_Texture2D_0;

	// Token: 0x040008E4 RID: 2276
	private static readonly IntPtr NativeMethodInfoPtr_OnSmallImageLoaded_Private_Void_Texture2D_0;

	// Token: 0x0200037F RID: 895
	[ObfuscatedName("FB_UserInfo+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x0600356E RID: 13678 RVA: 0x000DC6E8 File Offset: 0x000DA8E8
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<FB_UserInfo.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FB_UserInfo>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FB_UserInfo.__c>.NativeClassPtr);
			FB_UserInfo.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_UserInfo.__c>.NativeClassPtr, "<>9");
			FB_UserInfo.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_UserInfo.__c>.NativeClassPtr, "<>9__18_0");
			FB_UserInfo.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_UserInfo.__c>.NativeClassPtr, "<>9__19_0");
			FB_UserInfo.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo.__c>.NativeClassPtr, 100670121);
			FB_UserInfo.__c.NativeMethodInfoPtr___ctor_b__18_0_Internal_Void_FB_UserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo.__c>.NativeClassPtr, 100670122);
			FB_UserInfo.__c.NativeMethodInfoPtr___ctor_b__19_0_Internal_Void_FB_UserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_UserInfo.__c>.NativeClassPtr, 100670123);
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x000DC78C File Offset: 0x000DA98C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_UserInfo.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x000DC7C8 File Offset: 0x000DA9C8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__18_0(FB_UserInfo <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.__c.NativeMethodInfoPtr___ctor_b__18_0_Internal_Void_FB_UserInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x000DC80C File Offset: 0x000DAA0C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__19_0(FB_UserInfo <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_UserInfo.__c.NativeMethodInfoPtr___ctor_b__19_0_Internal_Void_FB_UserInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x00014B32 File Offset: 0x00012D32
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06003573 RID: 13683 RVA: 0x000DC850 File Offset: 0x000DAA50
		// (set) Token: 0x06003574 RID: 13684 RVA: 0x00014B3B File Offset: 0x00012D3B
		public unsafe static FB_UserInfo.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FB_UserInfo.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FB_UserInfo.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FB_UserInfo.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x06003575 RID: 13685 RVA: 0x000DC878 File Offset: 0x000DAA78
		// (set) Token: 0x06003576 RID: 13686 RVA: 0x00014B4D File Offset: 0x00012D4D
		public unsafe static Action<FB_UserInfo> __9__18_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FB_UserInfo.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_UserInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FB_UserInfo.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06003577 RID: 13687 RVA: 0x000DC8A0 File Offset: 0x000DAAA0
		// (set) Token: 0x06003578 RID: 13688 RVA: 0x00014B5F File Offset: 0x00012D5F
		public unsafe static Action<FB_UserInfo> __9__19_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FB_UserInfo.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FB_UserInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FB_UserInfo.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003135 RID: 12597
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003136 RID: 12598
		private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

		// Token: 0x04003137 RID: 12599
		private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

		// Token: 0x04003138 RID: 12600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003139 RID: 12601
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__18_0_Internal_Void_FB_UserInfo_0;

		// Token: 0x0400313A RID: 12602
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__19_0_Internal_Void_FB_UserInfo_0;
	}
}

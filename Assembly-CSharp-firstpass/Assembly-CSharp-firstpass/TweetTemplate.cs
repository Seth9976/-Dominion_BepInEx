using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x020000A6 RID: 166
public class TweetTemplate : Object
{
	// Token: 0x06000C03 RID: 3075 RVA: 0x00041508 File Offset: 0x0003F708
	// Note: this type is marked as 'beforefieldinit'.
	static TweetTemplate()
	{
		Il2CppClassPointerStore<TweetTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TweetTemplate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TweetTemplate>.NativeClassPtr);
		TweetTemplate.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweetTemplate>.NativeClassPtr, "id");
		TweetTemplate.NativeFieldInfoPtr_user_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweetTemplate>.NativeClassPtr, "user_id");
		TweetTemplate.NativeFieldInfoPtr_created_at = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweetTemplate>.NativeClassPtr, "created_at");
		TweetTemplate.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweetTemplate>.NativeClassPtr, "text");
		TweetTemplate.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweetTemplate>.NativeClassPtr, "source");
		TweetTemplate.NativeFieldInfoPtr_in_reply_to_status_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweetTemplate>.NativeClassPtr, "in_reply_to_status_id");
		TweetTemplate.NativeFieldInfoPtr_in_reply_to_user_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweetTemplate>.NativeClassPtr, "in_reply_to_user_id");
		TweetTemplate.NativeFieldInfoPtr_in_reply_to_screen_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweetTemplate>.NativeClassPtr, "in_reply_to_screen_name");
		TweetTemplate.NativeFieldInfoPtr_geo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweetTemplate>.NativeClassPtr, "geo");
		TweetTemplate.NativeFieldInfoPtr_place = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweetTemplate>.NativeClassPtr, "place");
		TweetTemplate.NativeFieldInfoPtr_lang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweetTemplate>.NativeClassPtr, "lang");
		TweetTemplate.NativeFieldInfoPtr_retweet_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweetTemplate>.NativeClassPtr, "retweet_count");
		TweetTemplate.NativeFieldInfoPtr_favorite_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TweetTemplate>.NativeClassPtr, "favorite_count");
		TweetTemplate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TweetTemplate>.NativeClassPtr, 100664761);
	}

	// Token: 0x06000C04 RID: 3076 RVA: 0x00041650 File Offset: 0x0003F850
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TweetTemplate()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TweetTemplate>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TweetTemplate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C05 RID: 3077 RVA: 0x00006C16 File Offset: 0x00004E16
	public TweetTemplate(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170003CC RID: 972
	// (get) Token: 0x06000C06 RID: 3078 RVA: 0x0004168C File Offset: 0x0003F88C
	// (set) Token: 0x06000C07 RID: 3079 RVA: 0x00006C1F File Offset: 0x00004E1F
	public unsafe string id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003CD RID: 973
	// (get) Token: 0x06000C08 RID: 3080 RVA: 0x000416B4 File Offset: 0x0003F8B4
	// (set) Token: 0x06000C09 RID: 3081 RVA: 0x00006C3E File Offset: 0x00004E3E
	public unsafe string user_id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_user_id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_user_id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003CE RID: 974
	// (get) Token: 0x06000C0A RID: 3082 RVA: 0x000416DC File Offset: 0x0003F8DC
	// (set) Token: 0x06000C0B RID: 3083 RVA: 0x00006C5D File Offset: 0x00004E5D
	public unsafe string created_at
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_created_at);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_created_at), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003CF RID: 975
	// (get) Token: 0x06000C0C RID: 3084 RVA: 0x00041704 File Offset: 0x0003F904
	// (set) Token: 0x06000C0D RID: 3085 RVA: 0x00006C7C File Offset: 0x00004E7C
	public unsafe string text
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_text);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003D0 RID: 976
	// (get) Token: 0x06000C0E RID: 3086 RVA: 0x0004172C File Offset: 0x0003F92C
	// (set) Token: 0x06000C0F RID: 3087 RVA: 0x00006C9B File Offset: 0x00004E9B
	public unsafe string source
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_source);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_source), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003D1 RID: 977
	// (get) Token: 0x06000C10 RID: 3088 RVA: 0x00041754 File Offset: 0x0003F954
	// (set) Token: 0x06000C11 RID: 3089 RVA: 0x00006CBA File Offset: 0x00004EBA
	public unsafe string in_reply_to_status_id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_in_reply_to_status_id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_in_reply_to_status_id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003D2 RID: 978
	// (get) Token: 0x06000C12 RID: 3090 RVA: 0x0004177C File Offset: 0x0003F97C
	// (set) Token: 0x06000C13 RID: 3091 RVA: 0x00006CD9 File Offset: 0x00004ED9
	public unsafe string in_reply_to_user_id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_in_reply_to_user_id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_in_reply_to_user_id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003D3 RID: 979
	// (get) Token: 0x06000C14 RID: 3092 RVA: 0x000417A4 File Offset: 0x0003F9A4
	// (set) Token: 0x06000C15 RID: 3093 RVA: 0x00006CF8 File Offset: 0x00004EF8
	public unsafe string in_reply_to_screen_name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_in_reply_to_screen_name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_in_reply_to_screen_name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003D4 RID: 980
	// (get) Token: 0x06000C16 RID: 3094 RVA: 0x000417CC File Offset: 0x0003F9CC
	// (set) Token: 0x06000C17 RID: 3095 RVA: 0x00006D17 File Offset: 0x00004F17
	public unsafe string geo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_geo);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_geo), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003D5 RID: 981
	// (get) Token: 0x06000C18 RID: 3096 RVA: 0x000417F4 File Offset: 0x0003F9F4
	// (set) Token: 0x06000C19 RID: 3097 RVA: 0x00006D36 File Offset: 0x00004F36
	public unsafe string place
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_place);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_place), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003D6 RID: 982
	// (get) Token: 0x06000C1A RID: 3098 RVA: 0x0004181C File Offset: 0x0003FA1C
	// (set) Token: 0x06000C1B RID: 3099 RVA: 0x00006D55 File Offset: 0x00004F55
	public unsafe string lang
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_lang);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_lang), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003D7 RID: 983
	// (get) Token: 0x06000C1C RID: 3100 RVA: 0x00041844 File Offset: 0x0003FA44
	// (set) Token: 0x06000C1D RID: 3101 RVA: 0x00006D74 File Offset: 0x00004F74
	public unsafe int retweet_count
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_retweet_count);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_retweet_count)) = value;
		}
	}

	// Token: 0x170003D8 RID: 984
	// (get) Token: 0x06000C1E RID: 3102 RVA: 0x0004186C File Offset: 0x0003FA6C
	// (set) Token: 0x06000C1F RID: 3103 RVA: 0x00006D8F File Offset: 0x00004F8F
	public unsafe int favorite_count
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_favorite_count);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TweetTemplate.NativeFieldInfoPtr_favorite_count)) = value;
		}
	}

	// Token: 0x0400097C RID: 2428
	private static readonly IntPtr NativeFieldInfoPtr_id;

	// Token: 0x0400097D RID: 2429
	private static readonly IntPtr NativeFieldInfoPtr_user_id;

	// Token: 0x0400097E RID: 2430
	private static readonly IntPtr NativeFieldInfoPtr_created_at;

	// Token: 0x0400097F RID: 2431
	private static readonly IntPtr NativeFieldInfoPtr_text;

	// Token: 0x04000980 RID: 2432
	private static readonly IntPtr NativeFieldInfoPtr_source;

	// Token: 0x04000981 RID: 2433
	private static readonly IntPtr NativeFieldInfoPtr_in_reply_to_status_id;

	// Token: 0x04000982 RID: 2434
	private static readonly IntPtr NativeFieldInfoPtr_in_reply_to_user_id;

	// Token: 0x04000983 RID: 2435
	private static readonly IntPtr NativeFieldInfoPtr_in_reply_to_screen_name;

	// Token: 0x04000984 RID: 2436
	private static readonly IntPtr NativeFieldInfoPtr_geo;

	// Token: 0x04000985 RID: 2437
	private static readonly IntPtr NativeFieldInfoPtr_place;

	// Token: 0x04000986 RID: 2438
	private static readonly IntPtr NativeFieldInfoPtr_lang;

	// Token: 0x04000987 RID: 2439
	private static readonly IntPtr NativeFieldInfoPtr_retweet_count;

	// Token: 0x04000988 RID: 2440
	private static readonly IntPtr NativeFieldInfoPtr_favorite_count;

	// Token: 0x04000989 RID: 2441
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000084 RID: 132
public class FacebookEvents : Object
{
	// Token: 0x0600095C RID: 2396 RVA: 0x000372B4 File Offset: 0x000354B4
	// Note: this type is marked as 'beforefieldinit'.
	static FacebookEvents()
	{
		Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FacebookEvents");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr);
		FacebookEvents.NativeFieldInfoPtr_FACEBOOK_INITED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr, "FACEBOOK_INITED");
		FacebookEvents.NativeFieldInfoPtr_AUTHENTICATION_SUCCEEDED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr, "AUTHENTICATION_SUCCEEDED");
		FacebookEvents.NativeFieldInfoPtr_AUTHENTICATION_FAILED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr, "AUTHENTICATION_FAILED");
		FacebookEvents.NativeFieldInfoPtr_PAYMENT_SUCCEEDED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr, "PAYMENT_SUCCEEDED");
		FacebookEvents.NativeFieldInfoPtr_PAYMENT_FAILED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr, "PAYMENT_FAILED");
		FacebookEvents.NativeFieldInfoPtr_POST_SUCCEEDED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr, "POST_SUCCEEDED");
		FacebookEvents.NativeFieldInfoPtr_POST_FAILED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr, "POST_FAILED");
		FacebookEvents.NativeFieldInfoPtr_APP_REQUEST_COMPLETE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr, "APP_REQUEST_COMPLETE");
		FacebookEvents.NativeFieldInfoPtr_GAME_FOCUS_CHANGED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr, "GAME_FOCUS_CHANGED");
		FacebookEvents.NativeFieldInfoPtr_USER_DATA_LOADED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr, "USER_DATA_LOADED");
		FacebookEvents.NativeFieldInfoPtr_USER_DATA_FAILED_TO_LOAD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr, "USER_DATA_FAILED_TO_LOAD");
		FacebookEvents.NativeFieldInfoPtr_FRIENDS_DATA_LOADED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr, "FRIENDS_DATA_LOADED");
		FacebookEvents.NativeFieldInfoPtr_FRIENDS_FAILED_TO_LOAD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr, "FRIENDS_FAILED_TO_LOAD");
		FacebookEvents.NativeFieldInfoPtr_APP_SCORES_REQUEST_COMPLETE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr, "APP_SCORES_REQUEST_COMPLETE");
		FacebookEvents.NativeFieldInfoPtr_PLAYER_SCORES_REQUEST_COMPLETE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr, "PLAYER_SCORES_REQUEST_COMPLETE");
		FacebookEvents.NativeFieldInfoPtr_SUBMIT_SCORE_REQUEST_COMPLETE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr, "SUBMIT_SCORE_REQUEST_COMPLETE");
		FacebookEvents.NativeFieldInfoPtr_DELETE_SCORES_REQUEST_COMPLETE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr, "DELETE_SCORES_REQUEST_COMPLETE");
		FacebookEvents.NativeFieldInfoPtr_LIKES_LIST_LOADED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr, "LIKES_LIST_LOADED");
		FacebookEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr, 100664421);
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x00037460 File Offset: 0x00035660
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FacebookEvents()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacebookEvents>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacebookEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x00005C4B File Offset: 0x00003E4B
	public FacebookEvents(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002F8 RID: 760
	// (get) Token: 0x0600095F RID: 2399 RVA: 0x0003749C File Offset: 0x0003569C
	// (set) Token: 0x06000960 RID: 2400 RVA: 0x00005C54 File Offset: 0x00003E54
	public unsafe static string FACEBOOK_INITED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(FacebookEvents.NativeFieldInfoPtr_FACEBOOK_INITED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookEvents.NativeFieldInfoPtr_FACEBOOK_INITED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002F9 RID: 761
	// (get) Token: 0x06000961 RID: 2401 RVA: 0x000374BC File Offset: 0x000356BC
	// (set) Token: 0x06000962 RID: 2402 RVA: 0x00005C66 File Offset: 0x00003E66
	public unsafe static string AUTHENTICATION_SUCCEEDED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(FacebookEvents.NativeFieldInfoPtr_AUTHENTICATION_SUCCEEDED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookEvents.NativeFieldInfoPtr_AUTHENTICATION_SUCCEEDED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002FA RID: 762
	// (get) Token: 0x06000963 RID: 2403 RVA: 0x000374DC File Offset: 0x000356DC
	// (set) Token: 0x06000964 RID: 2404 RVA: 0x00005C78 File Offset: 0x00003E78
	public unsafe static string AUTHENTICATION_FAILED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(FacebookEvents.NativeFieldInfoPtr_AUTHENTICATION_FAILED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookEvents.NativeFieldInfoPtr_AUTHENTICATION_FAILED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002FB RID: 763
	// (get) Token: 0x06000965 RID: 2405 RVA: 0x000374FC File Offset: 0x000356FC
	// (set) Token: 0x06000966 RID: 2406 RVA: 0x00005C8A File Offset: 0x00003E8A
	public unsafe static string PAYMENT_SUCCEEDED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(FacebookEvents.NativeFieldInfoPtr_PAYMENT_SUCCEEDED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookEvents.NativeFieldInfoPtr_PAYMENT_SUCCEEDED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002FC RID: 764
	// (get) Token: 0x06000967 RID: 2407 RVA: 0x0003751C File Offset: 0x0003571C
	// (set) Token: 0x06000968 RID: 2408 RVA: 0x00005C9C File Offset: 0x00003E9C
	public unsafe static string PAYMENT_FAILED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(FacebookEvents.NativeFieldInfoPtr_PAYMENT_FAILED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookEvents.NativeFieldInfoPtr_PAYMENT_FAILED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002FD RID: 765
	// (get) Token: 0x06000969 RID: 2409 RVA: 0x0003753C File Offset: 0x0003573C
	// (set) Token: 0x0600096A RID: 2410 RVA: 0x00005CAE File Offset: 0x00003EAE
	public unsafe static string POST_SUCCEEDED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(FacebookEvents.NativeFieldInfoPtr_POST_SUCCEEDED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookEvents.NativeFieldInfoPtr_POST_SUCCEEDED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002FE RID: 766
	// (get) Token: 0x0600096B RID: 2411 RVA: 0x0003755C File Offset: 0x0003575C
	// (set) Token: 0x0600096C RID: 2412 RVA: 0x00005CC0 File Offset: 0x00003EC0
	public unsafe static string POST_FAILED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(FacebookEvents.NativeFieldInfoPtr_POST_FAILED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookEvents.NativeFieldInfoPtr_POST_FAILED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002FF RID: 767
	// (get) Token: 0x0600096D RID: 2413 RVA: 0x0003757C File Offset: 0x0003577C
	// (set) Token: 0x0600096E RID: 2414 RVA: 0x00005CD2 File Offset: 0x00003ED2
	public unsafe static string APP_REQUEST_COMPLETE
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(FacebookEvents.NativeFieldInfoPtr_APP_REQUEST_COMPLETE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookEvents.NativeFieldInfoPtr_APP_REQUEST_COMPLETE, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000300 RID: 768
	// (get) Token: 0x0600096F RID: 2415 RVA: 0x0003759C File Offset: 0x0003579C
	// (set) Token: 0x06000970 RID: 2416 RVA: 0x00005CE4 File Offset: 0x00003EE4
	public unsafe static string GAME_FOCUS_CHANGED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(FacebookEvents.NativeFieldInfoPtr_GAME_FOCUS_CHANGED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookEvents.NativeFieldInfoPtr_GAME_FOCUS_CHANGED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000301 RID: 769
	// (get) Token: 0x06000971 RID: 2417 RVA: 0x000375BC File Offset: 0x000357BC
	// (set) Token: 0x06000972 RID: 2418 RVA: 0x00005CF6 File Offset: 0x00003EF6
	public unsafe static string USER_DATA_LOADED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(FacebookEvents.NativeFieldInfoPtr_USER_DATA_LOADED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookEvents.NativeFieldInfoPtr_USER_DATA_LOADED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000302 RID: 770
	// (get) Token: 0x06000973 RID: 2419 RVA: 0x000375DC File Offset: 0x000357DC
	// (set) Token: 0x06000974 RID: 2420 RVA: 0x00005D08 File Offset: 0x00003F08
	public unsafe static string USER_DATA_FAILED_TO_LOAD
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(FacebookEvents.NativeFieldInfoPtr_USER_DATA_FAILED_TO_LOAD, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookEvents.NativeFieldInfoPtr_USER_DATA_FAILED_TO_LOAD, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000303 RID: 771
	// (get) Token: 0x06000975 RID: 2421 RVA: 0x000375FC File Offset: 0x000357FC
	// (set) Token: 0x06000976 RID: 2422 RVA: 0x00005D1A File Offset: 0x00003F1A
	public unsafe static string FRIENDS_DATA_LOADED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(FacebookEvents.NativeFieldInfoPtr_FRIENDS_DATA_LOADED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookEvents.NativeFieldInfoPtr_FRIENDS_DATA_LOADED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000304 RID: 772
	// (get) Token: 0x06000977 RID: 2423 RVA: 0x0003761C File Offset: 0x0003581C
	// (set) Token: 0x06000978 RID: 2424 RVA: 0x00005D2C File Offset: 0x00003F2C
	public unsafe static string FRIENDS_FAILED_TO_LOAD
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(FacebookEvents.NativeFieldInfoPtr_FRIENDS_FAILED_TO_LOAD, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookEvents.NativeFieldInfoPtr_FRIENDS_FAILED_TO_LOAD, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000305 RID: 773
	// (get) Token: 0x06000979 RID: 2425 RVA: 0x0003763C File Offset: 0x0003583C
	// (set) Token: 0x0600097A RID: 2426 RVA: 0x00005D3E File Offset: 0x00003F3E
	public unsafe static string APP_SCORES_REQUEST_COMPLETE
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(FacebookEvents.NativeFieldInfoPtr_APP_SCORES_REQUEST_COMPLETE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookEvents.NativeFieldInfoPtr_APP_SCORES_REQUEST_COMPLETE, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000306 RID: 774
	// (get) Token: 0x0600097B RID: 2427 RVA: 0x0003765C File Offset: 0x0003585C
	// (set) Token: 0x0600097C RID: 2428 RVA: 0x00005D50 File Offset: 0x00003F50
	public unsafe static string PLAYER_SCORES_REQUEST_COMPLETE
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(FacebookEvents.NativeFieldInfoPtr_PLAYER_SCORES_REQUEST_COMPLETE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookEvents.NativeFieldInfoPtr_PLAYER_SCORES_REQUEST_COMPLETE, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000307 RID: 775
	// (get) Token: 0x0600097D RID: 2429 RVA: 0x0003767C File Offset: 0x0003587C
	// (set) Token: 0x0600097E RID: 2430 RVA: 0x00005D62 File Offset: 0x00003F62
	public unsafe static string SUBMIT_SCORE_REQUEST_COMPLETE
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(FacebookEvents.NativeFieldInfoPtr_SUBMIT_SCORE_REQUEST_COMPLETE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookEvents.NativeFieldInfoPtr_SUBMIT_SCORE_REQUEST_COMPLETE, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000308 RID: 776
	// (get) Token: 0x0600097F RID: 2431 RVA: 0x0003769C File Offset: 0x0003589C
	// (set) Token: 0x06000980 RID: 2432 RVA: 0x00005D74 File Offset: 0x00003F74
	public unsafe static string DELETE_SCORES_REQUEST_COMPLETE
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(FacebookEvents.NativeFieldInfoPtr_DELETE_SCORES_REQUEST_COMPLETE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookEvents.NativeFieldInfoPtr_DELETE_SCORES_REQUEST_COMPLETE, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000309 RID: 777
	// (get) Token: 0x06000981 RID: 2433 RVA: 0x000376BC File Offset: 0x000358BC
	// (set) Token: 0x06000982 RID: 2434 RVA: 0x00005D86 File Offset: 0x00003F86
	public unsafe static string LIKES_LIST_LOADED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(FacebookEvents.NativeFieldInfoPtr_LIKES_LIST_LOADED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(FacebookEvents.NativeFieldInfoPtr_LIKES_LIST_LOADED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000780 RID: 1920
	private static readonly IntPtr NativeFieldInfoPtr_FACEBOOK_INITED;

	// Token: 0x04000781 RID: 1921
	private static readonly IntPtr NativeFieldInfoPtr_AUTHENTICATION_SUCCEEDED;

	// Token: 0x04000782 RID: 1922
	private static readonly IntPtr NativeFieldInfoPtr_AUTHENTICATION_FAILED;

	// Token: 0x04000783 RID: 1923
	private static readonly IntPtr NativeFieldInfoPtr_PAYMENT_SUCCEEDED;

	// Token: 0x04000784 RID: 1924
	private static readonly IntPtr NativeFieldInfoPtr_PAYMENT_FAILED;

	// Token: 0x04000785 RID: 1925
	private static readonly IntPtr NativeFieldInfoPtr_POST_SUCCEEDED;

	// Token: 0x04000786 RID: 1926
	private static readonly IntPtr NativeFieldInfoPtr_POST_FAILED;

	// Token: 0x04000787 RID: 1927
	private static readonly IntPtr NativeFieldInfoPtr_APP_REQUEST_COMPLETE;

	// Token: 0x04000788 RID: 1928
	private static readonly IntPtr NativeFieldInfoPtr_GAME_FOCUS_CHANGED;

	// Token: 0x04000789 RID: 1929
	private static readonly IntPtr NativeFieldInfoPtr_USER_DATA_LOADED;

	// Token: 0x0400078A RID: 1930
	private static readonly IntPtr NativeFieldInfoPtr_USER_DATA_FAILED_TO_LOAD;

	// Token: 0x0400078B RID: 1931
	private static readonly IntPtr NativeFieldInfoPtr_FRIENDS_DATA_LOADED;

	// Token: 0x0400078C RID: 1932
	private static readonly IntPtr NativeFieldInfoPtr_FRIENDS_FAILED_TO_LOAD;

	// Token: 0x0400078D RID: 1933
	private static readonly IntPtr NativeFieldInfoPtr_APP_SCORES_REQUEST_COMPLETE;

	// Token: 0x0400078E RID: 1934
	private static readonly IntPtr NativeFieldInfoPtr_PLAYER_SCORES_REQUEST_COMPLETE;

	// Token: 0x0400078F RID: 1935
	private static readonly IntPtr NativeFieldInfoPtr_SUBMIT_SCORE_REQUEST_COMPLETE;

	// Token: 0x04000790 RID: 1936
	private static readonly IntPtr NativeFieldInfoPtr_DELETE_SCORES_REQUEST_COMPLETE;

	// Token: 0x04000791 RID: 1937
	private static readonly IntPtr NativeFieldInfoPtr_LIKES_LIST_LOADED;

	// Token: 0x04000792 RID: 1938
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

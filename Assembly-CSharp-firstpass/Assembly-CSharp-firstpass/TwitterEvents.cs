using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x020000A7 RID: 167
public class TwitterEvents : Object
{
	// Token: 0x06000C20 RID: 3104 RVA: 0x00041894 File Offset: 0x0003FA94
	// Note: this type is marked as 'beforefieldinit'.
	static TwitterEvents()
	{
		Il2CppClassPointerStore<TwitterEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TwitterEvents");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwitterEvents>.NativeClassPtr);
		TwitterEvents.NativeFieldInfoPtr_TWITTER_INITED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterEvents>.NativeClassPtr, "TWITTER_INITED");
		TwitterEvents.NativeFieldInfoPtr_AUTHENTICATION_SUCCEEDED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterEvents>.NativeClassPtr, "AUTHENTICATION_SUCCEEDED");
		TwitterEvents.NativeFieldInfoPtr_AUTHENTICATION_FAILED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterEvents>.NativeClassPtr, "AUTHENTICATION_FAILED");
		TwitterEvents.NativeFieldInfoPtr_USER_DATA_LOADED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterEvents>.NativeClassPtr, "USER_DATA_LOADED");
		TwitterEvents.NativeFieldInfoPtr_USER_DATA_FAILED_TO_LOAD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterEvents>.NativeClassPtr, "USER_DATA_FAILED_TO_LOAD");
		TwitterEvents.NativeFieldInfoPtr_POST_SUCCEEDED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterEvents>.NativeClassPtr, "POST_SUCCEEDED");
		TwitterEvents.NativeFieldInfoPtr_POST_FAILED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterEvents>.NativeClassPtr, "POST_FAILED");
		TwitterEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterEvents>.NativeClassPtr, 100664762);
	}

	// Token: 0x06000C21 RID: 3105 RVA: 0x00041964 File Offset: 0x0003FB64
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TwitterEvents()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwitterEvents>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C22 RID: 3106 RVA: 0x00006DAA File Offset: 0x00004FAA
	public TwitterEvents(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170003D9 RID: 985
	// (get) Token: 0x06000C23 RID: 3107 RVA: 0x000419A0 File Offset: 0x0003FBA0
	// (set) Token: 0x06000C24 RID: 3108 RVA: 0x00006DB3 File Offset: 0x00004FB3
	public unsafe static string TWITTER_INITED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(TwitterEvents.NativeFieldInfoPtr_TWITTER_INITED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TwitterEvents.NativeFieldInfoPtr_TWITTER_INITED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003DA RID: 986
	// (get) Token: 0x06000C25 RID: 3109 RVA: 0x000419C0 File Offset: 0x0003FBC0
	// (set) Token: 0x06000C26 RID: 3110 RVA: 0x00006DC5 File Offset: 0x00004FC5
	public unsafe static string AUTHENTICATION_SUCCEEDED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(TwitterEvents.NativeFieldInfoPtr_AUTHENTICATION_SUCCEEDED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TwitterEvents.NativeFieldInfoPtr_AUTHENTICATION_SUCCEEDED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003DB RID: 987
	// (get) Token: 0x06000C27 RID: 3111 RVA: 0x000419E0 File Offset: 0x0003FBE0
	// (set) Token: 0x06000C28 RID: 3112 RVA: 0x00006DD7 File Offset: 0x00004FD7
	public unsafe static string AUTHENTICATION_FAILED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(TwitterEvents.NativeFieldInfoPtr_AUTHENTICATION_FAILED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TwitterEvents.NativeFieldInfoPtr_AUTHENTICATION_FAILED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003DC RID: 988
	// (get) Token: 0x06000C29 RID: 3113 RVA: 0x00041A00 File Offset: 0x0003FC00
	// (set) Token: 0x06000C2A RID: 3114 RVA: 0x00006DE9 File Offset: 0x00004FE9
	public unsafe static string USER_DATA_LOADED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(TwitterEvents.NativeFieldInfoPtr_USER_DATA_LOADED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TwitterEvents.NativeFieldInfoPtr_USER_DATA_LOADED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003DD RID: 989
	// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00041A20 File Offset: 0x0003FC20
	// (set) Token: 0x06000C2C RID: 3116 RVA: 0x00006DFB File Offset: 0x00004FFB
	public unsafe static string USER_DATA_FAILED_TO_LOAD
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(TwitterEvents.NativeFieldInfoPtr_USER_DATA_FAILED_TO_LOAD, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TwitterEvents.NativeFieldInfoPtr_USER_DATA_FAILED_TO_LOAD, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003DE RID: 990
	// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00041A40 File Offset: 0x0003FC40
	// (set) Token: 0x06000C2E RID: 3118 RVA: 0x00006E0D File Offset: 0x0000500D
	public unsafe static string POST_SUCCEEDED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(TwitterEvents.NativeFieldInfoPtr_POST_SUCCEEDED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TwitterEvents.NativeFieldInfoPtr_POST_SUCCEEDED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003DF RID: 991
	// (get) Token: 0x06000C2F RID: 3119 RVA: 0x00041A60 File Offset: 0x0003FC60
	// (set) Token: 0x06000C30 RID: 3120 RVA: 0x00006E1F File Offset: 0x0000501F
	public unsafe static string POST_FAILED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(TwitterEvents.NativeFieldInfoPtr_POST_FAILED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TwitterEvents.NativeFieldInfoPtr_POST_FAILED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x0400098A RID: 2442
	private static readonly IntPtr NativeFieldInfoPtr_TWITTER_INITED;

	// Token: 0x0400098B RID: 2443
	private static readonly IntPtr NativeFieldInfoPtr_AUTHENTICATION_SUCCEEDED;

	// Token: 0x0400098C RID: 2444
	private static readonly IntPtr NativeFieldInfoPtr_AUTHENTICATION_FAILED;

	// Token: 0x0400098D RID: 2445
	private static readonly IntPtr NativeFieldInfoPtr_USER_DATA_LOADED;

	// Token: 0x0400098E RID: 2446
	private static readonly IntPtr NativeFieldInfoPtr_USER_DATA_FAILED_TO_LOAD;

	// Token: 0x0400098F RID: 2447
	private static readonly IntPtr NativeFieldInfoPtr_POST_SUCCEEDED;

	// Token: 0x04000990 RID: 2448
	private static readonly IntPtr NativeFieldInfoPtr_POST_FAILED;

	// Token: 0x04000991 RID: 2449
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

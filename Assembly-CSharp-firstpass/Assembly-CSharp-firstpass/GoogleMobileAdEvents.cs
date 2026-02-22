using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000010 RID: 16
public class GoogleMobileAdEvents : Object
{
	// Token: 0x060000D4 RID: 212 RVA: 0x00019EF4 File Offset: 0x000180F4
	// Note: this type is marked as 'beforefieldinit'.
	static GoogleMobileAdEvents()
	{
		Il2CppClassPointerStore<GoogleMobileAdEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GoogleMobileAdEvents");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleMobileAdEvents>.NativeClassPtr);
		GoogleMobileAdEvents.NativeFieldInfoPtr_ON_BANNER_AD_LOADED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleMobileAdEvents>.NativeClassPtr, "ON_BANNER_AD_LOADED");
		GoogleMobileAdEvents.NativeFieldInfoPtr_ON_BANNER_AD_FAILED_LOADING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleMobileAdEvents>.NativeClassPtr, "ON_BANNER_AD_FAILED_LOADING");
		GoogleMobileAdEvents.NativeFieldInfoPtr_ON_BANNER_AD_OPENED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleMobileAdEvents>.NativeClassPtr, "ON_BANNER_AD_OPENED");
		GoogleMobileAdEvents.NativeFieldInfoPtr_ON_BANNER_AD_CLOSED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleMobileAdEvents>.NativeClassPtr, "ON_BANNER_AD_CLOSED");
		GoogleMobileAdEvents.NativeFieldInfoPtr_ON_BANNER_AD_LEFT_APPLICATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleMobileAdEvents>.NativeClassPtr, "ON_BANNER_AD_LEFT_APPLICATION");
		GoogleMobileAdEvents.NativeFieldInfoPtr_ON_INTERSTITIAL_AD_LOADED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleMobileAdEvents>.NativeClassPtr, "ON_INTERSTITIAL_AD_LOADED");
		GoogleMobileAdEvents.NativeFieldInfoPtr_ON_INTERSTITIAL_AD_FAILED_LOADING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleMobileAdEvents>.NativeClassPtr, "ON_INTERSTITIAL_AD_FAILED_LOADING");
		GoogleMobileAdEvents.NativeFieldInfoPtr_ON_INTERSTITIAL_AD_OPENED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleMobileAdEvents>.NativeClassPtr, "ON_INTERSTITIAL_AD_OPENED");
		GoogleMobileAdEvents.NativeFieldInfoPtr_ON_INTERSTITIAL_AD_CLOSED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleMobileAdEvents>.NativeClassPtr, "ON_INTERSTITIAL_AD_CLOSED");
		GoogleMobileAdEvents.NativeFieldInfoPtr_ON_INTERSTITIAL_AD_LEFT_APPLICATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleMobileAdEvents>.NativeClassPtr, "ON_INTERSTITIAL_AD_LEFT_APPLICATION");
		GoogleMobileAdEvents.NativeFieldInfoPtr_ON_AD_IN_APP_REQUEST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleMobileAdEvents>.NativeClassPtr, "ON_AD_IN_APP_REQUEST");
		GoogleMobileAdEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleMobileAdEvents>.NativeClassPtr, 100663436);
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x0001A014 File Offset: 0x00018214
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GoogleMobileAdEvents()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleMobileAdEvents>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleMobileAdEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x000023D2 File Offset: 0x000005D2
	public GoogleMobileAdEvents(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x060000D7 RID: 215 RVA: 0x0001A050 File Offset: 0x00018250
	// (set) Token: 0x060000D8 RID: 216 RVA: 0x000023DB File Offset: 0x000005DB
	public unsafe static string ON_BANNER_AD_LOADED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_BANNER_AD_LOADED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_BANNER_AD_LOADED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x060000D9 RID: 217 RVA: 0x0001A070 File Offset: 0x00018270
	// (set) Token: 0x060000DA RID: 218 RVA: 0x000023ED File Offset: 0x000005ED
	public unsafe static string ON_BANNER_AD_FAILED_LOADING
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_BANNER_AD_FAILED_LOADING, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_BANNER_AD_FAILED_LOADING, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x060000DB RID: 219 RVA: 0x0001A090 File Offset: 0x00018290
	// (set) Token: 0x060000DC RID: 220 RVA: 0x000023FF File Offset: 0x000005FF
	public unsafe static string ON_BANNER_AD_OPENED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_BANNER_AD_OPENED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_BANNER_AD_OPENED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x060000DD RID: 221 RVA: 0x0001A0B0 File Offset: 0x000182B0
	// (set) Token: 0x060000DE RID: 222 RVA: 0x00002411 File Offset: 0x00000611
	public unsafe static string ON_BANNER_AD_CLOSED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_BANNER_AD_CLOSED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_BANNER_AD_CLOSED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x060000DF RID: 223 RVA: 0x0001A0D0 File Offset: 0x000182D0
	// (set) Token: 0x060000E0 RID: 224 RVA: 0x00002423 File Offset: 0x00000623
	public unsafe static string ON_BANNER_AD_LEFT_APPLICATION
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_BANNER_AD_LEFT_APPLICATION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_BANNER_AD_LEFT_APPLICATION, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x060000E1 RID: 225 RVA: 0x0001A0F0 File Offset: 0x000182F0
	// (set) Token: 0x060000E2 RID: 226 RVA: 0x00002435 File Offset: 0x00000635
	public unsafe static string ON_INTERSTITIAL_AD_LOADED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_INTERSTITIAL_AD_LOADED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_INTERSTITIAL_AD_LOADED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x060000E3 RID: 227 RVA: 0x0001A110 File Offset: 0x00018310
	// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002447 File Offset: 0x00000647
	public unsafe static string ON_INTERSTITIAL_AD_FAILED_LOADING
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_INTERSTITIAL_AD_FAILED_LOADING, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_INTERSTITIAL_AD_FAILED_LOADING, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060000E5 RID: 229 RVA: 0x0001A130 File Offset: 0x00018330
	// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002459 File Offset: 0x00000659
	public unsafe static string ON_INTERSTITIAL_AD_OPENED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_INTERSTITIAL_AD_OPENED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_INTERSTITIAL_AD_OPENED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x060000E7 RID: 231 RVA: 0x0001A150 File Offset: 0x00018350
	// (set) Token: 0x060000E8 RID: 232 RVA: 0x0000246B File Offset: 0x0000066B
	public unsafe static string ON_INTERSTITIAL_AD_CLOSED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_INTERSTITIAL_AD_CLOSED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_INTERSTITIAL_AD_CLOSED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x060000E9 RID: 233 RVA: 0x0001A170 File Offset: 0x00018370
	// (set) Token: 0x060000EA RID: 234 RVA: 0x0000247D File Offset: 0x0000067D
	public unsafe static string ON_INTERSTITIAL_AD_LEFT_APPLICATION
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_INTERSTITIAL_AD_LEFT_APPLICATION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_INTERSTITIAL_AD_LEFT_APPLICATION, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x060000EB RID: 235 RVA: 0x0001A190 File Offset: 0x00018390
	// (set) Token: 0x060000EC RID: 236 RVA: 0x0000248F File Offset: 0x0000068F
	public unsafe static string ON_AD_IN_APP_REQUEST
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_AD_IN_APP_REQUEST, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleMobileAdEvents.NativeFieldInfoPtr_ON_AD_IN_APP_REQUEST, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040000D8 RID: 216
	private static readonly IntPtr NativeFieldInfoPtr_ON_BANNER_AD_LOADED;

	// Token: 0x040000D9 RID: 217
	private static readonly IntPtr NativeFieldInfoPtr_ON_BANNER_AD_FAILED_LOADING;

	// Token: 0x040000DA RID: 218
	private static readonly IntPtr NativeFieldInfoPtr_ON_BANNER_AD_OPENED;

	// Token: 0x040000DB RID: 219
	private static readonly IntPtr NativeFieldInfoPtr_ON_BANNER_AD_CLOSED;

	// Token: 0x040000DC RID: 220
	private static readonly IntPtr NativeFieldInfoPtr_ON_BANNER_AD_LEFT_APPLICATION;

	// Token: 0x040000DD RID: 221
	private static readonly IntPtr NativeFieldInfoPtr_ON_INTERSTITIAL_AD_LOADED;

	// Token: 0x040000DE RID: 222
	private static readonly IntPtr NativeFieldInfoPtr_ON_INTERSTITIAL_AD_FAILED_LOADING;

	// Token: 0x040000DF RID: 223
	private static readonly IntPtr NativeFieldInfoPtr_ON_INTERSTITIAL_AD_OPENED;

	// Token: 0x040000E0 RID: 224
	private static readonly IntPtr NativeFieldInfoPtr_ON_INTERSTITIAL_AD_CLOSED;

	// Token: 0x040000E1 RID: 225
	private static readonly IntPtr NativeFieldInfoPtr_ON_INTERSTITIAL_AD_LEFT_APPLICATION;

	// Token: 0x040000E2 RID: 226
	private static readonly IntPtr NativeFieldInfoPtr_ON_AD_IN_APP_REQUEST;

	// Token: 0x040000E3 RID: 227
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

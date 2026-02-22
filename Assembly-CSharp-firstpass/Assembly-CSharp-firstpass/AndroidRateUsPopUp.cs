using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x02000082 RID: 130
public class AndroidRateUsPopUp : BaseAndroidPopup
{
	// Token: 0x0600093D RID: 2365 RVA: 0x00036B38 File Offset: 0x00034D38
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidRateUsPopUp()
	{
		Il2CppClassPointerStore<AndroidRateUsPopUp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidRateUsPopUp");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidRateUsPopUp>.NativeClassPtr);
		AndroidRateUsPopUp.NativeFieldInfoPtr_yes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidRateUsPopUp>.NativeClassPtr, "yes");
		AndroidRateUsPopUp.NativeFieldInfoPtr_later = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidRateUsPopUp>.NativeClassPtr, "later");
		AndroidRateUsPopUp.NativeFieldInfoPtr_no = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidRateUsPopUp>.NativeClassPtr, "no");
		AndroidRateUsPopUp.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidRateUsPopUp>.NativeClassPtr, "url");
		AndroidRateUsPopUp.NativeMethodInfoPtr_Create_Public_Static_AndroidRateUsPopUp_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidRateUsPopUp>.NativeClassPtr, 100664408);
		AndroidRateUsPopUp.NativeMethodInfoPtr_Create_Public_Static_AndroidRateUsPopUp_String_String_String_AndroidDialogTheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidRateUsPopUp>.NativeClassPtr, 100664409);
		AndroidRateUsPopUp.NativeMethodInfoPtr_Create_Public_Static_AndroidRateUsPopUp_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidRateUsPopUp>.NativeClassPtr, 100664410);
		AndroidRateUsPopUp.NativeMethodInfoPtr_Create_Public_Static_AndroidRateUsPopUp_String_String_String_String_String_String_AndroidDialogTheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidRateUsPopUp>.NativeClassPtr, 100664411);
		AndroidRateUsPopUp.NativeMethodInfoPtr_init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidRateUsPopUp>.NativeClassPtr, 100664412);
		AndroidRateUsPopUp.NativeMethodInfoPtr_init_Public_Void_AndroidDialogTheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidRateUsPopUp>.NativeClassPtr, 100664413);
		AndroidRateUsPopUp.NativeMethodInfoPtr_onPopUpCallBack_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidRateUsPopUp>.NativeClassPtr, 100664414);
		AndroidRateUsPopUp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidRateUsPopUp>.NativeClassPtr, 100664415);
	}

	// Token: 0x0600093E RID: 2366 RVA: 0x00036C58 File Offset: 0x00034E58
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 171101, RefRangeEnd = 171102, XrefRangeStart = 171081, XrefRangeEnd = 171101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AndroidRateUsPopUp Create(string title, string message, string url)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidRateUsPopUp.NativeMethodInfoPtr_Create_Public_Static_AndroidRateUsPopUp_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidRateUsPopUp>(intPtr3) : null;
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x00036CC0 File Offset: 0x00034EC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171102, XrefRangeEnd = 171118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AndroidRateUsPopUp Create(string title, string message, string url, AndroidDialogTheme theme)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref theme;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidRateUsPopUp.NativeMethodInfoPtr_Create_Public_Static_AndroidRateUsPopUp_String_String_String_AndroidDialogTheme_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidRateUsPopUp>(intPtr3) : null;
	}

	// Token: 0x06000940 RID: 2368 RVA: 0x00036D38 File Offset: 0x00034F38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171118, XrefRangeEnd = 171132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AndroidRateUsPopUp Create(string title, string message, string url, string yes, string later, string no)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(yes);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(later);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(no);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidRateUsPopUp.NativeMethodInfoPtr_Create_Public_Static_AndroidRateUsPopUp_String_String_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidRateUsPopUp>(intPtr3) : null;
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x00036DD8 File Offset: 0x00034FD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171132, XrefRangeEnd = 171142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AndroidRateUsPopUp Create(string title, string message, string url, string yes, string later, string no, AndroidDialogTheme theme)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(yes);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(later);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(no);
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref theme;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidRateUsPopUp.NativeMethodInfoPtr_Create_Public_Static_AndroidRateUsPopUp_String_String_String_String_String_String_AndroidDialogTheme_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidRateUsPopUp>(intPtr3) : null;
	}

	// Token: 0x06000942 RID: 2370 RVA: 0x00036E88 File Offset: 0x00035088
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171142, XrefRangeEnd = 171147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidRateUsPopUp.NativeMethodInfoPtr_init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x00036EBC File Offset: 0x000350BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171147, XrefRangeEnd = 171148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void init(AndroidDialogTheme theme)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref theme;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidRateUsPopUp.NativeMethodInfoPtr_init_Public_Void_AndroidDialogTheme_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x00036EFC File Offset: 0x000350FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171148, XrefRangeEnd = 171166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onPopUpCallBack(string buttonIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonIndex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidRateUsPopUp.NativeMethodInfoPtr_onPopUpCallBack_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x00036F40 File Offset: 0x00035140
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidRateUsPopUp()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidRateUsPopUp>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidRateUsPopUp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x00005B60 File Offset: 0x00003D60
	public AndroidRateUsPopUp(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002F1 RID: 753
	// (get) Token: 0x06000947 RID: 2375 RVA: 0x00036F7C File Offset: 0x0003517C
	// (set) Token: 0x06000948 RID: 2376 RVA: 0x00005B69 File Offset: 0x00003D69
	public unsafe string yes
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidRateUsPopUp.NativeFieldInfoPtr_yes);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidRateUsPopUp.NativeFieldInfoPtr_yes), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002F2 RID: 754
	// (get) Token: 0x06000949 RID: 2377 RVA: 0x00036FA4 File Offset: 0x000351A4
	// (set) Token: 0x0600094A RID: 2378 RVA: 0x00005B88 File Offset: 0x00003D88
	public unsafe string later
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidRateUsPopUp.NativeFieldInfoPtr_later);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidRateUsPopUp.NativeFieldInfoPtr_later), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002F3 RID: 755
	// (get) Token: 0x0600094B RID: 2379 RVA: 0x00036FCC File Offset: 0x000351CC
	// (set) Token: 0x0600094C RID: 2380 RVA: 0x00005BA7 File Offset: 0x00003DA7
	public unsafe string no
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidRateUsPopUp.NativeFieldInfoPtr_no);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidRateUsPopUp.NativeFieldInfoPtr_no), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002F4 RID: 756
	// (get) Token: 0x0600094D RID: 2381 RVA: 0x00036FF4 File Offset: 0x000351F4
	// (set) Token: 0x0600094E RID: 2382 RVA: 0x00005BC6 File Offset: 0x00003DC6
	public unsafe string url
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidRateUsPopUp.NativeFieldInfoPtr_url);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidRateUsPopUp.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x0400076C RID: 1900
	private static readonly IntPtr NativeFieldInfoPtr_yes;

	// Token: 0x0400076D RID: 1901
	private static readonly IntPtr NativeFieldInfoPtr_later;

	// Token: 0x0400076E RID: 1902
	private static readonly IntPtr NativeFieldInfoPtr_no;

	// Token: 0x0400076F RID: 1903
	private static readonly IntPtr NativeFieldInfoPtr_url;

	// Token: 0x04000770 RID: 1904
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AndroidRateUsPopUp_String_String_String_0;

	// Token: 0x04000771 RID: 1905
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AndroidRateUsPopUp_String_String_String_AndroidDialogTheme_0;

	// Token: 0x04000772 RID: 1906
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AndroidRateUsPopUp_String_String_String_String_String_String_0;

	// Token: 0x04000773 RID: 1907
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AndroidRateUsPopUp_String_String_String_String_String_String_AndroidDialogTheme_0;

	// Token: 0x04000774 RID: 1908
	private static readonly IntPtr NativeMethodInfoPtr_init_Public_Void_0;

	// Token: 0x04000775 RID: 1909
	private static readonly IntPtr NativeMethodInfoPtr_init_Public_Void_AndroidDialogTheme_0;

	// Token: 0x04000776 RID: 1910
	private static readonly IntPtr NativeMethodInfoPtr_onPopUpCallBack_Public_Void_String_0;

	// Token: 0x04000777 RID: 1911
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

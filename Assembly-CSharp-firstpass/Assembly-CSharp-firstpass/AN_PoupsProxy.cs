using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x020000C7 RID: 199
public class AN_PoupsProxy : Object
{
	// Token: 0x06000E62 RID: 3682 RVA: 0x0004A208 File Offset: 0x00048408
	// Note: this type is marked as 'beforefieldinit'.
	static AN_PoupsProxy()
	{
		Il2CppClassPointerStore<AN_PoupsProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_PoupsProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_PoupsProxy>.NativeClassPtr);
		AN_PoupsProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_PoupsProxy>.NativeClassPtr, "CLASS_NAME");
		AN_PoupsProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PoupsProxy>.NativeClassPtr, 100665107);
		AN_PoupsProxy.NativeMethodInfoPtr_showDialog_Public_Static_Void_String_String_AndroidDialogTheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PoupsProxy>.NativeClassPtr, 100665108);
		AN_PoupsProxy.NativeMethodInfoPtr_showDialog_Public_Static_Void_String_String_String_String_AndroidDialogTheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PoupsProxy>.NativeClassPtr, 100665109);
		AN_PoupsProxy.NativeMethodInfoPtr_showMessage_Public_Static_Void_String_String_AndroidDialogTheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PoupsProxy>.NativeClassPtr, 100665110);
		AN_PoupsProxy.NativeMethodInfoPtr_showMessage_Public_Static_Void_String_String_String_AndroidDialogTheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PoupsProxy>.NativeClassPtr, 100665111);
		AN_PoupsProxy.NativeMethodInfoPtr_OpenAppRatePage_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PoupsProxy>.NativeClassPtr, 100665112);
		AN_PoupsProxy.NativeMethodInfoPtr_showRateDialog_Public_Static_Void_String_String_String_String_String_AndroidDialogTheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PoupsProxy>.NativeClassPtr, 100665113);
		AN_PoupsProxy.NativeMethodInfoPtr_ShowPreloader_Public_Static_Void_String_String_AndroidDialogTheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PoupsProxy>.NativeClassPtr, 100665114);
		AN_PoupsProxy.NativeMethodInfoPtr_HidePreloader_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PoupsProxy>.NativeClassPtr, 100665115);
		AN_PoupsProxy.NativeMethodInfoPtr_HideCurrentPopup_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PoupsProxy>.NativeClassPtr, 100665116);
		AN_PoupsProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_PoupsProxy>.NativeClassPtr, 100665117);
	}

	// Token: 0x06000E63 RID: 3683 RVA: 0x0004A328 File Offset: 0x00048528
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178582, XrefRangeEnd = 178583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PoupsProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E64 RID: 3684 RVA: 0x0004A380 File Offset: 0x00048580
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178583, XrefRangeEnd = 178588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void showDialog(string title, string message, AndroidDialogTheme theme = AndroidDialogTheme.ThemeDeviceDefaultDark)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref theme;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PoupsProxy.NativeMethodInfoPtr_showDialog_Public_Static_Void_String_String_AndroidDialogTheme_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E65 RID: 3685 RVA: 0x0004A3D8 File Offset: 0x000485D8
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 178601, RefRangeEnd = 178608, XrefRangeStart = 178588, XrefRangeEnd = 178601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void showDialog(string title, string message, string yes, string no, AndroidDialogTheme theme = AndroidDialogTheme.ThemeDeviceDefaultDark)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(yes);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(no);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref theme;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PoupsProxy.NativeMethodInfoPtr_showDialog_Public_Static_Void_String_String_String_String_AndroidDialogTheme_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E66 RID: 3686 RVA: 0x0004A454 File Offset: 0x00048654
	[CallerCount(43)]
	[CachedScanResults(RefRangeStart = 178611, RefRangeEnd = 178654, XrefRangeStart = 178608, XrefRangeEnd = 178611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void showMessage(string title, string message, AndroidDialogTheme theme = AndroidDialogTheme.ThemeDeviceDefaultDark)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref theme;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PoupsProxy.NativeMethodInfoPtr_showMessage_Public_Static_Void_String_String_AndroidDialogTheme_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E67 RID: 3687 RVA: 0x0004A4AC File Offset: 0x000486AC
	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 178666, RefRangeEnd = 178685, XrefRangeStart = 178654, XrefRangeEnd = 178666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void showMessage(string title, string message, string ok, AndroidDialogTheme theme = AndroidDialogTheme.ThemeDeviceDefaultDark)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ok);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref theme;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PoupsProxy.NativeMethodInfoPtr_showMessage_Public_Static_Void_String_String_String_AndroidDialogTheme_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E68 RID: 3688 RVA: 0x0004A514 File Offset: 0x00048714
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 178691, RefRangeEnd = 178694, XrefRangeStart = 178685, XrefRangeEnd = 178691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OpenAppRatePage(string url)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PoupsProxy.NativeMethodInfoPtr_OpenAppRatePage_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E69 RID: 3689 RVA: 0x0004A54C File Offset: 0x0004874C
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 178708, RefRangeEnd = 178714, XrefRangeStart = 178694, XrefRangeEnd = 178708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void showRateDialog(string title, string message, string yes, string laiter, string no, AndroidDialogTheme theme = AndroidDialogTheme.ThemeDeviceDefaultDark)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(yes);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(laiter);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(no);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref theme;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PoupsProxy.NativeMethodInfoPtr_showRateDialog_Public_Static_Void_String_String_String_String_String_AndroidDialogTheme_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E6A RID: 3690 RVA: 0x0004A5DC File Offset: 0x000487DC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 178725, RefRangeEnd = 178727, XrefRangeStart = 178714, XrefRangeEnd = 178725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowPreloader(string title, string message, AndroidDialogTheme theme = AndroidDialogTheme.ThemeDeviceDefaultDark)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref theme;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PoupsProxy.NativeMethodInfoPtr_ShowPreloader_Public_Static_Void_String_String_AndroidDialogTheme_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E6B RID: 3691 RVA: 0x0004A634 File Offset: 0x00048834
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178732, RefRangeEnd = 178733, XrefRangeStart = 178727, XrefRangeEnd = 178732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HidePreloader()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PoupsProxy.NativeMethodInfoPtr_HidePreloader_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E6C RID: 3692 RVA: 0x0004A65C File Offset: 0x0004885C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178738, RefRangeEnd = 178739, XrefRangeStart = 178733, XrefRangeEnd = 178738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HideCurrentPopup()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PoupsProxy.NativeMethodInfoPtr_HideCurrentPopup_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E6D RID: 3693 RVA: 0x0004A684 File Offset: 0x00048884
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_PoupsProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_PoupsProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_PoupsProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E6E RID: 3694 RVA: 0x0000774D File Offset: 0x0000594D
	public static void CallActivityFunction(string methodName, params Object[] args)
	{
		AN_PoupsProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000E6F RID: 3695 RVA: 0x0000775B File Offset: 0x0000595B
	public AN_PoupsProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700043D RID: 1085
	// (get) Token: 0x06000E70 RID: 3696 RVA: 0x0004A6C0 File Offset: 0x000488C0
	// (set) Token: 0x06000E71 RID: 3697 RVA: 0x00007764 File Offset: 0x00005964
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_PoupsProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_PoupsProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000B2E RID: 2862
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000B2F RID: 2863
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000B30 RID: 2864
	private static readonly IntPtr NativeMethodInfoPtr_showDialog_Public_Static_Void_String_String_AndroidDialogTheme_0;

	// Token: 0x04000B31 RID: 2865
	private static readonly IntPtr NativeMethodInfoPtr_showDialog_Public_Static_Void_String_String_String_String_AndroidDialogTheme_0;

	// Token: 0x04000B32 RID: 2866
	private static readonly IntPtr NativeMethodInfoPtr_showMessage_Public_Static_Void_String_String_AndroidDialogTheme_0;

	// Token: 0x04000B33 RID: 2867
	private static readonly IntPtr NativeMethodInfoPtr_showMessage_Public_Static_Void_String_String_String_AndroidDialogTheme_0;

	// Token: 0x04000B34 RID: 2868
	private static readonly IntPtr NativeMethodInfoPtr_OpenAppRatePage_Public_Static_Void_String_0;

	// Token: 0x04000B35 RID: 2869
	private static readonly IntPtr NativeMethodInfoPtr_showRateDialog_Public_Static_Void_String_String_String_String_String_AndroidDialogTheme_0;

	// Token: 0x04000B36 RID: 2870
	private static readonly IntPtr NativeMethodInfoPtr_ShowPreloader_Public_Static_Void_String_String_AndroidDialogTheme_0;

	// Token: 0x04000B37 RID: 2871
	private static readonly IntPtr NativeMethodInfoPtr_HidePreloader_Public_Static_Void_0;

	// Token: 0x04000B38 RID: 2872
	private static readonly IntPtr NativeMethodInfoPtr_HideCurrentPopup_Public_Static_Void_0;

	// Token: 0x04000B39 RID: 2873
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

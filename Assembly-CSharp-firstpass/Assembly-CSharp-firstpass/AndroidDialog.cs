using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x0200007E RID: 126
public class AndroidDialog : BaseAndroidPopup
{
	// Token: 0x06000921 RID: 2337 RVA: 0x0003635C File Offset: 0x0003455C
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidDialog()
	{
		Il2CppClassPointerStore<AndroidDialog>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidDialog");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidDialog>.NativeClassPtr);
		AndroidDialog.NativeFieldInfoPtr_yes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidDialog>.NativeClassPtr, "yes");
		AndroidDialog.NativeFieldInfoPtr_no = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidDialog>.NativeClassPtr, "no");
		AndroidDialog.NativeMethodInfoPtr_Create_Public_Static_AndroidDialog_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidDialog>.NativeClassPtr, 100664392);
		AndroidDialog.NativeMethodInfoPtr_Create_Public_Static_AndroidDialog_String_String_AndroidDialogTheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidDialog>.NativeClassPtr, 100664393);
		AndroidDialog.NativeMethodInfoPtr_Create_Public_Static_AndroidDialog_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidDialog>.NativeClassPtr, 100664394);
		AndroidDialog.NativeMethodInfoPtr_Create_Public_Static_AndroidDialog_String_String_String_String_AndroidDialogTheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidDialog>.NativeClassPtr, 100664395);
		AndroidDialog.NativeMethodInfoPtr_init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidDialog>.NativeClassPtr, 100664396);
		AndroidDialog.NativeMethodInfoPtr_init_Public_Void_AndroidDialogTheme_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidDialog>.NativeClassPtr, 100664397);
		AndroidDialog.NativeMethodInfoPtr_onPopUpCallBack_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidDialog>.NativeClassPtr, 100664398);
		AndroidDialog.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidDialog>.NativeClassPtr, 100664399);
	}

	// Token: 0x06000922 RID: 2338 RVA: 0x00036454 File Offset: 0x00034654
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 170323, RefRangeEnd = 170325, XrefRangeStart = 170305, XrefRangeEnd = 170323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AndroidDialog Create(string title, string message)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidDialog.NativeMethodInfoPtr_Create_Public_Static_AndroidDialog_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidDialog>(intPtr3) : null;
	}

	// Token: 0x06000923 RID: 2339 RVA: 0x000364AC File Offset: 0x000346AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170325, XrefRangeEnd = 170339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AndroidDialog Create(string title, string message, AndroidDialogTheme theme)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidDialog.NativeMethodInfoPtr_Create_Public_Static_AndroidDialog_String_String_AndroidDialogTheme_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidDialog>(intPtr3) : null;
	}

	// Token: 0x06000924 RID: 2340 RVA: 0x00036510 File Offset: 0x00034710
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 170353, RefRangeEnd = 170358, XrefRangeStart = 170339, XrefRangeEnd = 170353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AndroidDialog Create(string title, string message, string yes, string no)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(yes);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(no);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidDialog.NativeMethodInfoPtr_Create_Public_Static_AndroidDialog_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidDialog>(intPtr3) : null;
	}

	// Token: 0x06000925 RID: 2341 RVA: 0x0003658C File Offset: 0x0003478C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170358, XrefRangeEnd = 170368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AndroidDialog Create(string title, string message, string yes, string no, AndroidDialogTheme theme)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidDialog.NativeMethodInfoPtr_Create_Public_Static_AndroidDialog_String_String_String_String_AndroidDialogTheme_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidDialog>(intPtr3) : null;
	}

	// Token: 0x06000926 RID: 2342 RVA: 0x00036614 File Offset: 0x00034814
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170368, XrefRangeEnd = 170373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidDialog.NativeMethodInfoPtr_init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000927 RID: 2343 RVA: 0x00036648 File Offset: 0x00034848
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170373, XrefRangeEnd = 170374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void init(AndroidDialogTheme theme)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref theme;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidDialog.NativeMethodInfoPtr_init_Public_Void_AndroidDialogTheme_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000928 RID: 2344 RVA: 0x00036688 File Offset: 0x00034888
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170374, XrefRangeEnd = 170970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onPopUpCallBack(string buttonIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonIndex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidDialog.NativeMethodInfoPtr_onPopUpCallBack_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000929 RID: 2345 RVA: 0x000366CC File Offset: 0x000348CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170970, XrefRangeEnd = 170971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidDialog()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidDialog>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidDialog.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x00005AD2 File Offset: 0x00003CD2
	public AndroidDialog(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002ED RID: 749
	// (get) Token: 0x0600092B RID: 2347 RVA: 0x00036708 File Offset: 0x00034908
	// (set) Token: 0x0600092C RID: 2348 RVA: 0x00005ADB File Offset: 0x00003CDB
	public unsafe string yes
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidDialog.NativeFieldInfoPtr_yes);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidDialog.NativeFieldInfoPtr_yes), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002EE RID: 750
	// (get) Token: 0x0600092D RID: 2349 RVA: 0x00036730 File Offset: 0x00034930
	// (set) Token: 0x0600092E RID: 2350 RVA: 0x00005AFA File Offset: 0x00003CFA
	public unsafe string no
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidDialog.NativeFieldInfoPtr_no);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidDialog.NativeFieldInfoPtr_no), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x0400074B RID: 1867
	private static readonly IntPtr NativeFieldInfoPtr_yes;

	// Token: 0x0400074C RID: 1868
	private static readonly IntPtr NativeFieldInfoPtr_no;

	// Token: 0x0400074D RID: 1869
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AndroidDialog_String_String_0;

	// Token: 0x0400074E RID: 1870
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AndroidDialog_String_String_AndroidDialogTheme_0;

	// Token: 0x0400074F RID: 1871
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AndroidDialog_String_String_String_String_0;

	// Token: 0x04000750 RID: 1872
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AndroidDialog_String_String_String_String_AndroidDialogTheme_0;

	// Token: 0x04000751 RID: 1873
	private static readonly IntPtr NativeMethodInfoPtr_init_Public_Void_0;

	// Token: 0x04000752 RID: 1874
	private static readonly IntPtr NativeMethodInfoPtr_init_Public_Void_AndroidDialogTheme_0;

	// Token: 0x04000753 RID: 1875
	private static readonly IntPtr NativeMethodInfoPtr_onPopUpCallBack_Public_Void_String_0;

	// Token: 0x04000754 RID: 1876
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

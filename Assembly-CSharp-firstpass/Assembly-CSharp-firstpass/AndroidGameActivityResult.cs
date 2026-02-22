using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200004F RID: 79
public class AndroidGameActivityResult : Object
{
	// Token: 0x0600068B RID: 1675 RVA: 0x0002D608 File Offset: 0x0002B808
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidGameActivityResult()
	{
		Il2CppClassPointerStore<AndroidGameActivityResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidGameActivityResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidGameActivityResult>.NativeClassPtr);
		AndroidGameActivityResult.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidGameActivityResult>.NativeClassPtr, "code");
		AndroidGameActivityResult.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidGameActivityResult>.NativeClassPtr, 100664089);
	}

	// Token: 0x0600068C RID: 1676 RVA: 0x0002D660 File Offset: 0x0002B860
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidGameActivityResult()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidGameActivityResult>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidGameActivityResult.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600068D RID: 1677 RVA: 0x00004ACD File Offset: 0x00002CCD
	public AndroidGameActivityResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000239 RID: 569
	// (get) Token: 0x0600068E RID: 1678 RVA: 0x0002D69C File Offset: 0x0002B89C
	// (set) Token: 0x0600068F RID: 1679 RVA: 0x00004AD6 File Offset: 0x00002CD6
	public unsafe GP_GamesActivityResultCodes code
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidGameActivityResult.NativeFieldInfoPtr_code);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidGameActivityResult.NativeFieldInfoPtr_code)) = value;
		}
	}

	// Token: 0x04000556 RID: 1366
	private static readonly IntPtr NativeFieldInfoPtr_code;

	// Token: 0x04000557 RID: 1367
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

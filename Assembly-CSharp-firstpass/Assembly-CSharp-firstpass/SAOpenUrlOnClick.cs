using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x020000FC RID: 252
public class SAOpenUrlOnClick : SAOnClickAction
{
	// Token: 0x06001185 RID: 4485 RVA: 0x000542B4 File Offset: 0x000524B4
	// Note: this type is marked as 'beforefieldinit'.
	static SAOpenUrlOnClick()
	{
		Il2CppClassPointerStore<SAOpenUrlOnClick>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SAOpenUrlOnClick");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SAOpenUrlOnClick>.NativeClassPtr);
		SAOpenUrlOnClick.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SAOpenUrlOnClick>.NativeClassPtr, "url");
		SAOpenUrlOnClick.NativeMethodInfoPtr_OnClick_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SAOpenUrlOnClick>.NativeClassPtr, 100665429);
		SAOpenUrlOnClick.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SAOpenUrlOnClick>.NativeClassPtr, 100665430);
	}

	// Token: 0x06001186 RID: 4486 RVA: 0x00054320 File Offset: 0x00052520
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181764, XrefRangeEnd = 181765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SAOpenUrlOnClick.NativeMethodInfoPtr_OnClick_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001187 RID: 4487 RVA: 0x0005435C File Offset: 0x0005255C
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SAOpenUrlOnClick()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SAOpenUrlOnClick>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SAOpenUrlOnClick.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001188 RID: 4488 RVA: 0x00008BD3 File Offset: 0x00006DD3
	public SAOpenUrlOnClick(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000532 RID: 1330
	// (get) Token: 0x06001189 RID: 4489 RVA: 0x00054398 File Offset: 0x00052598
	// (set) Token: 0x0600118A RID: 4490 RVA: 0x00008BDC File Offset: 0x00006DDC
	public unsafe string url
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SAOpenUrlOnClick.NativeFieldInfoPtr_url);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SAOpenUrlOnClick.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000D91 RID: 3473
	private static readonly IntPtr NativeFieldInfoPtr_url;

	// Token: 0x04000D92 RID: 3474
	private static readonly IntPtr NativeMethodInfoPtr_OnClick_Protected_Virtual_Void_0;

	// Token: 0x04000D93 RID: 3475
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

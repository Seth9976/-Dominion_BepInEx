using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200009E RID: 158
public class InstagramEvents : Object
{
	// Token: 0x06000B78 RID: 2936 RVA: 0x0003F34C File Offset: 0x0003D54C
	// Note: this type is marked as 'beforefieldinit'.
	static InstagramEvents()
	{
		Il2CppClassPointerStore<InstagramEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "InstagramEvents");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstagramEvents>.NativeClassPtr);
		InstagramEvents.NativeFieldInfoPtr_POST_SUCCEEDED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstagramEvents>.NativeClassPtr, "POST_SUCCEEDED");
		InstagramEvents.NativeFieldInfoPtr_POST_FAILED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstagramEvents>.NativeClassPtr, "POST_FAILED");
		InstagramEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstagramEvents>.NativeClassPtr, 100664680);
	}

	// Token: 0x06000B79 RID: 2937 RVA: 0x0003F3B8 File Offset: 0x0003D5B8
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InstagramEvents()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstagramEvents>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstagramEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B7A RID: 2938 RVA: 0x0000697E File Offset: 0x00004B7E
	public InstagramEvents(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170003AC RID: 940
	// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0003F3F4 File Offset: 0x0003D5F4
	// (set) Token: 0x06000B7C RID: 2940 RVA: 0x00006987 File Offset: 0x00004B87
	public unsafe static string POST_SUCCEEDED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(InstagramEvents.NativeFieldInfoPtr_POST_SUCCEEDED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(InstagramEvents.NativeFieldInfoPtr_POST_SUCCEEDED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003AD RID: 941
	// (get) Token: 0x06000B7D RID: 2941 RVA: 0x0003F414 File Offset: 0x0003D614
	// (set) Token: 0x06000B7E RID: 2942 RVA: 0x00006999 File Offset: 0x00004B99
	public unsafe static string POST_FAILED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(InstagramEvents.NativeFieldInfoPtr_POST_FAILED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(InstagramEvents.NativeFieldInfoPtr_POST_FAILED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000910 RID: 2320
	private static readonly IntPtr NativeFieldInfoPtr_POST_SUCCEEDED;

	// Token: 0x04000911 RID: 2321
	private static readonly IntPtr NativeFieldInfoPtr_POST_FAILED;

	// Token: 0x04000912 RID: 2322
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

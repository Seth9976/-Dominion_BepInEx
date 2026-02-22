using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x020000F3 RID: 243
public class AndroidABOrganization : Object
{
	// Token: 0x06001120 RID: 4384 RVA: 0x00053004 File Offset: 0x00051204
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidABOrganization()
	{
		Il2CppClassPointerStore<AndroidABOrganization>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidABOrganization");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidABOrganization>.NativeClassPtr);
		AndroidABOrganization.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidABOrganization>.NativeClassPtr, "name");
		AndroidABOrganization.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidABOrganization>.NativeClassPtr, "title");
		AndroidABOrganization.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidABOrganization>.NativeClassPtr, 100665396);
	}

	// Token: 0x06001121 RID: 4385 RVA: 0x00053070 File Offset: 0x00051270
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidABOrganization()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidABOrganization>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidABOrganization.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001122 RID: 4386 RVA: 0x0000887F File Offset: 0x00006A7F
	public AndroidABOrganization(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000513 RID: 1299
	// (get) Token: 0x06001123 RID: 4387 RVA: 0x000530AC File Offset: 0x000512AC
	// (set) Token: 0x06001124 RID: 4388 RVA: 0x00008888 File Offset: 0x00006A88
	public unsafe string name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABOrganization.NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABOrganization.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000514 RID: 1300
	// (get) Token: 0x06001125 RID: 4389 RVA: 0x000530D4 File Offset: 0x000512D4
	// (set) Token: 0x06001126 RID: 4390 RVA: 0x000088A7 File Offset: 0x00006AA7
	public unsafe string title
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABOrganization.NativeFieldInfoPtr_title);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABOrganization.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000D57 RID: 3415
	private static readonly IntPtr NativeFieldInfoPtr_name;

	// Token: 0x04000D58 RID: 3416
	private static readonly IntPtr NativeFieldInfoPtr_title;

	// Token: 0x04000D59 RID: 3417
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

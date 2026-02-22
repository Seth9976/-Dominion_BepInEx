using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x020000F2 RID: 242
public class AndroidABEmail : Object
{
	// Token: 0x06001119 RID: 4377 RVA: 0x00052F0C File Offset: 0x0005110C
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidABEmail()
	{
		Il2CppClassPointerStore<AndroidABEmail>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidABEmail");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidABEmail>.NativeClassPtr);
		AndroidABEmail.NativeFieldInfoPtr_email = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidABEmail>.NativeClassPtr, "email");
		AndroidABEmail.NativeFieldInfoPtr_emailType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidABEmail>.NativeClassPtr, "emailType");
		AndroidABEmail.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidABEmail>.NativeClassPtr, 100665395);
	}

	// Token: 0x0600111A RID: 4378 RVA: 0x00052F78 File Offset: 0x00051178
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidABEmail()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidABEmail>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidABEmail.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600111B RID: 4379 RVA: 0x00008838 File Offset: 0x00006A38
	public AndroidABEmail(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000511 RID: 1297
	// (get) Token: 0x0600111C RID: 4380 RVA: 0x00052FB4 File Offset: 0x000511B4
	// (set) Token: 0x0600111D RID: 4381 RVA: 0x00008841 File Offset: 0x00006A41
	public unsafe string email
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABEmail.NativeFieldInfoPtr_email);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABEmail.NativeFieldInfoPtr_email), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000512 RID: 1298
	// (get) Token: 0x0600111E RID: 4382 RVA: 0x00052FDC File Offset: 0x000511DC
	// (set) Token: 0x0600111F RID: 4383 RVA: 0x00008860 File Offset: 0x00006A60
	public unsafe string emailType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABEmail.NativeFieldInfoPtr_emailType);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABEmail.NativeFieldInfoPtr_emailType), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000D54 RID: 3412
	private static readonly IntPtr NativeFieldInfoPtr_email;

	// Token: 0x04000D55 RID: 3413
	private static readonly IntPtr NativeFieldInfoPtr_emailType;

	// Token: 0x04000D56 RID: 3414
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

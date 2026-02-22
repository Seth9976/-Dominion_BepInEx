using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000069 RID: 105
[Serializable]
public sealed class VerifyAccountData : ValueType
{
	// Token: 0x06000DC7 RID: 3527 RVA: 0x0000A1C7 File Offset: 0x000083C7
	// Note: this type is marked as 'beforefieldinit'.
	static VerifyAccountData()
	{
		Il2CppClassPointerStore<VerifyAccountData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "VerifyAccountData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerifyAccountData>.NativeClassPtr);
		VerifyAccountData.NativeFieldInfoPtr_username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyAccountData>.NativeClassPtr, "username");
	}

	// Token: 0x06000DC8 RID: 3528 RVA: 0x0000A200 File Offset: 0x00008400
	public VerifyAccountData(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x06000DC9 RID: 3529 RVA: 0x0000A209 File Offset: 0x00008409
	public VerifyAccountData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VerifyAccountData>.NativeClassPtr))
	{
	}

	// Token: 0x170004B7 RID: 1207
	// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00041E8C File Offset: 0x0004008C
	// (set) Token: 0x06000DCB RID: 3531 RVA: 0x0000A21B File Offset: 0x0000841B
	public unsafe string username
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerifyAccountData.NativeFieldInfoPtr_username);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerifyAccountData.NativeFieldInfoPtr_username), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x0400096D RID: 2413
	private static readonly IntPtr NativeFieldInfoPtr_username;
}

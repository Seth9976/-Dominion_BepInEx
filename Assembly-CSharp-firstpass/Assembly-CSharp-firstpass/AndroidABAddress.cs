using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x020000F0 RID: 240
public class AndroidABAddress : Object
{
	// Token: 0x06001101 RID: 4353 RVA: 0x00052BF0 File Offset: 0x00050DF0
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidABAddress()
	{
		Il2CppClassPointerStore<AndroidABAddress>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidABAddress");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidABAddress>.NativeClassPtr);
		AndroidABAddress.NativeFieldInfoPtr_poBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidABAddress>.NativeClassPtr, "poBox");
		AndroidABAddress.NativeFieldInfoPtr_street = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidABAddress>.NativeClassPtr, "street");
		AndroidABAddress.NativeFieldInfoPtr_city = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidABAddress>.NativeClassPtr, "city");
		AndroidABAddress.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidABAddress>.NativeClassPtr, "state");
		AndroidABAddress.NativeFieldInfoPtr_postalCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidABAddress>.NativeClassPtr, "postalCode");
		AndroidABAddress.NativeFieldInfoPtr_country = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidABAddress>.NativeClassPtr, "country");
		AndroidABAddress.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidABAddress>.NativeClassPtr, "type");
		AndroidABAddress.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidABAddress>.NativeClassPtr, 100665393);
	}

	// Token: 0x06001102 RID: 4354 RVA: 0x00052CC0 File Offset: 0x00050EC0
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidABAddress()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidABAddress>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidABAddress.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001103 RID: 4355 RVA: 0x0000870F File Offset: 0x0000690F
	public AndroidABAddress(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000508 RID: 1288
	// (get) Token: 0x06001104 RID: 4356 RVA: 0x00052CFC File Offset: 0x00050EFC
	// (set) Token: 0x06001105 RID: 4357 RVA: 0x00008718 File Offset: 0x00006918
	public unsafe string poBox
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABAddress.NativeFieldInfoPtr_poBox);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABAddress.NativeFieldInfoPtr_poBox), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000509 RID: 1289
	// (get) Token: 0x06001106 RID: 4358 RVA: 0x00052D24 File Offset: 0x00050F24
	// (set) Token: 0x06001107 RID: 4359 RVA: 0x00008737 File Offset: 0x00006937
	public unsafe string street
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABAddress.NativeFieldInfoPtr_street);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABAddress.NativeFieldInfoPtr_street), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700050A RID: 1290
	// (get) Token: 0x06001108 RID: 4360 RVA: 0x00052D4C File Offset: 0x00050F4C
	// (set) Token: 0x06001109 RID: 4361 RVA: 0x00008756 File Offset: 0x00006956
	public unsafe string city
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABAddress.NativeFieldInfoPtr_city);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABAddress.NativeFieldInfoPtr_city), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700050B RID: 1291
	// (get) Token: 0x0600110A RID: 4362 RVA: 0x00052D74 File Offset: 0x00050F74
	// (set) Token: 0x0600110B RID: 4363 RVA: 0x00008775 File Offset: 0x00006975
	public unsafe string state
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABAddress.NativeFieldInfoPtr_state);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABAddress.NativeFieldInfoPtr_state), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700050C RID: 1292
	// (get) Token: 0x0600110C RID: 4364 RVA: 0x00052D9C File Offset: 0x00050F9C
	// (set) Token: 0x0600110D RID: 4365 RVA: 0x00008794 File Offset: 0x00006994
	public unsafe string postalCode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABAddress.NativeFieldInfoPtr_postalCode);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABAddress.NativeFieldInfoPtr_postalCode), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700050D RID: 1293
	// (get) Token: 0x0600110E RID: 4366 RVA: 0x00052DC4 File Offset: 0x00050FC4
	// (set) Token: 0x0600110F RID: 4367 RVA: 0x000087B3 File Offset: 0x000069B3
	public unsafe string country
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABAddress.NativeFieldInfoPtr_country);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABAddress.NativeFieldInfoPtr_country), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700050E RID: 1294
	// (get) Token: 0x06001110 RID: 4368 RVA: 0x00052DEC File Offset: 0x00050FEC
	// (set) Token: 0x06001111 RID: 4369 RVA: 0x000087D2 File Offset: 0x000069D2
	public unsafe string type
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABAddress.NativeFieldInfoPtr_type);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidABAddress.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000D49 RID: 3401
	private static readonly IntPtr NativeFieldInfoPtr_poBox;

	// Token: 0x04000D4A RID: 3402
	private static readonly IntPtr NativeFieldInfoPtr_street;

	// Token: 0x04000D4B RID: 3403
	private static readonly IntPtr NativeFieldInfoPtr_city;

	// Token: 0x04000D4C RID: 3404
	private static readonly IntPtr NativeFieldInfoPtr_state;

	// Token: 0x04000D4D RID: 3405
	private static readonly IntPtr NativeFieldInfoPtr_postalCode;

	// Token: 0x04000D4E RID: 3406
	private static readonly IntPtr NativeFieldInfoPtr_country;

	// Token: 0x04000D4F RID: 3407
	private static readonly IntPtr NativeFieldInfoPtr_type;

	// Token: 0x04000D50 RID: 3408
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

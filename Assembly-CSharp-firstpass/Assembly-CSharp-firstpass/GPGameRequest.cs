using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000046 RID: 70
public class GPGameRequest : Object
{
	// Token: 0x060005C9 RID: 1481 RVA: 0x0002ADC0 File Offset: 0x00028FC0
	// Note: this type is marked as 'beforefieldinit'.
	static GPGameRequest()
	{
		Il2CppClassPointerStore<GPGameRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GPGameRequest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPGameRequest>.NativeClassPtr);
		GPGameRequest.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPGameRequest>.NativeClassPtr, "id");
		GPGameRequest.NativeFieldInfoPtr_playload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPGameRequest>.NativeClassPtr, "playload");
		GPGameRequest.NativeFieldInfoPtr_expirationTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPGameRequest>.NativeClassPtr, "expirationTimestamp");
		GPGameRequest.NativeFieldInfoPtr_creationTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPGameRequest>.NativeClassPtr, "creationTimestamp");
		GPGameRequest.NativeFieldInfoPtr_sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPGameRequest>.NativeClassPtr, "sender");
		GPGameRequest.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPGameRequest>.NativeClassPtr, "type");
		GPGameRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPGameRequest>.NativeClassPtr, 100664013);
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x0002AE7C File Offset: 0x0002907C
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPGameRequest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPGameRequest>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPGameRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x000044AE File Offset: 0x000026AE
	public GPGameRequest(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170001E1 RID: 481
	// (get) Token: 0x060005CC RID: 1484 RVA: 0x0002AEB8 File Offset: 0x000290B8
	// (set) Token: 0x060005CD RID: 1485 RVA: 0x000044B7 File Offset: 0x000026B7
	public unsafe string id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPGameRequest.NativeFieldInfoPtr_id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPGameRequest.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170001E2 RID: 482
	// (get) Token: 0x060005CE RID: 1486 RVA: 0x0002AEE0 File Offset: 0x000290E0
	// (set) Token: 0x060005CF RID: 1487 RVA: 0x000044D6 File Offset: 0x000026D6
	public unsafe string playload
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPGameRequest.NativeFieldInfoPtr_playload);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPGameRequest.NativeFieldInfoPtr_playload), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170001E3 RID: 483
	// (get) Token: 0x060005D0 RID: 1488 RVA: 0x0002AF08 File Offset: 0x00029108
	// (set) Token: 0x060005D1 RID: 1489 RVA: 0x000044F5 File Offset: 0x000026F5
	public unsafe long expirationTimestamp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPGameRequest.NativeFieldInfoPtr_expirationTimestamp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPGameRequest.NativeFieldInfoPtr_expirationTimestamp)) = value;
		}
	}

	// Token: 0x170001E4 RID: 484
	// (get) Token: 0x060005D2 RID: 1490 RVA: 0x0002AF30 File Offset: 0x00029130
	// (set) Token: 0x060005D3 RID: 1491 RVA: 0x00004510 File Offset: 0x00002710
	public unsafe long creationTimestamp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPGameRequest.NativeFieldInfoPtr_creationTimestamp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPGameRequest.NativeFieldInfoPtr_creationTimestamp)) = value;
		}
	}

	// Token: 0x170001E5 RID: 485
	// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0002AF58 File Offset: 0x00029158
	// (set) Token: 0x060005D5 RID: 1493 RVA: 0x0000452B File Offset: 0x0000272B
	public unsafe string sender
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPGameRequest.NativeFieldInfoPtr_sender);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPGameRequest.NativeFieldInfoPtr_sender), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170001E6 RID: 486
	// (get) Token: 0x060005D6 RID: 1494 RVA: 0x0002AF80 File Offset: 0x00029180
	// (set) Token: 0x060005D7 RID: 1495 RVA: 0x0000454A File Offset: 0x0000274A
	public unsafe GPGameRequestType type
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPGameRequest.NativeFieldInfoPtr_type);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GPGameRequest.NativeFieldInfoPtr_type)) = value;
		}
	}

	// Token: 0x040004D8 RID: 1240
	private static readonly IntPtr NativeFieldInfoPtr_id;

	// Token: 0x040004D9 RID: 1241
	private static readonly IntPtr NativeFieldInfoPtr_playload;

	// Token: 0x040004DA RID: 1242
	private static readonly IntPtr NativeFieldInfoPtr_expirationTimestamp;

	// Token: 0x040004DB RID: 1243
	private static readonly IntPtr NativeFieldInfoPtr_creationTimestamp;

	// Token: 0x040004DC RID: 1244
	private static readonly IntPtr NativeFieldInfoPtr_sender;

	// Token: 0x040004DD RID: 1245
	private static readonly IntPtr NativeFieldInfoPtr_type;

	// Token: 0x040004DE RID: 1246
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

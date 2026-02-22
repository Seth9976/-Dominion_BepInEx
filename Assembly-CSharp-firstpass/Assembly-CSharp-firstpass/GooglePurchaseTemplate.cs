using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200001F RID: 31
public class GooglePurchaseTemplate : Object
{
	// Token: 0x060002AE RID: 686 RVA: 0x000212F4 File Offset: 0x0001F4F4
	// Note: this type is marked as 'beforefieldinit'.
	static GooglePurchaseTemplate()
	{
		Il2CppClassPointerStore<GooglePurchaseTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GooglePurchaseTemplate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePurchaseTemplate>.NativeClassPtr);
		GooglePurchaseTemplate.NativeFieldInfoPtr_OrderId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseTemplate>.NativeClassPtr, "OrderId");
		GooglePurchaseTemplate.NativeFieldInfoPtr_PackageName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseTemplate>.NativeClassPtr, "PackageName");
		GooglePurchaseTemplate.NativeFieldInfoPtr_SKU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseTemplate>.NativeClassPtr, "SKU");
		GooglePurchaseTemplate.NativeFieldInfoPtr_DeveloperPayload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseTemplate>.NativeClassPtr, "DeveloperPayload");
		GooglePurchaseTemplate.NativeFieldInfoPtr_Signature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseTemplate>.NativeClassPtr, "Signature");
		GooglePurchaseTemplate.NativeFieldInfoPtr_Token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseTemplate>.NativeClassPtr, "Token");
		GooglePurchaseTemplate.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseTemplate>.NativeClassPtr, "Time");
		GooglePurchaseTemplate.NativeFieldInfoPtr_OriginalJson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseTemplate>.NativeClassPtr, "OriginalJson");
		GooglePurchaseTemplate.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseTemplate>.NativeClassPtr, "State");
		GooglePurchaseTemplate.NativeMethodInfoPtr_SetState_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseTemplate>.NativeClassPtr, 100663706);
		GooglePurchaseTemplate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseTemplate>.NativeClassPtr, 100663707);
	}

	// Token: 0x060002AF RID: 687 RVA: 0x00021400 File Offset: 0x0001F600
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 162462, RefRangeEnd = 162467, XrefRangeStart = 162458, XrefRangeEnd = 162462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetState(string code)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseTemplate.NativeMethodInfoPtr_SetState_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x00021444 File Offset: 0x0001F644
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePurchaseTemplate()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePurchaseTemplate>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseTemplate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x00002C9C File Offset: 0x00000E9C
	public GooglePurchaseTemplate(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x060002B2 RID: 690 RVA: 0x00021480 File Offset: 0x0001F680
	// (set) Token: 0x060002B3 RID: 691 RVA: 0x00002CA5 File Offset: 0x00000EA5
	public unsafe string OrderId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseTemplate.NativeFieldInfoPtr_OrderId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseTemplate.NativeFieldInfoPtr_OrderId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x060002B4 RID: 692 RVA: 0x000214A8 File Offset: 0x0001F6A8
	// (set) Token: 0x060002B5 RID: 693 RVA: 0x00002CC4 File Offset: 0x00000EC4
	public unsafe string PackageName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseTemplate.NativeFieldInfoPtr_PackageName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseTemplate.NativeFieldInfoPtr_PackageName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x060002B6 RID: 694 RVA: 0x000214D0 File Offset: 0x0001F6D0
	// (set) Token: 0x060002B7 RID: 695 RVA: 0x00002CE3 File Offset: 0x00000EE3
	public unsafe string SKU
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseTemplate.NativeFieldInfoPtr_SKU);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseTemplate.NativeFieldInfoPtr_SKU), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x060002B8 RID: 696 RVA: 0x000214F8 File Offset: 0x0001F6F8
	// (set) Token: 0x060002B9 RID: 697 RVA: 0x00002D02 File Offset: 0x00000F02
	public unsafe string DeveloperPayload
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseTemplate.NativeFieldInfoPtr_DeveloperPayload);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseTemplate.NativeFieldInfoPtr_DeveloperPayload), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x060002BA RID: 698 RVA: 0x00021520 File Offset: 0x0001F720
	// (set) Token: 0x060002BB RID: 699 RVA: 0x00002D21 File Offset: 0x00000F21
	public unsafe string Signature
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseTemplate.NativeFieldInfoPtr_Signature);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseTemplate.NativeFieldInfoPtr_Signature), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x060002BC RID: 700 RVA: 0x00021548 File Offset: 0x0001F748
	// (set) Token: 0x060002BD RID: 701 RVA: 0x00002D40 File Offset: 0x00000F40
	public unsafe string Token
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseTemplate.NativeFieldInfoPtr_Token);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseTemplate.NativeFieldInfoPtr_Token), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x060002BE RID: 702 RVA: 0x00021570 File Offset: 0x0001F770
	// (set) Token: 0x060002BF RID: 703 RVA: 0x00002D5F File Offset: 0x00000F5F
	public unsafe long Time
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseTemplate.NativeFieldInfoPtr_Time);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseTemplate.NativeFieldInfoPtr_Time)) = value;
		}
	}

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x060002C0 RID: 704 RVA: 0x00021598 File Offset: 0x0001F798
	// (set) Token: 0x060002C1 RID: 705 RVA: 0x00002D7A File Offset: 0x00000F7A
	public unsafe string OriginalJson
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseTemplate.NativeFieldInfoPtr_OriginalJson);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseTemplate.NativeFieldInfoPtr_OriginalJson), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x060002C2 RID: 706 RVA: 0x000215C0 File Offset: 0x0001F7C0
	// (set) Token: 0x060002C3 RID: 707 RVA: 0x00002D99 File Offset: 0x00000F99
	public unsafe GooglePurchaseState State
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseTemplate.NativeFieldInfoPtr_State);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseTemplate.NativeFieldInfoPtr_State)) = value;
		}
	}

	// Token: 0x04000246 RID: 582
	private static readonly IntPtr NativeFieldInfoPtr_OrderId;

	// Token: 0x04000247 RID: 583
	private static readonly IntPtr NativeFieldInfoPtr_PackageName;

	// Token: 0x04000248 RID: 584
	private static readonly IntPtr NativeFieldInfoPtr_SKU;

	// Token: 0x04000249 RID: 585
	private static readonly IntPtr NativeFieldInfoPtr_DeveloperPayload;

	// Token: 0x0400024A RID: 586
	private static readonly IntPtr NativeFieldInfoPtr_Signature;

	// Token: 0x0400024B RID: 587
	private static readonly IntPtr NativeFieldInfoPtr_Token;

	// Token: 0x0400024C RID: 588
	private static readonly IntPtr NativeFieldInfoPtr_Time;

	// Token: 0x0400024D RID: 589
	private static readonly IntPtr NativeFieldInfoPtr_OriginalJson;

	// Token: 0x0400024E RID: 590
	private static readonly IntPtr NativeFieldInfoPtr_State;

	// Token: 0x0400024F RID: 591
	private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Void_String_0;

	// Token: 0x04000250 RID: 592
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

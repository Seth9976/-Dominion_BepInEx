using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x0200001C RID: 28
public class BillingResult : Object
{
	// Token: 0x0600025F RID: 607 RVA: 0x0002012C File Offset: 0x0001E32C
	// Note: this type is marked as 'beforefieldinit'.
	static BillingResult()
	{
		Il2CppClassPointerStore<BillingResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "BillingResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BillingResult>.NativeClassPtr);
		BillingResult.NativeFieldInfoPtr__response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResult>.NativeClassPtr, "_response");
		BillingResult.NativeFieldInfoPtr__message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResult>.NativeClassPtr, "_message");
		BillingResult.NativeFieldInfoPtr__purchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BillingResult>.NativeClassPtr, "_purchase");
		BillingResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_GooglePurchaseTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingResult>.NativeClassPtr, 100663665);
		BillingResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingResult>.NativeClassPtr, 100663666);
		BillingResult.NativeMethodInfoPtr_get_purchase_Public_get_GooglePurchaseTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingResult>.NativeClassPtr, 100663667);
		BillingResult.NativeMethodInfoPtr_get_Purchase_Public_get_GooglePurchaseTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingResult>.NativeClassPtr, 100663668);
		BillingResult.NativeMethodInfoPtr_get_response_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingResult>.NativeClassPtr, 100663669);
		BillingResult.NativeMethodInfoPtr_get_Response_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingResult>.NativeClassPtr, 100663670);
		BillingResult.NativeMethodInfoPtr_get_message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingResult>.NativeClassPtr, 100663671);
		BillingResult.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingResult>.NativeClassPtr, 100663672);
		BillingResult.NativeMethodInfoPtr_get_isSuccess_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingResult>.NativeClassPtr, 100663673);
		BillingResult.NativeMethodInfoPtr_get_IsSuccess_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingResult>.NativeClassPtr, 100663674);
		BillingResult.NativeMethodInfoPtr_get_isFailure_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingResult>.NativeClassPtr, 100663675);
		BillingResult.NativeMethodInfoPtr_get_IsFailure_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BillingResult>.NativeClassPtr, 100663676);
	}

	// Token: 0x06000260 RID: 608 RVA: 0x00020288 File Offset: 0x0001E488
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 37124, RefRangeEnd = 37133, XrefRangeStart = 37124, XrefRangeEnd = 37133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BillingResult(int code, string msg, GooglePurchaseTemplate p)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BillingResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref code;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_GooglePurchaseTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000261 RID: 609 RVA: 0x000202F4 File Offset: 0x0001E4F4
	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 50515, RefRangeEnd = 50526, XrefRangeStart = 50515, XrefRangeEnd = 50526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BillingResult(int code, string msg)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BillingResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref code;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingResult.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x06000262 RID: 610 RVA: 0x00020350 File Offset: 0x0001E550
	public unsafe GooglePurchaseTemplate purchase
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingResult.NativeMethodInfoPtr_get_purchase_Public_get_GooglePurchaseTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GooglePurchaseTemplate>(intPtr3) : null;
		}
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x06000263 RID: 611 RVA: 0x00020390 File Offset: 0x0001E590
	public unsafe GooglePurchaseTemplate Purchase
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingResult.NativeMethodInfoPtr_get_Purchase_Public_get_GooglePurchaseTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GooglePurchaseTemplate>(intPtr3) : null;
		}
	}

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x06000264 RID: 612 RVA: 0x000203D0 File Offset: 0x0001E5D0
	public unsafe int response
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingResult.NativeMethodInfoPtr_get_response_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x06000265 RID: 613 RVA: 0x0002040C File Offset: 0x0001E60C
	public unsafe int Response
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingResult.NativeMethodInfoPtr_get_Response_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x06000266 RID: 614 RVA: 0x00020448 File Offset: 0x0001E648
	public unsafe string message
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingResult.NativeMethodInfoPtr_get_message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x06000267 RID: 615 RVA: 0x00020480 File Offset: 0x0001E680
	public unsafe string Message
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingResult.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x06000268 RID: 616 RVA: 0x000204B8 File Offset: 0x0001E6B8
	public unsafe bool isSuccess
	{
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 162234, RefRangeEnd = 162266, XrefRangeStart = 162234, XrefRangeEnd = 162234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingResult.NativeMethodInfoPtr_get_isSuccess_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000269 RID: 617 RVA: 0x000204F4 File Offset: 0x0001E6F4
	public unsafe bool IsSuccess
	{
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 162234, RefRangeEnd = 162266, XrefRangeStart = 162234, XrefRangeEnd = 162266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingResult.NativeMethodInfoPtr_get_IsSuccess_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x0600026A RID: 618 RVA: 0x00020530 File Offset: 0x0001E730
	public unsafe bool isFailure
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingResult.NativeMethodInfoPtr_get_isFailure_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x0600026B RID: 619 RVA: 0x0002056C File Offset: 0x0001E76C
	public unsafe bool IsFailure
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BillingResult.NativeMethodInfoPtr_get_IsFailure_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600026C RID: 620 RVA: 0x00002AB2 File Offset: 0x00000CB2
	public BillingResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x0600026D RID: 621 RVA: 0x000205A8 File Offset: 0x0001E7A8
	// (set) Token: 0x0600026E RID: 622 RVA: 0x00002ABB File Offset: 0x00000CBB
	public unsafe int _response
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillingResult.NativeFieldInfoPtr__response);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillingResult.NativeFieldInfoPtr__response)) = value;
		}
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x0600026F RID: 623 RVA: 0x000205D0 File Offset: 0x0001E7D0
	// (set) Token: 0x06000270 RID: 624 RVA: 0x00002AD6 File Offset: 0x00000CD6
	public unsafe string _message
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillingResult.NativeFieldInfoPtr__message);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillingResult.NativeFieldInfoPtr__message), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x06000271 RID: 625 RVA: 0x000205F8 File Offset: 0x0001E7F8
	// (set) Token: 0x06000272 RID: 626 RVA: 0x00002AF5 File Offset: 0x00000CF5
	public unsafe GooglePurchaseTemplate _purchase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillingResult.NativeFieldInfoPtr__purchase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GooglePurchaseTemplate>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BillingResult.NativeFieldInfoPtr__purchase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400020D RID: 525
	private static readonly IntPtr NativeFieldInfoPtr__response;

	// Token: 0x0400020E RID: 526
	private static readonly IntPtr NativeFieldInfoPtr__message;

	// Token: 0x0400020F RID: 527
	private static readonly IntPtr NativeFieldInfoPtr__purchase;

	// Token: 0x04000210 RID: 528
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_GooglePurchaseTemplate_0;

	// Token: 0x04000211 RID: 529
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;

	// Token: 0x04000212 RID: 530
	private static readonly IntPtr NativeMethodInfoPtr_get_purchase_Public_get_GooglePurchaseTemplate_0;

	// Token: 0x04000213 RID: 531
	private static readonly IntPtr NativeMethodInfoPtr_get_Purchase_Public_get_GooglePurchaseTemplate_0;

	// Token: 0x04000214 RID: 532
	private static readonly IntPtr NativeMethodInfoPtr_get_response_Public_get_Int32_0;

	// Token: 0x04000215 RID: 533
	private static readonly IntPtr NativeMethodInfoPtr_get_Response_Public_get_Int32_0;

	// Token: 0x04000216 RID: 534
	private static readonly IntPtr NativeMethodInfoPtr_get_message_Public_get_String_0;

	// Token: 0x04000217 RID: 535
	private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;

	// Token: 0x04000218 RID: 536
	private static readonly IntPtr NativeMethodInfoPtr_get_isSuccess_Public_get_Boolean_0;

	// Token: 0x04000219 RID: 537
	private static readonly IntPtr NativeMethodInfoPtr_get_IsSuccess_Public_get_Boolean_0;

	// Token: 0x0400021A RID: 538
	private static readonly IntPtr NativeMethodInfoPtr_get_isFailure_Public_get_Boolean_0;

	// Token: 0x0400021B RID: 539
	private static readonly IntPtr NativeMethodInfoPtr_get_IsFailure_Public_get_Boolean_0;
}

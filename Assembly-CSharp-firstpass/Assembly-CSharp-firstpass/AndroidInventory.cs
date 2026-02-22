using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x0200001B RID: 27
public class AndroidInventory : Object
{
	// Token: 0x06000253 RID: 595 RVA: 0x0001FDE4 File Offset: 0x0001DFE4
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidInventory()
	{
		Il2CppClassPointerStore<AndroidInventory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidInventory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidInventory>.NativeClassPtr);
		AndroidInventory.NativeFieldInfoPtr__purchases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidInventory>.NativeClassPtr, "_purchases");
		AndroidInventory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInventory>.NativeClassPtr, 100663657);
		AndroidInventory.NativeMethodInfoPtr_addPurchase_Public_Void_GooglePurchaseTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInventory>.NativeClassPtr, 100663658);
		AndroidInventory.NativeMethodInfoPtr_removePurchase_Public_Void_GooglePurchaseTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInventory>.NativeClassPtr, 100663659);
		AndroidInventory.NativeMethodInfoPtr_IsProductPurchased_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInventory>.NativeClassPtr, 100663660);
		AndroidInventory.NativeMethodInfoPtr_GetProductDetails_Public_GoogleProductTemplate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInventory>.NativeClassPtr, 100663661);
		AndroidInventory.NativeMethodInfoPtr_GetPurchaseDetails_Public_GooglePurchaseTemplate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInventory>.NativeClassPtr, 100663662);
		AndroidInventory.NativeMethodInfoPtr_get_Purchases_Public_get_List_1_GooglePurchaseTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInventory>.NativeClassPtr, 100663663);
		AndroidInventory.NativeMethodInfoPtr_get_Products_Public_get_List_1_GoogleProductTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidInventory>.NativeClassPtr, 100663664);
	}

	// Token: 0x06000254 RID: 596 RVA: 0x0001FEC8 File Offset: 0x0001E0C8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 162150, RefRangeEnd = 162152, XrefRangeStart = 162143, XrefRangeEnd = 162150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidInventory()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidInventory>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInventory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000255 RID: 597 RVA: 0x0001FF04 File Offset: 0x0001E104
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 162162, RefRangeEnd = 162165, XrefRangeStart = 162152, XrefRangeEnd = 162162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addPurchase(GooglePurchaseTemplate purchase)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInventory.NativeMethodInfoPtr_addPurchase_Public_Void_GooglePurchaseTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000256 RID: 598 RVA: 0x0001FF48 File Offset: 0x0001E148
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 162171, RefRangeEnd = 162173, XrefRangeStart = 162165, XrefRangeEnd = 162171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removePurchase(GooglePurchaseTemplate purchase)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInventory.NativeMethodInfoPtr_removePurchase_Public_Void_GooglePurchaseTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000257 RID: 599 RVA: 0x0001FF8C File Offset: 0x0001E18C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 162176, RefRangeEnd = 162178, XrefRangeStart = 162173, XrefRangeEnd = 162176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsProductPurchased(string SKU)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInventory.NativeMethodInfoPtr_IsProductPurchased_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000258 RID: 600 RVA: 0x0001FFDC File Offset: 0x0001E1DC
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 162200, RefRangeEnd = 162205, XrefRangeStart = 162178, XrefRangeEnd = 162200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GoogleProductTemplate GetProductDetails(string SKU)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInventory.NativeMethodInfoPtr_GetProductDetails_Public_GoogleProductTemplate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleProductTemplate>(intPtr3) : null;
		}
	}

	// Token: 0x06000259 RID: 601 RVA: 0x0002002C File Offset: 0x0001E22C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162205, XrefRangeEnd = 162209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePurchaseTemplate GetPurchaseDetails(string SKU)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInventory.NativeMethodInfoPtr_GetPurchaseDetails_Public_GooglePurchaseTemplate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GooglePurchaseTemplate>(intPtr3) : null;
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x0600025A RID: 602 RVA: 0x0002007C File Offset: 0x0001E27C
	public unsafe List<GooglePurchaseTemplate> Purchases
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162218, RefRangeEnd = 162220, XrefRangeStart = 162209, XrefRangeEnd = 162218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInventory.NativeMethodInfoPtr_get_Purchases_Public_get_List_1_GooglePurchaseTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GooglePurchaseTemplate>>(intPtr3) : null;
		}
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x0600025B RID: 603 RVA: 0x000200BC File Offset: 0x0001E2BC
	public unsafe List<GoogleProductTemplate> Products
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 162224, RefRangeEnd = 162234, XrefRangeStart = 162220, XrefRangeEnd = 162224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidInventory.NativeMethodInfoPtr_get_Products_Public_get_List_1_GoogleProductTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GoogleProductTemplate>>(intPtr3) : null;
		}
	}

	// Token: 0x0600025C RID: 604 RVA: 0x00002A8A File Offset: 0x00000C8A
	public AndroidInventory(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x0600025D RID: 605 RVA: 0x000200FC File Offset: 0x0001E2FC
	// (set) Token: 0x0600025E RID: 606 RVA: 0x00002A93 File Offset: 0x00000C93
	public unsafe Dictionary<string, GooglePurchaseTemplate> _purchases
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidInventory.NativeFieldInfoPtr__purchases);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GooglePurchaseTemplate>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidInventory.NativeFieldInfoPtr__purchases), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000204 RID: 516
	private static readonly IntPtr NativeFieldInfoPtr__purchases;

	// Token: 0x04000205 RID: 517
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000206 RID: 518
	private static readonly IntPtr NativeMethodInfoPtr_addPurchase_Public_Void_GooglePurchaseTemplate_0;

	// Token: 0x04000207 RID: 519
	private static readonly IntPtr NativeMethodInfoPtr_removePurchase_Public_Void_GooglePurchaseTemplate_0;

	// Token: 0x04000208 RID: 520
	private static readonly IntPtr NativeMethodInfoPtr_IsProductPurchased_Public_Boolean_String_0;

	// Token: 0x04000209 RID: 521
	private static readonly IntPtr NativeMethodInfoPtr_GetProductDetails_Public_GoogleProductTemplate_String_0;

	// Token: 0x0400020A RID: 522
	private static readonly IntPtr NativeMethodInfoPtr_GetPurchaseDetails_Public_GooglePurchaseTemplate_String_0;

	// Token: 0x0400020B RID: 523
	private static readonly IntPtr NativeMethodInfoPtr_get_Purchases_Public_get_List_1_GooglePurchaseTemplate_0;

	// Token: 0x0400020C RID: 524
	private static readonly IntPtr NativeMethodInfoPtr_get_Products_Public_get_List_1_GoogleProductTemplate_0;
}

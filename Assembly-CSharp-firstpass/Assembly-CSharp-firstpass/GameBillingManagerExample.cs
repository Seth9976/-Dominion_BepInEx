using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x0200010F RID: 271
public class GameBillingManagerExample : MonoBehaviour
{
	// Token: 0x060012A2 RID: 4770 RVA: 0x000579A0 File Offset: 0x00055BA0
	// Note: this type is marked as 'beforefieldinit'.
	static GameBillingManagerExample()
	{
		Il2CppClassPointerStore<GameBillingManagerExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GameBillingManagerExample");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameBillingManagerExample>.NativeClassPtr);
		GameBillingManagerExample.NativeFieldInfoPtr__isInited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBillingManagerExample>.NativeClassPtr, "_isInited");
		GameBillingManagerExample.NativeFieldInfoPtr_COINS_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBillingManagerExample>.NativeClassPtr, "COINS_ITEM");
		GameBillingManagerExample.NativeFieldInfoPtr_COINS_BOOST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBillingManagerExample>.NativeClassPtr, "COINS_BOOST");
		GameBillingManagerExample.NativeFieldInfoPtr_ListnersAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameBillingManagerExample>.NativeClassPtr, "ListnersAdded");
		GameBillingManagerExample.NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBillingManagerExample>.NativeClassPtr, 100665543);
		GameBillingManagerExample.NativeMethodInfoPtr_purchase_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBillingManagerExample>.NativeClassPtr, 100665544);
		GameBillingManagerExample.NativeMethodInfoPtr_consume_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBillingManagerExample>.NativeClassPtr, 100665545);
		GameBillingManagerExample.NativeMethodInfoPtr_get_isInited_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBillingManagerExample>.NativeClassPtr, 100665546);
		GameBillingManagerExample.NativeMethodInfoPtr_OnProcessingPurchasedProduct_Private_Static_Void_GooglePurchaseTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBillingManagerExample>.NativeClassPtr, 100665547);
		GameBillingManagerExample.NativeMethodInfoPtr_OnProcessingConsumeProduct_Private_Static_Void_GooglePurchaseTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBillingManagerExample>.NativeClassPtr, 100665548);
		GameBillingManagerExample.NativeMethodInfoPtr_OnProductPurchased_Private_Static_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBillingManagerExample>.NativeClassPtr, 100665549);
		GameBillingManagerExample.NativeMethodInfoPtr_OnProductConsumed_Private_Static_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBillingManagerExample>.NativeClassPtr, 100665550);
		GameBillingManagerExample.NativeMethodInfoPtr_OnBillingConnected_Private_Static_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBillingManagerExample>.NativeClassPtr, 100665551);
		GameBillingManagerExample.NativeMethodInfoPtr_OnRetrieveProductsFinised_Private_Static_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBillingManagerExample>.NativeClassPtr, 100665552);
		GameBillingManagerExample.NativeMethodInfoPtr_UpdateStoreData_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBillingManagerExample>.NativeClassPtr, 100665553);
		GameBillingManagerExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameBillingManagerExample>.NativeClassPtr, 100665554);
	}

	// Token: 0x060012A3 RID: 4771 RVA: 0x00057B10 File Offset: 0x00055D10
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 183120, RefRangeEnd = 183121, XrefRangeStart = 183073, XrefRangeEnd = 183120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameBillingManagerExample.NativeMethodInfoPtr_init_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012A4 RID: 4772 RVA: 0x00057B38 File Offset: 0x00055D38
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 183129, RefRangeEnd = 183131, XrefRangeStart = 183121, XrefRangeEnd = 183129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void purchase(string SKU)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameBillingManagerExample.NativeMethodInfoPtr_purchase_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012A5 RID: 4773 RVA: 0x00057B70 File Offset: 0x00055D70
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 183139, RefRangeEnd = 183142, XrefRangeStart = 183131, XrefRangeEnd = 183139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void consume(string SKU)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameBillingManagerExample.NativeMethodInfoPtr_consume_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x17000583 RID: 1411
	// (get) Token: 0x060012A6 RID: 4774 RVA: 0x00057BA8 File Offset: 0x00055DA8
	public unsafe static bool isInited
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183142, XrefRangeEnd = 183146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameBillingManagerExample.NativeMethodInfoPtr_get_isInited_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060012A7 RID: 4775 RVA: 0x00057BD8 File Offset: 0x00055DD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183146, XrefRangeEnd = 183155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnProcessingPurchasedProduct(GooglePurchaseTemplate purchase)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameBillingManagerExample.NativeMethodInfoPtr_OnProcessingPurchasedProduct_Private_Static_Void_GooglePurchaseTemplate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012A8 RID: 4776 RVA: 0x00057C10 File Offset: 0x00055E10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183155, XrefRangeEnd = 183171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnProcessingConsumeProduct(GooglePurchaseTemplate purchase)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameBillingManagerExample.NativeMethodInfoPtr_OnProcessingConsumeProduct_Private_Static_Void_GooglePurchaseTemplate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012A9 RID: 4777 RVA: 0x00057C48 File Offset: 0x00055E48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183171, XrefRangeEnd = 183207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnProductPurchased(BillingResult result)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameBillingManagerExample.NativeMethodInfoPtr_OnProductPurchased_Private_Static_Void_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012AA RID: 4778 RVA: 0x00057C80 File Offset: 0x00055E80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183207, XrefRangeEnd = 183244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnProductConsumed(BillingResult result)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameBillingManagerExample.NativeMethodInfoPtr_OnProductConsumed_Private_Static_Void_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x00057CB8 File Offset: 0x00055EB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183244, XrefRangeEnd = 183286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnBillingConnected(BillingResult result)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameBillingManagerExample.NativeMethodInfoPtr_OnBillingConnected_Private_Static_Void_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x00057CF0 File Offset: 0x00055EF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183286, XrefRangeEnd = 183307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnRetrieveProductsFinised(BillingResult result)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameBillingManagerExample.NativeMethodInfoPtr_OnRetrieveProductsFinised_Private_Static_Void_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012AD RID: 4781 RVA: 0x00057D28 File Offset: 0x00055F28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183307, XrefRangeEnd = 183360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateStoreData()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameBillingManagerExample.NativeMethodInfoPtr_UpdateStoreData_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012AE RID: 4782 RVA: 0x00057D50 File Offset: 0x00055F50
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameBillingManagerExample()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameBillingManagerExample>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameBillingManagerExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012AF RID: 4783 RVA: 0x00009445 File Offset: 0x00007645
	public GameBillingManagerExample(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700057F RID: 1407
	// (get) Token: 0x060012B0 RID: 4784 RVA: 0x00057D8C File Offset: 0x00055F8C
	// (set) Token: 0x060012B1 RID: 4785 RVA: 0x0000944E File Offset: 0x0000764E
	public unsafe static bool _isInited
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(GameBillingManagerExample.NativeFieldInfoPtr__isInited, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GameBillingManagerExample.NativeFieldInfoPtr__isInited, (void*)(&value));
		}
	}

	// Token: 0x17000580 RID: 1408
	// (get) Token: 0x060012B2 RID: 4786 RVA: 0x00057DA8 File Offset: 0x00055FA8
	// (set) Token: 0x060012B3 RID: 4787 RVA: 0x0000945C File Offset: 0x0000765C
	public unsafe static string COINS_ITEM
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GameBillingManagerExample.NativeFieldInfoPtr_COINS_ITEM, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GameBillingManagerExample.NativeFieldInfoPtr_COINS_ITEM, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000581 RID: 1409
	// (get) Token: 0x060012B4 RID: 4788 RVA: 0x00057DC8 File Offset: 0x00055FC8
	// (set) Token: 0x060012B5 RID: 4789 RVA: 0x0000946E File Offset: 0x0000766E
	public unsafe static string COINS_BOOST
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GameBillingManagerExample.NativeFieldInfoPtr_COINS_BOOST, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GameBillingManagerExample.NativeFieldInfoPtr_COINS_BOOST, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000582 RID: 1410
	// (get) Token: 0x060012B6 RID: 4790 RVA: 0x00057DE8 File Offset: 0x00055FE8
	// (set) Token: 0x060012B7 RID: 4791 RVA: 0x00009480 File Offset: 0x00007680
	public unsafe static bool ListnersAdded
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(GameBillingManagerExample.NativeFieldInfoPtr_ListnersAdded, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GameBillingManagerExample.NativeFieldInfoPtr_ListnersAdded, (void*)(&value));
		}
	}

	// Token: 0x04000E4F RID: 3663
	private static readonly IntPtr NativeFieldInfoPtr__isInited;

	// Token: 0x04000E50 RID: 3664
	private static readonly IntPtr NativeFieldInfoPtr_COINS_ITEM;

	// Token: 0x04000E51 RID: 3665
	private static readonly IntPtr NativeFieldInfoPtr_COINS_BOOST;

	// Token: 0x04000E52 RID: 3666
	private static readonly IntPtr NativeFieldInfoPtr_ListnersAdded;

	// Token: 0x04000E53 RID: 3667
	private static readonly IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;

	// Token: 0x04000E54 RID: 3668
	private static readonly IntPtr NativeMethodInfoPtr_purchase_Public_Static_Void_String_0;

	// Token: 0x04000E55 RID: 3669
	private static readonly IntPtr NativeMethodInfoPtr_consume_Public_Static_Void_String_0;

	// Token: 0x04000E56 RID: 3670
	private static readonly IntPtr NativeMethodInfoPtr_get_isInited_Public_Static_get_Boolean_0;

	// Token: 0x04000E57 RID: 3671
	private static readonly IntPtr NativeMethodInfoPtr_OnProcessingPurchasedProduct_Private_Static_Void_GooglePurchaseTemplate_0;

	// Token: 0x04000E58 RID: 3672
	private static readonly IntPtr NativeMethodInfoPtr_OnProcessingConsumeProduct_Private_Static_Void_GooglePurchaseTemplate_0;

	// Token: 0x04000E59 RID: 3673
	private static readonly IntPtr NativeMethodInfoPtr_OnProductPurchased_Private_Static_Void_BillingResult_0;

	// Token: 0x04000E5A RID: 3674
	private static readonly IntPtr NativeMethodInfoPtr_OnProductConsumed_Private_Static_Void_BillingResult_0;

	// Token: 0x04000E5B RID: 3675
	private static readonly IntPtr NativeMethodInfoPtr_OnBillingConnected_Private_Static_Void_BillingResult_0;

	// Token: 0x04000E5C RID: 3676
	private static readonly IntPtr NativeMethodInfoPtr_OnRetrieveProductsFinised_Private_Static_Void_BillingResult_0;

	// Token: 0x04000E5D RID: 3677
	private static readonly IntPtr NativeMethodInfoPtr_UpdateStoreData_Private_Static_Void_0;

	// Token: 0x04000E5E RID: 3678
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

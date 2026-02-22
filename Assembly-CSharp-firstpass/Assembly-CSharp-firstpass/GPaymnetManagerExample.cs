using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000111 RID: 273
public class GPaymnetManagerExample : MonoBehaviour
{
	// Token: 0x060012BF RID: 4799 RVA: 0x00057F90 File Offset: 0x00056190
	// Note: this type is marked as 'beforefieldinit'.
	static GPaymnetManagerExample()
	{
		Il2CppClassPointerStore<GPaymnetManagerExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GPaymnetManagerExample");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPaymnetManagerExample>.NativeClassPtr);
		GPaymnetManagerExample.NativeFieldInfoPtr__isInited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPaymnetManagerExample>.NativeClassPtr, "_isInited");
		GPaymnetManagerExample.NativeFieldInfoPtr_ANDROID_TEST_PURCHASED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPaymnetManagerExample>.NativeClassPtr, "ANDROID_TEST_PURCHASED");
		GPaymnetManagerExample.NativeFieldInfoPtr_ANDROID_TEST_CANCELED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPaymnetManagerExample>.NativeClassPtr, "ANDROID_TEST_CANCELED");
		GPaymnetManagerExample.NativeFieldInfoPtr_ANDROID_TEST_REFUNDED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPaymnetManagerExample>.NativeClassPtr, "ANDROID_TEST_REFUNDED");
		GPaymnetManagerExample.NativeFieldInfoPtr_ANDROID_TEST_ITEM_UNAVAILABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPaymnetManagerExample>.NativeClassPtr, "ANDROID_TEST_ITEM_UNAVAILABLE");
		GPaymnetManagerExample.NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPaymnetManagerExample>.NativeClassPtr, 100665561);
		GPaymnetManagerExample.NativeMethodInfoPtr_Purchase_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPaymnetManagerExample>.NativeClassPtr, 100665562);
		GPaymnetManagerExample.NativeMethodInfoPtr_consume_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPaymnetManagerExample>.NativeClassPtr, 100665563);
		GPaymnetManagerExample.NativeMethodInfoPtr_get_isInited_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPaymnetManagerExample>.NativeClassPtr, 100665564);
		GPaymnetManagerExample.NativeMethodInfoPtr_OnProcessingPurchasedProduct_Private_Static_Void_GooglePurchaseTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPaymnetManagerExample>.NativeClassPtr, 100665565);
		GPaymnetManagerExample.NativeMethodInfoPtr_OnProcessingConsumeProduct_Private_Static_Void_GooglePurchaseTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPaymnetManagerExample>.NativeClassPtr, 100665566);
		GPaymnetManagerExample.NativeMethodInfoPtr_OnProductPurchased_Private_Static_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPaymnetManagerExample>.NativeClassPtr, 100665567);
		GPaymnetManagerExample.NativeMethodInfoPtr_OnProductConsumed_Private_Static_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPaymnetManagerExample>.NativeClassPtr, 100665568);
		GPaymnetManagerExample.NativeMethodInfoPtr_OnBillingConnected_Private_Static_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPaymnetManagerExample>.NativeClassPtr, 100665569);
		GPaymnetManagerExample.NativeMethodInfoPtr_OnRetrieveProductsFinised_Private_Static_Void_BillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPaymnetManagerExample>.NativeClassPtr, 100665570);
		GPaymnetManagerExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPaymnetManagerExample>.NativeClassPtr, 100665571);
	}

	// Token: 0x060012C0 RID: 4800 RVA: 0x00058100 File Offset: 0x00056300
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 183448, RefRangeEnd = 183449, XrefRangeStart = 183384, XrefRangeEnd = 183448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPaymnetManagerExample.NativeMethodInfoPtr_init_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012C1 RID: 4801 RVA: 0x00058128 File Offset: 0x00056328
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183449, XrefRangeEnd = 183457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Purchase(string SKU)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPaymnetManagerExample.NativeMethodInfoPtr_Purchase_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012C2 RID: 4802 RVA: 0x00058160 File Offset: 0x00056360
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 183465, RefRangeEnd = 183466, XrefRangeStart = 183457, XrefRangeEnd = 183465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void consume(string SKU)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(SKU);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPaymnetManagerExample.NativeMethodInfoPtr_consume_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x1700058B RID: 1419
	// (get) Token: 0x060012C3 RID: 4803 RVA: 0x00058198 File Offset: 0x00056398
	public unsafe static bool isInited
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183466, XrefRangeEnd = 183470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPaymnetManagerExample.NativeMethodInfoPtr_get_isInited_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060012C4 RID: 4804 RVA: 0x000581C8 File Offset: 0x000563C8
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnProcessingPurchasedProduct(GooglePurchaseTemplate Purchase)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(Purchase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPaymnetManagerExample.NativeMethodInfoPtr_OnProcessingPurchasedProduct_Private_Static_Void_GooglePurchaseTemplate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012C5 RID: 4805 RVA: 0x00058200 File Offset: 0x00056400
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnProcessingConsumeProduct(GooglePurchaseTemplate Purchase)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(Purchase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPaymnetManagerExample.NativeMethodInfoPtr_OnProcessingConsumeProduct_Private_Static_Void_GooglePurchaseTemplate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012C6 RID: 4806 RVA: 0x00058238 File Offset: 0x00056438
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183470, XrefRangeEnd = 183497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnProductPurchased(BillingResult result)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPaymnetManagerExample.NativeMethodInfoPtr_OnProductPurchased_Private_Static_Void_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012C7 RID: 4807 RVA: 0x00058270 File Offset: 0x00056470
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183497, XrefRangeEnd = 183524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnProductConsumed(BillingResult result)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPaymnetManagerExample.NativeMethodInfoPtr_OnProductConsumed_Private_Static_Void_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012C8 RID: 4808 RVA: 0x000582A8 File Offset: 0x000564A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183524, XrefRangeEnd = 183566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnBillingConnected(BillingResult result)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPaymnetManagerExample.NativeMethodInfoPtr_OnBillingConnected_Private_Static_Void_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012C9 RID: 4809 RVA: 0x000582E0 File Offset: 0x000564E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183566, XrefRangeEnd = 183638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnRetrieveProductsFinised(BillingResult result)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPaymnetManagerExample.NativeMethodInfoPtr_OnRetrieveProductsFinised_Private_Static_Void_BillingResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012CA RID: 4810 RVA: 0x00058318 File Offset: 0x00056518
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPaymnetManagerExample()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPaymnetManagerExample>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GPaymnetManagerExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012CB RID: 4811 RVA: 0x00009497 File Offset: 0x00007697
	public GPaymnetManagerExample(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000586 RID: 1414
	// (get) Token: 0x060012CC RID: 4812 RVA: 0x00058354 File Offset: 0x00056554
	// (set) Token: 0x060012CD RID: 4813 RVA: 0x000094A0 File Offset: 0x000076A0
	public unsafe static bool _isInited
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(GPaymnetManagerExample.NativeFieldInfoPtr__isInited, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GPaymnetManagerExample.NativeFieldInfoPtr__isInited, (void*)(&value));
		}
	}

	// Token: 0x17000587 RID: 1415
	// (get) Token: 0x060012CE RID: 4814 RVA: 0x00058370 File Offset: 0x00056570
	// (set) Token: 0x060012CF RID: 4815 RVA: 0x000094AE File Offset: 0x000076AE
	public unsafe static string ANDROID_TEST_PURCHASED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GPaymnetManagerExample.NativeFieldInfoPtr_ANDROID_TEST_PURCHASED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GPaymnetManagerExample.NativeFieldInfoPtr_ANDROID_TEST_PURCHASED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000588 RID: 1416
	// (get) Token: 0x060012D0 RID: 4816 RVA: 0x00058390 File Offset: 0x00056590
	// (set) Token: 0x060012D1 RID: 4817 RVA: 0x000094C0 File Offset: 0x000076C0
	public unsafe static string ANDROID_TEST_CANCELED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GPaymnetManagerExample.NativeFieldInfoPtr_ANDROID_TEST_CANCELED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GPaymnetManagerExample.NativeFieldInfoPtr_ANDROID_TEST_CANCELED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000589 RID: 1417
	// (get) Token: 0x060012D2 RID: 4818 RVA: 0x000583B0 File Offset: 0x000565B0
	// (set) Token: 0x060012D3 RID: 4819 RVA: 0x000094D2 File Offset: 0x000076D2
	public unsafe static string ANDROID_TEST_REFUNDED
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GPaymnetManagerExample.NativeFieldInfoPtr_ANDROID_TEST_REFUNDED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GPaymnetManagerExample.NativeFieldInfoPtr_ANDROID_TEST_REFUNDED, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700058A RID: 1418
	// (get) Token: 0x060012D4 RID: 4820 RVA: 0x000583D0 File Offset: 0x000565D0
	// (set) Token: 0x060012D5 RID: 4821 RVA: 0x000094E4 File Offset: 0x000076E4
	public unsafe static string ANDROID_TEST_ITEM_UNAVAILABLE
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GPaymnetManagerExample.NativeFieldInfoPtr_ANDROID_TEST_ITEM_UNAVAILABLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GPaymnetManagerExample.NativeFieldInfoPtr_ANDROID_TEST_ITEM_UNAVAILABLE, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000E64 RID: 3684
	private static readonly IntPtr NativeFieldInfoPtr__isInited;

	// Token: 0x04000E65 RID: 3685
	private static readonly IntPtr NativeFieldInfoPtr_ANDROID_TEST_PURCHASED;

	// Token: 0x04000E66 RID: 3686
	private static readonly IntPtr NativeFieldInfoPtr_ANDROID_TEST_CANCELED;

	// Token: 0x04000E67 RID: 3687
	private static readonly IntPtr NativeFieldInfoPtr_ANDROID_TEST_REFUNDED;

	// Token: 0x04000E68 RID: 3688
	private static readonly IntPtr NativeFieldInfoPtr_ANDROID_TEST_ITEM_UNAVAILABLE;

	// Token: 0x04000E69 RID: 3689
	private static readonly IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;

	// Token: 0x04000E6A RID: 3690
	private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Static_Void_String_0;

	// Token: 0x04000E6B RID: 3691
	private static readonly IntPtr NativeMethodInfoPtr_consume_Public_Static_Void_String_0;

	// Token: 0x04000E6C RID: 3692
	private static readonly IntPtr NativeMethodInfoPtr_get_isInited_Public_Static_get_Boolean_0;

	// Token: 0x04000E6D RID: 3693
	private static readonly IntPtr NativeMethodInfoPtr_OnProcessingPurchasedProduct_Private_Static_Void_GooglePurchaseTemplate_0;

	// Token: 0x04000E6E RID: 3694
	private static readonly IntPtr NativeMethodInfoPtr_OnProcessingConsumeProduct_Private_Static_Void_GooglePurchaseTemplate_0;

	// Token: 0x04000E6F RID: 3695
	private static readonly IntPtr NativeMethodInfoPtr_OnProductPurchased_Private_Static_Void_BillingResult_0;

	// Token: 0x04000E70 RID: 3696
	private static readonly IntPtr NativeMethodInfoPtr_OnProductConsumed_Private_Static_Void_BillingResult_0;

	// Token: 0x04000E71 RID: 3697
	private static readonly IntPtr NativeMethodInfoPtr_OnBillingConnected_Private_Static_Void_BillingResult_0;

	// Token: 0x04000E72 RID: 3698
	private static readonly IntPtr NativeMethodInfoPtr_OnRetrieveProductsFinised_Private_Static_Void_BillingResult_0;

	// Token: 0x04000E73 RID: 3699
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

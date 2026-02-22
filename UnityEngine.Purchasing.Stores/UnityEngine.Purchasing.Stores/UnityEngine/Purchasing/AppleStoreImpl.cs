using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Uniject;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Security;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000049 RID: 73
	public class AppleStoreImpl : JSONStore
	{
		// Token: 0x06000252 RID: 594 RVA: 0x0000D920 File Offset: 0x0000BB20
		// Note: this type is marked as 'beforefieldinit'.
		static AppleStoreImpl()
		{
			Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "AppleStoreImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr);
			AppleStoreImpl.NativeFieldInfoPtr_m_DeferredCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, "m_DeferredCallback");
			AppleStoreImpl.NativeFieldInfoPtr_m_RefreshReceiptError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, "m_RefreshReceiptError");
			AppleStoreImpl.NativeFieldInfoPtr_m_RefreshReceiptSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, "m_RefreshReceiptSuccess");
			AppleStoreImpl.NativeFieldInfoPtr_m_RestoreCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, "m_RestoreCallback");
			AppleStoreImpl.NativeFieldInfoPtr_m_PromotionalPurchaseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, "m_PromotionalPurchaseCallback");
			AppleStoreImpl.NativeFieldInfoPtr_m_Native = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, "m_Native");
			AppleStoreImpl.NativeFieldInfoPtr_util = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, "util");
			AppleStoreImpl.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, "instance");
			AppleStoreImpl.NativeFieldInfoPtr_products_json = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, "products_json");
			AppleStoreImpl.NativeMethodInfoPtr__ctor_Public_Void_IUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, 100663594);
			AppleStoreImpl.NativeMethodInfoPtr_SetNativeStore_Public_Void_INativeAppleStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, 100663595);
			AppleStoreImpl.NativeMethodInfoPtr_OnProductsRetrieved_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, 100663596);
			AppleStoreImpl.NativeMethodInfoPtr_RestoreTransactions_Public_Virtual_Final_New_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, 100663597);
			AppleStoreImpl.NativeMethodInfoPtr_OnPurchaseDeferred_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, 100663598);
			AppleStoreImpl.NativeMethodInfoPtr_OnPromotionalPurchaseAttempted_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, 100663599);
			AppleStoreImpl.NativeMethodInfoPtr_OnTransactionsRestoredSuccess_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, 100663600);
			AppleStoreImpl.NativeMethodInfoPtr_OnTransactionsRestoredFail_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, 100663601);
			AppleStoreImpl.NativeMethodInfoPtr_OnAppReceiptRetrieved_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, 100663602);
			AppleStoreImpl.NativeMethodInfoPtr_OnAppReceiptRefreshedFailed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, 100663603);
			AppleStoreImpl.NativeMethodInfoPtr_MessageCallback_Private_Static_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, 100663604);
			AppleStoreImpl.NativeMethodInfoPtr_ProcessMessage_Private_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, 100663605);
			AppleStoreImpl.NativeMethodInfoPtr_OnPurchaseSucceeded_Public_Virtual_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, 100663606);
			AppleStoreImpl.NativeMethodInfoPtr_getAppleReceiptFromBase64String_Internal_AppleReceipt_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, 100663607);
			AppleStoreImpl.NativeMethodInfoPtr_isValidPurchaseState_Internal_Boolean_AppleReceipt_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, 100663608);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000DB30 File Offset: 0x0000BD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153125, XrefRangeEnd = 153129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppleStoreImpl(IUtil util)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(util);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.NativeMethodInfoPtr__ctor_Public_Void_IUtil_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000DB7C File Offset: 0x0000BD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153129, XrefRangeEnd = 153140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNativeStore(INativeAppleStore apple)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(apple);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.NativeMethodInfoPtr_SetNativeStore_Public_Void_INativeAppleStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153140, XrefRangeEnd = 153243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnProductsRetrieved(string json)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppleStoreImpl.NativeMethodInfoPtr_OnProductsRetrieved_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000DC10 File Offset: 0x0000BE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153243, XrefRangeEnd = 153247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RestoreTransactions(Action<bool> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.NativeMethodInfoPtr_RestoreTransactions_Public_Virtual_Final_New_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000DC54 File Offset: 0x0000BE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153247, XrefRangeEnd = 153254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPurchaseDeferred(string productId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.NativeMethodInfoPtr_OnPurchaseDeferred_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000DC98 File Offset: 0x0000BE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153254, XrefRangeEnd = 153261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPromotionalPurchaseAttempted(string productId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.NativeMethodInfoPtr_OnPromotionalPurchaseAttempted_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000DCDC File Offset: 0x0000BEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153261, XrefRangeEnd = 153264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTransactionsRestoredSuccess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.NativeMethodInfoPtr_OnTransactionsRestoredSuccess_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000DD10 File Offset: 0x0000BF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153264, XrefRangeEnd = 153267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTransactionsRestoredFail(string error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.NativeMethodInfoPtr_OnTransactionsRestoredFail_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000DD54 File Offset: 0x0000BF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153267, XrefRangeEnd = 153270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAppReceiptRetrieved(string receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(receipt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.NativeMethodInfoPtr_OnAppReceiptRetrieved_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000DD98 File Offset: 0x0000BF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153270, XrefRangeEnd = 153271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAppReceiptRefreshedFailed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.NativeMethodInfoPtr_OnAppReceiptRefreshedFailed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000DDCC File Offset: 0x0000BFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153271, XrefRangeEnd = 153287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MessageCallback(string subject, string payload, string receipt, string transactionId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(payload);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receipt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.NativeMethodInfoPtr_MessageCallback_Private_Static_Void_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000DE38 File Offset: 0x0000C038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153366, RefRangeEnd = 153367, XrefRangeStart = 153287, XrefRangeEnd = 153366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMessage(string subject, string payload, string receipt, string transactionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(payload);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receipt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.NativeMethodInfoPtr_ProcessMessage_Private_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000DEB4 File Offset: 0x0000C0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153367, XrefRangeEnd = 153374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPurchaseSucceeded(string id, string receipt, string transactionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receipt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppleStoreImpl.NativeMethodInfoPtr_OnPurchaseSucceeded_Public_Virtual_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000DF28 File Offset: 0x0000C128
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153385, RefRangeEnd = 153387, XrefRangeStart = 153374, XrefRangeEnd = 153385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppleReceipt getAppleReceiptFromBase64String(string receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(receipt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.NativeMethodInfoPtr_getAppleReceiptFromBase64String_Internal_AppleReceipt_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AppleReceipt>(intPtr3) : null;
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000DF78 File Offset: 0x0000C178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153438, RefRangeEnd = 153439, XrefRangeStart = 153387, XrefRangeEnd = 153438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isValidPurchaseState(AppleReceipt appleReceipt, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(appleReceipt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.NativeMethodInfoPtr_isValidPurchaseState_Internal_Boolean_AppleReceipt_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000031A3 File Offset: 0x000013A3
		public AppleStoreImpl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0000DFD8 File Offset: 0x0000C1D8
		// (set) Token: 0x06000264 RID: 612 RVA: 0x000031AC File Offset: 0x000013AC
		public unsafe Action<Product> m_DeferredCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.NativeFieldInfoPtr_m_DeferredCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.NativeFieldInfoPtr_m_DeferredCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0000E008 File Offset: 0x0000C208
		// (set) Token: 0x06000266 RID: 614 RVA: 0x000031CB File Offset: 0x000013CB
		public unsafe Action m_RefreshReceiptError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.NativeFieldInfoPtr_m_RefreshReceiptError);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.NativeFieldInfoPtr_m_RefreshReceiptError), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0000E038 File Offset: 0x0000C238
		// (set) Token: 0x06000268 RID: 616 RVA: 0x000031EA File Offset: 0x000013EA
		public unsafe Action<string> m_RefreshReceiptSuccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.NativeFieldInfoPtr_m_RefreshReceiptSuccess);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.NativeFieldInfoPtr_m_RefreshReceiptSuccess), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0000E068 File Offset: 0x0000C268
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00003209 File Offset: 0x00001409
		public unsafe Action<bool> m_RestoreCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.NativeFieldInfoPtr_m_RestoreCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.NativeFieldInfoPtr_m_RestoreCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0000E098 File Offset: 0x0000C298
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00003228 File Offset: 0x00001428
		public unsafe Action<Product> m_PromotionalPurchaseCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.NativeFieldInfoPtr_m_PromotionalPurchaseCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.NativeFieldInfoPtr_m_PromotionalPurchaseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000E0C8 File Offset: 0x0000C2C8
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00003247 File Offset: 0x00001447
		public unsafe INativeAppleStore m_Native
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.NativeFieldInfoPtr_m_Native);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<INativeAppleStore>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.NativeFieldInfoPtr_m_Native), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0000E0F8 File Offset: 0x0000C2F8
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00003266 File Offset: 0x00001466
		public unsafe static IUtil util
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppleStoreImpl.NativeFieldInfoPtr_util, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUtil>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppleStoreImpl.NativeFieldInfoPtr_util, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0000E120 File Offset: 0x0000C320
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00003278 File Offset: 0x00001478
		public unsafe static AppleStoreImpl instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AppleStoreImpl.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppleStoreImpl>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AppleStoreImpl.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000E148 File Offset: 0x0000C348
		// (set) Token: 0x06000274 RID: 628 RVA: 0x0000328A File Offset: 0x0000148A
		public unsafe string products_json
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.NativeFieldInfoPtr_products_json);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.NativeFieldInfoPtr_products_json), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr_m_DeferredCallback;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshReceiptError;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshReceiptSuccess;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr_m_RestoreCallback;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr_m_PromotionalPurchaseCallback;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_m_Native;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_util;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr_products_json;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IUtil_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_SetNativeStore_Public_Void_INativeAppleStore_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_OnProductsRetrieved_Public_Virtual_Void_String_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_RestoreTransactions_Public_Virtual_Final_New_Void_Action_1_Boolean_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseDeferred_Public_Void_String_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_OnPromotionalPurchaseAttempted_Public_Void_String_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_OnTransactionsRestoredSuccess_Public_Void_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_OnTransactionsRestoredFail_Public_Void_String_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_OnAppReceiptRetrieved_Public_Void_String_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_OnAppReceiptRefreshedFailed_Public_Void_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_MessageCallback_Private_Static_Void_String_String_String_String_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMessage_Private_Void_String_String_String_String_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseSucceeded_Public_Virtual_Void_String_String_String_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_getAppleReceiptFromBase64String_Internal_AppleReceipt_String_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_isValidPurchaseState_Internal_Boolean_AppleReceipt_String_0;

		// Token: 0x020000B1 RID: 177
		[ObfuscatedName("UnityEngine.Purchasing.AppleStoreImpl+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Object
		{
			// Token: 0x0600068E RID: 1678 RVA: 0x0001B278 File Offset: 0x00019478
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass23_0>.NativeClassPtr);
				AppleStoreImpl.__c__DisplayClass23_0.NativeFieldInfoPtr_productDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass23_0>.NativeClassPtr, "productDescription");
				AppleStoreImpl.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass23_0>.NativeClassPtr, 100663609);
				AppleStoreImpl.__c__DisplayClass23_0.NativeMethodInfoPtr__OnProductsRetrieved_b__0_Internal_Boolean_AppleInAppPurchaseReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass23_0>.NativeClassPtr, 100663610);
			}

			// Token: 0x0600068F RID: 1679 RVA: 0x0001B2E0 File Offset: 0x000194E0
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000690 RID: 1680 RVA: 0x0001B31C File Offset: 0x0001951C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153117, XrefRangeEnd = 153119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnProductsRetrieved_b__0(AppleInAppPurchaseReceipt r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.__c__DisplayClass23_0.NativeMethodInfoPtr__OnProductsRetrieved_b__0_Internal_Boolean_AppleInAppPurchaseReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000691 RID: 1681 RVA: 0x00005521 File Offset: 0x00003721
			public __c__DisplayClass23_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x06000692 RID: 1682 RVA: 0x0001B36C File Offset: 0x0001956C
			// (set) Token: 0x06000693 RID: 1683 RVA: 0x0000552A File Offset: 0x0000372A
			public unsafe ProductDescription productDescription
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.__c__DisplayClass23_0.NativeFieldInfoPtr_productDescription);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.__c__DisplayClass23_0.NativeFieldInfoPtr_productDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000449 RID: 1097
			private static readonly IntPtr NativeFieldInfoPtr_productDescription;

			// Token: 0x0400044A RID: 1098
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400044B RID: 1099
			private static readonly IntPtr NativeMethodInfoPtr__OnProductsRetrieved_b__0_Internal_Boolean_AppleInAppPurchaseReceipt_0;
		}

		// Token: 0x020000B2 RID: 178
		[ObfuscatedName("UnityEngine.Purchasing.AppleStoreImpl+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000694 RID: 1684 RVA: 0x0001B39C File Offset: 0x0001959C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AppleStoreImpl.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppleStoreImpl.__c>.NativeClassPtr);
				AppleStoreImpl.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleStoreImpl.__c>.NativeClassPtr, "<>9");
				AppleStoreImpl.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleStoreImpl.__c>.NativeClassPtr, "<>9__23_1");
				AppleStoreImpl.__c.NativeFieldInfoPtr___9__41_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleStoreImpl.__c>.NativeClassPtr, "<>9__41_1");
				AppleStoreImpl.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl.__c>.NativeClassPtr, 100663612);
				AppleStoreImpl.__c.NativeMethodInfoPtr__OnProductsRetrieved_b__23_1_Internal_Int32_AppleInAppPurchaseReceipt_AppleInAppPurchaseReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl.__c>.NativeClassPtr, 100663613);
				AppleStoreImpl.__c.NativeMethodInfoPtr__isValidPurchaseState_b__41_1_Internal_Int32_AppleInAppPurchaseReceipt_AppleInAppPurchaseReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl.__c>.NativeClassPtr, 100663614);
			}

			// Token: 0x06000695 RID: 1685 RVA: 0x0001B440 File Offset: 0x00019640
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppleStoreImpl.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000696 RID: 1686 RVA: 0x0001B47C File Offset: 0x0001967C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153119, XrefRangeEnd = 153120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnProductsRetrieved_b__23_1(AppleInAppPurchaseReceipt b, AppleInAppPurchaseReceipt a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.__c.NativeMethodInfoPtr__OnProductsRetrieved_b__23_1_Internal_Int32_AppleInAppPurchaseReceipt_AppleInAppPurchaseReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000697 RID: 1687 RVA: 0x0001B4DC File Offset: 0x000196DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _isValidPurchaseState_b__41_1(AppleInAppPurchaseReceipt b, AppleInAppPurchaseReceipt a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.__c.NativeMethodInfoPtr__isValidPurchaseState_b__41_1_Internal_Int32_AppleInAppPurchaseReceipt_AppleInAppPurchaseReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000698 RID: 1688 RVA: 0x00005549 File Offset: 0x00003749
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x06000699 RID: 1689 RVA: 0x0001B53C File Offset: 0x0001973C
			// (set) Token: 0x0600069A RID: 1690 RVA: 0x00005552 File Offset: 0x00003752
			public unsafe static AppleStoreImpl.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AppleStoreImpl.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppleStoreImpl.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AppleStoreImpl.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A9 RID: 425
			// (get) Token: 0x0600069B RID: 1691 RVA: 0x0001B564 File Offset: 0x00019764
			// (set) Token: 0x0600069C RID: 1692 RVA: 0x00005564 File Offset: 0x00003764
			public unsafe static Comparison<AppleInAppPurchaseReceipt> __9__23_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AppleStoreImpl.__c.NativeFieldInfoPtr___9__23_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<AppleInAppPurchaseReceipt>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AppleStoreImpl.__c.NativeFieldInfoPtr___9__23_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001AA RID: 426
			// (get) Token: 0x0600069D RID: 1693 RVA: 0x0001B58C File Offset: 0x0001978C
			// (set) Token: 0x0600069E RID: 1694 RVA: 0x00005576 File Offset: 0x00003776
			public unsafe static Comparison<AppleInAppPurchaseReceipt> __9__41_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AppleStoreImpl.__c.NativeFieldInfoPtr___9__41_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<AppleInAppPurchaseReceipt>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AppleStoreImpl.__c.NativeFieldInfoPtr___9__41_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400044C RID: 1100
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400044D RID: 1101
			private static readonly IntPtr NativeFieldInfoPtr___9__23_1;

			// Token: 0x0400044E RID: 1102
			private static readonly IntPtr NativeFieldInfoPtr___9__41_1;

			// Token: 0x0400044F RID: 1103
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000450 RID: 1104
			private static readonly IntPtr NativeMethodInfoPtr__OnProductsRetrieved_b__23_1_Internal_Int32_AppleInAppPurchaseReceipt_AppleInAppPurchaseReceipt_0;

			// Token: 0x04000451 RID: 1105
			private static readonly IntPtr NativeMethodInfoPtr__isValidPurchaseState_b__41_1_Internal_Int32_AppleInAppPurchaseReceipt_AppleInAppPurchaseReceipt_0;
		}

		// Token: 0x020000B3 RID: 179
		[ObfuscatedName("UnityEngine.Purchasing.AppleStoreImpl+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Object
		{
			// Token: 0x0600069F RID: 1695 RVA: 0x0001B5B4 File Offset: 0x000197B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass37_0>.NativeClassPtr);
				AppleStoreImpl.__c__DisplayClass37_0.NativeFieldInfoPtr_subject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass37_0>.NativeClassPtr, "subject");
				AppleStoreImpl.__c__DisplayClass37_0.NativeFieldInfoPtr_payload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass37_0>.NativeClassPtr, "payload");
				AppleStoreImpl.__c__DisplayClass37_0.NativeFieldInfoPtr_receipt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass37_0>.NativeClassPtr, "receipt");
				AppleStoreImpl.__c__DisplayClass37_0.NativeFieldInfoPtr_transactionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass37_0>.NativeClassPtr, "transactionId");
				AppleStoreImpl.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass37_0>.NativeClassPtr, 100663615);
				AppleStoreImpl.__c__DisplayClass37_0.NativeMethodInfoPtr__MessageCallback_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass37_0>.NativeClassPtr, 100663616);
			}

			// Token: 0x060006A0 RID: 1696 RVA: 0x0001B658 File Offset: 0x00019858
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006A1 RID: 1697 RVA: 0x0001B694 File Offset: 0x00019894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153120, XrefRangeEnd = 153123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MessageCallback_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.__c__DisplayClass37_0.NativeMethodInfoPtr__MessageCallback_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006A2 RID: 1698 RVA: 0x00005588 File Offset: 0x00003788
			public __c__DisplayClass37_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001AB RID: 427
			// (get) Token: 0x060006A3 RID: 1699 RVA: 0x0001B6C8 File Offset: 0x000198C8
			// (set) Token: 0x060006A4 RID: 1700 RVA: 0x00005591 File Offset: 0x00003791
			public unsafe string subject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.__c__DisplayClass37_0.NativeFieldInfoPtr_subject);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.__c__DisplayClass37_0.NativeFieldInfoPtr_subject), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170001AC RID: 428
			// (get) Token: 0x060006A5 RID: 1701 RVA: 0x0001B6F0 File Offset: 0x000198F0
			// (set) Token: 0x060006A6 RID: 1702 RVA: 0x000055B0 File Offset: 0x000037B0
			public unsafe string payload
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.__c__DisplayClass37_0.NativeFieldInfoPtr_payload);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.__c__DisplayClass37_0.NativeFieldInfoPtr_payload), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170001AD RID: 429
			// (get) Token: 0x060006A7 RID: 1703 RVA: 0x0001B718 File Offset: 0x00019918
			// (set) Token: 0x060006A8 RID: 1704 RVA: 0x000055CF File Offset: 0x000037CF
			public unsafe string receipt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.__c__DisplayClass37_0.NativeFieldInfoPtr_receipt);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.__c__DisplayClass37_0.NativeFieldInfoPtr_receipt), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170001AE RID: 430
			// (get) Token: 0x060006A9 RID: 1705 RVA: 0x0001B740 File Offset: 0x00019940
			// (set) Token: 0x060006AA RID: 1706 RVA: 0x000055EE File Offset: 0x000037EE
			public unsafe string transactionId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.__c__DisplayClass37_0.NativeFieldInfoPtr_transactionId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.__c__DisplayClass37_0.NativeFieldInfoPtr_transactionId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000452 RID: 1106
			private static readonly IntPtr NativeFieldInfoPtr_subject;

			// Token: 0x04000453 RID: 1107
			private static readonly IntPtr NativeFieldInfoPtr_payload;

			// Token: 0x04000454 RID: 1108
			private static readonly IntPtr NativeFieldInfoPtr_receipt;

			// Token: 0x04000455 RID: 1109
			private static readonly IntPtr NativeFieldInfoPtr_transactionId;

			// Token: 0x04000456 RID: 1110
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000457 RID: 1111
			private static readonly IntPtr NativeMethodInfoPtr__MessageCallback_b__0_Internal_Void_0;
		}

		// Token: 0x020000B4 RID: 180
		[ObfuscatedName("UnityEngine.Purchasing.AppleStoreImpl+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Object
		{
			// Token: 0x060006AB RID: 1707 RVA: 0x0001B768 File Offset: 0x00019968
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AppleStoreImpl>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass41_0>.NativeClassPtr);
				AppleStoreImpl.__c__DisplayClass41_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass41_0>.NativeClassPtr, "id");
				AppleStoreImpl.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass41_0>.NativeClassPtr, 100663617);
				AppleStoreImpl.__c__DisplayClass41_0.NativeMethodInfoPtr__isValidPurchaseState_b__0_Internal_Boolean_AppleInAppPurchaseReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass41_0>.NativeClassPtr, 100663618);
			}

			// Token: 0x060006AC RID: 1708 RVA: 0x0001B7D0 File Offset: 0x000199D0
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppleStoreImpl.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006AD RID: 1709 RVA: 0x0001B80C File Offset: 0x00019A0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153123, XrefRangeEnd = 153125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _isValidPurchaseState_b__0(AppleInAppPurchaseReceipt r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleStoreImpl.__c__DisplayClass41_0.NativeMethodInfoPtr__isValidPurchaseState_b__0_Internal_Boolean_AppleInAppPurchaseReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060006AE RID: 1710 RVA: 0x0000560D File Offset: 0x0000380D
			public __c__DisplayClass41_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001AF RID: 431
			// (get) Token: 0x060006AF RID: 1711 RVA: 0x0001B85C File Offset: 0x00019A5C
			// (set) Token: 0x060006B0 RID: 1712 RVA: 0x00005616 File Offset: 0x00003816
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.__c__DisplayClass41_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleStoreImpl.__c__DisplayClass41_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000458 RID: 1112
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04000459 RID: 1113
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400045A RID: 1114
			private static readonly IntPtr NativeMethodInfoPtr__isValidPurchaseState_b__0_Internal_Boolean_AppleInAppPurchaseReceipt_0;
		}
	}
}

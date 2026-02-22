using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000F RID: 15
	public class GooglePlayStoreService : Object
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00006D24 File Offset: 0x00004F24
		// Note: this type is marked as 'beforefieldinit'.
		static GooglePlayStoreService()
		{
			Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GooglePlayStoreService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr);
			GooglePlayStoreService.NativeFieldInfoPtr_m_GoogleConnectionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, "m_GoogleConnectionState");
			GooglePlayStoreService.NativeFieldInfoPtr_m_BillingClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, "m_BillingClient");
			GooglePlayStoreService.NativeFieldInfoPtr_m_BillingClientStateListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, "m_BillingClientStateListener");
			GooglePlayStoreService.NativeFieldInfoPtr_m_QuerySkuDetailsService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, "m_QuerySkuDetailsService");
			GooglePlayStoreService.NativeFieldInfoPtr_m_ProductsToQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, "m_ProductsToQuery");
			GooglePlayStoreService.NativeFieldInfoPtr_m_OnPurchaseSucceededQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, "m_OnPurchaseSucceededQueue");
			GooglePlayStoreService.NativeFieldInfoPtr_m_GooglePurchaseService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, "m_GooglePurchaseService");
			GooglePlayStoreService.NativeFieldInfoPtr_m_GoogleFinishTransactionService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, "m_GoogleFinishTransactionService");
			GooglePlayStoreService.NativeFieldInfoPtr_m_GoogleQueryPurchasesService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, "m_GoogleQueryPurchasesService");
			GooglePlayStoreService.NativeFieldInfoPtr_m_GooglePriceChangeService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, "m_GooglePriceChangeService");
			GooglePlayStoreService.NativeFieldInfoPtr_m_GoogleLastKnownProductService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, "m_GoogleLastKnownProductService");
			GooglePlayStoreService.NativeMethodInfoPtr__ctor_Internal_Void_IGoogleBillingClient_IQuerySkuDetailsService_IGooglePurchaseService_IGoogleFinishTransactionService_IGoogleQueryPurchasesService_IBillingClientStateListener_IGooglePriceChangeService_IGoogleLastKnownProductService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, 100663346);
			GooglePlayStoreService.NativeMethodInfoPtr_InitConnectionWithGooglePlay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, 100663347);
			GooglePlayStoreService.NativeMethodInfoPtr_StartConnection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, 100663348);
			GooglePlayStoreService.NativeMethodInfoPtr_ResumeConnection_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, 100663349);
			GooglePlayStoreService.NativeMethodInfoPtr_OnConnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, 100663350);
			GooglePlayStoreService.NativeMethodInfoPtr_DequeueQueryProducts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, 100663351);
			GooglePlayStoreService.NativeMethodInfoPtr_DequeueFetchPurchases_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, 100663352);
			GooglePlayStoreService.NativeMethodInfoPtr_OnDisconnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, 100663353);
			GooglePlayStoreService.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_ProductDescription_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, 100663354);
			GooglePlayStoreService.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, 100663355);
			GooglePlayStoreService.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_ProductDefinition_Product_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, 100663356);
			GooglePlayStoreService.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_ProductDefinition_String_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, 100663357);
			GooglePlayStoreService.NativeMethodInfoPtr_FetchPurchases_Public_Virtual_Final_New_Void_Action_1_List_1_GooglePurchase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr, 100663358);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00006F34 File Offset: 0x00005134
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150454, RefRangeEnd = 150455, XrefRangeStart = 150421, XrefRangeEnd = 150454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GooglePlayStoreService(IGoogleBillingClient billingClient, IQuerySkuDetailsService querySkuDetailsService, IGooglePurchaseService purchaseService, IGoogleFinishTransactionService finishTransactionService, IGoogleQueryPurchasesService queryPurchasesService, IBillingClientStateListener billingClientStateListener, IGooglePriceChangeService priceChangeService, IGoogleLastKnownProductService lastKnownProductService)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayStoreService>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingClient);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(querySkuDetailsService);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(purchaseService);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(finishTransactionService);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(queryPurchasesService);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(billingClientStateListener);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(priceChangeService);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastKnownProductService);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreService.NativeMethodInfoPtr__ctor_Internal_Void_IGoogleBillingClient_IQuerySkuDetailsService_IGooglePurchaseService_IGoogleFinishTransactionService_IGoogleQueryPurchasesService_IBillingClientStateListener_IGooglePriceChangeService_IGoogleLastKnownProductService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00007004 File Offset: 0x00005204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150455, XrefRangeEnd = 150475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitConnectionWithGooglePlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreService.NativeMethodInfoPtr_InitConnectionWithGooglePlay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00007038 File Offset: 0x00005238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150475, XrefRangeEnd = 150479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreService.NativeMethodInfoPtr_StartConnection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000706C File Offset: 0x0000526C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150479, XrefRangeEnd = 150482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResumeConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreService.NativeMethodInfoPtr_ResumeConnection_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000070A0 File Offset: 0x000052A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150482, XrefRangeEnd = 150495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnConnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreService.NativeMethodInfoPtr_OnConnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000070D4 File Offset: 0x000052D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150548, RefRangeEnd = 150550, XrefRangeStart = 150495, XrefRangeEnd = 150548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DequeueQueryProducts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreService.NativeMethodInfoPtr_DequeueQueryProducts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00007108 File Offset: 0x00005308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150550, XrefRangeEnd = 150562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DequeueFetchPurchases()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreService.NativeMethodInfoPtr_DequeueFetchPurchases_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000713C File Offset: 0x0000533C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150562, XrefRangeEnd = 150563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisconnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreService.NativeMethodInfoPtr_OnDisconnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00007170 File Offset: 0x00005370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150563, XrefRangeEnd = 150572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onProductsReceived, Action onRetrieveProductFailed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onProductsReceived);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onRetrieveProductFailed);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreService.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_ProductDescription_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000071D8 File Offset: 0x000053D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150572, XrefRangeEnd = 150584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Purchase(ProductDefinition product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreService.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000721C File Offset: 0x0000541C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150584, XrefRangeEnd = 150594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Purchase(ProductDefinition product, Product oldProduct, int desiredProrationMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldProduct);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desiredProrationMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreService.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_ProductDefinition_Product_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00007280 File Offset: 0x00005480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150594, XrefRangeEnd = 150597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FinishTransaction(ProductDefinition product, string purchaseToken, Action<ProductDefinition, GooglePurchase, GoogleBillingResult, string> onConsume, Action<ProductDefinition, GooglePurchase, GoogleBillingResult> onAcknowledge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(purchaseToken);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onConsume);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onAcknowledge);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreService.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_ProductDefinition_String_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000072FC File Offset: 0x000054FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150597, XrefRangeEnd = 150604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FetchPurchases(Action<List<GooglePurchase>> onQueryPurchaseSucceed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onQueryPurchaseSucceed);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreService.NativeMethodInfoPtr_FetchPurchases_Public_Virtual_Final_New_Void_Action_1_List_1_GooglePurchase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002238 File Offset: 0x00000438
		public GooglePlayStoreService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00007340 File Offset: 0x00005540
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002241 File Offset: 0x00000441
		public unsafe GoogleBillingConnectionState m_GoogleConnectionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_GoogleConnectionState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_GoogleConnectionState)) = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00007368 File Offset: 0x00005568
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0000225C File Offset: 0x0000045C
		public unsafe IGoogleBillingClient m_BillingClient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_BillingClient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGoogleBillingClient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_BillingClient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00007398 File Offset: 0x00005598
		// (set) Token: 0x0600006B RID: 107 RVA: 0x0000227B File Offset: 0x0000047B
		public unsafe IBillingClientStateListener m_BillingClientStateListener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_BillingClientStateListener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IBillingClientStateListener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_BillingClientStateListener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000073C8 File Offset: 0x000055C8
		// (set) Token: 0x0600006D RID: 109 RVA: 0x0000229A File Offset: 0x0000049A
		public unsafe IQuerySkuDetailsService m_QuerySkuDetailsService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_QuerySkuDetailsService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IQuerySkuDetailsService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_QuerySkuDetailsService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000073F8 File Offset: 0x000055F8
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000022B9 File Offset: 0x000004B9
		public unsafe Queue<ProductDescriptionQuery> m_ProductsToQuery
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_ProductsToQuery);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<ProductDescriptionQuery>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_ProductsToQuery), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00007428 File Offset: 0x00005628
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000022D8 File Offset: 0x000004D8
		public unsafe Queue<Action<List<GooglePurchase>>> m_OnPurchaseSucceededQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_OnPurchaseSucceededQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<Action<List<GooglePurchase>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_OnPurchaseSucceededQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00007458 File Offset: 0x00005658
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000022F7 File Offset: 0x000004F7
		public unsafe IGooglePurchaseService m_GooglePurchaseService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_GooglePurchaseService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePurchaseService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_GooglePurchaseService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00007488 File Offset: 0x00005688
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002316 File Offset: 0x00000516
		public unsafe IGoogleFinishTransactionService m_GoogleFinishTransactionService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_GoogleFinishTransactionService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGoogleFinishTransactionService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_GoogleFinishTransactionService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000074B8 File Offset: 0x000056B8
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002335 File Offset: 0x00000535
		public unsafe IGoogleQueryPurchasesService m_GoogleQueryPurchasesService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_GoogleQueryPurchasesService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGoogleQueryPurchasesService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_GoogleQueryPurchasesService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000074E8 File Offset: 0x000056E8
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002354 File Offset: 0x00000554
		public unsafe IGooglePriceChangeService m_GooglePriceChangeService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_GooglePriceChangeService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePriceChangeService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_GooglePriceChangeService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00007518 File Offset: 0x00005718
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002373 File Offset: 0x00000573
		public unsafe IGoogleLastKnownProductService m_GoogleLastKnownProductService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_GoogleLastKnownProductService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGoogleLastKnownProductService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreService.NativeFieldInfoPtr_m_GoogleLastKnownProductService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_m_GoogleConnectionState;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_m_BillingClient;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_m_BillingClientStateListener;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_m_QuerySkuDetailsService;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_m_ProductsToQuery;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_m_OnPurchaseSucceededQueue;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_m_GooglePurchaseService;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_m_GoogleFinishTransactionService;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_m_GoogleQueryPurchasesService;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_m_GooglePriceChangeService;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_m_GoogleLastKnownProductService;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IGoogleBillingClient_IQuerySkuDetailsService_IGooglePurchaseService_IGoogleFinishTransactionService_IGoogleQueryPurchasesService_IBillingClientStateListener_IGooglePriceChangeService_IGoogleLastKnownProductService_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_InitConnectionWithGooglePlay_Private_Void_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_StartConnection_Private_Void_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_ResumeConnection_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_OnConnected_Private_Void_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_DequeueQueryProducts_Private_Void_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_DequeueFetchPurchases_Private_Void_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_OnDisconnected_Private_Void_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_ProductDescription_Action_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_ProductDefinition_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_ProductDefinition_Product_Int32_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_ProductDefinition_String_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_FetchPurchases_Public_Virtual_Final_New_Void_Action_1_List_1_GooglePurchase_0;
	}
}

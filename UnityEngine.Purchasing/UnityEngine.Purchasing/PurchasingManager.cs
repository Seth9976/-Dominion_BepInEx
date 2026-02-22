using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000016 RID: 22
	public class PurchasingManager : Object
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x0000587C File Offset: 0x00003A7C
		// Note: this type is marked as 'beforefieldinit'.
		static PurchasingManager()
		{
			Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "PurchasingManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr);
			PurchasingManager.NativeFieldInfoPtr_m_Store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, "m_Store");
			PurchasingManager.NativeFieldInfoPtr_m_Listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, "m_Listener");
			PurchasingManager.NativeFieldInfoPtr_m_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, "m_Logger");
			PurchasingManager.NativeFieldInfoPtr_m_TransactionLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, "m_TransactionLog");
			PurchasingManager.NativeFieldInfoPtr_m_StoreName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, "m_StoreName");
			PurchasingManager.NativeFieldInfoPtr_m_AdditionalProductsCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, "m_AdditionalProductsCallback");
			PurchasingManager.NativeFieldInfoPtr_m_AdditionalProductsFailCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, "m_AdditionalProductsFailCallback");
			PurchasingManager.NativeFieldInfoPtr__useTransactionLog_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, "<useTransactionLog>k__BackingField");
			PurchasingManager.NativeFieldInfoPtr__products_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, "<products>k__BackingField");
			PurchasingManager.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, "initialized");
			PurchasingManager.NativeMethodInfoPtr_get_useTransactionLog_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663393);
			PurchasingManager.NativeMethodInfoPtr_set_useTransactionLog_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663394);
			PurchasingManager.NativeMethodInfoPtr__ctor_Internal_Void_TransactionLog_ILogger_IStore_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663395);
			PurchasingManager.NativeMethodInfoPtr_InitiatePurchase_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663396);
			PurchasingManager.NativeMethodInfoPtr_InitiatePurchase_Public_Virtual_Final_New_Void_Product_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663397);
			PurchasingManager.NativeMethodInfoPtr_InitiatePurchase_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663398);
			PurchasingManager.NativeMethodInfoPtr_ConfirmPendingPurchase_Public_Virtual_Final_New_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663399);
			PurchasingManager.NativeMethodInfoPtr_get_products_Public_Virtual_Final_New_get_ProductCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663400);
			PurchasingManager.NativeMethodInfoPtr_set_products_Private_set_Void_ProductCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663401);
			PurchasingManager.NativeMethodInfoPtr_OnPurchaseSucceeded_Public_Virtual_Final_New_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663402);
			PurchasingManager.NativeMethodInfoPtr_UpdateProductReceiptAndTrandsactionID_Private_Void_Product_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663403);
			PurchasingManager.NativeMethodInfoPtr_OnAllPurchasesRetrieved_Public_Virtual_Final_New_Void_List_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663404);
			PurchasingManager.NativeMethodInfoPtr_HandlePurchaseRetrieved_Private_Void_Product_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663405);
			PurchasingManager.NativeMethodInfoPtr_ClearProductReceipt_Private_Static_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663406);
			PurchasingManager.NativeMethodInfoPtr_OnSetupFailed_Public_Virtual_Final_New_Void_InitializationFailureReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663407);
			PurchasingManager.NativeMethodInfoPtr_OnPurchaseFailed_Public_Virtual_Final_New_Void_PurchaseFailureDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663408);
			PurchasingManager.NativeMethodInfoPtr_OnProductsRetrieved_Public_Virtual_Final_New_Void_List_1_ProductDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663409);
			PurchasingManager.NativeMethodInfoPtr_CreateUnifiedReceipt_Private_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663410);
			PurchasingManager.NativeMethodInfoPtr_ProcessPurchaseOnStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663411);
			PurchasingManager.NativeMethodInfoPtr_ProcessPurchaseIfNew_Private_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663412);
			PurchasingManager.NativeMethodInfoPtr_CheckForInitialization_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663413);
			PurchasingManager.NativeMethodInfoPtr_HasAvailableProductsToPurchase_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663414);
			PurchasingManager.NativeMethodInfoPtr_Initialize_Public_Void_IInternalStoreListener_HashSet_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, 100663415);
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00005B40 File Offset: 0x00003D40
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00005B7C File Offset: 0x00003D7C
		public unsafe virtual bool useTransactionLog
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_get_useTransactionLog_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_set_useTransactionLog_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00005BBC File Offset: 0x00003DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130810, XrefRangeEnd = 130811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PurchasingManager(TransactionLog tDb, ILogger logger, IStore store, string storeName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tDb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(logger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(store);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(storeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr__ctor_Internal_Void_TransactionLog_ILogger_IStore_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00005C40 File Offset: 0x00003E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130811, XrefRangeEnd = 130814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitiatePurchase(string productId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_InitiatePurchase_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005C84 File Offset: 0x00003E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130814, XrefRangeEnd = 130821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitiatePurchase(Product product, string developerPayload)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(developerPayload);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_InitiatePurchase_Public_Virtual_Final_New_Void_Product_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00005CD8 File Offset: 0x00003ED8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130840, RefRangeEnd = 130841, XrefRangeStart = 130821, XrefRangeEnd = 130840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitiatePurchase(string purchasableId, string developerPayload)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(purchasableId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(developerPayload);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_InitiatePurchase_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00005D2C File Offset: 0x00003F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130841, XrefRangeEnd = 130850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ConfirmPendingPurchase(Product product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_ConfirmPendingPurchase_Public_Virtual_Final_New_Void_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00005D70 File Offset: 0x00003F70
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00005DB0 File Offset: 0x00003FB0
		public unsafe virtual ProductCollection products
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_get_products_Public_Virtual_Final_New_get_ProductCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductCollection>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_set_products_Private_set_Void_ProductCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00005DF4 File Offset: 0x00003FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130850, XrefRangeEnd = 130867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPurchaseSucceeded(string id, string receipt, string transactionId)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_OnPurchaseSucceeded_Public_Virtual_Final_New_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00005E5C File Offset: 0x0000405C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130867, XrefRangeEnd = 130868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateProductReceiptAndTrandsactionID(Product product, string receipt, string transactionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receipt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_UpdateProductReceiptAndTrandsactionID_Private_Void_Product_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00005EC4 File Offset: 0x000040C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130868, XrefRangeEnd = 130886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAllPurchasesRetrieved(List<Product> purchasedProducts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchasedProducts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_OnAllPurchasesRetrieved_Public_Virtual_Final_New_Void_List_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00005F08 File Offset: 0x00004108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130886, XrefRangeEnd = 130887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandlePurchaseRetrieved(Product product, Product purchasedProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(purchasedProduct);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_HandlePurchaseRetrieved_Private_Void_Product_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00005F5C File Offset: 0x0000415C
		[CallerCount(0)]
		public unsafe static void ClearProductReceipt(Product product)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_ClearProductReceipt_Private_Static_Void_Product_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00005F94 File Offset: 0x00004194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130887, XrefRangeEnd = 130893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSetupFailed(InitializationFailureReason reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reason;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_OnSetupFailed_Public_Virtual_Final_New_Void_InitializationFailureReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005FD4 File Offset: 0x000041D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130893, XrefRangeEnd = 130917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPurchaseFailed(PurchaseFailureDescription description)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_OnPurchaseFailed_Public_Virtual_Final_New_Void_PurchaseFailureDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00006018 File Offset: 0x00004218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130917, XrefRangeEnd = 130970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnProductsRetrieved(List<ProductDescription> products)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_OnProductsRetrieved_Public_Virtual_Final_New_Void_List_1_ProductDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000605C File Offset: 0x0000425C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130970, XrefRangeEnd = 130971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateUnifiedReceipt(string rawReceipt, string transactionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(rawReceipt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_CreateUnifiedReceipt_Private_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000060B8 File Offset: 0x000042B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130988, RefRangeEnd = 130989, XrefRangeStart = 130971, XrefRangeEnd = 130988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessPurchaseOnStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_ProcessPurchaseOnStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000060EC File Offset: 0x000042EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131006, RefRangeEnd = 131008, XrefRangeStart = 130989, XrefRangeEnd = 131006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessPurchaseIfNew(Product product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_ProcessPurchaseIfNew_Private_Void_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00006130 File Offset: 0x00004330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131008, XrefRangeEnd = 131010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForInitialization()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_CheckForInitialization_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00006164 File Offset: 0x00004364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131035, RefRangeEnd = 131036, XrefRangeStart = 131010, XrefRangeEnd = 131035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasAvailableProductsToPurchase(bool shouldLogUnavailableProducts = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shouldLogUnavailableProducts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_HasAvailableProductsToPurchase_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000061B0 File Offset: 0x000043B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131084, RefRangeEnd = 131085, XrefRangeStart = 131036, XrefRangeEnd = 131084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(IInternalStoreListener listener, HashSet<ProductDefinition> products)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(products);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.NativeMethodInfoPtr_Initialize_Public_Void_IInternalStoreListener_HashSet_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002522 File Offset: 0x00000722
		public PurchasingManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00006204 File Offset: 0x00004404
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000252B File Offset: 0x0000072B
		public unsafe IStore m_Store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr_m_Store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStore>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr_m_Store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00006234 File Offset: 0x00004434
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000254A File Offset: 0x0000074A
		public unsafe IInternalStoreListener m_Listener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr_m_Listener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IInternalStoreListener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr_m_Listener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00006264 File Offset: 0x00004464
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00002569 File Offset: 0x00000769
		public unsafe ILogger m_Logger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr_m_Logger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr_m_Logger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00006294 File Offset: 0x00004494
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00002588 File Offset: 0x00000788
		public unsafe TransactionLog m_TransactionLog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr_m_TransactionLog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransactionLog>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr_m_TransactionLog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x000062C4 File Offset: 0x000044C4
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x000025A7 File Offset: 0x000007A7
		public unsafe string m_StoreName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr_m_StoreName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr_m_StoreName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000062EC File Offset: 0x000044EC
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x000025C6 File Offset: 0x000007C6
		public unsafe Action m_AdditionalProductsCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr_m_AdditionalProductsCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr_m_AdditionalProductsCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000631C File Offset: 0x0000451C
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x000025E5 File Offset: 0x000007E5
		public unsafe Action<InitializationFailureReason> m_AdditionalProductsFailCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr_m_AdditionalProductsFailCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InitializationFailureReason>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr_m_AdditionalProductsFailCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000634C File Offset: 0x0000454C
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002604 File Offset: 0x00000804
		public unsafe bool _useTransactionLog_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr__useTransactionLog_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr__useTransactionLog_k__BackingField)) = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00006374 File Offset: 0x00004574
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000261F File Offset: 0x0000081F
		public unsafe ProductCollection _products_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr__products_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr__products_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000063A4 File Offset: 0x000045A4
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0000263E File Offset: 0x0000083E
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_m_Store;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_m_Listener;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_m_Logger;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_m_TransactionLog;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_m_StoreName;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalProductsCallback;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditionalProductsFailCallback;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr__useTransactionLog_k__BackingField;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr__products_k__BackingField;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_get_useTransactionLog_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_set_useTransactionLog_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TransactionLog_ILogger_IStore_String_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_InitiatePurchase_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_InitiatePurchase_Public_Virtual_Final_New_Void_Product_String_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_InitiatePurchase_Public_Virtual_Final_New_Void_String_String_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmPendingPurchase_Public_Virtual_Final_New_Void_Product_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_get_products_Public_Virtual_Final_New_get_ProductCollection_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_set_products_Private_set_Void_ProductCollection_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseSucceeded_Public_Virtual_Final_New_Void_String_String_String_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_UpdateProductReceiptAndTrandsactionID_Private_Void_Product_String_String_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_OnAllPurchasesRetrieved_Public_Virtual_Final_New_Void_List_1_Product_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_HandlePurchaseRetrieved_Private_Void_Product_Product_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_ClearProductReceipt_Private_Static_Void_Product_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_OnSetupFailed_Public_Virtual_Final_New_Void_InitializationFailureReason_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseFailed_Public_Virtual_Final_New_Void_PurchaseFailureDescription_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_OnProductsRetrieved_Public_Virtual_Final_New_Void_List_1_ProductDescription_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_CreateUnifiedReceipt_Private_String_String_String_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPurchaseOnStart_Private_Void_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPurchaseIfNew_Private_Void_Product_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_CheckForInitialization_Private_Void_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_HasAvailableProductsToPurchase_Private_Boolean_Boolean_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_IInternalStoreListener_HashSet_1_ProductDefinition_0;

		// Token: 0x0200002E RID: 46
		[ObfuscatedName("UnityEngine.Purchasing.PurchasingManager+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Object
		{
			// Token: 0x06000186 RID: 390 RVA: 0x00008840 File Offset: 0x00006A40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<PurchasingManager.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PurchasingManager.__c__DisplayClass24_0>.NativeClassPtr);
				PurchasingManager.__c__DisplayClass24_0.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasingManager.__c__DisplayClass24_0>.NativeClassPtr, "product");
				PurchasingManager.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager.__c__DisplayClass24_0>.NativeClassPtr, 100663416);
				PurchasingManager.__c__DisplayClass24_0.NativeMethodInfoPtr__OnAllPurchasesRetrieved_b__0_Internal_Boolean_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager.__c__DisplayClass24_0>.NativeClassPtr, 100663417);
			}

			// Token: 0x06000187 RID: 391 RVA: 0x000088A8 File Offset: 0x00006AA8
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PurchasingManager.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000188 RID: 392 RVA: 0x000088E4 File Offset: 0x00006AE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130800, XrefRangeEnd = 130802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnAllPurchasesRetrieved_b__0(Product firstPurchasedProduct)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstPurchasedProduct);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.__c__DisplayClass24_0.NativeMethodInfoPtr__OnAllPurchasesRetrieved_b__0_Internal_Boolean_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000189 RID: 393 RVA: 0x00002A4B File Offset: 0x00000C4B
			public __c__DisplayClass24_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x0600018A RID: 394 RVA: 0x00008934 File Offset: 0x00006B34
			// (set) Token: 0x0600018B RID: 395 RVA: 0x00002A54 File Offset: 0x00000C54
			public unsafe Product product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.__c__DisplayClass24_0.NativeFieldInfoPtr_product);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Product>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchasingManager.__c__DisplayClass24_0.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000110 RID: 272
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x04000111 RID: 273
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000112 RID: 274
			private static readonly IntPtr NativeMethodInfoPtr__OnAllPurchasesRetrieved_b__0_Internal_Boolean_Product_0;
		}

		// Token: 0x0200002F RID: 47
		[ObfuscatedName("UnityEngine.Purchasing.PurchasingManager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600018C RID: 396 RVA: 0x00008964 File Offset: 0x00006B64
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PurchasingManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PurchasingManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PurchasingManager.__c>.NativeClassPtr);
				PurchasingManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasingManager.__c>.NativeClassPtr, "<>9");
				PurchasingManager.__c.NativeFieldInfoPtr___9__37_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchasingManager.__c>.NativeClassPtr, "<>9__37_0");
				PurchasingManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager.__c>.NativeClassPtr, 100663419);
				PurchasingManager.__c.NativeMethodInfoPtr__Initialize_b__37_0_Internal_Product_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchasingManager.__c>.NativeClassPtr, 100663420);
			}

			// Token: 0x0600018D RID: 397 RVA: 0x000089E0 File Offset: 0x00006BE0
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PurchasingManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600018E RID: 398 RVA: 0x00008A1C File Offset: 0x00006C1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130802, XrefRangeEnd = 130810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Product _Initialize_b__37_0(ProductDefinition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchasingManager.__c.NativeMethodInfoPtr__Initialize_b__37_0_Internal_Product_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Product>(intPtr3) : null;
				}
			}

			// Token: 0x0600018F RID: 399 RVA: 0x00002A73 File Offset: 0x00000C73
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x06000190 RID: 400 RVA: 0x00008A6C File Offset: 0x00006C6C
			// (set) Token: 0x06000191 RID: 401 RVA: 0x00002A7C File Offset: 0x00000C7C
			public unsafe static PurchasingManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PurchasingManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PurchasingManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PurchasingManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x06000192 RID: 402 RVA: 0x00008A94 File Offset: 0x00006C94
			// (set) Token: 0x06000193 RID: 403 RVA: 0x00002A8E File Offset: 0x00000C8E
			public unsafe static Func<ProductDefinition, Product> __9__37_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PurchasingManager.__c.NativeFieldInfoPtr___9__37_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ProductDefinition, Product>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PurchasingManager.__c.NativeFieldInfoPtr___9__37_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000113 RID: 275
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000114 RID: 276
			private static readonly IntPtr NativeFieldInfoPtr___9__37_0;

			// Token: 0x04000115 RID: 277
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000116 RID: 278
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__37_0_Internal_Product_ProductDefinition_0;
		}
	}
}

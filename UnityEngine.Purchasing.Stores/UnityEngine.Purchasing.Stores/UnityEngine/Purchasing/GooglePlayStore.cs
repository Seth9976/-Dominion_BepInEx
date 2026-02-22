using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;
using Uniject;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000021 RID: 33
	public class GooglePlayStore : AbstractStore
	{
		// Token: 0x06000119 RID: 281 RVA: 0x000097E4 File Offset: 0x000079E4
		// Note: this type is marked as 'beforefieldinit'.
		static GooglePlayStore()
		{
			Il2CppClassPointerStore<GooglePlayStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GooglePlayStore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayStore>.NativeClassPtr);
			GooglePlayStore.NativeFieldInfoPtr_m_RetrieveProductsService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStore>.NativeClassPtr, "m_RetrieveProductsService");
			GooglePlayStore.NativeFieldInfoPtr_m_StorePurchaseService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStore>.NativeClassPtr, "m_StorePurchaseService");
			GooglePlayStore.NativeFieldInfoPtr_m_FetchPurchases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStore>.NativeClassPtr, "m_FetchPurchases");
			GooglePlayStore.NativeFieldInfoPtr_m_FinishTransactionService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStore>.NativeClassPtr, "m_FinishTransactionService");
			GooglePlayStore.NativeFieldInfoPtr_m_GooglePurchaseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStore>.NativeClassPtr, "m_GooglePurchaseCallback");
			GooglePlayStore.NativeFieldInfoPtr_m_GooglePlayStoreExtensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStore>.NativeClassPtr, "m_GooglePlayStoreExtensions");
			GooglePlayStore.NativeFieldInfoPtr_m_Util = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStore>.NativeClassPtr, "m_Util");
			GooglePlayStore.NativeMethodInfoPtr__ctor_Public_Void_IGooglePlayStoreRetrieveProductsService_IGooglePlayStorePurchaseService_IGoogleFetchPurchases_IGooglePlayStoreFinishTransactionService_IGooglePurchaseCallback_IGooglePlayStoreExtensionsInternal_IUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStore>.NativeClassPtr, 100663438);
			GooglePlayStore.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IStoreCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStore>.NativeClassPtr, 100663439);
			GooglePlayStore.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Void_ReadOnlyCollection_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStore>.NativeClassPtr, 100663440);
			GooglePlayStore.NativeMethodInfoPtr_Purchase_Public_Virtual_Void_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStore>.NativeClassPtr, 100663441);
			GooglePlayStore.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Void_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStore>.NativeClassPtr, 100663442);
			GooglePlayStore.NativeMethodInfoPtr_OnPause_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStore>.NativeClassPtr, 100663443);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00009918 File Offset: 0x00007B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151440, XrefRangeEnd = 151441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GooglePlayStore(IGooglePlayStoreRetrieveProductsService retrieveProductsService, IGooglePlayStorePurchaseService storePurchaseService, IGoogleFetchPurchases fetchPurchases, IGooglePlayStoreFinishTransactionService transactionService, IGooglePurchaseCallback googlePurchaseCallback, IGooglePlayStoreExtensionsInternal googlePlayStoreExtensions, IUtil util)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayStore>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(retrieveProductsService);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(storePurchaseService);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fetchPurchases);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transactionService);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePurchaseCallback);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePlayStoreExtensions);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(util);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStore.NativeMethodInfoPtr__ctor_Public_Void_IGooglePlayStoreRetrieveProductsService_IGooglePlayStorePurchaseService_IGoogleFetchPurchases_IGooglePlayStoreFinishTransactionService_IGooglePurchaseCallback_IGooglePlayStoreExtensionsInternal_IUtil_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000099D4 File Offset: 0x00007BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151441, XrefRangeEnd = 151461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(IStoreCallback callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GooglePlayStore.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IStoreCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00009A24 File Offset: 0x00007C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151461, XrefRangeEnd = 151466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GooglePlayStore.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Void_ReadOnlyCollection_1_ProductDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00009A74 File Offset: 0x00007C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151466, XrefRangeEnd = 151470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Purchase(ProductDefinition product, string dummy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dummy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GooglePlayStore.NativeMethodInfoPtr_Purchase_Public_Virtual_Void_ProductDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00009AD4 File Offset: 0x00007CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151470, XrefRangeEnd = 151473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FinishTransaction(ProductDefinition product, string transactionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GooglePlayStore.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Void_ProductDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00009B34 File Offset: 0x00007D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151473, XrefRangeEnd = 151479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPause(bool isPaused)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isPaused;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStore.NativeMethodInfoPtr_OnPause_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002856 File Offset: 0x00000A56
		public GooglePlayStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00009B74 File Offset: 0x00007D74
		// (set) Token: 0x06000122 RID: 290 RVA: 0x0000285F File Offset: 0x00000A5F
		public unsafe IGooglePlayStoreRetrieveProductsService m_RetrieveProductsService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStore.NativeFieldInfoPtr_m_RetrieveProductsService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePlayStoreRetrieveProductsService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStore.NativeFieldInfoPtr_m_RetrieveProductsService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00009BA4 File Offset: 0x00007DA4
		// (set) Token: 0x06000124 RID: 292 RVA: 0x0000287E File Offset: 0x00000A7E
		public unsafe IGooglePlayStorePurchaseService m_StorePurchaseService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStore.NativeFieldInfoPtr_m_StorePurchaseService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePlayStorePurchaseService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStore.NativeFieldInfoPtr_m_StorePurchaseService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00009BD4 File Offset: 0x00007DD4
		// (set) Token: 0x06000126 RID: 294 RVA: 0x0000289D File Offset: 0x00000A9D
		public unsafe IGoogleFetchPurchases m_FetchPurchases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStore.NativeFieldInfoPtr_m_FetchPurchases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGoogleFetchPurchases>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStore.NativeFieldInfoPtr_m_FetchPurchases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00009C04 File Offset: 0x00007E04
		// (set) Token: 0x06000128 RID: 296 RVA: 0x000028BC File Offset: 0x00000ABC
		public unsafe IGooglePlayStoreFinishTransactionService m_FinishTransactionService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStore.NativeFieldInfoPtr_m_FinishTransactionService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePlayStoreFinishTransactionService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStore.NativeFieldInfoPtr_m_FinishTransactionService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00009C34 File Offset: 0x00007E34
		// (set) Token: 0x0600012A RID: 298 RVA: 0x000028DB File Offset: 0x00000ADB
		public unsafe IGooglePurchaseCallback m_GooglePurchaseCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStore.NativeFieldInfoPtr_m_GooglePurchaseCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePurchaseCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStore.NativeFieldInfoPtr_m_GooglePurchaseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00009C64 File Offset: 0x00007E64
		// (set) Token: 0x0600012C RID: 300 RVA: 0x000028FA File Offset: 0x00000AFA
		public unsafe IGooglePlayStoreExtensionsInternal m_GooglePlayStoreExtensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStore.NativeFieldInfoPtr_m_GooglePlayStoreExtensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePlayStoreExtensionsInternal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStore.NativeFieldInfoPtr_m_GooglePlayStoreExtensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00009C94 File Offset: 0x00007E94
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00002919 File Offset: 0x00000B19
		public unsafe IUtil m_Util
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStore.NativeFieldInfoPtr_m_Util);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUtil>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStore.NativeFieldInfoPtr_m_Util), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeFieldInfoPtr_m_RetrieveProductsService;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeFieldInfoPtr_m_StorePurchaseService;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_m_FetchPurchases;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr_m_FinishTransactionService;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr_m_GooglePurchaseCallback;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_m_GooglePlayStoreExtensions;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_m_Util;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IGooglePlayStoreRetrieveProductsService_IGooglePlayStorePurchaseService_IGoogleFetchPurchases_IGooglePlayStoreFinishTransactionService_IGooglePurchaseCallback_IGooglePlayStoreExtensionsInternal_IUtil_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IStoreCallback_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Void_ReadOnlyCollection_1_ProductDefinition_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Virtual_Void_ProductDefinition_String_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Void_ProductDefinition_String_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_OnPause_Public_Void_Boolean_0;
	}
}

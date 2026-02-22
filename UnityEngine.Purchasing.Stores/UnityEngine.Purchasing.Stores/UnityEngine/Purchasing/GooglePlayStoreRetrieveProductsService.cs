using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000030 RID: 48
	public class GooglePlayStoreRetrieveProductsService : Object
	{
		// Token: 0x060001A1 RID: 417 RVA: 0x0000B5CC File Offset: 0x000097CC
		// Note: this type is marked as 'beforefieldinit'.
		static GooglePlayStoreRetrieveProductsService()
		{
			Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GooglePlayStoreRetrieveProductsService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService>.NativeClassPtr);
			GooglePlayStoreRetrieveProductsService.NativeFieldInfoPtr_m_GooglePlayStoreService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService>.NativeClassPtr, "m_GooglePlayStoreService");
			GooglePlayStoreRetrieveProductsService.NativeFieldInfoPtr_m_GoogleFetchPurchases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService>.NativeClassPtr, "m_GoogleFetchPurchases");
			GooglePlayStoreRetrieveProductsService.NativeFieldInfoPtr_m_StoreCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService>.NativeClassPtr, "m_StoreCallback");
			GooglePlayStoreRetrieveProductsService.NativeFieldInfoPtr_m_GooglePlayConfigurationInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService>.NativeClassPtr, "m_GooglePlayConfigurationInternal");
			GooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr__ctor_Internal_Void_IGooglePlayStoreService_IGoogleFetchPurchases_IGooglePlayConfigurationInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService>.NativeClassPtr, 100663495);
			GooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr_SetStoreCallback_Public_Virtual_Final_New_Void_IStoreCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService>.NativeClassPtr, 100663496);
			GooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_ReadOnlyCollection_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService>.NativeClassPtr, 100663497);
			GooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr_ResumeConnection_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService>.NativeClassPtr, 100663498);
			GooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr_MakePurchasesIntoProducts_Private_Static_List_1_ProductDescription_List_1_ProductDescription_IEnumerable_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService>.NativeClassPtr, 100663499);
			GooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr__RetrieveProducts_b__6_0_Private_Void_List_1_ProductDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService>.NativeClassPtr, 100663500);
			GooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr__RetrieveProducts_b__6_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService>.NativeClassPtr, 100663501);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000B6D8 File Offset: 0x000098D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151686, XrefRangeEnd = 151687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GooglePlayStoreRetrieveProductsService(IGooglePlayStoreService googlePlayStoreService, IGoogleFetchPurchases googleFetchPurchases, IGooglePlayConfigurationInternal googlePlayConfigurationInternal)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePlayStoreService);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googleFetchPurchases);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePlayConfigurationInternal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr__ctor_Internal_Void_IGooglePlayStoreService_IGoogleFetchPurchases_IGooglePlayConfigurationInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000B748 File Offset: 0x00009948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStoreCallback(IStoreCallback storeCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr_SetStoreCallback_Public_Virtual_Final_New_Void_IStoreCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000B78C File Offset: 0x0000998C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151687, XrefRangeEnd = 151704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_ReadOnlyCollection_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000B7D0 File Offset: 0x000099D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151704, XrefRangeEnd = 151708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResumeConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr_ResumeConnection_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000B804 File Offset: 0x00009A04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151755, RefRangeEnd = 151756, XrefRangeStart = 151708, XrefRangeEnd = 151755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<ProductDescription> MakePurchasesIntoProducts(List<ProductDescription> retrievedProducts, IEnumerable<Product> purchaseProducts)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(retrievedProducts);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(purchaseProducts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr_MakePurchasesIntoProducts_Private_Static_List_1_ProductDescription_List_1_ProductDescription_IEnumerable_1_Product_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProductDescription>>(intPtr3) : null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000B85C File Offset: 0x00009A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151756, XrefRangeEnd = 151773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RetrieveProducts_b__6_0(List<ProductDescription> retrievedProducts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(retrievedProducts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr__RetrieveProducts_b__6_0_Private_Void_List_1_ProductDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000B8A0 File Offset: 0x00009AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151773, XrefRangeEnd = 151777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RetrieveProducts_b__6_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr__RetrieveProducts_b__6_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002C83 File Offset: 0x00000E83
		public GooglePlayStoreRetrieveProductsService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0000B8D4 File Offset: 0x00009AD4
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00002C8C File Offset: 0x00000E8C
		public unsafe IGooglePlayStoreService m_GooglePlayStoreService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreRetrieveProductsService.NativeFieldInfoPtr_m_GooglePlayStoreService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePlayStoreService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreRetrieveProductsService.NativeFieldInfoPtr_m_GooglePlayStoreService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001AC RID: 428 RVA: 0x0000B904 File Offset: 0x00009B04
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00002CAB File Offset: 0x00000EAB
		public unsafe IGoogleFetchPurchases m_GoogleFetchPurchases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreRetrieveProductsService.NativeFieldInfoPtr_m_GoogleFetchPurchases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGoogleFetchPurchases>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreRetrieveProductsService.NativeFieldInfoPtr_m_GoogleFetchPurchases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0000B934 File Offset: 0x00009B34
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00002CCA File Offset: 0x00000ECA
		public unsafe IStoreCallback m_StoreCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreRetrieveProductsService.NativeFieldInfoPtr_m_StoreCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStoreCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreRetrieveProductsService.NativeFieldInfoPtr_m_StoreCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000B964 File Offset: 0x00009B64
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002CE9 File Offset: 0x00000EE9
		public unsafe IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreRetrieveProductsService.NativeFieldInfoPtr_m_GooglePlayConfigurationInternal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePlayConfigurationInternal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreRetrieveProductsService.NativeFieldInfoPtr_m_GooglePlayConfigurationInternal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_m_GooglePlayStoreService;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr_m_GoogleFetchPurchases;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr_m_StoreCallback;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr_m_GooglePlayConfigurationInternal;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IGooglePlayStoreService_IGoogleFetchPurchases_IGooglePlayConfigurationInternal_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_SetStoreCallback_Public_Virtual_Final_New_Void_IStoreCallback_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_ReadOnlyCollection_1_ProductDefinition_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_ResumeConnection_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_MakePurchasesIntoProducts_Private_Static_List_1_ProductDescription_List_1_ProductDescription_IEnumerable_1_Product_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr__RetrieveProducts_b__6_0_Private_Void_List_1_ProductDescription_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr__RetrieveProducts_b__6_1_Private_Void_0;

		// Token: 0x020000A7 RID: 167
		[ObfuscatedName("UnityEngine.Purchasing.GooglePlayStoreRetrieveProductsService+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x0600063B RID: 1595 RVA: 0x0001A478 File Offset: 0x00018678
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService.__c__DisplayClass6_0>.NativeClassPtr);
				GooglePlayStoreRetrieveProductsService.__c__DisplayClass6_0.NativeFieldInfoPtr_retrievedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService.__c__DisplayClass6_0>.NativeClassPtr, "retrievedProducts");
				GooglePlayStoreRetrieveProductsService.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				GooglePlayStoreRetrieveProductsService.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService.__c__DisplayClass6_0>.NativeClassPtr, 100663502);
				GooglePlayStoreRetrieveProductsService.__c__DisplayClass6_0.NativeMethodInfoPtr__RetrieveProducts_b__2_Internal_Void_List_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService.__c__DisplayClass6_0>.NativeClassPtr, 100663503);
			}

			// Token: 0x0600063C RID: 1596 RVA: 0x0001A4F4 File Offset: 0x000186F4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreRetrieveProductsService.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600063D RID: 1597 RVA: 0x0001A530 File Offset: 0x00018730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151679, XrefRangeEnd = 151684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RetrieveProducts_b__2(List<Product> purchaseProducts)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchaseProducts);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreRetrieveProductsService.__c__DisplayClass6_0.NativeMethodInfoPtr__RetrieveProducts_b__2_Internal_Void_List_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600063E RID: 1598 RVA: 0x00005240 File Offset: 0x00003440
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000192 RID: 402
			// (get) Token: 0x0600063F RID: 1599 RVA: 0x0001A574 File Offset: 0x00018774
			// (set) Token: 0x06000640 RID: 1600 RVA: 0x00005249 File Offset: 0x00003449
			public unsafe List<ProductDescription> retrievedProducts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreRetrieveProductsService.__c__DisplayClass6_0.NativeFieldInfoPtr_retrievedProducts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductDescription>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreRetrieveProductsService.__c__DisplayClass6_0.NativeFieldInfoPtr_retrievedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000193 RID: 403
			// (get) Token: 0x06000641 RID: 1601 RVA: 0x0001A5A4 File Offset: 0x000187A4
			// (set) Token: 0x06000642 RID: 1602 RVA: 0x00005268 File Offset: 0x00003468
			public unsafe GooglePlayStoreRetrieveProductsService __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreRetrieveProductsService.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GooglePlayStoreRetrieveProductsService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreRetrieveProductsService.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400041F RID: 1055
			private static readonly IntPtr NativeFieldInfoPtr_retrievedProducts;

			// Token: 0x04000420 RID: 1056
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000421 RID: 1057
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000422 RID: 1058
			private static readonly IntPtr NativeMethodInfoPtr__RetrieveProducts_b__2_Internal_Void_List_1_Product_0;
		}

		// Token: 0x020000A8 RID: 168
		[ObfuscatedName("UnityEngine.Purchasing.GooglePlayStoreRetrieveProductsService+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06000643 RID: 1603 RVA: 0x0001A5D4 File Offset: 0x000187D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService.__c__DisplayClass8_0>.NativeClassPtr);
				GooglePlayStoreRetrieveProductsService.__c__DisplayClass8_0.NativeFieldInfoPtr_purchaseProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService.__c__DisplayClass8_0>.NativeClassPtr, "purchaseProduct");
				GooglePlayStoreRetrieveProductsService.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService.__c__DisplayClass8_0>.NativeClassPtr, 100663504);
				GooglePlayStoreRetrieveProductsService.__c__DisplayClass8_0.NativeMethodInfoPtr__MakePurchasesIntoProducts_b__0_Internal_Boolean_ProductDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService.__c__DisplayClass8_0>.NativeClassPtr, 100663505);
			}

			// Token: 0x06000644 RID: 1604 RVA: 0x0001A63C File Offset: 0x0001883C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayStoreRetrieveProductsService.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreRetrieveProductsService.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000645 RID: 1605 RVA: 0x0001A678 File Offset: 0x00018878
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151684, XrefRangeEnd = 151686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MakePurchasesIntoProducts_b__0(ProductDescription product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreRetrieveProductsService.__c__DisplayClass8_0.NativeMethodInfoPtr__MakePurchasesIntoProducts_b__0_Internal_Boolean_ProductDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000646 RID: 1606 RVA: 0x00005287 File Offset: 0x00003487
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000194 RID: 404
			// (get) Token: 0x06000647 RID: 1607 RVA: 0x0001A6C8 File Offset: 0x000188C8
			// (set) Token: 0x06000648 RID: 1608 RVA: 0x00005290 File Offset: 0x00003490
			public unsafe Product purchaseProduct
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreRetrieveProductsService.__c__DisplayClass8_0.NativeFieldInfoPtr_purchaseProduct);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Product>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreRetrieveProductsService.__c__DisplayClass8_0.NativeFieldInfoPtr_purchaseProduct), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000423 RID: 1059
			private static readonly IntPtr NativeFieldInfoPtr_purchaseProduct;

			// Token: 0x04000424 RID: 1060
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000425 RID: 1061
			private static readonly IntPtr NativeMethodInfoPtr__MakePurchasesIntoProducts_b__0_Internal_Boolean_ProductDescription_0;
		}
	}
}

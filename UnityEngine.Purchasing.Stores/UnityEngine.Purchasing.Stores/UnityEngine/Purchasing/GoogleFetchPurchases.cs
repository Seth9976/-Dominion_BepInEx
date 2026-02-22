using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200002D RID: 45
	public class GoogleFetchPurchases : Object
	{
		// Token: 0x0600017D RID: 381 RVA: 0x0000ACF0 File Offset: 0x00008EF0
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleFetchPurchases()
		{
			Il2CppClassPointerStore<GoogleFetchPurchases>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GoogleFetchPurchases");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleFetchPurchases>.NativeClassPtr);
			GoogleFetchPurchases.NativeFieldInfoPtr_m_GooglePlayStoreService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFetchPurchases>.NativeClassPtr, "m_GooglePlayStoreService");
			GoogleFetchPurchases.NativeFieldInfoPtr_m_TransactionService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFetchPurchases>.NativeClassPtr, "m_TransactionService");
			GoogleFetchPurchases.NativeFieldInfoPtr_m_StoreCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFetchPurchases>.NativeClassPtr, "m_StoreCallback");
			GoogleFetchPurchases.NativeMethodInfoPtr__ctor_Internal_Void_IGooglePlayStoreService_IGooglePlayStoreFinishTransactionService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFetchPurchases>.NativeClassPtr, 100663474);
			GoogleFetchPurchases.NativeMethodInfoPtr_SetStoreCallback_Public_Virtual_Final_New_Void_IStoreCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFetchPurchases>.NativeClassPtr, 100663475);
			GoogleFetchPurchases.NativeMethodInfoPtr_FetchPurchases_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFetchPurchases>.NativeClassPtr, 100663476);
			GoogleFetchPurchases.NativeMethodInfoPtr_FetchPurchases_Public_Virtual_Final_New_Void_Action_1_List_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFetchPurchases>.NativeClassPtr, 100663477);
			GoogleFetchPurchases.NativeMethodInfoPtr_FillProductsWithPurchases_Private_List_1_Product_IEnumerable_1_GooglePurchase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFetchPurchases>.NativeClassPtr, 100663478);
			GoogleFetchPurchases.NativeMethodInfoPtr_OnFetchedPurchase_Private_Void_List_1_GooglePurchase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFetchPurchases>.NativeClassPtr, 100663479);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000ADD4 File Offset: 0x00008FD4
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleFetchPurchases(IGooglePlayStoreService googlePlayStoreService, IGooglePlayStoreFinishTransactionService transactionService)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleFetchPurchases>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePlayStoreService);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transactionService);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFetchPurchases.NativeMethodInfoPtr__ctor_Internal_Void_IGooglePlayStoreService_IGooglePlayStoreFinishTransactionService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000AE34 File Offset: 0x00009034
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFetchPurchases.NativeMethodInfoPtr_SetStoreCallback_Public_Virtual_Final_New_Void_IStoreCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000AE78 File Offset: 0x00009078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151545, XrefRangeEnd = 151557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FetchPurchases()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFetchPurchases.NativeMethodInfoPtr_FetchPurchases_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000AEAC File Offset: 0x000090AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151557, XrefRangeEnd = 151573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FetchPurchases(Action<List<Product>> onQueryPurchaseSucceed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onQueryPurchaseSucceed);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFetchPurchases.NativeMethodInfoPtr_FetchPurchases_Public_Virtual_Final_New_Void_Action_1_List_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000AEF0 File Offset: 0x000090F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151622, RefRangeEnd = 151624, XrefRangeStart = 151573, XrefRangeEnd = 151622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Product> FillProductsWithPurchases(IEnumerable<GooglePurchase> purchases)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchases);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFetchPurchases.NativeMethodInfoPtr_FillProductsWithPurchases_Private_List_1_Product_IEnumerable_1_GooglePurchase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Product>>(intPtr3) : null;
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000AF40 File Offset: 0x00009140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151624, XrefRangeEnd = 151629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFetchedPurchase(List<GooglePurchase> purchases)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchases);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFetchPurchases.NativeMethodInfoPtr_OnFetchedPurchase_Private_Void_List_1_GooglePurchase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002B8F File Offset: 0x00000D8F
		public GoogleFetchPurchases(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000AF84 File Offset: 0x00009184
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002B98 File Offset: 0x00000D98
		public unsafe IGooglePlayStoreService m_GooglePlayStoreService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFetchPurchases.NativeFieldInfoPtr_m_GooglePlayStoreService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePlayStoreService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFetchPurchases.NativeFieldInfoPtr_m_GooglePlayStoreService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000AFB4 File Offset: 0x000091B4
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00002BB7 File Offset: 0x00000DB7
		public unsafe IGooglePlayStoreFinishTransactionService m_TransactionService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFetchPurchases.NativeFieldInfoPtr_m_TransactionService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePlayStoreFinishTransactionService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFetchPurchases.NativeFieldInfoPtr_m_TransactionService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000AFE4 File Offset: 0x000091E4
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00002BD6 File Offset: 0x00000DD6
		public unsafe IStoreCallback m_StoreCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFetchPurchases.NativeFieldInfoPtr_m_StoreCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStoreCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFetchPurchases.NativeFieldInfoPtr_m_StoreCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr_m_GooglePlayStoreService;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeFieldInfoPtr_m_TransactionService;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeFieldInfoPtr_m_StoreCallback;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IGooglePlayStoreService_IGooglePlayStoreFinishTransactionService_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_SetStoreCallback_Public_Virtual_Final_New_Void_IStoreCallback_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_FetchPurchases_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_FetchPurchases_Public_Virtual_Final_New_Void_Action_1_List_1_Product_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_FillProductsWithPurchases_Private_List_1_Product_IEnumerable_1_GooglePurchase_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_OnFetchedPurchase_Private_Void_List_1_GooglePurchase_0;

		// Token: 0x020000A5 RID: 165
		[ObfuscatedName("UnityEngine.Purchasing.GoogleFetchPurchases+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x0600062B RID: 1579 RVA: 0x0001A1C4 File Offset: 0x000183C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<GoogleFetchPurchases.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleFetchPurchases>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleFetchPurchases.__c__DisplayClass6_0>.NativeClassPtr);
				GoogleFetchPurchases.__c__DisplayClass6_0.NativeFieldInfoPtr_onQueryPurchaseSucceed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFetchPurchases.__c__DisplayClass6_0>.NativeClassPtr, "onQueryPurchaseSucceed");
				GoogleFetchPurchases.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFetchPurchases.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				GoogleFetchPurchases.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFetchPurchases.__c__DisplayClass6_0>.NativeClassPtr, 100663480);
				GoogleFetchPurchases.__c__DisplayClass6_0.NativeMethodInfoPtr__FetchPurchases_b__0_Internal_Void_List_1_GooglePurchase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFetchPurchases.__c__DisplayClass6_0>.NativeClassPtr, 100663481);
			}

			// Token: 0x0600062C RID: 1580 RVA: 0x0001A240 File Offset: 0x00018440
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleFetchPurchases.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFetchPurchases.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600062D RID: 1581 RVA: 0x0001A27C File Offset: 0x0001847C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151535, XrefRangeEnd = 151545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _FetchPurchases_b__0(List<GooglePurchase> googlePurchases)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePurchases);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFetchPurchases.__c__DisplayClass6_0.NativeMethodInfoPtr__FetchPurchases_b__0_Internal_Void_List_1_GooglePurchase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600062E RID: 1582 RVA: 0x000051CC File Offset: 0x000033CC
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700018E RID: 398
			// (get) Token: 0x0600062F RID: 1583 RVA: 0x0001A2C0 File Offset: 0x000184C0
			// (set) Token: 0x06000630 RID: 1584 RVA: 0x000051D5 File Offset: 0x000033D5
			public unsafe Action<List<Product>> onQueryPurchaseSucceed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFetchPurchases.__c__DisplayClass6_0.NativeFieldInfoPtr_onQueryPurchaseSucceed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<List<Product>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFetchPurchases.__c__DisplayClass6_0.NativeFieldInfoPtr_onQueryPurchaseSucceed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700018F RID: 399
			// (get) Token: 0x06000631 RID: 1585 RVA: 0x0001A2F0 File Offset: 0x000184F0
			// (set) Token: 0x06000632 RID: 1586 RVA: 0x000051F4 File Offset: 0x000033F4
			public unsafe GoogleFetchPurchases __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFetchPurchases.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleFetchPurchases>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFetchPurchases.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000417 RID: 1047
			private static readonly IntPtr NativeFieldInfoPtr_onQueryPurchaseSucceed;

			// Token: 0x04000418 RID: 1048
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000419 RID: 1049
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400041A RID: 1050
			private static readonly IntPtr NativeMethodInfoPtr__FetchPurchases_b__0_Internal_Void_List_1_GooglePurchase_0;
		}

		// Token: 0x020000A6 RID: 166
		[ObfuscatedName("UnityEngine.Purchasing.GoogleFetchPurchases+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000633 RID: 1587 RVA: 0x0001A320 File Offset: 0x00018520
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GoogleFetchPurchases.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleFetchPurchases>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleFetchPurchases.__c>.NativeClassPtr);
				GoogleFetchPurchases.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFetchPurchases.__c>.NativeClassPtr, "<>9");
				GoogleFetchPurchases.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFetchPurchases.__c>.NativeClassPtr, "<>9__7_0");
				GoogleFetchPurchases.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFetchPurchases.__c>.NativeClassPtr, 100663483);
				GoogleFetchPurchases.__c.NativeMethodInfoPtr__FillProductsWithPurchases_b__7_0_Internal_Boolean_GooglePurchase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFetchPurchases.__c>.NativeClassPtr, 100663484);
			}

			// Token: 0x06000634 RID: 1588 RVA: 0x0001A39C File Offset: 0x0001859C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleFetchPurchases.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFetchPurchases.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000635 RID: 1589 RVA: 0x0001A3D8 File Offset: 0x000185D8
			[CallerCount(0)]
			public unsafe bool _FillProductsWithPurchases_b__7_0(GooglePurchase purchase)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchase);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFetchPurchases.__c.NativeMethodInfoPtr__FillProductsWithPurchases_b__7_0_Internal_Boolean_GooglePurchase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000636 RID: 1590 RVA: 0x00005213 File Offset: 0x00003413
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000190 RID: 400
			// (get) Token: 0x06000637 RID: 1591 RVA: 0x0001A428 File Offset: 0x00018628
			// (set) Token: 0x06000638 RID: 1592 RVA: 0x0000521C File Offset: 0x0000341C
			public unsafe static GoogleFetchPurchases.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GoogleFetchPurchases.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleFetchPurchases.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GoogleFetchPurchases.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000191 RID: 401
			// (get) Token: 0x06000639 RID: 1593 RVA: 0x0001A450 File Offset: 0x00018650
			// (set) Token: 0x0600063A RID: 1594 RVA: 0x0000522E File Offset: 0x0000342E
			public unsafe static Func<GooglePurchase, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GoogleFetchPurchases.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GooglePurchase, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GoogleFetchPurchases.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400041B RID: 1051
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400041C RID: 1052
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x0400041D RID: 1053
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400041E RID: 1054
			private static readonly IntPtr NativeMethodInfoPtr__FillProductsWithPurchases_b__7_0_Internal_Boolean_GooglePurchase_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000C RID: 12
	public class GoogleFinishTransactionService : Object
	{
		// Token: 0x06000039 RID: 57 RVA: 0x000067E0 File Offset: 0x000049E0
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleFinishTransactionService()
		{
			Il2CppClassPointerStore<GoogleFinishTransactionService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GoogleFinishTransactionService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleFinishTransactionService>.NativeClassPtr);
			GoogleFinishTransactionService.NativeFieldInfoPtr_m_BillingClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFinishTransactionService>.NativeClassPtr, "m_BillingClient");
			GoogleFinishTransactionService.NativeFieldInfoPtr_m_GoogleQueryPurchasesService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFinishTransactionService>.NativeClassPtr, "m_GoogleQueryPurchasesService");
			GoogleFinishTransactionService.NativeMethodInfoPtr__ctor_Internal_Void_IGoogleBillingClient_IGoogleQueryPurchasesService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFinishTransactionService>.NativeClassPtr, 100663333);
			GoogleFinishTransactionService.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_ProductDefinition_String_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFinishTransactionService>.NativeClassPtr, 100663334);
			GoogleFinishTransactionService.NativeMethodInfoPtr_PurchaseNeedsAcknowledgement_Private_Static_Func_2_GooglePurchase_Boolean_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFinishTransactionService>.NativeClassPtr, 100663335);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00006874 File Offset: 0x00004A74
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleFinishTransactionService(IGoogleBillingClient billingClient, IGoogleQueryPurchasesService googleQueryPurchasesService)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleFinishTransactionService>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingClient);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googleQueryPurchasesService);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFinishTransactionService.NativeMethodInfoPtr__ctor_Internal_Void_IGoogleBillingClient_IGoogleQueryPurchasesService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000068D4 File Offset: 0x00004AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150388, XrefRangeEnd = 150404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFinishTransactionService.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_ProductDefinition_String_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00006950 File Offset: 0x00004B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150404, XrefRangeEnd = 150416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<GooglePurchase, bool> PurchaseNeedsAcknowledgement(ProductDefinition product)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFinishTransactionService.NativeMethodInfoPtr_PurchaseNeedsAcknowledgement_Private_Static_Func_2_GooglePurchase_Boolean_ProductDefinition_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<GooglePurchase, bool>>(intPtr3) : null;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000216D File Offset: 0x0000036D
		public GoogleFinishTransactionService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00006994 File Offset: 0x00004B94
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002176 File Offset: 0x00000376
		public unsafe IGoogleBillingClient m_BillingClient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFinishTransactionService.NativeFieldInfoPtr_m_BillingClient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGoogleBillingClient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFinishTransactionService.NativeFieldInfoPtr_m_BillingClient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000069C4 File Offset: 0x00004BC4
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002195 File Offset: 0x00000395
		public unsafe IGoogleQueryPurchasesService m_GoogleQueryPurchasesService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFinishTransactionService.NativeFieldInfoPtr_m_GoogleQueryPurchasesService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGoogleQueryPurchasesService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFinishTransactionService.NativeFieldInfoPtr_m_GoogleQueryPurchasesService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_m_BillingClient;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_m_GoogleQueryPurchasesService;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IGoogleBillingClient_IGoogleQueryPurchasesService_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_ProductDefinition_String_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_PurchaseNeedsAcknowledgement_Private_Static_Func_2_GooglePurchase_Boolean_ProductDefinition_0;

		// Token: 0x0200009D RID: 157
		[ObfuscatedName("UnityEngine.Purchasing.GoogleFinishTransactionService+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x060005DC RID: 1500 RVA: 0x00019440 File Offset: 0x00017640
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<GoogleFinishTransactionService.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleFinishTransactionService>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleFinishTransactionService.__c__DisplayClass3_0>.NativeClassPtr);
				GoogleFinishTransactionService.__c__DisplayClass3_0.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFinishTransactionService.__c__DisplayClass3_0>.NativeClassPtr, "product");
				GoogleFinishTransactionService.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFinishTransactionService.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
				GoogleFinishTransactionService.__c__DisplayClass3_0.NativeFieldInfoPtr_purchaseToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFinishTransactionService.__c__DisplayClass3_0>.NativeClassPtr, "purchaseToken");
				GoogleFinishTransactionService.__c__DisplayClass3_0.NativeFieldInfoPtr_onConsume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFinishTransactionService.__c__DisplayClass3_0>.NativeClassPtr, "onConsume");
				GoogleFinishTransactionService.__c__DisplayClass3_0.NativeFieldInfoPtr_onAcknowledge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFinishTransactionService.__c__DisplayClass3_0>.NativeClassPtr, "onAcknowledge");
				GoogleFinishTransactionService.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFinishTransactionService.__c__DisplayClass3_0>.NativeClassPtr, 100663336);
				GoogleFinishTransactionService.__c__DisplayClass3_0.NativeMethodInfoPtr__FinishTransaction_b__0_Internal_Void_List_1_GooglePurchase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFinishTransactionService.__c__DisplayClass3_0>.NativeClassPtr, 100663337);
			}

			// Token: 0x060005DD RID: 1501 RVA: 0x000194F8 File Offset: 0x000176F8
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleFinishTransactionService.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFinishTransactionService.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005DE RID: 1502 RVA: 0x00019534 File Offset: 0x00017734
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150351, XrefRangeEnd = 150387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _FinishTransaction_b__0(List<GooglePurchase> purchases)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchases);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFinishTransactionService.__c__DisplayClass3_0.NativeMethodInfoPtr__FinishTransaction_b__0_Internal_Void_List_1_GooglePurchase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005DF RID: 1503 RVA: 0x00004F1F File Offset: 0x0000311F
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000178 RID: 376
			// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00019578 File Offset: 0x00017778
			// (set) Token: 0x060005E1 RID: 1505 RVA: 0x00004F28 File Offset: 0x00003128
			public unsafe ProductDefinition product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFinishTransactionService.__c__DisplayClass3_0.NativeFieldInfoPtr_product);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFinishTransactionService.__c__DisplayClass3_0.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000179 RID: 377
			// (get) Token: 0x060005E2 RID: 1506 RVA: 0x000195A8 File Offset: 0x000177A8
			// (set) Token: 0x060005E3 RID: 1507 RVA: 0x00004F47 File Offset: 0x00003147
			public unsafe GoogleFinishTransactionService __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFinishTransactionService.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleFinishTransactionService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFinishTransactionService.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700017A RID: 378
			// (get) Token: 0x060005E4 RID: 1508 RVA: 0x000195D8 File Offset: 0x000177D8
			// (set) Token: 0x060005E5 RID: 1509 RVA: 0x00004F66 File Offset: 0x00003166
			public unsafe string purchaseToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFinishTransactionService.__c__DisplayClass3_0.NativeFieldInfoPtr_purchaseToken);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFinishTransactionService.__c__DisplayClass3_0.NativeFieldInfoPtr_purchaseToken), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700017B RID: 379
			// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00019600 File Offset: 0x00017800
			// (set) Token: 0x060005E7 RID: 1511 RVA: 0x00004F85 File Offset: 0x00003185
			public unsafe Action<ProductDefinition, GooglePurchase, GoogleBillingResult, string> onConsume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFinishTransactionService.__c__DisplayClass3_0.NativeFieldInfoPtr_onConsume);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ProductDefinition, GooglePurchase, GoogleBillingResult, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFinishTransactionService.__c__DisplayClass3_0.NativeFieldInfoPtr_onConsume), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700017C RID: 380
			// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00019630 File Offset: 0x00017830
			// (set) Token: 0x060005E9 RID: 1513 RVA: 0x00004FA4 File Offset: 0x000031A4
			public unsafe Action<ProductDefinition, GooglePurchase, GoogleBillingResult> onAcknowledge
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFinishTransactionService.__c__DisplayClass3_0.NativeFieldInfoPtr_onAcknowledge);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ProductDefinition, GooglePurchase, GoogleBillingResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFinishTransactionService.__c__DisplayClass3_0.NativeFieldInfoPtr_onAcknowledge), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040003EE RID: 1006
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x040003EF RID: 1007
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040003F0 RID: 1008
			private static readonly IntPtr NativeFieldInfoPtr_purchaseToken;

			// Token: 0x040003F1 RID: 1009
			private static readonly IntPtr NativeFieldInfoPtr_onConsume;

			// Token: 0x040003F2 RID: 1010
			private static readonly IntPtr NativeFieldInfoPtr_onAcknowledge;

			// Token: 0x040003F3 RID: 1011
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040003F4 RID: 1012
			private static readonly IntPtr NativeMethodInfoPtr__FinishTransaction_b__0_Internal_Void_List_1_GooglePurchase_0;
		}

		// Token: 0x0200009E RID: 158
		[ObfuscatedName("UnityEngine.Purchasing.GoogleFinishTransactionService+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x060005EA RID: 1514 RVA: 0x00019660 File Offset: 0x00017860
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<GoogleFinishTransactionService.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleFinishTransactionService>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleFinishTransactionService.__c__DisplayClass4_0>.NativeClassPtr);
				GoogleFinishTransactionService.__c__DisplayClass4_0.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleFinishTransactionService.__c__DisplayClass4_0>.NativeClassPtr, "product");
				GoogleFinishTransactionService.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFinishTransactionService.__c__DisplayClass4_0>.NativeClassPtr, 100663338);
				GoogleFinishTransactionService.__c__DisplayClass4_0.NativeMethodInfoPtr__PurchaseNeedsAcknowledgement_b__0_Internal_Boolean_GooglePurchase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleFinishTransactionService.__c__DisplayClass4_0>.NativeClassPtr, 100663339);
			}

			// Token: 0x060005EB RID: 1515 RVA: 0x000196C8 File Offset: 0x000178C8
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleFinishTransactionService.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFinishTransactionService.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005EC RID: 1516 RVA: 0x00019704 File Offset: 0x00017904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150387, XrefRangeEnd = 150388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PurchaseNeedsAcknowledgement_b__0(GooglePurchase purchase)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchase);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleFinishTransactionService.__c__DisplayClass4_0.NativeMethodInfoPtr__PurchaseNeedsAcknowledgement_b__0_Internal_Boolean_GooglePurchase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060005ED RID: 1517 RVA: 0x00004FC3 File Offset: 0x000031C3
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700017D RID: 381
			// (get) Token: 0x060005EE RID: 1518 RVA: 0x00019754 File Offset: 0x00017954
			// (set) Token: 0x060005EF RID: 1519 RVA: 0x00004FCC File Offset: 0x000031CC
			public unsafe ProductDefinition product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFinishTransactionService.__c__DisplayClass4_0.NativeFieldInfoPtr_product);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleFinishTransactionService.__c__DisplayClass4_0.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040003F5 RID: 1013
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x040003F6 RID: 1014
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040003F7 RID: 1015
			private static readonly IntPtr NativeMethodInfoPtr__PurchaseNeedsAcknowledgement_b__0_Internal_Boolean_GooglePurchase_0;
		}
	}
}

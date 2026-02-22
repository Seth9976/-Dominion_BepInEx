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
	// Token: 0x02000011 RID: 17
	public class GooglePurchaseService : Object
	{
		// Token: 0x06000083 RID: 131 RVA: 0x00007674 File Offset: 0x00005874
		// Note: this type is marked as 'beforefieldinit'.
		static GooglePurchaseService()
		{
			Il2CppClassPointerStore<GooglePurchaseService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GooglePurchaseService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePurchaseService>.NativeClassPtr);
			GooglePurchaseService.NativeFieldInfoPtr_m_BillingClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseService>.NativeClassPtr, "m_BillingClient");
			GooglePurchaseService.NativeFieldInfoPtr_m_GooglePurchaseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseService>.NativeClassPtr, "m_GooglePurchaseCallback");
			GooglePurchaseService.NativeFieldInfoPtr_m_QuerySkuDetailsService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseService>.NativeClassPtr, "m_QuerySkuDetailsService");
			GooglePurchaseService.NativeMethodInfoPtr__ctor_Internal_Void_IGoogleBillingClient_IGooglePurchaseCallback_IQuerySkuDetailsService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseService>.NativeClassPtr, 100663360);
			GooglePurchaseService.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_ProductDefinition_Product_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseService>.NativeClassPtr, 100663361);
			GooglePurchaseService.NativeMethodInfoPtr_OnQuerySkuDetailsResponse_Private_Void_List_1_AndroidJavaObject_ProductDefinition_Product_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseService>.NativeClassPtr, 100663362);
			GooglePurchaseService.NativeMethodInfoPtr_VerifyAndWarnIfMoreThanOneSku_Private_Static_Void_List_1_AndroidJavaObject_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseService>.NativeClassPtr, 100663363);
			GooglePurchaseService.NativeMethodInfoPtr_HandleBillingFlowResult_Private_Void_GoogleBillingResult_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseService>.NativeClassPtr, 100663364);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00007744 File Offset: 0x00005944
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150611, RefRangeEnd = 150613, XrefRangeStart = 150610, XrefRangeEnd = 150611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GooglePurchaseService(IGoogleBillingClient billingClient, IGooglePurchaseCallback googlePurchaseCallback, IQuerySkuDetailsService querySkuDetailsService)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePurchaseService>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingClient);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePurchaseCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(querySkuDetailsService);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseService.NativeMethodInfoPtr__ctor_Internal_Void_IGoogleBillingClient_IGooglePurchaseCallback_IQuerySkuDetailsService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000077B4 File Offset: 0x000059B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150613, XrefRangeEnd = 150630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseService.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_ProductDefinition_Product_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00007818 File Offset: 0x00005A18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150679, RefRangeEnd = 150680, XrefRangeStart = 150630, XrefRangeEnd = 150679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnQuerySkuDetailsResponse(List<AndroidJavaObject> skus, ProductDefinition productToBuy, Product oldProduct, int desiredProrationMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(skus);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productToBuy);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldProduct);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desiredProrationMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseService.NativeMethodInfoPtr_OnQuerySkuDetailsResponse_Private_Void_List_1_AndroidJavaObject_ProductDefinition_Product_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000788C File Offset: 0x00005A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150680, XrefRangeEnd = 150698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void VerifyAndWarnIfMoreThanOneSku(List<AndroidJavaObject> skus, AndroidJavaObject sku)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(skus);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sku);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseService.NativeMethodInfoPtr_VerifyAndWarnIfMoreThanOneSku_Private_Static_Void_List_1_AndroidJavaObject_AndroidJavaObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000078D4 File Offset: 0x00005AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150698, XrefRangeEnd = 150714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleBillingFlowResult(GoogleBillingResult billingResult, AndroidJavaObject sku)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingResult);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sku);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseService.NativeMethodInfoPtr_HandleBillingFlowResult_Private_Void_GoogleBillingResult_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000023D9 File Offset: 0x000005D9
		public GooglePurchaseService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00007928 File Offset: 0x00005B28
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000023E2 File Offset: 0x000005E2
		public unsafe IGoogleBillingClient m_BillingClient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseService.NativeFieldInfoPtr_m_BillingClient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGoogleBillingClient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseService.NativeFieldInfoPtr_m_BillingClient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00007958 File Offset: 0x00005B58
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00002401 File Offset: 0x00000601
		public unsafe IGooglePurchaseCallback m_GooglePurchaseCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseService.NativeFieldInfoPtr_m_GooglePurchaseCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePurchaseCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseService.NativeFieldInfoPtr_m_GooglePurchaseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00007988 File Offset: 0x00005B88
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00002420 File Offset: 0x00000620
		public unsafe IQuerySkuDetailsService m_QuerySkuDetailsService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseService.NativeFieldInfoPtr_m_QuerySkuDetailsService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IQuerySkuDetailsService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseService.NativeFieldInfoPtr_m_QuerySkuDetailsService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_m_BillingClient;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_m_GooglePurchaseCallback;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_m_QuerySkuDetailsService;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IGoogleBillingClient_IGooglePurchaseCallback_IQuerySkuDetailsService_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_ProductDefinition_Product_Int32_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_OnQuerySkuDetailsResponse_Private_Void_List_1_AndroidJavaObject_ProductDefinition_Product_Int32_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_VerifyAndWarnIfMoreThanOneSku_Private_Static_Void_List_1_AndroidJavaObject_AndroidJavaObject_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_HandleBillingFlowResult_Private_Void_GoogleBillingResult_AndroidJavaObject_0;

		// Token: 0x0200009F RID: 159
		[ObfuscatedName("UnityEngine.Purchasing.GooglePurchaseService+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x060005F0 RID: 1520 RVA: 0x00019784 File Offset: 0x00017984
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<GooglePurchaseService.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GooglePurchaseService>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePurchaseService.__c__DisplayClass4_0>.NativeClassPtr);
				GooglePurchaseService.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseService.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
				GooglePurchaseService.__c__DisplayClass4_0.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseService.__c__DisplayClass4_0>.NativeClassPtr, "product");
				GooglePurchaseService.__c__DisplayClass4_0.NativeFieldInfoPtr_oldProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseService.__c__DisplayClass4_0>.NativeClassPtr, "oldProduct");
				GooglePurchaseService.__c__DisplayClass4_0.NativeFieldInfoPtr_desiredProrationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseService.__c__DisplayClass4_0>.NativeClassPtr, "desiredProrationMode");
				GooglePurchaseService.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseService.__c__DisplayClass4_0>.NativeClassPtr, 100663365);
				GooglePurchaseService.__c__DisplayClass4_0.NativeMethodInfoPtr__Purchase_b__0_Internal_Void_List_1_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseService.__c__DisplayClass4_0>.NativeClassPtr, 100663366);
			}

			// Token: 0x060005F1 RID: 1521 RVA: 0x00019828 File Offset: 0x00017A28
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePurchaseService.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseService.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005F2 RID: 1522 RVA: 0x00019864 File Offset: 0x00017A64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150609, XrefRangeEnd = 150610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Purchase_b__0(List<AndroidJavaObject> skus)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(skus);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseService.__c__DisplayClass4_0.NativeMethodInfoPtr__Purchase_b__0_Internal_Void_List_1_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005F3 RID: 1523 RVA: 0x00004FEB File Offset: 0x000031EB
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700017E RID: 382
			// (get) Token: 0x060005F4 RID: 1524 RVA: 0x000198A8 File Offset: 0x00017AA8
			// (set) Token: 0x060005F5 RID: 1525 RVA: 0x00004FF4 File Offset: 0x000031F4
			public unsafe GooglePurchaseService __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseService.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GooglePurchaseService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseService.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700017F RID: 383
			// (get) Token: 0x060005F6 RID: 1526 RVA: 0x000198D8 File Offset: 0x00017AD8
			// (set) Token: 0x060005F7 RID: 1527 RVA: 0x00005013 File Offset: 0x00003213
			public unsafe ProductDefinition product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseService.__c__DisplayClass4_0.NativeFieldInfoPtr_product);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseService.__c__DisplayClass4_0.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000180 RID: 384
			// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00019908 File Offset: 0x00017B08
			// (set) Token: 0x060005F9 RID: 1529 RVA: 0x00005032 File Offset: 0x00003232
			public unsafe Product oldProduct
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseService.__c__DisplayClass4_0.NativeFieldInfoPtr_oldProduct);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Product>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseService.__c__DisplayClass4_0.NativeFieldInfoPtr_oldProduct), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000181 RID: 385
			// (get) Token: 0x060005FA RID: 1530 RVA: 0x00019938 File Offset: 0x00017B38
			// (set) Token: 0x060005FB RID: 1531 RVA: 0x00005051 File Offset: 0x00003251
			public unsafe int desiredProrationMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseService.__c__DisplayClass4_0.NativeFieldInfoPtr_desiredProrationMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseService.__c__DisplayClass4_0.NativeFieldInfoPtr_desiredProrationMode)) = value;
				}
			}

			// Token: 0x040003F8 RID: 1016
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040003F9 RID: 1017
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x040003FA RID: 1018
			private static readonly IntPtr NativeFieldInfoPtr_oldProduct;

			// Token: 0x040003FB RID: 1019
			private static readonly IntPtr NativeFieldInfoPtr_desiredProrationMode;

			// Token: 0x040003FC RID: 1020
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040003FD RID: 1021
			private static readonly IntPtr NativeMethodInfoPtr__Purchase_b__0_Internal_Void_List_1_AndroidJavaObject_0;
		}
	}
}

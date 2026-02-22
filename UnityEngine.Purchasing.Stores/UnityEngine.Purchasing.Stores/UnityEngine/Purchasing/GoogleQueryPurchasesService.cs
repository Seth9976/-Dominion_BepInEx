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
	// Token: 0x02000012 RID: 18
	public class GoogleQueryPurchasesService : Object
	{
		// Token: 0x06000090 RID: 144 RVA: 0x000079B8 File Offset: 0x00005BB8
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleQueryPurchasesService()
		{
			Il2CppClassPointerStore<GoogleQueryPurchasesService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GoogleQueryPurchasesService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleQueryPurchasesService>.NativeClassPtr);
			GoogleQueryPurchasesService.NativeFieldInfoPtr_m_BillingClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleQueryPurchasesService>.NativeClassPtr, "m_BillingClient");
			GoogleQueryPurchasesService.NativeFieldInfoPtr_m_CachedQuerySkuDetailsService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleQueryPurchasesService>.NativeClassPtr, "m_CachedQuerySkuDetailsService");
			GoogleQueryPurchasesService.NativeMethodInfoPtr__ctor_Internal_Void_IGoogleBillingClient_IGoogleCachedQuerySkuDetailsService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleQueryPurchasesService>.NativeClassPtr, 100663367);
			GoogleQueryPurchasesService.NativeMethodInfoPtr_QueryPurchases_Public_Virtual_Final_New_Void_Action_1_List_1_GooglePurchase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleQueryPurchasesService>.NativeClassPtr, 100663368);
			GoogleQueryPurchasesService.NativeMethodInfoPtr_HandleOnQueryPurchaseReceived_Private_Static_Void_Action_1_List_1_GooglePurchase_List_1_GooglePurchase_List_1_GooglePurchase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleQueryPurchasesService>.NativeClassPtr, 100663369);
			GoogleQueryPurchasesService.NativeMethodInfoPtr_QueryPurchasesWithSkuType_Private_GooglePurchaseResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleQueryPurchasesService>.NativeClassPtr, 100663370);
			GoogleQueryPurchasesService.NativeMethodInfoPtr_HandleGooglePurchaseResult_Private_Void_GooglePurchaseResult_Action_1_List_1_GooglePurchase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleQueryPurchasesService>.NativeClassPtr, 100663371);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00007A74 File Offset: 0x00005C74
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GoogleQueryPurchasesService(IGoogleBillingClient billingClient, IGoogleCachedQuerySkuDetailsService cachedQuerySkuDetailsService)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleQueryPurchasesService>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingClient);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachedQuerySkuDetailsService);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleQueryPurchasesService.NativeMethodInfoPtr__ctor_Internal_Void_IGoogleBillingClient_IGoogleCachedQuerySkuDetailsService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00007AD4 File Offset: 0x00005CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150732, XrefRangeEnd = 150790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void QueryPurchases(Action<List<GooglePurchase>> onQueryPurchaseSucceed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onQueryPurchaseSucceed);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleQueryPurchasesService.NativeMethodInfoPtr_QueryPurchases_Public_Virtual_Final_New_Void_Action_1_List_1_GooglePurchase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00007B18 File Offset: 0x00005D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150798, RefRangeEnd = 150799, XrefRangeStart = 150790, XrefRangeEnd = 150798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleOnQueryPurchaseReceived(Action<List<GooglePurchase>> onQueryPurchaseSucceed, List<GooglePurchase> googlePurchasesInSubs, List<GooglePurchase> googlePurchasesInApps)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onQueryPurchaseSucceed);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePurchasesInSubs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePurchasesInApps);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleQueryPurchasesService.NativeMethodInfoPtr_HandleOnQueryPurchaseReceived_Private_Static_Void_Action_1_List_1_GooglePurchase_List_1_GooglePurchase_List_1_GooglePurchase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00007B74 File Offset: 0x00005D74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150821, RefRangeEnd = 150822, XrefRangeStart = 150799, XrefRangeEnd = 150821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GooglePurchaseResult QueryPurchasesWithSkuType(string skuType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(skuType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleQueryPurchasesService.NativeMethodInfoPtr_QueryPurchasesWithSkuType_Private_GooglePurchaseResult_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GooglePurchaseResult>(intPtr3) : null;
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00007BC4 File Offset: 0x00005DC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150834, RefRangeEnd = 150835, XrefRangeStart = 150822, XrefRangeEnd = 150834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleGooglePurchaseResult(GooglePurchaseResult purchaseResult, Action<List<GooglePurchase>> onPurchaseResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchaseResult);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPurchaseResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleQueryPurchasesService.NativeMethodInfoPtr_HandleGooglePurchaseResult_Private_Void_GooglePurchaseResult_Action_1_List_1_GooglePurchase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000243F File Offset: 0x0000063F
		public GoogleQueryPurchasesService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00007C18 File Offset: 0x00005E18
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002448 File Offset: 0x00000648
		public unsafe IGoogleBillingClient m_BillingClient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleQueryPurchasesService.NativeFieldInfoPtr_m_BillingClient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGoogleBillingClient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleQueryPurchasesService.NativeFieldInfoPtr_m_BillingClient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00007C48 File Offset: 0x00005E48
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002467 File Offset: 0x00000667
		public unsafe IGoogleCachedQuerySkuDetailsService m_CachedQuerySkuDetailsService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleQueryPurchasesService.NativeFieldInfoPtr_m_CachedQuerySkuDetailsService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGoogleCachedQuerySkuDetailsService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleQueryPurchasesService.NativeFieldInfoPtr_m_CachedQuerySkuDetailsService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_m_BillingClient;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedQuerySkuDetailsService;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IGoogleBillingClient_IGoogleCachedQuerySkuDetailsService_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_QueryPurchases_Public_Virtual_Final_New_Void_Action_1_List_1_GooglePurchase_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_HandleOnQueryPurchaseReceived_Private_Static_Void_Action_1_List_1_GooglePurchase_List_1_GooglePurchase_List_1_GooglePurchase_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_QueryPurchasesWithSkuType_Private_GooglePurchaseResult_String_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_HandleGooglePurchaseResult_Private_Void_GooglePurchaseResult_Action_1_List_1_GooglePurchase_0;

		// Token: 0x020000A0 RID: 160
		[ObfuscatedName("UnityEngine.Purchasing.GoogleQueryPurchasesService+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x060005FC RID: 1532 RVA: 0x00019960 File Offset: 0x00017B60
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<GoogleQueryPurchasesService.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleQueryPurchasesService>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleQueryPurchasesService.__c__DisplayClass3_0>.NativeClassPtr);
				GoogleQueryPurchasesService.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleQueryPurchasesService.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
				GoogleQueryPurchasesService.__c__DisplayClass3_0.NativeFieldInfoPtr_onQueryPurchaseSucceed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleQueryPurchasesService.__c__DisplayClass3_0>.NativeClassPtr, "onQueryPurchaseSucceed");
				GoogleQueryPurchasesService.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleQueryPurchasesService.__c__DisplayClass3_0>.NativeClassPtr, 100663372);
				GoogleQueryPurchasesService.__c__DisplayClass3_0.NativeMethodInfoPtr__QueryPurchases_b__0_Internal_Void_List_1_GooglePurchase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleQueryPurchasesService.__c__DisplayClass3_0>.NativeClassPtr, 100663373);
			}

			// Token: 0x060005FD RID: 1533 RVA: 0x000199DC File Offset: 0x00017BDC
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleQueryPurchasesService.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleQueryPurchasesService.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005FE RID: 1534 RVA: 0x00019A18 File Offset: 0x00017C18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150714, XrefRangeEnd = 150730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _QueryPurchases_b__0(List<GooglePurchase> googlePurchasesInSubs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePurchasesInSubs);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleQueryPurchasesService.__c__DisplayClass3_0.NativeMethodInfoPtr__QueryPurchases_b__0_Internal_Void_List_1_GooglePurchase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005FF RID: 1535 RVA: 0x0000506C File Offset: 0x0000326C
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000182 RID: 386
			// (get) Token: 0x06000600 RID: 1536 RVA: 0x00019A5C File Offset: 0x00017C5C
			// (set) Token: 0x06000601 RID: 1537 RVA: 0x00005075 File Offset: 0x00003275
			public unsafe GoogleQueryPurchasesService __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleQueryPurchasesService.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleQueryPurchasesService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleQueryPurchasesService.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000183 RID: 387
			// (get) Token: 0x06000602 RID: 1538 RVA: 0x00019A8C File Offset: 0x00017C8C
			// (set) Token: 0x06000603 RID: 1539 RVA: 0x00005094 File Offset: 0x00003294
			public unsafe Action<List<GooglePurchase>> onQueryPurchaseSucceed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleQueryPurchasesService.__c__DisplayClass3_0.NativeFieldInfoPtr_onQueryPurchaseSucceed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<List<GooglePurchase>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleQueryPurchasesService.__c__DisplayClass3_0.NativeFieldInfoPtr_onQueryPurchaseSucceed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040003FE RID: 1022
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040003FF RID: 1023
			private static readonly IntPtr NativeFieldInfoPtr_onQueryPurchaseSucceed;

			// Token: 0x04000400 RID: 1024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000401 RID: 1025
			private static readonly IntPtr NativeMethodInfoPtr__QueryPurchases_b__0_Internal_Void_List_1_GooglePurchase_0;
		}

		// Token: 0x020000A1 RID: 161
		[ObfuscatedName("UnityEngine.Purchasing.GoogleQueryPurchasesService+<>c__DisplayClass3_1")]
		public sealed class __c__DisplayClass3_1 : Object
		{
			// Token: 0x06000604 RID: 1540 RVA: 0x00019ABC File Offset: 0x00017CBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_1()
			{
				Il2CppClassPointerStore<GoogleQueryPurchasesService.__c__DisplayClass3_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleQueryPurchasesService>.NativeClassPtr, "<>c__DisplayClass3_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleQueryPurchasesService.__c__DisplayClass3_1>.NativeClassPtr);
				GoogleQueryPurchasesService.__c__DisplayClass3_1.NativeFieldInfoPtr_googlePurchasesInSubs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleQueryPurchasesService.__c__DisplayClass3_1>.NativeClassPtr, "googlePurchasesInSubs");
				GoogleQueryPurchasesService.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleQueryPurchasesService.__c__DisplayClass3_1>.NativeClassPtr, "CS$<>8__locals1");
				GoogleQueryPurchasesService.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleQueryPurchasesService.__c__DisplayClass3_1>.NativeClassPtr, 100663374);
				GoogleQueryPurchasesService.__c__DisplayClass3_1.NativeMethodInfoPtr__QueryPurchases_b__1_Internal_Void_List_1_GooglePurchase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleQueryPurchasesService.__c__DisplayClass3_1>.NativeClassPtr, 100663375);
			}

			// Token: 0x06000605 RID: 1541 RVA: 0x00019B38 File Offset: 0x00017D38
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleQueryPurchasesService.__c__DisplayClass3_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleQueryPurchasesService.__c__DisplayClass3_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000606 RID: 1542 RVA: 0x00019B74 File Offset: 0x00017D74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150730, XrefRangeEnd = 150732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _QueryPurchases_b__1(List<GooglePurchase> googlePurchasesInApps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePurchasesInApps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleQueryPurchasesService.__c__DisplayClass3_1.NativeMethodInfoPtr__QueryPurchases_b__1_Internal_Void_List_1_GooglePurchase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000607 RID: 1543 RVA: 0x000050B3 File Offset: 0x000032B3
			public __c__DisplayClass3_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000184 RID: 388
			// (get) Token: 0x06000608 RID: 1544 RVA: 0x00019BB8 File Offset: 0x00017DB8
			// (set) Token: 0x06000609 RID: 1545 RVA: 0x000050BC File Offset: 0x000032BC
			public unsafe List<GooglePurchase> googlePurchasesInSubs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleQueryPurchasesService.__c__DisplayClass3_1.NativeFieldInfoPtr_googlePurchasesInSubs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GooglePurchase>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleQueryPurchasesService.__c__DisplayClass3_1.NativeFieldInfoPtr_googlePurchasesInSubs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000185 RID: 389
			// (get) Token: 0x0600060A RID: 1546 RVA: 0x00019BE8 File Offset: 0x00017DE8
			// (set) Token: 0x0600060B RID: 1547 RVA: 0x000050DB File Offset: 0x000032DB
			public unsafe GoogleQueryPurchasesService.__c__DisplayClass3_0 field_Public___c__DisplayClass3_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleQueryPurchasesService.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleQueryPurchasesService.__c__DisplayClass3_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleQueryPurchasesService.__c__DisplayClass3_1.NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000402 RID: 1026
			private static readonly IntPtr NativeFieldInfoPtr_googlePurchasesInSubs;

			// Token: 0x04000403 RID: 1027
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass3_0_0;

			// Token: 0x04000404 RID: 1028
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000405 RID: 1029
			private static readonly IntPtr NativeMethodInfoPtr__QueryPurchases_b__1_Internal_Void_List_1_GooglePurchase_0;
		}
	}
}

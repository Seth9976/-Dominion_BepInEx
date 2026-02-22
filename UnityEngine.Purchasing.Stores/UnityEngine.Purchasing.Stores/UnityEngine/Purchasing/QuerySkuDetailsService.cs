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
	// Token: 0x0200001B RID: 27
	public class QuerySkuDetailsService : Object
	{
		// Token: 0x060000DF RID: 223 RVA: 0x00008B28 File Offset: 0x00006D28
		// Note: this type is marked as 'beforefieldinit'.
		static QuerySkuDetailsService()
		{
			Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "QuerySkuDetailsService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr);
			QuerySkuDetailsService.NativeFieldInfoPtr_m_CachedQueriedSku = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr, "m_CachedQueriedSku");
			QuerySkuDetailsService.NativeFieldInfoPtr_m_BillingClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr, "m_BillingClient");
			QuerySkuDetailsService.NativeFieldInfoPtr_m_GoogleCachedQuerySkuDetailsService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr, "m_GoogleCachedQuerySkuDetailsService");
			QuerySkuDetailsService.NativeFieldInfoPtr_m_NumberReceivedCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr, "m_NumberReceivedCallbacks");
			QuerySkuDetailsService.NativeFieldInfoPtr_m_QueriedSkuDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr, "m_QueriedSkuDetails");
			QuerySkuDetailsService.NativeMethodInfoPtr_GetSkuDetailsParamClass_Private_Static_AndroidJavaClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr, 100663402);
			QuerySkuDetailsService.NativeMethodInfoPtr__ctor_Internal_Void_IGoogleBillingClient_IGoogleCachedQuerySkuDetailsService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr, 100663403);
			QuerySkuDetailsService.NativeMethodInfoPtr_QueryAsyncSku_Public_Virtual_Final_New_Void_ProductDefinition_Action_1_List_1_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr, 100663404);
			QuerySkuDetailsService.NativeMethodInfoPtr_QueryAsyncSku_Public_Virtual_Final_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_ProductDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr, 100663405);
			QuerySkuDetailsService.NativeMethodInfoPtr_QueryAsyncSku_Public_Virtual_Final_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr, 100663406);
			QuerySkuDetailsService.NativeMethodInfoPtr_QueryInAppsAsync_Private_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr, 100663407);
			QuerySkuDetailsService.NativeMethodInfoPtr_QuerySubsAsync_Private_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr, 100663408);
			QuerySkuDetailsService.NativeMethodInfoPtr_QuerySkuDetails_Private_Void_List_1_String_String_Action_1_List_1_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr, 100663409);
			QuerySkuDetailsService.NativeMethodInfoPtr_ConsolidateOnSkuDetailsReceived_Private_Void_AndroidJavaObject_AndroidJavaObject_Action_1_List_1_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr, 100663410);
			QuerySkuDetailsService.NativeMethodInfoPtr_AddToQueriedSkuDetails_Private_Void_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr, 100663411);
			QuerySkuDetailsService.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr, 100663412);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00008C98 File Offset: 0x00006E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151137, XrefRangeEnd = 151143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndroidJavaClass GetSkuDetailsParamClass()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.NativeMethodInfoPtr_GetSkuDetailsParamClass_Private_Static_AndroidJavaClass_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaClass>(intPtr3) : null;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00008CCC File Offset: 0x00006ECC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 151156, RefRangeEnd = 151159, XrefRangeStart = 151143, XrefRangeEnd = 151156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuerySkuDetailsService(IGoogleBillingClient billingClient, IGoogleCachedQuerySkuDetailsService googleCachedQuerySkuDetailsService)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingClient);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googleCachedQuerySkuDetailsService);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.NativeMethodInfoPtr__ctor_Internal_Void_IGoogleBillingClient_IGoogleCachedQuerySkuDetailsService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00008D2C File Offset: 0x00006F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151159, XrefRangeEnd = 151174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void QueryAsyncSku(ProductDefinition product, Action<List<AndroidJavaObject>> onSkuDetailsResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onSkuDetailsResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.NativeMethodInfoPtr_QueryAsyncSku_Public_Virtual_Final_New_Void_ProductDefinition_Action_1_List_1_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00008D80 File Offset: 0x00006F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151174, XrefRangeEnd = 151189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void QueryAsyncSku(ReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onSkuDetailsResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onSkuDetailsResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.NativeMethodInfoPtr_QueryAsyncSku_Public_Virtual_Final_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_ProductDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00008DD4 File Offset: 0x00006FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151189, XrefRangeEnd = 151191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void QueryAsyncSku(ReadOnlyCollection<ProductDefinition> products, Action<List<AndroidJavaObject>> onSkuDetailsResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onSkuDetailsResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.NativeMethodInfoPtr_QueryAsyncSku_Public_Virtual_Final_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00008E28 File Offset: 0x00007028
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 151232, RefRangeEnd = 151235, XrefRangeStart = 151191, XrefRangeEnd = 151232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueryInAppsAsync(ReadOnlyCollection<ProductDefinition> products, Action<List<AndroidJavaObject>> onSkuDetailsResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onSkuDetailsResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.NativeMethodInfoPtr_QueryInAppsAsync_Private_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00008E7C File Offset: 0x0000707C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 151276, RefRangeEnd = 151279, XrefRangeStart = 151235, XrefRangeEnd = 151276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuerySubsAsync(ReadOnlyCollection<ProductDefinition> products, Action<List<AndroidJavaObject>> onSkuDetailsResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onSkuDetailsResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.NativeMethodInfoPtr_QuerySubsAsync_Private_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00008ED0 File Offset: 0x000070D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151344, RefRangeEnd = 151346, XrefRangeStart = 151279, XrefRangeEnd = 151344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuerySkuDetails(List<string> skus, string type, Action<List<AndroidJavaObject>> onSkuDetailsResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(skus);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onSkuDetailsResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.NativeMethodInfoPtr_QuerySkuDetails_Private_Void_List_1_String_String_Action_1_List_1_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00008F38 File Offset: 0x00007138
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151386, RefRangeEnd = 151387, XrefRangeStart = 151346, XrefRangeEnd = 151386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsolidateOnSkuDetailsReceived(AndroidJavaObject javaBillingResult, AndroidJavaObject skuDetails, Action<List<AndroidJavaObject>> onSkuDetailsResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(javaBillingResult);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skuDetails);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onSkuDetailsResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.NativeMethodInfoPtr_ConsolidateOnSkuDetailsReceived_Private_Void_AndroidJavaObject_AndroidJavaObject_Action_1_List_1_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00008FA0 File Offset: 0x000071A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151387, XrefRangeEnd = 151410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToQueriedSkuDetails(AndroidJavaObject skusDetails)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(skusDetails);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.NativeMethodInfoPtr_AddToQueriedSkuDetails_Private_Void_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00008FE4 File Offset: 0x000071E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151410, XrefRangeEnd = 151416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000267C File Offset: 0x0000087C
		public QuerySkuDetailsService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00009018 File Offset: 0x00007218
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002685 File Offset: 0x00000885
		public unsafe List<AndroidJavaClass> m_CachedQueriedSku
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuerySkuDetailsService.NativeFieldInfoPtr_m_CachedQueriedSku);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AndroidJavaClass>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuerySkuDetailsService.NativeFieldInfoPtr_m_CachedQueriedSku), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00009048 File Offset: 0x00007248
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000026A4 File Offset: 0x000008A4
		public unsafe IGoogleBillingClient m_BillingClient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuerySkuDetailsService.NativeFieldInfoPtr_m_BillingClient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGoogleBillingClient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuerySkuDetailsService.NativeFieldInfoPtr_m_BillingClient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00009078 File Offset: 0x00007278
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x000026C3 File Offset: 0x000008C3
		public unsafe IGoogleCachedQuerySkuDetailsService m_GoogleCachedQuerySkuDetailsService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuerySkuDetailsService.NativeFieldInfoPtr_m_GoogleCachedQuerySkuDetailsService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGoogleCachedQuerySkuDetailsService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuerySkuDetailsService.NativeFieldInfoPtr_m_GoogleCachedQuerySkuDetailsService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x000090A8 File Offset: 0x000072A8
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x000026E2 File Offset: 0x000008E2
		public unsafe int m_NumberReceivedCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuerySkuDetailsService.NativeFieldInfoPtr_m_NumberReceivedCallbacks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuerySkuDetailsService.NativeFieldInfoPtr_m_NumberReceivedCallbacks)) = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x000090D0 File Offset: 0x000072D0
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x000026FD File Offset: 0x000008FD
		public unsafe List<AndroidJavaObject> m_QueriedSkuDetails
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuerySkuDetailsService.NativeFieldInfoPtr_m_QueriedSkuDetails);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AndroidJavaObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuerySkuDetailsService.NativeFieldInfoPtr_m_QueriedSkuDetails), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedQueriedSku;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_m_BillingClient;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_m_GoogleCachedQuerySkuDetailsService;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_m_NumberReceivedCallbacks;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_m_QueriedSkuDetails;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_GetSkuDetailsParamClass_Private_Static_AndroidJavaClass_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IGoogleBillingClient_IGoogleCachedQuerySkuDetailsService_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_QueryAsyncSku_Public_Virtual_Final_New_Void_ProductDefinition_Action_1_List_1_AndroidJavaObject_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_QueryAsyncSku_Public_Virtual_Final_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_ProductDescription_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_QueryAsyncSku_Public_Virtual_Final_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_AndroidJavaObject_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_QueryInAppsAsync_Private_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_AndroidJavaObject_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_QuerySubsAsync_Private_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_AndroidJavaObject_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_QuerySkuDetails_Private_Void_List_1_String_String_Action_1_List_1_AndroidJavaObject_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_ConsolidateOnSkuDetailsReceived_Private_Void_AndroidJavaObject_AndroidJavaObject_Action_1_List_1_AndroidJavaObject_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_AddToQueriedSkuDetails_Private_Void_AndroidJavaObject_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;

		// Token: 0x020000A2 RID: 162
		[ObfuscatedName("UnityEngine.Purchasing.QuerySkuDetailsService+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x0600060C RID: 1548 RVA: 0x00019C18 File Offset: 0x00017E18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<QuerySkuDetailsService.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuerySkuDetailsService.__c__DisplayClass12_0>.NativeClassPtr);
				QuerySkuDetailsService.__c__DisplayClass12_0.NativeFieldInfoPtr_onSkuDetailsResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuerySkuDetailsService.__c__DisplayClass12_0>.NativeClassPtr, "onSkuDetailsResponse");
				QuerySkuDetailsService.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService.__c__DisplayClass12_0>.NativeClassPtr, 100663413);
				QuerySkuDetailsService.__c__DisplayClass12_0.NativeMethodInfoPtr__QueryAsyncSku_b__0_Internal_Void_List_1_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService.__c__DisplayClass12_0>.NativeClassPtr, 100663414);
			}

			// Token: 0x0600060D RID: 1549 RVA: 0x00019C80 File Offset: 0x00017E80
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuerySkuDetailsService.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600060E RID: 1550 RVA: 0x00019CBC File Offset: 0x00017EBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151135, XrefRangeEnd = 151136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _QueryAsyncSku_b__0(List<AndroidJavaObject> skus)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(skus);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.__c__DisplayClass12_0.NativeMethodInfoPtr__QueryAsyncSku_b__0_Internal_Void_List_1_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600060F RID: 1551 RVA: 0x000050FA File Offset: 0x000032FA
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000186 RID: 390
			// (get) Token: 0x06000610 RID: 1552 RVA: 0x00019D00 File Offset: 0x00017F00
			// (set) Token: 0x06000611 RID: 1553 RVA: 0x00005103 File Offset: 0x00003303
			public unsafe Action<List<ProductDescription>> onSkuDetailsResponse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuerySkuDetailsService.__c__DisplayClass12_0.NativeFieldInfoPtr_onSkuDetailsResponse);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<List<ProductDescription>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuerySkuDetailsService.__c__DisplayClass12_0.NativeFieldInfoPtr_onSkuDetailsResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000406 RID: 1030
			private static readonly IntPtr NativeFieldInfoPtr_onSkuDetailsResponse;

			// Token: 0x04000407 RID: 1031
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000408 RID: 1032
			private static readonly IntPtr NativeMethodInfoPtr__QueryAsyncSku_b__0_Internal_Void_List_1_AndroidJavaObject_0;
		}

		// Token: 0x020000A3 RID: 163
		[ObfuscatedName("UnityEngine.Purchasing.QuerySkuDetailsService+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000612 RID: 1554 RVA: 0x00019D30 File Offset: 0x00017F30
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<QuerySkuDetailsService.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuerySkuDetailsService.__c>.NativeClassPtr);
				QuerySkuDetailsService.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuerySkuDetailsService.__c>.NativeClassPtr, "<>9");
				QuerySkuDetailsService.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuerySkuDetailsService.__c>.NativeClassPtr, "<>9__14_0");
				QuerySkuDetailsService.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuerySkuDetailsService.__c>.NativeClassPtr, "<>9__14_1");
				QuerySkuDetailsService.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuerySkuDetailsService.__c>.NativeClassPtr, "<>9__15_0");
				QuerySkuDetailsService.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuerySkuDetailsService.__c>.NativeClassPtr, "<>9__15_1");
				QuerySkuDetailsService.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService.__c>.NativeClassPtr, 100663416);
				QuerySkuDetailsService.__c.NativeMethodInfoPtr__QueryInAppsAsync_b__14_0_Internal_Boolean_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService.__c>.NativeClassPtr, 100663417);
				QuerySkuDetailsService.__c.NativeMethodInfoPtr__QueryInAppsAsync_b__14_1_Internal_String_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService.__c>.NativeClassPtr, 100663418);
				QuerySkuDetailsService.__c.NativeMethodInfoPtr__QuerySubsAsync_b__15_0_Internal_Boolean_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService.__c>.NativeClassPtr, 100663419);
				QuerySkuDetailsService.__c.NativeMethodInfoPtr__QuerySubsAsync_b__15_1_Internal_String_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService.__c>.NativeClassPtr, 100663420);
			}

			// Token: 0x06000613 RID: 1555 RVA: 0x00019E24 File Offset: 0x00018024
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuerySkuDetailsService.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000614 RID: 1556 RVA: 0x00019E60 File Offset: 0x00018060
			[CallerCount(0)]
			public unsafe bool _QueryInAppsAsync_b__14_0(ProductDefinition product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.__c.NativeMethodInfoPtr__QueryInAppsAsync_b__14_0_Internal_Boolean_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000615 RID: 1557 RVA: 0x00019EB0 File Offset: 0x000180B0
			[CallerCount(0)]
			public unsafe string _QueryInAppsAsync_b__14_1(ProductDefinition product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.__c.NativeMethodInfoPtr__QueryInAppsAsync_b__14_1_Internal_String_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000616 RID: 1558 RVA: 0x00019EF8 File Offset: 0x000180F8
			[CallerCount(0)]
			public unsafe bool _QuerySubsAsync_b__15_0(ProductDefinition product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.__c.NativeMethodInfoPtr__QuerySubsAsync_b__15_0_Internal_Boolean_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000617 RID: 1559 RVA: 0x00019F48 File Offset: 0x00018148
			[CallerCount(0)]
			public unsafe string _QuerySubsAsync_b__15_1(ProductDefinition product)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.__c.NativeMethodInfoPtr__QuerySubsAsync_b__15_1_Internal_String_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000618 RID: 1560 RVA: 0x00005122 File Offset: 0x00003322
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000187 RID: 391
			// (get) Token: 0x06000619 RID: 1561 RVA: 0x00019F90 File Offset: 0x00018190
			// (set) Token: 0x0600061A RID: 1562 RVA: 0x0000512B File Offset: 0x0000332B
			public unsafe static QuerySkuDetailsService.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QuerySkuDetailsService.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuerySkuDetailsService.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QuerySkuDetailsService.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000188 RID: 392
			// (get) Token: 0x0600061B RID: 1563 RVA: 0x00019FB8 File Offset: 0x000181B8
			// (set) Token: 0x0600061C RID: 1564 RVA: 0x0000513D File Offset: 0x0000333D
			public unsafe static Func<ProductDefinition, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QuerySkuDetailsService.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ProductDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QuerySkuDetailsService.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000189 RID: 393
			// (get) Token: 0x0600061D RID: 1565 RVA: 0x00019FE0 File Offset: 0x000181E0
			// (set) Token: 0x0600061E RID: 1566 RVA: 0x0000514F File Offset: 0x0000334F
			public unsafe static Func<ProductDefinition, string> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QuerySkuDetailsService.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ProductDefinition, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QuerySkuDetailsService.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700018A RID: 394
			// (get) Token: 0x0600061F RID: 1567 RVA: 0x0001A008 File Offset: 0x00018208
			// (set) Token: 0x06000620 RID: 1568 RVA: 0x00005161 File Offset: 0x00003361
			public unsafe static Func<ProductDefinition, bool> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QuerySkuDetailsService.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ProductDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QuerySkuDetailsService.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700018B RID: 395
			// (get) Token: 0x06000621 RID: 1569 RVA: 0x0001A030 File Offset: 0x00018230
			// (set) Token: 0x06000622 RID: 1570 RVA: 0x00005173 File Offset: 0x00003373
			public unsafe static Func<ProductDefinition, string> __9__15_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(QuerySkuDetailsService.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ProductDefinition, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(QuerySkuDetailsService.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000409 RID: 1033
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400040A RID: 1034
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x0400040B RID: 1035
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x0400040C RID: 1036
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x0400040D RID: 1037
			private static readonly IntPtr NativeFieldInfoPtr___9__15_1;

			// Token: 0x0400040E RID: 1038
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400040F RID: 1039
			private static readonly IntPtr NativeMethodInfoPtr__QueryInAppsAsync_b__14_0_Internal_Boolean_ProductDefinition_0;

			// Token: 0x04000410 RID: 1040
			private static readonly IntPtr NativeMethodInfoPtr__QueryInAppsAsync_b__14_1_Internal_String_ProductDefinition_0;

			// Token: 0x04000411 RID: 1041
			private static readonly IntPtr NativeMethodInfoPtr__QuerySubsAsync_b__15_0_Internal_Boolean_ProductDefinition_0;

			// Token: 0x04000412 RID: 1042
			private static readonly IntPtr NativeMethodInfoPtr__QuerySubsAsync_b__15_1_Internal_String_ProductDefinition_0;
		}

		// Token: 0x020000A4 RID: 164
		[ObfuscatedName("UnityEngine.Purchasing.QuerySkuDetailsService+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Object
		{
			// Token: 0x06000623 RID: 1571 RVA: 0x0001A058 File Offset: 0x00018258
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<QuerySkuDetailsService.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuerySkuDetailsService>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuerySkuDetailsService.__c__DisplayClass16_0>.NativeClassPtr);
				QuerySkuDetailsService.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuerySkuDetailsService.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
				QuerySkuDetailsService.__c__DisplayClass16_0.NativeFieldInfoPtr_onSkuDetailsResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuerySkuDetailsService.__c__DisplayClass16_0>.NativeClassPtr, "onSkuDetailsResponse");
				QuerySkuDetailsService.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService.__c__DisplayClass16_0>.NativeClassPtr, 100663421);
				QuerySkuDetailsService.__c__DisplayClass16_0.NativeMethodInfoPtr__QuerySkuDetails_b__0_Internal_Void_AndroidJavaObject_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySkuDetailsService.__c__DisplayClass16_0>.NativeClassPtr, 100663422);
			}

			// Token: 0x06000624 RID: 1572 RVA: 0x0001A0D4 File Offset: 0x000182D4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuerySkuDetailsService.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000625 RID: 1573 RVA: 0x0001A110 File Offset: 0x00018310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151136, XrefRangeEnd = 151137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _QuerySkuDetails_b__0(AndroidJavaObject billingResult, AndroidJavaObject skuDetails)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingResult);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skuDetails);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuerySkuDetailsService.__c__DisplayClass16_0.NativeMethodInfoPtr__QuerySkuDetails_b__0_Internal_Void_AndroidJavaObject_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000626 RID: 1574 RVA: 0x00005185 File Offset: 0x00003385
			public __c__DisplayClass16_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700018C RID: 396
			// (get) Token: 0x06000627 RID: 1575 RVA: 0x0001A164 File Offset: 0x00018364
			// (set) Token: 0x06000628 RID: 1576 RVA: 0x0000518E File Offset: 0x0000338E
			public unsafe QuerySkuDetailsService __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuerySkuDetailsService.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuerySkuDetailsService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuerySkuDetailsService.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700018D RID: 397
			// (get) Token: 0x06000629 RID: 1577 RVA: 0x0001A194 File Offset: 0x00018394
			// (set) Token: 0x0600062A RID: 1578 RVA: 0x000051AD File Offset: 0x000033AD
			public unsafe Action<List<AndroidJavaObject>> onSkuDetailsResponse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuerySkuDetailsService.__c__DisplayClass16_0.NativeFieldInfoPtr_onSkuDetailsResponse);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<List<AndroidJavaObject>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuerySkuDetailsService.__c__DisplayClass16_0.NativeFieldInfoPtr_onSkuDetailsResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000413 RID: 1043
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000414 RID: 1044
			private static readonly IntPtr NativeFieldInfoPtr_onSkuDetailsResponse;

			// Token: 0x04000415 RID: 1045
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000416 RID: 1046
			private static readonly IntPtr NativeMethodInfoPtr__QuerySkuDetails_b__0_Internal_Void_AndroidJavaObject_AndroidJavaObject_0;
		}
	}
}

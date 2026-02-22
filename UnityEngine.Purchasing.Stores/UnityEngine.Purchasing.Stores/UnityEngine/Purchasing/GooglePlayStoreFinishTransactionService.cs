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
	// Token: 0x0200002E RID: 46
	public class GooglePlayStoreFinishTransactionService : Object
	{
		// Token: 0x0600018B RID: 395 RVA: 0x0000B014 File Offset: 0x00009214
		// Note: this type is marked as 'beforefieldinit'.
		static GooglePlayStoreFinishTransactionService()
		{
			Il2CppClassPointerStore<GooglePlayStoreFinishTransactionService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GooglePlayStoreFinishTransactionService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayStoreFinishTransactionService>.NativeClassPtr);
			GooglePlayStoreFinishTransactionService.NativeFieldInfoPtr_m_ProcessedPurchaseToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreFinishTransactionService>.NativeClassPtr, "m_ProcessedPurchaseToken");
			GooglePlayStoreFinishTransactionService.NativeFieldInfoPtr_m_GooglePlayStoreService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreFinishTransactionService>.NativeClassPtr, "m_GooglePlayStoreService");
			GooglePlayStoreFinishTransactionService.NativeFieldInfoPtr_m_StoreCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreFinishTransactionService>.NativeClassPtr, "m_StoreCallback");
			GooglePlayStoreFinishTransactionService.NativeMethodInfoPtr__ctor_Internal_Void_IGooglePlayStoreService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreFinishTransactionService>.NativeClassPtr, 100663485);
			GooglePlayStoreFinishTransactionService.NativeMethodInfoPtr_SetStoreCallback_Public_Virtual_Final_New_Void_IStoreCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreFinishTransactionService>.NativeClassPtr, 100663486);
			GooglePlayStoreFinishTransactionService.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreFinishTransactionService>.NativeClassPtr, 100663487);
			GooglePlayStoreFinishTransactionService.NativeMethodInfoPtr_OnConsume_Public_Virtual_Final_New_Void_ProductDefinition_GooglePurchase_GoogleBillingResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreFinishTransactionService>.NativeClassPtr, 100663488);
			GooglePlayStoreFinishTransactionService.NativeMethodInfoPtr_OnAcknowledge_Public_Virtual_Final_New_Void_ProductDefinition_GooglePurchase_GoogleBillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreFinishTransactionService>.NativeClassPtr, 100663489);
			GooglePlayStoreFinishTransactionService.NativeMethodInfoPtr_HandleFinishTransaction_Public_Virtual_Final_New_Void_ProductDefinition_GooglePurchase_GoogleBillingResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreFinishTransactionService>.NativeClassPtr, 100663490);
			GooglePlayStoreFinishTransactionService.NativeMethodInfoPtr_CallPurchaseSucceededUpdateReceipt_Private_Void_ProductDefinition_GooglePurchase_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreFinishTransactionService>.NativeClassPtr, 100663491);
			GooglePlayStoreFinishTransactionService.NativeMethodInfoPtr_IsResponseCodeInRecoverableState_Private_Static_Boolean_GoogleBillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreFinishTransactionService>.NativeClassPtr, 100663492);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000B120 File Offset: 0x00009320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151629, XrefRangeEnd = 151636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GooglePlayStoreFinishTransactionService(IGooglePlayStoreService googlePlayStoreService)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayStoreFinishTransactionService>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePlayStoreService);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreFinishTransactionService.NativeMethodInfoPtr__ctor_Internal_Void_IGooglePlayStoreService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000B16C File Offset: 0x0000936C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreFinishTransactionService.NativeMethodInfoPtr_SetStoreCallback_Public_Virtual_Final_New_Void_IStoreCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000B1B0 File Offset: 0x000093B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151636, XrefRangeEnd = 151651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FinishTransaction(ProductDefinition product, string purchaseToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(purchaseToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreFinishTransactionService.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_ProductDefinition_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000B204 File Offset: 0x00009404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151651, XrefRangeEnd = 151652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnConsume(ProductDefinition product, GooglePurchase googlePurchase, GoogleBillingResult billingResult, string purchaseToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePurchase);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(billingResult);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(purchaseToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreFinishTransactionService.NativeMethodInfoPtr_OnConsume_Public_Virtual_Final_New_Void_ProductDefinition_GooglePurchase_GoogleBillingResult_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000B280 File Offset: 0x00009480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151652, XrefRangeEnd = 151653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAcknowledge(ProductDefinition product, GooglePurchase googlePurchase, GoogleBillingResult billingResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePurchase);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(billingResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreFinishTransactionService.NativeMethodInfoPtr_OnAcknowledge_Public_Virtual_Final_New_Void_ProductDefinition_GooglePurchase_GoogleBillingResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000B2E8 File Offset: 0x000094E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151670, RefRangeEnd = 151672, XrefRangeStart = 151653, XrefRangeEnd = 151670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleFinishTransaction(ProductDefinition product, GooglePurchase googlePurchase, GoogleBillingResult billingResult, string purchaseToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePurchase);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(billingResult);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(purchaseToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreFinishTransactionService.NativeMethodInfoPtr_HandleFinishTransaction_Public_Virtual_Final_New_Void_ProductDefinition_GooglePurchase_GoogleBillingResult_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000B364 File Offset: 0x00009564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151672, XrefRangeEnd = 151675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallPurchaseSucceededUpdateReceipt(ProductDefinition product, GooglePurchase googlePurchase, string purchaseToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePurchase);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(purchaseToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreFinishTransactionService.NativeMethodInfoPtr_CallPurchaseSucceededUpdateReceipt_Private_Void_ProductDefinition_GooglePurchase_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000B3CC File Offset: 0x000095CC
		[CallerCount(0)]
		public unsafe static bool IsResponseCodeInRecoverableState(GoogleBillingResult billingResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreFinishTransactionService.NativeMethodInfoPtr_IsResponseCodeInRecoverableState_Private_Static_Boolean_GoogleBillingResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002BF5 File Offset: 0x00000DF5
		public GooglePlayStoreFinishTransactionService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000B410 File Offset: 0x00009610
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00002BFE File Offset: 0x00000DFE
		public unsafe HashSet<string> m_ProcessedPurchaseToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreFinishTransactionService.NativeFieldInfoPtr_m_ProcessedPurchaseToken);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreFinishTransactionService.NativeFieldInfoPtr_m_ProcessedPurchaseToken), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000B440 File Offset: 0x00009640
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002C1D File Offset: 0x00000E1D
		public unsafe IGooglePlayStoreService m_GooglePlayStoreService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreFinishTransactionService.NativeFieldInfoPtr_m_GooglePlayStoreService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePlayStoreService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreFinishTransactionService.NativeFieldInfoPtr_m_GooglePlayStoreService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0000B470 File Offset: 0x00009670
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00002C3C File Offset: 0x00000E3C
		public unsafe IStoreCallback m_StoreCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreFinishTransactionService.NativeFieldInfoPtr_m_StoreCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStoreCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreFinishTransactionService.NativeFieldInfoPtr_m_StoreCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr_m_ProcessedPurchaseToken;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr_m_GooglePlayStoreService;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeFieldInfoPtr_m_StoreCallback;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IGooglePlayStoreService_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_SetStoreCallback_Public_Virtual_Final_New_Void_IStoreCallback_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_ProductDefinition_String_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_OnConsume_Public_Virtual_Final_New_Void_ProductDefinition_GooglePurchase_GoogleBillingResult_String_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_OnAcknowledge_Public_Virtual_Final_New_Void_ProductDefinition_GooglePurchase_GoogleBillingResult_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_HandleFinishTransaction_Public_Virtual_Final_New_Void_ProductDefinition_GooglePurchase_GoogleBillingResult_String_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_CallPurchaseSucceededUpdateReceipt_Private_Void_ProductDefinition_GooglePurchase_String_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_IsResponseCodeInRecoverableState_Private_Static_Boolean_GoogleBillingResult_0;
	}
}

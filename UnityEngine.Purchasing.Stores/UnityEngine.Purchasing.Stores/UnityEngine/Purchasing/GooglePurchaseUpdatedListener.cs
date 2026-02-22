using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Purchasing.Interfaces;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000019 RID: 25
	public class GooglePurchaseUpdatedListener : AndroidJavaProxy
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00008448 File Offset: 0x00006648
		// Note: this type is marked as 'beforefieldinit'.
		static GooglePurchaseUpdatedListener()
		{
			Il2CppClassPointerStore<GooglePurchaseUpdatedListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GooglePurchaseUpdatedListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePurchaseUpdatedListener>.NativeClassPtr);
			GooglePurchaseUpdatedListener.NativeFieldInfoPtr_m_LastKnownProductService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseUpdatedListener>.NativeClassPtr, "m_LastKnownProductService");
			GooglePurchaseUpdatedListener.NativeFieldInfoPtr_m_GooglePurchaseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseUpdatedListener>.NativeClassPtr, "m_GooglePurchaseCallback");
			GooglePurchaseUpdatedListener.NativeFieldInfoPtr_m_GoogleCachedQuerySkuDetailsService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseUpdatedListener>.NativeClassPtr, "m_GoogleCachedQuerySkuDetailsService");
			GooglePurchaseUpdatedListener.NativeMethodInfoPtr__ctor_Internal_Void_IGoogleLastKnownProductService_IGooglePurchaseCallback_IGoogleCachedQuerySkuDetailsService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseUpdatedListener>.NativeClassPtr, 100663388);
			GooglePurchaseUpdatedListener.NativeMethodInfoPtr_onPurchasesUpdated_Private_Void_AndroidJavaObject_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseUpdatedListener>.NativeClassPtr, 100663389);
			GooglePurchaseUpdatedListener.NativeMethodInfoPtr_HandleResultOkCases_Private_Void_GoogleBillingResult_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseUpdatedListener>.NativeClassPtr, 100663390);
			GooglePurchaseUpdatedListener.NativeMethodInfoPtr_HandleErrorCases_Private_Void_GoogleBillingResult_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseUpdatedListener>.NativeClassPtr, 100663391);
			GooglePurchaseUpdatedListener.NativeMethodInfoPtr_ApplyOnPurchases_Private_Void_AndroidJavaObject_Action_1_GooglePurchase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseUpdatedListener>.NativeClassPtr, 100663392);
			GooglePurchaseUpdatedListener.NativeMethodInfoPtr_ApplyOnPurchases_Private_Void_AndroidJavaObject_GoogleBillingResult_Action_2_GooglePurchase_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseUpdatedListener>.NativeClassPtr, 100663393);
			GooglePurchaseUpdatedListener.NativeMethodInfoPtr_IsLastProrationModeDeferred_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseUpdatedListener>.NativeClassPtr, 100663394);
			GooglePurchaseUpdatedListener.NativeMethodInfoPtr_OnPurchaseOk_Private_Void_GooglePurchase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseUpdatedListener>.NativeClassPtr, 100663395);
			GooglePurchaseUpdatedListener.NativeMethodInfoPtr_OnDeferredProrationUpgradeDowngradeSubscriptionOk_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseUpdatedListener>.NativeClassPtr, 100663396);
			GooglePurchaseUpdatedListener.NativeMethodInfoPtr_OnPurchaseCanceled_Private_Void_GooglePurchase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseUpdatedListener>.NativeClassPtr, 100663397);
			GooglePurchaseUpdatedListener.NativeMethodInfoPtr_OnPurchaseAlreadyOwned_Private_Void_GooglePurchase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseUpdatedListener>.NativeClassPtr, 100663398);
			GooglePurchaseUpdatedListener.NativeMethodInfoPtr_OnPurchaseFailed_Private_Void_GooglePurchase_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseUpdatedListener>.NativeClassPtr, 100663399);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000085A4 File Offset: 0x000067A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150885, XrefRangeEnd = 150891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GooglePurchaseUpdatedListener(IGoogleLastKnownProductService googleLastKnownProductService, IGooglePurchaseCallback googlePurchaseCallback, IGoogleCachedQuerySkuDetailsService googleCachedQuerySkuDetailsService)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePurchaseUpdatedListener>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(googleLastKnownProductService);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePurchaseCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googleCachedQuerySkuDetailsService);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseUpdatedListener.NativeMethodInfoPtr__ctor_Internal_Void_IGoogleLastKnownProductService_IGooglePurchaseCallback_IGoogleCachedQuerySkuDetailsService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00008614 File Offset: 0x00006814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150891, XrefRangeEnd = 150937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onPurchasesUpdated(AndroidJavaObject billingResult, AndroidJavaObject purchasesList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingResult);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(purchasesList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseUpdatedListener.NativeMethodInfoPtr_onPurchasesUpdated_Private_Void_AndroidJavaObject_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00008668 File Offset: 0x00006868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150937, XrefRangeEnd = 150966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleResultOkCases(GoogleBillingResult result, AndroidJavaObject purchasesList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(purchasesList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseUpdatedListener.NativeMethodInfoPtr_HandleResultOkCases_Private_Void_GoogleBillingResult_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000086BC File Offset: 0x000068BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150966, XrefRangeEnd = 150992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleErrorCases(GoogleBillingResult billingResult, AndroidJavaObject purchasesList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingResult);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(purchasesList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseUpdatedListener.NativeMethodInfoPtr_HandleErrorCases_Private_Void_GoogleBillingResult_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00008710 File Offset: 0x00006910
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151022, RefRangeEnd = 151024, XrefRangeStart = 150992, XrefRangeEnd = 151022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyOnPurchases(AndroidJavaObject purchasesList, Action<GooglePurchase> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchasesList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseUpdatedListener.NativeMethodInfoPtr_ApplyOnPurchases_Private_Void_AndroidJavaObject_Action_1_GooglePurchase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00008764 File Offset: 0x00006964
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151054, RefRangeEnd = 151056, XrefRangeStart = 151024, XrefRangeEnd = 151054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyOnPurchases(AndroidJavaObject purchasesList, GoogleBillingResult billingResult, Action<GooglePurchase, string> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchasesList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(billingResult);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseUpdatedListener.NativeMethodInfoPtr_ApplyOnPurchases_Private_Void_AndroidJavaObject_GoogleBillingResult_Action_2_GooglePurchase_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000087CC File Offset: 0x000069CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151056, XrefRangeEnd = 151063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLastProrationModeDeferred()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseUpdatedListener.NativeMethodInfoPtr_IsLastProrationModeDeferred_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00008808 File Offset: 0x00006A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151063, XrefRangeEnd = 151087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPurchaseOk(GooglePurchase googlePurchase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePurchase);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseUpdatedListener.NativeMethodInfoPtr_OnPurchaseOk_Private_Void_GooglePurchase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000884C File Offset: 0x00006A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151087, XrefRangeEnd = 151094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeferredProrationUpgradeDowngradeSubscriptionOk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseUpdatedListener.NativeMethodInfoPtr_OnDeferredProrationUpgradeDowngradeSubscriptionOk_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00008880 File Offset: 0x00006A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151094, XrefRangeEnd = 151104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPurchaseCanceled(GooglePurchase googlePurchase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePurchase);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseUpdatedListener.NativeMethodInfoPtr_OnPurchaseCanceled_Private_Void_GooglePurchase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000088C4 File Offset: 0x00006AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151104, XrefRangeEnd = 151114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPurchaseAlreadyOwned(GooglePurchase googlePurchase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePurchase);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseUpdatedListener.NativeMethodInfoPtr_OnPurchaseAlreadyOwned_Private_Void_GooglePurchase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00008908 File Offset: 0x00006B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151114, XrefRangeEnd = 151125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPurchaseFailed(GooglePurchase googlePurchase, string debugMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePurchase);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(debugMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseUpdatedListener.NativeMethodInfoPtr_OnPurchaseFailed_Private_Void_GooglePurchase_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000025EE File Offset: 0x000007EE
		public GooglePurchaseUpdatedListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000895C File Offset: 0x00006B5C
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x000025F7 File Offset: 0x000007F7
		public unsafe IGoogleLastKnownProductService m_LastKnownProductService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseUpdatedListener.NativeFieldInfoPtr_m_LastKnownProductService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGoogleLastKnownProductService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseUpdatedListener.NativeFieldInfoPtr_m_LastKnownProductService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000898C File Offset: 0x00006B8C
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002616 File Offset: 0x00000816
		public unsafe IGooglePurchaseCallback m_GooglePurchaseCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseUpdatedListener.NativeFieldInfoPtr_m_GooglePurchaseCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePurchaseCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseUpdatedListener.NativeFieldInfoPtr_m_GooglePurchaseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000089BC File Offset: 0x00006BBC
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002635 File Offset: 0x00000835
		public unsafe IGoogleCachedQuerySkuDetailsService m_GoogleCachedQuerySkuDetailsService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseUpdatedListener.NativeFieldInfoPtr_m_GoogleCachedQuerySkuDetailsService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGoogleCachedQuerySkuDetailsService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseUpdatedListener.NativeFieldInfoPtr_m_GoogleCachedQuerySkuDetailsService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_m_LastKnownProductService;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_m_GooglePurchaseCallback;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_m_GoogleCachedQuerySkuDetailsService;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IGoogleLastKnownProductService_IGooglePurchaseCallback_IGoogleCachedQuerySkuDetailsService_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_onPurchasesUpdated_Private_Void_AndroidJavaObject_AndroidJavaObject_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_HandleResultOkCases_Private_Void_GoogleBillingResult_AndroidJavaObject_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_HandleErrorCases_Private_Void_GoogleBillingResult_AndroidJavaObject_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_ApplyOnPurchases_Private_Void_AndroidJavaObject_Action_1_GooglePurchase_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_ApplyOnPurchases_Private_Void_AndroidJavaObject_GoogleBillingResult_Action_2_GooglePurchase_String_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_IsLastProrationModeDeferred_Private_Boolean_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseOk_Private_Void_GooglePurchase_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_OnDeferredProrationUpgradeDowngradeSubscriptionOk_Private_Void_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseCanceled_Private_Void_GooglePurchase_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseAlreadyOwned_Private_Void_GooglePurchase_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseFailed_Private_Void_GooglePurchase_String_0;
	}
}

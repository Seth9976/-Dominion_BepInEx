using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x0200008F RID: 143
	public class IGooglePlayStoreService : Il2CppObjectBase
	{
		// Token: 0x06000599 RID: 1433 RVA: 0x00018598 File Offset: 0x00016798
		// Note: this type is marked as 'beforefieldinit'.
		static IGooglePlayStoreService()
		{
			Il2CppClassPointerStore<IGooglePlayStoreService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Interfaces", "IGooglePlayStoreService");
			IGooglePlayStoreService.NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_ProductDescription_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePlayStoreService>.NativeClassPtr, 100663978);
			IGooglePlayStoreService.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePlayStoreService>.NativeClassPtr, 100663979);
			IGooglePlayStoreService.NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_ProductDefinition_String_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePlayStoreService>.NativeClassPtr, 100663980);
			IGooglePlayStoreService.NativeMethodInfoPtr_FetchPurchases_Public_Abstract_Virtual_New_Void_Action_1_List_1_GooglePurchase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePlayStoreService>.NativeClassPtr, 100663981);
			IGooglePlayStoreService.NativeMethodInfoPtr_ResumeConnection_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePlayStoreService>.NativeClassPtr, 100663982);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00018624 File Offset: 0x00016824
		[CallerCount(0)]
		public unsafe virtual void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onProductsReceived, Action onRetrieveProductFailed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onProductsReceived);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onRetrieveProductFailed);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePlayStoreService.NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_ProductDescription_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00018698 File Offset: 0x00016898
		[CallerCount(0)]
		public unsafe virtual void Purchase(ProductDefinition product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePlayStoreService.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_ProductDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x000186E8 File Offset: 0x000168E8
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePlayStoreService.NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_ProductDefinition_String_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0001876C File Offset: 0x0001696C
		[CallerCount(0)]
		public unsafe virtual void FetchPurchases(Action<List<GooglePurchase>> onQueryPurchaseSucceed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onQueryPurchaseSucceed);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePlayStoreService.NativeMethodInfoPtr_FetchPurchases_Public_Abstract_Virtual_New_Void_Action_1_List_1_GooglePurchase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x000187BC File Offset: 0x000169BC
		[CallerCount(0)]
		public unsafe virtual void ResumeConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePlayStoreService.NativeMethodInfoPtr_ResumeConnection_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00004D16 File Offset: 0x00002F16
		public IGooglePlayStoreService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_ProductDescription_Action_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_ProductDefinition_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_ProductDefinition_String_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_FetchPurchases_Public_Abstract_Virtual_New_Void_Action_1_List_1_GooglePurchase_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_ResumeConnection_Public_Abstract_Virtual_New_Void_0;
	}
}

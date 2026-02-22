using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x0200008C RID: 140
	public class IGoogleBillingClient : Il2CppObjectBase
	{
		// Token: 0x06000588 RID: 1416 RVA: 0x00018030 File Offset: 0x00016230
		// Note: this type is marked as 'beforefieldinit'.
		static IGoogleBillingClient()
		{
			Il2CppClassPointerStore<IGoogleBillingClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Interfaces", "IGoogleBillingClient");
			IGoogleBillingClient.NativeMethodInfoPtr_StartConnection_Public_Abstract_Virtual_New_Void_IBillingClientStateListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGoogleBillingClient>.NativeClassPtr, 100663967);
			IGoogleBillingClient.NativeMethodInfoPtr_QueryPurchase_Public_Abstract_Virtual_New_AndroidJavaObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGoogleBillingClient>.NativeClassPtr, 100663968);
			IGoogleBillingClient.NativeMethodInfoPtr_QuerySkuDetailsAsync_Public_Abstract_Virtual_New_Void_AndroidJavaObject_SkuDetailsResponseListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGoogleBillingClient>.NativeClassPtr, 100663969);
			IGoogleBillingClient.NativeMethodInfoPtr_LaunchBillingFlow_Public_Abstract_Virtual_New_AndroidJavaObject_AndroidJavaObject_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGoogleBillingClient>.NativeClassPtr, 100663970);
			IGoogleBillingClient.NativeMethodInfoPtr_ConsumeAsync_Public_Abstract_Virtual_New_Void_String_ProductDefinition_GooglePurchase_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGoogleBillingClient>.NativeClassPtr, 100663971);
			IGoogleBillingClient.NativeMethodInfoPtr_AcknowledgePurchase_Public_Abstract_Virtual_New_Void_String_ProductDefinition_GooglePurchase_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGoogleBillingClient>.NativeClassPtr, 100663972);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x000180D0 File Offset: 0x000162D0
		[CallerCount(0)]
		public unsafe virtual void StartConnection(IBillingClientStateListener billingClientStateListener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingClientStateListener);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGoogleBillingClient.NativeMethodInfoPtr_StartConnection_Public_Abstract_Virtual_New_Void_IBillingClientStateListener_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00018120 File Offset: 0x00016320
		[CallerCount(0)]
		public unsafe virtual AndroidJavaObject QueryPurchase(string skuType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(skuType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGoogleBillingClient.NativeMethodInfoPtr_QueryPurchase_Public_Abstract_Virtual_New_AndroidJavaObject_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0001817C File Offset: 0x0001637C
		[CallerCount(0)]
		public unsafe virtual void QuerySkuDetailsAsync(AndroidJavaObject skuDetailsParamsBuilder, SkuDetailsResponseListener listener)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(skuDetailsParamsBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGoogleBillingClient.NativeMethodInfoPtr_QuerySkuDetailsAsync_Public_Abstract_Virtual_New_Void_AndroidJavaObject_SkuDetailsResponseListener_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x000181DC File Offset: 0x000163DC
		[CallerCount(0)]
		public unsafe virtual AndroidJavaObject LaunchBillingFlow(AndroidJavaObject sku, string oldSku, string oldPurchaseToken, int prorationMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sku);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldSku);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldPurchaseToken);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prorationMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGoogleBillingClient.NativeMethodInfoPtr_LaunchBillingFlow_Public_Abstract_Virtual_New_AndroidJavaObject_AndroidJavaObject_String_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0001826C File Offset: 0x0001646C
		[CallerCount(0)]
		public unsafe virtual void ConsumeAsync(string purchaseToken, ProductDefinition product, GooglePurchase googlePurchase, Action<ProductDefinition, GooglePurchase, GoogleBillingResult, string> onConsume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(purchaseToken);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePurchase);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onConsume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGoogleBillingClient.NativeMethodInfoPtr_ConsumeAsync_Public_Abstract_Virtual_New_Void_String_ProductDefinition_GooglePurchase_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x000182F0 File Offset: 0x000164F0
		[CallerCount(0)]
		public unsafe virtual void AcknowledgePurchase(string purchaseToken, ProductDefinition product, GooglePurchase googlePurchase, Action<ProductDefinition, GooglePurchase, GoogleBillingResult> onAcknowledge)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(purchaseToken);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePurchase);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onAcknowledge);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGoogleBillingClient.NativeMethodInfoPtr_AcknowledgePurchase_Public_Abstract_Virtual_New_Void_String_ProductDefinition_GooglePurchase_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00004CCC File Offset: 0x00002ECC
		public IGoogleBillingClient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_StartConnection_Public_Abstract_Virtual_New_Void_IBillingClientStateListener_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_QueryPurchase_Public_Abstract_Virtual_New_AndroidJavaObject_String_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_QuerySkuDetailsAsync_Public_Abstract_Virtual_New_Void_AndroidJavaObject_SkuDetailsResponseListener_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_LaunchBillingFlow_Public_Abstract_Virtual_New_AndroidJavaObject_AndroidJavaObject_String_String_Int32_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeAsync_Public_Abstract_Virtual_New_Void_String_ProductDefinition_GooglePurchase_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_AcknowledgePurchase_Public_Abstract_Virtual_New_Void_String_ProductDefinition_GooglePurchase_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0;
	}
}

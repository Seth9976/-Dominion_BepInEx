using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x02000090 RID: 144
	public class IGooglePurchaseCallback : Il2CppObjectBase
	{
		// Token: 0x060005A0 RID: 1440 RVA: 0x000187F8 File Offset: 0x000169F8
		// Note: this type is marked as 'beforefieldinit'.
		static IGooglePurchaseCallback()
		{
			Il2CppClassPointerStore<IGooglePurchaseCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Interfaces", "IGooglePurchaseCallback");
			IGooglePurchaseCallback.NativeMethodInfoPtr_SetStoreCallback_Public_Abstract_Virtual_New_Void_IStoreCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePurchaseCallback>.NativeClassPtr, 100663983);
			IGooglePurchaseCallback.NativeMethodInfoPtr_SetStoreExtension_Public_Abstract_Virtual_New_Void_IGooglePlayStoreExtensionsInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePurchaseCallback>.NativeClassPtr, 100663984);
			IGooglePurchaseCallback.NativeMethodInfoPtr_OnPurchaseSuccessful_Public_Abstract_Virtual_New_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePurchaseCallback>.NativeClassPtr, 100663985);
			IGooglePurchaseCallback.NativeMethodInfoPtr_OnPurchaseFailed_Public_Abstract_Virtual_New_Void_PurchaseFailureDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePurchaseCallback>.NativeClassPtr, 100663986);
			IGooglePurchaseCallback.NativeMethodInfoPtr_NotifyDeferredPurchase_Public_Abstract_Virtual_New_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePurchaseCallback>.NativeClassPtr, 100663987);
			IGooglePurchaseCallback.NativeMethodInfoPtr_NotifyDeferredProrationUpgradeDowngradeSubscription_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePurchaseCallback>.NativeClassPtr, 100663988);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00018898 File Offset: 0x00016A98
		[CallerCount(0)]
		public unsafe virtual void SetStoreCallback(IStoreCallback storeCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePurchaseCallback.NativeMethodInfoPtr_SetStoreCallback_Public_Abstract_Virtual_New_Void_IStoreCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x000188E8 File Offset: 0x00016AE8
		[CallerCount(0)]
		public unsafe virtual void SetStoreExtension(IGooglePlayStoreExtensionsInternal extensions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extensions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePurchaseCallback.NativeMethodInfoPtr_SetStoreExtension_Public_Abstract_Virtual_New_Void_IGooglePlayStoreExtensionsInternal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00018938 File Offset: 0x00016B38
		[CallerCount(0)]
		public unsafe virtual void OnPurchaseSuccessful(string sku, string receipt, string purchaseToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sku);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receipt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(purchaseToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePurchaseCallback.NativeMethodInfoPtr_OnPurchaseSuccessful_Public_Abstract_Virtual_New_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000189AC File Offset: 0x00016BAC
		[CallerCount(0)]
		public unsafe virtual void OnPurchaseFailed(PurchaseFailureDescription purchaseFailureDescription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchaseFailureDescription);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePurchaseCallback.NativeMethodInfoPtr_OnPurchaseFailed_Public_Abstract_Virtual_New_Void_PurchaseFailureDescription_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x000189FC File Offset: 0x00016BFC
		[CallerCount(0)]
		public unsafe virtual void NotifyDeferredPurchase(string sku, string receipt, string purchaseToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sku);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receipt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(purchaseToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePurchaseCallback.NativeMethodInfoPtr_NotifyDeferredPurchase_Public_Abstract_Virtual_New_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00018A70 File Offset: 0x00016C70
		[CallerCount(0)]
		public unsafe virtual void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sku);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePurchaseCallback.NativeMethodInfoPtr_NotifyDeferredProrationUpgradeDowngradeSubscription_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00004D1F File Offset: 0x00002F1F
		public IGooglePurchaseCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_SetStoreCallback_Public_Abstract_Virtual_New_Void_IStoreCallback_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr_SetStoreExtension_Public_Abstract_Virtual_New_Void_IGooglePlayStoreExtensionsInternal_0;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseSuccessful_Public_Abstract_Virtual_New_Void_String_String_String_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseFailed_Public_Abstract_Virtual_New_Void_PurchaseFailureDescription_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDeferredPurchase_Public_Abstract_Virtual_New_Void_String_String_String_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDeferredProrationUpgradeDowngradeSubscription_Public_Abstract_Virtual_New_Void_String_0;
	}
}

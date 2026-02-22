using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x02000025 RID: 37
	public class IStoreCallback : Il2CppObjectBase
	{
		// Token: 0x06000147 RID: 327 RVA: 0x00007970 File Offset: 0x00005B70
		// Note: this type is marked as 'beforefieldinit'.
		static IStoreCallback()
		{
			Il2CppClassPointerStore<IStoreCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing.Extension", "IStoreCallback");
			IStoreCallback.NativeMethodInfoPtr_get_products_Public_Abstract_Virtual_New_get_ProductCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStoreCallback>.NativeClassPtr, 100663467);
			IStoreCallback.NativeMethodInfoPtr_OnSetupFailed_Public_Abstract_Virtual_New_Void_InitializationFailureReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStoreCallback>.NativeClassPtr, 100663468);
			IStoreCallback.NativeMethodInfoPtr_OnProductsRetrieved_Public_Abstract_Virtual_New_Void_List_1_ProductDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStoreCallback>.NativeClassPtr, 100663469);
			IStoreCallback.NativeMethodInfoPtr_OnPurchaseSucceeded_Public_Abstract_Virtual_New_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStoreCallback>.NativeClassPtr, 100663470);
			IStoreCallback.NativeMethodInfoPtr_OnAllPurchasesRetrieved_Public_Abstract_Virtual_New_Void_List_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStoreCallback>.NativeClassPtr, 100663471);
			IStoreCallback.NativeMethodInfoPtr_OnPurchaseFailed_Public_Abstract_Virtual_New_Void_PurchaseFailureDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStoreCallback>.NativeClassPtr, 100663472);
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00007A10 File Offset: 0x00005C10
		public unsafe virtual ProductCollection products
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStoreCallback.NativeMethodInfoPtr_get_products_Public_Abstract_Virtual_New_get_ProductCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00007A5C File Offset: 0x00005C5C
		[CallerCount(0)]
		public unsafe virtual void OnSetupFailed(InitializationFailureReason reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reason;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStoreCallback.NativeMethodInfoPtr_OnSetupFailed_Public_Abstract_Virtual_New_Void_InitializationFailureReason_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00007AA8 File Offset: 0x00005CA8
		[CallerCount(0)]
		public unsafe virtual void OnProductsRetrieved(List<ProductDescription> products)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStoreCallback.NativeMethodInfoPtr_OnProductsRetrieved_Public_Abstract_Virtual_New_Void_List_1_ProductDescription_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00007AF8 File Offset: 0x00005CF8
		[CallerCount(0)]
		public unsafe virtual void OnPurchaseSucceeded(string storeSpecificId, string receipt, string transactionIdentifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(storeSpecificId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receipt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionIdentifier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStoreCallback.NativeMethodInfoPtr_OnPurchaseSucceeded_Public_Abstract_Virtual_New_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00007B6C File Offset: 0x00005D6C
		[CallerCount(0)]
		public unsafe virtual void OnAllPurchasesRetrieved(List<Product> purchasedProducts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchasedProducts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStoreCallback.NativeMethodInfoPtr_OnAllPurchasesRetrieved_Public_Abstract_Virtual_New_Void_List_1_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00007BBC File Offset: 0x00005DBC
		[CallerCount(0)]
		public unsafe virtual void OnPurchaseFailed(PurchaseFailureDescription desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStoreCallback.NativeMethodInfoPtr_OnPurchaseFailed_Public_Abstract_Virtual_New_Void_PurchaseFailureDescription_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000028DD File Offset: 0x00000ADD
		public IStoreCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_get_products_Public_Abstract_Virtual_New_get_ProductCollection_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_OnSetupFailed_Public_Abstract_Virtual_New_Void_InitializationFailureReason_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_OnProductsRetrieved_Public_Abstract_Virtual_New_Void_List_1_ProductDescription_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseSucceeded_Public_Abstract_Virtual_New_Void_String_String_String_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_OnAllPurchasesRetrieved_Public_Abstract_Virtual_New_Void_List_1_Product_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseFailed_Public_Abstract_Virtual_New_Void_PurchaseFailureDescription_0;
	}
}

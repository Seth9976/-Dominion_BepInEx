using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001D RID: 29
	public static class ProductPurchaseUpdater : Object
	{
		// Token: 0x0600011E RID: 286 RVA: 0x000027A6 File Offset: 0x000009A6
		// Note: this type is marked as 'beforefieldinit'.
		static ProductPurchaseUpdater()
		{
			Il2CppClassPointerStore<ProductPurchaseUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "ProductPurchaseUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductPurchaseUpdater>.NativeClassPtr);
			ProductPurchaseUpdater.NativeMethodInfoPtr_UpdateProductReceiptAndTransactionID_Internal_Static_Void_Product_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductPurchaseUpdater>.NativeClassPtr, 100663444);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00006EE0 File Offset: 0x000050E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131302, RefRangeEnd = 131304, XrefRangeStart = 131301, XrefRangeEnd = 131302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateProductReceiptAndTransactionID(Product product, string receipt, string transactionId, string storeName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receipt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(storeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductPurchaseUpdater.NativeMethodInfoPtr_UpdateProductReceiptAndTransactionID_Internal_Static_Void_Product_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000027DF File Offset: 0x000009DF
		public ProductPurchaseUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_UpdateProductReceiptAndTransactionID_Internal_Static_Void_Product_String_String_String_0;
	}
}

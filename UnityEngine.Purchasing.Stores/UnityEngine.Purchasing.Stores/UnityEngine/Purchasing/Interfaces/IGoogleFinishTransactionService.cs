using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x0200008D RID: 141
	public class IGoogleFinishTransactionService : Il2CppObjectBase
	{
		// Token: 0x06000590 RID: 1424 RVA: 0x00004CD5 File Offset: 0x00002ED5
		// Note: this type is marked as 'beforefieldinit'.
		static IGoogleFinishTransactionService()
		{
			Il2CppClassPointerStore<IGoogleFinishTransactionService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Interfaces", "IGoogleFinishTransactionService");
			IGoogleFinishTransactionService.NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_ProductDefinition_String_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGoogleFinishTransactionService>.NativeClassPtr, 100663973);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00018374 File Offset: 0x00016574
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGoogleFinishTransactionService.NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_ProductDefinition_String_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00004D04 File Offset: 0x00002F04
		public IGoogleFinishTransactionService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_ProductDefinition_String_Action_4_ProductDefinition_GooglePurchase_GoogleBillingResult_String_Action_3_ProductDefinition_GooglePurchase_GoogleBillingResult_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000029 RID: 41
	public class IGooglePlayStoreFinishTransactionService : Il2CppObjectBase
	{
		// Token: 0x0600015C RID: 348 RVA: 0x0000A618 File Offset: 0x00008818
		// Note: this type is marked as 'beforefieldinit'.
		static IGooglePlayStoreFinishTransactionService()
		{
			Il2CppClassPointerStore<IGooglePlayStoreFinishTransactionService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "IGooglePlayStoreFinishTransactionService");
			IGooglePlayStoreFinishTransactionService.NativeMethodInfoPtr_SetStoreCallback_Public_Abstract_Virtual_New_Void_IStoreCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePlayStoreFinishTransactionService>.NativeClassPtr, 100663461);
			IGooglePlayStoreFinishTransactionService.NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePlayStoreFinishTransactionService>.NativeClassPtr, 100663462);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000A668 File Offset: 0x00008868
		[CallerCount(0)]
		public unsafe virtual void SetStoreCallback(IStoreCallback storeCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePlayStoreFinishTransactionService.NativeMethodInfoPtr_SetStoreCallback_Public_Abstract_Virtual_New_Void_IStoreCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000A6B8 File Offset: 0x000088B8
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePlayStoreFinishTransactionService.NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_ProductDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002A86 File Offset: 0x00000C86
		public IGooglePlayStoreFinishTransactionService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_SetStoreCallback_Public_Abstract_Virtual_New_Void_IStoreCallback_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_ProductDefinition_String_0;
	}
}

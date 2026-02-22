using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000028 RID: 40
	public class IGoogleFetchPurchases : Il2CppObjectBase
	{
		// Token: 0x06000157 RID: 343 RVA: 0x0000A4D8 File Offset: 0x000086D8
		// Note: this type is marked as 'beforefieldinit'.
		static IGoogleFetchPurchases()
		{
			Il2CppClassPointerStore<IGoogleFetchPurchases>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "IGoogleFetchPurchases");
			IGoogleFetchPurchases.NativeMethodInfoPtr_SetStoreCallback_Public_Abstract_Virtual_New_Void_IStoreCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGoogleFetchPurchases>.NativeClassPtr, 100663458);
			IGoogleFetchPurchases.NativeMethodInfoPtr_FetchPurchases_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGoogleFetchPurchases>.NativeClassPtr, 100663459);
			IGoogleFetchPurchases.NativeMethodInfoPtr_FetchPurchases_Public_Abstract_Virtual_New_Void_Action_1_List_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGoogleFetchPurchases>.NativeClassPtr, 100663460);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000A53C File Offset: 0x0000873C
		[CallerCount(0)]
		public unsafe virtual void SetStoreCallback(IStoreCallback storeCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGoogleFetchPurchases.NativeMethodInfoPtr_SetStoreCallback_Public_Abstract_Virtual_New_Void_IStoreCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000A58C File Offset: 0x0000878C
		[CallerCount(0)]
		public unsafe virtual void FetchPurchases()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGoogleFetchPurchases.NativeMethodInfoPtr_FetchPurchases_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000A5C8 File Offset: 0x000087C8
		[CallerCount(0)]
		public unsafe virtual void FetchPurchases(Action<List<Product>> onQueryPurchaseSucceed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onQueryPurchaseSucceed);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGoogleFetchPurchases.NativeMethodInfoPtr_FetchPurchases_Public_Abstract_Virtual_New_Void_Action_1_List_1_Product_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002A7D File Offset: 0x00000C7D
		public IGoogleFetchPurchases(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_SetStoreCallback_Public_Abstract_Virtual_New_Void_IStoreCallback_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_FetchPurchases_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_FetchPurchases_Public_Abstract_Virtual_New_Void_Action_1_List_1_Product_0;
	}
}

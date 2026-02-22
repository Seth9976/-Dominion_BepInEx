using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.ObjectModel;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200002B RID: 43
	public class IGooglePlayStoreRetrieveProductsService : Il2CppObjectBase
	{
		// Token: 0x06000163 RID: 355 RVA: 0x0000A768 File Offset: 0x00008968
		// Note: this type is marked as 'beforefieldinit'.
		static IGooglePlayStoreRetrieveProductsService()
		{
			Il2CppClassPointerStore<IGooglePlayStoreRetrieveProductsService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "IGooglePlayStoreRetrieveProductsService");
			IGooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr_SetStoreCallback_Public_Abstract_Virtual_New_Void_IStoreCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePlayStoreRetrieveProductsService>.NativeClassPtr, 100663464);
			IGooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_ReadOnlyCollection_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePlayStoreRetrieveProductsService>.NativeClassPtr, 100663465);
			IGooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr_ResumeConnection_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePlayStoreRetrieveProductsService>.NativeClassPtr, 100663466);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000A7CC File Offset: 0x000089CC
		[CallerCount(0)]
		public unsafe virtual void SetStoreCallback(IStoreCallback storeCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr_SetStoreCallback_Public_Abstract_Virtual_New_Void_IStoreCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000A81C File Offset: 0x00008A1C
		[CallerCount(0)]
		public unsafe virtual void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_ReadOnlyCollection_1_ProductDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000A86C File Offset: 0x00008A6C
		[CallerCount(0)]
		public unsafe virtual void ResumeConnection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePlayStoreRetrieveProductsService.NativeMethodInfoPtr_ResumeConnection_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002AC7 File Offset: 0x00000CC7
		public IGooglePlayStoreRetrieveProductsService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_SetStoreCallback_Public_Abstract_Virtual_New_Void_IStoreCallback_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_ReadOnlyCollection_1_ProductDefinition_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_ResumeConnection_Public_Abstract_Virtual_New_Void_0;
	}
}

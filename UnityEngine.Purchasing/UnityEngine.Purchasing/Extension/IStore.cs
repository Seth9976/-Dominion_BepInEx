using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.ObjectModel;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x02000024 RID: 36
	public class IStore : Il2CppObjectBase
	{
		// Token: 0x06000141 RID: 321 RVA: 0x00007798 File Offset: 0x00005998
		// Note: this type is marked as 'beforefieldinit'.
		static IStore()
		{
			Il2CppClassPointerStore<IStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing.Extension", "IStore");
			IStore.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_IStoreCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStore>.NativeClassPtr, 100663463);
			IStore.NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_ReadOnlyCollection_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStore>.NativeClassPtr, 100663464);
			IStore.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStore>.NativeClassPtr, 100663465);
			IStore.NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStore>.NativeClassPtr, 100663466);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00007810 File Offset: 0x00005A10
		[CallerCount(0)]
		public unsafe virtual void Initialize(IStoreCallback callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStore.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_IStoreCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00007860 File Offset: 0x00005A60
		[CallerCount(0)]
		public unsafe virtual void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStore.NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_ReadOnlyCollection_1_ProductDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000078B0 File Offset: 0x00005AB0
		[CallerCount(0)]
		public unsafe virtual void Purchase(ProductDefinition product, string developerPayload)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(developerPayload);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStore.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_ProductDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00007910 File Offset: 0x00005B10
		[CallerCount(0)]
		public unsafe virtual void FinishTransaction(ProductDefinition product, string transactionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStore.NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_ProductDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000028D4 File Offset: 0x00000AD4
		public IStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_IStoreCallback_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_ReadOnlyCollection_1_ProductDefinition_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_ProductDefinition_String_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_ProductDefinition_String_0;
	}
}

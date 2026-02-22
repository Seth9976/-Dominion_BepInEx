using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.ObjectModel;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x02000020 RID: 32
	public class AbstractStore : Object
	{
		// Token: 0x0600012E RID: 302 RVA: 0x00007298 File Offset: 0x00005498
		// Note: this type is marked as 'beforefieldinit'.
		static AbstractStore()
		{
			Il2CppClassPointerStore<AbstractStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing.Extension", "AbstractStore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbstractStore>.NativeClassPtr);
			AbstractStore.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_IStoreCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractStore>.NativeClassPtr, 100663452);
			AbstractStore.NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_ReadOnlyCollection_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractStore>.NativeClassPtr, 100663453);
			AbstractStore.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractStore>.NativeClassPtr, 100663454);
			AbstractStore.NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractStore>.NativeClassPtr, 100663455);
			AbstractStore.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractStore>.NativeClassPtr, 100663456);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000732C File Offset: 0x0000552C
		[CallerCount(0)]
		public unsafe virtual void Initialize(IStoreCallback callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractStore.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_IStoreCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000737C File Offset: 0x0000557C
		[CallerCount(0)]
		public unsafe virtual void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractStore.NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_ReadOnlyCollection_1_ProductDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000073CC File Offset: 0x000055CC
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractStore.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_ProductDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000742C File Offset: 0x0000562C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractStore.NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_ProductDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000748C File Offset: 0x0000568C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbstractStore()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbstractStore>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractStore.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002852 File Offset: 0x00000A52
		public AbstractStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_IStoreCallback_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_ReadOnlyCollection_1_ProductDefinition_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_ProductDefinition_String_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_ProductDefinition_String_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

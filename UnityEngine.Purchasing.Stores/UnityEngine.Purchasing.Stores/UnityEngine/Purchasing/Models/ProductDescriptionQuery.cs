using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing.Models
{
	// Token: 0x0200008A RID: 138
	public class ProductDescriptionQuery : Object
	{
		// Token: 0x0600057B RID: 1403 RVA: 0x00017DC0 File Offset: 0x00015FC0
		// Note: this type is marked as 'beforefieldinit'.
		static ProductDescriptionQuery()
		{
			Il2CppClassPointerStore<ProductDescriptionQuery>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Models", "ProductDescriptionQuery");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductDescriptionQuery>.NativeClassPtr);
			ProductDescriptionQuery.NativeFieldInfoPtr_products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDescriptionQuery>.NativeClassPtr, "products");
			ProductDescriptionQuery.NativeFieldInfoPtr_onProductsReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDescriptionQuery>.NativeClassPtr, "onProductsReceived");
			ProductDescriptionQuery.NativeFieldInfoPtr_onRetrieveProductsFailed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDescriptionQuery>.NativeClassPtr, "onRetrieveProductsFailed");
			ProductDescriptionQuery.NativeMethodInfoPtr__ctor_Internal_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_ProductDescription_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDescriptionQuery>.NativeClassPtr, 100663964);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00017E40 File Offset: 0x00016040
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150611, RefRangeEnd = 150613, XrefRangeStart = 150611, XrefRangeEnd = 150613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductDescriptionQuery(ReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onProductsReceived, Action onRetrieveProductsFailed)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductDescriptionQuery>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onProductsReceived);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onRetrieveProductsFailed);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDescriptionQuery.NativeMethodInfoPtr__ctor_Internal_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_ProductDescription_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00004C5D File Offset: 0x00002E5D
		public ProductDescriptionQuery(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x00017EB0 File Offset: 0x000160B0
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x00004C66 File Offset: 0x00002E66
		public unsafe ReadOnlyCollection<ProductDefinition> products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDescriptionQuery.NativeFieldInfoPtr_products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDescriptionQuery.NativeFieldInfoPtr_products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x00017EE0 File Offset: 0x000160E0
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x00004C85 File Offset: 0x00002E85
		public unsafe Action<List<ProductDescription>> onProductsReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDescriptionQuery.NativeFieldInfoPtr_onProductsReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<List<ProductDescription>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDescriptionQuery.NativeFieldInfoPtr_onProductsReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x00017F10 File Offset: 0x00016110
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x00004CA4 File Offset: 0x00002EA4
		public unsafe Action onRetrieveProductsFailed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDescriptionQuery.NativeFieldInfoPtr_onRetrieveProductsFailed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDescriptionQuery.NativeFieldInfoPtr_onRetrieveProductsFailed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeFieldInfoPtr_products;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeFieldInfoPtr_onProductsReceived;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeFieldInfoPtr_onRetrieveProductsFailed;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_ProductDescription_Action_0;
	}
}

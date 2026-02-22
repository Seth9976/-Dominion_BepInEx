using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200006A RID: 106
	[Serializable]
	public class ProductCatalogItem : Object
	{
		// Token: 0x060003BC RID: 956 RVA: 0x00012260 File Offset: 0x00010460
		// Note: this type is marked as 'beforefieldinit'.
		static ProductCatalogItem()
		{
			Il2CppClassPointerStore<ProductCatalogItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "ProductCatalogItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductCatalogItem>.NativeClassPtr);
			ProductCatalogItem.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductCatalogItem>.NativeClassPtr, "id");
			ProductCatalogItem.NativeFieldInfoPtr_storeIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductCatalogItem>.NativeClassPtr, "storeIDs");
			ProductCatalogItem.NativeFieldInfoPtr_defaultDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductCatalogItem>.NativeClassPtr, "defaultDescription");
			ProductCatalogItem.NativeFieldInfoPtr_googlePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductCatalogItem>.NativeClassPtr, "googlePrice");
			ProductCatalogItem.NativeFieldInfoPtr_descriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductCatalogItem>.NativeClassPtr, "descriptions");
			ProductCatalogItem.NativeFieldInfoPtr_udpPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductCatalogItem>.NativeClassPtr, "udpPrice");
			ProductCatalogItem.NativeFieldInfoPtr_payouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductCatalogItem>.NativeClassPtr, "payouts");
			ProductCatalogItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCatalogItem>.NativeClassPtr, 100663759);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00012330 File Offset: 0x00010530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155006, XrefRangeEnd = 155036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductCatalogItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductCatalogItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCatalogItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00003E5C File Offset: 0x0000205C
		public ProductCatalogItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0001236C File Offset: 0x0001056C
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x00003E65 File Offset: 0x00002065
		public unsafe string id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogItem.NativeFieldInfoPtr_id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogItem.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x00012394 File Offset: 0x00010594
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x00003E84 File Offset: 0x00002084
		public unsafe List<StoreID> storeIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogItem.NativeFieldInfoPtr_storeIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StoreID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogItem.NativeFieldInfoPtr_storeIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x000123C4 File Offset: 0x000105C4
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x00003EA3 File Offset: 0x000020A3
		public unsafe LocalizedProductDescription defaultDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogItem.NativeFieldInfoPtr_defaultDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedProductDescription>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogItem.NativeFieldInfoPtr_defaultDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x000123F4 File Offset: 0x000105F4
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x00003EC2 File Offset: 0x000020C2
		public unsafe Price googlePrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogItem.NativeFieldInfoPtr_googlePrice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Price>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogItem.NativeFieldInfoPtr_googlePrice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00012424 File Offset: 0x00010624
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x00003EE1 File Offset: 0x000020E1
		public unsafe List<LocalizedProductDescription> descriptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogItem.NativeFieldInfoPtr_descriptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LocalizedProductDescription>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogItem.NativeFieldInfoPtr_descriptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00012454 File Offset: 0x00010654
		// (set) Token: 0x060003CA RID: 970 RVA: 0x00003F00 File Offset: 0x00002100
		public unsafe Price udpPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogItem.NativeFieldInfoPtr_udpPrice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Price>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogItem.NativeFieldInfoPtr_udpPrice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00012484 File Offset: 0x00010684
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00003F1F File Offset: 0x0000211F
		public unsafe List<ProductCatalogPayout> payouts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogItem.NativeFieldInfoPtr_payouts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductCatalogPayout>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogItem.NativeFieldInfoPtr_payouts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeFieldInfoPtr_storeIDs;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeFieldInfoPtr_defaultDescription;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeFieldInfoPtr_googlePrice;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeFieldInfoPtr_descriptions;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeFieldInfoPtr_udpPrice;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeFieldInfoPtr_payouts;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

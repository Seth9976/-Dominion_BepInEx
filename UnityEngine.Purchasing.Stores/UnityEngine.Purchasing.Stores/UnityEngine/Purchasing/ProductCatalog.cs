using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200006B RID: 107
	[Serializable]
	public class ProductCatalog : Object
	{
		// Token: 0x060003CD RID: 973 RVA: 0x000124B4 File Offset: 0x000106B4
		// Note: this type is marked as 'beforefieldinit'.
		static ProductCatalog()
		{
			Il2CppClassPointerStore<ProductCatalog>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "ProductCatalog");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductCatalog>.NativeClassPtr);
			ProductCatalog.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductCatalog>.NativeClassPtr, "instance");
			ProductCatalog.NativeFieldInfoPtr_products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductCatalog>.NativeClassPtr, "products");
			ProductCatalog.NativeMethodInfoPtr_get_allProducts_Public_get_ICollection_1_ProductCatalogItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCatalog>.NativeClassPtr, 100663760);
			ProductCatalog.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCatalog>.NativeClassPtr, 100663761);
			ProductCatalog.NativeMethodInfoPtr_Initialize_Public_Static_Void_IProductCatalogImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCatalog>.NativeClassPtr, 100663762);
			ProductCatalog.NativeMethodInfoPtr_Deserialize_Public_Static_ProductCatalog_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCatalog>.NativeClassPtr, 100663763);
			ProductCatalog.NativeMethodInfoPtr_FromTextAsset_Public_Static_ProductCatalog_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCatalog>.NativeClassPtr, 100663764);
			ProductCatalog.NativeMethodInfoPtr_LoadDefaultCatalog_Public_Static_ProductCatalog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCatalog>.NativeClassPtr, 100663765);
			ProductCatalog.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCatalog>.NativeClassPtr, 100663766);
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00012598 File Offset: 0x00010798
		public unsafe ICollection<ProductCatalogItem> allProducts
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCatalog.NativeMethodInfoPtr_get_allProducts_Public_get_ICollection_1_ProductCatalogItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<ProductCatalogItem>>(intPtr3) : null;
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000125D8 File Offset: 0x000107D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155036, XrefRangeEnd = 155044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCatalog.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00012600 File Offset: 0x00010800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155044, XrefRangeEnd = 155046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(IProductCatalogImpl productCatalogImpl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(productCatalogImpl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCatalog.NativeMethodInfoPtr_Initialize_Public_Static_Void_IProductCatalogImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00012638 File Offset: 0x00010838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155046, XrefRangeEnd = 155049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProductCatalog Deserialize(string catalogJSON)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(catalogJSON);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCatalog.NativeMethodInfoPtr_Deserialize_Public_Static_ProductCatalog_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductCatalog>(intPtr3) : null;
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0001267C File Offset: 0x0001087C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155049, XrefRangeEnd = 155054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProductCatalog FromTextAsset(TextAsset asset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCatalog.NativeMethodInfoPtr_FromTextAsset_Public_Static_ProductCatalog_TextAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductCatalog>(intPtr3) : null;
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000126C0 File Offset: 0x000108C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155068, RefRangeEnd = 155069, XrefRangeStart = 155054, XrefRangeEnd = 155068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProductCatalog LoadDefaultCatalog()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCatalog.NativeMethodInfoPtr_LoadDefaultCatalog_Public_Static_ProductCatalog_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductCatalog>(intPtr3) : null;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x000126F4 File Offset: 0x000108F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155069, XrefRangeEnd = 155076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductCatalog()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductCatalog>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCatalog.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00003F3E File Offset: 0x0000213E
		public ProductCatalog(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00012730 File Offset: 0x00010930
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00003F47 File Offset: 0x00002147
		public unsafe static IProductCatalogImpl instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProductCatalog.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IProductCatalogImpl>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProductCatalog.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00012758 File Offset: 0x00010958
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x00003F59 File Offset: 0x00002159
		public unsafe List<ProductCatalogItem> products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalog.NativeFieldInfoPtr_products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductCatalogItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalog.NativeFieldInfoPtr_products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeFieldInfoPtr_products;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_get_allProducts_Public_get_ICollection_1_ProductCatalogItem_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_IProductCatalogImpl_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_ProductCatalog_String_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_FromTextAsset_Public_Static_ProductCatalog_TextAsset_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_LoadDefaultCatalog_Public_Static_ProductCatalog_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

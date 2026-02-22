using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000004 RID: 4
	public class ConfigurationBuilder : Object
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002F14 File Offset: 0x00001114
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurationBuilder()
		{
			Il2CppClassPointerStore<ConfigurationBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "ConfigurationBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationBuilder>.NativeClassPtr);
			ConfigurationBuilder.NativeFieldInfoPtr_m_Factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationBuilder>.NativeClassPtr, "m_Factory");
			ConfigurationBuilder.NativeFieldInfoPtr_m_Products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationBuilder>.NativeClassPtr, "m_Products");
			ConfigurationBuilder.NativeFieldInfoPtr__useCatalogProvider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationBuilder>.NativeClassPtr, "<useCatalogProvider>k__BackingField");
			ConfigurationBuilder.NativeMethodInfoPtr__ctor_Internal_Void_PurchasingFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationBuilder>.NativeClassPtr, 100663305);
			ConfigurationBuilder.NativeMethodInfoPtr_get_useCatalogProvider_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationBuilder>.NativeClassPtr, 100663306);
			ConfigurationBuilder.NativeMethodInfoPtr_get_products_Public_get_HashSet_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationBuilder>.NativeClassPtr, 100663307);
			ConfigurationBuilder.NativeMethodInfoPtr_get_factory_Internal_get_PurchasingFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationBuilder>.NativeClassPtr, 100663308);
			ConfigurationBuilder.NativeMethodInfoPtr_Instance_Public_Static_ConfigurationBuilder_IPurchasingModule_Il2CppReferenceArray_1_IPurchasingModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationBuilder>.NativeClassPtr, 100663309);
			ConfigurationBuilder.NativeMethodInfoPtr_AddProduct_Public_ConfigurationBuilder_String_ProductType_IDs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationBuilder>.NativeClassPtr, 100663310);
			ConfigurationBuilder.NativeMethodInfoPtr_AddProduct_Public_ConfigurationBuilder_String_ProductType_IDs_IEnumerable_1_PayoutDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationBuilder>.NativeClassPtr, 100663311);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000300C File Offset: 0x0000120C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130526, XrefRangeEnd = 130533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigurationBuilder(PurchasingFactory factory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationBuilder.NativeMethodInfoPtr__ctor_Internal_Void_PurchasingFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00003058 File Offset: 0x00001258
		public unsafe bool useCatalogProvider
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationBuilder.NativeMethodInfoPtr_get_useCatalogProvider_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00003094 File Offset: 0x00001294
		public unsafe HashSet<ProductDefinition> products
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationBuilder.NativeMethodInfoPtr_get_products_Public_get_HashSet_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<ProductDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000030D4 File Offset: 0x000012D4
		public unsafe PurchasingFactory factory
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationBuilder.NativeMethodInfoPtr_get_factory_Internal_get_PurchasingFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PurchasingFactory>(intPtr3) : null;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003114 File Offset: 0x00001314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130566, RefRangeEnd = 130567, XrefRangeStart = 130533, XrefRangeEnd = 130566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConfigurationBuilder Instance(IPurchasingModule first, [Optional] Il2CppReferenceArray<IPurchasingModule> rest)
		{
			if (rest == null)
			{
				rest = new Il2CppReferenceArray<IPurchasingModule>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationBuilder.NativeMethodInfoPtr_Instance_Public_Static_ConfigurationBuilder_IPurchasingModule_Il2CppReferenceArray_1_IPurchasingModule_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationBuilder>(intPtr3) : null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003178 File Offset: 0x00001378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130583, RefRangeEnd = 130584, XrefRangeStart = 130567, XrefRangeEnd = 130583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigurationBuilder AddProduct(string id, ProductType type, IDs storeIDs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(storeIDs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationBuilder.NativeMethodInfoPtr_AddProduct_Public_ConfigurationBuilder_String_ProductType_IDs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationBuilder>(intPtr3) : null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000031E8 File Offset: 0x000013E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130584, XrefRangeEnd = 130604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigurationBuilder AddProduct(string id, ProductType type, IDs storeIDs, IEnumerable<PayoutDefinition> payouts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(storeIDs);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(payouts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationBuilder.NativeMethodInfoPtr_AddProduct_Public_ConfigurationBuilder_String_ProductType_IDs_IEnumerable_1_PayoutDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationBuilder>(intPtr3) : null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020AF File Offset: 0x000002AF
		public static ConfigurationBuilder Instance(IPurchasingModule first, params IPurchasingModule[] rest)
		{
			return ConfigurationBuilder.Instance(first, new Il2CppReferenceArray<IPurchasingModule>(rest));
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020BD File Offset: 0x000002BD
		public ConfigurationBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001C RID: 28 RVA: 0x0000326C File Offset: 0x0000146C
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000020C6 File Offset: 0x000002C6
		public unsafe PurchasingFactory m_Factory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationBuilder.NativeFieldInfoPtr_m_Factory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PurchasingFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationBuilder.NativeFieldInfoPtr_m_Factory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000329C File Offset: 0x0000149C
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000020E5 File Offset: 0x000002E5
		public unsafe HashSet<ProductDefinition> m_Products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationBuilder.NativeFieldInfoPtr_m_Products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationBuilder.NativeFieldInfoPtr_m_Products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000032CC File Offset: 0x000014CC
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002104 File Offset: 0x00000304
		public unsafe bool _useCatalogProvider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationBuilder.NativeFieldInfoPtr__useCatalogProvider_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationBuilder.NativeFieldInfoPtr__useCatalogProvider_k__BackingField)) = value;
			}
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_m_Factory;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_m_Products;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr__useCatalogProvider_k__BackingField;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PurchasingFactory_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_get_useCatalogProvider_Public_get_Boolean_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_get_products_Public_get_HashSet_1_ProductDefinition_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_factory_Internal_get_PurchasingFactory_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_Instance_Public_Static_ConfigurationBuilder_IPurchasingModule_Il2CppReferenceArray_1_IPurchasingModule_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_AddProduct_Public_ConfigurationBuilder_String_ProductType_IDs_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_AddProduct_Public_ConfigurationBuilder_String_ProductType_IDs_IEnumerable_1_PayoutDefinition_0;
	}
}

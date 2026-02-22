using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000E RID: 14
	public class ProductCollection : Object
	{
		// Token: 0x0600005D RID: 93 RVA: 0x000040C0 File Offset: 0x000022C0
		// Note: this type is marked as 'beforefieldinit'.
		static ProductCollection()
		{
			Il2CppClassPointerStore<ProductCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "ProductCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductCollection>.NativeClassPtr);
			ProductCollection.NativeFieldInfoPtr_m_IdToProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductCollection>.NativeClassPtr, "m_IdToProduct");
			ProductCollection.NativeFieldInfoPtr_m_StoreSpecificIdToProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductCollection>.NativeClassPtr, "m_StoreSpecificIdToProduct");
			ProductCollection.NativeFieldInfoPtr_m_Products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductCollection>.NativeClassPtr, "m_Products");
			ProductCollection.NativeFieldInfoPtr_m_ProductSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductCollection>.NativeClassPtr, "m_ProductSet");
			ProductCollection.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCollection>.NativeClassPtr, 100663341);
			ProductCollection.NativeMethodInfoPtr_AddProducts_Internal_Void_IEnumerable_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCollection>.NativeClassPtr, 100663342);
			ProductCollection.NativeMethodInfoPtr_get_set_Public_get_HashSet_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCollection>.NativeClassPtr, 100663343);
			ProductCollection.NativeMethodInfoPtr_get_all_Public_get_Il2CppReferenceArray_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCollection>.NativeClassPtr, 100663344);
			ProductCollection.NativeMethodInfoPtr_WithID_Public_Product_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCollection>.NativeClassPtr, 100663345);
			ProductCollection.NativeMethodInfoPtr_WithStoreSpecificID_Public_Product_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCollection>.NativeClassPtr, 100663346);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000041B8 File Offset: 0x000023B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130617, XrefRangeEnd = 130625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductCollection(Il2CppReferenceArray<Product> products)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCollection.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004204 File Offset: 0x00002404
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 130663, RefRangeEnd = 130666, XrefRangeStart = 130625, XrefRangeEnd = 130663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddProducts(IEnumerable<Product> products)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCollection.NativeMethodInfoPtr_AddProducts_Internal_Void_IEnumerable_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00004248 File Offset: 0x00002448
		public unsafe HashSet<Product> set
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCollection.NativeMethodInfoPtr_get_set_Public_get_HashSet_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<Product>>(intPtr3) : null;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00004288 File Offset: 0x00002488
		public unsafe Il2CppReferenceArray<Product> all
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCollection.NativeMethodInfoPtr_get_all_Public_get_Il2CppReferenceArray_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Product>>(intPtr3) : null;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000042C8 File Offset: 0x000024C8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 130669, RefRangeEnd = 130676, XrefRangeStart = 130666, XrefRangeEnd = 130669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Product WithID(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCollection.NativeMethodInfoPtr_WithID_Public_Product_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Product>(intPtr3) : null;
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004318 File Offset: 0x00002518
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 130679, RefRangeEnd = 130689, XrefRangeStart = 130676, XrefRangeEnd = 130679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Product WithStoreSpecificID(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCollection.NativeMethodInfoPtr_WithStoreSpecificID_Public_Product_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Product>(intPtr3) : null;
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002286 File Offset: 0x00000486
		public ProductCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00004368 File Offset: 0x00002568
		// (set) Token: 0x06000066 RID: 102 RVA: 0x0000228F File Offset: 0x0000048F
		public unsafe Dictionary<string, Product> m_IdToProduct
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCollection.NativeFieldInfoPtr_m_IdToProduct);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCollection.NativeFieldInfoPtr_m_IdToProduct), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00004398 File Offset: 0x00002598
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000022AE File Offset: 0x000004AE
		public unsafe Dictionary<string, Product> m_StoreSpecificIdToProduct
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCollection.NativeFieldInfoPtr_m_StoreSpecificIdToProduct);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCollection.NativeFieldInfoPtr_m_StoreSpecificIdToProduct), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000043C8 File Offset: 0x000025C8
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000022CD File Offset: 0x000004CD
		public unsafe Il2CppReferenceArray<Product> m_Products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCollection.NativeFieldInfoPtr_m_Products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCollection.NativeFieldInfoPtr_m_Products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000043F8 File Offset: 0x000025F8
		// (set) Token: 0x0600006C RID: 108 RVA: 0x000022EC File Offset: 0x000004EC
		public unsafe HashSet<Product> m_ProductSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCollection.NativeFieldInfoPtr_m_ProductSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCollection.NativeFieldInfoPtr_m_ProductSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_m_IdToProduct;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_m_StoreSpecificIdToProduct;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_m_Products;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_m_ProductSet;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppReferenceArray_1_Product_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_AddProducts_Internal_Void_IEnumerable_1_Product_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_get_set_Public_get_HashSet_1_Product_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_get_all_Public_get_Il2CppReferenceArray_1_Product_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_WithID_Public_Product_String_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_WithStoreSpecificID_Public_Product_String_0;

		// Token: 0x0200002A RID: 42
		[ObfuscatedName("UnityEngine.Purchasing.ProductCollection+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000178 RID: 376 RVA: 0x0000855C File Offset: 0x0000675C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ProductCollection.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductCollection>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductCollection.__c>.NativeClassPtr);
				ProductCollection.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductCollection.__c>.NativeClassPtr, "<>9");
				ProductCollection.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductCollection.__c>.NativeClassPtr, "<>9__5_0");
				ProductCollection.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductCollection.__c>.NativeClassPtr, "<>9__5_1");
				ProductCollection.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCollection.__c>.NativeClassPtr, 100663348);
				ProductCollection.__c.NativeMethodInfoPtr__AddProducts_b__5_0_Internal_String_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCollection.__c>.NativeClassPtr, 100663349);
				ProductCollection.__c.NativeMethodInfoPtr__AddProducts_b__5_1_Internal_String_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCollection.__c>.NativeClassPtr, 100663350);
			}

			// Token: 0x06000179 RID: 377 RVA: 0x00008600 File Offset: 0x00006800
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductCollection.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCollection.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600017A RID: 378 RVA: 0x0000863C File Offset: 0x0000683C
			[CallerCount(0)]
			public unsafe string _AddProducts_b__5_0(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCollection.__c.NativeMethodInfoPtr__AddProducts_b__5_0_Internal_String_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600017B RID: 379 RVA: 0x00008684 File Offset: 0x00006884
			[CallerCount(0)]
			public unsafe string _AddProducts_b__5_1(Product x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCollection.__c.NativeMethodInfoPtr__AddProducts_b__5_1_Internal_String_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600017C RID: 380 RVA: 0x00002A0C File Offset: 0x00000C0C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x0600017D RID: 381 RVA: 0x000086CC File Offset: 0x000068CC
			// (set) Token: 0x0600017E RID: 382 RVA: 0x00002A15 File Offset: 0x00000C15
			public unsafe static ProductCollection.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductCollection.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductCollection.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductCollection.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x0600017F RID: 383 RVA: 0x000086F4 File Offset: 0x000068F4
			// (set) Token: 0x06000180 RID: 384 RVA: 0x00002A27 File Offset: 0x00000C27
			public unsafe static Func<Product, string> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductCollection.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductCollection.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x06000181 RID: 385 RVA: 0x0000871C File Offset: 0x0000691C
			// (set) Token: 0x06000182 RID: 386 RVA: 0x00002A39 File Offset: 0x00000C39
			public unsafe static Func<Product, string> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductCollection.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Product, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductCollection.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000107 RID: 263
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000108 RID: 264
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04000109 RID: 265
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x0400010A RID: 266
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400010B RID: 267
			private static readonly IntPtr NativeMethodInfoPtr__AddProducts_b__5_0_Internal_String_Product_0;

			// Token: 0x0400010C RID: 268
			private static readonly IntPtr NativeMethodInfoPtr__AddProducts_b__5_1_Internal_String_Product_0;
		}
	}
}

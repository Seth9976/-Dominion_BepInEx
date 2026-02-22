using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000012 RID: 18
	public class PurchaseEventArgs : Object
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x00005134 File Offset: 0x00003334
		// Note: this type is marked as 'beforefieldinit'.
		static PurchaseEventArgs()
		{
			Il2CppClassPointerStore<PurchaseEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "PurchaseEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PurchaseEventArgs>.NativeClassPtr);
			PurchaseEventArgs.NativeFieldInfoPtr__purchasedProduct_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PurchaseEventArgs>.NativeClassPtr, "<purchasedProduct>k__BackingField");
			PurchaseEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseEventArgs>.NativeClassPtr, 100663379);
			PurchaseEventArgs.NativeMethodInfoPtr_get_purchasedProduct_Public_get_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseEventArgs>.NativeClassPtr, 100663380);
			PurchaseEventArgs.NativeMethodInfoPtr_set_purchasedProduct_Private_set_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PurchaseEventArgs>.NativeClassPtr, 100663381);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000051B4 File Offset: 0x000033B4
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PurchaseEventArgs(Product purchasedProduct)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PurchaseEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchasedProduct);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00005200 File Offset: 0x00003400
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00005240 File Offset: 0x00003440
		public unsafe Product purchasedProduct
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseEventArgs.NativeMethodInfoPtr_get_purchasedProduct_Public_get_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Product>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PurchaseEventArgs.NativeMethodInfoPtr_set_purchasedProduct_Private_set_Void_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002447 File Offset: 0x00000647
		public PurchaseEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00005284 File Offset: 0x00003484
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002450 File Offset: 0x00000650
		public unsafe Product _purchasedProduct_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseEventArgs.NativeFieldInfoPtr__purchasedProduct_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Product>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PurchaseEventArgs.NativeFieldInfoPtr__purchasedProduct_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr__purchasedProduct_k__BackingField;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Product_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_purchasedProduct_Public_get_Product_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_set_purchasedProduct_Private_set_Void_Product_0;
	}
}

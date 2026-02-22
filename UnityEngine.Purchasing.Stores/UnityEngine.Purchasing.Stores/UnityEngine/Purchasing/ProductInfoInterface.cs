using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000045 RID: 69
	public class ProductInfoInterface : Object
	{
		// Token: 0x06000232 RID: 562 RVA: 0x0000D2F8 File Offset: 0x0000B4F8
		// Note: this type is marked as 'beforefieldinit'.
		static ProductInfoInterface()
		{
			Il2CppClassPointerStore<ProductInfoInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "ProductInfoInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductInfoInterface>.NativeClassPtr);
			ProductInfoInterface.NativeFieldInfoPtr_s_typeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductInfoInterface>.NativeClassPtr, "s_typeCache");
			ProductInfoInterface.NativeMethodInfoPtr_GetClassType_Private_Static_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductInfoInterface>.NativeClassPtr, 100663578);
			ProductInfoInterface.NativeMethodInfoPtr_GetCurrencyProp_Public_Static_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductInfoInterface>.NativeClassPtr, 100663579);
			ProductInfoInterface.NativeMethodInfoPtr_GetDescriptionProp_Public_Static_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductInfoInterface>.NativeClassPtr, 100663580);
			ProductInfoInterface.NativeMethodInfoPtr_GetPriceProp_Public_Static_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductInfoInterface>.NativeClassPtr, 100663581);
			ProductInfoInterface.NativeMethodInfoPtr_GetPriceAmountMicrosProp_Public_Static_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductInfoInterface>.NativeClassPtr, 100663582);
			ProductInfoInterface.NativeMethodInfoPtr_GetProductIdProp_Public_Static_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductInfoInterface>.NativeClassPtr, 100663583);
			ProductInfoInterface.NativeMethodInfoPtr_GetTitleProp_Public_Static_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductInfoInterface>.NativeClassPtr, 100663584);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 152967, RefRangeEnd = 152978, XrefRangeStart = 152953, XrefRangeEnd = 152967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetClassType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductInfoInterface.NativeMethodInfoPtr_GetClassType_Private_Static_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000D3FC File Offset: 0x0000B5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152978, XrefRangeEnd = 152983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyInfo GetCurrencyProp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductInfoInterface.NativeMethodInfoPtr_GetCurrencyProp_Public_Static_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000D430 File Offset: 0x0000B630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152983, XrefRangeEnd = 152988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyInfo GetDescriptionProp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductInfoInterface.NativeMethodInfoPtr_GetDescriptionProp_Public_Static_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000D464 File Offset: 0x0000B664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152988, XrefRangeEnd = 152993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyInfo GetPriceProp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductInfoInterface.NativeMethodInfoPtr_GetPriceProp_Public_Static_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000D498 File Offset: 0x0000B698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152993, XrefRangeEnd = 152998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyInfo GetPriceAmountMicrosProp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductInfoInterface.NativeMethodInfoPtr_GetPriceAmountMicrosProp_Public_Static_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000D4CC File Offset: 0x0000B6CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153003, RefRangeEnd = 153004, XrefRangeStart = 152998, XrefRangeEnd = 153003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyInfo GetProductIdProp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductInfoInterface.NativeMethodInfoPtr_GetProductIdProp_Public_Static_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000D500 File Offset: 0x0000B700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153004, XrefRangeEnd = 153009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyInfo GetTitleProp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductInfoInterface.NativeMethodInfoPtr_GetTitleProp_Public_Static_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00003137 File Offset: 0x00001337
		public ProductInfoInterface(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000D534 File Offset: 0x0000B734
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00003140 File Offset: 0x00001340
		public unsafe static Type s_typeCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProductInfoInterface.NativeFieldInfoPtr_s_typeCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProductInfoInterface.NativeFieldInfoPtr_s_typeCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeFieldInfoPtr_s_typeCache;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_GetClassType_Private_Static_Type_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrencyProp_Public_Static_PropertyInfo_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptionProp_Public_Static_PropertyInfo_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_GetPriceProp_Public_Static_PropertyInfo_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_GetPriceAmountMicrosProp_Public_Static_PropertyInfo_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_GetProductIdProp_Public_Static_PropertyInfo_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_GetTitleProp_Public_Static_PropertyInfo_0;
	}
}

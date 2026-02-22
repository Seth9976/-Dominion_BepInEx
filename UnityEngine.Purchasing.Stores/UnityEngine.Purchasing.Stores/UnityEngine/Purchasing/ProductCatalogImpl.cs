using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200006D RID: 109
	public class ProductCatalogImpl : Object
	{
		// Token: 0x060003DD RID: 989 RVA: 0x000127D4 File Offset: 0x000109D4
		// Note: this type is marked as 'beforefieldinit'.
		static ProductCatalogImpl()
		{
			Il2CppClassPointerStore<ProductCatalogImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "ProductCatalogImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductCatalogImpl>.NativeClassPtr);
			ProductCatalogImpl.NativeMethodInfoPtr_LoadDefaultCatalog_Public_Virtual_Final_New_ProductCatalog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCatalogImpl>.NativeClassPtr, 100663768);
			ProductCatalogImpl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCatalogImpl>.NativeClassPtr, 100663769);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0001282C File Offset: 0x00010A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155076, XrefRangeEnd = 155097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ProductCatalog LoadDefaultCatalog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCatalogImpl.NativeMethodInfoPtr_LoadDefaultCatalog_Public_Virtual_Final_New_ProductCatalog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductCatalog>(intPtr3) : null;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0001286C File Offset: 0x00010A6C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductCatalogImpl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductCatalogImpl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCatalogImpl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00003FB0 File Offset: 0x000021B0
		public ProductCatalogImpl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_LoadDefaultCatalog_Public_Virtual_Final_New_ProductCatalog_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

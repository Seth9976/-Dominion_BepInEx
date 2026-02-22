using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000069 RID: 105
	[Serializable]
	public class ProductCatalogPayout : Object
	{
		// Token: 0x060003B3 RID: 947 RVA: 0x0001212C File Offset: 0x0001032C
		// Note: this type is marked as 'beforefieldinit'.
		static ProductCatalogPayout()
		{
			Il2CppClassPointerStore<ProductCatalogPayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "ProductCatalogPayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductCatalogPayout>.NativeClassPtr);
			ProductCatalogPayout.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductCatalogPayout>.NativeClassPtr, "t");
			ProductCatalogPayout.NativeFieldInfoPtr_st = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductCatalogPayout>.NativeClassPtr, "st");
			ProductCatalogPayout.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductCatalogPayout>.NativeClassPtr, "d");
			ProductCatalogPayout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductCatalogPayout>.NativeClassPtr, 100663758);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x000121AC File Offset: 0x000103AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154998, XrefRangeEnd = 155006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductCatalogPayout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductCatalogPayout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductCatalogPayout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00003DF6 File Offset: 0x00001FF6
		public ProductCatalogPayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x000121E8 File Offset: 0x000103E8
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x00003DFF File Offset: 0x00001FFF
		public unsafe string t
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogPayout.NativeFieldInfoPtr_t);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogPayout.NativeFieldInfoPtr_t), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00012210 File Offset: 0x00010410
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00003E1E File Offset: 0x0000201E
		public unsafe string st
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogPayout.NativeFieldInfoPtr_st);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogPayout.NativeFieldInfoPtr_st), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00012238 File Offset: 0x00010438
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00003E3D File Offset: 0x0000203D
		public unsafe string d
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogPayout.NativeFieldInfoPtr_d);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductCatalogPayout.NativeFieldInfoPtr_d), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeFieldInfoPtr_t;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeFieldInfoPtr_st;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeFieldInfoPtr_d;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C1 RID: 193
		public enum ProductCatalogPayoutType
		{
			// Token: 0x04000491 RID: 1169
			Other,
			// Token: 0x04000492 RID: 1170
			Currency,
			// Token: 0x04000493 RID: 1171
			Item,
			// Token: 0x04000494 RID: 1172
			Resource
		}
	}
}

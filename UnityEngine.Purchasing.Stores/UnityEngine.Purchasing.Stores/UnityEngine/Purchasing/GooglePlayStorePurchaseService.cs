using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200002F RID: 47
	public class GooglePlayStorePurchaseService : Object
	{
		// Token: 0x0600019B RID: 411 RVA: 0x0000B4A0 File Offset: 0x000096A0
		// Note: this type is marked as 'beforefieldinit'.
		static GooglePlayStorePurchaseService()
		{
			Il2CppClassPointerStore<GooglePlayStorePurchaseService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GooglePlayStorePurchaseService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayStorePurchaseService>.NativeClassPtr);
			GooglePlayStorePurchaseService.NativeFieldInfoPtr_m_GooglePlayStoreService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStorePurchaseService>.NativeClassPtr, "m_GooglePlayStoreService");
			GooglePlayStorePurchaseService.NativeMethodInfoPtr__ctor_Internal_Void_IGooglePlayStoreService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStorePurchaseService>.NativeClassPtr, 100663493);
			GooglePlayStorePurchaseService.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStorePurchaseService>.NativeClassPtr, 100663494);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000B50C File Offset: 0x0000970C
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GooglePlayStorePurchaseService(IGooglePlayStoreService googlePlayStoreService)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayStorePurchaseService>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePlayStoreService);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStorePurchaseService.NativeMethodInfoPtr__ctor_Internal_Void_IGooglePlayStoreService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000B558 File Offset: 0x00009758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151675, XrefRangeEnd = 151679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Purchase(ProductDefinition product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStorePurchaseService.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002C5B File Offset: 0x00000E5B
		public GooglePlayStorePurchaseService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000B59C File Offset: 0x0000979C
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002C64 File Offset: 0x00000E64
		public unsafe IGooglePlayStoreService m_GooglePlayStoreService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStorePurchaseService.NativeFieldInfoPtr_m_GooglePlayStoreService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePlayStoreService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStorePurchaseService.NativeFieldInfoPtr_m_GooglePlayStoreService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_m_GooglePlayStoreService;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IGooglePlayStoreService_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_ProductDefinition_0;
	}
}

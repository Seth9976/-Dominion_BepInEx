using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000010 RID: 16
	public class GooglePriceChangeService : Object
	{
		// Token: 0x0600007C RID: 124 RVA: 0x00007548 File Offset: 0x00005748
		// Note: this type is marked as 'beforefieldinit'.
		static GooglePriceChangeService()
		{
			Il2CppClassPointerStore<GooglePriceChangeService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GooglePriceChangeService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePriceChangeService>.NativeClassPtr);
			GooglePriceChangeService.NativeFieldInfoPtr_m_BillingClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePriceChangeService>.NativeClassPtr, "m_BillingClient");
			GooglePriceChangeService.NativeFieldInfoPtr_m_QuerySkuDetailsService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePriceChangeService>.NativeClassPtr, "m_QuerySkuDetailsService");
			GooglePriceChangeService.NativeMethodInfoPtr__ctor_Internal_Void_IGoogleBillingClient_IGoogleCachedQuerySkuDetailsService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePriceChangeService>.NativeClassPtr, 100663359);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000075B4 File Offset: 0x000057B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150604, XrefRangeEnd = 150609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GooglePriceChangeService(IGoogleBillingClient billingClient, IGoogleCachedQuerySkuDetailsService cachedQuerySkuDetailsService)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePriceChangeService>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(billingClient);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachedQuerySkuDetailsService);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePriceChangeService.NativeMethodInfoPtr__ctor_Internal_Void_IGoogleBillingClient_IGoogleCachedQuerySkuDetailsService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002392 File Offset: 0x00000592
		public GooglePriceChangeService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00007614 File Offset: 0x00005814
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0000239B File Offset: 0x0000059B
		public unsafe IGoogleBillingClient m_BillingClient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePriceChangeService.NativeFieldInfoPtr_m_BillingClient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGoogleBillingClient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePriceChangeService.NativeFieldInfoPtr_m_BillingClient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00007644 File Offset: 0x00005844
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000023BA File Offset: 0x000005BA
		public unsafe QuerySkuDetailsService m_QuerySkuDetailsService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePriceChangeService.NativeFieldInfoPtr_m_QuerySkuDetailsService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuerySkuDetailsService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePriceChangeService.NativeFieldInfoPtr_m_QuerySkuDetailsService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_m_BillingClient;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_m_QuerySkuDetailsService;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IGoogleBillingClient_IGoogleCachedQuerySkuDetailsService_0;
	}
}

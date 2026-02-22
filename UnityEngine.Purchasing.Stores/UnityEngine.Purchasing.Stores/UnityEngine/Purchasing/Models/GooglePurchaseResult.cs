using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing.Models
{
	// Token: 0x02000087 RID: 135
	public class GooglePurchaseResult : Object
	{
		// Token: 0x06000569 RID: 1385 RVA: 0x00017A3C File Offset: 0x00015C3C
		// Note: this type is marked as 'beforefieldinit'.
		static GooglePurchaseResult()
		{
			Il2CppClassPointerStore<GooglePurchaseResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Models", "GooglePurchaseResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePurchaseResult>.NativeClassPtr);
			GooglePurchaseResult.NativeFieldInfoPtr_m_ResponseCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseResult>.NativeClassPtr, "m_ResponseCode");
			GooglePurchaseResult.NativeFieldInfoPtr_m_Purchases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchaseResult>.NativeClassPtr, "m_Purchases");
			GooglePurchaseResult.NativeMethodInfoPtr__ctor_Internal_Void_AndroidJavaObject_IGoogleCachedQuerySkuDetailsService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseResult>.NativeClassPtr, 100663956);
			GooglePurchaseResult.NativeMethodInfoPtr_FillPurchases_Private_Void_AndroidJavaObject_IGoogleCachedQuerySkuDetailsService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchaseResult>.NativeClassPtr, 100663957);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00017ABC File Offset: 0x00015CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157247, XrefRangeEnd = 157264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GooglePurchaseResult(AndroidJavaObject purchaseResult, IGoogleCachedQuerySkuDetailsService cachedQuerySkuDetailsService)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePurchaseResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchaseResult);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachedQuerySkuDetailsService);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseResult.NativeMethodInfoPtr__ctor_Internal_Void_AndroidJavaObject_IGoogleCachedQuerySkuDetailsService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00017B1C File Offset: 0x00015D1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 157325, RefRangeEnd = 157328, XrefRangeStart = 157264, XrefRangeEnd = 157325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillPurchases(AndroidJavaObject purchaseResult, IGoogleCachedQuerySkuDetailsService cachedQuerySkuDetailsService)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchaseResult);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cachedQuerySkuDetailsService);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchaseResult.NativeMethodInfoPtr_FillPurchases_Private_Void_AndroidJavaObject_IGoogleCachedQuerySkuDetailsService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00004C08 File Offset: 0x00002E08
		public GooglePurchaseResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00017B70 File Offset: 0x00015D70
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x00004C11 File Offset: 0x00002E11
		public unsafe int m_ResponseCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseResult.NativeFieldInfoPtr_m_ResponseCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseResult.NativeFieldInfoPtr_m_ResponseCode)) = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00017B98 File Offset: 0x00015D98
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x00004C2C File Offset: 0x00002E2C
		public unsafe List<GooglePurchase> m_Purchases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseResult.NativeFieldInfoPtr_m_Purchases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GooglePurchase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchaseResult.NativeFieldInfoPtr_m_Purchases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeFieldInfoPtr_m_ResponseCode;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeFieldInfoPtr_m_Purchases;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_AndroidJavaObject_IGoogleCachedQuerySkuDetailsService_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_FillPurchases_Private_Void_AndroidJavaObject_IGoogleCachedQuerySkuDetailsService_0;
	}
}

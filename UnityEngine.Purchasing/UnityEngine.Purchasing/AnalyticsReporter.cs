using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000002 RID: 2
	public class AnalyticsReporter : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002B30 File Offset: 0x00000D30
		// Note: this type is marked as 'beforefieldinit'.
		static AnalyticsReporter()
		{
			Il2CppClassPointerStore<AnalyticsReporter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "AnalyticsReporter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsReporter>.NativeClassPtr);
			AnalyticsReporter.NativeFieldInfoPtr_m_Analytics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsReporter>.NativeClassPtr, "m_Analytics");
			AnalyticsReporter.NativeMethodInfoPtr__ctor_Public_Void_IUnityAnalytics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReporter>.NativeClassPtr, 100663297);
			AnalyticsReporter.NativeMethodInfoPtr_OnPurchaseSucceeded_Public_Void_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReporter>.NativeClassPtr, 100663298);
			AnalyticsReporter.NativeMethodInfoPtr_OnPurchaseFailed_Public_Void_Product_PurchaseFailureReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsReporter>.NativeClassPtr, 100663299);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnalyticsReporter(IUnityAnalytics analytics)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsReporter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(analytics);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsReporter.NativeMethodInfoPtr__ctor_Public_Void_IUnityAnalytics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002BFC File Offset: 0x00000DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130458, XrefRangeEnd = 130461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPurchaseSucceeded(Product product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsReporter.NativeMethodInfoPtr_OnPurchaseSucceeded_Public_Void_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002C40 File Offset: 0x00000E40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130495, RefRangeEnd = 130496, XrefRangeStart = 130461, XrefRangeEnd = 130495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPurchaseFailed(Product product, PurchaseFailureReason reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reason;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsReporter.NativeMethodInfoPtr_OnPurchaseFailed_Public_Void_Product_PurchaseFailureReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		public AnalyticsReporter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002C90 File Offset: 0x00000E90
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe IUnityAnalytics m_Analytics
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsReporter.NativeFieldInfoPtr_m_Analytics);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUnityAnalytics>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnalyticsReporter.NativeFieldInfoPtr_m_Analytics), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_m_Analytics;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IUnityAnalytics_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseSucceeded_Public_Void_Product_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseFailed_Public_Void_Product_PurchaseFailureReason_0;
	}
}

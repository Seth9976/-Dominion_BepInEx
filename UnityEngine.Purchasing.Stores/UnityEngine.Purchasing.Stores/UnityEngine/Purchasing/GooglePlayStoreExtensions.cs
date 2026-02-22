using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000022 RID: 34
	public class GooglePlayStoreExtensions : Object
	{
		// Token: 0x0600012F RID: 303 RVA: 0x00009CC4 File Offset: 0x00007EC4
		// Note: this type is marked as 'beforefieldinit'.
		static GooglePlayStoreExtensions()
		{
			Il2CppClassPointerStore<GooglePlayStoreExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GooglePlayStoreExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayStoreExtensions>.NativeClassPtr);
			GooglePlayStoreExtensions.NativeFieldInfoPtr_m_GooglePlayStoreService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreExtensions>.NativeClassPtr, "m_GooglePlayStoreService");
			GooglePlayStoreExtensions.NativeFieldInfoPtr_m_GooglePlayStoreFinishTransactionService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreExtensions>.NativeClassPtr, "m_GooglePlayStoreFinishTransactionService");
			GooglePlayStoreExtensions.NativeFieldInfoPtr_m_StoreCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreExtensions>.NativeClassPtr, "m_StoreCallback");
			GooglePlayStoreExtensions.NativeFieldInfoPtr_m_GooglePlayStoreExtensionsInternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreExtensions>.NativeClassPtr, "m_GooglePlayStoreExtensionsInternal");
			GooglePlayStoreExtensions.NativeFieldInfoPtr_m_DeferredPurchaseAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreExtensions>.NativeClassPtr, "m_DeferredPurchaseAction");
			GooglePlayStoreExtensions.NativeFieldInfoPtr_m_DeferredProrationUpgradeDowngradeSubscriptionAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreExtensions>.NativeClassPtr, "m_DeferredProrationUpgradeDowngradeSubscriptionAction");
			GooglePlayStoreExtensions.NativeMethodInfoPtr__ctor_Internal_Void_IGooglePlayStoreService_IGooglePlayStoreFinishTransactionService_GooglePlayStoreExtensionsInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreExtensions>.NativeClassPtr, 100663444);
			GooglePlayStoreExtensions.NativeMethodInfoPtr_SetStoreCallback_Public_Virtual_Final_New_Void_IStoreCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreExtensions>.NativeClassPtr, 100663445);
			GooglePlayStoreExtensions.NativeMethodInfoPtr_NotifyDeferredPurchase_Public_Virtual_Final_New_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreExtensions>.NativeClassPtr, 100663446);
			GooglePlayStoreExtensions.NativeMethodInfoPtr_NotifyDeferredProrationUpgradeDowngradeSubscription_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreExtensions>.NativeClassPtr, 100663447);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00009DBC File Offset: 0x00007FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151479, XrefRangeEnd = 151480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GooglePlayStoreExtensions(IGooglePlayStoreService googlePlayStoreService, IGooglePlayStoreFinishTransactionService googlePlayStoreFinishTransactionService, GooglePlayStoreExtensionsInternal googlePlayStoreExtensionsInternal)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayStoreExtensions>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePlayStoreService);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePlayStoreFinishTransactionService);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(googlePlayStoreExtensionsInternal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreExtensions.NativeMethodInfoPtr__ctor_Internal_Void_IGooglePlayStoreService_IGooglePlayStoreFinishTransactionService_GooglePlayStoreExtensionsInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00009E2C File Offset: 0x0000802C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStoreCallback(IStoreCallback storeCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreExtensions.NativeMethodInfoPtr_SetStoreCallback_Public_Virtual_Final_New_Void_IStoreCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00009E70 File Offset: 0x00008070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151480, XrefRangeEnd = 151495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NotifyDeferredPurchase(string productId, string receipt, string transactionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receipt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreExtensions.NativeMethodInfoPtr_NotifyDeferredPurchase_Public_Virtual_Final_New_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00009ED8 File Offset: 0x000080D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151495, XrefRangeEnd = 151507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NotifyDeferredProrationUpgradeDowngradeSubscription(string productId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreExtensions.NativeMethodInfoPtr_NotifyDeferredProrationUpgradeDowngradeSubscription_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002938 File Offset: 0x00000B38
		public GooglePlayStoreExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00009F1C File Offset: 0x0000811C
		// (set) Token: 0x06000136 RID: 310 RVA: 0x00002941 File Offset: 0x00000B41
		public unsafe IGooglePlayStoreService m_GooglePlayStoreService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreExtensions.NativeFieldInfoPtr_m_GooglePlayStoreService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePlayStoreService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreExtensions.NativeFieldInfoPtr_m_GooglePlayStoreService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00009F4C File Offset: 0x0000814C
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00002960 File Offset: 0x00000B60
		public unsafe IGooglePlayStoreFinishTransactionService m_GooglePlayStoreFinishTransactionService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreExtensions.NativeFieldInfoPtr_m_GooglePlayStoreFinishTransactionService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePlayStoreFinishTransactionService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreExtensions.NativeFieldInfoPtr_m_GooglePlayStoreFinishTransactionService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00009F7C File Offset: 0x0000817C
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0000297F File Offset: 0x00000B7F
		public unsafe IStoreCallback m_StoreCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreExtensions.NativeFieldInfoPtr_m_StoreCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStoreCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreExtensions.NativeFieldInfoPtr_m_StoreCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00009FAC File Offset: 0x000081AC
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0000299E File Offset: 0x00000B9E
		public unsafe GooglePlayStoreExtensionsInternal m_GooglePlayStoreExtensionsInternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreExtensions.NativeFieldInfoPtr_m_GooglePlayStoreExtensionsInternal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GooglePlayStoreExtensionsInternal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreExtensions.NativeFieldInfoPtr_m_GooglePlayStoreExtensionsInternal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00009FDC File Offset: 0x000081DC
		// (set) Token: 0x0600013E RID: 318 RVA: 0x000029BD File Offset: 0x00000BBD
		public unsafe Action<Product> m_DeferredPurchaseAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreExtensions.NativeFieldInfoPtr_m_DeferredPurchaseAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreExtensions.NativeFieldInfoPtr_m_DeferredPurchaseAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000A00C File Offset: 0x0000820C
		// (set) Token: 0x06000140 RID: 320 RVA: 0x000029DC File Offset: 0x00000BDC
		public unsafe Action<Product> m_DeferredProrationUpgradeDowngradeSubscriptionAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreExtensions.NativeFieldInfoPtr_m_DeferredProrationUpgradeDowngradeSubscriptionAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreExtensions.NativeFieldInfoPtr_m_DeferredProrationUpgradeDowngradeSubscriptionAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr_m_GooglePlayStoreService;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeFieldInfoPtr_m_GooglePlayStoreFinishTransactionService;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeFieldInfoPtr_m_StoreCallback;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr_m_GooglePlayStoreExtensionsInternal;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeFieldInfoPtr_m_DeferredPurchaseAction;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_m_DeferredProrationUpgradeDowngradeSubscriptionAction;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IGooglePlayStoreService_IGooglePlayStoreFinishTransactionService_GooglePlayStoreExtensionsInternal_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_SetStoreCallback_Public_Virtual_Final_New_Void_IStoreCallback_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDeferredPurchase_Public_Virtual_Final_New_Void_String_String_String_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDeferredProrationUpgradeDowngradeSubscription_Public_Virtual_Final_New_Void_String_0;
	}
}

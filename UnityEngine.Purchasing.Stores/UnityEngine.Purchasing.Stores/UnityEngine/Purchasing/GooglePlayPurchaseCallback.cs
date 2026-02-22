using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000020 RID: 32
	public class GooglePlayPurchaseCallback : Object
	{
		// Token: 0x0600010C RID: 268 RVA: 0x00009484 File Offset: 0x00007684
		// Note: this type is marked as 'beforefieldinit'.
		static GooglePlayPurchaseCallback()
		{
			Il2CppClassPointerStore<GooglePlayPurchaseCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GooglePlayPurchaseCallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayPurchaseCallback>.NativeClassPtr);
			GooglePlayPurchaseCallback.NativeFieldInfoPtr_m_StoreCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayPurchaseCallback>.NativeClassPtr, "m_StoreCallback");
			GooglePlayPurchaseCallback.NativeFieldInfoPtr_m_GooglePlayStoreExtensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayPurchaseCallback>.NativeClassPtr, "m_GooglePlayStoreExtensions");
			GooglePlayPurchaseCallback.NativeMethodInfoPtr_SetStoreCallback_Public_Virtual_Final_New_Void_IStoreCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayPurchaseCallback>.NativeClassPtr, 100663431);
			GooglePlayPurchaseCallback.NativeMethodInfoPtr_SetStoreExtension_Public_Virtual_Final_New_Void_IGooglePlayStoreExtensionsInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayPurchaseCallback>.NativeClassPtr, 100663432);
			GooglePlayPurchaseCallback.NativeMethodInfoPtr_OnPurchaseSuccessful_Public_Virtual_Final_New_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayPurchaseCallback>.NativeClassPtr, 100663433);
			GooglePlayPurchaseCallback.NativeMethodInfoPtr_OnPurchaseFailed_Public_Virtual_Final_New_Void_PurchaseFailureDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayPurchaseCallback>.NativeClassPtr, 100663434);
			GooglePlayPurchaseCallback.NativeMethodInfoPtr_NotifyDeferredPurchase_Public_Virtual_Final_New_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayPurchaseCallback>.NativeClassPtr, 100663435);
			GooglePlayPurchaseCallback.NativeMethodInfoPtr_NotifyDeferredProrationUpgradeDowngradeSubscription_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayPurchaseCallback>.NativeClassPtr, 100663436);
			GooglePlayPurchaseCallback.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayPurchaseCallback>.NativeClassPtr, 100663437);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00009568 File Offset: 0x00007768
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStoreCallback(IStoreCallback storeCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayPurchaseCallback.NativeMethodInfoPtr_SetStoreCallback_Public_Virtual_Final_New_Void_IStoreCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000095AC File Offset: 0x000077AC
		[CallerCount(0)]
		public unsafe virtual void SetStoreExtension(IGooglePlayStoreExtensionsInternal extensions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extensions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayPurchaseCallback.NativeMethodInfoPtr_SetStoreExtension_Public_Virtual_Final_New_Void_IGooglePlayStoreExtensionsInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000095F0 File Offset: 0x000077F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151428, XrefRangeEnd = 151431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPurchaseSuccessful(string sku, string receipt, string purchaseToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sku);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receipt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(purchaseToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayPurchaseCallback.NativeMethodInfoPtr_OnPurchaseSuccessful_Public_Virtual_Final_New_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00009658 File Offset: 0x00007858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151431, XrefRangeEnd = 151434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPurchaseFailed(PurchaseFailureDescription purchaseFailureDescription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchaseFailureDescription);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayPurchaseCallback.NativeMethodInfoPtr_OnPurchaseFailed_Public_Virtual_Final_New_Void_PurchaseFailureDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000969C File Offset: 0x0000789C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151434, XrefRangeEnd = 151437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NotifyDeferredPurchase(string sku, string receipt, string purchaseToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sku);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receipt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(purchaseToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayPurchaseCallback.NativeMethodInfoPtr_NotifyDeferredPurchase_Public_Virtual_Final_New_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00009704 File Offset: 0x00007904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151437, XrefRangeEnd = 151440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sku);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayPurchaseCallback.NativeMethodInfoPtr_NotifyDeferredProrationUpgradeDowngradeSubscription_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00009748 File Offset: 0x00007948
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GooglePlayPurchaseCallback()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayPurchaseCallback>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayPurchaseCallback.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000280F File Offset: 0x00000A0F
		public GooglePlayPurchaseCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00009784 File Offset: 0x00007984
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00002818 File Offset: 0x00000A18
		public unsafe IStoreCallback m_StoreCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayPurchaseCallback.NativeFieldInfoPtr_m_StoreCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStoreCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayPurchaseCallback.NativeFieldInfoPtr_m_StoreCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000117 RID: 279 RVA: 0x000097B4 File Offset: 0x000079B4
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00002837 File Offset: 0x00000A37
		public unsafe IGooglePlayStoreExtensionsInternal m_GooglePlayStoreExtensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayPurchaseCallback.NativeFieldInfoPtr_m_GooglePlayStoreExtensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGooglePlayStoreExtensionsInternal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayPurchaseCallback.NativeFieldInfoPtr_m_GooglePlayStoreExtensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_m_StoreCallback;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_m_GooglePlayStoreExtensions;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_SetStoreCallback_Public_Virtual_Final_New_Void_IStoreCallback_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_SetStoreExtension_Public_Virtual_Final_New_Void_IGooglePlayStoreExtensionsInternal_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseSuccessful_Public_Virtual_Final_New_Void_String_String_String_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseFailed_Public_Virtual_Final_New_Void_PurchaseFailureDescription_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDeferredPurchase_Public_Virtual_Final_New_Void_String_String_String_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDeferredProrationUpgradeDowngradeSubscription_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

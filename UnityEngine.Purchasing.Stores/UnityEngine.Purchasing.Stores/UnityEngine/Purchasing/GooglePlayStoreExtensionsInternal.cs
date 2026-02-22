using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000023 RID: 35
	public class GooglePlayStoreExtensionsInternal : Object
	{
		// Token: 0x06000141 RID: 321 RVA: 0x0000A03C File Offset: 0x0000823C
		// Note: this type is marked as 'beforefieldinit'.
		static GooglePlayStoreExtensionsInternal()
		{
			Il2CppClassPointerStore<GooglePlayStoreExtensionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "GooglePlayStoreExtensionsInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayStoreExtensionsInternal>.NativeClassPtr);
			GooglePlayStoreExtensionsInternal.NativeFieldInfoPtr_m_GooglePlayStoreExtensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayStoreExtensionsInternal>.NativeClassPtr, "m_GooglePlayStoreExtensions");
			GooglePlayStoreExtensionsInternal.NativeMethodInfoPtr_SetGooglePlayStoreExtensions_Public_Void_GooglePlayStoreExtensions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreExtensionsInternal>.NativeClassPtr, 100663448);
			GooglePlayStoreExtensionsInternal.NativeMethodInfoPtr_SetStoreCallback_Public_Virtual_Final_New_Void_IStoreCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreExtensionsInternal>.NativeClassPtr, 100663449);
			GooglePlayStoreExtensionsInternal.NativeMethodInfoPtr_NotifyDeferredPurchase_Public_Virtual_Final_New_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreExtensionsInternal>.NativeClassPtr, 100663450);
			GooglePlayStoreExtensionsInternal.NativeMethodInfoPtr_NotifyDeferredProrationUpgradeDowngradeSubscription_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreExtensionsInternal>.NativeClassPtr, 100663451);
			GooglePlayStoreExtensionsInternal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayStoreExtensionsInternal>.NativeClassPtr, 100663452);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000A0E4 File Offset: 0x000082E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGooglePlayStoreExtensions(GooglePlayStoreExtensions googlePlayStoreExtensions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(googlePlayStoreExtensions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreExtensionsInternal.NativeMethodInfoPtr_SetGooglePlayStoreExtensions_Public_Void_GooglePlayStoreExtensions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000A128 File Offset: 0x00008328
		[CallerCount(0)]
		public unsafe virtual void SetStoreCallback(IStoreCallback storeCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreExtensionsInternal.NativeMethodInfoPtr_SetStoreCallback_Public_Virtual_Final_New_Void_IStoreCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000A16C File Offset: 0x0000836C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151507, XrefRangeEnd = 151522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreExtensionsInternal.NativeMethodInfoPtr_NotifyDeferredPurchase_Public_Virtual_Final_New_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000A1D4 File Offset: 0x000083D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151522, XrefRangeEnd = 151534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NotifyDeferredProrationUpgradeDowngradeSubscription(string productId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreExtensionsInternal.NativeMethodInfoPtr_NotifyDeferredProrationUpgradeDowngradeSubscription_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000A218 File Offset: 0x00008418
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GooglePlayStoreExtensionsInternal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayStoreExtensionsInternal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayStoreExtensionsInternal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000029FB File Offset: 0x00000BFB
		public GooglePlayStoreExtensionsInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000A254 File Offset: 0x00008454
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00002A04 File Offset: 0x00000C04
		public unsafe GooglePlayStoreExtensions m_GooglePlayStoreExtensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreExtensionsInternal.NativeFieldInfoPtr_m_GooglePlayStoreExtensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GooglePlayStoreExtensions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayStoreExtensionsInternal.NativeFieldInfoPtr_m_GooglePlayStoreExtensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeFieldInfoPtr_m_GooglePlayStoreExtensions;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_SetGooglePlayStoreExtensions_Public_Void_GooglePlayStoreExtensions_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_SetStoreCallback_Public_Virtual_Final_New_Void_IStoreCallback_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDeferredPurchase_Public_Virtual_Final_New_Void_String_String_String_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDeferredProrationUpgradeDowngradeSubscription_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

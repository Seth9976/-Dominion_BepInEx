using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000027 RID: 39
	public class IGooglePlayStoreExtensionsInternal : Il2CppObjectBase
	{
		// Token: 0x06000152 RID: 338 RVA: 0x0000A360 File Offset: 0x00008560
		// Note: this type is marked as 'beforefieldinit'.
		static IGooglePlayStoreExtensionsInternal()
		{
			Il2CppClassPointerStore<IGooglePlayStoreExtensionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "IGooglePlayStoreExtensionsInternal");
			IGooglePlayStoreExtensionsInternal.NativeMethodInfoPtr_SetStoreCallback_Public_Abstract_Virtual_New_Void_IStoreCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePlayStoreExtensionsInternal>.NativeClassPtr, 100663455);
			IGooglePlayStoreExtensionsInternal.NativeMethodInfoPtr_NotifyDeferredPurchase_Public_Abstract_Virtual_New_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePlayStoreExtensionsInternal>.NativeClassPtr, 100663456);
			IGooglePlayStoreExtensionsInternal.NativeMethodInfoPtr_NotifyDeferredProrationUpgradeDowngradeSubscription_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePlayStoreExtensionsInternal>.NativeClassPtr, 100663457);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000A3C4 File Offset: 0x000085C4
		[CallerCount(0)]
		public unsafe virtual void SetStoreCallback(IStoreCallback storeCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePlayStoreExtensionsInternal.NativeMethodInfoPtr_SetStoreCallback_Public_Abstract_Virtual_New_Void_IStoreCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000A414 File Offset: 0x00008614
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePlayStoreExtensionsInternal.NativeMethodInfoPtr_NotifyDeferredPurchase_Public_Abstract_Virtual_New_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000A488 File Offset: 0x00008688
		[CallerCount(0)]
		public unsafe virtual void NotifyDeferredProrationUpgradeDowngradeSubscription(string productId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePlayStoreExtensionsInternal.NativeMethodInfoPtr_NotifyDeferredProrationUpgradeDowngradeSubscription_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002A74 File Offset: 0x00000C74
		public IGooglePlayStoreExtensionsInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_SetStoreCallback_Public_Abstract_Virtual_New_Void_IStoreCallback_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDeferredPurchase_Public_Abstract_Virtual_New_Void_String_String_String_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDeferredProrationUpgradeDowngradeSubscription_Public_Abstract_Virtual_New_Void_String_0;
	}
}

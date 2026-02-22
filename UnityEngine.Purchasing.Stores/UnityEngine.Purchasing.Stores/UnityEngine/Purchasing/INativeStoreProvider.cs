using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Uniject;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200004F RID: 79
	public class INativeStoreProvider : Il2CppObjectBase
	{
		// Token: 0x06000281 RID: 641 RVA: 0x0000E2D4 File Offset: 0x0000C4D4
		// Note: this type is marked as 'beforefieldinit'.
		static INativeStoreProvider()
		{
			Il2CppClassPointerStore<INativeStoreProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "INativeStoreProvider");
			INativeStoreProvider.NativeMethodInfoPtr_GetAndroidStore_Public_Abstract_Virtual_New_INativeStore_IUnityCallback_AppStore_IPurchasingBinder_IUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INativeStoreProvider>.NativeClassPtr, 100663623);
			INativeStoreProvider.NativeMethodInfoPtr_GetStorekit_Public_Abstract_Virtual_New_INativeAppleStore_IUnityCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INativeStoreProvider>.NativeClassPtr, 100663624);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000E324 File Offset: 0x0000C524
		[CallerCount(0)]
		public unsafe virtual INativeStore GetAndroidStore(IUnityCallback callback, AppStore store, IPurchasingBinder binder, IUtil util)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref store;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(util);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INativeStoreProvider.NativeMethodInfoPtr_GetAndroidStore_Public_Abstract_Virtual_New_INativeStore_IUnityCallback_AppStore_IPurchasingBinder_IUtil_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<INativeStore>(intPtr3) : null;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000E3B4 File Offset: 0x0000C5B4
		[CallerCount(0)]
		public unsafe virtual INativeAppleStore GetStorekit(IUnityCallback callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INativeStoreProvider.NativeMethodInfoPtr_GetStorekit_Public_Abstract_Virtual_New_INativeAppleStore_IUnityCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<INativeAppleStore>(intPtr3) : null;
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00003350 File Offset: 0x00001550
		public INativeStoreProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_GetAndroidStore_Public_Abstract_Virtual_New_INativeStore_IUnityCallback_AppStore_IPurchasingBinder_IUtil_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_GetStorekit_Public_Abstract_Virtual_New_INativeAppleStore_IUnityCallback_0;
	}
}

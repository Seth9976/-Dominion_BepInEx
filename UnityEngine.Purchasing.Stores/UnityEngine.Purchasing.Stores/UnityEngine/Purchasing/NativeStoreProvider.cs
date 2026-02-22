using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Uniject;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000052 RID: 82
	public class NativeStoreProvider : Object
	{
		// Token: 0x060002BF RID: 703 RVA: 0x0000EFC4 File Offset: 0x0000D1C4
		// Note: this type is marked as 'beforefieldinit'.
		static NativeStoreProvider()
		{
			Il2CppClassPointerStore<NativeStoreProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "NativeStoreProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeStoreProvider>.NativeClassPtr);
			NativeStoreProvider.NativeMethodInfoPtr_GetAndroidStore_Public_Virtual_Final_New_INativeStore_IUnityCallback_AppStore_IPurchasingBinder_IUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeStoreProvider>.NativeClassPtr, 100663643);
			NativeStoreProvider.NativeMethodInfoPtr_GetAndroidStoreHelper_Private_INativeStore_IUnityCallback_AppStore_IPurchasingBinder_IUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeStoreProvider>.NativeClassPtr, 100663644);
			NativeStoreProvider.NativeMethodInfoPtr_GetStorekit_Public_Virtual_Final_New_INativeAppleStore_IUnityCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeStoreProvider>.NativeClassPtr, 100663645);
			NativeStoreProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeStoreProvider>.NativeClassPtr, 100663646);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000F044 File Offset: 0x0000D244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153638, XrefRangeEnd = 153639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeStoreProvider.NativeMethodInfoPtr_GetAndroidStore_Public_Virtual_Final_New_INativeStore_IUnityCallback_AppStore_IPurchasingBinder_IUtil_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<INativeStore>(intPtr3) : null;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000F0C8 File Offset: 0x0000D2C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153724, RefRangeEnd = 153725, XrefRangeStart = 153639, XrefRangeEnd = 153724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe INativeStore GetAndroidStoreHelper(IUnityCallback callback, AppStore store, IPurchasingBinder binder, IUtil util)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeStoreProvider.NativeMethodInfoPtr_GetAndroidStoreHelper_Private_INativeStore_IUnityCallback_AppStore_IPurchasingBinder_IUtil_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<INativeStore>(intPtr3) : null;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000F14C File Offset: 0x0000D34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153725, XrefRangeEnd = 153732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual INativeAppleStore GetStorekit(IUnityCallback callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeStoreProvider.NativeMethodInfoPtr_GetStorekit_Public_Virtual_Final_New_INativeAppleStore_IUnityCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<INativeAppleStore>(intPtr3) : null;
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000F19C File Offset: 0x0000D39C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeStoreProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeStoreProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeStoreProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x000035B8 File Offset: 0x000017B8
		public NativeStoreProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_GetAndroidStore_Public_Virtual_Final_New_INativeStore_IUnityCallback_AppStore_IPurchasingBinder_IUtil_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_GetAndroidStoreHelper_Private_INativeStore_IUnityCallback_AppStore_IPurchasingBinder_IUtil_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_GetStorekit_Public_Virtual_Final_New_INativeAppleStore_IUnityCallback_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

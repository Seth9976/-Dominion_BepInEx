using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000031 RID: 49
	public static class StoreCallbackExtensionMethods : Object
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x00002D08 File Offset: 0x00000F08
		// Note: this type is marked as 'beforefieldinit'.
		static StoreCallbackExtensionMethods()
		{
			Il2CppClassPointerStore<StoreCallbackExtensionMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "StoreCallbackExtensionMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoreCallbackExtensionMethods>.NativeClassPtr);
			StoreCallbackExtensionMethods.NativeMethodInfoPtr_FindProductById_Public_Static_Product_IStoreCallback_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreCallbackExtensionMethods>.NativeClassPtr, 100663506);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000B994 File Offset: 0x00009B94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151786, RefRangeEnd = 151787, XrefRangeStart = 151777, XrefRangeEnd = 151786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Product FindProductById(this IStoreCallback storeCallback, string sku)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(storeCallback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sku);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreCallbackExtensionMethods.NativeMethodInfoPtr_FindProductById_Public_Static_Product_IStoreCallback_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Product>(intPtr3) : null;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002D41 File Offset: 0x00000F41
		public StoreCallbackExtensionMethods(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_FindProductById_Public_Static_Product_IStoreCallback_String_0;
	}
}

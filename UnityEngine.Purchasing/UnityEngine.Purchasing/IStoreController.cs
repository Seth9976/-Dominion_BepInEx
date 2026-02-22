using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000009 RID: 9
	public class IStoreController : Il2CppObjectBase
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00003500 File Offset: 0x00001700
		// Note: this type is marked as 'beforefieldinit'.
		static IStoreController()
		{
			Il2CppClassPointerStore<IStoreController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "IStoreController");
			IStoreController.NativeMethodInfoPtr_get_products_Public_Abstract_Virtual_New_get_ProductCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStoreController>.NativeClassPtr, 100663317);
			IStoreController.NativeMethodInfoPtr_InitiatePurchase_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStoreController>.NativeClassPtr, 100663318);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00003550 File Offset: 0x00001750
		public unsafe virtual ProductCollection products
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStoreController.NativeMethodInfoPtr_get_products_Public_Abstract_Virtual_New_get_ProductCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductCollection>(intPtr3) : null;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000359C File Offset: 0x0000179C
		[CallerCount(0)]
		public unsafe virtual void InitiatePurchase(string productId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStoreController.NativeMethodInfoPtr_InitiatePurchase_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002184 File Offset: 0x00000384
		public IStoreController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_products_Public_Abstract_Virtual_New_get_ProductCollection_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_InitiatePurchase_Public_Abstract_Virtual_New_Void_String_0;
	}
}

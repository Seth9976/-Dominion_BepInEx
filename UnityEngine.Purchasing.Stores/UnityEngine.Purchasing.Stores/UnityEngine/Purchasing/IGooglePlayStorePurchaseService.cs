using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200002A RID: 42
	public class IGooglePlayStorePurchaseService : Il2CppObjectBase
	{
		// Token: 0x06000160 RID: 352 RVA: 0x00002A8F File Offset: 0x00000C8F
		// Note: this type is marked as 'beforefieldinit'.
		static IGooglePlayStorePurchaseService()
		{
			Il2CppClassPointerStore<IGooglePlayStorePurchaseService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "IGooglePlayStorePurchaseService");
			IGooglePlayStorePurchaseService.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePlayStorePurchaseService>.NativeClassPtr, 100663463);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000A718 File Offset: 0x00008918
		[CallerCount(0)]
		public unsafe virtual void Purchase(ProductDefinition product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePlayStorePurchaseService.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_ProductDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002ABE File Offset: 0x00000CBE
		public IGooglePlayStorePurchaseService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_ProductDefinition_0;
	}
}

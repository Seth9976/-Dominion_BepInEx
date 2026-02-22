using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x02000091 RID: 145
	public class IGooglePurchaseService : Il2CppObjectBase
	{
		// Token: 0x060005A8 RID: 1448 RVA: 0x00004D28 File Offset: 0x00002F28
		// Note: this type is marked as 'beforefieldinit'.
		static IGooglePurchaseService()
		{
			Il2CppClassPointerStore<IGooglePurchaseService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Interfaces", "IGooglePurchaseService");
			IGooglePurchaseService.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_ProductDefinition_Product_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGooglePurchaseService>.NativeClassPtr, 100663989);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00018AC0 File Offset: 0x00016CC0
		[CallerCount(0)]
		public unsafe virtual void Purchase(ProductDefinition product, Product oldProduct, int desiredProrationMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldProduct);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desiredProrationMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGooglePurchaseService.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_ProductDefinition_Product_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00004D57 File Offset: 0x00002F57
		public IGooglePurchaseService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_ProductDefinition_Product_Int32_0;
	}
}

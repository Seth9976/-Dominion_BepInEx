using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200006C RID: 108
	public class IProductCatalogImpl : Il2CppObjectBase
	{
		// Token: 0x060003DA RID: 986 RVA: 0x00003F78 File Offset: 0x00002178
		// Note: this type is marked as 'beforefieldinit'.
		static IProductCatalogImpl()
		{
			Il2CppClassPointerStore<IProductCatalogImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "IProductCatalogImpl");
			IProductCatalogImpl.NativeMethodInfoPtr_LoadDefaultCatalog_Public_Abstract_Virtual_New_ProductCatalog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProductCatalogImpl>.NativeClassPtr, 100663767);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00012788 File Offset: 0x00010988
		[CallerCount(0)]
		public unsafe virtual ProductCatalog LoadDefaultCatalog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IProductCatalogImpl.NativeMethodInfoPtr_LoadDefaultCatalog_Public_Abstract_Virtual_New_ProductCatalog_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductCatalog>(intPtr3) : null;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00003FA7 File Offset: 0x000021A7
		public IProductCatalogImpl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_LoadDefaultCatalog_Public_Abstract_Virtual_New_ProductCatalog_0;
	}
}

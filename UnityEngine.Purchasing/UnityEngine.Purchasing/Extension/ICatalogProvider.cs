using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x02000021 RID: 33
	public class ICatalogProvider : Il2CppObjectBase
	{
		// Token: 0x06000135 RID: 309 RVA: 0x0000285B File Offset: 0x00000A5B
		// Note: this type is marked as 'beforefieldinit'.
		static ICatalogProvider()
		{
			Il2CppClassPointerStore<ICatalogProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing.Extension", "ICatalogProvider");
			ICatalogProvider.NativeMethodInfoPtr_FetchProducts_Public_Abstract_Virtual_New_Void_Action_1_HashSet_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICatalogProvider>.NativeClassPtr, 100663457);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000074C8 File Offset: 0x000056C8
		[CallerCount(0)]
		public unsafe virtual void FetchProducts(Action<HashSet<ProductDefinition>> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICatalogProvider.NativeMethodInfoPtr_FetchProducts_Public_Abstract_Virtual_New_Void_Action_1_HashSet_1_ProductDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000288A File Offset: 0x00000A8A
		public ICatalogProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_FetchProducts_Public_Abstract_Virtual_New_Void_Action_1_HashSet_1_ProductDefinition_0;
	}
}

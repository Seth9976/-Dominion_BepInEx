using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Purchasing.Models;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x02000093 RID: 147
	public class IGoogleQueryPurchasesService : Il2CppObjectBase
	{
		// Token: 0x060005AD RID: 1453 RVA: 0x00004D84 File Offset: 0x00002F84
		// Note: this type is marked as 'beforefieldinit'.
		static IGoogleQueryPurchasesService()
		{
			Il2CppClassPointerStore<IGoogleQueryPurchasesService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Interfaces", "IGoogleQueryPurchasesService");
			IGoogleQueryPurchasesService.NativeMethodInfoPtr_QueryPurchases_Public_Abstract_Virtual_New_Void_Action_1_List_1_GooglePurchase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGoogleQueryPurchasesService>.NativeClassPtr, 100663990);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00018B30 File Offset: 0x00016D30
		[CallerCount(0)]
		public unsafe virtual void QueryPurchases(Action<List<GooglePurchase>> onQueryPurchaseSucceed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onQueryPurchaseSucceed);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGoogleQueryPurchasesService.NativeMethodInfoPtr_QueryPurchases_Public_Abstract_Virtual_New_Void_Action_1_List_1_GooglePurchase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00004DB3 File Offset: 0x00002FB3
		public IGoogleQueryPurchasesService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_QueryPurchases_Public_Abstract_Virtual_New_Void_Action_1_List_1_GooglePurchase_0;
	}
}

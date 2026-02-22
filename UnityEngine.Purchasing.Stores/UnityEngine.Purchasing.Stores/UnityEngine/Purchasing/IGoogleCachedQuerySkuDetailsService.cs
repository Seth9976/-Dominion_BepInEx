using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000013 RID: 19
	public class IGoogleCachedQuerySkuDetailsService : Il2CppObjectBase
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00007C78 File Offset: 0x00005E78
		// Note: this type is marked as 'beforefieldinit'.
		static IGoogleCachedQuerySkuDetailsService()
		{
			Il2CppClassPointerStore<IGoogleCachedQuerySkuDetailsService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "IGoogleCachedQuerySkuDetailsService");
			IGoogleCachedQuerySkuDetailsService.NativeMethodInfoPtr_GetCachedQueriedSkus_Public_Abstract_Virtual_New_HashSet_1_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGoogleCachedQuerySkuDetailsService>.NativeClassPtr, 100663376);
			IGoogleCachedQuerySkuDetailsService.NativeMethodInfoPtr_AddCachedQueriedSkus_Public_Abstract_Virtual_New_Void_List_1_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGoogleCachedQuerySkuDetailsService>.NativeClassPtr, 100663377);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00007CC8 File Offset: 0x00005EC8
		[CallerCount(0)]
		public unsafe virtual HashSet<AndroidJavaObject> GetCachedQueriedSkus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGoogleCachedQuerySkuDetailsService.NativeMethodInfoPtr_GetCachedQueriedSkus_Public_Abstract_Virtual_New_HashSet_1_AndroidJavaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<AndroidJavaObject>>(intPtr3) : null;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00007D14 File Offset: 0x00005F14
		[CallerCount(0)]
		public unsafe virtual void AddCachedQueriedSkus(List<AndroidJavaObject> queriedSkus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(queriedSkus);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGoogleCachedQuerySkuDetailsService.NativeMethodInfoPtr_AddCachedQueriedSkus_Public_Abstract_Virtual_New_Void_List_1_AndroidJavaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002486 File Offset: 0x00000686
		public IGoogleCachedQuerySkuDetailsService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedQueriedSkus_Public_Abstract_Virtual_New_HashSet_1_AndroidJavaObject_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_AddCachedQueriedSkus_Public_Abstract_Virtual_New_Void_List_1_AndroidJavaObject_0;
	}
}

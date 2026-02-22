using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x02000094 RID: 148
	public class IQuerySkuDetailsService : Il2CppObjectBase
	{
		// Token: 0x060005B0 RID: 1456 RVA: 0x00018B80 File Offset: 0x00016D80
		// Note: this type is marked as 'beforefieldinit'.
		static IQuerySkuDetailsService()
		{
			Il2CppClassPointerStore<IQuerySkuDetailsService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Interfaces", "IQuerySkuDetailsService");
			IQuerySkuDetailsService.NativeMethodInfoPtr_QueryAsyncSku_Public_Abstract_Virtual_New_Void_ProductDefinition_Action_1_List_1_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IQuerySkuDetailsService>.NativeClassPtr, 100663991);
			IQuerySkuDetailsService.NativeMethodInfoPtr_QueryAsyncSku_Public_Abstract_Virtual_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_ProductDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IQuerySkuDetailsService>.NativeClassPtr, 100663992);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00018BD0 File Offset: 0x00016DD0
		[CallerCount(0)]
		public unsafe virtual void QueryAsyncSku(ProductDefinition product, Action<List<AndroidJavaObject>> onSkuDetailsResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onSkuDetailsResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IQuerySkuDetailsService.NativeMethodInfoPtr_QueryAsyncSku_Public_Abstract_Virtual_New_Void_ProductDefinition_Action_1_List_1_AndroidJavaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00018C30 File Offset: 0x00016E30
		[CallerCount(0)]
		public unsafe virtual void QueryAsyncSku(ReadOnlyCollection<ProductDefinition> products, Action<List<ProductDescription>> onSkuDetailsResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onSkuDetailsResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IQuerySkuDetailsService.NativeMethodInfoPtr_QueryAsyncSku_Public_Abstract_Virtual_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_ProductDescription_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00004DBC File Offset: 0x00002FBC
		public IQuerySkuDetailsService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_QueryAsyncSku_Public_Abstract_Virtual_New_Void_ProductDefinition_Action_1_List_1_AndroidJavaObject_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_QueryAsyncSku_Public_Abstract_Virtual_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_1_List_1_ProductDescription_0;
	}
}

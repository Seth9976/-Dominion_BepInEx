using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.ObjectModel;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200003E RID: 62
	public class INativeUDPStore : Il2CppObjectBase
	{
		// Token: 0x060001F0 RID: 496 RVA: 0x0000C458 File Offset: 0x0000A658
		// Note: this type is marked as 'beforefieldinit'.
		static INativeUDPStore()
		{
			Il2CppClassPointerStore<INativeUDPStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "INativeUDPStore");
			INativeUDPStore.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_Action_2_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INativeUDPStore>.NativeClassPtr, 100663540);
			INativeUDPStore.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_String_Action_2_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INativeUDPStore>.NativeClassPtr, 100663541);
			INativeUDPStore.NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_2_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INativeUDPStore>.NativeClassPtr, 100663542);
			INativeUDPStore.NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INativeUDPStore>.NativeClassPtr, 100663543);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000C4D0 File Offset: 0x0000A6D0
		[CallerCount(0)]
		public unsafe virtual void Initialize(Action<bool, string> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INativeUDPStore.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_Action_2_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000C520 File Offset: 0x0000A720
		[CallerCount(0)]
		public unsafe virtual void Purchase(string productId, Action<bool, string> callback, string developerPayload = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(developerPayload);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INativeUDPStore.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_String_Action_2_Boolean_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000C594 File Offset: 0x0000A794
		[CallerCount(0)]
		public unsafe virtual void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products, Action<bool, string> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INativeUDPStore.NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_2_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000C5F4 File Offset: 0x0000A7F4
		[CallerCount(0)]
		public unsafe virtual void FinishTransaction(ProductDefinition productDefinition, string transactionID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(productDefinition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INativeUDPStore.NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_ProductDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002F87 File Offset: 0x00001187
		public INativeUDPStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_Action_2_Boolean_String_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_String_Action_2_Boolean_String_String_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_ReadOnlyCollection_1_ProductDefinition_Action_2_Boolean_String_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_ProductDefinition_String_0;
	}
}

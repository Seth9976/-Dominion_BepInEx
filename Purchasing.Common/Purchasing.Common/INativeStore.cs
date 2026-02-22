using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000002 RID: 2
	public class INativeStore : Il2CppObjectBase
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020F4 File Offset: 0x000002F4
		// Note: this type is marked as 'beforefieldinit'.
		static INativeStore()
		{
			Il2CppClassPointerStore<INativeStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("Purchasing.Common.dll", "UnityEngine.Purchasing", "INativeStore");
			INativeStore.NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INativeStore>.NativeClassPtr, 100663297);
			INativeStore.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INativeStore>.NativeClassPtr, 100663298);
			INativeStore.NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INativeStore>.NativeClassPtr, 100663299);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002158 File Offset: 0x00000358
		[CallerCount(0)]
		public unsafe virtual void RetrieveProducts(string json)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INativeStore.NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000021A8 File Offset: 0x000003A8
		[CallerCount(0)]
		public unsafe virtual void Purchase(string productJSON, string developerPayload)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productJSON);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(developerPayload);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INativeStore.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002208 File Offset: 0x00000408
		[CallerCount(0)]
		public unsafe virtual void FinishTransaction(string productJSON, string transactionID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productJSON);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INativeStore.NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		public INativeStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_String_String_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Abstract_Virtual_New_Void_String_String_0;
	}
}

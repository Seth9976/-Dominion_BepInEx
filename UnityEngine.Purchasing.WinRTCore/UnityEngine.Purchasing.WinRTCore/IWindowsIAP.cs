using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing.Default
{
	// Token: 0x02000003 RID: 3
	public class IWindowsIAP : Il2CppObjectBase
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002198 File Offset: 0x00000398
		// Note: this type is marked as 'beforefieldinit'.
		static IWindowsIAP()
		{
			Il2CppClassPointerStore<IWindowsIAP>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.WinRTCore.dll", "UnityEngine.Purchasing.Default", "IWindowsIAP");
			IWindowsIAP.NativeMethodInfoPtr_BuildDummyProducts_Public_Abstract_Virtual_New_Void_List_1_WinProductDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWindowsIAP>.NativeClassPtr, 100663297);
			IWindowsIAP.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_IWindowsIAPCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWindowsIAP>.NativeClassPtr, 100663298);
			IWindowsIAP.NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWindowsIAP>.NativeClassPtr, 100663299);
			IWindowsIAP.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWindowsIAP>.NativeClassPtr, 100663300);
			IWindowsIAP.NativeMethodInfoPtr_FinaliseTransaction_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWindowsIAP>.NativeClassPtr, 100663301);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002224 File Offset: 0x00000424
		[CallerCount(0)]
		public unsafe virtual void BuildDummyProducts(List<WinProductDescription> products)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWindowsIAP.NativeMethodInfoPtr_BuildDummyProducts_Public_Abstract_Virtual_New_Void_List_1_WinProductDescription_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002274 File Offset: 0x00000474
		[CallerCount(0)]
		public unsafe virtual void Initialize(IWindowsIAPCallback callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWindowsIAP.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_IWindowsIAPCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000022C4 File Offset: 0x000004C4
		[CallerCount(0)]
		public unsafe virtual void RetrieveProducts(bool retryIfOffline)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref retryIfOffline;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWindowsIAP.NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002310 File Offset: 0x00000510
		[CallerCount(0)]
		public unsafe virtual void Purchase(string productId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWindowsIAP.NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002360 File Offset: 0x00000560
		[CallerCount(0)]
		public unsafe virtual void FinaliseTransaction(string transactionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(transactionId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWindowsIAP.NativeMethodInfoPtr_FinaliseTransaction_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002074 File Offset: 0x00000274
		public IWindowsIAP(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_BuildDummyProducts_Public_Abstract_Virtual_New_Void_List_1_WinProductDescription_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_IWindowsIAPCallback_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducts_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Abstract_Virtual_New_Void_String_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_FinaliseTransaction_Public_Abstract_Virtual_New_Void_String_0;
	}
}

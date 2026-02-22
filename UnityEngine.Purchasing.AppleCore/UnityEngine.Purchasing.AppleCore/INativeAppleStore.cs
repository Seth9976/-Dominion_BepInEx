using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000002 RID: 2
	public class INativeAppleStore : Il2CppObjectBase
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000205C File Offset: 0x0000025C
		// Note: this type is marked as 'beforefieldinit'.
		static INativeAppleStore()
		{
			Il2CppClassPointerStore<INativeAppleStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.AppleCore.dll", "UnityEngine.Purchasing", "INativeAppleStore");
			INativeAppleStore.NativeMethodInfoPtr_SetUnityPurchasingCallback_Public_Abstract_Virtual_New_Void_UnityPurchasingCallback_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INativeAppleStore>.NativeClassPtr, 100663297);
			INativeAppleStore.NativeMethodInfoPtr_RestoreTransactions_Public_Abstract_Virtual_New_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INativeAppleStore>.NativeClassPtr, 100663298);
			INativeAppleStore.NativeMethodInfoPtr_AddTransactionObserver_Public_Abstract_Virtual_New_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INativeAppleStore>.NativeClassPtr, 100663299);
			INativeAppleStore.NativeMethodInfoPtr_get_appReceipt_Public_Abstract_Virtual_New_get_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INativeAppleStore>.NativeClassPtr, 100663300);
			INativeAppleStore.NativeMethodInfoPtr_InterceptPromotionalPurchases_Public_Abstract_Virtual_New_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INativeAppleStore>.NativeClassPtr, 100663301);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020E8 File Offset: 0x000002E8
		[CallerCount(0)]
		public unsafe virtual void SetUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(AsyncCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INativeAppleStore.NativeMethodInfoPtr_SetUnityPurchasingCallback_Public_Abstract_Virtual_New_Void_UnityPurchasingCallback_PDM_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002138 File Offset: 0x00000338
		[CallerCount(0)]
		public unsafe virtual void RestoreTransactions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INativeAppleStore.NativeMethodInfoPtr_RestoreTransactions_Public_Abstract_Virtual_New_Void_PDM_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002174 File Offset: 0x00000374
		[CallerCount(0)]
		public unsafe virtual void AddTransactionObserver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INativeAppleStore.NativeMethodInfoPtr_AddTransactionObserver_Public_Abstract_Virtual_New_Void_PDM_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000021B0 File Offset: 0x000003B0
		public unsafe virtual string appReceipt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INativeAppleStore.NativeMethodInfoPtr_get_appReceipt_Public_Abstract_Virtual_New_get_String_PDM_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021F4 File Offset: 0x000003F4
		[CallerCount(0)]
		public unsafe virtual void InterceptPromotionalPurchases()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INativeAppleStore.NativeMethodInfoPtr_InterceptPromotionalPurchases_Public_Abstract_Virtual_New_Void_PDM_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		public INativeAppleStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_SetUnityPurchasingCallback_Public_Abstract_Virtual_New_Void_UnityPurchasingCallback_PDM_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_RestoreTransactions_Public_Abstract_Virtual_New_Void_PDM_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_AddTransactionObserver_Public_Abstract_Virtual_New_Void_PDM_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_get_appReceipt_Public_Abstract_Virtual_New_get_String_PDM_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_InterceptPromotionalPurchases_Public_Abstract_Virtual_New_Void_PDM_0;
	}
}

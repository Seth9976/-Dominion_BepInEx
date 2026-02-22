using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000007 RID: 7
	public class IInternalStoreListener : Il2CppObjectBase
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00003338 File Offset: 0x00001538
		// Note: this type is marked as 'beforefieldinit'.
		static IInternalStoreListener()
		{
			Il2CppClassPointerStore<IInternalStoreListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "IInternalStoreListener");
			IInternalStoreListener.NativeMethodInfoPtr_OnInitializeFailed_Public_Abstract_Virtual_New_Void_InitializationFailureReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalStoreListener>.NativeClassPtr, 100663313);
			IInternalStoreListener.NativeMethodInfoPtr_ProcessPurchase_Public_Abstract_Virtual_New_PurchaseProcessingResult_PurchaseEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalStoreListener>.NativeClassPtr, 100663314);
			IInternalStoreListener.NativeMethodInfoPtr_OnPurchaseFailed_Public_Abstract_Virtual_New_Void_Product_PurchaseFailureReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalStoreListener>.NativeClassPtr, 100663315);
			IInternalStoreListener.NativeMethodInfoPtr_OnInitialized_Public_Abstract_Virtual_New_Void_IStoreController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInternalStoreListener>.NativeClassPtr, 100663316);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000033B0 File Offset: 0x000015B0
		[CallerCount(0)]
		public unsafe virtual void OnInitializeFailed(InitializationFailureReason error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInternalStoreListener.NativeMethodInfoPtr_OnInitializeFailed_Public_Abstract_Virtual_New_Void_InitializationFailureReason_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000033FC File Offset: 0x000015FC
		[CallerCount(0)]
		public unsafe virtual PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInternalStoreListener.NativeMethodInfoPtr_ProcessPurchase_Public_Abstract_Virtual_New_PurchaseProcessingResult_PurchaseEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003454 File Offset: 0x00001654
		[CallerCount(0)]
		public unsafe virtual void OnPurchaseFailed(Product i, PurchaseFailureReason p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInternalStoreListener.NativeMethodInfoPtr_OnPurchaseFailed_Public_Abstract_Virtual_New_Void_Product_PurchaseFailureReason_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000034B0 File Offset: 0x000016B0
		[CallerCount(0)]
		public unsafe virtual void OnInitialized(IStoreController controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IInternalStoreListener.NativeMethodInfoPtr_OnInitialized_Public_Abstract_Virtual_New_Void_IStoreController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000217B File Offset: 0x0000037B
		public IInternalStoreListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_OnInitializeFailed_Public_Abstract_Virtual_New_Void_InitializationFailureReason_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPurchase_Public_Abstract_Virtual_New_PurchaseProcessingResult_PurchaseEventArgs_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseFailed_Public_Abstract_Virtual_New_Void_Product_PurchaseFailureReason_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialized_Public_Abstract_Virtual_New_Void_IStoreController_0;
	}
}

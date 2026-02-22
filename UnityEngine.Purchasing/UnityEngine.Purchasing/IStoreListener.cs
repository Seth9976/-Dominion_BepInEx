using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000A RID: 10
	public class IStoreListener : Il2CppObjectBase
	{
		// Token: 0x06000031 RID: 49 RVA: 0x000035EC File Offset: 0x000017EC
		// Note: this type is marked as 'beforefieldinit'.
		static IStoreListener()
		{
			Il2CppClassPointerStore<IStoreListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "IStoreListener");
			IStoreListener.NativeMethodInfoPtr_OnInitializeFailed_Public_Abstract_Virtual_New_Void_InitializationFailureReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStoreListener>.NativeClassPtr, 100663319);
			IStoreListener.NativeMethodInfoPtr_ProcessPurchase_Public_Abstract_Virtual_New_PurchaseProcessingResult_PurchaseEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStoreListener>.NativeClassPtr, 100663320);
			IStoreListener.NativeMethodInfoPtr_OnPurchaseFailed_Public_Abstract_Virtual_New_Void_Product_PurchaseFailureReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStoreListener>.NativeClassPtr, 100663321);
			IStoreListener.NativeMethodInfoPtr_OnInitialized_Public_Abstract_Virtual_New_Void_IStoreController_IExtensionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStoreListener>.NativeClassPtr, 100663322);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003664 File Offset: 0x00001864
		[CallerCount(0)]
		public unsafe virtual void OnInitializeFailed(InitializationFailureReason error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStoreListener.NativeMethodInfoPtr_OnInitializeFailed_Public_Abstract_Virtual_New_Void_InitializationFailureReason_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000036B0 File Offset: 0x000018B0
		[CallerCount(0)]
		public unsafe virtual PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs purchaseEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchaseEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStoreListener.NativeMethodInfoPtr_ProcessPurchase_Public_Abstract_Virtual_New_PurchaseProcessingResult_PurchaseEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003708 File Offset: 0x00001908
		[CallerCount(0)]
		public unsafe virtual void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref failureReason;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStoreListener.NativeMethodInfoPtr_OnPurchaseFailed_Public_Abstract_Virtual_New_Void_Product_PurchaseFailureReason_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003764 File Offset: 0x00001964
		[CallerCount(0)]
		public unsafe virtual void OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extensions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStoreListener.NativeMethodInfoPtr_OnInitialized_Public_Abstract_Virtual_New_Void_IStoreController_IExtensionProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000218D File Offset: 0x0000038D
		public IStoreListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_OnInitializeFailed_Public_Abstract_Virtual_New_Void_InitializationFailureReason_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_ProcessPurchase_Public_Abstract_Virtual_New_PurchaseProcessingResult_PurchaseEventArgs_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseFailed_Public_Abstract_Virtual_New_Void_Product_PurchaseFailureReason_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialized_Public_Abstract_Virtual_New_Void_IStoreController_IExtensionProvider_0;
	}
}

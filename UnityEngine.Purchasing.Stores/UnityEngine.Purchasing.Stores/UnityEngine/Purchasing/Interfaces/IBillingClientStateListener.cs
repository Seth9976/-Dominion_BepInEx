using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Purchasing.Interfaces
{
	// Token: 0x0200008B RID: 139
	public class IBillingClientStateListener : Il2CppObjectBase
	{
		// Token: 0x06000584 RID: 1412 RVA: 0x00017F40 File Offset: 0x00016140
		// Note: this type is marked as 'beforefieldinit'.
		static IBillingClientStateListener()
		{
			Il2CppClassPointerStore<IBillingClientStateListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Interfaces", "IBillingClientStateListener");
			IBillingClientStateListener.NativeMethodInfoPtr_RegisterOnConnected_Public_Abstract_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBillingClientStateListener>.NativeClassPtr, 100663965);
			IBillingClientStateListener.NativeMethodInfoPtr_RegisterOnDisconnected_Public_Abstract_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IBillingClientStateListener>.NativeClassPtr, 100663966);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00017F90 File Offset: 0x00016190
		[CallerCount(0)]
		public unsafe virtual void RegisterOnConnected(Action onConnected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onConnected);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBillingClientStateListener.NativeMethodInfoPtr_RegisterOnConnected_Public_Abstract_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00017FE0 File Offset: 0x000161E0
		[CallerCount(0)]
		public unsafe virtual void RegisterOnDisconnected(Action onDisconnected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(onDisconnected);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IBillingClientStateListener.NativeMethodInfoPtr_RegisterOnDisconnected_Public_Abstract_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00004CC3 File Offset: 0x00002EC3
		public IBillingClientStateListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_RegisterOnConnected_Public_Abstract_Virtual_New_Void_Action_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_RegisterOnDisconnected_Public_Abstract_Virtual_New_Void_Action_0;
	}
}

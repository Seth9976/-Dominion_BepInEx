using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000050 RID: 80
	public class IStoreInternal : Il2CppObjectBase
	{
		// Token: 0x06000285 RID: 645 RVA: 0x00003359 File Offset: 0x00001559
		// Note: this type is marked as 'beforefieldinit'.
		static IStoreInternal()
		{
			Il2CppClassPointerStore<IStoreInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "IStoreInternal");
			IStoreInternal.NativeMethodInfoPtr_SetModule_Public_Abstract_Virtual_New_Void_StandardPurchasingModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStoreInternal>.NativeClassPtr, 100663625);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000E410 File Offset: 0x0000C610
		[CallerCount(0)]
		public unsafe virtual void SetModule(StandardPurchasingModule module)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStoreInternal.NativeMethodInfoPtr_SetModule_Public_Abstract_Virtual_New_Void_StandardPurchasingModule_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00003388 File Offset: 0x00001588
		public IStoreInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_SetModule_Public_Abstract_Virtual_New_Void_StandardPurchasingModule_0;
	}
}

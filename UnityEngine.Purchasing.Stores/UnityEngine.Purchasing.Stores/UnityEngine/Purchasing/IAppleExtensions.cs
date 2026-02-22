using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200004D RID: 77
	public class IAppleExtensions : Il2CppObjectBase
	{
		// Token: 0x0600027E RID: 638 RVA: 0x00003318 File Offset: 0x00001518
		// Note: this type is marked as 'beforefieldinit'.
		static IAppleExtensions()
		{
			Il2CppClassPointerStore<IAppleExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "IAppleExtensions");
			IAppleExtensions.NativeMethodInfoPtr_RestoreTransactions_Public_Abstract_Virtual_New_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAppleExtensions>.NativeClassPtr, 100663622);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000E284 File Offset: 0x0000C484
		[CallerCount(0)]
		public unsafe virtual void RestoreTransactions(Action<bool> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAppleExtensions.NativeMethodInfoPtr_RestoreTransactions_Public_Abstract_Virtual_New_Void_Action_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00003347 File Offset: 0x00001547
		public IAppleExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_RestoreTransactions_Public_Abstract_Virtual_New_Void_Action_1_Boolean_0;
	}
}

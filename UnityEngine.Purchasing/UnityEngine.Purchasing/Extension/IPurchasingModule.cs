using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x02000023 RID: 35
	public class IPurchasingModule : Il2CppObjectBase
	{
		// Token: 0x0600013E RID: 318 RVA: 0x0000289C File Offset: 0x00000A9C
		// Note: this type is marked as 'beforefieldinit'.
		static IPurchasingModule()
		{
			Il2CppClassPointerStore<IPurchasingModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing.Extension", "IPurchasingModule");
			IPurchasingModule.NativeMethodInfoPtr_Configure_Public_Abstract_Virtual_New_Void_IPurchasingBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPurchasingModule>.NativeClassPtr, 100663462);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00007748 File Offset: 0x00005948
		[CallerCount(0)]
		public unsafe virtual void Configure(IPurchasingBinder binder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPurchasingModule.NativeMethodInfoPtr_Configure_Public_Abstract_Virtual_New_Void_IPurchasingBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000028CB File Offset: 0x00000ACB
		public IPurchasingModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Abstract_Virtual_New_Void_IPurchasingBinder_0;
	}
}

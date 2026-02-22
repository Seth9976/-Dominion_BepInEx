using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003CD RID: 973
	public class ISecurableChannel : Il2CppObjectBase
	{
		// Token: 0x06003E51 RID: 15953 RVA: 0x000177CD File Offset: 0x000159CD
		// Note: this type is marked as 'beforefieldinit'.
		static ISecurableChannel()
		{
			Il2CppClassPointerStore<ISecurableChannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "ISecurableChannel");
			ISecurableChannel.NativeMethodInfoPtr_set_IsSecured_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISecurableChannel>.NativeClassPtr, 100672454);
		}

		// Token: 0x17000FA0 RID: 4000
		// (set) Token: 0x06003E52 RID: 15954 RVA: 0x001234EC File Offset: 0x001216EC
		public unsafe virtual bool IsSecured
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISecurableChannel.NativeMethodInfoPtr_set_IsSecured_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x000177FC File Offset: 0x000159FC
		public ISecurableChannel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003364 RID: 13156
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSecured_Public_Abstract_Virtual_New_set_Void_Boolean_0;
	}
}

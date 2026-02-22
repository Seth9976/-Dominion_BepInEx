using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Activation
{
	// Token: 0x020003D4 RID: 980
	public class IActivator : Il2CppObjectBase
	{
		// Token: 0x06003E83 RID: 16003 RVA: 0x00123F78 File Offset: 0x00122178
		// Note: this type is marked as 'beforefieldinit'.
		static IActivator()
		{
			Il2CppClassPointerStore<IActivator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "IActivator");
			IActivator.NativeMethodInfoPtr_get_NextActivator_Public_Abstract_Virtual_New_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IActivator>.NativeClassPtr, 100672476);
			IActivator.NativeMethodInfoPtr_Activate_Public_Abstract_Virtual_New_IConstructionReturnMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IActivator>.NativeClassPtr, 100672477);
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x06003E84 RID: 16004 RVA: 0x00123FC8 File Offset: 0x001221C8
		public unsafe virtual IActivator NextActivator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IActivator.NativeMethodInfoPtr_get_NextActivator_Public_Abstract_Virtual_New_get_IActivator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
			}
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x00124014 File Offset: 0x00122214
		[CallerCount(0)]
		public unsafe virtual IConstructionReturnMessage Activate(IConstructionCallMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IActivator.NativeMethodInfoPtr_Activate_Public_Abstract_Virtual_New_IConstructionReturnMessage_IConstructionCallMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConstructionReturnMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x00017936 File Offset: 0x00015B36
		public IActivator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003381 RID: 13185
		private static readonly IntPtr NativeMethodInfoPtr_get_NextActivator_Public_Abstract_Virtual_New_get_IActivator_0;

		// Token: 0x04003382 RID: 13186
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Abstract_Virtual_New_IConstructionReturnMessage_IConstructionCallMessage_0;
	}
}

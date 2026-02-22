using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003FB RID: 1019
	public class IMethodReturnMessage : Il2CppObjectBase
	{
		// Token: 0x06004023 RID: 16419 RVA: 0x001299C4 File Offset: 0x00127BC4
		// Note: this type is marked as 'beforefieldinit'.
		static IMethodReturnMessage()
		{
			Il2CppClassPointerStore<IMethodReturnMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "IMethodReturnMessage");
			IMethodReturnMessage.NativeMethodInfoPtr_get_Exception_Public_Abstract_Virtual_New_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodReturnMessage>.NativeClassPtr, 100672661);
			IMethodReturnMessage.NativeMethodInfoPtr_get_OutArgs_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodReturnMessage>.NativeClassPtr, 100672662);
			IMethodReturnMessage.NativeMethodInfoPtr_get_ReturnValue_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMethodReturnMessage>.NativeClassPtr, 100672663);
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x06004024 RID: 16420 RVA: 0x00129A28 File Offset: 0x00127C28
		public unsafe virtual Exception Exception
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodReturnMessage.NativeMethodInfoPtr_get_Exception_Public_Abstract_Virtual_New_get_Exception_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x06004025 RID: 16421 RVA: 0x00129A74 File Offset: 0x00127C74
		public unsafe virtual Il2CppReferenceArray<Object> OutArgs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodReturnMessage.NativeMethodInfoPtr_get_OutArgs_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x06004026 RID: 16422 RVA: 0x00129AC0 File Offset: 0x00127CC0
		public unsafe virtual Object ReturnValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMethodReturnMessage.NativeMethodInfoPtr_get_ReturnValue_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004027 RID: 16423 RVA: 0x000184C5 File Offset: 0x000166C5
		public IMethodReturnMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003485 RID: 13445
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_Abstract_Virtual_New_get_Exception_0;

		// Token: 0x04003486 RID: 13446
		private static readonly IntPtr NativeMethodInfoPtr_get_OutArgs_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003487 RID: 13447
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnValue_Public_Abstract_Virtual_New_get_Object_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000063 RID: 99
	public class IAsyncWebUtil : Il2CppObjectBase
	{
		// Token: 0x06000393 RID: 915 RVA: 0x00011BDC File Offset: 0x0000FDDC
		// Note: this type is marked as 'beforefieldinit'.
		static IAsyncWebUtil()
		{
			Il2CppClassPointerStore<IAsyncWebUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "IAsyncWebUtil");
			IAsyncWebUtil.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Void_String_Action_1_String_Action_1_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncWebUtil>.NativeClassPtr, 100663745);
			IAsyncWebUtil.NativeMethodInfoPtr_Schedule_Public_Abstract_Virtual_New_Void_Action_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncWebUtil>.NativeClassPtr, 100663746);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00011C2C File Offset: 0x0000FE2C
		[CallerCount(0)]
		public unsafe virtual void Get(string url, Action<string> responseHandler, Action<string> errorHandler, int maxTimeoutInSeconds = 30)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responseHandler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(errorHandler);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxTimeoutInSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncWebUtil.NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Void_String_Action_1_String_Action_1_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00011CAC File Offset: 0x0000FEAC
		[CallerCount(0)]
		public unsafe virtual void Schedule(Action a, int delayInSeconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayInSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncWebUtil.NativeMethodInfoPtr_Schedule_Public_Abstract_Virtual_New_Void_Action_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00003CBD File Offset: 0x00001EBD
		public IAsyncWebUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Abstract_Virtual_New_Void_String_Action_1_String_Action_1_String_Int32_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Public_Abstract_Virtual_New_Void_Action_Int32_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200041A RID: 1050
	public class IAsyncStateMachine : Il2CppObjectBase
	{
		// Token: 0x060041CD RID: 16845 RVA: 0x0012FCAC File Offset: 0x0012DEAC
		// Note: this type is marked as 'beforefieldinit'.
		static IAsyncStateMachine()
		{
			Il2CppClassPointerStore<IAsyncStateMachine>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "IAsyncStateMachine");
			IAsyncStateMachine.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncStateMachine>.NativeClassPtr, 100672876);
			IAsyncStateMachine.NativeMethodInfoPtr_SetStateMachine_Public_Abstract_Virtual_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncStateMachine>.NativeClassPtr, 100672877);
		}

		// Token: 0x060041CE RID: 16846 RVA: 0x0012FCFC File Offset: 0x0012DEFC
		[CallerCount(0)]
		public unsafe virtual void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncStateMachine.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041CF RID: 16847 RVA: 0x0012FD38 File Offset: 0x0012DF38
		[CallerCount(0)]
		public unsafe virtual void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncStateMachine.NativeMethodInfoPtr_SetStateMachine_Public_Abstract_Virtual_New_Void_IAsyncStateMachine_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041D0 RID: 16848 RVA: 0x000190E1 File Offset: 0x000172E1
		public IAsyncStateMachine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040035A9 RID: 13737
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040035AA RID: 13738
		private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Public_Abstract_Virtual_New_Void_IAsyncStateMachine_0;
	}
}
